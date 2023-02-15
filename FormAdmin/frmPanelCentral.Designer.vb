<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPanelCentral
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPanelCentral))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EjemploToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Ejemplo1ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Ejemplo1ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.panelMenu = New System.Windows.Forms.Panel()
        Me.panelSubMenuSala = New System.Windows.Forms.Panel()
        Me.btnReducciones = New System.Windows.Forms.Button()
        Me.btnAgregarHoras = New System.Windows.Forms.Button()
        Me.btnSalarios = New System.Windows.Forms.Button()
        Me.panelSubMenuEmple = New System.Windows.Forms.Panel()
        Me.btnCrearPuesto = New System.Windows.Forms.Button()
        Me.btnCrearEmpleados = New System.Windows.Forms.Button()
        Me.btnRegistroEmple = New System.Windows.Forms.Button()
        Me.panelSubMenuPlanillas = New System.Windows.Forms.Panel()
        Me.btnAgregarAPlanillas = New System.Windows.Forms.Button()
        Me.btnCrearPlanillas = New System.Windows.Forms.Button()
        Me.btnPlanillas = New System.Windows.Forms.Button()
        Me.btnUsuario = New System.Windows.Forms.Button()
        Me.btnCerrarSesion = New System.Windows.Forms.Button()
        Me.btnPrincipal = New System.Windows.Forms.Button()
        Me.panelLogo = New System.Windows.Forms.Panel()
        Me.pictureLogo = New System.Windows.Forms.PictureBox()
        Me.panelContenedor = New System.Windows.Forms.Panel()
        Me.MenuStrip1.SuspendLayout()
        Me.panelMenu.SuspendLayout()
        Me.panelSubMenuSala.SuspendLayout()
        Me.panelSubMenuEmple.SuspendLayout()
        Me.panelSubMenuPlanillas.SuspendLayout()
        Me.panelLogo.SuspendLayout()
        CType(Me.pictureLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem, Me.VerToolStripMenuItem, Me.EditarToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(5, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(1143, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EjemploToolStripMenuItem, Me.Ejemplo1ToolStripMenuItem1})
        Me.ArchivoToolStripMenuItem.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.ArchivoToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.ArchivoToolStripMenuItem.Text = "Archivo"
        '
        'EjemploToolStripMenuItem
        '
        Me.EjemploToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Ejemplo1ToolStripMenuItem})
        Me.EjemploToolStripMenuItem.Name = "EjemploToolStripMenuItem"
        Me.EjemploToolStripMenuItem.Size = New System.Drawing.Size(128, 22)
        Me.EjemploToolStripMenuItem.Text = "Ejemplo"
        '
        'Ejemplo1ToolStripMenuItem
        '
        Me.Ejemplo1ToolStripMenuItem.Name = "Ejemplo1ToolStripMenuItem"
        Me.Ejemplo1ToolStripMenuItem.Size = New System.Drawing.Size(128, 22)
        Me.Ejemplo1ToolStripMenuItem.Text = "Ejemplo1"
        '
        'Ejemplo1ToolStripMenuItem1
        '
        Me.Ejemplo1ToolStripMenuItem1.Name = "Ejemplo1ToolStripMenuItem1"
        Me.Ejemplo1ToolStripMenuItem1.Size = New System.Drawing.Size(128, 22)
        Me.Ejemplo1ToolStripMenuItem1.Text = "Ejemplo1"
        '
        'VerToolStripMenuItem
        '
        Me.VerToolStripMenuItem.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.VerToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.VerToolStripMenuItem.Name = "VerToolStripMenuItem"
        Me.VerToolStripMenuItem.Size = New System.Drawing.Size(38, 20)
        Me.VerToolStripMenuItem.Text = "Ver"
        '
        'EditarToolStripMenuItem
        '
        Me.EditarToolStripMenuItem.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.EditarToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.EditarToolStripMenuItem.Name = "EditarToolStripMenuItem"
        Me.EditarToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.EditarToolStripMenuItem.Text = "Editar"
        '
        'panelMenu
        '
        Me.panelMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.panelMenu.Controls.Add(Me.panelSubMenuSala)
        Me.panelMenu.Controls.Add(Me.btnSalarios)
        Me.panelMenu.Controls.Add(Me.panelSubMenuEmple)
        Me.panelMenu.Controls.Add(Me.btnRegistroEmple)
        Me.panelMenu.Controls.Add(Me.panelSubMenuPlanillas)
        Me.panelMenu.Controls.Add(Me.btnPlanillas)
        Me.panelMenu.Controls.Add(Me.btnUsuario)
        Me.panelMenu.Controls.Add(Me.btnCerrarSesion)
        Me.panelMenu.Controls.Add(Me.btnPrincipal)
        Me.panelMenu.Controls.Add(Me.panelLogo)
        Me.panelMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.panelMenu.Location = New System.Drawing.Point(0, 24)
        Me.panelMenu.Name = "panelMenu"
        Me.panelMenu.Size = New System.Drawing.Size(250, 625)
        Me.panelMenu.TabIndex = 3
        '
        'panelSubMenuSala
        '
        Me.panelSubMenuSala.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.panelSubMenuSala.Controls.Add(Me.btnReducciones)
        Me.panelSubMenuSala.Controls.Add(Me.btnAgregarHoras)
        Me.panelSubMenuSala.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelSubMenuSala.Location = New System.Drawing.Point(0, 433)
        Me.panelSubMenuSala.Name = "panelSubMenuSala"
        Me.panelSubMenuSala.Size = New System.Drawing.Size(250, 91)
        Me.panelSubMenuSala.TabIndex = 26
        '
        'btnReducciones
        '
        Me.btnReducciones.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnReducciones.FlatAppearance.BorderSize = 0
        Me.btnReducciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReducciones.Font = New System.Drawing.Font("Arial", 14.25!)
        Me.btnReducciones.ForeColor = System.Drawing.Color.White
        Me.btnReducciones.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReducciones.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnReducciones.Location = New System.Drawing.Point(0, 43)
        Me.btnReducciones.Name = "btnReducciones"
        Me.btnReducciones.Size = New System.Drawing.Size(250, 43)
        Me.btnReducciones.TabIndex = 21
        Me.btnReducciones.Text = "Mostrar reducciones"
        Me.btnReducciones.UseVisualStyleBackColor = True
        '
        'btnAgregarHoras
        '
        Me.btnAgregarHoras.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnAgregarHoras.FlatAppearance.BorderSize = 0
        Me.btnAgregarHoras.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregarHoras.Font = New System.Drawing.Font("Arial", 14.25!)
        Me.btnAgregarHoras.ForeColor = System.Drawing.Color.White
        Me.btnAgregarHoras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAgregarHoras.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnAgregarHoras.Location = New System.Drawing.Point(0, 0)
        Me.btnAgregarHoras.Name = "btnAgregarHoras"
        Me.btnAgregarHoras.Size = New System.Drawing.Size(250, 43)
        Me.btnAgregarHoras.TabIndex = 20
        Me.btnAgregarHoras.Text = "Agregar horas"
        Me.btnAgregarHoras.UseVisualStyleBackColor = True
        '
        'btnSalarios
        '
        Me.btnSalarios.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnSalarios.FlatAppearance.BorderSize = 0
        Me.btnSalarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalarios.Font = New System.Drawing.Font("Arial", 14.25!)
        Me.btnSalarios.ForeColor = System.Drawing.Color.White
        Me.btnSalarios.Image = CType(resources.GetObject("btnSalarios.Image"), System.Drawing.Image)
        Me.btnSalarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalarios.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnSalarios.Location = New System.Drawing.Point(0, 390)
        Me.btnSalarios.Name = "btnSalarios"
        Me.btnSalarios.Size = New System.Drawing.Size(250, 43)
        Me.btnSalarios.TabIndex = 20
        Me.btnSalarios.Text = "Salarios"
        Me.btnSalarios.UseVisualStyleBackColor = True
        '
        'panelSubMenuEmple
        '
        Me.panelSubMenuEmple.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.panelSubMenuEmple.Controls.Add(Me.btnCrearPuesto)
        Me.panelSubMenuEmple.Controls.Add(Me.btnCrearEmpleados)
        Me.panelSubMenuEmple.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelSubMenuEmple.Location = New System.Drawing.Point(0, 303)
        Me.panelSubMenuEmple.Name = "panelSubMenuEmple"
        Me.panelSubMenuEmple.Size = New System.Drawing.Size(250, 87)
        Me.panelSubMenuEmple.TabIndex = 25
        '
        'btnCrearPuesto
        '
        Me.btnCrearPuesto.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnCrearPuesto.FlatAppearance.BorderSize = 0
        Me.btnCrearPuesto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCrearPuesto.Font = New System.Drawing.Font("Arial", 14.25!)
        Me.btnCrearPuesto.ForeColor = System.Drawing.Color.White
        Me.btnCrearPuesto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCrearPuesto.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCrearPuesto.Location = New System.Drawing.Point(0, 43)
        Me.btnCrearPuesto.Name = "btnCrearPuesto"
        Me.btnCrearPuesto.Size = New System.Drawing.Size(250, 43)
        Me.btnCrearPuesto.TabIndex = 21
        Me.btnCrearPuesto.Text = "Crear puesto"
        Me.btnCrearPuesto.UseVisualStyleBackColor = True
        '
        'btnCrearEmpleados
        '
        Me.btnCrearEmpleados.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnCrearEmpleados.FlatAppearance.BorderSize = 0
        Me.btnCrearEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCrearEmpleados.Font = New System.Drawing.Font("Arial", 14.25!)
        Me.btnCrearEmpleados.ForeColor = System.Drawing.Color.White
        Me.btnCrearEmpleados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCrearEmpleados.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCrearEmpleados.Location = New System.Drawing.Point(0, 0)
        Me.btnCrearEmpleados.Name = "btnCrearEmpleados"
        Me.btnCrearEmpleados.Size = New System.Drawing.Size(250, 43)
        Me.btnCrearEmpleados.TabIndex = 20
        Me.btnCrearEmpleados.Text = "Crear empleados"
        Me.btnCrearEmpleados.UseVisualStyleBackColor = True
        '
        'btnRegistroEmple
        '
        Me.btnRegistroEmple.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnRegistroEmple.FlatAppearance.BorderSize = 0
        Me.btnRegistroEmple.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegistroEmple.Font = New System.Drawing.Font("Arial", 14.25!)
        Me.btnRegistroEmple.ForeColor = System.Drawing.Color.White
        Me.btnRegistroEmple.Image = CType(resources.GetObject("btnRegistroEmple.Image"), System.Drawing.Image)
        Me.btnRegistroEmple.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRegistroEmple.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnRegistroEmple.Location = New System.Drawing.Point(0, 260)
        Me.btnRegistroEmple.Name = "btnRegistroEmple"
        Me.btnRegistroEmple.Size = New System.Drawing.Size(250, 43)
        Me.btnRegistroEmple.TabIndex = 19
        Me.btnRegistroEmple.Text = "Empleados"
        Me.btnRegistroEmple.UseVisualStyleBackColor = True
        '
        'panelSubMenuPlanillas
        '
        Me.panelSubMenuPlanillas.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.panelSubMenuPlanillas.Controls.Add(Me.btnAgregarAPlanillas)
        Me.panelSubMenuPlanillas.Controls.Add(Me.btnCrearPlanillas)
        Me.panelSubMenuPlanillas.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelSubMenuPlanillas.Location = New System.Drawing.Point(0, 173)
        Me.panelSubMenuPlanillas.Name = "panelSubMenuPlanillas"
        Me.panelSubMenuPlanillas.Size = New System.Drawing.Size(250, 87)
        Me.panelSubMenuPlanillas.TabIndex = 0
        '
        'btnAgregarAPlanillas
        '
        Me.btnAgregarAPlanillas.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnAgregarAPlanillas.FlatAppearance.BorderSize = 0
        Me.btnAgregarAPlanillas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregarAPlanillas.Font = New System.Drawing.Font("Arial", 14.25!)
        Me.btnAgregarAPlanillas.ForeColor = System.Drawing.Color.White
        Me.btnAgregarAPlanillas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAgregarAPlanillas.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnAgregarAPlanillas.Location = New System.Drawing.Point(0, 43)
        Me.btnAgregarAPlanillas.Name = "btnAgregarAPlanillas"
        Me.btnAgregarAPlanillas.Size = New System.Drawing.Size(250, 43)
        Me.btnAgregarAPlanillas.TabIndex = 21
        Me.btnAgregarAPlanillas.Text = "Agregar a planillas"
        Me.btnAgregarAPlanillas.UseVisualStyleBackColor = True
        '
        'btnCrearPlanillas
        '
        Me.btnCrearPlanillas.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnCrearPlanillas.FlatAppearance.BorderSize = 0
        Me.btnCrearPlanillas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCrearPlanillas.Font = New System.Drawing.Font("Arial", 14.25!)
        Me.btnCrearPlanillas.ForeColor = System.Drawing.Color.White
        Me.btnCrearPlanillas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCrearPlanillas.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCrearPlanillas.Location = New System.Drawing.Point(0, 0)
        Me.btnCrearPlanillas.Name = "btnCrearPlanillas"
        Me.btnCrearPlanillas.Size = New System.Drawing.Size(250, 43)
        Me.btnCrearPlanillas.TabIndex = 22
        Me.btnCrearPlanillas.Text = "Crear planilla"
        Me.btnCrearPlanillas.UseVisualStyleBackColor = True
        '
        'btnPlanillas
        '
        Me.btnPlanillas.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnPlanillas.FlatAppearance.BorderSize = 0
        Me.btnPlanillas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPlanillas.Font = New System.Drawing.Font("Arial", 14.25!)
        Me.btnPlanillas.ForeColor = System.Drawing.Color.White
        Me.btnPlanillas.Image = CType(resources.GetObject("btnPlanillas.Image"), System.Drawing.Image)
        Me.btnPlanillas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPlanillas.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnPlanillas.Location = New System.Drawing.Point(0, 130)
        Me.btnPlanillas.Name = "btnPlanillas"
        Me.btnPlanillas.Size = New System.Drawing.Size(250, 43)
        Me.btnPlanillas.TabIndex = 21
        Me.btnPlanillas.Text = "Planillas"
        Me.btnPlanillas.UseVisualStyleBackColor = True
        '
        'btnUsuario
        '
        Me.btnUsuario.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnUsuario.FlatAppearance.BorderSize = 0
        Me.btnUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUsuario.Font = New System.Drawing.Font("Arial", 14.25!)
        Me.btnUsuario.ForeColor = System.Drawing.Color.White
        Me.btnUsuario.Image = CType(resources.GetObject("btnUsuario.Image"), System.Drawing.Image)
        Me.btnUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUsuario.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnUsuario.Location = New System.Drawing.Point(0, 539)
        Me.btnUsuario.Name = "btnUsuario"
        Me.btnUsuario.Size = New System.Drawing.Size(250, 43)
        Me.btnUsuario.TabIndex = 22
        Me.btnUsuario.Text = "Usuario"
        Me.btnUsuario.UseVisualStyleBackColor = True
        '
        'btnCerrarSesion
        '
        Me.btnCerrarSesion.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnCerrarSesion.FlatAppearance.BorderSize = 0
        Me.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrarSesion.Font = New System.Drawing.Font("Arial", 14.25!)
        Me.btnCerrarSesion.ForeColor = System.Drawing.Color.White
        Me.btnCerrarSesion.Image = CType(resources.GetObject("btnCerrarSesion.Image"), System.Drawing.Image)
        Me.btnCerrarSesion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCerrarSesion.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCerrarSesion.Location = New System.Drawing.Point(0, 582)
        Me.btnCerrarSesion.Name = "btnCerrarSesion"
        Me.btnCerrarSesion.Size = New System.Drawing.Size(250, 43)
        Me.btnCerrarSesion.TabIndex = 23
        Me.btnCerrarSesion.Text = "Cerrar sesion"
        Me.btnCerrarSesion.UseVisualStyleBackColor = True
        '
        'btnPrincipal
        '
        Me.btnPrincipal.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnPrincipal.FlatAppearance.BorderSize = 0
        Me.btnPrincipal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrincipal.Font = New System.Drawing.Font("Arial", 14.25!)
        Me.btnPrincipal.ForeColor = System.Drawing.Color.White
        Me.btnPrincipal.Image = CType(resources.GetObject("btnPrincipal.Image"), System.Drawing.Image)
        Me.btnPrincipal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPrincipal.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnPrincipal.Location = New System.Drawing.Point(0, 87)
        Me.btnPrincipal.Name = "btnPrincipal"
        Me.btnPrincipal.Size = New System.Drawing.Size(250, 43)
        Me.btnPrincipal.TabIndex = 18
        Me.btnPrincipal.Text = "Principal"
        Me.btnPrincipal.UseVisualStyleBackColor = True
        '
        'panelLogo
        '
        Me.panelLogo.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.panelLogo.Controls.Add(Me.pictureLogo)
        Me.panelLogo.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelLogo.Location = New System.Drawing.Point(0, 0)
        Me.panelLogo.Name = "panelLogo"
        Me.panelLogo.Size = New System.Drawing.Size(250, 87)
        Me.panelLogo.TabIndex = 24
        '
        'pictureLogo
        '
        Me.pictureLogo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pictureLogo.Image = CType(resources.GetObject("pictureLogo.Image"), System.Drawing.Image)
        Me.pictureLogo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.pictureLogo.Location = New System.Drawing.Point(0, 0)
        Me.pictureLogo.Name = "pictureLogo"
        Me.pictureLogo.Size = New System.Drawing.Size(250, 87)
        Me.pictureLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictureLogo.TabIndex = 0
        Me.pictureLogo.TabStop = False
        '
        'panelContenedor
        '
        Me.panelContenedor.BackColor = System.Drawing.Color.White
        Me.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelContenedor.Location = New System.Drawing.Point(250, 24)
        Me.panelContenedor.Name = "panelContenedor"
        Me.panelContenedor.Size = New System.Drawing.Size(893, 625)
        Me.panelContenedor.TabIndex = 5
        '
        'frmPanelCentral
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1143, 649)
        Me.Controls.Add(Me.panelContenedor)
        Me.Controls.Add(Me.panelMenu)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmPanelCentral"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sistemas de Planillas"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.panelMenu.ResumeLayout(False)
        Me.panelSubMenuSala.ResumeLayout(False)
        Me.panelSubMenuEmple.ResumeLayout(False)
        Me.panelSubMenuPlanillas.ResumeLayout(False)
        Me.panelLogo.ResumeLayout(False)
        CType(Me.pictureLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents panelMenu As Panel
    Friend WithEvents panelSubMenuSala As Panel
    Friend WithEvents btnAgregarAPlanillas As Button
    Friend WithEvents btnAgregarHoras As Button
    Friend WithEvents btnSalarios As Button
    Friend WithEvents btnPlanillas As Button
    Friend WithEvents panelSubMenuEmple As Panel
    Friend WithEvents btnCrearPuesto As Button
    Friend WithEvents btnCrearEmpleados As Button
    Friend WithEvents btnUsuario As Button
    Friend WithEvents btnCerrarSesion As Button
    Friend WithEvents btnRegistroEmple As Button
    Friend WithEvents btnPrincipal As Button
    Friend WithEvents panelLogo As Panel
    Friend WithEvents pictureLogo As PictureBox
    Friend WithEvents ArchivoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents panelContenedor As Panel
    Friend WithEvents EjemploToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Ejemplo1ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Ejemplo1ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents panelSubMenuPlanillas As Panel
    Friend WithEvents btnCrearPlanillas As Button
    Friend WithEvents btnReducciones As Button
End Class
