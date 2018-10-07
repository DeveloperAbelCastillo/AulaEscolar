<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_Actividades_Tareas_Calendario
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim TimeRuler1 As DevExpress.XtraScheduler.TimeRuler = New DevExpress.XtraScheduler.TimeRuler()
        Dim TimeRuler2 As DevExpress.XtraScheduler.TimeRuler = New DevExpress.XtraScheduler.TimeRuler()
        Dim TimeRuler3 As DevExpress.XtraScheduler.TimeRuler = New DevExpress.XtraScheduler.TimeRuler()
        Me.SchedulerStorage1 = New DevExpress.XtraScheduler.SchedulerStorage(Me.components)
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.NavegadorCalendario = New DevExpress.XtraScheduler.DateNavigator()
        Me.Calendario = New DevExpress.XtraScheduler.SchedulerControl()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.AgregarTarea = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.btnPopAgregar = New DevExpress.XtraBars.BarButtonItem()
        Me.VistaDia = New DevExpress.XtraBars.BarButtonItem()
        Me.VistaMes = New DevExpress.XtraBars.BarButtonItem()
        Me.BarSubItem1 = New DevExpress.XtraBars.BarSubItem()
        Me.btnPopVistaDia = New DevExpress.XtraBars.BarButtonItem()
        Me.btnPopVistaSemana = New DevExpress.XtraBars.BarButtonItem()
        Me.btnPopVistaMes = New DevExpress.XtraBars.BarButtonItem()
        Me.btnPopVistaAgenda = New DevExpress.XtraBars.BarButtonItem()
        Me.btnPopEditar = New DevExpress.XtraBars.BarButtonItem()
        Me.btnPopCalificar = New DevExpress.XtraBars.BarButtonItem()
        Me.MenuPop = New DevExpress.XtraBars.PopupMenu(Me.components)
        Me.SplashScreenManager1 = New DevExpress.XtraSplashScreen.SplashScreenManager(Me, GetType(Global.Profesor.WaitForm1), True, True)
        CType(Me.SchedulerStorage1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.NavegadorCalendario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NavegadorCalendario.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Calendario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MenuPop, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.NavegadorCalendario)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Right
        Me.PanelControl1.Location = New System.Drawing.Point(620, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(217, 508)
        Me.PanelControl1.TabIndex = 0
        '
        'NavegadorCalendario
        '
        Me.NavegadorCalendario.CalendarAppearance.DayCellSpecial.FontStyleDelta = System.Drawing.FontStyle.Bold
        Me.NavegadorCalendario.CalendarAppearance.DayCellSpecial.Options.UseFont = True
        Me.NavegadorCalendario.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.NavegadorCalendario.Cursor = System.Windows.Forms.Cursors.Default
        Me.NavegadorCalendario.DateTime = New Date(2018, 2, 16, 0, 0, 0, 0)
        Me.NavegadorCalendario.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NavegadorCalendario.EditValue = New Date(2018, 2, 16, 0, 0, 0, 0)
        Me.NavegadorCalendario.FirstDayOfWeek = System.DayOfWeek.Sunday
        Me.NavegadorCalendario.Location = New System.Drawing.Point(2, 2)
        Me.NavegadorCalendario.Name = "NavegadorCalendario"
        Me.NavegadorCalendario.SchedulerControl = Me.Calendario
        Me.NavegadorCalendario.Size = New System.Drawing.Size(213, 504)
        Me.NavegadorCalendario.TabIndex = 2
        '
        'Calendario
        '
        Me.Calendario.DataStorage = Me.SchedulerStorage1
        Me.Calendario.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Calendario.Location = New System.Drawing.Point(0, 0)
        Me.Calendario.MenuManager = Me.BarManager1
        Me.Calendario.Name = "Calendario"
        Me.Calendario.Size = New System.Drawing.Size(620, 508)
        Me.Calendario.Start = New Date(2017, 5, 10, 0, 0, 0, 0)
        Me.Calendario.TabIndex = 1
        Me.Calendario.Views.DayView.AppointmentDisplayOptions.EndTimeVisibility = DevExpress.XtraScheduler.AppointmentTimeVisibility.Never
        Me.Calendario.Views.DayView.AppointmentDisplayOptions.StartTimeVisibility = DevExpress.XtraScheduler.AppointmentTimeVisibility.Never
        Me.Calendario.Views.DayView.TimeRulers.Add(TimeRuler1)
        Me.Calendario.Views.FullWeekView.TimeRulers.Add(TimeRuler2)
        Me.Calendario.Views.WorkWeekView.TimeRulers.Add(TimeRuler3)
        '
        'BarManager1
        '
        Me.BarManager1.Categories.AddRange(New DevExpress.XtraBars.BarManagerCategory() {New DevExpress.XtraBars.BarManagerCategory("Tareas", New System.Guid("823c90fc-4f1d-471b-abc5-7304722ac643")), New DevExpress.XtraBars.BarManagerCategory("Vista", New System.Guid("fd58e6ff-e7d9-4f51-80a1-4661e84467a5"))})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.AgregarTarea, Me.BarButtonItem1, Me.btnPopAgregar, Me.VistaDia, Me.VistaMes, Me.BarSubItem1, Me.btnPopVistaDia, Me.btnPopVistaMes, Me.btnPopEditar, Me.btnPopVistaSemana, Me.btnPopVistaAgenda, Me.btnPopCalificar})
        Me.BarManager1.MaxItemId = 13
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.BarManager1
        Me.barDockControlTop.Size = New System.Drawing.Size(837, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 508)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(837, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 508)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(837, 0)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 508)
        '
        'AgregarTarea
        '
        Me.AgregarTarea.Caption = "Agregar"
        Me.AgregarTarea.CategoryGuid = New System.Guid("823c90fc-4f1d-471b-abc5-7304722ac643")
        Me.AgregarTarea.Id = 0
        Me.AgregarTarea.Name = "AgregarTarea"
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "AgregarTarea"
        Me.BarButtonItem1.Id = 1
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'btnPopAgregar
        '
        Me.btnPopAgregar.Caption = "Agregar"
        Me.btnPopAgregar.Id = 2
        Me.btnPopAgregar.Name = "btnPopAgregar"
        '
        'VistaDia
        '
        Me.VistaDia.Caption = "Dia"
        Me.VistaDia.CategoryGuid = New System.Guid("fd58e6ff-e7d9-4f51-80a1-4661e84467a5")
        Me.VistaDia.Id = 4
        Me.VistaDia.Name = "VistaDia"
        '
        'VistaMes
        '
        Me.VistaMes.Caption = "Mes"
        Me.VistaMes.CategoryGuid = New System.Guid("fd58e6ff-e7d9-4f51-80a1-4661e84467a5")
        Me.VistaMes.Id = 5
        Me.VistaMes.Name = "VistaMes"
        '
        'BarSubItem1
        '
        Me.BarSubItem1.Caption = "Vista"
        Me.BarSubItem1.Id = 6
        Me.BarSubItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btnPopVistaDia), New DevExpress.XtraBars.LinkPersistInfo(Me.btnPopVistaSemana), New DevExpress.XtraBars.LinkPersistInfo(Me.btnPopVistaMes), New DevExpress.XtraBars.LinkPersistInfo(Me.btnPopVistaAgenda)})
        Me.BarSubItem1.Name = "BarSubItem1"
        '
        'btnPopVistaDia
        '
        Me.btnPopVistaDia.Caption = "Dia"
        Me.btnPopVistaDia.Id = 7
        Me.btnPopVistaDia.Name = "btnPopVistaDia"
        '
        'btnPopVistaSemana
        '
        Me.btnPopVistaSemana.Caption = "Semana"
        Me.btnPopVistaSemana.Id = 10
        Me.btnPopVistaSemana.Name = "btnPopVistaSemana"
        '
        'btnPopVistaMes
        '
        Me.btnPopVistaMes.Caption = "Mes"
        Me.btnPopVistaMes.Id = 8
        Me.btnPopVistaMes.Name = "btnPopVistaMes"
        '
        'btnPopVistaAgenda
        '
        Me.btnPopVistaAgenda.Caption = "Agenda"
        Me.btnPopVistaAgenda.Id = 11
        Me.btnPopVistaAgenda.Name = "btnPopVistaAgenda"
        '
        'btnPopEditar
        '
        Me.btnPopEditar.Caption = "Editar"
        Me.btnPopEditar.Id = 9
        Me.btnPopEditar.Name = "btnPopEditar"
        '
        'btnPopCalificar
        '
        Me.btnPopCalificar.Caption = "Calificar"
        Me.btnPopCalificar.Id = 12
        Me.btnPopCalificar.Name = "btnPopCalificar"
        '
        'MenuPop
        '
        Me.MenuPop.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btnPopAgregar), New DevExpress.XtraBars.LinkPersistInfo(Me.btnPopEditar), New DevExpress.XtraBars.LinkPersistInfo(Me.btnPopCalificar), New DevExpress.XtraBars.LinkPersistInfo(Me.BarSubItem1, True)})
        Me.MenuPop.Manager = Me.BarManager1
        Me.MenuPop.Name = "MenuPop"
        '
        'SplashScreenManager1
        '
        Me.SplashScreenManager1.ClosingDelay = 500
        '
        'frm_Actividades_Tareas_Calendario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(837, 508)
        Me.Controls.Add(Me.Calendario)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_Actividades_Tareas_Calendario"
        Me.ShowIcon = False
        Me.Text = "Tareas"
        CType(Me.SchedulerStorage1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.NavegadorCalendario.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NavegadorCalendario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Calendario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MenuPop, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SchedulerStorage1 As DevExpress.XtraScheduler.SchedulerStorage
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents NavegadorCalendario As DevExpress.XtraScheduler.DateNavigator
    Friend WithEvents Calendario As DevExpress.XtraScheduler.SchedulerControl
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents MenuPop As DevExpress.XtraBars.PopupMenu
    Friend WithEvents AgregarTarea As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnPopAgregar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents VistaDia As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents VistaMes As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarSubItem1 As DevExpress.XtraBars.BarSubItem
    Friend WithEvents btnPopVistaDia As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnPopVistaMes As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnPopEditar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnPopVistaSemana As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnPopVistaAgenda As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents SplashScreenManager1 As DevExpress.XtraSplashScreen.SplashScreenManager
    Friend WithEvents btnPopCalificar As DevExpress.XtraBars.BarButtonItem
End Class
