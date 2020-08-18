<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EstadosAlta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EstadosAlta))
        Me.DataGridView_Estados = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstadosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PacientesCOVID191DataSet = New PacientesCOVID19.PacientesCOVID191DataSet()
        Me.EstadosTableAdapter = New PacientesCOVID19.PacientesCOVID191DataSetTableAdapters.EstadosTableAdapter()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox_Estado = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox_ID = New System.Windows.Forms.TextBox()
        Me.Button_Agregar = New System.Windows.Forms.Button()
        Me.Button_Editar = New System.Windows.Forms.Button()
        Me.Button_Eliminar = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.DataGridView_Estados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EstadosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PacientesCOVID191DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView_Estados
        '
        Me.DataGridView_Estados.AllowUserToAddRows = False
        Me.DataGridView_Estados.AllowUserToDeleteRows = False
        Me.DataGridView_Estados.AutoGenerateColumns = False
        Me.DataGridView_Estados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_Estados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.DescripcionDataGridViewTextBoxColumn})
        Me.DataGridView_Estados.DataSource = Me.EstadosBindingSource
        Me.DataGridView_Estados.Location = New System.Drawing.Point(10, 81)
        Me.DataGridView_Estados.Name = "DataGridView_Estados"
        Me.DataGridView_Estados.ReadOnly = True
        Me.DataGridView_Estados.RowHeadersWidth = 10
        Me.DataGridView_Estados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView_Estados.Size = New System.Drawing.Size(212, 150)
        Me.DataGridView_Estados.TabIndex = 0
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DescripcionDataGridViewTextBoxColumn
        '
        Me.DescripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.Name = "DescripcionDataGridViewTextBoxColumn"
        Me.DescripcionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EstadosBindingSource
        '
        Me.EstadosBindingSource.DataMember = "Estados"
        Me.EstadosBindingSource.DataSource = Me.PacientesCOVID191DataSet
        '
        'PacientesCOVID191DataSet
        '
        Me.PacientesCOVID191DataSet.DataSetName = "PacientesCOVID191DataSet"
        Me.PacientesCOVID191DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EstadosTableAdapter
        '
        Me.EstadosTableAdapter.ClearBeforeFill = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 270)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Descripción"
        '
        'TextBox_Estado
        '
        Me.TextBox_Estado.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EstadosBindingSource, "Descripcion", True))
        Me.TextBox_Estado.Location = New System.Drawing.Point(83, 267)
        Me.TextBox_Estado.MaxLength = 200
        Me.TextBox_Estado.Name = "TextBox_Estado"
        Me.TextBox_Estado.ReadOnly = True
        Me.TextBox_Estado.Size = New System.Drawing.Size(139, 20)
        Me.TextBox_Estado.TabIndex = 26
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 244)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 13)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "Id. Estado"
        '
        'TextBox_ID
        '
        Me.TextBox_ID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EstadosBindingSource, "ID", True))
        Me.TextBox_ID.Location = New System.Drawing.Point(73, 241)
        Me.TextBox_ID.MaxLength = 50
        Me.TextBox_ID.Name = "TextBox_ID"
        Me.TextBox_ID.ReadOnly = True
        Me.TextBox_ID.Size = New System.Drawing.Size(68, 20)
        Me.TextBox_ID.TabIndex = 24
        '
        'Button_Agregar
        '
        Me.Button_Agregar.Image = Global.PacientesCOVID19.My.Resources.Resources.add_16
        Me.Button_Agregar.Location = New System.Drawing.Point(237, 81)
        Me.Button_Agregar.Name = "Button_Agregar"
        Me.Button_Agregar.Size = New System.Drawing.Size(93, 34)
        Me.Button_Agregar.TabIndex = 23
        Me.Button_Agregar.Text = "Agregar"
        Me.Button_Agregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button_Agregar.UseVisualStyleBackColor = True
        '
        'Button_Editar
        '
        Me.Button_Editar.Image = Global.PacientesCOVID19.My.Resources.Resources.edit_16
        Me.Button_Editar.Location = New System.Drawing.Point(237, 140)
        Me.Button_Editar.Name = "Button_Editar"
        Me.Button_Editar.Size = New System.Drawing.Size(93, 34)
        Me.Button_Editar.TabIndex = 22
        Me.Button_Editar.Text = "Editar"
        Me.Button_Editar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button_Editar.UseVisualStyleBackColor = True
        '
        'Button_Eliminar
        '
        Me.Button_Eliminar.Image = Global.PacientesCOVID19.My.Resources.Resources.delete_16
        Me.Button_Eliminar.Location = New System.Drawing.Point(237, 197)
        Me.Button_Eliminar.Name = "Button_Eliminar"
        Me.Button_Eliminar.Size = New System.Drawing.Size(93, 34)
        Me.Button_Eliminar.TabIndex = 21
        Me.Button_Eliminar.Text = "Eliminar"
        Me.Button_Eliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button_Eliminar.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(-3, -2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(399, 67)
        Me.Panel1.TabIndex = 28
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(15, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(260, 29)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Estados del Paciente"
        '
        'EstadosAlta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(342, 302)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox_Estado)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextBox_ID)
        Me.Controls.Add(Me.Button_Agregar)
        Me.Controls.Add(Me.Button_Editar)
        Me.Controls.Add(Me.Button_Eliminar)
        Me.Controls.Add(Me.DataGridView_Estados)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "EstadosAlta"
        Me.Text = "EstadosAlta"
        CType(Me.DataGridView_Estados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EstadosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PacientesCOVID191DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView_Estados As DataGridView
    Friend WithEvents PacientesCOVID191DataSet As PacientesCOVID191DataSet
    Friend WithEvents EstadosBindingSource As BindingSource
    Friend WithEvents EstadosTableAdapter As PacientesCOVID191DataSetTableAdapters.EstadosTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescripcionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox_Estado As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox_ID As TextBox
    Friend WithEvents Button_Agregar As Button
    Friend WithEvents Button_Editar As Button
    Friend WithEvents Button_Eliminar As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
End Class
