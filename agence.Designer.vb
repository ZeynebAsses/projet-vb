<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class agence
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(agence))
        txtUserName = New TextBox()
        cbRole = New ComboBox()
        btnLogin = New Button()
        txtPassword = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        SuspendLayout()
        ' 
        ' txtUserName
        ' 
        txtUserName.BackColor = SystemColors.ControlLightLight
        txtUserName.Location = New Point(90, 141)
        txtUserName.Name = "txtUserName"
        txtUserName.Size = New Size(125, 27)
        txtUserName.TabIndex = 0
        ' 
        ' cbRole
        ' 
        cbRole.BackColor = SystemColors.ControlLightLight
        cbRole.FormattingEnabled = True
        cbRole.Items.AddRange(New Object() {"adminstrateur", "utilisateur"})
        cbRole.Location = New Point(637, 141)
        cbRole.Name = "cbRole"
        cbRole.Size = New Size(151, 28)
        cbRole.TabIndex = 1
        ' 
        ' btnLogin
        ' 
        btnLogin.BackColor = Color.Sienna
        btnLogin.Font = New Font("Showcard Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnLogin.Location = New Point(281, 362)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(196, 48)
        btnLogin.TabIndex = 2
        btnLogin.Text = "CONNECTE"
        btnLogin.UseVisualStyleBackColor = False
        ' 
        ' txtPassword
        ' 
        txtPassword.BackColor = SystemColors.ControlLightLight
        txtPassword.Location = New Point(424, 141)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(125, 27)
        txtPassword.TabIndex = 3
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.SaddleBrown
        Label1.Font = New Font("Arial Rounded MT Bold", 16.2F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(7, 137)
        Label1.Name = "Label1"
        Label1.Size = New Size(77, 32)
        Label1.TabIndex = 4
        Label1.Text = "Nom"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.SaddleBrown
        Label2.Font = New Font("Arial Rounded MT Bold", 16.2F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(555, 137)
        Label2.Name = "Label2"
        Label2.Size = New Size(76, 32)
        Label2.TabIndex = 5
        Label2.Text = "Role"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.SaddleBrown
        Label3.Font = New Font("Arial Rounded MT Bold", 16.2F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(221, 137)
        Label3.Name = "Label3"
        Label3.Size = New Size(155, 32)
        Label3.TabIndex = 6
        Label3.Text = "mot passe"
        ' 
        ' agence
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Highlight
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(800, 450)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txtPassword)
        Controls.Add(btnLogin)
        Controls.Add(cbRole)
        Controls.Add(txtUserName)
        Name = "agence"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtUserName As TextBox
    Friend WithEvents cbRole As ComboBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label

End Class
