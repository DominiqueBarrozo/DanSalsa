Public Class fAbmAlumnos
    Private Sub btBuscar_Click(sender As Object, e As EventArgs) Handles btBuscar.Click
        Dim olAumnos As New List(Of eAlumnos)
        Dim onAlumnos As New nAlumnos
        olAumnos = onAlumnos.listar(txApellido.Text)
        bsAlumno.DataSource = olAumnos
        gAlumnos.Refresh()
    End Sub

    Private Sub btNuevo_Click(sender As Object, e As EventArgs) Handles btNuevo.Click
        Dim fAlumno As New fAlumno
        fAlumno.Nuevo()
        fAlumno.MdiParent = Me.MdiParent
        fAlumno.Show()
    End Sub

    Private Sub btModificar_Click(sender As Object, e As EventArgs) Handles btModificar.Click
        Dim fAlumno As New fAlumno
        Dim oAlumno As New eAlumnos
        oAlumno = CType(bsAlumno.Current(), eAlumnos)
        fAlumno.Modificar(oAlumno)
        fAlumno.MdiParent = Me.MdiParent
        fAlumno.Show()
    End Sub
End Class