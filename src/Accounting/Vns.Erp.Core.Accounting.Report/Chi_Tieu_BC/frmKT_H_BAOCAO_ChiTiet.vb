Imports Vns.Erp.Core.Admin.Domain
Imports Vns.Erp.Core.Admin.Service.Interface

Public Class frmKT_H_BAOCAO_ChiTiet

#Region "Property"
    Private _KtHBaocaoService As IKtHBaocaoService
    Public Property KtHBaocaoService As IKtHBaocaoService
        Get
            Return _KtHBaocaoService
        End Get
        Set(ByVal value As IKtHBaocaoService)
            _KtHBaocaoService = value
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

    Private m_kt_h_BaoCao As Guid
    Private m_InputState As DataInputState
    Private obj_KT_H_BAOCAO As KtHBaocao
#End Region

#Region "Show_form"

    Public Function Show_form(ByVal p_kt_h_BaoCao As Guid, ByVal p_InputState As DataInputState) As Boolean
        Try
            m_kt_h_BaoCao = p_kt_h_BaoCao
            m_InputState = p_InputState
            Form_InitDialog(Me)
            'Panel_InitControl(grc_KT_H_BAOCAO, "KT_H_BAOCAO")
            Control_SetRequire(txtTITLE, True)
            frmProgress.Instance.Thread = AddressOf Init_Data
            frmProgress.Instance.Show_Progress()

        Catch ex As Exception
            Message_Error(ex)
        End Try
        Return Me.ShowDialog = DialogResult.OK
    End Function
#End Region

#Region "Private functions"

    Private Sub Init_Data()
        Select Case m_InputState
            Case DataInputState.EditMode
                SetObjectToControl()
                btnKhaiBaoChiTieu.Visible = True
            Case DataInputState.AddMode
                btnKhaiBaoChiTieu.Visible = False
        End Select
    End Sub

    Private Sub SetObjectToControl()
        obj_KT_H_BAOCAO = New KtHBaocao
        obj_KT_H_BAOCAO = _KtHBaocaoService.GetById(m_kt_h_BaoCao)
        'Panel_SetControlValue(grc_KT_H_BAOCAO, obj_KT_H_BAOCAO)
        txtMA_BAOCAO.Text = obj_KT_H_BAOCAO.MaBaocao
        txtTITLE.Text = obj_KT_H_BAOCAO.Title
        txtSO_COT.Text = obj_KT_H_BAOCAO.SoCot
        txtSO_DONG.Text = obj_KT_H_BAOCAO.SoDong
    End Sub

    Private Sub GetControlToObject()
        If obj_KT_H_BAOCAO Is Nothing Then
            obj_KT_H_BAOCAO = New KtHBaocao
        End If
        'Panel_GetControlValue(grc_KT_H_BAOCAO, obj_KT_H_BAOCAO)
        obj_KT_H_BAOCAO.MaBaocao = txtMA_BAOCAO.Text
        obj_KT_H_BAOCAO.Title = txtTITLE.Text
        obj_KT_H_BAOCAO.SoCot = txtSO_COT.Text
        obj_KT_H_BAOCAO.SoDong = txtSO_DONG.Text
        Select Case m_InputState
            Case DataInputState.AddMode
                _KtHBaocaoService.Save(obj_KT_H_BAOCAO)
            Case DataInputState.EditMode
                _KtHBaocaoService.SaveOrUpdate(obj_KT_H_BAOCAO)
        End Select
    End Sub

#End Region

#Region "Events"

    Private Sub btnXacNhan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnXacNhan.Click
        Try
            'Check kiem tra du lieu nhap tren form
            If (Panel_CheckError(grc_KT_H_BAOCAO)) Then
                If (txtTITLE.Text = Nothing) Then
                    Message_Information("bạn chưa nhập tên báo cáo")
                    Exit Sub
                End If
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
        Try
            Me.Close()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub btnKhaiBaoChiTieu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKhaiBaoChiTieu.Click
        Try
            Dim frm As frmKhaiBaoChiTieu_DanhSach = CType(ObjectFactory.GetObject("frmKhaiBaoChiTieu_DanhSach"), frmKhaiBaoChiTieu_DanhSach)
            frm.Show_form(m_kt_h_BaoCao)
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub frmKT_H_BAOCAO_ChiTiet_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Try
            Select Case e.KeyCode
                Case Keys.Escape
                    Me.Close()
            End Select
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub
#End Region


End Class