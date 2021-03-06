Imports Vns.Erp.Core.Admin.Domain
Imports Vns.Erp.Core.Admin.Service.Interface
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Columns

Public Class urc_TrangThai
    Private _KtStatusCtService As IKtStatusCtService
    Public Property KtStatusCtService As IKtStatusCtService
        Get
            Return _KtStatusCtService
        End Get
        Set(ByVal value As IKtStatusCtService)
            _KtStatusCtService = value
        End Set
    End Property
    Public Sub New(ByVal HT_bienbaoCao As HtBienBaocao)
        InitializeComponent()
        Parameter_info = HT_bienbaoCao
        If (Parameter_info.TenBien <> "") Then
            LabelControl1.Text = Parameter_info.TenBien
        End If
    End Sub

    Private Sub Lookup_Hang_Hoa_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            If Not Me.DesignMode Then
                Dim drpList As List(Of KtStatusCt) = New List(Of KtStatusCt)
                Dim drpListTEMP As New List(Of KtStatusCt)
                drpListTEMP.AddRange(_KtStatusCtService.GetAll())

                Dim obj As KtStatusCt = New KtStatusCt
                obj.Id = Null.NullDecimal
                obj.Ten = "Không xác định"
                drpList.Add(obj)
                drpList.AddRange(drpListTEMP)
                cboDonVi.Properties.DataSource = drpList
                cboDonVi.Properties.ValueMember = "Id"
                cboDonVi.Properties.DisplayMember = "Ten"
                If (Parameter_info.TenBien <> "") Then
                    LabelControl1.Text = Parameter_info.TenBien
                End If
                cboDonVi.Properties.View.ActiveFilterString = Parameter_info.GiaTriBien
                cboDonVi.Properties.View.OptionsView.ShowFilterPanelMode = ShowFilterPanelMode.Never
                For Each gridCol As GridColumn In cboDonVi.Properties.View.Columns
                    gridCol.OptionsFilter.AllowFilter = False
                Next
                cboDonVi.EditValue = Null.NullDecimal
                'lblKho.Text = "Không xác định"
            End If
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub cboDonVi_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboDonVi.EditValueChanged
        Try
            Dim drDonVi As KtStatusCt = cboDonVi.Properties.View.GetRow(cboDonVi.Properties.View.FocusedRowHandle)
            Value_info.ParameterValue = drDonVi.Id
            Value_info.Ten = drDonVi.Ten
            'lblKho.Text = drDonVi.TEN
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

End Class
