Public Class Usuarios
    '0 = consulta, 1 = agregar, 2 = editar
    Public IntTipoForm As Integer

    Private Sub Usuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PacientesCOVID191DataSet.EstadosUsuario' table. You can move, or remove it, as needed.
        Me.EstadosUsuarioTableAdapter.Fill(Me.PacientesCOVID191DataSet.EstadosUsuario)
        'TODO: This line of code loads data into the 'PacientesCOVID191DataSet.Usuarios' table. You can move, or remove it, as needed.
        Me.UsuariosTableAdapter.Fill(Me.PacientesCOVID191DataSet.Usuarios)

    End Sub

    Private Sub fx_buscar()
        Dim criterio As String = "%" + TextBox_Buscar.Text + "%"
        Me.UsuariosTableAdapter.FillByCriterio(Me.PacientesCOVID191DataSet.Usuarios, criterio, criterio)
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
        TextBox_Usuario.ReadOnly = Not valor
        TextBox_Nombre.ReadOnly = Not valor
        TextBox_Descripcion.ReadOnly = Not valor
        ComboBox_Estado.Enabled = valor
        CheckBox_Administrador.Enabled = valor
        DataGridView_usuarios.Enabled = Not valor
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
            Button_Agregar.Image = My.Resources.add_16
            Button_Editar.Text = "Editar"
            Button_Editar.Image = My.Resources.edit_16
        End If
        fx_activarcontroles(valor)
    End Sub

    Private Function fx_validarcampos() As Boolean
        Dim valor As Boolean = False
        If TextBox_Usuario.Text IsNot Nothing Then
            If TextBox_Nombre.Text IsNot Nothing Then
                If ComboBox_Estado.SelectedIndex >= 0 Then
                    valor = True
                Else
                    MsgBox("Seleccione el estado")
                End If
            Else
                MsgBox("Ingrese el nombre")
            End If
        Else
            MsgBox("Ingrese el usuario")
        End If
        Return valor
    End Function

    Private Sub Button_Agregar_Click(sender As Object, e As EventArgs) Handles Button_Agregar.Click
        If Button_Agregar.Text = "Agregar" Then
            fx_activarbotones(True)
            Me.UsuariosBindingSource.AddNew()
            IntTipoForm = 1
            TextBox_Usuario.Select()
        Else
            fx_activarbotones(False)
            Me.UsuariosBindingSource.CancelEdit()
            IntTipoForm = 0
            TextBox_Buscar.Select()
        End If
    End Sub

    Private idusuario_tmp As Integer
    Private Sub Button_Editar_Click(sender As Object, e As EventArgs) Handles Button_Editar.Click
        If Button_Editar.Text = "Editar" Then
            fx_activarbotones(True)
            IntTipoForm = 2
            idusuario_tmp = TextBox_ID.Text
            TextBox_Usuario.Select()
        Else
            If IntTipoForm = 1 Then
                'INSERT
                If fx_validarcampos() Then
                    Try

                        Me.UsuariosTableAdapter.InsertQuery(TextBox_Usuario.Text, TextBox_Usuario.Text, ComboBox_Estado.SelectedValue, TextBox_Nombre.Text, TextBox_Descripcion.Text, CheckBox_Administrador.Checked)
                        fx_activarbotones(False)
                        IntTipoForm = 0
                        MsgBox("Contraseña asignada: " + TextBox_Usuario.Text)
                        fx_buscar()
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                End If
            ElseIf IntTipoForm = 2 Then
                'UPDATE
                If fx_validarcampos() Then
                    Try
                        Me.UsuariosTableAdapter.UpdateQuery(TextBox_Usuario.Text, ComboBox_Estado.SelectedValue, TextBox_Nombre.Text, TextBox_Descripcion.Text, CheckBox_Administrador.Checked, idusuario_tmp)
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
        If MsgBox("Esta seguro que desea eliminar al usuario: " + TextBox_Usuario.Text + " ?", MsgBoxStyle.YesNoCancel, "Eliminando registro") = DialogResult.Yes Then
            Me.UsuariosTableAdapter.DeleteQuery(TextBox_ID.Text)
            fx_buscar()
        End If
    End Sub

    Private Sub Button_ReiniciarPswd_Click(sender As Object, e As EventArgs) Handles Button_ReiniciarPswd.Click
        If MsgBox("Esta seguro que desea reiniciar la contraseña del usuario: " + TextBox_Usuario.Text + " ?", MsgBoxStyle.YesNoCancel, "Eliminando registro") = DialogResult.Yes Then
            Me.UsuariosTableAdapter.ResetPswd(TextBox_Usuario.Text, TextBox_ID.Text)
            MsgBox("Contraseña nueva: " + TextBox_Usuario.Text)
            fx_buscar()
        End If
    End Sub
End Class