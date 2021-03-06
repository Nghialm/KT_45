Imports Vns.Erp.Core.Admin.Domain
Imports Vns.Erp.Core.Admin.Service.Interface

Public Class frmButToanKetChuyen_DanhSach
    Inherits DevExpress.XtraEditors.XtraForm
    Dim DMBTKC As Guid
    Dim _DmBtKetchuyenService As IDmBtKetchuyenService
    Public Property DmBtKetchuyenService() As IDmBtKetchuyenService
        Get
            Return _DmBtKetchuyenService
        End Get
        Set(value As IDmBtKetchuyenService)
            _DmBtKetchuyenService = value
        End Set
    End Property
    Public Sub New()
        InitializeComponent()
        TNCommon.setIconControl(Me)
    End Sub

    Private Sub frmButToanKetChuyen_DanhSach_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            _GridView.Columns("KcTudo1").Caption = "KC " + Generals.TS_TuDo1.GiaTri
            _GridView.Columns("KcTudo2").Caption = "KC " + Generals.TS_TuDo2.GiaTri
            _GridView.Columns("KcTudo3").Caption = "KC " + Generals.TS_TuDo3.GiaTri
            _GridView.Columns("KcTudo4").Caption = "KC " + Generals.TS_TuDo4.GiaTri
            _GridView.Columns("KcTudo5").Caption = "KC " + Generals.TS_TuDo5.GiaTri

            Load_Grid()

        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub Load_Grid()
        Dim lstBTKetChuyen As List(Of DmBtKetchuyen) = New List(Of DmBtKetchuyen)
        lstBTKetChuyen.AddRange(DmBtKetchuyenService.GetObjectAllByDonviID(Generals.DON_VI.Id))
        If lstBTKetChuyen.Count > 0 Then
            _GridControl.DataSource = lstBTKetChuyen
        Else
            _GridControl.DataSource = Nothing
        End If
        _GridView.Columns("KcKh").ColumnEdit = TNCommon.COSUDUNG_ColumnEdit()
        _GridView.Columns("KcVuviec").ColumnEdit = TNCommon.COSUDUNG_ColumnEdit()
        _GridView.Columns("KcPhi").ColumnEdit = TNCommon.COSUDUNG_ColumnEdit()
        _GridView.Columns("KcCongtrinh").ColumnEdit = TNCommon.COSUDUNG_ColumnEdit()
        _GridView.Columns("KcHopdong").ColumnEdit = TNCommon.COSUDUNG_ColumnEdit()
        _GridView.Columns("KcBpht").ColumnEdit = TNCommon.COSUDUNG_ColumnEdit()
        _GridView.Columns("KcTudo1").ColumnEdit = TNCommon.COSUDUNG_ColumnEdit()
        _GridView.Columns("KcTudo2").ColumnEdit = TNCommon.COSUDUNG_ColumnEdit()
        _GridView.Columns("KcTudo3").ColumnEdit = TNCommon.COSUDUNG_ColumnEdit()
        _GridView.Columns("KcTudo4").ColumnEdit = TNCommon.COSUDUNG_ColumnEdit()
        _GridView.Columns("KcTudo5").ColumnEdit = TNCommon.COSUDUNG_ColumnEdit()
        _GridView.Columns("LoaiKetchuyen").ColumnEdit = TNCommon.LoaiKChuyen_ColumnEdit()
    End Sub

    Private Sub create()

        Dim f As frmButToanKetChuyen_ChiTiet = CType(ObjectFactory.GetObject("frmButToanKetChuyen_ChiTiet"), frmButToanKetChuyen_ChiTiet)
        If f.Show_Form(Guid.NewGuid(), DataInputState.AddMode) Then
            Me.Load_Grid()
        End If
       
    End Sub
    Private Sub btnCreate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Try
            create()

        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub
    Private Sub Edit()

        Dim f As frmButToanKetChuyen_ChiTiet = CType(ObjectFactory.GetObject("frmButToanKetChuyen_ChiTiet"), frmButToanKetChuyen_ChiTiet)
        If _GridView.RowCount <> 0 Then
            Dim gridBTKC As DmBtKetchuyen = CType(_GridView.GetRow(_GridView.FocusedRowHandle), DmBtKetchuyen)
            If f.Show_Form(gridBTKC.Id, DataInputState.EditMode) Then
                Me.Load_Grid()
            End If
        Else
            Message_Warning("Không có bản ghi nào được lựa chọn!")
        End If
       
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMod.Click
        Try
            Edit()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub
    Private Sub Delete()
        If _GridView.RowCount <> 0 Then
            Dim gridBTKC As DmBtKetchuyen = CType(_GridView.GetRow(_GridView.FocusedRowHandle), DmBtKetchuyen)
            If (MessageBox.Show(ConstantMsgs.MSG_CONFIRM_FOR_DELETE, "Confirmation", MessageBoxButtons.YesNo) <> DialogResult.Yes) Then Return
            DmBtKetchuyenService.DeleteById(gridBTKC.Id)
            Me.Load_Grid()
        Else
            Message_Warning("Không có bản ghi nào được lựa chọn!")
        End If
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDel.Click
        Try
            Delete()

        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub _GridView_FocusedRowChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles _GridView.FocusedRowChanged
        Try

            Dim gridBTKC As DmBtKetchuyen = CType(_GridView.GetRow(_GridView.FocusedRowHandle), DmBtKetchuyen)

            If (Not gridBTKC Is Nothing) Then
                DMBTKC = gridBTKC.Id
            End If
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

    Private Sub SimpleButton1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            If _GridView.RowCount <> 0 Then
                Dim gridBTKC As DmBtKetchuyen = CType(_GridView.GetRow(_GridView.FocusedRowHandle), DmBtKetchuyen)
                Dim dt As DataTable = New DataTable()
                Dim Tu_Ngay As DateTime = New DateTime(2011, 2, 1)
                Dim Den_Ngay As DateTime = Tu_Ngay.AddMonths(1).AddDays(-1)
                dt = DmBtKetchuyenService().LaySoDuTaiKhoan(Tu_Ngay, Den_Ngay, Generals.DON_VI.Id, gridBTKC)
            Else
                Message_Warning("Không có bản ghi nào được lựa chọn!")
            End If
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub frmButToanKetChuyen_DanhSach_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Try
            Select Case e.KeyCode
                Case Keys.F3
                    create()
                Case Keys.F4
                    Edit()
                Case Keys.F8
                    Delete()
                Case Keys.Escape
                    Me.Close()
            End Select

        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub
End Class