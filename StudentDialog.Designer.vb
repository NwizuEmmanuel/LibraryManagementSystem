<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StudentDialog
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.FirstnameLabel = New System.Windows.Forms.Label()
        Me.MiddlenameLabel = New System.Windows.Forms.Label()
        Me.FirstnameTextBox = New System.Windows.Forms.TextBox()
        Me.MiddlenameTextBox = New System.Windows.Forms.TextBox()
        Me.LastnameLabel = New System.Windows.Forms.Label()
        Me.LastnameTextBox = New System.Windows.Forms.TextBox()
        Me.CourseLabel = New System.Windows.Forms.Label()
        Me.CourseTextBox = New System.Windows.Forms.TextBox()
        Me.SexLabel = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.MaleRadioButton = New System.Windows.Forms.RadioButton()
        Me.FemaleRadioButton = New System.Windows.Forms.RadioButton()
        Me.OthersRadioButton = New System.Windows.Forms.RadioButton()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.FlowLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(277, 212)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 29)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Location = New System.Drawing.Point(3, 3)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(67, 23)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "OK"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(76, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(67, 23)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Cancel"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.Controls.Add(Me.FirstnameLabel, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.MiddlenameLabel, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.FirstnameTextBox, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.MiddlenameTextBox, 1, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.LastnameLabel, 0, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.LastnameTextBox, 1, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.CourseLabel, 0, 5)
        Me.TableLayoutPanel2.Controls.Add(Me.CourseTextBox, 1, 5)
        Me.TableLayoutPanel2.Controls.Add(Me.SexLabel, 0, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.FlowLayoutPanel2, 1, 4)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(15, 5)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 6
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(405, 164)
        Me.TableLayoutPanel2.TabIndex = 1
        '
        'FirstnameLabel
        '
        Me.FirstnameLabel.AutoSize = True
        Me.FirstnameLabel.Location = New System.Drawing.Point(3, 0)
        Me.FirstnameLabel.Name = "FirstnameLabel"
        Me.FirstnameLabel.Size = New System.Drawing.Size(55, 13)
        Me.FirstnameLabel.TabIndex = 0
        Me.FirstnameLabel.Text = "First name"
        '
        'MiddlenameLabel
        '
        Me.MiddlenameLabel.AutoSize = True
        Me.MiddlenameLabel.Location = New System.Drawing.Point(3, 26)
        Me.MiddlenameLabel.Name = "MiddlenameLabel"
        Me.MiddlenameLabel.Size = New System.Drawing.Size(112, 13)
        Me.MiddlenameLabel.TabIndex = 2
        Me.MiddlenameLabel.Text = "Middlename (Optional)"
        '
        'FirstnameTextBox
        '
        Me.FirstnameTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FirstnameTextBox.Location = New System.Drawing.Point(121, 3)
        Me.FirstnameTextBox.Name = "FirstnameTextBox"
        Me.FirstnameTextBox.Size = New System.Drawing.Size(281, 20)
        Me.FirstnameTextBox.TabIndex = 1
        '
        'MiddlenameTextBox
        '
        Me.MiddlenameTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MiddlenameTextBox.Location = New System.Drawing.Point(121, 29)
        Me.MiddlenameTextBox.Name = "MiddlenameTextBox"
        Me.MiddlenameTextBox.Size = New System.Drawing.Size(281, 20)
        Me.MiddlenameTextBox.TabIndex = 3
        '
        'LastnameLabel
        '
        Me.LastnameLabel.AutoSize = True
        Me.LastnameLabel.Location = New System.Drawing.Point(3, 52)
        Me.LastnameLabel.Name = "LastnameLabel"
        Me.LastnameLabel.Size = New System.Drawing.Size(56, 13)
        Me.LastnameLabel.TabIndex = 4
        Me.LastnameLabel.Text = "Last name"
        '
        'LastnameTextBox
        '
        Me.LastnameTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LastnameTextBox.Location = New System.Drawing.Point(121, 55)
        Me.LastnameTextBox.Name = "LastnameTextBox"
        Me.LastnameTextBox.Size = New System.Drawing.Size(281, 20)
        Me.LastnameTextBox.TabIndex = 5
        '
        'CourseLabel
        '
        Me.CourseLabel.AutoSize = True
        Me.CourseLabel.Location = New System.Drawing.Point(3, 112)
        Me.CourseLabel.Name = "CourseLabel"
        Me.CourseLabel.Size = New System.Drawing.Size(40, 13)
        Me.CourseLabel.TabIndex = 6
        Me.CourseLabel.Text = "Course"
        '
        'CourseTextBox
        '
        Me.CourseTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CourseTextBox.Location = New System.Drawing.Point(121, 115)
        Me.CourseTextBox.Name = "CourseTextBox"
        Me.CourseTextBox.Size = New System.Drawing.Size(281, 20)
        Me.CourseTextBox.TabIndex = 7
        '
        'SexLabel
        '
        Me.SexLabel.AutoSize = True
        Me.SexLabel.Location = New System.Drawing.Point(3, 78)
        Me.SexLabel.Name = "SexLabel"
        Me.SexLabel.Size = New System.Drawing.Size(25, 13)
        Me.SexLabel.TabIndex = 10
        Me.SexLabel.Text = "Sex"
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.Controls.Add(Me.MaleRadioButton)
        Me.FlowLayoutPanel2.Controls.Add(Me.FemaleRadioButton)
        Me.FlowLayoutPanel2.Controls.Add(Me.OthersRadioButton)
        Me.FlowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(121, 81)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(281, 28)
        Me.FlowLayoutPanel2.TabIndex = 13
        '
        'MaleRadioButton
        '
        Me.MaleRadioButton.AutoSize = True
        Me.MaleRadioButton.Location = New System.Drawing.Point(3, 3)
        Me.MaleRadioButton.Name = "MaleRadioButton"
        Me.MaleRadioButton.Size = New System.Drawing.Size(48, 17)
        Me.MaleRadioButton.TabIndex = 12
        Me.MaleRadioButton.TabStop = True
        Me.MaleRadioButton.Text = "Male"
        Me.MaleRadioButton.UseVisualStyleBackColor = True
        '
        'FemaleRadioButton
        '
        Me.FemaleRadioButton.AutoSize = True
        Me.FemaleRadioButton.Location = New System.Drawing.Point(57, 3)
        Me.FemaleRadioButton.Name = "FemaleRadioButton"
        Me.FemaleRadioButton.Size = New System.Drawing.Size(59, 17)
        Me.FemaleRadioButton.TabIndex = 11
        Me.FemaleRadioButton.TabStop = True
        Me.FemaleRadioButton.Text = "Female"
        Me.FemaleRadioButton.UseVisualStyleBackColor = True
        '
        'OthersRadioButton
        '
        Me.OthersRadioButton.AutoSize = True
        Me.OthersRadioButton.Location = New System.Drawing.Point(122, 3)
        Me.OthersRadioButton.Name = "OthersRadioButton"
        Me.OthersRadioButton.Size = New System.Drawing.Size(56, 17)
        Me.OthersRadioButton.TabIndex = 13
        Me.OthersRadioButton.TabStop = True
        Me.OthersRadioButton.Text = "Others"
        Me.OthersRadioButton.UseVisualStyleBackColor = True
        '
        'StudentDialog
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(435, 253)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "StudentDialog"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "StudentDialog"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.FlowLayoutPanel2.ResumeLayout(False)
        Me.FlowLayoutPanel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents FirstnameLabel As Label
    Friend WithEvents MiddlenameLabel As Label
    Friend WithEvents FirstnameTextBox As TextBox
    Friend WithEvents MiddlenameTextBox As TextBox
    Friend WithEvents LastnameLabel As Label
    Friend WithEvents LastnameTextBox As TextBox
    Friend WithEvents CourseLabel As Label
    Friend WithEvents CourseTextBox As TextBox
    Friend WithEvents SexLabel As Label
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents MaleRadioButton As RadioButton
    Friend WithEvents FemaleRadioButton As RadioButton
    Friend WithEvents OthersRadioButton As RadioButton
End Class
