Imports System.ComponentModel
Imports System.Globalization
Imports System.Threading
Imports System.Windows.Forms

Public Class CustomFilter

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
    Private _EditValue As String = ""
    Private _EditValues As String = ""
    Private _ListEditValue As List(Of String) = New List(Of String)
    Private _NEXT_TAB As Integer = 0
    Private C_QUICK_ADD_SUCCESS As Boolean = False
    Private _ENABLES As Boolean

    Private _RaiseOtherEvents = True

    Public Property ENABLES() As Boolean
        Get
            If Me.TabStop = True AndAlso txtKeyWord.TabStop = True AndAlso txtKeyWord.Properties.ReadOnly = False AndAlso btnShowPopup.Enabled = True Then
                _ENABLES = True
                Return True
            ElseIf Me.TabStop = False AndAlso txtKeyWord.TabStop = False AndAlso txtKeyWord.Properties.ReadOnly = True AndAlso btnShowPopup.Enabled = False Then
                _ENABLES = False
                Return False
            End If
            Return False
        End Get
        Set(ByVal value As Boolean)
            _ENABLES = value
            If value = True Then
                txtKeyWord.TabStop = True
                txtKeyWord.Properties.ReadOnly = False
                btnShowPopup.Enabled = True
                Me.TabStop = True
            Else 'value = False
                txtKeyWord.TabStop = False
                txtKeyWord.Properties.ReadOnly = True
                btnShowPopup.Enabled = False
                Me.TabStop = False
                'Clear ListValue Return
                'Dim arr() As String = C_ARR_COLS_RETURN.Split(";")
                '_ListEditValue = New List(Of String)
                'For Each info As String In arr
                '    _ListEditValue.Add("")
                'Next
            End If
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

    Public Overrides Property Text() As String
        Get
            Return txtKeyWord.Text
        End Get
        Set(ByVal value As String)
            txtKeyWord.Text = value
        End Set
    End Property

    Public Overloads Property Tag() As Object
        Get
            Return txtKeyWord.Tag
        End Get
        Set(ByVal value As Object)
            txtKeyWord.Tag = value
            AfterSetTag()
        End Set
    End Property

    Public Property EditValue() As String
        Get
            Return _EditValue
        End Get
        Set(ByVal value As String)
            _EditValue = value
        End Set
    End Property

    Public Property EditValues() As String
        Get
            Return _EditValues
        End Get
        Set(ByVal value As String)
            _EditValues = value
        End Set
    End Property

    Public Property ListEditValue() As List(Of String)
        Get
            Dim arr_ColsReturn() As String = C_ARR_COLS_RETURN.Split(";")
            If _ListEditValue Is Nothing Then
                _ListEditValue = New List(Of String)
                For Each info As String In arr_ColsReturn
                    _ListEditValue.Add("")
                Next
            ElseIf _ListEditValue.Count = 0 Then
                For Each info As String In arr_ColsReturn
                    _ListEditValue.Add("")
                Next
            End If
            Return _ListEditValue
        End Get
        Set(ByVal value As List(Of String))
            _ListEditValue = value
        End Set
    End Property

    Public Property C_FORM_TITLE() As String
        Get
            Return _C_FORM_TITLE
        End Get
        Set(ByVal value As String)
            _C_FORM_TITLE = value
        End Set
    End Property

    Public Property C_DATA_SOURCE() As System.Data.DataTable
        Get
            Return _C_DATA_SOURCE
        End Get
        Set(ByVal value As System.Data.DataTable)
            _C_DATA_SOURCE = value
        End Set
    End Property

    Public Property C_ARR_COLS_DISPLAY() As String
        Get
            Return _C_ARR_COLS_DISPLAY
        End Get
        Set(ByVal value As String)
            _C_ARR_COLS_DISPLAY = value
        End Set
    End Property

    Public Property C_KEY_NAME() As String
        Get
            Return _C_KEY_NAME
        End Get
        Set(ByVal value As String)
            _C_KEY_NAME = value
        End Set
    End Property

    Public Property C_ARR_COLS_RETURN() As String
        Get
            Return _C_ARR_COLS_RETURN
        End Get
        Set(ByVal value As String)
            _C_ARR_COLS_RETURN = value
        End Set
    End Property

    Public Property C_IS_QUICKADD() As Boolean
        Get
            Return _C_IS_QUICKADD
        End Get
        Set(ByVal value As Boolean)
            _C_IS_QUICKADD = value
        End Set
    End Property

    Public Property C_FORM_DANHSACH() As String
        Get
            Return _C_FORM_DANHSACH
        End Get
        Set(ByVal value As String)
            _C_FORM_DANHSACH = value
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

    Private _AllowNull As Boolean = True
    Public Property AllowNull() As Boolean
        Get
            Return _AllowNull
        End Get
        Set(ByVal value As Boolean)
            _AllowNull = value
        End Set
    End Property

    Private _MessageWarning As String = "Giá trị không hợp lệ"
    Public Property MessageWarning() As String
        Get
            Return _MessageWarning
        End Get
        Set(ByVal value As String)
            _MessageWarning = value
        End Set
    End Property

    ''' <summary>
    ''' Bien khai bao de cac su kien kiem tra lai gia tri khong duoc goi nua
    ''' 'True: Cac su kien SetTag, TextChange bo qua
    ''' 'False: Raise su kien len
    ''' </summary>
    ''' <remarks></remarks>
    Public HasCheck As Boolean = False

    'Event Handlers
    Public Delegate Sub FilterCustomEventHandler(ByVal sender As Object, ByVal e As EventArgs)
    Public Event BeforeFilter As FilterCustomEventHandler
    Public Event AfterFilter As FilterCustomEventHandler
    Public Event ClearFilterData As FilterCustomEventHandler
    Public Event AfterQuickAdd As FilterCustomEventHandler
    Public Event FirstBinddata As FilterCustomEventHandler

