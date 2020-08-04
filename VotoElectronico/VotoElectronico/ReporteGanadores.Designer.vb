<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReporteGanadores
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource3 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.SistemaNacionalDeEleccionesDataSet1 = New VotoElectronico.SistemaNacionalDeEleccionesDataSet1()
        Me.AlcaldesElectosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AlcaldesElectosTableAdapter = New VotoElectronico.SistemaNacionalDeEleccionesDataSet1TableAdapters.AlcaldesElectosTableAdapter()
        Me.DiputadosElectosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DiputadosElectosTableAdapter = New VotoElectronico.SistemaNacionalDeEleccionesDataSet1TableAdapters.DiputadosElectosTableAdapter()
        Me.PresidenteElectosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PresidenteElectosTableAdapter = New VotoElectronico.SistemaNacionalDeEleccionesDataSet1TableAdapters.PresidenteElectosTableAdapter()
        CType(Me.SistemaNacionalDeEleccionesDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AlcaldesElectosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DiputadosElectosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PresidenteElectosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSetAlcaldes"
        ReportDataSource1.Value = Me.AlcaldesElectosBindingSource
        ReportDataSource2.Name = "DataSetDiputados"
        ReportDataSource2.Value = Me.DiputadosElectosBindingSource
        ReportDataSource3.Name = "DataSetPresidentes"
        ReportDataSource3.Value = Me.PresidenteElectosBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource3)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "VotoElectronico.reporte.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(26, 12)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(747, 399)
        Me.ReportViewer1.TabIndex = 0
        '
        'SistemaNacionalDeEleccionesDataSet1
        '
        Me.SistemaNacionalDeEleccionesDataSet1.DataSetName = "SistemaNacionalDeEleccionesDataSet1"
        Me.SistemaNacionalDeEleccionesDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AlcaldesElectosBindingSource
        '
        Me.AlcaldesElectosBindingSource.DataMember = "AlcaldesElectos"
        Me.AlcaldesElectosBindingSource.DataSource = Me.SistemaNacionalDeEleccionesDataSet1
        '
        'AlcaldesElectosTableAdapter
        '
        Me.AlcaldesElectosTableAdapter.ClearBeforeFill = True
        '
        'DiputadosElectosBindingSource
        '
        Me.DiputadosElectosBindingSource.DataMember = "DiputadosElectos"
        Me.DiputadosElectosBindingSource.DataSource = Me.SistemaNacionalDeEleccionesDataSet1
        '
        'DiputadosElectosTableAdapter
        '
        Me.DiputadosElectosTableAdapter.ClearBeforeFill = True
        '
        'PresidenteElectosBindingSource
        '
        Me.PresidenteElectosBindingSource.DataMember = "PresidenteElectos"
        Me.PresidenteElectosBindingSource.DataSource = Me.SistemaNacionalDeEleccionesDataSet1
        '
        'PresidenteElectosTableAdapter
        '
        Me.PresidenteElectosTableAdapter.ClearBeforeFill = True
        '
        'ReporteGanadores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ReportViewer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ReporteGanadores"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ReporteGanadores"
        CType(Me.SistemaNacionalDeEleccionesDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AlcaldesElectosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DiputadosElectosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PresidenteElectosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents AlcaldesElectosBindingSource As BindingSource
    Friend WithEvents SistemaNacionalDeEleccionesDataSet1 As SistemaNacionalDeEleccionesDataSet1
    Friend WithEvents DiputadosElectosBindingSource As BindingSource
    Friend WithEvents PresidenteElectosBindingSource As BindingSource
    Friend WithEvents AlcaldesElectosTableAdapter As SistemaNacionalDeEleccionesDataSet1TableAdapters.AlcaldesElectosTableAdapter
    Friend WithEvents DiputadosElectosTableAdapter As SistemaNacionalDeEleccionesDataSet1TableAdapters.DiputadosElectosTableAdapter
    Friend WithEvents PresidenteElectosTableAdapter As SistemaNacionalDeEleccionesDataSet1TableAdapters.PresidenteElectosTableAdapter
End Class
