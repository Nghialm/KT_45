#Region "Import"
Imports DevExpress.XtraTreeList.Nodes
Imports DevExpress.XtraEditors.Controls
Imports Vns.Erp.Core.Admin.Domain
Imports Vns.Erp.Core.Admin.Service.Interface

#End Region

Public Class frmThemSuaXoa

#Region "Variable"
    'Du lieu ht_baocao lay tu db
    Private list_baocao As List(Of HtBaocao)

    'Su dung cho cac grid
    Private list_caption As IList(Of ColumnReportInfo)
    Private list_file As List(Of HtFileBaocao) = New List(Of HtFileBaocao)
    Private list_bien As List(Of HtBienBaocao) = New List(Of HtBienBaocao)

    'Bien flag kiem tra xem insert hay update thanh cong
    Private f_ok As Boolean = False
    'Flag insert new
    Private f_insr As Boolean = False
    'Flag update
    Private f_upd As Boolean = False

    'Flag xem grid nao dang duoc focus
    Private grid_focused As Integer

    'Danh sach cac cot da ton tai trong csdl nhung bi nguoi dung xoa di
    Private lst_file_del As List(Of HtFileBaocao)
    Private lst_bien_del As List(Of HtBienBaocao)

    'Flag xem nguoi dung co thay doi du lieu khong.Khi edit ma chua save.
    Private edit_flag As Boolean = False 'False la chua chinh sua gi

    'Flag kiem tra xem so luong lan del cua user
    Private del_force_flag As Integer = 0

    'Object node dang dc focus
    Private obj_focus As HtBaocao

    'Luu object ht_baocao cha khi sua,su dung khi cap nhat id cha
    Private edit_obj_cha As HtBaocao

    Private _HtFileBaocaoService As IHtFileBaocaoService
    Public Property HtFileBaocaoService()
        Get
            Return _HtFileBaocaoService
        End Get
        Set(ByVal value)
            _HtFileBaocaoService = value
        End Set
    End Property

    Private _HtBienBaocaoService As IHtBienBaocaoService
    Public Property HtBienBaocaoService()
        Get
            Return _HtBienBaocaoService
        End Get
        Set(ByVal value)
            _HtBienBaocaoService = value
        End Set
    End Property
    Private _HtBaocaoService As IHtBaocaoService
    Public Property HtBaocaoService()
        Get
            Return _HtBaocaoService
        End Get
        Set(ByVal value)
            _HtBaocaoService = value
        End Set
    End Property
#End Region

