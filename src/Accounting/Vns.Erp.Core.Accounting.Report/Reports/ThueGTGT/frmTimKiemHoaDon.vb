Imports System
Imports System.Data
Imports System.IO
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls

Imports Vns.Erp.Core.Accounting.Report.Domain
Imports Vns.Erp.Core.Accounting.Domain
Imports Vns.Erp.Core.Admin.Domain
Imports Vns.Erp.Core.Accounting.Service.Interface
Imports Vns.Erp.Core.Admin.Service.Interface
Imports DevExpress.XtraReports.UI

Public Class frmTimKiemHoaDon
    Private MaxLengRow As Integer = 42
    Private MaxRowInVoice As Integer = 15
#Region "Property"
    Public Property CtHoadonService As ICtHoadonService
    Public Property CtThueService As ICtThueService
#End Region

#Region "Variable"
    Private lstCtThue As IList(Of CtThue) = New List(Of CtThue)
    Private selectCtHoaDon As CtHoadon
    Private lstCtHoaDon As IList(Of CtHoadon) = New List(Of CtHoadon)
#End Region

#Region "Functions"

    Public Sub BindLookUp()

    End Sub
#End Region


#Region "Events"
    Private Sub frmTimKiemChungTuKho_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.Escape
                Me.Close()
        End Select
    End Sub


    Public Sub New()
        InitializeComponent()
        Try
        Catch ex As Exception
            Message_Error(ex)
        End Try
        TNCommon.setIconControl(Me)
    End Sub

    Private Sub frmTimKiemChungTuKho_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        BindLookUp()
        SetStatus()
    End Sub

    Private Sub SetStatus()
        Dim hasdata As Boolean = True
        If lstCtHoaDon Is Nothing Then
            hasdata = False
        Else
            If lstCtHoaDon.Count <= 0 Then
                hasdata = False
            End If
        End If

        btnPrinter.Enabled = hasdata
        btnModify.Enabled = hasdata
    End Sub

    Private Sub btnHuy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub btnNhan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrinter.Click
        callReport()
    End Sub

    Private Sub callReport()
        Dim rp As New XtraReport

        Dim lstHNx As IList(Of RpHoaDonDTO) = New List(Of RpHoaDonDTO)()

        selectCtHoaDon = CType(grvLPX_Hnx.GetRow(grvLPX_Hnx.FocusedRowHandle), CtHoadon)
        Dim tmpRpHoadon As RpHoaDonDTO = New RpHoaDonDTO(selectCtHoaDon)
        lstHNx.Add(tmpRpHoadon)
        Dim dtH As DataTable = DataHelper.ToDataTable(Of RpHoaDonDTO)(lstHNx)
        dtH.TableName = "CtHoadon"


        Dim lstDNx As List(Of RpThueDTO) = New List(Of RpThueDTO)()
        For Each tmp As CtThue In lstCtThue
            lstDNx.AddRange(tmpRpHoadon.GenBy(tmp, MaxLengRow))
        Next


        'Dim SoDongHD As Integer = tmpRpHoadon.SoDongThueKhiIn(lstDNx, MaxLengRow)
        Dim SoDongHD As Integer = lstDNx.Count
        If (SoDongHD > MaxRowInVoice) Then
            Message_Information(String.Format("Số dòng chi tiết thuế GTGT {0} bản ghi", SoDongHD))
            Return
        End If

        Dim dtD As DataTable = DataHelper.ToDataTable(Of RpThueDTO)(lstDNx)
        dtD.TableName = "CtThue"

        For tmp As Integer = SoDongHD To MaxRowInVoice - 1
            Dim dr As DataRow = dtD.NewRow()
            If (tmp = (SoDongHD + 1)) Then
                dr("TenHanghoa") = tmpRpHoadon.DienGiai
            End If
            dtD.Rows.Add(dr)
        Next
        Dim Data As DataSet = New DataSet()
        Data.DataSetName = "DataSet"
        Data.Tables.Add(dtH)
        Data.Tables.Add(dtD)

        rp.DataSource = Data
        If File.Exists(getTemplate()) Then
            'load template
            rp.LoadLayout(getTemplate())
        Else
            Message_Information("Không thấy mẫu báo cáo")
        End If
        'If String.IsNullOrEmpty(txtSoLien.Text) Then
        '    txtSoLien.Text = "1"
        'End If
        Dim view As New Preview(getObjectAll(selectCtHoaDon), rp, 1)
        view.ShowDialog()
    End Sub

    Private Function getTemplate() As String
        Dim root_dir = Generals.ThuMucChayCT & "Reports\ThueGTGT\"
        Return root_dir + "Thue_GTGT.repx"
    End Function

    Private Function getObjectAll(ByVal tmpHoadon As CtHoadon) As List(Of DevExpress.XtraReports.Parameters.Parameter)
        Dim lst As New List(Of DevExpress.XtraReports.Parameters.Parameter)
        Dim obj As New DevExpress.XtraReports.Parameters.Parameter
        obj = New DevExpress.XtraReports.Parameters.Parameter

        obj = New DevExpress.XtraReports.Parameters.Parameter
        obj.Name = "pNgayHd"
        obj.Value = selectCtHoaDon.NgayHoadon.Value.Day
        lst.Add(obj)

        obj = New DevExpress.XtraReports.Parameters.Parameter
        obj.Name = "pThangHd"
        obj.Value = selectCtHoaDon.NgayHoadon.Value.Month
        lst.Add(obj)

        obj = New DevExpress.XtraReports.Parameters.Parameter
        obj.Name = "pNamHd"
        obj.Value = selectCtHoaDon.NgayHoadon.Value.Year - 2000
        lst.Add(obj)

        obj = New DevExpress.XtraReports.Parameters.Parameter
        obj.Name = "pNguoiBanHang"
        obj.Value = ""
        lst.Add(obj)

        obj = New DevExpress.XtraReports.Parameters.Parameter
        obj.Name = "pNguoiMuaHang"
        obj.Value = ""
        lst.Add(obj)

        obj = New DevExpress.XtraReports.Parameters.Parameter
        obj.Name = "pThuTruongDv"
        obj.Value = ""
        lst.Add(obj)

        obj = New DevExpress.XtraReports.Parameters.Parameter
        obj.Name = "pTyLeThue"
        obj.Value = 10
        lst.Add(obj)

        Dim num2text As New NumberToString()
        obj = New DevExpress.XtraReports.Parameters.Parameter
        obj.Name = "pSoTienBangChu"
        obj.Value = "                                         " + num2text.Num2Text(tmpHoadon.TongTien, "đồng.")
        lst.Add(obj)

        obj = New DevExpress.XtraReports.Parameters.Parameter
        obj.Name = "pTongHoaDon"
        obj.Value = tmpHoadon.TongTien
        lst.Add(obj)

        Return lst
    End Function

    Private Sub TimKiem()
        Try
            Dim TuNgay As DateTime = DateTime.Now
            Dim DenNgay As DateTime = DateTime.Now
            Dim SoHoaDon As String = txtSoHoaDon.EditValue
            Dim DonviId As Guid = Generals.DON_VI.Id

            TuNgay = ucDateTime.StartDate
            DenNgay = ucDateTime.EndDate

            lstCtHoaDon = CtHoadonService.SearchBy(TuNgay, DenNgay, DonviId, SoHoaDon)
            grcLPN_Hnx.DataSource = lstCtHoaDon

            SetStatus()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub Load_Grid()
        grcLPN_Hnx.DataSource = lstCtHoaDon
    End Sub

    Private Sub LoadGRV(ByVal CTH_XN As CtHoadon)
        lstCtThue = CtThueService.GetObjectbyCtHoaDon(CTH_XN.Id)
        grcLPN_Dnx.DataSource = lstCtThue
    End Sub

    Private Sub grvLPX_Hnx_FocusedRowChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles grvLPX_Hnx.FocusedRowChanged
        Dim gridcth As CtHoadon = CType(grvLPX_Hnx.GetRow(grvLPX_Hnx.FocusedRowHandle), CtHoadon)
        If gridcth Is Nothing Then
            grcLPN_Dnx.DataSource = Nothing
            grvLPN_Dnx.RefreshData()
            Return
        Else
            LoadGRV(gridcth)
        End If
    End Sub

    Private Sub btnSea_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSea.Click
        frmProgress.Instance.Thread = AddressOf TimKiem
        frmProgress.Instance.Show_Progress()
        grvLPX_Hnx.FocusedRowHandle = -1
        grvLPX_Hnx.SelectRow(Handle)
        If grvLPX_Hnx.RowCount > 0 Then
            btnPrinter.Enabled = True
        End If
    End Sub
#End Region


    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModify.Click
        Dim frm As frmHoaDonThueGTGT = ObjectFactory.GetObject("frmHoaDonThueGTGT")

        selectCtHoaDon = CType(grvLPX_Hnx.GetRow(grvLPX_Hnx.FocusedRowHandle), CtHoadon)
        If selectCtHoaDon Is Nothing Then Return
        frm.CtHoaDon = selectCtHoaDon
        frm.LstCtThue = lstCtThue
        frm.Show_Form()

        LoadGRV(selectCtHoaDon)
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click

    End Sub

    Private Sub btnQui_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuit.Click
        Me.Close()
    End Sub
End Class