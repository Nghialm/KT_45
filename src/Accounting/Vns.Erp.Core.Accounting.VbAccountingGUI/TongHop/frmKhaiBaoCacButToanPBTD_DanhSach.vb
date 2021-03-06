Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Repository

Imports Vns.Erp.Core.Admin.Domain
Imports Vns.Erp.Core.Accounting.Domain
Imports Vns.Erp.Core.Accounting.Service.Interface
Imports Vns.Erp.Core.Admin.Service.Interface
Public Class frmKhaiBaoCacButToanPBTD_DanhSach
#Region "Property"
    Private _KtDmBtPhanboService As IKtDmBtPhanboService
    Public Property KtDmBtPhanboService As IKtDmBtPhanboService
        Get
            Return _KtDmBtPhanboService
        End Get
        Set(ByVal value As IKtDmBtPhanboService)
            _KtDmBtPhanboService = value
        End Set
    End Property

    Private _DmKhangService As IDmKhangService
    Public Property DmKhangService As IDmKhangService
        Get
            Return _DmKhangService
        End Get
        Set(ByVal value As IDmKhangService)
            _DmKhangService = value
        End Set
    End Property

    Private _DmVuviecService As IDmVuviecService
    Public Property DmVuviecService As IDmVuviecService
        Get
            Return _DmVuviecService
        End Get
        Set(ByVal value As IDmVuviecService)
            _DmVuviecService = value
        End Set
    End Property

    Private _DmKhoanphiService As IDmKhoanphiService
    Public Property DmKhoanphiService As IDmKhoanphiService
        Get
            Return _DmKhoanphiService
        End Get
        Set(ByVal value As IDmKhoanphiService)
            _DmKhoanphiService = value
        End Set
    End Property

    Private _DmTudo1Service As IDmTudo1Service
    Public Property DmTudo1Service As IDmTudo1Service
        Get
            Return _DmTudo1Service
        End Get
        Set(ByVal value As IDmTudo1Service)
            _DmTudo1Service = value
        End Set
    End Property

    Private _DmHopdongService As IDmHopdongService
    Public Property DmHopdongService As IDmHopdongService
        Get
            Return _DmHopdongService
        End Get
        Set(ByVal value As IDmHopdongService)
            _DmHopdongService = value
        End Set
    End Property
