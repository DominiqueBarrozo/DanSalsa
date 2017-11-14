Public Class fAbmRitmo
    Private Sub btBuscar_Click(sender As Object, e As EventArgs) Handles btBuscar.Click
        Dim olRitmo As New List(Of eRitmo)
        Dim onRitmo As New nRitmo
        olRitmo = onRitmo.listar(txApellido.Text)
        bsRitmo.DataSource = olRitmo
        gProfesores.Refresh()
    End Sub

    Private Sub btNuevo_Click(sender As Object, e As EventArgs) Handles btNuevo.Click
        Dim fRitmo As New fRitmos
        fRitmos.Nuevo()
        fRitmos.MdiParent = Me.MdiParent
        fRitmos.Show()
    End Sub

    Private Sub btModificar_Click(sender As Object, e As EventArgs) Handles btModificar.Click
        Dim fRitmos As New fRitmos
        Dim oRitmos As New eRitmo
        oRitmos = CType(bsRitmo.Current(), eRitmo)
        fRitmos.Modificar(oRitmos)
        fRitmos.MdiParent = Me.MdiParent
        fRitmos.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    'Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
    '    Dim fRitmos As New fRitmos
    '    Dim oRitmos As New nRitmo
    '    oRitmos = CType(bsRitmo.Current(), nRitmo)
    '    oRitmos.Eliminar(nRitmo)
    'End Sub
End Class