Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraEditors

Imports DevExpress.XtraEditors.DXErrorProvider
Imports System.Collections
Imports DevExpress.XtraGrid.Columns
Imports Vns.Erp.Core.Admin.Domain
Imports Vns.Erp.Core.Admin.Service
Imports Vns.Erp.Core.Admin.Service.Interface

Partial Public Class frmDanhMucLoaiChungTu_ChiTiet
    Inherits FrmBaseDmChiTiet

#Region "Property"
    Dim _DmTaiKhoanService As IDmTaikhoanService
    Public Overridable Property DmTaikhoanService() As IDmTaikhoanService
        Get
            Return _DmTaiKhoanService
        End Get
        Set(ByVal value As IDmTaikhoanService)
            _DmTaiKhoanService = value
        End Set
    End Property
    Dim _HtLoaichungtuService As IHtLoaichungtuService
    Public Overridable Property HtLoaichungtuService() As IHtLoaichungtuService
        Get
            Return _HtLoaichungtuService
        End Get
        Set(ByVal value As IHtLoaichungtuService)
            _HtLoaichungtuService = value
        End Set
    End Property
#End Region

#Region "Variables and Messages"
    Private _temp As HtLoaichungtu = New HtLoaichungtu()
    Private LIST_DM As List(Of DMOrder)
    Private MAX_LENGTH As Integer = 25
    Private p_MA_CT As String
    Private temp_MA_CT As String = String.Empty

    Private _ObjectInfo As HtLoaichungtu
    Public Property ObjectInfo() As HtLoaichungtu
        Get
            If Not ID Is Nothing Then
                _ObjectInfo = HtLoaichungtuService.GetById(New Guid(ID.ToString()))
            Else
                _ObjectInfo = New HtLoaichungtu()
            End If

            _ObjectInfo.LoaiCtIdCha = VnsConvert.CGuid(cboLOAI_CT_ID_CHA.EditValue)
            _ObjectInfo.SdTkThueNgamdinh = TNCommon.ParseDecimal(chkSD_TK_THUE_NGAMDINH.Checked)
            _ObjectInfo.TkThueNgamdinh = txtTkThueNgamDinh.Text
            _ObjectInfo.MaLoaiCt = txtMA_LOAI_CT.Text
            _ObjectInfo.KyHieu = txtKy_Hieu.Text
            _ObjectInfo.TenLoaiCt = txtTEN_LOAI_CT.Text
            _ObjectInfo.PrefixCt = txtPREFIX_CT.Text
            _ObjectInfo.MauSoCt = txtMAU_SO_CT.Text
            _ObjectInfo.MoTa = txtMO_TA.Text
            _ObjectInfo.MaTkCoLq = txtMA_TK_CO_LQ.Text
            _ObjectInfo.MaTkNoLq = txtMA_TK_NO_LQ.Text
            _ObjectInfo.PhieuXuat = Decimal.Parse(txtPHIEU_XUAT.Text)
            _ObjectInfo.KhoXuat = Decimal.Parse(txtKHO_XUAT.Text)
            _ObjectInfo.CoSuDung = TNCommon.ParseDecimal(chkCO_SU_DUNG.Checked)
            _ObjectInfo.DmPhongban = TNCommon.ParseDecimal(chkDM_PHONGBAN.Checked)
            _ObjectInfo.DmPtqt = TNCommon.ParseDecimal(chkDM_PTQT.Checked)
            _ObjectInfo.DmTudo1 = TNCommon.ParseDecimal(chkDM_TUDO1.Checked)
            _ObjectInfo.DmTudo2 = TNCommon.ParseDecimal(chkDM_TUDO2.Checked)
            _ObjectInfo.DmTudo3 = TNCommon.ParseDecimal(chkDM_TUDO3.Checked)
            _ObjectInfo.DmTudo4 = TNCommon.ParseDecimal(chkDM_TUDO4.Checked)
            _ObjectInfo.DmTudo5 = TNCommon.ParseDecimal(chkDM_TUDO5.Checked)
            _ObjectInfo.DmVuviec = TNCommon.ParseDecimal(chkDM_VUVIEC.Checked)
            _ObjectInfo.DmKhoanphi = TNCommon.ParseDecimal(chkDM_KHOANPHI.Checked)
            _ObjectInfo.DmHopdong = TNCommon.ParseDecimal(chkDM_HOPDONG.Checked)
            _ObjectInfo.DmKhang = TNCommon.ParseDecimal(chkDM_KHANG.Checked)
            _ObjectInfo.DmCbnv = TNCommon.ParseDecimal(chkDM_CBNV.Checked)
            _ObjectInfo.DmHoadon = TNCommon.ParseDecimal(chkDM_HOADON.Checked)
            _ObjectInfo.NguoiTao = Generals.USER.Id
            _ObjectInfo.NguoiSua = Generals.USER.Id
            _ObjectInfo.ChiTiet = TNCommon.ParseDecimal(chkCHI_TIET.Checked)
            _ObjectInfo.Mota01 = GetMota(1)
            _ObjectInfo.Mota02 = GetMota(2)
            _ObjectInfo.Mota03 = GetMota(3)
            _ObjectInfo.Mota04 = GetMota(4)
            _ObjectInfo.Mota05 = GetMota(5)
            _ObjectInfo.SoCtHienthi = Decimal.Parse(txtSO_CT_HIENTHI.Text)
            _ObjectInfo.DuongDan = txtDUONG_DAN.Text
            _ObjectInfo.DonviId = Generals.DON_VI.Id

            MyBase.ResultObject = _ObjectInfo
            Return _ObjectInfo
        End Get
        Set(ByVal value As HtLoaichungtu)
            _ObjectInfo = value

            cboLOAI_CT_ID_CHA.EditValue = _ObjectInfo.LoaiCtIdCha
            txtTkThueNgamDinh.Text = _ObjectInfo.TkThueNgamdinh
            chkSD_TK_THUE_NGAMDINH.Checked = TNCommon.ParseBool(_ObjectInfo.SdTkThueNgamdinh)
            txtMA_LOAI_CT.Text = _ObjectInfo.MaLoaiCt
            txtKy_Hieu.Text = _ObjectInfo.KyHieu
            txtTEN_LOAI_CT.Text = _ObjectInfo.TenLoaiCt
            txtPREFIX_CT.Text = _ObjectInfo.PrefixCt
            txtMAU_SO_CT.Text = _ObjectInfo.MauSoCt
            txtSO_CT_HIENTHI.Text = _ObjectInfo.SoCtHienthi
            txtMO_TA.Text = _ObjectInfo.MoTa
            txtDUONG_DAN.Text = _ObjectInfo.DuongDan
            txtMA_TK_NO_LQ.Text = _ObjectInfo.MaTkNoLq
            txtMA_TK_CO_LQ.Text = _ObjectInfo.MaTkCoLq
            txtPHIEU_XUAT.Text = _ObjectInfo.PhieuXuat
            txtKHO_XUAT.Text = _ObjectInfo.KhoXuat
            chkCO_SU_DUNG.Checked = TNCommon.ParseBool(_ObjectInfo.CoSuDung)
            chkDM_PHONGBAN.Checked = TNCommon.ParseBool(_ObjectInfo.DmPhongban)
            chkDM_PTQT.Checked = TNCommon.ParseBool(_ObjectInfo.DmPtqt)
            chkDM_TUDO1.Checked = TNCommon.ParseBool(_ObjectInfo.DmTudo1)
            chkDM_TUDO2.Checked = TNCommon.ParseBool(_ObjectInfo.DmTudo2)
            chkDM_TUDO3.Checked = TNCommon.ParseBool(_ObjectInfo.DmTudo3)
            chkDM_TUDO4.Checked = TNCommon.ParseBool(_ObjectInfo.DmTudo4)
            chkDM_TUDO5.Checked = TNCommon.ParseBool(_ObjectInfo.DmTudo5)
            chkDM_VUVIEC.Checked = TNCommon.ParseBool(_ObjectInfo.DmVuviec)
            chkDM_KHOANPHI.Checked = TNCommon.ParseBool(_ObjectInfo.DmKhoanphi)
            chkDM_HOPDONG.Checked = TNCommon.ParseBool(_ObjectInfo.DmHopdong)
            chkDM_KHANG.Checked = TNCommon.ParseBool(_ObjectInfo.DmKhang)
            chkDM_CBNV.Checked = TNCommon.ParseBool(_ObjectInfo.DmCbnv)
            chkDM_HOADON.Checked = TNCommon.ParseBool(_ObjectInfo.DmHoadon)
            chkCHI_TIET.Checked = TNCommon.ParseBool(_ObjectInfo.ChiTiet)
            txtSO_CT_HIENTHI.Text = _ObjectInfo.SoCtHienthi
        End Set
    End Property
