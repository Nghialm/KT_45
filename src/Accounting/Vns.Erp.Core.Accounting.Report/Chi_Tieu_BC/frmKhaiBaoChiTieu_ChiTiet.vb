Imports System.Reflection
Imports Vns.Erp.Core.Admin.Domain
Imports Vns.Erp.Core.Admin.Service.Interface

Public Class frmKhaiBaoChiTieu_ChiTiet

#Region "Property"
    Private _KtHCotService As IKtHCotService
    Public Property KtHCotService As IKtHCotService
        Get
            Return _KtHCotService
        End Get
        Set(ByVal value As IKtHCotService)
            _KtHCotService = value
        End Set
    End Property
    Private _KtDieukienBcService As IKtDieukienBcService
    Public Property KtDieukienBcService As IKtDieukienBcService
        Get
            Return _KtDieukienBcService
        End Get
        Set(ByVal value As IKtDieukienBcService)
            _KtDieukienBcService = value
        End Set
    End Property
    Private _KtHDongService As IKtHDongService
    Public Property KtHDongService As IKtHDongService
        Get
            Return _KtHDongService
        End Get
        Set(ByVal value As IKtHDongService)
            _KtHDongService = value
        End Set
    End Property
#End Region

#Region "Contructor"

    Public Sub New()
        InitializeComponent()
        TNCommon.setIconControl(Me)
    End Sub

#End Region

#Region "Variables"

    Private m_kt_h_Dong As Guid
    Private m_InputState As DataInputState
    Private obj_KT_H_Dong As KtHDong
    Private obj_KT_H_COT As KtHCot
    Private obj_KT_CHITIET As KtDieukienBc
    Private m_baoCao_ID As Guid
    Dim dt_KT_H_COT As IList(Of KtHCot)
    Dim dt_KT_CHITIET As IList(Of KtDieukienBc)
#End Region

#Region "Show_form"

    Public Function Show_form(ByVal p_kt_h_Dong As Guid, ByVal p_BaoCao_ID As Guid, ByVal p_InputState As DataInputState) As KtHDong
        Try
            m_kt_h_Dong = p_kt_h_Dong
            m_InputState = p_InputState
            m_baoCao_ID = p_BaoCao_ID
            Form_InitDialog(Me)
            'Panel_InitControl(grc1, "KT_H_DONG")
            'Panel_InitControl(grc2, "KT_H_DONG")

            'dt_KT_H_COT = _KtHCotService.GetBy_Dong_Id(p_BaoCao_ID)
            'grc_KT_COT.DataSource = dt_KT_H_COT

            'dt_KT_CHITIET = _KtDieukienBcService.GetBy_Dong_Id(p_kt_h_Dong)
            'grc_CHI_TIET.DataSource = dt_KT_CHITIET

            frmProgress.Instance.Thread = AddressOf Init_Data
            frmProgress.Instance.Show_Progress()
        Catch ex As Exception
            Message_Error(ex)
        End Try
        If (Me.ShowDialog = DialogResult.OK) Then
            Return obj_KT_H_Dong
        Else
            Return Nothing
        End If
    End Function
#End Region

