Imports Vns.Erp.Core.Spa.Service.Interface
Imports Vns.Erp.Core.Spa.Domain


Public Class frmCongViecNhanVien

#Region "Properties"

    Private _SpaDmNhanvienService As ISpaDmNhanvienService
    Public Property SpaDmNhanvienService() As ISpaDmNhanvienService
        Get
            Return _SpaDmNhanvienService
        End Get
        Set(ByVal value As ISpaDmNhanvienService)
            _SpaDmNhanvienService = value
        End Set
    End Property

    Private _SpaReportsService As ISpaReportsService
    Public Property SpaReportsService() As ISpaReportsService
        Get
            Return _SpaReportsService
        End Get
        Set(ByVal value As ISpaReportsService)
            _SpaReportsService = value
        End Set
    End Property

#End Region

#Region "Variables"
    'Private lstDanhSach As List(Of SpaBangLuong) = New List(Of SpaBangLuong)
    Private lstChiTiet As List(Of SpaRpNhanVienDTO) = New List(Of SpaRpNhanVienDTO)
#End Region

#Region "Functions"

    Private Sub BindDataToCbo()
        Dim dtMonth As DataTable = New DataTable
        dtMonth.Columns.Add("MONTH")
        For i As Integer = 1 To 12
            dtMonth.Rows.Add(i)
        Next
        cboThang.Properties.DataSource = dtMonth
        cboThang.Properties.DisplayMember = "MONTH"
        cboThang.Properties.ValueMember = "MONTH"

        cboThang.EditValue = Date.Now.Month.ToString

        Dim dtYear As DataTable = New DataTable
        dtYear.Columns.Add("YEAR")
        For i As Integer = 2000 To 2030
            dtYear.Rows.Add(i)
        Next

        cboNam.Properties.DataSource = dtYear
        cboNam.Properties.DisplayMember = "YEAR"
        cboNam.Properties.ValueMember = "YEAR"
        cboNam.EditValue = Date.Now.Year.ToString

        'bind nhan vien
        Dim lstNhanVIen As List(Of SpaDmNhanvien) = _SpaDmNhanvienService.GetAllByDonviID(Generals.DON_VI.Id)
        Dim lstNhanVien_temp As List(Of SpaDmNhanvien) = New List(Of SpaDmNhanvien)
        Dim obj_NhanVien As SpaDmNhanvien = New SpaDmNhanvien
        lstNhanVien_temp.Add(obj_NhanVien)
        lstNhanVien_temp.AddRange(lstNhanVIen)
        cboNhanVien.Properties.DataSource = lstNhanVien_temp
        cboNhanVien.Properties.DisplayMember = "KyHieu"
        cboNhanVien.Properties.ValueMember = "Id"

        cboTenNhanVien.DataSource = lstNhanVien_temp
        cboTenNhanVien.DisplayMember = "Ten"
        cboTenNhanVien.ValueMember = "Id"
    End Sub

    Private Sub BindDataToGrid()
        Dim NhanVienID As Guid = VnsConvert.CGuid(cboNhanVien.EditValue)
        Dim TuNgay As DateTime = New Date(Integer.Parse(cboNam.EditValue), Integer.Parse(cboThang.EditValue), 1)
        Dim DenNgay As DateTime = TuNgay.AddMonths(1).AddDays(-1)
        Dim DonViId As Guid = Generals.DON_VI.Id
        Dim GiuongDVId As Guid = New Guid()

        lstChiTiet = _SpaReportsService.ListNhanVienPhucVu(Generals.DON_VI.Id, NhanVienID, Null.NullGuid, TuNgay, DenNgay)
        _Gridcontrol.DataSource = lstChiTiet
    End Sub

#End Region

#Region "Events"

    Private Sub frmBangLuong_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            MultiExportButton1.GRID_VIEW = _Gridview
            BindDataToCbo()
            BindDataToGrid()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Try
            frmProgress.Instance.Thread = AddressOf BindDataToGrid
            frmProgress.Instance.Show_Progress()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub btnQuayRa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuayRa.Click
        Try
            Me.Close()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

#End Region

End Class