#End Region

#Region "Construction"
    Public Sub New()
        InitializeComponent()
    End Sub
#End Region

#Region "Load Form"
    Public Overrides Sub InitProperty()
        TableName = "HtLoaichungtu"
        ButtonSave = btnSave
        ButtonCancel = btnCancel
        TNCommon.setIconControl(Me)
    End Sub

    Public Overrides Sub BindLookUpEdit()
        Dim dt As List(Of HtLoaichungtu) = New List(Of HtLoaichungtu)
        dt.AddRange(HtLoaichungtuService.GetByDonvi(Generals.DON_VI.Id))
        'Vns.Erp.Core.Dao.Util.DBUtil.ToDataTable(HtLoaichungtuService.GetAll())
        Dim root As HtLoaichungtu = New HtLoaichungtu()
        root.TenLoaiCt = "Danh mục gốc"
        root.Id = Guid.Empty
        root.MaLoaiCt = ""
        root.Cap = 1
        dt.Insert(0, root)
        Dim nhomdm As ArrayList = New ArrayList()
        nhomdm.Add(New ColumnInfo("TenLoaiCt", "Tên", 0, True, ""))
        TNCommon.BindData_LookupEdit(cboLOAI_CT_ID_CHA, dt, "TenLoaiCt", "Id", nhomdm, True, True)

        Dim dtTkNdinh As IList(Of DmTaikhoan) = DmTaikhoanService.GetAllByDonviID(Generals.DON_VI.Id)
        Dim _TkNdinhColumnDefine As ArrayList = New ArrayList()
        _TkNdinhColumnDefine.Add(New ColumnInfo("MaTaikhoan", "Mã tài khoản", 0, True, ""))
        _TkNdinhColumnDefine.Add(New ColumnInfo("TenTaikhoan", "Tên tài khoản", 0, True, ""))

        Try
            Me.ActiveControl = txtMA_LOAI_CT
            chkDM_TUDO1.Text = Generals.TS_TuDo1.GiaTri
            chkDM_TUDO2.Text = Generals.TS_TuDo2.GiaTri
            chkDM_TUDO3.Text = Generals.TS_TuDo3.GiaTri
            chkDM_TUDO4.Text = Generals.TS_TuDo4.GiaTri
            chkDM_TUDO5.Text = Generals.TS_TuDo5.GiaTri

            Dim ma_dm_str As String = ""
            Dim ten_dm_str As String = ""
            Dim thu_tu_str As String = ""

            If Mode = FormGlobals.DataInputState.AddMode Then
                TNCommon.SelectFirst(cboLOAI_CT_ID_CHA)

                ma_dm_str = "DM_PTQT;DM_PHONGBAN;DM_TUDO1;DM_TUDO2;DM_TUDO3;DM_TUDO4;DM_TUDO5;DM_VUVIEC;DM_KHOANPHI;DM_HOPDONG;DM_KHANG;DM_CBNV;;;;;;;;;;;;;"
                ten_dm_str = "DM PTQT;DM phòng ban;DM tự do 1;DM tự do 2;DM tự do 3;DM tự do 4;DM tự do 5;DM vụ việc;DM khoản phí;DM hợp đồng;DM khách hàng;DM CBNV;;;;;;;;;;;;;"
                thu_tu_str = "1;2;3;4;5;6;7;8;9;10;11;12;13;14;15;16;17;18;19;20;21;22;23;24;25"
            ElseIf Mode = FormGlobals.DataInputState.EditMode Then
                ma_dm_str = _temp.Mota01
                ten_dm_str = _temp.Mota02
                thu_tu_str = _temp.Mota03
            End If

            Dim arr_ma_dm() As String = ma_dm_str.Split(Char.Parse(";"))
            Dim arr_ten_dm() As String = ten_dm_str.Split(Char.Parse(";"))
            Dim arr_thu_tu() As String = thu_tu_str.Split(Char.Parse(";"))

            LIST_DM = New List(Of DMOrder)
            For i As Integer = 0 To arr_ma_dm.Length - 1
                If Not arr_ma_dm(i).Equals("") Then
                    LIST_DM.Add(New DMOrder(arr_ma_dm(i), arr_ten_dm(i), Integer.Parse(arr_thu_tu(i))))
                End If
            Next

            grcMain.DataSource = LIST_DM
            grvMain.Columns("MA_DM").OptionsColumn.AllowEdit = False
            grvMain.Columns("MA_DM").OptionsColumn.ReadOnly = True
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Public Overrides Sub BindData()
        _temp = HtLoaichungtuService().GetById(VnsConvert.CGuid(ID))
        Select Case Mode
            Case DataInputState.EditMode
                ObjectInfo = _temp
            Case DataInputState.AddMode
                ObjectInfo = New HtLoaichungtu()
        End Select
    End Sub

    Public Overrides Sub Saving()
        If Not Check_input() Then Return

        Dim info As HtLoaichungtu = New HtLoaichungtu()

        'Panel_GetControlValue(_panel1, info, TableName)
        'Panel_GetControlValue(GroupBox2, info, TableName)
        info = ObjectInfo()


        Select Case Mode
            Case FormGlobals.DataInputState.AddMode
                info.Id = Guid.NewGuid()
                ID = HtLoaichungtuService.SaveOrUpdate(info).Id

            Case FormGlobals.DataInputState.EditMode
                HtLoaichungtuService.SaveOrUpdate(info)
        End Select
        _ObjectInfo = info

        AfterSaveSuccess()
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub
#End Region

