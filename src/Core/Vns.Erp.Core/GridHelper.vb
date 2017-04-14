Imports DevExpress.XtraGrid.Views
Imports System.Windows.Forms
Imports DevExpress.XtraGrid.Views.Grid

Public Class GridHelper
    Public Shared Function CheckAddNewRow(ByVal _GridView As Grid.GridView) As Boolean
        Return CheckAddNewRow(_GridView, True)
    End Function

    Public Shared Function CheckAddNewRow(ByVal _GridView As Grid.GridView, ByVal _ShowConfirm As Boolean) As Boolean
        Dim Check As Boolean = True
        If (_GridView.IsLastRow) Then
            Dim i As Integer = _GridView.Columns.Count
            Dim j As Integer = -1
            While i >= 0
                Try
                    If _GridView.GetVisibleColumn(i).Visible Then
                        j = _GridView.GetVisibleColumn(i).AbsoluteIndex
                        If _GridView.FocusedColumn.AbsoluteIndex = j And Not j = -1 Then
                            If (_ShowConfirm) Then
                                Dim dr As DialogResult = MessageBox.Show("Bạn có muốn thêm dòng mới không?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
                                If dr = DialogResult.Yes Then
                                    Return True
                                Else
                                    Return False
                                End If
                            Else
                                Return True
                            End If
                        End If
                        Exit While
                    End If
                Catch ex As Exception
                End Try
                i = i - 1
            End While
        End If
        Return False
    End Function

    Public Shared Function GetRow(ByVal _GridView As Grid.GridView) As Object
        Dim currentRow As Object = _GridView.GetRow(_GridView.FocusedRowHandle)
        If currentRow Is Nothing Then
            Return Nothing
        End If
        Return currentRow
    End Function

    Public Shared Sub SetFocus_AfterAddRow(ByVal _GridView As GridView, ByVal i As Integer)
        If _GridView.RowCount > 0 Then
            _GridView.FocusedRowHandle = i
            _GridView.FocusedColumn = _GridView.VisibleColumns(0)
        End If
    End Sub
End Class
