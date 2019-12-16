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



Partial Public Class frmDanhMucKho_ChiTiet
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
    Private _DmKhoService As IDmKhoService
    Public Property DmKhoService() As IDmKhoService
        Get
            Return _DmKhoService
        End Get
        Set(ByVal value As IDmKhoService)
            _DmKhoService = value
        End Set
    End Property


#Region "Modify here"
    ''' <summary>
    ''' Kh?i t?o các thu?c tính phù h?p v?i form hi?n t?i
    ''' </summary>
    Public Overrides Sub InitProperty()
        'Size = new Size();
        'Tiêu d? 

        Title = "Danh mục kho"

        'Tên b?ng truy v?n trong DB
        TableName = "DmKho"

        'Thêm các control b?t bu?c nh?p vào dây
        'Sample: _RequireInput = new Control[] { txtCap,txtKyHieu };
        RequireInputControls = New Control() {txtTEN_KHO, txtKY_HIEU}

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
    ''' <param name="e"></param>
    Public Overrides Sub ValidateData(ByVal sender As Object, ByVal e As CancelEventArgs)

    End Sub

    ''' <summary>
    ''' Luu d? li?u vào DB (thêm m?i ho?c s?a)
    ''' </summary>
    Public Overrides Sub Saving()
        Try
            ' Kiem tra ket qua validation Ma kho
            If flgMaKho = False Then
                ' Stop process
                Exit Sub
            End If

            ' Save thong tin kho hang
            Dim info As DmKho = ObjectInfo
            Select Case Mode
                Case FormGlobals.DataInputState.AddMode
                    ID = DmKhoService.Save(info).Id

                Case FormGlobals.DataInputState.EditMode
                    DmKhoService.SaveOrUpdate(info)
            End Select
            AfterSaveSuccess()
            Me.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.Close()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private ngaySua As DateTime = New DateTime()
    Private temp As DmKho = New DmKho()
    ''' <summary>
    ''' Chuy?n d?i d? li?u qua l?i gi?a d?i tu?ng Info và form
    ''' </summary>
    Public Property ObjectInfo() As DmKho
        'L?y d? li?u t? các tru?ng d? li?u trên form gán cho thu?c tính tuong ?ng c?a d?i tu?ng Info r?i tr? v? d?i tu?ng Info dó
        Get
            Dim info As DmKho = New DmKho()
            If Not ID Is Nothing Then
                info = DmKhoService.Get(ID)
            End If
            'FormGlobals.Panel_GetControlValue(Me._GroupControlObjectInfo, info)

            Select Case Mode
                Case FormGlobals.DataInputState.AddMode
                    info.MaKho = txtKY_HIEU.Text
                    info.Id = Guid.NewGuid()
                Case FormGlobals.DataInputState.EditMode
                    info.MaKho = txtKY_HIEU.Text.Trim
            End Select
            info.KyHieu = Me.txtKY_HIEU.Text
            info.TenKho = Me.txtTEN_KHO.Text
            info.DiaChi = txtDIA_CHI.Text
            info.DonviId = Generals.DON_VI.Id
            info.MaDonvi = Generals.DON_VI.MaDonvi
            info.NguoiTao = Generals.USER.Id
            info.NguoiSua = Generals.USER.Id
            info.CoSuDung = TNCommon.ParseDecimal(chkCO_SU_DUNG.Checked)
            info.XuatAm = TNCommon.ParseDecimal(chkXUAT_AM.Checked)
            info.ChoPhepSua = TNCommon.ParseDecimal(chkCHO_PHEP_SUA.Checked)
            info.SynDate = Null.MIN_DATE

            info.DiaLy = cboDiaLy.EditValue
            info.LoaiKho = cboLOAI_KHO.EditValue
            MyBase.ResultObject = info
            Return info
        End Get

        'L?y d? li?u t? các thu?c tính c?a d?i tu?ng Info gán cho các tru?ng tuong ?ng trên form
        Set(ByVal value As DmKho)
            If Not value Is Nothing Then
                Dim obj As DmKho = TryCast(value, DmKho)
                'FormGlobals.Panel_SetControlValue(_GroupControlObjectInfo, obj)
                Me.txtDIA_CHI.Text = obj.DiaChi
                Me.txtKY_HIEU.Text = obj.KyHieu
                Me.txtTEN_KHO.Text = obj.TenKho
                obj.DonviId = Generals.DON_VI.Id
                obj.MaDonvi = Generals.DON_VI.MaDonvi
                chkCHO_PHEP_SUA.Checked = TNCommon.ParseBool(obj.ChoPhepSua)
                chkXUAT_AM.Checked = TNCommon.ParseBool(obj.XuatAm)
                chkCO_SU_DUNG.Checked = TNCommon.ParseBool(obj.CoSuDung)

                cboDiaLy.EditValue = Convert.ToInt32(obj.DiaLy)
                cboLOAI_KHO.EditValue = Convert.ToInt32(obj.LoaiKho)
            End If
        End Set
    End Property

    ''' <summary>
    ''' Kh?i t?o d? li?u cho các GridLookupEdit
    ''' </summary>
    Public Overrides Sub BindLookUpEdit()
        Try
            'Bind loại kho
            Dim dr As DataRow
            Dim dtLK As IList(Of HtDanhmuc) = HtDanhmucService.GetByDoiTuong("LOAI_KHO")
            Dim dtDiaLy As IList(Of HtDanhmuc) = HtDanhmucService.GetByDoiTuong("DIA_LY")
            'Dim dtLK As DataTable = New DataTable()
            'If (Not dsLK Is Nothing) AndAlso (dsLK.Tables.Count > 0) Then
            '    dtLK = dsLK.Tables(0)
            'End If

            Dim LoaiKhoColumnDefine As ArrayList = New ArrayList()
            LoaiKhoColumnDefine.Add(New ColumnInfo("TenDanhmuc", "Tên loại kho", 0, True, ""))
            TNCommon.BindData_LookupEdit(cboLOAI_KHO, dtLK, "TenDanhmuc", "GiaTri", LoaiKhoColumnDefine, True, True)

            Dim DiaLyColumnDefine As ArrayList = New ArrayList()
            DiaLyColumnDefine.Add(New ColumnInfo("TenDanhmuc", "Địa lý", 0, True, ""))
            TNCommon.BindData_LookupEdit(cboDiaLy, dtDiaLy, "TenDanhmuc", "GiaTri", DiaLyColumnDefine, True, True)
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    Public Overrides Sub BindData()
        Try
            temp = DmKhoService.GetById(ID)
            ObjectInfo = temp
            ngaySua = temp.NgaySua
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

#End Region

    'Public Overrides Sub InitComponet()
    '    InitializeComponent()
    'End Sub
#Region "Construction"
    Public Sub New()
        InitializeComponent()
    End Sub
#End Region
    Private flgMaKho As Boolean = True

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Try
            ' Reset flag status
            flgMaKho = True

            ' Kiem tra Ma kho ton tai trong DB
            ' Trang thai cua form la Add mode hoac Edit mode nhung co sua Ky hieu
            If (Mode = DataInputState.AddMode) Or (Mode = DataInputState.EditMode And txtKY_HIEU.Text.Trim() <> temp.KyHieu) Then
                ' Lay so record co Ma kho tuong tu trong DB
                Dim countMaKho As Integer = DmKhoService.GetNumberDmKhoByKyHieu(txtKY_HIEU.Text.Trim(), Generals.DON_VI.Id)

                ' Ma kho da duoc su dung trong DB
                If countMaKho > 0 Then
                    ' Change flag status
                    flgMaKho = False

                    ' Show warning msg
                    Message_Warning("Mã kho đã có trong cơ sở dữ liệu. Xin chọn mã kho khác!")
                    txtKY_HIEU.Focus()
                End If
            End If
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub
    Private Sub frmDanhMucKho_ChiTiet_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        InitProperty()
        BindLookUpEdit()
        CommonInit()
        TNCommon.setIconControl(Me)
    End Sub
End Class
