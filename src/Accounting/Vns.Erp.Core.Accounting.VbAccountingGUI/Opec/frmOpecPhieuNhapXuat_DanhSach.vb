Imports Vns.Erp.Core.Accounting.Domain
Imports Vns.Erp.Core.Admin.Domain
Imports Vns.Erp.Core.Accounting.Service.Interface
Imports Vns.Erp.Core.Admin.Service.Interface
Imports Vns.Erp.Core.Common.Controls.PagerControl

Public Class frmOpecPhieuNhapXuat_DanhSach

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
    Private _CtHNxService As ICtHNxService
    Public Property CtHNxService As ICtHNxService
        Get
            Return _CtHNxService
        End Get
        Set(ByVal value As ICtHNxService)
            _CtHNxService = value
        End Set
    End Property

    Private _CtDNxService As ICtDNxService
    Public Property CtDNxService As ICtDNxService
        Get
            Return _CtDNxService
        End Get
        Set(ByVal value As ICtDNxService)
            _CtDNxService = value
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

    ''' <summary>
    ''' khao bao bien chua ID dung de load du lieu cho bang duoi theo ID bang tren
    ''' </summary>
    ''' <remarks></remarks>
    Dim CTHNXID As Guid

    ''' <summary>
    ''' khai bao 1 bien chua ID de truyen sang form chi tiet de xu ly
    ''' </summary>
    ''' <remarks></remarks>
    Dim mCTHNXID As Guid

    ''' <summary>
    ''' khai bao 1 list obj de luu data
    ''' </summary>
    ''' <remarks></remarks>
    Public lstobj_ct_h_nx As List(Of CtHNx)

    ''' <summary>
    ''' khai bao 1 obj dung de chua cac thong tin cua loai chung tu truyen tu mennu
    ''' </summary>
    ''' <remarks></remarks>
    Public obj_loaichungtu As HtLoaichungtu = New HtLoaichungtu()
    '
    Dim SO_CT_HIENTHI As Integer
    '
    Private FormID As String

#End Region

#Region "Load form"

    ''' <summary>
    ''' xet icon cho btn
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub New()
        InitializeComponent()
        TNCommon.setIconControl(Me)
    End Sub

    ''' <summary>
    ''' load data cho form
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub frmPhieuNhapKho_DanhSach_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            grvLPX_Hnx.Columns("Ghi").Visible = Generals.Ts_PheDuyetChungTu
            Dim para_str As String = Me.AccessibleDescription
            Dim lst_para As List(Of ParamInfo) = DataMining.GetParams(para_str)
            '
            If lst_para.Count > 0 Then
                obj_loaichungtu.MaLoaiCt = lst_para(0).PARAMVALUE
            End If
            '
            obj_loaichungtu = _HtLoaichungtuService.GetByMA_LOAI_CT(obj_loaichungtu.MaLoaiCt, Generals.DON_VI.Id)
            If obj_loaichungtu IsNot Nothing Then
                If obj_loaichungtu.SoCtHienthi = 0 Then
                    SO_CT_HIENTHI = Integer.MinValue
                Else
                    SO_CT_HIENTHI = obj_loaichungtu.SoCtHienthi
                End If
            End If
            Me.Text = obj_loaichungtu.TenLoaiCt
            Load_Grid()
            PagerControl1.display = New DisplayResult(AddressOf Load_Grid)
            PagerControl1.RefreshPage()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

#End Region

