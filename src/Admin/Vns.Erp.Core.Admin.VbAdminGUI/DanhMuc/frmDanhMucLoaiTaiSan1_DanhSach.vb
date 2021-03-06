Imports System
Imports System.Data
Imports DevExpress.XtraTreeList
Imports DevExpress.XtraTreeList.Nodes
Imports System.Collections

Imports DevExpress.XtraTreeList.Columns
Imports DevExpress.XtraGrid
Imports System.Windows.Forms
Imports Vns.Erp.Core.Admin.Service.Interface
Imports Vns.Erp.Core.Admin.Domain

Public Class frmDanhMucLoaiTaiSan1_DanhSach
    Dim _DmLoaiTaisanService As IDmLoaitaisanService
    Public Overridable Property DmLoaiTaisanService() As IDmLoaitaisanService
        Get
            Return _DmLoaiTaisanService
        End Get
        Set(ByVal value As IDmLoaitaisanService)
            _DmLoaiTaisanService = value
        End Set
    End Property

    Dim _frmDanhMucLoaiTaiSan1_ChiTiet As frmDanhMucLoaiTaiSan1_ChiTiet
    Public Overridable Property FormChitiet() As frmDanhMucLoaiTaiSan1_ChiTiet
        Get
            Return _frmDanhMucLoaiTaiSan1_ChiTiet
        End Get
        Set(ByVal value As frmDanhMucLoaiTaiSan1_ChiTiet)
            _frmDanhMucLoaiTaiSan1_ChiTiet = value
        End Set
    End Property
#Region "Variables and Messages"
    Private DELAY_MESSAGE As Integer = 300
    Private DataSource As IList(Of DmLoaitaisan)
#End Region

#Region "Load Form"
    Public Sub New()
        InitializeComponent()
        TNCommon.setIconControl(Me)
    End Sub

#End Region

#Region "Private Function"

    Private Sub LoadDanhSach()
        Form_SetText(Me, "Danh mục loại tài sản", DataInputState.NoCaption)

        DataSource = DmLoaiTaisanService.GetAll()
        Dim ViewerColumnDefine As ArrayList = New ArrayList()
        ViewerColumnDefine.Add(New ColumnInfo("KyHieu", "Kí hiệu", 0, True, ""))
        ViewerColumnDefine.Add(New ColumnInfo("TenLoaitaisan", "Tên", 0, True, ""))
        ViewerColumnDefine.Add(New ColumnInfo("KhungTgsd", "Số năm sử dụng ", 0, True, ""))
        ViewerColumnDefine.Add(New ColumnInfo("CoSuDung", "Có sử dụng", 80, True, ""))
        TNCommon.BindData_TreeList(_TreeList, DataSource, "Id", "LoaitaisanIdCha", ViewerColumnDefine, True)

        _TreeList.DataSource = DataSource
        _TreeList.Columns("CoSuDung").ColumnEdit = TNCommon.COSUDUNG_ColumnEdit()
        Dim SearchHelperColumnDefine As ArrayList = New ArrayList()
        SearchHelperColumnDefine.Add(New ColumnInfo("MaLoaitaisan", "Mã loại tài sản", 0, True, ""))
        SearchHelperColumnDefine.Add(New ColumnInfo("KYHieu", "Kí hiệu", 0, True, ""))
        SearchHelperColumnDefine.Add(New ColumnInfo("TenLoaitaisan", "Tên loại tài sản", 0, True, ""))

        Dim FieldChooserColumnDefine As ArrayList = New ArrayList()
        FieldChooserColumnDefine.Add(New ColumnInfo("Caption", "Tên trường", 20, True, ""))

        TNCommon.BindData_GridLookUp(_SearchHelper, DataSource, (CType(SearchHelperColumnDefine(0), ColumnInfo)).FieldName, "Id", SearchHelperColumnDefine, True, False)
        TNCommon.BindData_GridLookUp(_FieldChooser, SearchHelperColumnDefine, "Caption", "FieldName", FieldChooserColumnDefine, False, True)
        'SetFormat()
    End Sub

    Private Sub SetKeyValue(ByVal value As Object)
        If value Is Nothing Then
            Return
        End If

        TNCommon.TreeList_SetNodeFocus(_TreeList, value)
    End Sub

    Private Function GetKeyValue() As Object
        Dim _Value As Object = Nothing
        _Value = TNCommon.TreeList_FocusKeyValue(_TreeList)
        Return _Value
    End Function

    Private Sub Deleting()
        Try
            DmLoaiTaisanService.DeleteById(GetKeyValue)
            AfterDeleteSuccess()
        Catch ex As System.Exception
            TNCommon.NotifyError(ex)
        End Try
    End Sub

    Private Sub AfterDeleteSuccess()
        frmProgress.Instance().SetFinishText(GeneralString.DELETE_SUCCESSFUL, DELAY_MESSAGE)
    End Sub

    Private Sub DoModify()
        Dim eID As String = GetKeyValue.ToString()
        'Try
        Dim f As frmDanhMucLoaiTaiSan1_ChiTiet = FormChitiet
        Dim ID As Guid = f.Show_Form(eID, DataInputState.EditMode)
        If (f.ID <> Guid.Empty) Then
            DoRefressData()
            SetKeyValue(ID)
        End If
        'Catch ex As Exception
        '    Message_Error(ex)
        'End Try
    End Sub

    Public Sub DoRefressData()
        frmProgress.Instance().Thread = AddressOf Me.LoadDanhSach
        frmProgress.Instance().Show_Progress(GeneralString.REFRESHING, GeneralString.COMPLETE)
    End Sub

    Private Sub DoCreate()
        'Try
        Dim f As frmDanhMucLoaiTaiSan1_ChiTiet = FormChitiet
        Dim ID As Guid = f.Show_Form(Nothing, DataInputState.AddMode)
        DoRefressData()
        SetKeyValue(ID)
        'Catch ex As Exception
        '    Message_Error(ex)
        'End Try
    End Sub

    'Private Sub DoDelete()
    '    'Try
    '    If GetKeyValue() Is Nothing Then
    '        NotifyNoSelectRecord()
    '        Return
    '    End If
    '    If (Message_Confirm("Bạn có chắc chắn muốn xóa bản ghi này?")) Then
    '        frmProgress.Instance().Thread = AddressOf Me.Deleting
    '        'frmProgress.Instance().Show_Progress("Đang xóa...")
    '        frmProgress.Instance().SetFinishText(GeneralString.DELETE_SUCCESSFUL, DELAY_MESSAGE)
    '        LoadDanhSach()
    '    End If
    '    'Catch ex As System.Exception
    '    '    TNCommon.NotifyError(ex)
    '    'End Try
    'End Sub

