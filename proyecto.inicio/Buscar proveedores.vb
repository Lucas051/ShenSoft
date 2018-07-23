<<<<<<< HEAD
﻿Imports MySql.Data.MySqlClient
Public Class Buscar_proveedores
    Dim resultado As DataTable
    Dim conexion As MySqlDataAdapter
    'Dim mysqlconexion As MySqlConnection = New MySqlConnection(ubicacion)

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ID.Click

    End Sub
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD

    'fail n°1 de eliminar :v
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
       
            'eliminar = "DELETE FROM proveedores WHERE num_prov= '" & TextBox1.Text & "'"
            consultar()
=======

    'fail n°1 de eliminar :v
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
       
            'eliminar = "DELETE FROM proveedores WHERE num_prov= '" & TextBox1.Text & "'"
            consultar()
>>>>>>> b9ac1fc0ad416c297c35c829e7c17ad9a49cbaf6
=======

    'fail n°1 de eliminar :v
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
       
            'eliminar = "DELETE FROM proveedores WHERE num_prov= '" & TextBox1.Text & "'"
            consultar()
>>>>>>> 62e125c36027cfa6bb4448f5a34b20b073f6979e
=======

    'fail n°1 de eliminar :v
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
       
            'eliminar = "DELETE FROM proveedores WHERE num_prov= '" & TextBox1.Text & "'"
            consultar()
>>>>>>> 62e125c36027cfa6bb4448f5a34b20b073f6979e
        conexioon.Consulta = "DELETE FROM proveedores WHERE num_prov= '" & TextBox1.Text & "'"
        consultar()
        dgvfran.DataSource = resultado



        MessageBox.Show("Dato Eliminado Correctamente.")

        conexioon.Consulta = "SELECT * FROM stock"
        consultar()
        dgvfran.DataSource = resultado

        dgvfran.Columns(0).HeaderText = "Codigo"
        dgvfran.Columns(1).HeaderText = "Proveedor"
        dgvfran.Columns(2).HeaderText = "Teléfono"
        dgvfran.Columns(3).HeaderText = "Dirección"
        dgvfran.Columns(4).HeaderText = "Saldo"
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD


    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        'Dim consulta As String
        ' Dim lista As Byte
        ' If TextBox1.Text <> "" Then
        ' consulta = "SELECT * FROM proveedores WHERE num_prov= '" & TextBox1.Text & "'"
        'conexion = New MySqlDataAdapter(consulta, ubicacion)
        'resultado = DataTable


        'aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa
    End Sub


    'intento visualizar datos en dgv. este anda cuando quiere xd

    Private Sub Buscar_proveedores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
=======


    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        'Dim consulta As String
        ' Dim lista As Byte
        ' If TextBox1.Text <> "" Then
        ' consulta = "SELECT * FROM proveedores WHERE num_prov= '" & TextBox1.Text & "'"
        'conexion = New MySqlDataAdapter(consulta, ubicacion)
        'resultado = DataTable


        'aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa
    End Sub


    'intento visualizar datos en dgv. este anda cuando quiere xd

    Private Sub Buscar_proveedores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
>>>>>>> b9ac1fc0ad416c297c35c829e7c17ad9a49cbaf6
=======


    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        'Dim consulta As String
        ' Dim lista As Byte
        ' If TextBox1.Text <> "" Then
        ' consulta = "SELECT * FROM proveedores WHERE num_prov= '" & TextBox1.Text & "'"
        'conexion = New MySqlDataAdapter(consulta, ubicacion)
        'resultado = DataTable


        'aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa
    End Sub


    'intento visualizar datos en dgv. este anda cuando quiere xd

    Private Sub Buscar_proveedores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
>>>>>>> 62e125c36027cfa6bb4448f5a34b20b073f6979e
=======


    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        'Dim consulta As String
        ' Dim lista As Byte
        ' If TextBox1.Text <> "" Then
        ' consulta = "SELECT * FROM proveedores WHERE num_prov= '" & TextBox1.Text & "'"
        'conexion = New MySqlDataAdapter(consulta, ubicacion)
        'resultado = DataTable


        'aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa
    End Sub


    'intento visualizar datos en dgv. este anda cuando quiere xd

    Private Sub Buscar_proveedores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
>>>>>>> 62e125c36027cfa6bb4448f5a34b20b073f6979e

        conexioon.Consulta = "SELECT * FROM proveedores;"
        consultar()
        dgvfran.DataSource = resultado

        dgvfran.Columns(0).HeaderText = "ID"
        dgvfran.Columns(1).HeaderText = "Proveedor"
        dgvfran.Columns(2).HeaderText = "Teléfono"
        dgvfran.Columns(3).HeaderText = "Dirección"
        dgvfran.Columns(4).HeaderText = "Saldo"
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD

    End Sub
=======

    End Sub
>>>>>>> b9ac1fc0ad416c297c35c829e7c17ad9a49cbaf6
=======

    End Sub
>>>>>>> 62e125c36027cfa6bb4448f5a34b20b073f6979e
=======

    End Sub
>>>>>>> 62e125c36027cfa6bb4448f5a34b20b073f6979e
=======
﻿Public Class Buscar_proveedores
    Private Sub Buscar_proveedores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

            conexioon.Consulta = "SELECT * FROM proveedores;"
            consultar()
            dgvfran.DataSource = resultado

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub
    Private Sub TextBox1_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        Try

            conexioon.Consulta = "SELECT * FROM proveedores WHERE nombre_prov LIKE '%" & TextBox1.Text & "%';"
            consultar()
            dgvfran.DataSource = resultado

        Catch ex As Exception

        End Try
    End Sub
>>>>>>> d19429f7d8081b4cb9859b313d55c7febe1d6b68
End Class