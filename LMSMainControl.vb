﻿Public Class LMSMainControl
    Private _title As String

<<<<<<< HEAD
    Public Sub New(ByVal title As String)
=======
    Public Sub New(Optional title As String = "")
>>>>>>> origin/school

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _title = title
        LoadDataTable()
    End Sub
<<<<<<< HEAD
    Private Sub LoadUserData()
=======
    Public Sub LoadUserData()
>>>>>>> origin/school
        Using context As New LMS()
            Dim users = context.Users.ToList()
            DataGridView1.DataSource = users
        End Using
    End Sub

<<<<<<< HEAD
    Private Sub LoadBookData()
=======
    Public Sub LoadBookData()
>>>>>>> origin/school
        Using context As New LMS()
            Dim books = context.Books.ToList()
            DataGridView1.DataSource = books
        End Using
    End Sub

<<<<<<< HEAD
    Private Sub LoadStudentData()
=======
    Public Sub LoadStudentData()
>>>>>>> origin/school
        Using context As New LMS()
            Dim students = context.Students.ToList()
            DataGridView1.DataSource = students
        End Using
    End Sub
    Private Sub LoadDataTable()
        If _title = "User Section" Then
            LoadUserData()
        ElseIf _title = "Book Section" Then
            LoadBookData()
        ElseIf _title = "Student Section" Then
            LoadStudentData()
        End If
    End Sub

    Private Sub LMSMainControl_Load(sender As Object, e As EventArgs) Handles Me.Load
        TitleLabel.Text = _title
    End Sub

    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles AddButton.Click
        If _title = "Book Section" Then
            BookDialog.ShowDialog()
        ElseIf _title = "Student Section" Then
            StudentDialog.ShowDialog()
        ElseIf _title = "User Section" Then
<<<<<<< HEAD
            UserDialog.ShowDialog()
=======
            Dim userDialog As New UserDialog(commandType:="insert")
            userDialog.ShowDialog()
>>>>>>> origin/school
        End If
    End Sub

    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click
<<<<<<< HEAD

    End Sub


    Private Sub DeleteUser()
        Dim noProblem = True
        For Each selectedRows As DataGridViewRow In DataGridView1.SelectedRows
            Dim id = Convert.ToInt32(selectedRows.Cells("Id").Value)
            Using context As New LMS()
                Dim bookToDelete = context.Books.Find(id)
=======
        If _title = "User Section" Then
            DeleteUser()
        ElseIf _title = "Student Section" Then
            DeleteStudent()
        ElseIf _title = "Book Section" Then
            DeleteBook()
        End If
    End Sub

    Private Sub DeleteStudent()
        Dim selectedRow As DataGridViewRow
        If DataGridView1.SelectedRows.Count > 0 Then
            selectedRow = DataGridView1.SelectedRows(0)
            Dim bookId = Convert.ToInt32(selectedRow.Cells("Id").Value)

            Using context As New LMS()
                Dim studentToDelete = context.Students.Find(bookId)

                If studentToDelete IsNot Nothing Then
                    context.Students.Remove(studentToDelete)
                    context.SaveChanges()
                    MessageBox.Show("Delete successful.")
                Else
                    MessageBox.Show("Delete Unsuccessfully.")
                End If
            End Using
        Else
            MessageBox.Show("You must select a row.")
        End If
    End Sub
    Private Sub DeleteBook()
        Dim selectedRow As DataGridViewRow
        If DataGridView1.SelectedRows.Count > 0 Then
            selectedRow = DataGridView1.SelectedRows(0)
            Dim bookId = Convert.ToInt32(selectedRow.Cells("Id").Value)

            Using context As New LMS()
                Dim bookToDelete = context.Books.Find(bookId)
>>>>>>> origin/school

                If bookToDelete IsNot Nothing Then
                    context.Books.Remove(bookToDelete)
                    context.SaveChanges()
<<<<<<< HEAD
                Else
                    noProblem = False
                End If
            End Using
        Next
        If noProblem Then
            MessageBox.Show("Delete successful.")
        Else
            MessageBox.Show("Some or no item is deleted successfully.")
=======
                    MessageBox.Show("Delete successful.")
                Else
                    MessageBox.Show("Delete Unsuccessfully.")
                End If
            End Using
        Else
            MessageBox.Show("You must select a row.")
        End If
    End Sub
    Private Sub DeleteUser()
        Dim selectedRow As DataGridViewRow
        If DataGridView1.SelectedRows.Count > 0 Then
            selectedRow = DataGridView1.SelectedRows(0)

            Dim id = Convert.ToInt32(selectedRow.Cells("Id").Value)
            Using context As New LMS()
                Dim userToDelete = context.Users.Find(id)

                If userToDelete IsNot Nothing Then
                    context.Users.Remove(userToDelete)
                    context.SaveChanges()
                    MessageBox.Show("Delete successful.")
                Else
                    MessageBox.Show("Delete Unsuccessfully.")
                End If
            End Using
        Else
            MessageBox.Show("You must select a row.")
        End If
    End Sub

    Private Sub UpdateButton_Click(sender As Object, e As EventArgs) Handles UpdateButton.Click
        If _title = "User Section" Then
            UpdateUser()
        End If
    End Sub

    Private Sub UpdateUser()
        Dim selectedRow As DataGridViewRow
        If DataGridView1.SelectedRows.Count > 0 Then
            selectedRow = DataGridView1.SelectedRows(0)
            Dim userId = Convert.ToInt32(selectedRow.Cells("Id").Value)
            Dim username = selectedRow.Cells("Username").Value
            Dim pass = selectedRow.Cells("Password").Value
            Dim role = selectedRow.Cells("Role").Value

            Dim dialog As New UserDialog(
                username:=username,
                password:=pass,
                role:=role,
                id:=userId
)
            dialog.ShowDialog()
>>>>>>> origin/school
        End If
    End Sub
End Class
