﻿Imports System.ComponentModel

Public Class IngresaVotante
    Dim conexion As conexion = New conexion()
    Private Sub btnAcceder_Click(sender As Object, e As EventArgs) Handles btnAcceder.Click
        Dim estado, Voto, Nombre As String
        Dim identidad As String
        Try
            If eleccionVotante.descripcionVotacion <> 0 Then
                If txtidentidad.Text.Length = 13 Then
                    Dim municipio As String
                    municipio = txtidentidad.Text.Substring(2, 2)
                    identidad = txtidentidad.Text
                    estado = conexion.RecuperarDatos(identidad, 0)
                    Voto = conexion.RecuperarDatos(identidad, 1)
                    Nombre = conexion.RecuperarDatos(identidad, 2)
                    eleccionVotante.idVotante = identidad
                    eleccionVotante.idmunicipio = municipio


                    If estado = "activo" And Voto = "F" Then
                        MessageBox.Show("Bienvenido " + Nombre, "Ingresando", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        txtidentidad.Clear()

                        Me.Hide()
                        votacionInterna.Show()

                    ElseIf estado <> "eliminado" And Voto = "V" Then
                        MessageBox.Show("La persona ya ha realizado la votación. Debera acceder otra persona", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        txtidentidad.Clear()

                    ElseIf estado = "eliminado" And Voto <> "F" Then
                        MessageBox.Show("La persona no se encuentra activa para realizar la votacion", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        txtidentidad.Clear()

                    ElseIf estado = "" And Voto = "" Then
                        MessageBox.Show("Esta persona no existe en la base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        txtidentidad.Clear()

                    End If

                Else
                    MessageBox.Show("Debe ingresar un numero de identidad valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                MessageBox.Show("Votacion no disponible aún", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

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



    Private Sub btnAdmin_Click(sender As Object, e As EventArgs) Handles btnAdmin.Click
        txtidentidad.Clear()
        Me.Hide()
        Login.Show()
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

    Private Sub btnAdmin_MouseHover(sender As Object, e As EventArgs) Handles btnAdmin.MouseHover
        ToolTip.SetToolTip(btnAdmin, "Accede el administrador")
        ToolTip.ToolTipTitle = "Aviso"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub
End Class
