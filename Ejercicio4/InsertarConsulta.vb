Public Class frmInsertarConsulta
  Dim bsnNegocio As New BsnNegocio()
  Dim consulta As New Consulta()
  Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
    Me.Dispose()
  End Sub

  Private Sub frmInsertarConsulta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    cbEspecialidad.DataSource = bsnNegocio.GetDatosIDEspecialidad()
    cbEspecialidad.DisplayMember = "Nombre"
    cbEspecialidad.ValueMember = "ID"

    cbTipoConsulta.DataSource = bsnNegocio.GetDatosIDTipoConsulta()
    cbTipoConsulta.DisplayMember = "Nombre"
    cbTipoConsulta.ValueMember = "ID"

    cbPaciente.DataSource = bsnNegocio.GetPacientes()
    cbPaciente.DisplayMember = "Rut"
    cbPaciente.ValueMember = "ID"
  End Sub

  Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click

    consulta.Motivo = txtMotivo.Text
    consulta.Diagnostico = txtDiagnostico.Text
    consulta.IdTipoConsulta = cbTipoConsulta.SelectedValue
    consulta.IdEspecialidad = cbEspecialidad.SelectedValue
    consulta.IdPaciente = cbPaciente.SelectedValue

    If (txtMotivo.Text.Equals("") Or txtDiagnostico.Text.Equals("")) Then
      MsgBox("Error campo motivo o campo diagnostico estan vacios", MsgBoxStyle.Information, "Alerta")
    Else
      bsnNegocio.InsertarConsulta(consulta)
      MsgBox("Consulta insertado correctamente", MsgBoxStyle.Information, "Alerta")
    End If

    Me.Close()

  End Sub

End Class