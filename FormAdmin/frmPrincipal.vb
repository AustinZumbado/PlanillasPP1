Imports MySql.Data.MySqlClient

Public Class frmPrincipal
    Private Sub frmPrincipal_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            CargarEmpleados()
            CargarSalarios()
            cnn.Close()
        Catch ex As Exception
            MsgBox("No se pudo cargar los usuarios, favor intentar mas tarde..." + ex.ToString)
        End Try
    End Sub
    Sub EsconderDataGridView()
        dgvListaEmpleados.Hide()
    End Sub
    Sub CargarEmpleados()
        Try
            Dim dt As New DataTable
            Abrir()
            Using adaptador As New MySqlDataAdapter("select Empleados.cedula as 'Cedula', Empleados.nombre as 'Nombre', Empleados.apellido as 'Apellido', tipoEmpleado.nombre as 'Tipo de usuario',
                                                        formaPago.nombre as 'Forma de pago', Empleados.fechaIngreso as 'Fecha de ingreso', Empleados.fechaSalida as 'Fecha de salida'
                                                        from Empleados inner join
                                                        tipoEmpleado on Empleados.tipoEmpleado = tipoEmpleado.tipoEmpleado inner join
                                                        formaPago on Empleados.formaPago = formaPago.formaPago", cnn)
                adaptador.Fill(dt)
            End Using
            dgvListaEmpleados.DataSource = dt
            cnn.Close()
        Catch ex As Exception
            MsgBox("No se pudo cargar los datos, favor intentar mas tarde..." + ex.ToString)
        End Try
    End Sub

    Sub CargarSalarios()
        Try
            Dim dt As New DataTable
            Abrir()
            Using adaptador As New MySqlDataAdapter("select Empleados.cedula as 'Cedula', Empleados.nombre as 'Nombre', tipoEmpleado.nombre as 'Tipo de usuario', formaPago.nombre as 'Forma de pago',
                                                    tipoEmpleado.salarioMensual as 'Salario Mensual', Empleados.salarioHora as 'Salario hora'
                                                    from Empleados inner join
                                                    tipoEmpleado on Empleados.tipoEmpleado = tipoEmpleado.tipoEmpleado inner join
                                                    formaPago on Empleados.formaPago = formaPago.formaPago", cnn)
                adaptador.Fill(dt)
            End Using
            dgvListaSalarios.DataSource = dt
            cnn.Close()
        Catch ex As Exception
            MsgBox("No se pudo cargar los datos, favor intentar mas tarde..." + ex.ToString)
        End Try
    End Sub

    Sub consultarNombreSalarios(ByVal cedula As String, ByVal dgv As DataGridView)
        Try
            Dim dt As New DataTable
            Abrir()
            Using adaptador As New MySqlDataAdapter("select Empleados.cedula as 'Cedula', Empleados.nombre as 'Nombre', tipoEmpleado.nombre as 'Tipo de usuario', formaPago.nombre as 'Forma de pago',
                                                    tipoEmpleado.salarioMensual as 'Salario Mensual', Empleados.salarioHora as 'Salario hora'
                                                    from Empleados inner join
                                                    tipoEmpleado on Empleados.tipoEmpleado = tipoEmpleado.tipoEmpleado inner join
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

    Sub consultarNombreEmpleados(ByVal cedula As String, ByVal dgv As DataGridView)
        Try
            Dim dt As New DataTable
            Abrir()
            Using adaptador As New MySqlDataAdapter("select Empleados.cedula as 'Cedula', Empleados.nombre as 'Nombre', Empleados.apellido as 'Apellido',tipoEmpleado.nombre as 'Tipo de usuario',
                                                     formaPago.nombre as 'Forma de pago', Empleados.fechaIngreso as 'Fecha de ingreso', Empleados.fechaSalida as 'Fecha de salida'
                                                    from Empleados inner join
                                                    tipoEmpleado on Empleados.tipoEmpleado = tipoEmpleado.tipoEmpleado inner join
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
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnResetEmpleados.Click
        CargarEmpleados()
    End Sub

    Private Sub txtBuscarEmple_TextChanged(sender As Object, e As EventArgs) Handles txtBuscarEmple.TextChanged
        consultarNombreEmpleados(txtBuscarEmple.Text, dgvListaEmpleados)
    End Sub

    Private Sub txtBuscarSalario_TextChanged(sender As Object, e As EventArgs) Handles txtBuscarSalario.TextChanged
        consultarNombreSalarios(txtBuscarSalario.Text, dgvListaSalarios)
    End Sub

    Private Sub btnResetSalario_Click(sender As Object, e As EventArgs) Handles btnResetSalario.Click
        CargarSalarios()
    End Sub
End Class