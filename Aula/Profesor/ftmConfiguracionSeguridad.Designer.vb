<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ftmConfiguracionSeguridad
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ftmConfiguracionSeguridad))
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.fpAcciones = New DevExpress.Utils.FlyoutPanel()
        Me.fpcAcciones = New DevExpress.Utils.FlyoutPanelControl()
        Me.gcNivelesSeguridad = New DevExpress.XtraGrid.GridControl()
        Me.gvNivelesSeguridad = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.BarraAcciones1 = New Framework2017.BarraAcciones()
        Me.gpoAccion = New DevExpress.XtraEditors.GroupControl()
        Me.btnCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnGuardar = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.fpAcciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.fpAcciones.SuspendLayout()
        CType(Me.fpcAcciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.fpcAcciones.SuspendLayout()
        CType(Me.gcNivelesSeguridad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvNivelesSeguridad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gpoAccion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpoAccion.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupControl1
        '
        Me.GroupControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupControl1.Controls.Add(Me.fpAcciones)
        Me.GroupControl1.Controls.Add(Me.gcNivelesSeguridad)
        Me.GroupControl1.Controls.Add(Me.BarraAcciones1)
        Me.GroupControl1.Location = New System.Drawing.Point(12, 12)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(408, 469)
        Me.GroupControl1.TabIndex = 0
        Me.GroupControl1.Text = "Niveles de Seguridad"
        '
        'fpAcciones
        '
        Me.fpAcciones.Controls.Add(Me.fpcAcciones)
        Me.fpAcciones.Location = New System.Drawing.Point(3, 53)
        Me.fpAcciones.Name = "fpAcciones"
        Me.fpAcciones.OwnerControl = Me.gcNivelesSeguridad
        Me.fpAcciones.Size = New System.Drawing.Size(403, 150)
        Me.fpAcciones.TabIndex = 2
        '
        'fpcAcciones
        '
        Me.fpcAcciones.Controls.Add(Me.gpoAccion)
        Me.fpcAcciones.Dock = System.Windows.Forms.DockStyle.Fill
        Me.fpcAcciones.FlyoutPanel = Me.fpAcciones
        Me.fpcAcciones.Location = New System.Drawing.Point(0, 0)
        Me.fpcAcciones.Name = "fpcAcciones"
        Me.fpcAcciones.Size = New System.Drawing.Size(403, 150)
        Me.fpcAcciones.TabIndex = 0
        '
        'gcNivelesSeguridad
        '
        Me.gcNivelesSeguridad.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcNivelesSeguridad.Location = New System.Drawing.Point(2, 50)
        Me.gcNivelesSeguridad.MainView = Me.gvNivelesSeguridad
        Me.gcNivelesSeguridad.Name = "gcNivelesSeguridad"
        Me.gcNivelesSeguridad.Size = New System.Drawing.Size(404, 417)
        Me.gcNivelesSeguridad.TabIndex = 1
        Me.gcNivelesSeguridad.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvNivelesSeguridad})
        '
        'gvNivelesSeguridad
        '
        Me.gvNivelesSeguridad.GridControl = Me.gcNivelesSeguridad
        Me.gvNivelesSeguridad.Name = "gvNivelesSeguridad"
        '
        'BarraAcciones1
        '
        Me.BarraAcciones1.Dock = System.Windows.Forms.DockStyle.Top
        Me.BarraAcciones1.Location = New System.Drawing.Point(2, 20)
        Me.BarraAcciones1.Name = "BarraAcciones1"
        Me.BarraAcciones1.pAgregar = True
        Me.BarraAcciones1.pEditar = True
        Me.BarraAcciones1.pEliminar = True
        Me.BarraAcciones1.Size = New System.Drawing.Size(404, 30)
        Me.BarraAcciones1.TabIndex = 0
        '
        'gpoAccion
        '
        Me.gpoAccion.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gpoAccion.Controls.Add(Me.btnCancelar)
        Me.gpoAccion.Controls.Add(Me.btnGuardar)
        Me.gpoAccion.Location = New System.Drawing.Point(2, 2)
        Me.gpoAccion.Name = "gpoAccion"
        Me.gpoAccion.Size = New System.Drawing.Size(399, 146)
        Me.gpoAccion.TabIndex = 0
        Me.gpoAccion.Text = "Acciones"
        '
        'btnCancelar
        '
        Me.btnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnCancelar.AutoSize = True
        Me.btnCancelar.ImageOptions.Image = CType(resources.GetObject("btnCancelar.ImageOptions.Image"), System.Drawing.Image)
        Me.btnCancelar.Location = New System.Drawing.Point(3, 119)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(70, 22)
        Me.btnCancelar.TabIndex = 10
        Me.btnCancelar.Text = "Cancelar"
        '
        'btnGuardar
        '
        Me.btnGuardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGuardar.AutoSize = True
        Me.btnGuardar.ImageOptions.Image = CType(resources.GetObject("btnGuardar.ImageOptions.Image"), System.Drawing.Image)
        Me.btnGuardar.Location = New System.Drawing.Point(327, 119)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(67, 22)
        Me.btnGuardar.TabIndex = 9
        Me.btnGuardar.Text = "Agregar"
        '
        'ftmConfiguracionSeguridad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(823, 493)
        Me.Controls.Add(Me.GroupControl1)
        Me.Name = "ftmConfiguracionSeguridad"
        Me.Text = "Seguridad"
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.fpAcciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.fpAcciones.ResumeLayout(False)
        CType(Me.fpcAcciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.fpcAcciones.ResumeLayout(False)
        CType(Me.gcNivelesSeguridad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvNivelesSeguridad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gpoAccion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpoAccion.ResumeLayout(False)
        Me.gpoAccion.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents BarraAcciones1 As Framework2017.BarraAcciones
    Friend WithEvents gcNivelesSeguridad As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvNivelesSeguridad As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents fpAcciones As DevExpress.Utils.FlyoutPanel
    Friend WithEvents fpcAcciones As DevExpress.Utils.FlyoutPanelControl
    Friend WithEvents gpoAccion As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btnCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnGuardar As DevExpress.XtraEditors.SimpleButton
End Class
