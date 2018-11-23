Public Class BsnNegocio
  Dim DaoDatos As New DaoDatos()

  Function GetPacientes()
    Return DaoDatos.GetPaciente()
  End Function
  Function GetConsultas()
    Return DaoDatos.GetConsulta()
  End Function
  Function EliminarConsulta(consulta As Consulta)
    Return DaoDatos.EliminarConsulta(consulta)
  End Function

  Function ModificarConsulta(consulta As Consulta)
    Return DaoDatos.ModificarConsulta(consulta)
  End Function

  Function GetDatosIDTipoConsulta()
    Return DaoDatos.GetIDTipoConsulta()
  End Function
  Function GetDatosIDEspecialidad()
    Return DaoDatos.GetIDEspecialidad()
  End Function

  Function InsertarConsulta(consulta As Consulta)
    Return DaoDatos.InsertarConsulta(consulta)
  End Function

  Function GetTipoConsulta()
    Return DaoDatos.GetTipoConsulta()
  End Function

  Function GetEspecialidad()
    Return DaoDatos.GetEspecialidad()
  End Function

  Function GetConsultasPaciente(paciente As Paciente)
    Return DaoDatos.GetConsultasPaciente(paciente)
  End Function
End Class
