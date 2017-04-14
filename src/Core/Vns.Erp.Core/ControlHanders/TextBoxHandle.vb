Imports System.Windows.Forms

Public Class TextBoxHandle

    Private WithEvents objTextBox As TextBox
    Private m_sDataType As String
    Private m_objMaxValue As Object
    Private m_objMinValue As Object
    Private m_bClearError, m_bMouseOver As Boolean

    Private Const CS_FLOAT_TYPE As String = "NUMBER,DOUBLE,FLOAT,DECIMAL,MONEY"
    Private Const CS_INT_TYPE As String = "LONG,BIGINT,INT,INTEGER,SHORT,SMALLINT,"
    Private Const CS_DATE_TYPE As String = "DATE,DATETIME,DATESHORT,TIME,"
    Private Const CS_STRING_TYPE As String = "NVARCHAR2,VARCHAR2,VARCHAR,NVARCHAR,CHAR,NCLOB,TEXT,NTEXT"

    Private m_sAll_Data_Type As String = CS_FLOAT_TYPE + CS_INT_TYPE + CS_DATE_TYPE + CS_STRING_TYPE
    Private m_sNumber_Data_Type As String = CS_FLOAT_TYPE + CS_INT_TYPE

    Protected Sub New()

    End Sub

    'Public Sub New(ByVal tb As TextBox)
    '    Me.objTextBox = tb
    'End Sub

    Public Property MaxValue() As Object
        Get
            Return m_objMaxValue
        End Get
        Set(ByVal Value As Object)
            m_objMaxValue = Value
        End Set
    End Property

    Public Property MinValue() As Object
        Get
            Return m_objMinValue
        End Get
        Set(ByVal Value As Object)
            m_objMinValue = Value
        End Set
    End Property

    Public Property DataType() As String
        Get
            Return m_sDataType
        End Get
        Set(ByVal Value As String)
            If m_sAll_Data_Type.IndexOf(Value.ToUpper + ",") = -1 Then
                Throw New Exception("Invalid data type")
            End If
            m_sDataType = Value.ToUpper
        End Set
    End Property

    Public Property AutoClearError() As Boolean
        Get
            Return m_bClearError
        End Get
        Set(ByVal Value As Boolean)
            m_bClearError = Value
        End Set
    End Property

    Public ReadOnly Property ControlName() As String
        Get
            Return objTextBox.Name
        End Get
    End Property

    Public Sub New(ByVal tb As TextBox, ByVal DataType As String, Optional ByVal MinValue As Object = Nothing, Optional ByVal MaxValue As Object = Nothing)
        Me.objTextBox = tb
        m_sDataType = DataType.ToUpper
        m_objMaxValue = MaxValue
        m_objMinValue = MinValue

        Select Case m_sDataType '.ToUpper
            Case "NUMBER", "FLOAT", "DOUBLE", "DECIMAL", "MONEY"
                tb.MaxLength = Double.MaxValue.ToString.Length
                tb.TextAlign = HorizontalAlignment.Right

                If m_objMaxValue Is Nothing Then m_objMaxValue = Double.MaxValue
                If m_objMinValue Is Nothing Then m_objMinValue = Double.MinValue
            Case "INT", "INTEGER"
                tb.MaxLength = Integer.MaxValue.ToString.Length
                tb.TextAlign = HorizontalAlignment.Right

                If m_objMaxValue Is Nothing Then m_objMaxValue = Integer.MaxValue
                If m_objMinValue Is Nothing Then m_objMinValue = Integer.MinValue
            Case "INT64", "LONG", "BIGINT"
                tb.MaxLength = Long.MaxValue.ToString.Length
                tb.TextAlign = HorizontalAlignment.Right

                If m_objMaxValue Is Nothing Then m_objMaxValue = Long.MaxValue
                If m_objMinValue Is Nothing Then m_objMinValue = Long.MinValue
            Case "INT16", "SHORT", "SMALLINT"
                tb.MaxLength = Short.MaxValue.ToString.Length
                tb.TextAlign = HorizontalAlignment.Right

                If m_objMaxValue Is Nothing Then m_objMaxValue = Short.MaxValue
                If m_objMinValue Is Nothing Then m_objMinValue = Short.MinValue
            Case "DATE", "DATETIME"
                tb.MaxLength = 10
                tb.CharacterCasing = CharacterCasing.Upper
            Case "DATESHORT"
                tb.MaxLength = 10
                tb.CharacterCasing = CharacterCasing.Upper
            Case "TIME"
                tb.MaxLength = 5
            Case "TEXT", "NTEXT"
                tb.MaxLength = 2000
            Case Else
                If m_sAll_Data_Type.IndexOf(DataType + ",") = -1 Then
                    Throw New Exception("Invalid data type: " + DataType)
                End If
        End Select
    End Sub

    Private Sub objTextBox_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles objTextBox.Enter
        Try
            If objTextBox.ReadOnly Then Return
            Select Case m_sDataType.ToUpper
                Case "DATE", "DATETIME"
                    If IsDate(objTextBox.Text) Then
                        objTextBox.Text = CType(objTextBox.Text, Date).ToString(CS_EDIT_DATE_FORMAT)
                    End If
                Case "DATESHORT"
            End Select
            objTextBox.SelectAll()
            '
            If Not m_bMouseOver Then SetToolTip(True)
            '
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub TextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles objTextBox.KeyPress
        Try
            If e.Handled Then Return

            Dim bHandled As Boolean = False
            Select Case Asc(e.KeyChar)
                Case 13 'Enter
                    If Not objTextBox.Multiline Then
                        e.Handled = True
                        SendKeys.SendWait("{TAB}")
                        Return
                    End If
                Case 8 'Backspace
                Case Else
                    Dim sValidChar As String = "0123456789"

                    If CS_FLOAT_TYPE.Contains(m_sDataType.ToUpper) Then
                        sValidChar += CS_DIGIT_GROUP_SYMBOL + CS_DECIMAL_SYMBOL
                    ElseIf CS_INT_TYPE.Contains(m_sDataType.ToUpper) Then
                        sValidChar += CS_DIGIT_GROUP_SYMBOL
                    ElseIf m_sDataType.ToUpper.Contains("DATE") Then
                        'sValidChar += "/- "
                        sValidChar = ""
                    ElseIf m_sDataType.ToUpper = "TIME" Then
                        sValidChar += ":"
                    Else
                        sValidChar = ""
                    End If
                    If sValidChar <> "" Then bHandled = (sValidChar.IndexOf(e.KeyChar) < 0)
                    '
                    If bHandled Then
                        ShowTip("Invalid character input: " + e.KeyChar)
                    End If
                    '
            End Select

            e.Handled = bHandled

        Catch ex As Exception
            'Throw ex
            Message_Error(ex)
        End Try
    End Sub

    Private Sub ShowTip(ByVal sTip As String)
        Dim objToolTip As ToolTip = Form_GetToolTip(objTextBox.FindForm)
        objToolTip.ToolTipTitle = ""
        objToolTip.Show(sTip, objTextBox, 1000)
    End Sub

    Private Sub objTextBox_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles objTextBox.MouseEnter
        m_bMouseOver = True
        SetToolTip(False)
    End Sub

    Private Sub SetToolTip(ByVal bShow As Boolean)
        If objTextBox.ReadOnly = True OrElse objTextBox.Enabled = False Then Return
        Dim objToolTip As ToolTip = Form_GetToolTip(objTextBox.FindForm)
        '
        objToolTip.Active = False
        objToolTip.Hide(objTextBox)
        '
        Dim sText As String = String.Format("Input Length: {0}/{1}" + vbCr _
                                             , objTextBox.Text.Length, objTextBox.MaxLength)
        If Control_GetRequire(objTextBox) Then
            sText += "Require: Yes"
            objToolTip.ToolTipIcon = ToolTipIcon.Warning
        Else
            sText += "Require: No"
            objToolTip.ToolTipIcon = ToolTipIcon.Info
        End If
        '
        If CS_FLOAT_TYPE.Contains(m_sDataType) Then
            objToolTip.ToolTipTitle = "Data type: Number"
        ElseIf CS_INT_TYPE.Contains(m_sDataType) Then
            objToolTip.ToolTipTitle = "Data type: Integer"
        ElseIf CS_DATE_TYPE.Contains(m_sDataType) Then
            objToolTip.ToolTipTitle = "Data type: Date"
        Else
            objToolTip.ToolTipTitle = "Data type: String"
        End If
        '
        objToolTip.SetToolTip(objTextBox, sText)
        objToolTip.Active = True
        '
        If bShow Then
            objToolTip.Show(sText, objTextBox, objToolTip.AutoPopDelay)
        Else

        End If
        '
        'Return objToolTip
    End Sub

    Private Sub objTextBox_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles objTextBox.MouseLeave
        m_bMouseOver = False
    End Sub

    Private Sub objTextBox_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles objTextBox.TextChanged
        Control_SetError(objTextBox, "")
    End Sub

    Private Sub TextBox_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles objTextBox.Validating
        Try
            If objTextBox.ReadOnly Then Exit Sub

            Dim sValue As String = objTextBox.Text.Trim

            Dim bWrong As Boolean = Nothing
            Dim sMessage As String = Nothing

            If sValue.Length > 0 Then
                If CS_STRING_TYPE.IndexOf(m_sDataType.ToUpper + ",") > -1 Then
                    If Control_GetError(objTextBox) <> "" Then
                        Return
                    Else
                        objTextBox.Text = sValue
                    End If
                End If
                'Check data type
                If CS_FLOAT_TYPE.Contains(m_sDataType) Then
                    bWrong = Not IsNumeric(sValue)
                    sMessage = "Please input numeric value"
                ElseIf CS_INT_TYPE.Contains(m_sDataType) Then
                    bWrong = Not IsNumeric(sValue)
                    If Not bWrong Then
                        Dim iValue As Long
                        Object_SetValue(sValue, iValue)
                        objTextBox.Text = iValue 'Long.Parse(sValue)
                    End If
                    sMessage = "Please input Integer value"
                ElseIf "DATE;DATETIME".Contains(m_sDataType) Then
                    Date_FixString(sValue)
                    Dim mDate As Date
                    If Not Date_TryParseEx(sValue, mDate) Then
                        bWrong = True
                    Else
                        'Object_SetValue(sValue, mDate)
                        objTextBox.Text = mDate.ToString(CS_DISPLAY_DATE_FORMAT) 'CType(sValue, Date).ToString(cstDisplayDateFormat)
                    End If
                    sMessage = "Please input Date value"
                ElseIf m_sDataType = "TIME" Then
                    If Not IsDate(sValue) Then
                        If sValue Like "####" Then
                            sValue = sValue.Substring(0, 2) & ":" & sValue.Substring(2, 2)
                        ElseIf sValue Like "###" Then
                            sValue = sValue.Substring(0, 1) & ":" & sValue.Substring(1, 2)
                        ElseIf sValue Like "##" Then
                            sValue = sValue & ":00"
                        End If
                    End If
                    If Not IsDate(sValue) Then
                        bWrong = True
                    Else
                        objTextBox.Text = DateTime.Parse(sValue).ToString("HH:mm")
                    End If
                    sMessage = "Please input Time value"
                Else
                    Return
                End If
                'Check range
                If Not (m_objMinValue Is Nothing And m_objMaxValue Is Nothing) Then
                    Dim sCheckRange = CheckRange(sValue, m_sDataType) ', m_objMinValue, m_objMaxValue)
                    If Not bWrong Then
                        bWrong = sCheckRange <> ""
                    End If
                    sMessage += sCheckRange
                End If

                If m_bClearError And bWrong Then
                    'Auto clear error
                    objTextBox.Text = ""
                    Return
                End If
            End If

            If bWrong Then
                e.Cancel = True
            Else
                sMessage = ""
                If TypeOf m_objMinValue Is TextBox Then Control_SetError(m_objMinValue, "")
                If TypeOf m_objMaxValue Is TextBox Then Control_SetError(m_objMaxValue, "")
                '
                If m_sNumber_Data_Type.Contains(m_sDataType) Then ' Auto format for numeric value
                    Dim mValue As Decimal
                    Object_SetValue(objTextBox.Text, mValue)
                    objTextBox.Text = Object_GetDisplayValue(mValue)
                End If
            End If

            Control_SetError(objTextBox, sMessage)

        Catch ex As Exception
            'Throw
            Message_Error(ex)
        End Try
    End Sub

    'Hàm kiểm tra khoảng nhập dữ liệu (private)
    Private Function CheckRange(ByVal sValue As String, ByVal sDataType As String) ', Optional ByVal objMinValue As Object = Nothing, Optional ByVal objMaxValue As Object = Nothing) As String
        Dim bReturn As Boolean = True
        Dim sMinValue As String = Nothing
        Dim sMaxValue As String = Nothing

        Select Case sDataType.ToUpper
            Case "NUMBER", "FLOAT", "DOUBLE", "LONG", "BIGINT", "INT", "INTEGER", "SHORT", "SMALLINT", "INT64", "INT32", "INT16"
                Dim MaxValue As Object = Nothing
                Dim MinValue As Object = Nothing
                Dim mValue As Object = Nothing

                Select Case sDataType.ToUpper
                    Case "NUMBER", "FLOAT", "DOUBLE"
                        MaxValue = CType(MaxValue, Double)
                        MinValue = CType(MinValue, Double)
                        mValue = CType(mValue, Double)
                    Case "LONG", "BIGINT", "INT64"
                        MaxValue = CType(MaxValue, Long)
                        MinValue = CType(MinValue, Long)
                        mValue = CType(mValue, Long)
                    Case "INT", "INTEGER", "INT32"
                        MaxValue = CType(MaxValue, Integer)
                        MinValue = CType(MinValue, Integer)
                        mValue = CType(mValue, Integer)
                    Case "SHORT", "SMALLINT", "INT16"
                        MaxValue = CType(MaxValue, Short)
                        MinValue = CType(MinValue, Short)
                        mValue = CType(mValue, Short)
                End Select

                Object_SetValue(m_objMaxValue, MaxValue)
                Object_SetValue(m_objMinValue, MinValue)


                If Not Null.IsNull(MaxValue) Then
                    sMaxValue = MaxValue.ToString
                End If
                If Not Null.IsNull(MinValue) Then
                    sMinValue = MinValue.ToString
                End If

                If IsNumeric(sValue) Then
                    Object_SetValue(sValue, mValue)
                    If Not Null.IsNull(MaxValue) Then
                        bReturn = bReturn And mValue <= MaxValue
                    End If
                    If Not Null.IsNull(MinValue) Then
                        bReturn = bReturn And mValue >= MinValue
                    End If
                Else
                    bReturn = False
                End If
            Case "DATE", "DATETIME"
                Dim MaxValue As Date
                Object_SetValue(m_objMaxValue, MaxValue)

                If MaxValue = Null.NullDate Then
                    GetValue(True, MaxValue)
                End If

                Dim MinValue As Date
                Object_SetValue(m_objMinValue, MinValue)

                If MinValue = Null.NullDate Then
                    GetValue(False, MinValue)
                End If

                If MinValue = Null.NullDate Then MinValue = Null.MIN_DATE
                If MaxValue = Null.NullDate Then MaxValue = Null.MAX_DATE

                If MaxValue > Null.NullDate Then
                    sMaxValue = MaxValue.ToString(CS_DISPLAY_DATE_FORMAT)
                End If
                If MinValue > Null.NullDate Then
                    sMinValue = MinValue.ToString(CS_DISPLAY_DATE_FORMAT)
                End If


                If IsDate(sValue) Then
                    If MaxValue > Null.NullDate Then
                        bReturn = bReturn And Date.Parse(sValue) <= MaxValue
                    End If
                    If MinValue > Null.NullDate Then
                        bReturn = bReturn And Date.Parse(sValue) >= MinValue
                    End If
                Else
                    bReturn = False
                End If
            Case "TIME"
                Dim MaxValue As DateTime
                Object_SetValue(m_objMaxValue, MaxValue)
                Dim MinValue As DateTime
                Object_SetValue(m_objMinValue, MinValue)
                If MinValue = Null.NullDate Then MinValue = DateTime.Parse("00:00")

                If MaxValue > Null.NullDate Then
                    sMaxValue = MaxValue.ToString("HH:mm")
                End If
                If MinValue > Null.NullDate Then
                    sMinValue = MinValue.ToString("HH:mm")
                End If

                If IsDate(sValue) Then
                    If MaxValue > Null.NullDate Then
                        bReturn = bReturn And DateTime.Parse(sValue) <= MaxValue
                    End If
                    If MinValue > Null.NullDate Then
                        bReturn = bReturn And DateTime.Parse(sValue) >= MinValue
                    End If
                Else
                    bReturn = False
                End If
            Case Else
        End Select
        Dim sMessage As String = ""
        If Not bReturn Then
            If sMinValue <> "" And sMaxValue <> "" Then
                sMessage = " from " & sMinValue & " to " & sMaxValue
            ElseIf sMinValue <> "" Then
                sMessage = " greate than or equal " & sMinValue
            ElseIf sMaxValue <> "" Then
                sMessage = " less than or equal " & sMaxValue
            End If
        End If
        Return sMessage
    End Function

    Private Sub GetValue(ByVal isMaxValue As Boolean, ByRef mValue As Object)
        Dim objValue As Object
        If isMaxValue Then
            objValue = m_objMaxValue
        Else
            objValue = m_objMinValue
        End If
        If TypeOf objValue Is TextBox Then
            Dim tmpObject As TextBox = objValue
            While TypeOf tmpObject Is TextBox
                If TypeOf tmpObject.Tag Is FormControlExt Then
                    Dim mHandle As TextBoxHandle = CType(tmpObject.Tag, FormControlExt).HandleObject
                    If isMaxValue Then
                        tmpObject = mHandle.MaxValue
                    Else
                        tmpObject = mHandle.MinValue
                    End If
                    Object_SetValue(tmpObject, mValue)
                    If Not Null.IsNull(mValue) Then Exit While
                Else
                    Exit While
                End If
            End While
        End If
    End Sub
End Class