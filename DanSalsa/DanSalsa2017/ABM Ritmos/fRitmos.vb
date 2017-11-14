Public Class fRitmos
    Enum Operaciones
        Nuevo
        Modificar
        Desactivar
    End Enum
    Dim vOperaciones As Operaciones

    Public Sub Nuevo()
        Me.Text = "Nuevo Ritmo"
        Dim oNegocio As New nRitmo()
        lbId.Text = oNegocio.maximo.ToString()
        vOperaciones = Operaciones.Nuevo
    End Sub

    Public Sub Modificar(oritmo As eRitmo)
        Me.Text = "Modificar ritmo"
        vOperaciones = Operaciones.Modificar
        lbId.Text = oritmo.Id.ToString()
        txNombre.Text = oritmo.Nombre
    End Sub

    Private Sub Guardar(oritmo As eRitmo)
        Dim onRitmo As New nRitmo()
        Select Case vOperaciones
            Case Operaciones.Nuevo
                onRitmo.guardar(oritmo)
                MessageBox.Show("Ritmo creado correctamente")
            Case Operaciones.Modificar
                onRitmo.modificar(oritmo)
                MessageBox.Show("Ritmo modificado correctamente")

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
            Dim oritmo As New eRitmo
            oritmo.Id = Int32.Parse(lbId.Text)
            oritmo.Nombre = txNombre.Text
            Guardar(oritmo)
        End If
    End Sub
End Class