Imports System.ComponentModel

Public Class Crud_Alcaldes
    Dim conexion As conexion = New conexion()
    Dim DataT As New DataTable
    Private Sub btnEjecutar_Click(sender As Object, e As EventArgs) Handles btnEjecutar.Click
        Select Case cmbOperacion.SelectedIndex
            Case 0
                If Me.ValidateChildren = True And txtIdentidad.Text <> "" And txtPrimerNombre.Text <> "" And txtSegundoNombre.Text <> "" And txtPrimerApellido.Text <> "" And txtSegundoApellido.Text <> "" Then
                    ingresarAlcalde()
                    consultarAlcalde()
                Else
                    MessageBox.Show("Debe asegurarse de que todos los campos esten completos", "Error al realizar operación", MessageBoxButtons.OK, MessageBoxIcon.Error)

                End If

            Case 1
                If Me.ValidateChildren = True And txtIdentidad.Text <> "" And txtPrimerNombre.Text <> "" And txtSegundoNombre.Text <> "" And txtPrimerApellido.Text <> "" And txtSegundoApellido.Text <> "" Then
                    actualizarAlcalde()
                    consultarAlcalde()
                Else
                    MessageBox.Show("Debe asegurarse de que todos los campos esten completos", "Error al realizar operación", MessageBoxButtons.OK, MessageBoxIcon.Error)

                End If
            Case 2
                If Me.ValidateChildren = True And txtIdentidad.Text <> "" Then
                    eliminarAlcalde()
                    consultarAlcalde()
                Else
                    MessageBox.Show("Debe asegurarse de que todos los campos esten completos", "Error al realizar operación", MessageBoxButtons.OK, MessageBoxIcon.Error)

                End If
            Case Else
                MessageBox.Show("Debe seleccionar una opcion de la operacion que desea realizar", "Error al realizar operación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Select
    End Sub
    Private Sub consultarAlcalde()
        Try
            DataT = conexion.consultarAlcalde
            If DataT.Rows.Count <> 0 Then
                dgvAlcaldes.DataSource = DataT
            Else
                dgvAlcaldes.DataSource = Nothing
                MessageBox.Show("Error al consultar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub ingresarAlcalde()
        Try
            Dim identidad, primerNombre, SegundoNombre, PrimerApellido, SegundoApellido, estado, municipio, descripcionVotacion As String
            Dim partido As Integer

            identidad = txtIdentidad.Text
            primerNombre = txtPrimerNombre.Text
            SegundoNombre = txtSegundoNombre.Text
            PrimerApellido = txtPrimerApellido.Text
            SegundoApellido = txtSegundoApellido.Text
            estado = cmbEstado.SelectedItem
            descripcionVotacion = "interna"
            Select Case cmbMunicipio.SelectedIndex
                Case 0
                    municipio = "01"
                Case 1
                    municipio = "02"
                Case 2
                    municipio = "03"
                Case 3
                    municipio = "04"
                Case 4
                    municipio = "05"
                Case 5
                    municipio = "06"
                Case 6
                    municipio = "07"
                Case 7
                    municipio = "08"
                Case 8
                    municipio = "09"
                Case 9
                    municipio = "10"
                Case 10
                    municipio = "11"
                Case 11
                    municipio = "12"
                Case 12
                    municipio = "13"
                Case 13
                    municipio = "14"
                Case 14
                    municipio = "15"
                Case 15
                    municipio = "16"
                Case 16
                    municipio = "17"
                Case 17
                    municipio = "18"
                Case 18
                    municipio = "19"
                Case 19
                    municipio = "20"
                Case 20
                    municipio = "21"
                Case Else
                    MessageBox.Show("Debe seleccionar un Municipio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Select
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

            If cmbPartido.SelectedItem <> "" And cmbEstado.SelectedItem <> "" And cmbMunicipio.SelectedItem <> "" Then
                If conexion.ingresarAlcalde(identidad, primerNombre, SegundoNombre, PrimerApellido, SegundoApellido, descripcionVotacion, estado, partido, municipio) Then
                    MessageBox.Show("Información Registrada correctamente", "Actualizando", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Error al guardar informacion del alcalde", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                MessageBox.Show("Debe asegurarse de haber seleccionado todo lo necesario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub actualizarAlcalde()
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
                If conexion.actualizarAlcalde(identidad, primerNombre, SegundoNombre, PrimerApellido, SegundoApellido, partido) Then
                    MessageBox.Show("Información Actualizada correctamente", "Actualizando", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Alcalde no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                MessageBox.Show("Debe seleccionar un Partido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub eliminarAlcalde()
        Try
            Dim identidad

            identidad = txtIdentidad.Text

            If conexion.eliminarAlcalde(identidad) Then
                MessageBox.Show("Información Eliminada correctamente", "Eliminando", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Alcalde no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
                cmbMunicipio.Enabled = True
            Case 1
                txtIdentidad.Enabled = True
                txtPrimerNombre.Enabled = True
                txtSegundoNombre.Enabled = True
                txtPrimerApellido.Enabled = True
                txtSegundoApellido.Enabled = True
                cmbPartido.Enabled = True
                cmbEstado.Enabled = False
                cmbMunicipio.Enabled = False
            Case 2
                txtIdentidad.Enabled = True
                txtPrimerNombre.Enabled = False
                txtSegundoNombre.Enabled = False
                txtPrimerApellido.Enabled = False
                txtSegundoApellido.Enabled = False
                cmbPartido.Enabled = False
                cmbEstado.Enabled = False
                cmbMunicipio.Enabled = False

            Case 3
                txtIdentidad.Enabled = False
                txtPrimerNombre.Enabled = False
                txtSegundoNombre.Enabled = False
                txtPrimerApellido.Enabled = False
                txtSegundoApellido.Enabled = False
                cmbPartido.Enabled = False
                cmbEstado.Enabled = False
                cmbMunicipio.Enabled = False
                consultarAlcalde()
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