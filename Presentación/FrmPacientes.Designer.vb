<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmPacientes
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
        Me.GunaElipse1 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.GunaPanel1 = New Guna.UI.WinForms.GunaPanel()
        Me.GunaVSeparator2 = New Guna.UI.WinForms.GunaVSeparator()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaPictureBox1 = New Guna.UI.WinForms.GunaPictureBox()
        Me.GunaVSeparator1 = New Guna.UI.WinForms.GunaVSeparator()
        Me.btnCerrar = New Guna.UI.WinForms.GunaImageButton()
        Me.btnMinimizar = New Guna.UI.WinForms.GunaImageButton()
        Me.GunaImageButton1 = New Guna.UI.WinForms.GunaImageButton()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel4 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel3 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel5 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel6 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel7 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel8 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel9 = New Guna.UI.WinForms.GunaLabel()
        Me.txtNombre = New Guna.UI.WinForms.GunaTextBox()
        Me.txtDomicilio = New Guna.UI.WinForms.GunaTextBox()
        Me.txtTelefono = New Guna.UI.WinForms.GunaTextBox()
        Me.txtCelular = New Guna.UI.WinForms.GunaTextBox()
        Me.txtEmail = New Guna.UI.WinForms.GunaTextBox()
        Me.txtSangre = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaSeparator1 = New Guna.UI.WinForms.GunaSeparator()
        Me.GunaSeparator2 = New Guna.UI.WinForms.GunaSeparator()
        Me.btnCancelar = New Guna.UI.WinForms.GunaButton()
        Me.btnGuardar = New Guna.UI.WinForms.GunaButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.dtpFechaNacimiento = New System.Windows.Forms.MaskedTextBox()
        Me.GunaPanel1.SuspendLayout()
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GunaElipse1
        '
        Me.GunaElipse1.TargetControl = Me
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
        Me.GunaPanel1.Location = New System.Drawing.Point(0, 0)
        Me.GunaPanel1.Name = "GunaPanel1"
        Me.GunaPanel1.Size = New System.Drawing.Size(606, 50)
        Me.GunaPanel1.TabIndex = 1
        '
        'GunaVSeparator2
        '
        Me.GunaVSeparator2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.GunaVSeparator2.LineColor = System.Drawing.Color.WhiteSmoke
        Me.GunaVSeparator2.Location = New System.Drawing.Point(372, 12)
        Me.GunaVSeparator2.Name = "GunaVSeparator2"
        Me.GunaVSeparator2.Size = New System.Drawing.Size(10, 25)
        Me.GunaVSeparator2.TabIndex = 6
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel1.Location = New System.Drawing.Point(439, 15)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(65, 20)
        Me.GunaLabel1.TabIndex = 5
        Me.GunaLabel1.Text = "Manuel"
        '
        'GunaPictureBox1
        '
        Me.GunaPictureBox1.BaseColor = System.Drawing.Color.White
        Me.GunaPictureBox1.Image = Global.Maulabs.My.Resources.Resources.icons8_verified_account_28
        Me.GunaPictureBox1.Location = New System.Drawing.Point(398, 8)
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
        Me.GunaVSeparator1.Location = New System.Drawing.Point(518, 12)
        Me.GunaVSeparator1.Name = "GunaVSeparator1"
        Me.GunaVSeparator1.Size = New System.Drawing.Size(10, 25)
        Me.GunaVSeparator1.TabIndex = 3
        '
        'btnCerrar
        '
        Me.btnCerrar.Image = Global.Maulabs.My.Resources.Resources.icons8_multiply_48
        Me.btnCerrar.ImageSize = New System.Drawing.Size(16, 16)
        Me.btnCerrar.Location = New System.Drawing.Point(567, 8)
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
        Me.btnMinimizar.Location = New System.Drawing.Point(529, 8)
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
        'GunaLabel2
        '
        Me.GunaLabel2.AutoSize = True
        Me.GunaLabel2.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel2.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel2.Location = New System.Drawing.Point(72, 53)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(259, 32)
        Me.GunaLabel2.TabIndex = 2
        Me.GunaLabel2.Text = "Registro de Pacientes"
        '
        'GunaLabel4
        '
        Me.GunaLabel4.AutoSize = True
        Me.GunaLabel4.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel4.Location = New System.Drawing.Point(92, 110)
        Me.GunaLabel4.Name = "GunaLabel4"
        Me.GunaLabel4.Size = New System.Drawing.Size(60, 17)
        Me.GunaLabel4.TabIndex = 4
        Me.GunaLabel4.Text = "Nombre:"
        '
        'GunaLabel3
        '
        Me.GunaLabel3.AutoSize = True
        Me.GunaLabel3.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel3.Location = New System.Drawing.Point(87, 148)
        Me.GunaLabel3.Name = "GunaLabel3"
        Me.GunaLabel3.Size = New System.Drawing.Size(65, 17)
        Me.GunaLabel3.TabIndex = 5
        Me.GunaLabel3.Text = "Domicilio:"
        '
        'GunaLabel5
        '
        Me.GunaLabel5.AutoSize = True
        Me.GunaLabel5.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel5.Location = New System.Drawing.Point(91, 187)
        Me.GunaLabel5.Name = "GunaLabel5"
        Me.GunaLabel5.Size = New System.Drawing.Size(61, 17)
        Me.GunaLabel5.TabIndex = 6
        Me.GunaLabel5.Text = "Teléfono:"
        '
        'GunaLabel6
        '
        Me.GunaLabel6.AutoSize = True
        Me.GunaLabel6.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel6.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel6.Location = New System.Drawing.Point(361, 187)
        Me.GunaLabel6.Name = "GunaLabel6"
        Me.GunaLabel6.Size = New System.Drawing.Size(51, 17)
        Me.GunaLabel6.TabIndex = 7
        Me.GunaLabel6.Text = "Celular:"
        '
        'GunaLabel7
        '
        Me.GunaLabel7.AutoSize = True
        Me.GunaLabel7.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel7.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel7.Location = New System.Drawing.Point(105, 222)
        Me.GunaLabel7.Name = "GunaLabel7"
        Me.GunaLabel7.Size = New System.Drawing.Size(47, 17)
        Me.GunaLabel7.TabIndex = 8
        Me.GunaLabel7.Text = "E-mail:"
        '
        'GunaLabel8
        '
        Me.GunaLabel8.AutoSize = True
        Me.GunaLabel8.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel8.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel8.Location = New System.Drawing.Point(51, 260)
        Me.GunaLabel8.Name = "GunaLabel8"
        Me.GunaLabel8.Size = New System.Drawing.Size(101, 17)
        Me.GunaLabel8.TabIndex = 9
        Me.GunaLabel8.Text = "Tipo de Sangre:"
        '
        'GunaLabel9
        '
        Me.GunaLabel9.AutoSize = True
        Me.GunaLabel9.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel9.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel9.Location = New System.Drawing.Point(19, 292)
        Me.GunaLabel9.Name = "GunaLabel9"
        Me.GunaLabel9.Size = New System.Drawing.Size(133, 17)
        Me.GunaLabel9.TabIndex = 10
        Me.GunaLabel9.Text = "Fecha de Nacimiento:"
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
        Me.txtNombre.Location = New System.Drawing.Point(158, 106)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNombre.Size = New System.Drawing.Size(420, 30)
        Me.txtNombre.TabIndex = 11
        '
        'txtDomicilio
        '
        Me.txtDomicilio.BaseColor = System.Drawing.Color.White
        Me.txtDomicilio.BorderColor = System.Drawing.Color.Silver
        Me.txtDomicilio.BorderSize = 1
        Me.txtDomicilio.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDomicilio.FocusedBaseColor = System.Drawing.Color.White
        Me.txtDomicilio.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtDomicilio.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtDomicilio.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtDomicilio.Location = New System.Drawing.Point(158, 144)
        Me.txtDomicilio.Name = "txtDomicilio"
        Me.txtDomicilio.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDomicilio.Size = New System.Drawing.Size(420, 30)
        Me.txtDomicilio.TabIndex = 12
        '
        'txtTelefono
        '
        Me.txtTelefono.BaseColor = System.Drawing.Color.White
        Me.txtTelefono.BorderColor = System.Drawing.Color.Silver
        Me.txtTelefono.BorderSize = 1
        Me.txtTelefono.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTelefono.FocusedBaseColor = System.Drawing.Color.White
        Me.txtTelefono.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtTelefono.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtTelefono.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtTelefono.Location = New System.Drawing.Point(158, 182)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTelefono.Size = New System.Drawing.Size(197, 30)
        Me.txtTelefono.TabIndex = 13
        '
        'txtCelular
        '
        Me.txtCelular.BaseColor = System.Drawing.Color.White
        Me.txtCelular.BorderColor = System.Drawing.Color.Silver
        Me.txtCelular.BorderSize = 1
        Me.txtCelular.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCelular.FocusedBaseColor = System.Drawing.Color.White
        Me.txtCelular.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtCelular.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtCelular.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtCelular.Location = New System.Drawing.Point(418, 181)
        Me.txtCelular.Name = "txtCelular"
        Me.txtCelular.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCelular.Size = New System.Drawing.Size(160, 30)
        Me.txtCelular.TabIndex = 14
        '
        'txtEmail
        '
        Me.txtEmail.BaseColor = System.Drawing.Color.White
        Me.txtEmail.BorderColor = System.Drawing.Color.Silver
        Me.txtEmail.BorderSize = 1
        Me.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtEmail.FocusedBaseColor = System.Drawing.Color.White
        Me.txtEmail.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtEmail.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtEmail.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtEmail.Location = New System.Drawing.Point(158, 218)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtEmail.Size = New System.Drawing.Size(197, 30)
        Me.txtEmail.TabIndex = 15
        '
        'txtSangre
        '
        Me.txtSangre.BaseColor = System.Drawing.Color.White
        Me.txtSangre.BorderColor = System.Drawing.Color.Silver
        Me.txtSangre.BorderSize = 1
        Me.txtSangre.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSangre.FocusedBaseColor = System.Drawing.Color.White
        Me.txtSangre.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtSangre.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtSangre.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtSangre.Location = New System.Drawing.Point(158, 256)
        Me.txtSangre.Name = "txtSangre"
        Me.txtSangre.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSangre.Size = New System.Drawing.Size(197, 30)
        Me.txtSangre.TabIndex = 16
        '
        'GunaSeparator1
        '
        Me.GunaSeparator1.LineColor = System.Drawing.Color.Silver
        Me.GunaSeparator1.Location = New System.Drawing.Point(72, 70)
        Me.GunaSeparator1.Name = "GunaSeparator1"
        Me.GunaSeparator1.Size = New System.Drawing.Size(512, 34)
        Me.GunaSeparator1.TabIndex = 18
        '
        'GunaSeparator2
        '
        Me.GunaSeparator2.LineColor = System.Drawing.Color.Silver
        Me.GunaSeparator2.Location = New System.Drawing.Point(12, 317)
        Me.GunaSeparator2.Name = "GunaSeparator2"
        Me.GunaSeparator2.Size = New System.Drawing.Size(572, 32)
        Me.GunaSeparator2.TabIndex = 21
        '
        'btnCancelar
        '
        Me.btnCancelar.AnimationHoverSpeed = 0.07!
        Me.btnCancelar.AnimationSpeed = 0.03!
        Me.btnCancelar.BaseColor = System.Drawing.Color.Firebrick
        Me.btnCancelar.BorderColor = System.Drawing.Color.Black
        Me.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancelar.FocusedColor = System.Drawing.Color.Empty
        Me.btnCancelar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnCancelar.ForeColor = System.Drawing.Color.White
        Me.btnCancelar.Image = Global.Maulabs.My.Resources.Resources.icons8_cancel_28
        Me.btnCancelar.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnCancelar.Location = New System.Drawing.Point(319, 346)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnCancelar.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnCancelar.OnHoverForeColor = System.Drawing.Color.White
        Me.btnCancelar.OnHoverImage = Nothing
        Me.btnCancelar.OnPressedColor = System.Drawing.Color.Black
        Me.btnCancelar.Radius = 3
        Me.btnCancelar.Size = New System.Drawing.Size(111, 42)
        Me.btnCancelar.TabIndex = 20
        Me.btnCancelar.Text = "Cancelar"
        '
        'btnGuardar
        '
        Me.btnGuardar.AnimationHoverSpeed = 0.07!
        Me.btnGuardar.AnimationSpeed = 0.03!
        Me.btnGuardar.BaseColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.btnGuardar.BorderColor = System.Drawing.Color.Black
        Me.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGuardar.FocusedColor = System.Drawing.Color.Empty
        Me.btnGuardar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnGuardar.ForeColor = System.Drawing.Color.White
        Me.btnGuardar.Image = Global.Maulabs.My.Resources.Resources.icons8_save_28
        Me.btnGuardar.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnGuardar.Location = New System.Drawing.Point(175, 346)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.btnGuardar.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnGuardar.OnHoverForeColor = System.Drawing.Color.White
        Me.btnGuardar.OnHoverImage = Nothing
        Me.btnGuardar.OnPressedColor = System.Drawing.Color.Black
        Me.btnGuardar.Radius = 3
        Me.btnGuardar.Size = New System.Drawing.Size(111, 42)
        Me.btnGuardar.TabIndex = 19
        Me.btnGuardar.Text = "Guardar"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.Maulabs.My.Resources.Resources.icons8_health_checkup_48
        Me.PictureBox1.Location = New System.Drawing.Point(12, 56)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(54, 52)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'dtpFechaNacimiento
        '
        Me.dtpFechaNacimiento.Location = New System.Drawing.Point(158, 291)
        Me.dtpFechaNacimiento.Mask = "00/00/0000"
        Me.dtpFechaNacimiento.Name = "dtpFechaNacimiento"
        Me.dtpFechaNacimiento.Size = New System.Drawing.Size(197, 20)
        Me.dtpFechaNacimiento.TabIndex = 22
        Me.dtpFechaNacimiento.ValidatingType = GetType(Date)
        '
        'FrmPacientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(607, 398)
        Me.Controls.Add(Me.dtpFechaNacimiento)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.GunaSeparator2)
        Me.Controls.Add(Me.GunaLabel2)
        Me.Controls.Add(Me.GunaSeparator1)
        Me.Controls.Add(Me.txtSangre)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtCelular)
        Me.Controls.Add(Me.txtTelefono)
        Me.Controls.Add(Me.txtDomicilio)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.GunaLabel9)
        Me.Controls.Add(Me.GunaLabel8)
        Me.Controls.Add(Me.GunaLabel7)
        Me.Controls.Add(Me.GunaLabel6)
        Me.Controls.Add(Me.GunaLabel5)
        Me.Controls.Add(Me.GunaLabel3)
        Me.Controls.Add(Me.GunaLabel4)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GunaPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmPacientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmPacientes"
        Me.GunaPanel1.ResumeLayout(False)
        Me.GunaPanel1.PerformLayout()
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GunaElipse1 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents GunaPanel1 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents GunaVSeparator2 As Guna.UI.WinForms.GunaVSeparator
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaPictureBox1 As Guna.UI.WinForms.GunaPictureBox
    Friend WithEvents GunaVSeparator1 As Guna.UI.WinForms.GunaVSeparator
    Friend WithEvents btnCerrar As Guna.UI.WinForms.GunaImageButton
    Friend WithEvents btnMinimizar As Guna.UI.WinForms.GunaImageButton
    Friend WithEvents GunaImageButton1 As Guna.UI.WinForms.GunaImageButton
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GunaSeparator1 As Guna.UI.WinForms.GunaSeparator
    Friend WithEvents txtSangre As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents txtEmail As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents txtCelular As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents txtTelefono As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents txtDomicilio As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents txtNombre As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaLabel9 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel8 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel7 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel6 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel5 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel3 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel4 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents btnGuardar As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnCancelar As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaSeparator2 As Guna.UI.WinForms.GunaSeparator
    Friend WithEvents dtpFechaNacimiento As MaskedTextBox
End Class
