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


Partial Public Class frmDanhMucThue_ChiTiet
    Inherits FrmBaseDmChiTiet
    Dim _DmThueService As IDmThueService

    Public Property DmThueService() As IDmThueService
        Get
            Return _DmThueService
        End Get
        Set(value As IDmThueService)
            _DmThueService = value
        End Set
    End Property
#Region "Modify here"
    ''' <summary>
    ''' Kh?i t?o các thu?c tính phù h?p v?i form hi?n t?i
    ''' </summary>
    Public Overrides Sub InitProperty()
        'Size = new Size();
        'Tiêu d? 
        Title = "Danh mục thuế"

        'Tên b?ng truy v?n trong DB
        TableName = "DmThue"

        'Thêm các control b?t bu?c nh?p vào dây
        'Sample: _RequireInput = new Control[] { txtCap,txtKyHieu };
        RequireInputControls = New Control() {txtMA_THUE, txtTEN_THUE, txtKY_HIEU}

        '---------------------------------------------------------------------
        ButtonSave = btnSave
        ButtonClear = btnClear
        ButtonCancel = btnCancel
        GroupControlObjectInfo = _GroupControlObjectInfo
        TNCommon.setIconControl(Me)
    End Sub

    Private Function KiemTraMa(ByVal ma As String) As Boolean
        If DmThueService.GetNumberDmThueByMaThue(ma.Trim) <> 0 Then
            Return False
        End If
        Return True
    End Function

    Private Ma_thue As String

    Public Overrides Sub ValidateData(ByVal sender As Object, ByVal e As CancelEventArgs)
        Try
            If sender Is txtMA_THUE Then
                If txtMA_THUE.Text.Trim = "" Then
                    ErrorProvider.SetError(txtMA_THUE, "Bạn chưa nhập mã thuế")
                    ErrorProvider.SetIconAlignment(txtTY_LE, ErrorIconAlignment.MiddleRight)
                    e.Cancel = True
                    'Exit Sub
                Else
                    Dim ma As String = ""
                    Select Case Mode
                        Case DataInputState.AddMode
                            ma = txtMA_THUE.Text
                        Case DataInputState.EditMode
                            If Not Ma_thue.Equals(txtMA_THUE.Text) Then
                                ma = txtMA_THUE.Text
                            End If
                    End Select

                    If Not KiemTraMa(ma) Then
                        ErrorProvider.SetError(txtMA_THUE, "Mã này đã tồn tại")
                        ErrorProvider.SetIconAlignment(txtTY_LE, ErrorIconAlignment.MiddleRight)
                        e.Cancel = True
                    Else
                        ErrorProvider.SetError(txtMA_THUE, "")
                        e.Cancel = False
                    End If
                End If
            End If

            If sender Is txtTY_LE Then
                If txtTY_LE.Text = "" Then
                    txtTY_LE.Text = "0"
                End If
                If Decimal.Parse(Me.txtTY_LE.Text) >= 1000 Then
                    ErrorProvider.SetError(txtTY_LE, "Tỷ lệ phải nhỏ hơn 1000")
                    ErrorProvider.SetIconAlignment(txtTY_LE, ErrorIconAlignment.MiddleRight)
                    e.Cancel = True
                ElseIf Decimal.Parse(Me.txtTY_LE.Text) < 0 Then
                    ErrorProvider.SetError(txtTY_LE, "Tỷ lệ phải lớn hơn 0")
                    ErrorProvider.SetIconAlignment(txtTY_LE, ErrorIconAlignment.MiddleRight)
                    e.Cancel = True
                Else
                    ErrorProvider.SetError(txtTY_LE, "")
                    e.Cancel = False
                End If
            End If
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    ''' <summary>
    ''' Luu d? li?u vào DB (thêm m?i ho?c s?a)
    ''' </summary>
    Public Overrides Sub Saving()
        Try
            Dim info As DmThue = ObjectInfo
            Select Case Mode
                Case FormGlobals.DataInputState.AddMode
                    ID = DmThueService.Save(info).Id
                Case FormGlobals.DataInputState.EditMode
                    DmThueService.SaveOrUpdate(info)
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
    Public Property ObjectInfo() As DmThue
        'L?y d? li?u t? các tru?ng d? li?u trên form gán cho thu?c tính tuong ?ng c?a d?i tu?ng Info r?i tr? v? d?i tu?ng Info dó
        Get
            Dim info As DmThue = New DmThue()
            If Not ID Is Nothing Then
                info = DmThueService.Get(ID)
            End If
            'FormGlobals.Panel_GetControlValue(Me._GroupControlObjectInfo, info)
            info.TyLe = Decimal.Parse(txtTY_LE.Text)
            info.ThueIdCha = New Guid(cboTHUE_ID_CHA.EditValue.ToString)
            info.XuatKhau = TNCommon.ParseDecimal(chkXUAT_KHAU.Checked)
            info.MuaHang = TNCommon.ParseDecimal(chkMuaHang.Checked)
            info.ChiTiet = TNCommon.ParseDecimal(chkCHI_TIET.Checked)
            info.CoSuDung = TNCommon.ParseDecimal(chkCO_SU_DUNG.Checked)
            info.ChoPhepSua = TNCommon.ParseDecimal(chkCHO_PHEP_SUA.Checked)
            info.NguoiTao = Generals.USER.Id
            info.NguoiSua = Generals.USER.Id
            info.MaThue = Me.txtMA_THUE.Text
            info.KyHieu = Me.txtKY_HIEU.Text
            info.TenThue = Me.txtTEN_THUE.Text

            MyBase.ResultObject = info
            Return info
        End Get

        'L?y d? li?u t? các thu?c tính c?a d?i tu?ng Info gán cho các tru?ng tuong ?ng trên form
        Set(ByVal value As DmThue)
            If Not value Is Nothing Then
                Dim obj As DmThue = value
                Me.txtKY_HIEU.Text = value.KyHieu
                Me.txtMA_THUE.Text = value.MaThue
                Me.txtTEN_THUE.Text = value.TenThue

                'chkCHI_TIET.Checked = (obj.CHI_TIET == 1);
                chkCHO_PHEP_SUA.Checked = (obj.ChoPhepSua = 1)
                chkCO_SU_DUNG.Checked = (obj.CoSuDung = 1)
                txtTY_LE.EditValue = obj.TyLe
                cboTHUE_ID_CHA.EditValue = obj.ThueIdCha
                chkXUAT_KHAU.Checked = (obj.XuatKhau = 1)
                chkMuaHang.Checked = (obj.MuaHang = 1)
                chkCHI_TIET.Checked = (obj.ChiTiet = 1)
                Ma_thue = obj.MaThue
            End If
        End Set
    End Property

    ''' <summary>
    ''' Kh?i t?o d? li?u cho các GridLookupEdit
    ''' </summary>
    Public Overrides Sub BindLookUpEdit()
        Try
            'Bind danh m?c cha
            Dim dr As DmThue
            Dim dt As List(Of DmThue) = New List(Of DmThue)
            dt.AddRange(DmThueService.GetAll())
            dr = New DmThue()
            dr.TenThue = "Thuế gốc"
            dr.Id = Guid.Empty
            dr.MaThue = ""
            'dr["CAP"] = 1;
            dt.Insert(0, dr)

            Dim DanhMucChaColumnDefine As ArrayList = New ArrayList()
            DanhMucChaColumnDefine.Add(New ColumnInfo("TenThue", "Tên thuế cha", 0, True, ""))
            TNCommon.BindData_LookupEdit(cboTHUE_ID_CHA, dt, "TenThue", "Id", DanhMucChaColumnDefine, True, True)
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    Public Overrides Sub BindData()
        Try
            ObjectInfo = DmThueService.GetById(ID)
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

#End Region
#Region "Construction"
    Public Sub New()
        InitializeComponent()

    End Sub
#End Region
    'Public Overrides Sub InitComponet()
    '    InitializeComponent()
    'End Sub

    'Private Sub frmDanhMucThue_ChiTiet_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
    '    'InitComponet()
    '    InitProperty()
    '    CommonInit()
    '    Try
    '        If cboTHUE_ID_CHA.Text = "" Then
    '            cboTHUE_ID_CHA.ItemIndex = 0
    '        End If

    '        AddHandler txtTY_LE.Validating, AddressOf ValidateData

    '    Catch ex As Exception
    '        Message_Error(ex)
    '    End Try
    'End Sub

End Class
