Public Class frmModificarConsulta
  Dim bsnNegocio As New BsnNegocio()
  Dim paciente As New Paciente()
  Dim num As Integer
  Public Sub New(paciente As Paciente, num As Integer)

    InitializeComponent()

    Me.paciente = paciente
    Me.num = num
  End Sub

  Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
    Me.Dispose()
  End Sub

  Public Sub frmModificarConsulta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    If num = 1 Then
      dgvConsultas.DataSource = bsnNegocio.GetConsultasPaciente(paciente)
    Else
      dgvConsultas.DataSource = bsnNegocio.GetConsultas()
    End If

    dgvConsultas.Columns(0).Visible = False
    dgvConsultas.Columns(6).Visible = False

  End Sub

  Public Sub New()

    InitializeComponent()

  End Sub

  Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click


    Dim Consulta As New Consulta()

    Consulta.ID = Integer.Parse(dgvConsultas.SelectedRows.Item(0).Cells(0).Value.ToString())
    Consulta.Motivo = dgvConsultas.SelectedRows.Item(0).Cells(1).Value.ToString()
    Consulta.Diagnostico = dgvConsultas.SelectedRows.Item(0).Cells(2).Value.ToString()
    Consulta.FechaConsulta = Date.Parse(dgvConsultas.SelectedRows.Item(0).Cells(3).Value.ToString())
    Consulta.IdTipoConsulta = Integer.Parse(dgvConsultas.SelectedRows.Item(0).Cells(4).Value.ToString())
    Consulta.IdEspecialidad = Integer.Parse(dgvConsultas.SelectedRows.Item(0).Cells(5).Value.ToString())
    Consulta.IdPaciente = Integer.Parse(dgvConsultas.SelectedRows.Item(0).Cells(6).Value.ToString())

    Dim frmModificarUnaConsulta As New frmModificarUnaConsulta(Me, Consulta)

    frmModificarUnaConsulta.ShowDialog()

  End Sub

  Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
    Dim consulta As New Consulta()

    consulta.ID = Integer.Parse(dgvConsultas.SelectedRows.Item(0).Cells(0).Value.ToString())

    If MessageBox.Show("¿ Está seguro de Eliminar el Alumno ?", "Alerta", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then

      bsnNegocio.EliminarConsulta(consulta)

      MsgBox("Consulta eliminada correctamente", MsgBoxStyle.Information, "Alerta")

      Me.frmModificarConsulta_Load(Me, Nothing)

    End If
  End Sub
End Class