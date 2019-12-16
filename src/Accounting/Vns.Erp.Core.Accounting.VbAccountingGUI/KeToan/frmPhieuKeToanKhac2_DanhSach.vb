'Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.Utils

Imports Vns.Erp.Core.Accounting.Domain
Imports Vns.Erp.Core.Accounting.Service.Interface
Imports Vns.Erp.Core.Admin.Domain
Imports Vns.Erp.Core.Admin.Service.Interface
Imports Vns.Erp.Core.Common.Controls.PagerControl

Public Class frmPhieuKeToanKhac2_DanhSach

#Region "Property"
    Private _HtLoaichungtuService As IHtLoaichungtuService

    Public Property HtLoaichungtuService() As IHtLoaichungtuService
        Get
            Return _HtLoaichungtuService
        End Get
        Set(ByVal value As IHtLoaichungtuService)
            _HtLoaichungtuService = value
        End Set
    End Property
    Private _CtHService As ICtHService

    Public Property CtHService() As ICtHService
        Get
            Return _CtHService
        End Get
        Set(ByVal value As ICtHService)
            _CtHService = value
        End Set
    End Property
    Private _CtDService As ICtDService

    Public Property CtDService() As ICtDService
        Get
            Return _CtDService
        End Get
        Set(ByVal value As ICtDService)
            _CtDService = value
        End Set
    End Property
    Private _DmPtqtService As IDmPtqtService

    Public Property DmPtqtService() As IDmPtqtService
        Get
            Return _DmPtqtService
        End Get
        Set(ByVal value As IDmPtqtService)
            _DmPtqtService = value
        End Set
    End Property
    Private _DmVuviecService As IDmVuviecService

    Public Property DmVuviecService() As IDmVuviecService
        Get
            Return _DmVuviecService
        End Get
        Set(ByVal value As IDmVuviecService)
            _DmVuviecService = value
        End Set
    End Property
