Imports System.ServiceModel
Imports System.Transactions
Imports DevExpress.Utils
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.DXErrorProvider

Public Class ftmConfiguracionSeguridad
#Region "Declaraciones"
    Dim cNivelSeguridad As clsNiveleSeguridad
    Dim NivelesSeguridad As List(Of NivelSeguridad)
    Dim NivelSeguridad As NivelSeguridad
    Dim TipoProceso As Proceso

    Private Enum Proceso
        agregar
        editar
        eliminar
    End Enum
#End Region
#Region "Carga Inicial"
    Private Sub frmAulaAlumnos_ListaAlumnos_Enter(sender As Object, e As EventArgs) Handles MyBase.Enter
        Try
            Cursor.Current = Cursors.WaitCursor
            CargaNivelesSeguridad()
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

    Private Sub CargaNivelesSeguridad()
        Try
            Cursor.Current = Cursors.WaitCursor
            NivelesSeguridad = cNivelSeguridad.GetNivelesSeguridad()
            gvNivelesSeguridad.OptionsBehavior.Editable = False
            gvNivelesSeguridad.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus
            gvNivelesSeguridad.OptionsView.ShowGroupPanel = False
            If NivelesSeguridad.Count > 0 Then
                For Each NivelSeguridad In NivelesSeguridad
                    With NivelSeguridad
                        .Clave = SAL.Encriptador.DecryptString(.Clave, My.Settings.Clave)
                    End With
                Next
                Using db As New AulaEntities()
                    gcNivelesSeguridad.DataSource = NivelesSeguridad
                End Using
                gvNivelesSeguridad.Columns("IdNivelSeguridad").Visible = False
                gvNivelesSeguridad.Columns("Clave").Visible = False
                gvNivelesSeguridad.Columns("Nivel").AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center
                gvNivelesSeguridad.Columns("Nivel").AppearanceCell.TextOptions.HAlignment = HorzAlignment.Center
                gvNivelesSeguridad.Columns("Nivel").Caption = "NIVEL DE SEGURIDAD"
            Else
                gcNivelesSeguridad.DataSource = Nothing
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

    Private Sub BarraAcciones1_eAgregar() Handles BarraAcciones1.eAgregar
        gpoAccion.Text = "Agregar Alumno"
        btnGuardar.Text = "Guardar"
        TipoProceso = Proceso.agregar
        fpAcciones.ShowPopup()
    End Sub
#End Region
#Region "Logica"

#End Region
#Region "Validaciones"

#End Region
End Class