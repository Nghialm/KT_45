Imports Vns.Erp.Core.Admin.Domain
Imports Vns.Erp.Core.Admin.Service.Interface
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Base

Public Class LookUp_Nhom_Vat_Tu_1
    Private _DmNhomvattu1Service As IDmNhomvattu1Service
    Public Property DmNhomvattu1Service As IDmNhomvattu1Service
        Get
            Return _DmNhomvattu1Service
        End Get
        Set(ByVal value As IDmNhomvattu1Service)
            _DmNhomvattu1Service = value
        End Set
    End Property
    Public Sub New(ByVal HT_bienbaoCao As HtBienBaocao)
        InitializeComponent()
        Parameter_info = HT_bienbaoCao
    End Sub

    Private Sub LookUp_Nhom_Vat_Tu_1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            If Not Me.DesignMode Then
                Dim drpList As List(Of DmNhomvattu1) = New List(Of DmNhomvattu1)
                Dim drpListTEMP As New List(Of DmNhomvattu1)
                drpListTEMP.AddRange(_DmNhomvattu1Service.GetObjectAllByDonviID(Generals.DON_VI.Id))

                Dim obj As DmNhomvattu1 = New DmNhomvattu1
                obj.TenNhomVt1 = "Không xác định"
                obj.MaNhomVt1 = Nothing
                drpList.Add(obj)
                drpList.AddRange(drpListTEMP)

                cboDonVi.Properties.DataSource = drpList
                cboDonVi.Properties.ValueMember = "TenNhomVt1"
                cboDonVi.Properties.DisplayMember = "MaNhomVt1"
                If (Parameter_info.TenBien <> "") Then
                    LabelControl1.Text = Parameter_info.TenBien
                End If
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

    Private Sub cboDonVi_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Dim obj As DmNhomvattu1 = CType(cboDonVi.EditValue, DmNhomvattu1)
            Value_info.ParameterValue = obj.MaNhomVt1
            lbltendonvi.Text = obj.TenNhomVt1
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub cboDonVi_EditValueChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboDonVi.EditValueChanged
        Try
            Dim drDonVi As DmNhomvattu1 = cboDonVi.Properties.View.GetRow(cboDonVi.Properties.View.FocusedRowHandle)
            Value_info.ParameterValue = drDonVi.MaNhomVt1
            Value_info.Ten = drDonVi.TenNhomVt1
            lbltendonvi.Text = drDonVi.TenNhomVt1
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

End Class
