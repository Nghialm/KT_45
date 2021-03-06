Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Grid
Imports System.IO
Imports System.Reflection

Imports Vns.Erp.Core.Admin.Domain
Imports Vns.Erp.Core.Admin.Service.Interface
Imports Vns.Erp.Core.Accounting.Domain
Imports Vns.Erp.Core.Service.Interface

Public Class frmBaoCaoView
#Region "Property"
    Private _HtLoaichungtuService As IHtLoaichungtuService
    Public Property HtLoaichungtuService As IHtLoaichungtuService
        Get
            Return _HtLoaichungtuService
        End Get
        Set(ByVal value As IHtLoaichungtuService)
            _HtLoaichungtuService = value
        End Set
    End Property
#End Region

#Region "Variables"
    Private _FORM_TITLE As String
    Private _DS_FILE_BAOCAO As List(Of HtFileBaocao)
    Private _DATA_SOURCE As DataTable
    Private _OBJ_INFO As HtBaocao
    Private _LIST_PARAM As List(Of DevExpress.XtraReports.Parameters.Parameter)

    Private _objhtloaict As HtLoaichungtu = New HtLoaichungtu()

    Public Property FORM_TITLE() As String
        Get
            Return _FORM_TITLE
        End Get
        Set(ByVal value As String)
            _FORM_TITLE = value
        End Set
    End Property

    Public Property DS_FILE_BAOCAO() As List(Of HtFileBaocao)
        Get
            Return _DS_FILE_BAOCAO
        End Get
        Set(ByVal value As List(Of HtFileBaocao))
            _DS_FILE_BAOCAO = value
        End Set
    End Property

    Public Property DATA_SOURCE() As System.Data.DataTable
        Get
            Return _DATA_SOURCE
        End Get
        Set(ByVal value As System.Data.DataTable)
            _DATA_SOURCE = value
        End Set
    End Property

    Public Property OBJ_INFO() As HtBaocao
        Get
            Return _OBJ_INFO
        End Get
        Set(ByVal value As HtBaocao)
            _OBJ_INFO = value
        End Set
    End Property

    Public Property LIST_PARAM() As List(Of DevExpress.XtraReports.Parameters.Parameter)
        Get
            Return _LIST_PARAM
        End Get
        Set(ByVal value As List(Of DevExpress.XtraReports.Parameters.Parameter))
            _LIST_PARAM = value
        End Set
    End Property

    Private _PKG_Name As String = ""
    Public Property PKG_Name() As String
        Get
            Return _PKG_Name
        End Get
        Set(ByVal value As String)
            _PKG_Name = value
        End Set
    End Property

    Private _lstParameter As List(Of Object) = New List(Of Object)()
    Public Property LstParameter() As List(Of Object)
        Get
            Return _lstParameter
        End Get
        Set(ByVal value As List(Of Object))
            _lstParameter = value
        End Set
    End Property

    Public TuNgay As Date
    Public DenNgay As Date
#End Region

#Region "Event Handles"
    Private Sub frmBaoCaoView_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            TNCommon.setIconControl(Me)
            Me.Text = FORM_TITLE

            Me.MultiExportButton1.Focus()
            Me.MultiExportButton1.AccessibleDescription = _OBJ_INFO.MaBaocao
            LoadTemplateList()

            frmProgress.Instance.Thread = AddressOf LoadGrid
            frmProgress.Instance.Show_Progress()

            Select Case (_OBJ_INFO.LoaiBaocao)
                Case 2
                    cboCheckVisible.Visible = True
                    Setstyle()
                    ShowGridWithCheck(False)
                Case Else
                    cboCheckVisible.Visible = False
                    RemoveStyle()
            End Select

            
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Function FilterTable(ByVal dt As DataTable, ByVal IsVisible As Boolean) As DataTable
        Dim dtfilter As DataTable = New DataTable()
        Dim arr As DataRow()

        dtfilter = dt.Clone()
        'dtfilter = dt.Copy()
        arr = dt.Select("InDong = 1")
        For i As Integer = 0 To arr.Count - 1
            dtfilter.ImportRow(arr(i))
        Next

        Return dtfilter
    End Function

    Private Sub btnReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReport.Click
        Try
            LoadReport(grvMain, _LIST_PARAM)
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
#End Region

