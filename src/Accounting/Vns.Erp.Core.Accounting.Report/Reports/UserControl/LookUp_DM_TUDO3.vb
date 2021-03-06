Imports Vns.Erp.Core.Admin.Domain
Imports Vns.Erp.Core.Admin.Service.Interface
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Columns

Public Class LookUp_DM_TUDO3
    Private _DmTudo3Service As IDmTudo3Service
    Public Property DmTudo3Service As IDmTudo3Service
        Get
            Return _DmTudo3Service
        End Get
        Set(ByVal value As IDmTudo3Service)
            _DmTudo3Service = value
        End Set
    End Property
    Public Sub New(ByVal HT_bienbaoCao As HtBienBaocao)
        InitializeComponent()
        Parameter_info = HT_bienbaoCao
        If (Parameter_info.TenBien <> "") Then
            LabelControl1.Text = Parameter_info.TenBien
        End If
    End Sub

    Private Sub LookUp_DM_TUDO3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            If Not Me.DesignMode Then
                Dim drpList As List(Of DmTudo3) = New List(Of DmTudo3)
                Dim drpListTEMP As New List(Of DmTudo3)
                drpListTEMP.AddRange(_DmTudo3Service.GetAllByDonviID(Generals.DON_VI.Id))

                Dim obj As DmTudo3 = New DmTudo3
                obj.KyHieu = Nothing
                obj.TenDmTudo3 = "Không xác định"
                drpList.Add(obj)
                drpList.AddRange(drpListTEMP)
                cboDMTudo3.Properties.DataSource = drpList
                cboDMTudo3.Properties.ValueMember = "Id"
                cboDMTudo3.Properties.DisplayMember = "KyHieu"
                If (Parameter_info.TenBien <> "") Then
                    LabelControl1.Text = Parameter_info.TenBien
                End If
                cboDMTudo3.Properties.View.ActiveFilterString = Parameter_info.GiaTriBien
                cboDMTudo3.Properties.View.OptionsView.ShowFilterPanelMode = ShowFilterPanelMode.Never
                For Each gridCol As GridColumn In cboDMTudo3.Properties.View.Columns
                    gridCol.OptionsFilter.AllowFilter = False
                Next

                cboDMTudo3.EditValue = Nothing
                lblVuViec.Text = "Không xác định"
            End If
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub cboDMTudo_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboDMTudo3.EditValueChanged
        Try
            Dim drDMTudo As DmTudo3 = cboDMTudo3.Properties.View.GetRow(cboDMTudo3.Properties.View.FocusedRowHandle)
            Value_info.ParameterValue = drDMTudo.Id
            Value_info.Ten = drDMTudo.TenDmTudo3
            lblVuViec.Text = drDMTudo.TenDmTudo3
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

End Class
