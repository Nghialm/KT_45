Imports System.Reflection
Imports DevExpress.XtraGrid.Columns

Imports Vns.Erp.Core
Imports Vns.Erp.Core.Admin.Domain
Imports Vns.Erp.Core.Accounting.Domain
Imports Vns.Erp.Core.Admin.Service.Interface
Imports Vns.Erp.Core.Accounting.Service.Interface

Public Class frmSearchKTHDONG
#Region "Property"
    Dim _DmTaikhoanService As IDmTaikhoanService
    Public Property DmTaikhoanService As IDmTaikhoanService
        Get
            Return _DmTaikhoanService
        End Get
        Set(ByVal value As IDmTaikhoanService)
            _DmTaikhoanService = value
        End Set
    End Property

    Private _HtLoaichungtuService As IHtLoaichungtuService
    Public Property HtLoaichungtuService As IHtLoaichungtuService
        Get
            Return _HtLoaichungtuService
        End Get
        Set(ByVal value As IHtLoaichungtuService)
            _HtLoaichungtuService = value
        End Set
    End Property

    Private _BcKetoanService As IBcKetoanService
    Public Property BcKetoanService As IBcKetoanService
        Get
            Return _BcKetoanService
        End Get
        Set(ByVal value As IBcKetoanService)
            _BcKetoanService = value
        End Set
    End Property

    Private _DmKhangService As IDmKhangService
    Public Property DmKhangService As IDmKhangService
        Get
            Return _DmKhangService
        End Get
        Set(ByVal value As IDmKhangService)
            _DmKhangService = value
        End Set
    End Property

    Private _DmHanghoaService As IDmHanghoaService
    Public Property DmHanghoaService As IDmHanghoaService
        Get
            Return _DmHanghoaService
        End Get
        Set(ByVal value As IDmHanghoaService)
            _DmHanghoaService = value
        End Set
    End Property
    Private _KtHDongService As IKtHDongService
    Public Property KtHDongService As IKtHDongService
        Get
            Return _KtHDongService
        End Get
        Set(ByVal value As IKtHDongService)
            _KtHDongService = value
        End Set
    End Property
#End Region

#Region "Variables"


    Private _p_MA_TAIKHOAN As String
    Private _p_MA_TAIKHOAN_DU As String
    Private _p_NGAY_CT_TU As Date
    Private _p_NGAY_CT_DEN As Date
    Private _p_ID_LOAI_CT As Guid
    Private _p_SO_TIEN_TU As Decimal = -1.0001
    Private _p_SO_TIEN_DEN As Decimal = -1.0001

    Public Property P_MA_TAIKHOAN() As String
        Get
            Return _p_MA_TAIKHOAN
        End Get
        Set(ByVal value As String)
            _p_MA_TAIKHOAN = value
        End Set
    End Property

    Public Property P_MA_TAIKHOAN_DU() As String
        Get
            Return _p_MA_TAIKHOAN_DU
        End Get
        Set(ByVal value As String)
            _p_MA_TAIKHOAN_DU = value
        End Set
    End Property

    Public Property P_NGAY_CT_TU() As Date
        Get
            Return _p_NGAY_CT_TU
        End Get
        Set(ByVal value As Date)
            _p_NGAY_CT_TU = value
        End Set
    End Property

    Public Property P_NGAY_CT_DEN() As Date
        Get
            Return _p_NGAY_CT_DEN
        End Get
        Set(ByVal value As Date)
            _p_NGAY_CT_DEN = value
        End Set
    End Property

    Public Property P_ID_LOAI_CT() As Guid
        Get
            Return _p_ID_LOAI_CT
        End Get
        Set(ByVal value As Guid)
            _p_ID_LOAI_CT = value
        End Set
    End Property

    Public Property P_SO_TIEN_TU() As Decimal
        Get
            Return _p_SO_TIEN_TU
        End Get
        Set(ByVal value As Decimal)
            _p_SO_TIEN_TU = value
        End Set
    End Property

    Public Property P_SO_TIEN_DEN() As Decimal
        Get
            Return _p_SO_TIEN_DEN
        End Get
        Set(ByVal value As Decimal)
            _p_SO_TIEN_DEN = value
        End Set
    End Property
#End Region

