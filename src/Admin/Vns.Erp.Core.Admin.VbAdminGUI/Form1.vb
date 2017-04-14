Imports Spring.Context
Imports Spring.Context.Support
Imports Vns.Erp.Core.Admin.Service.Interface
Imports Vns.Erp.Core.Service.Interface
Imports Vns.Erp.Core.Domain

Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'IApplicationContext ctx = ContextRegistry.GetContext();
        'Console.WriteLine("Get AppDvBcService...");
        'IAppDvBcService firstCalc = (IAppDvBcService)ctx.GetObject("AppDvBcService");
        'AppDvBc o = firstCalc.Get((decimal)1.00);
        'IList<AppDvBc> list = firstCalc.List(1, 10, null, null, null);
        'IAppGroupsService AppGroupsService = (IAppGroupsService)ctx.GetObject("AppGroupsService");
        'IList<AppGroups> listAppGroups = AppGroupsService.List(-1, -1, null, null, null);
        'Dim o As Vns.Erp.Core.Dao.NHibernate.CustomLocalSessionFactoryObject

        'Dim ctx As IApplicationContext
        'ctx = ContextRegistry.GetContext()
        'Dim AppGroupsService As IAppGroupsService
        'AppGroupsService = ctx.GetObject("AppGroupsService")


        'Dim count As Integer
        'count = AppGroupsService.GetCount()

        'Dim AppDvBcService As IAppDvBcService
        'AppDvBcService = ctx.GetObject("AppDvBcService")

        'Dim list As IList(Of AppDvBc) = AppDvBcService.List(1, 10, Nothing, Nothing, Nothing)

        'count = AppDvBcService.GetCount()

        'Dim frmUserRightList As frmUserRightList = ctx.GetObject("frmUserRightList")
    End Sub
End Class
