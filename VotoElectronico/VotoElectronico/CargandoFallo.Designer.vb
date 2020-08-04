<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CargandoFallo
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
        Me.CircularProgressBar1 = New CircularProgressBar.CircularProgressBar()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CircularProgressBar1
        '
        Me.CircularProgressBar1.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner
        Me.CircularProgressBar1.AnimationSpeed = 500
        Me.CircularProgressBar1.BackColor = System.Drawing.Color.Transparent
        Me.CircularProgressBar1.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Bold)
        Me.CircularProgressBar1.ForeColor = System.Drawing.Color.White
        Me.CircularProgressBar1.InnerColor = System.Drawing.Color.DimGray
        Me.CircularProgressBar1.InnerMargin = 2
        Me.CircularProgressBar1.InnerWidth = -1
        Me.CircularProgressBar1.Location = New System.Drawing.Point(952, 439)
        Me.CircularProgressBar1.Margin = New System.Windows.Forms.Padding(4)
        Me.CircularProgressBar1.MarqueeAnimationSpeed = 2000
        Me.CircularProgressBar1.Name = "CircularProgressBar1"
        Me.CircularProgressBar1.OuterColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.CircularProgressBar1.OuterMargin = -25
        Me.CircularProgressBar1.OuterWidth = 26
        Me.CircularProgressBar1.ProgressColor = System.Drawing.Color.Chartreuse
        Me.CircularProgressBar1.ProgressWidth = 25
        Me.CircularProgressBar1.SecondaryFont = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.CircularProgressBar1.Size = New System.Drawing.Size(107, 99)
        Me.CircularProgressBar1.StartAngle = 270
        Me.CircularProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee
        Me.CircularProgressBar1.SubscriptColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.CircularProgressBar1.SubscriptMargin = New System.Windows.Forms.Padding(10, -35, 0, 0)
        Me.CircularProgressBar1.SubscriptText = ""
        Me.CircularProgressBar1.SuperscriptColor = System.Drawing.Color.White
        Me.CircularProgressBar1.SuperscriptMargin = New System.Windows.Forms.Padding(10, 35, 0, 0)
        Me.CircularProgressBar1.SuperscriptText = "%"
        Me.CircularProgressBar1.TabIndex = 3
        Me.CircularProgressBar1.Text = "0"
        Me.CircularProgressBar1.TextMargin = New System.Windows.Forms.Padding(8, 8, 0, 0)
        Me.CircularProgressBar1.Value = 68
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.VotoElectronico.My.Resources.Resources.thumbnail_45933
        Me.PictureBox1.Location = New System.Drawing.Point(2, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1070, 442)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 30
        '
        'Timer2
        '
        Me.Timer2.Interval = 30
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Console", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Lime
        Me.Label1.Location = New System.Drawing.Point(793, 508)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(152, 20)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Reiniciando"
        '
        'CargandoFallo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImage = Global.VotoElectronico.My.Resources.Resources.thumbnail_45933
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1072, 537)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.CircularProgressBar1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "CargandoFallo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CargandoFallo"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CircularProgressBar1 As CircularProgressBar.CircularProgressBar
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Label1 As Label
End Class
