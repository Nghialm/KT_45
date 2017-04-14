Public Class CultureSettingInfo
    Private _Name As String
    Private _Code As String
    Private _DateFormat As String
    Private _DateSeparator As String
    Private _TimeFormat As String
    Private _TimeSeparator As String
    Private _DecimalSeparator As String
    Private _GroupSeparator As String
    Private _CalendarLanguage As String
    Private _Extend1 As String
    Private _Extend2 As String
    Private _Extend3 As String
    Private _Extend4 As String
    Private _Extend5 As String
    Private _Extend6 As String
    Private _Extend7 As String
    Private _Extend8 As String
    Private _Extend9 As String
    Private _Extend10 As String

    Public Property Name() As String
        Get
            Return _Name
        End Get
        Set(ByVal value As String)
            _Name = value
        End Set
    End Property

    Public Property Code() As String
        Get
            Return _Code
        End Get
        Set(ByVal value As String)
            _Code = value
        End Set
    End Property

    Public Property DateFormat() As String
        Get
            Return _DateFormat
        End Get
        Set(ByVal value As String)
            _DateFormat = value
        End Set
    End Property

    Public Property DateSeparator() As String
        Get
            Return _DateSeparator
        End Get
        Set(ByVal value As String)
            _DateSeparator = value
        End Set
    End Property

    Public Property TimeFormat() As String
        Get
            Return _TimeFormat
        End Get
        Set(ByVal value As String)
            _TimeFormat = value
        End Set
    End Property

    Public Property TimeSeparator() As String
        Get
            Return _TimeSeparator
        End Get
        Set(ByVal value As String)
            _TimeSeparator = value
        End Set
    End Property

    Public Property DecimalSeparator() As String
        Get
            Return _DecimalSeparator
        End Get
        Set(ByVal value As String)
            _DecimalSeparator = value
        End Set
    End Property

    Public Property GroupSeparator() As String
        Get
            Return _GroupSeparator
        End Get
        Set(ByVal value As String)
            _GroupSeparator = value
        End Set
    End Property

    Public Property CalendarLanguage() As String
        Get
            Return _CalendarLanguage
        End Get
        Set(ByVal value As String)
            _CalendarLanguage = value
        End Set
    End Property

    Public Property Extend1() As String
        Get
            Return _Extend1
        End Get
        Set(ByVal value As String)
            _Extend1 = value
        End Set
    End Property

    Public Property Extend2() As String
        Get
            Return _Extend2
        End Get
        Set(ByVal value As String)
            _Extend2 = value
        End Set
    End Property

    Public Property Extend3() As String
        Get
            Return _Extend3
        End Get
        Set(ByVal value As String)
            _Extend3 = value
        End Set
    End Property

    Public Property Extend4() As String
        Get
            Return _Extend4
        End Get
        Set(ByVal value As String)
            _Extend4 = value
        End Set
    End Property

    Public Property Extend5() As String
        Get
            Return _Extend5
        End Get
        Set(ByVal value As String)
            _Extend5 = value
        End Set
    End Property

    Public Property Extend6() As String
        Get
            Return _Extend6
        End Get
        Set(ByVal value As String)
            _Extend6 = value
        End Set
    End Property

    Public Property Extend7() As String
        Get
            Return _Extend7
        End Get
        Set(ByVal value As String)
            _Extend7 = value
        End Set
    End Property

    Public Property Extend8() As String
        Get
            Return _Extend8
        End Get
        Set(ByVal value As String)
            _Extend8 = value
        End Set
    End Property

    Public Property Extend9() As String
        Get
            Return _Extend9
        End Get
        Set(ByVal value As String)
            _Extend9 = value
        End Set
    End Property

    Public Property Extend10() As String
        Get
            Return _Extend10
        End Get
        Set(ByVal value As String)
            _Extend10 = value
        End Set
    End Property

    Public Sub New()
    End Sub

    Public Sub New(ByVal Name As String, _
                    ByVal Code As String, _
                    ByVal DateFormat As String, _
                    ByVal DateSeparator As String, _
                    ByVal TimeFormat As String, _
                    ByVal TimeSeparator As String, _
                    ByVal DecimalSeparator As String, _
                    ByVal GroupSeparator As String, _
                    ByVal CalendarLanguage As String, _
                    ByVal Extend1 As String, _
                    ByVal Extend2 As String, _
                    ByVal Extend3 As String, _
                    ByVal Extend4 As String, _
                    ByVal Extend5 As String, _
                    ByVal Extend6 As String, _
                    ByVal Extend7 As String, _
                    ByVal Extend8 As String, _
                    ByVal Extend9 As String, _
                    ByVal Extend10 As String)
        Me.Name = Name
        Me.Code = Code
        Me.DateFormat = DateFormat
        Me.DateSeparator = DateSeparator
        Me.TimeFormat = TimeFormat
        Me.TimeSeparator = TimeSeparator
        Me.DecimalSeparator = DecimalSeparator
        Me.GroupSeparator = GroupSeparator
        Me.CalendarLanguage = CalendarLanguage
        Me.Extend1 = Extend1
        Me.Extend2 = Extend2
        Me.Extend3 = Extend3
        Me.Extend4 = Extend4
        Me.Extend5 = Extend5
        Me.Extend6 = Extend6
        Me.Extend7 = Extend7
        Me.Extend8 = Extend8
        Me.Extend9 = Extend9
        Me.Extend10 = Extend10
    End Sub
End Class
