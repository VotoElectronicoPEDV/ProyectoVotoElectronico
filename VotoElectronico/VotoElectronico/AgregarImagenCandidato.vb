
Public Class AgregarImagenCandidato
    Dim conexion As conexion = New conexion()
    Dim DataT As New DataTable
    Dim MensajeMolesto As Integer
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim identidad As String
        Dim imagen As Image

        imagen = imgFoto.Image
        identidad = TxtIdentidad.Text


        If ValidateChildren() = True And TxtIdentidad.Text <> "" Then
            conexion.ingresarFoto(identidad, imagen)
            MessageBox.Show("Se ha agregado la Foto", "Agregando", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Else
            MessageBox.Show("Debe seleccionar un candidato", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub btnExplorar_Click(sender As Object, e As EventArgs) Handles btnExplorar.Click
        Dim dlg As New OpenFileDialog
        dlg.Filter = "Imagenes JPG|*.jpg|Imagenes PNG|*.png|Imagenes GIF|*.gif"
        If dlg.ShowDialog = Windows.Forms.DialogResult.OK Then
            imgFoto.Image = Image.FromFile(dlg.FileName)
        End If
    End Sub

    Private Sub TxtIdentidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtIdentidad.KeyPress
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
    Private Sub consultarAlcalde()
        Try
            DataT = conexion.consultarAlcalde
            If DataT.Rows.Count <> 0 Then
                dgvCandidatos.DataSource = DataT
                dgvCandidatos.DataSource = DataT
                dgvCandidatos.RowTemplate.MinimumHeight = 105
                dgvCandidatos.Columns(4).MinimumWidth = 40
                dgvCandidatos.Columns(4).Width = 40
                CType(dgvCandidatos.Columns(4), DataGridViewImageColumn).ImageLayout = DataGridViewImageCellLayout.Stretch

            Else
                dgvCandidatos.DataSource = Nothing
                MessageBox.Show("Error al consultar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub consultarPresidente()
        Try
            DataT = conexion.consultarPresidente
            If DataT.Rows.Count <> 0 Then
                dgvCandidatos.DataSource = DataT
                dgvCandidatos.DataSource = DataT
                dgvCandidatos.RowTemplate.MinimumHeight = 105
                dgvCandidatos.Columns(4).MinimumWidth = 40
                dgvCandidatos.Columns(4).Width = 40
                CType(dgvCandidatos.Columns(4), DataGridViewImageColumn).ImageLayout = DataGridViewImageCellLayout.Stretch

            Else
                dgvCandidatos.DataSource = Nothing
                MessageBox.Show("Error al consultar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub consultarDiputado()
        Try
            DataT = conexion.consultarDiputado
            If DataT.Rows.Count <> 0 Then
                dgvCandidatos.DataSource = DataT
                dgvCandidatos.DataSource = DataT
                dgvCandidatos.RowTemplate.MinimumHeight = 105
                dgvCandidatos.Columns(4).MinimumWidth = 40
                dgvCandidatos.Columns(4).Width = 40
                CType(dgvCandidatos.Columns(4), DataGridViewImageColumn).ImageLayout = DataGridViewImageCellLayout.Stretch
            Else
                dgvCandidatos.DataSource = Nothing
                MessageBox.Show("Error al consultar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cmbCandidatura_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCandidatura.SelectedIndexChanged
        If MensajeMolesto = 1 Then
            MessageBox.Show("Si desea, puede dar click en el candidato, para poner su identidad inmediatamente en la casilla ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            MensajeMolesto = 0
        End If

        Select Case cmbCandidatura.SelectedIndex
            Case 0
                consultarPresidente()
            Case 1
                consultarAlcalde()
            Case 2
                consultarDiputado()

        End Select
    End Sub

    Private Sub dgvCandidatos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCandidatos.CellContentClick
        TxtIdentidad.Text = dgvCandidatos.CurrentRow.Cells(0).Value.ToString
    End Sub

    Private Sub AgregarImagenCandidato_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MensajeMolesto = 1
    End Sub
End Class