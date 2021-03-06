Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Base

Imports Vns.Erp.Core.Admin.Domain
Imports Vns.Erp.Core.Admin.Service
Imports Vns.Erp.Core.Admin.Service.Interface

Public Class frmDieuChuyenTaiSan_ChiTiet

#Region "Variables"

    Private m_InputState As DataInputState
    Private m_DM_TSCD_ID As Guid
    Private m_ts_dc As Guid
    Private lst_tscd As List(Of DmTscd) = New List(Of DmTscd)
    Private lst_tsdc As List(Of TsDieuchuyen) = New List(Of TsDieuchuyen)
    Private obj_tscd As DmTscd = New DmTscd
    Private obj_tsdc As TsDieuchuyen = New TsDieuchuyen
    Private str_pb_hienTai As Guid
#End Region

#Region "Property"
    Private _DmTscdService As IDmTscdService
    Public Property DmTscdService() As IDmTscdService
        Get
            Return _DmTscdService
        End Get
        Set(ByVal value As IDmTscdService)
            _DmTscdService = value
        End Set
    End Property

    Private _TsDieuchuyenService As ITsDieuchuyenService
    Public Property TsDieuchuyenService() As ITsDieuchuyenService
        Get
            Return _TsDieuchuyenService
        End Get
        Set(ByVal value As ITsDieuchuyenService)
            _TsDieuchuyenService = value
        End Set
    End Property

    Private _DmPhongbanService As IDmPhongbanService
    Public Property DmPhongbanService() As IDmPhongbanService
        Get
            Return _DmPhongbanService
        End Get
        Set(ByVal value As IDmPhongbanService)
            _DmPhongbanService = value
        End Set
    End Property
#End Region

#Region "Show_form"

    Public Sub New()
        InitializeComponent()
        TNCommon.setIconControl(Me)
    End Sub

    Public Function Show_Form(ByVal p_DM_TSCD_ID As Guid, ByVal p_TS_DC As Guid, ByVal eState As DataInputState) As Boolean
        Try
            Form_SetText(Me, "Điều chuyển tài sản cố định", eState)
            Form_InitDialog(Me)
            m_InputState = eState
            m_DM_TSCD_ID = p_DM_TSCD_ID
            m_ts_dc = p_TS_DC
            obj_tscd = _DmTscdService.GetById(m_DM_TSCD_ID)
            lst_tsdc = New List(Of TsDieuchuyen)
            lst_tsdc.AddRange(_TsDieuchuyenService.GetObjectByTSCD_ID(m_DM_TSCD_ID))
            frmProgress.Instance.Thread = AddressOf Init_Data
            frmProgress.Instance.Show_Progress()
        Catch ex As Exception
            Message_Error(ex)
        End Try

        Return (Me.ShowDialog = DialogResult.OK)
    End Function

#End Region

