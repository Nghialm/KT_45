'*************************************************************************
'	created:	2011/08/18
'	created:	18:8:2011   20:40
'	file base:	CommonClass
'	file ext:	vb
'	author:		Pham Xuan Duy
'	
'	purpose:	
'*************************************************************************

#Region "Import detectives"


Imports DevExpress.XtraGrid.Views.Base
Imports System.Windows.Forms
Imports Vns.Erp.Core.Admin.Domain

#End Region

Public Class CommonClass

    ''' <summary>
    ''' Chuyen doi 1 chuoi thanh arraylist, cac phan tu cach nhau bang dau phay
    ''' </summary>
    ''' <param name="str">String cac phan thu cach nhau bang dau phay ,</param>
    ''' <returns>Mang cac string</returns>
    ''' <remarks></remarks>
    Public Shared Function convertStringToArrayList(ByVal str As String) As ArrayList
        Dim strsList As New ArrayList()
        Dim strs As String()
        If str <> Nothing Then
            str = str.Trim()
            strs = str.Split(","c)
            For Each s As String In strs
                strsList.Add(s.Trim())
            Next
        End If
        Return strsList
    End Function

    ''' <summary>
    ''' Chuyen doi 1 chuoi thanh arraylist, cac phan tu cach nhau bang dau bat ky
    ''' </summary>
    ''' <param name="str">String cac phan thu cach nhau bang dau bat ky</param>
    ''' <returns>Mang cac string</returns>
    ''' <remarks></remarks>
    Public Shared Function convertStringToArrayList(ByVal str As String, ByVal dotStr As String) As ArrayList
        Dim strsList As New ArrayList()
        Dim strs As String()
        If str <> Nothing Then
            str = str.Trim()
            strs = str.Split(Char.Parse(dotStr))
            For Each s As String In strs
                strsList.Add(s.Trim())
            Next
        End If
        Return strsList
    End Function

    ''' <summary>
    ''' Chuyen 1 list object kieu HtBaocao thanh list Parameter. Su dung de chuyen obj tu bang 
    ''' ht_thamso thanh paramter
    ''' </summary>
    ''' <param name="list_object">List cac object HtBaocao</param>
    ''' <returns>List paramter</returns>
    ''' <remarks></remarks>
    Public Shared Function ConvertThamSoToParameter(ByVal list_object As List(Of HtThamso)) As List(Of DevExpress.XtraReports.Parameters.Parameter)
        Dim lst As New List(Of DevExpress.XtraReports.Parameters.Parameter)
        Dim tem As DevExpress.XtraReports.Parameters.Parameter
        If list_object.Count > 0 Then
            For Each item As HtThamso In list_object
                If item.MaThamso <> Nothing Then
                    tem = New DevExpress.XtraReports.Parameters.Parameter
                    tem.Name = item.MaThamso
                    tem.Value = item.GiaTri
                    tem.Description = item.TenThamso
                    lst.Add(tem)
                End If
            Next
        End If
        Return lst
    End Function

    ''' <summary>
    ''' Lay node tren tren cung cua tree
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function TopGroupHtBaoCao(ByVal listBC As List(Of HtBaocao)) As HtBaocao
        'Lay tat cac cac node cap thu muc
        'Dim newList As List(Of HtBaocao) = listBC.OrderBy(Function(x) x.TEN_BAOCAO).ToList()(0)
        'Return newList(0)
        Return listBC.OrderBy(Function(x) x.TenBaocao).ToList()(0)
    End Function

    ''' <summary>
    ''' Lay datasource tren grid hien tai convert thanh datatable
    ''' </summary>
    ''' <param name="gridview">XtraGridView</param>
    ''' <returns>Datatable</returns>
    ''' <remarks></remarks>
    Public Shared Function GetDataTableFromDatasourceGrid(ByVal gridview As DevExpress.XtraGrid.Views.Grid.GridView) As DataTable
        Dim _dt As New DataTable()
        _dt = Nothing
        If gridview.GridControl.DataSource IsNot Nothing Then
            Dim _dataGrid As New DataGrid()
            _dataGrid.DataSource = GetFilteredData(gridview)
            Dim _dv As DataView = DirectCast(_dataGrid.DataSource, DataView)
            _dt = _dv.ToTable()
        End If
        Return _dt
    End Function

    ''' <summary>
    ''' Lay dataview tu columview
    ''' </summary>
    ''' <param name="view"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function GetFilteredData(ByVal view As ColumnView) As DataView
        If view Is Nothing Then
            Return Nothing
        End If
        If view.ActiveFilter Is Nothing OrElse Not view.ActiveFilterEnabled OrElse view.ActiveFilter.Expression = "" Then
            Return TryCast(view.DataSource, DataView)
        End If
        Dim table As DataTable = DirectCast(view.DataSource, DataView).Table
        Dim filteredDataView As New DataView(table)
        filteredDataView.RowFilter = view.ActiveFilterCriteria.LegacyToString()
        Return filteredDataView
    End Function

    ''' <summary>
    ''' Kiem tra xem 1 paramnter co trong danh sach khong
    ''' </summary>
    ''' <param name="obj">mot parameter</param>
    ''' <param name="list_obj">danh sach paramter</param>
    ''' <returns>True: neu paramter co trong danh sach paramter, va ngc lai</returns>
    ''' <remarks></remarks>
    Public Shared Function CheckExitParaOnList(ByVal obj As DevExpress.XtraReports.Parameters.Parameter, _
                                           ByVal list_obj As List(Of DevExpress.XtraReports.Parameters.Parameter)) _
                                           As Boolean
        For i = 0 To list_obj.Count - 1
            If Convert.ToString(obj.Name).Equals(Convert.ToString(list_obj(i).Name)) Then
                Return True
                Exit For
            End If
        Next
        Return False
    End Function

End Class
