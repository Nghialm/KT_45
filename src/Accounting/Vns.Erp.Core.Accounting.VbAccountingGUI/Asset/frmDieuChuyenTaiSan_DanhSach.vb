Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Columns

Imports Vns.Erp.Core.Admin.Domain
Imports Vns.Erp.Core.Admin.Service.Interface

Public Class frmDieuChuyenTaiSan_DanhSach

#Region "Variables"

    Private obj_tscd As DmTscd = New DmTscd()
    Private obj_TSDC As TsDieuchuyen = New TsDieuchuyen
    Private lst_tscd As List(Of DmTscd) = New List(Of DmTscd)
    Private lst_ts_dc As List(Of TsDieuchuyen) = New List(Of TsDieuchuyen)
    Private frm As New frmDieuChuyenTaiSan_ChiTiet
#End Region

#Region "Property"
    Private _DmTscdService As IDmTscdService
    Public Property DmTscdService() As IDmTscdService
        Get
            Return _DmTscdService
        End Get
        Set(ByVal value As IDmTscdService)
            _DmTscdService = value
        End Set
    End Property

    Private _TsDieuchuyenService As ITsDieuchuyenService
    Public Property TsDieuchuyenService() As ITsDieuchuyenService
        Get
            Return _TsDieuchuyenService
        End Get
        Set(ByVal value As ITsDieuchuyenService)
            _TsDieuchuyenService = value
        End Set
    End Property

    Private _DmPhongbanService As IDmPhongbanService
    Public Property DmPhongbanService() As IDmPhongbanService
        Get
            Return _DmPhongbanService
        End Get
        Set(ByVal value As IDmPhongbanService)
            _DmPhongbanService = value
        End Set
    End Property

    Private _DmTaikhoanService As IDmTaikhoanService
    Public Property DmTaikhoanService() As IDmTaikhoanService
        Get
            Return _DmTaikhoanService
        End Get
        Set(ByVal value As IDmTaikhoanService)
            _DmTaikhoanService = value
        End Set
    End Property
#End Region

