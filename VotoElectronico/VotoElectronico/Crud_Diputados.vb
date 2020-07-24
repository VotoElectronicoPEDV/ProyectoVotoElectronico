Public Class Crud_Diputados
    Dim conexion As conexion = New conexion()
    Dim DataT As New DataTable
    Private Sub btnEjecutar_Click(sender As Object, e As EventArgs) Handles btnEjecutar.Click
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
End Class