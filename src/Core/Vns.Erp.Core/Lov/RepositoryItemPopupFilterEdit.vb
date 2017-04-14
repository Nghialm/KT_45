'*************************************************************************
'	created:	2011/11/23
'	created:	23:11:2011   17:00
'	filename: 	D:\TRINAM\KeToan\v52\KTY.Common\UserControl\RepositoryItemPopupFilterEdit.vb
'	file path:	D:\TRINAM\KeToan\v52\KTY.Common\UserControl
'	file base:	RepositoryItemPopupFilterEdit
'	file ext:	vb
'	author:		TienNQ
'	
'	purpose:	
'*************************************************************************
Imports Microsoft.VisualBasic
Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.Registrator

<UserRepositoryItem("Register")> _
    Public Class RepositoryItemPopupFilterEdit
    Inherits RepositoryItemButtonEdit

#Region "Properties"
    Private _C_FORM_TITLE As String = ""
    Private _C_DATA_SOURCE As DataTable = Nothing
    Private _C_ARR_COLS_DISPLAY As String = ""
    Private _C_KEY_NAME As String = ""
    Private _C_ARR_COLS_RETURN As String = ""
    Private _C_IS_QUICKADD As Boolean = False
    Private _C_FORM_DANHSACH As String = ""
    Private _C_IS_CHECK_NUMBER As String = "="
    Private _C_IS_CHECK_STRING As String = "="
    Private _C_IS_CHECK_OTHER As String = "="
    Private _C_IS_FILTER_STRING As String = ""
    Private _C_IS_SORT_ORDER_STRING As String = ""

    Private _EditValues As String = ""
    Private _NEXT_TAB As Integer = 0
    Private _OBJ_CONDITITION As PopupFilterInfo
    Private _C_IS_CHI_TIET As String = ""
    Private _Text As String
    Private _ListEditValues As New List(Of String)
    Private _Editors As PopupFilterEdit = Nothing

    Public Property Editors() As PopupFilterEdit
        Get
            Return _Editors
        End Get
        Set(ByVal value As PopupFilterEdit)
            _Editors = value
        End Set
    End Property

    Public Property ListEditValues() As List(Of String)
        Get
            Return _ListEditValues
        End Get
        Set(ByVal value As List(Of String))
            _ListEditValues = value
        End Set
    End Property

    Public Property OBJ_CONDITITION() As PopupFilterInfo
        Get
            Return _OBJ_CONDITITION
        End Get
        Set(ByVal value As PopupFilterInfo)
            _OBJ_CONDITITION = value
        End Set
    End Property

    Public Property C_IS_CHI_TIET() As String
        Get
            Return _C_IS_CHI_TIET
        End Get
        Set(ByVal value As String)
            _C_IS_CHI_TIET = value
        End Set
    End Property

    Public Property C_FORM_TITLE() As String
        Get
            Return _C_FORM_TITLE
            'Return Form_Title
            'Return OBJ_CONDITITION.C_FORM_TITLE
        End Get
        Set(ByVal value As String)
            _C_FORM_TITLE = value
            'Form_Title = value
            'OBJ_CONDITITION.C_FORM_TITLE = value
        End Set
    End Property

    Public Property C_DATA_SOURCE() As System.Data.DataTable
        Get
            Return _C_DATA_SOURCE
            'Return Data_Source
            'Return OBJ_CONDITITION.C_DATA_SOURCE
        End Get
        Set(ByVal value As System.Data.DataTable)
            _C_DATA_SOURCE = value
            'Data_Source = value
            'OBJ_CONDITITION.C_DATA_SOURCE = value
        End Set
    End Property

    Public Property C_ARR_COLS_DISPLAY() As String
        Get
            Return _C_ARR_COLS_DISPLAY
            'Return Cols_Display
            'Return OBJ_CONDITITION.C_ARR_COLS_DISPLAY
        End Get
        Set(ByVal value As String)
            _C_ARR_COLS_DISPLAY = value
            'Cols_Display = value
            'OBJ_CONDITITION.C_ARR_COLS_DISPLAY = value
        End Set
    End Property

    Public Property C_KEY_NAME() As String
        Get
            Return _C_KEY_NAME
            'Return Key_Name
            'Return OBJ_CONDITITION.C_KEY_NAME
        End Get
        Set(ByVal value As String)
            _C_KEY_NAME = value
            'Key_Name = value
            'OBJ_CONDITITION.C_KEY_NAME = value
        End Set
    End Property

    Public Property C_ARR_COLS_RETURN() As String
        Get
            Return _C_ARR_COLS_RETURN
            'Return Cols_Return
            'Return OBJ_CONDITITION.C_ARR_COLS_RETURN
        End Get
        Set(ByVal value As String)
            _C_ARR_COLS_RETURN = value
            'Cols_Return = value
            'OBJ_CONDITITION.C_ARR_COLS_RETURN = value
        End Set
    End Property

    Public Property C_IS_QUICKADD() As Boolean
        Get
            Return _C_IS_QUICKADD
            'Return Is_Quick_Add
            'Return OBJ_CONDITITION.C_IS_QUICKADD
        End Get
        Set(ByVal value As Boolean)
            _C_IS_QUICKADD = value
            'Is_Quick_Add = value
            'OBJ_CONDITITION.C_IS_QUICKADD = value
        End Set
    End Property

    Public Property C_FORM_DANHSACH() As String
        Get
            Return _C_FORM_DANHSACH
            'Return Form_DanhSach
            'Return OBJ_CONDITITION.C_FORM_DANHSACH
        End Get
        Set(ByVal value As String)
            _C_FORM_DANHSACH = value
            'Form_DanhSach = value
            'OBJ_CONDITITION.C_FORM_DANHSACH = value
        End Set
    End Property

    Public Property C_IS_CHECK_NUMBER() As String
        Get
            Return _C_IS_CHECK_NUMBER
        End Get
        Set(ByVal value As String)
            _C_IS_CHECK_NUMBER = value
        End Set
    End Property

    Public Property C_IS_CHECK_STRING() As String
        Get
            Return _C_IS_CHECK_STRING
        End Get
        Set(ByVal value As String)
            _C_IS_CHECK_STRING = value
        End Set
    End Property

    Public Property C_IS_CHECK_OTHER() As String
        Get
            Return _C_IS_CHECK_OTHER
        End Get
        Set(ByVal value As String)
            _C_IS_CHECK_OTHER = value
        End Set
    End Property

    Public Property C_IS_FILTER_STRING() As String
        Get
            Return _C_IS_FILTER_STRING
        End Get
        Set(ByVal value As String)
            _C_IS_FILTER_STRING = value
        End Set
    End Property

    Public Property C_IS_SORT_ORDER_STRING() As String
        Get
            Return _C_IS_SORT_ORDER_STRING
        End Get
        Set(ByVal value As String)
            _C_IS_SORT_ORDER_STRING = value
        End Set
    End Property

    Public Property EditValues() As String
        Get
            Return _EditValues
            'Return Edit_Values
        End Get
        Set(ByVal value As String)
            _EditValues = value
            'Edit_Values = value
        End Set
    End Property

    Public Property NEXT_TAB() As Integer
        Get
            Return _NEXT_TAB
        End Get
        Set(ByVal value As Integer)
            _NEXT_TAB = value
        End Set
    End Property

