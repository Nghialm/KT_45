Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.Utils
Imports System.Reflection
Imports Vns.Erp.Core.Accounting.Domain
Imports Vns.Erp.Core.Admin.Domain
Imports Vns.Erp.Core.Accounting.Service.Interface
Imports Vns.Erp.Core.Admin.Service.Interface
Imports Vns.Erp.Core.Accounting.Domain.Extend
Imports Vns.Erp.Core.Common.Controls.PagerControl

Public Class frmSoDuTaiKhoan_Kho2_DanhSach
#Region "Property"
    Private _CtHNxService As ICtHNxService
    Public Property CtHNxService As ICtHNxService
        Get
            Return _CtHNxService
        End Get
        Set(ByVal value As ICtHNxService)
            _CtHNxService = value
        End Set
    End Property
    Private _HtLoaichungtuService As IHtLoaichungtuService
    Public Property HtLoaichungtuService As IHtLoaichungtuService
        Get
            Return _HtLoaichungtuService
        End Get
        Set(ByVal value As IHtLoaichungtuService)
            _HtLoaichungtuService = value
        End Set
    End Property
    Private _DmKhoService As IDmKhoService
    Public Property DmKhoService As IDmKhoService
        Get
            Return _DmKhoService
        End Get
        Set(ByVal value As IDmKhoService)
            _DmKhoService = value
        End Set
    End Property

#End Region

#Region "Variables and Messages"
    Private CTHID_NX As Guid
    Private obj_ct_h_nx As CtHNx
    Public obj_loaichungtu As HtLoaichungtu = New HtLoaichungtu()
    Private lstKho As IList(Of DmKho) = New List(Of DmKho)
#End Region

#Region "Load Form"
    Public Sub New()
        InitializeComponent()
        TNCommon.setIconControl(Me)
    End Sub

#End Region

