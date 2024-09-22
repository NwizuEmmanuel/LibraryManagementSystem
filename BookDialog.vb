Imports System.Windows.Forms

Public Class BookDialog

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        If String.IsNullOrEmpty(ISBNTextBox.Text) Then
            MessageBox.Show("ISBN is invalid")
        ElseIf String.IsNullOrEmpty(TitleTextBox.Text) Then
            MessageBox.Show("Title is invalid")
        ElseIf String.IsNullOrEmpty(AuthorsTextBox.Text) Then
            MessageBox.Show("Author is invalid")
        ElseIf String.IsNullOrEmpty(PublisherTextBox.Text) Then
            MessageBox.Show("Publisher is invalid")
        ElseIf PublisherYearNumricDropdown.Value <= 0 Then
            MessageBox.Show("Year published is invalid")
        Else
            Using context As New LMS()
                Dim book As New Book() With {
                    .ISBN = ISBNTextBox.Text,
                    .Title = TitleTextBox.Text,
                    .Publisher = PublisherTextBox.Text,
                    .YearPublished = PublisherYearNumricDropdown.Value,
                    .Authors = AuthorsTextBox.Text
                    }
                context.Books.Add(book)
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
