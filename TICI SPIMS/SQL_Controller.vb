﻿'*********************************************************************************************
'READ FIRST
'THIS CODE SNIPPET WAS DERIVED FROM EXISTENCE INNOVATIVE TECHNOLOGIES'S DATABASE
'COMMUNICATION API, THE XDBCON. THIS CODE SNIPPET IS FREE TO DISTRIBUTE AND SHARE BUT MUST BE
'ATTRIBUTED TO THE ORIGINAL DEVELOPERS.
'
'███████╗██╗  ██╗███████╗   FOUNDED BY: ROMEO MANUEL E. DAVID
'██╔════╝╚██╗██╔╝██╔════╝   XDBCON API Developed, Updated and Maintained by:
'█████╗   ╚███╔╝ ███████╗       -Romeo Manuel David
'██╔══╝   ██╔██╗ ╚════██║       -Raniel Garcia
'███████╗██╔╝ ██╗███████║       -John Christian Viray
'╚══════╝╚═╝  ╚═╝╚══════╝
'___________________________________________________________________________
'____  ____________________________________________________________________
'__| |/ /__  __ \__  __ )_  ____/_  __ \__  | / /______    |__  __ \___  _/
'__|   /__  / / /_  __  |  /    _  / / /_   |/ /______  /| |_  /_/ /__  /  
'_/   | _  /_/ /_  /_/ // /___  / /_/ /_  /|  /______  ___ |  ____/__/ /   
'/_/|_| /_____/ /_____/ \____/  \____/ /_/ |_/      /_/  |_/_/     /___/   
'___________________________________________________________________________ 
'*********************************************************************************************
Imports System.Data.Odbc
Imports System.Data.SqlClient
Module SQL_Controller
    Dim connectionString As String = "DRIVER={MySQL ODBC 3.51 Driver};" &
     "SERVER=localhost;" &
     "DATABASE=spimsdb;" &
     "UID=root;Pwd=;"
    Public conn As New OdbcConnection(connectionString)
    Public cmd As New OdbcCommand
    Public sql As String
    Public readers As OdbcDataReader
    Public chk As Integer
    Public dt As New DataTable
    Public dataAdapter As New OdbcDataAdapter

    Public Function HasConnection() As Boolean
        Try
            conn.Open()

            conn.Close()
            Return True
        Catch ex As Exception
            MessageBox.Show("Error occured in query. :" & vbNewLine & ex.Message, "Error on Insert Query!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try

    End Function
    Public Function getTable(ByVal qry As String) As DataTable
        Try


            Dim myTable1 As New DataTable()
            Dim adapter1 As New OdbcDataAdapter(qry, conn)
            adapter1.Fill(myTable1)
            'RETURN AS DATATABLE
            Return myTable1

        Catch ex As Exception
            MsgBox("Error Occured in getInstances! " & ex.ToString)
        Finally

        End Try
#Disable Warning BC42105 ' Function doesn't return a value on all code paths
    End Function
#Enable Warning BC42105 ' Function doesn't return a value on all code paths
    Public Function insertFunction(ByVal sql) As Boolean
        Try
            If HasConnection() = True Then
                conn.Open()
                cmd = conn.CreateCommand
                cmd.CommandText = sql

                chk = cmd.ExecuteNonQuery
                If chk > 0 Then

                    Return True
                Else

                    Return False
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Error occured in query. :" & vbNewLine & ex.Message, "Error on Insert Query!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
        End Try
        Return False
    End Function
End Module
