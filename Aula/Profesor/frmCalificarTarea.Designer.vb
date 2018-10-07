<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCalificarTarea
    Inherits System.Windows.Forms.Form

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
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.gcAlumnos = New DevExpress.XtraGrid.GridControl()
        Me.gvAlumnos = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.txtMateria = New DevExpress.XtraEditors.TextEdit()
        Me.txtTemaTarea = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.gcAlumnos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvAlumnos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMateria.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTemaTarea.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.gcAlumnos)
        Me.GroupControl1.Controls.Add(Me.txtMateria)
        Me.GroupControl1.Controls.Add(Me.txtTemaTarea)
        Me.GroupControl1.Controls.Add(Me.LabelControl2)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Location = New System.Drawing.Point(12, 12)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(645, 437)
        Me.GroupControl1.TabIndex = 0
        Me.GroupControl1.Text = "Informacion de la tarea"
        '
        'gcAlumnos
        '
        Me.gcAlumnos.Location = New System.Drawing.Point(5, 75)
        Me.gcAlumnos.MainView = Me.gvAlumnos
        Me.gcAlumnos.Name = "gcAlumnos"
        Me.gcAlumnos.Size = New System.Drawing.Size(635, 357)
        Me.gcAlumnos.TabIndex = 4
        Me.gcAlumnos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvAlumnos})
        '
        'gvAlumnos
        '
        Me.gvAlumnos.GridControl = Me.gcAlumnos
        Me.gvAlumnos.Name = "gvAlumnos"
        Me.gvAlumnos.OptionsView.ShowGroupPanel = False
        '
        'txtMateria
        '
        Me.txtMateria.Enabled = False
        Me.txtMateria.Location = New System.Drawing.Point(81, 49)
        Me.txtMateria.Name = "txtMateria"
        Me.txtMateria.Size = New System.Drawing.Size(253, 20)
        Me.txtMateria.TabIndex = 3
        '
        'txtTemaTarea
        '
        Me.txtTemaTarea.Enabled = False
        Me.txtTemaTarea.Location = New System.Drawing.Point(81, 23)
        Me.txtTemaTarea.Name = "txtTemaTarea"
        Me.txtTemaTarea.Size = New System.Drawing.Size(559, 20)
        Me.txtTemaTarea.TabIndex = 2
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(39, 52)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(36, 13)
        Me.LabelControl2.TabIndex = 1
        Me.LabelControl2.Text = "Materia"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(49, 26)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(26, 13)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Tema"
        '
        'frmCalificarTarea
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(669, 461)
        Me.Controls.Add(Me.GroupControl1)
        Me.Name = "frmCalificarTarea"
        Me.Text = "Calificar Tarea"
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.gcAlumnos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvAlumnos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMateria.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTemaTarea.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtTemaTarea As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtMateria As DevExpress.XtraEditors.TextEdit
    Friend WithEvents gcAlumnos As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvAlumnos As DevExpress.XtraGrid.Views.Grid.GridView
End Class
