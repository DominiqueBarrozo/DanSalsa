Public Class Nueva_Inscripcion

    Public Sub Inscripcion(oAlumno As eAlumnos)
        Lb_nombre.Text = oAlumno.Apellido & ", " & oAlumno.Nombre
        Lbl_LegajoAlumno.Text = oAlumno.Id
        llenarCombo()
        CargarInscripciones()

    End Sub

    Public Sub llenarCombo()

        Dim olClase As New List(Of eClase)
        Dim onCLase As New nClases

        cb_Clases.DisplayMember = "Nombre"
        cb_Clases.ValueMember = "id"

        olClase = onCLase.listar("")
        bs_Clase.DataSource = olClase

        cb_Clases.Refresh()

    End Sub



    Public Sub CargarInscripciones()

        Dim olInscripcion As New List(Of eInscripcion)
        Dim onInscripcion As New nInscripcion


        olInscripcion = onInscripcion.listar(Int32.Parse(Lbl_LegajoAlumno.Text))
        bs_Incripciones.DataSource = olInscripcion

        g_Inscripciones.Refresh()


    End Sub


    Private Sub btn_Agregar_Click(sender As Object, e As EventArgs) Handles btn_Agregar.Click

        Dim oIncripcione As New eInscripcion
        Dim oClases As New eClase

        oClases = CType(bs_Clase.Current, eClase)

        oIncripcione.idClase = oClases.Id

        oIncripcione.clase = oClases.Nombre

        oIncripcione.fecha = Date.Parse(Date.Now.ToString("dd/MM/yyyy"))
        oIncripcione.idAlumno = Int32.Parse(Lbl_LegajoAlumno.Text)


        bs_Incripciones.Add(oIncripcione)






    End Sub

    Private Sub btGuardar_Click(sender As Object, e As EventArgs) Handles btGuardar.Click

        Dim oInscripcion As New nInscripcion

        oInscripcion.guardar(Int32.Parse(Lbl_LegajoAlumno.Text), bs_Incripciones.List)

        MessageBox.Show(" Guardo correctamente")
        Close()


    End Sub

    Private Sub btCancelar_Click(sender As Object, e As EventArgs) Handles btCancelar.Click
        Close()
    End Sub
End Class