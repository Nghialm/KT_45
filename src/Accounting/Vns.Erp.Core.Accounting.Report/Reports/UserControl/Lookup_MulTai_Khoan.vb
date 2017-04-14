Imports Vns.Erp.Core.Admin.Domain
Imports Vns.Erp.Core.Admin.Service.Interface
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Base

Public Class Lookup_MulTai_Khoan
    Private _DmTaikhoanService As IDmTaikhoanService
    Public Property DmTaikhoanService As IDmTaikhoanService
        Get
            Return _DmTaikhoanService
        End Get
        Set(ByVal value As IDmTaikhoanService)
            _DmTaikhoanService = value
        End Set
    End Property
    Private currentView As List(Of DmTaikhoan)

    Public Sub New()
        InitializeComponent()
    End Sub

    Public Sub New(ByVal htbienbaocao As HtBienBaocao)
        InitializeComponent()
        Parameter_info = htbienbaocao
        If (Parameter_info.TenBien <> "") Then
            LabelControl1.Text = Parameter_info.TenBien
        End If
    End Sub

    Private Sub Lookup_Tai_Khoan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            If Not Me.DesignMode Then
                Dim columnDefine As ArrayList = New ArrayList()
                columnDefine.Add(New ColumnInfo("MaTaikhoan", "Mã tài khoản", 0, True, ""))
                columnDefine.Add(New ColumnInfo("TenTaikhoan", "Tên tài khoản", 0, True, ""))
                'Dim be As CusControls.BaseGridPopupForm = New CusControls.BaseGridPopupForm(txtMA_TK_LIENQUAN, "MaTaikhoan", DataHelper.ToDataTable(_DmTaikhoanService.GetAllByDonviID(Generals.DON_VI.Id)), columnDefine)
                'be.Text = "Chọn tài khoản"
                'be.Size = New Size(500, 300)
            End If
            If Not Me.DesignMode Then
                Me.NotAllowSendTab = True
            End If
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub txtMA_TK_LIENQUAN_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMA_TK_LIENQUAN.EditValueChanged
        Try
            Value_info.ParameterValue = txtMA_TK_LIENQUAN.Text
            Value_info.Ten = txtMA_TK_LIENQUAN.Text
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

End Class
