Public Class Process
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ProgressBar1.Maximum = 100
        ProgressBar1.Minimum = 0
    End Sub
    Private Sub GoButton_Click(sender As Object, e As EventArgs) Handles GoButton.Click
        Timer1.Enabled = True
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Value = ProgressBar1.Value + 1
        TimerLabel1.Text = ProgressBar1.Value & " % completed"
        If ProgressBar1.Value >= 100 Then
            Timer1.Stop()
            MsgBox("Welcome User", vbInformation + vbOKOnly, "Welcome")
            ProgressBar1.Value = 0
            TimerLabel1.Text = String.Empty
        End If
    End Sub
End Class
