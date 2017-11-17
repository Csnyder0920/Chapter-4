Public Class Form1

    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click
        ' Variable declarations
        Dim intStartIndex As Integer ' Starting index of the search
        Dim intFoundIndex As Integer ' Index of the found substring

        ' Determine whether the starting index is numeric.
        If IsNumeric(txtStartIndex.Text) Then
            intStartIndex = CInt(txtStartIndex.Text)
            intFoundIndex = lblString.Text.IndexOf(txtToFind.Text, intStartIndex)
        End If

        ' Determine whether a string to search for was entered.
        If txtToFind.Text.Length > 0 Then
        End If
        If intFoundIndex = -1 Then
            lblResults.Text = "The string was not found fool"
        Else
            lblResults.Text = "The string was found"
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class
