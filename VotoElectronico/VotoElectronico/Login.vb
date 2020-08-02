Imports System.ComponentModel

Public Class Login
    Dim conexion As New conexion
    Private Sub CustomizeComponents()

        txtUsuario.AutoSize = False
        txtUsuario.Size = New Size(250, 30)

        txtContrasena.AutoSize = False
        txtContrasena.Size = New Size(250, 30)
        txtContrasena.UseSystemPasswordChar = True
    End Sub
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CustomizeComponents()
    End Sub
    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Dim contrasenabd, identidad, contraseña As String
        identidad = txtUsuario.Text

        contraseña = txtContrasena.Text
        Try
            contrasenabd = conexion.validaradministrador(identidad, 2)
            If contraseña = contrasenabd And contrasenabd <> String.Empty Then
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
        MsgBox("Juan Orlando GANO!")
    End Sub
End Class