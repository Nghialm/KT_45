Imports System
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Windows.Forms
Imports System.Collections
Imports Vns.Erp.Core.Admin.Domain
Imports Vns.Erp.Core.Admin.Service.Interface

Public Class frmDanhMucTuDo1_ChiTiet
    Inherits FrmBaseDmChiTiet

#Region "Variables and Messages"
    Dim _DmTudo1Service As IDmTudo1Service
    Public Property DmTudo1Service() As IDmTudo1Service
        Get
            Return _DmTudo1Service
        End Get
        Set(ByVal value As IDmTudo1Service)
            _DmTudo1Service = value
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

    Public Property ObjectInfo() As DmTudo1
        'L?y d? li?u t? các tru?ng d? li?u trên form gán cho thu?c tính tuong ?ng c?a d?i tu?ng Info r?i tr? v? d?i tu?ng Info dó
        Get
            Dim objInfo As DmTudo1 = New DmTudo1()
            If Not ID Is Nothing Then
                objInfo = DmTudo1Service.GetById(New Guid(ID.ToString()))
            End If
            'FormGlobals.Panel_GetControlValue(Me._GroupControlObjectInfo, info)
            objInfo.KyHieu = txtKy_Hieu.Text
            objInfo.TenDmTudo1 = txtTen_Dm_Tudo_1.Text
            objInfo.MoTa = txtMO_TA.Text
            objInfo.DmTudo1IdCha = CType(cboDm_Tudo_1_Id_Cha.EditValue, Guid)
            objInfo.CoSuDung = TNCommon.ParseDecimal(chkCO_SU_DUNG.Checked)
            objInfo.MaTk = txtMA_TK.Text

            Select Case Mode
                Case DataInputState.AddMode
                    objInfo.ChiTiet = 1
                    objInfo.DonviId = Generals.DON_VI.Id
                    objInfo.MaDonvi = Generals.DON_VI.MaDonvi
                    objInfo.NguoiTao = Generals.USER.Id
                    objInfo.NguoiSua = Generals.USER.Id
                    objInfo.NgayTao = DateTime.Now
                    objInfo.NgaySua = DateTime.Now
                    objInfo.MaDmTudo1 = " "
                Case DataInputState.EditMode
                    objInfo.NguoiSua = Generals.USER.Id
                    objInfo.NgaySua = DateTime.Now
            End Select

            MyBase.ResultObject = objInfo
            Return objInfo
        End Get

        'L?y d? li?u t? các thu?c tính c?a d?i tu?ng Info gán cho các tru?ng tuong ?ng trên form
        Set(ByVal value As DmTudo1)
            If Not value Is Nothing Then
                txtKy_Hieu.Text = _temp.KyHieu
                txtTen_Dm_Tudo_1.Text = _temp.TenDmTudo1
                txtMO_TA.Text = _temp.MoTa
                txtMA_TK.Text = _temp.MaTk
                chkCO_SU_DUNG.Checked = TNCommon.ParseBool(value.CoSuDung)

                cboDm_Tudo_1_Id_Cha.EditValue = value.DmTudo1IdCha
                KH_Old = value.KyHieu
            End If
        End Set
    End Property
    Private KH_Old As String = ""
#End Region

#Region "Construction"
    Public Sub New()
        InitializeComponent()
    End Sub
#End Region

#Region "Load Form"
    Public Overrides Sub InitProperty()
        'Form_SetText(Me, Generals.TS_TuDo1.GIA_TRI, DataInputState.NoCaption)
        'Form_SetText(Me, "Danh muc tu do 1", DataInputState.NoCaption)
        'Form_InitDialog(Me)
        '
        '
        'Thêm các control b?t bu?c nh?p vào dây
        'Sample: _RequireInput = new Control[] { txtCap,txtKyHieu };
        RequireInputControls = New Control() {txtKy_Hieu}

        Dim dt As IList(Of DmTaikhoan)
        dt = _DmTaikhoanService.GetAllByDonviID(Generals.DON_VI.Id)

        Dim dtTK_Kho As DataTable = New DataTable()
        dtTK_Kho = Vns.Erp.Core.Dao.Util.DBUtil.ToDataTable(dt)

        Dim columnDefine As ArrayList = New ArrayList()
        columnDefine.Add(New ColumnInfo("MaTaikhoan", "Mă tài khoản", 0, True, ""))
        columnDefine.Add(New ColumnInfo("TenTaikhoan", "Tên tài khoản", 0, True, ""))
        Dim be As BaseGridPopupForm = New BaseGridPopupForm(txtMA_TK, "MaTaikhoan", dtTK_Kho, columnDefine)
        be.Text = "Chọn tài khoản"
        be.Size = New Size(500, 300)

        TNCommon.setIconControl(Me)

        '---------------------------------------------------------------------
        ButtonSave = btnSave
        ButtonClear = btnClear
        ButtonCancel = btnCancel
        GroupControlObjectInfo = _GroupControlObjectInfo
    End Sub

    Public Overrides Sub BindLookUpEdit()
        'Bind danh muc cha
        Dim dr As DmTudo1 = New DmTudo1()
        Dim dt As List(Of DmTudo1) = New List(Of DmTudo1)
        dt.AddRange(_DmTudo1Service.GetAllByDonviID(Generals.DonviID))
        dr.TenDmTudo1 = "Danh mục gốc"
        dr.Id = New Guid()
        dr.MaDmTudo1 = ""
        dr.Cap = 1
        dt.Insert(0, dr)

        Dim DanhMucChaColumnDefine As ArrayList = New ArrayList()
        DanhMucChaColumnDefine.Add(New ColumnInfo("TenDmTudo1", "Tên", 0, True, ""))
        TNCommon.BindData_LookupEdit(cboDm_Tudo_1_Id_Cha, dt, "TenDmTudo1", "Id", DanhMucChaColumnDefine, True, True)
    End Sub

    Private _temp As DmTudo1 = New DmTudo1()
    Public Overrides Sub BindData()
        Try
            _temp = DmTudo1Service.GetById(ID)
            ObjectInfo = _temp

        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Public Overrides Sub Saving()
        Try
            If (Not Check_input()) Then Return
            Dim info As DmTudo1 = CType(ObjectInfo, DmTudo1)
            Select Case Mode
                Case FormGlobals.DataInputState.AddMode
                    ID = DmTudo1Service.SaveOrUpdate(info).Id

                Case FormGlobals.DataInputState.EditMode
                    ID = DmTudo1Service.SaveOrUpdate(info).Id
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
    Private Function Check_input() As Boolean

        If txtKy_Hieu.Text.Trim = "" Then
            Message_Warning("Bạn chưa nhập ký hiệu!")
            txtKy_Hieu.Focus()
            Return False
        End If

        If txtTen_Dm_Tudo_1.Text.Trim = "" Then
            Message_Warning("Bạn chưa nhập tên danh mục tự do!")
            txtTen_Dm_Tudo_1.Focus()
            Return False
        End If

        If cboDm_Tudo_1_Id_Cha.Text.Trim = "" Then
            Message_Warning("Bạn chưa nhập danh mục chá!")
            cboDm_Tudo_1_Id_Cha.Focus()
            Return False
        End If

        Dim KH_New As String = ""
        Select Case Mode
            Case DataInputState.AddMode
                KH_New = txtKy_Hieu.Text.Trim
            Case DataInputState.EditMode
                If txtKy_Hieu.Text.Trim <> KH_Old Then
                    KH_New = txtKy_Hieu.Text.Trim
                End If
        End Select

        Return True
    End Function
#End Region
End Class
