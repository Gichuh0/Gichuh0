<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Loops_Form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Loops_Form))
        btnForLoop = New Button()
        lblForLoopResult = New Label()
        lblDoWhileLoopResult = New Label()
        btnDoWhileLoop = New Button()
        SuspendLayout()
        ' 
        ' btnForLoop
        ' 
        resources.ApplyResources(btnForLoop, "btnForLoop")
        btnForLoop.Name = "btnForLoop"
        btnForLoop.UseVisualStyleBackColor = True
        ' 
        ' lblForLoopResult
        ' 
        resources.ApplyResources(lblForLoopResult, "lblForLoopResult")
        lblForLoopResult.Name = "lblForLoopResult"
        ' 
        ' lblDoWhileLoopResult
        ' 
        resources.ApplyResources(lblDoWhileLoopResult, "lblDoWhileLoopResult")
        lblDoWhileLoopResult.Name = "lblDoWhileLoopResult"
        ' 
        ' btnDoWhileLoop
        ' 
        resources.ApplyResources(btnDoWhileLoop, "btnDoWhileLoop")
        btnDoWhileLoop.Name = "btnDoWhileLoop"
        btnDoWhileLoop.UseVisualStyleBackColor = True
        ' 
        ' Loops_Form
        ' 
        resources.ApplyResources(Me, "$this")
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(btnDoWhileLoop)
        Controls.Add(lblDoWhileLoopResult)
        Controls.Add(lblForLoopResult)
        Controls.Add(btnForLoop)
        Name = "Loops_Form"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnForLoop As Button
    Friend WithEvents lblForLoopResult As Label
    Friend WithEvents lblDoWhileLoopResult As Label
    Friend WithEvents btnDoWhileLoop As Button
End Class
