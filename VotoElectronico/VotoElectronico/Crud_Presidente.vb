Imports System.ComponentModel

Public Class Crud_Presidente
    Dim conexion As conexion = New conexion()
    Dim DataT As New DataTable
    Private Sub btnEjecutar_Click(sender As Object, e As EventArgs) Handles btnEjecutar.Click
        Select Case cmbOperacion.SelectedIndex
            Case 0
                If Me.ValidateChildren = True And txtIdentidad.Text <> "" And txtPrimerNombre.Text <> "" And txtSegundoNombre.Text <> "" And txtPrimerApellido.Text <> "" And txtSegundoApellido.Text <> "" Then
                    ingresarPresidente()
                    consultarPresidente()
                Else
                    MessageBox.Show("Debe asegurarse de que todos los campos esten completos", "Error al realizar operación", MessageBoxButtons.OK, MessageBoxIcon.Error)

                End If

            Case 1
                If Me.ValidateChildren = True And txtIdentidad.Text <> "" And txtPrimerNombre.Text <> "" And txtSegundoNombre.Text <> "" And txtPrimerApellido.Text <> "" And txtSegundoApellido.Text <> "" Then
                    actualizarPresidente()
                    consultarPresidente()
                Else
                    MessageBox.Show("Debe asegurarse de que todos los campos esten completos", "Error al realizar operación", MessageBoxButtons.OK, MessageBoxIcon.Error)

                End If
            Case 2
                If Me.ValidateChildren = True And txtIdentidad.Text <> "" Then
                    eliminarPresidente()
                    consultarPresidente()
                Else
                    MessageBox.Show("Debe asegurarse de que todos los campos esten completos", "Error al realizar operación", MessageBoxButtons.OK, MessageBoxIcon.Error)

                End If
            Case Else
                MessageBox.Show("Debe seleccionar una opcion de la operacion que desea realizar", "Error al realizar operación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Select
    End Sub
    Private Sub consultarPresidente()
        Try
            DataT = conexion.consultarPresidente
            If DataT.Rows.Count <> 0 Then
                dgvPresidente.DataSource = DataT
            Else
                dgvPresidente.DataSource = Nothing
                MessageBox.Show("Error al consultar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub ingresarPresidente()
        Try
            Dim identidad, primerNombre, SegundoNombre, PrimerApellido, SegundoApellido, estado As String
            Dim partido As Integer

            identidad = txtIdentidad.Text
            primerNombre = txtPrimerNombre.Text
            SegundoNombre = txtSegundoNombre.Text
            PrimerApellido = txtPrimerApellido.Text
            SegundoApellido = txtSegundoApellido.Text
            If cmbEstado.SelectedItem <> "" Then
                estado = cmbEstado.SelectedItem
                Select Case cmbPartido.SelectedIndex
                    Case 0
                        partido = 1
                    Case 1
                        partido = 2
                    Case 2
                        partido = 3
                    Case 3
                        partido = 4
                    Case Else
                        MessageBox.Show("Debe seleccionar un Partido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Select

                If conexion.ingresarPresidente(identidad, primerNombre, SegundoNombre, PrimerApellido, SegundoApellido, estado, partido) Then
                    MessageBox.Show("Información Actualizada correctamente", "Actualizando", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Presidente no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                MessageBox.Show("Debe seleccionar un Estado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub actualizarPresidente()
        Try
            Dim identidad, primerNombre, SegundoNombre, PrimerApellido, SegundoApellido As String
            Dim partido As Integer

            identidad = txtIdentidad.Text
            primerNombre = txtPrimerNombre.Text
            SegundoNombre = txtSegundoNombre.Text
            PrimerApellido = txtPrimerApellido.Text
            SegundoApellido = txtSegundoApellido.Text
            Select Case cmbPartido.SelectedIndex
                Case 0
                    partido = 1
                Case 1
                    partido = 2
                Case 2
                    partido = 3
                Case 3
                    partido = 4
                Case Else
                    MessageBox.Show("Debe seleccionar un Partido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Select

            If conexion.actualizarPresidente(identidad, primerNombre, SegundoNombre, PrimerApellido, SegundoApellido, partido) Then
                MessageBox.Show("Información Actualizada correctamente", "Actualizando", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Presidente no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub eliminarPresidente()
        Try
            Dim identidad

            identidad = txtIdentidad.Text

            If conexion.eliminarPresidente(identidad) Then
                MessageBox.Show("Información Eliminada correctamente", "Eliminando", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Presidente no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
                cmbPartido.Enabled = True
                cmbEstado.Enabled = True
            Case 1
                txtIdentidad.Enabled = True
                txtPrimerNombre.Enabled = True
                txtSegundoNombre.Enabled = True
                txtPrimerApellido.Enabled = True
                txtSegundoApellido.Enabled = True
                cmbPartido.Enabled = True
                cmbEstado.Enabled = False
            Case 2
                txtIdentidad.Enabled = True
                txtPrimerNombre.Enabled = False
                txtSegundoNombre.Enabled = False
                txtPrimerApellido.Enabled = False
                txtSegundoApellido.Enabled = False
                cmbPartido.Enabled = False
                cmbEstado.Enabled = False
            Case 3
                txtIdentidad.Enabled = False
                txtPrimerNombre.Enabled = False
                txtSegundoNombre.Enabled = False
                txtPrimerApellido.Enabled = False
                txtSegundoApellido.Enabled = False
                cmbPartido.Enabled = False
                cmbEstado.Enabled = False
                consultarPresidente()
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



    Private Sub txtIdentidad_Validating(sender As Object, e As CancelEventArgs) Handles txtIdentidad.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 And cmbOperacion.SelectedItem <> "Actualizar" Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, " Campo es obligatorio ")
        End If
    End Sub


    Private Sub txtPrimerNombre_Validating(sender As Object, e As CancelEventArgs) Handles txtPrimerNombre.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 And cmbOperacion.SelectedItem <> "Actualizar" Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, " Campo es obligatorio ")
        End If
    End Sub



    Private Sub txtSegundoNombre_Validating(sender As Object, e As CancelEventArgs) Handles txtSegundoNombre.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 And cmbOperacion.SelectedItem <> "Actualizar" Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, " Campo es obligatorio ")
        End If
    End Sub

    Private Sub txtPrimerApellido_TextChanged(sender As Object, e As EventArgs) Handles txtPrimerApellido.TextChanged
        If DirectCast(sender, TextBox).Text.Length > 0 And cmbOperacion.SelectedItem <> "Actualizar" Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, " Campo es obligatorio ")
        End If
    End Sub

    Private Sub txtSegundoApellido_TextChanged(sender As Object, e As EventArgs) Handles txtSegundoApellido.TextChanged
        If DirectCast(sender, TextBox).Text.Length > 0 And cmbOperacion.SelectedItem <> "Actualizar" Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, " Campo es obligatorio ")
        End If
    End Sub

    Private Sub txtIdentidad_MouseHover(sender As Object, e As EventArgs) Handles txtIdentidad.MouseHover
        ToolTip.SetToolTip(txtIdentidad, "Identidad ")
        ToolTip.ToolTipTitle = "Aviso"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub


    Private Sub txtPrimerNombre_MouseHover(sender As Object, e As EventArgs) Handles txtPrimerNombre.MouseHover
        ToolTip.SetToolTip(txtPrimerNombre, "Primer nombre")
        ToolTip.ToolTipTitle = "Aviso"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub


    Private Sub txtSegundoNombre_MouseHover(sender As Object, e As EventArgs) Handles txtSegundoNombre.MouseHover
        ToolTip.SetToolTip(txtSegundoNombre, "segundo Nombre")
        ToolTip.ToolTipTitle = "Aviso"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub


    Private Sub txtPrimerApellido_MouseHover(sender As Object, e As EventArgs) Handles txtPrimerApellido.MouseHover
        ToolTip.SetToolTip(txtPrimerApellido, "primer apellido")
        ToolTip.ToolTipTitle = "Aviso"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtSegundoApellido_MouseHover(sender As Object, e As EventArgs) Handles txtSegundoApellido.MouseHover
        ToolTip.SetToolTip(txtSegundoApellido, "segundo Apellido")
        ToolTip.ToolTipTitle = "Aviso"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub
End Class