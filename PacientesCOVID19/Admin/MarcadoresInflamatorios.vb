﻿Public Class MarcadoresInflamatorios
    '0 = consulta, 1 = agregar, 2 = editar
    Public IntTipoForm As Integer

    Private Sub MarcadoresInflamatorios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PacientesCOVID191DataSet.MarcadoresInflamatorios' table. You can move, or remove it, as needed.
        Me.MarcadoresInflamatoriosTableAdapter.Fill(Me.PacientesCOVID191DataSet.MarcadoresInflamatorios)

    End Sub

    Private Sub fx_buscar()
        Me.MarcadoresInflamatoriosTableAdapter.Fill(Me.PacientesCOVID191DataSet.MarcadoresInflamatorios)
    End Sub

    Private Sub fx_activarcontroles(ByVal valor As Boolean)
        'TextBox_ID.ReadOnly = Not valor
        TextBox_MI.ReadOnly = Not valor
        TextBox_ValMin.ReadOnly = Not valor
        TextBox_ValMax.ReadOnly = Not valor
        TextBox_Unidad.ReadOnly = Not valor
        DataGridView_MI.Enabled = Not valor
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
        If TextBox_MI.Text IsNot Nothing Then
            valor = True
        Else
            MsgBox("Ingrese el sexo")
        End If
        Return valor
    End Function

    Private Sub Button_Agregar_Click(sender As Object, e As EventArgs) Handles Button_Agregar.Click
        If Button_Agregar.Text = "Agregar" Then
            fx_activarbotones(True)
            Me.MarcadoresInflamatoriosBindingSource.AddNew()
            IntTipoForm = 1
            TextBox_MI.Select()
        Else
            fx_activarbotones(False)
            Me.MarcadoresInflamatoriosBindingSource.CancelEdit()
            IntTipoForm = 0
        End If
    End Sub

    Dim idmi_tmp As Integer
    Private Sub Button_Editar_Click(sender As Object, e As EventArgs) Handles Button_Editar.Click
        If Button_Editar.Text = "Editar" Then
            fx_activarbotones(True)
            IntTipoForm = 2
            idmi_tmp = TextBox_ID.Text
            TextBox_MI.Select()
        Else
            If IntTipoForm = 1 Then
                'INSERT
                If fx_validarcampos() Then
                    Try
                        Me.MarcadoresInflamatoriosTableAdapter.InsertQuery(TextBox_MI.Text, TextBox_ValMin.Text, TextBox_ValMax.Text, TextBox_Unidad.Text)
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
                        Me.MarcadoresInflamatoriosTableAdapter.UpdateQuery(TextBox_MI.Text, TextBox_ValMin.Text, TextBox_ValMax.Text, TextBox_Unidad.Text, idmi_tmp)
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
        If MsgBox("Esta seguro que desea eliminar al registro: " + TextBox_MI.Text + " ?", MsgBoxStyle.YesNoCancel, "Eliminando registro") = DialogResult.Yes Then
            Me.MarcadoresInflamatoriosTableAdapter.DeleteQuery(TextBox_ID.Text)
            fx_buscar()
        End If
    End Sub
End Class