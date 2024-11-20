<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminLogin
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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        Button1 = New Button()
        Button2 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Rockwell", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(286, 103)
        Label1.Name = "Label1"
        Label1.Size = New Size(173, 27)
        Label1.TabIndex = 0
        Label1.Text = "ADMIN LOGIN"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Rockwell", 9F)
        Label2.Location = New Point(180, 157)
        Label2.Name = "Label2"
        Label2.Size = New Size(63, 14)
        Label2.TabIndex = 1
        Label2.Text = "Username"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Rockwell", 9F)
        Label3.Location = New Point(180, 202)
        Label3.Name = "Label3"
        Label3.Size = New Size(61, 14)
        Label3.TabIndex = 2
        Label3.Text = "Password"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(246, 154)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(274, 23)
        TextBox1.TabIndex = 3
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(246, 199)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(274, 23)
        TextBox2.TabIndex = 4
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Rockwell", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(334, 252)
        Button1.Name = "Button1"
        Button1.Size = New Size(79, 25)
        Button1.TabIndex = 5
        Button1.Text = "LOGIN"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Rockwell", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button2.Location = New Point(12, 413)
        Button2.Name = "Button2"
        Button2.Size = New Size(85, 25)
        Button2.TabIndex = 6
        Button2.Text = "<- Go back"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' AdminLogin
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "AdminLogin"
        Text = "AdminLogin"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
