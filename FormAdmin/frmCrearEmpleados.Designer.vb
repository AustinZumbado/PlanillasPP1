<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCrearEmpleados
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCrearEmpleados))
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.cmbSexo = New System.Windows.Forms.ComboBox()
        Me.ttMensaje = New System.Windows.Forms.ToolTip(Me.components)
        Me.dtpFechaIngreso = New System.Windows.Forms.DateTimePicker()
        Me.tmMostrarMenu = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.tmOcultarMenu = New System.Windows.Forms.Timer(Me.components)
        Me.panelContenedor = New System.Windows.Forms.Panel()
        Me.btnEliminar = New Krypton.Toolkit.KryptonButton()
        Me.btnModificar = New Krypton.Toolkit.KryptonButton()
        Me.btnCrear = New Krypton.Toolkit.KryptonButton()
        Me.Panel18 = New System.Windows.Forms.Panel()
        Me.Panel19 = New System.Windows.Forms.Panel()
        Me.txtBuscarEmpleado = New Krypton.Toolkit.KryptonTextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtBuscarEmple = New Krypton.Toolkit.KryptonTextBox()
        Me.btnResetEmpleados = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dgvListaEmpleados = New System.Windows.Forms.DataGridView()
        Me.Panel16 = New System.Windows.Forms.Panel()
        Me.Panel17 = New System.Windows.Forms.Panel()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.dtpFechaSalida = New System.Windows.Forms.DateTimePicker()
        Me.Panel14 = New System.Windows.Forms.Panel()
        Me.Panel15 = New System.Windows.Forms.Panel()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.Panel13 = New System.Windows.Forms.Panel()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.cmbFormaPago = New System.Windows.Forms.ComboBox()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.cmbTipoUsuario = New System.Windows.Forms.ComboBox()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.txtCedula = New System.Windows.Forms.TextBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tmCalcularHora = New System.Windows.Forms.Timer(Me.components)
        Me.btnReporte = New Krypton.Toolkit.KryptonButton()
        Me.panelContenedor.SuspendLayout()
        Me.Panel18.SuspendLayout()
        Me.Panel19.SuspendLayout()
        CType(Me.dgvListaEmpleados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel16.SuspendLayout()
        Me.Panel17.SuspendLayout()
        Me.Panel14.SuspendLayout()
        Me.Panel15.SuspendLayout()
        Me.Panel12.SuspendLayout()
        Me.Panel13.SuspendLayout()
        Me.Panel10.SuspendLayout()
        Me.Panel11.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmbSexo
        '
        Me.cmbSexo.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.cmbSexo.FormattingEnabled = True
        Me.cmbSexo.Items.AddRange(New Object() {"Masculino", "Femenino"})
        Me.cmbSexo.Location = New System.Drawing.Point(3, 33)
        Me.cmbSexo.Name = "cmbSexo"
        Me.cmbSexo.Size = New System.Drawing.Size(165, 26)
        Me.cmbSexo.TabIndex = 48
        Me.cmbSexo.Text = "Elija una opcion"
        '
        'dtpFechaIngreso
        '
        Me.dtpFechaIngreso.CalendarFont = New System.Drawing.Font("Arial", 9.75!)
        Me.dtpFechaIngreso.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.dtpFechaIngreso.Location = New System.Drawing.Point(3, 35)
        Me.dtpFechaIngreso.Name = "dtpFechaIngreso"
        Me.dtpFechaIngreso.Size = New System.Drawing.Size(172, 22)
        Me.dtpFechaIngreso.TabIndex = 57
        Me.dtpFechaIngreso.Value = New Date(2023, 1, 3, 0, 0, 0, 0)
        '
        'panelContenedor
        '
        Me.panelContenedor.AutoScroll = True
        Me.panelContenedor.BackColor = System.Drawing.Color.White
        Me.panelContenedor.Controls.Add(Me.btnReporte)
        Me.panelContenedor.Controls.Add(Me.btnEliminar)
        Me.panelContenedor.Controls.Add(Me.btnModificar)
        Me.panelContenedor.Controls.Add(Me.btnCrear)
        Me.panelContenedor.Controls.Add(Me.Panel18)
        Me.panelContenedor.Controls.Add(Me.Panel16)
        Me.panelContenedor.Controls.Add(Me.Panel14)
        Me.panelContenedor.Controls.Add(Me.Panel12)
        Me.panelContenedor.Controls.Add(Me.Panel10)
        Me.panelContenedor.Controls.Add(Me.Panel8)
        Me.panelContenedor.Controls.Add(Me.Panel6)
        Me.panelContenedor.Controls.Add(Me.Panel1)
        Me.panelContenedor.Controls.Add(Me.Panel4)
        Me.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelContenedor.Location = New System.Drawing.Point(0, 0)
        Me.panelContenedor.Name = "panelContenedor"
        Me.panelContenedor.Size = New System.Drawing.Size(860, 615)
        Me.panelContenedor.TabIndex = 60
        '
        'btnEliminar
        '
        Me.btnEliminar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnEliminar.CornerRoundingRadius = 20.0!
        Me.btnEliminar.Location = New System.Drawing.Point(303, 502)
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
        Me.btnEliminar.TabIndex = 78
        Me.btnEliminar.Values.Text = "Eliminar"
        '
        'btnModificar
        '
        Me.btnModificar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnModificar.CornerRoundingRadius = 20.0!
        Me.btnModificar.Location = New System.Drawing.Point(160, 502)
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
        Me.btnModificar.TabIndex = 77
        Me.btnModificar.Values.Text = "Modificar"
        '
        'btnCrear
        '
        Me.btnCrear.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnCrear.CornerRoundingRadius = 20.0!
        Me.btnCrear.Location = New System.Drawing.Point(18, 502)
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
        Me.btnCrear.TabIndex = 76
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
        Me.Panel18.Location = New System.Drawing.Point(18, 236)
        Me.Panel18.Name = "Panel18"
        Me.Panel18.Size = New System.Drawing.Size(832, 261)
        Me.Panel18.TabIndex = 69
        '
        'Panel19
        '
        Me.Panel19.BackColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Panel19.Controls.Add(Me.txtBuscarEmpleado)
        Me.Panel19.Controls.Add(Me.Label10)
        Me.Panel19.Controls.Add(Me.txtBuscarEmple)
        Me.Panel19.Controls.Add(Me.btnResetEmpleados)
        Me.Panel19.Controls.Add(Me.Label7)
        Me.Panel19.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel19.Location = New System.Drawing.Point(0, 0)
        Me.Panel19.Name = "Panel19"
        Me.Panel19.Size = New System.Drawing.Size(830, 40)
        Me.Panel19.TabIndex = 9
        '
        'txtBuscarEmpleado
        '
        Me.txtBuscarEmpleado.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.txtBuscarEmpleado.Location = New System.Drawing.Point(691, 5)
        Me.txtBuscarEmpleado.Name = "txtBuscarEmpleado"
        Me.txtBuscarEmpleado.Size = New System.Drawing.Size(99, 28)
        Me.txtBuscarEmpleado.StateCommon.Back.Color1 = System.Drawing.Color.White
        Me.txtBuscarEmpleado.StateCommon.Border.Color1 = System.Drawing.Color.White
        Me.txtBuscarEmpleado.StateCommon.Border.Color2 = System.Drawing.Color.White
        Me.txtBuscarEmpleado.StateCommon.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.txtBuscarEmpleado.StateCommon.Border.Rounding = 10.0!
        Me.txtBuscarEmpleado.StateCommon.Content.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.txtBuscarEmpleado.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.txtBuscarEmpleado.StateNormal.Border.Color1 = System.Drawing.Color.White
        Me.txtBuscarEmpleado.StateNormal.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.txtBuscarEmpleado.TabIndex = 19
        Me.txtBuscarEmpleado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label10
        '
        Me.Label10.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial", 14.25!)
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(-2, 7)
        Me.Label10.Margin = New System.Windows.Forms.Padding(429, 0, 429, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(177, 22)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "Lista de empleados"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtBuscarEmple
        '
        Me.txtBuscarEmple.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.txtBuscarEmple.Location = New System.Drawing.Point(1141, -19)
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
        Me.btnResetEmpleados.Location = New System.Drawing.Point(796, 0)
        Me.btnResetEmpleados.Name = "btnResetEmpleados"
        Me.btnResetEmpleados.Size = New System.Drawing.Size(34, 40)
        Me.btnResetEmpleados.TabIndex = 10
        Me.btnResetEmpleados.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 14.25!)
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(6, -38)
        Me.Label7.Margin = New System.Windows.Forms.Padding(429, 0, 429, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(177, 22)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Lista de empleados"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'dgvListaEmpleados
        '
        Me.dgvListaEmpleados.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvListaEmpleados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvListaEmpleados.BackgroundColor = System.Drawing.Color.White
        Me.dgvListaEmpleados.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.NullValue = "Vacio"
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvListaEmpleados.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvListaEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Arial", 12.0!)
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvListaEmpleados.DefaultCellStyle = DataGridViewCellStyle4
        Me.dgvListaEmpleados.Location = New System.Drawing.Point(0, 39)
        Me.dgvListaEmpleados.Name = "dgvListaEmpleados"
        Me.dgvListaEmpleados.RowTemplate.Height = 25
        Me.dgvListaEmpleados.Size = New System.Drawing.Size(831, 221)
        Me.dgvListaEmpleados.TabIndex = 8
        '
        'Panel16
        '
        Me.Panel16.AutoScroll = True
        Me.Panel16.BackColor = System.Drawing.Color.White
        Me.Panel16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel16.Controls.Add(Me.Panel17)
        Me.Panel16.Controls.Add(Me.dtpFechaSalida)
        Me.Panel16.Location = New System.Drawing.Point(443, 85)
        Me.Panel16.Name = "Panel16"
        Me.Panel16.Size = New System.Drawing.Size(179, 64)
        Me.Panel16.TabIndex = 68
        '
        'Panel17
        '
        Me.Panel17.BackColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Panel17.Controls.Add(Me.Label46)
        Me.Panel17.Controls.Add(Me.Label6)
        Me.Panel17.Controls.Add(Me.Label39)
        Me.Panel17.Controls.Add(Me.Label40)
        Me.Panel17.Controls.Add(Me.Label41)
        Me.Panel17.Controls.Add(Me.Label42)
        Me.Panel17.Controls.Add(Me.Label43)
        Me.Panel17.Controls.Add(Me.Label44)
        Me.Panel17.Controls.Add(Me.Label45)
        Me.Panel17.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel17.Location = New System.Drawing.Point(0, 0)
        Me.Panel17.Name = "Panel17"
        Me.Panel17.Size = New System.Drawing.Size(177, 26)
        Me.Panel17.TabIndex = 55
        '
        'Label46
        '
        Me.Label46.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label46.AutoSize = True
        Me.Label46.Font = New System.Drawing.Font("Arial", 14.25!)
        Me.Label46.ForeColor = System.Drawing.Color.White
        Me.Label46.Location = New System.Drawing.Point(21, 3)
        Me.Label46.Margin = New System.Windows.Forms.Padding(429, 0, 429, 0)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(144, 22)
        Me.Label46.TabIndex = 22
        Me.Label46.Text = "Fecha de salida"
        Me.Label46.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label6
        '
        Me.Label6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 14.25!)
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(18, -57)
        Me.Label6.Margin = New System.Windows.Forms.Padding(429, 0, 429, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(158, 22)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Fecha de ingreso"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label39
        '
        Me.Label39.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label39.AutoSize = True
        Me.Label39.Font = New System.Drawing.Font("Arial", 14.25!)
        Me.Label39.ForeColor = System.Drawing.Color.White
        Me.Label39.Location = New System.Drawing.Point(26, -119)
        Me.Label39.Margin = New System.Windows.Forms.Padding(429, 0, 429, 0)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(140, 22)
        Me.Label39.TabIndex = 20
        Me.Label39.Text = "Forma de pago"
        Me.Label39.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label40
        '
        Me.Label40.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label40.AutoSize = True
        Me.Label40.Font = New System.Drawing.Font("Arial", 14.25!)
        Me.Label40.ForeColor = System.Drawing.Color.White
        Me.Label40.Location = New System.Drawing.Point(51, -178)
        Me.Label40.Margin = New System.Windows.Forms.Padding(429, 0, 429, 0)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(70, 22)
        Me.Label40.TabIndex = 19
        Me.Label40.Text = "Puesto"
        Me.Label40.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label41
        '
        Me.Label41.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label41.AutoSize = True
        Me.Label41.Font = New System.Drawing.Font("Arial", 14.25!)
        Me.Label41.ForeColor = System.Drawing.Color.White
        Me.Label41.Location = New System.Drawing.Point(51, -239)
        Me.Label41.Margin = New System.Windows.Forms.Padding(429, 0, 429, 0)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(74, 22)
        Me.Label41.TabIndex = 18
        Me.Label41.Text = "Genero"
        Me.Label41.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label42
        '
        Me.Label42.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label42.AutoSize = True
        Me.Label42.Font = New System.Drawing.Font("Arial", 14.25!)
        Me.Label42.ForeColor = System.Drawing.Color.White
        Me.Label42.Location = New System.Drawing.Point(57, -302)
        Me.Label42.Margin = New System.Windows.Forms.Padding(429, 0, 429, 0)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(79, 22)
        Me.Label42.TabIndex = 17
        Me.Label42.Text = "Apellido"
        Me.Label42.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label43
        '
        Me.Label43.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label43.AutoSize = True
        Me.Label43.Font = New System.Drawing.Font("Arial", 14.25!)
        Me.Label43.ForeColor = System.Drawing.Color.White
        Me.Label43.Location = New System.Drawing.Point(55, -361)
        Me.Label43.Margin = New System.Windows.Forms.Padding(429, 0, 429, 0)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(78, 22)
        Me.Label43.TabIndex = 16
        Me.Label43.Text = "Nombre"
        Me.Label43.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label44
        '
        Me.Label44.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label44.AutoSize = True
        Me.Label44.Font = New System.Drawing.Font("Arial", 14.25!)
        Me.Label44.ForeColor = System.Drawing.Color.White
        Me.Label44.Location = New System.Drawing.Point(55, -421)
        Me.Label44.Margin = New System.Windows.Forms.Padding(429, 0, 429, 0)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(70, 22)
        Me.Label44.TabIndex = 15
        Me.Label44.Text = "Cedula"
        Me.Label44.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label45
        '
        Me.Label45.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label45.AutoSize = True
        Me.Label45.Font = New System.Drawing.Font("Arial", 14.25!)
        Me.Label45.ForeColor = System.Drawing.Color.White
        Me.Label45.Location = New System.Drawing.Point(52, -483)
        Me.Label45.Margin = New System.Windows.Forms.Padding(429, 0, 429, 0)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(70, 22)
        Me.Label45.TabIndex = 14
        Me.Label45.Text = "Cedula"
        Me.Label45.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'dtpFechaSalida
        '
        Me.dtpFechaSalida.CalendarFont = New System.Drawing.Font("Arial", 9.75!)
        Me.dtpFechaSalida.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.dtpFechaSalida.Location = New System.Drawing.Point(2, 34)
        Me.dtpFechaSalida.Name = "dtpFechaSalida"
        Me.dtpFechaSalida.Size = New System.Drawing.Size(172, 22)
        Me.dtpFechaSalida.TabIndex = 58
        Me.dtpFechaSalida.Value = New Date(2023, 1, 3, 0, 0, 0, 0)
        '
        'Panel14
        '
        Me.Panel14.AutoScroll = True
        Me.Panel14.BackColor = System.Drawing.Color.White
        Me.Panel14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel14.Controls.Add(Me.Panel15)
        Me.Panel14.Controls.Add(Me.dtpFechaIngreso)
        Me.Panel14.Location = New System.Drawing.Point(442, 10)
        Me.Panel14.Name = "Panel14"
        Me.Panel14.Size = New System.Drawing.Size(179, 64)
        Me.Panel14.TabIndex = 67
        '
        'Panel15
        '
        Me.Panel15.BackColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Panel15.Controls.Add(Me.Label38)
        Me.Panel15.Controls.Add(Me.Label31)
        Me.Panel15.Controls.Add(Me.Label32)
        Me.Panel15.Controls.Add(Me.Label33)
        Me.Panel15.Controls.Add(Me.Label34)
        Me.Panel15.Controls.Add(Me.Label35)
        Me.Panel15.Controls.Add(Me.Label36)
        Me.Panel15.Controls.Add(Me.Label37)
        Me.Panel15.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel15.Location = New System.Drawing.Point(0, 0)
        Me.Panel15.Name = "Panel15"
        Me.Panel15.Size = New System.Drawing.Size(177, 26)
        Me.Panel15.TabIndex = 55
        '
        'Label38
        '
        Me.Label38.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label38.AutoSize = True
        Me.Label38.Font = New System.Drawing.Font("Arial", 14.25!)
        Me.Label38.ForeColor = System.Drawing.Color.White
        Me.Label38.Location = New System.Drawing.Point(18, 3)
        Me.Label38.Margin = New System.Windows.Forms.Padding(429, 0, 429, 0)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(158, 22)
        Me.Label38.TabIndex = 21
        Me.Label38.Text = "Fecha de ingreso"
        Me.Label38.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label31
        '
        Me.Label31.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Arial", 14.25!)
        Me.Label31.ForeColor = System.Drawing.Color.White
        Me.Label31.Location = New System.Drawing.Point(26, -58)
        Me.Label31.Margin = New System.Windows.Forms.Padding(429, 0, 429, 0)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(140, 22)
        Me.Label31.TabIndex = 20
        Me.Label31.Text = "Forma de pago"
        Me.Label31.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label32
        '
        Me.Label32.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Arial", 14.25!)
        Me.Label32.ForeColor = System.Drawing.Color.White
        Me.Label32.Location = New System.Drawing.Point(51, -117)
        Me.Label32.Margin = New System.Windows.Forms.Padding(429, 0, 429, 0)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(70, 22)
        Me.Label32.TabIndex = 19
        Me.Label32.Text = "Puesto"
        Me.Label32.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label33
        '
        Me.Label33.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Arial", 14.25!)
        Me.Label33.ForeColor = System.Drawing.Color.White
        Me.Label33.Location = New System.Drawing.Point(51, -179)
        Me.Label33.Margin = New System.Windows.Forms.Padding(429, 0, 429, 0)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(74, 22)
        Me.Label33.TabIndex = 18
        Me.Label33.Text = "Genero"
        Me.Label33.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label34
        '
        Me.Label34.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label34.AutoSize = True
        Me.Label34.Font = New System.Drawing.Font("Arial", 14.25!)
        Me.Label34.ForeColor = System.Drawing.Color.White
        Me.Label34.Location = New System.Drawing.Point(57, -241)
        Me.Label34.Margin = New System.Windows.Forms.Padding(429, 0, 429, 0)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(79, 22)
        Me.Label34.TabIndex = 17
        Me.Label34.Text = "Apellido"
        Me.Label34.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label35
        '
        Me.Label35.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label35.AutoSize = True
        Me.Label35.Font = New System.Drawing.Font("Arial", 14.25!)
        Me.Label35.ForeColor = System.Drawing.Color.White
        Me.Label35.Location = New System.Drawing.Point(55, -300)
        Me.Label35.Margin = New System.Windows.Forms.Padding(429, 0, 429, 0)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(78, 22)
        Me.Label35.TabIndex = 16
        Me.Label35.Text = "Nombre"
        Me.Label35.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label36
        '
        Me.Label36.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label36.AutoSize = True
        Me.Label36.Font = New System.Drawing.Font("Arial", 14.25!)
        Me.Label36.ForeColor = System.Drawing.Color.White
        Me.Label36.Location = New System.Drawing.Point(55, -361)
        Me.Label36.Margin = New System.Windows.Forms.Padding(429, 0, 429, 0)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(70, 22)
        Me.Label36.TabIndex = 15
        Me.Label36.Text = "Cedula"
        Me.Label36.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label37
        '
        Me.Label37.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label37.AutoSize = True
        Me.Label37.Font = New System.Drawing.Font("Arial", 14.25!)
        Me.Label37.ForeColor = System.Drawing.Color.White
        Me.Label37.Location = New System.Drawing.Point(52, -422)
        Me.Label37.Margin = New System.Windows.Forms.Padding(429, 0, 429, 0)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(70, 22)
        Me.Label37.TabIndex = 14
        Me.Label37.Text = "Cedula"
        Me.Label37.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Panel12
        '
        Me.Panel12.AutoScroll = True
        Me.Panel12.BackColor = System.Drawing.Color.White
        Me.Panel12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel12.Controls.Add(Me.Panel13)
        Me.Panel12.Controls.Add(Me.cmbFormaPago)
        Me.Panel12.Location = New System.Drawing.Point(230, 159)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(172, 64)
        Me.Panel12.TabIndex = 66
        '
        'Panel13
        '
        Me.Panel13.BackColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Panel13.Controls.Add(Me.Label30)
        Me.Panel13.Controls.Add(Me.Label8)
        Me.Panel13.Controls.Add(Me.Label25)
        Me.Panel13.Controls.Add(Me.Label26)
        Me.Panel13.Controls.Add(Me.Label27)
        Me.Panel13.Controls.Add(Me.Label28)
        Me.Panel13.Controls.Add(Me.Label29)
        Me.Panel13.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel13.Location = New System.Drawing.Point(0, 0)
        Me.Panel13.Name = "Panel13"
        Me.Panel13.Size = New System.Drawing.Size(170, 26)
        Me.Panel13.TabIndex = 55
        '
        'Label30
        '
        Me.Label30.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Arial", 14.25!)
        Me.Label30.ForeColor = System.Drawing.Color.White
        Me.Label30.Location = New System.Drawing.Point(26, 3)
        Me.Label30.Margin = New System.Windows.Forms.Padding(429, 0, 429, 0)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(140, 22)
        Me.Label30.TabIndex = 20
        Me.Label30.Text = "Forma de pago"
        Me.Label30.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label8
        '
        Me.Label8.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 14.25!)
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(51, -56)
        Me.Label8.Margin = New System.Windows.Forms.Padding(429, 0, 429, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(70, 22)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Puesto"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label25
        '
        Me.Label25.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Arial", 14.25!)
        Me.Label25.ForeColor = System.Drawing.Color.White
        Me.Label25.Location = New System.Drawing.Point(51, -118)
        Me.Label25.Margin = New System.Windows.Forms.Padding(429, 0, 429, 0)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(74, 22)
        Me.Label25.TabIndex = 18
        Me.Label25.Text = "Genero"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label26
        '
        Me.Label26.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Arial", 14.25!)
        Me.Label26.ForeColor = System.Drawing.Color.White
        Me.Label26.Location = New System.Drawing.Point(57, -180)
        Me.Label26.Margin = New System.Windows.Forms.Padding(429, 0, 429, 0)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(79, 22)
        Me.Label26.TabIndex = 17
        Me.Label26.Text = "Apellido"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label27
        '
        Me.Label27.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Arial", 14.25!)
        Me.Label27.ForeColor = System.Drawing.Color.White
        Me.Label27.Location = New System.Drawing.Point(55, -239)
        Me.Label27.Margin = New System.Windows.Forms.Padding(429, 0, 429, 0)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(78, 22)
        Me.Label27.TabIndex = 16
        Me.Label27.Text = "Nombre"
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label28
        '
        Me.Label28.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Arial", 14.25!)
        Me.Label28.ForeColor = System.Drawing.Color.White
        Me.Label28.Location = New System.Drawing.Point(55, -300)
        Me.Label28.Margin = New System.Windows.Forms.Padding(429, 0, 429, 0)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(70, 22)
        Me.Label28.TabIndex = 15
        Me.Label28.Text = "Cedula"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label29
        '
        Me.Label29.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Arial", 14.25!)
        Me.Label29.ForeColor = System.Drawing.Color.White
        Me.Label29.Location = New System.Drawing.Point(52, -361)
        Me.Label29.Margin = New System.Windows.Forms.Padding(429, 0, 429, 0)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(70, 22)
        Me.Label29.TabIndex = 14
        Me.Label29.Text = "Cedula"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'cmbFormaPago
        '
        Me.cmbFormaPago.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.cmbFormaPago.FormattingEnabled = True
        Me.cmbFormaPago.Items.AddRange(New Object() {"Quincenal", "Semanal"})
        Me.cmbFormaPago.Location = New System.Drawing.Point(3, 33)
        Me.cmbFormaPago.Name = "cmbFormaPago"
        Me.cmbFormaPago.Size = New System.Drawing.Size(165, 26)
        Me.cmbFormaPago.TabIndex = 48
        Me.cmbFormaPago.Text = "Elija una opcion"
        '
        'Panel10
        '
        Me.Panel10.AutoScroll = True
        Me.Panel10.BackColor = System.Drawing.Color.White
        Me.Panel10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel10.Controls.Add(Me.Panel11)
        Me.Panel10.Controls.Add(Me.cmbTipoUsuario)
        Me.Panel10.Location = New System.Drawing.Point(230, 86)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(172, 64)
        Me.Panel10.TabIndex = 65
        '
        'Panel11
        '
        Me.Panel11.BackColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Panel11.Controls.Add(Me.Label24)
        Me.Panel11.Controls.Add(Me.Label4)
        Me.Panel11.Controls.Add(Me.Label20)
        Me.Panel11.Controls.Add(Me.Label21)
        Me.Panel11.Controls.Add(Me.Label22)
        Me.Panel11.Controls.Add(Me.Label23)
        Me.Panel11.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel11.Location = New System.Drawing.Point(0, 0)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(170, 26)
        Me.Panel11.TabIndex = 55
        '
        'Label24
        '
        Me.Label24.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Arial", 14.25!)
        Me.Label24.ForeColor = System.Drawing.Color.White
        Me.Label24.Location = New System.Drawing.Point(51, 4)
        Me.Label24.Margin = New System.Windows.Forms.Padding(429, 0, 429, 0)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(70, 22)
        Me.Label24.TabIndex = 19
        Me.Label24.Text = "Puesto"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label4
        '
        Me.Label4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 14.25!)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(51, -57)
        Me.Label4.Margin = New System.Windows.Forms.Padding(429, 0, 429, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 22)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Genero"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label20
        '
        Me.Label20.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Arial", 14.25!)
        Me.Label20.ForeColor = System.Drawing.Color.White
        Me.Label20.Location = New System.Drawing.Point(57, -120)
        Me.Label20.Margin = New System.Windows.Forms.Padding(429, 0, 429, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(79, 22)
        Me.Label20.TabIndex = 17
        Me.Label20.Text = "Apellido"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label21
        '
        Me.Label21.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Arial", 14.25!)
        Me.Label21.ForeColor = System.Drawing.Color.White
        Me.Label21.Location = New System.Drawing.Point(55, -179)
        Me.Label21.Margin = New System.Windows.Forms.Padding(429, 0, 429, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(78, 22)
        Me.Label21.TabIndex = 16
        Me.Label21.Text = "Nombre"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label22
        '
        Me.Label22.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Arial", 14.25!)
        Me.Label22.ForeColor = System.Drawing.Color.White
        Me.Label22.Location = New System.Drawing.Point(55, -239)
        Me.Label22.Margin = New System.Windows.Forms.Padding(429, 0, 429, 0)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(70, 22)
        Me.Label22.TabIndex = 15
        Me.Label22.Text = "Cedula"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label23
        '
        Me.Label23.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Arial", 14.25!)
        Me.Label23.ForeColor = System.Drawing.Color.White
        Me.Label23.Location = New System.Drawing.Point(52, -301)
        Me.Label23.Margin = New System.Windows.Forms.Padding(429, 0, 429, 0)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(70, 22)
        Me.Label23.TabIndex = 14
        Me.Label23.Text = "Cedula"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'cmbTipoUsuario
        '
        Me.cmbTipoUsuario.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.cmbTipoUsuario.FormattingEnabled = True
        Me.cmbTipoUsuario.Location = New System.Drawing.Point(3, 33)
        Me.cmbTipoUsuario.Name = "cmbTipoUsuario"
        Me.cmbTipoUsuario.Size = New System.Drawing.Size(165, 26)
        Me.cmbTipoUsuario.TabIndex = 48
        Me.cmbTipoUsuario.Text = "Elija una opcion"
        '
        'Panel8
        '
        Me.Panel8.AutoScroll = True
        Me.Panel8.BackColor = System.Drawing.Color.White
        Me.Panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel8.Controls.Add(Me.Panel9)
        Me.Panel8.Controls.Add(Me.cmbSexo)
        Me.Panel8.Location = New System.Drawing.Point(229, 10)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(172, 64)
        Me.Panel8.TabIndex = 64
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Panel9.Controls.Add(Me.Label1)
        Me.Panel9.Controls.Add(Me.Label16)
        Me.Panel9.Controls.Add(Me.Label17)
        Me.Panel9.Controls.Add(Me.Label18)
        Me.Panel9.Controls.Add(Me.Label19)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel9.Location = New System.Drawing.Point(0, 0)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(170, 26)
        Me.Panel9.TabIndex = 55
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
        Me.Label1.Size = New System.Drawing.Size(74, 22)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Genero"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label16
        '
        Me.Label16.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Arial", 14.25!)
        Me.Label16.ForeColor = System.Drawing.Color.White
        Me.Label16.Location = New System.Drawing.Point(57, -59)
        Me.Label16.Margin = New System.Windows.Forms.Padding(429, 0, 429, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(79, 22)
        Me.Label16.TabIndex = 17
        Me.Label16.Text = "Apellido"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label17
        '
        Me.Label17.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Arial", 14.25!)
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(55, -118)
        Me.Label17.Margin = New System.Windows.Forms.Padding(429, 0, 429, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(78, 22)
        Me.Label17.TabIndex = 16
        Me.Label17.Text = "Nombre"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label18
        '
        Me.Label18.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Arial", 14.25!)
        Me.Label18.ForeColor = System.Drawing.Color.White
        Me.Label18.Location = New System.Drawing.Point(55, -179)
        Me.Label18.Margin = New System.Windows.Forms.Padding(429, 0, 429, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(70, 22)
        Me.Label18.TabIndex = 15
        Me.Label18.Text = "Cedula"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label19
        '
        Me.Label19.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Arial", 14.25!)
        Me.Label19.ForeColor = System.Drawing.Color.White
        Me.Label19.Location = New System.Drawing.Point(52, -240)
        Me.Label19.Margin = New System.Windows.Forms.Padding(429, 0, 429, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(70, 22)
        Me.Label19.TabIndex = 14
        Me.Label19.Text = "Cedula"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Panel6
        '
        Me.Panel6.AutoScroll = True
        Me.Panel6.BackColor = System.Drawing.Color.White
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel6.Controls.Add(Me.txtApellido)
        Me.Panel6.Controls.Add(Me.Panel7)
        Me.Panel6.Location = New System.Drawing.Point(18, 159)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(172, 64)
        Me.Panel6.TabIndex = 63
        '
        'txtApellido
        '
        Me.txtApellido.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.txtApellido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtApellido.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtApellido.Location = New System.Drawing.Point(2, 34)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(167, 26)
        Me.txtApellido.TabIndex = 61
        Me.txtApellido.Text = "Ingrese el apellido"
        Me.txtApellido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Panel7.Controls.Add(Me.Label15)
        Me.Panel7.Controls.Add(Me.Label2)
        Me.Panel7.Controls.Add(Me.Label13)
        Me.Panel7.Controls.Add(Me.Label14)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel7.Location = New System.Drawing.Point(0, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(170, 26)
        Me.Panel7.TabIndex = 55
        '
        'Label15
        '
        Me.Label15.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Arial", 14.25!)
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(57, 2)
        Me.Label15.Margin = New System.Windows.Forms.Padding(429, 0, 429, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(79, 22)
        Me.Label15.TabIndex = 17
        Me.Label15.Text = "Apellido"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 14.25!)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(55, -57)
        Me.Label2.Margin = New System.Windows.Forms.Padding(429, 0, 429, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 22)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Nombre"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label13
        '
        Me.Label13.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Arial", 14.25!)
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(55, -118)
        Me.Label13.Margin = New System.Windows.Forms.Padding(429, 0, 429, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(70, 22)
        Me.Label13.TabIndex = 15
        Me.Label13.Text = "Cedula"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label14
        '
        Me.Label14.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Arial", 14.25!)
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(52, -179)
        Me.Label14.Margin = New System.Windows.Forms.Padding(429, 0, 429, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(70, 22)
        Me.Label14.TabIndex = 14
        Me.Label14.Text = "Cedula"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.txtNombre)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Location = New System.Drawing.Point(18, 85)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(172, 64)
        Me.Panel1.TabIndex = 62
        '
        'txtNombre
        '
        Me.txtNombre.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNombre.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtNombre.Location = New System.Drawing.Point(2, 34)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(167, 26)
        Me.txtNombre.TabIndex = 61
        Me.txtNombre.Text = "Ingrese el nombre"
        Me.txtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Panel3.Controls.Add(Me.Label12)
        Me.Panel3.Controls.Add(Me.Label9)
        Me.Panel3.Controls.Add(Me.Label11)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(170, 26)
        Me.Panel3.TabIndex = 55
        '
        'Label12
        '
        Me.Label12.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial", 14.25!)
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(55, 3)
        Me.Label12.Margin = New System.Windows.Forms.Padding(429, 0, 429, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(78, 22)
        Me.Label12.TabIndex = 16
        Me.Label12.Text = "Nombre"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label9
        '
        Me.Label9.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 14.25!)
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(55, -57)
        Me.Label9.Margin = New System.Windows.Forms.Padding(429, 0, 429, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(70, 22)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Cedula"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label11
        '
        Me.Label11.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial", 14.25!)
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(52, -119)
        Me.Label11.Margin = New System.Windows.Forms.Padding(429, 0, 429, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(70, 22)
        Me.Label11.TabIndex = 14
        Me.Label11.Text = "Cedula"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Panel4
        '
        Me.Panel4.AutoScroll = True
        Me.Panel4.BackColor = System.Drawing.Color.White
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.txtCedula)
        Me.Panel4.Controls.Add(Me.Panel5)
        Me.Panel4.Location = New System.Drawing.Point(18, 10)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(172, 64)
        Me.Panel4.TabIndex = 61
        '
        'txtCedula
        '
        Me.txtCedula.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.txtCedula.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCedula.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtCedula.Location = New System.Drawing.Point(2, 34)
        Me.txtCedula.Name = "txtCedula"
        Me.txtCedula.Size = New System.Drawing.Size(167, 26)
        Me.txtCedula.TabIndex = 61
        Me.txtCedula.Text = "Ingrese una cedula"
        Me.txtCedula.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Panel5.Controls.Add(Me.Label5)
        Me.Panel5.Controls.Add(Me.Label3)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(170, 26)
        Me.Panel5.TabIndex = 55
        '
        'Label5
        '
        Me.Label5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 14.25!)
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(55, 3)
        Me.Label5.Margin = New System.Windows.Forms.Padding(429, 0, 429, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 22)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Cedula"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label3
        '
        Me.Label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 14.25!)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(52, -58)
        Me.Label3.Margin = New System.Windows.Forms.Padding(429, 0, 429, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 22)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Cedula"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'tmCalcularHora
        '
        Me.tmCalcularHora.Enabled = True
        Me.tmCalcularHora.Interval = 1
        '
        'btnReporte
        '
        Me.btnReporte.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnReporte.CornerRoundingRadius = 20.0!
        Me.btnReporte.Location = New System.Drawing.Point(713, 502)
        Me.btnReporte.Name = "btnReporte"
        Me.btnReporte.Size = New System.Drawing.Size(137, 35)
        Me.btnReporte.StateCommon.Back.Color1 = System.Drawing.Color.White
        Me.btnReporte.StateCommon.Back.Color2 = System.Drawing.Color.White
        Me.btnReporte.StateCommon.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.btnReporte.StateCommon.Border.Rounding = 20.0!
        Me.btnReporte.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnReporte.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold)
        Me.btnReporte.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnReporte.StateDisabled.Back.Color2 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnReporte.StateNormal.Back.Color1 = System.Drawing.Color.White
        Me.btnReporte.StateNormal.Back.Color2 = System.Drawing.Color.White
        Me.btnReporte.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.btnReporte.StateNormal.Border.Color2 = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.btnReporte.StateNormal.Border.ColorAngle = 46.0!
        Me.btnReporte.StateNormal.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.btnReporte.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.btnReporte.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnReporte.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.btnReporte.StatePressed.Back.ColorAngle = -45.0!
        Me.btnReporte.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnReporte.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.btnReporte.StatePressed.Border.ColorAngle = 45.0!
        Me.btnReporte.StatePressed.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.btnReporte.StatePressed.Border.Width = 1
        Me.btnReporte.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.White
        Me.btnReporte.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.White
        Me.btnReporte.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.btnReporte.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.btnReporte.StateTracking.Back.ColorAngle = 45.0!
        Me.btnReporte.StateTracking.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.btnReporte.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White
        Me.btnReporte.TabIndex = 83
        Me.btnReporte.Values.Text = "Reporte"
        '
        'frmCrearEmpleados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(860, 615)
        Me.Controls.Add(Me.panelContenedor)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmCrearEmpleados"
        Me.Text = "frmCrearEmpleados"
        Me.panelContenedor.ResumeLayout(False)
        Me.Panel18.ResumeLayout(False)
        Me.Panel19.ResumeLayout(False)
        Me.Panel19.PerformLayout()
        CType(Me.dgvListaEmpleados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel16.ResumeLayout(False)
        Me.Panel17.ResumeLayout(False)
        Me.Panel17.PerformLayout()
        Me.Panel14.ResumeLayout(False)
        Me.Panel15.ResumeLayout(False)
        Me.Panel15.PerformLayout()
        Me.Panel12.ResumeLayout(False)
        Me.Panel13.ResumeLayout(False)
        Me.Panel13.PerformLayout()
        Me.Panel10.ResumeLayout(False)
        Me.Panel11.ResumeLayout(False)
        Me.Panel11.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmbSexo As ComboBox
    Friend WithEvents ttMensaje As ToolTip
    Friend WithEvents dtpFechaIngreso As DateTimePicker
    Friend WithEvents tmMostrarMenu As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents tmOcultarMenu As Timer
    Friend WithEvents panelContenedor As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label12 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txtCedula As TextBox
    Friend WithEvents Panel10 As Panel
    Friend WithEvents Panel11 As Panel
    Friend WithEvents Label24 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents cmbTipoUsuario As ComboBox
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents txtApellido As TextBox
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Label15 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Panel16 As Panel
    Friend WithEvents Panel17 As Panel
    Friend WithEvents Label46 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label39 As Label
    Friend WithEvents Label40 As Label
    Friend WithEvents Label41 As Label
    Friend WithEvents Label42 As Label
    Friend WithEvents Label43 As Label
    Friend WithEvents Label44 As Label
    Friend WithEvents Label45 As Label
    Friend WithEvents dtpFechaSalida As DateTimePicker
    Friend WithEvents Panel14 As Panel
    Friend WithEvents Panel15 As Panel
    Friend WithEvents Label38 As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents Label33 As Label
    Friend WithEvents Label34 As Label
    Friend WithEvents Label35 As Label
    Friend WithEvents Label36 As Label
    Friend WithEvents Label37 As Label
    Friend WithEvents Panel12 As Panel
    Friend WithEvents Panel13 As Panel
    Friend WithEvents Label30 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents cmbFormaPago As ComboBox
    Friend WithEvents Panel18 As Panel
    Friend WithEvents Panel19 As Panel
    Friend WithEvents Label10 As Label
    Friend WithEvents txtBuscarEmple As Krypton.Toolkit.KryptonTextBox
    Friend WithEvents btnResetEmpleados As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents dgvListaEmpleados As DataGridView
    Friend WithEvents txtBuscarEmpleado As Krypton.Toolkit.KryptonTextBox
    Friend WithEvents tmCalcularHora As Timer
    Friend WithEvents btnEliminar As Krypton.Toolkit.KryptonButton
    Friend WithEvents btnModificar As Krypton.Toolkit.KryptonButton
    Friend WithEvents btnCrear As Krypton.Toolkit.KryptonButton
    Friend WithEvents btnReporte As Krypton.Toolkit.KryptonButton
End Class
