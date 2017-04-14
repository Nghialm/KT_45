Imports Vns.Erp.Core.Spa.Domain
Imports DevExpress.XtraReports.UI

Public Class rpHddv

#Region "Variables"

    Private m_lstHangHoa As IList(Of CtDHddv)
    Private m_lstDichVu As IList(Of CtDHddv)
    Private m_objCth As CtHHddv

#End Region

#Region "Contructor"

    Public Sub New()
        InitializeComponent()
    End Sub

    Public Sub New(ByVal p_lstHangHoa As IList(Of CtDHddv), ByVal p_lstDichVu As IList(Of CtDHddv), ByVal p_objCthHddv As CtHHddv)
        InitializeComponent()
        m_lstDichVu = p_lstDichVu
        m_lstHangHoa = p_lstHangHoa
        m_objCth = p_objCthHddv
    End Sub

#End Region

#Region "Functions"

    Private Sub BindData()
        Dim lstcth As IList(Of CtHHddv) = New List(Of CtHHddv)
        lstcth.Add(m_objCth)
        Me.DataSource = DataHelper.ToDataTable(Of CtHHddv)(lstcth)

        For i As Integer = 0 To Me.Parameters.Count - 1
            Me.Parameters(i).Visible = True
        Next
    End Sub

#End Region

#Region "Events"
    Private Sub subDichVu_BeforePrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles subDichVu.BeforePrint
        Try
            Dim rpDichVu As rpDichVu = CType((CType(sender, XRSubreport)).ReportSource, rpDichVu)
            rpDichVu.DataSource = rpDichVu.GetData(m_lstDichVu)
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub subHangHoa_BeforePrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles subHangHoa.BeforePrint
        Try
            Dim rpHangHoa As rpHanghoa = CType((CType(sender, XRSubreport)).ReportSource, rpHanghoa)
            rpHangHoa.DataSource = rpHangHoa.GetData(m_lstHangHoa)
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub rpHddv_BeforePrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles MyBase.BeforePrint
        Try
            frmProgress.Instance.Thread = AddressOf BindData
            frmProgress.Instance.Show_Progress()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub
#End Region


End Class