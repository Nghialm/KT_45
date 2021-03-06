Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid

Imports Vns.Erp.Core.Admin.Domain
Imports Vns.Erp.Core.Accounting.Domain
Imports Vns.Erp.Core.Accounting.Service.Interface
Imports Vns.Erp.Core.Admin.Service.Interface
Public Class frmKhaiBaoCacButToanPBTD_ChiTiet
#Region "Property"
    Private _KtDmBtPhanboService As IKtDmBtPhanboService
    Public Property KtDmBtPhanboService As IKtDmBtPhanboService
        Get
            Return _KtDmBtPhanboService
        End Get
        Set(ByVal value As IKtDmBtPhanboService)
            _KtDmBtPhanboService = value
        End Set
    End Property

    Private _DmKhangService As IDmKhangService
    Public Property DmKhangService As IDmKhangService
        Get
            Return _DmKhangService
        End Get
        Set(ByVal value As IDmKhangService)
            _DmKhangService = value
        End Set
    End Property

    Private _DmVuviecService As IDmVuviecService
    Public Property DmVuviecService As IDmVuviecService
        Get
            Return _DmVuviecService
        End Get
        Set(ByVal value As IDmVuviecService)
            _DmVuviecService = value
        End Set
    End Property

    Private _DmKhoanphiService As IDmKhoanphiService
    Public Property DmKhoanphiService As IDmKhoanphiService
        Get
            Return _DmKhoanphiService
        End Get
        Set(ByVal value As IDmKhoanphiService)
            _DmKhoanphiService = value
        End Set
    End Property

    Private _DmTudo1Service As IDmTudo1Service
    Public Property DmTudo1Service As IDmTudo1Service
        Get
            Return _DmTudo1Service
        End Get
        Set(ByVal value As IDmTudo1Service)
            _DmTudo1Service = value
        End Set
    End Property

    Private _DmHopdongService As IDmHopdongService
    Public Property DmHopdongService As IDmHopdongService
        Get
            Return _DmHopdongService
        End Get
        Set(ByVal value As IDmHopdongService)
            _DmHopdongService = value
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
    Dim _HtDanhmucService As IHtDanhmucService
    Public Property HtDanhmucService() As IHtDanhmucService
        Get
            Return _HtDanhmucService
        End Get
        Set(ByVal value As IHtDanhmucService)
            _HtDanhmucService = value
        End Set
    End Property
