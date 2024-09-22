Public Class LMSMainControl
    Private _title As String

    Public Sub New(ByVal title As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _title = title
        LoadDataTable()
    End Sub
    Private Sub LoadUserData()
        Using context As New LMS()
            Dim users = context.Users.ToList()
            DataGridView1.DataSource = users
        End Using
    End Sub

    Private Sub LoadBookData()
        Using context As New LMS()
            Dim books = context.Books.ToList()
            DataGridView1.DataSource = books
        End Using
    End Sub

    Private Sub LoadStudentData()
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
            UserDialog.ShowDialog()
        End If
    End Sub
End Class
