Public Class RegistrarAsistencia

    Public Sub Asistencia()
        llenarCombo()
    End Sub
    Public Sub llenarCombo()

        Dim olClase As New List(Of eClase)
        Dim onCLase As New nClases

        cbClase.DisplayMember = "Nombre"
        cbClase.ValueMember = "id"

        olClase = onCLase.listar("")
        bsClase.DataSource = olClase

        cbClase.Refresh()
    End Sub
    Public Sub validar(idAlumno As Integer)
        Dim consulta As String
        Dim oClase As New eClase
        Dim odataset As New DataTable
        oClase = CType(bsClase.Current, eClase)

        consulta = "select * from inscripciones where idAlumno=" & idAlumno.ToString & " and idClase=" & oClase.Id.ToString
        odataset = BDHelper.getDBHelper.ConsultaSQL(consulta)

        If (odataset.Rows.Count > 0) Then
            btAsistio.Enabled = True
        Else
            btAsistio.Enabled = False
        End If

    End Sub

    Private Sub RegistrarAsistencia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtfecha.SetDate(Date.Now)

    End Sub

    Private Sub btAsistio_Click(sender As Object, e As EventArgs) Handles btAsistio.Click
        Dim consulta As String
        Dim oClase As eClase
        oClase = CType(bsClase.Current, eClase)
        consulta = "insert asistencia values (" & txLegajo.Text & "," & oClase.Id.ToString & ",'" & dtfecha.SelectionRange.Start.ToString & "');"
        BDHelper.getDBHelper.EjecutarSQL(consulta)
        MessageBox.Show("Se registró la asistencia correctamente")

    End Sub

    Private Sub txLegajo_Leave(sender As Object, e As EventArgs) Handles txLegajo.Leave
        Dim id As Integer
        If (Int32.TryParse(txLegajo.Text, id)) Then
            validar(id)
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim id As Integer
        If (Int32.TryParse(txLegajo.Text, id)) Then
            validar(id)
        End If
    End Sub

    Private Sub btModificar_Click(sender As Object, e As EventArgs) Handles btModificar.Click
        Me.Close()
    End Sub
End Class