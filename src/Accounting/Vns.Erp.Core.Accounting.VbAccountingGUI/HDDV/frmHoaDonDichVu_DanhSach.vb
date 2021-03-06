Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.Utils
Imports Vns.Erp.Core.Accounting.Domain
Imports Vns.Erp.Core.Accounting.Service.Interface
Imports Vns.Erp.Core.Admin.Domain
Imports Vns.Erp.Core.Admin.Service.Interface
Imports Vns.Erp.Core.Common.Controls.PagerControl

Public Class frmHoaDonDichVu_DanhSach
#Region "Variable"
    Public Property HtLoaichungtuService As IHtLoaichungtuService
    Public Property KtCtHHddvService As IKtCtHHddvService
    Public Property KtCtDHddvService As IKtCtDHddvService
    Public Property DmPtqtService As IDmPtqtService
    Public Property DmVuviecService As IDmVuviecService
#End Region
    Private CTHID As Guid
    Private obj_ct_h As KtCtHHddv
    Public obj_loaichungtu As HtLoaichungtu = New HtLoaichungtu()
    Private FormID As String
    Private lstKtCtHHddv As IList(Of KtCtHHddv) = New List(Of KtCtHHddv)()

    Public Sub New()
        InitializeComponent()
        TNCommon.setIconControl(Me)
        _GridView.Columns("Ghi").Visible = Generals.Ts_PheDuyetChungTu
    End Sub

    Private Sub frmCT_H_DanhSach_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Try
            _GridView.Columns("NgayCt").DisplayFormat.FormatType = FormatType.DateTime
            _GridView.Columns("NgayCt").DisplayFormat.FormatString = "{0:dd/MM/yyyy}"

            InitData()
            LoadDanhSach()
            PagerControl1.display = New DisplayResult(AddressOf LoadDanhSach)
            PagerControl1.RefreshPage()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Function lst(ByVal lst_cth As List(Of KtCtHHddv)) As List(Of KtCtHHddv)
        Dim lst_cth_temp As List(Of KtCtHHddv) = New List(Of KtCtHHddv)
        For Each obj As KtCtHHddv In lst_cth
            If obj.PrefixCt IsNot Nothing Then
                obj.CtSo = obj.PrefixCt + obj.CtSo
            End If
            lst_cth_temp.Add(obj)
        Next
        Return lst_cth_temp
    End Function

    Private Sub LoadGridConfig()

        FormID = Me.Name + "?" + Me.AccessibleDescription
        ConfigGrid.GridConfig(FormID, gridView1.Name, gridView1)
        ConfigGrid.GridConfig(FormID, _GridView.Name, _GridView)
    End Sub

    Private Sub InitData()
        'truyen para frm
        Dim para_str As String = Me.AccessibleDescription
        Dim lst_para As List(Of ParamInfo) = DataMining.GetParams(para_str)
        If lst_para.Count > 0 Then
            'obj_loaichungtu.TEN_LOAI_CT = lst_para(1).PARAMVALUE
            obj_loaichungtu.MaLoaiCt = lst_para(0).PARAMVALUE
        End If

        Dim objHTCT As HtLoaichungtu = HtLoaichungtuService.GetByMA_LOAI_CT(obj_loaichungtu.MaLoaiCt, Generals.DON_VI.Id)
        If objHTCT IsNot Nothing Then
            obj_loaichungtu.TenLoaiCt = objHTCT.TenLoaiCt
        End If
    End Sub

    Private Sub LoadDanhSach() 'Khong dat ten trung voi mot so ham hoac key dac biet
        _GridControl.DataSource = Nothing
        
        Me.Text = obj_loaichungtu.TenLoaiCt
        Dim lstobj_ct_h_temp As List(Of KtCtHHddv) = New List(Of KtCtHHddv)
        lstobj_ct_h_temp.AddRange(KtCtHHddvService.GetByLoaiChungTu(Me.PagerControl1.PageIndex, Me.PagerControl1.PageSize, Generals.DON_VI.Id, obj_loaichungtu.MaLoaiCt, obj_loaichungtu.SoCtHienthi, PagerControl1.TotalResult))

        lstKtCtHHddv = lstobj_ct_h_temp

        Dim lstobj_ct_h As List(Of KtCtHHddv) = lst(lstobj_ct_h_temp)
        _GridControl.DataSource = lstobj_ct_h
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
            Dim gridcth As KtCtHHddv = CType(_GridView.GetRow(_GridView.FocusedRowHandle), KtCtHHddv)

            If _GridView.RowCount <> 0 Then
                If gridcth Is Nothing Then Return
                CTHID = gridcth.Id
                'CTHID = Grid_GetDataRowItemString(_GridView, "CTH_ID")
                LoadGRV(CTHID)
            Else
                gridControl1.DataSource = Nothing
            End If
        Catch ex As Exception
            Message_Error(ex)
        End Try

    End Sub

    Private Sub LoadCombo()
        Dim lstPPQTNo As List(Of DmPtqt) = New List(Of DmPtqt)
        lstPPQTNo.AddRange(DmPtqtService.GetAllByDonviID(Generals.DON_VI.Id))
        cboPTQTNo.DataSource = lstPPQTNo
        cboPTQTNo.DisplayMember = "KyHieu"
        cboPTQTNo.ValueMember = "Id"

        Dim lstPPQTCo As List(Of DmPtqt) = _
                DmPtqtService.GetAllByDonviID(Generals.DON_VI.Id)
        cboPTQTCo.DataSource = lstPPQTCo
        cboPTQTCo.DisplayMember = "KyHieu"
        cboPTQTCo.ValueMember = "Id"

        Dim lstVuViecNo As List(Of DmVuviec) = New List(Of DmVuviec)
        lstVuViecNo.AddRange(DmVuviecService.GetAllByDonviID(Generals.DON_VI.Id))
        cboVuviecNo.DataSource = lstVuViecNo
        cboVuviecNo.DisplayMember = "KyHieu"
        cboVuviecNo.ValueMember = "Id"

        Dim lstVuViecCo As List(Of DmVuviec) = New List(Of DmVuviec)
        lstVuViecCo.AddRange(DmVuviecService.GetAllByDonviID(Generals.DON_VI.Id))
        cboVuviecCo.DataSource = lstVuViecCo
        cboVuviecCo.DisplayMember = "KyHieu"
        cboVuviecCo.ValueMember = "Id"
    End Sub

    Private Sub LoadGRV(ByVal CTH_ID As Guid)
        Dim lstobj_ct_d As List(Of KtCtDHddv) = New List(Of KtCtDHddv)
        lstobj_ct_d.AddRange(KtCtDHddvService.GetByCtHandNghiepVu(CTH_ID))
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
        Dim f As frmHoaDonDichVu_ChiTiet = CType(ObjectFactory.GetObject("Ketoan.frmHoaDonDichVu_ChiTiet"), frmHoaDonDichVu_ChiTiet)
        Dim lstCTHG As List(Of Extend.CT_H_GInfo) = Commons.ConvertToCTHG(lstKtCtHHddv)
        obj_ct_h = f.Show_Form(Nothing, obj_loaichungtu.MaLoaiCt, obj_loaichungtu.TenLoaiCt, _
                                lstCTHG, DataInputState.AddMode)
        Me.LoadDanhSach()
        If _GridView.RowCount > 0 Then
            grv_focus()
            'Lay lai ID
            CTHID = CType(_GridView.GetRow(_GridView.FocusedRowHandle), KtCtHHddv).Id
            Me.LoadGRV(CTHID)
        End If
    End Sub

    Private Sub btnModify_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnModify.Click
        Try
            If _GridView.RowCount = 0 Then
                Message_Warning("Không có bản ghi nào!")
                Return
            End If
            Edit()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub Edit()
        CTHID = CType(_GridView.GetRow(_GridView.FocusedRowHandle), KtCtHHddv).Id
        Dim f As frmHoaDonDichVu_ChiTiet = CType(ObjectFactory.GetObject("Ketoan.frmHoaDonDichVu_ChiTiet"), frmHoaDonDichVu_ChiTiet)

        Dim lstCTHG As List(Of Extend.CT_H_GInfo) = Commons.ConvertToCTHG(lstKtCtHHddv)
        obj_ct_h = f.Show_Form(CTHID, obj_loaichungtu.MaLoaiCt, obj_loaichungtu.TenLoaiCt, lstCTHG, DataInputState.EditMode)
        Me.LoadDanhSach()
        If _GridView.RowCount > 0 Then
            grv_focus()
            'Lay lai ID
            CTHID = CType(_GridView.GetRow(_GridView.FocusedRowHandle), KtCtHHddv).Id
            Me.LoadGRV(CTHID)
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
        'If (Message_Confirm(ConstantMsgs.MSG_CONFIRM_FOR_DELETE)) Then
        '    CT_HBO.Instance.Delete(CTHID)
        '    _GridView.RefreshData()
        '    Me.LoadDanhSach()
        '    Me.LoadGRV(CTHID)
        'End If
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
        Dim lst As List(Of KtCtHHddv) = New List(Of KtCtHHddv)
        lst = _GridView.DataSource
        For i As Integer = 0 To _GridView.RowCount - 1
            If (lst(i).Id = obj_ct_h.Id) Then
                _GridView.FocusedRowHandle = i
            End If
        Next
    End Sub

    Private Sub _GridView_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles _GridView.KeyDown
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