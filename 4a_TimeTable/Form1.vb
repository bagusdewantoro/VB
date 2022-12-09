Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ListBox12.Items.Clear()

        Dim number1 As Integer
        Dim number2 As Integer
        Dim multiplier As Integer
        Dim answer As Integer
        Dim i As Integer

        number1 = Val(TextBox1.Text)
        number2 = Val(TextBox2.Text)
        multiplier = Val(TextBox3.Text)

        For i = number1 To number2
            answer = i * multiplier
            ListBox12.Items.Add(i & " * " & multiplier & " = " & answer)
        Next i
    End Sub
End Class
