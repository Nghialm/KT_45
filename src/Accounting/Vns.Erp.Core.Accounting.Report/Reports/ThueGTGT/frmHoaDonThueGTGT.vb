Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraEditors

Imports Vns.Erp.Core.Accounting.Service.Interface
Imports Vns.Erp.Core.Accounting.Domain
Imports Vns.Erp.Core.Admin.Domain
Imports Vns.Erp.Core.Admin.Service.Interface

Public Class frmHoaDonThueGTGT

#Region "Property"
    Private _DmThueService As IDmThueService
    Public Property DmThueService() As IDmThueService
        Get
            Return _DmThueService
        End Get
        Set(ByVal value As IDmThueService)
            _DmThueService = value
        End Set
    End Property

    Private _CtHoadonService As ICtHoadonService
    Public Property CtHoadonService() As ICtHoadonService
        Get
            Return _CtHoadonService
        End Get
        Set(ByVal value As ICtHoadonService)
            _CtHoadonService = value
        End Set
    End Property

    Private _CtThueService As ICtThueService
    Public Property CtThueService() As ICtThueService
        Get
            Return _CtThueService
        End Get
        Set(ByVal value As ICtThueService)
            _CtThueService = value
        End Set
    End Property
#End Region

#Region "Variables and Messages"
    Private _CtHoaDon As CtHoadon
    Public Property CtHoaDon() As CtHoadon
        Get
            Return _CtHoaDon
        End Get
        Set(ByVal value As CtHoadon)
            _CtHoaDon = value
        End Set
    End Property

    Private _LstCtThue As IList(Of CtThue)
    Public Property LstCtThue() As IList(Of CtThue)
        Get
            Return _LstCtThue
        End Get
        Set(ByVal value As IList(Of CtThue))
            _LstCtThue = value
        End Set
    End Property

    Private obj_ct_t As CtThue = New CtThue()
    Private m_obj_ct_h As CtH = New CtH()
    Private m_KHANG_ID As String
    Private m_sotien As Decimal
    Private m_ma_tkthue As String
    Private m_id_tkthue As Guid
    Private m_CTD_ID As Guid
    Private obj_Khang As DmKhang = New DmKhang
    'Private lstobj_ct_d As List(Of CT_DInfo) = New List(Of CT_DInfo)
    'List add vao luoi
    Public lstobj_ct_thue As List(Of CtThue) = New List(Of CtThue)
    'List xoa khi thao tac tren form
    Public del_lstobj_ct_thue As List(Of CtThue) = New List(Of CtThue)
    Public Duoc_Xac_Nhan As Boolean = False
    Public tongtienthue As Decimal
    'Thuoc tinh khi cap nhat xong tra ve form ngoai
    Public r_lstobj_ct_thue As List(Of CtThue) = New List(Of CtThue)
    'Thuoc tinh khi cap nhat xong tra ve form ngoai
    Public r_del_lstobj_ct_thue As List(Of CtThue) = New List(Of CtThue)
    'List truyen du lieu tu form ngoai
    Public u_lstobj_ct_thue As List(Of CtThue)
    'List xoa du lieu, truyen tu ngoai
    Public u_del_lstobj_ct_thue As List(Of CtThue)
    Public objct_ct_hd As CtHoadon = New CtHoadon
    'List xoa du lieu, truyen tu ngoai
    Public u_objct_ct_hd As CtHoadon
    'Thuoc tinh khi cap nhat xong tra ve form ngoai
    Public r_objct_ct_hd As CtHoadon

    Private OnLoad As Boolean = False
#End Region

#Region "Load Form"
    Public Sub New()
        InitializeComponent()
        TNCommon.setIconControl(Me)
    End Sub


    Public Function Show_Form() As Boolean
        Form_SetText(Me, "Chứng từ thuế", DataInputState.NoCaption)
        Form_InitDialog(Me)
        frmProgress.Instance.Thread = AddressOf Init_Data
        frmProgress.Instance.Show_Progress()
        Return (Me.ShowDialog = DialogResult.OK)
    End Function
#End Region

