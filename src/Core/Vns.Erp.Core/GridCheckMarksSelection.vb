Imports System
Imports System.Drawing
Imports System.Collections
Imports System.Windows.Forms
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo

Public Class GridCheckMarksSelection
    Protected ViewValue As GridView
    Protected selection As ArrayList
    Private column As GridColumn
    Private edit As RepositoryItemCheckEdit
    Public IsEdited As Boolean = False
    Public Event CellValueChange(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs)

    Public Sub New()
        selection = New ArrayList
    End Sub

    Public Sub New(ByVal view As GridView)
        Me.New()
        Me.View = view
    End Sub

    Protected Overridable Sub Attach(ByVal view As GridView)
        If view Is Nothing Then
            Return
        End If
        selection.Clear()
        Me.ViewValue = view
        edit = view.GridControl.RepositoryItems.Add("CheckEdit") '
        AddHandler edit.EditValueChanged, AddressOf Edit_EditValueChanged

        column = view.Columns.Add()
        column.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False
        column.VisibleIndex = Integer.MaxValue
        column.FieldName = "CheckMarkSelection"
        column.Caption = "Mark"
        column.OptionsColumn.ShowCaption = False
        column.UnboundType = DevExpress.Data.UnboundColumnType.Boolean
        column.ColumnEdit = edit

        AddHandler view.Click, AddressOf View_Click
        AddHandler view.CustomDrawColumnHeader, AddressOf View_CustomDrawColumnHeader
        AddHandler view.CustomDrawGroupRow, AddressOf View_CustomDrawGroupRow
        AddHandler view.CustomUnboundColumnData, AddressOf view_CustomUnboundColumnData
        AddHandler view.RowStyle, AddressOf view_RowStyle
    End Sub

    Protected Overridable Sub Detach()
        If View Is Nothing Then
            Return
        End If
        If Not (column Is Nothing) Then
            column.Dispose()
        End If
        If Not (edit Is Nothing) Then
            View.GridControl.RepositoryItems.Remove(edit)
            edit.Dispose()
        End If
        RemoveHandler ViewValue.Click, AddressOf View_Click
        RemoveHandler ViewValue.CustomDrawColumnHeader, AddressOf View_CustomDrawColumnHeader
        RemoveHandler ViewValue.CustomDrawGroupRow, AddressOf View_CustomDrawGroupRow
        RemoveHandler ViewValue.CustomUnboundColumnData, (AddressOf view_CustomUnboundColumnData)
        RemoveHandler ViewValue.RowStyle, AddressOf view_RowStyle

        View = Nothing
    End Sub

    Protected Sub DrawCheckBox(ByVal g As Graphics, ByVal r As Rectangle, ByVal Checked As Boolean, ByVal Grayed As Boolean)
        Dim info As DevExpress.XtraEditors.ViewInfo.CheckEditViewInfo
        Dim painter As DevExpress.XtraEditors.Drawing.CheckEditPainter
        Dim args As DevExpress.XtraEditors.Drawing.ControlGraphicsInfoArgs
        info = edit.CreateViewInfo()
        painter = edit.CreatePainter()
        If Grayed Then
            info.EditValue = edit.ValueGrayed
        Else
            info.EditValue = Checked
        End If
        info.Bounds = r
        info.CalcViewInfo(g)
        args = New DevExpress.XtraEditors.Drawing.ControlGraphicsInfoArgs(info, New DevExpress.Utils.Drawing.GraphicsCache(g), r)
        painter.Draw(args)
        args.Cache.Dispose()
    End Sub

    Private Sub View_Click(ByVal sender As Object, ByVal e As EventArgs)
        If column.OptionsColumn.AllowEdit Then
            Dim info As GridHitInfo
            Dim pt As Point = View.GridControl.PointToClient(Control.MousePosition)
            info = View.CalcHitInfo(pt)
            If info.InColumn And info.Column Is column Then
                If SelectedCount = View.DataRowCount Then
                    ClearSelection()
                Else
                    SelectAll()
                End If
            End If
            If info.InRow And View.IsGroupRow(info.RowHandle) And info.HitTest <> GridHitTest.RowGroupButton Then
                Dim selected As Boolean = IsGroupRowSelected(info.RowHandle)
                SelectGroup(info.RowHandle, Not selected)
            End If
        End If
    End Sub

    Private Sub View_CustomDrawColumnHeader(ByVal sender As Object, ByVal e As ColumnHeaderCustomDrawEventArgs)
        If e.Column Is column Then
            e.Info.InnerElements.Clear()
            e.Painter.DrawObject(e.Info)
            Dim gray As Boolean = SelectedCount > 0 And SelectedCount < View.DataRowCount
            DrawCheckBox(e.Graphics, e.Bounds, SelectedCount = View.DataRowCount, gray)
            e.Handled = True
        End If
    End Sub

    Private Sub View_CustomDrawGroupRow(ByVal sender As Object, ByVal e As RowObjectCustomDrawEventArgs)
        Dim info As DevExpress.XtraGrid.Views.Grid.ViewInfo.GridGroupRowInfo
        info = e.Info

        info.GroupText = "         " + info.GroupText.TrimStart()
        e.Info.Paint.FillRectangle(e.Graphics, e.Appearance.GetBackBrush(e.Cache), e.Bounds)
        e.Painter.DrawObject(e.Info)

        Dim r As Rectangle = info.ButtonBounds
        r.Offset(r.Width * 2, 0)

        Dim g As Integer = GroupRowSelectionStatus(e.RowHandle)
        DrawCheckBox(e.Graphics, r, g > 0, g < 0)
        e.Handled = True
    End Sub

    Private Sub view_RowStyle(ByVal sender As Object, ByVal e As RowStyleEventArgs)
        If IsRowSelected(e.RowHandle) Then
            e.Appearance.BackColor = SystemColors.Highlight
            e.Appearance.ForeColor = SystemColors.HighlightText
        End If
    End Sub

    Public Property View() As GridView
        Get
            Return ViewValue
        End Get
        Set(ByVal Value As GridView)
            If Not ViewValue Is Value Then
                Detach()
                Attach(Value)
            End If
        End Set
    End Property

    Public ReadOnly Property CheckMarkColumn() As GridColumn
        Get
            Return column
        End Get
    End Property

    Public ReadOnly Property SelectedCount() As Integer
        Get
            Return selection.Count
        End Get
    End Property

    Public Function GetSelectedRow(ByVal index As Integer) As Object
        Return selection(index)
    End Function

    Public Function GetSelectedIndex(ByVal row As Object) As Integer
        Return selection.IndexOf(row)
    End Function

    Public Sub ClearSelection()
        selection.Clear()
        Invalidate()
    End Sub

    Private Sub Invalidate()
        View.BeginUpdate()
        View.EndUpdate()
        RaiseEvent CellValueChange(Nothing, Nothing)
    End Sub

    Public Sub SelectAll()
        selection.Clear()
        If TypeOf View.DataSource Is ICollection Then
            selection.AddRange(CType(View.DataSource, ICollection)) ' fast
        Else
            Dim i As Integer
            For i = 0 To View.DataRowCount - 1 ' slow
                selection.Add(View.GetRow(i))
            Next i
        End If
        Invalidate()
    End Sub

    Public Sub SelectGroup(ByVal rowHandle As Integer, ByVal [select] As Boolean)
        If IsGroupRowSelected(rowHandle) And [select] Then
            Return
        End If
        Dim i As Integer
        For i = 0 To (View.GetChildRowCount(rowHandle)) - 1
            Dim childRowHandle As Integer = View.GetChildRowHandle(rowHandle, i)
            If View.IsGroupRow(childRowHandle) Then
                SelectGroup(childRowHandle, [select])
            Else
                SelectRow(childRowHandle, [select], False)
            End If
        Next i
        Invalidate()
    End Sub

    Public Overloads Sub SelectRow(ByVal rowHandle As Integer, ByVal [select] As Boolean)
        SelectRow(rowHandle, [select], True)
    End Sub

    Private Overloads Sub SelectRow(ByVal rowHandle As Integer, ByVal [select] As Boolean, ByVal invalidate As Boolean)
        If IsRowSelected(rowHandle) = [select] Then
            Return
        End If
        If [select] Then
            View.SetRowCellValue(rowHandle, column, True)
        Else
            View.SetRowCellValue(rowHandle, column, False)
        End If
        If invalidate Then
            Me.Invalidate()
        End If
    End Sub

    Public Function GroupRowSelectionStatus(ByVal rowHandle As Integer) As Integer
        Dim count As Integer = 0
        Dim i As Integer
        For i = 0 To (View.GetChildRowCount(rowHandle)) - 1
            Dim row As Integer = View.GetChildRowHandle(rowHandle, i)
            If View.IsGroupRow(row) Then
                Dim g As Integer = GroupRowSelectionStatus(row)
                If g < 0 Then
                    Return g
                End If
                If g > 0 Then
                    count += 1
                End If
            Else
                If IsRowSelected(row) Then
                    count += 1
                End If
            End If
        Next i
        If count = 0 Then
            Return 0
        End If
        If count = View.GetChildRowCount(rowHandle) Then
            Return 1
        End If
        Return -1
    End Function

    Public Function IsGroupRowSelected(ByVal rowHandle As Integer) As Boolean
        Dim i As Integer
        For i = 0 To (View.GetChildRowCount(rowHandle)) - 1
            Dim row As Integer = View.GetChildRowHandle(rowHandle, i)
            If View.IsGroupRow(row) Then
                If Not IsGroupRowSelected(row) Then
                    Return False
                End If
            Else
                If Not IsRowSelected(row) Then
                    Return False
                End If
            End If
        Next i
        Return True
    End Function

    Public Function IsRowSelected(ByVal rowHandle As Integer) As Boolean
        If View.IsGroupRow(rowHandle) Then
            Return IsGroupRowSelected(rowHandle)
        End If

        Dim row As Object = View.GetRow(rowHandle)
        Return GetSelectedIndex(row) <> -1
    End Function

    Private Sub view_CustomUnboundColumnData(ByVal sender As Object, ByVal e As CustomColumnDataEventArgs)
        If e.Column Is CheckMarkColumn Then
            If e.IsGetData Then
                e.Value = IsRowSelected(e.RowHandle)
            Else
                Dim [select] As Boolean = CBool(e.Value)
                If IsRowSelected(e.RowHandle) = [select] Then
                    Return
                End If
                Dim row As Object = View.GetRow(e.RowHandle)
                If [select] Then
                    selection.Add(row)
                Else
                    selection.Remove(row)
                End If
                Me.Invalidate()
            End If
        End If
    End Sub

    Private Sub Edit_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
        IsEdited = True
        View.PostEditor()
    End Sub
End Class

