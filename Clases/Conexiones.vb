Imports System.Data.SqlClient
Module Conexiones
    '-----------------------------Variables para la conexion con bases de Datos LIMS-------------------------------------------
    Public conexion As SqlConnection
    Public comando As SqlCommand
    Public lector As SqlDataReader
    Public adapter As SqlDataAdapter
    Public datatable As DataTable
    '================================================VARIABLE PARA UTILIZAR LA TRANSACCION DEL LIMS=========================================================================
    'Public conexiontransac As String = ("Data Source=PC92-L\SISTEMAS;Initial Catalog=MAULABS; Integrated Security=True")

    Public conexiontransaccion As String = ("Data Source=DESKTOP-0BBE1FU\SQLEXPRESS;Initial Catalog=MAULABS; Integrated Security=True")
    'Public conexionLIMStransac As String = ("Data Source=DATABASESERVER\COMPAC;Initial Catalog=MetAs_Live-pruebas; User Id=sa; Password=Contpaq1;Integrated Security=False")
    'Public conexiontransaccion As String = ("Data Source=DESKTOP-0BBE1FU\SQLEXPRESS;Initial Catalog=MAULABS; Integrated Security=true")

    '=======================================================================================================================================================================
    '------------------------------------------------------------------------CONEXIONES A BASES DE DATOS-------------------------------------------------------------------------------------------
    Sub Metodo()
        'Try
        'conexionLIMS = New SqlConnection("Data Source=107.180.70.168\METASSQLEXPRESS;Initial Catalog=MetAs_Live;Persist Security Info=False;User ID=sa;Password=Bws123bws")
        'conexion = New SqlConnection("Data Source=DESKTOP-0BBE1FU\SQLEXPRESS;Initial Catalog=MAULABS; Integrated Security=true")
        conexion = New SqlConnection("Data Source=DESKTOP-0BBE1FU\SQLEXPRESS;Initial Catalog=MAULABS; Integrated Security=True")
        'conexionLIMS = New SqlConnection("Data Source=185.166.213.202;Initial Catalog=MetAs_Live; User Id=sa; Password=Met99011578a;Integrated Security=False")
        conexion.Open()
        'Catch ex As Exception
        '    MsgBox("No se pudo conectar a la base de datos" + ex.ToString)
        'End Try
    End Sub
End Module
