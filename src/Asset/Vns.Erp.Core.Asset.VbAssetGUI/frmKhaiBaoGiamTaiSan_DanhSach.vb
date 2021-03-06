Imports DevExpress.XtraEditors.Repository

Imports Vns.Erp.Core.Admin.Domain
Imports Vns.Erp.Core.Accounting.Domain
Imports Vns.Erp.Core.Admin.Service.Interface
Imports Vns.Erp.Core.Accounting.Service.Interface
Imports Vns.Erp.Core.Common.Controls.PagerControl

Imports Vns.Erp.Core.Asset.Domain
Imports Vns.Erp.Core.Asset.Service.Interface

Public Class frmKhaiBaoGiamTaiSan_DanhSach

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

    Private _CtTscdService As ICtTscdService
    Public Property CtTscdService As ICtTscdService
        Get
            Return _CtTscdService
        End Get
        Set(ByVal value As ICtTscdService)
            _CtTscdService = value
        End Set
    End Property

    Private _CtHService As ICtHService
    Public Property CtHService As ICtHService
        Get
            Return _CtHService
        End Get
        Set(ByVal value As ICtHService)
            _CtHService = value
        End Set
    End Property
#End Region

#Region "Variables"

    Private obj_DM_TSCD As DmTscd
    Private p_MA_LOAI_CT As String
#End Region

