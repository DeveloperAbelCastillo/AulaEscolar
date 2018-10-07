Imports System.Threading
Imports DevExpress.XtraEditors
Imports DevExpress.LookAndFeel
Imports DevExpress.XtraSplashScreen

Public Class FrmPrincipal
#Region "Declaraciones"
    Dim clConfiguracion As New clsConfiguracionUsuario
    Dim clAulas As New clsConfiguracionAulas
    Dim clMaterias As New clsMaterias
    Dim Configuracion As Usuario
    Dim Aulas As List(Of Aulas)

    Private xRefresca As Integer
    Public WriteOnly Property RefrescarConfiguracion As Integer
        Set(ByVal value As Integer)
            If value > 0 Then
                CargaConfiguracion(value)
            Else
                CargaConfiguracion()
            End If
        End Set
    End Property

#End Region
#Region "Carga Inicial"
    Private Sub FrmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Thread.Sleep(4000)
        CargaConfiguracion()
    End Sub
#End Region
#Region "Funcionalidad"
#Region "Menu"
#Region "Abrir Ventana"
    Private llamado As New Form()

    Public Sub AbrirForm(ByVal frmHijo As Form, ByVal frmPadre As Form, Optional ByVal frmState As FormWindowState = FormWindowState.Maximized, Optional ByVal frmPosition As FormStartPosition = FormStartPosition.CenterScreen)
        Try
            SplashScreenManager2.ShowWaitForm()
            Dim cargado As Boolean = False
            For Each llamado As Form In frmPadre.MdiChildren
                If llamado.Text = frmHijo.Text Then
                    cargado = True
                    llamado.BringToFront()
                    'XtraTabbedMdiManager1.MdiParent.ActiveControl = llamado
                    'Dim a = DocumentManager1.MdiParent.ActiveControl
                    'DocumentManager1.MdiParent.ActiveControl = llamado
                    'Dim b = a
                    Exit For
                End If
            Next
            If Not cargado Then
                frmHijo.MdiParent = frmPadre
                frmHijo.WindowState = frmState
                frmHijo.StartPosition = frmPosition
                frmHijo.Show()
            End If
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            SplashScreenManager2.CloseWaitForm()
        End Try

    End Sub
#End Region
#Region "Botones"

    Private Sub ricbAulas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ricbAulas.SelectedIndexChanged
        Dim AulaSeleccionada As String = beAulas.EditValue
        If AulaSeleccionada.Length = 3 Then
            For Each Aula In Aulas
                With Aula
                    If .Grado = AulaSeleccionada.Substring(0, 1) AndAlso .Grupo = AulaSeleccionada.Substring(2, 1) Then
                        My.Settings.IdAulaActual = Aula.IdAula
                    End If
                End With
            Next
        End If
    End Sub

    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnConficuraiconAplicacionConfiguracionGeneral.ItemClick
        Dim frm As New frmConfiguracionGeneral()
        AbrirForm(frm, Me)
    End Sub

    Private Sub btnConficuraiconAplicacionConfiguracionAulas_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnConficuraiconAplicacionConfiguracionAulas.ItemClick
        Dim frm As New frmConfiguracionAulas()
        AbrirForm(frm, Me)
    End Sub

    Private Sub btnConficuraiconAplicacionConfiguracionMaterias_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnConficuraiconAplicacionConfiguracionMaterias.ItemClick
        Dim frm As New frmMaterias()
        AbrirForm(frm, Me)
    End Sub

    Private Sub btnAulaAlumnos_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAulaAlumnos.ItemClick
        Dim frm As New frmAulaAlumnos_ListaAlumnos()
        AbrirForm(frm, Me)
    End Sub

    Private Sub btnPaseLista_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnPaseLista.ItemClick
        Dim frm As New frmAulaAlumnos_PaseLista()
        AbrirForm(frm, Me)
    End Sub
    Private Sub btnCalendario_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCalendario.ItemClick
        Dim frm As New frm_Actividades_Tareas_Calendario()
        AbrirForm(frm, Me)
    End Sub

    Private Sub btnConfiguracionAplicacionPeriodos_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnConfiguracionAplicacionPeriodos.ItemClick
        Dim frm As New frmConfiguraPeriodos()
        AbrirForm(frm, Me)
    End Sub

#End Region
    Private Sub CargaConfiguracion(Optional ByVal pAula As Integer = 0)
        DevExpress.XtraBars.Helpers.SkinHelper.InitSkinGallery(SkinRibbonGalleryBarItem1)
        UserLookAndFeel.Default.SkinName = My.MySettings.Default("ApplicationSkinName").ToString()
        ricbAulas.Items.Clear()
        Configuracion = clConfiguracion.GetConfiguracionUsuario()
        If Not IsNothing(Configuracion) Then
            btnConficuraiconAplicacionConfiguracionAulas.Enabled = True
            With Configuracion
                My.Settings.IdUsuario = .Id
                Aulas = clAulas.GetAulasExistentes(.Id)
                If Aulas.Count > 0 Then
                    btnConficuraiconAplicacionConfiguracionMaterias.Enabled = True
                    btnConfiguracionSeguridad.Enabled = True
                    btnAulaAlumnos.Enabled = True
                    btnPaseLista.Enabled = True
                    btnCalendario.Enabled = True
                    For Each Aula In Aulas
                        Dim item As String = String.Format("{0}-{1}", Aula.Grado, Aula.Grupo)
                        ricbAulas.Items.Add(item)
                    Next
                    beAulas.EditValue = String.Format("{0}-{1}", Aulas.FirstOrDefault.Grado, Aulas.FirstOrDefault.Grupo)
                    If pAula = 0 Then
                        My.Settings.IdAulaActual = Aulas.FirstOrDefault.IdAula
                    Else
                        My.Settings.IdAulaActual = Aulas.Where(Function(x) x.IdAula = pAula).FirstOrDefault.IdAula
                    End If
                Else
                    btnConficuraiconAplicacionConfiguracionMaterias.Enabled = False
                    btnConfiguracionSeguridad.Enabled = False
                    btnAulaAlumnos.Enabled = False
                    btnPaseLista.Enabled = False
                    btnCalendario.Enabled = False

                    For Each llamado As Form In Me.MdiChildren
                        llamado.Close()
                    Next
                End If
            End With
        Else
            btnConficuraiconAplicacionConfiguracionAulas.Enabled = False
            btnConficuraiconAplicacionConfiguracionMaterias.Enabled = False
            btnConfiguracionSeguridad.Enabled = False
            btnAulaAlumnos.Enabled = False
            btnPaseLista.Enabled = False
            btnCalendario.Enabled = False

            For Each llamado As Form In Me.MdiChildren
                llamado.Close()
            Next
        End If
    End Sub

    Private Sub FrmPrincipal_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        My.MySettings.Default("ApplicationSkinName") = UserLookAndFeel.Default.SkinName
        My.MySettings.Default.Save()
    End Sub

    Private Sub bbRefrescar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbRefrescar.ItemClick
        If My.Settings.IdAulaActual > 0 Then
            CargaConfiguracion(My.Settings.IdAulaActual)
        End If
    End Sub

#End Region
#End Region
#Region "Logica"

#End Region
#Region "Validaciones"
#End Region

End Class
