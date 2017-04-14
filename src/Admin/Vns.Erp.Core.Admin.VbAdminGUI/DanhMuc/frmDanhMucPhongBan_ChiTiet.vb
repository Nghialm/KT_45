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

Partial Public Class frmDanhMucPhongBan_ChiTiet
    Inherits FrmBaseDmChiTiet

#Region "Variables and Messages"
    Dim _DmPhongbanService As IDmPhongbanService
    Public Property DmPhongbanService() As IDmPhongbanService
        Get
            Return _DmPhongbanService
        End Get
        Set(ByVal value As IDmPhongbanService)
            _DmPhongbanService = value
        End Set
    End Property

    Private _temp As DmPhongban = New DmPhongban()
    Public Property ObjectInfo() As DmPhongban
        'L?y d? li?u t? các tru?ng d? li?u trên form gán cho thu?c tính tuong ?ng c?a d?i tu?ng Info r?i tr? v? d?i tu?ng Info dó
        Get
            Dim info As DmPhongban = New DmPhongban()
            If Not ID Is Nothing Then
                info = Me.DmPhongbanService.Get(ID)
            End If
            'FormGlobals.Panel_GetControlValue(Me._GroupControlObjectInfo, info)
            info.KyHieu = Me.txtKy_Hieu.Text
            info.DiaChi = Me.txtDIA_CHI.Text
            info.TenPhongban = Me.txtTEN_PHONGBAN.Text
            info.PhongbanIdCha = New Guid(cboPHONGBAN_ID_CHA1.EditValue.ToString())
            info.DonviId = Generals.DON_VI.Id
            info.MaDonvi = Generals.DON_VI.MaDonvi
            info.NguoiTao = Generals.USER.Id
            info.NguoiSua = Generals.USER.Id
            info.ChiTiet = _temp.ChiTiet
            info.CoSuDung = TNCommon.ParseDecimal(chkCO_SU_DUNG.Checked)
            If String.IsNullOrEmpty(_temp.MaPhongban) Then
                info.MaPhongban = " "
            Else
                info.MaPhongban = _temp.MaPhongban
            End If
            Select Case Mode
                Case FormGlobals.DataInputState.AddMode
                    info.ChiTiet = 1

                Case FormGlobals.DataInputState.EditMode

            End Select

            MyBase.ResultObject = info
            Return info
        End Get

        'L?y d? li?u t? các thu?c tính c?a d?i tu?ng Info gán cho các tru?ng tuong ?ng trên form
        Set(ByVal value As DmPhongban)
            If Not value Is Nothing Then
                Dim obj As DmPhongban = TryCast(value, DmPhongban)
                'FormGlobals.Panel_SetControlValue(_GroupControlObjectInfo, obj)
                Me.txtKy_Hieu.Text = obj.KyHieu
                Me.txtDIA_CHI.Text = obj.DiaChi
                Me.txtTEN_PHONGBAN.Text = obj.TenPhongban
                chkCO_SU_DUNG.Checked = TNCommon.ParseBool(obj.CoSuDung)
                cboPHONGBAN_ID_CHA1.EditValue = obj.PhongbanIdCha
                KH_old = obj.KyHieu
            End If
        End Set
    End Property
#End Region

#Region "Construction"
    Public Sub New()
        InitializeComponent()
    End Sub
#End Region

#Region "Load Form"
    Public Overrides Sub InitProperty()
        TNCommon.setIconControl(Me)
        'Size = new Size();
        'Tiêu d? 
        Title = "Danh mục phòng ban"

        'Tên b?ng truy v?n trong DB
        TableName = "DM_PHONGBAN"

        'Thêm các control b?t bu?c nh?p vào dây
        'Sample: _RequireInput = new Control[] { txtCap,txtKyHieu };
        RequireInputControls = New Control() {txtKy_Hieu, txtTEN_PHONGBAN, cboPHONGBAN_ID_CHA1}


        '---------------------------------------------------------------------
        ButtonSave = btnSave
        ButtonClear = btnClear
        ButtonCancel = btnCancel
        GroupControlObjectInfo = _GroupControlObjectInfo
    End Sub

    Public Overrides Sub BindLookUpEdit()
        Try

            Dim dt As List(Of DmPhongban) = New List(Of DmPhongban)
            dt.AddRange(DmPhongbanService.GetAllByDonviID(Generals.DON_VI.Id))
            'dr = dt.NewRow()
            'dr("TEN_PHONGBAN") = "Danh mục gốc"
            'dr("PHONGBAN_ID") = Guid.Empty.ToString().Replace("-", "")
            'dr("MA_PHONGBAN") = ""
            'dt.Rows.InsertAt(dr, 0)
            Dim root As DmPhongban = New DmPhongban()
            root.TenPhongban = "Danh mục gốc"
            root.Id = Guid.Empty
            root.MaPhongban = ""
            dt.Insert(0, root)
            Dim DanhMucChaColumnDefine As ArrayList = New ArrayList()
            DanhMucChaColumnDefine.Add(New ColumnInfo("TenPhongban", "Tên phòng ban", 0, True, ""))
            TNCommon.BindData_LookupEdit(cboPHONGBAN_ID_CHA1, dt, "TenPhongban", "Id", DanhMucChaColumnDefine, True, True)
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Public Overrides Sub BindData()
        Try
            Select Case Mode
                Case FormGlobals.DataInputState.AddMode
                    cboPHONGBAN_ID_CHA1.ItemIndex = 0
                Case FormGlobals.DataInputState.EditMode
                    _temp = Me.DmPhongbanService.GetById(VnsConvert.CGuid(ID))
                    ObjectInfo = _temp
            End Select
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Public Overrides Sub Saving()
        Try
            Dim info As DmPhongban = CType(ObjectInfo, DmPhongban)
            Select Case Mode
                Case FormGlobals.DataInputState.AddMode
                    ID = DmPhongbanService.Save(info).Id
                Case FormGlobals.DataInputState.EditMode
                    ID = DmPhongbanService.SaveOrUpdate(info).Id
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

#End Region

    Private KH_old As String = ""
    Public Overrides Sub ValidateData(ByVal sender As Object, ByVal e As CancelEventArgs)
        Try
            If sender Is txtKy_Hieu Then
                If txtKy_Hieu.Text.Trim = "" Then
                    ErrorProvider.SetError(txtKy_Hieu, "Bạn chưa nhập mã phòng ban")
                    ErrorProvider.SetIconAlignment(txtKy_Hieu, ErrorIconAlignment.MiddleLeft)
                    e.Cancel = True
                Else
                    Dim ky_hieu As String = ""
                    Select Case Mode
                        Case DataInputState.AddMode
                            ky_hieu = txtKy_Hieu.Text.Trim
                        Case DataInputState.EditMode
                            If KH_old.Trim <> txtKy_Hieu.Text.Trim Then
                                ky_hieu = txtKy_Hieu.Text.Trim
                            End If
                    End Select

                    Dim dt As IList(Of DmPhongban) = DmPhongbanService.GetKy_hieu(ky_hieu, Generals.DON_VI.Id)

                    If dt.Count > 0 Then
                        ErrorProvider.SetError(txtKy_Hieu, "Mã phòng ban này đã tồn tại")
                        ErrorProvider.SetIconAlignment(txtKy_Hieu, ErrorIconAlignment.MiddleLeft)
                        e.Cancel = True
                    Else
                        ErrorProvider.SetError(txtKy_Hieu, "")
                        e.Cancel = False
                    End If
                End If
            End If
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

End Class
