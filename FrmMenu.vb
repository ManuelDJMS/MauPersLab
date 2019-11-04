Public Class FrmHome
    Private Sub FrmHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Size = New Size(800, 600)
        Me.StartPosition = FormStartPosition.CenterScreen
        Guna.UI.Lib.GraphicsHelper.ShadowForm(Me)
        Guna.UI.Lib.GraphicsHelper.DrawLineShadow(GunaPanel3, Color.Black, 20, 10, Guna.UI.WinForms.VerHorAlign.HoriziontalTop)

    End Sub
End Class
