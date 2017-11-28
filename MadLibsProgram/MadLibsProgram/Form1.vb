Public Class Form1

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim strInput As String 'Hold selected from list 

        If lstColor.SelectedIndex = -1 Then
            ' No Color Selected
            MessageBox.Show("Please Select a Color.")

        ElseIf lstEst.SelectedIndex = -1 Then
            ' No word ending in est
            MessageBox.Show("No word ending in est.")

        ElseIf lstNumber.SelectedIndex = -1 Then
            ' No number was selected
            MessageBox.Show("Please Select a Number.")

        ElseIf lstBodyPart.SelectedIndex = -1 Then
            ' No body part was selected 
            MessageBox.Show("Please Select a Body Part.")

        ElseIf lstAnimal.SelectedIndex = -1 Then
            ' No animal was selected
            MessageBox.Show("Please Select an Animal.")

        ElseIf lstNoun.SelectedIndex = -1 Then
            ' No noun was selected
            MessageBox.Show("Please Select a Noun.")

        ElseIf lstPluralNoun.SelectedIndex = -1 Then
            ' No plural noun was selected.
            MessageBox.Show("Please Select a Plural Noun.")

        Else
            ' Get the selected list from above to place into a message box
            strInput = lstColor.SelectedItem.ToString() & " Dragon is the " & lstEst.SelectedItem.ToString() & " Dragon of all. It has " &
                lstNumber.SelectedItem.ToString() & " " & lstBodyPart.SelectedItem.ToString() & ", and a(n) " &
                lstAnimal.SelectedItem.ToString() & " shaped like a(n) " & lstNoun.SelectedItem.ToString() & ". It loves to eat " &
                lstPluralNoun.SelectedItem.ToString()
            MessageBox.Show("The " & strInput & ", although it will feast on nearly anything.")

        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lstColor.SelectedIndex = -1
        lstEst.SelectedIndex = -1
        lstNumber.SelectedIndex = -1
        lstBodyPart.SelectedIndex = -1
        lstAnimal.SelectedIndex = -1
        lstNoun.SelectedIndex = -1
        lstPluralNoun.SelectedIndex = -1


    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
