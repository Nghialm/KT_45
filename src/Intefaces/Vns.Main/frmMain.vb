Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports DevExpress.XtraBars
Imports System.Xml
Imports Vns.Erp.Core.Admin.Service.Interface
Imports Vns.Erp.Core
Imports Vns.Erp.Core.Admin.Domain
Imports Vns.Erp.Core.Admin.VbAdminGUI
Imports Spring.Context
Imports Spring.Context.Support
Imports Vns.Erp.Core.Domain
Imports Vns.Erp.Core.Service.Interface
Imports Vns.Erp.Wcf.Client
Imports System.IO

Partial Public Class frmMain
    Inherits DevExpress.XtraEditors.XtraForm
    'Public Shared Sub InitFormObjects()
    '    Dim frmDanhMucDonVi_DanhSach As frmDanhMucDonVi_DanhSach = ObjectFactory.GetObject("frmDanhMucDonVi_DanhSach")
    'End Sub
#Region "Variables"
    Dim _AppUsersService As IAppUsersService
    Public Property AppUsersService As Vns.Erp.Core.Admin.Service.Interface.IAppUsersService
        Get
            Return _AppUsersService
        End Get
        Set(ByVal value As Vns.Erp.Core.Admin.Service.Interface.IAppUsersService)
            _AppUsersService = value
        End Set
    End Property
    Dim _DmDonviService As IDmDonviService
    Public Property DmDonviService As Vns.Erp.Core.Admin.Service.Interface.IDmDonviService
        Get
            Return _DmDonviService
        End Get
        Set(ByVal value As Vns.Erp.Core.Admin.Service.Interface.IDmDonviService)
            _DmDonviService = value
        End Set
    End Property

    Dim _HtThamsoService As IHtThamsoService

    Public Property HtThamsoService As Vns.Erp.Core.Admin.Service.Interface.IHtThamsoService
        Get
            Return _HtThamsoService
        End Get
        Set(ByVal value As Vns.Erp.Core.Admin.Service.Interface.IHtThamsoService)
            _HtThamsoService = value
        End Set
    End Property

    Dim _AppFormsService As IAppFormsService
    Public Property AppFormsService As Vns.Erp.Core.Admin.Service.Interface.IAppFormsService
        Get
            Return _AppFormsService
        End Get
        Set(ByVal value As Vns.Erp.Core.Admin.Service.Interface.IAppFormsService)
            _AppFormsService = value
        End Set
    End Property

    Dim _AppUsergroupService As IAppUsergroupService
    Public Property AppUsergroupService As Vns.Erp.Core.Admin.Service.Interface.IAppUsergroupService
        Get
            Return _AppUsergroupService
        End Get
        Set(ByVal value As Vns.Erp.Core.Admin.Service.Interface.IAppUsergroupService)
            _AppUsergroupService = value
        End Set
    End Property

    Dim _AppDvFormService As IAppDvFormService

    Public Property AppDvFormService As Vns.Erp.Core.Admin.Service.Interface.IAppDvFormService
        Get
            Return _AppDvFormService
        End Get
        Set(ByVal value As Vns.Erp.Core.Admin.Service.Interface.IAppDvFormService)
            _AppDvFormService = value
        End Set
    End Property

    Dim _AppHGroupFormService As IAppHGroupFormService
    Public Property AppHGroupFormService As Vns.Erp.Core.Admin.Service.Interface.IAppHGroupFormService
        Get
            Return _AppHGroupFormService
        End Get
        Set(ByVal value As Vns.Erp.Core.Admin.Service.Interface.IAppHGroupFormService)
            _AppHGroupFormService = value
        End Set
    End Property
    Dim _AppUgFormService As IAppUgFormService
    Public Property AppUgFormService As Vns.Erp.Core.Admin.Service.Interface.IAppUgFormService
        Get
            Return _AppUgFormService
        End Get
        Set(ByVal value As Vns.Erp.Core.Admin.Service.Interface.IAppUgFormService)
            _AppUgFormService = value
        End Set
    End Property
    Dim _AppHGroupFunctService As IAppHGroupFunctService
    Public Property AppHGroupFunctService As Vns.Erp.Core.Admin.Service.Interface.IAppHGroupFunctService
        Get
            Return _AppHGroupFunctService
        End Get
        Set(ByVal value As Vns.Erp.Core.Admin.Service.Interface.IAppHGroupFunctService)
            _AppHGroupFunctService = value
        End Set
    End Property
    Dim _AppGroupFormsService As IAppGroupFormsService
    Public Property AppGroupFormsService As Vns.Erp.Core.Admin.Service.Interface.IAppGroupFormsService
        Get
            Return _AppGroupFormsService
        End Get
        Set(ByVal value As Vns.Erp.Core.Admin.Service.Interface.IAppGroupFormsService)
            _AppGroupFormsService = value
        End Set
    End Property
    Dim _AppDvGroupUserService As IAppDvGroupUserService
    Public Property AppDvGroupUserService As Vns.Erp.Core.Admin.Service.Interface.IAppDvGroupUserService
        Get
            Return _AppDvGroupUserService
        End Get
        Set(ByVal value As Vns.Erp.Core.Admin.Service.Interface.IAppDvGroupUserService)
            _AppDvGroupUserService = value
        End Set
    End Property
    Dim _AppDvGroupFormService As IAppDvGroupFormService
    Public Property AppDvGroupFormService As Vns.Erp.Core.Admin.Service.Interface.IAppDvGroupFormService
        Get
            Return _AppDvGroupFormService
        End Get
        Set(ByVal value As Vns.Erp.Core.Admin.Service.Interface.IAppDvGroupFormService)
            _AppDvGroupFormService = value
        End Set
    End Property
    Dim _AppGroupFunctionService As IAppGroupFunctionService
    Public Property AppGroupFunctionService As Vns.Erp.Core.Admin.Service.Interface.IAppGroupFunctionService
        Get
            Return _AppGroupFunctionService
        End Get
        Set(ByVal value As Vns.Erp.Core.Admin.Service.Interface.IAppGroupFunctionService)
            _AppGroupFunctionService = value
        End Set
    End Property
    Dim _AppLogbookService As IAppLogbookService
    Public Property AppLogbookService As Vns.Erp.Core.Admin.Service.Interface.IAppLogbookService
        Get
            Return _AppLogbookService
        End Get
        Set(ByVal value As Vns.Erp.Core.Admin.Service.Interface.IAppLogbookService)
            _AppLogbookService = value
        End Set
    End Property
