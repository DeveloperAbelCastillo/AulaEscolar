Imports System.ServiceModel
Imports System.Transactions
Imports DevExpress.Utils
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.DXErrorProvider

Public Class frmAulaAlumnos_ListaAlumnos
#Region "Declaraciones"
    Dim cAlumnos As New clsAlumnos
    Dim AulaFormulario As Integer = 0
    Dim Alumnos As List(Of Alumnos)
    Dim Alumno As Alumnos
    Dim TipoProceso As Proceso

    Private Enum Proceso
        agregar
        editar
        eliminar
    End Enum

    Private Function RecuperaProceso() As String
        Dim res As String = ""
        Try
            Cursor.Current = Cursors.WaitCursor
            Select Case TipoProceso
                Case Proceso.agregar
                    res = "Agregado"
                Case Proceso.editar
                    res = "Actualizado"
                Case Proceso.eliminar
                    res = "Eliminado"
            End Select
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
        Return res
    End Function
#End Region
#Region "Funcionalidad"
    Private Sub CargaAlumos()
        Try
            Cursor.Current = Cursors.WaitCursor
            Alumnos = cAlumnos.GetAlumnosAula(My.Settings.IdAulaActual)
            gvAlumnos.OptionsBehavior.Editable = False
            gvAlumnos.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus
            gvAlumnos.OptionsView.ShowGroupPanel = False
            If Alumnos.Count > 0 Then
                For Each Alumno In Alumnos
                    With Alumno
                        .Nombre = SAL.Encriptador.DecryptString(.Nombre, My.Settings.Clave)
                        .Paterno = SAL.Encriptador.DecryptString(.Paterno, My.Settings.Clave)
                        .Materno = SAL.Encriptador.DecryptString(.Materno, My.Settings.Clave)
                    End With
                Next
                Using db As New AulaEntities()
                    gcAlumnos.DataSource = Alumnos
                End Using
                gvAlumnos.Columns("IdAlumno").Visible = False
                gvAlumnos.Columns("IdAula").Visible = False
                gvAlumnos.Columns("Nombre").AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center
                gvAlumnos.Columns("Nombre").AppearanceCell.TextOptions.HAlignment = HorzAlignment.Center
                gvAlumnos.Columns("Nombre").Caption = "NOMBRE"
                gvAlumnos.Columns("Paterno").AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center
                gvAlumnos.Columns("Paterno").AppearanceCell.TextOptions.HAlignment = HorzAlignment.Center
                gvAlumnos.Columns("Paterno").Caption = "PATERNO"
                gvAlumnos.Columns("Materno").AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center
                gvAlumnos.Columns("Materno").AppearanceCell.TextOptions.HAlignment = HorzAlignment.Center
                gvAlumnos.Columns("Materno").Caption = "MATERNO"
            Else
                gcAlumnos.DataSource = Nothing
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

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs)
        Try
            Cursor.Current = Cursors.WaitCursor
            Limpiar()
            txtNombre.Focus()
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
            If TipoProceso = Proceso.agregar Then
                If DxValidationProvider1.Validate() Then
                    Alumno = New Alumnos
                    With Alumno
                        .Nombre = SAL.Encriptador.EncryptString(txtNombre.EditValue, My.Settings.Clave)
                        .Paterno = SAL.Encriptador.EncryptString(txtPaterno.EditValue, My.Settings.Clave)
                        .Materno = SAL.Encriptador.EncryptString(txtMaterno.EditValue, My.Settings.Clave)
                        .IdAula = My.Settings.IdAulaActual
                        For Each Item In Alumnos
                            If Item.Nombre = .Nombre AndAlso Item.Paterno = .Paterno AndAlso Item.Materno = .Materno Then
                                XtraMessageBox.Show("El alumno que se intenta agregar ya existe", "Alumno Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                Exit Sub
                            End If
                        Next
                    End With

                    Dim result = cAlumnos.SetAlumno(Alumno)
                    If result Then
                        CargaAlumos()
                        fpAcciones.HidePopup()
                        Limpiar()
                        BarraAcciones1.pProceso = RecuperaProceso()
                    End If
                End If
            Else
                If DxValidationProvider1.Validate() Then
                    With Alumno
                        .Nombre = SAL.Encriptador.EncryptString(txtNombre.EditValue, My.Settings.Clave)
                        .Paterno = SAL.Encriptador.EncryptString(txtPaterno.EditValue, My.Settings.Clave)
                        .Materno = SAL.Encriptador.EncryptString(txtMaterno.EditValue, My.Settings.Clave)
                        For Each Item In Alumnos
                            If Item.Nombre = .Nombre AndAlso Item.Paterno = .Paterno AndAlso Item.Materno = .Materno AndAlso Alumno.IdAlumno <> .IdAlumno Then
                                XtraMessageBox.Show("El alumno que se intenta modificar ya existe", "Alumno Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                Exit Sub
                            End If
                        Next
                    End With

                    Dim result = cAlumnos.SetAlumno(Alumno)
                    If result Then
                        CargaAlumos()
                        fpAcciones.HidePopup()
                        Limpiar()
                        BarraAcciones1.pProceso = RecuperaProceso()
                    End If
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

    Private Sub Limpiar()
        txtNombre.EditValue = ""
        txtPaterno.EditValue = ""
        txtMaterno.EditValue = ""
    End Sub
#End Region
#Region "Logica"

#End Region
#Region "Validaciones"
    Private Sub frmAulaAlumnos_ListaAlumnos_Enter(sender As Object, e As EventArgs) Handles MyBase.Enter
        Try
            Cursor.Current = Cursors.WaitCursor
            If AulaFormulario <> My.Settings.IdAulaActual Then
                AulaFormulario = My.Settings.IdAulaActual
                CargaAlumos()
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

    Private Sub VlidaControl_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtNombre.Validating, txtPaterno.Validating, txtMaterno.Validating
        Try
            Cursor.Current = Cursors.WaitCursor
            Dim regla As New ConditionValidationRule()
            With regla
                .ConditionOperator = ConditionOperator.IsNotBlank
                .ErrorText = "No puede quedar vacio"
                .ErrorType = ErrorType.Critical
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

    Private Sub BarraAcciones1_eAgregar() Handles BarraAcciones1.eAgregar
        gpoAccion.Text = "Agregar Alumno"
        btnGuardar.Text = "Guardar"
        TipoProceso = Proceso.agregar
        fpAcciones.ShowPopup()
    End Sub

    Private Sub BarraAcciones1_eEditar() Handles BarraAcciones1.eEditar
        Alumno = gvAlumnos.GetRow(gvAlumnos.GetSelectedRows().FirstOrDefault)
        If Not IsNothing(Alumno) Then
            With Alumno
                txtNombre.EditValue = SAL.Encriptador.DecryptString(.Nombre, My.Settings.Clave)
                txtPaterno.EditValue = SAL.Encriptador.DecryptString(.Paterno, My.Settings.Clave)
                txtMaterno.EditValue = SAL.Encriptador.DecryptString(.Materno, My.Settings.Clave)
            End With
            gpoAccion.Text = "Actualizar Alumno"
            btnGuardar.Text = "Actualizar"
            TipoProceso = Proceso.editar
            fpAcciones.ShowPopup()
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        fpAcciones.HidePopup()
        TipoProceso = Nothing
    End Sub

End Class