#End Region

    Dim BTPBTD_ID As String
    Dim p_nhom As String
    Dim p_NAM As Integer
    Dim lst_PB_Nam_Con As List(Of KtDmBtPhanbo) = New List(Of KtDmBtPhanbo)
    Dim lstobj_DM_BT_PB As List(Of KtDmBtPhanbo) = New List(Of KtDmBtPhanbo)

    Public Sub New()
        InitializeComponent()
        TNCommon.setIconControl(Me)
    End Sub

    Private Sub LoadGrv_cha()
        lstobj_DM_BT_PB = New List(Of KtDmBtPhanbo)
        lstobj_DM_BT_PB.AddRange(_KtDmBtPhanboService.GetByDonviId(Generals.DON_VI.Id))
        Dim lst_nhom As List(Of KtDmBtPhanbo) = New List(Of KtDmBtPhanbo)
        'lst_nhom.Clear()
        Dim nhom As Integer = 0
        Dim i As Integer
        For i = 0 To lstobj_DM_BT_PB.Count - 1
            If (lstobj_DM_BT_PB(i).Nhom <> nhom) Then

                lst_nhom.Add(lstobj_DM_BT_PB(i))
                nhom = lstobj_DM_BT_PB(i).Nhom
            End If
        Next
        _GridControl.DataSource = lst_nhom
        _GridView.Columns("LoaiPhanbo").ColumnEdit = grid_ColumnEdit()
    End Sub

    Private Sub frmKhaiBaoCacButToanPBTD_DanhSach_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            LoadGrv_cha()

            For i As Integer = 0 To _GridView.Columns.Count - 1
                _GridView.Columns(i).OptionsColumn.ReadOnly = True
            Next
            For i As Integer = 0 To _GridView.Columns.Count - 1
                gridView1.Columns(i).OptionsColumn.ReadOnly = True
            Next
            cboKC_KH.DataSource = _DmKhangService.GetAllByDonviID(Generals.DON_VI.Id)
            cboKC_KH.DisplayMember = "TenKhang"
            cboKC_KH.ValueMember = "Id"
            cboKC_KH.Columns.Add(New LookUpColumnInfo("KyHieu", "Ký hiệu"))
            cboKC_KH.Columns.Add(New LookUpColumnInfo("TenKhang", "Tên khách hàng"))
            'bind vu viec
            cboKC_VUVIEC.DataSource = _DmVuviecService.GetAllByDonviID(Generals.DON_VI.Id)
            cboKC_VUVIEC.DisplayMember = "TenVuviec"
            cboKC_VUVIEC.ValueMember = "Id"
            cboKC_VUVIEC.Columns.Add(New LookUpColumnInfo("KyHieu", "Ký hiệu"))
            cboKC_VUVIEC.Columns.Add(New LookUpColumnInfo("TenVuviec", "Tên vụ việc"))
            'bind  phi
            cboKC_PHI.DataSource = _DmKhoanphiService.GetAllByDonviID(Generals.DON_VI.Id)
            cboKC_PHI.DisplayMember = "TenDmKhoanphi"
            cboKC_PHI.ValueMember = "Id"
            cboKC_PHI.Columns.Add(New LookUpColumnInfo("KyHieu", "Ký hiệu"))
            cboKC_PHI.Columns.Add(New LookUpColumnInfo("TenDmKhoanphi", "Tên khoản phí"))
            'bind DMTD
            cboKC_TUDO.DataSource = _DmTudo1Service.GetAllByDonviID(Generals.DON_VI.Id)
            cboKC_TUDO.DisplayMember = "TenDmTudo1"
            cboKC_TUDO.ValueMember = "Id"
            cboKC_TUDO.Columns.Add(New LookUpColumnInfo("KyHieu", "Ký hiệu"))
            cboKC_TUDO.Columns.Add(New LookUpColumnInfo("TenDmTudo1", "Tên danh mục tự do"))
            'bind Hop dong
            cboKC_HOPDONG.DataSource = _DmHopdongService.GetAllByDonviID(Generals.DON_VI.Id)
            cboKC_HOPDONG.DisplayMember = "TenHopdong"
            cboKC_HOPDONG.ValueMember = "Id"
            cboKC_HOPDONG.Columns.Add(New LookUpColumnInfo("KyHieu", "Ký hiệu"))
            cboKC_HOPDONG.Columns.Add(New LookUpColumnInfo("TenHopdong", "Tên hợp đồng"))
            gridView1.FixedLineWidth = 0
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub LoadGRV(ByVal nhom As String)
        lst_PB_Nam_Con.Clear()
        For Each obj_con As KtDmBtPhanbo In lstobj_DM_BT_PB
            If (obj_con.Nhom = nhom) Then
                lst_PB_Nam_Con.Add(obj_con)
            End If
        Next
        gridControl1.DataSource = lst_PB_Nam_Con
        gridView1.RefreshData()
    End Sub

    Private Sub _GridView_FocusedRowChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles _GridView.FocusedRowChanged
        Try
            If (_GridView.RowCount <> 0) Then
                Dim gridbtpbtd As KtDmBtPhanbo = CType(_GridView.GetRow(_GridView.FocusedRowHandle), KtDmBtPhanbo)
                If gridbtpbtd Is Nothing Then
                    Return
                End If
                p_nhom = gridbtpbtd.Nhom
                LoadGRV(p_nhom)
                gridView1.RefreshData()
            End If
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub create()
        'Try
        Dim frm As frmKhaiBaoCacButToanPBTD_ChiTiet = CType(ObjectFactory.GetObject("frmKhaiBaoCacButToanPBTD_ChiTiet"), frmKhaiBaoCacButToanPBTD_ChiTiet)
        If frm.Show_Form(0, p_NAM, DataInputState.AddMode) Then
            Me.LoadGrv_cha()
        End If
        'Catch ex As Exception
        '    Message_Error(ex)
        'End Try
    End Sub

    Private Sub btnCreate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Try
            create()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub Edit()
        'Try
        If _GridView.RowCount <> 0 Then
            Dim frm As frmKhaiBaoCacButToanPBTD_ChiTiet = CType(ObjectFactory.GetObject("frmKhaiBaoCacButToanPBTD_ChiTiet"), frmKhaiBaoCacButToanPBTD_ChiTiet)
            If frm.Show_Form(p_nhom, p_NAM, DataInputState.EditMode) Then
                Me.LoadGrv_cha()
                Me.LoadGRV(p_nhom)
            End If
        Else
            Message_Warning("Không có bản ghi nào trong danh sách")
        End If
        'Catch ex As Exception
        '    Message_Error(ex)
        'End Try
    End Sub

    Private Sub btnModify_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModify.Click
        Try
            Edit()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub Delete()
        'Try
        If (_GridView.RowCount <> 0) Then
            If (MessageBox.Show(ConstantMsgs.MSG_CONFIRM_FOR_DELETE, "Confirmation", MessageBoxButtons.YesNo) <> DialogResult.Yes) Then Return
            _KtDmBtPhanboService.DeleteByNhom(p_nhom, Generals.DON_VI.Id)
            Me.LoadGrv_cha()
            If (_GridView.RowCount <> 0) Then
                Dim gridbtpbtd As KtDmBtPhanbo = CType(_GridView.GetRow(_GridView.FocusedRowHandle), KtDmBtPhanbo)
                p_nhom = gridbtpbtd.Nhom
                Me.LoadGRV(p_nhom)
            Else
                Me.LoadGRV(-1)
            End If
        Else
            Me.LoadGRV(-1)
            Message_Information("Không có bản ghi nào trong danh sách")
        End If
        'Catch ex As Exception
        '    Message_Error(ex)
        'End Try
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

    Private Function Check_input() As Boolean
        Return True
    End Function

    Private Sub frmKhaiBaoCacButToanPBTD_DanhSach_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Try
            Select Case e.KeyCode
                Case Keys.F3
                    create()
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

    Private Function grid_ColumnEdit() As RepositoryItemLookUpEdit
        Dim result As New RepositoryItemLookUpEdit()
        Dim dt As New DataTable()
        dt.Columns.Add("Text", GetType(String))
        dt.Columns.Add("Value", GetType(Decimal))
        Dim dr As DataRow

        dr = dt.NewRow()
        dr("Text") = "Nợ sang có"
        dr("Value") = 1
        dt.Rows.Add(dr)

        dr = dt.NewRow()
        dr("Text") = "Có sang nợ"
        dr("Value") = 2
        dt.Rows.Add(dr)

        result.DisplayMember = "Text"
        result.ValueMember = "Value"
        result.DataSource = dt

        Return result
    End Function
End Class