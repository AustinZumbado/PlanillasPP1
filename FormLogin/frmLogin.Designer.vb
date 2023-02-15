<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.panelCabecera = New System.Windows.Forms.Panel()
        Me.lblNombreForm = New System.Windows.Forms.Label()
        Me.btnMinimizar = New System.Windows.Forms.Button()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.panelContenedor = New System.Windows.Forms.Panel()
        Me.chbMostrarContra = New System.Windows.Forms.CheckBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.panelBottom = New System.Windows.Forms.Panel()
        Me.btnRecuContra = New System.Windows.Forms.LinkLabel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.btnRegistrar = New Krypton.Toolkit.KryptonButton()
        Me.btnIngresar = New Krypton.Toolkit.KryptonButton()
        Me.txtContra = New Krypton.Toolkit.KryptonTextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtNombre = New Krypton.Toolkit.KryptonTextBox()
        Me.panelCabecera.SuspendLayout()
        Me.panelContenedor.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelBottom.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 20.25!)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(89, 109)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(147, 32)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Bienvenido"
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
        Me.panelCabecera.Size = New System.Drawing.Size(300, 35)
        Me.panelCabecera.TabIndex = 12
        '
        'lblNombreForm
        '
        Me.lblNombreForm.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblNombreForm.AutoSize = True
        Me.lblNombreForm.Font = New System.Drawing.Font("Arial", 14.25!)
        Me.lblNombreForm.ForeColor = System.Drawing.Color.White
        Me.lblNombreForm.Location = New System.Drawing.Point(12, 9)
        Me.lblNombreForm.Margin = New System.Windows.Forms.Padding(429, 0, 429, 0)
        Me.lblNombreForm.Name = "lblNombreForm"
        Me.lblNombreForm.Size = New System.Drawing.Size(57, 22)
        Me.lblNombreForm.TabIndex = 23
        Me.lblNombreForm.Text = "Login"
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
        Me.btnMinimizar.Size = New System.Drawing.Size(34, 35)
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
        Me.btnCerrar.Size = New System.Drawing.Size(34, 35)
        Me.btnCerrar.TabIndex = 0
        Me.btnCerrar.UseVisualStyleBackColor = False
        '
        'panelContenedor
        '
        Me.panelContenedor.BackColor = System.Drawing.Color.WhiteSmoke
        Me.panelContenedor.Controls.Add(Me.chbMostrarContra)
        Me.panelContenedor.Controls.Add(Me.PictureBox2)
        Me.panelContenedor.Controls.Add(Me.panelBottom)
        Me.panelContenedor.Controls.Add(Me.PictureBox3)
        Me.panelContenedor.Controls.Add(Me.btnRegistrar)
        Me.panelContenedor.Controls.Add(Me.btnIngresar)
        Me.panelContenedor.Controls.Add(Me.txtContra)
        Me.panelContenedor.Controls.Add(Me.PictureBox1)
        Me.panelContenedor.Controls.Add(Me.txtNombre)
        Me.panelContenedor.Controls.Add(Me.Label1)
        Me.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelContenedor.Location = New System.Drawing.Point(0, 35)
        Me.panelContenedor.Name = "panelContenedor"
        Me.panelContenedor.Size = New System.Drawing.Size(300, 465)
        Me.panelContenedor.TabIndex = 13
        '
        'chbMostrarContra
        '
        Me.chbMostrarContra.AutoSize = True
        Me.chbMostrarContra.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chbMostrarContra.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chbMostrarContra.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.chbMostrarContra.Location = New System.Drawing.Point(143, 263)
        Me.chbMostrarContra.Name = "chbMostrarContra"
        Me.chbMostrarContra.Size = New System.Drawing.Size(129, 19)
        Me.chbMostrarContra.TabIndex = 25
        Me.chbMostrarContra.Text = "Mostrar contraseña"
        Me.chbMostrarContra.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(22, 222)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(30, 30)
        Me.PictureBox2.TabIndex = 24
        Me.PictureBox2.TabStop = False
        '
        'panelBottom
        '
        Me.panelBottom.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.panelBottom.Controls.Add(Me.btnRecuContra)
        Me.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panelBottom.Location = New System.Drawing.Point(0, 425)
        Me.panelBottom.Name = "panelBottom"
        Me.panelBottom.Size = New System.Drawing.Size(300, 40)
        Me.panelBottom.TabIndex = 23
        '
        'btnRecuContra
        '
        Me.btnRecuContra.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnRecuContra.AutoSize = True
        Me.btnRecuContra.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRecuContra.LinkColor = System.Drawing.Color.White
        Me.btnRecuContra.Location = New System.Drawing.Point(92, 10)
        Me.btnRecuContra.Name = "btnRecuContra"
        Me.btnRecuContra.Size = New System.Drawing.Size(124, 16)
        Me.btnRecuContra.TabIndex = 0
        Me.btnRecuContra.TabStop = True
        Me.btnRecuContra.Text = "Olvide la contraseña"
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(111, 6)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(100, 100)
        Me.PictureBox3.TabIndex = 22
        Me.PictureBox3.TabStop = False
        '
        'btnRegistrar
        '
        Me.btnRegistrar.CornerRoundingRadius = 20.0!
        Me.btnRegistrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRegistrar.Location = New System.Drawing.Point(22, 348)
        Me.btnRegistrar.Name = "btnRegistrar"
        Me.btnRegistrar.Size = New System.Drawing.Size(250, 40)
        Me.btnRegistrar.StateCommon.Back.Color1 = System.Drawing.Color.White
        Me.btnRegistrar.StateCommon.Back.Color2 = System.Drawing.Color.White
        Me.btnRegistrar.StateCommon.Back.ColorAngle = 45.0!
        Me.btnRegistrar.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.btnRegistrar.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnRegistrar.StateCommon.Border.ColorAngle = 45.0!
        Me.btnRegistrar.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.btnRegistrar.StateCommon.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.btnRegistrar.StateCommon.Border.Rounding = 20.0!
        Me.btnRegistrar.StateCommon.Border.Width = 1
        Me.btnRegistrar.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.btnRegistrar.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Arial", 14.25!)
        Me.btnRegistrar.StateNormal.Back.Color1 = System.Drawing.Color.White
        Me.btnRegistrar.StateNormal.Back.Color2 = System.Drawing.Color.White
        Me.btnRegistrar.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnRegistrar.StateNormal.Border.Color2 = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.btnRegistrar.StateNormal.Border.ColorAngle = 45.0!
        Me.btnRegistrar.StateNormal.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.btnRegistrar.StateNormal.Border.Rounding = 20.0!
        Me.btnRegistrar.StateNormal.Border.Width = 1
        Me.btnRegistrar.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnRegistrar.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.btnRegistrar.StateTracking.Back.ColorAngle = 45.0!
        Me.btnRegistrar.StateTracking.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.btnRegistrar.StateTracking.Border.Width = 1
        Me.btnRegistrar.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White
        Me.btnRegistrar.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.White
        Me.btnRegistrar.TabIndex = 20
        Me.btnRegistrar.Values.Text = "Registrar"
        '
        'btnIngresar
        '
        Me.btnIngresar.CornerRoundingRadius = 20.0!
        Me.btnIngresar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnIngresar.Location = New System.Drawing.Point(22, 302)
        Me.btnIngresar.Name = "btnIngresar"
        Me.btnIngresar.Size = New System.Drawing.Size(250, 40)
        Me.btnIngresar.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnIngresar.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.btnIngresar.StateCommon.Back.ColorAngle = 45.0!
        Me.btnIngresar.StateCommon.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.btnIngresar.StateCommon.Border.Rounding = 20.0!
        Me.btnIngresar.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White
        Me.btnIngresar.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Arial", 14.25!)
        Me.btnIngresar.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnIngresar.StateDisabled.Back.Color2 = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.btnIngresar.StateDisabled.Back.ColorAngle = 45.0!
        Me.btnIngresar.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnIngresar.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.btnIngresar.StateNormal.Back.ColorAngle = 45.0!
        Me.btnIngresar.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.White
        Me.btnIngresar.StateNormal.Content.ShortText.Color2 = System.Drawing.Color.White
        Me.btnIngresar.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnIngresar.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.btnIngresar.StatePressed.Back.ColorAngle = 45.0!
        Me.btnIngresar.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.btnIngresar.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnIngresar.StatePressed.Border.ColorAngle = 45.0!
        Me.btnIngresar.StatePressed.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.btnIngresar.StatePressed.Border.Width = 1
        Me.btnIngresar.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.btnIngresar.StateTracking.Back.Color1 = System.Drawing.Color.White
        Me.btnIngresar.StateTracking.Back.Color2 = System.Drawing.Color.White
        Me.btnIngresar.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.btnIngresar.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnIngresar.StateTracking.Border.ColorAngle = 45.0!
        Me.btnIngresar.StateTracking.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.btnIngresar.StateTracking.Border.Width = 1
        Me.btnIngresar.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.btnIngresar.TabIndex = 19
        Me.btnIngresar.Values.Text = "Ingresar"
        '
        'txtContra
        '
        Me.txtContra.Location = New System.Drawing.Point(57, 216)
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
        Me.txtContra.ToolTipValues.Description = "Ingrese la contraseña."
        Me.txtContra.ToolTipValues.EnableToolTips = True
        Me.txtContra.ToolTipValues.Heading = "Contraseña"
        Me.txtContra.UseSystemPasswordChar = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(22, 170)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(30, 30)
        Me.PictureBox1.TabIndex = 16
        Me.PictureBox1.TabStop = False
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(57, 166)
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
        Me.txtNombre.ToolTipValues.Description = "Ingrese el nombre de usuario."
        Me.txtNombre.ToolTipValues.EnableToolTips = True
        Me.txtNombre.ToolTipValues.Heading = "Nombre"
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(300, 500)
        Me.Controls.Add(Me.panelContenedor)
        Me.Controls.Add(Me.panelCabecera)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmLogin"
        Me.panelCabecera.ResumeLayout(False)
        Me.panelCabecera.PerformLayout()
        Me.panelContenedor.ResumeLayout(False)
        Me.panelContenedor.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelBottom.ResumeLayout(False)
        Me.panelBottom.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents panelContenedor As Panel
    Friend WithEvents panelCabecera As Panel
    Friend WithEvents btnMinimizar As Button
    Friend WithEvents btnCerrar As Button
    Friend WithEvents txtNombre As Krypton.Toolkit.KryptonTextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnIngresar As Krypton.Toolkit.KryptonButton
    Friend WithEvents txtContra As Krypton.Toolkit.KryptonTextBox
    Friend WithEvents btnRegistrar As Krypton.Toolkit.KryptonButton
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents lblNombreForm As Label
    Friend WithEvents panelBottom As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents chbMostrarContra As CheckBox
    Friend WithEvents btnRecuContra As LinkLabel
End Class

