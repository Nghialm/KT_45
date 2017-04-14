Imports Vns.Erp.Core.Admin.Service.Interface
Imports Vns.Erp.Core.Admin.Domain

Public Class frmKhaiBaoGiamCCDC_ChiTiet

#Region "properties"

    Private _CcDmCcdcService As ICcDmCcdcService
    Public Property CcDmCcdcService() As ICcDmCcdcService
        Get
            Return _CcDmCcdcService
        End Get
        Set(ByVal value As ICcDmCcdcService)
            _CcDmCcdcService = value
        End Set
    End Property

    Private _CcCtCcdcService As ICcCtCcdcService
    Public Property CcCtCcdcService() As ICcCtCcdcService
        Get
            Return _CcCtCcdcService
        End Get
        Set(ByVal value As ICcCtCcdcService)
            _CcCtCcdcService = value
        End Set
    End Property


    Private _DmLydoTgTscdService As IDmLydoTgTscdService
    Public Property DmLydoTgTscdService() As IDmLydoTgTscdService
        Get
            Return _DmLydoTgTscdService
        End Get
        Set(ByVal value As IDmLydoTgTscdService)
            _DmLydoTgTscdService = value
        End Set
    End Property

#End Region

#Region "Variables"
    Private m_InputState As DataInputState
    Private m_CT_CCDC_Id As Guid
    Private m_Obj_CCDC_CT As CcCtCcdc
    Private IsInsert As Boolean = False
    Private m_OnLoadData As Boolean = False
#End Region

#Region "Show_form"

    Public Sub New()
        InitializeComponent()
        TNCommon.setIconControl(Me)
    End Sub

    Public Function Show_Form(ByVal p_CT_CCDC_Id As Guid, ByVal eState As DataInputState) As CcCtCcdc
        Try
            Form_InitDialog(Me)
            m_InputState = eState
            m_CT_CCDC_Id = p_CT_CCDC_Id
            m_InputState = eState
            ' Me.ActiveControl = txtMaCC
            frmProgress.Instance.Thread = AddressOf Init_Data
            frmProgress.Instance.Show_Progress()
        Catch ex As Exception
            Message_Error(ex)
        End Try

        If (Me.ShowDialog = DialogResult.OK) Then
            Return m_Obj_CCDC_CT
        Else
            Return Nothing
        End If
    End Function

#End Region

