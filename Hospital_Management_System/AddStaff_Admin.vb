Imports System.Data.OleDb
Imports System.Net.Mail
Public Class AddStaff_Admin
    Dim username As String
    Dim password As String
    Private Sub AddStaff_Admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DOBTxt.MaxDate = Format(Date.Now(), "dd-MM-yyyy")
    End Sub
    ' clear button to clear everthything
    Private Sub ClearBtn_Click(sender As Object, e As EventArgs) Handles ClearBtn.Click
        NameTxt.Clear()
        DOBTxt.Value = Format(Today(), "dd-MM-yyyy")
        GenderTxt.SelectedIndex = -1
        WorkShiftTxt.SelectedIndex = -1
        DesignationTxt.SelectedIndex = -1
        MobileTxt.Clear()
        EmailTxt.Clear()
        AddressTxt.Clear()
        SuccessMsg.Visible = False
    End Sub

    Private Sub RegisterBtn_Click(sender As Object, e As EventArgs) Handles RegisterBtn.Click
        Dim myconnection As OleDbConnection = New OleDbConnection
        Dim cmd As OleDbCommand
        'Connection String
        myconnection.ConnectionString = Form1.provider & Form1.datafile
        If Not Validate_data() Then
            Exit Sub
        End If
        username = NameTxt.Text.Split("."c)(0)
        username = username.Split(" "c)(0)
        username = Transliterate_Username(username)
        password = Random_Password_Generator()
        Dim var_date As DateTime = Format(DOBTxt.Value, "dd-MM-yyyy")
        myconnection.Open()
        'MessageBox.Show("Connected")
        Dim query As String
        'Insert into database 
        query = "Insert Into [Staff] ([Name],[Designation],[Date Of Birth],[Gender],[Mobile],[Email],[Address],[Work Shift],[Username],[Password]) Values (?,?,?,?,?,?,?,?,?,?)"
        cmd = New OleDbCommand(query, myconnection)
        Try
            'Specify the parameters and corresponding values
            cmd.Parameters.Add(New OleDbParameter("Name", CType(NameTxt.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("Designation", CType(DesignationTxt.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("Date Of Birth", CType(var_date, String)))
            cmd.Parameters.Add(New OleDbParameter("Gender", CType(GenderTxt.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("Mobile", CType(MobileTxt.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("Email", CType(EmailTxt.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("Address", CType(AddressTxt.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("Work Shift", CType(WorkShiftTxt.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("Username", CType(username, String)))
            cmd.Parameters.Add(New OleDbParameter("Password", CType(password, String)))
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            'Close the Connection
            myconnection.Close()
            'Display Success Message
            SuccessMsg.Visible = True
            SuccessMsg.Text = "Сотрудник успешно зарегистрирован." & vbCrLf & "логин: " & username & vbCrLf & "пароль: " & password
            SuccessMsg.BackColor = Color.Green
            'Start timer
            ClearBtn_Click(sender, e)
            SuccessMsg.Visible = True

        Catch ex As Exception
            'Close the connection
            myconnection.Close()
            'MessageBox.Show(query)
            ' 'Display failure Message
            SuccessMsg.Visible = True
            SuccessMsg.Text = "Неверные учетные данные"
            SuccessMsg.BackColor = Color.Red
            'Start timer
            Timer1.Start()
        End Try

    End Sub
    'Function Sends Email to staff member regarding his username and password

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        SuccessMsg.Visible = False
        Timer1.Stop()
    End Sub
    Private Function Validate_data() As Boolean
        If Not Form1.Name_Validation(NameTxt.Text) Then
            'Display failure Message
            SuccessMsg.Visible = True
            SuccessMsg.Text = "Недопустимое имя"
            SuccessMsg.BackColor = Color.Red
            'Start timer
            Timer1.Start()
            Return False
        End If
        If GenderTxt.SelectedIndex = -1 Then
            SuccessMsg.Visible = True
            SuccessMsg.Text = "Неверный пол"
            SuccessMsg.BackColor = Color.Red
            'Start timer
            Timer1.Start()
            Return False
        End If
        If Not Form1.Gender_Validator(GenderTxt.Text) Then
            'Display failure Message
            SuccessMsg.Visible = True
            SuccessMsg.Text = "Неверный пол"
            SuccessMsg.BackColor = Color.Red
            'Start timer
            Timer1.Start()
            Return False
        End If
        If Not Form1.Mobile_Validator(MobileTxt.Text) Then
            'Display failure Message
            SuccessMsg.Visible = True
            SuccessMsg.Text = "Неверный номер мобильного телефона"
            SuccessMsg.BackColor = Color.Red
            'Start timer
            Timer1.Start()
            Return False
        End If
        If WorkShiftTxt.SelectedIndex = -1 Then
            'Display failure Message
            SuccessMsg.Visible = True
            SuccessMsg.Text = "Неверный номер рабочей смены"
            SuccessMsg.BackColor = Color.Red
            'Start timer
            Timer1.Start()
            Return False
        End If
        If DesignationTxt.SelectedIndex = -1 Then
            'Display failure Message
            SuccessMsg.Visible = True
            SuccessMsg.Text = "Недопустимое обозначение"
            SuccessMsg.BackColor = Color.Red
            'Start timer
            Timer1.Start()
            Return False
        End If
        If AddressTxt.Text = "" Then
            'Display failure Message
            SuccessMsg.Visible = True
            SuccessMsg.Text = "Требуемый адрес"
            SuccessMsg.BackColor = Color.Red
            'Start timer
            Timer1.Start()
            Return False
        End If
        If EmailTxt.Text = "" Then
            'Display failiure Message
            SuccessMsg.Visible = True
            SuccessMsg.Text = "Поле электронной почты обязательно для заполнения"
            SuccessMsg.BackColor = Color.Red
            'Start Timer
            Timer1.Start()
        End If

        Return True
    End Function

    Private Function Random_Password_Generator() As String
        Dim validchars As String = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890"

        Dim sb As String = ""
        Dim rand As New Random()
        For i As Integer = 1 To 10
            Dim idx As Integer = rand.Next(0, validchars.Length)
            Dim randomChar As Char = validchars(idx)
            sb += randomChar
        Next i
        Return sb
    End Function

    ' Добавляем новую функцию, которая принимает username на русском языке и возвращает его транслитерацию на английском языке
    Private Function Transliterate_Username(ByVal username As String) As String
        ' Создаем словарь, в котором ключи - русские буквы, а значения - соответствующие английские буквы
        Dim translit_dict As New Dictionary(Of String, String)
        translit_dict.Add("А", "A")
        translit_dict.Add("Б", "B")
        translit_dict.Add("В", "V")
        translit_dict.Add("Г", "G")
        translit_dict.Add("Д", "D")
        translit_dict.Add("Е", "E")
        translit_dict.Add("Ё", "Yo")
        translit_dict.Add("Ж", "Zh")
        translit_dict.Add("З", "Z")
        translit_dict.Add("И", "I")
        translit_dict.Add("Й", "Y")
        translit_dict.Add("К", "K")
        translit_dict.Add("Л", "L")
        translit_dict.Add("М", "M")
        translit_dict.Add("Н", "N")
        translit_dict.Add("О", "O")
        translit_dict.Add("П", "P")
        translit_dict.Add("Р", "R")
        translit_dict.Add("С", "S")
        translit_dict.Add("Т", "T")
        translit_dict.Add("У", "U")
        translit_dict.Add("Ф", "F")
        translit_dict.Add("Х", "Kh")
        translit_dict.Add("Ц", "Ts")
        translit_dict.Add("Ч", "Ch")
        translit_dict.Add("Ш", "Sh")
        translit_dict.Add("Щ", "Shch")
        translit_dict.Add("Ъ", "")
        translit_dict.Add("Ы", "Y")
        translit_dict.Add("Ь", "")
        translit_dict.Add("Э", "E")
        translit_dict.Add("Ю", "Yu")
        translit_dict.Add("Я", "Ya")
        translit_dict.Add("а", "a")
        translit_dict.Add("б", "b")
        translit_dict.Add("в", "v")
        translit_dict.Add("г", "g")
        translit_dict.Add("д", "d")
        translit_dict.Add("е", "e")
        translit_dict.Add("ё", "yo")
        translit_dict.Add("ж", "zh")
        translit_dict.Add("з", "z")
        translit_dict.Add("и", "i")
        translit_dict.Add("й", "y")
        translit_dict.Add("к", "k")
        translit_dict.Add("л", "l")
        translit_dict.Add("м", "m")
        translit_dict.Add("н", "n")
        translit_dict.Add("о", "o")
        translit_dict.Add("п", "p")
        translit_dict.Add("р", "r")
        translit_dict.Add("с", "s")
        translit_dict.Add("т", "t")
        translit_dict.Add("у", "u")
        translit_dict.Add("ф", "f")
        translit_dict.Add("х", "kh")
        translit_dict.Add("ц", "ts")
        translit_dict.Add("ч", "ch")
        translit_dict.Add("ш", "sh")
        translit_dict.Add("щ", "shch")
        translit_dict.Add("ъ", "")
        translit_dict.Add("ы", "y")
        translit_dict.Add("ь", "")
        translit_dict.Add("э", "e")
        translit_dict.Add("ю", "yu")
        translit_dict.Add("я", "ya")

        ' Создаем переменную, в которой будем хранить результат транслитерации
        Dim translit_username As String = ""

        ' Проходим по каждому символу в username
        For Each c As Char In username
            ' Если символ - русская буква, то добавляем в результат соответствующую английскую букву из словаря
            If translit_dict.ContainsKey(c) Then
                translit_username += translit_dict(c)
            Else
                ' Если символ - не русская буква, то просто добавляем его в результат без изменений
                translit_username += c
            End If
        Next

        ' Возвращаем результат транслитерации
        Return translit_username
    End Function

End Class
