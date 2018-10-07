Imports System.IO
Imports System.ServiceModel
Imports System.Transactions
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.DXErrorProvider

Public Class frmConfiguracionGeneral
#Region "Declaraciones"
    Dim clConfiguracion As New BLL.clsConfiguracionUsuario
    Dim Configuracion As Usuario
    Dim MyFile As MyFileInfo
#End Region
#Region "Carga Inicial"
    Private Sub frmConfiguracionGeneral_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Cursor.Current = Cursors.WaitCursor
            Me.AutoSizeMode = AutoSizeMode.GrowAndShrink
            Configuracion = clConfiguracion.GetConfiguracionUsuario()

            If Not IsNothing(Configuracion) Then
                With Configuracion
                    txtNombreUsuario.EditValue = .Nombre
                    txtPaternoUsuario.EditValue = .Paterno
                    txtMaternoUsuario.EditValue = .Materno
                    txtNombreEscuela.EditValue = .Escuela
                    txtDireccionEscuela.EditValue = .Direccion
                    txtTelefonoEscuela.EditValue = .Telefono
                    If .Logo > 0 Then
                        MyFile = clConfiguracion.GetArchivo(.Logo)
                        If Not IsNothing(MyFile) Then
                            'Dim FechaHora As String = Now.ToString("ddMMyyHHmmss")
                            Dim FileName As String = Path.GetTempPath() & Convert.ToString(MyFile.StreamID) & MyFile.FileExtension
                            If File.Exists(FileName) Then File.Delete(FileName)
                            File.WriteAllBytes(FileName, MyFile.BinaryBuffer)
                            txtRutaLogo.EditValue = FileName
                            peLogo.Image = Image.FromFile(FileName)
                            peLogo.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch
                        End If
                    Else
                        'Aqui cargamos el actual logo
                    End If
                End With
            End If
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
    End Sub
#End Region
#Region "Funcionalidad"
    Private Sub btnBuscarLogo_Click(sender As Object, e As EventArgs) Handles btnBuscaLogo.Click
        Try
            Cursor.Current = Cursors.WaitCursor
            OpenFileDialog.Filter = "Imagenes (*.jpg)|*.jpg"
            OpenFileDialog.Title = "Seleccione el logo de la escuela"
            OpenFileDialog.Multiselect = False
            If OpenFileDialog.ShowDialog() = DialogResult.OK Then
                Dim FileInfo As New FileInfo(OpenFileDialog.FileName)
                If FileInfo.Length < 1000000 Then
                    txtRutaLogo.EditValue = OpenFileDialog.FileName
                    peLogo.Image = Image.FromFile(OpenFileDialog.FileName)
                    peLogo.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch
                Else
                    XtraMessageBox.Show("La imagen supera el tamaño maximo de la imagen", "Tamaño Superado", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
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
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            Cursor.Current = Cursors.WaitCursor
            If DxValidationProvider1.Validate() Then
                If IsNothing(Configuracion) Then Configuracion = New Usuario
                With Configuracion
                    .Nombre = txtNombreUsuario.EditValue
                    .Paterno = txtPaternoUsuario.EditValue
                    .Materno = txtMaternoUsuario.EditValue
                    .Escuela = txtNombreEscuela.EditValue
                    .Direccion = txtDireccionEscuela.EditValue
                    .Telefono = txtTelefonoEscuela.EditValue
                    If Not String.IsNullOrWhiteSpace(txtRutaLogo.EditValue) Then
                        If File.Exists(txtRutaLogo.EditValue) Then
                            If IsNothing(MyFile) Then
                                MyFile = New MyFileInfo
                                MyFile.StreamID = Guid.NewGuid()
                            End If
                            With MyFile
                                .FileExtension = Path.GetExtension(txtRutaLogo.EditValue)
                                .FileName = Path.GetFileName(txtRutaLogo.EditValue)
                                .BinaryBuffer = File.ReadAllBytes(txtRutaLogo.EditValue)
                            End With
                        End If
                    Else
                        MyFile = New MyFileInfo
                    End If
                End With

                Dim result = clConfiguracion.SetConfiguracionUsuario(Configuracion, MyFile)

                If result Then
                    My.Settings.IdUsuario = clConfiguracion.GetConfiguracionUsuario.Id
                    XtraMessageBox.Show("Configuracion Guardada Correctamente", "Configuracion Guardada", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Dim f As FrmPrincipal = DirectCast(Me.MdiParent, FrmPrincipal)
                    f.RefrescarConfiguracion = 0
                End If

            End If
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
    End Sub

#End Region
#Region "Logica"

#End Region
#Region "Validaciones"
    Private Sub Validar(ByVal control As Control, ByVal regla As ConditionValidationRule)
        Try
            Cursor.Current = Cursors.WaitCursor
            DxValidationProvider1.ValidationMode = ValidationMode.Manual
            DxValidationProvider1.Validate(control)
            DxValidationProvider1.SetIconAlignment(control, ErrorIconAlignment.BottomRight)
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
    End Sub

    Private Sub VlidaControl_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtPaternoUsuario.Validating, txtNombreUsuario.Validating, txtNombreEscuela.Validating, txtMaternoUsuario.Validating
        Try
            Cursor.Current = Cursors.WaitCursor
            Dim regla As New ConditionValidationRule()
            With regla
                .ConditionOperator = ConditionOperator.IsNotBlank
                .ErrorText = "No puede quedar vacio"
                .ErrorType = ErrorType.Information
            End With
            DxValidationProvider1.SetValidationRule(sender, regla)
            Validar(sender, regla)
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
    End Sub

#End Region
End Class