Public Class FormDataInfo
#Region "Private Variable"
    Private _FORMNAME As String = String.Empty
    Private _FORMDATA As String = String.Empty
#End Region

#Region "Property"
    Public Property FORMNAME() As String
        Get
            Return _FORMNAME
        End Get
        Set(ByVal value As String)
            _FORMNAME = value
        End Set
    End Property

    Public Property FORMDATA() As String
        Get
            Return _FORMDATA
        End Get
        Set(ByVal value As String)
            _FORMDATA = value
        End Set
    End Property
#End Region

#Region "Init Class"
    Public Sub New()
    End Sub

    Public Sub New(ByVal FORMNAME As String, ByVal FORMDATA As String)
        Me.FORMNAME = FORMNAME
        Me.FORMDATA = FORMDATA
    End Sub
#End Region
End Class
