Imports System
Imports System.Data
Imports System.Windows.Forms
Imports DevExpress.XtraTreeList.Nodes
Imports Vns.Erp.Core.Admin.Service.Interface
Imports Vns.Erp.Core.Admin.Domain

''' <summary>
''' update group
''' </summary>
''' <remarks></remarks>
Public Class frmGroupEdit

#Region "Variables"
    Private m_InputState As FormGlobals.DataInputState 'State mode
    Private m_GroupID As Guid 'Group ID
    Private m_Return As DialogResult 'Dialog Result

    Private _bo_group As IAppGroupsService
    Public Property AppGroupsService As IAppGroupsService
        Get
            Return _bo_group
        End Get
        Set(ByVal value As IAppGroupsService)
            _bo_group = value
        End Set
    End Property

    Private _bo_dv As IDmDonviService
    Public Property DmDonviService As IDmDonviService
        Get
            Return _bo_dv
        End Get
        Set(ByVal value As IDmDonviService)
            _bo_dv = value
        End Set
    End Property

    Private _bo_dv_group As IAppDvGroupService
    Public Property AppDvGroupService As IAppDvGroupService
        Get
            Return _bo_dv_group
        End Get
        Set(ByVal value As IAppDvGroupService)
            _bo_dv_group = value
        End Set
    End Property
    Public LIST_DONVI As List(Of Guid)
#End Region

#Region "Common Functions"

    ''' <summary>
    ''' Show Form Group
    ''' </summary>
    ''' <param name="UserID"></param>
    ''' <param name="state"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function ShowForm(ByVal UserID As Guid, ByVal state As DataInputState) As Boolean
        Form_SetText(Me, "User", state)
        Form_InitDialog(Me)
        m_InputState = state
        m_GroupID = UserID

        frmProgress.Instance.Thread = AddressOf InitForm
        frmProgress.Instance.Show_Progress() '        
        Return (ShowDialog() = Windows.Forms.DialogResult.OK)
    End Function

    ''' <summary>
    ''' Init Form
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub InitForm()
        InitControl()
        Select Case m_InputState
            Case DataInputState.AddMode
                Me.Text = "Nhóm người dùng [Thêm mới]"
            Case DataInputState.EditMode
                Me.Text = "Nhóm người dùng [Cập nhật]"
                SetUserData()
        End Select
    End Sub

    ''' <summary>
    ''' Set User Data
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub SetUserData()
        Try
            Dim oGroupInfo As AppGroups = _bo_group.Get(m_GroupID)
            txtGROUPTEXT.Text = oGroupInfo.Grouptext
            'Panel_SetControlValue(grpGroupInfo, oGroupInfo)
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    ''' <summary>
    ''' Init control
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub InitControl()
        Control_SetFont(Me, CS_FONT_NAME)
        'Panel_InitControl(grpGroupInfo, "APP_GROUPS")
        If Globals.IS_ADMIN_TONG = True Then
            lblDonVi.Visible = False
        ElseIf (Globals.IS_ADMIN_TONG = False) AndAlso (Globals.IS_ADMIN_DV = True) Then
            lblDonVi.Visible = True
            'lblDonVi.Text = Globals.TENDONVI
            'lblDonVi.Text = Generals.DON_VI.TEN_DONVI
            treeDV.Visible = False
        End If
    End Sub

    ''' <summary>
    ''' Check item existed in list DONVI
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function IsExistItemInListDV()
        If LIST_DONVI.Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    ''' <summary>
    ''' Save data to database
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub SaveData()
        Try
            Dim ObjInfo As New AppGroups
            Dim objLast As New AppGroups
            Dim infoDG As New AppDvGroup
            ObjInfo.Grouptext = txtGROUPTEXT.Text
            ObjInfo.Id = m_GroupID

            

            Select Case m_InputState
                '****************************************************
                '********** ADD MODE ********************************
                '****************************************************
                Case DataInputState.AddMode, DataInputState.CopyMode
                    _bo_group.Save(ObjInfo)
                    '************************************************
                    '********** UPDATE MODE *************************
                    '************************************************
                Case DataInputState.EditMode
                    _bo_group.SaveOrUpdate(ObjInfo)

                    'Delete donvi for group
                    AppDvGroupService.DeleteByG(ObjInfo.Id)


            End Select

            Dim dsDonviChecck As IList(Of Guid) = New List(Of Guid)
            Dim dsAppDvGroup As List(Of AppDvGroup) = New List(Of AppDvGroup)
            For Each node As TreeListNode In treeDV.Nodes
                If node.Checked Then
                    Dim itemCheck As Guid = CType(node.GetValue(0), Guid)

                    infoDG = New AppDvGroup()
                    infoDG.DvId = itemCheck
                    infoDG.GroupId = ObjInfo.Id
                    infoDG.GroupOrder = 0

                    _bo_dv_group.Save(infoDG)
                End If
            Next
        Catch ex As Exception
            Throw New Exception(ex.ToString)
        End Try
    End Sub

    ''' <summary>
    ''' Bind list DONVI to TreeList
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub BindDV()
        Try
            Dim dt As List(Of DmDonvi) = New List(Of DmDonvi)
            dt.AddRange(DmDonviService.GetAll())
            'If (Globals.IS_ADMIN_TONG = True) Then
            '    'dt = bo_dv.GetAll().Tables(0)
            'ElseIf (Globals.IS_ADMIN_TONG = False) AndAlso (Globals.IS_ADMIN_DV = True) Then
            '    dt = New List(Of DmDonvi)
            '    dt.Add(_bo_dv.Get(Generals.DonviID))
            'End If
            treeDV.DataSource = dt
        Catch
        End Try
    End Sub

    ''' <summary>
    ''' Load list LIST_DONVI
    ''' </summary>
    ''' <param name="group_id"></param>
    ''' <remarks></remarks>
    Private Sub LoadListDV(ByVal group_id As Guid)
        Try
            If group_id = Guid.Empty Then 'ADD
                LIST_DONVI = New List(Of Guid)
            Else 'UPDATE
                LIST_DONVI = New List(Of Guid)
                Dim dt As List(Of AppDvGroup) = New List(Of AppDvGroup)()
                dt.AddRange(_bo_dv_group.GetByGroup(group_id))
                If dt.Count > 0 Then
                    For Each row As AppDvGroup In dt
                        Dim donvi_id As Guid = row.DvId
                        If IsExistedItemInList(LIST_DONVI, donvi_id) = False Then
                            LIST_DONVI.Add(donvi_id)
                        End If
                    Next
                End If
            End If
        Catch
        End Try
    End Sub

    ''' <summary>
    ''' Select DONVI for GROUP
    ''' </summary>
    ''' <param name="group_id"></param>
    ''' <remarks></remarks>
    Private Sub SelectDVForGroup(ByVal group_id As Guid)
        Try
            If Not group_id = Guid.Empty Then
                For Each node As TreeListNode In treeDV.Nodes
                    Dim itemCheck As Guid = CType(node.GetValue(0), Guid)
                    If IsExistedItemInList(LIST_DONVI, itemCheck) = True Then
                        node.Checked = True
                    End If
                Next
            End If
        Catch
        End Try
    End Sub

    ''' <summary>
    ''' Checked first node
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub SelectFirstDV()
        Try
            'If (Globals.IS_ADMIN_TONG = False) AndAlso (Globals.IS_ADMIN_DV = False) Then 'ADMIN DV
            '    If m_GroupID = 0 Then 'ADD MODE
            '        If treeDV.Nodes.Count > 0 Then 'HAVE ANY GROUPS IN TREE LIST
            '            treeDV.Nodes(0).Checked = True
            '        End If
            '    End If
            'End If
            treeDV.Nodes(0).Checked = True
        Catch
        End Try
    End Sub

    ''' <summary>
    ''' Check item existed in list string
    ''' </summary>
    ''' <param name="list"></param>
    ''' <param name="item"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function IsExistedItemInList(ByVal list As List(Of Guid), ByVal item As Guid) As Boolean
        Try
            Dim bReturn As Boolean = False
            For Each info As Guid In list
                If info = item Then
                    bReturn = True
                End If
            Next
            Return bReturn
        Catch
            Return False
        End Try
    End Function

