Public Class Inscripcion

    Private Sub Inscripcion_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btBuscar_Click(sender As Object, e As EventArgs) Handles btBuscar.Click
        Dim olAumnos As New List(Of eAlumnos)
        Dim onAlumnos As New nAlumnos
        olAumnos = onAlumnos.listar(txnombre.Text)
        bsAlumno.DataSource = olAumnos
        gAlumno.Refresh()
    End Sub

    Private Sub txnombre_TextChanged(sender As Object, e As EventArgs) Handles txnombre.TextChanged

    End Sub

    Private Sub gAlumno_SelectionChanged(sender As Object, e As EventArgs) Handles gAlumno.SelectionChanged
        Dim onInscripcion As New nInscripcion
        Dim oAlumno As eAlumnos
        oAlumno = CType(bsAlumno.Current(), eAlumnos)
        If (Not IsNothing(oAlumno)) Then
            Dim olInscripciones As New List(Of eInscripcion)
            olInscripciones = onInscripcion.listar(oAlumno.Id)
            bsInscripcion.DataSource = olInscripciones
            gClases.Refresh()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)




    End Sub

    Private Sub btNuevo_Click(sender As Object, e As EventArgs) Handles btNuevo.Click

        Dim oAlumno As New eAlumnos
        oAlumno = CType(bsAlumno.Current, eAlumnos)

        Dim fNuevaInscripcion As New Nueva_Inscripcion
        fNuevaInscripcion.MdiParent = Me.MdiParent
        fNuevaInscripcion.Inscripcion(oAlumno)

        fNuevaInscripcion.Show()

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class