Imports Vns.Erp.Core.Admin.Service.Interface
Imports Vns.Erp.Core.Accounting.Report.Service.Interface

Public Class CT_TSCD
#Region "Property"
    Private _DmTscdService As IDmTscdService
    Public Property DmTscdService As IDmTscdService
        Get
            Return _DmTscdService
        End Get
        Set(ByVal value As IDmTscdService)
            _DmTscdService = value
        End Set
    End Property

    Private _RpTheTscdS23DnService As IRpTheTscdS23DnService
    Public Property RpTheTscdS23DnService As IRpTheTscdS23DnService
        Get
            Return _RpTheTscdS23DnService
        End Get
        Set(ByVal value As IRpTheTscdS23DnService)
            _RpTheTscdS23DnService = value
        End Set
    End Property
#End Region

    Public Function Bindata(ByVal TSCD_ID As Guid)
        Return _RpTheTscdS23DnService.GetData(TSCD_ID)
    End Function
End Class