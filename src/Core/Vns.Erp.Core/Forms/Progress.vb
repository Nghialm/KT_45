'*******************************************************************
' Purpose:  Form dung de goi cac thu tuc va ham long running trong 1 thread
' Notes:    Người sử dụng sẽ trao vào AddressOf thủ tục, thủ tục có tham số hoặc function để chạy
'           Hỗ trợ thay đổi Description
'           - Properties:
'                ThreadFunction: AddressOf hàm 
'                ThreadSub: AddressOf thủ tục có tham số
'                Thread: AddressOf thủ tục không có tham số
' History:
'     [Programer]       [DD-MMM-YYYY]       [Action]
'     LuanNH            09-May-2007         Created
'*******************************************************************  

Imports System.Globalization
Imports System.Threading
Imports System.Windows.Forms

Public Class frmProgress

#Region "Contructor"
    Private Shared _instance As frmProgress

    '// Note: Constructor is 'protected'
    'Protected Sub New()
    'End Sub
    '// Note: Dispose is 'protected'
    Protected Overloads Sub Dispose()
        _instance.Dispose()
        _instance = Nothing
        MyBase.Dispose()
    End Sub
    '// Lock synchronization object
    Private Shared _syncLock As Object = New Object()
    ' return the provider
    Public Shared Shadows Function Instance() As frmProgress
        '// Support multithreaded applications through
        '// 'Double checked locking' pattern which (once
        '// the instance exists) avoids locking each
        '// time the method is invoked 
        If _instance Is Nothing Then
            SyncLock _syncLock
                If _instance Is Nothing Then
                    _instance = New frmProgress
                    _instance.Tag = "MAIN_INIT"
                End If
            End SyncLock
        End If
        Return _instance
    End Function
