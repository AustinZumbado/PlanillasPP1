Imports MySql.Data.MySqlClient
Imports System.Runtime.InteropServices
Imports System.Security.Cryptography
Imports System.Text
Imports System.Text.RegularExpressions

Public Class frmRegistro
    Dim cmd As MySqlCommand
    Dim des As New TripleDESCryptoServiceProvider
    Dim MD5 As New MD5CryptoServiceProvider
    Dim nombreCheak As Integer = 0
    Dim contraCheak As Integer = 0
    Dim correoCheak As Integer = 0

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

    Function MD5Hash(ByVal value As String) As Byte()
        Return MD5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(value))
    End Function

    Function Encrypt(ByVal stringInput As String, ByVal key As String) As String
        des.Key = MD5Hash(key)
        des.Mode = CipherMode.ECB
        Dim buffer As Byte() = ASCIIEncoding.ASCII.GetBytes(stringInput)
        Return Convert.ToBase64String(des.CreateEncryptor().TransformFinalBlock(buffer, 0, buffer.Length))
    End Function
    Public Function IsValidEmail(ByVal email As String) As Boolean
        If email = String.Empty Then Return False
        Dim re As Regex = New Regex("^[\w._%-]+@[\w.-]+\.[a-zA-Z]{2,4}$")
        Dim m As Match = re.Match(email)
        Return (m.Captures.Count <> 0)
    End Function
    Public Function IsValidPassword(ByVal password As String) As Boolean
        If password = String.Empty Then Return False
        Dim re As Regex = New Regex("^(?=\w*\d)(?=\w*[A-Z])(?=\w*[a-z])\S{8,16}$")
        Dim m As Match = re.Match(password)
        Return (m.Captures.Count <> 0)
    End Function

    Sub formReset()
        txtContra.Text = ""
        txtCorreo.Text = ""
        txtNombre.Text = ""
        txtRepContra.Text = ""
        contraCheak = 0
        correoCheak = 0
        nombreCheak = 0
    End Sub

    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        Dim emailBln As Boolean = IsValidEmail(txtCorreo.Text)
        Dim contraBln As Boolean = IsValidPassword(txtContra.Text)
        Try
            Abrir()
            cmd = New MySqlCommand("insert into usuarios (nombre,contraseña,correo) values (@nombre,@contraseña,@correo)", cnn)
            If txtNombre.Text = "" Then
                MsgBox("Debe ingresar un nombre de usuario valido", MsgBoxStyle.MsgBoxHelp, "Nombre de usuario")
                nombreCheak = 1
            Else
                cmd.Parameters.AddWithValue("@nombre", Me.txtNombre.Text)
            End If
            If txtContra.Text = txtRepContra.Text Then
                If contraBln = False Then
                    MsgBox("Debe ingresar una contraseña validad.", MsgBoxStyle.MsgBoxHelp, "Contraseña")
                    contraBln = 1
                Else
                    cmd.Parameters.AddWithValue("@contraseña", Encrypt(Me.txtContra.Text, key))
                End If
            Else
                MsgBox("Las contraseñas no son iguales.", MsgBoxStyle.MsgBoxHelp, "Confirmacion de contraseña")
                contraCheak = 1
            End If

            If emailBln = False Then
                MsgBox("Debe ingresar un formato de correo electronico correcto.", MsgBoxStyle.MsgBoxHelp, "Email")
                correoCheak = 1
            Else
                cmd.Parameters.AddWithValue("@correo", txtCorreo.Text)
            End If

            If nombreCheak = 0 And contraCheak = 0 And correoCheak = 0 Then
                cmd.ExecuteNonQuery()
                MsgBox("Usuario creado correctamente", MsgBoxStyle.Information, "Usuario creado")
            Else
                MsgBox("Error: revise los datos", MsgBoxStyle.Exclamation, "Error")
            End If

            cnn.Close()
            nombreCheak = 0
            contraCheak = 0
            correoCheak = 0
        Catch ex As Exception
            MsgBox("No se pudo crear el usuario", MsgBoxStyle.Exclamation, "Error")
        End Try
        formReset()
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Hide()
        frmLogin.Show()
    End Sub

    Private Sub btnMinimizar_Click(sender As Object, e As EventArgs) Handles btnMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Me.Hide()
        frmLogin.Show()
    End Sub

    Private Sub chbMostrarContra_CheckedChanged(sender As Object, e As EventArgs) Handles chbMostrarContra.CheckedChanged
        If chbMostrarContra.Checked = True Then
            txtContra.UseSystemPasswordChar = False
            txtContra.PasswordChar = ""
            txtRepContra.UseSystemPasswordChar = False
            txtRepContra.PasswordChar = ""
        ElseIf chbMostrarContra.Checked = False Then
            txtContra.UseSystemPasswordChar = True
            txtContra.PasswordChar = "●"
            txtRepContra.UseSystemPasswordChar = True
            txtRepContra.PasswordChar = "●"
        End If
    End Sub

    Private Sub lblNombreForm_MouseMove(sender As Object, e As MouseEventArgs) Handles lblNombreForm.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112%, &HF012&, 0)
    End Sub

    Private Sub panelContenedor_Paint(sender As Object, e As PaintEventArgs) Handles panelContenedor.Paint

    End Sub
End Class