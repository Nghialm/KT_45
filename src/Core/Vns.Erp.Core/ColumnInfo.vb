Imports System.Collections.Generic
Imports System.Linq
Imports System.Text


Public Class ColumnInfo
    Public Sub New(ByVal fieldname__1 As String, ByVal caption__2 As String, ByVal width__3 As Integer, ByVal _readonly As Boolean, ByVal _DisplayFormat As String)
        FieldName = fieldname__1
        Caption = caption__2
        Width = width__3
        [ReadOnly] = _readonly
        DisplayFormat = _DisplayFormat
    End Sub
    Private _FieldName As String
    Public Property FieldName() As String
        Get
            Return _FieldName
        End Get
        Set(ByVal value As String)
            _FieldName = value
        End Set
    End Property
    Private _Caption As String
    Public Property Caption() As String
        Get
            Return _Caption
        End Get
        Set(ByVal value As String)
            _Caption = value
        End Set
    End Property
    Private _Width As Integer
    Public Property Width() As Integer
        Get
            Return _Width
        End Get
        Set(ByVal value As Integer)
            _Width = value
        End Set
    End Property
    Private _DisplayFormat As String
    Public Property DisplayFormat() As String
        Get
            Return _DisplayFormat
        End Get
        Set(ByVal value As String)
            _DisplayFormat = value
        End Set
    End Property
    Private _ReadOnly As Boolean
    Public Property [ReadOnly]() As Boolean
        Get
            Return _ReadOnly
        End Get
        Set(ByVal value As Boolean)
            _ReadOnly = value
        End Set
    End Property

    '--------
    Private _Visible As Boolean = True
    Public Property Visible() As Boolean
        Get
            Return _Visible
        End Get
        Set(ByVal value As Boolean)
            _Visible = value
        End Set
    End Property
    '   string _CaptionAlign;
    '  string _Align;
    '  string _Fix;
    Private _OverwriteExist As Boolean = False

    Public Property OverwriteExist() As Boolean
        Get
            Return _OverwriteExist
        End Get
        Set(ByVal value As Boolean)
            _OverwriteExist = value
        End Set
    End Property
End Class

