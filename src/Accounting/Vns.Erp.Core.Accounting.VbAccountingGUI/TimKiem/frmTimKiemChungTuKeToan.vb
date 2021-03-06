Imports DevExpress.XtraGrid.Views.Base
Imports Vns.Erp.Core.Accounting.Domain
Imports Vns.Erp.Core.Admin.Domain
Imports Vns.Erp.Core.Accounting.Service.Interface
Imports Vns.Erp.Core.Admin.Service.Interface

Public Class frmTimKiemChungTuKeToan

#Region "Property"
    Private _CtHService As ICtHService

    Public Property CtHService() As ICtHService
        Get
            Return _CtHService
        End Get
        Set(ByVal value As ICtHService)
            _CtHService = value
        End Set
    End Property
    Private _CtDService As ICtDService

    Public Property CtDService() As ICtDService
        Get
            Return _CtDService
        End Get
        Set(ByVal value As ICtDService)
            _CtDService = value
        End Set
    End Property
    Private _DmTaikhoanService As IDmTaikhoanService

    Public Property DmTaikhoanService() As IDmTaikhoanService
        Get
            Return _DmTaikhoanService
        End Get
        Set(ByVal value As IDmTaikhoanService)
            _DmTaikhoanService = value
        End Set
    End Property
    Private _DmVuviecService As IDmVuviecService

    Public Property DmVuviecService() As IDmVuviecService
        Get
            Return _DmVuviecService
        End Get
        Set(ByVal value As IDmVuviecService)
            _DmVuviecService = value
        End Set
    End Property
    Private _DmPtqtService As IDmPtqtService

    Public Property DmPtqtService() As IDmPtqtService
        Get
            Return _DmPtqtService
        End Get
        Set(ByVal value As IDmPtqtService)
            _DmPtqtService = value
        End Set
    End Property
    Private _DmKhoanphiService As IDmKhoanphiService

    Public Property DmKhoanphiService() As IDmKhoanphiService
        Get
            Return _DmKhoanphiService
        End Get
        Set(ByVal value As IDmKhoanphiService)
            _DmKhoanphiService = value
        End Set
    End Property
    Private _DmHopdongService As IDmHopdongService

    Public Property DmHopdongService() As IDmHopdongService
        Get
            Return _DmHopdongService
        End Get
        Set(ByVal value As IDmHopdongService)
            _DmHopdongService = value
        End Set
    End Property
    Private _DmPhongbanService As IDmPhongbanService

    Public Property DmPhongbanService() As IDmPhongbanService
        Get
            Return _DmPhongbanService
        End Get
        Set(ByVal value As IDmPhongbanService)
            _DmPhongbanService = value
        End Set
    End Property
    Private _DmTudo1Service As IDmTudo1Service

    Public Property DmTudo1Service() As IDmTudo1Service
        Get
            Return _DmTudo1Service
        End Get
        Set(ByVal value As IDmTudo1Service)
            _DmTudo1Service = value
        End Set
    End Property
    Private _DmTudo2Service As IDmTudo2Service

    Public Property DmTudo2Service() As IDmTudo2Service
        Get
            Return _DmTudo2Service
        End Get
        Set(ByVal value As IDmTudo2Service)
            _DmTudo2Service = value
        End Set
    End Property
    Private _DmTudo3Service As IDmTudo3Service

    Public Property DmTudo3Service() As IDmTudo3Service
        Get
            Return _DmTudo3Service
        End Get
        Set(ByVal value As IDmTudo3Service)
            _DmTudo3Service = value
        End Set
    End Property
    Private _DmTudo4Service As IDmTudo4Service

    Public Property DmTudo4Service() As IDmTudo4Service
        Get
            Return _DmTudo4Service
        End Get
        Set(ByVal value As IDmTudo4Service)
            _DmTudo4Service = value
        End Set
    End Property
    Private _DmTudo5Service As IDmTudo5Service

    Public Property DmTudo5Service() As IDmTudo5Service
        Get
            Return _DmTudo5Service
        End Get
        Set(ByVal value As IDmTudo5Service)
            _DmTudo5Service = value
        End Set
    End Property
#End Region

#Region "Variable"

    Private m_MA_LOAI_CT As String
    Private lstobj_ct_h As List(Of CtH)
    Private lstobj_ct_h_gg As List(Of Extend.CT_H_GInfo)
#End Region

#Region "Contructor"

    Public Sub New()
        InitializeComponent()
    End Sub
