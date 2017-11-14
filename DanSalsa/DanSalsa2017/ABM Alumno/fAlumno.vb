Public Class fAlumno
    Enum Operaciones
        Nuevo
        Modificar
        Desactivar
    End Enum
    Dim vOperaciones As Operaciones

    Public Sub Nuevo()
        Me.Text = "Nuevo Alumno"
        Dim oNegocio As New nAlumnos()
        lbId.Text = oNegocio.maximo.ToString()
        vOperaciones = Operaciones.Nuevo
    End Sub

    Public Sub Modificar(oAlumno As eAlumnos)
        Me.Text = "Modificar alumno"
        vOperaciones = Operaciones.Modificar
        lbId.Text = oAlumno.Id.ToString()
        txNombre.Text = oAlumno.Nombre
        txTelefono.Text = oAlumno.Telefono.ToString
        txNumero.Text = oAlumno.NroDoc.ToString
        txApellido.Text = oAlumno.Apellido.ToString
        cbTipo.Text = oAlumno.TipoDoc
        txtCalle.Text = oAlumno.Calle
        txtLegajo.Text = oAlumno.Legajo
        txtFechaNac.Text = oAlumno.FechaNac
        txtNro.Text = oAlumno.Nro.ToString
        chActivo.Text = oAlumno.Activo
        rbMasculino.Checked = (oAlumno.Sexo = 1)
        rbFemenino.Checked = Not (oAlumno.Sexo = 1)
    End Sub

    Private Sub Guardar(oAlumnos As eAlumnos)
        Dim onAlumnos As New nAlumnos()
        Select Case vOperaciones
            Case Operaciones.Nuevo
                onAlumnos.guardar(oAlumnos)
                MessageBox.Show("Alumno creado correctamente")
            Case Operaciones.Modificar
                onAlumnos.modificar(oAlumnos)
                MessageBox.Show("Usuario modificado correctamente")

        End Select
        Me.Close()
    End Sub

    Private Sub btCancelar_Click(sender As Object, e As EventArgs) Handles btCancelar.Click
        Close()
    End Sub

    Private Function Validar() As Boolean

        Return True
    End Function

    Private Sub btGuardar_Click(sender As Object, e As EventArgs) Handles btGuardar.Click
        If (Validar()) Then
            Dim oAlumnos As New eAlumnos
            oAlumnos.Id = Int32.Parse(lbId.Text)
            oAlumnos.Nombre = txNombre.Text
            oAlumnos.Apellido = txApellido.Text
            oAlumnos.NroDoc = txNumero.Text
            oAlumnos.TipoDoc = cbTipo.Text
            If (chActivo.Checked) Then
                oAlumnos.Activo = 1
            Else
                oAlumnos.Activo = 0
            End If
            If (rbMasculino.Checked) Then
                oAlumnos.Sexo = 1
            Else
                oAlumnos.Sexo = 0
            End If
            oAlumnos.Calle = txtCalle.Text
            oAlumnos.Nro = Int32.Parse(txtNro.Text)

            Guardar(oAlumnos)
        End If
    End Sub
End Class