#End Region

#Region "Event Handles"

    ''' <summary>
    ''' Exit from user
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Try
            Me.Close()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    ''' <summary>
    ''' Clear data from control
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Control_ClearData(grpGroupInfo)
    End Sub

    ''' <summary>
    ''' Do save
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Try
            If Not Panel_CheckError(Me.grpGroupInfo) Then
                Return
            End If
            If String.IsNullOrEmpty(txtGROUPTEXT.Text.Trim()) Then
                Message_Information("Tên nhóm không được bỏ trống !")
                Return
            End If
            If Globals.IS_ADMIN_TONG = True Then
                If IsExistItemInListDV() = False Then
                    Message_Information("Bạn cần còn ít nhất một đơn vị cho nhóm !")
                    Return
                End If
            End If

            frmProgress.Instance.Thread = AddressOf SaveData
            frmProgress.Instance.Show_Progress("Saving data")
            frmProgress.Instance.SetFinishText(ConstantMsgs.MESSAGE_SAVE_SUCCESS)
            Me.Tag = Me.txtGROUPTEXT.Text
            Me.DialogResult = DialogResult.OK
            Me.Close()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    ''' <summary>
    ''' Form Load
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub frmGroupEdit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            BindDV()
            LoadListDV(m_GroupID)
            SelectDVForGroup(m_GroupID)
            SelectFirstDV()
        Catch
        End Try
    End Sub

    Private Sub treeDV_AfterCheckNode(ByVal sender As System.Object, ByVal e As DevExpress.XtraTreeList.NodeEventArgs) Handles treeDV.AfterCheckNode
        Try
            Dim rowView As DmDonvi = CType(treeDV.GetDataRecordByNode(e.Node), DmDonvi)
            Dim donvi_id As Guid = rowView.Id
            If e.Node.Checked = True Then
                LIST_DONVI.Add(donvi_id)
            Else
                LIST_DONVI.Remove(donvi_id)
            End If
        Catch
        End Try
    End Sub
#End Region

End Class