#Region "Functions"

    ''' <summary>
    ''' Ham tao
    ''' </summary>
    ''' <remarks></remarks>
    ''' 

    Public Sub New()
        InitializeComponent()
        TNCommon.setIconControl(Me)
        Me.list_baocao = New List(Of HtBaocao)
    End Sub

#Region "Load Data"
    ''' <summary>
    ''' Load cac control ht_baocao 
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub LoadHTBAOCAO(ByVal objBaoCao As HtBaocao)
        Dim ht_bc_obj As New HtBaocao
        ht_bc_obj = objBaoCao

        txtTenBaocao.Text = ht_bc_obj.TenBaocao
        txtMaBaocao.Text = ht_bc_obj.MaBaocao
        txtTenBang.Text = ht_bc_obj.TenBangDulieu
        txtStore.Text = ht_bc_obj.TenProcedure
        txt_Loai_BC.Text = ht_bc_obj.LoaiBaocao
        txtFullPath.Text = ht_bc_obj.GhiChu
        txtThuTu.Text = ht_bc_obj.ThuTu.ToString()

        If ht_bc_obj.ChiTiet = 0 And Not VnsCheck.IsNullGuid(ht_bc_obj.IdCha) Then
            rdoType.SelectedIndex = 1
        ElseIf ht_bc_obj.ChiTiet = 1 Then
            rdoType.SelectedIndex = 2
        ElseIf ht_bc_obj.ChiTiet = 0 Then
            rdoType.SelectedIndex = 0

        End If

        LoadParentByObj(ht_bc_obj)
        If Not ht_bc_obj.LoaiBaocao = 3 Then
            LoadGirdCaption(ht_bc_obj)
        End If
    End Sub

    ''' <summary>
    ''' Load danh sach cot hien thi va ten hien thi
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub LoadGirdCaption(ByVal objBaoCao As HtBaocao)
        Me.list_caption = New List(Of ColumnReportInfo)

        Dim ht_baocao As New HtBaocao
        ht_baocao = objBaoCao

        'Lay list cac caption bind vao grid thong qua list obj
        Dim arCaption As New ArrayList()
        arCaption = CommonClass.convertStringToArrayList(ht_baocao.CotHienthi, ";")
        Dim arDisplay As New ArrayList()
        arDisplay = CommonClass.convertStringToArrayList(ht_baocao.TenHienthi, ";")

        Dim lst_cap As New List(Of ColumnReportInfo)
        Dim item As ColumnReportInfo
        For i = 0 To arCaption.Count - 1
            item = New ColumnReportInfo
            item.CotHienthi = arCaption(i)
            If i <= arDisplay.Count - 1 Then
                item.TenHienThi = arDisplay(i) 'Check Out of range
            End If
            lst_cap.Add(item)
        Next
        Me.list_caption = lst_cap
        'End If

        If Me.list_caption.Count <= 0 Then
            Me.list_caption.Add(New ColumnReportInfo)
        End If

        grcCaption.DataSource = Me.list_caption
    End Sub

    ''' <summary>
    ''' Load danh sach file bao cao vao combobox
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub LoadGridHT_FILE_BAOCAO(ByVal objBaoCao As HtBaocao)
        If (objBaoCao.LoaiBaocao = 3) Then
            Return
        End If

        'End If
        If Me.list_file.Count <= 0 Then
            Me.list_file.Add(New HtFileBaocao)
        End If

        grcFilebaocao.DataSource = Me.list_file
    End Sub

    ''' <summary>
    ''' Load danh sach bien bao cao len luoi
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub LoadGridBienBaocao(ByVal objBaoCao As HtBaocao)
        If (objBaoCao.LoaiBaocao = 3) Then
            Return
        End If

        'End If
        If Me.list_bien.Count <= 0 Then
            Me.list_bien.Add(New HtBienBaocao)
        End If

        grcBienbaocao.DataSource = Me.list_bien
    End Sub

    Private Sub LoadData(ByVal objBaoCao As HtBaocao)
        'obj_focus = objBaoCao

        If (objBaoCao.LoaiBaocao = 3) Then
            Return
        End If
        Me.list_file = New List(Of HtFileBaocao)
        Me.list_file.AddRange(_HtFileBaocaoService.GetByHTBAOCAOID(objBaoCao.Id))

        Me.list_bien = New List(Of HtBienBaocao)
        Me.list_bien.AddRange(_HtBienBaocaoService.GetByHTBAOCAOID(objBaoCao.Id))
    End Sub

    Private Sub SetObjectToControl(ByVal objBaoCao As HtBaocao)
        If (objBaoCao Is Nothing) Then
            Return
        End If

        LoadHTBAOCAO(objBaoCao)
        LoadGridHT_FILE_BAOCAO(objBaoCao)
        LoadGridBienBaocao(objBaoCao)
    End Sub
#End Region

    ''' <summary>
    ''' Load Tree danh sach ht_baocao focus node theo ID
    ''' </summary>
    ''' <param name="node_index">Kieu Decimal la ID cua mot object HtBaocao</param>
    ''' <remarks></remarks>
    Private Sub LoadTree(ByVal node_index As Guid)
        Try
            frmProgress.Instance().Thread = AddressOf GetListHT_BAOCAO
            frmProgress.Instance().Show_Progress__1("Khởi tạo cửa sổ...", "Xong", "")
            treeMain.DataSource = Me.list_baocao
            treeMain.CollapseAll()
            Dim node As TreeListNode
            node = treeMain.FindNodeByFieldValue("ID", node_index)
            treeMain.SetFocusedNode(node)
        Catch ex As Exception
        End Try
    End Sub

    ''' <summary>
    ''' Lay du lieu tu bang ht_baocao gan cho bien global
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub GetListHT_BAOCAO()
        Me.list_baocao = New List(Of HtBaocao)()
        list_baocao.AddRange(_HtBaocaoService.GetAll())
    End Sub

    Private Sub SetControlToObject(ByRef _temp As HtBaocao)

        _temp.MaBaocao = txtMaBaocao.Text
        _temp.TenBangDulieu = txtTenBang.Text
        _temp.TenBaocao = txtTenBaocao.Text

        Dim CotHienthi As String = String.Empty
        Dim TenHienthi As String = String.Empty

        For Each item In Me.list_caption
            'Neu cot caption dang rong thi gan luon bang item dau tien,ngc lai phai them dau phay
            If CotHienthi.Equals(String.Empty) Then
                CotHienthi = item.CotHienthi
                TenHienthi = item.TenHienThi
            Else
                CotHienthi = CotHienthi.Trim + ";" + item.CotHienthi
                TenHienthi = TenHienthi.Trim + ";" + item.TenHienThi
            End If
        Next
        _temp.TenHienthi = TenHienthi
        _temp.CotHienthi = CotHienthi
        _temp.TenProcedure = txtStore.Text
        'ht_bc.ID = ht_baocao_focused.ID
        _temp.LoaiBaocao = Integer.Parse(txt_Loai_BC.Text)
        _temp.GhiChu = txtFullPath.Text
        _temp.GhiChu2 = ""
        _temp.GhiChu3 = ""
        _temp.ThuTu = Decimal.Parse(txtThuTu.Text)

        If rdoType.EditValue = 0 Then
            _temp.IdCha = Null.NullGuid
            _temp.ChiTiet = 0
        ElseIf rdoType.EditValue = 3 Then
            _temp.ChiTiet = 0
            _temp.IdCha = GetIDCHAByEditObj(obj_focus, chkEdit.Checked)

            'Neu id cha la chinh no thi chuyen no ve thu muc max
            If _temp.Id = _temp.IdCha Then
                _temp.IdCha = Null.NullGuid
            End If

        Else
            _temp.ChiTiet = 1
            _temp.IdCha = GetIDCHAByEditObj(obj_focus, chkEdit.Checked)

            'Neu id cha la chinh no thi chuyen no ve thu muc max
            If _temp.Id = _temp.IdCha Then
                _temp.IdCha = Null.NullGuid
            End If
        End If
    End Sub

    Private Sub UpdateDetail(ByVal _tempbc As HtBaocao)
        'Save ht_file
        For Each item In Me.list_file
            item.HtBaocaoId = _tempbc.Id
            If item.Id <> Nothing Then
                If item.DuongDan <> Nothing Then
                    _HtFileBaocaoService.SaveOrUpdate(item)
                End If
            Else
                If item.DuongDan <> Nothing Then
                    _HtFileBaocaoService.Save(item)
                End If
            End If
        Next

        'ht_bien
        For Each item In Me.list_bien
            item.MaHtBaocao = _tempbc.MaBaocao
            item.IdHtBaocao = _tempbc.Id
            If item.Id <> Nothing Then
                _HtBienBaocaoService.SaveOrUpdate(item)
            Else
                _HtBienBaocaoService.Save(item)
            End If
        Next

        'Xoa danh sach cac file,bien khong dc su dung nua
        If Me.lst_bien_del.Count > 0 Then
            For Each item In Me.lst_bien_del
                _HtBienBaocaoService.Delete(item)
            Next
        End If
        If Me.lst_file_del.Count > 0 Then
            For Each ite In Me.lst_file_del
                _HtFileBaocaoService.Delete(ite)
            Next
        End If
    End Sub

    ''' <summary>
    ''' Them moi bao cao
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub SaveNewInsert()
        Dim ht_baocao_focused As New HtBaocao
        ht_baocao_focused = obj_focus

        'Save ht_baocao
        Dim ht_bc As New HtBaocao
        SetControlToObject(ht_bc)

        Try
            ht_bc = _HtBaocaoService.Save(ht_bc)
            Me.f_ok = True
        Catch
        End Try

        If ht_bc.ChiTiet = 1 Then
            'Neu insert thanh cong ht_bc thi tiep tuc
            If Me.f_ok = True Then
                UpdateDetail(ht_bc)
                'Load lai tree
                LoadTree(ht_bc.Id)
            End If
            Me.f_ok = False
        ElseIf ht_bc.ChiTiet = 0 Then
            LoadTree(ht_bc.Id)
        End If
    End Sub

    ''' <summary>
    ''' Cap nhat bao cao
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub SaveUpdateBC()
        'Save ht_baocao
        Dim ht_bc As New HtBaocao
        SetControlToObject(ht_bc)
        ht_bc.Id = obj_focus.Id

        Try
            ht_bc = _HtBaocaoService.SaveOrUpdate(ht_bc)
            Me.f_ok = True
        Catch
        End Try

        If obj_focus.ChiTiet = 1 Then
            If f_ok = True Then
                UpdateDetail(ht_bc)

                'Load lai tree
                LoadTree(obj_focus.Id)
                LoadHTBAOCAO(obj_focus)
                SetEnableControl(True)
            End If
            Me.f_ok = False
        ElseIf obj_focus.ChiTiet = 0 Then
            'Load lai tree
            LoadTree(obj_focus.Id)
            LoadHTBAOCAO(obj_focus)
            SetEnableControl(True)
        End If
    End Sub

    ''' <summary>
    ''' Close form neu grid co thay doi
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub CloseForm()
        If Me.edit_flag = True Then
            If Message_Confirm("Dữ liệu chưa được lưu, muốn tiếp tục không?") Then
                Me.Close()
            End If
        Else
            Me.Close()
        End If
    End Sub

    ''' <summary>
    ''' Lay node top cua tree
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function TopNode() As HtBaocao
        Dim lst As New List(Of HtBaocao)
        lst.AddRange(_HtBaocaoService.GetByIDCha(Null.NullGuid))
        Dim newList As New List(Of HtBaocao)
        newList = lst.OrderBy(Function(x) x.TenBaocao).ToList()
        Return newList(0)
    End Function

    ''' <summary>
    ''' Xoa bao cao va tat ca bao cao con. De quy
    ''' </summary>
    ''' <param name="ht_bc"></param>
    ''' <remarks></remarks>
    Private Sub Del(ByVal ht_bc As HtBaocao)
        If ht_bc.Id <> Nothing Then

            'Del ht_baocao
            _HtBaocaoService.Delete(ht_bc)
            'Del ht_file
            Dim list_ht_file As List(Of HtFileBaocao) = New List(Of HtFileBaocao)()
            list_ht_file.AddRange(_HtFileBaocaoService.GetByHTBAOCAOID(ht_bc.Id))
            For Each item In list_ht_file
                _HtFileBaocaoService.Delete(item)
            Next
            'Del ht_ien
            Dim list_ht_bien As List(Of HtBienBaocao) = New List(Of HtBienBaocao)()
            list_ht_bien.AddRange(_HtBienBaocaoService.GetByHTBAOCAOID(ht_bc.Id))
            For Each item In list_ht_bien
                _HtBienBaocaoService.Delete(item)
            Next

            'Del child node
            Dim list_child_node As New List(Of HtBaocao)
            list_child_node.AddRange(_HtBaocaoService.GetByIDCha(ht_bc.Id))
            If list_child_node.Count > 0 Then
                For Each item In list_child_node
                    Del(item)
                Next
            End If
        End If
        'LoadTree(TopNode().Id)
    End Sub

    ''' <summary>
    ''' Textbox thu muc cha
    ''' </summary>
    ''' <param name="ht_baocao"></param>
    ''' <remarks></remarks>
    Private Sub LoadParentByObj(ByVal ht_baocao As HtBaocao)
        Dim ht_baocao_group As New HtBaocao
        If Not VnsCheck.IsNullGuid(ht_baocao.IdCha) Then
            ht_baocao_group = _HtBaocaoService.GetById(ht_baocao.IdCha)
        End If

        If ht_baocao_group IsNot Nothing Then
            txtCha.Text = ht_baocao_group.TenBaocao
        Else
            txtCha.Text = ""
        End If
    End Sub

    ''' <summary>
    ''' Lay ID cha cua mot object kieu ht_baocao
    ''' </summary>
    ''' <param name="obj">object ht_baocao</param>
    ''' <returns>ID cha cua no, kieu decimal</returns>
    ''' <remarks></remarks>
    Private Function GetIDCHAByObj(ByVal obj As HtBaocao) As Guid
        Dim equal As Guid
        If obj.ChiTiet = 0 Then
            equal = obj.Id
        ElseIf obj.ChiTiet = 1 Then
            equal = obj.IdCha
        End If
        Return equal
    End Function

    ''' <summary>
    ''' Lay ID cha cua object ht_baocao neu checkbox Sua dc check
    ''' </summary>
    ''' <param name="obj">ht_baocao</param>
    ''' <param name="flag">Trang thai checked</param>
    ''' <returns></returns>
    ''' <remarks>
    ''' Neu true(check sua dc checked-nghia la popup dc bat len) co nghia la Me.edit_obj_cha.IdCha dc khoi tao
    ''' Luc nay id cha node dc sua se cap nhat id cha moi
    ''' </remarks>
    Private Function GetIDCHAByEditObj(ByVal obj As HtBaocao, ByVal flag As Boolean) As Guid

        Dim equal As Guid
        If flag Then
            If Me.edit_obj_cha.ChiTiet = 0 Then
                equal = Me.edit_obj_cha.Id
            ElseIf Me.edit_obj_cha.ChiTiet = 1 Then
                equal = Me.edit_obj_cha.IdCha
            End If
        Else
            'Neu false thi gan id cha = id cha cu
            If obj.ChiTiet = 0 Then
                equal = obj.IdCha
            ElseIf obj.ChiTiet = 1 Then
                equal = obj.IdCha
            End If
        End If

        Return equal
    End Function

    ''' <summary>
    ''' Lay danh sach cac cot duoc phep hien thi tren gridview dua vao object de insert  hoac update
    ''' </summary>
    ''' <param name="ht_baocao_focused">object ht_baocao dang duoc focus</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function GetCaption(ByVal ht_baocao_focused As HtBaocao) As HtBaocao
        Dim ht_baocao As New HtBaocao

        ht_baocao.IdCha = GetIDCHAByObj(ht_baocao_focused)
        ht_baocao.ChiTiet = 1
        ht_baocao.MaBaocao = ht_baocao_focused.MaBaocao
        ht_baocao.TenBangDulieu = ht_baocao_focused.TenBangDulieu
        ht_baocao.TenBaocao = txtTenBaocao.Text
        ht_baocao.TenProcedure = ht_baocao_focused.TenProcedure
        ht_baocao.Id = ht_baocao_focused.Id

        Dim string_cap As String = String.Empty
        Dim string_dis As String = String.Empty

        For i = 0 To Me.list_caption.Count - 1
            If string_cap.Equals(String.Empty) Then
                string_cap = Me.list_caption(i).CotHienthi
            Else
                string_cap = string_cap + "," + Me.list_caption(i).CotHienthi
            End If
            If string_dis.Equals(String.Empty) Then
                string_dis = Me.list_caption(i).TenHienThi
            Else
                string_dis = string_dis + "," + Me.list_caption(i).TenHienThi
            End If
        Next

        ht_baocao.CotHienthi = string_cap
        ht_baocao.TenHienthi = string_dis

        Return ht_baocao
    End Function

    ''' <summary>
    ''' Bat popup chon sua thu muc cha
    ''' </summary>
    ''' <param name="flag">True: neu checbox sua checked, False neu uncheck</param>
    ''' <remarks></remarks>
    Private Sub LoadPopupTree(ByVal flag As Boolean)
        'Lay id cha node dang focus gan cho bien global
        Dim ht_bc_obj As New HtBaocao
        ht_bc_obj = CType(treeMain.GetDataRecordByNode(GetNodeFocusing()), HtBaocao)

        Me.edit_obj_cha = New HtBaocao
        Me.edit_obj_cha = ht_bc_obj

        If flag Then
            Dim tree As ReportTreeListControl
            tree = ObjectFactory.GetObject("ReportTreeListControl")
            tree.input_obj_htbc = ht_bc_obj
            Dim result = tree.ShowDialog()
            If result = Windows.Forms.DialogResult.OK Then
                'node cha cua node dang focus se dc gan = node moi
                Me.edit_obj_cha = tree.ResultObject
                'Hien thi ten bao cao cua node moi ra textedit
                txtCha.Text = tree.ResultObject.TenBaocao
                'Thoat popup
                tree.Close()
                Me.Focus()
            End If
        End If
    End Sub

    ''' <summary>
    ''' Lay node dang duoc focus
    ''' </summary>
    ''' <returns>node kieu TreeListNode</returns>
    ''' <remarks></remarks>
    Private Function GetNodeFocusing() As TreeListNode
        Return treeMain.FindNodeByID(treeMain.FocusedNode.Id)
    End Function

    Private Function GetNodeFocused() As HtBaocao
        Dim node As TreeListNode = treeMain.FindNodeByID(treeMain.FocusedNode.Id)
        Dim ht_baocao As HtBaocao = CType(treeMain.GetDataRecordByNode(node), HtBaocao)
        Return ht_baocao
    End Function