#Region "Private functions"

    Private Sub Init_Data()
        Select Case m_InputState
            Case DataInputState.EditMode
                SetObjectToControl()
            Case DataInputState.AddMode
                txtNHOM.Text = 0
        End Select
    End Sub

    Private Sub SetObjectToControl()
        obj_KT_H_Dong = New KtHDong
        obj_KT_H_Dong = _KtHDongService.GetById(m_kt_h_Dong)

        'Panel_SetControlValue(grc1, obj_KT_H_Dong)
        'Panel_SetControlValue(grc2, obj_KT_H_Dong)
        'dt_KT_H_COT = _KtHCotService.GetBy_Dong_Id(m_baoCao_ID)
        'grc_KT_COT.DataSource = dt_KT_H_COT

        txtTHU_TU.Text = obj_KT_H_Dong.ThuTu
        txtMA_SO.Text = obj_KT_H_Dong.MaSo
        txtCHI_TIEU_1.Text = obj_KT_H_Dong.ChiTieu
        txtCHI_TIEU_2.Text = obj_KT_H_Dong.ChiTieu2
        txtIN_DONG.Text = obj_KT_H_Dong.InDong
        txtKIEU_CHU.Text = obj_KT_H_Dong.KieuChu

        dt_KT_CHITIET = _KtDieukienBcService.GetBy_Dong_Id(m_kt_h_Dong)
        txtNHOM.Text = obj_KT_H_Dong.Nhom
        txtCACH_TINH.Text = obj_KT_H_Dong.CachTinh
        txtHAM_TINH.Text = obj_KT_H_Dong.HamTinh
        txtDK_MA_TK.Text = obj_KT_H_Dong.DkMaTk
        txtDK_MA_TK_DU.Text = obj_KT_H_Dong.DkMaTkDu
        txtDkMaPTQT.Text = obj_KT_H_Dong.DkMaPtqt
        txtDkDmPTQTDu.Text = obj_KT_H_Dong.DkMaDmPtqtDu
    End Sub

    Private Sub GetControlToObject()
        If obj_KT_H_Dong Is Nothing Then
            obj_KT_H_Dong = New KtHDong
        End If
        obj_KT_H_Dong.ThuTu = txtTHU_TU.Text
        obj_KT_H_Dong.MaSo = txtMA_SO.Text
        obj_KT_H_Dong.ChiTieu = txtCHI_TIEU_1.Text
        obj_KT_H_Dong.ChiTieu2 = txtCHI_TIEU_2.Text
        obj_KT_H_Dong.InDong = txtIN_DONG.Text
        obj_KT_H_Dong.KieuChu = txtKIEU_CHU.Text
        obj_KT_H_Dong.Nhom = txtNHOM.Text
        obj_KT_H_Dong.CachTinh = txtCACH_TINH.Text
        obj_KT_H_Dong.HamTinh = txtHAM_TINH.Text
        obj_KT_H_Dong.DkMaTk = txtDK_MA_TK.Text
        obj_KT_H_Dong.DkMaTkDu = txtDK_MA_TK_DU.Text
        obj_KT_H_Dong.DkMaPtqt = txtDkMaPTQT.Text
        obj_KT_H_Dong.DkMaDmPtqtDu = txtDkDmPTQTDu.Text

        'Panel_GetControlValue(grc1, obj_KT_H_Dong)
        'Panel_GetControlValue(grc2, obj_KT_H_Dong)

        obj_KT_H_Dong.BaocaoId = m_baoCao_ID
        Select Case m_InputState
            Case DataInputState.AddMode
                _KtHDongService.Save(obj_KT_H_Dong)
            Case DataInputState.EditMode
                _KtHDongService.SaveOrUpdate(obj_KT_H_Dong)
        End Select

        'obj_KT_H_COT = New KtHCot()

        'obj_KT_CHITIET = New KtDieukienBc()
        'Dim dv As IList(Of KtHCot)

        'Dim dv_CHITIET As IList(Of KtDieukienBc)

        Select Case m_InputState
            Case DataInputState.AddMode
                'insert cot
                'dv = CType(grv_KT_COT.DataSource, IList(Of KtHCot))
                'For Each drw As KtHCot In dv
                '    drw.BaocaoId = m_baoCao_ID

                '    _KtHCotService.Save(drw)
                'Next

                'insert dieu kien
                'dv_CHITIET = CType(grv_CHI_TIET.DataSource, IList(Of KtDieukienBc))
                'For Each drw_ChiTiet As KtDieukienBc In dv_CHITIET
                '    drw_ChiTiet.IdDong = m_kt_h_Dong

                '    _KtDieukienBcService.Save(drw_ChiTiet)
                'Next

            Case DataInputState.EditMode
                ''lấy ra các row dc thêm mới và thực hiện thêm mới
                ''grv_KT_COT
                'dv = CType(grv_KT_COT.DataSource, IList(Of KtHCot))
                'For Each drw As KtHCot In dv
                '    drw.BaocaoId = m_baoCao_ID

                '    If (VnsCheck.IsNullGuid(drw.Id)) Then
                '        _KtHCotService.Save(obj_KT_H_COT)
                '    Else
                '        _KtHCotService.SaveOrUpdate(drw)
                '    End If
                'Next

                ''insert dieu kien
                'dv_CHITIET = CType(grv_CHI_TIET.DataSource, IList(Of KtDieukienBc))
                'For Each drw_ChiTiet As KtDieukienBc In dv_CHITIET
                '    drw_ChiTiet.IdDong = m_kt_h_Dong

                '    If (VnsCheck.IsNullGuid(drw_ChiTiet.Id)) Then
                '        _KtDieukienBcService.Save(drw_ChiTiet)
                '    Else
                '        _KtDieukienBcService.SaveOrUpdate(drw_ChiTiet)
                '    End If
                'Next
                'Delete

        End Select
    End Sub

