﻿Imports System.ComponentModel

Public Class IngresaVotante
    Dim conexion As conexion = New conexion()
    Private Sub btnAcceder_Click(sender As Object, e As EventArgs) Handles btnAcceder.Click
        Dim estado, Voto As String
        Dim identidad As String
        If txtidentidad.Text.Length = 13 Then
            identidad = txtidentidad.Text
            estado = conexion.RecuperarDatos(identidad, 0)
            Voto = conexion.RecuperarDatos(identidad, 1)
            MsgBox(estado)
            MsgBox(Voto)
            If estado = "activo" And Voto = "F" Then
                'accederia al siguiente formulario aca

            ElseIf estado <> "eliminado" And Voto = "V" Then
                MessageBox.Show("La persona ya ha realizado la votación. Debera acceder otra persona", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)

            ElseIf estado = "eliminado" And Voto <> "F" Then
                MessageBox.Show("La persona no se encuentra activa para realizar la votacion", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)

            End If
        Else
            MessageBox.Show("Debe ingresar un numero de identidad valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub txtidentidad_Validating(sender As Object, e As CancelEventArgs) Handles txtidentidad.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 And txtidentidad.Text = "" Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, " Campo es obligatorio ")
        End If
    End Sub

    Private Sub txtidentidad_MouseHover(sender As Object, e As EventArgs) Handles txtidentidad.MouseHover
        ToolTip.SetToolTip(txtidentidad, "Ingrese su numero de identidad")
        ToolTip.ToolTipTitle = "Aviso"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub btnAcceder_MouseHover(sender As Object, e As EventArgs) Handles btnAcceder.MouseHover
        ToolTip.SetToolTip(btnAcceder, "Acceder para ejercer el voto")
        ToolTip.ToolTipTitle = "Aviso"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtidentidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtidentidad.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        ElseIf Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
End Class
