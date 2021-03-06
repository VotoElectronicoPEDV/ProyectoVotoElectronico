﻿Imports System.ComponentModel

Public Class Login
    Dim conexion As New conexion


    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Dim contrasenabd, identidad, contraseña As String
        identidad = txtUsuario.Text

        contraseña = txtContrasena.Text
        Try
            contrasenabd = conexion.validaradministrador(identidad, 2)
            If contraseña = contrasenabd And contrasenabd <> String.Empty Then
                txtContrasena.Clear()
                txtUsuario.Clear()
                Me.Hide()
                AdministradorVotaciones.Show()

            ElseIf contrasenabd = String.Empty Then
                MessageBox.Show("El administrador no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                MessageBox.Show("Contrasena incorrecta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtContrasena_Validating(sender As Object, e As CancelEventArgs)
        If DirectCast(sender, TextBox).Text.Length > 0 And txtContrasena.Text = "" Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, " Campo es obligatorio ")
        End If
    End Sub

    Private Sub txtContrasena_MouseHover(sender As Object, e As EventArgs)
        ToolTip.SetToolTip(txtContrasena, "Ingrese su contrasena")
        ToolTip.ToolTipTitle = "Aviso"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtUsuario_Validating(sender As Object, e As CancelEventArgs)
        If DirectCast(sender, TextBox).Text.Length > 0 And txtUsuario.Text = "" Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, " Campo es obligatorio ")
        End If
    End Sub

    Private Sub txtUsuario_MouseHover(sender As Object, e As EventArgs)
        ToolTip.SetToolTip(txtUsuario, "Ingrese su Usuario")
        ToolTip.ToolTipTitle = "Aviso"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub btnREGRESAR_Click(sender As Object, e As EventArgs) Handles btnREGRESAR.Click
        txtContrasena.Clear()
        txtUsuario.Clear()
        Me.Hide()
        IngresaVotante.Show()

    End Sub

    Private Sub txtUsuario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUsuario.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub btnBROMA_Click(sender As Object, e As EventArgs) Handles btnBROMA.Click
        Me.Hide()
        CargandoFallo.Show()
    End Sub

    Private Sub OptVer_Click(sender As Object, e As EventArgs) Handles OptVer.Click
        txtContrasena.PasswordChar = ""
        optOcultar.Visible = True
        OptVer.Visible = False
    End Sub

    Private Sub optOcultar_Click(sender As Object, e As EventArgs) Handles optOcultar.Click
        txtContrasena.PasswordChar = "*"
        optOcultar.Visible = False
        OptVer.Visible = True
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtContrasena.PasswordChar = "*"
        optOcultar.Visible = False
        OptVer.Visible = True
    End Sub
End Class