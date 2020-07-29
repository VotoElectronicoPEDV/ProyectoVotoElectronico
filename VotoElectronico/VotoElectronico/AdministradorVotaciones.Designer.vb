<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdministradorVotaciones
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
        Me.PanelMenu = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnAlcaldes = New System.Windows.Forms.Button()
        Me.btnDiputados = New System.Windows.Forms.Button()
        Me.btnPresidentes = New System.Windows.Forms.Button()
        Me.btnVotantes = New System.Windows.Forms.Button()
        Me.btnAgregarImagenCandidatos = New System.Windows.Forms.Button()
        Me.PanelSuperior = New System.Windows.Forms.Panel()
        Me.PanelFormularios = New System.Windows.Forms.Panel()
        Me.PanelMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelMenu
        '
        Me.PanelMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.PanelMenu.Controls.Add(Me.btnAlcaldes)
        Me.PanelMenu.Controls.Add(Me.btnDiputados)
        Me.PanelMenu.Controls.Add(Me.btnPresidentes)
        Me.PanelMenu.Controls.Add(Me.btnVotantes)
        Me.PanelMenu.Controls.Add(Me.btnAgregarImagenCandidatos)
        Me.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelMenu.Location = New System.Drawing.Point(0, 68)
        Me.PanelMenu.Name = "PanelMenu"
        Me.PanelMenu.Size = New System.Drawing.Size(240, 742)
        Me.PanelMenu.TabIndex = 3
        '
        'btnAlcaldes
        '
        Me.btnAlcaldes.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnAlcaldes.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnAlcaldes.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnAlcaldes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.btnAlcaldes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnAlcaldes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAlcaldes.Font = New System.Drawing.Font("Times New Roman", 10.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAlcaldes.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnAlcaldes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAlcaldes.Location = New System.Drawing.Point(3, 3)
        Me.btnAlcaldes.Name = "btnAlcaldes"
        Me.btnAlcaldes.Size = New System.Drawing.Size(231, 71)
        Me.btnAlcaldes.TabIndex = 0
        Me.btnAlcaldes.Text = "Alcaldes"
        Me.btnAlcaldes.UseVisualStyleBackColor = True
        '
        'btnDiputados
        '
        Me.btnDiputados.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnDiputados.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnDiputados.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnDiputados.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.btnDiputados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnDiputados.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDiputados.Font = New System.Drawing.Font("Times New Roman", 10.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDiputados.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnDiputados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDiputados.Location = New System.Drawing.Point(3, 80)
        Me.btnDiputados.Name = "btnDiputados"
        Me.btnDiputados.Size = New System.Drawing.Size(231, 77)
        Me.btnDiputados.TabIndex = 1
        Me.btnDiputados.Text = "Diputados"
        Me.btnDiputados.UseVisualStyleBackColor = True
        '
        'btnPresidentes
        '
        Me.btnPresidentes.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnPresidentes.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnPresidentes.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnPresidentes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.btnPresidentes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnPresidentes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPresidentes.Font = New System.Drawing.Font("Times New Roman", 10.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPresidentes.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnPresidentes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPresidentes.Location = New System.Drawing.Point(3, 163)
        Me.btnPresidentes.Name = "btnPresidentes"
        Me.btnPresidentes.Size = New System.Drawing.Size(231, 78)
        Me.btnPresidentes.TabIndex = 2
        Me.btnPresidentes.Text = "Presidentes"
        Me.btnPresidentes.UseVisualStyleBackColor = True
        '
        'btnVotantes
        '
        Me.btnVotantes.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnVotantes.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnVotantes.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnVotantes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.btnVotantes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnVotantes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVotantes.Font = New System.Drawing.Font("Times New Roman", 10.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVotantes.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnVotantes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnVotantes.Location = New System.Drawing.Point(3, 247)
        Me.btnVotantes.Name = "btnVotantes"
        Me.btnVotantes.Size = New System.Drawing.Size(231, 78)
        Me.btnVotantes.TabIndex = 3
        Me.btnVotantes.Text = "Votantes"
        Me.btnVotantes.UseVisualStyleBackColor = True
        '
        'btnAgregarImagenCandidatos
        '
        Me.btnAgregarImagenCandidatos.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnAgregarImagenCandidatos.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnAgregarImagenCandidatos.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnAgregarImagenCandidatos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.btnAgregarImagenCandidatos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnAgregarImagenCandidatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregarImagenCandidatos.Font = New System.Drawing.Font("Times New Roman", 10.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarImagenCandidatos.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnAgregarImagenCandidatos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAgregarImagenCandidatos.Location = New System.Drawing.Point(3, 331)
        Me.btnAgregarImagenCandidatos.Name = "btnAgregarImagenCandidatos"
        Me.btnAgregarImagenCandidatos.Size = New System.Drawing.Size(231, 78)
        Me.btnAgregarImagenCandidatos.TabIndex = 5
        Me.btnAgregarImagenCandidatos.Text = "Imagen Candidatos"
        Me.btnAgregarImagenCandidatos.UseVisualStyleBackColor = True
        '
        'PanelSuperior
        '
        Me.PanelSuperior.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.PanelSuperior.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelSuperior.Location = New System.Drawing.Point(0, 0)
        Me.PanelSuperior.Name = "PanelSuperior"
        Me.PanelSuperior.Size = New System.Drawing.Size(1301, 68)
        Me.PanelSuperior.TabIndex = 2
        '
        'PanelFormularios
        '
        Me.PanelFormularios.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.PanelFormularios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelFormularios.Location = New System.Drawing.Point(240, 68)
        Me.PanelFormularios.Name = "PanelFormularios"
        Me.PanelFormularios.Size = New System.Drawing.Size(1061, 742)
        Me.PanelFormularios.TabIndex = 4
        '
        'AdministradorVotaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1301, 810)
        Me.Controls.Add(Me.PanelFormularios)
        Me.Controls.Add(Me.PanelMenu)
        Me.Controls.Add(Me.PanelSuperior)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AdministradorVotaciones"
        Me.Opacity = 0.9R
        Me.Text = "AdministradorVotaciones"
        Me.PanelMenu.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelMenu As FlowLayoutPanel
    Friend WithEvents btnAlcaldes As Button
    Friend WithEvents btnDiputados As Button
    Friend WithEvents btnPresidentes As Button
    Friend WithEvents PanelSuperior As Panel
    Friend WithEvents PanelFormularios As Panel
    Friend WithEvents btnVotantes As Button
    Friend WithEvents btnAgregarImagenCandidatos As Button
End Class
