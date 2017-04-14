Public Class ValueInfo
    Private _ID_DM As String = String.Empty

    Public Property ID_DM() As String
        Get
            Return _ID_DM
        End Get
        Set(ByVal value As String)
            _ID_DM = value
        End Set
    End Property

    Private _MA_DM As String = String.Empty

    Public Property MA_DM() As String
        Get
            Return _MA_DM
        End Get
        Set(ByVal value As String)
            _MA_DM = value
        End Set
    End Property

    Private _Ky_Hieu As String

    Public Property Ky_Hieu() As String
        Get
            Return _Ky_Hieu
        End Get
        Set(ByVal value As String)
            _Ky_Hieu = value
        End Set
    End Property

    Private _Ten As String = String.Empty

    Public Property Ten() As String
        Get
            Return _Ten
        End Get
        Set(ByVal value As String)
            _Ten = value
        End Set
    End Property

    Private _ParameterValue As Object = New Object()

    Public Property ParameterValue() As Object
        Get
            Return _ParameterValue
        End Get
        Set(ByVal value As Object)
            _ParameterValue = value
        End Set
    End Property

    Private _Tu_Ngay As Object = DateTime.Now

    Public Property Tu_Ngay() As Object
        Get
            Return _Tu_Ngay
        End Get
        Set(ByVal value As Object)
            _Tu_Ngay = value
        End Set
    End Property


    Private _Den_Ngay As Object = DateTime.Now

    Public Property Den_Ngay() As Object
        Get
            Return _Den_Ngay
        End Get
        Set(ByVal value As Object)
            _Den_Ngay = value
        End Set
    End Property
End Class
