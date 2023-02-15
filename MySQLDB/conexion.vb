Imports MySql.Data.MySqlClient
Module conexion
    Public cnn As MySqlConnection
    Public key As String = "abc"
    Public enunciado As MySqlCommand
    Public respuesta As MySqlDataReader
    Public userName As String = "Usuario"
    Sub Abrir()
        Try
            cnn = New MySqlConnection("Server=localhost;Database=proyectoplanillaspp1;User id=root;Password=Galaxi12;Port=3306")
            cnn.Open()
            'MsgBox("Conectado")
        Catch ex As Exception
            MsgBox("No se puede conectar, favor intentar mas tarde..." + ex.ToString)
        End Try
    End Sub
End Module