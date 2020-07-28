Public Class votacionDiputado
    Dim conexion As conexion = New conexion()
    Dim DataT As DataTable
    Public inicio As Integer
    Public final As Integer
    Private Sub diputadoExterna()
        Dim Voto As New DataGridViewButtonColumn()
        Voto.DataPropertyName = "votar"
        Voto.HeaderText = "Voto"
        Voto.Text = "Votar"
        Voto.UseColumnTextForButtonValue = True

        Try
            DataT = conexion.diputadoExterna()
            If DataT.Rows.Count <> 0 Then
                dgvDiputado.RowTemplate.MinimumHeight = 250
                dgvDiputado.DataSource = DataT
                CType(dgvDiputado.Columns(1), DataGridViewImageColumn).ImageLayout = DataGridViewImageCellLayout.Stretch
                dgvDiputado.Columns.AddRange(Voto)

                dgvDiputado.Columns(1).MinimumWidth = 200
                dgvDiputado.Columns(0).Visible = False
                dgvDiputado.Columns(4).MinimumWidth = 380
                CType(dgvDiputado.Columns(3), DataGridViewTextBoxColumn).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                CType(dgvDiputado.Columns(2), DataGridViewTextBoxColumn).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            Else
                dgvDiputado.DataSource = Nothing
                MessageBox.Show("Error al consultar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub votacionInterna_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim departamento As String
        departamento = conexion.recuperarMunicipio(eleccionVotante.idmunicipio, 1)
        departamento = departamento.ToUpper()

        Label1.Text = "03"
        Label2.Text = departamento
        diputadoExterna()
    End Sub

    Private Sub dgvDiputado_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDiputado.CellClick
        Dim confirmacion As DialogResult
        Try
            If Me.dgvDiputado.CurrentCell.GetType.ToString Like "*Button*" Then
                If Me.dgvDiputado.CurrentRow.Cells(0).Value.ToString <> String.Empty Then



                    Select Case inicio
                        Case 0
                            confirmacion = MessageBox.Show("¿Esta seguro de su eleccion?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                            If confirmacion = DialogResult.Yes Then
                                eleccionVotante.idDiputado1 = Me.dgvDiputado.CurrentRow.Cells(0).Value.ToString
                                inicio += 1
                            End If
                        Case 1
                            If Me.dgvDiputado.CurrentRow.Cells(0).Value.ToString = eleccionVotante.idDiputado1 Then
                                MsgBox("ya eligio este candidato")
                            Else
                                confirmacion = MessageBox.Show("¿Esta seguro de su eleccion?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                                If confirmacion = DialogResult.Yes Then
                                    eleccionVotante.idDiputado2 = Me.dgvDiputado.CurrentRow.Cells(0).Value.ToString
                                    inicio += 1
                                End If
                            End If
                        Case 2
                            If Me.dgvDiputado.CurrentRow.Cells(0).Value.ToString = eleccionVotante.idDiputado1 Or Me.dgvDiputado.CurrentRow.Cells(0).Value.ToString = eleccionVotante.idDiputado2 Then
                                MsgBox("ya eligio este candidato")
                            Else
                                confirmacion = MessageBox.Show("¿Esta seguro de su eleccion?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                                If confirmacion = DialogResult.Yes Then
                                    eleccionVotante.idDiputado3 = Me.dgvDiputado.CurrentRow.Cells(0).Value.ToString
                                    inicio += 1
                                End If
                            End If
                        Case 3
                            If Me.dgvDiputado.CurrentRow.Cells(0).Value.ToString = eleccionVotante.idDiputado1 Or Me.dgvDiputado.CurrentRow.Cells(0).Value.ToString = eleccionVotante.idDiputado2 Or Me.dgvDiputado.CurrentRow.Cells(0).Value.ToString = eleccionVotante.idDiputado3 Then
                                MsgBox("ya eligio este candidato")
                            Else
                                confirmacion = MessageBox.Show("¿Esta seguro de su eleccion?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                                If confirmacion = DialogResult.Yes Then
                                    eleccionVotante.idDiputado4 = Me.dgvDiputado.CurrentRow.Cells(0).Value.ToString
                                    inicio += 1
                                End If
                            End If
                        Case 4
                            If Me.dgvDiputado.CurrentRow.Cells(0).Value.ToString = eleccionVotante.idDiputado1 Or Me.dgvDiputado.CurrentRow.Cells(0).Value.ToString = eleccionVotante.idDiputado2 Or Me.dgvDiputado.CurrentRow.Cells(0).Value.ToString = eleccionVotante.idDiputado3 Or Me.dgvDiputado.CurrentRow.Cells(0).Value.ToString = eleccionVotante.idDiputado4 Then
                                MsgBox("ya eligio este candidato")
                            Else
                                confirmacion = MessageBox.Show("¿Esta seguro de su eleccion?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                                If confirmacion = DialogResult.Yes Then
                                    eleccionVotante.idDiputado5 = Me.dgvDiputado.CurrentRow.Cells(0).Value.ToString
                                    inicio += 1
                                End If
                            End If
                        Case 5
                            If Me.dgvDiputado.CurrentRow.Cells(0).Value.ToString = eleccionVotante.idDiputado1 Or Me.dgvDiputado.CurrentRow.Cells(0).Value.ToString = eleccionVotante.idDiputado2 Or Me.dgvDiputado.CurrentRow.Cells(0).Value.ToString = eleccionVotante.idDiputado3 Or Me.dgvDiputado.CurrentRow.Cells(0).Value.ToString = eleccionVotante.idDiputado4 Or Me.dgvDiputado.CurrentRow.Cells(0).Value.ToString = eleccionVotante.idDiputado5 Then
                                MsgBox("ya eligio este candidato")
                            Else
                                confirmacion = MessageBox.Show("¿Esta seguro de su eleccion?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                                If confirmacion = DialogResult.Yes Then
                                    eleccionVotante.idDiputado6 = Me.dgvDiputado.CurrentRow.Cells(0).Value.ToString
                                    inicio += 1
                                End If
                            End If
                        Case 6
                            If Me.dgvDiputado.CurrentRow.Cells(0).Value.ToString = eleccionVotante.idDiputado1 Or Me.dgvDiputado.CurrentRow.Cells(0).Value.ToString = eleccionVotante.idDiputado2 Or Me.dgvDiputado.CurrentRow.Cells(0).Value.ToString = eleccionVotante.idDiputado3 Or Me.dgvDiputado.CurrentRow.Cells(0).Value.ToString = eleccionVotante.idDiputado4 Or Me.dgvDiputado.CurrentRow.Cells(0).Value.ToString = eleccionVotante.idDiputado5 Or Me.dgvDiputado.CurrentRow.Cells(0).Value.ToString = eleccionVotante.idDiputado6 Then
                                MsgBox("ya eligio este candidato")
                            Else
                                confirmacion = MessageBox.Show("¿Esta seguro de su eleccion?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                                If confirmacion = DialogResult.Yes Then
                                    eleccionVotante.idDiputado7 = Me.dgvDiputado.CurrentRow.Cells(0).Value.ToString
                                    inicio += 1
                                End If
                            End If
                        Case 7
                            If Me.dgvDiputado.CurrentRow.Cells(0).Value.ToString = eleccionVotante.idDiputado1 Or Me.dgvDiputado.CurrentRow.Cells(0).Value.ToString = eleccionVotante.idDiputado2 Or Me.dgvDiputado.CurrentRow.Cells(0).Value.ToString = eleccionVotante.idDiputado3 Or Me.dgvDiputado.CurrentRow.Cells(0).Value.ToString = eleccionVotante.idDiputado4 Or Me.dgvDiputado.CurrentRow.Cells(0).Value.ToString = eleccionVotante.idDiputado5 Or Me.dgvDiputado.CurrentRow.Cells(0).Value.ToString = eleccionVotante.idDiputado6 Or Me.dgvDiputado.CurrentRow.Cells(0).Value.ToString = eleccionVotante.idDiputado7 Then
                                MsgBox("ya eligio este candidato")
                            Else
                                confirmacion = MessageBox.Show("¿Esta seguro de su eleccion?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                                If confirmacion = DialogResult.Yes Then
                                    eleccionVotante.idDiputado8 = Me.dgvDiputado.CurrentRow.Cells(0).Value.ToString
                                    inicio += 1
                                End If
                            End If
                        Case 8
                            If Me.dgvDiputado.CurrentRow.Cells(0).Value.ToString = eleccionVotante.idDiputado1 Or Me.dgvDiputado.CurrentRow.Cells(0).Value.ToString = eleccionVotante.idDiputado2 Or Me.dgvDiputado.CurrentRow.Cells(0).Value.ToString = eleccionVotante.idDiputado3 Or Me.dgvDiputado.CurrentRow.Cells(0).Value.ToString = eleccionVotante.idDiputado4 Or Me.dgvDiputado.CurrentRow.Cells(0).Value.ToString = eleccionVotante.idDiputado5 Or Me.dgvDiputado.CurrentRow.Cells(0).Value.ToString = eleccionVotante.idDiputado6 Or Me.dgvDiputado.CurrentRow.Cells(0).Value.ToString = eleccionVotante.idDiputado7 Or Me.dgvDiputado.CurrentRow.Cells(0).Value.ToString = eleccionVotante.idDiputado8 Then
                                MsgBox("ya eligio este candidato")
                            Else
                                confirmacion = MessageBox.Show("¿Esta seguro de su eleccion?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                                If confirmacion = DialogResult.Yes Then
                                    eleccionVotante.idDiputado9 = Me.dgvDiputado.CurrentRow.Cells(0).Value.ToString
                                    inicio = 0
                                    MessageBox.Show("Ha elegido los 9 diputados satisfactoriamente", "Votacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                    Me.Hide()
                                    'formularioPresidente
                                End If
                            End If
                    End Select
                Else
                    MessageBox.Show("La fila no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


        '    If Me.dgvDiputado.CurrentCell.GetType.ToString Like "*Button*" Then
        '        eleccionVotante.idDiputado1 = Me.dgvDiputado.CurrentRow.Cells(0).Value.ToString

        '        If eleccionVotante.idAlcalde = String.Empty Then
        '            MessageBox.Show("La fila no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '        Else
        '            Dim confirmacion As DialogResult
        '            confirmacion = MessageBox.Show("¿Esta seguro de su eleccion?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        '            If confirmacion = DialogResult.Yes Then

        '                Try
        '                    If eleccionVotante.descripcionVotacion = 1 Then

        '                        If conexion.votacionInterna(eleccionVotante.idVotante, eleccionVotante.idAlcalde) Then
        '                            MessageBox.Show("Ha votado Satisfactoriamente", "Votacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '                            Me.Hide()
        '                            IngresaVotante.Show()
        '                        Else
        '                            MessageBox.Show("Error al votar", "Votacion", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '                        End If
        '                    Else
        '                        MessageBox.Show("Ha votado Satisfactoriamente", "Votacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '                        Me.Hide()
        '                        'IngresaVotante.Show()
        '                    End If
        '                Catch ex As Exception
        '                    MsgBox(ex.Message)
        '                End Try
        '            End If
        '        End If
        '    End If
        'End Sub
        'Private Sub validarDiputado()

    End Sub

End Class
