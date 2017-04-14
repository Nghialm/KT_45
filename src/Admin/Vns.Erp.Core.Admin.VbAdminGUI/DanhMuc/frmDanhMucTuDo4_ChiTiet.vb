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

Partial Public Class frmDanhMucTuDo4_ChiTiet
    Inherits FrmBaseDmChiTiet

#Region "Variables and Messages"
    Dim _DmTudo4Service As IDmTudo4Service
    Public Property DmTudo4Service() As IDmTudo4Service
        Get
            Return _DmTudo4Service
        End Get
        Set(ByVal value As IDmTudo4Service)
            _DmTudo4Service = value
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

    Private _temp As DmTudo4 = New DmTudo4()
    ''' <summary>
    ''' Chuyển dổi dữ liệu qua lại giữa dối tượng Info và form
    ''' </summary>
    Public Property ObjectInfo() As DmTudo4
        'Lấyy dữ liệu từ các truờng dữ liệu trên form gán cho thuộc tính tuong ứng của dối tuợng Info rồi trả về dối tuợng Info dó
        Get
            Dim objInfo As DmTudo4 = New DmTudo4()
            If Not ID Is Nothing Then
                objInfo = DmTudo4Service.GetById(ID)
            End If
            'FormGlobals.Panel_GetControlValue(Me._GroupControlObjectInfo, info)
            objInfo.KyHieu = txtKy_Hieu.Text
            objInfo.TenDmTudo4 = txtTen_Dm_Tudo_4.Text
            objInfo.MoTa = txtMO_TA.Text
            objInfo.DmTudo4IdCha = CType(cboDm_Tudo_2_Id_Cha1.EditValue, Guid)
            objInfo.CoSuDung = TNCommon.ParseDecimal(chkCO_SU_DUNG.Checked)
            objInfo.MaTk = txtMA_TK.Text

            objInfo.DmTudo4IdCha = CType(cboDm_Tudo_2_Id_Cha1.EditValue, Guid)
            If String.IsNullOrEmpty(_temp.MaDmTudo4) Then
                objInfo.MaDmTudo4 = " "
            Else
                objInfo.MaDmTudo4 = _temp.MaDmTudo4
            End If

            Select Case Mode
                Case DataInputState.AddMode
                    objInfo.ChiTiet = 1
                    objInfo.DonviId = Generals.DON_VI.Id
                    objInfo.MaDonvi = Generals.DON_VI.MaDonvi
                    objInfo.NguoiTao = Generals.USER.Id
                    objInfo.NguoiSua = Generals.USER.Id
                    objInfo.NgayTao = DateTime.Now
                    objInfo.NgaySua = DateTime.Now
                    objInfo.MaDmTudo4 = " "
                Case DataInputState.EditMode
                    objInfo.NguoiSua = Generals.USER.Id
                    objInfo.NgaySua = DateTime.Now
            End Select

            MyBase.ResultObject = objInfo
            Return objInfo
        End Get

        'Lấy dữ liệu từ các thuộc tính của dối tuợng Info gán cho các truờng tuong ứng trên form
        Set(ByVal value As DmTudo4)
            If Not value Is Nothing Then
                'Dim obj As DM_Tudo2Info = TryCast(value, DM_Tudo2Info)
                'FormGlobals.Panel_SetControlValue(_GroupControlObjectInfo, obj)
                If (value Is Nothing) Then
                    Return
                End If
                txtKy_Hieu.Text = _temp.KyHieu
                txtTen_Dm_Tudo_4.Text = _temp.TenDmTudo4
                txtMO_TA.Text = _temp.MoTa
                txtMA_TK.Text = _temp.MaTk
                chkCO_SU_DUNG.Checked = TNCommon.ParseBool(value.CoSuDung)

                cboDm_Tudo_2_Id_Cha1.EditValue = value.DmTudo4IdCha
                KH_Old = value.KyHieu
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
        Title = "Danh mục tự do 4"

        'Tên b?ng truy v?n trong DB
        TableName = "DM_TUDO4"

        'Thêm các control b?t bu?c nh?p vào dây
        'Sample: _RequireInput = new Control[] { txtCap,txtKyHieu };
        RequireInputControls = New Control() {txtKy_Hieu, txtTen_Dm_Tudo_4}



        '---------------------------------------------------------------------
        ButtonSave = btnSave
        ButtonClear = btnClear
        ButtonCancel = btnCancel
        GroupControlObjectInfo = _GroupControlObjectInfo
    End Sub

    ''' <summary>
    ''' Khởi tạo dữ liệu cho các GridLookupEdit
    ''' </summary>
    Public Overrides Sub BindLookUpEdit()
        Try
            'Bind danh mục cha
            Dim dr As DmTudo4 = New DmTudo4()
            Dim dt As List(Of DmTudo4) = New List(Of DmTudo4)
            dt.AddRange(_DmTudo4Service.GetAllByDonviID(Generals.DON_VI.Id))
            dr.TenDmTudo4 = "Danh mục gốc"
            dr.Id = Guid.Empty
            dr.MaDmTudo4 = ""
            dr.Cap = 1
            dt.Insert(0, dr)

            Dim DanhMucChaColumnDefine As ArrayList = New ArrayList()
            DanhMucChaColumnDefine.Add(New ColumnInfo("TenDmTudo4", "Tên", 0, True, ""))
            TNCommon.BindData_LookupEdit(cboDm_Tudo_2_Id_Cha1, dt, "TenDmTudo4", "Id", DanhMucChaColumnDefine, True, True)

            Dim dt_tk As IList(Of DmTaikhoan)
            dt_tk = _DmTaikhoanService.GetAllByDonviID(Generals.DON_VI.Id)

            Dim dtTK_Kho As DataTable = New DataTable()
            dtTK_Kho = Vns.Erp.Core.Dao.Util.DBUtil.ToDataTable(dt_tk)

            Dim columnDefine As ArrayList = New ArrayList()
            columnDefine.Add(New ColumnInfo("MaTaikhoan", "Mă tài khoản", 0, True, ""))
            columnDefine.Add(New ColumnInfo("TenTaikhoan", "Tên tài khoản", 0, True, ""))
            Dim be As BaseGridPopupForm = New BaseGridPopupForm(txtMA_TK, "MaTaikhoan", dtTK_Kho, columnDefine)
            be.Text = "Chọn tài khoản"
            be.Size = New Size(500, 300)
            AddHandler txtMA_TK.Validating, AddressOf ValidateData
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    ''' <summary>
    ''' Bind data
    ''' </summary>
    Public Overrides Sub BindData()
        Try
            _temp = _DmTudo4Service.GetById(ID)
            ObjectInfo = _temp
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub
#End Region

#Region "Modify here"
    Dim KH_Old As String = ""
    Public Overrides Sub ValidateData(ByVal sender As Object, ByVal e As CancelEventArgs)
        If sender Is txtKy_Hieu Then
            If txtKy_Hieu.Text.Trim = "" Then
                ErrorProvider.SetError(txtKy_Hieu, "Bạn chưa nhập ký hiệu!")
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
                'Dim dt As DataTable = DM_Tudo3BO.Instance.GetByKy_Hieu(KH_New, Generals.DON_VI.DONVI_ID).Tables(0)
                'If dt.Rows.Count <> 0 Then
                '    ErrorProvider.SetError(txtKy_Hieu, "Ký hiệu này đã tồn tại!")
                '    e.Cancel = True
                'Else
                '    ErrorProvider.SetError(txtKy_Hieu, "")
                '    e.Cancel = False
                'End If
            End If
        End If
    End Sub

    ''' <summary>
    ''' Luu d? li?u vào DB (thêm m?i ho?c s?a)
    ''' </summary>
    Public Overrides Sub Saving()
        Try
            Dim info As DmTudo4 = CType(ObjectInfo, DmTudo4)
            Select Case Mode
                Case FormGlobals.DataInputState.AddMode
                    info.ChiTiet = 1
                    ID = _DmTudo4Service.Save(info).Id
                Case FormGlobals.DataInputState.EditMode
                    _DmTudo4Service.SaveOrUpdate(info)
            End Select
            AfterSaveSuccess()
            Me.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.Close()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub
#End Region

#Region "Events"
    Private Sub frmDanhMucTuDo4_ChiTiet_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Try
            Select Case Mode
                Case FormGlobals.DataInputState.AddMode
                    cboDm_Tudo_2_Id_Cha1.ItemIndex = 0
            End Select
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub
#End Region

End Class
