<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
  Inherits System.Windows.Forms.Form

  'Form reemplaza a Dispose para limpiar la lista de componentes.
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

  'Requerido por el Diseñador de Windows Forms
  Private components As System.ComponentModel.IContainer

  'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
  'Se puede modificar usando el Diseñador de Windows Forms.  
  'No lo modifique con el editor de código.
  <System.Diagnostics.DebuggerStepThrough()> _
  Private Sub InitializeComponent()
    Me.btnCerrar = New System.Windows.Forms.Button()
    Me.btnAceptar = New System.Windows.Forms.Button()
    Me.txtUser = New System.Windows.Forms.TextBox()
    Me.txtPassword = New System.Windows.Forms.TextBox()
    Me.lblUser = New System.Windows.Forms.Label()
    Me.lblPassword = New System.Windows.Forms.Label()
    Me.SuspendLayout()
    '
    'btnCerrar
    '
    Me.btnCerrar.Location = New System.Drawing.Point(24, 116)
    Me.btnCerrar.Name = "btnCerrar"
    Me.btnCerrar.Size = New System.Drawing.Size(75, 23)
    Me.btnCerrar.TabIndex = 0
    Me.btnCerrar.Text = "Cerrar"
    Me.btnCerrar.UseVisualStyleBackColor = True
    '
    'btnAceptar
    '
    Me.btnAceptar.Location = New System.Drawing.Point(182, 116)
    Me.btnAceptar.Name = "btnAceptar"
    Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
    Me.btnAceptar.TabIndex = 1
    Me.btnAceptar.Text = "Aceptar"
    Me.btnAceptar.UseVisualStyleBackColor = True
    '
    'txtUser
    '
    Me.txtUser.Location = New System.Drawing.Point(123, 27)
    Me.txtUser.Name = "txtUser"
    Me.txtUser.Size = New System.Drawing.Size(134, 20)
    Me.txtUser.TabIndex = 2
    '
    'txtPassword
    '
    Me.txtPassword.Location = New System.Drawing.Point(123, 64)
    Me.txtPassword.Name = "txtPassword"
    Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
    Me.txtPassword.Size = New System.Drawing.Size(134, 20)
    Me.txtPassword.TabIndex = 3
    '
    'lblUser
    '
    Me.lblUser.AutoSize = True
    Me.lblUser.Location = New System.Drawing.Point(21, 30)
    Me.lblUser.Name = "lblUser"
    Me.lblUser.Size = New System.Drawing.Size(96, 13)
    Me.lblUser.TabIndex = 4
    Me.lblUser.Text = "Nombre de usuario"
    '
    'lblPassword
    '
    Me.lblPassword.AutoSize = True
    Me.lblPassword.Location = New System.Drawing.Point(22, 67)
    Me.lblPassword.Name = "lblPassword"
    Me.lblPassword.Size = New System.Drawing.Size(61, 13)
    Me.lblPassword.TabIndex = 5
    Me.lblPassword.Text = "Contraseña"
    '
    'frmLogin
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(283, 157)
    Me.Controls.Add(Me.lblPassword)
    Me.Controls.Add(Me.lblUser)
    Me.Controls.Add(Me.txtPassword)
    Me.Controls.Add(Me.txtUser)
    Me.Controls.Add(Me.btnAceptar)
    Me.Controls.Add(Me.btnCerrar)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
    Me.MaximizeBox = False
    Me.MinimizeBox = False
    Me.Name = "frmLogin"
    Me.Text = "Login"
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub

  Friend WithEvents btnCerrar As Button
  Friend WithEvents btnAceptar As Button
  Friend WithEvents txtUser As TextBox
  Friend WithEvents txtPassword As TextBox
  Friend WithEvents lblUser As Label
  Friend WithEvents lblPassword As Label
End Class
