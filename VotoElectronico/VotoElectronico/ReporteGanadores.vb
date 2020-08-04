Public Class ReporteGanadores
    Private Sub ReporteGanadores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'SistemaNacionalDeEleccionesDataSet1.AlcaldesElectos' Puede moverla o quitarla según sea necesario.
        Me.AlcaldesElectosTableAdapter.Fill(Me.SistemaNacionalDeEleccionesDataSet1.AlcaldesElectos)
        'TODO: esta línea de código carga datos en la tabla 'SistemaNacionalDeEleccionesDataSet1.DiputadosElectos' Puede moverla o quitarla según sea necesario.
        Me.DiputadosElectosTableAdapter.Fill(Me.SistemaNacionalDeEleccionesDataSet1.DiputadosElectos)
        'TODO: esta línea de código carga datos en la tabla 'SistemaNacionalDeEleccionesDataSet1.PresidenteElectos' Puede moverla o quitarla según sea necesario.
        Me.PresidenteElectosTableAdapter.Fill(Me.SistemaNacionalDeEleccionesDataSet1.PresidenteElectos)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class