#Region "Private Function"
    Private Sub LoadDanhSach()

        Dim para_str As String = Me.AccessibleDescription
        Dim lst_para As List(Of ParamInfo) = DataMining.GetParams(para_str)
        If lst_para.Count > 0 Then
            'obj_loaichungtu.TEN_LOAI_CT = lst_para(1).PARAMVALUE
            obj_loaichungtu.MaLoaiCt = lst_para(0).PARAMVALUE
        End If

        Dim ds As List(Of CtDNx) = New List(Of CtDNx)
        ds.AddRange(_CtHNxService.GetAllSoDu(CtlPagerControl.PageIndex, Me.CtlPagerControl.PageSize, Generals.DON_VI.Id, Generals.Nam_Ke_Toan - 1, CtlPagerControl.TotalResult))
        Dim dsSoDu As IList(Of SoDuKhoInfo) = New List(Of SoDuKhoInfo)()
        For Each tmp As CtDNx In ds
            dsSoDu.Add(New SoDuKhoInfo(tmp.ObjCtHNx, tmp, GetDmKho(tmp.KhoNhapId)))
        Next
        _GridControl.DataSource = dsSoDu

        If _GridView.RowCount <> 0 Then

            btnDel.Enabled = True
        Else
            btnDel.Enabled = False
        End If

    End Sub

    Private Sub Delete()
        If (_GridView.RowCount <> 0) Then
            If (GetRowSelect()) Then
                If (MessageBox.Show("Bạn muốn xóa hay không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> DialogResult.Yes) Then Return
                Dim obj As New CtHNx
                obj.Id = CTHID_NX
                _CtHNxService.DeleteChungTu(obj)
                Me.LoadDanhSach()
            End If
        Else
            MessageBox.Show("Bạn chưa chọn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
        End If
    End Sub

    Private Sub grv_focus()
        'Dim lst As List(Of CT_H_NxInfo) = New List(Of CT_H_NxInfo)
        'lst = _GridView.DataSource
        'For i As Integer = 0 To _GridView.RowCount - 1
        '    If (lst(i).CTH_NX_ID = obj_ct_h_nx.CTH_NX_ID) Then
        '        _GridView.FocusedRowHandle = i
        '    End If
        'Next
        'Dim dv As CtDNx = New CtDNx
        'dv = CType(_GridView.DataSource, CtDNx)

        'Dim objCTHNX As CtHNx = New CtHNx()
        'If dv.Count <> 0 Then
        '    For i As Integer = 0 To dv.Count - 1
        '        Dim drw As DataRowView = dv(i)
        '        Object_GetDataRawView(objCTHNX, drw)
        '        If objCTHNX.Id = obj_ct_h_nx.Id Then
        '            _GridView.FocusedRowHandle = i
        '        End If
        '    Next
        'End If
    End Sub

    Private Sub Edit()
        'Try
        If (_GridView.RowCount <> 0) Then
            If (GetRowSelect()) Then
                Dim f As frmSoDuTaiKhoan_Kho2_ChiTiet = CType(ObjectFactory.GetObject("frmSoDuTaiKhoan_Kho2_ChiTiet"), frmSoDuTaiKhoan_Kho2_ChiTiet)
                obj_ct_h_nx = f.Show_Form(CTHID_NX, obj_loaichungtu.MaLoaiCt, obj_loaichungtu.TenLoaiCt, Nothing, DataInputState.EditMode)
                If obj_ct_h_nx IsNot Nothing Then
                    LoadDanhSach()
                    grv_focus()
                End If
            End If
        Else
            MessageBox.Show("Bạn chưa chọn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
        End If
        'Catch ex As Exception
        '    Message_Error(ex)
        'End Try
    End Sub

    Private Sub Create()
        'Try
        Dim f As frmSoDuTaiKhoan_Kho2_ChiTiet = CType(ObjectFactory.GetObject("frmSoDuTaiKhoan_Kho2_ChiTiet"), frmSoDuTaiKhoan_Kho2_ChiTiet)
        obj_ct_h_nx = f.Show_Form(Nothing, obj_loaichungtu.MaLoaiCt, obj_loaichungtu.TenLoaiCt, Nothing, DataInputState.AddMode)
        If obj_ct_h_nx IsNot Nothing Then
            LoadDanhSach()
            'grv_focus()
        End If
        'Catch ex As Exception
        '    Message_Error(ex)
        'End Try
    End Sub

    Private Function GetRowSelect() As Boolean
        Dim selrow As Integer = 0
        If (_GridView.GetSelectedRows().Length > 0) Then
            If (_GridView.RowCount <> 0) Then
                Dim drvcthnx As SoDuKhoInfo = CType(_GridView.GetRow(_GridView.FocusedRowHandle), SoDuKhoInfo)

                CTHID_NX = drvcthnx.CtHNxId
                Return True
            End If

        End If
        Return False
    End Function
#End Region

#Region "Events"

    Private Sub _GridView_FocusedRowChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles _GridView.FocusedRowChanged
        Try
            If (_GridView.FocusedRowHandle < 0) Then Return

            Dim drvcthnx As SoDuKhoInfo = CType(_GridView.GetRow(_GridView.FocusedRowHandle), SoDuKhoInfo)

            If _GridView.RowCount <> 0 Then
                CTHID_NX = drvcthnx.CtHNxId
            Else
            End If
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

    Private Sub btnMod_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMod.Click
        Try
            Edit()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub frmSoDuTaiKhoan_Kho2_DanhSach_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            lstKho = _DmKhoService.GetAllByDonviID(Generals.DON_VI.Id)
            _GridView.Columns("NgayCt").DisplayFormat.FormatType = FormatType.DateTime
            _GridView.Columns("NgayCt").DisplayFormat.FormatString = "{0:yyyy}"
            LoadDanhSach()
            CtlPagerControl.display = New DisplayResult(AddressOf LoadDanhSach)
            CtlPagerControl.RefreshPage()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub btnDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDel.Click
        Try
            Delete()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub frmSoDuTaiKhoan_Kho2_DanhSach_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Try
            Select Case e.KeyCode
                Case Keys.Escape
                    Me.Close()
                    Exit Select

                Case Keys.F3
                    Create()
                    Exit Select

                Case Keys.F4
                    If _GridView.RowCount <> 0 Then
                        Edit()
                    End If
                    Exit Select
            End Select
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub
#End Region

    Private Function GetDmKho(ByVal KhoId As Guid) As DmKho
        For Each tmp As DmKho In lstKho
            If (tmp.Id = KhoId) Then
                Return tmp
            End If
        Next
        Return Nothing
    End Function

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class