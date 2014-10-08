Option Strict On

Public Class Form1

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        Dim n As Integer

        Do While n < 10
            n = n * n
        Loop
        lstResult.Items.Add(n)

    End Sub
End Class
