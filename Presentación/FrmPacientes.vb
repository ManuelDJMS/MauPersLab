Imports System.Data.SqlClient
Public Class FrmPacientes
    Dim fecha As String
    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub btnMinimizar_Click(sender As Object, e As EventArgs) Handles btnMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        limpiar()
    End Sub
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        If txtNombre.Text <> "" Then
            Using cone As New SqlConnection(conexiontransaccion)
                cone.Open()
                Dim transaction As SqlTransaction
                transaction = cone.BeginTransaction("Sample")
                Dim comando As SqlCommand = cone.CreateCommand()
                comando.Connection = cone
                comando.Transaction = transaction
                If dtpFechaNacimiento.Text = "  -  -" Then
                    fecha = "1900-01-01"
                Else
                    fecha = dtpFechaNacimiento.Text
                End If
                Dim R As String = "insert into Pacientes ([Nombre],[Domicilio],[Telefono],[Celular],[Email],[TipoDeSangre],[FechaNac]) values ('" & txtNombre.Text & "','" & txtDomicilio.Text &
                                "','" & txtTelefono.Text & "','" & txtCelular.Text & "','" & txtEmail.Text & "','" & txtSangre.Text & "', CONVERT(DATE,'" & fecha & "'))"
                comando.CommandText = R
                MsgBox(R)
                comando.ExecuteNonQuery()
                Try
                    If MessageBox.Show("¿Desea Guardar la información?", "Guardar", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
                        transaction.Commit()
                        Alert("REGISTRO CORRECTO", frmAlert.alertTypeEnum.Success)
                        limpiar()
                    Else
                        transaction.Rollback()
                        Me.Dispose()
                    End If
                Catch ex As Exception
                    MsgBox("Commit Exception type: {0} no se pudo insertar por error", MsgBoxStyle.Critical, "Error externo al Sistema")
                    Try
                        transaction.Rollback()
                    Catch ex1 As Exception
                        MsgBox("Error RollBack", MsgBoxStyle.Critical, "Error interno del Sistema")
                    End Try
                End Try
            End Using
        Else
            MessageBox.Show("Favor de completar la información minima de registro", "Información faltante", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
    Public Sub limpiar()
        txtNombre.Text = ""
        txtCelular.Text = ""
        txtDomicilio.Text = ""
        txtEmail.Text = ""
        txtSangre.Text = ""
        txtTelefono.Text = ""
        dtpFechaNacimiento.Text = ""
    End Sub

    Private Sub txtTelefono_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTelefono.KeyPress, txtCelular.KeyPress
        If Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
End Class