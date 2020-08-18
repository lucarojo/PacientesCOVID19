<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Usuarios
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Usuarios))
        Me.GroupBox_Buscar = New System.Windows.Forms.GroupBox()
        Me.Button_Buscar = New System.Windows.Forms.Button()
        Me.TextBox_Buscar = New System.Windows.Forms.TextBox()
        Me.Label_Buscar = New System.Windows.Forms.Label()
        Me.DataGridView_usuarios = New System.Windows.Forms.DataGridView()
        Me.EstadosUsuarioBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.PacientesCOVID191DataSet = New PacientesCOVID19.PacientesCOVID191DataSet()
        Me.UsuariosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UsuariosTableAdapter = New PacientesCOVID19.PacientesCOVID191DataSetTableAdapters.UsuariosTableAdapter()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox_Usuario = New System.Windows.Forms.TextBox()
        Me.TextBox_Nombre = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox_Descripcion = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ComboBox_Estado = New System.Windows.Forms.ComboBox()
        Me.EstadosUsuarioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CheckBox_Administrador = New System.Windows.Forms.CheckBox()
        Me.Button_Eliminar = New System.Windows.Forms.Button()
        Me.Button_Editar = New System.Windows.Forms.Button()
        Me.Button_Agregar = New System.Windows.Forms.Button()
        Me.EstadosUsuarioTableAdapter = New PacientesCOVID19.PacientesCOVID191DataSetTableAdapters.EstadosUsuarioTableAdapter()
        Me.TextBox_ID = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button_ReiniciarPswd = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UsuarioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PasswordDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstadoUsuarioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.AdministradorDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.GroupBox_Buscar.SuspendLayout()
        CType(Me.DataGridView_usuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EstadosUsuarioBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PacientesCOVID191DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsuariosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EstadosUsuarioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox_Buscar
        '
        Me.GroupBox_Buscar.Controls.Add(Me.Button_Buscar)
        Me.GroupBox_Buscar.Controls.Add(Me.TextBox_Buscar)
        Me.GroupBox_Buscar.Controls.Add(Me.Label_Buscar)
        Me.GroupBox_Buscar.Location = New System.Drawing.Point(12, 65)
        Me.GroupBox_Buscar.Name = "GroupBox_Buscar"
        Me.GroupBox_Buscar.Size = New System.Drawing.Size(630, 59)
        Me.GroupBox_Buscar.TabIndex = 0
        Me.GroupBox_Buscar.TabStop = False
        Me.GroupBox_Buscar.Text = "Buscar"
        '
        'Button_Buscar
        '
        Me.Button_Buscar.Location = New System.Drawing.Point(543, 20)
        Me.Button_Buscar.Name = "Button_Buscar"
        Me.Button_Buscar.Size = New System.Drawing.Size(75, 23)
        Me.Button_Buscar.TabIndex = 2
        Me.Button_Buscar.Text = "Buscar"
        Me.Button_Buscar.UseVisualStyleBackColor = True
        '
        'TextBox_Buscar
        '
        Me.TextBox_Buscar.Location = New System.Drawing.Point(140, 22)
        Me.TextBox_Buscar.Name = "TextBox_Buscar"
        Me.TextBox_Buscar.Size = New System.Drawing.Size(397, 20)
        Me.TextBox_Buscar.TabIndex = 1
        '
        'Label_Buscar
        '
        Me.Label_Buscar.AutoSize = True
        Me.Label_Buscar.Location = New System.Drawing.Point(6, 25)
        Me.Label_Buscar.Name = "Label_Buscar"
        Me.Label_Buscar.Size = New System.Drawing.Size(128, 13)
        Me.Label_Buscar.TabIndex = 0
        Me.Label_Buscar.Text = "Buscar(Usuario, Nombre):"
        '
        'DataGridView_usuarios
        '
        Me.DataGridView_usuarios.AllowUserToAddRows = False
        Me.DataGridView_usuarios.AllowUserToDeleteRows = False
        Me.DataGridView_usuarios.AutoGenerateColumns = False
        Me.DataGridView_usuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_usuarios.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.UsuarioDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn, Me.PasswordDataGridViewTextBoxColumn, Me.DescripcionDataGridViewTextBoxColumn, Me.EstadoUsuarioDataGridViewTextBoxColumn, Me.AdministradorDataGridViewCheckBoxColumn})
        Me.DataGridView_usuarios.DataSource = Me.UsuariosBindingSource
        Me.DataGridView_usuarios.Location = New System.Drawing.Point(10, 130)
        Me.DataGridView_usuarios.Name = "DataGridView_usuarios"
        Me.DataGridView_usuarios.ReadOnly = True
        Me.DataGridView_usuarios.RowHeadersWidth = 10
        Me.DataGridView_usuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView_usuarios.Size = New System.Drawing.Size(512, 150)
        Me.DataGridView_usuarios.TabIndex = 1
        '
        'EstadosUsuarioBindingSource1
        '
        Me.EstadosUsuarioBindingSource1.DataMember = "EstadosUsuario"
        Me.EstadosUsuarioBindingSource1.DataSource = Me.PacientesCOVID191DataSet
        '
        'PacientesCOVID191DataSet
        '
        Me.PacientesCOVID191DataSet.DataSetName = "PacientesCOVID191DataSet"
        Me.PacientesCOVID191DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UsuariosBindingSource
        '
        Me.UsuariosBindingSource.DataMember = "Usuarios"
        Me.UsuariosBindingSource.DataSource = Me.PacientesCOVID191DataSet
        '
        'UsuariosTableAdapter
        '
        Me.UsuariosTableAdapter.ClearBeforeFill = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 340)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Usuario"
        '
        'TextBox_Usuario
        '
        Me.TextBox_Usuario.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsuariosBindingSource, "Usuario", True))
        Me.TextBox_Usuario.Location = New System.Drawing.Point(15, 356)
        Me.TextBox_Usuario.MaxLength = 50
        Me.TextBox_Usuario.Name = "TextBox_Usuario"
        Me.TextBox_Usuario.ReadOnly = True
        Me.TextBox_Usuario.Size = New System.Drawing.Size(131, 20)
        Me.TextBox_Usuario.TabIndex = 3
        '
        'TextBox_Nombre
        '
        Me.TextBox_Nombre.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsuariosBindingSource, "Nombre", True))
        Me.TextBox_Nombre.Location = New System.Drawing.Point(15, 401)
        Me.TextBox_Nombre.MaxLength = 200
        Me.TextBox_Nombre.Name = "TextBox_Nombre"
        Me.TextBox_Nombre.ReadOnly = True
        Me.TextBox_Nombre.Size = New System.Drawing.Size(131, 20)
        Me.TextBox_Nombre.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 385)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Nombre"
        '
        'TextBox_Descripcion
        '
        Me.TextBox_Descripcion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsuariosBindingSource, "Descripcion", True))
        Me.TextBox_Descripcion.Location = New System.Drawing.Point(194, 308)
        Me.TextBox_Descripcion.MaxLength = 200
        Me.TextBox_Descripcion.Name = "TextBox_Descripcion"
        Me.TextBox_Descripcion.ReadOnly = True
        Me.TextBox_Descripcion.Size = New System.Drawing.Size(179, 20)
        Me.TextBox_Descripcion.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(191, 292)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Descripción"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(191, 340)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Estado"
        '
        'ComboBox_Estado
        '
        Me.ComboBox_Estado.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.UsuariosBindingSource, "EstadoUsuario", True))
        Me.ComboBox_Estado.DataSource = Me.EstadosUsuarioBindingSource
        Me.ComboBox_Estado.DisplayMember = "Estado"
        Me.ComboBox_Estado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_Estado.Enabled = False
        Me.ComboBox_Estado.FormattingEnabled = True
        Me.ComboBox_Estado.Location = New System.Drawing.Point(194, 356)
        Me.ComboBox_Estado.Name = "ComboBox_Estado"
        Me.ComboBox_Estado.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox_Estado.TabIndex = 9
        Me.ComboBox_Estado.ValueMember = "ID"
        '
        'EstadosUsuarioBindingSource
        '
        Me.EstadosUsuarioBindingSource.DataMember = "EstadosUsuario"
        Me.EstadosUsuarioBindingSource.DataSource = Me.PacientesCOVID191DataSet
        '
        'CheckBox_Administrador
        '
        Me.CheckBox_Administrador.AutoSize = True
        Me.CheckBox_Administrador.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CheckBox_Administrador.Enabled = False
        Me.CheckBox_Administrador.Location = New System.Drawing.Point(194, 401)
        Me.CheckBox_Administrador.Name = "CheckBox_Administrador"
        Me.CheckBox_Administrador.Size = New System.Drawing.Size(92, 17)
        Me.CheckBox_Administrador.TabIndex = 10
        Me.CheckBox_Administrador.Text = "Administrador:"
        Me.CheckBox_Administrador.UseVisualStyleBackColor = True
        '
        'Button_Eliminar
        '
        Me.Button_Eliminar.Image = Global.PacientesCOVID19.My.Resources.Resources.eliminar_paciente_16
        Me.Button_Eliminar.Location = New System.Drawing.Point(545, 250)
        Me.Button_Eliminar.Name = "Button_Eliminar"
        Me.Button_Eliminar.Size = New System.Drawing.Size(85, 30)
        Me.Button_Eliminar.TabIndex = 11
        Me.Button_Eliminar.Text = "Eliminar"
        Me.Button_Eliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button_Eliminar.UseVisualStyleBackColor = True
        '
        'Button_Editar
        '
        Me.Button_Editar.Image = Global.PacientesCOVID19.My.Resources.Resources.editar_paciente_16
        Me.Button_Editar.Location = New System.Drawing.Point(545, 187)
        Me.Button_Editar.Name = "Button_Editar"
        Me.Button_Editar.Size = New System.Drawing.Size(85, 32)
        Me.Button_Editar.TabIndex = 12
        Me.Button_Editar.Text = "Editar"
        Me.Button_Editar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button_Editar.UseVisualStyleBackColor = True
        '
        'Button_Agregar
        '
        Me.Button_Agregar.Image = Global.PacientesCOVID19.My.Resources.Resources.agregar_paciente_16
        Me.Button_Agregar.Location = New System.Drawing.Point(545, 130)
        Me.Button_Agregar.Name = "Button_Agregar"
        Me.Button_Agregar.Size = New System.Drawing.Size(85, 35)
        Me.Button_Agregar.TabIndex = 13
        Me.Button_Agregar.Text = "Agregar"
        Me.Button_Agregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button_Agregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button_Agregar.UseVisualStyleBackColor = True
        '
        'EstadosUsuarioTableAdapter
        '
        Me.EstadosUsuarioTableAdapter.ClearBeforeFill = True
        '
        'TextBox_ID
        '
        Me.TextBox_ID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsuariosBindingSource, "ID", True))
        Me.TextBox_ID.Location = New System.Drawing.Point(14, 308)
        Me.TextBox_ID.MaxLength = 50
        Me.TextBox_ID.Name = "TextBox_ID"
        Me.TextBox_ID.ReadOnly = True
        Me.TextBox_ID.Size = New System.Drawing.Size(56, 20)
        Me.TextBox_ID.TabIndex = 14
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 292)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 13)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Id. Usuario"
        '
        'Button_ReiniciarPswd
        '
        Me.Button_ReiniciarPswd.Image = Global.PacientesCOVID19.My.Resources.Resources.editlock_16
        Me.Button_ReiniciarPswd.Location = New System.Drawing.Point(545, 334)
        Me.Button_ReiniciarPswd.Name = "Button_ReiniciarPswd"
        Me.Button_ReiniciarPswd.Size = New System.Drawing.Size(85, 42)
        Me.Button_ReiniciarPswd.TabIndex = 16
        Me.Button_ReiniciarPswd.Text = "Reiniciar Contraseña"
        Me.Button_ReiniciarPswd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button_ReiniciarPswd.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Location = New System.Drawing.Point(-4, -4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(664, 63)
        Me.Panel1.TabIndex = 17
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(25, 17)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(116, 29)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Usuarios"
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.ReadOnly = True
        Me.IDDataGridViewTextBoxColumn.Visible = False
        '
        'UsuarioDataGridViewTextBoxColumn
        '
        Me.UsuarioDataGridViewTextBoxColumn.DataPropertyName = "Usuario"
        Me.UsuarioDataGridViewTextBoxColumn.HeaderText = "Usuario"
        Me.UsuarioDataGridViewTextBoxColumn.Name = "UsuarioDataGridViewTextBoxColumn"
        Me.UsuarioDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NombreDataGridViewTextBoxColumn
        '
        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.HeaderText = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        Me.NombreDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PasswordDataGridViewTextBoxColumn
        '
        Me.PasswordDataGridViewTextBoxColumn.DataPropertyName = "Password"
        Me.PasswordDataGridViewTextBoxColumn.HeaderText = "Password"
        Me.PasswordDataGridViewTextBoxColumn.Name = "PasswordDataGridViewTextBoxColumn"
        Me.PasswordDataGridViewTextBoxColumn.ReadOnly = True
        Me.PasswordDataGridViewTextBoxColumn.Visible = False
        '
        'DescripcionDataGridViewTextBoxColumn
        '
        Me.DescripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.HeaderText = "Descripción"
        Me.DescripcionDataGridViewTextBoxColumn.Name = "DescripcionDataGridViewTextBoxColumn"
        Me.DescripcionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EstadoUsuarioDataGridViewTextBoxColumn
        '
        Me.EstadoUsuarioDataGridViewTextBoxColumn.DataPropertyName = "EstadoUsuario"
        Me.EstadoUsuarioDataGridViewTextBoxColumn.DataSource = Me.EstadosUsuarioBindingSource1
        Me.EstadoUsuarioDataGridViewTextBoxColumn.DisplayMember = "Estado"
        Me.EstadoUsuarioDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.EstadoUsuarioDataGridViewTextBoxColumn.HeaderText = "Estado"
        Me.EstadoUsuarioDataGridViewTextBoxColumn.Name = "EstadoUsuarioDataGridViewTextBoxColumn"
        Me.EstadoUsuarioDataGridViewTextBoxColumn.ReadOnly = True
        Me.EstadoUsuarioDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.EstadoUsuarioDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.EstadoUsuarioDataGridViewTextBoxColumn.ValueMember = "ID"
        '
        'AdministradorDataGridViewCheckBoxColumn
        '
        Me.AdministradorDataGridViewCheckBoxColumn.DataPropertyName = "Administrador"
        Me.AdministradorDataGridViewCheckBoxColumn.HeaderText = "Administrador"
        Me.AdministradorDataGridViewCheckBoxColumn.Name = "AdministradorDataGridViewCheckBoxColumn"
        Me.AdministradorDataGridViewCheckBoxColumn.ReadOnly = True
        '
        'Usuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(654, 431)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Button_ReiniciarPswd)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextBox_ID)
        Me.Controls.Add(Me.Button_Agregar)
        Me.Controls.Add(Me.Button_Editar)
        Me.Controls.Add(Me.Button_Eliminar)
        Me.Controls.Add(Me.CheckBox_Administrador)
        Me.Controls.Add(Me.ComboBox_Estado)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBox_Descripcion)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox_Nombre)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox_Usuario)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView_usuarios)
        Me.Controls.Add(Me.GroupBox_Buscar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Usuarios"
        Me.Text = "Usuarios"
        Me.GroupBox_Buscar.ResumeLayout(False)
        Me.GroupBox_Buscar.PerformLayout()
        CType(Me.DataGridView_usuarios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EstadosUsuarioBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PacientesCOVID191DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsuariosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EstadosUsuarioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox_Buscar As GroupBox
    Friend WithEvents Button_Buscar As Button
    Friend WithEvents TextBox_Buscar As TextBox
    Friend WithEvents Label_Buscar As Label
    Friend WithEvents DataGridView_usuarios As DataGridView
    Friend WithEvents PacientesCOVID191DataSet As PacientesCOVID191DataSet
    Friend WithEvents UsuariosBindingSource As BindingSource
    Friend WithEvents UsuariosTableAdapter As PacientesCOVID191DataSetTableAdapters.UsuariosTableAdapter
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox_Usuario As TextBox
    Friend WithEvents TextBox_Nombre As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox_Descripcion As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents ComboBox_Estado As ComboBox
    Friend WithEvents CheckBox_Administrador As CheckBox
    Friend WithEvents Button_Eliminar As Button
    Friend WithEvents Button_Editar As Button
    Friend WithEvents Button_Agregar As Button
    Friend WithEvents EstadosUsuarioBindingSource As BindingSource
    Friend WithEvents EstadosUsuarioTableAdapter As PacientesCOVID191DataSetTableAdapters.EstadosUsuarioTableAdapter
    Friend WithEvents EstadosUsuarioBindingSource1 As BindingSource
    Friend WithEvents TextBox_ID As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Button_ReiniciarPswd As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UsuarioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PasswordDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescripcionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EstadoUsuarioDataGridViewTextBoxColumn As DataGridViewComboBoxColumn
    Friend WithEvents AdministradorDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
End Class
