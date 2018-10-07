Imports System.ServiceModel
Imports System.Transactions
Imports DevExpress.XtraBars
Imports DevExpress.XtraEditors
Imports DevExpress.XtraScheduler
Imports DevExpress.XtraScheduler.Drawing
Imports DevExpress.XtraSplashScreen

Public Class frm_Actividades_Tareas_Calendario
#Region "Declaraciones"
    Dim cActividades As New clsActividades
    Dim cMateria As New clsMaterias
    Dim Actividades As List(Of Actividades)
    Dim AulaFormulario As Integer = 0
#End Region
#Region "Carga Inicial"
    Private Sub frm_Actividades_Tareas_Tareas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Deshabilitamos todos los contrales predefinidos del Calendario
        Calendario.OptionsCustomization.AllowInplaceEditor = UsedAppointmentType.None
        Calendario.ActiveViewType = SchedulerViewType.Day
        Calendario.OptionsCustomization.AllowAppointmentMultiSelect = False
        Calendario.OptionsCustomization.AllowAppointmentDrag = False
        Calendario.OptionsCustomization.AllowAppointmentDragBetweenResources = False
        Calendario.OptionsCustomization.AllowAppointmentResize = False
        Calendario.OptionsBehavior.SelectOnRightClick = True
        SchedulerStorage1.Appointments.CustomFieldMappings.Add(New AppointmentCustomFieldMapping("IdTipoActividad", "CustomField1"))
        SchedulerStorage1.Appointments.CustomFieldMappings.Add(New AppointmentCustomFieldMapping("IdMateria", "CustomField2"))

        Calendario.Start = Date.Today
        'Cargamos el aulaFormulario
        AulaFormulario = My.Settings.IdAulaActual
        'Cargamos todas las tareas
        'SplashScreenManager1.ShowWaitForm()
        'SplashScreenManager1.ShowForm(GetType(WaitForm1))
        CargaTareas()
        'SplashScreenManager1.CloseForm()
        'SplashScreenManager1.CloseWaitForm()
    End Sub
#End Region
#Region "Funcionalidad"

#End Region
#Region "Logica"
    Private Sub CargaTareas()
        SchedulerStorage1.Appointments.Clear()
        Actividades = New List(Of Actividades)
        Actividades = cActividades.GetActividades(AulaFormulario)

        If Actividades.Count > 0 Then
            SchedulerStorage1.Appointments.Labels.Clear()
            'Dim statusColl As AppointmentStatusCollection = scheduler.Storage.Appointments.Statuses
            'statusColl.Clear()
            For Each tarea In Actividades
                With tarea
                    ' Add an appointment.
                    Dim apt As Appointment = SchedulerStorage1.CreateAppointment(AppointmentType.Normal)
                    apt.Start = .FechaEntrega
                    apt.End = .TiempoRevision
                    apt.Subject = .Tema
                    apt.Description = .Descripcion
                    apt.AllDay = False
                    apt.LabelKey = .IdTarea
                    apt.CustomFields("IdTipoActividad") = .IdTipoActividad
                    apt.CustomFields("IdMateria") = .IdMateria
                    'apt.ResourceId = .TipoActividad
                    'apt.Location = Data.Scene
                    'apt.ResourceId = cell.Resource.Id
                    'apt.CustomFields("CustomField1") = Data.RunNumber
                    SchedulerStorage1.Appointments.Add(apt)
                    Dim label As AppointmentLabel = SchedulerStorage1.Appointments.Labels.CreateNewLabel(apt.LabelKey, apt.Subject)
                    label.Color = ValidaColor(cMateria.GetMateriaColor(.IdMateria))
                    label.DisplayName = "Hola Mundo"

                    SchedulerStorage1.Appointments.Labels.Add(label)
                    'Dim status As AppointmentStatus = statusColl.CreateNewStatus(apt.LabelKey, apt.Subject)
                    'statusColl.Add(status)
                End With
            Next
            'SetupLabels(SchedulerStorage1)
        End If
    End Sub

    Private Sub Calendario_AppointmentViewInfoCustomizing(sender As Object, e As AppointmentViewInfoCustomizingEventArgs) Handles Calendario.AppointmentViewInfoCustomizing
        Dim TareaID As Integer
        Dim Tema As String
        Dim Materia As Integer
        With e.ViewInfo.Appointment
            TareaID = .LabelKey
            Tema = .Subject
            Materia = .CustomFields("IdMateria")
        End With

        If Calendario.ActiveViewType = SchedulerViewType.Agenda Then
            e.ViewInfo.Appearance.ForeColor = Color.Black
        Else
            e.ViewInfo.Appearance.ForeColor = ColorContraste(ValidaColor(cMateria.GetMateriaColor(Materia)))
        End If
        e.ViewInfo.Appearance.Font = New Font(e.ViewInfo.Appearance.Font, FontStyle.Bold)
    End Sub