#Region "Common Functions"
    Private Sub BestFitAllColumns(ByVal gridview As GridView, ByVal first_col_name As String)
        'gridview.OptionsView.ColumnAutoWidth = False
        'gridview.RefreshData()
        'Dim equal As Double = 0
        'If gridview.Columns.Count > 0 Then
        '    For Each item As GridColumn In gridview.Columns
        '        If item.Visible = True Then
        '            equal = equal + item.Width
        '        End If
        '    Next
        'End If
        'If (equal > 0 And equal < gridview.GridControl.Width) Then
        '    gridview.OptionsView.ColumnAutoWidth = True
        'End If
        'gridview.RefreshData()
        'gridview.BestFitColumns()

        'Fix cot dau tien ko cho scroll
        Try
            If gridview.Columns.Count > 0 Then
                gridview.Columns(0).Fixed = FixedStyle.Left
            End If

        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub ChangeCaptionGridview(ByVal objInfo As HtBaocao, ByVal _gridView As GridView)
        Dim arCaption As New ArrayList()
        Dim arDisplay As New ArrayList()
        Dim arFormatString As New ArrayList()
        arCaption = CommonClass.convertStringToArrayList(objInfo.CotHienthi, ";")
        arDisplay = CommonClass.convertStringToArrayList(objInfo.TenHienthi, ";")

        For i As Integer = 0 To arCaption.Count - 1
            Dim arTemp As New ArrayList()
            arTemp = CommonClass.convertStringToArrayList(arCaption(i).ToString(), "$")

            If (arTemp.Count > 1) Then
                arCaption(i) = arTemp(0)
                arFormatString.Add(arTemp(1))
            Else
                arCaption(i) = arTemp(0)
                arFormatString.Add(" ")
            End If
        Next

        'Xu ly them truong hop neu ds cot hien thi null
        If arCaption.Count > 0 Then
            For l = 0 To _gridView.Columns.Count - 1
                _gridView.Columns(l).Visible = False
            Next
        End If

        For j = 0 To arCaption.Count - 1

            For i = 0 To _gridView.Columns.Count - 1
                'If _gridView.Columns(i).Visible = True Then
                Dim thisCol = _gridView.Columns(i).FieldName

                If thisCol = arCaption(j) Then
                    'Set visible
                    _gridView.Columns(i).Caption = arDisplay(j).ToString()
                    'Set index colum
                    _gridView.Columns(i).VisibleIndex = j + 1
                    '_gridView.Columns(i).Visible = True
                    Select Case arFormatString(j)(0)
                        Case "n"
                            _gridView.Columns(i).DisplayFormat.FormatString = arFormatString(j)
                            _gridView.Columns(i).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                            _gridView.Columns(i).DisplayFormat.FormatString = arFormatString(j)
                        Case "d"
                            _gridView.Columns(i).DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
                            _gridView.Columns(i).DisplayFormat.FormatString = arFormatString(j)
                        Case Else
                    End Select
                    '_gridView.Columns(i).DisplayFormat.FormatString = "N"
                    '_gridView.Columns(i).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    '_gridView.Columns(i).DisplayFormat.FormatString = "n0"
                    Exit For
                End If
                'End If
            Next
        Next

        'Xu ly them truong hop neu ds cot hien thi null
        If arCaption.Count <= 0 Then
            For l = 0 To _gridView.Columns.Count - 1
                _gridView.Columns(l).Visible = True
            Next
        End If

        'Tinh do rong cot de hien thi
        'If (arCaption.Count = 0) Then
        BestFitAllColumns(_gridView, "")
        'End If
    End Sub

    Private Sub LoadReport(ByVal _gridView As GridView, ByVal listParam As List(Of DevExpress.XtraReports.Parameters.Parameter))
        Try
            Dim dir As String = Generals.ThuMucFileBaocao
            dir = dir + cboTemplate.EditValue

            If File.Exists(dir) Then
                Dim s = System.IO.Path.GetExtension(dir)
                If String.Compare(s.ToUpper(), ".XLS") = 0 Or String.Compare(s.ToUpper(), ".XLSX") = 0 Then
                    System.Diagnostics.Process.Start(dir)
                ElseIf String.Compare(s, ".repx") = 0 Then
                    Dim prv As Form = ObjectFactory.GetObject("ReportPreview", New Object() {CommonClass.GetDataTableFromDatasourceGrid(grvMain), dir, listParam})
                    prv.ShowInTaskbar = False
                    prv.Show()
                End If
            End If
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub LoadTemplateList()
        cboTemplate.EditValue = ""
        cboTemplate.Properties.DataSource = DS_FILE_BAOCAO
        If DS_FILE_BAOCAO.Count > 0 Then
            cboTemplate.ItemIndex = 0
            cboTemplate.EditValue = DS_FILE_BAOCAO(0).DuongDan
        End If
    End Sub

    Private Sub LoadGrid()
        grcMain.DataSource = DATA_SOURCE
        ChangeCaptionGridview(OBJ_INFO, grvMain)
    End Sub

    Private Sub RefreshData()
        grcMain.DataSource = GetDataByParamter()
        ChangeCaptionGridview(OBJ_INFO, grvMain)
    End Sub

    ''' <summary>
    ''' Lay du lieu cho gridview hien thi
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function GetDataByParamter() As DataTable
        Dim data As New DataTable
        'Throw New ApplicationException("Chua hoan thien")
        Dim iReport As IErpService(Of BcKetoan, Guid) = ObjectFactory.GetObject(PKG_Name)
        Return iReport.GetData(Nothing, _lstParameter)
        'data = HeThong_UtilBO.Instance().GetDataForReport(PKG_Name, _lstParameter).Tables(0)
    End Function
