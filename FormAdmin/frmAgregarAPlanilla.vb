Imports MySql.Data.MySqlClient
Public Class frmAgregarAPlanilla
    Dim cmd As MySqlCommand
    Public repuesta As MySqlDataReader
    Dim fechaIngreso As Date
    Private Sub frmAgregarAPlanilla_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpInicioPlanilla.Value = Date.Now
        llenarComboBox(cmbPlanillas)
        CargarDatos(cmbPlanillas.Text)
        llenarTextBox(cmbPlanillas.Text)
    End Sub
    Sub consultarDatos(ByVal dgv As DataGridView, ByVal cbtext As String, ByVal text As String)
        Try
            Dim dt As New DataTable
            Abrir()
            Using adaptador As New MySqlDataAdapter("Select Empleados.cedula as 'Cedula', Empleados.nombre as 'Nombre', Empleados.apellido as 'Apellido',tipoEmpleado.nombre as 'Tipo de usuario', generoEmpleado.nombre as 'Sexo',
                                                        Empleados.fechaIngreso as 'Fecha de ingreso', Empleados.fechaSalida as 'Fecha de salida'
                                                        From Empleados inner Join
                                                        tipoEmpleado On Empleados.tipoEmpleado = tipoEmpleado.tipoEmpleado inner Join
                                                        generoEmpleado On Empleados.tipoSexo = generoEmpleado.tipoSexo
                                                        Where Empleados.nombre Not In (Select horasempleados.nombre from horasempleados where horasempleados.idPlanilla = '" & cbtext & "') and empleados.formaPago = 2 and empleados.cedula like '" & "%" & text & "%'", cnn)
                adaptador.Fill(dt)
            End Using
            dgv.DataSource = dt
            cnn.Close()
        Catch ex As Exception
            MsgBox("No se pudo cargar los datos, favor intentar mas tarde..." + ex.ToString)
        End Try
    End Sub
    Sub llenarLabel(ByVal idPlanilla As String)
        Try
            Abrir()
            cmd = New MySqlCommand("SELECT date_format(diaInicio, '%d/%m/%Y') as 'diaInicio', date_format(diaFinal, '%d/%m/%Y') as 'diaFinal' 
                                    FROM planillaSemanal 
                                    WHERE idPlanilla = '" & idPlanilla & "'", cnn)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()
            If reader.Read Then
                lblListaEmpl.Text = "De " & reader("diaInicio").ToString & " al " & reader("diaFinal").ToString
            End If
        Catch ex As Exception
            MsgBox("No se pudo cargar los datos, favor intentar mas tarde..." + ex.ToString)
        End Try
    End Sub
    Sub CargarDatos(ByVal cbtext As String)
        Try
            Dim dt As New DataTable
            Abrir()
            Using adaptador As New MySqlDataAdapter("Select Empleados.cedula as 'Cedula', Empleados.nombre as 'Nombre', Empleados.apellido as 'Apellido',tipoEmpleado.nombre as 'Tipo de usuario', generoEmpleado.nombre as 'Sexo',
                                                        Empleados.fechaIngreso as 'Fecha de ingreso', Empleados.fechaSalida as 'Fecha de salida'
                                                        from Empleados inner join
                                                        tipoEmpleado on Empleados.tipoEmpleado = tipoEmpleado.tipoEmpleado inner join
                                                        generoEmpleado on Empleados.tipoSexo = generoEmpleado.tipoSexo
                                                        where empleados.nombre not in (select horasempleados.nombre from horasempleados where horasempleados.idPlanilla = '" & cbtext & "') and 
                                                        empleados.formaPago = 2", cnn)
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
            cmd = New MySqlCommand("SELECT idPlanilla FROM planillaSemanal ORDER BY idPlanilla", cnn)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()
            While reader.Read
                cb.Items.Add(reader.Item("idPlanilla"))
            End While
        Catch ex As Exception
            MsgBox("No se pudo cargar los datos, favor intentar mas tarde..." + ex.ToString)
        End Try
    End Sub
    Sub llenarTextBox(ByVal idPlanilla As String)
        Try
            Abrir()
            cmd = New MySqlCommand("SELECT date_format(diaInicio, '%d/%m/%Y') as 'diaInicio' 
                                    FROM planillaSemanal 
                                    WHERE idPlanilla = '" & idPlanilla & "'", cnn)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()
            If reader.Read Then
                dtpInicioPlanilla.Value = reader("diaInicio")
            End If
        Catch ex As Exception
            MsgBox("No se pudo cargar los datos, favor intentar mas tarde..." + ex.ToString)
        End Try
    End Sub
    Sub formReset()
        txtNombre.Text = "Nombre"
        txtCedula.Text = "Cedula"
    End Sub

    Private Sub dgvListaEmpleados_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvListaEmpleados.CellContentClick

        Try
            If e.RowIndex >= 0 Then
                Dim row As DataGridViewRow
                row = Me.dgvListaEmpleados.Rows(e.RowIndex)
                txtCedula.Text = row.Cells("Cedula").Value.ToString
                txtNombre.Text = row.Cells("Nombre").Value.ToString
                fechaIngreso = row.Cells("Fecha de ingreso").Value
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim nombreCheak As Integer = 0
        Dim comboCheak As Integer = 0
        Dim cedulaCheak As Integer = 0
        Dim fechaCheak As Integer = 0
        Try
            If txtNombre.Text = "Nombre" Or txtCedula.Text = "Cedula" Or cmbPlanillas.Text = String.Empty Then
                MsgBox("Error: Revise los datos")
            Else
                If Me.ValidateChildren And txtCedula.Text <> String.Empty Or txtNombre.Text = "Nombre" Then
                    If MessageBox.Show("Estas seguro que deseas agregar a " & txtNombre.Text & " a la planilla " & cmbPlanillas.Text & " ?", "Por favor confirmar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.OK Then
                        Abrir()
                        cmd = New MySqlCommand("Insert into horasempleados (idPlanilla,cedula,nombre) values (@idPlanilla,@cedula,@nombre)", cnn)
                        If txtNombre.Text = "Nombre" Then
                            MsgBox("Debe seleccionar un usuario")
                            nombreCheak = 1
                        ElseIf txtNombre.Text <> "Nombre" Then
                            cmd.Parameters.AddWithValue("@nombre", Me.txtNombre.Text)
                        End If
                        If txtCedula.Text = "Cedula" Then
                            MsgBox("Debe seleccionar un usuario")
                            cedulaCheak = 1
                        ElseIf txtCedula.Text <> "Cedula" Then
                            cmd.Parameters.AddWithValue("@cedula", Me.txtCedula.Text)
                        End If
                        If cmbPlanillas.Text = "" Then
                            MsgBox("Debe seleccionar una planilla")
                            comboCheak = 1
                        ElseIf cmbPlanillas.Text <> "" Then
                            cmd.Parameters.AddWithValue("@idPlanilla", Me.cmbPlanillas.Text)
                        End If
                        If dtpInicioPlanilla.Value >= fechaIngreso Then
                            'MsgBox("Si se puede agregar este empleado a esta planilla")
                            fechaCheak = 0
                        ElseIf dtpInicioPlanilla.Value < fechaIngreso Then
                            MsgBox("No se puede agregar este empleado a esta planilla")
                            fechaCheak = 1
                        End If
                        If nombreCheak = 0 And cedulaCheak = 0 And comboCheak = 0 And fechaCheak = 0 Then
                            cmd.ExecuteNonQuery()
                            MsgBox("Usuario agregado")
                            CargarDatos(cmbPlanillas.Text)
                        Else
                            MsgBox("Error: Revise los datos")
                            End If
                            formReset()
                            cnn.Close()
                            comboCheak = 0
                            cedulaCheak = 0
                            nombreCheak = 0
                            fechaCheak = 0
                        End If
                    End If
            End If
        Catch ex As Exception
            MsgBox("No se pudo crear el empleado, favor intentar mas tarde..." + ex.ToString)
        End Try
    End Sub

    Private Sub cmbPlanillas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPlanillas.SelectedIndexChanged
        CargarDatos(cmbPlanillas.Text)
        llenarTextBox(cmbPlanillas.Text)
        llenarLabel(cmbPlanillas.Text)
    End Sub

    Private Sub txtBuscarEmple_TextChanged(sender As Object, e As EventArgs) Handles txtBuscarEmple.TextChanged
        consultarDatos(dgvListaEmpleados, cmbPlanillas.Text, txtBuscarEmple.Text)
    End Sub

    Private Sub btnResetEmpleados_Click(sender As Object, e As EventArgs) Handles btnResetEmpleados.Click
        formReset()
        CargarDatos(cmbPlanillas.Text)
    End Sub
End Class