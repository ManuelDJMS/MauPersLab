Public Class FrmPacientes
    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub btnMinimizar_Click(sender As Object, e As EventArgs) Handles btnMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        txtNombre.Text = ""
        txtCelular.Text = ""
        txtDomicilio.Text = ""
        txtEmail.Text = ""
        txtSangre.Text = ""
        txtTelefono.Text = ""
    End Sub
End Class