Imports System.ServiceModel
Imports System.Transactions
Imports System.Windows.Forms
Imports DevExpress.XtraEditors

Public Class clsNiveleSeguridad
    Public Function GetNivelesSeguridad() As List(Of NivelSeguridad)
        Dim result As New List(Of NivelSeguridad)
        Try
            Using db As New AulaEntities()
                result = db.NivelSeguridad.ToList
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

    Public Function ValidaSeguridad(ByVal pIdNivelSeguridad As Integer, ByVal pClave As String) As Boolean
        Dim result As Boolean = False
        Try
            Using db As New AulaEntities()
                Dim a As New NivelSeguridad
                a = db.NivelSeguridad.Where(Function(x) x.IdNivelSeguridad = pIdNivelSeguridad And x.Clave = pClave).FirstOrDefault()

                If Not IsNothing(a) Then
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

    Public Function SetNivelSeguridad(ByVal pNivelSeguridad As NivelSeguridad) As Boolean
        Dim result As Boolean = False
        Try
            Using db As New AulaEntities()
                Using xx As New GenericRepository(Of NivelSeguridad)(db)
                    xx.Save(pNivelSeguridad)
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
