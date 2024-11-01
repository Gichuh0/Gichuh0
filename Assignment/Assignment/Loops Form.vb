Public Class Loops_Form
    Private Sub btnForLoop_Click(sender As Object, e As EventArgs) Handles btnForLoop.Click
        Dim result As String = ""
        For i As Integer = 1 To 10
            result &= i.ToString() & " "
        Next
        lblForLoopResult.Text = result
    End Sub

    Private Sub btnDoWhileLoop_Click(sender As Object, e As EventArgs) Handles btnDoWhileLoop.Click
        Dim result As String = ""
        Dim i As Integer = 1
        Do While i <= 10
            result &= i.ToString() & " "
            i += 1
        Loop
        lblDoWhileLoopResult.Text = result
    End Sub
End Class