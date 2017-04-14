Imports DevExpress.XtraGrid.Views

Public Class ComboHelper
    Public Shared Function GetSelectData(ByVal grlLoaiTSCD As DevExpress.XtraEditors.GridLookUpEdit) As Object
        Return grlLoaiTSCD.Properties.GetRowByKeyValue(grlLoaiTSCD.EditValue)
        'Dim iRowIdx As Integer = grlLoaiTSCD.Properties.GetIndexByKeyValue(grlLoaiTSCD.EditValue)
        'If iRowIdx <> -1 Then
        '    Return DirectCast(grlLoaiTSCD.Properties.DataSource, IList)(iRowIdx)
        'End If
        'Return Nothing
    End Function

    Public Shared Function GetSelectData(ByVal grlLoaiTSCD As DevExpress.XtraEditors.LookUpEdit) As Object
        Return grlLoaiTSCD.Properties.GetDataSourceRowByKeyValue(grlLoaiTSCD.EditValue)
    End Function

    Shared Function GetSelectData(ByVal repositoryItemLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit, ByVal svalue As Object) As Object
        Return repositoryItemLookUpEdit.GetDataSourceRowByKeyValue(svalue)
    End Function

    Shared Function GetSelectData(ByVal repositoryItemLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit, ByVal svalue As Object) As Object
        Return repositoryItemLookUpEdit.GetRowByKeyValue(svalue)
    End Function


    Shared Function GetSelectData(ByVal rp As DevExpress.XtraGrid.Views.Grid.GridView) As Object
        Return rp.GetRow(rp.FocusedRowHandle)
    End Function
End Class