#End Region

#Region "Events"
    Private Sub btnModify_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModify.Click
        Try
            DoModify()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub _FieldChooser_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _FieldChooser.EditValueChanged
        Try
            If _FieldChooser.EditValue IsNot Nothing Then
                _SearchHelper.Properties.DisplayMember = _FieldChooser.EditValue.ToString()
                _SearchHelper.Focus()
            End If
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub _SearchHelper_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _SearchHelper.EditValueChanged
        Try
            If _SearchHelper.EditValue IsNot Nothing Then
                SetKeyValue(_SearchHelper.EditValue)
            End If
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub btnCreate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCreate.Click
        Try
            DoCreate()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Try
            Me.Close()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

   

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        Try
            Dim data As New DataTable
            data = CType(DataSource, DataTable)
            'Dim i_n As New frmInDanhMuc(data, "DM_TUDO1")
            'i_n.ShowDialog()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub frmDanhMucLoaiTaiSan1_DanhSach_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            LoadDanhSach()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub frmDanhMucLoaiTaiSan1_DanhSach_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Try
            Select Case e.KeyCode
                Case FormGlobals.ExitKey
                    Me.Close()
                    Exit Select
                Case FormGlobals.AddNewKey
                    DoCreate()
                    Exit Select
                Case FormGlobals.EditKey
                    DoModify()
                    Exit Select
                Case Keys.F8
                    If Message_Confirm("Bạn có chắc chắn muốn xóa dữ liệu này?") Then
                        Deleting()
                        LoadDanhSach()
                    End If
                    Exit Select
            End Select
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub
#End Region

#Region "Notify"
    Public Function ConfirmDelete() As Boolean
        Return (DialogResult.Yes = MessageBox.Show(GeneralString.CONFIRM_DELETE_MESSAGE, GeneralString.CONFIRM_DELETE_CAPTION, MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
    End Function
    Public Sub NotifyNoSelectRecord()
        MessageBox.Show(GeneralString.NOTIFY_NO_SELECT_RECORD_MESSAGE, GeneralString.NOTIFY_NO_SELECT_RECORD_CAPTION, MessageBoxButtons.OK, MessageBoxIcon.Warning)
    End Sub
#End Region


    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Try
            If Message_Confirm("Bạn có chắc chắn muốn xóa dữ liệu này?") Then
                Deleting()
                ' DoDelete()

                LoadDanhSach()
            End If
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub
End Class
