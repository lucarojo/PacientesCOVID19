<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Principal
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Principal))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.InicioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerrarFormulariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CambiarContrasenaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerrarSesionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirAltF4ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdministradorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SexosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EstadosDeAltaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EstadosDeUsuarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PacientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MarcadoresInflamatoriosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.Left
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InicioToolStripMenuItem, Me.AdministradorToolStripMenuItem, Me.PacientesToolStripMenuItem, Me.ConsultasToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(6, 0, 0, 0)
        Me.MenuStrip1.Size = New System.Drawing.Size(126, 450)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'InicioToolStripMenuItem
        '
        Me.InicioToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CerrarFormulariosToolStripMenuItem, Me.CambiarContrasenaToolStripMenuItem, Me.CerrarSesionToolStripMenuItem, Me.SalirAltF4ToolStripMenuItem})
        Me.InicioToolStripMenuItem.Image = Global.PacientesCOVID19.My.Resources.Resources.house_16
        Me.InicioToolStripMenuItem.Name = "InicioToolStripMenuItem"
        Me.InicioToolStripMenuItem.Padding = New System.Windows.Forms.Padding(2, 20, 2, 20)
        Me.InicioToolStripMenuItem.Size = New System.Drawing.Size(113, 60)
        Me.InicioToolStripMenuItem.Text = "Inicio"
        '
        'CerrarFormulariosToolStripMenuItem
        '
        Me.CerrarFormulariosToolStripMenuItem.Name = "CerrarFormulariosToolStripMenuItem"
        Me.CerrarFormulariosToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.CerrarFormulariosToolStripMenuItem.Text = "Cerrar Formularios"
        '
        'CambiarContrasenaToolStripMenuItem
        '
        Me.CambiarContrasenaToolStripMenuItem.Name = "CambiarContrasenaToolStripMenuItem"
        Me.CambiarContrasenaToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.CambiarContrasenaToolStripMenuItem.Text = "Cambiar Contrasena"
        '
        'CerrarSesionToolStripMenuItem
        '
        Me.CerrarSesionToolStripMenuItem.Name = "CerrarSesionToolStripMenuItem"
        Me.CerrarSesionToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.CerrarSesionToolStripMenuItem.Text = "Cerrar Sesion"
        '
        'SalirAltF4ToolStripMenuItem
        '
        Me.SalirAltF4ToolStripMenuItem.Name = "SalirAltF4ToolStripMenuItem"
        Me.SalirAltF4ToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.SalirAltF4ToolStripMenuItem.Text = "Salir (Alt+F4)"
        '
        'AdministradorToolStripMenuItem
        '
        Me.AdministradorToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MarcadoresInflamatoriosToolStripMenuItem, Me.SexosToolStripMenuItem, Me.EstadosDeAltaToolStripMenuItem, Me.EstadosDeUsuarioToolStripMenuItem, Me.UsuariosToolStripMenuItem})
        Me.AdministradorToolStripMenuItem.Image = Global.PacientesCOVID19.My.Resources.Resources.cog_16
        Me.AdministradorToolStripMenuItem.Name = "AdministradorToolStripMenuItem"
        Me.AdministradorToolStripMenuItem.Padding = New System.Windows.Forms.Padding(4, 20, 4, 20)
        Me.AdministradorToolStripMenuItem.Size = New System.Drawing.Size(113, 60)
        Me.AdministradorToolStripMenuItem.Text = "Administrador"
        '
        'SexosToolStripMenuItem
        '
        Me.SexosToolStripMenuItem.Name = "SexosToolStripMenuItem"
        Me.SexosToolStripMenuItem.Size = New System.Drawing.Size(209, 22)
        Me.SexosToolStripMenuItem.Text = "Sexos"
        '
        'EstadosDeAltaToolStripMenuItem
        '
        Me.EstadosDeAltaToolStripMenuItem.Name = "EstadosDeAltaToolStripMenuItem"
        Me.EstadosDeAltaToolStripMenuItem.Size = New System.Drawing.Size(209, 22)
        Me.EstadosDeAltaToolStripMenuItem.Text = "Estados del Paciente"
        '
        'EstadosDeUsuarioToolStripMenuItem
        '
        Me.EstadosDeUsuarioToolStripMenuItem.Name = "EstadosDeUsuarioToolStripMenuItem"
        Me.EstadosDeUsuarioToolStripMenuItem.Size = New System.Drawing.Size(209, 22)
        Me.EstadosDeUsuarioToolStripMenuItem.Text = "Estados del Usuario"
        '
        'UsuariosToolStripMenuItem
        '
        Me.UsuariosToolStripMenuItem.Name = "UsuariosToolStripMenuItem"
        Me.UsuariosToolStripMenuItem.Size = New System.Drawing.Size(209, 22)
        Me.UsuariosToolStripMenuItem.Text = "Usuarios"
        '
        'PacientesToolStripMenuItem
        '
        Me.PacientesToolStripMenuItem.Image = Global.PacientesCOVID19.My.Resources.Resources.user_16
        Me.PacientesToolStripMenuItem.Name = "PacientesToolStripMenuItem"
        Me.PacientesToolStripMenuItem.Padding = New System.Windows.Forms.Padding(4, 20, 4, 20)
        Me.PacientesToolStripMenuItem.Size = New System.Drawing.Size(113, 60)
        Me.PacientesToolStripMenuItem.Text = "Pacientes"
        '
        'ConsultasToolStripMenuItem
        '
        Me.ConsultasToolStripMenuItem.Image = Global.PacientesCOVID19.My.Resources.Resources.chart_16
        Me.ConsultasToolStripMenuItem.Name = "ConsultasToolStripMenuItem"
        Me.ConsultasToolStripMenuItem.Padding = New System.Windows.Forms.Padding(4, 20, 4, 20)
        Me.ConsultasToolStripMenuItem.Size = New System.Drawing.Size(113, 60)
        Me.ConsultasToolStripMenuItem.Text = "Reportes"
        '
        'MarcadoresInflamatoriosToolStripMenuItem
        '
        Me.MarcadoresInflamatoriosToolStripMenuItem.Name = "MarcadoresInflamatoriosToolStripMenuItem"
        Me.MarcadoresInflamatoriosToolStripMenuItem.Size = New System.Drawing.Size(209, 22)
        Me.MarcadoresInflamatoriosToolStripMenuItem.Text = "Marcadores Inflamatorios"
        '
        'Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Principal"
        Me.Text = "Control de Marcadores Inflamatorios"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents InicioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CerrarFormulariosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CambiarContrasenaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CerrarSesionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirAltF4ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PacientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AdministradorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SexosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EstadosDeAltaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EstadosDeUsuarioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UsuariosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MarcadoresInflamatoriosToolStripMenuItem As ToolStripMenuItem
End Class
