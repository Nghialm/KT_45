Imports System
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Windows.Forms
Imports System.Collections
Imports Vns.Erp.Core.Admin.Domain
Imports Vns.Erp.Core.Admin.Service.Interface

Public Class frmDanhMucLoaiTaiSan1_ChiTiet

#Region "Variables and Messages"
    Private m_InputState As FormGlobals.DataInputState
    Private m_ID As Guid
    Private objInfo As DmLoaitaisan
    Private p_ma As String
    Dim _DmLoaiTaisanService As IDmLoaitaisanService
    Public Property ID() As Guid
        Get
            Return m_ID
        End Get
        Set(value As Guid)
            m_ID = value
        End Set
    End Property

    Public Overridable Property DmLoaiTaisanService() As IDmLoaitaisanService
        Get
            Return _DmLoaiTaisanService
        End Get
        Set(ByVal value As IDmLoaitaisanService)
            _DmLoaiTaisanService = value
        End Set
    End Property
#End Region

#Region "Load Form"

    Public Sub New()
        InitializeComponent()
        TNCommon.setIconControl(Me)
    End Sub

    Public Function Show_Form(ByVal iID As String, ByVal eState As DataInputState) As Guid
        Try
            Form_SetText(Me, "Danh mục loại tài sản chi tiết", DataInputState.NoCaption)
            Form_InitDialog(Me)

            m_InputState = eState
            If (eState.Equals(DataInputState.EditMode)) Then
                m_ID = New Guid(iID)
            Else
                m_ID = Guid.NewGuid()
            End If

            frmProgress.Instance.Thread = AddressOf Init_Form
            frmProgress.Instance.Show_Progress()
        Catch ex As Exception
            Message_Error(ex)
        End Try

        If (Me.ShowDialog = DialogResult.OK) Then
            Return m_ID
        Else
            Return Nothing
        End If
    End Function

#End Region

