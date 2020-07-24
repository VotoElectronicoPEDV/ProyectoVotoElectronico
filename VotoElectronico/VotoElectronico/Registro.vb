﻿Imports System.ComponentModel

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

    Private Sub txtUsuario_MouseHover(sender As Object, e As EventArgs) Handles txtUsuario.MouseHover
        ToolTip.SetToolTip(txtUsuario, "Ingrese su usuario")
        ToolTip.ToolTipTitle = "Aviso"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtemail_TextChanged(sender As Object, e As EventArgs) Handles txtemail.TextChanged

    End Sub

    Private Sub txtemail_MouseHover(sender As Object, e As EventArgs) Handles txtemail.MouseHover
        ToolTip.SetToolTip(txtemail, "Ingrese su email")
        ToolTip.ToolTipTitle = "Aviso"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtcontrasena_TextChanged(sender As Object, e As EventArgs) Handles txtcontrasena.TextChanged

    End Sub

    Private Sub txtcontrasena_MouseHover(sender As Object, e As EventArgs) Handles txtcontrasena.MouseHover
        ToolTip.SetToolTip(txtcontrasena, "Ingrese su contraseña")
        ToolTip.ToolTipTitle = "Aviso"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtconfirmar_TextChanged(sender As Object, e As EventArgs) Handles txtconfirmar.TextChanged

    End Sub

    Private Sub txtconfirmar_MouseHover(sender As Object, e As EventArgs) Handles txtconfirmar.MouseHover
        ToolTip.SetToolTip(txtconfirmar, "Confirme su contraseña")
        ToolTip.ToolTipTitle = "Aviso"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub btnIngresar_MouseHover(sender As Object, e As EventArgs) Handles btnIngresar.MouseHover
        ToolTip.SetToolTip(btnIngresar, "Registrar")
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

    Private Sub txtemail_Validating(sender As Object, e As CancelEventArgs) Handles txtemail.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 And txtemail.Text = "" Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, " Campo es obligatorio ")
        End If
    End Sub

    Private Sub txtcontrasena_Validating(sender As Object, e As CancelEventArgs) Handles txtcontrasena.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 And txtcontrasena.Text = "" Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, " Campo es obligatorio ")
        End If
    End Sub

    Private Sub txtconfirmar_Validating(sender As Object, e As CancelEventArgs) Handles txtconfirmar.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 And txtconfirmar.Text = "" Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, " Campo es obligatorio ")
        End If
    End Sub


End Class