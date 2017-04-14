Public Class DMOrder
#Region "Variables"
    Private _MA_DM As String
    Private _TEN_DM As String
    Private _THU_TU As Integer
#End Region

#Region "Properties"
    Public Property MA_DM() As String
        Get
            Return _MA_DM
        End Get
        Set(ByVal value As String)
            _MA_DM = value
        End Set
    End Property

    Public Property TEN_DM() As String
        Get
            Return _TEN_DM
        End Get
        Set(ByVal value As String)
            _TEN_DM = value
        End Set
    End Property

    Public Property THU_TU() As Integer
        Get
            Return _THU_TU
        End Get
        Set(ByVal value As Integer)
            _THU_TU = value
        End Set
    End Property
#End Region

#Region "Constructors"
    Public Sub New()
    End Sub
    Public Sub New(ByVal MA_DM As String, ByVal TEN_DM As String, ByVal THU_TU As Integer)
        Me.MA_DM = MA_DM
        Me.TEN_DM = TEN_DM
        Me.THU_TU = THU_TU
    End Sub
#End Region
End Class
