
Public Class LoginForm

    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See https://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Using context As New LMS()
            Dim usernameExit = context.Users.Any(Function(u) u.Username = UsernameTextBox.Text)
            Dim passwordExit = context.Users.Any(Function(u) u.Password = PasswordTextBox.Text)
            If usernameExit And passwordExit Then
                MainForm.Show()
                Me.Hide()
            Else
                MessageBox.Show("User not found")
            End If
        End Using
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

End Class
