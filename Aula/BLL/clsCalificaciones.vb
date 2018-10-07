Imports System.ServiceModel
Imports System.Transactions
Imports System.Windows.Forms
Imports DevExpress.XtraEditors

Public Class clsCalificaciones
    Public Function GetActividadesCalificaciones(ByVal pIdTarea As Integer) As List(Of dtoCalificaciones)
        Dim result As New List(Of dtoCalificaciones)
        Try
            Using db As New AulaEntities()
                result = (From a In db.Alumnos
                          Join b In db.Materias On b.IdAula Equals a.IdAula
                          Join c In db.Actividades.Where(Function(x) x.IdTarea = pIdTarea) On c.IdMateria Equals b.IdMateria
                          Group Join d In db.Calificaciones On d.IdActividad Equals c.IdTarea And d.IdAlumno Equals a.IdAlumno Into da = Group
                          From d In da.DefaultIfEmpty()
                          Select New dtoCalificaciones With {
                              .IdAlumno = a.IdAlumno,
                              .Nombre = a.Nombre,
                              .Paterno = a.Paterno,
                              .Materno = a.Materno,
                              .IdAula = a.IdAula,
                              .IdCalificacion = d.IdCalificacion,
                              .IdActividad = c.IdTarea,
                              .Calificacion = d.Calificacion}
                          ).ToList
            End Using
        Catch p As FaultException
            XtraMessageBox.Show(p.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As TransactionAbortedException
            XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As ApplicationException
            XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return result
    End Function

    Public Function SetCalificacion(ByVal pCalificacion As Calificaciones) As Boolean
        Dim result As Boolean = False
        Try
            Using db As New AulaEntities()
                Using xx As New GenericRepository(Of Calificaciones)(db)
                    xx.Save(pCalificacion)
                    db.SaveChanges()
                End Using
                result = True
            End Using
        Catch p As FaultException
            XtraMessageBox.Show(p.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As TransactionAbortedException
            XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As ApplicationException
            XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return result
    End Function
End Class
