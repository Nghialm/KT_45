Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraEditors

Imports Vns.Erp.Core.Accounting.Service.Interface
Imports Vns.Erp.Core.Accounting.Domain
Imports Vns.Erp.Core.Admin.Domain
Imports Vns.Erp.Core.Admin.Service.Interface

Public Class frmChungTuThue

#Region "Property"
    Private _DmThueService As IDmThueService
    Public Property DmThueService As IDmThueService
        Get
            Return _DmThueService
        End Get
        Set(ByVal value As IDmThueService)
            _DmThueService = value
        End Set
    End Property

    Private _CtHoadonService As ICtHoadonService
    Public Property CtHoadonService As ICtHoadonService
        Get
            Return _CtHoadonService
        End Get
        Set(ByVal value As ICtHoadonService)
            _CtHoadonService = value
        End Set
    End Property

    Private _CtThueService As ICtThueService
    Public Property CtThueService As ICtThueService
        Get
            Return _CtThueService
        End Get
        Set(ByVal value As ICtThueService)
            _CtThueService = value
        End Set
    End Property
#End Region

#Region "Variables and Messages"
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
    Private ht_loaiCt As HtLoaichungtu
#End Region

#Region "Load Form"
    Public Sub New()
        InitializeComponent()
        TNCommon.setIconControl(Me)
    End Sub


    Public Function Show_Form(ByVal obj_ct_h As CtH, ByVal sotien As Decimal, ByVal ma_tkthue As String, _
                               ByVal id_tkthue As Guid, ByVal CTD_ID As Guid, ByVal obj_loaiCt As HtLoaichungtu) As Boolean
        Form_SetText(Me, "Chứng từ thuế", DataInputState.NoCaption)
        Form_InitDialog(Me)
        m_obj_ct_h = obj_ct_h
        'm_KHANG_ID = KHANG_ID
        'Dim test As List(Of CtThue) = r_lstobj_ct_thue
        m_CTD_ID = CTD_ID
        m_sotien = sotien
        m_ma_tkthue = ma_tkthue
        m_id_tkthue = id_tkthue
        ht_loaiCt = obj_loaiCt
        frmProgress.Instance.Thread = AddressOf Init_Data
        frmProgress.Instance.Show_Progress()
        Return (Me.ShowDialog = DialogResult.OK)
    End Function
#End Region

