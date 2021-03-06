Imports Microsoft.VisualBasic
Imports System
Imports System.Data
Imports DevExpress.XtraTreeList
Imports DevExpress.XtraTreeList.Nodes
Imports System.Collections
Imports DevExpress.XtraTreeList.Columns
Imports DevExpress.XtraGrid
Imports System.Windows.Forms
Imports Vns.Erp.Core.Admin.Domain
Imports Vns.Erp.Core.Admin.Service.Interface

Partial Public Class frmDanhMucTuDo1_DanhSach
    Inherits FrmBaseDmDanhSach

#Region "Variables and Messages"
    Dim _DmTudo1Service As IDmTudo1Service
    Public Property DmTudo1Service() As IDmTudo1Service
        Get
            Return _DmTudo1Service
        End Get
        Set(ByVal value As IDmTudo1Service)
            _DmTudo1Service = value
        End Set
    End Property

    'Private _FormChiTiet As FrmBaseDmChiTiet
    'Public Overrides Property FormChiTiet() As FrmBaseDmChiTiet
    '    Get
    '        If _FormChiTiet Is Nothing Then
    '            _FormChiTiet = New frmDanhMucTuDo1_ChiTiet()
    '        End If
    '        Return _FormChiTiet
    '    End Get
    '    Set(ByVal value As FrmBaseDmChiTiet)
    '        _FormChiTiet = value
    '    End Set
    'End Property

    Private _DataSource As IList(Of DmTudo1)
    Public Property DataSource() As IList(Of DmTudo1)
        Get
            Return _DataSource
        End Get
        Set(ByVal value As IList(Of DmTudo1))
            _DataSource = value
        End Set
    End Property
#End Region

#Region "Load Form"
    Public Overrides Sub InitProperty()
        'Form_SetText(Me, Generals.TS_TuDo1.GIA_TRI, DataInputState.NoCaption)

        'Ki?u hi?n th? là TreeList ho?c GridView
        Title = "Danh mục tự do 1"
        Viewer = _TreeList

        'Áp d?ng d?i v?i TreeList
        KeyName = "Id"
        ParentKeyName = "DmTudo1IdCha"

        ViewerColumnDefine = New ArrayList()
        ViewerColumnDefine.Add(New ColumnInfo("KyHieu", "Kí hiệu", 100, True, ""))
        ViewerColumnDefine.Add(New ColumnInfo("TenDmTudo1", "Tên", 0, True, ""))
        ViewerColumnDefine.Add(New ColumnInfo("MoTa", "Mô tả", 0, True, ""))
        ViewerColumnDefine.Add(New ColumnInfo("CoSuDung", "Có sử dụng", 80, True, ""))
        ViewerColumnDefine.Add(New ColumnInfo("Cap", "Level", 0, True, ""))


        SearchHelperColumnDefine = New ArrayList()
        SearchHelperColumnDefine.Add(New ColumnInfo("TenDmTudo1", "Tên", 0, True, ""))
        SearchHelperColumnDefine.Add(New ColumnInfo("KyHieu", "Kí hiệu", 0, True, ""))
        SearchHelperColumnDefine.Add(New ColumnInfo("MoTa", "Mô tả", 0, True, ""))

        FieldChooserColumnDefine = New ArrayList()
        FieldChooserColumnDefine.Add(New ColumnInfo("Caption", "Tên trường", 20, True, ""))


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
            DataSource = _DmTudo1Service.GetAllByDonviID(Generals.DonviID)
            TNCommon.BindData_TreeList(Viewer, DataSource, KeyName, ParentKeyName, ViewerColumnDefine, True)
            TNCommon.BindData_GridLookUp(SearchHelper, DataSource, (CType(SearchHelperColumnDefine(0), ColumnInfo)).FieldName, KeyName, SearchHelperColumnDefine, True, False)
            TNCommon.BindData_GridLookUp(FieldChooser, SearchHelperColumnDefine, "Caption", "FieldName", FieldChooserColumnDefine, True, True)

            _TreeList.Columns("CoSuDung").ColumnEdit = TNCommon.COSUDUNG_ColumnEdit()
            FieldChooser.EditValue = (CType(SearchHelperColumnDefine(0), ColumnInfo)).FieldName

            SetFormat()
            btExport.GRID_VIEW = _TreeList
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub
#End Region

#Region "Construction"
    Public Sub New()
        InitializeComponent()
    End Sub
#End Region

#Region "Private Function"
    Private Sub SetFormat()
        Dim cols As TreeListColumnCollection = _TreeList.Columns
        Dim colLevel As TreeListColumn = cols("Cap")
        colLevel.OptionsColumn.AllowEdit = True
        colLevel.OptionsColumn.ReadOnly = False
        colLevel.Visible = True

        Dim f1 As StyleFormatConditions.StyleFormatCondition = _TreeList.FormatConditions(0)
        f1.Condition = FormatConditionEnum.Equal
        f1.Value1 = "0"
        f1.ApplyToRow = True
        Dim f2 As StyleFormatConditions.StyleFormatCondition = _TreeList.FormatConditions(1)
        f2.Condition = FormatConditionEnum.Equal
        f2.Value1 = "1"
        f2.ApplyToRow = True

        _TreeList.BeginUnboundLoad()
        For Each gpNode As TreeListNode In _TreeList.Nodes
            gpNode.SetValue(0, gpNode.Level.ToString)
            For Each pNode As TreeListNode In gpNode.Nodes
                pNode.SetValue(0, pNode.Level.ToString)
            Next
        Next
        _TreeList.EndUnboundLoad()

        f1.Column = colLevel
        f2.Column = colLevel
        colLevel.Visible = False
    End Sub
#End Region

#Region "Events"
    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        'Try
        '    Dim data As New DataTable
        '    data = CType(DataSource, DataTable)
        '    Dim i_n As New frmInDanhMuc(data, "DM_TUDO1")
        '    i_n.ShowDialog()
        'Catch ex As Exception
        '    Message_Error(ex)
        'End Try
    End Sub
#End Region
#Region "Override"
    Public Overrides Sub DoCreate()
        Dim obj As Object = ShowFormChiTiet(FormGlobals.DataInputState.AddMode)
        If obj IsNot Nothing Then
            'Dim NewObj As Object = DmTudo1Service.GetById(obj)
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
            'Dim NewObj As Object = DmTudo1Service.GetById(obj)
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
            DmTudo1Service.DeleteById(KeyValue)
            AfterDeleteSuccess()
        Catch ex As System.Exception
            TNCommon.NotifyError(ex)
        End Try
    End Sub
#End Region
End Class
