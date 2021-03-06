Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Base
Imports System.Collections
Imports DevExpress.Data.Filtering
Imports DevExpress.Utils.Paint
Imports DevExpress.Utils
Imports DevExpress.XtraGrid.Columns

Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.ViewInfo
Imports DevExpress.XtraEditors.Drawing
Imports DevExpress.Utils.Drawing
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraEditors.Controls

Imports DevExpress.XtraGrid.Views.Grid.ViewInfo

Partial Public Class BaseGridPopupForm
    Inherits DevExpress.XtraEditors.XtraForm
    Public FULL_SLOT As String = "Số lượng bản ghi được chọn đã tối đa!"
    Private paints As XPaint = New XPaint()

    Private _DataView As DataView
    Private _DataTable As DataTable

    Private _FieldSearchCaptionWidth As Integer = 120

    Public Property FieldSearchCaptionWidth() As Integer
        Get
            Return _FieldSearchCaptionWidth
        End Get
        Set(ByVal value As Integer)
            _FieldSearchCaptionWidth = value
        End Set
    End Property

    Public Property DataSource() As Object
        Get
            Return _DataTable
        End Get
        Set(ByVal value As Object)
            If value Is Nothing Then
                Throw New Exception("DataSource is null")
            End If
            If TypeOf value Is DataTable Then
                _DataTable = TryCast(value, DataTable)
                Init()
                If _DataTable.Columns(KeyName).DataType.Name = "Int32" Then
                    _Border = ""
                End If
                Return
            End If
            Throw New Exception("Not support datatasource type is " & value.GetType().ToString())
        End Set
    End Property

    Private SELECT_Renamed As Boolean = True
    Private SEPERATOR As Char = ";"c
    Private _MaxLength As Integer = Integer.MaxValue

    Private _MarkColumn As GridColumn
    Private _MarkColumnEdit As RepositoryItemCheckEdit

    Public ReadOnly Property SelectCount() As Integer
        Get
            If _MarkString.Trim() = "" Then
                Return 0
            End If
            Dim temp As String = _MarkString
            If temp.EndsWith(SEPERATOR.ToString()) Then
                temp = temp.Remove(temp.Length - 1)
            End If

            Return temp.Split(SEPERATOR).Length
        End Get
    End Property
    Private _ColumnDefines As ArrayList = Nothing
    Private _CheckEditCaptionList As ArrayList = New ArrayList()

    Public Property ColumnDefines() As ArrayList
        Get
            Return _ColumnDefines
        End Get
        Set(ByVal value As ArrayList)
            _ColumnDefines = value
        End Set
    End Property
    Private _Border As String = "'"

    Private _MarkField As String = "Mark"
    Public Property MarkField() As String
        Get
            Return _MarkField
        End Get
        Set(ByVal value As String)
            _MarkField = value
        End Set
    End Property


    Private _KeyName As String
    Public Property KeyName() As String
        Get
            If _KeyName Is Nothing Then
                Throw New Exception("Key name is null !")
            End If
            If _KeyName = "" Then
                Throw New Exception("Key name is empty !")
            End If
            Return _KeyName
        End Get
        Set(ByVal value As String)
            _KeyName = value
        End Set

    End Property

    Private _MarkString As String

    Public Function IsSelected(ByVal key As String) As Boolean
        If _MarkString = "" Then
            Return False
        End If
        Dim temp As String = SEPERATOR & _MarkString
        Return (temp.IndexOf(SEPERATOR & key & SEPERATOR) > -1)
    End Function

    Public Overloads Sub [Select](ByVal key As String)
        If _MarkString = "" Then
            _MarkString = key & SEPERATOR
            Return
        End If
        If _MarkString.Length + key.Length + 1 > _MaxLength Then
            TNCommon.Notify(FULL_SLOT, "Thông báo")
            Return
        End If
        Dim temp As String = SEPERATOR & _MarkString
        temp = temp.Replace(SEPERATOR & key & SEPERATOR, SEPERATOR.ToString())
        temp = temp.Replace(SEPERATOR.ToString() & SEPERATOR, SEPERATOR.ToString())
        If (Not temp.EndsWith(SEPERATOR.ToString())) Then
            temp &= SEPERATOR
        End If
        temp &= key & SEPERATOR
        _MarkString = temp
        If _MarkString.StartsWith(SEPERATOR.ToString()) Then
            _MarkString = _MarkString.Remove(0, 1)
        End If
    End Sub

    Public Sub Remove(ByVal key As String)
        If _MarkString = "" Then
            Return
        End If
        Dim temp As String = SEPERATOR & _MarkString
        temp = temp.Replace(SEPERATOR & key & SEPERATOR, SEPERATOR.ToString())
        temp = temp.Replace(SEPERATOR.ToString() & SEPERATOR, SEPERATOR.ToString())
        If (Not temp.EndsWith(SEPERATOR.ToString())) Then
            temp &= SEPERATOR
        End If
        _MarkString = temp
        If _MarkString.StartsWith(SEPERATOR.ToString()) Then
            _MarkString = _MarkString.Remove(0, 1)
        End If
    End Sub

    Public Property MarkString() As String
        Get
            Dim t As String = _MarkString
            Return _MarkString
        End Get
        Set(ByVal value As String)
            Dim dr As DataRow
            _MarkString = ""
            If value.EndsWith(SEPERATOR.ToString()) Then
                value = value.Remove(value.Length - 1)
            End If
            Dim _MarkArray As String() = value.Split(SEPERATOR)

            _DataView.RowFilter = MarkField & "='True'"
            For Each drv As DataRowView In _DataView
                dr = drv.Row
                dr(MarkField) = False
            Next drv
            Dim invalidkey As String = ""
            Try
                For i As Integer = 0 To _MarkArray.Length - 1
                    Dim key As String = _MarkArray(i)
                    If _MarkString.Length + key.Length + 1 > _MaxLength Then
                        TNCommon.Notify(FULL_SLOT, "Thông báo")
                        Exit For
                    End If
                    invalidkey = key
                    _DataView.RowFilter = _KeyName & "=" & _Border & key & _Border & ""
                    If _DataView.Count > 0 Then
                        dr = _DataView(0).Row
                        dr(MarkField) = True
                        _MarkString &= key & SEPERATOR
                        invalidkey = ""
                    Else
                        invalidkey = key
                    End If
                Next i
            Catch ex As Exception

            End Try
            CorrectKey(invalidkey)
        End Set
    End Property

    Private Sub CorrectKey(ByVal key As String)
        If key = "" Then
            Return
        End If
        txtKeyword.Text = key
        Me.ShowDialog()
    End Sub

    Private _FieldEditor As Object

    Public Property FieldEditor() As Object
        Get
            Return _FieldEditor
        End Get
        Set(ByVal value As Object)
            If value Is Nothing Then
                Throw New Exception("Field Editor is null!")
            End If
            If TypeOf value Is TextEdit Then
                _FieldEditor = value
                Dim te As TextEdit = TryCast(value, TextEdit)
                If te.Properties.MaxLength > 0 Then
                    _MaxLength = te.Properties.MaxLength
                End If
                'te.Leave += new EventHandler(te_Leave);
                AddHandler te.LostFocus, AddressOf te_LostFocus
                AddHandler te.KeyDown, AddressOf te_KeyDown
                Me.StartPosition = FormStartPosition.CenterScreen
                Return
            End If
            Throw New Exception("Field Editor type is " & value.GetType().ToString())
        End Set
    End Property

    Private Sub te_LostFocus(ByVal sender As Object, ByVal e As EventArgs)
        If Me.Visible Then
            Return
        End If
        If TypeOf sender Is TextEdit Then
            Dim te As TextEdit = (TryCast(sender, TextEdit))
            Dim value As String = te.Text.Trim()
            If value.EndsWith(SEPERATOR.ToString()) Then
                value = value.Remove(value.Length - 1)
            End If
            Me.MarkString = value
            te.Text = Me.MarkString
            Return
        End If
    End Sub

    Private Sub te_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            If TypeOf sender Is TextEdit Then
                Dim te As TextEdit = TryCast(sender, TextEdit)

                If String.IsNullOrEmpty(te.Text) Then
                    te.EnterMoveNextControl = True
                    Return
                End If

                te.EnterMoveNextControl = (te.SelectionStart = te.Text.Length AndAlso te.Text.EndsWith(SEPERATOR.ToString()))
                Dim value As String = te.Text.Trim()
                Me.MarkString = value
                te.Text = MarkString
                te.SelectionStart = te.Text.Length
                te.SelectionLength = 0
                'SendKeys.Send("{Tab}")
            End If
        End If

    End Sub

    Public Sub New(ByVal fieldeditor As Control, ByVal keyname As String, ByVal datasource As Object, ByVal columndefine As ArrayList)
        InitializeComponent()
        Me.KeyName = keyname
        Me.FieldEditor = fieldeditor
        ColumnDefines = columndefine
        Me.DataSource = datasource
    End Sub

    Public Sub Init()
        Dim dc As DataColumn = New DataColumn(MarkField, GetType(Boolean))
        dc.DefaultValue = False
        _DataTable.Columns.Add(dc)
        _DataView = New DataView(_DataTable)

        If Not ColumnDefines Is Nothing Then
            Dim x As Integer = txtKeyword.Location.X + txtKeyword.Width + 50
            Dim y As Integer = txtKeyword.Location.Y
            Dim index As Integer = 0

            For Each ci As ColumnInfo In ColumnDefines
                Dim ce As CheckEdit = New CheckEdit()
                ce.Text = ci.Caption
                ce.Location = New Point(x + FieldSearchCaptionWidth * index, y)
                ce.Visible = True
                ce.Checked = (ci.FieldName = KeyName)
                ce.Width = _FieldSearchCaptionWidth
                _CheckEditCaptionList.Add(ce)
                Me.pnlHeader.Controls.Add(ce)
                index += 1
            Next ci
            ColumnDefines.Add(New ColumnInfo(MarkField, "", 0, False, ""))
        End If
        TNCommon.BindData_GridView(_GridView, _DataTable, _ColumnDefines)
        _MarkColumnEdit = TryCast(_GridView.GridControl.RepositoryItems.Add("CheckEdit"), RepositoryItemCheckEdit)
        AddHandler _MarkColumnEdit.EditValueChanging, AddressOf _MarkColumnEdit_EditValueChanging
        _MarkColumn = _GridView.Columns(MarkField)
        _MarkColumn.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False
        _MarkColumn.VisibleIndex = Integer.MaxValue
        _MarkColumn.FieldName = MarkField
        _MarkColumn.Width = 20
        _MarkColumn.Caption = MarkField
        _MarkColumn.OptionsColumn.ShowCaption = False
        _MarkColumn.UnboundType = DevExpress.Data.UnboundColumnType.Boolean
        _MarkColumn.ColumnEdit = _MarkColumnEdit
        _MarkColumn.Visible = True
        AddHandler _GridView.Click, AddressOf _GridView_Click
        AddHandler _GridView.CustomDrawColumnHeader, AddressOf _GridView_CustomDrawColumnHeader
        AddHandler _GridView.RowStyle, AddressOf _GridView_RowStyle
        AddHandler _GridView.CustomDrawCell, AddressOf _GridView_CustomDrawCell
        AddHandler txtKeyword.EditValueChanged, AddressOf txtKeyword_EditValueChanged
    End Sub
    '-----------------------------------------------------------------------------
    Private Sub _GridView_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim info As GridHitInfo
        Dim pt As Point = _GridView.GridControl.PointToClient(Control.MousePosition)
        info = _GridView.CalcHitInfo(pt)
        If info.InColumn AndAlso info.Column Is _MarkColumn Then
            Dim x As Integer = SelectCount
            _MarkString = ""
            Dim y As Integer = _GridView.DataRowCount
            If x = _GridView.DataRowCount Then
                For Each dr As DataRow In _DataTable.Rows
                    dr(MarkField) = False
                Next dr
            Else
                For Each dr As DataRow In _DataTable.Rows
                    dr(MarkField) = True
                    Dim key As String = dr(KeyName).ToString()
                    If _MarkString.Length + key.Length + 1 > _MaxLength Then
                        TNCommon.Notify(FULL_SLOT, "Thông báo")
                        Exit For
                    End If
                    _MarkString &= key & SEPERATOR.ToString()
                Next dr
            End If
        End If


    End Sub
    Private Sub _GridView_RowStyle(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs)
        Dim View As GridView = TryCast(sender, GridView)
        Dim obj As Object = View.GetRowCellValue(e.RowHandle, MarkField)
        If Not (TypeOf obj Is Boolean) Then
            Return
        End If
        If CBool(obj) Then
            e.Appearance.BackColor = SystemColors.Highlight
            e.Appearance.ForeColor = SystemColors.HighlightText
        End If
    End Sub
    Private Sub _GridView_CustomDrawColumnHeader(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.ColumnHeaderCustomDrawEventArgs)
        If e.Column Is _MarkColumn Then
            e.Info.InnerElements.Clear()
            e.Painter.DrawObject(e.Info)
            Dim selectcount As Integer = Me.SelectCount
            Dim check As Boolean = (selectcount = _DataTable.Rows.Count)
            Dim gray As Boolean = (selectcount > 0 AndAlso selectcount < _DataTable.Rows.Count)
            DrawCheckBox(e.Graphics, e.Bounds, check, gray)
            e.Handled = True
        End If
    End Sub
    Private Sub DrawCheckBox(ByVal g As Graphics, ByVal r As Rectangle, ByVal Checked As Boolean, ByVal Grayed As Boolean)
        Dim info As CheckEditViewInfo
        Dim painter As CheckEditPainter
        Dim args As ControlGraphicsInfoArgs
        info = TryCast(_MarkColumnEdit.CreateViewInfo(), CheckEditViewInfo)
        painter = TryCast(_MarkColumnEdit.CreatePainter(), CheckEditPainter)
        If Grayed Then
            info.EditValue = _MarkColumnEdit.ValueGrayed
        Else
            info.EditValue = Checked
        End If
        info.Bounds = r
        info.CalcViewInfo(g)
        args = New ControlGraphicsInfoArgs(info, New GraphicsCache(g), r)
        painter.Draw(args)
        args.Cache.Dispose()
    End Sub
    Private Sub _MarkColumnEdit_EditValueChanging(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ChangingEventArgs)
        Dim dr As DataRow = _GridView.GetDataRow(_GridView.FocusedRowHandle)
        Dim obj As Object = dr(KeyName)

        If CBool(e.NewValue) = SELECT_Renamed Then
            [Select](obj.ToString())
        Else
            Remove(obj.ToString())
        End If
        lblResult.Text = MarkString
    End Sub
    Private Sub txtKeyword_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
        ActiveFilter = txtKeyword.Text
        _GridView.ApplyColumnsFilter()


    End Sub