#End Region

#Region "Functions"

    Public Function Show_Form(ByVal MA_LOAI_CT As String) As List(Of Extend.CT_H_GInfo)
        Try
            _GridView.Columns("Ghi").Visible = Generals.Ts_PheDuyetChungTu

            dteTuNgay.DateTime = New DateTime(DateTime.Now.Year, DateTime.Now.Month, 1)
            dteDenNgay.DateTime = DateTime.Now

            Form_InitDialog(Me)
            m_MA_LOAI_CT = MA_LOAI_CT
            BindLookUp()
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
        Dim tuso As String = txtTuSo.Text.Trim
        Dim sophieuden As String = ""
        Dim tungay As DateTime = dteTuNgay.DateTime
        If tungay = Nothing Then
            tungay = DateTime.MinValue
        Else
            tungay = tungay
        End If

        Dim denngay As DateTime = dteDenNgay.DateTime
        If denngay = Nothing Then
            denngay = DateTime.MaxValue
        Else
            denngay = denngay
        End If

        Dim ghi As Decimal
        'If String.IsNullOrEmpty(txttrangthai.Text) Then
        '    ghi = 0
        'Else
        '    ghi = Convert.ToDecimal(txttrangthai.Text)
        'End If
        ghi = 0
        Dim makhach As String = txtMaKhach.Text.Trim

        Dim pram_tkco As String = GetPramTk(txtTaiKhoanCo.Text.Trim)
        Dim pram_tkno As String = GetPramTk(txtTaiKhoanNo.Text.Trim)

        Dim sotientu As Decimal
        If String.IsNullOrEmpty(txtSoTienTu.Text) Then
            sotientu = 0
        Else
            sotientu = Convert.ToDecimal(txtSoTienTu.Text)
        End If
        Dim sotienden As Decimal
        If String.IsNullOrEmpty(txtSoTienDen.Text) Then
            sotienden = 0
        Else
            sotienden = Convert.ToDecimal(txtSoTienDen.Text)
        End If
        Dim noidung As String = txtDienGiaiChua.Text.Trim
        Dim khoanphi As Guid = cboKhoanPhi.EditValue

        Dim vuviec As Guid = cboVuViec.EditValue

        Dim hopdong As Guid = cboHopDong.EditValue

        Dim phongban As Guid = cboPhongBan.EditValue

        Dim tudo1 As Guid = cboTuDo1.EditValue

        Dim tudo2 As Guid = cboTuDo2.EditValue

        Dim tudo3 As Guid = cboTuDo3.EditValue

        Dim tudo4 As Guid = cboTuDo4.EditValue

        Dim tudo5 As Guid = cboTuDo5.EditValue

        lstobj_ct_h = New List(Of CtH)
        lstobj_ct_h.AddRange(_CtHService.SearchChungTu(Generals.DON_VI.Id, m_MA_LOAI_CT, tuso, sophieuden, tungay, denngay, _
                                              ghi, makhach, pram_tkco, pram_tkno, sotientu, sotienden, noidung, khoanphi, _
                                              vuviec, hopdong, phongban, tudo1, tudo2, tudo3, tudo4, tudo5))

        lstobj_ct_h_gg = New List(Of Extend.CT_H_GInfo)
        lstobj_ct_h_gg.AddRange(Commons.ConvertLstObjCtHtoCtHG(lstobj_ct_h))
        If lstobj_ct_h_gg Is Nothing Then
            lstobj_ct_h_gg = New List(Of Extend.CT_H_GInfo)
        End If
        _GridControl.DataSource = lstobj_ct_h

        If lstobj_ct_h.Count = 0 Then
            btnXac.Enabled = False
        Else
            btnXac.Enabled = True
        End If

    End Sub

    Private Function GetPramTk(ByVal tk As String) As String
        Dim pram_tk As String = String.Empty
        If Not String.IsNullOrEmpty(tk) Then
            'Dim str As String()
            If tk.Substring(tk.Count() - 1, 1).Equals(";") Then
                pram_tk = tk.Substring(0, tk.Count() - 1)
            Else
                'str = tk.Split(New Char() {";"c})
                pram_tk = tk
            End If
            'For Each i As String In str
            '    pram_tk = pram_tk + "'" + i + "'" + ","
            'Next
            'If pram_tk.Substring(pram_tk.Count() - 1, 1).Equals(",") Then
            '    pram_tk = pram_tk.Substring(0, pram_tk.Count() - 1)
            'End If
            'Else
            'pram_tk = "''"
        End If
        Return pram_tk
    End Function

    Private Sub LoadGRV(ByVal CTH_ID As CtH)
        'Dim lstobj_ct_d As List(Of CtD) = _CtDService.GetByCtHandNghiepVu(CTH_ID, 0)
        gridControl1.DataSource = CTH_ID.LstCtD
    End Sub

    Private Sub BindLookUp()

        Dim lstPPQTNo As List(Of DmPtqt) = New List(Of DmPtqt)
        lstPPQTNo.AddRange(_DmPtqtService.GetAllByDonviID(Generals.DON_VI.Id))
        cboPTQTNo.DataSource = lstPPQTNo
        cboPTQTNo.DisplayMember = "KyHieu"
        cboPTQTNo.ValueMember = "Id"

        Dim lstPPQTCo As List(Of DmPtqt) = New List(Of DmPtqt)
        lstPPQTCo.AddRange(_DmPtqtService.GetAllByDonviID(Generals.DON_VI.Id))
        cboPTQTCo.DataSource = lstPPQTCo
        cboPTQTCo.DisplayMember = "KyHieu"
        cboPTQTCo.ValueMember = "Id"

        Dim lstVuViecNo As List(Of DmVuviec) = New List(Of DmVuviec)
        lstVuViecNo.AddRange(_DmVuviecService.GetAllByDonviID(Generals.DON_VI.Id))
        cboVuviecNo.DataSource = lstVuViecNo
        cboVuviecNo.DisplayMember = "TenVuviec"
        cboVuviecNo.ValueMember = "Id"

        Dim lstVuViecCo As List(Of DmVuviec) = New List(Of DmVuviec)
        lstVuViecCo.AddRange(_DmVuviecService.GetAllByDonviID(Generals.DON_VI.Id))
        cboVuviecCo.DataSource = lstVuViecCo
        cboVuviecCo.DisplayMember = "TenVuviec"
        cboVuviecCo.ValueMember = "Id"

        Dim objColumnDefine As ArrayList
        'bind khoan phi
        Dim lstKhoanPhi As List(Of DmKhoanphi) = New List(Of DmKhoanphi)
        lstKhoanPhi.AddRange(_DmKhoanphiService.GetAllByDonviID(Generals.DON_VI.Id))
        Dim lstKhoanPhiTemp As List(Of DmKhoanphi) = New List(Of DmKhoanphi)
        Dim KhoanPhi As DmKhoanphi = New DmKhoanphi()
        KhoanPhi.TenDmKhoanphi = ""
        KhoanPhi.KyHieu = ""
        KhoanPhi.MaDmKhoanphi = ""
        KhoanPhi.Id = New Guid
        lstKhoanPhiTemp.Add(KhoanPhi)
        lstKhoanPhiTemp.AddRange(lstKhoanPhi)
        objColumnDefine = New ArrayList
        objColumnDefine.Add(New LookupEdit_ColumnInfo("KyHieu", "Mã khoản phí"))
        objColumnDefine.Add(New LookupEdit_ColumnInfo("TenDmKhoanphi", "Tên khoản phí"))
        LookupEdit_BindData(cboKhoanPhi, lstKhoanPhiTemp, "KyHieu", "Id", COMBO_ITEM_REQUIRE, objColumnDefine)

        'bind vu viec
        Dim lstVuViec As List(Of DmVuviec) = New List(Of DmVuviec)
        lstVuViec.AddRange(_DmVuviecService.GetAllByDonviID(Generals.DON_VI.Id))
        Dim lstVuViecTemp As List(Of DmVuviec) = New List(Of DmVuviec)
        Dim VuViec As DmVuviec = New DmVuviec()
        VuViec.TenVuviec = ""
        VuViec.KyHieu = ""
        VuViec.MaVuviec = ""
        VuViec.Id = New Guid
        lstVuViecTemp.Add(VuViec)
        lstVuViecTemp.AddRange(lstVuViec)
        objColumnDefine = New ArrayList
        objColumnDefine.Add(New LookupEdit_ColumnInfo("KyHieu", "Mã vụ việc"))
        objColumnDefine.Add(New LookupEdit_ColumnInfo("TenVuviec", "Tên vụ việc"))
        LookupEdit_BindData(cboVuViec, lstVuViecTemp, "KyHieu", "Id", COMBO_ITEM_REQUIRE, objColumnDefine)

        'bind hopdong
        Dim lstHopDong As List(Of DmHopdong) = New List(Of DmHopdong)
        lstHopDong.AddRange(_DmHopdongService.GetAllByDonviID(Generals.DON_VI.Id))
        Dim lstHopDongTemp As List(Of DmHopdong) = New List(Of DmHopdong)
        Dim HopDong As DmHopdong = New DmHopdong()
        HopDong.TenHopdong = ""
        HopDong.KyHieu = ""
        HopDong.MaHopdong = ""
        HopDong.Id = New Guid
        lstHopDongTemp.Add(HopDong)
        lstHopDongTemp.AddRange(lstHopDong)
        objColumnDefine = New ArrayList
        objColumnDefine.Add(New LookupEdit_ColumnInfo("KyHieu", "Mã hợp đồng"))
        objColumnDefine.Add(New LookupEdit_ColumnInfo("TenHopdong", "Tên hợp đồng"))
        LookupEdit_BindData(cboHopDong, lstHopDongTemp, "KyHieu", "Id", COMBO_ITEM_REQUIRE, objColumnDefine)

        'bind phong ban
        Dim lstPhongBan As List(Of DmPhongban) = New List(Of DmPhongban)
        lstPhongBan.AddRange(_DmPhongbanService.GetAllByDonviID(Generals.DON_VI.Id))
        Dim lstPhongBanTemp As List(Of DmPhongban) = New List(Of DmPhongban)
        Dim PhongBan As DmPhongban = New DmPhongban()
        PhongBan.TenPhongban = ""
        PhongBan.KyHieu = ""
        PhongBan.MaPhongban = ""
        PhongBan.Id = New Guid
        lstPhongBanTemp.Add(PhongBan)
        lstPhongBanTemp.AddRange(lstPhongBan)
        objColumnDefine = New ArrayList
        objColumnDefine.Add(New LookupEdit_ColumnInfo("KyHieu", "Mã phòng ban"))
        objColumnDefine.Add(New LookupEdit_ColumnInfo("TenPhongban", "Tên phòng ban"))
        LookupEdit_BindData(cboPhongBan, lstPhongBanTemp, "KyHieu", "Id", COMBO_ITEM_REQUIRE, objColumnDefine)

        'bind tu do 1
        Dim lstTuDo1 As List(Of DmTudo1) = New List(Of DmTudo1)
        lstTuDo1.AddRange(_DmTudo1Service.GetAllByDonviID(Generals.DON_VI.Id))
        Dim listTuDo1 As List(Of DmTudo1) = New List(Of DmTudo1)
        Dim TuDo1 As DmTudo1 = New DmTudo1()
        listTuDo1.Add(TuDo1)
        listTuDo1.AddRange(lstTuDo1)
        objColumnDefine = New ArrayList
        objColumnDefine.Add(New LookupEdit_ColumnInfo("KyHieu", "Mã danh mục"))
        objColumnDefine.Add(New LookupEdit_ColumnInfo("TenDmTudo1", "Tên danh mục"))
        LookupEdit_BindData(cboTuDo1, listTuDo1, "KyHieu", "Id", COMBO_ITEM_REQUIRE, objColumnDefine)

        'bind tu do 2
        Dim lstTuDo2 As List(Of DmTudo2) = New List(Of DmTudo2)
        lstTuDo2.AddRange(_DmTudo2Service.GetAllByDonviID(Generals.DON_VI.Id))
        Dim listTuDo2 As List(Of DmTudo2) = New List(Of DmTudo2)
        Dim TuDo2 As DmTudo2 = New DmTudo2()
        listTuDo2.Add(TuDo2)
        listTuDo2.AddRange(lstTuDo2)
        objColumnDefine = New ArrayList
        objColumnDefine.Add(New LookupEdit_ColumnInfo("KyHieu", "Mã danh mục"))
        objColumnDefine.Add(New LookupEdit_ColumnInfo("TenDmTudo2", "Tên danh mục"))
        LookupEdit_BindData(cboTuDo2, listTuDo2, "KyHieu", "Id", COMBO_ITEM_REQUIRE, objColumnDefine)

        'bind tu do 3
        Dim lstTuDo3 As List(Of DmTudo3) = New List(Of DmTudo3)
        lstTuDo3.AddRange(_DmTudo3Service.GetAllByDonviID(Generals.DON_VI.Id))
        Dim listTuDo3 As List(Of DmTudo3) = New List(Of DmTudo3)
        Dim TuDo3 As DmTudo3 = New DmTudo3()
        listTuDo3.Add(TuDo3)
        listTuDo3.AddRange(lstTuDo3)
        objColumnDefine = New ArrayList
        objColumnDefine.Add(New LookupEdit_ColumnInfo("KyHieu", "Mã danh mục"))
        objColumnDefine.Add(New LookupEdit_ColumnInfo("TenDmTudo3", "Tên danh mục"))
        LookupEdit_BindData(cboTuDo3, listTuDo3, "KyHieu", "Id", COMBO_ITEM_REQUIRE, objColumnDefine)

        'bind tu do 4
        Dim lstTuDo4 As List(Of DmTudo4) = New List(Of DmTudo4)
        lstTuDo4.AddRange(_DmTudo4Service.GetAllByDonviID(Generals.DON_VI.Id))
        Dim listTuDo4 As List(Of DmTudo4) = New List(Of DmTudo4)
        Dim TuDo4 As DmTudo4 = New DmTudo4()
        listTuDo4.Add(TuDo4)
        listTuDo4.AddRange(lstTuDo4)
        objColumnDefine = New ArrayList
        objColumnDefine.Add(New LookupEdit_ColumnInfo("KyHieu", "Mã danh mục"))
        objColumnDefine.Add(New LookupEdit_ColumnInfo("TenDmTudo4", "Tên danh mục"))
        LookupEdit_BindData(cboTuDo4, listTuDo4, "KyHieu", "Id", COMBO_ITEM_REQUIRE, objColumnDefine)

        'bind tu do 5
        Dim lstTuDo5 As List(Of DmTudo5) = New List(Of DmTudo5)
        lstTuDo5.AddRange(DmTudo5Service.GetAllByDonviID(Generals.DON_VI.Id))
        Dim listTuDo5 As List(Of DmTudo5) = New List(Of DmTudo5)
        Dim TuDo5 As DmTudo5 = New DmTudo5()
        listTuDo5.Add(TuDo5)
        listTuDo5.AddRange(lstTuDo5)
        objColumnDefine = New ArrayList
        objColumnDefine.Add(New LookupEdit_ColumnInfo("KyHieu", "Mã danh mục"))
        objColumnDefine.Add(New LookupEdit_ColumnInfo("TenDmTudo5", "Tên danh mục"))
        LookupEdit_BindData(cboTuDo5, listTuDo5, "KyHieu", "Id", COMBO_ITEM_REQUIRE, objColumnDefine)
    End Sub

