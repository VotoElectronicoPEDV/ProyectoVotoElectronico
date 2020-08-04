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
        Me.SistemaNacionalDeEleccionesDataSet2 = New VotoElectronico.SistemaNacionalDeEleccionesDataSet2()
        Me.DiputadosElectosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DiputadosElectosTableAdapter = New VotoElectronico.SistemaNacionalDeEleccionesDataSet2TableAdapters.DiputadosElectosTableAdapter()
        Me.SistemaNacionalDeEleccionesDataSet3 = New VotoElectronico.SistemaNacionalDeEleccionesDataSet3()
        Me.PresidenteElectosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PresidenteElectosTableAdapter = New VotoElectronico.SistemaNacionalDeEleccionesDataSet3TableAdapters.PresidenteElectosTableAdapter()
        Me.btnSalir = New System.Windows.Forms.Button()
        CType(Me.SistemaNacionalDeEleccionesDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AlcaldesElectosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SistemaNacionalDeEleccionesDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DiputadosElectosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SistemaNacionalDeEleccionesDataSet3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PresidenteElectosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataAlcaldesG"
        ReportDataSource1.Value = Me.AlcaldesElectosBindingSource
        ReportDataSource2.Name = "DataSetDiputadosG"
        ReportDataSource2.Value = Me.DiputadosElectosBindingSource
        ReportDataSource3.Name = "DataSetPresidenteG"
        ReportDataSource3.Value = Me.PresidenteElectosBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource3)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "VotoElectronico.reporte.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(12, 42)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(1319, 457)
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
        'SistemaNacionalDeEleccionesDataSet2
        '
        Me.SistemaNacionalDeEleccionesDataSet2.DataSetName = "SistemaNacionalDeEleccionesDataSet2"
        Me.SistemaNacionalDeEleccionesDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DiputadosElectosBindingSource
        '
        Me.DiputadosElectosBindingSource.DataMember = "DiputadosElectos"
        Me.DiputadosElectosBindingSource.DataSource = Me.SistemaNacionalDeEleccionesDataSet2
        '
        'DiputadosElectosTableAdapter
        '
        Me.DiputadosElectosTableAdapter.ClearBeforeFill = True
        '
        'SistemaNacionalDeEleccionesDataSet3
        '
        Me.SistemaNacionalDeEleccionesDataSet3.DataSetName = "SistemaNacionalDeEleccionesDataSet3"
        Me.SistemaNacionalDeEleccionesDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PresidenteElectosBindingSource
        '
        Me.PresidenteElectosBindingSource.DataMember = "PresidenteElectos"
        Me.PresidenteElectosBindingSource.DataSource = Me.SistemaNacionalDeEleccionesDataSet3
        '
        'PresidenteElectosTableAdapter
        '
        Me.PresidenteElectosTableAdapter.ClearBeforeFill = True
        '
        'btnSalir
        '
        Me.btnSalir.FlatAppearance.BorderSize = 0
        Me.btnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon
        Me.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btnSalir.Image = Global.VotoElectronico.My.Resources.Resources.close_window_32px
        Me.btnSalir.Location = New System.Drawing.Point(1296, 1)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(35, 35)
        Me.btnSalir.TabIndex = 1
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'ReporteGanadores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1343, 511)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.ReportViewer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ReporteGanadores"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ReporteGanadores"
        CType(Me.SistemaNacionalDeEleccionesDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AlcaldesElectosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SistemaNacionalDeEleccionesDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DiputadosElectosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SistemaNacionalDeEleccionesDataSet3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PresidenteElectosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents AlcaldesElectosBindingSource As BindingSource
    Friend WithEvents SistemaNacionalDeEleccionesDataSet1 As SistemaNacionalDeEleccionesDataSet1
    Friend WithEvents DiputadosElectosBindingSource As BindingSource
    Friend WithEvents SistemaNacionalDeEleccionesDataSet2 As SistemaNacionalDeEleccionesDataSet2
    Friend WithEvents PresidenteElectosBindingSource As BindingSource
    Friend WithEvents SistemaNacionalDeEleccionesDataSet3 As SistemaNacionalDeEleccionesDataSet3
    Friend WithEvents AlcaldesElectosTableAdapter As SistemaNacionalDeEleccionesDataSet1TableAdapters.AlcaldesElectosTableAdapter
    Friend WithEvents DiputadosElectosTableAdapter As SistemaNacionalDeEleccionesDataSet2TableAdapters.DiputadosElectosTableAdapter
    Friend WithEvents PresidenteElectosTableAdapter As SistemaNacionalDeEleccionesDataSet3TableAdapters.PresidenteElectosTableAdapter
    Friend WithEvents btnSalir As Button
End Class
