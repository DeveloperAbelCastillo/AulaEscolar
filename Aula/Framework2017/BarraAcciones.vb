Public Class BarraAcciones

    Public Event eAgregar()
    Public Event eEditar()
    Public Event eEliminar()

    Public Property pAgregar() As Boolean
        Get
            Return btnAgregar.Enabled
        End Get
        Set(ByVal value As Boolean)
            btnAgregar.Enabled = value
            If value Then
                btnAgregar.Glyph = My.Resources.add_16
            Else
                btnAgregar.Glyph = My.Resources.add_16_
            End If
        End Set
    End Property

    Public Property pEditar() As Boolean
        Get
            Return btnEditar.Enabled
        End Get
        Set(ByVal value As Boolean)
            btnEditar.Enabled = value
            If value Then
                btnEditar.Glyph = My.Resources.edit_16
            Else
                btnEditar.Glyph = My.Resources.edit_16_
            End If
        End Set
    End Property

    Public Property pEliminar() As Boolean
        Get
            Return btnEliminar.Enabled
        End Get
        Set(ByVal value As Boolean)
            btnEliminar.Enabled = value
            If value Then
                btnEliminar.Glyph = My.Resources.delete_16
            Else
                btnEliminar.Glyph = My.Resources.delete_16_
            End If
        End Set
    End Property

    Public WriteOnly Property pProceso() As String
        Set(ByVal value As String)
            lblProceso.Caption = value
            lblProceso.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
            Timer.Start()
        End Set
    End Property

    Private Sub btnAgregar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAgregar.ItemClick
        RaiseEvent eAgregar()
    End Sub

    Private Sub btnEditar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnEditar.ItemClick
        RaiseEvent eEditar()
    End Sub

    Private Sub btnEliminar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnEliminar.ItemClick
        RaiseEvent eEliminar()
    End Sub

    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        Timer.Stop()
        lblProceso.Caption = ""
        lblProceso.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
    End Sub
End Class
