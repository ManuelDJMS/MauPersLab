<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmSolicitudes
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GunaElipse1 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.GunaPanel1 = New Guna.UI.WinForms.GunaPanel()
        Me.GunaVSeparator2 = New Guna.UI.WinForms.GunaVSeparator()
        Me.lbInicio = New Guna.UI.WinForms.GunaLabel()
        Me.GunaPictureBox1 = New Guna.UI.WinForms.GunaPictureBox()
        Me.GunaVSeparator1 = New Guna.UI.WinForms.GunaVSeparator()
        Me.btnCerrar = New Guna.UI.WinForms.GunaImageButton()
        Me.btnMinimizar = New Guna.UI.WinForms.GunaImageButton()
        Me.GunaImageButton1 = New Guna.UI.WinForms.GunaImageButton()
        Me.GunaLabel4 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaSeparator1 = New Guna.UI.WinForms.GunaSeparator()
        Me.GunaLabel5 = New Guna.UI.WinForms.GunaLabel()
        Me.txtNombre = New Guna.UI.WinForms.GunaTextBox()
        Me.txtMedico = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaSeparator2 = New Guna.UI.WinForms.GunaSeparator()
        Me.GunaLabel3 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel6 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaElipsePanel1 = New Guna.UI.WinForms.GunaElipsePanel()
        Me.PanelSeccion2 = New System.Windows.Forms.Panel()
        Me.GunaButton6 = New Guna.UI.WinForms.GunaButton()
        Me.GunaButton7 = New Guna.UI.WinForms.GunaButton()
        Me.PanelSeccion1 = New System.Windows.Forms.Panel()
        Me.PanelQuimicaClinica = New System.Windows.Forms.Panel()
        Me.GunaCheckBox6 = New Guna.UI.WinForms.GunaCheckBox()
        Me.GunaCheckBox7 = New Guna.UI.WinForms.GunaCheckBox()
        Me.GunaCheckBox8 = New Guna.UI.WinForms.GunaCheckBox()
        Me.GunaCheckBox9 = New Guna.UI.WinForms.GunaCheckBox()
        Me.GunaCheckBox10 = New Guna.UI.WinForms.GunaCheckBox()
        Me.GunaButton2 = New Guna.UI.WinForms.GunaButton()
        Me.PanelQuimicaSan = New System.Windows.Forms.Panel()
        Me.GunaCheckBox5 = New Guna.UI.WinForms.GunaCheckBox()
        Me.GunaCheckBox4 = New Guna.UI.WinForms.GunaCheckBox()
        Me.GunaCheckBox3 = New Guna.UI.WinForms.GunaCheckBox()
        Me.GunaCheckBox2 = New Guna.UI.WinForms.GunaCheckBox()
        Me.GunaCheckBox1 = New Guna.UI.WinForms.GunaCheckBox()
        Me.GunaButton1 = New Guna.UI.WinForms.GunaButton()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GunaTextBox1 = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.dgEstudios = New Guna.UI.WinForms.GunaDataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GunaButton10 = New Guna.UI.WinForms.GunaButton()
        Me.GunaButton3 = New Guna.UI.WinForms.GunaButton()
        Me.btnPacientes = New Guna.UI.WinForms.GunaButton()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.GunaPanel1.SuspendLayout()
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GunaElipsePanel1.SuspendLayout()
        Me.PanelSeccion2.SuspendLayout()
        Me.PanelSeccion1.SuspendLayout()
        Me.PanelQuimicaClinica.SuspendLayout()
        Me.PanelQuimicaSan.SuspendLayout()
        CType(Me.dgEstudios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GunaElipse1
        '
        Me.GunaElipse1.TargetControl = Me
        '
        'GunaPanel1
        '
        Me.GunaPanel1.BackColor = System.Drawing.Color.White
        Me.GunaPanel1.Controls.Add(Me.GunaVSeparator2)
        Me.GunaPanel1.Controls.Add(Me.lbInicio)
        Me.GunaPanel1.Controls.Add(Me.GunaPictureBox1)
        Me.GunaPanel1.Controls.Add(Me.GunaVSeparator1)
        Me.GunaPanel1.Controls.Add(Me.btnCerrar)
        Me.GunaPanel1.Controls.Add(Me.btnMinimizar)
        Me.GunaPanel1.Controls.Add(Me.GunaImageButton1)
        Me.GunaPanel1.Location = New System.Drawing.Point(0, 0)
        Me.GunaPanel1.Name = "GunaPanel1"
        Me.GunaPanel1.Size = New System.Drawing.Size(666, 50)
        Me.GunaPanel1.TabIndex = 1
        '
        'GunaVSeparator2
        '
        Me.GunaVSeparator2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.GunaVSeparator2.LineColor = System.Drawing.Color.WhiteSmoke
        Me.GunaVSeparator2.Location = New System.Drawing.Point(434, 12)
        Me.GunaVSeparator2.Name = "GunaVSeparator2"
        Me.GunaVSeparator2.Size = New System.Drawing.Size(10, 25)
        Me.GunaVSeparator2.TabIndex = 6
        '
        'lbInicio
        '
        Me.lbInicio.AutoSize = True
        Me.lbInicio.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbInicio.Location = New System.Drawing.Point(501, 15)
        Me.lbInicio.Name = "lbInicio"
        Me.lbInicio.Size = New System.Drawing.Size(65, 20)
        Me.lbInicio.TabIndex = 5
        Me.lbInicio.Text = "Manuel"
        '
        'GunaPictureBox1
        '
        Me.GunaPictureBox1.BaseColor = System.Drawing.Color.White
        Me.GunaPictureBox1.Image = Global.Maulabs.My.Resources.Resources.icons8_verified_account_28
        Me.GunaPictureBox1.Location = New System.Drawing.Point(460, 8)
        Me.GunaPictureBox1.Name = "GunaPictureBox1"
        Me.GunaPictureBox1.Size = New System.Drawing.Size(32, 32)
        Me.GunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.GunaPictureBox1.TabIndex = 4
        Me.GunaPictureBox1.TabStop = False
        '
        'GunaVSeparator1
        '
        Me.GunaVSeparator1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.GunaVSeparator1.LineColor = System.Drawing.Color.WhiteSmoke
        Me.GunaVSeparator1.Location = New System.Drawing.Point(580, 12)
        Me.GunaVSeparator1.Name = "GunaVSeparator1"
        Me.GunaVSeparator1.Size = New System.Drawing.Size(10, 25)
        Me.GunaVSeparator1.TabIndex = 3
        '
        'btnCerrar
        '
        Me.btnCerrar.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnCerrar.Image = Global.Maulabs.My.Resources.Resources.icons8_multiply_48
        Me.btnCerrar.ImageSize = New System.Drawing.Size(16, 16)
        Me.btnCerrar.Location = New System.Drawing.Point(629, 8)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.OnHoverImage = Nothing
        Me.btnCerrar.OnHoverImageOffset = New System.Drawing.Point(0, -1)
        Me.btnCerrar.Size = New System.Drawing.Size(32, 32)
        Me.btnCerrar.TabIndex = 2
        '
        'btnMinimizar
        '
        Me.btnMinimizar.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnMinimizar.Image = Global.Maulabs.My.Resources.Resources.icons8_horizontal_line_48
        Me.btnMinimizar.ImageSize = New System.Drawing.Size(16, 16)
        Me.btnMinimizar.Location = New System.Drawing.Point(591, 8)
        Me.btnMinimizar.Name = "btnMinimizar"
        Me.btnMinimizar.OnHoverImage = Nothing
        Me.btnMinimizar.OnHoverImageOffset = New System.Drawing.Point(0, -1)
        Me.btnMinimizar.Size = New System.Drawing.Size(32, 32)
        Me.btnMinimizar.TabIndex = 1
        '
        'GunaImageButton1
        '
        Me.GunaImageButton1.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaImageButton1.Image = Global.Maulabs.My.Resources.Resources.icons8_menu_48
        Me.GunaImageButton1.ImageSize = New System.Drawing.Size(16, 16)
        Me.GunaImageButton1.Location = New System.Drawing.Point(8, 8)
        Me.GunaImageButton1.Name = "GunaImageButton1"
        Me.GunaImageButton1.OnHoverImage = Nothing
        Me.GunaImageButton1.OnHoverImageOffset = New System.Drawing.Point(0, -1)
        Me.GunaImageButton1.Size = New System.Drawing.Size(32, 32)
        Me.GunaImageButton1.TabIndex = 0
        '
        'GunaLabel4
        '
        Me.GunaLabel4.AutoSize = True
        Me.GunaLabel4.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel4.Location = New System.Drawing.Point(46, 126)
        Me.GunaLabel4.Name = "GunaLabel4"
        Me.GunaLabel4.Size = New System.Drawing.Size(60, 17)
        Me.GunaLabel4.TabIndex = 39
        Me.GunaLabel4.Text = "Nombre:"
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoSize = True
        Me.GunaLabel2.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel2.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel2.Location = New System.Drawing.Point(54, 64)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(260, 32)
        Me.GunaLabel2.TabIndex = 50
        Me.GunaLabel2.Text = "Selección de Estudios"
        '
        'GunaSeparator1
        '
        Me.GunaSeparator1.LineColor = System.Drawing.Color.Silver
        Me.GunaSeparator1.Location = New System.Drawing.Point(54, 84)
        Me.GunaSeparator1.Name = "GunaSeparator1"
        Me.GunaSeparator1.Size = New System.Drawing.Size(588, 32)
        Me.GunaSeparator1.TabIndex = 51
        '
        'GunaLabel5
        '
        Me.GunaLabel5.AutoSize = True
        Me.GunaLabel5.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel5.Location = New System.Drawing.Point(51, 158)
        Me.GunaLabel5.Name = "GunaLabel5"
        Me.GunaLabel5.Size = New System.Drawing.Size(55, 17)
        Me.GunaLabel5.TabIndex = 54
        Me.GunaLabel5.Text = "Médico:"
        '
        'txtNombre
        '
        Me.txtNombre.BaseColor = System.Drawing.Color.White
        Me.txtNombre.BorderColor = System.Drawing.Color.Silver
        Me.txtNombre.BorderSize = 1
        Me.txtNombre.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNombre.FocusedBaseColor = System.Drawing.Color.White
        Me.txtNombre.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtNombre.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtNombre.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtNombre.Location = New System.Drawing.Point(112, 122)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNombre.Size = New System.Drawing.Size(420, 26)
        Me.txtNombre.TabIndex = 55
        '
        'txtMedico
        '
        Me.txtMedico.BaseColor = System.Drawing.Color.White
        Me.txtMedico.BorderColor = System.Drawing.Color.Silver
        Me.txtMedico.BorderSize = 1
        Me.txtMedico.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtMedico.FocusedBaseColor = System.Drawing.Color.White
        Me.txtMedico.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtMedico.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtMedico.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtMedico.Location = New System.Drawing.Point(112, 154)
        Me.txtMedico.Name = "txtMedico"
        Me.txtMedico.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtMedico.Size = New System.Drawing.Size(420, 26)
        Me.txtMedico.TabIndex = 56
        '
        'GunaSeparator2
        '
        Me.GunaSeparator2.LineColor = System.Drawing.Color.Silver
        Me.GunaSeparator2.Location = New System.Drawing.Point(12, 183)
        Me.GunaSeparator2.Name = "GunaSeparator2"
        Me.GunaSeparator2.Size = New System.Drawing.Size(630, 32)
        Me.GunaSeparator2.TabIndex = 57
        '
        'GunaLabel3
        '
        Me.GunaLabel3.AutoSize = True
        Me.GunaLabel3.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel3.Location = New System.Drawing.Point(549, 126)
        Me.GunaLabel3.Name = "GunaLabel3"
        Me.GunaLabel3.Size = New System.Drawing.Size(44, 17)
        Me.GunaLabel3.TabIndex = 59
        Me.GunaLabel3.Text = "Fecha:"
        '
        'GunaLabel6
        '
        Me.GunaLabel6.AutoSize = True
        Me.GunaLabel6.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel6.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel6.Location = New System.Drawing.Point(598, 125)
        Me.GunaLabel6.Name = "GunaLabel6"
        Me.GunaLabel6.Size = New System.Drawing.Size(44, 17)
        Me.GunaLabel6.TabIndex = 60
        Me.GunaLabel6.Text = "Fecha:"
        '
        'GunaElipsePanel1
        '
        Me.GunaElipsePanel1.BackColor = System.Drawing.Color.Transparent
        Me.GunaElipsePanel1.BaseColor = System.Drawing.Color.White
        Me.GunaElipsePanel1.Controls.Add(Me.PanelSeccion2)
        Me.GunaElipsePanel1.Controls.Add(Me.PanelSeccion1)
        Me.GunaElipsePanel1.Location = New System.Drawing.Point(12, 221)
        Me.GunaElipsePanel1.Name = "GunaElipsePanel1"
        Me.GunaElipsePanel1.Size = New System.Drawing.Size(422, 224)
        Me.GunaElipsePanel1.TabIndex = 61
        '
        'PanelSeccion2
        '
        Me.PanelSeccion2.Controls.Add(Me.GunaButton6)
        Me.PanelSeccion2.Controls.Add(Me.GunaButton7)
        Me.PanelSeccion2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelSeccion2.Location = New System.Drawing.Point(210, 0)
        Me.PanelSeccion2.Name = "PanelSeccion2"
        Me.PanelSeccion2.Size = New System.Drawing.Size(212, 224)
        Me.PanelSeccion2.TabIndex = 2
        '
        'GunaButton6
        '
        Me.GunaButton6.AnimationHoverSpeed = 0.07!
        Me.GunaButton6.AnimationSpeed = 0.03!
        Me.GunaButton6.BackColor = System.Drawing.Color.Transparent
        Me.GunaButton6.BaseColor = System.Drawing.Color.White
        Me.GunaButton6.BorderColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.GunaButton6.BorderSize = 1
        Me.GunaButton6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.GunaButton6.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaButton6.Dock = System.Windows.Forms.DockStyle.Top
        Me.GunaButton6.FocusedColor = System.Drawing.Color.Empty
        Me.GunaButton6.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaButton6.ForeColor = System.Drawing.Color.Black
        Me.GunaButton6.Image = Nothing
        Me.GunaButton6.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaButton6.Location = New System.Drawing.Point(0, 50)
        Me.GunaButton6.Name = "GunaButton6"
        Me.GunaButton6.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.GunaButton6.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaButton6.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButton6.OnHoverImage = Nothing
        Me.GunaButton6.OnPressedColor = System.Drawing.Color.Black
        Me.GunaButton6.Radius = 3
        Me.GunaButton6.Size = New System.Drawing.Size(212, 50)
        Me.GunaButton6.TabIndex = 12
        Me.GunaButton6.Text = "Abrir"
        Me.GunaButton6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaButton7
        '
        Me.GunaButton7.AnimationHoverSpeed = 0.07!
        Me.GunaButton7.AnimationSpeed = 0.03!
        Me.GunaButton7.BackColor = System.Drawing.Color.Transparent
        Me.GunaButton7.BaseColor = System.Drawing.Color.White
        Me.GunaButton7.BorderColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.GunaButton7.BorderSize = 1
        Me.GunaButton7.Cursor = System.Windows.Forms.Cursors.Hand
        Me.GunaButton7.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaButton7.Dock = System.Windows.Forms.DockStyle.Top
        Me.GunaButton7.FocusedColor = System.Drawing.Color.Empty
        Me.GunaButton7.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaButton7.ForeColor = System.Drawing.Color.Black
        Me.GunaButton7.Image = Nothing
        Me.GunaButton7.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaButton7.Location = New System.Drawing.Point(0, 0)
        Me.GunaButton7.Name = "GunaButton7"
        Me.GunaButton7.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.GunaButton7.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaButton7.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButton7.OnHoverImage = Nothing
        Me.GunaButton7.OnPressedColor = System.Drawing.Color.Black
        Me.GunaButton7.Radius = 3
        Me.GunaButton7.Size = New System.Drawing.Size(212, 50)
        Me.GunaButton7.TabIndex = 11
        Me.GunaButton7.Text = "Abrir"
        Me.GunaButton7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PanelSeccion1
        '
        Me.PanelSeccion1.AutoScroll = True
        Me.PanelSeccion1.BackColor = System.Drawing.Color.White
        Me.PanelSeccion1.Controls.Add(Me.PanelQuimicaClinica)
        Me.PanelSeccion1.Controls.Add(Me.PanelQuimicaSan)
        Me.PanelSeccion1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelSeccion1.Location = New System.Drawing.Point(0, 0)
        Me.PanelSeccion1.Name = "PanelSeccion1"
        Me.PanelSeccion1.Size = New System.Drawing.Size(210, 224)
        Me.PanelSeccion1.TabIndex = 0
        '
        'PanelQuimicaClinica
        '
        Me.PanelQuimicaClinica.Controls.Add(Me.GunaCheckBox6)
        Me.PanelQuimicaClinica.Controls.Add(Me.GunaCheckBox7)
        Me.PanelQuimicaClinica.Controls.Add(Me.GunaCheckBox8)
        Me.PanelQuimicaClinica.Controls.Add(Me.GunaCheckBox9)
        Me.PanelQuimicaClinica.Controls.Add(Me.GunaCheckBox10)
        Me.PanelQuimicaClinica.Controls.Add(Me.GunaButton2)
        Me.PanelQuimicaClinica.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelQuimicaClinica.Location = New System.Drawing.Point(0, 153)
        Me.PanelQuimicaClinica.MaximumSize = New System.Drawing.Size(210, 269)
        Me.PanelQuimicaClinica.MinimumSize = New System.Drawing.Size(210, 50)
        Me.PanelQuimicaClinica.Name = "PanelQuimicaClinica"
        Me.PanelQuimicaClinica.Size = New System.Drawing.Size(210, 50)
        Me.PanelQuimicaClinica.TabIndex = 15
        '
        'GunaCheckBox6
        '
        Me.GunaCheckBox6.BaseColor = System.Drawing.Color.White
        Me.GunaCheckBox6.CheckedOffColor = System.Drawing.Color.Gray
        Me.GunaCheckBox6.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaCheckBox6.Dock = System.Windows.Forms.DockStyle.Top
        Me.GunaCheckBox6.FillColor = System.Drawing.Color.White
        Me.GunaCheckBox6.Location = New System.Drawing.Point(0, 130)
        Me.GunaCheckBox6.Name = "GunaCheckBox6"
        Me.GunaCheckBox6.Size = New System.Drawing.Size(115, 20)
        Me.GunaCheckBox6.TabIndex = 18
        Me.GunaCheckBox6.Text = "GunaCheckBox6"
        '
        'GunaCheckBox7
        '
        Me.GunaCheckBox7.BaseColor = System.Drawing.Color.White
        Me.GunaCheckBox7.CheckedOffColor = System.Drawing.Color.Gray
        Me.GunaCheckBox7.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaCheckBox7.Dock = System.Windows.Forms.DockStyle.Top
        Me.GunaCheckBox7.FillColor = System.Drawing.Color.White
        Me.GunaCheckBox7.Location = New System.Drawing.Point(0, 110)
        Me.GunaCheckBox7.Name = "GunaCheckBox7"
        Me.GunaCheckBox7.Size = New System.Drawing.Size(115, 20)
        Me.GunaCheckBox7.TabIndex = 17
        Me.GunaCheckBox7.Text = "GunaCheckBox7"
        '
        'GunaCheckBox8
        '
        Me.GunaCheckBox8.BaseColor = System.Drawing.Color.White
        Me.GunaCheckBox8.CheckedOffColor = System.Drawing.Color.Gray
        Me.GunaCheckBox8.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaCheckBox8.Dock = System.Windows.Forms.DockStyle.Top
        Me.GunaCheckBox8.FillColor = System.Drawing.Color.White
        Me.GunaCheckBox8.Location = New System.Drawing.Point(0, 90)
        Me.GunaCheckBox8.Name = "GunaCheckBox8"
        Me.GunaCheckBox8.Size = New System.Drawing.Size(115, 20)
        Me.GunaCheckBox8.TabIndex = 16
        Me.GunaCheckBox8.Text = "GunaCheckBox8"
        '
        'GunaCheckBox9
        '
        Me.GunaCheckBox9.BaseColor = System.Drawing.Color.White
        Me.GunaCheckBox9.CheckedOffColor = System.Drawing.Color.Gray
        Me.GunaCheckBox9.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaCheckBox9.Dock = System.Windows.Forms.DockStyle.Top
        Me.GunaCheckBox9.FillColor = System.Drawing.Color.White
        Me.GunaCheckBox9.Location = New System.Drawing.Point(0, 70)
        Me.GunaCheckBox9.Name = "GunaCheckBox9"
        Me.GunaCheckBox9.Size = New System.Drawing.Size(71, 20)
        Me.GunaCheckBox9.TabIndex = 15
        Me.GunaCheckBox9.Text = "Glucosa"
        '
        'GunaCheckBox10
        '
        Me.GunaCheckBox10.BaseColor = System.Drawing.Color.White
        Me.GunaCheckBox10.CheckedOffColor = System.Drawing.Color.Gray
        Me.GunaCheckBox10.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaCheckBox10.Dock = System.Windows.Forms.DockStyle.Top
        Me.GunaCheckBox10.FillColor = System.Drawing.Color.White
        Me.GunaCheckBox10.Location = New System.Drawing.Point(0, 50)
        Me.GunaCheckBox10.Name = "GunaCheckBox10"
        Me.GunaCheckBox10.Radius = 3
        Me.GunaCheckBox10.Size = New System.Drawing.Size(80, 20)
        Me.GunaCheckBox10.TabIndex = 14
        Me.GunaCheckBox10.Text = "Bilirrubina"
        '
        'GunaButton2
        '
        Me.GunaButton2.AnimationHoverSpeed = 0.07!
        Me.GunaButton2.AnimationSpeed = 0.03!
        Me.GunaButton2.BackColor = System.Drawing.Color.Transparent
        Me.GunaButton2.BaseColor = System.Drawing.Color.White
        Me.GunaButton2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(175, Byte), Integer))
        Me.GunaButton2.BorderSize = 1
        Me.GunaButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.GunaButton2.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaButton2.Dock = System.Windows.Forms.DockStyle.Top
        Me.GunaButton2.FocusedColor = System.Drawing.Color.Empty
        Me.GunaButton2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaButton2.ForeColor = System.Drawing.Color.Black
        Me.GunaButton2.Image = Nothing
        Me.GunaButton2.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaButton2.Location = New System.Drawing.Point(0, 0)
        Me.GunaButton2.Name = "GunaButton2"
        Me.GunaButton2.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.GunaButton2.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaButton2.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButton2.OnHoverImage = Nothing
        Me.GunaButton2.OnPressedColor = System.Drawing.Color.Black
        Me.GunaButton2.Radius = 3
        Me.GunaButton2.Size = New System.Drawing.Size(210, 50)
        Me.GunaButton2.TabIndex = 7
        Me.GunaButton2.Text = "Química Clínica"
        Me.GunaButton2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PanelQuimicaSan
        '
        Me.PanelQuimicaSan.Controls.Add(Me.GunaCheckBox5)
        Me.PanelQuimicaSan.Controls.Add(Me.GunaCheckBox4)
        Me.PanelQuimicaSan.Controls.Add(Me.GunaCheckBox3)
        Me.PanelQuimicaSan.Controls.Add(Me.GunaCheckBox2)
        Me.PanelQuimicaSan.Controls.Add(Me.GunaCheckBox1)
        Me.PanelQuimicaSan.Controls.Add(Me.GunaButton1)
        Me.PanelQuimicaSan.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelQuimicaSan.Location = New System.Drawing.Point(0, 0)
        Me.PanelQuimicaSan.MaximumSize = New System.Drawing.Size(210, 269)
        Me.PanelQuimicaSan.MinimumSize = New System.Drawing.Size(210, 50)
        Me.PanelQuimicaSan.Name = "PanelQuimicaSan"
        Me.PanelQuimicaSan.Size = New System.Drawing.Size(210, 153)
        Me.PanelQuimicaSan.TabIndex = 14
        '
        'GunaCheckBox5
        '
        Me.GunaCheckBox5.BaseColor = System.Drawing.Color.White
        Me.GunaCheckBox5.CheckedOffColor = System.Drawing.Color.Gray
        Me.GunaCheckBox5.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaCheckBox5.Dock = System.Windows.Forms.DockStyle.Top
        Me.GunaCheckBox5.FillColor = System.Drawing.Color.White
        Me.GunaCheckBox5.Location = New System.Drawing.Point(0, 130)
        Me.GunaCheckBox5.Name = "GunaCheckBox5"
        Me.GunaCheckBox5.Size = New System.Drawing.Size(115, 20)
        Me.GunaCheckBox5.TabIndex = 18
        Me.GunaCheckBox5.Text = "GunaCheckBox5"
        '
        'GunaCheckBox4
        '
        Me.GunaCheckBox4.BaseColor = System.Drawing.Color.White
        Me.GunaCheckBox4.CheckedOffColor = System.Drawing.Color.Gray
        Me.GunaCheckBox4.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaCheckBox4.Dock = System.Windows.Forms.DockStyle.Top
        Me.GunaCheckBox4.FillColor = System.Drawing.Color.White
        Me.GunaCheckBox4.Location = New System.Drawing.Point(0, 110)
        Me.GunaCheckBox4.Name = "GunaCheckBox4"
        Me.GunaCheckBox4.Size = New System.Drawing.Size(115, 20)
        Me.GunaCheckBox4.TabIndex = 17
        Me.GunaCheckBox4.Text = "GunaCheckBox4"
        '
        'GunaCheckBox3
        '
        Me.GunaCheckBox3.BaseColor = System.Drawing.Color.White
        Me.GunaCheckBox3.CheckedOffColor = System.Drawing.Color.Gray
        Me.GunaCheckBox3.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaCheckBox3.Dock = System.Windows.Forms.DockStyle.Top
        Me.GunaCheckBox3.FillColor = System.Drawing.Color.White
        Me.GunaCheckBox3.Location = New System.Drawing.Point(0, 90)
        Me.GunaCheckBox3.Name = "GunaCheckBox3"
        Me.GunaCheckBox3.Size = New System.Drawing.Size(115, 20)
        Me.GunaCheckBox3.TabIndex = 16
        Me.GunaCheckBox3.Text = "GunaCheckBox3"
        '
        'GunaCheckBox2
        '
        Me.GunaCheckBox2.BaseColor = System.Drawing.Color.White
        Me.GunaCheckBox2.CheckedOffColor = System.Drawing.Color.Gray
        Me.GunaCheckBox2.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaCheckBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.GunaCheckBox2.FillColor = System.Drawing.Color.White
        Me.GunaCheckBox2.Location = New System.Drawing.Point(0, 70)
        Me.GunaCheckBox2.Name = "GunaCheckBox2"
        Me.GunaCheckBox2.Size = New System.Drawing.Size(71, 20)
        Me.GunaCheckBox2.TabIndex = 15
        Me.GunaCheckBox2.Text = "Glucosa"
        '
        'GunaCheckBox1
        '
        Me.GunaCheckBox1.BaseColor = System.Drawing.Color.White
        Me.GunaCheckBox1.CheckedOffColor = System.Drawing.Color.Gray
        Me.GunaCheckBox1.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaCheckBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GunaCheckBox1.FillColor = System.Drawing.Color.White
        Me.GunaCheckBox1.Location = New System.Drawing.Point(0, 50)
        Me.GunaCheckBox1.Name = "GunaCheckBox1"
        Me.GunaCheckBox1.Radius = 3
        Me.GunaCheckBox1.Size = New System.Drawing.Size(80, 20)
        Me.GunaCheckBox1.TabIndex = 14
        Me.GunaCheckBox1.Text = "Bilirrubina"
        '
        'GunaButton1
        '
        Me.GunaButton1.AnimationHoverSpeed = 0.07!
        Me.GunaButton1.AnimationSpeed = 0.03!
        Me.GunaButton1.BackColor = System.Drawing.Color.Transparent
        Me.GunaButton1.BaseColor = System.Drawing.Color.White
        Me.GunaButton1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(175, Byte), Integer))
        Me.GunaButton1.BorderSize = 1
        Me.GunaButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.GunaButton1.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaButton1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GunaButton1.FocusedColor = System.Drawing.Color.Empty
        Me.GunaButton1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaButton1.ForeColor = System.Drawing.Color.Black
        Me.GunaButton1.Image = Nothing
        Me.GunaButton1.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaButton1.Location = New System.Drawing.Point(0, 0)
        Me.GunaButton1.Name = "GunaButton1"
        Me.GunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.GunaButton1.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaButton1.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButton1.OnHoverImage = Nothing
        Me.GunaButton1.OnPressedColor = System.Drawing.Color.Black
        Me.GunaButton1.Radius = 3
        Me.GunaButton1.Size = New System.Drawing.Size(210, 50)
        Me.GunaButton1.TabIndex = 7
        Me.GunaButton1.Text = "Química Sanguinea"
        Me.GunaButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Timer1
        '
        Me.Timer1.Interval = 10
        '
        'GunaTextBox1
        '
        Me.GunaTextBox1.BaseColor = System.Drawing.Color.White
        Me.GunaTextBox1.BorderColor = System.Drawing.Color.Silver
        Me.GunaTextBox1.BorderSize = 1
        Me.GunaTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.GunaTextBox1.FocusedBaseColor = System.Drawing.Color.White
        Me.GunaTextBox1.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GunaTextBox1.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.GunaTextBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaTextBox1.Location = New System.Drawing.Point(561, 451)
        Me.GunaTextBox1.Name = "GunaTextBox1"
        Me.GunaTextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.GunaTextBox1.Size = New System.Drawing.Size(93, 26)
        Me.GunaTextBox1.TabIndex = 278
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel1.Location = New System.Drawing.Point(516, 457)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(39, 17)
        Me.GunaLabel1.TabIndex = 279
        Me.GunaLabel1.Text = "Total:"
        '
        'dgEstudios
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.dgEstudios.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgEstudios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgEstudios.BackgroundColor = System.Drawing.Color.White
        Me.dgEstudios.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgEstudios.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgEstudios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(175, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgEstudios.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgEstudios.ColumnHeadersHeight = 21
        Me.dgEstudios.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgEstudios.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgEstudios.EnableHeadersVisualStyles = False
        Me.dgEstudios.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgEstudios.Location = New System.Drawing.Point(440, 221)
        Me.dgEstudios.Name = "dgEstudios"
        Me.dgEstudios.RowHeadersVisible = False
        Me.dgEstudios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgEstudios.Size = New System.Drawing.Size(214, 223)
        Me.dgEstudios.TabIndex = 280
        Me.dgEstudios.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna
        Me.dgEstudios.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgEstudios.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgEstudios.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgEstudios.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgEstudios.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgEstudios.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.dgEstudios.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgEstudios.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgEstudios.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgEstudios.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.dgEstudios.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgEstudios.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgEstudios.ThemeStyle.HeaderStyle.Height = 21
        Me.dgEstudios.ThemeStyle.ReadOnly = False
        Me.dgEstudios.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgEstudios.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgEstudios.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.dgEstudios.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dgEstudios.ThemeStyle.RowsStyle.Height = 22
        Me.dgEstudios.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgEstudios.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'Column1
        '
        Me.Column1.HeaderText = "Estudios Seleccionados"
        Me.Column1.Name = "Column1"
        '
        'GunaButton10
        '
        Me.GunaButton10.AnimationHoverSpeed = 0.07!
        Me.GunaButton10.AnimationSpeed = 0.03!
        Me.GunaButton10.BackColor = System.Drawing.Color.Transparent
        Me.GunaButton10.BaseColor = System.Drawing.Color.Navy
        Me.GunaButton10.BorderColor = System.Drawing.Color.Black
        Me.GunaButton10.Cursor = System.Windows.Forms.Cursors.Hand
        Me.GunaButton10.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaButton10.FocusedColor = System.Drawing.Color.Empty
        Me.GunaButton10.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GunaButton10.ForeColor = System.Drawing.Color.White
        Me.GunaButton10.Image = Global.Maulabs.My.Resources.Resources.icons8_cash_24
        Me.GunaButton10.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaButton10.Location = New System.Drawing.Point(283, 457)
        Me.GunaButton10.Name = "GunaButton10"
        Me.GunaButton10.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GunaButton10.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaButton10.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButton10.OnHoverImage = Nothing
        Me.GunaButton10.OnPressedColor = System.Drawing.Color.Black
        Me.GunaButton10.Radius = 3
        Me.GunaButton10.Size = New System.Drawing.Size(111, 42)
        Me.GunaButton10.TabIndex = 72
        Me.GunaButton10.Text = "Cobrar"
        '
        'GunaButton3
        '
        Me.GunaButton3.AnimationHoverSpeed = 0.07!
        Me.GunaButton3.AnimationSpeed = 0.03!
        Me.GunaButton3.BackColor = System.Drawing.Color.Transparent
        Me.GunaButton3.BaseColor = System.Drawing.Color.Firebrick
        Me.GunaButton3.BorderColor = System.Drawing.Color.Black
        Me.GunaButton3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.GunaButton3.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaButton3.FocusedColor = System.Drawing.Color.Empty
        Me.GunaButton3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GunaButton3.ForeColor = System.Drawing.Color.White
        Me.GunaButton3.Image = Global.Maulabs.My.Resources.Resources.icons8_cancel_28
        Me.GunaButton3.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaButton3.Location = New System.Drawing.Point(49, 457)
        Me.GunaButton3.Name = "GunaButton3"
        Me.GunaButton3.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GunaButton3.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaButton3.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButton3.OnHoverImage = Nothing
        Me.GunaButton3.OnPressedColor = System.Drawing.Color.Black
        Me.GunaButton3.Radius = 3
        Me.GunaButton3.Size = New System.Drawing.Size(111, 42)
        Me.GunaButton3.TabIndex = 71
        Me.GunaButton3.Text = "Cancelar"
        '
        'btnPacientes
        '
        Me.btnPacientes.AnimationHoverSpeed = 0.07!
        Me.btnPacientes.AnimationSpeed = 0.03!
        Me.btnPacientes.BackColor = System.Drawing.Color.Transparent
        Me.btnPacientes.BaseColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.btnPacientes.BorderColor = System.Drawing.Color.Black
        Me.btnPacientes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPacientes.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnPacientes.FocusedColor = System.Drawing.Color.Empty
        Me.btnPacientes.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnPacientes.ForeColor = System.Drawing.Color.White
        Me.btnPacientes.Image = Global.Maulabs.My.Resources.Resources.icons8_save_28
        Me.btnPacientes.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnPacientes.Location = New System.Drawing.Point(166, 457)
        Me.btnPacientes.Name = "btnPacientes"
        Me.btnPacientes.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnPacientes.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnPacientes.OnHoverForeColor = System.Drawing.Color.White
        Me.btnPacientes.OnHoverImage = Nothing
        Me.btnPacientes.OnPressedColor = System.Drawing.Color.Black
        Me.btnPacientes.Radius = 3
        Me.btnPacientes.Size = New System.Drawing.Size(111, 42)
        Me.btnPacientes.TabIndex = 70
        Me.btnPacientes.Text = "Guardar"
        '
        'PictureBox8
        '
        Me.PictureBox8.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox8.Image = Global.Maulabs.My.Resources.Resources.icons8_caduceus_48
        Me.PictureBox8.Location = New System.Drawing.Point(4, 60)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(54, 52)
        Me.PictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox8.TabIndex = 52
        Me.PictureBox8.TabStop = False
        '
        'FrmSolicitudes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(670, 512)
        Me.Controls.Add(Me.dgEstudios)
        Me.Controls.Add(Me.GunaLabel1)
        Me.Controls.Add(Me.GunaTextBox1)
        Me.Controls.Add(Me.GunaButton10)
        Me.Controls.Add(Me.GunaButton3)
        Me.Controls.Add(Me.btnPacientes)
        Me.Controls.Add(Me.GunaElipsePanel1)
        Me.Controls.Add(Me.GunaLabel6)
        Me.Controls.Add(Me.GunaLabel3)
        Me.Controls.Add(Me.GunaSeparator2)
        Me.Controls.Add(Me.txtMedico)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.GunaLabel5)
        Me.Controls.Add(Me.PictureBox8)
        Me.Controls.Add(Me.GunaLabel2)
        Me.Controls.Add(Me.GunaSeparator1)
        Me.Controls.Add(Me.GunaLabel4)
        Me.Controls.Add(Me.GunaPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmSolicitudes"
        Me.Text = "FrmSolicitudes"
        Me.GunaPanel1.ResumeLayout(False)
        Me.GunaPanel1.PerformLayout()
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GunaElipsePanel1.ResumeLayout(False)
        Me.PanelSeccion2.ResumeLayout(False)
        Me.PanelSeccion1.ResumeLayout(False)
        Me.PanelQuimicaClinica.ResumeLayout(False)
        Me.PanelQuimicaClinica.PerformLayout()
        Me.PanelQuimicaSan.ResumeLayout(False)
        Me.PanelQuimicaSan.PerformLayout()
        CType(Me.dgEstudios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GunaElipse1 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents GunaPanel1 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents GunaVSeparator2 As Guna.UI.WinForms.GunaVSeparator
    Friend WithEvents lbInicio As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaPictureBox1 As Guna.UI.WinForms.GunaPictureBox
    Friend WithEvents GunaVSeparator1 As Guna.UI.WinForms.GunaVSeparator
    Friend WithEvents btnCerrar As Guna.UI.WinForms.GunaImageButton
    Friend WithEvents btnMinimizar As Guna.UI.WinForms.GunaImageButton
    Friend WithEvents GunaImageButton1 As Guna.UI.WinForms.GunaImageButton
    Friend WithEvents GunaLabel4 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel5 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaSeparator1 As Guna.UI.WinForms.GunaSeparator
    Friend WithEvents GunaLabel6 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel3 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaSeparator2 As Guna.UI.WinForms.GunaSeparator
    Friend WithEvents txtMedico As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents txtNombre As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaElipsePanel1 As Guna.UI.WinForms.GunaElipsePanel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents PanelSeccion1 As Panel
    Friend WithEvents PanelSeccion2 As Panel
    Friend WithEvents GunaButton6 As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaButton7 As Guna.UI.WinForms.GunaButton
    Friend WithEvents PanelQuimicaSan As Panel
    Friend WithEvents GunaCheckBox5 As Guna.UI.WinForms.GunaCheckBox
    Friend WithEvents GunaCheckBox4 As Guna.UI.WinForms.GunaCheckBox
    Friend WithEvents GunaCheckBox3 As Guna.UI.WinForms.GunaCheckBox
    Friend WithEvents GunaCheckBox2 As Guna.UI.WinForms.GunaCheckBox
    Friend WithEvents GunaCheckBox1 As Guna.UI.WinForms.GunaCheckBox
    Friend WithEvents GunaButton1 As Guna.UI.WinForms.GunaButton
    Friend WithEvents PanelQuimicaClinica As Panel
    Friend WithEvents GunaCheckBox6 As Guna.UI.WinForms.GunaCheckBox
    Friend WithEvents GunaCheckBox7 As Guna.UI.WinForms.GunaCheckBox
    Friend WithEvents GunaCheckBox8 As Guna.UI.WinForms.GunaCheckBox
    Friend WithEvents GunaCheckBox9 As Guna.UI.WinForms.GunaCheckBox
    Friend WithEvents GunaCheckBox10 As Guna.UI.WinForms.GunaCheckBox
    Friend WithEvents GunaButton2 As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaButton3 As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnPacientes As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaButton10 As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaTextBox1 As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents dgEstudios As Guna.UI.WinForms.GunaDataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
End Class
