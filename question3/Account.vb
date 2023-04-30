Public Class Account
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim P, A, r As Double
        Dim n As Integer
        P = 1000000D
        n = 10D
        r = 0.05
        For n = 1 To 10
            A = P * ((1 + r) ^ n)
            P = A
            ListBox1.Items.Add("Year: " & n.ToString & " Amount:" & A.ToString)
        Next
    End Sub
End Class
