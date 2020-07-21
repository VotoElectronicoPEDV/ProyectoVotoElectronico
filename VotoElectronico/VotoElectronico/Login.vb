Public Class Login
    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        If txtUsuario.Text = My.Settings.Usuario And txtContrasena.Text = My.Settings.Clave Then
            MsgBox("Usuario y contrasena correctos")
            Me.Hide()
            VotacionInterna.Show()
        Else
            MsgBox("Usuario y contrasena incorrecto")
        End If
    End Sub
End Class