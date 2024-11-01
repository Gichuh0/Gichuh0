<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Tax_Form
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Tax_Form))
        txtGrossSalary = New TextBox()
        btnComputeTax = New Button()
        lblTax = New Label()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' txtGrossSalary
        ' 
        txtGrossSalary.Location = New Point(468, 77)
        txtGrossSalary.Name = "txtGrossSalary"
        txtGrossSalary.Size = New Size(129, 23)
        txtGrossSalary.TabIndex = 0
        ' 
        ' btnComputeTax
        ' 
        btnComputeTax.Location = New Point(468, 137)
        btnComputeTax.Name = "btnComputeTax"
        btnComputeTax.Size = New Size(129, 23)
        btnComputeTax.TabIndex = 1
        btnComputeTax.Text = "Calculate"
        btnComputeTax.UseVisualStyleBackColor = True
        ' 
        ' lblTax
        ' 
        lblTax.AutoSize = True
        lblTax.Location = New Point(387, 186)
        lblTax.Name = "lblTax"
        lblTax.Size = New Size(83, 15)
        lblTax.TabIndex = 2
        lblTax.Text = " Tax to be paid"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(182, 78)
        Label1.Name = "Label1"
        Label1.Size = New Size(211, 22)
        Label1.TabIndex = 3
        Label1.Text = "Enter Your Gross Salary"
        ' 
        ' Tax_Form
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(800, 450)
        Controls.Add(Label1)
        Controls.Add(lblTax)
        Controls.Add(btnComputeTax)
        Controls.Add(txtGrossSalary)
        Name = "Tax_Form"
        Text = "Tax_Form"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtGrossSalary As TextBox
    Friend WithEvents btnComputeTax As Button
    Friend WithEvents lblTax As Label
    Friend WithEvents Label1 As Label
End Class