#Region "Private Function and Procedures"

    Private Sub Init_Data()
        BindLookup()
        SetObjectToControl()
        ConfigGrid.GridConfig(Me.Name, _GridView.Name, _GridView)
    End Sub

    Private Sub SetObjectToControl()
        'Header
        OnLoad = True
        txtNGAY_HD.EditValue = _CtHoaDon.NgayHoadon
        txtSohoadon.Text = _CtHoaDon.SoHoadon
        txtSoSeri.Text = _CtHoaDon.SoSeri
        txtkhang.Text = _CtHoaDon.TenKhachhang
        txtMaSoThue.Text = _CtHoaDon.MaSoThue
        txtDiaChi.Text = _CtHoaDon.DiaChi
        txtHinhThucTT.Text = _CtHoaDon.HinhThucTT
        txtSoTaiKhoanNh.Text = _CtHoaDon.SoTaiKhoanNh

        txtTongTienHang.Text = _CtHoaDon.DoanhThu
        txtTongTienThue.Text = _CtHoaDon.TienThue
        txtDienGiai.Text = _CtHoaDon.DienGiai
        'Detail
        _GridControl.DataSource = _LstCtThue
        lstobj_ct_thue = _LstCtThue

        TinhTong()
        ConfigGrid.GridConfig(Me.Name, _GridView.Name, _GridView)
        OnLoad = False
    End Sub

    Private Sub GetControlToOBject()
        _CtHoaDon.NgayHoadon = txtNGAY_HD.EditValue
        _CtHoaDon.SoHoadon = txtSohoadon.Text
        _CtHoaDon.SoSeri = txtSoSeri.Text
        _CtHoaDon.TenKhachhang = txtkhang.Text
        _CtHoaDon.MaSoThue = txtMaSoThue.Text
        _CtHoaDon.DiaChi = txtDiaChi.Text
        _CtHoaDon.HinhThucTT = txtHinhThucTT.Text
        _CtHoaDon.SoTaiKhoanNh = txtSoTaiKhoanNh.Text
        _CtHoaDon.TienThue = txtTongTienThue.EditValue
        _CtHoaDon.DoanhThu = txtTongTienHang.EditValue
        _CtHoaDon.TongTien = _CtHoaDon.TienThue + _CtHoaDon.DoanhThu
        _CtHoaDon.DonviId = Generals.DON_VI.Id
        _CtHoaDon.DienGiai = txtDienGiai.Text

        r_del_lstobj_ct_thue = del_lstobj_ct_thue
        r_lstobj_ct_thue = lstobj_ct_thue

        r_objct_ct_hd = objct_ct_hd
    End Sub

    Private Function ValidateCTThue(ByVal lstobj_ct_thue As List(Of CtThue)) As Boolean
        For Each objctthue As CtThue In lstobj_ct_thue
            If String.IsNullOrEmpty(objctthue.SoSeri) Or String.IsNullOrEmpty(objctthue.KyHieuHd) Then
                Return False
            End If
        Next
        Return True
    End Function

    Private Sub BindLookup()
        'Bind danh muc thue
        Dim lstDMThue As List(Of DmThue) = _DmThueService.GetAll
        cboDM_Thue.DataSource = lstDMThue
        cboDM_Thue.DisplayMember = "TenThue"
        cboDM_Thue.ValueMember = "Id"
        cboDM_Thue.Columns.Add(New LookUpColumnInfo("KyHieu", "Ký hiệu"))
        cboDM_Thue.Columns.Add(New LookUpColumnInfo("TenThue", "Tên thuế"))
    End Sub

    Private Sub AddRow()

        obj_ct_t = New CtThue
        obj_ct_t.SoSeri = txtSoSeri.Text.Trim()
        obj_ct_t.KyHieuHd = txtSohoadon.Text.Trim()

        obj_ct_t.KhangId = m_obj_ct_h.KhangId
        obj_ct_t.TenKhang = m_obj_ct_h.TenKhang
        obj_ct_t.Mst = m_obj_ct_h.MstKhang
        'obj_ct_t.DIA_CHI = m_obj_ct_h.DIA_CHI
        obj_ct_t.DonviId = Generals.DON_VI.Id
        obj_ct_t.NgayHoadon = m_obj_ct_h.NgayCt
        obj_ct_t.DoanhSo = 0
        obj_ct_t.MaTaikhoan = m_ma_tkthue
        obj_ct_t.TaikhoanId = m_id_tkthue
        obj_ct_t.NgayTao = DateTime.Now
        obj_ct_t.LoaiTaikhoan = "C"
        lstobj_ct_thue.Add(obj_ct_t)
        _GridView.RefreshData()
    End Sub

    Private Sub TinhTong()
        'tinh tong so tien
        Dim DoanhThu As Decimal = 0
        Dim Thue As Decimal = 0
        For Each tmp As CtThue In lstobj_ct_thue
            DoanhThu = DoanhThu + tmp.DoanhSo
            Thue = Thue + tmp.SoTien
        Next

        txtTongTienHang.EditValue = DoanhThu
        txtTongTienThue.EditValue = Thue
    End Sub

    Private Sub SetFocus_FirstCell()
        _GridView.FocusedRowHandle = 0
        _GridView.SelectRow(Handle)
        Try
            _GridView.FocusedColumn = _GridView.VisibleColumns(0)
        Catch ex As Exception

        End Try

    End Sub


