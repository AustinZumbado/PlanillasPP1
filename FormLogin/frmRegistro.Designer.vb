<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmRegistro
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRegistro))
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.panelCabecera = New System.Windows.Forms.Panel()
        Me.lblNombreForm = New System.Windows.Forms.Label()
        Me.btnMinimizar = New System.Windows.Forms.Button()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.panelContenedor = New System.Windows.Forms.Panel()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.txtRepContra = New Krypton.Toolkit.KryptonTextBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.txtCorreo = New Krypton.Toolkit.KryptonTextBox()
        Me.chbMostrarContra = New System.Windows.Forms.CheckBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.panelBottom = New System.Windows.Forms.Panel()
        Me.btnLogin = New Krypton.Toolkit.KryptonButton()
        Me.btnRegistrar = New Krypton.Toolkit.KryptonButton()
        Me.txtContra = New Krypton.Toolkit.KryptonTextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtNombre = New Krypton.Toolkit.KryptonTextBox()
        Me.panelCabecera.SuspendLayout()
        Me.panelContenedor.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 20
        Me.BunifuElipse1.TargetControl = Me
        '
        'panelCabecera
        '
        Me.panelCabecera.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.panelCabecera.Controls.Add(Me.lblNombreForm)
        Me.panelCabecera.Controls.Add(Me.btnMinimizar)
        Me.panelCabecera.Controls.Add(Me.btnCerrar)
        Me.panelCabecera.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelCabecera.Location = New System.Drawing.Point(0, 0)
        Me.panelCabecera.Name = "panelCabecera"
        Me.panelCabecera.Size = New System.Drawing.Size(300, 40)
        Me.panelCabecera.TabIndex = 13
        '
        'lblNombreForm
        '
        Me.lblNombreForm.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblNombreForm.AutoSize = True
        Me.lblNombreForm.Font = New System.Drawing.Font("Arial", 14.25!)
        Me.lblNombreForm.ForeColor = System.Drawing.Color.White
        Me.lblNombreForm.Location = New System.Drawing.Point(12, 7)
        Me.lblNombreForm.Margin = New System.Windows.Forms.Padding(429, 0, 429, 0)
        Me.lblNombreForm.Name = "lblNombreForm"
        Me.lblNombreForm.Size = New System.Drawing.Size(82, 22)
        Me.lblNombreForm.TabIndex = 23
        Me.lblNombreForm.Text = "Registro"
        Me.lblNombreForm.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnMinimizar
        '
        Me.btnMinimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMinimizar.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnMinimizar.FlatAppearance.BorderSize = 0
        Me.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMinimizar.Image = CType(resources.GetObject("btnMinimizar.Image"), System.Drawing.Image)
        Me.btnMinimizar.Location = New System.Drawing.Point(232, 0)
        Me.btnMinimizar.Name = "btnMinimizar"
        Me.btnMinimizar.Size = New System.Drawing.Size(34, 40)
        Me.btnMinimizar.TabIndex = 4
        Me.btnMinimizar.UseVisualStyleBackColor = True
        '
        'btnCerrar
        '
        Me.btnCerrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCerrar.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnCerrar.FlatAppearance.BorderSize = 0
        Me.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrar.Image = CType(resources.GetObject("btnCerrar.Image"), System.Drawing.Image)
        Me.btnCerrar.Location = New System.Drawing.Point(266, 0)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(34, 40)
        Me.btnCerrar.TabIndex = 0
        Me.btnCerrar.UseVisualStyleBackColor = False
        '
        'panelContenedor
        '
        Me.panelContenedor.BackColor = System.Drawing.Color.WhiteSmoke
        Me.panelContenedor.Controls.Add(Me.PictureBox5)
        Me.panelContenedor.Controls.Add(Me.PictureBox4)
        Me.panelContenedor.Controls.Add(Me.txtRepContra)
        Me.panelContenedor.Controls.Add(Me.PictureBox3)
        Me.panelContenedor.Controls.Add(Me.txtCorreo)
        Me.panelContenedor.Controls.Add(Me.chbMostrarContra)
        Me.panelContenedor.Controls.Add(Me.PictureBox2)
        Me.panelContenedor.Controls.Add(Me.panelBottom)
        Me.panelContenedor.Controls.Add(Me.btnLogin)
        Me.panelContenedor.Controls.Add(Me.btnRegistrar)
        Me.panelContenedor.Controls.Add(Me.txtContra)
        Me.panelContenedor.Controls.Add(Me.PictureBox1)
        Me.panelContenedor.Controls.Add(Me.txtNombre)
        Me.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelContenedor.Location = New System.Drawing.Point(0, 40)
        Me.panelContenedor.Name = "panelContenedor"
        Me.panelContenedor.Size = New System.Drawing.Size(300, 460)
        Me.panelContenedor.TabIndex = 14
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(122, 15)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(65, 65)
        Me.PictureBox5.TabIndex = 30
        Me.PictureBox5.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(24, 192)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(30, 30)
        Me.PictureBox4.TabIndex = 29
        Me.PictureBox4.TabStop = False
        '
        'txtRepContra
        '
        Me.txtRepContra.Location = New System.Drawing.Point(59, 232)
        Me.txtRepContra.Name = "txtRepContra"
        Me.txtRepContra.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtRepContra.Size = New System.Drawing.Size(215, 41)
        Me.txtRepContra.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.txtRepContra.StateCommon.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.txtRepContra.StateCommon.Border.Rounding = 20.0!
        Me.txtRepContra.StateCommon.Content.Font = New System.Drawing.Font("Arial", 14.25!)
        Me.txtRepContra.TabIndex = 28
        Me.txtRepContra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtRepContra.ToolTipValues.Description = "Repita la contraseña."
        Me.txtRepContra.ToolTipValues.EnableToolTips = True
        Me.txtRepContra.ToolTipValues.Heading = "Validar contraseña"
        Me.txtRepContra.ToolTipValues.Image = CType(resources.GetObject("resource.Image"), System.Drawing.Image)
        Me.txtRepContra.UseSystemPasswordChar = True
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(24, 145)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(30, 30)
        Me.PictureBox3.TabIndex = 27
        Me.PictureBox3.TabStop = False
        '
        'txtCorreo
        '
        Me.txtCorreo.Location = New System.Drawing.Point(59, 141)
        Me.txtCorreo.Name = "txtCorreo"
        Me.txtCorreo.Size = New System.Drawing.Size(215, 41)
        Me.txtCorreo.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.txtCorreo.StateCommon.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.txtCorreo.StateCommon.Border.Rounding = 20.0!
        Me.txtCorreo.StateCommon.Content.Font = New System.Drawing.Font("Arial", 14.25!)
        Me.txtCorreo.TabIndex = 26
        Me.txtCorreo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtCorreo.ToolTipValues.Description = "Ingrese el correo electronico."
        Me.txtCorreo.ToolTipValues.EnableToolTips = True
        Me.txtCorreo.ToolTipValues.Heading = "Correo."
        Me.txtCorreo.ToolTipValues.Image = CType(resources.GetObject("resource.Image1"), System.Drawing.Image)
        '
        'chbMostrarContra
        '
        Me.chbMostrarContra.AutoSize = True
        Me.chbMostrarContra.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chbMostrarContra.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chbMostrarContra.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.chbMostrarContra.Location = New System.Drawing.Point(145, 277)
        Me.chbMostrarContra.Name = "chbMostrarContra"
        Me.chbMostrarContra.Size = New System.Drawing.Size(129, 19)
        Me.chbMostrarContra.TabIndex = 25
        Me.chbMostrarContra.Text = "Mostrar contraseña"
        Me.chbMostrarContra.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(24, 239)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(30, 30)
        Me.PictureBox2.TabIndex = 24
        Me.PictureBox2.TabStop = False
        '
        'panelBottom
        '
        Me.panelBottom.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panelBottom.Location = New System.Drawing.Point(0, 420)
        Me.panelBottom.Name = "panelBottom"
        Me.panelBottom.Size = New System.Drawing.Size(300, 40)
        Me.panelBottom.TabIndex = 23
        '
        'btnLogin
        '
        Me.btnLogin.CornerRoundingRadius = 20.0!
        Me.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogin.Location = New System.Drawing.Point(24, 350)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(250, 40)
        Me.btnLogin.StateCommon.Back.Color1 = System.Drawing.Color.White
        Me.btnLogin.StateCommon.Back.Color2 = System.Drawing.Color.White
        Me.btnLogin.StateCommon.Back.ColorAngle = 45.0!
        Me.btnLogin.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.btnLogin.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnLogin.StateCommon.Border.ColorAngle = 45.0!
        Me.btnLogin.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.btnLogin.StateCommon.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.btnLogin.StateCommon.Border.Rounding = 20.0!
        Me.btnLogin.StateCommon.Border.Width = 1
        Me.btnLogin.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.btnLogin.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Arial", 14.25!)
        Me.btnLogin.StateNormal.Back.Color1 = System.Drawing.Color.White
        Me.btnLogin.StateNormal.Back.Color2 = System.Drawing.Color.White
        Me.btnLogin.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnLogin.StateNormal.Border.Color2 = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.btnLogin.StateNormal.Border.ColorAngle = 45.0!
        Me.btnLogin.StateNormal.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.btnLogin.StateNormal.Border.Rounding = 20.0!
        Me.btnLogin.StateNormal.Border.Width = 1
        Me.btnLogin.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnLogin.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.btnLogin.StateTracking.Back.ColorAngle = 45.0!
        Me.btnLogin.StateTracking.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.btnLogin.StateTracking.Border.Width = 1
        Me.btnLogin.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White
        Me.btnLogin.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.White
        Me.btnLogin.TabIndex = 20
        Me.btnLogin.Values.Text = "Regresar"
        '
        'btnRegistrar
        '
        Me.btnRegistrar.CornerRoundingRadius = 20.0!
        Me.btnRegistrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRegistrar.Location = New System.Drawing.Point(24, 304)
        Me.btnRegistrar.Name = "btnRegistrar"
        Me.btnRegistrar.Size = New System.Drawing.Size(250, 40)
        Me.btnRegistrar.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnRegistrar.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.btnRegistrar.StateCommon.Back.ColorAngle = 45.0!
        Me.btnRegistrar.StateCommon.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.btnRegistrar.StateCommon.Border.Rounding = 20.0!
        Me.btnRegistrar.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White
        Me.btnRegistrar.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Arial", 14.25!)
        Me.btnRegistrar.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnRegistrar.StateDisabled.Back.Color2 = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.btnRegistrar.StateDisabled.Back.ColorAngle = 45.0!
        Me.btnRegistrar.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnRegistrar.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.btnRegistrar.StateNormal.Back.ColorAngle = 45.0!
        Me.btnRegistrar.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.White
        Me.btnRegistrar.StateNormal.Content.ShortText.Color2 = System.Drawing.Color.White
        Me.btnRegistrar.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnRegistrar.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.btnRegistrar.StatePressed.Back.ColorAngle = 45.0!
        Me.btnRegistrar.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.btnRegistrar.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnRegistrar.StatePressed.Border.ColorAngle = 45.0!
        Me.btnRegistrar.StatePressed.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.btnRegistrar.StatePressed.Border.Width = 1
        Me.btnRegistrar.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.btnRegistrar.StateTracking.Back.Color1 = System.Drawing.Color.White
        Me.btnRegistrar.StateTracking.Back.Color2 = System.Drawing.Color.White
        Me.btnRegistrar.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.btnRegistrar.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnRegistrar.StateTracking.Border.ColorAngle = 45.0!
        Me.btnRegistrar.StateTracking.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.btnRegistrar.StateTracking.Border.Width = 1
        Me.btnRegistrar.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.btnRegistrar.TabIndex = 19
        Me.btnRegistrar.Values.Text = "Registrar"
        '
        'txtContra
        '
        Me.txtContra.Location = New System.Drawing.Point(59, 186)
        Me.txtContra.Name = "txtContra"
        Me.txtContra.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtContra.Size = New System.Drawing.Size(215, 41)
        Me.txtContra.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.txtContra.StateCommon.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.txtContra.StateCommon.Border.Rounding = 20.0!
        Me.txtContra.StateCommon.Content.Font = New System.Drawing.Font("Arial", 14.25!)
        Me.txtContra.TabIndex = 17
        Me.txtContra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtContra.ToolTipValues.Description = "La contraseña debera de contener: " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " · Mas de 8 carateres" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " · Una mayuscula" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " · U" &
    "n numero" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.txtContra.ToolTipValues.EnableToolTips = True
        Me.txtContra.ToolTipValues.Heading = "Contraseña"
        Me.txtContra.ToolTipValues.Image = CType(resources.GetObject("resource.Image2"), System.Drawing.Image)
        Me.txtContra.UseSystemPasswordChar = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(24, 98)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(30, 30)
        Me.PictureBox1.TabIndex = 16
        Me.PictureBox1.TabStop = False
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(59, 94)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(215, 41)
        Me.txtNombre.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.txtNombre.StateCommon.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.txtNombre.StateCommon.Border.Rounding = 20.0!
        Me.txtNombre.StateCommon.Content.Font = New System.Drawing.Font("Arial", 14.25!)
        Me.txtNombre.TabIndex = 15
        Me.txtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtNombre.ToolTipValues.Description = "Ingrese el nombre de usuario que desea."
        Me.txtNombre.ToolTipValues.EnableToolTips = True
        Me.txtNombre.ToolTipValues.Heading = "Nombre"
        Me.txtNombre.ToolTipValues.Image = CType(resources.GetObject("resource.Image3"), System.Drawing.Image)
        '
        'frmRegistro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(300, 500)
        Me.Controls.Add(Me.panelContenedor)
        Me.Controls.Add(Me.panelCabecera)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmRegistro"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmRegistro"
        Me.panelCabecera.ResumeLayout(False)
        Me.panelCabecera.PerformLayout()
        Me.panelContenedor.ResumeLayout(False)
        Me.panelContenedor.PerformLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents panelCabecera As Panel
    Friend WithEvents lblNombreForm As Label
    Friend WithEvents btnMinimizar As Button
    Friend WithEvents btnCerrar As Button
    Friend WithEvents panelContenedor As Panel
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents txtRepContra As Krypton.Toolkit.KryptonTextBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents txtCorreo As Krypton.Toolkit.KryptonTextBox
    Friend WithEvents chbMostrarContra As CheckBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents panelBottom As Panel
    Friend WithEvents btnLogin As Krypton.Toolkit.KryptonButton
    Friend WithEvents btnRegistrar As Krypton.Toolkit.KryptonButton
    Friend WithEvents txtContra As Krypton.Toolkit.KryptonTextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtNombre As Krypton.Toolkit.KryptonTextBox
    Friend WithEvents PictureBox5 As PictureBox
End Class
