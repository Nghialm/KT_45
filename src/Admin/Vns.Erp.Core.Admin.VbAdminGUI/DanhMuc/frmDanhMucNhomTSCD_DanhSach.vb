Imports System.Collections.Generic
Imports System
Imports System.Data
Imports System.Windows.Forms
Imports DevExpress.XtraTreeList
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Grid
Imports System.Collections
Imports Vns.Erp.Core.Admin.Domain
Imports Vns.Erp.Core.Admin.Service.Interface

Public Class frmDanhMucNhomTSCD_DanhSach
    Inherits FrmBaseDmDanhSach

#Region "Variables and properties"

    Dim _DmNhomTscdService As IDmNhomTscdService

    Public Property DmNhomTscdService() As IDmNhomTscdService
        Get
            Return _DmNhomTscdService
        End Get
        Set(ByVal value As IDmNhomTscdService)
            _DmNhomTscdService = value
        End Set
    End Property

    Private DM_NHOM_TSCD_ID As String
    Private lstobj_dm_NTSCD As IList(Of DmNhomTscd)

    Dim _FormChiTiet As frmDanhMucNhomTSCD_ChiTiet
    Public Property FormChiTiet() As frmDanhMucNhomTSCD_ChiTiet
        Get
            Return _FormChiTiet
        End Get
        Set(ByVal value As frmDanhMucNhomTSCD_ChiTiet)
            _FormChiTiet = value
        End Set
    End Property
#End Region

#Region "Functions"
    Private Sub BindataCBO()
        Dim dt_NHOM As IList(Of DmNhomTscd) = DmNhomTscdService.GetAllByDonviID(Generals.DON_VI.Id)
        ''Ð?nh nghia danh sách tru?ng cho phép tìm ki?m tìm ki?m
        Dim SearchHelperColumnDefine As ArrayList = New ArrayList()
        SearchHelperColumnDefine.Add(New ColumnInfo("MaNhomTscd", "Tên nhóm TS", 0, True, ""))
        SearchHelperColumnDefine.Add(New ColumnInfo("TenNhomTscd", "Mã nhóm TS", 0, True, ""))
        TNCommon.BindData_GridLookUp(_SearchHelper, dt_NHOM, "MaNhomTscd", "Id", SearchHelperColumnDefine, True)

        Dim arr As ArrayList = New ArrayList()
        arr.Add(New ColumnInfo("Display", "Tìm kiếm theo", 0, True, ""))
        Dim tbl_TK As New DataTable
        tbl_TK.Columns.Add("Value")
        tbl_TK.Columns.Add("Display")

        tbl_TK.Rows.Add("MaNhomTscd", "Mã nhóm tài sản")
        tbl_TK.Rows.Add("TenNhomTscd", "Tên nhóm tài sản")

        TNCommon.BindData_GridLookUp(_FieldChooser, tbl_TK, "Display", "Value", arr, True)

    End Sub

    Private Sub Load_Grid()
        lstobj_dm_NTSCD = DmNhomTscdService.GetAllByDonviID(Generals.DON_VI.Id)
        _GridControl.DataSource = lstobj_dm_NTSCD
    End Sub

    Private Function GetRowSelect() As Boolean
        Dim selrow As Integer = 0
        If (_GridView.GetSelectedRows().Length > 0) Then
            If (_GridView.RowCount <> 0) Then
                DM_NHOM_TSCD_ID = Grid_GetDataRowItemString(_GridView, "Id")
                Dim listDmNhomTscd As IList(Of DmNhomTscd) = TryCast(_GridView.DataSource, IList(Of DmNhomTscd))
                DM_NHOM_TSCD_ID = listDmNhomTscd.Item(_GridView.FocusedRowHandle).Id.ToString
                Return True
            End If
        End If
        Return False
    End Function

    Private Sub AddNew()
        Dim f As frmDanhMucNhomTSCD_ChiTiet = FormChiTiet
        Dim obj As DmNhomTscd = f.Show_Form(Nothing, DataInputState.AddMode)
        If obj IsNot Nothing Then
            Me.Load_Grid()
            TNCommon.GridView_SetRowFocus(_GridView, "Id", obj.Id)
        End If
    End Sub

    Private Sub Edit()
        If _GridView.FocusedRowHandle < 0 Then
            Message_Warning("Chưa chọn bản ghi")
            Return
        End If
        If (GetRowSelect()) Then
            Dim f As frmDanhMucNhomTSCD_ChiTiet = FormChiTiet
            Dim obj As DmNhomTscd = f.Show_Form(DM_NHOM_TSCD_ID, DataInputState.EditMode)
            If obj IsNot Nothing Then
                Me.Load_Grid()
                TNCommon.GridView_SetRowFocus(_GridView, "Id", obj.Id)
            End If
        Else
            Message_Information("Không có bản ghi nào")
        End If

    End Sub

    Private Sub Delete()
        If _GridView.FocusedRowHandle < 0 Then
            Message_Warning("Chưa chọn bản ghi")
            Return
        End If
        If (GetRowSelect()) Then
            If Not (Message_Confirm("Bạn có chắc chắn muốn xóa?")) Then Return
            DmNhomTscdService.DeleteById(New Guid(DM_NHOM_TSCD_ID))
            Me.Load_Grid()
        End If
    End Sub

    Private Sub SetKeyValue(ByVal value As Object)
        If value Is Nothing Then
            Return
        End If
        TNCommon.GridView_SetRowFocus(_GridView, "Id", value)
    End Sub
#End Region

#Region "Events"

    Private Sub frmDanhMucNhomTSCD_DanhSach_DanhSach_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            TNCommon.setIconControl(Me)
            Load_Grid()
            BindataCBO()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub btnCreate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCreate.Click
        Try
            AddNew()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub


    Private Sub btnModify_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModify.Click
        Try
            Edit()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub


    Private Sub frmDanhMucNhomKhachHang_DanhSach_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Try
            Select Case e.KeyCode
                Case Keys.Escape
                    Me.Close()
                    Exit Select

                Case Keys.F3
                    AddNew()
                    Exit Select
                Case Keys.F4
                    Edit()
                    Exit Select
                Case Keys.F8
                    Delete()
                    Exit Select
            End Select
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Try
            Me.Close()
        Catch ex As Exception
            Message_Error(ex)
        End Try
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

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Try
            Delete()
        Catch ex As Exception
            Message_Error(ex)
        End Try

    End Sub
#End Region

End Class
