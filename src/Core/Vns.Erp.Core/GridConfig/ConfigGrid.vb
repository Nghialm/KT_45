Imports System.Text
Imports System.Xml
Imports System.IO
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Grid
Imports System.Windows.Forms

Public Class ConfigGrid

#Region "Variables and Messages"
    Private lstColInfo As List(Of ColInfo)
    Private _ColInfo As ColInfo
    Public Shared FilePath As String = Generals.FileResourceGrid
    Private GridID As String
    Private FormID As String
#End Region

#Region "Load"



    Public Sub New()
        InitializeComponent()
        TNCommon.setIconControl(Me)
    End Sub

    Public Function Show_Form(ByVal _GridID As String, ByVal _FormID As String, ByVal _lstColInfo As List(Of ColInfo)) As Boolean
        GridID = _GridID
        FormID = _FormID
        Try


            If FileCheckExist(FilePath) Then
                If NodeCheckExistAndDelNode(GridID, FormID, FilePath, False) Then
                    btnDelete.Enabled = True
                    LoadByGridID(GridID, FormID, FilePath)
                Else
                    btnDelete.Enabled = False
                    lstColInfo = _lstColInfo
                    txtFormID.Text = FormID
                    txtGridID.Text = GridID
                    _GridControl.DataSource = lstColInfo
                End If
            Else
                btnDelete.Enabled = False
                lstColInfo = _lstColInfo
                txtFormID.Text = FormID
                txtGridID.Text = GridID
                _GridControl.DataSource = lstColInfo
            End If
        Catch ex As Exception
            Message_Error(ex)
        End Try
        Return (Me.ShowDialog = Windows.Forms.DialogResult.OK)
    End Function

#End Region

#Region "Events"

    Private Sub ConfigGrid_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'lstColInfo = New List(Of ColInfo)
        '_GridControl.DataSource = lstColInfo
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Try
            frmProgress.Instance.Thread = AddressOf SaveData

            frmProgress.Instance.Show_Progress("Đang ghi dữ liệu")

            'frmProgress.Instance.SetFinishText("Dữ liệu đã được ghi lại.", 2000)
            DialogResult = Windows.Forms.DialogResult.OK
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub SaveData()

        If FileCheckExist(FilePath) Then
            'file ton tai
            If NodeCheckExistAndDelNode(GridID, FormID, FilePath, False) Then
                'node ton tai
                UpdateNode(GridID, FormID, lstColInfo, FilePath)
                'MessageBox.Show("Update GridID: " + GridID + " thành công!")
            Else
                'node ko ton tai, them du lieu vao sau node cuoi cung
                AddNode(GridID, FormID, lstColInfo, FilePath)
                'MessageBox.Show("AddNew GridID: " + GridID + " thành công!")
            End If
        Else
            'file ko ton tai
            Dim xmlWriter As New XmlTextWriter(FilePath, Encoding.UTF8)
            xmlWriter.Formatting = Formatting.Indented
            xmlWriter.WriteStartDocument(True)
            xmlWriter.WriteStartElement("Root")


            xmlWriter.WriteStartElement("Grids")
            xmlWriter.WriteStartElement("Grid")


            xmlWriter.WriteStartElement("Form_ID")
            xmlWriter.WriteString(txtFormID.Text.Trim())
            xmlWriter.WriteEndElement()

            xmlWriter.WriteStartElement("Grid_ID")
            xmlWriter.WriteString(txtGridID.Text.Trim())
            xmlWriter.WriteEndElement()

            xmlWriter.WriteStartElement("ColInfos")




            Dim list As List(Of ColInfo) = lstColInfo
            For Each colInfo As ColInfo In list
                If colInfo.ColVisible = "0" Then
                    colInfo.ColVisibleIndex = -1
                End If



                xmlWriter.WriteStartElement("ColInfo")

                xmlWriter.WriteStartElement("ColName")
                xmlWriter.WriteString(colInfo.ColName)
                xmlWriter.WriteEndElement()

                xmlWriter.WriteStartElement("ColCaption")
                xmlWriter.WriteString(colInfo.ColCaption)
                xmlWriter.WriteEndElement()

                xmlWriter.WriteStartElement("ColWidth")
                xmlWriter.WriteString(colInfo.ColWidth)
                xmlWriter.WriteEndElement()

                xmlWriter.WriteStartElement("ColVisible")
                xmlWriter.WriteString(colInfo.ColVisible)
                xmlWriter.WriteEndElement()

                xmlWriter.WriteStartElement("ColReadOnly")
                xmlWriter.WriteString(colInfo.ColReadOnly)
                xmlWriter.WriteEndElement()

                xmlWriter.WriteStartElement("ColVisibleIndex")
                xmlWriter.WriteString(colInfo.ColVisibleIndex)
                xmlWriter.WriteEndElement()



                xmlWriter.WriteEndElement()

            Next
            xmlWriter.WriteEndElement() 'ColInfos
            xmlWriter.WriteEndElement() 'Grid
            xmlWriter.WriteEndElement() 'Grids

            xmlWriter.WriteEndElement() 'root
            xmlWriter.WriteEndDocument()
            xmlWriter.Flush()
            xmlWriter.Close()

        End If
    End Sub

    'Private sub 

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuit.Click
        Me.Close()
    End Sub

    Private Sub btnNewRow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNewRow.Click
        NewRow()
    End Sub

    Private Sub btnLoad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoad.Click
        Try
            LoadByGridID(txtGridID.Text.Trim(), txtFormID.Text.Trim(), FilePath)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnDelRow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelRow.Click
        _GridView.DeleteSelectedRows()
    End Sub

    Private Sub _GridView_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles _GridView.KeyDown
        If e.KeyCode = Keys.Enter Then
            If (_GridView.IsLastRow) Then
                Dim i As Integer = _GridView.Columns.Count
                Dim j As Integer = -1
                While i >= 0
                    Try
                        If _GridView.GetVisibleColumn(i).Visible Then
                            j = _GridView.GetVisibleColumn(i).AbsoluteIndex
                            If _GridView.FocusedColumn.AbsoluteIndex = j And Not j = -1 Then
                                NewRow()
                            End If
                            Exit While
                        End If
                    Catch ex As Exception
                    End Try
                    i = i - 1
                End While
            End If
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        txtGridID.Text = String.Empty
        txtFormID.Text = String.Empty
        _GridControl.DataSource = Nothing
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If Message_Confirm("Bạn muốn xóa?") Then
            If NodeCheckExistAndDelNode(GridID, FormID, FilePath, True) Then

                txtFormID.Text = String.Empty
                txtGridID.Text = String.Empty
                _GridControl.DataSource = Nothing
                btnSave.Enabled = False
                DialogResult = Windows.Forms.DialogResult.OK
            End If
        End If



    End Sub

