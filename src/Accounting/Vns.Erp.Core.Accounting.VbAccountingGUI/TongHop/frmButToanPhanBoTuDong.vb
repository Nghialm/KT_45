Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Columns

Imports Vns.Erp.Core.Admin.Domain
Imports Vns.Erp.Core.Accounting.Domain
Imports Vns.Erp.Core.Admin.Service.Interface
Imports Vns.Erp.Core.Accounting.Service.Interface

Public Class frmButToanPhanBoTuDong

#Region "Property"
    Private _KtThBtPhanboService As IKtThBtPhanboService
    Public Property KtThBtPhanboService As IKtThBtPhanboService
        Get
            Return _KtThBtPhanboService
        End Get
        Set(ByVal value As IKtThBtPhanboService)
            _KtThBtPhanboService = value
        End Set
    End Property

    Private _KtDmBtPhanboService As IKtDmBtPhanboService
    Public Property KtDmBtPhanboService As IKtDmBtPhanboService
        Get
            Return _KtDmBtPhanboService
        End Get
        Set(ByVal value As IKtDmBtPhanboService)
            _KtDmBtPhanboService = value
        End Set
    End Property

    Private _HtLoaichungtuService As IHtLoaichungtuService
    Public Property HtLoaichungtuService As IHtLoaichungtuService
        Get
            Return _HtLoaichungtuService
        End Get
        Set(ByVal value As IHtLoaichungtuService)
            _HtLoaichungtuService = value
        End Set
    End Property

    Private _DmKhangService As IDmKhangService
    Public Property DmKhangService As IDmKhangService
        Get
            Return _DmKhangService
        End Get
        Set(ByVal value As IDmKhangService)
            _DmKhangService = value
        End Set
    End Property

    Private _DmVuviecService As IDmVuviecService
    Public Property DmVuviecService As IDmVuviecService
        Get
            Return _DmVuviecService
        End Get
        Set(ByVal value As IDmVuviecService)
            _DmVuviecService = value
        End Set
    End Property

    Private _DmKhoanphiService As IDmKhoanphiService
    Public Property DmKhoanphiService As IDmKhoanphiService
        Get
            Return _DmKhoanphiService
        End Get
        Set(ByVal value As IDmKhoanphiService)
            _DmKhoanphiService = value
        End Set
    End Property

    Private _DmTudo1Service As IDmTudo1Service
    Public Property DmTudo1Service As IDmTudo1Service
        Get
            Return _DmTudo1Service
        End Get
        Set(ByVal value As IDmTudo1Service)
            _DmTudo1Service = value
        End Set
    End Property

    Private _DmHopdongService As IDmHopdongService
    Public Property DmHopdongService As IDmHopdongService
        Get
            Return _DmHopdongService
        End Get
        Set(ByVal value As IDmHopdongService)
            _DmHopdongService = value
        End Set
    End Property

    Private _HtDanhmucService As IHtDanhmucService
    Public Property HtDanhmucService As IHtDanhmucService
        Get
            Return _HtDanhmucService
        End Get
        Set(ByVal value As IHtDanhmucService)
            _HtDanhmucService = value
        End Set
    End Property

    Private _CtHService As ICtHService
    Public Property CtHService As ICtHService
        Get
            Return _CtHService
        End Get
        Set(ByVal value As ICtHService)
            _CtHService = value
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
#End Region

#Region "Variables"

    Dim p_nhom As String
    Dim p_nam As Integer
    Dim msgKhoaSo As String = "Tháng được chọn đã khóa sổ nên không thể phân bổ"
    Dim dicsotien As Dictionary(Of Decimal, Decimal) = New Dictionary(Of Decimal, Decimal)
    Public obj_loaichungtu As HtLoaichungtu = New HtLoaichungtu()

    'Danh sach cac but toan phan bo can thuc hien trong ky
    Dim lst_DM As List(Of KtDmBtPhanbo) = New List(Of KtDmBtPhanbo)()
    'Danh sach cac but toan phan bo da thuc hien trong ky
    Dim lst_TH As List(Of KtThBtPhanbo) = New List(Of KtThBtPhanbo)()
    'Danh sach cac nhom but toan da thuc hien trong ky
    Dim lst_TH_Cha As List(Of KtThBtPhanbo) = New List(Of KtThBtPhanbo)()
    'Danh sach chi tiet cac but toan da thuc hien trong ky
    Dim lst_TH_Con As List(Of KtThBtPhanbo) = New List(Of KtThBtPhanbo)()

    Dim thang As Decimal = 1
    Dim nam As Decimal = DateTime.Now.Year
