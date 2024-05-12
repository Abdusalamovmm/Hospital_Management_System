Imports System.Data.OleDb
Public Class Form5
    Dim myconnection As OleDbConnection = New OleDbConnection
    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        myconnection.ConnectionString = Form1.provider & Form1.datafile
        If Form2.PID_Value = "" Then
            'If data is invalid Show error message
            MessageBox.Show("Ни один пациент не выбран")
            Exit Sub
        End If
        Dim cmd As New OleDbCommand
        Dim adapter As OleDbDataAdapter
        Dim dt As DataTable
        Dim query As String
        'query statement
        query = "Select * From [Admit-Discharge] Where [PID] = " & Form2.PID_Value & ";"
        'Create New DataTable
        dt = New DataTable()
        'Open the connection
        myconnection.Open()
        Try
            adapter = New OleDbDataAdapter(query, myconnection)
            adapter.Fill(dt)
            SearchResultGrid.DataSource = dt
            If SearchResultGrid.Rows.Count = 1 Then
                Me.Close()
                MessageBox.Show("Предыдущая история болезни Пациента не обнаружена")
            End If
            'Show the dataGrid
            SearchResultGrid.Visible = True
            'Close the connection
            myconnection.Close()
        Catch ex As Exception
            myconnection.Close()
        End Try
    End Sub
End Class