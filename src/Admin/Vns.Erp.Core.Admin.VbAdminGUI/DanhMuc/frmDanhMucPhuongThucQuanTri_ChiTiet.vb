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


Partial Public Class frmDanhMucPhuongThucQuanTri_ChiTiet
    Inherits FrmBaseDmChiTiet

    Dim _DmTaikhoanService As IDmTaikhoanService
    Public Property DmTaikhoanService() As IDmTaikhoanService
        Get
            Return _DmTaikhoanService
        End Get
        Set(value As IDmTaikhoanService)
            _DmTaikhoanService = value
        End Set
    End Property
    Dim _DmPtqtService As IDmPtqtService
    Public Property DmPtqtService() As IDmPtqtService
        Get
            Return _DmPtqtService
        End Get
        Set(value As IDmPtqtService)
            _DmPtqtService = value
        End Set
    End Property
#Region "Modify here"
    '' <summary>
    '' Kh?i t?o các thu?c tính phù h?p v?i form hi?n t?i
    '' </summary>
    Public Overrides Sub InitProperty()
        'Size = new Size();
        'Tiêu d? 
        Title = "Danh mục phương thức quản trị"

        'Tên b?ng truy v?n trong DB
        TableName = "DmPtqt"

        'Thêm các control b?t bu?c nh?p vào dây
        'Sample: _RequireInput = new Control[] { txtCap,txtKyHieu };
        RequireInputControls = New Control() {txtTEN_PTQT, txtKY_HIEU}

        '---------------------------------------------------------------------
        ButtonSave = btnSave
        ButtonClear = btnClear
        ButtonCancel = btnCancel
        GroupControlObjectInfo = _GroupControlObjectInfo

        Dim columnDefine As ArrayList = New ArrayList()
        columnDefine.Add(New ColumnInfo("MaTaikhoan", "Mă tài khoản", 0, True, ""))
        columnDefine.Add(New ColumnInfo("TenTaikhoan", "Tên tài khoản", 0, True, ""))
        Dim dt As DataTable = Vns.Erp.Core.Dao.Util.DBUtil.ToDataTable(DmTaikhoanService.GetAllByDonviID(Generals.DON_VI.Id))
        Dim be As BaseGridPopupForm = New BaseGridPopupForm(txtMA_TK, "MaTaikhoan", dt, columnDefine)
        be.Text = "Chọn tài khoản"
        be.Size = New Size(500, 300)
        AddHandler txtMA_TK.Validating, AddressOf ValidateData

    End Sub

    ''' <summary>
    ''' X? lư b?t l?i d? li?u
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>

    Public Overrides Sub ValidateData(ByVal sender As Object, ByVal e As CancelEventArgs)
        If sender Is txtKY_HIEU Then
            If txtKY_HIEU.Text.Trim = "" Then
                ErrorProvider.SetError(txtKY_HIEU, "Bạn chưa nhập ký hiệu!")
                e.Cancel = True
            Else
                Dim KH_New As String = ""
                Select Case Mode
                    Case DataInputState.AddMode
                        KH_New = txtKY_HIEU.Text.Trim
                    Case DataInputState.EditMode
                        If txtKY_HIEU.Text.Trim <> KH_Old Then
                            KH_New = txtKY_HIEU.Text.Trim
                        End If
                End Select

                Dim dt As IList(Of DmPtqt) = DmPtqtService.GetByKyHieu(KH_New, Generals.DON_VI.Id)

                If dt.Count <> 0 Then
                    ErrorProvider.SetError(txtKY_HIEU, "Ký hiệu này đã tồn tại!")
                    e.Cancel = True
                Else
                    ErrorProvider.SetError(txtKY_HIEU, "")
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
            Dim info As DmPtqt = CType(ObjectInfo, DmPtqt)
            Select Case Mode
                Case FormGlobals.DataInputState.AddMode
                    ID = DmPtqtService().Save(info).Id


                Case FormGlobals.DataInputState.EditMode
                    DmPtqtService().SaveOrUpdate(info)
            End Select

            AfterSaveSuccess()
            Me.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.Close()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    'Luu gia tri cu cua DM khi sua. Them moi
    Private _temp As DmPtqt = New DmPtqt()
    Private KH_Old As String = ""
    ''' <summary>
    ''' Chuy?n d?i d? li?u qua l?i gi?a d?i tu?ng Info và form
    ''' </summary>
    Public Property ObjectInfo() As DmPtqt
        'L?y d? li?u t? các tru?ng d? li?u trên form gán cho thu?c tính tuong ?ng c?a d?i tu?ng Info r?i tr? v? d?i tu?ng Info dó
        Get
            Dim info As DmPtqt = New DmPtqt()
            If Not ID Is Nothing Then
                info = DmPtqtService.Get(ID)
            End If
            info.PtqtIdCha = VnsConvert.CGuid(cboPTQT_ID_CHA.EditValue)
            'info.MA_TK = cboMA_TK.EditValue.ToString();
            'Them moi
            If String.IsNullOrEmpty(_temp.MaPtqt) Then
                info.MaPtqt = " "
            Else
                info.MaPtqt = _temp.MaPtqt
            End If
            Select Case Mode
                Case FormGlobals.DataInputState.AddMode
                    info.ChiTiet = 1

                Case FormGlobals.DataInputState.EditMode
                    info.ChiTiet = _temp.ChiTiet
            End Select

            info.DonviId = Generals.DON_VI.Id
            info.MaDonvi = Generals.DON_VI.MaDonvi
            info.CoSuDung = TNCommon.ParseDecimal(chkCO_SU_DUNG.Checked)
            'info.CHO_PHEP_SUA = TNCommon.ParseDecimal(chkCHO_PHEP_SUA.Checked);
            info.NguoiTao = Generals.USER.Id
            info.NguoiSua = Generals.USER.Id
            info.MoTa = Me.txtMO_TA.Text
            info.MaTk = Me.txtMA_TK.Text
            info.KyHieu = Me.txtKY_HIEU.Text
            info.TenPtqt = Me.txtTEN_PTQT.Text

            MyBase.ResultObject = info
            Return info
        End Get

        'L?y d? li?u t? các thu?c tính c?a d?i tu?ng Info gán cho các tru?ng tuong ?ng trên form
        Set(ByVal value As DmPtqt)
            If Not value Is Nothing Then
                Dim obj As DmPtqt = TryCast(value, DmPtqt)
                'FormGlobals.Panel_SetControlValue(_GroupControlObjectInfo, obj)
                Me.txtKY_HIEU.Text = value.KyHieu
                Me.txtTEN_PTQT.Text = value.TenPtqt
                Me.txtMO_TA.Text = value.MoTa
                Me.txtMA_TK.Text = value.MaTk
                chkCO_SU_DUNG.Checked = (obj.CoSuDung = 1)
                cboPTQT_ID_CHA.EditValue = obj.PtqtIdCha
                ' cboMA_TK.EditValue = obj.MA_TK;
                KH_Old = obj.KyHieu
            End If
        End Set
    End Property

    ''' <summary>
    ''' Kh?i t?o d? li?u cho các GridLookupEdit
    ''' </summary>
    Public Overrides Sub BindLookUpEdit()
        Try
            'Bind danh m?c cha
            Dim dr As DmPtqt

            Dim dt As List(Of DmPtqt) = New List(Of DmPtqt)()
            dt.AddRange(DmPtqtService().GetAllByDonviID(Generals.DON_VI.Id))
            dr = New DmPtqt()
            dr.TenPtqt = "Phương thức gốc"
            dr.Id = Guid.Empty
            dr.MaPtqt = ""

            dt.Insert(0, dr)
            Dim DanhMucChaColumnDefine As ArrayList = New ArrayList()
            DanhMucChaColumnDefine.Add(New ColumnInfo("TenPtqt", "Tên phương thức quản trị", 0, True, ""))
            TNCommon.BindData_LookupEdit(cboPTQT_ID_CHA, dt, "TenPtqt", "Id", DanhMucChaColumnDefine, True, True)

        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    Public Overrides Sub BindData()
        Try
            'Them moi
            _temp = DmPtqtService().GetById(ID)
            ObjectInfo = _temp
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

    'Private Sub frmDanhMucPhuongThucQuanTri_ChiTiet_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
    '    'InitProperty()
    '    'CommonInit()
    '    Try
    '        If Mode = FormGlobals.DataInputState.AddMode Then
    '            TNCommon.SelectFirst(cboPTQT_ID_CHA)
    '        End If
    '    Catch ex As Exception

    '    End Try
    'End Sub

End Class
