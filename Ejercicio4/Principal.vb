Public Class Principal
  Private Sub PacientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PacientesToolStripMenuItem.Click

  End Sub

  Private Sub Principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

  End Sub

  Private Sub ConsultarPacienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultarPacienteToolStripMenuItem.Click
    Dim ConsultarPaciente As New frmConsultarPaciente()
    ConsultarPaciente.ShowDialog()
  End Sub

  Private Sub InicioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InicioToolStripMenuItem.Click
    Dim Login As New frmLogin()
    Me.Hide()
    Login.Show()
  End Sub

  Private Sub InsertarConsultaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InsertarConsultaToolStripMenuItem.Click
    Dim InsertarConsulta As New frmInsertarConsulta()
    InsertarConsulta.ShowDialog()
  End Sub

  Private Sub ModificarConsultaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModificarConsultaToolStripMenuItem.Click
    Dim ModificarConsulta As New frmModificarConsulta()
    ModificarConsulta.ShowDialog()
  End Sub

  Private Sub EliminarConsultaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarConsultaToolStripMenuItem.Click
    Dim ModificarConsulta As New frmModificarConsulta()
    ModificarConsulta.ShowDialog()
  End Sub

  Private Sub TipoDeConsultaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TipoDeConsultaToolStripMenuItem.Click
    Dim TipoConsulta As New frmTipoDeConsulta()
    TipoConsulta.ShowDialog()
  End Sub

  Private Sub EspecialidadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EspecialidadToolStripMenuItem.Click
    Dim Especialidad As New frmEspecialidad()
    Especialidad.ShowDialog()
  End Sub
End Class