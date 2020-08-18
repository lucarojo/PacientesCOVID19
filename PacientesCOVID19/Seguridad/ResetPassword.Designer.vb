<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ResetPassword
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox_Usuario = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox_OldPasswd = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox_NewPasswd = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox_ConfNewPasswd = New System.Windows.Forms.TextBox()
        Me.Button_Cancelar = New System.Windows.Forms.Button()
        Me.Button_Aceptar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(48, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(173, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cambiar Contraseña"
        '
        'TextBox_Usuario
        '
        Me.TextBox_Usuario.Location = New System.Drawing.Point(121, 42)
        Me.TextBox_Usuario.Name = "TextBox_Usuario"
        Me.TextBox_Usuario.ReadOnly = True
        Me.TextBox_Usuario.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_Usuario.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(69, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Usuario:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Contraseña Actual:"
        '
        'TextBox_OldPasswd
        '
        Me.TextBox_OldPasswd.Location = New System.Drawing.Point(121, 68)
        Me.TextBox_OldPasswd.Name = "TextBox_OldPasswd"
        Me.TextBox_OldPasswd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBox_OldPasswd.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_OldPasswd.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 97)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Nueva Contraseña:"
        '
        'TextBox_NewPasswd
        '
        Me.TextBox_NewPasswd.Location = New System.Drawing.Point(121, 94)
        Me.TextBox_NewPasswd.Name = "TextBox_NewPasswd"
        Me.TextBox_NewPasswd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBox_NewPasswd.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_NewPasswd.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(4, 123)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(111, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Confirmar Contraseña:"
        '
        'TextBox_ConfNewPasswd
        '
        Me.TextBox_ConfNewPasswd.Location = New System.Drawing.Point(121, 120)
        Me.TextBox_ConfNewPasswd.Name = "TextBox_ConfNewPasswd"
        Me.TextBox_ConfNewPasswd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBox_ConfNewPasswd.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_ConfNewPasswd.TabIndex = 7
        '
        'Button_Cancelar
        '
        Me.Button_Cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button_Cancelar.Location = New System.Drawing.Point(176, 151)
        Me.Button_Cancelar.Name = "Button_Cancelar"
        Me.Button_Cancelar.Size = New System.Drawing.Size(75, 23)
        Me.Button_Cancelar.TabIndex = 9
        Me.Button_Cancelar.Text = "Cancelar"
        Me.Button_Cancelar.UseVisualStyleBackColor = True
        '
        'Button_Aceptar
        '
        Me.Button_Aceptar.Location = New System.Drawing.Point(95, 151)
        Me.Button_Aceptar.Name = "Button_Aceptar"
        Me.Button_Aceptar.Size = New System.Drawing.Size(75, 23)
        Me.Button_Aceptar.TabIndex = 10
        Me.Button_Aceptar.Text = "Aceptar"
        Me.Button_Aceptar.UseVisualStyleBackColor = True
        '
        'ResetPassword
        '
        Me.AcceptButton = Me.Button_Aceptar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Button_Cancelar
        Me.ClientSize = New System.Drawing.Size(263, 186)
        Me.Controls.Add(Me.Button_Aceptar)
        Me.Controls.Add(Me.Button_Cancelar)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextBox_ConfNewPasswd)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBox_NewPasswd)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox_OldPasswd)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox_Usuario)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ResetPassword"
        Me.Text = "ResetPassword"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox_Usuario As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox_OldPasswd As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox_NewPasswd As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox_ConfNewPasswd As TextBox
    Friend WithEvents Button_Cancelar As Button
    Friend WithEvents Button_Aceptar As Button
End Class
