Imports System.ComponentModel

Public Class Login
    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click

        If txtUsuario.Text = "" And txtContrasena.Text = "" Then
            MsgBox("debe de llenar los campos")
        ElseIf txtUsuario.Text = My.Settings.Usuario And txtContrasena.Text = My.Settings.Clave Then
            MsgBox("Usuario y contrasena correctos")
            Me.Hide()
            IngresaVotante.Show()
        Else
            MsgBox("Usuario y contrasena incorrecto")
        End If
    End Sub

    Private Sub txtContrasena_Validating(sender As Object, e As CancelEventArgs) Handles txtContrasena.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 And txtContrasena.Text = "" Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, " Campo es obligatorio ")
        End If
    End Sub

    Private Sub txtContrasena_MouseHover(sender As Object, e As EventArgs) Handles txtContrasena.MouseHover
        ToolTip.SetToolTip(txtContrasena, "Ingrese su contrasena")
        ToolTip.ToolTipTitle = "Aviso"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtUsuario_Validating(sender As Object, e As CancelEventArgs) Handles txtUsuario.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 And txtUsuario.Text = "" Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, " Campo es obligatorio ")
        End If
    End Sub

    Private Sub txtUsuario_MouseHover(sender As Object, e As EventArgs) Handles txtUsuario.MouseHover
        ToolTip.SetToolTip(txtUsuario, "Ingrese su Usuario")
        ToolTip.ToolTipTitle = "Aviso"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub


End Class