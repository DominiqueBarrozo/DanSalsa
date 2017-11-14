Public Class EscritorioDanSalsa

    Private Sub btn_salir_Click(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing, btn_salir.Click
        If MsgBox("Seguro que desea salir de la aplicación?", MsgBoxStyle.Question + MsgBoxStyle.OkCancel, "Aviso") = 1 Then
            End
        Else
            Dim result As DialogResult
            Dim flogin As New LoginForm1
            result = flogin.ShowDialog()
            If (result = DialogResult.OK) Then
                Me.Visible = True
            Else
                Me.Close()
            End If
        End If
    End Sub
    Private Sub Frm_Principal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Al cargar el formulario principal cargamos y mostramos el formulario: Frm_login en forma MODAL.
        'PictureBox1.Width = Me.Width
        Me.Visible = False
        Dim frmInicial As New fInicial()
        frmInicial.MdiParent = Me
        frmInicial.Show()

        Dim result As DialogResult
        Dim flogin As New LoginForm1

        result = flogin.ShowDialog()
        If (result = DialogResult.OK) Then
            Me.Visible = True
        Else
            Me.Close()
        End If

    End Sub
    Public Sub actualizarUsuarioLogueado(ByVal userLogin As String)
        'lbl_user.Text = userLogin
        btn_alumnos.Visible = True
        btn_profesor.Visible = True
        btn_salir.Visible = True
        btn_asistencia.Visible = True
        btn_informe.Visible = True
        btn_informe.visible = True
    End Sub
    Private Sub ConsultaDeBugsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        fAbmAlumnos.ShowDialog()
    End Sub

    Private Sub btn_salir_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub btUsuarios_Click(sender As Object, e As EventArgs) Handles btUsuarios.Click
        Dim fAbmUsuarios As New fAbmUsuarios
        fAbmUsuarios.MdiParent = Me
        fAbmUsuarios.Show()

    End Sub

    Private Sub btn_profesor_Click(sender As Object, e As EventArgs) Handles btn_profesor.Click
        Dim fAbmProfesores As New fAbmProfesor
        fAbmProfesores.MdiParent = Me
        fAbmProfesores.Show()

    End Sub

    Private Sub btn_alumnos_Click(sender As Object, e As EventArgs) Handles btn_alumnos.Click
        Dim fAbmAlumnos As New fAbmAlumnos
        fAbmAlumnos.MdiParent = Me
        fAbmAlumnos.Show()
    End Sub

    Private Sub btRitmo_Click(sender As Object, e As EventArgs) Handles btRitmo.Click
        Dim fAbmRitmo As New fAbmRitmo
        fAbmRitmo.MdiParent = Me
        fAbmRitmo.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim fAbmClase As New fAbmClases
        fAbmClase.MdiParent = Me
        fAbmClase.Show()
    End Sub

    Private Sub btn_inscripcion_Click(sender As Object, e As EventArgs) Handles btn_inscripcion.Click
        Dim fAbmInscripciones As New Inscripcion
        fAbmInscripciones.MdiParent = Me
        fAbmInscripciones.Show()
    End Sub

    Private Sub btn_estadistica_Click(sender As Object, e As EventArgs) Handles btn_informe.Click
        Dim fInformes As New Informes
        fInformes.MdiParent = Me


        fInformes.Show()
    End Sub

    Private Sub btn_Asistencia_Click(sender As Object, e As EventArgs) Handles btn_Asistencia.Click
        Dim fAsistencia As New RegistrarAsistencia
        fAsistencia.MdiParent = Me
        fAsistencia.Asistencia()

        fAsistencia.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim fEstadistica As New Estadisticas
        fEstadistica.MdiParent = Me
        fEstadistica.Show()
    End Sub
End Class