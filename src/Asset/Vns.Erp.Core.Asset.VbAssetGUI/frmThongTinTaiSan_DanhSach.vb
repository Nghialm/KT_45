Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Views.Grid

Imports Vns.Erp.Core.Asset.Domain
Imports Vns.Erp.Core.Asset.Service.Interface

Public Class frmThongTinTaiSan_DanhSach

#Region "Property"
    Private _DmLoaitaisanService As IDmLoaitaisanService
    Public Property DmLoaitaisanService As IDmLoaitaisanService
        Get
            Return _DmLoaitaisanService
        End Get
        Set(ByVal value As IDmLoaitaisanService)
            _DmLoaitaisanService = value
        End Set
    End Property
    Private _DmTscdService As IDmTscdService
    Public Property DmTscdService As IDmTscdService
        Get
            Return _DmTscdService
        End Get
        Set(ByVal value As IDmTscdService)
            _DmTscdService = value
        End Set
    End Property
#End Region

#Region "Variables"

    Dim DM_TSCD_ID As Guid
    Dim TSCD_new As DmTscd
#End Region

#Region "Private functions"

    Public Sub New()
        InitializeComponent()
        TNCommon.setIconControl(Me)
    End Sub

    Private Sub BindData()
        Dim DON_VI_ID As Guid = Generals.DON_VI.Id
        Dim objColumnDefine As ArrayList

        'Dim dt_DM_LoaiTS As DataTable = DM_LoaitaisanBO.Instance.GetAll.Tables(0)
        Dim dt_DM_LoaiTS As List(Of DmLoaitaisan) = New List(Of DmLoaitaisan)

        dt_DM_LoaiTS.AddRange(_DmLoaitaisanService.GetAllSortByKyHieu())

        Dim dr As New DmLoaitaisan
        dr.KyHieu = ""
        dr.Id = Null.NullGuid
        dr.TenLoaitaisan = "<Không xác định>"
        dt_DM_LoaiTS.Insert(0, dr)

        objColumnDefine = New ArrayList
        objColumnDefine.Add(New LookupEdit_ColumnInfo("KyHieu", "Ký hiệu"))
        objColumnDefine.Add(New LookupEdit_ColumnInfo("TenLoaitaisan", "Tên loại tài sản"))
        GridLookupEdit_BindData(grlLoaiTSCD, dt_DM_LoaiTS, "KyHieu", "Id", COMBO_ITEM_BLANK, "TenLoaitaisan", txttenLoaiTS, objColumnDefine)
    End Sub

    'bind data vao grid
    Private Sub Load_GRV_TSCD()
        Dim lst_TSCD As IList(Of DmTscd) = New List(Of DmTscd)
        lst_TSCD = _DmTscdService.GetbyParameter((dteTuNgay.DateTime), (dteDenNgay.DateTime), txtTenTS.Text.Trim, VnsConvert.CGuid(grlLoaiTSCD.EditValue), Generals.DON_VI.Id)
        grcTSCD.DataSource = lst_TSCD
        'grvTSCD.BestFitColumns()
    End Sub

    Private Sub Create()
        Dim frm As frmThongTinTSCD_ChiTiet = CType(ObjectFactory.GetObject("frmThongTinTSCD_ChiTiet"), frmThongTinTSCD_ChiTiet)
        TSCD_new = frm.Show_Form(Nothing, DataInputState.AddMode)
        If TSCD_new IsNot Nothing Then
            Me.Load_GRV_TSCD()
            grv_focus()
        End If
    End Sub

    Private Sub Edit()
        If grvTSCD.RowCount <> 0 Then
            Dim i As Integer = grvTSCD.FocusedRowHandle
            'DM_TSCD_ID = Grid_GetDataRowItemString(grvTSCD, "Id")
            DM_TSCD_ID = CType(grvTSCD.GetRow(i), DmTscd).Id

            If (Grid_GetDataRowItemInteger(grvTSCD, "GIAM_TSCD") = 1) Then
                Message_Information("Tài sản đã khai báo giảm")
                Exit Sub
            End If

            Dim frm As frmThongTinTSCD_ChiTiet = CType(ObjectFactory.GetObject("frmThongTinTSCD_ChiTiet"), frmThongTinTSCD_ChiTiet)
            TSCD_new = frm.Show_Form(DM_TSCD_ID, DataInputState.EditMode)
            If TSCD_new IsNot Nothing Then
                Me.Load_GRV_TSCD()
                'grv_focus()
            End If
        Else
            MessageBox.Show("Không có bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub Delete()
        If grvTSCD.RowCount <> 0 Then
            Dim i As Integer = grvTSCD.FocusedRowHandle
            'DM_TSCD_ID = Grid_GetDataRowItemString(grvTSCD, "Id")
            DM_TSCD_ID = CType(grvTSCD.GetRow(i), DmTscd).Id

            If (Grid_GetDataRowItemInteger(grvTSCD, "GIAM_TSCD") = 1) Then
                Message_Information("Tài sản đã khai báo giảm")
                Exit Sub
            End If
            If (MessageBox.Show("Bạn có chắc chắn muốn xóa bản ghi này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes) Then
                DmTscdService.DeleteById(DM_TSCD_ID)
                Me.Load_GRV_TSCD()
            End If
        Else
            MessageBox.Show("Không có bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If


    End Sub

    Private Sub grv_focus()
        'TNCommon.GridControl_SetRowFocus(grcTSCD, "MaTscd", TSCD_new.MaTscd)
    End Sub
#End Region

#Region "Events"

    Private Sub frmThongTinTaiSan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            'btnPrint.Visible = False

            BindData()
            Dim F_ngay As Date = Date.Now.Date
            Dim S_ngay As Date = New Date(F_ngay.Year, 1, 1)
            dteTuNgay.DateTime = S_ngay
            dteDenNgay.DateTime = F_ngay
            Load_GRV_TSCD()
            grvTSCD.FixedLineWidth = 0
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub btnCreate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
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



    Private Sub frmThongTinTaiSan_DanhSach_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Try
            Select Case e.KeyCode
                Case Keys.Escape
                    Me.Close()
                    Exit Select
                Case Keys.F3
                    Create()
                    Exit Select
                Case Keys.F4
                    Edit()
                    Exit Select
                Case Keys.F8
                    Delete()
                    Exit Select
            End Select
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

    Private Sub btnIn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        Try
            Dim frm As In_The_TSCD = ObjectFactory.GetObject("In_The_TSCD", New Object() {dteTuNgay.DateTime, dteDenNgay.DateTime, txtTenTS.Text, grlLoaiTSCD.EditValue, Generals.DON_VI.Id})
            frm.ShowDialog()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Try
            frmProgress.Instance.Thread = AddressOf Load_GRV_TSCD
            frmProgress.Instance.Show_Progress()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub grlLoaiTSCD_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grlLoaiTSCD.EditValueChanged
        Try
            Dim dr As DmLoaitaisan = CType(ComboHelper.GetSelectData(grlLoaiTSCD), DmLoaitaisan)
            If dr IsNot Nothing Then
                txttenLoaiTS.Text = dr.TenLoaitaisan
            End If
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub
#End Region

    Private Sub btnXem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnXem.Click
        Try
            If grvTSCD.RowCount <> 0 Then
                Dim i As Integer = grvTSCD.FocusedRowHandle
                'DM_TSCD_ID = Grid_GetDataRowItemString(grvTSCD, "Id")
                DM_TSCD_ID = CType(grvTSCD.GetRow(i), DmTscd).Id

                Dim frm As New frmThongTinTSCD_ChiTiet
                TSCD_new = frm.Show_Form(DM_TSCD_ID, DataInputState.ViewMode)
                If TSCD_new IsNot Nothing Then
                    Me.Load_GRV_TSCD()
                    grv_focus()
                End If
            Else
                MessageBox.Show("Không có bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub grvTSCD_FocusedRowChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles grvTSCD.FocusedRowChanged
        Try
            If Grid_GetDataRowItemInteger(grvTSCD, "GIAM_TSCD") = 1 Then
                btnXem.Enabled = True
                btnModify.Enabled = False
                btnDelete.Enabled = False
            Else
                btnXem.Enabled = False
                btnModify.Enabled = True
                btnDelete.Enabled = True
            End If
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
End Class