Public Class ReporteGanadores
    Private Sub ReporteGanadores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'SistemaNacionalDeEleccionesDataSet1.AlcaldesElectos' Puede moverla o quitarla según sea necesario.
        Me.AlcaldesElectosTableAdapter.Fill(Me.SistemaNacionalDeEleccionesDataSet1.AlcaldesElectos)
        'TODO: esta línea de código carga datos en la tabla 'SistemaNacionalDeEleccionesDataSet2.DiputadosElectos' Puede moverla o quitarla según sea necesario.
        Me.DiputadosElectosTableAdapter.Fill(Me.SistemaNacionalDeEleccionesDataSet2.DiputadosElectos)
        'TODO: esta línea de código carga datos en la tabla 'SistemaNacionalDeEleccionesDataSet3.PresidenteElectos' Puede moverla o quitarla según sea necesario.
        Me.PresidenteElectosTableAdapter.Fill(Me.SistemaNacionalDeEleccionesDataSet3.PresidenteElectos)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click

        Dim confirmacion As DialogResult
        confirmacion = MessageBox.Show("¿Esta seguro que desea salir del reporte?", "Cerrando", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If confirmacion = DialogResult.Yes Then
            Me.Close()
        End If



    End Sub
End Class