#End Region

#Region "Delegate"
    Public Delegate Sub FilterCustomEventHandler(ByVal senders As Object, ByVal e As EventArgs)
    Public Event BeforeFilter As FilterCustomEventHandler
    Public Event AfterFilter As FilterCustomEventHandler
    Public Event AfterQuickAdd As FilterCustomEventHandler
    Public Event ClearDataFilter As FilterCustomEventHandler
    Public Event FisrtBinddata As FilterCustomEventHandler

    Public Sub RaiseEventBefore(ByVal senders As Object, ByVal e As EventArgs)
        RaiseEvent BeforeFilter(senders, e)
    End Sub

    Public Sub RaiseEventClear(ByVal senders As Object, ByVal e As EventArgs)
        RaiseEvent ClearDataFilter(senders, e)
    End Sub

    Public Sub RaiseEventAfter(ByVal senders As Object, ByVal e As EventArgs)
        RaiseEvent AfterFilter(senders, e)
    End Sub

    Public Sub RaiseEventAfterQuickAdd(ByVal sender As Object, ByVal e As EventArgs)
        RaiseEvent AfterQuickAdd(sender, e)
    End Sub

    Public Sub RaiseEventFirstBinddata(ByVal sender As Object, ByVal e As EventArgs)
        RaiseEvent FisrtBinddata(sender, e)
    End Sub
