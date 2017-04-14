﻿Imports Vns.Erp.Core.Spa.Domain
Imports Vns.Erp.Core.Admin.Domain
Imports Vns.Erp.Core.Spa.Service.Interface
Imports Vns.Erp.Core.Admin.Service.Interface

Public Class frmDoanhThuTongHop

#Region "Properties"
    Private _SpaReportsService As ISpaReportsService
    Public Property SpaReportsService() As ISpaReportsService
        Get
            Return _SpaReportsService
        End Get
        Set(ByVal value As ISpaReportsService)
            _SpaReportsService = value
        End Set
    End Property

    Private _DmNhomKhangService As IDmNhomKhangService
    Public Property DmNhomKhangService() As IDmNhomKhangService
        Get
            Return _DmNhomKhangService
        End Get
        Set(ByVal value As IDmNhomKhangService)
            _DmNhomKhangService = value
        End Set
    End Property

#End Region

#Region "Variables"

#End Region

#Region "Functions"

    Private Sub InitData()
        dteTuNgay.DateTime = Date.Now.Date
        dteDenNgay.DateTime = Date.Now.Date
        MultiExportButton1.GRID_VIEW = _GridView
    End Sub

    Private Sub BindDataToCbo()
        'bind giuong dich vu
        Dim lstNhomKh As List(Of DmNhomKhang) = _DmNhomKhangService.GetObjectAllByDonviID(Generals.DON_VI.Id)
        Dim lstNhom_temp As List(Of DmNhomKhang) = New List(Of DmNhomKhang)
        Dim obj_nhom As DmNhomKhang = New DmNhomKhang
        lstNhom_temp.Add(obj_nhom)
        lstNhom_temp.AddRange(lstNhomKh)
        cboLoaiKH.Properties.DataSource = lstNhom_temp
        cboLoaiKH.Properties.DisplayMember = "TenNhomKhang"
        cboLoaiKH.Properties.ValueMember = "Id"

        TNCommon.SelectFirst(cboLoaiKH)
    End Sub

    Private Sub BindDataToGrid()
        Dim TuNgay As DateTime = dteTuNgay.DateTime
        Dim DenNgay As DateTime = dteDenNgay.DateTime
        Dim NhomKhId As Guid = cboLoaiKH.EditValue
        'Dim LoaiDichVu As Decimal = Decimal.Parse(cboLoaiNghiepVu.EditValue)
        Dim lstDoanhThu As IList(Of SpaRpDoanhThuDTO) = SpaReportsService.BaoCaoDoanhThuDichVu(TuNgay, DenNgay, NhomKhId, Generals.DonviID)

        _GridControl.DataSource = lstDoanhThu
    End Sub
#End Region

#Region "Events"

    Private Sub frmDoanhThuBanThe_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            InitData()
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

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Try
            Me.Close()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

#End Region

End Class