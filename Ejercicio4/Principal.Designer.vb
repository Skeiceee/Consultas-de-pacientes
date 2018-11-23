<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Principal
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
    Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
    Me.InicioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    Me.PacientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    Me.ConsultarPacienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    Me.InsertarConsultaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    Me.ModificarConsultaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    Me.EliminarConsultaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    Me.OtrosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    Me.TipoDeConsultaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    Me.EspecialidadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    Me.MenuStrip1.SuspendLayout()
    Me.SuspendLayout()
    '
    'MenuStrip1
    '
    Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InicioToolStripMenuItem, Me.PacientesToolStripMenuItem, Me.OtrosToolStripMenuItem})
    Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
    Me.MenuStrip1.Name = "MenuStrip1"
    Me.MenuStrip1.Size = New System.Drawing.Size(663, 24)
    Me.MenuStrip1.TabIndex = 0
    Me.MenuStrip1.Text = "MenuStrip1"
    '
    'InicioToolStripMenuItem
    '
    Me.InicioToolStripMenuItem.Name = "InicioToolStripMenuItem"
    Me.InicioToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
    Me.InicioToolStripMenuItem.Text = "Inicio"
    '
    'PacientesToolStripMenuItem
    '
    Me.PacientesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConsultarPacienteToolStripMenuItem, Me.InsertarConsultaToolStripMenuItem, Me.ModificarConsultaToolStripMenuItem, Me.EliminarConsultaToolStripMenuItem})
    Me.PacientesToolStripMenuItem.Name = "PacientesToolStripMenuItem"
    Me.PacientesToolStripMenuItem.Size = New System.Drawing.Size(69, 20)
    Me.PacientesToolStripMenuItem.Text = "Pacientes"
    '
    'ConsultarPacienteToolStripMenuItem
    '
    Me.ConsultarPacienteToolStripMenuItem.Name = "ConsultarPacienteToolStripMenuItem"
    Me.ConsultarPacienteToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
    Me.ConsultarPacienteToolStripMenuItem.Text = "Consultar paciente"
    '
    'InsertarConsultaToolStripMenuItem
    '
    Me.InsertarConsultaToolStripMenuItem.Name = "InsertarConsultaToolStripMenuItem"
    Me.InsertarConsultaToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
    Me.InsertarConsultaToolStripMenuItem.Text = "Insertar consulta"
    '
    'ModificarConsultaToolStripMenuItem
    '
    Me.ModificarConsultaToolStripMenuItem.Name = "ModificarConsultaToolStripMenuItem"
    Me.ModificarConsultaToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
    Me.ModificarConsultaToolStripMenuItem.Text = "Modificar consulta"
    '
    'EliminarConsultaToolStripMenuItem
    '
    Me.EliminarConsultaToolStripMenuItem.Name = "EliminarConsultaToolStripMenuItem"
    Me.EliminarConsultaToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
    Me.EliminarConsultaToolStripMenuItem.Text = "Eliminar consulta"
    '
    'OtrosToolStripMenuItem
    '
    Me.OtrosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TipoDeConsultaToolStripMenuItem, Me.EspecialidadToolStripMenuItem})
    Me.OtrosToolStripMenuItem.Name = "OtrosToolStripMenuItem"
    Me.OtrosToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
    Me.OtrosToolStripMenuItem.Text = "Otros"
    '
    'TipoDeConsultaToolStripMenuItem
    '
    Me.TipoDeConsultaToolStripMenuItem.Name = "TipoDeConsultaToolStripMenuItem"
    Me.TipoDeConsultaToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
    Me.TipoDeConsultaToolStripMenuItem.Text = "Tipo de consulta"
    '
    'EspecialidadToolStripMenuItem
    '
    Me.EspecialidadToolStripMenuItem.Name = "EspecialidadToolStripMenuItem"
    Me.EspecialidadToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
    Me.EspecialidadToolStripMenuItem.Text = "Especialidad"
    '
    'Principal
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(663, 468)
    Me.Controls.Add(Me.MenuStrip1)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
    Me.MainMenuStrip = Me.MenuStrip1
    Me.MaximizeBox = False
    Me.MinimizeBox = False
    Me.Name = "Principal"
    Me.Text = "Principal"
    Me.MenuStrip1.ResumeLayout(False)
    Me.MenuStrip1.PerformLayout()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub

  Friend WithEvents MenuStrip1 As MenuStrip
  Friend WithEvents InicioToolStripMenuItem As ToolStripMenuItem
  Friend WithEvents PacientesToolStripMenuItem As ToolStripMenuItem
  Friend WithEvents ConsultarPacienteToolStripMenuItem As ToolStripMenuItem
  Friend WithEvents InsertarConsultaToolStripMenuItem As ToolStripMenuItem
  Friend WithEvents ModificarConsultaToolStripMenuItem As ToolStripMenuItem
  Friend WithEvents EliminarConsultaToolStripMenuItem As ToolStripMenuItem
  Friend WithEvents OtrosToolStripMenuItem As ToolStripMenuItem
  Friend WithEvents TipoDeConsultaToolStripMenuItem As ToolStripMenuItem
  Friend WithEvents EspecialidadToolStripMenuItem As ToolStripMenuItem
End Class
