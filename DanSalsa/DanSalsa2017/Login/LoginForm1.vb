Public Class LoginForm1
    Private flagSalir As Boolean = True
    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        'Dim strSQL As String
        'Dim tabla As DataTable
        'Validamos que las cajas no esten vacías
        'If String.IsNullOrEmpty(txt_password.Text) Or String.IsNullOrEmpty(txt_usuario.Text) Then
        If txt_password.Text = String.Empty Or txt_usuario.Text = String.Empty Then
            MessageBox.Show("Olvidó ingresar nombre y/o legajo", "Validación de datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            'strSQL = "select u.nombre from Persona u where u.nombre = '" & txt_usuario.Text
            'strSQL += "' AND u.dni='" & txt_password.Text & "'"
            'tabla = BDHelper.getDBHelper().ConsultaSQL(strSQL)
            '    If tabla.Rows.Count > 0 Then
            '    EscritorioDanSalsa.actualizarUsuarioLogueado("Persona: " & txt_usuario.Text)
            '    flagSalir = False
            '    Me.Close()
            '    Else
            '    MessageBox.Show("Nombre y/o legajo incorrectos", "Validación de datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
            '    'Limpiamos las cajas de texto y dejamos el cursor sobre el control: txt_usuario.
            '    txt_password.Text = String.Empty
            '        txt_usuario.Text = String.Empty
            '        txt_usuario.Focus()
            '    End If
            Dim onusuario As New nUsuario
            If onusuario.validar(txt_usuario.Text, txt_password.Text) Then
                DialogResult = DialogResult.OK
                Me.Close()
            Else
                MessageBox.Show("Nombre y/o legajo incorrectos", "Validación de datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
                'Limpiamos las cajas de texto y dejamos el cursor sobre el control: txt_usuario.
                txt_password.Text = String.Empty
                txt_usuario.Text = String.Empty
                txt_usuario.Focus()
            End If
        End If
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub


End Class