#End Region

#Region "Events"
    Private Sub btnAdd_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnRow.Click
        Try
            AddRow()
            TinhTong()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub btnClose_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnQuit.Click
        Try
            Me.Close()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Function Check_input() As Boolean

        If String.IsNullOrEmpty(txtSoSeri.Text.Trim()) Or String.IsNullOrEmpty(txtSohoadon.Text.Trim()) Then
            Message_Information("Chưa nhập đầy đủ thông tin Số Seri và Số hóa đơn")
            Return False
        End If

        If lstobj_ct_thue.Count <> 0 Then
            For Each ctThueInfo As CtThue In lstobj_ct_thue

                If Not LimitValue.CheckVNDCurrency(ctThueInfo.DoanhSo) Then
                    Message_Warning("Giá trị tiền hàng VND không hợp lệ")
                    Return False
                End If

                If Not LimitValue.CheckQuantity(ctThueInfo.SoLuong) Or ctThueInfo.SoLuong = 0 Then
                    Message_Warning("Giá trị số lượng không hợp lệ!")
                    Return False
                End If

                If Not LimitValue.CheckTaxRate(ctThueInfo.TyLe) Then
                    Message_Warning("Tỷ lệ phải nằm trong khoảng (0,100]!")
                    Return False
                End If

                If Not LimitValue.CheckVNDCurrency(ctThueInfo.SoTien) Then
                    Message_Warning("Giá trị số tiền thuế không hợp lệ!")
                    Return False
                End If
            Next
        Else
            Message_Warning("Bạn chưa nhập chi tiết thuế")
            Return False
        End If

        Return True
    End Function

    Private Sub btnLuu_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSave.Click
        Try
            If Not Check_input() Then
                Return
            End If

            For Each ctThueInfo As CtThue In lstobj_ct_thue
                ctThueInfo.SoSeri = txtSoSeri.Text.Trim
                ctThueInfo.KyHieuHd = txtSohoadon.Text.Trim
                ctThueInfo.TenKhang = txtkhang.Text
            Next

            If ValidateCTThue(lstobj_ct_thue) Then

                TinhTong()
                GetControlToOBject()
                Duoc_Xac_Nhan = True

                _CtHoadonService.SaveHoaDonThueGTGT(_CtHoaDon, lstobj_ct_thue, del_lstobj_ct_thue)

                DialogResult = DialogResult.OK
            Else
                Message_Warning("Chi tiết định khoản chưa nhập đủ")
                Return
            End If
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub DeleteRow()
        If _GridView.RowCount > 0 Then
            Dim gridctdthue As CtThue = CType(_GridView.GetRow(_GridView.FocusedRowHandle), CtThue)
            del_lstobj_ct_thue.Add(gridctdthue)
            _GridView.DeleteSelectedRows()
            TinhTong()
        Else
            Message_Warning("Không tồn tại bản ghi nào!")
        End If

    End Sub

    Private Sub btnDelete_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnDeRow.Click
        Try
            DeleteRow()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub _GridView_CellValueChanged(ByVal sender As Object, ByVal e As CellValueChangedEventArgs) Handles _GridView.CellValueChanged
        If OnLoad Then
            Return
        End If
        Try
            Try
                Dim obj As CtThue = CType(_GridView.GetRow(_GridView.FocusedRowHandle), CtThue)
                Select Case e.Column.Name
                    Case "THUE_ID"
                        Dim dmThue As DmThue = CType(cboDM_Thue.GetDataSourceRowByKeyValue(obj.ThueId), DmThue)
                        If (obj Is Nothing) Then
                            Return
                        End If
                        'Gan vao GridView
                        obj.TyLe = dmThue.TyLe
                    Case "TY_LE"
                        Dim chiuthue As Decimal = obj.TyLe * obj.DoanhSo / 100
                        Dim chiu_thue = Math.Round(chiuthue, 0, MidpointRounding.AwayFromZero)

                        If chiuthue > chiu_thue Then
                            chiu_thue = chiu_thue + 1
                        End If
                        obj.SoTien = chiuthue
                    Case "DOANH_SO"
                        Dim chiuthue As Decimal = obj.TyLe * obj.DoanhSo / 100
                        Dim chiu_thue = Math.Round(chiuthue, 0, MidpointRounding.AwayFromZero)

                        If chiuthue > chiu_thue Then
                            chiu_thue = chiu_thue + 1
                        End If
                        obj.SoTien = chiuthue
                End Select
                TinhTong()
            Catch ex As OverflowException
                Message_Warning("Lỗi tràn số!")
            End Try
        Catch ex As Exception
            Message_Error(ex)
        End Try

    End Sub

    Private Sub _GridView_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles _GridView.KeyDown
        Try
            Select Case e.KeyCode
                Case Keys.Enter
                    If (Vns.Erp.Core.GridHelper.CheckAddNewRow(_GridView)) Then
                        AddRow()
                        TinhTong()
                    End If
                Case Keys.F12
                    Dim FormID As String = Me.Name
                    Dim lstColInfo As List(Of ColInfo) = New List(Of ColInfo)
                    ConfigGrid.GetGridColInfo(_GridView, lstColInfo)
                    Dim f As New ConfigGrid
                    If f.Show_Form(_GridView.Name, FormID, lstColInfo) Then
                        ConfigGrid.GridConfig(FormID, _GridView.Name, _GridView)
                    End If
            End Select

        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub frmChungTuThue_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles MyBase.KeyDown
        Try
            Select Case e.KeyCode
                Case Keys.Escape
                    Me.Close()
                    Exit Select

                Case Keys.F4
                    AddRow()
                    TinhTong()
                    Exit Select

                Case Keys.F8
                    DeleteRow()
                    Exit Select
            End Select
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub _GridView_ValidatingEditor(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs) Handles _GridView.ValidatingEditor
        Try
            Select Case _GridView.FocusedColumn.Name
                Case "TY_LE"
                    If (Decimal.Parse(e.Value) < 0) Or (Decimal.Parse(e.Value) > 100) Then
                        e.Valid = False
                        e.ErrorText = "Tỷ lệ thuế phải nằm trong khoảng [0,100]"
                    End If
                Case Else
                    Exit Sub
            End Select
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub
#End Region

    Private Sub txtkhang_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtkhang.Validating
        Dim tmp As String = txtkhang.Text
        If (tmp.Count > 110) Then
            ErrorProviderHelper.SetError(Erp, "Tên quá dài", txtkhang)
        Else
            ErrorProviderHelper.SetError(Erp, "", txtkhang)
        End If
    End Sub

    Private Sub txtDiaChi_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtDiaChi.Validating
        Dim tmp As String = txtDiaChi.Text
        If (tmp.Count > 110) Then
            ErrorProviderHelper.SetError(Erp, "Tên quá dài", txtDiaChi)
        Else
            ErrorProviderHelper.SetError(Erp, "", txtDiaChi)
        End If
    End Sub
End Class