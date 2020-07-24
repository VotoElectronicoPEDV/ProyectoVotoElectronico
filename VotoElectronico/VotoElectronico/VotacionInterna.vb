Imports System.ComponentModel

Public Class VotacionInterna
    Private Sub btnAcceder_Click(sender As Object, e As EventArgs) Handles btnAcceder.Click

    End Sub

    Private Sub txtidentidad_TextChanged(sender As Object, e As EventArgs) Handles txtidentidad.TextChanged

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
End Class
