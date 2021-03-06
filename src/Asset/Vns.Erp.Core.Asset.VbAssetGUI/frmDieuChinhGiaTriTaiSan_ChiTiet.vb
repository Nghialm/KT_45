Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Base
Imports System.Reflection
Imports DevExpress.XtraGrid.Views.Grid

Imports Vns.Erp.Core.Admin.Domain
Imports Vns.Erp.Core.Admin.Service.Interface

Imports Vns.Erp.Core.Asset.Domain
Imports Vns.Erp.Core.Asset.Service.Interface

Public Class frmDieuChinhGiaTriTaiSan_ChiTiet
#Region "Property"
    Private _DmTscdService As IDmTscdService

    Public Property DmTscdService() As IDmTscdService
        Get
            Return _DmTscdService
        End Get
        Set(ByVal value As IDmTscdService)
            _DmTscdService = value
        End Set
    End Property
    Private _TsCtTscdNvonService As ITsCtTscdNvonService

    Public Property TsCtTscdNvonService() As ITsCtTscdNvonService
        Get
            Return _TsCtTscdNvonService
        End Get
        Set(ByVal value As ITsCtTscdNvonService)
            _TsCtTscdNvonService = value
        End Set
    End Property
    Private _HtDanhmucService As IHtDanhmucService

    Public Property HtDanhmucService() As IHtDanhmucService
        Get
            Return _HtDanhmucService
        End Get
        Set(ByVal value As IHtDanhmucService)
            _HtDanhmucService = value
        End Set
    End Property
    Private _DmNguonTscdService As IDmNguonTscdService

    Public Property DmNguonTscdService() As IDmNguonTscdService
        Get
            Return _DmNguonTscdService
        End Get
        Set(ByVal value As IDmNguonTscdService)
            _DmNguonTscdService = value
        End Set
    End Property
    Private _DmTaikhoanService As IDmTaikhoanService

    Public Property DmTaikhoanService() As IDmTaikhoanService
        Get
            Return _DmTaikhoanService
        End Get
        Set(ByVal value As IDmTaikhoanService)
            _DmTaikhoanService = value
        End Set
    End Property
    Private _CtTscdService As ICtTscdService

    Public Property CtTscdService() As ICtTscdService
        Get
            Return _CtTscdService
        End Get
        Set(ByVal value As ICtTscdService)
            _CtTscdService = value
        End Set
    End Property
    Private _DmLydoTgTscdService As IDmLydoTgTscdService

    Public Property DmLydoTgTscdService() As IDmLydoTgTscdService
        Get
            Return _DmLydoTgTscdService
        End Get
        Set(ByVal value As IDmLydoTgTscdService)
            _DmLydoTgTscdService = value
        End Set
    End Property
#End Region

#Region "Variable"

    Private m_InputState As FormGlobals.DataInputState
    Private m_CT_TSCD_ID As Guid
    Private m_DM_TSCD_ID As Guid
    Private obj_CT_TSCD As CtTscd = New CtTscd
    Private obj_DM_TSCD As DmTscd = New DmTscd
    Private lst_CT_TSCD As List(Of CtTscd) = New List(Of CtTscd)
    Private dt_nguonvon As List(Of TsCtTscdNvon) = New List(Of TsCtTscdNvon)
    Private lst_del As IList(Of TsCtTscdNvon) = New List(Of TsCtTscdNvon)
    Private obj_nguonVon As New TsCtTscdNvon
    Private LS_TSCD As TsLsKhauhao = New TsLsKhauhao
    Private dt_tk_khauhao As DataTable
    Private dt_tk_chiphi As DataTable
#End Region

