Imports DevExpress.XtraEditors
Imports DevExpress.XtraReports.UI
Imports System.IO

Imports Vns.Erp.Core
Imports Vns.Erp.Core.Admin.Domain
Imports Vns.Erp.Core.Accounting.Domain
Imports Vns.Erp.Core.Accounting.Report.Domain

Imports Vns.Erp.Core.Admin.Service.Interface
Imports Vns.Erp.Core.Accounting.Service.Interface
Public Class frmKho_Input

#Region "Property"
    Public Property CtHNxService As ICtHNxService
    Public Property CtDNxService As ICtDNxService
    Public Property HtThamsoService As IHtThamsoService
#End Region

#Region "Variable"
    Private _ht As HtLoaichungtu
    Private data As New DataSet
    Public Property objCtH As CtHNx
    Public Property lstCtD As IList(Of CtDNx)

    Private m_CTH_ID As Guid

#End Region

#Region "Function"
    Public Sub New(ByVal _m_CTH_ID As Guid, ByVal obj As HtLoaichungtu)
        Try
            InitializeComponent()
            _ht = obj
            m_CTH_ID = _m_CTH_ID
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub InitData()
        Me.ShowInTaskbar = False
        Me.StartPosition = FormStartPosition.CenterScreen
        data = New DataSet()

        objCtH = CtHNxService.GetById(m_CTH_ID)
        'dt1.Rows(0)("CT_SO") = dt1.Rows(0)("PREFIX_CT") & dt1.Rows(0)("CT_SO")
        lstCtD = objCtH.LstCtDNx

        txtTieude.EditValue = _ht.TenLoaiCt
        'If _ht.KhoXuat = 0 Then
        txtNguoiNhan.EditValue = objCtH.NguoiGiaoNhanHang
        'Else
        'txtNguoiNhan.EditValue = objCtH.NguoiNhanNopTien
        'End If
    End Sub

    'Create sample template
    Private Sub fillObjectTemplate()
        'If rdoNgonngu.SelectedIndex = 0 Then
        'Load template tieng viet
        tempVi(_ht.KhoXuat)
        'Else
        ''Load template tieng anh
        'tempEng(Me._ht.KHO_XUAT)
        'End If
    End Sub

    Private Sub tempVi(ByVal flag As Decimal)
        Dim lst As New List(Of String)
        If _ht.MaLoaiCt = "P_XKHO_BH" Then
            lst.Add("BanHangKiemXuatKho.repx")
        ElseIf (flag = 1) Or (flag = 2) Then
            'Load template xuat kho
            lst.Add("xuat.repx")
        ElseIf flag = 0 Then
            'Load template nhap kho
            lst.Add("nhap.repx")
        End If
        lkeTemplate.Properties.DataSource = lst
        If lst.Count <> 0 Then
            lkeTemplate.ItemIndex = 0
        End If
    End Sub

    Private Sub tempEng(ByVal flag As Decimal)
        If flag = 1 Then
            'Load template xuat kho
            Dim lst As New List(Of String)
            lst.Add("xuat_en.repx")
            lkeTemplate.Properties.DataSource = lst
            lkeTemplate.ItemIndex = 0
        ElseIf flag = 0 Then
            'Load template nhap kho
            Dim ls As New List(Of String)
            ls.Add("nhap_en.repx")
            lkeTemplate.Properties.DataSource = ls
            lkeTemplate.ItemIndex = 0
        End If
    End Sub

    'Get template link
    Private Function getTemplate(ByVal contrl As LookUpEdit) As String
        Dim root_dir = Generals.ThuMucChayCT & "Vouchers\Templates\"
        Return root_dir + contrl.EditValue
    End Function

    'Get Sum colum
    Private Function getColumnSum() As Decimal
        Dim equal As Decimal = 0
        For Each item As CtDNx In lstCtD
            If _ht.MaLoaiCt = "P_XKHO_BH" Then
                equal = equal + item.SoTienBan
            Else
                equal = equal + item.GiaVon
            End If
        Next
        Return equal
    End Function

    'Get object in form
    Private Function getObjectAll() As List(Of DevExpress.XtraReports.Parameters.Parameter)
        Dim lst As New List(Of DevExpress.XtraReports.Parameters.Parameter)
        Dim obj As New DevExpress.XtraReports.Parameters.Parameter
        obj = New DevExpress.XtraReports.Parameters.Parameter
        obj.Name = "pNgayFooter"
        obj.Value = "Ngày " + DateTime.Now.Day.ToString() + " tháng " + DateTime.Now.Month.ToString() + " năm " + DateTime.Now.Year.ToString()
        lst.Add(obj)
        obj = New DevExpress.XtraReports.Parameters.Parameter
        obj.Name = "pNgayHeader"
        obj.Value = "Ngày " + DateTime.Now.Day.ToString() + "/" + DateTime.Now.Month.ToString() + "/" + DateTime.Now.Year.ToString()
        lst.Add(obj)
        obj = New DevExpress.XtraReports.Parameters.Parameter
        obj.Name = "pNguoiLapPhieuKy"
        obj.Value = txtNguoiLapPhieu.Text
        lst.Add(obj)
        obj = New DevExpress.XtraReports.Parameters.Parameter
        obj.Name = "pThuKhoKy"
        obj.Value = txtThuKho.Text
        lst.Add(obj)
        obj = New DevExpress.XtraReports.Parameters.Parameter
        obj.Name = "pTieuDe"
        obj.Value = txtTieude.Text
        lst.Add(obj)
        obj = New DevExpress.XtraReports.Parameters.Parameter
        obj.Name = "pTruongPhongKy"
        obj.Value = txtTruongPhong.Text
        lst.Add(obj)
        obj = New DevExpress.XtraReports.Parameters.Parameter
        obj.Name = "pNguoiNhan"
        obj.Value = txtNguoiNhan.Text
        lst.Add(obj)
        obj = New DevExpress.XtraReports.Parameters.Parameter
        obj.Name = "pNguoiGiao"
        obj.Value = txtNguoiNhan.Text
        lst.Add(obj)
        obj = New DevExpress.XtraReports.Parameters.Parameter
        obj.Name = "pGiamDoc"
        obj.Value = txtThuTruong.Text
        lst.Add(obj)
        obj = New DevExpress.XtraReports.Parameters.Parameter
        obj.Name = "pSoCTGoc"
        obj.Value = txtSoCtuKem.Text
        lst.Add(obj)
        obj = New DevExpress.XtraReports.Parameters.Parameter
        obj.Name = "p_TenCongTy"
        obj.Value = txtCty.Text
        lst.Add(obj)

        obj = New DevExpress.XtraReports.Parameters.Parameter
        obj.Name = "p_DiaChiCongTy"
        obj.Value = txtDCcty.Text
        lst.Add(obj)

        'obj = New DevExpress.XtraReports.Parameters.Parameter
        'obj.Name = "p_NguoiNhanMua"
        'If _ht.KhoXuat = 0 Then
        '    obj.Value = "Người giao hàng :"
        'Else
        '    obj.Value = "Người nhận hàng :"
        'End If
        'lst.Add(obj)

        Dim num2text As New NumberToString()
        obj = New DevExpress.XtraReports.Parameters.Parameter
        obj.Name = "pSoTienBangChu"
        'If Me._ht.KHO_XUAT = 0 Then
        obj.Value = num2text.Num2Text(getColumnSum(), "đồng.")
        'Else
        '    obj.Value = num2text.Num2Text(getColumnSum(Me.data.Tables("CT_D_NX"), "SO_TIEN_BAN"), "đồng.")
        'End If
        lst.Add(obj)

        lst.AddRange(CommonClass.ConvertThamSoToParameter(_HtThamsoService.GetAll()))

        Return lst
        'Return Nothing
    End Function

    Private Sub callReport()
        Dim list_obj As List(Of HtThamso) = HtThamsoService.GetByDonviId(Generals.DON_VI.Id)
        'Dim list_para As List(Of DevExpress.XtraReports.Parameters.Parameter) = ConvertListObjectToParamter(list_obj)
        Dim rp As New XtraReport
        Dim lstHNx As IList(Of RpPhieuKeToanKhoHDTO) = New List(Of RpPhieuKeToanKhoHDTO)()
        lstHNx.Add(New RpPhieuKeToanKhoHDTO(objCtH))
        Dim dtH As DataTable = DataHelper.ToDataTable(Of RpPhieuKeToanKhoHDTO)(lstHNx)
        dtH.TableName = "CtHNx"

        Dim lstDNx As IList(Of RpPhieuKeToanKhoDDTO) = New List(Of RpPhieuKeToanKhoDDTO)()
        For Each tmp As CtDNx In lstCtD
            lstDNx.Add(New RpPhieuKeToanKhoDDTO(tmp))
        Next
        Dim dtD As DataTable = DataHelper.ToDataTable(Of RpPhieuKeToanKhoDDTO)(lstDNx)
        dtD.TableName = "CtDNx"
        data = New DataSet()
        data.DataSetName = "DataSet"
        data.Tables.Add(dtH)
        data.Tables.Add(dtD)
        data.Relations.Add(New DataRelation("CtHNx_CtDNx", dtH.Columns("CtHId"), dtD.Columns("CtHId")))

        rp.DataSource = Me.data
        If File.Exists(getTemplate(lkeTemplate)) Then
            'load template
            rp.LoadLayout(getTemplate(lkeTemplate))
        Else
            Message_Information("Không thấy mẫu báo cáo")
        End If
        If String.IsNullOrEmpty(txtSoLien.Text) Then
            txtSoLien.Text = "1"
        End If
        Dim view As New Preview(getObjectAll(), rp, Convert.ToDecimal(txtSoLien.Text))
        view.WindowState = System.Windows.Forms.FormWindowState.Maximized
        view.ShowDialog()
    End Sub

    'Convert list to paramter
    Private Function ConvertListObjectToParamter(ByVal data_list_object As List(Of HtThamso)) As List(Of DevExpress.XtraReports.Parameters.Parameter)
        Dim list_para As New List(Of DevExpress.XtraReports.Parameters.Parameter)
        Dim tem As DevExpress.XtraReports.Parameters.Parameter
        For Each item As HtThamso In data_list_object
            tem = New DevExpress.XtraReports.Parameters.Parameter
            tem.Name = item.MaThamso
            tem.Description = item.TenThamso
            tem.Value = item.GiaTri
            'tem.Visible = False
            list_para.Add(tem)
        Next
        Return list_para
    End Function

    'Load data mac dinh cua he thong
    Private Sub setDefault()
        Dim ts = HtThamsoService.GetByDonviId(Generals.DON_VI.Id)
        If ts.Count > 0 Then
            For Each item In ts
                If item.GiaTri <> Nothing And item.MaThamso = "p_TenCongTy" Then
                    txtCty.Text = item.GiaTri
                ElseIf item.GiaTri <> Nothing And item.MaThamso = "p_DiaChiCongTy" Then
                    txtDCcty.Text = item.GiaTri
                ElseIf item.GiaTri <> Nothing And item.MaThamso = "p_ThuKho" Then
                    txtThuKho.Text = item.GiaTri
                ElseIf item.GiaTri <> Nothing And item.MaThamso = "p_TieuDe" Then
                    txtTieude.Text = item.GiaTri
                ElseIf item.GiaTri <> Nothing And item.MaThamso = "p_KeToanTruong" Then
                    txtTruongPhong.Text = item.GiaTri
                ElseIf item.GiaTri <> Nothing And item.MaThamso = "p_ThuTruongDonVi" Then
                    txtThuTruong.Text = item.GiaTri
                    'ElseIf item.GIA_TRI <> Nothing And item.MA_THAMSO = "p_NguoiLapPhieu" Then
                    '    txtNguoiLapPhieu.Text = item.GIA_TRI
                End If
            Next
        End If

        txtNguoiLapPhieu.Text = Generals.USER.Fullname
        'txtThuTruong.Text = Generals.DON_VI.GIAM_DOC
    End Sub
