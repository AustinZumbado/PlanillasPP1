Imports MySql.Data.MySqlClient
Public Class frmReducciones
    Dim cmd As MySqlCommand
    Private Sub frmReducciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenarComboBox(cmbPlanillaSemana)
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

    Sub llenarDateGriew(ByVal dgv As DataGridView, ByVal cbText As String)
        Try
            Dim dt As New DataTable
            Abrir()
            Using adaptador As New MySqlDataAdapter("select horasempleados.idHorasEmple as 'ID', empleados.cedula as 'Cedula', empleados.nombre as 'Nombre', format(empleados.salarioHora, 2) as 'Salario por hora',
                                                        format((salarioHora*horasNormales)+((empleados.salarioHora*horasMedias)*1.5)+((empleados.salarioHora*horasDobles)*2), 2) as 'Salario' ,
                                                        format(((salarioHora*horasNormales)+((empleados.salarioHora*horasMedias)*1.5)+(empleados.salarioHora*horasDobles)*2)*0.005,2) as 'Seguro social',
                                                        format(((salarioHora*horasNormales)+((empleados.salarioHora*horasMedias)*1.5)+(empleados.salarioHora*horasDobles)*2)*0.0035,2) as 'Pension'
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
    Sub consultarDateGriew(ByVal dgv As DataGridView, ByVal cedula As String, ByVal cbText As String)
        Try
            Dim dt As New DataTable
            Abrir()
            Using adaptador As New MySqlDataAdapter("select horasempleados.idHorasEmple as 'ID', empleados.cedula as 'Cedula', empleados.nombre as 'Nombre', format(empleados.salarioHora, 2) as 'Salario por hora',
                                                        format((salarioHora*horasNormales)+((empleados.salarioHora*horasMedias)*1.5)+((empleados.salarioHora*horasDobles)*2), 2) as 'Salario' ,
                                                        format(((salarioHora*horasNormales)+((empleados.salarioHora*horasMedias)*1.5)+(empleados.salarioHora*horasDobles)*2)*0.005,2) as 'Seguro social',
                                                        format(((salarioHora*horasNormales)+((empleados.salarioHora*horasMedias)*1.5)+(empleados.salarioHora*horasDobles)*2)*0.0035,2) as 'Pension'
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

    Private Sub cmbPlanillaSemana_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPlanillaSemana.SelectedIndexChanged
        llenarDateGriew(dgvListaSalarios, cmbPlanillaSemana.Text)
        llenarLabel(cmbPlanillaSemana.Text)
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        consultarDateGriew(dgvListaSalarios, txtBuscar.Text, cmbPlanillaSemana.Text)
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        llenarDateGriew(dgvListaSalarios, cmbPlanillaSemana.Text)
    End Sub
End Class