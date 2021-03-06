Imports Vns.Erp.Core.Admin.Domain
Imports Vns.Erp.Core.Admin.Service.Interface
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Columns

Public Class LookUp_DM_TUDO2

    Private _DmTudo2Service As IDmTudo2Service
    Public Property DmTudo2Service As IDmTudo2Service
        Get
            Return _DmTudo2Service
        End Get
        Set(ByVal value As IDmTudo2Service)
            _DmTudo2Service = value
        End Set
    End Property
    Public Sub New(ByVal HT_bienbaoCao As HtBienBaocao)
        InitializeComponent()
        Parameter_info = HT_bienbaoCao
        If (Parameter_info.TenBien <> "") Then
            LabelControl1.Text = Parameter_info.TenBien
        End If
    End Sub

    Private Sub LookUp_DM_TUDO2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            If Not Me.DesignMode Then
                Dim drpList As List(Of DmTudo2) = New List(Of DmTudo2)
                Dim drpListTEMP As New List(Of DmTudo2)
                drpListTEMP.AddRange(_DmTudo2Service.GetAllByDonviID(Generals.DON_VI.Id))

                Dim obj As DmTudo2 = New DmTudo2
                obj.KyHieu = Nothing
                obj.TenDmTudo2 = "Không xác định"
                drpList.Add(obj)
                drpList.AddRange(drpListTEMP)
                cboDMTudo2.Properties.DataSource = drpList
                cboDMTudo2.Properties.ValueMember = "Id"
                cboDMTudo2.Properties.DisplayMember = "KyHieu"
                If (Parameter_info.TenBien <> "") Then
                    LabelControl1.Text = Parameter_info.TenBien
                End If
                cboDMTudo2.Properties.View.ActiveFilterString = Parameter_info.GiaTriBien
                cboDMTudo2.Properties.View.OptionsView.ShowFilterPanelMode = ShowFilterPanelMode.Never
                For Each gridCol As GridColumn In cboDMTudo2.Properties.View.Columns
                    gridCol.OptionsFilter.AllowFilter = False
                Next

                cboDMTudo2.EditValue = Nothing
                lblVuViec.Text = "Không xác định"
            End If
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub cboDMTudo_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboDMTudo2.EditValueChanged
        Try
            Dim drDMTudo As DmTudo2 = cboDMTudo2.Properties.View.GetRow(cboDMTudo2.Properties.View.FocusedRowHandle)
            Value_info.ParameterValue = drDMTudo.Id
            Value_info.Ten = drDMTudo.TenDmTudo2
            lblVuViec.Text = drDMTudo.TenDmTudo2
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

End Class
