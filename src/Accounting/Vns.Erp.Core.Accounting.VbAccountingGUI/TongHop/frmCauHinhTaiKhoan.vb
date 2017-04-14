Imports Vns.Erp.Core.Admin.Service.Interface
Imports Vns.Erp.Core.Admin.Domain

Public Class frmCauHinhTaiKhoan
#Region "Property"
    Public Property HtDanhmucService() As IHtDanhmucService
    Public Property HtTaikhoanMauService As IHtTaikhoanMauService
#End Region

    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        Dim loai As Decimal = CType(ComboHelper.GetSelectData(grlQuyetDinh), HtDanhmuc).GiaTri

        HtTaikhoanMauService.ImportDmTaiKhoan(loai, Generals.DON_VI.Id)

        Message_Information("Đã thực hiện thành công")
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub frmCauHinhTaiKhoan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        BindLookUp()
    End Sub

    Private Sub BindLookUp()
        Dim objColumnDefine As ArrayList

        Dim lstLKChuyen As List(Of HtDanhmuc) = New List(Of HtDanhmuc)
        lstLKChuyen.AddRange(HtDanhmucService.GetByDoiTuong("QD_KETOAN"))
        objColumnDefine = New ArrayList
        objColumnDefine.Add(New LookupEdit_ColumnInfo("TenDanhmuc", "Loại kết chuyển"))
        GridLookupEdit_BindData(grlQuyetDinh, lstLKChuyen, "TenDanhmuc", "GiaTri", COMBO_ITEM_REQUIRE, "", objColumnDefine)
    End Sub
End Class