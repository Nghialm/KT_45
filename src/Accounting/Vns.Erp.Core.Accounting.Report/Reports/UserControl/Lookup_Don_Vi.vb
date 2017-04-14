Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Base
Imports Vns.Erp.Core.Admin.Domain
Imports Vns.Erp.Core.Admin.Service.Interface
Public Class Lookup_Don_Vi
    Private _DmDonviService As IDmDonviService
    Public Property DmDonviService As IDmDonviService
        Get
            Return _DmDonviService
        End Get
        Set(ByVal value As IDmDonviService)
            _DmDonviService = value
        End Set
    End Property
    Public Sub New(ByVal HT_bienbaoCao As HtBienBaocao)
        InitializeComponent()
        Parameter_info = HT_bienbaoCao
    End Sub

    Dim drpList As List(Of DmDonvi) = New List(Of DmDonvi)()

    Private Sub Lookup_Don_Vi_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            If Not Me.DesignMode Then
                Dim drpList As New List(Of DmDonvi)
                drpList.Add(_DmDonviService.GetById(Generals.DON_VI.Id))

                cboDonVi.Properties.DataSource = drpList
                cboDonVi.Properties.ValueMember = "Id"
                cboDonVi.Properties.DisplayMember = "KyHieu"
                If drpList.Count > 0 Then
                    cboDonVi.EditValue = drpList.Item(0).Id
                End If

                If (Parameter_info.TenBien <> "") Then
                    LabelControl1.Text = Parameter_info.TenBien
                End If

                cboDonVi.Properties.View.ActiveFilterString = Parameter_info.GiaTriBien
                cboDonVi.Properties.View.OptionsView.ShowFilterPanelMode = ShowFilterPanelMode.Never
                For Each gridCol As GridColumn In cboDonVi.Properties.View.Columns
                    gridCol.OptionsFilter.AllowFilter = False
                Next
            End If
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub cboDonVi_EditValueChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboDonVi.EditValueChanged
        Try
            Dim drDonVi As DmDonvi = CType(ComboHelper.GetSelectData(cboDonVi), DmDonvi)
            Value_info.ParameterValue = drDonVi.Id
            Value_info.Ten = drDonVi.TenDonvi
            lbltendonvi.Text = drDonVi.TenDonvi
        Catch ex As Exception
            lbltendonvi.Text = String.Empty
            Message_Error(ex)
        End Try
    End Sub

End Class
