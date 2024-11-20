Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Me.Visible = False
        StudentLogin.Visible = True

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Me.Visible = False
        AdminLogin.Visible = True
    End Sub
End Class
