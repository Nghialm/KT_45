Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraPrinting

Imports Vns.Erp.Core.Asset.Service.Interface
Imports Vns.Erp.Core.Accounting.Service.Interface
Imports Vns.Erp.Core.Asset.Domain
Imports Vns.Erp.Core.Accounting.Report.Service.Interface

Public Class The_TSCD

#Region "Property"
    Private _DmTscdService As IDmTscdService
    Public Property DmTscdService As IDmTscdService
        Get
            Return _DmTscdService
        End Get
        Set(ByVal value As IDmTscdService)
            _DmTscdService = value
        End Set
    End Property

    Private _RpTheTscdS23DnService As IRpTheTscdS23DnService
    Public Property RpTheTscdS23DnService As IRpTheTscdS23DnService
        Get
            Return _RpTheTscdS23DnService
        End Get
        Set(ByVal value As IRpTheTscdS23DnService)
            _RpTheTscdS23DnService = value
        End Set
    End Property

    Private _TsTscdPtungService As ITsTscdPtungService
    Public Property TsTscdPtungService As ITsTscdPtungService
        Get
            Return _TsTscdPtungService
        End Get
        Set(ByVal value As ITsTscdPtungService)
            _TsTscdPtungService = value
        End Set
    End Property
#End Region

    Private m_TSCD_ID As String
    Private LastID As String = ""
    Private PageNumber As Integer = 0
    Private lstDmTscd As List(Of DmTscd) = New List(Of DmTscd)

    Public Sub New(ByVal p_TSCD_ID As String)
        InitializeComponent()
        m_TSCD_ID = p_TSCD_ID
    End Sub

    Public Sub New(ByVal p_TSCD_ID As String, ByVal lstTscd As List(Of DmTscd))
        InitializeComponent()
        m_TSCD_ID = p_TSCD_ID
        lstDmTscd = New List(Of DmTscd)
        lstDmTscd.AddRange(lstTscd)
    End Sub

    Private Sub XrSubreport2_BeforePrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles XrSubreport2.BeforePrint
        Dim prt_ts As CT_TSCD = CType((CType(sender, XRSubreport)).ReportSource, CT_TSCD)
        prt_ts.RpTheTscdS23DnService = _RpTheTscdS23DnService
        prt_ts.DataSource = prt_ts.Bindata(GetCurrentColumnValue("Id"))
    End Sub

    Private Sub XrSubreport1_BeforePrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles XrSubreport1.BeforePrint
        Dim rpt_PT As PTKT = CType((CType(sender, XRSubreport)).ReportSource, PTKT)
        rpt_PT.TsTscdPtungService = _TsTscdPtungService
        rpt_PT.DataSource = rpt_PT.GetData(VnsConvert.CGuid(Me.GetCurrentColumnValue("Id")))
    End Sub

    Private Sub The_TSCD_BeforePrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles MyBase.BeforePrint
        Dim ds_TSCD As DataTable = DataHelper.ToDataTable(lstDmTscd)
        Me.DataSource = ds_TSCD

        lblDon_VI.Text = Generals.DON_VI.TenDonvi
        lblDia_Chi.Text = Generals.DON_VI.DiaChi
    End Sub

    Private Sub xrPage_PrintOnPage(ByVal sender As System.Object, ByVal e As DevExpress.XtraReports.UI.PrintOnPageEventArgs) Handles xrPage.PrintOnPage
        'Try
        Dim CurID As String = (CType(sender, XRLabel)).Tag.ToString()
        Dim PageCount As Integer = 0

        For Each MyPage As Page In Me.PrintingSystem.Pages
            Dim BrickEnum As BrickEnumerator = MyPage.GetEnumerator()

            Do While BrickEnum.MoveNext()
                Dim Brick As VisualBrick = CType(BrickEnum.Current, VisualBrick)

                If Not (Brick Is Nothing) And Brick.BrickOwner Is CType(sender, XRLabel) Then
                    If Brick.Value.ToString() = CurID Then
                        PageCount += 1
                    End If
                End If
            Loop
        Next MyPage

        If CurID = LastID Then
            PageNumber += 1
        Else
            PageNumber = 1
        End If

        LastID = CurID
        CType(sender, XRLabel).Text = "Page " & PageNumber.ToString() & " of " & PageCount.ToString()
        'Catch ex As Exception
        'End Try
    End Sub
End Class