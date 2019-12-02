Public Class FrmSolicitudes
    Dim isCollapsed As Boolean = True
    Dim panelselect As Integer
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Select Case panelselect
            Case 1
                Tiempo(isCollapsed, PanelQuimicaSan)
            Case 2
                Tiempo(isCollapsed, PanelQuimicaClinica)
            Case 3
                'Return "tres"
            Case 4
                'Return "cuatro"
            Case 5
                'Return "cinco"
            Case Else
                'Return "error"
        End Select

    End Sub

    Private Sub GunaButton1_Click(sender As Object, e As EventArgs) Handles GunaButton1.Click
        Timer1.Start()
        panelselect = 1
    End Sub

    Public Sub Tiempo(ByVal bandera As Boolean, ByVal panel As Panel)
        If isCollapsed Then
            panel.Height += 10
            If panel.Size = panel.MaximumSize Then
                Timer1.Stop()
                isCollapsed = False
            End If
        Else
            panel.Height -= 15
            If panel.Size = panel.MinimumSize Then
                Timer1.Stop()
                isCollapsed = True
            End If
        End If
    End Sub

    Private Sub GunaButton2_Click(sender As Object, e As EventArgs) Handles GunaButton2.Click
        Timer1.Start()
        panelselect = 2
    End Sub

    Private Sub GunaCheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles GunaCheckBox1.CheckedChanged
        'dgEstudios.
    End Sub
End Class