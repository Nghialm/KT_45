Imports Vns.Erp.Core.Admin.Service.Interface
Imports Vns.Erp.Core.Admin.Domain

Public Class In_The_TSCD

#Region "Property"
    Private _DmTscdService As IDmTscdService
    Public Property DmTscdService As IDmTscdService
        Get
            Return _DmTscdService
        End Get
        Set(ByVal value As IDmTscdService)
            _DmTscdService = value
        End Set
    End Property

    Private _DmLoaitaisanService As IDmLoaitaisanService
    Public Property DmLoaitaisanService As IDmLoaitaisanService
        Get
            Return _DmLoaitaisanService
        End Get
        Set(ByVal value As IDmLoaitaisanService)
            _DmLoaitaisanService = value
        End Set
    End Property
#End Region

#Region "variables"
    Private dt As List(Of DmTscd) = New List(Of DmTscd)
    Private selection As GridCheckMarksSelection
    Dim LoaiTS_id As String
#End Region

#Region "Private functions"

    Public Sub New()
        InitializeComponent()
        TNCommon.setIconControl(Me)
        Dim _date As DateTime = DateTime.Now.Date
        dteTuNgay.DateTime = New Date(_date.Year, 1, 1)
        dteDenNgay.DateTime = _date
    End Sub

    Public Sub New(ByVal TU_NGAY As Date, ByVal DEN_NGAY As Date, ByVal TEN_TSCD As String, ByVal LOAI_TSCD As String, ByVal DON_VI_ID As Guid)
        InitializeComponent()
        TNCommon.setIconControl(Me)
        dteTuNgay.DateTime = TU_NGAY
        dteDenNgay.DateTime = DEN_NGAY
        txtTenTS.Text = TEN_TSCD
        LoaiTS_id = LOAI_TSCD
    End Sub

    Private Sub load_Data()
        dt = New List(Of DmTscd)()
        dt.AddRange(_DmTscdService.GetbyParameter((dteTuNgay.DateTime), (dteDenNgay.DateTime), txtTenTS.Text.Trim, VnsConvert.CGuid(grlLoaiTSCD.EditValue), Generals.DON_VI.Id))
        grcTSCD.DataSource = dt
        CheckKry()
    End Sub

    Private Sub BindData()
        Dim DON_VI_ID As Guid = Generals.DON_VI.Id
        Dim objColumnDefine As ArrayList

        Dim dt_DM_LoaiTS As New List(Of DmLoaitaisan)
        dt_DM_LoaiTS.AddRange(_DmLoaitaisanService.GetAll())

        Dim dr As DmLoaitaisan = New DmLoaitaisan()
        dr.KyHieu = ""
        dr.Id = Null.NullGuid
        dr.TenLoaitaisan = "<Không xác định>"
        dt_DM_LoaiTS.Add(dr)

        objColumnDefine = New ArrayList
        objColumnDefine.Add(New LookupEdit_ColumnInfo("KyHieu", "Ký hiệu"))
        objColumnDefine.Add(New LookupEdit_ColumnInfo("TenLoaichungtu", "Tên loại tài sản"))
        GridLookupEdit_BindData(grlLoaiTSCD, dt_DM_LoaiTS, "KyHieu", "Id", COMBO_ITEM_BLANK, "TenLoaichungtu", txttenLoaiTS, objColumnDefine)

    End Sub

    Private Sub CheckKry()
        If Not selection Is Nothing Then
            selection.ClearSelection()
        Else
            selection = New GridCheckMarksSelection(grvTSCD)
            selection.CheckMarkColumn.VisibleIndex = 0
            selection.CheckMarkColumn.Width = 35
            selection.CheckMarkColumn.OptionsColumn.AllowSize = False
            selection.CheckMarkColumn.OptionsColumn.FixedWidth = True
            selection.CheckMarkColumn.FieldName = "UNCHECK11"
        End If
    End Sub

#End Region

#Region "Events"

    Private Sub In_The_TSCD_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            BindData()
            txttenLoaiTS.Text = "<Không xác định>"
            grlLoaiTSCD.EditValue = LoaiTS_id
            load_Data()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub grvTSCD_CellValueChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles grvTSCD.CellValueChanged
        Try
            'Dim dt1 As DataTable = dt
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuit.Click
        Try
            Me.Close()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub btnIn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        Try
            Dim dt_Edit As IList(Of DmTscd) = CType(grvTSCD.DataSource, IList(Of DmTscd))
            Dim str As String = ""
            Dim lstTscd As IList(Of DmTscd) = New List(Of DmTscd)
            For i As Integer = 0 To grvTSCD.RowCount - 1
                If (grvTSCD.GetRowCellValue(i, "UNCHECK11").ToString = "True") Then
                    If (str = "") Then
                        str = str + grvTSCD.GetRowCellValue(i, "Id").ToString
                    Else
                        str = str + ";" + grvTSCD.GetRowCellValue(i, "Id").ToString
                    End If
                    lstTscd.Add(dt_Edit(i))
                End If
            Next
            If (str <> "") Then
                Dim rpt As The_TSCD = ObjectFactory.GetObject("The_TSCD", New Object() {str, lstTscd})
                rpt.ShowPreview()
            Else
                Message_Information("Không có bản ghi nào được lựa chọn")
            End If
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub In_The_TSCD_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Try
            Select Case e.KeyCode
                Case Keys.Escape
                    Me.Close()
            End Select
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Try
            frmProgress.Instance.Thread = AddressOf load_Data
            frmProgress.Instance.Show_Progress()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub grlLoaiTSCD_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grlLoaiTSCD.EditValueChanged
        Try
            Dim dr As DmLoaitaisan = CType(ComboHelper.GetSelectData(grlLoaiTSCD), DmLoaitaisan)

            If dr IsNot Nothing Then
                txttenLoaiTS.Text = dr.TenLoaitaisan
            End If
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub
#End Region

End Class