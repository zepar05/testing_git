Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblPaymentResult.Text = "Git Test: " & Now.ToString("HH : mm : ss")
        'one more modification plis
        'one more'
        'testing'
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox("bye")
        Me.Hide()
        Form2.Show()

    End Sub
End Class