#End Region

#Region "Show Form"
    Public Sub AddForm(ByVal frm As System.Windows.Forms.Form)
        frm.MdiParent = Me
        '_AppLogbookService.UserOpenScreen(Globals.LoginUserID, frm.Text, frm.Name)
        frm.Show()
    End Sub

    '//////////////////////////////////////////////////
    ' Method:    IsExistedMdiChilden
    ' Coded by Nguyễn Quyết Tiến
    ' Kiểm tra xem form đã tồn tại hay chưa
    ' FullName:  KTY.UI.frmMain.IsExistedMdiChilden
    ' Access:    public 
    ' Returns:   Boolean
    ' Parameter: ByVal frm As Windows.Forms.Form
    '//////////////////////////////////////////////////
    Public Function IsExistedMdiChilden(ByVal frm As Windows.Forms.Form) As Boolean
        Try
            Dim isExisted As Boolean = False
            For Each m_Frm As Windows.Forms.Form In Me.MdiChildren
                If m_Frm.Name.Equals(frm.Name) Then
                    isExisted = True
                    Exit For
                End If
            Next
            Return isExisted
        Catch
            Return False
        End Try
    End Function
#End Region

#Region "Sercurity"
    '//////////////////////////////////////////////////
    ' Method:    UserLogOff
    ' Coded by Nguyễn Quyết Tiến
    ' FullName:  KTY.UI.frmMain.UserLogOff
    ' Access:    public 
    ' Returns:   
    '//////////////////////////////////////////////////
    Public Sub UserLogOff()
        Try
            'myRegistry.DeleteKey("login")
            Vns.Erp.Core.Globals.LoginUserID = Guid.Empty
            For Each mItem As BarItem In barManager1.Items
                If mItem.Name.Substring(0, 2) = "so" Then
                    mItem.Enabled = True
                Else
                    mItem.Enabled = False
                End If
            Next mItem
            'Đóng tất cả các form con trước khi LogOff
            CloseMdiChildenForLogOff(Me)
            barMenu.Reset()
        Catch ex As Exception
            FormGlobals.Message_Error(ex)
        End Try
    End Sub

    '//////////////////////////////////////////////////
    ' Method:    InitHMenu
    ' FullName:  KTY.UI.frmMain.InitHMenu
    ' Access:    public 
    ' Returns:   
    '//////////////////////////////////////////////////
    Public Sub InitHMenu()
        Try
            Vns.Erp.Core.Globals.LoginUserID = Guid.Empty
            For Each mItem As BarItem In barManager1.Items
                If mItem.Name.Substring(0, 2) = "so" Then
                    mItem.Enabled = True
                Else
                    mItem.Enabled = False
                End If
            Next mItem
        Catch ex As Exception
            FormGlobals.Message_Error(ex)
        End Try
    End Sub

    '//////////////////////////////////////////////////
    ' Method:    DoLogin
    ' FullName:  KTY.UI.frmMain.DoLogin
    ' Access:    private 
    ' Returns:   
    '//////////////////////////////////////////////////
    Public Sub DoLogin()
        Dim oLogin As frmLogin = ObjectFactory.GetObject("frmLogin")
        Try
            If oLogin.ShowForm() Then
                UserLogin()
                frmProgress.Instance.Thread = AddressOf CreateDataCache
                frmProgress.Instance.Show_Progress("Init cache ...")

                frmProgress.Instance.Thread = AddressOf LoadHMenu
                frmProgress.Instance.Show_Progress("Init H Menu  ...")

                If (Not Vns.Erp.Core.Globals.LoginUserName.Equals("")) AndAlso (Vns.Erp.Core.Globals.LoginUserID <> Guid.Empty) AndAlso (Not Generals.DonviID.Equals("")) Then
                    ShowMainMenu()
                    'frmProgress.Instance.Thread = AddressOf ShowMainMenu
                    'frmProgress.Instance.Show_Progress("Load Menu ...")
                End If
            End If
        Catch ex As Exception
            FormGlobals.Message_Error(ex)
        End Try
    End Sub

    Private Function GetThamso(ByVal lst As IList(Of HtThamso), ByVal searchvalue As String) As HtThamso
        For Each tmp As HtThamso In lst
            If searchvalue = tmp.MaThamso Then
                Return tmp
            End If
        Next
        Return New HtThamso()
    End Function

    '//////////////////////////////////////////////////
    ' Method:    UserLogin
    ' FullName:  KTY.UI.frmMain.UserLogin
    ' Access:    private 
    ' Returns:   
    '//////////////////////////////////////////////////
    Private Sub UserLogin()
        Dim dv As DataView = Nothing
        Dim ds As DataSet = Nothing
        Dim expression As String = ""
        Try
            'GETSETTINGS()
            'Lay thong tin cua nguoi dung va he thong
            ds = _AppUsersService.GetUserMenu(Vns.Erp.Core.Globals.LoginUserID)
            Generals.USER = _AppUsersService.Get(Vns.Erp.Core.Globals.LoginUserID)
            Generals.DON_VI = _DmDonviService.Get(Generals.DON_VI.Id)
            '-----------------Lay thong tin config log-----------------
            'Generals.DBLOG_CONFIG = DBLogConfigBO.Instance().GetAllByDonviID(Generals.DON_VI.DONVI_ID)
            Generals.DBLOG_CONFIG = Nothing
            '-----------------Lay thong tin config log-----------------
            Dim tmplstThamso = _HtThamsoService.GetByDonviId(Generals.DonviID)
            Generals.TS_TuDo1 = GetThamso(tmplstThamso, "p_DM_TuDo_1") '_HtThamsoService.GetByMaThamSo("p_DM_TuDo_1", Generals.DonviID)
            Generals.TS_TuDo2 = GetThamso(tmplstThamso, "p_DM_TuDo_2") '_HtThamsoService.GetByMaThamSo("p_DM_TuDo_2", Generals.DonviID)
            Generals.TS_TuDo3 = GetThamso(tmplstThamso, "p_DM_TuDo_3") '_HtThamsoService.GetByMaThamSo("p_DM_TuDo_3", Generals.DonviID)
            Generals.TS_TuDo4 = GetThamso(tmplstThamso, "p_DM_TuDo_4") '_HtThamsoService.GetByMaThamSo("p_DM_TuDo_4", Generals.DonviID)
            Generals.TS_TuDo5 = GetThamso(tmplstThamso, "p_DM_TuDo_5") '_HtThamsoService.GetByMaThamSo("p_DM_TuDo_5", Generals.DonviID)
            Generals.TS_ThueGTGTDauVao = GetThamso(tmplstThamso, "p_ThueGTGTDauVao") ' _HtThamsoService.GetByMaThamSo("p_ThueGTGTDauVao", Generals.DonviID)
            Generals.TS_ThueGTGTDauRa = GetThamso(tmplstThamso, "p_ThueGTGTDauRa") '_HtThamsoService.GetByMaThamSo("p_ThueGTGTDauRa", Generals.DonviID)
            Generals.TS_NoiTe_ID = GetThamso(tmplstThamso, "p_NTe_NoiTe") '_HtThamsoService.GetByMaThamSo("p_NTe_NoiTe", Generals.DonviID)
            Generals.Nam_Ke_Toan = GetNamKT()

            Generals.Df_Tk_Kho = GetThamso(tmplstThamso, "p_tk_kho")
            Generals.Df_Tk_DoanhThu = GetThamso(tmplstThamso, "p_tk_dt")
            Generals.Df_Tk_GiaVon = GetThamso(tmplstThamso, "p_tk_gv")
            Generals.Df_PP_TinhGiaKho = GetThamso(tmplstThamso, "p_pp_xuat_kho")

            Dim initappspa As ApplicationInitGlobal = CType(ObjectFactory.GetObject("SpaApplicationInit"), ApplicationInitGlobal)
            initappspa.InitGlobal()

            If Not ds Is Nothing AndAlso Not ds.Tables(0) Is Nothing AndAlso ds.Tables(0).Rows.Count > 0 Then
                dv = ds.Tables(0).DefaultView
                For Each mItem As BarItem In barManager1.Items
                    If (Not mItem.Name.StartsWith("so")) Then
                        expression = "MenuName='" & mItem.Name & "'"
                        dv.RowFilter = expression
                        If dv.Count > 0 Then
                            mItem.Enabled = True
                        End If
                        ds.Tables(0).DefaultView.RowFilter = ""
                    End If
                Next mItem
            End If

            For Each mItem As BarItem In barManager1.Items
                mItem.Enabled = True
            Next mItem

            siLogOut.Enabled = True
            soLogin.Enabled = False
            barClientDate.Caption = "Người sử dụng: " + Vns.Erp.Core.Globals.LoginFullName
            barClientDonVi.Caption = "Đơn vị: " + Generals.DON_VI.TenDonvi
            barClientNamKT.Caption = "Năm KT: " + Generals.Nam_Ke_Toan.ToString
        Catch ex As Exception
            FormGlobals.Message_Error(ex)
        End Try
    End Sub

    '//////////////////////////////////////////////////
    ' Method:    GetNamKT
    ' FullName:  KTY.UI.frmMain.GetNamKT
    ' Access:    private 
    ' Returns:   Integer
    '//////////////////////////////////////////////////
    Private Function GetNamKT() As Integer
        Dim doc As XmlDocument = XMLConfig.XmlReader("KTConfig.xml")
        Dim root As XmlElement = doc.DocumentElement
        Dim serverNode As XmlNode = root.SelectSingleNode("nam_ke_toan_info")
        Dim nam_kt As String = serverNode.SelectSingleNode("nam_kt").InnerText
        nam_kt = Crypto.DecryptString128Bit(nam_kt, Crypto.key_encrypt)
        If nam_kt.Equals("") Then
            Return SetDefaultNamKT()
        Else
            Dim i As Integer = 2012
            Try
                i = Integer.Parse(nam_kt)
            Catch ex As Exception
                i = SetDefaultNamKT()
            End Try
            Return i
        End If
    End Function

    '//////////////////////////////////////////////////
    ' Method:    SetDefaultNamKT
    ' FullName:  KTY.UI.frmMain.SetDefaultNamKT
    ' Access:    private 
    ' Returns:   Integer
    '//////////////////////////////////////////////////
    Private Function SetDefaultNamKT() As Integer
        Dim nam_kt_current As String = DateTime.Now.Year.ToString()
        Dim nam_kt_encrypted As String = Crypto.EncryptString128Bit(nam_kt_current, Crypto.key_encrypt)
        Dim doc As XmlDocument = XMLConfig.XmlReader("KTConfig.xml")
        Dim root As XmlElement = doc.DocumentElement
        Dim serverNode As XmlNode = root.SelectSingleNode("nam_ke_toan_info")
        serverNode.SelectSingleNode("nam_kt").InnerText = nam_kt_encrypted
        doc.Save("KTConfig.xml")
        Return DateTime.Now.Year
    End Function

    '//////////////////////////////////////////////////
    ' Method:    IsAdminGroup
    ' Kiểm tra xem User có thuộc nhóm Admin hay không
    ' Coded by Nguyễn Quyết Tiến
    ' FullName:  KTY.UI.frmMain.IsAdminGroup
    ' Access:    public 
    ' Returns:   Boolean
    ' Parameter: ByVal user_id As Integer
    '//////////////////////////////////////////////////
    Public Sub SetupHorizontalMenu()
        'Thực hiện phân quyền trên Menu ngang
        Dim isAdminTong As Boolean = Vns.Erp.Core.Globals.IS_ADMIN_TONG
        Dim isAdminDV As Boolean = Vns.Erp.Core.Globals.IS_ADMIN_DV
        Dim isMember As Boolean = Vns.Erp.Core.Globals.IS_MEMBER
        Dim item001 As BarItem = barManager1.Items("siUserManagement")
        Dim item002 As BarItem = barManager1.Items("siDonviGroup")
        'Dim item003 As BarItem = barManager1.Items("siDonviGroupUser") 'Not use
        Dim item004 As BarItem = barManager1.Items("siDonviGroupForm")
        Dim item005 As BarItem = barManager1.Items("siDonviBaocao")
        Dim item006 As BarItem = barManager1.Items("siDonviGroupBaocao")
        If isAdminTong = True Then
            item001.Visibility = BarItemVisibility.OnlyInRuntime
            item002.Visibility = BarItemVisibility.OnlyInRuntime
            'item003.Visibility = BarItemVisibility.OnlyInRuntime 'Not use
            item004.Visibility = BarItemVisibility.Never
            item005.Visibility = BarItemVisibility.OnlyInRuntime
            item006.Visibility = BarItemVisibility.Never
        ElseIf (isAdminTong = False) AndAlso (isAdminDV = True) Then
            item001.Visibility = BarItemVisibility.OnlyInRuntime
            item002.Visibility = BarItemVisibility.Never
            'item003.Visibility = BarItemVisibility.Never 'Not use
            item004.Visibility = BarItemVisibility.OnlyInRuntime
            item005.Visibility = BarItemVisibility.Never
            item006.Visibility = BarItemVisibility.OnlyInRuntime
        ElseIf (isAdminTong = False) AndAlso (isAdminDV = False) AndAlso (isMember = True) Then
            item001.Visibility = BarItemVisibility.Never
            item002.Visibility = BarItemVisibility.Never
            'item003.Visibility = BarItemVisibility.Never 'Not use
            item004.Visibility = BarItemVisibility.Never
            item005.Visibility = BarItemVisibility.Never
            item006.Visibility = BarItemVisibility.Never
        End If
    End Sub

    '//////////////////////////////////////////////////
    ' Method:    LoadHMenu
    ' Coded by Nguyễn Quyết Tiến
    ' FullName:  KTY.UI.frmMain.LoadHMenu
    ' Access:    public 
    ' Returns:   
    '//////////////////////////////////////////////////
    Public Sub LoadHMenu()
        'BindGroupToBar(barMenu)
        BindGroupToBar2(barMenu)
    End Sub

    Public Sub BindLinkToMenu(ByVal subMenu As BarSubItem, ByVal group_id As Guid)
        Dim buttonItem As BarButtonItem = Nothing
        Dim dt As IList(Of AppForms) = _AppFormsService.GetByHGroup(group_id)
        For Each rowInfo As AppForms In dt
            'Check permission
            Dim form_id_of_row As String = rowInfo.FormId.ToString
            If IsExistedItemInList(Vns.Erp.Core.Globals.LIST_FORMS, New Guid(form_id_of_row)) Then
                buttonItem = New BarButtonItem
                buttonItem.Name = rowInfo.FormName + ";" + rowInfo.MenuName
                buttonItem.Caption = rowInfo.FormText
                buttonItem.AccessibleDescription = rowInfo.FormParam
                buttonItem.Tag = "dynamic"
                subMenu.AddItem(buttonItem)
            End If
        Next
    End Sub

    Public Function GetDataByParent(ByVal listSource As IList(Of AppHGroupFunct), ByVal parent_id As Guid) As List(Of AppHGroupFunct)
        Dim listReturn As New List(Of AppHGroupFunct)
        For Each info As AppHGroupFunct In listSource
            If info.ParentId = parent_id Then
                listReturn.Add(info)
            End If
        Next
        Return listReturn
    End Function

    Public Sub BindGroupToBar2(ByVal bar As DevExpress.XtraBars.Bar)
        Dim subItem As BarSubItem
        Dim listSource As IList(Of AppHGroupFunct) = _AppHGroupFunctService.GetAll()
        For Each itemInfo As AppHGroupFunct In listSource
            If itemInfo.ParentId = Guid.Empty Then
                subItem = New BarSubItem
                subItem.Name = "dynamic_" + itemInfo.GroupKyhieu
                subItem.Caption = itemInfo.GroupTen
                subItem.Tag = ""
                bar.AddItem(subItem)
                AddItemToBar2(subItem, listSource, itemInfo.Id)
            End If
        Next
    End Sub

    Public Sub AddItemToBar2(ByVal subItem As BarSubItem, ByVal listSource As IList(Of AppHGroupFunct), ByVal parent_id As Guid)
        Dim subMenu As BarSubItem = Nothing
        Dim listData As IList(Of AppHGroupFunct) = GetDataByParent(listSource, parent_id)
        For Each rowInfo As AppHGroupFunct In listData
            subMenu = New BarSubItem
            subMenu.Name = rowInfo.GroupKyhieu
            subMenu.Caption = rowInfo.GroupTen
            subMenu.Tag = rowInfo.Id
            subItem.AddItem(subMenu)
            If subItem.ItemLinks.Count = 0 Then
                subItem.Visibility = BarItemVisibility.Never
            End If
            AddItemToBar2(subMenu, listSource, New Guid(subMenu.Tag.ToString))
            If subMenu.ItemLinks.Count = 0 Then
                BindLinkToMenu(subMenu, New Guid(subMenu.Tag.ToString))
                If subMenu.ItemLinks.Count = 0 Then
                    subMenu.Visibility = BarItemVisibility.Never
                End If
            End If
        Next
    End Sub

    '//////////////////////////////////////////////////
    ' Method:    CloseMdiChilden
    ' Coded by Nguyễn Quyết Tiến
    ' Đóng tất cả các mdiChilden form
    ' FullName:  KTY.UI.frmMain.CloseMdiChilden
    ' Access:    public 
    ' Returns:   Windows.Forms.Form)
    ' Parameter: ByVal parent As Windows.Forms.Form
    '//////////////////////////////////////////////////
    Public Sub CloseMdiChilden(ByVal parent As Windows.Forms.Form)
        For Each frm_child As Windows.Forms.Form In parent.MdiChildren
            If Not frm_child.Name.Equals("frmMenu") Then
                frm_child.Close()
            End If
        Next
    End Sub

    '//////////////////////////////////////////////////
    ' Method:    CloseMdiChildenForLogOff
    ' FullName:  KTY.UI.frmMain.CloseMdiChildenForLogOff
    ' Access:    public 
    ' Returns:   Windows.Forms.Form)
    ' Parameter: ByVal parent As Windows.Forms.Form
    '//////////////////////////////////////////////////
    Public Sub CloseMdiChildenForLogOff(ByVal parent As Windows.Forms.Form)
        For Each frm_child As Windows.Forms.Form In parent.MdiChildren
            frm_child.Close()
        Next
    End Sub

    '//////////////////////////////////////////////////
    ' Method:    ShowMainMenu
    ' Coded by Nguyễn Quyết Tiến
    ' Gọi menu
    ' FullName:  KTY.UI.frmMain.ShowMainMenu
    ' Access:    public 
    ' Returns:   
    '//////////////////////////////////////////////////
    Public Sub ShowMainMenu()
        Dim m_FrmMenu As New frmMenu()
        m_FrmMenu.MdiParent = Me
        m_FrmMenu.ShowInTaskbar = False
        m_FrmMenu.ShowIcon = False
        m_FrmMenu.ControlBox = False
        m_FrmMenu.Show()
    End Sub

    '//////////////////////////////////////////////////
    ' Method:    CreateDataCache
    ' FullName:  KTY.UI.frmMain.CreateDataCache
    ' Access:    public 
    ' Returns:   
    '//////////////////////////////////////////////////
    Public Sub CreateDataCache()
        'Default value
        Vns.Erp.Core.Globals.IS_ADMIN_TONG = False
        Vns.Erp.Core.Globals.IS_ADMIN_DV = False
        Vns.Erp.Core.Globals.IS_MEMBER = True

        'Create data for Function Permission
        Vns.Erp.Core.Globals.LIST_USER_GROUP = New List(Of Guid)
        Dim donvi_id As Guid = Generals.DonviID
        Dim user_id As Guid = Vns.Erp.Core.Globals.LoginUserID
        Dim dt As IList(Of AppDvGroupUser) = _AppDvGroupUserService.GetDVUser(donvi_id, user_id)
        For Each row As AppDvGroupUser In dt
            Vns.Erp.Core.Globals.LIST_USER_GROUP.Add(row.GroupId)
        Next

        'If (donvi_id.Equals(Vns.Erp.Core.Globals.HD_BQT_ID)) And (donvi_id.Equals(Generals.USER.DonviId)) Then
        '    Globals.IS_ADMIN_TONG = True
        'Else
        '    Globals.IS_ADMIN_TONG = False
        'End If
        Vns.Erp.Core.Globals.IS_ADMIN_TONG = True 'Tam

        Dim tmpname = Generals.USER.Username.ToUpper()
        If (tmpname.Contains("ADMIN")) Then
            Generals.PriorityLevel = 0 'Admin
        End If
        'Create data for Custom Menu
        Dim list_form_return As New List(Of Guid)
        Select Case Generals.PriorityLevel
            Case 0
                '1. Lay tat ca chuc nang
                Dim dtTong As IList(Of AppGroupForms) = _AppGroupFormsService.GetAll()
                For Each rowTong As AppGroupForms In dtTong
                    list_form_return.Add(rowTong.Id)
                Next
            Case 1
                '3. Lay theo nguoi dung
                list_form_return = LoadListForm(dt)

        End Select

        '2. Lay tat ca chung nang cua don vi duoc phan
        'Dim dtAdmin As IList(Of AppDvForm) = _AppDvFormService.GetByDV(donvi_id)
        'For Each rowAdmin As AppDvForm In dtAdmin
        '    list_form_return.Add(rowAdmin.FormId)
        'Next

        Dim list_level2_return As List(Of Guid) = GetLevel2(list_form_return)
        Dim list_level1_return As List(Of Guid) = GetLevel1(list_level2_return)
        Vns.Erp.Core.Globals.LIST_FORMS = list_form_return
        Vns.Erp.Core.Globals.LIST_LEVEL2 = list_level2_return
        Vns.Erp.Core.Globals.LIST_LEVEL1 = list_level1_return
    End Sub

    '//////////////////////////////////////////////////
    ' Method:    LoadListForm
    ' FullName:  KTY.UI.frmMain.LoadListForm
    ' Access:    public 
    ' Returns:   List(Of String)
    ' Parameter: ByVal dtGroup As DataTable
    '//////////////////////////////////////////////////
    Public Function LoadListForm(ByVal dtGroup As IList(Of AppDvGroupUser)) As List(Of Guid)
        Try
            Dim list_return As New List(Of Guid) 'List FORM_ID
            Dim list_dv_group_form As New List(Of AppDvGroupForm)

            Dim firstGuid As Guid = New Guid()
            Dim dtDGF As IList(Of AppDvGroupForm) = New List(Of AppDvGroupForm)()
            If (LIST_USER_GROUP.Count > 0) Then
                firstGuid = LIST_USER_GROUP(0)
                dtDGF = _AppDvGroupFormService.GetByDVG(Generals.DON_VI.Id, firstGuid)
            Else
                dtDGF = _AppDvGroupFormService.GetAll()
            End If

            For Each rowDVG As AppDvGroupForm In dtDGF
                list_dv_group_form.Add(rowDVG)
            Next

            For Each row As AppDvGroupUser In dtGroup
                Dim g_id As Guid = row.GroupId
                Dim m_dv As Guid = Generals.DonviID
                For Each infoDGF As AppDvGroupForm In list_dv_group_form
                    If (infoDGF.DvId = m_dv) AndAlso (infoDGF.GroupId = g_id) AndAlso (IsExistedItemInList(list_return, infoDGF.FormId) = False) Then
                        list_return.Add(infoDGF.FormId)
                    End If
                Next
            Next
            Return list_return
        Catch
            Return Nothing
        End Try
    End Function

    '//////////////////////////////////////////////////
    ' Method:    GetLevel2
    ' FullName:  KTY.UI.frmMain.GetLevel2
    ' Access:    public 
    ' Returns:   List(Of String)
    ' Parameter: ByVal list_user_group As List
    ' Parameter: Of String
    '//////////////////////////////////////////////////
    Public Function GetLevel2(ByVal list_user_group As List(Of Guid)) As List(Of Guid)
        Try
            Dim list_return As New List(Of Guid) 'List GROUP_ID Level2
            Dim list_group_form As New List(Of AppGroupForms)
            Dim dtGF As List(Of AppGroupForms) = New List(Of AppGroupForms)()
            dtGF.AddRange(_AppGroupFormsService.GetAll())

            For Each rowGF As AppGroupForms In dtGF
                'Dim form_id As Decimal = Decimal.Parse(rowGF("FORMS_ID").ToString)
                'Dim group_id As Decimal = Decimal.Parse(rowGF("GROUP_ID").ToString)
                list_group_form.Add(rowGF.Clone())
            Next

            For Each info As Guid In list_user_group 'FormID
                For Each infoGF As AppGroupForms In list_group_form
                    If (infoGF.Id = info) AndAlso (IsExistedItemInList(list_return, infoGF.Id) = False) Then
                        list_return.Add(infoGF.GroupId)
                    End If
                Next
            Next
            Return list_return
        Catch
            Return Nothing
        End Try
    End Function

    '//////////////////////////////////////////////////
    ' Method:    GetLevel1
    ' FullName:  KTY.UI.frmMain.GetLevel1
    ' Access:    public 
    ' Returns:   List(Of String)
    ' Parameter: ByVal list2 As List
    ' Parameter: Of String
    '//////////////////////////////////////////////////
    Public Function GetLevel1(ByVal list2 As List(Of Guid)) As List(Of Guid)
        Try
            Dim list_return As New List(Of Guid)
            Dim list_group_function As New List(Of AppGroupFunction)
            Dim dtFunction As List(Of AppGroupFunction) = New List(Of AppGroupFunction)()
            dtFunction.AddRange(_AppGroupFunctionService.GetAll())

            For Each rowFunction As AppGroupFunction In dtFunction
                list_group_function.Add(rowFunction.Clone())
            Next

            For Each info As Guid In list2 'GroupID
                For Each infoFunction As AppGroupFunction In list_group_function
                    If (infoFunction.Id = info) AndAlso (IsExistedItemInList(list_return, infoFunction.ParentId) = False) Then
                        list_return.Add(infoFunction.ParentId)
                    End If
                Next
            Next
            Return list_return
        Catch
            Return Nothing
        End Try
    End Function

    '//////////////////////////////////////////////////
    ' Method:    IsExistedItemInList
    ' FullName:  KTY.UI.frmMain.IsExistedItemInList
    ' Access:    public 
    ' Returns:   String) As Boolean
    ' Parameter: ByVal list As List
    ' Parameter: Of String
    ' Parameter: ByVal item As String
    '//////////////////////////////////////////////////
    Public Function IsExistedItemInList(ByVal list As List(Of Guid), ByVal item As Guid) As Boolean
        Try
            Dim bReturn As Boolean = False
            For Each info As Guid In list
                If info.Equals(item) Then
                    bReturn = True
                    Return bReturn
                End If
            Next
            Return bReturn
        Catch
            Return False
        End Try
    End Function

    '//////////////////////////////////////////////////
    ' Method:    ShowDynamicMenu
    ' FullName:  KTY.UI.frmMain.ShowDynamicMenu
    ' Access:    public 
    ' Returns:   
    '//////////////////////////////////////////////////
    Public Sub ShowDynamicMenu()

    End Sub

