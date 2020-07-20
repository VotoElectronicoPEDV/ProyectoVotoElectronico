Imports System.Data.SqlClient
Public Class conexion
    Public conexion As SqlConnection = New SqlConnection("Data Source=HECTOROS\SQLEXPRESS02;Initial Catalog=SistemaNacionalDeElecciones;Integrated Security=True")
    Public lectura As SqlDataReader
    Public comando As SqlCommand


    Public Sub conectar()
        Try
            conexion.Open()
            MessageBox.Show("Conectado con exito")
        Catch ex As Exception
            MessageBox.Show("No se ha podido acceder a la base de datos")
        Finally
            conexion.Close()
        End Try
    End Sub

End Class
