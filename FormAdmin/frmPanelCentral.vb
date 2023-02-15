Imports System.Runtime.InteropServices

Public Class frmPanelCentral
    Private Sub frmPanelCentral(sender As Object, e As EventArgs) Handles MyBase.Load
        abrirFormPanel(frmPrincipal)
        hideSubmenu()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParm As Integer)
    End Sub
    Private Sub panelCabecera_MouseMove(sender As Object, e As MouseEventArgs)
        ReleaseCapture()
        SendMessage(Me.Handle, &H112%, &HF012&, 0)
    End Sub
    Private Sub lblNombrePlanillas_Click(sender As Object, e As EventArgs)
        ReleaseCapture()
        SendMessage(Me.Handle, &H112%, &HF012&, 0)
    End Sub
    Private Sub hideSubmenu()
        panelSubMenuEmple.Visible = False
        panelSubMenuPlanillas.Visible = False
        panelSubMenuSala.Visible = False
    End Sub
    Private Sub mostrarSubMenu(submenu As Panel)
        If submenu.Visible = False Then
            hideSubmenu()
            submenu.Visible = True
        Else
            submenu.Visible = False
        End If
    End Sub
    Private Sub abrirFormPanel(ByVal formHijo As Form)
        If Me.panelContenedor.Controls.Count > 0 Then
            Me.panelContenedor.Controls.RemoveAt(0)
        End If
        Dim fh As Form = TryCast(formHijo, Form)
        fh.TopLevel = False 'Especifica que el formulario no es de nivel superior
        fh.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        fh.Dock = DockStyle.Fill
        Me.panelContenedor.Controls.Add(fh)
        Me.panelContenedor.Tag = fh
        fh.Show()
    End Sub


    Private Sub btnMinimizar_Click(sender As Object, e As EventArgs)
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub btnCerrar_Click(sender As Object, e As EventArgs)
        Me.Hide()
        frmLogin.Show()
    End Sub
    Private Sub btnPrincipal_Click(sender As Object, e As EventArgs) Handles btnPrincipal.Click
        abrirFormPanel(frmPrincipal)
    End Sub
    Private Sub btnRegistroEmple_Click(sender As Object, e As EventArgs) Handles btnRegistroEmple.Click
        mostrarSubMenu(panelSubMenuEmple)
    End Sub
    Private Sub btnSalarios_Click(sender As Object, e As EventArgs) Handles btnSalarios.Click
        mostrarSubMenu(panelSubMenuSala)
    End Sub
    Private Sub btnPlanillas_Click(sender As Object, e As EventArgs) Handles btnPlanillas.Click
        mostrarSubMenu(panelSubMenuPlanillas)
    End Sub
    Private Sub btnCerrarSesion_Click(sender As Object, e As EventArgs) Handles btnCerrarSesion.Click
        Me.Hide()
        frmLogin.Show()
    End Sub

    Private Sub frmPanelCentralUI_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Hide()
        frmLogin.Show()
    End Sub

    Private Sub btnCrearEmpleados_Click(sender As Object, e As EventArgs) Handles btnCrearEmpleados.Click
        abrirFormPanel(New frmCrearEmpleados)
    End Sub

    Private Sub btnAgregarHoras_Click(sender As Object, e As EventArgs) Handles btnAgregarHoras.Click
        abrirFormPanel(New frmSalario)
    End Sub

    Private Sub btnAgregarAPlanillas_Click(sender As Object, e As EventArgs) Handles btnAgregarAPlanillas.Click
        abrirFormPanel(New frmAgregarAPlanilla)
    End Sub

    Private Sub btnCrearPlanillas_Click(sender As Object, e As EventArgs) Handles btnCrearPlanillas.Click
        abrirFormPanel(New frmPlanillas)
    End Sub

    Private Sub btnCrearPuesto_Click(sender As Object, e As EventArgs) Handles btnCrearPuesto.Click
        abrirFormPanel(New frmCrearPuesto)
    End Sub

    Private Sub btnReducciones_Click(sender As Object, e As EventArgs) Handles btnReducciones.Click
        abrirFormPanel(New frmReducciones)
    End Sub
End Class