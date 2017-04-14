Imports Vns.Erp.Core.Admin.Service.Interface
Imports Vns.Erp.Core.Accounting.Service.Interface
Imports Vns.Erp.Core.Admin.Domain
Imports Vns.Erp.Core.Accounting.Domain
Imports Vns.Erp.Core.Common.Controls.PagerControl

Public Class frmPhieuNhapKhau_Danhsach
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

    ' khai bao 1 bien chua ID cua luoi tren
    Dim CTHNXID As Guid

    ' khai bao 1 bien chua ID dung trong ham getrow
    Dim mCTHNXID As Guid

    ' khai bao1 obj chua data chung tu
    Public obj_loaichungtu As HtLoaichungtu = New HtLoaichungtu()
    'Private lstobj_ct_h_nx As List(Of CT_H_NxInfo)

    Private FormID As String

    Dim SO_CT_HIENTHI As Integer


#Region "Load form"

    ''' <summary>
    ''' ham xet icon cho cac button
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub New()
        InitializeComponent()
        TNCommon.setIconControl(Me)
    End Sub

    Private Sub LoadGridConfig()

        FormID = Me.Name + "?" + Me.AccessibleDescription
        ConfigGrid.GridConfig(FormID, grvLPN_Dnx.Name, grvLPN_Dnx)
        ConfigGrid.GridConfig(FormID, grvLPX_Hnx.Name, grvLPX_Hnx)
    End Sub

    ''' <summary>
    ''' load form
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub frmPhieuNhapKhau_Danhsach_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            grvLPX_Hnx.Columns("Ghi").Visible = Generals.Ts_PheDuyetChungTu
            'khai bao cac bien luu ma loai chung tu khi chon tren menu truyen vao
            Dim para_str As String = Me.AccessibleDescription
            Dim lst_para As List(Of ParamInfo) = DataMining.GetParams(para_str)
            If lst_para.Count > 0 Then
                'gan ma loai chung tu bang gia tri truyen tu menu
                obj_loaichungtu.MaLoaiCt = lst_para(0).PARAMVALUE
            End If
            'khai bao 1 obj luu data lay duoc theo ma loai chung tu
            obj_loaichungtu = _HtLoaichungtuService.GetByMA_LOAI_CT(obj_loaichungtu.MaLoaiCt, Generals.DON_VI.Id)

            If obj_loaichungtu IsNot Nothing Then
                If obj_loaichungtu.SoCtHienthi = 0 Then
                    SO_CT_HIENTHI = Integer.MinValue
                Else
                    SO_CT_HIENTHI = obj_loaichungtu.SoCtHienthi
                End If
            End If
            'gan ten form theo ten quy dinh trong bang HT loai chung tu
            Me.Text = obj_loaichungtu.TenLoaiCt

            BindControl()
            'goi ham xu ly load form
            Load_Grid()
            PagerControl1.display = New DisplayResult(AddressOf Load_Grid)
            PagerControl1.RefreshPage()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

