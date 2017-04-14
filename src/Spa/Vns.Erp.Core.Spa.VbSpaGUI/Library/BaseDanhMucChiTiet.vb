Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports DevExpress.XtraEditors
Imports System.ComponentModel
Imports System.Windows.Forms
Imports DevExpress.XtraEditors.DXErrorProvider
Imports System.Drawing

Public Class BaseDanhMucChiTiet(Of T, IdT)
    Inherits XtraForm
    Public Shared DELAY_MESSAGE As Integer = 300


    Public Overridable Sub InitProperty()
    End Sub
    Public Overridable Sub InitComponet()
    End Sub
    Public Overridable Sub BindLookUpEdit()
    End Sub
    Public Overridable Sub ValidateData(ByVal sender As Object, ByVal e As CancelEventArgs)
    End Sub
    Public Overridable Sub Saving()
    End Sub
    Public Overridable Sub BindData()
    End Sub
    Public Overridable Property ObjectInfo() As T
        Get
            Return m_ObjectInfo
        End Get
        Set(ByVal value As T)
            m_ObjectInfo = value
        End Set
    End Property
    Private m_ObjectInfo As T

    Public Sub New()
        InitComponet()
    End Sub

    Public Sub CommonInit()
        If ButtonSave Is Nothing Then
            Return
        End If
        InitTile()

        If (Me.GroupControlObjectInfo IsNot Nothing) Then
            Me.GroupControlObjectInfo.ShowCaption = False
        End If

        KeyPreview = True
        'KeyDown += New KeyEventHandler(AddressOf CommonInit_KeyDownEventProcess)
        AddHandler Me.KeyDown, AddressOf CommonInit_KeyDownEventProcess
        'ButtonSave.Click += New System.EventHandler(AddressOf ButtonSave_Click)
        If (Me.ButtonSave IsNot Nothing) Then
            RemoveHandler Me.ButtonSave.Click, AddressOf ButtonSave_Click
            AddHandler Me.ButtonSave.Click, AddressOf ButtonSave_Click
        End If
        'ButtonClear.Click += New EventHandler(AddressOf ButtonClear_Click)
        If (Me.ButtonClear IsNot Nothing) Then
            RemoveHandler Me.ButtonClear.Click, AddressOf ButtonClear_Click
            AddHandler Me.ButtonClear.Click, AddressOf ButtonClear_Click
        End If
        'ButtonCancel.Click += New EventHandler(AddressOf ButtonCancel_Click)
        If (Me.ButtonCancel IsNot Nothing) Then
            RemoveHandler Me.ButtonCancel.Click, AddressOf ButtonCancel_Click
            AddHandler Me.ButtonCancel.Click, AddressOf ButtonCancel_Click
        End If
        'acc

        ApplyRequireInputValidate()

        DoLoadData()
    End Sub
    Public Sub InitTile()
        Dim mode__1 As String = ""
        Select Case Mode
            Case FormGlobals.DataInputState.AddMode
                mode__1 = GeneralString.ADD
                Exit Select
            Case FormGlobals.DataInputState.EditMode
                mode__1 = GeneralString.EDIT
                Exit Select
        End Select

        Text = Title & mode__1

    End Sub
    Public Sub Loading()
        FormGlobals.Panel_InitControl(GroupControlObjectInfo, TableName)
        Init_Data()
    End Sub
    Public Sub Init_Data()
        BindLookUpEdit()
        If Mode = FormGlobals.DataInputState.AddMode Then
        End If

        If Mode = FormGlobals.DataInputState.EditMode Then
            BindData()
        End If
    End Sub

#Region "Properties"

    Private _BO As Vns.Erp.Core.Service.Interface.IErpService(Of T, IdT)

    Public Property ErpService() As Vns.Erp.Core.Service.Interface.IErpService(Of T, IdT)
        Get
            Return _BO
        End Get
        Set(ByVal value As Vns.Erp.Core.Service.Interface.IErpService(Of T, IdT))
            _BO = value
        End Set
    End Property
    Private _ButtonSave As SimpleButton
    Public Property ButtonSave() As SimpleButton
        Get
            Return _ButtonSave
        End Get
        Set(ByVal value As SimpleButton)
            _ButtonSave = value
        End Set
    End Property

    Private _ButtonClear As SimpleButton
    Public Property ButtonClear() As SimpleButton
        Get
            Return _ButtonClear
        End Get
        Set(ByVal value As SimpleButton)
            _ButtonClear = value
        End Set
    End Property

    Private _ButtonCancel As SimpleButton
    Public Property ButtonCancel() As SimpleButton
        Get
            Return _ButtonCancel
        End Get
        Set(ByVal value As SimpleButton)
            _ButtonCancel = value
        End Set
    End Property

    Private _Title As String
    Public Property Title() As String
        Get
            Return _Title
        End Get
        Set(ByVal value As String)
            _Title = value
        End Set
    End Property

    Private _GroupControlObjectInfo As GroupControl
    Public Property GroupControlObjectInfo() As GroupControl
        Get
            Return _GroupControlObjectInfo
        End Get
        Set(ByVal value As GroupControl)
            _GroupControlObjectInfo = value
        End Set
    End Property

    Public Property RequireInputControls() As Control()
        Get
            Return _RequireInputControl
        End Get
        Set(ByVal value As Control())
            _RequireInputControl = value
        End Set
    End Property

    Public Property ID() As [Object]
        Get
            Return _ID
        End Get
        Set(ByVal value As [Object])

            _ID = value
        End Set
    End Property

    Public Property Mode() As FormGlobals.DataInputState
        Get
            Return _Mode
        End Get
        Set(ByVal value As FormGlobals.DataInputState)
            _Mode = value
        End Set
    End Property

    Private _TableName As String
    Public Property TableName() As String
        Get
            Return _TableName
        End Get
        Set(ByVal value As String)
            _TableName = value
        End Set
    End Property

    Public Property ErrorProvider() As DXErrorProvider
        Get
            If _ErrorProvider Is Nothing Then
                _ErrorProvider = New DXErrorProvider()
            End If
            Return _ErrorProvider
        End Get
        Set(ByVal value As DXErrorProvider)
            _ErrorProvider = value
        End Set
    End Property
