Imports System.ServiceModel
Imports System.Transactions
Imports DevExpress.Utils
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.DXErrorProvider

Public Class frmConfiguracionAulas
#Region "Declaraciones"
    Dim clAulas As New BLL.clsConfiguracionAulas
    Dim Aulas As List(Of Aulas)
    Dim Aula As Aulas
    Dim TipoProceso As Proceso

    Private Enum Proceso
        agregar
        editar
        eliminar
    End Enum

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
#Region "Carga Inicial"
    Private Sub frmConfiguracionAulas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.AutoSizeMode = AutoSizeMode.GrowAndShrink
            Cursor.Current = Cursors.WaitCursor
            MuestraAulas()
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

    Private Sub MuestraAulas()
        Try
            Cursor.Current = Cursors.WaitCursor
            Aulas = clAulas.GetAulasExistentes(My.Settings.IdUsuario)

            If Aulas.Count > 0 Then
                gcAulas.DataSource = Aulas
                gvAulas.OptionsBehavior.Editable = False
                gvAulas.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus
                gvAulas.OptionsView.ShowGroupPanel = False
                gvAulas.Columns("IdAula").Visible = False
                gvAulas.Columns("IdUsuario").Visible = False
                gvAulas.Columns("Grado").AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center
                gvAulas.Columns("Grado").AppearanceCell.TextOptions.HAlignment = HorzAlignment.Center
                gvAulas.Columns("Grado").Caption = "GRADO"
                gvAulas.Columns("Grupo").AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center
                gvAulas.Columns("Grupo").AppearanceCell.TextOptions.HAlignment = HorzAlignment.Center
                gvAulas.Columns("Grupo").Caption = "GRUPO"
            Else
                gcAulas.DataSource = Nothing
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
#End Region
#Region "Funcionalidad"
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            Cursor.Current = Cursors.WaitCursor
            If TipoProceso = Proceso.agregar Then
                If DxValidationProvider1.Validate(cboGrado) And DxValidationProvider1.Validate(cboGrupo) Then
                    For Each vAula In Aulas
                        With vAula
                            If .Grado = cboGrado.EditValue AndAlso .Grupo = cboGrupo.EditValue Then
                                XtraMessageBox.Show("No pueden existir 2 aulas con el mismo grado y grupo", "Aula existente", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                Exit Sub
                            End If
                        End With
                    Next
                    Aula = New Aulas
                    With Aula
                        .Grado = cboGrado.EditValue
                        .Grupo = cboGrupo.EditValue
                        .IdUsuario = My.Settings.IdUsuario
                    End With
                    Dim result = clAulas.SetAula(Aula)

                    Dim f As FrmPrincipal = DirectCast(Me.MdiParent, FrmPrincipal)
                    f.RefrescarConfiguracion = 0

                    If result Then
                        'XtraMessageBox.Show("El aula fue agregada correctamente", "Proceso Terminado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                        cboGrado.SelectedIndex = 0
                        cboGrupo.SelectedIndex = 0
                        fpAulas.HidePopup()
                        MuestraAulas()
                        BarraAcciones.pProceso = RecuperaProceso()
                    End If
                End If
            Else
                If DxValidationProvider1.Validate(cboGrado) And DxValidationProvider1.Validate(cboGrupo) Then
                    For Each aul In Aulas
                        With aul
                            If .Grado = cboGrado.EditValue AndAlso .Grupo = cboGrupo.EditValue And Aula.IdAula <> .IdAula Then
                                XtraMessageBox.Show("No pueden existir 2 aulas con el mismo grado y grupo", "Aula existente", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                Exit Sub
                            End If
                        End With
                    Next
                    With Aula
                        .Grado = cboGrado.EditValue
                        .Grupo = cboGrupo.EditValue
                    End With
                    Dim result = clAulas.SetAula(Aula)

                    Dim f As FrmPrincipal = DirectCast(Me.MdiParent, FrmPrincipal)
                    f.RefrescarConfiguracion = True

                    If result Then
                        'XtraMessageBox.Show("El aula fue agregada correctamente", "Proceso Terminado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                        cboGrado.SelectedIndex = 0
                        cboGrupo.SelectedIndex = 0
                        fpAulas.HidePopup()
                        MuestraAulas()
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
#End Region
#Region "Logica"

#End Region
#Region "Validaciones"
    Private Sub Validar(ByVal control As Control, Optional Nivel As Integer = 0)
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

    Private Sub cboGrado_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs)
        Try
            Cursor.Current = Cursors.WaitCursor
            Dim regla As New ConditionValidationRule()
            With regla
                .ConditionOperator = ConditionOperator.Between
                .ErrorText = "Seleccione alguno de los grados propuestos"
                .ErrorType = ErrorType.Critical
                .Value1 = 1
                .Value2 = 6
            End With
            DxValidationProvider1.SetValidationRule(sender, regla)
            Validar(sender)
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

    Private Sub cboGrupo_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs)
        Try
            Cursor.Current = Cursors.WaitCursor
            Dim regla As New ConditionValidationRule()
            With regla
                .ConditionOperator = ConditionOperator.AnyOf
                .ErrorText = "Selecciona alguno de los grupos propuestos"
                .ErrorType = ErrorType.Critical
                .Values.Add("A")
                .Values.Add("B")
                .Values.Add("C")
                .Values.Add("D")
                .Values.Add("E")
                .Values.Add("F")
            End With
            DxValidationProvider1.SetValidationRule(sender, regla)
            Validar(sender)
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

    Private Sub BarraAcciones_eAgregar() Handles BarraAcciones.eAgregar
        gpoAccion.Text = "Agregar Aula"
        btnGuardar.Text = "Guardar"
        TipoProceso = Proceso.agregar
        fpAulas.ShowPopup()
    End Sub

    Private Sub BarraAcciones_eEditar() Handles BarraAcciones.eEditar
        Aula = gvAulas.GetRow(gvAulas.GetSelectedRows().FirstOrDefault)
        If Not IsNothing(Aula) Then
            With Aula
                cboGrado.EditValue = .Grado
                cboGrupo.EditValue = .Grupo
            End With
            gpoAccion.Text = "Actualizar Aula"
            btnGuardar.Text = "Actualizar"
            TipoProceso = Proceso.editar
            fpAulas.ShowPopup()
        End If
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        fpAulas.HidePopup()
        TipoProceso = Nothing
    End Sub

#End Region
End Class