#End Region

#Region "Constructor"
    Shared Sub New()
        Register()
    End Sub

    Public Sub New()
    End Sub

    Public Sub New(ByVal C_FORM_TITLE As String, ByVal C_DATA_SOURCE As DataTable, ByVal C_ARR_COLS_DISPLAY As String, ByVal C_KEY_NAME As String, ByVal C_ARR_COLS_RETURN As String, ByVal C_IS_QUICKADD As Boolean, ByVal C_FORM_DANHSACH As String)
        Me.C_FORM_TITLE = C_FORM_TITLE
        _C_DATA_SOURCE = C_DATA_SOURCE
        Me.C_ARR_COLS_DISPLAY = C_ARR_COLS_DISPLAY
        Me.C_KEY_NAME = C_KEY_NAME
        Me.C_ARR_COLS_RETURN = C_ARR_COLS_RETURN
        Me.C_IS_QUICKADD = C_IS_QUICKADD
        Me.C_FORM_DANHSACH = C_FORM_DANHSACH
        RegisterEvent()
    End Sub

    Public Sub RegisterEvent()
        AddHandler Editors.AfterPopupFilterEdit, AddressOf RaiseEventAfter
        AddHandler Editors.AfterQuickAddPopupFilterEdit, AddressOf RaiseEventAfterQuickAdd
        AddHandler Editors.BeforePopupFilterEdit, AddressOf RaiseEventBefore
        AddHandler Editors.ClearPopupFilterEdit, AddressOf RaiseEventClear
        AddHandler Editors.FirstBindData, AddressOf RaiseEventFirstBinddata
    End Sub
#End Region

#Region "Constant"
    Friend Const EditorName As String = "PopupFilterEdit"
#End Region

#Region "Overrides"
    Public Shared Sub Register()
        EditorRegistrationInfo.Default.Editors.Add(New EditorClassInfo(EditorName, GetType(PopupFilterEdit), GetType(RepositoryItemPopupFilterEdit), GetType(DevExpress.XtraEditors.ViewInfo.ButtonEditViewInfo), New DevExpress.XtraEditors.Drawing.ButtonEditPainter(), True, CType(Nothing, Image), GetType(DevExpress.Accessibility.ButtonEditAccessible)))
    End Sub

    Public Overrides ReadOnly Property EditorTypeName() As String
        Get
            Return EditorName
        End Get
    End Property

    Public Overloads ReadOnly Property OwnerEdit() As PopupFilterEdit
        Get
            Return Editors
        End Get
    End Property

    Public Overrides Function CreateEditor() As DevExpress.XtraEditors.BaseEdit
        Editors = New PopupFilterEdit(C_FORM_TITLE, _C_DATA_SOURCE, C_ARR_COLS_DISPLAY, C_KEY_NAME, C_ARR_COLS_RETURN, C_IS_QUICKADD, C_FORM_DANHSACH, C_IS_CHECK_NUMBER, C_IS_CHECK_STRING, C_IS_CHECK_OTHER, C_IS_FILTER_STRING, C_IS_SORT_ORDER_STRING)
        RegisterEvent()
        Return Editors
    End Function

    Public Overrides Sub Assign(ByVal item As DevExpress.XtraEditors.Repository.RepositoryItem)
        BeginUpdate()
        Try
            MyBase.Assign(item)
            Dim source As RepositoryItemPopupFilterEdit = TryCast(item, RepositoryItemPopupFilterEdit)
            If source Is Nothing Then Return
            Me.Events.AddHandlers(source.Events)
        Finally
            EndUpdate()
        End Try
    End Sub
#End Region

End Class



Public Class PopupFilterEdit
    Inherits ButtonEdit

#Region "Delegate"
    Public Delegate Sub FilterCustomEventHandler(ByVal senders As Object, ByVal e As EventArgs)
    Public Event BeforePopupFilterEdit As FilterCustomEventHandler
    Public Event AfterPopupFilterEdit As FilterCustomEventHandler
    Public Event AfterQuickAddPopupFilterEdit As FilterCustomEventHandler
    Public Event ClearPopupFilterEdit As FilterCustomEventHandler
    Public Event FirstBindData As FilterCustomEventHandler
