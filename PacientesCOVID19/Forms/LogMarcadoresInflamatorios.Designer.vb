<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LogMarcadoresInflamatorios
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
        Me.TextBox_PacienteID_param = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button_Buscar = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox_PacienteFechaNacimiento_param = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox_PacienteIdentidad_param = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox_PacienteNombre_param = New System.Windows.Forms.TextBox()
        Me.DataGridView_MI = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaHoraDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PacienteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.PacientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PacientesCOVID191DataSet = New PacientesCOVID19.PacientesCOVID191DataSet()
        Me.UsuarioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RegistroMarcadoresInflamatoriosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button_Agregar = New System.Windows.Forms.Button()
        Me.Button_Editar = New System.Windows.Forms.Button()
        Me.Button_Eliminar = New System.Windows.Forms.Button()
        Me.ComboBox_Paciente = New System.Windows.Forms.ComboBox()
        Me.PacientesBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.PacientesCOVID191DataSet1 = New PacientesCOVID19.PacientesCOVID191DataSet()
        Me.DateTimePicker_FechaHora = New System.Windows.Forms.DateTimePicker()
        Me.TextBox_Usuario = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TextBox_DimeroD = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TextBox_TGP = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TextBox_TGO = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TextBox_Ferritina = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TextBox_LDH = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TextBox_ProteinaCReactivaUltra = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextBox_ProteinaCReactiva = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox_ID = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.RegistroMarcadoresInflamatoriosTableAdapter = New PacientesCOVID19.PacientesCOVID191DataSetTableAdapters.RegistroMarcadoresInflamatoriosTableAdapter()
        Me.PacientesTableAdapter = New PacientesCOVID19.PacientesCOVID191DataSetTableAdapters.PacientesTableAdapter()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView_MI, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PacientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PacientesCOVID191DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RegistroMarcadoresInflamatoriosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PacientesBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PacientesCOVID191DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBox_PacienteID_param
        '
        Me.TextBox_PacienteID_param.Location = New System.Drawing.Point(33, 19)
        Me.TextBox_PacienteID_param.Name = "TextBox_PacienteID_param"
        Me.TextBox_PacienteID_param.ReadOnly = True
        Me.TextBox_PacienteID_param.Size = New System.Drawing.Size(47, 20)
        Me.TextBox_PacienteID_param.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(21, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "ID:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button_Buscar)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TextBox_PacienteFechaNacimiento_param)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TextBox_PacienteIdentidad_param)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TextBox_PacienteNombre_param)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TextBox_PacienteID_param)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(776, 56)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Informacion del Paciente"
        '
        'Button_Buscar
        '
        Me.Button_Buscar.Location = New System.Drawing.Point(695, 17)
        Me.Button_Buscar.Name = "Button_Buscar"
        Me.Button_Buscar.Size = New System.Drawing.Size(75, 23)
        Me.Button_Buscar.TabIndex = 8
        Me.Button_Buscar.Text = "Actualizar"
        Me.Button_Buscar.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(453, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(109, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Fecha de nacimiento:"
        '
        'TextBox_PacienteFechaNacimiento_param
        '
        Me.TextBox_PacienteFechaNacimiento_param.Location = New System.Drawing.Point(568, 19)
        Me.TextBox_PacienteFechaNacimiento_param.Name = "TextBox_PacienteFechaNacimiento_param"
        Me.TextBox_PacienteFechaNacimiento_param.ReadOnly = True
        Me.TextBox_PacienteFechaNacimiento_param.Size = New System.Drawing.Size(105, 20)
        Me.TextBox_PacienteFechaNacimiento_param.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(282, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Identidad:"
        '
        'TextBox_PacienteIdentidad_param
        '
        Me.TextBox_PacienteIdentidad_param.Location = New System.Drawing.Point(342, 19)
        Me.TextBox_PacienteIdentidad_param.Name = "TextBox_PacienteIdentidad_param"
        Me.TextBox_PacienteIdentidad_param.ReadOnly = True
        Me.TextBox_PacienteIdentidad_param.Size = New System.Drawing.Size(105, 20)
        Me.TextBox_PacienteIdentidad_param.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(86, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Nombre:"
        '
        'TextBox_PacienteNombre_param
        '
        Me.TextBox_PacienteNombre_param.Location = New System.Drawing.Point(139, 19)
        Me.TextBox_PacienteNombre_param.Name = "TextBox_PacienteNombre_param"
        Me.TextBox_PacienteNombre_param.ReadOnly = True
        Me.TextBox_PacienteNombre_param.Size = New System.Drawing.Size(137, 20)
        Me.TextBox_PacienteNombre_param.TabIndex = 2
        '
        'DataGridView_MI
        '
        Me.DataGridView_MI.AllowUserToAddRows = False
        Me.DataGridView_MI.AllowUserToDeleteRows = False
        Me.DataGridView_MI.AutoGenerateColumns = False
        Me.DataGridView_MI.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_MI.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.FechaHoraDataGridViewTextBoxColumn, Me.PacienteDataGridViewTextBoxColumn, Me.UsuarioDataGridViewTextBoxColumn})
        Me.DataGridView_MI.DataSource = Me.RegistroMarcadoresInflamatoriosBindingSource
        Me.DataGridView_MI.Location = New System.Drawing.Point(12, 74)
        Me.DataGridView_MI.Name = "DataGridView_MI"
        Me.DataGridView_MI.ReadOnly = True
        Me.DataGridView_MI.RowHeadersWidth = 10
        Me.DataGridView_MI.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView_MI.Size = New System.Drawing.Size(326, 437)
        Me.DataGridView_MI.TabIndex = 3
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.ReadOnly = True
        Me.IDDataGridViewTextBoxColumn.Width = 50
        '
        'FechaHoraDataGridViewTextBoxColumn
        '
        Me.FechaHoraDataGridViewTextBoxColumn.DataPropertyName = "FechaHora"
        Me.FechaHoraDataGridViewTextBoxColumn.HeaderText = "FechaHora"
        Me.FechaHoraDataGridViewTextBoxColumn.Name = "FechaHoraDataGridViewTextBoxColumn"
        Me.FechaHoraDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PacienteDataGridViewTextBoxColumn
        '
        Me.PacienteDataGridViewTextBoxColumn.DataPropertyName = "Paciente"
        Me.PacienteDataGridViewTextBoxColumn.DataSource = Me.PacientesBindingSource
        Me.PacienteDataGridViewTextBoxColumn.DisplayMember = "Nombre"
        Me.PacienteDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.PacienteDataGridViewTextBoxColumn.HeaderText = "Paciente"
        Me.PacienteDataGridViewTextBoxColumn.Name = "PacienteDataGridViewTextBoxColumn"
        Me.PacienteDataGridViewTextBoxColumn.ReadOnly = True
        Me.PacienteDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.PacienteDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.PacienteDataGridViewTextBoxColumn.ValueMember = "ID"
        '
        'PacientesBindingSource
        '
        Me.PacientesBindingSource.DataMember = "Pacientes"
        Me.PacientesBindingSource.DataSource = Me.PacientesCOVID191DataSet
        '
        'PacientesCOVID191DataSet
        '
        Me.PacientesCOVID191DataSet.DataSetName = "PacientesCOVID191DataSet"
        Me.PacientesCOVID191DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UsuarioDataGridViewTextBoxColumn
        '
        Me.UsuarioDataGridViewTextBoxColumn.DataPropertyName = "Usuario"
        Me.UsuarioDataGridViewTextBoxColumn.HeaderText = "Usuario"
        Me.UsuarioDataGridViewTextBoxColumn.Name = "UsuarioDataGridViewTextBoxColumn"
        Me.UsuarioDataGridViewTextBoxColumn.ReadOnly = True
        '
        'RegistroMarcadoresInflamatoriosBindingSource
        '
        Me.RegistroMarcadoresInflamatoriosBindingSource.DataMember = "RegistroMarcadoresInflamatorios"
        Me.RegistroMarcadoresInflamatoriosBindingSource.DataSource = Me.PacientesCOVID191DataSet
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button_Agregar)
        Me.GroupBox2.Controls.Add(Me.Button_Editar)
        Me.GroupBox2.Controls.Add(Me.Button_Eliminar)
        Me.GroupBox2.Controls.Add(Me.ComboBox_Paciente)
        Me.GroupBox2.Controls.Add(Me.DateTimePicker_FechaHora)
        Me.GroupBox2.Controls.Add(Me.TextBox_Usuario)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.TextBox_DimeroD)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.TextBox_TGP)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.TextBox_TGO)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.TextBox_Ferritina)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.TextBox_LDH)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.TextBox_ProteinaCReactivaUltra)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.TextBox_ProteinaCReactiva)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.TextBox_ID)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Location = New System.Drawing.Point(354, 74)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(405, 437)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Registro Marcador Inflamatorio"
        '
        'Button_Agregar
        '
        Me.Button_Agregar.BackColor = System.Drawing.SystemColors.Control
        Me.Button_Agregar.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.Button_Agregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Agregar.Image = Global.PacientesCOVID19.My.Resources.Resources.add_16
        Me.Button_Agregar.Location = New System.Drawing.Point(299, 285)
        Me.Button_Agregar.Name = "Button_Agregar"
        Me.Button_Agregar.Size = New System.Drawing.Size(88, 36)
        Me.Button_Agregar.TabIndex = 26
        Me.Button_Agregar.Text = "Agregar"
        Me.Button_Agregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button_Agregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button_Agregar.UseVisualStyleBackColor = True
        '
        'Button_Editar
        '
        Me.Button_Editar.Image = Global.PacientesCOVID19.My.Resources.Resources.edit_16
        Me.Button_Editar.Location = New System.Drawing.Point(299, 328)
        Me.Button_Editar.Name = "Button_Editar"
        Me.Button_Editar.Size = New System.Drawing.Size(88, 36)
        Me.Button_Editar.TabIndex = 25
        Me.Button_Editar.Text = "Editar"
        Me.Button_Editar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button_Editar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button_Editar.UseVisualStyleBackColor = True
        '
        'Button_Eliminar
        '
        Me.Button_Eliminar.Image = Global.PacientesCOVID19.My.Resources.Resources.delete_16
        Me.Button_Eliminar.Location = New System.Drawing.Point(299, 370)
        Me.Button_Eliminar.Name = "Button_Eliminar"
        Me.Button_Eliminar.Size = New System.Drawing.Size(88, 36)
        Me.Button_Eliminar.TabIndex = 24
        Me.Button_Eliminar.Text = "Eliminar"
        Me.Button_Eliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button_Eliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button_Eliminar.UseVisualStyleBackColor = True
        '
        'ComboBox_Paciente
        '
        Me.ComboBox_Paciente.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.RegistroMarcadoresInflamatoriosBindingSource, "Paciente", True))
        Me.ComboBox_Paciente.DataSource = Me.PacientesBindingSource1
        Me.ComboBox_Paciente.DisplayMember = "Nombre"
        Me.ComboBox_Paciente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_Paciente.Enabled = False
        Me.ComboBox_Paciente.FormattingEnabled = True
        Me.ComboBox_Paciente.Location = New System.Drawing.Point(84, 76)
        Me.ComboBox_Paciente.Name = "ComboBox_Paciente"
        Me.ComboBox_Paciente.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox_Paciente.TabIndex = 23
        Me.ComboBox_Paciente.ValueMember = "ID"
        '
        'PacientesBindingSource1
        '
        Me.PacientesBindingSource1.DataMember = "Pacientes"
        Me.PacientesBindingSource1.DataSource = Me.PacientesCOVID191DataSet1
        '
        'PacientesCOVID191DataSet1
        '
        Me.PacientesCOVID191DataSet1.DataSetName = "PacientesCOVID191DataSet"
        Me.PacientesCOVID191DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DateTimePicker_FechaHora
        '
        Me.DateTimePicker_FechaHora.CustomFormat = "dd/MM/yyyy hh:mm"
        Me.DateTimePicker_FechaHora.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.RegistroMarcadoresInflamatoriosBindingSource, "FechaHora", True))
        Me.DateTimePicker_FechaHora.Enabled = False
        Me.DateTimePicker_FechaHora.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker_FechaHora.Location = New System.Drawing.Point(269, 21)
        Me.DateTimePicker_FechaHora.Name = "DateTimePicker_FechaHora"
        Me.DateTimePicker_FechaHora.Size = New System.Drawing.Size(121, 20)
        Me.DateTimePicker_FechaHora.TabIndex = 22
        '
        'TextBox_Usuario
        '
        Me.TextBox_Usuario.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RegistroMarcadoresInflamatoriosBindingSource, "Usuario", True))
        Me.TextBox_Usuario.Location = New System.Drawing.Point(99, 363)
        Me.TextBox_Usuario.Name = "TextBox_Usuario"
        Me.TextBox_Usuario.ReadOnly = True
        Me.TextBox_Usuario.Size = New System.Drawing.Size(121, 20)
        Me.TextBox_Usuario.TabIndex = 8
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(47, 367)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(46, 13)
        Me.Label15.TabIndex = 20
        Me.Label15.Text = "Usuario:"
        '
        'TextBox_DimeroD
        '
        Me.TextBox_DimeroD.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RegistroMarcadoresInflamatoriosBindingSource, "Dimero D", True))
        Me.TextBox_DimeroD.Location = New System.Drawing.Point(99, 337)
        Me.TextBox_DimeroD.Name = "TextBox_DimeroD"
        Me.TextBox_DimeroD.ReadOnly = True
        Me.TextBox_DimeroD.Size = New System.Drawing.Size(121, 20)
        Me.TextBox_DimeroD.TabIndex = 7
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(39, 341)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(54, 13)
        Me.Label14.TabIndex = 18
        Me.Label14.Text = "Dimero D:"
        '
        'TextBox_TGP
        '
        Me.TextBox_TGP.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RegistroMarcadoresInflamatoriosBindingSource, "TGP", True))
        Me.TextBox_TGP.Location = New System.Drawing.Point(99, 311)
        Me.TextBox_TGP.Name = "TextBox_TGP"
        Me.TextBox_TGP.ReadOnly = True
        Me.TextBox_TGP.Size = New System.Drawing.Size(121, 20)
        Me.TextBox_TGP.TabIndex = 6
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(61, 315)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(32, 13)
        Me.Label13.TabIndex = 16
        Me.Label13.Text = "TGP:"
        '
        'TextBox_TGO
        '
        Me.TextBox_TGO.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RegistroMarcadoresInflamatoriosBindingSource, "TGO", True))
        Me.TextBox_TGO.Location = New System.Drawing.Point(99, 285)
        Me.TextBox_TGO.Name = "TextBox_TGO"
        Me.TextBox_TGO.ReadOnly = True
        Me.TextBox_TGO.Size = New System.Drawing.Size(121, 20)
        Me.TextBox_TGO.TabIndex = 5
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(60, 288)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(33, 13)
        Me.Label12.TabIndex = 14
        Me.Label12.Text = "TGO:"
        '
        'TextBox_Ferritina
        '
        Me.TextBox_Ferritina.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RegistroMarcadoresInflamatoriosBindingSource, "Ferritina", True))
        Me.TextBox_Ferritina.Location = New System.Drawing.Point(142, 217)
        Me.TextBox_Ferritina.Name = "TextBox_Ferritina"
        Me.TextBox_Ferritina.ReadOnly = True
        Me.TextBox_Ferritina.Size = New System.Drawing.Size(121, 20)
        Me.TextBox_Ferritina.TabIndex = 4
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(89, 220)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(47, 13)
        Me.Label11.TabIndex = 12
        Me.Label11.Text = "Ferritina:"
        '
        'TextBox_LDH
        '
        Me.TextBox_LDH.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RegistroMarcadoresInflamatoriosBindingSource, "LDH", True))
        Me.TextBox_LDH.Location = New System.Drawing.Point(142, 191)
        Me.TextBox_LDH.Name = "TextBox_LDH"
        Me.TextBox_LDH.ReadOnly = True
        Me.TextBox_LDH.Size = New System.Drawing.Size(121, 20)
        Me.TextBox_LDH.TabIndex = 3
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(104, 194)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(32, 13)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "LDH:"
        '
        'TextBox_ProteinaCReactivaUltra
        '
        Me.TextBox_ProteinaCReactivaUltra.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RegistroMarcadoresInflamatoriosBindingSource, "ProteinaCReactivaUltrasensible", True))
        Me.TextBox_ProteinaCReactivaUltra.Location = New System.Drawing.Point(142, 165)
        Me.TextBox_ProteinaCReactivaUltra.Name = "TextBox_ProteinaCReactivaUltra"
        Me.TextBox_ProteinaCReactivaUltra.ReadOnly = True
        Me.TextBox_ProteinaCReactivaUltra.Size = New System.Drawing.Size(121, 20)
        Me.TextBox_ProteinaCReactivaUltra.TabIndex = 2
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(31, 162)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(105, 26)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Proteina C Reactiva " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Ultrasensible:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TextBox_ProteinaCReactiva
        '
        Me.TextBox_ProteinaCReactiva.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RegistroMarcadoresInflamatoriosBindingSource, "ProteinaCReactiva", True))
        Me.TextBox_ProteinaCReactiva.Location = New System.Drawing.Point(142, 139)
        Me.TextBox_ProteinaCReactiva.Name = "TextBox_ProteinaCReactiva"
        Me.TextBox_ProteinaCReactiva.ReadOnly = True
        Me.TextBox_ProteinaCReactiva.Size = New System.Drawing.Size(121, 20)
        Me.TextBox_ProteinaCReactiva.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(31, 142)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(105, 13)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Proteina C Reactiva:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(26, 79)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 13)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Paciente:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(191, 24)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 13)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Fecha y hora:"
        '
        'TextBox_ID
        '
        Me.TextBox_ID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RegistroMarcadoresInflamatoriosBindingSource, "ID", True))
        Me.TextBox_ID.Location = New System.Drawing.Point(42, 21)
        Me.TextBox_ID.Name = "TextBox_ID"
        Me.TextBox_ID.ReadOnly = True
        Me.TextBox_ID.Size = New System.Drawing.Size(121, 20)
        Me.TextBox_ID.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(15, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(21, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "ID:"
        '
        'RegistroMarcadoresInflamatoriosTableAdapter
        '
        Me.RegistroMarcadoresInflamatoriosTableAdapter.ClearBeforeFill = True
        '
        'PacientesTableAdapter
        '
        Me.PacientesTableAdapter.ClearBeforeFill = True
        '
        'LogMarcadoresInflamatorios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(801, 523)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.DataGridView_MI)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "LogMarcadoresInflamatorios"
        Me.Text = "LogMarcadoresInflamatorios"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView_MI, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PacientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PacientesCOVID191DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RegistroMarcadoresInflamatoriosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PacientesBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PacientesCOVID191DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Public WithEvents TextBox_PacienteID_param As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label4 As Label
    Public WithEvents TextBox_PacienteFechaNacimiento_param As TextBox
    Friend WithEvents Label3 As Label
    Public WithEvents TextBox_PacienteIdentidad_param As TextBox
    Friend WithEvents Label2 As Label
    Public WithEvents TextBox_PacienteNombre_param As TextBox
    Friend WithEvents DataGridView_MI As DataGridView
    Friend WithEvents PacientesCOVID191DataSet As PacientesCOVID191DataSet
    Friend WithEvents RegistroMarcadoresInflamatoriosBindingSource As BindingSource
    Friend WithEvents RegistroMarcadoresInflamatoriosTableAdapter As PacientesCOVID191DataSetTableAdapters.RegistroMarcadoresInflamatoriosTableAdapter
    Friend WithEvents PacientesBindingSource As BindingSource
    Friend WithEvents PacientesTableAdapter As PacientesCOVID191DataSetTableAdapters.PacientesTableAdapter
    Friend WithEvents Button_Buscar As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ComboBox_Paciente As ComboBox
    Friend WithEvents DateTimePicker_FechaHora As DateTimePicker
    Friend WithEvents TextBox_Usuario As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents TextBox_DimeroD As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents TextBox_TGP As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents TextBox_TGO As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents TextBox_Ferritina As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents TextBox_LDH As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents TextBox_ProteinaCReactivaUltra As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TextBox_ProteinaCReactiva As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox_ID As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Button_Agregar As Button
    Friend WithEvents Button_Editar As Button
    Friend WithEvents Button_Eliminar As Button
    Friend WithEvents PacientesCOVID191DataSet1 As PacientesCOVID191DataSet
    Friend WithEvents PacientesBindingSource1 As BindingSource
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaHoraDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PacienteDataGridViewTextBoxColumn As DataGridViewComboBoxColumn
    Friend WithEvents UsuarioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
