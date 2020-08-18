Imports System.Data.OleDb

Public Class ResetPassword
    Private Sub Button_Cancelar_Click(sender As Object, e As EventArgs) Handles Button_Cancelar.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub ResetPassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox_Usuario.Text = My.Settings.Usuario
    End Sub

    Private Sub Button_Aceptar_Click(sender As Object, e As EventArgs) Handles Button_Aceptar.Click
        Dim cnx As OleDbConnection = New OleDbConnection(My.Settings.PacientesCOVID191ConnectionString)
        Dim sql As String = "select password from usuarios where lcase(usuario) = @usuario"
        Dim cmd As OleDbCommand = New OleDbCommand(sql, cnx)
        cmd.Parameters.AddWithValue("@usuario", Convert.ToString(TextBox_Usuario.Text).ToLower)

        Try
            cnx.Open()
            Dim query As OleDbDataReader = cmd.ExecuteReader
            If query.HasRows Then
                If query.Read Then
                    Dim pwd As String = query.GetString(0)
                    If pwd = TextBox_OldPasswd.Text Then
                        If TextBox_NewPasswd.Text = TextBox_ConfNewPasswd.Text Then
                            Dim sql2 As String = "update [usuarios] set [password] = @password where lcase([usuario]) = @usuario and [password] = @passwordold"
                            Dim xcmd As OleDbCommand = New OleDbCommand(sql2, cnx)
                            xcmd.Parameters.AddWithValue("@password", TextBox_NewPasswd.Text)
                            xcmd.Parameters.AddWithValue("@usuario", TextBox_Usuario.Text.ToLower)
                            xcmd.Parameters.AddWithValue("@passwordold", TextBox_OldPasswd.Text)
                            xcmd.ExecuteScalar()

                            Me.DialogResult = DialogResult.OK
                            Me.Close()
                        Else
                            MsgBox("Las contraseñas deben coincidir")
                        End If
                    Else
                        MsgBox("Usuario o contraseña incorrecta", MsgBoxStyle.Critical, "Advertencia")
                        TextBox_OldPasswd.Select()
                    End If
                End If
            End If
            cnx.Close()
        Catch ex As OleDbException
            MsgBox(ex.Message)
        End Try
    End Sub
End Class