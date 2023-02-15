<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCrearPuesto
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCrearPuesto))
        Me.Panel14 = New System.Windows.Forms.Panel()
        Me.txtNombre = New Krypton.Toolkit.KryptonTextBox()
        Me.Panel15 = New System.Windows.Forms.Panel()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtSalarioMes = New Krypton.Toolkit.KryptonTextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblSalarioMes = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.dgvListaPuestos = New Krypton.Toolkit.KryptonDataGridView()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.txtBuscarEmple = New Krypton.Toolkit.KryptonTextBox()
        Me.btnResetEmpleados = New System.Windows.Forms.Button()
        Me.lblListaEmpl = New System.Windows.Forms.Label()
        Me.btnEliminar = New Krypton.Toolkit.KryptonButton()
        Me.btnModificar = New Krypton.Toolkit.KryptonButton()
        Me.btnCrear = New Krypton.Toolkit.KryptonButton()
        Me.Panel14.SuspendLayout()
        Me.Panel15.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.dgvListaPuestos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel14
        '
        Me.Panel14.AutoScroll = True
        Me.Panel14.BackColor = System.Drawing.Color.White
        Me.Panel14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel14.Controls.Add(Me.txtNombre)
        Me.Panel14.Controls.Add(Me.Panel15)
        Me.Panel14.Location = New System.Drawing.Point(10, 10)
        Me.Panel14.Name = "Panel14"
        Me.Panel14.Size = New System.Drawing.Size(172, 64)
        Me.Panel14.TabIndex = 69
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(3, 30)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(165, 30)
        Me.txtNombre.StateCommon.Border.Color1 = System.Drawing.Color.Black
        Me.txtNombre.StateCommon.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.txtNombre.StateCommon.Border.Rounding = 7.0!
        Me.txtNombre.StateCommon.Content.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtNombre.TabIndex = 70
        Me.txtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtNombre.ToolTipValues.Description = "Ingrese el nombre del puesto"
        Me.txtNombre.ToolTipValues.EnableToolTips = True
        Me.txtNombre.ToolTipValues.Heading = "Nombre puesto"
        '
        'Panel15
        '
        Me.Panel15.BackColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Panel15.Controls.Add(Me.lblNombre)
        Me.Panel15.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel15.Location = New System.Drawing.Point(0, 0)
        Me.Panel15.Name = "Panel15"
        Me.Panel15.Size = New System.Drawing.Size(170, 26)
        Me.Panel15.TabIndex = 55
        '
        'lblNombre
        '
        Me.lblNombre.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Arial", 14.25!)
        Me.lblNombre.ForeColor = System.Drawing.Color.White
        Me.lblNombre.Location = New System.Drawing.Point(52, 3)
        Me.lblNombre.Margin = New System.Windows.Forms.Padding(429, 0, 429, 0)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(78, 22)
        Me.lblNombre.TabIndex = 21
        Me.lblNombre.Text = "Nombre"
        Me.lblNombre.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.txtSalarioMes)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Location = New System.Drawing.Point(204, 10)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(172, 64)
        Me.Panel1.TabIndex = 71
        '
        'txtSalarioMes
        '
        Me.txtSalarioMes.Location = New System.Drawing.Point(3, 29)
        Me.txtSalarioMes.Name = "txtSalarioMes"
        Me.txtSalarioMes.Size = New System.Drawing.Size(165, 30)
        Me.txtSalarioMes.StateCommon.Border.Color1 = System.Drawing.Color.Black
        Me.txtSalarioMes.StateCommon.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.txtSalarioMes.StateCommon.Border.Rounding = 7.0!
        Me.txtSalarioMes.StateCommon.Content.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtSalarioMes.TabIndex = 70
        Me.txtSalarioMes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtSalarioMes.ToolTipValues.Description = "Ingrese el salario mensual, ej: 349000"
        Me.txtSalarioMes.ToolTipValues.EnableToolTips = True
        Me.txtSalarioMes.ToolTipValues.Heading = "Salario mensual"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Panel2.Controls.Add(Me.lblSalarioMes)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(170, 26)
        Me.Panel2.TabIndex = 55
        '
        'lblSalarioMes
        '
        Me.lblSalarioMes.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblSalarioMes.AutoSize = True
        Me.lblSalarioMes.Font = New System.Drawing.Font("Arial", 14.25!)
        Me.lblSalarioMes.ForeColor = System.Drawing.Color.White
        Me.lblSalarioMes.Location = New System.Drawing.Point(25, 3)
        Me.lblSalarioMes.Margin = New System.Windows.Forms.Padding(429, 0, 429, 0)
        Me.lblSalarioMes.Name = "lblSalarioMes"
        Me.lblSalarioMes.Size = New System.Drawing.Size(144, 22)
        Me.lblSalarioMes.TabIndex = 21
        Me.lblSalarioMes.Text = "Salario mensual"
        Me.lblSalarioMes.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.dgvListaPuestos)
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Location = New System.Drawing.Point(10, 87)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(667, 192)
        Me.Panel3.TabIndex = 72
        '
        'dgvListaPuestos
        '
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.dgvListaPuestos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvListaPuestos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvListaPuestos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvListaPuestos.Location = New System.Drawing.Point(-2, 37)
        Me.dgvListaPuestos.Name = "dgvListaPuestos"
        Me.dgvListaPuestos.PaletteMode = Krypton.Toolkit.PaletteMode.SparkleBlueLightMode
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.dgvListaPuestos.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvListaPuestos.RowTemplate.Height = 25
        Me.dgvListaPuestos.Size = New System.Drawing.Size(667, 154)
        Me.dgvListaPuestos.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.dgvListaPuestos.StateCommon.DataCell.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.dgvListaPuestos.StateCommon.DataCell.Content.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.dgvListaPuestos.StateCommon.HeaderColumn.Content.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.dgvListaPuestos.StateCommon.HeaderColumn.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.dgvListaPuestos.StateCommon.HeaderColumn.Content.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.dgvListaPuestos.TabIndex = 10
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Panel4.Controls.Add(Me.txtBuscarEmple)
        Me.Panel4.Controls.Add(Me.btnResetEmpleados)
        Me.Panel4.Controls.Add(Me.lblListaEmpl)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(665, 40)
        Me.Panel4.TabIndex = 9
        '
        'txtBuscarEmple
        '
        Me.txtBuscarEmple.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.txtBuscarEmple.Location = New System.Drawing.Point(527, 4)
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
        Me.btnResetEmpleados.Size = New System.Drawing.Size(34, 40)
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
        Me.lblListaEmpl.Location = New System.Drawing.Point(-1, 7)
        Me.lblListaEmpl.Margin = New System.Windows.Forms.Padding(429, 0, 429, 0)
        Me.lblListaEmpl.Name = "lblListaEmpl"
        Me.lblListaEmpl.Size = New System.Drawing.Size(177, 22)
        Me.lblListaEmpl.TabIndex = 9
        Me.lblListaEmpl.Text = "Lista de empleados"
        Me.lblListaEmpl.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnEliminar
        '
        Me.btnEliminar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnEliminar.CornerRoundingRadius = 20.0!
        Me.btnEliminar.Location = New System.Drawing.Point(295, 285)
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
        Me.btnModificar.Location = New System.Drawing.Point(153, 285)
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
        Me.btnCrear.Location = New System.Drawing.Point(10, 285)
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
        'frmCrearPuesto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(686, 390)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnCrear)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel14)
        Me.ForeColor = System.Drawing.Color.White
        Me.Name = "frmCrearPuesto"
        Me.Text = "frmCrearPuesto"
        Me.Panel14.ResumeLayout(False)
        Me.Panel14.PerformLayout()
        Me.Panel15.ResumeLayout(False)
        Me.Panel15.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        CType(Me.dgvListaPuestos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel14 As Panel
    Friend WithEvents Panel15 As Panel
    Friend WithEvents lblNombre As Label
    Friend WithEvents txtNombre As Krypton.Toolkit.KryptonTextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtSalarioMes As Krypton.Toolkit.KryptonTextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblSalarioMes As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents txtBuscarEmple As Krypton.Toolkit.KryptonTextBox
    Friend WithEvents btnResetEmpleados As Button
    Friend WithEvents lblListaEmpl As Label
    Friend WithEvents btnEliminar As Krypton.Toolkit.KryptonButton
    Friend WithEvents btnModificar As Krypton.Toolkit.KryptonButton
    Friend WithEvents btnCrear As Krypton.Toolkit.KryptonButton
    Friend WithEvents dgvListaPuestos As Krypton.Toolkit.KryptonDataGridView
End Class

