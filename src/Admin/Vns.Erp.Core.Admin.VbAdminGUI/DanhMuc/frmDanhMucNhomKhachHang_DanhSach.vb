Imports System.Collections.Generic
Imports System
Imports System.Windows.Forms
Imports System.Data
Imports System.Collections
Imports Vns.Erp.Core.Admin.Domain
Imports Vns.Erp.Core.Admin.Service.Interface

Public Class frmDanhMucNhomKhachHang_DanhSach
    Inherits FrmBaseDmDanhSach

#Region "Variables and property"
    Private dmnkh As String
    Private lstobj_dm_nkh As List(Of DmNhomKhang) = New List(Of DmNhomKhang)
    Dim _DmNhomKhangService As IDmNhomKhangService

    Dim _FormChiTiet As FrmBaseDmChiTiet
    Public Overrides Property FormChiTiet() As FrmBaseDmChiTiet
        Get
            If _FormChiTiet Is Nothing Then
                _FormChiTiet = New frmDanhMucNhomKhachHang_ChiTiet()
            End If
            Return _FormChiTiet
        End Get
        Set(ByVal value As FrmBaseDmChiTiet)
            _FormChiTiet = value
        End Set
    End Property

    Public Property DmNhomKhangService() As IDmNhomKhangService
        Get
            Return _DmNhomKhangService
        End Get
        Set(ByVal value As IDmNhomKhangService)
            _DmNhomKhangService = value
        End Set
    End Property
#End Region

#Region "Contructor"
    Public Sub New()
        InitializeComponent()
        TNCommon.setIconControl(Me)
    End Sub
#End Region

#Region "Events"
    Private Sub frmDanhMucNhomKhachHang_DanhSach_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
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

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Try
            Delete()
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
#End Region

#Region "Functions"

    Private Sub BindataCBO()
        Dim dt_NHOM As IList(Of DmNhomKhang) = DmNhomKhangService.GetObjectAllByDonviID(Generals.DON_VI.Id)
        ''Ð?nh nghia danh sách tru?ng cho phép tìm ki?m tìm ki?m
        Dim SearchHelperColumnDefine As ArrayList = New ArrayList()
        SearchHelperColumnDefine.Add(New ColumnInfo("TenNhomKhang", "Tên nhóm khách hàng", 0, True, ""))
        SearchHelperColumnDefine.Add(New ColumnInfo("MaNhomKhang", "Mã nhóm khách hàng", 0, True, ""))
        TNCommon.BindData_GridLookUp(_SearchHelper, dt_NHOM, "TenNhomKhang", "Id", SearchHelperColumnDefine, True)

        Dim arr As ArrayList = New ArrayList()
        arr.Add(New ColumnInfo("Display", "Tìm kiếm theo", 0, True, ""))
        Dim tbl_TK As New DataTable
        tbl_TK.Columns.Add("Value")
        tbl_TK.Columns.Add("Display")

        tbl_TK.Rows.Add("MaNhomKhang", "Mã nhóm khách hàng")
        tbl_TK.Rows.Add("TenNhomKhang", "Tên nhóm Khách hàng")

        TNCommon.BindData_GridLookUp(_FieldChooser, tbl_TK, "Display", "Value", arr, True)

    End Sub

    Private Sub Load_Grid()
        Dim lstobj_dm_NhomKHang As IList(Of DmNhomKhang) = DmNhomKhangService.GetObjectAllByDonviID(Generals.DON_VI.Id)
        _GridControl.DataSource = lstobj_dm_NhomKHang
    End Sub

    Private Function GetRowSelect() As Boolean
        Dim selrow As Integer = 0
        If (_GridView.GetSelectedRows().Length > 0) Then
            If (_GridView.RowCount <> 0) Then
                Dim grinkh As DmNhomKhang = CType(_GridView.GetRow(_GridView.GetSelectedRows(0)), DmNhomKhang)
                dmnkh = grinkh.Id.ToString
                Return True
            End If
        End If
        Return False
    End Function

    Private Sub AddNew()
        'Try
        Dim f As frmDanhMucNhomKhachHang_ChiTiet = FormChiTiet
        If f.Show_Form(Nothing, DataInputState.AddMode) Then
            Me.Load_Grid()
        End If
        'Catch ex As Exception
        '    Message_Error(ex)
        'End Try
    End Sub

    Private Sub Edit()
        If _GridView.FocusedRowHandle < 0 Then
            Message_Warning("Chưa chọn bản ghi")
            Return
        End If

        If (GetRowSelect()) Then
            Dim f As frmDanhMucNhomKhachHang_ChiTiet = FormChiTiet
            If f.Show_Form(dmnkh, DataInputState.EditMode) Then
                Me.Load_Grid()
            End If
        End If
    End Sub

    Private Sub Delete()
        If _GridView.FocusedRowHandle < 0 Then
            Message_Warning("Chưa chọn bản ghi")
            Return
        End If
        If (GetRowSelect()) Then
            If (MessageBox.Show("Bạn muốn xóa hay không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> DialogResult.Yes) Then Return
            DmNhomKhangService.DeleteById(New Guid(dmnkh))
            Me.Load_Grid()
        End If
    End Sub

    Private Sub SetKeyValue(ByVal value As Object)
        If value Is Nothing Then
            Return
        End If
        'TNCommon.GridView_SetRowFocus(_GridView, "DM_NHOM_KHANG_ID", value)
        For i As Integer = 0 To _GridView.RowCount - 1
            Dim obj As DmNhomKhang = CType(_GridView.GetRow(i), DmNhomKhang)
            If obj.Id.ToString.Equals(value.ToString()) Then
                _GridView.FocusedRowHandle = i
            End If
        Next
    End Sub
#End Region

End Class

