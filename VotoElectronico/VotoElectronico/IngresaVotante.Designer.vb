<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IngresaVotante
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnAdmin = New System.Windows.Forms.Button()
        Me.txtidentidad = New System.Windows.Forms.TextBox()
        Me.btnAcceder = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ErrorValidacion = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        CType(Me.ErrorValidacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(28, 11)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 17)
        Me.Label2.TabIndex = 2
        '
        'btnAdmin
        '
        Me.btnAdmin.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btnAdmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnAdmin.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnAdmin.FlatAppearance.BorderSize = 0
        Me.btnAdmin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.btnAdmin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.btnAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdmin.Font = New System.Drawing.Font("Times New Roman", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdmin.ForeColor = System.Drawing.Color.White
        Me.btnAdmin.Location = New System.Drawing.Point(323, 251)
        Me.btnAdmin.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAdmin.Name = "btnAdmin"
        Me.btnAdmin.Size = New System.Drawing.Size(109, 38)
        Me.btnAdmin.TabIndex = 5
        Me.btnAdmin.Text = "ADMIN"
        Me.btnAdmin.UseVisualStyleBackColor = False
        '
        'txtidentidad
        '
        Me.txtidentidad.BackColor = System.Drawing.Color.Gray
        Me.txtidentidad.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtidentidad.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtidentidad.ForeColor = System.Drawing.Color.White
        Me.txtidentidad.Location = New System.Drawing.Point(389, 155)
        Me.txtidentidad.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtidentidad.MaxLength = 13
        Me.txtidentidad.Name = "txtidentidad"
        Me.txtidentidad.Size = New System.Drawing.Size(253, 19)
        Me.txtidentidad.TabIndex = 0
        '
        'btnAcceder
        '
        Me.btnAcceder.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btnAcceder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnAcceder.FlatAppearance.BorderSize = 0
        Me.btnAcceder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(3, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.btnAcceder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(4, Byte), Integer))
        Me.btnAcceder.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAcceder.Font = New System.Drawing.Font("Times New Roman", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAcceder.ForeColor = System.Drawing.Color.White
        Me.btnAcceder.Location = New System.Drawing.Point(505, 252)
        Me.btnAcceder.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAcceder.Name = "btnAcceder"
        Me.btnAcceder.Size = New System.Drawing.Size(117, 37)
        Me.btnAcceder.TabIndex = 4
        Me.btnAcceder.Text = "ACCEDER"
        Me.btnAcceder.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(384, 98)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 23)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Identidad"
        '
        'ErrorValidacion
        '
        Me.ErrorValidacion.ContainerControl = Me
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(267, 316)
        Me.Panel1.TabIndex = 16
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.VotoElectronico.My.Resources.Resources.kisspng_flag_of_honduras_el_salvador_national_flag_5b18fd380145f8_removebg_preview1
        Me.PictureBox1.Location = New System.Drawing.Point(32, 60)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(215, 192)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.VotoElectronico.My.Resources.Resources.user2
        Me.PictureBox2.Location = New System.Drawing.Point(289, 98)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(87, 75)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 17
        Me.PictureBox2.TabStop = False
        '
        'IngresaVotante
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(687, 316)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnAdmin)
        Me.Controls.Add(Me.txtidentidad)
        Me.Controls.Add(Me.btnAcceder)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "IngresaVotante"
        Me.Opacity = 0.9R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Verificar Votante"
        CType(Me.ErrorValidacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents txtidentidad As TextBox
    Friend WithEvents btnAcceder As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents ErrorValidacion As ErrorProvider
    Friend WithEvents ToolTip As ToolTip
    Friend WithEvents btnAdmin As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
End Class
