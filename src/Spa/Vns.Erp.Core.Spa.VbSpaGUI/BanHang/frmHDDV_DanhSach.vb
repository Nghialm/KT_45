Imports Vns.Erp.Core.Spa.Domain
Imports Vns.Erp.Core.Spa.Service
Imports Vns.Erp.Core.Spa.Service.Interface
Imports Vns.Erp.Core.Admin.Service.Interface
Imports Vns.Erp.Core.Admin.Domain
Imports Vns.Erp.Core
Imports Vns.Erp.Core.Accounting.Domain

Public Class frmHDDV_DanhSach

#Region "Properties"

    Private _HtLoaichungtuService As IHtLoaichungtuService
    Public Property HtLoaichungtuService As IHtLoaichungtuService
        Get
            Return _HtLoaichungtuService
        End Get
        Set(ByVal value As IHtLoaichungtuService)
            _HtLoaichungtuService = value
        End Set
    End Property

    Private _ctHHddvService As ICtHHddvService
    Public Property CtHHddvService() As ICtHHddvService
        Get
            Return _ctHHddvService
        End Get
        Set(ByVal value As ICtHHddvService)
            _ctHHddvService = value
        End Set
    End Property


    Private _ctDHddvServiece As ICtDHddvService
    Public Property CtDHddvService() As ICtDHddvService
        Get
            Return _ctDHddvServiece
        End Get
        Set(ByVal value As ICtDHddvService)
            _ctDHddvServiece = value
        End Set
    End Property

#End Region

#Region "Constructors"
    Public Sub New()
        InitializeComponent()
        TNCommon.setIconControl(Me)
    End Sub
#End Region

#Region "Variables"
    Private CTHID As Guid
    Private ListCtH As IList(Of CtHHddv) = New List(Of CtHHddv)
    Private obj_ct_h As New CtHHddv
    Private FormID As String
    Public obj_loaichungtu As New HtLoaichungtu
#End Region

#Region "Private methods and procedures"

    Private Sub LoadDanhSach()

        'truyen para frm
        Dim para_str As String = Me.AccessibleDescription
        Dim lst_para As List(Of ParamInfo) = DataMining.GetParams(para_str)
        If lst_para.Count > 0 Then
            'obj_loaichungtu.TEN_LOAI_CT = lst_para(1).PARAMVALUE
            obj_loaichungtu.MaLoaiCt = lst_para(0).PARAMVALUE
        End If

        Dim SO_CT_HIENTHI As Integer
        Dim objHTCT As HtLoaichungtu = _HtLoaichungtuService.GetByMA_LOAI_CT(obj_loaichungtu.MaLoaiCt, Generals.DON_VI.Id)
        If objHTCT IsNot Nothing Then
            obj_loaichungtu.TenLoaiCt = objHTCT.TenLoaiCt
            If objHTCT.SoCtHienthi = 0 Then
                SO_CT_HIENTHI = Integer.MinValue
            Else
                SO_CT_HIENTHI = objHTCT.SoCtHienthi
            End If
        End If

        Me.Text = obj_loaichungtu.TenLoaiCt
        Dim lstobj_ct_h_temp As IList(Of CtHHddv) = New List(Of CtHHddv)
        lstobj_ct_h_temp = CtHHddvService.GetByLoaiChungTu(Generals.DON_VI.Id, obj_loaichungtu.MaLoaiCt, SO_CT_HIENTHI)
        'lstobj_ct_h_temp = _CtHService.GetAll()
        ListCtH = lstobj_ct_h_temp

        grcDanhSach.DataSource = ListCtH
        'Dim sotien As Decimal = 0

        'For Each ctHInfo As CtH In ListCtH
        '    sotien += ctHInfo.SoTien
        'Next
        If grvDanhSach.RowCount <> 0 Then
            btnDelete.Enabled = True
            btnModify.Enabled = True
        Else
            btnDelete.Enabled = False
            btnModify.Enabled = False
        End If
        'LoadGridConfig()
    End Sub

    Private Sub BindDataToCombo()
        Dim dt As DataTable = New DataTable
        dt.Columns.Add("ID", GetType(Integer))
        dt.Columns.Add("TEN", GetType(String))

        dt.Rows.Add(1, "Dịch vụ")
        dt.Rows.Add(2, "Bán hàng")

        cboLoaiNghiepVu.DataSource = dt
        cboLoaiNghiepVu.ValueMember = "ID"
        cboLoaiNghiepVu.DisplayMember = "TEN"
    End Sub

    Private Sub LoadCtd(ByVal ID As Guid)
        BindDataToCombo()
        Dim lstobj_ct_d As List(Of CtDHddv) = _ctDHddvServiece.GetCtdBycth(ID)
        grcChiTiet.DataSource = lstobj_ct_d
    End Sub

    Private Sub Create()
        Dim f As frmHDDV_ChiTiet = CType(ObjectFactory.GetObject("frmHDDV_ChiTiet"), frmHDDV_ChiTiet)
        'Dim f As New frmCT_H_ChiTiet

        Dim lstCTHG As List(Of Extend.CT_H_GInfo) = ConvertLstObjCtHtoCtHG(ListCtH)
        obj_ct_h = f.Show_Form(Nothing, obj_loaichungtu.MaLoaiCt, obj_loaichungtu.TenLoaiCt, lstCTHG, DataInputState.AddMode)
        Me.LoadDanhSach()
        If grvDanhSach.RowCount > 0 And obj_ct_h IsNot Nothing Then
            grv_focus()
            'Lay lai CTH_ID
            Dim objCth As CtHHddv = CType(grvDanhSach.GetRow(grvDanhSach.FocusedRowHandle), CtHHddv)
            Me.LoadCtd(objCth.Id)
        End If
    End Sub

    Private Sub Edit()
        If grvDanhSach.RowCount = 0 Then
            Message_Warning("Không có bản ghi nào được lựa chọn")
            Return
        End If

        CTHID = CType(grvDanhSach.GetRow(grvDanhSach.FocusedRowHandle), CtHHddv).Id
        'Try
        'Dim f As New frmCT_H_ChiTiet
        Dim f As frmHDDV_ChiTiet = CType(ObjectFactory.GetObject("frmHDDV_ChiTiet"), frmHDDV_ChiTiet)

        Dim lstCTHG As List(Of Extend.CT_H_GInfo) = ConvertLstObjCtHtoCtHG(ListCtH)
        obj_ct_h = f.Show_Form(CTHID, obj_loaichungtu.MaLoaiCt, obj_loaichungtu.TenLoaiCt, _
                                lstCTHG, DataInputState.EditMode)

        Me.LoadDanhSach()
        If grvDanhSach.RowCount > 0 And obj_ct_h IsNot Nothing Then
            grv_focus()
            'Lấy lại CT_H_ID
            Dim objCth As CtHHddv = CType(grvDanhSach.GetRow(grvDanhSach.FocusedRowHandle), CtHHddv)
            Me.LoadCtd(objCth.Id)
        End If
    End Sub

    Private Sub Delete()
        If grvDanhSach.RowCount = 0 Then
            Message_Warning("Không có bản ghi nào được lựa chọn")
            Return
        End If

        If (Message_Confirm(ConstantMsgs.MSG_CONFIRM_FOR_DELETE)) Then
            Dim objCtH As CtHHddv = CType(grvDanhSach.GetRow(grvDanhSach.FocusedRowHandle), CtHHddv)

            _ctHHddvService.Delete(objCtH)
            grvDanhSach.DeleteSelectedRows()
            grvDanhSach.RefreshData()
        End If
    End Sub

    Private Sub grv_focus()
        Dim lst As List(Of CtHHddv) = New List(Of CtHHddv)
        lst = grvDanhSach.DataSource
        For i As Integer = 0 To grvDanhSach.RowCount - 1
            If (lst(i).Id = obj_ct_h.Id) Then
                grvDanhSach.FocusedRowHandle = i
            End If
        Next
    End Sub

