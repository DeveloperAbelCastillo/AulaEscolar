Imports System.ServiceModel
Imports System.Transactions
Imports DevExpress.Utils
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.DXErrorProvider

Public Class frmConfiguraPeriodos
    Dim clPeriodos As New clsPeriodos
    Dim clActividades As New clsActividades
    Dim lPeriodos As List(Of Periodos)
    Dim Periodo As Periodos
    Dim TipoProceso As Proceso

    Private Enum Proceso
        agregar
        editar
        eliminar
    End Enum

    Private Enum Grid
        Periodos
        Dias
    End Enum

    Private Sub frmConfiguraPeriodos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.AutoSizeMode = AutoSizeMode.GrowAndShrink
            Cursor.Current = Cursors.WaitCursor
            MuestraPeriodos()
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

    Private Sub MuestraPeriodos()
        Try
            Cursor.Current = Cursors.WaitCursor
            lPeriodos = clPeriodos.GetPeriodos()
            If lPeriodos.Count > 0 Then
                gcPeriodos.DataSource = lPeriodos
                CargaGrid(Grid.Periodos)
            Else
                gcPeriodos.DataSource = Nothing
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

    Private Sub BarraAcciones_eAgregar() Handles BarraAcciones.eAgregar
        gpoPeriodo.Text = "Agregar Periodo"
        btnGuardar.Text = "Guardar"
        TipoProceso = Proceso.agregar
        fpPeriodo.ShowPopup()
    End Sub

    Private Sub BarraAcciones_eEditar() Handles BarraAcciones.eEditar
        Periodo = gvPeriodos.GetRow(gvPeriodos.GetSelectedRows().FirstOrDefault)
        If Not IsNothing(Periodo) Then
            With Periodo
                ccFechaInicio.EditValue = .FechaInicio
                ccFechaFin.EditValue = .FechaFin
            End With
            gpoPeriodo.Text = "Actualizar Periodo"
            btnGuardar.Text = "Actualizar"
            TipoProceso = Proceso.editar
            fpPeriodo.ShowPopup()
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        fpPeriodo.HidePopup()
        TipoProceso = Nothing
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            Cursor.Current = Cursors.WaitCursor
            If TipoProceso = Proceso.agregar Then
                If DxValidationProvider1.Validate(ccFechaFin) Then
                    Periodo = New Periodos
                    With Periodo
                        .FechaInicio = ccFechaInicio.EditValue
                        .FechaFin = ccFechaFin.EditValue
                    End With

                    If Not clPeriodos.GetFechaExiste(Periodo.FechaInicio) Or Not clPeriodos.GetFechaExiste(Periodo.FechaFin) Then
                        XtraMessageBox.Show("Las fechas ya existen en otro periodo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If
                    Dim result = clPeriodos.SetPeriodo(Periodo)

                    If result Then

                        Dim lFechas = GetFechas(Periodo)
                        If lFechas.Count > 0 Then
                            Dim result2 As Boolean = True
                            For Each row In lFechas
                                Dim DiaPeriodo As New DiasPeriodos
                                DiaPeriodo = row
                                If Not clPeriodos.SetDiasPeriodo(DiaPeriodo) Then
                                    result2 = False
                                    Exit For
                                End If
                            Next
                            If result2 Then
                                Dim result3 = clPeriodos.GetDiasPeriodo(Periodo.IdPeriodo)
                                gcDiasPeriodo.DataSource = result3
                                CargaGrid(Grid.Dias)
                            End If
                        End If
                        'XtraMessageBox.Show("El aula fue agregada correctamente", "Proceso Terminado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                        ccFechaInicio.EditValue = Today
                        ccFechaFin.EditValue = Today
                        fpPeriodo.HidePopup()
                        MuestraPeriodos()
                        BarraAcciones.pProceso = RecuperaProceso()
                    End If
                End If
            ElseIf TipoProceso = Proceso.editar Then
                If DxValidationProvider1.Validate(ccFechaFin) Then
                    With Periodo
                        .FechaInicio = ccFechaInicio.EditValue
                        .FechaFin = ccFechaFin.EditValue
                    End With

                    If Not clPeriodos.GetFechaExiste(Periodo.FechaInicio, Periodo.IdPeriodo) Or Not clPeriodos.GetFechaExiste(Periodo.FechaFin, Periodo.IdPeriodo) Then
                        XtraMessageBox.Show("Las fechas ya existen en otro periodo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If

                    Dim lFechas = clPeriodos.GetFechasExistes(Periodo.IdPeriodo)

                    'Dim result = clPeriodos.SetPeriodo(Periodo)
                    If lFechas.Count > 0 Then
                        Dim result As Boolean = True
                        For Each row In lFechas
                            If Not clPeriodos.DelDiasPeriodo(row) Then
                                result = False
                                Exit For
                            End If
                        Next
                        Dim result1 = clPeriodos.SetPeriodo(Periodo)

                        If result1 Then
                            lFechas = New List(Of DiasPeriodos)
                            lFechas = GetFechas(Periodo)
                            If lFechas.Count > 0 Then
                                Dim result2 As Boolean = True
                                For Each row In lFechas
                                    Dim DiaPeriodo As New DiasPeriodos
                                    DiaPeriodo = row
                                    If Not clPeriodos.SetDiasPeriodo(DiaPeriodo) Then
                                        result2 = False
                                        Exit For
                                    End If
                                Next
                                If result2 Then
                                    Dim result3 = clPeriodos.GetDiasPeriodo(Periodo.IdPeriodo)
                                    gcDiasPeriodo.DataSource = result3
                                    CargaGrid(Grid.Dias)
                                End If
                            End If
                            'XtraMessageBox.Show("El aula fue agregada correctamente", "Proceso Terminado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                            ccFechaInicio.EditValue = Today
                            ccFechaFin.EditValue = Today
                            fpPeriodo.HidePopup()
                            MuestraPeriodos()
                            BarraAcciones.pProceso = RecuperaProceso()
                        End If
                    End If

                    'If result Then
                    '    'XtraMessageBox.Show("El aula fue agregada correctamente", "Proceso Terminado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                    '    ccFechaInicio.EditValue = Today
                    '    ccFechaFin.EditValue = Today
                    '    fpPeriodo.HidePopup()
                    '    MuestraPeriodos()
                    '    BarraAcciones.pProceso = RecuperaProceso()
                    'End If
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

    Private Sub ccFechaFin_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ccFechaFin.Validating
        Try
            Cursor.Current = Cursors.WaitCursor
            Dim regla As New ConditionValidationRule()
            With regla
                .ConditionOperator = ConditionOperator.Greater
                .ErrorText = "Seleccione la fecha de Inicio"
                .ErrorType = ErrorType.Critical
                .Value1 = ccFechaInicio.EditValue
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
#End Region

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

    Private Function GetFechas(ByVal pPeriodo As Periodos) As List(Of DiasPeriodos)
        Dim result As New List(Of DiasPeriodos)
        Dim FechaDiasPeriodos As DiasPeriodos
        Dim fecha As New Date
        Dim Dias As Integer = 0

        fecha = Periodo.FechaInicio

        While fecha <= Periodo.FechaFin
            FechaDiasPeriodos = New DiasPeriodos
            With FechaDiasPeriodos
                .IdPeriodo = Periodo.IdPeriodo
                .Fecha = fecha
                If fecha.DayOfWeek = DayOfWeek.Saturday Or fecha.DayOfWeek = DayOfWeek.Sunday Then
                    .Laboral = False
                Else
                    .Laboral = True
                End If
            End With
            result.Add(FechaDiasPeriodos)
            fecha = fecha.AddDays(1)
        End While
        Return result
    End Function

    Private Sub gvPeriodos_Click(sender As Object, e As EventArgs) Handles gvPeriodos.Click
        Try
            Periodo = gvPeriodos.GetRow(gvPeriodos.GetSelectedRows().FirstOrDefault)
            Dim result3 = clPeriodos.GetDiasPeriodo(Periodo.IdPeriodo)
            gcDiasPeriodo.DataSource = result3
            CargaGrid(Grid.Dias)
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

    Private Sub CargaGrid(ByVal pGrid As Grid)
        Select Case pGrid
            Case Grid.Periodos
                gvPeriodos.OptionsBehavior.Editable = False
                gvPeriodos.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus
                gvPeriodos.OptionsView.ShowGroupPanel = False
                gvPeriodos.Columns("IdPeriodo").Visible = False
                gvPeriodos.Columns("FechaInicio").AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center
                gvPeriodos.Columns("FechaInicio").AppearanceCell.TextOptions.HAlignment = HorzAlignment.Center
                gvPeriodos.Columns("FechaInicio").Caption = "Fecha Inicio"
                gvPeriodos.Columns("FechaFin").AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center
                gvPeriodos.Columns("FechaFin").AppearanceCell.TextOptions.HAlignment = HorzAlignment.Center
                gvPeriodos.Columns("FechaFin").Caption = "Fecha Fin"
                gvPeriodos.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Auto
            Case Grid.Dias
                'gvDiasPeriodo.OptionsBehavior.Editable = False
                gvDiasPeriodo.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus
                gvDiasPeriodo.OptionsView.ShowGroupPanel = False
                gvDiasPeriodo.Columns("IdDia").Visible = False
                gvDiasPeriodo.Columns("IdPeriodo").Visible = False
                gvDiasPeriodo.Columns("Fecha").AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center
                gvDiasPeriodo.Columns("Fecha").AppearanceCell.TextOptions.HAlignment = HorzAlignment.Center
                gvDiasPeriodo.Columns("Fecha").Caption = "Fecha"
                gvDiasPeriodo.Columns("Fecha").DisplayFormat.FormatType = FormatType.DateTime
                gvDiasPeriodo.Columns("Fecha").DisplayFormat.FormatString = "D"
                gvDiasPeriodo.Columns("Fecha").OptionsColumn.AllowEdit = False
                gvDiasPeriodo.Columns("Laboral").AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center
                gvDiasPeriodo.Columns("Laboral").AppearanceCell.TextOptions.HAlignment = HorzAlignment.Center
                gvDiasPeriodo.Columns("Laboral").Caption = "Laboral"
                gvDiasPeriodo.Columns("Laboral").Width = 30
                gvDiasPeriodo.Columns("Laboral").OptionsColumn.AllowEdit = True
                gvDiasPeriodo.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Auto
        End Select
    End Sub

    Private Sub gvDiasPeriodo_CellValueChanging(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles gvDiasPeriodo.CellValueChanging
        Dim DiaPeriodo As New DiasPeriodos
        DiaPeriodo = gvDiasPeriodo.GetRow(gvDiasPeriodo.GetSelectedRows().FirstOrDefault)
        If DiaPeriodo.Laboral Then
            clPeriodos.SetDiasPeriodo(DiaPeriodo)
        Else
            If Not clActividades.TieneActvidades(DiaPeriodo.Fecha) Then
                clPeriodos.SetDiasPeriodo(DiaPeriodo)
            Else
                XtraMessageBox.Show("No puede ser desactivado por que cuenta con actividades para revisar en ese dia", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            End If
        End If
    End Sub
End Class