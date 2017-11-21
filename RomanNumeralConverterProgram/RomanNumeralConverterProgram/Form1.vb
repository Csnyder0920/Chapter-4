Public Class Form1

    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click
        Dim intError As Integer
        Dim intRomanNumeral As Integer
        Try
            If txtInteger.Text = 1 Then
                lblResult.Text = "I"
            End If
            If txtInteger.Text = 2 Then
                lblResult.Text = "II"
            End If
            If txtInteger.Text = 3 Then
                lblResult.Text = "III"
            End If
            If txtInteger.Text = 4 Then
                lblResult.Text = "IV"
            End If
            If txtInteger.Text = 5 Then
                lblResult.Text = "V"
            End If
            If txtInteger.Text = 6 Then
                lblResult.Text = "VI"
            End If
            If txtInteger.Text = 7 Then
                lblResult.Text = "VII"
            End If
            If txtInteger.Text = 8 Then
                lblResult.Text = "VIII"
            End If
            If txtInteger.Text = 9 Then
                lblResult.Text = "IX"
            End If
            If txtInteger.Text = 10 Then
                lblResult.Text = "X"
            End If
        Catch
            intRomanNumeral = CInt(txtInteger.Text)
            intError = CInt(txtInteger.Text)

            If intRomanNumeral > 1 Or intRomanNumeral < 10 Then
                lblErrorMessage.Text = "Integer entered must be between 1 and 10!!!"
            End If
        End Try

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lblResult.Text = ""
        lblErrorMessage.Text = ""
        txtInteger.Clear()
    End Sub
End Class
