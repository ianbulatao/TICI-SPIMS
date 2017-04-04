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
        txtCaseNo.Clear()

        chkImplant.Checked = False
        chkClaustro.Checked = False
    End Sub

    Private Sub btnADD_Click(sender As Object, e As EventArgs) Handles btnADD.Click
        If transport() Then
            'GET LAST ID
            Dim newID As String = ((Convert.ToInt32(Date.Now.ToString("yyyy")) * 10000) + Convert.ToInt32(getLastId))
            Dim dateNow As String = Date.Now.ToString
            'FIX THIS
            Dim qry As String = "INSERT INTO" &
                " PATIENT(PT_CASE_NO,PT_LN,PT_FN,PT_MN,PT_DOB,PT_CSTAT,PT_SEX,PT_CONTACT_NO,PT_TYPE,PT_BRGY,PT_CITY,PT_PROV,PT_OCC,PT_ALLERGY,PT_IMPLANT,PT_CLAUSTRO,PT_ENAME,PT_ECONTACT,PT_HMO,PT_HMO_ID,PT_LAST_UPDATE,ROW_LOCK) VALUES( '" & caseNo &
                "', '" & lname &
                "','" & fname &
                "','" & mname &
                "','" & xenc(dob) &
                "','" & xenc(cstat) &
                "','" & xenc(sex) &
                "','" & xenc(contactNo) &
                "','" & ptype &
                "','" & xenc(brgy) &
                "','" & xenc(city) &
                "','" & xenc(prov) &
                "','" & xenc(occ) &
                "','" & xenc(allergy) &
                "','" & xenc(implant) &
                "','" & xenc(claustro) &
                "','" & xenc(emname) &
                "','" & xenc(emcontact) &
                "','" & xenc(hmo) &
                "','" & xenc(hmoid) &
                "','" & dateNow &
                "','" & "-" &
                "')"
            If insertFunction(qry) Then '
                MsgBox("PATIENT ADDED SUCCESSFULLY!")
            End If
        End If
        'System.Net.Dns.GetHostName()
    End Sub

    Function transport() As Boolean

        'CHECKS IF THE CORE INFOS ARE ENTERED
        If (txtLname.Text <> "") And (txtFname.Text <> "") And (txtCaseNo.Text <> "") Then

            lname = txtLname.Text
            fname = txtFname.Text
            mname = txtMname.Text
            dob = txtDob.Text
            contactNo = txtContactNo.Text
            cstat = txtCstat.Text
            sex = txtSex.Text
            ptype = txtPtype.Text
            caseNo = txtCaseNo.Text

            brgy = txtBrgy.Text
            city = txtCity.Text
            prov = txtProv.Text
            occ = txtOcc.Text
            'VERIFY IF CASE NUMBER EXIST ALREADY BEFORE PROCEEDING
            If checkIfCaseExists(caseNo) Then

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
                MsgBox("CASE NUMBER ALREADY EXISTS!")

                Return False
            End If

        Else
            MsgBox("ENTER atleast the LAST NAME, the FIRST NAME and the CASE NUMBER.")
            Return False
        End If

    End Function
    Function getLastId() As String
        Try
            conn.Open()
            cmd = conn.CreateCommand
            sql = "select count(*) + 1 as ct from PATIENT"
            cmd = conn.CreateCommand
            cmd.CommandText = sql
            readers = cmd.ExecuteReader
            Try
                While readers.Read
                    Return readers("ct").ToString
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

    End Function
    Function checkIfCaseExists(ByVal caseno As String) As Boolean
        Try
            Dim n As String = "none"
            conn.Open()
            cmd = conn.CreateCommand
            sql = "select * from PATIENT where PT_CASE_NO like '%" & caseno & "%'"
            cmd = conn.CreateCommand
            cmd.CommandText = sql
            readers = cmd.ExecuteReader
            Try
                While readers.Read
                    n = readers("PT_ID")
                End While
                If n = "none" Then
                    Return True
                Else
                    Return False
                End If
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
        Return False
    End Function
End Class