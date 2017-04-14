Imports System
Imports System.Data
Imports System.IO
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports System.ComponentModel

Imports Vns.Erp.Core.Asset.Domain
Imports Vns.Erp.Core.Asset.Service.Interface

Public Class frmDanhMucNguonVon_tscd_ChiTiet
    Inherits FrmBaseDmChiTiet

#Region "Variables"
    Private objNguonVon As DmNguonTscd = New DmNguonTscd()
    'Private objNguonVonBO As IDmBtKetchuyenService
    'Public Property DmBtKetchuyenService() As IDmBtKetchuyenService
    '    Get
    '        Return objNguonVonBO
    '    End Get
    '    Set(ByVal value As IDmBtKetchuyenService)
    '        objNguonVonBO = value
    '    End Set
    'End Property

    Dim _DmNguonTscdService As IDmNguonTscdService

    Public Property DmNguonTscdService() As IDmNguonTscdService
        Get
            Return _DmNguonTscdService
        End Get
        Set(ByVal value As IDmNguonTscdService)
            _DmNguonTscdService = value
        End Set
    End Property

    Private m_InputState As FormGlobals.DataInputState
    Private m_NV_tscd As String
    Private p_Ma_Nguon_TSCD As String
#End Region

#Region "Funtions"

#Region "Overrides Function and Property"

    Public Property ObjectInfo() As DmNguonTscd
        Get
            If Not ID Is Nothing Then
                objNguonVon = DmNguonTscdService.Get(ID)
            Else
                objNguonVon = New DmNguonTscd()
            End If
            objNguonVon.MaDmNguonTscd = txtMaTSCD.Text
            objNguonVon.TenDmNguonTscd = txtTenTSCD.Text
            objNguonVon.KyHieu = txtKYHIEU.Text
            objNguonVon.MoTa = txtMOTA.Text
            objNguonVon.DonviId = Generals.DON_VI.Id
            objNguonVon.MaDonvi = Generals.DON_VI.MaDonvi
            objNguonVon.CoSuDung = TNCommon.ParseDecimal(chkCO_SU_DUNG.Checked)
            objNguonVon.ChoPhepSua = TNCommon.ParseDecimal(chkCHO_PHEP_SUA.Checked)
            MyBase.ResultObject = objNguonVon
            Return objNguonVon
        End Get
        Set(ByVal value As DmNguonTscd)
            If Not value Is Nothing Then
                objNguonVon = value
                p_Ma_Nguon_TSCD = objNguonVon.MaDmNguonTscd
                txtMaTSCD.Text = objNguonVon.MaDmNguonTscd
                txtTenTSCD.Text = objNguonVon.TenDmNguonTscd
                txtKYHIEU.Text = objNguonVon.KyHieu
                txtMOTA.Text = objNguonVon.MoTa
                chkCO_SU_DUNG.Checked = TNCommon.ParseBool(objNguonVon.CoSuDung)
                chkCHO_PHEP_SUA.Checked = TNCommon.ParseBool(objNguonVon.ChoPhepSua)
            End If
        End Set
    End Property

    Public Overrides Sub InitProperty()
        Title = "Danh mục nguồn tài sản cố định"
        TableName = "DmNguonTscd"
        'RequireInputControls = New Control() {txtMaTSCD, txtKYHIEU, txtTenTSCD}
        ButtonSave = btnSave
        ButtonClear = btnClear
        ButtonCancel = btnCancel
        'GroupControlObjectInfo = _GroupControlObjectInfo
        TNCommon.setIconControl(Me)
    End Sub

    Public Overrides Sub InitComponet()
        'InitializeComponent() ' Not Use because of using in the design view
    End Sub

    Public Overrides Sub BindLookUpEdit()
        Select Case Mode
            Case FormGlobals.DataInputState.AddMode
                ClearObjectToControl()
        End Select

    End Sub

    Public Overrides Sub ValidateData(ByVal sender As Object, ByVal e As CancelEventArgs)
        'If txtMaTSCD.Text.Trim = "" Then
        '    Message_Warning("Bạn chưa nhập mã nguồn TSCD")
        '    txtMaTSCD.Focus()
        '    Exit Sub
        'End If

        'If txtKYHIEU.Text.Trim = "" Then
        '    Message_Information("Bạn chưa nhập ký hiệu nguồn TSCD ")
        '    txtKYHIEU.Focus()
        '    Exit Sub
        'End If

        'If txtTenTSCD.Text.Trim = "" Then
        '    Message_Information("Bạn chưa nhập tên nguồn TSCD ")
        '    txtTenTSCD.Focus()
        '    Exit Sub
        'End If
    End Sub

    Public Sub Save()
        Try
            Dim info As DmNguonTscd = ObjectInfo
            Select Case Mode
                Case FormGlobals.DataInputState.AddMode
                    ID = DmNguonTscdService.Save(info).Id
                Case FormGlobals.DataInputState.EditMode
                    DmNguonTscdService.SaveOrUpdate(info)
            End Select
            AfterSaveSuccess()
            Me.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.Close()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Public Overrides Sub BindData()
        Try
            ObjectInfo = DmNguonTscdService.GetById(ID)
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

