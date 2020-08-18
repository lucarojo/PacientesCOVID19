<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pacientes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Pacientes))
        Me.GroupBox_Buscar = New System.Windows.Forms.GroupBox()
        Me.Button_Buscar = New System.Windows.Forms.Button()
        Me.TextBox_Buscar = New System.Windows.Forms.TextBox()
        Me.Label_Buscar = New System.Windows.Forms.Label()
        Me.DataGridView_Pacientes = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaNacimientoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SexoPacienteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.SexoBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.PacientesCOVID191DataSet = New PacientesCOVID19.PacientesCOVID191DataSet()
        Me.IdentidadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaDeIngresoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstadoPacienteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.EstadosBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.UltimoEstadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.EstadosBindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.FechaCambioEstadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UsuarioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PacientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Button_Agregar = New System.Windows.Forms.Button()
        Me.Button_Editar = New System.Windows.Forms.Button()
        Me.Button_Eliminar = New System.Windows.Forms.Button()
        Me.PacientesTableAdapter = New PacientesCOVID19.PacientesCOVID191DataSetTableAdapters.PacientesTableAdapter()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox_ID = New System.Windows.Forms.TextBox()
        Me.TextBox_Nombre = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox_Identidad = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DateTimePicker_FechaNacimiento = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ComboBox_Sexo = New System.Windows.Forms.ComboBox()
        Me.SexoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DateTimePicker_FechaIngreso = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ComboBox_Estado = New System.Windows.Forms.ComboBox()
        Me.EstadosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBox_FechaCambioEstado = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextBox_Usuario = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ComboBox_UltimoEstado = New System.Windows.Forms.ComboBox()
        Me.EstadosBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.SexoTableAdapter = New PacientesCOVID19.PacientesCOVID191DataSetTableAdapters.SexoTableAdapter()
        Me.EstadosTableAdapter = New PacientesCOVID19.PacientesCOVID191DataSetTableAdapters.EstadosTableAdapter()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Edadtxt = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.EstadosBindingSource4 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Button_Agregar_MI = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.GroupBox_Buscar.SuspendLayout()
        CType(Me.DataGridView_Pacientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SexoBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PacientesCOVID191DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EstadosBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EstadosBindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PacientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SexoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EstadosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EstadosBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.EstadosBindingSource4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox_Buscar
        '
        Me.GroupBox_Buscar.Controls.Add(Me.Button_Buscar)
        Me.GroupBox_Buscar.Controls.Add(Me.TextBox_Buscar)
        Me.GroupBox_Buscar.Controls.Add(Me.Label_Buscar)
        Me.GroupBox_Buscar.Location = New System.Drawing.Point(12, 75)
        Me.GroupBox_Buscar.Name = "GroupBox_Buscar"
        Me.GroupBox_Buscar.Size = New System.Drawing.Size(658, 55)
        Me.GroupBox_Buscar.TabIndex = 1
        Me.GroupBox_Buscar.TabStop = False
        Me.GroupBox_Buscar.Text = "Buscar"
        '
        'Button_Buscar
        '
        Me.Button_Buscar.Image = Global.PacientesCOVID19.My.Resources.Resources.buscar_16
        Me.Button_Buscar.Location = New System.Drawing.Point(589, 19)
        Me.Button_Buscar.Name = "Button_Buscar"
        Me.Button_Buscar.Size = New System.Drawing.Size(44, 25)
        Me.Button_Buscar.TabIndex = 2
        Me.Button_Buscar.UseVisualStyleBackColor = True
        '
        'TextBox_Buscar
        '
        Me.TextBox_Buscar.Location = New System.Drawing.Point(140, 22)
        Me.TextBox_Buscar.Name = "TextBox_Buscar"
        Me.TextBox_Buscar.Size = New System.Drawing.Size(431, 20)
        Me.TextBox_Buscar.TabIndex = 1
        '
        'Label_Buscar
        '
        Me.Label_Buscar.AutoSize = True
        Me.Label_Buscar.Location = New System.Drawing.Point(6, 25)
        Me.Label_Buscar.Name = "Label_Buscar"
        Me.Label_Buscar.Size = New System.Drawing.Size(136, 13)
        Me.Label_Buscar.TabIndex = 0
        Me.Label_Buscar.Text = "Buscar(Nombre, Identidad):"
        '
        'DataGridView_Pacientes
        '
        Me.DataGridView_Pacientes.AllowUserToAddRows = False
        Me.DataGridView_Pacientes.AllowUserToDeleteRows = False
        Me.DataGridView_Pacientes.AutoGenerateColumns = False
        Me.DataGridView_Pacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_Pacientes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn, Me.FechaNacimientoDataGridViewTextBoxColumn, Me.SexoPacienteDataGridViewTextBoxColumn, Me.IdentidadDataGridViewTextBoxColumn, Me.FechaDeIngresoDataGridViewTextBoxColumn, Me.EstadoPacienteDataGridViewTextBoxColumn, Me.UltimoEstadoDataGridViewTextBoxColumn, Me.FechaCambioEstadoDataGridViewTextBoxColumn, Me.UsuarioDataGridViewTextBoxColumn})
        Me.DataGridView_Pacientes.DataSource = Me.PacientesBindingSource
        Me.DataGridView_Pacientes.Location = New System.Drawing.Point(12, 136)
        Me.DataGridView_Pacientes.Name = "DataGridView_Pacientes"
        Me.DataGridView_Pacientes.ReadOnly = True
        Me.DataGridView_Pacientes.RowHeadersWidth = 10
        Me.DataGridView_Pacientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView_Pacientes.Size = New System.Drawing.Size(658, 179)
        Me.DataGridView_Pacientes.TabIndex = 2
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.ReadOnly = True
        Me.IDDataGridViewTextBoxColumn.Visible = False
        Me.IDDataGridViewTextBoxColumn.Width = 50
        '
        'NombreDataGridViewTextBoxColumn
        '
        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.HeaderText = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        Me.NombreDataGridViewTextBoxColumn.ReadOnly = True
        Me.NombreDataGridViewTextBoxColumn.Width = 150
        '
        'FechaNacimientoDataGridViewTextBoxColumn
        '
        Me.FechaNacimientoDataGridViewTextBoxColumn.DataPropertyName = "Fecha Nacimiento"
        Me.FechaNacimientoDataGridViewTextBoxColumn.HeaderText = "Fecha Nacimiento"
        Me.FechaNacimientoDataGridViewTextBoxColumn.Name = "FechaNacimientoDataGridViewTextBoxColumn"
        Me.FechaNacimientoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SexoPacienteDataGridViewTextBoxColumn
        '
        Me.SexoPacienteDataGridViewTextBoxColumn.DataPropertyName = "Sexo Paciente"
        Me.SexoPacienteDataGridViewTextBoxColumn.DataSource = Me.SexoBindingSource1
        Me.SexoPacienteDataGridViewTextBoxColumn.DisplayMember = "Sexo"
        Me.SexoPacienteDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.SexoPacienteDataGridViewTextBoxColumn.HeaderText = "Sexo"
        Me.SexoPacienteDataGridViewTextBoxColumn.Name = "SexoPacienteDataGridViewTextBoxColumn"
        Me.SexoPacienteDataGridViewTextBoxColumn.ReadOnly = True
        Me.SexoPacienteDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.SexoPacienteDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.SexoPacienteDataGridViewTextBoxColumn.ValueMember = "ID"
        '
        'SexoBindingSource1
        '
        Me.SexoBindingSource1.DataMember = "Sexo"
        Me.SexoBindingSource1.DataSource = Me.PacientesCOVID191DataSet
        '
        'PacientesCOVID191DataSet
        '
        Me.PacientesCOVID191DataSet.DataSetName = "PacientesCOVID191DataSet"
        Me.PacientesCOVID191DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'IdentidadDataGridViewTextBoxColumn
        '
        Me.IdentidadDataGridViewTextBoxColumn.DataPropertyName = "Identidad"
        Me.IdentidadDataGridViewTextBoxColumn.HeaderText = "Identidad"
        Me.IdentidadDataGridViewTextBoxColumn.Name = "IdentidadDataGridViewTextBoxColumn"
        Me.IdentidadDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FechaDeIngresoDataGridViewTextBoxColumn
        '
        Me.FechaDeIngresoDataGridViewTextBoxColumn.DataPropertyName = "Fecha de Ingreso"
        Me.FechaDeIngresoDataGridViewTextBoxColumn.HeaderText = "Fecha de Ingreso"
        Me.FechaDeIngresoDataGridViewTextBoxColumn.Name = "FechaDeIngresoDataGridViewTextBoxColumn"
        Me.FechaDeIngresoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EstadoPacienteDataGridViewTextBoxColumn
        '
        Me.EstadoPacienteDataGridViewTextBoxColumn.DataPropertyName = "EstadoPaciente"
        Me.EstadoPacienteDataGridViewTextBoxColumn.DataSource = Me.EstadosBindingSource2
        Me.EstadoPacienteDataGridViewTextBoxColumn.DisplayMember = "Descripcion"
        Me.EstadoPacienteDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.EstadoPacienteDataGridViewTextBoxColumn.HeaderText = "Estado"
        Me.EstadoPacienteDataGridViewTextBoxColumn.Name = "EstadoPacienteDataGridViewTextBoxColumn"
        Me.EstadoPacienteDataGridViewTextBoxColumn.ReadOnly = True
        Me.EstadoPacienteDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.EstadoPacienteDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.EstadoPacienteDataGridViewTextBoxColumn.ValueMember = "ID"
        '
        'EstadosBindingSource2
        '
        Me.EstadosBindingSource2.DataMember = "Estados"
        Me.EstadosBindingSource2.DataSource = Me.PacientesCOVID191DataSet
        '
        'UltimoEstadoDataGridViewTextBoxColumn
        '
        Me.UltimoEstadoDataGridViewTextBoxColumn.DataPropertyName = "UltimoEstado"
        Me.UltimoEstadoDataGridViewTextBoxColumn.DataSource = Me.EstadosBindingSource3
        Me.UltimoEstadoDataGridViewTextBoxColumn.DisplayMember = "Descripcion"
        Me.UltimoEstadoDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.UltimoEstadoDataGridViewTextBoxColumn.HeaderText = "UltimoEstado"
        Me.UltimoEstadoDataGridViewTextBoxColumn.Name = "UltimoEstadoDataGridViewTextBoxColumn"
        Me.UltimoEstadoDataGridViewTextBoxColumn.ReadOnly = True
        Me.UltimoEstadoDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.UltimoEstadoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.UltimoEstadoDataGridViewTextBoxColumn.ValueMember = "ID"
        Me.UltimoEstadoDataGridViewTextBoxColumn.Visible = False
        '
        'EstadosBindingSource3
        '
        Me.EstadosBindingSource3.DataMember = "Estados"
        Me.EstadosBindingSource3.DataSource = Me.PacientesCOVID191DataSet
        '
        'FechaCambioEstadoDataGridViewTextBoxColumn
        '
        Me.FechaCambioEstadoDataGridViewTextBoxColumn.DataPropertyName = "FechaCambioEstado"
        Me.FechaCambioEstadoDataGridViewTextBoxColumn.HeaderText = "FechaCambioEstado"
        Me.FechaCambioEstadoDataGridViewTextBoxColumn.Name = "FechaCambioEstadoDataGridViewTextBoxColumn"
        Me.FechaCambioEstadoDataGridViewTextBoxColumn.ReadOnly = True
        Me.FechaCambioEstadoDataGridViewTextBoxColumn.Visible = False
        '
        'UsuarioDataGridViewTextBoxColumn
        '
        Me.UsuarioDataGridViewTextBoxColumn.DataPropertyName = "Usuario"
        Me.UsuarioDataGridViewTextBoxColumn.HeaderText = "Usuario"
        Me.UsuarioDataGridViewTextBoxColumn.Name = "UsuarioDataGridViewTextBoxColumn"
        Me.UsuarioDataGridViewTextBoxColumn.ReadOnly = True
        Me.UsuarioDataGridViewTextBoxColumn.Visible = False
        '
        'PacientesBindingSource
        '
        Me.PacientesBindingSource.DataMember = "Pacientes"
        Me.PacientesBindingSource.DataSource = Me.PacientesCOVID191DataSet
        '
        'Button_Agregar
        '
        Me.Button_Agregar.BackColor = System.Drawing.SystemColors.Control
        Me.Button_Agregar.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.Button_Agregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Agregar.Image = Global.PacientesCOVID19.My.Resources.Resources.agregar_paciente_16
        Me.Button_Agregar.Location = New System.Drawing.Point(564, 383)
        Me.Button_Agregar.Name = "Button_Agregar"
        Me.Button_Agregar.Size = New System.Drawing.Size(88, 44)
        Me.Button_Agregar.TabIndex = 16
        Me.Button_Agregar.Text = "Agregar"
        Me.Button_Agregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button_Agregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button_Agregar.UseVisualStyleBackColor = True
        '
        'Button_Editar
        '
        Me.Button_Editar.Image = Global.PacientesCOVID19.My.Resources.Resources.editar_paciente_16
        Me.Button_Editar.Location = New System.Drawing.Point(564, 433)
        Me.Button_Editar.Name = "Button_Editar"
        Me.Button_Editar.Size = New System.Drawing.Size(88, 41)
        Me.Button_Editar.TabIndex = 15
        Me.Button_Editar.Text = "Editar"
        Me.Button_Editar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button_Editar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button_Editar.UseVisualStyleBackColor = True
        '
        'Button_Eliminar
        '
        Me.Button_Eliminar.Image = Global.PacientesCOVID19.My.Resources.Resources.eliminar_paciente_16
        Me.Button_Eliminar.Location = New System.Drawing.Point(564, 480)
        Me.Button_Eliminar.Name = "Button_Eliminar"
        Me.Button_Eliminar.Size = New System.Drawing.Size(88, 48)
        Me.Button_Eliminar.TabIndex = 14
        Me.Button_Eliminar.Text = "Eliminar"
        Me.Button_Eliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button_Eliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button_Eliminar.UseVisualStyleBackColor = True
        '
        'PacientesTableAdapter
        '
        Me.PacientesTableAdapter.ClearBeforeFill = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(39, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(21, 13)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "ID:"
        '
        'TextBox_ID
        '
        Me.TextBox_ID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PacientesBindingSource, "ID", True))
        Me.TextBox_ID.Location = New System.Drawing.Point(104, 19)
        Me.TextBox_ID.Name = "TextBox_ID"
        Me.TextBox_ID.ReadOnly = True
        Me.TextBox_ID.Size = New System.Drawing.Size(121, 20)
        Me.TextBox_ID.TabIndex = 18
        '
        'TextBox_Nombre
        '
        Me.TextBox_Nombre.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PacientesBindingSource, "Nombre", True))
        Me.TextBox_Nombre.Location = New System.Drawing.Point(104, 48)
        Me.TextBox_Nombre.Name = "TextBox_Nombre"
        Me.TextBox_Nombre.ReadOnly = True
        Me.TextBox_Nombre.Size = New System.Drawing.Size(121, 20)
        Me.TextBox_Nombre.TabIndex = 20
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 13)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Nombre Paciente:"
        '
        'TextBox_Identidad
        '
        Me.TextBox_Identidad.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PacientesBindingSource, "Identidad", True))
        Me.TextBox_Identidad.Location = New System.Drawing.Point(104, 75)
        Me.TextBox_Identidad.Name = "TextBox_Identidad"
        Me.TextBox_Identidad.ReadOnly = True
        Me.TextBox_Identidad.Size = New System.Drawing.Size(121, 20)
        Me.TextBox_Identidad.TabIndex = 22
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 82)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 13)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Identidad:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 140)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 13)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Fecha Nacimiento"
        '
        'DateTimePicker_FechaNacimiento
        '
        Me.DateTimePicker_FechaNacimiento.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PacientesBindingSource, "Fecha Nacimiento", True))
        Me.DateTimePicker_FechaNacimiento.Enabled = False
        Me.DateTimePicker_FechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker_FechaNacimiento.Location = New System.Drawing.Point(104, 134)
        Me.DateTimePicker_FechaNacimiento.Name = "DateTimePicker_FechaNacimiento"
        Me.DateTimePicker_FechaNacimiento.Size = New System.Drawing.Size(121, 20)
        Me.DateTimePicker_FechaNacimiento.TabIndex = 24
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(30, 110)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(34, 13)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "Sexo:"
        '
        'ComboBox_Sexo
        '
        Me.ComboBox_Sexo.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.PacientesBindingSource, "Sexo Paciente", True))
        Me.ComboBox_Sexo.DataSource = Me.SexoBindingSource
        Me.ComboBox_Sexo.DisplayMember = "Sexo"
        Me.ComboBox_Sexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_Sexo.Enabled = False
        Me.ComboBox_Sexo.FormattingEnabled = True
        Me.ComboBox_Sexo.Location = New System.Drawing.Point(104, 105)
        Me.ComboBox_Sexo.Name = "ComboBox_Sexo"
        Me.ComboBox_Sexo.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox_Sexo.TabIndex = 26
        Me.ComboBox_Sexo.ValueMember = "ID"
        '
        'SexoBindingSource
        '
        Me.SexoBindingSource.DataMember = "Sexo"
        Me.SexoBindingSource.DataSource = Me.PacientesCOVID191DataSet
        '
        'DateTimePicker_FechaIngreso
        '
        Me.DateTimePicker_FechaIngreso.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PacientesBindingSource, "Fecha de Ingreso", True))
        Me.DateTimePicker_FechaIngreso.Enabled = False
        Me.DateTimePicker_FechaIngreso.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker_FechaIngreso.Location = New System.Drawing.Point(113, 23)
        Me.DateTimePicker_FechaIngreso.Name = "DateTimePicker_FechaIngreso"
        Me.DateTimePicker_FechaIngreso.Size = New System.Drawing.Size(121, 20)
        Me.DateTimePicker_FechaIngreso.TabIndex = 28
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(15, 26)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(92, 13)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "Fecha de ingreso:"
        '
        'ComboBox_Estado
        '
        Me.ComboBox_Estado.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.PacientesBindingSource, "EstadoPaciente", True))
        Me.ComboBox_Estado.DataSource = Me.EstadosBindingSource
        Me.ComboBox_Estado.DisplayMember = "Descripcion"
        Me.ComboBox_Estado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_Estado.Enabled = False
        Me.ComboBox_Estado.FormattingEnabled = True
        Me.ComboBox_Estado.Location = New System.Drawing.Point(113, 52)
        Me.ComboBox_Estado.Name = "ComboBox_Estado"
        Me.ComboBox_Estado.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox_Estado.TabIndex = 30
        Me.ComboBox_Estado.ValueMember = "ID"
        '
        'EstadosBindingSource
        '
        Me.EstadosBindingSource.DataMember = "Estados"
        Me.EstadosBindingSource.DataSource = Me.PacientesCOVID191DataSet
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(37, 58)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(43, 13)
        Me.Label7.TabIndex = 29
        Me.Label7.Text = "Estado:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(24, 93)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(75, 13)
        Me.Label8.TabIndex = 31
        Me.Label8.Text = "Ultimo Estado:"
        '
        'TextBox_FechaCambioEstado
        '
        Me.TextBox_FechaCambioEstado.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PacientesBindingSource, "FechaCambioEstado", True))
        Me.TextBox_FechaCambioEstado.Location = New System.Drawing.Point(113, 133)
        Me.TextBox_FechaCambioEstado.Name = "TextBox_FechaCambioEstado"
        Me.TextBox_FechaCambioEstado.ReadOnly = True
        Me.TextBox_FechaCambioEstado.Size = New System.Drawing.Size(121, 20)
        Me.TextBox_FechaCambioEstado.TabIndex = 34
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(18, 137)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(78, 13)
        Me.Label9.TabIndex = 33
        Me.Label9.Text = "Fecha Cambio:"
        '
        'TextBox_Usuario
        '
        Me.TextBox_Usuario.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PacientesBindingSource, "Usuario", True))
        Me.TextBox_Usuario.Location = New System.Drawing.Point(113, 168)
        Me.TextBox_Usuario.Name = "TextBox_Usuario"
        Me.TextBox_Usuario.ReadOnly = True
        Me.TextBox_Usuario.Size = New System.Drawing.Size(121, 20)
        Me.TextBox_Usuario.TabIndex = 36
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(34, 172)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(46, 13)
        Me.Label10.TabIndex = 35
        Me.Label10.Text = "Usuario:"
        '
        'ComboBox_UltimoEstado
        '
        Me.ComboBox_UltimoEstado.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.PacientesBindingSource, "UltimoEstado", True))
        Me.ComboBox_UltimoEstado.DataSource = Me.EstadosBindingSource1
        Me.ComboBox_UltimoEstado.DisplayMember = "Descripcion"
        Me.ComboBox_UltimoEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_UltimoEstado.Enabled = False
        Me.ComboBox_UltimoEstado.FormattingEnabled = True
        Me.ComboBox_UltimoEstado.Location = New System.Drawing.Point(113, 90)
        Me.ComboBox_UltimoEstado.Name = "ComboBox_UltimoEstado"
        Me.ComboBox_UltimoEstado.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox_UltimoEstado.TabIndex = 37
        Me.ComboBox_UltimoEstado.ValueMember = "ID"
        '
        'EstadosBindingSource1
        '
        Me.EstadosBindingSource1.DataMember = "Estados"
        Me.EstadosBindingSource1.DataSource = Me.PacientesCOVID191DataSet
        '
        'SexoTableAdapter
        '
        Me.SexoTableAdapter.ClearBeforeFill = True
        '
        'EstadosTableAdapter
        '
        Me.EstadosTableAdapter.ClearBeforeFill = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Edadtxt)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TextBox_ID)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TextBox_Nombre)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TextBox_Identidad)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker_FechaNacimiento)
        Me.GroupBox1.Controls.Add(Me.ComboBox_Sexo)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 321)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(251, 207)
        Me.GroupBox1.TabIndex = 38
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos del Paciente"
        '
        'Edadtxt
        '
        Me.Edadtxt.AccessibleName = "Edad"
        Me.Edadtxt.Location = New System.Drawing.Point(103, 168)
        Me.Edadtxt.Name = "Edadtxt"
        Me.Edadtxt.ReadOnly = True
        Me.Edadtxt.Size = New System.Drawing.Size(121, 20)
        Me.Edadtxt.TabIndex = 28
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(30, 175)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(32, 13)
        Me.Label11.TabIndex = 27
        Me.Label11.Text = "Edad"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.ComboBox_Estado)
        Me.GroupBox2.Controls.Add(Me.TextBox_Usuario)
        Me.GroupBox2.Controls.Add(Me.ComboBox_UltimoEstado)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.TextBox_FechaCambioEstado)
        Me.GroupBox2.Controls.Add(Me.DateTimePicker_FechaIngreso)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Location = New System.Drawing.Point(285, 321)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(259, 207)
        Me.GroupBox2.TabIndex = 39
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos Hospitalización"
        '
        'EstadosBindingSource4
        '
        Me.EstadosBindingSource4.DataMember = "Estados"
        Me.EstadosBindingSource4.DataSource = Me.PacientesCOVID191DataSet
        '
        'Button_Agregar_MI
        '
        Me.Button_Agregar_MI.Image = Global.PacientesCOVID19.My.Resources.Resources.addmarcador_16
        Me.Button_Agregar_MI.Location = New System.Drawing.Point(564, 327)
        Me.Button_Agregar_MI.Name = "Button_Agregar_MI"
        Me.Button_Agregar_MI.Size = New System.Drawing.Size(88, 50)
        Me.Button_Agregar_MI.TabIndex = 40
        Me.Button_Agregar_MI.Text = "Agregar Marcador"
        Me.Button_Agregar_MI.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button_Agregar_MI.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Location = New System.Drawing.Point(0, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(686, 70)
        Me.Panel1.TabIndex = 41
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.PacientesCOVID19.My.Resources.Resources.medicalrecord_32
        Me.PictureBox1.Location = New System.Drawing.Point(12, 21)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(36, 29)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(54, 21)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(128, 29)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Pacientes"
        '
        'Pacientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 540)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Button_Agregar_MI)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button_Agregar)
        Me.Controls.Add(Me.Button_Editar)
        Me.Controls.Add(Me.Button_Eliminar)
        Me.Controls.Add(Me.DataGridView_Pacientes)
        Me.Controls.Add(Me.GroupBox_Buscar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Pacientes"
        Me.Text = "Registro de Pacientes"
        Me.GroupBox_Buscar.ResumeLayout(False)
        Me.GroupBox_Buscar.PerformLayout()
        CType(Me.DataGridView_Pacientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SexoBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PacientesCOVID191DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EstadosBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EstadosBindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PacientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SexoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EstadosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EstadosBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.EstadosBindingSource4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox_Buscar As GroupBox
    Friend WithEvents Button_Buscar As Button
    Friend WithEvents TextBox_Buscar As TextBox
    Friend WithEvents Label_Buscar As Label
    Friend WithEvents DataGridView_Pacientes As DataGridView
    Friend WithEvents Button_Agregar As Button
    Friend WithEvents Button_Editar As Button
    Friend WithEvents Button_Eliminar As Button
    Friend WithEvents PacientesCOVID191DataSet As PacientesCOVID191DataSet
    Friend WithEvents PacientesBindingSource As BindingSource
    Friend WithEvents PacientesTableAdapter As PacientesCOVID191DataSetTableAdapters.PacientesTableAdapter
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox_ID As TextBox
    Friend WithEvents TextBox_Nombre As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox_Identidad As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents DateTimePicker_FechaNacimiento As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents ComboBox_Sexo As ComboBox
    Friend WithEvents DateTimePicker_FechaIngreso As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents ComboBox_Estado As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox_FechaCambioEstado As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TextBox_Usuario As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents ComboBox_UltimoEstado As ComboBox
    Friend WithEvents SexoBindingSource As BindingSource
    Friend WithEvents SexoTableAdapter As PacientesCOVID191DataSetTableAdapters.SexoTableAdapter
    Friend WithEvents EstadosBindingSource As BindingSource
    Friend WithEvents EstadosTableAdapter As PacientesCOVID191DataSetTableAdapters.EstadosTableAdapter
    Friend WithEvents EstadosBindingSource1 As BindingSource
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents SexoBindingSource1 As BindingSource
    Friend WithEvents EstadosBindingSource2 As BindingSource
    Friend WithEvents EstadosBindingSource3 As BindingSource
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents EstadosBindingSource4 As BindingSource
    Friend WithEvents Label11 As Label
    Friend WithEvents Edadtxt As TextBox
    Friend WithEvents Button_Agregar_MI As Button
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaNacimientoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SexoPacienteDataGridViewTextBoxColumn As DataGridViewComboBoxColumn
    Friend WithEvents IdentidadDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaDeIngresoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EstadoPacienteDataGridViewTextBoxColumn As DataGridViewComboBoxColumn
    Friend WithEvents UltimoEstadoDataGridViewTextBoxColumn As DataGridViewComboBoxColumn
    Friend WithEvents FechaCambioEstadoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UsuarioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label12 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