#End Region

#Region "Popup Event"
    Private Function IsDataRow() As Boolean
        Try
            Dim bCheck As Boolean = True
            Dim rowData As DataRowView = CType(grvMain.GetFocusedRow, DataRowView)
            Dim cth_id As String = rowData("CthId").ToString
            If cth_id.Equals("") Then
                bCheck = False
            End If
            Return bCheck
        Catch
            Return False
        End Try
    End Function

    Private Sub grcMain_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles grcMain.MouseClick
        Try
            If (e.Button = MouseButtons.Right) AndAlso (grvMain.RowCount > 0) Then
                popupControl.ShowPopup(MousePosition)
            End If
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub grvMain_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grvMain.DoubleClick
        Try
            Dim rowData As DataRowView = CType(grvMain.GetFocusedRow, DataRowView)
            CallDetailReport(rowData)
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub popDetail_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles popDetail.ItemClick
        Try
            Dim rowData As DataRowView = CType(grvMain.GetFocusedRow, DataRowView)
            CallDetailReport(rowData)
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    ''' <summary>
    ''' Ham liet ke chung tu lien quan trong bao cao
    ''' </summary>
    ''' <param name="rowData"></param>
    ''' <remarks></remarks>
    Private Sub CallDetailReport(ByVal rowData As DataRowView)
        If rowData Is Nothing Then
            Return
        End If
        Select Case (OBJ_INFO.LoaiBaocao)
            Case 1
                'Hien thi form chi tiet voi mot so chung tu cung loai
                Dim cth_id As Guid = VnsConvert.CGuid(rowData("CthId").ToString)
                If Not VnsCheck.IsNullGuid(cth_id) Then
                    Dim id_loai_ct As Guid = VnsConvert.CGuid(rowData("IdLoaiCt").ToString())
                    Dim infoLoaiCT As HtLoaichungtu = _HtLoaichungtuService.GetById(id_loai_ct)
                    Dim currentRowIndex As Integer = grvMain.FocusedRowHandle
                    Dim listCTHG As List(Of Extend.CT_H_GInfo) = GetNumberCTHG(5, currentRowIndex)
                    'Dim listCTHG As List(Of CT_H_GInfo) = GetAllCTHG(currentRowIndex)

                    ShowDetail(cth_id, infoLoaiCT.MaLoaiCt, infoLoaiCT.TenLoaiCt, infoLoaiCT.DuongDan, listCTHG, DataInputState.EditMode)

                    RefreshData()
                End If
            Case 2
                'Dua ra form tim kiem theo doi tuong thiet lap 
                Dim id_dong As Guid = VnsConvert.CGuid(rowData("IdDong"))
                Dim frm_view As frmSearchKTHDONG = CType(ObjectFactory.GetObject("frmSearchKTHDONG"), frmSearchKTHDONG)
                Dim bReturn As Boolean = False
                bReturn = frm_view.Show_Form_2(id_dong, TuNgay, DenNgay)
                If bReturn = False Then
                    Message_Information("Đã có lỗi xảy ra trong quá trình đọc dữ liệu. Vui lòng kiểm tra lại cấu hình báo cáo !")
                End If
            Case 3
            Case Else
        End Select
    End Sub

    Private Sub popRefresh_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles popRefresh.ItemClick
        Try
            LoadGrid()
            grvMain.FocusedRowHandle = 0
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub popClose_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles popClose.ItemClick
        Try
            Me.Close()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub ShowDetail(ByVal cth_id As Guid, ByVal ma_loai_ct As String, ByVal ten_loai_ct As String, ByVal duong_dan As String, ByVal listCTHG As List(Of Extend.CT_H_GInfo), ByVal state As DataInputState)
        'Try
        'If not form for show, return
        If duong_dan.Equals("") Then
            Message_Information("Không có form để hiển thị chi tiết !")
            Return
        End If

        Dim frm As Form = Nothing 'Form that contain method
        Dim method_show_form As MethodInfo = Nothing 'Method for invoke

        'Get list parameter form property duong_dan
        Dim dataInfo As FormDataInfo = DataMining.GetFormData(duong_dan)
        Dim form_name As String = dataInfo.FORMNAME
        Dim form_param_data As String = dataInfo.FORMDATA
        'Dim listParam As List(Of ParamInfo) = DataMining.GetParams(form_param_data)

        'Array parameter for method
        Dim arrParam() As Object = New Object() {cth_id, ma_loai_ct, ten_loai_ct, listCTHG, state}

        'Create form from formName ShowFormFullOther
        'frm = SystemHelper.GetFormAssemblyDirect(form_name, Nothing, False, "")
        'Dim formType As Type = Type.GetType(form_name)
        'Name = formType.Name

        frm = ObjectFactory.GetObject(form_name)

        'Get method of form by methodName
        method_show_form = GetMethodByName(frm, "Show_Form")
        'Invoke method
        method_show_form.Invoke(frm, arrParam)
        'Catch ex As Exception
        '    Message_Error(ex)
        'End Try
    End Sub

    Private Function GetOneCTHG(ByVal rowHandle As Integer, ByVal loai_ct_id As Guid) As Extend.CT_H_GInfo
        Dim infoCTHG As New Extend.CT_H_GInfo()
        Dim rowData As DataRowView = CType(grvMain.GetRow(rowHandle), DataRowView)
        'Dim rowData As DataRow = CType(grvMain.GetRow(rowHandle), DataRow)
        Dim cth_id As Guid = VnsConvert.CGuid(rowData("CthId").ToString)
        Dim id_loai_ct As Guid = VnsConvert.CGuid(rowData("IdLoaiCt").ToString)

        If id_loai_ct.Equals(loai_ct_id) Then
            Dim infoLoaiCT As HtLoaichungtu = _objhtloaict
            Dim ngay_ghi As DateTime = DateTime.Now
            Dim ngay_ct As DateTime = DateTime.Now
            Dim ct_so As String = ""
            Dim so_tien As Decimal = 0
            Dim ghi As Decimal = 0
            Dim da_khoa_so As Decimal = 0

            Try
                ngay_ghi = DateTime.Parse(rowData("NgayGhi").ToString)
                ngay_ct = DateTime.Parse(rowData("NgayCt").ToString)
                ct_so = rowData("CtSo").ToString
                'so_tien = Decimal.Parse(rowData("TongTien").ToString)
                ghi = Decimal.Parse(rowData("Ghi").ToString)
                da_khoa_so = Decimal.Parse(rowData("DaKhoaSo").ToString)
            Catch
            End Try
            If String.IsNullOrEmpty(ct_so) Then
                Try
                    ct_so = rowData("SoCt").ToString
                Catch
                End Try
            End If

            If String.IsNullOrEmpty(ct_so) Then
                Try
                    ct_so = rowData("SoChungtu").ToString
                Catch
                End Try
            End If

            infoCTHG.Id = VnsConvert.CGuid(cth_id)
            infoCTHG.MaLoaiCt = infoLoaiCT.MaLoaiCt
            infoCTHG.NgayGhi = ngay_ghi
            infoCTHG.CtSo = ct_so
            infoCTHG.NgayCt = ngay_ct
            infoCTHG.SoTien = so_tien
            infoCTHG.Ghi = ghi
            infoCTHG.DaKhoaSo = da_khoa_so

            Return infoCTHG
        Else
            Return Nothing
        End If
    End Function

    Private Function GetNumberCTHG(ByVal half As Integer, ByVal currentRowIndex As Integer) As List(Of Extend.CT_H_GInfo)
        Dim listCTHG As New List(Of Extend.CT_H_GInfo)
        Dim infoTemp As New Extend.CT_H_GInfo

        Dim _countLeft As Integer = 0
        Dim _countRight As Integer = 0
        Dim _maxLeft As Integer = half
        Dim _maxRight As Integer = half
        Dim _currentIndex As Integer = currentRowIndex

        Dim currentRowData As DataRowView = CType(grvMain.GetRow(_currentIndex), DataRowView)
        Dim currentLoaiCTID As Guid = VnsConvert.CGuid(currentRowData("IdLoaiCt").ToString)

        Dim currentInfo As Extend.CT_H_GInfo = GetOneCTHG(_currentIndex, currentLoaiCTID)

        'Add CTHG of Left
        For i As Integer = _currentIndex - 1 To 0 Step -1
            infoTemp = GetOneCTHG(i, currentLoaiCTID)
            If Not infoTemp Is Nothing Then
                listCTHG.Add(infoTemp)
                _countLeft = _countLeft + 1
            End If
            If _countLeft = _maxLeft Then
                Exit For
            End If
        Next

        'Add Current
        listCTHG.Add(currentInfo)

        'Add CTHG of Right
        For j As Integer = _currentIndex + 1 To grvMain.RowCount - 1
            infoTemp = GetOneCTHG(j, currentLoaiCTID)
            If Not infoTemp Is Nothing Then
                listCTHG.Add(infoTemp)
                _countRight = _countRight + 1
            End If
            If _countRight = _maxRight Then
                Exit For
            End If
        Next

        'Remove objCTHG if ID duplicate
        Dim listDel As List(Of Integer) = New List(Of Integer)
        For Ji As Integer = listCTHG.Count - 1 To 0 Step -1
            If VnsCheck.IsNullGuid(listCTHG(Ji).Id) Then
            Else
                For Kry As Integer = Ji - 1 To 0 Step -1
                    If listCTHG(Ji).Id = listCTHG(Kry).Id Then
                        listCTHG(Kry).Id = Null.NullGuid
                        'listDel.Add(Kry)
                    End If
                Next
            End If
        Next
        For i = listCTHG.Count - 1 To 0 Step -1
            If VnsCheck.IsNullGuid(listCTHG(i).Id) Then
                listCTHG.RemoveAt(i)
            End If
        Next

        Return listCTHG
    End Function

    Private Function GetAllCTHG(ByVal currentRowIndex As Integer) As List(Of Extend.CT_H_GInfo)
        Dim listCTHG As New List(Of Extend.CT_H_GInfo)
        Dim infoTemp As New Extend.CT_H_GInfo

        Dim _currentIndex As Integer = currentRowIndex

        Dim currentRowData As DataRowView = CType(grvMain.GetRow(_currentIndex), DataRowView)
        Dim currentLoaiCTID As Guid = VnsConvert.CGuid(currentRowData("IdLoaiCt").ToString)

        Dim currentInfo As Extend.CT_H_GInfo = GetOneCTHG(_currentIndex, currentLoaiCTID)

        'Add CTHG of Left
        For i As Integer = _currentIndex - 1 To 0 Step -1
            infoTemp = GetOneCTHG(i, currentLoaiCTID)
            If Not infoTemp Is Nothing Then
                listCTHG.Add(infoTemp)
            End If
        Next

        'Add Current
        listCTHG.Add(currentInfo)

        'Add CTHG of Right
        For j As Integer = _currentIndex + 1 To grvMain.RowCount - 1
            infoTemp = GetOneCTHG(j, currentLoaiCTID)
            If Not infoTemp Is Nothing Then
                listCTHG.Add(infoTemp)
            End If
        Next

        Return listCTHG
    End Function

    Private Function GetMethodByName(ByVal frmContainer As Form, ByVal methodName As String) As MethodInfo
        Try
            Dim type As Type = frmContainer.GetType()
            Dim methodReturn As MethodInfo = type.GetMethod(methodName)
            Return methodReturn
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Private Sub grvMain_RowCellStyle(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs)
        Try
            'Set Format Number
            Dim data_type As String = e.Column.ColumnType().Name
            If data_type.Equals("Decimal") Or data_type.Equals("Double") Or data_type.Equals("Single") Then
                e.Column.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                e.Column.DisplayFormat.FormatString = "n0"
                e.Column.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                e.Column.GroupFormat.FormatString = "##0,000.00"
            End If
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub grvMain_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)

    End Sub
#End Region

    Private Sub cboCheckVisible_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCheckVisible.CheckedChanged
        ShowGridWithCheck(cboCheckVisible.Checked)
    End Sub

    Private Sub ShowGridWithCheck(ByVal ShowVisiableRow As Boolean)
        Dim dt As DataTable = New DataTable()
        If (Not ShowVisiableRow) Then
            dt = FilterTable(_DATA_SOURCE, ShowVisiableRow)
            grcMain.DataSource = Nothing
            grcMain.DataSource = dt
        Else
            grcMain.DataSource = Nothing
            grcMain.DataSource = _DATA_SOURCE.DefaultView
        End If
    End Sub

#Region "Format style"
    Dim BoldStyleFormatCondition As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
    Dim ItalicStyleFormatCondition As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition

    Private Sub Setstyle()
        Try
            BoldStyleFormatCondition.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
            BoldStyleFormatCondition.Appearance.Options.UseFont = True
            BoldStyleFormatCondition.ApplyToRow = True
            BoldStyleFormatCondition.Column = grvMain.Columns("FormatKieuChu")
            BoldStyleFormatCondition.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
            BoldStyleFormatCondition.Value1 = "1"

            ItalicStyleFormatCondition.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Italic)
            ItalicStyleFormatCondition.Appearance.Options.UseFont = True
            ItalicStyleFormatCondition.ApplyToRow = True
            ItalicStyleFormatCondition.Column = grvMain.Columns("FormatKieuChu")
            ItalicStyleFormatCondition.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
            ItalicStyleFormatCondition.Value1 = "2"

            If grvMain.FormatConditions.Count > 0 Then Return

            grvMain.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {BoldStyleFormatCondition, ItalicStyleFormatCondition})
        Catch ex As Exception

        End Try
    End Sub

    Private Sub RemoveStyle()
        If grvMain.FormatConditions.Count = 0 Then Return

        grvMain.FormatConditions.Remove(BoldStyleFormatCondition)
        grvMain.FormatConditions.Remove(ItalicStyleFormatCondition)
    End Sub
#End Region
End Class