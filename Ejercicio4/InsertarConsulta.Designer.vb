<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInsertarConsulta
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
    Me.btnCancelar = New System.Windows.Forms.Button()
    Me.btnAceptar = New System.Windows.Forms.Button()
    Me.dtpConsulta = New System.Windows.Forms.DateTimePicker()
    Me.cbTipoConsulta = New System.Windows.Forms.ComboBox()
    Me.cbEspecialidad = New System.Windows.Forms.ComboBox()
    Me.txtMotivo = New System.Windows.Forms.TextBox()
    Me.txtDiagnostico = New System.Windows.Forms.TextBox()
    Me.lblMotivo = New System.Windows.Forms.Label()
    Me.lblDiagnostico = New System.Windows.Forms.Label()
    Me.lblFechaConsulta = New System.Windows.Forms.Label()
    Me.lblTipoConsulta = New System.Windows.Forms.Label()
    Me.lblEspecialidad = New System.Windows.Forms.Label()
    Me.lblPaciente = New System.Windows.Forms.Label()
    Me.cbPaciente = New System.Windows.Forms.ComboBox()
    Me.SuspendLayout()
    '
    'btnCancelar
    '
    Me.btnCancelar.Location = New System.Drawing.Point(26, 202)
    Me.btnCancelar.Name = "btnCancelar"
    Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
    Me.btnCancelar.TabIndex = 0
    Me.btnCancelar.Text = "Cancelar"
    Me.btnCancelar.UseVisualStyleBackColor = True
    '
    'btnAceptar
    '
    Me.btnAceptar.Location = New System.Drawing.Point(262, 202)
    Me.btnAceptar.Name = "btnAceptar"
    Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
    Me.btnAceptar.TabIndex = 1
    Me.btnAceptar.Text = "Aceptar"
    Me.btnAceptar.UseVisualStyleBackColor = True
    '
    'dtpConsulta
    '
    Me.dtpConsulta.Location = New System.Drawing.Point(137, 67)
    Me.dtpConsulta.Name = "dtpConsulta"
    Me.dtpConsulta.Size = New System.Drawing.Size(200, 20)
    Me.dtpConsulta.TabIndex = 3
    '
    'cbTipoConsulta
    '
    Me.cbTipoConsulta.FormattingEnabled = True
    Me.cbTipoConsulta.Location = New System.Drawing.Point(137, 94)
    Me.cbTipoConsulta.Name = "cbTipoConsulta"
    Me.cbTipoConsulta.Size = New System.Drawing.Size(200, 21)
    Me.cbTipoConsulta.TabIndex = 4
    '
    'cbEspecialidad
    '
    Me.cbEspecialidad.FormattingEnabled = True
    Me.cbEspecialidad.Location = New System.Drawing.Point(137, 122)
    Me.cbEspecialidad.Name = "cbEspecialidad"
    Me.cbEspecialidad.Size = New System.Drawing.Size(200, 21)
    Me.cbEspecialidad.TabIndex = 5
    '
    'txtMotivo
    '
    Me.txtMotivo.Location = New System.Drawing.Point(137, 15)
    Me.txtMotivo.Name = "txtMotivo"
    Me.txtMotivo.Size = New System.Drawing.Size(200, 20)
    Me.txtMotivo.TabIndex = 6
    '
    'txtDiagnostico
    '
    Me.txtDiagnostico.Location = New System.Drawing.Point(137, 41)
    Me.txtDiagnostico.Name = "txtDiagnostico"
    Me.txtDiagnostico.Size = New System.Drawing.Size(200, 20)
    Me.txtDiagnostico.TabIndex = 7
    '
    'lblMotivo
    '
    Me.lblMotivo.AutoSize = True
    Me.lblMotivo.Location = New System.Drawing.Point(23, 22)
    Me.lblMotivo.Name = "lblMotivo"
    Me.lblMotivo.Size = New System.Drawing.Size(39, 13)
    Me.lblMotivo.TabIndex = 8
    Me.lblMotivo.Text = "Motivo"
    '
    'lblDiagnostico
    '
    Me.lblDiagnostico.AutoSize = True
    Me.lblDiagnostico.Location = New System.Drawing.Point(23, 44)
    Me.lblDiagnostico.Name = "lblDiagnostico"
    Me.lblDiagnostico.Size = New System.Drawing.Size(63, 13)
    Me.lblDiagnostico.TabIndex = 9
    Me.lblDiagnostico.Text = "Diagnostico"
    '
    'lblFechaConsulta
    '
    Me.lblFechaConsulta.AutoSize = True
    Me.lblFechaConsulta.Location = New System.Drawing.Point(23, 73)
    Me.lblFechaConsulta.Name = "lblFechaConsulta"
    Me.lblFechaConsulta.Size = New System.Drawing.Size(106, 13)
    Me.lblFechaConsulta.TabIndex = 10
    Me.lblFechaConsulta.Text = "Fecha de la consulta"
    '
    'lblTipoConsulta
    '
    Me.lblTipoConsulta.AutoSize = True
    Me.lblTipoConsulta.Location = New System.Drawing.Point(23, 97)
    Me.lblTipoConsulta.Name = "lblTipoConsulta"
    Me.lblTipoConsulta.Size = New System.Drawing.Size(86, 13)
    Me.lblTipoConsulta.TabIndex = 11
    Me.lblTipoConsulta.Text = "Tipo de consulta"
    '
    'lblEspecialidad
    '
    Me.lblEspecialidad.AutoSize = True
    Me.lblEspecialidad.Location = New System.Drawing.Point(23, 125)
    Me.lblEspecialidad.Name = "lblEspecialidad"
    Me.lblEspecialidad.Size = New System.Drawing.Size(67, 13)
    Me.lblEspecialidad.TabIndex = 12
    Me.lblEspecialidad.Text = "Especialidad"
    '
    'lblPaciente
    '
    Me.lblPaciente.AutoSize = True
    Me.lblPaciente.Location = New System.Drawing.Point(23, 152)
    Me.lblPaciente.Name = "lblPaciente"
    Me.lblPaciente.Size = New System.Drawing.Size(49, 13)
    Me.lblPaciente.TabIndex = 13
    Me.lblPaciente.Text = "Paciente"
    '
    'cbPaciente
    '
    Me.cbPaciente.FormattingEnabled = True
    Me.cbPaciente.Location = New System.Drawing.Point(137, 149)
    Me.cbPaciente.Name = "cbPaciente"
    Me.cbPaciente.Size = New System.Drawing.Size(200, 21)
    Me.cbPaciente.TabIndex = 14
    '
    'frmInsertarConsulta
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(370, 241)
    Me.Controls.Add(Me.cbPaciente)
    Me.Controls.Add(Me.lblPaciente)
    Me.Controls.Add(Me.lblEspecialidad)
    Me.Controls.Add(Me.lblTipoConsulta)
    Me.Controls.Add(Me.lblFechaConsulta)
    Me.Controls.Add(Me.lblDiagnostico)
    Me.Controls.Add(Me.lblMotivo)
    Me.Controls.Add(Me.txtDiagnostico)
    Me.Controls.Add(Me.txtMotivo)
    Me.Controls.Add(Me.cbEspecialidad)
    Me.Controls.Add(Me.cbTipoConsulta)
    Me.Controls.Add(Me.dtpConsulta)
    Me.Controls.Add(Me.btnAceptar)
    Me.Controls.Add(Me.btnCancelar)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
    Me.MaximizeBox = False
    Me.MinimizeBox = False
    Me.Name = "frmInsertarConsulta"
    Me.Text = "Insertar consulta"
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub

  Friend WithEvents btnCancelar As Button
  Friend WithEvents btnAceptar As Button
  Friend WithEvents dtpConsulta As DateTimePicker
  Friend WithEvents cbTipoConsulta As ComboBox
  Friend WithEvents cbEspecialidad As ComboBox
  Friend WithEvents txtMotivo As TextBox
  Friend WithEvents txtDiagnostico As TextBox
  Friend WithEvents lblMotivo As Label
  Friend WithEvents lblDiagnostico As Label
  Friend WithEvents lblFechaConsulta As Label
  Friend WithEvents lblTipoConsulta As Label
  Friend WithEvents lblEspecialidad As Label
  Friend WithEvents lblPaciente As Label
  Friend WithEvents cbPaciente As ComboBox
End Class