#End Region

#Region "Contructor"

    'Loc nhom tren list va bind data vao grid cha
    Public Sub New()
        InitializeComponent()
        TNCommon.setIconControl(Me)
    End Sub

#End Region

#Region "Functions"

    Private Sub LoadGrv_Cha(ByVal Nam As Decimal)

        'Danh sach DM but toan phan bo
        lst_DM = New List(Of KtDmBtPhanbo)()
        lst_DM.AddRange(_KtDmBtPhanboService.GetByDonviId(Generals.DON_VI.Id))
        'Danh sach thuc hien trong ky
        lst_TH = New List(Of KtThBtPhanbo)()
        lst_TH.AddRange(_KtThBtPhanboService.GetObjectAllByThangNam(thang, Nam, Generals.DON_VI.Id))

        If (lst_TH Is Nothing Or lst_TH.Count = 0) Then
            lst_TH = New List(Of KtThBtPhanbo)()
            lst_TH.AddRange(_KtThBtPhanboService.ConvertListDM2THButToanPhanBo(lst_DM))
        End If
        lst_TH_Cha.Clear()
        dicsotien.Clear()

        Dim nhom As Integer = 0
        Dim i As Integer
        For i = 0 To lst_TH.Count - 1
            If (lst_TH(i).Nhom <> nhom) Then
                lst_TH_Cha.Add(lst_TH(i))
                nhom = lst_TH(i).Nhom
                If (dicsotien.ContainsKey(nhom) = False) Then
                    dicsotien.Add(lst_TH(i).Nhom, 0)
                End If
            End If
        Next

        _GridControlCha.DataSource = lst_TH_Cha
        '_GridViewCha.Columns("LOAI_PHANBO").ColumnEdit = TNCommon.LoaiKChuyen_ColumnEdit()
    End Sub

    'Load gridview con ung voi gia tri nhom cha
    Private Sub LoadGRV_Con(ByVal nhom As String)
        lst_TH_Con.Clear()
        For Each obj_con As KtThBtPhanbo In lst_TH
            If (obj_con.Nhom = nhom) Then
                lst_TH_Con.Add(obj_con)
            End If
        Next
        _GridControlCon.DataSource = lst_TH_Con
    End Sub

    Private Sub BindData()
        'bind Nam'
        cboKC_KH_Nam.DataSource = _DmKhangService.GetAllByDonviID(Generals.DON_VI.Id)
        cboKC_KH_Nam.DisplayMember = "TenKhang"
        cboKC_KH_Nam.ValueMember = "Id"
        cboKC_KH_Nam.Columns.Add(New LookUpColumnInfo("KyHieu", "Ký hiệu"))
        cboKC_KH_Nam.Columns.Add(New LookUpColumnInfo("TenKhang", "Tên khách hàng"))
        'bind vu viec
        cboKC_VUVIEC_NAM.DataSource = _DmVuviecService.GetAllByDonviID(Generals.DON_VI.Id)
        cboKC_VUVIEC_NAM.DisplayMember = "TenVuviec"
        cboKC_VUVIEC_NAM.ValueMember = "Id"
        cboKC_VUVIEC_NAM.Columns.Add(New LookUpColumnInfo("KyHieu", "Ký hiệu"))
        cboKC_VUVIEC_NAM.Columns.Add(New LookUpColumnInfo("TenVuviec", "Tên vụ việc"))
        'bind  phi
        cboKC_PHI_Nam.DataSource = _DmKhoanphiService.GetAllByDonviID(Generals.DON_VI.Id)
        cboKC_PHI_Nam.DisplayMember = "TenDmKhoanphi"
        cboKC_PHI_Nam.ValueMember = "Id"
        cboKC_PHI_Nam.Columns.Add(New LookUpColumnInfo("KyHieu", "Ký hiệu"))
        cboKC_PHI_Nam.Columns.Add(New LookUpColumnInfo("TenDmKhoanphi", "Tên khoản phí"))
        'bind DMTD
        cboKC_TUDO_NAM.DataSource = _DmTudo1Service.GetAllByDonviID(Generals.DON_VI.Id)
        cboKC_TUDO_NAM.DisplayMember = "TenDmTudo1"
        cboKC_TUDO_NAM.ValueMember = "Id"
        cboKC_TUDO_NAM.Columns.Add(New LookUpColumnInfo("KyHieu", "Ký hiệu"))
        cboKC_TUDO_NAM.Columns.Add(New LookUpColumnInfo("TenDmTudo1", "Tên danh mục tự do"))
        'bind Hop dong
        cboKC_HOPDONG_NAM.DataSource = _DmHopdongService.GetAllByDonviID(Generals.DON_VI.Id)
        cboKC_HOPDONG_NAM.DisplayMember = "TenHopdong"
        cboKC_HOPDONG_NAM.ValueMember = "Id"
        cboKC_HOPDONG_NAM.Columns.Add(New LookUpColumnInfo("KyHieu", "Ký hiệu"))
        cboKC_HOPDONG_NAM.Columns.Add(New LookUpColumnInfo("TenHopdong", "Tên hợp đồng"))

        'Bind Loai ket chuyen
        cboLoaiPhanBo.DataSource = _HtDanhmucService.GetByDoiTuong("LOAI_PHANBO")
        cboLoaiPhanBo.DisplayMember = "TenDanhmuc"
        cboLoaiPhanBo.ValueMember = "GiaTri"
        cboLoaiPhanBo.Columns.Add(New LookUpColumnInfo("TenDanhmuc", "Tên"))

        'Bind Loai ket chuyen
        cboPhuongPhapPB.DataSource = _HtDanhmucService.GetByDoiTuong("KIEU_PHANBO")
        cboPhuongPhapPB.DisplayMember = "TenDanhmuc"
        cboPhuongPhapPB.ValueMember = "GiaTri"
        cboPhuongPhapPB.Columns.Add(New LookUpColumnInfo("TenDanhmuc", "Tên"))

        'unbound column
        _GridControlCha.ForceInitialize()
    End Sub

    'luu cac but toan da phan bo
    Private Sub Save()
        Try
            If lst_TH.Count > 0 Then
                'Dim objctd As CT_DInfo
                Dim objcth As CtH = New CtH

                objcth.MaLoaiCt = obj_loaichungtu.MaLoaiCt
                objcth.KyHieuLoaiCt = obj_loaichungtu.KyHieu
                objcth.IdLoaiCt = obj_loaichungtu.Id

                objcth.NgayCt = DateSerial(nam, thang + 1, 0)
                objcth.NgayGhi = DateTime.Now
                objcth.NgayTao = DateTime.Now
                objcth.SoTien = 0
                objcth.DonviId = Generals.DON_VI.Id
                objcth.MaDonvi = Generals.DON_VI.MaDonvi
                objcth.TyGia = 1
                objcth.NgoaiTe = False
                objcth.NteId = VnsConvert.CGuid(Generals.TS_NoiTe_ID.GiaTri)

                Dim strSoCT As Integer
                Dim lst As List(Of String) = _HtLoaichungtuService.GetSoCT_prefix(obj_loaichungtu.Id, thang.ToString(), nam.ToString(), Generals.DON_VI.Id)
                objcth.CtSo = lst(0)

                For Each temp As KtThBtPhanbo In lst_TH
                    temp.Thang = thang
                    temp.Nam = nam
                Next
                _CtHService.SaveChungTuPhanBo(objcth, Nothing, lst_TH, thang)
            End If
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Function Check_input() As Boolean

        If String.IsNullOrEmpty(txtThang.Text) Then
            Message_Warning("Bạn chưa nhập tháng phân bổ")
            txtThang.Focus()
            Return False
        End If

        Dim deT As Decimal = Decimal.Parse(txtThang.Text.Trim)
        If deT < 1 Or deT > 12 Then
            Message_Warning("Số tháng nhập vào không hợp lệ")
            txtThang.Focus()
            Return False
        End If

        If String.IsNullOrEmpty(txtSoNamPhanBo.Text.Trim) Then
            Message_Warning("Bạn chưa nhập năm")
            Return False
        End If

        Dim de As Decimal = Decimal.Parse(txtSoNamPhanBo.Text)
        If de < 2000 Or de >= 2999 Then
            Message_Warning("Năm nhập vào không hợp lệ!")
            Return False
        End If
        Return True
    End Function