#Region "Private Function and Procedures"

    Private Sub Init_Control()
        Control_SetRequire(txtKy_Hieu, True)
        Control_SetRequire(cboLOAITAISAN_ID_CHA, True)
        Control_SetRequire(txtTEN_LOAITAISAN, True)
        Control_SetFont(Me, CS_FONT_NAME)
        'Panel_InitControl(Me._GroupControlObjectInfo, "DM_LOAITAISAN")
    End Sub

    Private Sub Init_Form()
        Init_Control()
        Init_Data()
    End Sub
    Private Sub ClearForm()
        Me.txtKHUNG_TGSD1.Text = ""
        Me.txtKy_Hieu.Text = ""
        Me.txtTEN_LOAITAISAN.Text = ""
    End Sub
    Private Sub Init_Data()
        Select Case m_InputState
            Case DataInputState.AddMode
                BindLookUpEdit()
                ClearForm()
                TNCommon.SelectFirst(cboLOAITAISAN_ID_CHA)
            Case DataInputState.EditMode
                BindLookUpEdit()
                Load_Data()
        End Select
    End Sub

    Private Sub Load_Data()
        objInfo = DmLoaiTaisanService.GetById(m_ID)
        p_ma = objInfo.KyHieu
        Me.txtKy_Hieu.Text = objInfo.KyHieu
        Me.txtTEN_LOAITAISAN.Text = objInfo.TenLoaitaisan
        Me.txtKHUNG_TGSD1.Text = objInfo.KhungTgsd.ToString
        Me.cboLOAITAISAN_ID_CHA.EditValue = objInfo.LoaitaisanIdCha.ToString
        'Panel_SetControlValue(Me._GroupControlObjectInfo, objInfo, True)
        txtKHUNG_TGSD1.Text = objInfo.KhungTgsd.ToString
        If objInfo.LoaitaisanIdCha = Nothing Then
            cboLOAITAISAN_ID_CHA.EditValue = Nothing
        Else
            cboLOAITAISAN_ID_CHA.EditValue = objInfo.LoaitaisanIdCha
        End If

        chkCO_SU_DUNG.Checked = TNCommon.ParseBool(objInfo.CoSuDung)
    End Sub

    Private Sub Save_Data()
        If objInfo Is Nothing Then
            objInfo = New DmLoaitaisan
        End If
        objInfo.KyHieu = Me.txtKy_Hieu.Text
        objInfo.TenLoaitaisan = txtTEN_LOAITAISAN.Text
        objInfo.CoSuDung = TNCommon.ParseDecimal(chkCO_SU_DUNG.Checked)
        objInfo.LoaitaisanIdCha = New Guid(cboLOAITAISAN_ID_CHA.EditValue.ToString())
        If txtKHUNG_TGSD1.Text <> "" Then
            objInfo.KhungTgsd = Decimal.Parse(txtKHUNG_TGSD1.Text)
        End If

        'Try
        If m_InputState = DataInputState.AddMode OrElse m_InputState = DataInputState.CopyMode Then
            objInfo.MaLoaitaisan = " "
            objInfo.Id = New Guid()
            DmLoaiTaisanService.SaveOrUpdate(objInfo)
            m_ID = objInfo.Id
        Else
            DmLoaiTaisanService.SaveOrUpdate(objInfo)
            m_ID = objInfo.Id
        End If
        frmProgress.Instance.SetFinishText("Data saved")
        'Catch ex As Exception
        '    Message_Error(ex)
        'End Try

    End Sub

    Private Sub BindLookUpEdit()
        'Bind danh muc cha
        Dim dr As DmLoaitaisan
        Dim dt As List(Of DmLoaitaisan) = New List(Of DmLoaitaisan)
        dt.AddRange(DmLoaiTaisanService.GetAll())
        dr = New DmLoaitaisan()
        dr.TenLoaitaisan = "Danh mục gốc"
        dr.Id = Guid.Empty
        dr.MaLoaitaisan = ""
        dr.Cap = 1
        dt.Insert(0, dr)


        cboLOAITAISAN_ID_CHA.Properties.ValueMember = "Id"
        cboLOAITAISAN_ID_CHA.Properties.DisplayMember = "TenLoaitaisan"
        cboLOAITAISAN_ID_CHA.Properties.DataSource = dt
    End Sub

    Private Function Check_KH(ByVal KH As String) As Boolean
        Dim dt As List(Of DmLoaitaisan) = New List(Of DmLoaitaisan)
        dt.AddRange(DmLoaiTaisanService.GetByKyHieu(KH))
        If dt.Count <> 0 Then
            Message_Warning("Ký hiệu loại tài sản đã tồn tại")
            txtKy_Hieu.Focus()
            Return False
        End If
        Return True
    End Function

    Private Function Check_input() As Boolean
        If (txtKy_Hieu.Text = "" Or txtTEN_LOAITAISAN.Text = "" Or DB_GetString(cboLOAITAISAN_ID_CHA.EditValue) = "") Then
            Message_Warning("Bạn chưa nhập giá trị cho các trường bắt buộc")
            Return False
        End If

        If txtKHUNG_TGSD1.Text <> "" Then
            Dim Nam As Decimal = Decimal.Parse(txtKHUNG_TGSD1.Text)
            If Nam < 0 Or Nam > 9999.99 Then
                Message_Warning("Số Năm sử dụng không hợp lệ!")
                txtKHUNG_TGSD1.Focus()
                Return False
            End If
        End If

        If DB_GetString(cboLOAITAISAN_ID_CHA.EditValue) = "" Then
            Message_Warning("Bạn chưa chọn danh mục cha!")
            cboLOAITAISAN_ID_CHA.Focus()
            Return False
        End If

        Return True
    End Function
#End Region

#Region "Events"

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Try
            Me.Close()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        Try
            Control_ClearData(_GroupControlObjectInfo)
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Try
            Dim kh As String = ""
            Select Case m_InputState
                Case DataInputState.AddMode
                    kh = txtKy_Hieu.Text
                Case DataInputState.EditMode
                    If Not p_ma.Equals(txtKy_Hieu.Text) Then
                        kh = txtKy_Hieu.Text
                    Else
                        kh = ""
                    End If
            End Select

            If Not Check_KH(kh) Then
                Exit Sub
            End If

            If Check_input() Then
                frmProgress.Instance.Thread = AddressOf Save_Data
                frmProgress.Instance.Show_Progress("Saving data")
                DialogResult = Windows.Forms.DialogResult.OK
            End If
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub frmDanhMucTuDo1_ChiTiet_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Try
            Select Case e.KeyCode
                Case Keys.Escape
                    Me.Close()
                    Exit Select
            End Select
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

#End Region

End Class