#End Region

#Region "Properties"
    Private _A_FORM_TITLE As String = ""
    Private _A_DATA_SOURCE As DataTable = Nothing
    Private _A_ARR_COLS_DISPLAY As String = ""
    Private _A_KEY_NAME As String = ""
    Private _A_ARR_COLS_RETURN As String = ""
    Private _A_IS_QUICKADD As Boolean = False
    Private _A_FORM_DANHSACH As String = ""
    Private _A_LIST_VALUES As New List(Of String)
    Private _A_MAIN_VALUE As String = ""
    Private _A_IS_CHECK_NUMBER As String = ""
    Private _A_IS_CHECK_STRING As String = ""
    Private _A_IS_CHECK_OTHER As String = ""
    Private _A_IS_FILTER_STRING As String = ""
    Private _A_IS_SORT_ORDER_STRING As String = ""
    Private _A_USER_CHOISE_OK As Boolean = False
    Private C_QUICK_ADD_SUCCESS As Boolean = False

    Public Property A_USER_CHOISE_OK() As Boolean
        Get
            Return _A_USER_CHOISE_OK
        End Get
        Set(ByVal value As Boolean)
            _A_USER_CHOISE_OK = value
        End Set
    End Property

    Public Property A_MAIN_VALUE() As String
        Get
            Return _A_MAIN_VALUE
        End Get
        Set(ByVal value As String)
            _A_MAIN_VALUE = value
        End Set
    End Property

    Public Property A_LIST_VALUES() As List(Of String)
        Get
            Return _A_LIST_VALUES
        End Get
        Set(ByVal value As List(Of String))
            _A_LIST_VALUES = value
        End Set
    End Property

    Public Property A_FORM_TITLE() As String
        Get
            Return _A_FORM_TITLE
        End Get
        Set(ByVal value As String)
            _A_FORM_TITLE = value
        End Set
    End Property

    Public Property A_DATA_SOURCE() As System.Data.DataTable
        Get
            Return _A_DATA_SOURCE
        End Get
        Set(ByVal value As System.Data.DataTable)
            _A_DATA_SOURCE = value
        End Set
    End Property

    Public Property A_ARR_COLS_DISPLAY() As String
        Get
            Return _A_ARR_COLS_DISPLAY
        End Get
        Set(ByVal value As String)
            _A_ARR_COLS_DISPLAY = value
        End Set
    End Property

    Public Property A_KEY_NAME() As String
        Get
            Return _A_KEY_NAME
        End Get
        Set(ByVal value As String)
            _A_KEY_NAME = value
        End Set
    End Property

    Public Property A_ARR_COLS_RETURN() As String
        Get
            Return _A_ARR_COLS_RETURN
        End Get
        Set(ByVal value As String)
            _A_ARR_COLS_RETURN = value
        End Set
    End Property

    Public Property A_IS_QUICKADD() As Boolean
        Get
            Return _A_IS_QUICKADD
        End Get
        Set(ByVal value As Boolean)
            _A_IS_QUICKADD = value
        End Set
    End Property

    Public Property A_FORM_DANHSACH() As String
        Get
            Return _A_FORM_DANHSACH
        End Get
        Set(ByVal value As String)
            _A_FORM_DANHSACH = value
        End Set
    End Property

    Public Property A_IS_CHECK_NUMBER() As String
        Get
            Return _A_IS_CHECK_NUMBER
        End Get
        Set(ByVal value As String)
            _A_IS_CHECK_NUMBER = value
        End Set
    End Property

    Public Property A_IS_CHECK_STRING() As String
        Get
            Return _A_IS_CHECK_STRING
        End Get
        Set(ByVal value As String)
            _A_IS_CHECK_STRING = value
        End Set
    End Property

    Public Property A_IS_CHECK_OTHER() As String
        Get
            Return _A_IS_CHECK_OTHER
        End Get
        Set(ByVal value As String)
            _A_IS_CHECK_OTHER = value
        End Set
    End Property

    Public Property A_IS_FILTER_STRING() As String
        Get
            Return _A_IS_FILTER_STRING
        End Get
        Set(ByVal value As String)
            _A_IS_FILTER_STRING = value
        End Set
    End Property

    Public Property A_IS_SORT_ORDER_STRING() As String
        Get
            Return _A_IS_SORT_ORDER_STRING
        End Get
        Set(ByVal value As String)
            _A_IS_SORT_ORDER_STRING = value
        End Set
    End Property

    Private _MessageWarning As String = "Giá trị không hợp lệ!"
    Public Property MessageWarning() As String
        Get
            Return _MessageWarning
        End Get
        Set(ByVal value As String)
            _MessageWarning = value
        End Set
    End Property
