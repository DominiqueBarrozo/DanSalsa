Public Class fClase
    Enum Operaciones
        Nuevo
        Modificar
        Desactivar
    End Enum
    Dim vOperaciones As Operaciones
    Private Sub btGuardar_Click(sender As Object, e As EventArgs) Handles btGuardar.Click
        If (Validar()) Then
            Dim oClase As New eClase

            oClase.Id = Int32.Parse(lbId.Text)
            oClase.IdProfesor = Int32.Parse(cb_profesor.SelectedValue)
            oClase.IdRitmo = Int32.Parse(cbRitmo.SelectedValue)
            oClase.Descripcion = txDescripcion.Text
            oClase.Nombre = txNombre.Text
            oClase.Monto = Double.Parse(tx_monto.Text)
            guardar(oClase)
        End If
    End Sub
    Private Function Validar() As Boolean

        Return True
    End Function

    Private Sub fClase_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim onritmo As New nRitmo
        Dim olritmo As New List(Of eRitmo)

        olritmo = onritmo.listar
        cbRitmo.DataSource = olritmo
        cbRitmo.DisplayMember = "nombre"
        cbRitmo.ValueMember = "id"
        cbRitmo.Refresh()

        Dim onprofesor As New nProfesores
        Dim olprofesores As New List(Of eProfesores)

        olprofesores = onprofesor.listar("")
        cb_profesor.DataSource = olprofesores
        cb_profesor.DisplayMember = "nombre"
        cb_profesor.ValueMember = "id"
        cb_profesor.Refresh()
    End Sub

    Private Sub btCancelar_Click(sender As Object, e As EventArgs) Handles btCancelar.Click
        Me.Close()
    End Sub
    Public Sub guardar(oclase As eClase)
        Dim onclase As New nClases()
        Select Case vOperaciones
            Case Operaciones.Nuevo
                onclase.guardar(oclase)
                MessageBox.Show("Clase creada correctamente")
            Case Operaciones.Modificar
                onclase.modificar(oclase)
                MessageBox.Show("Clase modificada correctamente")

        End Select
        Me.Close()
    End Sub
    Public Sub nuevo()
        Dim noclase As New nClases
        vOperaciones = Operaciones.Nuevo
        Me.Text = "Nueva Clase"
        lbId.Text = noclase.maximo.ToString
    End Sub
    Public Sub modificar(oclase As eClase)
        vOperaciones = Operaciones.Modificar
        Me.Text = "Modificar Clase"
        txNombre.Text = oclase.Nombre
        txDescripcion.Text = oclase.Descripcion
        tx_monto.Text = oclase.Monto.ToString
        cbRitmo.SelectedValue = oclase.IdRitmo
        cb_profesor.SelectedValue = oclase.IdProfesor
        lbId.Text = oclase.Id.ToString


    End Sub
End Class