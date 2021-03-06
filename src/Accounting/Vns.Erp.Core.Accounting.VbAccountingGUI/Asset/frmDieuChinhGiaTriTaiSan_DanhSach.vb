Imports DevExpress.XtraEditors.Repository

Imports Vns.Erp.Core.Admin.Domain
Imports Vns.Erp.Core.Admin.Service.Interface


Public Class frmDieuChinhGiaTriTaiSan_DanhSach

#Region "Property"
    Private _CtTscdService As ICtTscdService
    Public Property CtTscdService As ICtTscdService
        Get
            Return _CtTscdService
        End Get
        Set(ByVal value As ICtTscdService)
            _CtTscdService = value
        End Set
    End Property
    Private _DmTaikhoanService As IDmTaikhoanService
    Public Property DmTaikhoanService As IDmTaikhoanService
        Get
            Return _DmTaikhoanService
        End Get
        Set(ByVal value As IDmTaikhoanService)
            _DmTaikhoanService = value
        End Set
    End Property
    Private _DmTscdService As IDmTscdService
    Public Property DmTscdService As IDmTscdService
        Get
            Return _DmTscdService
        End Get
        Set(ByVal value As IDmTscdService)
            _DmTscdService = value
        End Set
    End Property
#End Region

#Region "Variables"
    Private CT_TSCD_ID As Guid
    Private DM_TSCD_ID As Guid
    Dim grv_con As CtTscd = New CtTscd
#End Region

