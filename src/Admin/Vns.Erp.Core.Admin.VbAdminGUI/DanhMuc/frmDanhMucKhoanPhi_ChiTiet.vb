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


Partial Public Class frmDanhMucKhoanPhi_ChiTiet
    Inherits FrmBaseDmChiTiet

#Region "Modify here"
    ''' <summary>
    ''' Khởi tạo các thuộc tính phù hợp với form hiển thị
    ''' </summary>
    Private KH_CU As String = ""
    Private ID_CHA As Guid
    Private _BO As IDmKhoanphiService

    Public Property DmKhoanphiService() As IDmKhoanphiService
        Get
            Return _BO
        End Get
        Set(ByVal value As IDmKhoanphiService)
            _BO = value
        End Set
    End Property

    Dim _DmTaikhoanService As IDmTaikhoanService

    Public Property DmTaikhoanService() As IDmTaikhoanService
        Get
            Return _DmTaikhoanService
        End Get
        Set(ByVal value As IDmTaikhoanService)
            _DmTaikhoanService = value
        End Set
    End Property

    Public Overrides Sub InitProperty()
        Dim columnDefine As ArrayList = New ArrayList()
        columnDefine.Add(New ColumnInfo("MaTaikhoan", "Mã tài khoản", 0, True, ""))
        columnDefine.Add(New ColumnInfo("TenTaikhoan", "Tên tài khoản", 0, True, ""))
        Dim list As IList(Of DmTaikhoan) = DmTaikhoanService.GetAllByDonviID(Generals.DON_VI.Id)
        Dim dt As DataTable = Vns.Erp.Core.Dao.Util.DBUtil.ToDataTable(list)
        Dim be As BaseGridPopupForm = New BaseGridPopupForm(txtMATK_LIENQUAN, "MaTaikhoan", dt, columnDefine)
        be.Text = "Chọn tài khoản"
        be.Size = New Size(500, 300)

        TableName = "DmKhoanphi"
        Panel_InitControl(_GroupControlObjectInfo, TableName)
        'Control_SetRequire(txtMA_DM_KHOANPHI, True)
        Control_SetRequire(txtTEN_DM_KHOANPHI, True)
        Control_SetRequire(txtKY_HIEU, True)
        Control_SetRequire(cboDM_KHOANPHI_ID_CHA, True)

        ButtonSave = btnSave
        ButtonCancel = btnCancel
        GroupControlObjectInfo = _GroupControlObjectInfo
        Title = "Danh mục khoản phí"
    End Sub

    Private _ObjectInfo As DmKhoanphi
    Public Property ObjectInfo() As DmKhoanphi
        Get
            If Not ID Is Nothing Then
                _ObjectInfo = DmKhoanphiService.GetById(New Guid(ID.ToString()))
            Else
                _ObjectInfo = New DmKhoanphi()
            End If
            Try
                _ObjectInfo.DmKhoanphiIdCha = New Guid(cboDM_KHOANPHI_ID_CHA.EditValue.ToString())
            Catch
                _ObjectInfo.DmKhoanphiIdCha = New Guid()
            End Try

            _ObjectInfo.CoSuDung = TNCommon.ParseDecimal(chkCO_SU_DUNG.Checked)
            _ObjectInfo.KyHieu = Me.txtKY_HIEU.Text
            _ObjectInfo.MoTa = Me.txtMO_TA.Text
            _ObjectInfo.TenDmKhoanphi = Me.txtTEN_DM_KHOANPHI.Text
            _ObjectInfo.MaDmKhoanphi = Me.txtMA_DM_KHOANPHI.Text
            _ObjectInfo.MatkLienquan = Me.txtMATK_LIENQUAN.Text
            MyBase.ResultObject = _ObjectInfo
            Return _ObjectInfo
        End Get
        Set(ByVal value As DmKhoanphi)
            If value Is Nothing Then
                value = New DmKhoanphi()
            End If
            Me.txtMA_DM_KHOANPHI.Text = value.MaDmKhoanphi
            Me.txtTEN_DM_KHOANPHI.Text = value.TenDmKhoanphi
            Me.txtKY_HIEU.Text = value.KyHieu
            Me.txtMO_TA.Text = value.MoTa
            Me.cboDM_KHOANPHI_ID_CHA.EditValue = value.DmKhoanphiIdCha
            Me.chkCO_SU_DUNG.Checked = value.CoSuDung
            Me.txtMATK_LIENQUAN.Text = value.MatkLienquan
        End Set
    End Property

    Public Sub Save()
        Try
            Dim info As DmKhoanphi = ObjectInfo
            Select Case Mode
                Case FormGlobals.DataInputState.AddMode
                    info.DonviId = Generals.DON_VI.Id
                    info.MaDonvi = Generals.DON_VI.MaDonvi
                    info.NguoiTao = Generals.USER.Id
                    info.NguoiSua = Generals.USER.Id
                    ID = DmKhoanphiService.SaveOrUpdate(info).Id

                Case FormGlobals.DataInputState.EditMode
                    info.DonviId = Generals.DON_VI.Id
                    info.MaDonvi = Generals.DON_VI.MaDonvi
                    info.NguoiSua = Generals.USER.Id
                    ID = DmKhoanphiService.SaveOrUpdate(info).Id
            End Select
            AfterSaveSuccess()
            Me.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.ObjectInfo = info
            Me.Close()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    'Luu gia tri cu cua DM khi sua. Them moi
    Private _temp As DmKhoanphi = New DmKhoanphi()

    Public Overrides Sub BindLookUpEdit()
        'Bind danh mục cha
        'Dim dr As DataRow
        Dim dt As List(Of DmKhoanphi) = New List(Of DmKhoanphi)
        dt.AddRange(DmKhoanphiService.GetAllByDonviID(Generals.DON_VI.Id))
        Dim dr As DmKhoanphi = New DmKhoanphi()
        dr.TenDmKhoanphi = "Danh mục gốc"
        dr.Id = Guid.Empty
        dr.MaDmKhoanphi = ""
        dr.Cap = 1
        dt.Insert(0, dr)

        Dim DanhMucChaColumnDefine As ArrayList = New ArrayList()
        DanhMucChaColumnDefine.Add(New ColumnInfo("TenDmKhoanphi", "Tên", 0, True, ""))
        TNCommon.BindData_LookupEdit(cboDM_KHOANPHI_ID_CHA, dt, "TenDmKhoanphi", "Id", DanhMucChaColumnDefine, True, True)
    End Sub

    Public Overrides Sub DoLoadData()
        BindData()
    End Sub

    Public Overrides Sub BindData()
        Select Case Mode
            Case DataInputState.AddMode
                ID = Nothing
        End Select
        If (Not ID Is Nothing) Then
            ObjectInfo = DmKhoanphiService.GetById(ID)
        Else
            ObjectInfo = New DmKhoanphi()
        End If
        KH_CU = _temp.KyHieu

    End Sub

#End Region

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub frmDanhMucKhoanPhi_ChiTiet_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        InitProperty()
        CommonInit()
        BindLookUpEdit()
        TNCommon.setIconControl(Me)
        Try
            Select Case Mode
                Case FormGlobals.DataInputState.AddMode
                    TNCommon.SelectFirst(cboDM_KHOANPHI_ID_CHA)
                Case FormGlobals.DataInputState.EditMode
                    DoLoadData()
            End Select
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Function check_kh() As Boolean
        Dim kh As String = ""
        Select Case Mode
            Case DataInputState.AddMode
                kh = txtKY_HIEU.Text.Trim
                If DmKhoanphiService.GetNumberDmKhoanphiByKyHieu(Generals.DON_VI.Id, kh) <> 0 Then
                    Message_Warning("Ký hiệu đã tồn tại!")
                    txtKY_HIEU.Focus()
                    Return False
                End If
            Case DataInputState.EditMode
                If txtKY_HIEU.Text.Trim <> KH_CU Then
                    kh = txtKY_HIEU.Text.Trim
                End If
        End Select
        Return True
    End Function

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Try

            If txtKY_HIEU.Text.Trim = "" Then
                Message_Warning("Bạn chưa nhập ký hiệu")
                txtKY_HIEU.Focus()
                Return
            End If

            If txtTEN_DM_KHOANPHI.Text.Trim = "" Then
                Message_Warning("Bạn chưa nhập tên danh mục khoản phí")
                txtTEN_DM_KHOANPHI.Focus()
                Return
            End If

            If String.IsNullOrEmpty(DB_GetString(cboDM_KHOANPHI_ID_CHA.EditValue)) Then
                Message_Warning("Bạn chưa chọn danh mục cha!")
                cboDM_KHOANPHI_ID_CHA.Focus()
                Return
            End If

            If Not check_kh() Then
                Return
            End If

            frmProgress.Instance.Thread = AddressOf Save
            frmProgress.Instance.Show_Progress("Saving data")
            DialogResult = Windows.Forms.DialogResult.OK
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Try
            Me.Close()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub frmDanhMucKhoanPhi_ChiTiet_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Try
            If e.KeyCode = Keys.Escape Then
                Me.Close()
            End If
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub
End Class
