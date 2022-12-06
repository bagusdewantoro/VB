Public Class frmVariables
    Private Sub btnTransfer_Click(sender As Object, e As EventArgs) Handles btnTransfer.Click
        Dim LabelContents As String
        LabelContents = lblTransfer.Text
        txtVariables.Text = LabelContents

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles cmdTransferToLabel.Click
        Dim TextBoxContents As String
        TextBoxContents = txtVariables.Text
        lblTransfer.Text = TextBoxContents
    End Sub

    Private Sub lblTransfer_Click(sender As Object, e As EventArgs) Handles lblTransfer.Click

    End Sub

    Private Sub txtVariables_TextChanged(sender As Object, e As EventArgs) Handles txtVariables.TextChanged

    End Sub
End Class