#End Region

#Region "Event Handles"
    Public Sub CustomFilter()
        InitializeComponent()
    End Sub

    Private Sub CustomFilter_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Me.DesignMode Then
            Return
        End If
        Dim arr_ColsReturn() As String = C_ARR_COLS_RETURN.Split(";")
        If Not Me.Tag Is Nothing Then
            If Not Me.Tag.ToString.Equals("") Then
                RaiseEvent BeforeFilter(sender, e)
                Dim obj_id_value As String = Me.Tag.ToString
                Dim obj_id_field As String = arr_ColsReturn(0)
                _ListEditValue = New List(Of String)
                For Each dr As DataRow In C_DATA_SOURCE.Rows
                    If dr(obj_id_field).ToString.Equals(obj_id_value) Then
                        For Each info As String In arr_ColsReturn
                            _ListEditValue.Add(dr(info).ToString)
                        Next
                        Exit For
                    End If
                Next
            End If
        Else
            _ListEditValue = New List(Of String)
            For Each info As String In arr_ColsReturn
                _ListEditValue.Add("")
            Next
        End If
    End Sub

    Private Sub txtKeyWord_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtKeyWord.KeyDown
        If _ENABLES = False Then
            Return
        End If
        Dim _isRaised As Boolean = False
        Dim _isRaisedAfterQuickAdd As Boolean = False

        If Me.C_DATA_SOURCE Is Nothing Then
            RaiseEvent BeforeFilter(sender, e)
        End If

        'Dim txt_key_value As String = txtKeyWord.Text & Chr(e.KeyCode)
        'txt_key_value = txt_key_value.Trim()

        If (e.KeyCode = Keys.Enter) Then 'Key is Enter

            If CheckExistKeyName(txtKeyWord.Text) Then 'If mapped
                IsSelectOK = RepositoryCommonFunctions.CheckChiTietForPopup(C_KEY_NAME, txtKeyWord.Text, C_DATA_SOURCE, C_IS_CHECK_NUMBER, C_IS_CHECK_STRING, C_IS_CHECK_OTHER)
                If IsSelectOK Then
                    _isRaised = True
                    'GetDataByKeyName(txt_key_value)
                Else
                    GoTo _SHOW_POP
                End If
            Else 'If not mapped
