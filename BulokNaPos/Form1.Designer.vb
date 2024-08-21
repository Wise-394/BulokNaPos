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
        lbUname = New Label()
        lbPword = New Label()
        tbUname = New TextBox()
        tbPword = New TextBox()
        btnLogin = New Button()
        SuspendLayout()
        ' 
        ' lbUname
        ' 
        lbUname.AutoSize = True
        lbUname.Location = New Point(243, 109)
        lbUname.Name = "lbUname"
        lbUname.Size = New Size(60, 15)
        lbUname.TabIndex = 0
        lbUname.Text = "Username"
        ' 
        ' lbPword
        ' 
        lbPword.AutoSize = True
        lbPword.Location = New Point(243, 139)
        lbPword.Name = "lbPword"
        lbPword.Size = New Size(57, 15)
        lbPword.TabIndex = 1
        lbPword.Text = "Password"
        ' 
        ' tbUname
        ' 
        tbUname.Location = New Point(309, 106)
        tbUname.Name = "tbUname"
        tbUname.Size = New Size(100, 23)
        tbUname.TabIndex = 2
        ' 
        ' tbPword
        ' 
        tbPword.Location = New Point(309, 136)
        tbPword.Name = "tbPword"
        tbPword.Size = New Size(100, 23)
        tbPword.TabIndex = 3
        ' 
        ' btnLogin
        ' 
        btnLogin.Location = New Point(320, 165)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(75, 23)
        btnLogin.TabIndex = 4
        btnLogin.Text = "Login"
        btnLogin.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnLogin)
        Controls.Add(tbPword)
        Controls.Add(tbUname)
        Controls.Add(lbPword)
        Controls.Add(lbUname)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lbUname As Label
    Friend WithEvents lbPword As Label
    Friend WithEvents tbUname As TextBox
    Friend WithEvents tbPword As TextBox
    Friend WithEvents btnLogin As Button

End Class
