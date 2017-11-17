Public Class Form1

    Private Sub btnInsult_Click(sender As Object, e As EventArgs) Handles btnInsult.Click
        Dim IntAge As Integer

        Try
            IntAge = txtUserAgeInput.Text

            If IntAge < 10 Then
                lblResult.Text = "Can you even read?"
            ElseIf IntAge >= 10 And IntAge < 14 Then
                lblResult.Text = "There are no words to express how naive you are."
            ElseIf IntAge >= 14 And IntAge < 18 Then
                lblResult.Text = "You have no clue how the real world works."
            ElseIf IntAge >= 18 And IntAge < 24 Then
                lblResult.Text = "You won't make it."
            ElseIf IntAge >= 24 And IntAge < 30 Then
                lblResult.Text = "Try to keep a steady job."
            ElseIf IntAge >= 30 And IntAge < 40 Then
                lblResult.Text = "You're almost over the hill."
            ElseIf IntAge >= 40 And IntAge < 60 Then
                lblResult.Text = "You've made it over the hill."
            ElseIf IntAge >= 60 Then
                lblResult.Text = "Don't fall, you might need life alert."
            End If
        Catch ex As Exception
            lblMessage.Text = "Enter a numeric value."
        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lblMessage.Clear()
        lblResult.clear()
        txtUserAgeInput.Text = ""
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
