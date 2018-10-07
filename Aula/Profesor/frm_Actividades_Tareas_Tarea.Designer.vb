<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_Actividades_Tareas_Tarea
    Inherits System.Windows.Forms.Form

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Actividades_Tareas_Tarea))
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.cboHorasRevision = New DevExpress.XtraEditors.TimeEdit()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.cboHoraEntrega = New DevExpress.XtraEditors.TimeEdit()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.txtRutaArchivo = New DevExpress.XtraEditors.TextEdit()
        Me.btnBuscaArchivo = New DevExpress.XtraEditors.SimpleButton()
        Me.btnGuardar = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.cboFechaEntrega = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txtTema = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txtDescripcion = New DevExpress.XtraEditors.MemoEdit()
        Me.cboMateria = New DevExpress.XtraEditors.LookUpEdit()
        Me.DxValidationProvider1 = New DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(Me.components)
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.cboHorasRevision.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboHoraEntrega.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRutaArchivo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboFechaEntrega.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboFechaEntrega.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTema.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescripcion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboMateria.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DxValidationProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupControl1
        '
        Me.GroupControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupControl1.Controls.Add(Me.cboHorasRevision)
        Me.GroupControl1.Controls.Add(Me.LabelControl6)
        Me.GroupControl1.Controls.Add(Me.cboHoraEntrega)
        Me.GroupControl1.Controls.Add(Me.LabelControl5)
        Me.GroupControl1.Controls.Add(Me.txtRutaArchivo)
        Me.GroupControl1.Controls.Add(Me.btnBuscaArchivo)
        Me.GroupControl1.Controls.Add(Me.btnGuardar)
        Me.GroupControl1.Controls.Add(Me.LabelControl4)
        Me.GroupControl1.Controls.Add(Me.cboFechaEntrega)
        Me.GroupControl1.Controls.Add(Me.LabelControl3)
        Me.GroupControl1.Controls.Add(Me.LabelControl2)
        Me.GroupControl1.Controls.Add(Me.txtTema)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Controls.Add(Me.txtDescripcion)
        Me.GroupControl1.Controls.Add(Me.cboMateria)
        Me.GroupControl1.Location = New System.Drawing.Point(12, 12)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(645, 444)
        Me.GroupControl1.TabIndex = 0
        Me.GroupControl1.Text = "Informacion de la tarea"
        '
        'cboHorasRevision
        '
        Me.cboHorasRevision.EditValue = New Date(2017, 5, 14, 0, 0, 0, 0)
        Me.cboHorasRevision.Location = New System.Drawing.Point(348, 49)
        Me.cboHorasRevision.Name = "cboHorasRevision"
        Me.cboHorasRevision.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboHorasRevision.Properties.Mask.EditMask = "t"
        Me.cboHorasRevision.Size = New System.Drawing.Size(72, 20)
        Me.cboHorasRevision.TabIndex = 4
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(265, 52)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(77, 13)
        Me.LabelControl6.TabIndex = 15
        Me.LabelControl6.Text = "Timepo Revision"
        '
        'cboHoraEntrega
        '
        Me.cboHoraEntrega.EditValue = New Date(2017, 5, 14, 0, 0, 0, 0)
        Me.cboHoraEntrega.Location = New System.Drawing.Point(187, 49)
        Me.cboHoraEntrega.Name = "cboHoraEntrega"
        Me.cboHoraEntrega.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboHoraEntrega.Properties.Mask.EditMask = "t"
        Me.cboHoraEntrega.Size = New System.Drawing.Size(72, 20)
        Me.cboHoraEntrega.TabIndex = 3
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(39, 392)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(36, 13)
        Me.LabelControl5.TabIndex = 13
        Me.LabelControl5.Text = "Archivo"
        '
        'txtRutaArchivo
        '
        Me.txtRutaArchivo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtRutaArchivo.Cursor = System.Windows.Forms.Cursors.Default
        Me.txtRutaArchivo.Location = New System.Drawing.Point(81, 389)
        Me.txtRutaArchivo.Name = "txtRutaArchivo"
        Me.txtRutaArchivo.Properties.ReadOnly = True
        Me.txtRutaArchivo.Size = New System.Drawing.Size(529, 20)
        Me.txtRutaArchivo.TabIndex = 11
        '
        'btnBuscaArchivo
        '
        Me.btnBuscaArchivo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBuscaArchivo.ImageOptions.Image = CType(resources.GetObject("btnBuscaArchivo.ImageOptions.Image"), System.Drawing.Image)
        Me.btnBuscaArchivo.Location = New System.Drawing.Point(616, 387)
        Me.btnBuscaArchivo.Name = "btnBuscaArchivo"
        Me.btnBuscaArchivo.Size = New System.Drawing.Size(24, 22)
        Me.btnBuscaArchivo.TabIndex = 7
        '
        'btnGuardar
        '
        Me.btnGuardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGuardar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.btnGuardar.ImageOptions.Image = CType(resources.GetObject("btnGuardar.ImageOptions.Image"), System.Drawing.Image)
        Me.btnGuardar.Location = New System.Drawing.Point(565, 416)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardar.TabIndex = 8
        Me.btnGuardar.Text = "Guardar"
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(426, 52)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(36, 13)
        Me.LabelControl4.TabIndex = 6
        Me.LabelControl4.Text = "Materia"
        '
        'cboFechaEntrega
        '
        Me.cboFechaEntrega.EditValue = Nothing
        Me.cboFechaEntrega.Location = New System.Drawing.Point(81, 49)
        Me.cboFechaEntrega.Name = "cboFechaEntrega"
        Me.cboFechaEntrega.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboFechaEntrega.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboFechaEntrega.Size = New System.Drawing.Size(100, 20)
        Me.cboFechaEntrega.TabIndex = 2
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(5, 52)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(70, 13)
        Me.LabelControl3.TabIndex = 4
        Me.LabelControl3.Text = "Fecha Entrega"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(21, 77)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(54, 13)
        Me.LabelControl2.TabIndex = 2
        Me.LabelControl2.Text = "Descripcion"
        '
        'txtTema
        '
        Me.txtTema.Location = New System.Drawing.Point(81, 23)
        Me.txtTema.Name = "txtTema"
        Me.txtTema.Size = New System.Drawing.Size(559, 20)
        Me.txtTema.TabIndex = 1
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(49, 26)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(26, 13)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Tema"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(81, 75)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(559, 308)
        Me.txtDescripcion.TabIndex = 6
        '
        'cboMateria
        '
        Me.cboMateria.Location = New System.Drawing.Point(468, 49)
        Me.cboMateria.Name = "cboMateria"
        Me.cboMateria.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboMateria.Properties.NullText = ""
        Me.cboMateria.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.cboMateria.Properties.PopupSizeable = False
        Me.cboMateria.Size = New System.Drawing.Size(172, 20)
        Me.cboMateria.TabIndex = 5
        '
        'DxValidationProvider1
        '
        Me.DxValidationProvider1.ValidationMode = DevExpress.XtraEditors.DXErrorProvider.ValidationMode.Manual
        '
        'frm_Actividades_Tareas_Tarea
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(669, 468)
        Me.Controls.Add(Me.GroupControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_Actividades_Tareas_Tarea"
        Me.ShowIcon = False
        Me.Text = "Tarea"
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.cboHorasRevision.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboHoraEntrega.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRutaArchivo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboFechaEntrega.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboFechaEntrega.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTema.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescripcion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboMateria.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DxValidationProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtTema As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtDescripcion As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cboFechaEntrega As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtRutaArchivo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnBuscaArchivo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cboMateria As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cboHorasRevision As DevExpress.XtraEditors.TimeEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cboHoraEntrega As DevExpress.XtraEditors.TimeEdit
    Friend WithEvents DxValidationProvider1 As DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider
End Class