#End Region

#Region "Events"

    Private Sub btnNhan_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnXac.Click
        DialogResult = DialogResult.OK
    End Sub

    Private Sub btnSea_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSea.Click
        Try
            XtraTabControl1.SelectedTabPageIndex = 0
            frmProgress.Instance.Thread = AddressOf TimKiem
            frmProgress.Instance.Show_Progress()
            _GridView.FocusedRowHandle = -1
            _GridView.SelectRow(Handle)
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub _GridView_FocusedRowChanged(ByVal sender As Object, ByVal e As FocusedRowChangedEventArgs) _
        Handles _GridView.FocusedRowChanged
        Try
            Dim gridcth As CtH = CType(_GridView.GetRow(_GridView.FocusedRowHandle), CtH)

            If _GridView.RowCount <> 0 Then
                Dim CTHID As Guid = gridcth.Id
                LoadGRV(gridcth)

            Else
                gridControl1.DataSource = Nothing
            End If
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub cboKhoanPhi_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) _
        Handles cboKhoanPhi.EditValueChanged
        Try
            Dim drKhoanPhi As DmKhoanphi = ComboHelper.GetSelectData(cboKhoanPhi)
            If drKhoanPhi IsNot Nothing Then
                txtkhoanphi.Text = drKhoanPhi.TenDmKhoanphi
            End If
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub cboVuViec_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) _
        Handles cboVuViec.EditValueChanged
        Try
            Dim drVuViec As DmVuviec = ComboHelper.GetSelectData(cboVuViec)
            If drVuViec IsNot Nothing Then
                txtvuviec.Text = drVuViec.TenVuviec
            End If
        Catch ex As Exception
            Message_Error(ex)
        End Try

    End Sub

    Private Sub cboHopDong_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) _
        Handles cboHopDong.EditValueChanged
        Try
            Dim drHopDong As DmHopdong = ComboHelper.GetSelectData(cboHopDong)
            If drHopDong IsNot Nothing Then
                txthopdong.Text = drHopDong.TenHopdong
            End If
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub cboPhongBan_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) _
        Handles cboPhongBan.EditValueChanged
        Try
            Dim drPhongBan As DmPhongban = ComboHelper.GetSelectData(cboPhongBan)
            If drPhongBan IsNot Nothing Then
                txtphongban.Text = drPhongBan.TenPhongban
            End If
        Catch ex As Exception
            Message_Error(ex)
        End Try

    End Sub

    Private Sub cboTuDo1_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) _
        Handles cboTuDo1.EditValueChanged
        Try
            Dim drTuDo1 As DmTudo1 = ComboHelper.GetSelectData(cboTuDo1)
            If drTuDo1 IsNot Nothing Then
                txttudo1.Text = drTuDo1.TenDmTudo1
            End If
        Catch ex As Exception
            Message_Error(ex)
        End Try

    End Sub

    Private Sub cboTuDo2_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) _
        Handles cboTuDo2.EditValueChanged
        Try
            Dim drTuDo2 As DmTudo2 = ComboHelper.GetSelectData(cboTuDo2)
            If drTuDo2 IsNot Nothing Then
                txttudo2.Text = drTuDo2.TenDmTudo2
            End If
        Catch ex As Exception
            Message_Error(ex)
        End Try

    End Sub

    Private Sub cboTuDo3_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) _
        Handles cboTuDo3.EditValueChanged
        Try
            Dim drTuDo3 As DmTudo3 = ComboHelper.GetSelectData(cboTuDo3)
            If drTuDo3 IsNot Nothing Then
                txttudo3.Text = drTuDo3.TenDmTudo3
            End If
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub cboTuDo4_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) _
        Handles cboTuDo4.EditValueChanged
        Try
            Dim drTuDo4 As DmTudo4 = ComboHelper.GetSelectData(cboTuDo4)
            If drTuDo4 IsNot Nothing Then
                txttudo4.Text = drTuDo4.TenDmTudo4
            End If
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub cboTuDo5_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) _
        Handles cboTuDo5.EditValueChanged
        Try
            Dim drTuDo5 As DmTudo5 = ComboHelper.GetSelectData(cboTuDo5)
            If drTuDo5 IsNot Nothing Then
                txttudo5.Text = drTuDo5.TenDmTudo5
            End If
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub btnCan_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCan.Click
        Me.Close()
    End Sub

    Private Sub frmTimKiemChungTuKeToan_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Dim columnDefineNO As ArrayList = New ArrayList()
        columnDefineNO.Add(New ColumnInfo("MaTaikhoan", "Mã tài khoản", 0, True, ""))
        columnDefineNO.Add(New ColumnInfo("TenTaikhoan", "Tên tài khoản", 0, True, ""))

        Dim dtDmTaikhoan As DataTable = DataHelper.ToDataTable(_DmTaikhoanService.GetAllByDonviID(Generals.DON_VI.Id))
        Dim dtDmtk2 As DataTable = dtDmTaikhoan.Copy

        Dim beNo As Vns.Erp.Core.BaseGridPopupForm = _
            New Vns.Erp.Core.BaseGridPopupForm(txtTaiKhoanNo, "MaTaikhoan", _
                                                              dtDmTaikhoan, _
                                                               columnDefineNO)
        beNo.Text = "Chọn tài khoản"
        beNo.Size = New Size(500, 300)

        Dim columnDefineCO As ArrayList = New ArrayList()
        columnDefineCO.Add(New ColumnInfo("MaTaikhoan", "Mã tài khoản", 0, True, ""))
        columnDefineCO.Add(New ColumnInfo("TenTaikhoan", "Tên tài khoản", 0, True, ""))
        Dim beCo As Vns.Erp.Core.BaseGridPopupForm = _
            New Vns.Erp.Core.BaseGridPopupForm(txtTaiKhoanCo, "MaTaikhoan", _
                                                               dtDmtk2, _
                                                               columnDefineCO)
        beCo.Text = "Chọn tài khoản"
        beCo.Size = New Size(500, 300)
        'AddHandler txtMA_TK_NO_LQ.Validating, AddressOf ValidateData
        TNCommon.setIconControl(Me)

        btnXac.Enabled = False
        Me.ActiveControl = txtTuSo
    End Sub

    Private Sub frmTimKiemChungTuKeToan_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

#End Region

End Class