#End Region

#Region "Events"

    Private Sub btnXacNhan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Try
            'Check kiem tra du lieu nhap tren form
            If (Panel_CheckError(grc1) And Panel_CheckError(grc2)) Then
                frmProgress.Instance.Thread = AddressOf GetControlToObject
                frmProgress.Instance.Show_Progress()

                frmProgress.Instance.SetFinishText("Ghi dữ liệu thành công")
                DialogResult = System.Windows.Forms.DialogResult.OK
            End If
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnRow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRow.Click
        'Try
        '    Select Case xtcMAIN.SelectedTabPageIndex
        '        Case 0
        '            Grid_AddRow(grv_KT_COT)
        '        Case 1
        '            Grid_AddRow(grv_CHI_TIET)
        '    End Select
        'Catch ex As Exception
        '    Message_Error(ex)
        'End Try
    End Sub

    Private Sub btnDeR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeR.Click
        'Try
        '    Select Case xtcMAIN.SelectedTabPageIndex
        '        Case 0
        '            Grid_DeleteSelectRows(grv_KT_COT)
        '        Case 1
        '            Grid_DeleteSelectRows(grv_CHI_TIET)
        '    End Select
        'Catch ex As Exception
        '    Message_Error(ex)
        'End Try
    End Sub

    Private Sub grc_KT_COT_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        'If e.KeyCode = Keys.Enter Then
        '    If grv_KT_COT.IsLastRow Then
        '        If grv_KT_COT.FocusedColumn.AbsoluteIndex = grv_KT_COT.Columns.ColumnByName("DK_MA_DM_KHOANPHI_DU").AbsoluteIndex Then
        '            CType(grv_KT_COT.DataSource, DataView).AddNew()
        '            grv_KT_COT.RefreshData()
        '            grv_KT_COT.FocusedRowHandle() = grv_KT_COT.RowCount - 2
        '        End If
        '    End If
        '    If grv_KT_COT.IsEmpty Then
        '        CType(grv_KT_COT.DataSource, DataView).AddNew()
        '        grv_KT_COT.RefreshData()
        '        Return
        '    End If
        '    SendKeys.Send("{TAB}")
        'End If
    End Sub

    Private Sub frmKhaiBaoChiTieu_ChiTiet_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Try
            Select Case e.KeyCode
                Case Keys.Escape
                    Me.Close()
                    'Case Keys.F4
                    '    If (xtcMAIN.SelectedTabPageIndex = 0) Then
                    '        Grid_AddRow(grv_KT_COT)
                    '    ElseIf (xtcMAIN.SelectedTabPageIndex = 1) Then
                    '        Grid_AddRow(grv_CHI_TIET)
                    '    End If
                    'Case Keys.F8
                    '    If (xtcMAIN.SelectedTabPageIndex = 0) Then
                    '        If grv_KT_COT.RowCount <> 0 Then
                    '            Grid_DeleteSelectRows(grv_KT_COT)
                    '        Else
                    '            Message_Warning("Không có bản ghi nào được chọn!")
                    '        End If
                    '    ElseIf (xtcMAIN.SelectedTabPageIndex = 1) Then
                    '        If grv_CHI_TIET.RowCount <> 0 Then
                    '            Grid_DeleteSelectRows(grv_CHI_TIET)
                    '        Else
                    '            Message_Warning("Không có bản ghi nào được chọn!")
                    '        End If
                    '    End If
            End Select
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub grc_CHI_TIET_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        'If e.KeyCode = Keys.Enter Then
        '    If grv_CHI_TIET.IsLastRow Then
        '        If grv_CHI_TIET.FocusedColumn.AbsoluteIndex = grv_CHI_TIET.Columns.ColumnByName("DK_MA_DM_KHOANPHI_DU_CT").AbsoluteIndex Then
        '            CType(grv_CHI_TIET.DataSource, DataView).AddNew()
        '            grv_CHI_TIET.RefreshData()
        '            grv_CHI_TIET.FocusedRowHandle() = grv_CHI_TIET.RowCount - 2
        '        End If
        '    End If
        '    If grv_CHI_TIET.IsEmpty Then
        '        CType(grv_CHI_TIET.DataSource, DataView).AddNew()
        '        grv_CHI_TIET.RefreshData()
        '        Return
        '    End If
        '    SendKeys.Send("{TAB}")
        'End If
    End Sub
#End Region

    
End Class