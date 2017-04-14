Imports System.Collections
Imports System.Windows.Forms

Public Class ListViewColumnSorter
    Implements System.Collections.IComparer

    Private ColumnToSort As Integer
    Private OrderOfSort As SortOrder
    Private ObjectCompare As CaseInsensitiveComparer

    Public Sub New()
        ' Initialize the column to '0'.
        ColumnToSort = 0

        ' Initialize the sort order to 'none'.
        OrderOfSort = SortOrder.None

        ' Initialize the CaseInsensitiveComparer object.
        'ObjectCompare = New CaseInsensitiveComparer()
    End Sub

    Public Function Compare(ByVal x As Object, ByVal y As Object) As Integer Implements IComparer.Compare
        Dim compareResult As Integer
        Dim listviewX As ListViewItem
        Dim listviewY As ListViewItem
        Dim sValueX, sValueY As Object
        ' Cast the objects to be compared to ListViewItem objects.
        listviewX = DirectCast(x, ListViewItem)
        listviewY = DirectCast(y, ListViewItem)
        '
        Dim sDataType As String = DirectCast(listviewX.ListView.Columns(ColumnToSort).Tag, ListViewHeader).DataType
        ' Compare the two items.
        If listviewX.SubItems.Count > ColumnToSort AndAlso listviewY.SubItems.Count > ColumnToSort Then
            sValueX = listviewX.SubItems(ColumnToSort).Tag
            sValueY = listviewY.SubItems(ColumnToSort).Tag
            If sDataType = "DATE" Then
                compareResult = Date.Compare(Date.Parse(sValueX), Date.Parse(sValueY))
            ElseIf sDataType = "NUMBER" Then
                compareResult = Decimal.Compare(Decimal.Parse(sValueX), Decimal.Parse(sValueY))
            Else
                'compareResult = ObjectCompare.Compare(sValueX, sValueY)
                compareResult = String.Compare(sValueX, sValueY, True)
            End If
        Else
            Return 0
        End If
        ' Calculate the correct return value based on the object 
        ' comparison.
        If (OrderOfSort = SortOrder.Ascending) Then
            ' Ascending sort is selected, return typical result of 
            ' compare operation.
            Return compareResult
        ElseIf (OrderOfSort = SortOrder.Descending) Then
            ' Descending sort is selected, return negative result of 
            ' compare operation.
            Return (-compareResult)
        Else
            ' Return '0' to indicate that they are equal.
            Return 0
        End If
    End Function

    Public Property SortColumn() As Integer
        Set(ByVal Value As Integer)
            ColumnToSort = Value
        End Set

        Get
            Return ColumnToSort
        End Get
    End Property

    Public Property Order() As SortOrder
        Set(ByVal Value As SortOrder)
            OrderOfSort = Value
        End Set

        Get
            Return OrderOfSort
        End Get
    End Property
End Class

Public Class ListViewHeader
    Public Sub New(ByVal _DisplayField As String)
        DisplayField = _DisplayField
        ValueField = _DisplayField
    End Sub

    Public Sub New(ByVal _DisplayField As String, ByVal _DataFormat As String)
        DisplayField = _DisplayField
        ValueField = _DisplayField
        DataFormat = _DataFormat
    End Sub

    Public Sub New(ByVal _DisplayField As String, ByVal _ValueField As String, ByVal _StatusArray As String, ByVal _StatusColor As String)
        DisplayField = _DisplayField
        ValueField = _ValueField
        StatusArray = _StatusArray
        StatusColor = _StatusColor
    End Sub

    Public Sub New(ByVal _DisplayField As String, ByVal _ValueField As String, ByVal _DataFormat As String, ByVal _StatusArray As String, ByVal _StatusColor As String)
        DisplayField = _DisplayField
        ValueField = _ValueField
        StatusArray = _StatusArray
        StatusColor = _StatusColor
    End Sub

    Public DisplayField As String
    Public ValueField As String
    Public DataFormat As String
    Public StatusArray As String
    Public StatusColor As String
    '
    Public DataType As String
