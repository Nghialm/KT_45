#Region "Import detectives"

Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports DevExpress.XtraReports.UI

Imports Vns.Erp.Core.Admin.Domain
Imports Vns.Erp.Core.Admin.Service.Interface
#End Region

Partial Public Class ReportPreview
    Inherits DevExpress.XtraEditors.XtraForm

#Region "Property"
    Private _HtThamsoService As IHtThamsoService
    Public Property HtThamsoService As IHtThamsoService
        Get
            Return _HtThamsoService
        End Get
        Set(ByVal value As IHtThamsoService)
            _HtThamsoService = value
        End Set
    End Property
#End Region

#Region "Variable"
    'Bien bao cao
    Private report As New rptMain()
    'Du lieu bao cao
    Private dtReport As New DataTable()
    'Duong dan template
    Private dir_template As String

    'Danh sach parameter dc truyen vao form
    Private list_parameter As List(Of DevExpress.XtraReports.Parameters.Parameter)

    'Danh sach parameter convert tu bien bao cao
    Private lstBienPara As List(Of DevExpress.XtraReports.Parameters.Parameter)
#End Region

#Region "Function"

    Public Sub New()
        InitializeComponent()
    End Sub

    Public Sub New(ByVal rpt As rptMain)
        InitializeComponent()
        Me.report = rpt
    End Sub

    Public Sub New(ByVal data As DataTable, ByVal dir_tem As String)
        InitializeComponent()
        Me.dtReport = data
        Me.dir_template = dir_tem
        Me.report.DataSource = data
        Me.list_parameter = New List(Of DevExpress.XtraReports.Parameters.Parameter)
        Me.lstBienPara = New List(Of DevExpress.XtraReports.Parameters.Parameter)
        Try
            Me.report.LoadLayout(dir_tem)
        Catch generatedExceptionName As Exception
            Message_Information("Không có mẫu báo cáo cho bảng này!")
            Return
        End Try
    End Sub

    Public Sub New(ByVal data As DataTable, ByVal dir_tem As String, ByVal exPara As List(Of DevExpress.XtraReports.Parameters.Parameter))
        InitializeComponent()
        Me.dtReport = data
        Me.dir_template = dir_tem
        Me.report.DataSource = data
        Me.list_parameter = New List(Of DevExpress.XtraReports.Parameters.Parameter)
        Me.lstBienPara = New List(Of DevExpress.XtraReports.Parameters.Parameter)
        Me.lstBienPara = exPara
        Try
            Me.report.LoadLayout(dir_tem)
        Catch generatedExceptionName As Exception
            Message_Information("Không tìm thấy file mẫu báo cáo!")
            Return
        End Try
    End Sub

    Private Sub callPreview()
        'Bind paramter tu form he thong vao report
        Dim repc = report.Parameters.Count

        If Me.list_parameter.Count > 0 Then
            'Edit template da co parameter

            'Check danh sach bien bao cao
            If Me.lstBienPara.Count > 0 Then
                For Each item As DevExpress.XtraReports.Parameters.Parameter In Me.lstBienPara
                    Me.list_parameter.Add(item)
                Next
            End If

            For Each param As DevExpress.XtraReports.Parameters.Parameter In Me.list_parameter
                Select Case param.Name
                    Case "p_DonVi"
                        param.Value = Generals.DON_VI.TenDonvi
                    Case "p_DiaChiCongTy"
                        param.Value = Generals.DON_VI.DiaChi
                    Case "p_FooterReport"
                        param.Value = Generals.DON_VI.TenDonvi + " - " + Generals.DON_VI.DiaChi
                End Select
            Next

            For Each item In Me.list_parameter
                For i = 0 To repc - 1
                    If (String.Compare(item.Name.ToString().ToLower(), report.Parameters(i).Name.ToLower()) = 0) Then
                        report.Parameters(i).Value = item.Value
                        report.Parameters(i).Description = item.Description
                        report.Parameters(i).Visible = False
                    End If
                Next
            Next
        Else
            'Edit template moi tinh chua co paramter
            Me.list_parameter = CommonClass.ConvertThamSoToParameter(_HtThamsoService.GetByDonviId(Generals.DON_VI.Id))

            'Check danh sach bien bao cao
            If Me.lstBienPara.Count > 0 Then
                For Each item As DevExpress.XtraReports.Parameters.Parameter In Me.lstBienPara
                    Me.list_parameter.Add(item)
                Next
            End If

            For Each param As DevExpress.XtraReports.Parameters.Parameter In Me.list_parameter
                Select Case param.Name
                    Case "p_DonVi"
                        param.Value = Generals.DON_VI.TenDonvi
                    Case "p_DiaChiCongTy"
                        param.Value = Generals.DON_VI.DiaChi
                    Case "p_FooterReport"
                        param.Value = Generals.DON_VI.TenDonvi + " - " + Generals.DON_VI.DiaChi
                End Select
            Next

            If Me.list_parameter.Count > 0 Then
                For Each item In Me.list_parameter
                    For i = 0 To repc - 1
                        If (String.Compare(item.Name.ToString().ToLower(), report.Parameters(i).Name.ToLower()) = 0) Then
                            report.Parameters(i).Value = item.Value
                            report.Parameters(i).Description = item.Description
                            report.Parameters(i).Visible = False
                        End If
                    Next
                Next
            End If
        End If

        'Show
        Me.PrintControl1.PrintingSystem = Me.report.PrintingSystem
        Me.report.CreateDocument()
    End Sub

#End Region

#Region "Events"

    Private Sub ReportPreview_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            callPreview()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub BarButtonItem2_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        Try
            Me.report.ShowDesignerDialog()
            Me.report.CreateDocument()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub ReportPreview_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown, PrintBarManager1.EditorKeyDown
        Try
            Select Case e.KeyCode
                Case Keys.Escape
                    Me.Close()
                Case Else
            End Select
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub
#End Region

End Class