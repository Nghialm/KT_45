
Imports DevExpress.XtraEditors
Imports System.Windows.Forms

Public Class LookUpEditHandle
    'Class dùng để handle LookUpEdit
    'Hỗ trợ auto complete
    Inherits NativeWindow

    Private WithEvents objLookUpEdit As LookUpEdit

    Private Sub New()
    End Sub

    Public Sub New(ByVal tb As LookUpEdit)
        'Me.objLookUpEdit = tb
        'objLookUpEdit.DropDownStyle = ComboBoxStyle.DropDown
    End Sub

    Private Sub objLookUpEdit_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles objLookUpEdit.Enter
        Try
            'If Not objLookUpEdit.DroppedDown Then objComboBox.DroppedDown = True
        Catch exp As Exception
            Message_Error(exp)
        End Try
    End Sub

    Private Sub objLookUpEdit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles objLookUpEdit.Click
        Try
            'If Not objComboBox.DroppedDown Then objComboBox.DroppedDown = True
        Catch exp As Exception
            Message_Error(exp)
        End Try
    End Sub
    Dim iIndex As Long
    Private Sub objLookUpEdit_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles objLookUpEdit.Validated
        Try
            Return

            If Not objLookUpEdit.Enabled Then Exit Sub

            'Dim iIndex As Long = objLookUpEdit.FindString(objLookUpEdit.Text)

            If iIndex >= 0 Then
                'objComboBox.SelectedIndex = -1
                'objLookUpEdit.Properties.SelectedIndex = iIndex
            Else
                'If objLookUpEdit.Items.Count > 0 Then
                'objLookUpEdit.SelectedIndex = 0
                'objLookUpEdit.Text = ""
                'Else
                objLookUpEdit.Text = ""
            End If
            ' End If
            'If objComboBox.DroppedDown Then objComboBox.DroppedDown = False           
        Catch exp As Exception
            Message_Error(exp)
        End Try
    End Sub

    'Private Sub objComboBox_PreviewKeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles objComboBox.PreviewKeyDown
    '    If e.KeyCode = Keys.Enter Then SendKeys.SendWait("{TAB}")
    'End Sub

    'Private Sub objLookUpEdit_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles objLookUpEdit.KeyPress
    '    Return
    '    If e.KeyChar = vbCr Then
    '        e.Handled = True
    '        SendKeys.Send("{TAB}")
    '    End If
    'End Sub

    'Private Sub objLookUpEdit_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles objLookUpEdit.SelectedIndexChanged
    '    Try
    '        If objLookUpEdit.Parent.Controls.ContainsKey(objLookUpEdit.Name + "_View") Then
    '            Dim ctlView As TextBox = objLookUpEdit.Parent.Controls(objLookUpEdit.Name + "_View")
    '            ctlView.Text = objLookUpEdit.Text
    '        End If
    '    Catch exp As Exception
    '        Message_Error(exp)
    '    End Try
    'End Sub
    Dim mystring As String
    Private Sub objLookUpEdit_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles objLookUpEdit.EditValueChanged
        Return
        mystring = objLookUpEdit.EditValue.ToString()
        objLookUpEdit.EditValue = mystring

    End Sub

    Private Sub objLookUpEdit_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles objLookUpEdit.TextChanged

    End Sub

    'Private Sub objComboBox_TextUpdate(ByVal sender As Object, ByVal e As System.EventArgs) Handles objLookUpEdit.tTextUpdate
    '    Try
    '        If objLookUpEdit.ContainsFocus Then
    '            Dim dtView As DataView
    '            If TypeOf objLookUpEdit.Properties.DataSource Is DataTable Then
    '                dtView = DirectCast(objLookUpEdit.Properties.DataSource, DataTable).DefaultView
    '            ElseIf TypeOf objLookUpEdit.Properties.DataSource Is DataView Then
    '                dtView = DirectCast(objLookUpEdit.Properties.DataSource, DataView)
    '            Else
    '                Return
    '            End If
    '            dtView.RowFilter = "Sort_Field LIKE '" + objLookUpEdit.Text + "%'"
    '        End If
    '    Catch exp As Exception
    '        Message_Error(exp)
    '    End Try
    'End Sub
    Dim dtView As DataView
    Dim sOldText As String
    Private Sub objLookUpEdit_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles objLookUpEdit.Validating

        Try
            Return
            If TypeOf objLookUpEdit.Properties.DataSource Is DataTable Then
                dtView = DirectCast(objLookUpEdit.Properties.DataSource, DataTable).DefaultView
            ElseIf TypeOf objLookUpEdit.Properties.DataSource Is DataView Then
                dtView = DirectCast(objLookUpEdit.Properties.DataSource, DataView)
            Else
                Return
            End If
            sOldText = objLookUpEdit.Text
            dtView.RowFilter = ""
            objLookUpEdit.Text = sOldText
        Catch exp As Exception
            Message_Error(exp)
        End Try
    End Sub
End Class

'-------------
'</LookUpEdit>
'-------------
