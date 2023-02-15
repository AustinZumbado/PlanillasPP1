Imports MySql.Data.MySqlClient

Public Class frmCrearPuesto
    Dim cmd As MySqlCommand
    Dim id As Integer
    Private Sub frmCrearPuesto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarDatos()
        dgvListaPuestos.AllowUserToAddRows = False
    End Sub

    Sub CargarDatos()
        Try
            Dim dt As New DataTable
            Abrir()
            Using adaptador As New MySqlDataAdapter("SELECT tipoEmpleado.tipoEmpleado as 'ID',tipoEmpleado.nombre as 'Nombre', format(tipoEmpleado.salariomensual, 2) as 'Salario mensual' 
                                                        FROM proyectoplanillaspp1.tipoempleado ORDER BY salarioMensual desc", cnn)
                adaptador.Fill(dt)
            End Using
            dgvListaPuestos.DataSource = dt
            dgvListaPuestos.Columns("ID").Visible = False
            cnn.Close()
        Catch ex As Exception
            MsgBox("No se pudo cargar los datos, favor intentar mas tarde..." + ex.ToString)
        End Try
    End Sub
    Sub consultarPuesto(ByVal txtPuesto As String, ByVal dgv As DataGridView)
        Try
            Dim dt As New DataTable
            Abrir()
            Using adaptador As New MySqlDataAdapter("SELECT tipoEmpleado.tipoEmpleado as 'ID',tipoEmpleado.nombre as 'Nombre', format(tipoEmpleado.salariomensual, 2) as 'Salario mensual' 
                                                        FROM proyectoplanillaspp1.tipoempleado
                                                        where tipoEmpleado.nombre like '" & "%" & txtPuesto & "%'", cnn)
                adaptador.Fill(dt)
            End Using
            dgv.DataSource = dt
            cnn.Close()
        Catch ex As Exception
            MsgBox("No se puede encontrar este puesto, por favor intente con otro..." + ex.ToString, MsgBoxStyle.Exclamation, "Error MYSQL")
        End Try
    End Sub

    Sub formReset()
        txtNombre.Text = String.Empty
        txtSalarioMes.Text = String.Empty
    End Sub

    Private Sub dgvListaPuestos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvListaPuestos.CellContentClick
        Try
            If e.RowIndex >= 0 Then
                Dim row As DataGridViewRow
                row = Me.dgvListaPuestos.Rows(e.RowIndex)
                txtNombre.Text = row.Cells("Nombre").Value.ToString
                txtSalarioMes.Text = row.Cells("Salario mensual").Value.ToString
                id = row.Cells("ID").Value.ToString
            End If
        Catch ex As Exception
            MsgBox("No se pudo seleccionar el puesto" + ex.ToString, MsgBoxStyle.Critical, "Error mysql")
        End Try
    End Sub

    Private Sub btnCrear_Click(sender As Object, e As EventArgs) Handles btnCrear.Click
        Dim nombreCheak As Integer = 0
        Dim puestoCheak As Integer = 0
        Try
            Abrir()
            cmd = New MySqlCommand("insert into tipoEmpleado (nombre,salarioMensual) values (@nombre,@salarioMensual)", cnn)
            If txtNombre.Text = String.Empty Then
                MsgBox("Ingrese el nombre de puesto", MsgBoxStyle.Exclamation, "Error de nombre")
                nombreCheak = 1
            ElseIf txtNombre.Text <> String.Empty Then
                cmd.Parameters.AddWithValue("@nombre", txtNombre.Text)
                nombreCheak = 0
            End If
            If txtSalarioMes.Text = String.Empty Then
                MsgBox("Ingrese el salario mensual del puesto", MsgBoxStyle.Exclamation, "Error de puesto")
                puestoCheak = 1
            ElseIf txtSalarioMes.Text <> String.Empty Then
                cmd.Parameters.AddWithValue("@salarioMensual", txtSalarioMes.Text)
                puestoCheak = 0
            End If
            If nombreCheak = 0 And puestoCheak = 0 Then
                cmd.ExecuteNonQuery()
                MsgBox("Puesto creado correctamente", MsgBoxStyle.Information, "Puesto creado")
                CargarDatos()
                formReset()
            Else
                MsgBox("Error: revise los datos.", MsgBoxStyle.Exclamation, "Error")
            End If
        Catch ex As Exception
            MsgBox("No se pudo crear el puesto, favor intentar mas tarde..." + ex.ToString, MsgBoxStyle.Exclamation, "Error MYSQL")
        End Try
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Try
            If txtNombre.Text = String.Empty Then
                MsgBox("Debe seleccionar un puesto", MsgBoxStyle.Exclamation, "Error de seleccion")
            Else
                If Me.ValidateChildren And txtNombre.Text <> String.Empty Or txtSalarioMes.Text <> String.Empty Then
                    If MessageBox.Show("¿Esta seguro que deseas modificar el puesto " & txtNombre.Text & "?", "Modificar puesto.", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) = DialogResult.OK Then
                        Abrir()
                        cmd = New MySqlCommand("Update tipoEmpleado set nombre=@NEWnombre, salarioMensual=@NEWsalarioMensual where tipoEmpleado = '" & id & "'", cnn)
                        cmd.Parameters.AddWithValue("@NEWnombre", Me.txtNombre.Text)
                        cmd.Parameters.AddWithValue("@NEWsalarioMensual", Me.txtSalarioMes.Text)
                        cmd.ExecuteNonQuery()
                        MsgBox("Puesto modificado correctamente", MsgBoxStyle.Information, "Modificado correctamente")
                        cnn.Close()
                        CargarDatos()
                        formReset()
                    End If
                Else
                    MsgBox("Debe seleccionar un puesto valido.", MsgBoxStyle.Exclamation, "Error")
                End If
            End If
        Catch ex As Exception
            MsgBox("No se pudo modificar el puesto " + ex.ToString, MsgBoxStyle.Critical, "Error MYSQL")
        End Try
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim cmd As New MySqlCommand
        Try
            If txtNombre.Text = String.Empty Then
                MsgBox("Debe seleccionar un puesto.", MsgBoxStyle.Exclamation, "Error de seleccion")
            Else
                If MessageBox.Show("¿Estas seguro que desea eliminar el puesto " & txtNombre.Text & "?", "Eliminar puesto", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) = DialogResult.OK Then
                    Abrir()
                    cmd.Connection = cnn
                    cmd.Parameters.AddWithValue("@tipoEmpleado", id)
                    If (id = 5) Then
                        MsgBox("Error este puesto no se puede eliminar", MsgBoxStyle.Exclamation, "Error")
                    ElseIf (id <> 5) Then
                        cmd.CommandText = "delete from tipoEmpleado where tipoEmpleado = @tipoEmpleado;
                                        Update empleados set tipoEmpleado= '5' where tipoEmpleado = @tipoEmpleado"
                        cmd.ExecuteNonQuery()
                        MsgBox("Los datos han sido eliminados correctamente", MsgBoxStyle.Information, "Puesto eliminado")
                        CargarDatos()
                        formReset()
                        cnn.Close()
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox("No se pudo eliminar el puesto " + ex.ToString, MsgBoxStyle.Exclamation, "Error MYSQL")
        End Try
    End Sub

    Private Sub txtBuscarEmple_TextChanged(sender As Object, e As EventArgs) Handles txtBuscarEmple.TextChanged
        consultarPuesto(txtBuscarEmple.Text, dgvListaPuestos)
    End Sub

    Private Sub btnResetEmpleados_Click(sender As Object, e As EventArgs) Handles btnResetEmpleados.Click
        CargarDatos()
    End Sub
End Class