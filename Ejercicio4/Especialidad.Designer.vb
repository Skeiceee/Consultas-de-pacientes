<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEspecialidad
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
    Me.gbEspecialidad = New System.Windows.Forms.GroupBox()
    Me.dgvEspecialidad = New System.Windows.Forms.DataGridView()
    Me.btnCerrar = New System.Windows.Forms.Button()
    Me.gbEspecialidad.SuspendLayout()
    CType(Me.dgvEspecialidad, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'gbEspecialidad
    '
    Me.gbEspecialidad.Controls.Add(Me.dgvEspecialidad)
    Me.gbEspecialidad.Location = New System.Drawing.Point(12, 12)
    Me.gbEspecialidad.Name = "gbEspecialidad"
    Me.gbEspecialidad.Size = New System.Drawing.Size(201, 178)
    Me.gbEspecialidad.TabIndex = 0
    Me.gbEspecialidad.TabStop = False
    Me.gbEspecialidad.Text = "Especialidad"
    '
    'dgvEspecialidad
    '
    Me.dgvEspecialidad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.dgvEspecialidad.Location = New System.Drawing.Point(6, 19)
    Me.dgvEspecialidad.Name = "dgvEspecialidad"
    Me.dgvEspecialidad.Size = New System.Drawing.Size(185, 150)
    Me.dgvEspecialidad.TabIndex = 0
    '
    'btnCerrar
    '
    Me.btnCerrar.Location = New System.Drawing.Point(12, 196)
    Me.btnCerrar.Name = "btnCerrar"
    Me.btnCerrar.Size = New System.Drawing.Size(75, 23)
    Me.btnCerrar.TabIndex = 2
    Me.btnCerrar.Text = "Cerrar"
    Me.btnCerrar.UseVisualStyleBackColor = True
    '
    'frmEspecialidad
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(223, 228)
    Me.Controls.Add(Me.btnCerrar)
    Me.Controls.Add(Me.gbEspecialidad)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
    Me.MaximizeBox = False
    Me.MinimizeBox = False
    Me.Name = "frmEspecialidad"
    Me.Text = "Especialidad"
    Me.gbEspecialidad.ResumeLayout(False)
    CType(Me.dgvEspecialidad, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub

  Friend WithEvents gbEspecialidad As GroupBox
  Friend WithEvents dgvEspecialidad As DataGridView
  Friend WithEvents btnCerrar As Button
End Class