#Region "Event Handles"
    Private Sub chkSD_TK_THUE_NGAMDINH_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkSD_TK_THUE_NGAMDINH.CheckedChanged
        Try
            If chkSD_TK_THUE_NGAMDINH.Checked Then
                txtTkThueNgamDinh.Enabled = True
            Else
                txtTkThueNgamDinh.Enabled = False
            End If
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub frmDanhMucLoaiChungTu_ChiTiet_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub
#End Region

    Private Function Check_input() As Boolean
        If txtMA_LOAI_CT.Text.Trim = "" Then
            Message_Warning("Bạn chưa nhập mã loại chứng từ!")
            txtMA_LOAI_CT.Focus()
            Return False
        End If

        If txtKy_Hieu.Text.Trim = "" Then
            Message_Warning("Bạn chưa nhập ký hiệu loại chứng từ!")
            txtKy_Hieu.Focus()
            Return False
        End If

        If txtTEN_LOAI_CT.Text.Trim = "" Then
            Message_Warning("Bạn chưa nhập tên loại chứng từ!")
            txtTEN_LOAI_CT.Focus()
            Return False
        End If
        If txtSO_CT_HIENTHI.Text.Trim = "" Then
            Message_Warning("Bạn chưa nhập số chứng từ hiển thị!")
            txtSO_CT_HIENTHI.Focus()
            Return False
        End If



        If DB_GetString(cboLOAI_CT_ID_CHA.EditValue) = "" Then
            Message_Warning("Bạn chưa chọn nhóm loại chứng từ!")
            cboLOAI_CT_ID_CHA.Focus()
            Return False
        End If

        If txtMAU_SO_CT.Text.Trim = "" Then
            Message_Warning("Bạn chưa nhập mẫu số chứng từ!")
            txtMAU_SO_CT.Focus()
            Return False
        End If

        If txtPHIEU_XUAT.Text.Trim = "" Then
            Message_Warning("Bạn chưa nhập phiếu xuất")
            txtPHIEU_XUAT.Focus()
            Return False
        End If

        If txtKHO_XUAT.Text.Trim = "" Then
            Message_Warning("Bạn chưa nhập kho xuất")
            txtKHO_XUAT.Focus()
            Return False
        End If
        Select Case Mode
            Case DataInputState.AddMode
                p_MA_CT = txtMA_LOAI_CT.Text.Trim

                If HtLoaichungtuService.GetByMA_LOAI_CT(p_MA_CT, Generals.DON_VI.Id) IsNot Nothing Then
                    Message_Warning("Mã chứng từ này đã tồn tại!")
                    txtMA_LOAI_CT.Focus()
                    Return False
                End If
            Case DataInputState.EditMode
                If Not temp_MA_CT.Equals(txtMA_LOAI_CT.Text.Trim) Then
                    p_MA_CT = txtMA_LOAI_CT.Text
                Else
                    p_MA_CT = ""
                End If
        End Select
        Return True
    End Function

#Region "Common Functions"
    Private Function GetMota(ByVal num As Integer) As String
        Dim str As String = ""
        Select Case num
            Case 1 'MA_DM
                For i As Integer = 0 To grvMain.RowCount - 1
                    str = str + grvMain.GetRowCellValue(i, "MA_DM").ToString + ";"
                Next
                For j As Integer = 0 To (MAX_LENGTH - 1 - grvMain.RowCount)
                    str = str + ";"
                Next
            Case 2 'TEN_DM
                For i As Integer = 0 To grvMain.RowCount - 1
                    str = str + grvMain.GetRowCellValue(i, "TEN_DM").ToString + ";"
                Next
                For j As Integer = 0 To (MAX_LENGTH - 1 - grvMain.RowCount)
                    str = str + ";"
                Next
            Case 3 'THU_TU
                For i As Integer = 0 To grvMain.RowCount - 1
                    str = str + grvMain.GetRowCellValue(i, "THU_TU").ToString + ";"
                Next
                For j As Integer = 0 To (MAX_LENGTH - 1 - grvMain.RowCount)
                    str = str + ";"
                Next
            Case 4 'NOT USE
            Case 5 'NOT USE
        End Select
        Return str
    End Function

#End Region

End Class



