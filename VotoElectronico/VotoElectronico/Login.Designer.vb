<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.btnREGRESAR = New System.Windows.Forms.Button()
        Me.ErrorValidacion = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PanelSuperior = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.txtContrasena = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnBROMA = New System.Windows.Forms.Button()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.MenuStrip15 = New System.Windows.Forms.MenuStrip()
        Me.OptVer = New System.Windows.Forms.ToolStripMenuItem()
        Me.optOcultar = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.ErrorValidacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelSuperior.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.MenuStrip15.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnREGRESAR
        '
        Me.btnREGRESAR.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btnREGRESAR.FlatAppearance.BorderSize = 0
        Me.btnREGRESAR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnREGRESAR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btnREGRESAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnREGRESAR.Font = New System.Drawing.Font("Times New Roman", 8.25!)
        Me.btnREGRESAR.ForeColor = System.Drawing.Color.White
        Me.btnREGRESAR.Location = New System.Drawing.Point(249, 373)
        Me.btnREGRESAR.Name = "btnREGRESAR"
        Me.btnREGRESAR.Size = New System.Drawing.Size(96, 36)
        Me.btnREGRESAR.TabIndex = 6
        Me.btnREGRESAR.Text = "REGRESAR"
        Me.btnREGRESAR.UseVisualStyleBackColor = False
        '
        'ErrorValidacion
        '
        Me.ErrorValidacion.ContainerControl = Me
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 451)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(587, 18)
        Me.Panel1.TabIndex = 13
        '
        'PanelSuperior
        '
        Me.PanelSuperior.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.PanelSuperior.Controls.Add(Me.Label3)
        Me.PanelSuperior.Controls.Add(Me.PictureBox1)
        Me.PanelSuperior.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelSuperior.Location = New System.Drawing.Point(0, 0)
        Me.PanelSuperior.Name = "PanelSuperior"
        Me.PanelSuperior.Size = New System.Drawing.Size(587, 41)
        Me.PanelSuperior.TabIndex = 14
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft PhagsPa", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(214, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(172, 25)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "INICIO DE SESIÓN"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.VotoElectronico.My.Resources.Resources.kisspng_flag_of_honduras_el_salvador_national_flag_5b18fd380145f8_removebg_preview
        Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(65, 35)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'txtUsuario
        '
        Me.txtUsuario.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsuario.ForeColor = System.Drawing.Color.White
        Me.txtUsuario.Location = New System.Drawing.Point(264, 185)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(236, 17)
        Me.txtUsuario.TabIndex = 17
        '
        'txtContrasena
        '
        Me.txtContrasena.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.txtContrasena.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtContrasena.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContrasena.ForeColor = System.Drawing.Color.White
        Me.txtContrasena.Location = New System.Drawing.Point(264, 261)
        Me.txtContrasena.Name = "txtContrasena"
        Me.txtContrasena.Size = New System.Drawing.Size(236, 17)
        Me.txtContrasena.TabIndex = 18
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(264, 166)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 16)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "ID Usuario"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(261, 242)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 16)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Contraseña"
        '
        'btnBROMA
        '
        Me.btnBROMA.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnBROMA.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnBROMA.FlatAppearance.BorderSize = 0
        Me.btnBROMA.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnBROMA.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnBROMA.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBROMA.Font = New System.Drawing.Font("Times New Roman", 8.25!)
        Me.btnBROMA.ForeColor = System.Drawing.Color.White
        Me.btnBROMA.Location = New System.Drawing.Point(474, 415)
        Me.btnBROMA.Name = "btnBROMA"
        Me.btnBROMA.Size = New System.Drawing.Size(96, 30)
        Me.btnBROMA.TabIndex = 21
        Me.btnBROMA.UseVisualStyleBackColor = False
        '
        'btnAceptar
        '
        Me.btnAceptar.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btnAceptar.FlatAppearance.BorderSize = 0
        Me.btnAceptar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnAceptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime
        Me.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAceptar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAceptar.ForeColor = System.Drawing.Color.White
        Me.btnAceptar.Location = New System.Drawing.Point(456, 373)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(92, 36)
        Me.btnAceptar.TabIndex = 5
        Me.btnAceptar.Text = "ACEPTAR"
        Me.btnAceptar.UseVisualStyleBackColor = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.VotoElectronico.My.Resources.Resources.security
        Me.PictureBox4.Location = New System.Drawing.Point(12, 81)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(166, 226)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 24
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.VotoElectronico.My.Resources.Resources.password
        Me.PictureBox3.Location = New System.Drawing.Point(219, 242)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(39, 34)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 23
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.VotoElectronico.My.Resources.Resources.login
        Me.PictureBox2.Location = New System.Drawing.Point(219, 166)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(39, 34)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 22
        Me.PictureBox2.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Panel2.Controls.Add(Me.PictureBox4)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 41)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(200, 410)
        Me.Panel2.TabIndex = 25
        '
        'MenuStrip15
        '
        Me.MenuStrip15.AutoSize = False
        Me.MenuStrip15.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip15.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip15.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip15.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OptVer, Me.optOcultar})
        Me.MenuStrip15.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.MenuStrip15.Location = New System.Drawing.Point(513, 250)
        Me.MenuStrip15.Name = "MenuStrip15"
        Me.MenuStrip15.Padding = New System.Windows.Forms.Padding(4, 2, 0, 2)
        Me.MenuStrip15.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.MenuStrip15.ShowItemToolTips = True
        Me.MenuStrip15.Size = New System.Drawing.Size(74, 28)
        Me.MenuStrip15.TabIndex = 604
        Me.MenuStrip15.Text = "MenuStrip15"
        '
        'OptVer
        '
        Me.OptVer.BackColor = System.Drawing.Color.Transparent
        Me.OptVer.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.OptVer.ForeColor = System.Drawing.Color.Black
        Me.OptVer.Image = CType(resources.GetObject("OptVer.Image"), System.Drawing.Image)
        Me.OptVer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.OptVer.ImageTransparentColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.OptVer.Name = "OptVer"
        Me.OptVer.Size = New System.Drawing.Size(32, 24)
        Me.OptVer.ToolTipText = "Ver contraseña"
        '
        'optOcultar
        '
        Me.optOcultar.BackColor = System.Drawing.Color.Transparent
        Me.optOcultar.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.optOcultar.ForeColor = System.Drawing.Color.Black
        Me.optOcultar.Image = CType(resources.GetObject("optOcultar.Image"), System.Drawing.Image)
        Me.optOcultar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.optOcultar.ImageTransparentColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.optOcultar.Name = "optOcultar"
        Me.optOcultar.Size = New System.Drawing.Size(32, 24)
        Me.optOcultar.ToolTipText = "Ocultar contraseña"
        Me.optOcultar.Visible = False
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(587, 469)
        Me.Controls.Add(Me.MenuStrip15)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.btnBROMA)
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(Me.txtContrasena)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PanelSuperior)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.btnREGRESAR)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Login"
        Me.Opacity = 0.9R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        CType(Me.ErrorValidacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelSuperior.ResumeLayout(False)
        Me.PanelSuperior.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.MenuStrip15.ResumeLayout(False)
        Me.MenuStrip15.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnAceptar As Button
    Friend WithEvents ErrorValidacion As ErrorProvider
    Friend WithEvents ToolTip As ToolTip
    Friend WithEvents btnREGRESAR As Button
    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents txtContrasena As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PanelSuperior As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnBROMA As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents MenuStrip15 As MenuStrip
    Friend WithEvents OptVer As ToolStripMenuItem
    Friend WithEvents optOcultar As ToolStripMenuItem
End Class
