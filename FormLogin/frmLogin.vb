Imports MySql.Data.MySqlClient
Imports System.Runtime.InteropServices
Imports System.Security.Cryptography
Imports System.Text
Public Class frmLogin
    Dim cmd As MySqlCommand
    Dim des As New TripleDESCryptoServiceProvider
    Dim MD5 As New MD5CryptoServiceProvider
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

    Sub formReset()
        txtNombre.Text = ""
        txtContra.Text = ""
    End Sub

    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        Try
            Abrir()
            Dim query As String = "select * from Usuarios where nombre=@nombre and contraseña=@contraseña"
            cmd = New MySqlCommand(query, cnn)
            cmd.Parameters.AddWithValue("@nombre", txtNombre.Text)
            cmd.Parameters.AddWithValue("@contraseña", Encrypt(txtContra.Text, key))
            cmd.ExecuteNonQuery()
            Dim dr As MySqlDataReader
            dr = cmd.ExecuteReader
            While dr.Read
                'MsgBox("login satisfactorio")
                MsgBox("Bienvenido " & txtNombre.Text & ".", MsgBoxStyle.Information, "Bienvenido")
                Me.Hide()
                'frmCrearEmpleados.Show()
                frmPanelCentral.Show()
            End While
        Catch ex As Exception
            MsgBox("No se puede ingresar a la base de datos " + ex.ToString)
        End Try
        formReset()
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub btnMinimizar_Click(sender As Object, e As EventArgs) Handles btnMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub chbMostrarContra_CheckedChanged(sender As Object, e As EventArgs) Handles chbMostrarContra.CheckedChanged
        If chbMostrarContra.Checked = True Then
            txtContra.UseSystemPasswordChar = False
            txtContra.PasswordChar = ""
        ElseIf chbMostrarContra.Checked = False Then
            txtContra.UseSystemPasswordChar = True
            txtContra.PasswordChar = "●"
        End If
    End Sub

    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        Me.Hide()
        frmRegistro.Show()
    End Sub

    Private Sub btnRecuContra_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles btnRecuContra.LinkClicked
        frmRecuperarContra.Show()
        Me.Hide()
    End Sub

    Private Sub lblNombreForm_MouseMove(sender As Object, e As MouseEventArgs) Handles lblNombreForm.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112%, &HF012&, 0)
    End Sub
End Class