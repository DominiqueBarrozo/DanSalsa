Public Class fAbmClases
    Private Sub btBuscar_Click(sender As Object, e As EventArgs) Handles btBuscar.Click
        Dim olclase As New List(Of eClase)
        Dim onclase As New nClases
        olclase = onclase.listar(txnombre.Text)
        bsclase.DataSource = olclase
        gClase.Refresh()
    End Sub

    Private Sub btNuevo_Click(sender As Object, e As EventArgs) Handles btNuevo.Click
        Dim fclase As New fClase
        fclase.Nuevo()
        fclase.MdiParent = Me.MdiParent
        fclase.Show()
    End Sub

    Private Sub btModificar_Click(sender As Object, e As EventArgs) Handles btModificar.Click
        Dim fclase As New fClase
        Dim oclase As New eClase
        oclase = CType(bsclase.Current(), eClase)
        fclase.modificar(oclase)
        fclase.MdiParent = Me.MdiParent
        fclase.Show()
    End Sub
End Class