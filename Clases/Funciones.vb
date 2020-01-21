Imports System.Data.SqlClient
Imports System.Runtime.InteropServices
Module Funciones
    '================================================================== VARIABLES GLOBALES ==================================================================================================
    Public cadena As String 'Variable que almacena el string de errores para la bitacora
    Public idusuario As Integer
    Public R As String 'Variable de los select´s
    '========================================================================================================================================================================================
    '================================================== CODIGO PARA INSERTAR ERRORES EN LA BASE DE DATOS DE BITACORA ========================================================================
    Public Sub Bitacora(Formulario As String, Evento As String, error1 As String, Descripcion As String)
        Try
            Dim conexionbit As New SqlConnection("Data Source=SERVER3\COMPAC2;Initial Catalog=Bitacora; User Id=sa; Password=Met99011578a;Integrated Security=False")
            conexionbit.Open()
            Dim comando As SqlCommand = conexionbit.CreateCommand()
            Dim r As String
            Dim I As Integer
            Dim x As String
            x = "'"
            For I = 1 To Len(error1)
                If Mid(error1, I, 1) = Chr(39) Then
                    x = x & "'"
                Else
                    x = x & Mid(error1, I, 1)
                End If
            Next
            error1 = x
            r = "insert into Resultados(Formulario, Evento, Error, Descripcion, Fecha) values ('" & Formulario & "','" & Evento & "'," & error1 & "','" & Descripcion & "', getdate())"
            comando.CommandText = r
            comando.ExecuteNonQuery()
            conexionbit.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error del Sistema")
        End Try
    End Sub
    '========================================================================================================================================================================================
    '================================================== CODIGO PARA SUMAR PRECIOS EN DATAGRIDS ========================================================================
    Public Sub SumarDatagrid(ByRef dg As Guna.UI.WinForms.GunaDataGridView, ByVal txtsuma As Guna.UI.WinForms.GunaTextBox)
        Dim subtotal As Decimal
        For Each fila In dg.Rows
            subtotal += Convert.ToDecimal(fila.Cells("precioUnitario").Value)
        Next
        txtsuma.Text = subtotal
    End Sub
    '========================================================================================================================================================================================
    '================================================== METOOS PARA ARRASTRAR UN FORMULARIO ========================================================================
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Public Sub ReleaseCapture()
    End Sub

    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Public Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub
    '========================================================================================================================================================================================
End Module
