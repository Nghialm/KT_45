Imports Vns.Erp.Core.Admin.Domain
Imports Vns.Erp.Core.Admin.Service.Interface
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Columns

Public Class LookUp_DM_TUDO1
    Private _DmTudo1Service As IDmTudo1Service
    Public Property DmTudo1Service As IDmTudo1Service
        Get
            Return _DmTudo1Service
        End Get
        Set(ByVal value As IDmTudo1Service)
            _DmTudo1Service = value
        End Set
    End Property
    Public Sub New(ByVal HT_bienbaoCao As HtBienBaocao)
        InitializeComponent()
        Parameter_info = HT_bienbaoCao
        If (Parameter_info.TenBien <> "") Then
            LabelControl1.Text = Parameter_info.TenBien
        End If
    End Sub

    Private Sub LookUp_DM_TUDO1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            If Not Me.DesignMode Then
                Dim drpList As List(Of DmTudo1) = New List(Of DmTudo1)
                Dim drpListTEMP As New List(Of DmTudo1)
                drpListTEMP.AddRange(_DmTudo1Service.GetAllByDonviID(Generals.DON_VI.Id))

                Dim obj As DmTudo1 = New DmTudo1
                obj.KyHieu = Nothing
                obj.TenDmTudo1 = "Không xác định"
                drpList.Add(obj)
                drpList.AddRange(drpListTEMP)
                cboDMTudo1.Properties.DataSource = drpList
                cboDMTudo1.Properties.ValueMember = "Id"
                cboDMTudo1.Properties.DisplayMember = "KyHieu"
                If (Parameter_info.TenBien <> "") Then
                    LabelControl1.Text = Parameter_info.TenBien
                End If
                cboDMTudo1.Properties.View.ActiveFilterString = Parameter_info.GiaTriBien
                cboDMTudo1.Properties.View.OptionsView.ShowFilterPanelMode = ShowFilterPanelMode.Never
                For Each gridCol As GridColumn In cboDMTudo1.Properties.View.Columns
                    gridCol.OptionsFilter.AllowFilter = False
                Next

                cboDMTudo1.EditValue = Nothing
                lblVuViec.Text = "Không xác định"
            End If
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub cboDMTudo_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboDMTudo1.EditValueChanged
        Try
            Dim drDMTudo As DmTudo1 = cboDMTudo1.Properties.View.GetRow(cboDMTudo1.Properties.View.FocusedRowHandle)
            Value_info.ParameterValue = drDMTudo.Id
            Value_info.Ten = drDMTudo.TenDmTudo1
            lblVuViec.Text = drDMTudo.TenDmTudo1
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

End Class