#Region "Private functions"

    Private Sub Init_Data()
        Select Case m_InputState
            Case DataInputState.AddMode
                bindLookUp()
                GanGT()
                dteNGAY_DC.DateTime = Date.Now
                Dim str As String = txtLY_DO_DC.Text
            Case DataInputState.EditMode
                bindLookUp()
                SetObjectToControl()
        End Select
    End Sub

    Private Sub bindLookUp()
        'bind  phong ban
        Dim objColumnDefine As ArrayList
        Dim lstDM_PB As New List(Of DmPhongban)
        lstDM_PB.AddRange(_DmPhongbanService.GetAllByDonviID(Generals.DON_VI.Id))
        objColumnDefine = New ArrayList
        objColumnDefine.Add(New LookupEdit_ColumnInfo("KyHieu", "Ký hiệu"))
        objColumnDefine.Add(New LookupEdit_ColumnInfo("TenPhongban", "Tên phòng ban"))
        GridLookupEdit_BindData(grlPHONG_BAN_DC, lstDM_PB, "TenPhongban", "Id", COMBO_ITEM_REQUIRE, objColumnDefine)
    End Sub

    Private Sub GetControlToObject()

        Dim THU_TU As Integer = _TsDieuchuyenService.GetObjectByTSCD_ID(obj_tscd.Id).Count + 1
        obj_tsdc.TscdId = obj_tscd.Id
        obj_tsdc.MaTscd = obj_tscd.MaTscd
        obj_tsdc.TenTscd = obj_tscd.TenTscd
        obj_tsdc.KyHieuTscd = obj_tscd.KyHieu
        If (grlPHONG_BAN_DC.EditValue <> Nothing) Then
            obj_tsdc.BoPhanDcId = grlPHONG_BAN_DC.EditValue
        End If
        obj_tsdc.NgayDc = dteNGAY_DC.DateTime
        obj_tsdc.LyDoDc = txtLY_DO_DC.Text
        Select Case m_InputState
            Case DataInputState.AddMode
                obj_tsdc.ThuTu = THU_TU
                obj_tsdc.NguoiTao = Generals.USER.Id
                _TsDieuchuyenService.Save(obj_tsdc)
            Case DataInputState.EditMode
                obj_tsdc.NguoiSua = Generals.USER.Id
                _TsDieuchuyenService.SaveOrUpdate(obj_tsdc)
        End Select
    End Sub

    Private Sub SetObjectToControl()
        GanGT()
        obj_tsdc = _TsDieuchuyenService.GetById(m_ts_dc)
        grlPHONG_BAN_DC.EditValue = obj_tsdc.BoPhanDcId
        dteNGAY_DC.DateTime = DB_GetString(DB_GetNull(obj_tsdc.NgayDc))
        txtLY_DO_DC.Text = obj_tsdc.LyDoDc
    End Sub

    Private Sub GanGT()
        txtMA_TSCD.Text = obj_tscd.MaTscd
        txtTenTS.Text = obj_tscd.TenTscd
        txtNGAY_MUA.Text = DB_GetString(DB_GetNull(obj_tscd.NgayMua))
        If (lst_tsdc.Count = 0) Then
            txtPHONG_BAN_HT.Text = obj_tscd.TenPhongban
            str_pb_hienTai = obj_tscd.PhongbanId
        Else
            Select Case m_InputState
                Case DataInputState.AddMode
                    For Each obj As TsDieuchuyen In lst_tsdc
                        If (obj.ThuTu = lst_tsdc.Count And obj.ThuTu <> Nothing) Then
                            Dim obj_PB As DmPhongban = _DmPhongbanService.GetById(obj.BoPhanDcId)
                            txtPHONG_BAN_HT.Text = DB_GetString(obj_PB.TenPhongban)
                            str_pb_hienTai = obj_PB.Id
                        End If
                    Next
                Case DataInputState.EditMode
                    If (lst_tsdc.Count = 1) Then
                        txtPHONG_BAN_HT.Text = DB_GetString(obj_tscd.TenPhongban)
                        str_pb_hienTai = obj_tscd.PhongbanId
                    Else
                        For Each obj As TsDieuchuyen In lst_tsdc
                            If (obj.ThuTu = lst_tsdc.Count - 1 And obj.ThuTu <> Nothing) Then
                                Dim obj_PB As DmPhongban = _DmPhongbanService.GetById(obj.BoPhanDcId)
                                txtPHONG_BAN_HT.Text = DB_GetString(obj_PB.TenPhongban)
                                str_pb_hienTai = obj_PB.Id
                            End If
                        Next
                    End If
            End Select
        End If
    End Sub

#End Region

#Region "Events"

    Private Sub frmDieuChuyenTaiSan_ChiTiet_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Try
            Select Case e.KeyCode
                Case Keys.Escape
                    Me.Close()
            End Select
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Try
            If DB_GetString(DB_GetNull(dteNGAY_DC.DateTime)) = "" Then
                Message_Warning("Bạn chưa nhập ngày điều chuyển!")
                dteNGAY_DC.Focus()
                Exit Sub
            Else
                If DB_GetString(DB_GetNull(obj_tscd.NgayMua)) <> "" Then
                    If dteNGAY_DC.DateTime < obj_tscd.NgayMua Then
                        Message_Warning("Ngày điều chuyển phải >=Ngày mua")
                        dteNGAY_DC.Focus()
                        Exit Sub
                    End If
                End If
            End If
            If DB_GetString(grlPHONG_BAN_DC.EditValue) = "" Then
                Message_Information("Bạn chưa nhập phòng ban điều chuyển đến")
                grlPHONG_BAN_DC.Focus()
                Exit Sub
            Else
                If grlPHONG_BAN_DC.EditValue = str_pb_hienTai Then
                    Message_Information("Phòng ban điều chuyển đến không hợp lệ!")
                    grlPHONG_BAN_DC.Focus()
                    Exit Sub
                End If
            End If

            frmProgress.Instance.Thread = AddressOf GetControlToObject
            frmProgress.Instance.Show_Progress()
            frmProgress.Instance.SetFinishText("Ghi dữ liệu thành công")
            DialogResult = System.Windows.Forms.DialogResult.OK
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Try
            Me.Close()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

#End Region

End Class