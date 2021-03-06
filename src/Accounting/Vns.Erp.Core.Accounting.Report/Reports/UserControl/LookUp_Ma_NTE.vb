Imports Vns.Erp.Core.Admin.Domain
Imports Vns.Erp.Core.Admin.Service.Interface
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Columns

Public Class LookUp_Ma_NTE
    Private _DmNgoaiteService As IDmNgoaiteService
    Public Property DmNgoaiteService As IDmNgoaiteService
        Get
            Return _DmNgoaiteService
        End Get
        Set(ByVal value As IDmNgoaiteService)
            _DmNgoaiteService = value
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
                Dim drpList As List(Of DmNgoaite) = New List(Of DmNgoaite)
                Dim drpListTEMP As New List(Of DmNgoaite)
                drpListTEMP.AddRange(_DmNgoaiteService.GetAll())

                Dim obj As DmNgoaite = New DmNgoaite
                obj.MaNte = Nothing
                obj.TenNte = "Không xác định"
                drpList.Add(obj)
                drpList.AddRange(drpListTEMP)
                cboDonVi.Properties.DataSource = drpList
                cboDonVi.Properties.ValueMember = "MaNte"
                cboDonVi.Properties.DisplayMember = "MaNte"
                If (Parameter_info.TenBien <> "") Then
                    LabelControl1.Text = Parameter_info.TenBien
                End If

                cboDonVi.EditValue = Nothing
                lblNte.Text = "Không xác định"
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
            Dim drDonVi As DmNgoaite = cboDonVi.Properties.View.GetRow(cboDonVi.Properties.View.FocusedRowHandle)
            If drDonVi Is Nothing Then
                Exit Sub
            End If
            Value_info.ParameterValue = drDonVi.MaNte
            Value_info.Ten = "Mã ngoại tệ : " & drDonVi.MaNte
            lblNte.Text = drDonVi.TenNte
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

End Class