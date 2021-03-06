Imports System
Imports System.Windows.Forms
Imports Vns.Erp.Core.Admin.Service.Interface
Imports Vns.Erp.Core.Admin.Domain
Public Class frmHPopupOfSetup

#Region "Variables"
    Private _STATUS As Decimal = 1 '1:Add, 2:Update
    Private _INFO_RETURN As IAppHGroupFunctService
    Private _INFO_REF As AppHGroupFunct
    Private _PARENT_ID As Guid = Guid.Empty
    'Parent = 0: Group level 0

    Public Property PARENT_ID() As Guid
        Get
            Return _PARENT_ID
        End Get
        Set(ByVal value As Guid)
            _PARENT_ID = value
        End Set
    End Property

    Public Property STATUS() As Decimal
        Get
            Return _STATUS
        End Get
        Set(ByVal value As Decimal)
            _STATUS = value
        End Set
    End Property

    Public Property INFO_RETURN() As AppHGroupFunct
        Get
            Return _INFO_RETURN
        End Get
        Set(ByVal value As AppHGroupFunct)
            _INFO_RETURN = value
        End Set
    End Property

    Public Property INFO_REF() As AppHGroupFunct
        Get
            Return _INFO_REF
        End Get
        Set(ByVal value As AppHGroupFunct)
            _INFO_REF = value
        End Set
    End Property

    Dim _AppHGroupFunctService As IAppHGroupFunctService

    Public Property AppHGroupFunctService() As IAppHGroupFunctService
        Get
            Return _AppHGroupFunctService
        End Get
        Set(value As IAppHGroupFunctService)
            _AppHGroupFunctService = value
        End Set
    End Property

#End Region

    Public Sub New()
        InitializeComponent()
    End Sub

    Public Sub New(ByVal STATUS As Integer, ByVal INFO_REF As AppHGroupFunct, ByVal PARENT_ID As Guid)
        InitializeComponent()
        Me.STATUS = STATUS
        Me.INFO_REF = INFO_REF
        Me.PARENT_ID = PARENT_ID
    End Sub

    Private Sub frmHPopupOfSetup_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            If STATUS = 1 Then 'Add
                'Do any thing : INFO_REF = Nothing
                If PARENT_ID = Guid.Empty Then
                    txtParentName.Text = "Thư mục cha"
                Else
                    txtParentName.Text = INFO_REF.GroupTen
                End If
            ElseIf STATUS = 2 Then 'Update
                'INFO_REF has value
                txtKyHieu.Text = INFO_REF.GroupKyhieu
                txtTen.Text = INFO_REF.GroupTen
                txtOrder.Text = INFO_REF.GroupOrder
                txtDescription.Text = INFO_REF.Description
                If INFO_REF.ParentId = Guid.Empty Then
                    txtParentName.Text = "Thư mục cha"
                Else
                    Dim objParent As AppHGroupFunct = _AppHGroupFunctService.GetById(INFO_REF.ParentId)
                    txtParentName.Text = objParent.GroupTen
                End If
            End If
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub btnSubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSubmit.Click
        Try
            INFO_RETURN = New AppHGroupFunct()
            Dim info_temp As New AppHGroupFunct()

            If STATUS = 1 Then 'Add
                info_temp.GroupTen = txtKyHieu.Text
                info_temp.GroupTen = txtTen.Text
                Try
                    info_temp.GroupOrder = Decimal.Parse(txtOrder.Text)
                Catch
                    info_temp.GroupOrder = 0
                End Try
                info_temp.ResourcePath = ""
                info_temp.ShortcutKey = ""
                info_temp.Description = txtDescription.Text
                info_temp.ParentId = PARENT_ID
                info_temp.ImageIndex = "-1"
                info_temp.Note1 = ""
                info_temp.Note2 = ""
                info_temp.Note3 = ""

                If IsValidate() Then
                    INFO_RETURN = _AppHGroupFunctService.SaveOrUpdate(info_temp)
                Else
                    Message_Information("Dữ liệu chưa đầy đủ !")
                    Return
                End If

            ElseIf STATUS = 2 Then 'Update
                INFO_RETURN = INFO_REF
                INFO_RETURN.GroupKyhieu = txtKyHieu.Text
                INFO_RETURN.GroupTen = txtTen.Text
                Try
                    INFO_RETURN.GroupOrder = Decimal.Parse(txtOrder.Text)
                Catch ex As Exception
                    INFO_RETURN.GroupOrder = 0
                End Try
                INFO_RETURN.DESCRIPTION = txtDescription.Text

                If IsValidate() Then
                    _AppHGroupFunctService.SaveOrUpdate(INFO_RETURN)
                Else
                    Message_Information("Dữ liệu chưa đầy đủ !")
                    Return
                End If
            End If

            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Function IsValidate() As Boolean
        Dim bReturn As Boolean = True
        If (txtTen.Text Is Nothing) Or (txtTen.Text.Equals("")) Then
            bReturn = False
        End If
        Return bReturn
    End Function

    Private Sub frmHPopupOfSetup_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
            Me.Close()
        End If
    End Sub
End Class