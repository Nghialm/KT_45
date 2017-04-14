Public Class NumberToString
    Public Function Num2Text(ByVal S As String, ByVal ext As String) As String
        Dim So() As String = Split("không một hai ba bốn năm sáu bảy tám chín", " ")
        Dim So1() As String = Split("linh một tư lăm mười mươi", " ")
        Dim Hang() As String = Split(" nghìn triệu tỷ", " ")
        Dim I, J, Donvi, Chuc, Tram As Integer
        Dim StrValue$, S1$
        Hang(0) = ""
        StrValue = ""
        S1 = ""
        For I = 1 To Len(S)
            If IsNumeric(Mid(S, I, 1)) Then
                S1 = S1 & Mid(S, I, 1)
            ElseIf Mid(S, I, 1) = "," Then
                Exit For
            End If
        Next
        S = S1
        If Len(S) = 0 Then
            Return String.Empty
        End If
        If S = "0" Then
            Num2Text = So(0)
            Exit Function
        End If
        While Left(S, 1) = "0"
            S = Right(S, Len(S) - 1)
        End While
        I = Len(S)
        J = 0
        Do While I > 0
            Donvi = Int(Mid(S, I, 1))
            I = I - 1
            If I > 0 Then
                Chuc = Int(Mid(S, I, 1))
            Else
                Chuc = -1
            End If
            I = I - 1
            If I > 0 Then
                Tram = Int(Mid(S, I, 1))
            Else
                Tram = -1
            End If
            I = I - 1
            If Donvi > 0 Or Chuc > 0 Or Tram > 0 Or J = 3 Then
                StrValue = Hang(J) & " " & StrValue
            End If
            J = J + 1
            If J > 3 Then
                J = 1
            End If
            If Donvi = 1 And Chuc > 1 Then
                StrValue = So1(1) & " " & StrValue
            ElseIf Donvi = 4 And Chuc > 1 Then
                StrValue = So1(2) & " " & StrValue
            Else
                If Donvi = 5 And Chuc > 0 Then
                    StrValue = So1(3) & " " & StrValue
                ElseIf Donvi > 0 Then
                    StrValue = So(Donvi) & " " & StrValue
                End If
            End If
            If Chuc < 0 Then
                Exit Do
            Else
                If Chuc = 0 And Donvi > 0 Then
                    StrValue = So1(0) & " " & StrValue
                ElseIf Chuc = 1 Then
                    StrValue = So1(4) & " " & StrValue
                ElseIf Chuc > 1 Then
                    StrValue = So(Chuc) & " " & So1(5) & " " & StrValue
                End If
            End If
            If Tram < 0 Then
                Exit Do
            Else
                If Tram > 0 Or Chuc > 0 Or Donvi > 0 Then
                    StrValue = So(Tram) & " trăm " & StrValue
                End If
            End If
        Loop
        For I = 1 To 3
            StrValue = Replace(StrValue, Hang(I), Hang(I) & "")
        Next
        StrValue = Replace(StrValue, ", " & Hang(3), " " & Hang(3))
        StrValue = Trim(StrValue)
        If Right(StrValue, 1) = "," Then StrValue = Left(StrValue, Len(StrValue) - 1)
        StrValue = UCase(Left(StrValue, 1)) & Right(StrValue, Len(StrValue) - 1)
        Num2Text = StrValue + " " + ext
    End Function
End Class
