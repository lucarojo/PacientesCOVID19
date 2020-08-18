<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RepMarcadoresInflamatorios
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
        Me.RegMarcadoresPacienteTableAdapter1 = New PacientesCOVID19.PacientesCOVID191DataSet1TableAdapters.RegMarcadoresPacienteTableAdapter()
        Me.PacientesCOVID191DataSet = New PacientesCOVID19.PacientesCOVID191DataSet()
        Me.DetalleRegistroMarcadoresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DetalleRegistroMarcadoresTableAdapter = New PacientesCOVID19.PacientesCOVID191DataSetTableAdapters.DetalleRegistroMarcadoresTableAdapter()
        Me.PacientesCOVID191DataSet2 = New PacientesCOVID19.PacientesCOVID191DataSet2()
        Me.PacientesCOVID191DataSet2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PacientesCOVID191DataSet2BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DetalleRegistroMarcadoresBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DetalleRegistroMarcadoresTableAdapter1 = New PacientesCOVID19.PacientesCOVID191DataSet2TableAdapters.DetalleRegistroMarcadoresTableAdapter()
        Me.MarcadorInflamatorioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ResultadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DetalleRegistroMarcadoresBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DetalleRegistroMarcadoresBindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.PacientesCOVID191DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DetalleRegistroMarcadoresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PacientesCOVID191DataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PacientesCOVID191DataSet2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PacientesCOVID191DataSet2BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DetalleRegistroMarcadoresBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DetalleRegistroMarcadoresBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DetalleRegistroMarcadoresBindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RegMarcadoresPacienteTableAdapter1
        '
        Me.RegMarcadoresPacienteTableAdapter1.ClearBeforeFill = True
        '
        'PacientesCOVID191DataSet
        '
        Me.PacientesCOVID191DataSet.DataSetName = "PacientesCOVID191DataSet"
        Me.PacientesCOVID191DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'PacientesCOVID191DataSet2
        '
        Me.PacientesCOVID191DataSet2.DataSetName = "PacientesCOVID191DataSet2"
        Me.PacientesCOVID191DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PacientesCOVID191DataSet2BindingSource
        '
        Me.PacientesCOVID191DataSet2BindingSource.DataSource = Me.PacientesCOVID191DataSet2
        Me.PacientesCOVID191DataSet2BindingSource.Position = 0
        '
        'PacientesCOVID191DataSet2BindingSource1
        '
        Me.PacientesCOVID191DataSet2BindingSource1.DataSource = Me.PacientesCOVID191DataSet2
        Me.PacientesCOVID191DataSet2BindingSource1.Position = 0
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MarcadorInflamatorioDataGridViewTextBoxColumn, Me.ResultadoDataGridViewTextBoxColumn, Me.IDDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.DetalleRegistroMarcadoresBindingSource3
        Me.DataGridView1.Location = New System.Drawing.Point(22, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(344, 417)
        Me.DataGridView1.TabIndex = 1
        '
        'DetalleRegistroMarcadoresBindingSource1
        '
        Me.DetalleRegistroMarcadoresBindingSource1.DataMember = "DetalleRegistroMarcadores"
        Me.DetalleRegistroMarcadoresBindingSource1.DataSource = Me.PacientesCOVID191DataSet2BindingSource1
        '
        'DetalleRegistroMarcadoresTableAdapter1
        '
        Me.DetalleRegistroMarcadoresTableAdapter1.ClearBeforeFill = True
        '
        'MarcadorInflamatorioDataGridViewTextBoxColumn
        '
        Me.MarcadorInflamatorioDataGridViewTextBoxColumn.DataPropertyName = "MarcadorInflamatorio"
        Me.MarcadorInflamatorioDataGridViewTextBoxColumn.HeaderText = "MarcadorInflamatorio"
        Me.MarcadorInflamatorioDataGridViewTextBoxColumn.Name = "MarcadorInflamatorioDataGridViewTextBoxColumn"
        '
        'ResultadoDataGridViewTextBoxColumn
        '
        Me.ResultadoDataGridViewTextBoxColumn.DataPropertyName = "Resultado"
        Me.ResultadoDataGridViewTextBoxColumn.HeaderText = "Resultado"
        Me.ResultadoDataGridViewTextBoxColumn.Name = "ResultadoDataGridViewTextBoxColumn"
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        '
        'DetalleRegistroMarcadoresBindingSource2
        '
        Me.DetalleRegistroMarcadoresBindingSource2.DataMember = "DetalleRegistroMarcadores"
        Me.DetalleRegistroMarcadoresBindingSource2.DataSource = Me.PacientesCOVID191DataSet2BindingSource1
        '
        'DetalleRegistroMarcadoresBindingSource3
        '
        Me.DetalleRegistroMarcadoresBindingSource3.DataMember = "DetalleRegistroMarcadores"
        Me.DetalleRegistroMarcadoresBindingSource3.DataSource = Me.PacientesCOVID191DataSet2BindingSource
        '
        'RepMarcadoresInflamatorios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(979, 451)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "RepMarcadoresInflamatorios"
        Me.Text = "Reporte Marcadores Inflamatorios"
        CType(Me.PacientesCOVID191DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DetalleRegistroMarcadoresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PacientesCOVID191DataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PacientesCOVID191DataSet2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PacientesCOVID191DataSet2BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DetalleRegistroMarcadoresBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DetalleRegistroMarcadoresBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DetalleRegistroMarcadoresBindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RegMarcadoresPacienteTableAdapter1 As PacientesCOVID191DataSet1TableAdapters.RegMarcadoresPacienteTableAdapter
    Friend WithEvents PacientesCOVID191DataSet As PacientesCOVID191DataSet
    Friend WithEvents DetalleRegistroMarcadoresBindingSource As BindingSource
    Friend WithEvents DetalleRegistroMarcadoresTableAdapter As PacientesCOVID191DataSetTableAdapters.DetalleRegistroMarcadoresTableAdapter
    Friend WithEvents PacientesCOVID191DataSet2BindingSource As BindingSource
    Friend WithEvents PacientesCOVID191DataSet2 As PacientesCOVID191DataSet2
    Friend WithEvents PacientesCOVID191DataSet2BindingSource1 As BindingSource
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DetalleRegistroMarcadoresBindingSource1 As BindingSource
    Friend WithEvents DetalleRegistroMarcadoresTableAdapter1 As PacientesCOVID191DataSet2TableAdapters.DetalleRegistroMarcadoresTableAdapter
    Friend WithEvents MarcadorInflamatorioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ResultadoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DetalleRegistroMarcadoresBindingSource2 As BindingSource
    Friend WithEvents DetalleRegistroMarcadoresBindingSource3 As BindingSource
End Class
