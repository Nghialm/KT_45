Imports Vns.Erp.Core.Admin.Domain
Imports Vns.Erp.Core.Admin.Service.Interface
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Columns

Public Class LookUp_DM_TUDO4
    Private _DmTudo4Service As IDmTudo4Service
    Public Property DmTudo4Service As IDmTudo4Service
        Get
            Return _DmTudo4Service
        End Get
        Set(ByVal value As IDmTudo4Service)
            _DmTudo4Service = value
        End Set
    End Property
    Public Sub New(ByVal HT_bienbaoCao As HtBienBaocao)
        InitializeComponent()
        Parameter_info = HT_bienbaoCao
        If (Parameter_info.TenBien <> "") Then
            LabelControl1.Text = Parameter_info.TenBien
        End If
    End Sub

    Private Sub LookUp_DM_TUDO4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            If Not Me.DesignMode Then
                Dim drpList As List(Of DmTudo4) = New List(Of DmTudo4)
                Dim drpListTEMP As New List(Of DmTudo4)
                drpListTEMP.AddRange(_DmTudo4Service.GetAllByDonviID(Generals.DON_VI.Id))

                Dim obj As DmTudo4 = New DmTudo4
                obj.KyHieu = Nothing
                obj.TenDmTudo4 = "Không xác định"
                drpList.Add(obj)
                drpList.AddRange(drpListTEMP)
                cboDMTudo4.Properties.DataSource = drpList
                cboDMTudo4.Properties.ValueMember = "Id"
                cboDMTudo4.Properties.DisplayMember = "KyHieu"
                If (Parameter_info.TenBien <> "") Then
                    LabelControl1.Text = Parameter_info.TenBien
                End If
                cboDMTudo4.Properties.View.ActiveFilterString = Parameter_info.GiaTriBien
                cboDMTudo4.Properties.View.OptionsView.ShowFilterPanelMode = ShowFilterPanelMode.Never
                For Each gridCol As GridColumn In cboDMTudo4.Properties.View.Columns
                    gridCol.OptionsFilter.AllowFilter = False
                Next

                cboDMTudo4.EditValue = Nothing
                lblVuViec.Text = "Không xác định"
            End If
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub cboDMTudo_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboDMTudo4.EditValueChanged
        Try
            Dim drDMTudo As DmTudo4 = cboDMTudo4.Properties.View.GetRow(cboDMTudo4.Properties.View.FocusedRowHandle)
            Value_info.ParameterValue = drDMTudo.Id
            Value_info.Ten = drDMTudo.TenDmTudo4
            lblVuViec.Text = drDMTudo.TenDmTudo4
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

End Class
