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
Imports DevExpress.XtraTreeList
Imports Vns.Erp.Core.Admin.Domain
Imports Vns.Erp.Core.Admin.Service.Interface
Imports Vns.Erp.Core.Common.Controls


Partial Public Class frmDanhMucHangHoa_DanhSach
    Inherits FrmBaseDmDanhSach

#Region "Variables and Messages"
    Dim _DmHanghoaService As IDmHanghoaService


    Dim _DmDvtService As IDmDvtService
    Public Property DmDvtService() As IDmDvtService
        Get
            Return _DmDvtService
        End Get
        Set(ByVal value As IDmDvtService)
            _DmDvtService = value
        End Set
    End Property
    Public Property DmHanghoaService() As IDmHanghoaService
        Get
            Return _DmHanghoaService
        End Get
        Set(ByVal value As IDmHanghoaService)
            _DmHanghoaService = value
        End Set
    End Property

    Private _DataSource As Object

    Public Property DataSource() As IList(Of DmHanghoa)
        Get
            Return _DataSource
        End Get
        Set(ByVal value As IList(Of DmHanghoa))
            _DataSource = value
        End Set
    End Property

    Private _FormChiTiet As FrmBaseDmChiTiet
    Public Overrides Property FormChiTiet() As FrmBaseDmChiTiet
        Get
            If _FormChiTiet Is Nothing Then
                _FormChiTiet = New frmDanhMucHangHoa_ChiTiet()
            End If
            Return _FormChiTiet
        End Get
        Set(ByVal value As FrmBaseDmChiTiet)
            _FormChiTiet = value
        End Set
    End Property
#End Region

#Region "Construction"
    Public Sub New()
        InitializeComponent()
    End Sub
#End Region

#Region "Load Form"
    Public Overrides Sub InitProperty()
        Title = "Danh mục vật tư/hàng hóa"
        Viewer = _GridView

        KeyName = "Id"
        'ParentKeyName = "HanghoaIdCha"

        ViewerColumnDefine = New ArrayList()
        ViewerColumnDefine.Add(New ColumnInfo("MaHanghoa", "Mã hàng", 130, True, ""))
        ViewerColumnDefine.Add(New ColumnInfo("KyHieu", "Tên viết tắt", 130, True, ""))
        ViewerColumnDefine.Add(New ColumnInfo("TenHanghoa", "Tên", 250, True, ""))
        ViewerColumnDefine.Add(New ColumnInfo("NuocSanxuat", "Nước sản xuất", 120, True, ""))
        ViewerColumnDefine.Add(New ColumnInfo("NamSanxuat", "Năm sản xuất", 120, True, ""))
        ViewerColumnDefine.Add(New ColumnInfo("TenDvt", "Đơn vị tính", 150, True, ""))
        ViewerColumnDefine.Add(New ColumnInfo("TenPpHtk", "Phương pháp tính giá hàng tồn kho", 250, True, ""))
        ViewerColumnDefine.Add(New ColumnInfo("MdTkKho", "Tài khoản kho mặc định", 150, True, ""))
        ViewerColumnDefine.Add(New ColumnInfo("CoSuDung", "Có sử dụng", 100, True, ""))

        'Đ?nh nghia danh sách tru?ng cho phép t́m ki?m t́m ki?m
        SearchHelperColumnDefine = New ArrayList()
        SearchHelperColumnDefine.Add(New ColumnInfo("TenHanghoa", "Tên", 0, True, ""))
        SearchHelperColumnDefine.Add(New ColumnInfo("KyHieu", "Ký hiệu", 0, True, ""))
        SearchHelperColumnDefine.Add(New ColumnInfo("NuocSanxuat", "Nước sản xuất", 0, True, ""))
        SearchHelperColumnDefine.Add(New ColumnInfo("NamSanxuat", "Năm sản xuất", 0, True, ""))

        ButtonCreate = btnCreate
        ButtonModify = btnModify
        ButtonDelete = btnDelete

        'Đ?nh nghia danh sách tru?ng cho phép t́m ki?m t́m ki?m
        FieldChooserColumnDefine = New ArrayList()
        FieldChooserColumnDefine.Add(New ColumnInfo("Caption", "Tên trường", 0, True, ""))
        CtPagerControl.display = New PagerControl.DisplayResult(AddressOf Loading)

        FieldChooser = _FieldChooser
        SearchHelper = _SearchHelper
    End Sub
