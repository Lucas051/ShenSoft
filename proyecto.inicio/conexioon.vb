﻿Imports MySql.Data
Imports MySql.Data.Types
Imports MySql.Data.MySqlClient
Imports System.Data.OleDb
Imports System.Data
Module conexioon
    Dim ubicacion As String = "server=localhost ; user id=root ; password=;database =proyecto"
    Public conexion As MySqlDataAdapter
    Public resultado As DataTable
    Public Consulta As String
    Public mysqlconexion As MySqlConnection = New MySqlConnection(ubicacion)

    Public Sub consultar()
        conexion = New MySqlDataAdapter(consulta, ubicacion)
        resultado = New DataTable

        conexion.Fill(resultado)





    End Sub

End Module