#End Region

    Dim phieunhap As IList(Of CtHNx) = New List(Of CtHNx)
    ''' <summary>
    ''' ham xu ly load form
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub Load_Grid()
        ' Lay thong tin he so nop thue
        phieunhap = _CtHNxService.GetByLoaiChungTu(Me.PagerControl1.PageIndex, Me.PagerControl1.PageSize, Generals.DON_VI.Id, obj_loaichungtu.MaLoaiCt, SO_CT_HIENTHI, PagerControl1.TotalResult)
        ' load du lieu len grid
        'grvLPX_Hnx.
        Grid_LoadData(grvLPX_Hnx, phieunhap)
        If grvLPX_Hnx.RowCount <> 0 Then
            btnDel.Enabled = True
            btnMod.Enabled = True
        Else
            btnDel.Enabled = False
            btnMod.Enabled = False
        End If
        LoadGridConfig()
    End Sub

    Private Sub LoadGRV(ByVal CTH_XN_ID As Guid)
        ' Lay thong tin cua luoi o duoi va load len
        Dim phieuCT_D_NxData As IList(Of CtDNx) = New List(Of CtDNx)
        If Not VnsCheck.IsNullGuid(CTH_XN_ID) Then
            phieuCT_D_NxData = _CtDNxService.GetObjectByCTHId(CTH_XN_ID)
        Else
            phieuCT_D_NxData = Nothing
        End If
        Grid_LoadData(grvLPN_Dnx, phieuCT_D_NxData)
        
    End Sub

    Private Sub BindControl()
        ''Bind mã kho
        Dim lstMaKho As List(Of DmKho) = New List(Of DmKho)
        lstMaKho.AddRange(_DmKhoService.GetAllByDonviID(Generals.DON_VI.Id))
        cboKHO_NHAP_ID.DataSource = lstMaKho
        cboKHO_NHAP_ID.DisplayMember = "KyHieu"
        cboKHO_NHAP_ID.ValueMember = "Id"
    End Sub

    Private Sub Create()
        'Try
        Dim f As frmPhieuNhapKhau_ChiTiet = CType(ObjectFactory.GetObject("frmPhieuNhapKhau_ChiTiet"), frmPhieuNhapKhau_ChiTiet)
        f.obj_lct = obj_loaichungtu
        Dim lstCTHG As List(Of Extend.CT_H_GInfo) = Commons.ConvertToCTHG(phieunhap)
        If f.Show_Form(Nothing, obj_loaichungtu.MaLoaiCt, obj_loaichungtu.TenLoaiCt, lstCTHG, DataInputState.AddMode) Then
            Me.Load_Grid()
            If grvLPX_Hnx.RowCount > 0 Then
                CTHNXID = CType(grvLPX_Hnx.GetRow(grvLPX_Hnx.FocusedRowHandle), CtHNx).Id
                Me.LoadGRV(CTHNXID)
            End If
        End If
        'Catch ex As Exception
        '    Message_Error(ex)
        'End Try
    End Sub

    Private Sub btnCreate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Try
            Create()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub Edit()
        'Try
        If (grvLPX_Hnx.RowCount <> 0) Then
            CTHNXID = CType(grvLPX_Hnx.GetRow(grvLPX_Hnx.FocusedRowHandle), CtHNx).Id
            Dim f As frmPhieuNhapKhau_ChiTiet = CType(ObjectFactory.GetObject("frmPhieuNhapKhau_ChiTiet"), frmPhieuNhapKhau_ChiTiet)
            f.obj_lct = obj_loaichungtu
            Dim lstCTHG As List(Of Extend.CT_H_GInfo) = Commons.ConvertToCTHG(phieunhap)
            If f.Show_Form(CTHNXID, obj_loaichungtu.MaLoaiCt, obj_loaichungtu.TenLoaiCt, lstCTHG, DataInputState.EditMode) Then
                Me.Load_Grid()
                If grvLPX_Hnx.RowCount > 0 Then
                    CTHNXID = CType(grvLPX_Hnx.GetRow(grvLPX_Hnx.FocusedRowHandle), CtHNx).Id
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

    Private Sub btnModify_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMod.Click
        Try
            Edit()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub grvLPX_Hnx_FocusedRowChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles grvLPX_Hnx.FocusedRowChanged
        Try
            Dim tmp As CtHNx = CType(grvLPX_Hnx.GetRow(grvLPX_Hnx.FocusedRowHandle), CtHNx)
            If tmp Is Nothing Then
                tmp = New CtHNx()
            End If
            CTHNXID = tmp.Id
            LoadGRV(CTHNXID)
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub frmPhieuNhapKhau_Danhsach_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Try
            Select Case e.KeyCode
                Case Keys.Escape
                    Me.Close()
                    Exit Select
                Case Keys.F3
                    Create()
                    Exit Select
                Case Keys.F4
                    If grvLPX_Hnx.RowCount <> 0 Then
                        Edit()
                    End If
                    Exit Select
                Case Keys.Q And e.Alt
                    Me.Close()
                    Exit Select
            End Select
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClo.Click
        Try
            Me.Close()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub grvLPX_Hnx_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles grvLPX_Hnx.KeyDown
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

    Private Sub grvLPN_Dnx_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles grvLPN_Dnx.KeyDown, grcLPN_Hnx.KeyDown
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
End Class