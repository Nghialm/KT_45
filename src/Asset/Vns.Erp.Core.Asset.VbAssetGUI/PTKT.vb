Imports Vns.Erp.Core.Asset.Service.Interface
Imports Vns.Erp.Core.Asset.Domain

Public Class PTKT
#Region "Property"
    Private _TsTscdPtungService As ITsTscdPtungService
    Public Property TsTscdPtungService As ITsTscdPtungService
        Get
            Return _TsTscdPtungService
        End Get
        Set(ByVal value As ITsTscdPtungService)
            _TsTscdPtungService = value
        End Set
    End Property
#End Region

    Public Function GetData(ByVal TSCD_ID As Guid) As DataTable
        Dim dt As DataTable = New DataTable
        dt = DataHelper.ToDataTable(Of TsTscdPtung)(_TsTscdPtungService.GetAllByTSCD_ID(TSCD_ID))
        Return dt
    End Function

End Class