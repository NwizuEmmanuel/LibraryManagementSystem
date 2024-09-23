Public Class MainForm

    Private Sub BooksButton_Click(sender As Object, e As EventArgs) Handles BooksButton.Click
        MainHomePanel.Controls.Clear()
        Dim control As New LMSMainControl("Book Section") With {
            .Dock = DockStyle.Fill
        }
        MainHomePanel.Controls.Add(control)
    End Sub

    Private Sub StudentsButton_Click(sender As Object, e As EventArgs) Handles StudentsButton.Click
        MainHomePanel.Controls.Clear()
        Dim control As New LMSMainControl("Student Section") With {
            .Dock = DockStyle.Fill
        }
        MainHomePanel.Controls.Add(control)
    End Sub

    Private Sub UsersButton_Click(sender As Object, e As EventArgs) Handles UsersButton.Click
        MainHomePanel.Controls.Clear()
        Dim control As New LMSMainControl("User Section") With {
            .Dock = DockStyle.Fill
        }
        MainHomePanel.Controls.Add(control)
    End Sub
End Class
