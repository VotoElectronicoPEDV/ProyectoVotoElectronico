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
        Me.imgFoto.Location = New System.Drawing.Point(575, 15)
        Me.imgFoto.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.imgFoto.Name = "imgFoto"
        Me.imgFoto.Size = New System.Drawing.Size(188, 153)
        Me.imgFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgFoto.TabIndex = 21
        Me.imgFoto.TabStop = False
        '
        'dgvCandidatos
        '
        Me.dgvCandidatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCandidatos.Location = New System.Drawing.Point(16, 203)
        Me.dgvCandidatos.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dgvCandidatos.Name = "dgvCandidatos"
        Me.dgvCandidatos.RowHeadersWidth = 51
        Me.dgvCandidatos.Size = New System.Drawing.Size(747, 185)
        Me.dgvCandidatos.TabIndex = 22
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(388, 91)
        Me.btnAgregar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(133, 39)
        Me.btnAgregar.TabIndex = 23
        Me.btnAgregar.Text = "Agregar Imagen"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'TxtIdentidad
        '
        Me.TxtIdentidad.Location = New System.Drawing.Point(129, 48)
        Me.TxtIdentidad.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtIdentidad.MaxLength = 13
        Me.TxtIdentidad.Name = "TxtIdentidad"
        Me.TxtIdentidad.Size = New System.Drawing.Size(132, 22)
        Me.TxtIdentidad.TabIndex = 24
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(35, 52)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 17)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Identidad"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(35, 172)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(199, 17)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Debe dar click en el candidato"
        '
        'cmbCandidatura
        '
        Me.cmbCandidatura.FormattingEnabled = True
        Me.cmbCandidatura.Items.AddRange(New Object() {"Presidentes", "Alcaldes ", "Diputados"})
        Me.cmbCandidatura.Location = New System.Drawing.Point(129, 107)
        Me.cmbCandidatura.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmbCandidatura.Name = "cmbCandidatura"
        Me.cmbCandidatura.Size = New System.Drawing.Size(160, 24)
        Me.cmbCandidatura.TabIndex = 27
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(36, 111)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 17)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Candidatura"
        '
        'btnExplorar
        '
        Me.btnExplorar.Location = New System.Drawing.Point(388, 52)
        Me.btnExplorar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnExplorar.Name = "btnExplorar"
        Me.btnExplorar.Size = New System.Drawing.Size(131, 32)
        Me.btnExplorar.TabIndex = 29
        Me.btnExplorar.Text = "Explorar"
        Me.btnExplorar.UseVisualStyleBackColor = True
        '
        'AgregarImagenCandidato
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ClientSize = New System.Drawing.Size(779, 402)
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
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
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
