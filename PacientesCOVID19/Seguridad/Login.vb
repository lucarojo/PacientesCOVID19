Imports System.Data.OleDb

Public Class Login
    Public ingreso = False

    Private Sub Button_Cancelar_Click(sender As Object, e As EventArgs) Handles Button_Cancelar.Click
        Me.Close()
    End Sub

    Private Sub fx_buscar()
        Dim cnx As OleDbConnection = New OleDbConnection(My.Settings.PacientesCOVID191ConnectionString)
        Dim sql As String = "select password, estadousuario, nombre, administrador from usuarios where lcase(usuario) = @usuario"
        Dim cmd As OleDbCommand = New OleDbCommand(sql, cnx)
        cmd.Parameters.AddWithValue("@usuario", Convert.ToString(TextBox_Usuario.Text).ToLower)

        Try
            cnx.Open()
            Dim query As OleDbDataReader = cmd.ExecuteReader
            If query.HasRows Then
                If query.Read Then
                    Dim pwd As String = query.GetString(0)
                    Dim estadousuario As Int32 = query.GetInt32(1)
                    If pwd = TextBox_Contrasena.Text Then
                        If estadousuario = 2 Then
                            ingreso = True
                            Dim nombre As String = query.GetString(2)
                            Dim esadmin As String = query.GetBoolean(3)
                            My.Settings.Usuario = TextBox_Usuario.Text
                            My.Settings.Nombre = nombre
                            My.Settings.EsAdmin = esadmin
                            Me.Close()
                        ElseIf estadousuario = 3 Then
                            'ingreso = True
                            Dim nombre As String = query.GetString(2)
                            Dim esadmin As String = query.GetBoolean(3)
                            My.Settings.Usuario = TextBox_Usuario.Text
                            My.Settings.Nombre = nombre
                            My.Settings.EsAdmin = esadmin
                            Dim resetpass As ResetPassword = New ResetPassword
                            If resetpass.ShowDialog() = DialogResult.OK Then
                                ingreso = True
                                Me.Close()
                            End If
                        Else
                            MsgBox("Usuario inactivo", MsgBoxStyle.Critical, "Advertencia")
                        End If
                    Else
                        MsgBox("Usuario o contraseña incorrecta", MsgBoxStyle.Critical, "Advertencia")
                        TextBox_Contrasena.Select()
                    End If
                End If
            End If
            cnx.Close()
        Catch ex As OleDbException
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button_Aceptar_Click(sender As Object, e As EventArgs) Handles Button_Aceptar.Click
        fx_buscar()
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox_Usuario.Text = ""
        TextBox_Contrasena.Text = ""
        TextBox_Usuario.Select()
        ingreso = False
    End Sub

    Private Sub Login_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If Not ingreso Then
            Application.Exit()
        End If
    End Sub

    Private Sub TextBox_Contrasena_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox_Contrasena.KeyDown
        Select Case e.KeyData
            Case Keys.Enter
                'Aqui mandas a llmar a tu funcion Buscar
                fx_buscar()
        End Select
    End Sub
End Class
