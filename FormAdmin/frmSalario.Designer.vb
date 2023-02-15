<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSalario
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSalario))
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.panelContenedor = New System.Windows.Forms.Panel()
        Me.tbcContenedor = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.btnReporte = New Krypton.Toolkit.KryptonButton()
        Me.btnEliminar = New Krypton.Toolkit.KryptonButton()
        Me.btnModificar = New Krypton.Toolkit.KryptonButton()
        Me.btnCrear = New Krypton.Toolkit.KryptonButton()
        Me.Panel26 = New System.Windows.Forms.Panel()
        Me.txtHorasNormales = New System.Windows.Forms.TextBox()
        Me.Panel27 = New System.Windows.Forms.Panel()
        Me.lblHorasNormales = New System.Windows.Forms.Label()
        Me.Panel14 = New System.Windows.Forms.Panel()
        Me.Panel15 = New System.Windows.Forms.Panel()
        Me.lblPlanila = New System.Windows.Forms.Label()
        Me.cmbPlanillaSemana = New System.Windows.Forms.ComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.dgvListaSalarios = New System.Windows.Forms.DataGridView()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txtBuscar = New Krypton.Toolkit.KryptonTextBox()
        Me.lblListaSalarios = New System.Windows.Forms.Label()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.Panel13 = New System.Windows.Forms.Panel()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.txtCedula = New System.Windows.Forms.TextBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.lblCedula = New System.Windows.Forms.Label()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.txtHorasDobles = New System.Windows.Forms.TextBox()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.lblHorasDobles = New System.Windows.Forms.Label()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.Panel16 = New System.Windows.Forms.Panel()
        Me.txtHorasMedia = New System.Windows.Forms.TextBox()
        Me.Panel17 = New System.Windows.Forms.Panel()
        Me.lblHorasMedia = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.txtHorasTrabajadas = New System.Windows.Forms.TextBox()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.lblHorasTrabajadas = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Panel36 = New System.Windows.Forms.Panel()
        Me.txtTotalQuin = New System.Windows.Forms.TextBox()
        Me.Panel37 = New System.Windows.Forms.Panel()
        Me.lblTotalQuin = New System.Windows.Forms.Label()
        Me.Panel34 = New System.Windows.Forms.Panel()
        Me.txtHorasNormalesQuin = New System.Windows.Forms.TextBox()
        Me.Panel35 = New System.Windows.Forms.Panel()
        Me.lblHoraNormales = New System.Windows.Forms.Label()
        Me.Panel32 = New System.Windows.Forms.Panel()
        Me.txtHoraDobleQuin = New System.Windows.Forms.TextBox()
        Me.Panel33 = New System.Windows.Forms.Panel()
        Me.lblHoraDobleQuin = New System.Windows.Forms.Label()
        Me.Panel28 = New System.Windows.Forms.Panel()
        Me.txtHoraMediaQuin = New System.Windows.Forms.TextBox()
        Me.Panel29 = New System.Windows.Forms.Panel()
        Me.lblHoraMediaQuin = New System.Windows.Forms.Label()
        Me.Panel24 = New System.Windows.Forms.Panel()
        Me.txtNombreQuin = New System.Windows.Forms.TextBox()
        Me.Panel25 = New System.Windows.Forms.Panel()
        Me.lblNombreQuin = New System.Windows.Forms.Label()
        Me.Panel30 = New System.Windows.Forms.Panel()
        Me.txtHorasTrabajadasQuin = New System.Windows.Forms.TextBox()
        Me.Panel31 = New System.Windows.Forms.Panel()
        Me.lblHorasTraQuin = New System.Windows.Forms.Label()
        Me.Panel22 = New System.Windows.Forms.Panel()
        Me.txtCedulaQuin = New System.Windows.Forms.TextBox()
        Me.Panel23 = New System.Windows.Forms.Panel()
        Me.lblCedulaQuin = New System.Windows.Forms.Label()
        Me.Panel20 = New System.Windows.Forms.Panel()
        Me.Panel21 = New System.Windows.Forms.Panel()
        Me.txtBuscarQuin = New Krypton.Toolkit.KryptonTextBox()
        Me.lblSalariosQuin = New System.Windows.Forms.Label()
        Me.btnResetQuin = New System.Windows.Forms.Button()
        Me.dgvListaQuin = New System.Windows.Forms.DataGridView()
        Me.Panel18 = New System.Windows.Forms.Panel()
        Me.Panel19 = New System.Windows.Forms.Panel()
        Me.lblPlanilla = New System.Windows.Forms.Label()
        Me.cmbPlanilaQuin = New System.Windows.Forms.ComboBox()
        Me.tmMostrarMenu = New System.Windows.Forms.Timer(Me.components)
        Me.tmOcultarMenu = New System.Windows.Forms.Timer(Me.components)
        Me.ttMensaje = New System.Windows.Forms.ToolTip(Me.components)
        Me.epError = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.tmCalcularHora = New System.Windows.Forms.Timer(Me.components)
        Me.panelContenedor.SuspendLayout()
        Me.tbcContenedor.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.Panel26.SuspendLayout()
        Me.Panel27.SuspendLayout()
        Me.Panel14.SuspendLayout()
        Me.Panel15.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvListaSalarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel12.SuspendLayout()
        Me.Panel13.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.Panel10.SuspendLayout()
        Me.Panel11.SuspendLayout()
        Me.Panel16.SuspendLayout()
        Me.Panel17.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.Panel36.SuspendLayout()
        Me.Panel37.SuspendLayout()
        Me.Panel34.SuspendLayout()
        Me.Panel35.SuspendLayout()
        Me.Panel32.SuspendLayout()
        Me.Panel33.SuspendLayout()
        Me.Panel28.SuspendLayout()
        Me.Panel29.SuspendLayout()
        Me.Panel24.SuspendLayout()
        Me.Panel25.SuspendLayout()
        Me.Panel30.SuspendLayout()
        Me.Panel31.SuspendLayout()
        Me.Panel22.SuspendLayout()
        Me.Panel23.SuspendLayout()
        Me.Panel20.SuspendLayout()
        Me.Panel21.SuspendLayout()
        CType(Me.dgvListaQuin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel18.SuspendLayout()
        Me.Panel19.SuspendLayout()
        CType(Me.epError, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panelContenedor
        '
        Me.panelContenedor.AutoScroll = True
        Me.panelContenedor.Controls.Add(Me.tbcContenedor)
        Me.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelContenedor.Location = New System.Drawing.Point(0, 0)
        Me.panelContenedor.Name = "panelContenedor"
        Me.panelContenedor.Size = New System.Drawing.Size(860, 615)
        Me.panelContenedor.TabIndex = 61
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
        Me.tbcContenedor.Size = New System.Drawing.Size(860, 615)
        Me.tbcContenedor.TabIndex = 68
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.White
        Me.TabPage1.Controls.Add(Me.btnReporte)
        Me.TabPage1.Controls.Add(Me.btnEliminar)
        Me.TabPage1.Controls.Add(Me.btnModificar)
        Me.TabPage1.Controls.Add(Me.btnCrear)
        Me.TabPage1.Controls.Add(Me.Panel26)
        Me.TabPage1.Controls.Add(Me.Panel14)
        Me.TabPage1.Controls.Add(Me.Panel1)
        Me.TabPage1.Controls.Add(Me.Panel12)
        Me.TabPage1.Controls.Add(Me.Panel4)
        Me.TabPage1.Controls.Add(Me.Panel8)
        Me.TabPage1.Controls.Add(Me.Panel10)
        Me.TabPage1.Controls.Add(Me.Panel16)
        Me.TabPage1.Controls.Add(Me.Panel6)
        Me.TabPage1.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.TabPage1.Location = New System.Drawing.Point(4, 31)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(852, 580)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Semanal"
        '
        'btnReporte
        '
        Me.btnReporte.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnReporte.CornerRoundingRadius = 20.0!
        Me.btnReporte.Location = New System.Drawing.Point(707, 545)
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
        Me.btnReporte.TabIndex = 82
        Me.btnReporte.Values.Text = "Reporte"
        '
        'btnEliminar
        '
        Me.btnEliminar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnEliminar.CornerRoundingRadius = 20.0!
        Me.btnEliminar.Location = New System.Drawing.Point(287, 545)
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
        Me.btnEliminar.TabIndex = 81
        Me.btnEliminar.Values.Text = "Eliminar"
        '
        'btnModificar
        '
        Me.btnModificar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnModificar.CornerRoundingRadius = 20.0!
        Me.btnModificar.Location = New System.Drawing.Point(145, 545)
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
        Me.btnModificar.TabIndex = 80
        Me.btnModificar.Values.Text = "Modificar"
        '
        'btnCrear
        '
        Me.btnCrear.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnCrear.CornerRoundingRadius = 20.0!
        Me.btnCrear.Location = New System.Drawing.Point(3, 545)
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
        Me.btnCrear.TabIndex = 79
        Me.btnCrear.Values.Text = "Agregar"
        '
        'Panel26
        '
        Me.Panel26.AutoScroll = True
        Me.Panel26.BackColor = System.Drawing.Color.White
        Me.Panel26.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel26.Controls.Add(Me.txtHorasNormales)
        Me.Panel26.Controls.Add(Me.Panel27)
        Me.Panel26.Location = New System.Drawing.Point(460, 10)
        Me.Panel26.Name = "Panel26"
        Me.Panel26.Size = New System.Drawing.Size(172, 64)
        Me.Panel26.TabIndex = 62
        '
        'txtHorasNormales
        '
        Me.txtHorasNormales.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.txtHorasNormales.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtHorasNormales.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtHorasNormales.Location = New System.Drawing.Point(2, 33)
        Me.txtHorasNormales.Name = "txtHorasNormales"
        Me.txtHorasNormales.Size = New System.Drawing.Size(167, 26)
        Me.txtHorasNormales.TabIndex = 60
        Me.txtHorasNormales.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel27
        '
        Me.Panel27.BackColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Panel27.Controls.Add(Me.lblHorasNormales)
        Me.Panel27.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel27.Location = New System.Drawing.Point(0, 0)
        Me.Panel27.Name = "Panel27"
        Me.Panel27.Size = New System.Drawing.Size(170, 26)
        Me.Panel27.TabIndex = 55
        '
        'lblHorasNormales
        '
        Me.lblHorasNormales.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblHorasNormales.AutoSize = True
        Me.lblHorasNormales.Font = New System.Drawing.Font("Arial", 14.25!)
        Me.lblHorasNormales.ForeColor = System.Drawing.Color.White
        Me.lblHorasNormales.Location = New System.Drawing.Point(25, 3)
        Me.lblHorasNormales.Margin = New System.Windows.Forms.Padding(429, 0, 429, 0)
        Me.lblHorasNormales.Name = "lblHorasNormales"
        Me.lblHorasNormales.Size = New System.Drawing.Size(143, 22)
        Me.lblHorasNormales.TabIndex = 15
        Me.lblHorasNormales.Text = "Horas normales"
        Me.lblHorasNormales.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Panel14
        '
        Me.Panel14.AutoScroll = True
        Me.Panel14.BackColor = System.Drawing.Color.White
        Me.Panel14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel14.Controls.Add(Me.Panel15)
        Me.Panel14.Controls.Add(Me.cmbPlanillaSemana)
        Me.Panel14.Location = New System.Drawing.Point(8, 10)
        Me.Panel14.Name = "Panel14"
        Me.Panel14.Size = New System.Drawing.Size(172, 64)
        Me.Panel14.TabIndex = 67
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
        Me.lblPlanila.Location = New System.Drawing.Point(52, 4)
        Me.lblPlanila.Margin = New System.Windows.Forms.Padding(429, 0, 429, 0)
        Me.lblPlanila.Name = "lblPlanila"
        Me.lblPlanila.Size = New System.Drawing.Size(69, 22)
        Me.lblPlanila.TabIndex = 21
        Me.lblPlanila.Text = "Planilla"
        Me.lblPlanila.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'cmbPlanillaSemana
        '
        Me.cmbPlanillaSemana.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.cmbPlanillaSemana.FormattingEnabled = True
        Me.cmbPlanillaSemana.Location = New System.Drawing.Point(3, 33)
        Me.cmbPlanillaSemana.Name = "cmbPlanillaSemana"
        Me.cmbPlanillaSemana.Size = New System.Drawing.Size(165, 26)
        Me.cmbPlanillaSemana.TabIndex = 48
        Me.cmbPlanillaSemana.Text = "Elija una opcion"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.dgvListaSalarios)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Location = New System.Drawing.Point(9, 227)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(835, 313)
        Me.Panel1.TabIndex = 59
        '
        'dgvListaSalarios
        '
        Me.dgvListaSalarios.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvListaSalarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvListaSalarios.BackgroundColor = System.Drawing.Color.White
        Me.dgvListaSalarios.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Arial", 12.0!)
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.NullValue = "Vacio"
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvListaSalarios.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvListaSalarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Arial", 12.0!)
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvListaSalarios.DefaultCellStyle = DataGridViewCellStyle6
        Me.dgvListaSalarios.Location = New System.Drawing.Point(0, 33)
        Me.dgvListaSalarios.Name = "dgvListaSalarios"
        Me.dgvListaSalarios.RowTemplate.Height = 25
        Me.dgvListaSalarios.Size = New System.Drawing.Size(831, 276)
        Me.dgvListaSalarios.TabIndex = 10
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Panel3.Controls.Add(Me.txtBuscar)
        Me.Panel3.Controls.Add(Me.lblListaSalarios)
        Me.Panel3.Controls.Add(Me.btnReset)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(833, 31)
        Me.Panel3.TabIndex = 9
        '
        'txtBuscar
        '
        Me.txtBuscar.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.txtBuscar.Location = New System.Drawing.Point(696, 1)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(99, 28)
        Me.txtBuscar.StateCommon.Back.Color1 = System.Drawing.Color.White
        Me.txtBuscar.StateCommon.Border.Color1 = System.Drawing.Color.White
        Me.txtBuscar.StateCommon.Border.Color2 = System.Drawing.Color.White
        Me.txtBuscar.StateCommon.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.txtBuscar.StateCommon.Border.Rounding = 10.0!
        Me.txtBuscar.StateCommon.Content.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.txtBuscar.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.txtBuscar.StateNormal.Border.Color1 = System.Drawing.Color.White
        Me.txtBuscar.StateNormal.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.txtBuscar.TabIndex = 14
        Me.txtBuscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblListaSalarios
        '
        Me.lblListaSalarios.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblListaSalarios.AutoSize = True
        Me.lblListaSalarios.Font = New System.Drawing.Font("Arial", 14.25!)
        Me.lblListaSalarios.ForeColor = System.Drawing.Color.White
        Me.lblListaSalarios.Location = New System.Drawing.Point(2, 4)
        Me.lblListaSalarios.Margin = New System.Windows.Forms.Padding(429, 0, 429, 0)
        Me.lblListaSalarios.Name = "lblListaSalarios"
        Me.lblListaSalarios.Size = New System.Drawing.Size(224, 22)
        Me.lblListaSalarios.TabIndex = 13
        Me.lblListaSalarios.Text = "Lista de salarios semales"
        Me.lblListaSalarios.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnReset
        '
        Me.btnReset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnReset.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReset.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnReset.FlatAppearance.BorderSize = 0
        Me.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReset.Image = CType(resources.GetObject("btnReset.Image"), System.Drawing.Image)
        Me.btnReset.Location = New System.Drawing.Point(799, 0)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(34, 31)
        Me.btnReset.TabIndex = 10
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'Panel12
        '
        Me.Panel12.AutoScroll = True
        Me.Panel12.BackColor = System.Drawing.Color.White
        Me.Panel12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel12.Controls.Add(Me.txtTotal)
        Me.Panel12.Controls.Add(Me.Panel13)
        Me.Panel12.Location = New System.Drawing.Point(461, 81)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(172, 64)
        Me.Panel12.TabIndex = 64
        '
        'txtTotal
        '
        Me.txtTotal.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTotal.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtTotal.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtTotal.Location = New System.Drawing.Point(2, 33)
        Me.txtTotal.MaxLength = 6
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(167, 26)
        Me.txtTotal.TabIndex = 60
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel13
        '
        Me.Panel13.BackColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Panel13.Controls.Add(Me.lblTotal)
        Me.Panel13.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel13.Location = New System.Drawing.Point(0, 0)
        Me.Panel13.Name = "Panel13"
        Me.Panel13.Size = New System.Drawing.Size(170, 26)
        Me.Panel13.TabIndex = 55
        '
        'lblTotal
        '
        Me.lblTotal.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Arial", 14.25!)
        Me.lblTotal.ForeColor = System.Drawing.Color.White
        Me.lblTotal.Location = New System.Drawing.Point(62, 3)
        Me.lblTotal.Margin = New System.Windows.Forms.Padding(429, 0, 429, 0)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(50, 22)
        Me.lblTotal.TabIndex = 19
        Me.lblTotal.Text = "Total"
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Panel4
        '
        Me.Panel4.AutoScroll = True
        Me.Panel4.BackColor = System.Drawing.Color.White
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.txtCedula)
        Me.Panel4.Controls.Add(Me.Panel5)
        Me.Panel4.Location = New System.Drawing.Point(9, 81)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(172, 64)
        Me.Panel4.TabIndex = 60
        '
        'txtCedula
        '
        Me.txtCedula.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.txtCedula.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCedula.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Italic)
        Me.txtCedula.Location = New System.Drawing.Point(2, 32)
        Me.txtCedula.Name = "txtCedula"
        Me.txtCedula.Size = New System.Drawing.Size(167, 26)
        Me.txtCedula.TabIndex = 60
        Me.txtCedula.Text = "Seleccione  la cedula"
        Me.txtCedula.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Panel5.Controls.Add(Me.lblCedula)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(170, 26)
        Me.Panel5.TabIndex = 55
        '
        'lblCedula
        '
        Me.lblCedula.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCedula.AutoSize = True
        Me.lblCedula.Font = New System.Drawing.Font("Arial", 14.25!)
        Me.lblCedula.ForeColor = System.Drawing.Color.White
        Me.lblCedula.Location = New System.Drawing.Point(52, 3)
        Me.lblCedula.Margin = New System.Windows.Forms.Padding(429, 0, 429, 0)
        Me.lblCedula.Name = "lblCedula"
        Me.lblCedula.Size = New System.Drawing.Size(70, 22)
        Me.lblCedula.TabIndex = 14
        Me.lblCedula.Text = "Cedula"
        Me.lblCedula.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Panel8
        '
        Me.Panel8.AutoScroll = True
        Me.Panel8.BackColor = System.Drawing.Color.White
        Me.Panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel8.Controls.Add(Me.txtHorasDobles)
        Me.Panel8.Controls.Add(Me.Panel9)
        Me.Panel8.Location = New System.Drawing.Point(239, 81)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(172, 64)
        Me.Panel8.TabIndex = 63
        '
        'txtHorasDobles
        '
        Me.txtHorasDobles.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.txtHorasDobles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtHorasDobles.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtHorasDobles.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtHorasDobles.Location = New System.Drawing.Point(2, 33)
        Me.txtHorasDobles.MaxLength = 6
        Me.txtHorasDobles.Name = "txtHorasDobles"
        Me.txtHorasDobles.Size = New System.Drawing.Size(167, 26)
        Me.txtHorasDobles.TabIndex = 60
        Me.txtHorasDobles.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Panel9.Controls.Add(Me.lblHorasDobles)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel9.Location = New System.Drawing.Point(0, 0)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(170, 26)
        Me.Panel9.TabIndex = 55
        '
        'lblHorasDobles
        '
        Me.lblHorasDobles.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblHorasDobles.AutoSize = True
        Me.lblHorasDobles.Font = New System.Drawing.Font("Arial", 14.25!)
        Me.lblHorasDobles.ForeColor = System.Drawing.Color.White
        Me.lblHorasDobles.Location = New System.Drawing.Point(27, 3)
        Me.lblHorasDobles.Margin = New System.Windows.Forms.Padding(429, 0, 429, 0)
        Me.lblHorasDobles.Name = "lblHorasDobles"
        Me.lblHorasDobles.Size = New System.Drawing.Size(123, 22)
        Me.lblHorasDobles.TabIndex = 18
        Me.lblHorasDobles.Text = "Horas dobles"
        Me.lblHorasDobles.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Panel10
        '
        Me.Panel10.AutoScroll = True
        Me.Panel10.BackColor = System.Drawing.Color.White
        Me.Panel10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel10.Controls.Add(Me.txtNombre)
        Me.Panel10.Controls.Add(Me.Panel11)
        Me.Panel10.Location = New System.Drawing.Point(9, 153)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(172, 64)
        Me.Panel10.TabIndex = 62
        '
        'txtNombre
        '
        Me.txtNombre.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNombre.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtNombre.Location = New System.Drawing.Point(2, 32)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(167, 26)
        Me.txtNombre.TabIndex = 60
        Me.txtNombre.Text = "Seleccione el nombre"
        Me.txtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel11
        '
        Me.Panel11.BackColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Panel11.Controls.Add(Me.lblNombre)
        Me.Panel11.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel11.Location = New System.Drawing.Point(0, 0)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(170, 26)
        Me.Panel11.TabIndex = 55
        '
        'lblNombre
        '
        Me.lblNombre.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Arial", 14.25!)
        Me.lblNombre.ForeColor = System.Drawing.Color.White
        Me.lblNombre.Location = New System.Drawing.Point(51, 3)
        Me.lblNombre.Margin = New System.Windows.Forms.Padding(429, 0, 429, 0)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(78, 22)
        Me.lblNombre.TabIndex = 16
        Me.lblNombre.Text = "Nombre"
        Me.lblNombre.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Panel16
        '
        Me.Panel16.AutoScroll = True
        Me.Panel16.BackColor = System.Drawing.Color.White
        Me.Panel16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel16.Controls.Add(Me.txtHorasMedia)
        Me.Panel16.Controls.Add(Me.Panel17)
        Me.Panel16.Location = New System.Drawing.Point(239, 153)
        Me.Panel16.Name = "Panel16"
        Me.Panel16.Size = New System.Drawing.Size(172, 64)
        Me.Panel16.TabIndex = 62
        '
        'txtHorasMedia
        '
        Me.txtHorasMedia.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.txtHorasMedia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtHorasMedia.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtHorasMedia.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtHorasMedia.Location = New System.Drawing.Point(2, 33)
        Me.txtHorasMedia.MaxLength = 6
        Me.txtHorasMedia.Name = "txtHorasMedia"
        Me.txtHorasMedia.Size = New System.Drawing.Size(167, 26)
        Me.txtHorasMedia.TabIndex = 60
        Me.txtHorasMedia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel17
        '
        Me.Panel17.BackColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Panel17.Controls.Add(Me.lblHorasMedia)
        Me.Panel17.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel17.Location = New System.Drawing.Point(0, 0)
        Me.Panel17.Name = "Panel17"
        Me.Panel17.Size = New System.Drawing.Size(170, 26)
        Me.Panel17.TabIndex = 55
        '
        'lblHorasMedia
        '
        Me.lblHorasMedia.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblHorasMedia.AutoSize = True
        Me.lblHorasMedia.Font = New System.Drawing.Font("Arial", 14.25!)
        Me.lblHorasMedia.ForeColor = System.Drawing.Color.White
        Me.lblHorasMedia.Location = New System.Drawing.Point(44, 3)
        Me.lblHorasMedia.Margin = New System.Windows.Forms.Padding(429, 0, 429, 0)
        Me.lblHorasMedia.Name = "lblHorasMedia"
        Me.lblHorasMedia.Size = New System.Drawing.Size(92, 22)
        Me.lblHorasMedia.TabIndex = 17
        Me.lblHorasMedia.Text = "Horas 1/2"
        Me.lblHorasMedia.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Panel6
        '
        Me.Panel6.AutoScroll = True
        Me.Panel6.BackColor = System.Drawing.Color.White
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel6.Controls.Add(Me.txtHorasTrabajadas)
        Me.Panel6.Controls.Add(Me.Panel7)
        Me.Panel6.Location = New System.Drawing.Point(238, 10)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(172, 64)
        Me.Panel6.TabIndex = 61
        '
        'txtHorasTrabajadas
        '
        Me.txtHorasTrabajadas.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.txtHorasTrabajadas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtHorasTrabajadas.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtHorasTrabajadas.Location = New System.Drawing.Point(2, 32)
        Me.txtHorasTrabajadas.Name = "txtHorasTrabajadas"
        Me.txtHorasTrabajadas.Size = New System.Drawing.Size(167, 26)
        Me.txtHorasTrabajadas.TabIndex = 60
        Me.txtHorasTrabajadas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Panel7.Controls.Add(Me.lblHorasTrabajadas)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel7.Location = New System.Drawing.Point(0, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(170, 26)
        Me.Panel7.TabIndex = 55
        '
        'lblHorasTrabajadas
        '
        Me.lblHorasTrabajadas.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblHorasTrabajadas.AutoSize = True
        Me.lblHorasTrabajadas.Font = New System.Drawing.Font("Arial", 14.25!)
        Me.lblHorasTrabajadas.ForeColor = System.Drawing.Color.White
        Me.lblHorasTrabajadas.Location = New System.Drawing.Point(26, 4)
        Me.lblHorasTrabajadas.Margin = New System.Windows.Forms.Padding(429, 0, 429, 0)
        Me.lblHorasTrabajadas.Name = "lblHorasTrabajadas"
        Me.lblHorasTrabajadas.Size = New System.Drawing.Size(137, 22)
        Me.lblHorasTrabajadas.TabIndex = 15
        Me.lblHorasTrabajadas.Text = "Horas Trabajas"
        Me.lblHorasTrabajadas.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.White
        Me.TabPage2.Controls.Add(Me.Panel36)
        Me.TabPage2.Controls.Add(Me.Panel34)
        Me.TabPage2.Controls.Add(Me.Panel32)
        Me.TabPage2.Controls.Add(Me.Panel28)
        Me.TabPage2.Controls.Add(Me.Panel24)
        Me.TabPage2.Controls.Add(Me.Panel30)
        Me.TabPage2.Controls.Add(Me.Panel22)
        Me.TabPage2.Controls.Add(Me.Panel20)
        Me.TabPage2.Controls.Add(Me.Panel18)
        Me.TabPage2.Location = New System.Drawing.Point(4, 31)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(852, 580)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Quincenal"
        '
        'Panel36
        '
        Me.Panel36.AutoScroll = True
        Me.Panel36.BackColor = System.Drawing.Color.White
        Me.Panel36.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel36.Controls.Add(Me.txtTotalQuin)
        Me.Panel36.Controls.Add(Me.Panel37)
        Me.Panel36.Location = New System.Drawing.Point(457, 83)
        Me.Panel36.Name = "Panel36"
        Me.Panel36.Size = New System.Drawing.Size(172, 64)
        Me.Panel36.TabIndex = 76
        '
        'txtTotalQuin
        '
        Me.txtTotalQuin.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.txtTotalQuin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTotalQuin.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtTotalQuin.Location = New System.Drawing.Point(2, 32)
        Me.txtTotalQuin.Name = "txtTotalQuin"
        Me.txtTotalQuin.Size = New System.Drawing.Size(167, 26)
        Me.txtTotalQuin.TabIndex = 60
        Me.txtTotalQuin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel37
        '
        Me.Panel37.BackColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Panel37.Controls.Add(Me.lblTotalQuin)
        Me.Panel37.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel37.Location = New System.Drawing.Point(0, 0)
        Me.Panel37.Name = "Panel37"
        Me.Panel37.Size = New System.Drawing.Size(170, 26)
        Me.Panel37.TabIndex = 55
        '
        'lblTotalQuin
        '
        Me.lblTotalQuin.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTotalQuin.AutoSize = True
        Me.lblTotalQuin.Font = New System.Drawing.Font("Arial", 14.25!)
        Me.lblTotalQuin.ForeColor = System.Drawing.Color.White
        Me.lblTotalQuin.Location = New System.Drawing.Point(65, 3)
        Me.lblTotalQuin.Margin = New System.Windows.Forms.Padding(429, 0, 429, 0)
        Me.lblTotalQuin.Name = "lblTotalQuin"
        Me.lblTotalQuin.Size = New System.Drawing.Size(50, 22)
        Me.lblTotalQuin.TabIndex = 16
        Me.lblTotalQuin.Text = "Total"
        Me.lblTotalQuin.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Panel34
        '
        Me.Panel34.AutoScroll = True
        Me.Panel34.BackColor = System.Drawing.Color.White
        Me.Panel34.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel34.Controls.Add(Me.txtHorasNormalesQuin)
        Me.Panel34.Controls.Add(Me.Panel35)
        Me.Panel34.Location = New System.Drawing.Point(457, 13)
        Me.Panel34.Name = "Panel34"
        Me.Panel34.Size = New System.Drawing.Size(172, 64)
        Me.Panel34.TabIndex = 75
        '
        'txtHorasNormalesQuin
        '
        Me.txtHorasNormalesQuin.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.txtHorasNormalesQuin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtHorasNormalesQuin.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtHorasNormalesQuin.Location = New System.Drawing.Point(2, 32)
        Me.txtHorasNormalesQuin.Name = "txtHorasNormalesQuin"
        Me.txtHorasNormalesQuin.Size = New System.Drawing.Size(167, 26)
        Me.txtHorasNormalesQuin.TabIndex = 60
        Me.txtHorasNormalesQuin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel35
        '
        Me.Panel35.BackColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Panel35.Controls.Add(Me.lblHoraNormales)
        Me.Panel35.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel35.Location = New System.Drawing.Point(0, 0)
        Me.Panel35.Name = "Panel35"
        Me.Panel35.Size = New System.Drawing.Size(170, 26)
        Me.Panel35.TabIndex = 55
        '
        'lblHoraNormales
        '
        Me.lblHoraNormales.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblHoraNormales.AutoSize = True
        Me.lblHoraNormales.Font = New System.Drawing.Font("Arial", 14.25!)
        Me.lblHoraNormales.ForeColor = System.Drawing.Color.White
        Me.lblHoraNormales.Location = New System.Drawing.Point(29, 3)
        Me.lblHoraNormales.Margin = New System.Windows.Forms.Padding(429, 0, 429, 0)
        Me.lblHoraNormales.Name = "lblHoraNormales"
        Me.lblHoraNormales.Size = New System.Drawing.Size(133, 22)
        Me.lblHoraNormales.TabIndex = 16
        Me.lblHoraNormales.Text = "Hora normales"
        Me.lblHoraNormales.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Panel32
        '
        Me.Panel32.AutoScroll = True
        Me.Panel32.BackColor = System.Drawing.Color.White
        Me.Panel32.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel32.Controls.Add(Me.txtHoraDobleQuin)
        Me.Panel32.Controls.Add(Me.Panel33)
        Me.Panel32.Location = New System.Drawing.Point(232, 152)
        Me.Panel32.Name = "Panel32"
        Me.Panel32.Size = New System.Drawing.Size(172, 64)
        Me.Panel32.TabIndex = 74
        '
        'txtHoraDobleQuin
        '
        Me.txtHoraDobleQuin.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.txtHoraDobleQuin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtHoraDobleQuin.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtHoraDobleQuin.Location = New System.Drawing.Point(2, 33)
        Me.txtHoraDobleQuin.Name = "txtHoraDobleQuin"
        Me.txtHoraDobleQuin.Size = New System.Drawing.Size(167, 26)
        Me.txtHoraDobleQuin.TabIndex = 60
        Me.txtHoraDobleQuin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel33
        '
        Me.Panel33.BackColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Panel33.Controls.Add(Me.lblHoraDobleQuin)
        Me.Panel33.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel33.Location = New System.Drawing.Point(0, 0)
        Me.Panel33.Name = "Panel33"
        Me.Panel33.Size = New System.Drawing.Size(170, 26)
        Me.Panel33.TabIndex = 55
        '
        'lblHoraDobleQuin
        '
        Me.lblHoraDobleQuin.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblHoraDobleQuin.AutoSize = True
        Me.lblHoraDobleQuin.Font = New System.Drawing.Font("Arial", 14.25!)
        Me.lblHoraDobleQuin.ForeColor = System.Drawing.Color.White
        Me.lblHoraDobleQuin.Location = New System.Drawing.Point(39, 3)
        Me.lblHoraDobleQuin.Margin = New System.Windows.Forms.Padding(429, 0, 429, 0)
        Me.lblHoraDobleQuin.Name = "lblHoraDobleQuin"
        Me.lblHoraDobleQuin.Size = New System.Drawing.Size(103, 22)
        Me.lblHoraDobleQuin.TabIndex = 16
        Me.lblHoraDobleQuin.Text = "Hora doble"
        Me.lblHoraDobleQuin.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Panel28
        '
        Me.Panel28.AutoScroll = True
        Me.Panel28.BackColor = System.Drawing.Color.White
        Me.Panel28.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel28.Controls.Add(Me.txtHoraMediaQuin)
        Me.Panel28.Controls.Add(Me.Panel29)
        Me.Panel28.Location = New System.Drawing.Point(233, 83)
        Me.Panel28.Name = "Panel28"
        Me.Panel28.Size = New System.Drawing.Size(172, 64)
        Me.Panel28.TabIndex = 73
        '
        'txtHoraMediaQuin
        '
        Me.txtHoraMediaQuin.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.txtHoraMediaQuin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtHoraMediaQuin.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtHoraMediaQuin.Location = New System.Drawing.Point(2, 32)
        Me.txtHoraMediaQuin.Name = "txtHoraMediaQuin"
        Me.txtHoraMediaQuin.Size = New System.Drawing.Size(167, 26)
        Me.txtHoraMediaQuin.TabIndex = 60
        Me.txtHoraMediaQuin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel29
        '
        Me.Panel29.BackColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Panel29.Controls.Add(Me.lblHoraMediaQuin)
        Me.Panel29.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel29.Location = New System.Drawing.Point(0, 0)
        Me.Panel29.Name = "Panel29"
        Me.Panel29.Size = New System.Drawing.Size(170, 26)
        Me.Panel29.TabIndex = 55
        '
        'lblHoraMediaQuin
        '
        Me.lblHoraMediaQuin.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblHoraMediaQuin.AutoSize = True
        Me.lblHoraMediaQuin.Font = New System.Drawing.Font("Arial", 14.25!)
        Me.lblHoraMediaQuin.ForeColor = System.Drawing.Color.White
        Me.lblHoraMediaQuin.Location = New System.Drawing.Point(39, 3)
        Me.lblHoraMediaQuin.Margin = New System.Windows.Forms.Padding(429, 0, 429, 0)
        Me.lblHoraMediaQuin.Name = "lblHoraMediaQuin"
        Me.lblHoraMediaQuin.Size = New System.Drawing.Size(107, 22)
        Me.lblHoraMediaQuin.TabIndex = 16
        Me.lblHoraMediaQuin.Text = "Hora media"
        Me.lblHoraMediaQuin.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Panel24
        '
        Me.Panel24.AutoScroll = True
        Me.Panel24.BackColor = System.Drawing.Color.White
        Me.Panel24.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel24.Controls.Add(Me.txtNombreQuin)
        Me.Panel24.Controls.Add(Me.Panel25)
        Me.Panel24.Location = New System.Drawing.Point(9, 153)
        Me.Panel24.Name = "Panel24"
        Me.Panel24.Size = New System.Drawing.Size(172, 64)
        Me.Panel24.TabIndex = 71
        '
        'txtNombreQuin
        '
        Me.txtNombreQuin.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.txtNombreQuin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNombreQuin.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtNombreQuin.Location = New System.Drawing.Point(2, 32)
        Me.txtNombreQuin.Name = "txtNombreQuin"
        Me.txtNombreQuin.Size = New System.Drawing.Size(167, 26)
        Me.txtNombreQuin.TabIndex = 60
        Me.txtNombreQuin.Text = "Seleccione el nombre"
        Me.txtNombreQuin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel25
        '
        Me.Panel25.BackColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Panel25.Controls.Add(Me.lblNombreQuin)
        Me.Panel25.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel25.Location = New System.Drawing.Point(0, 0)
        Me.Panel25.Name = "Panel25"
        Me.Panel25.Size = New System.Drawing.Size(170, 26)
        Me.Panel25.TabIndex = 55
        '
        'lblNombreQuin
        '
        Me.lblNombreQuin.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblNombreQuin.AutoSize = True
        Me.lblNombreQuin.Font = New System.Drawing.Font("Arial", 14.25!)
        Me.lblNombreQuin.ForeColor = System.Drawing.Color.White
        Me.lblNombreQuin.Location = New System.Drawing.Point(49, 3)
        Me.lblNombreQuin.Margin = New System.Windows.Forms.Padding(429, 0, 429, 0)
        Me.lblNombreQuin.Name = "lblNombreQuin"
        Me.lblNombreQuin.Size = New System.Drawing.Size(78, 22)
        Me.lblNombreQuin.TabIndex = 16
        Me.lblNombreQuin.Text = "Nombre"
        Me.lblNombreQuin.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Panel30
        '
        Me.Panel30.AutoScroll = True
        Me.Panel30.BackColor = System.Drawing.Color.White
        Me.Panel30.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel30.Controls.Add(Me.txtHorasTrabajadasQuin)
        Me.Panel30.Controls.Add(Me.Panel31)
        Me.Panel30.Location = New System.Drawing.Point(232, 13)
        Me.Panel30.Name = "Panel30"
        Me.Panel30.Size = New System.Drawing.Size(172, 64)
        Me.Panel30.TabIndex = 72
        '
        'txtHorasTrabajadasQuin
        '
        Me.txtHorasTrabajadasQuin.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.txtHorasTrabajadasQuin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtHorasTrabajadasQuin.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Italic)
        Me.txtHorasTrabajadasQuin.Location = New System.Drawing.Point(2, 32)
        Me.txtHorasTrabajadasQuin.Name = "txtHorasTrabajadasQuin"
        Me.txtHorasTrabajadasQuin.Size = New System.Drawing.Size(167, 26)
        Me.txtHorasTrabajadasQuin.TabIndex = 60
        Me.txtHorasTrabajadasQuin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel31
        '
        Me.Panel31.BackColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Panel31.Controls.Add(Me.lblHorasTraQuin)
        Me.Panel31.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel31.Location = New System.Drawing.Point(0, 0)
        Me.Panel31.Name = "Panel31"
        Me.Panel31.Size = New System.Drawing.Size(170, 26)
        Me.Panel31.TabIndex = 55
        '
        'lblHorasTraQuin
        '
        Me.lblHorasTraQuin.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblHorasTraQuin.AutoSize = True
        Me.lblHorasTraQuin.Font = New System.Drawing.Font("Arial", 14.25!)
        Me.lblHorasTraQuin.ForeColor = System.Drawing.Color.White
        Me.lblHorasTraQuin.Location = New System.Drawing.Point(20, 3)
        Me.lblHorasTraQuin.Margin = New System.Windows.Forms.Padding(429, 0, 429, 0)
        Me.lblHorasTraQuin.Name = "lblHorasTraQuin"
        Me.lblHorasTraQuin.Size = New System.Drawing.Size(152, 22)
        Me.lblHorasTraQuin.TabIndex = 14
        Me.lblHorasTraQuin.Text = "Horas trabajadas"
        Me.lblHorasTraQuin.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Panel22
        '
        Me.Panel22.AutoScroll = True
        Me.Panel22.BackColor = System.Drawing.Color.White
        Me.Panel22.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel22.Controls.Add(Me.txtCedulaQuin)
        Me.Panel22.Controls.Add(Me.Panel23)
        Me.Panel22.Location = New System.Drawing.Point(8, 82)
        Me.Panel22.Name = "Panel22"
        Me.Panel22.Size = New System.Drawing.Size(172, 64)
        Me.Panel22.TabIndex = 70
        '
        'txtCedulaQuin
        '
        Me.txtCedulaQuin.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.txtCedulaQuin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCedulaQuin.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Italic)
        Me.txtCedulaQuin.Location = New System.Drawing.Point(2, 33)
        Me.txtCedulaQuin.Name = "txtCedulaQuin"
        Me.txtCedulaQuin.Size = New System.Drawing.Size(167, 26)
        Me.txtCedulaQuin.TabIndex = 60
        Me.txtCedulaQuin.Text = "Seleccione  la cedula"
        Me.txtCedulaQuin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel23
        '
        Me.Panel23.BackColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Panel23.Controls.Add(Me.lblCedulaQuin)
        Me.Panel23.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel23.Location = New System.Drawing.Point(0, 0)
        Me.Panel23.Name = "Panel23"
        Me.Panel23.Size = New System.Drawing.Size(170, 26)
        Me.Panel23.TabIndex = 55
        '
        'lblCedulaQuin
        '
        Me.lblCedulaQuin.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCedulaQuin.AutoSize = True
        Me.lblCedulaQuin.Font = New System.Drawing.Font("Arial", 14.25!)
        Me.lblCedulaQuin.ForeColor = System.Drawing.Color.White
        Me.lblCedulaQuin.Location = New System.Drawing.Point(54, 3)
        Me.lblCedulaQuin.Margin = New System.Windows.Forms.Padding(429, 0, 429, 0)
        Me.lblCedulaQuin.Name = "lblCedulaQuin"
        Me.lblCedulaQuin.Size = New System.Drawing.Size(70, 22)
        Me.lblCedulaQuin.TabIndex = 14
        Me.lblCedulaQuin.Text = "Cedula"
        Me.lblCedulaQuin.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Panel20
        '
        Me.Panel20.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel20.BackColor = System.Drawing.Color.White
        Me.Panel20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel20.Controls.Add(Me.Panel21)
        Me.Panel20.Controls.Add(Me.dgvListaQuin)
        Me.Panel20.Location = New System.Drawing.Point(9, 223)
        Me.Panel20.Name = "Panel20"
        Me.Panel20.Size = New System.Drawing.Size(621, 351)
        Me.Panel20.TabIndex = 69
        '
        'Panel21
        '
        Me.Panel21.BackColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Panel21.Controls.Add(Me.txtBuscarQuin)
        Me.Panel21.Controls.Add(Me.lblSalariosQuin)
        Me.Panel21.Controls.Add(Me.btnResetQuin)
        Me.Panel21.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel21.Location = New System.Drawing.Point(0, 0)
        Me.Panel21.Name = "Panel21"
        Me.Panel21.Size = New System.Drawing.Size(619, 31)
        Me.Panel21.TabIndex = 9
        '
        'txtBuscarQuin
        '
        Me.txtBuscarQuin.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.txtBuscarQuin.Location = New System.Drawing.Point(479, 3)
        Me.txtBuscarQuin.Name = "txtBuscarQuin"
        Me.txtBuscarQuin.Size = New System.Drawing.Size(99, 28)
        Me.txtBuscarQuin.StateCommon.Back.Color1 = System.Drawing.Color.White
        Me.txtBuscarQuin.StateCommon.Border.Color1 = System.Drawing.Color.White
        Me.txtBuscarQuin.StateCommon.Border.Color2 = System.Drawing.Color.White
        Me.txtBuscarQuin.StateCommon.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.txtBuscarQuin.StateCommon.Border.Rounding = 10.0!
        Me.txtBuscarQuin.StateCommon.Content.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.txtBuscarQuin.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.txtBuscarQuin.StateNormal.Border.Color1 = System.Drawing.Color.White
        Me.txtBuscarQuin.StateNormal.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.txtBuscarQuin.TabIndex = 14
        Me.txtBuscarQuin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblSalariosQuin
        '
        Me.lblSalariosQuin.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblSalariosQuin.AutoSize = True
        Me.lblSalariosQuin.Font = New System.Drawing.Font("Arial", 14.25!)
        Me.lblSalariosQuin.ForeColor = System.Drawing.Color.White
        Me.lblSalariosQuin.Location = New System.Drawing.Point(2, 5)
        Me.lblSalariosQuin.Margin = New System.Windows.Forms.Padding(429, 0, 429, 0)
        Me.lblSalariosQuin.Name = "lblSalariosQuin"
        Me.lblSalariosQuin.Size = New System.Drawing.Size(253, 22)
        Me.lblSalariosQuin.TabIndex = 13
        Me.lblSalariosQuin.Text = "Lista de salarios quincenales"
        Me.lblSalariosQuin.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnResetQuin
        '
        Me.btnResetQuin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnResetQuin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnResetQuin.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnResetQuin.FlatAppearance.BorderSize = 0
        Me.btnResetQuin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnResetQuin.Location = New System.Drawing.Point(585, 0)
        Me.btnResetQuin.Name = "btnResetQuin"
        Me.btnResetQuin.Size = New System.Drawing.Size(34, 31)
        Me.btnResetQuin.TabIndex = 10
        Me.btnResetQuin.UseVisualStyleBackColor = True
        '
        'dgvListaQuin
        '
        Me.dgvListaQuin.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvListaQuin.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvListaQuin.BackgroundColor = System.Drawing.Color.White
        Me.dgvListaQuin.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Arial", 14.25!)
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.NullValue = "Vacio"
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvListaQuin.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.dgvListaQuin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Arial", 14.25!)
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvListaQuin.DefaultCellStyle = DataGridViewCellStyle8
        Me.dgvListaQuin.Location = New System.Drawing.Point(0, 33)
        Me.dgvListaQuin.Name = "dgvListaQuin"
        Me.dgvListaQuin.RowTemplate.Height = 25
        Me.dgvListaQuin.Size = New System.Drawing.Size(619, 314)
        Me.dgvListaQuin.TabIndex = 8
        '
        'Panel18
        '
        Me.Panel18.AutoScroll = True
        Me.Panel18.BackColor = System.Drawing.Color.White
        Me.Panel18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel18.Controls.Add(Me.Panel19)
        Me.Panel18.Controls.Add(Me.cmbPlanilaQuin)
        Me.Panel18.Location = New System.Drawing.Point(8, 12)
        Me.Panel18.Name = "Panel18"
        Me.Panel18.Size = New System.Drawing.Size(172, 64)
        Me.Panel18.TabIndex = 68
        '
        'Panel19
        '
        Me.Panel19.BackColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Panel19.Controls.Add(Me.lblPlanilla)
        Me.Panel19.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel19.Location = New System.Drawing.Point(0, 0)
        Me.Panel19.Name = "Panel19"
        Me.Panel19.Size = New System.Drawing.Size(170, 26)
        Me.Panel19.TabIndex = 55
        '
        'lblPlanilla
        '
        Me.lblPlanilla.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblPlanilla.AutoSize = True
        Me.lblPlanilla.Font = New System.Drawing.Font("Arial", 14.25!)
        Me.lblPlanilla.ForeColor = System.Drawing.Color.White
        Me.lblPlanilla.Location = New System.Drawing.Point(54, 3)
        Me.lblPlanilla.Margin = New System.Windows.Forms.Padding(429, 0, 429, 0)
        Me.lblPlanilla.Name = "lblPlanilla"
        Me.lblPlanilla.Size = New System.Drawing.Size(69, 22)
        Me.lblPlanilla.TabIndex = 21
        Me.lblPlanilla.Text = "Planilla"
        Me.lblPlanilla.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'cmbPlanilaQuin
        '
        Me.cmbPlanilaQuin.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.cmbPlanilaQuin.FormattingEnabled = True
        Me.cmbPlanilaQuin.Location = New System.Drawing.Point(3, 33)
        Me.cmbPlanilaQuin.Name = "cmbPlanilaQuin"
        Me.cmbPlanilaQuin.Size = New System.Drawing.Size(165, 26)
        Me.cmbPlanilaQuin.TabIndex = 48
        Me.cmbPlanilaQuin.Text = "Elija una opcion"
        '
        'epError
        '
        Me.epError.ContainerControl = Me
        '
        'tmCalcularHora
        '
        Me.tmCalcularHora.Enabled = True
        Me.tmCalcularHora.Interval = 1
        '
        'frmSalario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(860, 615)
        Me.Controls.Add(Me.panelContenedor)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmSalario"
        Me.Text = "frmSalarios"
        Me.panelContenedor.ResumeLayout(False)
        Me.tbcContenedor.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.Panel26.ResumeLayout(False)
        Me.Panel26.PerformLayout()
        Me.Panel27.ResumeLayout(False)
        Me.Panel27.PerformLayout()
        Me.Panel14.ResumeLayout(False)
        Me.Panel15.ResumeLayout(False)
        Me.Panel15.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.dgvListaSalarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel12.ResumeLayout(False)
        Me.Panel12.PerformLayout()
        Me.Panel13.ResumeLayout(False)
        Me.Panel13.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        Me.Panel10.ResumeLayout(False)
        Me.Panel10.PerformLayout()
        Me.Panel11.ResumeLayout(False)
        Me.Panel11.PerformLayout()
        Me.Panel16.ResumeLayout(False)
        Me.Panel16.PerformLayout()
        Me.Panel17.ResumeLayout(False)
        Me.Panel17.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.Panel36.ResumeLayout(False)
        Me.Panel36.PerformLayout()
        Me.Panel37.ResumeLayout(False)
        Me.Panel37.PerformLayout()
        Me.Panel34.ResumeLayout(False)
        Me.Panel34.PerformLayout()
        Me.Panel35.ResumeLayout(False)
        Me.Panel35.PerformLayout()
        Me.Panel32.ResumeLayout(False)
        Me.Panel32.PerformLayout()
        Me.Panel33.ResumeLayout(False)
        Me.Panel33.PerformLayout()
        Me.Panel28.ResumeLayout(False)
        Me.Panel28.PerformLayout()
        Me.Panel29.ResumeLayout(False)
        Me.Panel29.PerformLayout()
        Me.Panel24.ResumeLayout(False)
        Me.Panel24.PerformLayout()
        Me.Panel25.ResumeLayout(False)
        Me.Panel25.PerformLayout()
        Me.Panel30.ResumeLayout(False)
        Me.Panel30.PerformLayout()
        Me.Panel31.ResumeLayout(False)
        Me.Panel31.PerformLayout()
        Me.Panel22.ResumeLayout(False)
        Me.Panel22.PerformLayout()
        Me.Panel23.ResumeLayout(False)
        Me.Panel23.PerformLayout()
        Me.Panel20.ResumeLayout(False)
        Me.Panel21.ResumeLayout(False)
        Me.Panel21.PerformLayout()
        CType(Me.dgvListaQuin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel18.ResumeLayout(False)
        Me.Panel19.ResumeLayout(False)
        Me.Panel19.PerformLayout()
        CType(Me.epError, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents panelContenedor As Panel
    Friend WithEvents tmMostrarMenu As Timer
    Friend WithEvents tmOcultarMenu As Timer
    Friend WithEvents ttMensaje As ToolTip
    Friend WithEvents epError As ErrorProvider
    Friend WithEvents tbcContenedor As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents Panel14 As Panel
    Friend WithEvents Panel15 As Panel
    Friend WithEvents lblPlanila As Label
    Friend WithEvents cmbPlanillaSemana As ComboBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents txtBuscar As Krypton.Toolkit.KryptonTextBox
    Friend WithEvents lblListaSalarios As Label
    Friend WithEvents btnReset As Button
    Friend WithEvents Panel12 As Panel
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents Panel13 As Panel
    Friend WithEvents lblTotal As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents txtCedula As TextBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents lblCedula As Label
    Friend WithEvents Panel8 As Panel
    Friend WithEvents txtHorasDobles As TextBox
    Friend WithEvents Panel9 As Panel
    Friend WithEvents lblHorasDobles As Label
    Friend WithEvents Panel10 As Panel
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Panel11 As Panel
    Friend WithEvents lblNombre As Label
    Friend WithEvents Panel16 As Panel
    Friend WithEvents txtHorasMedia As TextBox
    Friend WithEvents Panel17 As Panel
    Friend WithEvents lblHorasMedia As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents txtHorasTrabajadas As TextBox
    Friend WithEvents Panel7 As Panel
    Friend WithEvents lblHorasTrabajadas As Label
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Panel24 As Panel
    Friend WithEvents txtNombreQuin As TextBox
    Friend WithEvents Panel25 As Panel
    Friend WithEvents lblNombreQuin As Label
    Friend WithEvents Panel22 As Panel
    Friend WithEvents txtCedulaQuin As TextBox
    Friend WithEvents Panel23 As Panel
    Friend WithEvents lblCedulaQuin As Label
    Friend WithEvents Panel20 As Panel
    Friend WithEvents Panel21 As Panel
    Friend WithEvents txtBuscarQuin As Krypton.Toolkit.KryptonTextBox
    Friend WithEvents lblSalariosQuin As Label
    Friend WithEvents btnResetQuin As Button
    Friend WithEvents dgvListaQuin As DataGridView
    Friend WithEvents Panel18 As Panel
    Friend WithEvents Panel19 As Panel
    Friend WithEvents lblPlanilla As Label
    Friend WithEvents cmbPlanilaQuin As ComboBox
    Friend WithEvents Panel26 As Panel
    Friend WithEvents txtHorasNormales As TextBox
    Friend WithEvents Panel27 As Panel
    Friend WithEvents lblHorasNormales As Label
    Friend WithEvents tmCalcularHora As Timer
    Friend WithEvents Panel34 As Panel
    Friend WithEvents txtHorasNormalesQuin As TextBox
    Friend WithEvents Panel35 As Panel
    Friend WithEvents lblHoraNormales As Label
    Friend WithEvents Panel32 As Panel
    Friend WithEvents txtHoraDobleQuin As TextBox
    Friend WithEvents Panel33 As Panel
    Friend WithEvents lblHoraDobleQuin As Label
    Friend WithEvents Panel28 As Panel
    Friend WithEvents txtHoraMediaQuin As TextBox
    Friend WithEvents Panel29 As Panel
    Friend WithEvents lblHoraMediaQuin As Label
    Friend WithEvents Panel30 As Panel
    Friend WithEvents txtHorasTrabajadasQuin As TextBox
    Friend WithEvents Panel31 As Panel
    Friend WithEvents lblHorasTraQuin As Label
    Friend WithEvents Panel36 As Panel
    Friend WithEvents txtTotalQuin As TextBox
    Friend WithEvents Panel37 As Panel
    Friend WithEvents lblTotalQuin As Label
    Friend WithEvents btnEliminar As Krypton.Toolkit.KryptonButton
    Friend WithEvents btnModificar As Krypton.Toolkit.KryptonButton
    Friend WithEvents btnCrear As Krypton.Toolkit.KryptonButton
    Friend WithEvents dgvListaSalarios As DataGridView
    Friend WithEvents btnReporte As Krypton.Toolkit.KryptonButton
End Class

