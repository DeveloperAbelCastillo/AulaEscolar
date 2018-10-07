Imports System.ServiceModel
Imports System.Transactions
Imports DevExpress.Utils
Imports DevExpress.XtraEditors

Public Class frmAulaAlumnos_PaseLista
#Region "Declaraciones"
    Dim AulaFormulario As Integer = 0
    Dim cAlumnos As New clsAlumnos
    Dim Alumnos As List(Of Alumnos)
#End Region
#Region "Carga Inicial"
    Private Sub frmAulaAlumnos_PaseLista_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.AutoSizeMode = AutoSizeMode.GrowAndShrink
            Cursor.Current = Cursors.WaitCursor
            AulaFormulario = My.Settings.IdAulaActual
            deFecha.EditValue = Date.Today
            CargaAlumnos()
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
    Private Sub CargaAlumnos()
        Try
            Cursor.Current = Cursors.WaitCursor
            Alumnos = cAlumnos.GetAsistencia(My.Settings.IdAulaActual, deFecha.EditValue)
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
                gcAlumnos.DataSource = Alumnos
                gvAlumnos.Columns("IdAlumno").Visible = False
                gvAlumnos.Columns("IdAula").Visible = False
                gvAlumnos.Columns("Nombre").AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center
                gvAlumnos.Columns("Nombre").AppearanceCell.TextOptions.HAlignment = HorzAlignment.Near
                gvAlumnos.Columns("Nombre").Caption = "NOMBRE"
                gvAlumnos.Columns("Paterno").AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center
                gvAlumnos.Columns("Paterno").AppearanceCell.TextOptions.HAlignment = HorzAlignment.Near
                gvAlumnos.Columns("Paterno").Caption = "PATERNO"
                gvAlumnos.Columns("Materno").AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center
                gvAlumnos.Columns("Materno").AppearanceCell.TextOptions.HAlignment = HorzAlignment.Near
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

#End Region
#Region "Logica"

#End Region
#Region "Validaciones"
    Private Sub frmAulaAlumnos_PaseLista_Enter(sender As Object, e As EventArgs) Handles MyBase.Enter
        Try
            Cursor.Current = Cursors.WaitCursor
            If AulaFormulario <> My.Settings.IdAulaActual Then
                AulaFormulario = My.Settings.IdAulaActual
                CargaAlumnos()
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

    Private Sub gvAlumnos_DoubleClick(sender As Object, e As EventArgs) Handles gvAlumnos.DoubleClick
        Dim Alumno As New Alumnos
        Alumno = gvAlumnos.GetFocusedRow()
        Dim Asistencia As New Asistencias
        With Asistencia
            .IdAlumno = Alumno.IdAlumno
            .IdAula = Alumno.IdAula
            .FechaAsistencia = deFecha.EditValue
        End With
        Dim result = cAlumnos.SetAsistencia(Asistencia)

        If result Then
            CargaAlumnos()
        Else
            XtraMessageBox.Show("El Alumno seleccionado ya cuenta con su asistencia para ese dia, favor de recargar le ventana", "Error Asistencia", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub deFecha_Validated(sender As Object, e As EventArgs) Handles deFecha.Validated
        CargaAlumnos()
    End Sub

#End Region
End Class