End Class

Public Class ListViewHandle
    Private WithEvents objListView As ListView
    Private _AllowSort As Boolean
    Private _AllowCopy As Boolean
    Private lvwColumnSorter As ListViewColumnSorter

    Public Property AllowSort() As Boolean
        Get
            Return _AllowSort
        End Get
        Set(ByVal value As Boolean)
            _AllowSort = value
        End Set
    End Property

    Public Property AllowCopy() As Boolean
        Get
            Return _AllowCopy
        End Get
        Set(ByVal value As Boolean)
            _AllowCopy = value
        End Set
    End Property

    Public Sub New(ByVal lv As ListView, Optional ByVal bAllowSort As Boolean = False, Optional ByVal bAllowCopy As Boolean = False)
        _AllowSort = bAllowSort
        _AllowCopy = bAllowCopy
        objListView = lv
        If _AllowSort Then
            lvwColumnSorter = New ListViewColumnSorter
            objListView.ListViewItemSorter = lvwColumnSorter
        End If
    End Sub

    Private Sub objListView_ColumnClick(ByVal sender As Object, ByVal e As System.Windows.Forms.ColumnClickEventArgs) Handles objListView.ColumnClick
        Try
            If Not _AllowSort Then Return
            ' Determine if the clicked column is already the column that is 
            ' being sorted.
            If (e.Column = lvwColumnSorter.SortColumn) Then
                ' Reverse the current sort direction for this column.
                If (lvwColumnSorter.Order = SortOrder.Ascending) Then
                    lvwColumnSorter.Order = SortOrder.Descending
                Else
                    lvwColumnSorter.Order = SortOrder.Ascending
                End If
            Else
                ' Set the column number that is to be sorted; default to ascending.
                lvwColumnSorter.SortColumn = e.Column
                lvwColumnSorter.Order = SortOrder.Ascending
            End If

            ' Perform the sort with these new sort options.
            objListView.Sort()
        Catch ex As Exception

        End Try
    End Sub

    Public Sub ResetSort()
        If Not lvwColumnSorter Is Nothing Then
            lvwColumnSorter.SortColumn = 0
            lvwColumnSorter.Order = SortOrder.None
        End If
    End Sub
End Class

Public Class ListViewCommon

#Region "Contructor"
    Private Shared _instance As ListViewCommon

    '// Notes: Constructor is 'protected'
    Protected Sub New()
    End Sub
    '// Notes: Dispose is 'protected'
    Protected Sub Dispose()
        _instance = Nothing
    End Sub
    '// Lock synchronization object
    Private Shared _syncLock As Object = New Object()
    ' return the provider
    Public Shared Shadows Function Instance() As ListViewCommon
        '// Support multithreaded applications through
        '// 'Double checked locking' pattern which (once
        '// the instance exists) avoids locking each
        '// time the method is invoked 
        If _instance Is Nothing Then
            SyncLock _syncLock
                If _instance Is Nothing Then
                    _instance = New ListViewCommon
                End If
            End SyncLock
        End If
        Return _instance
    End Function
