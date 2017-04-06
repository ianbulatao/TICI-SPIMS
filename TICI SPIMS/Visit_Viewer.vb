
Public Class Visit_Viewer

    Private Sub Visit_Viewer_Closing(sender As Object, e As EventArgs) Handles Me.Closing
        Patient_Directory.Show()
    End Sub

    Private Sub EditPatientInformationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditPatientInformationToolStripMenuItem.Click
        Rtt_data1.Enabled = True
        Rtt_data2.Enabled = True
        Rtt_data3.Enabled = True
        btn_addchrg.Enabled = True
        btn_update.Enabled = True
    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        Rtt_data1.Enabled = False
        Rtt_data2.Enabled = False
        Rtt_data3.Enabled = False
        btn_addchrg.Enabled = False
        btn_update.Enabled = False
    End Sub

    Private Sub Visit_Viewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'DO SOME DECRYPTOIN HERE
        Try
            digInfo(Patient_Directory.visitdgv.SelectedRows.Item(0).ToString)
        Catch ex As Exception

        End Try
    End Sub
    Sub digInfo(ByVal ptId As String)
        Try
            conn.Open()
            cmd = conn.CreateCommand
            sql = "select * from PATIENT where PT_ID=" & ptId & ""
            cmd = conn.CreateCommand
            cmd.CommandText = sql
            readers = cmd.ExecuteReader
            Try
                While readers.Read
                    '  user_id = readers("USERNAME").ToString
                    ' hashed = readers("PASSWD").ToString
                    ' resx = readers("RX").ToString
                End While
            Catch ex As Exception
                MsgBox("Error in retrieving user information" & vbNewLine & ex.Message)
            Finally
                readers.Close()
            End Try
        Catch ex As Exception
            MsgBox("Error in retrieving user information" & vbNewLine & ex.Message)
        Finally
            conn.Close()

        End Try
    End Sub
End Class