<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Reporte
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button_Buscar = New System.Windows.Forms.Button()
        Me.DateTimePicker_Hasta = New System.Windows.Forms.DateTimePicker()
        Me.Label_Hasta = New System.Windows.Forms.Label()
        Me.DateTimePicker_Desde = New System.Windows.Forms.DateTimePicker()
        Me.Label_Desde = New System.Windows.Forms.Label()
        Me.CheckBox_FechaHora = New System.Windows.Forms.CheckBox()
        Me.ComboBox_MarcadorInflam = New System.Windows.Forms.ComboBox()
        Me.MarcadoresInflamatoriosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PacientesCOVID191DataSet = New PacientesCOVID19.PacientesCOVID191DataSet()
        Me.CheckBox_MarcadorInflam = New System.Windows.Forms.CheckBox()
        Me.TextBox_Paciente = New System.Windows.Forms.TextBox()
        Me.Label_Paciente = New System.Windows.Forms.Label()
        Me.DataGridView_Reporte = New System.Windows.Forms.DataGridView()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaDeNacimiento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaDeIngreso = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MarcadorInflamatorio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Resultado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaHora = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Edad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DiasDeIngreso = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button_Exportar = New System.Windows.Forms.Button()
        Me.MarcadoresInflamatoriosTableAdapter = New PacientesCOVID19.PacientesCOVID191DataSetTableAdapters.MarcadoresInflamatoriosTableAdapter()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.GroupBox1.SuspendLayout()
        CType(Me.MarcadoresInflamatoriosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PacientesCOVID191DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView_Reporte, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button_Buscar)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker_Hasta)
        Me.GroupBox1.Controls.Add(Me.Label_Hasta)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker_Desde)
        Me.GroupBox1.Controls.Add(Me.Label_Desde)
        Me.GroupBox1.Controls.Add(Me.CheckBox_FechaHora)
        Me.GroupBox1.Controls.Add(Me.ComboBox_MarcadorInflam)
        Me.GroupBox1.Controls.Add(Me.CheckBox_MarcadorInflam)
        Me.GroupBox1.Controls.Add(Me.TextBox_Paciente)
        Me.GroupBox1.Controls.Add(Me.Label_Paciente)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(776, 100)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filtros de búsqueda"
        '
        'Button_Buscar
        '
        Me.Button_Buscar.Image = Global.PacientesCOVID19.My.Resources.Resources.buscar_16
        Me.Button_Buscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button_Buscar.Location = New System.Drawing.Point(695, 26)
        Me.Button_Buscar.Name = "Button_Buscar"
        Me.Button_Buscar.Size = New System.Drawing.Size(75, 23)
        Me.Button_Buscar.TabIndex = 9
        Me.Button_Buscar.Text = "Buscar"
        Me.Button_Buscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button_Buscar.UseVisualStyleBackColor = True
        '
        'DateTimePicker_Hasta
        '
        Me.DateTimePicker_Hasta.Enabled = False
        Me.DateTimePicker_Hasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker_Hasta.Location = New System.Drawing.Point(520, 56)
        Me.DateTimePicker_Hasta.Name = "DateTimePicker_Hasta"
        Me.DateTimePicker_Hasta.Size = New System.Drawing.Size(95, 20)
        Me.DateTimePicker_Hasta.TabIndex = 8
        '
        'Label_Hasta
        '
        Me.Label_Hasta.AutoSize = True
        Me.Label_Hasta.Enabled = False
        Me.Label_Hasta.Location = New System.Drawing.Point(473, 59)
        Me.Label_Hasta.Name = "Label_Hasta"
        Me.Label_Hasta.Size = New System.Drawing.Size(38, 13)
        Me.Label_Hasta.TabIndex = 7
        Me.Label_Hasta.Text = "Hasta:"
        '
        'DateTimePicker_Desde
        '
        Me.DateTimePicker_Desde.Enabled = False
        Me.DateTimePicker_Desde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker_Desde.Location = New System.Drawing.Point(372, 56)
        Me.DateTimePicker_Desde.Name = "DateTimePicker_Desde"
        Me.DateTimePicker_Desde.Size = New System.Drawing.Size(95, 20)
        Me.DateTimePicker_Desde.TabIndex = 6
        '
        'Label_Desde
        '
        Me.Label_Desde.AutoSize = True
        Me.Label_Desde.Enabled = False
        Me.Label_Desde.Location = New System.Drawing.Point(325, 59)
        Me.Label_Desde.Name = "Label_Desde"
        Me.Label_Desde.Size = New System.Drawing.Size(41, 13)
        Me.Label_Desde.TabIndex = 5
        Me.Label_Desde.Text = "Desde:"
        '
        'CheckBox_FechaHora
        '
        Me.CheckBox_FechaHora.AutoSize = True
        Me.CheckBox_FechaHora.Location = New System.Drawing.Point(271, 58)
        Me.CheckBox_FechaHora.Name = "CheckBox_FechaHora"
        Me.CheckBox_FechaHora.Size = New System.Drawing.Size(59, 17)
        Me.CheckBox_FechaHora.TabIndex = 4
        Me.CheckBox_FechaHora.Text = "Fecha:"
        Me.CheckBox_FechaHora.UseVisualStyleBackColor = True
        '
        'ComboBox_MarcadorInflam
        '
        Me.ComboBox_MarcadorInflam.DataSource = Me.MarcadoresInflamatoriosBindingSource
        Me.ComboBox_MarcadorInflam.DisplayMember = "Marcador Inflamatorio"
        Me.ComboBox_MarcadorInflam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_MarcadorInflam.Enabled = False
        Me.ComboBox_MarcadorInflam.FormattingEnabled = True
        Me.ComboBox_MarcadorInflam.Location = New System.Drawing.Point(143, 56)
        Me.ComboBox_MarcadorInflam.Name = "ComboBox_MarcadorInflam"
        Me.ComboBox_MarcadorInflam.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox_MarcadorInflam.TabIndex = 3
        Me.ComboBox_MarcadorInflam.ValueMember = "ID"
        '
        'MarcadoresInflamatoriosBindingSource
        '
        Me.MarcadoresInflamatoriosBindingSource.DataMember = "MarcadoresInflamatorios"
        Me.MarcadoresInflamatoriosBindingSource.DataSource = Me.PacientesCOVID191DataSet
        '
        'PacientesCOVID191DataSet
        '
        Me.PacientesCOVID191DataSet.DataSetName = "PacientesCOVID191DataSet"
        Me.PacientesCOVID191DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CheckBox_MarcadorInflam
        '
        Me.CheckBox_MarcadorInflam.AutoSize = True
        Me.CheckBox_MarcadorInflam.Location = New System.Drawing.Point(6, 58)
        Me.CheckBox_MarcadorInflam.Name = "CheckBox_MarcadorInflam"
        Me.CheckBox_MarcadorInflam.Size = New System.Drawing.Size(131, 17)
        Me.CheckBox_MarcadorInflam.TabIndex = 2
        Me.CheckBox_MarcadorInflam.Text = "Marcador Inflamatorio:"
        Me.CheckBox_MarcadorInflam.UseVisualStyleBackColor = True
        '
        'TextBox_Paciente
        '
        Me.TextBox_Paciente.Location = New System.Drawing.Point(196, 28)
        Me.TextBox_Paciente.Name = "TextBox_Paciente"
        Me.TextBox_Paciente.Size = New System.Drawing.Size(493, 20)
        Me.TextBox_Paciente.TabIndex = 1
        '
        'Label_Paciente
        '
        Me.Label_Paciente.AutoSize = True
        Me.Label_Paciente.Location = New System.Drawing.Point(6, 31)
        Me.Label_Paciente.Name = "Label_Paciente"
        Me.Label_Paciente.Size = New System.Drawing.Size(184, 13)
        Me.Label_Paciente.TabIndex = 0
        Me.Label_Paciente.Text = "Buscar Paciente (Nombre, Identidad):"
        '
        'DataGridView_Reporte
        '
        Me.DataGridView_Reporte.AllowUserToAddRows = False
        Me.DataGridView_Reporte.AllowUserToDeleteRows = False
        Me.DataGridView_Reporte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_Reporte.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Nombre, Me.FechaDeNacimiento, Me.FechaDeIngreso, Me.MarcadorInflamatorio, Me.Resultado, Me.FechaHora, Me.Edad, Me.DiasDeIngreso})
        Me.DataGridView_Reporte.Location = New System.Drawing.Point(12, 118)
        Me.DataGridView_Reporte.Name = "DataGridView_Reporte"
        Me.DataGridView_Reporte.ReadOnly = True
        Me.DataGridView_Reporte.RowHeadersWidth = 10
        Me.DataGridView_Reporte.Size = New System.Drawing.Size(776, 274)
        Me.DataGridView_Reporte.TabIndex = 1
        '
        'Nombre
        '
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
        Me.Nombre.ReadOnly = True
        '
        'FechaDeNacimiento
        '
        Me.FechaDeNacimiento.HeaderText = "Fecha de Nacimiento"
        Me.FechaDeNacimiento.Name = "FechaDeNacimiento"
        Me.FechaDeNacimiento.ReadOnly = True
        '
        'FechaDeIngreso
        '
        Me.FechaDeIngreso.HeaderText = "Fecha de Ingreso"
        Me.FechaDeIngreso.Name = "FechaDeIngreso"
        Me.FechaDeIngreso.ReadOnly = True
        '
        'MarcadorInflamatorio
        '
        Me.MarcadorInflamatorio.HeaderText = "Marcador Inflamatorio"
        Me.MarcadorInflamatorio.Name = "MarcadorInflamatorio"
        Me.MarcadorInflamatorio.ReadOnly = True
        '
        'Resultado
        '
        Me.Resultado.HeaderText = "Resultado"
        Me.Resultado.Name = "Resultado"
        Me.Resultado.ReadOnly = True
        '
        'FechaHora
        '
        Me.FechaHora.HeaderText = "Fecha y Hora"
        Me.FechaHora.Name = "FechaHora"
        Me.FechaHora.ReadOnly = True
        '
        'Edad
        '
        Me.Edad.HeaderText = "Edad"
        Me.Edad.Name = "Edad"
        Me.Edad.ReadOnly = True
        '
        'DiasDeIngreso
        '
        Me.DiasDeIngreso.HeaderText = "Dias de Ingreso"
        Me.DiasDeIngreso.Name = "DiasDeIngreso"
        Me.DiasDeIngreso.ReadOnly = True
        '
        'Button_Exportar
        '
        Me.Button_Exportar.Image = Global.PacientesCOVID19.My.Resources.Resources.export_16
        Me.Button_Exportar.Location = New System.Drawing.Point(713, 398)
        Me.Button_Exportar.Name = "Button_Exportar"
        Me.Button_Exportar.Size = New System.Drawing.Size(75, 40)
        Me.Button_Exportar.TabIndex = 10
        Me.Button_Exportar.Text = "Exportar"
        Me.Button_Exportar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button_Exportar.UseVisualStyleBackColor = True
        '
        'MarcadoresInflamatoriosTableAdapter
        '
        Me.MarcadoresInflamatoriosTableAdapter.ClearBeforeFill = True
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(607, 407)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(100, 23)
        Me.ProgressBar1.TabIndex = 11
        Me.ProgressBar1.Visible = False
        '
        'Reporte
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.Button_Exportar)
        Me.Controls.Add(Me.DataGridView_Reporte)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Reporte"
        Me.Text = "Reporte"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.MarcadoresInflamatoriosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PacientesCOVID191DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView_Reporte, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DataGridView_Reporte As DataGridView
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents FechaDeNacimiento As DataGridViewTextBoxColumn
    Friend WithEvents FechaDeIngreso As DataGridViewTextBoxColumn
    Friend WithEvents MarcadorInflamatorio As DataGridViewTextBoxColumn
    Friend WithEvents Resultado As DataGridViewTextBoxColumn
    Friend WithEvents FechaHora As DataGridViewTextBoxColumn
    Friend WithEvents Edad As DataGridViewTextBoxColumn
    Friend WithEvents DiasDeIngreso As DataGridViewTextBoxColumn
    Friend WithEvents TextBox_Paciente As TextBox
    Friend WithEvents Label_Paciente As Label
    Friend WithEvents CheckBox_MarcadorInflam As CheckBox
    Friend WithEvents Label_Desde As Label
    Friend WithEvents CheckBox_FechaHora As CheckBox
    Friend WithEvents ComboBox_MarcadorInflam As ComboBox
    Friend WithEvents DateTimePicker_Hasta As DateTimePicker
    Friend WithEvents Label_Hasta As Label
    Friend WithEvents DateTimePicker_Desde As DateTimePicker
    Friend WithEvents Button_Buscar As Button
    Friend WithEvents Button_Exportar As Button
    Friend WithEvents PacientesCOVID191DataSet As PacientesCOVID191DataSet
    Friend WithEvents MarcadoresInflamatoriosBindingSource As BindingSource
    Friend WithEvents MarcadoresInflamatoriosTableAdapter As PacientesCOVID191DataSetTableAdapters.MarcadoresInflamatoriosTableAdapter
    Friend WithEvents ProgressBar1 As ProgressBar
End Class
