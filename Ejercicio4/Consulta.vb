Public Class Consulta

  Protected _id As Integer
  Protected _motivo As String
  Protected _diagnostico As String
  Protected _fechaConsulta As Date
  Protected _idTipoConsulta As Integer
  Protected _idEspecialidad As Integer
  Protected _idPaciente As Integer

  Public Property ID As Integer
    Get
      Return _id
    End Get
    Set(value As Integer)
      _id = value
    End Set
  End Property

  Public Property Motivo As String
    Get
      Return _motivo
    End Get
    Set(value As String)
      _motivo = value
    End Set
  End Property
  Public Property FechaConsulta As Date
    Get
      Return _fechaConsulta
    End Get
    Set(value As Date)
      _fechaConsulta = value
    End Set
  End Property
  Public Property Diagnostico As String
    Get
      Return _diagnostico
    End Get
    Set(value As String)
      _diagnostico = value
    End Set
  End Property

  Public Property IdTipoConsulta As Integer
    Get
      Return _idTipoConsulta
    End Get
    Set(value As Integer)
      _idTipoConsulta = value
    End Set
  End Property

  Public Property IdEspecialidad As Integer
    Get
      Return _idEspecialidad
    End Get
    Set(value As Integer)
      _idEspecialidad = value
    End Set
  End Property

  Public Property IdPaciente As Integer
    Get
      Return _idPaciente
    End Get
    Set(value As Integer)
      _idPaciente = value
    End Set
  End Property

End Class