#End Region

    Private CTHID As Guid
    Private obj_ct_h As CtH
    Public obj_loaichungtu As HtLoaichungtu = New HtLoaichungtu()

    Public Sub New()
        InitializeComponent()
        TNCommon.setIconControl(Me)
    End Sub

    Private Sub frmPhieuKeToanKhac2_DanhSach_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Try
            _GridView.Columns("Ghi").Visible = Generals.Ts_PheDuyetChungTu
            _GridView.Columns("NgayCt").DisplayFormat.FormatType = FormatType.DateTime
            _GridView.Columns("NgayCt").DisplayFormat.FormatString = "{0:dd/MM/yyyy}"

            BindCombobox()
            LoadDanhSach()
            Me.CtlPagerControl.display = New DisplayResult(AddressOf LoadDanhSach)
            CtlPagerControl.RefreshPage()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Function lst(ByVal lst_cth As List(Of CtH)) As List(Of CtH)
        Dim lst_cth_temp As List(Of CtH) = New List(Of CtH)

        For Each obj As CtH In lst_cth
            If obj.PrefixCt IsNot Nothing Then
                obj.CtSo = obj.PrefixCt + obj.CtSo
            End If
            lst_cth_temp.Add(obj)
        Next
        Return lst_cth_temp
    End Function

    Dim lstobj_ct_h As List(Of CtH) = New List(Of CtH)
    Private Sub LoadDanhSach() 'Khong dat ten trung voi mot so ham hoac key dac biet
        'get ct_h by DonviID va obj_loaichungtu.LOAI_CT_ID (or ma loai ct), viet pkg
        'obj_loaichungtu.LOAI_CT_ID

        'truyen para frm
        Dim para_str As String = Me.AccessibleDescription
        Dim lst_para As List(Of ParamInfo) = DataMining.GetParams(para_str)
        If lst_para.Count > 0 Then
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
        Dim lstobj_ct_h_Temp As List(Of CtH) = New List(Of CtH)
        'CtlPagerControl.PageSize = SO_CT_HIENTHI
        lstobj_ct_h_Temp.AddRange(_CtHService.GetByLoaiChungTu(CtlPagerControl.PageIndex, CtlPagerControl.PageSize, Generals.DON_VI.Id, obj_loaichungtu.MaLoaiCt, CtlPagerControl.TotalResult))

        lstobj_ct_h = lst(lstobj_ct_h_Temp)
        _GridControl.DataSource = lstobj_ct_h
        If _GridView.RowCount <> 0 Then
            btnDelete.Enabled = True
            btnModify.Enabled = True
        Else
            btnDelete.Enabled = False
            btnModify.Enabled = False
        End If
    End Sub

    Private Sub _GridView_FocusedRowChanged(ByVal sender As Object, ByVal e As FocusedRowChangedEventArgs) Handles _GridView.FocusedRowChanged
        Try
            Dim gridcth As CtH = CType(_GridView.GetRow(_GridView.FocusedRowHandle), CtH)

            If _GridView.RowCount <> 0 Then
                CTHID = gridcth.Id
                LoadGRV(CTHID)
            Else
                gridControl1.DataSource = Nothing
            End If
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub BindCombobox()
        Dim lstPPQTNo As List(Of DmPtqt) = New List(Of DmPtqt)
        lstPPQTNo.AddRange(_DmPtqtService.GetAllByDonviID(Generals.DON_VI.Id))
        cboPTQTNo.DataSource = lstPPQTNo
        cboPTQTNo.DisplayMember = "KyHieu"
        cboPTQTNo.ValueMember = "Id"

        Dim lstPPQTCo As List(Of DmPtqt) = New List(Of DmPtqt)
        lstPPQTCo.AddRange(_DmPtqtService.GetAllByDonviID(Generals.DON_VI.Id))
        cboPTQTCo.DataSource = lstPPQTCo
        cboPTQTCo.DisplayMember = "KyHieu"
        cboPTQTCo.ValueMember = "Id"

        Dim lstVuViecNo As List(Of DmVuviec) = New List(Of DmVuviec)
        lstVuViecNo.AddRange(_DmVuviecService.GetAllByDonviID(Generals.DON_VI.Id))
        cboVuviecNo.DataSource = lstVuViecNo
        cboVuviecNo.DisplayMember = "TenVuviec"
        cboVuviecNo.ValueMember = "Id"

        Dim lstVuViecCo As List(Of DmVuviec) = New List(Of DmVuviec)
        lstVuViecCo.AddRange(_DmVuviecService.GetAllByDonviID(Generals.DON_VI.Id))
        cboVuviecCo.DataSource = lstVuViecCo
        cboVuviecCo.DisplayMember = "TenVuviec"
        cboVuviecCo.ValueMember = "Id"
    End Sub

    Private Sub LoadGRV(ByVal CTH_ID As Guid)
        Dim lstobj_ct_d As List(Of CtD) = New List(Of CtD)
        lstobj_ct_d.AddRange(_CtDService.GetByCtHandNghiepVu(CTH_ID, 0))
        gridControl1.DataSource = lstobj_ct_d
    End Sub

    Private Sub btnCreate_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAdd.Click
        Try
            Create()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub


    Private Sub Create()
        Dim f As frmPhieuKeToanKhac2_ChiTiet = CType(ObjectFactory.GetObject("frmPhieuKeToanKhac2_ChiTiet"), frmPhieuKeToanKhac2_ChiTiet)
        Dim lstCTHG As List(Of Extend.CT_H_GInfo) = Commons.ConvertLstObjCtHtoCtHG(lstobj_ct_h)
        obj_ct_h = f.Show_Form(Nothing, obj_loaichungtu.MaLoaiCt, obj_loaichungtu.TenLoaiCt, _
                                lstCTHG, DataInputState.AddMode)
        Me.LoadDanhSach()
        If _GridView.RowCount > 0 Then
            grv_focus()
            'Lay lai ID
            CTHID = CType(_GridView.GetRow(_GridView.FocusedRowHandle), CtH).Id
            Me.LoadGRV(CTHID)
        End If
    End Sub

    Private Sub btnModify_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnModify.Click
        Try
            Edit()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub Edit()
        If _GridView.RowCount > 0 Then
            CTHID = CType(_GridView.GetRow(_GridView.FocusedRowHandle), CtH).Id
            Dim f As frmPhieuKeToanKhac2_ChiTiet = CType(ObjectFactory.GetObject("frmPhieuKeToanKhac2_ChiTiet"), frmPhieuKeToanKhac2_ChiTiet)
            Dim lstCTHG As List(Of Extend.CT_H_GInfo) = Commons.ConvertLstObjCtHtoCtHG(lstobj_ct_h)
            obj_ct_h = f.Show_Form(CTHID, obj_loaichungtu.MaLoaiCt, obj_loaichungtu.TenLoaiCt, _
                                    lstCTHG, DataInputState.EditMode)
            Me.LoadDanhSach()
            If _GridView.RowCount > 0 Then
                grv_focus()
                'Lay lai ID
                CTHID = CType(_GridView.GetRow(_GridView.FocusedRowHandle), CtH).Id
                Me.LoadGRV(CTHID)
            End If
        End If
    End Sub

    Private Sub btnDelete_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnDelete.Click
        Try
            Delete()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub Delete()
        If (Message_Confirm(ConstantMsgs.MSG_CONFIRM_FOR_DELETE)) Then
            Dim obj As CtH = New CtH
            obj.Id = CTHID
            _CtHService.DeleteChungTuCTH(obj, Nothing, Nothing)
            _GridView.RefreshData()
            Me.LoadDanhSach()
            Me.LoadGRV(CTHID)
        End If
    End Sub

    Private Sub btnClose_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnClose.Click
        Try
            Me.Close()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub frmPhieuKeToanKhac2_DanhSach_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles MyBase.KeyDown
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

    Private Sub grv_focus()
        Dim lst As List(Of CtH) = New List(Of CtH)
        lst = _GridView.DataSource
        For i As Integer = 0 To _GridView.RowCount - 1
            If (lst(i).Id = obj_ct_h.Id) Then
                _GridView.FocusedRowHandle = i
            End If
        Next
    End Sub
End Class