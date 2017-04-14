Public Class ParamInfo
#Region "Private Variable"
    Private _PARAMNAME As String = String.Empty
    Private _PARAMVALUE As String = String.Empty
#End Region

#Region "Property"
    Public Property PARAMNAME() As String
        Get
            Return _PARAMNAME
        End Get
        Set(ByVal value As String)
            _PARAMNAME = value
        End Set
    End Property

    Public Property PARAMVALUE() As String
        Get
            Return _PARAMVALUE
        End Get
        Set(ByVal value As String)
            _PARAMVALUE = value
        End Set
    End Property
#End Region

#Region "Init Class"
    Public Sub New()
    End Sub
    Public Sub New(ByVal PARAMNAME As String, ByVal PARAMVALUE As String)
        Me.PARAMNAME = PARAMNAME
        Me.PARAMVALUE = PARAMVALUE
    End Sub
#End Region
End Class
