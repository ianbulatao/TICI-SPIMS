Public Class AdminMenu


    Private Sub AdminMenu_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Gateway.Show()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        EmployeeMgmt.Show()

    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub
    Dim sw As Boolean = True
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label2.Text = Date.Now.ToString
    End Sub

    Private Sub AdminMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = "WELCOME, " & userGlobal
    End Sub
End Class