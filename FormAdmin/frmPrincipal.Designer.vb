<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPrincipal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrincipal))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.panelContenedor = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.txtBuscarSalario = New Krypton.Toolkit.KryptonTextBox()
        Me.lblListaSalarios = New System.Windows.Forms.Label()
        Me.KryptonTextBox1 = New Krypton.Toolkit.KryptonTextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnResetSalario = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dgvListaSalarios = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtBuscarEmple = New Krypton.Toolkit.KryptonTextBox()
        Me.btnResetEmpleados = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgvListaEmpleados = New System.Windows.Forms.DataGridView()
        Me.panelContenedor.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.dgvListaSalarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.dgvListaEmpleados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panelContenedor
        '
        Me.panelContenedor.AutoScroll = True
        Me.panelContenedor.BackColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.panelContenedor.Controls.Add(Me.Panel3)
        Me.panelContenedor.Controls.Add(Me.Panel1)
        Me.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelContenedor.Location = New System.Drawing.Point(0, 0)
        Me.panelContenedor.Name = "panelContenedor"
        Me.panelContenedor.Size = New System.Drawing.Size(880, 615)
        Me.panelContenedor.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Controls.Add(Me.dgvListaSalarios)
        Me.Panel3.Location = New System.Drawing.Point(10, 216)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(860, 200)
        Me.Panel3.TabIndex = 60
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Panel4.Controls.Add(Me.txtBuscarSalario)
        Me.Panel4.Controls.Add(Me.lblListaSalarios)
        Me.Panel4.Controls.Add(Me.KryptonTextBox1)
        Me.Panel4.Controls.Add(Me.Label9)
        Me.Panel4.Controls.Add(Me.btnResetSalario)
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(858, 40)
        Me.Panel4.TabIndex = 9
        '
        'txtBuscarSalario
        '
        Me.txtBuscarSalario.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.txtBuscarSalario.Location = New System.Drawing.Point(718, 6)
        Me.txtBuscarSalario.Name = "txtBuscarSalario"
        Me.txtBuscarSalario.Size = New System.Drawing.Size(99, 28)
        Me.txtBuscarSalario.StateCommon.Back.Color1 = System.Drawing.Color.White
        Me.txtBuscarSalario.StateCommon.Border.Color1 = System.Drawing.Color.White
        Me.txtBuscarSalario.StateCommon.Border.Color2 = System.Drawing.Color.White
        Me.txtBuscarSalario.StateCommon.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.txtBuscarSalario.StateCommon.Border.Rounding = 10.0!
        Me.txtBuscarSalario.StateCommon.Content.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.txtBuscarSalario.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.txtBuscarSalario.StateNormal.Border.Color1 = System.Drawing.Color.White
        Me.txtBuscarSalario.StateNormal.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.txtBuscarSalario.TabIndex = 16
        Me.txtBuscarSalario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblListaSalarios
        '
        Me.lblListaSalarios.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblListaSalarios.AutoSize = True
        Me.lblListaSalarios.Font = New System.Drawing.Font("Arial", 14.25!)
        Me.lblListaSalarios.ForeColor = System.Drawing.Color.White
        Me.lblListaSalarios.Location = New System.Drawing.Point(6, 7)
        Me.lblListaSalarios.Margin = New System.Windows.Forms.Padding(429, 0, 429, 0)
        Me.lblListaSalarios.Name = "lblListaSalarios"
        Me.lblListaSalarios.Size = New System.Drawing.Size(147, 22)
        Me.lblListaSalarios.TabIndex = 15
        Me.lblListaSalarios.Text = "Lista de salarios"
        Me.lblListaSalarios.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'KryptonTextBox1
        '
        Me.KryptonTextBox1.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.KryptonTextBox1.Location = New System.Drawing.Point(1152, -20)
        Me.KryptonTextBox1.Name = "KryptonTextBox1"
        Me.KryptonTextBox1.Size = New System.Drawing.Size(99, 28)
        Me.KryptonTextBox1.StateCommon.Back.Color1 = System.Drawing.Color.White
        Me.KryptonTextBox1.StateCommon.Border.Color1 = System.Drawing.Color.White
        Me.KryptonTextBox1.StateCommon.Border.Color2 = System.Drawing.Color.White
        Me.KryptonTextBox1.StateCommon.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.KryptonTextBox1.StateCommon.Border.Rounding = 10.0!
        Me.KryptonTextBox1.StateCommon.Content.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.KryptonTextBox1.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.KryptonTextBox1.StateNormal.Border.Color1 = System.Drawing.Color.White
        Me.KryptonTextBox1.StateNormal.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.KryptonTextBox1.TabIndex = 14
        Me.KryptonTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 14.25!)
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(2, -42)
        Me.Label9.Margin = New System.Windows.Forms.Padding(429, 0, 429, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(147, 22)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "Lista de salarios"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnResetSalario
        '
        Me.btnResetSalario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnResetSalario.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnResetSalario.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnResetSalario.FlatAppearance.BorderSize = 0
        Me.btnResetSalario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnResetSalario.Image = CType(resources.GetObject("btnResetSalario.Image"), System.Drawing.Image)
        Me.btnResetSalario.Location = New System.Drawing.Point(824, 0)
        Me.btnResetSalario.Name = "btnResetSalario"
        Me.btnResetSalario.Size = New System.Drawing.Size(34, 40)
        Me.btnResetSalario.TabIndex = 10
        Me.btnResetSalario.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 14.25!)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(6, -98)
        Me.Label3.Margin = New System.Windows.Forms.Padding(429, 0, 429, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(177, 22)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Lista de empleados"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'dgvListaSalarios
        '
        Me.dgvListaSalarios.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvListaSalarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvListaSalarios.BackgroundColor = System.Drawing.Color.White
        Me.dgvListaSalarios.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.NullValue = "Vacio"
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvListaSalarios.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvListaSalarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 12.0!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvListaSalarios.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvListaSalarios.Location = New System.Drawing.Point(0, 40)
        Me.dgvListaSalarios.Name = "dgvListaSalarios"
        Me.dgvListaSalarios.RowTemplate.Height = 25
        Me.dgvListaSalarios.Size = New System.Drawing.Size(858, 159)
        Me.dgvListaSalarios.TabIndex = 8
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
        Me.Panel1.Location = New System.Drawing.Point(9, 10)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(860, 200)
        Me.Panel1.TabIndex = 10
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Panel2.Controls.Add(Me.txtBuscarEmple)
        Me.Panel2.Controls.Add(Me.btnResetEmpleados)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(858, 40)
        Me.Panel2.TabIndex = 9
        '
        'txtBuscarEmple
        '
        Me.txtBuscarEmple.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.txtBuscarEmple.Location = New System.Drawing.Point(719, 6)
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
        Me.btnResetEmpleados.Location = New System.Drawing.Point(824, 0)
        Me.btnResetEmpleados.Name = "btnResetEmpleados"
        Me.btnResetEmpleados.Size = New System.Drawing.Size(34, 40)
        Me.btnResetEmpleados.TabIndex = 10
        Me.btnResetEmpleados.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 14.25!)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(7, 8)
        Me.Label2.Margin = New System.Windows.Forms.Padding(429, 0, 429, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(177, 22)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Lista de empleados"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
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
        Me.dgvListaEmpleados.Location = New System.Drawing.Point(0, 33)
        Me.dgvListaEmpleados.Name = "dgvListaEmpleados"
        Me.dgvListaEmpleados.RowTemplate.Height = 25
        Me.dgvListaEmpleados.Size = New System.Drawing.Size(858, 162)
        Me.dgvListaEmpleados.TabIndex = 8
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(880, 615)
        Me.Controls.Add(Me.panelContenedor)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmPrincipal"
        Me.Text = "frmPrincipal"
        Me.panelContenedor.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.dgvListaSalarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.dgvListaEmpleados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents panelContenedor As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents dgvListaEmpleados As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnResetEmpleados As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents lblListaSalarios As Label
    Friend WithEvents KryptonTextBox1 As Krypton.Toolkit.KryptonTextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents btnResetSalario As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents dgvListaSalarios As DataGridView
    Friend WithEvents txtBuscarSalario As Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtBuscarEmple As Krypton.Toolkit.KryptonTextBox
End Class
