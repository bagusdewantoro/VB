Public Class Form1
    Private Sub menuExit_Click(sender As Object, e As EventArgs) Handles menuExit.Click
        Me.Close()
    End Sub



    Private Sub menuOpen_Click(sender As Object, e As EventArgs) Handles menuOpen.Click
        Dim strFileName As String

        openFD.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
        openFD.Title = "Open a Text File"
        openFD.Filter = "Text Files|*.txt|Word Files|*.docx"
        openFD.FileName = "text1.txt"

        Dim DidWork As Integer = openFD.ShowDialog()

        If DidWork = DialogResult.Cancel Then
            MessageBox.Show("Cancel Button Clicked")
        Else
            strFileName = openFD.FileName
            MessageBox.Show(strFileName)
        End If
    End Sub

    Private Sub openFD_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles openFD.FileOk

    End Sub

    Private Sub menuSave_Click(sender As Object, e As EventArgs) Handles menuSave.Click
        Dim strFileName As String

        saveFD.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
        saveFD.Title = "Save a Text File"
        saveFD.Filter = "Text Files|*.txt|Word Files|*.docx"
        saveFD.FileName = "text1.txt"
        saveFD.OverwritePrompt = True

        Dim DidWork As Integer = saveFD.ShowDialog()

        If DidWork = DialogResult.Cancel Then
            MessageBox.Show("Cancel Button Clicked")
        Else
            strFileName = saveFD.FileName
            MessageBox.Show(strFileName)
        End If
    End Sub

    Private Sub menuCopy_Click(sender As Object, e As EventArgs) Handles menuCopy.Click
        TextBox1.Copy()
    End Sub

    Private Sub menuPaste_Click(sender As Object, e As EventArgs) Handles menuPaste.Click
        TextBox2.Paste()
    End Sub

    Private Sub menuCut_Click(sender As Object, e As EventArgs) Handles menuCut.Click
        TextBox1.Cut()
    End Sub

    Private Sub menuUndo_Click(sender As Object, e As EventArgs) Handles menuUndo.Click
        TextBox1.Undo()
    End Sub


    Private Sub menuViewTextBoxes_Click(sender As Object, e As EventArgs) Handles menuViewTextBoxes.Click
        menuViewTextBoxes.Checked = Not menuViewTextBoxes.Checked

        If menuViewTextBoxes.Checked = True Then
            TextBox1.Visible = True
            TextBox2.Visible = True
        Else
            TextBox1.Visible = False
            TextBox2.Visible = False
        End If
    End Sub

    Private Sub menuViewLabels_Click(sender As Object, e As EventArgs) Handles menuViewLabels.Click
        menuViewLabels.Checked = Not menuViewLabels.Checked

        If menuViewLabels.Checked = True Then
            Label1.Visible = True
            Label2.Visible = True
        Else
            Label1.Visible = False
            Label2.Visible = False
        End If
    End Sub
End Class
