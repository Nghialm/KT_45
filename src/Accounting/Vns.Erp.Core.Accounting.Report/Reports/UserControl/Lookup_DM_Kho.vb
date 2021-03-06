Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Columns
Imports Vns.Erp.Core.Admin.Domain
Imports Vns.Erp.Core.Admin.Service.Interface
Public Class Lookup_DM_Kho
    Private _DmKhoService As IDmKhoService
    Public Property DmKhoService As IDmKhoService
        Get
            Return _DmKhoService
        End Get
        Set(ByVal value As IDmKhoService)
            _DmKhoService = value
        End Set
    End Property
    Public Sub New(ByVal HT_bienbaoCao As HtBienBaocao)
        InitializeComponent()
        Parameter_info = HT_bienbaoCao
        If (Parameter_info.TenBien <> "") Then
            LabelControl1.Text = Parameter_info.TenBien
        End If
    End Sub

    Private Sub Lookup_Kho_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            If Not Me.DesignMode Then
                Dim drpList As List(Of DmKho) = New List(Of DmKho)
                Dim drpListTEMP As New List(Of DmKho)
                drpListTEMP.AddRange(_DmKhoService.GetAllByDonviID(Generals.DON_VI.Id))
                Dim obj As DmKho = New DmKho
                obj.MaKho = Nothing
                obj.TenKho = "Không xác định"
                obj.Id = Null.NullGuid
                drpList.Add(obj)
                drpList.AddRange(drpListTEMP)
                cboDonVi.Properties.DataSource = drpList
                cboDonVi.Properties.ValueMember = "Id"
                cboDonVi.Properties.DisplayMember = "KyHieu"
                If (Parameter_info.TenBien <> "") Then
                    LabelControl1.Text = Parameter_info.TenBien
                End If
                cboDonVi.EditValue = Nothing
                lblKho.Text = "Không xác định"
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

    Private Sub cboDonVi_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboDonVi.EditValueChanged
        Try
            Dim drDonVi As DmKho = cboDonVi.Properties.View.GetRow(cboDonVi.Properties.View.FocusedRowHandle)
            If drDonVi Is Nothing Then
                Exit Sub
            End If
            Value_info.ParameterValue = drDonVi.Id
            Value_info.Ten = drDonVi.TenKho
            lblKho.Text = drDonVi.TenKho
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

End Class
