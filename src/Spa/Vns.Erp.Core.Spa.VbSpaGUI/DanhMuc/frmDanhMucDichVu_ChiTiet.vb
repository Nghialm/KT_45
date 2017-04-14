Imports Vns.Erp.Core.Spa.Domain
Imports Vns.Erp.Core.Spa.Service.Interface

Public Class frmDanhMucDichVu_ChiTiet
    Inherits FrmBaseDmChiTiet

#Region "property"
    Private MaCu As String

    Private _SpaDmDichVuService As ISpaDmDichVuService
    Public Property SpaDmDichVuService() As ISpaDmDichVuService
        Get
            Return _SpaDmDichVuService
        End Get
        Set(ByVal value As ISpaDmDichVuService)
            _SpaDmDichVuService = value
        End Set
    End Property

    Public Property ObjectInfo() As SpaDmDichVu
        'L?y d? li?u t? các tru?ng d? li?u trên form gán cho thu?c tính tuong ?ng c?a d?i tu?ng Info r?i tr? v? d?i tu?ng Info dó
        Get
            Dim info As SpaDmDichVu = New SpaDmDichVu()
            If Not ID Is Nothing Then
                info.Id = VnsConvert.CGuid(ID)
            End If
            info.Ma = txtMa.Text
            info.Ten = txtTenThe.Text
            info.Kyhieu = txtKyHieu.Text
            info.MoTa = txtMota.Text
            info.DonGia = Decimal.Parse(txtGia.Text)
            info.DonviId = Generals.DON_VI.Id

            If Not String.IsNullOrEmpty(cboDMCha.EditValue.ToString) Then
                info.DichvuIdCha = cboDMCha.EditValue
            End If

            info.NguoiTao = Generals.USER.Id
            info.NgayTao = Date.Now

            MyBase.ResultObject = info
            Return info
        End Get

        'L?y d? li?u t? các thu?c tính c?a d?i tu?ng Info gán cho các tru?ng tuong ?ng trên form
        Set(ByVal value As SpaDmDichVu)
            If Not value Is Nothing Then
                Dim obj As SpaDmDichVu = TryCast(value, SpaDmDichVu)

                txtMa.Text = obj.Ma
                txtTenThe.Text = obj.Ten
                txtKyHieu.Text = obj.Kyhieu
                txtMota.Text = obj.MoTa
                txtGia.EditValue = obj.DonGia
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
    Public Overrides Sub BindLookUpEdit()

        'Bind danh m?c cha
        Dim dtDMCHA As IList(Of SpaDmDichVu) = _SpaDmDichVuService.GetAll()
        Dim _DMCHAColumnDefine As ArrayList = New ArrayList()
        _DMCHAColumnDefine.Add(New ColumnInfo("Ten", "Tên dịch vụ", 0, True, ""))
        Dim root As SpaDmDichVu = New SpaDmDichVu()
        root.Ten = "Danh mục gốc"
        root.Id = Guid.Empty
        root.Ma = ""
        dtDMCHA.Insert(0, root)
        TNCommon.BindData_LookupEdit(cboDMCha, dtDMCHA, "Ten", "Id", _DMCHAColumnDefine, True, True)
        TNCommon.SelectFirst(cboDMCha)
    End Sub

    Public Overrides Sub InitProperty()

        Title = "Danh mục dịch vụ"

        RequireInputControls = New Control() {txtMa, txtKyHieu, txtTenThe, txtGia}

        '---------------------------------------------------------------------
        ButtonSave = btnSave
        ButtonClear = btnClear
        ButtonCancel = btnCancel
        GroupControlObjectInfo = _GroupControlObjectInfo

        txtMa.Properties.ValidateOnEnterKey = True
    End Sub

    Dim _temp As SpaDmDichVu
    Public Overrides Sub BindData()
        Try
            Select Case Mode
                Case DataInputState.EditMode
                    _temp = _SpaDmDichVuService.GetById(ID)
                    ObjectInfo = _temp
            End Select
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Public Overrides Sub Saving()
        Dim info As SpaDmDichVu = CType(ObjectInfo, SpaDmDichVu)
        Select Case Mode
            Case FormGlobals.DataInputState.AddMode
                ID = _SpaDmDichVuService.Save(info).Id
            Case FormGlobals.DataInputState.EditMode
                _SpaDmDichVuService.SaveOrUpdate(info)
        End Select
        AfterSaveSuccess()
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub
#End Region

End Class