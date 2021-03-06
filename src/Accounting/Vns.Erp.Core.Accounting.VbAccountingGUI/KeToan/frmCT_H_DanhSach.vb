Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.Utils
Imports System.Xml
Imports System.IO
Imports Vns.Erp.Core.Accounting.Domain
Imports Vns.Erp.Core.Admin.Domain
Imports Vns.Erp.Core.Accounting.Service.Interface
Imports Vns.Erp.Core.Admin.Service.Interface
Imports Vns.Erp.Core.Common.Controls.PagerControl

Public Class frmCT_H_DanhSach

#Region "Property"
    Private _HtLoaichungtuService As IHtLoaichungtuService
    Public Property HtLoaichungtuService As IHtLoaichungtuService
        Get
            Return _HtLoaichungtuService
        End Get
        Set(ByVal value As IHtLoaichungtuService)
            _HtLoaichungtuService = value
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

    Private _CtDService As ICtDService
    Public Property CtDService As ICtDService
        Get
            Return _CtDService
        End Get
        Set(ByVal value As ICtDService)
            _CtDService = value
        End Set
    End Property

    Private _DmPtqtService As IDmPtqtService
    Public Property DmPtqtService As IDmPtqtService
        Get
            Return _DmPtqtService
        End Get
        Set(ByVal value As IDmPtqtService)
            _DmPtqtService = value
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
#End Region


    Private CTHID As Guid
    Private ListCtH As IList(Of CtH) = New List(Of CtH)
    Private obj_ct_h As New CtH
    Private FormID As String
    Public obj_loaichungtu As New HtLoaichungtu

    Public Sub New()
        InitializeComponent()
        TNCommon.setIconControl(Me)
    End Sub

    Private Sub frmCT_H_DanhSach_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Try
            _GridView.Columns("Ghi").Visible = Generals.Ts_PheDuyetChungTu
            _GridView.Columns("NgayCt").DisplayFormat.FormatType = FormatType.DateTime
            _GridView.Columns("NgayCt").DisplayFormat.FormatString = "{0:dd/MM/yyyy}"
            LoadDanhSach()
            CtlPagerControl.display = New DisplayResult(AddressOf LoadDanhSach)
            CtlPagerControl.RefreshPage()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub LoadGridConfig()

        FormID = Me.Name + "?" + Me.AccessibleDescription
        ConfigGrid.GridConfig(FormID, gridView1.Name, gridView1)
        ConfigGrid.GridConfig(FormID, _GridView.Name, _GridView)
    End Sub

    Private Sub LoadDanhSach() 'Khong dat ten trung voi mot so ham hoac key dac biet
        'get ct_h by DonviID va obj_loaichungtu.LOAI_CT_ID (or ma loai ct), viet pkg
        'obj_loaichungtu.LOAI_CT_ID

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
        Dim lstobj_ct_h_temp As IList(Of CtH) = New List(Of CtH)
        lstobj_ct_h_temp = _CtHService.GetByLoaiChungTu(Me.CtlPagerControl.PageIndex, Me.CtlPagerControl.PageSize, Generals.DON_VI.Id, obj_loaichungtu.MaLoaiCt, CtlPagerControl.TotalResult)
        'lstobj_ct_h_temp = _CtHService.GetAll()
        ListCtH = lstobj_ct_h_temp

        _GridControl.DataSource = ListCtH
        Dim sotien As Decimal = 0
        For Each ctHInfo As CtH In ListCtH
            sotien += ctHInfo.SoTien
        Next
        If _GridView.RowCount <> 0 Then
            btnDelete.Enabled = True
            btnModify.Enabled = True
        Else
            btnDelete.Enabled = False
            btnModify.Enabled = False
        End If
        LoadGridConfig()
    End Sub

    Private Sub _GridView_FocusedRowChanged(ByVal sender As Object, ByVal e As FocusedRowChangedEventArgs) Handles _GridView.FocusedRowChanged
        Try
            Dim gridcth As CtH = CType(_GridView.GetRow(_GridView.FocusedRowHandle), CtH)

            If _GridView.RowCount <> 0 Then
                If Not (gridcth Is Nothing) Then
                    CTHID = gridcth.Id
                    'CTHID = Grid_GetDataRowItemString(_GridView, "CTH_ID")
                    LoadGRV(gridcth)
                End If
            Else
                gridControl1.DataSource = Nothing
            End If
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub LoadGRV(ByVal objCth As CtH)

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

        'Bind 
        'Dim lstobj_ct_d As List(Of CtD) = CT_DBO.Instance.GetObjectByCTHIdLNV0(CTH_ID)
        'Dim lstobj_ct_d As List(Of CtD) = objCth.LstCtD
        Dim lstobj_ct_d As List(Of CtD) = New List(Of CtD)
        lstobj_ct_d.AddRange(_CtDService.GetByCtHandNghiepVu(objCth.Id, -1))
        gridControl1.DataSource = lstobj_ct_d
    End Sub

    Private Sub btnCreate_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAdd.Click
        Try
            Create()
            'chuyen loai chung tu mac dinh sang form Chi Tiet xu ly
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub Create()
        Dim f As frmCT_H_ChiTiet = CType(ObjectFactory.GetObject("frmCT_H_ChiTiet"), frmCT_H_ChiTiet)
        'Dim f As New frmCT_H_ChiTiet

        Dim lstCTHG As List(Of Extend.CT_H_GInfo) = Commons.ConvertLstObjCtHtoCtHG(ListCtH)
        obj_ct_h = f.Show_Form(Nothing, obj_loaichungtu.MaLoaiCt, obj_loaichungtu.TenLoaiCt, _
                                lstCTHG, DataInputState.AddMode)
        Me.LoadDanhSach()
        If _GridView.RowCount > 0 Then
            grv_focus()
            'Lay lai CTH_ID
            Dim objCth As CtH = CType(_GridView.GetRow(_GridView.FocusedRowHandle), CtH)
            Me.LoadGRV(objCth)
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
        If _GridView.RowCount = 0 Then
            Return
        End If
        CTHID = CType(_GridView.GetRow(_GridView.FocusedRowHandle), CtH).Id
        'Try
        'Dim f As New frmCT_H_ChiTiet
        Dim f As frmCT_H_ChiTiet = CType(ObjectFactory.GetObject("frmCT_H_ChiTiet"), frmCT_H_ChiTiet)

        Dim lstCTHG As List(Of Extend.CT_H_GInfo) = Commons.ConvertLstObjCtHtoCtHG(ListCtH)
        obj_ct_h = f.Show_Form(CTHID, obj_loaichungtu.MaLoaiCt, obj_loaichungtu.TenLoaiCt, _
                                lstCTHG, DataInputState.EditMode)

        Me.LoadDanhSach()
        If _GridView.RowCount > 0 Then
            grv_focus()
            'Lấy lại CT_H_ID
            Dim objCth As CtH = CType(_GridView.GetRow(_GridView.FocusedRowHandle), CtH)
            Me.LoadGRV(objCth)
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
            Dim objCtH As CtH = CType(_GridView.GetRow(_GridView.FocusedRowHandle), CtH)
            _CtHService.Delete(objCtH)
            _GridView.DeleteSelectedRows()
            _GridView.RefreshData()
            'Me.LoadDanhSach()
            'Me.LoadGRV(objCtH)
        End If
    End Sub

    Private Sub btnClose_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnClose.Click
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
        lst.AddRange(_GridView.DataSource)
        For i As Integer = 0 To _GridView.RowCount - 1
            If (lst(i).Id = obj_ct_h.Id) Then
                _GridView.FocusedRowHandle = i
            End If
        Next
    End Sub

#Region "Cau hinh GridView"

    Private Sub _GridView_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        Try
            If e.KeyCode = Keys.F12 Then
                Dim lstColInfo As List(Of ColInfo) = New List(Of ColInfo)
                ConfigGrid.GetGridColInfo(_GridView, lstColInfo)
                Dim f As New ConfigGrid
                If f.Show_Form(_GridView.Name, FormID, lstColInfo) Then
                    ConfigGrid.GridConfig(FormID, _GridView.Name, _GridView)
                End If
            End If

        Catch ex As Exception
            Message_Error(ex)
        End Try

    End Sub

#End Region

    Private Sub gridView1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles gridView1.KeyDown
        Try
            If e.KeyCode = Keys.F12 Then
                Dim lstColInfo As List(Of ColInfo) = New List(Of ColInfo)
                ConfigGrid.GetGridColInfo(gridView1, lstColInfo)
                Dim f As New ConfigGrid
                If f.Show_Form(gridView1.Name, FormID, lstColInfo) Then
                    ConfigGrid.GridConfig(FormID, gridView1.Name, gridView1)
                End If
            End If
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

End Class