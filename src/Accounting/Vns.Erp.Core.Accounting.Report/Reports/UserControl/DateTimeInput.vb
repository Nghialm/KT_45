Imports Vns.Erp.Core.Admin.Domain
Imports Vns.Erp.Core.Admin.Service.Interface

Public Class DateTimeInput 

#Region "Variables"
    Private _StartDate As Date
    Private _EndDate As Date
    Private StartTemp As Date
    Private EndTemp As Date
#End Region

#Region "Properties"
    Public Property StartDate() As Date
        Get
            Return _StartDate
        End Get
        Set(ByVal value As Date)
            _StartDate = value
        End Set
    End Property

    Public Property EndDate() As Date
        Get
            Return _EndDate
        End Get
        Set(ByVal value As Date)
            _EndDate = value
        End Set
    End Property


#End Region

#Region "Common Functions"
    Private Sub BindYear()
        For i As Integer = DateTime.Now.Year + 2 To 1995 Step -1
            cmbYear.Properties.Items.Add(i)
            cmbYearMonth.Properties.Items.Add(i)
            cmbYearTerm.Properties.Items.Add(i)
        Next
        cmbYear.SelectedItem = DateTime.Now.Year
        cmbYearMonth.SelectedItem = DateTime.Now.Year
        cmbYearTerm.SelectedItem = DateTime.Now.Year
    End Sub

    Private Sub SetValue()
        StartDate = StartTemp
        EndDate = EndTemp
        Dim strMode As String = ""
        If cmbSelectMode.SelectedIndex = 0 Then
            Value_info.Tu_Ngay = StartDate
            Value_info.Den_Ngay = EndDate
            Value_info.ParameterValue = "-1"
            Value_info.Ten = "Từ ngày: " + StartDate.Day.ToString + "/" + StartDate.Month.ToString + "/" + StartDate.Year.ToString
            Value_info.Ten += "   " + "Đến ngày: " + EndDate.Day.ToString + "/" + EndDate.Month.ToString + "/" + EndDate.Year.ToString
        ElseIf cmbSelectMode.SelectedIndex = 1 Then
            Value_info.Tu_Ngay = StartDate
            Value_info.Den_Ngay = EndDate
            Value_info.ParameterValue = "-1"
            Value_info.Ten = "Tháng: " + cmbMonth.SelectedItem.ToString + "   " + "Năm: " + cmbYearMonth.SelectedItem.ToString
        ElseIf cmbSelectMode.SelectedIndex = 2 Then
            Value_info.Tu_Ngay = StartDate
            Value_info.Den_Ngay = EndDate
            Value_info.ParameterValue = "-1"
            Value_info.Ten = "Quý: " + cmbTerm.SelectedItem.ToString + "   " + "Năm: " + cmbYearTerm.SelectedItem.ToString
        ElseIf cmbSelectMode.SelectedIndex = 3 Then
            Value_info.Tu_Ngay = StartDate
            Value_info.Den_Ngay = EndDate
            Value_info.ParameterValue = "-1"
            Value_info.Ten = "Năm: " + cmbYear.SelectedItem.ToString
        End If
        Value_info.Tu_Ngay = VnsConvert.CStartOfDate(Value_info.Tu_Ngay)
        Value_info.Den_Ngay = VnsConvert.CEndOfDate(Value_info.Den_Ngay)
        'lblTuNgay.Text = StartDate.Day.ToString + "/" + StartDate.Month.ToString + "/" + StartDate.Year.ToString
        'lblDenNgay.Text = EndDate.Day.ToString + "/" + EndDate.Month.ToString + "/" + EndDate.Year.ToString
    End Sub
#End Region

