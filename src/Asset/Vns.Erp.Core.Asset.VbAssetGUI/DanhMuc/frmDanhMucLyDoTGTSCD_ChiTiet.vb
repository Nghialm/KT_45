Imports Microsoft.VisualBasic
Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.DXErrorProvider

Imports Vns.Erp.Core.Asset.Domain
Imports Vns.Erp.Core.Asset.Service.Interface

Imports Vns.Erp.Core.Admin.Domain
Imports Vns.Erp.Core.Admin.Service.Interface

Partial Public Class frmDanhMucLyDoTGTSCD_ChiTiet
    Inherits FrmBaseDmChiTiet
    Private _HtDanhmucService As IHtDanhmucService

    Public Property HtDanhmucService() As IHtDanhmucService
        Get
            Return _HtDanhmucService
        End Get
        Set(ByVal value As IHtDanhmucService)
            _HtDanhmucService = value
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
#Region "Modify here"
    ''' <summary>
    ''' Kh?i t?o các thu?c tính phù h?p v?i form hi?n t?i
    ''' </summary>
    Public Overrides Sub InitProperty()
        'Size = new Size();
        'Tiêu d? 
        Title = "Danh mục lý do tăng giảm tài sản cố định"

        'Tên b?ng truy v?n trong DB
        TableName = "DM_LYDO_TG_TSCD"

        'Thêm các control b?t bu?c nh?p vào dây
        'Sample: _RequireInput = new Control[] { txtCap,txtKyHieu };
        RequireInputControls = New Control() {txtMA_LYDO_TG_TSCD, txtTEN_LYDO_TG_TSCD, txtKY_HIEU, cboLOAI_LG1}

        '---------------------------------------------------------------------
        ButtonSave = btnSave
        ButtonClear = btnClear
        ButtonCancel = btnCancel
        GroupControlObjectInfo = _GroupControlObjectInfo
    End Sub

    ''' <summary>
    ''' X? lư b?t l?i d? li?u
    ''' </summary>
    ''' <param name="sender"></param>
    ' <param name="e"></param>
    Private MaCu As String
    Public Overrides Sub ValidateData(ByVal sender As Object, ByVal e As CancelEventArgs)
        Try
            If sender Is txtMA_LYDO_TG_TSCD Then
                Dim Ma_LyDoTGTSCD As String = txtMA_LYDO_TG_TSCD.Text
                Select Case Mode
                    Case FormGlobals.DataInputState.AddMode
                        KiemTraMa(Ma_LyDoTGTSCD, e)
                    Case FormGlobals.DataInputState.EditMode

                        If MaCu <> Ma_LyDoTGTSCD Then
                            KiemTraMa(Ma_LyDoTGTSCD, e)
                        End If
                End Select
            End If
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub KiemTraMa(ByVal Ma_LyDoTGTSCD As String, ByVal e As CancelEventArgs)
        'Try
        'Dim kiemtra As Boolean = HeThong_UtilBO.Instance().KiemTraMaDanhMuc("DM_LYDO_TG_TSCD", "MA_LYDO_TG_TSCD", Ma_LyDoTGTSCD, Generals.DON_VI.Id)
        'If (Not kiemtra) Then
        '    ErrorProvider.SetError(txtMA_LYDO_TG_TSCD, "Mã đã tồn tại")
        '    e.Cancel = True

        'End If
        'Catch ex As Exception
        '    Message_Error(ex)
        'End Try
    End Sub

    ''' <summary>
    ''' Luu d? li?u vào DB (thêm m?i ho?c s?a)
    ''' </summary>
    Public Overrides Sub Saving()
        Try
            Dim info As DmLydoTgTscd = ObjectInfo
            Select Case Mode
                Case FormGlobals.DataInputState.AddMode
                    info.Id = Guid.NewGuid()
                    ID = DmLydoTgTscdService.Save(info).Id
                    cboLOAI_LG1.ItemIndex = 0

                Case FormGlobals.DataInputState.EditMode
                    DmLydoTgTscdService.SaveOrUpdate(info)
            End Select
            AfterSaveSuccess()
            Me.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.Close()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    ''' <summary>
    ''' Chuy?n d?i d? li?u qua l?i gi?a d?i tu?ng Info và form
    ''' </summary>
    Public Property ObjectInfo() As DmLydoTgTscd
        'L?y d? li?u t? các tru?ng d? li?u trên form gán cho thu?c tính tuong ?ng c?a d?i tu?ng Info r?i tr? v? d?i tu?ng Info dó
        Get
            Dim info As DmLydoTgTscd = New DmLydoTgTscd()
            If Not ID Is Nothing Then
                info = Me.DmLydoTgTscdService.Get(ID)
            End If
            'FormGlobals.Panel_GetControlValue(Me._GroupControlObjectInfo, info)
            info.KyHieu = Me.txtKY_HIEU.Text
            info.MaLydoTgTscd = Me.txtMA_LYDO_TG_TSCD.Text
            info.TenLydoTgTscd = Me.txtTEN_LYDO_TG_TSCD.Text
            info.LoaiLg = Decimal.Parse(cboLOAI_LG1.EditValue.ToString())
            info.DonviId = Generals.DON_VI.Id
            info.MaDonvi = Generals.DON_VI.MaDonvi
            info.GiaTri = 0
            info.CoSuDung = TNCommon.ParseDecimal(chkCO_SU_DUNG.Checked)

            MyBase.ResultObject = info
            Return info
        End Get

        'L?y d? li?u t? các thu?c tính c?a d?i tu?ng Info gán cho các tru?ng tuong ?ng trên form
        Set(ByVal value As DmLydoTgTscd)
            If Not value Is Nothing Then
                Dim obj As DmLydoTgTscd = TryCast(value, DmLydoTgTscd)
                'FormGlobals.Panel_SetControlValue(_GroupControlObjectInfo, obj)
                Me.txtKY_HIEU.Text = obj.KyHieu
                Me.txtMA_LYDO_TG_TSCD.Text = obj.MaLydoTgTscd
                Me.txtTEN_LYDO_TG_TSCD.Text = obj.TenLydoTgTscd
                cboLOAI_LG1.EditValue = obj.LoaiLg
                chkCO_SU_DUNG.Checked = TNCommon.ParseBool(obj.CoSuDung)
                'cboLOAI_LG1.EditValue = obj.LOAILG
            End If
        End Set
    End Property

    ''' <summary>
    ''' Kh?i t?o d? li?u cho các GridLookupEdit
    ''' </summary>
    Public Overrides Sub BindLookUpEdit()
        Try
            'Bind lo?i tang gi?m
            Dim dtLoaiTG As List(Of HtDanhmuc) = New List(Of HtDanhmuc)
            dtLoaiTG.AddRange(HtDanhmucService.GetByDoiTuong("KIEU_THAYDOI_TSCD"))

            Dim LoaiTGComlumnDefine As ArrayList = New ArrayList()
            LoaiTGComlumnDefine.Add(New ColumnInfo("TenDanhmuc", "Tên", 0, True, ""))
            TNCommon.BindData_LookupEdit(cboLOAI_LG1, dtLoaiTG, "TenDanhmuc", "GiaTri", LoaiTGComlumnDefine, False)
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    Public Overrides Sub BindData()
        Try
            ObjectInfo = DmLydoTgTscdService.GetById(ID)
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
    Private Sub frmDanhMucLyDoTGTSCD_ChiTiet_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        InitProperty()
        CommonInit()
        TNCommon.setIconControl(Me)
        Try
            MaCu = txtMA_LYDO_TG_TSCD.Text
            Select Case Mode
                Case FormGlobals.DataInputState.AddMode
                    cboLOAI_LG1.ItemIndex = 0

                Case FormGlobals.DataInputState.EditMode
            End Select
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub
End Class
