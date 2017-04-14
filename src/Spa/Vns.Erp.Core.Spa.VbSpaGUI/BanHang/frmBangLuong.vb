Imports Vns.Erp.Core.Spa.Service.Interface
Imports Vns.Erp.Core.Spa.Domain

Public Class frmBangLuong
#Region "Properties"

    Private _CtHHddvService As ICtHHddvService
    Public Property CtHHddvService() As ICtHHddvService
        Get
            Return _CtHHddvService
        End Get
        Set(ByVal value As ICtHHddvService)
            _CtHHddvService = value
        End Set
    End Property

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

    Private _SpaBangLuongService As ISpaBangLuongService
    Public Property SpaBangLuongService() As ISpaBangLuongService
        Get
            Return _SpaBangLuongService
        End Get
        Set(ByVal value As ISpaBangLuongService)
            _SpaBangLuongService = value
        End Set
    End Property
#End Region

#Region "Variables"
    Private lstDanhSach As List(Of SpaBangLuong) = New List(Of SpaBangLuong)
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

    Dim ThangLuong As DateTime = Date.Now
    Private Sub BindDataToGridDanhSach()
        Dim NhanVienID As Guid = VnsConvert.CGuid(cboNhanVien.EditValue)
        Dim TuNgay As DateTime = New Date(Integer.Parse(cboNam.EditValue), Integer.Parse(cboThang.EditValue), 1)
        Dim DenNgay As DateTime = TuNgay.AddMonths(1).AddDays(-1)
        Dim DonViId As Guid = Generals.DON_VI.Id
        Dim GiuongDVId As Guid = New Guid()
        lstDanhSach = _SpaBangLuongService.BangLuongThang(DonViId, DenNgay, NhanVienID)
        ThangLuong = DenNgay

        lstChiTiet = _SpaReportsService.ListNhanVienPhucVu(Generals.DON_VI.Id, NhanVienID, Null.NullGuid, TuNgay, DenNgay)

        Dim TienHoaHong As Decimal

        For Each objDanhSach As SpaBangLuong In lstDanhSach
            TienHoaHong = 0
            For Each objChiTiet As SpaRpNhanVienDTO In lstChiTiet
                If objChiTiet.NhanVienID = objDanhSach.NhanVienId Then
                    TienHoaHong += objChiTiet.SoTienHh
                End If
            Next

            'Neu tien hoa hong da duoc thay doi va luu thi se lay tien hoa hong tu db len
            'Co the no ko bang tong tien hoa hong o form danh sach cong lai
            If objDanhSach.SoTienHoaHong <> 0 AndAlso TienHoaHong <> objDanhSach.SoTienHoaHong Then
            Else
                objDanhSach.SoTienHoaHong = TienHoaHong
            End If
        Next
        grcDanhSach.DataSource = Nothing
        grcDanhSach.DataSource = lstDanhSach
    End Sub

    Private Sub BindDataToGridChiTiet(ByVal lst As List(Of SpaRpNhanVienDTO), ByVal NhanVienId As Guid)
        Dim lstTempChiTiet As List(Of SpaRpNhanVienDTO) = New List(Of SpaRpNhanVienDTO)

        For Each objChiTietTemp As SpaRpNhanVienDTO In lstChiTiet
            If objChiTietTemp.NhanVienID = NhanVienId Then
                lstTempChiTiet.Add(objChiTietTemp)
            End If
        Next

        grcChiTiet.DataSource = lstTempChiTiet
    End Sub

    Private Sub SaveData()
        _SpaBangLuongService.SaveBangLuongThang(lstDanhSach, ThangLuong)
    End Sub

#End Region

#Region "Events"

    Private Sub frmBangLuong_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            BindDataToCbo()
            BindDataToGridDanhSach()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Try
            Dim i As Integer = grvDanhSach.FocusedRowHandle
            frmProgress.Instance.Thread = AddressOf BindDataToGridDanhSach
            frmProgress.Instance.Show_Progress()
            If i = 0 Then
                grvDanhSach_FocusedRowChanged(grvDanhSach, Nothing)
            End If
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Try
            frmProgress.Instance.Thread = AddressOf SaveData
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

    Private Sub grvDanhSach_FocusedRowChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles grvDanhSach.FocusedRowChanged
        Try
            Dim objDanhSach As SpaBangLuong = CType(grvDanhSach.GetRow(grvDanhSach.FocusedRowHandle), SpaBangLuong)
            If objDanhSach Is Nothing Then
                grcChiTiet.DataSource = Nothing
                Return
            End If
            BindDataToGridChiTiet(lstChiTiet, objDanhSach.NhanVienId)
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

#End Region
End Class