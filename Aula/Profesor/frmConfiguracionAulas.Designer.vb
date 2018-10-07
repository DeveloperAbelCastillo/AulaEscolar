<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmConfiguracionAulas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConfiguracionAulas))
        Dim ConditionValidationRule2 As DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule = New DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule()
        Me.btnGuardar = New DevExpress.XtraEditors.SimpleButton()
        Me.gcAulas = New DevExpress.XtraGrid.GridControl()
        Me.gvAulas = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.DxValidationProvider1 = New DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(Me.components)
        Me.cboGrupo = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.fpAulas = New DevExpress.Utils.FlyoutPanel()
        Me.fpcAulas = New DevExpress.Utils.FlyoutPanelControl()
        Me.gpoAccion = New DevExpress.XtraEditors.GroupControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.cboGrado = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.BarraAcciones = New Framework2017.BarraAcciones()
        CType(Me.gcAulas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvAulas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DxValidationProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboGrupo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.fpAulas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.fpAulas.SuspendLayout()
        CType(Me.fpcAulas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.fpcAulas.SuspendLayout()
        CType(Me.gpoAccion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpoAccion.SuspendLayout()
        CType(Me.cboGrado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnGuardar
        '
        Me.btnGuardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGuardar.AutoSize = True
        Me.btnGuardar.ImageOptions.Image = CType(resources.GetObject("btnGuardar.ImageOptions.Image"), System.Drawing.Image)
        Me.btnGuardar.Location = New System.Drawing.Point(174, 49)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(67, 22)
        Me.btnGuardar.TabIndex = 4
        Me.btnGuardar.Text = "Agregar"
        '
        'gcAulas
        '
        Me.gcAulas.Location = New System.Drawing.Point(1, 31)
        Me.gcAulas.MainView = Me.gvAulas
        Me.gcAulas.Name = "gcAulas"
        Me.gcAulas.Size = New System.Drawing.Size(255, 312)
        Me.gcAulas.TabIndex = 1
        Me.gcAulas.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvAulas})
        '
        'gvAulas
        '
        Me.gvAulas.GridControl = Me.gcAulas
        Me.gvAulas.Name = "gvAulas"
        Me.gvAulas.OptionsView.ShowGroupPanel = False
        '
        'DxValidationProvider1
        '
        Me.DxValidationProvider1.ValidationMode = DevExpress.XtraEditors.DXErrorProvider.ValidationMode.Manual
        '
        'cboGrupo
        '
        Me.cboGrupo.EditValue = "A"
        Me.cboGrupo.Location = New System.Drawing.Point(159, 23)
        Me.cboGrupo.Name = "cboGrupo"
        Me.cboGrupo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboGrupo.Properties.Items.AddRange(New Object() {"A", "B", "C", "D", "E", "F"})
        Me.cboGrupo.Size = New System.Drawing.Size(71, 20)
        Me.cboGrupo.TabIndex = 10
        ConditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.AnyOf
        ConditionValidationRule2.ErrorText = "This value is not valid"
        ConditionValidationRule2.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Information
        Me.DxValidationProvider1.SetValidationRule(Me.cboGrupo, ConditionValidationRule2)
        '
        'GroupControl1
        '
        Me.GroupControl1.CaptionLocation = DevExpress.Utils.Locations.Top
        Me.GroupControl1.Controls.Add(Me.fpAulas)
        Me.GroupControl1.Controls.Add(Me.BarraAcciones)
        Me.GroupControl1.Controls.Add(Me.gcAulas)
        Me.GroupControl1.Location = New System.Drawing.Point(12, 12)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.ShowCaption = False
        Me.GroupControl1.Size = New System.Drawing.Size(257, 344)
        Me.GroupControl1.TabIndex = 3
        Me.GroupControl1.Text = "LayoutControlGroup1"
        '
        'fpAulas
        '
        Me.fpAulas.Controls.Add(Me.fpcAulas)
        Me.fpAulas.Location = New System.Drawing.Point(1, 31)
        Me.fpAulas.Name = "fpAulas"
        Me.fpAulas.OptionsButtonPanel.ButtonPanelContentAlignment = System.Drawing.ContentAlignment.TopCenter
        Me.fpAulas.OptionsButtonPanel.ButtonPanelLocation = DevExpress.Utils.FlyoutPanelButtonPanelLocation.Top
        Me.fpAulas.OwnerControl = Me.gcAulas
        Me.fpAulas.Size = New System.Drawing.Size(256, 86)
        Me.fpAulas.TabIndex = 7
        '
        'fpcAulas
        '
        Me.fpcAulas.Controls.Add(Me.gpoAccion)
        Me.fpcAulas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.fpcAulas.FlyoutPanel = Me.fpAulas
        Me.fpcAulas.Location = New System.Drawing.Point(0, 0)
        Me.fpcAulas.Name = "fpcAulas"
        Me.fpcAulas.Size = New System.Drawing.Size(256, 86)
        Me.fpcAulas.TabIndex = 0
        '
        'gpoAccion
        '
        Me.gpoAccion.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gpoAccion.CaptionLocation = DevExpress.Utils.Locations.Top
        Me.gpoAccion.Controls.Add(Me.LabelControl3)
        Me.gpoAccion.Controls.Add(Me.SimpleButton1)
        Me.gpoAccion.Controls.Add(Me.cboGrupo)
        Me.gpoAccion.Controls.Add(Me.LabelControl4)
        Me.gpoAccion.Controls.Add(Me.btnGuardar)
        Me.gpoAccion.Controls.Add(Me.cboGrado)
        Me.gpoAccion.Location = New System.Drawing.Point(5, 5)
        Me.gpoAccion.Name = "gpoAccion"
        Me.gpoAccion.Size = New System.Drawing.Size(246, 76)
        Me.gpoAccion.TabIndex = 4
        Me.gpoAccion.Text = "Agregar Aula"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(124, 26)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(29, 13)
        Me.LabelControl3.TabIndex = 8
        Me.LabelControl3.Text = "Grupo"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton1.AutoSize = True
        Me.SimpleButton1.ImageOptions.Image = CType(resources.GetObject("SimpleButton1.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(5, 49)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(70, 22)
        Me.SimpleButton1.TabIndex = 7
        Me.SimpleButton1.Text = "Cancelar"
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(12, 26)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(29, 13)
        Me.LabelControl4.TabIndex = 11
        Me.LabelControl4.Text = "Grado"
        '
        'cboGrado
        '
        Me.cboGrado.EditValue = "1"
        Me.cboGrado.Location = New System.Drawing.Point(47, 23)
        Me.cboGrado.Name = "cboGrado"
        Me.cboGrado.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboGrado.Properties.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6"})
        Me.cboGrado.Size = New System.Drawing.Size(71, 20)
        Me.cboGrado.TabIndex = 9
        '
        'BarraAcciones
        '
        Me.BarraAcciones.Location = New System.Drawing.Point(1, 1)
        Me.BarraAcciones.Name = "BarraAcciones"
        Me.BarraAcciones.pAgregar = True
        Me.BarraAcciones.pEditar = True
        Me.BarraAcciones.pEliminar = False
        Me.BarraAcciones.Size = New System.Drawing.Size(255, 30)
        Me.BarraAcciones.TabIndex = 2
        '
        'frmConfiguracionAulas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(685, 524)
        Me.Controls.Add(Me.GroupControl1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmConfiguracionAulas"
        Me.ShowIcon = False
        Me.Text = "Configuracion de Aulas"
        CType(Me.gcAulas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvAulas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DxValidationProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboGrupo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.fpAulas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.fpAulas.ResumeLayout(False)
        CType(Me.fpcAulas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.fpcAulas.ResumeLayout(False)
        CType(Me.gpoAccion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpoAccion.ResumeLayout(False)
        Me.gpoAccion.PerformLayout()
        CType(Me.cboGrado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gcAulas As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvAulas As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents btnGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents DxValidationProvider1 As DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cboGrupo As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cboGrado As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents BarraAcciones As Framework2017.BarraAcciones
    Friend WithEvents fpAulas As DevExpress.Utils.FlyoutPanel
    Friend WithEvents fpcAulas As DevExpress.Utils.FlyoutPanelControl
    Friend WithEvents gpoAccion As DevExpress.XtraEditors.GroupControl
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
End Class
