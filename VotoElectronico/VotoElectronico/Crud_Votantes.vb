Imports System.ComponentModel

Public Class Crud_Votantes
    Dim conexion As conexion = New conexion()
    Dim DataT As New DataTable
    Private Sub btnEjecutar_Click(sender As Object, e As EventArgs) Handles btnEjecutar.Click
        Select Case cmbOperacion.SelectedIndex
            Case 0
                If Me.ValidateChildren = True And txtIdentidad.Text <> "" And txtPrimerNombre.Text <> "" And txtSegundoNombre.Text <> "" And txtPrimerApellido.Text <> "" And txtSegundoApellido.Text <> "" And txtEdad.Text <> "" Then
                    IngresarVotante()
                    consultarVotante()
                Else
                    MessageBox.Show("Debe asegurarse de que todos los campos esten completos", "Error al realizar operación", MessageBoxButtons.OK, MessageBoxIcon.Error)

                End If

            Case 1
                If Me.ValidateChildren = True And txtIdentidad.Text <> "" And txtPrimerNombre.Text <> "" And txtSegundoNombre.Text <> "" And txtPrimerApellido.Text <> "" And txtSegundoApellido.Text <> "" Then
                    actualizarVotante()
                    consultarVotante()
                Else
                    MessageBox.Show("Debe asegurarse de que todos los campos esten completos", "Error al realizar operación", MessageBoxButtons.OK, MessageBoxIcon.Error)

                End If
            Case 2
                If Me.ValidateChildren = True And txtIdentidad.Text <> "" Then
                    eliminarVotante()
                    consultarVotante()
                Else
                    MessageBox.Show("Debe asegurarse de que todos los campos esten completos", "Error al realizar operación", MessageBoxButtons.OK, MessageBoxIcon.Error)

                End If
            Case Else
                MessageBox.Show("Debe seleccionar una opcion de la operacion que desea realizar", "Error al realizar operación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Select
    End Sub
    Private Sub consultarVotante()
        Try
            DataT = conexion.consultarVotante
            If DataT.Rows.Count <> 0 Then
                dgvVotantes.DataSource = DataT
            Else
                dgvVotantes.DataSource = Nothing
                MessageBox.Show("Error al consultar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub IngresarVotante()
        Try
            Dim identidad, primerNombre, SegundoNombre, PrimerApellido, SegundoApellido, estadoVotante, sexo As String
            Dim edad As Integer

            identidad = txtIdentidad.Text
            primerNombre = txtPrimerNombre.Text
            SegundoNombre = txtSegundoNombre.Text
            PrimerApellido = txtPrimerApellido.Text
            SegundoApellido = txtSegundoApellido.Text
            estadoVotante = cmbEstado.SelectedItem
            sexo = cmbSexo.SelectedItem

            If cmbSexo.SelectedItem <> "" And cmbEstado.SelectedItem <> "" Then
                If conexion.IngresarVotante(identidad, primerNombre, SegundoNombre, PrimerApellido, SegundoApellido, edad, sexo, estadoVotante) Then
                    MessageBox.Show("Información Registrada correctamente", "Actualizando", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Error al guardar informacion del Votante", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                MessageBox.Show("Debe asegurarse de haber seleccionado todo lo necesario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub actualizarVotante()
        Try
            Dim identidad, primerNombre, SegundoNombre, PrimerApellido, SegundoApellido As String

            identidad = txtIdentidad.Text
            primerNombre = txtPrimerNombre.Text
            SegundoNombre = txtSegundoNombre.Text
            PrimerApellido = txtPrimerApellido.Text
            SegundoApellido = txtSegundoApellido.Text

            If conexion.actualizarVotante(identidad, primerNombre, SegundoNombre, PrimerApellido, SegundoApellido) Then
                MessageBox.Show("Información Actualizada correctamente", "Actualizando", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Diputado no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub eliminarVotante()
        Try
            Dim identidad

            identidad = txtIdentidad.Text

            If conexion.eliminarVotante(identidad) Then
                MessageBox.Show("Información Eliminada correctamente", "Eliminando", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Votante no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cmbOperacion_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbOperacion.SelectedIndexChanged
        Select Case cmbOperacion.SelectedIndex
            Case 0
                txtIdentidad.Enabled = True
                txtPrimerNombre.Enabled = True
                txtSegundoNombre.Enabled = True
                txtPrimerApellido.Enabled = True
                txtSegundoApellido.Enabled = True
                cmbSexo.Enabled = True
                cmbEstado.Enabled = True
                txtEdad.Enabled = True
            Case 1
                txtIdentidad.Enabled = True
                txtPrimerNombre.Enabled = True
                txtSegundoNombre.Enabled = True
                txtPrimerApellido.Enabled = True
                txtSegundoApellido.Enabled = True
                cmbSexo.Enabled = False
                cmbEstado.Enabled = False
                txtEdad.Enabled = False

            Case 2
                txtIdentidad.Enabled = True
                txtPrimerNombre.Enabled = False
                txtSegundoNombre.Enabled = False
                txtPrimerApellido.Enabled = False
                txtSegundoApellido.Enabled = False
                cmbSexo.Enabled = False
                cmbEstado.Enabled = False
                txtEdad.Enabled = False

            Case 3
                txtIdentidad.Enabled = False
                txtPrimerNombre.Enabled = False
                txtSegundoNombre.Enabled = False
                txtPrimerApellido.Enabled = False
                txtSegundoApellido.Enabled = False
                cmbSexo.Enabled = False
                cmbEstado.Enabled = False
                txtEdad.Enabled = False
                consultarVotante()

        End Select

    End Sub

    Private Sub txtIdentidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtIdentidad.KeyPress
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

    Private Sub txtPrimerNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPrimerNombre.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsNumber(e.KeyChar) Then
            e.Handled = True
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtSegundoNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSegundoNombre.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsNumber(e.KeyChar) Then
            e.Handled = True
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtPrimerApellido_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPrimerApellido.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsNumber(e.KeyChar) Then
            e.Handled = True
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtSegundoApellido_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSegundoApellido.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsNumber(e.KeyChar) Then
            e.Handled = True
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtEdad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtEdad.KeyPress
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

    Private Sub txtSegundoApellido_TextChanged(sender As Object, e As EventArgs) Handles txtSegundoApellido.TextChanged

    End Sub

    Private Sub txtSegundoApellido_Validating(sender As Object, e As CancelEventArgs) Handles txtSegundoApellido.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 And cmbOperacion.SelectedItem <> "Actualizar" Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, " Campo es obligatorio ")
        End If
    End Sub

    Private Sub txtPrimerApellido_TextChanged(sender As Object, e As EventArgs) Handles txtPrimerApellido.TextChanged

    End Sub

    Private Sub txtPrimerApellido_Validating(sender As Object, e As CancelEventArgs) Handles txtPrimerApellido.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 And cmbOperacion.SelectedItem <> "Actualizar" Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, " Campo es obligatorio ")
        End If
    End Sub

    Private Sub txtIdentidad_TextChanged(sender As Object, e As EventArgs) Handles txtIdentidad.TextChanged

    End Sub

    Private Sub txtIdentidad_Validating(sender As Object, e As CancelEventArgs) Handles txtIdentidad.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 And cmbOperacion.SelectedItem <> "Actualizar" Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, " Campo es obligatorio ")
        End If
    End Sub

    Private Sub txtPrimerNombre_TextChanged(sender As Object, e As EventArgs) Handles txtPrimerNombre.TextChanged

    End Sub

    Private Sub txtPrimerNombre_Validating(sender As Object, e As CancelEventArgs) Handles txtPrimerNombre.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 And cmbOperacion.SelectedItem <> "Actualizar" Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, " Campo es obligatorio ")
        End If
    End Sub

    Private Sub txtSegundoNombre_TextChanged(sender As Object, e As EventArgs) Handles txtSegundoNombre.TextChanged

    End Sub

    Private Sub txtEdad_TextChanged(sender As Object, e As EventArgs) Handles txtEdad.TextChanged

    End Sub

    Private Sub txtEdad_Validating(sender As Object, e As CancelEventArgs) Handles txtEdad.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 And cmbOperacion.SelectedItem <> "Actualizar" Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, " Campo es obligatorio ")
        End If
    End Sub

    Private Sub txtIdentidad_MouseHover(sender As Object, e As EventArgs) Handles txtIdentidad.MouseHover
        ToolTip.SetToolTip(txtIdentidad, "Identidad")
        ToolTip.ToolTipTitle = "Aviso"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtPrimerNombre_MouseHover(sender As Object, e As EventArgs) Handles txtPrimerNombre.MouseHover
        ToolTip.SetToolTip(txtPrimerNombre, "Primer nombre")
        ToolTip.ToolTipTitle = "Aviso"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtSegundoNombre_Validating(sender As Object, e As CancelEventArgs) Handles txtSegundoNombre.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 And cmbOperacion.SelectedItem <> "Actualizar" Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, " Campo es obligatorio ")
        End If
    End Sub

    Private Sub txtSegundoNombre_MouseHover(sender As Object, e As EventArgs) Handles txtSegundoNombre.MouseHover
        ToolTip.SetToolTip(txtSegundoNombre, "Segundo nombre")
        ToolTip.ToolTipTitle = "Aviso"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtPrimerApellido_MouseHover(sender As Object, e As EventArgs) Handles txtPrimerApellido.MouseHover
        ToolTip.SetToolTip(txtPrimerApellido, "Primer Apellido")
        ToolTip.ToolTipTitle = "Aviso"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtSegundoApellido_MouseHover(sender As Object, e As EventArgs) Handles txtSegundoApellido.MouseHover
        ToolTip.SetToolTip(txtSegundoApellido, "Segundo Apellido")
        ToolTip.ToolTipTitle = "Aviso"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtEdad_MouseHover(sender As Object, e As EventArgs) Handles txtEdad.MouseHover
        ToolTip.SetToolTip(txtEdad, "Edad")
        ToolTip.ToolTipTitle = "Aviso"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub cmbSexo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSexo.SelectedIndexChanged

    End Sub

    Private Sub cmbSexo_MouseHover(sender As Object, e As EventArgs) Handles cmbSexo.MouseHover
        ToolTip.SetToolTip(cmbSexo, "Sexo")
        ToolTip.ToolTipTitle = "Aviso"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub cmbEstado_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbEstado.SelectedIndexChanged

    End Sub

    Private Sub cmbEstado_MouseHover(sender As Object, e As EventArgs) Handles cmbEstado.MouseHover
        ToolTip.SetToolTip(cmbEstado, "Estado")
        ToolTip.ToolTipTitle = "Aviso"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub cmbOperacion_MouseHover(sender As Object, e As EventArgs) Handles cmbOperacion.MouseHover
        ToolTip.SetToolTip(cmbOperacion, "Operacion a realizar")
        ToolTip.ToolTipTitle = "Aviso"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub btnEjecutar_MouseHover(sender As Object, e As EventArgs) Handles btnEjecutar.MouseHover
        ToolTip.SetToolTip(btnEjecutar, "Ejecutar")
        ToolTip.ToolTipTitle = "Aviso"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub cmbSexo_Validating(sender As Object, e As CancelEventArgs) Handles cmbSexo.Validating
        If DirectCast(sender, ComboBox).Text.Length > 0 And cmbOperacion.SelectedItem <> "Actualizar" Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, " Campo es obligatorio ")
        End If
    End Sub
End Class