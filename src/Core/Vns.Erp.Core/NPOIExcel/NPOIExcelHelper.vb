Imports System.IO
Imports NPOI.SS.UserModel
Imports NPOI.HSSF.UserModel
Imports NPOI.POIFS.FileSystem
Imports System.Windows.Forms

Public Class NPOIExcelHelper

    Public Shared Function ReadDicFile(ByVal filename As String) As DataTable
        Dim hssfwb As IWorkbook
        Dim file As FileStream = New FileStream(filename, FileMode.Open, FileAccess.Read)

        Dim workbook As IWorkbook = New HSSFWorkbook(New POIFSFileSystem(file))
        If workbook Is Nothing Then
            Return Nothing
        Else
            Dim sheet As ISheet = workbook.GetSheet("SO_LIEU")
            Dim numberRows As Integer = sheet.PhysicalNumberOfRows
            Dim number As Integer = sheet.LastRowNum
            Dim startCol As Integer = 0
            Dim headerRow As Integer = 0
            Dim startRow As Integer = 1

            'Tao Column
            Dim endcol As Integer = 0

            Dim dt As DataTable = New DataTable()
            Dim hRow As IRow = sheet.GetRow(headerRow)
            For h As Integer = startCol To 50 Step 1
                If hRow.GetCell(h) Is Nothing Then
                    Exit For
                End If

                Dim colname As String = hRow.GetCell(h).ToString()
                If String.IsNullOrEmpty(colname) Then
                    Exit For
                Else
                    endcol = h
                    Dim dc As DataColumn = New DataColumn(colname, GetType(System.String))
                    dt.Columns.Add(dc)
                End If

            Next

            For i As Integer = startRow To number Step 1
                Dim row As IRow = sheet.GetRow(i)
                Dim dr As DataRow = dt.NewRow()
                For j As Integer = startCol To endcol Step 1
                    Dim tmp As Object = row.GetCell(j)
                    If tmp Is Nothing Then
                        dr.Item(j - startCol) = ""
                    Else
                        dr.Item(j - startCol) = row.GetCell(j).ToString()
                    End If
                Next
                dt.Rows.Add(dr)
            Next

            Return dt
        End If
    End Function
End Class