#End Region

#Region "Events"

    Private Sub frmButToanPhanBoTuDong_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            _GridViewCha.FixedLineWidth = 0
            _GridViewCon.FixedLineWidth = 0
            txtSoNamPhanBo.Text = Date.Today.Year

            'khai bao cac bien luu ma loai chung tu khi chon tren menu truyen vao
            Dim para_str As String = Me.AccessibleDescription
            Dim lst_para As List(Of ParamInfo) = DataMining.GetParams(para_str)
            If lst_para.Count > 0 Then
                'gan ma loai chung tu bang gia tri truyen tu menu
                obj_loaichungtu.MaLoaiCt = lst_para(0).PARAMVALUE
            End If
            'khai bao 1 obj luu data lay duoc theo ma loai chung tu
            obj_loaichungtu = _HtLoaichungtuService.GetByMA_LOAI_CT(obj_loaichungtu.MaLoaiCt, Generals.DON_VI.Id)
            'gan ten form theo ten quy dinh trong bang HT loai chung tu
            'Me.Text = obj_loaichungtu.TEN_LOAI_CT

            LoadGrv_Cha(Decimal.Parse(txtSoNamPhanBo.Text))
            If _GridViewCha.RowCount <> 0 Then
                LoadGRV_Con(p_nhom)
            End If

            BindData()
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

    Private Sub btnTaoButToan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTao.Click
        Try
            If _GridViewCha.RowCount = 0 Then
                Message_Warning("Không có bản ghi nào trong danh sách!")
                Return
            End If
            btnTao.Enabled = True
            'Tinh so tien tung thang voi he so va so tien phan bo tuong ung
            For Each obj_Nhom As KtThBtPhanbo In lst_TH_Cha
                Dim sotien As Decimal = dicsotien(obj_Nhom.Nhom)
                For Each obj As KtThBtPhanbo In lst_TH
                    If (obj.Nhom = obj_Nhom.Nhom) Then
                        obj.SoTienPb = obj.TyLePb * sotien / 100
                    End If
                    _GridViewCon.RefreshData()
                Next
            Next
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    'load gridView con theo nhom
    Private Sub _GridViewCha_FocusedRowChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles _GridViewCha.FocusedRowChanged
        Try
            Dim sotien As Decimal = 0
            If (_GridViewCha.RowCount <> 0) Then
                Dim gridbtpbtd As KtThBtPhanbo = CType(_GridViewCha.GetRow(_GridViewCha.FocusedRowHandle), KtThBtPhanbo)
                p_nhom = gridbtpbtd.Nhom
                LoadGRV_Con(p_nhom)
                _GridViewCon.RefreshData()
            End If
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub btnLuuButToan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSav.Click
        Try
            If Not Check_input() Then
                Return
            End If
            If String.IsNullOrEmpty(txtThang.Text) Then
                Message_Warning("Bạn chưa chọn tháng!")
                Return
            End If
            Dim ngaytinh As DateTime = New DateTime(Decimal.Parse(txtSoNamPhanBo.Text.Trim), Decimal.Parse(txtThang.Text.Trim), 1)
            'Check khoa so thang
            If _KtKhoasoThangService.KiemTraKhoaSo(ngaytinh, Generals.DON_VI.Id) Then
                Message_Warning(msgKhoaSo)
                Exit Sub
            End If
            If _GridViewCha.RowCount <> 0 Then
                frmProgress.Instance.Thread = AddressOf Save
                frmProgress.Instance.SetFinishText("Data saved")
                frmProgress.Instance.Show_Progress()
            Else
                Message_Warning("Không tồn tại bản ghi nào!")
            End If
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnXacNhan.Click
        Try
            If Not Check_input() Then
                Return
            End If
            lst_TH.Clear()

            nam = Integer.Parse(txtSoNamPhanBo.Text)
            thang = Integer.Parse(txtThang.Text)

            grcCha.Enabled = True
            GrcCon.Enabled = True
            btnDelete.Enabled = True
            'pncNhap.Enabled = True
            LoadGrv_Cha(nam)
            If (_GridViewCha.RowCount <> 0) Then
                LoadGRV_Con(p_nhom)
            Else
                LoadGRV_Con(-1)
            End If
            _GridViewCha.RefreshData()
            _GridViewCon.RefreshData()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    'validate row tren grid
    Private Sub _GridViewCon_ValidateRow(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles _GridViewCon.ValidateRow
        Dim view As ColumnView = CType(sender, ColumnView)
        Dim HST1 As Decimal = view.GetRowCellDisplayText(e.RowHandle, view.Columns("TyLePb"))
        Dim sum1 As Decimal
        sum1 = 0

        For i = 0 To lst_TH_Con.Count - 1
            sum1 = sum1 + lst_TH_Con(i).TyLePb
        Next

        If (HST1 < 0 Or HST1 > 100 Or sum1 > 100) Then
            e.Valid = False
            view.SetColumnError(view.Columns("TyLePb"), "Số nhập vào có giá trị không phù hợp ")
        End If
    End Sub

    Private Sub _GridViewCon_InvalidRowException(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs) Handles _GridViewCon.InvalidRowException
        e.ExceptionMode = ExceptionMode.NoAction
    End Sub

    'delete 
    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Try
            If _GridViewCha.RowCount = 0 Then
                Message_Warning("Không có bản ghi nào được chọn!")
                Return
            End If
            If (MessageBox.Show(ConstantMsgs.MSG_CONFIRM_FOR_DELETE, "Confirmation", MessageBoxButtons.YesNo) <> DialogResult.Yes) Then Return
            Dim objNhom As KtThBtPhanbo = CType(_GridViewCha.GetRow(_GridViewCha.FocusedRowHandle), KtThBtPhanbo)
            If objNhom Is Nothing Then
                Return
            End If
            For Each obj As KtThBtPhanbo In lst_TH
                If (obj.Nhom = objNhom.Nhom) Then
                    _KtThBtPhanboService.DeleteByThangNam(thang, nam, Generals.DON_VI.Id)
                    _GridViewCha.RefreshData()
                    _GridViewCon.RefreshData()
                End If
            Next
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub _GridViewCon_CellValueChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles _GridViewCon.CellValueChanged
        Try
            Dim sum1 As Integer
            sum1 = 0

            For i = 0 To lst_TH_Con.Count - 2
                sum1 = sum1 + lst_TH_Con(i).TyLePb
            Next

            'Tinh he so cho row cuoi
            If (lst_TH_Con.Count > 1) Then
                For Each obj As KtThBtPhanbo In lst_TH_Con
                    Select Case e.Column.Name
                        Case "TY_LE_PB"
                            If (sum1 < 100) Then
                                lst_TH_Con(lst_TH_Con.Count - 1).TyLePb = 100 - sum1
                                _GridViewCon.RefreshData()
                            Else
                                lst_TH_Con(lst_TH_Con.Count - 1).TyLePb = 0
                            End If
                    End Select
                Next
            End If
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub _GridViewCha_CustomUnboundColumnData(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs) Handles _GridViewCha.CustomUnboundColumnData
        Try
            'set, get gia tri cho unbound coloumn
            If e.Column.FieldName = "SoTien" And e.IsGetData Then
                Dim objtemp As KtThBtPhanbo = CType(_GridViewCha.GetRow(e.ListSourceRowIndex), KtThBtPhanbo)
                e.Value = dicsotien(objtemp.Nhom)
            End If
            If e.Column.FieldName = "SoTien" And e.IsSetData Then
                Dim objtemp As KtThBtPhanbo = CType(_GridViewCha.GetRow(e.ListSourceRowIndex), KtThBtPhanbo)
                dicsotien(objtemp.Nhom) = Decimal.Parse(_GridViewCha.ActiveEditor.EditValue.ToString())
            End If
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub frmButToanPhanBoTuDong_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Try
            Select Case e.KeyCode
                Case Keys.Escape
                    Me.Close()
            End Select
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub btnSoDu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSoDu.Click
        Try
            If _GridViewCha.RowCount = 0 Then
                Message_Warning("Không có bản ghi nào trong danh sách!")
                Return
            End If
            Dim Ji As Decimal
            'For i = 0 To lst_TH_Cha.Count - 1
            '    If lst_TH_Cha(i).LoaiPhanbo = 1 Then
            '        Ji = CT_Phanbo_NamBO.Instance.LayDuNo(lst_TH_Cha(i).MA_TK_PHANBO, Generals.DON_VI.Id, DateSerial(nam, thang + 1, 0)).Tables(0).Rows(0)("sotien")
            '        dicsotien(lst_TH_Cha(i).Nhom) = Ji
            '    Else
            '        Ji = CT_Phanbo_NamBO.Instance.LayDuCo(lst_TH_Cha(i).MA_TK_PHANBO, Generals.DON_VI.Id, DateSerial(nam, thang + 1, 0)).Tables(0).Rows(0)("sotien")
            '        dicsotien(lst_TH_Cha(i).Nhom) = Ji
            '    End If
            'Next

            _GridViewCha.RefreshData()

        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub


#End Region

End Class