#End Region

    Public Function GetSubItem(ByVal lvItem As ListViewItem, ByVal sColumnName As String) As ListViewItem.ListViewSubItem
        If lvItem.SubItems.ContainsKey(sColumnName) Then
            Return lvItem.SubItems(sColumnName)
        Else
            Dim clm As ColumnHeader
            For i As Integer = 0 To lvItem.ListView.Columns.Count - 1
                clm = lvItem.ListView.Columns(i)
                If String.IsNullOrEmpty(clm.Name) Then clm.Name = clm.Tag
                If sColumnName.ToUpper = clm.Tag.ToString.ToUpper Then
                    If i > lvItem.SubItems.Count - 1 Then
                        For j As Integer = lvItem.SubItems.Count To i
                            lvItem.SubItems.Add("")
                        Next
                    End If
                    Return lvItem.SubItems(i)
                End If
            Next
        End If
        Return Nothing
    End Function

    Public Function GetSubItemText(ByVal lvItem As ListViewItem, ByVal sColumnName As String) As String
        If lvItem.SubItems.ContainsKey(sColumnName) Then
            Return lvItem.SubItems(sColumnName).Text
        Else
            Dim clm As ColumnHeader
            For i As Integer = 0 To lvItem.ListView.Columns.Count - 1
                clm = lvItem.ListView.Columns(i)
                If String.IsNullOrEmpty(clm.Name) Then clm.Name = clm.Tag
                If sColumnName.ToUpper = clm.Tag.ToString.ToUpper Then
                    Return lvItem.SubItems(i).Text
                End If
            Next
            Return ""
        End If
    End Function

    Public Function ListView_CopyData(ByVal objListView As ListView, Optional ByVal bIncludeGroup As Boolean = True) As String
        Dim sTemp As String = Nothing
        Dim sGroupName As String = Nothing
        Dim bUseGroup As Boolean = (objListView.ShowGroups AndAlso bIncludeGroup)

        Dim sBuilder As New System.Text.StringBuilder
        For Each lvColumn As ColumnHeader In objListView.Columns
            If String.IsNullOrEmpty(sTemp) Then
                sTemp = lvColumn.Text
            Else
                sTemp += vbTab + lvColumn.Text
            End If
        Next
        sBuilder.Append(sTemp)
        For Each lvItem As ListViewItem In objListView.Items
            If bUseGroup AndAlso objListView.Groups.Count > 0 Then
                If Not lvItem.Group Is Nothing AndAlso sGroupName <> lvItem.Group.Name Then
                    sGroupName = lvItem.Group.Name
                    sBuilder.Append(vbCrLf + lvItem.Group.Header)
                End If
            End If
            sTemp = ""
            For i As Integer = 0 To lvItem.SubItems.Count - 1
                If String.IsNullOrEmpty(sTemp) Then
                    sTemp = lvItem.SubItems(i).Text
                Else
                    sTemp += vbTab + lvItem.SubItems(i).Text
                End If
            Next
            sBuilder.Append(vbCrLf + sTemp)
        Next
        Return sBuilder.ToString
    End Function

    Public Function ListView_MoveAll(ByVal lstSource As ListView, ByVal lstDest As ListView) As Long
        'Purpose: 
        '   Hàm để chuyển ListViewItem từ ListView này sang ListView khác (move all)
        'Parameters: 
        '   lstSource   : ListView nguồn
        '   lstDest     : ListView nguồn đích
        'Notes:
        Dim iReturn As Long
        iReturn = lstSource.Items.Count
        If iReturn > 0 Then
            lstSource.BeginUpdate()
            lstDest.BeginUpdate()
            For Each itm As ListViewItem In lstSource.Items
                lstSource.Items.Remove(itm)
                itm.Selected = False
                lstDest.Items.Add(itm)
            Next itm
            lstSource.EndUpdate()
            lstDest.EndUpdate()
        End If
        Return iReturn
    End Function

    Public Function ListView_MoveSelect(ByVal lstSource As ListView, ByVal lstDest As ListView) As Long
        'Purpose: 
        '   Hàm để chuyển ListViewItem từ ListView này sang ListView khác (move select)
        'Parameters: 
        '   lstSource   : ListView nguồn
        '   lstDest     : ListView nguồn đích
        'Notes:
        Dim iReturn As Long
        iReturn = lstSource.SelectedItems.Count
        If iReturn > 0 Then
            lstSource.BeginUpdate()
            lstDest.BeginUpdate()
            For Each itm As ListViewItem In lstSource.SelectedItems
                lstSource.Items.Remove(itm)
                itm.Selected = False
                lstDest.Items.Add(itm)
            Next itm
            lstSource.EndUpdate()
            lstDest.EndUpdate()
        End If
        Return iReturn
    End Function

    Public Function ListView_AddItem(ByVal objListView As ListView, ByVal objData As Object, Optional ByVal sPK_Field As String = "") As ListViewItem
        'Purpose: 
        '   Ham Add Item cho ListView theo ColumnHeader
        'Parameters: 
        '   objListView : đối tượng ListView
        '   objData     : object data        
        'Notes

        Dim lvItem As ListViewItem = Nothing
        Dim sValue As String = Nothing
        Dim sColumnName As String = Nothing
        For Each clm As ColumnHeader In objListView.Columns
            sColumnName = clm.Tag
            If TypeOf objData Is IDataReader Then
                sValue = DB_GetString(objData.Item(sColumnName))
            Else
                sValue = Object_GetDisplayValue(Object_GetPropertyValue(objData, sColumnName))
            End If
            If lvItem Is Nothing Then
                lvItem = objListView.Items.Add(sValue)
            Else
                lvItem.SubItems.Add(sValue)
            End If
        Next
        'Set Key value
        If Not String.IsNullOrEmpty(sPK_Field) Then
            If TypeOf objData Is IDataReader Then
                lvItem.Name = objData.Item(sPK_Field)
            Else
                lvItem.Name = Object_GetDisplayValue(Object_GetPropertyValue(objData, sPK_Field))
            End If
        End If
        If Not TypeOf objData Is IDataReader Then
            lvItem.Tag = objData
        End If
        Return lvItem
    End Function

    Public Sub ListView_UpdateItem(ByVal lvItem As ListViewItem, ByVal objData As Object, Optional ByVal sPK_Field As String = "")
        'Purpose: 
        '   Ham Update Item cho ListViewItem theo ColumnHeader
        'Parameters: 
        '   lvItem : đối tượng ListViewItem
        '   objData     : object data        
        'Notes

        Dim sValue As String = Nothing
        Dim sColumnName As String = Nothing
        Dim i As Integer = 0
        For Each clm As ColumnHeader In lvItem.ListView.Columns
            sColumnName = clm.Tag

            sValue = Object_GetDisplayValue(Object_GetPropertyValue(objData, sColumnName))
            lvItem.SubItems(i).Text = sValue
            i += 1
        Next
        'Set Key value
        If Not String.IsNullOrEmpty(sPK_Field) Then
            lvItem.Name = Object_GetDisplayValue(Object_GetPropertyValue(objData, sPK_Field))
        End If
        lvItem.Tag = objData
    End Sub

    Public Sub ListView_DataBind(ByVal objListView As ListView, ByVal objData As Object, Optional ByVal sPK_Field As String = "")
        ListView_DataBind(objListView, Nothing, objData, sPK_Field)
    End Sub

    Public Sub ListView_DataBind(ByVal objListView As ListView, ByVal objGroup As ListViewGroup, ByVal objReader As IDataReader, Optional ByVal sPK_Field As String = "")
        'Purpose: 
        '   Ham Add All Item cho ListView theo ColumnHeader
        'Parameters: 
        '   objListView : đối tượng ListView
        '   objReader     : object IdataReader
        'Notes
        Dim sColumnName, sValue As String
        Try
            objListView.BeginUpdate()
            objListView.Items.Clear()
            Dim lvItem As ListViewItem
            While objReader.Read
                lvItem = Nothing
                For Each clm As ColumnHeader In objListView.Columns
                    Dim clmHeader As ListViewHeader = clm.Tag
                    sColumnName = clmHeader.DisplayField
                    If sColumnName = "@STT" Then
                        sValue = objListView.Items.Count + 1
                    Else
                        'sValue = GetDBStringValue(objReader.Item(sColumnName))
                        sValue = Object_GetDisplayValue(objReader.Item(sColumnName))
                    End If
                    If lvItem Is Nothing Then
                        lvItem = objListView.Items.Add(sValue)
                        If Not String.IsNullOrEmpty(sPK_Field) Then
                            lvItem.Tag = objReader.Item(sPK_Field)
                            lvItem.Name = objReader.Item(sPK_Field)
                            If Not objGroup Is Nothing Then
                                lvItem.Group = objGroup
                            End If
                        End If
                    Else
                        Dim subItem As ListViewItem.ListViewSubItem = lvItem.SubItems.Add(sValue)
                        subItem.Tag = DB_GetValue(objReader.Item(clmHeader.ValueField), Nothing)
                    End If
                Next
            End While
        Finally
            Reader_Close(objReader)
            objListView.EndUpdate()
        End Try
    End Sub

    Public Sub ListView_DataBind(ByVal objListView As ListView, ByVal objGroup As ListViewGroup, ByVal objDataTable As DataTable, Optional ByVal sPK_Field As String = "")
        ListView_DataBind(objListView, objGroup, objDataTable.DefaultView, sPK_Field)
    End Sub

    Public Sub ListView_DataBind(ByVal objListView As ListView, ByVal objGroup As ListViewGroup, ByVal objDataView As DataView, Optional ByVal sPK_Field As String = "")
        'Purpose: 
        '   Ham Add All Item cho ListView theo ColumnHeader
        'Parameters: 
        '   objListView : đối tượng ListView
        '   objDataView : object DataView
        'Notes
        Dim sColumnName, sValue As String
        Try
            objListView.BeginUpdate()
            objListView.Items.Clear()
            Dim lvItem As ListViewItem
            For i As Integer = 0 To objDataView.Count - 1
                lvItem = Nothing
                For Each clm As ColumnHeader In objListView.Columns
                    Dim clmHeader As ListViewHeader = clm.Tag
                    sColumnName = clmHeader.DisplayField
                    If sColumnName = "@STT" Then
                        sValue = objListView.Items.Count + 1
                    Else
                        'sValue = GetDBStringValue(objDataView.Item(i).Item(sColumnName))
                        sValue = Object_GetDisplayValue(objDataView.Item(i).Item(sColumnName))
                    End If
                    If lvItem Is Nothing Then
                        lvItem = objListView.Items.Add(sValue)
                        If Not String.IsNullOrEmpty(sPK_Field) Then
                            lvItem.Tag = objDataView.Item(i).Item(sPK_Field)
                            lvItem.Name = objDataView.Item(i).Item(sPK_Field)
                        End If
                        lvItem.Group = objGroup
                    Else
                        lvItem.SubItems.Add(sValue)
                    End If
                Next
            Next
        Finally
            objListView.EndUpdate()
        End Try
    End Sub

    Public Sub ListView_DataBind(ByVal objListView As ListView, ByVal objGroup As ListViewGroup, ByVal arrObject As ArrayList, Optional ByVal sPK_Field As String = "")
        'Purpose: 
        '   Ham Add All Item cho ListView theo ColumnHeader
        'Parameters: 
        '   objListView : đối tượng ListView
        '   objReader     : object ArrayList
        'Notes
        Dim sColumnName, sValue As String
        Dim lvItem As ListViewItem

        objListView.BeginUpdate()
        Try
            objListView.Items.Clear()
            For Each objData As Object In arrObject
                lvItem = Nothing
                For Each clm As ColumnHeader In objListView.Columns
                    sColumnName = clm.Tag
                    If sColumnName = "@STT" Then
                        sValue = objListView.Items.Count + 1
                    Else
                        sValue = Object_GetDisplayValue(Object_GetPropertyValue(objData, sColumnName))
                    End If
                    If lvItem Is Nothing Then
                        lvItem = objListView.Items.Add(sValue)
                        lvItem.Tag = objData
                        If Not String.IsNullOrEmpty(sPK_Field) Then
                            lvItem.Name = Object_GetDisplayValue(Object_GetPropertyValue(objData, sPK_Field))
                        End If
                        lvItem.Group = objGroup
                    Else
                        lvItem.SubItems.Add(sValue)
                    End If
                Next
            Next
        Finally
            objListView.EndUpdate()
        End Try
    End Sub
    
End Class
