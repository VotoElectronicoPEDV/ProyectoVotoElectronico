Imports System.Runtime.InteropServices
Public Class AdministradorVotaciones
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(hWnd As IntPtr, wMs As Integer, wParam As Integer, lParam As Integer)

    End Sub

    Private Sub PanelSuperior_MouseMove(sender As Object, e As MouseEventArgs) Handles PanelSuperior.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)

    End Sub

    Private Sub PanelSuperior_Paint(sender As Object, e As PaintEventArgs) Handles PanelSuperior.Paint
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Formulario As Form = Nothing
    Private Sub abrirFormularios(ByVal formHijo As Form)
        Try
            If Formulario IsNot Nothing Then
                Formulario.Close()
            End If
            Formulario = formHijo
            formHijo.TopLevel = False
            formHijo.FormBorderStyle = FormBorderStyle.None
            formHijo.Dock = DockStyle.Fill
            PanelFormularios.Controls.Add(formHijo)
            PanelFormularios.Tag = formHijo
            formHijo.BringToFront()
            formHijo.Show()
        Catch ex As Exception
            MessageBox.Show("No puedes abrir dos veces la misma opción", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnAlcaldes_Click(sender As Object, e As EventArgs) Handles btnAlcaldes.Click
        abrirFormularios(Crud_Alcaldes)
    End Sub

    Private Sub btnDiputados_Click(sender As Object, e As EventArgs) Handles btnDiputados.Click
        abrirFormularios(Crud_Diputados)
    End Sub

    Private Sub btnPresidentes_Click(sender As Object, e As EventArgs) Handles btnPresidentes.Click
        abrirFormularios(Crud_Presidente)
    End Sub

    Private Sub btnVotantes_Click(sender As Object, e As EventArgs) Handles btnVotantes.Click
        abrirFormularios(Crud_Votantes)
    End Sub

    Private Sub btnAgregarImagenCandidatos_Click(sender As Object, e As EventArgs) Handles btnAgregarImagenCandidatos.Click
        abrirFormularios(AgregarImagenCandidato)
    End Sub

End Class