#Region "Event Handles"
    Public Sub New()
        InitializeComponent()


        

        TNCommon.setIconControl(Me)
    End Sub

    Private Sub frmSearchKTHDONG_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            CtlPagerControl.display = New Common.Controls.PagerControl.DisplayResult(AddressOf DisplayResult)
            LoadAll()
            HideSearchBox()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub frmSearchKTHDONG_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Try
            Select Case (e.KeyCode)
                Case Keys.Enter
                    'SendKeys.Send("{TAB}")
                Case Keys.Escape
                    Me.Close()
            End Select
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        ShowSearchResult()
    End Sub

    Private Sub ShowSearchResult()
        Try
            'paneSearch.Expanded = False
            frmProgress.Instance.Thread = AddressOf DisplayResult
            frmProgress.Instance.Show_Progress("Searching ...")
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub dateEditNgayCTTu_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            P_NGAY_CT_TU = dateEditNgayCTTu.DateTime
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub dateEditNgayCTDen_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            _p_NGAY_CT_DEN = dateEditNgayCTDen.DateTime
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub cboLoaiCT_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            _p_ID_LOAI_CT = cboLoaiCT.EditValue
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub btnGetData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Dim rowHandle As Integer = grvMain.FocusedRowHandle
            Dim str As String = "Row data: " + rowHandle.ToString + Environment.NewLine
            For Each gcol As GridColumn In grvMain.Columns
                str = str + vbTab + EqualSpace(gcol.Name) + ":" + grvMain.GetRowCellValue(rowHandle, gcol.Name).ToString + Environment.NewLine
            Next
            Message_Information(str)
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Try
            Me.Close()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub
#End Region