#Region "Private functions"

    Public Sub New()
        InitializeComponent()
        TNCommon.setIconControl(Me)
    End Sub
    'load grv cha
    Private Sub Load_DM_TSCD()
        Dim dt_tk As New List(Of DmTaikhoan)
        dt_tk.AddRange(_DmTaikhoanService.GetAllByDonviID(Generals.DON_VI.Id))

        Dim dt_tk_ts As List(Of DmTaikhoan) = dt_tk

        cboMD_TK_TS.DataSource = dt_tk_ts
        cboMD_TK_TS.ValueMember = "Id"
        cboMD_TK_TS.DisplayMember = "MaTaikhoan"

        Dim dt_tk_cp As IList(Of DmTaikhoan) = dt_tk

        cboMD_TK_CHIPHI.DataSource = dt_tk_ts
        cboMD_TK_CHIPHI.ValueMember = "Id"
        cboMD_TK_CHIPHI.DisplayMember = "MaTaikhoan"

        Dim dt_tk_kh As IList(Of DmTaikhoan) = dt_tk

        cboMD_TK_KHAUHAO.DataSource = dt_tk_kh
        cboMD_TK_KHAUHAO.ValueMember = "Id"
        cboMD_TK_KHAUHAO.DisplayMember = "MaTaikhoan"

        Dim lst_DM_TSCD As List(Of DmTscd) = New List(Of DmTscd)
        Dim TotalResult As Integer
        lst_DM_TSCD.AddRange(_DmTscdService.GetObjectAllByDonviID(-1, -1, Generals.DON_VI.Id, TotalResult))
        grcDM_TSCD.DataSource = lst_DM_TSCD
    End Sub

    'load grv con
    Private Sub Load_CT_TSCD(ByVal DM_TSCD_ID As Guid)
        Dim lst_CT_TSCD As List(Of CtTscd) = New List(Of CtTscd)
        lst_CT_TSCD.AddRange(_CtTscdService.GetObjectByIdDM_TSCD_DC(DM_TSCD_ID))
        grc_CT_TSCD.DataSource = lst_CT_TSCD
        grvCT_TSCD.Columns("TangTscd").ColumnEdit = TANGGIAM_ColumnEdit()
    End Sub

    Private Sub frmDieuChinhGiaTriTaiSan_DanhSach_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Load_DM_TSCD()

    End Sub
    'chuyen so thang text tren grid
    Private Function TANGGIAM_ColumnEdit() As RepositoryItemLookUpEdit
        Dim result As New RepositoryItemLookUpEdit()
        Dim dt As New DataTable()
        dt.Columns.Add("Text", GetType(String))
        dt.Columns.Add("Value", GetType(Decimal))
        Dim dr As DataRow

        dr = dt.NewRow()
        dr("Text") = "Giảm"
        dr("Value") = 4
        dt.Rows.Add(dr)

        dr = dt.NewRow()
        dr("Text") = "Tăng"
        dr("Value") = 1
        dt.Rows.Add(dr)

        dr = dt.NewRow()
        dr("Text") = "Điều chỉnh tăng TSCĐ"
        dr("Value") = 2
        dt.Rows.Add(dr)

        dr = dt.NewRow()
        dr("Text") = "Điều chỉnh giảm TSCĐ"
        dr("Value") = 3
        dt.Rows.Add(dr)

        result.DisplayMember = "Text"
        result.ValueMember = "Value"
        result.DataSource = dt

        Return result


    End Function

    Private Sub Create()
        'Try
        If (grvCT_TSCD.RowCount = 0) Then
            Message_Warning("Không có phần tử nào")
            Exit Sub
        End If

        Dim frm As frmDieuChinhGiaTriTaiSan_ChiTiet = CType(ObjectFactory.GetObject("frmDieuChinhGiaTriTaiSan_ChiTiet"), frmDieuChinhGiaTriTaiSan_ChiTiet)
        If (frm.Show_Form(Nothing, DM_TSCD_ID, DataInputState.AddMode)) Then
            Me.Load_CT_TSCD(DM_TSCD_ID)
            grvCT_TSCD.FocusedRowHandle = grvCT_TSCD.RowCount - 1
        End If
        'Catch ex As Exception
        '    Message_Error(ex)
        'End Try
    End Sub

    Private Sub Edit()
        'Try
        If (grvCT_TSCD.RowCount <> 0) Then
            grv_con = CType(grvCT_TSCD.GetRow(grvCT_TSCD.FocusedRowHandle), CtTscd)
            If (grv_con.ThuTu = grvCT_TSCD.RowCount And grv_con.TangTscd <> 1 And grv_con.TangTscd <> 4) Then
                Dim i As Integer = grvDM_TSCD.FocusedRowHandle
                Dim frm As frmDieuChinhGiaTriTaiSan_ChiTiet = CType(ObjectFactory.GetObject("frmDieuChinhGiaTriTaiSan_ChiTiet"), frmDieuChinhGiaTriTaiSan_ChiTiet)
                If (frm.Show_Form(CT_TSCD_ID, DM_TSCD_ID, DataInputState.EditMode)) Then
                    Me.Load_DM_TSCD()
                    Me.Load_CT_TSCD(DM_TSCD_ID)
                    grvDM_TSCD.FocusedRowHandle = i
                    grvCT_TSCD.FocusedRowHandle = grvCT_TSCD.RowCount - 1
                End If
            Else
                Message_Warning("Bạn không được sửa bản ghi này")
            End If
        Else
            Message_Warning("Không có bản ghi nào")
        End If
        'Catch ex As Exception
        '    Message_Error(ex)
        'End Try
    End Sub

    Private Sub Delete()
        'Try
        If (grvCT_TSCD.RowCount = 0) Then
            Message_Warning("Không có bản ghi nào")
            Exit Sub
        End If
        btnDelete.Enabled = True
        Dim gridCT As CtTscd = CType(grvCT_TSCD.GetRow(grvCT_TSCD.FocusedRowHandle), CtTscd)
        If (gridCT.TangTscd = 1 Or gridCT.TangTscd = 4 Or gridCT.ThuTu < grvCT_TSCD.RowCount) Then
            Message_Warning("Bạn không được xóa bản ghi này")
        Else
            If (MessageBox.Show("Bạn có chắc chắn muốn xóa bản ghi này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes) Then
                _CtTscdService.Delete(gridCT)
                Load_CT_TSCD(DM_TSCD_ID)
            End If
        End If
        'Catch ex As Exception
        '    Message_Error(ex)
        'End Try
        'End If
    End Sub
#End Region

#Region "Events"

    Private Sub grvDM_TSCD_FocusedRowChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles grvDM_TSCD.FocusedRowChanged
        Try
            If (grvDM_TSCD.RowCount <> 0) Then
                Dim grv_DM_TSCD As DmTscd = CType(grvDM_TSCD.GetRow(grvDM_TSCD.FocusedRowHandle), DmTscd)
                If grv_DM_TSCD IsNot Nothing Then
                    Load_CT_TSCD(grv_DM_TSCD.Id)
                    DM_TSCD_ID = grv_DM_TSCD.Id
                    Dim lst As List(Of CtTscd) = New List(Of CtTscd)
                    lst.AddRange(_CtTscdService.GetObjectByIdDM_TSCD_DC(DM_TSCD_ID))
                    For Each obj As CtTscd In lst
                        If (obj.TangTscd = 4) Then
                            btnAdd.Enabled = False
                            btnModify.Enabled = False
                            btnDelete.Enabled = False
                            Exit For
                        Else
                            btnAdd.Enabled = True
                            btnModify.Enabled = True
                            btnDelete.Enabled = True
                        End If
                    Next
                End If
            End If
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub grvCT_TSCD_FocusedRowChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles grvCT_TSCD.FocusedRowChanged
        Try
            If (grvCT_TSCD.RowCount <> 0) Then
                Dim grv_CT_TSCD As CtTscd = CType(grvCT_TSCD.GetRow(grvCT_TSCD.FocusedRowHandle), CtTscd)
                If grv_CT_TSCD IsNot Nothing Then
                    CT_TSCD_ID = grv_CT_TSCD.Id
                    Dim lst_obj_DM_TSCD_DC = _CtTscdService.GetObjectByIdDM_TSCD_DC(grv_CT_TSCD.TscdId)
                    Dim thu_tu As Integer = lst_obj_DM_TSCD_DC.Count
                End If
            End If
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub btnCreate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Try
            Create()
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

    Private Sub frmDieuChinhGiaTriTaiSan_DanhSach_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Try
            Select Case e.KeyCode
                Case Keys.Escape
                    Me.Close()
                    Exit Select

                Case Keys.F3
                    Create()
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
#End Region

End Class