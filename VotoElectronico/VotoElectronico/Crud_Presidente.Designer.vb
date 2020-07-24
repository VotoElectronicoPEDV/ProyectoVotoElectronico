<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Crud_Presidente
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
        Me.txtIdentidad = New System.Windows.Forms.TextBox()
        Me.txtSegundoApellido = New System.Windows.Forms.TextBox()
        Me.txtPrimerApellido = New System.Windows.Forms.TextBox()
        Me.txtSegundoNombre = New System.Windows.Forms.TextBox()
        Me.txtPrimerNombre = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmbEstado = New System.Windows.Forms.ComboBox()
        Me.cmbPartido = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnEjecutar = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmbOperacion = New System.Windows.Forms.ComboBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.dgvPresidente = New System.Windows.Forms.DataGridView()
        Me.ErrorValidacion = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgvPresidente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorValidacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtIdentidad
        '
        Me.txtIdentidad.Location = New System.Drawing.Point(120, 24)
        Me.txtIdentidad.Margin = New System.Windows.Forms.Padding(2)
        Me.txtIdentidad.MaxLength = 13
        Me.txtIdentidad.Name = "txtIdentidad"
        Me.txtIdentidad.Size = New System.Drawing.Size(91, 20)
        Me.txtIdentidad.TabIndex = 0
        '
        'txtSegundoApellido
        '
        Me.txtSegundoApellido.Location = New System.Drawing.Point(341, 24)
        Me.txtSegundoApellido.Margin = New System.Windows.Forms.Padding(2)
        Me.txtSegundoApellido.Name = "txtSegundoApellido"
        Me.txtSegundoApellido.Size = New System.Drawing.Size(91, 20)
        Me.txtSegundoApellido.TabIndex = 3
        '
        'txtPrimerApellido
        '
        Me.txtPrimerApellido.Location = New System.Drawing.Point(120, 158)
        Me.txtPrimerApellido.Margin = New System.Windows.Forms.Padding(2)
        Me.txtPrimerApellido.Name = "txtPrimerApellido"
        Me.txtPrimerApellido.Size = New System.Drawing.Size(91, 20)
        Me.txtPrimerApellido.TabIndex = 4
        '
        'txtSegundoNombre
        '
        Me.txtSegundoNombre.Location = New System.Drawing.Point(120, 107)
        Me.txtSegundoNombre.Margin = New System.Windows.Forms.Padding(2)
        Me.txtSegundoNombre.Name = "txtSegundoNombre"
        Me.txtSegundoNombre.Size = New System.Drawing.Size(91, 20)
        Me.txtSegundoNombre.TabIndex = 5
        '
        'txtPrimerNombre
        '
        Me.txtPrimerNombre.Location = New System.Drawing.Point(120, 63)
        Me.txtPrimerNombre.Margin = New System.Windows.Forms.Padding(2)
        Me.txtPrimerNombre.Name = "txtPrimerNombre"
        Me.txtPrimerNombre.Size = New System.Drawing.Size(91, 20)
        Me.txtPrimerNombre.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 27)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Identidad"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 67)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Primer Nombre"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 111)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Segundo Nombre"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(20, 162)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Primer Apellido"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(246, 67)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Partido"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(246, 27)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(90, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Segundo Apellido"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmbEstado)
        Me.GroupBox1.Controls.Add(Me.cmbPartido)
        Me.GroupBox1.Controls.Add(Me.txtPrimerApellido)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtIdentidad)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtSegundoNombre)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtPrimerNombre)
        Me.GroupBox1.Controls.Add(Me.txtSegundoApellido)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(9, 10)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(446, 199)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Presidente"
        '
        'cmbEstado
        '
        Me.cmbEstado.FormattingEnabled = True
        Me.cmbEstado.Items.AddRange(New Object() {"activo"})
        Me.cmbEstado.Location = New System.Drawing.Point(340, 106)
        Me.cmbEstado.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbEstado.Name = "cmbEstado"
        Me.cmbEstado.Size = New System.Drawing.Size(92, 21)
        Me.cmbEstado.TabIndex = 15
        '
        'cmbPartido
        '
        Me.cmbPartido.FormattingEnabled = True
        Me.cmbPartido.Items.AddRange(New Object() {"Partido Nacional", "Partido Libre", "Partido AntiCorrupcion", "Partido Liberal"})
        Me.cmbPartido.Location = New System.Drawing.Point(341, 61)
        Me.cmbPartido.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbPartido.Name = "cmbPartido"
        Me.cmbPartido.Size = New System.Drawing.Size(92, 21)
        Me.cmbPartido.TabIndex = 14
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(246, 111)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Estado"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnEjecutar)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.cmbOperacion)
        Me.GroupBox2.Location = New System.Drawing.Point(466, 10)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Size = New System.Drawing.Size(125, 199)
        Me.GroupBox2.TabIndex = 15
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Operaciones Crud"
        '
        'btnEjecutar
        '
        Me.btnEjecutar.Location = New System.Drawing.Point(22, 124)
        Me.btnEjecutar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnEjecutar.Name = "btnEjecutar"
        Me.btnEjecutar.Size = New System.Drawing.Size(91, 20)
        Me.btnEjecutar.TabIndex = 2
        Me.btnEjecutar.Text = "Ejecutar"
        Me.btnEjecutar.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(20, 46)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 13)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Operación"
        '
        'cmbOperacion
        '
        Me.cmbOperacion.FormattingEnabled = True
        Me.cmbOperacion.Items.AddRange(New Object() {"Ingresar", "Actualizar", "Eliminar", "Consultar"})
        Me.cmbOperacion.Location = New System.Drawing.Point(22, 67)
        Me.cmbOperacion.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbOperacion.Name = "cmbOperacion"
        Me.cmbOperacion.Size = New System.Drawing.Size(92, 21)
        Me.cmbOperacion.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.dgvPresidente)
        Me.GroupBox3.Location = New System.Drawing.Point(9, 214)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox3.Size = New System.Drawing.Size(582, 142)
        Me.GroupBox3.TabIndex = 16
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Visualización de datos"
        '
        'dgvPresidente
        '
        Me.dgvPresidente.AllowUserToAddRows = False
        Me.dgvPresidente.AllowUserToDeleteRows = False
        Me.dgvPresidente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPresidente.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvPresidente.Location = New System.Drawing.Point(2, 15)
        Me.dgvPresidente.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvPresidente.Name = "dgvPresidente"
        Me.dgvPresidente.ReadOnly = True
        Me.dgvPresidente.RowHeadersWidth = 51
        Me.dgvPresidente.RowTemplate.Height = 24
        Me.dgvPresidente.Size = New System.Drawing.Size(578, 125)
        Me.dgvPresidente.TabIndex = 0
        '
        'ErrorValidacion
        '
        Me.ErrorValidacion.ContainerControl = Me
        '
        'Crud_Presidente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 366)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Crud_Presidente"
        Me.Text = "Crud_Presidente"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.dgvPresidente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorValidacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txtIdentidad As TextBox
    Friend WithEvents txtSegundoApellido As TextBox
    Friend WithEvents txtPrimerApellido As TextBox
    Friend WithEvents txtSegundoNombre As TextBox
    Friend WithEvents txtPrimerNombre As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cmbPartido As ComboBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnEjecutar As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents cmbOperacion As ComboBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents dgvPresidente As DataGridView
    Friend WithEvents cmbEstado As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents ErrorValidacion As ErrorProvider
    Friend WithEvents ToolTip As ToolTip
End Class
