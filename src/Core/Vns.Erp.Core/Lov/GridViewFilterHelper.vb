'*************************************************************************
'	created:	2011/11/14
'	created:	14:11:2011   14:09
'	filename: 	D:\TRINAM\KeToan\v52\KTY.Report\Reports\GridViewFilterHelper.vb
'	file path:	D:\TRINAM\KeToan\v52\KTY.Report\Reports
'	file base:	GridViewFilterHelper
'	file ext:	vb
'	author:		Nguyen Quyet Tien
'	
'	purpose:	Base Highlight Filter
'*************************************************************************
Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.Data.Filtering
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.Utils.Paint
Imports DevExpress.Utils
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Base

Public Class GridViewFilterHelper
    Private _ActiveFilter As String = String.Empty
    Private _View As GridView
    Private paint As New XPaint()
    Private _LIST_CHK As List(Of CheckEdit)

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

    Public Sub New(ByVal view As GridView, ByVal listChk As List(Of CheckEdit))
        _LIST_CHK = listChk
        _View = view
        AddHandler _View.CustomDrawCell, AddressOf _View_CustomDrawCell
    End Sub

    Private Sub _View_CustomDrawCell(ByVal sender As Object, ByVal e As RowCellCustomDrawEventArgs)
        'If (Not OnChecked(e.Column.Caption)) Then
        '    Return
        'End If
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

    Private Function OnChecked(ByVal caption As String) As Boolean
        Dim checkedit As CheckEdit = Nothing
        For Each ce As CheckEdit In _LIST_CHK
            If ce.Text.Equals(caption) Then
                checkedit = ce
                Exit For
            End If
        Next ce
        If checkedit Is Nothing Then
            Return False
        End If
        Return (checkedit.Text.Equals(caption) AndAlso checkedit.Checked)
    End Function

    Private Function CreateFilterCriteria() As CriteriaOperator
        Dim operators(_View.VisibleColumns.Count - 1) As CriteriaOperator
        For i As Integer = 0 To _View.VisibleColumns.Count - 1
            operators(i) = New BinaryOperator(_View.VisibleColumns(i).FieldName, String.Format("%{0}%", _ActiveFilter), BinaryOperatorType.Like)
        Next i
        Return New GroupOperator(GroupOperatorType.Or, operators)
    End Function

    Private Sub OnActiveFilterChanged()
        _View.ActiveFilterCriteria = CreateFilterCriteria()
    End Sub
End Class



