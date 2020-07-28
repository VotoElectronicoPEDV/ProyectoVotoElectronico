Public Class votacionInterna
    Dim conexion As conexion = New conexion()
    Dim DataT As DataTable
    Private Sub alcaldesInterna()
        Dim Voto As New DataGridViewButtonColumn()
        Voto.DataPropertyName = "votar"
        Voto.HeaderText = "Voto"
        Voto.Text = "Votar"
        Voto.UseColumnTextForButtonValue = True
        'dgvAlcaldeInterna.Columns.Add(Voto)

        Try
            DataT = conexion.alcaldesInterna(eleccionVotante.idmunicipio)
            If DataT.Rows.Count <> 0 Then
                dgvAlcaldeInterna.RowTemplate.MinimumHeight = 250
                dgvAlcaldeInterna.DataSource = DataT
                CType(dgvAlcaldeInterna.Columns(1), DataGridViewImageColumn).ImageLayout = DataGridViewImageCellLayout.Stretch
                dgvAlcaldeInterna.Columns.AddRange(Voto)

                dgvAlcaldeInterna.Columns(1).MinimumWidth = 200
                dgvAlcaldeInterna.Columns(0).Visible = False
                dgvAlcaldeInterna.Columns(4).MinimumWidth = 380
                CType(dgvAlcaldeInterna.Columns(3), DataGridViewTextBoxColumn).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                CType(dgvAlcaldeInterna.Columns(2), DataGridViewTextBoxColumn).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            Else
                dgvAlcaldeInterna.DataSource = Nothing
                MessageBox.Show("Error al consultar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub votacionInterna_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim municipio, departamento As String
        municipio = conexion.recuperarMunicipio(eleccionVotante.idmunicipio, 0)
        departamento = conexion.recuperarMunicipio(eleccionVotante.idmunicipio, 1)
        municipio = municipio.ToUpper()
        departamento = departamento.ToUpper()

        Label1.Text = "03" + eleccionVotante.idmunicipio
        Label2.Text = municipio + "-" + departamento
        alcaldesInterna()
    End Sub

    Private Sub dgvAlcaldeInterna_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAlcaldeInterna.CellClick
        If Me.dgvAlcaldeInterna.CurrentCell.GetType.ToString Like "*Button*" Then
            eleccionVotante.idAlcalde = Me.dgvAlcaldeInterna.CurrentRow.Cells(0).Value.ToString


            If eleccionVotante.idAlcalde = String.Empty Then
                MessageBox.Show("La fila no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Dim confirmacion As DialogResult
                confirmacion = MessageBox.Show("¿Esta seguro de su eleccion?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                If confirmacion = DialogResult.Yes Then

                    Try
                        If eleccionVotante.descripcionVotacion = 1 Then

                            If conexion.votacionInterna(eleccionVotante.idVotante, eleccionVotante.idAlcalde) Then
                                MessageBox.Show("Ha votado Satisfactoriamente", "Votacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                Me.Hide()
                                IngresaVotante.Show()
                            Else
                                MessageBox.Show("Error al votar", "Votacion", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            End If
                        Else
                            MessageBox.Show("Ha votado Satisfactoriamente", "Votacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Me.Hide()
                            votacionDiputado.Show()
                        End If
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                End If
            End If
        End If
    End Sub
End Class