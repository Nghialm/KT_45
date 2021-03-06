#Region "Imports"
Imports DevExpress.XtraGrid.Views.Grid
Imports System.Collections.Generic
Imports DevExpress.XtraGrid
Imports System.Windows.Forms
Imports DevExpress.XtraEditors.Controls
Imports System.Data
Imports System
Imports System.Linq
Imports DevExpress.XtraTreeList.Nodes
Imports System.Reflection
Imports System.Collections
Imports Vns.Erp.Core.Admin.Service.Interface
Imports Vns.Erp.Core.Admin.Domain
#End Region

Public Class frmThamSoHeThong

#Region "Property"
    Private _HtThamsoService As IHtThamsoService
    Public Property HtThamsoService As IHtThamsoService
        Get
            Return _HtThamsoService
        End Get
        Set(ByVal value As IHtThamsoService)
            _HtThamsoService = value
        End Set
    End Property

#End Region

#Region "Variable"
    Private data As DataTable = New DataTable
    ''' <summary>
    ''' True = load from XML
    ''' </summary>
    ''' <remarks></remarks>
    Private flag As Boolean = False
    Private filter As FilterGridview
    'Private dt_Import As DataTable = New DataTable
    'Private dt_import_Cha As DataTable = New DataTable
    'Private dt_import_Con As DataTable = New DataTable
    'Private dt_import_Con_temp As DataTable = New DataTable
    Private lsAll As IList(Of HtThamso) = New List(Of HtThamso)
    Dim id As Decimal = 0
    'Dim dt_find As DataTable
#End Region

