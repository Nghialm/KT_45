Imports System.Reflection
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.DXErrorProvider
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Views.Grid
Imports Microsoft.Win32
Imports System.Windows.Forms
Imports System
Imports System.IO

'Imports KTY.ObjectInfo
Imports System.Net.Mail
Imports DevExpress.Utils
Imports System.Drawing

Public Class ListBoxItem
    'Class phục vụ cho việc bind list từ IDataReader
    Dim _DisplayField As String
    Dim _ValueField As String

    Public Sub New()

    End Sub

    Public Sub New(ByVal iValue As String, Optional ByVal sName As String = "")
        _DisplayField = sName
        _ValueField = iValue
    End Sub

    Public Property DisplayField() As String
        Get
            Return _DisplayField
        End Get
        Set(ByVal Value As String)
            _DisplayField = Value
        End Set
    End Property

    Public Property ValueField() As String
        Get
            Return _ValueField
        End Get
        Set(ByVal Value As String)
            _ValueField = Value
        End Set
    End Property
End Class

'Column for LookupEdit and GridLookupEdit
Public Class LookupEdit_ColumnInfo
    Private _FieldName As String
    Private _FieldLabel As String
    Private _Width As Integer = 0

    Public Sub New(ByVal sFieldName As String, ByVal sFieldLabel As String, Optional ByVal iWidth As Integer = 0)
        _FieldName = sFieldName
        _FieldLabel = sFieldLabel
        _Width = iWidth
    End Sub

    Public Property FieldName() As String
        Get
            Return _FieldName
        End Get
        Set(ByVal value As String)
            _FieldName = value
        End Set
    End Property

    Public Property FieldLabel() As String
        Get
            Return _FieldLabel
        End Get
        Set(ByVal value As String)
            _FieldLabel = value
        End Set
    End Property

    Public Property Width() As String
        Get
            Return _Width
        End Get
        Set(ByVal value As String)
            _Width = value
        End Set
    End Property
End Class

Public Module FormGlobals
    Public Sub SetCultureInfo(ByVal mThread As System.Threading.Thread)
        'Set khuôn dạng Date và Number cho 1 thread
        Dim dtfi As New System.Globalization.DateTimeFormatInfo
        Dim nfi As New System.Globalization.NumberFormatInfo
        Try
            nfi.NumberDecimalSeparator = CS_DECIMAL_SYMBOL
            nfi.NumberGroupSeparator = CS_DIGIT_GROUP_SYMBOL
            dtfi.ShortDatePattern = CS_DISPLAY_DATE_FORMAT
            mThread.CurrentCulture = New System.Globalization.CultureInfo("en-US") '
            mThread.CurrentCulture.DateTimeFormat = dtfi
            mThread.CurrentCulture.NumberFormat = nfi
        Catch ex As Exception
            Message_Error(ex)
        End Try

    End Sub

#Region "Private declare"
    Private Structure FormField
        Dim FieldName As String
        Dim ControlType As String
        Dim ControlName As String
        Dim DataLength As Integer
        Dim DataType As String
        Dim Required As Boolean
        Dim MaxValue As Object
        Dim Scale As Object
    End Structure

    Private Structure FormProperty
        Dim ControlBox As Boolean
        Dim FormBorderStyle As Windows.Forms.FormBorderStyle
        Dim ShowIcon As Boolean
        Dim ShowInTaskbar As Boolean
        Dim StartPosition As FormStartPosition
        Dim Location As Point
        Dim Size As Size
    End Structure

    Public Enum DataInputState
        BrowseMode = 0
        ViewMode = 1
        EditMode = 2
        AddMode = 4
        CopyMode = 8
        VersionMode = 16
        NoCaption = 17
        Delete = 99
    End Enum

    Public Enum DinhMucType
        SanPham = 1
        VatTu = 2
    End Enum

    Public Enum DataType
        TypeString = 0
        TypeDate = 1
        TypeTime = 2
        TypeUSD = 4
        TypeVND = 5
    End Enum

    Public Structure FormControlExt
        Public Required As Boolean
        Public FieldName As String
        Public DescFieldName As String
        Public DescFieldObject As Object
        Public HandleObject As Object
        Public Tag As Object
    End Structure

    Public Delegate Function GetField_Invoker(ByVal sTable As String) As DataTable
    Public GetField_Function As GetField_Invoker
    Public CS_FONT_NAME As String = "Tahoma"
    Dim mFieldCache As New Dictionary(Of String, List(Of FormField))
    Dim mTableCache As New Dictionary(Of String, DataTable)
#End Region

