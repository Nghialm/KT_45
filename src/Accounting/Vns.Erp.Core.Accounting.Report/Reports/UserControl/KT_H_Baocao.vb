Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Base
Imports Vns.Erp.Core.Admin.Domain
Imports Vns.Erp.Core.Admin.Service.Interface

Public Class KT_H_Baocao
    Private _KtHBaocaoService As IKtHBaocaoService
    Public Property KtHBaocaoService As IKtHBaocaoService
        Get
            Return _KtHBaocaoService
        End Get
        Set(ByVal value As IKtHBaocaoService)
            _KtHBaocaoService = value
        End Set
    End Property
    Private currentView As List(Of KtHBaocao)

    Public Sub New()
        InitializeComponent()
    End Sub

    Public Sub New(ByVal HT_bienbaoCao As HtBienBaocao)
        InitializeComponent()
        Parameter_info = HT_bienbaoCao
        If (Parameter_info.TenBien <> "") Then
            LabelControl1.Text = Parameter_info.TenBien
        End If
    End Sub

    Private Sub KT_H_Baocao_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            If Not Me.DesignMode Then
                Dim drpList As List(Of KtHBaocao) = New List(Of KtHBaocao)
                Dim drpListTEMP As List(Of KtHBaocao) = New List(Of KtHBaocao)()
                drpListTEMP.AddRange(_KtHBaocaoService.GetAllSort())
                drpList.AddRange(drpListTEMP)
                cboKTHBaoCao.Properties.DataSource = drpList
                cboKTHBaoCao.Properties.ValueMember = "Id"
                cboKTHBaoCao.Properties.DisplayMember = "Title"
                If (Parameter_info.TenBien <> "") Then
                    LabelControl1.Text = Parameter_info.TenBien
                End If
                currentView = drpListTEMP
                'Filter
                cboKTHBaoCao.Properties.View.ActiveFilterString = Parameter_info.GiaTriBien
                cboKTHBaoCao.Properties.View.OptionsView.ShowFilterPanelMode = ShowFilterPanelMode.Never
                For Each gridCol As GridColumn In cboKTHBaoCao.Properties.View.Columns
                    gridCol.OptionsFilter.AllowFilter = False
                Next

                'TNCommon.SelectFirst(cboKTHBaoCao)
            End If
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub cboKTHBaoCao_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboKTHBaoCao.EditValueChanged
        Try
            Dim h_baocao_id As Guid = cboKTHBaoCao.EditValue
            Dim title As String = GetDisplayText(h_baocao_id)
            Value_info.ParameterValue = h_baocao_id
            Value_info.Ten = title
            lblTenKTBaoCao.Text = title
        Catch ex As Exception
            Value_info.ParameterValue = Nothing
            Value_info.Ten = "Không xác định"
            lblTenKTBaoCao.Text = "Không xác định"
            Message_Error(ex)
        End Try
    End Sub

    Private Sub SetCurrentView()
        'Use for Show Popup and Quick Add Object
        currentView = New List(Of KtHBaocao)
        For i As Integer = 0 To cboKTHBaoCao.Properties.View.RowCount - 1
            Dim info As KtHBaocao = CType(cboKTHBaoCao.Properties.View.GetRow(i), KtHBaocao)
            currentView.Add(info)
        Next
    End Sub

    Private Function GetDisplayText(ByVal selectedValue As Guid) As String
        Dim strDisplay As String = ""
        For Each info As KtHBaocao In currentView
            If (info.Id = selectedValue) Then
                strDisplay = info.Title
                Exit For
            End If
        Next
        Return strDisplay
    End Function

End Class
