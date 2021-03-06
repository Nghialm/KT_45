Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.Utils
Imports System.Reflection
Imports Vns.Erp.Core.Accounting.Domain
Imports Vns.Erp.Core.Accounting.Domain.Extend
Imports Vns.Erp.Core.Accounting.Service.Interface
Imports Vns.Erp.Core.Admin.Domain
Imports Vns.Erp.Core.Admin.Service.Interface

Public Class frmSoDuTaiKhoan2_DanhSach
#Region "Property"
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

#Region "Variables and Messages"
    Private CTHID As Guid
    Private obj_ct_h As CtH
    Public obj_loaichungtu As HtLoaichungtu = New HtLoaichungtu()
    Private ds As IList(Of CtD) = New List(Of CtD)
    Private dsSoDu As IList(Of SoDuTaiKhoanInfo) = New List(Of SoDuTaiKhoanInfo)
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
        'Generals.Nam_Ke_Toan()
        'Dim lstobj_ct_h_nx As List(Of CT_H_NxInfo) = _
        ds = _CtHService.GetAllSoDu(Generals.DON_VI.Id, Generals.Nam_Ke_Toan - 1)
        dsSoDu = New List(Of SoDuTaiKhoanInfo)()
        For Each tmp As CtD In ds
            dsSoDu.Add(New SoDuTaiKhoanInfo(tmp.ObjCtH, tmp))
        Next
        '_GridControl.DataSource = lstobj_ct_h_nx
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
                Dim cth As New CtH
                cth.Id = CTHID
                _CtHService.DeleteChungTu(cth, Nothing)
                Me.LoadDanhSach()
            End If
        Else
            MessageBox.Show("Bạn chưa chọn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
        End If
    End Sub

    Private Sub grv_focus()
        'Dim dv As CtD = New CtD
        'dv = CType(_GridView.DataSource, CtD)

        'Dim objCTH As CtH = New CtH
        'If dv.Count <> 0 Then
        '    For i As Integer = 0 To dv.Count - 1
        '        Dim drw As DataRowView = dv(i)
        '        Object_GetDataRawView(objCTH, drw)
        '        If objCTH.Id = obj_ct_h.Id Then
        '            _GridView.FocusedRowHandle = i
        '        End If
        '    Next
        'End If
    End Sub

    Private Sub Edit()
        'Try
        If (_GridView.RowCount <> 0) Then
            If (GetRowSelect()) Then
                Dim f As frmSoDuTaiKhoan2_ChiTiet = CType(ObjectFactory.GetObject("frmSoDuTaiKhoan2_ChiTiet"), frmSoDuTaiKhoan2_ChiTiet)
                obj_ct_h = f.Show_Form(CTHID, obj_loaichungtu.MaLoaiCt, Nothing, Nothing, DataInputState.EditMode)
                If obj_ct_h IsNot Nothing Then
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
        Dim f As frmSoDuTaiKhoan2_ChiTiet = CType(ObjectFactory.GetObject("frmSoDuTaiKhoan2_ChiTiet"), frmSoDuTaiKhoan2_ChiTiet)
        obj_ct_h = f.Show_Form(Nothing, obj_loaichungtu.MaLoaiCt, Nothing, Nothing, DataInputState.AddMode)
        If obj_ct_h IsNot Nothing Then
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
                Dim drvcth As SoDuTaiKhoanInfo = CType(_GridView.GetRow(_GridView.FocusedRowHandle), SoDuTaiKhoanInfo)
                CTHID = drvcth.CthId
                Return True
            End If

        End If
        Return False
    End Function
#End Region

#Region "Events"

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

    Private Sub btnDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDel.Click
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

    Private Sub _GridView_FocusedRowChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles _GridView.FocusedRowChanged
        Try
            If (_GridView.FocusedRowHandle < 0) Then Return

            Dim drvcth As SoDuTaiKhoanInfo = CType(_GridView.GetRow(_GridView.FocusedRowHandle), SoDuTaiKhoanInfo)
            'Dim gridcth As CtH = New CtH()

            If _GridView.RowCount <> 0 Then
                'Object_GetDataRawView(gridcth, drvcth)
                If (Not drvcth Is Nothing) Then
                    CTHID = drvcth.CtHId
                End If

            End If
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub frmSoDuTaiKhoan2_DanhSach_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            _GridView.Columns("NgayCt").DisplayFormat.FormatType = FormatType.DateTime
            _GridView.Columns("NgayCt").DisplayFormat.FormatString = "{0:yyyy}"
            LoadDanhSach()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub frmSoDuTaiKhoan2_DanhSach_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
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
                Case Keys.F8
                    Delete()
                    Exit Select
            End Select
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub
#End Region

End Class