#End Region

#Region "Private Function and Procedures"

    Private Sub NewRow()

        _ColInfo = New ColInfo
        _ColInfo.ColVisible = "0"
        _ColInfo.ColReadOnly = "0"
        lstColInfo.Add(_ColInfo)
        _GridView.RefreshData()
    End Sub

    Private Sub LoadByGridID(ByVal GridID As String, ByVal FormID As String, ByVal FilePath As String)
        lstColInfo = New List(Of ColInfo)

        Dim doc As XmlDocument = New XmlDocument
        doc.Load(FilePath)

        Dim root As XmlElement = doc.DocumentElement
        'Get element named "login_info"
        Dim Grids As XmlNode = root.SelectSingleNode("Grids")

        For Each GridNode As XmlNode In Grids.ChildNodes
            Dim Grid_ID As String = GridNode.SelectSingleNode("Grid_ID").InnerText
            Dim Form_ID As String = GridNode.SelectSingleNode("Form_ID").InnerText
            If (Grid_ID.Equals(GridID) And Form_ID.Equals(FormID)) Then
                'Dim Form_ID As String = GridNode.SelectSingleNode("Form_ID").InnerText
                Dim ColInfos As XmlNode = GridNode.SelectSingleNode("ColInfos")

                For Each colInfo As XmlNode In ColInfos.ChildNodes
                    Dim info As ColInfo = New ColInfo()

                    info.ColName = colInfo.SelectSingleNode("ColName").InnerText
                    info.ColCaption = colInfo.SelectSingleNode("ColCaption").InnerText
                    info.ColWidth = colInfo.SelectSingleNode("ColWidth").InnerText
                    info.ColVisible = colInfo.SelectSingleNode("ColVisible").InnerText
                    info.ColReadOnly = colInfo.SelectSingleNode("ColReadOnly").InnerText
                    info.ColVisibleIndex = colInfo.SelectSingleNode("ColVisibleIndex").InnerText
                    lstColInfo.Add(info)
                Next
                txtFormID.Text = Form_ID
                txtGridID.Text = Grid_ID
                _GridControl.DataSource = lstColInfo
                Exit Sub
            End If


        Next
        MessageBox.Show("Không tồn tại GridID này !!")
    End Sub

    Public Shared Function FileCheckExist(ByVal FilePath As String) As Boolean
        Dim fileInfo As New FileInfo(FilePath)
        If fileInfo.Exists Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Function NodeCheckExistAndDelNode(ByVal GridID As String, ByVal FormID As String, ByVal FilePath As String, ByVal del As Boolean) As Boolean
        Dim doc As XmlDocument = New XmlDocument
        doc.Load(FilePath)
        Dim bCheck As Boolean = False
        Dim root As XmlElement = doc.DocumentElement
        'Get element named "login_info"
        Dim Grids As XmlNode = root.SelectSingleNode("Grids")

        For Each GridNode As XmlNode In Grids.ChildNodes
            Dim Grid_ID As String = GridNode.SelectSingleNode("Grid_ID").InnerText
            Dim Form_ID As String = GridNode.SelectSingleNode("Form_ID").InnerText
            If (Grid_ID.Equals(GridID) And Form_ID.Equals(FormID)) Then

                If del Then
                    Grids.RemoveChild(GridNode)
                    doc.Save(FilePath)
                End If

                Return True
                Exit For
            End If
        Next
        Return bCheck
    End Function

    Private Sub UpdateNode(ByVal GridID As String, ByVal FormID As String, ByVal lstColInfo As List(Of ColInfo), ByVal FilePath As String)
        Dim doc As XmlDocument = New XmlDocument
        doc.Load(FilePath)

        Dim root As XmlElement = doc.DocumentElement
        'Get element named "login_info"
        Dim Grids As XmlNode = root.SelectSingleNode("Grids")

        For Each GridNode As XmlNode In Grids.ChildNodes
            Dim Grid_ID As String = GridNode.SelectSingleNode("Grid_ID").InnerText
            Dim Form_ID As String = GridNode.SelectSingleNode("Form_ID").InnerText
            If (Grid_ID.Equals(GridID) And Form_ID.Equals(FormID)) Then
                'GridNode.SelectSingleNode("Form_ID").InnerText = FormID


                Dim ColInfos As XmlNode = GridNode.SelectSingleNode("ColInfos")
                ColInfos.RemoveAll()
                For Each colInfo As ColInfo In lstColInfo
                    If colInfo.ColVisible = "0" Then
                        colInfo.ColVisibleIndex = -1
                    End If
                    Dim ele As XmlNode = doc.CreateNode(XmlNodeType.Element, "ColInfo", Nothing)
                    Dim strXml As String = ""
                    strXml = strXml + "<ColName>" + colInfo.ColName + "</ColName>" + _
                                    "<ColCaption>" + colInfo.ColCaption + "</ColCaption>" + _
                                    "<ColWidth>" + colInfo.ColWidth.ToString() + "</ColWidth>" + _
                                    "<ColVisible>" + colInfo.ColVisible + "</ColVisible>" + _
                                    "<ColReadOnly>" + colInfo.ColReadOnly + "</ColReadOnly>" + _
                                    "<ColVisibleIndex>" + colInfo.ColVisibleIndex.ToString() + "</ColVisibleIndex>"

                    ele.InnerXml = strXml
                    ColInfos.AppendChild(ele)

                Next
            End If
        Next
        doc.Save(FilePath)
    End Sub

    Private Sub AddNode(ByVal GridID As String, ByVal FormID As String, ByVal lstColInfo As List(Of ColInfo), ByVal FilePath As String)
        Dim doc As XmlDocument = New XmlDocument
        doc.Load(FilePath)

        Dim root As XmlElement = doc.DocumentElement
        'Get element named "login_info"
        Dim Grids As XmlNode = root.SelectSingleNode("Grids")
        Dim GridNewNode As XmlNode = doc.CreateNode(XmlNodeType.Element, "Grid", Nothing)
        Dim FormIDNewNode As XmlNode = doc.CreateElement("Form_ID")
        FormIDNewNode.InnerText = FormID

        Dim GridIDNewNode As XmlNode = doc.CreateElement("Grid_ID")
        GridIDNewNode.InnerText = GridID


        Dim ColInfos As XmlNode = doc.CreateNode(XmlNodeType.Element, "ColInfos", Nothing)

        'ColInfos.RemoveAll()
        For Each colInfo As ColInfo In lstColInfo
            If colInfo.ColVisible = "0" Then
                colInfo.ColVisibleIndex = -1
            End If
            Dim ele As XmlNode = doc.CreateNode(XmlNodeType.Element, "ColInfo", Nothing)
            Dim strXml As String = ""
            strXml = strXml + "<ColName>" + colInfo.ColName + "</ColName>" + _
                            "<ColCaption>" + colInfo.ColCaption + "</ColCaption>" + _
                            "<ColWidth>" + colInfo.ColWidth.ToString() + "</ColWidth>" + _
                            "<ColVisible>" + colInfo.ColVisible + "</ColVisible>" + _
                            "<ColReadOnly>" + colInfo.ColReadOnly + "</ColReadOnly>" + _
                            "<ColVisibleIndex>" + colInfo.ColVisibleIndex.ToString() + "</ColVisibleIndex>"

            ele.InnerXml = strXml
            ColInfos.AppendChild(ele)

        Next
        GridNewNode.AppendChild(FormIDNewNode)
        GridNewNode.AppendChild(GridIDNewNode)
        GridNewNode.AppendChild(ColInfos)
        Grids.AppendChild(GridNewNode)
        doc.Save(FilePath)
    End Sub


    ''' <summary>
    ''' Nhan vao FormID,GridID xu ly de cau hinh lai _View
    ''' </summary>
    ''' <param name="FormID"></param>
    ''' <param name="GridID"></param>
    ''' <param name="_View"></param>
    ''' <remarks></remarks>
    ''' 

    Public Shared Sub GridConfig(ByVal FormID As String, ByVal GridID As String, ByVal _View As GridView)
        If FileCheckExist(FilePath) Then
            Dim lstColInfo As List(Of ColInfo) = New List(Of ColInfo)

            Dim doc As XmlDocument = New XmlDocument
            doc.Load(FilePath)

            Dim root As XmlElement = doc.DocumentElement
            'Get element named "login_info"
            Dim Grids As XmlNode = root.SelectSingleNode("Grids")

            For Each GridNode As XmlNode In Grids.ChildNodes
                Dim Grid_ID As String = GridNode.SelectSingleNode("Grid_ID").InnerText
                Dim Form_ID As String = GridNode.SelectSingleNode("Form_ID").InnerText
                If (Grid_ID.Equals(GridID) And Form_ID.Equals(FormID)) Then
                    'Dim Form_ID As String = GridNode.SelectSingleNode("Form_ID").InnerText
                    Dim ColInfos As XmlNode = GridNode.SelectSingleNode("ColInfos")

                    For Each colInfo As XmlNode In ColInfos.ChildNodes
                        Dim info As ColInfo = New ColInfo()

                        info.ColName = colInfo.SelectSingleNode("ColName").InnerText
                        info.ColCaption = colInfo.SelectSingleNode("ColCaption").InnerText
                        info.ColWidth = colInfo.SelectSingleNode("ColWidth").InnerText
                        info.ColVisible = colInfo.SelectSingleNode("ColVisible").InnerText
                        info.ColReadOnly = colInfo.SelectSingleNode("ColReadOnly").InnerText
                        info.ColVisibleIndex = colInfo.SelectSingleNode("ColVisibleIndex").InnerText
                        lstColInfo.Add(info)
                    Next

                    For Each colInfo As ColInfo In lstColInfo
                        For i As Integer = 0 To _View.Columns.Count - 1
                            If _View.Columns(i).Name = colInfo.ColName Then
                                '_View.Columns(i).Visible = TNCommon.ParseBool(Convert.ToDecimal(colInfo.ColVisible))
                                _View.Columns(i).Caption = colInfo.ColCaption
                                _View.Columns(i).Width = colInfo.ColWidth
                                _View.Columns(i).OptionsColumn.ReadOnly = TNCommon.ParseBool(Convert.ToDecimal(colInfo.ColReadOnly))
                                _View.Columns(i).VisibleIndex = colInfo.ColVisibleIndex

                                Exit For 'Bo vong for trong
                            End If
                        Next
                    Next

                    _View.RefreshData()
                    Exit Sub
                End If


            Next
        End If



    End Sub


    ''' <summary>
    ''' lay colInfo cua _View thanh list lstColInfo
    ''' </summary>
    ''' <param name="_View"></param>
    ''' <param name="lstColInfo"></param>
    ''' <remarks></remarks>
    Public Shared Sub GetGridColInfo(ByVal _View As GridView, ByVal lstColInfo As List(Of ColInfo))

        For Each c As GridColumn In _View.Columns
            Dim _ColInfo As ColInfo = New ColInfo()
            _ColInfo.ColName = c.Name
            _ColInfo.ColCaption = c.Caption
            _ColInfo.ColWidth = c.Width
            _ColInfo.ColVisible = TNCommon.ParseDecimal(c.Visible)
            _ColInfo.ColReadOnly = TNCommon.ParseDecimal(c.ReadOnly)
            _ColInfo.ColVisibleIndex = c.VisibleIndex
            lstColInfo.Add(_ColInfo)
        Next

    End Sub

#End Region

    Private Sub ConfigGrid_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode.Equals(Keys.Escape) Then
            Me.Close()
        End If
    End Sub
End Class
