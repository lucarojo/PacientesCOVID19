Public Class LogMarcadoresInflamatorios
    '0 = consulta, 1 = agregar, 2 = editar
    Public IntTipoForm As Integer

    '    Private Sub LogMarcadoresInflamatorios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    '        'TODO: This line of code loads data into the 'PacientesCOVID191DataSet1.Pacientes' table. You can move, or remove it, as needed.
    '        Me.PacientesTableAdapter.Fill(Me.PacientesCOVID191DataSet1.Pacientes)
    '        'TODO: This line of code loads data into the 'PacientesCOVID191DataSet.Pacientes' table. You can move, or remove it, as needed.
    '        Me.PacientesTableAdapter.Fill(Me.PacientesCOVID191DataSet.Pacientes)
    '        'TODO: This line of code loads data into the 'PacientesCOVID191DataSet.RegistroMarcadoresInflamatorios' table. You can move, or remove it, as needed.
    '        'Me.RegistroMarcadoresInflamatoriosTableAdapter.Fill(Me.PacientesCOVID191DataSet.RegistroMarcadoresInflamatorios)
    '        fx_buscar()

    '    End Sub

    '    Private Sub fx_buscar()
    '        Me.RegistroMarcadoresInflamatoriosTableAdapter.FillByPaciente(Me.PacientesCOVID191DataSet.RegistroMarcadoresInflamatorios, TextBox_PacienteID_param.Text)
    '    End Sub

    '    Private Sub Button_Buscar_Click(sender As Object, e As EventArgs) Handles Button_Buscar.Click
    '        fx_buscar()
    '    End Sub

    '    Private Sub fx_activarcontroles(ByVal valor As Boolean)
    '        'TextBox_ID.ReadOnly = Not valor
    '        DateTimePicker_FechaHora.Enabled = valor
    '        'ComboBox_Paciente.Enabled = valor
    '        TextBox_ProteinaCReactiva.ReadOnly = Not valor
    '        TextBox_ProteinaCReactivaUltra.ReadOnly = Not valor
    '        TextBox_LDH.ReadOnly = Not valor
    '        TextBox_Ferritina.ReadOnly = Not valor
    '        TextBox_TGO.ReadOnly = Not valor
    '        TextBox_TGP.ReadOnly = Not valor
    '        TextBox_DimeroD.ReadOnly = Not valor
    '        'TextBox_Usuario.ReadOnly = Not valor
    '        DataGridView_MI.Enabled = Not valor
    '        Button_Buscar.Enabled = Not valor
    '        Button_Eliminar.Enabled = Not valor
    '    End Sub

    '    Private Sub fx_activarbotones(ByVal valor)
    '        If valor Then
    '            Button_Agregar.Text = "Deshacer"
    '            Button_Agregar.Image = My.Resources.deshacer_16
    '            Button_Editar.Text = "Guardar"
    '            Button_Editar.Image = My.Resources.salvar_16
    '        Else
    '            Button_Agregar.Text = "Agregar"
    '            Button_Agregar.Image = My.Resources.add_16
    '            Button_Editar.Text = "Editar"
    '            Button_Editar.Image = My.Resources.edit_16
    '        End If
    '        fx_activarcontroles(valor)
    '    End Sub

    '    Private Function fx_validarcampos() As Boolean
    '        Dim valor As Boolean = False
    '        If TextBox_ProteinaCReactiva.Text IsNot Nothing Then
    '            If TextBox_ProteinaCReactivaUltra.Text IsNot Nothing Then
    '                If TextBox_LDH.Text IsNot Nothing Then
    '                    If TextBox_Ferritina.Text IsNot Nothing Then
    '                        If TextBox_TGO.Text IsNot Nothing Then
    '                            If TextBox_TGP.Text IsNot Nothing Then
    '                                If TextBox_DimeroD.Text IsNot Nothing Then
    '                                    valor = True
    '                                Else
    '                                    MsgBox("Ingrese el Dimero D del paciente")
    '                                End If
    '                            Else
    '                                MsgBox("Ingrese el TGP del paciente")
    '                            End If
    '                        Else
    '                            MsgBox("Ingrese el TGO del paciente")
    '                        End If
    '                    Else
    '                        MsgBox("Ingrese la Ferritina del paciente")
    '                    End If
    '                Else
    '                    MsgBox("Ingrese el LDH del paciente")
    '                End If
    '            Else
    '                MsgBox("Ingrese la Proteina C Reactiva Ultrasensible del paciente")
    '            End If
    '        Else
    '            MsgBox("Ingrese la Proteina C Reactiva del paciente")
    '        End If
    '        Return valor
    '    End Function

    '    Private Sub Button_Agregar_Click(sender As Object, e As EventArgs) Handles Button_Agregar.Click
    '        If Button_Agregar.Text = "Agregar" Then
    '            fx_activarbotones(True)
    '            Me.RegistroMarcadoresInflamatoriosBindingSource.AddNew()
    '            IntTipoForm = 1
    '            TextBox_ProteinaCReactiva.Select()
    '            ComboBox_Paciente.SelectedValue = TextBox_PacienteID_param.Text
    '        Else
    '            fx_activarbotones(False)
    '            Me.RegistroMarcadoresInflamatoriosBindingSource.CancelEdit()
    '            IntTipoForm = 0
    '        End If
    '    End Sub

    '    Dim idmi_tmp As String
    '    Private Sub Button_Editar_Click(sender As Object, e As EventArgs) Handles Button_Editar.Click
    '        If Button_Editar.Text = "Editar" Then
    '            fx_activarbotones(True)
    '            IntTipoForm = 2
    '            idmi_tmp = TextBox_ID.Text
    '            TextBox_ProteinaCReactiva.Select()
    '        Else
    '            If IntTipoForm = 1 Then
    '                'INSERT
    '                If fx_validarcampos() Then
    '                    Try

    '                        Me.RegistroMarcadoresInflamatoriosTableAdapter.InsertQuery(DateTimePicker_FechaHora.Value, ComboBox_Paciente.SelectedValue, TextBox_ProteinaCReactiva.Text, TextBox_ProteinaCReactivaUltra.Text, TextBox_LDH.Text, TextBox_Ferritina.Text, TextBox_TGO.Text, TextBox_TGP.Text, TextBox_DimeroD.Text, My.Settings.Usuario)
    '                        fx_activarbotones(False)
    '                        IntTipoForm = 0
    '                        fx_buscar()
    '                    Catch ex As Exception
    '                        MsgBox(ex.Message)
    '                    End Try
    '                End If
    '            ElseIf IntTipoForm = 2 Then
    '                'UPDATE
    '                If fx_validarcampos() Then
    '                    Try
    '                        Me.RegistroMarcadoresInflamatoriosTableAdapter.UpdateQuery(DateTimePicker_FechaHora.Value, ComboBox_Paciente.SelectedValue, TextBox_ProteinaCReactiva.Text, TextBox_ProteinaCReactivaUltra.Text, TextBox_LDH.Text, TextBox_Ferritina.Text, TextBox_TGO.Text, TextBox_TGP.Text, TextBox_DimeroD.Text, My.Settings.Usuario, idmi_tmp)
    '                        fx_activarbotones(False)
    '                        IntTipoForm = 0
    '                        fx_buscar()
    '                    Catch ex As Exception
    '                        MsgBox(ex.Message)
    '                    End Try
    '                End If
    '            End If
    '        End If
    '    End Sub

    '    Private Sub Button_Eliminar_Click(sender As Object, e As EventArgs) Handles Button_Eliminar.Click
    '        If MsgBox("¿Está seguro que desea eliminar al registro No.: " + TextBox_ID.Text + " ?", MsgBoxStyle.YesNoCancel, "Eliminando registro") = DialogResult.Yes Then
    '            Me.RegistroMarcadoresInflamatoriosTableAdapter.DeleteQuery(TextBox_ID.Text)
    '            fx_buscar()
    '        End If
    '    End Sub

    '#Region "Masked TextBox"
    '    Private Sub TextBox_ProteinaCReactiva_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox_ProteinaCReactiva.KeyPress
    '        'option 1
    '        'If (Not Char.IsControl(e.KeyChar) _
    '        '             AndAlso (Not Char.IsDigit(e.KeyChar) _
    '        '             AndAlso (e.KeyChar <> Microsoft.VisualBasic.ChrW(46)))) Then
    '        '    e.Handled = True
    '        'End If
    '        'option 2
    '        'If Asc(e.KeyChar) <> 8 Then
    '        '    If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
    '        '        e.Handled = True
    '        '    End If
    '        'End If
    '        'option 3
    '        Dim numbers As Windows.Forms.TextBox = sender
    '        If InStr("1234567890.-+ ", e.KeyChar) = 0 And (e.KeyChar <> Microsoft.VisualBasic.ChrW(46)) And Asc(e.KeyChar) <> 8 Or (e.KeyChar = "." And InStr(numbers.Text, ".") > 0) Then
    '            e.KeyChar = Chr(0)
    '            e.Handled = True
    '        End If
    '    End Sub

    '    Private Sub TextBox_ProteinaCReactiva_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox_ProteinaCReactiva.KeyDown
    '        ' If Char.IsDigit(Chr(e.KeyValue)) Or
    '        'Chr(e.KeyValue) = "¾"c Or
    '        'e.KeyData = Keys.Delete Or
    '        'e.KeyData = Keys.Back Then

    '        '     If Chr(e.KeyValue) = "¾"c Then
    '        '         If TextBox_ProteinaCReactiva.Text.Contains(".") Then
    '        '             e.SuppressKeyPress = True
    '        '         Else
    '        '             e.SuppressKeyPress = False
    '        '         End If
    '        '     End If
    '        ' ElseIf e.KeyData = Keys.Enter Then

    '        ' ElseIf e.KeyData = Keys.Tab Then

    '        ' Else
    '        '     e.SuppressKeyPress = True
    '        ' End If
    '    End Sub

    '    Private Sub TextBox_ProteinaCReactivaUltra_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox_ProteinaCReactivaUltra.KeyPress
    '        Dim numbers As Windows.Forms.TextBox = sender
    '        If InStr("1234567890.-+ ", e.KeyChar) = 0 And (e.KeyChar <> Microsoft.VisualBasic.ChrW(46)) And Asc(e.KeyChar) <> 8 Or (e.KeyChar = "." And InStr(numbers.Text, ".") > 0) Then
    '            e.KeyChar = Chr(0)
    '            e.Handled = True
    '        End If
    '    End Sub

    '    Private Sub TextBox_LDH_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox_LDH.KeyPress
    '        Dim numbers As Windows.Forms.TextBox = sender
    '        If InStr("1234567890.-+ ", e.KeyChar) = 0 And (e.KeyChar <> Microsoft.VisualBasic.ChrW(46)) And Asc(e.KeyChar) <> 8 Or (e.KeyChar = "." And InStr(numbers.Text, ".") > 0) Then
    '            e.KeyChar = Chr(0)
    '            e.Handled = True
    '        End If
    '    End Sub

    '    Private Sub TextBox_Ferritina_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox_Ferritina.KeyPress
    '        Dim numbers As Windows.Forms.TextBox = sender
    '        If InStr("1234567890.-+ ", e.KeyChar) = 0 And (e.KeyChar <> Microsoft.VisualBasic.ChrW(46)) And Asc(e.KeyChar) <> 8 Or (e.KeyChar = "." And InStr(numbers.Text, ".") > 0) Then
    '            e.KeyChar = Chr(0)
    '            e.Handled = True
    '        End If
    '    End Sub

    '    Private Sub TextBox_TGO_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox_TGO.KeyPress
    '        Dim numbers As Windows.Forms.TextBox = sender
    '        If InStr("1234567890.-+ ", e.KeyChar) = 0 And (e.KeyChar <> Microsoft.VisualBasic.ChrW(46)) And Asc(e.KeyChar) <> 8 Or (e.KeyChar = "." And InStr(numbers.Text, ".") > 0) Then
    '            e.KeyChar = Chr(0)
    '            e.Handled = True
    '        End If
    '    End Sub

    '    Private Sub TextBox_TGP_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox_TGP.KeyPress
    '        Dim numbers As Windows.Forms.TextBox = sender
    '        If InStr("1234567890.-+ ", e.KeyChar) = 0 And (e.KeyChar <> Microsoft.VisualBasic.ChrW(46)) And Asc(e.KeyChar) <> 8 Or (e.KeyChar = "." And InStr(numbers.Text, ".") > 0) Then
    '            e.KeyChar = Chr(0)
    '            e.Handled = True
    '        End If
    '    End Sub

    '    Private Sub TextBox_DimeroD_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox_DimeroD.KeyPress
    '        Dim numbers As Windows.Forms.TextBox = sender
    '        If InStr("1234567890.-+ ", e.KeyChar) = 0 And (e.KeyChar <> Microsoft.VisualBasic.ChrW(46)) And Asc(e.KeyChar) <> 8 Or (e.KeyChar = "." And InStr(numbers.Text, ".") > 0) Then
    '            e.KeyChar = Chr(0)
    '            e.Handled = True
    '        End If
    '    End Sub
    '#End Region
End Class