#End Region

#Region "Events"
    Private Sub frmEditSettings_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            'Khoi tao cac bien truoc khi su dung
            Me.obj_focus = New HtBaocao
            Me.lst_bien_del = New List(Of HtBienBaocao)
            Me.lst_file_del = New List(Of HtFileBaocao)

            'Load tree
            Try
                GetListHT_BAOCAO()
                treeMain.DataSource = Me.list_baocao
            Catch ex As Exception
            End Try
            LoadData(obj_focus)
            SetObjectToControl(obj_focus)

            SetStatusControl(DataInputState.AddMode)

            treeMain.CollapseAll()
            Dim node As TreeListNode
            node = treeMain.FindNodeByFieldValue("ID", TopNode.Id)
            treeMain.SetFocusedNode(node)

            'Add handle cho node focus
            AddHandler treeMain.FocusedNodeChanged, AddressOf treeMain_FocusedNodeChanged
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub treeMain_FocusedNodeChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraTreeList.FocusedNodeChangedEventArgs)
        Try
            If e.Node Is Nothing Then Return

            If Not e.Node.HasChildren Then
                'Is Report
                frmProgress.Instance().Thread = AddressOf FocusNodeChange
                frmProgress.Instance().Show_Progress("Đang tải dữ liệu...", "Xong")
            Else
                'Is Folder
                FocusNodeChange()
            End If
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub grcCaption_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles grcCaption.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                'If (GridHelper.CheckAddNewRow(grvCaption)) Then
                '    Me.list_caption.Add(New ColumnReportInfo)
                '    grvCaption.RefreshData()
                'End If
                SendKeys.Send("{TAB}")
            End If
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub grcFilebaocao_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles grcFilebaocao.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                'If (GridHelper.CheckAddNewRow(grvFilebaocao)) Then
                '    Me.list_caption.Add(New ColumnReportInfo)
                '    grvFilebaocao.RefreshData()
                'End If
                SendKeys.Send("{TAB}")
            End If
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub grcBienbaocao_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles grcBienbaocao.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                'If (GridHelper.CheckAddNewRow(grvBienbaocao)) Then
                '    Me.list_caption.Add(New ColumnReportInfo)
                '    grvBienbaocao.RefreshData()
                'End If
                SendKeys.Send("{TAB}")
            End If
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub grcCaption_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grcCaption.Enter
        Me.grid_focused = 0
    End Sub

    Private Sub grcFilebaocao_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grcFilebaocao.Enter
        Me.grid_focused = 1
    End Sub

    Private Sub grcBienbaocao_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grcBienbaocao.Enter
        Me.grid_focused = 2
    End Sub

    Private Sub frmEditSettings_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Try
            Select Case e.KeyCode
                Case Keys.Escape
                    CloseForm()
                    Exit Select
            End Select
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub grvCaption_CellValueChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles grvCaption.CellValueChanged, grvFilebaocao.CellValueChanged, grvBienbaocao.CellValueChanged
        Me.edit_flag = True
    End Sub

    Private Sub rdoType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdoType.SelectedIndexChanged
        Try
            If rdoType.EditValue = 0 Then
                txtMaBaocao.Text = "N"
                txtStore.Text = "N"
                txtTenBang.Text = "N"
                txt_Loai_BC.Text = "0"
            ElseIf rdoType.EditValue = 3 Then
                txtMaBaocao.Text = "N"
                txtStore.Text = "N"
                txtTenBang.Text = "N"
                txt_Loai_BC.Text = "1"
            End If
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub txtCha_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCha.Click
        Try
            LoadPopupTree(Not txtCha.Properties.ReadOnly)
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub chkEdit_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkEdit.CheckedChanged
        Try
            txtCha.Properties.ReadOnly = Not chkEdit.Checked
            LoadPopupTree(chkEdit.Checked)
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub treeMain_GetStateImage(ByVal sender As System.Object, ByVal e As DevExpress.XtraTreeList.GetStateImageEventArgs) Handles treeMain.GetStateImage
        Try
            Dim obj As HtBaocao = CType(CType(treeMain.GetDataRecordByNode(e.Node), HtBaocao), HtBaocao)
            If obj.ChiTiet = 0 Then
                e.NodeImageIndex = 0
            Else
                e.NodeImageIndex = 16
            End If
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub txt_Loai_BC_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_Loai_BC.EditValueChanged
        Try
            Dim iCheck As Integer = Integer.Parse(txt_Loai_BC.Text)
            If iCheck = 3 Then
                txtFullPath.Properties.ReadOnly = False
            Else
                txtFullPath.Properties.ReadOnly = True
            End If
        Catch
            txtFullPath.Properties.ReadOnly = True
        End Try
    End Sub
