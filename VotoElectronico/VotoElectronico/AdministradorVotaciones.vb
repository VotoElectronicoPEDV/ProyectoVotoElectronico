Imports System.Runtime.InteropServices
Public Class AdministradorVotaciones

    Dim conexion As conexion = New conexion()
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


    Private Sub btnVotacionExterna_Click(sender As Object, e As EventArgs) Handles btnVotacionExterna.Click
        Try
            If conexion.cambioVotacion And eleccionVotante.descripcionVotacion = 1 Then
                MessageBox.Show("¡Se ha realizado el cambio De votacion a externa exitosamente!", "Cambiando", MessageBoxButtons.OK, MessageBoxIcon.Information)
                eleccionVotante.descripcionVotacion = 2

            ElseIf eleccionVotante.descripcionVotacion = 0 Then
                MessageBox.Show("Debe realizarse la votacion interna", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            Else
                MessageBox.Show("Ha ocurrido un error al realizar el cambio de tipo votación", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub



    Private Sub btnSalir_Click_1(sender As Object, e As EventArgs) Handles btnSalir.Click
        Dim confirmacion As DialogResult
        confirmacion = MessageBox.Show("¿Esta seguro que desea salir?", "Cerrando", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If confirmacion = DialogResult.Yes Then
            End
        End If
    End Sub

    Private Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click

        Dim confirmacion As DialogResult
        confirmacion = MessageBox.Show("¿Esta seguro que desea regresar?", "Regresando", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If confirmacion = DialogResult.Yes Then
            Me.Close()
            IngresaVotante.Show()
        End If
    End Sub

    Private Sub ocultarSubMenu()
        PanelSubMenuCandidatos.Visible = False
        PanelAjustes.Visible = False
    End Sub

    Private Sub MostrarSubMenu(submenu As Panel)
        If submenu.Visible = False Then
            ocultarSubMenu()
            submenu.Visible = True
        Else
            submenu.Visible = False
        End If
    End Sub

    Private Sub AdministradorVotaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ocultarSubMenu()
        If eleccionVotante.descripcionVotacion = 0 Then
            btnReiniciarVotacion.Text = "Iniciar Votación"
        ElseIf eleccionVotante.descripcionVotacion = 1 Then
            btnReiniciarVotacion.Text = "Reiniciar Votación"
        ElseIf eleccionVotante.descripcionVotacion = 2 Then
            btnReiniciarVotacion.Text = "Finalizar Votación"
        End If

        btnReiniciarVotacion.Enabled = True
    End Sub

    Private Sub BtnAlmacenamiento_Click(sender As Object, e As EventArgs) Handles BtnAlmacenamiento.Click
        MostrarSubMenu(PanelSubMenuCandidatos)
    End Sub

    Private Sub BtnAjustes_Click(sender As Object, e As EventArgs) Handles BtnAjustes.Click
        MostrarSubMenu(PanelAjustes)
    End Sub

    Private Sub btnImagenCand_Click(sender As Object, e As EventArgs) Handles btnImagenCand.Click
        abrirFormularios(AgregarImagenCandidato)
    End Sub

    Private Sub btnReiniciarVotacion_Click(sender As Object, e As EventArgs) Handles btnReiniciarVotacion.Click
        If eleccionVotante.descripcionVotacion = 0 Then
            eleccionVotante.descripcionVotacion = 1
            MessageBox.Show("La votación se ha iniciado satisfactoriamente", "Iniciando", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf eleccionVotante.descripcionVotacion = 1 Then
            ReiniciarVotacion()
            eleccionVotante.descripcionVotacion = 0
        ElseIf eleccionVotante.descripcionVotacion = 2 Then
            MessageBox.Show("Votacion finalizada satisfactoriamente", "finalizando", MessageBoxButtons.OK, MessageBoxIcon.Information)
            eleccionVotante.descripcionVotacion = 1
        End If

        btnReiniciarVotacion.Enabled = False
    End Sub

    Private Sub ReiniciarVotacion()
        Try
            If conexion.ReiniciarVotacion Then
                If eleccionVotante.descripcionVotacion = 1 Then
                    MessageBox.Show("La votación se ha reiniciado satisfactoriamente", "Reiniciando", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Else
                If eleccionVotante.descripcionVotacion = 1 Then
                    MessageBox.Show("Ha surgido un error al reiniciar la votación", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub BtnAlmacenamiento_MouseHover(sender As Object, e As EventArgs) Handles BtnAlmacenamiento.MouseHover
        ToolTip.SetToolTip(BtnAlmacenamiento, "Almacenamiento de la Base de datos")
        ToolTip.ToolTipTitle = "Aviso"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub btnVotantes_MouseHover(sender As Object, e As EventArgs) Handles btnVotantes.MouseHover
        ToolTip.SetToolTip(btnVotantes, "Votantes")
        ToolTip.ToolTipTitle = "Aviso"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub btnPresidentes_MouseHover(sender As Object, e As EventArgs) Handles btnPresidentes.MouseHover
        ToolTip.SetToolTip(btnPresidentes, "Presidentes")
        ToolTip.ToolTipTitle = "Aviso"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub btnDiputados_MouseHover(sender As Object, e As EventArgs) Handles btnDiputados.MouseHover
        ToolTip.SetToolTip(btnDiputados, "Diputados")
        ToolTip.ToolTipTitle = "Aviso"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub btnAlcaldes_MouseHover(sender As Object, e As EventArgs) Handles btnAlcaldes.MouseHover
        ToolTip.SetToolTip(btnAlcaldes, "Alcaldes")
        ToolTip.ToolTipTitle = "Aviso"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub btnImagenCand_MouseHover(sender As Object, e As EventArgs) Handles btnImagenCand.MouseHover
        ToolTip.SetToolTip(btnImagenCand, "Agregar imagen a candidato")
        ToolTip.ToolTipTitle = "Aviso"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub BtnAjustes_MouseHover(sender As Object, e As EventArgs) Handles BtnAjustes.MouseHover
        ToolTip.SetToolTip(BtnAjustes, "Ajustes")
        ToolTip.ToolTipTitle = "Aviso"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub btnVotacionExterna_MouseHover(sender As Object, e As EventArgs) Handles btnVotacionExterna.MouseHover
        ToolTip.SetToolTip(btnVotacionExterna, "Iniciar Votacion Externa")
        ToolTip.ToolTipTitle = "Aviso"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub btnReiniciarVotacion_MouseHover(sender As Object, e As EventArgs) Handles btnReiniciarVotacion.MouseHover
        ToolTip.SetToolTip(btnReiniciarVotacion, "Reiniciar Votacion")
        ToolTip.ToolTipTitle = "Aviso"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub
End Class