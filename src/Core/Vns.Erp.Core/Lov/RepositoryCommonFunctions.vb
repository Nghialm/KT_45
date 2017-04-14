Public Class RepositoryCommonFunctions

    Public Shared MESSAGE_CHECK_NUMBER As String = "Giá trị kiểu số không hợp lệ"
    Public Shared MESSAGE_CHECK_STRING As String = "Giá trị kiểu chuỗi không hợp lệ"
    Public Shared MESSAGE_CHECK_OTHER As String = ""
    Public Shared MESSAGE_CHECK As String = "Giá trị không hợp lệ"

    Public Shared Function CheckChiTiet(ByVal row As DataRow, ByVal IS_CHECK_NUMBER As String, ByVal IS_CHECK_STRING As String, ByVal IS_CHECK_OTHER As String, ByVal _MessageWarning As String) As Boolean
        Dim bReturn As Boolean = False
        Dim strNumber As String = IS_CHECK_NUMBER
        Dim strString As String = IS_CHECK_STRING
        Dim strOther As String = IS_CHECK_OTHER
        Dim number_valid As Integer = -1
        Dim string_valid As Integer = -1
        Dim other_valid As Integer = -1

        'Number
        If strNumber.Trim().Equals("=") Or strNumber.Trim().Equals(">") Or strNumber.Trim().Equals("<") Or strNumber.Trim().Equals(">=") Or strNumber.Trim().Equals("<=") Or strNumber.Trim().Equals("") Then
            number_valid = 0
        Else
            Dim bCheck As Boolean = CheckingNumber(row, strNumber)
            If bCheck = True Then
                number_valid = 1
            Else
                number_valid = 2
            End If
        End If

        'String
        If strString.Trim().Equals("=") Or strString.Trim().ToLower().Equals("like") Or strString.Trim().Equals("") Then
            string_valid = 0
        Else
            Dim bCheck As Boolean = CheckingString(row, strString)
            If bCheck = True Then
                string_valid = 1
            Else
                string_valid = 2
            End If
        End If

        'Other

        'Overview
        If number_valid = 0 AndAlso string_valid = 0 Then
            bReturn = True 'not check number and string
        ElseIf number_valid = 0 AndAlso string_valid = 1 Then
            bReturn = True 'not check number and string valid
        ElseIf number_valid = 0 AndAlso string_valid = 2 Then
            bReturn = False 'not check number and string invalid
            'Message_Information(MESSAGE_CHECK_STRING)
            Message_Information(_MessageWarning)
        ElseIf number_valid = 1 AndAlso string_valid = 0 Then
            bReturn = True 'not check string and number valid
        ElseIf number_valid = 1 AndAlso string_valid = 1 Then
            bReturn = True 'number valid and string valid
        ElseIf number_valid = 1 AndAlso string_valid = 2 Then
            bReturn = False 'number valid and string invalid
            Message_Information(_MessageWarning)
            'Message_Information(MESSAGE_CHECK_STRING)
        ElseIf number_valid = 2 AndAlso string_valid = 0 Then
            bReturn = False 'number invalid and not check string
            Message_Information(_MessageWarning)
            'Message_Information(MESSAGE_CHECK_NUMBER)
        ElseIf number_valid = 2 AndAlso string_valid = 1 Then
            bReturn = False 'number invalid and string valid
            Message_Information(_MessageWarning)
            'Message_Information(MESSAGE_CHECK_NUMBER)
        ElseIf number_valid = 2 AndAlso string_valid = 2 Then
            bReturn = False 'number invalid and string invalid
            Message_Information(_MessageWarning)
            'Message_Information(MESSAGE_CHECK_NUMBER + Microsoft.VisualBasic.Constants.vbCrLf + MESSAGE_CHECK_STRING)
        End If

        Return bReturn
    End Function

    Public Shared Function CheckChiTietForAllForm(ByVal key_name As String, ByVal key_value As String, ByVal data_source As DataTable, ByVal IS_CHECK_NUMBER As String, ByVal IS_CHECK_STRING As String, ByVal IS_CHECK_OTHER As String) As Boolean
        Dim bReturn As Boolean = False
        Dim strNumber As String = IS_CHECK_NUMBER
        Dim strString As String = IS_CHECK_STRING
        Dim strOther As String = IS_CHECK_OTHER
        Dim number_valid As Integer = -1
        Dim string_valid As Integer = -1
        Dim other_valid As Integer = -1

        Try
            'Get DataRow
            Dim row As DataRow = GetDataRowByKeyName(key_name, key_value, data_source)

            'Number
            If strNumber.Trim().Equals("=") Or strNumber.Trim().Equals(">") Or strNumber.Trim().Equals("<") Or strNumber.Trim().Equals(">=") Or strNumber.Trim().Equals("<=") Or strNumber.Trim().Equals("") Then
                number_valid = 0
            Else
                Dim bCheck As Boolean = CheckingNumber(row, strNumber)
                If bCheck = True Then
                    number_valid = 1
                Else
                    number_valid = 2
                End If
            End If

            'String
            If strString.Trim().Equals("=") Or strString.Trim().ToLower().Equals("like") Or strString.Trim().Equals("") Then
                string_valid = 0
            Else
                Dim bCheck As Boolean = CheckingString(row, strString)
                If bCheck = True Then
                    string_valid = 1
                Else
                    string_valid = 2
                End If
            End If

            'Other

            'Overview
            If number_valid = 0 AndAlso string_valid = 0 Then
                bReturn = True 'not check number and string
            ElseIf number_valid = 0 AndAlso string_valid = 1 Then
                bReturn = True 'not check number and string valid
            ElseIf number_valid = 0 AndAlso string_valid = 2 Then
                bReturn = False 'not check number and string invalid
                Message_Information(MESSAGE_CHECK_STRING)
            ElseIf number_valid = 1 AndAlso string_valid = 0 Then
                bReturn = True 'not check string and number valid
            ElseIf number_valid = 1 AndAlso string_valid = 1 Then
                bReturn = True 'number valid and string valid
            ElseIf number_valid = 1 AndAlso string_valid = 2 Then
                bReturn = False 'number valid and string invalid
                Message_Information(MESSAGE_CHECK_STRING)
            ElseIf number_valid = 2 AndAlso string_valid = 0 Then
                bReturn = False 'number invalid and not check string
                Message_Information(MESSAGE_CHECK_NUMBER)
            ElseIf number_valid = 2 AndAlso string_valid = 1 Then
                bReturn = False 'number invalid and string valid
                Message_Information(MESSAGE_CHECK_NUMBER)
            ElseIf number_valid = 2 AndAlso string_valid = 2 Then
                bReturn = False 'number invalid and string invalid
                Message_Information(MESSAGE_CHECK_NUMBER + Microsoft.VisualBasic.Constants.vbCrLf + MESSAGE_CHECK_STRING)
            End If
        Catch
        End Try

        Return bReturn
    End Function

    Public Shared Function CheckChiTietForPopup(ByVal key_name As String, ByVal key_value As String, ByVal data_source As DataTable, ByVal IS_CHECK_NUMBER As String, ByVal IS_CHECK_STRING As String, ByVal IS_CHECK_OTHER As String) As Boolean
        Dim bReturn As Boolean = False
        Dim strNumber As String = IS_CHECK_NUMBER
        Dim strString As String = IS_CHECK_STRING
        Dim strOther As String = IS_CHECK_OTHER
        Dim number_valid As Integer = -1
        Dim string_valid As Integer = -1
        Dim other_valid As Integer = -1

        Try
            'Get DataRow
            Dim row As DataRow = GetDataRowByKeyName(key_name, key_value, data_source)

            'Number
            If strNumber.Trim().Equals("=") Or strNumber.Trim().Equals(">") Or strNumber.Trim().Equals("<") Or strNumber.Trim().Equals(">=") Or strNumber.Trim().Equals("<=") Or strNumber.Trim().Equals("") Then
                number_valid = 0
            Else
                Dim bCheck As Boolean = CheckingNumber(row, strNumber)
                If bCheck = True Then
                    number_valid = 1
                Else
                    number_valid = 2
                End If
            End If

            'String
            If strString.Trim().Equals("=") Or strString.Trim().ToLower().Equals("like") Or strString.Trim().Equals("") Then
                string_valid = 0
            Else
                Dim bCheck As Boolean = CheckingString(row, strString)
                If bCheck = True Then
                    string_valid = 1
                Else
                    string_valid = 2
                End If
            End If

            'Other

            'Overview
            If number_valid = 0 AndAlso string_valid = 0 Then
                bReturn = True 'not check number and string
            ElseIf number_valid = 0 AndAlso string_valid = 1 Then
                bReturn = True 'not check number and string valid
            ElseIf number_valid = 0 AndAlso string_valid = 2 Then
                bReturn = False 'not check number and string invalid
                'Message_Information(MESSAGE_CHECK_STRING)
            ElseIf number_valid = 1 AndAlso string_valid = 0 Then
                bReturn = True 'not check string and number valid
            ElseIf number_valid = 1 AndAlso string_valid = 1 Then
                bReturn = True 'number valid and string valid
            ElseIf number_valid = 1 AndAlso string_valid = 2 Then
                bReturn = False 'number valid and string invalid
                'Message_Information(MESSAGE_CHECK_STRING)
            ElseIf number_valid = 2 AndAlso string_valid = 0 Then
                bReturn = False 'number invalid and not check string
                'Message_Information(MESSAGE_CHECK_NUMBER)
            ElseIf number_valid = 2 AndAlso string_valid = 1 Then
                bReturn = False 'number invalid and string valid
                'Message_Information(MESSAGE_CHECK_NUMBER)
            ElseIf number_valid = 2 AndAlso string_valid = 2 Then
                bReturn = False 'number invalid and string invalid
                'Message_Information(MESSAGE_CHECK_NUMBER + Microsoft.VisualBasic.Constants.vbCrLf + MESSAGE_CHECK_STRING)
            End If
        Catch
        End Try

        Return bReturn
    End Function

    Public Shared Function CheckingNumber(ByVal row As DataRow, ByVal strNumber As String) As Boolean
        Dim bReturn As Boolean = False
        If strNumber.Trim().Equals("=") Or strNumber.Trim().Equals(">") Or strNumber.Trim().Equals("<") Or strNumber.Trim().Equals(">=") Or strNumber.Trim().Equals("<=") Or strNumber.Trim().Equals("") Then
            bReturn = False
        Else
            Dim operatorStr As String = "="
            If IsExistCharInString(strNumber, "=") AndAlso (Not IsExistCharInString(strNumber, ">")) AndAlso (Not IsExistCharInString(strNumber, "<")) Then
                operatorStr = "="
            ElseIf IsExistCharInString(strNumber, ">") AndAlso (Not IsExistCharInString(strNumber, "=")) Then
                operatorStr = ">"
            ElseIf IsExistCharInString(strNumber, "<") AndAlso (Not IsExistCharInString(strNumber, "=")) Then
                operatorStr = "<"
            ElseIf IsExistCharInString(strNumber, ">=") Then
                operatorStr = ">="
            ElseIf IsExistCharInString(strNumber, "<=") Then
                operatorStr = "<="
            End If

            Dim value_of_row As String = ""
            Dim key_name As String = ""
            Dim key_value As String = ""
            Select Case operatorStr
                Case "="
                    Dim arr() As String = strNumber.Split("=")
                    key_name = arr(0).Trim
                    If Not key_name.Equals("") Then
                        key_value = arr(1).Trim
                        value_of_row = row(key_name).ToString
                        If value_of_row.Equals(key_value) Or (Decimal.Parse(value_of_row) = Decimal.Parse(key_value)) Then
                            bReturn = True
                        End If
                    End If
                Case ">"
                    Dim arr() As String = strNumber.Split(">")
                    key_name = arr(0).Trim
                    If Not key_name.Equals("") Then
                        key_value = arr(1).Trim
                        value_of_row = row(key_name).ToString
                        If Decimal.Parse(value_of_row) > Decimal.Parse(key_value) Then
                            bReturn = True
                        End If
                    End If
                Case "<"
                    Dim arr() As String = strNumber.Split("<")
                    key_name = arr(0).Trim
                    If Not key_name.Equals("") Then
                        key_value = arr(1).Trim
                        value_of_row = row(key_name).ToString
                        If Decimal.Parse(value_of_row) < Decimal.Parse(key_value) Then
                            bReturn = True
                        End If
                    End If
                Case ">="
                    Dim arr() As String = strNumber.Split(">=")
                    key_name = arr(0).Trim
                    If Not key_name.Equals("") Then
                        key_value = arr(1).Trim
                        key_value = key_value.Substring(1).Trim
                        value_of_row = row(key_name).ToString
                        If Decimal.Parse(value_of_row) >= Decimal.Parse(key_value) Then
                            bReturn = True
                        End If
                    End If
                Case "<="
                    Dim arr() As String = strNumber.Split("<=")
                    key_name = arr(0).Trim
                    If Not key_name.Equals("") Then
                        key_value = arr(1).Trim
                        key_value = key_value.Substring(0).Trim
                        value_of_row = row(key_name).ToString
                        If Decimal.Parse(value_of_row) <= Decimal.Parse(key_value) Then
                            bReturn = True
                        End If
                    End If
            End Select
        End If
        Return bReturn
    End Function

    Public Shared Function CheckingString(ByVal row As DataRow, ByVal strString As String) As Boolean
        Dim bReturn As Boolean = False
        If strString.Trim().Equals("=") Or strString.Trim().ToLower().Equals("like") Or strString.Trim().Equals("") Then
            bReturn = False
        Else
            Dim operatorStr As String = "="
            If IsExistCharInString(strString, "=") Then
                operatorStr = "="
            ElseIf IsExistCharInString(strString, "like") Then
                operatorStr = "like"
            End If

            Dim value_of_row As String = ""
            Dim key_name As String = ""
            Dim key_value As String = ""
            Select Case operatorStr
                Case "="
                    Dim arr() As String = strString.Split("=")
                    key_name = arr(0).Trim
                    If Not key_name.Equals("") Then
                        key_value = arr(1).Trim
                        value_of_row = row(key_name).ToString
                        If value_of_row.Equals(key_value) Then
                            bReturn = True
                        End If
                    End If
                Case "like"
                    Dim arr() As String = strString.Split("LIKE")
                    key_name = arr(0).Trim
                    If Not key_name.Equals("") Then
                        key_value = arr(1).Trim
                        key_value = key_value.Substring(3).Trim
                        value_of_row = row(key_name).ToString
                        bReturn = value_of_row.Contains(key_value)
                    End If
            End Select
        End If
        Return bReturn
    End Function

    Public Shared Function CheckingOther(ByVal row As DataRow, ByVal strOther As String) As Boolean
        Dim bReturn As Boolean = False
        If strOther.Trim().Equals("=") Or strOther.Trim().Equals("") Then
            bReturn = False
        Else
            Dim operatorStr As String = "="
            Dim arr() As String = strOther.Split("=")
            Dim key_name As String = arr(0).Trim
            Dim key_value As String = arr(1).Trim
            Dim value_of_row As String = row(key_name).ToString
            If Not key_name.Equals("") Then
                If value_of_row.Equals(key_value) Then
                    bReturn = True
                End If
            End If
        End If
        Return bReturn
    End Function

    Public Shared Function IsExistCharInString(ByVal str As String, ByVal ch As String) As Boolean
        str = str.ToLower()
        ch = ch.ToLower()
        Return str.Contains(ch)
    End Function

    Public Shared Function GetDataRowByKeyName(ByVal key_name As String, ByVal key_value As String, ByVal data_source As DataTable) As DataRow
        Dim rowReturn As DataRow = Nothing
        For Each dr As DataRow In data_source.Rows
            If dr(key_name).ToString.Equals(key_value) Then
                rowReturn = dr
                Exit For
            End If
        Next
        Return rowReturn
    End Function
End Class
