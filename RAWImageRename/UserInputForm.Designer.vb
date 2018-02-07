<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserInputForm
    Inherits System.Windows.Forms.Form





    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TargetDirectory = New System.Windows.Forms.Label()
        Me.BeginButton = New System.Windows.Forms.Button()
        Me.RenameTextBox = New System.Windows.Forms.TextBox()
        Me.DigitLabel = New System.Windows.Forms.Label()
        Me.DigitInput = New System.Windows.Forms.NumericUpDown()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.DirectoryBrowseButton = New System.Windows.Forms.Button()
        Me.DirectoryDisplayField = New System.Windows.Forms.TextBox()
        Me.RenameCheckBox = New System.Windows.Forms.CheckBox()
        Me.AppendComboBox = New System.Windows.Forms.ComboBox()
        CType(Me.DigitInput, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TargetDirectory
        '
        Me.TargetDirectory.AutoSize = True
        Me.TargetDirectory.Location = New System.Drawing.Point(42, 36)
        Me.TargetDirectory.Name = "TargetDirectory"
        Me.TargetDirectory.Size = New System.Drawing.Size(148, 13)
        Me.TargetDirectory.TabIndex = 0
        Me.TargetDirectory.Text = "Select Target Image Directory"
        '
        'BeginButton
        '
        Me.BeginButton.Location = New System.Drawing.Point(424, 103)
        Me.BeginButton.Name = "BeginButton"
        Me.BeginButton.Size = New System.Drawing.Size(75, 23)
        Me.BeginButton.TabIndex = 3
        Me.BeginButton.Text = "Start"
        Me.BeginButton.UseVisualStyleBackColor = True
        '
        'RenameTextBox
        '
        Me.RenameTextBox.Location = New System.Drawing.Point(196, 66)
        Me.RenameTextBox.Name = "RenameTextBox"
        Me.RenameTextBox.Size = New System.Drawing.Size(212, 20)
        Me.RenameTextBox.TabIndex = 4
        Me.RenameTextBox.Visible = False
        '
        'DigitLabel
        '
        Me.DigitLabel.AutoSize = True
        Me.DigitLabel.Location = New System.Drawing.Point(293, 105)
        Me.DigitLabel.Name = "DigitLabel"
        Me.DigitLabel.Size = New System.Drawing.Size(56, 13)
        Me.DigitLabel.TabIndex = 6
        Me.DigitLabel.Text = "Starting At"
        Me.DigitLabel.Visible = False
        '
        'DigitInput
        '
        Me.DigitInput.Location = New System.Drawing.Point(355, 103)
        Me.DigitInput.Name = "DigitInput"
        Me.DigitInput.Size = New System.Drawing.Size(53, 20)
        Me.DigitInput.TabIndex = 7
        Me.DigitInput.Value = New Decimal(New Integer() {1, 0, 0, 0})
        Me.DigitInput.Visible = False
        '
        'DirectoryBrowseButton
        '
        Me.DirectoryBrowseButton.Location = New System.Drawing.Point(424, 30)
        Me.DirectoryBrowseButton.Name = "DirectoryBrowseButton"
        Me.DirectoryBrowseButton.Size = New System.Drawing.Size(75, 23)
        Me.DirectoryBrowseButton.TabIndex = 8
        Me.DirectoryBrowseButton.Text = "Browse"
        Me.DirectoryBrowseButton.UseVisualStyleBackColor = True
        '
        'DirectoryDisplayField
        '
        Me.DirectoryDisplayField.Enabled = False
        Me.DirectoryDisplayField.Location = New System.Drawing.Point(196, 33)
        Me.DirectoryDisplayField.Name = "DirectoryDisplayField"
        Me.DirectoryDisplayField.Size = New System.Drawing.Size(212, 20)
        Me.DirectoryDisplayField.TabIndex = 9
        '
        'RenameCheckBox
        '
        Me.RenameCheckBox.AutoSize = True
        Me.RenameCheckBox.Location = New System.Drawing.Point(64, 68)
        Me.RenameCheckBox.Name = "RenameCheckBox"
        Me.RenameCheckBox.Size = New System.Drawing.Size(90, 17)
        Me.RenameCheckBox.TabIndex = 10
        Me.RenameCheckBox.Text = "Rename Files"
        Me.RenameCheckBox.UseVisualStyleBackColor = True
        '
        'AppendComboBox
        '
        Me.AppendComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.AppendComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.AppendComboBox.FormattingEnabled = True
        Me.AppendComboBox.Items.AddRange(New Object() {"Append Date", "Renumber"})
        Me.AppendComboBox.Location = New System.Drawing.Point(196, 103)
        Me.AppendComboBox.Name = "AppendComboBox"
        Me.AppendComboBox.Size = New System.Drawing.Size(89, 21)
        Me.AppendComboBox.TabIndex = 11
        Me.AppendComboBox.Text = "Append Date"
        '
        'UserInputForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(618, 183)
        Me.Controls.Add(Me.AppendComboBox)
        Me.Controls.Add(Me.RenameCheckBox)
        Me.Controls.Add(Me.DirectoryDisplayField)
        Me.Controls.Add(Me.DirectoryBrowseButton)
        Me.Controls.Add(Me.DigitInput)
        Me.Controls.Add(Me.DigitLabel)
        Me.Controls.Add(Me.RenameTextBox)
        Me.Controls.Add(Me.BeginButton)
        Me.Controls.Add(Me.TargetDirectory)
        Me.Name = "UserInputForm"
        Me.Text = "RAW Image Renamer"
        CType(Me.DigitInput, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TargetDirectory As System.Windows.Forms.Label
    Friend WithEvents BeginButton As System.Windows.Forms.Button
    Friend WithEvents RenameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DigitLabel As System.Windows.Forms.Label
    Friend WithEvents DigitInput As System.Windows.Forms.NumericUpDown
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents DirectoryBrowseButton As System.Windows.Forms.Button
    Friend WithEvents DirectoryDisplayField As System.Windows.Forms.TextBox
    Friend WithEvents RenameCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents AppendComboBox As System.Windows.Forms.ComboBox
End Class
