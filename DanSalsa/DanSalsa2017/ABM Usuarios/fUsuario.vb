Public Class fUsuario
    Enum Operaciones
        Nuevo
        Modificar
        Desactivar
    End Enum
    Dim vOperaciones As Operaciones

    Public Sub Nuevo()
        Me.Text = "Nuevo Usuario"
        Dim oNegocio As New nUsuario()
        lbId.Text = oNegocio.maximo.ToString()
        vOperaciones = Operaciones.Nuevo
    End Sub

    Public Sub Modificar(oUsuario As eUsuarios)
        Me.Text = "Modificar Usuario"
        vOperaciones = Operaciones.Modificar
        lbId.Text = oUsuario.id.ToString()
        txNombre.Text = oUsuario.nombre
        txPassword.Text = oUsuario.password
        txLogin.Text = oUsuario.login
        txApellido.Text = oUsuario.apellido
        chActivo.Checked = (oUsuario.activo = 1)
    End Sub

    Public Sub Desactivar(oUsuario As eUsuarios)
        Me.Text = "Desactivar Usuario"
        vOperaciones = Operaciones.Desactivar
        lbId.Text = oUsuario.id.ToString()
        txNombre.Text = oUsuario.nombre
        txPassword.Text = oUsuario.password
        txLogin.Text = oUsuario.login
        txApellido.Text = oUsuario.apellido
        chActivo.Checked = (oUsuario.activo = 1)
        Guardar(oUsuario)
    End Sub

    Private Sub btGuardar_Click(sender As Object, e As EventArgs) Handles btGuardar.Click
        If (Validar()) Then
            Dim oUsuario As New eUsuarios
            oUsuario.id = Int32.Parse(lbId.Text)
            oUsuario.nombre = txNombre.Text
            oUsuario.apellido = txApellido.Text
            If (chActivo.Checked) Then
                oUsuario.activo = 1
            Else
                oUsuario.activo = 0
            End If
            oUsuario.login = txLogin.Text
            oUsuario.password = txPassword.Text
            Guardar(oUsuario)
        End If
    End Sub
    Private Function Validar() As Boolean

        Return True
    End Function

    Private Sub Guardar(oUsuario As eUsuarios)
        Dim onUsuario As New nUsuario()
        Select Case vOperaciones
            Case Operaciones.Nuevo
                onUsuario.guardar(oUsuario)
                MessageBox.Show("Usuario creado correctamente")
            Case Operaciones.Modificar
                onUsuario.modificar(oUsuario)
                MessageBox.Show("Usuario modificado correctamente")
            Case Operaciones.Desactivar
                onUsuario.cambiarEstado(oUsuario)
                MessageBox.Show("Usuario desactivo correctamente")
        End Select
        Me.Close()
    End Sub

    Private Sub btCancelar_Click(sender As Object, e As EventArgs) Handles btCancelar.Click
        Close()
    End Sub

    Private Sub fProfesor_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class