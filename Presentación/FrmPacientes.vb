Imports System.Data.SqlClient
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
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        Metodo()
        Dim R As String = "insert into Pacientes ([Nombre],[Domicilio],[Telefono],[Celular],[Email],[TipoDeSangre],[fechaNac]) values ('" & txtNombre.Text & "','" & txtDomicilio.Text &
                            "','" & txtTelefono.Text & "','" & txtCelular.Text & "','" & txtEmail.Text & "','" & txtSangre.Text & "', CONVERT(DATE,'" & dtpFechaNacimiento.Text & "'))"
        Dim comando As New SqlCommand(R, conexion)
        MsgBox(R)
        comando.ExecuteNonQuery()
        Alert("REGISTRO CORRECTO", frmAlert.alertTypeEnum.Success)
        Me.Close()
    End Sub
End Class