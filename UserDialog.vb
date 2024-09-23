Imports System.Windows.Forms

Public Class UserDialog
    'command type: insert or update
    'command type default: update
    Private _commandType As String
    Private _username As String
    Private _password As String
    Private _role As String
    Private _id As String

    Public Sub New(Optional username As String = "", Optional password As String = "", Optional role As String = "", Optional id As Integer = 0, Optional commandType As String = "update")

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        If _commandType = "update" Then
            UsernameTextBox.Text = username
            PasswordTextBox.Text = password
            RoleComboBox.Text = role
            _id = id
        End If
    End Sub
    'Public Property Id As Integer
    '    Get
    '        Return _id
    '    End Get
    '    Set(value As Integer)
    '        _id = value
    '    End Set
    'End Property
    'Public Property Username As String
    '    Get
    '        Return _username
    '    End Get
    '    Set(value As String)
    '        _username = value
    '    End Set
    'End Property

    'Public Property Password As String
    '    Get
    '        Return _password
    '    End Get
    '    Set(value As String)
    '        _password = value
    '    End Set
    'End Property

    'Public Property Role As String
    '    Get
    '        Return _role
    '    End Get
    '    Set(value As String)
    '        _role = value
    '    End Set
    'End Property
    'Public Property CommandType() As String
    '    Get
    '        Return _commandType
    '    End Get
    '    Set(value As String)
    '        _commandType = value
    '    End Set
    'End Property

    Private Sub AddUser()
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
            Dim control As New LMSMainControl()
            control.LoadUserData()
            Me.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.Close()
        End If
    End Sub

    Private Sub UpdateUser()
        If String.IsNullOrEmpty(UsernameTextBox.Text) Then
            MessageBox.Show("Username invalid")
        ElseIf String.IsNullOrEmpty(PasswordTextBox.Text) Then
            MessageBox.Show("Password invalid")
        ElseIf String.IsNullOrEmpty(RoleComboBox.Text) Then
            MessageBox.Show("Role is empty")
        Else
            Using context As New LMS()
                Dim user = context.Users.Find(_id)

                If user IsNot Nothing Then
                    user.Username = UsernameTextBox.Text
                    user.Password = PasswordTextBox.Text
                    user.Role = RoleComboBox.Text

                    context.SaveChanges()
                End If
            End Using
            Me.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.Close()
        End If
    End Sub
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        If _commandType = "insert" Then
            AddUser()
        ElseIf _commandType = "update" Then
            UpdateUser()
        End If
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

End Class
