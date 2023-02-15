Imports MySql.Data.MySqlClient
Imports System.Net.Mail
Imports System.Runtime.InteropServices
Imports System.Security.Cryptography
Imports System.Text
Public Class frmRecuperarContra
    Dim cmd As MySqlCommand
    Dim des As New TripleDESCryptoServiceProvider
    Dim MD5 As New MD5CryptoServiceProvider
    Private nuevaContra As String
    Function MD5Hash(ByVal value As String) As Byte()
        Return MD5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(value))
    End Function

    Function Encrypt(ByVal stringInput As String, ByVal key As String) As String
        des.Key = MD5Hash(key)
        des.Mode = CipherMode.ECB
        Dim buffer As Byte() = ASCIIEncoding.ASCII.GetBytes(stringInput)
        Return Convert.ToBase64String(des.CreateEncryptor().TransformFinalBlock(buffer, 0, buffer.Length))
    End Function

    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParm As Integer)
    End Sub

    Private Sub panelCabecera_MouseMove(sender As Object, e As MouseEventArgs) Handles panelCabecera.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112%, &HF012&, 0)
    End Sub
    Private Sub btnMinimizar_Click(sender As Object, e As EventArgs) Handles btnMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Function generarContraRandom() As Integer
        Dim numeroAleatorio As New Random()
        Dim valorAleatorio As Integer = numeroAleatorio.Next(100000, 999999)
        Return valorAleatorio
    End Function

    Private Sub actualizarClave(ByVal correo As String)
        Try
            Abrir()
            cmd = New MySqlCommand("Update Usuarios set contraseña=@contraseña where correo = @correo", cnn)
            cmd.Parameters.AddWithValue("@contraseña", Encrypt(nuevaContra, key))
            cmd.Parameters.AddWithValue("@correo", correo)
            cmd.ExecuteNonQuery()
            MsgBox("Correcto")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub frmRecuperarContra_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnEnviar_Click(sender As Object, e As EventArgs) Handles btnEnviar.Click
        Try
            Abrir()
            cmd = New MySqlCommand("select usuarios.correo from usuarios where usuarios.correo = @correo", cnn)
            cmd.Parameters.AddWithValue("@correo", txtCorreo.Text.Trim)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()
            reader.Read()
            If reader.HasRows Then
                nuevaContra = generarContraRandom().ToString()
                Dim correo As New MailMessage()
                Dim smtp As New SmtpClient
                correo.From = New MailAddress("soporteplanillasbreak@gmail.com", "Soporte Break", System.Text.Encoding.UTF8)
                correo.To.Add(txtCorreo.Text.Trim)
                correo.SubjectEncoding = System.Text.Encoding.UTF8
                correo.Subject = "Recuperacion de contraseña"
                correo.Body = nuevaContra
                correo.BodyEncoding = System.Text.Encoding.UTF8
                correo.IsBodyHtml = False
                correo.Priority = MailPriority.High
                smtp.Host = "smtp.gmail.com"
                smtp.Port = 587
                smtp.EnableSsl = True
                smtp.Credentials = New System.Net.NetworkCredential("soporteplanillasbreak@gmail.com", "xupkboldrpcmgkdo")
                Try
                    smtp.Send(correo)
                    MsgBox("Se envio la nueva contraseña a su correo")
                    actualizarClave(txtCorreo.Text.Trim)
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            Else
                MsgBox("Datos incorrectos")
            End If
        Catch ex As Exception
            MsgBox("No se conecto por: " & ex.Message)
        End Try
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Hide()
        frmLogin.Show()
    End Sub

    Private Sub lblNombreForm_MouseMove(sender As Object, e As MouseEventArgs) Handles lblNombreForm.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112%, &HF012&, 0)
    End Sub

    Private Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        Me.Hide()
        frmLogin.Show()
    End Sub
End Class