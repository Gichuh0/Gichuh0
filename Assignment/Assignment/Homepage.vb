Public Class Homepage
    Private Sub btnTaxComputation_Click(sender As Object, e As EventArgs) Handles btnTaxComputation.Click
        Dim taxForm As New Tax_Form()
        taxForm.Show()
        Me.Hide()
    End Sub

    Private Sub btnLoops_Click(sender As Object, e As EventArgs) Handles btnLoops.Click
        Dim loopsForm As New Loops_Form()
        loopsForm.Show()
        Me.Hide()
    End Sub
End Class
