Imports DevExpress.XtraGrid.Views.Base
Imports Vns.Erp.Core.Admin.Domain
Imports Vns.Erp.Core.Admin.Service.Interface

Public Class LookUp_Group_Name_Kho

    Public Sub New()
        InitializeComponent()
    End Sub

    Public Sub New(ByVal HT_bienbaoCao As HtBienBaocao)
        InitializeComponent()
        Parameter_info = HT_bienbaoCao
        If (Parameter_info.TenBien <> "") Then
            LabelControl1.Text = Parameter_info.TenBien
        End If
    End Sub

    Private Sub LookUp_Group_Name_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            BindData()
            TNCommon.SelectFirst(cboGroup)
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub BindData()
        Dim listGroup As New List(Of GroupReportInfo)

        listGroup.Add(New GroupReportInfo("Vụ việc", "VUVIEC"))
        listGroup.Add(New GroupReportInfo("Hợp đồng", "HOPDONG"))
        listGroup.Add(New GroupReportInfo("Khách hàng", "KHANG"))
        listGroup.Add(New GroupReportInfo("Kho", "KHO"))
        listGroup.Add(New GroupReportInfo("Hàng hóa", "HANGHOA"))

        cboGroup.Properties.DataSource = listGroup
        cboGroup.Properties.DisplayMember = "GROUP_NAME"
        cboGroup.Properties.ValueMember = "GROUP_VALUE"

        cboGroup.Properties.View.ActiveFilterString = Parameter_info.GiaTriBien
        cboGroup.Properties.View.OptionsView.ShowFilterPanelMode = ShowFilterPanelMode.Never
    End Sub

    Class GroupReportInfo

        Private _GROUP_NAME As String

        Public Property GROUP_NAME() As String
            Get
                Return _GROUP_NAME
            End Get
            Set(ByVal value As String)
                _GROUP_NAME = value
            End Set
        End Property

        Private _GROUP_VALUE As String

        Public Property GROUP_VALUE() As String
            Get
                Return _GROUP_VALUE
            End Get
            Set(ByVal value As String)
                _GROUP_VALUE = value
            End Set
        End Property

        Public Sub New()
        End Sub

        Public Sub New(ByVal GROUP_NAME As String, ByVal GROUP_VALUE As String)
            Me.GROUP_NAME = GROUP_NAME
            Me.GROUP_VALUE = GROUP_VALUE
        End Sub
    End Class

    Private Sub cboGroup_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboGroup.EditValueChanged
        Try
            Value_info.ParameterValue = cboGroup.EditValue
        Catch ex As Exception
            Value_info.ParameterValue = String.Empty
            Message_Error(ex)
        End Try
    End Sub

End Class
