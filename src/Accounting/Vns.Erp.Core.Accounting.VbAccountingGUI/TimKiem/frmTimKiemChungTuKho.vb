Imports System
Imports System.Data
Imports System.IO
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls

Imports Vns.Erp.Core.Accounting.Domain
Imports Vns.Erp.Core.Admin.Domain
Imports Vns.Erp.Core.Accounting.Service.Interface
Imports Vns.Erp.Core.Admin.Service.Interface

Public Class frmTimKiemChungTuKho

#Region "Property"
    Public Property DmTaikhoanService As IDmTaikhoanService
    Public Property DmKhoService As IDmKhoService
    Public Property DmNhomvattu1Service As IDmNhomvattu1Service
    Public Property CtHNxService As ICtHNxService
    Public Property CtDNxService As ICtDNxService
#End Region

#Region "Variable"
    Private obj_ct_h_nx As CtHNx = New CtHNx()
    Private obj_ct_d_nx As CtDNx = New CtDNx()
    Private lstobj_ct_d_nx As List(Of CtDNx) = New List(Of CtDNx)
    Private del_lstobj_ct_d_nx As List(Of CtDNx) = New List(Of CtDNx)
    Public MaCT As String
    Public lstobj_ct_h_nx As List(Of CtHNx) = New List(Of CtHNx)
    Public lstobj_ct_h_g As List(Of Extend.CT_H_GInfo) = New List(Of Extend.CT_H_GInfo)
    Dim CTHNXID As Guid

#End Region

#Region "Functions"

    Public Sub BindLookUp()
        ' Bind mã khách
        'Dim lstMaKhachHang As List(Of DM_KhangInfo) = DM_KhangBO.Instance.GetObjectAllByDonviID(Generals.DON_VI.Id)
        'grlMA_KHANG.Properties.DataSource = lstMaKhachHang
        'grlMA_KHANG.Properties.DisplayMember = "KY_HIEU"
        'grlMA_KHANG.Properties.ValueMember = "KHANG_ID"

        'Bind các tài khoản khác
        Dim lstMaTaiKhoan As List(Of DmTaikhoan) = New List(Of DmTaikhoan)
        lstMaTaiKhoan.Add(New DmTaikhoan)
        lstMaTaiKhoan.AddRange(DmTaikhoanService.GetAllByDonviID(Generals.DON_VI.Id))
        'grlTKT.Properties.DataSource = lstMaTaiKhoan
        'grlTKT.Properties.DisplayMember = "MA_TAIKHOAN"
        'grlTKT.Properties.ValueMember = "MA_TAIKHOAN"

        grlTKN.Properties.DataSource = lstMaTaiKhoan
        grlTKN.Properties.DisplayMember = "MaTaikhoan"
        grlTKN.Properties.ValueMember = "MaTaikhoan"

        'Bind vào danh mục kho
        Dim lstMaKho As List(Of DmKho) = New List(Of DmKho)
        lstMaKho.Add(New DmKho)
        lstMaKho.AddRange(DmKhoService.GetAllByDonviID(Generals.DON_VI.Id))
        grlMA_KHO.Properties.DataSource = lstMaKho
        grlMA_KHO.Properties.DisplayMember = "KyHieu"
        grlMA_KHO.Properties.ValueMember = "Id"

        Dim lstKho As List(Of DmKho) = lstMaKho
        cboKHO_NHAP_ID.DataSource = lstKho
        cboKHO_NHAP_ID.DisplayMember = "KyHieu"
        cboKHO_NHAP_ID.ValueMember = "Id"

        ''Bind mã hàng
        'Dim lstMaHang As List(Of DM_HanghoaInfo) = DM_HanghoaBO.Instance.GetObjectAllByDonviID(Generals.DON_VI.Id)
        'grlMA_VT.Properties.DataSource = lstMaHang
        'grlMA_VT.Properties.DisplayMember = "KY_HIEU"
        'grlMA_VT.Properties.ValueMember = "HANGHOA_ID"

        'Bind vào danh mục vật tư
        Dim lstDanhmucvattu1 As List(Of DmNhomvattu1) = New List(Of DmNhomvattu1)
        lstDanhmucvattu1.Add(New DmNhomvattu1)
        lstDanhmucvattu1.AddRange(DmNhomvattu1Service.GetAllByNhom(Generals.DON_VI.Id, 1))
        grlNhomVatTu1.Properties.DataSource = lstDanhmucvattu1
        grlNhomVatTu1.Properties.DisplayMember = "TenNhomVt1"
        grlNhomVatTu1.Properties.ValueMember = "Id"

        Dim lstDanhmucvattu2 As List(Of DmNhomvattu1) = New List(Of DmNhomvattu1)
        lstDanhmucvattu2.Add(New DmNhomvattu1)
        lstDanhmucvattu2.AddRange(DmNhomvattu1Service.GetAllByNhom(Generals.DON_VI.Id, 2))
        grlNhomVatTu2.Properties.DataSource = lstDanhmucvattu2
        grlNhomVatTu2.Properties.DisplayMember = "TenNhomVt1"
        grlNhomVatTu2.Properties.ValueMember = "Id"

        Dim lstDanhmucvattu3 As List(Of DmNhomvattu1) = New List(Of DmNhomvattu1)
        lstDanhmucvattu3.Add(New DmNhomvattu1)
        lstDanhmucvattu3.AddRange(DmNhomvattu1Service.GetAllByNhom(Generals.DON_VI.Id, 3))
        grlNhomVatTu3.Properties.DataSource = lstDanhmucvattu3
        grlNhomVatTu3.Properties.DisplayMember = "TenNhomVt1"
        grlNhomVatTu3.Properties.ValueMember = "Id"

    End Sub
