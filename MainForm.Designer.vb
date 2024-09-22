<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.BooksButton = New System.Windows.Forms.Button()
        Me.StudentsButton = New System.Windows.Forms.Button()
        Me.UsersButton = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.MainHomePanel = New System.Windows.Forms.Panel()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.BooksButton)
        Me.FlowLayoutPanel1.Controls.Add(Me.StudentsButton)
        Me.FlowLayoutPanel1.Controls.Add(Me.UsersButton)
        Me.FlowLayoutPanel1.Controls.Add(Me.Button1)
        Me.FlowLayoutPanel1.Controls.Add(Me.Button2)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Padding = New System.Windows.Forms.Padding(0, 30, 0, 0)
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(153, 450)
        Me.FlowLayoutPanel1.TabIndex = 0
        '
        'BooksButton
        '
        Me.BooksButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BooksButton.Location = New System.Drawing.Point(10, 33)
        Me.BooksButton.Margin = New System.Windows.Forms.Padding(10, 3, 10, 3)
        Me.BooksButton.Name = "BooksButton"
        Me.BooksButton.Size = New System.Drawing.Size(117, 52)
        Me.BooksButton.TabIndex = 0
        Me.BooksButton.Text = "Books"
        Me.BooksButton.UseVisualStyleBackColor = True
        '
        'StudentsButton
        '
        Me.StudentsButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.StudentsButton.Location = New System.Drawing.Point(10, 91)
        Me.StudentsButton.Margin = New System.Windows.Forms.Padding(10, 3, 10, 3)
        Me.StudentsButton.Name = "StudentsButton"
        Me.StudentsButton.Size = New System.Drawing.Size(117, 52)
        Me.StudentsButton.TabIndex = 1
        Me.StudentsButton.Text = "Students"
        Me.StudentsButton.UseVisualStyleBackColor = True
        '
        'UsersButton
        '
        Me.UsersButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.UsersButton.Location = New System.Drawing.Point(10, 149)
        Me.UsersButton.Margin = New System.Windows.Forms.Padding(10, 3, 10, 3)
        Me.UsersButton.Name = "UsersButton"
        Me.UsersButton.Size = New System.Drawing.Size(117, 52)
        Me.UsersButton.TabIndex = 2
        Me.UsersButton.Text = "Users"
        Me.UsersButton.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Location = New System.Drawing.Point(10, 207)
        Me.Button1.Margin = New System.Windows.Forms.Padding(10, 3, 10, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(117, 52)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Books"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.Location = New System.Drawing.Point(10, 265)
        Me.Button2.Margin = New System.Windows.Forms.Padding(10, 3, 10, 3)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(117, 52)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Books"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'MainHomePanel
        '
        Me.MainHomePanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainHomePanel.Location = New System.Drawing.Point(153, 0)
        Me.MainHomePanel.Name = "MainHomePanel"
        Me.MainHomePanel.Padding = New System.Windows.Forms.Padding(10)
        Me.MainHomePanel.Size = New System.Drawing.Size(647, 450)
        Me.MainHomePanel.TabIndex = 1
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MainHomePanel)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Name = "MainForm"
        Me.Text = "Library Management SyStem"
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents BooksButton As Button
    Friend WithEvents StudentsButton As Button
    Friend WithEvents UsersButton As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents MainHomePanel As Panel
End Class