#End Region

#Region "Event handles"

    Private Sub frmHDDV_DanhSach_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            LoadDanhSach()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub grvDanhSach_FocusedRowChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles grvDanhSach.FocusedRowChanged
        Try
            If grvDanhSach.RowCount > 0 Then
                Dim cthInfo As CtHHddv = CType(grvDanhSach.GetRow(grvDanhSach.FocusedRowHandle), CtHHddv)

                'Doan nay em can lay cai id cua no de em get ctd theo cth id
                If cthInfo Is Nothing OrElse String.IsNullOrEmpty(cthInfo.Id.ToString) = True Then

                    ' Reset datasource for detail gridview
                    grcChiTiet.DataSource = Nothing

                    btnModify.Enabled = False

                    '' Set focus to filter row
                    'If e.FocusedRowHandle = DevExpress.XtraGrid.GridControl.AutoFilterRowHandle Then
                    '    _GridView.FocusedColumn = _GridView.VisibleColumns(0)
                    'End If

                    Return
                End If

                btnModify.Enabled = True

                CTHID = cthInfo.Id

                LoadCtd(CTHID)

            Else
                ' Reset datasource for detail gridview
                grcChiTiet.DataSource = Nothing

                ' Focus to button
                btnAdd.Focus()

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

    Private Sub frmCT_H_DanhSach_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles MyBase.KeyDown
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

#End Region

#Region "Commons"

    Function ConvertLstObjCtHtoCtHG(ByVal lstObjCtH As List(Of CtHHddv)) As List(Of Extend.CT_H_GInfo)
        Try
            Dim lstobjCTHG As List(Of Extend.CT_H_GInfo) = New List(Of Extend.CT_H_GInfo)
            Dim objCTHG As Extend.CT_H_GInfo
            For i As Integer = 0 To lstObjCtH.Count - 1
                objCTHG = New Extend.CT_H_GInfo
                objCTHG.Id = lstObjCtH(i).Id
                objCTHG.CtSo = lstObjCtH(i).CtSo
                objCTHG.MaLoaiCt = lstObjCtH(i).MaLoaiCt
                objCTHG.NgayCt = lstObjCtH(i).NgayCt
                objCTHG.NgayGhi = lstObjCtH(i).NgayGhi

                lstobjCTHG.Add(objCTHG)
            Next
            If lstobjCTHG.Count > 0 Then
                Return lstobjCTHG
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
#End Region

End Class