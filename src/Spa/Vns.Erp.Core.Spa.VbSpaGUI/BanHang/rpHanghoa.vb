Imports Vns.Erp.Core.Spa.Domain

Public Class rpHanghoa

    Public Function GetData(ByVal lstSource As IList(Of CtDHddv)) As DataTable
        Dim dt As DataTable = New DataTable
        dt = DataHelper.ToDataTable(Of CtDHddv)(lstSource)
        Return dt
    End Function

End Class