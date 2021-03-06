Imports Vns.Erp.Core.Admin.Domain
Imports Vns.Erp.Core.Admin.Service.Interface
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Columns

Public Class Lookup_HTLoaiChungTu
    Private _HtLoaichungtuService As IHtLoaichungtuService
    Public Property HtLoaichungtuService As IHtLoaichungtuService
        Get
            Return _HtLoaichungtuService
        End Get
        Set(ByVal value As IHtLoaichungtuService)
            _HtLoaichungtuService = value
        End Set
    End Property
    Public Sub New(ByVal HT_bienbaoCao As HtBienBaocao)
        InitializeComponent()
        Parameter_info = HT_bienbaoCao
        If (Parameter_info.TenBien <> "") Then
            LabelControl1.Text = Parameter_info.TenBien
        End If
    End Sub

    Private Sub Lookup_HTLoaiChungTu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            If Not Me.DesignMode Then
                Dim drpList As List(Of HtLoaichungtu) = New List(Of HtLoaichungtu)
                Dim drpListTEMP As New List(Of HtLoaichungtu)
                drpListTEMP.AddRange(_HtLoaichungtuService.GetAll())

                Dim obj As HtLoaichungtu = New HtLoaichungtu
                obj.MaLoaiCt = Nothing
                obj.TenLoaiCt = "Không xác định"
                drpList.Add(obj)
                drpList.AddRange(drpListTEMP)
                cboHTLoaiChungTu.Properties.DataSource = drpList
                cboHTLoaiChungTu.Properties.ValueMember = "Id"
                cboHTLoaiChungTu.Properties.DisplayMember = "MaLoaiCt"
                If (Parameter_info.TenBien <> "") Then
                    LabelControl1.Text = Parameter_info.TenBien
                End If
                cboHTLoaiChungTu.Properties.View.ActiveFilterString = Parameter_info.GiaTriBien
                cboHTLoaiChungTu.Properties.View.OptionsView.ShowFilterPanelMode = ShowFilterPanelMode.Never
                For Each gridCol As GridColumn In cboHTLoaiChungTu.Properties.View.Columns
                    gridCol.OptionsFilter.AllowFilter = False
                Next
                cboHTLoaiChungTu.EditValue = Nothing
                lblHTLoaiChungTu.Text = "Không xác định"
            End If
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub cboHTLoaiChungTu_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboHTLoaiChungTu.EditValueChanged
        Try
            Dim drHTLoaiChungTu As HtLoaichungtu = cboHTLoaiChungTu.Properties.View.GetRow(cboHTLoaiChungTu.Properties.View.FocusedRowHandle)
            Value_info.ParameterValue = drHTLoaiChungTu.MaLoaiCt
            Value_info.Ten = drHTLoaiChungTu.TenLoaiCt
            lblHTLoaiChungTu.Text = drHTLoaiChungTu.TenLoaiCt
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

End Class
