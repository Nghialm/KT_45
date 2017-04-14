Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports DevExpress.XtraTreeList
Imports DevExpress.XtraTreeList.Nodes
Imports System.Collections
Imports DevExpress.XtraGrid
Imports DevExpress.XtraTreeList.Columns
Imports Vns.Erp.Core.Admin.Domain
Imports Vns.Erp.Core.Admin.Service.Interface

Partial Public Class frmDanhMucDonViTinh_DanhSach
    Inherits FrmBaseDmDanhSach

#Region "Variables and Messages"
    Dim _DmDvtService As IDmDvtService
    Public Property DmDvtService() As IDmDvtService

        Get
            Return _DmDvtService
        End Get
        Set(ByVal value As IDmDvtService)
            _DmDvtService = value
        End Set
    End Property
    Private _DataSource As Object
    Public Property DataSource() As IList(Of DmDvt)
        Get
            Return _DataSource
        End Get
        Set(ByVal value As IList(Of DmDvt))
            _DataSource = value
        End Set
    End Property
#End Region

#Region "Load Form"
    Public Overrides Sub InitProperty()
        'Tiêu d? form
        Title = "Danh mục đơn vị tính "

        'Ki?u hi?n th? là TreeList ho?c GridView
        Viewer = _GridView

        'Áp d?ng d?i v?i TreeList
        KeyName = "Id"
        'ParentKeyName = "DM_TUDO_2_ID_CHA";

        'Ð?nh nghia các c?t c?a lu?i hi?n th?
        ViewerColumnDefine = New ArrayList()
        ViewerColumnDefine.Add(New ColumnInfo("MaDvt", "Mã đơn vị", 0, True, ""))
        ViewerColumnDefine.Add(New ColumnInfo("TenDvt", "Tên đơn vị tính", 0, True, ""))
        ViewerColumnDefine.Add(New ColumnInfo("KyHieu", "Kí hiệu", 0, True, ""))
        ViewerColumnDefine.Add(New ColumnInfo("MoTa", "Mô tả", 0, True, ""))
        'ViewerColumnDefine.Add(new ColumnInfo("CHO_PHEP_SUA",           "Cho phép s?a", 0, true, ""));
        ViewerColumnDefine.Add(New ColumnInfo("CoSuDung", "Có sử dụng", 0, True, ""))


        'Ð?nh nghia danh sách tru?ng cho phép tìm ki?m tìm ki?m
        SearchHelperColumnDefine = New ArrayList()
        SearchHelperColumnDefine.Add(New ColumnInfo("MaDvt", "Mã đơn vị", 0, True, ""))
        SearchHelperColumnDefine.Add(New ColumnInfo("KyHieu", "Kí hiệu", 0, True, ""))
        SearchHelperColumnDefine.Add(New ColumnInfo("TenDvt", "Tên đơn vị tính", 0, True, ""))


        'Ð?nh nghia danh sách tru?ng cho phép tìm ki?m tìm ki?m
        FieldChooserColumnDefine = New ArrayList()
        FieldChooserColumnDefine.Add(New ColumnInfo("Caption", "Tên trường", 0, True, ""))

        '----------------------------------------------
        ButtonCreate = btnCreate
        ButtonModify = btnModify
        ButtonDelete = btnDelete
        'ButtonSearch = btnSearch
        'ButtonView = btnView
        'Pagger = _Pagger

        FieldChooser = _FieldChooser
        SearchHelper = _SearchHelper
    End Sub

    Public Overrides Sub Loading()
        Try
            DataSource = DmDvtService.GetAllByDonviID(Generals.DonviID)
            TNCommon.BindData_GridView(Viewer, DataSource, ViewerColumnDefine)
            _GridView.Columns("CoSuDung").ColumnEdit = TNCommon.COSUDUNG_ColumnEdit()

            TNCommon.BindData_GridLookUp(SearchHelper, DataSource, (CType(SearchHelperColumnDefine(0), ColumnInfo)).FieldName, KeyName, SearchHelperColumnDefine, True, False)
            TNCommon.BindData_GridLookUp(FieldChooser, SearchHelperColumnDefine, "Caption", "FieldName", FieldChooserColumnDefine, True, True)
            FieldChooser.EditValue = (CType(SearchHelperColumnDefine(0), ColumnInfo)).FieldName

            'TNCommon.BindData_TreeList(Viewer, DataSource, KeyName, ParentKeyName, ViewerColumnDefine, true);
            'TNCommon.BindData_GridLookUp(SearchHelper, DataSource, ((ColumnInfo)SearchHelperColumnDefine[0]).FieldName, KeyName, SearchHelperColumnDefine, true,false);
            'TNCommon.BindData_GridLookUp(FieldChooser, SearchHelperColumnDefine, "Caption", "FieldName", FieldChooserColumnDefine, true,true);
            'FieldChooser.EditValue  = ((ColumnInfo)SearchHelperColumnDefine[0]).FieldName;
        Catch ex As Exception
            TNCommon.NotifyError(ex)
        End Try
    End Sub
