Public Class ShortCutInfo
#Region "Fields"
    Private _KEY As String
    Private _DESCRIPTION As String
#End Region

#Region "Properties"
    Public Property KEY() As String
        Get
            Return _KEY
        End Get
        Set(ByVal value As String)
            _KEY = value
        End Set
    End Property

    Public Property DESCRIPTION() As String
        Get
            Return _DESCRIPTION
        End Get
        Set(ByVal value As String)
            _DESCRIPTION = value
        End Set
    End Property
#End Region

#Region "Constructor"
    Public Sub New()
    End Sub

    Public Sub New(ByVal KEY As String, ByVal DESCRIPTION As String)
        Me.KEY = KEY
        Me.DESCRIPTION = DESCRIPTION
    End Sub
#End Region
End Class