#End Region

#Region "Function"
    ''' <summary>
    ''' Xoa node dang focus
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub Delete()
        Dim current_focus_node As HtBaocao = obj_focus
        Dim list_child_node As New List(Of HtBaocao)
        list_child_node.AddRange(_HtBaocaoService.GetByIDCha(current_focus_node.Id))

        'Xoa multi cap
        If Message_Confirm("Bạn có chắc chắn xóa '" + current_focus_node.TenBaocao + _
                           "' không?") Then
            If list_child_node.Count > 0 And Me.del_force_flag < 1 Then
                Message_Information("Phải xóa hết các báo cáo con của thư mục '" + current_focus_node.TenBaocao + "'")
                Me.del_force_flag += 1
            ElseIf Me.del_force_flag >= 1 Then
                If MessageBox.Show("CẢNH BÁO! NHẤN YES NẾU BẮT BUỘC PHẢI XÓA BÁO CÁO NÀY", Application.ProductName, _
                                   MessageBoxButtons.YesNo, MessageBoxIcon.Warning) _
                                   = Windows.Forms.DialogResult.Yes Then
                    Me.del_force_flag = 0
                    'Xoa node cha va cac node con
                    Del(current_focus_node)
                End If
            Else
                dele(current_focus_node)
                Me.del_force_flag = 0
            End If

            'Xoa node cha va cac node con
            'Del(current_focus_node)
        End If
    End Sub

    ''' <summary>
    ''' Chi xoa bao cao
    ''' </summary>
    ''' <param name="ht_bc">object kieu ht_baocao</param>
    ''' <remarks></remarks>
    Private Sub dele(ByVal ht_bc As HtBaocao)
        'Del ht_baocao
        _HtBaocaoService.Delete(ht_bc)
        'Del ht_file
        Dim list_ht_file As New List(Of HtFileBaocao)
        list_ht_file.AddRange(_HtFileBaocaoService.GetByHTBAOCAOID(ht_bc.Id))
        For Each item In list_ht_file
            _HtFileBaocaoService.Delete(item)
        Next

        'Del ht_ien
        Dim list_ht_bien As New List(Of HtBienBaocao)
        list_ht_bien.AddRange(_HtBienBaocaoService.GetByHTBAOCAOID(ht_bc.Id))
        For Each item In list_ht_bien
            _HtBienBaocaoService.Delete(item)
        Next

        If Not VnsCheck.IsNullGuid(ht_bc.IdCha) Then
            LoadTree(ht_bc.IdCha)
        Else
            LoadTree(TopNode().Id)
        End If

        Dim node As TreeListNode
        node = treeMain.FindNodeByID(treeMain.FocusedNode.Id)
        node.Expanded = True
    End Sub

    Private _IDBaocao As Guid = New Guid()
    'Focus change
    Private Sub FocusNodeChange()
        Dim ht_baocao As New HtBaocao
        'Khoi tao bien gloal
        Dim node As TreeListNode
        node = treeMain.FindNodeByID(treeMain.FocusedNode.Id)
        ht_baocao = CType(treeMain.GetDataRecordByNode(node), HtBaocao)
        obj_focus = ht_baocao

        GroupControl1.Text = "Thông tin báo cáo: " + ht_baocao.Id.ToString
        _IDBaocao = ht_baocao.Id

        SetStatusControl(DataInputState.ViewMode)

        SetEnableControl(True)

        LoadData(obj_focus)
        SetObjectToControl(obj_focus)
        If Not ht_baocao.LoaiBaocao = 3 Then
            tabMain.Enabled = True
        Else
            tabMain.Enabled = False
        End If

        'Set trang thai check cua chkedit = false
        chkEdit.Checked = False
        chkEdit.Properties.ReadOnly = True
        txtFullPath.Properties.ReadOnly = True
    End Sub

    ''' <summary>
    ''' Set status control
    ''' </summary>
    ''' <param name="status"></param>
    ''' <remarks></remarks>
    Private Sub SetStatusControl(ByVal status As DataInputState)
        Select Case status
            Case DataInputState.ViewMode
                'Huy bo them sua
                Me.f_insr = False
                Me.f_upd = False

                'Load trang thai cac button
                btnLuu.Enabled = False
                btnDRow.Enabled = False
                btnRow.Enabled = False

                btnNew.Enabled = True
                btnEdit.Enabled = True
                btnXBC.Enabled = True
                btnHuy.Enabled = False

                SetEnableControl(True)
            Case DataInputState.EditMode
                'Xac nhan trang thai sua
                Me.f_insr = False
                Me.f_upd = True
                'Load trang thai button
                SetEnableControl(False)

                btnLuu.Enabled = True
                btnDRow.Enabled = True
                btnRow.Enabled = True

                btnNew.Enabled = False
                btnEdit.Enabled = False
                btnXBC.Enabled = False
                btnHuy.Enabled = True
            Case DataInputState.AddMode
                'Bien xac nhan bat che do them moi
                Me.f_insr = True
                Me.f_upd = False

                'Load trang thai cac button
                SetEnableControl(False)

                btnLuu.Enabled = True
                btnDRow.Enabled = True
                btnRow.Enabled = True

                btnNew.Enabled = False
                btnEdit.Enabled = False
                btnXBC.Enabled = False
                btnHuy.Enabled = True
            Case Else
        End Select

    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="val"></param>
    ''' <remarks></remarks>
    Private Sub SetEnableControl(ByVal val As Boolean)
        txtTenBang.Properties.ReadOnly = val
        txtMaBaocao.Properties.ReadOnly = val
        txtStore.Properties.ReadOnly = val
        txtTenBaocao.Properties.ReadOnly = val
        txt_Loai_BC.Properties.ReadOnly = val
        txtThuTu.Properties.ReadOnly = val
        rdoType.Properties.ReadOnly = val
        grvBienbaocao.OptionsBehavior.Editable = Not val
        grvCaption.OptionsBehavior.Editable = Not val
        grvFilebaocao.OptionsBehavior.Editable = Not val
    End Sub
#End Region

#Region "Button Click"
    Private Sub btnLuu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLuu.Click
        Try
            If txtTenBaocao.Enabled = True Then
                If rdoType.EditValue = 0 Or rdoType.EditValue = 3 Then
                    txtMaBaocao.Text = "N"
                    txtStore.Text = "N"
                    txtTenBang.Text = "N"
                    txt_Loai_BC.Text = "1"
                End If
                If txtMaBaocao.Text.Equals(String.Empty) Then
                    Message_Information("Vui lòng nhập " + lblMaBC.Text + " cho " + txtTenBaocao.Text)
                ElseIf txtTenBang.Text.Equals(String.Empty) Then
                    Message_Information("Vui lòng nhập " + lblTenBang.Text + " cho " + txtTenBaocao.Text)
                ElseIf txtTenBaocao.Text.Equals(String.Empty) Then
                    Message_Information("Vui lòng nhập " + lblTenHienThi.Text + " cho " + txtTenBaocao.Text)
                ElseIf rdoType.EditValue Is Nothing Then
                    Message_Information("Vui lòng chọn " + lblKieu.Text + " cho " + txtTenBaocao.Text)
                Else
                    If Me.f_insr Then
                        SaveNewInsert()
                        SetStatusControl(DataInputState.ViewMode)
                    ElseIf Me.f_upd Then
                        SaveUpdateBC()
                        SetStatusControl(DataInputState.ViewMode)
                    Else
                        Message_Confirm("Không rõ trạng thái thêm mới hay sửa đổi")
                    End If
                End If
            End If
            txtFullPath.Properties.ReadOnly = True
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub btExport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btExport.Click
        Dim expds As DataSet = New DataSet()

        ''Dim node As TreeListNode
        Dim ht_baocao_focused As New HtBaocao
        'ht_baocao_focused = CType(treeMain.GetDataRecordByNode(node), HtBaocao)
        ht_baocao_focused = CType(treeMain.GetDataRecordByNode(treeMain.FocusedNode), HtBaocao)

        Dim array(3) As DataTable

        Dim expHtBaocao As HtBaocao = _HtBaocaoService.GetById(_IDBaocao)
        Dim explstHtBc As IList(Of HtBaocao) = New List(Of HtBaocao)()
        explstHtBc.Add(expHtBaocao)
        array(0) = DataHelper.ToDataTable(Of HtBaocao)(explstHtBc)
        array(0).TableName = "HtBaocao"

        Dim lstExpHtBien As New List(Of HtBienBaocao)
        lstExpHtBien.AddRange(_HtBienBaocaoService.GetByHTBAOCAOID(_IDBaocao))
        array(1) = DataHelper.ToDataTable(Of HtBienBaocao)(lstExpHtBien)
        array(1).TableName = "HtBienBaocao"

        Dim lstExpHtFile As New List(Of HtFileBaocao)
        lstExpHtFile.AddRange(_HtFileBaocaoService.GetByHTBAOCAOID(_IDBaocao))
        array(2) = DataHelper.ToDataTable(Of HtFileBaocao)(lstExpHtFile)
        array(2).TableName = "HtFileBaocao"

        expds.Tables.Add(array(0).Copy())
        expds.Tables.Add(array(1).Copy())
        expds.Tables.Add(array(2).Copy())
        Dim ofd As New SaveFileDialog()
        ofd.Filter = "XML file|*.xml"
        If ofd.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            expds.WriteXml(ofd.FileName)
        End If
    End Sub

    Private Sub btImport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btImport.Click
        Dim expds As DataSet = New DataSet()
        Dim ofd As New OpenFileDialog()
        ofd.Filter = "XML file|*.xml"
        If Not (ofd.ShowDialog() = System.Windows.Forms.DialogResult.OK) Then
            Return
        End If

        Dim OverWrite As Boolean = True
        If Not (Message_Confirm("Load đè dữ liệu cũ?")) Then
            OverWrite = False
            SetStatusControl(DataInputState.EditMode)
        Else
            SetStatusControl(DataInputState.AddMode)
        End If

        expds.ReadXml(ofd.FileName)
        Dim HtBaocao1 As HtBaocao = New HtBaocao()
        For Each drhtbc As DataRow In expds.Tables("HtBaocao").Rows
            'DataRow_FillObject(drhtbc, HtBaocao1)
            HtBaocao1 = CType(Vns.Erp.Core.Object_GetDataRaw(HtBaocao1, drhtbc), HtBaocao)
            If (OverWrite) Then
                HtBaocao1.Id = obj_focus.Id
                HtBaocao1.IdCha = obj_focus.IdCha
            Else
                HtBaocao1.IdCha = obj_focus.IdCha
            End If
        Next

        Dim lstBienBC As List(Of HtBienBaocao) = New List(Of HtBienBaocao)()
        For Each drhtbc As DataRow In expds.Tables("HtBienBaocao").Rows
            Dim tempbien As HtBienBaocao = New HtBienBaocao()
            tempbien = CType(Vns.Erp.Core.Object_GetDataRaw(tempbien, drhtbc), HtBienBaocao)
            'DataRow_FillObject(drhtbc, tempbien)
            tempbien.Id = Null.NullGuid
            If (OverWrite) Then
                tempbien.IdHtBaocao = obj_focus.Id
            End If
            lstBienBC.Add(tempbien)
        Next

        Dim lstFileBC As List(Of HtFileBaocao) = New List(Of HtFileBaocao)()
        For Each drhtbc As DataRow In expds.Tables("HtFileBaocao").Rows
            Dim tempfile As HtFileBaocao = New HtFileBaocao()
            tempfile = CType(Vns.Erp.Core.Object_GetDataRaw(tempfile, drhtbc), HtFileBaocao)
            'DataRow_FillObject(drhtbc, tempfile)
            tempfile.Id = Null.NullGuid
            If (OverWrite) Then
                tempfile.HtBaocaoId = obj_focus.Id
            End If
            lstFileBC.Add(tempfile)
        Next

        Me.lst_bien_del.AddRange(Me.list_bien)
        Me.lst_file_del.AddRange(Me.list_file)

        Me.list_file = lstFileBC
        Me.list_bien = lstBienBC

        SetObjectToControl(HtBaocao1)
    End Sub

    Private Sub btnHuy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHuy.Click
        Try
            SetStatusControl(DataInputState.ViewMode)
            txtFullPath.Properties.ReadOnly = True
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        Try
            SetStatusControl(DataInputState.EditMode)

            If GetNodeFocused.ChiTiet = 0 Then
                tabMain.Enabled = False
            End If

            'Check cho phep sua id cha
            chkEdit.Properties.ReadOnly = False
            Try
                Dim icheck As Integer = Integer.Parse(txt_Loai_BC.Text)
                If icheck = 3 Then
                    txtFullPath.Properties.ReadOnly = False
                Else
                    txtFullPath.Properties.ReadOnly = True
                End If
            Catch
                txtFullPath.Properties.ReadOnly = True
            End Try
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub SimpleButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQui.Click
        Try
            CloseForm()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub btnXoabc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnXBC.Click
        Try
            Delete()
            'frmProgress.Instance.Thread = AddressOf Delete
            'frmProgress.Instance.Show_Progress()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub btnThembc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        Try
            SetStatusControl(DataInputState.AddMode)
            'Khoi tao
            Me.list_bien = New List(Of HtBienBaocao)
            Me.list_caption = New List(Of ColumnReportInfo)
            Me.list_file = New List(Of HtFileBaocao)

            Me.list_bien.Add(New HtBienBaocao)
            Me.list_caption.Add(New ColumnReportInfo)
            Me.list_file.Add(New HtFileBaocao)

            grcBienbaocao.DataSource = Me.list_bien
            grcCaption.DataSource = Me.list_caption
            grcFilebaocao.DataSource = Me.list_file

            Me.obj_focus = New HtBaocao
            Me.obj_focus.Id = Nothing

            txtStore.Text = ""
            txtMaBaocao.Text = ""
            txtTenBang.Text = ""
            txtTenBaocao.Text = ""
            txt_Loai_BC.Text = "1"
            txtFullPath.Text = ""
            Try
                Dim icheck As Integer = Integer.Parse(txt_Loai_BC.Text)
                If icheck = 3 Then
                    txtFullPath.Properties.ReadOnly = False
                Else
                    txtFullPath.Properties.ReadOnly = True
                End If
            Catch
                txtFullPath.Properties.ReadOnly = True
            End Try
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRow.Click
        Try
            If Me.grid_focused = 0 Then
                Me.list_caption.Add(New ColumnReportInfo)
                grvCaption.RefreshData()
            ElseIf Me.grid_focused = 1 Then
                Me.list_file.Add(New HtFileBaocao)
                grvFilebaocao.RefreshData()
            ElseIf Me.grid_focused = 2 Then
                Me.list_bien.Add(New HtBienBaocao)
                grvBienbaocao.RefreshData()
            End If
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDRow.Click
        Try
            If Me.grid_focused = 0 Then
                If grvCaption.RowCount > 0 Then
                    Dim thisLine As ColumnReportInfo = CType(grvCaption.GetRow(grvCaption.FocusedRowHandle), ColumnReportInfo)
                    Me.list_caption.Remove(thisLine)
                    grvCaption.RefreshData()
                Else
                    Message_Warning("Không có bản ghi nào được lựa chọn!")
                End If
            ElseIf Me.grid_focused = 1 Then
                If grvFilebaocao.RowCount > 0 Then
                    Dim thisLine As HtFileBaocao = CType(grvFilebaocao.GetRow(grvFilebaocao.FocusedRowHandle), HtFileBaocao)
                    Me.list_file.Remove(thisLine)
                    If thisLine.Id <> Nothing Then
                        'Dua vao danh sach can del
                        Me.lst_file_del.Add(thisLine)
                    End If
                    grvFilebaocao.RefreshData()
                Else
                    Message_Warning("Không có bản ghi nào được lựa chọn!")
                End If

            ElseIf Me.grid_focused = 2 Then
                If grvBienbaocao.RowCount > 0 Then
                    Dim thisLine As HtBienBaocao = CType(grvBienbaocao.GetRow(grvBienbaocao.FocusedRowHandle), HtBienBaocao)
                    Me.list_bien.Remove(thisLine)
                    If thisLine.Id <> Nothing Then
                        'Dua vao ds can del
                        Me.lst_bien_del.Add(thisLine)
                    End If
                    grvBienbaocao.RefreshData()
                Else
                    Message_Warning("Không có bản ghi nào được lựa chọn!")
                End If
            End If
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub
#End Region
End Class