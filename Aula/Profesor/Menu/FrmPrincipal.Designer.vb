<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmPrincipal
    Inherits DevExpress.XtraBars.Ribbon.RibbonForm

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPrincipal))
        Me.SplashScreenManager2 = New DevExpress.XtraSplashScreen.SplashScreenManager(Me, GetType(Global.Profesor.WaitForm1), True, True, True)
        Me.RibbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.SkinRibbonGalleryBarItem1 = New DevExpress.XtraBars.SkinRibbonGalleryBarItem()
        Me.btnConficuraiconAplicacionConfiguracionGeneral = New DevExpress.XtraBars.BarButtonItem()
        Me.btnConficuraiconAplicacionConfiguracionAulas = New DevExpress.XtraBars.BarButtonItem()
        Me.beAulas = New DevExpress.XtraBars.BarEditItem()
        Me.ricbAulas = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.btnConfiguracionSeguridad = New DevExpress.XtraBars.BarButtonItem()
        Me.btnConficuraiconAplicacionConfiguracionMaterias = New DevExpress.XtraBars.BarButtonItem()
        Me.btnAulaAlumnos = New DevExpress.XtraBars.BarButtonItem()
        Me.btnPaseLista = New DevExpress.XtraBars.BarButtonItem()
        Me.btnCalendario = New DevExpress.XtraBars.BarButtonItem()
        Me.bbRefrescar = New DevExpress.XtraBars.BarButtonItem()
        Me.btnConfiguracionAplicacionPeriodos = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPage2 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup4 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPage3 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup3 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonStatusBar1 = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
        Me.ApplicationMenu1 = New DevExpress.XtraBars.Ribbon.ApplicationMenu(Me.components)
        Me.DefaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
        Me.XtraTabbedMdiManager1 = New DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(Me.components)
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ricbAulas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ApplicationMenu1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabbedMdiManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplashScreenManager2
        '
        Me.SplashScreenManager2.ClosingDelay = 1000
        '
        'RibbonControl1
        '
        Me.RibbonControl1.AllowMinimizeRibbon = False
        Me.RibbonControl1.ApplicationIcon = CType(resources.GetObject("RibbonControl1.ApplicationIcon"), System.Drawing.Bitmap)
        Me.RibbonControl1.ExpandCollapseItem.Id = 0
        Me.RibbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl1.ExpandCollapseItem, Me.SkinRibbonGalleryBarItem1, Me.btnConficuraiconAplicacionConfiguracionGeneral, Me.btnConficuraiconAplicacionConfiguracionAulas, Me.beAulas, Me.btnConfiguracionSeguridad, Me.btnConficuraiconAplicacionConfiguracionMaterias, Me.btnAulaAlumnos, Me.btnPaseLista, Me.btnCalendario, Me.bbRefrescar, Me.btnConfiguracionAplicacionPeriodos})
        Me.RibbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl1.MaxItemId = 15
        Me.RibbonControl1.Name = "RibbonControl1"
        Me.RibbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1, Me.RibbonPage2, Me.RibbonPage3})
        Me.RibbonControl1.QuickToolbarItemLinks.Add(Me.SkinRibbonGalleryBarItem1)
        Me.RibbonControl1.QuickToolbarItemLinks.Add(Me.beAulas)
        Me.RibbonControl1.QuickToolbarItemLinks.Add(Me.bbRefrescar)
        Me.RibbonControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.ricbAulas})
        Me.RibbonControl1.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.RibbonControl1.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.RibbonControl1.ShowToolbarCustomizeItem = False
        Me.RibbonControl1.Size = New System.Drawing.Size(709, 143)
        Me.RibbonControl1.StatusBar = Me.RibbonStatusBar1
        Me.RibbonControl1.Toolbar.ShowCustomizeItem = False
        '
        'SkinRibbonGalleryBarItem1
        '
        Me.SkinRibbonGalleryBarItem1.Caption = "SkinRibbonGalleryBarItem1"
        Me.SkinRibbonGalleryBarItem1.Id = 2
        Me.SkinRibbonGalleryBarItem1.Name = "SkinRibbonGalleryBarItem1"
        '
        'btnConficuraiconAplicacionConfiguracionGeneral
        '
        Me.btnConficuraiconAplicacionConfiguracionGeneral.Caption = "General"
        Me.btnConficuraiconAplicacionConfiguracionGeneral.Id = 3
        Me.btnConficuraiconAplicacionConfiguracionGeneral.ImageOptions.Image = CType(resources.GetObject("btnConficuraiconAplicacionConfiguracionGeneral.ImageOptions.Image"), System.Drawing.Image)
        Me.btnConficuraiconAplicacionConfiguracionGeneral.ImageOptions.LargeImage = CType(resources.GetObject("btnConficuraiconAplicacionConfiguracionGeneral.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnConficuraiconAplicacionConfiguracionGeneral.Name = "btnConficuraiconAplicacionConfiguracionGeneral"
        '
        'btnConficuraiconAplicacionConfiguracionAulas
        '
        Me.btnConficuraiconAplicacionConfiguracionAulas.Caption = "Aulas"
        Me.btnConficuraiconAplicacionConfiguracionAulas.Id = 4
        Me.btnConficuraiconAplicacionConfiguracionAulas.ImageOptions.Image = CType(resources.GetObject("btnConficuraiconAplicacionConfiguracionAulas.ImageOptions.Image"), System.Drawing.Image)
        Me.btnConficuraiconAplicacionConfiguracionAulas.ImageOptions.LargeImage = CType(resources.GetObject("btnConficuraiconAplicacionConfiguracionAulas.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnConficuraiconAplicacionConfiguracionAulas.Name = "btnConficuraiconAplicacionConfiguracionAulas"
        '
        'beAulas
        '
        Me.beAulas.Caption = "Aula"
        Me.beAulas.Edit = Me.ricbAulas
        Me.beAulas.Id = 5
        Me.beAulas.ImageOptions.Image = CType(resources.GetObject("beAulas.ImageOptions.Image"), System.Drawing.Image)
        Me.beAulas.ImageOptions.LargeImage = CType(resources.GetObject("beAulas.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.beAulas.Name = "beAulas"
        '
        'ricbAulas
        '
        Me.ricbAulas.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.ricbAulas.Appearance.Options.UseFont = True
        Me.ricbAulas.AutoHeight = False
        Me.ricbAulas.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ricbAulas.Name = "ricbAulas"
        Me.ricbAulas.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        '
        'btnConfiguracionSeguridad
        '
        Me.btnConfiguracionSeguridad.Caption = "Seguridad"
        Me.btnConfiguracionSeguridad.Id = 7
        Me.btnConfiguracionSeguridad.ImageOptions.LargeImage = Global.Profesor.My.Resources.Resources.key
        Me.btnConfiguracionSeguridad.Name = "btnConfiguracionSeguridad"
        '
        'btnConficuraiconAplicacionConfiguracionMaterias
        '
        Me.btnConficuraiconAplicacionConfiguracionMaterias.Caption = "Materias"
        Me.btnConficuraiconAplicacionConfiguracionMaterias.Id = 8
        Me.btnConficuraiconAplicacionConfiguracionMaterias.ImageOptions.Image = CType(resources.GetObject("btnConficuraiconAplicacionConfiguracionMaterias.ImageOptions.Image"), System.Drawing.Image)
        Me.btnConficuraiconAplicacionConfiguracionMaterias.ImageOptions.LargeImage = CType(resources.GetObject("btnConficuraiconAplicacionConfiguracionMaterias.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnConficuraiconAplicacionConfiguracionMaterias.Name = "btnConficuraiconAplicacionConfiguracionMaterias"
        '
        'btnAulaAlumnos
        '
        Me.btnAulaAlumnos.Caption = "Lista de Alumnos"
        Me.btnAulaAlumnos.Id = 10
        Me.btnAulaAlumnos.ImageOptions.Image = CType(resources.GetObject("btnAulaAlumnos.ImageOptions.Image"), System.Drawing.Image)
        Me.btnAulaAlumnos.ImageOptions.LargeImage = CType(resources.GetObject("btnAulaAlumnos.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnAulaAlumnos.Name = "btnAulaAlumnos"
        '
        'btnPaseLista
        '
        Me.btnPaseLista.Caption = "Pase de Lista"
        Me.btnPaseLista.Id = 11
        Me.btnPaseLista.ImageOptions.Image = CType(resources.GetObject("btnPaseLista.ImageOptions.Image"), System.Drawing.Image)
        Me.btnPaseLista.ImageOptions.LargeImage = CType(resources.GetObject("btnPaseLista.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnPaseLista.Name = "btnPaseLista"
        '
        'btnCalendario
        '
        Me.btnCalendario.Caption = "Calendario"
        Me.btnCalendario.Id = 12
        Me.btnCalendario.ImageOptions.Image = CType(resources.GetObject("btnCalendario.ImageOptions.Image"), System.Drawing.Image)
        Me.btnCalendario.ImageOptions.LargeImage = CType(resources.GetObject("btnCalendario.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnCalendario.Name = "btnCalendario"
        '
        'bbRefrescar
        '
        Me.bbRefrescar.Caption = "btnRefrescar"
        Me.bbRefrescar.Id = 13
        Me.bbRefrescar.ImageOptions.Image = CType(resources.GetObject("bbRefrescar.ImageOptions.Image"), System.Drawing.Image)
        Me.bbRefrescar.ImageOptions.LargeImage = CType(resources.GetObject("bbRefrescar.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.bbRefrescar.Name = "bbRefrescar"
        '
        'btnConfiguracionAplicacionPeriodos
        '
        Me.btnConfiguracionAplicacionPeriodos.Caption = "Periodos"
        Me.btnConfiguracionAplicacionPeriodos.Id = 14
        Me.btnConfiguracionAplicacionPeriodos.ImageOptions.Image = CType(resources.GetObject("btnConfiguracionAplicacionPeriodos.ImageOptions.Image"), System.Drawing.Image)
        Me.btnConfiguracionAplicacionPeriodos.ImageOptions.LargeImage = CType(resources.GetObject("btnConfiguracionAplicacionPeriodos.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnConfiguracionAplicacionPeriodos.Name = "btnConfiguracionAplicacionPeriodos"
        '
        'RibbonPage1
        '
        Me.RibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup1, Me.RibbonPageGroup2})
        Me.RibbonPage1.Name = "RibbonPage1"
        Me.RibbonPage1.Text = "Configuracion"
        '
        'RibbonPageGroup1
        '
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnConficuraiconAplicacionConfiguracionGeneral)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnConfiguracionSeguridad)
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        Me.RibbonPageGroup1.Text = "Aplicacion"
        '
        'RibbonPageGroup2
        '
        Me.RibbonPageGroup2.ItemLinks.Add(Me.btnConficuraiconAplicacionConfiguracionAulas)
        Me.RibbonPageGroup2.ItemLinks.Add(Me.btnConficuraiconAplicacionConfiguracionMaterias)
        Me.RibbonPageGroup2.ItemLinks.Add(Me.btnConfiguracionAplicacionPeriodos)
        Me.RibbonPageGroup2.Name = "RibbonPageGroup2"
        Me.RibbonPageGroup2.Text = "Aulas"
        '
        'RibbonPage2
        '
        Me.RibbonPage2.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup4})
        Me.RibbonPage2.Name = "RibbonPage2"
        Me.RibbonPage2.Text = "Aula"
        '
        'RibbonPageGroup4
        '
        Me.RibbonPageGroup4.ItemLinks.Add(Me.btnAulaAlumnos)
        Me.RibbonPageGroup4.ItemLinks.Add(Me.btnPaseLista)
        Me.RibbonPageGroup4.Name = "RibbonPageGroup4"
        Me.RibbonPageGroup4.Text = "Alumnos"
        '
        'RibbonPage3
        '
        Me.RibbonPage3.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup3})
        Me.RibbonPage3.Name = "RibbonPage3"
        Me.RibbonPage3.Text = "Actividades"
        '
        'RibbonPageGroup3
        '
        Me.RibbonPageGroup3.ItemLinks.Add(Me.btnCalendario)
        Me.RibbonPageGroup3.Name = "RibbonPageGroup3"
        Me.RibbonPageGroup3.Text = "Tareas"
        '
        'RibbonStatusBar1
        '
        Me.RibbonStatusBar1.Location = New System.Drawing.Point(0, 452)
        Me.RibbonStatusBar1.Name = "RibbonStatusBar1"
        Me.RibbonStatusBar1.Ribbon = Me.RibbonControl1
        Me.RibbonStatusBar1.Size = New System.Drawing.Size(709, 31)
        '
        'ApplicationMenu1
        '
        Me.ApplicationMenu1.Name = "ApplicationMenu1"
        Me.ApplicationMenu1.Ribbon = Me.RibbonControl1
        '
        'XtraTabbedMdiManager1
        '
        Me.XtraTabbedMdiManager1.MdiParent = Me
        '
        'FrmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(709, 483)
        Me.Controls.Add(Me.RibbonStatusBar1)
        Me.Controls.Add(Me.RibbonControl1)
        Me.IsMdiContainer = True
        Me.Name = "FrmPrincipal"
        Me.Ribbon = Me.RibbonControl1
        Me.RibbonVisibility = DevExpress.XtraBars.Ribbon.RibbonVisibility.Visible
        Me.StatusBar = Me.RibbonStatusBar1
        Me.Text = "Principal"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ricbAulas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ApplicationMenu1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabbedMdiManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RibbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents ApplicationMenu1 As DevExpress.XtraBars.Ribbon.ApplicationMenu
    Friend WithEvents RibbonStatusBar1 As DevExpress.XtraBars.Ribbon.RibbonStatusBar
    Friend WithEvents SkinRibbonGalleryBarItem1 As DevExpress.XtraBars.SkinRibbonGalleryBarItem
    Friend WithEvents DefaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
    Friend WithEvents btnConficuraiconAplicacionConfiguracionGeneral As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnConficuraiconAplicacionConfiguracionAulas As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents beAulas As DevExpress.XtraBars.BarEditItem
    Friend WithEvents ricbAulas As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents btnConfiguracionSeguridad As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents btnConficuraiconAplicacionConfiguracionMaterias As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPage2 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup4 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents btnAulaAlumnos As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnPaseLista As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents XtraTabbedMdiManager1 As DevExpress.XtraTabbedMdi.XtraTabbedMdiManager
    Friend WithEvents RibbonPage3 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup3 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents btnCalendario As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents SplashScreenManager2 As DevExpress.XtraSplashScreen.SplashScreenManager
    Friend WithEvents bbRefrescar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnConfiguracionAplicacionPeriodos As DevExpress.XtraBars.BarButtonItem
End Class
