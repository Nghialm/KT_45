Imports System.Collections.Generic
Imports System.Windows.Forms
Imports System
Imports Vns.Erp.Core.Admin.Domain
Imports Vns.Erp.Core.Admin.Service.Interface




Public Class frmLS_TyGiaNgoaiTe_DanhSach
    Inherits FrmBaseDmDanhSach
    Dim LSNT As Guid
    Private lstobj_ls_nt As List(Of LsTygia) = New List(Of LsTygia)
    Private _Ma_Ngoaite As String = String.Empty
    Dim _LsTygiaService As ILsTygiaService
    Public Property LsTygiaService() As ILsTygiaService
        Get
            Return _LsTygiaService
        End Get
        Set(value As ILsTygiaService)
            _LsTygiaService = value
        End Set
    End Property
    Public Sub New()
        InitializeComponent()
        TNCommon.setIconControl(Me)
    End Sub

    Public Property MaTruyen() As String
        Get
            Return _Ma_Ngoaite
        End Get
        Set(ByVal value As String)
            _Ma_Ngoaite = value
        End Set
    End Property

    Private Function GetRowSelect() As Boolean
        Dim selrow As Integer = 0
        If (_GridView.GetSelectedRows().Length > 0) Then
            If (_GridView.RowCount <> 0) Then
                Dim gridnvt1 As LsTygia = CType(_GridView.GetRow(_GridView.GetSelectedRows(0)), LsTygia)
                LSNT = gridnvt1.Id
                Return True
            End If
        End If
        Return False
    End Function

    Private Sub frmLS_TyGiaNgoaiTe_DanhSach_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            If (_Ma_Ngoaite <> Nothing And (_Ma_Ngoaite <> Guid.Empty.ToString())) Then
                invaData()
            Else
                LoadGird()
                For i As Integer = 0 To _GridView.Columns.Count - 1
                    _GridView.Columns(i).OptionsColumn.ReadOnly = True
                Next
            End If
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub LoadGird()
        Dim lstobj_ls_nt As List(Of LsTygia) = New List(Of LsTygia)
        lstobj_ls_nt.AddRange(LsTygiaService.GetAll())
        _GridControl.DataSource = lstobj_ls_nt
    End Sub

    Private Sub invaData()
        'Dim lstobjlsnt As List(Of LsTygia) = LsTygiaService.GetObjectByDoiTuong(_Ma_Ngoaite)
        Dim lstobjlsnt As List(Of LsTygia) = New List(Of LsTygia)
        lstobjlsnt.AddRange(LsTygiaService.GetTyGiaByNgoaiTeId(New Guid(_Ma_Ngoaite)))
        _GridControl.DataSource = lstobjlsnt
    End Sub

    Private Sub SimpleButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Try
            Me.Close()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub _GridView_FocusedRowChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles _GridView.FocusedRowChanged
        Try
            If (_GridView.RowCount <> 0) Then
                Dim gridcth As LsTygia = CType(_GridView.GetRow(_GridView.FocusedRowHandle), LsTygia)
                LSNT = gridcth.Id
            End If
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub btnCreate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCreate.Click
        Try
            If (_Ma_Ngoaite <> Nothing) Then
                Dim f As frmLS_TyGiaNgoaiTe_ChiTiet = ObjectFactory.GetObject("frmLS_TyGiaNgoaiTe_ChiTiet")
                If f.Show_Form(New Guid(_Ma_Ngoaite), DataInputState.AddMode) Then
                    Me.invaData()
                End If
            Else
                Dim f As frmLS_TyGiaNgoaiTe_ChiTiet = ObjectFactory.GetObject("frmLS_TyGiaNgoaiTe_ChiTiet")
                If f.Show_Form(New Guid(_Ma_Ngoaite), DataInputState.AddMode) Then
                    Me.LoadGird()
                End If
            End If
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModify.Click
        Try
            sua()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub sua()
        Try
            If (_GridView.RowCount = 0) Then
                MessageBox.Show("Bạn chưa chọn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            Else
                If (GetRowSelect()) Then
                    If (_Ma_Ngoaite <> Nothing) Then
                        Dim f As frmLS_TyGiaNgoaiTe_ChiTiet = ObjectFactory.GetObject("frmLS_TyGiaNgoaiTe_ChiTiet")
                        If f.Show_Form(LSNT, DataInputState.EditMode) Then
                            Me.invaData()
                        End If
                    Else


                        Dim f As frmLS_TyGiaNgoaiTe_ChiTiet = ObjectFactory.GetObject("frmLS_TyGiaNgoaiTe_ChiTiet")
                        If f.Show_Form(LSNT, DataInputState.EditMode) Then
                            Me.LoadGird()
                        End If
                    End If


                End If
            End If
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Try
            xoa()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub xoa()
        If (_GridView.RowCount = 0) Then
            MessageBox.Show("Bạn chưa chọn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        Else
            If (GetRowSelect()) Then
                If (MessageBox.Show("Bạn muốn xóa hay không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> DialogResult.Yes) Then Return
                LsTygiaService.DeleteById(LSNT)
                Me.LoadGird()
            End If
        End If
    End Sub

End Class