#End Region

#Region "Events"
    Private Sub frmTimKiemChungTuKho_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.Escape
                Me.Close()
        End Select
    End Sub


    Public Sub New()
        InitializeComponent()
        Try
            'Dim columnDefine As ArrayList = New ArrayList()
            'columnDefine.Add(New ColumnInfo("MA_HANGHOA", "Mã hàng hóa", 0, True, ""))
            'columnDefine.Add(New ColumnInfo("TEN_HANGHOA", "Tên hàng hóa", 0, True, ""))
            'Dim dt As DataTable = DM_HanghoaBO.Instance().GetAllByDonviID(Generals.DON_VI.Id).Tables(0)
            'Dim be As CusControls.BaseGridPopupForm = New CusControls.BaseGridPopupForm(txtMA_VT, "MA_HANGHOA", DM_HanghoaBO.Instance().GetAllByDonviID(Generals.DON_VI.Id).Tables(0), columnDefine)
            'be.Text = "Chọn tài khoản"
            'be.Size = New Size(500, 300)
        Catch ex As Exception
            Message_Error(ex)
        End Try
        TNCommon.setIconControl(Me)
    End Sub

    Private Sub frmTimKiemChungTuKho_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            dteNGAY_CTmin.DateTime = New Date(DateTime.Now.Year, DateTime.Now.Month, 1)
            dteNGAY_CTmax.DateTime = DateTime.Now
            BindLookUp()
            btnCon.Enabled = False
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub btnHuy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQui.Click
        lstobj_ct_h_g = New List(Of Extend.CT_H_GInfo)
        Me.Close()
    End Sub

    Private Sub btnNhan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCon.Click
        Try
            grvLPX_Hnx.RefreshData()
            grvLPN_Dnx.RefreshData()
            DialogResult = System.Windows.Forms.DialogResult.OK
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub TimKiem()
        Try

            Dim SoPNMin As String = "" 'txtSO_PNmin.Text.Trim
            Dim SoPNMax As String = ""

            Dim DateCTMin As DateTime = dteNGAY_CTmin.DateTime
            Dim DateCTMax As DateTime = dteNGAY_CTmax.DateTime


            Dim SoHD As String = "" 'txtSO_HD.Text.Trim

            Dim MaKH As String = grlMA_KHANG.Text
            Dim Tax As Decimal = 0
            'If String.IsNullOrEmpty(txtTHUESUAT.Text) Then
            '    Tax = 0
            'Else
            '    Tax = Decimal.Parse(txtTHUESUAT.Text)
            'End If
            Dim TaiKhoanThue As String = ""
            Dim SoTienMin As Decimal
            If String.IsNullOrEmpty(txtSO_TIENMin.Text) Then
                SoTienMin = 0
            Else
                SoTienMin = Decimal.Parse(txtSO_TIENMin.Text)
            End If
            Dim soTienMax As Decimal
            If String.IsNullOrEmpty(txtSO_TIENMax.Text) Then
                soTienMax = 0
            Else
                soTienMax = Decimal.Parse(txtSO_TIENMax.Text)
            End If
            Dim NgayHTMin As DateTime = dteNGAY_CTmin.DateTime
            Dim NgayHTMax As DateTime = dteNGAY_CTmax.DateTime
            If NgayHTMax = Nothing Then
                NgayHTMax = DateTime.MaxValue
            End If

            If NgayHTMin = Nothing Then
                NgayHTMin = DateTime.MinValue
            End If

            Dim DienGiai As String = txtDIENGIAI.Text.Trim
            Dim KhoId As Guid = VnsConvert.CGuid(grlMA_KHO.EditValue)
            Dim MaVT As String = String.Empty
            MaVT = txtMa_VT.Text.Trim

            Dim NVT1 As Guid = grlNhomVatTu1.EditValue
            Dim NVT2 As Guid = grlNhomVatTu2.EditValue
            Dim NVT3 As Guid = grlNhomVatTu3.EditValue
            Dim TKN As String = grlTKN.EditValue
            Dim NguoiSD As String = "" 'txtNGUOISD.Text.Trim
            Dim status As Decimal
            If String.IsNullOrEmpty(txtGHI.Text) Then
                status = 0
            Else
                status = Decimal.Parse(txtGHI.Text)
            End If

            Dim Ghi As Decimal = VnsConvert.CDecimal(txtGHI.Text)

            lstobj_ct_h_nx = New List(Of CtHNx)
            lstobj_ct_h_nx.AddRange(CtHNxService.SearchChungTu(Generals.DON_VI.Id, MaCT, SoPNMin, SoPNMax, DateCTMin, DateCTMax, Ghi, MaKH, String.Empty, String.Empty, SoTienMin, soTienMax, DienGiai, Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid,
                                                        Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid, KhoId, 0, 0, MaVT))
            ''status, MaKho, MaVT, NVT1, NVT2, NVT3, TKN)
            lstobj_ct_h_g = Commons.ConvertToCTHG(lstobj_ct_h_nx)
            If lstobj_ct_h_g Is Nothing Then
                lstobj_ct_h_g = New List(Of Extend.CT_H_GInfo)
            End If
            grcLPN_Hnx.DataSource = lstobj_ct_h_nx

            If lstobj_ct_h_nx.Count = 0 Then
                btnCon.Enabled = False
            Else
                btnCon.Enabled = True
            End If

        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub Load_Grid()
        grcLPN_Hnx.DataSource = lstobj_ct_h_nx
    End Sub

    Private Sub LoadGRV(ByVal CTH_XN As CtHNx)
        'Dim lstobj_ct_d_nx As List(Of CtDNx) = CtDNxService.GetObjectByCTHId(CTH_XN_ID)
        grcLPN_Dnx.DataSource = CTH_XN.LstCtDNx
    End Sub

    Private Sub grvLPX_Hnx_FocusedRowChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles grvLPX_Hnx.FocusedRowChanged
        Dim gridcth As CtHNx = CType(grvLPX_Hnx.GetRow(grvLPX_Hnx.FocusedRowHandle), CtHNx)
        If gridcth Is Nothing Then
            grcLPN_Dnx.DataSource = Nothing
            grvLPN_Dnx.RefreshData()
            Return
        Else
            LoadGRV(gridcth)
        End If
    End Sub

    Private Sub btnSea_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSea.Click
        grvLPX_Hnx.RefreshData()
        grvLPN_Dnx.RefreshData()
        frmProgress.Instance.Thread = AddressOf TimKiem
        frmProgress.Instance.Show_Progress()
        grvLPX_Hnx.FocusedRowHandle = -1
        grvLPX_Hnx.SelectRow(Handle)
        If grvLPX_Hnx.RowCount > 0 Then
            btnCon.Enabled = True
        End If
    End Sub
#End Region

End Class