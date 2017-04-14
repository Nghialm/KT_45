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
Imports DevExpress.XtraTreeList
Imports System.Collections
Imports Vns.Erp.Core.Admin.Domain
Imports Vns.Erp.Core.Admin.Service.Interface


Partial Public Class frmDanhMucVuViec_ChiTiet
    Inherits FrmBaseDmChiTiet

#Region "Modify here"
    Private Ma_Vv_old As String = ""
    Dim _DmVuviecService As IDmVuviecService
    Public Property DmVuviecService() As IDmVuviecService
        Get
            Return _DmVuviecService
        End Get
        Set(value As IDmVuviecService)
            _DmVuviecService = value
        End Set
    End Property
    Dim _DmTaikhoanService As IDmTaikhoanService
    Public Property DmTaikhoanService() As IDmTaikhoanService
        Get
            Return _DmTaikhoanService
        End Get
        Set(value As IDmTaikhoanService)
            _DmTaikhoanService = value
        End Set
    End Property

    ''' <summary>
    ''' Kh?i t?o các thu?c tính phù h?p v?i form hi?n t?i
    ''' </summary>
    Public Overrides Sub InitProperty()
        TNCommon.setIconControl(Me)
        'Size = new Size();
        'Tiêu d? 
        Title = "Danh mục vụ việc"

        'Tên b?ng truy v?n trong DB
        TableName = "DmVuviec"

        Dim columnDefine As ArrayList = New ArrayList()
        columnDefine.Add(New ColumnInfo("MaTaikhoan", "Mã tài khoản", 0, True, ""))
        columnDefine.Add(New ColumnInfo("TenTaikhoan", "Tên tài khoản", 0, True, ""))
        Dim dt As DataTable = Vns.Erp.Core.Dao.Util.DBUtil.ToDataTable(DmTaikhoanService.GetAllByDonviID(Generals.DON_VI.Id))
        Dim be As BaseGridPopupForm = New BaseGridPopupForm(txtMA_TK_LIENQUAN, "MaTaikhoan", dt, columnDefine)
        be.Text = "Chọn tài khoản"
        be.Size = New Size(500, 300)
        AddHandler txtMA_TK_LIENQUAN.Validating, AddressOf ValidateData

        RequireInputControls = New Control() {txtMA_VUVIEC, txtTEN_VUVIEC, txtKY_HIEU}

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
    Public Overrides Sub ValidateData(ByVal sender As Object, ByVal e As CancelEventArgs)
        If sender Is txtMA_VUVIEC Then
            If txtMA_VUVIEC.Text.Trim = "" Then
                ErrorProvider.SetError(txtMA_VUVIEC, "Bạn chưa nhập dữ liệu!")
                e.Cancel = True
            Else
                Dim Ma_Vv_New As String = ""
                Select Case Mode
                    Case DataInputState.AddMode
                        Ma_Vv_New = txtMA_VUVIEC.Text.Trim
                    Case DataInputState.EditMode
                        If Ma_Vv_old <> txtMA_VUVIEC.Text.Trim Then
                            Ma_Vv_New = txtMA_VUVIEC.Text.Trim
                        End If
                End Select
                Dim numberVuViec As Integer = DmVuviecService.GetNumberVuViecByMaVuViec(Ma_Vv_New, Generals.DON_VI.Id)
                If numberVuViec <> 0 Then
                    ErrorProvider.SetError(txtMA_VUVIEC, "Mã này đã tồn tại!")
                    e.Cancel = True
                Else
                    ErrorProvider.SetError(txtMA_VUVIEC, "")
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
            Dim info As DmVuviec = CType(ObjectInfo, DmVuviec)
            Select Case Mode
                Case FormGlobals.DataInputState.AddMode
                    ID = DmVuviecService().Save(info).Id

                Case FormGlobals.DataInputState.EditMode
                    DmVuviecService().SaveOrUpdate(info)
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
    Public Property ObjectInfo() As DmVuviec
        'L?y d? li?u t? các tru?ng d? li?u trên form gán cho thu?c tính tuong ?ng c?a d?i tu?ng Info r?i tr? v? d?i tu?ng Info dó
        Get
            Dim info As DmVuviec = New DmVuviec()
            If Not ID Is Nothing Then
                info = DmVuviecService.GetById(ID)
            End If

            info.MaVuviec = Me.txtMA_VUVIEC.Text
            info.TenVuviec = Me.txtTEN_VUVIEC.Text
            info.MaTkLienquan = Me.txtMA_TK_LIENQUAN.Text
            info.KyHieu = Me.txtKY_HIEU.Text
            'info.DONVI_ID = cboDONVI_ID.EditValue.ToString();
            info.DonviId = Generals.DON_VI.Id
            info.MaDonvi = Generals.DON_VI.MaDonvi
            info.CoSuDung = TNCommon.ParseDecimal(chkCO_SU_DUNG.Checked)
            info.ChoPhepSua = TNCommon.ParseDecimal(chkCO_SU_DUNG1.Checked)
            info.NguoiTao = Generals.USER.Id
            info.NguoiSua = Generals.USER.Id

            MyBase.ResultObject = info
            Return info
        End Get

        'L?y d? li?u t? các thu?c tính c?a d?i tu?ng Info gán cho các tru?ng tuong ?ng trên form
        Set(ByVal value As DmVuviec)
            If Not value Is Nothing Then
                Me.txtMA_VUVIEC.Text = value.MaVuviec
                Me.txtTEN_VUVIEC.Text = value.TenVuviec
                Me.txtMA_TK_LIENQUAN.Text = value.MaTkLienquan
                Me.txtKY_HIEU.Text = value.KyHieu

                chkCO_SU_DUNG.Checked = TNCommon.ParseBool(value.CoSuDung)
                Ma_Vv_old = value.MaVuviec
            End If
        End Set
    End Property

    ''' <summary>
    ''' Kh?i t?o d? li?u cho các GridLookupEdit
    ''' </summary>
    Public Overrides Sub BindLookUpEdit()

    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    Public Overrides Sub BindData()
        Try
            ObjectInfo = DmVuviecService().GetById(ID)
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

#End Region
#Region "Construction"
    Public Sub New()
        InitializeComponent()
        TNCommon.setIconControl(Me)
    End Sub
#End Region
    'Public Overrides Sub InitComponet()
    '    Try
    '        InitializeComponent()
    '    Catch ex As Exception
    '        Message_Error(ex)
    '    End Try
    'End Sub
    'Private Sub frmDanhMucVuViec_ChiTiet_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
    '    InitProperty()
    '    CommonInit()
    '    TNCommon.setIconControl(Me)
    'End Sub
End Class
