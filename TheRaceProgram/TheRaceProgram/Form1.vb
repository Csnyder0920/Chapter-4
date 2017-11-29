Public Class Form1

    Private Sub btnResults_Click(sender As Object, e As EventArgs) Handles btnResults.Click
        Dim dblTime1, dblTime2, dblTime3 As Double

        dblTime1 = txtFinishTime1.Text
        dblTime2 = txtFinishTime2.Text
        dblTime3 = txtFinishTime3.Text

        If dblTime1 < dblTime2 And dblTime1 < dblTime3 Then
            lblResult1.Text = txtRunner1.Text
            If dblTime2 < dblTime3 Then
                lblResult2.Text = txtRunner2.Text
                lblResult3.Text = txtRunner3.Text
            ElseIf dblTime3 < dblTime2 Then
                lblResult2.Text = txtRunner3.Text
                lblResult3.Text = txtRunner2.Text
            End If
        End If
        If dblTime2 < dblTime1 And dblTime2 < dblTime3 Then
            lblResult1.Text = txtRunner2.Text
            If dblTime1 < dblTime3 Then
                lblResult1.Text = txtRunner2.Text
                lblResult3.Text = txtRunner3.Text
            ElseIf dblTime3 < dblTime1 Then
                lblResult1.Text = txtRunner2.Text
                lblResult2.Text = txtRunner3.Text
            End If
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lblResult1.Text = ""
        lblResult2.Text = ""
        lblResult3.Text = ""
        txtFinishTime1.Clear()
        txtFinishTime2.Clear()
        txtFinishTime3.Clear()
        txtRunner1.Clear()
        txtRunner3.Clear()
        txtRunner2.Clear()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
