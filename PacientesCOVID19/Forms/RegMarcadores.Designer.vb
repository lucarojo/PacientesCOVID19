<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RegMarcadores
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
        Me.components = New System.ComponentModel.Container()
        Dim IDLabel As System.Windows.Forms.Label
        Dim FechaHoraLabel As System.Windows.Forms.Label
        Dim NombreLabel As System.Windows.Forms.Label
        Dim UsuarioLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Me.PacientesCOVID191DataSet = New PacientesCOVID19.PacientesCOVID191DataSet()
        Me.RegistroMarcadoresInflamatoriosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RegistroMarcadoresInflamatoriosTableAdapter = New PacientesCOVID19.PacientesCOVID191DataSetTableAdapters.RegistroMarcadoresInflamatoriosTableAdapter()
        Me.DetalleRegistroMarcadoresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DetalleRegistroMarcadoresTableAdapter = New PacientesCOVID19.PacientesCOVID191DataSetTableAdapters.DetalleRegistroMarcadoresTableAdapter()
        Me.TableAdapterManager = New PacientesCOVID19.PacientesCOVID191DataSetTableAdapters.TableAdapterManager()
        Me.PacientesTableAdapter = New PacientesCOVID19.PacientesCOVID191DataSetTableAdapters.PacientesTableAdapter()
        Me.DetalleRegistroMarcadoresBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.lblRegistroMarcadores = New System.Windows.Forms.Label()
        Me.lblDetalleMarcadores = New System.Windows.Forms.Label()
        Me.btnAgregarDetalle = New System.Windows.Forms.Button()
        Me.btnEditarDetalle = New System.Windows.Forms.Button()
        Me.btnEliminarDetalle = New System.Windows.Forms.Button()
        Me.DetalleRegistroMarcadoresDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.MarcadoresInflamatoriosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PacientesCOVID191DataSet2 = New PacientesCOVID19.PacientesCOVID191DataSet()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RegistroMarcadoresInflamatoriosTable1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PacientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PacientesRegistroMarcadoresInflamatorios1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PacientesBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.PacientesCOVID191DataSet1 = New PacientesCOVID19.PacientesCOVID191DataSet1()
        Me.RegMarcadoresPacienteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RegMarcadoresPacienteTableAdapter = New PacientesCOVID19.PacientesCOVID191DataSet1TableAdapters.RegMarcadoresPacienteTableAdapter()
        Me.TableAdapterManager1 = New PacientesCOVID19.PacientesCOVID191DataSet1TableAdapters.TableAdapterManager()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.FechaHoraDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.NombreTextBox = New System.Windows.Forms.TextBox()
        Me.UsuarioTextBox = New System.Windows.Forms.TextBox()
        Me.MarcadoresInflamatoriosTableAdapter = New PacientesCOVID19.PacientesCOVID191DataSetTableAdapters.MarcadoresInflamatoriosTableAdapter()
        Me.TextBox_ID_Param = New System.Windows.Forms.TextBox()
        IDLabel = New System.Windows.Forms.Label()
        FechaHoraLabel = New System.Windows.Forms.Label()
        NombreLabel = New System.Windows.Forms.Label()
        UsuarioLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        CType(Me.PacientesCOVID191DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RegistroMarcadoresInflamatoriosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DetalleRegistroMarcadoresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DetalleRegistroMarcadoresBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DetalleRegistroMarcadoresDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MarcadoresInflamatoriosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PacientesCOVID191DataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RegistroMarcadoresInflamatoriosTable1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PacientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PacientesRegistroMarcadoresInflamatorios1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PacientesBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PacientesCOVID191DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RegMarcadoresPacienteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Location = New System.Drawing.Point(21, 44)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(21, 13)
        IDLabel.TabIndex = 9
        IDLabel.Text = "ID:"
        '
        'FechaHoraLabel
        '
        FechaHoraLabel.AutoSize = True
        FechaHoraLabel.Location = New System.Drawing.Point(198, 45)
        FechaHoraLabel.Name = "FechaHoraLabel"
        FechaHoraLabel.Size = New System.Drawing.Size(66, 13)
        FechaHoraLabel.TabIndex = 11
        FechaHoraLabel.Text = "Fecha Hora:"
        AddHandler FechaHoraLabel.Click, AddressOf Me.FechaHoraLabel_Click
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Location = New System.Drawing.Point(26, 89)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(47, 13)
        NombreLabel.TabIndex = 13
        NombreLabel.Text = "Nombre:"
        '
        'UsuarioLabel
        '
        UsuarioLabel.AutoSize = True
        UsuarioLabel.Location = New System.Drawing.Point(27, 124)
        UsuarioLabel.Name = "UsuarioLabel"
        UsuarioLabel.Size = New System.Drawing.Size(46, 13)
        UsuarioLabel.TabIndex = 15
        UsuarioLabel.Text = "Usuario:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(546, 44)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(21, 13)
        Label1.TabIndex = 17
        Label1.Text = "ID:"
        '
        'PacientesCOVID191DataSet
        '
        Me.PacientesCOVID191DataSet.DataSetName = "PacientesCOVID191DataSet"
        Me.PacientesCOVID191DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RegistroMarcadoresInflamatoriosBindingSource
        '
        Me.RegistroMarcadoresInflamatoriosBindingSource.DataMember = "RegistroMarcadoresInflamatorios"
        Me.RegistroMarcadoresInflamatoriosBindingSource.DataSource = Me.PacientesCOVID191DataSet
        '
        'RegistroMarcadoresInflamatoriosTableAdapter
        '
        Me.RegistroMarcadoresInflamatoriosTableAdapter.ClearBeforeFill = True
        '
        'DetalleRegistroMarcadoresBindingSource
        '
        Me.DetalleRegistroMarcadoresBindingSource.DataMember = "DetalleRegistroMarcadores"
        Me.DetalleRegistroMarcadoresBindingSource.DataSource = Me.PacientesCOVID191DataSet
        '
        'DetalleRegistroMarcadoresTableAdapter
        '
        Me.DetalleRegistroMarcadoresTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.DetalleRegistroMarcadoresTableAdapter = Me.DetalleRegistroMarcadoresTableAdapter
        Me.TableAdapterManager.EstadosTableAdapter = Nothing
        Me.TableAdapterManager.EstadosUsuarioTableAdapter = Nothing
        Me.TableAdapterManager.IndicadoresResultadosTableAdapter = Nothing
        Me.TableAdapterManager.MarcadoresInflamatoriosTableAdapter = Nothing
        Me.TableAdapterManager.PacientesTableAdapter = Me.PacientesTableAdapter
        Me.TableAdapterManager.RegistroMarcadoresInflamatoriosTableAdapter = Me.RegistroMarcadoresInflamatoriosTableAdapter
        Me.TableAdapterManager.SexoTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = PacientesCOVID19.PacientesCOVID191DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsersTableAdapter = Nothing
        Me.TableAdapterManager.UsuariosTableAdapter = Nothing
        '
        'PacientesTableAdapter
        '
        Me.PacientesTableAdapter.ClearBeforeFill = True
        '
        'DetalleRegistroMarcadoresBindingSource1
        '
        Me.DetalleRegistroMarcadoresBindingSource1.DataMember = "RegistroMarcadoresInflamatoriosTable1"
        Me.DetalleRegistroMarcadoresBindingSource1.DataSource = Me.RegistroMarcadoresInflamatoriosBindingSource
        '
        'lblRegistroMarcadores
        '
        Me.lblRegistroMarcadores.AutoSize = True
        Me.lblRegistroMarcadores.Location = New System.Drawing.Point(13, 13)
        Me.lblRegistroMarcadores.Name = "lblRegistroMarcadores"
        Me.lblRegistroMarcadores.Size = New System.Drawing.Size(120, 13)
        Me.lblRegistroMarcadores.TabIndex = 0
        Me.lblRegistroMarcadores.Text = "Registro de Marcadores"
        '
        'lblDetalleMarcadores
        '
        Me.lblDetalleMarcadores.AutoSize = True
        Me.lblDetalleMarcadores.Location = New System.Drawing.Point(12, 237)
        Me.lblDetalleMarcadores.Name = "lblDetalleMarcadores"
        Me.lblDetalleMarcadores.Size = New System.Drawing.Size(125, 13)
        Me.lblDetalleMarcadores.TabIndex = 1
        Me.lblDetalleMarcadores.Text = "Marcadores Inflamatorios"
        '
        'btnAgregarDetalle
        '
        Me.btnAgregarDetalle.Location = New System.Drawing.Point(453, 253)
        Me.btnAgregarDetalle.Name = "btnAgregarDetalle"
        Me.btnAgregarDetalle.Size = New System.Drawing.Size(75, 37)
        Me.btnAgregarDetalle.TabIndex = 7
        Me.btnAgregarDetalle.Text = "Agregar Marcador"
        Me.btnAgregarDetalle.UseVisualStyleBackColor = True
        '
        'btnEditarDetalle
        '
        Me.btnEditarDetalle.Location = New System.Drawing.Point(453, 312)
        Me.btnEditarDetalle.Name = "btnEditarDetalle"
        Me.btnEditarDetalle.Size = New System.Drawing.Size(75, 44)
        Me.btnEditarDetalle.TabIndex = 8
        Me.btnEditarDetalle.Text = "Editar Marcador"
        Me.btnEditarDetalle.UseVisualStyleBackColor = True
        '
        'btnEliminarDetalle
        '
        Me.btnEliminarDetalle.Location = New System.Drawing.Point(453, 376)
        Me.btnEliminarDetalle.Name = "btnEliminarDetalle"
        Me.btnEliminarDetalle.Size = New System.Drawing.Size(75, 43)
        Me.btnEliminarDetalle.TabIndex = 9
        Me.btnEliminarDetalle.Text = "Eliminar Marcador"
        Me.btnEliminarDetalle.UseVisualStyleBackColor = True
        '
        'DetalleRegistroMarcadoresDataGridView
        '
        Me.DetalleRegistroMarcadoresDataGridView.AllowUserToAddRows = False
        Me.DetalleRegistroMarcadoresDataGridView.AllowUserToDeleteRows = False
        Me.DetalleRegistroMarcadoresDataGridView.AutoGenerateColumns = False
        Me.DetalleRegistroMarcadoresDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DetalleRegistroMarcadoresDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9})
        Me.DetalleRegistroMarcadoresDataGridView.DataSource = Me.DetalleRegistroMarcadoresBindingSource1
        Me.DetalleRegistroMarcadoresDataGridView.Location = New System.Drawing.Point(16, 253)
        Me.DetalleRegistroMarcadoresDataGridView.Name = "DetalleRegistroMarcadoresDataGridView"
        Me.DetalleRegistroMarcadoresDataGridView.RowHeadersWidth = 10
        Me.DetalleRegistroMarcadoresDataGridView.Size = New System.Drawing.Size(415, 166)
        Me.DetalleRegistroMarcadoresDataGridView.TabIndex = 9
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn5.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Visible = False
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "RegistroMarcadores"
        Me.DataGridViewTextBoxColumn6.HeaderText = "RegistroMarcadores"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Visible = False
        Me.DataGridViewTextBoxColumn6.Width = 150
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "MarcadorInflamatorio"
        Me.DataGridViewTextBoxColumn7.DataSource = Me.MarcadoresInflamatoriosBindingSource
        Me.DataGridViewTextBoxColumn7.DisplayMember = "Marcador Inflamatorio"
        Me.DataGridViewTextBoxColumn7.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox
        Me.DataGridViewTextBoxColumn7.HeaderText = "MarcadorInflamatorio"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn7.ValueMember = "ID"
        Me.DataGridViewTextBoxColumn7.Width = 170
        '
        'MarcadoresInflamatoriosBindingSource
        '
        Me.MarcadoresInflamatoriosBindingSource.DataMember = "MarcadoresInflamatorios"
        Me.MarcadoresInflamatoriosBindingSource.DataSource = Me.PacientesCOVID191DataSet2
        '
        'PacientesCOVID191DataSet2
        '
        Me.PacientesCOVID191DataSet2.DataSetName = "PacientesCOVID191DataSet"
        Me.PacientesCOVID191DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Resultado"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Resultado"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Indicador"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Indicador"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'RegistroMarcadoresInflamatoriosTable1BindingSource
        '
        Me.RegistroMarcadoresInflamatoriosTable1BindingSource.DataMember = "RegistroMarcadoresInflamatoriosTable1"
        Me.RegistroMarcadoresInflamatoriosTable1BindingSource.DataSource = Me.RegistroMarcadoresInflamatoriosBindingSource
        '
        'PacientesBindingSource
        '
        Me.PacientesBindingSource.DataMember = "Pacientes"
        Me.PacientesBindingSource.DataSource = Me.PacientesCOVID191DataSet
        '
        'PacientesRegistroMarcadoresInflamatorios1BindingSource
        '
        Me.PacientesRegistroMarcadoresInflamatorios1BindingSource.DataMember = "PacientesRegistroMarcadoresInflamatorios1"
        Me.PacientesRegistroMarcadoresInflamatorios1BindingSource.DataSource = Me.PacientesBindingSource
        '
        'PacientesBindingSource1
        '
        Me.PacientesBindingSource1.DataMember = "Pacientes"
        Me.PacientesBindingSource1.DataSource = Me.PacientesCOVID191DataSet
        '
        'PacientesCOVID191DataSet1
        '
        Me.PacientesCOVID191DataSet1.DataSetName = "PacientesCOVID191DataSet1"
        Me.PacientesCOVID191DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RegMarcadoresPacienteBindingSource
        '
        Me.RegMarcadoresPacienteBindingSource.DataMember = "RegMarcadoresPaciente"
        Me.RegMarcadoresPacienteBindingSource.DataSource = Me.PacientesCOVID191DataSet1
        '
        'RegMarcadoresPacienteTableAdapter
        '
        Me.RegMarcadoresPacienteTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.Connection = Nothing
        Me.TableAdapterManager1.UpdateOrder = PacientesCOVID19.PacientesCOVID191DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'IDTextBox
        '
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RegMarcadoresPacienteBindingSource, "ID", True))
        Me.IDTextBox.Location = New System.Drawing.Point(48, 41)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IDTextBox.TabIndex = 10
        '
        'FechaHoraDateTimePicker
        '
        Me.FechaHoraDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.RegMarcadoresPacienteBindingSource, "FechaHora", True))
        Me.FechaHoraDateTimePicker.Location = New System.Drawing.Point(270, 41)
        Me.FechaHoraDateTimePicker.Name = "FechaHoraDateTimePicker"
        Me.FechaHoraDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.FechaHoraDateTimePicker.TabIndex = 12
        '
        'NombreTextBox
        '
        Me.NombreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RegMarcadoresPacienteBindingSource, "Nombre", True))
        Me.NombreTextBox.Location = New System.Drawing.Point(79, 86)
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.ReadOnly = True
        Me.NombreTextBox.Size = New System.Drawing.Size(283, 20)
        Me.NombreTextBox.TabIndex = 14
        '
        'UsuarioTextBox
        '
        Me.UsuarioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RegMarcadoresPacienteBindingSource, "Usuario", True))
        Me.UsuarioTextBox.Location = New System.Drawing.Point(79, 121)
        Me.UsuarioTextBox.Name = "UsuarioTextBox"
        Me.UsuarioTextBox.Size = New System.Drawing.Size(100, 20)
        Me.UsuarioTextBox.TabIndex = 16
        '
        'MarcadoresInflamatoriosTableAdapter
        '
        Me.MarcadoresInflamatoriosTableAdapter.ClearBeforeFill = True
        '
        'TextBox_ID_Param
        '
        Me.TextBox_ID_Param.Location = New System.Drawing.Point(573, 42)
        Me.TextBox_ID_Param.Name = "TextBox_ID_Param"
        Me.TextBox_ID_Param.ReadOnly = True
        Me.TextBox_ID_Param.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_ID_Param.TabIndex = 18
        '
        'RegMarcadores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 562)
        Me.Controls.Add(Me.TextBox_ID_Param)
        Me.Controls.Add(Label1)
        Me.Controls.Add(UsuarioLabel)
        Me.Controls.Add(Me.UsuarioTextBox)
        Me.Controls.Add(NombreLabel)
        Me.Controls.Add(Me.NombreTextBox)
        Me.Controls.Add(FechaHoraLabel)
        Me.Controls.Add(Me.FechaHoraDateTimePicker)
        Me.Controls.Add(IDLabel)
        Me.Controls.Add(Me.IDTextBox)
        Me.Controls.Add(Me.DetalleRegistroMarcadoresDataGridView)
        Me.Controls.Add(Me.btnEliminarDetalle)
        Me.Controls.Add(Me.btnEditarDetalle)
        Me.Controls.Add(Me.btnAgregarDetalle)
        Me.Controls.Add(Me.lblDetalleMarcadores)
        Me.Controls.Add(Me.lblRegistroMarcadores)
        Me.Name = "RegMarcadores"
        Me.Text = "Registro de Marcadores Inflamatorios"
        CType(Me.PacientesCOVID191DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RegistroMarcadoresInflamatoriosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DetalleRegistroMarcadoresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DetalleRegistroMarcadoresBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DetalleRegistroMarcadoresDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MarcadoresInflamatoriosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PacientesCOVID191DataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RegistroMarcadoresInflamatoriosTable1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PacientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PacientesRegistroMarcadoresInflamatorios1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PacientesBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PacientesCOVID191DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RegMarcadoresPacienteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PacientesCOVID191DataSet As PacientesCOVID191DataSet
    Friend WithEvents RegistroMarcadoresInflamatoriosBindingSource As BindingSource
    Friend WithEvents RegistroMarcadoresInflamatoriosTableAdapter As PacientesCOVID191DataSetTableAdapters.RegistroMarcadoresInflamatoriosTableAdapter
    Friend WithEvents DetalleRegistroMarcadoresBindingSource As BindingSource
    Friend WithEvents DetalleRegistroMarcadoresTableAdapter As PacientesCOVID191DataSetTableAdapters.DetalleRegistroMarcadoresTableAdapter
    Friend WithEvents TableAdapterManager As PacientesCOVID191DataSetTableAdapters.TableAdapterManager
    Friend WithEvents DetalleRegistroMarcadoresBindingSource1 As BindingSource
    Friend WithEvents lblRegistroMarcadores As Label
    Friend WithEvents lblDetalleMarcadores As Label
    Friend WithEvents btnAgregarDetalle As Button
    Friend WithEvents btnEditarDetalle As Button
    Friend WithEvents btnEliminarDetalle As Button
    Friend WithEvents DetalleRegistroMarcadoresDataGridView As DataGridView
    Friend WithEvents PacientesTableAdapter As PacientesCOVID191DataSetTableAdapters.PacientesTableAdapter
    Friend WithEvents RegistroMarcadoresInflamatoriosTable1BindingSource As BindingSource
    Friend WithEvents PacientesBindingSource As BindingSource
    Friend WithEvents PacientesRegistroMarcadoresInflamatorios1BindingSource As BindingSource
    Friend WithEvents PacientesBindingSource1 As BindingSource
    Friend WithEvents PacientesCOVID191DataSet1 As PacientesCOVID191DataSet1
    Friend WithEvents RegMarcadoresPacienteBindingSource As BindingSource
    Friend WithEvents RegMarcadoresPacienteTableAdapter As PacientesCOVID191DataSet1TableAdapters.RegMarcadoresPacienteTableAdapter
    Friend WithEvents TableAdapterManager1 As PacientesCOVID191DataSet1TableAdapters.TableAdapterManager
    Friend WithEvents IDTextBox As TextBox
    Friend WithEvents FechaHoraDateTimePicker As DateTimePicker
    Friend WithEvents NombreTextBox As TextBox
    Friend WithEvents UsuarioTextBox As TextBox
    Friend WithEvents PacientesCOVID191DataSet2 As PacientesCOVID191DataSet
    Friend WithEvents MarcadoresInflamatoriosBindingSource As BindingSource
    Friend WithEvents MarcadoresInflamatoriosTableAdapter As PacientesCOVID191DataSetTableAdapters.MarcadoresInflamatoriosTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Public WithEvents TextBox_ID_Param As TextBox
End Class
