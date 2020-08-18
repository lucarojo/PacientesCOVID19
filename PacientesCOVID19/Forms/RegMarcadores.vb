Public Class RegMarcadores
    Private Sub RegMarcadores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PacientesCOVID191DataSet2.MarcadoresInflamatorios' table. You can move, or remove it, as needed.
        Me.MarcadoresInflamatoriosTableAdapter.Fill(Me.PacientesCOVID191DataSet2.MarcadoresInflamatorios)
        'TODO: This line of code loads data into the 'PacientesCOVID191DataSet1.RegMarcadoresPaciente' table. You can move, or remove it, as needed.
        Me.RegMarcadoresPacienteTableAdapter.Fill(Me.PacientesCOVID191DataSet1.RegMarcadoresPaciente)
        'TODO: This line of code loads data into the 'PacientesCOVID191DataSet.Pacientes' table. You can move, or remove it, as needed.
        Me.PacientesTableAdapter.Fill(Me.PacientesCOVID191DataSet.Pacientes)
        'TODO: This line of code loads data into the 'PacientesCOVID191DataSet.RegistroMarcadoresInflamatorios' table. You can move, or remove it, as needed.
        Me.RegistroMarcadoresInflamatoriosTableAdapter.FillByID(Me.PacientesCOVID191DataSet.RegistroMarcadoresInflamatorios, TextBox_ID_Param.Text)
        'TODO: This line of code loads data into the 'PacientesCOVID191DataSet.DetalleRegistroMarcadores' table. You can move, or remove it, as needed.
        Me.DetalleRegistroMarcadoresTableAdapter.FillByRegMarcadores(Me.PacientesCOVID191DataSet.DetalleRegistroMarcadores, TextBox_ID_Param.Text)

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub RegistroMarcadoresInflamatoriosDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub DetalleRegistroMarcadoresDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DetalleRegistroMarcadoresDataGridView.CellContentClick

    End Sub

    Private Sub FillByToolStripButton_Click(sender As Object, e As EventArgs)
        Try
            Me.RegMarcadoresPacienteTableAdapter.FillBy(Me.PacientesCOVID191DataSet1.RegMarcadoresPaciente)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub FechaHoraLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub FechaHoraDateTimePicker_ValueChanged(sender As Object, e As EventArgs) Handles FechaHoraDateTimePicker.ValueChanged

    End Sub
End Class