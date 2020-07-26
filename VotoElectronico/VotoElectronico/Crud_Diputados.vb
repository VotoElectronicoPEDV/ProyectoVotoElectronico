Imports System.ComponentModel

Public Class Crud_Diputados
    Dim conexion As conexion = New conexion()
    Dim DataT As New DataTable
    Private Sub btnEjecutar_Click(sender As Object, e As EventArgs) Handles btnEjecutar.Click
        If txtIdentidad.Text.Length = 13 Then
            Select Case cmbOperacion.SelectedIndex
                Case 0
                    If Me.ValidateChildren = True And txtIdentidad.Text <> "" And txtPrimerNombre.Text <> "" And txtSegundoNombre.Text <> "" And txtPrimerApellido.Text <> "" And txtSegundoApellido.Text <> "" Then
                        ingresarDiputado()
                        consultarDiputado()
                    Else
                        MessageBox.Show("Debe asegurarse de que todos los campos esten completos", "Error al realizar operación", MessageBoxButtons.OK, MessageBoxIcon.Error)

                    End If

                Case 1
                    If Me.ValidateChildren = True And txtIdentidad.Text <> "" And txtPrimerNombre.Text <> "" And txtSegundoNombre.Text <> "" And txtPrimerApellido.Text <> "" And txtSegundoApellido.Text <> "" Then
                        actualizarDiputado()
                        consultarDiputado()
                    Else
                        MessageBox.Show("Debe asegurarse de que todos los campos esten completos", "Error al realizar operación", MessageBoxButtons.OK, MessageBoxIcon.Error)

                    End If
                Case 2
                    If Me.ValidateChildren = True And txtIdentidad.Text <> "" Then
                        eliminarDiputado()
                        consultarDiputado()
                    Else
                        MessageBox.Show("Debe asegurarse de que todos los campos esten completos", "Error al realizar operación", MessageBoxButtons.OK, MessageBoxIcon.Error)

                    End If
                Case Else
                    MessageBox.Show("Debe seleccionar una opcion de la operacion que desea realizar", "Error al realizar operación", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Select
        Else
            MessageBox.Show("Debe ingresar un numero de identidad valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub consultarDiputado()
        Try
            DataT = conexion.consultarDiputado
            If DataT.Rows.Count <> 0 Then
                dgvDiputados.DataSource = DataT
            Else
                dgvDiputados.DataSource = Nothing
                MessageBox.Show("Error al consultar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub ingresarDiputado()
        Try
            Dim identidad, primerNombre, SegundoNombre, PrimerApellido, SegundoApellido, estado, Departamento As String
            Dim partido As Integer

            identidad = txtIdentidad.Text
            primerNombre = txtPrimerNombre.Text
            SegundoNombre = txtSegundoNombre.Text
            PrimerApellido = txtPrimerApellido.Text
            SegundoApellido = txtSegundoApellido.Text
            estado = cmbEstado.SelectedItem
            Departamento = "03"

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

            If cmbPartido.SelectedItem <> "" And cmbEstado.SelectedItem <> "" Then
                If conexion.ingresarDiputado(identidad, primerNombre, SegundoNombre, PrimerApellido, SegundoApellido, estado, partido, Departamento) Then
                    MessageBox.Show("Información Registrada correctamente", "Actualizando", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Error al guardar informacion del Diputado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                MessageBox.Show("Debe asegurarse de haber seleccionado todo lo necesario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub actualizarDiputado()
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
            If cmbPartido.SelectedItem <> "" Then
                If conexion.actualizarDiputado(identidad, primerNombre, SegundoNombre, PrimerApellido, SegundoApellido, partido) Then
                    MessageBox.Show("Información Actualizada correctamente", "Actualizando", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Diputado no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                MessageBox.Show("Debe seleccionar un Partido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub eliminarDiputado()
        Try
            Dim identidad

            identidad = txtIdentidad.Text

            If conexion.eliminarDiputado(identidad) Then
                MessageBox.Show("Información Eliminada correctamente", "Eliminando", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Diputado no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
                consultarDiputado()

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

    Private Sub txtIdentidad_TextChanged(sender As Object, e As EventArgs) Handles txtIdentidad.TextChanged
        ToolTip.SetToolTip(txtIdentidad, "Identidad")
        ToolTip.ToolTipTitle = "Aviso"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
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


    Private Sub txtPrimerApellido_Validating(sender As Object, e As CancelEventArgs) Handles txtPrimerApellido.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 And cmbOperacion.SelectedItem <> "Actualizar" Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, " Campo es obligatorio ")
        End If
    End Sub


    Private Sub txtSegundoApellido_Validating(sender As Object, e As CancelEventArgs) Handles txtSegundoApellido.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 And cmbOperacion.SelectedItem <> "Actualizar" Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, " Campo es obligatorio ")
        End If
    End Sub

    Private Sub txtPrimerNombre_MouseHover(sender As Object, e As EventArgs) Handles txtPrimerNombre.MouseHover
        ToolTip.SetToolTip(txtPrimerNombre, "Primer Nombre")
        ToolTip.ToolTipTitle = "Aviso"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtSegundoNombre_MouseHover(sender As Object, e As EventArgs) Handles txtSegundoNombre.MouseHover
        ToolTip.SetToolTip(txtSegundoNombre, "Segundo Nombre")
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

    Private Sub cmbPartido_MouseHover(sender As Object, e As EventArgs) Handles cmbPartido.MouseHover
        ToolTip.SetToolTip(cmbPartido, "Partido")
        ToolTip.ToolTipTitle = "Aviso"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
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


    Private Sub cmbPartido_Validating(sender As Object, e As CancelEventArgs) Handles cmbPartido.Validating
        If DirectCast(sender, ComboBox).Text.Length > 0 And cmbOperacion.SelectedItem <> "Actualizar" Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, " Campo es obligatorio ")
        End If
    End Sub

    Private Sub cmbEstado_Validating(sender As Object, e As CancelEventArgs) Handles cmbEstado.Validating
        If DirectCast(sender, ComboBox).Text.Length > 0 And cmbOperacion.SelectedItem <> "Actualizar" Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, " Campo es obligatorio ")
        End If
    End Sub

    Private Sub Crud_Diputados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        consultarDiputado()
    End Sub

    Private Sub dgvDiputados_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDiputados.CellContentClick
        txtIdentidad.Text = dgvDiputados.CurrentRow.Cells(0).Value.ToString
        txtPrimerNombre.Text = dgvDiputados.CurrentRow.Cells(1).Value.ToString
        txtSegundoNombre.Text = dgvDiputados.CurrentRow.Cells(1).Value.ToString
        txtPrimerApellido.Text = dgvDiputados.CurrentRow.Cells(1).Value.ToString
        txtSegundoApellido.Text = dgvDiputados.CurrentRow.Cells(1).Value.ToString
        cmbPartido.SelectedItem = dgvDiputados.CurrentRow.Cells(7).Value.ToString
        cmbEstado.SelectedItem = "activo"
    End Sub
End Class