#Region "Private Functions"
    Public Sub New()
        InitializeComponent()
    End Sub

    'Load gridview
    Private Sub reloadGridView()
        If Message_Confirm("Dữ liệu vừa nhập sẽ mất, bạn có chắc chắn khôi phục cài đặt gốc không?") Then
            'data = HT_ThamsoBO.Instance().GetByGroupID(GetNodeFocusedByTree.ID)
            data = _HtThamsoService.GetByGroupID_ds(GetNodeFocusedByTree.Id, Generals.DON_VI.Id)
            'data = HT_ThamsoBO.Instance.GetObjectAllByDonviID(Generals.DON_VI.DONVI_ID)
            grcSettings.DataSource = data
        End If
    End Sub

    Private Function dt_GetByGroup_ID(ByVal dt As DataTable, ByVal dce As Decimal) As DataTable
        Dim dt_find_temp As DataTable = New DataTable()
        Create_DataTable(dt_find_temp)
        For Each dr As DataRow In dt.Rows
            If dr("Group_ID").ToString = dce.ToString Then
                Dim dr_fill As DataRow = dt_find_temp.NewRow
                dr_fill("ID") = Decimal.Parse(dr("ID").ToString)
                dr_fill("MA_THAMSO") = dr("MA_THAMSO")
                dr_fill("TEN_THAMSO") = dr("TEN_THAMSO")
                dr_fill("GIA_TRI") = dr("GIA_TRI")
                dr_fill("GIA_TRI_MD") = dr("GIA_TRI_MD")
                dr_fill("MO_TA") = dr("MO_TA")
                dr_fill("GROUP_ID") = Decimal.Parse(dr("GROUP_ID").ToString)
                dr_fill("DONVI_ID") = dr("DONVI_ID")
                dt_find_temp.Rows.Add(dr_fill)
            End If
        Next
        Return dt_find_temp
    End Function

    Private Sub loadGridView()
        'Get data
        Dim tmp As HtThamso = GetNodeFocusedByTree()
        Dim dtDetail = (From ts In lsAll
                       Where ts.GroupId = tmp.Id
                       Select ts)

        Dim lsttmp As IList(Of HtThamso) = New List(Of HtThamso)
        For Each tmpts As HtThamso In dtDetail
            lsttmp.Add(tmpts)
        Next

        grcSettings.DataSource = lsttmp

        Dim arr As ArrayList = New ArrayList()
        arr.Add(New ColumnInfo("Display", "Tìm kiếm theo", 0, True, ""))
        Dim tbl_TK As New DataTable
        tbl_TK.Columns.Add("Value")
        tbl_TK.Columns.Add("Display")

        tbl_TK.Rows.Add("TenThamso", "Tên tham số")
        tbl_TK.Rows.Add("GiaTri", "Giá trị")

        TNCommon.BindData_GridLookUp(_FieldChooser, tbl_TK, "Display", "Value", arr, True)

        _SearchHelper.Properties.DataSource = lsttmp
        _SearchHelper.Properties.DisplayMember = "TenThamso"
        _SearchHelper.Properties.ValueMember = "Id"
    End Sub

    'Load tree
    Private Sub LoadTree()
        Dim dtParrent = (From ts In lsAll
                        Where ts.GroupId = Null.NullGuid
                        Select ts)
        Dim lsttmp As IList(Of HtThamso) = New List(Of HtThamso)
        For Each tmp As HtThamso In dtParrent
            lsttmp.Add(tmp)
        Next
        _TreeList.DataSource = lsttmp
    End Sub

    'Lay du lieu tu node dang focus
    Private Function GetNodeFocusedByTree() As HtThamso
        Dim obj As New HtThamso
        obj = CType(_TreeList.GetDataRecordByNode(_TreeList.FocusedNode), HtThamso)
        Return obj
    End Function

    ''' <summary>
    ''' Convert datarowview sang object info
    ''' </summary>
    ''' <param name="objInfo">object info</param>
    ''' <param name="dr">Datarowview</param>
    ''' <remarks></remarks>
    Private Sub Object_GetDataRawView(ByVal objInfo As Object, ByVal dr As DataRowView)
        Dim objPropertyInfo As PropertyInfo
        Dim fieldName As String
        Dim objValue As Object
        '
        For i As Integer = 0 To dr.Row.Table.Columns.Count - 1
            fieldName = dr.Row.Table.Columns(i).ColumnName
            If (fieldName <> "") Then
                objPropertyInfo = Object_GetProperty(objInfo.GetType, fieldName)
                If objPropertyInfo Is Nothing Then
                    Continue For
                End If
                'Kiểu của Cell  ???
                objValue = dr.Row.Item(i)

                If Not objValue Is DBNull.Value Then
                    objValue = Object_SetValueEx(objValue, objPropertyInfo.PropertyType.Name)
                    objPropertyInfo.SetValue(objInfo, objValue, Nothing)
                End If
            End If
        Next
    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="objInfo"></param>
    ''' <param name="dr"></param>
    ''' <remarks></remarks>
    Private Function Object_GetDataRaw(ByVal objInfo As Object, ByVal dr As DataRow) As Object
        Dim objPropertyInfo As PropertyInfo
        Dim fieldName As String
        Dim objValue As Object = Nothing
        '
        For i As Integer = 0 To dr.Table.Columns.Count - 1
            fieldName = dr.Table.Columns(i).ColumnName
            If (fieldName <> "") Then
                objPropertyInfo = Object_GetProperty(objInfo.GetType, fieldName)
                If objPropertyInfo Is Nothing Then
                    Continue For
                End If
                'Kiểu của Cell  ???
                objValue = dr.Item(i)

                If Not objValue Is DBNull.Value Then
                    objValue = Object_SetValueEx(objValue, objPropertyInfo.PropertyType.Name)
                    objPropertyInfo.SetValue(objInfo, objValue, Nothing)
                End If
            End If
        Next

        Return objInfo
    End Function

    Private Sub saveData()
        Dim str As String = ""
        If flag Then
            _HtThamsoService.DeleteByDonviId(Generals.DON_VI.Id)

            Dim lsParrent = (From ht In lsAll
                            Where ht.GroupId = Null.NullGuid
                            Select ht)

            For Each tmpParrent As HtThamso In lsParrent
                Dim oldid As Guid = tmpParrent.Id
                Dim newid As Guid = Null.NullGuid
                tmpParrent.DonviId = Generals.DON_VI.Id
                _HtThamsoService.Save(tmpParrent)
                newid = tmpParrent.Id

                Dim lsDetail = (From ht In lsAll
                                Where ht.GroupId = oldid
                                Select ht)
                For Each tmpDetail As HtThamso In lsDetail
                    tmpDetail.GroupId = newid
                    tmpDetail.DonviId = Generals.DON_VI.Id
                    _HtThamsoService.Save(tmpDetail)
                Next
            Next
            flag = False
        Else
            'Lay ra nhung row dc update va update
            For Each tmp As HtThamso In lsAll
                If (tmp.MaDonvi = "1") Then
                    tmp.MaDonvi = Generals.DON_VI.MaDonvi
                    _HtThamsoService.SaveOrUpdate(tmp)
                End If
            Next
        End If
        loadGridView()
        grvSettings.RefreshData()
    End Sub

    'Xuat xml
    Private Sub xuatxml()
        Dim ds As New DataSet
        ds.Tables.Add(Vns.Erp.Core.Dao.Util.DBUtil.ToDataTable(lsAll))

        Dim ofd As New SaveFileDialog()
        ofd.Filter = "XML file|*.xml"
        If ofd.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            ds.WriteXml(ofd.FileName)
        End If
    End Sub

    Private Sub Create_DataTable(ByVal dt As DataTable)
        dt.Columns.Add("ID", GetType(Decimal))
        dt.Columns.Add("MA_THAMSO", GetType(String))
        dt.Columns.Add("TEN_THAMSO", GetType(String))
        dt.Columns.Add("GIA_TRI", GetType(String))
        dt.Columns.Add("GIA_TRI_MD", GetType(String))
        dt.Columns.Add("MO_TA", GetType(String))
        dt.Columns.Add("GROUP_ID", GetType(Decimal))
        dt.Columns.Add("DONVI_ID", GetType(String))
        dt.Columns.Add("MA_DONVI", GetType(String))
        'dt.Columns.Add("FLAG", GetType(String))
    End Sub

    Private Sub nhapxml()
        Dim lst_ht_thamSo As List(Of HtThamso) = New List(Of HtThamso)
        Dim ds As New DataSet
        Dim ofd As New OpenFileDialog()
        ofd.Filter = "XML file|*.xml"
        If ofd.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            ds.ReadXml(ofd.FileName)
            Dim dt_Import As New DataTable
            dt_Import = ds.Tables(0)
            lsAll = New List(Of HtThamso)
            For Each dr As DataRow In dt_Import.Rows
                Dim obj As New HtThamso
                obj = CType(Object_GetDataRaw(obj, dr), HtThamso)
                lsAll.Add(obj)
            Next

            LoadTree()
            loadGridView()

            flag = True
        End If
    End Sub

    'Convert datatable to list
    Public Function ConvertDataTableToListObj(ByVal data As DataTable) As List(Of HtThamso)
        Dim tem As HtThamso
        Dim lst As New List(Of HtThamso)

        For Each item As DataRow In data.Rows
            'Try
            tem = New HtThamso
            tem.Id = VnsConvert.CGuid(item("ID"))
            tem.MaThamso = item("MA_THAMSO").ToString()
            tem.TenThamso = item("TEN_THAMSO").ToString()
            tem.GiaTri = item("GIA_TRI").ToString()
            tem.GiaTriMd = item("GIA_TRI_MD").ToString()
            tem.MoTa = item("MO_TA").ToString()
            lst.Add(tem)
            'Catch ex As Exception
            '    Message_Error(ex)
            'End Try
        Next
        Return lst
    End Function

