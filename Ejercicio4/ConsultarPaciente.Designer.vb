<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsultarPaciente
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
    Me.dvgPacicentes = New System.Windows.Forms.DataGridView()
    Me.gbPaciente = New System.Windows.Forms.GroupBox()
    Me.btnCerrar = New System.Windows.Forms.Button()
    Me.btnVerConsultas = New System.Windows.Forms.Button()
    CType(Me.dvgPacicentes, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.gbPaciente.SuspendLayout()
    Me.SuspendLayout()
    '
    'dvgPacicentes
    '
    Me.dvgPacicentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.dvgPacicentes.Location = New System.Drawing.Point(6, 19)
    Me.dvgPacicentes.Name = "dvgPacicentes"
    Me.dvgPacicentes.Size = New System.Drawing.Size(625, 150)
    Me.dvgPacicentes.TabIndex = 0
    '
    'gbPaciente
    '
    Me.gbPaciente.Controls.Add(Me.dvgPacicentes)
    Me.gbPaciente.Location = New System.Drawing.Point(12, 12)
    Me.gbPaciente.Name = "gbPaciente"
    Me.gbPaciente.Size = New System.Drawing.Size(639, 182)
    Me.gbPaciente.TabIndex = 1
    Me.gbPaciente.TabStop = False
    Me.gbPaciente.Text = "Pacientes"
    '
    'btnCerrar
    '
    Me.btnCerrar.Location = New System.Drawing.Point(12, 201)
    Me.btnCerrar.Name = "btnCerrar"
    Me.btnCerrar.Size = New System.Drawing.Size(75, 23)
    Me.btnCerrar.TabIndex = 2
    Me.btnCerrar.Text = "Cerrar"
    Me.btnCerrar.UseVisualStyleBackColor = True
    '
    'btnVerConsultas
    '
    Me.btnVerConsultas.Location = New System.Drawing.Point(528, 201)
    Me.btnVerConsultas.Name = "btnVerConsultas"
    Me.btnVerConsultas.Size = New System.Drawing.Size(123, 23)
    Me.btnVerConsultas.TabIndex = 3
    Me.btnVerConsultas.Text = "Ver consultas"
    Me.btnVerConsultas.UseVisualStyleBackColor = True
    '
    'frmConsultarPaciente
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(663, 234)
    Me.Controls.Add(Me.btnVerConsultas)
    Me.Controls.Add(Me.btnCerrar)
    Me.Controls.Add(Me.gbPaciente)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
    Me.MaximizeBox = False
    Me.MinimizeBox = False
    Me.Name = "frmConsultarPaciente"
    Me.Text = "Consultar paciente"
    CType(Me.dvgPacicentes, System.ComponentModel.ISupportInitialize).EndInit()
    Me.gbPaciente.ResumeLayout(False)
    Me.ResumeLayout(False)

  End Sub

  Friend WithEvents dvgPacicentes As DataGridView
  Friend WithEvents gbPaciente As GroupBox
  Friend WithEvents btnCerrar As Button
  Friend WithEvents btnVerConsultas As Button
End Class
