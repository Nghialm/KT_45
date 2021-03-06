Imports Vns.Erp.Core.Admin.Domain
Imports Vns.Erp.Core.Admin.Service.Interface

Public Class frmKT_H_BAOCAO_DanhSach
#Region "Property"
    Public Property KtHDongService As IKtHDongService

    Private _KtHBaocaoService As IKtHBaocaoService
    Public Property KtHBaocaoService As IKtHBaocaoService
        Get
            Return _KtHBaocaoService
        End Get
        Set(ByVal value As IKtHBaocaoService)
            _KtHBaocaoService = value
        End Set
    End Property

#End Region


#Region "Contructor"

    Public Sub New()
        InitializeComponent()
        TNCommon.setIconControl(Me)
    End Sub
#End Region

#Region "Variables"

    Private KT_H_BAOCAO_ID As Guid
#End Region

#Region "Private Functions"

    Private Sub Load_GRV_KT_H_BAOCAO()
        Dim dt_KT_H_BAOCAO As IList(Of KtHBaocao) = _KtHBaocaoService.GetAll()
        grc_KT_H_BAOCAO.DataSource = dt_KT_H_BAOCAO
    End Sub

    Private Sub Create()
        Dim frm As frmKT_H_BAOCAO_ChiTiet = CType(ObjectFactory.GetObject("frmKT_H_BAOCAO_ChiTiet"), frmKT_H_BAOCAO_ChiTiet)
        frm.Show_form(Nothing, DataInputState.AddMode)
        Load_GRV_KT_H_BAOCAO()
    End Sub

    Private Sub Edit()
        If (grv_KT_H_BAOCAO.RowCount <> 0) Then
            KT_H_BAOCAO_ID = CType(GridHelper.GetRow(grv_KT_H_BAOCAO), KtHBaocao).Id
            Dim frm As frmKT_H_BAOCAO_ChiTiet = CType(ObjectFactory.GetObject("frmKT_H_BAOCAO_ChiTiet"), frmKT_H_BAOCAO_ChiTiet)
            frm.Show_form(KT_H_BAOCAO_ID, DataInputState.EditMode)
            Load_GRV_KT_H_BAOCAO()
        Else
            Message_Information("Không có bản ghi nào")
        End If
    End Sub

    Private Sub Delete()
        If (grv_KT_H_BAOCAO.RowCount <> 0) Then
            Dim tmp As KtHBaocao = CType(GridHelper.GetRow(grv_KT_H_BAOCAO), KtHBaocao)
            If (Message_Confirm("Bạn có chắc chắn muốn xóa bản ghi này?")) Then
                _KtHBaocaoService.Delete(tmp)
                Me.Load_GRV_KT_H_BAOCAO()
            End If
        Else
            Message_Information("Không có bản ghi nào được chọn!")
        End If
    End Sub

#End Region

#Region "Events"

    Private Sub frmKT_H_BAOCAO_DanhSach_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Load_GRV_KT_H_BAOCAO()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub frmKT_H_BAOCAO_DanhSach_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Try
            Select Case e.KeyCode
                Case Keys.F3
                    Create()
                Case Keys.F4
                    Edit()
                Case Keys.F8
                    Delete()
                Case Keys.Escape
                    Me.Close()
            End Select
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Try
            Create()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub btnModify_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModify.Click
        Try
            Edit()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Try
            Delete()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Try
            Me.Close()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub grv_KT_H_BAOCAO_CustomDrawCell(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs) Handles grv_KT_H_BAOCAO.CustomDrawCell
        Try
            If (e.Column.Name = "STT") Then
                e.DisplayText = Convert.ToString(e.RowHandle + 1)
            End If
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub
#End Region


    Private Sub btnExport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExport.Click
        xuatxml()
    End Sub

    Private Sub btnImport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImport.Click
        nhanxml()
    End Sub

    Private Sub xuatxml()
        If (grv_KT_H_BAOCAO.RowCount <> 0) Then
            KT_H_BAOCAO_ID = CType(GridHelper.GetRow(grv_KT_H_BAOCAO), KtHBaocao).Id
        Else
            Message_Information("Không có bản ghi nào")
            Return
        End If

        Dim dt_KT_H_BAOCAO As IList(Of KtHDong) = KtHDongService.GetBy_BAOCAO_Id(KT_H_BAOCAO_ID)

        Dim ds As New DataSet
        ds.Tables.Add(Vns.Erp.Core.DataHelper.ToDataTable(dt_KT_H_BAOCAO))

        Dim ofd As New SaveFileDialog()
        ofd.Filter = "XML file|*.xml"
        If ofd.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            ds.WriteXml(ofd.FileName)
        End If
    End Sub

    Private Sub nhanxml()
        If (grv_KT_H_BAOCAO.RowCount <> 0) Then
            KT_H_BAOCAO_ID = CType(GridHelper.GetRow(grv_KT_H_BAOCAO), KtHBaocao).Id
        Else
            Message_Information("Không có bản ghi nào")
            Return
        End If

        Dim lst_KtHBaocao As List(Of KtHDong) = New List(Of KtHDong)
        Dim ds As New DataSet
        Dim ofd As New OpenFileDialog()
        ofd.Filter = "XML file|*.xml"
        If ofd.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            ds.ReadXml(ofd.FileName)
            Dim dt_Import As New DataTable
            dt_Import = ds.Tables(0)
            lst_KtHBaocao = New List(Of KtHDong)
            For Each dr As DataRow In dt_Import.Rows
                Dim obj As New KtHDong
                obj = CType(Vns.Erp.Core.Object_GetDataRaw(obj, dr), KtHDong)
                lst_KtHBaocao.Add(obj)
            Next
        End If

        KtHDongService.DeleteByBaoCaoId(KT_H_BAOCAO_ID)
        For Each tmp As KtHDong In lst_KtHBaocao
            tmp.BaocaoId = KT_H_BAOCAO_ID
            KtHDongService.Save(tmp)
        Next
    End Sub
End Class