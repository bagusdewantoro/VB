Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim number1 As Integer
        Dim number2 As Integer
        Dim answer As Integer

        If Integer.TryParse(txtFirstNumber.Text, 0) And Integer.TryParse(txtSecondNumber.Text, 0) Then
            number1 = txtFirstNumber.Text
            number2 = txtSecondNumber.Text
            answer = number1 + number2
            txtNumberResult.Text = answer
        Else
            MessageBox.Show("Please Input Number Only")
            txtNumberResult.Text = ""
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim FirstName As String = txtFirstName.Text
        Dim LastName As String = txtLastName.Text
        Dim FullName As String = FirstName & " " & LastName

        txtFullName.Text = FullName
    End Sub


End Class


