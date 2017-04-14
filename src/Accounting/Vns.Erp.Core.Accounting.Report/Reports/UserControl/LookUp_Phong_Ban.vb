Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Columns
Imports Vns.Erp.Core.Admin.Domain
Imports Vns.Erp.Core.Admin.Service.Interface
Public Class LookUp_Phong_Ban
    Private _DmPhongbanService As IDmPhongbanService
    Private Property DmPhongbanService As IDmPhongbanService
        Get
            Return _DmPhongbanService
        End Get
        Set(ByVal value As IDmPhongbanService)
            _DmPhongbanService = value
        End Set
    End Property
    Public Sub New(ByVal htbienbaocao As HtBienBaocao)
        InitializeComponent()
        Parameter_info = htbienbaocao
        If (Parameter_info.TenBien <> "") Then
            lblPhongBan.Text = Parameter_info.TenBien
        End If
    End Sub

    Private Sub LookUp_LoaiKHang_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            If Not Me.DesignMode Then
                Dim drpList As List(Of DmPhongban) = New List(Of DmPhongban)
                Dim drpListTEMP As New List(Of DmPhongban)
                drpListTEMP.AddRange(_DmPhongbanService.GetAllByDonviID(Generals.DON_VI.Id))

                Dim obj As DmPhongban = New DmPhongban
                obj.TenPhongban = "Không xác định"
                obj.MaPhongban = Nothing
                drpList.Add(obj)
                drpList.AddRange(drpListTEMP)
                cboPhongBan.Properties.DataSource = drpList
                cboPhongBan.Properties.ValueMember = "Id"
                cboPhongBan.Properties.DisplayMember = "MaPhongban"
                If (Parameter_info.TenBien <> "") Then
                    lblPhongBan.Text = Parameter_info.TenBien
                End If
                cboPhongBan.Properties.View.ActiveFilterString = Parameter_info.GiaTriBien
                cboPhongBan.Properties.View.OptionsView.ShowFilterPanelMode = ShowFilterPanelMode.Never
                For Each gridCol As GridColumn In cboPhongBan.Properties.View.Columns
                    gridCol.OptionsFilter.AllowFilter = False
                Next
                cboPhongBan.EditValue = Nothing
                cboPhongBan.Text = "Không xác định"
            End If
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub cboLoaiKhachHang_EditValueChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboPhongBan.EditValueChanged
        Try
            Dim drPhongBan As DmPhongban = CType(ComboHelper.GetSelectData(cboPhongBan), DmPhongban)
            If drPhongBan Is Nothing Then Return

            Value_info.ParameterValue = drPhongBan.Id
            Value_info.Ten = drPhongBan.TenPhongban
            lblTenPhongBan.Text = drPhongBan.TenPhongban
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

End Class
