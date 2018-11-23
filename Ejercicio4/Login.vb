Public Class frmLogin
  Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

  End Sub

  Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
    Application.Exit()
  End Sub

  Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click

    If (txtUser.Text.Equals("admin") And txtPassword.Text.Equals("admin")) Then
      Me.Hide()
      Principal.Show()
    Else
      txtUser.Text = ""
      txtPassword.Text = ""
      MsgBox("El usuario es inválido", MsgBoxStyle.Information, "Alerta")
    End If

  End Sub
End Class