Public Class Form_TMP
    Private Sub DetalleRegistroMarcadoresBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles DetalleRegistroMarcadoresBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.DetalleRegistroMarcadoresBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.PacientesCOVID191DataSet)

    End Sub

    Private Sub Form_TMP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PacientesCOVID191DataSet.DetalleRegistroMarcadores' table. You can move, or remove it, as needed.
        Me.DetalleRegistroMarcadoresTableAdapter.Fill(Me.PacientesCOVID191DataSet.DetalleRegistroMarcadores)

    End Sub
End Class