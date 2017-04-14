Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports System.ComponentModel
Imports DevExpress.XtraEditors.DXErrorProvider
Imports DevExpress.XtraTreeList
Imports System.Data
Imports DevExpress.XtraTreeList.Nodes
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraTreeList.Columns
Imports DevExpress.XtraGrid.Columns
Imports System.Collections
Imports System.Globalization
Imports DevExpress.XtraEditors.Repository
Imports System.Data.SqlClient
Imports DevExpress.XtraTab
Imports System.Drawing


Public Class TNCommon
    Public Shared CURENTCY_FORMAT As String = "{0:0,0.0}"

    Public Shared Sub setIconControl(ByVal oGetForm As XtraForm)
        For Each btn As Control In oGetForm.Controls
            GetButton(btn)
        Next
    End Sub

    Public Shared Sub GetButton(ByVal oControl As Control)
        If TypeOf (oControl) Is SimpleButton Then
            setIconSimpleButton(oControl, oControl.Name)
        ElseIf TypeOf (oControl) Is PanelControl _
            Or TypeOf (oControl) Is GroupControl _
            Or TypeOf (oControl) Is XtraTabControl _
            Or TypeOf (oControl) Is XtraTabPage _
            Then
            For Each ctrl As Control In oControl.Controls
                GetButton(ctrl)
            Next
        End If
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="btn"></param>
    ''' <param name="strName"></param>
    ''' <remarks></remarks>
    Public Shared Sub setIconSimpleButton(ByVal btn As SimpleButton, ByVal strName As String)
        If strName.Length < 6 Then
            Return
        End If
        Select Case btn.Name.Substring(0, 6)
            Case "btnAdd"
                btn.Image = My.Resources.Add
                btn.Text = "&Mới"
                btn.Size = New Size(80, 30)
            Case "btnCre"
                btn.Image = My.Resources.Add
                btn.Text = "Thêm"
                btn.Size = New Size(80, 30)
            Case "btnRow"
                btn.Image = My.Resources.Add
                btn.Text = "Thêm dòng"
                btn.Size = New Size(80, 30)
            Case "btnMod"
                btn.Image = My.Resources.Edit
                btn.Text = "&Sửa"
                btn.Size = New Size(80, 30)
            Case "btnSav"
                btn.Image = My.Resources.Save
                btn.Text = "&Lưu"
                btn.Size = New Size(80, 30)
            Case "btnSAl"
                btn.Image = My.Resources.SaveAll
                btn.Text = "Lưu"
                btn.Size = New Size(80, 30)
            Case "btnChu"
                btn.Image = My.Resources.Replace
                btn.Text = "Chuyển"
                btn.Size = New Size(80, 30)
            Case "btnSCl"
                btn.Image = My.Resources.SaveAndClose
                btn.Text = "Lưu"
                btn.Size = New Size(80, 30)

            Case "btnCop"
                btn.Image = My.Resources.Copy
                btn.Text = "Sao chép"
                btn.Size = New Size(80, 30)
            Case "btnDel"
                btn.Image = My.Resources.Delete
                btn.Text = "&Xóa"
                btn.Size = New Size(80, 30)
            Case "btnDeR"
                btn.Image = My.Resources.DelRow
                btn.Text = "Xóa dòng"
                btn.Size = New Size(80, 30)
            Case "btnGia"
                btn.Image = My.Resources.DelRow
                btn.Text = "Giảm TS"
                btn.Size = New Size(80, 30)
            Case "btnClo"
                btn.Image = My.Resources.Close
                btn.Text = "Đó&ng"
                btn.Size = New Size(80, 30)
            Case "btnCan"
                btn.Image = My.Resources.Close
                btn.Text = "&Hủy"
                btn.Size = New Size(80, 30)
            Case "btnSea"
                btn.Image = My.Resources.Search
                btn.Text = "&Tìm kiếm"
                btn.Size = New Size(80, 30)
            Case "btnQui"
                btn.Image = My.Resources.Refresh
                btn.Text = "&Quay ra"
                btn.Size = New Size(80, 30)
            Case "btnCle"
                btn.Image = My.Resources.Clean
                btn.Text = "Xóa trắng"
                btn.Size = New Size(80, 30)
            Case "btnPri"
                btn.Image = My.Resources.Print
                'btn.Text = "&In"
                'btn.Size = New Size(80, 30)
            Case "btnThu"
                btn.Image = My.Resources.Preview
                btn.Text = "CT thuế"
                btn.Size = New Size(80, 30)
            Case "btnXac"
                btn.Image = My.Resources.Options
                btn.Text = "Xác nhận"
                btn.Size = New Size(80, 30)
            Case "btnOke"
                btn.Image = My.Resources.Active
                btn.Text = "Xong"
                btn.Size = New Size(80, 30)
            Case "btnDie"
                btn.Image = My.Resources.Active
                btn.Text = "Chuyển"
                btn.Size = New Size(80, 30)
                'btnExportExcel
            Case "btnExp"
                btn.Image = My.Resources.icExcel
                btn.Text = "Xuất Excel"
                btn.Size = New Size(90, 30)
            Case "btnNex"
                btn.Image = My.Resources.icNext
                btn.Text = ""
                btn.Size = New Size(25, 30)

            Case "btnPre"
                btn.Image = My.Resources.icBack
                btn.Text = ""
                btn.Size = New Size(25, 30)

            Case "btnLas"
                btn.Image = My.Resources.icLast
                btn.Text = ""
                btn.Size = New Size(25, 30)

            Case "btnFir"
                btn.Image = My.Resources.icFirst
                btn.Text = ""
                btn.Size = New Size(25, 30)

            Case "btnLoc"
                btn.Image = My.Resources.icLock
                btn.Text = "Khóa"
                btn.Size = New Size(80, 30)

            Case "btnUnl"
                btn.Image = My.Resources.icUnlock
                btn.Text = "Mở khóa"
                btn.Size = New Size(80, 30)

            Case "btnCon"
                btn.Image = My.Resources.Options
                btn.Text = "Xác nhận"
                btn.Size = New Size(80, 30)

        End Select

    End Sub

