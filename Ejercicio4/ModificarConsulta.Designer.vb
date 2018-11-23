<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmModificarConsulta
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
    Me.gbConsultas = New System.Windows.Forms.GroupBox()
    Me.dgvConsultas = New System.Windows.Forms.DataGridView()
    Me.btnCerrar = New System.Windows.Forms.Button()
    Me.btnModificar = New System.Windows.Forms.Button()
    Me.btnEliminar = New System.Windows.Forms.Button()
    Me.gbConsultas.SuspendLayout()
    CType(Me.dgvConsultas, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'gbConsultas
    '
    Me.gbConsultas.Controls.Add(Me.dgvConsultas)
    Me.gbConsultas.Location = New System.Drawing.Point(12, 12)
    Me.gbConsultas.Name = "gbConsultas"
    Me.gbConsultas.Size = New System.Drawing.Size(709, 181)
    Me.gbConsultas.TabIndex = 0
    Me.gbConsultas.TabStop = False
    Me.gbConsultas.Text = "Consultas"
    '
    'dgvConsultas
    '
    Me.dgvConsultas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.dgvConsultas.Location = New System.Drawing.Point(6, 22)
    Me.dgvConsultas.Name = "dgvConsultas"
    Me.dgvConsultas.Size = New System.Drawing.Size(697, 150)
    Me.dgvConsultas.TabIndex = 0
    '
    'btnCerrar
    '
    Me.btnCerrar.Location = New System.Drawing.Point(18, 211)
    Me.btnCerrar.Name = "btnCerrar"
    Me.btnCerrar.Size = New System.Drawing.Size(75, 23)
    Me.btnCerrar.TabIndex = 1
    Me.btnCerrar.Text = "Cerrar"
    Me.btnCerrar.UseVisualStyleBackColor = True
    '
    'btnModificar
    '
    Me.btnModificar.Location = New System.Drawing.Point(548, 212)
    Me.btnModificar.Name = "btnModificar"
    Me.btnModificar.Size = New System.Drawing.Size(75, 23)
    Me.btnModificar.TabIndex = 2
    Me.btnModificar.Text = "Modificar"
    Me.btnModificar.UseVisualStyleBackColor = True
    '
    'btnEliminar
    '
    Me.btnEliminar.Location = New System.Drawing.Point(640, 211)
    Me.btnEliminar.Name = "btnEliminar"
    Me.btnEliminar.Size = New System.Drawing.Size(75, 23)
    Me.btnEliminar.TabIndex = 3
    Me.btnEliminar.Text = "Eliminar"
    Me.btnEliminar.UseVisualStyleBackColor = True
    '
    'frmModificarConsulta
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(730, 248)
    Me.Controls.Add(Me.btnEliminar)
    Me.Controls.Add(Me.btnModificar)
    Me.Controls.Add(Me.btnCerrar)
    Me.Controls.Add(Me.gbConsultas)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
    Me.MaximizeBox = False
    Me.MinimizeBox = False
    Me.Name = "frmModificarConsulta"
    Me.Text = "Modificar consulta"
    Me.gbConsultas.ResumeLayout(False)
    CType(Me.dgvConsultas, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub

  Friend WithEvents gbConsultas As GroupBox
  Friend WithEvents dgvConsultas As DataGridView
  Friend WithEvents btnCerrar As Button
  Friend WithEvents btnModificar As Button
  Friend WithEvents btnEliminar As Button
End Class