#Region "Functions"

    Private Sub Init_Data()
        m_OnLoadData = True
        BindDataToCbo()
        Select Case m_InputState
            Case DataInputState.AddMode

            Case DataInputState.EditMode
                SetObject()
        End Select
        m_OnLoadData = False
    End Sub

    Private Sub BindDataToCbo()
        ''bind ly do tang giam ccdc
        Dim _lstLydo As List(Of DmLydoTgTscd) = New List(Of DmLydoTgTscd)
        _lstLydo.Add(New DmLydoTgTscd)
        _lstLydo.AddRange(DmLydoTgTscdService.GetAll())
        grlMaGiam.Properties.DataSource = _lstLydo
        grlMaGiam.Properties.ValueMember = "Id"
        grlMaGiam.Properties.DisplayMember = "TenLydoTgTscd"

        ''Bind Dmtscd
        Dim _lstDmCcdc As List(Of CcDmCcdc) = New List(Of CcDmCcdc)
        _lstDmCcdc.Add(New CcDmCcdc)
        _lstDmCcdc.AddRange(CcDmCcdcService.GetAllByDonviID(Generals.DON_VI.Id))
        grlMaCCDC.Properties.DataSource = _lstDmCcdc
        grlMaCCDC.Properties.ValueMember = "Id"
        grlMaCCDC.Properties.DisplayMember = "MaCcdc"
    End Sub

    Private Sub GetObject()
        If m_Obj_CCDC_CT Is Nothing Then
            m_Obj_CCDC_CT = New CcCtCcdc
        End If

        Dim obj_CCDC As CcDmCcdc = CType(ComboHelper.GetSelectData(grlMaCCDC), CcDmCcdc)
        m_Obj_CCDC_CT.CcdcId = obj_CCDC.Id
        m_Obj_CCDC_CT.MaCcdc = obj_CCDC.MaCcdc
        m_Obj_CCDC_CT.TenCcdc = obj_CCDC.TenCcdc
        m_Obj_CCDC_CT.NuocSx = obj_CCDC.NuocSx
        m_Obj_CCDC_CT.NamSx = obj_CCDC.NamSx
        m_Obj_CCDC_CT.ThongsoKythuat = obj_CCDC.ThongsoKythuat
        m_Obj_CCDC_CT.NgayMua = obj_CCDC.NgayMua
        m_Obj_CCDC_CT.NgayBdsd = obj_CCDC.NgayBdsd
        m_Obj_CCDC_CT.NgayBdpb = obj_CCDC.NgayBdpb
        m_Obj_CCDC_CT.NgayKtpb = obj_CCDC.NgayKtpb
        m_Obj_CCDC_CT.NgayGiam = obj_CCDC.NgayGiam
        m_Obj_CCDC_CT.NgayTang = obj_CCDC.NgayTang
        m_Obj_CCDC_CT.SoKyPhanbo = obj_CCDC.SoKyPhanbo
        m_Obj_CCDC_CT.SoTienDaPhanbo = obj_CCDC.SoTienDaPhanbo
        m_Obj_CCDC_CT.GiaTriCl = obj_CCDC.GiaTriCl
        m_Obj_CCDC_CT.PhongbanId = obj_CCDC.PhongbanId
        m_Obj_CCDC_CT.MaPhongban = obj_CCDC.MaPhongban
        m_Obj_CCDC_CT.TenPhongban = obj_CCDC.TenPhongban
        m_Obj_CCDC_CT.TenLoaiPhanbo = obj_CCDC.TenLoaiPhanbo
        m_Obj_CCDC_CT.DvtId = obj_CCDC.DvtId
        m_Obj_CCDC_CT.MaDvt = obj_CCDC.MaDvt
        m_Obj_CCDC_CT.TenDvt = obj_CCDC.TenDvt
        m_Obj_CCDC_CT.DonviId = Generals.DON_VI.Id
        m_Obj_CCDC_CT.MaDonvi = Generals.DON_VI.MaDonvi
        m_Obj_CCDC_CT.MdTkCcdc = obj_CCDC.MdTkCcdc
        m_Obj_CCDC_CT.MdTkChiphi = obj_CCDC.MdTkChiphi
        m_Obj_CCDC_CT.MdTkPhanbo = obj_CCDC.MdTkPhanbo
        m_Obj_CCDC_CT.Nhom1 = obj_CCDC.Nhom1
        m_Obj_CCDC_CT.Nhom2 = obj_CCDC.Nhom2
        m_Obj_CCDC_CT.Nhom3 = obj_CCDC.Nhom3
        m_Obj_CCDC_CT.SoLuong = obj_CCDC.SoLuong
        m_Obj_CCDC_CT.NguyenGia = obj_CCDC.NguyenGia


        m_Obj_CCDC_CT.ThuTu = 1
        m_Obj_CCDC_CT.GiamCcdc = 2
        Dim obj_Lydo As DmLydoTgTscd = CType(ComboHelper.GetSelectData(grlMaGiam), DmLydoTgTscd)
        m_Obj_CCDC_CT.LyDoTangGiamId = obj_Lydo.Id
        m_Obj_CCDC_CT.TenLyDoTangGiam = obj_Lydo.TenLydoTgTscd
        m_Obj_CCDC_CT.GhiChu = txtGhiChu.Text
        m_Obj_CCDC_CT.NgayKtpb = dteNgayHetPb.DateTime
        m_Obj_CCDC_CT.SoCt = txtSoCt.Text
        m_Obj_CCDC_CT.NgayGiam = dteNgayGiam.DateTime

        obj_CCDC.GiamCcdc = 1

        'Save or update 
        CcDmCcdcService.SaveKhaiBaoGiam(IsInsert, obj_CCDC, m_Obj_CCDC_CT)

    End Sub

    Private Sub SetObject()
        m_Obj_CCDC_CT = CcCtCcdcService.GetById(m_CT_CCDC_Id)

        grlMaCCDC.EditValue = m_Obj_CCDC_CT.CcdcId
        grlMaGiam.EditValue = m_Obj_CCDC_CT.LyDoTangGiamId
        dteNgayGiam.DateTime = m_Obj_CCDC_CT.NgayGiam
        dteNgayHetPb.DateTime = m_Obj_CCDC_CT.NgayKtpb
        txtSoCt.Text = m_Obj_CCDC_CT.SoCt
        txtGhiChu.Text = m_Obj_CCDC_CT.GhiChu
    End Sub

    Private Function Check_input() As Boolean
        If grlMaCCDC.EditValue Is Nothing Then
            Message_Warning("Bạn chưa chọn CCDC cần khai báo giảm")
            grlMaCCDC.Focus()
            Return False
        End If

        If grlMaGiam.EditValue Is Nothing Then
            Message_Warning("Bạn chưa chọn mã giảm")
            grlMaGiam.Focus()
            Return False
        End If

        If dteNgayGiam.Text = "" Then
            Message_Warning("Bạn chưa chọn ngày giảm")
            dteNgayGiam.Focus()
            Return False
        End If

        If dteNgayHetPb.Text = "" Then
            Message_Warning("Bạn chưa chọn kết thúc phân bổ")
            dteNgayHetPb.Focus()
            Return False
        End If

        If txtSoCt.Text.Trim = "" Then
            Message_Warning("Bạn chưa nhập ngày ct")
            txtSoCt.Focus()
            Return False
        End If

        Return True
    End Function

    Private Function GetCTId(ByVal p_CcdcId As Guid)
        Dim ccCtId As Guid = New Guid()
        Dim lst As List(Of CcCtCcdc) = CcCtCcdcService.GetByCcDcId_TrangThai(p_CcdcId, 2)
        If lst.Count > 0 Then
            ccCtId = lst(0).Id
        End If
        Return ccCtId
    End Function

#End Region

#Region "Events"

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Try
            If Not Check_input() Then
                Return
            End If

            frmProgress.Instance.Thread = AddressOf GetObject
            frmProgress.Instance.Show_Progress()

            Me.DialogResult = DialogResult.OK
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub grlMaCCDC_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grlMaCCDC.EditValueChanged
        Try
            If m_OnLoadData Then
                Return
            End If
            Dim obj_CCDC As CcDmCcdc = CType(ComboHelper.GetSelectData(grlMaCCDC), CcDmCcdc)
            If obj_CCDC.GiamCcdc = 1 Then
                'm_CT_CCDC_Id = obj_CCDC.Id
                'Ly id ccdc_ct
                m_CT_CCDC_Id = GetCTId(obj_CCDC.Id)
                SetObject()
                IsInsert = False
            Else
                IsInsert = True
            End If
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub btnQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuit.Click
        Me.Close()
    End Sub
#End Region

End Class