#Region "Show_form"

    Public Sub New()
        InitializeComponent()
        TNCommon.setIconControl(Me)
    End Sub

    Public Function Show_Form(ByVal p_CT_TSCD_ID As Guid, ByVal p_DM_TSCD_ID As Guid, ByVal eState As DataInputState) As Boolean
        Try
            Form_SetText(Me, "Điều chỉnh giá trị tài sản", eState)
            Form_InitDialog(Me)
            m_InputState = eState
            m_CT_TSCD_ID = p_CT_TSCD_ID
            m_DM_TSCD_ID = p_DM_TSCD_ID
            'Control_SetRequire(txtTY_LE_HAOMON1, True)
            SetRequire()

            obj_DM_TSCD = _DmTscdService.GetById(p_DM_TSCD_ID)
            txtMA_TSCD.Text = obj_DM_TSCD.MaTscd
            txtTenTS.Text = obj_DM_TSCD.TenTscd

            Panel_InitControl(grcTHONG_TIN_CHINH, "CT_TSCD")
            frmProgress.Instance.Thread = AddressOf Init_Data
            frmProgress.Instance.Show_Progress()
        Catch ex As Exception
            Message_Error(ex)
        End Try
        Return (Me.ShowDialog = DialogResult.OK)
    End Function
#End Region

