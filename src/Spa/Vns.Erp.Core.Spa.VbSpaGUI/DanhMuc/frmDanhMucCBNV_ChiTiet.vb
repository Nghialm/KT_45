Imports Vns.Erp.Core.Spa.Domain
Imports Vns.Erp.Core.Spa.Service.Interface

Public Class frmDanhMucCBNV_ChiTiet
    Inherits FrmBaseDmChiTiet

#Region "property"

    Private _SpaDmNhanvienService As ISpaDmNhanvienService
    Public Property SpaDmNhanvienService() As ISpaDmNhanvienService
        Get
            Return _SpaDmNhanvienService
        End Get
        Set(ByVal value As ISpaDmNhanvienService)
            _SpaDmNhanvienService = value
        End Set
    End Property

    Public Property ObjectInfo() As SpaDmNhanvien
        'L?y d? li?u t? các tru?ng d? li?u trên form gán cho thu?c tính tuong ?ng c?a d?i tu?ng Info r?i tr? v? d?i tu?ng Info dó
        Get
            Dim info As SpaDmNhanvien = New SpaDmNhanvien()
            If Not ID Is Nothing Then
                info.Id = VnsConvert.CGuid(ID)
            End If
            info.Ma = txtMa.Text
            info.Ten = txtTenNhanVien.Text
            info.KyHieu = txtKyHieu.Text
            info.MoTa = txtMota.Text
            info.NgaySinh = dteNgaySinh.DateTime
            info.SoDienThoai = txtSDT.Text
            info.DonviId = Generals.DON_VI.Id
            info.DaNghiViec = TNCommon.ParseDecimal(ckeDaNghi.Checked)

            MyBase.ResultObject = info
            Return info
        End Get

        'L?y d? li?u t? các thu?c tính c?a d?i tu?ng Info gán cho các tru?ng tuong ?ng trên form
        Set(ByVal value As SpaDmNhanvien)
            If Not value Is Nothing Then
                Dim obj As SpaDmNhanvien = TryCast(value, SpaDmNhanvien)
                txtMa.Text = obj.Ma
                txtKyHieu.Text = obj.KyHieu
                txtTenNhanVien.Text = obj.Ten
                txtMota.Text = obj.MoTa
                dteNgaySinh.DateTime = obj.NgaySinh
                txtSDT.Text = obj.SoDienThoai

                ckeDaNghi.Checked = obj.DaNghiViec

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
        'Size = new Size();
        'Tiêu d? 
        Title = "Danh cán bộ nhân viên"



        'Thêm các control b?t bu?c nh?p vào dây
        'Sample: _RequireInput = new Control[] { txtCap,txtKyHieu };
        RequireInputControls = New Control() {txtMa, txtTenNhanVien, txtKyHieu}

        '---------------------------------------------------------------------
        ButtonSave = btnSave
        ButtonClear = btnClear
        ButtonCancel = btnCancel
        GroupControlObjectInfo = _GroupControlObjectInfo
    End Sub

    Dim _temp As SpaDmNhanvien
    Public Overrides Sub BindData()
        Try
            Select Case Mode
                Case DataInputState.EditMode
                    _temp = _SpaDmNhanvienService.GetById(ID)
                    ObjectInfo = _temp
            End Select
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Public Overrides Sub Saving()
        Dim info As SpaDmNhanvien = CType(ObjectInfo, SpaDmNhanvien)
        Select Case Mode
            Case FormGlobals.DataInputState.AddMode
                ID = _SpaDmNhanvienService.Save(info).Id
            Case FormGlobals.DataInputState.EditMode
                _SpaDmNhanvienService.SaveOrUpdate(info)
        End Select
        AfterSaveSuccess()
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub
#End Region


End Class