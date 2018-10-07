Imports System.ServiceModel
Imports System.Transactions
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.DXErrorProvider
Imports DevExpress.XtraScheduler.UI

Public Class frm_Actividades_Tareas_Tarea

#Region "Declaraciones"
    Dim clPeriodo As New clsPeriodos
    Dim Actividad As Actividades
    Dim cActividad As New clsActividades
    Dim cMaterias As New clsMaterias

    Private xSoloLectura As Boolean = False
    Public Property pSoloLectura() As Boolean
        Get
            Return xSoloLectura
        End Get
        Set(ByVal value As Boolean)
            xSoloLectura = value
            SoloLectura()
        End Set
    End Property

    Private xIdTarea As Integer = 0
    Public Property pTarea() As Integer
        Get
            Return xIdTarea
        End Get
        Set(ByVal value As Integer)
            xIdTarea = value
        End Set
    End Property

#End Region
#Region "Carga Inicial"
    Private Sub frm_Actividades_Tareas_Tarea_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = FormBorderStyle.FixedSingle
        Limpiar()
        cboMateria.Properties.DataSource = cMaterias.GetMaterias(My.Settings.IdAulaActual)
        cboMateria.Properties.DisplayMember = "Materia"
        cboMateria.Properties.ValueMember = "IdMateria"
        cboMateria.ItemIndex = 0

        If xIdTarea > 0 Then
            Actividad = cActividad.GetActividad(xIdTarea)

            If Not IsNothing(Actividad) Then
                With Actividad
                    txtTema.EditValue = .Tema
                    cboFechaEntrega.EditValue = CDate(.FechaEntrega).Date
                    cboHoraEntrega.EditValue = Format(.FechaEntrega, "HH:mm")
                    cboHorasRevision.EditValue = GetDiferenciaFechas(.FechaEntrega, .TiempoRevision)
                    cboMateria.Enabled = True
                    cboMateria.EditValue = CInt(.IdMateria)
                    txtDescripcion.EditValue = .Descripcion
                End With
            Else
                XtraMessageBox.Show("No se encotro la tarea seleccionada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            Actividad = New Actividades
        End If
        CargaValidaciones()
    End Sub

    Private Sub Limpiar()
        txtTema.EditValue = ""
        cboFechaEntrega.EditValue = Date.Today
        cboHoraEntrega.EditValue = Format(Date.Today, "t")
        cboHorasRevision.EditValue = 0
        cboMateria.ItemIndex = 0
        txtDescripcion.EditValue = ""
        txtRutaArchivo.EditValue = ""
    End Sub
#End Region
#Region "Funcionalidad"
    Private Sub SoloLectura()
        If xSoloLectura Then
            txtTema.ReadOnly = True
            cboFechaEntrega.ReadOnly = True
            cboHoraEntrega.ReadOnly = True
            cboHorasRevision.ReadOnly = True
            cboMateria.ReadOnly = True
            txtDescripcion.ReadOnly = True
            btnBuscaArchivo.Enabled = False
            btnGuardar.Enabled = False
        Else
            txtTema.ReadOnly = False
            cboFechaEntrega.ReadOnly = False
            cboHoraEntrega.ReadOnly = False
            cboHorasRevision.ReadOnly = False
            cboMateria.ReadOnly = False
            txtDescripcion.ReadOnly = False
            btnBuscaArchivo.Enabled = True
            btnGuardar.Enabled = True
        End If
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            Cursor.Current = Cursors.WaitCursor
            With Actividad
                .Tema = txtTema.EditValue
                .FechaCreacion = Date.Today
                .FechaEntrega = CDate(cboFechaEntrega.EditValue).Date.AddHours(CDate(cboHoraEntrega.EditValue).Hour).AddMinutes(CDate(cboHoraEntrega.EditValue).Minute)
                .TiempoRevision = CDate(.FechaEntrega).AddHours(CDate(cboHorasRevision.EditValue).Hour).AddMinutes(CDate(cboHorasRevision.EditValue).Minute)
                .IdMateria = cboMateria.EditValue
                .Descripcion = txtDescripcion.EditValue
                .IdTipoActividad = 1
            End With

            If Not clPeriodo.GetFechaLaboral(Actividad.FechaEntrega) Then
                Exit Sub
            End If

            Dim result = cActividad.SetActividad(Actividad)
            If result Then
                Me.DialogResult = DialogResult.OK
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
    Public Sub CargaValidaciones()
        Try
            Cursor.Current = Cursors.WaitCursor
            Dim regla As New ConditionValidationRule()
            With regla
                .ConditionOperator = ConditionOperator.IsNotBlank
                .ErrorText = "El campo no puede quedar vacio"
                .ErrorType = ErrorType.Critical
            End With
            DxValidationProvider1.SetValidationRule(txtTema, regla)
            DxValidationProvider1.SetIconAlignment(txtTema, ErrorIconAlignment.BottomRight)

            regla = New ConditionValidationRule()
            With regla
                .ConditionOperator = ConditionOperator.Greater
                .ErrorText = "El campo no puede quedar vacio"
                .ErrorType = ErrorType.Critical
                .Value1 = Date.Today.AddDays(-1)
            End With
            DxValidationProvider1.SetValidationRule(cboFechaEntrega, regla)
            DxValidationProvider1.SetIconAlignment(cboFechaEntrega, ErrorIconAlignment.BottomRight)

            'regla = New ConditionValidationRule()
            'With regla
            '    .ConditionOperator = ConditionOperator.Greater
            '    .ErrorText = "El campo no puede quedar vacio"
            '    .ErrorType = ErrorType.Critical
            '    .Value1 = Date.Today.Hour(-1)
            'End With
            'DxValidationProvider1.SetValidationRule(cboFechaEntrega, regla)
            'DxValidationProvider1.SetIconAlignment(cboFechaEntrega, ErrorIconAlignment.BottomRight)
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

    Private Sub Validar_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtTema.Validating, cboFechaEntrega.Validating
        Validar(sender)
    End Sub

#End Region
End Class