#End Region

    Dim frm As New frmKhaiBaoCacButToanPBTD_DanhSach
    Private obj_PBTD As KtDmBtPhanbo = New KtDmBtPhanbo()
    Private obj_PBTDBO As KtDmBtPhanbo
    Private lstobj_PBTD As List(Of KtDmBtPhanbo) = New List(Of KtDmBtPhanbo)
    Private lstobj_Del_PBTD As List(Of KtDmBtPhanbo) = New List(Of KtDmBtPhanbo)
    Dim lst_PB_Nam_Con As List(Of KtDmBtPhanbo) = New List(Of KtDmBtPhanbo)
    Private m_InputState As FormGlobals.DataInputState
    Private m_Nhom As String
    Private m_nam As String
    Dim dt As DataTable

    Public Sub New()
        InitializeComponent()
        TNCommon.setIconControl(Me)
    End Sub

    Public Function Show_Form(ByVal p_NHOM As String, ByVal p_Nam As Integer, ByVal eState As DataInputState) As Boolean
        Try
            Form_SetText(Me, "Khai báo các bút toán phân bổ tự động", eState)
            Form_InitDialog(Me)
            m_InputState = eState
            m_Nhom = p_NHOM
            m_nam = p_Nam
            frmProgress.Instance.Thread = AddressOf Init_Data
            frmProgress.Instance.Show_Progress()
            _GridView.FixedLineWidth = 0

        Catch ex As Exception
            Message_Error(ex)
        End Try

        Return (Me.ShowDialog = DialogResult.OK)
    End Function

    Private Sub Init_Data()
        Select Case m_InputState
            Case DataInputState.AddMode
                BindLookup()
                lstobj_PBTD.Add(New KtDmBtPhanbo())
                _GridControl.DataSource = lstobj_PBTD
                Dim dt As String
                Dim ds As KtDmBtPhanbo = _KtDmBtPhanboService.GetNhomMax(Generals.DON_VI.Id)
                If Not (ds Is Nothing) Then
                    txtNHOM.Text = ds.Nhom + 1
                Else
                    txtNHOM.Text = "1"
                End If
                txtNHOM.Enabled = False
            Case Else
                BindLookup()
                SetObjectToControl()
        End Select
    End Sub

    Private Sub BindLookup()
        dt = DataHelper.ToDataTable(_DmTaikhoanService.GetAllByDonviID(Generals.DON_VI.Id))
        'Bind tai khoan
        'Dim lstTkoan As List(Of DmTaikhoan) = DM_TaikhoanBO.Instance.GetAllByDonviID(Generals.DON_VI.Id)
        'grlTAI_KHOAN.Properties.DataSource = lstTkoan
        'grlTAI_KHOAN.Properties.DisplayMember = "MA_TAIKHOAN"
        'grlTAI_KHOAN.Properties.ValueMember = "TAIKHOAN_ID"

        'bind tai khoan dich
        'cboMA_TK_DICH.DataSource = lstTkoan
        'cboMA_TK_DICH.DisplayMember = "MA_TAIKHOAN"
        'cboMA_TK_DICH.ValueMember = "TAIKHOAN_ID"
        'cboMA_TK_DICH.Columns.Add(New LookUpColumnInfo("MA_TAIKHOAN", "Mã tài khoản"))
        'cboMA_TK_DICH.Columns.Add(New LookUpColumnInfo("TEN_TAIKHOAN", "Tên tài khoản"))

        'bind khach hang
        CboKC_KH.DataSource = _DmKhangService.GetAllByDonviID(Generals.DON_VI.Id)
        CboKC_KH.DisplayMember = "TenKhang"
        CboKC_KH.ValueMember = "Id"
        CboKC_KH.Columns.Add(New LookUpColumnInfo("KyHieu", "Ký hiệu"))
        CboKC_KH.Columns.Add(New LookUpColumnInfo("TenKhang", "Tên khách hàng"))
        'bind vu viec
        cboVuViec.DataSource = _DmVuviecService.GetAllByDonviID(Generals.DON_VI.Id)
        cboVuViec.DisplayMember = "TenVuviec"
        cboVuViec.ValueMember = "Id"
        cboVuViec.Columns.Add(New LookUpColumnInfo("KyHieu", "Ký hiệu"))
        cboVuViec.Columns.Add(New LookUpColumnInfo("TenVuviec", "Tên vụ việc"))
        'bind  phi
        cboKC_PHI.DataSource = _DmKhoanphiService.GetAllByDonviID(Generals.DON_VI.Id)
        cboKC_PHI.DisplayMember = "TenDmKhoanphi"
        cboKC_PHI.ValueMember = "Id"
        cboKC_PHI.Columns.Add(New LookUpColumnInfo("KyHieu", "Ký hiệu"))
        cboKC_PHI.Columns.Add(New LookUpColumnInfo("TenDmKhoanphi", "Tên khoản phí"))
        'bind DMTD
        cboKC_TUDO.DataSource = _DmTudo1Service.GetAllByDonviID(Generals.DON_VI.Id)
        cboKC_TUDO.DisplayMember = "TenDmTudo1"
        cboKC_TUDO.ValueMember = "Id"
        cboKC_TUDO.Columns.Add(New LookUpColumnInfo("KyHieu", "Ký hiệu"))
        cboKC_TUDO.Columns.Add(New LookUpColumnInfo("TenDmTudo1", "Tên danh mục tự do"))
        'bind Hop dong
        cboKC_HOPDONG.DataSource = _DmHopdongService.GetAllByDonviID(Generals.DON_VI.Id)
        cboKC_HOPDONG.DisplayMember = "TenHopdong"
        cboKC_HOPDONG.ValueMember = "Id"
        cboKC_HOPDONG.Columns.Add(New LookUpColumnInfo("KyHieu", "Ký hiệu"))
        cboKC_HOPDONG.Columns.Add(New LookUpColumnInfo("TenHopdong", "Tên hợp đồng"))

        'bind BPHP
        'cboKC_BPHT.DataSource = DM_.Instance.GetAllByDonviID(Generals.DON_VI.Id)
        'cboKC_BPHT.DisplayMember = "TEN"
        'cboKC_BPHT.ValueMember = "ID"
        'cboKC_BPHT.Columns.Add(New LookUpColumnInfo("ID", "ID"))
        'cboKC_BPHT.Columns.Add(New LookUpColumnInfo("TEN", "Tên"))
        ''bind Cong trinh
        'cboKC_CONGTRINH.DataSource = BindCBO()
        'cboKC_CONGTRINH.DisplayMember = "TEN"
        'cboKC_CONGTRINH.ValueMember = "ID"
        'cboKC_CONGTRINH.Columns.Add(New LookUpColumnInfo("ID", "ID"))
        'cboKC_CONGTRINH.Columns.Add(New LookUpColumnInfo("TEN", "Tên"))

        Dim objColumnDefine As ArrayList
        'Bind loại kết chuyển
        Dim lstLKChuyen As List(Of HtDanhmuc) = New List(Of HtDanhmuc)
        lstLKChuyen.AddRange(_HtDanhmucService.GetByDoiTuong("LOAI_KETCHUYEN"))
        objColumnDefine = New ArrayList
        objColumnDefine.Add(New LookupEdit_ColumnInfo("TenDanhmuc", "Loại kết chuyển"))
        GridLookupEdit_BindData(grlLOAI_PHANBO, lstLKChuyen, "TenDanhmuc", "GiaTri", COMBO_ITEM_REQUIRE, "", objColumnDefine)
    End Sub

    Private Sub GetControlToOBject()
        Try
            'lay nhieu gia tri trong 1 table khac
            obj_PBTD.NHOM = Convert.ToInt32(txtNHOM.Text)
            obj_PBTD.TenBtPhanbo = txtTEN_BUT_TOAN.Text
            obj_PBTD.MaTkPhanbo = cFilterTaiKhoan.ListEditValue(1)
            obj_PBTD.TenTkPhanbo = cFilterTaiKhoan.ListEditValue(2)
            obj_PBTD.TkPhanboId = VnsConvert.CGuid(cFilterTaiKhoan.ListEditValue(0))
            obj_PBTD.DonviId = Generals.DON_VI.Id
            obj_PBTD.Nam = m_nam
            obj_PBTD.LoaiPhanbo = grlLOAI_PHANBO.EditValue
            'Lấy giá trị control trên lưới
            Dim ThuTu As Integer = 0
            For Each objPB As KtDmBtPhanbo In lstobj_PBTD
                ThuTu = ThuTu + 1
                objPB.NHOM = obj_PBTD.NHOM
                objPB.NAM = obj_PBTD.NAM
                objPB.TenBtPhanbo = obj_PBTD.TenBtPhanbo
                objPB.TenTkPhanbo = obj_PBTD.TenTkPhanbo
                objPB.MaTkPhanbo = obj_PBTD.MaTkPhanbo
                objPB.TkPhanboId = obj_PBTD.TkPhanboId
                objPB.LoaiPhanbo = grlLOAI_PHANBO.EditValue
                objPB.ThuTu = ThuTu
                objPB.DonviId = Generals.DON_VI.Id
                objPB.NAM = obj_PBTD.NAM
                Select Case m_InputState
                    Case DataInputState.AddMode
                        Insert_PBTD(objPB)
                    Case Else
                        If (VnsCheck.IsNullGuid(objPB.Id)) Then
                            Insert_PBTD(objPB)
                        Else
                            Update_PBTD(objPB)
                        End If
                End Select
            Next
            For Each del_obj As KtDmBtPhanbo In lstobj_Del_PBTD
                Select Case m_InputState
                    Case DataInputState.AddMode
                    Case Else
                        Delete_PBTD(del_obj.Id)
                End Select
            Next
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub SetObjectToControl()
        txtNHOM.Enabled = False
        Dim lstobj_DM_BT_PB As List(Of KtDmBtPhanbo) = New List(Of KtDmBtPhanbo)
        lstobj_DM_BT_PB.AddRange(_KtDmBtPhanboService.GetByDonviId(Generals.DON_VI.Id))
        Dim lst_nhom As List(Of KtDmBtPhanbo) = New List(Of KtDmBtPhanbo)
        lst_nhom.Clear()
        Dim i As Integer
        Dim nhom As Integer = 0
        For i = 0 To lstobj_DM_BT_PB.Count - 1
            If (nhom <> lstobj_DM_BT_PB(i).NHOM) Then
                lst_nhom.Add(lstobj_DM_BT_PB(i))
                nhom = lstobj_DM_BT_PB(i).NHOM
            End If
        Next
        'Gan obj vao textbox
        For Each obj As KtDmBtPhanbo In lst_nhom
            If (obj.NHOM = m_Nhom) Then
                txtNHOM.Text = obj.NHOM
                txtTEN_BUT_TOAN.Text = obj.TenBtPhanbo
                'grlTAI_KHOAN.EditValue = obj.TK_PHANBO_ID
                RemoveHandler cFilterTaiKhoan.ClearFilterData, AddressOf cFilterTaiKhoan_ClearFilterData
                cFilterTaiKhoan.Tag = obj.TkPhanboId
                cFilterTaiKhoan.Text = obj.MaTkPhanbo
                AddHandler cFilterTaiKhoan.ClearFilterData, AddressOf cFilterTaiKhoan_ClearFilterData
                'lblTEN_TAI_KHOAN.Text = obj.TEN_TK_PHANBO
                If (obj.LoaiPhanbo <> Nothing) Then
                    grlLOAI_PHANBO.EditValue = obj.LoaiPhanbo
                End If
            End If
        Next
        'gan datasource
        For Each obj_con As KtDmBtPhanbo In lstobj_DM_BT_PB
            If (obj_con.NHOM = m_Nhom) Then
                lstobj_PBTD.Add(obj_con)
            End If
        Next
        _GridControl.DataSource = lstobj_PBTD
    End Sub

    Private Function Insert_PBTD(ByVal _obj_PBTD As KtDmBtPhanbo) As KtDmBtPhanbo
        Return _KtDmBtPhanboService.Save(_obj_PBTD)
    End Function

    Private Sub Update_PBTD(ByVal _obj_PBTD As KtDmBtPhanbo)
        _KtDmBtPhanboService.SaveOrUpdate(_obj_PBTD)
    End Sub

    Private Sub Delete_PBTD(ByVal _obj_PBTD As Object)
        _KtDmBtPhanboService.Delete(_obj_PBTD)
    End Sub

    Private Sub _GridView_CellValueChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles _GridView.CellValueChanged
        Try
            Dim grv_PBTD As KtDmBtPhanbo = CType(_GridView.GetRow(_GridView.FocusedRowHandle), KtDmBtPhanbo)
            Select Case e.Column.Name
                Case "TK_DICH_ID"
                    Dim cboTKD As DmTaikhoan = CType(cboMA_TK_DICH.GetDataSourceRowByKeyValue(grv_PBTD.TkDichId), DmTaikhoan)
                    If (grv_PBTD Is Nothing) Then
                        Return
                    End If
                    If cboTKD Is Nothing Then
                        Return
                    End If
                    'Gan vao GridView
                    grv_PBTD.TenTkDich = cboTKD.TenTaikhoan
                    grv_PBTD.MaTkDich = cboTKD.MaTaikhoan
                    grv_PBTD.TkDichId = cboTKD.Id
            End Select
            _GridView.RefreshData()

        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    'Check Validate cho Grid
    Private Function ExistError(ByVal grv As GridView) As Boolean
        For Each gcol As GridColumn In grv.Columns
            If grv.GetColumnError(gcol) <> "" Then
                Return True
            End If
        Next
        '
        Return False
    End Function

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Try
            If String.IsNullOrEmpty(grlLOAI_PHANBO.EditValue) Then
                Message_Warning("Loại kết chuyển không được để trống!")
                grlLOAI_PHANBO.Focus()
                Return
            End If

            If VnsCheck.IsNullGuid(cFilterTaiKhoan.Tag) Then
                Message_Warning("Tài khoản phân bổ không được để trống!")
                cFilterTaiKhoan.Focus()
                Return
            End If

            If txtTEN_BUT_TOAN.Text = "" Then
                Message_Warning("Tên bút toán không được để trống!")
                txtTEN_BUT_TOAN.Focus()
                Return
            End If

            If _GridView.RowCount <> 0 Then
                For Each obj As KtDmBtPhanbo In lstobj_PBTD
                    If (VnsCheck.IsNullGuid(obj.TkDichId)) Then
                        Message_Warning("Tài khoản đích không được để trống")
                        Exit Sub
                    End If
                Next
            Else
                Message_Warning("Chi tiết phân bổ không được để trống!")
                Return
            End If

            frmProgress.Instance.Thread = AddressOf GetControlToOBject
            frmProgress.Instance.Show_Progress()
            frmProgress.Instance.SetFinishText("Data saved")
            DialogResult = System.Windows.Forms.DialogResult.OK

        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub _GridView_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles _GridView.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                If (GridHelper.CheckAddNewRow(_GridView)) Then
                    lstobj_PBTD.Add(New KtDmBtPhanbo)
                    _GridView.RefreshData()
                End If
            End If
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub THEM_DONG()
        Try
            Dim obj As KtDmBtPhanbo = New KtDmBtPhanbo
            lstobj_PBTD.Add(obj)
            _GridView.RefreshData()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        If Message_Confirm("Bạn có muốn thêm dòng mới?") Then
            THEM_DONG()
        End If
    End Sub

    Private Sub XOA_DONG()
        Try
            Dim itemGrid As KtDmBtPhanbo = CType(_GridView.GetRow(_GridView.FocusedRowHandle), KtDmBtPhanbo)
            If (Not VnsCheck.IsNullGuid(itemGrid.Id)) Then
                lstobj_Del_PBTD.Add(itemGrid)
            End If
            _GridView.DeleteSelectedRows()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeRow.Click
        Try
            If _GridView.RowCount <> 0 Then
                If Message_Confirm("Bạn có muốn xóa dòng này?") Then
                    XOA_DONG()
                End If
            Else
                Message_Warning("Không có bản ghi nào được chọn!")
            End If

        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub SimpleButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQui.Click
        Validate_BTPB.ClearErrors()
        Me.Close()
    End Sub

    Private Sub _GridView_ValidateRow(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles _GridView.ValidateRow
        Try
            Dim view As ColumnView = CType(sender, ColumnView)
            Dim currentindex As Integer = _GridView.FocusedRowHandle
            Dim MTK As String = view.GetRowCellDisplayText(_GridView.FocusedRowHandle, view.Columns("MaTkDich"))
            Dim KH As Guid = view.GetRowCellValue(_GridView.FocusedRowHandle, view.Columns("KcKh"))
            Dim VV As Guid = view.GetRowCellValue(_GridView.FocusedRowHandle, view.Columns("KcVuviec"))
            Dim CP As Guid = view.GetRowCellValue(_GridView.FocusedRowHandle, view.Columns("KcPhi"))
            Dim TD As Guid = view.GetRowCellValue(_GridView.FocusedRowHandle, view.Columns("KcTudo"))
            Dim HD As Guid = view.GetRowCellValue(_GridView.FocusedRowHandle, view.Columns("KcHopdong"))
            Dim BPHT As Guid = view.GetRowCellValue(_GridView.FocusedRowHandle, view.Columns("KcBpht"))
            Dim CT As Guid = view.GetRowCellValue(_GridView.FocusedRowHandle, view.Columns("KcCongtrinh"))

            Dim s As Integer = lstobj_PBTD.Count

            For i As Integer = 0 To s - 1
                Dim str As String = lstobj_PBTD(i).MaTkDich

                If ((MTK = lstobj_PBTD(i).MaTkDich) And i <> currentindex) And (KH = lstobj_PBTD(i).KhachHangDich) _
                     And ((VV = lstobj_PBTD(i).VuviecDich) And (CP = lstobj_PBTD(i).KhoanPhiDich) _
                     And (TD = lstobj_PBTD(i).Tudo1Dich) And (HD = lstobj_PBTD(i).HopDongDich) _
                     And (BPHT = lstobj_PBTD(i).PtqtDich) And (CT = lstobj_PBTD(i).CongTrinhDich)) Then

                    e.Valid = False
                    view.SetColumnError(view.Columns("MaTkDich"), "Dữ liệu không được trùng nhau")
                End If
            Next
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub _GridView_InvalidRowException(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs) Handles _GridView.InvalidRowException
        e.ExceptionMode = ExceptionMode.NoAction
    End Sub

    Private Sub frmKhaiBaoCacButToanPBTD_ChiTiet_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Try
            Select Case e.KeyCode
                Case Keys.Escape
                    Me.Close()
                Case Keys.F8
                    If _GridView.RowCount <> 0 Then
                        If Message_Confirm("Bạn có muốn xóa dòng đang chọn?") Then
                            XOA_DONG()
                        End If
                    Else
                        Message_Warning("Không có bản ghi nào được chọn!")
                    End If
                Case Keys.F4
                    If Message_Confirm("Bạn có muốn thêm dòng mới?") Then
                        THEM_DONG()
                    End If
            End Select
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub cFilterTaiKhoan_AfterFilter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cFilterTaiKhoan.AfterFilter
        Try
            cFilterTaiKhoan.Tag = cFilterTaiKhoan.ListEditValue(0)
            If cFilterTaiKhoan.IsNotTextChanged Then SendKeys.Send("{TAB}")
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub cFilterTaiKhoan_FirstBinddata(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cFilterTaiKhoan.FirstBinddata
        Try
            cFilterTaiKhoan.C_DATA_SOURCE = dt
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub cFilterTaiKhoan_ClearFilterData(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cFilterTaiKhoan.ClearFilterData
        Try
            cFilterTaiKhoan.Tag = ""
            cFilterTaiKhoan.Text = ""
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub CFiltelTAIKHOANDICH_AfterFilter(ByVal senders As System.Object, ByVal e As System.EventArgs) Handles CFiltelTAIKHOANDICH.AfterFilter
        Try
            Dim obj_PB As KtDmBtPhanbo = CType(_GridView.GetRow(_GridView.FocusedRowHandle), KtDmBtPhanbo)

            If obj_PB Is Nothing Then
                Return
            End If

            Select Case _GridView.FocusedColumn().Name
                Case "TK_DICH_ID"
                    If CFiltelTAIKHOANDICH.OwnerEdit.A_LIST_VALUES.Count <> 0 Then
                        obj_PB.TkDichId = VnsConvert.CGuid(CFiltelTAIKHOANDICH.OwnerEdit.A_LIST_VALUES(0))
                        obj_PB.MaTkDich = CFiltelTAIKHOANDICH.OwnerEdit.A_LIST_VALUES(1)
                        obj_PB.TenTkDich = CFiltelTAIKHOANDICH.OwnerEdit.A_LIST_VALUES(2)
                        _GridView.SetRowCellValue(_GridView.FocusedRowHandle, "MaTkDich", obj_PB.MaTkDich)
                    End If
            End Select
            SendKeys.Send("{TAB}")
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub CFiltelTAIKHOANDICH_FisrtBinddata(ByVal senders As System.Object, ByVal e As System.EventArgs) Handles CFiltelTAIKHOANDICH.FisrtBinddata
        Try
            CFiltelTAIKHOANDICH.C_DATA_SOURCE = dt
            CFiltelTAIKHOANDICH.Editors.A_DATA_SOURCE = CFiltelTAIKHOANDICH.C_DATA_SOURCE
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub CFiltelTAIKHOANDICH_ClearDataFilter(ByVal senders As System.Object, ByVal e As System.EventArgs) Handles CFiltelTAIKHOANDICH.ClearDataFilter
        Try
            Dim obj_PB As KtDmBtPhanbo = CType(_GridView.GetRow(_GridView.FocusedRowHandle), KtDmBtPhanbo)

            If obj_PB Is Nothing Then
                Return
            End If

            Select Case _GridView.FocusedColumn().Name
                Case "TK_DICH_ID"
                    If CFiltelTAIKHOANDICH.OwnerEdit.A_LIST_VALUES.Count <> 0 Then
                        obj_PB.TkDichId = VnsConvert.CGuid(CFiltelTAIKHOANDICH.OwnerEdit.A_LIST_VALUES(0))
                        obj_PB.MaTkDich = CFiltelTAIKHOANDICH.OwnerEdit.A_LIST_VALUES(1)
                        obj_PB.TenTkDich = CFiltelTAIKHOANDICH.OwnerEdit.A_LIST_VALUES(2)
                        '_GridView.SetRowCellValue(_GridView.FocusedRowHandle, "MA_TK_DICH", obj_PB.MA_TK_DICH)
                    End If
            End Select
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub
End Class