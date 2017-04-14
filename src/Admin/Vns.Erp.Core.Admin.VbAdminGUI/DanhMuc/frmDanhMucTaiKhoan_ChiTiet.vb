Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraEditors

Imports DevExpress.XtraEditors.DXErrorProvider
Imports System.Collections
Imports Vns.Erp.Core.Admin.Domain
Imports Vns.Erp.Core.Admin.Service
Imports Vns.Erp.Core.Admin.Service.Interface

Partial Public Class frmDanhMucTaiKhoan_ChiTiet
    Inherits FrmBaseDmChiTiet

#Region "Variables and Messages"

    Private obj_DM_TK_ChiTiet As DmTkChitiet
    Private lstobj_DM_TK_ChiTiet As List(Of DmTkChitiet)
    Private del_lstobj_DM_TK_ChiTiet As List(Of DmTkChitiet)
    Private obj As DmTaikhoan = New DmTaikhoan
    Dim str_Ma_tk As String
    Dim dt_tk As IList(Of DmTaikhoan)
    Dim parent_lv As Integer = 0
    Dim parentIdOld As Guid
    Dim parentIdNew As Guid
    Dim _DmTaikhoanService As IDmTaikhoanService
    Public Property DmTaikhoanService() As IDmTaikhoanService
        Get
            Return _DmTaikhoanService
        End Get
        Set(ByVal value As IDmTaikhoanService)
            _DmTaikhoanService = value
        End Set
    End Property

    Dim _DmTkChitietService As IDmTkChitietService
    Public Overridable Property DmTkChitietService() As IDmTkChitietService
        Get
            Return _DmTkChitietService
        End Get
        Set(ByVal value As IDmTkChitietService)
            _DmTkChitietService = value
        End Set
    End Property

    Public Property ObjectInfo() As DmTaikhoan
        'Lay du lieu tu các truong du lieu trên form gán cho thuoc tính tuong ung cua doi tuong Info roi tra ve doi tuong Info dó
        Get
            Dim info As DmTaikhoan = New DmTaikhoan()
            If Not ID Is Nothing Then
                info.Id = ID
            End If
            'FormGlobals.Panel_GetControlValue(Me._GroupControlObjectInfo, info)
            info.MaTaikhoan = Me.txtMA_TAIKHOAN1.Text
            info.TenTaikhoan = Me.txtTEN_TAIKHOAN.Text
            info.MoTa = mmeMO_TA.Text

            info.DonviId = Generals.DON_VI.Id
            info.MaDonvi = Generals.DON_VI.MaDonvi
            info.CoSuDung = TNCommon.ParseDecimal(chkCO_SU_DUNG.Checked)
            info.ChoPhepSua = TNCommon.ParseDecimal(chkCHO_PHEP_SUA.Checked)
            info.InBcd = TNCommon.ParseDecimal(chkIN_BCD.Checked)
            info.TkNb = TNCommon.ParseDecimal(chkTB_NB.Checked)
            info.TinhChat = cboTINH_CHAT1.EditValue.ToString()

            info.TaikhoanIdCha = VnsConvert.CGuid(cFilterTaiKhoan.ListEditValue(0))
            info.TenTaikhoan = txtTEN_TAIKHOAN.Text
            info.MaTaikhoan = txtMA_TAIKHOAN_CHA1.Text + txtMA_TAIKHOAN1.Text
            info.NguoiTao = Generals.USER.Id
            info.NguoiSua = Generals.USER.Id
            info.Cap = GetLevel(VnsConvert.CGuid(cFilterTaiKhoan.ListEditValue(0)), parent_lv)
            info.ChiTiet = TNCommon.ParseDecimal(cboChiTiet.Checked)

            'info.MA_TAIKHOAN = string.IsNullOrEmpty(_temp.MA_TAIKHOAN) ? " " : _temp.MA_TAIKHOAN;
            

            'If VnsCheck.IsNullGuid(obj.TaikhoanIdCha) Then
            '    obj.ChiTiet = 1
            'Else
            '    obj.ChiTiet = 0
            'End If

            MyBase.ResultObject = info
            'info.TaikhoanIdCha = gr.TaikhoanIdCha1.EditValue.ToString() ' drDMCHA[.TaikhoanId"].ToString();
            Return info
        End Get

        'Lay du lieu tu các thuoc tính cua doi tuong Info gán cho các truong tuong ung trên form
        Set(ByVal value As DmTaikhoan)
            If Not value Is Nothing Then
                obj = TryCast(value, DmTaikhoan)
                'FormGlobals.Panel_SetControlValue(_GroupControlObjectInfo, obj)
                txtMA_TAIKHOAN1.Text = obj.MaTaikhoan
                txtTEN_TAIKHOAN.Text = obj.TenTaikhoan
                mmeMO_TA.Text = obj.MoTa
                chkCO_SU_DUNG.Checked = TNCommon.ParseBool(obj.CoSuDung)
                chkCHO_PHEP_SUA.Checked = TNCommon.ParseBool(obj.ChoPhepSua)
                chkCHI_TIET.Checked = TNCommon.ParseBool(obj.ChiTiet)
                chkIN_BCD.Checked = TNCommon.ParseBool(obj.InBcd)
                chkTB_NB.Checked = TNCommon.ParseBool(obj.TkNb)
                cboTINH_CHAT1.EditValue = obj.TinhChat
                parentIdOld = obj.TaikhoanIdCha
                RemoveHandler cFilterTaiKhoan.ClearFilterData, AddressOf cFilterTaiKhoan_ClearFilterData
                parent_lv = obj.Cap
                cFilterTaiKhoan.Tag = obj.TaikhoanIdCha
                cFilterTaiKhoan.Text = Return_maTK(obj.TaikhoanIdCha.ToString)
                txtMA_TAIKHOAN_CHA1.Text = Return_maTK(obj.TaikhoanIdCha.ToString)
                str_Ma_tk = obj.MaTaikhoan
                MaTkCu = obj.MaTaikhoan
                Dim macha As String = txtMA_TAIKHOAN_CHA1.Text
                txtMA_TAIKHOAN1.Text = obj.MaTaikhoan.Remove(0, macha.Length)
                cboChiTiet.Checked = TNCommon.ParseBool(obj.ChiTiet)
                AddHandler cFilterTaiKhoan.ClearFilterData, AddressOf cFilterTaiKhoan_ClearFilterData

                SetObjectToControl()
            End If
        End Set
    End Property
#End Region
    
#Region "Construction"
    Public Sub New()
        InitializeComponent()
        TNCommon.setIconControl(Me)
    End Sub
#End Region

#Region "Load Form"
    Public Overrides Sub InitProperty()
        ButtonSave = btnSave
        ButtonCancel = btnCancel
        GroupControlObjectInfo = _GroupControlObjectInfo
        Me.ActiveControl = cFilterTaiKhoan
        CommonInit()
    End Sub

    Public Overrides Sub BindLookUpEdit()

        Dim dr As DataRow

        'Dim dtDMCHA As DataTable = DMTaikhoanService().GetAllByDonviID(Generals.DON_VI.ID.Replace("-", "")).Tables(0)
        'Dim _DMCHAColumnDefine As ArrayList = New ArrayList()
        '_DMCHAColumnDefine.Add(New ColumnInfo("MA_TAIKHOAN", "Mã nhóm tài khoản", 0, True, ""))
        '_DMCHAColumnDefine.Add(New ColumnInfo("TEN_TAIKHOAN", "Tên nhóm tài khoản", 0, True, ""))
        'dr = dtDMCHA.NewRow()
        'dr("TEN_TAIKHOAN") = "Danh mục gốc"
        'dr(.TaikhoanId") = Guid.Empty.ToString().Replace("-", "")
        'dr("MA_TAIKHOAN") = ""
        'dtDMCHA.Rows.InsertAt(dr, 0)
        'TNCommon.BindData_GridLookUp(gr.TaikhoanIdCha1, dtDMCHA, "MA_TAIKHOAN", .TaikhoanId", _DMCHAColumnDefine, True, True)
        'TNCommon.SelectFirst(gr.TaikhoanIdCha1)

        'Bind tính ch?t
        Dim dtTinhChat As DataTable = New DataTable()
        dtTinhChat.Columns.Add("ID", GetType(String))
        dtTinhChat.Columns.Add("Ten", GetType(String))
        dr = dtTinhChat.NewRow()
        dr("ID") = "N"
        dr("Ten") = "Nợ"
        dtTinhChat.Rows.Add(dr)
        dr = dtTinhChat.NewRow()
        dr("ID") = "C"
        dr("Ten") = "Có"
        dtTinhChat.Rows.Add(dr)
        dr = dtTinhChat.NewRow()
        dr("ID") = "L"
        dr("Ten") = "Lưỡng tính"
        dtTinhChat.Rows.Add(dr)

        Dim TinhChatComlumnDefine As ArrayList = New ArrayList()
        TinhChatComlumnDefine.Add(New ColumnInfo("Ten", "Tên", 0, True, ""))
        TNCommon.BindData_LookupEdit(cboTINH_CHAT1, dtTinhChat, "Ten", "ID", TinhChatComlumnDefine, False, True)
    End Sub

    Private _temp As DmTaikhoan = New DmTaikhoan()
    Public Overrides Sub BindData()
        _temp = DmTaikhoanService().GetById(ID)
        ObjectInfo = _temp
    End Sub

    Private info As DmTaikhoan = New DmTaikhoan()
    Public Overrides Sub Saving()
        If (Not Check_input()) Then Return

        info = CType(ObjectInfo, DmTaikhoan)
        Select Case Mode
            Case FormGlobals.DataInputState.AddMode
                ID = DmTaikhoanService().SaveOrUpdate(info).Id
                cboTINH_CHAT1.ItemIndex = 0
                GetControlToOBject()
                SaveTK_ChiTiet()
                ' DeleteTK_ChiTiet()
            Case FormGlobals.DataInputState.EditMode
                DmTaikhoanService().SaveOrUpdate(info)
                GetControlToOBject()
                SaveTK_ChiTiet()
                DeleteTK_ChiTiet()
        End Select

        SetChiTiet(parentIdOld, parentIdNew)
        AfterSaveSuccess()
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub
#End Region

#Region "Private Function and Procedures"

    Private Function GetLevel(ByVal parent_id As Guid, ByVal parent_lv As Integer) As Integer
        Dim lv As Integer
        If Not VnsCheck.IsNullGuid(parent_id) Then
            lv = parent_lv + 1
        Else
            lv = parent_lv
        End If

        Return lv
    End Function

    Private Sub SetChiTiet(ByVal parentIdOld As Guid, ByVal parentIdNew As Guid)
        Dim lstOld As List(Of DmTaikhoan) = New List(Of DmTaikhoan)
        Dim lstNew As List(Of DmTaikhoan) = New List(Of DmTaikhoan)
        Dim lst As List(Of DmTaikhoan) 
        If Mode = FormGlobals.DataInputState.AddMode Then
        Else

            'Kiem tra va update lai danh muc cha
            If parentIdNew = parentIdOld Then
                lst = New List(Of DmTaikhoan)
                lst.AddRange(_DmTaikhoanService.GetAllByParentID(parentIdOld))
                If lst.Count > 0 Then
                    _DmTaikhoanService.SetChiTietTKCha(parentIdOld, 0)
                Else
                    _DmTaikhoanService.SetChiTietTKCha(parentIdOld, 1)
                End If
            Else
                lst = New List(Of DmTaikhoan)
                lstOld.AddRange(_DmTaikhoanService.GetAllByParentID(parentIdOld))
                If lstOld.Count > 0 Then
                    _DmTaikhoanService.SetChiTietTKCha(parentIdOld, 0)
                Else
                    _DmTaikhoanService.SetChiTietTKCha(parentIdOld, 1)
                End If

                lstNew.AddRange(_DmTaikhoanService.GetAllByParentID(parentIdNew))
                If lstNew.Count > 0 Then
                    _DmTaikhoanService.SetChiTietTKCha(parentIdNew, 0)
                Else
                    _DmTaikhoanService.SetChiTietTKCha(parentIdNew, 1)
                End If

            End If
        End If
    End Sub

    Private Sub ResetCheckEdit()
        chkDM_Tudo1.Checked = False
        chkDM_Tudo2.Checked = False
        chkDM_Tudo3.Checked = False
        chkDM_Tudo4.Checked = False
        chkDM_Tudo5.Checked = False
        chkDM_HopDong.Checked = False
        chkDM_Khang.Checked = False
        chkDM_Khoanphi.Checked = False
        chkDM_Phongban.Checked = False
        chkDM_PTQT.Checked = False
        chkDM_Vuviec.Checked = False
    End Sub

    Private Sub SaveTK_ChiTiet()
        For Each obj_DM_TK_ChiTiet As DmTkChitiet In lstobj_DM_TK_ChiTiet
            DmTkChitietService.SaveOrUpdate(obj_DM_TK_ChiTiet)
        Next
    End Sub

    Private Sub DeleteTK_ChiTiet()
        For Each obj_DM_TK_ChiTiet As DmTkChitiet In del_lstobj_DM_TK_ChiTiet
            DmTkChitietService.DeleteByTKID(obj_DM_TK_ChiTiet.TaikhoanId, obj_DM_TK_ChiTiet.DmLienquan)
        Next
    End Sub

    Private Sub GetControlToOBject()
        'list add
        lstobj_DM_TK_ChiTiet = New List(Of DmTkChitiet)

        If chkDM_Tudo1.Checked = True Then
            obj_DM_TK_ChiTiet = New DmTkChitiet
            obj_DM_TK_ChiTiet.TaikhoanId = info.Id
            obj_DM_TK_ChiTiet.DmLienquan = "DM_TUDO1"
            obj_DM_TK_ChiTiet.ThuTu = 6
            obj_DM_TK_ChiTiet.BatBuoc = 1
            lstobj_DM_TK_ChiTiet.Add(obj_DM_TK_ChiTiet)
        End If
        If chkDM_Tudo2.Checked = True Then
            obj_DM_TK_ChiTiet = New DmTkChitiet
            obj_DM_TK_ChiTiet.TaikhoanId = info.Id
            obj_DM_TK_ChiTiet.DmLienquan = "DM_TUDO2"
            obj_DM_TK_ChiTiet.ThuTu = 7
            obj_DM_TK_ChiTiet.BatBuoc = 1
            lstobj_DM_TK_ChiTiet.Add(obj_DM_TK_ChiTiet)
        End If
        If chkDM_Tudo3.Checked = True Then
            obj_DM_TK_ChiTiet = New DmTkChitiet
            obj_DM_TK_ChiTiet.TaikhoanId = info.Id
            obj_DM_TK_ChiTiet.DmLienquan = "DM_TUDO3"
            obj_DM_TK_ChiTiet.ThuTu = 8
            obj_DM_TK_ChiTiet.BatBuoc = 1
            lstobj_DM_TK_ChiTiet.Add(obj_DM_TK_ChiTiet)
        End If
        If chkDM_Tudo4.Checked = True Then
            obj_DM_TK_ChiTiet = New DmTkChitiet
            obj_DM_TK_ChiTiet.TaikhoanId = info.Id
            obj_DM_TK_ChiTiet.DmLienquan = "DM_TUDO4"
            obj_DM_TK_ChiTiet.ThuTu = 9
            obj_DM_TK_ChiTiet.BatBuoc = 1
            lstobj_DM_TK_ChiTiet.Add(obj_DM_TK_ChiTiet)
        End If
        If chkDM_Tudo5.Checked = True Then
            obj_DM_TK_ChiTiet = New DmTkChitiet
            obj_DM_TK_ChiTiet.TaikhoanId = info.Id
            obj_DM_TK_ChiTiet.DmLienquan = "DM_TUDO5"
            obj_DM_TK_ChiTiet.ThuTu = 10
            obj_DM_TK_ChiTiet.BatBuoc = 1
            lstobj_DM_TK_ChiTiet.Add(obj_DM_TK_ChiTiet)
        End If
        If chkDM_HopDong.Checked = True Then
            obj_DM_TK_ChiTiet = New DmTkChitiet
            obj_DM_TK_ChiTiet.TaikhoanId = info.Id
            obj_DM_TK_ChiTiet.DmLienquan = "DM_HOPDONG"
            obj_DM_TK_ChiTiet.ThuTu = 11
            obj_DM_TK_ChiTiet.BatBuoc = 1
            lstobj_DM_TK_ChiTiet.Add(obj_DM_TK_ChiTiet)
        End If
        If chkDM_Khang.Checked = True Then
            obj_DM_TK_ChiTiet = New DmTkChitiet
            obj_DM_TK_ChiTiet.TaikhoanId = info.Id
            obj_DM_TK_ChiTiet.DmLienquan = "DM_KHANG"
            obj_DM_TK_ChiTiet.ThuTu = 1
            obj_DM_TK_ChiTiet.BatBuoc = 1
            lstobj_DM_TK_ChiTiet.Add(obj_DM_TK_ChiTiet)
        End If
        If chkDM_Phongban.Checked = True Then
            obj_DM_TK_ChiTiet = New DmTkChitiet
            obj_DM_TK_ChiTiet.TaikhoanId = info.Id
            obj_DM_TK_ChiTiet.DmLienquan = "DM_PHONGBAN"
            obj_DM_TK_ChiTiet.ThuTu = 2
            obj_DM_TK_ChiTiet.BatBuoc = 1
            lstobj_DM_TK_ChiTiet.Add(obj_DM_TK_ChiTiet)
        End If
        If chkDM_PTQT.Checked = True Then
            obj_DM_TK_ChiTiet = New DmTkChitiet
            obj_DM_TK_ChiTiet.TaikhoanId = info.Id
            obj_DM_TK_ChiTiet.DmLienquan = "DM_PTQT"
            obj_DM_TK_ChiTiet.ThuTu = 3
            obj_DM_TK_ChiTiet.BatBuoc = 1
            lstobj_DM_TK_ChiTiet.Add(obj_DM_TK_ChiTiet)
        End If
        If chkDM_Khoanphi.Checked = True Then
            obj_DM_TK_ChiTiet = New DmTkChitiet
            obj_DM_TK_ChiTiet.TaikhoanId = info.Id
            obj_DM_TK_ChiTiet.DmLienquan = "DM_KHOANPHI"
            obj_DM_TK_ChiTiet.ThuTu = 4
            obj_DM_TK_ChiTiet.BatBuoc = 1
            lstobj_DM_TK_ChiTiet.Add(obj_DM_TK_ChiTiet)
        End If
        If chkDM_Vuviec.Checked = True Then
            obj_DM_TK_ChiTiet = New DmTkChitiet
            obj_DM_TK_ChiTiet.TaikhoanId = info.Id
            obj_DM_TK_ChiTiet.DmLienquan = "DM_VUVIEC"
            obj_DM_TK_ChiTiet.ThuTu = 5
            obj_DM_TK_ChiTiet.BatBuoc = 1
            lstobj_DM_TK_ChiTiet.Add(obj_DM_TK_ChiTiet)
        End If

        'list del

        del_lstobj_DM_TK_ChiTiet = New List(Of DmTkChitiet)

        If chkDM_Tudo1.Checked = False Then
            obj_DM_TK_ChiTiet = New DmTkChitiet
            obj_DM_TK_ChiTiet.TaikhoanId = info.Id
            obj_DM_TK_ChiTiet.DmLienquan = "DM_TUDO1"
            obj_DM_TK_ChiTiet.ThuTu = 1
            obj_DM_TK_ChiTiet.BatBuoc = 0
            del_lstobj_DM_TK_ChiTiet.Add(obj_DM_TK_ChiTiet)
        End If
        If chkDM_Tudo2.Checked = False Then
            obj_DM_TK_ChiTiet = New DmTkChitiet
            obj_DM_TK_ChiTiet.TaikhoanId = info.Id
            obj_DM_TK_ChiTiet.DmLienquan = "DM_TUDO2"
            obj_DM_TK_ChiTiet.ThuTu = 2
            obj_DM_TK_ChiTiet.BatBuoc = 0
            del_lstobj_DM_TK_ChiTiet.Add(obj_DM_TK_ChiTiet)
        End If
        If chkDM_Tudo3.Checked = False Then
            obj_DM_TK_ChiTiet = New DmTkChitiet
            obj_DM_TK_ChiTiet.TaikhoanId = info.Id
            obj_DM_TK_ChiTiet.DmLienquan = "DM_TUDO3"
            obj_DM_TK_ChiTiet.ThuTu = 3
            obj_DM_TK_ChiTiet.BatBuoc = 0
            del_lstobj_DM_TK_ChiTiet.Add(obj_DM_TK_ChiTiet)
        End If
        If chkDM_Tudo4.Checked = False Then
            obj_DM_TK_ChiTiet = New DmTkChitiet
            obj_DM_TK_ChiTiet.TaikhoanId = info.Id
            obj_DM_TK_ChiTiet.DmLienquan = "DM_TUDO4"
            obj_DM_TK_ChiTiet.ThuTu = 4
            obj_DM_TK_ChiTiet.BatBuoc = 0
            del_lstobj_DM_TK_ChiTiet.Add(obj_DM_TK_ChiTiet)
        End If
        If chkDM_Tudo5.Checked = False Then
            obj_DM_TK_ChiTiet = New DmTkChitiet
            obj_DM_TK_ChiTiet.TaikhoanId = info.Id
            obj_DM_TK_ChiTiet.DmLienquan = "DM_TUDO5"
            obj_DM_TK_ChiTiet.ThuTu = 5
            obj_DM_TK_ChiTiet.BatBuoc = 0
            del_lstobj_DM_TK_ChiTiet.Add(obj_DM_TK_ChiTiet)
        End If
        If chkDM_HopDong.Checked = False Then
            obj_DM_TK_ChiTiet = New DmTkChitiet
            obj_DM_TK_ChiTiet.TaikhoanId = info.Id
            obj_DM_TK_ChiTiet.DmLienquan = "DM_HOPDONG"
            obj_DM_TK_ChiTiet.ThuTu = 6
            obj_DM_TK_ChiTiet.BatBuoc = 0
            del_lstobj_DM_TK_ChiTiet.Add(obj_DM_TK_ChiTiet)
        End If
        If chkDM_Khang.Checked = False Then
            obj_DM_TK_ChiTiet = New DmTkChitiet
            obj_DM_TK_ChiTiet.Id = info.Id
            obj_DM_TK_ChiTiet.DmLienquan = "DM_KHANG"
            obj_DM_TK_ChiTiet.ThuTu = 7
            obj_DM_TK_ChiTiet.BatBuoc = 0
            del_lstobj_DM_TK_ChiTiet.Add(obj_DM_TK_ChiTiet)
        End If
        If chkDM_Phongban.Checked = False Then
            obj_DM_TK_ChiTiet = New DmTkChitiet
            obj_DM_TK_ChiTiet.TaikhoanId = info.Id
            obj_DM_TK_ChiTiet.DmLienquan = "DM_PHONGBAN"
            obj_DM_TK_ChiTiet.ThuTu = 8
            obj_DM_TK_ChiTiet.BatBuoc = 0
            del_lstobj_DM_TK_ChiTiet.Add(obj_DM_TK_ChiTiet)
        End If
        If chkDM_PTQT.Checked = False Then
            obj_DM_TK_ChiTiet = New DmTkChitiet
            obj_DM_TK_ChiTiet.TaikhoanId = info.Id
            obj_DM_TK_ChiTiet.DmLienquan = "DM_PTQT"
            obj_DM_TK_ChiTiet.ThuTu = 9
            obj_DM_TK_ChiTiet.BatBuoc = 0
            del_lstobj_DM_TK_ChiTiet.Add(obj_DM_TK_ChiTiet)
        End If
        If chkDM_Khoanphi.Checked = False Then
            obj_DM_TK_ChiTiet = New DmTkChitiet
            obj_DM_TK_ChiTiet.TaikhoanId = info.Id
            obj_DM_TK_ChiTiet.DmLienquan = "DM_KHOANPHI"
            obj_DM_TK_ChiTiet.ThuTu = 10
            obj_DM_TK_ChiTiet.BatBuoc = 0
            del_lstobj_DM_TK_ChiTiet.Add(obj_DM_TK_ChiTiet)
        End If
        If chkDM_Vuviec.Checked = False Then
            obj_DM_TK_ChiTiet = New DmTkChitiet
            obj_DM_TK_ChiTiet.TaikhoanId = info.Id
            obj_DM_TK_ChiTiet.DmLienquan = "DM_VUVIEC"
            obj_DM_TK_ChiTiet.ThuTu = 11
            obj_DM_TK_ChiTiet.BatBuoc = 0
            del_lstobj_DM_TK_ChiTiet.Add(obj_DM_TK_ChiTiet)
        End If

    End Sub

    Private Sub SetObjectToControl()
        lstobj_DM_TK_ChiTiet = New List(Of DmTkChitiet)
        lstobj_DM_TK_ChiTiet.AddRange(DmTkChitietService.SelectAllListByTaiKhoanID(obj.Id))
        If (lstobj_DM_TK_ChiTiet Is Nothing) Then
            Return
        End If

        For Each obj_DM_TK_ChiTiet As DmTkChitiet In lstobj_DM_TK_ChiTiet
            If obj_DM_TK_ChiTiet.DmLienquan = "DM_TUDO1" And obj_DM_TK_ChiTiet.TaikhoanId = obj.Id Then
                chkDM_Tudo1.Checked = True
            End If
            If obj_DM_TK_ChiTiet.DmLienquan = "DM_TUDO2" And obj_DM_TK_ChiTiet.TaikhoanId = obj.Id Then
                chkDM_Tudo2.Checked = True
            End If
            If obj_DM_TK_ChiTiet.DmLienquan = "DM_TUDO3" And obj_DM_TK_ChiTiet.TaikhoanId = obj.Id Then
                chkDM_Tudo3.Checked = True
            End If
            If obj_DM_TK_ChiTiet.DmLienquan = "DM_TUDO4" And obj_DM_TK_ChiTiet.TaikhoanId = obj.Id Then
                chkDM_Tudo4.Checked = True
            End If
            If obj_DM_TK_ChiTiet.DmLienquan = "DM_TUDO5" And obj_DM_TK_ChiTiet.TaikhoanId = obj.Id Then
                chkDM_Tudo5.Checked = True
            End If
            If obj_DM_TK_ChiTiet.DmLienquan = "DM_HOPDONG" And obj_DM_TK_ChiTiet.TaikhoanId = obj.Id Then
                chkDM_HopDong.Checked = True
            End If
            If obj_DM_TK_ChiTiet.DmLienquan = "DM_KHANG" And obj_DM_TK_ChiTiet.TaikhoanId = obj.Id Then
                chkDM_Khang.Checked = True
            End If
            If obj_DM_TK_ChiTiet.DmLienquan = "DM_PHONGBAN" And obj_DM_TK_ChiTiet.TaikhoanId = obj.Id Then
                chkDM_Phongban.Checked = True
            End If
            If obj_DM_TK_ChiTiet.DmLienquan = "DM_PTQT" And obj_DM_TK_ChiTiet.TaikhoanId = obj.Id Then
                chkDM_PTQT.Checked = True
            End If
            If obj_DM_TK_ChiTiet.DmLienquan = "DM_KHOANPHI" And obj_DM_TK_ChiTiet.TaikhoanId = obj.Id Then
                chkDM_Khoanphi.Checked = True
            End If
            If obj_DM_TK_ChiTiet.DmLienquan = "DM_VUVIEC" And obj_DM_TK_ChiTiet.TaikhoanId = obj.Id Then
                chkDM_Vuviec.Checked = True
            End If
        Next
    End Sub

    Private Function Check_input() As Boolean
        If Not String.IsNullOrEmpty(ErrorProvider.GetError(Me.txtMA_TAIKHOAN1)) Then
            Return False
        End If

        If Mode = DataInputState.EditMode Then
            If DB_GetString(cFilterTaiKhoan.Text) <> "" Then
                If str_Ma_tk.Equals(cFilterTaiKhoan.Text) Then
                    Message_Warning("Bạn chọn sai giá trị tài khoản cha")
                    cFilterTaiKhoan.Focus()
                    Return False
                End If
            End If
        End If
        'Dim a As String = 
        'If Not Panel_CheckError(Me._GroupControlObjectInfo) Then Return

        If txtMA_TAIKHOAN1.Text = "" Then
            Message_Warning("Bạn chưa nhập giá trị cho mã tài khoản")
            txtMA_TAIKHOAN1.Focus()
            Return False
        End If

        If txtTEN_TAIKHOAN.Text = "" Then
            Message_Warning("Bạn chưa nhập giá trị cho tên tài khoản")
            txtTEN_TAIKHOAN.Focus()
            Return False
        End If

        Return True
    End Function

    Private MaTkCu As String
    Private Sub KiemTraMa(ByVal Ma_taiKhoan As String, ByVal e As CancelEventArgs)
        'Dim kiemtra As Boolean = HeThong_UtilBO.Instance().KiemTraMaDanhMuc("DM_TAIKHOAN", "MA_TAIKHOAN", Ma_taiKhoan, Generals.DON_VI.Id)
        ''Sample
        'If (Not kiemtra) Then
        '    ErrorProvider.SetError(txtMA_TAIKHOAN1, "Mã đã tồn tại")
        '    ErrorProvider.SetIconAlignment(txtMA_TAIKHOAN1, ErrorIconAlignment.MiddleRight)
        '    e.Cancel = True

        'Else
        '    ErrorProvider.SetErrorType(txtMA_TAIKHOAN1, ErrorType.None)
        '    ErrorProvider.SetError(txtMA_TAIKHOAN1, "")
        '    e.Cancel = False
        'End If
    End Sub

    Private Function Return_maTK(ByVal MTK As String) As String
        Dim str As String = ""
        For Each dr As DmTaikhoan In dt_tk
            If dr.Id.ToString = MTK Then
                str = dr.MaTaikhoan.ToString
                Exit For
            End If
        Next
        Return str
    End Function
#End Region

#Region "Events"
    Private Sub frmDanhMucHangHoa_ChiTiet_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Try
            cboChiTiet.Checked = False
            Select Case Mode
                Case FormGlobals.DataInputState.AddMode
                    cboChiTiet.Checked = True
            End Select

            chkDM_Tudo1.Text = Generals.TS_TuDo1.GiaTri
            chkDM_Tudo2.Text = Generals.TS_TuDo2.GiaTri
            chkDM_Tudo3.Text = Generals.TS_TuDo3.GiaTri
            chkDM_Tudo4.Text = Generals.TS_TuDo4.GiaTri
            chkDM_Tudo5.Text = Generals.TS_TuDo5.GiaTri

            Select Case (Mode)
                Case DataInputState.AddMode
                    ResetCheckEdit()
                Case Else
            End Select
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub txtMA_TAIKHOAN1_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtMA_TAIKHOAN1.Validating
        Try
            Dim Ma_taiKhoan As String = txtMA_TAIKHOAN_CHA1.Text + txtMA_TAIKHOAN1.Text
            Select Case Mode
                Case FormGlobals.DataInputState.AddMode
                    KiemTraMa(Ma_taiKhoan, e)

                Case FormGlobals.DataInputState.EditMode

                    If MaTkCu <> Ma_taiKhoan Then
                        KiemTraMa(Ma_taiKhoan, e)
                    End If
            End Select
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub cFilterTaiKhoan_AfterFilter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cFilterTaiKhoan.AfterFilter
        Try
            obj.TaikhoanIdCha = New Guid(cFilterTaiKhoan.ListEditValue(0))
            parentIdNew = New Guid(cFilterTaiKhoan.ListEditValue(0))
            txtMA_TAIKHOAN_CHA1.Text = cFilterTaiKhoan.ListEditValue(1)
            cFilterTaiKhoan.Tag = cFilterTaiKhoan.ListEditValue(0)
            parent_lv = cFilterTaiKhoan.ListEditValue(4)
            If cFilterTaiKhoan.IsNotTextChanged Then SendKeys.Send("{TAB}")
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub cFilterTaiKhoan_ClearFilterData(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cFilterTaiKhoan.ClearFilterData
        Try
            cFilterTaiKhoan.Text = ""
            cFilterTaiKhoan.Tag = ""
            obj.TaikhoanIdCha = Null.NullGuid()
            txtMA_TAIKHOAN_CHA1.Text = ""
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub cFilterTaiKhoan_FirstBinddata(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cFilterTaiKhoan.FirstBinddata
        Try
            dt_tk = DmTaikhoanService.GetAllByDonviID(Generals.DON_VI.Id)
            Dim dt As DataTable = Vns.Erp.Core.Dao.Util.DBUtil.ToDataTable(dt_tk)
            cFilterTaiKhoan.C_DATA_SOURCE = dt
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub frmDanhMucTaiKhoan_ChiTiet_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub
#End Region

End Class
