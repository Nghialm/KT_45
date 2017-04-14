'*************************************************************************
'	Created:	2011/08/19
'	Created:	19:8:2011   10:44
'	File base:	FilterGridview
'	File ext:	vb
'	Author:		Pham Xuan Duy
'	Email:		duypx@trinam.com.vn
'	Mobile:		01239 589 689
'	Purpose:	
'*************************************************************************

Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Collections
Imports DevExpress.Data.Filtering
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.Utils.Paint
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.Utils

Public Class FilterGridview
    Private _ActiveFilter As String = String.Empty
    Private _View As GridView
    Private paint As New XPaint()
    Private listColumn As New ArrayList()
    Private stringColumn As String = String.Empty

    Public Property ActiveFilter() As String
        Get
            Return _ActiveFilter
        End Get
        Set(ByVal value As String)
            If _ActiveFilter <> value Then
                _ActiveFilter = value
            End If
            OnActiveFilterChanged()
        End Set
    End Property
    Public Property ActiveColumn() As String
        Get
            Return stringColumn
        End Get
        Set(ByVal value As String)
            If stringColumn <> value Then
                stringColumn = value
            End If
            Me.listColumn = convertStringToArrayList(Me.stringColumn)
        End Set
    End Property
    Private Function convertStringToArrayList(ByVal str As String) As ArrayList
        Dim strs As String() = str.Split(","c)
        Dim strsList As New ArrayList()
        For Each s As String In strs
            strsList.Add(s.Trim().ToUpper)
        Next
        Return strsList
    End Function
    'Ham tao moi, chi can truyen vao gridview
    Public Sub New(ByVal view As GridView)
        _View = view
        If _View Is Nothing Then Return
        AddHandler _View.CustomDrawCell, AddressOf _View_CustomDrawCell
    End Sub
    Public Sub New(ByVal view As GridView, ByVal listCol As ArrayList)
        _View = view
        If _View Is Nothing Then Return
        AddHandler _View.CustomDrawCell, AddressOf _View_CustomDrawCell
    End Sub
    Private Sub _View_CustomDrawCell(ByVal sender As Object, ByVal e As RowCellCustomDrawEventArgs)
        If Not ExitInListColumn(e.Column.FieldName, Me.listColumn) Then
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
        Dim args As New MultiColorDrawStringParams(e.Appearance)
        args.Bounds = e.Bounds
        args.Text = e.DisplayText
        args.Appearance.Assign(e.Appearance)
        Dim apperance As AppearanceObject = _View.PaintAppearance.SelectedRow
        Dim defaultRange As New CharacterRangeWithFormat(0, e.DisplayText.Length, e.Appearance.ForeColor, e.Appearance.BackColor)
        Dim range As New CharacterRangeWithFormat(index, _ActiveFilter.Length, apperance.ForeColor, apperance.BackColor)
        args.Ranges = New CharacterRangeWithFormat() {defaultRange, range}
        paint.MultiColorDrawString(e.Cache, args)
    End Sub

    Private Function CreateFilterCriteria() As CriteriaOperator
        Dim arFilter As New ArrayList()
        For i As Integer = 0 To _View.VisibleColumns.Count - 1
            Dim _opera = New BinaryOperator(_View.VisibleColumns(i).FieldName, [String].Format("%{0}%", _ActiveFilter), BinaryOperatorType.[Like])
            Dim _flag = ExitInListColumn(_View.VisibleColumns(i).FieldName.ToString(), Me.listColumn)

            If _flag = True Then
                arFilter.Add(_opera)

            End If
        Next
        Dim operators As CriteriaOperator() = New CriteriaOperator(arFilter.Count - 1) {}
        Dim _i As Integer = 0
        For Each item As BinaryOperator In arFilter
            operators(_i) = item
            _i += 1
        Next
        Return New GroupOperator(GroupOperatorType.[Or], operators)
    End Function

    Private Sub OnActiveFilterChanged()
        _View.ActiveFilterCriteria = CreateFilterCriteria()
    End Sub
    Private Function ExitInListColumn(ByVal str As String, ByVal arlist As ArrayList) As Boolean
        If arlist.Contains(str.Trim().ToUpper) Then
            Return True
        End If
        Return False
    End Function
End Class
