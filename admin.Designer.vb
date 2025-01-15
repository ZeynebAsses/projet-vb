<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class admin
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(admin))
        txtNumVol = New TextBox()
        btnAjouter = New Button()
        dgvVols = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column6 = New DataGridViewTextBoxColumn()
        txtPrix = New TextBox()
        txtPlaces = New TextBox()
        txtDestination = New TextBox()
        txtDate = New TextBox()
        btnModifier = New Button()
        btnSupprimer = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        CType(dgvVols, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtNumVol
        ' 
        txtNumVol.Location = New Point(163, 13)
        txtNumVol.Name = "txtNumVol"
        txtNumVol.Size = New Size(125, 27)
        txtNumVol.TabIndex = 0
        ' 
        ' btnAjouter
        ' 
        btnAjouter.BackColor = Color.Orange
        btnAjouter.Font = New Font("Segoe UI Black", 13.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        btnAjouter.Location = New Point(178, 190)
        btnAjouter.Name = "btnAjouter"
        btnAjouter.Size = New Size(133, 41)
        btnAjouter.TabIndex = 1
        btnAjouter.Text = "Ajouter"
        btnAjouter.UseVisualStyleBackColor = False
        ' 
        ' dgvVols
        ' 
        dgvVols.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvVols.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column4, Column6})
        dgvVols.Location = New Point(94, 316)
        dgvVols.Name = "dgvVols"
        dgvVols.RowHeadersWidth = 51
        dgvVols.Size = New Size(597, 131)
        dgvVols.TabIndex = 2
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "NUM"
        Column1.MinimumWidth = 6
        Column1.Name = "Column1"
        Column1.Width = 125
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "DESTINATION"
        Column2.MinimumWidth = 6
        Column2.Name = "Column2"
        Column2.Width = 125
        ' 
        ' Column3
        ' 
        Column3.HeaderText = "DATE"
        Column3.MinimumWidth = 6
        Column3.Name = "Column3"
        Column3.Width = 125
        ' 
        ' Column4
        ' 
        Column4.HeaderText = "PLACES"
        Column4.MinimumWidth = 6
        Column4.Name = "Column4"
        Column4.Width = 125
        ' 
        ' Column6
        ' 
        Column6.HeaderText = "PRIX"
        Column6.MinimumWidth = 6
        Column6.Name = "Column6"
        Column6.Width = 125
        ' 
        ' txtPrix
        ' 
        txtPrix.Location = New Point(255, 101)
        txtPrix.Name = "txtPrix"
        txtPrix.Size = New Size(125, 27)
        txtPrix.TabIndex = 3
        ' 
        ' txtPlaces
        ' 
        txtPlaces.Location = New Point(386, 56)
        txtPlaces.Name = "txtPlaces"
        txtPlaces.Size = New Size(125, 27)
        txtPlaces.TabIndex = 4
        ' 
        ' txtDestination
        ' 
        txtDestination.Location = New Point(163, 56)
        txtDestination.Name = "txtDestination"
        txtDestination.Size = New Size(125, 27)
        txtDestination.TabIndex = 5
        ' 
        ' txtDate
        ' 
        txtDate.Location = New Point(386, 10)
        txtDate.Name = "txtDate"
        txtDate.Size = New Size(125, 27)
        txtDate.TabIndex = 6
        ' 
        ' btnModifier
        ' 
        btnModifier.BackColor = Color.Orange
        btnModifier.Font = New Font("Segoe UI Black", 13.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        btnModifier.Location = New Point(324, 190)
        btnModifier.Name = "btnModifier"
        btnModifier.Size = New Size(139, 41)
        btnModifier.TabIndex = 7
        btnModifier.Text = "Modifier"
        btnModifier.UseVisualStyleBackColor = False
        ' 
        ' btnSupprimer
        ' 
        btnSupprimer.BackColor = Color.Orange
        btnSupprimer.Font = New Font("Segoe UI Black", 13.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        btnSupprimer.Location = New Point(481, 190)
        btnSupprimer.Name = "btnSupprimer"
        btnSupprimer.Size = New Size(139, 41)
        btnSupprimer.TabIndex = 8
        btnSupprimer.Text = "Supprimer"
        btnSupprimer.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.SaddleBrown
        Label1.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(61, 14)
        Label1.Name = "Label1"
        Label1.Size = New Size(88, 23)
        Label1.TabIndex = 9
        Label1.Text = "Numero"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Sienna
        Label2.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(202, 101)
        Label2.Name = "Label2"
        Label2.Size = New Size(47, 23)
        Label2.TabIndex = 10
        Label2.Text = "Prix"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.SaddleBrown
        Label3.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(305, 56)
        Label3.Name = "Label3"
        Label3.Size = New Size(75, 23)
        Label3.TabIndex = 11
        Label3.Text = "Places"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.SaddleBrown
        Label4.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(324, 14)
        Label4.Name = "Label4"
        Label4.Size = New Size(56, 23)
        Label4.TabIndex = 12
        Label4.Text = "Date"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.SaddleBrown
        Label5.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(39, 60)
        Label5.Name = "Label5"
        Label5.Size = New Size(118, 23)
        Label5.TabIndex = 13
        Label5.Text = "destination"
        ' 
        ' admin
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(800, 450)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btnSupprimer)
        Controls.Add(btnModifier)
        Controls.Add(txtDate)
        Controls.Add(txtDestination)
        Controls.Add(txtPlaces)
        Controls.Add(txtPrix)
        Controls.Add(dgvVols)
        Controls.Add(btnAjouter)
        Controls.Add(txtNumVol)
        Name = "admin"
        Text = "admin"
        CType(dgvVols, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtNumVol As TextBox
    Friend WithEvents btnAjouter As Button
    Friend WithEvents dgvVols As DataGridView
    Friend WithEvents txtPrix As TextBox
    Friend WithEvents txtPlaces As TextBox
    Friend WithEvents txtDestination As TextBox
    Friend WithEvents txtDate As TextBox
    Friend WithEvents btnModifier As Button
    Friend WithEvents btnSupprimer As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
End Class
