
Imports MySql.Data.MySqlClient
Imports Microsoft.VisualBasic.ApplicationServices

Public Class frmPlanillas
    Dim cmd As MySqlCommand
    Public repuesta As MySqlDataReader
    Dim idPlanilla As String = ""
    Dim nombreCheak As Integer = 0
    Dim fechaCheak As Integer = 0
    Sub consultarNombreSemanal(ByVal nombre As String, ByVal dgv As DataGridView)
        Try
            Dim dt As New DataTable
            Abrir()
            Using adaptador As New MySqlDataAdapter("SELECT planillaSemanal.idPlanilla as 'ID', planillaSemanal.nombre AS 'Nombre',
                                                        planillaSemanal.diaInicio AS 'Dia inicial', planillaSemanal.diaFinal AS 'Dia final', week(diaInicio) as 'Semana'
                                                        FROM planillaSemanal
                                                        where planillaSemanal.nombre like '" & "%" + nombre + "%" & "'", cnn)
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
            Using adaptador As New MySqlDataAdapter("SELECT planillaSemanal.idPlanilla as 'ID', planillaSemanal.nombre AS 'Nombre',
                                                        planillaSemanal.diaInicio AS 'Dia inicial', planillaSemanal.diaFinal AS 'Dia final', week(diaInicio) as 'Semana'
                                                        FROM planillaSemanal", cnn)
                adaptador.Fill(dt)
            End Using
            dgvListaEmpleados.DataSource = dt
            cnn.Close()
        Catch ex As Exception
            MsgBox("No se pudo cargar los datos, favor intentar mas tarde..." + ex.ToString)
        End Try
    End Sub
    Private Sub formReset()
        txtNombre.Text = "Ingrese el nombre"
        txtNombreQuin.Text = "Ingrese el nombre"
        dtpFechaInicio.Value = "01/01/2023"
        dtpFechaFinal.Value = "01/01/2023"
        dtpFechaInicialQuin.Value = "01/01/2023"
        dtpFechaFinalQuin.Value = "01/01/2023"
        nombreCheak = 0
        fechaCheak = 0
        cnn.Close()
    End Sub
    Private Sub frmPlanillas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarDatos()
        dtpFechaFinal.Enabled = False
        dtpFechaFinalQuin.Enabled = False
        cargarQuincenales()
    End Sub
    Private Sub dgvListaEmpleados_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvListaEmpleados.CellContentClick
        Try
            If tbcContenedor.SelectedIndex = 0 Then
                If e.RowIndex >= 0 Then
                    Dim row As DataGridViewRow
                    row = Me.dgvListaEmpleados.Rows(e.RowIndex)
                    txtNombre.Text = row.Cells("Nombre").Value.ToString
                    dtpFechaInicio.Value = row.Cells("Dia inicial").Value.ToString
                    dtpFechaFinal.Value = row.Cells("Dia final").Value.ToString
                    idPlanilla = row.Cells(0).Value.ToString
                End If
            End If
        Catch ex As Exception
            MsgBox("No se pudo seleccionar el usuario" + ex.ToString)
        End Try
    End Sub
    Private Sub dtpFechaInicio_ValueChanged(sender As Object, e As EventArgs) Handles dtpFechaInicio.ValueChanged
        idPlanilla = (Year(dtpFechaInicio.Value) & DatePart("ww", dtpFechaInicio.Value))
        dtpFechaFinal.Value = dtpFechaInicio.Value.AddDays(7)
    End Sub
    Private Sub txtBuscarEmple_TextChanged(sender As Object, e As EventArgs) Handles txtBuscarEmple.TextChanged
        consultarNombreSemanal(txtBuscarEmple.Text, dgvListaEmpleados)
    End Sub
    Sub consultarNombreQuincena(ByVal nombre As String, ByVal dgv As DataGridView)
        Try
            Dim dt As New DataTable
            Abrir()
            Using adaptador As New MySqlDataAdapter("SELECT planillaQuincenal.id as 'ID', planillaQuincenal.nombre AS 'Nombre',
                                                        planillaQuincenal.diaInicial AS 'Dia inicial', planillaQuincenal.diaFinal AS 'Dia final', DATEDIFF(diaFinal, diaInicial) as 'Diferencia entre dias'
                                                        FROM planillaQuincenal
                                                        where planillaQuincenal.nombre like '" & "%" + nombre + "%" & "'", cnn)
                adaptador.Fill(dt)
            End Using
            dgv.DataSource = dt
            cnn.Close()
        Catch ex As Exception
            MsgBox("No se pudo cargar los datos, favor intentar mas tarde..." + ex.ToString)
        End Try
    End Sub
    Sub cargarQuincenales()
        Try
            Dim dt As New DataTable
            Abrir()
            Using adaptador As New MySqlDataAdapter("SELECT planillaQuincenal.id as 'ID', planillaQuincenal.nombre AS 'Nombre',
                                                        planillaQuincenal.diaInicial AS 'Dia inicial', planillaQuincenal.diaFinal AS 'Dia final', DATEDIFF(diaFinal, diaInicial) as 'Diferencia entre dias'
                                                        FROM planillaQuincenal", cnn)
                adaptador.Fill(dt)
            End Using
            dgvPlanillaQuincenal.DataSource = dt
            dgvPlanillaQuincenal.Columns("ID").Visible = False
            cnn.Close()
        Catch ex As Exception
            MsgBox("No se pudo cargar los datos, favor intentar mas tarde..." + ex.ToString)
        End Try
    End Sub
    Private Sub dgvPlanillaQuincenal_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPlanillaQuincenal.CellContentClick
        Try
            If tbcContenedor.SelectedIndex = 1 Then
                If e.RowIndex >= 0 Then
                    Dim row As DataGridViewRow
                    row = Me.dgvPlanillaQuincenal.Rows(e.RowIndex)
                    txtNombreQuin.Text = row.Cells("Nombre").Value.ToString
                    dtpFechaInicialQuin.Value = row.Cells("Dia inicial").Value.ToString
                    dtpFechaFinalQuin.Value = row.Cells("Dia final").Value.ToString
                    idPlanilla = row.Cells(0).Value.ToString
                End If
            End If
        Catch ex As Exception
            MsgBox("No se pudo seleccionar el usuario" + ex.ToString)
        End Try
    End Sub
    Private Sub dtpFechaInicialQuin_ValueChanged(sender As Object, e As EventArgs) Handles dtpFechaInicialQuin.ValueChanged
        dtpFechaFinalQuin.Value = dtpFechaInicialQuin.Value.AddDays(15)
    End Sub

    Private Sub txtBuscarQuincenal_TextChanged(sender As Object, e As EventArgs) Handles txtBuscarQuincenal.TextChanged
        consultarNombreQuincena(txtBuscarQuincenal.Text, dgvPlanillaQuincenal)
    End Sub

    Private Sub btnCrear_Click(sender As Object, e As EventArgs) Handles btnCrear.Click
        Try
            If tbcContenedor.SelectedIndex = 0 Then
                Abrir()
                cmd = New MySqlCommand("INSERT INTO planillaSemanal (idPlanilla,nombre,diaInicio,diaFinal) values (@idPlanilla,@nombre,@diaInicio,@diaFinal)", cnn)
                cmd.Parameters.AddWithValue("@idPlanilla", idPlanilla)
                If txtNombre.Text = "Ingrese el nombre" Then
                    MsgBox("Debe ingreser un nombre de empleado valido", MsgBoxStyle.MsgBoxHelp, "Nombre")
                    nombreCheak = 1
                ElseIf txtNombre.Text = "" Then
                    MsgBox("La opcion nombre no puede estar vacia", MsgBoxStyle.MsgBoxHelp, "Nombre")
                    nombreCheak = 1
                Else
                    cmd.Parameters.AddWithValue("@nombre", Me.txtNombre.Text)
                End If

                If dtpFechaInicio.Value = dtpFechaFinal.Value Then
                    MsgBox("Cambie la fecha por favor", MsgBoxStyle.MsgBoxHelp, "Fecha")
                    fechaCheak = 1
                Else
                    cmd.Parameters.AddWithValue("@diaInicio", Me.dtpFechaInicio.Value.Date)
                    cmd.Parameters.AddWithValue("@diaFinal", Me.dtpFechaFinal.Value.Date)
                End If

                If nombreCheak = 0 And fechaCheak = 0 Then
                    cmd.ExecuteNonQuery()
                    MsgBox("Planilla creada correctamente", MsgBoxStyle.Information, "Planilla creada")
                    CargarDatos()
                Else
                    MsgBox("Error: Revise los datos", MsgBoxStyle.Exclamation, "Revise la planilla")
                End If
                cnn.Close()
                nombreCheak = 0
                fechaCheak = 0
                formReset()
            End If
            If tbcContenedor.SelectedIndex = 1 Then
                Abrir()
                cmd = New MySqlCommand("INSERT INTO planillaQuincenal (nombre,diaInicial,diaFinal) values (@nombre,@diaInicial,@diaFinal)", cnn)
                If txtNombreQuin.Text = "Ingrese el nombre" Then
                    MsgBox("Debe ingreser un nombre de empleado valido", MsgBoxStyle.MsgBoxHelp, "Nombre")
                    nombreCheak = 1
                ElseIf txtNombreQuin.Text = "" Then
                    MsgBox("La opcion nombre no puede estar vacia", MsgBoxStyle.MsgBoxHelp, "Nombre")
                    nombreCheak = 1
                Else
                    cmd.Parameters.AddWithValue("@nombre", Me.txtNombreQuin.Text)
                End If

                If dtpFechaInicialQuin.Value = dtpFechaFinalQuin.Value Then
                    MsgBox("Cambie la fecha por favor", MsgBoxStyle.MsgBoxHelp, "Fechas")
                    fechaCheak = 1
                Else
                    cmd.Parameters.AddWithValue("@diaInicial", Me.dtpFechaInicialQuin.Value.Date)
                    cmd.Parameters.AddWithValue("@diaFinal", Me.dtpFechaFinalQuin.Value.Date)
                End If

                If nombreCheak = 0 And fechaCheak = 0 Then
                    cmd.ExecuteNonQuery()
                    MsgBox("Planilla creada correctamente", MsgBoxStyle.Information, "Planilla creada")
                    cargarQuincenales()
                Else
                    MsgBox("Error: Revise los datos", MsgBoxStyle.Exclamation, "Revise la planilla")
                End If
                cnn.Close()
                nombreCheak = 0
                fechaCheak = 0
                formReset()
            End If

        Catch ex As Exception
            MsgBox("No se pudo crear el empleado, favor intentar mas tarde..." + ex.ToString)
        End Try
    End Sub
    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Try
            If tbcContenedor.SelectedIndex = 0 Then
                If txtNombre.Text = "Ingrese el nombre" Then
                    MsgBox("Debe seleccionar un empleado para modificar", MsgBoxStyle.MsgBoxHelp, "Nombre")
                Else
                    If Me.ValidateChildren And txtNombre.Text <> String.Empty Or txtNombre.Text = "Ingrese el nombre" Then
                        If MessageBox.Show("Estas seguro que desea modificar el usuario " & txtNombre.Text & "?", "Por favor confirmar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.OK Then
                            Dim ds As New DataSet
                            Dim msqlda As New MySqlDataAdapter
                            Abrir()
                            cmd = New MySqlCommand("Update planillaSemanal set nombre=@NEWnombre,diaInicio=@NEWdiaInicio,diaFinal=@NEWdiaFinal where idPlanilla like " + idPlanilla, cnn)
                            cmd.Parameters.AddWithValue("@NEWnombre", Me.txtNombre.Text)
                            cmd.Parameters.AddWithValue("@NEWdiaInicio", Me.dtpFechaInicio.Value.Date)
                            cmd.Parameters.AddWithValue("@NEWdiaFinal", Me.dtpFechaFinal.Value.Date)
                        End If
                        cmd.ExecuteNonQuery()
                        MsgBox("Planilla modificada correctamente", MsgBoxStyle.Information, "Planilla modificada")
                        CargarDatos()
                        formReset()
                        cnn.Close()
                    End If
                End If
            ElseIf tbcContenedor.SelectedIndex = 1 Then
                If txtNombreQuin.Text = "Ingrese el nombre" Then
                    MsgBox("Debe seleccionar un empleado para modificar", MsgBoxStyle.MsgBoxHelp, "Error")
                Else
                    If Me.ValidateChildren And txtNombreQuin.Text <> String.Empty Or txtNombre.Text = "Ingrese el nombre" Then
                        If MessageBox.Show("Estas seguro que deseas modificar la planilla " & txtNombreQuin.Text & "?", "Por favor confirmar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.OK Then
                            Dim ds As New DataSet
                            Dim msqlda As New MySqlDataAdapter
                            Abrir()
                            cmd = New MySqlCommand("Update planillaQuincenal set nombre=@NEWnombre, diaInicial=@NEWdiaInicial, diaFinal=@NEWdiaFinal where idPlanilla=" + idPlanilla, cnn)
                            cmd.Parameters.AddWithValue("@NEWnombre", Me.txtNombreQuin.Text)
                            cmd.Parameters.AddWithValue("@NEWdiaInicial", Me.dtpFechaInicialQuin.Value.Date)
                            cmd.Parameters.AddWithValue("@NEWdiaFinal", Me.dtpFechaFinalQuin.Value.Date)
                        End If
                        cmd.ExecuteNonQuery()
                        MsgBox("Planilla modificada correctamente", MsgBoxStyle.MsgBoxHelp, "Planilla modifica")
                        cargarQuincenales()
                        formReset()
                        cnn.Close()
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox("No se pudo modificar la planilla" + ex.ToString)
        End Try
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim cmd As New MySqlCommand
        Try
            If tbcContenedor.SelectedIndex = 0 Then
                If txtNombre.Text = "Ingrese el nombre" Then
                    MsgBox("Debe seleccionar un planilla", MsgBoxStyle.MsgBoxHelp, "Selecciona una planilla")
                ElseIf txtNombre.Text = "" Then
                    MsgBox("La planilla no puede estar vacia", MsgBoxStyle.MsgBoxHelp, "Planilla vacia")
                Else
                    If MessageBox.Show("Estas seguro que deseas eliminar la planilla " & txtNombre.Text & "?", "Por favor confirmar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.OK Then
                        Abrir()
                        cmd.Connection = cnn
                        cmd.Parameters.AddWithValue("@id", idPlanilla)
                        cmd.CommandText = "Delete from planillaSemanal where idPlanilla = @id"
                        cmd.ExecuteNonQuery()
                        MsgBox("La planilla se ha eliminado correctamente.", MsgBoxStyle.Information, "Planilla eliminada")
                        CargarDatos()
                        formReset()
                        cnn.Close()
                    End If
                End If
            ElseIf tbcContenedor.SelectedIndex = 1 Then
                If txtNombreQuin.Text = "Ingrese el nombre" Then
                    MsgBox("Debe seleccionar una planilla", MsgBoxStyle.MsgBoxHelp, "Selecciona una planilla")
                ElseIf txtNombre.Text = "" Then
                    MsgBox("La planilla no puede estar vacia", MsgBoxStyle.MsgBoxHelp, "Planilla vacia")
                Else
                    If MessageBox.Show("Estas seguro que deseas eliminar la planilla " & txtNombreQuin.Text & "?", "Por favor confirmar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.OK Then
                        Abrir()
                        cmd.Connection = cnn
                        cmd.Parameters.AddWithValue("@id", idPlanilla)
                        cmd.CommandText = "Delete from planillaQuincenal where idPlanilla = @id"
                        cmd.ExecuteNonQuery()
                        MsgBox("La planilla se ha eliminado correctamente.", MsgBoxStyle.Information, "Planilla eliminada")
                        cargarQuincenales()
                        formReset()
                        cnn.Close()
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox("No se pudo eliminar la planilla" + ex.ToString)
        End Try
    End Sub
End Class