#End Region

#Region "Event"
    Private Sub frmPhieu_Input_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            'Create sample template
            InitData()
            fillObjectTemplate()
            'rdoNgonngu.SelectedIndex = 0
            'rdoTienTe.SelectedIndex = 0
            'PanelControl2.Visible = False
            'Me.Height = 230
            setDefault()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub btnXem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnXem.Click
        Try
            callReport()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    'Private Sub chkOption_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkOption.CheckedChanged
    '    If chkOption.Checked = True Then
    '        PanelControl2.Visible = True
    '        Me.Height = 350
    '    Else
    '        PanelControl2.Visible = False
    '        Me.Height = 240
    '    End If
    'End Sub

    'Private Sub rdoNgonngu_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdoNgonngu.SelectedIndexChanged, rdoTienTe.SelectedIndexChanged
    '    fillObjectTemplate()
    'End Sub

    Private Sub txtNguoiNhan_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtNguoiNhan.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                callReport()
            End If
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub frmKho_Input_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown, txtTieude.KeyDown, txtSoLien.KeyDown, txtSoCtuKem.KeyDown, lkeTemplate.KeyDown
        Select Case e.KeyCode
            Case Keys.Escape
                Me.Close()
                Exit Select
        End Select
    End Sub
#End Region

End Class