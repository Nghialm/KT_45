Imports Vns.Erp.Core
Imports Vns.Erp.Core.Admin.Domain
Imports Vns.Erp.Core.Admin.Service.Interface
Imports Vns.Erp.Core.Accounting.Service.Interface

Public Class frmTinhGiaTrungBinh
#Region "Property"
    Private _HtDanhmucService As IHtDanhmucService
    Public Property HtDanhmucService As IHtDanhmucService
        Get
            Return _HtDanhmucService
        End Get
        Set(ByVal value As IHtDanhmucService)
            _HtDanhmucService = value
        End Set
    End Property

    Private _DmNhomvattu1Service As IDmNhomvattu1Service
    Public Property DmNhomvattu1Service As IDmNhomvattu1Service
        Get
            Return _DmNhomvattu1Service
        End Get
        Set(ByVal value As IDmNhomvattu1Service)
            _DmNhomvattu1Service = value
        End Set
    End Property

    Private _DmKhoService As IDmKhoService
    Public Property DmKhoService As IDmKhoService
        Get
            Return _DmKhoService
        End Get
        Set(ByVal value As IDmKhoService)
            _DmKhoService = value
        End Set
    End Property

    Private _KtKhoasoThangService As IKtKhoasoThangService
    Public Property KtKhoasoThangService As IKtKhoasoThangService
        Get
            Return _KtKhoasoThangService
        End Get
        Set(ByVal value As IKtKhoasoThangService)
            _KtKhoasoThangService = value
        End Set
    End Property

    Private _DmHanghoaService As IDmHanghoaService
    Public Property DmHanghoaService As IDmHanghoaService
        Get
            Return _DmHanghoaService
        End Get
        Set(ByVal value As IDmHanghoaService)
            _DmHanghoaService = value
        End Set
    End Property

    Private _BcKetoanKhoService As IBcKetoanKhoService
    Public Property BcKetoanKhoService As IBcKetoanKhoService
        Get
            Return _BcKetoanKhoService
        End Get
        Set(ByVal value As IBcKetoanKhoService)
            _BcKetoanKhoService = value
        End Set
    End Property
