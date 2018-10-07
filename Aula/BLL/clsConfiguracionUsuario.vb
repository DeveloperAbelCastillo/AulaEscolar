Imports System.ServiceModel
Imports System.Transactions
Imports System.Windows.Forms
Imports DevExpress.XtraEditors

Public Class clsConfiguracionUsuario
    Public Function GetConfiguracionUsuario() As Usuario
        Dim result As New Usuario
        Try
            Cursor.Current = Cursors.WaitCursor
            Using db As New AulaEntities()
                result = db.Usuario.FirstOrDefault()
            End Using
        Catch p As FaultException
            XtraMessageBox.Show(p.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As TransactionAbortedException
            XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As ApplicationException
            XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Cursor.Current = Cursors.Default
        End Try
        Return result
    End Function

    Public Function SetConfiguracionUsuario(ByVal ConfiguracionUsuario As Usuario, ByVal MyFileInfo As MyFileInfo) As Boolean
        Dim result As Boolean = False
        Try
            Cursor.Current = Cursors.WaitCursor
            Using db As New AulaEntities()

                If Not MyFileInfo.StreamID.ToString = "00000000-0000-0000-0000-000000000000" Then
                    Dim Archivo = db.FileStream.Where(Function(x) x.StreamId = MyFileInfo.StreamID).FirstOrDefault

                    If Not IsNothing(Archivo) Then
                        With Archivo
                            .Descripcion = MyFileInfo.FileName
                            .Extencion = MyFileInfo.FileExtension
                            .FileData = MyFileInfo.BinaryBuffer
                        End With
                    Else
                        Archivo = New FileStream
                        With Archivo
                            .StreamId = MyFileInfo.StreamID
                            .Descripcion = MyFileInfo.FileName
                            .Extencion = MyFileInfo.FileExtension
                            .FileData = MyFileInfo.BinaryBuffer
                        End With
                    End If

                    Using xx As New GenericRepository(Of FileStream)(db)
                        xx.Save(Archivo)
                        db.SaveChanges()
                    End Using

                    With ConfiguracionUsuario
                        .Logo = Archivo.Id
                    End With
                End If

                Using xx As New GenericRepository(Of Usuario)(db)
                    xx.Save(ConfiguracionUsuario)
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
        Finally
            Cursor.Current = Cursors.Default
        End Try
        Return result
    End Function

    Public Function GetArchivo(ByVal IdArchivo As Integer) As MyFileInfo
        Dim result As New MyFileInfo
        Try
            Cursor.Current = Cursors.WaitCursor
            Using db As New AulaEntities()
                result = db.FileStream.Where(Function(x) x.Id = IdArchivo).Select(Function(x) New MyFileInfo With {
                                                                                    .StreamID = x.StreamId,
                                                                                    .FileName = x.Descripcion,
                                                                                    .FileExtension = x.Extencion,
                                                                                    .BinaryBuffer = x.FileData
                                                                                    }).FirstOrDefault
            End Using
        Catch p As FaultException
            XtraMessageBox.Show(p.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As TransactionAbortedException
            XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As ApplicationException
            XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Cursor.Current = Cursors.Default
        End Try
        Return result
    End Function
End Class