#Region "Private functions"

    Public Sub New()
        InitializeComponent()
        TNCommon.setIconControl(Me)
    End Sub

    Private Sub LoadGRV()
        Dim lstobj_DM_TSCD As List(Of DmTscd) = New List(Of DmTscd)
        lstobj_DM_TSCD = New List(Of DmTscd)
        lstobj_DM_TSCD.AddRange(_DmTscdService.GetObjectAllByDonviID(PagerControl1.PageIndex, PagerControl1.PageSize, Generals.DON_VI.Id, PagerControl1.TotalResult))

        grc_TSCD.DataSource = lstobj_DM_TSCD

        Dim para_str As String = Me.AccessibleDescription
        Dim lst_para As List(Of ParamInfo) = DataMining.GetParams(para_str)
        If lst_para.Count > 0 Then
            'obj_loaichungtu.TEN_LOAI_CT = lst_para(1).PARAMVALUE
            p_MA_LOAI_CT = lst_para(0).PARAMVALUE
        End If
        PagerControl1.RefreshPage()
    End Sub

    Private Sub Create()
        'Try
        If (grv_TSCD.RowCount <> 0) Then
            obj_DM_TSCD = CType(grv_TSCD.GetRow(grv_TSCD.FocusedRowHandle), DmTscd)
            If (obj_DM_TSCD.GiamTscd <> 1) Then
                Dim i As Integer = grv_TSCD.FocusedRowHandle()
                Dim frm As frmKhaiBaoGiamTaiSan_ChiTiet = CType(ObjectFactory.GetObject("frmKhaiBaoGiamTaiSan_ChiTiet"), frmKhaiBaoGiamTaiSan_ChiTiet)
                If frm.Show_Form(obj_DM_TSCD.Id, DataInputState.AddMode, p_MA_LOAI_CT) Then
                    Me.LoadGRV()
                    grv_TSCD.RefreshData()
                    grv_TSCD.FocusedRowHandle = i
                    btnDelete.Enabled = True
                    btnGiam.Enabled = False
                    btnModify.Enabled = True
                End If
            Else
                Message_Information("Tài sản này đã được khai báo giảm")
            End If
        End If

        'Catch ex As Exception
        '    Message_Error(ex)
        'End Try
    End Sub

    Private Sub Edit()
        'Try
        If (grv_TSCD.RowCount <> 0) Then
            obj_DM_TSCD = CType(grv_TSCD.GetRow(grv_TSCD.FocusedRowHandle), DmTscd)
            If (obj_DM_TSCD.GiamTscd = 1) Then
                Dim frm As frmKhaiBaoGiamTaiSan_ChiTiet = CType(ObjectFactory.GetObject("frmKhaiBaoGiamTaiSan_ChiTiet"), frmKhaiBaoGiamTaiSan_ChiTiet)
                Dim i As Integer = grv_TSCD.FocusedRowHandle()
                If (frm.Show_Form(obj_DM_TSCD.Id, DataInputState.EditMode, p_MA_LOAI_CT)) Then
                    Me.LoadGRV()
                    grv_TSCD.RefreshData()
                    grv_TSCD.FocusedRowHandle = i
                End If
            Else
                Message_Information("Tài sản cố định đang ở trạng thái tăng")
            End If
        Else
            Message_Information("Không có bản ghi nào")
        End If
        'Catch ex As Exception
        '    Message_Error(ex)
        'End Try
    End Sub

    Private Sub Delete()
        'Try
        If (grv_TSCD.RowCount <> 0) Then
            obj_DM_TSCD = CType(grv_TSCD.GetRow(grv_TSCD.FocusedRowHandle), DmTscd)
            Dim i As Integer = grv_TSCD.FocusedRowHandle()
            If (obj_DM_TSCD.GiamTscd = 1) Then
                If (MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes) Then
                    'Update DM_TSCS(GIAM_TSCD=0)
                    
                    Dim tmpDM As DmTscd = _DmTscdService.GetById(obj_DM_TSCD.Id)
                    tmpDM.GiamTscd = 0
                    tmpDM.NgayGiam = Nothing
                    _DmTscdService.SaveOrUpdate(tmpDM)

                    Dim obj_del_ct_TSCD As CtTscd = _CtTscdService.GetByTRANG_THAI(obj_DM_TSCD.Id, 4)

                    'Xoa CT_TSCD
                    If (obj_del_ct_TSCD IsNot Nothing) Then
                        _CtTscdService.DeleteById(obj_del_ct_TSCD.Id)
                    End If

                    'Xoa CTH, CTD
                    If Not (obj_del_ct_TSCD.CthId = Null.NullGuid) Then
                        Dim tmpCth As CtH = New CtH()
                        tmpCth.Id = obj_del_ct_TSCD.CthId
                        _CtHService.DeleteChungTu(tmpCth, Nothing)
                    End If

                    Me.LoadGRV()
                    grv_TSCD.FocusedRowHandle = i

                    btnDelete.Enabled = False
                    btnGiam.Enabled = True
                    btnModify.Enabled = False
                End If
            Else
                Message_Warning("Tài sản này đang ở trạng thái tăng")
            End If

        Else
            Message_Warning("Không có bản ghi nào được chọn!")
        End If
        'Catch ex As Exception
        '    Message_Error(ex)
        'End Try
    End Sub

    Private Function TANGGIAM_ColumnEdit() As RepositoryItemLookUpEdit
        Dim result As New RepositoryItemLookUpEdit()
        Dim dt As New DataTable()
        dt.Columns.Add("Text", GetType(String))
        dt.Columns.Add("Value", GetType(Decimal))
        Dim dr As DataRow

        dr = dt.NewRow()
        dr("Text") = "Giảm"
        dr("Value") = 1
        dt.Rows.Add(dr)

        dr = dt.NewRow()
        dr("Text") = "Tăng"
        dr("Value") = 0
        dt.Rows.Add(dr)

        result.DisplayMember = "Text"
        result.ValueMember = "Value"
        result.DataSource = dt

        Return result
    End Function

#End Region

#Region "Events"

    Private Sub frmKhaiBaoGiamTaiSan_DanhSach_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            LoadGRV()
            PagerControl1.display = New DisplayResult(AddressOf LoadGRV)
            'PagerControl1.display()
            grv_TSCD.Columns("GiamTscd").ColumnEdit = TANGGIAM_ColumnEdit()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub grv_TSCD_FocusedRowChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles grv_TSCD.FocusedRowChanged
        Try
            obj_DM_TSCD = CType(grv_TSCD.GetRow(grv_TSCD.FocusedRowHandle), DmTscd)
            If (obj_DM_TSCD.GiamTscd = 1) Then
                btnGiam.Enabled = False
                btnDelete.Enabled = True
                btnModify.Enabled = True
            Else
                btnGiam.Enabled = True
                btnDelete.Enabled = False
                btnModify.Enabled = False
            End If
        Catch ex As Exception
            Message_Error(ex)
        End Try

    End Sub

    Private Sub btnCreate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGiam.Click
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

    Private Sub frmKhaiBaoGiamTaiSan_DanhSach_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
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

#End Region

End Class