Public Class fAbmProfesor
    Private Sub btBuscar_Click(sender As Object, e As EventArgs) Handles btBuscar.Click
        Dim olProfesores As New List(Of eProfesores)
        Dim onProfesores As New nProfesores
        olProfesores = onProfesores.listar(txApellido.Text)
        bsProfesor.DataSource = olProfesores
        gProfesores.Refresh()
    End Sub

    Private Sub btNuevo_Click(sender As Object, e As EventArgs) Handles btNuevo.Click
        Dim fProfesor As New fProfesores
        fProfesor.Nuevo()
        fProfesor.MdiParent = Me.MdiParent
        fProfesor.Show()
    End Sub

    Private Sub btModificar_Click(sender As Object, e As EventArgs) Handles btModificar.Click
        Dim fProfesor As New fProfesores
        Dim oProfesor As New eProfesores
        oProfesor = CType(bsProfesor.Current(), eProfesores)
        fProfesor.Modificar(oProfesor)
        fProfesor.MdiParent = Me.MdiParent
        fProfesor.Show()
    End Sub
End Class