Imports System.Data.SqlClient
Public Class FrmMedicos
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Using cone As New SqlConnection(conexiontransaccion)
            cone.Open()
            Dim transaction As SqlTransaction
            transaction = cone.BeginTransaction("Sample")
            Dim comando As SqlCommand = cone.CreateCommand()
            comando.Connection = cone
            comando.Transaction = transaction
            If txtNombreMedico.Text <> "" Or txtNombreMedico.Text <> " " Then
                Dim R As String = "insert into Medicos ([Nombre],[Hospital],[Telefono],[Email]) values ('" & txtNombreMedico.Text & "','" & txtxHospital.Text & "','" & txtTelefono.Text & "', '" & txtEmail.Text & "')"
                comando.CommandText = R
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
            Else
                MessageBox.Show("Favor de ingresar un Nombre antes de guardar", "Información faltante", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End Using
    End Sub
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        limpiar()
    End Sub
    Private Sub btnMinimizar_Click(sender As Object, e As EventArgs) Handles btnMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub
    Public Sub limpiar()
        txtNombreMedico.Text = ""
        txtxHospital.Text = ""
        txtTelefono.Text = ""
        txtEmail.Text = ""
    End Sub
End Class