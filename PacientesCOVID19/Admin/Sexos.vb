Public Class Sexos
    '0 = consulta, 1 = agregar, 2 = editar
    Public IntTipoForm As Integer

    Private Sub Sexos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PacientesCOVID191DataSet.Sexo' table. You can move, or remove it, as needed.
        Me.SexoTableAdapter.Fill(Me.PacientesCOVID191DataSet.Sexo)
    End Sub

    Private Sub fx_buscar()
        Me.SexoTableAdapter.Fill(Me.PacientesCOVID191DataSet.Sexo)
    End Sub

    Private Sub fx_activarcontroles(ByVal valor As Boolean)
        TextBox_Sexo.ReadOnly = Not valor
        DataGridView_Sexos.Enabled = Not valor
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
            Button_Agregar.Image = My.Resources.add_16
            Button_Editar.Text = "Editar"
            Button_Editar.Image = My.Resources.edit_16
        End If
        fx_activarcontroles(valor)
    End Sub

    Private Function fx_validarcampos() As Boolean
        Dim valor As Boolean = False
        If TextBox_Sexo.Text IsNot Nothing Then
            valor = True
        Else
            MsgBox("Ingrese el sexo")
        End If
        Return valor
    End Function

    Private Sub Button_Agregar_Click(sender As Object, e As EventArgs) Handles Button_Agregar.Click
        If Button_Agregar.Text = "Agregar" Then
            fx_activarbotones(True)
            Me.SexoBindingSource.AddNew()
            IntTipoForm = 1
            TextBox_Sexo.Select()
        Else
            fx_activarbotones(False)
            Me.SexoBindingSource.CancelEdit()
            IntTipoForm = 0
        End If
    End Sub

    Dim idsexo_tmp As Integer
    Private Sub Button_Editar_Click(sender As Object, e As EventArgs) Handles Button_Editar.Click
        If Button_Editar.Text = "Editar" Then
            fx_activarbotones(True)
            IntTipoForm = 2
            idsexo_tmp = TextBox_ID.Text
            TextBox_Sexo.Select()
        Else
            If IntTipoForm = 1 Then
                'INSERT
                If fx_validarcampos() Then
                    Try
                        Me.SexoTableAdapter.InsertQuery(TextBox_Sexo.Text)
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
                        Me.SexoTableAdapter.UpdateQuery(TextBox_Sexo.Text, idsexo_tmp)
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
        If MsgBox("Esta seguro que desea eliminar al registro: " + TextBox_Sexo.Text + " ?", MsgBoxStyle.YesNoCancel, "Eliminando registro") = DialogResult.Yes Then
            Me.SexoTableAdapter.DeleteQuery(TextBox_ID.Text)
            fx_buscar()
        End If
    End Sub
End Class