#End Region

    Private Sub frmDanhMucNguonVon_tscd_ChiTiet_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        InitProperty()
        CommonInit()
    End Sub

    Private Sub ClearObjectToControl()
        objNguonVon = New DmNguonTscd()
        m_NV_tscd = Guid.NewGuid().ToString
        p_Ma_Nguon_TSCD = objNguonVon.MaDmNguonTscd
        txtMaTSCD.Text = objNguonVon.MaDmNguonTscd
        txtTenTSCD.Text = objNguonVon.TenDmNguonTscd
        txtKYHIEU.Text = objNguonVon.KyHieu
        txtMOTA.Text = objNguonVon.MoTa
        chkCO_SU_DUNG.Checked = False
        chkCHO_PHEP_SUA.Checked = False
    End Sub

    Private Sub SetObjectToControl()
        objNguonVon = DmNguonTscdService.GetById(New Guid(m_NV_tscd))
        p_Ma_Nguon_TSCD = objNguonVon.MaDmNguonTscd
        txtMaTSCD.Text = objNguonVon.MaDmNguonTscd
        txtTenTSCD.Text = objNguonVon.TenDmNguonTscd
        txtKYHIEU.Text = objNguonVon.KyHieu
        txtMOTA.Text = objNguonVon.MoTa
        chkCO_SU_DUNG.Checked = TNCommon.ParseBool(objNguonVon.CoSuDung)
        chkCHO_PHEP_SUA.Checked = TNCommon.ParseBool(objNguonVon.ChoPhepSua)
    End Sub

    Private Function Check_ma(ByVal Ma_Nguon As String) As Boolean
        Dim dt As IList(Of DmNguonTscd) = DmNguonTscdService.GetByMaNguon(Ma_Nguon, Generals.DON_VI.Id)
        If dt.Count <> 0 Then
            Message_Warning("Mã nguồn TSCD đã tồn tại")
            txtMaTSCD.Focus()
            Return False
        End If
        Return True
    End Function

#End Region

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Try
            If txtMaTSCD.Text.Trim = "" Then
                Message_Warning("Bạn chưa nhập mã nguồn TSCD")
                txtMaTSCD.Focus()
                Exit Sub
            End If

            If txtKYHIEU.Text.Trim = "" Then
                Message_Information("Bạn chưa nhập ký hiệu nguồn TSCD ")
                txtKYHIEU.Focus()
                Exit Sub
            End If

            If txtTenTSCD.Text.Trim = "" Then
                Message_Information("Bạn chưa nhập tên nguồn TSCD ")
                txtTenTSCD.Focus()
                Exit Sub
            End If
            Save()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub
End Class
