<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmConfiguracionGeneral
    Inherits DevExpress.XtraEditors.XtraForm

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConfiguracionGeneral))
        Me.btnGuardar = New DevExpress.XtraEditors.SimpleButton()
        Me.peLogo = New DevExpress.XtraEditors.PictureEdit()
        Me.txtRutaLogo = New DevExpress.XtraEditors.TextEdit()
        Me.txtTelefonoEscuela = New DevExpress.XtraEditors.TextEdit()
        Me.txtDireccionEscuela = New DevExpress.XtraEditors.TextEdit()
        Me.txtNombreEscuela = New DevExpress.XtraEditors.TextEdit()
        Me.btnBuscaLogo = New DevExpress.XtraEditors.SimpleButton()
        Me.txtMaternoUsuario = New DevExpress.XtraEditors.TextEdit()
        Me.txtPaternoUsuario = New DevExpress.XtraEditors.TextEdit()
        Me.txtNombreUsuario = New DevExpress.XtraEditors.TextEdit()
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.DxValidationProvider1 = New DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(Me.components)
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.GroupControl4 = New DevExpress.XtraEditors.GroupControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        CType(Me.peLogo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRutaLogo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTelefonoEscuela.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDireccionEscuela.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNombreEscuela.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMaternoUsuario.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPaternoUsuario.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNombreUsuario.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DxValidationProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl4.SuspendLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnGuardar
        '
        Me.btnGuardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGuardar.Image = CType(resources.GetObject("btnGuardar.Image"), System.Drawing.Image)
        Me.btnGuardar.Location = New System.Drawing.Point(211, 406)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(128, 22)
        Me.btnGuardar.TabIndex = 9
        Me.btnGuardar.Text = "Guardar"
        '
        'peLogo
        '
        Me.peLogo.Location = New System.Drawing.Point(94, 120)
        Me.peLogo.Name = "peLogo"
        Me.peLogo.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.[Auto]
        Me.peLogo.Properties.ZoomAccelerationFactor = 1.0R
        Me.peLogo.Size = New System.Drawing.Size(159, 152)
        Me.peLogo.TabIndex = 9
        '
        'txtRutaLogo
        '
        Me.txtRutaLogo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtRutaLogo.Cursor = System.Windows.Forms.Cursors.Default
        Me.txtRutaLogo.Location = New System.Drawing.Point(55, 94)
        Me.txtRutaLogo.Name = "txtRutaLogo"
        Me.txtRutaLogo.Properties.ReadOnly = True
        Me.txtRutaLogo.Size = New System.Drawing.Size(244, 20)
        Me.txtRutaLogo.TabIndex = 7
        '
        'txtTelefonoEscuela
        '
        Me.txtTelefonoEscuela.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTelefonoEscuela.Cursor = System.Windows.Forms.Cursors.Default
        Me.txtTelefonoEscuela.Location = New System.Drawing.Point(55, 70)
        Me.txtTelefonoEscuela.Name = "txtTelefonoEscuela"
        Me.txtTelefonoEscuela.Size = New System.Drawing.Size(274, 20)
        Me.txtTelefonoEscuela.TabIndex = 5
        '
        'txtDireccionEscuela
        '
        Me.txtDireccionEscuela.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDireccionEscuela.Cursor = System.Windows.Forms.Cursors.Default
        Me.txtDireccionEscuela.Location = New System.Drawing.Point(55, 46)
        Me.txtDireccionEscuela.Name = "txtDireccionEscuela"
        Me.txtDireccionEscuela.Size = New System.Drawing.Size(274, 20)
        Me.txtDireccionEscuela.TabIndex = 4
        '
        'txtNombreEscuela
        '
        Me.txtNombreEscuela.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNombreEscuela.Cursor = System.Windows.Forms.Cursors.Default
        Me.txtNombreEscuela.Location = New System.Drawing.Point(55, 22)
        Me.txtNombreEscuela.Name = "txtNombreEscuela"
        Me.txtNombreEscuela.Size = New System.Drawing.Size(274, 20)
        Me.txtNombreEscuela.TabIndex = 3
        '
        'btnBuscaLogo
        '
        Me.btnBuscaLogo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBuscaLogo.Image = CType(resources.GetObject("btnBuscaLogo.Image"), System.Drawing.Image)
        Me.btnBuscaLogo.Location = New System.Drawing.Point(305, 96)
        Me.btnBuscaLogo.Name = "btnBuscaLogo"
        Me.btnBuscaLogo.Size = New System.Drawing.Size(24, 22)
        Me.btnBuscaLogo.TabIndex = 8
        '
        'txtMaternoUsuario
        '
        Me.txtMaternoUsuario.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMaternoUsuario.Cursor = System.Windows.Forms.Cursors.Default
        Me.txtMaternoUsuario.Location = New System.Drawing.Point(55, 68)
        Me.txtMaternoUsuario.Name = "txtMaternoUsuario"
        Me.txtMaternoUsuario.Size = New System.Drawing.Size(274, 20)
        Me.txtMaternoUsuario.TabIndex = 5
        '
        'txtPaternoUsuario
        '
        Me.txtPaternoUsuario.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPaternoUsuario.Cursor = System.Windows.Forms.Cursors.Default
        Me.txtPaternoUsuario.Location = New System.Drawing.Point(55, 44)
        Me.txtPaternoUsuario.Name = "txtPaternoUsuario"
        Me.txtPaternoUsuario.Size = New System.Drawing.Size(274, 20)
        Me.txtPaternoUsuario.TabIndex = 4
        '
        'txtNombreUsuario
        '
        Me.txtNombreUsuario.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNombreUsuario.Cursor = System.Windows.Forms.Cursors.Default
        Me.txtNombreUsuario.Location = New System.Drawing.Point(55, 20)
        Me.txtNombreUsuario.Name = "txtNombreUsuario"
        Me.txtNombreUsuario.Size = New System.Drawing.Size(274, 20)
        Me.txtNombreUsuario.TabIndex = 3
        '
        'OpenFileDialog
        '
        Me.OpenFileDialog.FileName = "OpenFileDialog"
        '
        'DxValidationProvider1
        '
        Me.DxValidationProvider1.ValidateHiddenControls = False
        Me.DxValidationProvider1.ValidationMode = DevExpress.XtraEditors.DXErrorProvider.ValidationMode.Manual
        '
        'GroupControl2
        '
        Me.GroupControl2.CaptionLocation = DevExpress.Utils.Locations.Top
        Me.GroupControl2.Controls.Add(Me.btnGuardar)
        Me.GroupControl2.Controls.Add(Me.GroupControl3)
        Me.GroupControl2.Controls.Add(Me.GroupControl4)
        Me.GroupControl2.Location = New System.Drawing.Point(5, 5)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(344, 433)
        Me.GroupControl2.TabIndex = 0
        Me.GroupControl2.Text = "Datos Generales"
        '
        'GroupControl3
        '
        Me.GroupControl3.CaptionLocation = DevExpress.Utils.Locations.Top
        Me.GroupControl3.Controls.Add(Me.peLogo)
        Me.GroupControl3.Controls.Add(Me.LabelControl2)
        Me.GroupControl3.Controls.Add(Me.txtRutaLogo)
        Me.GroupControl3.Controls.Add(Me.LabelControl3)
        Me.GroupControl3.Controls.Add(Me.txtTelefonoEscuela)
        Me.GroupControl3.Controls.Add(Me.LabelControl4)
        Me.GroupControl3.Controls.Add(Me.txtDireccionEscuela)
        Me.GroupControl3.Controls.Add(Me.LabelControl5)
        Me.GroupControl3.Controls.Add(Me.txtNombreEscuela)
        Me.GroupControl3.Controls.Add(Me.btnBuscaLogo)
        Me.GroupControl3.Location = New System.Drawing.Point(5, 125)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.Size = New System.Drawing.Size(334, 277)
        Me.GroupControl3.TabIndex = 10
        Me.GroupControl3.Text = "Informacion de la Escuela"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(26, 97)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(23, 13)
        Me.LabelControl2.TabIndex = 10
        Me.LabelControl2.Text = "Logo"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(8, 73)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(42, 13)
        Me.LabelControl3.TabIndex = 11
        Me.LabelControl3.Text = "Telefono"
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(7, 49)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(43, 13)
        Me.LabelControl4.TabIndex = 12
        Me.LabelControl4.Text = "Direccion"
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(13, 25)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(37, 13)
        Me.LabelControl5.TabIndex = 13
        Me.LabelControl5.Text = "Nombre"
        '
        'GroupControl4
        '
        Me.GroupControl4.CaptionLocation = DevExpress.Utils.Locations.Top
        Me.GroupControl4.Controls.Add(Me.LabelControl6)
        Me.GroupControl4.Controls.Add(Me.txtMaternoUsuario)
        Me.GroupControl4.Controls.Add(Me.LabelControl7)
        Me.GroupControl4.Controls.Add(Me.txtPaternoUsuario)
        Me.GroupControl4.Controls.Add(Me.LabelControl8)
        Me.GroupControl4.Controls.Add(Me.txtNombreUsuario)
        Me.GroupControl4.Location = New System.Drawing.Point(5, 23)
        Me.GroupControl4.Name = "GroupControl4"
        Me.GroupControl4.Size = New System.Drawing.Size(334, 96)
        Me.GroupControl4.TabIndex = 11
        Me.GroupControl4.Text = "Nombre y Apellidos"
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(9, 71)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(40, 13)
        Me.LabelControl6.TabIndex = 0
        Me.LabelControl6.Text = "Materno"
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(12, 47)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(38, 13)
        Me.LabelControl7.TabIndex = 6
        Me.LabelControl7.Text = "Paterno"
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(12, 23)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(37, 13)
        Me.LabelControl8.TabIndex = 7
        Me.LabelControl8.Text = "Nombre"
        '
        'GroupControl1
        '
        Me.GroupControl1.CaptionLocation = DevExpress.Utils.Locations.Top
        Me.GroupControl1.Controls.Add(Me.GroupControl2)
        Me.GroupControl1.Location = New System.Drawing.Point(12, 12)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.ShowCaption = False
        Me.GroupControl1.Size = New System.Drawing.Size(354, 443)
        Me.GroupControl1.TabIndex = 5
        Me.GroupControl1.Text = "LayoutControlGroup1"
        '
        'frmConfiguracionGeneral
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(767, 545)
        Me.Controls.Add(Me.GroupControl1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmConfiguracionGeneral"
        Me.ShowIcon = False
        Me.Text = "Configuracion de Usuario"
        CType(Me.peLogo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRutaLogo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTelefonoEscuela.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDireccionEscuela.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNombreEscuela.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMaternoUsuario.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPaternoUsuario.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNombreUsuario.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DxValidationProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        Me.GroupControl3.PerformLayout()
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl4.ResumeLayout(False)
        Me.GroupControl4.PerformLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtNombreUsuario As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtMaternoUsuario As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtPaternoUsuario As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtTelefonoEscuela As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtDireccionEscuela As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtNombreEscuela As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtRutaLogo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents peLogo As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents btnBuscaLogo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents OpenFileDialog As OpenFileDialog
    Friend WithEvents btnGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents DxValidationProvider1 As DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupControl4 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
End Class
