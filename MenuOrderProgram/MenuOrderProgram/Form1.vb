Public Class Form1

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        Dim dblTacos As Double = 4.99
        Dim dblEnchilads As Double = 5.99
        Dim dblBurrito As Double = 5.99
        Dim dblTorta As Double = 4.99
        Dim dblTomato As Double = 0.1
        Dim dblCheese As Double = 0.2
        Dim dblSourCream As Double = 0.3
        Dim dblGuac As Double = 0.3
        Dim dblRiceAndBeans As Double = 0.99
        Dim dblChipsAndSalsa As Double = 0.99
        Dim dblQuesoDip As Double = 1.99
        Dim Total As Double

        If radTacos.Checked = True Then
            lblResult.Text = "You selected 3 Tacos"
            Total = dblTacos + Total
        ElseIf radEnchiladas.Checked = True Then
            lblResult.Text = "You selected 3 Enchiladas"
            Total = dblEnchilads + Total
        ElseIf radBurrito.Checked = True Then
            lblResult.Text = "You selected a Burrito"
            Total = dblBurrito = Total
        ElseIf radTorta.Checked = True Then
            lblResult.Text = "You selected a Torta"
            Total = dblTorta + Total
        End If

        If chkTomato.Checked = True Then
            lblResult.Text &= ", and Extra Tomato"
            Total = dblTomato + Total
        End If
        If chkCheese.Checked = True Then
            lblResult.Text &= ", and Extra Cheese"
            Total = dblCheese + Total
        End If
        If chkSourCream.Checked = True Then
            lblResult.Text &= ", and Sour Cream"
            Total = dblSourCream + Total
        End If
        If chkGuac.Checked = True Then
            lblResult.Text &= ", and Guacamole"
            Total = dblGuac + Total
        End If

        If radRiceAndBeans.Checked = True Then
            lblResult.Text &= ", With a Side Order of Rice and Beans"
            Total = dblRiceAndBeans + Total
        End If
        If radChipsAndSalsa.Checked = True Then
            lblResult.Text &= ", With a Side Order of Chips and Salsa"
            Total = dblChipsAndSalsa + Total
        End If
        If radQueso.Checked = True Then
            lblResult.Text &= ", With a Side Order of Queso Dip"
            Total = dblQuesoDip + Total
        End If
        lblTotal.Text = Total.ToString("c")
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lblResult.Text = ""
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class
