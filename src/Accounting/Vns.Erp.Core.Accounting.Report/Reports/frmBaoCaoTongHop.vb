#Region "Import"
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports System.Collections
Imports DevExpress.XtraGrid.Views.Base
Imports System.IO
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraReports
Imports DevExpress.LookAndFeel
Imports DevExpress.XtraReports.UserDesigner
Imports DevExpress.XtraTreeList
Imports DevExpress.XtraTreeList.Nodes
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Columns
Imports System.Reflection

Imports Vns.Erp.Core.Admin.Domain
Imports Vns.Erp.Core.Admin.Service.Interface
Imports Vns.Erp.Core.Accounting.Domain
Imports Vns.Erp.Core.Service.Interface
Imports Vns.Erp.Core.Domain

#End Region

Public Class frmBaoCaoTongHop
#Region "Property"
    Private _HtFileBaocaoService As IHtFileBaocaoService
    Public Property HtFileBaocaoService As IHtFileBaocaoService
        Get
            Return _HtFileBaocaoService
        End Get
        Set(ByVal value As IHtFileBaocaoService)
            _HtFileBaocaoService = value
        End Set
    End Property

    Private _HtBienBaocaoService As IHtBienBaocaoService
    Public Property HtBienBaocaoService As IHtBienBaocaoService
        Get
            Return _HtBienBaocaoService
        End Get
        Set(ByVal value As IHtBienBaocaoService)
            _HtBienBaocaoService = value
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
    Private _AppDvBcService As IAppDvBcService
    Public Property AppDvBcService As IAppDvBcService
        Get
            Return _AppDvBcService
        End Get
        Set(ByVal value As IAppDvBcService)
            _AppDvBcService = value
        End Set
    End Property
    Private _HtBaocaoService As IHtBaocaoService
    Public Property HtBaocaoService As IHtBaocaoService
        Get
            Return _HtBaocaoService
        End Get
        Set(ByVal value As IHtBaocaoService)
            _HtBaocaoService = value
        End Set
    End Property
    Private _AppDvGroupBcService As IAppDvGroupBcService
    Public Property AppDvGroupBcService As IAppDvGroupBcService
        Get
            Return _AppDvGroupBcService
        End Get
        Set(ByVal value As IAppDvGroupBcService)
            _AppDvGroupBcService = value
        End Set
    End Property
#End Region

#Region "Variable"
    'Luu tru danh sach paramter
    Private list_usercontrol As List(Of KTY_UserControl)
    Private list_bienbaocao As List(Of HtBienBaocao)

    'Tieu de form
    Private title As String = String.Empty

    'Flag load form lan dau tien
    Private first_Start As Boolean = True

    'Updated by TienNQ
    Private IS_ONE As Boolean = False
    Private USER_ID As Guid
    Private DONVI_ID As Guid
    Private KTY_UC As KTY_UserControl


    'For View
    Private FORM_TITLE As String
    Private DS_FILE_BAOCAO As List(Of HtFileBaocao)
    Private LOAI_BAOCAO As Decimal
    Private DATA_SOURCE As DataTable
    Private OBJ_INFO As HtBaocao
    Private LIST_PARAM As List(Of DevExpress.XtraReports.Parameters.Parameter)

    Private PKG_Name As String = ""
    Private lstParameter As List(Of Object) = New List(Of Object)()
#End Region

#Region "Functions"

    Public Sub New()
        InitializeComponent()
    End Sub

#Region "Grant Report Permission"

    '//////////////////////////////////////////////////
    ' Method:    IsExistedInfoInList
    ' FullName:  frmDonviGroupBaocao.IsExistedInfoInList
    ' Body:		 Check info existed in list. Coded by TienNQ
    ' Access:    private 
    ' Returns:   Decimal)
    ' Parameter: ByVal list As List
    ' Parameter: Of HtBaocao
    ' Parameter: ByVal checkValue As Decimal
    '//////////////////////////////////////////////////
    Private Function IsExistedInfoInList(ByVal list As List(Of HtBaocao), ByVal checkValue As Guid) As Boolean
        Dim bReturn As Boolean = False
        For Each item As HtBaocao In list
            If item.Id = checkValue Then
                bReturn = True
                Exit For
            End If
        Next
        Return bReturn
    End Function

    '//////////////////////////////////////////////////
    ' Method:    IsExistedItemInList
    ' FullName:  frmDonviGroupForm.IsExistedItemInList
    ' Body:		 Check item existed in List(Of String). Coded by TienNQ
    ' Access:    private 
    ' Returns:   String) As Boolean
    ' Parameter: ByVal list As List
    ' Parameter: Of String
    ' Parameter: ByVal item As String
    '//////////////////////////////////////////////////
    Private Function IsExistedItemInList(ByVal list As List(Of String), ByVal item As String) As Boolean
        Try
            Dim bReturn As Boolean = False
            For Each info As String In list
                If info.Equals(item) Then
                    bReturn = True
                End If
            Next
            Return bReturn
        Catch
            Return False
        End Try
    End Function

    '//////////////////////////////////////////////////
    ' Method:    FindParentNode
    ' FullName:  frmDonviGroupBaocao.FindParentNode
    ' Body:		 Find list parent node of list child node. Coded by TienNQ
    ' Access:    private 
    ' Returns:   List(Of HtBaocao)) As List(Of HtBaocao)
    ' Parameter: ByVal listAll As List
    ' Parameter: Of HtBaocao
    ' Parameter: ByVal listTest As List
    ' Parameter: Of HtBaocao
    '//////////////////////////////////////////////////
    Private Function FindParentNode(ByVal listAll As List(Of HtBaocao), ByVal listTest As List(Of HtBaocao)) As List(Of HtBaocao)
        Dim listParent As New List(Of HtBaocao)
        Dim listReturn As New List(Of HtBaocao)
ComeBack:
        Dim isChanged As Boolean = False
        For Each itemTest As HtBaocao In listTest
            For Each itemAll As HtBaocao In listAll
                If (itemAll.Id = itemTest.IdCha) AndAlso (IsExistedInfoInList(listParent, itemAll.Id) = False) Then
                    listParent.Add(itemAll)
                    isChanged = True
                End If
            Next
        Next

        listTest = listParent
        For Each info As HtBaocao In listParent
            listReturn.Add(info)
        Next
        listParent = New List(Of HtBaocao)
        If isChanged = True Then
            GoTo ComeBack
        End If

        Return listReturn
    End Function

    '//////////////////////////////////////////////////
    ' Method:    GetListReportForUser
    ' FullName:  frmBaoCaoTongHop.GetListReportForUser
    ' Body:		 Get list report for normal user
    ' Access:    private 
    ' Returns:   List(Of HT_BaocaoI
    '//////////////////////////////////////////////////
    Private Function GetListReportForUser() As List(Of HtBaocao)
        USER_ID = Globals.LoginUserID
        DONVI_ID = Generals.DON_VI.Id
        'Dim dtBC As DataTable = _HtBaocaoService.GetBCByDVU(DONVI_ID, USER_ID).Tables(0)
        'Dim listBC As List(Of HtBaocao) = CType(DataHelper.DataTableToList(dtBC, GetType(HtBaocao), New List(Of HtBaocao)), List(Of HtBaocao))
        Dim listBC As List(Of HtBaocao) = _AppDvGroupBcService.GetBCByDVU(DONVI_ID, USER_ID) '_HtBaocaoService.GetAllWithOrder()

        Dim tmpguid As Guid = New Guid()
        For i As Integer = listBC.Count - 1 To 0 Step -1
            If (listBC(i).Id = tmpguid) Then
                listBC.RemoveAt(i)
            Else
                tmpguid = listBC(i).Id
            End If
        Next

        Return listBC
    End Function

    '//////////////////////////////////////////////////
    ' Method:    GetListReportForAdminDV
    ' FullName:  frmBaoCaoTongHop.GetListReportForAdminDV
    ' Body:		 Get list report for Admin of DONVI
    ' Access:    private 
    ' Returns:   List(Of HtBaocao)
    '//////////////////////////////////////////////////
    Private Function GetListReportForAdminDV() As List(Of HtBaocao)
        DONVI_ID = Generals.DON_VI.Id
        'Dim dtBC As DataTable = bo_dv_bc.GetBCByDV(DONVI_ID).Tables(0)
        'Dim listBC As List(Of HtBaocao) = CType(DataHelper.DataTableToList(dtBC, GetType(HtBaocao), New List(Of HtBaocao)), List(Of HtBaocao))
        Dim listBC As List(Of HtBaocao) = _HtBaocaoService.GetAllWithOrder()
        Return listBC
    End Function

    '//////////////////////////////////////////////////
    ' Method:    GetListReportForAdminGlobal
    ' FullName:  frmBaoCaoTongHop.GetListReportForAdminGlobal
    ' Body:		 Get list report for Admin Global
    ' Access:    private 
    ' Returns:   List(Of HtBaocao)
    '//////////////////////////////////////////////////
    Private Function GetListReportForAdminGlobal() As List(Of HtBaocao)
        Return _HtBaocaoService.GetAllWithOrder()
    End Function

    '//////////////////////////////////////////////////
    ' Method:    GetListReportForTree
    ' FullName:  frmBaoCaoTongHop.GetListReportForTree
    ' Body:		 Get report data for Build Tree
    ' Access:    private 
    ' Returns:   List(Of HtBaocao)
    '//////////////////////////////////////////////////
    Private Function GetListReportForTree(ByVal ht_baocao_one As HtBaocao) As List(Of HtBaocao)
        'All report
        Dim listAll As List(Of HtBaocao) = New List(Of HtBaocao)

        Select Case Generals.PriorityLevel
            Case 0
                listAll.AddRange(_HtBaocaoService.GetAllWithOrder())
            Case Else
                listAll.AddRange(GetListReportForUser())
        End Select

        Return listAll
    End Function

