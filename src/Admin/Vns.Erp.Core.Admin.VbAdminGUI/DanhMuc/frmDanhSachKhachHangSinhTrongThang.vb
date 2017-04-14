Imports Vns.Erp.Core.Admin.Domain
Imports Vns.Erp.Core.Admin.Service.Interface

Public Class frmDanhSachKhachHangSinhTrongThang

    Public DmKhangService As IDmKhangService
    Private lstKh As IList(Of DmKhang) = New List(Of DmKhang)
    Private Sub frmDanhSachKhachHangSinhTrongThang_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        btExport.GRID_VIEW = _GridView
        dteTuNgay.DateTime = New DateTime(DateTime.Now.Year, DateTime.Now.Month, 1)
        dteDenNgay.DateTime = dteTuNgay.DateTime.AddMonths(1).AddDays(-1)

        lstKh = DmKhangService.GetAllByDonviID(Generals.DonviID)

        _GridControl.DataSource = GetKhachhangSn(dteTuNgay.DateTime, dteDenNgay.DateTime)
    End Sub

    Private Function GetKhachhangSn(ByVal p_TuNgay As DateTime, ByVal p_DenNgay As DateTime) As IList(Of DmKhang)

        Dim _year As Int16
        Dim tempLstKh As IList(Of DmKhang) = New List(Of DmKhang)
        For Each obj As DmKhang In lstKh
            _year = obj.NgaySinh.Year
            p_TuNgay = New DateTime(_year, p_TuNgay.Month, p_TuNgay.Day)
            p_DenNgay = New DateTime(_year, p_DenNgay.Month, p_DenNgay.Day)
            If (obj.NgaySinh >= p_TuNgay And obj.NgaySinh <= p_DenNgay) Then
                tempLstKh.Add(obj)
            End If
        Next

        Return tempLstKh
    End Function

    
    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Try
            _GridControl.DataSource = GetKhachhangSn(dteTuNgay.DateTime, dteDenNgay.DateTime)
            _GridView.RefreshData()
        Catch ex As Exception
            Message_Error(ex)
        End Try

    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class