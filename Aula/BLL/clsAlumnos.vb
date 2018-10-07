Imports System.ServiceModel
Imports System.Transactions
Imports System.Windows.Forms
Imports DevExpress.XtraEditors

Public Class clsAlumnos
    Public Function GetAlumnosAula(ByVal pIdAula As Integer) As List(Of Alumnos)
        Dim result As New List(Of Alumnos)
        Try
            Using db As New AulaEntities()
                result = db.Alumnos.Where(Function(x) x.IdAula = pIdAula).ToList
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

    Public Function SetAlumno(ByVal pxAlumno As Alumnos) As Boolean
        Dim result As Boolean = False
        Try
            Using db As New AulaEntities()
                Using xx As New GenericRepository(Of Alumnos)(db)
                    xx.Save(pxAlumno)
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

    Public Function GetAsistencia(ByVal pxIdAula As Integer, ByVal pxFecha As Date) As List(Of Alumnos)
        Dim result As New List(Of Alumnos)
        Try
            Using db As New AulaEntities()
                Dim Asisntecias = db.Asistencias.Where(Function(x) x.IdAula = pxIdAula And x.FechaAsistencia = pxFecha).Select(Function(x) x.IdAlumno).ToList
                result = db.Alumnos.Where(Function(x) Not Asisntecias.Contains(x.IdAlumno) And x.IdAula = pxIdAula).ToList
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

    Public Function SetAsistencia(ByVal pxAsistencia As Asistencias) As Boolean
        Dim result As Boolean = False
        Try
            Using db As New AulaEntities()

                Dim Asistencia = db.Asistencias.Where(Function(x) x.IdAlumno = pxAsistencia.IdAlumno _
                                                     And x.IdAula = pxAsistencia.IdAula _
                                                     And x.FechaAsistencia = pxAsistencia.FechaAsistencia).FirstOrDefault()

                If Asistencia Is Nothing Then
                    Asistencia = New Asistencias
                    With Asistencia
                        .IdAlumno = pxAsistencia.IdAlumno
                        .IdAula = pxAsistencia.IdAula
                        .FechaAsistencia = pxAsistencia.FechaAsistencia
                    End With

                    Using xx As New GenericRepository(Of Asistencias)(db)
                        xx.Save(Asistencia)
                        db.SaveChanges()
                        result = True
                    End Using
                Else
                    Return False
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
