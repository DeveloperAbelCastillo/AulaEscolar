<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMaterias
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMaterias))
        Me.gcMaterias = New DevExpress.XtraGrid.GridControl()
        Me.gvMaterias = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.txtMateria = New DevExpress.XtraEditors.TextEdit()
        Me.btnGuardar = New DevExpress.XtraEditors.SimpleButton()
        Me.DxValidationProvider1 = New DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(Me.components)
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.fpMaterias = New DevExpress.Utils.FlyoutPanel()
        Me.fpcMaterias = New DevExpress.Utils.FlyoutPanelControl()
        Me.gpoAccion = New DevExpress.XtraEditors.GroupControl()
        Me.btnCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.cboColor = New DevExpress.XtraEditors.ColorPickEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.BarraAcciones = New Framework2017.BarraAcciones()
        CType(Me.gcMaterias, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvMaterias, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMateria.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DxValidationProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.fpMaterias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.fpMaterias.SuspendLayout()
        CType(Me.fpcMaterias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.fpcMaterias.SuspendLayout()
        CType(Me.gpoAccion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpoAccion.SuspendLayout()
        CType(Me.cboColor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gcMaterias
        '
        Me.gcMaterias.Location = New System.Drawing.Point(1, 31)
        Me.gcMaterias.MainView = Me.gvMaterias
        Me.gcMaterias.Name = "gcMaterias"
        Me.gcMaterias.Size = New System.Drawing.Size(320, 428)
        Me.gcMaterias.TabIndex = 4
        Me.gcMaterias.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvMaterias})
        '
        'gvMaterias
        '
        Me.gvMaterias.GridControl = Me.gcMaterias
        Me.gvMaterias.Name = "gvMaterias"
        Me.gvMaterias.OptionsView.ShowGroupPanel = False
        '
        'txtMateria
        '
        Me.txtMateria.Location = New System.Drawing.Point(47, 20)
        Me.txtMateria.Name = "txtMateria"
        Me.txtMateria.Size = New System.Drawing.Size(248, 20)
        Me.txtMateria.TabIndex = 1
        '
        'btnGuardar
        '
        Me.btnGuardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGuardar.ImageOptions.Image = CType(resources.GetObject("btnGuardar.ImageOptions.Image"), System.Drawing.Image)
        Me.btnGuardar.Location = New System.Drawing.Point(219, 72)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(76, 22)
        Me.btnGuardar.TabIndex = 3
        Me.btnGuardar.Text = "Agregar"
        '
        'DxValidationProvider1
        '
        Me.DxValidationProvider1.ValidationMode = DevExpress.XtraEditors.DXErrorProvider.ValidationMode.Manual
        '
        'GroupControl1
        '
        Me.GroupControl1.CaptionLocation = DevExpress.Utils.Locations.Top
        Me.GroupControl1.Controls.Add(Me.fpMaterias)
        Me.GroupControl1.Controls.Add(Me.BarraAcciones)
        Me.GroupControl1.Controls.Add(Me.gcMaterias)
        Me.GroupControl1.Location = New System.Drawing.Point(12, 12)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.ShowCaption = False
        Me.GroupControl1.Size = New System.Drawing.Size(322, 459)
        Me.GroupControl1.TabIndex = 5
        Me.GroupControl1.Text = "LayoutControlGroup1"
        '
        'fpMaterias
        '
        Me.fpMaterias.Controls.Add(Me.fpcMaterias)
        Me.fpMaterias.Location = New System.Drawing.Point(7, 99)
        Me.fpMaterias.Name = "fpMaterias"
        Me.fpMaterias.OptionsButtonPanel.ButtonPanelContentAlignment = System.Drawing.ContentAlignment.TopCenter
        Me.fpMaterias.OptionsButtonPanel.ButtonPanelLocation = DevExpress.Utils.FlyoutPanelButtonPanelLocation.Top
        Me.fpMaterias.OwnerControl = Me.gcMaterias
        Me.fpMaterias.Size = New System.Drawing.Size(310, 112)
        Me.fpMaterias.TabIndex = 6
        '
        'fpcMaterias
        '
        Me.fpcMaterias.Controls.Add(Me.gpoAccion)
        Me.fpcMaterias.Dock = System.Windows.Forms.DockStyle.Fill
        Me.fpcMaterias.FlyoutPanel = Me.fpMaterias
        Me.fpcMaterias.Location = New System.Drawing.Point(0, 0)
        Me.fpcMaterias.Name = "fpcMaterias"
        Me.fpcMaterias.Size = New System.Drawing.Size(310, 112)
        Me.fpcMaterias.TabIndex = 0
        '
        'gpoAccion
        '
        Me.gpoAccion.CaptionLocation = DevExpress.Utils.Locations.Top
        Me.gpoAccion.Controls.Add(Me.btnCancelar)
        Me.gpoAccion.Controls.Add(Me.cboColor)
        Me.gpoAccion.Controls.Add(Me.LabelControl2)
        Me.gpoAccion.Controls.Add(Me.LabelControl1)
        Me.gpoAccion.Controls.Add(Me.txtMateria)
        Me.gpoAccion.Controls.Add(Me.btnGuardar)
        Me.gpoAccion.Location = New System.Drawing.Point(5, 5)
        Me.gpoAccion.Name = "gpoAccion"
        Me.gpoAccion.Size = New System.Drawing.Size(302, 102)
        Me.gpoAccion.TabIndex = 4
        Me.gpoAccion.Text = "Agregar Materia"
        '
        'btnCancelar
        '
        Me.btnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnCancelar.ImageOptions.Image = CType(resources.GetObject("btnCancelar.ImageOptions.Image"), System.Drawing.Image)
        Me.btnCancelar.Location = New System.Drawing.Point(5, 75)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(76, 22)
        Me.btnCancelar.TabIndex = 7
        Me.btnCancelar.Text = "Cancelar"
        '
        'cboColor
        '
        Me.cboColor.EditValue = System.Drawing.Color.Empty
        Me.cboColor.Location = New System.Drawing.Point(47, 46)
        Me.cboColor.Name = "cboColor"
        Me.cboColor.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboColor.Properties.ShowSystemColors = False
        Me.cboColor.Properties.ShowWebColors = False
        Me.cboColor.Size = New System.Drawing.Size(133, 20)
        Me.cboColor.TabIndex = 2
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(16, 49)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(25, 13)
        Me.LabelControl2.TabIndex = 6
        Me.LabelControl2.Text = "Color"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(5, 23)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(36, 13)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Materia"
        '
        'BarraAcciones
        '
        Me.BarraAcciones.Location = New System.Drawing.Point(1, 1)
        Me.BarraAcciones.Name = "BarraAcciones"
        Me.BarraAcciones.pAgregar = True
        Me.BarraAcciones.pEditar = True
        Me.BarraAcciones.pEliminar = False
        Me.BarraAcciones.Size = New System.Drawing.Size(320, 30)
        Me.BarraAcciones.TabIndex = 5
        '
        'frmMaterias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(674, 511)
        Me.Controls.Add(Me.GroupControl1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMaterias"
        Me.ShowIcon = False
        Me.Text = "Materias"
        CType(Me.gcMaterias, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvMaterias, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMateria.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DxValidationProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.fpMaterias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.fpMaterias.ResumeLayout(False)
        CType(Me.fpcMaterias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.fpcMaterias.ResumeLayout(False)
        CType(Me.gpoAccion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpoAccion.ResumeLayout(False)
        Me.gpoAccion.PerformLayout()
        CType(Me.cboColor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gcMaterias As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvMaterias As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents btnGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtMateria As DevExpress.XtraEditors.TextEdit
    Friend WithEvents DxValidationProvider1 As DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents gpoAccion As DevExpress.XtraEditors.GroupControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cboColor As DevExpress.XtraEditors.ColorPickEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents BarraAcciones As Framework2017.BarraAcciones
    Friend WithEvents fpMaterias As DevExpress.Utils.FlyoutPanel
    Friend WithEvents fpcMaterias As DevExpress.Utils.FlyoutPanelControl
    Friend WithEvents btnCancelar As DevExpress.XtraEditors.SimpleButton
End Class
