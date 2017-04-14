Public Class PhanBoHelper
    Public Function PhanBo(ByVal lst_phanBo As List(Of PhanBoHelperInfo))
        Dim sum_st As Decimal = 0
        For Each obj As PhanBoHelperInfo In lst_phanBo
            sum_st = sum_st + obj.SO_TIEN
        Next
        For i As Integer = 0 To lst_phanBo.Count - 1
            If i < lst_phanBo.Count - 1 Then
                If lst_phanBo(i).HE_SO <> 0 And lst_phanBo(i).SO_TIEN = 0 Then
                    lst_phanBo(i).TIEN_PB = Math.Round(lst_phanBo(i).TONG_SO_TIEN * lst_phanBo(i).HE_SO / 100, 0)
                ElseIf lst_phanBo(i).SO_TIEN <> 0 Then
                    lst_phanBo(i).HE_SO = lst_phanBo(i).SO_TIEN / sum_st
                    lst_phanBo(i).TIEN_PB = Math.Round(lst_phanBo(i).TONG_SO_TIEN * lst_phanBo(i).HE_SO, 0)
                End If
            Else
                Dim Sum_st_pb As Decimal = 0
                For Each obj As PhanBoHelperInfo In lst_phanBo
                    If obj.THU_TU <> lst_phanBo(i).THU_TU Then
                        Sum_st_pb = Sum_st_pb + obj.TIEN_PB
                    End If
                Next
                lst_phanBo(i).TIEN_PB = lst_phanBo(i).TONG_SO_TIEN - Sum_st_pb
            End If
        Next
        Return lst_phanBo
    End Function
End Class

Public Class PhanBoHelperInfo

#Region "Private Variable"
    Private _TONG_SO_TIEN As Decimal
    Private _THU_TU As Decimal
    Private _HE_SO As Decimal
    Private _SO_TIEN As Decimal
    Private _TIEN_PB As Decimal

    Private _ID As String
#End Region

#Region "Property"
    Public Property TIEN_PB() As Decimal
        Get
            Return _TIEN_PB
        End Get
        Set(ByVal value As Decimal)
            _TIEN_PB = value
        End Set
    End Property

    Public Property SO_TIEN() As Decimal
        Get
            Return _SO_TIEN
        End Get
        Set(ByVal value As Decimal)
            _SO_TIEN = value
        End Set
    End Property


    Public Property HE_SO() As Decimal
        Get
            Return _HE_SO
        End Get
        Set(ByVal value As Decimal)
            _HE_SO = value
        End Set
    End Property

    Public Property THU_TU() As Decimal
        Get
            Return _THU_TU
        End Get
        Set(ByVal value As Decimal)
            _THU_TU = value
        End Set
    End Property

    Public Property TONG_SO_TIEN() As Decimal
        Get
            Return _TONG_SO_TIEN
        End Get
        Set(ByVal value As Decimal)
            _TONG_SO_TIEN = value
        End Set
    End Property

    Public Property ID() As String
        Get
            Return _ID
        End Get
        Set(ByVal value As String)
            _ID = value
        End Set
    End Property

#End Region

#Region "Init Class"

    Public Sub New()

    End Sub

    Public Sub New(ByVal TONG_SO_TIEN As Decimal, ByVal THU_TU As Decimal, ByVal HE_SO As Decimal, ByVal SO_TIEN As Decimal, ByVal TIEN_PB As Decimal, ByVal ID As String)
        Me.TONG_SO_TIEN = TONG_SO_TIEN
        Me.THU_TU = THU_TU
        Me.HE_SO = HE_SO
        Me.SO_TIEN = SO_TIEN
        Me.TIEN_PB = TIEN_PB
        Me.ID = ID
    End Sub
#End Region

End Class
