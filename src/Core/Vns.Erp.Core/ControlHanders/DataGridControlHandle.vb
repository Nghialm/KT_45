
'*******************************************************************
' Purpose:  Class dùng handle cho DevExpress Grid Control
' Notes:    
' History:
'     [Programer]       [DD-MMM-YYYY]       [Action]
'     HieuVT            06-12-2010         Created
'*******************************************************************  
Public Class DataGridControlHandle
    Private WithEvents m_objGridControl As DevExpress.XtraGrid.GridControl


    Public Function GetKeyValue(ByVal grv As DevExpress.XtraGrid.Views.Grid.GridView, ByVal keyvalue As Object) As Object
        'If m_objGridControl.OptionsView. Is Nothing OrElse m_objGrid.CurrentRow.IsNewRow Then
        '    Return Nothing
        'Else
        'Return DB_GetValue(DirectCast(m_objGrid.CurrentRow.DataBoundItem, DataRowView).Item(_sPrimaryKey), Nothing)
        'End If
        'm_objGridControl.


        Dim row As DataRow = grv.GetDataRow(grv.FocusedRowHandle)
        If row Is Nothing Then
            Return Nothing
        Else
            keyvalue = row("ImporterID")
        End If

        Return keyvalue

    End Function

End Class