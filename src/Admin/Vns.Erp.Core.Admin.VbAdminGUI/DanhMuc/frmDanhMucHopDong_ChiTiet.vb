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
Imports Vns.Erp.Core.Admin.Domain
Imports Vns.Erp.Core.Admin.Service.Interface


Partial Public Class frmDanhMucHopDong_ChiTiet
    Inherits FrmBaseDmChiTiet
    Dim _DmHopdongService As IDmHopdongService
    Public Property DmHopdongService() As IDmHopdongService
        Get
            Return _DmHopdongService
        End Get
        Set(ByVal value As IDmHopdongService)
            _DmHopdongService = value
        End Set
    End Property
    Private _HtDanhmucService As IHtDanhmucService
    Public Property HtDanhmucService() As IHtDanhmucService
        Get
            Return _HtDanhmucService
        End Get
        Set(ByVal value As IHtDanhmucService)
            _HtDanhmucService = value
        End Set
    End Property
#Region "Modify here"
    ''' <summary>
    ''' Kh?i t?o các thu?c tính phù h?p v?i form hi?n t?i
    ''' </summary>
    Public Overrides Sub InitProperty()
        'Size = new Size();
        'Tiêu d? 
        Title = "Danh mục hợp đồng"

        'Tên b?ng truy v?n trong DB
        TableName = "DmHopdong"

        'Thêm các control b?t bu?c nh?p vào dây
        'Sample: _RequireInput = new Control[] { txtCap,txtKyHieu };
        RequireInputControls = New Control() {txtTEN_HOPDONG, txtKy_Hieu, cboHOPDONG_ID_CHA}

        '---------------------------------------------------------------------
        ButtonSave = btnSave
        ButtonClear = btnClear
        ButtonCancel = btnCancel
        GroupControlObjectInfo = _GroupControlObjectInfo
    End Sub

    ''' <summary>
    ''' X? lý b?t l?i d? li?u
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private KH_Old As String = ""
    Public Overrides Sub ValidateData(ByVal sender As Object, ByVal e As CancelEventArgs)
        If sender Is txtKy_Hieu Then
            If txtKy_Hieu.Text.Trim = "" Then
                ErrorProvider.SetError(txtKy_Hieu, "Bạn chưa nhập ký hiệu hợp đồng!")
                e.Cancel = True
            Else
                Dim KH_New As String = ""
                Select Case Mode
                    Case DataInputState.AddMode
                        KH_New = txtKy_Hieu.Text.Trim
                    Case DataInputState.EditMode
                        If KH_Old <> txtKy_Hieu.Text.Trim Then
                            KH_New = txtKy_Hieu.Text.Trim
                        End If
                End Select

                Dim dt As IList(Of DmHopdong) = DmHopdongService.GetAllByKy_Hieu(KH_New, Generals.DON_VI.Id)
                If dt.Count <> 0 Then
                    ErrorProvider.SetError(txtKy_Hieu, "Ký hiệu này đã tồn tại!")
                    e.Cancel = True
                Else
                    ErrorProvider.SetError(txtKy_Hieu, "")
                    e.Cancel = False
                End If

            End If
        End If
    End Sub

    ''' <summary>
    ''' Luu d? li?u vào DB (thêm m?i ho?c s?a)
    ''' </summary>
    Public Overrides Sub Saving()
        Try
            Dim info As DmHopdong = CType(ObjectInfo, DmHopdong)
            Select Case Mode
                Case FormGlobals.DataInputState.AddMode
                    info.Id = Nothing
                    ID = DmHopdongService.Save(info).Id

                Case FormGlobals.DataInputState.EditMode
                    DmHopdongService.SaveOrUpdate(info)
            End Select
            AfterSaveSuccess()
            Me.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.Close()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    'Luu gia tri cu cua DM khi sua. Them moi
    Private _temp As DmHopdong = New DmHopdong()

    ''' <summary>
    ''' Chuy?n d?i d? li?u qua l?i gi?a d?i tu?ng Info và form
    ''' </summary>
    Public Property ObjectInfo() As DmHopdong
        'L?y d? li?u t? các tru?ng d? li?u trên form gán cho thu?c tính tuong ?ng c?a d?i tu?ng Info r?i tr? v? d?i tu?ng Info dó
        Get
            Dim info As DmHopdong = New DmHopdong()
            If Not ID Is Nothing Then
                info = DmHopdongService.Get(ID)
            End If
            'FormGlobals.Panel_GetControlValue(Me._GroupControlObjectInfo, info)
            info.KyHieu = Me.txtKy_Hieu.Text
            info.MaDonvi = Generals.DON_VI.MaDonvi
            info.TenHopdong = Me.txtTEN_HOPDONG.Text
            info.MoTa = Me.txtMO_TA.Text

            info.HopdongIdCha = New Guid(cboHOPDONG_ID_CHA.EditValue.ToString())
            info.LoaiHopdong = Decimal.Parse(cboTEN_LOAI_HOPDONG1.EditValue.ToString())
            info.TenLoaiHopdong = cboTEN_LOAI_HOPDONG1.Text
            'Them moi
            If String.IsNullOrEmpty(_temp.MaHopdong) Then
                info.MaHopdong = " "
            Else
                info.MaHopdong = _temp.MaHopdong
            End If
            Select Case Mode
                Case FormGlobals.DataInputState.AddMode
                    info.ChiTiet = 1

                Case FormGlobals.DataInputState.EditMode
                    info.ChiTiet = _temp.ChiTiet
            End Select
            info.DonviId = Generals.DON_VI.Id
            info.MaDonvi = Generals.DON_VI.MaDonvi
            info.NguoiTao = Generals.USER.Id
            info.NguoiSua = Generals.USER.Id
            info.CoSuDung = TNCommon.ParseDecimal(chkCO_SU_DUNG.Checked)
            info.SynDate = Null.MIN_DATE
            MyBase.ResultObject = info
            Return info
        End Get

        'L?y d? li?u t? các thu?c tính c?a d?i tu?ng Info gán cho các tru?ng tuong ?ng trên form
        Set(ByVal value As DmHopdong)
            If Not value Is Nothing Then
                Dim obj As DmHopdong = TryCast(value, DmHopdong)
                'FormGlobals.Panel_SetControlValue(_GroupControlObjectInfo, obj)
                txtKy_Hieu.Text = obj.KyHieu
                chkCO_SU_DUNG.Checked = TNCommon.ParseBool(obj.CoSuDung)
                cboHOPDONG_ID_CHA.EditValue = obj.HopdongIdCha
                cboTEN_LOAI_HOPDONG1.EditValue = obj.LoaiHopdong
                KH_Old = obj.KyHieu
                txtTEN_HOPDONG.Text = obj.TenHopdong
                txtMO_TA.Text = obj.MoTa
            End If
        End Set
    End Property

    ''' <summary>
    ''' Kh?i t?o d? li?u cho các GridLookupEdit
    ''' </summary>
    Public Overrides Sub BindLookUpEdit()
        Try
            'Bind danh m?c cha
            Dim dr As DmHopdong
            Dim dt As List(Of DmHopdong) = New List(Of DmHopdong)
            dt.AddRange(DmHopdongService.GetAllByDonviID(Generals.DON_VI.Id))
            dr = New DmHopdong()
            dr.TenHopdong = "Danh mục gốc"
            dr.Id = Guid.Empty
            dr.MaHopdong = ""
            dr.Cap = 1
            dt.Insert(0, dr)
            Dim nhomdm As ArrayList = New ArrayList()
            nhomdm.Add(New ColumnInfo("TenHopdong", "Tên", 0, True, ""))
            TNCommon.BindData_LookupEdit(cboHOPDONG_ID_CHA, dt, "TenHopdong", "Id", nhomdm, True, True)

            ' Bind loai hop d?ng
            Dim dtHopDong As IList(Of HtDanhmuc) = HtDanhmucService.GetByDoiTuong("LOAI_HOP_DONG")
            Dim _HopDongColumnDefine As ArrayList = New ArrayList()
            _HopDongColumnDefine.Add(New ColumnInfo("TenDanhmuc", "Loại hợp đồng", 0, True, ""))
            TNCommon.BindData_LookupEdit(cboTEN_LOAI_HOPDONG1, dtHopDong, "TenDanhmuc", "GiaTri", _HopDongColumnDefine, True)
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    Public Overrides Sub BindData()
        'Them moi
        Try
            _temp = DmHopdongService.GetById(ID)
            ObjectInfo = _temp
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

#End Region

    'Public Overrides Sub InitComponet()
    '    InitializeComponent()
    'End Sub
    Public Sub New()
        InitializeComponent()
    End Sub


    Private Sub frmDanhMucHopDong_ChiTiet_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        InitProperty()
        BindLookUpEdit()
        'CommonInit()
        TNCommon.setIconControl(Me)
        Try
            If Mode = FormGlobals.DataInputState.AddMode Then
                TNCommon.SelectFirst(cboHOPDONG_ID_CHA)
                TNCommon.SelectFirst(cboTEN_LOAI_HOPDONG1)
            End If
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

End Class
