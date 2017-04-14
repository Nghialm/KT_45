Imports Vns.Erp.Core.Admin.Service.Interface
Imports Vns.Erp.Core.Admin.Domain

Public Class frmKhaiBaoGiamCCDC_DanhSach

#Region "Properties"

    Private _CcCtCcdcService As ICcCtCcdcService
    Public Property CcCtCcdcService As ICcCtCcdcService
        Get
            Return _CcCtCcdcService
        End Get
        Set(ByVal value As ICcCtCcdcService)
            _CcCtCcdcService = value
        End Set
    End Property

    Private _CcDmCcdcService As ICcDmCcdcService
    Public Property CcDmCcdcService() As ICcDmCcdcService
        Get
            Return _CcDmCcdcService
        End Get
        Set(ByVal value As ICcDmCcdcService)
            _CcDmCcdcService = value
        End Set
    End Property

#End Region

#Region "Variables"
    Private CT_CCDC_id As Guid
    Private objCtcdc As CcCtCcdc
#End Region

#Region "Contructor"
    Public Sub New()
        InitializeComponent()
        TNCommon.setIconControl(Me)
    End Sub
#End Region

#Region "Functions"

    Private Sub DoLoadData()
        Dim lstCT_CCDC As List(Of CcCtCcdc) = New List(Of CcCtCcdc)
        lstCT_CCDC.AddRange(_CcCtCcdcService.GetByTrangThai(2))
        _gridControl.DataSource = lstCT_CCDC
    End Sub

    Private Sub grv_focus()
        TNCommon.GridView_SetRowFocus(_gridView, "MaCcdc", objCtcdc.MaCcdc)
    End Sub

    Private Sub DoCreate()
        Dim frm As frmKhaiBaoGiamCCDC_ChiTiet = CType(ObjectFactory.GetObject("frmKhaiBaoGiamCCDC_ChiTiet"), frmKhaiBaoGiamCCDC_ChiTiet)
        objCtcdc = frm.Show_Form(Nothing, DataInputState.AddMode)
        If objCtcdc IsNot Nothing Then
            Me.DoLoadData()
            grv_focus()
        End If
    End Sub

    Private Sub DoModify()
        If _gridView.RowCount <> 0 Then
            Dim i As Integer = _gridView.FocusedRowHandle

            If i < 0 Then
                Message_Warning("Không có bản ghi nào được lựa chọn")
                Return
            End If
            CT_CCDC_id = CType(_gridView.GetRow(i), CcCtCcdc).Id
            Dim frm As frmKhaiBaoGiamCCDC_ChiTiet = CType(ObjectFactory.GetObject("frmKhaiBaoGiamCCDC_ChiTiet"), frmKhaiBaoGiamCCDC_ChiTiet)
            objCtcdc = frm.Show_Form(CT_CCDC_id, DataInputState.EditMode)
            If objCtcdc IsNot Nothing Then
                Me.DoLoadData()
                _gridView.FocusedRowHandle = i
            End If
        Else
            Message_Warning("Không có bản ghi nào được lựa chọn")
        End If
    End Sub

    Private Sub DoDelete()
        If _gridView.RowCount <> 0 Then

            Dim i As Integer = _gridView.FocusedRowHandle

            If i < 0 Then
                Message_Warning("Không có bản ghi nào được lựa chọn")
                Return
            End If
            CT_CCDC_id = CType(_gridView.GetRow(i), CcCtCcdc).Id
            If Message_Confirm("Bạn chắc chắn muốn xóa bản ghi này?") Then
                CcDmCcdcService.DeleteKhaiBaoGiamCcdc(CT_CCDC_id, 2)
                Me.DoLoadData()
            End If
        Else
            Message_Warning("Không có bản ghi nào được lựa chọn")
        End If
    End Sub

#End Region

#Region "Events"

    Private Sub frmKhaiBaoGiamCCDC_DanhSach_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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