Imports System.Data.Entity
Imports System.Data.Entity.Core.Objects
Imports System.Data.Entity.Infrastructure

Public Class GenericRepository(Of T As Class)
    Implements IGenericRepository(Of T)
    Implements IDisposable

    Sub New()
    End Sub

    Private m_dbContext As AulaEntities
    Protected Property DBContext() As AulaEntities
        Get
            Return m_dbContext
        End Get
        Set(ByVal value As AulaEntities)
            m_dbContext = value
        End Set
    End Property

    Private m_dbSet As DbSet
    Public Property DbSet() As DbSet
        Get
            Return m_dbSet
        End Get
        Set(ByVal value As DbSet)
            m_dbSet = value
        End Set
    End Property

    Dim tmpContext As AulaEntities
    Public Sub New(dbContext1 As AulaEntities)
        If dbContext1 Is Nothing Then
            Throw New NullReferenceException("dbContext")
        End If
        tmpContext = DBContext
        DBContext = dbContext1
        DbSet = DBContext.Set(Of T)()
    End Sub

    Private Function GetKeyNames(context As DbContext) As String()
        Dim objectSet As ObjectSet(Of T) = DirectCast(context, IObjectContextAdapter).ObjectContext.CreateObjectSet(Of T)()
        Dim keyNames As String() = objectSet.EntitySet.ElementType.KeyMembers.[Select](Function(k) k.Name).ToArray()
        Return keyNames
    End Function

    Private Function GetKeys(entity As T, context As DbContext) As Object()
        Dim keyNames = GetKeyNames(context)
        Dim type As Type = GetType(T)

        Dim keys As Object() = New Object(keyNames.Length - 1) {}
        For i As Integer = 0 To keyNames.Length - 1
            keys(i) = type.GetProperty(keyNames(i)).GetValue(entity, Nothing)
        Next
        Return keys
    End Function

    Public Sub Save(Entity As T) Implements IGenericRepository(Of T).Save
        Dim P = DbSet.Find(GetKeys(Entity, DBContext))
        If P Is Nothing Then
            DbSet.Add(Entity)
        Else
            Dim entry = DBContext.Entry(P)
            entry.CurrentValues.SetValues(Entity)
        End If
    End Sub

    Public Sub Delete(Entity As T) Implements IGenericRepository(Of T).Delete
        Dim entry = DBContext.Entry(Entity)
        DbSet.Attach(Entity)
        entry.State = EntityState.Deleted
    End Sub

    Public Function GetAll() As List(Of T) Implements IGenericRepository(Of T).GetAll
        Return DBContext.[Set](Of T)().ToList()
    End Function

#Region "IDisposable Support"
    Private disposedValue As Boolean ' Para detectar llamadas redundantes

    ' IDisposable
    Protected Overridable Sub Dispose(disposing As Boolean)
        If Not disposedValue Then
            If disposing Then
            End If

        End If
        disposedValue = True
    End Sub

    ' Visual Basic agrega este código para implementar correctamente el patrón descartable.
    Public Sub Dispose() Implements IDisposable.Dispose
        ' No cambie este código. Coloque el código de limpieza en el anterior Dispose(disposing As Boolean).
        Dispose(True)
        GC.SuppressFinalize(Me)
    End Sub
#End Region
End Class
