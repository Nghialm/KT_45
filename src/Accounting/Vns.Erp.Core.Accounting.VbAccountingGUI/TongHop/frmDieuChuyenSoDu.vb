Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraGrid.Views.Grid

Imports Vns.Erp.Core.Admin.Domain
Imports Vns.Erp.Core.Accounting.Domain
Imports Vns.Erp.Core.Admin.Service.Interface
Imports Vns.Erp.Core.Accounting.Service.Interface
Public Class frmDieuChuyenSoDu
#Region "Property"
    Private _HtSoChungtuMaxService As IHtSoChungtuMaxService
    Public Property HtSoChungtuMaxService As IHtSoChungtuMaxService
        Get
            Return _HtSoChungtuMaxService
        End Get
        Set(ByVal value As IHtSoChungtuMaxService)
            _HtSoChungtuMaxService = value
        End Set
    End Property
    Private _DmNgoaiteService As IDmNgoaiteService
    Public Property DmNgoaiteService As IDmNgoaiteService
        Get
            Return _DmNgoaiteService
        End Get
        Set(ByVal value As IDmNgoaiteService)
            _DmNgoaiteService = value
        End Set
    End Property

    Private _KtKhoasoThangService As IKtKhoasoThangService
    Public Property KtKhoasoThangService As IKtKhoasoThangService
        Get
            Return _KtKhoasoThangService
        End Get
        Set(ByVal value As IKtKhoasoThangService)
            _KtKhoasoThangService = value
        End Set
    End Property

    Private _CtHService As ICtHService
    Public Property CtHService As ICtHService
        Get
            Return _CtHService
        End Get
        Set(ByVal value As ICtHService)
            _CtHService = value
        End Set
    End Property

    Dim _DmBtKetchuyenService As IDmBtKetchuyenService
    Public Property DmBtKetchuyenService() As IDmBtKetchuyenService
        Get
            Return _DmBtKetchuyenService
        End Get
        Set(ByVal value As IDmBtKetchuyenService)
            _DmBtKetchuyenService = value
        End Set
    End Property

    Private _DmTaikhoanService As IDmTaikhoanService
    Public Property DmTaikhoanService As IDmTaikhoanService
        Get
            Return _DmTaikhoanService
        End Get
        Set(ByVal value As IDmTaikhoanService)
            _DmTaikhoanService = value
        End Set
    End Property

    Private _HtLoaichungtuService As IHtLoaichungtuService
    Public Property HtLoaichungtuService As IHtLoaichungtuService
        Get
            Return _HtLoaichungtuService
        End Get
        Set(ByVal value As IHtLoaichungtuService)
            _HtLoaichungtuService = value
        End Set
    End Property
