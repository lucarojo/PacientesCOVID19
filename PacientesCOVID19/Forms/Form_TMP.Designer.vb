<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_TMP
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_TMP))
        Me.PacientesCOVID191DataSet = New PacientesCOVID19.PacientesCOVID191DataSet()
        Me.DetalleRegistroMarcadoresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DetalleRegistroMarcadoresTableAdapter = New PacientesCOVID19.PacientesCOVID191DataSetTableAdapters.DetalleRegistroMarcadoresTableAdapter()
        Me.TableAdapterManager = New PacientesCOVID19.PacientesCOVID191DataSetTableAdapters.TableAdapterManager()
        Me.DetalleRegistroMarcadoresBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.DetalleRegistroMarcadoresBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.DetalleRegistroMarcadoresDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.PacientesCOVID191DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DetalleRegistroMarcadoresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DetalleRegistroMarcadoresBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DetalleRegistroMarcadoresBindingNavigator.SuspendLayout()
        CType(Me.DetalleRegistroMarcadoresDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'DetalleRegistroMarcadoresBindingNavigator
        '
        Me.DetalleRegistroMarcadoresBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.DetalleRegistroMarcadoresBindingNavigator.BindingSource = Me.DetalleRegistroMarcadoresBindingSource
        Me.DetalleRegistroMarcadoresBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.DetalleRegistroMarcadoresBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.DetalleRegistroMarcadoresBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.DetalleRegistroMarcadoresBindingNavigatorSaveItem})
        Me.DetalleRegistroMarcadoresBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.DetalleRegistroMarcadoresBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.DetalleRegistroMarcadoresBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.DetalleRegistroMarcadoresBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.DetalleRegistroMarcadoresBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.DetalleRegistroMarcadoresBindingNavigator.Name = "DetalleRegistroMarcadoresBindingNavigator"
        Me.DetalleRegistroMarcadoresBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.DetalleRegistroMarcadoresBindingNavigator.Size = New System.Drawing.Size(800, 25)
        Me.DetalleRegistroMarcadoresBindingNavigator.TabIndex = 0
        Me.DetalleRegistroMarcadoresBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 15)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'DetalleRegistroMarcadoresBindingNavigatorSaveItem
        '
        Me.DetalleRegistroMarcadoresBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.DetalleRegistroMarcadoresBindingNavigatorSaveItem.Image = CType(resources.GetObject("DetalleRegistroMarcadoresBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.DetalleRegistroMarcadoresBindingNavigatorSaveItem.Name = "DetalleRegistroMarcadoresBindingNavigatorSaveItem"
        Me.DetalleRegistroMarcadoresBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.DetalleRegistroMarcadoresBindingNavigatorSaveItem.Text = "Save Data"
        '
        'DetalleRegistroMarcadoresDataGridView
        '
        Me.DetalleRegistroMarcadoresDataGridView.AutoGenerateColumns = False
        Me.DetalleRegistroMarcadoresDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DetalleRegistroMarcadoresDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.DetalleRegistroMarcadoresDataGridView.DataSource = Me.DetalleRegistroMarcadoresBindingSource
        Me.DetalleRegistroMarcadoresDataGridView.Location = New System.Drawing.Point(387, 139)
        Me.DetalleRegistroMarcadoresDataGridView.Name = "DetalleRegistroMarcadoresDataGridView"
        Me.DetalleRegistroMarcadoresDataGridView.Size = New System.Drawing.Size(300, 220)
        Me.DetalleRegistroMarcadoresDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "RegistroMarcadores"
        Me.DataGridViewTextBoxColumn2.HeaderText = "RegistroMarcadores"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "MarcadorInflamatorio"
        Me.DataGridViewTextBoxColumn3.HeaderText = "MarcadorInflamatorio"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Resultado"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Resultado"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Indicador"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Indicador"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'Form_TMP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.DetalleRegistroMarcadoresDataGridView)
        Me.Controls.Add(Me.DetalleRegistroMarcadoresBindingNavigator)
        Me.Name = "Form_TMP"
        Me.Text = "Form_TMP"
        CType(Me.PacientesCOVID191DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DetalleRegistroMarcadoresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DetalleRegistroMarcadoresBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DetalleRegistroMarcadoresBindingNavigator.ResumeLayout(False)
        Me.DetalleRegistroMarcadoresBindingNavigator.PerformLayout()
        CType(Me.DetalleRegistroMarcadoresDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PacientesCOVID191DataSet As PacientesCOVID191DataSet
    Friend WithEvents DetalleRegistroMarcadoresBindingSource As BindingSource
    Friend WithEvents DetalleRegistroMarcadoresTableAdapter As PacientesCOVID191DataSetTableAdapters.DetalleRegistroMarcadoresTableAdapter
    Friend WithEvents TableAdapterManager As PacientesCOVID191DataSetTableAdapters.TableAdapterManager
    Friend WithEvents DetalleRegistroMarcadoresBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents DetalleRegistroMarcadoresBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents DetalleRegistroMarcadoresDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
End Class
