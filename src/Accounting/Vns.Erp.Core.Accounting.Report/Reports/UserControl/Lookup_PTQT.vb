Imports Vns.Erp.Core.Admin.Domain
Imports Vns.Erp.Core.Admin.Service.Interface
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Columns

Public Class Lookup_PTQT
    Private _DmPtqtService As IDmPtqtService
    Public Property DmPtqtService As IDmPtqtService
        Get
            Return _DmPtqtService
        End Get
        Set(ByVal value As IDmPtqtService)
            _DmPtqtService = value
        End Set
    End Property
    Public Sub New(ByVal HT_bienbaoCao As HtBienBaocao)
        InitializeComponent()
        Parameter_info = HT_bienbaoCao
        If (Parameter_info.TenBien <> "") Then
            LabelControl1.Text = Parameter_info.TenBien
        End If
    End Sub

    Private Sub Lookup_PTQT_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            If Not Me.DesignMode Then
                Dim drpList As List(Of DmPtqt) = New List(Of DmPtqt)
                Dim drpListTEMP As New List(Of DmPtqt)
                drpListTEMP.AddRange(_DmPtqtService.GetAllByDonviID(Generals.DON_VI.Id))

                Dim obj As DmPtqt = New DmPtqt
                obj.KyHieu = Nothing
                obj.TenPtqt = "Không xác định"
                drpList.Add(obj)
                drpList.AddRange(drpListTEMP)
                cboPTQT.Properties.DataSource = drpList
                cboPTQT.Properties.ValueMember = "Id"
                cboPTQT.Properties.DisplayMember = "KyHieu"
                If (Parameter_info.TenBien <> "") Then
                    LabelControl1.Text = Parameter_info.TenBien
                End If
                cboPTQT.Properties.View.ActiveFilterString = Parameter_info.GiaTriBien
                cboPTQT.Properties.View.OptionsView.ShowFilterPanelMode = ShowFilterPanelMode.Never
                For Each gridCol As GridColumn In cboPTQT.Properties.View.Columns
                    gridCol.OptionsFilter.AllowFilter = False
                Next

                cboPTQT.EditValue = Nothing
                lblVuViec.Text = "Không xác định"
            End If
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub cboPTQT_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboPTQT.EditValueChanged
        Try
            Dim drPTQT As DmPtqt = cboPTQT.Properties.View.GetRow(cboPTQT.Properties.View.FocusedRowHandle)
            Value_info.ParameterValue = drPTQT.Id
            Value_info.Ten = drPTQT.TenPtqt
            lblVuViec.Text = drPTQT.TenPtqt
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

End Class
