Public Class RepMarcadoresInflamatorios
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PacientesCOVID191DataSet2.DetalleRegistroMarcadores' table. You can move, or remove it, as needed.
        Me.DetalleRegistroMarcadoresTableAdapter1.Fill(Me.PacientesCOVID191DataSet2.DetalleRegistroMarcadores)
        'TODO: This line of code loads data into the 'PacientesCOVID191DataSet.DetalleRegistroMarcadores' table. You can move, or remove it, as needed.
        Me.DetalleRegistroMarcadoresTableAdapter.Fill(Me.PacientesCOVID191DataSet.DetalleRegistroMarcadores)
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class