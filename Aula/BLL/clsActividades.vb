Imports System.ServiceModel
Imports System.Transactions
Imports System.Windows.Forms
Imports DevExpress.XtraEditors

Public Class clsActividades
    Public Function GetActividades(ByVal pIdAula As Integer) As List(Of Actividades)
        Dim result As New List(Of Actividades)
        Try
            Using db As New AulaEntities()
                result = (From t In db.Actividades
                          Join m In db.Materias On m.IdMateria Equals t.IdMateria
                          Where m.IdAula = pIdAula
                          Select t).ToList()
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

    Public Function GetActividad(ByVal pIdTarea As Integer) As Actividades
        Dim result As New Actividades
        Try
            Using db As New AulaEntities()
                result = db.Actividades.Where(Function(x) x.IdTarea = pIdTarea).FirstOrDefault
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

    Public Function GetActividad(ByVal pIdTarea As Integer, ByVal pIdAula As Integer) As Actividades
        Dim result As New Actividades
        Try
            Using db As New AulaEntities()
                result = db.Actividades.Where(Function(x) x.IdTarea = pIdTarea).FirstOrDefault
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

    Public Function SetActividad(ByVal pTarea As Actividades) As Boolean
        Dim result As Boolean = False
        Try
            Using db As New AulaEntities()
                Using xx As New GenericRepository(Of Actividades)(db)
                    xx.Save(pTarea)
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

    Public Function TieneActvidades(ByVal pFecha As Date) As Boolean
        Dim result As Boolean = False
        Try
            Using db As New AulaEntities()
                If db.Actividades.Where(Function(x) CDate(x.FechaEntrega) = pFecha).Count > 0 Then
                    result = True
                End If
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
