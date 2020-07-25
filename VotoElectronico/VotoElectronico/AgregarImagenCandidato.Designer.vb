<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AgregarImagenCandidato
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
        Me.imgFoto = New System.Windows.Forms.PictureBox()
        Me.dgvCandidatos = New System.Windows.Forms.DataGridView()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.TxtIdentidad = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbCandidatura = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnExplorar = New System.Windows.Forms.Button()
        CType(Me.imgFoto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvCandidatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'imgFoto
        '
        Me.imgFoto.BackColor = System.Drawing.Color.Black
        Me.imgFoto.Location = New System.Drawing.Point(431, 12)
        Me.imgFoto.Name = "imgFoto"
        Me.imgFoto.Size = New System.Drawing.Size(141, 124)
        Me.imgFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgFoto.TabIndex = 21
        Me.imgFoto.TabStop = False
        '
        'dgvCandidatos
        '
        Me.dgvCandidatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCandidatos.Location = New System.Drawing.Point(12, 165)
        Me.dgvCandidatos.Name = "dgvCandidatos"
        Me.dgvCandidatos.Size = New System.Drawing.Size(560, 150)
        Me.dgvCandidatos.TabIndex = 22
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(291, 74)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(100, 32)
        Me.btnAgregar.TabIndex = 23
        Me.btnAgregar.Text = "Agregar Imagen"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'TxtIdentidad
        '
        Me.TxtIdentidad.Location = New System.Drawing.Point(97, 39)
        Me.TxtIdentidad.MaxLength = 13
        Me.TxtIdentidad.Name = "TxtIdentidad"
        Me.TxtIdentidad.Size = New System.Drawing.Size(100, 20)
        Me.TxtIdentidad.TabIndex = 24
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Identidad"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 140)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(152, 13)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Debe dar click en el candidato"
        '
        'cmbCandidatura
        '
        Me.cmbCandidatura.FormattingEnabled = True
        Me.cmbCandidatura.Items.AddRange(New Object() {"Presidentes", "Alcaldes ", "Diputados"})
        Me.cmbCandidatura.Location = New System.Drawing.Point(97, 87)
        Me.cmbCandidatura.Name = "cmbCandidatura"
        Me.cmbCandidatura.Size = New System.Drawing.Size(121, 21)
        Me.cmbCandidatura.TabIndex = 27
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(27, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 13)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Candidatura"
        '
        'btnExplorar
        '
        Me.btnExplorar.Location = New System.Drawing.Point(291, 42)
        Me.btnExplorar.Name = "btnExplorar"
        Me.btnExplorar.Size = New System.Drawing.Size(98, 26)
        Me.btnExplorar.TabIndex = 29
        Me.btnExplorar.Text = "EXPLORAR"
        Me.btnExplorar.UseVisualStyleBackColor = True
        '
        'AgregarImagenCandidato
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ClientSize = New System.Drawing.Size(584, 327)
        Me.Controls.Add(Me.btnExplorar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmbCandidatura)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtIdentidad)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.dgvCandidatos)
        Me.Controls.Add(Me.imgFoto)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AgregarImagenCandidato"
        Me.Text = "AgregarImagenCandidato"
        CType(Me.imgFoto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvCandidatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents imgFoto As PictureBox
    Friend WithEvents dgvCandidatos As DataGridView
    Friend WithEvents btnAgregar As Button
    Friend WithEvents TxtIdentidad As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbCandidatura As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnExplorar As Button
End Class
