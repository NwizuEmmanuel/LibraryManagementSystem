Imports System.Windows.Forms

Public Class UserDialog

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        If String.IsNullOrEmpty(UsernameTextBox.Text) Then
            MessageBox.Show("Username invalid")
        ElseIf String.IsNullOrEmpty(PasswordTextBox.Text) Then
            MessageBox.Show("Password invalid")
        ElseIf String.IsNullOrEmpty(RoleComboBox.Text) Then
            MessageBox.Show("Role is empty")
        Else
            Using context As New LMS()
                Dim user As New User() With {
                    .Username = UsernameTextBox.Text,
                    .Password = PasswordTextBox.Text,
                    .Role = RoleComboBox.Text
                    }
                context.Users.Add(user)
                context.SaveChanges()
            End Using
            Me.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.Close()
        End If
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

End Class
