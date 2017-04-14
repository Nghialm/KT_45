Imports Vns.Erp.Core.Asset.Domain
Imports Vns.Erp.Core.Asset.Service.Interface

Imports Vns.Erp.Core.Admin.Domain
Imports Vns.Erp.Core.Admin.Service.Interface

Public Class LookUp_Ma_Loai_Tai_San
    Private _DmLoaitaisanService As IDmLoaitaisanService
    Public Property DmLoaitaisanService As IDmLoaitaisanService
        Get
            Return _DmLoaitaisanService
        End Get
        Set(ByVal value As IDmLoaitaisanService)
            _DmLoaitaisanService = value
        End Set
    End Property
    Public Sub New(ByVal HT_bienbaoCao As HtBienBaocao)
        InitializeComponent()
        Parameter_info = HT_bienbaoCao
        If (Parameter_info.TenBien <> "") Then
            LabelControl1.Text = Parameter_info.TenBien
        End If
    End Sub

    Private Sub LookUp_Ma_Loai_Tai_San_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            If Not Me.DesignMode Then
                Dim drpList As List(Of DmLoaitaisan) = New List(Of DmLoaitaisan)
                Dim drpListTEMP As New List(Of DmLoaitaisan)
                drpListTEMP.AddRange(_DmLoaitaisanService.GetAll())

                Dim obj As DmLoaitaisan = New DmLoaitaisan
                obj.TenLoaitaisan = "Không xác định"
                obj.MaLoaitaisan = Nothing
                drpList.Add(obj)
                drpList.AddRange(drpListTEMP)

                cboLoaiTaiSan.Properties.DataSource = drpList
                cboLoaiTaiSan.Properties.ValueMember = "TenLoaitaisan"
                cboLoaiTaiSan.Properties.DisplayMember = "MaLoaitaisan"
                lblTenLoaiTanSan.Text = "Không xác định"
            End If
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub cboLoaiTaiSan_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboLoaiTaiSan.EditValueChanged
        Try
            Dim drDonVi As DmLoaitaisan = cboLoaiTaiSan.Properties.View.GetRow(cboLoaiTaiSan.Properties.View.FocusedRowHandle)
            Value_info.ParameterValue = drDonVi.MaLoaitaisan
            Value_info.Ten = drDonVi.TenLoaitaisan
            lblTenLoaiTanSan.Text = drDonVi.TenLoaitaisan
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

End Class
