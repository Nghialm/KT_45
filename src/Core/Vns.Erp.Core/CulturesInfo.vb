Public Class CulturesInfo
    Private _Name As String
    Private _Code As String
    Private _Example As String
    Private _IsUsed As Integer
    Private _IconIndex As Integer = 0
    Private _Description As String

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

    Public Property Example() As String
        Get
            Return _Example
        End Get
        Set(ByVal value As String)
            _Example = value
        End Set
    End Property

    Public Property IsUsed() As Integer
        Get
            Return _IsUsed
        End Get
        Set(ByVal value As Integer)
            _IsUsed = value
        End Set
    End Property

    Public Property IconIndex() As Integer
        Get
            Return _IconIndex
        End Get
        Set(ByVal value As Integer)
            _IconIndex = value
        End Set
    End Property

    Public Property Description() As String
        Get
            Return _Description
        End Get
        Set(ByVal value As String)
            _Description = value
        End Set
    End Property

    Public Sub New()
    End Sub

    Public Sub New(ByVal Name As String, ByVal Code As String, ByVal Example As String, ByVal IsUsed As Integer, ByVal IconIndex As Integer, ByVal Description As String)
        Me.Name = Name
        Me.Code = Code
        Me.Example = Example
        Me.IsUsed = IsUsed
        Me.IconIndex = IconIndex
        Me.Description = Description
    End Sub
End Class
