Public Class ColInfo
    Private _ColName As String
    Private _ColCaption As String
    Private _ColWidth As Integer
    Private _ColVisible As String
    Private _ColReadOnly As String
    Private _ColVisibleIndex As Integer
    Public Property ColName() As String
        Get
            Return _ColName
        End Get
        Set(ByVal value As String)
            _ColName = value
        End Set
    End Property

    Public Property ColCaption() As String
        Get
            Return _ColCaption
        End Get
        Set(ByVal value As String)
            _ColCaption = value
        End Set
    End Property

    Public Property ColWidth() As Integer
        Get
            Return _ColWidth
        End Get
        Set(ByVal value As Integer)
            _ColWidth = value
        End Set
    End Property

    Public Property ColVisible() As String
        Get
            Return _ColVisible
        End Get
        Set(ByVal value As String)
            _ColVisible = value
        End Set
    End Property

    Public Property ColReadOnly() As String
        Get
            Return _ColReadOnly
        End Get
        Set(ByVal value As String)
            _ColReadOnly = value
        End Set
    End Property

    Public Property ColVisibleIndex() As Integer
        Get
            Return _ColVisibleIndex
        End Get
        Set(ByVal value As Integer)
            _ColVisibleIndex = value
        End Set
    End Property



    Public Sub New()
    End Sub

    Public Sub New(ByVal ColName As String, ByVal ColCaption As String, ByVal ColWidth As Integer, ByVal ColVisible As String, _
                   ByVal ColReadOnly As String, ByVal ColVisibleIndex As Integer)

        Me.ColName = ColName
        Me.ColCaption = ColCaption
        Me.ColWidth = ColWidth
        Me.ColVisible = ColVisible
        Me.ColReadOnly = ColReadOnly
        Me.ColVisibleIndex = ColVisibleIndex
    End Sub

End Class
