<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPagos
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
        Me.GunaElipse1 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaSeparator1 = New Guna.UI.WinForms.GunaSeparator()
        Me.GunaPanel1 = New Guna.UI.WinForms.GunaPanel()
        Me.GunaVSeparator2 = New Guna.UI.WinForms.GunaVSeparator()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaVSeparator1 = New Guna.UI.WinForms.GunaVSeparator()
        Me.GunaLabel3 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaTextBox1 = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaTextBox2 = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaLabel4 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaElipsePanel1 = New Guna.UI.WinForms.GunaElipsePanel()
        Me.GunaRadioButton2 = New Guna.UI.WinForms.GunaRadioButton()
        Me.GunaRadioButton1 = New Guna.UI.WinForms.GunaRadioButton()
        Me.GunaElipsePanel2 = New Guna.UI.WinForms.GunaElipsePanel()
        Me.GunaElipsePanel3 = New Guna.UI.WinForms.GunaElipsePanel()
        Me.GunaPanel2 = New Guna.UI.WinForms.GunaPanel()
        Me.GunaLabel5 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel6 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel7 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel8 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel9 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel10 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel11 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel13 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaTextBox3 = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaLabel12 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel14 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel15 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaButton2 = New Guna.UI.WinForms.GunaButton()
        Me.GunaButton1 = New Guna.UI.WinForms.GunaButton()
        Me.btnPacientes = New Guna.UI.WinForms.GunaButton()
        Me.btnSolicitudes = New Guna.UI.WinForms.GunaButton()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.GunaPictureBox1 = New Guna.UI.WinForms.GunaPictureBox()
        Me.btnCerrar = New Guna.UI.WinForms.GunaImageButton()
        Me.btnMinimizar = New Guna.UI.WinForms.GunaImageButton()
        Me.GunaImageButton1 = New Guna.UI.WinForms.GunaImageButton()
        Me.GunaPanel1.SuspendLayout()
        Me.GunaElipsePanel1.SuspendLayout()
        Me.GunaElipsePanel2.SuspendLayout()
        Me.GunaElipsePanel3.SuspendLayout()
        Me.GunaPanel2.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GunaElipse1
        '
        Me.GunaElipse1.TargetControl = Me
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoSize = True
        Me.GunaLabel2.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel2.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel2.Location = New System.Drawing.Point(52, 56)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(83, 32)
        Me.GunaLabel2.TabIndex = 53
        Me.GunaLabel2.Text = "Pagos"
        '
        'GunaSeparator1
        '
        Me.GunaSeparator1.LineColor = System.Drawing.Color.Silver
        Me.GunaSeparator1.Location = New System.Drawing.Point(52, 76)
        Me.GunaSeparator1.Name = "GunaSeparator1"
        Me.GunaSeparator1.Size = New System.Drawing.Size(354, 32)
        Me.GunaSeparator1.TabIndex = 54
        '
        'GunaPanel1
        '
        Me.GunaPanel1.Controls.Add(Me.GunaVSeparator2)
        Me.GunaPanel1.Controls.Add(Me.GunaLabel1)
        Me.GunaPanel1.Controls.Add(Me.GunaPictureBox1)
        Me.GunaPanel1.Controls.Add(Me.GunaVSeparator1)
        Me.GunaPanel1.Controls.Add(Me.btnCerrar)
        Me.GunaPanel1.Controls.Add(Me.btnMinimizar)
        Me.GunaPanel1.Controls.Add(Me.GunaImageButton1)
        Me.GunaPanel1.Location = New System.Drawing.Point(-1, 3)
        Me.GunaPanel1.Name = "GunaPanel1"
        Me.GunaPanel1.Size = New System.Drawing.Size(407, 50)
        Me.GunaPanel1.TabIndex = 56
        '
        'GunaVSeparator2
        '
        Me.GunaVSeparator2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.GunaVSeparator2.LineColor = System.Drawing.Color.WhiteSmoke
        Me.GunaVSeparator2.Location = New System.Drawing.Point(162, 12)
        Me.GunaVSeparator2.Name = "GunaVSeparator2"
        Me.GunaVSeparator2.Size = New System.Drawing.Size(10, 25)
        Me.GunaVSeparator2.TabIndex = 6
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel1.Location = New System.Drawing.Point(229, 15)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(65, 20)
        Me.GunaLabel1.TabIndex = 5
        Me.GunaLabel1.Text = "Manuel"
        '
        'GunaVSeparator1
        '
        Me.GunaVSeparator1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.GunaVSeparator1.LineColor = System.Drawing.Color.WhiteSmoke
        Me.GunaVSeparator1.Location = New System.Drawing.Point(308, 12)
        Me.GunaVSeparator1.Name = "GunaVSeparator1"
        Me.GunaVSeparator1.Size = New System.Drawing.Size(10, 25)
        Me.GunaVSeparator1.TabIndex = 3
        '
        'GunaLabel3
        '
        Me.GunaLabel3.AutoSize = True
        Me.GunaLabel3.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel3.Location = New System.Drawing.Point(11, 33)
        Me.GunaLabel3.Name = "GunaLabel3"
        Me.GunaLabel3.Size = New System.Drawing.Size(47, 15)
        Me.GunaLabel3.TabIndex = 58
        Me.GunaLabel3.Text = "Cliente:"
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
        Me.GunaTextBox1.Location = New System.Drawing.Point(64, 27)
        Me.GunaTextBox1.Name = "GunaTextBox1"
        Me.GunaTextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.GunaTextBox1.Size = New System.Drawing.Size(224, 26)
        Me.GunaTextBox1.TabIndex = 59
        '
        'GunaTextBox2
        '
        Me.GunaTextBox2.BaseColor = System.Drawing.Color.White
        Me.GunaTextBox2.BorderColor = System.Drawing.Color.Silver
        Me.GunaTextBox2.BorderSize = 1
        Me.GunaTextBox2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.GunaTextBox2.FocusedBaseColor = System.Drawing.Color.White
        Me.GunaTextBox2.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GunaTextBox2.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.GunaTextBox2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaTextBox2.Location = New System.Drawing.Point(69, 7)
        Me.GunaTextBox2.Name = "GunaTextBox2"
        Me.GunaTextBox2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.GunaTextBox2.Size = New System.Drawing.Size(155, 26)
        Me.GunaTextBox2.TabIndex = 62
        '
        'GunaLabel4
        '
        Me.GunaLabel4.AutoSize = True
        Me.GunaLabel4.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel4.Location = New System.Drawing.Point(18, 14)
        Me.GunaLabel4.Name = "GunaLabel4"
        Me.GunaLabel4.Size = New System.Drawing.Size(51, 15)
        Me.GunaLabel4.TabIndex = 61
        Me.GunaLabel4.Text = "Servicio:"
        '
        'GunaElipsePanel1
        '
        Me.GunaElipsePanel1.BaseColor = System.Drawing.Color.White
        Me.GunaElipsePanel1.Controls.Add(Me.GunaRadioButton2)
        Me.GunaElipsePanel1.Controls.Add(Me.GunaRadioButton1)
        Me.GunaElipsePanel1.Location = New System.Drawing.Point(120, 109)
        Me.GunaElipsePanel1.Name = "GunaElipsePanel1"
        Me.GunaElipsePanel1.Size = New System.Drawing.Size(169, 29)
        Me.GunaElipsePanel1.TabIndex = 63
        '
        'GunaRadioButton2
        '
        Me.GunaRadioButton2.BaseColor = System.Drawing.SystemColors.Control
        Me.GunaRadioButton2.CheckedOffColor = System.Drawing.Color.Gray
        Me.GunaRadioButton2.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaRadioButton2.FillColor = System.Drawing.Color.White
        Me.GunaRadioButton2.Location = New System.Drawing.Point(83, 3)
        Me.GunaRadioButton2.Name = "GunaRadioButton2"
        Me.GunaRadioButton2.Size = New System.Drawing.Size(65, 20)
        Me.GunaRadioButton2.TabIndex = 64
        Me.GunaRadioButton2.Text = "Cliente"
        '
        'GunaRadioButton1
        '
        Me.GunaRadioButton1.BaseColor = System.Drawing.SystemColors.Control
        Me.GunaRadioButton1.CheckedOffColor = System.Drawing.Color.Gray
        Me.GunaRadioButton1.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaRadioButton1.FillColor = System.Drawing.Color.White
        Me.GunaRadioButton1.Location = New System.Drawing.Point(7, 3)
        Me.GunaRadioButton1.Name = "GunaRadioButton1"
        Me.GunaRadioButton1.Size = New System.Drawing.Size(70, 20)
        Me.GunaRadioButton1.TabIndex = 0
        Me.GunaRadioButton1.Text = "Servicio"
        '
        'GunaElipsePanel2
        '
        Me.GunaElipsePanel2.BaseColor = System.Drawing.SystemColors.Control
        Me.GunaElipsePanel2.Controls.Add(Me.GunaLabel8)
        Me.GunaElipsePanel2.Controls.Add(Me.GunaLabel9)
        Me.GunaElipsePanel2.Controls.Add(Me.GunaTextBox1)
        Me.GunaElipsePanel2.Controls.Add(Me.GunaLabel3)
        Me.GunaElipsePanel2.Location = New System.Drawing.Point(7, 144)
        Me.GunaElipsePanel2.Name = "GunaElipsePanel2"
        Me.GunaElipsePanel2.Size = New System.Drawing.Size(303, 73)
        Me.GunaElipsePanel2.TabIndex = 64
        '
        'GunaElipsePanel3
        '
        Me.GunaElipsePanel3.BaseColor = System.Drawing.Color.White
        Me.GunaElipsePanel3.Controls.Add(Me.GunaLabel7)
        Me.GunaElipsePanel3.Controls.Add(Me.GunaLabel6)
        Me.GunaElipsePanel3.Controls.Add(Me.GunaTextBox2)
        Me.GunaElipsePanel3.Controls.Add(Me.GunaLabel4)
        Me.GunaElipsePanel3.Location = New System.Drawing.Point(7, 144)
        Me.GunaElipsePanel3.Name = "GunaElipsePanel3"
        Me.GunaElipsePanel3.Size = New System.Drawing.Size(303, 75)
        Me.GunaElipsePanel3.TabIndex = 65
        '
        'GunaPanel2
        '
        Me.GunaPanel2.Controls.Add(Me.GunaLabel15)
        Me.GunaPanel2.Controls.Add(Me.GunaLabel14)
        Me.GunaPanel2.Controls.Add(Me.GunaLabel12)
        Me.GunaPanel2.Controls.Add(Me.GunaTextBox3)
        Me.GunaPanel2.Controls.Add(Me.GunaLabel13)
        Me.GunaPanel2.Controls.Add(Me.GunaLabel11)
        Me.GunaPanel2.Controls.Add(Me.GunaLabel10)
        Me.GunaPanel2.Controls.Add(Me.GunaLabel5)
        Me.GunaPanel2.Location = New System.Drawing.Point(7, 225)
        Me.GunaPanel2.Name = "GunaPanel2"
        Me.GunaPanel2.Size = New System.Drawing.Size(404, 124)
        Me.GunaPanel2.TabIndex = 66
        '
        'GunaLabel5
        '
        Me.GunaLabel5.AutoSize = True
        Me.GunaLabel5.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel5.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel5.Location = New System.Drawing.Point(11, 12)
        Me.GunaLabel5.Name = "GunaLabel5"
        Me.GunaLabel5.Size = New System.Drawing.Size(65, 15)
        Me.GunaLabel5.TabIndex = 62
        Me.GunaLabel5.Text = "Referencia:"
        '
        'GunaLabel6
        '
        Me.GunaLabel6.AutoSize = True
        Me.GunaLabel6.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel6.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel6.Location = New System.Drawing.Point(14, 54)
        Me.GunaLabel6.Name = "GunaLabel6"
        Me.GunaLabel6.Size = New System.Drawing.Size(55, 15)
        Me.GunaLabel6.TabIndex = 63
        Me.GunaLabel6.Text = "Paciente:"
        '
        'GunaLabel7
        '
        Me.GunaLabel7.AutoSize = True
        Me.GunaLabel7.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel7.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel7.Location = New System.Drawing.Point(69, 54)
        Me.GunaLabel7.Name = "GunaLabel7"
        Me.GunaLabel7.Size = New System.Drawing.Size(55, 15)
        Me.GunaLabel7.TabIndex = 64
        Me.GunaLabel7.Text = "Paciente:"
        '
        'GunaLabel8
        '
        Me.GunaLabel8.AutoSize = True
        Me.GunaLabel8.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel8.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel8.Location = New System.Drawing.Point(71, 9)
        Me.GunaLabel8.Name = "GunaLabel8"
        Me.GunaLabel8.Size = New System.Drawing.Size(55, 15)
        Me.GunaLabel8.TabIndex = 66
        Me.GunaLabel8.Text = "Paciente:"
        '
        'GunaLabel9
        '
        Me.GunaLabel9.AutoSize = True
        Me.GunaLabel9.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel9.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel9.Location = New System.Drawing.Point(3, 9)
        Me.GunaLabel9.Name = "GunaLabel9"
        Me.GunaLabel9.Size = New System.Drawing.Size(55, 15)
        Me.GunaLabel9.TabIndex = 65
        Me.GunaLabel9.Text = "Paciente:"
        '
        'GunaLabel10
        '
        Me.GunaLabel10.AutoSize = True
        Me.GunaLabel10.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel10.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel10.Location = New System.Drawing.Point(82, 12)
        Me.GunaLabel10.Name = "GunaLabel10"
        Me.GunaLabel10.Size = New System.Drawing.Size(65, 15)
        Me.GunaLabel10.TabIndex = 63
        Me.GunaLabel10.Text = "Referencia:"
        '
        'GunaLabel11
        '
        Me.GunaLabel11.AutoSize = True
        Me.GunaLabel11.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel11.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel11.Location = New System.Drawing.Point(230, 35)
        Me.GunaLabel11.Name = "GunaLabel11"
        Me.GunaLabel11.Size = New System.Drawing.Size(35, 15)
        Me.GunaLabel11.TabIndex = 64
        Me.GunaLabel11.Text = "Total:"
        '
        'GunaLabel13
        '
        Me.GunaLabel13.AutoSize = True
        Me.GunaLabel13.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel13.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel13.Location = New System.Drawing.Point(213, 64)
        Me.GunaLabel13.Name = "GunaLabel13"
        Me.GunaLabel13.Size = New System.Drawing.Size(52, 15)
        Me.GunaLabel13.TabIndex = 66
        Me.GunaLabel13.Text = "Importe:"
        '
        'GunaTextBox3
        '
        Me.GunaTextBox3.BaseColor = System.Drawing.Color.White
        Me.GunaTextBox3.BorderColor = System.Drawing.Color.Silver
        Me.GunaTextBox3.BorderSize = 1
        Me.GunaTextBox3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.GunaTextBox3.FocusedBaseColor = System.Drawing.Color.White
        Me.GunaTextBox3.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GunaTextBox3.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.GunaTextBox3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaTextBox3.Location = New System.Drawing.Point(268, 55)
        Me.GunaTextBox3.Name = "GunaTextBox3"
        Me.GunaTextBox3.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.GunaTextBox3.Size = New System.Drawing.Size(69, 26)
        Me.GunaTextBox3.TabIndex = 67
        '
        'GunaLabel12
        '
        Me.GunaLabel12.AutoSize = True
        Me.GunaLabel12.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel12.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel12.Location = New System.Drawing.Point(267, 35)
        Me.GunaLabel12.Name = "GunaLabel12"
        Me.GunaLabel12.Size = New System.Drawing.Size(35, 15)
        Me.GunaLabel12.TabIndex = 68
        Me.GunaLabel12.Text = "Total:"
        '
        'GunaLabel14
        '
        Me.GunaLabel14.AutoSize = True
        Me.GunaLabel14.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel14.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel14.Location = New System.Drawing.Point(213, 93)
        Me.GunaLabel14.Name = "GunaLabel14"
        Me.GunaLabel14.Size = New System.Drawing.Size(52, 15)
        Me.GunaLabel14.TabIndex = 69
        Me.GunaLabel14.Text = "Cambio:"
        '
        'GunaLabel15
        '
        Me.GunaLabel15.AutoSize = True
        Me.GunaLabel15.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel15.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel15.Location = New System.Drawing.Point(268, 92)
        Me.GunaLabel15.Name = "GunaLabel15"
        Me.GunaLabel15.Size = New System.Drawing.Size(52, 15)
        Me.GunaLabel15.TabIndex = 70
        Me.GunaLabel15.Text = "Cambio:"
        '
        'GunaButton2
        '
        Me.GunaButton2.AnimationHoverSpeed = 0.07!
        Me.GunaButton2.AnimationSpeed = 0.03!
        Me.GunaButton2.BaseColor = System.Drawing.Color.Navy
        Me.GunaButton2.BorderColor = System.Drawing.Color.Black
        Me.GunaButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.GunaButton2.FocusedColor = System.Drawing.Color.Empty
        Me.GunaButton2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GunaButton2.ForeColor = System.Drawing.Color.White
        Me.GunaButton2.Image = Global.Maulabs.My.Resources.Resources.icons8_print_24
        Me.GunaButton2.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaButton2.Location = New System.Drawing.Point(299, 357)
        Me.GunaButton2.Name = "GunaButton2"
        Me.GunaButton2.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GunaButton2.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaButton2.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButton2.OnHoverImage = Nothing
        Me.GunaButton2.OnPressedColor = System.Drawing.Color.Black
        Me.GunaButton2.Radius = 3
        Me.GunaButton2.Size = New System.Drawing.Size(111, 42)
        Me.GunaButton2.TabIndex = 69
        Me.GunaButton2.Text = "Imprimir"
        '
        'GunaButton1
        '
        Me.GunaButton1.AnimationHoverSpeed = 0.07!
        Me.GunaButton1.AnimationSpeed = 0.03!
        Me.GunaButton1.BaseColor = System.Drawing.Color.Firebrick
        Me.GunaButton1.BorderColor = System.Drawing.Color.Black
        Me.GunaButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.GunaButton1.FocusedColor = System.Drawing.Color.Empty
        Me.GunaButton1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GunaButton1.ForeColor = System.Drawing.Color.White
        Me.GunaButton1.Image = Global.Maulabs.My.Resources.Resources.icons8_cancel_28
        Me.GunaButton1.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaButton1.Location = New System.Drawing.Point(153, 357)
        Me.GunaButton1.Name = "GunaButton1"
        Me.GunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GunaButton1.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaButton1.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButton1.OnHoverImage = Nothing
        Me.GunaButton1.OnPressedColor = System.Drawing.Color.Black
        Me.GunaButton1.Radius = 3
        Me.GunaButton1.Size = New System.Drawing.Size(111, 42)
        Me.GunaButton1.TabIndex = 68
        Me.GunaButton1.Text = "Cancelar"
        '
        'btnPacientes
        '
        Me.btnPacientes.AnimationHoverSpeed = 0.07!
        Me.btnPacientes.AnimationSpeed = 0.03!
        Me.btnPacientes.BaseColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.btnPacientes.BorderColor = System.Drawing.Color.Black
        Me.btnPacientes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPacientes.FocusedColor = System.Drawing.Color.Empty
        Me.btnPacientes.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnPacientes.ForeColor = System.Drawing.Color.White
        Me.btnPacientes.Image = Global.Maulabs.My.Resources.Resources.icons8_save_28
        Me.btnPacientes.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnPacientes.Location = New System.Drawing.Point(7, 357)
        Me.btnPacientes.Name = "btnPacientes"
        Me.btnPacientes.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnPacientes.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnPacientes.OnHoverForeColor = System.Drawing.Color.White
        Me.btnPacientes.OnHoverImage = Nothing
        Me.btnPacientes.OnPressedColor = System.Drawing.Color.Black
        Me.btnPacientes.Radius = 3
        Me.btnPacientes.Size = New System.Drawing.Size(111, 42)
        Me.btnPacientes.TabIndex = 67
        Me.btnPacientes.Text = "Guardar"
        '
        'btnSolicitudes
        '
        Me.btnSolicitudes.AnimationHoverSpeed = 0.07!
        Me.btnSolicitudes.AnimationSpeed = 0.03!
        Me.btnSolicitudes.BaseColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnSolicitudes.BorderColor = System.Drawing.Color.Black
        Me.btnSolicitudes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSolicitudes.FocusedColor = System.Drawing.Color.Empty
        Me.btnSolicitudes.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnSolicitudes.ForeColor = System.Drawing.SystemColors.WindowText
        Me.btnSolicitudes.Image = Global.Maulabs.My.Resources.Resources.icons8_search_24__1_
        Me.btnSolicitudes.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnSolicitudes.Location = New System.Drawing.Point(316, 163)
        Me.btnSolicitudes.Name = "btnSolicitudes"
        Me.btnSolicitudes.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(175, Byte), Integer))
        Me.btnSolicitudes.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnSolicitudes.OnHoverForeColor = System.Drawing.Color.White
        Me.btnSolicitudes.OnHoverImage = Nothing
        Me.btnSolicitudes.OnPressedColor = System.Drawing.Color.Black
        Me.btnSolicitudes.Radius = 3
        Me.btnSolicitudes.Size = New System.Drawing.Size(90, 29)
        Me.btnSolicitudes.TabIndex = 60
        Me.btnSolicitudes.Text = "Buscar"
        Me.btnSolicitudes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox5.Image = Global.Maulabs.My.Resources.Resources.icons8_paper_money_48
        Me.PictureBox5.Location = New System.Drawing.Point(7, 56)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(48, 48)
        Me.PictureBox5.TabIndex = 57
        Me.PictureBox5.TabStop = False
        '
        'GunaPictureBox1
        '
        Me.GunaPictureBox1.BaseColor = System.Drawing.Color.White
        Me.GunaPictureBox1.Image = Global.Maulabs.My.Resources.Resources.icons8_verified_account_28
        Me.GunaPictureBox1.Location = New System.Drawing.Point(188, 8)
        Me.GunaPictureBox1.Name = "GunaPictureBox1"
        Me.GunaPictureBox1.Size = New System.Drawing.Size(32, 32)
        Me.GunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.GunaPictureBox1.TabIndex = 4
        Me.GunaPictureBox1.TabStop = False
        '
        'btnCerrar
        '
        Me.btnCerrar.Image = Global.Maulabs.My.Resources.Resources.icons8_multiply_48
        Me.btnCerrar.ImageSize = New System.Drawing.Size(16, 16)
        Me.btnCerrar.Location = New System.Drawing.Point(357, 8)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.OnHoverImage = Nothing
        Me.btnCerrar.OnHoverImageOffset = New System.Drawing.Point(0, -1)
        Me.btnCerrar.Size = New System.Drawing.Size(32, 32)
        Me.btnCerrar.TabIndex = 2
        '
        'btnMinimizar
        '
        Me.btnMinimizar.Image = Global.Maulabs.My.Resources.Resources.icons8_horizontal_line_48
        Me.btnMinimizar.ImageSize = New System.Drawing.Size(16, 16)
        Me.btnMinimizar.Location = New System.Drawing.Point(319, 8)
        Me.btnMinimizar.Name = "btnMinimizar"
        Me.btnMinimizar.OnHoverImage = Nothing
        Me.btnMinimizar.OnHoverImageOffset = New System.Drawing.Point(0, -1)
        Me.btnMinimizar.Size = New System.Drawing.Size(32, 32)
        Me.btnMinimizar.TabIndex = 1
        '
        'GunaImageButton1
        '
        Me.GunaImageButton1.Image = Global.Maulabs.My.Resources.Resources.icons8_menu_48
        Me.GunaImageButton1.ImageSize = New System.Drawing.Size(16, 16)
        Me.GunaImageButton1.Location = New System.Drawing.Point(8, 8)
        Me.GunaImageButton1.Name = "GunaImageButton1"
        Me.GunaImageButton1.OnHoverImage = Nothing
        Me.GunaImageButton1.OnHoverImageOffset = New System.Drawing.Point(0, -1)
        Me.GunaImageButton1.Size = New System.Drawing.Size(32, 32)
        Me.GunaImageButton1.TabIndex = 0
        '
        'FrmPagos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(419, 411)
        Me.Controls.Add(Me.GunaButton2)
        Me.Controls.Add(Me.GunaButton1)
        Me.Controls.Add(Me.btnPacientes)
        Me.Controls.Add(Me.GunaPanel2)
        Me.Controls.Add(Me.GunaElipsePanel3)
        Me.Controls.Add(Me.GunaElipsePanel2)
        Me.Controls.Add(Me.GunaElipsePanel1)
        Me.Controls.Add(Me.btnSolicitudes)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.GunaPanel1)
        Me.Controls.Add(Me.GunaLabel2)
        Me.Controls.Add(Me.GunaSeparator1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmPagos"
        Me.Text = "FrmPagos"
        Me.GunaPanel1.ResumeLayout(False)
        Me.GunaPanel1.PerformLayout()
        Me.GunaElipsePanel1.ResumeLayout(False)
        Me.GunaElipsePanel1.PerformLayout()
        Me.GunaElipsePanel2.ResumeLayout(False)
        Me.GunaElipsePanel2.PerformLayout()
        Me.GunaElipsePanel3.ResumeLayout(False)
        Me.GunaElipsePanel3.PerformLayout()
        Me.GunaPanel2.ResumeLayout(False)
        Me.GunaPanel2.PerformLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GunaElipse1 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaSeparator1 As Guna.UI.WinForms.GunaSeparator
    Friend WithEvents GunaPanel1 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents GunaVSeparator2 As Guna.UI.WinForms.GunaVSeparator
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaPictureBox1 As Guna.UI.WinForms.GunaPictureBox
    Friend WithEvents GunaVSeparator1 As Guna.UI.WinForms.GunaVSeparator
    Friend WithEvents btnCerrar As Guna.UI.WinForms.GunaImageButton
    Friend WithEvents btnMinimizar As Guna.UI.WinForms.GunaImageButton
    Friend WithEvents GunaImageButton1 As Guna.UI.WinForms.GunaImageButton
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents GunaLabel3 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaTextBox1 As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents btnSolicitudes As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaElipsePanel3 As Guna.UI.WinForms.GunaElipsePanel
    Friend WithEvents GunaTextBox2 As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaLabel4 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaElipsePanel2 As Guna.UI.WinForms.GunaElipsePanel
    Friend WithEvents GunaElipsePanel1 As Guna.UI.WinForms.GunaElipsePanel
    Friend WithEvents GunaRadioButton2 As Guna.UI.WinForms.GunaRadioButton
    Friend WithEvents GunaRadioButton1 As Guna.UI.WinForms.GunaRadioButton
    Friend WithEvents GunaPanel2 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents GunaTextBox3 As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaLabel13 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel11 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel10 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel5 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel7 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel6 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel8 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel9 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel15 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel14 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel12 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaButton2 As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaButton1 As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnPacientes As Guna.UI.WinForms.GunaButton
End Class
