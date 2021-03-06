Imports Vns.Erp.Core.Admin.Domain
Imports Vns.Erp.Core.Admin.Service.Interface
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Columns

Public Class LookUp_DM_TUDO5
    Private _DmTudo5Service As IDmTudo5Service
    Public Property DmTudo5Service As IDmTudo5Service
        Get
            Return _DmTudo5Service
        End Get
        Set(ByVal value As IDmTudo5Service)
            _DmTudo5Service = value
        End Set
    End Property
    Public Sub New(ByVal HT_bienbaoCao As HtBienBaocao)
        InitializeComponent()
        Parameter_info = HT_bienbaoCao
        If (Parameter_info.TenBien <> "") Then
            LabelControl1.Text = Parameter_info.TenBien
        End If
    End Sub

    Private Sub LookUp_DM_TUDO5_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            If Not Me.DesignMode Then
                Dim drpList As List(Of DmTudo5) = New List(Of DmTudo5)
                Dim drpListTEMP As New List(Of DmTudo5)
                drpListTEMP.AddRange(_DmTudo5Service.GetAllByDonviID(Generals.DON_VI.Id))

                Dim obj As DmTudo5 = New DmTudo5
                obj.KyHieu = Nothing
                obj.TenDmTudo5 = "Không xác định"
                drpList.Add(obj)
                drpList.AddRange(drpListTEMP)
                cboDMTudo5.Properties.DataSource = drpList
                cboDMTudo5.Properties.ValueMember = "Id"
                cboDMTudo5.Properties.DisplayMember = "KyHieu"
                If (Parameter_info.TenBien <> "") Then
                    LabelControl1.Text = Parameter_info.TenBien
                End If
                cboDMTudo5.Properties.View.ActiveFilterString = Parameter_info.GiaTriBien
                cboDMTudo5.Properties.View.OptionsView.ShowFilterPanelMode = ShowFilterPanelMode.Never
                For Each gridCol As GridColumn In cboDMTudo5.Properties.View.Columns
                    gridCol.OptionsFilter.AllowFilter = False
                Next

                cboDMTudo5.EditValue = Nothing
                lblVuViec.Text = "Không xác định"
            End If
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub cboDMTudo_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboDMTudo5.EditValueChanged
        Try
            Dim drDMTudo As DmTudo5 = cboDMTudo5.Properties.View.GetRow(cboDMTudo5.Properties.View.FocusedRowHandle)
            Value_info.ParameterValue = drDMTudo.Id
            Value_info.Ten = drDMTudo.TenDmTudo5
            lblVuViec.Text = drDMTudo.TenDmTudo5
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

End Class