#End Region

    Public Delegate Function FunctionInvoker(ByVal sInput As Object) As Object
    Public Delegate Sub SubInvoker(ByVal sInput As Object)

    Private _ThreadFunction As FunctionInvoker
    Private _ThreadSub As SubInvoker
    Private _ThreadMethod As MethodInvoker

    Public ThreadInputObject As Object
    Private _ThreadOutputObject As Object
    '
    Private m_objThread As System.Threading.Thread
    '
    Private m_sTextDescription As String
    Private m_sTextFinish As String
    '
    Private m_TheardException As Exception
    Private m_sErrorRaTEMS As String
    '

    Public WriteOnly Property ThreadFunction() As FunctionInvoker
        Set(ByVal value As FunctionInvoker)
            _ThreadFunction = value
            _ThreadSub = Nothing
            _ThreadMethod = Nothing
            _ThreadOutputObject = Nothing
        End Set
    End Property

    Public WriteOnly Property ThreadSub() As SubInvoker
        Set(ByVal value As SubInvoker)
            _ThreadSub = value
            _ThreadFunction = Nothing
            _ThreadMethod = Nothing
        End Set
    End Property

    Public WriteOnly Property Thread() As MethodInvoker
        Set(ByVal value As MethodInvoker)
            _ThreadMethod = value
            _ThreadSub = Nothing
            _ThreadFunction = Nothing
        End Set
    End Property

    Public ReadOnly Property IsAbort() As Boolean
        Get
            Dim bStop As Boolean = AppDomain.CurrentDomain.GetData("Progress_Abort")
            Return bStop
        End Get
    End Property

    'Public Overloads Sub Show()
    '    If Me.Tag Is Nothing Then
    '        Throw New Exception("Use frmProgress.Instance.Show for display progress")
    '    End If
    '    Me.InitializeComponent()
    '    Show_Progress("Loading ...")
    'End Sub

    'Public Overloads Sub Show(ByVal sDescription As String)
    '    If Me.Tag Is Nothing Then
    '        Throw New Exception("Use frmProgress.Instance.Show for display progress")
    '    End If
    '    Me.InitializeComponent()
    '    Show_Progress(sDescription)
    'End Sub

    'Public Overloads Function ShowDialog() As DialogResult
    '    If Me.Tag = "MAIN_INIT" Then
    '        Throw New Exception("Use method Show instead of ShowDialog on frmProgress.Instance")
    '    ElseIf Me.Tag Is Nothing Then
    '        Throw New Exception("Use frmProgress.Instance.Show for display progress")
    '    End If
    '    Return MyBase.ShowDialog()
    'End Function

    'Public Overloads Function ShowDialog() As DialogResult
    '    Me.InitializeComponent()
    '    Show_Progress("Loading ...")
    'End Function

    'Public Overloads Function ShowDialog(ByVal sDescription As String) As DialogResult
    '    Me.InitializeComponent()
    '    If sDescription = "" Then sDescription = "Loading ..."
    '    Show_Progress(sDescription)
    'End Function
    '*******************************************************************
    ' Purpose:  hàm Public để show progress
    ' Notes:    Trong trường hợp hỗ trợ cancel thì phải có đoạn handle ThreadAbortException để xử lý
    '     - Inputs: 
    '               sDescription : init description text
    '               bAllowCancel : hỗ trợ cancel hay không
    '     - Return: Trả lại kết quả tính toán của ThreadFunction (nếu có)
    ' History:
    '     [Programer]       [DD-MMM-YYYY]       [Action]
    '     LuânNH            09-May-2007         Created
    '     [Modifier]        [Modify Date]       Updated
    '*******************************************************************  
    Public Function Show_Progress(ByVal sStart As String, ByVal sFinish As String) As Object
        m_sTextFinish = sFinish
        Me.Visible = False
        Return Show_Progress(sStart, False)
    End Function

    Public Function Show_Progress__1(ByVal sStart As String, ByVal sFinish As String, ByVal sForm As Object) As Object
        'sForm.Visible = False
        m_sTextFinish = sFinish
        Me.Visible = False
        Return Show_Progress(sStart, False)
    End Function

    Public Function Show_Progress() As Object
        m_sTextFinish = ""
        Me.Visible = False
        Return Show_Progress("Loading ...", False)
    End Function

    Public Function Show_Progress(ByVal sStart As String) As Object
        m_sTextFinish = ""
        Me.Visible = False
        Return Show_Progress(sStart, False)
    End Function

    Public Function Show_Progress(ByVal sStart As String, ByVal bAllowCancel As Boolean) As Object
        'Prevent wrong call
        If _ThreadMethod Is Nothing And _ThreadSub Is Nothing And _ThreadFunction Is Nothing Then
            Throw New Exception("Nothing method or function assigned")
        End If
        Try
            'm_sErrorRaTEMS = "Init_Circle"
            Init_Circle(Me.LoadingCircle)
            If Not m_objThread Is Nothing Then m_objThread.Abort()
            m_objThread = New System.Threading.Thread(AddressOf Show_Circle)
            '
            'm_sErrorRaTEMS = "SetDescription"
            '
            If String.IsNullOrEmpty(sStart) Then
                sStart = "Loading ..."
            Else
                If Not sStart.EndsWith("...") Then
                    sStart += " ..."
                End If
            End If
            m_sTextDescription = sStart
            SetDescription()
            '
            cmdCancel.Visible = bAllowCancel
            m_TheardException = Nothing
            '
            If Not bAllowCancel Then
                Me.Width = 240
            End If
            '
            'm_sErrorRaTEMS = "ShowDialog"
            '
            Me.Tag = "MAIN_PRORESS"
            Me.TopMost = False
            Me.Timer_Event.Enabled = False
            Me.ShowDialog()
            '
            'If m_objThread.ThreadState = ThreadState.Running Then
            '    AppDomain.CurrentDomain.SetData("Progress_Stop", True)
            '    While m_objThread.ThreadState <> ThreadState.Stopped
            '        System.Threading.Thread.Sleep(50)
            '    End While
            '    m_objThread.Abort()
            '    m_objThread = Nothing
            'End If
            '
            If Not m_TheardException Is Nothing Then
                'Throw m_TheardException
            End If

        Catch ex As ThreadStartException

            'Throw ex
            'Throw New Exception(m_sErrorRaTEMS + ": " + ex.Message)
        Catch tsEx As ThreadStateException
            'Khong su ly gi
        Catch otherEx As Exception
            'Throw otherEx
        Finally
            'm_TheardException = Nothing
            'Me.Hide()
        End Try
        Return _ThreadOutputObject
    End Function

    Private Sub Init_Circle(ByVal lc As FAMP.LoadingCircle)
        lc.StylePreset = FAMP.LoadingCircle.StylePresets.Custom
        lc.OuterCircleRadius = 12
        lc.InnerCircleRadius = 9
        lc.NumberSpoke = 12
        lc.SpokeThickness = 4
        lc.RotationSpeed = 150
        lc.Active = False
    End Sub
    '*******************************************************************
    ' Purpose:  hàm Public để set description text
    ' Notes:    
    '     - Inputs: 
    '               sDescription : description text
    ' History:
    '     [Programer]       [DD-MMM-YYYY]       [Action]
    '     LuânNH            09-May-2007         Created
    '     [Modifier]        [Modify Date]       Updated
    '*******************************************************************  
    Public Sub SetDescriptionText(ByVal sDescription As String)
        m_sTextDescription = sDescription
        SetDescription()
    End Sub

    Private Sub SetDescription()
        'If Me.InvokeRequired Then
        '    Me.Invoke(New MethodInvoker(AddressOf SetDescription))
        'Else
        '    'lbDescription.Text = m_sTextDescription
        '    'lbDescription.Refresh()
        '    'Me.Refresh()
        'End If
        lbDescription.Text = m_sTextDescription
        AppDomain.CurrentDomain.SetData("Progress_Desc", m_sTextDescription)
    End Sub
    '*******************************************************************
    ' Purpose:  hàm Public để set Finish description text
    ' Notes:    
    '     - Inputs: 
    '               sFinish : chuỗi Finish description text 
    ' History:
    '     [Programer]       [DD-MMM-YYYY]       [Action]
    '     LuânNH            09-May-2007         Created
    '     [Modifier]        [Modify Date]       Updated
    '*******************************************************************  
    Public Sub SetFinishText(Optional ByVal sFinish As String = "Data saved", Optional ByVal iDelay As Integer = 500)
        m_sTextDescription = sFinish
        SetDescription()
        'Delay iDelay milTEMScond
        System.Threading.Thread.Sleep(iDelay)
    End Sub
    '*******************************************************************
    ' Purpose:  hàm để gọi trong Thread và Invoke thủ tục hoặc hàm
    ' Notes:    
    ' History:
    '     [Programer]       [DD-MMM-YYYY]       [Action]
    '     LuânNH            09-May-2007         Created
    '     [Modifier]        [Modify Date]       Updated
    '*******************************************************************  
    Private Sub Dummy_Function()
        Try
            If Not _ThreadMethod Is Nothing Then
                _ThreadMethod.Invoke()
            ElseIf Not _ThreadSub Is Nothing Then
                _ThreadSub.Invoke(ThreadInputObject)
            ElseIf Not _ThreadFunction Is Nothing Then
                _ThreadOutputObject = _ThreadFunction.Invoke(ThreadInputObject)
            End If
        Catch ex As Exception
            'm_TheardException = ex
        Finally
            'Me.Invoke(New MethodInvoker(AddressOf Me.Close))
        End Try
    End Sub

    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        SetDescriptionText("Cancelling ...")
        AppDomain.CurrentDomain.SetData("Progress_Abort", True)
        cmdCancel.Enabled = False
    End Sub

    Private Sub Timer_Event_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer_Event.Tick
        Try
            'If Me.Tag = "CHILD" Then
            '    lbDescription.Text = AppDomain.CurrentDomain.GetData("Progress_Desc")
            '    Dim bStop As Boolean = AppDomain.CurrentDomain.GetData("Progress_Stop")
            '    If bStop Then Me.Hide()
            'ElseIf Me.Tag = "MAIN_PROGRESS" Then
            '    Dim bStop As Boolean = AppDomain.CurrentDomain.GetData("Progress_Abort")
            'End If
            If (m_objThread Is Nothing) Then
                Me.Close()
                Return
            End If

            If (m_objThread.ThreadState = System.Threading.ThreadState.Stopped Or Not m_objThread.IsAlive) Then
                m_objThread.Abort()
                m_objThread = Nothing
                Me.Close()
            End If

        Catch

        End Try
    End Sub

    Private Sub Show_Circle()
        Dim f As New frmProgress
        Try
            m_sErrorRaTEMS = "Init Child"
            Init_Circle(f.LoadingCircle)
            f.LoadingCircle.Active = True
            f.Timer_Event.Interval = 75
            f.Timer_Event.Enabled = True
            f.lbDescription.Text = m_sTextDescription
            f.Tag = "CHILD"
            f.Width = Me.Width
            f.TopMost = Me.TopMost
            f.cmdCancel.Visible = Me.cmdCancel.Visible
            f.cmdCancel.TabStop = False
            m_sErrorRaTEMS = "Show Child"
            f.ShowDialog()
        Catch
        Finally
            f.LoadingCircle.Active = False
            f.Timer_Event.Enabled = False
            f.Close()
        End Try
    End Sub

    Private Sub frmProgress_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Try
            If Me.Tag = "MAIN_PRORESS" Then
                If m_objThread Is Nothing Then
                    'Throw New Exception("Thread is nothing")
                    Me.Close()
                    Return
                End If
                '
                AppDomain.CurrentDomain.SetData("Progress_Abort", False)
                AppDomain.CurrentDomain.SetData("Progress_Stop", False)
                '
                m_sErrorRaTEMS = "Thread start"
                '
                m_objThread.Start()
                '
                Application.DoEvents()
                '
                m_sErrorRaTEMS = "Process Function"
                '
                Dummy_Function()
                '
                If m_sTextFinish <> "" Then
                    SetFinishText(m_sTextFinish)
                    m_sTextFinish = ""
                End If
                '
                Me.Close()
            Else
                Application.DoEvents()
            End If
        Catch ex As Exception
            'm_TheardException = ex
        End Try
    End Sub
End Class