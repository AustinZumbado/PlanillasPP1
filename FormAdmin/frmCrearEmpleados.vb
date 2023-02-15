Imports MySql.Data.MySqlClient
Public Class frmCrearEmpleados
    Dim cmd As MySqlCommand
    Dim cedulaCheak As Integer = 0
    Dim nombreCheak As Integer = 0
    Dim apellidoCheak As Integer = 0
    Dim tipoUsuarioCheak As Integer = 0
    Dim sexoCheak As Integer = 0
    Dim fechaCheak As Integer = 0
    Dim cedulaEmpleado As String = ""
    Dim formaPagoCheak As Integer = 0
    Dim salarioHora As Integer = 0
    Dim salarioMes As Integer = 0
    Dim idTipoEmple As Integer = 0
    Private Sub frmCrearEmpleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            CargarDatos()
            llenarComboBox(cmbTipoUsuario)
            cnn.Close()
        Catch ex As Exception
            MsgBox("No se pudo cargar los usuarios, favor intentar mas tarde..." + ex.ToString)
        End Try
    End Sub
    Sub consultarNombreEmpleados(ByVal cedula As String, ByVal dgv As DataGridView)
        Try
            Dim dt As New DataTable
            Abrir()
            Using adaptador As New MySqlDataAdapter("select Empleados.cedula as 'Cedula', Empleados.nombre as 'Nombre', Empleados.apellido as 'Apellido',tipoEmpleado.nombre as 'Tipo de usuario', generoEmpleado.nombre as 'Sexo',
                                                    Empleados.fechaIngreso as 'Fecha de ingreso', Empleados.fechaSalida as 'Fecha de salida', formaPago.nombre as 'Forma de pago'
                                                    from Empleados inner join
                                                    tipoEmpleado on Empleados.tipoEmpleado = tipoEmpleado.tipoEmpleado inner join
                                                    generoEmpleado on Empleados.tipoSexo = generoEmpleado.tipoSexo inner join
													formaPago on Empleados.formaPago = formaPago.formaPago
                                                   where Empleados.cedula like '" & "%" + cedula + "%" & "'", cnn)
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
            Using adaptador As New MySqlDataAdapter("select Empleados.cedula as 'Cedula', Empleados.nombre as 'Nombre', Empleados.apellido as 'Apellido',tipoEmpleado.nombre as 'Tipo de usuario', generoEmpleado.nombre as 'Sexo',
                                                    Empleados.fechaIngreso as 'Fecha de ingreso', Empleados.fechaSalida as 'Fecha de salida', formaPago.nombre as 'Forma de pago'
                                                    from Empleados inner join
                                                    tipoEmpleado on Empleados.tipoEmpleado = tipoEmpleado.tipoEmpleado inner join
                                                    generoEmpleado on Empleados.tipoSexo = generoEmpleado.tipoSexo inner join
													formaPago on Empleados.formaPago = formaPago.formaPago", cnn)
                adaptador.Fill(dt)
            End Using
            dgvListaEmpleados.DataSource = dt
            cnn.Close()
        Catch ex As Exception
            MsgBox("No se pudo cargar los datos, favor intentar mas tarde..." + ex.ToString)
        End Try
    End Sub
    Sub llenarComboBox(ByVal cb As ComboBox)
        Try
            Abrir()
            cmd = New MySqlCommand("SELECT tipoEmpleado.nombre as 'Nombre' FROM tipoempleado", cnn)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()
            While reader.Read
                cb.Items.Add(reader.Item("Nombre"))
            End While
        Catch ex As Exception
            MsgBox("No se pudo cargar los datos, favor intentar mas tarde..." + ex.ToString)
        End Try
    End Sub
    Private Sub formReset()
        txtNombre.Text = "Ingrese el nombre"
        txtCedula.Text = "Ingrese una cedula"
        txtApellido.Text = "Ingrese el apellido"
        cmbSexo.Text = "Elija una opcion"
        cmbTipoUsuario.Text = "Elija una opcion"
        cmbFormaPago.Text = "Elija una opcion"
        dtpFechaIngreso.Value = "03/01/2023"
        dtpFechaSalida.Value = "03/01/2023"
        salarioHora = 0
        salarioHora = 0
        CargarDatos()
        cnn.Close()
    End Sub
    Private Sub dgvListaEmpleados_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles dgvListaEmpleados.CellContentClick
        Try
            If e.RowIndex >= 0 Then
                Dim row As DataGridViewRow
                row = Me.dgvListaEmpleados.Rows(e.RowIndex)
                txtNombre.Text = row.Cells("Nombre").Value.ToString
                txtCedula.Text = row.Cells("Cedula").Value.ToString
                txtApellido.Text = row.Cells("Apellido").Value.ToString
                dtpFechaIngreso.Value = row.Cells("Fecha de ingreso").Value.ToString
                dtpFechaSalida.Value = row.Cells("Fecha de salida").Value.ToString
                cmbTipoUsuario.Text = row.Cells("Tipo de usuario").Value.ToString
                cmbSexo.Text = row.Cells("Sexo").Value.ToString
                cmbFormaPago.Text = row.Cells("Forma de pago").Value.ToString
                cedulaEmpleado = row.Cells(0).Value.ToString
            End If
        Catch ex As Exception
            MsgBox("No se pudo seleccionar el usuario" + ex.ToString)
        End Try
    End Sub

    Private Sub txtBuscarEmpleado_TextChanged(sender As Object, e As EventArgs) Handles txtBuscarEmpleado.TextChanged
        consultarNombreEmpleados(txtBuscarEmpleado.Text, dgvListaEmpleados)
    End Sub
    Private Sub tmCalcularHora_Tick(sender As Object, e As EventArgs) Handles tmCalcularHora.Tick
        Dim calculo As Integer = 0
        If cmbFormaPago.Text = "Quincenal" Then
            calculo = Math.Round(salarioMes / 30)
            salarioHora = Math.Round(calculo / 8)
        ElseIf cmbFormaPago.Text = "Semanal" Then
            calculo = Math.Round(salarioMes / 28)
            salarioHora = Math.Round(calculo / 8)
        End If
    End Sub

    Private Sub cmbTipoUsuario_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTipoUsuario.SelectedIndexChanged
        Try
            Abrir()
            cmd = New MySqlCommand("select tipoEmpleado as 'ID', tipoempleado.nombre as 'Nombre', tipoEmpleado.salarioMensual as 'salarioMensual' FROM tipoempleado 
                                        where nombre like '" & cmbTipoUsuario.Text & "'", cnn)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()
            While reader.Read
                salarioMes = reader("salarioMensual")
                idTipoEmple = reader("ID")
            End While
        Catch ex As Exception
            MsgBox("No se pudo cargar los datos, favor intentar mas tarde..." + ex.ToString)
        End Try
    End Sub

    Private Sub btnResetEmpleados_Click(sender As Object, e As EventArgs) Handles btnResetEmpleados.Click
        CargarDatos()
    End Sub

    Private Sub btnCrear_Click(sender As Object, e As EventArgs) Handles btnCrear.Click
        Try
            Abrir()
            cmd = New MySqlCommand("INSERT INTO Empleados (cedula,nombre,apellido,tipoSexo,fechaIngreso,fechaSalida,tipoEmpleado,formaPago,salarioHora) values (@cedula,@nombre,@apellido,@tipoSexo,@fechaIngreso,@fechaSalida,@tipoEmpleado,@formaPago,@salarioHora)", cnn)
            If txtNombre.Text = "Ingrese el nombre" Then
                MsgBox("Debe ingresar un nombre de empleado valido", MsgBoxStyle.MsgBoxHelp, "Nombre")
                nombreCheak = 1
            ElseIf txtNombre.Text = "" Then
                MsgBox("La opcion nombre no puede estar vacia", MsgBoxStyle.MsgBoxHelp, "Nombre")
                nombreCheak = 1
            Else
                cmd.Parameters.AddWithValue("@nombre", Me.txtNombre.Text)
            End If

            If txtApellido.Text = "Ingrese el apellido" Then
                MsgBox("Debe ingresar un apellido valido", MsgBoxStyle.MsgBoxHelp, "Apellido")
                apellidoCheak = 1
            ElseIf txtApellido.Text = "" Then
                MsgBox("El apellido no puede estar vacio.", MsgBoxStyle.MsgBoxHelp, "Apellido")
                apellidoCheak = 1
            Else
                cmd.Parameters.AddWithValue("@apellido", Me.txtApellido.Text)
            End If

            If dtpFechaIngreso.Value = dtpFechaSalida.Value Then
                MsgBox("La fecha de ingreso y la fecha de salida no pueden ser la misma", MsgBoxStyle.MsgBoxHelp, "Fechas")
                fechaCheak = 1
            Else
                cmd.Parameters.AddWithValue("@fechaIngreso", Me.dtpFechaIngreso.Value.Date)
                cmd.Parameters.AddWithValue("@fechaSalida", Me.dtpFechaSalida.Value.Date)
            End If

            If txtCedula.Text = "Ingrese la cedula" Then
                MsgBox("Debe ingresar una cedula valida", MsgBoxStyle.MsgBoxHelp, "Cedula")
                cedulaCheak = 1
            ElseIf txtCedula.Text = "" Then
                MsgBox("La cedula no puede estar vacia.", MsgBoxStyle.MsgBoxHelp, "Cedula")
                cedulaCheak = 1
            Else
                cmd.Parameters.AddWithValue("@cedula", Me.txtCedula.Text)
            End If

            If cmbTipoUsuario.Text = "Elija una opcion" Then
                MsgBox("Debe ingresar un opcion valida", MsgBoxStyle.MsgBoxHelp, "Puesto")
                tipoUsuarioCheak = 1
            ElseIf cmbTipoUsuario.Text <> "Elija una opcion" Then
                cmd.Parameters.AddWithValue("@tipoEmpleado", idTipoEmple)
            End If

            If cmbFormaPago.Text = "Elija una opcion" Then
                MsgBox("Debe ingresar un opcion valida", MsgBoxStyle.MsgBoxHelp, "Forma de pago")
                formaPagoCheak = 1
            ElseIf cmbFormaPago.Text = "Quincenal" Then
                cmd.Parameters.AddWithValue("@formaPago", 1)
            ElseIf cmbFormaPago.Text = "Semanal" Then
                cmd.Parameters.AddWithValue("@formaPago", 2)
            End If



            If cmbSexo.Text = "Elija una opcion" Then
                MsgBox("Debe ingresar un opcion valida", MsgBoxStyle.MsgBoxHelp, "Genero")
                sexoCheak = 1
            ElseIf cmbSexo.Text = "Masculino" Then
                cmd.Parameters.AddWithValue("@tipoSexo", 1)
            ElseIf cmbSexo.Text = "Femenino" Then
                cmd.Parameters.AddWithValue("@tipoSexo", 2)
            End If

            If nombreCheak = 0 And apellidoCheak = 0 And cedulaCheak = 0 And tipoUsuarioCheak = 0 And sexoCheak = 0 And fechaCheak = 0 And formaPagoCheak = 0 Then
                cmd.Parameters.AddWithValue("@salarioHora", salarioHora)
                cmd.ExecuteNonQuery()
                MsgBox("Empleado creado correctamente", MsgBoxStyle.Information, "Empleado creado")
                CargarDatos()
            Else
                MsgBox("Error: Revise los datos", MsgBoxStyle.Exclamation, "Error")
            End If
            cnn.Close()
            formReset()
            cedulaCheak = 0
            nombreCheak = 0
            apellidoCheak = 0
            tipoUsuarioCheak = 0
            sexoCheak = 0
            fechaCheak = 0
            salarioHora = 0
            salarioMes = 0

        Catch ex As Exception
            MsgBox("No se pudo crear el empleado, favor intentar mas tarde..." + ex.ToString)
        End Try
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Try
            If txtNombre.Text = "Ingrese el nombre" Then
                MsgBox("Debe seleccionar un empleado para modificar.", MsgBoxStyle.MsgBoxHelp, "Seleccione un empleado")
            Else
                If Me.ValidateChildren And txtCedula.Text <> String.Empty Or txtNombre.Text = "Ingrese un usuario" Then
                    If MessageBox.Show("Estas seguro que desea modificar el usuario " & txtNombre.Text & "?", "Favor confirmar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.OK Then
                        Dim ds As New DataSet
                        Dim msqlda As New MySqlDataAdapter
                        Abrir()
                        cmd = New MySqlCommand("Update Empleados set nombre=@NEWnombre,apellido=@NEWapellido,fechaIngreso=@NEWfechaIngreso,fechaSalida=@NEWfechaSalida,tipoSexo=@NEWtipoSexo,tipoEmpleado=@NEWtipoEmpleado,formaPago=@NEWformaPago,salarioHora=@NEWsalarioHora where cedula =" + cedulaEmpleado, cnn)
                        cmd.Parameters.AddWithValue("@NEWnombre", Me.txtNombre.Text)
                        cmd.Parameters.AddWithValue("@NEWapellido", Me.txtApellido.Text)
                        cmd.Parameters.AddWithValue("@NEWsalarioHora", salarioHora)
                        If cmbSexo.Text = "Elija una opcion" Then
                            MsgBox("Error: eligir una opcion", MsgBoxStyle.Exclamation, "Error")
                            sexoCheak = 1
                        ElseIf cmbSexo.Text = "Masculino" Then
                            cmd.Parameters.AddWithValue("@NEWtipoSexo", 1)
                        ElseIf cmbSexo.Text = "Femenino" Then
                            cmd.Parameters.AddWithValue("@NEWtipoSexo", 2)
                        End If
                        If cmbSexo.Text = "Elija una opcion" Then
                            MsgBox("Error: eligir una opcion")
                            tipoUsuarioCheak = 1
                        ElseIf cmbTipoUsuario.Text <> "Elija una opcion" Then
                            cmd.Parameters.AddWithValue("@NEWtipoEmpleado", idTipoEmple)
                        End If
                        If cmbFormaPago.Text = "Elija una opcion" Then
                            MsgBox("Error: eligir una opcion", MsgBoxStyle.Exclamation, "Error")
                            formaPagoCheak = 1
                        ElseIf cmbFormaPago.Text = "Quincenal" Then
                            cmd.Parameters.AddWithValue("@NEWformaPago", 1)
                        ElseIf cmbFormaPago.Text = "Semanal" Then
                            cmd.Parameters.AddWithValue("@NEWformaPago", 2)
                        End If
                        If dtpFechaIngreso.Value = dtpFechaSalida.Value Then
                            MsgBox("La fecha de ingreso y la fecha de salida no pueden ser la misma", MsgBoxStyle.MsgBoxHelp, "Fechas")
                            fechaCheak = 1
                        Else
                            cmd.Parameters.AddWithValue("@NEWfechaIngreso", Me.dtpFechaIngreso.Value.Date)
                            cmd.Parameters.AddWithValue("@NEWfechaSalida", Me.dtpFechaSalida.Value.Date)
                        End If
                        cmd.ExecuteNonQuery()
                        MsgBox("Empleado modificado correctamente", MsgBoxStyle.Information, "Empleado modificado")
                        CargarDatos()
                        formReset()
                        cnn.Close()
                    End If
                Else
                    MessageBox.Show("Debe seleccionar un usuario valido.", "Error")
                    formReset()
                End If
            End If
        Catch ex As Exception
            MsgBox("No se pudo modificar el usuario" + ex.ToString)
        End Try
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim cmd As New MySqlCommand
        Dim cmd1 As New MySqlCommand
        Try
            If txtNombre.Text = "Ingrese el nombre" Then
                MsgBox("Debe seleccionar un empleado", MsgBoxStyle.MsgBoxHelp, "Seleccione un empleado")
            ElseIf txtNombre.Text = "" Then
                MsgBox("El usuario no puede estar en blanco", MsgBoxStyle.MsgBoxHelp, "Campo en blanco")
            Else
                If MessageBox.Show("Estas seguro desea eliminar al empleado " & txtNombre.Text & "?", "Favor confimar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.OK Then
                    Abrir()
                    cmd.Connection = cnn
                    cmd.Parameters.AddWithValue("@cedula", txtCedula.Text)
                    cmd.CommandText = "delete from Empleados where cedula = @cedula"
                    cmd.ExecuteNonQuery()
                    cmd1.Connection = cnn
                    cmd1.Parameters.AddWithValue("@cedula", txtCedula.Text)
                    cmd1.CommandText = "delete from horasempleados where cedula = @cedula"
                    cmd1.ExecuteNonQuery()
                    MsgBox("Los datos han sido eliminados correctamente", MsgBoxStyle.Information, "Datos eliminados")
                    CargarDatos()
                    cnn.Close()
                    formReset()
                End If
            End If
        Catch ex As Exception
            MsgBox("No se pudo eliminar el usuario" + ex.ToString)
        End Try
    End Sub

    Private Sub btnReporte_Click(sender As Object, e As EventArgs) Handles btnReporte.Click
        Dim formReportes As New frmReportesHoras
        formReportes.cedula = txtCedula.Text
        formReportes.reporte = 0
        formReportes.ShowDialog()
    End Sub
End Class