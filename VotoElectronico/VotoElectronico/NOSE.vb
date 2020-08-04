Public Class NOSE
    Public contador As Integer
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        contador += 1
        If Me.Opacity < 1 Then
            Me.Opacity += 0.05
        End If

        If contador = 130 Then
            Timer1.Stop()
            Timer2.Start()
        End If
        If contador = 40 Then
            Label3.Text = "Ahhhhh se crean 
                           es Broma!!!!"
        End If

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Me.Opacity -= 0.05
        If Me.Opacity = 0 Then
            Timer2.Stop()
            Me.Close()
            Login.Show()
        End If
    End Sub

    Private Sub NOSE_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        contador = 0
        Me.Opacity = 0
        Timer1.Start()
    End Sub
End Class