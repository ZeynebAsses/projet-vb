Public Class agence
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim username As String = txtUserName.Text
        Dim password As String = txtPassword.Text
        Dim role As String = cbRole.SelectedItem


        If username = "" Or password = "" Or role = "" Then
            MessageBox.Show("Veuillez remplir tous les champs.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If


        If username = "admin" And password = "0000" And role = "admi" Then
            MessageBox.Show("Connexion réussieen tant qu'admin.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)


            Dim adminForm As New admin()
            adminForm.Show()
            Me.Hide()

        ElseIf username = "utilisateur" And password = "1111" And role = "utilisateur" Then
            MessageBox.Show("Connexion réussie en tant qu'Utilisateur.", "Info", MessageBoxButtons.OK)


            Dim utilisateurForm As New reserv()
            utilisateurForm.Show()
            Me.Hide()

        Else

            MessageBox.Show("Identifiants ou rôle incorrects.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub agence_Load(sender As Object, e As EventArgs)

    End Sub
End Class
