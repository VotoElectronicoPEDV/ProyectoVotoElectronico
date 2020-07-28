Public Class votacionPresidente
    Dim conexion As conexion = New conexion()
    Dim DataT As DataTable
    Private Sub PresidenteExterna()
        Dim Voto As New DataGridViewButtonColumn()
        Voto.DataPropertyName = "votar"
        Voto.HeaderText = "Voto"
        Voto.Text = "Votar"
        Voto.UseColumnTextForButtonValue = True


        Try
            DataT = conexion.PresidenteExterna()
            If DataT.Rows.Count <> 0 Then
                dgvPresidente.RowTemplate.MinimumHeight = 250
                dgvPresidente.DataSource = DataT
                CType(dgvPresidente.Columns(1), DataGridViewImageColumn).ImageLayout = DataGridViewImageCellLayout.Stretch
                dgvPresidente.Columns.AddRange(Voto)

                dgvPresidente.Columns(1).MinimumWidth = 200
                dgvPresidente.Columns(0).Visible = False
                dgvPresidente.Columns(4).MinimumWidth = 380
                CType(dgvPresidente.Columns(3), DataGridViewTextBoxColumn).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                CType(dgvPresidente.Columns(2), DataGridViewTextBoxColumn).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            Else
                dgvPresidente.DataSource = Nothing
                MessageBox.Show("Error al consultar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub votacionInterna_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PresidenteExterna()
    End Sub

    Private Sub dgvPresidente_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPresidente.CellClick
        If Me.dgvPresidente.CurrentCell.GetType.ToString Like "*Button*" Then
            eleccionVotante.idPresidente = Me.dgvPresidente.CurrentRow.Cells(0).Value.ToString


            If eleccionVotante.idPresidente = String.Empty Then
                MessageBox.Show("La fila no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Dim confirmacion As DialogResult
                confirmacion = MessageBox.Show("¿Esta seguro de su eleccion?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                If confirmacion = DialogResult.Yes Then

                    Try
                        If conexion.votacionExterna(eleccionVotante.idVotante, eleccionVotante.idAlcalde, eleccionVotante.idDiputado1,
                                                    eleccionVotante.idDiputado2, eleccionVotante.idDiputado3, eleccionVotante.idDiputado4,
                                                    eleccionVotante.idDiputado5, eleccionVotante.idDiputado6, eleccionVotante.idDiputado7,
                                                    eleccionVotante.idDiputado8, eleccionVotante.idDiputado9, eleccionVotante.idPresidente) Then


                            MessageBox.Show("Ha realizado toda su votacion Satisfactoriamente", "Votacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Me.Hide()
                            IngresaVotante.Show()
                        Else
                            MessageBox.Show("Error al finalizar votacion", "Votacion", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                End If
            End If
        End If
    End Sub


End Class