#End Region

#Region "Modify here"
    Public Overrides Sub Loading()
        'Try
        'truyen para frm
        Dim para_str As String = Me.AccessibleDescription
        Dim lst_para As List(Of ParamInfo) = DataMining.GetParams(para_str)

        'Filter default by LoaiKhang, Nothing return All
        Dim LoaiHangHoa = -1
        If (lst_para.Count > 0) Then
            If (String.IsNullOrEmpty(lst_para(0).PARAMVALUE)) Then
                LoaiHangHoa = -1
            Else
                Decimal.TryParse(lst_para(0).PARAMVALUE, LoaiHangHoa)
            End If
        End If

        DataSource = DmHanghoaService().GetAllByDonviID(CtPagerControl.PageIndex, CtPagerControl.PageSize, Generals.DON_VI.Id, LoaiHangHoa, CtPagerControl.TotalResult)
        CtPagerControl.RefreshPage()
        TNCommon.BindData_GridView(Viewer, DataSource, ViewerColumnDefine)
        'Dim obj As TreeList = TryCast(Viewer, TreeList)
        _GridView.Columns("CoSuDung").ColumnEdit = TNCommon.COSUDUNG_ColumnEdit()

        TNCommon.BindData_GridLookUp(SearchHelper, DataSource, (CType(SearchHelperColumnDefine(0), ColumnInfo)).FieldName, KeyName, SearchHelperColumnDefine, True, False)
        TNCommon.BindData_GridLookUp(FieldChooser, SearchHelperColumnDefine, "Caption", "FieldName", FieldChooserColumnDefine, True, True)
        'Catch ex As Exception
        '    TNCommon.NotifyError(ex)
        'End Try

    End Sub
#End Region

#Region "Private Function"

#End Region

#Region "Events"
    Private Sub btnIn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        Try
            Dim data As New DataTable
            data = CType(DataSource, DataTable)
            'Dim i_n As New frmInDanhMuc(data, "DM_HANGHOA")
            'i_n.ShowDialog()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub btnClose_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnClose.Click
        Try
            Me.Close()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub
#End Region
#Region "Override"
    Public Overrides Sub DoCreate()
        Dim obj As Object = ShowFormChiTiet(FormGlobals.DataInputState.AddMode)
        If obj IsNot Nothing Then
            Dim NewObj As Object = _FormChiTiet.GetEditObject()
            DoRefressData(FormGlobals.DataInputState.AddMode, Nothing, NewObj)
            Me.KeyValue = obj
        End If
    End Sub

    Public Overrides Sub DoModify()
        If Me.KeyValue Is Nothing Then
            NotifyNoSelectRecord()
            Return
        End If
        Dim OldObj As Object = GetObjectValue()
        Dim obj As Object = ShowFormChiTiet(FormGlobals.DataInputState.EditMode)
        If obj IsNot Nothing Then
            'Dim NewObj As Object = DmHanghoaService.GetById(obj)
            DoRefressData(FormGlobals.DataInputState.EditMode, OldObj, obj)
            Me.KeyValue = obj
        End If
    End Sub

    Public Overrides Sub DoRefressData(ByVal _mode As FormGlobals.DataInputState, ByVal OldObj As Object, ByVal NewObj As Object)
        frmProgress.Instance().Thread = AddressOf Me.Loading
        frmProgress.Instance().Show_Progress(GeneralString.REFRESHING, GeneralString.COMPLETE)
        Select Case _mode
            Case DataInputState.AddMode
                'DataSource.Add(NewObj)
            Case DataInputState.EditMode
                'DataSource.Remove(OldObj)
                'DataSource.Add(NewObj)
            Case DataInputState.Delete
                'DataSource.Remove(OldObj)
        End Select
        TNCommon.BindData4Refresh(Viewer, DataSource)
    End Sub
    Public Overloads Overrides Sub Deleting()
        Try
            DmHanghoaService.DeleteById(KeyValue)
            AfterDeleteSuccess()
        Catch ex As System.Exception
            TNCommon.NotifyError(ex)
        End Try
    End Sub