#Region "Common Functions"
    Private Sub LoadKTHDongToControl(ByVal d As KtHDong, ByVal _tu_ngay As Date, ByVal _den_ngay As Date)
        'Dim hamtinh As String = d.HamTinh.ToUpper()
        'If (hamtinh.IndexOf("NO") > -1) Then
        '    txtMA_TK.Text = d.DkMaTk
        '    txtMa_TK_DOI_UNG.Text = d.DkMaTkDu
        'End If

        'If (hamtinh.IndexOf("CO") > -1) Then
        '    txtMA_TK.Text = d.DkMaTkDu
        '    txtMa_TK_DOI_UNG.Text = d.DkMaTk
        'End If
        txtMA_TK.Text = d.DkMaTk
        txtMa_TK_DOI_UNG.Text = d.DkMaTkDu
        dateEditNgayCTTu.EditValue = _tu_ngay
        dateEditNgayCTDen.EditValue = _den_ngay
    End Sub

    Private Sub LoadAll()
        Dim dt_tk As DataTable = DataHelper.ToDataTable(_DmTaikhoanService.GetAllByDonviID(Generals.DON_VI.Id))

        Dim columnDefine As ArrayList = New ArrayList()
        columnDefine.Add(New ColumnInfo("MaTaikhoan", "Mă tài khoản", 0, True, ""))
        columnDefine.Add(New ColumnInfo("TenTaikhoan", "Tên tài khoản", 0, True, ""))
        Dim dt_tk1 As DataTable = dt_tk.Copy
        Dim be As BaseGridPopupForm = New BaseGridPopupForm(txtMA_TK, "MaTaikhoan", dt_tk1, columnDefine)
        be.Text = "Chọn tài khoản"
        be.Size = New Size(500, 300)

        Dim columnDefine1 As ArrayList = New ArrayList()
        columnDefine1.Add(New ColumnInfo("MaTaikhoan", "Mă tài khoản", 0, True, ""))
        columnDefine1.Add(New ColumnInfo("TenTaikhoan", "Tên tài khoản", 0, True, ""))
        Dim dt_tk2 As DataTable = dt_tk.Copy
        Dim b1 As BaseGridPopupForm = New BaseGridPopupForm(txtMa_TK_DOI_UNG, "MaTaikhoan", dt_tk2, columnDefine1)
        b1.Text = "Chọn tài khoản"
        b1.Size = New Size(500, 300)
        'BindTK()
        'BindTKDU()
        BindLoaiCT()
    End Sub

    Private Sub BindLoaiCT()
        cboLoaiCT.Properties.DataSource = Nothing
        Dim listBind As New List(Of HtLoaichungtu)
        Dim infoNULL As New HtLoaichungtu()
        infoNULL.MaLoaiCt = Nothing
        infoNULL.TenLoaiCt = "Không xác định"
        listBind.Add(infoNULL)
        Dim listData As List(Of HtLoaichungtu) = New List(Of HtLoaichungtu)
        listData.AddRange(_HtLoaichungtuService.GetAll())
        listBind.AddRange(listData)
        cboLoaiCT.Properties.DataSource = listBind
        cboLoaiCT.Properties.ValueMember = "Id"
        cboLoaiCT.Properties.DisplayMember = "TenLoaiCt"
    End Sub
    Private _PageIndex As Integer = 1
    Private _PageSize As Integer=100
    Public Property PageIndex As Integer
        Get
            Return _PageIndex
        End Get
        Set(ByVal value As Integer)
            _PageIndex = value
        End Set
    End Property
    Public Property PageSize As Integer
        Get
            Return _PageSize
        End Get
        Set(ByVal value As Integer)
            _PageSize = value
        End Set
    End Property

    Private Sub DisplayResult()
        Try
            _p_NGAY_CT_TU = dateEditNgayCTTu.DateTime
            _p_NGAY_CT_DEN = dateEditNgayCTDen.DateTime

            If Not cboLoaiCT.EditValue Is Nothing Then
                _p_ID_LOAI_CT = VnsConvert.CGuid(cboLoaiCT.EditValue)
            Else
                _p_ID_LOAI_CT = Nothing
            End If

            If (txtSoTienTu.Text Is Nothing) Or txtSoTienTu.Text.Equals("0") Then
                P_SO_TIEN_TU = Decimal.MinValue
            Else
                Try
                    P_SO_TIEN_TU = Decimal.Parse(txtSoTienTu.Text)
                Catch ex As Exception
                    P_SO_TIEN_TU = Decimal.MinValue
                End Try
            End If

            If (txtSoTienDen.Text Is Nothing) Or txtSoTienDen.Text.Equals("0") Then
                P_SO_TIEN_DEN = Decimal.MinValue
            Else
                Try
                    P_SO_TIEN_DEN = Decimal.Parse(txtSoTienDen.Text)
                Catch ex As Exception
                    P_SO_TIEN_DEN = Decimal.MinValue
                End Try
            End If
            Dim totalResult As Integer
            Dim dt As IList(Of BcKetoan) = _BcKetoanService.SearchBy(CtlPagerControl.PageIndex, CtlPagerControl.PageSize, _p_ID_LOAI_CT, P_SO_TIEN_TU, P_SO_TIEN_DEN, txtMA_TK.Text, txtMa_TK_DOI_UNG.Text, _
                                                        _p_NGAY_CT_TU, _p_NGAY_CT_DEN, Generals.DON_VI.Id, _
                                                        Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, _
                                                        Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, _
                                                        Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, CtlPagerControl.TotalResult)
            CtlPagerControl.RefreshPage()
            Dim title As String = gcResult.Text
            Dim indexOfChar As Integer = title.LastIndexOf("(")
            If indexOfChar > 0 Then
                title = title.Substring(0, title.LastIndexOf("(") - 1).Trim()
            End If
            gcResult.Text = title + " (" + dt.Count.ToString + ")"
            grcMain.DataSource = dt
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Public Function Show_Form(ByVal id_dong As Guid) As Boolean
        Dim bReturn As Boolean = False
        Dim str As Guid = Null.NullGuid
        str = GetDkFromIdDong(id_dong)
        If Not str.Equals("") Then
            bReturn = True
        End If
        If bReturn = True Then
            Me.ShowDialog()
        End If
        Return bReturn
    End Function

    Public Function Show_Form_2(ByVal id_dong As Guid, ByVal TuNgay As Date, ByVal DenNgay As Date) As Boolean
        Dim d As KtHDong = _KtHDongService.GetById(id_dong)
        Dim ngay_dau_ky As DateTime = TuNgay
        Dim ngay_cuoi_ky As DateTime = DenNgay

        LoadKTHDongToControl(d, ngay_dau_ky, ngay_cuoi_ky)
        Dim ds As IList(Of BcKetoan) = New List(Of BcKetoan)()
        Dim totalResult As Integer = 1
        ds = _BcKetoanService.SearchBy(-1, -1, Nothing, Decimal.MinValue, Decimal.MinValue, d.DkMaTk, d.DkMaTkDu, ngay_dau_ky, ngay_cuoi_ky, _
                                    Generals.DON_VI.Id, d.DkNgoaiTe, _
                                    d.DkMaHopdong, d.DkMaHopdongDu, d.DkMaPtqt, d.DkMaDmPtqtDu, _
                                    d.DkMaDmPhongban, d.DkMaDmPhongbanDu, _
                                    VnsConvert.CGuid(d.DkMaDmVuviec), VnsConvert.CGuid(d.DkMaDmVuviecDu), _
                                    VnsConvert.CGuid(d.DkMaKhang), VnsConvert.CGuid(d.DkMaKhangDu), _
                                    VnsConvert.CGuid(d.DkMaDmTudo1), VnsConvert.CGuid(d.DkMaDmTudo1Du), _
                                    VnsConvert.CGuid(d.DkMaDmTudo2), VnsConvert.CGuid(d.DkMaDmTudo2Du), _
                                    VnsConvert.CGuid(d.DkMaDmTudo3), VnsConvert.CGuid(d.DkMaDmTudo3Du), _
                                    VnsConvert.CGuid(d.DkMaDmTudo4), VnsConvert.CGuid(d.DkMaDmTudo4Du), _
                                    VnsConvert.CGuid(d.DkMaDmTudo5), VnsConvert.CGuid(d.DkMaDmTudo5Du), totalResult)
        grcMain.DataSource = ds
        Dim count As Integer = ds.Count
        gcResult.Text = gcResult.Text + " (" + count.ToString + ")"
        Me.ShowDialog()
        Return True
    End Function

    Private Function GetDkFromIdDong(ByVal id_dong As Guid) As Guid
        Dim dong_Info As KtHDong = _KtHDongService.GetById(id_dong)
        Dim str As Guid = dong_Info.Id
        Return str
    End Function

    Private Sub HideSearchBox()
        'paneSearch.Expanded = False
    End Sub

    Private Function EqualSpace(ByVal str As String)
        Dim max As Integer = 20
        Dim abc As String = ""
        Dim countRemain As Integer = max - str.Length
        For i As Integer = 0 To countRemain
            abc = abc + " "
        Next
        Return (str + abc)
    End Function