#End Region

    ''' <summary>
    ''' Load treeMain
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub LoadTreeMain(ByVal ht_baocao_one As HtBaocao)
        TreeDsBang.DataSource = GetListReportForTree(ht_baocao_one)
    End Sub

    ''' <summary>
    ''' Dem so node con
    ''' </summary>
    ''' <param name="node"></param>
    ''' <remarks></remarks>
    Private Sub CountChild(ByVal node As TreeListNode)
        If node.HasChildren Then
            For Each item As TreeListNode In node.TreeList.Nodes
                If item.HasChildren Then
                    CountChild(item)
                End If
            Next
        End If
        node.SetValue(0, node.GetDisplayText(0).ToString + " (" + node.Nodes.Count.ToString + ")")
    End Sub

    ''' <summary>
    ''' Dem so node con de quy
    ''' </summary>
    ''' <param name="treelist"></param>
    ''' <remarks></remarks>
    Private Sub CountChildNodes(ByVal treelist As TreeList)
        Try
            For Each item As TreeListNode In treelist.Nodes
                If item.HasChildren Then
                    item.SetValue(0, item.GetDisplayText(0).ToString + " (" + item.Nodes.Count.ToString + ")")
                End If
            Next
        Catch ex As Exception
        End Try
    End Sub

    ''' <summary>
    ''' Load danh sach template bao cao
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub LoadTemplateList()
        'Lay object dang focus
        Dim obj As HtBaocao = GetNodeFocusing()

        Dim list_template As New List(Of HtFileBaocao)
        list_template.AddRange(_HtFileBaocaoService.GetByHTBAOCAOID(obj.Id))

        'Loai bo cac template khong ton tai
        Dim dir As String = Generals.ThuMucFileBaocao
        'Dim tem As New List(Of HT_File_BaocaoInfo)
        DS_FILE_BAOCAO = New List(Of HtFileBaocao)
        For Each item In list_template
            If File.Exists(dir + item.DuongDan) Then
                DS_FILE_BAOCAO.Add(item)
            End If
        Next
        cboTemplate.EditValue = ""
        cboTemplate.Properties.DataSource = DS_FILE_BAOCAO
        cboTemplate.Properties.ValueMember = "DuongDan"
        cboTemplate.ItemIndex = 0
    End Sub

    ''' <summary>
    ''' Load textbox va danh sach cot filter
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub LoadFilterControl()
    End Sub

    ''' <summary>
    ''' Kich hoat dong control filter
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub ActiveFilter()
    End Sub

    ''' <summary>
    ''' Load user control list
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub LoadUserControlList()
        Dim object_focusing As HtBaocao = GetNodeFocusing()

        'Lay danh sach cac bien bao cao theo id ht_baocao
        'Dim list_bienbaocao As New List(Of HtBienBaocao)
        list_bienbaocao = New List(Of HtBienBaocao)()
        list_bienbaocao.AddRange(_HtBienBaocaoService.GetByHTBAOCAOID(object_focusing.Id))

        'Duyet danh sach bien bao cao va add control len panel
        Dim listUC As New List(Of KTY_UserControl)
        For Each _obj As HtBienBaocao In list_bienbaocao
            'Try
            Select Case _obj.KieuBien
                Case "DM_NHOM_KHANG"
                    'listUC.Add(New Lookup_DM_Nhom_KH(_obj))
                    listUC.Add(CType(ObjectFactory.GetObject("UC_Lookup_DM_Nhom_KH", _obj), Lookup_DM_Nhom_KH))
                Case "GROUP_NAME"
                    listUC.Add(New LookUp_Group_Name(_obj))
                Case "GROUP_NAME_KHO"
                    listUC.Add(New LookUp_Group_Name_Kho(_obj))
                Case "KT_H_BAOCAO"
                    'listUC.Add(New KT_H_Baocao(_obj))
                    listUC.Add(CType(ObjectFactory.GetObject("UC_KT_H_Baocao", _obj), KT_H_Baocao))
                Case "DTIP_NGAY"
                    listUC.Add(New DateTimeInput(_obj))
                Case "UC_NGAY"
                    listUC.Add(New TxtNgay(_obj))
                Case "DM_KHANG"
                    'listUC.Add(New LookupKH(_obj))
                    listUC.Add(CType(ObjectFactory.GetObject("UC_LookupKH", _obj), LookupKH))
                Case "DM_TAIKHOAN"
                    'listUC.Add(New Lookup_Tai_Khoan(_obj))
                    listUC.Add(CType(ObjectFactory.GetObject("UC_Lookup_Tai_Khoan", _obj), Lookup_Tai_Khoan))
                Case "DM_DONVI"
                    'listUC.Add((New Lookup_Don_Vi(_obj)))
                    listUC.Add(CType(ObjectFactory.GetObject("UC_Lookup_Don_Vi", _obj), Lookup_Don_Vi))
                Case "TUOI_KHO"
                    listUC.Add(New LookUp_GetNumber(_obj))
                Case "NAM_SD"
                    listUC.Add(New TxtSo_Nam_Su_Dung(_obj))
                Case "MA_LOAITAISAN"
                    'listUC.Add(New LookUp_Ma_Loai_Tai_San(_obj))
                    listUC.Add(CType(ObjectFactory.GetObject("UC_LookUp_Ma_Loai_Tai_San", _obj), LookUp_Ma_Loai_Tai_San))
                Case "URC_PHONGBAN"
                    'listUC.Add(New LookUp_Phong_Ban(_obj))
                    listUC.Add(CType(ObjectFactory.GetObject("UC_LookUp_Phong_Ban", _obj), LookUp_Phong_Ban))
                Case "LOAI_KHACH_HANG"
                    'listUC.Add(New LookUp_LoaiKHang(_obj))
                    listUC.Add(CType(ObjectFactory.GetObject("UC_LookUp_LoaiKHang", _obj), LookUp_LoaiKHang))
                Case "MA_KHACH_HANG"
                    'listUC.Add(New LookupKH(_obj))
                    listUC.Add(CType(ObjectFactory.GetObject("UC_LookupKH", _obj), LookupKH))
                Case "MA_HANG_HOA"
                    'listUC.Add(New Lookup_Hang_Hoa(_obj))
                    listUC.Add(CType(ObjectFactory.GetObject("UC_Lookup_Hang_Hoa", _obj), Lookup_Hang_Hoa))
                Case "NVT_1"
                    'listUC.Add(New LookUp_Nhom_Vat_Tu_1(_obj))
                    listUC.Add(CType(ObjectFactory.GetObject("UC_LookUp_Nhom_Vat_Tu_1", _obj), LookUp_Nhom_Vat_Tu_1))
                Case "MA_HOP_DONG"
                    'listUC.Add(New LookUp_Hop_Dong(_obj))
                    listUC.Add(CType(ObjectFactory.GetObject("UC_LookUp_Hop_Dong", _obj), LookUp_Hop_Dong))
                Case "DM_KHO"
                    'listUC.Add(New Lookup_DM_Kho(_obj))
                    listUC.Add(CType(ObjectFactory.GetObject("UC_Lookup_DM_Kho", _obj), Lookup_DM_Kho))
                Case "URC_KHO"
                    'listUC.Add(New Lookup_DM_Kho(_obj))
                    listUC.Add(CType(ObjectFactory.GetObject("UC_Lookup_DM_Kho", _obj), Lookup_DM_Kho))
                    'Case "URC_NGAY"
                    '    listUC.Add(New urc_Ngay(_obj))
                    'Case "URC_DOIXE"
                    '    listUC.Add(New urc_DoiXe(_obj))
                    'Case "URC_KHACHHANG"
                    '    listUC.Add(New urc_KhachHang(_obj))
                    'Case "URC_KIEUXE"
                    '    listUC.Add(New urc_KieuXe(_obj))
                    'Case "URC_LAIXE"
                    '    listUC.Add(New urc_LaiXe(_obj))
                    'Case "URC_LOAILENH"
                    '    listUC.Add(New urc_LoaiLenh(_obj))
                    'Case "URC_LAIMOI"
                    '    listUC.Add(New urc_LoaiLenh(_obj))
                    'Case "URC_BACTHO"
                    '    listUC.Add(New urc_LoaiLenh(_obj))
                    'Case "URC_NHOMBOPHAN"
                    '    listUC.Add(New urc_NhomBoPhan(_obj))
                    'Case "URC_SOXE"
                    '    listUC.Add(New urc_SoXe(_obj))
                    'Case "URC_TEXT"
                    '    listUC.Add(New urc_Text(_obj))
                    'Case "URC_GARA"
                    '    listUC.Add(New urc_Gara(_obj))
                    'Case "URC_MUCTHAP"
                    '    listUC.Add(New urc_Text(_obj))
                    'Case "URC_DIEMGIAOCA"
                    '    listUC.Add(New urc_DiemGiaoCa(_obj))
                    'Case "URC_CAYXANG"
                    '    listUC.Add(New urc_CayXang(_obj))
                    'Case "URC_TONGHOPTHEO_GIAOVE"
                    '    listUC.Add(New urc_LoaiLenh(_obj))
                    'Case "URC_TONGHOPTHEO_VE"
                    '    listUC.Add(New urc_LoaiLenh(_obj))
                    'Case "URC_TONGHOPTHEO_TNH"
                    '    listUC.Add(New urc_LoaiLenh(_obj))
                    'Case "URC_LOAIBANGKE"
                    '    listUC.Add(New urc_LoaiLenh(_obj))
                    'Case "URC_TONGHOPTHEO_KH"
                    '    listUC.Add(New urc_LoaiLenh(_obj))
                    'Case "URC_DINHNGACH"
                    '    listUC.Add(New urc_LoaiLenh(_obj))
                    'Case "URC_DCKHO"
                    '    listUC.Add(New urc_LoaiLenh(_obj))
                    'Case "URC_KHO"
                    '    listUC.Add(New Lookup_DM_Kho(_obj))
                    'Case "URC_PHANLOAIVE"
                    '    listUC.Add(New urc_NhomVe(_obj))
                    'Case "URC_SOVE"
                    '    listUC.Add(New urc_SoVe(_obj))
                    'Case "URC_NHOMVE1"
                    '    listUC.Add(New urc_NhomVe(_obj))
                    'Case "URC_NHOMVE2"
                    '    listUC.Add(New urc_NhomVe(_obj))
                    'Case "URC_NHOMVE3"
                    '    listUC.Add(New urc_NhomVe(_obj))
                    'Case "URC_LOAITHE"
                    '    listUC.Add(New urc_Text(_obj))
                    'Case "URC_TKVATTU"
                    '    listUC.Add(New urc_TKVT(_obj))
                    'Case "URC_MAUBAOCAO"
                    '    listUC.Add(New urc_MauBaoCao(_obj))
                    'Case "URC_SOLOP"
                    '    listUC.Add(New urc_SoLop(_obj))
                    'Case "URC_LOAIXE"
                    '    listUC.Add(New urc_KieuXe(_obj))
                    'Case "URC_LHTT"
                    '    listUC.Add(New urc_LHTT(_obj))
                    'Case "URC_HOPDONG"
                    '    listUC.Add(New urc_HopDong(_obj))
                    'Case "URC_MAVE"
                    '    listUC.Add(New urc_MaVe(_obj))
                    'Case "URC_LOAIBC_NH"
                    '    listUC.Add(New urc_LoaiLenh(_obj))
                    'Case "URC_LOAITHE_NH"
                    '    listUC.Add(New urc_LoaiLenh(_obj))
                    'Case "URC_NHOMVATTU1"
                    '    listUC.Add(New urc_NhomVatTu1(_obj))
                    'Case "URC_NHOMVATTU2"
                    '    listUC.Add(New urc_NhomVatTu2(_obj))
                    'Case "URC_NHOMVATTU3"
                    '    listUC.Add(New urc_NhomVatTu3(_obj))
                    'Case "URC_TKVATTU"
                    '    listUC.Add(New urc_TKVatTu(_obj))
                    'Case "URC_LHTT_CN"
                    '    listUC.Add(New urc_LoaiLenh(_obj))
                Case "DM_NGOAITE"
                    'listUC.Add(New LookUp_Ma_NTE(_obj))
                    listUC.Add(CType(ObjectFactory.GetObject("UC_LookUp_Ma_NTE", _obj), LookUp_Ma_NTE))
                Case "DM_TAIKHOAN_2"
                    listUC.Add(New txtMA_TAIKHOAN(_obj))
                Case "HT_LOAICHUNGTU"
                    'listUC.Add(New Lookup_HTLoaiChungTu(_obj))
                    listUC.Add(CType(ObjectFactory.GetObject("UC_Lookup_HTLoaiChungTu", _obj), Lookup_HTLoaiChungTu))
                Case "DM_VuViec"
                    'listUC.Add(New Lookup_VuViec(_obj))
                    listUC.Add(CType(ObjectFactory.GetObject("UC_Lookup_VuViec", _obj), Lookup_VuViec))
                Case "NHOM_TSCD"
                    'listUC.Add(New LookUp_NhomTS(_obj))
                    listUC.Add(CType(ObjectFactory.GetObject("UC_LookUp_NhomTS", _obj), LookUp_NhomTS))
                Case "TEXTNUMBER"
                    listUC.Add(New txtNumber(_obj))
                Case "DM_TAIKHOAN_MUL"
                    'listUC.Add(New Lookup_MulTai_Khoan(_obj))
                    listUC.Add(CType(ObjectFactory.GetObject("UC_Lookup_MulTai_Khoan", _obj), Lookup_MulTai_Khoan))
                Case "TRANG_THAI"
                    'listUC.Add(New urc_TrangThai(_obj))
                    listUC.Add(CType(ObjectFactory.GetObject("UC_urc_TrangThai", _obj), urc_TrangThai))
                Case "DM_PTQT"
                    'listUC.Add(New Lookup_PTQT(_obj))
                    listUC.Add(CType(ObjectFactory.GetObject("UC_Lookup_PTQT", _obj), Lookup_PTQT))
                Case "DM_KHOANPHI"
                    'listUC.Add(New LookUp_KhoanPhi(_obj))
                    listUC.Add(CType(ObjectFactory.GetObject("UC_LookUp_KhoanPhi", _obj), LookUp_KhoanPhi))
                Case "DM_TUDO1"
                    'listUC.Add(New LookUp_DM_TUDO1(_obj))
                    listUC.Add(CType(ObjectFactory.GetObject("UC_LookUp_DM_TUDO1", _obj), LookUp_DM_TUDO1))
                Case "DM_TUDO2"
                    'listUC.Add(New LookUp_DM_TUDO2(_obj))
                    listUC.Add(CType(ObjectFactory.GetObject("UC_LookUp_DM_TUDO2", _obj), LookUp_DM_TUDO2))
                Case "DM_TUDO3"
                    'listUC.Add(New LookUp_DM_TUDO3(_obj))
                    listUC.Add(CType(ObjectFactory.GetObject("UC_LookUp_DM_TUDO3", _obj), LookUp_DM_TUDO3))
                Case "DM_TUDO4"
                    'listUC.Add(New LookUp_DM_TUDO4(_obj))
                    listUC.Add(CType(ObjectFactory.GetObject("UC_LookUp_DM_TUDO4", _obj), LookUp_DM_TUDO4))
                Case "DM_TUDO5"
                    'listUC.Add(New LookUp_DM_TUDO5(_obj))
                    listUC.Add(CType(ObjectFactory.GetObject("UC_LookUp_DM_TUDO5", _obj), LookUp_DM_TUDO5))
            End Select
            'Catch
            '    Message_Information("UserControl không có")
            'End Try

        Next
        If FlowLayoutPanel1.Controls.Count > 0 Then
            FlowLayoutPanel1.Controls.Clear()
        End If

        'Them control vao luoi
        For Each objUC As KTY_UserControl In listUC
            If Not (CheckShowUControl(objUC)) Then
                Continue For
            End If

            FlowLayoutPanel1.Controls.Add(objUC)
        Next

        Me.list_usercontrol = New List(Of KTY_UserControl)
        Me.list_usercontrol = listUC
    End Sub

    ''' <summary>
    ''' Load tieu de bang du lieu
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub LoadTitleHeader()
        Dim object_focusing As HtBaocao = GetNodeFocusing()
        Me.title = ""
        GetLevelString(object_focusing)
        grpHeader.Text = Me.title
        FORM_TITLE = Me.title
    End Sub

    ''' <summary>
    ''' Lay chuoi hien thi tieu de
    ''' </summary>
    ''' <param name="obj"></param>
    ''' <remarks></remarks>
    Private Sub GetLevelString(ByVal obj As HtBaocao)
        Dim list_parent As HtBaocao = _HtBaocaoService.GetById(obj.IdCha)
        If list_parent IsNot Nothing Then
            GetLevelString(list_parent)
        End If
        If Me.title.Equals(String.Empty) Then
            Me.title = obj.TenBaocao
        Else
            Me.title += " - " + obj.TenBaocao
        End If
    End Sub

    ''' <summary>
    ''' Load Gridview
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub LoadGridview()

        frmProgress.Instance.Thread = AddressOf LoadReportData
        frmProgress.Instance.Show_Progress()

        OpenInNewWindows()
    End Sub

    Private Sub LoadReportData()
        DATA_SOURCE = GetDataByParamter()
        OBJ_INFO = GetNodeFocusing()
        LIST_PARAM = GetBienBaoCaoToParameter()
    End Sub

    ''' <summary>
    ''' Open in new windows
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub OpenInNewWindows()
        Dim frmView As frmBaoCaoView = CType(ObjectFactory.GetObject("frmBaoCaoView"), frmBaoCaoView)
        frmView.PKG_Name = PKG_Name
        frmView.LstParameter = lstParameter
        frmView.FORM_TITLE = FORM_TITLE
        frmView.DS_FILE_BAOCAO = DS_FILE_BAOCAO
        frmView.LIST_PARAM = LIST_PARAM
        frmView.OBJ_INFO = OBJ_INFO
        frmView.DATA_SOURCE = DATA_SOURCE
        frmView.TuNgay = TuNgay
        frmView.DenNgay = DenNgay
        frmView.ShowDialog()
    End Sub

    ''' <summary>
    ''' Dinh lai do rong tong cac cot:
    ''' Kiem tra do rong tat cac cac cot: neu lon hon man hinh thi tat chuc nang auto width
    ''' </summary>
    ''' <param name="gridview"></param>
    ''' <param name="first_col_name"></param>
    ''' <remarks></remarks>
    Private Sub BestFitAllColumns(ByVal gridview As GridView, ByVal first_col_name As String)
        gridview.OptionsView.ColumnAutoWidth = False
        gridview.RefreshData()
        Dim equal As Double = 0
        If gridview.Columns.Count > 0 Then
            For Each item As GridColumn In gridview.Columns
                If item.Visible = True Then
                    equal = equal + item.Width
                End If
            Next
        End If
        If (equal > 0 And equal < gridview.GridControl.Width) Then
            gridview.OptionsView.ColumnAutoWidth = True
        End If
        gridview.RefreshData()
        gridview.BestFitColumns()

        'Fix cot dau tien ko cho scroll
        Try
            gridview.Columns(0).Fixed = FixedStyle.Left
        Catch ex As Exception
            'Message_Warning("Cột dữ liệu '" + first_col_name + "' không tồn tại, kiểm tra lại!")
            'Message_Error(ex)
        End Try
    End Sub

    ''' <summary>
    ''' Load lai caption tren grid
    ''' </summary>
    ''' <param name="ob"></param>
    ''' <remarks></remarks>
    Private Sub ChangeCaptionGridview(ByVal ob As HtBaocao)
        Dim arCaption As New ArrayList()
        Dim arDisplay As New ArrayList()
        arCaption = CommonClass.convertStringToArrayList(ob.CotHienthi.ToUpper, ";")
        arDisplay = CommonClass.convertStringToArrayList(ob.TenHienthi, ";")
        Dim colIndex = 0
        For i = 0 To grvMain.Columns.Count - 1
            If grvMain.Columns(i).Visible = True Then
                Dim checkVisiable As Boolean = False
                Dim thisCol = grvMain.Columns(i).FieldName
                For j = 0 To arCaption.Count - 1
                    If thisCol = arCaption(j) Then
                        'Set visible
                        grvMain.Columns(i).Visible = True
                        grvMain.Columns(i).Caption = arDisplay(j).ToString()
                        checkVisiable = True
                        'Set index colum
                        grvMain.Columns(i).VisibleIndex = colIndex
                        colIndex = colIndex + 1
                        Exit For
                    End If
                Next
                If Not checkVisiable Then
                    grvMain.Columns(i).Visible = False
                End If
            End If
        Next
        'Xu ly them truong hop neu ds cot hien thi null
        If arCaption.Count <= 0 Then
            For l = 0 To grvMain.Columns.Count - 1
                grvMain.Columns(l).Visible = True
            Next
        End If

        'Tinh do rong cot de hien thi
        If arCaption(0) <> Nothing Then
            BestFitAllColumns(grvMain, arCaption(0).ToString)
        End If
    End Sub

    ''' <summary>
    ''' Lay danh sach bien bao cao convert thanh parameter
    ''' </summary>
    ''' <returns>List Report prameter</returns>
    ''' <remarks></remarks>
    Private Function GetBienBaoCaoToParameter() As List(Of DevExpress.XtraReports.Parameters.Parameter)
        Dim lstParaBien As List(Of DevExpress.XtraReports.Parameters.Parameter) = New List(Of DevExpress.XtraReports.Parameters.Parameter)
        Dim paraByBien As DevExpress.XtraReports.Parameters.Parameter

        'For Each item As KTY_UserControl In FlowLayoutPanel1.Controls
        For Each item As KTY_UserControl In list_usercontrol

            Try
                If (CheckShowUControl(item)) Then
                    If Not String.IsNullOrEmpty(item.Parameter_info.TenParameter) Then
                        paraByBien = New DevExpress.XtraReports.Parameters.Parameter
                        paraByBien.Name = item.Parameter_info.TenParameter
                        paraByBien.Value = item.Value_info.Ten
                        lstParaBien.Add(paraByBien)
                    Else
                        paraByBien = New DevExpress.XtraReports.Parameters.Parameter
                        paraByBien.Name = ""
                        paraByBien.Value = ""
                        lstParaBien.Add(paraByBien)
                    End If
                Else
                    paraByBien = New DevExpress.XtraReports.Parameters.Parameter
                    paraByBien.Name = item.Parameter_info.TenParameter
                    paraByBien.Value = ""
                    lstParaBien.Add(paraByBien)
                End If
                'If Not item.Parameter_info.TEN_PARAMETER.ToString().Equals(String.Empty) _
                '    And Not item.Value_info.ParameterValue.ToString().Equals(String.Empty) Then

            Catch
            End Try

        Next
        Return lstParaBien
    End Function

    ''' <summary>
    ''' Load Report
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub LoadReport()
        'Try
        Dim dir As String = Generals.ThuMucFileBaocao
        dir = dir + cboTemplate.EditValue

        'Neu la file repx thi load template
        'Neu la file excel xls thi mo file do len
        Dim lstPara As List(Of DevExpress.XtraReports.Parameters.Parameter) = GetBienBaoCaoToParameter()

        If File.Exists(dir) Then
            Dim s = System.IO.Path.GetExtension(dir)
            If String.Compare(s.ToUpper(), ".XLS") = 0 Or String.Compare(s.ToUpper(), ".XLSX") = 0 Then
                System.Diagnostics.Process.Start(dir)
            ElseIf String.Compare(s, ".repx") = 0 Then
                Dim prv As New ReportPreview(CommonClass.GetDataTableFromDatasourceGrid(grvMain), dir, lstPara)
                prv.Show()
            End If
        End If
        'Catch ex As Exception
        '    Message_Error(ex)
        'End Try
    End Sub

    ''' <summary>
    ''' Lay du lieu cho gridview hien thi
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function GetDataByParamter() As DataTable
        Dim object_focusing As HtBaocao = GetNodeFocusing()
        Dim data As New DataTable
        PKG_Name = object_focusing.TenProcedure
        'Dim s As String = "RpLedgerS38DNService"
        Dim iReport As IErpService(Of BcKetoan, Guid) = ObjectFactory.GetObject(PKG_Name)
        'Throw New Exception("Chua hoan thien")
        'data = HeThong_UtilBO.Instance().GetDataForReport(object_focusing.TenProcedure, GetAllParameterFormUC).Tables(0)
        Return iReport.GetData(Nothing, GetAllParameterFormUC)
    End Function

    Private TuNgay As Date
    Private DenNgay As Date
    ''' <summary>
    ''' Lay danh sach paramter
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function GetAllParameterFormUC() As List(Of Object)
        Dim lst As New List(Of Object)
        If Me.list_usercontrol.Count > 0 Then
            For Each item As KTY_UserControl In Me.list_usercontrol
                If (Not CheckShowUControl(item)) Then
                    lst.Add(Nothing)
                    Continue For
                End If

                If item.Parameter_info.KieuBien.Equals("DTIP_NGAY") Then
                    lst.Add(item.Value_info.Tu_Ngay)
                    lst.Add(item.Value_info.Den_Ngay)
                    TuNgay = CType(item.Value_info.Tu_Ngay, Date)
                    DenNgay = CType(item.Value_info.Den_Ngay, Date)
                Else
                    lst.Add(item.Value_info.ParameterValue)
                End If
            Next
        End If

        lstParameter = lst
        Return lst
    End Function

    Private Function CheckShowUControl(ByVal KTYUC As KTY_UserControl) As Boolean
        Dim bshow As Boolean = False

        Select Case KTYUC.Parameter_info.CoGiaTri
            Case 0
                bshow = True
            Case 1
                bshow = True
            Case 2
                bshow = False
            Case Else
                bshow = True
        End Select

        'Return false => UC khong dc load len form dieu kien, gia tri bien mac dinh = NoThing
        Return bshow
    End Function

    ''' <summary>
    ''' Lay danh sach cac cot duoc phep hien thi
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function GetListColumn() As List(Of ColumnReportInfo)
        Dim obj As HtBaocao = GetNodeFocusing()

        Dim lst As New List(Of ColumnReportInfo)
        Dim arDisplay As New ArrayList
        arDisplay = CommonClass.convertStringToArrayList(obj.CotHienthi, ";")
        Dim arCaption As New ArrayList
        arCaption = CommonClass.convertStringToArrayList(obj.CotHienthi, ";")

        Dim one_item As ColumnReportInfo
        If arDisplay.Count > 0 Then
            For i = 0 To arDisplay.Count - 1
                one_item = New ColumnReportInfo
                If Not arDisplay(i).Equals(String.Empty) Then
                    one_item.COT_HIENTHI = arDisplay(i)
                    one_item.TEN_HIENTHI = arCaption(i)
                End If
                lst.Add(one_item)
            Next
        End If
        Return lst
    End Function

    ''' <summary>
    ''' Lay node dang focus -> object HtBaocao
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function GetNodeFocusing() As HtBaocao
        Dim obj As New HtBaocao
        Dim node As TreeListNode
        Try
            node = TreeDsBang.FindNodeByID(TreeDsBang.FocusedNode.Id)
            obj = CType(TreeDsBang.GetDataRecordByNode(node), HtBaocao)
        Catch ex As Exception
        End Try
        Return obj
    End Function

    ''' <summary>
    ''' Lay node theo ID bao cao
    ''' </summary>
    ''' <param name="id_ht_baocao"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function GetNodeByField(ByVal id_ht_baocao As Guid) As TreeListNode
        Return TreeDsBang.FindNodeByFieldValue("Id", id_ht_baocao)
    End Function

    ''' <summary>
    ''' Dinh dang form Bao cao tong hop
    ''' </summary>
    ''' <param name="isOne"></param>
    ''' <remarks></remarks>
    Private Sub SetStyleForLoad(ByVal isOne As Boolean)
        If isOne = True Then
            'Hien thi button
            btnShowSearchOption.Visible = True
            'Panel trai an
            SplitContainerControl2.Panel1.Width = 0
            SplitContainerControl2.Panel1.Dock = DockStyle.None
            SplitContainerControl2.Panel2.Dock = DockStyle.Fill
            'Panel phai hien thi
            SplitContainerControl1.Panel1.Height = 170
            SplitContainerControl1.Panel1.Dock = DockStyle.None
            SplitContainerControl1.Panel2.Dock = DockStyle.None
        Else
            'An button
            btnShowSearchOption.Visible = False
        End If
    End Sub

    ''' <summary>
    ''' An/Hien khung tim kiem
    ''' </summary>
    ''' <param name="isVisible"></param>
    ''' <remarks></remarks>
    Private Sub SetVisibleSearchOption(ByVal isVisible As Boolean)
        If isVisible = True Then
            SplitContainerControl1.Panel1.Height = 170
            SplitContainerControl1.Panel1.Dock = DockStyle.None
            SplitContainerControl1.Panel2.Dock = DockStyle.None
        Else
            SplitContainerControl1.Panel1.Height = 0
            SplitContainerControl1.Panel1.Dock = DockStyle.None
            SplitContainerControl1.Panel2.Dock = DockStyle.Fill
        End If
    End Sub

    ''' <summary>
    ''' Bind du lieu vao Grid
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub BindDataToGridMain()
        'If GetNodeFocusing.
        If GetNodeFocusing.LoaiBaocao = 3 Then
            Return
        End If

        If GetNodeFocusing.ChiTiet = 1 Then 'If item is report
            Try
                Dim listUC As List(Of KTY_UserControl) = CheckInput()
                If listUC.Count = 0 Then
                    LoadGridview()
                    'btnxem.Text = "Làm mới"
                Else
                    Dim strError As String = ""
                    For Each itemUC As KTY_UserControl In listUC
                        strError = strError + "- " + itemUC.Parameter_info.TenBien + " chưa có giá trị." + vbNewLine
                    Next
                    Message_Warning(strError)
                    'Message_Warning("Chưa nhập đủ dữ liệu đầu vào để xem báo cáo.")
                End If
            Catch ex As Exception
                'Message_Information("Danh sách Cột hiển thị và Tên hiển thị không tương ứng")
                'Message_Error(ex)
            End Try
        End If

        If IS_ONE = True Then
            SetVisibleSearchOption(False)
        End If
    End Sub

    ''' <summary>
    ''' Close form
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub CloseForm()

    End Sub

    ''' <summary>
    ''' Refresh gridview
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub RefreshGrid()
        grcMain.DataSource = Nothing
        grvMain.Columns.Clear()

        'Colum tem
        Dim colum As GridColumn

        'Lay node dang focus
        Dim now_focusing As HtBaocao = GetNodeFocusing()

        'Lay danh sach caption
        Dim arCaption As New ArrayList()
        Dim arDisplay As New ArrayList()
        arCaption = CommonClass.convertStringToArrayList(now_focusing.CotHienthi.ToUpper, ";")
        arDisplay = CommonClass.convertStringToArrayList(now_focusing.TenHienthi, ";")

        'Bind cot len grid
        If arCaption.Count > 0 Then
            For index As Integer = 0 To arCaption.Count - 1
                colum = New GridColumn()
                colum.FieldName = arCaption(index).ToString
                'Rat co the arDisplay ko co phan tu thu index
                Try
                    colum.Caption = arDisplay(index).ToString
                Catch ex As Exception
                End Try
                grvMain.Columns.Add(colum)
                grvMain.Columns(index).Visible = True
            Next
        End If

        BestFitAllColumns(grvMain, arCaption(0).ToString)
        grvMain.RefreshData()
    End Sub

    ''' <summary>
    '''  Load All
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub LoadAll()
        LoadUserControlList()
        LoadTitleHeader()
        LoadTemplateList()
        LoadFilterControl()
        RefreshGrid()
    End Sub

    ''' <summary>
    ''' Get KTY UserControl, that is focused in FlowLayout
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function GetKTYControlFocused() As KTY_UserControl
        Try
            Dim focusedControl As Control = Me.ActiveControl
            Dim ktyFocused As KTY_UserControl = Nothing
            For Each ktyControl As KTY_UserControl In FlowLayoutPanel1.Controls
                'If control focused in FlowLayoutPanel, return it, else return nothing
                If focusedControl.Name.Equals(ktyControl.Name) Then
                    ktyFocused = CType(focusedControl, KTY_UserControl)
                    Exit For
                End If
            Next
            Return ktyFocused
        Catch
            Return Nothing
        End Try
    End Function

    ''' <summary>
    ''' Show Quick Edit
    ''' </summary>
    ''' <param name="ktyUC"></param>
    ''' <remarks></remarks>
    Private Sub ShowQuickEditFromUC(ByVal ktyUC As KTY_UserControl)
        Try
            Dim frmDS As Form = Nothing 'Form
            Dim methodInfo As MethodInfo = Nothing 'Method
            Dim methodName As String = "QuickAddObject" 'Method Name
            Dim objValue As Object = Nothing 'Value form Method Invoke

            'Define form for show quick add object
            Select Case ktyUC.Parameter_info.KieuBien
                Case "DTIP_NGAY"
                Case "UC_NGAY"
                Case "DM_KHANG"
                Case "DM_TAIKHOAN"
                Case "DM_DONVI"
                Case "NAM_SD"
                Case "MA_LOAITAISAN"
                Case "LOAI_KHACH_HANG"
                Case "MA_KHACH_HANG"
                Case "MA_HANG_HOA"
                    'frmDS = SystemHelper.GetFormAssembly("frmDanhMucHangHoa_DanhSach", Nothing, False, "")
                Case "NVT_1"
                Case "NVT_2"
                Case "NVT_3"
                Case "MA_HOP_DONG"
                Case "DM_KHO"
                Case "URC_NGAY"
                Case "URC_DOIXE"
                Case "URC_KHACHHANG"
                Case "URC_KIEUXE"
                Case "URC_LAIXE"
                Case "URC_LOAILENH"
                Case "URC_LAIMOI"
                Case "URC_BACTHO"
                Case "URC_NHOMBOPHAN"
                Case "URC_SOXE"
                Case "URC_TEXT"
                Case "URC_GARA"
                Case "URC_MUCTHAP"
                Case "URC_DIEMGIAOCA"
                Case "URC_CAYXANG"
                Case "URC_TONGHOPTHEO_GIAOVE"
                Case "URC_TONGHOPTHEO_VE"
                Case "URC_TONGHOPTHEO_TNH"
                Case "URC_LOAIBANGKE"
                Case "URC_TONGHOPTHEO_KH"
                Case "URC_DINHNGACH"
                Case "URC_DCKHO"
                Case "URC_KHO"
                Case "URC_PHANLOAIVE"
                Case "URC_SOVE"
                Case "URC_NHOMVE1"
                Case "URC_NHOMVE2"
                Case "URC_NHOMVE3"
                Case "URC_LOAITHE"
                Case "URC_TKVATTU"
                Case "URC_MAUBAOCAO"
                Case "URC_SOLOP"
                Case "URC_LOAIXE"
                Case "URC_LHTT"
                Case "URC_HOPDONG"
                Case "URC_MAVE"
                Case "URC_LOAIBC_NH"
                Case "URC_LOAITHE_NH"
                Case "URC_NHOMVATTU1"
                Case "URC_NHOMVATTU2"
                Case "URC_NHOMVATTU3"
                Case "URC_TKVATTU"
                Case "URC_LHTT_CN"
                Case "DM_NGOAITE"
                    'End
            End Select

            'Show Quick Add Object Form
            methodInfo = GetMethodByName(frmDS, methodName)
            objValue = methodInfo.Invoke(frmDS, Nothing)
            ktyUC.ReLoad(objValue)
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    ''' <summary>
    ''' Check Input Value for Report Filter
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function CheckInput() As List(Of KTY_UserControl)
        Dim listUC As New List(Of KTY_UserControl)
        If FlowLayoutPanel1.Controls.Count > 0 Then
            For Each itemKTYUC As KTY_UserControl In FlowLayoutPanel1.Controls

                Select Case itemKTYUC.Parameter_info.CoGiaTri
                    Case 1 'Bat buoc phai nhap gia tri
                        If itemKTYUC.Value_info.ParameterValue Is Nothing Then
                            listUC.Add(itemKTYUC)
                        End If
                    Case 0
                        'Gia tri khong bat buoc
                    Case 2 'Gia tri khong bat buoc
                    Case Else 'Con lai
                End Select
            Next
        End If
        Return listUC
    End Function

    ''' <summary>
    ''' Call Direct
    ''' </summary>
    ''' <param name="fullFormName"></param>
    ''' <remarks></remarks>
    Private Sub CallDirect(ByVal fullFormName As String)
        Try
            SystemHelper.ShowFormFullOther(fullFormName, Nothing, "", True)
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub
#End Region