#Region "Private functions"

    Public Sub New()
        InitializeComponent()
        TNCommon.setIconControl(Me)
    End Sub

    Private Sub Load_grv_TSCD()
        Dim TotalResult As Integer
        lst_tscd.AddRange(_DmTscdService.GetObjectAllByDonviID(-1, -1, Generals.DON_VI.Id, TotalResult))
        grcTSCD.DataSource = lst_tscd
    End Sub

    Private Sub Load_grv_BoPhan(ByVal TSCD_ID As Guid)
        lst_ts_dc = New List(Of TsDieuchuyen)
        lst_ts_dc.AddRange(_TsDieuchuyenService.GetObjectByTSCD_ID(TSCD_ID))
        grcBoPhan.DataSource = lst_ts_dc
    End Sub

    Private Sub frmDieuChuyenTaiSan_DanhSach_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Load_grv_TSCD()

            'bind bo phan dieu chuyen
            Dim lstDM_PB As New List(Of DmPhongban)
            lstDM_PB.AddRange(_DmPhongbanService.GetAllByDonviID(Generals.DON_VI.Id))
            cboBO_PHAN_DC_ID.DataSource = lstDM_PB
            cboBO_PHAN_DC_ID.DisplayMember = "TenPhongban"
            cboBO_PHAN_DC_ID.ValueMember = "Id"

            'tao cac unbound column
            grcBoPhan.ForceInitialize()
            'ub tai khoan tai san
            Dim ubTKTS As GridColumn = grvBoPhan.Columns.AddField("TK_TS")
            ubTKTS.Caption = "Tài khoản tài sản"
            ubTKTS.VisibleIndex = 3
            ubTKTS.Width = 200
            ubTKTS.UnboundType = DevExpress.Data.UnboundColumnType.String
            ubTKTS.OptionsColumn.ReadOnly = True
            'ub tai san khau hao
            Dim ubTKKH As GridColumn = grvBoPhan.Columns.AddField("TK_KH")
            ubTKKH.Caption = "Tài khoản khấu hao"
            ubTKKH.VisibleIndex = 4
            ubTKKH.Width = 200
            ubTKKH.UnboundType = DevExpress.Data.UnboundColumnType.String
            ubTKKH.OptionsColumn.ReadOnly = True
            'ub tai san chi phi
            Dim ubTKCP As GridColumn = grvBoPhan.Columns.AddField("TK_CP")
            ubTKCP.Caption = "Tài khoản chi phí"
            ubTKCP.VisibleIndex = 5
            ubTKCP.Width = 200
            ubTKCP.UnboundType = DevExpress.Data.UnboundColumnType.String
            ubTKCP.OptionsColumn.ReadOnly = True
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub Create()
        'Try
        frm = CType(ObjectFactory.GetObject("frmDieuChuyenTaiSan_ChiTiet"), frmDieuChuyenTaiSan_ChiTiet)
        If (frm.Show_Form(obj_tscd.Id, Null.NullGuid, DataInputState.AddMode)) Then
            Me.Load_grv_BoPhan(obj_tscd.Id)
            grvBoPhan.FocusedRowHandle = grvBoPhan.RowCount - 1
        End If
        'Catch ex As Exception
        '    Message_Error(ex)
        'End Try
    End Sub

    Private Sub Edit()
        'Try
        If (grvBoPhan.RowCount <> 0) Then
            obj_TSDC = CType(grvBoPhan.GetRow(grvBoPhan.FocusedRowHandle), TsDieuchuyen)
            If (obj_TSDC.ThuTu < lst_ts_dc.Count) Then
                Message_Warning("Bạn không được sửa bản ghi này")
            Else
                frm = CType(ObjectFactory.GetObject("frmDieuChuyenTaiSan_ChiTiet"), frmDieuChuyenTaiSan_ChiTiet)
                If (frm.Show_Form(obj_tscd.Id, obj_TSDC.Id, DataInputState.EditMode)) Then
                    Me.Load_grv_BoPhan(obj_tscd.Id)
                    grvBoPhan.FocusedRowHandle = grvBoPhan.RowCount - 1
                End If
            End If
        Else
            Message_Warning("Không có bản ghi nào!")
        End If
        'Catch ex As Exception
        '    Message_Error(ex)
        'End Try
    End Sub

    Private Sub Delete()
        'Try
        If grvBoPhan.RowCount <> 0 Then
            obj_TSDC = CType(grvBoPhan.GetRow(grvBoPhan.FocusedRowHandle), TsDieuchuyen)
            If (obj_TSDC.ThuTu < lst_ts_dc.Count) Then
                Message_Warning("Bạn không được xóa bản ghi này")
            ElseIf (MessageBox.Show("Bạn có chắc chắn muốn xóa bản ghi này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes) Then
                _TsDieuchuyenService.Delete(obj_TSDC)
                Me.Load_grv_BoPhan(obj_tscd.Id)
                grvBoPhan.RefreshData()
            End If
        Else
            Message_Warning("Không có bản ghi nào được chọn!")
        End If
        'Catch ex As Exception
        '    Message_Error(ex)
        'End Try
    End Sub
#End Region

#Region "Events"

    Private Sub grvTSCD_FocusedRowChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles grvTSCD.FocusedRowChanged
        Try
            If (lst_tscd.Count <> 0) Then
                obj_tscd = CType(grvTSCD.GetRow(grvTSCD.FocusedRowHandle), DmTscd)
                Load_grv_BoPhan(obj_tscd.Id)
                grvBoPhan.RefreshData()
            End If
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub btnCreate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChuyen.Click
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

    Private Sub frmDieuChuyenTaiSan_DanhSach_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
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

    Private Function GetTen_TK(ByVal TAI_KHOAN_ID As Guid, ByVal dt As IList(Of DmTaikhoan)) As DmTaikhoan
        Dim obj_tk As DmTaikhoan = New DmTaikhoan
        For Each dr As DmTaikhoan In dt
            If dr.Id = TAI_KHOAN_ID Then
                obj_tk.Id = dr.Id
                obj_tk.TenTaikhoan = dr.TenTaikhoan
                obj_tk.MaTaikhoan = dr.MaTaikhoan
            End If
        Next
        Return obj_tk
    End Function

    Private Function GetTen_TK(ByVal MaTaikhoan As String, ByVal dt As IList(Of DmTaikhoan)) As DmTaikhoan
        Dim obj_tk As DmTaikhoan = New DmTaikhoan
        For Each dr As DmTaikhoan In dt
            If dr.MaTaikhoan = MaTaikhoan Then
                obj_tk.Id = dr.Id
                obj_tk.TenTaikhoan = dr.TenTaikhoan
                obj_tk.MaTaikhoan = dr.MaTaikhoan
            End If
        Next
        Return obj_tk
    End Function

    Private Sub grvBoPhan_CustomUnboundColumnData(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs) Handles grvBoPhan.CustomUnboundColumnData
        Try
            'set, get gia tri cho unbound coloumn
            Dim dt As List(Of DmTaikhoan) = New List(Of DmTaikhoan)
            dt.AddRange(_DmTaikhoanService.GetAllByDonviID(Generals.DON_VI.Id))

            If (_TsDieuchuyenService.GetObjectByTSCD_ID(obj_tscd.Id).Count <> 0) Then
                Dim objtemp As DmTscd = CType(grvTSCD.GetRow(grvTSCD.FocusedRowHandle), DmTscd)
                If e.Column.FieldName = "TK_TS" And e.IsGetData Then
                    e.Value = GetTen_TK(objtemp.MdTkTs, dt).MaTaikhoan
                End If
                If e.Column.FieldName = "TK_KH" And e.IsGetData Then
                    e.Value = GetTen_TK(objtemp.MdTkKhauhao, dt).MaTaikhoan
                End If
                If e.Column.FieldName = "TK_CP" And e.IsGetData Then
                    e.Value = GetTen_TK(objtemp.MdTkChiphi, dt).MaTaikhoan
                End If
            End If
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
#End Region

End Class