#Region "Notify"
    Public Shared Sub NotifyError(ByVal ex As Exception)
        MessageBox.Show(ex.Message & vbCr & vbLf & ex.Source & vbCr & vbLf & ex.StackTrace)
    End Sub

    Public Shared Sub Notify(ByVal message As String, ByVal caption As String)
        MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
#End Region

#Region "BindData"

    Public Shared Sub BindData4Refresh(ByVal obj As Object, ByVal _DataSource As [Object])
        If obj Is Nothing Then
            Throw New Exception("Viewer is null")
        End If
        If (TypeOf obj Is TreeList) Then
            Dim _TreeList As TreeList = TryCast(obj, TreeList)
            _TreeList.DataSource = _DataSource
            _TreeList.RefreshDataSource()
        End If
        If (TypeOf obj Is GridView) Then
            Dim _GridView As GridView = TryCast(obj, GridView)
            _GridView.GridControl.DataSource = _DataSource
            _GridView.GridControl.RefreshDataSource()
        End If
    End Sub

    'TreeList
    Public Shared Sub BindData_TreeList(ByVal obj As [Object], ByVal _DataSource As [Object], ByVal _KeyFieldName As String, ByVal _ParentFieldName As String, ByVal _ColumnDefine As ArrayList, ByVal _ExpanAll As Boolean)
        If obj Is Nothing Then
            Throw New Exception("Viewer is null")
        End If
        If Not (TypeOf obj Is TreeList) Then
            Throw New Exception("Viewer not is a TreeList")
        End If
        Dim _TreeList As TreeList = TryCast(obj, TreeList)
        _TreeList.OptionsBehavior.AutoPopulateColumns = False


        Dim _Columns As TreeListColumnCollection = _TreeList.Columns
        _Columns.Clear()

        Dim i As Integer = 0
        Dim tc As TreeListColumn
        For Each col As ColumnInfo In _ColumnDefine
            tc = _Columns.Insert(0)
            tc.VisibleIndex = i
            tc.FieldName = col.FieldName
            tc.MinWidth = 1
            If col.Width > 0 Then
                tc.OptionsColumn.FixedWidth = True
                tc.Width = col.Width
            End If

            tc.Visible = True
            tc.Caption = col.Caption
            tc.OptionsColumn.[ReadOnly] = col.[ReadOnly]
            tc.OptionsColumn.AllowEdit = Not col.[ReadOnly]
            i += 1
        Next

        _TreeList.KeyFieldName = _KeyFieldName
        _TreeList.ParentFieldName = _ParentFieldName
        _TreeList.DataSource = _DataSource
        If _ExpanAll Then
            _TreeList.ExpandAll()
        End If
    End Sub

    Public Shared Sub BindData_TreeList(ByVal obj As [Object], ByVal _DataSource As [Object], ByVal _KeyFieldName As String, ByVal _ParentFieldName As String, ByVal _ExpanAll As Boolean)
        If obj Is Nothing Then
            Throw New Exception("Viewer is null")
        End If
        If Not (TypeOf obj Is TreeList) Then
            Throw New Exception("Viewer not is a TreeList")
        End If
        Dim _TreeList As TreeList = TryCast(obj, TreeList)
        If TypeOf _DataSource Is DataTable Then
            _TreeList.KeyFieldName = _KeyFieldName
            _TreeList.ParentFieldName = _ParentFieldName
            _TreeList.DataSource = _DataSource
            If _ExpanAll Then
                _TreeList.ExpandAll()
            End If
        End If
    End Sub

    Public Shared Sub TreeList_SetNodeFocus(ByVal obj As [Object], ByVal _FocusValue As Object)
        If _FocusValue Is Nothing Then
            Return
        End If
        If TypeOf obj Is TreeList Then
            Dim _TreeList As TreeList = TryCast(obj, TreeList)
            Dim node As TreeListNode = _TreeList.FindNodeByFieldValue(_TreeList.KeyFieldName, _FocusValue)
            If node IsNot Nothing Then
                _TreeList.SetFocusedNode(node)
            End If
        End If
    End Sub

    'Lookup
    Public Shared Sub BindData_LookupEdit(ByVal _LookupEdit As LookUpEdit, ByVal _DataSource As [Object], ByVal _DisplayMember As String, ByVal _ValueMember As String, ByVal _ColumnDefine As ArrayList, ByVal _Editable As Boolean, _
     ByVal _FirstSelect As Boolean)

        _LookupEdit.Properties.DisplayMember = _DisplayMember
        _LookupEdit.Properties.ValueMember = _ValueMember
        _LookupEdit.Properties.NullText = ""
        _LookupEdit.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        If _Editable Then
            _LookupEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        End If
        _LookupEdit.Properties.ImmediatePopup = True

        If _ColumnDefine Is Nothing OrElse _ColumnDefine.Count <= 0 Then
            Return
        End If
        Dim _Columns As LookUpColumnInfoCollection = _LookupEdit.Properties.Columns

        _Columns.Clear()
        Dim i As Integer = 0
        For Each col As ColumnInfo In _ColumnDefine
            Dim luci As New LookUpColumnInfo(col.FieldName, col.Caption)
            If col.DisplayFormat <> "" Then
                luci.FormatString = col.DisplayFormat
            End If
            _Columns.Add(luci)
            i += 1
        Next

        _LookupEdit.Properties.DataSource = _DataSource
        _LookupEdit.Update()
        Try
            If _FirstSelect Then
                Return
                '_LookupEdit.BindingContextChanged += new EventHandler(_LookupEdit_BindingContextChanged);
            End If

        Catch ex As Exception
        End Try
    End Sub

    Private Shared Sub _LookupEdit_BindingContextChanged(ByVal sender As Object, ByVal e As EventArgs)
        Try
            Dim _LookupEdit As LookUpEdit = TryCast(sender, LookUpEdit)
            _LookupEdit.ItemIndex = 0

        Catch ex As Exception
        End Try
    End Sub

    Public Shared Sub BindData_LookupEdit(ByVal _LookupEdit As LookUpEdit, ByVal _DataSource As [Object], ByVal _DisplayMember As String, ByVal _ValueMember As String, ByVal _ColumnDefine As ArrayList, ByVal _Editable As Boolean)
        BindData_LookupEdit(_LookupEdit, _DataSource, _DisplayMember, _ValueMember, _ColumnDefine, _Editable, _
         False)
    End Sub
    Public Shared Sub BindData_LookupEdit(ByVal _LookupEdit As LookUpEdit, ByVal _DataSource As [Object], ByVal _DisplayMember As String, ByVal _ValueMember As String)
        BindData_LookupEdit(_LookupEdit, _DataSource, _DisplayMember, _ValueMember, Nothing, False, _
         False)
    End Sub

    'GridView
    Public Shared Sub BindData_GridView(ByVal obj As [Object], ByVal DataSource As Object, ByVal _ColumnDefine As ArrayList)
        If obj Is Nothing Then
            Throw New Exception("Viewer is null")
        End If
        If Not (TypeOf obj Is GridView) Then
            Throw New Exception("Viewer not is a GridView")
        End If
        Dim _GridView As GridView = TryCast(obj, GridView)

        If _ColumnDefine IsNot Nothing AndAlso _ColumnDefine.Count <> 0 Then
            _GridView.OptionsBehavior.AutoPopulateColumns = False
            Dim _Columns As GridColumnCollection = _GridView.Columns
            _Columns.Clear()

            Dim i As Integer = 0
            Dim gc As GridColumn
            For Each col As ColumnInfo In _ColumnDefine
                gc = _Columns.Add()
                gc.Caption = col.Caption
                gc.FieldName = col.FieldName
                If col.Width > 0 Then
                    gc.MaxWidth = col.Width
                    gc.MinWidth = col.Width
                End If
                gc.VisibleIndex = i
                gc.OptionsColumn.AllowEdit = Not col.[ReadOnly]
                gc.Visible = col.Visible
                If col.DisplayFormat <> "" Then
                    gc.DisplayFormat.FormatString = col.DisplayFormat
                End If
                i += 1

            Next
        End If
        _GridView.GridControl.DataSource = DataSource
    End Sub
    Public Shared Sub BindData_GridView(ByVal obj As [Object], ByVal DataSource As Object)
        If obj Is Nothing Then
            Throw New Exception("Viewer is null")
        End If
        If Not (TypeOf obj Is GridView) Then
            Throw New Exception("Viewer not is a GridView")
        End If
        Dim _GridView As GridView = TryCast(obj, GridView)
        _GridView.GridControl.DataSource = DataSource
    End Sub

    'GridLookup
    Public Shared Sub BindData_GridLookUp(ByVal obj As [Object], ByVal _DataSource As Object, ByVal _DisplayMember As String, ByVal _ValueMember As String, ByVal _ColumnDefine As ArrayList, ByVal _Editable As Boolean)
        If _DataSource Is Nothing Then
            Return
        End If
        If Not (TypeOf _DataSource Is DataTable OrElse TypeOf _DataSource Is ArrayList OrElse TypeOf _DataSource Is IList) Then
            Throw New Exception("(Bind Data GridLookup) Not support DataSource " & _DataSource.[GetType]().Name)
        End If
        If obj Is Nothing Then
            Throw New Exception("(Bind Data GridLookup) Viewer is null")
        End If
        If Not (TypeOf obj Is GridLookUpEdit) Then
            Throw New Exception("(Bind Data GridLookup) Viewer not is a GridLookUpEdit")
        End If
        Dim _GridLookUpEdit As GridLookUpEdit = TryCast(obj, GridLookUpEdit)

        _GridLookUpEdit.Properties.DisplayMember = _DisplayMember
        _GridLookUpEdit.Properties.ValueMember = _ValueMember
        _GridLookUpEdit.Properties.ShowFooter = False
        _GridLookUpEdit.Properties.ShowPopupShadow = False
        _GridLookUpEdit.Properties.BestFitMode = BestFitMode.BestFitResizePopup
        '_GridLookUpEdit.Properties.View.OptionsBehavior.SmartVertScrollBar = true;
        '_GridLookUpEdit.Properties.View.OptionsView.AnimationType = DevExpress.XtraGrid.Views.Base.GridAnimationType.AnimateFocusedItem;
        _GridLookUpEdit.Properties.PopupFilterMode = PopupFilterMode.Contains

        If _Editable Then
            _GridLookUpEdit.Properties.TextEditStyle = TextEditStyles.Standard
        End If

        If _ColumnDefine IsNot Nothing AndAlso _ColumnDefine.Count <> 0 Then
            _GridLookUpEdit.Properties.View.OptionsBehavior.AutoPopulateColumns = False
            Dim _Column As GridColumnCollection = _GridLookUpEdit.Properties.View.Columns
            _Column.Clear()
            Dim gc As GridColumn
            Dim i As Integer = 0
            For Each col As ColumnInfo In _ColumnDefine
                gc = _Column.Add()
                gc.Caption = col.Caption
                gc.FieldName = col.FieldName
                gc.MinWidth = 1
                If col.Width > 0 Then
                    gc.Width = col.Width
                End If
                gc.VisibleIndex = i
                gc.Visible = col.Visible
                If col.DisplayFormat <> "" Then
                    gc.DisplayFormat.FormatString = col.DisplayFormat
                End If
                i += 1

            Next
        End If
        _GridLookUpEdit.Properties.DataSource = _DataSource
    End Sub
    Public Shared Sub BindData_GridLookUp(ByVal obj As [Object], ByVal _DataSource As Object, ByVal _DisplayMember As String, ByVal _ValueMember As String, ByVal _ColumnDefine As ArrayList, ByVal _Editable As Boolean, _
     ByVal _SelectedFirst As Boolean)
        BindData_GridLookUp(obj, _DataSource, _DisplayMember, _ValueMember, _ColumnDefine, _Editable)
        If _SelectedFirst Then
            '_GridLookUpEdit.BindingContextChanged += new EventHandler(_GridLookUpEdit_BindingContextChanged);
            Dim _GridLookUpEdit As GridLookUpEdit = TryCast(obj, GridLookUpEdit)
        End If
    End Sub

    Public Shared Sub SelectFirst(ByVal sender As Object)
        Try
            If TypeOf sender Is GridLookUpEdit Then
                Dim _GridLookUpEdit As GridLookUpEdit = TryCast(sender, GridLookUpEdit)
                    Dim objx As Object = _GridLookUpEdit.Properties.GetKeyValue(0)
                    _GridLookUpEdit.EditValue = objx
                    Return
                End If
                If TypeOf sender Is LookUpEdit Then
                    Dim _LookupEdit As LookUpEdit = TryCast(sender, LookUpEdit)
                    _LookupEdit.ItemIndex = 0
                    Return
                End If
                MessageBox.Show("Not support control type is " & sender.[GetType]().ToString())

        Catch ex As Exception
        End Try
    End Sub


    ''' <summary>
    ''' Dung cho GridLookUp, lay object ban ghi dang duoc fucus
    ''' </summary>
    ''' <param name="sender">Ten GridLookUp</param>
    ''' <returns>Object</returns>
    ''' <remarks></remarks>
    Public Shared Function GetObjFocus_GridLookup(ByVal sender As DevExpress.XtraEditors.GridLookUpEdit) As Object
        Try
            Dim obj As Object = sender.Properties.View.GetRow(sender.Properties.View.FocusedRowHandle)
            Return obj
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
#End Region
    '------------------------------------------bindData_lookupEdit_List----------------
    Public Shared Sub BindData_LookupEdit_List(ByVal _LookupEdit As LookUpEdit, ByVal _DataSource As [Object], ByVal _DisplayMember As String, ByVal _ColumnDefine As ArrayList, ByVal _Editable As Boolean, _
      ByVal _FirstSelect As Boolean)

        _LookupEdit.Properties.DisplayMember = _DisplayMember
        ' _LookupEdit.Properties.ValueMember = _ValueMember
        _LookupEdit.Properties.NullText = ""
        _LookupEdit.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        If _Editable Then
            _LookupEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        End If
        _LookupEdit.Properties.ImmediatePopup = True

        If _ColumnDefine Is Nothing OrElse _ColumnDefine.Count <= 0 Then
            Return
        End If
        Dim _Columns As LookUpColumnInfoCollection = _LookupEdit.Properties.Columns

        _Columns.Clear()
        Dim i As Integer = 0
        For Each col As ColumnInfo In _ColumnDefine
            Dim luci As New LookUpColumnInfo(col.FieldName, col.Caption)
            If col.DisplayFormat <> "" Then
                luci.FormatString = col.DisplayFormat
            End If
            _Columns.Add(luci)
            i += 1
        Next

        _LookupEdit.Properties.DataSource = _DataSource
        _LookupEdit.Update()
        Try
            If _FirstSelect Then
                Return
                '_LookupEdit.BindingContextChanged += new EventHandler(_LookupEdit_BindingContextChanged);
            End If

        Catch ex As Exception
        End Try
    End Sub