#End Region
#Region "Validaciones"
    Private Sub frm_Actividades_Tareas_Tareas_Enter(sender As Object, e As EventArgs) Handles MyBase.Enter
        Try
            'SplashScreenManager.ShowForm(GetType(WaitForm1))
            Cursor.Current = Cursors.WaitCursor
            If AulaFormulario <> My.Settings.IdAulaActual Then
                AulaFormulario = My.Settings.IdAulaActual
                CargaTareas()
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
            'SplashScreenManager.CloseForm()
        End Try
    End Sub

    Private Sub Calendario_EditAppointmentFormShowing(sender As Object, e As AppointmentFormEventArgs) Handles Calendario.EditAppointmentFormShowing
        Try
            Cursor.Current = Cursors.WaitCursor
            Dim selectedApt As Integer = 0
            If Calendario.SelectedAppointments.Count = 1 Then
                selectedApt = Calendario.SelectedAppointments(0).LabelKey
            ElseIf Calendario.SelectedAppointments.Count > 1 Then
                XtraMessageBox.Show("Selecciono mas de una tarea, para abrir seleccione solo una.", "Error de Usuario", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            Using frm As New frm_Actividades_Tareas_Tarea() With {.pSoloLectura = IIf(selectedApt = 0, False, True), .pTarea = selectedApt, .WindowState = FormWindowState.Normal, .StartPosition = FormStartPosition.CenterParent}
                If frm.ShowDialog() = DialogResult.OK Then
                    CargaTareas()
                End If
            End Using
            e.Handled = True
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

    Private Sub Calendario_PopupMenuShowing(sender As Object, e As PopupMenuShowingEventArgs) Handles Calendario.PopupMenuShowing
        Try
            Cursor.Current = Cursors.WaitCursor
            e.Menu.Items.Clear()
            Dim selectedApt As Integer
            If Calendario.SelectedAppointments.Count = 1 Then
                selectedApt = Calendario.SelectedAppointments(0).CustomFields("IdTipoActividad")
            Else
                selectedApt = 0
            End If
            If selectedApt = 0 Then
                btnPopCalificar.Enabled = False
                btnPopEditar.Enabled = True
                btnPopAgregar.Enabled = True
            Else
                btnPopCalificar.Enabled = True
                btnPopEditar.Enabled = False
                btnPopAgregar.Enabled = False
            End If
            MenuPop.ShowPopup(Control.MousePosition)
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

    Private Sub btnPopAgregar_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnPopAgregar.ItemClick
        Try
            Cursor.Current = Cursors.WaitCursor
            Using frm As New frm_Actividades_Tareas_Tarea() With {.pSoloLectura = False, .pTarea = 0, .WindowState = FormWindowState.Normal, .StartPosition = FormStartPosition.CenterParent}
                If frm.ShowDialog() = DialogResult.OK Then
                    CargaTareas()
                    Calendario.Refresh()
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
        Finally
            Cursor.Current = Cursors.Default
        End Try
    End Sub

    Private Sub btnPopEditar_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnPopEditar.ItemClick
        Try
            Cursor.Current = Cursors.WaitCursor
            Dim selectedApt As Integer = 0
            If Calendario.SelectedAppointments.Count = 1 Then
                selectedApt = Calendario.SelectedAppointments(0).LabelKey
            ElseIf Calendario.SelectedAppointments.Count > 1 Then
                XtraMessageBox.Show("Selecciono mas de una tarea, para abrir seleccione solo una.", "Error de Usuario", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            Using frm As New frm_Actividades_Tareas_Tarea() With {.pSoloLectura = False, .pTarea = selectedApt, .WindowState = FormWindowState.Normal, .StartPosition = FormStartPosition.CenterParent}
                If frm.ShowDialog() = DialogResult.OK Then
                    CargaTareas()
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
        Finally
            Cursor.Current = Cursors.Default
        End Try
    End Sub

    Private Sub btnPopVistaDia_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnPopVistaDia.ItemClick
        Calendario.ActiveViewType = SchedulerViewType.Day
        Calendario.Views.DayView.AppointmentDisplayOptions.StartTimeVisibility = AppointmentTimeVisibility.Never
        Calendario.Views.DayView.AppointmentDisplayOptions.EndTimeVisibility = AppointmentTimeVisibility.Never
    End Sub

    Private Sub btnPopVistaSemana_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnPopVistaSemana.ItemClick
        Calendario.ActiveViewType = SchedulerViewType.WorkWeek
        Calendario.Views.WorkWeekView.AppointmentDisplayOptions.StartTimeVisibility = AppointmentTimeVisibility.Never
        Calendario.Views.WorkWeekView.AppointmentDisplayOptions.EndTimeVisibility = AppointmentTimeVisibility.Never
    End Sub

    Private Sub btnPopVistaMes_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnPopVistaMes.ItemClick
        Calendario.ActiveViewType = SchedulerViewType.Month
        Calendario.Views.MonthView.AppointmentDisplayOptions.StartTimeVisibility = AppointmentTimeVisibility.Never
        Calendario.Views.MonthView.AppointmentDisplayOptions.EndTimeVisibility = AppointmentTimeVisibility.Never
    End Sub

    Private Sub btnPopVistaAgenda_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnPopVistaAgenda.ItemClick
        Calendario.ActiveViewType = SchedulerViewType.Agenda
        Calendario.Views.AgendaView.AppointmentDisplayOptions.StartTimeVisibility = AppointmentTimeVisibility.Never
        Calendario.Views.AgendaView.AppointmentDisplayOptions.EndTimeVisibility = AppointmentTimeVisibility.Never
        Calendario.AgendaView.DayCount = 7
    End Sub

    Private Sub Calendario_InitAppointmentDisplayText(sender As Object, e As AppointmentDisplayTextEventArgs) Handles Calendario.InitAppointmentDisplayText
        Dim apt As Appointment = e.Appointment
        e.Text = String.Format("Tema: {0}", apt.Subject)
        e.Description = String.Format("Detalle: {0}", apt.Description)
    End Sub

    Private Sub Calendario_InitAppointmentImages(sender As Object, e As AppointmentImagesEventArgs) Handles Calendario.InitAppointmentImages
        Dim info As AppointmentImageInfo = New AppointmentImageInfo()
        Select Case CInt(e.Appointment.CustomFields("IdTipoActividad"))
            Case 1
                info.Image = My.Resources.Tarea
            Case 2
                info.Image = My.Resources.PuntoExtra
            Case 3
                info.Image = My.Resources.Examen
            Case Else
                Exit Select
        End Select
        e.ImageInfoList.Add(info)
    End Sub
#End Region

    Private Sub MenuPop_BeforePopup(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles MenuPop.BeforePopup
        CType(sender, DevExpress.XtraBars.PopupMenu).ItemLinks(1).Item.Enabled = Not CType(sender, DevExpress.XtraBars.PopupMenu).ItemLinks(1).Item.Enabled
    End Sub

    Private Sub btnPopCalificar_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnPopCalificar.ItemClick
        Try
            Cursor.Current = Cursors.WaitCursor
            Dim selectedApt As Integer = 0
            If Calendario.SelectedAppointments.Count = 1 Then
                selectedApt = Calendario.SelectedAppointments(0).LabelKey
            ElseIf Calendario.SelectedAppointments.Count > 1 Then
                XtraMessageBox.Show("Selecciono mas de una tarea, para abrir seleccione solo una.", "Error de Usuario", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            Using frm As New frmCalificarTarea With {.pTarea = selectedApt, .WindowState = FormWindowState.Normal, .StartPosition = FormStartPosition.CenterParent}
                If frm.ShowDialog() = DialogResult.OK Then
                    CargaTareas()
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
        Finally
            Cursor.Current = Cursors.Default
        End Try
    End Sub
End Class