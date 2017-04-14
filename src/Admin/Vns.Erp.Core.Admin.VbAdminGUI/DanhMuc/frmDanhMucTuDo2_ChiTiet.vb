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

Partial Public Class frmDanhMucTuDo2_ChiTiet
    Inherits FrmBaseDmChiTiet

#Region "Variables and Messages"
    Dim _DmTudo2Service As IDmTudo2Service
    Public Property DmTudo2Service() As IDmTudo2Service
        Get
            Return _DmTudo2Service
        End Get
        Set(ByVal value As IDmTudo2Service)
            _DmTudo2Service = value
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

    ''' <summary>
    ''' Chuyển dổi dữ liệu qua lại giữa dối tượng Info và form
    ''' </summary>
    Public Property ObjectInfo() As DmTudo2
        'Lấyy dữ liệu từ các truờng dữ liệu trên form gán cho thuộc tính tuong ứng của dối tuợng Info rồi trả về dối tuợng Info dó
        Get
            Dim objInfo As DmTudo2 = New DmTudo2()
            If Not ID Is Nothing Then
                objInfo = DmTudo2Service.GetById(ID)
            End If
            'FormGlobals.Panel_GetControlValue(Me._GroupControlObjectInfo, info)
            objInfo.KyHieu = txtKy_Hieu.Text
            objInfo.TenDmTudo2 = txtTen_Dm_Tudo_2.Text
            objInfo.MoTa = txtMO_TA.Text
            objInfo.DmTudo2IdCha = CType(cboDm_Tudo_2_Id_Cha1.EditValue, Guid)
            objInfo.CoSuDung = TNCommon.ParseDecimal(chkCO_SU_DUNG.Checked)
            objInfo.MaTk = txtMA_TK.Text

            objInfo.DmTudo2IdCha = CType(cboDm_Tudo_2_Id_Cha1.EditValue, Guid)
            If String.IsNullOrEmpty(_temp.MaDmTudo2) Then
                objInfo.MaDmTudo2 = " "
            Else
                objInfo.MaDmTudo2 = _temp.MaDmTudo2
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
                    objInfo.MaDmTudo2 = " "
                Case DataInputState.EditMode
                    objInfo.NguoiSua = Generals.USER.Id
                    objInfo.NgaySua = DateTime.Now
            End Select

            MyBase.ResultObject = objInfo
            Return objInfo
        End Get

        'Lấy dữ liệu từ các thuộc tính của dối tuợng Info gán cho các truờng tuong ứng trên form
        Set(ByVal value As DmTudo2)
            If Not value Is Nothing Then
                'Dim obj As DM_Tudo2Info = TryCast(value, DM_Tudo2Info)
                'FormGlobals.Panel_SetControlValue(_GroupControlObjectInfo, obj)
                If (value Is Nothing) Then
                    Return
                End If
                txtKy_Hieu.Text = _temp.KyHieu
                txtTen_Dm_Tudo_2.Text = _temp.TenDmTudo2
                txtMO_TA.Text = _temp.MoTa
                txtMA_TK.Text = _temp.MaTk
                chkCO_SU_DUNG.Checked = TNCommon.ParseBool(value.CoSuDung)

                cboDm_Tudo_2_Id_Cha1.EditValue = value.DmTudo2IdCha
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
        'Size = new Size()
        'Tiêu đề 
        Title = "Danh mục tự do 2"

        'Tên bảng truy vấn trong DB
        TableName = "DM_TUDO2"
        '
        '
        'Thêm các control bắt buộc nhập vào dây
        'Sample: _RequireInput = new Control[] { txtCap,txtKyHieu }
        RequireInputControls = New Control() {txtKy_Hieu, txtTen_Dm_Tudo_2, cboDm_Tudo_2_Id_Cha1}

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
            Dim dr As DmTudo2 = New DmTudo2()
            Dim dt As List(Of DmTudo2) = New List(Of DmTudo2)
            dt.AddRange(_DmTudo2Service.GetAllByDonviID(Generals.DON_VI.Id))
            dr.TenDmTudo2 = "Danh mục gốc"
            dr.Id = Guid.Empty
            dr.MaDmTudo2 = ""
            dr.Cap = 1
            dt.Insert(0, dr)

            Dim DanhMucChaColumnDefine As ArrayList = New ArrayList()
            DanhMucChaColumnDefine.Add(New ColumnInfo("TenDmTudo2", "Tên", 0, True, ""))
            TNCommon.BindData_LookupEdit(cboDm_Tudo_2_Id_Cha1, dt, "TenDmTudo2", "Id", DanhMucChaColumnDefine, True, True)
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private _temp As DmTudo2 = New DmTudo2()
    ''' <summary>
    ''' Bind data
    ''' </summary>
    Public Overrides Sub BindData()
        Try
            _temp = _DmTudo2Service.GetById(ID)
            ObjectInfo = _temp
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Public Overrides Sub InitComponet()
        Try
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
            AddHandler txtMA_TK.Validating, AddressOf ValidateData
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub
#End Region

#Region "Modify here"
    ''' <summary>
    '''Xử lý bắt lỗi dữ liệu
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private KH_Old As String = ""
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
                'Dim dt As DataTable = DM_Tudo2BO.Instance.GetByKyHieu(KH_New, Generals.DON_VI.DONVI_ID).Tables(0)
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
    ''' Luu dữ liệu vào DB (thêm mới hoặc sửa)
    ''' </summary>
    Public Overrides Sub Saving()
        Try
            Dim info As DmTudo2 = CType(ObjectInfo, DmTudo2)
            Select Case Mode
                Case FormGlobals.DataInputState.AddMode
                    info.ChiTiet = 1
                    ID = _DmTudo2Service.Save(info).Id
                Case FormGlobals.DataInputState.EditMode
                    _DmTudo2Service.SaveOrUpdate(info)
            End Select
            AfterSaveSuccess()
            Me.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.Close()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub
#End Region
End Class
