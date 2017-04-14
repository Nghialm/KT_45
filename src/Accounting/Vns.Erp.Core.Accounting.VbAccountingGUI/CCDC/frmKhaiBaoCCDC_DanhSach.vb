Imports Vns.Erp.Core.Admin.Domain
Imports Vns.Erp.Core.Admin.Service.Interface

Public Class frmKhaiBaoCCDC_DanhSach

#Region "Properties"
    Private _CcDmCcdcService As ICcDmCcdcService
    Public Property CcDmCcdcService As ICcDmCcdcService
        Get
            Return _CcDmCcdcService
        End Get
        Set(ByVal value As ICcDmCcdcService)
            _CcDmCcdcService = value
        End Set
    End Property


    Private _CcCtCcdcService As ICcCtCcdcService
    Public Property CcCtCcdcService() As ICcCtCcdcService
        Get
            Return _CcCtCcdcService
        End Get
        Set(ByVal value As ICcCtCcdcService)
            _CcCtCcdcService = value
        End Set
    End Property


    Private _CcCtCcdcNvonService As ICcCtCcdcNvonService
    Public Property CcCtCcdcNvonService() As ICcCtCcdcNvonService
        Get
            Return _CcCtCcdcNvonService
        End Get
        Set(ByVal value As ICcCtCcdcNvonService)
            _CcCtCcdcNvonService = value
        End Set
    End Property


#End Region

#Region "Variables"
    Private CCDC_id As Guid
    Private objDmCcdc As CcDmCcdc
#End Region

#Region "Contructor"
    Public Sub New()
        InitializeComponent()
        TNCommon.setIconControl(Me)
    End Sub
#End Region

#Region "Functions"

    Private Sub DoLoadData()
        Dim lstCCDC As List(Of CcDmCcdc) = New List(Of CcDmCcdc)
        lstCCDC.AddRange(_CcDmCcdcService.GetAllByDonviID(Generals.DON_VI.Id))
        grcCCDC.DataSource = lstCCDC
    End Sub

    Private Sub grv_focus()
        TNCommon.GridView_SetRowFocus(grvCCDC, "MaCcdc", objDmCcdc.MaCcdc)
    End Sub

    Private Sub DoCreate()
        Dim frm As frmKhaiBaoCCDC_ChiTiet = CType(ObjectFactory.GetObject("frmKhaiBaoCCDC_ChiTiet"), frmKhaiBaoCCDC_ChiTiet)
        objDmCcdc = frm.Show_Form(Nothing, DataInputState.AddMode)
        If objDmCcdc IsNot Nothing Then
            Me.DoLoadData()
            grv_focus()
        End If
    End Sub

    Private Sub DoModify()
        If grvCCDC.RowCount <> 0 Then
            Dim i As Integer = grvCCDC.FocusedRowHandle

            If i < 0 Then
                Message_Warning("Không có bản ghi nào được lựa chọn")
                Return
            End If

            CCDC_id = CType(grvCCDC.GetRow(i), CcDmCcdc).Id

            Dim frm As frmKhaiBaoCCDC_ChiTiet = CType(ObjectFactory.GetObject("frmKhaiBaoCCDC_ChiTiet"), frmKhaiBaoCCDC_ChiTiet)
            objDmCcdc = frm.Show_Form(CCDC_id, DataInputState.EditMode)
            If objDmCcdc IsNot Nothing Then
                Me.DoLoadData()
                grvCCDC.FocusedRowHandle = i
            End If
        Else
            Message_Warning("Không có bản ghi nào được lựa chọn")
        End If
    End Sub

    Private Sub DoDelete()
        If grvCCDC.RowCount <> 0 Then

            Dim i As Integer = grvCCDC.FocusedRowHandle

            If i < 0 Then
                Message_Warning("Không có bản ghi nào được lựa chọn")
                Return
            End If
            CCDC_id = CType(grvCCDC.GetRow(i), CcDmCcdc).Id
            If Message_Confirm("Bạn chắc chắn muốn xóa bản ghi này?") Then
                CcDmCcdcService.DeleteCCDC(CCDC_id)
                Me.DoLoadData()
            End If
        Else
            Message_Warning("Không có bản ghi nào được lựa chọn")
        End If
    End Sub

#End Region

#Region "Events"

    Private Sub frmKhaiBaoCCDC_DanhSach_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            DoLoadData()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Try
            DoCreate()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub btnModify_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModify.Click
        Try
            DoModify()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Try
            DoDelete()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

#End Region

End Class