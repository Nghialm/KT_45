Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports DevExpress.XtraEditors
Imports System.Windows.Forms
Imports System.Collections
Imports DevExpress.XtraTreeList
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Grid
Imports System


Public  Class FrmBaseDmDanhSach
    Inherits XtraForm
    Public Shared DELAY_MESSAGE As Integer = 300
    Dim T As Type
    Dim idT As Type
#Region "Overidable"
    Public Overridable Sub InitComponent()
    End Sub
    Public Overridable Sub InitProperty()
    End Sub
    Public Overridable Sub Loading()
    End Sub
    Public Overridable Sub DoLoadData()
        Loading()

    End Sub

    Public Overridable Sub DoRefressData(ByVal _mode As FormGlobals.DataInputState, ByVal OldObj As Object, ByVal NewObj As Object)
    End Sub
    Public Overridable Sub DoCreate()
    End Sub
    Public Overridable Sub DoModify()
    End Sub

    Public Overridable Sub DoExport()
    End Sub

    Public Overridable Sub DoImport()
    End Sub

    Public Overridable Sub DoDelete()
        Try
            If Me.KeyValue Is Nothing Then
                NotifyNoSelectRecord()
                Return
            End If
            If Not ConfirmDelete() Then
                Return
            End If
            Dim OldObj As Object = GetObjectValue()
            frmProgress.Instance().Thread = AddressOf Me.Deleting
            frmProgress.Instance().Show_Progress(GeneralString.DELETING)
            frmProgress.Instance().SetFinishText(GeneralString.DELETE_SUCCESSFUL, DELAY_MESSAGE)
            DoRefressData(FormGlobals.DataInputState.Delete, OldObj, Nothing)
        Catch ex As System.Exception
            TNCommon.NotifyError(ex)
        End Try
    End Sub

    Public Overridable Property FormChiTiet() As FrmBaseDmChiTiet
        Get
            Return m_FormChiTiet
        End Get
        Set(ByVal value As FrmBaseDmChiTiet)
            m_FormChiTiet = value
        End Set
    End Property
    Private m_FormChiTiet As FrmBaseDmChiTiet
    Public Overridable Sub CommonInit()
        If Me.ButtonCreate Is Nothing Then
            Return
        End If

        InitTile()

        Me.KeyPreview = True
        AddHandler Me.KeyDown, AddressOf CommonInit_KeyDownEventProcess
        AddHandler Me.ButtonCreate.Click, AddressOf ButtonCreate_Click
        AddHandler Me.ButtonModify.Click, AddressOf ButtonModify_Click
        If Not (ButtonDelete Is Nothing) Then
            AddHandler Me.ButtonDelete.Click, AddressOf ButtonDelete_Click
        End If

        AddHandler Me.SearchHelper.EditValueChanged, AddressOf SearchHelper_EditValueChanged
        AddHandler Me.FieldChooser.EditValueChanged, AddressOf FieldChooser_EditValueChanged
        SearchHelper.Properties.ValueMember = KeyName
        'Insert Image to button
        TNCommon.setIconControl(Me)
        DoLoadData()
        ' mdlAdmin.SetUserRole(this);
    End Sub
#End Region

    Public Sub InitTile()
        Me.Text = Title + GeneralString.LIST
    End Sub