#Region "Parse"
    Public Shared Function ParseBool(ByVal d As [Decimal]) As Boolean
        Return d >= 1
    End Function
    Public Shared Function ParseDecimal(ByVal b As Boolean) As [Decimal]
        Dim d As Decimal = 0
        If b Then
            d = 1
        End If
        Return d
    End Function
#End Region

    Public Shared Sub GridControl_SetRowFocus(ByVal obj As [Object], ByVal _KeyName As String, ByVal _Value As Object)
        If _Value Is Nothing Then
            Return
        End If

        If TypeOf obj Is GridControl Then
            Dim _GridControl As GridControl = TryCast(obj, GridControl)
            Dim _GridView As GridView = TryCast(_GridControl.MainView, GridView)
            Dim dt As DataTable = TryCast(_GridControl.DataSource, DataTable)
            For i As Integer = 0 To _GridView.DataRowCount - 1
                Dim dr As DataRow = _GridView.GetDataRow(i)
                Dim value As Object = dr(_KeyName)
                If value.Equals(_Value) Then
                    _GridView.FocusedRowHandle = i
                    Return


                End If
            Next
        End If
    End Sub

    Public Shared Sub GridView_SetRowFocus(ByVal obj As [Object], ByVal _KeyName As String, ByVal _Value As Object)
        If _Value Is Nothing Then
            Return
        End If

        'If TypeOf obj Is GridView Then
        '    Dim _GridView As GridView = TryCast(obj, GridView)
        '    Dim dt As DataTable = TryCast(_GridView.GridControl.DataSource, DataTable)

        '    For i As Integer = 0 To _GridView.DataRowCount - 1
        '        Dim dr As DataRow = _GridView.GetDataRow(i)
        '        Dim value As Object = dr(_KeyName)
        '        If value.Equals(_Value) Then
        '            _GridView.FocusedRowHandle = i
        '            Return
        '        End If
        '    Next
        'End If
        If TypeOf obj Is GridView Then
            Dim _GridView As GridView = TryCast(obj, GridView)
            Dim dt As DataTable = Vns.Erp.Core.Dao.Util.DBUtil.ToDataTable(_GridView.GridControl.DataSource)
            'For i As Integer = 0 To _GridView.DataRowCount - 1
            For i As Integer = 0 To dt.Rows.Count - 1
                Dim dr As DataRow = dt.Rows.Item(i)
                Dim value As Object = dr(_KeyName)
                If value.Equals(_Value) Then
                    _GridView.FocusedRowHandle = i
                    Return
                End If
            Next
        End If
    End Sub

    Public Shared Function GridView_FocusKeyValue(ByVal obj As Object, ByVal _KeyName As String) As Object
        Dim _KeyValue As Object = Nothing
        If TypeOf obj Is GridView Then
            Dim _GridView As GridView = TryCast(obj, GridView)
            If _GridView.FocusedRowHandle >= 0 Then
                Dim dr As DataRow = _GridView.GetDataRow(_GridView.FocusedRowHandle)
                Dim dt As DataTable = Vns.Erp.Core.Dao.Util.DBUtil.ToDataTable(_GridView.DataSource)
                If (dr Is Nothing) Then
                    dr = dt.Rows.Item(_GridView.FocusedRowHandle)
                End If
                If dr IsNot Nothing Then
                    _KeyValue = dr(_KeyName)
                Else
                End If
            End If
        End If
        Return _KeyValue
    End Function

    Public Shared Function GridView_FocusObjectValue(ByVal obj As Object) As Object
        Dim _Value As Object = Nothing
        If TypeOf obj Is GridView Then
            Dim _GridView As GridView = TryCast(obj, GridView)
            _Value = _GridView.GetFocusedRow()
        End If
        Return _Value
    End Function

    Public Shared Function GridControl_FocusKeyValue(ByVal obj As Object, ByVal _KeyName As String) As Object
        Dim _KeyValue As Object = Nothing
        If TypeOf obj Is GridControl Then
            Dim _GridControl As GridControl = TryCast(obj, GridControl)
            Dim _GridView As GridView = TryCast(_GridControl.MainView, GridView)
            Dim dr As DataRow = _GridView.GetDataRow(_GridView.FocusedRowHandle)

            If dr IsNot Nothing Then
                _KeyValue = dr(_KeyName)
            End If
        End If
        Return _KeyValue
    End Function

    Public Shared Function TreeList_FocusKeyValue(ByVal obj As Object) As Object
        Dim _KeyValue As Object = Nothing
        If TypeOf obj Is TreeList Then
            Dim _TreeList As TreeList = TryCast(obj, TreeList)
            If _TreeList.FocusedNode IsNot Nothing Then
                _KeyValue = _TreeList.FocusedNode(_TreeList.KeyFieldName)
            End If
        End If
        Return _KeyValue
    End Function

    Public Shared Function TreeList_FocusObjectValue(ByVal obj As Object) As Object
        Dim _ObjectValue As Object = Nothing
        If TypeOf obj Is TreeList Then
            Dim _TreeList As TreeList = TryCast(obj, TreeList)
            If _TreeList.FocusedNode IsNot Nothing Then
                _ObjectValue = _TreeList.GetDataRecordByNode(_TreeList.FocusedNode)
            End If
        End If
        Return _ObjectValue
    End Function

    Public Shared Function LookupEdit_ColumnEdit(ByVal _DataSource As [Object], ByVal _DisplayMember As String, ByVal _ValueMember As String) As RepositoryItemLookUpEdit
        Dim result As New RepositoryItemLookUpEdit()

        result.DisplayMember = _DisplayMember
        result.ValueMember = _ValueMember
        result.DataSource = _DataSource

        Return result
    End Function

    Public Shared Function Editable_ColumnEdit() As RepositoryItemTextEdit
        Dim result As New RepositoryItemTextEdit()
        result.ReadOnly = False
        result.Enabled = True
        Return result
    End Function

    Public Shared Function COSUDUNG_ColumnEdit() As RepositoryItemLookUpEdit
        Dim result As New RepositoryItemLookUpEdit()
        Dim dt As New DataTable()
        dt.Columns.Add("Text", GetType(String))
        dt.Columns.Add("Value", GetType(Decimal))
        Dim dr As DataRow

        dr = dt.NewRow()
        dr("Text") = "Không"
        dr("Value") = 0
        dt.Rows.Add(dr)

        dr = dt.NewRow()
        dr("Text") = "Có"
        dr("Value") = 1
        dt.Rows.Add(dr)

        result.DisplayMember = "Text"
        result.ValueMember = "Value"
        result.DataSource = dt

        Return result
    End Function

    Public Shared Function HAVE_USE_ColumnEdit() As RepositoryItemCheckEdit
        Dim result As New RepositoryItemCheckEdit()
        result.BeginUpdate()
        result.ValueChecked = "1"
        result.ValueUnchecked = "0"
        result.EndUpdate()
        Return result
    End Function


    Public Shared Function LoaiKChuyen_ColumnEdit() As RepositoryItemLookUpEdit
        Dim result As New RepositoryItemLookUpEdit()
        Dim dt As New DataTable()
        dt.Columns.Add("Text", GetType(String))
        dt.Columns.Add("Value", GetType(Decimal))
        Dim dr As DataRow

        dr = dt.NewRow()
        dr("Text") = "Nợ sang có"
        dr("Value") = 1
        dt.Rows.Add(dr)

        dr = dt.NewRow()
        dr("Text") = "Có sang Nợ"
        dr("Value") = 2
        dt.Rows.Add(dr)

        dr = dt.NewRow()
        dr("Text") = "Kết chuyển tự động"
        dr("Value") = 3
        dt.Rows.Add(dr)

        result.DisplayMember = "Text"
        result.ValueMember = "Value"
        result.DataSource = dt

        Return result
    End Function

    Public Shared Sub FormatNumber()
        Dim nfi As NumberFormatInfo = DirectCast(CultureInfo.InvariantCulture.NumberFormat.Clone(), NumberFormatInfo)
        nfi.NumberGroupSeparator = " "
        Console.WriteLine(12345.ToString("n", nfi))
    End Sub

    Public Shared Function DemoData() As DataTable
        Try

            Dim connectonstring As String = "Data Source=.\SQL2008;Initial Catalog=Renew_Thanhtra;User ID=sa;Password=kissmenow"
            'string commandtext = "SELECT Id,Title,Subject,Address FROM AINews";
            Dim commandtext As String = "SELECT top(5) Id,ParentId,Name,Url,LanguageId FROM AIMenus"
            Dim da As New SqlDataAdapter(commandtext, connectonstring)
            Dim dt As New DataTable()
            da.Fill(dt)
            Return dt
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return New DataTable()
        End Try
    End Function

    ''' <summary>
    ''' Gen like string dung cho cac UserControl
    ''' </summary>
    ''' <param name="keyName"></param>
    ''' <param name="likeValue"></param>
    ''' <returns>likeString</returns>
    ''' <remarks></remarks>
    Public Shared Function GenLikeString(ByVal keyName As String, ByVal likeValue As String) As String
        Dim likeString As String = String.Empty
        If String.IsNullOrEmpty(likeValue) Then
            Return likeString
        End If
        If likeValue.Substring(likeValue.Length - 1).Equals(";") Then
            likeValue = likeValue.Substring(0, likeValue.Length - 1)
        End If
        Dim tks As String() = likeValue.Split(New Char() {";"c})

        For Each tk As String In tks
            likeString = likeString + keyName + " LIKE " + "'" + tk + "%'" + " or "

        Next
        If likeString.Length > 3 Then
            likeString = likeString.Substring(0, likeString.Length - 3)
        End If
        Return likeString
    End Function

End Class

