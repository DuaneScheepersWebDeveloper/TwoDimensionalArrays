<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        btnGo1 = New Button()
        btnGo2 = New Button()
        btnGo3 = New Button()
        btnGo4 = New Button()
        SuspendLayout()
        ' 
        ' btnGo1
        ' 
        btnGo1.Location = New Point(78, 12)
        btnGo1.Name = "btnGo1"
        btnGo1.Size = New Size(191, 86)
        btnGo1.TabIndex = 0
        btnGo1.Text = "Display data items row wise"
        btnGo1.UseVisualStyleBackColor = True
        ' 
        ' btnGo2
        ' 
        btnGo2.Location = New Point(78, 119)
        btnGo2.Name = "btnGo2"
        btnGo2.Size = New Size(191, 86)
        btnGo2.TabIndex = 1
        btnGo2.Text = "Display data items column wise"
        btnGo2.UseVisualStyleBackColor = True
        ' 
        ' btnGo3
        ' 
        btnGo3.Location = New Point(78, 228)
        btnGo3.Name = "btnGo3"
        btnGo3.Size = New Size(191, 86)
        btnGo3.TabIndex = 2
        btnGo3.Text = "Display all data items at once"
        btnGo3.UseVisualStyleBackColor = True
        ' 
        ' btnGo4
        ' 
        btnGo4.Location = New Point(78, 338)
        btnGo4.Name = "btnGo4"
        btnGo4.Size = New Size(191, 86)
        btnGo4.TabIndex = 3
        btnGo4.Text = "Search For a Person"
        btnGo4.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnGo4)
        Controls.Add(btnGo3)
        Controls.Add(btnGo2)
        Controls.Add(btnGo1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnGo1 As Button
    Friend WithEvents btnGo2 As Button
    Friend WithEvents btnGo3 As Button
    Friend WithEvents btnGo4 As Button
End Class
