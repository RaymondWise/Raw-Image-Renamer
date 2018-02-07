Public Class UserInputForm
    Private Sub DirectoryBrowseButton_Click(sender As Object, e As EventArgs) Handles DirectoryBrowseButton.Click
        If (FolderBrowserDialog1.ShowDialog()) Then
            DirectoryDisplayField.Text = FolderBrowserDialog1.SelectedPath & "\"
        End If
    End Sub

    Private Sub RenameCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles RenameCheckBox.CheckedChanged
        If RenameCheckBox.Checked Then
            RenameTextBox.Visible = True
        Else
            RenameTextBox.Visible = False
        End If
    End Sub

    Private Sub AppendComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles AppendComboBox.SelectedIndexChanged
        If AppendComboBox.Text = "Renumber" Then
            DigitLabel.Visible = True
            DigitInput.Visible = True
        Else
            DigitLabel.Visible = False
            DigitInput.Visible = False
        End If
    End Sub

    Public Sub BeginButton_Click(sender As Object, e As EventArgs) Handles BeginButton.Click
        Dim startingNumber As Integer = -1
        Dim baseName As String = Nothing
        Dim useDate As Boolean = True

        If Not DirectoryDisplayField.Text = Nothing Then
            If AppendComboBox.Text = "Renumber" Then useDate = False
            If RenameCheckBox.Checked Then baseName = RenameTextBox.Text
            If AppendComboBox.Text = "Renumber" Then startingNumber = DigitInput.Value


            UserFormSubmit(DirectoryDisplayField.Text, useDate, RenameTextBox.Text, startingNumber)
        End If
    End Sub
End Class