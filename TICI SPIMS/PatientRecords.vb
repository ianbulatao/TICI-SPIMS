Public Class PatientRecords
    Private Sub PatientRecords_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Gateway.Show()
    End Sub



    Private Sub PatientRecords_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        NEW_PATIENT.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Patient_Directory.Show()
        Me.Hide()
    End Sub
End Class