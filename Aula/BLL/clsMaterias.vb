Imports System.ServiceModel
Imports System.Transactions
Imports System.Windows.Forms
Imports DevExpress.XtraEditors

Public Class clsMaterias
    Public Function GetMaterias(ByVal IdAula As Integer) As List(Of Materias)
        Dim result As New List(Of Materias)
        Try
            Using db As New AulaEntities()
                result = db.Materias.Where(Function(x) x.IdAula = IdAula).ToList
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

    Public Function SetMateria(ByVal MateriaNva As Materias) As Boolean
        Dim result As Boolean = False
        Try
            Using db As New AulaEntities()
                Using xx As New GenericRepository(Of Materias)(db)
                    xx.Save(MateriaNva)
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

    Public Function GetMateriaColor(ByVal pIdMateria As Integer) As String
        Dim result As String = ""
        Try
            Using db As New AulaEntities()
                result = db.Materias.Where(Function(x) x.IdMateria = pIdMateria).Select(Function(x) x.ColorRGB).FirstOrDefault
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

    Public Function GetMateria(ByVal pIdMateria As Integer) As Materias
        Dim result As New Materias
        Try
            Using db As New AulaEntities()
                result = db.Materias.Where(Function(x) x.IdMateria = pIdMateria).FirstOrDefault
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
