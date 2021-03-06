Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Columns
Imports Vns.Erp.Core.Admin.Domain
Imports Vns.Erp.Core.Admin.Service.Interface

Public Class Lookup_DM_Nhom_KH
    Private _DmNhomKhangService As IDmNhomKhangService
    Public Property DmNhomKhangService As IDmNhomKhangService
        Get
            Return _DmNhomKhangService
        End Get
        Set(ByVal value As IDmNhomKhangService)
            _DmNhomKhangService = value
        End Set
    End Property

    Public Sub New(ByVal HT_bienbaoCao As HtBienBaocao)
        InitializeComponent()
        Parameter_info = HT_bienbaoCao
        If (Parameter_info.TenBien <> "") Then
            LabelControl1.Text = Parameter_info.TenBien
        End If
    End Sub

    Private Sub Lookup_DM_Nhom_KH_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            If Not Me.DesignMode Then
                Dim drpList As List(Of DmNhomKhang) = New List(Of DmNhomKhang)
                Dim drpListTEMP As New List(Of DmNhomKhang)
                drpListTEMP.AddRange(_DmNhomKhangService.GetObjectAllByDonviID(Generals.DON_VI.Id))

                Dim obj As DmNhomKhang = New DmNhomKhang
                obj.Id = Nothing
                obj.TenNhomKhang = "Không xác định"
                drpList.Add(obj)
                drpList.AddRange(drpListTEMP)
                cboDonVi.Properties.DataSource = drpList
                cboDonVi.Properties.ValueMember = "Id"
                cboDonVi.Properties.DisplayMember = "MaNhomKhang"
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

    Private Sub cboDonVi_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboDonVi.EditValueChanged
        Try
            Dim drDonVi As DmNhomKhang = cboDonVi.Properties.View.GetRow(cboDonVi.Properties.View.FocusedRowHandle)
            Value_info.ParameterValue = drDonVi.Id
            Value_info.Ten = drDonVi.TenNhomKhang
            lblKho.Text = drDonVi.TenNhomKhang
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

End Class
