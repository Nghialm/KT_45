Imports DevExpress.XtraGrid.Views.Base
Imports Vns.Erp.Core.Accounting.Domain
Imports Vns.Erp.Core.Admin.Domain
Imports Vns.Erp.Core.Accounting.Service.Interface
Imports Vns.Erp.Core.Admin.Service.Interface


Public Class frmTimKiemChungTuHDDV
#Region "Property"
    Public Property DmTaikhoanService As IDmTaikhoanService
    Public Property KtCtHHddvService As IKtCtHHddvService
    Public Property KtCtDHddvService As IKtCtDHddvService
    Public Property DmVuviecService As IDmVuviecService
    Public Property DmPtqtService As IDmPtqtService
#End Region

#Region "Variable"
    Public m_CT_H_HDDV_ID As Guid
    Private m_MA_LOAI_CT As String
    Private lstobj_ct_h_gg As List(Of Extend.CT_H_GInfo) = New List(Of Extend.CT_H_GInfo)
#End Region

    Public Sub New()
        InitializeComponent()
    End Sub

    Public Function Show_Form(ByVal MA_LOAI_CT As String) As List(Of Extend.CT_H_GInfo)
        Try
            TNCommon.setIconControl(Me)
            Form_InitDialog(Me)
            m_MA_LOAI_CT = MA_LOAI_CT
            dteTuNgay.DateTime = Date.Now.Date
            dteDenNgay.DateTime = Date.Now.Date
        Catch ex As Exception
            Message_Error(ex)
        End Try
        If (Me.ShowDialog = DialogResult.OK) Then
            Return lstobj_ct_h_gg
        Else
            Return Nothing
        End If
    End Function

    Private Sub TimKiem()
        Dim CT_SO As String = ""
        Dim SO_TIEN_TU As Decimal = 0
        Dim SO_TIEN_DEN As Decimal = 0
        Dim TRANG_THAI As Decimal = 0

        CT_SO = txtCTTuSo.Text

        Dim ma_tk_no, ma_tk_co, ma_tk_thue As String
        ma_tk_no = txtTK_NO.Text
        ma_tk_co = txtTK_CO.Text
        ma_tk_thue = txtTKThue.Text

        Dim ngay_ct_tu, ngay_ct_den As DateTime
        ngay_ct_tu = dteTuNgay.DateTime
        ngay_ct_den = dteDenNgay.DateTime

        If txtSoTienTu.Text <> "" Then
            SO_TIEN_TU = txtSoTienTu.Text
        End If

        Dim TenKhachHang As String
        TenKhachHang = txtTENKH.Text

        If txtSoTienDen.Text <> "" Then
            SO_TIEN_DEN = Decimal.Parse(txtSoTienDen.Text)
        End If

        Dim lstobj_ct_h_gg_temp As List(Of KtCtHHddv) =
        KtCtHHddvService.SearchChungTu(Generals.DON_VI.Id, m_MA_LOAI_CT, CT_SO, ngay_ct_tu, ngay_ct_den, 0, TenKhachHang,
                                       ma_tk_no, ma_tk_co, ma_tk_thue,
                                       SO_TIEN_TU, SO_TIEN_DEN, String.Empty,
                                       0, 0, txtTenDichVu.Text,
                                       Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid,
                                       Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid, Null.NullGuid)
        
        lstobj_ct_h_gg = Commons.ConvertToCTHG(lstobj_ct_h_gg_temp)

        If lstobj_ct_h_gg Is Nothing Then
            lstobj_ct_h_gg = New List(Of Extend.CT_H_GInfo)
        End If
        _GridControl.DataSource = lstobj_ct_h_gg_temp

        If lstobj_ct_h_gg.Count = 0 Then
            btnXac.Enabled = False
        Else
            btnXac.Enabled = True
        End If

    End Sub

    Private Sub Load_grv_CT(ByVal ct_h_HDDV_ID As Guid)
        Dim lst_obj_HDDV_CT As List(Of KtCtDHddv) = KtCtDHddvService.GetByCtHandNghiepVu(ct_h_HDDV_ID)
        _gridControlCT.DataSource = lst_obj_HDDV_CT
    End Sub

    Private Sub btnNhan_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnXac.Click
        DialogResult = DialogResult.OK
    End Sub

    Private Sub btnSea_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSea.Click
        Try
            frmProgress.Instance.Thread = AddressOf TimKiem
            frmProgress.Instance.Show_Progress()
            _GridView.FocusedRowHandle = -1
            _GridView.SelectRow(Handle)
            If _GridView.RowCount = 0 Then
                _gridControlCT.DataSource = Nothing
            End If
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub _GridView_FocusedRowChanged(ByVal sender As Object, ByVal e As FocusedRowChangedEventArgs) Handles _GridView.FocusedRowChanged
        Try
            If _GridView.RowCount <> 0 Then
                m_CT_H_HDDV_ID = CType(_GridView.GetRow(_GridView.FocusedRowHandle), KtCtHHddv).Id
                Load_grv_CT(m_CT_H_HDDV_ID)
            End If
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub BindData()
        Dim lsTaiKhoan As IList(Of DmTaikhoan) = DmTaikhoanService.GetAllByDonviID(Generals.DON_VI.Id)
        Dim dt As DataTable = DataHelper.ToDataTable(Of DmTaikhoan)(lsTaiKhoan)

        Dim dt_No As DataTable = dt.Copy
        Dim columnDefine As ArrayList = New ArrayList()
        columnDefine.Add(New ColumnInfo("MaTaikhoan", "Mã tài khoản", 0, True, ""))
        columnDefine.Add(New ColumnInfo("TenTaikhoan", "Tên tài khoản", 0, True, ""))

        Dim beNo As BaseGridPopupForm = New BaseGridPopupForm(txtTK_NO, "MaTaikhoan", dt_No, columnDefine)
        beNo.Text = "Chọn tài khoản"
        beNo.Size = New Size(500, 300)

        Dim dt_Co As DataTable = dt.Copy
        Dim beCo As BaseGridPopupForm = New BaseGridPopupForm(txtTK_CO, "MaTaikhoan", dt_Co, columnDefine)
        beCo.Text = "Chọn tài khoản"
        beCo.Size = New Size(500, 300)

        Dim dt_thue As DataTable = dt.Copy
        Dim beTHUE As BaseGridPopupForm = New BaseGridPopupForm(txtTKThue, "MaTaikhoan", dt_thue, columnDefine)
        beTHUE.Text = "Chọn tài khoản"
        beTHUE.Size = New Size(500, 300)

        Dim lstPPQTNo As List(Of DmPtqt) = _
                DmPtqtService.GetAllByDonviID(Generals.DON_VI.Id)
        cboPTQTNo.DataSource = lstPPQTNo
        cboPTQTNo.DisplayMember = "KyHieu"
        cboPTQTNo.ValueMember = "Id"

        Dim lstPPQTCo As List(Of DmPtqt) = _
                DmPtqtService.GetAllByDonviID(Generals.DON_VI.Id)
        cboPTQTCo.DataSource = lstPPQTCo
        cboPTQTCo.DisplayMember = "KyHieu"
        cboPTQTCo.ValueMember = "Id"

        Dim lstVuViecNo As List(Of DmVuviec) = DmVuviecService.GetAllByDonviID(Generals.DON_VI.Id)
        cboVuviecNo.DataSource = lstVuViecNo
        cboVuviecNo.DisplayMember = "TenVuviec"
        cboVuviecNo.ValueMember = "Id"

        Dim lstVuViecCo As List(Of DmVuviec) = DmVuviecService.GetAllByDonviID(Generals.DON_VI.Id)
        cboVuviecCo.DataSource = lstVuViecCo
        cboVuviecCo.DisplayMember = "TenVuviec"
        cboVuviecCo.ValueMember = "Id"
    End Sub

    Private Sub btnCan_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCan.Click
        Me.Close()
    End Sub

    Private Sub frmTimKiemChungTuKeToan_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Try
            BindData()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub frmTimKiemChungTuKeToan_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub
End Class