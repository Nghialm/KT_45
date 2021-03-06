Imports Vns.Erp.Core.Admin.Domain
Imports Vns.Erp.Core.Admin.Service.Interface
Imports DevExpress.XtraGrid
'Imports Vns.Erp.Core.Dao

Public Class frmKhaiBaoChiTieu_DanhSach
#Region "Property"
    Private _KtHDongService As IKtHDongService
    Public Property KtHDongService As IKtHDongService
        Get
            Return _KtHDongService
        End Get
        Set(ByVal value As IKtHDongService)
            _KtHDongService = value
        End Set
    End Property
#End Region

#Region "Contructor"

    Public Sub New()
        InitializeComponent()
        TNCommon.setIconControl(Me)
    End Sub

#End Region

#Region "Show_form"

    Public Function Show_form(ByVal p_BaoCao_Id As Guid) As Boolean
        Try
            BAOCAO_ID = p_BaoCao_Id
            frmProgress.Instance.Thread = AddressOf Load_GRV_KT_H_DONG
            frmProgress.Instance.Show_Progress()
        Catch ex As Exception
            Message_Error(ex)
        End Try
        Return Me.ShowDialog = DialogResult.OK
    End Function
#End Region

#Region "Variables"
    Private KHAI_BAO_CT_ID As Guid
    Private BAOCAO_ID As Guid
    Dim obj_DONG_NEW As KtHDong
#End Region

#Region "Private Functions"

    Private Sub Load_GRV_KT_H_DONG()
        Dim dt_KT_H_BAOCAO As IList(Of KtHDong) = _KtHDongService.GetBy_BAOCAO_Id(BAOCAO_ID)
        grc_ChiTieu.DataSource = dt_KT_H_BAOCAO
    End Sub

    Private Sub Create()
        Dim frm As frmKhaiBaoChiTieu_ChiTiet = CType(ObjectFactory.GetObject("frmKhaiBaoChiTieu_ChiTiet"), frmKhaiBaoChiTieu_ChiTiet)
        obj_DONG_NEW = New KtHDong
        obj_DONG_NEW = frm.Show_form(Nothing, BAOCAO_ID, DataInputState.AddMode)
        Me.Load_GRV_KT_H_DONG()
        grv_focus()
    End Sub

    Private Sub Edit()
        If (grv_ChiTieu.RowCount <> 0) Then
            Dim i As Decimal = grv_ChiTieu.FocusedRowHandle
            Dim frm As frmKhaiBaoChiTieu_ChiTiet = CType(ObjectFactory.GetObject("frmKhaiBaoChiTieu_ChiTiet"), frmKhaiBaoChiTieu_ChiTiet)
            KHAI_BAO_CT_ID = CType(GridHelper.GetRow(grv_ChiTieu), KtHDong).Id
            frm.Show_form(KHAI_BAO_CT_ID, BAOCAO_ID, DataInputState.EditMode)
            Me.Load_GRV_KT_H_DONG()
            grv_ChiTieu.FocusedRowHandle = i
        Else
            Message_Information("Không có bản ghi nào")
        End If
    End Sub

    Private Sub Delete()
        If (grv_ChiTieu.RowCount <> 0) Then
            Dim delobj As KtHDong = CType(GridHelper.GetRow(grv_ChiTieu), KtHDong)
            If (Message_Confirm("Bạn có chắc chắn muốn xóa bản ghi này??")) Then
                _KtHDongService.Delete(delobj)
                Me.Load_GRV_KT_H_DONG()
            End If
        Else
            Message_Information("Không có bản ghi nào được chọn!")
        End If
    End Sub

    Private Sub grv_focus()
        'For i As Integer = 0 To grv_ChiTieu.RowCount - 1
        '    If (dv.Table.Rows(i)("ID_DONG") = obj_DONG_NEW.Id) Then
        '        grv_ChiTieu.FocusedRowHandle = i
        '    End If
        'Next
    End Sub

#End Region

#Region "Events"

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
        Me.Close()
    End Sub
#End Region

    Private Sub frmKhaiBaoChiTieu_DanhSach_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    

    Private Sub btnImport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImport.Click

    End Sub

    Private Sub btnExport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExport.Click

    End Sub

End Class