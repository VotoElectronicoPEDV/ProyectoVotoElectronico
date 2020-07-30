﻿Imports System.ComponentModel

Public Class Login
    Dim conexion As New conexion
    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Dim contrasena, identidad As String
        identidad = txtUsuario.Text
        Try
            contrasena = conexion.validaradministrador(identidad, 2)
            If txtContrasena.Text = contrasena Then
                Me.Hide()
                AdministradorVotaciones.Show()
            ElseIf contrasena = String.Empty Then
                MessageBox.Show("El administrador no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                MessageBox.Show("Contrasena incorrepta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
        Me.Hide()
        IngresaVotante.Show()

    End Sub

    Private Sub txtUsuario_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub BtnMinimizar_Click(sender As Object, e As EventArgs) Handles BtnMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
End Class