Public Class frmGridFilter
    Private m_DataTable As DataTable
    Private sCondition As String

    Public Function Show_Form(ByVal dt As DataTable) As Boolean
        '
        'Dim sFilter As String = dt.DefaultView.RowFilter
        'Dim dtCondition As New DataTable
        'dtCondition.Columns.Add("Column_Name", GetType(String))
        'dtCondition.Columns.Add("Column_Criteria", GetType(String))
        'dtCondition.Columns(1).AllowDBNull = False
        'If Not String.IsNullOrEmpty(sFilter) Then
        '    sFilter = sFilter.Replace(" AND ", vbTab)
        '    For Each sCondition As String In sFilter.Split(vbTab)
        '        sCondition = sCondition.Trim
        '        Dim dr As DataRow = dtCondition.NewRow
        '        Dim i As Integer = grdTableSetting.Rows.Add()
        '        Dim iPos As Integer = sCondition.IndexOf(" ")
        '        Dim sFieldName As String = sCondition.Substring(0, iPos)
        '        Dim sCriteria As String = sCondition.Substring(iPos + 1)
        '        If sCriteria.StartsWith("=") Then sCriteria = sCriteria.Substring(1)
        '        If sCriteria.StartsWith("'") AndAlso sCriteria.EndsWith("'") Then
        '            sCriteria = sCriteria.Substring(1)
        '            sCriteria = sCriteria.Substring(0, sCriteria.Length - 1)
        '        End If
        '        dr.Item("Column_Name") = sFieldName
        '        dr.Item("Column_Criteria") = sCriteria
        '        dtCondition.Rows.Add(dr)
        '    Next
        'End If
        'Dim dh As New DataGridHandle(grdTableSetting)
        'dh.AutoRequired = True

        'grdTableSetting.Columns(0).DataPropertyName = "Column_Name"
        'grdTableSetting.Columns(1).DataPropertyName = "Column_Criteria"
        'grdTableSetting.AutoGenerateColumns = False
        'grdTableSetting.DataSource = dtCondition
        'm_DataTable = dt
        'Return Me.ShowDialog = Windows.Forms.DialogResult.OK
        Return Nothing
    End Function

    Private Sub cmdOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOK.Click
        'Try
        '    sCondition = ""
        '    For Each row As DataGridViewRow In grdTableSetting.Rows
        '        If row.IsNewRow Then Continue For
        '        If Not String.IsNullOrEmpty(sCondition) Then
        '            sCondition += " AND "
        '        Else
        '            sCondition += ""
        '        End If
        '        Dim sFieldName As String = row.Cells("Column_Name").Value
        '        Dim sCriteria As String = row.Cells("Column_Criteria").Value
        '        sCriteria = sCriteria.Trim
        '        If sCriteria.StartsWith("=") _
        '        OrElse sCriteria.StartsWith("IN", StringComparison.CurrentCultureIgnoreCase) _
        '        OrElse sCriteria.StartsWith("LIKE", StringComparison.CurrentCultureIgnoreCase) _
        '        OrElse sCriteria.StartsWith(">", StringComparison.CurrentCultureIgnoreCase) _
        '        OrElse sCriteria.StartsWith("<", StringComparison.CurrentCultureIgnoreCase) _
        '        OrElse sCriteria.StartsWith("BETWEEN", StringComparison.CurrentCultureIgnoreCase) _
        '        OrElse sCriteria.StartsWith(">=", StringComparison.CurrentCultureIgnoreCase) _
        '        OrElse sCriteria.StartsWith("<=", StringComparison.CurrentCultureIgnoreCase) _
        '        OrElse sCriteria.StartsWith("<>", StringComparison.CurrentCultureIgnoreCase) _
        '        Then
        '        Else
        '            If Not (sCriteria.StartsWith("'") And sCriteria.EndsWith("'")) Then
        '                sCriteria = "='" + sCriteria + "'"
        '            Else
        '                sCriteria = "=" + sCriteria
        '            End If
        '        End If
        '        sCondition += sFieldName + " " + sCriteria
        '    Next
        '    Try
        '        m_DataTable.DefaultView.RowFilter = sCondition
        '    Catch
        '        Message_Information("Invalid condition, please check condition syntax")
        '        Return
        '    End Try
        '    Me.Tag = sCondition
        '    Me.DialogResult = Windows.Forms.DialogResult.OK
        '    Me.Hide()
        'Catch ex As Exception
        '    Message_Error(ex)
        'End Try
    End Sub

    Private Sub cmdCancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        Me.Hide()
    End Sub
End Class