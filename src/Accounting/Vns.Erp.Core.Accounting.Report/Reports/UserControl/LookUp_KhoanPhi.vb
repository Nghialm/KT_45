Imports Vns.Erp.Core.Admin.Domain
Imports Vns.Erp.Core.Admin.Service.Interface
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Columns

Public Class LookUp_KhoanPhi
    Private _DmKhoanphiService As IDmKhoanphiService
    Public Property DmKhoanphiService As IDmKhoanphiService
        Get
            Return _DmKhoanphiService
        End Get
        Set(ByVal value As IDmKhoanphiService)
            _DmKhoanphiService = value
        End Set
    End Property
    Public Sub New(ByVal HT_bienbaoCao As HtBienBaocao)
        InitializeComponent()
        Parameter_info = HT_bienbaoCao
        If (Parameter_info.TenBien <> "") Then
            LabelControl1.Text = Parameter_info.TenBien
        End If
    End Sub

    Private Sub LookUp_KhoanPhi_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            If Not Me.DesignMode Then
                Dim drpList As List(Of DmKhoanphi) = New List(Of DmKhoanphi)
                Dim drpListTEMP As New List(Of DmKhoanphi)
                drpListTEMP.AddRange(_DmKhoanphiService.GetAllByDonviID(Generals.DON_VI.Id))

                Dim obj As DmKhoanphi = New DmKhoanphi
                obj.KyHieu = Nothing
                obj.TenDmKhoanphi = "Không xác định"
                drpList.Add(obj)
                drpList.AddRange(drpListTEMP)
                cboKhoanPhi.Properties.DataSource = drpList
                cboKhoanPhi.Properties.ValueMember = "Id"
                cboKhoanPhi.Properties.DisplayMember = "KyHieu"
                If (Parameter_info.TenBien <> "") Then
                    LabelControl1.Text = Parameter_info.TenBien
                End If
                cboKhoanPhi.Properties.View.ActiveFilterString = Parameter_info.GiaTriBien
                cboKhoanPhi.Properties.View.OptionsView.ShowFilterPanelMode = ShowFilterPanelMode.Never
                For Each gridCol As GridColumn In cboKhoanPhi.Properties.View.Columns
                    gridCol.OptionsFilter.AllowFilter = False
                Next

                cboKhoanPhi.EditValue = Nothing
                lblVuViec.Text = "Không xác định"
            End If
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub cboKhoanPhi_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboKhoanPhi.EditValueChanged
        Try
            Dim drKhoanPhi As DmKhoanphi = cboKhoanPhi.Properties.View.GetRow(cboKhoanPhi.Properties.View.FocusedRowHandle)
            Value_info.ParameterValue = drKhoanPhi.Id
            Value_info.Ten = drKhoanPhi.TenDmKhoanphi
            lblVuViec.Text = drKhoanPhi.TenDmKhoanphi
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

End Class
