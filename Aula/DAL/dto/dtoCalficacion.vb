Imports System.Runtime.Serialization

<DataContract>
Public Class dtoCalificaciones
    <DataMember> Public Property IdAlumno As Integer?
    <DataMember> Public Property Nombre As String
    <DataMember> Public Property Paterno As String
    <DataMember> Public Property Materno As String
    <DataMember> Public Property IdAula As Integer?
    <DataMember> Public Property IdCalificacion As Integer?
    <DataMember> Public Property IdActividad As Integer?
    <DataMember> Public Property Calificacion As Decimal?
End Class
