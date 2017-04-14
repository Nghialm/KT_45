Imports Vns.Erp.Core.Admin.Domain
Imports Vns.Erp.Core.Admin.Service.Interface
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Base

Public Class LookUp_Hop_Dong
    Private _DmHopdongService As IDmHopdongService
    Public Property DmHopdongService As IDmHopdongService
        Get
            Return _DmHopdongService
        End Get
        Set(ByVal value As IDmHopdongService)
            _DmHopdongService = value
        End Set
    End Property
    Public Sub New(ByVal HT_bienbaoCao As HtBienBaocao)
        InitializeComponent()
        Parameter_info = HT_bienbaoCao
    End Sub

    Private Sub Lookup_Don_Vi_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            If Not Me.DesignMode Then
                Dim drpList As List(Of DmHopdong) = New List(Of DmHopdong)
                Dim drpListTEMP As New List(Of DmHopdong)
                drpListTEMP.AddRange(_DmHopdongService.GetAllByDonviID(Generals.DON_VI.Id))

                Dim obj As DmHopdong = New DmHopdong
                obj.TenHopdong = "Không xác định"
                obj.MaHopdong = ""
                drpList.Add(obj)
                drpList.AddRange(drpListTEMP)
                cboDonVi.Properties.DataSource = drpList
                cboDonVi.Properties.ValueMember = "Id"
                cboDonVi.Properties.DisplayMember = "MaHopdong"
                If (Parameter_info.TenBien <> "") Then
                    LabelControl1.Text = Parameter_info.TenBien
                End If
                cboDonVi.Properties.View.ActiveFilterString = Parameter_info.GiaTriBien
                cboDonVi.Properties.View.OptionsView.ShowFilterPanelMode = ShowFilterPanelMode.Never
                For Each gridCol As GridColumn In cboDonVi.Properties.View.Columns
                    gridCol.OptionsFilter.AllowFilter = False
                Next
                cboDonVi.EditValue = Nothing
                cboDonVi.Text = "Không xác định"
            End If
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub cboDonVi_EditValueChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboDonVi.EditValueChanged
        Try
            Dim drDonVi As DmHopdong = cboDonVi.Properties.View.GetRow(cboDonVi.Properties.View.FocusedRowHandle)
            Value_info.ParameterValue = drDonVi.Id
            Value_info.Ten = drDonVi.TenHopdong
            lbltendonvi.Text = drDonVi.TenHopdong
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

End Class