#End Region

#Region "Item click"
    '//////////////////////////////////////////////////
    ' Method:    mnuAdministration_Function
    ' FullName:  KTY.UI.frmMain.mnuAdministration_Function
    ' Access:    private 
    ' Returns:   
    ' Parameter: ByVal sender As Object
    ' Parameter: ByVal e As DevExpress.XtraBars.ItemClickEventArgs
    '//////////////////////////////////////////////////
    Private Sub mnuAdministration_Function(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Vns.Erp.Core.Globals.ActiveMenuName = e.Item.Name
        Select Case e.Item.Name
            Case "soLogin"
                'Dim frmChangePassword As frmChangePassword = ObjectFactory.GetObject("frmChangePassword")
                DoLogin()

            Case "soExit"
                If (MessageBox.Show("Bạn thực sự muốn thoát khỏi hệ thống ?", "THOÁT", MessageBoxButtons.YesNo) <> DialogResult.Yes) Then
                    Return
                End If
                Me.Dispose()

            Case "siLogOut"
                UserLogOff()
                DoLogin()

            Case "siAdminChangePass"
                'Dim oPwd As frmChangePassword = New frmChangePassword()
                'oPwd.ShowForm(Globals.LoginUserID)
                Dim frmChangePassword As frmChangePassword = ObjectFactory.GetObject("frmChangePassword")
                frmChangePassword.ShowForm(Vns.Erp.Core.Globals.LoginUserID)
            Case ("siFreezeData")
                FormGlobals.Message_Confirm("The function cannot display.", False)

            Case "siUserActionReport"
                Throw New Exception("Dang hoan thien")
                'AddForm(New frmLogBook())

            Case "siUserManagement"
                Throw New Exception("Dang hoan thien")
                'AddForm(New frmUserRightList())

            Case "soAdminDatabaseSettings"
                Throw New Exception("Form cau hinh co so du lieu dang lam!")
                'Dim frmDatabase As frmDatabaseSettings = New frmDatabaseSettings()
                'If frmDatabase.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                '    UserLogOff()
                '    DoLogin()
                'End If

            Case "siDonviGroup"
                Throw New Exception("Dang hoan thien")
                'Dim m_Frm As New frmDonviGroup()
                'm_Frm.ShowDialog()

            Case "siDonviGroupUser"
                Throw New Exception("Dang hoan thien")
                'Dim m_Frm As New frmDonviGroupUser()
                'm_Frm.ShowDialog()

            Case "siDonviGroupForm"
                Throw New Exception("Dang hoan thien")
                'Dim m_Frm As New frmDonviGroupForm()
                'm_Frm.ShowDialog()

            Case "siDonviBaocao"
                Throw New Exception("Dang hoan thien")
                'Dim m_Frm As New frmDonviBaocao()
                'm_Frm.ShowDialog()

            Case "siDonviGroupBaocao"
                Throw New Exception("Dang hoan thien")
                'Dim m_Frm As New frmDonviGroupBaocao()
                'm_Frm.ShowDialog()

                'Case "_CloseAllVisible"
                '    CloseMdiChilden(Me)
                'Case "siDataTransfer"
                '    Dim m_Frm As New frmTransDemo()
                '    m_Frm.ShowDialog()

                'Case "siDonviGroupLCTStatus"
                '    Dim m_Frm As New frmGrantStatus()
                '    m_Frm.ShowDialog()

            Case "_frmTreeBaoCao"
                Dim frmBaocao As Vns.Erp.Core.Accounting.Report.frmBaoCaoTongHop = CType(ObjectFactory.GetObject("frmBaoCaoTongHop"),  _
                    Vns.Erp.Core.Accounting.Report.frmBaoCaoTongHop)
                AddForm(frmBaocao)
                'Throw New Exception("Dang hoan thien")
                'Case "_ThietLapMenu"
                '    AddForm(New frmSetupMenu())

            Case "_ThamSoHeThong"
                Throw New Exception("Dang hoan thien")
                'AddForm(New frmThamSoHeThong())

            Case "_ShowDesign"
                Throw New Exception("Dang hoan thien")
                'Dim f_ds As frmShowDesign = New frmShowDesign()
                'f_ds.Show()

            Case "_ReportSettings"
                Throw New Exception("Dang hoan thien")
                'AddForm(New frmThemSuaXoa())

            Case "_EditReports"
                'AddForm(New KTY.Report.frmBaoCaoTongHop())

            Case "_DanhSachBaoCao"
                Throw New Exception("Dang hoan thien")
                'AddForm(New frmKT_H_BAOCAO_DanhSach())

            Case "_barTeamview"
                If File.Exists(Application.StartupPath & "\Util\Teamview.exe") Then
                    frmProgress.Instance.Thread = AddressOf CallTeamview
                    frmProgress.Instance.Show_Progress()
                Else
                    Message_Warning("Không tìm thấy ứng dụng teamviewer")
                End If
            Case Else
                'Start Case Else
                If e.Item.GetType().Name.Equals("BarButtonItem") Then
                    If (Not e.Item.Tag Is Nothing) AndAlso (e.Item.Tag.ToString.Equals("dynamic")) Then
                        Dim f_name_isdialog() As String = e.Item.Name.Split(Char.Parse(";"))
                        Dim f_name As String = f_name_isdialog(0)
                        Dim f_dialog As String = f_name_isdialog(1)
                        Dim f_param As String = e.Item.AccessibleDescription
                        Dim isShowDialog As Boolean = False
                        If f_dialog.Equals("2") Then
                            isShowDialog = True
                        End If
                        If SystemHelper.ShowFormFull(f_name, Me, f_param, isShowDialog) = False Then
                            'ShowFormFullOther(f_name, Me.ParentForm, f_param, isShowDialog)
                        End If
                    End If
                End If
                'End Case Else
        End Select
    End Sub
#End Region

#Region "Event Handles"
    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub InitObject()
        Me.AppUsersService = ObjectFactory.GetObject("AppUsersService")
        Me.DmDonviService = ObjectFactory.GetObject("DmDonviService")
        Me.HtThamsoService = ObjectFactory.GetObject("HtThamsoService")
        Me.AppUsergroupService = ObjectFactory.GetObject("AppUsergroupService")
        Me.AppDvFormService = ObjectFactory.GetObject("AppDvFormService")
        Me.AppHGroupFormService = ObjectFactory.GetObject("AppHGroupFormService")
        Me.AppDvGroupUserService = ObjectFactory.GetObject("AppDvGroupUserService")
        Me.AppHGroupFunctService = ObjectFactory.GetObject("AppHGroupFunctService")
        Me.AppGroupFormsService = ObjectFactory.GetObject("AppGroupFormsService")
        Me.AppFormsService = ObjectFactory.GetObject("AppFormsService")
        Me.AppDvGroupFormService = ObjectFactory.GetObject("AppDvGroupFormService")
        Me.AppGroupFunctionService = ObjectFactory.GetObject("AppGroupFunctionService")

        Dim AppDvGroupBcService As IAppDvGroupBcService = ObjectFactory.GetObject("AppDvGroupBcService")
        Dim AppDvGroupUserService As IAppDvGroupUserService = ObjectFactory.GetObject("AppDvGroupUserService")

        'Spaglo = ObjectFactory.GetObject("SpaApplicationInit");
    End Sub

    '//////////////////////////////////////////////////
    ' Method:    frmMain_Load
    ' FullName:  KTY.UI.frmMain.frmMain_Load
    ' Access:    private 
    ' Returns:   Object, ByVal e As EventArgs) Handles MyBase.Load
    ' Parameter: ByVal sender As Object
    ' Parameter: ByVal e As EventArgs
    '//////////////////////////////////////////////////
    Private Sub frmMain_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load

        frmProgress.Instance.Thread = AddressOf InitObject
        frmProgress.Instance.Show_Progress("Đang tải dữ liệu ...")
        'InitObject()

        Try
            Dim LoginService As WcfAuthenticationService = New WcfAuthenticationService()
            'Dim WcfAppCtStatusService As IAppCtStatusService = ObjectFactory.GetObject("AppCtStatusService")

            'Dim ok As Boolean = LoginService.Login("admin", "admin", "", True)
            'Dim listAppCtStatus As IList(Of AppCtStatus) = WcfAppCtStatusService.GetAll()

            DataHelper.SetCulture2()
            DoLogin()
            Dim _DicSource As String = String.Empty
            _DicSource = Application.ExecutablePath
            Dim _i1 As Integer = _DicSource.Split("\"c).Length
            Dim _temp As String = _DicSource.Split("\"c)(_i1 - 1)
            _DicSource = _DicSource.Replace(_temp, "")
            Generals.ThuMucChayCT = _DicSource
            Generals.ThuMucFileBaocao = _DicSource & "Reports\"
            Generals.FileResourceGrid = _DicSource & "Resources\ConfigGrid.xml"
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    '//////////////////////////////////////////////////
    ' Method:    barManager1_ItemClick
    ' FullName:  KTY.UI.frmMain.barManager1_ItemClick
    ' Access:    private 
    ' Returns:   Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles barManager1.ItemClick
    ' Parameter: ByVal sender As Object
    ' Parameter: ByVal e As DevExpress.XtraBars.ItemClickEventArgs
    '//////////////////////////////////////////////////
    Private Sub barManager1_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles barManager1.ItemClick
        Try
            Dim subMenu As BarSubItem = TryCast(e.Item, BarSubItem)
            Vns.Erp.Core.Globals.ActiveMenuName = e.Item.Name
            Vns.Erp.Core.Globals.ActiveMenuText = e.Link.DisplayCaption
            mnuAdministration_Function(sender, e)
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    '//////////////////////////////////////////////////
    ' Method:    frmMain_MdiChildActivate
    ' FullName:  KTY.UI.frmMain.frmMain_MdiChildActivate
    ' Body:		 Set ShortCut Key Description
    ' Access:    private 
    ' Returns:   System.Object, ByVal e As System.EventArgs) Handles MyBase.MdiChildActivate
    ' Parameter: ByVal sender As System.Object
    ' Parameter: ByVal e As System.EventArgs
    '//////////////////////////////////////////////////
    Private Sub frmMain_MdiChildActivate(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.MdiChildActivate
        Try
            'Determize child form is Activated
            Dim frmChildActive As Windows.Forms.Form = Me.ActiveMdiChild
            If frmChildActive Is Nothing Then
                barGuide.Caption = String.Empty
                Return
            End If

            If Not (frmChildActive.Tag Is Nothing) Then
                barGuide.Caption = frmChildActive.Tag.ToString
            Else
                barGuide.Caption = String.Empty
            End If
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub
#End Region

#Region "Show Grant"
    Public Sub ShowGrantFunctionGlobal()
        Throw New Exception("Dang hoan thien")
        'Dim m_Frm As New frmDonviGroup
        'm_Frm.ShowDialog()
    End Sub

    Public Sub ShowGrantFunctionDV()
        Throw New Exception("Dang hoan thien")
        'Dim m_Frm As New frmDonviGroupForm
        'm_Frm.ShowDialog()
    End Sub

    Public Sub ShowGrantReportGlobal()
        Throw New Exception("Dang hoan thien")
        'Dim m_Frm As New frmDonviBaocao
        'm_Frm.ShowDialog()
    End Sub

    Public Sub ShowGrantReportDV()
        Throw New Exception("Dang hoan thien")
        'Dim m_Frm As New frmDonviGroupBaocao
        'm_Frm.ShowDialog()
    End Sub
#End Region

#Region "Change Nam KT"
    Public Sub ChangeNamKT(ByVal nam_kt As Integer)
        barClientNamKT.Caption = "Năm KT: " + nam_kt.ToString
    End Sub
#End Region

#Region "CallTeamview"
    Private Sub CallTeamview()
        Try
            Dim procStartInfo As ProcessStartInfo = New ProcessStartInfo()
            procStartInfo.FileName = Application.StartupPath & "\Util\Teamview.exe"
            If Environment.OSVersion.Version.Major >= 6 Then
                procStartInfo.Verb = "runas"
                procStartInfo.UseShellExecute = True
            End If
            procStartInfo.Arguments = String.Empty
            Dim process As Process = Nothing
            process = process.Start(procStartInfo)
        Catch ex As Exception
            'user cancel process
            Return
        End Try
    End Sub
#End Region
    
End Class
