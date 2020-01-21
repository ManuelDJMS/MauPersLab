Imports System.Data.SqlClient
Public Class FrmSolicitudes
    Dim isCollapsed As Boolean = True
    Dim panelselect As Integer
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Select Case panelselect
            Case 1
                Tiempo(isCollapsed, PanelQuimicaSan)
            Case 2
                Tiempo(isCollapsed, PanelQuimicaClinica)
            Case 3
                'Return "tres"
            Case 4
                'Return "cuatro"
            Case 5
                'Return "cinco"
            Case Else
                'Return "error"
        End Select
    End Sub

    Private Sub GunaButton1_Click(sender As Object, e As EventArgs) Handles GunaButton1.Click
        Timer1.Start()
        panelselect = 1
    End Sub

    Public Sub Tiempo(ByVal bandera As Boolean, ByVal panel As Panel)
        '=========================================== METODO SABER SI ESTA ABIERTO UN PANEL O NO ================================================================
        If isCollapsed Then
            panel.Height += 10
            If panel.Size = panel.MaximumSize Then
                Timer1.Stop()
                isCollapsed = False
            End If
        Else
            panel.Height -= 15
            If panel.Size = panel.MinimumSize Then
                Timer1.Stop()
                isCollapsed = True
            End If
        End If
    End Sub

    Private Sub GunaButton2_Click(sender As Object, e As EventArgs) Handles GunaButton2.Click
        Timer1.Start()
        panelselect = 2
    End Sub

    Private Sub Seleccion(ByVal check As Guna.UI.WinForms.GunaCheckBox)
        '============================================================== METODO PARA SELECCIONAR Y MANDAR AL DATAGRID LOS ESTUDIOS ========================================================
        Dim ban As Boolean
        Dim posicionborrar As Integer
        For i = 0 To dgEstudios.Rows.Count - 1
            If check.Text = dgEstudios.Rows(i).Cells(0).Value Then
                posicionborrar = dgEstudios.Rows(i).Index
                ban = True
                Exit For
            End If
        Next
        For i = 0 To dgEstudios.Rows.Count - 1
            If ban = True Then
                dgEstudios.Rows.RemoveAt(posicionborrar)
                posicionborrar = 0
                ban = False
                SumarDatagrid(dgEstudios, txtSubtotal)
                Exit For
            Else
                Metodo()
                R = "select Descripcion, Precio from DetalleCategorias where Descripcion='" & check.Text & "'"
                comando = conexion.CreateCommand
                comando.CommandText = R
                lector = comando.ExecuteReader
                lector.Read()
                dgEstudios.Rows.Add(lector(0), lector(1))
                lector.Close()
                conexion.Close()
                SumarDatagrid(dgEstudios, txtSubtotal)
                Exit For
            End If
        Next
    End Sub

    Private Sub ckBilirrubina_CheckedChanged(sender As Object, e As EventArgs) Handles ckBilirrubina.CheckedChanged
        Seleccion(ckBilirrubina)
    End Sub

    Private Sub GunaCheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles GunaCheckBox2.CheckedChanged
        Seleccion(GunaCheckBox2)
    End Sub

    Private Sub PanelMover_MouseMove(sender As Object, e As MouseEventArgs) Handles PanelMover.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub btnMinimizar_Click(sender As Object, e As EventArgs) Handles btnMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        dgEstudios.Rows.Clear()
        'txtNombre.Text = ""
        'txtMedico.Text = ""
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        'Dim fechaActual As DateTime
        'If dgEstudios.Rows.Count = 0 Then
        '    MsgBox("Falta agregar el usuario que realizo la cotización¡", MsgBoxStyle.Critical)
        'Else
        '    Try
        '        fechaActual = Convert.ToDateTime(dtpFecha.Text).ToShortDateString
        '        Using conexion As New SqlConnection(conexiontransaccion)
        '            conexion.Open()
        '            Dim transaction As SqlTransaction
        '            transaction = conexion.BeginTransaction("Sample")
        '            Dim comando As SqlCommand = conexion.CreateCommand()
        '            Dim lector As SqlDataReader
        '            comando.Connection = conexion
        '            comando.Transaction = transaction
        '            '**************************************************** COTIZACION NORMAL *************************************************************************************
        '            'Else

        '            R = "insert into Solicitudes (idPaciente, idEmpleado, Fecha, Total)
        '            values (" & Val(txtCveContacto.Text) & ",'" & origen & "'," & Val(cboServicio.Tag) & "," & Val(Cbcuando.Tag) & "," & Val(CbModalidad.Tag) & "," & Val(CboTiempo.Tag) & "," &
        '                        Val(CCondPago.Tag) & "," & Val(CboLeyenda.Tag) & "," & Val(CboValidez.Tag) & "," & Val(CboMoneda.Tag) & "," & Val(ComboDocCond.Tag) & "," & Val(CboContabilizar.Tag) & ",'" &
        '                        txtReferencia.Text & "','" & fechaActual & "','" & fecharecepcion & "','" & txtObservaciones.Text & "','" & usuario & "'," & subtotal & "," & iva & "," & Total & ",0)"
        '            comando.CommandText = R
        '            comando.ExecuteNonQuery()
        '            'End If
        '            '============================================================================================================================================================================================
        '            '========================================================== SACAR EL ULTIMO REGISTRO DE SOLICITUDES PARA EL DETALLE DE COTIZACION =============================================================
        '            R = "select MAX(Numcot) from [Cotizaciones]"
        '            comando.CommandText = R
        '            lector = comando.ExecuteReader
        '            lector.Read()
        '            If ((lector(0) Is DBNull.Value) OrElse (lector(0) Is Nothing)) Then
        '                maximo = 1
        '            Else
        '                maximo = lector(0)
        '            End If
        '            lector.Close()
        '            '============================================================================================================================================================================================
        '            '===================================================================== INSERTAR EN DETALLE DE COTIZACIONES===================================================================================
        '            For i = 0 To DGCopia.Rows.Count - 2
        '                If DGCopia.Item(3, i).Value.ToString = "GENERICO" Or DGCopia.Item(3, i).Value.ToString = "Generico" Or DGCopia.Item(3, i).Value.ToString = "Genérico" Then
        '                    marcaGen = InputBox("¿Deseas agregar la marca del articulo: """ & DGCopia.Item(2, i).Value.ToString & """?", "Marca")
        '                    modGen = InputBox("¿Deseas agregar el modelo del articulo: """ & DGCopia.Item(2, i).Value.ToString & """?", "Modelo")
        '                    If marcaGen = "" Or marcaGen = "-" Then
        '                        marcaGen = ""
        '                    Else
        '                        marcaGen = " Marca: " & marcaGen
        '                    End If
        '                    If modGen = "" Or modGen = "-" Then
        '                        modGen = ""
        '                    Else
        '                        modGen = " Modelo: " & modGen
        '                    End If
        '                    observacion = observacion + marcaGen + modGen
        '                End If
        '                R = "insert into DetalleCotizaciones (NumCot,EquipId, PartidaNo,Cantidad, CantidadReal, identificadorInventarioCliente, Serie, Observaciones, ObservacionesServicios) values (" &
        '                         maximo & "," & DGCopia.Item(0, i).Value & "," & Val(DGCopia.Item(1, i).Value) & ",
        '                 " & Val(DGCopia.Item(5, i).Value) & "," & Val(DGCopia.Item(5, i).Value) & ",'" & (DGCopia.Item(9, i).Value) & "','" & (DGCopia.Item(10, i).Value) & "','" & (DGCopia.Item(7, i).Value) + observacion & "','" & (DGCopia.Item(11, i).Value) & "')"
        '                comando.CommandText = R
        '                comando.ExecuteNonQuery()
        '                marcaGen = ""
        '                modGen = ""
        '                observacion = ""
        '            Next i      '============================================================================================================================================================================================
        '            Try
        '                If MessageBox.Show("¿Desea Guardar la información?", "Guardar", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
        '                    transaction.Commit()
        '                    MsgBox("La Cotización se guardó correctamente", MsgBoxStyle.Information, "Guardado Exitoso")
        '                    FrmCotizacion.DgAgregar.Rows.Clear()
        '                    Me.Dispose()
        '                Else
        '                    transaction.Rollback()
        '                    Me.Dispose()
        '                End If
        '            Catch ex As Exception
        '                MsgBox("Commit Exception type: {0} no se pudo insertar por error", MsgBoxStyle.Critical, "Error externo al Sistema")
        '                Try
        '                    transaction.Rollback()
        '                Catch ex1 As Exception
        '                    MsgBox("Error RollBack", MsgBoxStyle.Critical, "Error interno del Sistema")
        '                End Try
        '                End Try66
        '            conexion.Close()
        '        End Using
        '    Catch ex As Exception
        '        MsgBox(ex.Message, MsgBoxStyle.Critical, "Error del Sistema")
        '    End Try
        'End If
    End Sub



    Private Sub TextNombre_TextChanged(sender As Object, e As EventArgs)
        Metodo()
        'conex.Open()
        'Dim R As String
        R = "select top 10 Nombre from [Pacientes] where Nombre like '" & TextNombre.Text & "%'"
        Dim comando As New SqlCommand(R, conexion)
        comando.CommandType = CommandType.Text
        Dim da As New SqlDataAdapter(comando)
        Dim dt As New DataTable
        da.Fill(dt)
        dgnombres.DataSource = dt
        da.Dispose()
        conexion.Close()
        TextNombre.AutoCompleteCustomSource.Add(dgnombres.SelectedCells.Item(0).Value)
    End Sub

    Private Sub CboPaciente_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboPaciente.SelectedIndexChanged
        seleccionarcombo("select idPaciente from Pacientes where Nombre='" & CboPaciente.Text & "'", CboPaciente)
    End Sub

    Private Sub CboPaciente_TextChanged(sender As Object, e As EventArgs) Handles CboPaciente.TextChanged
        llenarcombo("select top 10 idPaciente, Nombre from Pacientes where Nombre like '" & CboPaciente.Text & "%'", CboPaciente)
    End Sub
    Sub seleccionarcombo(ByVal query As String, ByVal combo As ComboBox)
        'Try
        Metodo()
        comando = conexion.CreateCommand
        '-----------------Combo moneda ------------------------
        comando.CommandText = query
        'MsgBox(comando.CommandText)
        lector = comando.ExecuteReader
        lector.Read()
        combo.Tag = lector(0)
        MsgBox(combo.Tag)
        lector.Close()
        'Catch ex As Exception
        '    MsgBox("Ocurrio un error en la lectura de datos de LIMS.", MsgBoxStyle.Exclamation)
        'End Try
    End Sub
    Sub llenarcombo(ByVal query As String, ByVal combo As ComboBox)
        '=============================================== METODO PARA LLENAR LOS COMBOS ===================================================
        Metodo()
        comando = conexion.CreateCommand
        comando.CommandText = query
        lector = comando.ExecuteReader
        While lector.Read()
            combo.Items.Add(lector(1))
        End While
        lector.Close()
        comando.CommandText = query
        'lector = comando.ExecuteReader
        'lector.Read()
        'combo.Tag = lector(0)
        'lector.Close()
    End Sub
End Class