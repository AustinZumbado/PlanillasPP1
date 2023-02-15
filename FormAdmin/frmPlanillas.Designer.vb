<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPlanillas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPlanillas))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.tmMostrarMenu = New System.Windows.Forms.Timer(Me.components)
        Me.tmOcultarMenu = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel14 = New System.Windows.Forms.Panel()
        Me.Panel15 = New System.Windows.Forms.Panel()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.dtpFechaInicio = New System.Windows.Forms.DateTimePicker()
        Me.Panel16 = New System.Windows.Forms.Panel()
        Me.Panel17 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpFechaFinal = New System.Windows.Forms.DateTimePicker()
        Me.panelContenedor = New System.Windows.Forms.Panel()
        Me.tbcContenedor = New System.Windows.Forms.TabControl()
        Me.tbpSemanal = New System.Windows.Forms.TabPage()
        Me.btnEliminar = New Krypton.Toolkit.KryptonButton()
        Me.btnModificar = New Krypton.Toolkit.KryptonButton()
        Me.btnCrear = New Krypton.Toolkit.KryptonButton()
        Me.Panel18 = New System.Windows.Forms.Panel()
        Me.Panel19 = New System.Windows.Forms.Panel()
        Me.txtBuscarEmple = New Krypton.Toolkit.KryptonTextBox()
        Me.btnReiniciar = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dgvListaEmpleados = New System.Windows.Forms.DataGridView()
        Me.tbpQuincenal = New System.Windows.Forms.TabPage()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.txtNombreQuin = New System.Windows.Forms.TextBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.txtBuscarQuincenal = New Krypton.Toolkit.KryptonTextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dgvPlanillaQuincenal = New System.Windows.Forms.DataGridView()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dtpFechaInicialQuin = New System.Windows.Forms.DateTimePicker()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dtpFechaFinalQuin = New System.Windows.Forms.DateTimePicker()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel14.SuspendLayout()
        Me.Panel15.SuspendLayout()
        Me.Panel16.SuspendLayout()
        Me.Panel17.SuspendLayout()
        Me.panelContenedor.SuspendLayout()
        Me.tbcContenedor.SuspendLayout()
        Me.tbpSemanal.SuspendLayout()
        Me.Panel18.SuspendLayout()
        Me.Panel19.SuspendLayout()
        CType(Me.dgvListaEmpleados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbpQuincenal.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel7.SuspendLayout()
        CType(Me.dgvPlanillaQuincenal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel8.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.Panel10.SuspendLayout()
        Me.Panel11.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.txtNombre)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Location = New System.Drawing.Point(5, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(180, 64)
        Me.Panel1.TabIndex = 63
        '
        'txtNombre
        '
        Me.txtNombre.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNombre.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtNombre.Location = New System.Drawing.Point(6, 33)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(167, 26)
        Me.txtNombre.TabIndex = 61
        Me.txtNombre.Text = "Ingrese el nombre"
        Me.txtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(178, 26)
        Me.Panel3.TabIndex = 55
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 14.25!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(51, 3)
        Me.Label1.Margin = New System.Windows.Forms.Padding(429, 0, 429, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 22)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Nombre"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Panel14
        '
        Me.Panel14.AutoScroll = True
        Me.Panel14.BackColor = System.Drawing.Color.White
        Me.Panel14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel14.Controls.Add(Me.Panel15)
        Me.Panel14.Controls.Add(Me.dtpFechaInicio)
        Me.Panel14.Location = New System.Drawing.Point(226, 5)
        Me.Panel14.Name = "Panel14"
        Me.Panel14.Size = New System.Drawing.Size(179, 64)
        Me.Panel14.TabIndex = 69
        '
        'Panel15
        '
        Me.Panel15.BackColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Panel15.Controls.Add(Me.Label46)
        Me.Panel15.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel15.Location = New System.Drawing.Point(0, 0)
        Me.Panel15.Name = "Panel15"
        Me.Panel15.Size = New System.Drawing.Size(177, 26)
        Me.Panel15.TabIndex = 55
        '
        'Label46
        '
        Me.Label46.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label46.AutoSize = True
        Me.Label46.Font = New System.Drawing.Font("Arial", 14.25!)
        Me.Label46.ForeColor = System.Drawing.Color.White
        Me.Label46.Location = New System.Drawing.Point(40, 3)
        Me.Label46.Margin = New System.Windows.Forms.Padding(429, 0, 429, 0)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(116, 22)
        Me.Label46.TabIndex = 22
        Me.Label46.Text = "Fecha Inicial"
        Me.Label46.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'dtpFechaInicio
        '
        Me.dtpFechaInicio.CalendarFont = New System.Drawing.Font("Arial", 9.75!)
        Me.dtpFechaInicio.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.dtpFechaInicio.Location = New System.Drawing.Point(3, 35)
        Me.dtpFechaInicio.Name = "dtpFechaInicio"
        Me.dtpFechaInicio.Size = New System.Drawing.Size(172, 22)
        Me.dtpFechaInicio.TabIndex = 57
        Me.dtpFechaInicio.Value = New Date(2023, 1, 1, 0, 0, 0, 0)
        '
        'Panel16
        '
        Me.Panel16.AutoScroll = True
        Me.Panel16.BackColor = System.Drawing.Color.White
        Me.Panel16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel16.Controls.Add(Me.Panel17)
        Me.Panel16.Controls.Add(Me.dtpFechaFinal)
        Me.Panel16.Location = New System.Drawing.Point(453, 5)
        Me.Panel16.Name = "Panel16"
        Me.Panel16.Size = New System.Drawing.Size(179, 64)
        Me.Panel16.TabIndex = 70
        '
        'Panel17
        '
        Me.Panel17.BackColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Panel17.Controls.Add(Me.Label2)
        Me.Panel17.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel17.Location = New System.Drawing.Point(0, 0)
        Me.Panel17.Name = "Panel17"
        Me.Panel17.Size = New System.Drawing.Size(177, 26)
        Me.Panel17.TabIndex = 55
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 14.25!)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(44, 3)
        Me.Label2.Margin = New System.Windows.Forms.Padding(429, 0, 429, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 22)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Fecha Final"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'dtpFechaFinal
        '
        Me.dtpFechaFinal.CalendarFont = New System.Drawing.Font("Arial", 9.75!)
        Me.dtpFechaFinal.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.dtpFechaFinal.Location = New System.Drawing.Point(3, 34)
        Me.dtpFechaFinal.Name = "dtpFechaFinal"
        Me.dtpFechaFinal.Size = New System.Drawing.Size(172, 22)
        Me.dtpFechaFinal.TabIndex = 58
        Me.dtpFechaFinal.Value = New Date(2023, 1, 1, 0, 0, 0, 0)
        '
        'panelContenedor
        '
        Me.panelContenedor.Controls.Add(Me.tbcContenedor)
        Me.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelContenedor.Location = New System.Drawing.Point(0, 0)
        Me.panelContenedor.Name = "panelContenedor"
        Me.panelContenedor.Size = New System.Drawing.Size(860, 615)
        Me.panelContenedor.TabIndex = 62
        '
        'tbcContenedor
        '
        Me.tbcContenedor.Controls.Add(Me.tbpSemanal)
        Me.tbcContenedor.Controls.Add(Me.tbpQuincenal)
        Me.tbcContenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbcContenedor.Font = New System.Drawing.Font("Arial", 14.25!)
        Me.tbcContenedor.Location = New System.Drawing.Point(0, 0)
        Me.tbcContenedor.Name = "tbcContenedor"
        Me.tbcContenedor.SelectedIndex = 0
        Me.tbcContenedor.Size = New System.Drawing.Size(860, 615)
        Me.tbcContenedor.TabIndex = 72
        '
        'tbpSemanal
        '
        Me.tbpSemanal.Controls.Add(Me.btnEliminar)
        Me.tbpSemanal.Controls.Add(Me.btnModificar)
        Me.tbpSemanal.Controls.Add(Me.btnCrear)
        Me.tbpSemanal.Controls.Add(Me.Panel1)
        Me.tbpSemanal.Controls.Add(Me.Panel18)
        Me.tbpSemanal.Controls.Add(Me.Panel14)
        Me.tbpSemanal.Controls.Add(Me.Panel16)
        Me.tbpSemanal.Location = New System.Drawing.Point(4, 31)
        Me.tbpSemanal.Name = "tbpSemanal"
        Me.tbpSemanal.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpSemanal.Size = New System.Drawing.Size(852, 580)
        Me.tbpSemanal.TabIndex = 0
        Me.tbpSemanal.Text = "Semanal"
        Me.tbpSemanal.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnEliminar.CornerRoundingRadius = 20.0!
        Me.btnEliminar.Location = New System.Drawing.Point(290, 443)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(137, 35)
        Me.btnEliminar.StateCommon.Back.Color1 = System.Drawing.Color.White
        Me.btnEliminar.StateCommon.Back.Color2 = System.Drawing.Color.White
        Me.btnEliminar.StateCommon.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.btnEliminar.StateCommon.Border.Rounding = 20.0!
        Me.btnEliminar.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnEliminar.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold)
        Me.btnEliminar.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnEliminar.StateDisabled.Back.Color2 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnEliminar.StateNormal.Back.Color1 = System.Drawing.Color.White
        Me.btnEliminar.StateNormal.Back.Color2 = System.Drawing.Color.White
        Me.btnEliminar.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnEliminar.StateNormal.Border.Color2 = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnEliminar.StateNormal.Border.ColorAngle = 45.0!
        Me.btnEliminar.StateNormal.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.btnEliminar.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnEliminar.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnEliminar.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.btnEliminar.StatePressed.Back.ColorAngle = -45.0!
        Me.btnEliminar.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnEliminar.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.btnEliminar.StatePressed.Border.ColorAngle = 45.0!
        Me.btnEliminar.StatePressed.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.btnEliminar.StatePressed.Border.Width = 1
        Me.btnEliminar.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.White
        Me.btnEliminar.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.White
        Me.btnEliminar.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnEliminar.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnEliminar.StateTracking.Back.ColorAngle = 45.0!
        Me.btnEliminar.StateTracking.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.btnEliminar.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White
        Me.btnEliminar.TabIndex = 75
        Me.btnEliminar.Values.Text = "Eliminar"
        '
        'btnModificar
        '
        Me.btnModificar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnModificar.CornerRoundingRadius = 20.0!
        Me.btnModificar.Location = New System.Drawing.Point(147, 443)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(137, 35)
        Me.btnModificar.StateCommon.Back.Color1 = System.Drawing.Color.White
        Me.btnModificar.StateCommon.Back.Color2 = System.Drawing.Color.White
        Me.btnModificar.StateCommon.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.btnModificar.StateCommon.Border.Rounding = 20.0!
        Me.btnModificar.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnModificar.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold)
        Me.btnModificar.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnModificar.StateDisabled.Back.Color2 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnModificar.StateNormal.Back.Color1 = System.Drawing.Color.White
        Me.btnModificar.StateNormal.Back.Color2 = System.Drawing.Color.White
        Me.btnModificar.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnModificar.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnModificar.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.btnModificar.StatePressed.Back.ColorAngle = -45.0!
        Me.btnModificar.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnModificar.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.btnModificar.StatePressed.Border.ColorAngle = 45.0!
        Me.btnModificar.StatePressed.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.btnModificar.StatePressed.Border.Width = 1
        Me.btnModificar.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.White
        Me.btnModificar.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.White
        Me.btnModificar.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnModificar.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.btnModificar.StateTracking.Back.ColorAngle = -45.0!
        Me.btnModificar.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnModificar.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnModificar.StateTracking.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.btnModificar.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White
        Me.btnModificar.TabIndex = 74
        Me.btnModificar.Values.Text = "Modificar"
        '
        'btnCrear
        '
        Me.btnCrear.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnCrear.CornerRoundingRadius = 20.0!
        Me.btnCrear.Location = New System.Drawing.Point(5, 443)
        Me.btnCrear.Name = "btnCrear"
        Me.btnCrear.Size = New System.Drawing.Size(137, 35)
        Me.btnCrear.StateCommon.Back.Color1 = System.Drawing.Color.White
        Me.btnCrear.StateCommon.Back.Color2 = System.Drawing.Color.White
        Me.btnCrear.StateCommon.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.btnCrear.StateCommon.Border.Rounding = 20.0!
        Me.btnCrear.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnCrear.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold)
        Me.btnCrear.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnCrear.StateDisabled.Back.Color2 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnCrear.StateNormal.Back.Color1 = System.Drawing.Color.White
        Me.btnCrear.StateNormal.Back.Color2 = System.Drawing.Color.White
        Me.btnCrear.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.btnCrear.StateNormal.Border.Color2 = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.btnCrear.StateNormal.Border.ColorAngle = 46.0!
        Me.btnCrear.StateNormal.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.btnCrear.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.btnCrear.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnCrear.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.btnCrear.StatePressed.Back.ColorAngle = -45.0!
        Me.btnCrear.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnCrear.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.btnCrear.StatePressed.Border.ColorAngle = 45.0!
        Me.btnCrear.StatePressed.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.btnCrear.StatePressed.Border.Width = 1
        Me.btnCrear.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.White
        Me.btnCrear.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.White
        Me.btnCrear.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.btnCrear.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.btnCrear.StateTracking.Back.ColorAngle = 45.0!
        Me.btnCrear.StateTracking.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.btnCrear.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White
        Me.btnCrear.TabIndex = 72
        Me.btnCrear.Values.Text = "Agregar"
        '
        'Panel18
        '
        Me.Panel18.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel18.BackColor = System.Drawing.Color.White
        Me.Panel18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel18.Controls.Add(Me.Panel19)
        Me.Panel18.Controls.Add(Me.dgvListaEmpleados)
        Me.Panel18.Location = New System.Drawing.Point(5, 74)
        Me.Panel18.Name = "Panel18"
        Me.Panel18.Size = New System.Drawing.Size(839, 364)
        Me.Panel18.TabIndex = 71
        '
        'Panel19
        '
        Me.Panel19.BackColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Panel19.Controls.Add(Me.txtBuscarEmple)
        Me.Panel19.Controls.Add(Me.btnReiniciar)
        Me.Panel19.Controls.Add(Me.Label7)
        Me.Panel19.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel19.Location = New System.Drawing.Point(0, 0)
        Me.Panel19.Name = "Panel19"
        Me.Panel19.Size = New System.Drawing.Size(837, 31)
        Me.Panel19.TabIndex = 9
        '
        'txtBuscarEmple
        '
        Me.txtBuscarEmple.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.txtBuscarEmple.Location = New System.Drawing.Point(699, 1)
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
        'btnReiniciar
        '
        Me.btnReiniciar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnReiniciar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReiniciar.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnReiniciar.FlatAppearance.BorderSize = 0
        Me.btnReiniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReiniciar.Image = CType(resources.GetObject("btnReiniciar.Image"), System.Drawing.Image)
        Me.btnReiniciar.Location = New System.Drawing.Point(803, 0)
        Me.btnReiniciar.Name = "btnReiniciar"
        Me.btnReiniciar.Size = New System.Drawing.Size(34, 31)
        Me.btnReiniciar.TabIndex = 10
        Me.btnReiniciar.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 14.25!)
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(5, 5)
        Me.Label7.Margin = New System.Windows.Forms.Padding(429, 0, 429, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(225, 22)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Lista de planillas semanal"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'dgvListaEmpleados
        '
        Me.dgvListaEmpleados.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvListaEmpleados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvListaEmpleados.BackgroundColor = System.Drawing.Color.White
        Me.dgvListaEmpleados.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
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
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvListaEmpleados.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvListaEmpleados.Location = New System.Drawing.Point(0, 33)
        Me.dgvListaEmpleados.Name = "dgvListaEmpleados"
        Me.dgvListaEmpleados.RowTemplate.Height = 25
        Me.dgvListaEmpleados.Size = New System.Drawing.Size(837, 330)
        Me.dgvListaEmpleados.TabIndex = 8
        '
        'tbpQuincenal
        '
        Me.tbpQuincenal.Controls.Add(Me.Panel4)
        Me.tbpQuincenal.Controls.Add(Me.Panel6)
        Me.tbpQuincenal.Controls.Add(Me.Panel8)
        Me.tbpQuincenal.Controls.Add(Me.Panel10)
        Me.tbpQuincenal.Location = New System.Drawing.Point(4, 31)
        Me.tbpQuincenal.Name = "tbpQuincenal"
        Me.tbpQuincenal.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpQuincenal.Size = New System.Drawing.Size(852, 580)
        Me.tbpQuincenal.TabIndex = 1
        Me.tbpQuincenal.Text = "Quincenal"
        Me.tbpQuincenal.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.AutoScroll = True
        Me.Panel4.BackColor = System.Drawing.Color.White
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.txtNombreQuin)
        Me.Panel4.Controls.Add(Me.Panel5)
        Me.Panel4.Location = New System.Drawing.Point(5, 6)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(180, 64)
        Me.Panel4.TabIndex = 72
        '
        'txtNombreQuin
        '
        Me.txtNombreQuin.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.txtNombreQuin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNombreQuin.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtNombreQuin.Location = New System.Drawing.Point(6, 32)
        Me.txtNombreQuin.Name = "txtNombreQuin"
        Me.txtNombreQuin.Size = New System.Drawing.Size(167, 26)
        Me.txtNombreQuin.TabIndex = 61
        Me.txtNombreQuin.Text = "Ingrese el nombre"
        Me.txtNombreQuin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Panel5.Controls.Add(Me.Label3)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(178, 26)
        Me.Panel5.TabIndex = 55
        '
        'Label3
        '
        Me.Label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 14.25!)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(54, 4)
        Me.Label3.Margin = New System.Windows.Forms.Padding(429, 0, 429, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 22)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Nombre"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Panel6
        '
        Me.Panel6.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel6.BackColor = System.Drawing.Color.White
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel6.Controls.Add(Me.Panel7)
        Me.Panel6.Controls.Add(Me.dgvPlanillaQuincenal)
        Me.Panel6.Location = New System.Drawing.Point(202, 7)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(431, 219)
        Me.Panel6.TabIndex = 75
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Panel7.Controls.Add(Me.txtBuscarQuincenal)
        Me.Panel7.Controls.Add(Me.Button1)
        Me.Panel7.Controls.Add(Me.Label5)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel7.Location = New System.Drawing.Point(0, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(429, 31)
        Me.Panel7.TabIndex = 9
        '
        'txtBuscarQuincenal
        '
        Me.txtBuscarQuincenal.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.txtBuscarQuincenal.Location = New System.Drawing.Point(291, 3)
        Me.txtBuscarQuincenal.Name = "txtBuscarQuincenal"
        Me.txtBuscarQuincenal.Size = New System.Drawing.Size(99, 28)
        Me.txtBuscarQuincenal.StateCommon.Back.Color1 = System.Drawing.Color.White
        Me.txtBuscarQuincenal.StateCommon.Border.Color1 = System.Drawing.Color.White
        Me.txtBuscarQuincenal.StateCommon.Border.Color2 = System.Drawing.Color.White
        Me.txtBuscarQuincenal.StateCommon.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.txtBuscarQuincenal.StateCommon.Border.Rounding = 10.0!
        Me.txtBuscarQuincenal.StateCommon.Content.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.txtBuscarQuincenal.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.txtBuscarQuincenal.StateNormal.Border.Color1 = System.Drawing.Color.White
        Me.txtBuscarQuincenal.StateNormal.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.txtBuscarQuincenal.TabIndex = 15
        Me.txtBuscarQuincenal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button1
        '
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(395, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(34, 31)
        Me.Button1.TabIndex = 10
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 14.25!)
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(3, 6)
        Me.Label5.Margin = New System.Windows.Forms.Padding(429, 0, 429, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(234, 22)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Lista de planillas quincenal"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'dgvPlanillaQuincenal
        '
        Me.dgvPlanillaQuincenal.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvPlanillaQuincenal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvPlanillaQuincenal.BackgroundColor = System.Drawing.Color.White
        Me.dgvPlanillaQuincenal.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Arial", 14.25!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.NullValue = "Vacio"
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvPlanillaQuincenal.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvPlanillaQuincenal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Arial", 14.25!)
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvPlanillaQuincenal.DefaultCellStyle = DataGridViewCellStyle4
        Me.dgvPlanillaQuincenal.Location = New System.Drawing.Point(0, 33)
        Me.dgvPlanillaQuincenal.Name = "dgvPlanillaQuincenal"
        Me.dgvPlanillaQuincenal.RowTemplate.Height = 25
        Me.dgvPlanillaQuincenal.Size = New System.Drawing.Size(430, 185)
        Me.dgvPlanillaQuincenal.TabIndex = 8
        '
        'Panel8
        '
        Me.Panel8.AutoScroll = True
        Me.Panel8.BackColor = System.Drawing.Color.White
        Me.Panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel8.Controls.Add(Me.Panel9)
        Me.Panel8.Controls.Add(Me.dtpFechaInicialQuin)
        Me.Panel8.Location = New System.Drawing.Point(5, 84)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(179, 64)
        Me.Panel8.TabIndex = 73
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Panel9.Controls.Add(Me.Label6)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel9.Location = New System.Drawing.Point(0, 0)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(177, 26)
        Me.Panel9.TabIndex = 55
        '
        'Label6
        '
        Me.Label6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 14.25!)
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(39, 3)
        Me.Label6.Margin = New System.Windows.Forms.Padding(429, 0, 429, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(116, 22)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "Fecha Inicial"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'dtpFechaInicialQuin
        '
        Me.dtpFechaInicialQuin.CalendarFont = New System.Drawing.Font("Arial", 9.75!)
        Me.dtpFechaInicialQuin.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.dtpFechaInicialQuin.Location = New System.Drawing.Point(3, 35)
        Me.dtpFechaInicialQuin.Name = "dtpFechaInicialQuin"
        Me.dtpFechaInicialQuin.Size = New System.Drawing.Size(172, 22)
        Me.dtpFechaInicialQuin.TabIndex = 57
        Me.dtpFechaInicialQuin.Value = New Date(2023, 1, 1, 0, 0, 0, 0)
        '
        'Panel10
        '
        Me.Panel10.AutoScroll = True
        Me.Panel10.BackColor = System.Drawing.Color.White
        Me.Panel10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel10.Controls.Add(Me.Panel11)
        Me.Panel10.Controls.Add(Me.dtpFechaFinalQuin)
        Me.Panel10.Location = New System.Drawing.Point(6, 162)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(179, 64)
        Me.Panel10.TabIndex = 74
        '
        'Panel11
        '
        Me.Panel11.BackColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Panel11.Controls.Add(Me.Label8)
        Me.Panel11.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel11.Location = New System.Drawing.Point(0, 0)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(177, 26)
        Me.Panel11.TabIndex = 55
        '
        'Label8
        '
        Me.Label8.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 14.25!)
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(43, 3)
        Me.Label8.Margin = New System.Windows.Forms.Padding(429, 0, 429, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(108, 22)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "Fecha Final"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'dtpFechaFinalQuin
        '
        Me.dtpFechaFinalQuin.CalendarFont = New System.Drawing.Font("Arial", 9.75!)
        Me.dtpFechaFinalQuin.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.dtpFechaFinalQuin.Location = New System.Drawing.Point(3, 34)
        Me.dtpFechaFinalQuin.Name = "dtpFechaFinalQuin"
        Me.dtpFechaFinalQuin.Size = New System.Drawing.Size(172, 22)
        Me.dtpFechaFinalQuin.TabIndex = 58
        Me.dtpFechaFinalQuin.Value = New Date(2023, 1, 1, 0, 0, 0, 0)
        '
        'frmPlanillas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(860, 615)
        Me.Controls.Add(Me.panelContenedor)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmPlanillas"
        Me.Text = "frmPlanillas"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel14.ResumeLayout(False)
        Me.Panel15.ResumeLayout(False)
        Me.Panel15.PerformLayout()
        Me.Panel16.ResumeLayout(False)
        Me.Panel17.ResumeLayout(False)
        Me.Panel17.PerformLayout()
        Me.panelContenedor.ResumeLayout(False)
        Me.tbcContenedor.ResumeLayout(False)
        Me.tbpSemanal.ResumeLayout(False)
        Me.Panel18.ResumeLayout(False)
        Me.Panel19.ResumeLayout(False)
        Me.Panel19.PerformLayout()
        CType(Me.dgvListaEmpleados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbpQuincenal.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        CType(Me.dgvPlanillaQuincenal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel8.ResumeLayout(False)
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        Me.Panel10.ResumeLayout(False)
        Me.Panel11.ResumeLayout(False)
        Me.Panel11.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tmMostrarMenu As Timer
    Friend WithEvents tmOcultarMenu As Timer
    Friend WithEvents panelContenedor As Panel
    Friend WithEvents Panel16 As Panel
    Friend WithEvents Panel17 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents dtpFechaFinal As DateTimePicker
    Friend WithEvents Panel14 As Panel
    Friend WithEvents Panel15 As Panel
    Friend WithEvents Label46 As Label
    Friend WithEvents dtpFechaInicio As DateTimePicker
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel18 As Panel
    Friend WithEvents Panel19 As Panel
    Friend WithEvents txtBuscarEmple As Krypton.Toolkit.KryptonTextBox
    Friend WithEvents btnReiniciar As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents dgvListaEmpleados As DataGridView
    Friend WithEvents tbcContenedor As TabControl
    Friend WithEvents tbpSemanal As TabPage
    Friend WithEvents tbpQuincenal As TabPage
    Friend WithEvents Panel4 As Panel
    Friend WithEvents txtNombreQuin As TextBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents txtBuscarQuincenal As Krypton.Toolkit.KryptonTextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents dgvPlanillaQuincenal As DataGridView
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents dtpFechaInicialQuin As DateTimePicker
    Friend WithEvents Panel10 As Panel
    Friend WithEvents Panel11 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents dtpFechaFinalQuin As DateTimePicker
    Friend WithEvents btnEliminar As Krypton.Toolkit.KryptonButton
    Friend WithEvents btnModificar As Krypton.Toolkit.KryptonButton
    Friend WithEvents btnCrear As Krypton.Toolkit.KryptonButton
End Class
