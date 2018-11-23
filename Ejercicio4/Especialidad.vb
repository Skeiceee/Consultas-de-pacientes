Public Class frmEspecialidad
  Dim bsnNegocio As New BsnNegocio()
  Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
    Me.Close()
  End Sub

  Private Sub frmEspecialidad_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    dgvEspecialidad.DataSource = bsnNegocio.GetEspecialidad()
    dgvEspecialidad.Columns(0).Visible = False
  End Sub
End Class