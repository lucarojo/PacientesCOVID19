<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Sexos
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
        Me.DataGridView_Sexos = New System.Windows.Forms.DataGridView()
        Me.Button_Agregar = New System.Windows.Forms.Button()
        Me.Button_Editar = New System.Windows.Forms.Button()
        Me.Button_Eliminar = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox_ID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox_Sexo = New System.Windows.Forms.TextBox()
        Me.SexoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PacientesCOVID191DataSet = New PacientesCOVID19.PacientesCOVID191DataSet()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SexoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SexoTableAdapter = New PacientesCOVID19.PacientesCOVID191DataSetTableAdapters.SexoTableAdapter()
        CType(Me.DataGridView_Sexos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SexoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PacientesCOVID191DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView_Sexos
        '
        Me.DataGridView_Sexos.AllowUserToAddRows = False
        Me.DataGridView_Sexos.AllowUserToDeleteRows = False
        Me.DataGridView_Sexos.AutoGenerateColumns = False
        Me.DataGridView_Sexos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_Sexos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.SexoDataGridViewTextBoxColumn})
        Me.DataGridView_Sexos.DataSource = Me.SexoBindingSource
        Me.DataGridView_Sexos.Location = New System.Drawing.Point(12, 12)
        Me.DataGridView_Sexos.Name = "DataGridView_Sexos"
        Me.DataGridView_Sexos.ReadOnly = True
        Me.DataGridView_Sexos.RowHeadersWidth = 10
        Me.DataGridView_Sexos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView_Sexos.Size = New System.Drawing.Size(254, 150)
        Me.DataGridView_Sexos.TabIndex = 0
        '
        'Button_Agregar
        '
        Me.Button_Agregar.Location = New System.Drawing.Point(29, 235)
        Me.Button_Agregar.Name = "Button_Agregar"
        Me.Button_Agregar.Size = New System.Drawing.Size(75, 23)
        Me.Button_Agregar.TabIndex = 16
        Me.Button_Agregar.Text = "Agregar"
        Me.Button_Agregar.UseVisualStyleBackColor = True
        '
        'Button_Editar
        '
        Me.Button_Editar.Location = New System.Drawing.Point(110, 235)
        Me.Button_Editar.Name = "Button_Editar"
        Me.Button_Editar.Size = New System.Drawing.Size(75, 23)
        Me.Button_Editar.TabIndex = 15
        Me.Button_Editar.Text = "Editar"
        Me.Button_Editar.UseVisualStyleBackColor = True
        '
        'Button_Eliminar
        '
        Me.Button_Eliminar.Location = New System.Drawing.Point(191, 235)
        Me.Button_Eliminar.Name = "Button_Eliminar"
        Me.Button_Eliminar.Size = New System.Drawing.Size(75, 23)
        Me.Button_Eliminar.TabIndex = 14
        Me.Button_Eliminar.Text = "Eliminar"
        Me.Button_Eliminar.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(32, 171)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(21, 13)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "ID:"
        '
        'TextBox_ID
        '
        Me.TextBox_ID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SexoBindingSource, "ID", True))
        Me.TextBox_ID.Location = New System.Drawing.Point(59, 168)
        Me.TextBox_ID.MaxLength = 50
        Me.TextBox_ID.Name = "TextBox_ID"
        Me.TextBox_ID.ReadOnly = True
        Me.TextBox_ID.Size = New System.Drawing.Size(41, 20)
        Me.TextBox_ID.TabIndex = 17
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 197)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 13)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Sexo:"
        '
        'TextBox_Sexo
        '
        Me.TextBox_Sexo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SexoBindingSource, "Sexo", True))
        Me.TextBox_Sexo.Location = New System.Drawing.Point(59, 194)
        Me.TextBox_Sexo.MaxLength = 20
        Me.TextBox_Sexo.Name = "TextBox_Sexo"
        Me.TextBox_Sexo.ReadOnly = True
        Me.TextBox_Sexo.Size = New System.Drawing.Size(110, 20)
        Me.TextBox_Sexo.TabIndex = 19
        '
        'SexoBindingSource
        '
        Me.SexoBindingSource.DataMember = "Sexo"
        Me.SexoBindingSource.DataSource = Me.PacientesCOVID191DataSet
        '
        'PacientesCOVID191DataSet
        '
        Me.PacientesCOVID191DataSet.DataSetName = "PacientesCOVID191DataSet"
        Me.PacientesCOVID191DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SexoDataGridViewTextBoxColumn
        '
        Me.SexoDataGridViewTextBoxColumn.DataPropertyName = "Sexo"
        Me.SexoDataGridViewTextBoxColumn.HeaderText = "Sexo"
        Me.SexoDataGridViewTextBoxColumn.Name = "SexoDataGridViewTextBoxColumn"
        Me.SexoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SexoTableAdapter
        '
        Me.SexoTableAdapter.ClearBeforeFill = True
        '
        'Sexos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(278, 270)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox_Sexo)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextBox_ID)
        Me.Controls.Add(Me.Button_Agregar)
        Me.Controls.Add(Me.Button_Editar)
        Me.Controls.Add(Me.Button_Eliminar)
        Me.Controls.Add(Me.DataGridView_Sexos)
        Me.Name = "Sexos"
        Me.Text = "Sexos"
        CType(Me.DataGridView_Sexos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SexoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PacientesCOVID191DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView_Sexos As DataGridView
    Friend WithEvents PacientesCOVID191DataSet As PacientesCOVID191DataSet
    Friend WithEvents SexoBindingSource As BindingSource
    Friend WithEvents SexoTableAdapter As PacientesCOVID191DataSetTableAdapters.SexoTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SexoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Button_Agregar As Button
    Friend WithEvents Button_Editar As Button
    Friend WithEvents Button_Eliminar As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox_ID As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox_Sexo As TextBox
End Class
