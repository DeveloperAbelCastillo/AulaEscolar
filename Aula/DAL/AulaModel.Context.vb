﻿'------------------------------------------------------------------------------
' <auto-generated>
'     Este código se generó a partir de una plantilla.
'
'     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
'     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Data.Entity
Imports System.Data.Entity.Infrastructure

Partial Public Class AulaEntities
    Inherits DbContext

    Public Sub New()
        MyBase.New("name=AulaEntities")
    End Sub

    Protected Overrides Sub OnModelCreating(modelBuilder As DbModelBuilder)
        Throw New UnintentionalCodeFirstException()
    End Sub

    Public Overridable Property Actividades() As DbSet(Of Actividades)
    Public Overridable Property Alumnos() As DbSet(Of Alumnos)
    Public Overridable Property Asistencias() As DbSet(Of Asistencias)
    Public Overridable Property Aulas() As DbSet(Of Aulas)
    Public Overridable Property FileStream() As DbSet(Of FileStream)
    Public Overridable Property Materias() As DbSet(Of Materias)
    Public Overridable Property TiposActividades() As DbSet(Of TiposActividades)
    Public Overridable Property Usuario() As DbSet(Of Usuario)
    Public Overridable Property Calificaciones() As DbSet(Of Calificaciones)
    Public Overridable Property DiasPeriodos() As DbSet(Of DiasPeriodos)
    Public Overridable Property Periodos() As DbSet(Of Periodos)
    Public Overridable Property Bitacora() As DbSet(Of Bitacora)
    Public Overridable Property NivelSeguridad() As DbSet(Of NivelSeguridad)

End Class
