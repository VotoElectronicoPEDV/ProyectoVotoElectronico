Public Class Registro

    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        'My.setting expone cada configuración como una propiedad. El nombre de la propiedad es el mismo 
        'que el nombre de la configuración, y el tipo de propiedad es el mismo
        If txtconfirmar.Text = txtcontrasena.Text Then
            MsgBox("correctos")
            My.Settings.Usuario = txtUsuario.Text
            My.Settings.Save()
            My.Settings.Reload()

            My.Settings.Email = txtemail.Text
            My.Settings.Save()
            My.Settings.Reload()

            My.Settings.Clave = txtcontrasena.Text
            My.Settings.Save()
            My.Settings.Reload()

            Me.Hide()
            Login.Show()
        ElseIf txtconfirmar.Text <> txtcontrasena.Text Then
            MsgBox("Debe de ingresar correctamente ambas contrasenas")

        End If

    End Sub
End Class