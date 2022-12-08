Public Class Form1

    Dim initNumber As Integer
    Dim total As Integer
    Dim currentOperation As String


    Private Sub btnMultiply_Click(sender As Object, e As EventArgs) Handles btnMultiply.Click
        Select Case currentOperation
            Case "plus"
                If (total = 0) Then
                    total = txtDisplay.Text
                Else
                    total = total + txtDisplay.Text
                End If
            Case "minus"
                If (total = 0) Then
                    total = txtDisplay.Text
                Else
                    total = total - txtDisplay.Text
                End If
            Case "multiply"
                If (total = 0) Then
                    total = txtDisplay.Text
                Else
                    total = total * txtDisplay.Text
                End If
            Case "divide"
                If (total = 0) Then
                    total = txtDisplay.Text
                Else
                    total = total / txtDisplay.Text
                End If
        End Select

        initNumber = 0
        txtDisplay.Text = total
        currentOperation = "multiply"
    End Sub

    Private Sub btnDivide_Click(sender As Object, e As EventArgs) Handles btnDivide.Click
        Select Case currentOperation
            Case "plus"
                If (total = 0) Then
                    total = txtDisplay.Text
                Else
                    total = total + txtDisplay.Text
                End If
            Case "minus"
                If (total = 0) Then
                    total = txtDisplay.Text
                Else
                    total = total - txtDisplay.Text
                End If
            Case "multiply"
                If (total = 0) Then
                    total = txtDisplay.Text
                Else
                    total = total * txtDisplay.Text
                End If
            Case "divide"
                If (total = 0) Then
                    total = txtDisplay.Text
                Else
                    total = total / txtDisplay.Text
                End If
        End Select

        initNumber = 0
        txtDisplay.Text = total
        currentOperation = "divide"
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnPlus.Click

        Select Case currentOperation
            Case "plus"
                If (total = 0) Then
                    total = txtDisplay.Text
                Else
                    total = total + txtDisplay.Text
                End If
            Case "minus"
                If (total = 0) Then
                    total = txtDisplay.Text
                Else
                    total = total - txtDisplay.Text
                End If
            Case "multiply"
                If (total = 0) Then
                    total = txtDisplay.Text
                Else
                    total = total * txtDisplay.Text
                End If
            Case "divide"
                If (total = 0) Then
                    total = txtDisplay.Text
                Else
                    total = total / txtDisplay.Text
                End If
        End Select

        initNumber = 0
        txtDisplay.Text = total
        currentOperation = "plus"
    End Sub

    Private Sub btnMinus_Click(sender As Object, e As EventArgs) Handles btnMinus.Click

        Select Case currentOperation
            Case "plus"
                If (total = 0) Then
                    total = txtDisplay.Text
                Else
                    total = total + txtDisplay.Text
                End If
            Case "minus"
                If (total = 0) Then
                    total = txtDisplay.Text
                Else
                    total = total - txtDisplay.Text
                End If
            Case "multiply"
                If (total = 0) Then
                    total = txtDisplay.Text
                Else
                    total = total * txtDisplay.Text
                End If
            Case "divide"
                If (total = 0) Then
                    total = txtDisplay.Text
                Else
                    total = total / txtDisplay.Text
                End If
        End Select

        initNumber = 0
        txtDisplay.Text = total
        currentOperation = "minus"
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btnEquals.Click

        Select Case currentOperation
            Case "plus"
                If (total = 0) Then
                    total = txtDisplay.Text
                Else
                    total = total + txtDisplay.Text
                End If
            Case "minus"
                If (total = 0) Then
                    total = txtDisplay.Text
                Else
                    total = total - txtDisplay.Text
                End If
            Case "multiply"
                If (total = 0) Then
                    total = txtDisplay.Text
                Else
                    total = total * txtDisplay.Text
                End If
            Case "divide"
                If (total = 0) Then
                    total = txtDisplay.Text
                Else
                    total = total / txtDisplay.Text
                End If
        End Select

        initNumber = 0
        txtDisplay.Text = total
        total = 0
    End Sub

    Private Sub btnZero_Click(sender As Object, e As EventArgs) Handles btnZero.Click
        If (initNumber = 0) Then
            initNumber = Val(btnZero.Text)
            txtDisplay.Text = initNumber
        Else
            txtDisplay.Text = txtDisplay.Text & btnZero.Text
        End If

    End Sub

    Private Sub btnOne_Click(sender As Object, e As EventArgs) Handles btnOne.Click
        If (initNumber = 0) Then
            initNumber = Val(btnOne.Text)
            txtDisplay.Text = initNumber
        Else
            txtDisplay.Text = txtDisplay.Text & btnOne.Text
        End If
    End Sub

    Private Sub btnTwo_Click(sender As Object, e As EventArgs) Handles btnTwo.Click
        If (initNumber = 0) Then
            initNumber = Val(btnTwo.Text)
            txtDisplay.Text = initNumber
        Else
            txtDisplay.Text = txtDisplay.Text & btnTwo.Text
        End If

    End Sub

    Private Sub btnThree_Click(sender As Object, e As EventArgs) Handles btnThree.Click
        If (initNumber = 0) Then
            initNumber = Val(btnThree.Text)
            txtDisplay.Text = initNumber
        Else
            txtDisplay.Text = txtDisplay.Text & btnThree.Text
        End If
    End Sub

    Private Sub btnFour_Click(sender As Object, e As EventArgs) Handles btnFour.Click
        If (initNumber = 0) Then
            initNumber = Val(btnFour.Text)
            txtDisplay.Text = initNumber
        Else
            txtDisplay.Text = txtDisplay.Text & btnFour.Text
        End If
    End Sub

    Private Sub btnFive_Click(sender As Object, e As EventArgs) Handles btnFive.Click
        If (initNumber = 0) Then
            initNumber = Val(btnFive.Text)
            txtDisplay.Text = initNumber
        Else
            txtDisplay.Text = txtDisplay.Text & btnFive.Text
        End If
    End Sub

    Private Sub btnSix_Click(sender As Object, e As EventArgs) Handles btnSix.Click
        If (initNumber = 0) Then
            initNumber = Val(btnSix.Text)
            txtDisplay.Text = initNumber
        Else
            txtDisplay.Text = txtDisplay.Text & btnSix.Text
        End If
    End Sub

    Private Sub btnSeven_Click(sender As Object, e As EventArgs) Handles btnSeven.Click
        If (initNumber = 0) Then
            initNumber = Val(btnSeven.Text)
            txtDisplay.Text = initNumber
        Else
            txtDisplay.Text = txtDisplay.Text & btnSeven.Text
        End If
    End Sub

    Private Sub btnEight_Click(sender As Object, e As EventArgs) Handles btnEight.Click
        If (initNumber = 0) Then
            initNumber = Val(btnEight.Text)
            txtDisplay.Text = initNumber
        Else
            txtDisplay.Text = txtDisplay.Text & btnEight.Text
        End If
    End Sub

    Private Sub btnNine_Click(sender As Object, e As EventArgs) Handles btnNine.Click
        If (initNumber = 0) Then
            initNumber = Val(btnNine.Text)
            txtDisplay.Text = initNumber
        Else
            txtDisplay.Text = txtDisplay.Text & btnNine.Text
        End If
    End Sub

    Private Sub txtDisplay_TextChanged(sender As Object, e As EventArgs) Handles txtDisplay.TextChanged
        'initNumber = Val(txtDisplay.Text)
        'MessageBox.Show(initNumber)
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        total = txtDisplay.Text
        txtDisplay.Text = 0
        initNumber = 0
    End Sub

    Private Sub btnClearAll_Click(sender As Object, e As EventArgs) Handles btnClearAll.Click
        total = 0
        txtDisplay.Text = 0
        initNumber = 0
    End Sub

End Class