#Region "Notify"

    'Private _BO As Vns.Erp.Core.Service.Interface.IErpService(Of T, IdT)
    Public Function ConfirmDelete() As Boolean
        Return (DialogResult.Yes = MessageBox.Show(GeneralString.CONFIRM_DELETE_MESSAGE, GeneralString.CONFIRM_DELETE_CAPTION, MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
    End Function

    Public Sub NotifyNoSelectRecord()
        MessageBox.Show(GeneralString.NOTIFY_NO_SELECT_RECORD_MESSAGE, GeneralString.NOTIFY_NO_SELECT_RECORD_CAPTION, MessageBoxButtons.OK, MessageBoxIcon.Warning)
    End Sub
#End Region

#Region "Action"

    Public Function ShowFormChiTiet(ByVal mode As FormGlobals.DataInputState) As Object
        Dim form As XtraForm = TryCast(Me.FormChiTiet, XtraForm)
        'Me.DialogResult = DialogResult.Cancel

        If (mode = DataInputState.EditMode) Then
            Me.FormChiTiet.ID = Me.KeyValue
        Else
            Me.FormChiTiet.ID = Nothing
        End If

        Me.FormChiTiet.Mode = mode

        FormChiTiet.InitTile()
        FormChiTiet.DoClear()
        'Me.FormChiTiet.Loading()
        If form.ShowDialog() <> DialogResult.OK Then
            Return Nothing
        Else
            Return Me.FormChiTiet.GetEditObject()
        End If
    End Function
    Public Function QuickAddObject() As Object
        Return ShowFormChiTiet(FormGlobals.DataInputState.AddMode)
    End Function



    Public Sub DoSearch()
        DoLoadData()
    End Sub

    Public Overridable Sub Deleting()

    End Sub

    Public Shared Sub AfterDeleteSuccess()
        frmProgress.Instance().SetFinishText(GeneralString.DELETE_SUCCESSFUL, DELAY_MESSAGE)
    End Sub

#End Region

#Region "Property"
    Private _Pagger As ControlNavigator

    Public Property Pagger() As ControlNavigator
        Get
            Return _Pagger
        End Get
        Set(ByVal value As ControlNavigator)
            _Pagger = value
        End Set
    End Property


    Private _SearchHelperColumnDefine As ArrayList
    Public Property SearchHelperColumnDefine() As ArrayList
        Get
            Return _SearchHelperColumnDefine
        End Get
        Set(ByVal value As ArrayList)
            _SearchHelperColumnDefine = value
        End Set
    End Property

    Private _SearchHelper As GridLookUpEdit
    Public Property SearchHelper() As GridLookUpEdit
        Get
            Return _SearchHelper
        End Get
        Set(ByVal value As GridLookUpEdit)
            _SearchHelper = value
        End Set
    End Property

    Private _FieldChooser As GridLookUpEdit
    Public Property FieldChooser() As GridLookUpEdit
        Get
            Return _FieldChooser
        End Get
        Set(ByVal value As GridLookUpEdit)
            _FieldChooser = value
        End Set
    End Property

    Public Sub SetKeyValue(ByVal value As Object)
        If value Is Nothing Then
            Return
        End If

        If TypeOf Me.Viewer Is TreeList Then
            TNCommon.TreeList_SetNodeFocus(Viewer, value)
        End If

        If TypeOf Me.Viewer Is GridView Then
            TNCommon.GridView_SetRowFocus(Viewer, KeyName, value)
        End If
    End Sub

    Public Function GetKeyValue() As Object
        Dim _Value As Object = Nothing
        If TypeOf Viewer Is TreeList Then
            _Value = TNCommon.TreeList_FocusKeyValue(Viewer)
        End If

        If TypeOf Viewer Is GridView Then
            _Value = TNCommon.GridView_FocusKeyValue(Viewer, KeyName)
        End If
        Return _Value
    End Function

    Public Function GetObjectValue() As Object
        Dim _Value As Object = Nothing
        If TypeOf Viewer Is TreeList Then
            _Value = TNCommon.TreeList_FocusObjectValue(Viewer)
        End If

        If TypeOf Viewer Is GridView Then
            _Value = TNCommon.GridView_FocusObjectValue(Viewer)
        End If
        Return _Value
    End Function

    Private _Title As String

    Public Property Title() As String
        Get
            Return _Title
        End Get
        Set(ByVal value As String)
            _Title = value
        End Set
    End Property

    Private _Viewer As Object = Nothing
    Public Property Viewer() As Object
        Get
            Return _Viewer
        End Get
        Set(ByVal value As Object)
            _Viewer = value
        End Set
    End Property

    Private _KeyName As String

    Public Property KeyName() As String
        Get
            Return _KeyName
        End Get
        Set(ByVal value As String)
            _KeyName = value
        End Set
    End Property

    Private _ParentKeyName As String

    Public Property ParentKeyName() As String
        Get
            Return _ParentKeyName
        End Get
        Set(ByVal value As String)
            _ParentKeyName = value
        End Set
    End Property

    Private _KeyValue As Object

    Public Property KeyValue() As Object
        Get
            Return GetKeyValue()
        End Get
        Set(ByVal value As Object)
            SetKeyValue(value)
        End Set
    End Property

    Private _ButtonCreate As SimpleButton

    Public Property ButtonCreate() As SimpleButton
        Get
            Return _ButtonCreate
        End Get
        Set(ByVal value As SimpleButton)
            _ButtonCreate = value
        End Set
    End Property

    Private _ButtonModify As SimpleButton

    Public Property ButtonModify() As SimpleButton
        Get
            Return _ButtonModify
        End Get
        Set(ByVal value As SimpleButton)
            _ButtonModify = value
        End Set
    End Property

    Private _ButtonDelete As SimpleButton
    Public Property ButtonDelete() As SimpleButton
        Get
            Return _ButtonDelete
        End Get
        Set(ByVal value As SimpleButton)
            _ButtonDelete = value
        End Set
    End Property

    Private _ButtonView As SimpleButton
    Public Property ButtonView() As SimpleButton
        Get
            Return _ButtonView
        End Get
        Set(ByVal value As SimpleButton)
            _ButtonView = value
        End Set
    End Property

    Private _ButtonSearch As SimpleButton
    Public Property ButtonSearch() As SimpleButton
        Get
            Return _ButtonSearch
        End Get
        Set(ByVal value As SimpleButton)
            _ButtonSearch = value
        End Set
    End Property

    Private _ViewerColumnDefine As ArrayList
    Public Property ViewerColumnDefine() As ArrayList
        Get
            Return _ViewerColumnDefine
        End Get
        Set(ByVal value As ArrayList)
            _ViewerColumnDefine = value
        End Set
    End Property

    Private _FieldChooserColumnDefine As ArrayList
    Public Property FieldChooserColumnDefine() As ArrayList
        Get
            Return _FieldChooserColumnDefine
        End Get
        Set(ByVal value As ArrayList)
            _FieldChooserColumnDefine = value
        End Set
    End Property

#End Region

#Region "Event handle"
    Private Sub FieldChooser_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        If FieldChooser.EditValue IsNot Nothing Then
            SearchHelper.Properties.DisplayMember = FieldChooser.EditValue.ToString()
            SearchHelper.Focus()
        End If
    End Sub

    Private Sub SearchHelper_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        If SearchHelper.EditValue IsNot Nothing Then
            SetKeyValue(SearchHelper.EditValue)
        End If
    End Sub

    Private Sub CommonInit_KeyDownEventProcess(ByVal sender As Object, ByVal e As KeyEventArgs)
        Dim form As XtraForm = TryCast(sender, XtraForm)
        Dim obj As FrmBaseDmChiTiet = TryCast(sender, FrmBaseDmChiTiet)
        Select Case e.KeyCode
            Case Keys.Escape
                form.Close()
                Exit Select

            Case Keys.F3
                DoCreate()
                Exit Select

            Case Keys.F4
                DoModify()
                Exit Select

            Case Keys.F8
                DoDelete()
                Exit Select

            Case Keys.F11
                DoExport()
                Exit Select

            Case Keys.F12
                DoImport()
                Exit Select

        End Select
    End Sub

    Private Sub ButtonCreate_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        DoCreate()
    End Sub

    Private Sub ButtonSearch_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        DoSearch()
    End Sub

    Private Sub ButtonDelete_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        DoDelete()
    End Sub

    Private Sub ButtonModify_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        DoModify()
    End Sub

    Private Sub frmBaseChiTiet_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        InitProperty()
        CommonInit()
    End Sub
#End Region
End Class