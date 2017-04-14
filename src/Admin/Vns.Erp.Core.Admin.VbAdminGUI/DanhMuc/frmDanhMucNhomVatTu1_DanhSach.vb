'*************************************************************************
'	Modifile:	8:9:2011   17:10
'	File base:	frmDanhMucNhomVatTu1_DanhSach
'	File ext:	vb
'	By:			Pham Xuan Duy
'	Email:		duypx@trinam.com.vn
'	Mobile:		01239 589 689
'	Company:	TRI NAM TDI., JSC 2009 | All rights reserved 
'	Purpose:	
'*************************************************************************
Imports System.Collections.Generic
Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Grid
Imports Vns.Erp.Core.Admin.Domain
Imports Vns.Erp.Core.Admin.Service.Interface


Public Class frmDanhMucNhomVatTu1_DanhSach
    Inherits FrmBaseDmDanhSach

#Region "Variable"

    'Tuyen sua 28-07-2011
    Private dmnvt1 As String
    Private lstobj_dm_nvt1 As List(Of DmNhomvattu1) = New List(Of DmNhomvattu1)

    'Bien tim kiem
    Private filter As FilterGridview

#End Region

#Region "Functions"
    Dim _DmNhomvattu1Service As IDmNhomvattu1Service
    Public Property DmNhomvattu1Service() As IDmNhomvattu1Service
        Get
            Return _DmNhomvattu1Service
        End Get
        Set(ByVal value As IDmNhomvattu1Service)
            _DmNhomvattu1Service = value
        End Set
    End Property

    Dim _FormChiTiet As frmDanhMucNhomVatTu1_ChiTiet
    Public Property FormChiTiet() As frmDanhMucNhomVatTu1_ChiTiet
        Get
            Return _FormChiTiet
        End Get
        Set(ByVal value As frmDanhMucNhomVatTu1_ChiTiet)
            _FormChiTiet = value
        End Set
    End Property
    Public Sub New()
        InitializeComponent()
        TNCommon.setIconControl(Me)
        filter = New FilterGridview(_GridView)
    End Sub

    Private Sub Load_Grid()
        Dim lstobj_dm_NhomVT1 As IList(Of DmNhomvattu1) = DmNhomvattu1Service.GetObjectAllByDonviID(Generals.DON_VI.Id)
        _GridControl.DataSource = lstobj_dm_NhomVT1
        _GridView.Columns("CoSuDung").ColumnEdit = TNCommon.COSUDUNG_ColumnEdit()
        _GridView.Columns("ChoPhepSua").ColumnEdit = TNCommon.COSUDUNG_ColumnEdit()
    End Sub

    'Khoi dong control filter
    Private Sub ActiveFilter(ByVal grv As GridView)
        If Not chkColum.EditValue.ToString.Equals(String.Empty) Then
            filter.ActiveColumn = chkColum.EditValue.ToString()
            filter.ActiveFilter = txtKeyword.Text
        Else
            grv.ClearColumnsFilter()
        End If
    End Sub

    'Tao danh sach cac cot trong db
    Private Sub LoadListColum()
        'Tao bien collection tap hop cac item
        Dim coll As CheckedListBoxItemCollection = chkColum.Properties.Items

        'Mang luu ten cac cot trong db
        Dim ar() As ColumnReportInfo = New ColumnReportInfo() {New ColumnReportInfo("MaNhomVt1", "Mã nhóm vật tư"), _
                                          New ColumnReportInfo("TenNhomVt1", "Tên nhóm vật tư"), _
                                          New ColumnReportInfo("ChoPhepSua", "Cho phép sửa"), _
                                          New ColumnReportInfo("CoSuDung", "Có sử dụng"), _
                                          New ColumnReportInfo("LoaiNhom", "Loại nhóm"), _
                                          New ColumnReportInfo("MaDonvi", "Mã đơn vị"), _
                                          New ColumnReportInfo("NguoiTao", "Người tạo"), _
                                          New ColumnReportInfo("NgayTao", "Ngày tạo"), _
                                          New ColumnReportInfo("NguoiSua", "Người sửa"), _
                                          New ColumnReportInfo("NgaySua", "Ngày sửa")}

        Dim lst As List(Of ColumnReportInfo) = New List(Of ColumnReportInfo)
        For Each item As ColumnReportInfo In ar
            lst.Add(item)
        Next
        chkColum.Properties.DataSource = lst
        chkColum.Properties.DisplayMember = "TenHienthi"
        chkColum.Properties.ValueMember = "CotHienthi"
    End Sub

    Private Function GetRowSelect() As Boolean
        Dim selrow As Integer = 0
        If (_GridView.GetSelectedRows().Length > 0) Then
            If (_GridView.RowCount <> 0) Then
                Dim gridnvt1 As DmNhomvattu1 = CType(_GridView.GetRow(_GridView.GetSelectedRows(0)), DmNhomvattu1)
                dmnvt1 = gridnvt1.Id.ToString
                Return True
            End If
        End If
        Return False
    End Function

    Private Sub themmoi()
        Dim f As frmDanhMucNhomVatTu1_ChiTiet = FormChiTiet
        If f.Show_Form(Nothing, DataInputState.AddMode) Then
            Me.Load_Grid()
        End If
    End Sub

    Private Sub sua()
        If _GridView.FocusedRowHandle < 0 Then
            Message_Warning("Chưa chọn bản ghi")
            Return
        End If
        If (_GridView.RowCount <> 0) Then
            If (GetRowSelect()) Then
                Dim f As frmDanhMucNhomVatTu1_ChiTiet = FormChiTiet
                If f.Show_Form(dmnvt1, DataInputState.EditMode) Then
                    Me.Load_Grid()
                End If
            End If
        Else
            MessageBox.Show("Bạn chưa chưa chọn bản ghi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
        End If
    End Sub

    Private Sub delete()
        If _GridView.FocusedRowHandle < 0 Then
            Message_Warning("Chưa chọn bản ghi")
            Return
        End If
        If (GetRowSelect()) Then
            If Message_Confirm("Bạn có muốn xóa bản ghi này?") Then
                DmNhomvattu1Service.DeleteById(New Guid(dmnvt1))
                Me.Load_Grid()
            End If
        End If
    End Sub

#End Region

#Region "Events"

    Private Sub frmDanhMucNhomVatTu1_DanhSach_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Load_Grid()
            LoadListColum()
            For i As Integer = 0 To _GridView.Columns.Count - 1
                _GridView.Columns(i).OptionsColumn.ReadOnly = True
            Next
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub btnCreate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCreate.Click
        Try
            themmoi()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub btnModify_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModify.Click
        Try
            sua()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Try
            delete()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub _GridView_FocusedRowChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs)

    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Try
            Me.Close()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub frmDanhMucNhomVatTu1_DanhSach_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                If (_GridView.IsLastRow) Then
                    Dim i As Integer = _GridView.Columns.Count
                    Dim j As Integer = -1
                    While i >= 0
                        Try
                            If _GridView.GetVisibleColumn(i).Visible Then
                                j = _GridView.GetVisibleColumn(i).AbsoluteIndex
                                If _GridView.FocusedColumn.AbsoluteIndex = j And Not j = -1 Then
                                    lstobj_dm_nvt1.Add(New DmNhomvattu1)
                                    _GridView.RefreshData()
                                End If
                                Exit While
                            End If
                        Catch ex As Exception
                        End Try
                        i = i - 1
                    End While
                End If
                SendKeys.Send("{TAB}")
            End If
            Select Case e.KeyCode
                Case Keys.Escape
                    Me.Close()
                    Exit Select

                Case Keys.F3
                    themmoi()
                    Exit Select
                Case Keys.F4
                    sua()
                    Exit Select
                Case Keys.F8
                    delete()
                    Exit Select
            End Select
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub txtKeyword_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtKeyword.EditValueChanged
        Try
            ActiveFilter(_GridView)
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub chkColum_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkColum.EditValueChanged
        Try
            ActiveFilter(_GridView)
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

#End Region

End Class