#End Region

#Region "Constructor"
    Shared Sub New()
        RepositoryItemPopupFilterEdit.Register()
    End Sub

    Public Sub New()
    End Sub

    Public Sub New(ByVal A_FORM_TITLE As String, ByVal A_DATA_SOURCE As DataTable, ByVal A_ARR_COLS_DISPLAY As String, ByVal A_KEY_NAME As String, ByVal A_ARR_COLS_RETURN As String, ByVal A_IS_QUICKADD As Boolean, ByVal A_FORM_DANHSACH As String, ByVal A_IS_CHECK_NUMBER As String, ByVal A_IS_CHECK_STRING As String, ByVal A_IS_CHECK_OTHER As String, ByVal A_IS_FILTER_STRING As String, ByVal A_IS_SORT_ORDER_STRING As String)
        Me.A_FORM_TITLE = A_FORM_TITLE
        _A_DATA_SOURCE = A_DATA_SOURCE
        Me.A_ARR_COLS_DISPLAY = A_ARR_COLS_DISPLAY
        Me.A_KEY_NAME = A_KEY_NAME
        Me.A_IS_CHECK_NUMBER = A_IS_CHECK_NUMBER
        Me.A_IS_CHECK_STRING = A_IS_CHECK_STRING
        Me.A_IS_CHECK_OTHER = A_IS_CHECK_OTHER
        Me.A_IS_FILTER_STRING = A_IS_FILTER_STRING
        Me.A_IS_SORT_ORDER_STRING = A_IS_SORT_ORDER_STRING
        Me.A_ARR_COLS_RETURN = A_ARR_COLS_RETURN
        Me.A_IS_QUICKADD = A_IS_QUICKADD
        Me.A_FORM_DANHSACH = A_FORM_DANHSACH
        Dim arrColReturn() As String = Me.A_ARR_COLS_RETURN.Split(";")
        For Each info As String In arrColReturn
            A_LIST_VALUES.Add("")
        Next
        Me.A_USER_CHOISE_OK = False
    End Sub
#End Region

#Region "Overrides"
    Protected Overrides Sub OnTextChanged(ByVal e As EventArgs)
        Try
            GetDataByKeyName(Me.Text)
        Catch ex As Exception
            Vns.Erp.Core.Message_Error(ex)
        End Try
    End Sub

    Protected Overrides Sub OnKeyDown(ByVal e As KeyEventArgs)
        Try
            Dim _isRaised As Boolean = False
            Dim _isRaisedAfterQuickAdd As Boolean = False
            If _A_DATA_SOURCE Is Nothing Then
                RaiseEvent BeforePopupFilterEdit(Nothing, Nothing)
            End If

            'Dim txt_key_value As String = Me.Text & Chr(e.KeyCode)
            'txt_key_value = txt_key_value.Trim()

            If e.KeyCode = Keys.Enter Then 'Key is Enter
                If CheckExistKeyName(Me.Text) Then 'If mapped
                    If RepositoryCommonFunctions.CheckChiTietForPopup(A_KEY_NAME, Me.Text, _A_DATA_SOURCE, A_IS_CHECK_NUMBER, A_IS_CHECK_STRING, A_IS_CHECK_OTHER) Then
                        _isRaised = True
                        'GetDataByKeyName(Me.Text)
                    Else
                        GoTo _SHOW_POP
                    End If
                Else 'If not mapped
