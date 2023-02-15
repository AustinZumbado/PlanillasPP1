<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAgregarAPlanilla
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAgregarAPlanilla))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtBuscarEmple = New Krypton.Toolkit.KryptonTextBox()
        Me.btnResetEmpleados = New System.Windows.Forms.Button()
        Me.lblListaEmpl = New System.Windows.Forms.Label()
        Me.dgvListaEmpleados = New System.Windows.Forms.DataGridView()
        Me.cmbPlanillas = New System.Windows.Forms.ComboBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtCedula = New System.Windows.Forms.TextBox()
        Me.btnAgregar = New Krypton.Toolkit.KryptonButton()
        Me.tbcContenedor = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.dtpInicioPlanilla = New Krypton.Toolkit.KryptonDateTimePicker()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.lblCedula = New System.Windows.Forms.Label()
        Me.Panel14 = New System.Windows.Forms.Panel()
        Me.Panel15 = New System.Windows.Forms.Panel()
        Me.lblPlanila = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.dgvListaEmpleados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbcContenedor.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel14.SuspendLayout()
        Me.Panel15.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.dgvListaEmpleados)
        Me.Panel1.Location = New System.Drawing.Point(7, 140)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(667, 161)
        Me.Panel1.TabIndex = 11
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Panel2.Controls.Add(Me.txtBuscarEmple)
        Me.Panel2.Controls.Add(Me.btnResetEmpleados)
        Me.Panel2.Controls.Add(Me.lblListaEmpl)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(665, 31)
        Me.Panel2.TabIndex = 9
        '
        'txtBuscarEmple
        '
        Me.txtBuscarEmple.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.txtBuscarEmple.Location = New System.Drawing.Point(527, 2)
        Me.txtBuscarEmple.Name = "txtBuscarEmple"
        Me.txtBuscarEmple.Size = New System.Drawing.Size(99, 28)
        Me.txtBuscarEmple.StateCommon.Back.Color1 = System.Drawing.Color.White
        Me.txtBuscarEmple.StateCommon.Border.Color1 = System.Drawing.Color.White
        Me.txtBuscarEmple.StateCommon.Border.Color2 = System.Drawing.Color.White
        Me.txtBuscarEmple.StateCommon.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.txtBuscarEmple.StateCommon.Border.Rounding = 10.0!
        Me.txtBuscarEmple.StateCommon.Content.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.txtBuscarEmple.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.txtBuscarEmple.StateNormal.Border.Color1 = System.Drawing.Color.White
        Me.txtBuscarEmple.StateNormal.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.txtBuscarEmple.TabIndex = 15
        Me.txtBuscarEmple.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnResetEmpleados
        '
        Me.btnResetEmpleados.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnResetEmpleados.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnResetEmpleados.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnResetEmpleados.FlatAppearance.BorderSize = 0
        Me.btnResetEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnResetEmpleados.Image = CType(resources.GetObject("btnResetEmpleados.Image"), System.Drawing.Image)
        Me.btnResetEmpleados.Location = New System.Drawing.Point(631, 0)
        Me.btnResetEmpleados.Name = "btnResetEmpleados"
        Me.btnResetEmpleados.Size = New System.Drawing.Size(34, 31)
        Me.btnResetEmpleados.TabIndex = 10
        Me.btnResetEmpleados.UseVisualStyleBackColor = True
        '
        'lblListaEmpl
        '
        Me.lblListaEmpl.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblListaEmpl.AutoSize = True
        Me.lblListaEmpl.Font = New System.Drawing.Font("Arial", 14.25!)
        Me.lblListaEmpl.ForeColor = System.Drawing.Color.White
        Me.lblListaEmpl.Location = New System.Drawing.Point(3, 4)
        Me.lblListaEmpl.Margin = New System.Windows.Forms.Padding(429, 0, 429, 0)
        Me.lblListaEmpl.Name = "lblListaEmpl"
        Me.lblListaEmpl.Size = New System.Drawing.Size(177, 22)
        Me.lblListaEmpl.TabIndex = 9
        Me.lblListaEmpl.Text = "Lista de empleados"
        Me.lblListaEmpl.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'dgvListaEmpleados
        '
        Me.dgvListaEmpleados.AllowUserToAddRows = False
        Me.dgvListaEmpleados.AllowUserToDeleteRows = False
        Me.dgvListaEmpleados.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvListaEmpleados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvListaEmpleados.BackgroundColor = System.Drawing.Color.White
        Me.dgvListaEmpleados.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 14.25!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.NullValue = "Vacio"
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvListaEmpleados.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvListaEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 14.25!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvListaEmpleados.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvListaEmpleados.Location = New System.Drawing.Point(0, 33)
        Me.dgvListaEmpleados.Name = "dgvListaEmpleados"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Arial", 14.25!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvListaEmpleados.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvListaEmpleados.RowTemplate.Height = 25
        Me.dgvListaEmpleados.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvListaEmpleados.Size = New System.Drawing.Size(665, 124)
        Me.dgvListaEmpleados.TabIndex = 8
        '
        'cmbPlanillas
        '
        Me.cmbPlanillas.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.cmbPlanillas.FormattingEnabled = True
        Me.cmbPlanillas.Location = New System.Drawing.Point(3, 32)
        Me.cmbPlanillas.Name = "cmbPlanillas"
        Me.cmbPlanillas.Size = New System.Drawing.Size(165, 26)
        Me.cmbPlanillas.TabIndex = 12
        '
        'txtNombre
        '
        Me.txtNombre.Enabled = False
        Me.txtNombre.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtNombre.Location = New System.Drawing.Point(3, 32)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(165, 26)
        Me.txtNombre.TabIndex = 13
        Me.txtNombre.Text = "Nombre"
        Me.txtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCedula
        '
        Me.txtCedula.Enabled = False
        Me.txtCedula.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtCedula.Location = New System.Drawing.Point(3, 32)
        Me.txtCedula.Name = "txtCedula"
        Me.txtCedula.Size = New System.Drawing.Size(165, 26)
        Me.txtCedula.TabIndex = 14
        Me.txtCedula.Text = "Cedula"
        Me.txtCedula.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnAgregar
        '
        Me.btnAgregar.CornerRoundingRadius = 20.0!
        Me.btnAgregar.Location = New System.Drawing.Point(566, 5)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(106, 63)
        Me.btnAgregar.StateCommon.Back.Color1 = System.Drawing.Color.White
        Me.btnAgregar.StateCommon.Back.Color2 = System.Drawing.Color.White
        Me.btnAgregar.StateCommon.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.btnAgregar.StateCommon.Border.Rounding = 20.0!
        Me.btnAgregar.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnAgregar.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold)
        Me.btnAgregar.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnAgregar.StateDisabled.Back.Color2 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnAgregar.StateNormal.Back.Color1 = System.Drawing.Color.White
        Me.btnAgregar.StateNormal.Back.Color2 = System.Drawing.Color.White
        Me.btnAgregar.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnAgregar.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnAgregar.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.btnAgregar.StatePressed.Back.ColorAngle = -45.0!
        Me.btnAgregar.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnAgregar.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.btnAgregar.StatePressed.Border.ColorAngle = 45.0!
        Me.btnAgregar.StatePressed.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.btnAgregar.StatePressed.Border.Width = 1
        Me.btnAgregar.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.White
        Me.btnAgregar.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.White
        Me.btnAgregar.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnAgregar.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.btnAgregar.StateTracking.Back.ColorAngle = -45.0!
        Me.btnAgregar.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnAgregar.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnAgregar.StateTracking.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.btnAgregar.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White
        Me.btnAgregar.TabIndex = 15
        Me.btnAgregar.Values.Text = "Agregar"
        '
        'tbcContenedor
        '
        Me.tbcContenedor.Controls.Add(Me.TabPage1)
        Me.tbcContenedor.Controls.Add(Me.TabPage2)
        Me.tbcContenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbcContenedor.Font = New System.Drawing.Font("Arial", 14.25!)
        Me.tbcContenedor.Location = New System.Drawing.Point(0, 0)
        Me.tbcContenedor.Name = "tbcContenedor"
        Me.tbcContenedor.SelectedIndex = 0
        Me.tbcContenedor.Size = New System.Drawing.Size(686, 390)
        Me.tbcContenedor.TabIndex = 16
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Panel7)
        Me.TabPage1.Controls.Add(Me.Panel5)
        Me.TabPage1.Controls.Add(Me.Panel3)
        Me.TabPage1.Controls.Add(Me.Panel14)
        Me.TabPage1.Controls.Add(Me.Panel1)
        Me.TabPage1.Controls.Add(Me.btnAgregar)
        Me.TabPage1.Location = New System.Drawing.Point(4, 31)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(678, 355)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Semanal"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Panel7
        '
        Me.Panel7.AutoScroll = True
        Me.Panel7.BackColor = System.Drawing.Color.White
        Me.Panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel7.Controls.Add(Me.dtpInicioPlanilla)
        Me.Panel7.Controls.Add(Me.Panel8)
        Me.Panel7.Location = New System.Drawing.Point(7, 72)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(172, 64)
        Me.Panel7.TabIndex = 70
        '
        'dtpInicioPlanilla
        '
        Me.dtpInicioPlanilla.CornerRoundingRadius = 7.0!
        Me.dtpInicioPlanilla.Enabled = False
        Me.dtpInicioPlanilla.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpInicioPlanilla.Location = New System.Drawing.Point(3, 32)
        Me.dtpInicioPlanilla.Name = "dtpInicioPlanilla"
        Me.dtpInicioPlanilla.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.dtpInicioPlanilla.Size = New System.Drawing.Size(164, 28)
        Me.dtpInicioPlanilla.StateCommon.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.dtpInicioPlanilla.StateCommon.Border.Rounding = 7.0!
        Me.dtpInicioPlanilla.StateCommon.Content.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.dtpInicioPlanilla.TabIndex = 56
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Panel8.Controls.Add(Me.Label1)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel8.Location = New System.Drawing.Point(0, 0)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(170, 26)
        Me.Panel8.TabIndex = 55
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 14.25!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(22, 3)
        Me.Label1.Margin = New System.Windows.Forms.Padding(429, 0, 429, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(144, 22)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Inicio de planilla"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Panel5
        '
        Me.Panel5.AutoScroll = True
        Me.Panel5.BackColor = System.Drawing.Color.White
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.Panel6)
        Me.Panel5.Controls.Add(Me.txtNombre)
        Me.Panel5.Location = New System.Drawing.Point(376, 5)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(172, 64)
        Me.Panel5.TabIndex = 70
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Panel6.Controls.Add(Me.lblNombre)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel6.Location = New System.Drawing.Point(0, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(170, 26)
        Me.Panel6.TabIndex = 55
        '
        'lblNombre
        '
        Me.lblNombre.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Arial", 14.25!)
        Me.lblNombre.ForeColor = System.Drawing.Color.White
        Me.lblNombre.Location = New System.Drawing.Point(55, 3)
        Me.lblNombre.Margin = New System.Windows.Forms.Padding(429, 0, 429, 0)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(78, 22)
        Me.lblNombre.TabIndex = 21
        Me.lblNombre.Text = "Nombre"
        Me.lblNombre.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Panel3
        '
        Me.Panel3.AutoScroll = True
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Controls.Add(Me.txtCedula)
        Me.Panel3.Location = New System.Drawing.Point(192, 5)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(172, 64)
        Me.Panel3.TabIndex = 69
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Panel4.Controls.Add(Me.lblCedula)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(170, 26)
        Me.Panel4.TabIndex = 55
        '
        'lblCedula
        '
        Me.lblCedula.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCedula.AutoSize = True
        Me.lblCedula.Font = New System.Drawing.Font("Arial", 14.25!)
        Me.lblCedula.ForeColor = System.Drawing.Color.White
        Me.lblCedula.Location = New System.Drawing.Point(56, 3)
        Me.lblCedula.Margin = New System.Windows.Forms.Padding(429, 0, 429, 0)
        Me.lblCedula.Name = "lblCedula"
        Me.lblCedula.Size = New System.Drawing.Size(70, 22)
        Me.lblCedula.TabIndex = 22
        Me.lblCedula.Text = "Cedula"
        Me.lblCedula.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Panel14
        '
        Me.Panel14.AutoScroll = True
        Me.Panel14.BackColor = System.Drawing.Color.White
        Me.Panel14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel14.Controls.Add(Me.Panel15)
        Me.Panel14.Controls.Add(Me.cmbPlanillas)
        Me.Panel14.Location = New System.Drawing.Point(7, 5)
        Me.Panel14.Name = "Panel14"
        Me.Panel14.Size = New System.Drawing.Size(172, 64)
        Me.Panel14.TabIndex = 68
        '
        'Panel15
        '
        Me.Panel15.BackColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Panel15.Controls.Add(Me.lblPlanila)
        Me.Panel15.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel15.Location = New System.Drawing.Point(0, 0)
        Me.Panel15.Name = "Panel15"
        Me.Panel15.Size = New System.Drawing.Size(170, 26)
        Me.Panel15.TabIndex = 55
        '
        'lblPlanila
        '
        Me.lblPlanila.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblPlanila.AutoSize = True
        Me.lblPlanila.Font = New System.Drawing.Font("Arial", 14.25!)
        Me.lblPlanila.ForeColor = System.Drawing.Color.White
        Me.lblPlanila.Location = New System.Drawing.Point(53, 3)
        Me.lblPlanila.Margin = New System.Windows.Forms.Padding(429, 0, 429, 0)
        Me.lblPlanila.Name = "lblPlanila"
        Me.lblPlanila.Size = New System.Drawing.Size(69, 22)
        Me.lblPlanila.TabIndex = 21
        Me.lblPlanila.Text = "Planilla"
        Me.lblPlanila.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(4, 31)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(678, 355)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Quincenal"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'frmAgregarAPlanilla
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(686, 390)
        Me.ControlBox = False
        Me.Controls.Add(Me.tbcContenedor)
        Me.Name = "frmAgregarAPlanilla"
        Me.Text = "frmAgregarAPlanilla"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.dgvListaEmpleados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbcContenedor.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel14.ResumeLayout(False)
        Me.Panel15.ResumeLayout(False)
        Me.Panel15.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtBuscarEmple As Krypton.Toolkit.KryptonTextBox
    Friend WithEvents btnResetEmpleados As Button
    Friend WithEvents lblListaEmpl As Label
    Friend WithEvents dgvListaEmpleados As DataGridView
    Friend WithEvents cmbPlanillas As ComboBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtCedula As TextBox
    Friend WithEvents btnAgregar As Krypton.Toolkit.KryptonButton
    Friend WithEvents tbcContenedor As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents lblNombre As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel14 As Panel
    Friend WithEvents Panel15 As Panel
    Friend WithEvents lblPlanila As Label
    Friend WithEvents lblCedula As Label
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents dtpInicioPlanilla As Krypton.Toolkit.KryptonDateTimePicker
End Class
