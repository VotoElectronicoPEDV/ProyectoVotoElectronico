<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VotacionInterna
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
        Me.txtidentidad = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnAcceder = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtidentidad
        '
        Me.txtidentidad.Location = New System.Drawing.Point(101, 48)
        Me.txtidentidad.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtidentidad.Name = "txtidentidad"
        Me.txtidentidad.Size = New System.Drawing.Size(132, 22)
        Me.txtidentidad.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 52)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Identidad"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(28, 11)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Votante"
        '
        'btnAcceder
        '
        Me.btnAcceder.Location = New System.Drawing.Point(130, 120)
        Me.btnAcceder.Name = "btnAcceder"
        Me.btnAcceder.Size = New System.Drawing.Size(78, 37)
        Me.btnAcceder.TabIndex = 3
        Me.btnAcceder.Text = "Acceder"
        Me.btnAcceder.UseVisualStyleBackColor = True
        '
        'VotacionInterna
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(396, 194)
        Me.Controls.Add(Me.btnAcceder)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtidentidad)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "VotacionInterna"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtidentidad As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnAcceder As Button
End Class
