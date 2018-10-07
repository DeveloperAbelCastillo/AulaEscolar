Imports System.Linq

Public Interface IGenericRepository(Of T As Class)
    Function GetAll() As List(Of T)
    Sub Save(Entity As T)
    Sub Delete(Entity As T)
End Interface
