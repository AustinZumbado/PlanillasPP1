<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRecuperarContra
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRecuperarContra))
        Me.txtCorreo = New Krypton.Toolkit.KryptonTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnEnviar = New Krypton.Toolkit.KryptonButton()
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.panelCabecera = New System.Windows.Forms.Panel()
        Me.lblNombreForm = New System.Windows.Forms.Label()
        Me.btnMinimizar = New System.Windows.Forms.Button()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.panelBottom = New System.Windows.Forms.Panel()
        Me.btnRegresar = New Krypton.Toolkit.KryptonButton()
        Me.panelCabecera.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtCorreo
        '
        Me.txtCorreo.Location = New System.Drawing.Point(12, 189)
        Me.txtCorreo.Name = "txtCorreo"
        Me.txtCorreo.Size = New System.Drawing.Size(276, 41)
        Me.txtCorreo.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.txtCorreo.StateCommon.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.txtCorreo.StateCommon.Border.Rounding = 20.0!
        Me.txtCorreo.StateCommon.Content.Font = New System.Drawing.Font("Arial", 14.25!)
        Me.txtCorreo.TabIndex = 16
        Me.txtCorreo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtCorreo.ToolTipValues.Description = "Ingrese el correo electronico con el que se registro."
        Me.txtCorreo.ToolTipValues.EnableToolTips = True
        Me.txtCorreo.ToolTipValues.Heading = "Recuperacion de contraseña"
        Me.txtCorreo.ToolTipValues.Image = CType(resources.GetObject("resource.Image"), System.Drawing.Image)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 20.25!)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(30, 145)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(237, 32)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Correo electronico"
        '
        'btnEnviar
        '
        Me.btnEnviar.CornerRoundingRadius = 20.0!
        Me.btnEnviar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEnviar.Location = New System.Drawing.Point(20, 247)
        Me.btnEnviar.Name = "btnEnviar"
        Me.btnEnviar.Size = New System.Drawing.Size(250, 40)
        Me.btnEnviar.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnEnviar.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.btnEnviar.StateCommon.Back.ColorAngle = 45.0!
        Me.btnEnviar.StateCommon.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.btnEnviar.StateCommon.Border.Rounding = 20.0!
        Me.btnEnviar.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White
        Me.btnEnviar.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Arial", 14.25!)
        Me.btnEnviar.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnEnviar.StateDisabled.Back.Color2 = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.btnEnviar.StateDisabled.Back.ColorAngle = 45.0!
        Me.btnEnviar.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnEnviar.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.btnEnviar.StateNormal.Back.ColorAngle = 45.0!
        Me.btnEnviar.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.White
        Me.btnEnviar.StateNormal.Content.ShortText.Color2 = System.Drawing.Color.White
        Me.btnEnviar.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnEnviar.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.btnEnviar.StatePressed.Back.ColorAngle = 45.0!
        Me.btnEnviar.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.btnEnviar.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnEnviar.StatePressed.Border.ColorAngle = 45.0!
        Me.btnEnviar.StatePressed.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.btnEnviar.StatePressed.Border.Width = 1
        Me.btnEnviar.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.btnEnviar.StateTracking.Back.Color1 = System.Drawing.Color.White
        Me.btnEnviar.StateTracking.Back.Color2 = System.Drawing.Color.White
        Me.btnEnviar.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.btnEnviar.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnEnviar.StateTracking.Border.ColorAngle = 45.0!
        Me.btnEnviar.StateTracking.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.btnEnviar.StateTracking.Border.Width = 1
        Me.btnEnviar.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.btnEnviar.TabIndex = 20
        Me.btnEnviar.Values.Text = "Enviar"
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
        Me.panelCabecera.TabIndex = 21
        '
        'lblNombreForm
        '
        Me.lblNombreForm.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblNombreForm.AutoSize = True
        Me.lblNombreForm.Font = New System.Drawing.Font("Arial", 14.25!)
        Me.lblNombreForm.ForeColor = System.Drawing.Color.White
        Me.lblNombreForm.Location = New System.Drawing.Point(1, 7)
        Me.lblNombreForm.Margin = New System.Windows.Forms.Padding(429, 0, 429, 0)
        Me.lblNombreForm.Name = "lblNombreForm"
        Me.lblNombreForm.Size = New System.Drawing.Size(197, 22)
        Me.lblNombreForm.TabIndex = 24
        Me.lblNombreForm.Text = "Recuperar contraseña"
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
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(108, 42)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(100, 100)
        Me.PictureBox3.TabIndex = 23
        Me.PictureBox3.TabStop = False
        '
        'panelBottom
        '
        Me.panelBottom.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panelBottom.Location = New System.Drawing.Point(0, 460)
        Me.panelBottom.Name = "panelBottom"
        Me.panelBottom.Size = New System.Drawing.Size(300, 40)
        Me.panelBottom.TabIndex = 24
        '
        'btnRegresar
        '
        Me.btnRegresar.CornerRoundingRadius = 20.0!
        Me.btnRegresar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRegresar.Location = New System.Drawing.Point(20, 293)
        Me.btnRegresar.Name = "btnRegresar"
        Me.btnRegresar.Size = New System.Drawing.Size(250, 40)
        Me.btnRegresar.StateCommon.Back.Color1 = System.Drawing.Color.White
        Me.btnRegresar.StateCommon.Back.Color2 = System.Drawing.Color.White
        Me.btnRegresar.StateCommon.Back.ColorAngle = 45.0!
        Me.btnRegresar.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.btnRegresar.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnRegresar.StateCommon.Border.ColorAngle = 45.0!
        Me.btnRegresar.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid
        Me.btnRegresar.StateCommon.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.btnRegresar.StateCommon.Border.Rounding = 20.0!
        Me.btnRegresar.StateCommon.Border.Width = 1
        Me.btnRegresar.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.btnRegresar.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Arial", 14.25!)
        Me.btnRegresar.StateNormal.Back.Color1 = System.Drawing.Color.White
        Me.btnRegresar.StateNormal.Back.Color2 = System.Drawing.Color.White
        Me.btnRegresar.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnRegresar.StateNormal.Border.Color2 = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.btnRegresar.StateNormal.Border.ColorAngle = 45.0!
        Me.btnRegresar.StateNormal.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.btnRegresar.StateNormal.Border.Rounding = 20.0!
        Me.btnRegresar.StateNormal.Border.Width = 1
        Me.btnRegresar.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnRegresar.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.btnRegresar.StateTracking.Back.ColorAngle = 45.0!
        Me.btnRegresar.StateTracking.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.btnRegresar.StateTracking.Border.Width = 1
        Me.btnRegresar.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White
        Me.btnRegresar.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.White
        Me.btnRegresar.TabIndex = 21
        Me.btnRegresar.Values.Text = "Regresar"
        '
        'frmRecuperarContra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(300, 500)
        Me.Controls.Add(Me.btnRegresar)
        Me.Controls.Add(Me.panelBottom)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.panelCabecera)
        Me.Controls.Add(Me.btnEnviar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtCorreo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmRecuperarContra"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmRecuperarContra"
        Me.panelCabecera.ResumeLayout(False)
        Me.panelCabecera.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtCorreo As Krypton.Toolkit.KryptonTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnEnviar As Krypton.Toolkit.KryptonButton
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents panelCabecera As Panel
    Friend WithEvents btnMinimizar As Button
    Friend WithEvents btnCerrar As Button
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents panelBottom As Panel
    Friend WithEvents btnRegresar As Krypton.Toolkit.KryptonButton
    Friend WithEvents lblNombreForm As Label
End Class
