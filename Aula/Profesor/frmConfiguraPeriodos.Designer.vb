<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmConfiguraPeriodos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConfiguraPeriodos))
        Me.gcPeriodos = New DevExpress.XtraGrid.GridControl()
        Me.gvPeriodos = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.gpoPeriodos = New DevExpress.XtraEditors.GroupControl()
        Me.fpPeriodo = New DevExpress.Utils.FlyoutPanel()
        Me.fpcPeriodos = New DevExpress.Utils.FlyoutPanelControl()
        Me.gpoPeriodo = New DevExpress.XtraEditors.GroupControl()
        Me.ccFechaFin = New DevExpress.XtraEditors.Controls.CalendarControl()
        Me.ccFechaInicio = New DevExpress.XtraEditors.Controls.CalendarControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.btnCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.btnGuardar = New DevExpress.XtraEditors.SimpleButton()
        Me.BarraAcciones = New Framework2017.BarraAcciones()
        Me.DxValidationProvider1 = New DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(Me.components)
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.gcDiasPeriodo = New DevExpress.XtraGrid.GridControl()
        Me.gvDiasPeriodo = New DevExpress.XtraGrid.Views.Grid.GridView()
        CType(Me.gcPeriodos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvPeriodos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gpoPeriodos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpoPeriodos.SuspendLayout()
        CType(Me.fpPeriodo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.fpPeriodo.SuspendLayout()
        CType(Me.fpcPeriodos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.fpcPeriodos.SuspendLayout()
        CType(Me.gpoPeriodo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpoPeriodo.SuspendLayout()
        CType(Me.ccFechaFin.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ccFechaInicio.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DxValidationProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.gcDiasPeriodo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvDiasPeriodo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gcPeriodos
        '
        Me.gcPeriodos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gcPeriodos.Location = New System.Drawing.Point(1, 32)
        Me.gcPeriodos.MainView = Me.gvPeriodos
        Me.gcPeriodos.Name = "gcPeriodos"
        Me.gcPeriodos.Size = New System.Drawing.Size(557, 658)
        Me.gcPeriodos.TabIndex = 0
        Me.gcPeriodos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvPeriodos})
        '
        'gvPeriodos
        '
        Me.gvPeriodos.GridControl = Me.gcPeriodos
        Me.gvPeriodos.Name = "gvPeriodos"
        Me.gvPeriodos.OptionsView.ShowGroupPanel = False
        '
        'gpoPeriodos
        '
        Me.gpoPeriodos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.gpoPeriodos.CaptionLocation = DevExpress.Utils.Locations.Top
        Me.gpoPeriodos.Controls.Add(Me.fpPeriodo)
        Me.gpoPeriodos.Controls.Add(Me.BarraAcciones)
        Me.gpoPeriodos.Controls.Add(Me.gcPeriodos)
        Me.gpoPeriodos.Location = New System.Drawing.Point(12, 12)
        Me.gpoPeriodos.Name = "gpoPeriodos"
        Me.gpoPeriodos.ShowCaption = False
        Me.gpoPeriodos.Size = New System.Drawing.Size(558, 690)
        Me.gpoPeriodos.TabIndex = 1
        Me.gpoPeriodos.Text = "GroupControl1"
        '
        'fpPeriodo
        '
        Me.fpPeriodo.Controls.Add(Me.fpcPeriodos)
        Me.fpPeriodo.Location = New System.Drawing.Point(1, 32)
        Me.fpPeriodo.Name = "fpPeriodo"
        Me.fpPeriodo.OptionsButtonPanel.ButtonPanelContentAlignment = System.Drawing.ContentAlignment.TopCenter
        Me.fpPeriodo.OptionsButtonPanel.ButtonPanelLocation = DevExpress.Utils.FlyoutPanelButtonPanelLocation.Top
        Me.fpPeriodo.OwnerControl = Me.gcPeriodos
        Me.fpPeriodo.Size = New System.Drawing.Size(557, 322)
        Me.fpPeriodo.TabIndex = 8
        '
        'fpcPeriodos
        '
        Me.fpcPeriodos.Controls.Add(Me.gpoPeriodo)
        Me.fpcPeriodos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.fpcPeriodos.FlyoutPanel = Me.fpPeriodo
        Me.fpcPeriodos.Location = New System.Drawing.Point(0, 0)
        Me.fpcPeriodos.Name = "fpcPeriodos"
        Me.fpcPeriodos.Size = New System.Drawing.Size(557, 322)
        Me.fpcPeriodos.TabIndex = 0
        '
        'gpoPeriodo
        '
        Me.gpoPeriodo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gpoPeriodo.CaptionLocation = DevExpress.Utils.Locations.Top
        Me.gpoPeriodo.Controls.Add(Me.ccFechaFin)
        Me.gpoPeriodo.Controls.Add(Me.ccFechaInicio)
        Me.gpoPeriodo.Controls.Add(Me.LabelControl3)
        Me.gpoPeriodo.Controls.Add(Me.btnCancelar)
        Me.gpoPeriodo.Controls.Add(Me.LabelControl4)
        Me.gpoPeriodo.Controls.Add(Me.btnGuardar)
        Me.gpoPeriodo.Location = New System.Drawing.Point(2, 5)
        Me.gpoPeriodo.Name = "gpoPeriodo"
        Me.gpoPeriodo.Size = New System.Drawing.Size(552, 312)
        Me.gpoPeriodo.TabIndex = 4
        Me.gpoPeriodo.Text = "Periodo"
        '
        'ccFechaFin
        '
        Me.ccFechaFin.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ccFechaFin.Location = New System.Drawing.Point(277, 45)
        Me.ccFechaFin.Name = "ccFechaFin"
        Me.ccFechaFin.Size = New System.Drawing.Size(248, 227)
        Me.ccFechaFin.TabIndex = 13
        '
        'ccFechaInicio
        '
        Me.ccFechaInicio.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ccFechaInicio.Location = New System.Drawing.Point(5, 45)
        Me.ccFechaInicio.Name = "ccFechaInicio"
        Me.ccFechaInicio.Size = New System.Drawing.Size(248, 227)
        Me.ccFechaInicio.TabIndex = 12
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(277, 23)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(46, 13)
        Me.LabelControl3.TabIndex = 8
        Me.LabelControl3.Text = "Fecha Fin"
        '
        'btnCancelar
        '
        Me.btnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnCancelar.AutoSize = True
        Me.btnCancelar.ImageOptions.Image = CType(resources.GetObject("btnCancelar.ImageOptions.Image"), System.Drawing.Image)
        Me.btnCancelar.Location = New System.Drawing.Point(5, 285)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(70, 22)
        Me.btnCancelar.TabIndex = 7
        Me.btnCancelar.Text = "Cancelar"
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(5, 23)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(57, 13)
        Me.LabelControl4.TabIndex = 11
        Me.LabelControl4.Text = "Fecha Inicio"
        '
        'btnGuardar
        '
        Me.btnGuardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGuardar.AutoSize = True
        Me.btnGuardar.ImageOptions.Image = CType(resources.GetObject("btnGuardar.ImageOptions.Image"), System.Drawing.Image)
        Me.btnGuardar.Location = New System.Drawing.Point(480, 285)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(67, 22)
        Me.btnGuardar.TabIndex = 4
        Me.btnGuardar.Text = "Agregar"
        '
        'BarraAcciones
        '
        Me.BarraAcciones.Dock = System.Windows.Forms.DockStyle.Top
        Me.BarraAcciones.Location = New System.Drawing.Point(2, 2)
        Me.BarraAcciones.Name = "BarraAcciones"
        Me.BarraAcciones.pAgregar = True
        Me.BarraAcciones.pEditar = True
        Me.BarraAcciones.pEliminar = False
        Me.BarraAcciones.Size = New System.Drawing.Size(554, 30)
        Me.BarraAcciones.TabIndex = 3
        '
        'DxValidationProvider1
        '
        Me.DxValidationProvider1.ValidationMode = DevExpress.XtraEditors.DXErrorProvider.ValidationMode.Manual
        '
        'GroupControl1
        '
        Me.GroupControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupControl1.Controls.Add(Me.gcDiasPeriodo)
        Me.GroupControl1.Location = New System.Drawing.Point(573, 12)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.ShowCaption = False
        Me.GroupControl1.Size = New System.Drawing.Size(347, 690)
        Me.GroupControl1.TabIndex = 2
        Me.GroupControl1.Text = "GroupControl1"
        '
        'gcDiasPeriodo
        '
        Me.gcDiasPeriodo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gcDiasPeriodo.Location = New System.Drawing.Point(5, 5)
        Me.gcDiasPeriodo.MainView = Me.gvDiasPeriodo
        Me.gcDiasPeriodo.Name = "gcDiasPeriodo"
        Me.gcDiasPeriodo.Size = New System.Drawing.Size(337, 680)
        Me.gcDiasPeriodo.TabIndex = 0
        Me.gcDiasPeriodo.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvDiasPeriodo})
        '
        'gvDiasPeriodo
        '
        Me.gvDiasPeriodo.GridControl = Me.gcDiasPeriodo
        Me.gvDiasPeriodo.Name = "gvDiasPeriodo"
        Me.gvDiasPeriodo.OptionsView.ShowGroupPanel = False
        '
        'frmConfiguraPeriodos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1202, 714)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.gpoPeriodos)
        Me.Name = "frmConfiguraPeriodos"
        Me.Text = "frmConfiguraPeriodos"
        CType(Me.gcPeriodos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvPeriodos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gpoPeriodos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpoPeriodos.ResumeLayout(False)
        CType(Me.fpPeriodo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.fpPeriodo.ResumeLayout(False)
        CType(Me.fpcPeriodos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.fpcPeriodos.ResumeLayout(False)
        CType(Me.gpoPeriodo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpoPeriodo.ResumeLayout(False)
        Me.gpoPeriodo.PerformLayout()
        CType(Me.ccFechaFin.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ccFechaInicio.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DxValidationProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.gcDiasPeriodo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvDiasPeriodo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gcPeriodos As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvPeriodos As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents gpoPeriodos As DevExpress.XtraEditors.GroupControl
    Friend WithEvents BarraAcciones As Framework2017.BarraAcciones
    Friend WithEvents gpoPeriodo As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btnCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ccFechaInicio As DevExpress.XtraEditors.Controls.CalendarControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ccFechaFin As DevExpress.XtraEditors.Controls.CalendarControl
    Friend WithEvents fpPeriodo As DevExpress.Utils.FlyoutPanel
    Friend WithEvents fpcPeriodos As DevExpress.Utils.FlyoutPanelControl
    Friend WithEvents DxValidationProvider1 As DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents gcDiasPeriodo As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvDiasPeriodo As DevExpress.XtraGrid.Views.Grid.GridView
End Class