#Region " Dành cho Message_ "
    Public Function Message_Delete(ByVal objType As String, Optional ByVal sObjName As String = "") As Boolean
        'Hàm confirm khi xóa dữ liệu
        Return (MessageBox.Show("Are you sure you want to delete " & objType & IIf(sObjName = "", "", " '" & sObjName & "'"), Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes)
    End Function

    Public Function Message_InputText(ByVal objType As String, Optional ByVal sObjName As String = "") As Boolean
        'Hàm confirm yeu cau nhap du lieu
        Return (MessageBox.Show(objType & IIf(sObjName = "", "", "" & sObjName & " !"), Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information) = DialogResult.Yes)
    End Function

    Public Function Message_Confirm(ByVal sMessage As String, Optional ByVal bShowRetry As Boolean = False) As Boolean
        'Hàm hiện message confirm 
        If bShowRetry Then
            Return (MessageBox.Show(sMessage, Application.ProductName, MessageBoxButtons.RetryCancel, MessageBoxIcon.Question) = DialogResult.Retry)
        Else
            Return (MessageBox.Show(sMessage, Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes)
        End If
    End Function

    Public Function Message_YesNoCancel(ByVal sMessage As String) As DialogResult
        'Hàm hiện message YesNoCancel
        Return MessageBox.Show(sMessage, Application.ProductName, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
    End Function

    Public Sub Message_Information(ByVal sMessage As String)
        ' Write noi dung exception ra log file
        ' Dung module log4net duoc cau hinh truoc trong file app.config
        'Log.WriteLog(Log.LogLevel.INFO, sMessage)

        'Thủ tục hiện message information
        MessageBox.Show(sMessage, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Public Sub Message_Warning(ByVal sMessage As String)
        ' Write noi dung exception ra log file
        ' Dung module log4net duoc cau hinh truoc trong file app.config
        Log.WriteLog(Log.LogLevel.WARN, sMessage)

        'Thủ tục hiện message warning
        MessageBox.Show(sMessage, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
    End Sub

    Public Sub Message_Error(ByVal ex As Exception)
        Message_Error(ex, "")
    End Sub

    Public Sub Message_Error(ByVal ex As Exception, ByVal sDesc As String)
        ' Write noi dung exception ra log file
        ' Dung module log4net duoc cau hinh truoc trong file app.config
        'Log.WriteLog(Log.LogLevel.ERR, ex)

        ' ------------------ Khong show exception cho user & shutdown/restart chuong trinh ------------------
        '' Create custom common error message
        'Dim sCaption As String = Application.ProductName
        'Dim sMessage As String = "Xảy ra lỗi hệ thống. Chương trình sẽ kết thúc. Xin hãy liên hệ với người quản trị hệ thống!"

        '' Display custom common error message to user
        'MessageBox.Show(sMessage, sCaption, MessageBoxButtons.OK, MessageBoxIcon.Error)

        '' Stop and shutdown application
        'Application.Exit()
        ' ------------------ Khong show exception cho user & shutdown/restart chuong trinh ------------------


        ' ------------------ Tam thoi dung show message cho user Dev & Tester ------------------
        Dim sMessage As String
        If Not String.IsNullOrEmpty(sDesc) Then
            sMessage = "Description: " + sDesc + vbCr
        Else
            sMessage = String.Empty
        End If

        sMessage += "Message: " + ex.Message.Replace(vbCrLf, vbCr + "     ")
        sMessage += vbCr + "Trace: " + ex.StackTrace

        If ex.Message.Substring(0, 9) = "ORA-02292" Then
            MessageBox.Show("Can not delete because integrity contraint", "Delete error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        ElseIf ex.Message.Substring(0, 9) = "ORA-01401" Then
            MessageBox.Show("Inserted value too large", "Data error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        Else
            MessageBox.Show(sMessage, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
        ' ------------------ Tam thoi dung show message cho user Dev & Tester ------------------
    End Sub
#End Region

#Region " Dành cho Form_ "
    Public Sub Form_InitDialog(ByVal f As Form, Optional ByVal bShowInTaskbar As Boolean = False)
        f.StartPosition = FormStartPosition.CenterParent
        f.ShowInTaskbar = bShowInTaskbar
        f.FormBorderStyle = FormBorderStyle.FixedDialog
        f.MinimizeBox = False
        f.MaximizeBox = False
    End Sub

    Public Sub Form_BeginInit(ByRef objForm As Form, Optional ByVal KeepProperty As Boolean = False)
        With objForm
            If KeepProperty Then
                Dim p As New FormProperty
                p.ControlBox = .ControlBox
                p.FormBorderStyle = .FormBorderStyle
                p.Location = .Location
                p.ShowIcon = .ShowIcon
                p.ShowInTaskbar = .ShowInTaskbar
                p.Size = .Size
                p.StartPosition = .StartPosition
                .Tag = p
            End If
            objForm.ControlBox = False
            objForm.ShowIcon = False
            objForm.ShowInTaskbar = False
            objForm.StartPosition = FormStartPosition.Manual
            objForm.WindowState = FormWindowState.Normal
            objForm.Location = New Point(Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height)
            objForm.FormBorderStyle = Windows.Forms.FormBorderStyle.None
            objForm.Show()
        End With
    End Sub

    Public Sub Form_EndInit(ByVal objForm As Form)
        objForm.Hide()
        If TypeOf objForm.Tag Is FormProperty Then
            Dim p As FormProperty = objForm.Tag
            With objForm
                .ControlBox = p.ControlBox
                .FormBorderStyle = p.FormBorderStyle
                .ShowIcon = p.ShowIcon
                .ShowInTaskbar = p.ShowInTaskbar
                .Size = p.Size
                If p.StartPosition = FormStartPosition.Manual Then
                    .Location = p.Location
                Else
                    .Location = Nothing
                End If
                .StartPosition = p.StartPosition
            End With
        End If
    End Sub

    Public Sub Form_SetText(ByVal f As Form, ByVal sFunctionName As String, _
        Optional ByVal mDataInputState As DataInputState = DataInputState.BrowseMode, _
        Optional ByVal sDescText As String = "") 'As String
        'Purpose: 
        '   Set caption text cho form show in tab
        'Parameters: 
        '   sFunctionName : tên chức năng
        '   mDataInputState: trạng thái nhập liệu (trường hợp form Browse sẽ = Nothing) 
        '   sDescText : ghi chú (thường là mã hoặc tên của đối tượng, nếu AddNew thì để trống)
        'Notes
        '               
        Dim sReturn As String
        sReturn = sFunctionName.Trim

        Select Case mDataInputState
            Case DataInputState.BrowseMode
                sReturn += " [Browse]"
            Case DataInputState.AddMode
                sReturn += " [Thêm mới"
            Case DataInputState.EditMode
                sReturn += " [Chỉnh sửa"
            Case DataInputState.ViewMode
                sReturn += " [Xem"
            Case DataInputState.CopyMode
                sReturn += " [Copy"
            Case DataInputState.VersionMode
                sReturn += " [New Version"
            Case DataInputState.NoCaption

        End Select
        If mDataInputState <> DataInputState.BrowseMode Then
            If sDescText.Length > 0 Then
                sReturn += " " + sDescText.Trim + "]"
            Else
                If mDataInputState <> DataInputState.NoCaption Then
                    sReturn += "]"
                End If
            End If
        End If
        f.Text = sReturn
    End Sub

    Public Function Form_GetToolTip(ByVal f As Form) As ToolTip
        Dim ctlDummy As Control = f.Controls(f.Name + "_ToolTip")
        Dim objToolTip As ToolTip
        If ctlDummy Is Nothing Then
            ctlDummy = New Control
            ctlDummy.Name = f.Name + "_ToolTip"
            f.Controls.Add(ctlDummy)
            objToolTip = New ToolTip
            objToolTip.ToolTipIcon = ToolTipIcon.Info
            objToolTip.IsBalloon = True
            objToolTip.UseAnimation = True
            objToolTip.UseFading = True
            objToolTip.AutoPopDelay = 3000
            ctlDummy.Tag = objToolTip
        Else
            objToolTip = ctlDummy.Tag
        End If
        Return objToolTip
    End Function

    Public Function Form_GetErrorProvider(ByVal f As Form) As DXErrorProvider
        Dim ctlDummy As Control = f.Controls(f.Name + "_DXErrorProvider")
        Dim objErrorProvider As DXErrorProvider
        If ctlDummy Is Nothing Then
            ctlDummy = New Control
            ctlDummy.Name = f.Name + "_DXErrorProvider"
            f.Controls.Add(ctlDummy)
            objErrorProvider = New DXErrorProvider
            ctlDummy.Tag = objErrorProvider
        Else
            objErrorProvider = ctlDummy.Tag
        End If
        Return objErrorProvider
    End Function

    Public Function Form_GetDXErrorProvider(ByVal f As Form) As DXErrorProvider
        Dim ctlDummy As Control = f.Controls(f.Name + "_DXErrorProvider")
        Dim objErrorProvider As DXErrorProvider
        If ctlDummy Is Nothing Then
            ctlDummy = New Control
            ctlDummy.Name = f.Name + "_DXErrorProvider"
            f.Controls.Add(ctlDummy)
            objErrorProvider = New DXErrorProvider
            ctlDummy.Tag = objErrorProvider
        Else
            objErrorProvider = ctlDummy.Tag
        End If
        Return objErrorProvider
    End Function
#End Region

#Region " Dành cho Control_ "

    Public Sub Control_InitByField(ByVal objControl As Control, ByVal sTableName As String, ByVal sFieldName As String)
        'Purpose: 
        '   Tự động đặt kiểu dữ liệu, độ dài, required cho 1 control nhập liệu theo TableName và Field Name
        'Parameters: 
        '   objControl : đối tượng chứa các ô nhập liệu
        '   sTableName : tên Table tương ứng với form nhập liệu
        'Notes:
        '   Chỉ dùng khi set cho 1 field lẻ
        'Dim mDataTable As DataTable
        'Try
        '    mDataTable = GetTableField(sTableName)
        '    Dim dtRow As DataRow = mDataTable.Rows.Find(sFieldName)
        '    If Not dtRow Is Nothing Then
        '        Dim mFormField As New FormField
        '        mFormField.ControlType = TypeName(objControl)
        '        SetControlField(objControl, mFormField, dtRow)
        '    Else
        '        Throw New Exception("Field not found")
        '    End If
        'Catch
        '    Throw
        'End Try
    End Sub

    Public Sub Control_SetValue(ByVal ctlSource As Control, ByRef objDest As Object)
        'Purpose: 
        '   Sử dụng để lấy giá trị từ Control 
        'Parameters: 
        '   objSource : dữ liệu nguồn
        '   objDest   : dữ liệu đích
        'Notes:
        '   Thường dùng khi lấy giá trị trên Form nhập liệu để ghi vào CSDL
        '   Hỗ trợ nguồn là TextBox hoặc ComboBox
        Dim sValue As Object
        'Dành cho DevExpress
        If TypeOf ctlSource Is TextEdit Then
            sValue = ctlSource.Text
        ElseIf TypeOf ctlSource Is LookUpEdit Then
            sValue = ctlSource.Text
        ElseIf TypeOf ctlSource Is TextBox Then
            sValue = ctlSource.Text
        ElseIf TypeOf ctlSource Is System.Windows.Forms.ComboBox Then
            sValue = Combo_GetValue(ctlSource)
            'Chặn trường hợp là ITEM_NULL
            If Not IsDBNull(sValue) AndAlso sValue = COMBO_ITEM_NULL_VALUE Then
                objDest = Null.SetNull(DBNull.Value, objDest)
                Exit Sub
            End If
        Else
            Throw New Exception(String.Format("Control type '{0}' isn't support", ctlSource.GetType.Name))
        End If
        Object_SetValue(sValue, objDest)
    End Sub

    Public Sub Control_SetFont(ByVal objControl As Control, ByVal sFont As String)
        objControl.Font = New Font(sFont, objControl.Font.Size, objControl.Font.Style)
    End Sub

    Public Sub Control_SetFlat(ByVal objControl As Control)
        If objControl.HasChildren Then
            For Each objChild As Control In objControl.Controls
                Control_SetFlat(objChild)
            Next
        End If
        '
        Dim bDrawRect As Boolean = False
        '
        If TypeOf objControl Is TextBox Then
            DirectCast(objControl, TextBox).BorderStyle = BorderStyle.FixedSingle
        ElseIf TypeOf objControl Is Button Then
            DirectCast(objControl, Button).FlatStyle = FlatStyle.Flat
        ElseIf TypeOf objControl Is CheckBox Then
            DirectCast(objControl, CheckBox).FlatStyle = FlatStyle.Flat
        ElseIf TypeOf objControl Is RadioButton Then
            DirectCast(objControl, RadioButton).FlatStyle = FlatStyle.Flat
        ElseIf TypeOf objControl Is System.Windows.Forms.ComboBox Then
            DirectCast(objControl, System.Windows.Forms.ComboBox).FlatStyle = FlatStyle.Flat
            '
            bDrawRect = True
        ElseIf TypeOf objControl Is RichTextBox Then
            DirectCast(objControl, RichTextBox).BorderStyle = BorderStyle.None
            bDrawRect = True
        Else
            Return
        End If
        '
        If Not bDrawRect Then Return
        '
        'If TypeOf objControl.Parent Is GroupBox _
        ' OrElse TypeOf objControl.Parent Is TabPage _
        ' OrElse TypeOf objControl.Parent Is Form _
        ' Then
        'Dim arrControl As String
        'arrControl = objControl.Parent.Tag
        'If arrControl Is Nothing Then
        '    arrControl = objControl.Name
        'Else
        '    If Not arrControl.Contains(objControl.Name) Then
        '        If arrControl <> "" Then
        '            arrControl += ";" + objControl.Name
        '        Else
        '            arrControl = objControl.Name
        '        End If
        '    End If
        'End If
        'objControl.Parent.Tag = arrControl
        '
        objControl.Height -= 2
        '
        Dim lb As New Label
        lb.Name = objControl.Name + "_Flat"
        lb.AutoSize = False
        lb.BorderStyle = BorderStyle.FixedSingle
        lb.Width = objControl.Width
        lb.Height = objControl.Height + 2
        lb.Location = objControl.Location
        objControl.Parent.Controls.Add(lb)
        lb.SendToBack()
        '
        objControl.Left += 1
        objControl.Width -= 2
        objControl.Top += 1
        '
        'AddHandler objControl.Parent.Paint, AddressOf Paint_FlatControl            
        'End If
    End Sub

    'Private Sub Paint_FlatControl(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs)
    '    Dim sControl As String
    '    sControl = sender.Tag
    '    If sControl Is Nothing Then Return
    '    Dim objParent As Control = DirectCast(sender, Control)
    '    Dim arrControl As String() = sControl.Split(";")
    '    Dim objGraphics As Graphics '= sender.CreateGraphics 'objControl.Parent.CreateGraphics
    '    For Each sControl In arrControl
    '        Dim objControl As Control = objParent.Controls(sControl)
    '        If Not objControl.Visible Then Continue For
    '        Dim objRect As New Rectangle(objControl.Left - 1, objControl.Top - 1, objControl.Width + 1, objControl.Height + 1)
    '        objGraphics = sender.CreateGraphics
    '        objGraphics.DrawRectangle(New Pen(Color.Black, 1), objRect)
    '        objGraphics.Dispose()
    '    Next
    '    'objGraphics.Dispose()
    'End Sub

    Public Sub Button_SetState(ByVal objControl As Control, ByVal sState As DataInputState)
        'Purpose: 
        '   'Set trạng thái cho các button theo trạng thái nhập liệu
        'Parameters: 
        '   objControl : đối tượng chứa nhóm Button Control (thường là Panel và GroupBox)
        '   sState: trạng thái nhập liệu
        'Notes
        '            
        For Each mControl As Control In objControl.Controls
            If mControl.Name.IndexOf("cmdAdd") > -1 _
                Or mControl.Name.IndexOf("cmdEdit") > -1 _
                Or mControl.Name.IndexOf("cmdDelete") > -1 _
                Or mControl.Name.IndexOf("cmdAddCopy") > -1 _
                Then
                mControl.Enabled = (sState = DataInputState.ViewMode)
            ElseIf mControl.Name.IndexOf("cmdSave") > -1 _
                Or mControl.Name.IndexOf("cmdOK") > -1 _
                Or mControl.Name.IndexOf("cmdCancel") > -1 _
                Then
                mControl.Enabled = Not (sState = DataInputState.ViewMode)
            End If
        Next
    End Sub

    Public Sub Control_SetState(ByVal objControl As Control, ByVal sState As DataInputState)
        'Purpose: 
        '   'Set trạng thái cho các ô nhập liệu theo trạng thái nhập liệu
        'Parameters: 
        '   objControl : đối tượng chứa nhóm Control (thường là Panel và GroupBox)
        '   sState: trạng thái nhập liệu
        'Notes
        '               
        For Each mControl As Control In objControl.Controls
            Select Case TypeName(mControl)
                Case "TextBox", "ComboBox", "DataGridView"
                    SetControlViewOnly(mControl, True, True, (sState = DataInputState.ViewMode))
                Case "ListBox", "TreeView"
                    If TypeOf mControl.Parent.Parent Is Form Then
                        mControl.Enabled = (sState = DataInputState.ViewMode)
                    Else
                        mControl.Enabled = Not (sState = DataInputState.ViewMode)
                    End If
                Case "Button", "RadioButton", "CheckBox"
                    mControl.Enabled = Not (sState = DataInputState.ViewMode)
                    '=====================================================================
                    '"Phần dành cho DevExpress "
                    '=====================================================================
                Case "TextEdit", "LookUpEdit", "DateEdit", "CheckEdit", "GridLookUpEdit"
                    DirectCast(mControl, DevExpress.XtraEditors.BaseEdit).Properties.ReadOnly = (sState = DataInputState.ViewMode)
                Case Else
                    If mControl.HasChildren Then
                        Control_SetState(mControl, sState)
                    End If
            End Select
        Next
    End Sub
    'Clear data khi nhập bản ghi mới
    Public Sub Control_ClearData(ByVal objControl As Control, Optional ByVal ClearReadOnlyControl As Boolean = False)
        For Each mControl As Control In objControl.Controls
            Select Case TypeName(mControl)
                Case "LookUpEdit"
                    CType(mControl, DevExpress.XtraEditors.LookUpEdit).ItemIndex = 0
                Case "TextBox"
                    CType(mControl, TextBox).Text = ""
                Case "ComboBox"
                    If CType(mControl, System.Windows.Forms.ComboBox).Items.Count > 0 Then
                        CType(mControl, System.Windows.Forms.ComboBox).SelectedIndex = 0
                    End If
                Case "ListBox"
                    If Not TypeOf mControl.Parent.Parent Is Form Then
                        CType(mControl, ListBox).Items.Clear()
                    End If
                Case "TreeView"
                    If Not TypeOf mControl.Parent.Parent Is Form Then
                        CType(mControl, TreeView).Nodes.Clear()
                    End If
                Case "CheckEdit"
                    Dim xControl As CheckEdit = CType(mControl, CheckEdit)
                    If xControl.Properties.ReadOnly Then
                        If ClearReadOnlyControl Then
                            xControl.Checked = False
                        End If
                    Else
                        xControl.Checked = False
                    End If

                Case "TextBoxMaskBox"
                    Dim xControl As TextEdit = CType(objControl, TextEdit)
                    If xControl.Properties.ReadOnly Then
                        If ClearReadOnlyControl Then
                            xControl.Text = ""
                        End If
                    Else
                        xControl.Text = ""
                    End If

                Case "SpinEdit"
                    '/*Added by: AuDH*/
                    Dim spin As SpinEdit = CType(mControl, SpinEdit)
                    If spin.Properties.ReadOnly Then
                        If ClearReadOnlyControl = True Then
                            spin.Value = spin.Properties.MinValue
                        End If
                    Else
                        spin.Value = spin.Properties.MinValue
                    End If

                Case "DateEdit"
                    '/*Added by: AuDH*/
                    'Dim dteEdit As DateEdit = CType(mControl, DateEdit)
                    'If dteEdit.Properties.ReadOnly Then
                    '    If ClearReadOnlyControl Then
                    '        dteEdit.DateTime = Date.Now
                    '    End If
                    'Else
                    '    dteEdit.DateTime = Date.Now
                    'End If
                    CType(mControl, DevExpress.XtraEditors.DateEdit).DateTime = Date.Now

                Case "Button"
                Case "TimeEdit"
                    CType(mControl, TimeEdit).EditValue = DateTime.Now.ToShortTimeString
                Case Else
                    If mControl.HasChildren Then
                        Control_ClearData(mControl)
                    End If
            End Select
        Next
    End Sub

    Public Sub Control_SetViewOnly(ByVal objControl As Control, ByVal bViewOnly As Boolean)
        Control_SetViewOnly(objControl, bViewOnly, True)
    End Sub

    Public Sub Control_SetViewOnly(ByVal objControl As Control, ByVal bViewOnly As Boolean, ByVal bSetChildOnly As Boolean)
        Control_SetViewOnly(objControl, bViewOnly, bSetChildOnly, True)
    End Sub

    Public Sub Control_SetViewOnly(ByVal objControl As Control, ByVal bViewOnly As Boolean, ByVal bSetChildOnly As Boolean, ByVal bForceVisible As Boolean)
        'Purpose: 
        '   Đặt trạng thái ViewOnly cho các ô nhập liệu
        'Parameters: 
        '   objControl : đối tượng Control hoặc đối tượng chứa nhóm Control cần set view only          
        '   bSetChildOnly : chỉ set cho các Child control, không đệ quy để tìm các Child of Child
        '   bForceVisible : không kiểm tra thuộc tính visible
        'Notes
        '                  

        If objControl.HasChildren AndAlso Not TypeOf objControl Is DataGridView Then
            Dim objForm As Form = Nothing
            If Not bForceVisible Then
                objForm = objControl.FindForm
                If Not objForm Is Nothing Then
                    If Not objForm.Visible Then
                        Form_BeginInit(objForm, True)
                    Else
                        objForm = Nothing
                    End If
                End If
            End If

            For Each mControl As Control In objControl.Controls
                SetControlViewOnly(mControl, bSetChildOnly, bForceVisible, bViewOnly)
            Next

            If Not objForm Is Nothing Then
                Form_EndInit(objForm)
            End If
        Else
            SetControlViewOnly(objControl, bSetChildOnly, True, bViewOnly)
        End If
    End Sub

    'Thủ tục dùng để SetViewOnly đệ quy 
    Private Sub SetControlViewOnly(ByVal objControl As Control, ByVal bSetChildOnly As Boolean, Optional ByVal bForceVisible As Boolean = False, Optional ByVal bSetOn As Boolean = True)
        If Not objControl.HasChildren OrElse TypeOf objControl Is DataGridView Then
            If objControl.Visible Or bForceVisible Then
                'Rẽ nhánh theo kiểu ô nhập liệu
                Select Case TypeName(objControl)
                    Case "TextBox"
                        'Set ReadOnly, BackColor, BorderStyle
                        DirectCast(objControl, TextBox).ReadOnly = bSetOn
                        If bSetOn Then
                            DirectCast(objControl, TextBox).BackColor = System.Drawing.ColorTranslator.FromHtml("#eaeaea")
                            'CType(objControl, TextBox).BorderStyle = BorderStyle.FixedSingle
                        Else
                            DirectCast(objControl, TextBox).BackColor = SystemColors.Window
                            'CType(objControl, TextBox).BorderStyle = BorderStyle.Fixed3D
                        End If
                    Case "ComboBox"
                        'Khởi tạo 1 TextBox ReadOnly để hiển thị thay thế
                        Dim objTextBox As TextBox
                        objTextBox = objControl.Parent.Controls.Item(objControl.Name + "_View")
                        Dim objFlat As Control
                        objFlat = objControl.Parent.Controls.Item(objControl.Name + "_Flat")
                        If bSetOn Then
                            If objTextBox Is Nothing Then
                                objTextBox = New TextBox
                                objTextBox.Location = objControl.Location
                                objTextBox.Size = objControl.Size
                                objTextBox.Anchor = objControl.Anchor
                                objTextBox.Name = objControl.Name + "_View"
                                objControl.Parent.Controls.Add(objTextBox)
                                Control_SetViewOnly(objTextBox, True)
                                If CType(objControl, System.Windows.Forms.ComboBox).FlatStyle = FlatStyle.Flat Then
                                    objTextBox.BorderStyle = BorderStyle.FixedSingle
                                End If
                            End If
                            objTextBox.Visible = True
                            objTextBox.BringToFront()
                            objTextBox.Text = objControl.Text
                        Else
                            If Not objTextBox Is Nothing Then objTextBox.Visible = False
                        End If
                        If Not objFlat Is Nothing Then objFlat.Visible = Not bSetOn
                        objControl.Visible = Not bSetOn
                    Case "Button", "CheckedListBox", "RadioButton", "CheckBox", "TreeView"
                        'Set Enabled cho các Control khác
                        objControl.Enabled = Not bSetOn
                    Case "DataGridView"
                        Dim objGrid As DataGridView = DirectCast(objControl, DataGridView)
                        objGrid.ReadOnly = bSetOn
                        objGrid.AllowUserToAddRows = Not bSetOn
                        objGrid.AllowUserToDeleteRows = Not bSetOn
                        If bSetOn Then
                            objGrid.RowHeadersWidth = 30
                            objGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect
                        Else
                            objGrid.RowHeadersWidth = 45
                            objGrid.SelectionMode = DataGridViewSelectionMode.CellSelect
                        End If
                        For Each mCol As DataGridViewColumn In objGrid.Columns
                            If TypeOf mCol Is DataGridViewButtonColumn Then
                                mCol.Visible = Not bSetOn
                            End If
                        Next
                        '===========================================================
                        'Phần dành cho các DevExpress
                        '===========================================================
                    Case "TextEdit", "LookUpEdit", "DateEdit", "CheckEdit", "GridLookUpEdit"
                        DirectCast(objControl, DevExpress.XtraEditors.BaseEdit).Properties.ReadOnly = bSetOn
                    Case Else
                        'Các trường hợp khác
                        Return 'Bỏ qua
                End Select
                'Invisible require
                If bSetOn Then
                    Dim ctl As Control = objControl.Parent.Controls.Item(objControl.Name + "_Required")
                    If Not ctl Is Nothing Then ctl.Visible = False
                End If
                'Set TabStop
                objControl.TabStop = Not bSetOn
            End If
        Else
            If (objControl.Visible Or bForceVisible) And bSetChildOnly = False Then
                For Each mControl As Control In objControl.Controls
                    SetControlViewOnly(mControl, bSetChildOnly, bForceVisible)
                Next
            End If
        End If
    End Sub

    'Đặt trạng thái ViewOnly cho các nút command
    Public Sub Button_SetViewOnly(ByVal objControl As Control)
        For Each mControl As Control In objControl.Controls
            If Not (mControl.Name = "cmdExit" Or mControl.Name.IndexOf("cmdView") > -1) Then
                mControl.Visible = False
            Else
                mControl.Visible = True
            End If
        Next
    End Sub

    Public Function Control_GetRequire(ByVal mControl As Control) As Boolean
        Dim objFormControl As FormControlExt
        If mControl.Tag Is Nothing Then
            Return False
        Else
            If TypeOf mControl.Tag Is FormControlExt Then
                objFormControl = mControl.Tag
                Return objFormControl.Required
            Else
                Return False
            End If
        End If
    End Function

    Public Sub Control_SetRequire(ByVal mControl As Control, ByVal bSetOnOff As Boolean)
        'Purpose: 
        '   Thủ tục set hoặc unset bắt buộc nhập cho 1 ô nhập liệu TextBox hoặc ComboBox
        'Parameters: 
        '   mControl : đối tượng TextBox hoặc ComboBox
        '   bSetOn   : set required On/Off        
        'Notes:
        '   Auto make require sign and on/off required field

        Dim objFormControl As FormControlExt
        If mControl.Tag Is Nothing Then
            objFormControl = New FormControlExt
        Else
            If TypeOf mControl.Tag Is FormControlExt Then
                objFormControl = mControl.Tag
            Else
                If Not bSetOnOff Then
                    Return
                Else
                    objFormControl = New FormControlExt
                    objFormControl.Tag = mControl.Tag
                End If
            End If
        End If
        Dim sLabelName As String = mControl.Name & "_Required"
        Dim objControl As Control = mControl.Parent.Controls(sLabelName)
        If bSetOnOff Then
            ' /* Tam thoi bo doan code thiet lap dau * truoc cac truong bat buoc */
            'Dim mLabel As Label = objControl

            'If mLabel Is Nothing Then
            '    mLabel = New Label
            '    mLabel.Name = sLabelName
            '    mLabel.AutoSize = True
            '    mLabel.Anchor = mControl.Anchor
            '    mLabel.Text = "*"
            '    mLabel.ForeColor = System.Drawing.Color.OrangeRed
            '    mLabel.Top = mControl.Top
            '    mLabel.Left = mControl.Left - 15
            '    mControl.Parent.Controls.Add(mLabel)
            '    mLabel.Visible = True
            '    mLabel.BringToFront()
            'Else
            '    If objControl.Name = sLabelName And objControl.Text = "*" Then
            '        objControl.Visible = True
            '    End If
            'End If
            objFormControl.Required = True
        Else
            'If Not objControl Is Nothing Then
            '    If objControl.Name = sLabelName And objControl.Text = "*" Then
            '        objControl.Visible = False
            '    End If
            'End If
            objFormControl.Required = False
        End If
        mControl.Tag = objFormControl
    End Sub

    Public Function Control_GetLabel(ByVal mControl As Control)
        Dim sCaption As String = Nothing
        mControl = mControl.Parent.GetNextControl(mControl, False)
        If Not mControl Is Nothing AndAlso TypeOf mControl Is Label Then
            sCaption = mControl.Text.Replace("&", "")
        End If

        If Not mControl Is Nothing AndAlso TypeOf mControl Is LabelControl Then
            sCaption = mControl.Text.Replace("&", "")
        End If

        Return sCaption
    End Function

    'Ham Private dung de de quy SetControlByField
    'Private Function SetControlByField(ByVal objControl As Control, ByVal mReader As DataTable, ByVal sExcepControl As String) As List(Of FormField)
    '    Dim arrControl As New List(Of FormField)
    '    Dim arrReturn As New List(Of FormField)
    '    'Get arr        
    '    Dim mFormField As FormField
    '    Dim mControl As Control

    '    For Each mControl In objControl.Controls
    '        If String.IsNullOrEmpty(mControl.Name) OrElse sExcepControl.Contains(mControl.Name.ToUpper) Then Continue For

    '        If (TypeOf mControl Is TextBox _
    '            OrElse TypeOf mControl Is Windows.Forms.ComboBox _
    '            OrElse TypeOf mControl Is RichTextBox _
    '            OrElse TypeOf mControl Is ComboBoxEdit _
    '            OrElse TypeOf mControl Is TextEdit _
    '            OrElse TypeOf mControl Is SpinEdit _
    '            OrElse TypeOf mControl Is CheckEdit _
    '            OrElse TypeOf mControl Is LookUpEdit _
    '            OrElse TypeOf mControl Is CalcEdit _
    '            OrElse TypeOf mControl Is DateEdit _
    '            OrElse TypeOf mControl Is TimeEdit _
    '            OrElse TypeOf mControl Is MemoEdit _
    '            OrElse TypeOf mControl Is GridLookUpEdit _
    '            ) Then
    '            mFormField = New FormField
    '            mFormField.ControlName = mControl.Name
    '            mFormField.FieldName = mControl.Name.Substring(3).ToUpper
    '            mFormField.ControlType = TypeName(mControl)
    '            arrControl.Add(mFormField)
    '        ElseIf mControl.Controls.Count > 0 Then
    '            Dim arrSub As List(Of FormField) = SetControlByField(mControl, mReader, sExcepControl)
    '            If arrSub.Count > 0 Then arrReturn.AddRange(arrSub)
    '        End If
    '    Next

    '    Dim mDataRow As DataRow

    '    For Each mFormField In arrControl
    '        mDataRow = mReader.Rows.Find(mFormField.FieldName)
    '        'Fix trường hợp là các field _ID hoặc _CODE
    '        If mDataRow Is Nothing AndAlso mFormField.ControlType = "ComboBox" Then
    '            mDataRow = mReader.Rows.Find(mFormField.FieldName & "_ID")
    '            If mDataRow Is Nothing Then
    '                mDataRow = mReader.Rows.Find(mFormField.FieldName & "_CODE")
    '            End If
    '            If mDataRow Is Nothing Then
    '                mDataRow = mReader.Rows.Find(mFormField.FieldName & "ID")
    '            End If
    '            If Not mDataRow Is Nothing Then mFormField.FieldName = mDataRow("COLUMN_NAME")
    '        End If
    '        If Not mDataRow Is Nothing Then
    '            mControl = objControl.Controls(mFormField.ControlName)
    '            SetControlField(mControl, mFormField, mDataRow)
    '            'Lưu lại kết quả tìm được                
    '            arrReturn.Add(mFormField)
    '        End If
    '    Next

    '    Return arrReturn
    'End Function
    'Sử dụng cho lần chạy đầu tiên
    '    Private Sub SetControlField(ByVal mControl As Control, ByRef mFormField As FormField, ByVal mDataRow As DataRow)
    '        Dim mDataType As String = Nothing
    '        Dim iMaxValue As Object = Nothing
    '        '
    '        Dim objFormControl As New FormControlExt

    '        If mFormField.ControlType = "TextBox" Then
    '            mDataType = mDataRow.Item("DATA_TYPE")
    '            If mDataType = "NUMBER" Then
    '                If mDataRow.Item("DATA_SCALE") > 0 Then
    '                    If mDataRow.Item("DATA_LENGTH") > Double.MaxValue.ToString.Length Then
    '                        mDataType = "DOUBLE"
    '                    End If
    '                    iMaxValue = 10 ^ (mDataRow.Item("DATA_LENGTH") - mDataRow.Item("DATA_SCALE") - 1) - 1 / (10 ^ mDataRow.Item("DATA_SCALE"))
    '                Else
    '                    If mDataRow.Item("DATA_LENGTH") > Integer.MaxValue.ToString.Length Or mDataRow.Item("DATA_LENGTH") = 0 Then
    '                        mDataType = "LONG"
    '                    ElseIf mDataRow.Item("DATA_LENGTH") > Short.MaxValue.ToString.Length Then
    '                        mDataType = "INTEGER"
    '                    Else
    '                        mDataType = "SMALLINT"
    '                        iMaxValue = 10 ^ (mDataRow.Item("DATA_LENGTH")) - 1
    '                    End If
    '                End If
    '            End If

    '            Dim txtHandle As New TextBoxHandle(mControl, mDataType, , iMaxValue)
    '            Select Case mDataRow.Item("DATA_TYPE").ToUpper
    '                Case "NVARCHAR2"
    '                    DirectCast(mControl, TextBox).MaxLength = mDataRow.Item("DATA_LENGTH") / 2
    '                Case "CHAR", "VARCHAR2", "NCHAR", "VARCHAR", "NVARCHAR"
    '                    DirectCast(mControl, TextBox).MaxLength = mDataRow.Item("DATA_LENGTH")
    '                Case "CLOB", "NCLOB", "NTEXT", "TEXT"
    '                    DirectCast(mControl, TextBox).MaxLength = Int32.MaxValue
    '                Case "NUMBER"
    '                    If DirectCast(mControl, TextBox).MaxLength > mDataRow.Item("DATA_LENGTH") Then
    '                        DirectCast(mControl, TextBox).MaxLength = mDataRow.Item("DATA_LENGTH")
    '                    End If
    '            End Select

    '            objFormControl.HandleObject = txtHandle
    '            'Hold cache data
    '            mFormField.DataType = mDataType
    '            mFormField.MaxValue = iMaxValue
    '            mFormField.DataLength = DirectCast(mControl, TextBox).MaxLength
    '        ElseIf mFormField.ControlType = "RichTextBox" Then
    '            DirectCast(mControl, RichTextBox).MaxLength = DB_GetValue(mDataRow.Item("DATA_LENGTH"), Int32.MaxValue)
    '        ElseIf mFormField.ControlType = "ComboBox" Then
    '            If mControl.TabStop Then
    '                Dim cboHandle As New ComboBoxHandle(mControl)
    '                objFormControl.HandleObject = cboHandle
    '            End If
    '            '===================================================================================================
    '            ' Dev Express control - HIEUVT added
    '            '===================================================================================================
    '        ElseIf mFormField.ControlType = "SpinEdit" Then
    '            ' Xu ly SpinEdit
    '            mDataType = mDataRow.Item("DATA_TYPE")
    '            Dim txtSpinEditHandle As New SpinEditHandle(mControl, mDataType, , iMaxValue)
    '            objFormControl.HandleObject = txtSpinEditHandle
    '            'Hold cache data
    '            mFormField.DataType = mDataType
    '            mFormField.MaxValue = iMaxValue
    '            mFormField.DataLength = DirectCast(mControl, SpinEdit).Properties.MaxLength
    '        ElseIf mFormField.ControlType = "TextEdit" Then
    '            ' Xu ly TextEdit
    '            Dim iScale As Integer = DB_GetValue(mDataRow.Item("DATA_SCALE"), 0)
    '            Dim iLength As Integer = DB_GetValue(mDataRow.Item("DATA_LENGTH"), 0)
    '            mDataType = mDataRow.Item("DATA_TYPE").ToUpper

    '            If mDataType = "NUMBER" Then
    '                If iScale > 0 Then
    '                    If iLength > Double.MaxValue.ToString.Length Then
    '                        mDataType = "DOUBLE"
    '                    End If
    '                    iMaxValue = 10 ^ (iLength - iScale - 1) - 1 / (10 ^ iScale)
    '                Else
    '                    If iLength > Integer.MaxValue.ToString.Length Or iLength = 0 Then
    '                        mDataType = "LONG"
    '                    ElseIf iLength > Short.MaxValue.ToString.Length Then
    '                        mDataType = "INTEGER"
    '                    Else
    '                        mDataType = "SMALLINT"
    '                        iMaxValue = 10 ^ (iLength) - 1
    '                    End If
    '                End If
    '            End If
    '            '
    '            Dim txtEditHandle As New TextEditHandle(mControl, mDataType, , iMaxValue)
    '            Select Case mDataType
    '                Case "NVARCHAR2"
    '                    'Chuyen kieu nvarchar2 lay du length trong DB
    '                    DirectCast(mControl, TextEdit).Properties.MaxLength = iLength
    '                    'DirectCast(mControl, TextEdit).Properties.MaxLength = iLength / 2
    '                Case "CHAR", "VARCHAR2", "NCHAR", "VARCHAR", "NVARCHAR"
    '                    DirectCast(mControl, TextEdit).Properties.MaxLength = iLength
    '                Case "CLOB", "NCLOB", "NTEXT", "TEXT"
    '                    DirectCast(mControl, TextEdit).Properties.MaxLength = Int32.MaxValue
    '                Case "NUMBER", "DOUBLE", "LONG", "INTEGER", "SMALLINT"
    '                    If (DirectCast(mControl, TextEdit).Properties.MaxLength = 0) _
    '                            Or (DirectCast(mControl, TextEdit).Properties.MaxLength > iLength) Then
    '                        DirectCast(mControl, TextEdit).Properties.MaxLength = iLength
    '                    End If
    '            End Select
    '            '
    '            objFormControl.HandleObject = txtEditHandle
    '            DirectCast(mControl, TextEdit).EnterMoveNextControl = CS_ENTER_MOVE_NEXT_CONTROL

    '            'Hold cache data
    '            mFormField.DataType = mDataType
    '            mFormField.MaxValue = iMaxValue
    '            mFormField.DataLength = DirectCast(mControl, TextEdit).Properties.MaxLength
    '            mFormField.Scale = iScale
    '        ElseIf mFormField.ControlType = "LookUpEdit" Then
    '            DirectCast(mControl, LookUpEdit).EnterMoveNextControl = CS_ENTER_MOVE_NEXT_CONTROL
    '        ElseIf mFormField.ControlType = "CalcEdit" Then
    '            DirectCast(mControl, CalcEdit).EnterMoveNextControl = CS_ENTER_MOVE_NEXT_CONTROL
    '        ElseIf mFormField.ControlType = "DateEdit" Then
    '            If mFormField.Required Then
    '                DirectCast(mControl, DateEdit).Properties.AllowNullInput = DefaultBoolean.False
    '            Else
    '                DirectCast(mControl, DateEdit).Properties.NullDate = Null.MIN_DATE
    '            End If
    '            DirectCast(mControl, DateEdit).EnterMoveNextControl = CS_ENTER_MOVE_NEXT_CONTROL
    '        ElseIf mFormField.ControlType = "TimeEdit" Then
    '            DirectCast(mControl, TimeEdit).EnterMoveNextControl = CS_ENTER_MOVE_NEXT_CONTROL
    '        ElseIf mFormField.ControlType = "CheckEdit" Then
    '            '
    '        ElseIf mFormField.ControlType = "MemoEdit" Then
    '            '
    '        ElseIf mFormField.ControlType = "GridLookUpEdit" Then
    '            DirectCast(mControl, GridLookUpEdit).EnterMoveNextControl = CS_ENTER_MOVE_NEXT_CONTROL
    '        Else
    '            'Không hỗ trợ các control khác
    '            Throw New Exception("Not support type of control " + mFormField.ControlType)
    '        End If
    '        If Not mControl.Tag Is Nothing Then
    '            'Keep current Tag value, must use GetControlTag for retrieve value
    '            If TypeOf mControl.Tag Is FormControlExt Then
    '                objFormControl.Tag = CType(mControl.Tag, FormControlExt).Tag
    '            Else
    '                objFormControl.Tag = mControl.Tag
    '            End If
    '        End If
    '#If DEBUG Then
    '        mControl.BackColor = Color.LemonChiffon
    '#End If
    '        objFormControl.FieldName = mFormField.FieldName
    '        mControl.Tag = objFormControl
    '        'Hold cache data
    '        mFormField.Required = (mDataRow.Item("NULLABLE") = "N")
    '        If mFormField.Required AndAlso mControl.TabStop Then
    '            Control_SetRequire(mControl, True)
    '        End If
    '    End Sub

    'Sử dụng khi lấy lại thông tin từ Cache

    '    Private Sub SetControlField(ByVal mParentControl As Control, ByVal arrFormField As List(Of FormField))
    '        For Each mFormField As FormField In arrFormField
    '            'Dim arrControl() As Control = mParentControl.Controls.Find(mFormField.ControlName, True)
    '            'If arrControl.Length = 0 Then Continue For
    '            'Dim mControl As Control = arrControl(0)
    '            Dim mControl As Control = Find_Control(mParentControl, mFormField.ControlName)

    '            Dim objFormControl As New FormControlExt
    '            If mFormField.ControlType = "TextBox" Then
    '                Dim txtHandle As New TextBoxHandle(mControl, mFormField.DataType, , mFormField.MaxValue)
    '                DirectCast(mControl, TextBox).MaxLength = mFormField.DataLength
    '                objFormControl.HandleObject = txtHandle
    '            ElseIf mFormField.ControlType = "ComboBox" Then
    '                Dim cboHandle As New ComboBoxHandle(mControl)
    '                objFormControl.HandleObject = cboHandle
    '            ElseIf mFormField.ControlType = "RichTextBox" Then
    '                DirectCast(mControl, RichTextBox).MaxLength = mFormField.DataLength
    '            ElseIf mFormField.ControlType = "TextEdit" Then
    '                Dim txtEditHandle As New TextEditHandle(mControl, mFormField.DataType, , mFormField.MaxValue)
    '                DirectCast(mControl, TextEdit).Properties.MaxLength = mFormField.DataLength
    '                objFormControl.HandleObject = txtEditHandle
    '                DirectCast(mControl, TextEdit).EnterMoveNextControl = CS_ENTER_MOVE_NEXT_CONTROL
    '            ElseIf mFormField.ControlType = "LookUpEdit" Then
    '                DirectCast(mControl, LookUpEdit).EnterMoveNextControl = CS_ENTER_MOVE_NEXT_CONTROL
    '            ElseIf mFormField.ControlType = "CalcEdit" Then
    '                DirectCast(mControl, CalcEdit).EnterMoveNextControl = CS_ENTER_MOVE_NEXT_CONTROL
    '            ElseIf mFormField.ControlType = "DateEdit" Then
    '                If mFormField.Required Then
    '                    DirectCast(mControl, DateEdit).Properties.AllowNullInput = DefaultBoolean.False
    '                Else
    '                    DirectCast(mControl, DateEdit).Properties.NullDate = Null.MIN_DATE
    '                End If
    '                DirectCast(mControl, DateEdit).EnterMoveNextControl = CS_ENTER_MOVE_NEXT_CONTROL
    '            ElseIf mFormField.ControlType = "TimeEdit" Then
    '                DirectCast(mControl, TimeEdit).EnterMoveNextControl = CS_ENTER_MOVE_NEXT_CONTROL
    '            ElseIf mFormField.ControlType = "CheckEdit" Then
    '                '
    '            ElseIf mFormField.ControlType = "MemoEdit" Then
    '                '
    '            ElseIf mFormField.ControlType = "GridLookUpEdit" Then
    '                DirectCast(mControl, GridLookUpEdit).EnterMoveNextControl = CS_ENTER_MOVE_NEXT_CONTROL
    '            Else
    '                'Không hỗ trợ các control khác
    '                Throw New Exception("Not support type of control " + mFormField.ControlType)
    '            End If
    '#If DEBUG Then
    '            mControl.BackColor = Color.LemonChiffon
    '#End If
    '            objFormControl.FieldName = mFormField.FieldName
    '            mControl.Tag = objFormControl
    '            If mFormField.Required Then
    '                Control_SetRequire(mControl, True)
    '            End If
    '        Next
    '    End Sub

    Private Function ControlField_GetKey(ByVal objControl As Control, ByVal sTableName As String) As String
        Return objControl.FindForm.Name + "|" + objControl.Name + "|" + sTableName
    End Function

    Public Sub ListControl_BindData(ByVal objList As Object, ByVal mDataSource As Object _
                                    , Optional ByVal mDisplayField As String = Nothing _
                                    , Optional ByVal mValueField As String = Nothing _
                                    , Optional ByVal bSort As Boolean = True _
                                    )
        'Purpose: 
        '   Thủ tục để Bind dữ liệu cho List box hoặc Combo box
        'Parameters: 
        '   objList         : đối tượng ComboBox hoặc ListBox
        '   mDataSource     : source data có thể là ArrayList, IDataReader, DataTable hoặc DataView
        '   mDisplayField   : tên trường Display
        '   mValueField     : tên trường Value
        Dim sDisplayText As String = Nothing

        If Not mDisplayField Is Nothing Then
            objList.DisplayMember = mDisplayField
            objList.ValueMember = mValueField
        End If

        If TypeOf mDataSource Is ArrayList Then
            '
            Dim arr As ArrayList = DirectCast(mDataSource, ArrayList)
            '
            objList.Items.Clear()
            If arr.Count = 0 Then Return
            If Object_GetProperty(arr(0).GetType, mValueField) Is Nothing Then
                Throw New Exception(String.Format("Value field '{0}' not found in object property", mValueField))
            End If
            For Each objItem As Object In mDataSource
                objList.Items.Add(objItem)
            Next
        ElseIf TypeOf mDataSource Is IDataReader Then
            objList.Items.Clear()
            objList.DisplayMember = "DisplayField"
            objList.ValueMember = "ValueField"
            Dim mReader As IDataReader = CType(mDataSource, IDataReader)
            Try
                'Lấy field index
                'Fix trường hơp không trao tên field, tự động lấy theo thứ tự DisplayField,ValueField
                'VD: SELECT DisplayField,ValueField FROM Dic_Table
                Dim sDisplayField As String = ""
                Dim iDisplayField As Integer = 1
                Dim iValueField As Integer = 0
                Dim arr() As String

                Try
                    iValueField = mReader.GetOrdinal(mValueField)
                Catch
                    Throw New Exception(String.Format("Value field '{0}' not found in data", mValueField))
                End Try

                Try
                    arr = mDisplayField.Split(" ")
                    If arr.Length = 1 Then
                        iDisplayField = mReader.GetOrdinal(mDisplayField)
                    Else
                        Dim iOrd As Integer
                        For i As Integer = 0 To arr.Length - 1
                            iOrd = -1
                            Try
                                iOrd = mReader.GetOrdinal(arr(i))
                            Catch
                            End Try
                            If iOrd >= 0 Then
                                sDisplayField += "," + iOrd.ToString
                            Else
                                sDisplayField += "," + arr(i)
                            End If
                        Next
                        sDisplayField = sDisplayField.Substring(1)
                    End If
                Catch

                End Try
                Dim mItem As ListBoxItem

                Do Until mReader.Read = False
                    mItem = New ListBoxItem
                    arr = sDisplayField.Split(",")
                    If arr.Length = 1 Then
                        mItem.DisplayField = mReader.Item(iDisplayField)
                    Else
                        Dim sTemp As String = ""
                        For i As Integer = 0 To arr.Length - 1
                            If Integer.TryParse(arr(i), iDisplayField) Then
                                sTemp += " " + mReader.Item(iDisplayField)
                            Else
                                sTemp += " " + arr(i)
                            End If
                        Next
                        mItem.DisplayField = sTemp.TrimStart
                    End If
                    mItem.ValueField = mReader.Item(iValueField)
                    objList.Items.Add(mItem)
                Loop
            Finally
                Reader_Close(mReader)
                mReader = Nothing
            End Try
        Else
            Dim dt As DataTable
            If TypeOf mDataSource Is DataTable Then
                dt = DirectCast(mDataSource, DataTable)
            ElseIf TypeOf mDataSource Is DataView Then
                dt = DirectCast(mDataSource, DataView).Table
            Else
                Throw New Exception("Function isn't support data source " + mDataSource.GetType.Name)
            End If
            If Not dt.Columns.Contains(mValueField) Then
                Throw New Exception(String.Format("Value field '{0}' not found in data", mValueField))
            End If
            '
            Dim arr() As String = mDisplayField.Split(" ")
            'Support combine field in DataTable for display
            'Ex: sDisplayField="Code - Name"
            If arr.Length > 1 Then
                mDisplayField = mDisplayField.Replace(" ", "_")
                dt.Columns.Add(mDisplayField, GetType(String))
                For Each mRow As DataRow In dt.Rows
                    Dim sTemp As String = ""
                    For Each mField As String In arr
                        If dt.Columns.Contains(mField) Then
                            sTemp += mRow.Item(mField).ToString + " "
                        Else
                            sTemp += mField + " "
                        End If
                    Next
                    mRow.Item(mDisplayField) = sTemp.Trim
                Next
            End If
            '
            If bSort Then
                dt.Columns.Add("Sort_Field", GetType(String))
                For Each mRow As DataRow In dt.Rows
                    mRow.Item("Sort_Field") = mRow.Item(mDisplayField)
                Next
                dt.DefaultView.Sort = "Sort_Field"
            End If
            '
            objList.DisplayMember = mDisplayField
            objList.DataSource = mDataSource

        End If
    End Sub

    Private Function Find_Control(ByVal mParentControl As Control, ByVal sName As String)
        Dim arrControl() As Control = mParentControl.Controls.Find(sName, True)
        If arrControl.Length = 0 Then Return Nothing
        Return arrControl(0)
    End Function

    Private Function FormField_GetCache(ByVal objControl As Control, ByVal sTableName As String) As List(Of FormField)
        Dim sKey As String = ControlField_GetKey(objControl, sTableName)
        If Not mFieldCache.ContainsKey(sKey) Then
            Return Nothing
        Else
            Return mFieldCache(sKey)
        End If
    End Function

    Private Function GetTableField(ByVal sTableName As String) As DataTable
        'sTableName = sTableName.ToUpper
        'If Not mTableCache.ContainsKey(sTableName) Then
        '    Dim mDataTable As DataTable = AppHandler.Instance.Table_ListField(sTableName)
        '    mDataTable.PrimaryKey = New DataColumn() {mDataTable.Columns("COLUMN_NAME")}
        '    mDataTable.AcceptChanges()
        '    mTableCache.Add(sTableName, mDataTable)
        'End If
        'Return mTableCache(sTableName)
        Return Nothing
    End Function

#End Region

#Region "Application Function"

    Public Function App_GetTheme() As String
        'Function to get the current Windows XP theme.
        'Optional: You can use it to set different colors for each theme.
        Dim key As RegistryKey
        Dim s As String = "WindowsClassic"
        key = Registry.CurrentUser.OpenSubKey("Software\Microsoft\Windows\CurrentVersion\ThemeManager")
        If key IsNot Nothing Then
            If "1" = (key.GetValue("ThemeActive").ToString) Then
                s = (key.GetValue("ColorName")).ToString()
            End If
        End If
        Return s
    End Function

    Public Function App_GetColor(ByVal sColor As String) As Color
        If sColor.StartsWith("#") Then
            Return ColorTranslator.FromHtml(sColor)
        Else
            Color.FromName(sColor)
        End If
    End Function

    Public Function App_TextWidth(ByVal sText As String, ByVal f As System.Drawing.Font) As Long
        Dim i As New System.Drawing.Bitmap(1, 1)
        Dim g As System.Drawing.Graphics = System.Drawing.Graphics.FromImage(i)
        Dim fSize As System.Drawing.SizeF = g.MeasureString(sText, f)
        Return fSize.Width
    End Function

    Public Sub App_ShowProgress(ByVal _MethodAddress As MethodInvoker)
        frmProgress.Instance.Thread = _MethodAddress
        frmProgress.Instance.Show_Progress()
    End Sub

    Public Sub App_ShowProgress(ByVal _MethodAddress As MethodInvoker, ByVal sInitText As String)
        frmProgress.Instance.Thread = _MethodAddress
        frmProgress.Instance.Show_Progress(sInitText)
    End Sub

    Public Sub App_ShowProgress(ByVal _MethodAddress As MethodInvoker, ByVal sInitText As String, ByVal sFinishText As String)
        frmProgress.Instance.Thread = _MethodAddress
        frmProgress.Instance.Show_Progress(sInitText, sFinishText)
    End Sub

    Public Sub App_ShowProgress(ByVal _SubAddress As frmProgress.SubInvoker, ByVal objInput As Object, ByVal sInitText As String)
        frmProgress.Instance.ThreadSub = _SubAddress
        frmProgress.Instance.ThreadInputObject = objInput
        frmProgress.Instance.Show_Progress(sInitText)
    End Sub

    Public Function App_ShowProgress(ByVal _FunctionAddress As frmProgress.FunctionInvoker, ByVal objInput As Object, ByVal sDesc As String) As Object
        frmProgress.Instance.ThreadFunction = _FunctionAddress
        frmProgress.Instance.ThreadInputObject = objInput
        Return frmProgress.Instance.Show_Progress(sDesc)
    End Function

#End Region

#Region "Panel Function"

    Public Function Panel_CheckError(ByVal objControl As Control) As Boolean
        Return Panel_CheckError(objControl, False)
    End Function

    Public Function Panel_CheckError(ByVal objControl As Control, ByVal bSilent As Boolean) As Boolean
        'Purpose: 
        '   Tự động kiểm tra dữ liệu cần phải nhập trên form
        'Parameters: 
        '   objControl : đối tượng chứa các ô nhập liệu
        '   bSilent : check Silent True/False
        'Notes:
        '   Nếu ở chế độ check Silent sẽ không hiện MessageBox
        Dim bReturn As Boolean = True
        Dim mControl As Control = Nothing
        Dim sControlType As String = Nothing

        Dim sError As String = Nothing
        Dim bError As Boolean = Nothing

        Dim sCaption As String = Nothing

        For i As Integer = objControl.Controls.Count - 1 To 0 Step -1
            mControl = objControl.Controls(i)
            sControlType = TypeName(mControl)
            If mControl.Controls.Count > 0 And mControl.Enabled And _
            (sControlType.IndexOf("Panel") > -1 Or sControlType.IndexOf("Tab") > -1 Or sControlType.IndexOf("Group") > -1) Then
                bReturn = Panel_CheckError(mControl, bSilent)
                'If Not mReturn Then bSilent = True
                If Not bReturn Then Return bReturn
            Else
                If TypeOf mControl.Tag Is FormControlExt Then
                    Dim objControlExt As FormControlExt = DirectCast(mControl.Tag, FormControlExt)
                    Select Case sControlType
                        Case "TextBox"
                            If objControlExt.Required Then
                                bReturn = (mControl.Text.Trim <> "")
                            End If
                        Case "TextEdit"
                            If objControlExt.Required Then
                                bReturn = (mControl.Text.Trim <> "")
                            End If
                        Case "DateEdit"
                            If objControlExt.Required Then
                                bReturn = (mControl.Text.Trim <> "")
                            End If
                        Case "DateEdit"
                            If objControlExt.Required Then
                                bReturn = (mControl.Text.Trim <> "")
                            End If
                        Case "CheckEdit"
                            bReturn = True

                        Case "ComboBox"
                            If objControlExt.Required Then
                                'If obj.HandleObject Is Nothing Then 'OrElse obj.HandleObject.AutoComplete Then
                                '    bReturn = Combo_GetValue(mControl) <> COMBO_ITEM_NULL_VALUE
                                'Else
                                '    bReturn = (Not mControl.Text Is Nothing) AndAlso (mControl.Text.Trim <> "")
                                'End If
                                bReturn = Not Null.IsNull(Combo_GetValue(mControl))
                            End If
                        Case "HtmlEditorControl"
                            If objControlExt.Required Then
                                'bReturn = CType(mControl, HtmlEditorControl).InnerText.Trim <> ""
                            End If
                        Case Else
                            If objControlExt.Required Then
                                bReturn = (mControl.Text.Trim <> "")
                            End If
                    End Select
                Else
                    Continue For
                End If
            End If
            '
            If sControlType = "TextBox" AndAlso DirectCast(mControl, TextBox).ReadOnly = False Then
                sError = Control_GetError(mControl)
                bError = Not String.IsNullOrEmpty(sError)
            End If

            If sControlType = "TextEdit" AndAlso DirectCast(mControl, TextEdit).Properties.ReadOnly = False Then
                sError = Control_GetError(mControl)
                bError = Not String.IsNullOrEmpty(sError)
            End If

            If (Not bReturn) Or bError Then
                If Not bSilent Then
                    'Hỗ trợ trường hợp nằm trong tabpage không active
                    Dim ctlParent As Control = mControl.Parent
                    While Not TypeOf ctlParent Is Form
                        If TypeOf ctlParent Is TabPage Then
                            If DirectCast(ctlParent.Parent, TabControl).SelectedIndex <> DirectCast(ctlParent, TabPage).TabIndex Then
                                DirectCast(ctlParent.Parent, TabControl).SelectedIndex = DirectCast(ctlParent, TabPage).TabIndex
                                Exit While
                            End If
                        End If
                        ctlParent = ctlParent.Parent
                    End While
                    '
                    mControl.Focus()
                    sCaption = Control_GetLabel(mControl)
                    If String.IsNullOrEmpty(sCaption) Then
                        sCaption = "trường bắt buộc"
                    Else
                        sCaption = "trường '" + sCaption + "'"
                    End If
                    If Not bReturn Then
                        sCaption = "Bạn phải nhập dữ liệu cho " & sCaption
                    End If
                    If bError Then
                        If sCaption = "trường bắt buộc" Then
                            sCaption = sError
                        Else
                            sCaption = sError + " cho " + sCaption
                        End If
                        bReturn = False
                    End If
                    Message_Information(sCaption)
                End If
                Exit For
            End If
        Next

        Return bReturn
    End Function

    Public Sub Panel_GetControlValue(ByVal objPanel As Control, ByVal objInfo As Object)
        Dim sTableName As String = objPanel.Tag
        Panel_GetControlValue(objPanel, objInfo, sTableName)
    End Sub

    Public Sub Panel_GetControlValue(ByVal objPanel As Control, ByVal objInfo As Object, ByVal sTableName As String)
        Throw New Exception("Gan gia tri vao cac control trong form")
        Dim arrFormField As List(Of FormField) = FormField_GetCache(objPanel, sTableName)
        '
        If arrFormField Is Nothing Then
            Throw New Exception(String.Format("Control '{0}' isn't init control with table '{1}'", objPanel.Name, sTableName))
        End If
        '
        Dim objProperty As PropertyInfo
        Dim objValue As Object
        For Each mFormField As FormField In arrFormField
            Dim mControl As Control = Find_Control(objPanel, mFormField.ControlName)
            If mControl Is Nothing Then Continue For
            objProperty = Object_GetProperty(objInfo.GetType, mFormField.FieldName)
            If objProperty Is Nothing OrElse Not objProperty.CanWrite Then Continue For
            objValue = objProperty.GetValue(objInfo, Nothing)
            'Dim objFormControl As New FormControlExt
            If mFormField.ControlType = "TextBox" Then
                objValue = DirectCast(mControl, TextBox).Text
            ElseIf mFormField.ControlType = "RichTextBox" Then
                objValue = DirectCast(mControl, RichTextBox).Rtf
            ElseIf mFormField.ControlType = "ComboBox" Then
                objValue = Combo_GetValue(mControl)
            ElseIf mFormField.ControlType = "TextEdit" Then
                objValue = DirectCast(mControl, TextEdit).Text
            ElseIf mFormField.ControlType = "MemoEdit" Then
                objValue = DirectCast(mControl, MemoEdit).Text
            ElseIf mFormField.ControlType = "DateEdit" Then
                objValue = DirectCast(mControl, DateEdit).DateTime.Date
            ElseIf mFormField.ControlType = "TimeEdit" Then
                objValue = DirectCast(mControl, TimeEdit).Text
            ElseIf mFormField.ControlType = "SpinEdit" Then
                objValue = DirectCast(mControl, SpinEdit).Text
            ElseIf mFormField.ControlType = "LookUpEdit" Then
                objValue = DirectCast(mControl, LookUpEdit).EditValue
            ElseIf mFormField.ControlType = "GridLookUpEdit" Then
                objValue = DirectCast(mControl, GridLookUpEdit).EditValue
            ElseIf mFormField.ControlType = "CheckBox" Then
                objValue = DirectCast(mControl, CheckBox).Checked
            ElseIf mFormField.ControlType = "CheckEdit" Then
                If DirectCast(mControl, CheckEdit).Checked Then
                    objValue = 1
                Else
                    objValue = 0
                End If

                'CType(objValue, DirectCast(mControl, CheckEdit).Checked)

            Else
                Continue For
                'Throw New Exception("Not support type of control")
            End If
            objValue = Object_SetValueEx(objValue, objProperty.PropertyType.Name)
            objProperty.SetValue(objInfo, objValue, Nothing)
        Next
    End Sub

    Public Sub Panel_SetControlValue(ByVal objPanel As Control, ByVal objInfo As Object)
        Panel_SetControlValue(objPanel, objInfo, False)
    End Sub

    Public Sub Panel_SetControlValue(ByVal objPanel As Control, ByVal objInfo As Object, ByVal bIgnoreError As Boolean)
        Dim sTableName As String = objPanel.Tag
        Panel_SetControlValue(objPanel, objInfo, sTableName, bIgnoreError)
    End Sub

    Public Sub Panel_SetControlValue(ByVal objPanel As Control, ByVal objInfo As Object, ByVal sTableName As String)
        Panel_SetControlValue(objPanel, objInfo, sTableName, False)
    End Sub

    Public Sub Panel_SetControlValue(ByVal objPanel As Control, ByVal objInfo As Object, ByVal sTableName As String, ByVal bIgnoreError As Boolean)
        Dim arrFormField As List(Of FormField) = FormField_GetCache(objPanel, sTableName)
        '
        If arrFormField Is Nothing Then
            Throw New Exception(String.Format("Control '{0}' isn't init control with table '{1}'", objPanel.Name, sTableName))
        End If
        '
        Dim objProperty As PropertyInfo
        Dim objValue As Object
        For Each mFormField As FormField In arrFormField
            Dim mControl As Control = Find_Control(objPanel, mFormField.ControlName)
            If mControl Is Nothing Then Continue For
            objProperty = Object_GetProperty(objInfo.GetType, mFormField.FieldName)
            If objProperty Is Nothing Then
                objValue = Nothing
            Else
                objValue = objProperty.GetValue(objInfo, Nothing)
                'Dim objFormControl As New FormControlExt
                If mFormField.ControlType = "TextBox" Then
                    DirectCast(mControl, TextBox).Text = Object_GetDisplayValue(objValue)
                ElseIf mFormField.ControlType = "TextEdit" Then
                    DirectCast(mControl, TextEdit).Text = Object_GetDisplayValue(objValue)
                ElseIf mFormField.ControlType = "RichTextBox" Then
                    DirectCast(mControl, RichTextBox).Rtf = Object_GetDisplayValue(objValue)
                ElseIf mFormField.ControlType = "ComboBox" Then
                    Combo_SetValue(mControl, objValue, bIgnoreError) 'DirectCast(mControl, ComboBox).SelectedValue = GetValue(objValue, "")
                ElseIf mFormField.ControlType = "LookUpEdit" Then
                    LookUpEdit_SetValue(mControl, objValue, bIgnoreError)
                ElseIf mFormField.ControlType = "GridLookUpEdit" Then
                    GridLookUpEdit_SetValue(mControl, objValue, bIgnoreError)
                ElseIf mFormField.ControlType = "SpinEdit" Then
                    DirectCast(mControl, SpinEdit).Text = Object_GetDisplayValue(objValue)
                ElseIf mFormField.ControlType = "MemoEdit" Then
                    DirectCast(mControl, TextEdit).Text = Object_GetDisplayValue(objValue)
                ElseIf mFormField.ControlType = "DateEdit" Then
                    DirectCast(mControl, DateEdit).EditValue = Object_GetDisplayValue(objValue)
                ElseIf mFormField.ControlType = "TimeEdit" Then
                    DirectCast(mControl, TimeEdit).Text = Object_GetDisplayValue(objValue)
                ElseIf mFormField.ControlType = "CheckBox" Then
                    DirectCast(mControl, CheckBox).Checked = CType(objValue, Boolean)
                ElseIf mFormField.ControlType = "CheckEdit" Then
                    DirectCast(mControl, CheckEdit).Checked = CType(objValue, Boolean)
                Else
                    Throw New Exception("Not support type of control: " + mControl.GetType.Name)
                End If
            End If
        Next
    End Sub

    Public Sub Panel_InitControl(ByVal objControl As Control, ByVal sTableName As String)
        Panel_InitControl(objControl, sTableName, "")
    End Sub

    Public Sub Panel_InitControl(ByVal objControl As Control, ByVal sTableName As String, ByVal sExceptControl As String)
        'Purpose: 
        '   Tự động đặt kiểu dữ liệu, độ dài, required cho form nhập liệu theo database
        'Parameters: 
        '   objControl : đối tượng chứa các ô nhập liệu
        '   sTableName : tên Table tương ứng với form nhập liệu
        'Notes:
        '   Hỗ trợ cache DataTable

        'Dim mDataTable As DataTable
        'Dim sKey As String = ControlField_GetKey(objControl, sTableName)
        'Try
        '    Dim arrCache As List(Of FormField)
        '    'mFieldCache.Clear()
        '    If Not mFieldCache.ContainsKey(sKey) Then
        '        'mDataTable = SystemController.Instance.GetTableField(sTableName)
        '        mDataTable = GetTableField(sTableName) 'Reader2Table(DataAccess.SqlHelper.ExecuteReader(g_sDBConnect, "GetTableField", sTableName))
        '        If mDataTable.Rows.Count > 0 Then
        '            arrCache = SetControlByField(objControl, mDataTable, sExceptControl)
        '            mFieldCache.Add(sKey, arrCache)
        '        Else
        '            Throw New Exception("Table '" + sTableName + "' do not exist")
        '        End If
        '    Else
        '        arrCache = mFieldCache(sKey)
        '        SetControlField(objControl, arrCache)
        '    End If
        '    '
        '    objControl.Tag = sTableName
        'Catch
        '    Throw
        'Finally
        '    'If Not mDataTable Is Nothing Then mDataTable.Dispose()
        'End Try
    End Sub

#End Region

#Region " Dành cho TextBox"
    'Handle Input cho TextBox
    'Public Sub TextBox_SetHandle(ByVal tb As TextBox, ByVal DataType As String, Optional ByVal MinValue As Object = Nothing, Optional ByVal MaxValue As Object = Nothing, Optional ByVal AutoClearError As Boolean = False)
    '    'Purpose: 
    '    '   Handle cho TextBox
    '    'Parameters: 
    '    '   tb         : đối tượng TextBox
    '    '   DataType   : loại dữ liệu
    '    '   MinValue   : giá trị nhỏ nhất
    '    '   MaxValue   : giá trị lớn nhất
    '    'Notes
    '    Dim objFormControl As FormControlExt
    '    If tb.Tag Is Nothing Then
    '        objFormControl = New FormControlExt
    '    Else
    '        objFormControl = tb.Tag
    '    End If
    '    If objFormControl.HandleObject Is Nothing Then
    '        Dim mHandle As New TextBoxHandle(tb, DataType, MinValue, MaxValue)
    '        mHandle.AutoClearError = AutoClearError
    '        objFormControl.HandleObject = mHandle
    '    Else
    '        CType(objFormControl.HandleObject, TextBoxHandle).DataType = DataType
    '        CType(objFormControl.HandleObject, TextBoxHandle).MinValue = MinValue
    '        CType(objFormControl.HandleObject, TextBoxHandle).MaxValue = MaxValue
    '    End If
    '    tb.Tag = objFormControl
    'End Sub

    '-------------
    '<TextBox>
    '-------------

    ''Handle Input cho TextEdit
    'Public Sub TextEdit_SetHandle(ByVal te As TextEdit, ByVal DataType As String, Optional ByVal MinValue As Object = Nothing, Optional ByVal MaxValue As Object = Nothing, Optional ByVal AutoClearError As Boolean = False)
    '    'Purpose: 
    '    '   Handle cho TextEdit
    '    'Parameters: 
    '    '   tb         : đối tượng TextEdit
    '    '   DataType   : loại dữ liệu
    '    '   MinValue   : giá trị nhỏ nhất
    '    '   MaxValue   : giá trị lớn nhất
    '    'Notes
    '    Dim objFormControl As FormControlExt
    '    If te.Tag Is Nothing Then
    '        objFormControl = New FormControlExt
    '    Else
    '        objFormControl = te.Tag
    '    End If
    '    If objFormControl.HandleObject Is Nothing Then
    '        Dim mHandle As New TextEditHandle(te, DataType, MinValue, MaxValue)
    '        mHandle.AutoClearError = AutoClearError
    '        objFormControl.HandleObject = mHandle
    '    Else
    '        CType(objFormControl.HandleObject, TextEditHandle).DataType = DataType
    '        CType(objFormControl.HandleObject, TextEditHandle).MinValue = MinValue
    '        CType(objFormControl.HandleObject, TextEditHandle).MaxValue = MaxValue
    '    End If
    '    te.Tag = objFormControl
    'End Sub

    Public Sub Control_SetError(ByVal objControl As Control, ByVal sError As String)
        Dim errDX As DXErrorProvider
        errDX = Form_GetDXErrorProvider(objControl.FindForm)
        errDX.SetError(objControl, sError, ErrorType.Information)
        errDX.SetIconAlignment(objControl, ErrorIconAlignment.MiddleLeft)
        If sError.Length > 0 Then
            Dim mForm As Form = objControl.FindForm
            If mForm.AutoValidate <> AutoValidate.EnableAllowFocusChange Then
                mForm.AutoValidate = AutoValidate.EnableAllowFocusChange
            End If
        End If

        'Dim errPro As ErrorProvider
        'errPro = Form_GetErrorProvider(objControl.FindForm)
        'errPro.SetError(objControl, sError)
        'If sError.Length > 0 Then
        '    Dim objErrControl As Control = objControl.Parent.GetChildAtPoint(New Point(objControl.Left - 18, objControl.Top))
        '    Dim iPadding As Integer = 2
        '    If Not objErrControl Is Nothing AndAlso TypeOf objErrControl Is TextBox Then
        '        If CType(objErrControl, TextBox).ReadOnly Then iPadding += objControl.Left - objErrControl.Left
        '    End If

        '    If Not objErrControl Is Nothing AndAlso TypeOf objErrControl Is TextEdit Then
        '        If CType(objErrControl, TextEdit).Properties.ReadOnly Then iPadding += objControl.Left - objErrControl.Left
        '    End If

        '    errPro.SetIconAlignment(objControl, ErrorIconAlignment.TopLeft)
        '    errPro.SetIconPadding(objControl, iPadding)

        '    Dim mForm As Form = objControl.FindForm
        '    If mForm.AutoValidate <> AutoValidate.EnableAllowFocusChange Then mForm.AutoValidate = AutoValidate.EnableAllowFocusChange
        'End If
    End Sub

    Public Function Control_GetError(ByVal objControl As Control) As String
        Dim errPro As DXErrorProvider
        errPro = Form_GetErrorProvider(objControl.FindForm)
        Return errPro.GetError(objControl)
    End Function
#End Region

#Region " Dành cho ComboBox"


    'Các cosnt phục vụ cho item null của ComboBox
    Public Const COMBO_ITEM_REQUIRE As String = "<Chọn giá trị>"
    Public Const COMBO_ITEM_BLANK As String = ""
    Public Const COMBO_ITEM_SELECT_ALL As String = "<Tất cả>"
    Public Const COMBO_ITEM_NULL_VALUE As String = "-1111111111"

    Public Sub Combo_BindData(ByVal objList As System.Windows.Forms.ComboBox, ByVal mDataSource As Object _
                                   , ByVal mDisplayField As String _
                                   , Optional ByVal bSort As Boolean = True _
                                   )
        Combo_BindData(objList, mDataSource, mDisplayField, "", bSort)
    End Sub

    Public Sub Combo_BindData(ByVal objList As System.Windows.Forms.ComboBox, ByVal mDataSource As Object _
                                   , ByVal mDisplayField As String _
                                   , ByVal sFirstItem As String _
                                   , Optional ByVal bSort As Boolean = True _
                                   )
        Dim mValueField As String
        If TypeOf objList.Tag Is FormControlExt Then
            mValueField = DirectCast(objList.Tag, FormControlExt).FieldName
        Else
            If String.IsNullOrEmpty(objList.ValueMember) Then
                mValueField = objList.Name.Substring(3)
                If Not mValueField.EndsWith("_ID") Then mValueField += "_ID"
            Else
                mValueField = objList.ValueMember
            End If
        End If
        If String.IsNullOrEmpty(mValueField) Then
            Throw New Exception("Can't get Value Field because control don't have extend property")
        End If
        Combo_BindData(objList, mDataSource, mDisplayField, mValueField, sFirstItem, bSort)
    End Sub

    Public Sub Combo_BindData(ByVal objList As DataGridViewComboBoxColumn, ByVal mDataSource As Object _
                                   , ByVal mDisplayField As String _
                                   , ByVal mValueField As String _
                                   , Optional ByVal bSort As Boolean = True _
                                   )
        Combo_BindData(objList, mDataSource, mDisplayField, mValueField, "", bSort)
    End Sub

    Public Sub Combo_BindData(ByVal objList As Object, ByVal mDataSource As Object _
                                   , ByVal mDisplayField As String _
                                   , ByVal mValueField As String _
                                   , ByVal sFirstItem As String _
                                   , Optional ByVal bSort As Boolean = True _
                                   )
        '
        ListControl_BindData(objList, mDataSource, mDisplayField, mValueField, bSort)
        '
        'Tự động chèn null item cho combo (trường hợp DataSource là DataTable và DataView)
        Dim sDisplayText As String
        Dim bSortText As Boolean
        If sFirstItem <> "" Then
            sDisplayText = sFirstItem
            '
            If TypeOf mDataSource Is DataTable Then
                Dim mRow As DataRow = DirectCast(mDataSource, DataTable).NewRow()
                For Each mCol As DataColumn In mRow.Table.Columns
                    mCol.AllowDBNull = True
                Next
                mRow.Item(objList.DisplayMember) = sDisplayText
                If objList.DisplayMember <> objList.ValueMember Then
                    'Dim iMaxLen As Integer = mRow.Table.Columns(objList.ValueMember.ToString).MaxLength
                    'If iMaxLen > 0 Then
                    '    mRow.Item(objList.ValueMember) = COMBO_ITEM_NULL_VALUE.Substring(0, iMaxLen)
                    'Else
                    mRow.Item(objList.ValueMember) = DBNull.Value 'COMBO_ITEM_NULL_VALUE
                    'End If
                End If
                DirectCast(mDataSource, DataTable).Rows.InsertAt(mRow, 0)
                ''
            ElseIf TypeOf mDataSource Is DataView Then
                Dim mRow As DataRowView = DirectCast(mDataSource, DataView).AddNew
                For Each mCol As DataColumn In mRow.DataView.Table.Columns
                    mCol.AllowDBNull = True
                Next
                mRow.Item(objList.DisplayMember) = sDisplayText
                If objList.DisplayMember <> objList.ValueMember Then
                    Dim iMaxLen As Integer = mRow.DataView.Table.Columns(objList.ValueMember.ToString).MaxLength
                    If iMaxLen > 0 Then
                        mRow.Item(objList.ValueMember) = COMBO_ITEM_NULL_VALUE.Substring(0, iMaxLen)
                    Else
                        mRow.Item(objList.ValueMember) = DBNull.Value 'COMBO_ITEM_NULL_VALUE
                    End If
                End If
                DirectCast(mDataSource, DataView).Sort = objList.DisplayMember
                DirectCast(mDataSource, DataView).ApplyDefaultSort = True
            Else '(trường hợp DataSource là ArrayList và IDataReader)
                bSortText = True
                sDisplayText = sFirstItem
                Dim objType As Type = objList.Items.Item(0).GetType
                Dim objProperty As PropertyInfo

                Dim mObject As Object = Activator.CreateInstance(objType)

                objProperty = Object_GetProperty(objType, objList.ValueMember)
                'If objProperty.PropertyType.Name = "String" Then
                '    objProperty.SetValue(mObject, COMBO_ITEM_NULL_VALUE.ToString, Nothing)
                'Else
                '    objProperty.SetValue(mObject, Convert.ChangeType(COMBO_ITEM_NULL_VALUE, objProperty.PropertyType), Nothing)
                'End If
                objProperty.SetValue(mObject, Null.SetNull(objProperty), Nothing)
                '
                objProperty = Object_GetProperty(objType, objList.DisplayMember)
                objProperty.SetValue(mObject, sDisplayText, Nothing)

                CType(objList, System.Windows.Forms.ComboBox).Items.Insert(0, mObject)

            End If
        End If
        '
        If TypeOf objList Is System.Windows.Forms.ComboBox Then
            Dim objCombo As System.Windows.Forms.ComboBox = DirectCast(objList, System.Windows.Forms.ComboBox)
            'objCombo.Text = ""
            If sFirstItem <> "" Then
                objCombo.SelectedIndex = 0
                'Else
                '    objCombo.SelectedItem = Nothing
            End If
        End If
    End Sub

    Public Sub Combo_SetHandle(ByVal cb As System.Windows.Forms.ComboBox, Optional ByVal RequiredField As Boolean = False) ', Optional ByVal bSortByText As Boolean = True)
        'Purpose: 
        '   Handle cho ComboBox
        'Parameters: 
        '   cb              : đối tượng ComboBox
        '   RequiredField   : đánh dấu bắt buộc nhập        
        'Notes
        Dim objFormControl As New FormControlExt
        objFormControl.HandleObject = New ComboBoxHandle(cb)
        cb.Tag = objFormControl
        'cb.Sorted = bSortByText
        Control_SetRequire(cb, RequiredField)
    End Sub

    Public Sub Combo_SetValue(ByVal objCombo As System.Windows.Forms.ComboBox, ByVal sValue As Object)
        Combo_SetValue(objCombo, sValue, False, "")
    End Sub

    Public Sub LookUpEdit_SetValue(ByVal objLookUpEdit As LookUpEdit, ByVal sValue As Object, ByVal bIgnoreError As Boolean)
        LookUpEdit_SetValue(objLookUpEdit, sValue, bIgnoreError, "")
    End Sub

    '
    Public Sub GridLookUpEdit_SetValue(ByVal objGridLookUpEdit As GridLookUpEdit, ByVal sValue As Object, ByVal bIgnoreError As Boolean)
        GridLookUpEdit_SetValue(objGridLookUpEdit, sValue, bIgnoreError, "")
    End Sub

    Public Sub Combo_SetValue(ByVal objCombo As System.Windows.Forms.ComboBox, ByVal sValue As Object, ByVal bIgnoreError As Boolean)
        Combo_SetValue(objCombo, sValue, bIgnoreError, "")
    End Sub

    Public Sub Combo_SetValue(ByVal objCombo As System.Windows.Forms.ComboBox, ByVal sValue As Object, ByVal bIgnoreError As Boolean, ByVal sCorrectDisplay As String)
        'Purpose: 
        '   Thủ tục để set giá trị cho ComboBox
        '   Hỗ trợ AutoCorrect giá trị không có trong Combo
        'Parameters: 
        '   objCombo        : đối tượng ComboBox 
        '   sValue          : giá trị cần set có thể là biến hoặc Object
        '   bAutoCorrect    : Yes/No
        '   sDisplay        : tên trường Value        

        'Handle dbnull value
        If sValue Is Nothing OrElse sValue Is DBNull.Value OrElse Null.IsNull(sValue) Then
            If objCombo.Items.Count > 0 Then
                'Combo_SetValue(objCombo, COMBO_ITEM_NULL_VALUE)
                objCombo.SelectedIndex = 0
            End If
            Return
        End If

        If objCombo.Items.Count = 0 AndAlso Not bIgnoreError AndAlso sCorrectDisplay = "" Then
            Throw New Exception("Can't set value with blank combo: " + objCombo.Name)
        End If

        Dim bFound As Boolean = False
        Dim mSource As Object = objCombo.DataSource
        If objCombo.Items.Count > 0 Then
            objCombo.SelectedIndex = -1
            If TypeOf mSource Is DataView Or TypeOf mSource Is DataTable Then
                Dim mDataView As DataView

                If TypeOf mSource Is DataView Then
                    mDataView = mSource
                Else
                    mDataView = mSource.DefaultView
                End If


                Dim i As Long '= 0
                For i = 0 To mDataView.Count - 1
                    Dim oItemValue As Object = mDataView.Item(i).Item(objCombo.ValueMember)
                    If Not IsDBNull(oItemValue) AndAlso oItemValue = sValue Then
                        bFound = True
                        Exit For
                    End If
                Next
                'If String.IsNullOrEmpty(mDataView.Sort) Then
                '    mDataView.Sort = objCombo.ValueMember
                'End If
                ''i = mDataView.Find(Object_GetDisplayValue(sValue))
                'i = mDataView.Find(sValue)
                'bFound = (i > -1)
                If bFound Then
                    objCombo.SelectedIndex = i
                Else
                    objCombo.SelectedIndex = 0
                End If
                'If sCorrectDisplay = "" Then Return
            Else
                Dim objType As Type = objCombo.Items.Item(0).GetType
                Dim objProperty As PropertyInfo = Object_GetProperty(objType, objCombo.ValueMember)

                For Each objItem As Object In objCombo.Items
                    If objItem.GetType.Name = sValue.GetType.Name Then
                        If Object_Compare(objItem, sValue) Then
                            objCombo.SelectedItem = objItem
                            bFound = True
                            Exit For
                        End If
                    ElseIf objProperty Is Nothing Then
                        Exit For
                    ElseIf objProperty.GetValue(objItem, Nothing).ToString = sValue.ToString Then
                        objCombo.SelectedItem = objItem
                        bFound = True
                        Exit For
                    End If
                Next
            End If
        End If
        If bFound = False Then
            If sCorrectDisplay <> "" Then
                If TypeOf objCombo.DataSource Is DataTable Then
                    Dim mRow As DataRow = CType(objCombo.DataSource, DataTable).NewRow()
                    mRow.Item(objCombo.DisplayMember) = sCorrectDisplay
                    mRow.Item(objCombo.ValueMember) = sValue
                    CType(objCombo.DataSource, DataTable).Rows.Add(mRow)
                    objCombo.SelectedValue = sValue
                ElseIf TypeOf objCombo.DataSource Is DataView Then
                    Dim mRow As DataRowView = CType(objCombo.DataSource, DataView).AddNew
                    mRow.Item(objCombo.DisplayMember) = sCorrectDisplay
                    mRow.Item(objCombo.ValueMember) = sValue
                    objCombo.SelectedValue = sValue
                Else
                    Dim obj As New ListBoxItem(sValue, sCorrectDisplay)
                    objCombo.Items.Add(obj)
                    objCombo.SelectedItem = obj
                End If
            Else
                If sCorrectDisplay <> "" Then
                    objCombo.Text = sCorrectDisplay
                Else
                    If Not bIgnoreError Then Throw New Exception(String.Format("Item with value '{0}' not found in ComboBox: " + objCombo.Name, sValue))
                End If
            End If
        Else
            'Dim s = DirectCast(objCombo, ComboBox).SelectedItem.Text
        End If
        'reupdate view only text
        Dim objView As TextBox = Find_Control(objCombo.Parent, objCombo.Name + "_View")
        If Not objView Is Nothing Then
            objView.Text = DirectCast(objCombo, System.Windows.Forms.ComboBox).Text '.SelectedItem.Text
        End If
        ''
    End Sub

    Public Function Combo_GetValue(ByVal objCombo As System.Windows.Forms.ComboBox) As Object
        'Purpose: 
        '   Hàm lấy giá trị select của combo
        'Parameters: 
        '   objCombo    : đối tượng combobox
        'Notes

        Dim mReturn As Boolean = True

        If Not objCombo.SelectedValue Is Nothing Then
            'Detech null item
            'If (objCombo.SelectedValue.ToString.IndexOf(COMBO_ITEM_NULL_VALUE) = 0 Or (objCombo.DisplayMember = objCombo.ValueMember)) _
            '    AndAlso (objCombo.SelectedText = COMBO_ITEM_NULL_TEXT OrElse objCombo.SelectedText = COMBO_ITEM_SELECT_ALL) Then
            '    Return COMBO_ITEM_NULL_VALUE
            'Else
            '    Return objCombo.SelectedValue
            'End If
            Return objCombo.SelectedValue
        ElseIf Not objCombo.SelectedItem Is Nothing Then
            Dim objItem As Object = objCombo.Items(objCombo.SelectedIndex)
            If objCombo.ValueMember <> "" Then
                Dim objType As Type = objItem.GetType
                Dim objProperty As PropertyInfo = Object_GetProperty(objType, objCombo.ValueMember)
                If objProperty Is Nothing Then
                    Return objItem
                Else
                    Return objProperty.GetValue(objItem, Nothing)
                End If
            Else
                Return objItem
            End If
        Else
            Return Null.NullString 'COMBO_ITEM_NULL_VALUE
        End If
    End Function

    Public Sub LookUpEdit_SetValue(ByVal objLookUpEdit As LookUpEdit, ByVal sValue As Object, ByVal bIgnoreError As Boolean, ByVal sCorrectDisplay As String)
        'Purpose: 
        '   Hàm lấy giá trị select của LookUpEdit
        'Parameters: 
        '   objCombo    : đối tượng LookUpEdit
        'Notes

        objLookUpEdit.DataBindings.Clear()
        objLookUpEdit.EditValue = sValue

    End Sub

    '
    Public Sub GridLookUpEdit_SetValue(ByVal objGridLookUpEdit As GridLookUpEdit, ByVal sValue As Object, ByVal bIgnoreError As Boolean, ByVal sCorrectDisplay As String)
        'Purpose: 
        '   Hàm lấy giá trị select của LookUpEdit
        'Parameters: 
        '   objCombo    : đối tượng LookUpEdit
        'Notes

        objGridLookUpEdit.DataBindings.Clear()
        objGridLookUpEdit.EditValue = sValue

        'Display Description Information
        If objGridLookUpEdit.Tag IsNot Nothing AndAlso TypeOf objGridLookUpEdit.Tag Is FormControlExt Then
            Dim objFormCtrl As FormControlExt = objGridLookUpEdit.Tag

            If objFormCtrl.DescFieldName <> "" Then
                'Get content to display
                Dim iRowHandle As Integer = -1
                Try
                    iRowHandle = objGridLookUpEdit.Properties.View.GetRowHandle(objGridLookUpEdit.Properties.GetIndexByKeyValue(sValue))
                Catch
                End Try
                '
                Dim objValue As Object = Nothing
                If iRowHandle >= 0 Then
                    Dim objInfo As Object = objGridLookUpEdit.Properties.View.GetRow(iRowHandle)
                    Try
                        If TypeOf objInfo Is DataRowView Then
                            Dim x As DataRowView = objInfo
                            objValue = x.Item(objFormCtrl.DescFieldName)
                        Else
                            objValue = objInfo.GetType.GetProperty(objFormCtrl.DescFieldName).GetValue(objInfo, Nothing)
                        End If
                    Catch
                        Throw New Exception(String.Format("Property '{0}' is not memember of object '{1}'", objFormCtrl.DescFieldName, objInfo.GetType.Name))
                    End Try
                End If
                If DB_GetValue(objValue) <> "" Then
                    If objFormCtrl.DescFieldObject Is Nothing Then
                        Dim sLabelName As String = objGridLookUpEdit.Name & "_DescriptionLabel"
                        Dim objControl As Control = objGridLookUpEdit.Parent.Controls(sLabelName)
                        Dim mLabel As Label = objControl

                        If mLabel Is Nothing Then
                            mLabel = New Label
                            mLabel.Name = sLabelName
                            mLabel.AutoSize = True
                            mLabel.Anchor = objGridLookUpEdit.Anchor
                            mLabel.Text = ""
                            mLabel.Top = objGridLookUpEdit.Top + 3
                            mLabel.Left = objGridLookUpEdit.Left + objGridLookUpEdit.Width + 10
                            objGridLookUpEdit.Parent.Controls.Add(mLabel)
                            mLabel.Visible = True
                            mLabel.BringToFront()
                        End If
                        mLabel.Text = objValue
                    Else
                        If TypeOf objFormCtrl.DescFieldObject Is TextEdit Then
                            CType(objFormCtrl.DescFieldObject, TextEdit).Text = objValue
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Public Sub LookUpEdit_SetHandle(ByVal objLookUpEdit As LookUpEdit)
        'Purpose: 
        '   Handle cho ComboBox
        'Parameters: 
        '   cb              : đối tượng ComboBox
        '   RequiredField   : đánh dấu bắt buộc nhập        
        'Notes
        'Dim objFormControl As New FormControlExt
        'objFormControl.HandleObject = New LookUpEditHandle(objLookUpEdit)
        'objLookUpEdit.Tag = objFormControl
        'cb.Sorted = bSortByText
        'Control_SetRequire(cb, RequiredField)
    End Sub

    Public Sub GridLookUpEdit_SetHandle(ByVal objGridLookUpEdit As GridLookUpEdit)
        'Purpose: 
        '   Handle cho ComboBox
        'Parameters: 
        '   cb              : đối tượng ComboBox
        '   RequiredField   : đánh dấu bắt buộc nhập        
        'Notes
        'Dim objFormControl As FormControlExt = Nothing
        'If objGridLookUpEdit.Tag IsNot Nothing AndAlso TypeOf objGridLookUpEdit.Tag Is FormControlExt Then
        '    objFormControl = objGridLookUpEdit.Tag
        'Else
        '    objFormControl = New FormControlExt
        'End If
        'objFormControl.HandleObject = New GridLookUpEditHandle(objGridLookUpEdit)
        'objGridLookUpEdit.Tag = objFormControl
    End Sub
#End Region

#Region " Dành cho DataGridView "
    Public Function Grid_CheckValid(ByVal objGrid As DataGridView) As Boolean
        Dim mTable As DataTable
        If TypeOf objGrid.DataSource Is DataView Then
            mTable = DirectCast(objGrid.DataSource, DataView).Table
        ElseIf TypeOf objGrid.DataSource Is DataTable Then
            mTable = DirectCast(objGrid.DataSource, DataTable)
        Else
            Return True
        End If
        For Each mRow As DataRow In mTable.GetErrors
            If mRow.RowState <> DataRowState.Deleted Then
                Return False
            End If
        Next
        Return True
    End Function

    Public Sub Grid_FormatButtonColumn(ByVal clmButton As DataGridViewButtonColumn)
        clmButton.UseColumnTextForButtonValue = True
        clmButton.HeaderText = ""
        clmButton.DefaultCellStyle.BackColor = System.Drawing.SystemColors.Control
        clmButton.DefaultCellStyle.NullValue = clmButton.Text
        clmButton.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.Control
        clmButton.DefaultCellStyle.SelectionForeColor = System.Drawing.SystemColors.ControlText
    End Sub

    Public Sub Grid_SetColumnCopy(ByVal objColumn As DataColumn, Optional ByVal bSetOn As Boolean = True)
        If bSetOn Then
            objColumn.Caption = objColumn.ColumnName
        Else
            objColumn.Caption = "HIDE"
        End If
    End Sub

    Public Sub Grid_SetColumnViewOnly(ByVal objColumn As DataGridViewColumn, Optional ByVal bSetOn As Boolean = True)
        objColumn.ReadOnly = bSetOn
        If bSetOn Then
            objColumn.DefaultCellStyle.ForeColor = System.Drawing.Color.Gray
            'objColumn.Tag = objColumn.DefaultCellStyle.BackColor
            'objColumn.DefaultCellStyle.BackColor = Color.LightGray
        Else
            objColumn.DefaultCellStyle.ForeColor = System.Drawing.Color.Black
            'objColumn.DefaultCellStyle.BackColor = Nothing 'objColumn.Tag 
        End If
    End Sub

    Public Sub Grid_SetRowObject(ByVal objGrid As DataGridView, ByVal objInfo As Object)
        Dim mType As Type = objInfo.GetType
        For Each mProperty As System.Reflection.PropertyInfo In mType.GetProperties
            If objGrid.Columns.Contains(mProperty.Name) Then
                If TypeOf objGrid.Columns(mProperty.Name) Is DataGridViewCheckBoxColumn Then
                    If mProperty.GetValue(objInfo, Nothing) Then
                        objGrid.CurrentRow.Cells(mProperty.Name).Value = "1"
                    Else
                        objGrid.CurrentRow.Cells(mProperty.Name).Value = "0"
                    End If
                Else
                    objGrid.CurrentRow.Cells(mProperty.Name).Value = DB_GetNull(mProperty.GetValue(objInfo, Nothing))
                End If
            Else
                If Not objGrid.CurrentRow.IsNewRow Then
                    Dim objRow As DataRow
                    Try
                        If TypeOf objGrid.DataSource Is DataTable Then
                            objRow = CType(objGrid.DataSource, DataTable).Rows(objGrid.CurrentRow.Index)
                        Else
                            objRow = CType(objGrid.DataSource, DataView).Table.Rows(objGrid.CurrentRow.Index)
                        End If
                    Catch
                        Continue For
                    End Try
                    If objRow.Table.Columns.Contains(mProperty.Name) Then
                        If TypeOf mProperty.GetValue(objInfo, Nothing) Is Boolean Then
                            If mProperty.GetValue(objInfo, Nothing) Then
                                objRow.Item(mProperty.Name) = "1"
                            Else
                                objRow.Item(mProperty.Name) = "0"
                            End If
                        Else
                            objRow.Item(mProperty.Name) = DB_GetNull(mProperty.GetValue(objInfo, Nothing))
                        End If
                    End If
                End If
            End If
        Next
    End Sub

    Public Sub Grid_GetRowObject(ByVal objGrid As DataGridView, ByVal objInfo As Object)
        Dim mType As Type = objInfo.GetType
        Dim objValue As Object
        For Each mProperty As System.Reflection.PropertyInfo In mType.GetProperties
            If objGrid.Columns.Contains(mProperty.Name) Then
                objValue = objGrid.CurrentRow.Cells(mProperty.Name).Value
            Else
                If Not objGrid.CurrentRow.IsNewRow Then
                    Dim objRow As DataRow
                    Try
                        If TypeOf objGrid.DataSource Is DataTable Then
                            objRow = CType(objGrid.DataSource, DataTable).Rows(objGrid.CurrentRow.Index)
                        Else
                            objRow = CType(objGrid.DataSource, DataView).Table.Rows(objGrid.CurrentRow.Index)
                        End If
                    Catch
                        Continue For
                    End Try
                    If objRow.Table.Columns.Contains(mProperty.Name) Then
                        objValue = objRow.Item(mProperty.Name)
                    Else
                        Continue For
                    End If
                Else
                    Continue For
                End If
            End If
            If IsDBNull(objValue) Then
                ' translate Null value
                mProperty.SetValue(objInfo, Null.SetNull(mProperty), Nothing)
            Else
                If mProperty.PropertyType.Name = "Boolean" Then
                    mProperty.SetValue(objInfo, CType(objValue, Boolean), Nothing)
                Else
                    mProperty.SetValue(objInfo, Convert.ChangeType(objValue, mProperty.PropertyType), Nothing)
                End If
            End If
        Next
    End Sub

    Public Sub Grid_MoveSelect(ByVal dtgSource As DataGridView, ByVal dtgDest As DataGridView)
        Dim iCount As Integer = dtgSource.SelectedRows.Count
        While dtgSource.SelectedRows.Count > 0
            Dim dtgRow As DataGridViewRow = dtgSource.SelectedRows(dtgSource.SelectedRows.Count - 1)
            If TypeOf dtgSource.DataSource Is DataTable Then
                Dim arrItem As Object() = DirectCast(dtgRow.DataBoundItem, DataRowView).Row.ItemArray
                DirectCast(dtgDest.DataSource, DataTable).Rows.Add(arrItem)
            ElseIf TypeOf dtgSource.DataSource Is DataView Then
                Dim arrItem As Object() = DirectCast(dtgRow.DataBoundItem, DataRowView).Row.ItemArray
                DirectCast(dtgDest.DataSource, DataView).Table.Rows.Add(arrItem)
            Else
                dtgDest.Rows.Add(dtgRow.Clone)
            End If
            dtgSource.Rows.Remove(dtgRow)
            iCount -= 1
            If iCount = 0 Then
                dtgSource.ClearSelection()
                Exit While
            End If
        End While
    End Sub

    Public Sub Grid_MoveAll(ByVal dtgSource As DataGridView, ByVal dtgDest As DataGridView)
        Dim iCount As Integer = dtgSource.Rows.Count
        While dtgSource.Rows.Count > 0
            Dim dtgRow As DataGridViewRow = dtgSource.Rows(0)
            If TypeOf dtgSource.DataSource Is DataTable Then
                Dim arrItem As Object() = DirectCast(dtgRow.DataBoundItem, DataRowView).Row.ItemArray
                DirectCast(dtgDest.DataSource, DataTable).Rows.Add(arrItem)
            ElseIf TypeOf dtgSource.DataSource Is DataView Then
                Dim arrItem As Object() = DirectCast(dtgRow.DataBoundItem, DataRowView).Row.ItemArray
                DirectCast(dtgDest.DataSource, DataView).Table.Rows.Add(arrItem)
            Else
                dtgDest.Rows.Add(dtgRow.Clone)
            End If
            dtgSource.Rows.Remove(dtgRow)
            iCount -= 1
            If iCount = 0 Then
                dtgSource.ClearSelection()
                Exit While
            End If
        End While
    End Sub

    Public Sub Grid_SetRowDisplay(ByVal ctlGrid As DataGridView, ByVal sColumnName As String)
        Grid_SetRowDisplay(ctlGrid, sColumnName, 100)
    End Sub

    Public Sub Grid_SetRowDisplay(ByVal ctlGrid As DataGridView, ByVal sColumnName As String, ByVal iMaxHeight As Integer)
        For Each dtgRow As DataGridViewRow In ctlGrid.Rows
            If ctlGrid.Columns.Contains("Order_Code") Then
                dtgRow.Cells("Order_Code").Value = dtgRow.Index + 1
            End If
            dtgRow.Height = iMaxHeight
            dtgRow.Height = dtgRow.Cells(sColumnName).GetContentBounds(dtgRow.Index).Height + 10
        Next
    End Sub
#End Region

#Region " Dành cho TextEdit"
    'Public Sub TextEdit_SetEditNumeric(ByRef txtControl As TextEdit, Optional ByVal DecimaLength As Integer = 0)
    '    txtControl.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
    '    ''Set input number Only
    '    'txtControl.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    '    'txtControl.Properties.DisplayFormat.FormatString = "n" & DecimaLength
    '    ''for Edit
    '    'txtControl.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    '    'txtControl.Properties.EditFormat.FormatString = "n" & DecimaLength
    '    ''for Mark
    '    'txtControl.Properties.Mask.MaskType = Mask.MaskType.Numeric
    '    'txtControl.Properties.Mask.EditMask = "n" & DecimaLength
    'End Sub
#End Region

#Region " Dành cho DevExpress.LookupEdit"

    Public Sub LookupEdit_BindData_ByField(ByVal objList As Object _
                                  , ByVal mDataSource As Object _
                                  , ByVal mDisplayField As String _
                                  , ByVal mValueField As String _
                                  , ByVal sSelectedValue As String _
                                  , ByVal ParamArray arrayDisplayField() As Object)
        Dim sDisplayText As String
        Dim i As Integer

        If (arrayDisplayField Is Nothing) AndAlso (arrayDisplayField Is Nothing) Then
            ' Do nothing if we get no data
            Exit Sub
        End If

        objList.Properties.Columns.Clear()
        'Support Array in ParamArray 
        Dim iUpper As Integer = arrayDisplayField.GetUpperBound(0)
        If iUpper >= 0 AndAlso IsArray(arrayDisplayField(iUpper)) Then
            Dim arr() As Object = arrayDisplayField(iUpper)
            Array.Resize(arrayDisplayField, arrayDisplayField.Length + arr.Length - 1)
            For i = 0 To arr.Length - 1
                arrayDisplayField(iUpper + i) = arr(i)
            Next
        End If

        If sSelectedValue = "" Then
            sDisplayText = sSelectedValue
            If TypeOf mDataSource Is DataTable Then
                Dim mRow As DataRow = DirectCast(mDataSource, DataTable).NewRow()
                For Each mCol As DataColumn In mRow.Table.Columns
                    mCol.AllowDBNull = True
                Next

                If TypeOf mRow.Item(mValueField) Is Decimal Then
                    mRow.Item(mValueField) = Null.NullDecimal
                End If
                If TypeOf mRow.Item(mValueField) Is String Then
                    mRow.Item(mValueField) = Null.NullString
                End If

                If TypeOf mRow.Item(mValueField) Is Boolean Then
                    mRow.Item(mValueField) = Null.NullBoolean
                End If
                If TypeOf mRow.Item(mValueField) Is Integer Then
                    mRow.Item(mValueField) = Null.NullInteger
                End If

                If TypeOf mRow.Item(mValueField) Is Date Then
                    mRow.Item(mValueField) = Null.NullDate
                End If


                mRow.Item(mDisplayField) = sSelectedValue
                DirectCast(mDataSource, DataTable).Rows.InsertAt(mRow, 0)
                DirectCast(mDataSource, DataTable).AcceptChanges()
                objList.Properties.NullText = String.Empty
            End If
        End If

        ' The edit value matches the value of the ValueMember field
        objList.DataBindings.Clear()
        objList.DataBindings.Add("EditValue", mDataSource, mValueField)


        ' Specify the data source to display in the dropdown.
        objList.Properties.DataSource = mDataSource

        ' The field providing the editor's display text.
        objList.Properties.DisplayMember = mDisplayField
        ' The field matching the edit value.
        objList.Properties.ValueMember = mValueField

        ' Add colunm to GridLookupEdit
        ' Add colunm to GridLookupEdit
        Dim coll As LookUpColumnInfoCollection = objList.Properties.Columns
        Dim iColIndex As Integer = -1
        For Each fieldDisplay As String In arrayDisplayField
            iColIndex = coll.Add(New LookUpColumnInfo(fieldDisplay, 0))
            If TypeOf mDataSource Is DataTable Then
                If DirectCast(mDataSource, DataTable).Columns(fieldDisplay).DataType.Name = "DateTime" Then
                    coll(iColIndex).FormatType = FormatType.DateTime
                    coll(iColIndex).FormatString = "d"
                End If
            End If
        Next
        'Dim coll As LookUpColumnInfoCollection = objList.Properties.Columns
        'For Each fieldDisplay As String In arrayDisplayField
        '    coll.Add(New LookUpColumnInfo(fieldDisplay, 0))
        'Next

        objList.Properties.BestFitMode = BestFitMode.BestFitResizePopup
        objList.Properties.SearchMode = SearchMode.AutoComplete
        objList.Properties.AutoSearchColumnIndex = 0

        LookUpEdit_SetHandle(objList)
    End Sub

    Public Sub LookupEdit_BindData(ByVal objList As LookUpEdit _
                                 , ByVal mDataSource As Object _
                                 , ByVal mDisplayField As String _
                                 , ByVal mValueField As String _
                                 , ByVal sSelectedValue As String _
                                 , ByVal arrayDisplayField As ArrayList)

        Dim sDisplayText As String

        If (arrayDisplayField Is Nothing) Then
            ' Do nothing if we get no data
            Exit Sub
        End If

        If sSelectedValue = "" Then
            sDisplayText = sSelectedValue
            If TypeOf mDataSource Is DataTable Then
                Dim mRow As DataRow = DirectCast(mDataSource, DataTable).NewRow()
                For Each mCol As DataColumn In mRow.Table.Columns
                    mCol.AllowDBNull = True
                Next

                If TypeOf mRow.Item(mValueField) Is Decimal Then
                    mRow.Item(mValueField) = Null.NullDecimal
                End If
                If TypeOf mRow.Item(mValueField) Is String Then
                    mRow.Item(mValueField) = Null.NullString
                End If

                If TypeOf mRow.Item(mValueField) Is Boolean Then
                    mRow.Item(mValueField) = Null.NullBoolean
                End If
                If TypeOf mRow.Item(mValueField) Is Integer Then
                    mRow.Item(mValueField) = Null.NullInteger
                End If

                mRow.Item(mDisplayField) = sSelectedValue
                DirectCast(mDataSource, DataTable).Rows.InsertAt(mRow, 0)
                DirectCast(mDataSource, DataTable).AcceptChanges()
                objList.Properties.NullText = String.Empty
            ElseIf TypeOf mDataSource Is Object Then
                'ToDo: Add Null Object to LookUpEdit
                'Dim objNewUserControl As Object = Activator.CreateInstance(Type.GetType(className))
            End If
        End If

        objList.Properties.Columns.Clear()
        For Each obj As Object In arrayDisplayField
            If TypeOf obj Is LookupEdit_ColumnInfo Then
                If obj.FieldName <> "" Then
                    objList.Properties.Columns.Add(New LookUpColumnInfo(obj.FieldName, 0, obj.FieldLabel))
                End If
            End If
        Next

        ' Specify the data source to display in the dropdown.
        objList.Properties.DataSource = mDataSource
        objList.Properties.DisplayMember = mDisplayField
        objList.Properties.ValueMember = mValueField

        objList.Properties.BestFitMode = BestFitMode.BestFitResizePopup
        objList.Properties.SearchMode = SearchMode.AutoComplete
        objList.Properties.AutoSearchColumnIndex = 0
        If TypeOf mDataSource Is DataTable Then
            If DirectCast(mDataSource, DataTable).Rows.Count > 0 Then
                objList.EditValue = DirectCast(mDataSource, DataTable).Rows(0)(mValueField)
            End If
        End If

        LookUpEdit_SetHandle(objList)
    End Sub
#End Region

#Region " Dành cho DevExpress.GridLookupEdit"
    'Compare 2 Objec are  equas
    Private Function ObjectInforAreEquals(ByVal obj1 As Object, ByVal obj2 As Object) As Boolean
        Dim bRet As Boolean = False
        Try
            If obj1 Is Nothing Or obj2 Is Nothing Then
                If obj1 Is Nothing And obj2 Is Nothing Then
                    bRet = True
                Else
                    bRet = False
                End If
            Else
                Dim objProperty1 As PropertyInfo() = obj1.GetType.GetProperties
                Dim objProperty2 As PropertyInfo() = obj2.GetType.GetProperties

                Dim sValue1, sValue2 As String
                If objProperty1.Length = objProperty2.Length Then
                    Dim i As Integer
                    For i = 0 To objProperty1.Length - 1
                        If objProperty1(i).Name = objProperty2(i).Name Then
                            If objProperty1(i) IsNot Nothing AndAlso objProperty2(i) IsNot Nothing Then
                                sValue1 = objProperty1(i).GetValue(obj1, Nothing)
                                sValue2 = objProperty2(i).GetValue(obj2, Nothing)
                                If sValue1 <> sValue2 Then
                                    Exit For
                                End If
                            Else
                                Exit For
                            End If
                        Else
                            Exit For
                        End If
                    Next
                    If i = objProperty1.Length - 1 Then
                        bRet = True
                    End If
                End If
            End If
        Catch ex As Exception
            Message_Error(ex)
        End Try
        Return bRet
    End Function

    Private Sub GridLookupEdit_SetDataSource(ByVal objList As GridLookUpEdit _
                                    , ByVal mDataSource As Object _
                                    , ByVal mDisplayField As String _
                                    , ByVal mValueField As String _
                                    , ByVal sSelectedValue As String _
                                    , ByVal arrayDisplayField As ArrayList)
        'Check Datasource is nothing
        If mDataSource Is Nothing Then
            Exit Sub
        Else
            If Not ((TypeOf mDataSource Is DataSet) Or (TypeOf mDataSource Is DataTable)) Then
                Try
                    If mDataSource.Count = 0 Then
                        Exit Sub
                    End If
                Catch ex As Exception
                    Throw New Exception("DataSource type not support by function GridLookupEdit_BindData")
                End Try
            End If
        End If

        If objList.Tag IsNot Nothing AndAlso TypeOf (objList.Tag) Is FormControlExt Then
            If Not DirectCast(objList.Tag, FormControlExt).Required Then
                If TypeOf mDataSource Is DataTable Then
                    Dim mRow As DataRow = DirectCast(mDataSource, DataTable).NewRow()
                    For Each mCol As DataColumn In mRow.Table.Columns
                        mCol.AllowDBNull = True
                    Next

                    If TypeOf mRow.Item(mValueField) Is Decimal Then
                        mRow.Item(mValueField) = Null.NullDecimal
                    End If
                    If TypeOf mRow.Item(mValueField) Is String Then
                        mRow.Item(mValueField) = Null.NullString
                    End If

                    If TypeOf mRow.Item(mValueField) Is Boolean Then
                        mRow.Item(mValueField) = Null.NullBoolean
                    End If
                    If TypeOf mRow.Item(mValueField) Is Integer Then
                        mRow.Item(mValueField) = Null.NullInteger
                    End If

                    mRow.Item(mDisplayField) = sSelectedValue
                    DirectCast(mDataSource, DataTable).Rows.InsertAt(mRow, 0)
                    DirectCast(mDataSource, DataTable).AcceptChanges()
                    objList.Properties.NullText = String.Empty
                ElseIf mDataSource IsNot Nothing AndAlso mDataSource.GetType.IsGenericType Then
                    Dim objEmptyDataRow As Object = Activator.CreateInstance(mDataSource(0).GetType)
                    Dim objValueProperty As PropertyInfo = objEmptyDataRow.GetType.GetProperty(mValueField)

                    If objValueProperty.PropertyType.Name = "Decimal" Then
                        objValueProperty.SetValue(objEmptyDataRow, Null.NullDecimal, Nothing)
                    End If
                    If objValueProperty.PropertyType.Name = "String" Then
                        objValueProperty.SetValue(objEmptyDataRow, Null.NullString, Nothing)
                    End If
                    If objValueProperty.PropertyType.Name = "Boolean" Then
                        objValueProperty.SetValue(objEmptyDataRow, Null.NullBoolean, Nothing)
                    End If
                    If objValueProperty.PropertyType.Name = "Integer" Then
                        objValueProperty.SetValue(objEmptyDataRow, Null.NullInteger, Nothing)
                    End If

                    If Not ObjectInforAreEquals(mDataSource(0), objEmptyDataRow) Then
                        mDataSource.Insert(0, objEmptyDataRow)
                    End If
                End If
            End If
        End If

        objList.Properties.PopupFilterMode = PopupFilterMode.Contains
        objList.Properties.View.Columns.Clear()
        objList.Properties.View.FocusRectStyle = DrawFocusRectStyle.RowFocus
        objList.Properties.View.OptionsView.ShowGroupPanel = False

        For Each obj As Object In arrayDisplayField
            If TypeOf obj Is LookupEdit_ColumnInfo Then
                If obj.FieldName <> "" Then
                    objList.Properties.View.Columns.AddVisible(obj.FieldName, obj.FieldLabel)
                End If
            End If
        Next

        'Specify the data source to display in the dropdown.
        objList.Properties.DataSource = mDataSource
        objList.Properties.DisplayMember = mDisplayField
        objList.Properties.ValueMember = mValueField
        '
        objList.Properties.BestFitMode = BestFitMode.BestFitResizePopup

    End Sub

    Public Sub GridLookupEdit_BindData(ByVal objList As GridLookUpEdit _
                                    , ByVal mDataSource As Object _
                                    , ByVal mDisplayField As String _
                                    , ByVal mValueField As String _
                                    , ByVal sSelectedValue As String _
                                    , ByVal arrayDisplayField As ArrayList)

        'Check Datasource is nothing
        If mDataSource Is Nothing Then
            Exit Sub
        Else
            If Not ((TypeOf mDataSource Is DataSet) Or (TypeOf mDataSource Is DataTable)) Then
                Try
                    If mDataSource.Count = 0 Then
                        Exit Sub
                    End If
                Catch ex As Exception
                    Throw New Exception("DataSource type not support by function GridLookupEdit_BindData")
                End Try
            End If
        End If

        GridLookupEdit_SetDataSource(objList, mDataSource, mDisplayField, mValueField, sSelectedValue, arrayDisplayField)
        GridLookUpEdit_SetHandle(objList)
    End Sub

    Public Sub GridLookupEdit_BindData(ByVal objList As GridLookUpEdit _
                                    , ByVal mDataSource As Object _
                                    , ByVal mDisplayField As String _
                                    , ByVal mValueField As String _
                                    , ByVal sSelectedValue As String _
                                    , ByVal sDisplayLabelField As String _
                                    , ByVal arrayDisplayField As ArrayList)
        'Check Datasource is nothing
        If mDataSource Is Nothing Then
            Exit Sub
        Else
            If Not ((TypeOf mDataSource Is DataSet) Or (TypeOf mDataSource Is DataTable)) Then
                Try
                    If mDataSource.Count = 0 Then
                        Exit Sub
                    End If
                Catch ex As Exception
                    Throw New Exception("DataSource type not support by function GridLookupEdit_BindData")
                End Try
            End If
        End If

        GridLookupEdit_SetDataSource(objList, mDataSource, mDisplayField, mValueField, sSelectedValue, arrayDisplayField)
        Dim objFormControl As FormControlExt
        If (objList.Tag IsNot Nothing) AndAlso (TypeOf objList.Tag Is FormControlExt) Then
            objFormControl = objList.Tag
            objFormControl.DescFieldName = sDisplayLabelField
            objList.Tag = objFormControl
        End If
        GridLookUpEdit_SetHandle(objList)
    End Sub

    Public Sub GridLookupEdit_BindData(ByVal objList As GridLookUpEdit _
                                    , ByVal mDataSource As Object _
                                    , ByVal mDisplayField As String _
                                    , ByVal mValueField As String _
                                    , ByVal sSelectedValue As String _
                                    , ByVal sDisplayLabelField As String _
                                    , ByVal ctrDisplayControl As Control _
                                    , ByVal arrayDisplayField As ArrayList)

        'Check Datasource is nothing
        If mDataSource Is Nothing Then
            Exit Sub
        Else
            If Not ((TypeOf mDataSource Is DataSet) Or (TypeOf mDataSource Is DataTable)) Then
                Try
                    If mDataSource.Count = 0 Then
                        Exit Sub
                    End If
                Catch ex As Exception
                    Throw New Exception("DataSource type not support by function GridLookupEdit_BindData")
                End Try
            End If
        End If

        GridLookupEdit_SetDataSource(objList, mDataSource, mDisplayField, mValueField, sSelectedValue, arrayDisplayField)
        Dim objFormControl As FormControlExt
        If (objList.Tag IsNot Nothing) AndAlso (TypeOf objList.Tag Is FormControlExt) Then
            objFormControl = objList.Tag
            If ctrDisplayControl IsNot Nothing Then
                'Current support only TextEdit, add more if need
                If TypeOf ctrDisplayControl Is TextEdit Then
                    objFormControl.DescFieldObject = ctrDisplayControl
                End If
            End If
            objFormControl.DescFieldName = sDisplayLabelField
            objList.Tag = objFormControl
            GridLookUpEdit_SetHandle(objList)
        End If
    End Sub
#End Region

#Region " Dành cho DevExpress.XtraGrid"
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="grvGridView"></param>
    ''' <param name="itemName"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Grid_GetDataRowItemDecimal(ByVal grvGridView As GridView, ByVal itemName As String) As Decimal

        Dim currentRow As DataRow = grvGridView.GetDataRow(grvGridView.FocusedRowHandle)
        If currentRow Is Nothing Then
            Return 0
        End If

        Return Decimal.Parse(currentRow(itemName).ToString())

    End Function

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="grvGridView"></param>
    ''' <param name="itemName"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Grid_GetDataRowItemString(ByVal grvGridView As GridView, ByVal itemName As String) As String

        Dim currentRow As DataRow = grvGridView.GetDataRow(grvGridView.FocusedRowHandle)
        If currentRow Is Nothing Then
            Return Nothing
        End If
        Return currentRow(itemName).ToString()
    End Function

    Public Function Grid_GetDataRowItemInteger(ByVal grvGridView As GridView, ByVal itemName As String) As Integer

        Dim currentRow As DataRow = grvGridView.GetDataRow(grvGridView.FocusedRowHandle)
        If currentRow Is Nothing Then
            Return 0
        End If

        Return Integer.Parse(currentRow(itemName).ToString())

    End Function

    Public Sub Grid_LoadData(ByVal gridviewName As GridView, ByVal table As Object)
        Dim indexVal As Integer = -1
        indexVal = gridviewName.GetFocusedDataSourceRowIndex
        gridviewName.GridControl.DataSource = table
        If indexVal >= 0 And table IsNot Nothing Then
            gridviewName.GridControl.BindingContext(table).Position = indexVal
        End If
    End Sub

    Public Sub Grid_AddRow(ByVal grv As DevExpress.XtraGrid.Views.Grid.GridView)
        If TypeOf (grv.DataSource) Is DataView Then
            CType(grv.DataSource, DataView).AddNew()
        Else
            Throw New Exception("Not support type data source")
        End If
    End Sub

    Public Sub Grid_DeleteSelectRows(ByVal grv As DevExpress.XtraGrid.Views.Grid.GridView)
        grv.DeleteSelectedRows()
    End Sub

    Public Function Grid_GetDeletedRows(ByVal grv As DevExpress.XtraGrid.Views.Grid.GridView) As DataView
        If TypeOf (grv.DataSource) Is DataView Then
            Dim dv As DataView = CType(grv.DataSource, DataView)
            dv.RowStateFilter = DataViewRowState.Deleted
            Return dv
        Else
            Throw New Exception("Not support type data source")
        End If
    End Function

    Public Function Grid_GetUpdatedRows(ByVal grv As DevExpress.XtraGrid.Views.Grid.GridView) As DataView
        If TypeOf (grv.DataSource) Is DataView Then
            Dim dv As DataView = CType(grv.DataSource, DataView)
            dv.RowStateFilter = DataViewRowState.ModifiedCurrent
            Return dv
        Else
            Throw New Exception("Not support type data source")
        End If
    End Function

    Public Function Grid_GetAddedRows(ByVal grv As DevExpress.XtraGrid.Views.Grid.GridView) As DataView
        If TypeOf (grv.DataSource) Is DataView Then
            Dim dv As DataView = CType(grv.DataSource, DataView)
            dv.RowStateFilter = DataViewRowState.Added
            Return dv
        Else
            Throw New Exception("Not support type data source")
        End If
    End Function

    Public Sub Grid_BindDataLookupEdit(ByVal objList As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit _
                                    , ByVal mDataSource As DataTable _
                                    , ByVal mDisplayField As String _
                                    , ByVal mValueField As String _
                                    , ByVal ParamArray arrayDisplayField() As Object _
                                   )
        objList.Columns.Clear()
        ' Specify the data source to display in the dropdown.
        objList.DataSource = mDataSource
        ' The field providing the editor's display text.
        objList.DisplayMember = mDisplayField
        ' The field matching the edit value.
        objList.ValueMember = mValueField

        ' Add colunm to GridLookupEdit
        Dim coll As LookUpColumnInfoCollection = objList.Columns
        For Each fieldDisplay As String In arrayDisplayField
            coll.Add(New LookUpColumnInfo(fieldDisplay, 0))
        Next
        '
        objList.BestFitMode = BestFitMode.BestFitResizePopup
    End Sub

    'Get select datarow on ListOfValue
    Public Function Grid_Combo_GetDataRow(ByVal grv As GridView, ByVal lueData As LookUpEdit) As DataRow
        Dim row As DataRow = Nothing
        Dim drvData As DataRowView

        drvData = TryCast(lueData.Properties.GetDataSourceRowByKeyValue(lueData.EditValue), DataRowView)
        If drvData IsNot Nothing Then
            row = drvData.Row
        End If
        '
        Return row
    End Function
#End Region

#Region "Export Function "

    Public Sub SetLicenseSpreadsheet()
        'Dim licenseSpreadsheet As String = Commons.Instance.getKeyValueByKeyName("LicenseSpreadsheet")
        'SpreadsheetInfo.SetLicense(licenseSpreadsheet)
    End Sub

    Public Sub Export_GridToExcel(ByVal gridviewName As GridView)
        'Edit by TienNQ
        'Using SaveFile As New SaveFileDialog
        '    SaveFile.Filter = "Excel (*.xls)|*.xls"
        '    If SaveFile.ShowDialog = Windows.Forms.DialogResult.OK Then
        '        gridviewName.ExportToXls(SaveFile.FileName)
        '        Message_Information("Báo cáo đã được lưu tới: " + SaveFile.FileName)
        '    End If
        'End Using

    End Sub

    Public Sub Export_TableToExcel(ByVal dataTable As DataTable, ByVal sheetName As String, ByVal startPossison As String)

        'SetLicenseSpreadsheet()
        'Dim ef As ExcelFile = New ExcelFile
        'Dim worksheet As ExcelWorksheet = ef.Worksheets.Add(sheetName)
        'worksheet.InsertDataTable(dataTable, startPossison, True)

        'Using SaveFile As New SaveFileDialog
        '    SaveFile.Filter = "Excel (*.xls)|*.xls"
        '    If SaveFile.ShowDialog = Windows.Forms.DialogResult.OK Then
        '        ef.SaveXls(SaveFile.FileName)
        '    End If
        'End Using

    End Sub

    'Public Sub Export_TableToExcelTemplate(ByVal worksheet As ExcelWorksheet, ByVal dataTable As DataTable, ByVal startPossison As String)

    '    SetLicenseSpreadsheet()

    '    worksheet.InsertDataTable(dataTable, startPossison, True)

    'End Sub

    'Public Sub Export_SaveExcelFile(ByVal ef As ExcelFile)

    '    SetLicenseSpreadsheet()
    '    Using SaveFile As New SaveFileDialog
    '        SaveFile.Filter = "Excel (*.xls)|*.xls"
    '        If SaveFile.ShowDialog = Windows.Forms.DialogResult.OK Then
    '            ef.SaveXls(SaveFile.FileName)
    '        End If
    '    End Using

    'End Sub

    'Function Export_GetExcelTemplateFile(ByVal fileTemplateName As String) As ExcelFile

    '    SetLicenseSpreadsheet()
    '    Dim ef As ExcelFile = New ExcelFile
    '    Dim myMod As System.Reflection.Module = Assembly.GetExecutingAssembly().GetModules()(0)
    '    Dim aPath As String = Path.GetFullPath(Path.GetDirectoryName(myMod.FullyQualifiedName))
    '    aPath = aPath.Replace("bin\Debug", "\")
    '    aPath = aPath + Commons.getKeyValueByKeyName("URLFileTemplate") + fileTemplateName + ".xls"

    '    ef.LoadXls(aPath)

    '    Return ef

    'End Function

#End Region

#Region "Import Function "

    Public Function Import_ExcelFile(ByVal fileTemplateName As String) As DataSet
        'SetLicenseSpreadsheet()
        'Dim ef As ExcelFile = New ExcelFile()
        'If fileTemplateName.ToUpper.EndsWith(".XLS") Then
        '    ef.LoadXls(fileTemplateName, XlsOptions.None)
        'ElseIf fileTemplateName.ToUpper.EndsWith(".XLSX") Then
        '    'ef.LoadXlsx(fileTemplateName, XlsxOptions.None)
        'End If
        'Dim ds As New DataSet
        'For Each ws As GemBox.Spreadsheet.ExcelWorksheet In ef.Worksheets
        '    If ws.Rows.Count > 0 Then
        '        Dim dataTable As New DataTable
        '        ' Depending on the format of the input file, you need to change this:
        '        Dim noCol As Integer = 0
        '        Do
        '            Dim sName As String = ws.Cells(0, noCol).Value
        '            If Not sName Is Nothing Then
        '                dataTable.Columns.Add(sName.Trim, GetType(String))
        '                noCol += 1
        '            Else
        '                Exit Do
        '            End If
        '        Loop While noCol < 10000

        '        For i As Integer = 1 To ws.Rows.Count - 1
        '            Dim arrRow(noCol - 1) As Object
        '            For j As Integer = 0 To noCol - 1
        '                arrRow(j) = ws.Rows(i).Cells(j).Value
        '            Next
        '            dataTable.Rows.Add(arrRow)
        '        Next

        '        dataTable.TableName = ws.Name.Trim
        '        ds.Tables.Add(dataTable)
        '    End If
        'Next
        Return Nothing
    End Function

    '    Public Function Import_ExcelFile(ByVal fileTemplateName As String, ByVal listData As List(Of ObjImportExcel)) As DataSet
    '        SetLicenseSpreadsheet()
    '        Dim ef As ExcelFile = New ExcelFile()
    '        If fileTemplateName.ToUpper.EndsWith(".XLS") Then
    '            ef.LoadXls(fileTemplateName, XlsOptions.None)
    '            'ElseIf fileTemplateName.ToUpper.EndsWith(".XLSX") Then
    '            '    ef.LoadXlsx(fileTemplateName, XlsxOptions.None)
    '        End If
    '        Dim ds As New DataSet
    '        For Each oImportExcel As ObjImportExcel In listData
    '            Dim dt As New DataTable
    '            For Each col As Import_Excel In oImportExcel.DataTableImportExcel.ImpExcels
    '                dt.Columns.Add(col.ColumnName)
    '            Next
    '            dt.TableName = oImportExcel.SheetName

    '            For Each ws As GemBox.Spreadsheet.ExcelWorksheet In ef.Worksheets
    '                If ws.Name = oImportExcel.SheetName Then
    '                    If ws.Rows.Count > 0 Then
    '                        'ws.InsertDataTable(dt, oImportExcel.DataTableImportExcel.StartRow, 0, False)
    '                        'Exit For
    '                        For j As Integer = oImportExcel.DataTableImportExcel.StartRow To ws.Rows.Count - 1
    '                            Dim arrRow As DataRow = dt.NewRow

    '                            For Each col As Import_Excel In oImportExcel.DataTableImportExcel.ImpExcels
    '                                If col.IndexColumn >= 0 Then

    '                                    If col.DataType = 0 Then
    '                                        arrRow(col.ColumnName) = ws.Rows(j).Cells(col.IndexColumn).Value
    '                                    ElseIf col.DataType = 1 Then
    '                                        Try
    '                                            arrRow(col.ColumnName) = String.Format("{0:dd/MM/yyyy}", DateTime.Parse(ws.Rows(j).Cells(col.IndexColumn).Value))
    '                                        Catch ex As Exception
    '                                            arrRow(col.ColumnName) = String.Empty
    '                                        End Try
    '                                    ElseIf col.DataType = 2 Then
    '                                        Try
    '                                            arrRow(col.ColumnName) = String.Format("{0:HH:mm}", DateTime.Parse(ws.Rows(j).Cells(col.IndexColumn).Value))
    '                                        Catch ex As Exception
    '                                            arrRow(col.ColumnName) = String.Empty
    '                                        End Try
    '                                    ElseIf col.DataType = 4 Then
    '                                        Try
    '                                            arrRow(col.ColumnName) = String.Format("{0:#,##0.00}", Decimal.Parse(ws.Rows(j).Cells(col.IndexColumn).Value))
    '                                        Catch ex As Exception
    '                                            arrRow(col.ColumnName) = String.Empty
    '                                        End Try
    '                                    ElseIf col.DataType = 5 Then
    '                                        Try
    '                                            arrRow(col.ColumnName) = String.Format("{0:#,###}", Decimal.Parse(ws.Rows(j).Cells(col.IndexColumn).Value))
    '                                        Catch ex As Exception
    '                                            arrRow(col.ColumnName) = String.Empty
    '                                        End Try
    '                                    End If

    '                                    If col.isRequired = True And String.IsNullOrEmpty(Convert.ToString(arrRow(col.ColumnName))) Then
    '                                        GoTo ExitFor
    '                                    End If
    '                                End If
    '                            Next

    '                            dt.Rows.Add(arrRow)
    '                        Next
    '                    End If
    '                End If
    '            Next
    'ExitFor:
    '            ds.Tables.Add(dt)
    '        Next

    '        Return ds
    '    End Function

    Public Function Import_ExcelFile_TruckingLan(ByVal fileTemplateName As String, ByVal array As String(), ByVal nRow As Int32) As DataSet
        'SetLicenseSpreadsheet()
        'Dim ef As ExcelFile = New ExcelFile()
        'If fileTemplateName.ToUpper.EndsWith(".XLS") Then
        '    ef.LoadXls(fileTemplateName, XlsOptions.None)
        'ElseIf fileTemplateName.ToUpper.EndsWith(".XLSX") Then
        '    'ef.LoadXlsx(fileTemplateName, XlsxOptions.None)
        'End If
        'Dim ds As New DataSet
        'For Each ws As GemBox.Spreadsheet.ExcelWorksheet In ef.Worksheets
        '    If ws.Rows.Count >= nRow Then
        '        Dim dataTable As New DataTable

        '        For Each arr As String In array
        '            dataTable.Columns.Add(arr.Trim, GetType(String))
        '        Next

        '        For i As Integer = nRow - 1 To ws.Rows.Count - 1
        '            Dim arrRow(array.Count - 1) As Object
        '            If Not String.IsNullOrEmpty(Convert.ToString(ws.Rows(i).Cells(0).Value).Trim) Then
        '                For j As Integer = 0 To array.Count - 1
        '                    arrRow(j) = ws.Rows(i).Cells(j).Value
        '                Next
        '                dataTable.Rows.Add(arrRow)
        '            Else
        '                Continue For
        '            End If
        '        Next
        '        dataTable.TableName = ws.Name.Trim
        '        ds.Tables.Add(dataTable)

        '    End If
        'Next
        Return Nothing
    End Function

    Public Function Import_ExcelTest(ByVal fileTemplateName As String) As DataSet
        'SetLicenseSpreadsheet()
        'Dim ef As ExcelFile = New ExcelFile()
        'If fileTemplateName.ToUpper.EndsWith(".XLS") Then
        '    ef.LoadXls(fileTemplateName, XlsOptions.None)
        'ElseIf fileTemplateName.ToUpper.EndsWith(".XLSX") Then
        '    'ef.LoadXlsx(fileTemplateName, XlsxOptions.None)
        'End If
        'Dim ds As New DataSet
        'For Each ws As GemBox.Spreadsheet.ExcelWorksheet In ef.Worksheets
        '    If ws.Rows.Count > 0 Then
        '        Dim dataTable As New DataTable
        '        ' Depending on the format of the input file, you need to change this:
        '        Dim str As String = ws.Cells("A14").Value
        '        MessageBox.Show(str)
        '    End If
        'Next
        Return Nothing
    End Function
#End Region

#Region "Save File As .CSV File "
    Public Function saveCSV(ByVal fileName As String, ByVal listData As List(Of String)) As List(Of String)
        'Try
        '    SetLicenseSpreadsheet()
        '    Dim listFileLocation As New List(Of String)
        '    Dim excel As New ExcelFile
        '    Dim file As String = ""
        '    'Get file name
        '    Dim excelFileName As String = fileName.Substring(fileName.LastIndexOf("\"c)) ' Get file name

        '    Dim currentLocation As String = Application.ExecutablePath
        '    currentLocation = currentLocation.Replace(currentLocation.Substring(currentLocation.LastIndexOf("\"c)), "")

        '    ' Create folder Temp to save file .csv
        '    If Not My.Computer.FileSystem.DirectoryExists(currentLocation & "\" & "Temp") = True Then
        '        My.Computer.FileSystem.CreateDirectory(currentLocation & "\" & "Temp")
        '    End If

        '    Dim pathSave As String = currentLocation & "\" & "Temp" ' Directory to save file .csv

        '    'Check excel file to load
        '    'Hien tai framework chua import duoc file excel 2007
        '    If fileName.ToUpper.EndsWith(".XLS") Then ' 2003
        '        excel.LoadXls(fileName, XlsOptions.PreserveWorksheetRecords)
        '        excelFileName = excelFileName.Substring(0, excelFileName.Length - 4)
        '        'ElseIf fileName.ToUpper.EndsWith(".XLSX") Then ' 2007
        '        'excel.LoadXlsxFromDirectory(fileName, XlsxOptions.None)
        '        'excelFileName = excelFileName.Substring(0, excelFileName.Length - 5)
        '    End If

        '    If fileName.ToUpper.EndsWith(".CSV") Then ' 2003
        '        excel.LoadCsv(fileName, CsvType.CommaDelimited)
        '        excelFileName = excelFileName.Substring(0, excelFileName.Length - 4)
        '        'ElseIf fileName.ToUpper.EndsWith(".XLSX") Then ' 2007
        '        'excel.LoadXlsxFromDirectory(fileName, XlsxOptions.None)
        '        'excelFileName = excelFileName.Substring(0, excelFileName.Length - 5)
        '    End If

        '    ' If GemBox.Spreadsheet.
        '    For Each ws As GemBox.Spreadsheet.ExcelWorksheet In excel.Worksheets
        '        If ws.Rows.Count > 0 Then
        '            For i As Integer = 0 To listData.Count - 1
        '                If ws.Name = listData.Item(i).ToString Then
        '                    excel.Worksheets.ActiveWorksheet = ws

        '                    file = pathSave.Trim & excelFileName & "_" & ws.Name & "." & "csv"
        '                    listFileLocation.Add(file)

        '                    'Delete if file is exists
        '                    If My.Computer.FileSystem.FileExists(file) = True Then
        '                        My.Computer.FileSystem.DeleteFile(file)
        '                    End If

        '                    'Save file

        '                    excel.SaveCsv(file, CsvType.CommaDelimited)
        '                End If
        '            Next
        '        End If
        '    Next
        '    Return listFileLocation
        'Catch ex As Exception
        '    Message_Error(ex)
        '    Return Nothing
        'End Try
        Return Nothing
    End Function
#End Region

#Region "Import .CSV File"
    Public Function Import_CsvFile( _
                                    ByVal i_dsImport As DataSet, ByVal listFile As List(Of String), _
                                    ByVal i_columnsIndex As Integer(), ByVal i_fileInfo As Integer(), _
                                    ByVal i_fieldRequire As Integer()) As DataSet
        'Try
        '    SetLicenseSpreadsheet()
        '    Dim m_dsImport As DataSet = i_dsImport
        '    Dim excel As ExcelFile = New ExcelFile()
        '    Dim m_listFile As List(Of String) = listFile
        '    Dim m_columnsIndex As Integer() = i_columnsIndex
        '    Dim m_fieldRequire As Integer() = i_fieldRequire
        '    If m_listFile.Count > 0 Then
        '        For i As Integer = 0 To listFile.Count - 1
        '            If listFile.Item(i).EndsWith(".csv") Then
        '                excel.LoadCsv(listFile.Item(i).ToString, CsvType.SemicolonDelimited)
        '                For Each ws As GemBox.Spreadsheet.ExcelWorksheet In excel.Worksheets
        '                    If ws.Rows.Count > 0 Then
        '                        Dim m_dtImport As DataTable = m_dsImport.Tables(0)
        '                        For j As Integer = i_fileInfo.GetValue(0) To ws.Rows.Count - 1
        '                            Dim arrRow(m_dtImport.Columns.Count - 1) As Object

        '                            For k As Integer = 0 To m_dtImport.Columns.Count - 1
        '                                For x As Integer = 0 To m_fieldRequire.Count - 1
        '                                    'm_columnsIndex.GetValue(k) : index of excel file want to get <Define when button import click>
        '                                    arrRow(k) = ws.Rows(j).Cells(m_columnsIndex.GetValue(k)).Value

        '                                Next

        '                            Next
        '                            m_dtImport.Rows.Add(arrRow)
        '                        Next

        '                    End If
        '                Next
        '            End If
        '        Next

        '    End If
        '    Return m_dsImport
        'Catch ex As Exception
        '    Message_Error(ex)
        '    Return Nothing
        'End Try
        Return Nothing
    End Function

    Public Function Import_XLSCSVFileTest() As DataTable
        'Try
        '    SetLicenseSpreadsheet()
        '    Dim excel As ExcelFile = New ExcelFile()
        '    Dim dataTable As New DataTable
        '    excel.LoadXls("C:/CKD request &  stock confirm daily.xls", XlsOptions.PreserveAll)
        '    For Each ws As GemBox.Spreadsheet.ExcelWorksheet In excel.Worksheets
        '        If ws.Rows.Count > 0 Then
        '            Dim sName As Object = ws.Cells("H22").Value
        '            Dim dt As String = DateTime.FromOADate(sName).ToString("HH:mm")
        '        End If
        '    Next
        '    Return dataTable
        'Catch ex As Exception
        '    Return Nothing
        '    Message_Error(ex)
        'End Try
        Return Nothing
    End Function
#End Region

#Region "Save File As .CSV File Class"
    'Public Function saveListCSV(ByVal fileName As String, ByVal listData As List(Of ObjImportExcel)) As List(Of ObjImportExcel)
    '    Try
    '        SetLicenseSpreadsheet()
    '        Dim LObjImportExcel As List(Of ObjImportExcel) = listData

    '        For Each clearObjImportExcel As ObjImportExcel In LObjImportExcel
    '            clearObjImportExcel.SheetPath = String.Empty
    '        Next

    '        Dim excel As New ExcelFile
    '        Dim file As String = String.Empty

    '        'Get file name
    '        Dim excelFileName As String = fileName.Substring(fileName.LastIndexOf("\"c)) ' Get file name

    '        Dim currentLocation As String = Application.ExecutablePath
    '        currentLocation = currentLocation.Replace(currentLocation.Substring(currentLocation.LastIndexOf("\"c)), String.Empty)

    '        ' Create folder Temp to save file .csv
    '        If Not My.Computer.FileSystem.DirectoryExists(currentLocation & "\" & "Temp") = True Then
    '            My.Computer.FileSystem.CreateDirectory(currentLocation & "\" & "Temp")
    '        End If

    '        Dim pathSave As String = currentLocation & "\" & "Temp" ' Directory to save file .csv

    '        'Check excel file to load
    '        'Hien tai framework chua import duoc file excel 2007
    '        If fileName.ToUpper.EndsWith(".XLS") Then ' 2003
    '            excel.LoadXls(fileName, XlsOptions.PreserveWorksheetRecords)
    '            excelFileName = excelFileName.Substring(0, excelFileName.Length - 4)
    '        End If

    '        ' If GemBox.Spreadsheet.
    '        For Each ws As GemBox.Spreadsheet.ExcelWorksheet In excel.Worksheets
    '            If ws.Rows.Count > 0 Then
    '                For Each imp As ObjImportExcel In LObjImportExcel
    '                    If ws.Name = imp.SheetName Then
    '                        excel.Worksheets.ActiveWorksheet = ws

    '                        file = String.Format("{0}{1}_{2}.csv", pathSave.Trim, excelFileName, ws.Name)
    '                        ' Add Path

    '                        imp.SheetPath = file

    '                        'Delete if file is exists
    '                        If My.Computer.FileSystem.FileExists(file) = True Then
    '                            My.Computer.FileSystem.DeleteFile(file)
    '                        End If

    '                        'Save file
    '                        excel.SaveCsv(file, CsvType.CommaDelimited)
    '                        Exit For
    '                    End If
    '                Next
    '            End If
    '        Next
    '        Return LObjImportExcel
    '    Catch ex As Exception
    '        Message_Error(ex)
    '        Return Nothing
    '    End Try
    'End Function
#End Region

#Region "Import Excel Class"
    'Public Function Import_Csv_File(ByVal imp_Excels As PRLS_Import_Excel) As DataTable
    '    Try
    '        SetLicenseSpreadsheet()
    '        Dim excel As ExcelFile = New ExcelFile()
    '        ' Return DataTable
    '        Dim dt_Import As New DataTable
    '        ' Check Field isRequired
    '        Dim flag As Boolean = False

    '        If imp_Excels.ImpExcels.Count > 0 Then
    '            'Create Colunm DataTable
    '            For Each col As Import_Excel In imp_Excels.ImpExcels
    '                dt_Import.Columns.Add(col.ColumnName)
    '            Next
    '        Else
    '            Return Nothing
    '        End If

    '        If imp_Excels.FileExcelPath.EndsWith(".csv") Then
    '            excel.LoadCsv(imp_Excels.FileExcelPath, CsvType.CommaDelimited)
    '        ElseIf imp_Excels.FileExcelPath.ToUpper.EndsWith(".XLS") Then
    '            excel.LoadXls(imp_Excels.FileExcelPath, XlsOptions.PreserveWorksheetRecords)
    '        ElseIf imp_Excels.FileExcelPath.ToUpper.EndsWith(".XLSX") Then
    '            excel.LoadXls(imp_Excels.FileExcelPath, XlsOptions.PreserveWorksheetRecords)
    '        Else
    '            Message_Information("Parameter File Not Found!")
    '            Return Nothing
    '        End If
    '        Dim ws As GemBox.Spreadsheet.ExcelWorksheet = excel.Worksheets(0)
    '        If ws.Rows.Count > 0 Then
    '            Dim m_dtImport As DataTable = dt_Import
    '            For j As Integer = imp_Excels.StartRow To ws.Rows.Count - 1
    '                Dim arrRow As DataRow = dt_Import.NewRow

    '                For Each col As Import_Excel In imp_Excels.ImpExcels

    '                    If col.DataType = 0 Then
    '                        arrRow(col.ColumnName) = ws.Rows(j).Cells(col.IndexColumn).Value
    '                    ElseIf col.DataType = 1 Then
    '                        Try
    '                            arrRow(col.ColumnName) = String.Format("{0:dd/MM/yyyy}", DateTime.Parse(ws.Rows(j).Cells(col.IndexColumn).Value))
    '                        Catch ex As Exception
    '                            arrRow(col.ColumnName) = String.Empty
    '                        End Try
    '                    ElseIf col.DataType = 2 Then
    '                        Try
    '                            arrRow(col.ColumnName) = String.Format("{0:HH:mm}", DateTime.Parse(ws.Rows(j).Cells(col.IndexColumn).Value))
    '                        Catch ex As Exception
    '                            arrRow(col.ColumnName) = String.Empty
    '                        End Try
    '                    ElseIf col.DataType = 4 Then
    '                        Try
    '                            arrRow(col.ColumnName) = String.Format("{0:#,##0.00}", Decimal.Parse(ws.Rows(j).Cells(col.IndexColumn).Value))
    '                        Catch ex As Exception
    '                            arrRow(col.ColumnName) = String.Empty
    '                        End Try
    '                    ElseIf col.DataType = 5 Then
    '                        Try
    '                            arrRow(col.ColumnName) = String.Format("{0:#,###}", Decimal.Parse(ws.Rows(j).Cells(col.IndexColumn).Value))
    '                        Catch ex As Exception
    '                            arrRow(col.ColumnName) = String.Empty
    '                        End Try
    '                    End If

    '                    If col.isRequired = True And String.IsNullOrEmpty(Convert.ToString(arrRow(col.ColumnName))) Then
    '                        flag = True
    '                        Exit For
    '                    End If
    '                Next

    '                If Not flag Then
    '                    m_dtImport.Rows.Add(arrRow)
    '                End If
    '            Next
    '        End If
    '        Return dt_Import
    '    Catch ex As Exception
    '        Message_Error(ex)
    '        Return Nothing
    '    End Try
    'End Function
#End Region

#Region "SendMail"

    Public Sub SendMail(ByVal FromEmail As String, ByVal ToEmail As String, ByVal Subject As String, ByVal Body As String, ByVal SMTPServer As String)
        Dim myMessage As New System.Net.Mail.MailMessage(FromEmail, ToEmail, Subject, Body)

        Try


            Dim EmailServer As New System.Net.Mail.SmtpClient(SMTPServer)

            EmailServer.Send(myMessage)

        Catch myexp As Exception
            'MsgBox(myexp.Message)
        End Try
    End Sub
    Public Sub SendMail(ByVal FromEmail As String, ByVal ToEmail As String, ByVal Subject As String, ByVal Body As String, ByVal SMTPServer As String, ByVal Port As String, ByVal Username As String, ByVal Password As String)
        Dim myMessage As New System.Net.Mail.MailMessage(FromEmail, ToEmail, Subject, Body)

        Try

            Dim EmailServer As New System.Net.Mail.SmtpClient(SMTPServer)

            EmailServer.Port = Integer.Parse(Port)

            EmailServer.EnableSsl = True

            EmailServer.Credentials = New Net.NetworkCredential(Username, Password)

            EmailServer.Send(myMessage)

        Catch myexp As Exception
            'MsgBox(myexp.Message)
        End Try
    End Sub
#End Region

#Region "Import CPL"
    Public Function Import_CPL(ByVal fileLocation As String) As DataSet
        'SetLicenseSpreadsheet()
        'Dim ef As ExcelFile = New ExcelFile()
        'Dim ds As New DataSet
        'If fileLocation.EndsWith(".csv") Then
        '    ef.LoadCsv(fileLocation, CsvType.CommaDelimited)
        '    Dim ws As GemBox.Spreadsheet.ExcelWorksheet = ef.Worksheets(0)
        '    If ws.Rows.Count > 0 Then

        '        Dim dataTable As New DataTable

        '        For i As Integer = 0 To 24
        '            Dim sName As String = ws.Cells(0, i).Value
        '            If Not String.IsNullOrEmpty(sName) Then
        '                dataTable.Columns.Add(sName.Trim, GetType(String))
        '            Else
        '                dataTable.Columns.Add("FIXLOTNULL_" & i, GetType(String))
        '            End If
        '        Next

        '        For i As Integer = 1 To ws.Rows.Count - 1
        '            Dim arrRow(24) As Object
        '            For j As Integer = 0 To 24
        '                If Not String.IsNullOrEmpty(ws.Rows(i).Cells(2).Value) Then
        '                    arrRow(j) = ws.Rows(i).Cells(j).Value
        '                End If
        '            Next
        '            dataTable.Rows.Add(arrRow)
        '        Next
        '        dataTable.TableName = ws.Name.Trim
        '        ds.Tables.Add(dataTable)
        '    End If
        'End If
        'Return ds
        Return Nothing
    End Function
#End Region

#Region "Import Cost SPP"
    ' Function to import data for Cost SPP
    Public Function Import_TextFile( _
                                        ByVal colIndex As Integer, _
                                        ByVal hasHeaders As Boolean, _
                                        ByVal FilePath As String, _
                                        ByVal readType As Integer) As DataSet
        'Try
        '    Dim m_dsImport As New DataSet
        '    Dim excel As New ExcelFile
        '    'Check file input
        '    If Not FilePath.ToString.ToUpper.Trim.EndsWith(".TXT") Then
        '        Message_Information("Invalid file.")
        '        Return Nothing
        '    End If

        '    excel.LoadCsv(FilePath, readType)

        '    For Each ws As GemBox.Spreadsheet.ExcelWorksheet In excel.Worksheets
        '        Dim dt As New DataTable
        '        Dim noCol As Integer = 0
        '        If ws.Rows.Count > 0 Then

        '            If hasHeaders = True Then

        '                Do
        '                    Dim sName As String = ws.Cells(0, noCol).Value
        '                    If Not sName Is Nothing Then
        '                        dt.Columns.Add(sName.Trim, GetType(String))
        '                        noCol += 1
        '                    Else
        '                        Exit Do
        '                    End If
        '                Loop While noCol < 10000

        '                For i As Integer = 1 To ws.Rows.Count - 1

        '                    Dim arrRow(noCol - 1) As Object
        '                    For j As Integer = 0 To noCol - 1
        '                        arrRow(j) = ws.Rows(i).Cells(j).Value
        '                    Next
        '                    dt.Rows.Add(arrRow)
        '                Next

        '            Else
        '                For i As Integer = 0 To colIndex - 1
        '                    Dim sName As String = ws.Cells(0, colIndex).Value
        '                    dt.Columns.Add("Column " & i, GetType(String))
        '                Next

        '                For i As Integer = 0 To ws.Rows.Count - 1

        '                    Dim arrRow(colIndex - 1) As Object
        '                    For j As Integer = 0 To colIndex - 1
        '                        arrRow(j) = ws.Rows(i).Cells(j).Value
        '                    Next
        '                    dt.Rows.Add(arrRow)
        '                Next
        '            End If
        '            m_dsImport.Tables.Add(dt)
        '        End If
        '    Next

        '    Return m_dsImport

        'Catch ex As Exception

        '    Message_Error(ex)
        '    Return Nothing

        'End Try
        Return Nothing

    End Function

#End Region

#Region "Key Press Define"
    'Public Shared 
    Public ExitKey As Keys = Keys.Escape
    Public AddNewKey As Keys = Keys.F3
    Public EditKey As Keys = Keys.F4
    Public DeleteKey As Keys = Keys.F8
    Public SaveKey As Keys = Keys.F2
#End Region

#Region "Set control chung tu"
    ''' <summary>
    ''' Xoa ban ghi duoc lua chon tren Phieu (Luoi ben Trai)
    ''' </summary>
    ''' <param name="_tempList">Danh sach ban ghi</param>
    ''' <param name="_ID">ID So sanh</param>
    ''' <returns>True: Duoc phep lay lai du lieu theo ID dc tra ve</returns>
    ''' <remarks></remarks>
    'Public Function RemoveLeftGrid(ByRef _tempList As List(Of CT_H_GInfo), ByVal _ID As String) As String
    '    For i = _tempList.Count - 1 To 0 Step -1
    '        If _tempList.Count = 1 Then
    '            _tempList.RemoveAt(0)
    '            Return ""
    '        End If
    '        If _tempList(i).CTH_NX_ID = _ID Then
    '            '
    '            _tempList.RemoveAt(i)
    '            '
    '            If (i = 0) Then
    '                i = 1
    '            End If
    '            _ID = _tempList(i - 1).CTH_NX_ID
    '            'SetObjectToControl()
    '            Return _ID
    '        End If
    '    Next

    '    Return ""
    'End Function
#End Region
End Module

Public Class WaitCursor
    Implements System.IDisposable
    Public Sub New()
        Cursor.Current = Cursors.WaitCursor
    End Sub
    Public Sub Dispose() Implements System.IDisposable.Dispose
        Cursor.Current = Cursors.[Default]
    End Sub
End Class

Public Class ConverterArrayToDatatable
    Private Sub New()
    End Sub

    Public Shared Function ConvertToDataTable(ByVal o As [Object]) As DataTable
        Dim properties As PropertyInfo() = o.[GetType]().GetProperties()
        Dim dt As DataTable = CreateDataTable(properties)
        FillData(properties, dt, o)
        Return dt
    End Function
    Public Shared Function ConvertToDataTable(ByVal array As [Object]()) As DataTable
        Dim properties As PropertyInfo() = array.[GetType]().GetElementType().GetProperties()
        Dim dt As DataTable = CreateDataTable(properties)

        If array.Length <> 0 Then
            For Each o As Object In array
                FillData(properties, dt, o)

            Next
        End If

        Return dt
    End Function

    Private Shared Function CreateDataTable(ByVal properties As PropertyInfo()) As DataTable
        Dim dt As New DataTable()
        Dim dc As DataColumn = Nothing

        For Each pi As PropertyInfo In properties
            dc = New DataColumn()
            dc.ColumnName = pi.Name
            dc.DataType = pi.PropertyType

            dt.Columns.Add(dc)
        Next

        Return dt
    End Function


    Private Shared Sub FillData(ByVal properties As PropertyInfo(), ByVal dt As DataTable, ByVal o As [Object])
        Dim dr As DataRow = dt.NewRow()

        For Each pi As PropertyInfo In properties
            dr(pi.Name) = pi.GetValue(o, Nothing)
        Next

        dt.Rows.Add(dr)
    End Sub


End Class

