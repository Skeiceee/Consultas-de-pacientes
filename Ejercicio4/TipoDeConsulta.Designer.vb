<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTipoDeConsulta
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
    Me.gbTipodeConsultas = New System.Windows.Forms.GroupBox()
    Me.dvgTipoDeConsulta = New System.Windows.Forms.DataGridView()
    Me.btnCerrar = New System.Windows.Forms.Button()
    Me.gbTipodeConsultas.SuspendLayout()
    CType(Me.dvgTipoDeConsulta, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'gbTipodeConsultas
    '
    Me.gbTipodeConsultas.Controls.Add(Me.dvgTipoDeConsulta)
    Me.gbTipodeConsultas.Location = New System.Drawing.Point(12, 12)
    Me.gbTipodeConsultas.Name = "gbTipodeConsultas"
    Me.gbTipodeConsultas.Size = New System.Drawing.Size(193, 180)
    Me.gbTipodeConsultas.TabIndex = 0
    Me.gbTipodeConsultas.TabStop = False
    Me.gbTipodeConsultas.Text = "Tipo de consultas"
    '
    'dvgTipoDeConsulta
    '
    Me.dvgTipoDeConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.dvgTipoDeConsulta.Location = New System.Drawing.Point(7, 20)
    Me.dvgTipoDeConsulta.Name = "dvgTipoDeConsulta"
    Me.dvgTipoDeConsulta.Size = New System.Drawing.Size(177, 150)
    Me.dvgTipoDeConsulta.TabIndex = 0
    '
    'btnCerrar
    '
    Me.btnCerrar.Location = New System.Drawing.Point(19, 199)
    Me.btnCerrar.Name = "btnCerrar"
    Me.btnCerrar.Size = New System.Drawing.Size(75, 23)
    Me.btnCerrar.TabIndex = 1
    Me.btnCerrar.Text = "Cerrar"
    Me.btnCerrar.UseVisualStyleBackColor = True
    '
    'frmTipoDeConsulta
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(219, 231)
    Me.Controls.Add(Me.btnCerrar)
    Me.Controls.Add(Me.gbTipodeConsultas)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
    Me.MaximizeBox = False
    Me.MinimizeBox = False
    Me.Name = "frmTipoDeConsulta"
    Me.Text = " Tipo de consultas"
    Me.gbTipodeConsultas.ResumeLayout(False)
    CType(Me.dvgTipoDeConsulta, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub

  Friend WithEvents gbTipodeConsultas As GroupBox
  Friend WithEvents dvgTipoDeConsulta As DataGridView
  Friend WithEvents btnCerrar As Button
End Class
