Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraEditors

Imports Vns.Erp.Core.Accounting.Domain
Imports Vns.Erp.Core.Accounting.Service.Interface
Imports Vns.Erp.Core.Admin.Domain
Imports Vns.Erp.Core.Admin.Service.Interface

Public Class frmChungTuThue2

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

#End Region

#Region "Variables and Messages"
    Private obj_ct_t As CtThue = New CtThue()
    Private m_obj_ct_d As Extend.CT_D_KInfo = New Extend.CT_D_KInfo()

    ''' Gia tri duoc sua
    Public n_obj_ct_d As Extend.CT_D_KInfo = New Extend.CT_D_KInfo()

    Private m_sotien As Decimal
    Private m_ngayCT As DateTime
    Private obj_Khang As DmKhang = New DmKhang
    Private lstobj_ct_thue As List(Of CtThue) = New List(Of CtThue)
    Private objct_ct_hd As CtHoadon = New CtHoadon
    Private del_lstobj_ct_thue As List(Of CtThue) = New List(Of CtThue)
    Public Duoc_Xac_Nhan As Boolean = False
    Private flagThue As Boolean
#End Region

#Region "Load Form"
    Public Sub New()
        InitializeComponent()
        TNCommon.setIconControl(Me)
    End Sub


    Public Function Show_Form(ByVal obj_ct_d As Extend.CT_D_KInfo, ByVal sotien As Decimal, ByVal NgayCT As DateTime, ByVal Thue As Boolean) As Extend.CT_D_KInfo
        Form_SetText(Me, "Chứng từ thuế", DataInputState.NoCaption)
        Form_InitDialog(Me)
        n_obj_ct_d = obj_ct_d
        m_obj_ct_d = obj_ct_d.Clone()
        m_sotien = sotien
        m_ngayCT = NgayCT
        flagThue = Thue
        frmProgress.Instance.Thread = AddressOf Init_Data
        frmProgress.Instance.Show_Progress()
        If (Me.ShowDialog = DialogResult.OK) Then
            Return n_obj_ct_d
        Else
            Return m_obj_ct_d
        End If
    End Function
#End Region

#Region "Private Function and Procedures"

    Private Sub Init_Data()
        BindLookup()
        If m_obj_ct_d.LstCtThue Is Nothing Then
            m_obj_ct_d.LstCtThue = New List(Of CtThue)
            obj_ct_t.DoanhSo = m_sotien
            obj_ct_t.NgayTao = DateTime.Now
            obj_ct_t.MaTaikhoan = m_obj_ct_d.MA_TK
            obj_ct_t.TaikhoanId = m_obj_ct_d.TK_ID
            obj_ct_t.NgayHoadon = m_ngayCT
            obj_ct_t.LoaiTaikhoan = "C"
            obj_ct_t.DonviId = Generals.DON_VI.Id

            obj_ct_t.TenKhang = m_obj_ct_d.TEN_KHANG

            lstobj_ct_thue.Add(obj_ct_t)
        ElseIf m_obj_ct_d.LstCtThue.Count = 0 Then
            obj_ct_t.DoanhSo = m_sotien
            obj_ct_t.NgayTao = DateTime.Now
            obj_ct_t.MaTaikhoan = m_obj_ct_d.MA_TK
            obj_ct_t.TaikhoanId = m_obj_ct_d.TK_ID
            obj_ct_t.NgayHoadon = m_ngayCT
            obj_ct_t.LoaiTaikhoan = "C"
            obj_ct_t.DonviId = Generals.DON_VI.Id
            obj_ct_t.TenKhang = m_obj_ct_d.TEN_KHANG

            lstobj_ct_thue.Add(obj_ct_t)
        Else
            lstobj_ct_thue = m_obj_ct_d.LstCtThue
        End If

        If m_obj_ct_d.CT_HOADON IsNot Nothing Then
            objct_ct_hd = m_obj_ct_d.CT_HOADON
            txtSoSeri.Text = objct_ct_hd.SoSeri
            txtSohoadon.Text = objct_ct_hd.SoHoadon
            txtkhang.Text = objct_ct_hd.TenKhachhang
            daeNGAY_HD.DateTime = objct_ct_hd.NgayHoadon
            txtkhang.Text = objct_ct_hd.TenKhachhang
        Else

            daeNGAY_HD.DateTime = m_ngayCT
            txtkhang.Text = n_obj_ct_d.TEN_KHANG
        End If

        _GridControl.DataSource = lstobj_ct_thue
        txtTongTienThue.Text = m_sotien
        'txtTongTienThue.EditValue = Format(CLng(txtTongTienThue.Text), "n0")
        txtTongTienHang.Text = Convert.ToString(TongSoTien())
        'txtTongTienHang.EditValue = Format(CLng(txtTongTienHang.Text), "n0")
        'SetFocus_FirstCell()
    End Sub

    Private Sub GetControlToOBject()

        If m_obj_ct_d.LstCtThue Is Nothing Then
            m_obj_ct_d.LstCtThue = New List(Of CtThue)
        End If

        If m_obj_ct_d.LstDelCtThue Is Nothing Then
            m_obj_ct_d.LstDelCtThue = New List(Of CtThue)
        End If

        If m_obj_ct_d.CT_HOADON Is Nothing Then
            m_obj_ct_d.CT_HOADON = New CtHoadon()
        End If

        m_obj_ct_d.LstCtThue = lstobj_ct_thue
        For Each ctThueInfo As CtThue In del_lstobj_ct_thue
            m_obj_ct_d.LstDelCtThue.Add(ctThueInfo)
        Next

        objct_ct_hd.MaDonvi = Generals.DON_VI.MaDonvi
        objct_ct_hd.NgayHoadon = daeNGAY_HD.DateTime
        objct_ct_hd.SoHoadon = txtSohoadon.Text.Trim()
        objct_ct_hd.SoSeri = txtSoSeri.Text.Trim()
        objct_ct_hd.TenKhachhang = txtkhang.Text.Trim()
        objct_ct_hd.TienThue = txtTongTienThue.Text.Trim()
        objct_ct_hd.DoanhThu = txtTongTienHang.Text.Trim()
        'objct_ct_hd.DIA_CHI = m_obj_ct_h.DIA_CHI
        objct_ct_hd.DonviId = Generals.DON_VI.Id
        objct_ct_hd.TongTien = Convert.ToDecimal(txtTongTienThue.Text.Trim()) + Convert.ToDecimal(txtTongTienHang.Text.Trim())
        objct_ct_hd.MaSoThue = txtMaSoThue.Text
        m_obj_ct_d.CT_HOADON = objct_ct_hd
    End Sub

    Private Sub BindLookup()
        'Bind danh muc thue
        Dim lstDMThue As List(Of DmThue) = New List(Of DmThue)
        'lstDMThue.AddRange(_DmThueService.GetAll())
        'ban hang = false
        If Not flagThue Then
            lstDMThue.AddRange(_DmThueService.GetDmThueByabc(0, 0))
        Else
            lstDMThue.AddRange(_DmThueService.GetDmThueByabc(0, 1))
        End If
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

        obj_ct_t.DonviId = Generals.DON_VI.Id
        obj_ct_t.SoTien = m_sotien - Convert.ToDecimal(TongSoTienThue())
        obj_ct_t.MaTaikhoan = m_obj_ct_d.MA_TK
        obj_ct_t.TaikhoanId = m_obj_ct_d.TK_ID
        obj_ct_t.NgayTao = DateTime.Now
        obj_ct_t.NgayHoadon = m_ngayCT
        obj_ct_t.LoaiTaikhoan = "C"
        lstobj_ct_thue.Add(obj_ct_t)
        _GridView.RefreshData()
        SetFocus_FirstCell()
    End Sub

    Private Function TongSoTien() As Decimal
        'tinh tong so tien
        Dim sum As Decimal = 0
        Dim i As Integer
        For i = 0 To _GridView.RowCount - 1
            sum = sum + _GridView.GetRowCellValue(i, "DoanhSo")
        Next

        Return sum
    End Function

    Private Function TongSoTienThue() As Decimal
        'tinh tong so tien
        Dim sum As Decimal = 0
        Dim i As Integer
        For i = 0 To _GridView.RowCount - 1
            sum = sum + _GridView.GetRowCellValue(i, "SoTien")
        Next
        Return sum
    End Function

    Private Sub SetFocus_FirstCell()
        _GridView.FocusedRowHandle = _GridView.RowCount - 1
        _GridView.SelectRow(Handle)
        If _GridView.RowCount <> 0 Then
            _GridView.FocusedColumn = _GridView.VisibleColumns(0)
        End If
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

    Private Function check_sotien() As Boolean

        For Each obj As CtThue In lstobj_ct_thue
            If Not LimitValue.CheckQuantity(obj.SoLuong) Then
                Message_Warning("Giá trị số lượng không hợp lệ")
                Return False
            End If

            If Not LimitValue.CheckVNDCurrency(obj.DoanhSo) Then
                Message_Warning("Giá trị số tiền hàng không hợp lệ")
                Return False
            End If

            If obj.TyLe <= 0 And obj.TyLe > 100 Then
                Message_Warning("Giá trị tỷ lệ thuế không hợp lệ")
                Return False
            End If

            If Not LimitValue.CheckVNDCurrency(obj.SoTien) Then
                Message_Warning("Giá trị số tiền thuế không hợp lệ")
                Return False
            End If
        Next

        Return True
    End Function

    Private Sub btnLuu_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnOke.Click
        Try
            If String.IsNullOrEmpty(txtSoSeri.Text.Trim()) Then
                Message_Warning("Bạn chưa nhập số seri")
                txtSoSeri.Focus()
                Return
            End If

            If String.IsNullOrEmpty(txtSohoadon.Text.Trim()) Then
                Message_Warning("Bạn chưa nhập số hóa đơn")
                txtSohoadon.Focus()
                Return
            End If
            
            If _GridView.RowCount = 0 Then
                Message_Warning("Bạn chưa nhập chi tiết thuế!")
                Return
            End If

            For Each ctThueInfo As CtThue In lstobj_ct_thue
                ctThueInfo.SoSeri = txtSoSeri.Text.Trim()
                ctThueInfo.KyHieuHd = txtSohoadon.Text.Trim()
                ctThueInfo.TenKhang = txtkhang.Text.Trim
            Next

            If Not check_sotien() Then
                Return
            End If

            GetControlToOBject()
            'tongtienthue = TongSoTienThue()

            If Convert.ToDecimal(TongSoTienThue()) <> m_sotien And _GridView.RowCount <> 0 Then
                Message_Information("Số tiền thuế không hợp lệ")
                Return
            Else
                n_obj_ct_d.LstCtThue = m_obj_ct_d.LstCtThue
                n_obj_ct_d.LstDelCtThue = m_obj_ct_d.LstDelCtThue
                n_obj_ct_d.CT_HOADON = m_obj_ct_d.CT_HOADON
                Duoc_Xac_Nhan = True
                DialogResult = DialogResult.OK
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
            'TongSoTien()
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
            Dim obj As CtThue = CType(_GridView.GetRow(_GridView.FocusedRowHandle), CtThue)
            If obj Is Nothing Then
                Return
            End If
            Select Case e.Column.FieldName
                Case "ThueId"
                    Dim dmThue As DmThue = CType(cboDM_Thue.GetDataSourceRowByKeyValue(obj.ThueId), DmThue)
                    If (obj Is Nothing) Then
                        Return
                    End If
                    'Gan vao GridView
                    _GridView.SetRowCellValue(_GridView.FocusedRowHandle, "TyLe", dmThue.TyLe)
                    obj.TenThue = dmThue.TenThue
                Case "TyLe"
                    Try
                        obj.SoTien = obj.TyLe * obj.DoanhSo / 100
                    Catch ex As OverflowException
                        Message_Warning("Giá trị số tiền nhập vào không hợp lệ")
                    End Try

                Case "DoanhSo"
                    Try
                        obj.SoTien = obj.TyLe * obj.DoanhSo / 100
                    Catch ex As OverflowException
                        Message_Warning("Giá trị số tiền nhập vào không hợp lệ")
                    End Try
                Case "DonGia", "SoLuong"
                    obj.DoanhSo = obj.SoLuong * obj.DonGia
                    If obj.TyLe = 0 Then
                        obj.SoTien = 0
                    Else
                        obj.SoTien = obj.DoanhSo / obj.TyLe
                    End If
            End Select

            txtTongTienHang.Text = Convert.ToString(TongSoTien())
            txtTongTienThue.Text = Convert.ToString(TongSoTienThue())
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub _GridView_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles _GridView.KeyDown
        Try
            Select Case e.KeyCode
                Case Keys.Enter
                    If (GridHelper.CheckAddNewRow(_GridView)) Then
                        AddRow()
                        TongSoTien()
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
                    Exit Select

                Case Keys.F8
                    DeleteRow()
                    Exit Select
            End Select
            txtTongTienHang.Text = TongSoTien().ToString
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub _GridView_ValidatingEditor(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs) Handles _GridView.ValidatingEditor
        Try
            Select Case _GridView.FocusedColumn.Name
                Case "TyLe"
                    If e.Value Is Nothing Then
                        Return
                    End If
                    If (Convert.ToInt32(e.Value) < 0) Or (Convert.ToInt32(e.Value) > 100) Then
                        e.Valid = False
                        e.ErrorText = "Tỷ lệ phải lớn hơn 0 và nhỏ hơn 100"
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