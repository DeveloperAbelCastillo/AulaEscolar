Imports System.ServiceModel
Imports System.Transactions
Imports DevExpress.Utils
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.DXErrorProvider
Imports DevExpress.XtraGrid.Views.Grid

Public Class frmMaterias
#Region "Declaraciones"
    Dim AluaFormulario As Integer = 0
    Dim cMaterias As New clsMaterias
    Dim Materias As New List(Of Materias)
    Dim Materia As Materias
    Dim TipoProceso As Proceso

    Private Enum Proceso
        agregar
        editar
        eliminar
    End Enum

#End Region
#Region "Carga Inicial"
    Private Sub frmMaterias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Cursor.Current = Cursors.WaitCursor
            Me.AutoSizeMode = AutoSizeMode.GrowAndShrink
            CargaMaterias()
            CargaValidaciones()
        Catch p As FaultException
            XtraMessageBox.Show(p.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As TransactionAbortedException
            XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As ApplicationException
            XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Cursor.Current = Cursors.Default
        End Try
    End Sub

#End Region
#Region "Funcionalidad"
    Private Sub CargaMaterias()
        Try
            Cursor.Current = Cursors.WaitCursor
            Materias = cMaterias.GetMaterias(My.Settings.IdAulaActual)
            If Materias.Count > 0 Then
                gcMaterias.DataSource = Materias
                gvMaterias.OptionsBehavior.Editable = False
                gvMaterias.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus
                gvMaterias.OptionsView.ShowGroupPanel = False
                gvMaterias.Columns("IdMateria").Visible = False
                gvMaterias.Columns("IdAula").Visible = False
                gvMaterias.Columns("Materia").AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center
                gvMaterias.Columns("Materia").AppearanceCell.TextOptions.HAlignment = HorzAlignment.Center
                gvMaterias.Columns("Materia").Caption = "MATERIAS"
                gvMaterias.Columns("ColorRGB").AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center
                gvMaterias.Columns("ColorRGB").AppearanceCell.TextOptions.HAlignment = HorzAlignment.Center
                gvMaterias.Columns("ColorRGB").Caption = "COLOR"
            Else
                gcMaterias.DataSource = Nothing
            End If
        Catch p As FaultException
            XtraMessageBox.Show(p.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As TransactionAbortedException
            XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As ApplicationException
            XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Cursor.Current = Cursors.Default
        End Try
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            Cursor.Current = Cursors.WaitCursor
            If TipoProceso = Proceso.agregar Then
                If DxValidationProvider1.Validate(txtMateria) Then
                    For Each vMateria In Materias
                        With vMateria
                            If .Materia = txtMateria.EditValue Then
                                XtraMessageBox.Show("No pueden existir 2 materias con el mismo nombre en la misma aula", "Aula existente", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                Exit Sub
                            End If
                        End With
                    Next
                    Materia = New Materias
                    With Materia
                        .Materia = txtMateria.EditValue
                        .IdAula = My.Settings.IdAulaActual
                        .ColorRGB = String.Format("{0};{1};{2};{3}", cboColor.Color.A, cboColor.Color.R, cboColor.Color.G, cboColor.Color.B)
                    End With
                    Dim result = cMaterias.SetMateria(Materia)

                    If result Then
                        'XtraMessageBox.Show("La Materia fue agregada correctamente", "Proceso Terminado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                        fpMaterias.HidePopup()
                        txtMateria.EditValue = ""
                        CargaMaterias()
                        BarraAcciones.pProceso = RecuperaProceso()
                    End If
                End If
            ElseIf TipoProceso = Proceso.editar Then
                If DxValidationProvider1.Validate(txtMateria) Then
                    For Each mate In Materias
                        With mate
                            If .Materia = txtMateria.EditValue And Materia.IdMateria <> .IdMateria Then
                                XtraMessageBox.Show("No pueden existir 2 materias con el mismo nombre en la misma aula", "Aula existente", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                Exit Sub
                            End If
                        End With
                    Next

                    With Materia
                        .Materia = txtMateria.EditValue
                        .ColorRGB = String.Format("{0};{1};{2};{3}", cboColor.Color.A, cboColor.Color.R, cboColor.Color.G, cboColor.Color.B)
                    End With
                    Dim result = cMaterias.SetMateria(Materia)

                    If result Then
                        'XtraMessageBox.Show("La Materia fue agregada correctamente", "Proceso Terminado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                        fpMaterias.HidePopup()
                        txtMateria.EditValue = ""
                        CargaMaterias()
                        BarraAcciones.pProceso = RecuperaProceso()
                    End If
                End If
            End If
        Catch p As FaultException
            XtraMessageBox.Show(p.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As TransactionAbortedException
            XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As ApplicationException
            XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Cursor.Current = Cursors.Default
        End Try
    End Sub

    Private Function RecuperaProceso() As String
        Dim res As String = ""
        Try
            Cursor.Current = Cursors.WaitCursor
            Select Case TipoProceso
                Case Proceso.agregar
                    res = "Agregado"
                Case Proceso.editar
                    res = "Actualizado"
                Case Proceso.eliminar
                    res = "Eliminado"
            End Select
        Catch p As FaultException
            XtraMessageBox.Show(p.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As TransactionAbortedException
            XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As ApplicationException
            XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Cursor.Current = Cursors.Default
        End Try
        Return res
    End Function
#End Region
#Region "Logica"

#End Region
#Region "Validaciones"
    Private Sub CargaValidaciones()
        Cursor.Current = Cursors.WaitCursor
        Dim regla As New ConditionValidationRule()
        With regla
            .ConditionOperator = ConditionOperator.IsNotBlank
            .ErrorText = "El campo no puede quedar vacio"
            .ErrorType = ErrorType.Critical
        End With
        DxValidationProvider1.SetValidationRule(txtMateria, regla)
        DxValidationProvider1.SetIconAlignment(txtMateria, ErrorIconAlignment.BottomRight)
    End Sub

    Private Sub Validar(ByVal control As Control)
        Try
            Cursor.Current = Cursors.WaitCursor
            DxValidationProvider1.ValidationMode = ValidationMode.Manual
            DxValidationProvider1.Validate(control)
            DxValidationProvider1.SetIconAlignment(control, ErrorIconAlignment.BottomRight)
        Catch p As FaultException
            XtraMessageBox.Show(p.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As TransactionAbortedException
            XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As ApplicationException
            XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Cursor.Current = Cursors.Default
        End Try
    End Sub

    Private Sub txtMateria_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtMateria.Validating
        Validar(sender)
    End Sub

    Private Sub frmMaterias_Enter(sender As Object, e As EventArgs) Handles MyBase.Enter
        If AluaFormulario <> My.Settings.IdAulaActual Then
            AluaFormulario = My.Settings.IdAulaActual
            CargaMaterias()
        End If
    End Sub

    Private Sub gvMaterias_RowStyle(sender As Object, e As RowStyleEventArgs) Handles gvMaterias.RowStyle
        Dim View As GridView = sender
        If (e.RowHandle >= 0) Then
            Dim RowColor As String = View.GetRowCellDisplayText(e.RowHandle, View.Columns("ColorRGB"))
            If Not IsNothing(RowColor) Then

                e.Appearance.BackColor = ValidaColor(RowColor)
                e.Appearance.ForeColor = ColorContraste(ValidaColor(RowColor))
                'e.Appearance.BackColor2 = Color.SeaShell
            End If
        End If
    End Sub

    Private Sub BarraAcciones_eAgregar() Handles BarraAcciones.eAgregar
        gpoAccion.Text = "Agregar Materia"
        btnGuardar.Text = "Guardar"
        TipoProceso = Proceso.agregar
        fpMaterias.ShowPopup()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        fpMaterias.HidePopup()
        TipoProceso = Nothing
    End Sub

    Private Sub BarraAcciones_eEditar() Handles BarraAcciones.eEditar
        Materia = gvMaterias.GetRow(gvMaterias.GetSelectedRows().FirstOrDefault)
        If Not IsNothing(Materia) Then
            With Materia
                txtMateria.EditValue = .Materia
                cboColor.EditValue = ValidaColor(.ColorRGB)
            End With
            gpoAccion.Text = "Actualizar Materia"
            btnGuardar.Text = "Actualizar"
            TipoProceso = Proceso.editar
            fpMaterias.ShowPopup()
        End If
    End Sub

    Private Sub gcMaterias_Click(sender As Object, e As EventArgs) Handles gcMaterias.Click
        Materia = gvMaterias.GetRow(gvMaterias.GetSelectedRows().FirstOrDefault)
        gvMaterias.Appearance.FocusedRow.BackColor = Color.Transparent
        gvMaterias.Appearance.FocusedCell.BackColor = Color.Transparent
        gvMaterias.Appearance.FocusedRow.BorderColor = ValidaColor(Materia.ColorRGB)
        gvMaterias.Appearance.FocusedCell.BorderColor = ValidaColor(Materia.ColorRGB)
    End Sub

#End Region
End Class