Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraEditors
Imports DevExpress.Data.Filtering
Imports DevExpress.XtraGrid.Views.Base
Imports System.Reflection
Imports Microsoft.VisualBasic
Imports System.Windows.Forms

Public Class MultiFilterPopup

#Region "Variables"
    Private IS_QUICKADD As Boolean = False
    Private FORM_DANHSACH As String = ""
    Private FORM_TITLE As String = ""
    Private DATASOURCE As DataTable = Nothing
    Private KEYWORD As String = ""
    Private KEYNAME As String = ""
    Private COLS_RETURN As String = ""
    Private COLS_DISPLAY As String = ""
    Private FILTER_STRING As String = ""
    Private LIST_CHK As List(Of CheckEdit)
    Private FILTER_HELPER As GridViewFilterHelper
    Private IS_CHECK_NUMBER As String = ""
    Private IS_CHECK_STRING As String = ""
    Private IS_CHECK_OTHER As String = ""
    Private IS_FILTER_STRING As String = ""
    Private IS_SORT_ORDER_STRING As String = ""
    Public IS_CHOISE_OK As Boolean = False
    Private _IS_ADDNEW As Boolean
    Private _MAIN_RETURN_VALUE As String = ""
    Private _LIST_EDIT_VALUE As New List(Of String)
    Private _QUICK_ADD_SUCCESS As Boolean = False

    Public Property QUICK_ADD_SUCCESS() As Boolean
        Get
            Return _QUICK_ADD_SUCCESS
        End Get
        Set(ByVal value As Boolean)
            _QUICK_ADD_SUCCESS = value
        End Set
    End Property

    Public Property LIST_EDIT_VALUE() As List(Of String)
        Get
            Return _LIST_EDIT_VALUE
        End Get
        Set(ByVal value As List(Of String))
            _LIST_EDIT_VALUE = value
        End Set
    End Property

    Public Property MAIN_RETURN_VALUE() As String
        Get
            Return _MAIN_RETURN_VALUE
        End Get
        Set(ByVal value As String)
            _MAIN_RETURN_VALUE = value
        End Set
    End Property

    Public Property IS_ADDNEW() As Boolean
        Get
            Return _IS_ADDNEW
        End Get
        Set(ByVal value As Boolean)
            _IS_ADDNEW = value
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
#End Region

#Region "Event Handles"

    Public Sub New()
        InitializeComponent()
    End Sub

    Public Sub New(ByVal title As String, ByVal ds As DataTable, ByVal key_word As String, ByVal col_display As String, ByVal key_name As String, ByVal col_return As String, ByVal isQuickAdd As Boolean, ByVal form_ds As String, ByVal check_number As String, ByVal check_string As String, ByVal check_other As String, ByVal filter_string As String, ByVal sort_order_string As String)
        InitializeComponent()
        FORM_TITLE = title
        KEYWORD = key_word
        DATASOURCE = ds
        COLS_DISPLAY = col_display
        KEYNAME = key_name
        COLS_RETURN = col_return
        IS_QUICKADD = isQuickAdd
        FORM_DANHSACH = form_ds 'now is form_chitiet_name
        IS_CHECK_NUMBER = check_number
        IS_CHECK_STRING = check_string
        IS_CHECK_OTHER = check_other
        IS_FILTER_STRING = filter_string
        IS_SORT_ORDER_STRING = sort_order_string
    End Sub

    Private Sub MultiFilterPopup_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

            InitControl()
            BindData()
            GetListCheckEdit()
            FILTER_HELPER = New GridViewFilterHelper(grvMain, LIST_CHK)
            AddHandler txtKeyWord.EditValueChanged, AddressOf txtKeyWord_EditValueChanged
            DoFirst()
            DoSecond()
            'Me.DialogResult = DialogResult.Cancel
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub txtKeyWord_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            FILTER_HELPER.ActiveFilter = txtKeyWord.Text
            grvMain.ApplyColumnsFilter()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub MultiFilterPopup_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If (e.Alt = True) AndAlso (e.KeyCode = Keys.F3) Then
            If IS_QUICKADD = True Then
                ThemNhanh()
            End If
        ElseIf (e.Control = True) AndAlso (e.KeyCode = Keys.S) Then
            SetValue()
            Me.DialogResult = DialogResult.OK
            Me.Close()
        ElseIf e.KeyCode = Keys.Enter Then
            btnSubmit.PerformClick()
        ElseIf e.KeyCode = Keys.Escape Then
            Me.DialogResult = DialogResult.Cancel
        End If
    End Sub

    Private Sub grcMain_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles grcMain.KeyDown
        If e.KeyCode = Keys.Enter Then
            'btnSubmit.Select()
        ElseIf (e.KeyCode <> Keys.Up) AndAlso (e.KeyCode <> Keys.Down) AndAlso (e.KeyCode <> Keys.Back) Then
            txtKeyWord.Focus()
            txtKeyWord.Text = txtKeyWord.Text + Chr(e.KeyCode)
            txtKeyWord.SelectionStart = txtKeyWord.Text.Length
        ElseIf e.KeyCode = Keys.Back Then
            Try
                txtKeyWord.Text = txtKeyWord.Text.Substring(0, txtKeyWord.Text.Length - 1)
            Catch
                txtKeyWord.Text = ""
            End Try
            txtKeyWord.Focus()
            txtKeyWord.SelectionStart = txtKeyWord.Text.Length
        End If
    End Sub

    Private Sub txtKeyWord_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtKeyWord.KeyDown
        If e.KeyCode = Keys.Up Then
            grcMain.Select()
            grvMain.SelectRow(0)
        ElseIf e.KeyCode = Keys.Down Then
            grcMain.Select()
            grvMain.SelectRow(0)
        End If
    End Sub

