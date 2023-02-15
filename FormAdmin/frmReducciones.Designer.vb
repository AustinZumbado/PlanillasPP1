<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmReducciones
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
        Me.tbcContenedor = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
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
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.tbcContenedor.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.Panel14.SuspendLayout()
        Me.Panel15.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvListaSalarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbcContenedor
        '
        Me.tbcContenedor.Controls.Add(Me.TabPage1)
        Me.tbcContenedor.Controls.Add(Me.TabPage2)
        Me.tbcContenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbcContenedor.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.tbcContenedor.Location = New System.Drawing.Point(0, 0)
        Me.tbcContenedor.Name = "tbcContenedor"
        Me.tbcContenedor.SelectedIndex = 0
        Me.tbcContenedor.Size = New System.Drawing.Size(800, 549)
        Me.tbcContenedor.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Panel14)
        Me.TabPage1.Controls.Add(Me.Panel1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 31)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(792, 514)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Semanal"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Panel14
        '
        Me.Panel14.AutoScroll = True
        Me.Panel14.BackColor = System.Drawing.Color.White
        Me.Panel14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel14.Controls.Add(Me.Panel15)
        Me.Panel14.Controls.Add(Me.cmbPlanillaSemana)
        Me.Panel14.Location = New System.Drawing.Point(11, 18)
        Me.Panel14.Name = "Panel14"
        Me.Panel14.Size = New System.Drawing.Size(200, 73)
        Me.Panel14.TabIndex = 68
        '
        'Panel15
        '
        Me.Panel15.BackColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Panel15.Controls.Add(Me.lblPlanila)
        Me.Panel15.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel15.Location = New System.Drawing.Point(0, 0)
        Me.Panel15.Name = "Panel15"
        Me.Panel15.Size = New System.Drawing.Size(198, 30)
        Me.Panel15.TabIndex = 55
        '
        'lblPlanila
        '
        Me.lblPlanila.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblPlanila.AutoSize = True
        Me.lblPlanila.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblPlanila.ForeColor = System.Drawing.Color.White
        Me.lblPlanila.Location = New System.Drawing.Point(61, 4)
        Me.lblPlanila.Margin = New System.Windows.Forms.Padding(500, 0, 500, 0)
        Me.lblPlanila.Name = "lblPlanila"
        Me.lblPlanila.Size = New System.Drawing.Size(69, 22)
        Me.lblPlanila.TabIndex = 21
        Me.lblPlanila.Text = "Planilla"
        Me.lblPlanila.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'cmbPlanillaSemana
        '
        Me.cmbPlanillaSemana.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.cmbPlanillaSemana.FormattingEnabled = True
        Me.cmbPlanillaSemana.Location = New System.Drawing.Point(3, 38)
        Me.cmbPlanillaSemana.Name = "cmbPlanillaSemana"
        Me.cmbPlanillaSemana.Size = New System.Drawing.Size(192, 26)
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
        Me.Panel1.Location = New System.Drawing.Point(10, 107)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(776, 401)
        Me.Panel1.TabIndex = 60
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
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.NullValue = "Vacio"
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvListaSalarios.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvListaSalarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvListaSalarios.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvListaSalarios.Location = New System.Drawing.Point(3, 42)
        Me.dgvListaSalarios.Name = "dgvListaSalarios"
        Me.dgvListaSalarios.RowTemplate.Height = 25
        Me.dgvListaSalarios.Size = New System.Drawing.Size(768, 354)
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
        Me.Panel3.Size = New System.Drawing.Size(774, 36)
        Me.Panel3.TabIndex = 9
        '
        'txtBuscar
        '
        Me.txtBuscar.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.txtBuscar.Location = New System.Drawing.Point(622, 3)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(115, 28)
        Me.txtBuscar.StateCommon.Back.Color1 = System.Drawing.Color.White
        Me.txtBuscar.StateCommon.Border.Color1 = System.Drawing.Color.White
        Me.txtBuscar.StateCommon.Border.Color2 = System.Drawing.Color.White
        Me.txtBuscar.StateCommon.Border.DrawBorders = CType((((Krypton.Toolkit.PaletteDrawBorders.Top Or Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or Krypton.Toolkit.PaletteDrawBorders.Right), Krypton.Toolkit.PaletteDrawBorders)
        Me.txtBuscar.StateCommon.Border.Rounding = 10.0!
        Me.txtBuscar.StateCommon.Content.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
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
        Me.lblListaSalarios.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblListaSalarios.ForeColor = System.Drawing.Color.White
        Me.lblListaSalarios.Location = New System.Drawing.Point(3, 5)
        Me.lblListaSalarios.Margin = New System.Windows.Forms.Padding(500, 0, 500, 0)
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
        'Me.btnReset.Image = Global.ProyectoPlanillas.My.Resources.Resources.btnReiniciar
        Me.btnReset.Location = New System.Drawing.Point(734, 0)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(40, 36)
        Me.btnReset.TabIndex = 10
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(4, 31)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(792, 514)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Quincenal"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'frmReducciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 549)
        Me.Controls.Add(Me.tbcContenedor)
        Me.Name = "frmReducciones"
        Me.Text = "frmReducciones"
        Me.tbcContenedor.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.Panel14.ResumeLayout(False)
        Me.Panel15.ResumeLayout(False)
        Me.Panel15.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.dgvListaSalarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tbcContenedor As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Panel1 As Panel
    Friend WithEvents dgvListaSalarios As DataGridView
    Friend WithEvents Panel3 As Panel
    Friend WithEvents txtBuscar As Krypton.Toolkit.KryptonTextBox
    Friend WithEvents lblListaSalarios As Label
    Friend WithEvents btnReset As Button
    Friend WithEvents Panel14 As Panel
    Friend WithEvents Panel15 As Panel
    Friend WithEvents lblPlanila As Label
    Friend WithEvents cmbPlanillaSemana As ComboBox
End Class