#End Region

    Public Sub New()
        InitializeComponent()
        TNCommon.setIconControl(Me)
    End Sub

    Private Sub BindData()
        Dim objColumnDefine As ArrayList
        'bind pp tinh gia
        Dim lstPPTInhGia As List(Of HtDanhmuc) = New List(Of HtDanhmuc)
        lstPPTInhGia.AddRange(_HtDanhmucService.GetByDoiTuong("PP_TINHGIA_KHO"))
        Dim listPPTinhGia As List(Of HtDanhmuc) = New List(Of HtDanhmuc)
        Dim PPTinhGia As HtDanhmuc = New HtDanhmuc()
        PPTinhGia.TenDanhmuc = ""
        PPTinhGia.GiaTri = Nothing
        listPPTinhGia.Add(PPTinhGia)
        listPPTinhGia.AddRange(lstPPTInhGia)
        objColumnDefine = New ArrayList
        objColumnDefine.Add(New LookupEdit_ColumnInfo("TenDanhmuc", "Phương pháp tính giá"))
        LookupEdit_BindData(cboPPTinhGia, listPPTinhGia, "TenDanhmuc", "GiaTri", "", objColumnDefine)
        'bind hang hoa
        Dim lsthanghoa As List(Of DmHanghoa) = New List(Of DmHanghoa)
        lsthanghoa.AddRange(_DmHanghoaService.GetAllByDonviID(Generals.DON_VI.Id))
        Dim listhanghoa As List(Of DmHanghoa) = New List(Of DmHanghoa)
        Dim hanghoa As DmHanghoa = New DmHanghoa()
        hanghoa.TenHanghoa = ""
        hanghoa.KyHieu = ""
        hanghoa.Id = Null.NullGuid
        listhanghoa.Add(hanghoa)
        listhanghoa.AddRange(lsthanghoa)
        objColumnDefine = New ArrayList
        objColumnDefine.Add(New LookupEdit_ColumnInfo("KyHieu", "Mã hàng hóa"))
        objColumnDefine.Add(New LookupEdit_ColumnInfo("TenHanghoa", "Tên hàng hóa"))
        LookupEdit_BindData(cboHangHoa, listhanghoa, "TenHanghoa", "Id", "", objColumnDefine)
        'bind nhom vat tu 1
        Dim lstvattu1 As List(Of DmNhomvattu1) = New List(Of DmNhomvattu1)
        lstvattu1.AddRange(_DmNhomvattu1Service.GetByMaNhomVT(1, Generals.DON_VI.Id))

        Dim listvattu1 As List(Of DmNhomvattu1) = New List(Of DmNhomvattu1)
        Dim vattu1 As DmNhomvattu1 = New DmNhomvattu1()
        vattu1.MaNhomVt1 = ""
        vattu1.TenNhomVt1 = ""
        vattu1.Id = Null.NullGuid
        listvattu1.Add(vattu1)
        listvattu1.AddRange(lstvattu1)

        objColumnDefine = New ArrayList
        objColumnDefine.Add(New LookupEdit_ColumnInfo("MaNhomVt1", "Mã vật tư"))
        objColumnDefine.Add(New LookupEdit_ColumnInfo("TenNhomVt1", "Tên vật tư"))
        LookupEdit_BindData(cboNVT1, listvattu1, "TenNhomVt1", "Id", "", objColumnDefine)
        'bind nhom vat tu 2
        Dim lstvattu2 As List(Of DmNhomvattu1) = New List(Of DmNhomvattu1)
        lstvattu2.AddRange(_DmNhomvattu1Service.GetByMaNhomVT(2, Generals.DON_VI.Id))

        Dim listvattu2 As List(Of DmNhomvattu1) = New List(Of DmNhomvattu1)
        Dim vattu2 As DmNhomvattu1 = New DmNhomvattu1()
        vattu2.MaNhomVt1 = ""
        vattu2.TenNhomVt1 = ""
        vattu2.Id = Null.NullGuid
        listvattu2.Add(vattu2)
        listvattu2.AddRange(lstvattu2)

        objColumnDefine = New ArrayList
        objColumnDefine.Add(New LookupEdit_ColumnInfo("MaNhomVt1", "Mã vật tư"))
        objColumnDefine.Add(New LookupEdit_ColumnInfo("TenNhomVt1", "Tên vật tư"))
        LookupEdit_BindData(cboNVT2, listvattu2, "TenNhomVt1", "Id", "", objColumnDefine)
        'bind nhom vat tu 3
        Dim lstvattu3 As List(Of DmNhomvattu1) = New List(Of DmNhomvattu1)
        lstvattu3.AddRange(_DmNhomvattu1Service.GetByMaNhomVT(3, Generals.DON_VI.Id))

        Dim listvattu3 As List(Of DmNhomvattu1) = New List(Of DmNhomvattu1)
        Dim vattu3 As DmNhomvattu1 = New DmNhomvattu1()
        vattu3.MaNhomVt1 = ""
        vattu3.TenNhomVt1 = ""
        vattu3.Id = Null.NullGuid
        listvattu3.Add(vattu3)
        listvattu3.AddRange(lstvattu3)

        objColumnDefine = New ArrayList
        objColumnDefine.Add(New LookupEdit_ColumnInfo("MaNhomVt1", "Mã vật tư"))
        objColumnDefine.Add(New LookupEdit_ColumnInfo("TenNhomVt1", "Tên vật tư"))
        LookupEdit_BindData(cboNVT3, listvattu3, "TenNhomVt1", "Id", "", objColumnDefine)

        'Bind kho
        Dim listkho As List(Of DmKho) = New List(Of DmKho)
        listkho.AddRange(_DmKhoService.GetAllByDonviID(Generals.DON_VI.Id))

        Dim lstkho As List(Of DmKho) = New List(Of DmKho)
        Dim blank_kho As DmKho = New DmKho()
        blank_kho.MaKho = ""
        blank_kho.TenKho = ""
        blank_kho.Id = Null.NullGuid
        lstkho.Add(blank_kho)
        lstkho.AddRange(listkho)

        objColumnDefine = New ArrayList
        objColumnDefine.Add(New LookupEdit_ColumnInfo("KyHieu", "Mã kho"))
        objColumnDefine.Add(New LookupEdit_ColumnInfo("TenKho", "Tên kho"))
        LookupEdit_BindData(cboKho, lstkho, "TenKho", "Id", "", objColumnDefine)
    End Sub

    Private Sub frmTinhGiaTrungBinh_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            txtThang.Text = DateTime.Now.Month
            txtNam.Text = DateTime.Now.Year
            BindData()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Dim msgKhoaSo As String = "Tháng lựa chọn đã khóa sổ!"
    Private Sub btnTinhGia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTinhGia.Click
        If (Not Me.ValidateChildren()) Then
            Return
        End If

        Dim p_tu_ngay As DateTime = New DateTime(txtNam.EditValue, txtThang.EditValue, 1)
        'Check khoa so thang
        If _KtKhoasoThangService.KiemTraKhoaSo(p_tu_ngay, Generals.DON_VI.Id) Then
            Message_Warning(msgKhoaSo)
            Exit Sub
        End If

        frmProgress.Instance.Thread = AddressOf TinhGiaKho
        frmProgress.Instance.Show_Progress()
        frmProgress.Instance.SetFinishText("Da thuc hien xong!")
        Message_Information("Đã thực hiện xong!")
    End Sub

    Private Sub TinhGiaKho()
        Try
            Dim p_tu_ngay As DateTime = New DateTime(txtNam.EditValue, txtThang.EditValue, 1)
            Dim p_den_ngay As DateTime = p_tu_ngay.AddMonths(1).AddDays(-1)
            Dim p_hanghoa_id As Guid = cboHangHoa.EditValue
            Dim p_nhom1_id As Guid = cboNVT1.EditValue
            Dim p_nhom2_id As Guid = cboNVT2.EditValue
            Dim p_nhom3_id As Guid = cboNVT3.EditValue
            Dim p_kho_id As Guid = cboKho.EditValue
            Dim p_phuongphap As String = cboPPTinhGia.EditValue
            _BcKetoanKhoService.TinhGiaXuatHangHoaVoiKho( _
                p_tu_ngay, p_den_ngay, p_hanghoa_id, p_kho_id, _
                p_phuongphap, Generals.DON_VI.Id, _
                p_nhom1_id, p_nhom2_id, p_nhom3_id)
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

    Private Sub txtThang_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtThang.Validating
        Try
            If String.IsNullOrEmpty(txtThang.Text) Then
                dep.SetError(txtThang, "Số liệu không hợp lệ")
                e.Cancel = True
                Return
            End If

            Dim i As Integer = 0
            i = Integer.Parse(txtThang.EditValue.ToString())
            If (i <= 12) And (i >= 1) Then
                dep.SetError(txtThang, "")
                e.Cancel = False
            Else
                dep.SetError(txtThang, "Số liệu không hợp lệ")
                e.Cancel = True
            End If
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub txtNam_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtNam.Validating
        Try
            If String.IsNullOrEmpty(txtNam.Text) Then
                dep.SetError(txtNam, "Số liệu không hợp lệ")
                e.Cancel = True
                Return
            End If

            Dim i As Integer = 0
            i = Integer.Parse(txtNam.EditValue.ToString())
            If (i <= 2050) And (i >= 1990) Then
                dep.SetError(txtNam, "")
                e.Cancel = False
            Else
                dep.SetError(txtNam, "Số liệu không hợp lệ")
                e.Cancel = True
            End If
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub
End Class