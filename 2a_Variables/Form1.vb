Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim number1 As Integer
        Dim number2 As Integer
        Dim answer As Integer

        number1 = txtFirstNumber.Text
        number2 = txtSecondNumber.Text
        answer = number1 + number2

        'MessageBox.Show(answer)
        txtNumberResult.Text = answer
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim FirstName As String
        Dim LastName As String
        Dim FullName As String

        FirstName = txtFirstName.Text
        LastName = txtLastName.Text

        FullName = FirstName & " " & LastName

        txtFullName.Text = FullName
    End Sub

    Private Sub txtFirstName_TextChanged(sender As Object, e As EventArgs) Handles txtFirstName.TextChanged

    End Sub

    Private Sub txtLastName_TextChanged(sender As Object, e As EventArgs) Handles txtLastName.TextChanged

    End Sub

    Private Sub txtFullName_TextChanged(sender As Object, e As EventArgs) Handles txtFullName.TextChanged

    End Sub

    Private Sub txtNumberResult_TextChanged(sender As Object, e As EventArgs) Handles txtNumberResult.TextChanged

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtSecondNumber.TextChanged

    End Sub

    Private Sub txtFirstNumber_TextChanged(sender As Object, e As EventArgs) Handles txtFirstNumber.TextChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub TextBox1_TextChanged_1(sender As Object, e As EventArgs)

    End Sub
End Class


