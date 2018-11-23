Imports System.Data.OleDb
Public Class DaoDatos

  Dim conexion As New Conexion()

  Function GetPaciente()
    Dim command As New OleDbCommand
    Dim dataset As New DataSet

    command.Connection = conexion.GetConexion()
    conexion.AbrirConexion()

    command.CommandText = "select * from Paciente"

    Dim reader As New OleDbDataAdapter
    reader.SelectCommand = command
    reader.Fill(dataset)

    conexion.CerrarConexion()

    Return dataset.Tables(0)

  End Function

  Function GetTipoConsulta()
    Dim command As New OleDbCommand
    Dim dataset As New DataSet

    command.Connection = conexion.GetConexion()
    conexion.AbrirConexion()

    command.CommandText = "select * from TipoConsulta"

    Dim reader As New OleDbDataAdapter
    reader.SelectCommand = command
    reader.Fill(dataset)

    conexion.CerrarConexion()

    Return dataset.Tables(0)

  End Function
  Function GetEspecialidad()
    Dim command As New OleDbCommand
    Dim dataset As New DataSet

    command.Connection = conexion.GetConexion()
    conexion.AbrirConexion()

    command.CommandText = "select * from Especialidad"

    Dim reader As New OleDbDataAdapter
    reader.SelectCommand = command
    reader.Fill(dataset)

    conexion.CerrarConexion()

    Return dataset.Tables(0)

  End Function

  Function GetConsulta()
    Dim command As New OleDbCommand
    Dim dataset As New DataSet

    command.Connection = conexion.GetConexion()
    conexion.AbrirConexion()

    command.CommandText = "select * from Consultas"

    Dim reader As New OleDbDataAdapter
    reader.SelectCommand = command
    reader.Fill(dataset)

    conexion.CerrarConexion()

    Return dataset.Tables(0)

  End Function
  Function GetIDTipoConsulta()
    Dim command As New OleDbCommand
    Dim dataset As New DataSet

    command.Connection = conexion.GetConexion()
    conexion.AbrirConexion()

    command.CommandText = "select * from TipoConsulta"

    Dim reader As New OleDbDataAdapter
    reader.SelectCommand = command
    reader.Fill(dataset)

    conexion.CerrarConexion()

    Return dataset.Tables(0)

  End Function
  Function GetIDEspecialidad()
    Dim command As New OleDbCommand
    Dim dataset As New DataSet

    command.Connection = conexion.GetConexion()
    conexion.AbrirConexion()

    command.CommandText = "select * from Especialidad"

    Dim reader As New OleDbDataAdapter
    reader.SelectCommand = command
    reader.Fill(dataset)

    conexion.CerrarConexion()

    Return dataset.Tables(0)
  End Function

  Function GetConsultasPaciente(paciente As Paciente)
    Dim command As New OleDbCommand
    Dim dataset As New DataSet

    command.Connection = conexion.GetConexion()
    conexion.AbrirConexion()

    command.CommandText = "select * from Consultas where IDPaciente =" & paciente.ID

    Dim reader As New OleDbDataAdapter
    reader.SelectCommand = command
    reader.Fill(dataset)

    conexion.CerrarConexion()

    Return dataset.Tables(0)
  End Function
  Function InsertarConsulta(consulta As Consulta)
    Dim command As New OleDbCommand
    command.Connection = conexion.GetConexion()
    conexion.AbrirConexion()

    command.CommandText = "Insert into Consultas (Motivo, Diagnostico, FechaConsulta, IDTipoConsulta, IDEspecialidad, IDPaciente) values ('" & consulta.Motivo & "','" & consulta.Diagnostico & "','" & consulta.FechaConsulta.ToString() & "'," & consulta.IdTipoConsulta & "," & consulta.IdEspecialidad & "," & consulta.IdPaciente & ") "
    command.ExecuteNonQuery()

    conexion.CerrarConexion()

    Return consulta
  End Function
  Function ModificarConsulta(consulta As Consulta)


    Dim command As New OleDbCommand
    command.Connection = conexion.GetConexion()

    conexion.AbrirConexion()

    command.CommandText = "Update Consultas set Motivo = '" & consulta.Motivo & "' , Diagnostico = '" & consulta.Diagnostico & "', FechaConsulta = '" & consulta.FechaConsulta.ToString() & "', IDTipoConsulta = " & consulta.IdTipoConsulta & ", IDEspecialidad = " & consulta.IdEspecialidad & ", IDPaciente= " & consulta.IdPaciente & " where ID = " & consulta.ID & ""
    command.ExecuteNonQuery()

    conexion.CerrarConexion()

    Return consulta

  End Function

  Function EliminarConsulta(consulta As Consulta)


    Dim command As New OleDbCommand
    command.Connection = conexion.GetConexion()

    conexion.AbrirConexion()

    command.CommandText = "Delete from Consultas where ID = " & consulta.ID & ""
    command.ExecuteNonQuery()

    conexion.CerrarConexion()

    Return consulta

  End Function
End Class
