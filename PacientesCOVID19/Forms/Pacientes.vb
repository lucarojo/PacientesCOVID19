Imports System.Data.OleDb

Public Class Pacientes
    '0 = consulta, 1 = agregar, 2 = editar
    Public IntTipoForm As Integer

    Private Sub Pacientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PacientesCOVID191DataSet.Estados' table. You can move, or remove it, as needed.
        Me.EstadosTableAdapter.Fill(Me.PacientesCOVID191DataSet.Estados)
        'TODO: This line of code loads data into the 'PacientesCOVID191DataSet.Sexo' table. You can move, or remove it, as needed.
        Me.SexoTableAdapter.Fill(Me.PacientesCOVID191DataSet.Sexo)
        'TODO: This line of code loads data into the 'PacientesCOVID191DataSet.Pacientes' table. You can move, or remove it, as needed.
        Me.PacientesTableAdapter.Fill(Me.PacientesCOVID191DataSet.Pacientes)

    End Sub

    Private Sub fx_buscar()
        Dim criterio As String = "%" + TextBox_Buscar.Text + "%"
        Me.PacientesTableAdapter.FillByCriterio(Me.PacientesCOVID191DataSet.Pacientes, criterio, criterio)

    End Sub

    Private Sub Button_Buscar_Click(sender As Object, e As EventArgs) Handles Button_Buscar.Click
        fx_buscar()
    End Sub

    Private Sub TextBox_Buscar_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox_Buscar.KeyDown
        Select Case e.KeyData
            Case Keys.Enter
                'Aqui mandas a llmar a tu funcion Buscar
                fx_buscar()
        End Select
    End Sub

    Private Sub fx_activarcontroles(ByVal valor As Boolean)
        TextBox_Nombre.ReadOnly = Not valor
        DateTimePicker_FechaNacimiento.Enabled = valor
        ComboBox_Sexo.Enabled = valor
        TextBox_Identidad.ReadOnly = Not valor
        DateTimePicker_FechaIngreso.Enabled = valor
        ComboBox_Estado.Enabled = valor
        'ComboBox_UltimoEstado.Enabled = valor
        'TextBox_FechaCambioEstado.ReadOnly = Not valor
        'TextBox_Usuario.ReadOnly = Not valor
        DataGridView_Pacientes.Enabled = Not valor
        GroupBox_Buscar.Enabled = Not valor
        Button_Eliminar.Enabled = Not valor
    End Sub

    Private Sub fx_activarbotones(ByVal valor)
        If valor Then
            Button_Agregar.Text = "Deshacer"
            Button_Agregar.Image = My.Resources.deshacer_16
            Button_Editar.Text = "Guardar"
            Button_Editar.Image = My.Resources.salvar_16
        Else
            Button_Agregar.Text = "Agregar"
            Button_Agregar.Image = My.Resources.agregar_paciente_16
            Button_Editar.Text = "Editar"
            Button_Editar.Image = My.Resources.editar_paciente_16
        End If
        fx_activarcontroles(valor)
    End Sub

    Private Function fx_validarcampos() As Boolean
        Dim valor As Boolean = False
        If TextBox_Nombre.Text IsNot Nothing Then
            If ComboBox_Sexo.SelectedIndex >= 0 Then
                If TextBox_Identidad.Text IsNot Nothing Then
                    If ComboBox_Estado.SelectedIndex >= 0 Then
                        valor = True
                    Else
                        MsgBox("Seleccione el estado")
                    End If
                Else
                    MsgBox("Ingrese el numero de identidad del paciente")
                End If
            Else
                MsgBox("Seleccione el sexo del paciente")
            End If
        Else
            MsgBox("Ingrese el nombre del paciente")
        End If
        Return valor
    End Function

    Private Sub Button_Agregar_Click(sender As Object, e As EventArgs) Handles Button_Agregar.Click
        If Button_Agregar.Text = "Agregar" Then
            fx_activarbotones(True)
            Me.PacientesBindingSource.AddNew()
            IntTipoForm = 1
            TextBox_Usuario.Select()
            ComboBox_Estado.SelectedIndex = ComboBox_Estado.FindStringExact("UCI")
        Else
            fx_activarbotones(False)
            Me.PacientesBindingSource.CancelEdit()
            IntTipoForm = 0
            TextBox_Buscar.Select()
        End If
    End Sub

    Dim idpaciente_tmp As Integer
    Dim idestadopaciente_tmp As Integer
    Private Sub Button_Editar_Click(sender As Object, e As EventArgs) Handles Button_Editar.Click
        If Button_Editar.Text = "Editar" Then
            fx_activarbotones(True)
            IntTipoForm = 2
            idpaciente_tmp = TextBox_ID.Text
            idestadopaciente_tmp = ComboBox_Estado.SelectedValue
            TextBox_Usuario.Select()
        Else
            If IntTipoForm = 1 Then
                'INSERT
                If fx_validarcampos() Then
                    Try

                        Me.PacientesTableAdapter.InsertQuery(TextBox_Nombre.Text, DateTimePicker_FechaNacimiento.Value, ComboBox_Sexo.SelectedValue, TextBox_Identidad.Text, DateTimePicker_FechaIngreso.Value, ComboBox_Estado.SelectedValue, My.Settings.Usuario)
                        fx_activarbotones(False)
                        IntTipoForm = 0
                        fx_buscar()
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                End If
            ElseIf IntTipoForm = 2 Then
                'UPDATE
                If fx_validarcampos() Then
                    Try
                        Me.PacientesTableAdapter.UpdateQuery(TextBox_Nombre.Text, DateTimePicker_FechaNacimiento.Value, ComboBox_Sexo.SelectedValue, TextBox_Identidad.Text, DateTimePicker_FechaIngreso.Value, ComboBox_Estado.SelectedValue, idestadopaciente_tmp, DateTime.Today, My.Settings.Usuario, idpaciente_tmp)
                        fx_activarbotones(False)
                        IntTipoForm = 0
                        fx_buscar()
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                End If
            End If
        End If
    End Sub

    Private Sub Button_Eliminar_Click(sender As Object, e As EventArgs) Handles Button_Eliminar.Click
        If MsgBox("¿Está seguro que desea eliminar al paciente: " + TextBox_Nombre.Text + " ?", MsgBoxStyle.YesNoCancel, "Eliminando registro") = DialogResult.Yes Then
            Me.PacientesTableAdapter.DeleteQuery(TextBox_ID.Text)
            fx_buscar()
        End If
    End Sub

    Public Function CalcularEdad(ByVal Nacimiento As Date) As String
        Dim Edad As String = "0"

        If Nacimiento.Month > Today.Month Then
            Edad = DateDiff(DateInterval.Year, Nacimiento, Date.Today).ToString - 1
        Else
            Edad = DateDiff(DateInterval.Year, Nacimiento, Date.Today).ToString

        End If

        Return Edad
    End Function

    Private Sub DateTimePicker_FechaNacimiento_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker_FechaNacimiento.ValueChanged
        Edadtxt.Text = CalcularEdad(DateTimePicker_FechaNacimiento.Value)
    End Sub

    Private Sub TextBox_ID_TextChanged(sender As Object, e As EventArgs) Handles TextBox_ID.TextChanged
        If TextBox_ID IsNot Nothing Then
            Button_Agregar_MI.Enabled = True
        Else
            Button_Agregar_MI.Enabled = False
        End If
    End Sub

    Private Sub Button_Agregar_MI_Click(sender As Object, e As EventArgs) Handles Button_Agregar_MI.Click
        'Using form As New RegMarcadores
        '    form.ShowDialog()

        'End Using
        If MsgBox("Creando registro de marcadores inflamatorios para" + vbNewLine + "Paciente: " + TextBox_Nombre.Text + vbNewLine + "Fecha y hora: " + Now, MsgBoxStyle.OkCancel, "Creando registro") <> DialogResult.OK Then
            Exit Sub
        End If

        Dim cnx As OleDbConnection = New OleDbConnection(My.Settings.PacientesCOVID191ConnectionString)
        Dim sql As String = "INSERT INTO [RegistroMarcadoresInflamatorios] ([FechaHora], [Paciente], [Usuario]) VALUES (Now(), @paciente, @usuario)"
        Dim cmd As OleDbCommand = New OleDbCommand(sql, cnx)
        cmd.Parameters.AddWithValue("@paciente", Integer.Parse(TextBox_ID.Text))
        cmd.Parameters.AddWithValue("@usuario", My.Settings.Usuario)
        Dim cmd1 As OleDbCommand = New OleDbCommand(sql, cnx)

        Try
            cnx.Open()
            Dim query As String = "INSERT INTO DetalleRegistroMarcadores (RegistroMarcadores, MarcadorInflamatorio) SELECT @ID_RMI, [ID] FROM MarcadoresInflamatorios"

            cmd.ExecuteNonQuery()
            cmd.CommandText = "SELECT @@Identity"
            Dim ID_RMI As Integer = cmd.ExecuteScalar()
            cmd1.CommandText = query
            cmd1.Parameters.AddWithValue("@ID_RMI", ID_RMI)
            cmd1.ExecuteNonQuery()

            Using formulario As NuevoRegMarcadores = New NuevoRegMarcadores
                formulario.TextBox_ID_Param.Text = ID_RMI
                formulario.ShowDialog()
            End Using

            cnx.Close()
        Catch ex As OleDbException
            MsgBox(ex.Message)
        End Try
    End Sub
End Class