#Region "Functions"

    Private Sub Init_Data()
        Select Case m_InputState
            Case DataInputState.AddMode
                BindLookup()
                dt_nguonvon = New List(Of TsCtTscdNvon)
                grcNGUON_VON.DataSource = dt_nguonvon
            Case Else
                BindLookup()
                SetObjectToControl()
        End Select
    End Sub

    Private Sub SetRequire()
        Control_SetRequire(txtSO_THANG_SD1, True)
        Control_SetRequire(txtNGUYEN_GIA1, True)
        Control_SetRequire(txtHAO_MON_LUY_KE1, True)
        Control_SetRequire(txtGIA_TRI_CL1, True)
        Control_SetRequire(dteNgay_BD_KH1, True)
        Control_SetRequire(grlTANG_TSCD1, True)
        Control_SetRequire(dteNGAY_CT1, True)
        Control_SetRequire(txtSO_CT1, True)
        Control_SetRequire(grlLYDO_TANGGIAM, True)
    End Sub

    Private Function Check_Input() As Boolean

        If (txtGIA_TRI_CL1.Text = "" Or txtHAO_MON_LUY_KE1.Text = "" Or txtNGUYEN_GIA1.Text = "" Or txtSO_THANG_SD1.Text = "" _
                Or DB_GetString(grlTANG_TSCD1.EditValue) = "" Or DB_GetString(DB_GetNull(dteNGAY_CT1.DateTime)) = "" Or txtSO_CT1.Text = "" Or DB_GetString(grlLYDO_TANGGIAM.EditValue) = "") Then
            Message_Warning("Bạn chưa nhập giá trị cho trường bắt buộc")
            Return False
        End If

        If Not LimitValue.CheckVNDCurrency(Decimal.Parse(txtNGUYEN_GIA1.Text)) Then
            Message_Warning("Giá trị nguyên giá không hợp lệ")
            txtNGUYEN_GIA1.Focus()
            Return False
        End If

        If Not LimitValue.CheckVNDCurrency(Decimal.Parse(txtGIA_TRI_CL1.Text)) Then
            Message_Warning("Giá trị giá trị còn lại không hợp lệ")
            txtGIA_TRI_CL1.Focus()
            Return False
        End If

        If Not LimitValue.CheckVNDCurrency(Decimal.Parse(txtHAO_MON_LUY_KE1.Text)) Then
            Message_Warning("Giá trị hao mòn lũy kế không hợp lệ")
            txtHAO_MON_LUY_KE1.Focus()
            Return False
        End If

        Dim he_so As Decimal = 0
        Dim dv As IList(Of TsCtTscdNvon) = CType(grvNGUON_VON.DataSource, IList(Of TsCtTscdNvon))
        If (dv.Count <> 0) Then
            For Each drv As TsCtTscdNvon In dv

                If (drv.DmNguonTscdId = Null.NullGuid) Then
                    Message_Warning("Bạn chưa chọn nguồn vốn!")
                    Return False
                End If

                If (drv.TkKhauhao = Null.NullGuid) Then
                    Message_Warning("Bạn chưa nhập tài khoản khấu hao!")
                    Return False
                End If

                If (drv.TkChiphi = Null.NullGuid) Then
                    Message_Warning("Tài khoản chi phí nhập vào không đúng!")
                    Return False
                End If

                If drv.HeSoPbKh < 0 Then
                    Message_Warning("Hệ số phải lớn hơn 0")
                    Return False
                Else
                    he_so = he_so + drv.HeSoPbKh
                End If
            Next

            If (he_so <> 100) Then
                Message_Warning("Tổng hệ số phân bổ của nguồn vốn phải bằng 100%")
                Return False
            End If
        End If

        Return True
    End Function

    Private Sub BindLookup()

        Dim dt As IList(Of HtDanhmuc) = New List(Of HtDanhmuc)

        Dim dt_All As New List(Of HtDanhmuc)
        dt_All.AddRange(_HtDanhmucService.GetByDoiTuong("KIEU_THAYDOI_TSCD"))

        For Each dr_all As HtDanhmuc In dt_All
            Dim dr As New HtDanhmuc
            If (dr_all.GiaTri = 2 Or dr_all.GiaTri = 3) Then
                dr.GiaTri = dr_all.GiaTri
                dr.TenDanhmuc = dr_all.TenDanhmuc
                dt.Add(dr)
            End If
        Next
        grlTANG_TSCD1.Properties.DataSource = dt
        grlTANG_TSCD1.Properties.ValueMember = "GiaTri"
        grlTANG_TSCD1.Properties.DisplayMember = "TenDanhmuc"

        Dim objColumnDefine As ArrayList = New ArrayList
        objColumnDefine.Add(New LookupEdit_ColumnInfo("GiaTri", "Ký hiệu"))
        objColumnDefine.Add(New LookupEdit_ColumnInfo("TenDanhmuc", "Loại tăng giảm"))
        GridLookupEdit_BindData(grlTANG_TSCD1, dt, "TenDanhmuc", "GiaTri", COMBO_ITEM_REQUIRE, objColumnDefine)

        Dim dt_DM_nguon As New List(Of DmNguonTscd)
        dt_DM_nguon.AddRange(_DmNguonTscdService.GetAllByDonviID(Generals.DON_VI.Id))
        cboDM_NGUON_TSCD_ID.DataSource = dt_DM_nguon
        cboDM_NGUON_TSCD_ID.ValueMember = "Id"
        cboDM_NGUON_TSCD_ID.DisplayMember = "KyHieu"
        cboDM_NGUON_TSCD_ID.Columns.Add(New LookUpColumnInfo("KyHieu", "Ký hiệu"))
        cboDM_NGUON_TSCD_ID.Columns.Add(New LookUpColumnInfo("TenDmNguonTscd", "Tên nguồn vốn"))

        'bind tkts nguon von
        Dim dt_Tk As New List(Of DmTaikhoan)
        dt_Tk.AddRange(_DmTaikhoanService.GetAllByDonviID(Generals.DON_VI.Id))

        dt_tk_khauhao = Vns.Erp.Core.DataHelper.ToDataTable(dt_Tk)
        dt_tk_chiphi = Vns.Erp.Core.DataHelper.ToDataTable(dt_Tk)
    End Sub

    Private Sub GetControlToOBject()
        Dim Thu_Tu As Decimal
        Dim lst As List(Of CtTscd) = New List(Of CtTscd)
        lst.AddRange(_CtTscdService.GetObjectByIdDM_TSCD_DC(m_DM_TSCD_ID))

        Thu_Tu = lst.Count + 1
        'Panel_GetControlValue(grcTHONG_TIN_CHINH, obj_CT_TSCD)
        obj_CT_TSCD.TscdId = obj_DM_TSCD.Id
        obj_CT_TSCD.TenTscd = obj_DM_TSCD.TenTscd
        obj_CT_TSCD.KyHieuTscd = obj_DM_TSCD.KyHieu
        obj_CT_TSCD.DvtId = obj_DM_TSCD.DvtId
        obj_CT_TSCD.TenDvt = obj_DM_TSCD.TenDvt
        obj_CT_TSCD.LoaitaisanId = obj_DM_TSCD.LoaitaisanId
        obj_CT_TSCD.MaLoaitaisan = obj_DM_TSCD.MaLoaitaisan
        'obj_CT_TSCD.TkChiphi = obj_DM_TSCD.MdTkChiphi

        obj_CT_TSCD.NgayBdKh = dteNgay_BD_KH1.DateTime
        obj_CT_TSCD.NgayKtKh = dteNGAY_KT_KH1.DateTime
        obj_CT_TSCD.TangTscd = grlTANG_TSCD1.EditValue

        If grlLYDO_TANGGIAM.EditValue IsNot Nothing Then
            Dim obj_LYDOTG As DmLydoTgTscd = CType(ComboHelper.GetSelectData(grlLYDO_TANGGIAM), DmLydoTgTscd)
            obj_CT_TSCD.LydoTanggiam = obj_LYDOTG.Id
            obj_CT_TSCD.TenLydoTanggiam = obj_LYDOTG.TenLydoTgTscd
        Else
            obj_CT_TSCD.LydoTanggiam = Null.NullGuid
            obj_CT_TSCD.TenLydoTanggiam = ""
        End If

        obj_CT_TSCD.GiaTriCl = txtGIA_TRI_CL1.Text
        obj_CT_TSCD.HaoMonLuyKe = txtHAO_MON_LUY_KE1.Text
        obj_CT_TSCD.NguyenGia = txtNGUYEN_GIA1.Text
        obj_CT_TSCD.NgayKtKh = dteNGAY_KT_KH1.DateTime
        obj_CT_TSCD.SoThangSd = txtSO_THANG_SD1.Text
        obj_CT_TSCD.SoCt = txtSO_CT1.Text
        obj_CT_TSCD.NgayCt = dteNGAY_CT1.DateTime

        Dim dv_NV As IList(Of TsCtTscdNvon) = New List(Of TsCtTscdNvon)

        Select Case m_InputState
            Case DataInputState.AddMode
                obj_CT_TSCD.ThuTu = Thu_Tu
                _CtTscdService.Save(obj_CT_TSCD)

                dv_NV = CType(grvNGUON_VON.DataSource, IList(Of TsCtTscdNvon))
                If dv_NV.Count <> 0 Then
                    For Each drw_NV As TsCtTscdNvon In dv_NV
                        'Object_GetDataRawView(obj_nguonVon, drw_NV)
                        drw_NV.CtTscdId = obj_CT_TSCD.Id
                        _TsCtTscdNvonService.Save(drw_NV)
                    Next
                End If
            Case Else
                _CtTscdService.SaveOrUpdate(obj_CT_TSCD)

                'Update NGUON_VON
                ''lấy ra những row dc thêm mới khi update và insert vào CSDL
                'dv_NV = Grid_GetAddedRows(grvNGUON_VON)
                dv_NV = CType(grvNGUON_VON.DataSource, IList(Of TsCtTscdNvon))
                If dv_NV.Count <> 0 Then
                    For Each drw_NV_new As TsCtTscdNvon In dv_NV
                        'Object_GetDataRawView(obj_nguonVon, drw_NV_new)
                        drw_NV_new.CtTscdId = m_CT_TSCD_ID
                        If (drw_NV_new.Id = Null.NullGuid) Then
                            _TsCtTscdNvonService.Save(drw_NV_new)
                        Else
                            _TsCtTscdNvonService.SaveOrUpdate(drw_NV_new)
                        End If
                    Next
                End If
                ''Lấy ra những row dc delete và delete
                'dv_NV = Grid_GetDeletedRows(grvNGUON_VON)
                If dv_NV.Count <> 0 Then
                    For Each drw_Delete As TsCtTscdNvon In lst_del
                        _TsCtTscdNvonService.DeleteById(drw_Delete.Id)
                    Next
                End If
        End Select

    End Sub

    Private Sub SetObjectToControl()
        obj_CT_TSCD = _CtTscdService.GetById(m_CT_TSCD_ID)

        txtGIA_TRI_CL1.EditValue = obj_CT_TSCD.GiaTriCl
        txtSO_THANG_SD1.EditValue = obj_CT_TSCD.SoThangSd
        txtNGUYEN_GIA1.EditValue = obj_CT_TSCD.NguyenGia
        'txtNGUYEN_GIA1.EditValue = Format(CLng(obj_CT_TSCD.NGUYEN_GIA.ToString()), "n0")
        txtHAO_MON_LUY_KE1.EditValue = obj_CT_TSCD.HaoMonLuyKe
        'txtTY_LE_HAOMON1.Text = obj_CT_TSCD.TY_LE_HAOMON.ToString()
        grlTANG_TSCD1.EditValue = obj_CT_TSCD.TangTscd
        grlLYDO_TANGGIAM.EditValue = obj_CT_TSCD.LydoTanggiam

        txtSO_CT1.Text = obj_CT_TSCD.SoCt
        dteNGAY_CT1.DateTime = obj_CT_TSCD.NgayCt
        dteNgay_BD_KH1.DateTime = obj_CT_TSCD.NgayBdKh

        If DB_GetNull(obj_CT_TSCD.NgayKtKh).ToString <> "" Then
            dteNGAY_KT_KH1.DateTime = obj_CT_TSCD.NgayKtKh
        Else
            dteNGAY_KT_KH1.EditValue = Nothing
        End If

        dteNGAY_CT1.DateTime = Date.Parse(obj_CT_TSCD.NgayCt)
        'dteNGAY_KT_KH1.DateTime = Date.Parse(obj_CT_TSCD.NGAY_KT_KH)

        bindLyTangGiam(obj_CT_TSCD.TangTscd)
        'Panel_SetControlValue(grcTHONG_TIN_CHINH, obj_CT_TSCD, True)

        'bind  nguon von
        dt_nguonvon = New List(Of TsCtTscdNvon)()
        dt_nguonvon.AddRange(_TsCtTscdNvonService.GetAllByCT_TSCD_ID(m_CT_TSCD_ID))
        grcNGUON_VON.DataSource = dt_nguonvon

        LS_TSCD = _CtTscdService.KHAUHAO_VET_CUOI(m_DM_TSCD_ID, obj_CT_TSCD.NgayBdKh)
    End Sub

    Private Sub bindLyTangGiam(ByVal i As Decimal)
        Dim lst_LyDo_Tang_giam As New List(Of DmLydoTgTscd)
        lst_LyDo_Tang_giam.AddRange(_DmLydoTgTscdService.GetAllAllByLoai(i, Generals.DON_VI.Id))
        grlLYDO_TANGGIAM.Properties.DataSource = lst_LyDo_Tang_giam
        grlLYDO_TANGGIAM.Properties.ValueMember = "Id"
        grlLYDO_TANGGIAM.Properties.DisplayMember = "KyHieu"
    End Sub

