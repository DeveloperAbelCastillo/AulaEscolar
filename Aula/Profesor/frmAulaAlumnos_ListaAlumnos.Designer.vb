<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAulaAlumnos_ListaAlumnos
    Inherits DevExpress.XtraEditors.XtraForm

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAulaAlumnos_ListaAlumnos))
        Me.gcAlumnos = New DevExpress.XtraGrid.GridControl()
        Me.gvAlumnos = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.btnGuardar = New DevExpress.XtraEditors.SimpleButton()
        Me.txtNombre = New DevExpress.XtraEditors.TextEdit()
        Me.txtMaterno = New DevExpress.XtraEditors.TextEdit()
        Me.txtPaterno = New DevExpress.XtraEditors.TextEdit()
        Me.DxValidationProvider1 = New DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(Me.components)
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.fpAcciones = New DevExpress.Utils.FlyoutPanel()
        Me.fpcAcciones = New DevExpress.Utils.FlyoutPanelControl()
        Me.gpoAccion = New DevExpress.XtraEditors.GroupControl()
        Me.btnCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.BarraAcciones1 = New Framework2017.BarraAcciones()
        CType(Me.gcAlumnos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvAlumnos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNombre.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMaterno.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPaterno.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DxValidationProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.fpAcciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.fpAcciones.SuspendLayout()
        CType(Me.fpcAcciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.fpcAcciones.SuspendLayout()
        CType(Me.gpoAccion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpoAccion.SuspendLayout()
        Me.SuspendLayout()
        '
        'gcAlumnos
        '
        Me.gcAlumnos.Location = New System.Drawing.Point(1, 31)
        Me.gcAlumnos.MainView = Me.gvAlumnos
        Me.gcAlumnos.Name = "gcAlumnos"
        Me.gcAlumnos.Size = New System.Drawing.Size(369, 534)
        Me.gcAlumnos.TabIndex = 0
        Me.gcAlumnos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvAlumnos})
        '
        'gvAlumnos
        '
        Me.gvAlumnos.GridControl = Me.gcAlumnos
        Me.gvAlumnos.Name = "gvAlumnos"
        '
        'btnGuardar
        '
        Me.btnGuardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGuardar.AutoSize = True
        Me.btnGuardar.ImageOptions.Image = CType(resources.GetObject("btnGuardar.ImageOptions.Image"), System.Drawing.Image)
        Me.btnGuardar.Location = New System.Drawing.Point(288, 95)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(67, 22)
        Me.btnGuardar.TabIndex = 6
        Me.btnGuardar.Text = "Agregar"
        '
        'txtNombre
        '
        Me.txtNombre.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNombre.Location = New System.Drawing.Point(97, 22)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(258, 20)
        Me.txtNombre.TabIndex = 3
        '
        'txtMaterno
        '
        Me.txtMaterno.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMaterno.Location = New System.Drawing.Point(97, 70)
        Me.txtMaterno.Name = "txtMaterno"
        Me.txtMaterno.Size = New System.Drawing.Size(258, 20)
        Me.txtMaterno.TabIndex = 5
        '
        'txtPaterno
        '
        Me.txtPaterno.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPaterno.Location = New System.Drawing.Point(97, 46)
        Me.txtPaterno.Name = "txtPaterno"
        Me.txtPaterno.Size = New System.Drawing.Size(258, 20)
        Me.txtPaterno.TabIndex = 4
        '
        'GroupControl1
        '
        Me.GroupControl1.CaptionLocation = DevExpress.Utils.Locations.Top
        Me.GroupControl1.Controls.Add(Me.fpAcciones)
        Me.GroupControl1.Controls.Add(Me.gcAlumnos)
        Me.GroupControl1.Controls.Add(Me.BarraAcciones1)
        Me.GroupControl1.Location = New System.Drawing.Point(12, 12)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.ShowCaption = False
        Me.GroupControl1.Size = New System.Drawing.Size(371, 564)
        Me.GroupControl1.TabIndex = 4
        Me.GroupControl1.Text = "LayoutControlGroup1"
        '
        'fpAcciones
        '
        Me.fpAcciones.Controls.Add(Me.fpcAcciones)
        Me.fpAcciones.Location = New System.Drawing.Point(0, 31)
        Me.fpAcciones.Name = "fpAcciones"
        Me.fpAcciones.OwnerControl = Me.gcAlumnos
        Me.fpAcciones.Size = New System.Drawing.Size(370, 132)
        Me.fpAcciones.TabIndex = 3
        '
        'fpcAcciones
        '
        Me.fpcAcciones.Controls.Add(Me.gpoAccion)
        Me.fpcAcciones.Dock = System.Windows.Forms.DockStyle.Fill
        Me.fpcAcciones.FlyoutPanel = Me.fpAcciones
        Me.fpcAcciones.Location = New System.Drawing.Point(0, 0)
        Me.fpcAcciones.Name = "fpcAcciones"
        Me.fpcAcciones.Size = New System.Drawing.Size(370, 132)
        Me.fpcAcciones.TabIndex = 0
        '
        'gpoAccion
        '
        Me.gpoAccion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gpoAccion.CaptionLocation = DevExpress.Utils.Locations.Top
        Me.gpoAccion.Controls.Add(Me.btnCancelar)
        Me.gpoAccion.Controls.Add(Me.LabelControl1)
        Me.gpoAccion.Controls.Add(Me.txtNombre)
        Me.gpoAccion.Controls.Add(Me.LabelControl2)
        Me.gpoAccion.Controls.Add(Me.txtMaterno)
        Me.gpoAccion.Controls.Add(Me.LabelControl3)
        Me.gpoAccion.Controls.Add(Me.txtPaterno)
        Me.gpoAccion.Controls.Add(Me.btnGuardar)
        Me.gpoAccion.Location = New System.Drawing.Point(5, 5)
        Me.gpoAccion.Name = "gpoAccion"
        Me.gpoAccion.Size = New System.Drawing.Size(360, 122)
        Me.gpoAccion.TabIndex = 0
        Me.gpoAccion.Text = "Registrar Alumno"
        '
        'btnCancelar
        '
        Me.btnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnCancelar.AutoSize = True
        Me.btnCancelar.ImageOptions.Image = CType(resources.GetObject("btnCancelar.ImageOptions.Image"), System.Drawing.Image)
        Me.btnCancelar.Location = New System.Drawing.Point(5, 95)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(70, 22)
        Me.btnCancelar.TabIndex = 8
        Me.btnCancelar.Text = "Cancelar"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(54, 25)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(37, 13)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Nombre"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(11, 73)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(80, 13)
        Me.LabelControl2.TabIndex = 4
        Me.LabelControl2.Text = "Apellido Materno"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(13, 49)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(78, 13)
        Me.LabelControl3.TabIndex = 6
        Me.LabelControl3.Text = "Apellido Paterno"
        '
        'BarraAcciones1
        '
        Me.BarraAcciones1.Location = New System.Drawing.Point(1, 1)
        Me.BarraAcciones1.Name = "BarraAcciones1"
        Me.BarraAcciones1.pAgregar = True
        Me.BarraAcciones1.pEditar = True
        Me.BarraAcciones1.pEliminar = False
        Me.BarraAcciones1.Size = New System.Drawing.Size(369, 30)
        Me.BarraAcciones1.TabIndex = 2
        '
        'frmAulaAlumnos_ListaAlumnos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(943, 584)
        Me.Controls.Add(Me.GroupControl1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAulaAlumnos_ListaAlumnos"
        Me.ShowIcon = False
        Me.Text = "Lista de Alumnos"
        CType(Me.gcAlumnos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvAlumnos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNombre.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMaterno.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPaterno.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DxValidationProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.fpAcciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.fpAcciones.ResumeLayout(False)
        CType(Me.fpcAcciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.fpcAcciones.ResumeLayout(False)
        CType(Me.gpoAccion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpoAccion.ResumeLayout(False)
        Me.gpoAccion.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gcAlumnos As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvAlumnos As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txtMaterno As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtPaterno As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtNombre As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents DxValidationProvider1 As DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents gpoAccion As DevExpress.XtraEditors.GroupControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents BarraAcciones1 As Framework2017.BarraAcciones
    Friend WithEvents fpAcciones As DevExpress.Utils.FlyoutPanel
    Friend WithEvents fpcAcciones As DevExpress.Utils.FlyoutPanelControl
    Friend WithEvents btnCancelar As DevExpress.XtraEditors.SimpleButton
End Class
