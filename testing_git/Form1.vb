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
        'comment
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MsgBox("Button testing", 0, "Button")
    End Sub
End Class
