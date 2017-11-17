Public Class Form1

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim decSalesAmount As Decimal
        Dim decAdvancePayAmount As Decimal
        Dim decCommissionRate As Decimal
        Dim decCommissionAmount As Decimal
        Dim decNetPay As Decimal

        Try
            decSalesAmount = CDec(txtSales.Text)

            decAdvancePayAmount = CDec(txtPayAwarded.Text)

            Select Case decSalesAmount
                Case Is < 10000
                    decCommissionRate = 0.05D
                    ON PAGE 251
            End Select
        Catch ex As Exception

        End Try
    End Sub
End Class
