
Public Class frmConsultarPaciente
  Dim bsnNegocio As New BsnNegocio()
  Dim formPrincipal As New Principal()

  Private Sub frmConsultarPaciente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    dvgPacicentes.DataSource = bsnNegocio.GetPacientes()
    dvgPacicentes.Columns(0).Visible = False
  End Sub

  Public Sub New()
    InitializeComponent()
  End Sub

  Private Sub BtnCerrar_Click(sender As System.Object, e As System.EventArgs) Handles btnCerrar.Click
    Me.Dispose()
  End Sub

  Private Sub btnVerConsultas_Click(sender As Object, e As EventArgs) Handles btnVerConsultas.Click

    Dim paciente As New Paciente()

    paciente.ID = Integer.Parse(dvgPacicentes.SelectedRows.Item(0).Cells(0).Value.ToString())
    paciente.Rut = dvgPacicentes.SelectedRows.Item(0).Cells(1).Value.ToString()
    paciente.Nombre = dvgPacicentes.SelectedRows.Item(0).Cells(2).Value.ToString()
    paciente.Apellido = dvgPacicentes.SelectedRows.Item(0).Cells(3).Value.ToString()
    paciente.FechaNacimiento = Date.Parse(dvgPacicentes.SelectedRows.Item(0).Cells(4).Value.ToString())
    paciente.Telefono = Integer.Parse(dvgPacicentes.SelectedRows.Item(0).Cells(5).Value.ToString())

    Dim ConsultarPaciente As New frmModificarConsulta(paciente, 1)
    ConsultarPaciente.ShowDialog()

  End Sub
End Class