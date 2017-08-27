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


Partial Public Class frmDanhMucDonVi_ChiTiet
    Inherits FrmBaseDmChiTiet

#Region "Variables and Messages"
    Private _DmDonviService As IDmDonviService
    Public Property DmDonviService() As IDmDonviService
        Get
            Return _DmDonviService
        End Get
        Set(ByVal value As IDmDonviService)
            _DmDonviService = value
        End Set
    End Property

    Private _temp As DmDonvi = New DmDonvi()
    Public Property ObjectInfo() As DmDonvi
        Get
            Dim info As DmDonvi = New DmDonvi()
            If Not ID Is Nothing Then
                info = DmDonviService.GetById(New Guid(ID.ToString()))
            End If
            info.TenDonvi = Me.txtTEN_DONVI.Text
            info.KyHieu = Me.txtKY_HIEU.Text
            info.DonviIdCha = New Guid(cboDONVI_ID_CHA1.EditValue.ToString())
            info.NguoiTao = Generals.USER.Id
            info.NguoiSua = Generals.USER.Id
            info.BoPhanTt = TNCommon.ParseDecimal(chkBO_PHAN_TT.Checked)
            info.QuanHuyen = Me.txtQUAN_HUYEN.Text
            info.NguoiLapBieu = Me.txtNGUOI_LAP_BIEU.Text
            info.GiamDoc = Me.txtGIAM_DOC.Text
            info.ThuQuy = Me.txtTHU_QUY.Text
            info.KtTruong = Me.txtKT_TRUONG.Text
            info.TinhTp = Me.txtTINH_TP.Text
            info.DienThoai = Me.txtDIEN_THOAI.Text
            info.MaSoThue = Me.txtMA_SO_THUE.Text
            info.FAX = Me.txtFAX.Text
            info.EMAIL = Me.txtEMAIL.Text
            info.DiaChi = Me.txtDIA_CHI.Text
            info.SoTaikhoanNh = Me.txtSO_TAIKHOAN_NH.Text
            info.TenNganhang = Me.txtTEN_NGANHANG.Text
            info.DiaChiNh = Me.txtDIA_CHI_NH.Text

            If String.IsNullOrEmpty(_temp.MaDonvi) Then
                info.MaDonvi = " "
            Else
                info.MaDonvi = _temp.MaDonvi
            End If
            Select Case Mode
                Case FormGlobals.DataInputState.AddMode
                    info.ChiTiet = 1
                Case FormGlobals.DataInputState.EditMode
                    info.ChiTiet = _temp.ChiTiet
            End Select

            info.SynDate = Null.MIN_DATE
            MyBase.ResultObject = info
            Return info
        End Get

        'L?y d? li?u t? các thu?c tính c?a d?i tu?ng Info gán cho các tru?ng tuong ?ng trên form
        Set(ByVal value As DmDonvi)
            If Not value Is Nothing Then
                Dim obj As DmDonvi = TryCast(value, DmDonvi)
                'FormGlobals.Panel_SetControlValue(_GroupControlObjectInfo, obj)
                Me.txtDIA_CHI.Text = obj.DiaChi
                Me.txtDIA_CHI_NH.Text = obj.DiaChiNh
                Me.txtDIEN_THOAI.Text = obj.DienThoai
                Me.txtEMAIL.Text = obj.EMAIL
                Me.txtFAX.Text = obj.FAX
                Me.txtKY_HIEU.Text = obj.KyHieu
                Me.txtKT_TRUONG.Text = obj.KtTruong
                Me.txtMA_SO_THUE.Text = obj.MaSoThue
                Me.txtGIAM_DOC.Text = obj.GiamDoc
                Me.txtNGUOI_LAP_BIEU.Text = obj.NguoiLapBieu
                Me.txtTEN_DONVI.Text = obj.TenDonvi
                Me.txtQUAN_HUYEN.Text = obj.QuanHuyen
                Me.txtTINH_TP.Text = obj.TinhTp
                Me.txtTHU_QUY.Text = obj.ThuQuy
                Me.txtKT_TRUONG.Text = obj.KtTruong
                Me.txtGIAM_DOC.Text = obj.GiamDoc
                Me.txtTEN_NGANHANG.Text = obj.TenNganhang
                Me.txtSO_TAIKHOAN_NH.Text = obj.SoTaikhoanNh
                cboDONVI_ID_CHA1.EditValue = obj.DonviIdCha.ToString

            End If
        End Set
    End Property
#End Region

#Region "Construction"
    Public Sub New()
        InitializeComponent()
        TNCommon.setIconControl(Me)
    End Sub
#End Region

#Region "Load Form"
    Public Overrides Sub InitProperty()
        'Size = new Size();
        'Tiêu d? 
        Title = "Danh mục đơn vị"

        'Tên b?ng truy v?n trong DB
        TableName = "DmDonvi"

        'Thêm các control b?t bu?c nh?p vào dây
        'Sample: _RequireInput = new Control[] { txtCap,txtKyHieu };
        RequireInputControls = New Control() {txtTEN_DONVI, txtKY_HIEU, cboDONVI_ID_CHA1}

        '---------------------------------------------------------------------
        ButtonSave = btnSave
        ButtonClear = btnClear
        ButtonCancel = btnCancel
        GroupControlObjectInfo = _GroupControlObjectInfo
    End Sub

    Public Overrides Sub BindLookUpEdit()
        Try
            'Bind danh m?c cha
            Dim dtDMCHA As List(Of DmDonvi) = New List(Of DmDonvi)
            dtDMCHA.AddRange(DmDonviService.GetAll())
            Dim _DMCHAColumnDefine As ArrayList = New ArrayList()
            _DMCHAColumnDefine.Add(New ColumnInfo("TenDonvi", "Tên nhóm đơn vị", 0, True, ""))
            Dim root As DmDonvi = New DmDonvi()
            root.TenDonvi = "Danh mục gốc"
            root.Id = Guid.Empty
            root.MaDonvi = ""
            'dr = dtDMCHA.NewRow()
            'dr("TEN_DONVI") = "Danh mục gốc"
            'dr("DONVI_ID") = Guid.Empty.ToString().Replace("-", "")
            'dr("MA_DONVI") = ""
            'dtDMCHA.Rows.InsertAt(dr, 0)
            dtDMCHA.Insert(0, root)
            TNCommon.BindData_LookupEdit(cboDONVI_ID_CHA1, dtDMCHA, "TenDonvi", "Id", _DMCHAColumnDefine, True, True)
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Public Overrides Sub BindData()
        Try
            Select Case Mode
                Case FormGlobals.DataInputState.AddMode
                    cboDONVI_ID_CHA1.ItemIndex = 0
                Case FormGlobals.DataInputState.EditMode
                    _temp = DmDonviService.GetById(ID)
                    ObjectInfo = _temp
            End Select
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Public Overrides Sub Saving()
        Try
            Dim info As DmDonvi = ObjectInfo
            Select Case Mode
                Case FormGlobals.DataInputState.AddMode
                    ID = DmDonviService.SaveOrUpdate(info).Id

                Case FormGlobals.DataInputState.EditMode
                    ID = DmDonviService.SaveOrUpdate(info).Id
            End Select
            AfterSaveSuccess()
            Me.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.Close()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub
#End Region

#Region "Private Function and Procedures"

#End Region

#Region "Events"
    Public Overrides Sub ValidateData(ByVal sender As Object, ByVal e As CancelEventArgs)

    End Sub
#End Region
End Class