#Region "Event Handles"
    Public Sub New()
        InitializeComponent()
    End Sub

    Public Sub New(ByVal HT_bienbaocao As HtBienBaocao)
        InitializeComponent()
        Parameter_info = HT_bienbaocao
    End Sub

    Private Sub DateTimeInput_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            If Not Me.DesignMode Then
                Try
                    'Init temp
                    StartTemp = Date.Now
                    EndTemp = Date.Now
                    StartDate = Date.Now
                    EndDate = Date.Now

                    'Init value
                    deDayStart.EditValue = Date.Now
                    deDayEnd.EditValue = Date.Now

                    BindYear()
                    '
                    cmbSelectMode.SelectedIndex = 0
                    SetValue()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            End If
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub cmbSelectMode_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbSelectMode.SelectedIndexChanged
        Try
            If cmbSelectMode.SelectedIndex = 0 Then 'Day
                deDayStart.Visible = True '204, 3
                deDayEnd.Visible = True '322, 3

                cmbMonth.Visible = False
                cmbYearMonth.Visible = False

                cmbTerm.Visible = False
                cmbYearTerm.Visible = False

                cmbYear.Visible = False

                AddHandler deDayStart.EditValueChanged, AddressOf deDayStart_EditValueChanged
                AddHandler deDayEnd.EditValueChanged, AddressOf deDayEnd_EditValueChanged
                deDayStart_EditValueChanged(sender, e)
                deDayEnd_EditValueChanged(sender, e)

            ElseIf cmbSelectMode.SelectedIndex = 1 Then 'Month
                deDayStart.Visible = False '204, 3
                deDayEnd.Visible = False '322, 3

                cmbTerm.Visible = False
                cmbYearTerm.Visible = False

                cmbMonth.Visible = True
                cmbMonth.Location = New Point(204, 3)
                cmbYearMonth.Visible = True
                cmbYearMonth.Location = New Point(322, 3)

                cmbYear.Visible = False

                AddHandler cmbMonth.SelectedIndexChanged, AddressOf cmbMonth_SelectedIndexChanged
                AddHandler cmbYearMonth.SelectedIndexChanged, AddressOf cmbYearMonth_SelectedIndexChanged
                cmbMonth_SelectedIndexChanged(sender, e)

            ElseIf cmbSelectMode.SelectedIndex = 2 Then 'Term
                deDayStart.Visible = False '204, 3
                deDayEnd.Visible = False '322, 3

                cmbMonth.Visible = False
                cmbYearMonth.Visible = False

                cmbTerm.Visible = True
                cmbTerm.Location = New Point(204, 3)
                cmbYearTerm.Visible = True
                cmbYearTerm.Location = New Point(322, 3)

                cmbYear.Visible = False

                AddHandler cmbTerm.SelectedIndexChanged, AddressOf cmbTerm_SelectedIndexChanged
                AddHandler cmbYearTerm.SelectedIndexChanged, AddressOf cmbYearTerm_SelectedIndexChanged
                cmbTerm_SelectedIndexChanged(sender, e)

            ElseIf cmbSelectMode.SelectedIndex = 3 Then 'Year
                deDayStart.Visible = False '204, 3
                deDayEnd.Visible = False '322, 3

                cmbMonth.Visible = False
                cmbYearMonth.Visible = False

                cmbTerm.Visible = False
                cmbYearTerm.Visible = False

                cmbYear.Visible = True
                cmbYear.Location = New Point(204, 3)

                AddHandler cmbYear.SelectedIndexChanged, AddressOf cmbYear_SelectedIndexChanged
                cmbYear_SelectedIndexChanged(sender, e)
            End If
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub
#End Region

#Region "Set Value"
    'Day Mode
    Private Sub deDayStart_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            StartTemp = deDayStart.EditValue
            SetValue()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub deDayEnd_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            EndTemp = deDayEnd.EditValue
            SetValue()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    'Month Mode
    Private Sub cmbMonth_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Dim year_selected As Integer = Integer.Parse(cmbYearMonth.SelectedItem.ToString)
            Dim month_selected As Integer = Integer.Parse(cmbMonth.SelectedItem.ToString)
            StartTemp = New Date(year_selected, month_selected, 1)
            EndTemp = StartTemp.AddMonths(1).AddDays(-1)
            SetValue()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub cmbYearMonth_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Dim year_selected As Integer = Integer.Parse(cmbYearMonth.SelectedItem.ToString)
            Dim month_selected As Integer = StartTemp.Month
            StartTemp = New Date(year_selected, month_selected, 1)
            EndTemp = StartTemp.AddMonths(1).AddDays(-1)
            SetValue()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    'Term Mode
    Private Sub cmbTerm_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Dim year_selected As Integer = Integer.Parse(cmbYearTerm.SelectedItem.ToString)
            If cmbTerm.SelectedIndex = 0 Then
                'Term 1 : Month 1, 2, 3 : 1/1 - 31/3
                StartTemp = New Date(year_selected, 1, 1)
                EndTemp = StartTemp.AddMonths(3).AddDays(-1)
            ElseIf cmbTerm.SelectedIndex = 1 Then
                'Term 2 : Month 4, 5, 6 : 1/4 - 30/6
                StartTemp = New Date(year_selected, 4, 1)
                EndTemp = StartTemp.AddMonths(3).AddDays(-1)
            ElseIf cmbTerm.SelectedIndex = 2 Then
                'Term 3 : Month 7, 8, 9 : 1/7 - 30/9
                StartTemp = New Date(year_selected, 7, 1)
                EndTemp = StartTemp.AddMonths(3).AddDays(-1)
            ElseIf cmbTerm.SelectedIndex = 3 Then
                'Term 4 : Month 10, 11, 12 : 1/10 - 31/12
                StartTemp = New Date(year_selected, 10, 1)
                EndTemp = StartTemp.AddMonths(3).AddDays(-1)
            End If
            SetValue()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    Private Sub cmbYearTerm_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Dim year_selected As Integer = Integer.Parse(cmbYearTerm.SelectedItem.ToString)
            Dim month_selected As Integer = StartTemp.Month
            Dim month_end As Integer = EndTemp.Month
            Dim day_end As Integer = EndTemp.Day
            StartTemp = New Date(year_selected, month_selected, 1)
            EndTemp = New Date(year_selected, month_end, day_end)
            SetValue()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

    'Year Mode
    Private Sub cmbYear_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Dim year_selected As Integer = Integer.Parse(cmbYear.SelectedItem.ToString)
            StartTemp = New Date(year_selected, 1, 1)
            EndTemp = New Date(year_selected, 12, 31)
            SetValue()
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub

#End Region

#Region "Key Down Events"
    Private Sub DateTimeInput_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Try
            Select Case e.KeyCode
                Case Keys.Enter
                    SendKeys.Send("TAB")
                Case Else
            End Select
        Catch ex As Exception
            Message_Error(ex)
        End Try
    End Sub
#End Region

End Class