_SHOW_POP:
                    Dim str As String = ShowPopupForm()
                    Dim bCheck As Boolean = RepositoryCommonFunctions.CheckChiTietForPopup(A_KEY_NAME, str, _A_DATA_SOURCE, A_IS_CHECK_NUMBER, A_IS_CHECK_STRING, A_IS_CHECK_OTHER)
                    If bCheck = False Then
                        str = ""
                    End If
                    If Not str.Equals("") Then
                        If C_QUICK_ADD_SUCCESS Then
                            _isRaisedAfterQuickAdd = True
                        End If
                        'GetDataByKeyName(str)
                        _isRaised = True
                    Else
                        _isRaised = False
                    End If
                End If
                'RaiseEvent
                If _isRaised Then
                    A_USER_CHOISE_OK = True
                    RaiseEvent AfterPopupFilterEdit(Nothing, Nothing)
                Else
                    A_USER_CHOISE_OK = False
                    RaiseEvent AfterPopupFilterEdit(Nothing, Nothing)
                End If
                If _isRaisedAfterQuickAdd Then
                    RaiseEvent AfterQuickAddPopupFilterEdit(Nothing, Nothing)
                End If
            Else 'Key is not Enter
                'GetDataByKeyName(Me.Text)
            End If
        Catch ex As Exception
            Vns.Erp.Core.Message_Error(ex)
        End Try
    End Sub

    Protected Overrides Sub OnEnter(ByVal e As EventArgs)
        'MyBase.OnEnter(e)
    End Sub

    Public Overrides ReadOnly Property EditorTypeName() As String
        Get
            Return RepositoryItemPopupFilterEdit.EditorName
        End Get
    End Property

    <DesignerSerializationVisibility(DesignerSerializationVisibility.Content)> _
    Public Shadows ReadOnly Property Properties() As RepositoryItemPopupFilterEdit
        Get
            Dim abc = TryCast(MyBase.Properties, RepositoryItemPopupFilterEdit)
            'abc.C_FORM_TITLE = info.C_FORM_TITLE
            'abc.C_FORM_TITLE = RepositoryItemPopupFilterEdit.Form_Title
            'abc.C_DATA_SOURCE = RepositoryItemPopupFilterEdit.Data_Source
            'abc.C_ARR_COLS_DISPLAY = RepositoryItemPopupFilterEdit.Cols_Display
            'abc.C_KEY_NAME = RepositoryItemPopupFilterEdit.Key_Name
            'abc.C_ARR_COLS_RETURN = RepositoryItemPopupFilterEdit.Cols_Return
            'abc.C_IS_QUICKADD = RepositoryItemPopupFilterEdit.Is_Quick_Add
            'abc.C_FORM_DANHSACH = RepositoryItemPopupFilterEdit.Form_DanhSach
            Return abc
        End Get
    End Property

    Protected Overrides Sub OnClickButton(ByVal buttonInfo As DevExpress.XtraEditors.Drawing.EditorButtonObjectInfoArgs)
        Try
            Dim _hasChanged As Boolean = False
            Dim _isRaisedAfterQuickAdd As Boolean = False

            If _A_DATA_SOURCE Is Nothing Then
                RaiseEvent FirstBindData(Nothing, Nothing)
            End If

            Dim str As String = ShowPopupForm()
            If Not str.Equals("") Then
                If C_QUICK_ADD_SUCCESS Then
                    _isRaisedAfterQuickAdd = True
                End If
                _hasChanged = True
            Else
                _hasChanged = False
            End If

            If _hasChanged Then
                A_USER_CHOISE_OK = True
                RaiseEvent AfterPopupFilterEdit(Nothing, Nothing)
            Else
                A_USER_CHOISE_OK = False
                RaiseEvent AfterPopupFilterEdit(Nothing, Nothing)
            End If
            If _isRaisedAfterQuickAdd Then
                RaiseEvent AfterQuickAddPopupFilterEdit(Nothing, Nothing)
            End If
        Catch ex As Exception
            Vns.Erp.Core.Message_Error(ex)
        End Try
    End Sub

    Protected Overridable Function ShowPopupForm() As String
        Dim frm As New MultiFilterPopup(A_FORM_TITLE, _A_DATA_SOURCE, Me.Text, A_ARR_COLS_DISPLAY, A_KEY_NAME, A_ARR_COLS_RETURN, A_IS_QUICKADD, A_FORM_DANHSACH, A_IS_CHECK_NUMBER, A_IS_CHECK_STRING, A_IS_CHECK_OTHER, A_IS_FILTER_STRING, A_IS_SORT_ORDER_STRING)
        frm.MessageWarning = _MessageWarning
        If frm.ShowDialog() = DialogResult.OK Then
            If Not frm.MAIN_RETURN_VALUE.Equals("") Then
                If frm.QUICK_ADD_SUCCESS Then
                    C_QUICK_ADD_SUCCESS = True
                End If
                Me.Text = frm.MAIN_RETURN_VALUE
                Me.A_MAIN_VALUE = frm.MAIN_RETURN_VALUE
                Dim count As Integer = frm.LIST_EDIT_VALUE.Count
                Me.A_LIST_VALUES.Clear()
                If count > 0 Then
                    Me.A_LIST_VALUES = frm.LIST_EDIT_VALUE
                End If
                Me.A_USER_CHOISE_OK = True
            Else
                Me.Text = ""
                Me.A_MAIN_VALUE = ""
                Me.A_LIST_VALUES = New List(Of String)
                Me.A_USER_CHOISE_OK = False
            End If
        Else
            'Me.Text = ""
            Me.A_MAIN_VALUE = Me.Text
            Me.A_LIST_VALUES = New List(Of String)
            Me.A_USER_CHOISE_OK = False
        End If
        Return Me.A_MAIN_VALUE
    End Function

    Protected Overridable Function CheckExistKeyName(ByVal user_key_name_value As String) As Boolean
        Dim bCheck As Boolean = False

        'Kiem tra de raise su kien Binddata lan dau tien
        If (_A_DATA_SOURCE Is Nothing) Then
            RaiseEvent FirstBindData(Nothing, Nothing)
        End If

        'Kiem tra de return khoi ham khi DataSource = Nothing
        If (_A_DATA_SOURCE Is Nothing) Then
            Return Nothing
        End If

        For Each dr As DataRow In _A_DATA_SOURCE.Rows
            If dr(A_KEY_NAME).ToString.Equals(user_key_name_value) Then
                bCheck = True
                Exit For
            End If
        Next
        Return bCheck
    End Function

    Protected Overridable Sub GetDataByKeyName(ByVal user_key_name_value As String)
        Dim bCheck As Boolean = False
        Dim arr_col_return() As String = A_ARR_COLS_RETURN.Split(";")
        A_LIST_VALUES = New List(Of String)
        Dim row As DataRow = Nothing

        'Kiem tra de raise su kien Binddata lan dau tien
        If (_A_DATA_SOURCE Is Nothing) Then
            RaiseEvent FirstBindData(Nothing, Nothing)
        End If

        'Kiem tra de return khoi ham khi DataSource = Nothing
        If (_A_DATA_SOURCE Is Nothing) Then
            Return
        End If

        For Each dr As DataRow In _A_DATA_SOURCE.Rows
            If dr(A_KEY_NAME).ToString.Equals(user_key_name_value) Then
                row = dr
                bCheck = True
                Exit For
            End If
        Next

        'Kiem tra item tra ve co phai la chi tiet hay khong
        If RepositoryCommonFunctions.CheckChiTietForPopup(A_KEY_NAME, user_key_name_value, _A_DATA_SOURCE, A_IS_CHECK_NUMBER, A_IS_CHECK_STRING, A_IS_CHECK_OTHER) Then
            If bCheck Then
                For Each info As String In arr_col_return
                    A_LIST_VALUES.Add(row(info).ToString)
                Next
            Else
                For Each info As String In arr_col_return
                    A_LIST_VALUES.Add("")
                Next
                '1. Raise su kien after value change (Ko dc, lost forcus)
                'RaiseEvent AfterPopupFilterEdit(Nothing, Nothing)
                '2. Raise su kien clean data neu du lieu khong hop le
                RaiseEvent ClearPopupFilterEdit(Nothing, Nothing)
            End If
        Else
            For Each info As String In arr_col_return
                A_LIST_VALUES.Add("")
            Next
            RaiseEvent ClearPopupFilterEdit(Nothing, Nothing)
        End If
    End Sub
#End Region

End Class