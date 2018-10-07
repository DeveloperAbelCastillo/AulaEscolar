Imports DevExpress.Utils
Imports DevExpress.XtraEditors

Public Class frmCalificarTarea
    Dim clActividades As New clsActividades
    Dim clCalificaciones As New clsCalificaciones
    Dim clMateria As New clsMaterias
    Dim actividad As Actividades
    Dim calificaciones As List(Of dtoCalificaciones)
    Dim calificacion As dtoCalificaciones
    Dim calif As Calificaciones
    Dim materia As Materias

    Private xIdTarea As Integer = 0
    Public Property pTarea() As Integer
        Get
            Return xIdTarea
        End Get
        Set(ByVal value As Integer)
            xIdTarea = value
        End Set
    End Property

    Private Sub frmCalificarTarea_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.FormBorderStyle = FormBorderStyle.FixedSingle
        CargarCalificacion()
    End Sub

    Private Sub Limpiar()
        txtTemaTarea.EditValue = ""
        txtMateria.EditValue = ""
        gcAlumnos.DataSource = Nothing
    End Sub

    Private Sub gvAlumnos_CellValueChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles gvAlumnos.CellValueChanged
        calificacion = gvAlumnos.GetFocusedRow()
        calif = New Calificaciones
        With calif
            If Not IsNothing(calificacion.IdCalificacion) Then
                .IdCalificacion = calificacion.IdCalificacion
            End If
            .IdActividad = calificacion.IdActividad
            .IdAlumno = calificacion.IdAlumno
            .Calificacion = calificacion.Calificacion
        End With

        If Not IsNumeric(calif.Calificacion) Then
            XtraMessageBox.Show("La calificacion debe ser numerica.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            CargarCalificacion()
            Exit Sub
        End If

        If calif.Calificacion < 0 Or calif.Calificacion > 10 Then
            XtraMessageBox.Show("La calificacion no es un numero valido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            CargarCalificacion()
            Exit Sub
        End If

        Dim result = clCalificaciones.SetCalificacion(calif)

        If result Then
            CargarCalificacion()
        Else
            XtraMessageBox.Show("el alumno seleccionado ya cuenta con su asistencia para ese dia, favor de recargar le ventana", "error asistencia", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub CargarCalificacion()
        Limpiar()
        actividad = clActividades.GetActividad(xIdTarea)

        If IsNothing(actividad) Then
            XtraMessageBox.Show("La tarea no pudo ser encontrada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
        End If

        With actividad
            txtTemaTarea.EditValue = .Tema
            txtMateria.EditValue = clMateria.GetMateria(.IdMateria).Materia
        End With

        calificaciones = New List(Of dtoCalificaciones)
        calificaciones = clCalificaciones.GetActividadesCalificaciones(xIdTarea).ToList()

        For Each calificacion In calificaciones
            With calificacion
                .Nombre = SAL.Encriptador.DecryptString(.Nombre, My.Settings.Clave)
                .Paterno = SAL.Encriptador.DecryptString(.Paterno, My.Settings.Clave)
                .Materno = SAL.Encriptador.DecryptString(.Materno, My.Settings.Clave)
            End With
        Next

        gcAlumnos.DataSource = calificaciones
        gvAlumnos.Columns("IdAlumno").Visible = False
        gvAlumnos.Columns("IdAula").Visible = False
        gvAlumnos.Columns("IdCalificacion").Visible = False
        gvAlumnos.Columns("IdActividad").Visible = False
        gvAlumnos.Columns("Nombre").AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center
        gvAlumnos.Columns("Nombre").OptionsColumn.AllowEdit = False
        gvAlumnos.Columns("Nombre").AppearanceCell.TextOptions.HAlignment = HorzAlignment.Center
        gvAlumnos.Columns("Nombre").Caption = "NOMBRE"
        gvAlumnos.Columns("Paterno").AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center
        gvAlumnos.Columns("Paterno").AppearanceCell.TextOptions.HAlignment = HorzAlignment.Center
        gvAlumnos.Columns("Paterno").Caption = "PATERNO"
        gvAlumnos.Columns("Paterno").OptionsColumn.AllowEdit = False
        gvAlumnos.Columns("Materno").AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center
        gvAlumnos.Columns("Materno").AppearanceCell.TextOptions.HAlignment = HorzAlignment.Center
        gvAlumnos.Columns("Materno").Caption = "MATERNO"
        gvAlumnos.Columns("Materno").OptionsColumn.AllowEdit = False
        gvAlumnos.Columns("Calificacion").AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center
        gvAlumnos.Columns("Calificacion").AppearanceCell.TextOptions.HAlignment = HorzAlignment.Center
        gvAlumnos.Columns("Calificacion").Caption = "CALIFICACION"
    End Sub
End Class