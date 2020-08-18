<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class NuevoRegMarcadores
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NuevoRegMarcadores))
        Me.TextBox_ID_Param = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TextBox_PacienteEdad = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox_PacienteFechaNacimiento_param = New System.Windows.Forms.TextBox()
        Me.PacientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PacientesCOVID191DataSet = New PacientesCOVID19.PacientesCOVID191DataSet()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox_PacienteIdentidad_param = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox_PacienteNombre_param = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox_PacienteID_param = New System.Windows.Forms.TextBox()
        Me.RegistroMarcadoresInflamatoriosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DateTimePicker_FechaHora_RMI = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox_ID_RMI = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.MarcadoresInflamatoriosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DetalleRegistroMarcadoresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DetalleRegistroMarcadoresTableAdapter = New PacientesCOVID19.PacientesCOVID191DataSetTableAdapters.DetalleRegistroMarcadoresTableAdapter()
        Me.RegistroMarcadoresInflamatoriosTableAdapter = New PacientesCOVID19.PacientesCOVID191DataSetTableAdapters.RegistroMarcadoresInflamatoriosTableAdapter()
        Me.PacientesTableAdapter = New PacientesCOVID19.PacientesCOVID191DataSetTableAdapters.PacientesTableAdapter()
        Me.MarcadoresInflamatoriosTableAdapter = New PacientesCOVID19.PacientesCOVID191DataSetTableAdapters.MarcadoresInflamatoriosTableAdapter()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Button_Buscar = New System.Windows.Forms.Button()
        Me.Button_Salvar = New System.Windows.Forms.Button()
        Me.TableAdapterManager = New PacientesCOVID19.PacientesCOVID191DataSetTableAdapters.TableAdapterManager()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RegistroMarcadoresDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MarcadorInflamatorioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.ResultadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PacientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PacientesCOVID191DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RegistroMarcadoresInflamatoriosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MarcadoresInflamatoriosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DetalleRegistroMarcadoresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBox_ID_Param
        '
        Me.TextBox_ID_Param.Location = New System.Drawing.Point(110, 22)
        Me.TextBox_ID_Param.Name = "TextBox_ID_Param"
        Me.TextBox_ID_Param.ReadOnly = True
        Me.TextBox_ID_Param.Size = New System.Drawing.Size(56, 20)
        Me.TextBox_ID_Param.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextBox_PacienteEdad)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TextBox_PacienteFechaNacimiento_param)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TextBox_PacienteIdentidad_param)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TextBox_PacienteNombre_param)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TextBox_PacienteID_param)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 116)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(308, 151)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Información del Paciente"
        '
        'TextBox_PacienteEdad
        '
        Me.TextBox_PacienteEdad.Location = New System.Drawing.Point(172, 112)
        Me.TextBox_PacienteEdad.Name = "TextBox_PacienteEdad"
        Me.TextBox_PacienteEdad.ReadOnly = True
        Me.TextBox_PacienteEdad.Size = New System.Drawing.Size(125, 20)
        Me.TextBox_PacienteEdad.TabIndex = 9
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(169, 96)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(35, 13)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Edad:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 96)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(109, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Fecha de nacimiento:"
        '
        'TextBox_PacienteFechaNacimiento_param
        '
        Me.TextBox_PacienteFechaNacimiento_param.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PacientesBindingSource, "Fecha Nacimiento", True))
        Me.TextBox_PacienteFechaNacimiento_param.Location = New System.Drawing.Point(11, 112)
        Me.TextBox_PacienteFechaNacimiento_param.Name = "TextBox_PacienteFechaNacimiento_param"
        Me.TextBox_PacienteFechaNacimiento_param.ReadOnly = True
        Me.TextBox_PacienteFechaNacimiento_param.Size = New System.Drawing.Size(138, 20)
        Me.TextBox_PacienteFechaNacimiento_param.TabIndex = 6
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
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(112, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Identidad:"
        '
        'TextBox_PacienteIdentidad_param
        '
        Me.TextBox_PacienteIdentidad_param.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PacientesBindingSource, "Identidad", True))
        Me.TextBox_PacienteIdentidad_param.Location = New System.Drawing.Point(115, 38)
        Me.TextBox_PacienteIdentidad_param.Name = "TextBox_PacienteIdentidad_param"
        Me.TextBox_PacienteIdentidad_param.ReadOnly = True
        Me.TextBox_PacienteIdentidad_param.Size = New System.Drawing.Size(143, 20)
        Me.TextBox_PacienteIdentidad_param.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Nombre:"
        '
        'TextBox_PacienteNombre_param
        '
        Me.TextBox_PacienteNombre_param.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PacientesBindingSource, "Nombre", True))
        Me.TextBox_PacienteNombre_param.Location = New System.Drawing.Point(11, 74)
        Me.TextBox_PacienteNombre_param.Name = "TextBox_PacienteNombre_param"
        Me.TextBox_PacienteNombre_param.ReadOnly = True
        Me.TextBox_PacienteNombre_param.Size = New System.Drawing.Size(247, 20)
        Me.TextBox_PacienteNombre_param.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Id. Paciente"
        '
        'TextBox_PacienteID_param
        '
        Me.TextBox_PacienteID_param.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RegistroMarcadoresInflamatoriosBindingSource, "Paciente", True))
        Me.TextBox_PacienteID_param.Location = New System.Drawing.Point(11, 37)
        Me.TextBox_PacienteID_param.Name = "TextBox_PacienteID_param"
        Me.TextBox_PacienteID_param.ReadOnly = True
        Me.TextBox_PacienteID_param.Size = New System.Drawing.Size(83, 20)
        Me.TextBox_PacienteID_param.TabIndex = 0
        '
        'RegistroMarcadoresInflamatoriosBindingSource
        '
        Me.RegistroMarcadoresInflamatoriosBindingSource.DataMember = "RegistroMarcadoresInflamatorios"
        Me.RegistroMarcadoresInflamatoriosBindingSource.DataSource = Me.PacientesCOVID191DataSet
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.DateTimePicker_FechaHora_RMI)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.TextBox_ID_RMI)
        Me.GroupBox2.Controls.Add(Me.TextBox_ID_Param)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 54)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(308, 56)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Registro de Marcador Inflamatorio"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 25)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Fecha y Hora:"
        '
        'DateTimePicker_FechaHora_RMI
        '
        Me.DateTimePicker_FechaHora_RMI.CustomFormat = "dd/MM/yyyy hh:mm"
        Me.DateTimePicker_FechaHora_RMI.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.RegistroMarcadoresInflamatoriosBindingSource, "FechaHora", True))
        Me.DateTimePicker_FechaHora_RMI.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker_FechaHora_RMI.Location = New System.Drawing.Point(86, 22)
        Me.DateTimePicker_FechaHora_RMI.Name = "DateTimePicker_FechaHora_RMI"
        Me.DateTimePicker_FechaHora_RMI.Size = New System.Drawing.Size(172, 20)
        Me.DateTimePicker_FechaHora_RMI.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(96, 25)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(21, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "ID:"
        Me.Label5.Visible = False
        '
        'TextBox_ID_RMI
        '
        Me.TextBox_ID_RMI.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RegistroMarcadoresInflamatoriosBindingSource, "ID", True))
        Me.TextBox_ID_RMI.Location = New System.Drawing.Point(135, 22)
        Me.TextBox_ID_RMI.Name = "TextBox_ID_RMI"
        Me.TextBox_ID_RMI.ReadOnly = True
        Me.TextBox_ID_RMI.Size = New System.Drawing.Size(47, 20)
        Me.TextBox_ID_RMI.TabIndex = 9
        Me.TextBox_ID_RMI.Visible = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.RegistroMarcadoresDataGridViewTextBoxColumn, Me.MarcadorInflamatorioDataGridViewTextBoxColumn, Me.ResultadoDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.DetalleRegistroMarcadoresBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(326, 88)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(334, 244)
        Me.DataGridView1.TabIndex = 8
        '
        'MarcadoresInflamatoriosBindingSource
        '
        Me.MarcadoresInflamatoriosBindingSource.DataMember = "MarcadoresInflamatorios"
        Me.MarcadoresInflamatoriosBindingSource.DataSource = Me.PacientesCOVID191DataSet
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
        'RegistroMarcadoresInflamatoriosTableAdapter
        '
        Me.RegistroMarcadoresInflamatoriosTableAdapter.ClearBeforeFill = True
        '
        'PacientesTableAdapter
        '
        Me.PacientesTableAdapter.ClearBeforeFill = True
        '
        'MarcadoresInflamatoriosTableAdapter
        '
        Me.MarcadoresInflamatoriosTableAdapter.ClearBeforeFill = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Location = New System.Drawing.Point(1, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(752, 48)
        Me.Panel1.TabIndex = 9
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.PacientesCOVID19.My.Resources.Resources.listicon_32
        Me.PictureBox1.Location = New System.Drawing.Point(9, 9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(35, 36)
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(41, 9)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(451, 29)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Registro de Marcadores Inflamatorios"
        '
        'Button_Buscar
        '
        Me.Button_Buscar.Image = Global.PacientesCOVID19.My.Resources.Resources.deshacer_16
        Me.Button_Buscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button_Buscar.Location = New System.Drawing.Point(474, 54)
        Me.Button_Buscar.Name = "Button_Buscar"
        Me.Button_Buscar.Size = New System.Drawing.Size(186, 27)
        Me.Button_Buscar.TabIndex = 8
        Me.Button_Buscar.Text = "Cargar Marcadores Inflamatorios"
        Me.Button_Buscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button_Buscar.UseVisualStyleBackColor = True
        '
        'Button_Salvar
        '
        Me.Button_Salvar.Image = Global.PacientesCOVID19.My.Resources.Resources.salvar_16
        Me.Button_Salvar.Location = New System.Drawing.Point(73, 272)
        Me.Button_Salvar.Name = "Button_Salvar"
        Me.Button_Salvar.Size = New System.Drawing.Size(88, 37)
        Me.Button_Salvar.TabIndex = 10
        Me.Button_Salvar.Text = "Guardar"
        Me.Button_Salvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button_Salvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button_Salvar.UseVisualStyleBackColor = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.DetalleRegistroMarcadoresTableAdapter = Me.DetalleRegistroMarcadoresTableAdapter
        Me.TableAdapterManager.EstadosTableAdapter = Nothing
        Me.TableAdapterManager.EstadosUsuarioTableAdapter = Nothing
        Me.TableAdapterManager.IndicadoresResultadosTableAdapter = Nothing
        Me.TableAdapterManager.MarcadoresInflamatoriosTableAdapter = Nothing
        Me.TableAdapterManager.PacientesTableAdapter = Nothing
        Me.TableAdapterManager.RegistroMarcadoresInflamatoriosTableAdapter = Nothing
        Me.TableAdapterManager.SexoTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = PacientesCOVID19.PacientesCOVID191DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsersTableAdapter = Nothing
        Me.TableAdapterManager.UsuariosTableAdapter = Nothing
        '
        'btnCancelar
        '
        Me.btnCancelar.Image = Global.PacientesCOVID19.My.Resources.Resources.delete_16
        Me.btnCancelar.Location = New System.Drawing.Point(182, 273)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(88, 36)
        Me.btnCancelar.TabIndex = 11
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.Visible = False
        '
        'RegistroMarcadoresDataGridViewTextBoxColumn
        '
        Me.RegistroMarcadoresDataGridViewTextBoxColumn.DataPropertyName = "RegistroMarcadores"
        Me.RegistroMarcadoresDataGridViewTextBoxColumn.HeaderText = "RegistroMarcadores"
        Me.RegistroMarcadoresDataGridViewTextBoxColumn.Name = "RegistroMarcadoresDataGridViewTextBoxColumn"
        Me.RegistroMarcadoresDataGridViewTextBoxColumn.Visible = False
        '
        'MarcadorInflamatorioDataGridViewTextBoxColumn
        '
        Me.MarcadorInflamatorioDataGridViewTextBoxColumn.DataPropertyName = "MarcadorInflamatorio"
        Me.MarcadorInflamatorioDataGridViewTextBoxColumn.DataSource = Me.MarcadoresInflamatoriosBindingSource
        Me.MarcadorInflamatorioDataGridViewTextBoxColumn.DisplayMember = "Marcador Inflamatorio"
        Me.MarcadorInflamatorioDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.MarcadorInflamatorioDataGridViewTextBoxColumn.HeaderText = "Marcador Inflamatorio"
        Me.MarcadorInflamatorioDataGridViewTextBoxColumn.Name = "MarcadorInflamatorioDataGridViewTextBoxColumn"
        Me.MarcadorInflamatorioDataGridViewTextBoxColumn.ReadOnly = True
        Me.MarcadorInflamatorioDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MarcadorInflamatorioDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.MarcadorInflamatorioDataGridViewTextBoxColumn.ValueMember = "ID"
        Me.MarcadorInflamatorioDataGridViewTextBoxColumn.Width = 190
        '
        'ResultadoDataGridViewTextBoxColumn
        '
        Me.ResultadoDataGridViewTextBoxColumn.DataPropertyName = "Resultado"
        Me.ResultadoDataGridViewTextBoxColumn.HeaderText = "Resultado"
        Me.ResultadoDataGridViewTextBoxColumn.Name = "ResultadoDataGridViewTextBoxColumn"
        '
        'NuevoRegMarcadores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(671, 343)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.Button_Salvar)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Button_Buscar)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "NuevoRegMarcadores"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registro de Marcadores Inflamatorios"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PacientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PacientesCOVID191DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RegistroMarcadoresInflamatoriosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MarcadoresInflamatoriosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DetalleRegistroMarcadoresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TextBox_ID_Param As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button_Buscar As Button
    Friend WithEvents Label4 As Label
    Public WithEvents TextBox_PacienteFechaNacimiento_param As TextBox
    Friend WithEvents Label3 As Label
    Public WithEvents TextBox_PacienteIdentidad_param As TextBox
    Friend WithEvents Label2 As Label
    Public WithEvents TextBox_PacienteNombre_param As TextBox
    Friend WithEvents Label1 As Label
    Public WithEvents TextBox_PacienteID_param As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Public WithEvents TextBox_ID_RMI As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents PacientesCOVID191DataSet As PacientesCOVID191DataSet
    Friend WithEvents DetalleRegistroMarcadoresBindingSource As BindingSource
    Friend WithEvents DetalleRegistroMarcadoresTableAdapter As PacientesCOVID191DataSetTableAdapters.DetalleRegistroMarcadoresTableAdapter
    Friend WithEvents RegistroMarcadoresInflamatoriosBindingSource As BindingSource
    Friend WithEvents RegistroMarcadoresInflamatoriosTableAdapter As PacientesCOVID191DataSetTableAdapters.RegistroMarcadoresInflamatoriosTableAdapter
    Friend WithEvents PacientesBindingSource As BindingSource
    Friend WithEvents PacientesTableAdapter As PacientesCOVID191DataSetTableAdapters.PacientesTableAdapter
    Friend WithEvents MarcadoresInflamatoriosBindingSource As BindingSource
    Friend WithEvents MarcadoresInflamatoriosTableAdapter As PacientesCOVID191DataSetTableAdapters.MarcadoresInflamatoriosTableAdapter
    Friend WithEvents DateTimePicker_FechaHora_RMI As DateTimePicker
    Friend WithEvents TextBox_PacienteEdad As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents Button_Salvar As Button
    Friend WithEvents TableAdapterManager As PacientesCOVID191DataSetTableAdapters.TableAdapterManager
    Friend WithEvents btnCancelar As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RegistroMarcadoresDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MarcadorInflamatorioDataGridViewTextBoxColumn As DataGridViewComboBoxColumn
    Friend WithEvents ResultadoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
