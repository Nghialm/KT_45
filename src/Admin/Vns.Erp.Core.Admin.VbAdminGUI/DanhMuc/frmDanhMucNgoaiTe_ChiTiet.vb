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
Imports Vns.Erp.Core.Admin.Domain
Imports Vns.Erp.Core.Admin.Service.Interface


Partial Public Class frmDanhMucNgoaiTe_ChiTiet
    Inherits FrmBaseDmChiTiet

    Private obj As DmNgoaite
    Dim _DmNgoaiteService As IDmNgoaiteService

    Public Property DmNgoaiteService() As IDmNgoaiteService
        Get
            Return _DmNgoaiteService
        End Get
        Set(value As IDmNgoaiteService)
            _DmNgoaiteService = value
        End Set
    End Property
#Region "Modify here"
    ''' <summary>
    ''' Kh?i t?o các thu?c tính phù h?p v?i form hi?n t?i
    ''' </summary>
    Public Overrides Sub InitProperty()
        'Size = new Size();
        'Tiêu d? 
        Title = "Danh mục ngoại tệ"

        'Tên b?ng truy v?n trong DB
        TableName = "DmNgoaite"

        'Thêm các control b?t bu?c nh?p vào dây
        'Sample: _RequireInput = new Control[] { txtCap,txtKyHieu };
        RequireInputControls = New Control() {txtKY_HIEU, txtTEN_NTE, txtTEN_NTE, txtTY_GIA}

        '---------------------------------------------------------------------
        ButtonSave = btnSave
        ButtonClear = btnClear
        ButtonCancel = btnCancel
        GroupControlObjectInfo = _GroupControlObjectInfo
    End Sub

    Private KH_Cu As String
    Public Overrides Sub ValidateData(ByVal sender As Object, ByVal e As CancelEventArgs)
        If sender Is txtKY_HIEU Then
            If txtKY_HIEU.Text.Trim = "" Then
                ErrorProvider.SetError(txtKY_HIEU, "Bạn chưa nhập ký hiệu")
                ErrorProvider.SetIconAlignment(txtKY_HIEU, ErrorIconAlignment.MiddleLeft)
                e.Cancel = True
            Else
                Dim kh As String = ""
                Select Case Mode
                    Case DataInputState.AddMode
                        kh = txtKY_HIEU.Text.Trim
                    Case DataInputState.EditMode
                        If txtKY_HIEU.Text.Trim <> KH_Cu Then
                            kh = txtKY_HIEU.Text.Trim
                        End If
                End Select

                If DmNgoaiteService.GetAllByKyHieu(kh).Count <> 0 Then
                    ErrorProvider.SetError(txtKY_HIEU, "Ký hiệu này đã tồn tại!")
                    ErrorProvider.SetIconAlignment(txtKY_HIEU, ErrorIconAlignment.MiddleLeft)
                    e.Cancel = True
                Else
                    ErrorProvider.SetError(txtKY_HIEU, "")
                    e.Cancel = False
                End If
            End If
        End If
    End Sub

    Private Sub KiemTraMa(ByVal Ma_NT As String, ByVal e As CancelEventArgs)

    End Sub

    ''' <summary>
    ''' Luu d? li?u vào DB (thêm m?i ho?c s?a)
    ''' </summary>
    Public Overrides Sub Saving()
        Try
            Dim info As DmNgoaite = CType(ObjectInfo, DmNgoaite)
            Select Case Mode
                Case FormGlobals.DataInputState.AddMode
                    ID = DmNgoaiteService.Save(info).Id

                Case FormGlobals.DataInputState.EditMode
                    DmNgoaiteService.SaveOrUpdate(info)
            End Select
            AfterSaveSuccess()
            Me.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.Close()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private temp As DmNgoaite = New DmNgoaite()

    ''' <summary>
    ''' Chuy?n d?i d? li?u qua l?i gi?a d?i tu?ng Info và form
    ''' </summary>
    Public Property ObjectInfo() As DmNgoaite
        'L?y d? li?u t? các tru?ng d? li?u trên form gán cho thu?c tính tuong ?ng c?a d?i tu?ng Info r?i tr? v? d?i tu?ng Info dó
        Get
            Dim info As DmNgoaite = New DmNgoaite()
            If Not ID Is Nothing Then
                info = DmNgoaiteService.Get(ID)
            End If
            'FormGlobals.Panel_GetControlValue(Me._GroupControlObjectInfo, info)
            info.KyHieu = Me.txtKY_HIEU.Text
            info.NguoiTao = Generals.USER.Id
            info.NguoiSua = Generals.USER.Id
            info.TenNte = Me.txtTEN_NTE.Text
            info.DonviId = Generals.DonviID
            info.MaDonvi = Generals.DON_VI.MaDonvi
            Select Case Mode
                Case FormGlobals.DataInputState.AddMode
                    info.MaNte = "0"

                Case FormGlobals.DataInputState.EditMode
                    info.MaNte = temp.MaNte
            End Select
            info.SynDate = Null.MIN_DATE

            MyBase.ResultObject = info
            Return info
        End Get

        'L?y d? li?u t? các thu?c tính c?a d?i tu?ng Info gán cho các tru?ng tuong ?ng trên form
        Set(ByVal value As DmNgoaite)
            If Not value Is Nothing Then
                Me.txtKY_HIEU.Text = value.KyHieu
                Me.txtTEN_NTE.Text = value.TenNte
                KH_Cu = value.KyHieu
            End If
        End Set
    End Property

    ''' <summary>
    ''' Kh?i t?o d? li?u cho các GridLookupEdit
    ''' </summary>
    Public Overrides Sub BindLookUpEdit()

    End Sub

    Public Overrides Sub BindData()
        Try
            temp = DmNgoaiteService.GetById(ID)
            ObjectInfo = temp
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

#End Region
    Public Sub New()
        InitializeComponent()
    End Sub
    'Public Overrides Sub InitComponet()
    '    InitializeComponent()
    'End Sub

    Private Sub frmDanhMucNgoaiTe_ChiTiet_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        InitProperty()
        CommonInit()
        Try
            AddHandler txtTY_GIA.Validating, AddressOf ValidateData
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub btnTyGia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTyGia.Click
        Try
            Dim GAN As Guid = Guid.Empty
            If ID IsNot Nothing Then
                GAN = ID
            Else
                GAN = Nothing
            End If

            Dim f As frmLS_TyGiaNgoaiTe_DanhSach = ObjectFactory.GetObject("frmLS_TyGiaNgoaiTe_DanhSach")
            f.MaTruyen = GAN.ToString
            f.ShowDialog()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

End Class

