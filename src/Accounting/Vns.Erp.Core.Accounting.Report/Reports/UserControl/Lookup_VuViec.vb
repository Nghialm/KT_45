Imports Vns.Erp.Core.Admin.Domain
Imports Vns.Erp.Core.Admin.Service.Interface
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Columns

Public Class Lookup_VuViec
    Private _DmVuviecService As IDmVuviecService
    Public Property DmVuviecService As IDmVuviecService
        Get
            Return _DmVuviecService
        End Get
        Set(ByVal value As IDmVuviecService)
            _DmVuviecService = value
        End Set
    End Property
    Public Sub New(ByVal HT_bienbaoCao As HtBienBaocao)
        InitializeComponent()
        Parameter_info = HT_bienbaoCao
        If (Parameter_info.TenBien <> "") Then
            LabelControl1.Text = Parameter_info.TenBien
        End If
    End Sub

    Private Sub Lookup_VuViec_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            If Not Me.DesignMode Then
                Dim drpList As List(Of DmVuviec) = New List(Of DmVuviec)
                Dim drpListTEMP As New List(Of DmVuviec)
                drpListTEMP.AddRange(_DmVuviecService.GetAllByDonviID(Generals.DON_VI.Id))

                Dim obj As DmVuviec = New DmVuviec
                obj.KyHieu = Nothing
                obj.TenVuviec = "Không xác định"
                drpList.Add(obj)
                drpList.AddRange(drpListTEMP)
                cboVuViec.Properties.DataSource = drpList
                cboVuViec.Properties.ValueMember = "Id"
                cboVuViec.Properties.DisplayMember = "KyHieu"
                If (Parameter_info.TenBien <> "") Then
                    LabelControl1.Text = Parameter_info.TenBien
                End If
                cboVuViec.Properties.View.ActiveFilterString = Parameter_info.GiaTriBien
                cboVuViec.Properties.View.OptionsView.ShowFilterPanelMode = ShowFilterPanelMode.Never
                For Each gridCol As GridColumn In cboVuViec.Properties.View.Columns
                    gridCol.OptionsFilter.AllowFilter = False
                Next

                cboVuViec.EditValue = Nothing
                lblVuViec.Text = "Không xác định"
            End If
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub cboVuViec_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboVuViec.EditValueChanged
        Try
            Dim drVuViec As DmVuviec = cboVuViec.Properties.View.GetRow(cboVuViec.Properties.View.FocusedRowHandle)
            Value_info.ParameterValue = drVuViec.Id
            Value_info.Ten = drVuViec.TenVuviec
            lblVuViec.Text = drVuViec.TenVuviec
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

End Class
