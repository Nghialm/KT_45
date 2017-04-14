Imports System.Reflection
Imports Spring.Context.Support
Imports Spring.Context

Public Class ObjectFactory
    Private Shared _appContext As IApplicationContext = Nothing

    Public Shared ReadOnly Property AppContext() As IApplicationContext
        Get
            If _appContext Is Nothing Then
                _appContext = ContextRegistry.GetContext()
            End If
            Return _appContext
        End Get
    End Property

    Public Shared Function GetObject(objectid As String) As Object
        Return AppContext.GetObject(objectid)
    End Function

    Public Shared Function GetObject(ByVal objectid As String, ByVal argument As Object) As Object
        Dim arr() As Object = {argument}
        Return AppContext.GetObject(objectid, arr)
    End Function

    Public Shared Function GetObject(ByVal objectid As String, ByVal arguments() As Object) As Object
        Return AppContext.GetObject(objectid, arguments)
    End Function

    ''' <summary>
    ''' Returns an Object with the specified Type and whose value is equivalent to the specified object.
    ''' </summary>
    ''' <param name="value">An Object that implements the IConvertible interface.</param>
    ''' <param name="conversionType">The Type to which value is to be converted.</param>
    ''' <returns>An object whose Type is conversionType (or conversionType's underlying type if conversionType
    ''' is Nullable&lt;&gt;) and whose value is equivalent to value. -or- a null reference, if value is a null
    ''' reference and conversionType is not a value type.</returns>
    ''' <remarks>
    ''' This method exists as a workaround to System.Convert.ChangeType(Object, Type) which does not handle
    ''' nullables as of version 2.0 (2.0.50727.42) of the .NET Framework. The idea is that this method will
    ''' be deleted once Convert.ChangeType is updated in a future version of the .NET Framework to handle
    ''' nullable types, so we want this to behave as closely to Convert.ChangeType as possible.
    ''' This method was written by Peter Johnson at:
    ''' http://aspalliance.com/author.aspx?uId=1026.
    ''' </remarks>
    Public Shared Function ChangeType(value As Object, conversionType As Type) As Object
        ' Note: This if block was taken from Convert.ChangeType as is, and is needed here since we're
        ' checking properties on conversionType below.
        If conversionType Is Nothing Then
            Throw New ArgumentNullException("conversionType")
        End If
        ' end if
        ' If it's not a nullable type, just pass through the parameters to Convert.ChangeType

        If conversionType.IsGenericType AndAlso conversionType.GetGenericTypeDefinition().Equals(GetType(Nullable(Of ))) Then
            ' It's a nullable type, so instead of calling Convert.ChangeType directly which would throw a
            ' InvalidCastException (per http://weblogs.asp.net/pjohnson/archive/2006/02/07/437631.aspx),
            ' determine what the underlying type is
            ' If it's null, it won't convert to the underlying type, but that's fine since nulls don't really
            ' have a type--so just return null
            ' Note: We only do this check if we're converting to a nullable type, since doing it outside
            ' would diverge from Convert.ChangeType's behavior, which throws an InvalidCastException if
            ' value is null and conversionType is a value type.
            If value Is Nothing Then
                Return Nothing
            End If
            ' end if
            ' It's a nullable type, and not null, so that means it can be converted to its underlying type,
            ' so overwrite the passed-in conversion type with this underlying type
            'NullableConverter nullableConverter = new NullableConverter(conversionType);
            'conversionType = nullableConverter.UnderlyingType;
            conversionType = Nullable.GetUnderlyingType(conversionType)
        End If
        ' end if
        ' Now that we've guaranteed conversionType is something Convert.ChangeType can handle (i.e. not a
        ' nullable type), pass the call on to Convert.ChangeType
        Return Convert.ChangeType(value, conversionType)
    End Function

    Public Shared Sub MemberwiseCopy(objTo As Object, objFrom As Object, propInfos As ICollection(Of PropertyInfo))
        Dim props As ICollection(Of PropertyInfo) = propInfos
        If props Is Nothing Then
            Dim type As Type = objFrom.[GetType]()
            props = type.GetProperties()
        End If
        For Each prop As PropertyInfo In props
            If prop.CanRead AndAlso prop.CanWrite Then
                prop.SetValue(objTo, prop.GetValue(objFrom, Nothing), Nothing)
            End If
        Next
    End Sub
End Class