#End Region

#Region "Events"

    Private Sub grlTANG_TSCD_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grlTANG_TSCD1.EditValueChanged
        Try
            grlLYDO_TANGGIAM.Properties.ReadOnly = False
            txtNGUYEN_GIA1.Properties.ReadOnly = False
            txtGIA_TRI_CL1.Properties.ReadOnly = False
            txtHAO_MON_LUY_KE1.Properties.ReadOnly = False
            bindLyTangGiam(Decimal.Parse(grlTANG_TSCD1.EditValue))
            grlLYDO_TANGGIAM.EditValue = Nothing
            'grlMD_TK_CHIPHI
            Dim htdm As HtDanhmuc = ComboHelper.GetSelectData(grlTANG_TSCD1)
            If Not htdm Is Nothing Then
                txtTenTangGiam.Text = htdm.GiaTri
                txtNGUYEN_GIA1_TextChanged(sender, e)
            End If
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Try
            If Not Check_Input() Then
                Exit Sub
            End If

            If err.GetError(dteNgay_BD_KH1) = "" And err.GetError(dteNGAY_KT_KH1) = "" Then
                frmProgress.Instance.Thread = AddressOf GetControlToOBject
                frmProgress.Instance.Show_Progress()
                frmProgress.Instance.SetFinishText("Ghi dữ liệu thành công")
                DialogResult = System.Windows.Forms.DialogResult.OK
            Else
                Message_Warning("Vui lòng kiểm tra lại dữ liệu đã nhập")
            End If
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Try
            Me.Close()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub frmDieuChinhGiaTriTaiSan_ChiTiet_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Try
            Select Case e.KeyCode
                Case Keys.Escape
                    Me.Close()
            End Select
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub dteNgay_BD_KH_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles dteNgay_BD_KH1.Validating
        Try
            lst_CT_TSCD = New List(Of CtTscd)
            lst_CT_TSCD.AddRange(_CtTscdService.GetObjectByIdDM_TSCD_DC(m_DM_TSCD_ID))
            If (DB_GetNull(dteNgay_BD_KH1.DateTime).ToString = "") Then
                err.SetError(dteNgay_BD_KH1, "Bạn chưa nhập ngày khấu hao")
                err.SetIconAlignment(dteNgay_BD_KH1, ErrorIconAlignment.MiddleRight)
                e.Cancel = True
            ElseIf (dteNgay_BD_KH1.DateTime < lst_CT_TSCD(lst_CT_TSCD.Count - 1).NgayBdKh And m_InputState = DataInputState.AddMode) Then
                err.SetError(dteNgay_BD_KH1, "Ngày khấu hao phải lớn hơn ngày khấu hao của vệt trước :" + lst_CT_TSCD(lst_CT_TSCD.Count - 1).NgayBdKh)
                err.SetIconAlignment(dteNgay_BD_KH1, ErrorIconAlignment.MiddleRight)
                e.Cancel = True
            Else
                err.SetError(dteNgay_BD_KH1, "")
                e.Cancel = False
            End If
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub grlLYDO_TANGGIAM_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grlLYDO_TANGGIAM.EditValueChanged
        Try
            Dim obj As DmLydoTgTscd = ComboHelper.GetSelectData(grlLYDO_TANGGIAM)
            If Not (obj Is Nothing) Then
                txtTenLyDo.Text = obj.TenLydoTgTscd
            Else
                txtTenLyDo.Text = String.Empty
            End If
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub Tinh()
        If LS_TSCD IsNot Nothing Then
            If txtNGUYEN_GIA1.Text <> "" Then
                If grlTANG_TSCD1.EditValue = 3 Then
                    txtGIA_TRI_CL1.Text = (LS_TSCD.GiaTriCl - VnsConvert.CDecimal(txtNGUYEN_GIA1.Text)).ToString
                    txtHAO_MON_LUY_KE1.Text = LS_TSCD.HaoMonLk.ToString
                ElseIf grlTANG_TSCD1.EditValue = 2 Then
                    txtGIA_TRI_CL1.Text = (LS_TSCD.GiaTriCl + VnsConvert.CDecimal(txtNGUYEN_GIA1.Text)).ToString
                    txtHAO_MON_LUY_KE1.Text = LS_TSCD.HaoMonLk.ToString
                End If
            End If
        End If
    End Sub

    Private Sub txtNGUYEN_GIA1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNGUYEN_GIA1.TextChanged
        Try
            If DB_GetString(DB_GetNull(dteNgay_BD_KH1.DateTime)) <> "" Then
                Tinh()
            End If
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub grvNGUON_VON_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles grvNGUON_VON.KeyDown
        Try
            Select Case e.KeyCode
                Case Keys.F8
                    If grvNGUON_VON.RowCount <> 0 Then
                        Dim del As TsCtTscdNvon = CType(grvNGUON_VON.GetRow(grvNGUON_VON.FocusedRowHandle), TsCtTscdNvon)
                        lst_del.Add(del)
                        Grid_DeleteSelectRows(grvNGUON_VON)
                    Else
                        Message_Warning("Không có bản ghi nào được chọn!")
                    End If
                Case Keys.F4
                    GridAddNewRow(sender, True)
                    'dt_nguonvon.Add(New TsCtTscdNvon())
                    'grvNGUON_VON.RefreshData()
                    'Grid_AddRow(grvNGUON_VON)
                Case Keys.Enter
                    GridAddNewRow(sender, True)
            End Select
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub dteNgay_BD_KH_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dteNgay_BD_KH1.Validated
        Try
            LS_TSCD = _CtTscdService.KHAUHAO_VET_CUOI(m_DM_TSCD_ID, dteNgay_BD_KH1.DateTime)

            If LS_TSCD Is Nothing Then
                Message_Warning("Bạn chưa tính khấu hao cho vệt trước hoặc ngày BDKH nhỏ hơn ngày tính khấu hao nhỏ nhất!")
                Return
            End If

            Tinh()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub dteNGAY_KT_KH_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles dteNGAY_KT_KH1.Validating
        Try
            If (DB_GetNull(dteNGAY_KT_KH1.DateTime).ToString <> "" And dteNGAY_KT_KH1.DateTime < dteNgay_BD_KH1.DateTime) Then
                err.SetError(dteNGAY_KT_KH1, "Ngày kết thúc khấu hao phải >= ngày bắt đầu khấu hao")
                err.SetIconAlignment(dteNGAY_KT_KH1, ErrorIconAlignment.MiddleRight)
                e.Cancel = True
            Else
                err.SetError(dteNGAY_KT_KH1, "")
                e.Cancel = False
            End If
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

