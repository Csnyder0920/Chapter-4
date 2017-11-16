Public Class Form1

    Private Sub btnCheckQual_Click(sender As Object, e As EventArgs) Handles btnCheckQual.Click
        ' Variables to hold input data.
        Dim dblSalary As Double
        Dim intYearsOnJob As Integer

        Try
            ' Get the user's input.
            dblSalary = CDbl(txtAnnualSalary.Text)
            intYearsOnJob = CInt(txtNumberOfYears.Text)

            ' Determine whether the applicant qualifies.
            ' for the special loan
            If dblSalary > 30000 Then
                If intYearsOnJob > 2 Then
                    lblMessage.Text = "The applicant qualifies"
                Else
                    lblMessage.Text = "The applicant does not qualify"
                End If
            End If

        Catch ex As Exception
            ' Display an error message.
            lblMessage.Text = "Please enter numeric values"
        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtAnnualSalary.Clear()
        txtNumberOfYears.Clear()
        lblMessage.Text = ""
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
