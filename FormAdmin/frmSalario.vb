Imports MySql.Data.MySqlClient
Public Class frmSalario
    Dim cmd As MySqlCommand
    Dim cedulaEmpleado As String = ""
    Dim horasTraCheak As Integer = 0
    Dim horasNormalCheak As Integer = 0
    Dim horasMediaCheak As Integer = 0
    Dim horasDoblesCheak As Integer = 0
    Dim idHorasEmple As Integer = 0
    Private Sub frmSalarios_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            txtCedula.Enabled = False
            txtNombre.Enabled = False
            txtTotal.Enabled = False
            txtHorasNormales.Enabled = False
            txtCedulaQuin.Enabled = False
            txtNombreQuin.Enabled = False
            txtTotalQuin.Enabled = False
            CargarDatos()
            CargarDatosQuin()
            llenarComboBox(cmbPlanillaSemana)
            llenarComboBoxQuin(cmbPlanilaQuin)
            llenarLabel(cmbPlanillaSemana.Text)
            cnn.Close()
        Catch ex As Exception
            MsgBox("No se pudo cargar los salarios, favor intentar mas tarde..." + ex.ToString)
        End Try
    End Sub
    Sub CalHoraNormal()
        Dim txt1, txt2, txt3, horaResult As Double
        Do
            Dim correcto As Boolean = (txtHorasTrabajadas.Text <> String.Empty)
            If (Not (correcto)) Then Exit Do
            correcto = (txtHorasDobles.Text() <> String.Empty)
            If (Not (correcto)) Then Exit Do
            correcto = (txtHorasMedia.Text() <> String.Empty)
            If (Not (correcto)) Then Exit Do
            txt2 = CDbl(txtHorasDobles.Text)
            txt1 = CDbl(txtHorasTrabajadas.Text)
            txt3 = CDbl(txtHorasMedia.Text)
            If txtHorasTrabajadas.Text <= 48 Then
                txtHorasNormales.Text = txt1
                txtHorasDobles.Enabled = False
                txtHorasMedia.Enabled = False
                txtHorasDobles.Text = 0
                txtHorasMedia.Text = 0
            ElseIf txtHorasTrabajadas.Text > 48 Then
                txtHorasDobles.Enabled = True
                txtHorasMedia.Enabled = True
                horaResult = txt1 - txt2 - txt3
                txtHorasNormales.Text = horaResult
            End If
            Return
        Loop
        txt1 = 0.0R
        txt2 = 0.0R
        txt3 = 0.0R
    End Sub

    Sub llenarComboBox(ByVal cb As ComboBox)
        Try
            Abrir()
            cmd = New MySqlCommand("SELECT idPlanilla FROM planillaSemanal ORDER BY idPlanilla", cnn)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()
            While reader.Read
                cb.Items.Add(reader.Item("idPlanilla"))
            End While
        Catch ex As Exception
            MsgBox("No se pudo cargar los datos, favor intentar mas tarde..." + ex.ToString)
        End Try
    End Sub
    Sub consultarSalario(ByVal idPlanilla As String, ByVal cedula As String)
        Try
            Abrir()
            cmd = New MySqlCommand("select empleados.cedula as 'Cedula', empleados.nombre as 'Nombre', format(empleados.salarioHora, 2) as 'Salario por hora',
                                        format((salarioHora*horasNormales)+((empleados.salarioHora*horasMedias)*1.5)+((empleados.salarioHora*horasDobles)*2), 2) as 'Salario' 
                                        from horasempleados inner join
                                        empleados on horasempleados.cedula = empleados.cedula inner join
                                        formapago on horasempleados.formaPago = formapago.formaPago
                                        where empleados.formaPago = 2 and horasempleados.idPlanilla ='" & idPlanilla & "' and Empleados.cedula like '" & cedula & "'", cnn)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()
            If reader.Read Then
                txtTotal.Text = reader("Salario").ToString
            End If
        Catch ex As Exception
            MsgBox("No se pudo cargar los datos, favor intentar mas tarde..." + ex.ToString)
        End Try
    End Sub
    Sub llenarLabel(ByVal idPlanilla As String)
        Try
            Abrir()
            cmd = New MySqlCommand("Select date_format(diaInicio, '%d/%m/%Y') as 'diaInicio', date_format(diaFinal, '%d/%m/%Y') as 'diaFinal' 
                                        From planillaSemanal 
                                        WHERE idPlanilla = '" & idPlanilla & "'", cnn)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()
            If reader.Read Then
                lblListaSalarios.Text = "De " & reader("diaInicio").ToString & " al " & reader("diaFinal").ToString
            End If
        Catch ex As Exception
            MsgBox("No se pudo cargar los datos, favor intentar mas tarde..." + ex.ToString)
        End Try
    End Sub
    Sub llenarDateGriew(ByVal dgv As DataGridView, ByVal cbText As String)
        Try
            Dim dt As New DataTable
            Abrir()
            Using adaptador As New MySqlDataAdapter("select horasempleados.idHorasEmple as 'ID', empleados.cedula as 'Cedula', empleados.nombre as 'Nombre', format(empleados.salarioHora, 2) as 'Salario por hora',
                                                        horasempleados.horasTrabajadas as 'Horas trabajadas', horasempleados.horasNormales as 'Horas normales', 
                                                        format(empleados.salarioHora*horasNormales, 2) as 'Salario normal',
                                                        horasempleados.horasMedias as 'Horas 1/2',
                                                        format((empleados.salarioHora*horasMedias)*1.5, 2) as 'Salario medio',
                                                        horasempleados.horasDobles as 'Horas dobles',
                                                        format((empleados.salarioHora*horasDobles)*2, 2) as 'Salario doble',
                                                        format((salarioHora*horasNormales)+((empleados.salarioHora*horasMedias)*1.5)+((empleados.salarioHora*horasDobles)*2), 2) as 'Salario' 
                                                        from horasempleados inner join
                                                        empleados on horasempleados.cedula = empleados.cedula inner join
                                                        formapago on horasempleados.formaPago = formapago.formaPago
                                                        where empleados.formaPago = 2 and horasempleados.idPlanilla ='" & cbText & "'", cnn)
                adaptador.Fill(dt)
            End Using
            dgv.DataSource = dt
            dgv.Columns("ID").Visible = False
            cnn.Close()
        Catch ex As Exception
            MsgBox("No se pudo cargar los datos, favor intentar mas tarde..." + ex.ToString)
        End Try
    End Sub
    Sub consultarDateGriew(ByVal dgv As DataGridView, ByVal cedula As String, ByVal cbText As String)
        Try
            Dim dt As New DataTable
            Abrir()
            Using adaptador As New MySqlDataAdapter("select horasempleados.idHorasEmple as 'ID', empleados.cedula as 'Cedula', empleados.nombre as 'Nombre', format(empleados.salarioHora, 2) as 'Salario por hora',
                                                        horasempleados.horasTrabajadas as 'Horas trabajadas', horasempleados.horasNormales as 'Horas normales', 
                                                        format(empleados.salarioHora*horasNormales, 2) as 'Salario normal',
                                                        horasempleados.horasMedias as 'Horas 1/2',
                                                        format((empleados.salarioHora*horasMedias)*1.5, 2) as 'Salario medio',
                                                        horasempleados.horasDobles as 'Horas dobles',
                                                        format((empleados.salarioHora*horasDobles)*2, 2) as 'Salario doble',
                                                        format((salarioHora*horasNormales)+((empleados.salarioHora*horasMedias)*1.5)+((empleados.salarioHora*horasDobles)*2), 2) as 'Salario' 
                                                        from horasempleados inner join
                                                        empleados on horasempleados.cedula = empleados.cedula inner join
                                                        formapago on horasempleados.formaPago = formapago.formaPago
                                                        where empleados.formaPago = 2 and horasempleados.idPlanilla ='" & cbText & "' and Empleados.cedula like '" & "%" + cedula + "%" & "'", cnn)
                adaptador.Fill(dt)
            End Using
            dgv.DataSource = dt
            cnn.Close()
        Catch ex As Exception
            MsgBox("No se pudo cargar los datos, favor intentar mas tarde..." + ex.ToString)
        End Try
    End Sub
    Sub CargarDatos()
        Try
            Dim dt As New DataTable
            Abrir()
            Using adaptador As New MySqlDataAdapter("select Empleados.cedula as 'Cedula', Empleados.nombre as 'Nombre', tipoEmpleado.nombre as 'Tipo de usuario', formaPago.nombre as 'Forma de pago',
                                                    tipoEmpleado.salarioMensual as 'Salario Mensual', Empleados.salarioHora as 'Salario hora'
                                                    from Empleados inner join
                                                    tipoEmpleado on Empleados.tipoEmpleado = tipoEmpleado.tipoEmpleado inner join
                                                    formaPago on Empleados.formaPago = formaPago.formaPago
                                                    where Empleados.formaPago = '2'", cnn)
                adaptador.Fill(dt)
            End Using
            dgvListaSalarios.DataSource = dt
            cnn.Close()
        Catch ex As Exception
            MsgBox("No se pudo cargar los datos, favor intentar mas tarde..." + ex.ToString)
        End Try
    End Sub
    Sub consultarNombre(ByVal cedula As String, ByVal dgv As DataGridView)
        Try
            Dim dt As New DataTable
            Abrir()
            Using adaptador As New MySqlDataAdapter("select Empleados.cedula as 'Cedula', Empleados.nombre as 'Nombre', tipoEmpleado.nombre as 'Tipo de usuario', formaPago.nombre as 'Forma de pago',
                                                    tipoEmpleado.salarioMensual as 'Salario Mensual', Empleados.salarioHora as 'Salario hora'
                                                    from Empleados inner join
                                                    tipoEmpleado on Empleados.tipoEmpleado = tipoEmpleado.tipoEmpleado inner join
                                                    formaPago on Empleados.formaPago = formaPago.formaPago
                                                    where Empleados.formaPago = 2 and Empleados.cedula like '" & "%" + cedula + "%" & "'", cnn)
                adaptador.Fill(dt)
            End Using
            dgv.DataSource = dt
            cnn.Close()
        Catch ex As Exception
            MsgBox("No se pudo cargar los datos, favor intentar mas tarde..." + ex.ToString)
        End Try
    End Sub
    Private Sub formReset()
        If tbcContenedor.SelectedIndex = 0 Then
            txtNombre.Text = "Seleccione el nombre"
            txtCedula.Text = "Seleccione la cedula"
            txtHorasTrabajadas.Text = "0"
            txtHorasDobles.Text = "0"
            txtHorasMedia.Text = "0"
            txtHorasNormales.Text = "0"
            cnn.Close()
        ElseIf tbcContenedor.SelectedIndex = 1 Then
            txtNombreQuin.Text = "Seleccione el nombre"
            txtCedulaQuin.Text = "Seleccione la cedula"
            cmbPlanilaQuin.Text = "Elija una opcion"
            CargarDatosQuin()
            cnn.Close()
        End If
    End Sub
    Private Sub btnReiniciar_Click(sender As Object, e As EventArgs)
        formReset()
    End Sub
    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        If tbcContenedor.SelectedIndex = 0 Then
            If cmbPlanillaSemana.Text = "Elija una opcion" Then
                consultarNombre(txtBuscar.Text, dgvListaSalarios)
            ElseIf cmbPlanillaSemana.Text <> "Elija una opcion" Then
                consultarDateGriew(dgvListaSalarios, txtBuscar.Text, cmbPlanillaSemana.Text)
            End If
        End If
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        CargarDatos()
    End Sub

    Sub llenarComboBoxQuin(ByVal cb As ComboBox)
        Try
            Abrir()
            cmd = New MySqlCommand("SELECT diaInicial,diaFinal FROM planillaQuincenal ORDER BY diaInicial,diaFinal", cnn)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()
            While reader.Read
                cb.Items.Add(reader.Item("diaInicial") & " - " & reader.Item("diaFinal"))
            End While
        Catch ex As Exception
            MsgBox("No se pudo cargar los datos, favor intentar mas tarde..." + ex.ToString)
        End Try
    End Sub
    Sub llenarDateGriewQuin(ByVal dgv As DataGridView, ByVal cbText As String)
        Try
            Dim dt As New DataTable
            Abrir()
            Using adaptador As New MySqlDataAdapter("select Empleados.cedula as 'Cedula', Empleados.nombre as 'Nombre', tipoEmpleado.salarioMensual as 'Salario mensual',
                                                    Empleados.salarioHora as 'Salario hora', Empleados.horasTrabajadas as 'Horas trabajadas', Empleados.horasNormales as 'Horas normales',
                                                    Empleados.horaMedia as 'Horas 1/2', Empleados.horaDoble as 'Horas dobles'
                                                    from Empleados inner join
                                                    planillaQuincenal on Empleados.fechaIngreso <= planillaQuincenal.diaInicial or
													Empleados.fechaIngreso <= planillaQuincenal.diaFinal inner join
                                                    horasEmpleados on horasEmpleados.horasTrabajadas = horasEmpleados.horasTrabajadas inner join
                                                    tipoEmpleado on Empleados.tipoEmpleado = tipoEmpleado.tipoEmpleado
                                                    where Empleados.formaPago = 1 and CONVERT(nvarchar,diaInicial,103) + ' - ' + CONVERT(nvarchar,diaFinal,103) like'" & "%" + cbText + "%" & "'", cnn)
                adaptador.Fill(dt)
            End Using
            dgv.DataSource = dt
            cnn.Close()
        Catch ex As Exception
            MsgBox("No se pudo cargar los datos, favor intentar mas tarde..." + ex.ToString)
        End Try
    End Sub
    Sub CargarDatosQuin()
        Try
            Dim dt As New DataTable
            Abrir()
            Using adaptador As New MySqlDataAdapter("select Empleados.cedula as 'Cedula', Empleados.nombre as 'Nombre', tipoEmpleado.nombre as 'Tipo de usuario', formaPago.nombre as 'Forma de pago',
                                                    tipoEmpleado.salarioMensual as 'Salario Mensual', Empleados.salarioHora as 'Salario hora'
                                                    from Empleados inner join
                                                    tipoEmpleado on Empleados.tipoEmpleado = tipoEmpleado.tipoEmpleado inner join
                                                    formaPago on Empleados.formaPago = formaPago.formaPago
                                                    where Empleados.formaPago = '1'", cnn)
                adaptador.Fill(dt)
            End Using
            dgvListaQuin.DataSource = dt
            cnn.Close()
        Catch ex As Exception
            MsgBox("No se pudo cargar los datos, favor intentar mas tarde..." + ex.ToString)
        End Try
    End Sub
    Private Sub cmbPlanillaSemana_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPlanillaSemana.SelectedIndexChanged
        llenarDateGriew(dgvListaSalarios, cmbPlanillaSemana.Text)
        llenarLabel(cmbPlanillaSemana.Text)
        formReset()
    End Sub

    Private Sub tmCalcularHora_Tick(sender As Object, e As EventArgs) Handles tmCalcularHora.Tick
        CalHoraNormal()
        If tbcContenedor.SelectedIndex = 0 Then
            If cmbPlanillaSemana.Text = "Elija una opcion" Then
                txtHorasTrabajadas.Enabled = False
                txtHorasMedia.Enabled = False
                txtHorasDobles.Enabled = False
            ElseIf cmbPlanillaSemana.Text <> "Elija una opcion" Then
                txtHorasTrabajadas.Enabled = True
                txtHorasMedia.Enabled = True
                txtHorasDobles.Enabled = True
            End If
        ElseIf tbcContenedor.SelectedIndex = 1 Then
            If cmbPlanilaQuin.Text = "Elija una opcion" Then
                txtHorasTrabajadasQuin.Enabled = False
                txtHoraMediaQuin.Enabled = False
                txtHoraDobleQuin.Enabled = False
                txtHorasNormalesQuin.Enabled = False
            ElseIf cmbPlanilaQuin.Text <> "Elija una opcion" Then
                txtHorasTrabajadasQuin.Enabled = True
                txtHoraMediaQuin.Enabled = True
                txtHoraDobleQuin.Enabled = True
                txtHorasNormalesQuin.Enabled = True
            End If
        End If
    End Sub
    Private Sub txtHorasMedia_TextChanged(sender As Object, e As EventArgs) Handles txtHorasMedia.TextChanged
        CalHoraNormal()
    End Sub
    Private Sub btnCrear_Click(sender As Object, e As EventArgs) Handles btnCrear.Click
        Try
            If tbcContenedor.SelectedIndex = 0 Then
                Abrir()
                cmd = New MySqlCommand("update horasempleados set horasTrabajadas=@horasTrabajadas,horasNormales=@horasNormales,horasMedias=@horasMedias,horasDobles=@horasDobles where cedula = '" & txtCedula.Text & "' and idPlanilla = '" & cmbPlanillaSemana.Text & "'", cnn)
                If txtHorasTrabajadas.Text = "" Then
                    MsgBox("Ingrese las horas trabajadas por el empleado")
                    horasTraCheak = 1
                Else
                    horasTraCheak = 0
                    cmd.Parameters.AddWithValue("@horasTrabajadas", txtHorasTrabajadas.Text)
                End If
                If txtHorasMedia.Text = "" Then
                    MsgBox("Ingrese las horas medias trabajadas por el empleado")
                    horasMediaCheak = 1

                ElseIf txtHorasMedia.Text = 0 Or txtHorasMedia.Text <> String.Empty Then
                    horasMediaCheak = 0
                    cmd.Parameters.AddWithValue("@horasMedias", txtHorasMedia.Text)
                End If
                If txtHorasDobles.Text = "" Then
                    MsgBox("Ingrese las horas dobles trabajas por el empleado")
                    horasDoblesCheak = 1
                ElseIf txtHorasDobles.Text = 0 Or txtHorasDobles.Text <> String.Empty Then
                    horasDoblesCheak = 0
                    cmd.Parameters.AddWithValue("@horasDobles", txtHorasDobles.Text)
                End If

                If horasTraCheak = 0 And horasMediaCheak = 0 And horasDoblesCheak = 0 Then
                    cmd.Parameters.AddWithValue("@horasNormales", txtHorasNormales.Text)
                    cmd.ExecuteNonQuery()
                    MsgBox("Datos agregados")
                    llenarDateGriew(dgvListaSalarios, cmbPlanillaSemana.Text)

                Else
                    MsgBox("Error: Revise los datos")
                End If
            ElseIf tbcContenedor.SelectedIndex = 1 Then
                Abrir()
                cmd = New MySqlCommand("update Empleados set horasTrabajadas=@horasTrabajadas,horasNormales=@horasNormales,horaMedia=@horaMedia,horaDoble=@horaDoble where cedula =" + txtCedulaQuin.Text, cnn)
                If txtHorasTrabajadasQuin.Text = "" Then
                    MsgBox("Ingrese las horas trabajadas por el empleado")
                    horasTraCheak = 1
                Else
                    cmd.Parameters.AddWithValue("@horasTrabajadas", txtHorasTrabajadasQuin.Text)
                End If
                If txtHoraMediaQuin.Text = "" Then
                    MsgBox("Ingrese las horas medias trabajadas por el empleado")
                    horasMediaCheak = 1
                Else
                    cmd.Parameters.AddWithValue("@horaMedia", txtHoraMediaQuin.Text)
                End If
                If txtHoraDobleQuin.Text = "" Then
                    MsgBox("Ingrese las horas dobles trabajas por el empleado")
                    horasDoblesCheak = 1
                Else
                    cmd.Parameters.AddWithValue("@horaDoble", txtHoraDobleQuin.Text)
                End If
                If txtHorasNormalesQuin.Text < 48 Then
                    horasNormalCheak = 1
                    MsgBox("Las horas normales nos pueden ser menores a 48")
                Else
                    cmd.Parameters.AddWithValue("@horasNormales", txtHorasNormalesQuin.Text)
                End If
                If horasTraCheak = 0 And horasMediaCheak = 0 And horasDoblesCheak = 0 And horasNormalCheak = 0 Then
                    cmd.ExecuteNonQuery()
                    formReset()
                    MsgBox("Datos agregados")
                    llenarDateGriew(dgvListaQuin, cmbPlanilaQuin.Text)
                Else
                    MsgBox("Error: Revise los datos")
                End If
            End If

        Catch ex As Exception
            MsgBox("No se pudo agregar el salario, favor intentar mas tarde..." + ex.ToString)
        End Try
        cnn.Close()
        horasTraCheak = 0
        horasMediaCheak = 0
        horasDoblesCheak = 0
    End Sub
    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Try
            If txtNombre.Text = "Seleccione el nombre" Then
                MsgBox("Debe seleccionar un usuario para modificar.")
            Else
                If Me.ValidateChildren And txtCedula.Text <> String.Empty Or txtNombre.Text = "Seleccione el nombre" Then
                    If MessageBox.Show("Estas seguro que deseas modificar el empleado " & txtNombre.Text & "?", "Favor confimar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.OK Then
                        Dim ds As New DataSet
                        Dim msqlda As New MySqlDataAdapter
                        Abrir()
                        cmd = New MySqlCommand("update empleadoSalario set salarioQuincenal=@NEWsalarioQuincenal,salarioHora=@NEWsalarioHora,salarioMensual=@NEWsalarioMensual,horasTrabajadas=@NEWhorasTrabajadas where cedula =" + cedulaEmpleado, cnn)
                        cmd.Parameters.AddWithValue("@NEWsalarioHora", Me.txtHorasMedia.Text)
                        'cmd.Parameters.AddWithValue("@NEWsalarioQuincenal", Me.txtSalarioQuin.Text)
                        If txtHorasTrabajadas.Text = "" Then
                            MsgBox("Ingrese el salario del mes")
                            horasTraCheak = 0
                        Else
                            cmd.Parameters.AddWithValue("@NEWsalarioMensual", Me.txtHorasTrabajadas.Text)
                        End If
                    End If
                    cmd.ExecuteNonQuery()
                    MsgBox("Salario modificado.")
                    CargarDatos()
                    formReset()
                    cnn.Close()
                Else
                    MessageBox.Show("Debe seleccionar un empleado valido.")
                    formReset()
                End If
            End If
        Catch ex As Exception
            MsgBox("No se pudo modificar el empleado" + ex.ToString)
        End Try
    End Sub
    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim cmd As New MySqlCommand
        Try
            If txtNombre.Text = "Ingrese el nombre" Then
                MsgBox("Debe seleccionar un usuario")
            ElseIf txtNombre.Text = "" Then
                MsgBox("El usuario no puede estar en blanco")
            Else
                If MessageBox.Show("Estas seguro desea eliminar de la planilla a " & txtNombre.Text & "?", "por favor confimar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.OK Then
                    Abrir()
                    cmd.Connection = cnn
                    cmd.Parameters.AddWithValue("@idHorasEmple", idHorasEmple)
                    cmd.Parameters.AddWithValue("@idPlanilla", cmbPlanillaSemana.Text)
                    cmd.CommandText = "delete from horasempleados where idHorasEmple = @idHorasEmple and idPlanilla = @idPlanilla"
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Los datos han sido eliminados correctamente")
                    llenarDateGriew(dgvListaSalarios, cmbPlanillaSemana.Text)
                    cnn.Close()
                    formReset()
                End If
            End If
        Catch ex As Exception
            MsgBox("No se pudo eliminar el usuario" + ex.ToString)
        End Try
    End Sub
    Private Sub dgvListaSalarios_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvListaSalarios.CellContentClick
        Try
            If tbcContenedor.SelectedIndex = 0 Then
                If e.RowIndex >= 0 Then
                    Dim row As DataGridViewRow
                    row = Me.dgvListaSalarios.Rows(e.RowIndex)
                    txtCedula.Text = row.Cells("Cedula").Value.ToString
                    txtNombre.Text = row.Cells("Nombre").Value.ToString
                    txtHorasTrabajadas.Text = row.Cells("Horas trabajadas").Value
                    txtHorasMedia.Text = row.Cells("Horas dobles").Value
                    txtHorasDobles.Text = row.Cells("Horas 1/2").Value
                    txtHorasNormales.Text = row.Cells("Horas normales").Value
                End If
            End If
        Catch ex As Exception
            MsgBox("No se pudo seleccionar el salario" + ex.ToString)
        End Try
    End Sub

    Private Sub btnReporte_Click(sender As Object, e As EventArgs) Handles btnReporte.Click
        Dim formReportes As New frmReportesHoras
        formReportes.idPlanilla = cmbPlanillaSemana.Text
        formReportes.reporte = 1
        formReportes.ShowDialog()
    End Sub
End Class