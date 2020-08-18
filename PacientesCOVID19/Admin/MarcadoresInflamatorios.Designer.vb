<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MarcadoresInflamatorios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MarcadoresInflamatorios))
        Me.DataGridView_MI = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MarcadorInflamatorioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ValorMinimoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ValorMaximoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UnidadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MarcadoresInflamatoriosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PacientesCOVID191DataSet = New PacientesCOVID19.PacientesCOVID191DataSet()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button_Agregar = New System.Windows.Forms.Button()
        Me.Button_Editar = New System.Windows.Forms.Button()
        Me.Button_Eliminar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox_ID = New System.Windows.Forms.TextBox()
        Me.MarcadoresInflamatoriosTableAdapter = New PacientesCOVID19.PacientesCOVID191DataSetTableAdapters.MarcadoresInflamatoriosTableAdapter()
        Me.TextBox_MI = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox_ValMin = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox_ValMax = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox_Unidad = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.DataGridView_MI, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MarcadoresInflamatoriosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PacientesCOVID191DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView_MI
        '
        Me.DataGridView_MI.AllowUserToAddRows = False
        Me.DataGridView_MI.AllowUserToDeleteRows = False
        Me.DataGridView_MI.AutoGenerateColumns = False
        Me.DataGridView_MI.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_MI.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.MarcadorInflamatorioDataGridViewTextBoxColumn, Me.ValorMinimoDataGridViewTextBoxColumn, Me.ValorMaximoDataGridViewTextBoxColumn, Me.UnidadDataGridViewTextBoxColumn})
        Me.DataGridView_MI.DataSource = Me.MarcadoresInflamatoriosBindingSource
        Me.DataGridView_MI.Location = New System.Drawing.Point(12, 85)
        Me.DataGridView_MI.Name = "DataGridView_MI"
        Me.DataGridView_MI.ReadOnly = True
        Me.DataGridView_MI.RowHeadersWidth = 10
        Me.DataGridView_MI.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView_MI.Size = New System.Drawing.Size(450, 150)
        Me.DataGridView_MI.TabIndex = 0
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.ReadOnly = True
        Me.IDDataGridViewTextBoxColumn.Width = 50
        '
        'MarcadorInflamatorioDataGridViewTextBoxColumn
        '
        Me.MarcadorInflamatorioDataGridViewTextBoxColumn.DataPropertyName = "Marcador Inflamatorio"
        Me.MarcadorInflamatorioDataGridViewTextBoxColumn.HeaderText = "Marcador Inflamatorio"
        Me.MarcadorInflamatorioDataGridViewTextBoxColumn.Name = "MarcadorInflamatorioDataGridViewTextBoxColumn"
        Me.MarcadorInflamatorioDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ValorMinimoDataGridViewTextBoxColumn
        '
        Me.ValorMinimoDataGridViewTextBoxColumn.DataPropertyName = "Valor Minimo"
        Me.ValorMinimoDataGridViewTextBoxColumn.HeaderText = "Valor Minimo"
        Me.ValorMinimoDataGridViewTextBoxColumn.Name = "ValorMinimoDataGridViewTextBoxColumn"
        Me.ValorMinimoDataGridViewTextBoxColumn.ReadOnly = True
        Me.ValorMinimoDataGridViewTextBoxColumn.Width = 80
        '
        'ValorMaximoDataGridViewTextBoxColumn
        '
        Me.ValorMaximoDataGridViewTextBoxColumn.DataPropertyName = "Valor Maximo"
        Me.ValorMaximoDataGridViewTextBoxColumn.HeaderText = "Valor Maximo"
        Me.ValorMaximoDataGridViewTextBoxColumn.Name = "ValorMaximoDataGridViewTextBoxColumn"
        Me.ValorMaximoDataGridViewTextBoxColumn.ReadOnly = True
        Me.ValorMaximoDataGridViewTextBoxColumn.Width = 80
        '
        'UnidadDataGridViewTextBoxColumn
        '
        Me.UnidadDataGridViewTextBoxColumn.DataPropertyName = "Unidad"
        Me.UnidadDataGridViewTextBoxColumn.HeaderText = "Unidad"
        Me.UnidadDataGridViewTextBoxColumn.Name = "UnidadDataGridViewTextBoxColumn"
        Me.UnidadDataGridViewTextBoxColumn.ReadOnly = True
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
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Location = New System.Drawing.Point(-7, -2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(484, 81)
        Me.Panel1.TabIndex = 38
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(13, 27)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(308, 29)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Marcadores Inflamatorios"
        '
        'Button_Agregar
        '
        Me.Button_Agregar.Image = Global.PacientesCOVID19.My.Resources.Resources.add_16
        Me.Button_Agregar.Location = New System.Drawing.Point(333, 244)
        Me.Button_Agregar.Name = "Button_Agregar"
        Me.Button_Agregar.Size = New System.Drawing.Size(83, 30)
        Me.Button_Agregar.TabIndex = 41
        Me.Button_Agregar.Text = "Agregar"
        Me.Button_Agregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button_Agregar.UseVisualStyleBackColor = True
        '
        'Button_Editar
        '
        Me.Button_Editar.Image = Global.PacientesCOVID19.My.Resources.Resources.edit_16
        Me.Button_Editar.Location = New System.Drawing.Point(333, 293)
        Me.Button_Editar.Name = "Button_Editar"
        Me.Button_Editar.Size = New System.Drawing.Size(83, 32)
        Me.Button_Editar.TabIndex = 40
        Me.Button_Editar.Text = "Editar"
        Me.Button_Editar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button_Editar.UseVisualStyleBackColor = True
        '
        'Button_Eliminar
        '
        Me.Button_Eliminar.Image = Global.PacientesCOVID19.My.Resources.Resources.delete_16
        Me.Button_Eliminar.Location = New System.Drawing.Point(333, 345)
        Me.Button_Eliminar.Name = "Button_Eliminar"
        Me.Button_Eliminar.Size = New System.Drawing.Size(83, 30)
        Me.Button_Eliminar.TabIndex = 39
        Me.Button_Eliminar.Text = "Eliminar"
        Me.Button_Eliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button_Eliminar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(4, 244)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(124, 13)
        Me.Label1.TabIndex = 42
        Me.Label1.Text = "Id. Marcador Inflamatorio"
        '
        'TextBox_ID
        '
        Me.TextBox_ID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MarcadoresInflamatoriosBindingSource, "ID", True))
        Me.TextBox_ID.Location = New System.Drawing.Point(134, 241)
        Me.TextBox_ID.Name = "TextBox_ID"
        Me.TextBox_ID.ReadOnly = True
        Me.TextBox_ID.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_ID.TabIndex = 43
        '
        'MarcadoresInflamatoriosTableAdapter
        '
        Me.MarcadoresInflamatoriosTableAdapter.ClearBeforeFill = True
        '
        'TextBox_MI
        '
        Me.TextBox_MI.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MarcadoresInflamatoriosBindingSource, "Marcador Inflamatorio", True))
        Me.TextBox_MI.Location = New System.Drawing.Point(134, 267)
        Me.TextBox_MI.Name = "TextBox_MI"
        Me.TextBox_MI.ReadOnly = True
        Me.TextBox_MI.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_MI.TabIndex = 45
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 270)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 13)
        Me.Label2.TabIndex = 44
        Me.Label2.Text = "Marcador Inflamatorio:"
        '
        'TextBox_ValMin
        '
        Me.TextBox_ValMin.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MarcadoresInflamatoriosBindingSource, "Valor Minimo", True))
        Me.TextBox_ValMin.Location = New System.Drawing.Point(134, 296)
        Me.TextBox_ValMin.Name = "TextBox_ValMin"
        Me.TextBox_ValMin.ReadOnly = True
        Me.TextBox_ValMin.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_ValMin.TabIndex = 47
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(29, 299)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 13)
        Me.Label4.TabIndex = 46
        Me.Label4.Text = "Valor Minimo:"
        '
        'TextBox_ValMax
        '
        Me.TextBox_ValMax.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MarcadoresInflamatoriosBindingSource, "Valor Maximo", True))
        Me.TextBox_ValMax.Location = New System.Drawing.Point(134, 322)
        Me.TextBox_ValMax.Name = "TextBox_ValMax"
        Me.TextBox_ValMax.ReadOnly = True
        Me.TextBox_ValMax.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_ValMax.TabIndex = 49
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(29, 325)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 13)
        Me.Label5.TabIndex = 48
        Me.Label5.Text = "Valor Maximo:"
        '
        'TextBox_Unidad
        '
        Me.TextBox_Unidad.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MarcadoresInflamatoriosBindingSource, "Unidad", True))
        Me.TextBox_Unidad.Location = New System.Drawing.Point(134, 345)
        Me.TextBox_Unidad.Name = "TextBox_Unidad"
        Me.TextBox_Unidad.ReadOnly = True
        Me.TextBox_Unidad.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_Unidad.TabIndex = 51
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(45, 348)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 13)
        Me.Label6.TabIndex = 50
        Me.Label6.Text = "Unidad:"
        '
        'MarcadoresInflamatorios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(472, 390)
        Me.Controls.Add(Me.TextBox_Unidad)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TextBox_ValMax)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextBox_ValMin)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBox_MI)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox_ID)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button_Agregar)
        Me.Controls.Add(Me.Button_Editar)
        Me.Controls.Add(Me.Button_Eliminar)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DataGridView_MI)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MarcadoresInflamatorios"
        Me.Text = "MarcadoresInflamatorios"
        CType(Me.DataGridView_MI, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MarcadoresInflamatoriosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PacientesCOVID191DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView_MI As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Button_Agregar As Button
    Friend WithEvents Button_Editar As Button
    Friend WithEvents Button_Eliminar As Button
    Friend WithEvents PacientesCOVID191DataSet As PacientesCOVID191DataSet
    Friend WithEvents MarcadoresInflamatoriosBindingSource As BindingSource
    Friend WithEvents MarcadoresInflamatoriosTableAdapter As PacientesCOVID191DataSetTableAdapters.MarcadoresInflamatoriosTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MarcadorInflamatorioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ValorMinimoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ValorMaximoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UnidadDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox_ID As TextBox
    Friend WithEvents TextBox_MI As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox_ValMin As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox_ValMax As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox_Unidad As TextBox
    Friend WithEvents Label6 As Label
End Class