#Region "Filter core"
    Private _ActiveFilter As String = ""
    Public Property ActiveFilter() As String
        Get
            Return _ActiveFilter
        End Get
        Set(ByVal value As String)
            _ActiveFilter = value
            OnActiveFilterChanged()
        End Set
    End Property
    Private Sub _GridView_CustomDrawCell(ByVal sender As Object, ByVal e As RowCellCustomDrawEventArgs)
        Dim t As String = e.Column.Caption
        If (Not OnChecked(e.Column.Caption)) Then
            Return
        End If
        If _ActiveFilter = String.Empty Then
            Return
        End If
        Dim index As Integer = e.DisplayText.IndexOf(_ActiveFilter)
        If index < 0 Then
            Return
        End If
        e.Handled = True
        e.Appearance.FillRectangle(e.Cache, e.Bounds)
        Dim args As MultiColorDrawStringParams = New MultiColorDrawStringParams(e.Appearance)
        args.Bounds = e.Bounds
        args.Text = e.DisplayText
        args.Appearance.Assign(e.Appearance)
        Dim apperance As AppearanceObject = _GridView.PaintAppearance.SelectedRow
        Dim defaultRange As CharacterRangeWithFormat = New CharacterRangeWithFormat(0, e.DisplayText.Length, e.Appearance.ForeColor, e.Appearance.BackColor)
        Dim range As CharacterRangeWithFormat = New CharacterRangeWithFormat(index, _ActiveFilter.Length, apperance.ForeColor, apperance.BackColor)
        args.Ranges = New CharacterRangeWithFormat() {defaultRange, range}
        paints.MultiColorDrawString(e.Cache, args)
    End Sub
    Private Function OnChecked(ByVal captionname As String) As Boolean
        Dim checkedit As CheckEdit = Nothing
        For Each ce As CheckEdit In _CheckEditCaptionList
            If ce.Text.Equals(captionname) Then
                checkedit = ce
                Exit For
            End If
        Next ce
        If checkedit Is Nothing Then
            Return False
        End If
        Return (checkedit.Text.Equals(captionname) AndAlso checkedit.Checked)
    End Function
    Private Sub OnActiveFilterChanged()
        _GridView.ActiveFilterCriteria = Me.CreateFilterCriteria()
    End Sub
    Private Function CreateFilterCriteria() As CriteriaOperator
        Dim temp As ArrayList = New ArrayList()
        For i As Integer = 0 To _GridView.VisibleColumns.Count - 1
            Dim _test As BinaryOperator = New BinaryOperator(_GridView.VisibleColumns(i).FieldName, String.Format("%{0}%", _ActiveFilter), BinaryOperatorType.Like)
            If OnChecked(_GridView.VisibleColumns(i).Caption) Then
                temp.Add(_test)
            End If
        Next i

        Dim operators As CriteriaOperator() = New CriteriaOperator(temp.Count - 1) {}
        Dim index As Integer = 0
        For Each bo As BinaryOperator In temp
            operators(index) = bo
            index += 1
        Next bo
        Return New GroupOperator(GroupOperatorType.Or, operators)

    End Function
