﻿Public Class Form1

    Dim Total1 As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnPlus.Click

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btnEquals.Click

    End Sub

    Private Sub btnZero_Click(sender As Object, e As EventArgs) Handles btnZero.Click
        txtDisplay.Text = txtDisplay.Text & btnZero.Text
    End Sub

    Private Sub btnOne_Click(sender As Object, e As EventArgs) Handles btnOne.Click
        txtDisplay.Text = txtDisplay.Text & btnOne.Text
    End Sub

    Private Sub btnTwo_Click(sender As Object, e As EventArgs) Handles btnTwo.Click
        txtDisplay.Text = txtDisplay.Text & btnTwo.Text
    End Sub

    Private Sub btnThree_Click(sender As Object, e As EventArgs) Handles btnThree.Click
        txtDisplay.Text = txtDisplay.Text & btnThree.Text
    End Sub

    Private Sub btnFour_Click(sender As Object, e As EventArgs) Handles btnFour.Click
        txtDisplay.Text = txtDisplay.Text & btnFour.Text
    End Sub

    Private Sub btnFive_Click(sender As Object, e As EventArgs) Handles btnFive.Click
        txtDisplay.Text = txtDisplay.Text & btnFive.Text
    End Sub

    Private Sub btnSix_Click(sender As Object, e As EventArgs) Handles btnSix.Click
        txtDisplay.Text = txtDisplay.Text & btnSix.Text
    End Sub

    Private Sub btnSeven_Click(sender As Object, e As EventArgs) Handles btnSeven.Click
        txtDisplay.Text = txtDisplay.Text & btnSeven.Text
    End Sub

    Private Sub btnEight_Click(sender As Object, e As EventArgs) Handles btnEight.Click
        txtDisplay.Text = txtDisplay.Text & btnEight.Text
    End Sub

    Private Sub btnNine_Click(sender As Object, e As EventArgs) Handles btnNine.Click
        txtDisplay.Text = txtDisplay.Text & btnNine.Text
    End Sub

    Private Sub txtDisplay_TextChanged(sender As Object, e As EventArgs) Handles txtDisplay.TextChanged

    End Sub
End Class