#End Region

#Region "Dành cho grid"

    'Check Validate cho Grid
    Private Function ExistError(ByVal grv As GridView) As Boolean
        For Each gcol As GridColumn In grv.Columns
            If grv.GetColumnError(gcol) <> "" Or grv.GetColumnError(gcol) = Nothing Then
                Return True
            End If
        Next

        Return False
    End Function

    Private Sub GridAddNewRow(ByVal grv As DevExpress.XtraGrid.Views.Grid.GridView, Optional ByVal byTab As Boolean = False)
        'Chưa có DataSource
        If grv.DataSource Is Nothing Then
            Message_Warning("Chưa có thì thêm vào!!!")
            Exit Sub
        End If
        'Trường hợp Grid rỗng
        If grv.RowCount = 0 Then
            dt_nguonvon.Add(New TsCtTscdNvon())
            grv.RefreshData()
            'Nếu là Enter key --> Nhảy 1 tab (bỏ qua cell check Xóa)
            If Not byTab Then
                SendKeys.Send("{TAB}")
            End If
            '
            Exit Sub
        End If
        'Trường hợp ở dòng dưới cùng của Grid
        Dim maxIndex As Int16 = -1
        'Xét Grid đang ở dòng dưới cùng (không sử dụng đc grv.IsLastRow)
        'Tình trạng đang có 1 dòng thêm mới --> Focus chắc chắn đang ở dòng dưới cùng của Grid
        'Khi có 1 dòng được thêm mới sẽ chưa có sự tương ứng giữa View & DataSource cho đến khi dữ liệu đc cập nhật
        'Ví dụ: FocusRowHandle là Null, DataRowCount < RowCount...
        '--- Trường hợp: Là dòng dưới cùng thực sự
        If (GridHelper.CheckAddNewRow(grv)) Then
            dt_nguonvon.Add(New TsCtTscdNvon())
            grv.RefreshData()
        End If

    End Sub


    Private Sub rpeTK_TAISAN_FisrtBinddata(ByVal senders As System.Object, ByVal e As System.EventArgs) Handles rpeTK_TAISAN.FisrtBinddata
        Try
            rpeTK_TAISAN.C_DATA_SOURCE = dt_tk_khauhao
            rpeTK_TAISAN.Editors.A_DATA_SOURCE = rpeTK_TAISAN.C_DATA_SOURCE
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub rpeTK_TAISAN_AfterFilter(ByVal senders As System.Object, ByVal e As System.EventArgs) Handles rpeTK_TAISAN.AfterFilter
        Try
            Dim dr_grv_NGUONVON As TsCtTscdNvon = grvNGUON_VON.GetRow(grvNGUON_VON.FocusedRowHandle)
            If dr_grv_NGUONVON Is Nothing Then
                Return
            End If
            If rpeTK_TAISAN.OwnerEdit.A_LIST_VALUES.Count <> 0 Then
                rpeTK_TAISAN.Tag = rpeTK_TAISAN.OwnerEdit.A_LIST_VALUES(0)
                dr_grv_NGUONVON.TkKhauhao = VnsConvert.CGuid(rpeTK_TAISAN.OwnerEdit.A_LIST_VALUES(0))
                dr_grv_NGUONVON.MaTkKhauhao = rpeTK_TAISAN.OwnerEdit.A_LIST_VALUES(1)
                grvNGUON_VON.SetRowCellValue(grvNGUON_VON.FocusedRowHandle, "MaTkKhauhao", dr_grv_NGUONVON.MaTkKhauhao)
            End If
            SendKeys.Send("{TAB}")
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub rpeTK_TAISAN_ClearDataFilter(ByVal senders As System.Object, ByVal e As System.EventArgs) Handles rpeTK_TAISAN.ClearDataFilter
        Try
            Dim dr_grv_NGUONVON As TsCtTscdNvon = grvNGUON_VON.GetRow(grvNGUON_VON.FocusedRowHandle)
            If dr_grv_NGUONVON Is Nothing Then
                Return
            End If
            If rpeTK_TAISAN.OwnerEdit.A_LIST_VALUES.Count <> 0 Then
                rpeTK_TAISAN.Tag = rpeTK_TAISAN.OwnerEdit.A_LIST_VALUES(0)
                dr_grv_NGUONVON.TkKhauhao = VnsConvert.CGuid(rpeTK_TAISAN.OwnerEdit.A_LIST_VALUES(0))
                dr_grv_NGUONVON.MaTkKhauhao = rpeTK_TAISAN.OwnerEdit.A_LIST_VALUES(1)
            End If
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub rpeTK_CHIPHI_FisrtBinddata(ByVal senders As System.Object, ByVal e As System.EventArgs) Handles rpeTK_CHIPHI.FisrtBinddata
        Try
            rpeTK_CHIPHI.C_DATA_SOURCE = dt_tk_khauhao
            rpeTK_CHIPHI.Editors.A_DATA_SOURCE = rpeTK_CHIPHI.C_DATA_SOURCE
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub rpeTK_CHIPHI_AfterFilter(ByVal senders As System.Object, ByVal e As System.EventArgs) Handles rpeTK_CHIPHI.AfterFilter
        Try
            Dim dr_grv_NGUONVON As TsCtTscdNvon = grvNGUON_VON.GetRow(grvNGUON_VON.FocusedRowHandle)
            If dr_grv_NGUONVON Is Nothing Then
                Return
            End If
            If rpeTK_CHIPHI.OwnerEdit.A_LIST_VALUES.Count <> 0 Then
                rpeTK_CHIPHI.Tag = rpeTK_CHIPHI.OwnerEdit.A_LIST_VALUES(0)
                dr_grv_NGUONVON.TkChiphi = VnsConvert.CGuid(rpeTK_CHIPHI.OwnerEdit.A_LIST_VALUES(0))
                dr_grv_NGUONVON.MaTkChiphi = rpeTK_CHIPHI.OwnerEdit.A_LIST_VALUES(1)
                grvNGUON_VON.SetRowCellValue(grvNGUON_VON.FocusedRowHandle, "MaTkChiphi", dr_grv_NGUONVON.MaTkChiphi)
            End If
            SendKeys.Send("{TAB}")
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub rpeTK_CHIPHI_ClearDataFilter(ByVal senders As System.Object, ByVal e As System.EventArgs) Handles rpeTK_CHIPHI.ClearDataFilter
        Try
            Dim dr_grv_NGUONVON As TsCtTscdNvon = grvNGUON_VON.GetRow(grvNGUON_VON.FocusedRowHandle)
            If dr_grv_NGUONVON Is Nothing Then
                Return
            End If

            If rpeTK_CHIPHI.OwnerEdit.A_LIST_VALUES.Count <> 0 Then
                rpeTK_CHIPHI.Tag = rpeTK_CHIPHI.OwnerEdit.A_LIST_VALUES(0)
                dr_grv_NGUONVON.TkChiphi = VnsConvert.CGuid(rpeTK_CHIPHI.OwnerEdit.A_LIST_VALUES(0))
                dr_grv_NGUONVON.MaTkChiphi = rpeTK_CHIPHI.OwnerEdit.A_LIST_VALUES(1)
                'grvNGUON_VON.SetRowCellValue(grvNGUON_VON.FocusedRowHandle, "MA_TK_CHIPHI", dr_grv_NGUONVON("MA_TK_CHIPHI"))
            End If
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

#End Region


End Class