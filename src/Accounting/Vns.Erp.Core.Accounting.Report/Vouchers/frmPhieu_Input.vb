Imports DevExpress.XtraEditors
Imports DevExpress.XtraReports.UI
Imports System.IO

Imports Vns.Erp.Core
Imports Vns.Erp.Core.Admin.Domain
Imports Vns.Erp.Core.Accounting.Domain
Imports Vns.Erp.Core.Accounting.Report.Domain

Imports Vns.Erp.Core.Admin.Service.Interface
Imports Vns.Erp.Core.Accounting.Service.Interface
Public Class frmPhieu_Input

#Region "Property"
    Public Property CtHService As ICtHService
    Public Property CtDService As ICtDService
    Public Property HtThamsoService As IHtThamsoService
#End Region

#Region "Variable"
    Private _ht As HtLoaichungtu
    Private m_CTH_ID As Guid
    Private data As New DataSet
    Public Property objCtH As CtH
    Public Property lstCtD As IList(Of CtD)
#End Region

#Region "Function"
    Public Sub New()
        InitializeComponent()
    End Sub

    Public Sub New(ByVal _m_CTH_ID As Guid, ByVal obj As HtLoaichungtu)
        Try
            InitializeComponent()
            m_CTH_ID = _m_CTH_ID
            _ht = obj
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub InitData()
        data = New DataSet()
        objCtH = CtHService.GetById(m_CTH_ID)
        LstCtD = objCtH.LstCtD
        txtTieude.EditValue = _ht.TenLoaiCt
        txtNguoiNhan.EditValue = objCtH.NguoiNhanNopTien
    End Sub

    'Create sample template
    Private Sub fillObjectTemplate()
        tempVi(Me._ht.PhieuXuat)
    End Sub

    Public Sub tempVi(ByVal flag As Decimal)
        If flag = 1 Then
            'Load template phieu chi
            Dim lst As New List(Of String)
            lst.Add("thu.repx")
            lkeTemplate.Properties.DataSource = lst
            lkeTemplate.ItemIndex = 0
        ElseIf flag = 0 Then
            'Load template phieu thu
            Dim ls As New List(Of String)
            ls.Add("chi.repx")
            lkeTemplate.Properties.DataSource = ls
            lkeTemplate.ItemIndex = 0
        End If
    End Sub

    Public Sub tempEng(ByVal flag As Decimal)
        If flag = 1 Then
            'Load template phieu chi
            Dim lst As New List(Of String)
            lst.Add("thu_en.repx")
            lkeTemplate.Properties.DataSource = lst
            lkeTemplate.ItemIndex = 0
        ElseIf flag = 0 Then
            'Load template phieu thu
            Dim ls As New List(Of String)
            ls.Add("chi_en.repx")
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
    Public Function getColumnSum() As Double
        Dim equal As Decimal = 0
        For Each item As CtD In lstCtD
            equal = equal + item.SoTien
        Next
        Return equal
    End Function

    'Get object in form
    Private Function getObjectAll() As List(Of DevExpress.XtraReports.Parameters.Parameter)
        Dim lst As New List(Of DevExpress.XtraReports.Parameters.Parameter)
        Dim obj As New DevExpress.XtraReports.Parameters.Parameter

        Try
            'Danh cho phieu chi
            'Dim sotien = Me._ctdInfo.Sum(Function(v) v.SO_TIEN)
            Dim sotien = getColumnSum()
            Dim num2text As New NumberToString()
            Dim value = num2text.Num2Text(sotien, "đồng.")
            obj = New DevExpress.XtraReports.Parameters.Parameter
            obj.Name = "pKeToanKy"
            obj.Value = txtKT.Text
            lst.Add(obj)
            obj = New DevExpress.XtraReports.Parameters.Parameter
            obj.Name = "pKeToanThanhToanKy"
            obj.Value = txtKTtt.Text
            lst.Add(obj)
            obj = New DevExpress.XtraReports.Parameters.Parameter
            obj.Name = "pNgayFooter"
            obj.Value = "Ngày " + DateTime.Now.Day.ToString() + " tháng " + DateTime.Now.Month.ToString() + " năm " + DateTime.Now.Year.ToString()
            lst.Add(obj)
            obj = New DevExpress.XtraReports.Parameters.Parameter
            obj.Name = "pNgayHeader"
            obj.Value = "Ngày " + DateTime.Now.Day.ToString() + "/" + DateTime.Now.Month.ToString() + "/" + DateTime.Now.Year.ToString()
            lst.Add(obj)
            obj = New DevExpress.XtraReports.Parameters.Parameter
            obj.Name = "pNguoiNhanKy"
            obj.Value = txtNguoiNhan.Text
            lst.Add(obj)
            obj = New DevExpress.XtraReports.Parameters.Parameter
            obj.Name = "pSoTienBangChu"
            obj.Value = value
            lst.Add(obj)
            obj = New DevExpress.XtraReports.Parameters.Parameter
            obj.Name = "pThuQuyKy"
            obj.Value = txtThuquy.Text
            lst.Add(obj)
            obj = New DevExpress.XtraReports.Parameters.Parameter
            obj.Name = "pTieuDe"
            obj.Value = txtTieude.Text.ToUpper
            lst.Add(obj)
            obj = New DevExpress.XtraReports.Parameters.Parameter
            obj.Name = "pKeToan"
            obj.Value = txtKT.Text
            lst.Add(obj)
            obj = New DevExpress.XtraReports.Parameters.Parameter
            obj.Name = "pThuTruongKy"
            obj.Value = txtThutruong.Text
            lst.Add(obj)
            obj = New DevExpress.XtraReports.Parameters.Parameter
            obj.Name = "pCtuKemTheo"
            If txtSoCtuKem.Text <> "" Then
                obj.Value = Convert.ToDecimal(txtSoCtuKem.Text)
            Else
                obj.Value = 0
            End If
            lst.Add(obj)
            obj = New DevExpress.XtraReports.Parameters.Parameter
            obj.Name = "pCongTy"
            obj.Value = txtCty.Text
            lst.Add(obj)
            obj = New DevExpress.XtraReports.Parameters.Parameter
            obj.Name = "pDiaChiCongTy"
            obj.Value = txtDCcty.Text

            lst.AddRange(CommonClass.ConvertThamSoToParameter(_HtThamsoService.GetAll()))

            lst.Add(obj)
        Catch ex As Exception
            Message_Error(ex)
        End Try
        Return lst
    End Function

    Public Sub callReport()
        Dim rp As New rptMain()
        Dim lst As IList(Of RpPhieuKeToanDTO) = New List(Of RpPhieuKeToanDTO)()
        lst.Add(New RpPhieuKeToanDTO(objCtH, lstCtD))
        rp.DataSource = DataHelper.ToDataTable(Of RpPhieuKeToanDTO)(lst)
        'rp.DataSource = lst
        If File.Exists(getTemplate(lkeTemplate)) Then
            'load template
            rp.LoadLayout(getTemplate(lkeTemplate))
        Else
            Message_Information("Không thấy mẫu báo cáo")
            Return
        End If
        If String.IsNullOrEmpty(txtSoLien.Text) Then
            txtSoLien.Text = "1"
        End If
        Dim view As New Preview(getObjectAll(), rp, Convert.ToDecimal(txtSoLien.Text))
        view.WindowState = System.Windows.Forms.FormWindowState.Maximized
        view.ShowDialog()
    End Sub

    'Load data mac dinh cua he thong
    Private Sub setDefault()
        Dim ts = HtThamsoService.GetByDonviId(Generals.DON_VI.Id)
        If ts.Count > 0 Then
            For Each item In ts
                If item.GiaTri <> Nothing And item.MaThamso = "p_TenCongTy" Then
                    txtCty.Text = item.GiaTri
                ElseIf item.GiaTri <> Nothing And item.MaThamso = "p_DiaChiCongTy" Then
                    txtDCcty.Text = item.GiaTri
                ElseIf item.GiaTri <> Nothing And item.MaThamso = "p_ThuQuy" Then
                    txtThuquy.Text = item.GiaTri
                ElseIf item.GiaTri <> Nothing And item.MaThamso = "p_TieuDe" Then
                    txtTieude.Text = item.GiaTri
                ElseIf item.GiaTri <> Nothing And item.MaThamso = "p_KeToanTruong" Then
                    txtKT.Text = item.GiaTri
                ElseIf item.GiaTri <> Nothing And item.MaThamso = "p_ThuTruongDonVi" Then
                    txtThutruong.Text = item.GiaTri
                ElseIf item.GiaTri <> Nothing And item.MaThamso = "p_KeToanThanhToan" Then
                    txtKTtt.Text = item.GiaTri
                End If
            Next
        End If

        txtKTtt.Text = Generals.USER.Fullname
        'txtThutruong.Text = Generals.DON_VI.GIAM_DOC
        'txtThuquy.Text = Generals.DON_VI.THU_QUY
    End Sub
#End Region

#Region "Event"
    Private Sub frmPhieu_Input_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            InitData()
            'Create sample template
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
    '        Me.Height = 355
    '    Else
    '        PanelControl2.Visible = False
    '        Me.Height = 240
    '    End If
    'End Sub

    'Private Sub rdoNgonngu_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdoNgonngu.SelectedIndexChanged, rdoTienTe.SelectedIndexChanged
    '    fillObjectTemplate()
    'End Sub

    Private Sub txtNguoiNhan_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtNguoiNhan.KeyDown
        If e.KeyCode = Keys.Enter Then
            callReport()
        End If
    End Sub

    Private Sub frmPhieu_Input_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown, txtTieude.KeyDown, txtSoLien.KeyDown, txtSoCtuKem.KeyDown, lkeTemplate.KeyDown
        Select Case e.KeyCode
            Case Keys.Escape
                Me.Close()
                Exit Select
        End Select
    End Sub
#End Region

End Class