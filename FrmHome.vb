Public Class FrmHome
    Private Sub FrmHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Size = New Size(800, 600)
        Me.StartPosition = FormStartPosition.CenterScreen
        GunaAnimateWindow1.AnimationType = Guna.UI.WinForms.GunaAnimateWindow.AnimateWindowType.AW_BLEND
        GunaAnimateWindow1.Start()
        Guna.UI.Lib.GraphicsHelper.ShadowForm(Me)
        Guna.UI.Lib.GraphicsHelper.DrawLineShadow(GunaPanel3, Color.Black, 20, 10, Guna.UI.WinForms.VerHorAlign.HoriziontalTop)

    End Sub

    Private Sub GunaAdvenceButton3_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton3.Click
        Panel2.Visible = True
        Panel1.BringToFront()
        GunaTransition1.Hide(Panel1)
    End Sub

    Private Sub btnMenu_Click(sender As Object, e As EventArgs) Handles btnMenu.Click
        Panel1.BringToFront()
        GunaTransition1.Show(Panel1)
    End Sub

    Private Sub btnSolicitudes_Click(sender As Object, e As EventArgs) Handles btnSolicitudes.Click
        FrmSolicitudes.Show()
    End Sub
End Class
