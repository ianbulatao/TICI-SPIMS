Public Class Cashier_form
    Private Sub btn_addc_Click(sender As Object, e As EventArgs) Handles btn_addc.Click
        Try
            If Convert.ToInt32(text_chrgprice.Text) < 0 Then
                MsgBox("enter admin key")
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btn_search_Click(sender As Object, e As EventArgs) Handles btn_search.Click

    End Sub
End Class
