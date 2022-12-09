Public Class Form1
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim MyVariable As String
        MyVariable = ComboBox1.Text
        TextBox1.Text = MyVariable
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim MyVariable As String
        MyVariable = TextBox1.Text
        ComboBox1.Text = MyVariable
        'This does not mutate the array
    End Sub
End Class
