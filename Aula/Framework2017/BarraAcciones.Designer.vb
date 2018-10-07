<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BarraAcciones
    Inherits DevExpress.XtraEditors.XtraUserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BarraAcciones))
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar1 = New DevExpress.XtraBars.Bar()
        Me.btnAgregar = New DevExpress.XtraBars.BarButtonItem()
        Me.btnEditar = New DevExpress.XtraBars.BarButtonItem()
        Me.btnEliminar = New DevExpress.XtraBars.BarButtonItem()
        Me.lblProceso = New DevExpress.XtraBars.BarStaticItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.BarHeaderItem1 = New DevExpress.XtraBars.BarHeaderItem()
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BarManager1
        '
        Me.BarManager1.AllowCustomization = False
        Me.BarManager1.AllowMoveBarOnToolbar = False
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar1})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btnAgregar, Me.btnEditar, Me.btnEliminar, Me.BarHeaderItem1, Me.lblProceso})
        Me.BarManager1.MaxItemId = 6
        '
        'Bar1
        '
        Me.Bar1.BarName = "Acciones"
        Me.Bar1.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Top
        Me.Bar1.DockCol = 0
        Me.Bar1.DockRow = 0
        Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar1.FloatLocation = New System.Drawing.Point(317, 119)
        Me.Bar1.FloatSize = New System.Drawing.Size(254, 47)
        Me.Bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btnAgregar), New DevExpress.XtraBars.LinkPersistInfo(Me.btnEditar), New DevExpress.XtraBars.LinkPersistInfo(Me.btnEliminar), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.lblProceso, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
        Me.Bar1.OptionsBar.DisableClose = True
        Me.Bar1.OptionsBar.DisableCustomization = True
        Me.Bar1.OptionsBar.RotateWhenVertical = False
        Me.Bar1.Text = "Acciones"
        '
        'btnAgregar
        '
        Me.btnAgregar.Caption = "Agregar"
        Me.btnAgregar.Id = 0
        Me.btnAgregar.ImageOptions.Image = Global.Framework2017.My.Resources.Resources.add_16
        Me.btnAgregar.Name = "btnAgregar"
        '
        'btnEditar
        '
        Me.btnEditar.Caption = "Editar"
        Me.btnEditar.Id = 1
        Me.btnEditar.ImageOptions.Image = Global.Framework2017.My.Resources.Resources.edit_16
        Me.btnEditar.Name = "btnEditar"
        '
        'btnEliminar
        '
        Me.btnEliminar.Caption = "Eliminar"
        Me.btnEliminar.Id = 2
        Me.btnEliminar.ImageOptions.Image = Global.Framework2017.My.Resources.Resources.delete_16
        Me.btnEliminar.Name = "btnEliminar"
        '
        'lblProceso
        '
        Me.lblProceso.Caption = "Correcto"
        Me.lblProceso.Id = 5
        Me.lblProceso.ImageOptions.Image = CType(resources.GetObject("lblProceso.ImageOptions.Image"), System.Drawing.Image)
        Me.lblProceso.ImageOptions.LargeImage = CType(resources.GetObject("lblProceso.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.lblProceso.Name = "lblProceso"
        Me.lblProceso.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.BarManager1
        Me.barDockControlTop.Size = New System.Drawing.Size(268, 31)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 30)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(268, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 31)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 0)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(268, 31)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 0)
        '
        'BarHeaderItem1
        '
        Me.BarHeaderItem1.Caption = "Correcto"
        Me.BarHeaderItem1.Id = 3
        Me.BarHeaderItem1.Name = "BarHeaderItem1"
        Me.BarHeaderItem1.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'Timer
        '
        Me.Timer.Interval = 2000
        '
        'BarraAcciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Name = "BarraAcciones"
        Me.Size = New System.Drawing.Size(268, 30)
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar1 As DevExpress.XtraBars.Bar
    Friend WithEvents btnAgregar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnEditar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnEliminar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarHeaderItem1 As DevExpress.XtraBars.BarHeaderItem
    Friend WithEvents lblProceso As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents Timer As System.Windows.Forms.Timer
End Class
