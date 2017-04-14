Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports Vns.Erp.Core.Domain
Imports System.IO
Imports System.Collections

Public Class SerializerUtil
    Public Shared Sub writeObject(list As IList, filePath As String)
        Using stream As Stream = File.Open(filePath, FileMode.Create)
            Dim bformatter = New System.Runtime.Serialization.Formatters.Binary.BinaryFormatter()
            bformatter.Serialize(stream, list)
        End Using
    End Sub
    Public Shared Function readObject(filePath As [String]) As IList
        Using stream As Stream = File.Open(filePath, FileMode.Open)
            Dim bformatter = New System.Runtime.Serialization.Formatters.Binary.BinaryFormatter()
            Dim listAll As IList = DirectCast(bformatter.Deserialize(stream), IList)
            Return listAll
        End Using
    End Function

    'Public Shared Sub writeEncounter(list As IList(Of Encounter), filePath As String)
    '    Using stream As Stream = File.Open(filePath, FileMode.Create)
    '        Dim bformatter = New System.Runtime.Serialization.Formatters.Binary.BinaryFormatter()
    '        bformatter.Serialize(stream, list)
    '    End Using
    'End Sub
    'Public Shared Function readEncounter(filePath As [String]) As IList(Of Encounter)
    '    Using stream As Stream = File.Open(filePath, FileMode.Open)
    '        Dim bformatter = New System.Runtime.Serialization.Formatters.Binary.BinaryFormatter()
    '        Dim listAll As IList(Of Encounter) = DirectCast(bformatter.Deserialize(stream), IList(Of Encounter))
    '        Return listAll
    '    End Using
    'End Function
    'Public Shared Sub writePatient(list As IList(Of Patient), filePath As String)
    '    Using stream As Stream = File.Open(filePath, FileMode.Create)
    '        Dim bformatter = New System.Runtime.Serialization.Formatters.Binary.BinaryFormatter()
    '        bformatter.Serialize(stream, list)
    '    End Using
    'End Sub
    'Public Shared Function readPatient(filePath As [String]) As IList(Of Patient)
    '    Using stream As Stream = File.Open(filePath, FileMode.Open)
    '        Dim bformatter = New System.Runtime.Serialization.Formatters.Binary.BinaryFormatter()
    '        Dim listAll As IList(Of Patient) = DirectCast(bformatter.Deserialize(stream), IList(Of Patient))
    '        Return listAll
    '    End Using
    'End Function
End Class