#Region "Events"

    Private Sub frmBaoCaoTongHop_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown, grcMain.KeyDown, btnxem.KeyDown
        Try
            If e.KeyCode = Keys.Escape Then
                Me.Close()
            ElseIf e.KeyCode = Keys.Enter Then
                'SendKeys.Send("{TAB}")
                '
            ElseIf (e.Alt = True) AndAlso (e.KeyCode = Keys.Z) Then
                SetVisibleSearchOption(True)
            ElseIf (e.Alt = True) AndAlso (e.KeyCode = Keys.E) Then
                MultiExportButton1.DoExport()
            ElseIf (e.Alt = True) AndAlso (e.KeyCode = Keys.R) Then
                LoadReport()
            ElseIf (e.Alt = True) AndAlso (e.KeyCode = Keys.A) Then
                BindDataToGridMain()
            End If
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub frmBaoCaoTongHop_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            'Kiem tra xe form bat len co tham so dau vao khong, neu co thi focus node dc truyen
            Dim MaBaocao As String = String.Empty
            Dim input_form As String = Me.AccessibleDescription
            Try
                If Not String.IsNullOrEmpty(input_form) Then
                    Dim list_param As List(Of ParamInfo) = DataMining.GetParams(input_form)
                    MaBaocao = list_param(0).PARAMVALUE

                    'Neu duoc fix tham so
                    TreeDsBang.Enabled = False
                End If
            Catch
            End Try

            Dim obj As HtBaocao = _HtBaocaoService.GetByMa(MaBaocao)
            LoadTreeMain(obj)

            LoadTitleHeader()
            LoadTemplateList()
            LoadFilterControl()
            LoadUserControlList()

            'Form load ket thuc
            Me.first_Start = False

            'Set focus vao node tren cung
            If TreeDsBang.Nodes.Count > 0 Then
                Dim node_bc As TreeListNode = TreeDsBang.Nodes(0)
                Dim ten_bc As String = node_bc.GetDisplayText(0)
                For Each cNode As TreeListNode In TreeDsBang.Nodes
                    Dim ten_bao_cao As String = cNode.GetDisplayText(0)
                    If String.Compare(ten_bao_cao, ten_bc) < 0 Then
                        ten_bc = ten_bao_cao
                        node_bc = cNode
                    End If
                Next
                TreeDsBang.SetFocusedNode(node_bc)
                TreeDsBang.CollapseAll()
            End If

            'Add handle cho su kien  focus node change
            AddHandler TreeDsBang.FocusedNodeChanged, AddressOf TreeDsBang_FocusedNodeChanged

            SetStyleForLoad(IS_ONE)
            If Not obj Is Nothing Then
                Dim node_one As TreeListNode = GetNodeByField(obj.Id)
                TreeDsBang.SetFocusedNode(node_one)
            End If
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Dim SelectedNode As DevExpress.XtraTreeList.Nodes.TreeListNode
    Private Sub TreeDsBang_FocusedNodeChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraTreeList.FocusedNodeChangedEventArgs)
        SelectedNode = e.Node
        CallReport(e.Node)
    End Sub

    Private Sub TreeDsBang_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TreeDsBang.DoubleClick
        If (RaiseDoubleClick) Then
            CallReport(SelectedNode)
        End If
    End Sub

    Dim RaiseDoubleClick As Boolean = False
    ''' <summary>
    ''' Call Report by Node is selected
    ''' </summary>
    ''' <param name="_selectNode"></param>
    ''' <remarks></remarks>
    Private Sub CallReport(ByVal _selectNode As DevExpress.XtraTreeList.Nodes.TreeListNode)
        Try
            If (_selectNode Is Nothing) Then
                Return
            End If
            If Not _selectNode.HasChildren Then
                If GetNodeFocusing.LoaiBaocao = 3 Then
                    RaiseDoubleClick = True
                    CallDirect(GetNodeFocusing.GhiChu)
                    'Message_Information("Call direct ok !")
                Else
                    RaiseDoubleClick = False
                    frmProgress.Instance().Thread = AddressOf LoadAll
                    'frmProgress.Instance().Show_Progress("Đang tải dữ liệu", "Xong")
                    frmProgress.Instance().Show_Progress("Đang tải dữ liệu")
                End If
            End If
        Catch ex As Exception
            Message_Error(ex)
        Finally
        End Try
    End Sub

    Private Sub btnxem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnxem.Click
        Try

            BindDataToGridMain()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub btnReportSubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReportSubmit.Click
        Try
            LoadReport()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub TreeDsBang_GetStateImage(ByVal sender As System.Object, ByVal e As DevExpress.XtraTreeList.GetStateImageEventArgs) Handles TreeDsBang.GetStateImage
        Try
            If e.Node.HasChildren Then
                e.NodeImageIndex = 0
            Else
                e.NodeImageIndex = 18
            End If
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub grvMain_ColumnWidthChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.ColumnEventArgs) Handles grvMain.ColumnWidthChanged
        Try
            'Hien scroll khi resize column width
            grvMain.OptionsView.ColumnAutoWidth = False
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub btnShowSearchOption_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShowSearchOption.Click
        Try
            SetVisibleSearchOption(True)
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

#Region "Popup Event"
    Private Function IsDataRow() As Boolean
        Try
            Dim bCheck As Boolean = True
            Dim rowData As DataRowView = CType(grvMain.GetFocusedRow, DataRowView)
            Dim cth_id As String = rowData("CTH_ID").ToString
            If cth_id.Equals("") Then
                bCheck = False
            End If
            Return bCheck
        Catch
            Return False
        End Try
    End Function

    ''' <summary>
    ''' Show Popup Panel
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub grcMain_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles grcMain.MouseClick
        Try
            If (e.Button = MouseButtons.Right) AndAlso (grvMain.RowCount > 0) AndAlso (IsDataRow()) Then
                popupControl.ShowPopup(MousePosition)
            End If
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    ''' <summary>
    ''' Double Click and Show Detail
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub grvMain_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grvMain.DoubleClick
        CallDetail()
    End Sub

    ''' <summary>
    ''' Popup for Show Detail
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub popDetail_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles popDetail.ItemClick
        CallDetail()
    End Sub

    Private Sub CallDetail()
        Try
            Dim rowData As DataRowView = CType(grvMain.GetFocusedRow, DataRowView)
            Dim cth_id As Guid = VnsConvert.CGuid(rowData("CthId").ToString)
            If Not cth_id.Equals("") Then
                Dim id_loai_ct As Guid = VnsConvert.CGuid(rowData("IdLoaiCt").ToString)
                Dim infoLoaiCT As HtLoaichungtu = _HtLoaichungtuService.GetById(id_loai_ct)
                Dim currentRowIndex As Integer = grvMain.FocusedRowHandle
                Dim listCTHG As List(Of Extend.CT_H_GInfo) = GetNumberCTHG(5, currentRowIndex)
                'Dim listCTHG As List(Of CT_H_GInfo) = GetAllCTHG(currentRowIndex)
                ShowDetail(cth_id, infoLoaiCT.MaLoaiCt, infoLoaiCT.TenLoaiCt, infoLoaiCT.DuongDan, listCTHG, DataInputState.EditMode)
            End If
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    ''' <summary>
    ''' Refresh Grid
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub popRefresh_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles popRefresh.ItemClick
        'Try

        'Catch ex As Exception
        '    Message_Error(ex)
        'End Try
    End Sub

    ''' <summary>
    ''' Close Form
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub popClose_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles popClose.ItemClick
        Try
            Me.Close()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    ''' <summary>
    ''' Show Detail
    ''' </summary>
    ''' <param name="cth_id"></param>
    ''' <param name="ma_loai_ct"></param>
    ''' <param name="ten_loai_ct"></param>
    ''' <param name="duong_dan"></param>
    ''' <param name="state"></param>
    ''' <remarks></remarks>
    Private Sub ShowDetail(ByVal cth_id As Guid, ByVal ma_loai_ct As String, ByVal ten_loai_ct As String, ByVal duong_dan As String, ByVal listCTHG As List(Of Extend.CT_H_GInfo), ByVal state As DataInputState)
        Try
            'If not form for show, return
            If duong_dan.Equals("") Then
                Message_Information("Không có form để hiển thị chi tiết !")
                Return
            End If

            Dim frm As Form = Nothing 'Form that contain method
            Dim method_show_form As MethodInfo = Nothing 'Method for invoke

            'Get list parameter form property duong_dan
            Dim dataInfo As FormDataInfo = DataMining.GetFormData(duong_dan)
            Dim form_name As String = dataInfo.FORMNAME
            Dim form_param_data As String = dataInfo.FORMDATA
            Dim listParam As List(Of ParamInfo) = DataMining.GetParams(form_param_data)

            'Array parameter for method
            Dim arrParam() As Object = New Object() {cth_id, listParam(0).PARAMVALUE, ten_loai_ct, listCTHG, state}

            'Create form from formName
            frm = SystemHelper.GetFormAssemblyDirect(form_name, Nothing, False, "")

            'Get method of form by methodName
            method_show_form = GetMethodByName(frm, "Show_Form")
            'Invoke method
            method_show_form.Invoke(frm, arrParam)
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    ''' <summary>
    ''' Get Current CTHG
    ''' </summary>
    ''' <param name="rowHandle"></param>
    ''' <param name="loai_ct_id"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function GetOneCTHG(ByVal rowHandle As Integer, ByVal loai_ct_id As String) As Extend.CT_H_GInfo
        Dim infoCTHG As New Extend.CT_H_GInfo()
        Dim rowData As DataRowView = CType(grvMain.GetRow(rowHandle), DataRowView)
        Dim cth_id As Guid = VnsConvert.CGuid(rowData("CthId").ToString)
        Dim id_loai_ct As Guid = VnsConvert.CGuid(rowData("IdLoaiCt").ToString)

        If id_loai_ct.Equals(loai_ct_id) Then
            Dim infoLoaiCT As HtLoaichungtu = _HtLoaichungtuService.GetById(id_loai_ct)
            Dim ngay_ghi As DateTime = DateTime.Now
            Dim ngay_ct As DateTime = DateTime.Now
            Dim ct_so As String = ""
            Dim so_tien As Decimal = 0
            Dim ghi As Decimal = 0
            Dim da_khoa_so As Decimal = 0

            Try
                ngay_ghi = DateTime.Parse(rowData("NgayGhi").ToString)
                ngay_ct = DateTime.Parse(rowData("NgayCt").ToString)
                ct_so = rowData("CtSo").ToString
                so_tien = Decimal.Parse(rowData("SoTien").ToString)
                ghi = Decimal.Parse(rowData("Ghi").ToString)
                da_khoa_so = Decimal.Parse(rowData("DaKhoaSo").ToString)
            Catch
            End Try

            infoCTHG.Id = VnsConvert.CGuid(cth_id)
            infoCTHG.MaLoaiCt = infoLoaiCT.MaLoaiCt
            infoCTHG.NgayGhi = ngay_ghi
            infoCTHG.CtSo = ct_so
            infoCTHG.NgayCt = ngay_ct
            infoCTHG.SoTien = so_tien
            infoCTHG.Ghi = ghi
            infoCTHG.DaKhoaSo = da_khoa_so

            Return infoCTHG
        Else
            Return Nothing
        End If
    End Function

    ''' <summary>
    ''' Get Current CTHG and Number of CTHG same type
    ''' </summary>
    ''' <param name="half"></param>
    ''' <param name="currentRowIndex"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function GetNumberCTHG(ByVal half As Integer, ByVal currentRowIndex As Integer) As List(Of Extend.CT_H_GInfo)
        Dim listCTHG As New List(Of Extend.CT_H_GInfo)
        Dim infoTemp As New Extend.CT_H_GInfo

        Dim _countLeft As Integer = 0
        Dim _countRight As Integer = 0
        Dim _maxLeft As Integer = half
        Dim _maxRight As Integer = half
        Dim _currentIndex As Integer = currentRowIndex

        Dim currentRowData As DataRowView = CType(grvMain.GetRow(_currentIndex), DataRowView)
        Dim currentLoaiCTID As String = currentRowData("ID_LOAI_CT").ToString

        Dim currentInfo As Extend.CT_H_GInfo = GetOneCTHG(_currentIndex, currentLoaiCTID)

        'Add CTHG of Left
        For i As Integer = _currentIndex - 1 To 0 Step -1
            infoTemp = GetOneCTHG(i, currentLoaiCTID)
            If Not infoTemp Is Nothing Then
                listCTHG.Add(infoTemp)
                _countLeft = _countLeft + 1
            End If
            If _countLeft = _maxLeft Then
                Exit For
            End If
        Next

        'Add Current
        listCTHG.Add(currentInfo)

        'Add CTHG of Right
        For j As Integer = _currentIndex + 1 To grvMain.RowCount - 1
            infoTemp = GetOneCTHG(j, currentLoaiCTID)
            If Not infoTemp Is Nothing Then
                listCTHG.Add(infoTemp)
                _countRight = _countRight + 1
            End If
            If _countRight = _maxRight Then
                Exit For
            End If
        Next

        Return listCTHG
    End Function

    ''' <summary>
    ''' Get All CTHG same type
    ''' </summary>
    ''' <param name="currentRowIndex"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function GetAllCTHG(ByVal currentRowIndex As Integer) As List(Of Extend.CT_H_GInfo)
        Dim listCTHG As New List(Of Extend.CT_H_GInfo)
        Dim infoTemp As New Extend.CT_H_GInfo

        Dim _currentIndex As Integer = currentRowIndex

        Dim currentRowData As DataRowView = CType(grvMain.GetRow(_currentIndex), DataRowView)
        Dim currentLoaiCTID As String = currentRowData("ID_LOAI_CT").ToString

        Dim currentInfo As Extend.CT_H_GInfo = GetOneCTHG(_currentIndex, currentLoaiCTID)

        'Add CTHG of Left
        For i As Integer = _currentIndex - 1 To 0 Step -1
            infoTemp = GetOneCTHG(i, currentLoaiCTID)
            If Not infoTemp Is Nothing Then
                listCTHG.Add(infoTemp)
            End If
        Next

        'Add Current
        listCTHG.Add(currentInfo)

        'Add CTHG of Right
        For j As Integer = _currentIndex + 1 To grvMain.RowCount - 1
            infoTemp = GetOneCTHG(j, currentLoaiCTID)
            If Not infoTemp Is Nothing Then
                listCTHG.Add(infoTemp)
            End If
        Next

        Return listCTHG
    End Function

    ''' <summary>
    ''' Get MethodInfo
    ''' </summary>
    ''' <param name="frmContainer"></param>
    ''' <param name="methodName"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    ''' 
    Private Function GetMethodByName(ByVal frmContainer As Form, ByVal methodName As String) As MethodInfo
        Try
            Dim type As Type = frmContainer.GetType()
            Dim methodReturn As MethodInfo = type.GetMethod(methodName)
            Return methodReturn
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    ''' <summary>
    ''' Format Grid
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub grvMain_RowCellStyle(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs) Handles grvMain.RowCellStyle
        Try
            Dim data_type As String = e.Column.ColumnType().Name
            If data_type.Equals("Decimal") Or data_type.Equals("Double") Or data_type.Equals("Single") Then
                e.Column.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                e.Column.DisplayFormat.FormatString = "n0"
                e.Column.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                e.Column.GroupFormat.FormatString = "##0,000.00"
            End If
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub
#End Region

#End Region


    Private Sub TreeDsBang_FocusedNodeChanged_1(ByVal sender As System.Object, ByVal e As DevExpress.XtraTreeList.FocusedNodeChangedEventArgs) Handles TreeDsBang.FocusedNodeChanged
        OBJ_INFO = CType(TreeDsBang.GetDataRecordByNode(e.Node), HtBaocao)
    End Sub
End Class