#End Region

    Private Sub btnImport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImport.Click
        Dim frm As OpenFileDialog = New OpenFileDialog()
        frm.ShowDialog()

        If (Not String.IsNullOrEmpty(frm.FileName)) Then
            Dim dt As DataTable = NPOIExcelHelper.ReadDicFile(frm.FileName)

            Dim lstHh As List(Of DmHanghoa) = New List(Of DmHanghoa)
            Dim lstdvt As List(Of DmDvt) = _DmDvtService.GetAllByDonviID(Generals.DON_VI.Id)

            If (Message_Confirm("Bạn có muốn xóa dữ liệu cũ?", False) = True) Then
                _DmHanghoaService.DeleteAllByDonviId(Generals.DON_VI.Id)
            End If


            For Each dr As DataRow In dt.Rows
                Dim tmp As DmHanghoa = New DmHanghoa(dr)
                tmp.DonviId = Generals.DON_VI.Id
                tmp.MaDonvi = Generals.DON_VI.MaDonvi

                Dim tmpdvt As DmDvt = New DmDvt()
                tmpdvt = GetDvtByMa(lstdvt, tmp.MaDvt)

                If (tmpdvt IsNot Nothing) Then
                    tmp.DvtId = tmpdvt.Id
                    tmp.MaDvt = tmpdvt.MaDvt
                    tmp.TenDvt = tmpdvt.TenDvt
                Else
                    tmp.DvtId = New Guid()
                    tmp.MaDvt = ""
                    tmp.TenDvt = ""
                End If

                lstHh.Add(tmp)
            Next

            Dim macu As String = "ZZZ"
            Dim idcu As Guid = New Guid()
            For Each hh As DmHanghoa In lstHh
                If (hh.MaHanghoa.Length > macu.Length And
                    hh.MaHanghoa.StartsWith(macu)) Then
                    hh.HanghoaIdCha = idcu
                Else
                    hh.HanghoaIdCha = New Guid()
                    hh.Id = Guid.NewGuid()
                    macu = hh.MaHanghoa
                    idcu = hh.Id
                End If
            Next


            Dim lstOld As List(Of DmHanghoa) = _DmHanghoaService.GetAllByDonviID(Generals.DON_VI.Id)
            For Each hh As DmHanghoa In lstHh

                Dim flg_exist As Boolean = False
                For Each old As DmHanghoa In lstOld
                    If old.MaHanghoa.Trim() = hh.MaHanghoa.Trim() Then
                        flg_exist = True
                        Exit For
                    End If
                Next

                If Not flg_exist Then
                    _DmHanghoaService.Merge(hh)
                End If
            Next

        End If

        DoRefressData(DataInputState.ViewMode, Nothing, Nothing)
    End Sub

    Private Function GetDvtByMa(ByVal lst As List(Of DmDvt), ByVal Madvt As String) As DmDvt
        For Each tmpdvt As DmDvt In lst
            If Madvt.ToUpper() = tmpdvt.MaDvt.ToUpper() Or Madvt.ToUpper() = tmpdvt.KyHieu.ToUpper() Then
                Return tmpdvt
            End If
        Next

        If (lst IsNot Nothing Or lst.Count > 0) Then
            Return lst(0)
        Else
            Return Nothing
        End If
    End Function
End Class
