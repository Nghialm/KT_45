Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Base
Imports Vns.Erp.Core.Admin.Domain
Imports Vns.Erp.Core.Admin.Service.Interface

Public Class LookUp_LoaiKHang
    Private _HtDanhmucService As IHtDanhmucService
    Public Property HtDanhmucService As IHtDanhmucService
        Get
            Return _HtDanhmucService
        End Get
        Set(ByVal value As IHtDanhmucService)
            _HtDanhmucService = value
        End Set
    End Property
    Public Sub New(ByVal htbienbaocao As HtBienBaocao)
        InitializeComponent()
        Parameter_info = htbienbaocao
        If (Parameter_info.TenBien <> "") Then
            lblNhomKhachHang.Text = Parameter_info.TenBien
        End If
    End Sub

    Private Sub LookUp_LoaiKHang_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            If Not Me.DesignMode Then
                Dim drpList As List(Of HtDanhmuc) = New List(Of HtDanhmuc)
                Dim drpListTEMP As New List(Of HtDanhmuc)
                drpListTEMP.AddRange(_HtDanhmucService.GetAll())

                Dim obj As HtDanhmuc = New HtDanhmuc
                obj.TenDanhmuc = "Không xác định"
                obj.Id = 0
                drpList.Add(obj)
                drpList.AddRange(drpListTEMP)
                cboLoaiKhachHang.Properties.DataSource = drpList
                cboLoaiKhachHang.Properties.ValueMember = "TenDanhmuc"
                cboLoaiKhachHang.Properties.DisplayMember = "Id"
                If (Parameter_info.TenBien <> "") Then
                    lblNhomKhachHang.Text = Parameter_info.TenBien
                End If
                cboLoaiKhachHang.Properties.View.ActiveFilterString = Parameter_info.GiaTriBien
                cboLoaiKhachHang.Properties.View.OptionsView.ShowFilterPanelMode = ShowFilterPanelMode.Never
                For Each gridCol As GridColumn In cboLoaiKhachHang.Properties.View.Columns
                    gridCol.OptionsFilter.AllowFilter = False
                Next
            End If
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub cboLoaiKhachHang_EditValueChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboLoaiKhachHang.EditValueChanged
        Try
            Dim drDonVi As HtDanhmuc = cboLoaiKhachHang.Properties.View.GetRow(cboLoaiKhachHang.Properties.View.FocusedRowHandle)
            Value_info.ParameterValue = drDonVi.Id
            Value_info.Ten = drDonVi.TenDanhmuc
            lblTenNhomKH.Text = drDonVi.TenDanhmuc
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

End Class