_SHOW_POP:
                Dim str As String = ShowPopup()
                Dim bCheck As Boolean = RepositoryCommonFunctions.CheckChiTietForPopup(C_KEY_NAME, str, C_DATA_SOURCE, C_IS_CHECK_NUMBER, C_IS_CHECK_STRING, C_IS_CHECK_OTHER)
                IsSelectOK = bCheck
                If bCheck = False Then
                    str = ""
                End If
                If Not str.Equals("") Then
                    If C_QUICK_ADD_SUCCESS Then
                        _isRaisedAfterQuickAdd = True
                    End If
                    'GetDataByKeyName(str)
                    'Value is exist in ListEditValue
                    _isRaised = True
                Else
                    _isRaised = False
                End If
            End If
            'RaiseEvent
            If _isRaisedAfterQuickAdd Then
                RaiseEvent AfterQuickAdd(sender, e)
            End If

            HasCheck = True
            If (IsSelectOK) Then
                RaiseEvent AfterFilter(sender, e)
            End If
            HasCheck = False

        Else 'Key is not Enter
            'GetDataByKeyName(txt_key_value)
        End If
    End Sub

    ''' <summary>
    ''' Flag Is Text changed events raise
    ''' True: Not send tab key
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property IsNotTextChanged As Boolean = True
    Private Sub txtKeyWord_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtKeyWord.EditValueChanged
        Try
            If Not (HasCheck) Then
                IsNotTextChanged = False
                GetDataByKeyName(txtKeyWord.Text)
                IsNotTextChanged = True
            End If
        Catch
        End Try
    End Sub

    Private Sub btnShowPopup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShowPopup.Click
        Dim _isRaised As Boolean = False
        Dim _isRaisedAfterQuickAdd As Boolean = False

        If Me.C_DATA_SOURCE Is Nothing Then
            'RaiseEvent BeforeFilter(sender, e)
            RaiseEvent FirstBinddata(sender, e)
        End If

        Dim str As String = ShowPopup()
        If Not (IsSelectOK) Then
            Return
        End If
        Dim bCheck As Boolean = RepositoryCommonFunctions.CheckChiTietForPopup(C_KEY_NAME, str, C_DATA_SOURCE, C_IS_CHECK_NUMBER, C_IS_CHECK_STRING, C_IS_CHECK_OTHER)
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
        'After Quick Add
        If _isRaisedAfterQuickAdd Then
            RaiseEvent AfterQuickAdd(sender, e)
        End If

        'After Filter
        HasCheck = True
        If IsSelectOK Then
            RaiseEvent AfterFilter(sender, e)
        End If
        HasCheck = False
    End Sub
#End Region

#Region "Common Functions"
    Dim IsSelectOK = False
    Private Function ShowPopup() As String
        Dim frm As New MultiFilterPopup(C_FORM_TITLE, C_DATA_SOURCE, txtKeyWord.Text, C_ARR_COLS_DISPLAY, C_KEY_NAME, C_ARR_COLS_RETURN, C_IS_QUICKADD, C_FORM_DANHSACH, C_IS_CHECK_NUMBER, C_IS_CHECK_STRING, C_IS_CHECK_OTHER, C_IS_FILTER_STRING, C_IS_SORT_ORDER_STRING)
        'Gan canh bao cua control
        frm.MessageWarning = Me._MessageWarning
        If frm.ShowDialog() = DialogResult.OK Then
            _ListEditValue = New List(Of String)
            Dim count As Integer = 0
            Dim arr_editvalue() As String = Me.C_ARR_COLS_RETURN.Split(";")

            If Not frm.MAIN_RETURN_VALUE.Equals("") Then
                If frm.QUICK_ADD_SUCCESS Then
                    C_QUICK_ADD_SUCCESS = True
                End If
                count = frm.LIST_EDIT_VALUE.Count
                HasCheck = True
                txtKeyWord.Text = frm.MAIN_RETURN_VALUE
                HasCheck = False
                EditValue = frm.MAIN_RETURN_VALUE
                If count > 0 Then
                    _ListEditValue = frm.LIST_EDIT_VALUE
                End If
            Else
                EditValue = ""
                EditValues = ""
                For Each info As String In arr_editvalue
                    _ListEditValue.Add("")
                Next
            End If
        End If

        IsSelectOK = frm.IS_CHOISE_OK
        Return EditValue
    End Function

    Private Function CheckExistKeyName(ByVal user_key_name_value As String) As Boolean
        Dim bCheck As Boolean = False
        If (C_DATA_SOURCE Is Nothing) Then
            RaiseEvent FirstBinddata(Me, Nothing)
        End If

        Dim str As String = C_IS_FILTER_STRING
        Dim dt_check As DataTable = GetDataCheck(str, C_DATA_SOURCE)

        For Each dr As DataRow In dt_check.Rows
            If dr(C_KEY_NAME).ToString.Equals(user_key_name_value) Then
                bCheck = True
                Exit For
            End If
        Next
        Return bCheck
    End Function

    Function GetDataCheck(ByVal strExpresstion As String, ByVal DataSource As DataTable) As DataTable
        Dim dt_check As DataTable = DataSource.Clone
        If Not String.IsNullOrEmpty(strExpresstion) Then
            Dim dataRowFilter As DataRow() = C_DATA_SOURCE.Select(strExpresstion)

            If dataRowFilter.Length >= 0 Then
                For Each row As DataRow In dataRowFilter
                    dt_check.ImportRow(row)
                Next
            End If
        Else
            dt_check = C_DATA_SOURCE
        End If

        Return dt_check
    End Function

    Private Sub GetDataByKeyName(ByVal user_key_name_value As String)

        'For value in TextBox mapped with one KEYNAME in Database
        Dim bCheck As Boolean = False
        Dim arr_col_return() As String = C_ARR_COLS_RETURN.Split(";")

        If (C_DATA_SOURCE Is Nothing) Then
            RaiseEvent FirstBinddata(Me, Nothing)
        End If

        _ListEditValue = New List(Of String)
        Dim row As DataRow = Nothing

        For Each dr As DataRow In GetDataCheck(C_IS_FILTER_STRING, C_DATA_SOURCE).Rows
            If dr(C_KEY_NAME).ToString.Equals(user_key_name_value) Then
                row = dr
                bCheck = True
                Exit For
            End If
        Next

        If RepositoryCommonFunctions.CheckChiTietForPopup(C_KEY_NAME, user_key_name_value, C_DATA_SOURCE, C_IS_CHECK_NUMBER, C_IS_CHECK_STRING, C_IS_CHECK_OTHER) Then
            If bCheck = True Then
                For Each info As String In arr_col_return
                    _ListEditValue.Add(row(info).ToString)
                Next
                RaiseEvent AfterFilter(Me, Nothing)
            ElseIf bCheck = False Then
                For Each info As String In arr_col_return
                    _ListEditValue.Add("")
                Next
                RaiseEvent ClearFilterData(Me, Nothing)
            End If
        Else
            For Each info As String In arr_col_return
                _ListEditValue.Add("")
            Next
            RaiseEvent ClearFilterData(Me, Nothing)
        End If

    End Sub

    Public Sub AfterSetTag()
        If HasCheck Then
            Return
        End If

        Dim arr_ColsReturn() As String = C_ARR_COLS_RETURN.Split(";")

        If (C_DATA_SOURCE Is Nothing) Then
            RaiseEvent FirstBinddata(Me, Nothing)
        End If

        If Not Me.Tag Is Nothing Then
            If Not Me.Tag.ToString.Equals("") Then
                RaiseEvent BeforeFilter(Nothing, Nothing)
                Dim obj_id_value As String = Me.Tag.ToString
                Dim obj_id_field As String = arr_ColsReturn(0)
                _ListEditValue = New List(Of String)
                For Each dr As DataRow In C_DATA_SOURCE.Rows
                    If dr(obj_id_field).ToString.Equals(obj_id_value) Then
                        For Each info As String In arr_ColsReturn
                            _ListEditValue.Add(dr(info).ToString)
                        Next
                        Exit For
                    End If
                Next
            End If
        Else
            _ListEditValue = New List(Of String)
            For Each info As String In arr_ColsReturn
                _ListEditValue.Add("")
            Next
        End If
    End Sub
#End Region

#Region "Validation"
    Protected Overrides Sub OnValidating(ByVal e As System.ComponentModel.CancelEventArgs)
        'If (_AllowNull) Then
        '    If ((txtKeyWord.Tag Is Nothing Or String.IsNullOrEmpty(txtKeyWord.Tag)) And Not String.IsNullOrEmpty(txtKeyWord.Text)) Then
        '        dx.SetError(Me, "Truong bat buoc nhap")
        '        e.Cancel = True
        '    Else
        '        dx.SetError(Me, "")
        '        e.Cancel = False
        '    End If
        'End If
        MyBase.OnValidating(e)
    End Sub

#End Region
End Class
