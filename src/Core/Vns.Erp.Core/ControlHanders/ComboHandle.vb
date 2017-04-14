Imports System.Windows.Forms

Public Class ComboBoxHandle
    'Class dùng để handle ComboBox
    'Hỗ trợ auto complete
    Inherits NativeWindow

    Private WithEvents objComboBox As ComboBox

    Private Sub New()
    End Sub

    Public Sub New(ByVal tb As ComboBox)
        Me.objComboBox = tb
        objComboBox.DropDownStyle = ComboBoxStyle.DropDown
    End Sub

    Private Sub objComboBox_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles objComboBox.Enter
        Try
            If Not objComboBox.DroppedDown Then objComboBox.DroppedDown = True
        Catch exp As Exception
            Message_Error(exp)
        End Try
    End Sub

    Private Sub objComboBox_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles objComboBox.Click
        Try
            'If Not objComboBox.DroppedDown Then objComboBox.DroppedDown = True
        Catch exp As Exception
            Message_Error(exp)
        End Try
    End Sub

    Private Sub objComboBox_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles objComboBox.Validated
        Try
            If Not objComboBox.Enabled Then Exit Sub

            Dim iIndex As Long = objComboBox.FindString(objComboBox.Text)
            If iIndex >= 0 Then
                'objComboBox.SelectedIndex = -1
                objComboBox.SelectedIndex = iIndex
            Else
                If objComboBox.Items.Count > 0 Then
                    objComboBox.SelectedIndex = 0
                Else
                    objComboBox.Text = ""
                End If
            End If
            'If objComboBox.DroppedDown Then objComboBox.DroppedDown = False           
        Catch exp As Exception
            Message_Error(exp)
        End Try
    End Sub

    'Private Sub objComboBox_PreviewKeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles objComboBox.PreviewKeyDown
    '    If e.KeyCode = Keys.Enter Then SendKeys.SendWait("{TAB}")
    'End Sub

    Private Sub objComboBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles objComboBox.KeyPress
        If e.KeyChar = vbCr Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub objComboBox_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles objComboBox.SelectedIndexChanged
        Try
            If objComboBox.Parent.Controls.ContainsKey(objComboBox.Name + "_View") Then
                Dim ctlView As TextBox = objComboBox.Parent.Controls(objComboBox.Name + "_View")
                ctlView.Text = objComboBox.Text
            End If
        Catch exp As Exception
            Message_Error(exp)
        End Try
    End Sub

    Private Sub objComboBox_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles objComboBox.TextChanged

    End Sub

    Private Sub objComboBox_TextUpdate(ByVal sender As Object, ByVal e As System.EventArgs) Handles objComboBox.TextUpdate
        Try
            If objComboBox.ContainsFocus Then
                Dim dtView As DataView
                If TypeOf objComboBox.DataSource Is DataTable Then
                    dtView = DirectCast(objComboBox.DataSource, DataTable).DefaultView
                ElseIf TypeOf objComboBox.DataSource Is DataView Then
                    dtView = DirectCast(objComboBox.DataSource, DataView)
                Else
                    Return
                End If
                dtView.RowFilter = "Sort_Field LIKE '" + objComboBox.Text + "%'"
            End If
        Catch exp As Exception
            Message_Error(exp)
        End Try
    End Sub

    Private Sub objComboBox_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles objComboBox.Validating
        Dim dtView As DataView
        Try
            If TypeOf objComboBox.DataSource Is DataTable Then
                dtView = DirectCast(objComboBox.DataSource, DataTable).DefaultView
            ElseIf TypeOf objComboBox.DataSource Is DataView Then
                dtView = DirectCast(objComboBox.DataSource, DataView)
            Else
                Return
            End If
            Dim sOldText As String = objComboBox.Text
            dtView.RowFilter = ""
            objComboBox.Text = sOldText
        Catch exp As Exception
            Message_Error(exp)
        End Try
    End Sub
End Class
'-------------
'</ComboBox>
'-------------