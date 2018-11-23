Public Class frmTipoDeConsulta
  Dim bsnNegocio As New BsnNegocio()
  Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
    Me.Close()
  End Sub

  Private Sub frmTipoDeConsulta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    dvgTipoDeConsulta.DataSource = bsnNegocio.GetTipoConsulta()
    dvgTipoDeConsulta.Columns(0).Visible = False
  End Sub
End Class