#End Region

#Region "Popup Events"
    Private Sub grvMain_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grvMain.DoubleClick
        Try
            If grvMain.RowCount > 0 Then
                Dim rowData As BcKetoan = CType(grvMain.GetFocusedRow, BcKetoan)
                Dim cth_id As Guid = rowData.CthId

                If Not cth_id.Equals("") Then
                    Dim id_loai_ct As Guid = rowData.IdLoaiCt
                    Dim infoLoaiCT As HtLoaichungtu = _HtLoaichungtuService.GetById(id_loai_ct)
                    Dim currentRowIndex As Integer = grvMain.FocusedRowHandle
                    Dim listCTHG As List(Of Extend.CT_H_GInfo) = GetNumberCTHG(5, currentRowIndex)
                    ShowDetail(cth_id, infoLoaiCT.MaLoaiCt, infoLoaiCT.TenLoaiCt, infoLoaiCT.DuongDan, listCTHG, DataInputState.EditMode)
                    ShowSearchResult()
                    Dim count As Integer = grvMain.RowCount - 1
                    If count < 0 Then
                        Return
                    End If
                    If (currentRowIndex > count) Then
                        currentRowIndex = count
                    End If
                    grvMain.GetRow(currentRowIndex)
                End If
            End If
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub popDetail_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Try
            If grvMain.RowCount > 0 Then
                Dim rowData As BcKetoan = CType(grvMain.GetFocusedRow, BcKetoan)
                Dim cth_id As Guid = rowData.CthId
                If Not cth_id.Equals("") Then
                    Dim id_loai_ct As Guid = rowData.IdLoaiCt
                    Dim infoLoaiCT As HtLoaichungtu = _HtLoaichungtuService.GetById(id_loai_ct)
                    Dim currentRowIndex As Integer = grvMain.FocusedRowHandle
                    Dim listCTHG As List(Of Extend.CT_H_GInfo) = GetNumberCTHG(5, currentRowIndex)
                    ShowDetail(cth_id, infoLoaiCT.MaLoaiCt, infoLoaiCT.TenLoaiCt, infoLoaiCT.DuongDan, listCTHG, DataInputState.EditMode)
                End If
            End If
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub popRefresh_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)

    End Sub

    Private Sub popClose_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Try
            Me.Close()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Function IsDataRow() As Boolean
        Try
            Dim bCheck As Boolean = True
            Dim rowData As DataRowView = CType(grvMain.GetFocusedRow, DataRowView)
            Dim cth_id As String = rowData("CTH_ID").ToString
            If cth_id.Equals("") Then
                bCheck = False
            End If
            Return bCheck
        Catch
            Return False
        End Try
    End Function

    Private Sub ShowDetail(ByVal cth_id As Guid, ByVal ma_loai_ct As String, ByVal ten_loai_ct As String, ByVal duong_dan As String, ByVal listCTHG As List(Of Extend.CT_H_GInfo), ByVal state As DataInputState)
        Try
            'If not form for show, return
            If String.IsNullOrEmpty(duong_dan) Then
                Message_Information("Không có form để hiển thị chi tiết !")
                Return
            End If

            Dim frm As Form = Nothing 'Form that contain method
            Dim method_show_form As MethodInfo = Nothing 'Method for invoke

            'Get list parameter form property duong_dan
            Dim dataInfo As FormDataInfo = DataMining.GetFormData(duong_dan)
            Dim form_name As String = dataInfo.FORMNAME
            Dim form_param_data As String = dataInfo.FORMDATA
            Dim listParam As List(Of ParamInfo) = DataMining.GetParams(form_param_data)

            'Array parameter for method
            'Dim arrParam() As Object = New Object() {cth_id, listParam(0).PARAMVALUE, ten_loai_ct, listCTHG, state}
            'Lay truc tiep ma chung tu truyen vao tham so
            Dim arrParam() As Object = New Object() {cth_id, ma_loai_ct, ten_loai_ct, listCTHG, state}

            'Create form from formName
            Dim Name As String = form_name
            If (Not form_name.IndexOf(",") = -1) Then
                Dim formType As Type = Type.GetType(form_name)
                Dim theForm As Windows.Forms.Form = DirectCast(Activator.CreateInstance(formType), Windows.Forms.Form)
                Name = theForm.Name
            End If
            frm = ObjectFactory.GetObject(Name)

            'Get method of form by methodName
            'Dim types() As System.Type = New Type() {cth_id.GetType(), listParam(0).PARAMVALUE.GetType(), ten_loai_ct.GetType(), listCTHG.GetType(), state.GetType()}
            'Lay truc tiep ma chung tu truyen vao tham so
            'Dim types() As System.Type = New Type() {cth_id.GetType(), ma_loai_ct.GetType(), ten_loai_ct.GetType(), listCTHG.GetType(), state.GetType()}
            'frm = ObjectFactory.GetObject(form_name)
            method_show_form = GetMethodByName(frm, "Show_Form")
            'Invoke method
            method_show_form.Invoke(frm, arrParam)
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Function GetMethodByName(ByVal frmContainer As Form, ByVal methodName As String) As MethodInfo
        Try
            Dim type As Type = frmContainer.GetType()
            Dim methodReturn As MethodInfo = type.GetMethod(methodName)
            Return methodReturn
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Private Function GetMethodByName(ByVal frmContainer As Form, ByVal methodName As String, ByVal types As System.Type()) As MethodInfo
        Try
            Dim type As Type = frmContainer.GetType()
            Dim methodReturn As MethodInfo = type.GetMethod(methodName, types, Nothing)
            Return methodReturn
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Private Function GetOneCTHG(ByVal rowHandle As Integer, ByVal loai_ct_id As Guid) As Extend.CT_H_GInfo
        Dim infoCTHG As New Extend.CT_H_GInfo()
        Dim rowData As BcKetoan = CType(grvMain.GetRow(rowHandle), BcKetoan)
        Dim cth_id As Guid = rowData.CthId
        Dim id_loai_ct As Guid = rowData.IdLoaiCt

        If id_loai_ct.Equals(loai_ct_id) Then
            Dim infoLoaiCT As HtLoaichungtu = _HtLoaichungtuService.GetById(id_loai_ct)
            Dim ngay_ghi As DateTime = DateTime.Now
            Dim ngay_ct As DateTime = DateTime.Now
            Dim ct_so As String = ""
            Dim so_tien As Decimal = 0
            Dim ghi As Decimal = 0
            Dim da_khoa_so As Decimal = 0

            Try
                ngay_ghi = rowData.NgayGhi
                ngay_ct = rowData.NgayCt
                ct_so = rowData.CtSo
                so_tien = rowData.SoTien
                ghi = 1
                da_khoa_so = 1
            Catch
            End Try

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

        Dim currentRowData As BcKetoan = CType(grvMain.GetRow(_currentIndex), BcKetoan)
        Dim currentLoaiCTID As Guid = currentRowData.IdLoaiCt

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

        Dim currentRowData As BcKetoan = CType(grvMain.GetRow(_currentIndex), BcKetoan)
        Dim currentLoaiCTID As Guid = currentRowData.IdLoaiCt

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
#End Region

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.PageIndex = PageIndex - 1
        DisplayResult()
    End Sub

    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.PageIndex = PageIndex + 1
        DisplayResult()
    End Sub

    Private Sub txtPage_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        Select Case (e.KeyCode)
            Case Keys.Enter
                DisplayResult()
        End Select
    End Sub
End Class