#Region "Private Function and Procedures"

    Private Sub Init_Data()
        If m_CTD_ID = Null.NullGuid Then
            BindLookup()
            obj_ct_t.KhangId = m_obj_ct_h.KhangId
            obj_ct_t.TenKhang = m_obj_ct_h.TenKhang
            obj_ct_t.Mst = m_obj_ct_h.MstKhang
            obj_ct_t.NgayHoadon = m_obj_ct_h.NgayCt
            obj_ct_t.DonviId = Generals.DON_VI.Id
            txtTongTienHang.Text = m_sotien
            'txtTongTienHang.EditValue = Format(CLng(txtTongTienHang.Text), "n0")
            obj_ct_t.DoanhSo = m_sotien
            obj_ct_t.MaTaikhoan = m_ma_tkthue
            obj_ct_t.TaikhoanId = m_id_tkthue
            obj_ct_t.NgayTao = DateTime.Now
            obj_ct_t.LoaiTaikhoan = "C"


            txtkhang.Text = m_obj_ct_h.TenKhang
            daeNGAY_HD.DateTime = m_obj_ct_h.NgayCt
            txtMaSoThue.Text = m_obj_ct_h.MstKhang
            If u_objct_ct_hd IsNot Nothing AndAlso Not VnsCheck.IsNullGuid(u_objct_ct_hd.Id) Then
                objct_ct_hd = u_objct_ct_hd
                txtSoSeri.Text = objct_ct_hd.SoSeri
                txtSohoadon.Text = objct_ct_hd.SoHoadon
                txtkhang.Text = objct_ct_hd.TenKhachhang
                daeNGAY_HD.DateTime = objct_ct_hd.NgayHoadon
            End If

            If u_lstobj_ct_thue.Count <> 0 Then
                lstobj_ct_thue = u_lstobj_ct_thue
                del_lstobj_ct_thue = u_del_lstobj_ct_thue
            Else
                lstobj_ct_thue.Add(obj_ct_t)
            End If

            _GridControl.DataSource = lstobj_ct_thue
            ConfigGrid.GridConfig(Me.Name, _GridView.Name, _GridView)
            txtTongTienThue.Text = Convert.ToString(TongSoTienThue())
            'txtTongTienThue.EditValue = Format(CLng(txtTongTienThue.Text), "n0")
        Else
            BindLookup()
            SetObjectToControl()
            txtTongTienHang.Text = m_sotien
            'txtTongTienHang.EditValue = Format(CLng(txtTongTienHang.Text), "n0")
            txtTongTienThue.Text = Convert.ToString(TongSoTienThue())
            'txtTongTienThue.EditValue = Format(CLng(txtTongTienThue.Text), "n0")
        End If
    End Sub

    Private Sub SetObjectToControl()
        If (u_lstobj_ct_thue Is Nothing) Then
            u_lstobj_ct_thue = New List(Of CtThue)
        End If

        If (u_del_lstobj_ct_thue Is Nothing) Then
            u_del_lstobj_ct_thue = New List(Of CtThue)
        End If

        If u_lstobj_ct_thue.Count = 0 And u_del_lstobj_ct_thue.Count = 0 Then
            lstobj_ct_thue = New List(Of CtThue)()
            lstobj_ct_thue.AddRange(_CtThueService.GetObjectAllByCTD_ID(m_CTD_ID))
        ElseIf u_lstobj_ct_thue.Count <> 0 Or u_del_lstobj_ct_thue.Count <> 0 Then
            lstobj_ct_thue = u_lstobj_ct_thue
        End If

        _GridControl.DataSource = lstobj_ct_thue
        If u_objct_ct_hd Is Nothing And lstobj_ct_thue.Count <> 0 Then
            objct_ct_hd = _CtHoadonService.GetById(lstobj_ct_thue(0).CtHoadonId)
            txtSoSeri.Text = objct_ct_hd.SoSeri
            txtSohoadon.Text = objct_ct_hd.SoHoadon
            txtkhang.Text = objct_ct_hd.TenKhachhang
            daeNGAY_HD.DateTime = objct_ct_hd.NgayHoadon
            txtMaSoThue.Text = objct_ct_hd.MaSoThue
        ElseIf u_objct_ct_hd IsNot Nothing Then
            txtSoSeri.Text = u_objct_ct_hd.SoSeri
            txtSohoadon.Text = u_objct_ct_hd.SoHoadon
            txtkhang.Text = u_objct_ct_hd.TenKhachhang
            daeNGAY_HD.DateTime = u_objct_ct_hd.NgayHoadon
            txtMaSoThue.Text = u_objct_ct_hd.MaSoThue
        End If
        ConfigGrid.GridConfig(Me.Name, _GridView.Name, _GridView)
        For Each obj_ct_t As CtThue In lstobj_ct_thue

            obj_ct_t.MaTaikhoan = m_ma_tkthue
            obj_ct_t.TaikhoanId = m_id_tkthue
        Next
    End Sub

    Private Sub GetControlToOBject()
        r_del_lstobj_ct_thue = del_lstobj_ct_thue
        r_lstobj_ct_thue = lstobj_ct_thue

        objct_ct_hd.MaDonvi = Generals.DON_VI.MaDonvi
        objct_ct_hd.MaSoThue = txtMaSoThue.Text
        objct_ct_hd.NgayHoadon = daeNGAY_HD.DateTime
        objct_ct_hd.SoHoadon = txtSohoadon.Text.Trim()
        objct_ct_hd.SoSeri = txtSoSeri.Text.Trim()
        objct_ct_hd.TenKhachhang = txtkhang.Text
        objct_ct_hd.TienThue = txtTongTienThue.Text.Trim()
        objct_ct_hd.DoanhThu = txtTongTienHang.Text.Trim()
        objct_ct_hd.DiaChi = m_obj_ct_h.DiaChi
        objct_ct_hd.DonviId = Generals.DON_VI.Id
        objct_ct_hd.TongTien = Convert.ToDecimal(txtTongTienThue.Text.Trim()) + Convert.ToDecimal(txtTongTienHang.Text.Trim())

        r_objct_ct_hd = objct_ct_hd
    End Sub

    Private Sub BindLookup()
        'Bind danh muc thue
        Dim lstDMThue As List(Of DmThue) = New List(Of DmThue)
        lstDMThue.AddRange(_DmThueService.GetDmThueByabc(ht_loaiCt))
        'ban hang
        'If ht_loaiCt.PhieuXuat = 0 Then
        '    lstDMThue.AddRange(_DmThueService.GetDmThueByabc(0, 0))
        'Else
        '    lstDMThue.AddRange(_DmThueService.GetDmThueByabc(0, 1))
        'End If
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
        obj_ct_t.DoanhSo = m_sotien - Convert.ToDecimal(TongSoTien)
        obj_ct_t.MaTaikhoan = m_ma_tkthue
        obj_ct_t.TaikhoanId = m_id_tkthue
        obj_ct_t.NgayTao = DateTime.Now
        obj_ct_t.LoaiTaikhoan = "C"
        lstobj_ct_thue.Add(obj_ct_t)
        _GridView.RefreshData()

        SetFocus_FirstCell()
    End Sub

    Private Function TongSoTien()
        'tinh tong so tien
        Dim sum As Decimal = 0
        Dim i As Integer
        For i = 0 To _GridView.RowCount - 1
            sum = sum + Convert.ToDecimal(_GridView.GetRowCellValue(i, "DoanhSo"))
        Next

        Return sum
    End Function

    Private Function TongSoTienThue()
        'tinh tong so tien
        Dim sum As Decimal = 0
        Try
            Dim i As Integer
            For i = 0 To _GridView.RowCount - 1
                sum = sum + Convert.ToDecimal(_GridView.GetRowCellValue(i, "SoTien"))
            Next
        Catch ex As Exception
            Message_Error(ex)
        End Try

        Return sum
    End Function

    Private Sub SetFocus_FirstCell()
        _GridView.FocusedRowHandle = _GridView.RowCount - 1
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
            TongSoTien()
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

        If String.IsNullOrEmpty(txtSoSeri.Text.Trim()) Then
            Message_Warning("Bạn chưa nhập số seri")
            txtSoSeri.Focus()
            Return False
        End If

        If String.IsNullOrEmpty(txtSohoadon.Text.Trim()) Then
            Message_Warning("Bạn chưa nhập số hóa đơn")
            txtSohoadon.Focus()
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

    Private Sub btnLuu_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnOke.Click
        Try
            If Not Check_input() Then
                Return
            End If

            For Each ctThueInfo As CtThue In lstobj_ct_thue
                ctThueInfo.SoSeri = txtSoSeri.Text.Trim
                ctThueInfo.KyHieuHd = txtSohoadon.Text.Trim
                ctThueInfo.TenKhang = txtkhang.Text
            Next

            tongtienthue = TongSoTienThue()
                GetControlToOBject()
                Duoc_Xac_Nhan = True
                If Convert.ToDecimal(TongSoTien()) < m_sotien Or Convert.ToDecimal(TongSoTien()) > m_sotien Then
                    Message_Information("Giá trị tiền hàng VND nhập vào không hợp lệ")
                    Return
                End If
                DialogResult = DialogResult.OK
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub DeleteRow()
        If _GridView.RowCount > 0 Then
            Dim gridctdthue As CtThue = CType(_GridView.GetRow(_GridView.FocusedRowHandle), CtThue)
            del_lstobj_ct_thue.Add(gridctdthue)
            _GridView.DeleteSelectedRows()
            txtTongTienThue.Text = Convert.ToString(TongSoTienThue())
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
        Try
            Try
                Dim obj As CtThue = CType(_GridView.GetRow(_GridView.FocusedRowHandle), CtThue)
                Select Case e.Column.FieldName
                    Case "ThueId"
                        Dim dmThue As DmThue = CType(cboDM_Thue.GetDataSourceRowByKeyValue(obj.ThueId), DmThue)
                        If (obj Is Nothing) Then
                            Return
                        End If
                        'Gan vao GridView
                        obj.TenThue = dmThue.TenThue
                        _GridView.SetRowCellValue(_GridView.FocusedRowHandle, "TyLe", dmThue.TyLe)
                        
                    Case "TyLe"
                        Dim so_tien As Decimal = obj.DoanhSo

                        If (m_sotien < Convert.ToDecimal(TongSoTien)) Then
                            obj.DoanhSo = m_sotien - (Convert.ToDecimal(TongSoTien) - so_tien)
                            '_GridView.SetRowCellValue(_GridView.FocusedRowHandle, "DoanhSo", _
                            '                           m_sotien - (Convert.ToDecimal(TongSoTien) - so_tien))
                            'Message_Information("Số tiền vượt quá mức cho phép")
                            Return
                        End If

                        Dim ty_le As Decimal = obj.TyLe

                        Dim chiuthue As Decimal = obj.TyLe * obj.DoanhSo / 100
                        Dim chiu_thue = Math.Round(chiuthue, 0, MidpointRounding.AwayFromZero)

                        'If chiuthue > chiu_thue Then
                        '    chiu_thue = chiu_thue + 1
                        'End If
                        '_GridView.SetRowCellValue(_GridView.FocusedRowHandle, "SoTien", chiu_thue)
                        obj.SoTien = chiu_thue

                    Case "DoanhSo"
                        Dim so_tien As Decimal = obj.DoanhSo
                        If (m_sotien < Convert.ToDecimal(TongSoTien)) Then
                            _GridView.SetRowCellValue(_GridView.FocusedRowHandle, "DoanhSo", _
                                                       m_sotien - (Convert.ToDecimal(TongSoTien) - so_tien))
                            Message_Information("Số tiền vượt quá mức cho phép")
                            Return
                        End If

                        Dim ty_le As Decimal = obj.TyLe
                        Dim chiuthue As Decimal = obj.TyLe * obj.DoanhSo / 100
                        Dim chiu_thue = Math.Round(chiuthue, 0, MidpointRounding.AwayFromZero)

                        'If chiuthue > chiu_thue Then
                        '    chiu_thue = chiu_thue + 1
                        'End If
                        '_GridView.SetRowCellValue(_GridView.FocusedRowHandle, "SoTien", chiu_thue)
                        obj.SoTien = chiu_thue
                    Case "DonGia", "SoLuong"
                        obj.DoanhSo = obj.SoLuong * obj.DonGia
                        If obj.TyLe = 0 Then
                            obj.SoTien = 0
                        Else
                            Dim chiu_thue = Math.Round(obj.DoanhSo / obj.TyLe, 0, MidpointRounding.AwayFromZero)
                            obj.SoTien = chiu_thue
                        End If
                End Select
                txtTongTienThue.Text = Convert.ToString(TongSoTienThue())
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
                        TongSoTien()
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
                    TongSoTien()
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

End Class