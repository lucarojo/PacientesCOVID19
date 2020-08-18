Public Class Principal
    Private Sub Principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        My.Settings.Item("PacientesCOVID191ConnectionString") = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\PacientesCOVID191.accdb;Persist Security Info=False;"
        Login.ShowDialog()
        Me.Text = "Pacientes COVID19 - " + My.Settings.Nombre
        If My.Settings.EsAdmin Then
            AdministradorToolStripMenuItem.Visible = True
        Else
            AdministradorToolStripMenuItem.Visible = False
        End If
    End Sub

    Private Sub SalirAltF4ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirAltF4ToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub CerrarSesionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarSesionToolStripMenuItem.Click
        fx_cerrarformularios()
        Login.ShowDialog()
        Me.Text = "Pacientes COVID19 - " + My.Settings.Nombre
    End Sub

    Private Sub fx_cerrarformularios()
        For Each f As Form In Me.MdiChildren
            f.Close()
        Next
    End Sub

    Private Sub CerrarFormulariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarFormulariosToolStripMenuItem.Click
        fx_cerrarformularios()
    End Sub

    Private Sub CambiarContrasenaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CambiarContrasenaToolStripMenuItem.Click
        Dim resetpswd As ResetPassword = New ResetPassword
        resetpswd.ShowDialog()
    End Sub

    Private Sub UsuariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UsuariosToolStripMenuItem.Click
        For Each f As Form In Me.MdiChildren
            If f.Name = "Usuarios" Then
                f.Select()
                Exit Sub
            End If
        Next
        Dim form As Usuarios = New Usuarios
        form.MdiParent = Me
        form.Show()
    End Sub

    Private Sub EstadosDeUsuarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EstadosDeUsuarioToolStripMenuItem.Click
        For Each f As Form In Me.MdiChildren
            If f.Name = "EstadosUsuario" Then
                f.Select()
                Exit Sub
            End If
        Next
        Dim form As EstadosUsuario = New EstadosUsuario
        form.MdiParent = Me
        form.Show()
    End Sub

    Private Sub EstadosDeAltaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EstadosDeAltaToolStripMenuItem.Click
        For Each f As Form In Me.MdiChildren
            If f.Name = "EstadosAlta" Then
                f.Select()
                Exit Sub
            End If
        Next
        Dim form As EstadosAlta = New EstadosAlta
        form.MdiParent = Me
        form.Show()
    End Sub

    Private Sub SexosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SexosToolStripMenuItem.Click
        For Each f As Form In Me.MdiChildren
            If f.Name = "Sexos" Then
                f.Select()
                Exit Sub
            End If
        Next
        Dim form As Sexos = New Sexos
        form.MdiParent = Me
        form.Show()
    End Sub

    Private Sub PacientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PacientesToolStripMenuItem.Click
        For Each f As Form In Me.MdiChildren
            If f.Name = "Pacientes" Then
                f.Select()
                Exit Sub
            End If
        Next
        Dim form As Pacientes = New Pacientes
        form.MdiParent = Me
        form.Show()
    End Sub

    Private Sub ConsultasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultasToolStripMenuItem.Click
        For Each f As Form In Me.MdiChildren
            If f.Name = "Reporte" Then
                f.Select()
                Exit Sub
            End If
        Next
        Dim form As Reporte = New Reporte
        form.MdiParent = Me
        form.Show()
    End Sub

    Private Sub MarcadoresInflamatoriosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MarcadoresInflamatoriosToolStripMenuItem.Click
        For Each f As Form In Me.MdiChildren
            If f.Name = "MarcadoresInflamatorios" Then
                f.Select()
                Exit Sub
            End If
        Next
        Dim form As MarcadoresInflamatorios = New MarcadoresInflamatorios
        form.MdiParent = Me
        form.Show()
    End Sub
End Class
