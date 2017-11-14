Public Class fProfesores
    Enum Operaciones
        Nuevo
        Modificar
        Desactivar
    End Enum
    Dim vOperaciones As Operaciones

    Public Sub Nuevo()
        Me.Text = "Nuevo Profesor"
        Dim oNegocio As New nProfesores()
        lbId.Text = oNegocio.maximo.ToString()
        vOperaciones = Operaciones.Nuevo
    End Sub

    Public Sub Modificar(oProfesor As eProfesores)
        Me.Text = "Modificar profesor"
        vOperaciones = Operaciones.Modificar
        lbId.Text = oProfesor.Id.ToString()
        txNombre.Text = oProfesor.Nombre
        txTelefono.Text = oProfesor.Telefono.ToString
        txNumero.Text = oProfesor.NroDoc.ToString
        txApellido.Text = oProfesor.Apellido.ToString
        cbTipo.Text = oProfesor.TipoDoc
        rbMasculino.Checked = (oProfesor.Sexo = 1)
        rbFemenino.Checked = Not (oProfesor.Sexo = 1)
    End Sub

    Private Sub Guardar(oProfesor As eProfesores)
        Dim onProfesor As New nProfesores()
        Select Case vOperaciones
            Case Operaciones.Nuevo
                onProfesor.guardar(oProfesor)
                MessageBox.Show("Profesor creado correctamente")
            Case Operaciones.Modificar
                onProfesor.modificar(oProfesor)
                MessageBox.Show("Profesor modificado correctamente")

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
            Dim oProfesor As New eProfesores
            oProfesor.Id = Int32.Parse(lbId.Text)
            oProfesor.Nombre = txNombre.Text
            oProfesor.Apellido = txApellido.Text
            If (String.IsNullOrEmpty(txNumero.Text)) Then
                oProfesor.NroDoc = 0
            Else
                oProfesor.NroDoc = Int32.Parse(txNumero.Text)
            End If

            oProfesor.TipoDoc = cbTipo.Text
            If (rbMasculino.Checked) Then
                oProfesor.Sexo = 1
            Else
                oProfesor.Sexo = 0
            End If
            Guardar(oProfesor)
        End If
    End Sub
End Class