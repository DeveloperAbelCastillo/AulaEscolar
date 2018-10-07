<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAulaAlumnos_PaseLista
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.deFecha = New DevExpress.XtraEditors.DateEdit()
        Me.gcAlumnos = New DevExpress.XtraGrid.GridControl()
        Me.gvAlumnos = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        CType(Me.deFecha.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deFecha.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcAlumnos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvAlumnos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        Me.SuspendLayout()
        '
        'deFecha
        '
        Me.deFecha.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.deFecha.EditValue = Nothing
        Me.deFecha.Location = New System.Drawing.Point(40, 5)
        Me.deFecha.Name = "deFecha"
        Me.deFecha.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deFecha.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deFecha.Size = New System.Drawing.Size(223, 20)
        Me.deFecha.TabIndex = 0
        '
        'gcAlumnos
        '
        Me.gcAlumnos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcAlumnos.Location = New System.Drawing.Point(2, 20)
        Me.gcAlumnos.MainView = Me.gvAlumnos
        Me.gcAlumnos.Name = "gcAlumnos"
        Me.gcAlumnos.Size = New System.Drawing.Size(264, 397)
        Me.gcAlumnos.TabIndex = 2
        Me.gcAlumnos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvAlumnos})
        '
        'gvAlumnos
        '
        Me.gvAlumnos.GridControl = Me.gcAlumnos
        Me.gvAlumnos.Name = "gvAlumnos"
        '
        'GroupControl1
        '
        Me.GroupControl1.CaptionLocation = DevExpress.Utils.Locations.Top
        Me.GroupControl1.Controls.Add(Me.GroupControl2)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Controls.Add(Me.deFecha)
        Me.GroupControl1.Location = New System.Drawing.Point(12, 12)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.ShowCaption = False
        Me.GroupControl1.Size = New System.Drawing.Size(268, 450)
        Me.GroupControl1.TabIndex = 4
        Me.GroupControl1.Text = "Root"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(5, 8)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(29, 13)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Fecha"
        '
        'GroupControl2
        '
        Me.GroupControl2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupControl2.Controls.Add(Me.gcAlumnos)
        Me.GroupControl2.Location = New System.Drawing.Point(0, 31)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(268, 419)
        Me.GroupControl2.TabIndex = 3
        Me.GroupControl2.Text = "Doble clic sobre  alumno para marcar su asistencia"
        '
        'frmAulaAlumnos_PaseLista
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(849, 616)
        Me.Controls.Add(Me.GroupControl1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAulaAlumnos_PaseLista"
        Me.ShowIcon = False
        Me.Text = "Pase de Lista"
        CType(Me.deFecha.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deFecha.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcAlumnos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvAlumnos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents deFecha As DevExpress.XtraEditors.DateEdit
    Friend WithEvents gcAlumnos As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvAlumnos As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
End Class
