Imports System.Data.OleDb
Public Class SearchPatient_Admin
    Dim myconnection As OleDbConnection = New OleDbConnection
    Dim name_search As String
    Private Sub SearchPatient_Admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Set the connection String
        myconnection.ConnectionString = Form1.provider & Form1.datafile
        HideItemsOnForm()
        DOBTxt.MaxDate = Format(Date.Now(), "dd-MM-yyyy")
    End Sub

    Private Sub SearchBtn_Click(sender As Object, e As EventArgs) Handles SearchBtn.Click
        'Hide ClearBtn, PrintBtn SearchResultGrid , PaitentInfoBox and PaymentInfoBox
        HideItemsOnForm()
        'Check if name and mobilehave valid data form
        If Not Form1.Name_Validation(NameSTxt.Text.ToLower) Then
            'If data is invalid Show error message
            MessageBox.Show("Результат не найден")
            Exit Sub
        End If
        Dim cmd As New OleDbCommand
        Dim adapter As OleDbDataAdapter
        Dim dt As DataTable
        Dim query As String
        'query statement
        query = "Select * From [Patient] Where [Name] Like '%" & NameSTxt.Text.ToLower & "%';"
        'Create New DataTable
        dt = New DataTable()
        'Open the connection
        myconnection.Open()
        Try
            adapter = New OleDbDataAdapter(query, myconnection)
            adapter.Fill(dt)
            SearchResultGrid.DataSource = dt
            'If SearchResultGrid Contains only header column, No data entry was found
            If SearchResultGrid.RowCount = 1 Then
                MessageBox.Show("Результат не найден")
                myconnection.Close()
                Exit Sub
            End If
            'Show the dataGrid
            SearchResultGrid.Visible = True
            'Close the connection
            myconnection.Close()
            name_search = NameSTxt.Text
        Catch ex As Exception
            myconnection.Close()
        End Try
    End Sub

    Private Function HideItemsOnForm() As Boolean
        'Hide Items On the form
        SearchResultGrid.Visible = False
        PatientInfoBox.Visible = False
        ClearBtn.Visible = False
        UpdateBtn.Visible = False
        DeleteBtn.Visible = False
        Return True
    End Function

    Private Sub DeleteBtn_Click(sender As Object, e As EventArgs) Handles DeleteBtn.Click
        If PIDTxt.Text = "" Then
            MessageBox.Show("Удалять нечего")
            Exit Sub
        End If
        Dim cmd As New OleDbCommand
        Dim query As String
        'query statement for delete
        query = "Delete From [Patient] Where [PID] = " & PIDTxt.Text & ";"
        'Open the connection
        myconnection.Open()
        Try
            cmd = New OleDbCommand(query, myconnection)

            cmd.ExecuteNonQuery()
            cmd.Dispose()
            'Close the connection
            myconnection.Close()
            UpdateTable()
            ClearPatientInfo()
            MessageBox.Show("Успешно удаленная запись")
        Catch ex As Exception
            myconnection.Close()
        End Try
    End Sub

    Private Sub UpdateBtn_Click(sender As Object, e As EventArgs) Handles UpdateBtn.Click
        'Check if name and mobile have valid data form
        If NameTxt.Text = "" Or GenderTxt.Text = "" Or AddressTxt.Text = "" Then
            'If data is invalid Show error message
            MessageBox.Show("Empty Fields Not Allowed")
            Exit Sub
        End If
        If Not (Form1.Name_Validation(NameTxt.Text.ToLower) And Form1.Gender_Validator(GenderTxt.Text.ToLower)) Then
            MessageBox.Show("Неверные учетные данные")
            Exit Sub
        End If
        Dim cmd As New OleDbCommand
        Dim query As String
        Dim var_date As DateTime = Format(DOBTxt.Value, "dd-MM-yyyy")
        'query statement for update
        query = "Update [Patient] Set [Name] = '" & NameTxt.Text & "', [DOB] = #" & var_date & "#, [Mobile] = '" & MobileTxt.Text & "', [Gender] = '" & GenderTxt.Text & "', [Address] = '" & AddressTxt.Text & "' Where [PID] = " & PIDTxt.Text & ";"
        'Open the connection
        myconnection.Open()
        Try
            cmd = New OleDbCommand(query, myconnection)

            cmd.ExecuteNonQuery()
            cmd.Dispose()
            'Close the connection
            myconnection.Close()
            MessageBox.Show("Успешно обновленные сведения")
            ClearPatientInfo()
            UpdateTable()
        Catch ex As Exception
            myconnection.Close()
        End Try
    End Sub

    Private Sub ClearBtn_Click(sender As Object, e As EventArgs) Handles ClearBtn.Click
        'Clears the data in the PatientInfoBox And AdmitDetailsBox
        ClearPatientInfo()
    End Sub

    Private Function UpdateTable() As Boolean

        Dim cmd As New OleDbCommand
        Dim adapter As OleDbDataAdapter
        Dim dt As DataTable
        Dim query As String
        'query statement
        query = "Select * From [Patient] Where [Name] Like '%" & name_search
        'Create New DataTable
        dt = New DataTable()
        'Open the connection
        myconnection.Open()
        Try
            adapter = New OleDbDataAdapter(query, myconnection)
            adapter.Fill(dt)
            SearchResultGrid.DataSource = dt
            'If SearchResultGrid Contains only header column, No data entry was found
            If SearchResultGrid.RowCount = 1 Then
                myconnection.Close()
                Return False
            End If
            'Show the dataGrid
            SearchResultGrid.Visible = True
            'Close the connection
            myconnection.Close()
        Catch ex As Exception
            myconnection.Close()
        End Try
        Return False
    End Function

    Private Sub SearchResultGrid_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles SearchResultGrid.CellMouseClick
        Try
            'Show the Patient Info in the Respective Fields
            PIDTxt.Text = SearchResultGrid.Rows(e.RowIndex).Cells(0).Value
            NameTxt.Text = SearchResultGrid.Rows(e.RowIndex).Cells(1).Value
            DOBTxt.Text = SearchResultGrid.Rows(e.RowIndex).Cells(2).Value
            GenderTxt.Text = SearchResultGrid.Rows(e.RowIndex).Cells(3).Value
            AddressTxt.Text = SearchResultGrid.Rows(e.RowIndex).Cells(5).Value
            MobileTxt.Text = SearchResultGrid.Rows(e.RowIndex).Cells(4).Value
            'Show Hidden items
            PatientInfoBox.Visible = True
            ClearBtn.Visible = True
            UpdateBtn.Visible = True
            DeleteBtn.Visible = True
        Catch ex As Exception
            ' MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Function ClearPatientInfo() As Boolean
        'Clear All the text box
        PIDTxt.Clear()
        NameTxt.Clear()
        MobileTxt.Clear()
        DOBTxt.Value = Format(Today(), "dd-MM-yyyy")
        AddressTxt.Clear()
        GenderTxt.Clear()
        Return True
    End Function


End Class