#End Region

    Private Sub btnChoose_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCancel.Click, btnChoose.Click
        Me.Close()
    End Sub


    Private Sub BaseGridPopupForm_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        'txtKeyword.Text = e.KeyValue.ToString
        Select Case (e.KeyValue)
            Case 13 'Enter

                btnChoose.Select()
                Return
            Case 82 'S
                txtKeyword.Text = e.KeyValue.ToString
            Case 27 'Esc
                Me.Close()
        End Select

        If e.KeyValue <= 57 And e.KeyValue >= 48 Then
            txtKeyword.Select()
            txtKeyword.Focus()
        End If
        If e.KeyValue <= 90 And e.KeyValue >= 65 Then
            txtKeyword.Select()
            txtKeyword.Focus()
        End If
    End Sub


    Private Sub BaseGridPopupForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtKeyword.Select()
        _GridView.Columns(2).VisibleIndex = 0
    End Sub

    Private Sub BaseGridPopupForm_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        If e.KeyChar = "s" Or e.KeyChar = "S" Then
            txtKeyword.Focus()
        End If
        If e.KeyChar = "Return" Then
            btnChoose.Select()
            Return
        End If


    End Sub


    Private Sub txtKeyword_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtKeyword.KeyDown
        Select Case (e.KeyValue)
            'Case 37 'Left
            '    _GridControl.Select()
            '    _GridView.SelectRow(0)
            '    Return
            Case 38 'Up
                _GridControl.Select()
                _GridView.SelectRow(0)
                Return
                'Case 39 'Right
                '    _GridControl.Select()
                '    _GridView.SelectRow(0)
                '    Return
            Case 40 'Down
                _GridControl.Select()
                _GridView.SelectRow(0)
                Return
        End Select

    End Sub


    Private Sub _GridControl_EditorKeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles _GridControl.EditorKeyPress
        If e.KeyChar = "Return" Then
            btnChoose.Select()
            Return
        End If
    End Sub

    Private Sub _GridControl_EditorKeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles _GridControl.EditorKeyDown
        Select Case (e.KeyValue)
            Case 13 'Enter
                btnChoose.Select()
                Return
            Case 32 'Space
                '_GridControl.Select()
                '_GridView.SelectRow(0)


        End Select

    End Sub

#Region "dang test thuoc tinh"
    'Private Sub _GridView_FocusedRowChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles _GridView.FocusedRowChanged

    '    '_GridView.Columns(0).ColumnHandle

    'End Sub

    'Private Sub _GridControl_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles _GridControl.KeyDown

    'End Sub

    'Private Sub _GridView_CustomRowCellEditForEditing(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs) Handles _GridView.CustomRowCellEditForEditing
    '    'txtKeyword.Text = _GridView.GetRowCellValue(_GridView.FocusedRowHandle, e.Column).ToString()

    'End Sub

    'Private Sub _GridView_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles _GridView.KeyDown
    '    If e.KeyValue = 32 Then
    '        'txtKeyword.Text = _GridView.GetRowCellValue(e.Handled, chkMarkSelection).ToString()

    '        '_GridView.SetRowCellValue(CheckBox, chkMarkSelection, 1)
    '        '_GridView.SetRowCellValue(Convert.ToInt32(_GridView.FocusedRowHandle), chkMarkSelection, 1)
    '    End If

    'End Sub
#End Region

End Class