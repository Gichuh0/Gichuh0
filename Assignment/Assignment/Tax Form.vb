Public Class Tax_Form
    Private Sub btnComputeTax_Click(sender As Object, e As EventArgs) Handles btnComputeTax.Click
        Dim grossSalary As Double = Double.Parse(txtGrossSalary.Text)
        Dim tax As Double

        If grossSalary <= 10000 Then
            tax = grossSalary * 0.1
        ElseIf grossSalary <= 20000 Then
            tax = grossSalary * 0.2
        Else
            tax = grossSalary * 0.3
        End If

        lblTax.Text = "Tax: " & tax.ToString("C")
    End Sub


End Class