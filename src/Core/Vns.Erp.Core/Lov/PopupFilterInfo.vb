Public Class PopupFilterInfo
    Private _C_FORM_TITLE As String
    Private _C_DATA_SOURCE As DataTable
    Private _C_ARR_COLS_DISPLAY As String
    Private _C_KEY_NAME As String
    Private _C_ARR_COLS_RETURN As String
    Private _C_IS_QUICKADD As Boolean
    Private _C_FORM_DANHSACH As String

    Public Property C_FORM_TITLE() As String
        Get
            Return _C_FORM_TITLE
        End Get
        Set(ByVal value As String)
            _C_FORM_TITLE = value
        End Set
    End Property

    Public Property C_DATA_SOURCE() As System.Data.DataTable
        Get
            Return _C_DATA_SOURCE
        End Get
        Set(ByVal value As System.Data.DataTable)
            _C_DATA_SOURCE = value
        End Set
    End Property

    Public Property C_ARR_COLS_DISPLAY() As String
        Get
            Return _C_ARR_COLS_DISPLAY
        End Get
        Set(ByVal value As String)
            _C_ARR_COLS_DISPLAY = value
        End Set
    End Property

    Public Property C_KEY_NAME() As String
        Get
            Return _C_KEY_NAME
        End Get
        Set(ByVal value As String)
            _C_KEY_NAME = value
        End Set
    End Property

    Public Property C_ARR_COLS_RETURN() As String
        Get
            Return _C_ARR_COLS_RETURN
        End Get
        Set(ByVal value As String)
            _C_ARR_COLS_RETURN = value
        End Set
    End Property

    Public Property C_IS_QUICKADD() As Boolean
        Get
            Return _C_IS_QUICKADD
        End Get
        Set(ByVal value As Boolean)
            _C_IS_QUICKADD = value
        End Set
    End Property

    Public Property C_FORM_DANHSACH() As String
        Get
            Return _C_FORM_DANHSACH
        End Get
        Set(ByVal value As String)
            _C_FORM_DANHSACH = value
        End Set
    End Property

    Public Sub New()
    End Sub

    Public Sub New(ByVal C_FORM_TITLE As String, ByVal C_DATA_SOURCE As DataTable, ByVal C_ARR_COLS_DISPLAY As String, ByVal C_KEY_NAME As String, ByVal C_ARR_COLS_RETURN As String, ByVal C_IS_QUICKADD As Boolean, ByVal C_FORM_DANHSACH As String)
        Me.C_FORM_TITLE = C_FORM_TITLE
        Me.C_DATA_SOURCE = C_DATA_SOURCE
        Me.C_ARR_COLS_DISPLAY = C_ARR_COLS_DISPLAY
        Me.C_KEY_NAME = C_KEY_NAME
        Me.C_ARR_COLS_RETURN = C_ARR_COLS_RETURN
        Me.C_IS_QUICKADD = C_IS_QUICKADD
        Me.C_FORM_DANHSACH = C_FORM_DANHSACH
    End Sub
End Class
