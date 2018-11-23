Public Class frmModificarUnaConsulta
  Dim frmMod As frmModificarConsulta
  Dim bsnNegocio As New BsnNegocio()
  Dim consulta As New Consulta()

  Public Sub New(frmMod As frmModificarConsulta, consulta As Consulta)

    InitializeComponent()
    Me.frmMod = frmMod
    Me.consulta = consulta
  End Sub
  Private Sub frmModificarUnaConsulta_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    cbEspecialidad.DataSource = bsnNegocio.GetDatosIDEspecialidad()
    cbEspecialidad.DisplayMember = "Nombre"
    cbEspecialidad.ValueMember = "ID"

    cbTipoConsulta.DataSource = bsnNegocio.GetDatosIDTipoConsulta()
    cbTipoConsulta.DisplayMember = "Nombre"
    cbTipoConsulta.ValueMember = "ID"

    cbPaciente.DataSource = bsnNegocio.GetPacientes()
    cbPaciente.DisplayMember = "Rut"
    cbPaciente.ValueMember = "ID"

    txtMotivo.Text = consulta.Motivo
    txtDiagnostico.Text = consulta.Diagnostico
    dtpConsulta.Value = consulta.FechaConsulta
    cbTipoConsulta.SelectedValue = consulta.IdTipoConsulta
    cbEspecialidad.SelectedValue = consulta.IdEspecialidad
    cbPaciente.SelectedValue = consulta.IdPaciente

  End Sub

  Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
    Me.Dispose()

  End Sub

  Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click

    consulta.Motivo = txtMotivo.Text
    consulta.Diagnostico = txtDiagnostico.Text
    consulta.FechaConsulta = dtpConsulta.Value
    consulta.IdTipoConsulta = cbTipoConsulta.SelectedValue
    consulta.IdEspecialidad = cbEspecialidad.SelectedValue
    consulta.IdPaciente = cbPaciente.SelectedValue

    If (txtMotivo.Text.Equals("") Or txtDiagnostico.Text.Equals("")) Then
      MsgBox("Error campo motivo o campo diagnostico estan vacios", MsgBoxStyle.Information, "Alerta")
    Else
      bsnNegocio.ModificarConsulta(consulta)
      MsgBox("Consulta se a modificado correctamente", MsgBoxStyle.Information, "Alerta")
    End If

    frmMod.frmModificarConsulta_Load(Me, Nothing)
    Me.Close()

  End Sub
End Class