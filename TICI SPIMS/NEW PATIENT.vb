Public Class NEW_PATIENT
    'variables for transport
    'PTX
    Dim lname As String = "-"
    Dim fname As String = "-"
    Dim mname As String = "-"
    Dim caseNo As String = ""
    Dim dob As String = "-"
    Dim contactNo As String = "-"
    Dim cstat As String = "-"
    Dim sex As String = "-"
    Dim ptype As String = "-"

    'PTY
    Dim brgy As String = "-"
    Dim city As String = "-"
    Dim prov As String = "-"
    Dim occ As String = "-"
    Dim allergy As String = "NONE"
    Dim implant As String = "NONE"
    Dim claustro As String = "NO"

    'PTZ
    Dim emname As String = "-"
    Dim emcontact As String = "-"
    Dim hmo As String = "-"
    Dim hmoid As String = "-"

    Private Sub NEW_PATIENT_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        PatientRecords.Show()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtLname.Clear()
        txtFname.Clear()
        txtMname.Clear()
        txtDob.Clear()
        txtContactNo.Clear()
        txtBrgy.Clear()
        txtCity.Clear()
        txtProv.Clear()
        txtOcc.Clear()
        txtAll.Clear()
        txtCaseNo.clear

        chkImplant.Checked = False
        chkClaustro.Checked = False
    End Sub

    Private Sub btnADD_Click(sender As Object, e As EventArgs) Handles btnADD.Click
        If transport() Then
            'GET LAST ID
            Dim newID As String = ((Convert.ToInt32(Date.Now.ToString("YYYY")) * 10000) + 1) '+ GET NUMBER OF ROWS
            'FIX THIS
            Dim qry As String = "INSERT INTO PATIENT VALUES(" & newID & ", '" & lname & "')"
            If True Then 'insertfunction(qry)
                MsgBox("PATIENT ADDED SUCCESSFULLY!")
            End If
        End If

    End Sub

    Function transport() As Boolean

        If (txtLname.Text <> "") And (txtFname.Text <> "") And (txtCaseNo.Text <> "") Then

            lname = txtLname.Text
            fname = txtFname.Text
            mname = txtMname.Text
            dob = txtDob.Text
            contactNo = txtContactNo.Text
            cstat = txtCstat.Text
            sex = txtSex.Text
            ptype = txtPtype.Text

            brgy = txtBrgy.Text
            city = txtCity.Text
            prov = txtProv.Text
            occ = txtOcc.Text
            If txtAll.Text <> "" Then
                allergy = txtAll.Text
            End If
            If chkClaustro.CheckState = True Then
                claustro = "YES"
            Else
                claustro = "NONE"
            End If
            If chkImplant.CheckState = True Then
                implant = "YES"
            Else
                implant = "NONE"
            End If
            Return True
        Else
            MsgBox("ENTER atleast the LAST NAME, the FIRST NAME and the CASE NUMBER.")
            Return False
        End If

    End Function

End Class