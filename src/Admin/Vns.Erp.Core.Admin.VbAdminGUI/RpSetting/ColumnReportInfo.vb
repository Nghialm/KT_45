Public Class ColumnReportInfo
#Region "Variable"
    Private _COT_HIENTHI As String
    Private _TEN_HIENTHI As String

#End Region
#Region "Property"
    Public Property CotHienthi()
        Get
            Return _COT_HIENTHI
        End Get
        Set(ByVal value)
            _COT_HIENTHI = value
        End Set
    End Property
    Public Property TenHienThi()
        Get
            Return _TEN_HIENTHI
        End Get
        Set(ByVal value)
            _TEN_HIENTHI = value
        End Set
    End Property
#End Region
#Region "Init Class"
    Public Sub New()
    End Sub
    Public Sub New(ByVal COT_HIENTHI As String, ByVal TEN_HIENTHI As String)
        Me.CotHienthi = COT_HIENTHI
        Me.TenHienThi = TEN_HIENTHI
    End Sub
#End Region
End Class