#End Region

#Region "Events"
    Private Sub frmThamSoHeThong_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            lsAll = _HtThamsoService.GetByDonviId(Generals.DON_VI.Id)

            LoadTree()
            loadGridView()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Function InsertObjectx(ByVal obj As HtThamso) As HtThamso
        Return _HtThamsoService.Save(obj)
    End Function

    Private Sub UpdateObjectx(ByVal obj As HtThamso)
        _HtThamsoService.SaveOrUpdate(obj)
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Try
            Me.Close()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub frmThamSoHeThong_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown, grcSettings.KeyDown
        Try
            Select Case e.KeyCode
                Case Keys.Escape
                    Me.Close()
                    Exit Select
            End Select
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub btnRollBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRollBack.Click
        Try
            flag = False
            reloadGridView()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub btnExportToXml_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnXuatXml.Click
        Try
            frmProgress.Instance.Thread = AddressOf xuatxml
            frmProgress.Instance.Show_Progress()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub btnNhapXml_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNhapXml.Click
        Try
            flag = True
            nhapxml()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub TreeList1_FocusedNodeChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraTreeList.FocusedNodeChangedEventArgs) Handles _TreeList.FocusedNodeChanged
        Try
            If _TreeList.Nodes.Count <> 0 Then
                If flag = True Then
                    'loadGridView(dt_import_Con)
                Else
                    loadGridView()
                End If
            End If
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Try
            frmProgress.Instance.Thread = AddressOf saveData
            frmProgress.Instance.Show_Progress()
            frmProgress.Instance.SetFinishText("Save data")

        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub
#End Region

    Private Sub grvSettings_CellValueChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles grvSettings.CellValueChanged
        Try
            Dim dr As HtThamso = CType(grvSettings.GetRow(grvSettings.FocusedRowHandle), HtThamso)
            'dr.SetModified()
            data.AcceptChanges()
            'Dung tam ma don vi lam flag
            dr.MaDonvi = "1"
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub SetKeyValue(ByVal value As Object)
        If value Is Nothing Then
            Return
        End If
        TNCommon.GridView_SetRowFocus(grvSettings, "Id", value)
    End Sub

    Private Sub _FieldChooser_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _FieldChooser.EditValueChanged
        Try
            If DB_GetString(_FieldChooser.EditValue) <> "" Then
                _SearchHelper.Properties.DisplayMember = _FieldChooser.EditValue.ToString()
                _SearchHelper.Focus()
            End If
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub _SearchHelper_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _SearchHelper.EditValueChanged
        Try
            If DB_GetString(_SearchHelper.EditValue) <> "" Then
                SetKeyValue(_SearchHelper.EditValue)
            End If
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub
End Class