#Region "Private Function and Procedures"
    Dim phieukhoData As IList(Of CtHNx) = New List(Of CtHNx)
    Private Sub Load_Grid()

        phieukhoData = _CtHNxService.GetByLoaiChungTu(Me.PagerControl1.PageIndex, Me.PagerControl1.PageSize, Generals.DON_VI.Id, obj_loaichungtu.MaLoaiCt, SO_CT_HIENTHI, PagerControl1.TotalResult)
        ' load du lieu len grid
        'Grid_LoadData(grvLPX_Hnx, phieukhoData)
        grvLPX_Hnx.GridControl.DataSource = phieukhoData
        'grcLPN_Hnx.DataSource = lstobj_ct_h_nx

        If grvLPX_Hnx.RowCount <> 0 Then
            btnMod.Enabled = True
        Else
            btnMod.Enabled = False
        End If
        '
        LoadGridConfig()

    End Sub


    Private Sub LoadGRV(ByVal CTH_XN_ID As Guid)
        Dim lstobj_ct_d_nx As List(Of CtDNx) = New List(Of CtDNx)
        lstobj_ct_d_nx.AddRange(_CtDNxService.GetObjectByCTHId(CTH_XN_ID))
        grcLPN_Dnx.DataSource = lstobj_ct_d_nx

        Dim lstKhoNhap As List(Of DmKho) = New List(Of DmKho)
        lstKhoNhap.AddRange(_DmKhoService.GetAllByDonviID(Generals.DON_VI.Id))
        cboKhoNhap1.DataSource = lstKhoNhap
        cboKhoNhap1.DisplayMember = "KyHieu"
        cboKhoNhap1.ValueMember = "Id"

        Dim lstKhoXuat As List(Of DmKho) = New List(Of DmKho)
        lstKhoXuat.AddRange(_DmKhoService.GetAllByDonviID(Generals.DON_VI.Id))
        cboKhoXuat1.DataSource = lstKhoXuat
        cboKhoXuat1.DisplayMember = "KyHieu"
        cboKhoXuat1.ValueMember = "Id"

        If obj_loaichungtu.MaLoaiCt = "P_NKHO_NK" Then
            grvLPN_Dnx.Columns("KhoXuatId").Visible = False
            grvLPN_Dnx.Columns("KhoNhapId").Visible = True
        ElseIf obj_loaichungtu.MaLoaiCt = "P_XKHO_XK" Then
            grvLPN_Dnx.Columns("KhoXuatId").Visible = True
            grvLPN_Dnx.Columns("KhoNhapId").Visible = False
        End If
    End Sub

    ''' <summary>
    ''' lay duoc ID row hien tai (chua su dung)
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function GetRowSelect() As Boolean
        Dim selrow As Integer = 0
        If (grvLPX_Hnx.GetSelectedRows().Length > 0) Then
            If (grvLPX_Hnx.RowCount <> 0) Then
                Dim grtCTH_NX As CtHNx = CType(grvLPX_Hnx.GetRow(grvLPX_Hnx.GetSelectedRows(0)), CtHNx)
                mCTHNXID = grtCTH_NX.Id
                Return True
            End If
        End If
        Return False
    End Function

    ''' <summary>
    ''' load config
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub LoadGridConfig()

        FormID = Me.Name + "?" + Me.AccessibleDescription
        ConfigGrid.GridConfig(FormID, grvLPX_Hnx.Name, grvLPX_Hnx)
        ConfigGrid.GridConfig(FormID, grvLPN_Dnx.Name, grvLPN_Dnx)

    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnCreate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Try
            Create()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub
    Private Sub Create()
        'Try
        Dim f As frmOpecPhieuNhapXuat_ChiTiet = CType(ObjectFactory.GetObject("frmOpecPhieuNhapXuat_ChiTiet"), frmOpecPhieuNhapXuat_ChiTiet)
        'f.lstobj_ct_h_nx = lstobj_ct_h_nx
        f.obj_lct.MaLoaiCt = obj_loaichungtu.MaLoaiCt
        f.obj_lct = obj_loaichungtu
        'Dim lstCTHG As List(Of Extend.CT_H_GInfo) = Commons.ConvertToCTHG(CT_H_NxBO.Instance.GetObjectAllByLoaiChungTu(Generals.DON_VI.Id, obj_loaichungtu.MaLoaiCt))
        Dim lstCTHG As List(Of Extend.CT_H_GInfo) = Commons.ConvertToCTHG(phieukhoData)
        If f.Show_Form(Nothing, obj_loaichungtu.MaLoaiCt, obj_loaichungtu.TenLoaiCt, lstCTHG, DataInputState.AddMode) Then
            Me.Load_Grid()
            If grvLPX_Hnx.RowCount > 0 Then
                Dim tmp As CtHNx = CType(grvLPX_Hnx.GetRow(grvLPX_Hnx.FocusedRowHandle), CtHNx)
                If tmp Is Nothing Then tmp = New CtHNx()
                CTHNXID = tmp.Id
                Me.LoadGRV(CTHNXID)
            End If

        End If
        'Catch ex As Exception
        '    Message_Error(ex)
        'End Try
    End Sub

    Private Sub btnModify_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMod.Click
        Try
            Edit()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub Edit()
        'Try
        If (grvLPX_Hnx.RowCount <> 0) Then

            CTHNXID = CType(grvLPX_Hnx.GetRow(grvLPX_Hnx.FocusedRowHandle), CtHNx).Id
            Dim f As frmOpecPhieuNhapXuat_ChiTiet = CType(ObjectFactory.GetObject("frmOpecPhieuNhapXuat_ChiTiet"), frmOpecPhieuNhapXuat_ChiTiet)
            f.obj_lct = obj_loaichungtu
            f.obj_lct.MaLoaiCt = obj_loaichungtu.MaLoaiCt
            'Dim lstCTHG As List(Of Extend.CT_H_GInfo) = Commons.ConvertToCTHG(CT_H_NxBO.Instance.GetObjectAllByLoaiChungTu(Generals.DON_VI.Id, obj_loaichungtu.MaLoaiCt))
            Dim lstCTHG As List(Of Extend.CT_H_GInfo) = Vns.Erp.Core.Accounting.VbAccountingGUI.Commons.ConvertToCTHG(phieukhoData)
            If f.Show_Form(CTHNXID, obj_loaichungtu.MaLoaiCt, obj_loaichungtu.TenLoaiCt, lstCTHG, DataInputState.EditMode) Then
                Me.Load_Grid()
                If grvLPX_Hnx.RowCount > 0 Then
                    Dim tmp As CtHNx = CType(grvLPX_Hnx.GetRow(grvLPX_Hnx.FocusedRowHandle), CtHNx)
                    If tmp Is Nothing Then tmp = New CtHNx()
                    CTHNXID = tmp.Id
                    Me.LoadGRV(CTHNXID)
                End If
            End If

        Else
            MessageBox.Show("Bạn chưa chọn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
        End If
        'Catch ex As Exception
        '    Message_Error(ex)
        'End Try
    End Sub

    Private Sub btnClo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClo.Click
        Try
            Me.Close()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

#End Region

#Region "Events"

    Private Sub grvLPX_Hnx_FocusedRowChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles grvLPX_Hnx.FocusedRowChanged
        Try
            Dim tmp As CtHNx = CType(grvLPX_Hnx.GetRow(e.FocusedRowHandle), CtHNx)
            If tmp Is Nothing Then
                tmp = New CtHNx()
            End If
            CTHNXID = tmp.Id
            LoadGRV(CTHNXID)
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub frmPhieuNhapKho_DanhSach_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
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

                Case Keys.Q And e.Alt
                    Me.Close()
                    Exit Select
            End Select
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    ''' <summary>
    ''' Cau hinh grid view tren
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub grvLPX_Hnx_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles grvLPX_Hnx.KeyDown
        Try
            If e.KeyCode = Keys.F12 Then
                Dim lstColInfo As List(Of ColInfo) = New List(Of ColInfo)
                ConfigGrid.GetGridColInfo(grvLPX_Hnx, lstColInfo)
                Dim f As New ConfigGrid
                If f.Show_Form(grvLPX_Hnx.Name, FormID, lstColInfo) Then
                    ConfigGrid.GridConfig(FormID, grvLPX_Hnx.Name, grvLPX_Hnx)
                End If
            End If
        Catch ex As Exception
            Message_Error(ex)
        End Try

    End Sub

    ''' <summary>
    ''' Cau hinh grid view duoi
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub grvLPN_Dnx_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles grvLPN_Dnx.KeyDown, grcLPN_Hnx.KeyDown
        Try
            If e.KeyCode = Keys.F12 Then
                Dim lstColInfo As List(Of ColInfo) = New List(Of ColInfo)
                ConfigGrid.GetGridColInfo(grvLPN_Dnx, lstColInfo)
                Dim f As New ConfigGrid
                If f.Show_Form(grvLPN_Dnx.Name, FormID, lstColInfo) Then
                    ConfigGrid.GridConfig(FormID, grvLPN_Dnx.Name, grvLPN_Dnx)
                End If
            End If
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

#End Region

End Class