#End Region

#Region "Common Function"
    Private Sub InitControl()
        'Form Title
        Me.Text = FORM_TITLE

        'Show quick add
        IS_ADDNEW = False
        If IS_QUICKADD = False Then
            btnQuickAdd.Visible = False
        End If

        'Bind Keyword
        txtKeyWord.Text = KEYWORD

        'Bind Columns
        grvMain.Columns.Clear()
        Dim arrColsDisplay() As String = COLS_DISPLAY.Split(";")

        For Each info As String In arrColsDisplay
            Dim is_visible As Integer = Convert.ToInt32(info.Split("-")(3))
            If is_visible = 0 Then 'Hide
                Dim g_col As GridColumn = grvMain.Columns.AddVisible(info.Split("-")(0), info.Split("-")(1))
                g_col.Visible = False
            ElseIf is_visible = 1 Then 'Visible
                grvMain.Columns.AddVisible(info.Split("-")(0), info.Split("-")(1))
            End If
        Next

        'Set Property
        grvMain.OptionsView.ShowFilterPanelMode = ShowFilterPanelMode.Never
        For Each gridCol As GridColumn In grvMain.Columns
            gridCol.OptionsFilter.AllowFilter = False
        Next

        'Bind CheckEdit
        'Nothing
    End Sub

    Private Sub BindData()
        If Not IS_FILTER_STRING.Equals("") Then
            Dim dtFilter As DataTable = DATASOURCE.Copy()
            dtFilter.Rows.Clear()
            Dim listColName As New List(Of String)
            For Each col As DataColumn In dtFilter.Columns
                listColName.Add(col.ColumnName)
            Next
            Dim rowFilter() As DataRow = DATASOURCE.Select(IS_FILTER_STRING, IS_SORT_ORDER_STRING)
            For Each dtRow As DataRow In rowFilter
                Dim _newRow As DataRow = dtFilter.NewRow()
                For Each colName As String In listColName
                    _newRow(colName) = dtRow(colName)
                Next
                dtFilter.Rows.Add(_newRow)
            Next
            grcMain.DataSource = dtFilter.DefaultView
        Else
            grcMain.DataSource = DATASOURCE
        End If
        For Each col As GridColumn In grvMain.Columns
            col.OptionsColumn.AllowEdit = False
            col.OptionsColumn.ReadOnly = True
        Next
    End Sub

    Private Sub GetListCheckEdit()
        LIST_CHK = New List(Of CheckEdit)
        For Each control As Control In pcTop.Controls
            If control.GetType().Name.Equals("CheckEdit") Then
                Dim chk As CheckEdit = CType(control, CheckEdit)
                LIST_CHK.Add(chk)
            End If
        Next
    End Sub

    Private Sub SetValue()
        Try
            If RepositoryCommonFunctions.CheckChiTiet(grvMain.GetFocusedDataRow(), IS_CHECK_NUMBER, IS_CHECK_STRING, IS_CHECK_OTHER, _MessageWarning) Then
                IS_CHOISE_OK = True
                MAIN_RETURN_VALUE = grvMain.GetFocusedDataRow()(KEYNAME).ToString()
                Dim arrColsReturn() As String = COLS_RETURN.Split(";")
                LIST_EDIT_VALUE.Clear()
                For Each colReturn As String In arrColsReturn
                    LIST_EDIT_VALUE.Add(grvMain.GetFocusedDataRow()(colReturn).ToString())
                Next
            Else
                IS_CHOISE_OK = False
                Return
            End If
        Catch ex As Exception
            MAIN_RETURN_VALUE = ""
            LIST_EDIT_VALUE = New List(Of String)
        End Try
    End Sub

    Private Sub SetValue(ByVal obj_return As Object)
        Try
            Dim arrPros() As PropertyInfo = obj_return.GetType().GetProperties()
            For Each pInfo As PropertyInfo In arrPros
                If pInfo.Name.Equals(KEYNAME) Then
                    MAIN_RETURN_VALUE = pInfo.GetValue(obj_return, Nothing).ToString
                    Exit For
                End If
            Next

            Dim arrColsReturn() As String = COLS_RETURN.Split(";")
            For Each colReturn As String In arrColsReturn
                For Each ppInfo As PropertyInfo In arrPros
                    If ppInfo.Name.Equals(colReturn) Then
                        LIST_EDIT_VALUE.Add(ppInfo.GetValue(obj_return, Nothing).ToString)
                        Exit For
                    End If
                Next
            Next

        Catch ex As Exception
            MAIN_RETURN_VALUE = ""
            LIST_EDIT_VALUE = New List(Of String)
        End Try
    End Sub

    Private Sub DoFirst()
        FILTER_HELPER.ActiveFilter = txtKeyWord.Text
        grvMain.ApplyColumnsFilter()
    End Sub

    Private Sub DoSecond()
        grcMain.Select()
        grvMain.SelectRow(0)
    End Sub

    Private Function ShowQuickAdd() As Object
        Try
            'FORM_DANHSACH now name is form_chi_tiet_name
            Dim frmDS As FrmBaseDmDanhSach = CType(ObjectFactory.GetObject(FORM_DANHSACH), FrmBaseDmDanhSach)
            'Dim methodName As String = "QuickAddObject"
            'Dim typeForm As Type = frmDS.GetType()
            'Dim methodInfo As Reflection.MethodInfo = typeForm.GetMethod(methodName)
            'Dim objValue As Object = methodInfo.Invoke(frmDS, Nothing) 'ObjectInfo
            Return frmDS.QuickAddObject()
            'Return objValue
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Private Sub GetDataReturnForAdd(ByVal objGet As Object, ByVal listColReturn As String)
        Dim arrColsReturn() As String = listColReturn.Split(";")
        Dim arrProperties() As PropertyInfo = objGet.GetType().GetProperties()
        For Each pInfo As PropertyInfo In arrProperties
            If pInfo.Name.Equals(KEYNAME) Then
                MAIN_RETURN_VALUE = pInfo.GetValue(objGet, Nothing)
                Exit For
            End If
        Next
        LIST_EDIT_VALUE.Clear()
        For Each colReturn As String In arrColsReturn
            For Each pInfo As PropertyInfo In arrProperties
                If pInfo.Name.Equals(colReturn) Then
                    LIST_EDIT_VALUE.Add(pInfo.GetValue(objGet, Nothing).ToString())
                    Exit For
                End If
            Next
        Next
    End Sub
#End Region

#Region "Control Handles"
    Private Sub btnCancal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancal.Click
        Me.Close()
    End Sub

    Private Sub btnSubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSubmit.Click
        SetValue()
        If IS_CHOISE_OK = True Then
            Me.DialogResult = DialogResult.OK
            Me.Close()
        Else
            Return
        End If
    End Sub

    Private Sub btnQuickAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuickAdd.Click
        ThemNhanh()
    End Sub

    Private Sub ThemNhanh()
        Dim obj_return As Object = ShowQuickAdd()
        If Not obj_return Is Nothing Then
            QUICK_ADD_SUCCESS = True
            IS_CHOISE_OK = True
            GetDataReturnForAdd(obj_return, COLS_RETURN)
            Me.DialogResult = DialogResult.OK
            Me.Close()
        End If
    End Sub
#End Region

    Private Sub MultiFilterPopup_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        If Not (Me.IS_CHOISE_OK) Then
            Me.DialogResult = DialogResult.Cancel
        End If
    End Sub
End Class