#End Region

#Region "Construction"
    Public Sub New()
        InitializeComponent()
    End Sub
#End Region

#Region "Override"
    Public Overrides Sub DoCreate()
        Dim obj As Object = ShowFormChiTiet(FormGlobals.DataInputState.AddMode)
        If obj IsNot Nothing Then
            'Dim NewObj As Object = DmDvtService.GetById(obj)
            DoRefressData(FormGlobals.DataInputState.AddMode, Nothing, obj)
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
            'Dim NewObj As Object = DmDvtService.GetById(obj)
            DoRefressData(FormGlobals.DataInputState.EditMode, OldObj, obj)
            Me.KeyValue = obj
        End If
    End Sub

    Public Overrides Sub DoRefressData(ByVal _mode As FormGlobals.DataInputState, ByVal OldObj As Object, ByVal NewObj As Object)
        frmProgress.Instance().Thread = AddressOf Me.Loading
        frmProgress.Instance().Show_Progress(GeneralString.REFRESHING, GeneralString.COMPLETE)
        'Select Case _mode
        '    Case DataInputState.AddMode
        '        'DataSource.Add(NewObj)
        '    Case DataInputState.EditMode
        '        DataSource.Remove(OldObj)
        '        DataSource.Add(NewObj)
        '    Case DataInputState.Delete
        '        DataSource.Remove(OldObj)
        'End Select
        TNCommon.BindData4Refresh(Viewer, DataSource)
    End Sub
    Public Overloads Overrides Sub Deleting()
        Try
            DmDvtService.DeleteById(KeyValue)
            AfterDeleteSuccess()
        Catch ex As System.Exception
            TNCommon.NotifyError(ex)
        End Try
    End Sub
#End Region

#Region "Events"
    Private Sub btnClose_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
#End Region

    Private Sub btnImport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImport.Click
        Dim frm As OpenFileDialog = New OpenFileDialog()
        frm.ShowDialog()

        If (Not String.IsNullOrEmpty(frm.FileName)) Then
            Dim dt As DataTable = NPOIExcelHelper.ReadDicFile(frm.FileName)

            Dim lstNew As List(Of DmDvt) = New List(Of DmDvt)
            Dim lstOld As List(Of DmDvt) = _DmDvtService.GetAllByDonviID(Generals.DON_VI.Id)

            For Each dr As DataRow In dt.Rows
                Dim tmp As DmDvt = New DmDvt(dr)
                tmp.DonviId = Generals.DON_VI.Id

                lstNew.Add(tmp)
            Next

            For Each objnew As DmDvt In lstNew
                Dim flg_exist As Boolean = False
                For Each objold As DmDvt In lstOld
                    If objnew.MaDvt = objold.MaDvt Then
                        flg_exist = True
                        Exit For
                    End If
                Next

                If Not flg_exist Then
                    _DmDvtService.Save(objnew)
                End If
            Next

        End If
    End Sub
End Class
