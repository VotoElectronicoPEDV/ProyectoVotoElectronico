<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Crud_Alcaldes
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
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.dgvAlcaldes = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnEjecutar = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmbOperacion = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmbEstado = New System.Windows.Forms.ComboBox()
        Me.cmbPartido = New System.Windows.Forms.ComboBox()
        Me.txtPrimerApellido = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtIdentidad = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtSegundoNombre = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtPrimerNombre = New System.Windows.Forms.TextBox()
        Me.txtSegundoApellido = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbMunicipio = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgvAlcaldes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.dgvAlcaldes)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 263)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(776, 175)
        Me.GroupBox3.TabIndex = 19
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Visualización de datos"
        '
        'dgvAlcaldes
        '
        Me.dgvAlcaldes.AllowUserToAddRows = False
        Me.dgvAlcaldes.AllowUserToDeleteRows = False
        Me.dgvAlcaldes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAlcaldes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvAlcaldes.Location = New System.Drawing.Point(3, 18)
        Me.dgvAlcaldes.Name = "dgvAlcaldes"
        Me.dgvAlcaldes.ReadOnly = True
        Me.dgvAlcaldes.RowHeadersWidth = 51
        Me.dgvAlcaldes.RowTemplate.Height = 24
        Me.dgvAlcaldes.Size = New System.Drawing.Size(770, 154)
        Me.dgvAlcaldes.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnEjecutar)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.cmbOperacion)
        Me.GroupBox2.Location = New System.Drawing.Point(621, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(167, 245)
        Me.GroupBox2.TabIndex = 18
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Operaciones Crud"
        '
        'btnEjecutar
        '
        Me.btnEjecutar.Location = New System.Drawing.Point(29, 153)
        Me.btnEjecutar.Name = "btnEjecutar"
        Me.btnEjecutar.Size = New System.Drawing.Size(121, 25)
        Me.btnEjecutar.TabIndex = 2
        Me.btnEjecutar.Text = "Ejecutar"
        Me.btnEjecutar.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(26, 57)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(74, 17)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Operación"
        '
        'cmbOperacion
        '
        Me.cmbOperacion.FormattingEnabled = True
        Me.cmbOperacion.Items.AddRange(New Object() {"Ingresar", "Actualizar", "Eliminar", "Consultar"})
        Me.cmbOperacion.Location = New System.Drawing.Point(29, 82)
        Me.cmbOperacion.Name = "cmbOperacion"
        Me.cmbOperacion.Size = New System.Drawing.Size(121, 24)
        Me.cmbOperacion.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmbMunicipio)
        Me.GroupBox1.Controls.Add(Me.Label9)
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
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(595, 245)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Alcalde"
        '
        'cmbEstado
        '
        Me.cmbEstado.FormattingEnabled = True
        Me.cmbEstado.Items.AddRange(New Object() {"activo"})
        Me.cmbEstado.Location = New System.Drawing.Point(454, 130)
        Me.cmbEstado.Name = "cmbEstado"
        Me.cmbEstado.Size = New System.Drawing.Size(121, 24)
        Me.cmbEstado.TabIndex = 15
        '
        'cmbPartido
        '
        Me.cmbPartido.FormattingEnabled = True
        Me.cmbPartido.Items.AddRange(New Object() {"Partido Nacional", "Partido Libre", "Partido AntiCorrupcion", "Partido Liberal"})
        Me.cmbPartido.Location = New System.Drawing.Point(455, 75)
        Me.cmbPartido.Name = "cmbPartido"
        Me.cmbPartido.Size = New System.Drawing.Size(121, 24)
        Me.cmbPartido.TabIndex = 14
        '
        'txtPrimerApellido
        '
        Me.txtPrimerApellido.Location = New System.Drawing.Point(160, 195)
        Me.txtPrimerApellido.Name = "txtPrimerApellido"
        Me.txtPrimerApellido.Size = New System.Drawing.Size(120, 22)
        Me.txtPrimerApellido.TabIndex = 4
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(328, 33)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(119, 17)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Segundo Apellido"
        '
        'txtIdentidad
        '
        Me.txtIdentidad.Location = New System.Drawing.Point(160, 30)
        Me.txtIdentidad.MaxLength = 13
        Me.txtIdentidad.Name = "txtIdentidad"
        Me.txtIdentidad.Size = New System.Drawing.Size(120, 22)
        Me.txtIdentidad.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(328, 82)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 17)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Partido"
        '
        'txtSegundoNombre
        '
        Me.txtSegundoNombre.Location = New System.Drawing.Point(160, 132)
        Me.txtSegundoNombre.Name = "txtSegundoNombre"
        Me.txtSegundoNombre.Size = New System.Drawing.Size(120, 22)
        Me.txtSegundoNombre.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(328, 137)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 17)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Estado"
        '
        'txtPrimerNombre
        '
        Me.txtPrimerNombre.Location = New System.Drawing.Point(160, 77)
        Me.txtPrimerNombre.Name = "txtPrimerNombre"
        Me.txtPrimerNombre.Size = New System.Drawing.Size(120, 22)
        Me.txtPrimerNombre.TabIndex = 6
        '
        'txtSegundoApellido
        '
        Me.txtSegundoApellido.Location = New System.Drawing.Point(455, 30)
        Me.txtSegundoApellido.Name = "txtSegundoApellido"
        Me.txtSegundoApellido.Size = New System.Drawing.Size(120, 22)
        Me.txtSegundoApellido.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(27, 200)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(103, 17)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Primer Apellido"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 17)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Identidad"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(27, 137)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(119, 17)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Segundo Nombre"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 17)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Primer Nombre"
        '
        'cmbMunicipio
        '
        Me.cmbMunicipio.FormattingEnabled = True
        Me.cmbMunicipio.Items.AddRange(New Object() {"Comayagua", "Ajuterique", "El Rosario", "Esquías", "Humuya", "La Libertad", "Lamaní", "La Trinidad", "Lejamaní", "Meámbar", "Minas de Oro", "Ojos de Agua", "San Jerónimo", "San José de Comayagua", "San José del Potrero", "San Luis", "San Sebastián", "Siguatepeque", "Villa de San Antonio", "Las Lajas", "Taulabé"})
        Me.cmbMunicipio.Location = New System.Drawing.Point(455, 183)
        Me.cmbMunicipio.Name = "cmbMunicipio"
        Me.cmbMunicipio.Size = New System.Drawing.Size(121, 24)
        Me.cmbMunicipio.TabIndex = 17
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(329, 190)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(67, 17)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Municipio"
        '
        'Crud_Alcaldes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Crud_Alcaldes"
        Me.Text = "Crud_Alcaldes"
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.dgvAlcaldes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents dgvAlcaldes As DataGridView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnEjecutar As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents cmbOperacion As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cmbEstado As ComboBox
    Friend WithEvents cmbPartido As ComboBox
    Friend WithEvents txtPrimerApellido As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtIdentidad As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtSegundoNombre As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtPrimerNombre As TextBox
    Friend WithEvents txtSegundoApellido As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbMunicipio As ComboBox
    Friend WithEvents Label9 As Label
End Class