#End Region
    Private DMBTKC As String
    Private dtChiTietKC As DataTable = New DataTable()
    Private loaiKC As Integer
    Dim gridBTKC As DmBtKetchuyen
    Dim msgKhoaSo As String = "Tháng được chọn đã khóa sổ nên không thể tính kết chuyển"
    Private selection As GridCheckMarksSelection
    Public obj_loaichungtu As HtLoaichungtu = New HtLoaichungtu()
    Private lstobjctd As List(Of CtD)
    Private lstTmpDmTaikhoan As IList(Of DmTaikhoan) = New List(Of DmTaikhoan)()


    Public Sub New()
        InitializeComponent()
        TNCommon.setIconControl(Me)
    End Sub

    Private Sub frmButToanKetChuyen_DanhSach_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            txtNam.Text = Year(DateTime.Today).ToString

            Dim lstTKCO As List(Of DmTaikhoan) = New List(Of DmTaikhoan)
            lstTKCO.AddRange(_DmTaikhoanService.GetAllByDonviID(Generals.DON_VI.Id))
            cboMATKCO.DataSource = lstTKCO
            cboMATKCO.DisplayMember = "MaTaikhoan"
            cboMATKCO.ValueMember = "Id"

            lstTmpDmTaikhoan = _DmTaikhoanService.GetAllByDonviID(Generals.DON_VI.Id)

            Dim lstTKNO As List(Of DmTaikhoan) = New List(Of DmTaikhoan)()
            lstTKNO.AddRange(lstTmpDmTaikhoan)
            cboMATKNO.DataSource = lstTKNO
            cboMATKNO.DisplayMember = "MaTaikhoan"
            cboMATKNO.ValueMember = "Id"

            _GridView.Columns("KcTudo1").Caption = "KC " + Generals.TS_TuDo1.GiaTri
            _GridView.Columns("KcTudo2").Caption = "KC " + Generals.TS_TuDo2.GiaTri
            _GridView.Columns("KcTudo3").Caption = "KC " + Generals.TS_TuDo3.GiaTri
            _GridView.Columns("KcTudo4").Caption = "KC " + Generals.TS_TuDo4.GiaTri
            _GridView.Columns("KcTudo5").Caption = "KC " + Generals.TS_TuDo5.GiaTri
            'dteNGAY_TINH.EditValue = DateTime.Now

            'khai bao cac bien luu ma loai chung tu khi chon tren menu truyen vao
            Dim para_str As String = Me.AccessibleDescription
            Dim lst_para As List(Of ParamInfo) = DataMining.GetParams(para_str)
            If lst_para.Count > 0 Then
                'gan ma loai chung tu bang gia tri truyen tu menu
                obj_loaichungtu.MaLoaiCt = lst_para(0).PARAMVALUE
            End If

            'khai bao 1 obj luu data lay duoc theo ma loai chung tu
            obj_loaichungtu = _HtLoaichungtuService.GetByMA_LOAI_CT(obj_loaichungtu.MaLoaiCt, Generals.DON_VI.Id)

            Load_Grid()

            CheckKry()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Function GetDmTaikhoan(ByVal Id As Guid) As DmTaikhoan
        For Each tmp As DmTaikhoan In lstTmpDmTaikhoan
            If (tmp.Id = Id) Then Return tmp
        Next

        Return Nothing
    End Function

    Private Sub CheckKry()
        If Not selection Is Nothing Then
            selection.ClearSelection()
        Else
            selection = New GridCheckMarksSelection(_GridView)
            selection.CheckMarkColumn.VisibleIndex = 0
            selection.CheckMarkColumn.Width = 35
            selection.CheckMarkColumn.OptionsColumn.AllowSize = False
            selection.CheckMarkColumn.OptionsColumn.FixedWidth = True
            selection.CheckMarkColumn.FieldName = "Check"
        End If
    End Sub

    Private Sub Load_Grid()
        Dim lstBTKetChuyen As List(Of DmBtKetchuyen) = New List(Of DmBtKetchuyen)
        lstBTKetChuyen.AddRange(_DmBtKetchuyenService.GetObjectAllByDonviID(Generals.DON_VI.Id))

        'lstBTKetChuyen = DM_Bt_KetchuyenBO.Instance.GetObjectAllByDonviID(Generals.DON_VI.Id)
        _GridControl.DataSource = lstBTKetChuyen

        _GridView.Columns("KcKh").ColumnEdit = TNCommon.COSUDUNG_ColumnEdit()
        _GridView.Columns("KcVuviec").ColumnEdit = TNCommon.COSUDUNG_ColumnEdit()
        _GridView.Columns("KcPhi").ColumnEdit = TNCommon.COSUDUNG_ColumnEdit()
        _GridView.Columns("KcCongtrinh").ColumnEdit = TNCommon.COSUDUNG_ColumnEdit()
        _GridView.Columns("KcHopdong").ColumnEdit = TNCommon.COSUDUNG_ColumnEdit()
        _GridView.Columns("KcBpht").ColumnEdit = TNCommon.COSUDUNG_ColumnEdit()
        _GridView.Columns("KcTudo1").ColumnEdit = TNCommon.COSUDUNG_ColumnEdit()
        _GridView.Columns("KcTudo2").ColumnEdit = TNCommon.COSUDUNG_ColumnEdit()
        _GridView.Columns("KcTudo3").ColumnEdit = TNCommon.COSUDUNG_ColumnEdit()
        _GridView.Columns("KcTudo4").ColumnEdit = TNCommon.COSUDUNG_ColumnEdit()
        _GridView.Columns("KcTudo5").ColumnEdit = TNCommon.COSUDUNG_ColumnEdit()
        _GridView.Columns("LoaiKetchuyen").ColumnEdit = TNCommon.LoaiKChuyen_ColumnEdit()
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDel.Click
        Try
            Dim dr As DialogResult = MessageBox.Show("Bạn muốn xóa kết chuyển ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)

            If dr = DialogResult.Yes Then
                gridBTKC = CType(_GridView.GetRow(_GridView.FocusedRowHandle), DmBtKetchuyen)

                Dim dateCT As DateTime = New DateTime()
                If (String.IsNullOrEmpty(txtThang.Text)) Then
                    dateCT = DateSerial(Int32.Parse(txtNam.Text), 13, 0)
                Else
                    dateCT = DateSerial(Int32.Parse(txtNam.Text), Int32.Parse(txtThang.Text) + 1, 0)
                End If


                _CtHService.DeleteMa(obj_loaichungtu.Id, dateCT, Generals.DonviID)
            End If

        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Function GetTuNgay() As DateTime
        Dim dateCT As DateTime = New DateTime()
        If (String.IsNullOrEmpty(txtThang.Text)) Then
            dateCT = New DateTime(Int32.Parse(txtNam.Text), 1, 1)
        Else
            dateCT = New DateTime(Int32.Parse(txtNam.Text), Int32.Parse(txtThang.Text), 1)
        End If
        Return dateCT
    End Function

    Private Function GetDenNgay() As DateTime
        Dim dateCT As DateTime = GetTuNgay()
        If (String.IsNullOrEmpty(txtThang.Text)) Then
            dateCT = dateCT.AddYears(1).AddDays(-1)
        Else
            dateCT = dateCT.AddMonths(1).AddDays(-1)
        End If
        Return dateCT
    End Function


    Private Sub _GridView_FocusedRowChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles _GridView.FocusedRowChanged
        Try
            'Check khoa so thang
            If _KtKhoasoThangService.KiemTraKhoaSo(GetDenNgay(), Generals.DON_VI.Id) Then
                Message_Warning(msgKhoaSo)
                Exit Sub
            End If

            gridBTKC = CType(_GridView.GetRow(_GridView.FocusedRowHandle), DmBtKetchuyen)

            GetSoDu()

            Dim checkExist As Boolean = True
            For i As Integer = 0 To _GridView.RowCount - 1
                gridBTKC = CType(_GridView.GetRow(i), DmBtKetchuyen)
                If gridBTKC.ThuTu = txtNHOM.EditValue Then
                    checkExist = False
                    Exit For
                End If
            Next

            If checkExist Then
                dtChiTietKC = New DataTable
                GridView1.RefreshData()
            End If
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClo.Click
        Try
            Me.Close()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub btnLaySD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLaySD.Click
        'Try
        '    gridBTKC = CType(_GridView.GetRow(_GridView.FocusedRowHandle), DmBtKetchuyen)

        '    GetSoDu()
        'Catch ex As Exception
        '    Message_Error(ex)
        'End Try
    End Sub

    Private Sub GetSoDu()
        Dim dateKetChuyen As DateTime

        If (GetDenNgay() = Nothing) Then
            Message_Warning("Chưa nhập tháng tính kết chuyển")
        Else
            dateKetChuyen = GetTuNgay()
            Dim Tu_Ngay As DateTime = New DateTime(Year(dateKetChuyen), Month(dateKetChuyen), 1)
            Dim Den_Ngay As DateTime
            Den_Ngay = GetDenNgay()
            dtChiTietKC = _DmBtKetchuyenService.LaySoDuTaiKhoan(Tu_Ngay, Den_Ngay, Generals.DON_VI.Id, gridBTKC)
            loaiKC = gridBTKC.LoaiKetchuyen
            If loaiKC = 1 Then
                dtChiTietKC.Columns.Add("MaTkCo", GetType(String))
                dtChiTietKC.Columns.Add("TkNoId", Type.GetType("System.Guid"))
                dtChiTietKC.Columns.Add("MaTkNo", GetType(String))
            Else
                dtChiTietKC.Columns.Add("MaTkNo", GetType(String))
                dtChiTietKC.Columns.Add("TkCoId", Type.GetType("System.Guid"))
                dtChiTietKC.Columns.Add("MaTkCo", GetType(String))
            End If

            For i As Integer = 0 To dtChiTietKC.Rows.Count - 1
                Select Case (loaiKC)
                    Case 1
                        Dim cboTK As DmTaikhoan = GetDmTaikhoan(VnsConvert.CGuid(dtChiTietKC.Rows(i)("TkCoId")))
                        If cboTK Is Nothing Then Continue For
                        dtChiTietKC.Rows(i)("MaTkCo") = cboTK.MaTaikhoan
                        dtChiTietKC.Rows(i)("TkCoId") = cboTK.Id
                        dtChiTietKC.Rows(i)("TkNoId") = gridBTKC.IdTkCo
                        dtChiTietKC.Rows(i)("MaTkNo") = gridBTKC.MaTkCo
                    Case 2
                        Dim cboTK As DmTaikhoan = GetDmTaikhoan(VnsConvert.CGuid(dtChiTietKC.Rows(i)("TkNoId")))
                        If cboTK Is Nothing Then Continue For
                        dtChiTietKC.Rows(i)("MaTkNo") = cboTK.MaTaikhoan
                        dtChiTietKC.Rows(i)("TkNoId") = cboTK.Id
                        dtChiTietKC.Rows(i)("MaTkCo") = gridBTKC.MaTkCo
                        dtChiTietKC.Rows(i)("TkCoId") = gridBTKC.IdTkCo
                    Case 3
                        Dim tmp_so_tien As Decimal = VnsConvert.CDecimal(dtChiTietKC.Rows(i)("SoTien").ToString())
                        If (tmp_so_tien > 0) Then
                            Dim cboTK As DmTaikhoan = GetDmTaikhoan(VnsConvert.CGuid(dtChiTietKC.Rows(i)("TkNoId")))
                            If cboTK Is Nothing Then Continue For
                            dtChiTietKC.Rows(i)("MaTkNo") = cboTK.MaTaikhoan
                            dtChiTietKC.Rows(i)("TkNoId") = cboTK.Id
                            dtChiTietKC.Rows(i)("MaTkCo") = gridBTKC.MaTkCo
                            dtChiTietKC.Rows(i)("TkCoId") = gridBTKC.IdTkCo
                        Else
                            Dim cboTK As DmTaikhoan = GetDmTaikhoan(VnsConvert.CGuid(dtChiTietKC.Rows(i)("TkNoId")))
                            If cboTK Is Nothing Then Continue For
                            dtChiTietKC.Rows(i)("SoTien") = tmp_so_tien * -1
                            dtChiTietKC.Rows(i)("MaTkCo") = cboTK.MaTaikhoan
                            dtChiTietKC.Rows(i)("TkCoId") = cboTK.Id
                            dtChiTietKC.Rows(i)("TkNoId") = gridBTKC.IdTkCo
                            dtChiTietKC.Rows(i)("MaTkNo") = gridBTKC.MaTkCo
                        End If
                End Select
                'If loaiKC = 1 Then
                '    'dtChiTietKC.Rows(i)("MaTkCo") = gridBTKC.MA_TK_CO
                '    'dtChiTietKC.Rows(i)("TkNoId") = gridBTKC.ID_TK_CO
                '    'dtChiTietKC.Rows(i)("MaTkNo") = gridBTKC.MA_TK_NO

                'Else
                '    'dtChiTietKC.Rows(i)("MaTkCo") = gridBTKC.MA_TK_NO
                '    'dtChiTietKC.Rows(i)("MaTkNo") = gridBTKC.MA_TK_CO
                '    'dtChiTietKC.Rows(i)("TkCoId") = gridBTKC.ID_TK_CO

                'End If
            Next
            GridControl1.DataSource = dtChiTietKC
        End If
    End Sub

    Private Sub InsertToCTD(ByVal _gridBTKC As DmBtKetchuyen, ByVal _ct_h As CtH, ByVal _dtDinhKhoanCT As DataTable)
        'Dim gridkc As DmBtKetchuyen
        Dim objctd As CtD
        For i As Integer = 0 To _dtDinhKhoanCT.Rows.Count - 1
            objctd = New CtD
            objctd.Nhom = gridBTKC.ThuTu

            objctd.MaTkCo = _dtDinhKhoanCT.Rows(i)("MaTkNo")
            objctd.MaTkNo = _dtDinhKhoanCT.Rows(i)("MaTkCo")
            objctd.TkCoId = _dtDinhKhoanCT.Rows(i)("TkNoId")
            objctd.TkNoId = _dtDinhKhoanCT.Rows(i)("TkCoId")

            If _dtDinhKhoanCT.Columns.Contains("IdHopdongCo") Then
                objctd.IdDmHopdongCo = If(IsDBNull(_dtDinhKhoanCT.Rows(i)("IdHopdongCo")), Nothing, _dtDinhKhoanCT.Rows(i)("IdHopdongCo"))
                objctd.IdDmHopdongNo = objctd.IdDmHopdongCo
            End If
            If _dtDinhKhoanCT.Columns.Contains("IdKhangCo") Then
                objctd.IdKhangCo = If(IsDBNull(_dtDinhKhoanCT.Rows(i)("IdKhangCo")), Nothing, _dtDinhKhoanCT.Rows(i)("IdKhangCo"))
                objctd.IdKhangNo = objctd.IdKhangCo
            End If
            If _dtDinhKhoanCT.Columns.Contains("IdDmKhoanphiCo") Then
                objctd.IdDmKhoanphiCo = If(IsDBNull(_dtDinhKhoanCT.Rows(i)("IdDmKhoanphiCo")), Nothing, _dtDinhKhoanCT.Rows(i)("IdDmKhoanphiCo"))
                objctd.IdDmKhoanphiNo = objctd.IdDmKhoanphiCo
            End If
            If _dtDinhKhoanCT.Columns.Contains("IdDmTudo1Co") Then
                objctd.IdDmTudo1Co = If(IsDBNull(_dtDinhKhoanCT.Rows(i)("IdDmTudo1Co")), Nothing, _dtDinhKhoanCT.Rows(i)("IdDmTudo1Co"))
                objctd.IdDmTudo1No = objctd.IdDmTudo1Co
            End If
            If _dtDinhKhoanCT.Columns.Contains("IdDmTudo2Co") Then
                objctd.IdDmTudo2Co = If(IsDBNull(_dtDinhKhoanCT.Rows(i)("IdDmTudo2Co")), Nothing, _dtDinhKhoanCT.Rows(i)("IdDmTudo2Co"))
                objctd.IdDmTudo2No = objctd.IdDmTudo2Co
            End If
            If _dtDinhKhoanCT.Columns.Contains("IdDmTudo3Co") Then
                objctd.IdDmTudo3Co = If(IsDBNull(_dtDinhKhoanCT.Rows(i)("IdDmTudo3Co")), Nothing, _dtDinhKhoanCT.Rows(i)("IdDmTudo3Co"))
                objctd.IdDmTudo3No = objctd.IdDmTudo3Co
            End If
            If _dtDinhKhoanCT.Columns.Contains("IdDmTudo4Co") Then
                objctd.IdDmTudo4Co = If(IsDBNull(_dtDinhKhoanCT.Rows(i)("IdDmTudo4Co")), Nothing, _dtDinhKhoanCT.Rows(i)("IdDmTudo4Co"))
                objctd.IdDmTudo4No = objctd.IdDmTudo4Co
            End If
            If _dtDinhKhoanCT.Columns.Contains("IdDmTudo5Co") Then
                objctd.IdDmTudo5Co = If(IsDBNull(_dtDinhKhoanCT.Rows(i)("IdDmTudo5Co")), Nothing, _dtDinhKhoanCT.Rows(i)("IdDmTudo5Co"))
                objctd.IdDmTudo5No = objctd.IdDmTudo5Co
            End If
            If _dtDinhKhoanCT.Columns.Contains("IdVuviecCo") Then
                objctd.IdDmVuviecCo = If(IsDBNull(_dtDinhKhoanCT.Rows(i)("IdVuviecCo")), Nothing, _dtDinhKhoanCT.Rows(i)("IdVuviecCo"))
                objctd.IdDmVuviecNo = objctd.IdDmVuviecCo
            End If

            If _dtDinhKhoanCT.Columns.Contains("IdHopdongNo") Then
                objctd.IdDmHopdongCo = If(IsDBNull(_dtDinhKhoanCT.Rows(i)("IdHopdongNo")), Nothing, _dtDinhKhoanCT.Rows(i)("IdHopdongNo"))
                objctd.IdDmHopdongNo = objctd.IdDmHopdongCo
            End If
            If _dtDinhKhoanCT.Columns.Contains("IdKhangNo") Then
                objctd.IdKhangCo = If(IsDBNull(_dtDinhKhoanCT.Rows(i)("IdKhangNo")), Nothing, _dtDinhKhoanCT.Rows(i)("IdKhangNo"))
                objctd.IdKhangNo = objctd.IdKhangCo
            End If
            If _dtDinhKhoanCT.Columns.Contains("ID_DM_KHOANPHI_NO") Then
                objctd.IdDmKhoanphiCo = If(IsDBNull(_dtDinhKhoanCT.Rows(i)("ID_DM_KHOANPHI_NO")), Nothing, _dtDinhKhoanCT.Rows(i)("ID_DM_KHOANPHI_NO"))
                objctd.IdDmKhoanphiNo = objctd.IdDmKhoanphiCo
            End If
            If _dtDinhKhoanCT.Columns.Contains("IdDmTudo1No") Then
                objctd.IdDmTudo1Co = If(IsDBNull(_dtDinhKhoanCT.Rows(i)("IdDmTudo1No")), Nothing, _dtDinhKhoanCT.Rows(i)("IdDmTudo1No"))
                objctd.IdDmTudo1No = objctd.IdDmTudo1Co
            End If
            If _dtDinhKhoanCT.Columns.Contains("IdDmTudo2No") Then
                objctd.IdDmTudo2Co = If(IsDBNull(_dtDinhKhoanCT.Rows(i)("IdDmTudo2No")), Nothing, _dtDinhKhoanCT.Rows(i)("IdDmTudo2No"))
                objctd.IdDmTudo2No = objctd.IdDmTudo2Co
            End If
            If _dtDinhKhoanCT.Columns.Contains("IdDmTudo3No") Then
                objctd.IdDmTudo3Co = If(IsDBNull(_dtDinhKhoanCT.Rows(i)("IdDmTudo3No")), Nothing, _dtDinhKhoanCT.Rows(i)("IdDmTudo3No"))
                objctd.IdDmTudo3No = objctd.IdDmTudo3Co
            End If
            If _dtDinhKhoanCT.Columns.Contains("IdDmTudo4No") Then
                objctd.IdDmTudo4Co = If(IsDBNull(_dtDinhKhoanCT.Rows(i)("IdDmTudo4No")), Nothing, _dtDinhKhoanCT.Rows(i)("IdDmTudo4No"))
                objctd.IdDmTudo4No = objctd.IdDmTudo4Co
            End If
            If _dtDinhKhoanCT.Columns.Contains("IdDmTudo5No") Then
                objctd.IdDmTudo5Co = If(IsDBNull(_dtDinhKhoanCT.Rows(i)("IdDmTudo5No")), Nothing, _dtDinhKhoanCT.Rows(i)("IdDmTudo5No"))
                objctd.IdDmTudo5No = objctd.IdDmTudo5Co
            End If
            If _dtDinhKhoanCT.Columns.Contains("IdVuviecNo") Then
                objctd.IdDmVuviecCo = If(IsDBNull(_dtDinhKhoanCT.Rows(i)("IdVuviecNo")), Nothing, _dtDinhKhoanCT.Rows(i)("IdVuviecNo"))
                objctd.IdDmVuviecNo = objctd.IdDmVuviecCo
            End If
            If (_dtDinhKhoanCT.Rows(i)(0) Is DBNull.Value) Then
                _dtDinhKhoanCT.Rows(i)(0) = 0
            End If
            objctd.SoTien = _dtDinhKhoanCT.Rows(i)(0)
            'objctd.CTH_ID = _ct_h.CTH_ID
            If (objctd.SoTien > 0) Then
                lstobjctd.Add(objctd)
            End If
        Next
    End Sub

    Private Sub btnMove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMove.Click
        Try
            'Check khoa so thang
            If _KtKhoasoThangService.KiemTraKhoaSo(GetDenNgay, Generals.DON_VI.Id) Then
                Message_Warning(msgKhoaSo)
                Exit Sub
            End If

            Dim objcth As CtH = New CtH
            lstobjctd = New List(Of CtD)
            Dim _ExistCTH As Boolean = False

            Dim _Nhom As String = ""
            _Nhom = txtNHOM.EditValue
            'Sap xep theo thu tu nhom de tinh
            _GridView.Columns("ThuTu").SortOrder = DevExpress.Data.ColumnSortOrder.Ascending

            Dim objBTKC As DmBtKetchuyen = New DmBtKetchuyen
            Dim lstobjBTKC As List(Of DmBtKetchuyen) = New List(Of DmBtKetchuyen)

            'Lay ra cac dong duoc danh dau de thuc hien ket chuyen
            For i As Integer = 0 To _GridView.RowCount - 1
                gridBTKC = CType(_GridView.GetRow(i), DmBtKetchuyen)
                If (gridBTKC.ThuTu = txtNHOM.EditValue) Or _GridView.GetRowCellValue(i, "Check").ToString = "True" Then
                    lstobjBTKC.Add(gridBTKC)
                End If
            Next

            'For k As Integer = 0 To _GridView.RowCount - 1

            '    gridBTKC = CType(_GridView.GetRow(k), DmBtKetchuyen)
            'If (gridBTKC.THU_TU = txtNHOM.EditValue) Or _GridView.GetRowCellValue(k, "Check").ToString = "True" Then
            For k As Integer = 0 To lstobjBTKC.Count - 1

                gridBTKC = lstobjBTKC(k)
                GetSoDu()

                If dtChiTietKC.Rows.Count > 0 Then
                    If Not _ExistCTH Then
                        objcth.MaLoaiCt = obj_loaichungtu.MaLoaiCt
                        objcth.KyHieuLoaiCt = obj_loaichungtu.KyHieu
                        objcth.IdLoaiCt = obj_loaichungtu.Id

                        objcth.NgayCt = GetDenNgay()
                        objcth.NgayGhi = objcth.NgayCt
                        objcth.NgayTao = objcth.NgayCt
                        objcth.SoTien = 0
                        objcth.SoTienNte = 0
                        objcth.TyGia = 1
                        objcth.NteId = VnsConvert.CGuid(Generals.TS_NoiTe_ID.GiaTri)
                        objcth.MaNte = _DmNgoaiteService.GetById(objcth.NteId).MaNte

                        'gridBTKC = CType(_GridView.GetRow(_GridView.FocusedRowHandle), DmBtKetchuyen)
                        objcth.DonviId = Generals.DON_VI.Id
                        'Dim dmDonVi As DM_DonViInfo = DM_DonviBO.Instance.GetById(gridBTKC.DONVI_ID)
                        objcth.MaDonvi = Generals.DON_VI.MaDonvi

                        'Insert so chung tu
                        Dim strmMonth As String
                        strmMonth = Month(GetDenNgay).ToString
                        Dim strYear As String
                        strYear = Year(GetDenNgay).ToString
                        'Dim strSoCT As Integer
                        'strSoCT = GETNEXTfSOCHUNGTU(objcth.Id, strmMonth, strYear, Generals.DON_VI.Id)
                        Dim lst As List(Of String) = _HtLoaichungtuService.GetSoCT_prefix(obj_loaichungtu.Id, strmMonth, strYear, Generals.DON_VI.Id)
                        objcth.CtSo = lst(0)
                        'objcth = CT_HBO.Instance.Insert(objcth)
                        _ExistCTH = True

                    End If

                    InsertToCTD(gridBTKC, objcth, dtChiTietKC)
                End If
                If (k = lstobjBTKC.Count - 1) Then
                    _CtHService.SaveChungTuKeToan(True, Nothing, objcth, lstobjctd, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
                    lstobjctd = New List(Of CtD)()
                Else
                    If lstobjBTKC(k).ThuTu <> lstobjBTKC(k + 1).ThuTu Then
                        _CtHService.SaveChungTuKeToan(True, Nothing, objcth, lstobjctd, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
                        lstobjctd = New List(Of CtD)()
                    End If
                End If
                'End If
            Next

        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub txtNHOM_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNHOM.EditValueChanged
        Try
            GridView1.RefreshData()
            For i As Integer = 0 To _GridView.RowCount - 1
                gridBTKC = CType(_GridView.GetRow(i), DmBtKetchuyen)
                If gridBTKC.ThuTu = txtNHOM.EditValue Then
                    GetSoDu()
                    Exit For
                End If
            Next
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

End Class