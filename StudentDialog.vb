Imports System.Windows.Forms

Public Class StudentDialog

    Private Function GetSex() As String
        Dim result = OthersRadioButton.Text.ToString()
        If MaleRadioButton.Checked Then
            result = MaleRadioButton.Text.ToString()
        ElseIf FemaleRadioButton.Checked Then
            result = FemaleRadioButton.Text.ToString()
        ElseIf OthersRadioButton.Checked Then
            result = OthersRadioButton.Text.ToString()
        End If
        Return result
    End Function

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Try
            Using context As New LMS()
                Dim students As New Student() With {
                    .Firstname = FirstnameTextBox.Text,
                    .Middlename = If(MiddlenameTextBox.Text <> Nothing, MiddlenameTextBox.Text, Nothing),
                    .Lastname = LastnameTextBox.Text,
                    .Course = CourseTextBox.Text,
                    .Sex = GetSex()
                }
                context.Students.Add(students)
                context.SaveChanges()
            End Using
            Me.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

End Class
