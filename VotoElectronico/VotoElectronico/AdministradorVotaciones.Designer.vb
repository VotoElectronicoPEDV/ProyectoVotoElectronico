<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AdministradorVotaciones
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
        Me.PanelMenu = New System.Windows.Forms.FlowLayoutPanel()
        Me.BtnAlmacenamiento = New System.Windows.Forms.Button()
        Me.PanelSubMenuCandidatos = New System.Windows.Forms.Panel()
        Me.btnAlcaldes = New System.Windows.Forms.Button()
        Me.btnDiputados = New System.Windows.Forms.Button()
        Me.btnPresidentes = New System.Windows.Forms.Button()
        Me.btnVotantes = New System.Windows.Forms.Button()
        Me.BtnAjustes = New System.Windows.Forms.Button()
        Me.PanelAjustes = New System.Windows.Forms.Panel()
        Me.btnReiniciarVotacion = New System.Windows.Forms.Button()
        Me.btnVotacionExterna = New System.Windows.Forms.Button()
        Me.btnAgregarImagenCandidatos = New System.Windows.Forms.Button()
        Me.btnRegresar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PanelFormularios = New System.Windows.Forms.Panel()
        Me.PanelSuperior = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PanelMenu.SuspendLayout()
        Me.PanelSubMenuCandidatos.SuspendLayout()
        Me.PanelAjustes.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelFormularios.SuspendLayout()
        Me.PanelSuperior.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelMenu
        '
        Me.PanelMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.PanelMenu.Controls.Add(Me.BtnAlmacenamiento)
        Me.PanelMenu.Controls.Add(Me.PanelSubMenuCandidatos)
        Me.PanelMenu.Controls.Add(Me.BtnAjustes)
        Me.PanelMenu.Controls.Add(Me.PanelAjustes)
        Me.PanelMenu.Controls.Add(Me.btnRegresar)
        Me.PanelMenu.Controls.Add(Me.btnSalir)
        Me.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelMenu.Location = New System.Drawing.Point(0, 44)
        Me.PanelMenu.Margin = New System.Windows.Forms.Padding(2)
        Me.PanelMenu.Name = "PanelMenu"
        Me.PanelMenu.Size = New System.Drawing.Size(181, 596)
        Me.PanelMenu.TabIndex = 3
        '
        'BtnAlmacenamiento
        '
        Me.BtnAlmacenamiento.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.BtnAlmacenamiento.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnAlmacenamiento.FlatAppearance.BorderSize = 0
        Me.BtnAlmacenamiento.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.BtnAlmacenamiento.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan
        Me.BtnAlmacenamiento.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAlmacenamiento.Font = New System.Drawing.Font("Times New Roman", 10.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.BtnAlmacenamiento.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.BtnAlmacenamiento.Location = New System.Drawing.Point(3, 3)
        Me.BtnAlmacenamiento.Name = "BtnAlmacenamiento"
        Me.BtnAlmacenamiento.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.BtnAlmacenamiento.Size = New System.Drawing.Size(180, 71)
        Me.BtnAlmacenamiento.TabIndex = 1
        Me.BtnAlmacenamiento.Text = "Almacenamiento"
        Me.BtnAlmacenamiento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAlmacenamiento.UseVisualStyleBackColor = False
        '
        'PanelSubMenuCandidatos
        '
        Me.PanelSubMenuCandidatos.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PanelSubMenuCandidatos.Controls.Add(Me.btnAlcaldes)
        Me.PanelSubMenuCandidatos.Controls.Add(Me.btnDiputados)
        Me.PanelSubMenuCandidatos.Controls.Add(Me.btnPresidentes)
        Me.PanelSubMenuCandidatos.Controls.Add(Me.btnVotantes)
        Me.PanelSubMenuCandidatos.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelSubMenuCandidatos.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.PanelSubMenuCandidatos.Location = New System.Drawing.Point(3, 80)
        Me.PanelSubMenuCandidatos.Name = "PanelSubMenuCandidatos"
        Me.PanelSubMenuCandidatos.Size = New System.Drawing.Size(180, 254)
        Me.PanelSubMenuCandidatos.TabIndex = 2
        '
        'btnAlcaldes
        '
        Me.btnAlcaldes.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnAlcaldes.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnAlcaldes.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnAlcaldes.FlatAppearance.BorderSize = 0
        Me.btnAlcaldes.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnAlcaldes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.btnAlcaldes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnAlcaldes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAlcaldes.Font = New System.Drawing.Font("Times New Roman", 10.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAlcaldes.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnAlcaldes.Image = Global.VotoElectronico.My.Resources.Resources.people_40px
        Me.btnAlcaldes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAlcaldes.Location = New System.Drawing.Point(0, 189)
        Me.btnAlcaldes.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAlcaldes.Name = "btnAlcaldes"
        Me.btnAlcaldes.Size = New System.Drawing.Size(180, 63)
        Me.btnAlcaldes.TabIndex = 0
        Me.btnAlcaldes.Text = "Alcaldes"
        Me.btnAlcaldes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAlcaldes.UseVisualStyleBackColor = False
        '
        'btnDiputados
        '
        Me.btnDiputados.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnDiputados.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnDiputados.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnDiputados.FlatAppearance.BorderSize = 0
        Me.btnDiputados.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnDiputados.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.btnDiputados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnDiputados.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDiputados.Font = New System.Drawing.Font("Times New Roman", 10.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDiputados.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnDiputados.Image = Global.VotoElectronico.My.Resources.Resources.Diputados
        Me.btnDiputados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDiputados.Location = New System.Drawing.Point(0, 126)
        Me.btnDiputados.Margin = New System.Windows.Forms.Padding(2)
        Me.btnDiputados.Name = "btnDiputados"
        Me.btnDiputados.Size = New System.Drawing.Size(180, 63)
        Me.btnDiputados.TabIndex = 1
        Me.btnDiputados.Text = "Diputados"
        Me.btnDiputados.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDiputados.UseVisualStyleBackColor = False
        '
        'btnPresidentes
        '
        Me.btnPresidentes.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnPresidentes.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnPresidentes.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnPresidentes.FlatAppearance.BorderSize = 0
        Me.btnPresidentes.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnPresidentes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.btnPresidentes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnPresidentes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPresidentes.Font = New System.Drawing.Font("Times New Roman", 10.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPresidentes.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnPresidentes.Image = Global.VotoElectronico.My.Resources.Resources.user_account_40px
        Me.btnPresidentes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPresidentes.Location = New System.Drawing.Point(0, 63)
        Me.btnPresidentes.Margin = New System.Windows.Forms.Padding(2)
        Me.btnPresidentes.Name = "btnPresidentes"
        Me.btnPresidentes.Size = New System.Drawing.Size(180, 63)
        Me.btnPresidentes.TabIndex = 2
        Me.btnPresidentes.Text = "Presidentes"
        Me.btnPresidentes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPresidentes.UseVisualStyleBackColor = False
        '
        'btnVotantes
        '
        Me.btnVotantes.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnVotantes.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnVotantes.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnVotantes.FlatAppearance.BorderSize = 0
        Me.btnVotantes.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnVotantes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.btnVotantes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnVotantes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVotantes.Font = New System.Drawing.Font("Times New Roman", 10.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVotantes.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnVotantes.Image = Global.VotoElectronico.My.Resources.Resources.user_groups_48px
        Me.btnVotantes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnVotantes.Location = New System.Drawing.Point(0, 0)
        Me.btnVotantes.Margin = New System.Windows.Forms.Padding(2)
        Me.btnVotantes.Name = "btnVotantes"
        Me.btnVotantes.Size = New System.Drawing.Size(180, 63)
        Me.btnVotantes.TabIndex = 3
        Me.btnVotantes.Text = "Votantes"
        Me.btnVotantes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnVotantes.UseVisualStyleBackColor = False
        '
        'BtnAjustes
        '
        Me.BtnAjustes.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.BtnAjustes.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnAjustes.FlatAppearance.BorderSize = 0
        Me.BtnAjustes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.BtnAjustes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan
        Me.BtnAjustes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAjustes.Font = New System.Drawing.Font("Times New Roman", 10.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.BtnAjustes.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.BtnAjustes.Location = New System.Drawing.Point(3, 340)
        Me.BtnAjustes.Name = "BtnAjustes"
        Me.BtnAjustes.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.BtnAjustes.Size = New System.Drawing.Size(180, 71)
        Me.BtnAjustes.TabIndex = 3
        Me.BtnAjustes.Text = "Ajustes"
        Me.BtnAjustes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAjustes.UseVisualStyleBackColor = False
        '
        'PanelAjustes
        '
        Me.PanelAjustes.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PanelAjustes.Controls.Add(Me.btnReiniciarVotacion)
        Me.PanelAjustes.Controls.Add(Me.btnVotacionExterna)
        Me.PanelAjustes.Controls.Add(Me.btnAgregarImagenCandidatos)
        Me.PanelAjustes.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelAjustes.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.PanelAjustes.Location = New System.Drawing.Point(3, 417)
        Me.PanelAjustes.Name = "PanelAjustes"
        Me.PanelAjustes.Size = New System.Drawing.Size(180, 179)
        Me.PanelAjustes.TabIndex = 4
        '
        'btnReiniciarVotacion
        '
        Me.btnReiniciarVotacion.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnReiniciarVotacion.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnReiniciarVotacion.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnReiniciarVotacion.FlatAppearance.BorderSize = 0
        Me.btnReiniciarVotacion.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnReiniciarVotacion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.btnReiniciarVotacion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnReiniciarVotacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReiniciarVotacion.Font = New System.Drawing.Font("Times New Roman", 10.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReiniciarVotacion.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnReiniciarVotacion.Image = Global.VotoElectronico.My.Resources.Resources.reset_48px
        Me.btnReiniciarVotacion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReiniciarVotacion.Location = New System.Drawing.Point(0, 120)
        Me.btnReiniciarVotacion.Margin = New System.Windows.Forms.Padding(2)
        Me.btnReiniciarVotacion.Name = "btnReiniciarVotacion"
        Me.btnReiniciarVotacion.Size = New System.Drawing.Size(180, 63)
        Me.btnReiniciarVotacion.TabIndex = 7
        Me.btnReiniciarVotacion.Text = "Reiniciar Vot."
        Me.btnReiniciarVotacion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnReiniciarVotacion.UseVisualStyleBackColor = False
        '
        'btnVotacionExterna
        '
        Me.btnVotacionExterna.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnVotacionExterna.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnVotacionExterna.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnVotacionExterna.FlatAppearance.BorderSize = 0
        Me.btnVotacionExterna.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnVotacionExterna.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.btnVotacionExterna.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnVotacionExterna.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVotacionExterna.Font = New System.Drawing.Font("Times New Roman", 10.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVotacionExterna.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnVotacionExterna.Image = Global.VotoElectronico.My.Resources.Resources.open_in_browser_40px
        Me.btnVotacionExterna.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnVotacionExterna.Location = New System.Drawing.Point(0, 57)
        Me.btnVotacionExterna.Margin = New System.Windows.Forms.Padding(2)
        Me.btnVotacionExterna.Name = "btnVotacionExterna"
        Me.btnVotacionExterna.Size = New System.Drawing.Size(180, 63)
        Me.btnVotacionExterna.TabIndex = 6
        Me.btnVotacionExterna.Text = "Votación Ext."
        Me.btnVotacionExterna.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnVotacionExterna.UseVisualStyleBackColor = False
        '
        'btnAgregarImagenCandidatos
        '
        Me.btnAgregarImagenCandidatos.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnAgregarImagenCandidatos.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnAgregarImagenCandidatos.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnAgregarImagenCandidatos.FlatAppearance.BorderSize = 0
        Me.btnAgregarImagenCandidatos.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnAgregarImagenCandidatos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.btnAgregarImagenCandidatos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnAgregarImagenCandidatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregarImagenCandidatos.Font = New System.Drawing.Font("Times New Roman", 10.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarImagenCandidatos.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnAgregarImagenCandidatos.Image = Global.VotoElectronico.My.Resources.Resources.photo_gallery_40px
        Me.btnAgregarImagenCandidatos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAgregarImagenCandidatos.Location = New System.Drawing.Point(0, 0)
        Me.btnAgregarImagenCandidatos.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAgregarImagenCandidatos.Name = "btnAgregarImagenCandidatos"
        Me.btnAgregarImagenCandidatos.Size = New System.Drawing.Size(180, 57)
        Me.btnAgregarImagenCandidatos.TabIndex = 5
        Me.btnAgregarImagenCandidatos.Text = "Imagen Cand"
        Me.btnAgregarImagenCandidatos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAgregarImagenCandidatos.UseVisualStyleBackColor = False
        '
        'btnRegresar
        '
        Me.btnRegresar.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnRegresar.FlatAppearance.BorderSize = 0
        Me.btnRegresar.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnRegresar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.btnRegresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegresar.Font = New System.Drawing.Font("Times New Roman", 10.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegresar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnRegresar.Image = Global.VotoElectronico.My.Resources.Resources.exit_100px
        Me.btnRegresar.Location = New System.Drawing.Point(2, 601)
        Me.btnRegresar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnRegresar.Name = "btnRegresar"
        Me.btnRegresar.Size = New System.Drawing.Size(80, 80)
        Me.btnRegresar.TabIndex = 10
        Me.btnRegresar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnRegresar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnSalir.FlatAppearance.BorderSize = 0
        Me.btnSalir.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalir.Font = New System.Drawing.Font("Times New Roman", 10.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnSalir.Image = Global.VotoElectronico.My.Resources.Resources.shutdown_100px
        Me.btnSalir.Location = New System.Drawing.Point(86, 601)
        Me.btnSalir.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(80, 80)
        Me.btnSalir.TabIndex = 9
        Me.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox1.BackColor = System.Drawing.Color.Gray
        Me.PictureBox1.Location = New System.Drawing.Point(232, 769)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(173, 69)
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'PanelFormularios
        '
        Me.PanelFormularios.AutoSize = True
        Me.PanelFormularios.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.PanelFormularios.Controls.Add(Me.PictureBox1)
        Me.PanelFormularios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelFormularios.Location = New System.Drawing.Point(181, 44)
        Me.PanelFormularios.Margin = New System.Windows.Forms.Padding(2)
        Me.PanelFormularios.Name = "PanelFormularios"
        Me.PanelFormularios.Size = New System.Drawing.Size(795, 596)
        Me.PanelFormularios.TabIndex = 4
        '
        'PanelSuperior
        '
        Me.PanelSuperior.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.PanelSuperior.Controls.Add(Me.Label2)
        Me.PanelSuperior.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelSuperior.Location = New System.Drawing.Point(0, 0)
        Me.PanelSuperior.Margin = New System.Windows.Forms.Padding(2)
        Me.PanelSuperior.Name = "PanelSuperior"
        Me.PanelSuperior.Size = New System.Drawing.Size(976, 44)
        Me.PanelSuperior.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(247, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(492, 40)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Sistema de votacion Electronica"
        '
        'AdministradorVotaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(976, 640)
        Me.Controls.Add(Me.PanelFormularios)
        Me.Controls.Add(Me.PanelMenu)
        Me.Controls.Add(Me.PanelSuperior)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "AdministradorVotaciones"
        Me.Opacity = 0.9R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AdministradorVotaciones"
        Me.PanelMenu.ResumeLayout(False)
        Me.PanelSubMenuCandidatos.ResumeLayout(False)
        Me.PanelAjustes.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelFormularios.ResumeLayout(False)
        Me.PanelSuperior.ResumeLayout(False)
        Me.PanelSuperior.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PanelMenu As FlowLayoutPanel
    Friend WithEvents btnAlcaldes As Button
    Friend WithEvents btnDiputados As Button
    Friend WithEvents btnPresidentes As Button
    Friend WithEvents PanelFormularios As Panel
    Friend WithEvents btnVotantes As Button
    Friend WithEvents btnAgregarImagenCandidatos As Button
    Friend WithEvents btnVotacionExterna As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnRegresar As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BtnAlmacenamiento As Button
    Friend WithEvents PanelSubMenuCandidatos As Panel
    Friend WithEvents BtnAjustes As Button
    Friend WithEvents PanelAjustes As Panel
    Friend WithEvents btnReiniciarVotacion As Button
    Friend WithEvents PanelSuperior As Panel
    Friend WithEvents Label2 As Label
End Class
