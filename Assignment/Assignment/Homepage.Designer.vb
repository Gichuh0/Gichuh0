<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Homepage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Homepage))
        btnTaxComputation = New Button()
        btnLoops = New Button()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' btnTaxComputation
        ' 
        btnTaxComputation.Font = New Font("Segoe Script", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnTaxComputation.Location = New Point(164, 116)
        btnTaxComputation.Name = "btnTaxComputation"
        btnTaxComputation.Size = New Size(75, 36)
        btnTaxComputation.TabIndex = 0
        btnTaxComputation.Text = "Tax Computation"
        btnTaxComputation.UseVisualStyleBackColor = True
        ' 
        ' btnLoops
        ' 
        btnLoops.Font = New Font("Segoe Script", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnLoops.Location = New Point(589, 116)
        btnLoops.Name = "btnLoops"
        btnLoops.Size = New Size(75, 36)
        btnLoops.TabIndex = 1
        btnLoops.Text = "Loops"
        btnLoops.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = SystemColors.Control
        Label1.Font = New Font("Georgia", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(195, 22)
        Label1.Name = "Label1"
        Label1.Size = New Size(468, 25)
        Label1.TabIndex = 2
        Label1.Text = "Welcome To The Internal Revenue Service"
        ' 
        ' Homepage
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Highlight
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(800, 450)
        Controls.Add(Label1)
        Controls.Add(btnLoops)
        Controls.Add(btnTaxComputation)
        Name = "Homepage"
        Text = "Homepage"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnTaxComputation As Button
    Friend WithEvents btnLoops As Button
    Friend WithEvents Label1 As Label
End Class
