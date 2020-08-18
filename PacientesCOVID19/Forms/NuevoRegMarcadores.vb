Public Class NuevoRegMarcadores
    Private Sub NuevoRegMarcadores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PacientesCOVID191DataSet.MarcadoresInflamatorios' table. You can move, or remove it, as needed.
        Me.MarcadoresInflamatoriosTableAdapter.Fill(Me.PacientesCOVID191DataSet.MarcadoresInflamatorios)
        ''TODO: This line of code loads data into the 'PacientesCOVID191DataSet.Pacientes' table. You can move, or remove it, as needed.
        'Me.PacientesTableAdapter.Fill(Me.PacientesCOVID191DataSet.Pacientes)
        ''TODO: This line of code loads data into the 'PacientesCOVID191DataSet.RegistroMarcadoresInflamatorios' table. You can move, or remove it, as needed.
        'Me.RegistroMarcadoresInflamatoriosTableAdapter.Fill(Me.PacientesCOVID191DataSet.RegistroMarcadoresInflamatorios)
        ''TODO: This line of code loads data into the 'PacientesCOVID191DataSet.DetalleRegistroMarcadores' table. You can move, or remove it, as needed.
        'Me.DetalleRegistroMarcadoresTableAdapter.Fill(Me.PacientesCOVID191DataSet.DetalleRegistroMarcadores)
        fx_buscar()
    End Sub

    Private Sub fx_buscar()
        Me.RegistroMarcadoresInflamatoriosTableAdapter.FillByID(Me.PacientesCOVID191DataSet.RegistroMarcadoresInflamatorios, TextBox_ID_Param.Text)
        Me.PacientesTableAdapter.FillByID(Me.PacientesCOVID191DataSet.Pacientes, TextBox_PacienteID_param.Text)
        Me.DetalleRegistroMarcadoresTableAdapter.FillByRegMarcadores(Me.PacientesCOVID191DataSet.DetalleRegistroMarcadores, TextBox_ID_Param.Text)
        TextBox_PacienteEdad.Text = CalcularEdad(TextBox_PacienteFechaNacimiento_param.Text)

    End Sub


    Public Function CalcularEdad(ByVal Nacimiento As Date) As String
        Dim Edad As String = "0"

        If Nacimiento.Month > Today.Month Then
            Edad = DateDiff(DateInterval.Year, Nacimiento, DateTimePicker_FechaHora_RMI.Value).ToString - 1
        Else
            Edad = DateDiff(DateInterval.Year, Nacimiento, DateTimePicker_FechaHora_RMI.Value).ToString

        End If

        Return Edad
    End Function
    Private Sub Button_Buscar_Click(sender As Object, e As EventArgs) Handles Button_Buscar.Click
        Me.DetalleRegistroMarcadoresBindingSource.EndEdit()
        fx_buscar()
    End Sub

    Private Sub Button_Salvar_Click(sender As Object, e As EventArgs) Handles Button_Salvar.Click
        If MsgBox("¿Está seguro que desea guardar este registro?", MsgBoxStyle.YesNoCancel, "Confirmación") = DialogResult.Yes Then
            Me.Validate()
            Me.DetalleRegistroMarcadoresBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.PacientesCOVID191DataSet)
            Me.RegistroMarcadoresInflamatoriosTableAdapter.UpdateDateTimeQuery(DateTimePicker_FechaHora_RMI.Value, TextBox_ID_Param.Text)
            Me.Close()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub
End Class