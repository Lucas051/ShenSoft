Imports MySql.Data
Imports MySql.Data.Types
Imports MySql.Data.MySqlClient
Module conexion
    Public conn As New MySqlConnection("server=localhost; user=root; password=; database=proyecto; port=3306")

    Public Sub conexion()
        Try
            conn.Open()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Public Function consultar(ByVal sql As String) As DataSet
        Dim ds As New DataSet

        Try
            Dim reader As New MySqlDataAdapter(sql, conn)
            reader.Fill(ds, "Historial")
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        Return ds
    End Function
End Module
