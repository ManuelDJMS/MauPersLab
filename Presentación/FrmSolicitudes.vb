Public Class FrmSolicitudes
    Dim isCollapsed As Boolean
    Private Sub btnEtiquetas_Click(sender As Object, e As EventArgs)
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'If isCollapsed Then
        '    Panel3.Height += 10
        '    If Panel3.Size = Panel3.MaximumSize Then
        '        Timer1.Stop()
        '        isCollapsed = False
        '    End If
        'Else
        '    Panel3.Height -= 15
        '    If Panel3.Size = Panel3.MinimumSize Then
        '        Timer1.Stop()
        '        isCollapsed = True
        '    End If
        'End If
    End Sub
End Class