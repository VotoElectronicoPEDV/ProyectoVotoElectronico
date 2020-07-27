Public Class votacionInterna
    Dim conexion As conexion = New conexion()
    Dim DataT As DataTable
    Private Sub alcaldesInterna()
        Dim Voto As New DataGridViewButtonColumn()
        Voto.DataPropertyName = "votar"
        Voto.HeaderText = "Voto"


        Try
            DataT = conexion.alcaldesInterna(eleccionVotante.idmunicipio)
            If DataT.Rows.Count <> 0 Then
                dgvAlcaldeInterna.DataSource = DataT
                CType(dgvAlcaldeInterna.Columns(0), DataGridViewImageColumn).ImageLayout = DataGridViewImageCellLayout.Stretch
                dgvAlcaldeInterna.Columns.AddRange(Voto)
                Voto.Text = "V"
            Else
                dgvAlcaldeInterna.DataSource = Nothing
                MessageBox.Show("Error al consultar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub votacionInterna_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        alcaldesInterna()
    End Sub
End Class