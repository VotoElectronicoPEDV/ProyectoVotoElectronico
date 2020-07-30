Imports System.Data.SqlClient
Public Class conexion
    Public conexion As SqlConnection = New SqlConnection("Data Source=localhost\MSSQLSERVER01;Initial Catalog=SistemaNacionalDeElecciones;Integrated Security=True")
    Public ds As DataSet = New DataSet()
    Public da As SqlDataAdapter
    Public lectura As SqlDataReader
    Public comando As SqlCommand
    Public cmd As New SqlCommand

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
    Public Function ingresarFoto(identidad As String, imagen As Image) As Boolean
        Try
            conexion.Open()
            Dim cmd As New SqlCommand("ingresarFoto", conexion)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@imagen", ImagenToByte(imagen))
            cmd.Parameters.AddWithValue("@identidad", identidad)
            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            conexion.Close()
        End Try
    End Function
    'Crud de presidente
    Public Function consultarPresidente()
        Try
            conexion.Open()
            Dim cmd As New SqlCommand("consultarPresidente", conexion)

            cmd.CommandType = CommandType.StoredProcedure
            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
                Return dt
                conexion.Close()
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            conexion.Close()
        End Try
    End Function

    Public Function ingresarPresidente(identidad As String, primerNombre As String, SegundoNombre As String, PrimerApellido As String,
                                         SegundoApellido As String, estado As String, partido As Integer) As Boolean
        Try
            conexion.Open()
            cmd = New SqlCommand("ingresarPresidente", conexion)
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.AddWithValue("@IdentidadPresidente", identidad)
            cmd.Parameters.AddWithValue("@PrimerNombre", primerNombre)
            cmd.Parameters.AddWithValue("@SegundoNombre", SegundoNombre)
            cmd.Parameters.AddWithValue("@PrimerApellido", PrimerApellido)
            cmd.Parameters.AddWithValue("@SegundoApellido", SegundoApellido)
            cmd.Parameters.AddWithValue("@Estado", estado)
            cmd.Parameters.AddWithValue("@idPartido", partido)

            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            conexion.Close()
        End Try
    End Function

    Public Function actualizarPresidente(identidad As String, primerNombre As String, SegundoNombre As String, PrimerApellido As String,
                                         SegundoApellido As String, partido As Integer) As Boolean
        Try
            conexion.Open()
            cmd = New SqlCommand("actualizarPresidente", conexion)
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.AddWithValue("@IdentidadPresidente", identidad)
            cmd.Parameters.AddWithValue("@PrimerNombre", primerNombre)
            cmd.Parameters.AddWithValue("@SegundoNombre", SegundoNombre)
            cmd.Parameters.AddWithValue("@PrimerApellido", PrimerApellido)
            cmd.Parameters.AddWithValue("@SegundoApellido", SegundoApellido)
            cmd.Parameters.AddWithValue("@partido", partido)

            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            conexion.Close()
        End Try
    End Function

    Public Function eliminarPresidente(identidad As String) As Boolean
        Try
            conexion.Open()
            cmd = New SqlCommand("eliminarPresidente", conexion)
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.AddWithValue("@identidadPresidente", identidad)

            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            conexion.Close()
        End Try
    End Function

    'Crud de Alcalde

    Public Function consultarAlcalde()
        Try
            conexion.Open()
            Dim cmd As New SqlCommand("consultarAlcalde", conexion)

            cmd.CommandType = CommandType.StoredProcedure
            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
                Return dt
                conexion.Close()
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            conexion.Close()
        End Try
    End Function
    Public Function ingresarAlcalde(identidad As String, primerNombre As String, SegundoNombre As String, PrimerApellido As String,
                                         SegundoApellido As String, descripcionVotacion As String, estado As String, partido As Integer, municipio As String) As Boolean
        Try
            conexion.Open()
            cmd = New SqlCommand("ingresarAlcalde", conexion)
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.AddWithValue("@identidadAlcalde", identidad)
            cmd.Parameters.AddWithValue("@PrimerNombre", primerNombre)
            cmd.Parameters.AddWithValue("@SegundoNombre", SegundoNombre)
            cmd.Parameters.AddWithValue("@PrimerApellido", PrimerApellido)
            cmd.Parameters.AddWithValue("@SegundoApellido", SegundoApellido)
            cmd.Parameters.AddWithValue("@DescripcionVotacion", descripcionVotacion)
            cmd.Parameters.AddWithValue("@Estado", estado)
            cmd.Parameters.AddWithValue("@Partido", partido)
            cmd.Parameters.AddWithValue("@Municipio", municipio)

            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            conexion.Close()
        End Try
    End Function

    Public Function actualizarAlcalde(identidad As String, primerNombre As String, SegundoNombre As String, PrimerApellido As String,
                                         SegundoApellido As String, partido As Integer) As Boolean
        Try
            conexion.Open()
            cmd = New SqlCommand("actualizarAlcalde", conexion)
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.AddWithValue("@identidadAlcalde", identidad)
            cmd.Parameters.AddWithValue("@PrimerNombre", primerNombre)
            cmd.Parameters.AddWithValue("@SegundoNombre", SegundoNombre)
            cmd.Parameters.AddWithValue("@PrimerApellido", PrimerApellido)
            cmd.Parameters.AddWithValue("@SegundoApellido", SegundoApellido)
            cmd.Parameters.AddWithValue("@Partido", partido)

            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            conexion.Close()
        End Try
    End Function

    Public Function eliminarAlcalde(identidad As String) As Boolean
        Try
            conexion.Open()
            cmd = New SqlCommand("eliminarAlcalde", conexion)
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.AddWithValue("@identidadAlcalde", identidad)

            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            conexion.Close()
        End Try
    End Function

    'Crud De Diputado
    Public Function consultarDiputado()
        Try
            conexion.Open()
            Dim cmd As New SqlCommand("consultarDiputado", conexion)

            cmd.CommandType = CommandType.StoredProcedure
            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
                Return dt
                conexion.Close()
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            conexion.Close()
        End Try
    End Function
    Public Function ingresarDiputado(identidad As String, primerNombre As String, SegundoNombre As String, PrimerApellido As String,
                                         SegundoApellido As String, estado As String, partido As Integer, Departamento As String) As Boolean
        Try
            conexion.Open()
            cmd = New SqlCommand("ingresarDiputado", conexion)
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.AddWithValue("@identidadDiputado", identidad)
            cmd.Parameters.AddWithValue("@PrimerNombre", primerNombre)
            cmd.Parameters.AddWithValue("@SegundoNombre", SegundoNombre)
            cmd.Parameters.AddWithValue("@PrimerApellido", PrimerApellido)
            cmd.Parameters.AddWithValue("@SegundoApellido", SegundoApellido)
            cmd.Parameters.AddWithValue("@Estado", estado)
            cmd.Parameters.AddWithValue("@partido", partido)
            cmd.Parameters.AddWithValue("@Departamento", Departamento)

            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            conexion.Close()
        End Try
    End Function

    Public Function actualizarDiputado(identidad As String, primerNombre As String, SegundoNombre As String, PrimerApellido As String,
                                         SegundoApellido As String, partido As Integer) As Boolean
        Try
            conexion.Open()
            cmd = New SqlCommand("actualizarDiputado", conexion)
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.AddWithValue("@identidadDiputado", identidad)
            cmd.Parameters.AddWithValue("@PrimerNombre", primerNombre)
            cmd.Parameters.AddWithValue("@SegundoNombre", SegundoNombre)
            cmd.Parameters.AddWithValue("@PrimerApellido", PrimerApellido)
            cmd.Parameters.AddWithValue("@SegundoApellido", SegundoApellido)
            cmd.Parameters.AddWithValue("@partido", partido)

            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            conexion.Close()
        End Try
    End Function

    Public Function eliminarDiputado(identidad As String) As Boolean
        Try
            conexion.Open()
            cmd = New SqlCommand("eliminarDiputado", conexion)
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.AddWithValue("@identidadDiputado", identidad)

            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            conexion.Close()
        End Try
    End Function

    'Crud De Votante
    Public Function consultarVotante()
        Try
            conexion.Open()
            Dim cmd As New SqlCommand("consultarVotante", conexion)

            cmd.CommandType = CommandType.StoredProcedure
            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)

                Return dt
                conexion.Close()
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            conexion.Close()
        End Try
    End Function
    Public Function IngresarVotante(identidad As String, primerNombre As String, SegundoNombre As String, PrimerApellido As String,
                                         SegundoApellido As String, edad As Integer, sexo As String, estadoVotante As String) As Boolean
        Try
            conexion.Open()
            cmd = New SqlCommand("IngresarVotante", conexion)
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.AddWithValue("@IdentidadVotante", identidad)
            cmd.Parameters.AddWithValue("@PrimerNombre", primerNombre)
            cmd.Parameters.AddWithValue("@SegundoNombre", SegundoNombre)
            cmd.Parameters.AddWithValue("@PrimerApellido", PrimerApellido)
            cmd.Parameters.AddWithValue("@SegundoApellido", SegundoApellido)
            cmd.Parameters.AddWithValue("@edad", edad)
            cmd.Parameters.AddWithValue("@sexo", sexo)
            cmd.Parameters.AddWithValue("@estadoVotante", estadoVotante)

            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            conexion.Close()
        End Try
    End Function

    Public Function actualizarVotante(identidad As String, primerNombre As String, SegundoNombre As String, PrimerApellido As String,
                                         SegundoApellido As String) As Boolean
        Try
            conexion.Open()
            cmd = New SqlCommand("actualizarVotante", conexion)
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.AddWithValue("@IdentidadVotante", identidad)
            cmd.Parameters.AddWithValue("@PrimerNombre", primerNombre)
            cmd.Parameters.AddWithValue("@SegundoNombre", SegundoNombre)
            cmd.Parameters.AddWithValue("@PrimerApellido", PrimerApellido)
            cmd.Parameters.AddWithValue("@SegundoApellido", SegundoApellido)


            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            conexion.Close()
        End Try
    End Function

    Public Function eliminarVotante(identidad As String) As Boolean
        Try
            conexion.Open()
            cmd = New SqlCommand("eliminarVotante", conexion)
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.AddWithValue("@IdentidadVotante", identidad)

            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            conexion.Close()
        End Try
    End Function

    'Funcion para recuperar y validar los datos del Votante
    Public Function RecuperarDatos(ByVal identidad As String, ByVal columna As Integer)
        Dim texto As String
        Try
            conexion.Open()
            cmd = New SqlCommand("validarVotante", conexion)
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.AddWithValue("@IdentidadVotante", identidad)
            lectura = cmd.ExecuteReader()

            If lectura.Read() Then
                texto = lectura(columna).ToString()
                Return texto
            Else
                Return Nothing
            End If
            lectura.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            conexion.Close()
        End Try
    End Function
    Public Function validaradministrador(ByVal identidad As String, ByVal columna As Integer)
        Dim texto As String
        Try
            conexion.Open()
            cmd = New SqlCommand("validaradministrador", conexion)
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.AddWithValue("@identidad", identidad)
            lectura = cmd.ExecuteReader()

            If lectura.Read() Then
                texto = lectura(columna).ToString()
                Return texto
            Else
                Return Nothing
            End If
            lectura.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            conexion.Close()
        End Try
    End Function


    Public Function recuperarMunicipio(ByVal municipio As String, ByVal columna As Integer)
        Dim texto As String
        Try
            conexion.Open()
            cmd = New SqlCommand("recuperarMunicipio", conexion)
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.AddWithValue("@municipio", municipio)
            lectura = cmd.ExecuteReader()

            If lectura.Read() Then
                texto = lectura(columna).ToString()
                Return texto
            Else
                Return Nothing
            End If
            lectura.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            conexion.Close()
        End Try
    End Function
    Public Function alcaldesInterna(municipio As String)
        Try
            conexion.Open()
            Dim cmd As New SqlCommand("alcaldesInterna", conexion)

            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.AddWithValue("@municipio", municipio)
            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
                Return dt
                conexion.Close()
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            conexion.Close()
        End Try
    End Function

    Public Function votacionInterna(identidadVotante As String, identidadAlcalde As String) As Boolean
        Try
            conexion.Open()
            Dim cmd As New SqlCommand("votacionInterna", conexion)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@identidad", identidadVotante)
            cmd.Parameters.AddWithValue("@candidatoAlcalde", identidadAlcalde)
            If cmd.ExecuteNonQuery Then
                Return True
                conexion.Close()
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            conexion.Close()
        End Try
    End Function

    Public Function diputadoExterna()
        Try
            conexion.Open()
            Dim cmd As New SqlCommand("diputadoExterna", conexion)

            cmd.CommandType = CommandType.StoredProcedure

            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
                Return dt
                conexion.Close()
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            conexion.Close()
        End Try
    End Function

    Public Function PresidenteExterna()
        Try
            conexion.Open()
            Dim cmd As New SqlCommand("PresidenteExterna", conexion)

            cmd.CommandType = CommandType.StoredProcedure

            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
                Return dt
                conexion.Close()
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            conexion.Close()
        End Try
    End Function
    Public Function votacionExterna(idVotante As String, idAlcalde As String, idDiputado1 As String, idDiputado2 As String,
                                     idDiputado3 As String, idDiputado4 As String, idDiputado5 As String, idDiputado6 As String,
                                     idDiputado7 As String, idDiputado8 As String, idDiputado9 As String, idPresidente As String) As Boolean
        Try
            conexion.Open()
            Dim cmd As New SqlCommand("votacionExterna", conexion)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@identidad", idVotante)
            cmd.Parameters.AddWithValue("@candidatoAlcalde", idAlcalde)
            cmd.Parameters.AddWithValue("@candidatodiputado1", idDiputado1)
            cmd.Parameters.AddWithValue("@candidatodiputado2", idDiputado2)
            cmd.Parameters.AddWithValue("@candidatodiputado3", idDiputado3)
            cmd.Parameters.AddWithValue("@candidatodiputado4", idDiputado4)
            cmd.Parameters.AddWithValue("@candidatodiputado5", idDiputado5)
            cmd.Parameters.AddWithValue("@candidatodiputado6", idDiputado6)
            cmd.Parameters.AddWithValue("@candidatodiputado7", idDiputado7)
            cmd.Parameters.AddWithValue("@candidatodiputado8", idDiputado8)
            cmd.Parameters.AddWithValue("@candidatodiputado9", idDiputado9)
            cmd.Parameters.AddWithValue("@candidatopresidente", idPresidente)
            If cmd.ExecuteNonQuery Then
                Return True
                conexion.Close()
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            conexion.Close()
        End Try
    End Function

    Public Function cambioVotacion() As Boolean
        Try
            conexion.Open()
            Dim cmd As New SqlCommand("cambioVotacion", conexion)

            cmd.CommandType = CommandType.StoredProcedure
            If cmd.ExecuteNonQuery Then
                Return True
                conexion.Close()
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            conexion.Close()
        End Try
    End Function


End Class
