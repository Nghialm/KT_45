Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraReports.Parameters

Public Class Preview

#Region "Variable"
    Private rep As New XtraReport()
    Private lsParameter As New List(Of DevExpress.XtraReports.Parameters.Parameter)
#End Region

#Region "Function"
    'Creater
    Public Sub New(ByVal lst As List(Of DevExpress.XtraReports.Parameters.Parameter), ByVal rp As XtraReport, ByVal Count As Decimal)
        InitializeComponent()
        Me.rep = rp
        Me.lsParameter = lst
        If Count <= 0 Then
            Count = 1
        End If
        Me.ShowInTaskbar = False
        Me.StartPosition = FormStartPosition.CenterScreen
        'Me.rep.Detail.RepeatCountOnEmptyDataSource = Count
    End Sub
    Public Sub New(ByVal rp As XtraReport)
        InitializeComponent()
        Me.rep = rp
    End Sub
#End Region

#Region "Events"
    Private Sub Preview_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Duyet tu dau toi cuoi danh sach cac paramter tren template
        'Duyet to dau toi cuoi list dc dua vao
        'Neu Name cua chung bang nhau thi gan gia tri cho paramter tren template
        Try
            Dim repc = rep.Parameters.Count

            If (lsParameter IsNot Nothing) Then
                For Each item In Me.lsParameter
                    For i = 0 To repc - 1
                        If (String.Compare(item.Name.ToString().ToLower(), rep.Parameters(i).Name.ToLower()) = 0) Then
                            rep.Parameters(i).Value = item.Value
                            rep.Parameters(i).Description = item.Description
                            rep.Parameters(i).Visible = False
                        End If
                    Next
                Next
            End If

            PrintControl1.PrintingSystem = rep.PrintingSystem
            Me.rep.CreateDocument()
        Catch ex As Exception
            Message_Error(ex)
        End Try

    End Sub

    Private Sub btEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btEdit.ItemClick
        Me.rep.ShowDesignerDialog()
        Me.rep.CreateDocument()
    End Sub
#End Region

    Private Sub Preview_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Select Case e.KeyCode
            Case Keys.Escape
                Me.Close()
            Case Else
        End Select
    End Sub
End Class

#Region "Parameter Info"
'
'Create parameter info
Public Class ParameterInfo
    Private _Name As String
    Private _Value As String
    Property Name()
        Get
            Return _Name
        End Get
        Set(ByVal value)
            _Name = value
        End Set
    End Property
    Property Value()
        Get
            Return _Value
        End Get
        Set(ByVal value)
            _Value = value
        End Set
    End Property
End Class
#End Region