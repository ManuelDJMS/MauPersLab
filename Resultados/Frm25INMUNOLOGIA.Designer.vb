﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm25INMUNOLOGIA
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
        Me.GunaElipsePanel1 = New Guna.UI.WinForms.GunaElipsePanel()
        Me.GunaLabel30 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel22 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel6 = New Guna.UI.WinForms.GunaLabel()
        Me.txtNombreMedico = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaLabel4 = New Guna.UI.WinForms.GunaLabel()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaSeparator1 = New Guna.UI.WinForms.GunaSeparator()
        Me.GunaLabel29 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel28 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaPanel1 = New Guna.UI.WinForms.GunaPanel()
        Me.GunaVSeparator2 = New Guna.UI.WinForms.GunaVSeparator()
        Me.lbInicio = New Guna.UI.WinForms.GunaLabel()
        Me.GunaPictureBox1 = New Guna.UI.WinForms.GunaPictureBox()
        Me.GunaVSeparator1 = New Guna.UI.WinForms.GunaVSeparator()
        Me.btnCerrar = New Guna.UI.WinForms.GunaImageButton()
        Me.btnMinimizar = New Guna.UI.WinForms.GunaImageButton()
        Me.GunaImageButton1 = New Guna.UI.WinForms.GunaImageButton()
        Me.GunaElipsePanel1.SuspendLayout()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GunaPanel1.SuspendLayout()
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GunaElipse1
        '
        Me.GunaElipse1.TargetControl = Me
        '
        'GunaElipsePanel1
        '
        Me.GunaElipsePanel1.BackColor = System.Drawing.Color.Transparent
        Me.GunaElipsePanel1.BaseColor = System.Drawing.Color.White
        Me.GunaElipsePanel1.Controls.Add(Me.GunaLabel30)
        Me.GunaElipsePanel1.Controls.Add(Me.GunaLabel22)
        Me.GunaElipsePanel1.Controls.Add(Me.GunaLabel6)
        Me.GunaElipsePanel1.Controls.Add(Me.txtNombreMedico)
        Me.GunaElipsePanel1.Controls.Add(Me.GunaLabel4)
        Me.GunaElipsePanel1.Location = New System.Drawing.Point(82, 140)
        Me.GunaElipsePanel1.Name = "GunaElipsePanel1"
        Me.GunaElipsePanel1.Size = New System.Drawing.Size(632, 125)
        Me.GunaElipsePanel1.TabIndex = 129
        '
        'GunaLabel30
        '
        Me.GunaLabel30.AutoSize = True
        Me.GunaLabel30.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel30.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel30.Location = New System.Drawing.Point(427, 69)
        Me.GunaLabel30.Name = "GunaLabel30"
        Me.GunaLabel30.Size = New System.Drawing.Size(85, 17)
        Me.GunaLabel30.TabIndex = 124
        Me.GunaLabel30.Text = "0.3-4.0 ng/ml"
        '
        'GunaLabel22
        '
        Me.GunaLabel22.AutoSize = True
        Me.GunaLabel22.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel22.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel22.Location = New System.Drawing.Point(359, 69)
        Me.GunaLabel22.Name = "GunaLabel22"
        Me.GunaLabel22.Size = New System.Drawing.Size(42, 17)
        Me.GunaLabel22.TabIndex = 118
        Me.GunaLabel22.Text = "ng/ml"
        '
        'GunaLabel6
        '
        Me.GunaLabel6.AutoSize = True
        Me.GunaLabel6.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel6.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel6.Location = New System.Drawing.Point(29, 41)
        Me.GunaLabel6.Name = "GunaLabel6"
        Me.GunaLabel6.Size = New System.Drawing.Size(102, 17)
        Me.GunaLabel6.TabIndex = 59
        Me.GunaLabel6.Text = "INMUNOLOGIA"
        '
        'txtNombreMedico
        '
        Me.txtNombreMedico.BaseColor = System.Drawing.Color.White
        Me.txtNombreMedico.BorderColor = System.Drawing.Color.Silver
        Me.txtNombreMedico.BorderSize = 1
        Me.txtNombreMedico.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNombreMedico.FocusedBaseColor = System.Drawing.Color.White
        Me.txtNombreMedico.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtNombreMedico.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtNombreMedico.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtNombreMedico.Location = New System.Drawing.Point(267, 69)
        Me.txtNombreMedico.Name = "txtNombreMedico"
        Me.txtNombreMedico.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNombreMedico.Size = New System.Drawing.Size(70, 26)
        Me.txtNombreMedico.TabIndex = 55
        '
        'GunaLabel4
        '
        Me.GunaLabel4.AutoSize = True
        Me.GunaLabel4.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel4.Location = New System.Drawing.Point(32, 75)
        Me.GunaLabel4.Name = "GunaLabel4"
        Me.GunaLabel4.Size = New System.Drawing.Size(229, 17)
        Me.GunaLabel4.TabIndex = 53
        Me.GunaLabel4.Text = "ANTIGENO ESPECIFICO DE PROSTATA "
        '
        'PictureBox8
        '
        Me.PictureBox8.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox8.Image = Global.Maulabs.My.Resources.Resources.icons8_caduceus_48
        Me.PictureBox8.Location = New System.Drawing.Point(12, 61)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(54, 52)
        Me.PictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox8.TabIndex = 128
        Me.PictureBox8.TabStop = False
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoSize = True
        Me.GunaLabel2.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel2.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel2.Location = New System.Drawing.Point(62, 65)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(276, 32)
        Me.GunaLabel2.TabIndex = 126
        Me.GunaLabel2.Text = "Registro de Resultados"
        '
        'GunaSeparator1
        '
        Me.GunaSeparator1.LineColor = System.Drawing.Color.Silver
        Me.GunaSeparator1.Location = New System.Drawing.Point(62, 85)
        Me.GunaSeparator1.Name = "GunaSeparator1"
        Me.GunaSeparator1.Size = New System.Drawing.Size(638, 32)
        Me.GunaSeparator1.TabIndex = 127
        '
        'GunaLabel29
        '
        Me.GunaLabel29.AutoSize = True
        Me.GunaLabel29.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel29.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel29.Location = New System.Drawing.Point(152, 120)
        Me.GunaLabel29.Name = "GunaLabel29"
        Me.GunaLabel29.Size = New System.Drawing.Size(64, 17)
        Me.GunaLabel29.TabIndex = 125
        Me.GunaLabel29.Text = "PACIENTE"
        '
        'GunaLabel28
        '
        Me.GunaLabel28.AutoSize = True
        Me.GunaLabel28.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel28.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel28.Location = New System.Drawing.Point(79, 120)
        Me.GunaLabel28.Name = "GunaLabel28"
        Me.GunaLabel28.Size = New System.Drawing.Size(67, 17)
        Me.GunaLabel28.TabIndex = 124
        Me.GunaLabel28.Text = "PACIENTE:"
        '
        'GunaPanel1
        '
        Me.GunaPanel1.Controls.Add(Me.GunaVSeparator2)
        Me.GunaPanel1.Controls.Add(Me.lbInicio)
        Me.GunaPanel1.Controls.Add(Me.GunaPictureBox1)
        Me.GunaPanel1.Controls.Add(Me.GunaVSeparator1)
        Me.GunaPanel1.Controls.Add(Me.btnCerrar)
        Me.GunaPanel1.Controls.Add(Me.btnMinimizar)
        Me.GunaPanel1.Controls.Add(Me.GunaImageButton1)
        Me.GunaPanel1.Location = New System.Drawing.Point(12, 12)
        Me.GunaPanel1.Name = "GunaPanel1"
        Me.GunaPanel1.Size = New System.Drawing.Size(735, 50)
        Me.GunaPanel1.TabIndex = 123
        '
        'GunaVSeparator2
        '
        Me.GunaVSeparator2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.GunaVSeparator2.LineColor = System.Drawing.Color.WhiteSmoke
        Me.GunaVSeparator2.Location = New System.Drawing.Point(500, 12)
        Me.GunaVSeparator2.Name = "GunaVSeparator2"
        Me.GunaVSeparator2.Size = New System.Drawing.Size(10, 25)
        Me.GunaVSeparator2.TabIndex = 6
        '
        'lbInicio
        '
        Me.lbInicio.AutoSize = True
        Me.lbInicio.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbInicio.Location = New System.Drawing.Point(567, 15)
        Me.lbInicio.Name = "lbInicio"
        Me.lbInicio.Size = New System.Drawing.Size(65, 20)
        Me.lbInicio.TabIndex = 5
        Me.lbInicio.Text = "Manuel"
        '
        'GunaPictureBox1
        '
        Me.GunaPictureBox1.BaseColor = System.Drawing.Color.White
        Me.GunaPictureBox1.Image = Global.Maulabs.My.Resources.Resources.icons8_verified_account_28
        Me.GunaPictureBox1.Location = New System.Drawing.Point(526, 8)
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
        Me.GunaVSeparator1.Location = New System.Drawing.Point(646, 12)
        Me.GunaVSeparator1.Name = "GunaVSeparator1"
        Me.GunaVSeparator1.Size = New System.Drawing.Size(10, 25)
        Me.GunaVSeparator1.TabIndex = 3
        '
        'btnCerrar
        '
        Me.btnCerrar.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnCerrar.Image = Global.Maulabs.My.Resources.Resources.icons8_multiply_48
        Me.btnCerrar.ImageSize = New System.Drawing.Size(16, 16)
        Me.btnCerrar.Location = New System.Drawing.Point(695, 8)
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
        Me.btnMinimizar.Location = New System.Drawing.Point(657, 8)
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
        'Frm25INMUNOLOGIA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(755, 286)
        Me.Controls.Add(Me.GunaElipsePanel1)
        Me.Controls.Add(Me.PictureBox8)
        Me.Controls.Add(Me.GunaLabel2)
        Me.Controls.Add(Me.GunaSeparator1)
        Me.Controls.Add(Me.GunaLabel29)
        Me.Controls.Add(Me.GunaLabel28)
        Me.Controls.Add(Me.GunaPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Frm25INMUNOLOGIA"
        Me.Text = "Frm25INMUNOLOGIA"
        Me.GunaElipsePanel1.ResumeLayout(False)
        Me.GunaElipsePanel1.PerformLayout()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GunaPanel1.ResumeLayout(False)
        Me.GunaPanel1.PerformLayout()
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GunaElipse1 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents GunaElipsePanel1 As Guna.UI.WinForms.GunaElipsePanel
    Friend WithEvents GunaLabel30 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel22 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel6 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txtNombreMedico As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaLabel4 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaSeparator1 As Guna.UI.WinForms.GunaSeparator
    Friend WithEvents GunaLabel29 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel28 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaPanel1 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents GunaVSeparator2 As Guna.UI.WinForms.GunaVSeparator
    Friend WithEvents lbInicio As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaPictureBox1 As Guna.UI.WinForms.GunaPictureBox
    Friend WithEvents GunaVSeparator1 As Guna.UI.WinForms.GunaVSeparator
    Friend WithEvents btnCerrar As Guna.UI.WinForms.GunaImageButton
    Friend WithEvents btnMinimizar As Guna.UI.WinForms.GunaImageButton
    Friend WithEvents GunaImageButton1 As Guna.UI.WinForms.GunaImageButton
End Class
