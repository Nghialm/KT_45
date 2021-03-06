Imports System
Imports System.Data
Imports System.IO
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports Vns.Erp.Core.Admin.Domain
Imports Vns.Erp.Core.Admin.Service.Interface

Public Class frmButToanKetChuyen_ChiTiet
    Dim _DmBtKetchuyenService As IDmBtKetchuyenService
    Public Property DmBtKetchuyenService() As IDmBtKetchuyenService
        Get
            Return _DmBtKetchuyenService
        End Get
        Set(value As IDmBtKetchuyenService)
            _DmBtKetchuyenService = value
        End Set
    End Property

    Dim _DmTaikhoanService As IDmTaikhoanService
    Public Property DmTaikhoanService() As IDmTaikhoanService
        Get
            Return _DmTaikhoanService
        End Get
        Set(value As IDmTaikhoanService)
            _DmTaikhoanService = value
        End Set
    End Property

    Dim _HtDanhmucService As IHtDanhmucService
    Public Property HtDanhmucService() As IHtDanhmucService
        Get
            Return _HtDanhmucService
        End Get
        Set(value As IHtDanhmucService)
            _HtDanhmucService = value
        End Set
    End Property

    Private objBTKChuyen As DmBtKetchuyen = New DmBtKetchuyen()
    'Private objBTKChuyenBO As DM_Bt_KetchuyenBO
    Private m_InputState As FormGlobals.DataInputState
    Private m_BT_KC As Guid

    Public Sub New()
        InitializeComponent()
        '
    End Sub


    Public Function Show_Form(ByVal DM_BT_KETCHUYEN_ID As Guid, ByVal eState As DataInputState) As Boolean
        Form_SetText(Me, "Bút toán kết chuyển", eState)
        Form_InitDialog(Me)
        TNCommon.setIconControl(Me)
        'Panel_InitControl(grpButChuyenTuDong, "DM_BT_KETCHUYEN")
        'Control_SetRequire(txtTHU_TU1, True)
        'Control_SetRequire(txtTEN_BT_KETCHUYEN, True)
        m_InputState = eState
        m_BT_KC = DM_BT_KETCHUYEN_ID
        Init_Data()

        'frmProgress.Instance.Thread = AddressOf Init_Data
        'frmProgress.Instance.Show_Progress()

        Return (Me.ShowDialog = Windows.Forms.DialogResult.OK)
    End Function

    Private Sub Init_Data()
        Select Case m_InputState
            Case DataInputState.AddMode
                BindLoookUpNX()
            Case Else
                BindLoookUpNX()
                SetObjectToControl()
        End Select
    End Sub

    Private Sub BindLoookUpNX()
        'List DmTaikhoan secondList = new List DmTaikhoan firstList);
        Dim objColumnDefine As ArrayList
        'Bind tai khoan nợ

        Dim lstDM_Tkhoan As List(Of DmTaikhoan) = New List(Of DmTaikhoan)
        lstDM_Tkhoan.AddRange(_DmTaikhoanService.GetAllByDonviID(Generals.DON_VI.Id))
        objColumnDefine = New ArrayList
        objColumnDefine.Add(New LookupEdit_ColumnInfo("MaTaikhoan", "Mã tài khoản"))
        objColumnDefine.Add(New LookupEdit_ColumnInfo("TenTaikhoan", "Tên tài khoản"))
        GridLookupEdit_BindData(grlID_TK_NO, lstDM_Tkhoan, "MaTaikhoan", "Id", COMBO_ITEM_REQUIRE, objColumnDefine)

        'Bind tai khoan có
        Dim lstTKCo As List(Of DmTaikhoan) = New List(Of DmTaikhoan)
        lstTKCo.AddRange(_DmTaikhoanService.GetAllByDonviID(Generals.DON_VI.Id))
        objColumnDefine = New ArrayList
        objColumnDefine.Add(New LookupEdit_ColumnInfo("MaTaikhoan", "Mã tài khoản"))
        objColumnDefine.Add(New LookupEdit_ColumnInfo("TenTaikhoan", "Tên tài khoản"))
        GridLookupEdit_BindData(grlID_TK_CO, lstTKCo, "MaTaikhoan", "Id", COMBO_ITEM_REQUIRE, "TenTaikhoan", objColumnDefine)

        'Bind loại kết chuyển
        Dim lstLKChuyen As List(Of HtDanhmuc) = New List(Of HtDanhmuc)
        lstLKChuyen.AddRange(_HtDanhmucService.GetByDoiTuong("LOAI_KETCHUYEN"))
        objColumnDefine = New ArrayList
        objColumnDefine.Add(New LookupEdit_ColumnInfo("TenDanhmuc", "Loại kết chuyển"))
        GridLookupEdit_BindData(grlLOAI_KETCHUYEN, lstLKChuyen, "TenDanhmuc", "GiaTri", COMBO_ITEM_REQUIRE, "", objColumnDefine)
    End Sub

    Private Sub GetControlToOBject()

        'Panel_GetControlValue(grpButChuyenTuDong, objBTKChuyen)
        'lấy dữ liệu từ nhiều bảng 
        objBTKChuyen.TenBtKetchuyen = txtTEN_BT_KETCHUYEN.Text
        objBTKChuyen.DonviId = Generals.DON_VI.Id
        Dim drTKNo As DmTaikhoan = CType(ComboHelper.GetSelectData(grlID_TK_NO), DmTaikhoan)
        objBTKChuyen.IdTkNo = drTKNo.Id
        objBTKChuyen.MaTkNo = drTKNo.MaTaikhoan
        objBTKChuyen.TenTkNo = drTKNo.TenTaikhoan
        Dim drTKCo As DmTaikhoan = CType(ComboHelper.GetSelectData(grlID_TK_CO), DmTaikhoan)
        objBTKChuyen.IdTkCo = drTKCo.Id
        objBTKChuyen.MaTkCo = drTKCo.MaTaikhoan
        objBTKChuyen.TenTkCo = drTKCo.TenTaikhoan
        objBTKChuyen.NguoiTao = Generals.USER.Id
        objBTKChuyen.NguoiSua = Generals.USER.Id
        Dim drHtLoaiKc As HtDanhmuc = CType(ComboHelper.GetSelectData(grlLOAI_KETCHUYEN), HtDanhmuc)
        objBTKChuyen.LoaiKetchuyen = drHtLoaiKc.GiaTri

        objBTKChuyen.KcVuviec = VnsConvert.CDecimal(chkKC_VUVIEC.Checked)
        objBTKChuyen.KcKh = VnsConvert.CDecimal(chkKC_KH.Checked)
        objBTKChuyen.KcPhi = VnsConvert.CDecimal(chkKC_PHI.Checked)
        objBTKChuyen.KcCongtrinh = VnsConvert.CDecimal(chkKC_CONGTRINH.Checked)
        objBTKChuyen.KcBpht = VnsConvert.CDecimal(chkKC_BPHT.Checked)
        objBTKChuyen.KcHopdong = VnsConvert.CDecimal(chkKC_HOPDONG.Checked)
        objBTKChuyen.KcTudo1 = VnsConvert.CDecimal(chkKC_TUDO_1.Checked)
        objBTKChuyen.KcTudo2 = VnsConvert.CDecimal(chkKC_TUDO_2.Checked)
        objBTKChuyen.KcTudo3 = VnsConvert.CDecimal(chkKC_TUDO_3.Checked)
        objBTKChuyen.KcTudo4 = VnsConvert.CDecimal(chkKC_TUDO_4.Checked)
        objBTKChuyen.KcTudo5 = VnsConvert.CDecimal(chkKC_TUDO_5.Checked)

        objBTKChuyen.ThuTu = Decimal.Parse(txtTHU_TU1.Text)
        ' Sử lý insert,update
        Select Case m_InputState
            Case DataInputState.AddMode
                objBTKChuyen = InsertBT_KChuyen(objBTKChuyen)
            Case Else
                UpdateBT_KChuyen(objBTKChuyen)
        End Select
    End Sub

    Private Sub SetObjectToControl()
        objBTKChuyen = DmBtKetchuyenService.GetById(m_BT_KC)
        'Panel_SetControlValue(grpButChuyenTuDong, objBTKChuyen, True)
        txtTHU_TU1.Text = objBTKChuyen.ThuTu.ToString
        txtTEN_BT_KETCHUYEN.Text = objBTKChuyen.TenBtKetchuyen
        grlID_TK_NO.EditValue = objBTKChuyen.IdTkNo
        grlID_TK_CO.EditValue = objBTKChuyen.IdTkCo
        grlLOAI_KETCHUYEN.EditValue = objBTKChuyen.LoaiKetchuyen
        chkKC_VUVIEC.Checked = VnsConvert.CBoolean(objBTKChuyen.KcVuviec)
        chkKC_KH.Checked = VnsConvert.CBoolean(objBTKChuyen.KcVuviec)
        chkKC_PHI.Checked = VnsConvert.CBoolean(objBTKChuyen.KcPhi)
        chkKC_CONGTRINH.Checked = VnsConvert.CBoolean(objBTKChuyen.KcCongtrinh)
        chkKC_BPHT.Checked = VnsConvert.CBoolean(objBTKChuyen.KcBpht)
        chkKC_HOPDONG.Checked = VnsConvert.CBoolean(objBTKChuyen.KcHopdong)
        chkKC_TUDO_1.Checked = VnsConvert.CBoolean(objBTKChuyen.KcTudo1)
        chkKC_TUDO_2.Checked = VnsConvert.CBoolean(objBTKChuyen.KcTudo2)
        chkKC_TUDO_3.Checked = VnsConvert.CBoolean(objBTKChuyen.KcTudo3)
        chkKC_TUDO_4.Checked = VnsConvert.CBoolean(objBTKChuyen.KcTudo4)
        chkKC_TUDO_5.Checked = VnsConvert.CBoolean(objBTKChuyen.KcTudo5)
    End Sub

    Private Function InsertBT_KChuyen(ByVal _objBTKChuyen As DmBtKetchuyen) As DmBtKetchuyen
        Return DmBtKetchuyenService.Save(_objBTKChuyen)
    End Function

    Private Sub UpdateBT_KChuyen(ByVal _objBTKChuyen As DmBtKetchuyen)
        DmBtKetchuyenService.SaveOrUpdate(_objBTKChuyen)
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Try
            If txtTHU_TU1.Text = "" Then
                Message_Warning("Bạn chưa giá trị cho trường bắt buộc!")
                Return
            End If

            If Panel_CheckError(grpButChuyenTuDong) Then
                frmProgress.Instance.Thread = AddressOf GetControlToOBject
                frmProgress.Instance.Show_Progress()
                frmProgress.Instance.SetFinishText("Ghi dữ liệu thành công") '"Data saved"
                DialogResult = System.Windows.Forms.DialogResult.OK
            End If
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub btnNhapLai_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCle.Click
        Try
            Control_ClearData(grpButChuyenTuDong)
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub SimpleButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQui.Click
        Try
            Me.Close()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub grlID_TK_CO_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grlID_TK_CO.EditValueChanged
        Try
            If (Not VnsCheck.IsNullGuid(grlID_TK_CO.EditValue)) Then
                Dim drTKCo As DmTaikhoan = grlID_TK_CO.Properties.View.GetRow(grlID_TK_CO.Properties.View.FocusedRowHandle)
                'lblTEN_TK_CO.Text = drTKCo.TENTAIKHOAN
            End If
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub frmButToanKetChuyen_ChiTiet_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            chkKC_TUDO_1.Text = "KC theo " + Generals.TS_TuDo1.GiaTri
            chkKC_TUDO_2.Text = "KC theo " + Generals.TS_TuDo2.GiaTri
            chkKC_TUDO_3.Text = "KC theo " + Generals.TS_TuDo3.GiaTri
            chkKC_TUDO_4.Text = "KC theo " + Generals.TS_TuDo4.GiaTri
            chkKC_TUDO_5.Text = "KC theo " + Generals.TS_TuDo5.GiaTri
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub frmButToanKetChuyen_ChiTiet_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub
End Class