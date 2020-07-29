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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.imgFoto = New System.Windows.Forms.PictureBox()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.TxtIdentidad = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbCandidatura = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnExplorar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Funcion = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.dgvCandidatos = New System.Windows.Forms.DataGridView()
        CType(Me.imgFoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.Funcion.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgvCandidatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'imgFoto
        '
        Me.imgFoto.BackColor = System.Drawing.Color.Black
        Me.imgFoto.Image = Global.VotoElectronico.My.Resources.Resources.descarga
        Me.imgFoto.Location = New System.Drawing.Point(262, 23)
        Me.imgFoto.Margin = New System.Windows.Forms.Padding(4)
        Me.imgFoto.Name = "imgFoto"
        Me.imgFoto.Size = New System.Drawing.Size(226, 183)
        Me.imgFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgFoto.TabIndex = 21
        Me.imgFoto.TabStop = False
        '
        'btnAgregar
        '
        Me.btnAgregar.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.btnAgregar.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnAgregar.FlatAppearance.BorderSize = 2
        Me.btnAgregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregar.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnAgregar.Location = New System.Drawing.Point(73, 99)
        Me.btnAgregar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(138, 69)
        Me.btnAgregar.TabIndex = 23
        Me.btnAgregar.Text = "Agregar Imagen"
        Me.btnAgregar.UseVisualStyleBackColor = False
        '
        'TxtIdentidad
        '
        Me.TxtIdentidad.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.TxtIdentidad.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtIdentidad.Font = New System.Drawing.Font("Times New Roman", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtIdentidad.ForeColor = System.Drawing.Color.White
        Me.TxtIdentidad.Location = New System.Drawing.Point(225, 53)
        Me.TxtIdentidad.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtIdentidad.MaxLength = 13
        Me.TxtIdentidad.Name = "TxtIdentidad"
        Me.TxtIdentidad.Size = New System.Drawing.Size(198, 27)
        Me.TxtIdentidad.TabIndex = 24
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 16.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(37, 55)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 32)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Identidad"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 263)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(199, 17)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Debe dar click en el candidato"
        '
        'cmbCandidatura
        '
        Me.cmbCandidatura.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.cmbCandidatura.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbCandidatura.Font = New System.Drawing.Font("Times New Roman", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCandidatura.ForeColor = System.Drawing.Color.White
        Me.cmbCandidatura.FormattingEnabled = True
        Me.cmbCandidatura.Items.AddRange(New Object() {"Presidentes", "Alcaldes ", "Diputados"})
        Me.cmbCandidatura.Location = New System.Drawing.Point(225, 149)
        Me.cmbCandidatura.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbCandidatura.Name = "cmbCandidatura"
        Me.cmbCandidatura.Size = New System.Drawing.Size(198, 34)
        Me.cmbCandidatura.TabIndex = 27
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 16.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(37, 151)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(161, 32)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Candidatura"
        '
        'btnExplorar
        '
        Me.btnExplorar.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.btnExplorar.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnExplorar.FlatAppearance.BorderSize = 2
        Me.btnExplorar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnExplorar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.btnExplorar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExplorar.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExplorar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnExplorar.Location = New System.Drawing.Point(303, 214)
        Me.btnExplorar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnExplorar.Name = "btnExplorar"
        Me.btnExplorar.Size = New System.Drawing.Size(136, 45)
        Me.btnExplorar.TabIndex = 29
        Me.btnExplorar.Text = "Explorar"
        Me.btnExplorar.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.TxtIdentidad)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cmbCandidatura)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 15)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(509, 265)
        Me.GroupBox1.TabIndex = 30
        Me.GroupBox1.TabStop = False
        '
        'Funcion
        '
        Me.Funcion.BackColor = System.Drawing.Color.Transparent
        Me.Funcion.Controls.Add(Me.imgFoto)
        Me.Funcion.Controls.Add(Me.btnAgregar)
        Me.Funcion.Controls.Add(Me.btnExplorar)
        Me.Funcion.Location = New System.Drawing.Point(533, 13)
        Me.Funcion.Margin = New System.Windows.Forms.Padding(4)
        Me.Funcion.Name = "Funcion"
        Me.Funcion.Padding = New System.Windows.Forms.Padding(4)
        Me.Funcion.Size = New System.Drawing.Size(515, 267)
        Me.Funcion.TabIndex = 31
        Me.Funcion.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.dgvCandidatos)
        Me.GroupBox3.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox3.Location = New System.Drawing.Point(16, 321)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox3.Size = New System.Drawing.Size(1032, 378)
        Me.GroupBox3.TabIndex = 32
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Candidatos"
        '
        'dgvCandidatos
        '
        Me.dgvCandidatos.AllowUserToAddRows = False
        Me.dgvCandidatos.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(61, Byte), Integer))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gray
        Me.dgvCandidatos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvCandidatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvCandidatos.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.dgvCandidatos.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(61, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCandidatos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvCandidatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(82, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvCandidatos.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvCandidatos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvCandidatos.EnableHeadersVisualStyles = False
        Me.dgvCandidatos.GridColor = System.Drawing.Color.White
        Me.dgvCandidatos.Location = New System.Drawing.Point(3, 22)
        Me.dgvCandidatos.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgvCandidatos.Name = "dgvCandidatos"
        Me.dgvCandidatos.ReadOnly = True
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(61, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCandidatos.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvCandidatos.RowHeadersWidth = 51
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(82, Byte), Integer))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Gray
        Me.dgvCandidatos.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvCandidatos.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.dgvCandidatos.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvCandidatos.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White
        Me.dgvCandidatos.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Gray
        Me.dgvCandidatos.RowTemplate.Height = 40
        Me.dgvCandidatos.Size = New System.Drawing.Size(1026, 354)
        Me.dgvCandidatos.TabIndex = 0
        '
        'AgregarImagenCandidato
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1061, 710)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Funcion)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "AgregarImagenCandidato"
        Me.Text = "AgregarImagenCandidato"
        CType(Me.imgFoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Funcion.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.dgvCandidatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents imgFoto As PictureBox
    Friend WithEvents btnAgregar As Button
    Friend WithEvents TxtIdentidad As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbCandidatura As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnExplorar As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Funcion As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents dgvCandidatos As DataGridView
End Class
