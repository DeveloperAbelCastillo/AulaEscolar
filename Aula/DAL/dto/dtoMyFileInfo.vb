Imports System.Runtime.Serialization

<DataContract>
Public Class MyFileInfo
    <DataMember> Public Property BinaryBuffer As Byte()
    <DataMember> Public Property FileExtension As String
    <DataMember> Public Property FileName As String
    <DataMember> Public Property StreamID As Guid
End Class
