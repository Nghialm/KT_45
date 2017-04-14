Imports Vns.Erp.Core.Asset.Domain
Imports Vns.Erp.Core.Asset.Service.Interface

Imports Vns.Erp.Core.Admin.Domain
Imports Vns.Erp.Core.Admin.Service.Interface

Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Base

Public Class LookUp_NhomTS
    Private _DmNhomTscdService As IDmNhomTscdService
    Public Property DmNhomTscdService As IDmNhomTscdService
        Get
            Return _DmNhomTscdService
        End Get
        Set(ByVal value As IDmNhomTscdService)
            _DmNhomTscdService = value
        End Set
    End Property
    Public Sub New(ByVal HT_bienbaoCao As HtBienBaocao)
        InitializeComponent()
        Parameter_info = HT_bienbaoCao
    End Sub

    Private Sub LookUp_Nhom_Vat_Tu_1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            If Not Me.DesignMode Then
                Dim drpList As List(Of DmNhomTscd) = New List(Of DmNhomTscd)
                Dim drpListTEMP As New List(Of DmNhomTscd)
                drpListTEMP.AddRange(_DmNhomTscdService.GetAllByDonviID(Generals.DON_VI.Id))

                Dim obj As DmNhomTscd
                obj = New DmNhomTscd
                obj.TenNhomTscd = "Không xác định"
                obj.LoaiNhom = 0
                obj.MaNhomTscd = Nothing
                drpList.Add(obj)
                drpList.AddRange(drpListTEMP)

                cboNhomTS.Properties.DataSource = drpList
                cboNhomTS.Properties.ValueMember = "Id"
                cboNhomTS.Properties.DisplayMember = "MaNhomTscd"
                If (Parameter_info.TenBien <> "") Then
                    LabelControl1.Text = Parameter_info.TenBien
                End If
                cboNhomTS.Properties.View.ActiveFilterString = Parameter_info.GiaTriBien
                cboNhomTS.Properties.View.OptionsView.ShowFilterPanelMode = ShowFilterPanelMode.Never
                For Each gridCol As GridColumn In cboNhomTS.Properties.View.Columns
                    gridCol.OptionsFilter.AllowFilter = False
                Next

                lbltendonvi.Text = "Không xác định"
            End If
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub cboDonVi_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Dim obj As DmNhomTscd = CType(cboNhomTS.EditValue, DmNhomTscd)
            Value_info.ParameterValue = obj.Id
            lbltendonvi.Text = obj.TenNhomTscd
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub cboDonVi_EditValueChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboNhomTS.EditValueChanged
        Try
            Dim drDonVi As DmNhomTscd = cboNhomTS.Properties.View.GetRow(cboNhomTS.Properties.View.FocusedRowHandle)
            Value_info.ParameterValue = drDonVi.Id
            Value_info.Ten = drDonVi.TenNhomTscd
            lbltendonvi.Text = drDonVi.TenNhomTscd
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

End Class