#End Region

#Region "Private Field"
    Private _ID As [Object]
    Private _Mode As FormGlobals.DataInputState
    Private _RequireInputControl As Control()
    Private _ErrorProvider As DXErrorProvider
#End Region

#Region "Action"

    Public Overridable Sub DoLoadData()
        DoClear()
        Loading()
    End Sub

    Public Sub DoSave()
        Try
            ErrorProvider.ClearErrors()
            If Not ValidateChildren(ValidationConstraints.Enabled) Then
                Return
            End If
            frmProgress.Instance().Thread = AddressOf Saving
            frmProgress.Instance().Show_Progress(GeneralString.SAVING)
        Catch ex As Exception
            TNCommon.NotifyError(ex)
        End Try
    End Sub

    Public Sub DoClear()
        If (Not GroupControlObjectInfo Is Nothing) Then
            GroupControlObjectInfo.Visible = False
            FormGlobals.Control_ClearData(GroupControlObjectInfo)
            ErrorProvider.ClearErrors()
            GroupControlObjectInfo.Visible = True
        End If
    End Sub

    Public Sub DoCancel()
        Close()
    End Sub
#End Region

#Region "Validate"
    Public Sub ApplyRequireInputValidate()
        If RequireInputControls Is Nothing Then
            Return
        End If

        For Each _Control As Control In RequireInputControls
            Dim lbl As New LabelControl()
            lbl.Text = "*"
            lbl.ForeColor = System.Drawing.Color.Red
            _Control.Parent.Controls.Add(lbl)
            lbl.Location = New Point(_Control.Location.X - 10, _Control.Location.Y)
            AddHandler _Control.Validating, New CancelEventHandler(AddressOf ValidateRequireInput)
            AddHandler _Control.Validating, New CancelEventHandler(AddressOf ValidateData)
        Next
    End Sub

    Public Sub ValidateRequireInput(ByVal sender As [Object], ByVal e As CancelEventArgs)
        Dim value As Object = ""
        Dim support As Boolean = False
        If TypeOf sender Is TextEdit Then
            value = DirectCast(sender, TextEdit).Text.Trim
            support = True
        End If
        If TypeOf sender Is LookUpEdit Then
            value = DirectCast(sender, LookUpEdit).EditValue
            support = True
        End If

        If TypeOf sender Is GridLookUpEdit Then
            value = DirectCast(sender, GridLookUpEdit).EditValue
            support = True
        End If
        If TypeOf sender Is DateEdit Then
            value = DirectCast(sender, DateEdit).EditValue
            support = True
        End If
        If Not support Then
            Throw New Exception([String].Format(GeneralString.VALIDATE_REQUIRE_NOT_SUPPORT_CONTROL, sender.[GetType]().ToString()))
        End If

        Dim ctl As Control = TryCast(sender, Control)

        If value Is Nothing OrElse value.ToString() = "" Then
            ErrorProvider.SetIconAlignment(ctl, ErrorIconAlignment.MiddleRight)
            ErrorProvider.SetError(ctl, GeneralString.NO_INPUT_DATA)
            e.Cancel = True
        Else
            ErrorProvider.SetErrorType(ctl, ErrorType.None)
        End If
    End Sub
#End Region

#Region "Event Handle"
    Private Sub CommonInit_KeyDownEventProcess(ByVal sender As Object, ByVal e As KeyEventArgs)
        Dim form As XtraForm = TryCast(sender, XtraForm)
        Dim obj As BaseDanhMucDanhSach(Of T, IdT) = TryCast(sender, BaseDanhMucDanhSach(Of T, IdT))
        Select Case e.KeyCode
            Case Keys.Escape
                form.Close()
                Exit Select
        End Select
    End Sub
    Private Sub ButtonCancel_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Close()
    End Sub
    Private Sub ButtonClear_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        DoClear()
    End Sub
    Private Sub ButtonSave_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        DoSave()
    End Sub
#End Region

    Public Sub AfterSaveSuccess()
        frmProgress.Instance().SetFinishText(GeneralString.SAVE_SUCCESSFUL, DELAY_MESSAGE)
    End Sub
End Class

