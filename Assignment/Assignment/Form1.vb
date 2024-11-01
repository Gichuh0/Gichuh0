Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'CheckBox If both fields are filled
        If txtUsername.Text = "admin" Or txtpassword.Text = "password" Then
            Dim homePage As New Form1()
            homePage.Show()
            Me.Hide()
        Else
            MessageBox.Show("Invalid login credentials")
        End If
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
End Class
