Public Class fAbmUsuarios


    Private Sub btBuscar_Click(sender As Object, e As EventArgs) Handles btBuscar.Click
        Dim olUsuarios As New List(Of eUsuarios)
        Dim onUsuario As New nUsuario
        olUsuarios = onUsuario.listar(txApellido.Text)
        bsusuarios.DataSource = olUsuarios
        gUsuarios.Refresh()

    End Sub

    Private Sub btNuevo_Click(sender As Object, e As EventArgs) Handles btNuevo.Click
        Dim fusuario As New fUsuario
        fusuario.MdiParent = Me.MdiParent
        fusuario.Nuevo()
        fusuario.Show()
    End Sub

    Private Sub btModificar_Click(sender As Object, e As EventArgs) Handles btModificar.Click
        Dim fusuario As New fUsuario
        Dim oUsuario As New eUsuarios
        oUsuario = CType(bsusuarios.Current(), eUsuarios)
        fusuario.Modificar(oUsuario)
        fusuario.MdiParent = Me.MdiParent
        fusuario.Show()
    End Sub

    Private Sub btElminar_Click(sender As Object, e As EventArgs) Handles btElminar.Click
        Dim fusuario As New fUsuario
        Dim oUsuario As New eUsuarios
        oUsuario = CType(bsusuarios.Current(), eUsuarios)
        fusuario.Desactivar(oUsuario)
    End Sub
End Class