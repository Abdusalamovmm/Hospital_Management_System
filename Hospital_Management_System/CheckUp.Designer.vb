<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CheckUp
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SearchResultGrid = New System.Windows.Forms.DataGridView()
        Me.SearchBox = New System.Windows.Forms.GroupBox()
        Me.SearchBtn = New System.Windows.Forms.Button()
        Me.NameSTxt = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PatientInfoBox = New System.Windows.Forms.GroupBox()
        Me.NameTxt = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.AddressTxt = New System.Windows.Forms.TextBox()
        Me.GenderTxt = New System.Windows.Forms.TextBox()
        Me.DOBTxt = New System.Windows.Forms.TextBox()
        Me.PIDTxt = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PaymentBox = New System.Windows.Forms.GroupBox()
        Me.FeesTxt = New System.Windows.Forms.TextBox()
        Me.TokenNoTxt = New System.Windows.Forms.TextBox()
        Me.RoomNoTxt = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ClearBtn = New System.Windows.Forms.Button()
        Me.PrintBtn = New System.Windows.Forms.Button()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.SearchResultGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SearchBox.SuspendLayout()
        Me.PatientInfoBox.SuspendLayout()
        Me.PaymentBox.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("MS Reference Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(392, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(261, 47)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Проверка"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SearchResultGrid
        '
        Me.SearchResultGrid.BackgroundColor = System.Drawing.Color.White
        Me.SearchResultGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SearchResultGrid.Location = New System.Drawing.Point(59, 295)
        Me.SearchResultGrid.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.SearchResultGrid.Name = "SearchResultGrid"
        Me.SearchResultGrid.ReadOnly = True
        Me.SearchResultGrid.RowHeadersWidth = 49
        Me.SearchResultGrid.RowTemplate.Height = 24
        Me.SearchResultGrid.Size = New System.Drawing.Size(853, 169)
        Me.SearchResultGrid.TabIndex = 3
        '
        'SearchBox
        '
        Me.SearchBox.Controls.Add(Me.SearchBtn)
        Me.SearchBox.Controls.Add(Me.NameSTxt)
        Me.SearchBox.Controls.Add(Me.Label2)
        Me.SearchBox.Font = New System.Drawing.Font("MS Reference Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchBox.Location = New System.Drawing.Point(179, 151)
        Me.SearchBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.SearchBox.Name = "SearchBox"
        Me.SearchBox.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.SearchBox.Size = New System.Drawing.Size(623, 128)
        Me.SearchBox.TabIndex = 4
        Me.SearchBox.TabStop = False
        Me.SearchBox.Text = "Поиск пациента"
        '
        'SearchBtn
        '
        Me.SearchBtn.BackColor = System.Drawing.Color.MidnightBlue
        Me.SearchBtn.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchBtn.ForeColor = System.Drawing.Color.White
        Me.SearchBtn.Location = New System.Drawing.Point(457, 52)
        Me.SearchBtn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.SearchBtn.Name = "SearchBtn"
        Me.SearchBtn.Size = New System.Drawing.Size(133, 37)
        Me.SearchBtn.TabIndex = 4
        Me.SearchBtn.Text = "Поиск"
        Me.SearchBtn.UseVisualStyleBackColor = False
        '
        'NameSTxt
        '
        Me.NameSTxt.Location = New System.Drawing.Point(157, 57)
        Me.NameSTxt.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.NameSTxt.Name = "NameSTxt"
        Me.NameSTxt.Size = New System.Drawing.Size(253, 27)
        Me.NameSTxt.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(43, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 28)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "ФИО :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PatientInfoBox
        '
        Me.PatientInfoBox.Controls.Add(Me.NameTxt)
        Me.PatientInfoBox.Controls.Add(Me.Label11)
        Me.PatientInfoBox.Controls.Add(Me.AddressTxt)
        Me.PatientInfoBox.Controls.Add(Me.GenderTxt)
        Me.PatientInfoBox.Controls.Add(Me.DOBTxt)
        Me.PatientInfoBox.Controls.Add(Me.PIDTxt)
        Me.PatientInfoBox.Controls.Add(Me.Label7)
        Me.PatientInfoBox.Controls.Add(Me.Label6)
        Me.PatientInfoBox.Controls.Add(Me.Label5)
        Me.PatientInfoBox.Controls.Add(Me.Label4)
        Me.PatientInfoBox.Font = New System.Drawing.Font("MS Reference Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PatientInfoBox.Location = New System.Drawing.Point(101, 485)
        Me.PatientInfoBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PatientInfoBox.Name = "PatientInfoBox"
        Me.PatientInfoBox.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PatientInfoBox.Size = New System.Drawing.Size(439, 255)
        Me.PatientInfoBox.TabIndex = 5
        Me.PatientInfoBox.TabStop = False
        Me.PatientInfoBox.Text = "Информация о пациенте"
        '
        'NameTxt
        '
        Me.NameTxt.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NameTxt.Location = New System.Drawing.Point(93, 80)
        Me.NameTxt.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.NameTxt.Name = "NameTxt"
        Me.NameTxt.ReadOnly = True
        Me.NameTxt.Size = New System.Drawing.Size(328, 25)
        Me.NameTxt.TabIndex = 9
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(20, 80)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(76, 26)
        Me.Label11.TabIndex = 8
        Me.Label11.Text = "ФИО :"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'AddressTxt
        '
        Me.AddressTxt.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddressTxt.Location = New System.Drawing.Point(124, 159)
        Me.AddressTxt.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.AddressTxt.Multiline = True
        Me.AddressTxt.Name = "AddressTxt"
        Me.AddressTxt.ReadOnly = True
        Me.AddressTxt.Size = New System.Drawing.Size(297, 90)
        Me.AddressTxt.TabIndex = 7
        '
        'GenderTxt
        '
        Me.GenderTxt.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GenderTxt.Location = New System.Drawing.Point(315, 114)
        Me.GenderTxt.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GenderTxt.Name = "GenderTxt"
        Me.GenderTxt.ReadOnly = True
        Me.GenderTxt.Size = New System.Drawing.Size(107, 25)
        Me.GenderTxt.TabIndex = 6
        '
        'DOBTxt
        '
        Me.DOBTxt.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DOBTxt.Location = New System.Drawing.Point(93, 114)
        Me.DOBTxt.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DOBTxt.Name = "DOBTxt"
        Me.DOBTxt.ReadOnly = True
        Me.DOBTxt.Size = New System.Drawing.Size(129, 25)
        Me.DOBTxt.TabIndex = 5
        '
        'PIDTxt
        '
        Me.PIDTxt.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PIDTxt.Location = New System.Drawing.Point(93, 43)
        Me.PIDTxt.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PIDTxt.Name = "PIDTxt"
        Me.PIDTxt.ReadOnly = True
        Me.PIDTxt.Size = New System.Drawing.Size(129, 25)
        Me.PIDTxt.TabIndex = 4
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(20, 159)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(105, 26)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Адрес : "
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(247, 114)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(84, 26)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Пол : "
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(20, 114)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 26)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Д.Р. :"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(20, 46)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 25)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "PID :"
        '
        'PaymentBox
        '
        Me.PaymentBox.Controls.Add(Me.FeesTxt)
        Me.PaymentBox.Controls.Add(Me.TokenNoTxt)
        Me.PaymentBox.Controls.Add(Me.RoomNoTxt)
        Me.PaymentBox.Controls.Add(Me.Label10)
        Me.PaymentBox.Controls.Add(Me.Label9)
        Me.PaymentBox.Controls.Add(Me.Label8)
        Me.PaymentBox.Font = New System.Drawing.Font("MS Reference Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PaymentBox.Location = New System.Drawing.Point(589, 485)
        Me.PaymentBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PaymentBox.Name = "PaymentBox"
        Me.PaymentBox.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PaymentBox.Size = New System.Drawing.Size(285, 165)
        Me.PaymentBox.TabIndex = 6
        Me.PaymentBox.TabStop = False
        Me.PaymentBox.Text = "Детали оплаты"
        '
        'FeesTxt
        '
        Me.FeesTxt.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FeesTxt.Location = New System.Drawing.Point(167, 111)
        Me.FeesTxt.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.FeesTxt.Name = "FeesTxt"
        Me.FeesTxt.ReadOnly = True
        Me.FeesTxt.Size = New System.Drawing.Size(100, 25)
        Me.FeesTxt.TabIndex = 9
        '
        'TokenNoTxt
        '
        Me.TokenNoTxt.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TokenNoTxt.Location = New System.Drawing.Point(167, 71)
        Me.TokenNoTxt.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TokenNoTxt.Name = "TokenNoTxt"
        Me.TokenNoTxt.ReadOnly = True
        Me.TokenNoTxt.Size = New System.Drawing.Size(100, 25)
        Me.TokenNoTxt.TabIndex = 8
        '
        'RoomNoTxt
        '
        Me.RoomNoTxt.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RoomNoTxt.Location = New System.Drawing.Point(167, 37)
        Me.RoomNoTxt.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.RoomNoTxt.Name = "RoomNoTxt"
        Me.RoomNoTxt.ReadOnly = True
        Me.RoomNoTxt.Size = New System.Drawing.Size(100, 25)
        Me.RoomNoTxt.TabIndex = 7
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(19, 114)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(121, 25)
        Me.Label10.TabIndex = 3
        Me.Label10.Text = "Стоимость  :"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(19, 71)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(107, 28)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "№ токена :"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(19, 34)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(121, 25)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "№ палаты :"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ClearBtn
        '
        Me.ClearBtn.BackColor = System.Drawing.Color.MidnightBlue
        Me.ClearBtn.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClearBtn.ForeColor = System.Drawing.Color.White
        Me.ClearBtn.Location = New System.Drawing.Point(589, 697)
        Me.ClearBtn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ClearBtn.Name = "ClearBtn"
        Me.ClearBtn.Size = New System.Drawing.Size(119, 44)
        Me.ClearBtn.TabIndex = 7
        Me.ClearBtn.Text = "Очистить"
        Me.ClearBtn.UseVisualStyleBackColor = False
        '
        'PrintBtn
        '
        Me.PrintBtn.BackColor = System.Drawing.Color.MidnightBlue
        Me.PrintBtn.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PrintBtn.ForeColor = System.Drawing.Color.White
        Me.PrintBtn.Location = New System.Drawing.Point(756, 697)
        Me.PrintBtn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PrintBtn.Name = "PrintBtn"
        Me.PrintBtn.Size = New System.Drawing.Size(119, 44)
        Me.PrintBtn.TabIndex = 8
        Me.PrintBtn.Text = "Печать"
        Me.PrintBtn.UseVisualStyleBackColor = False
        '
        'PrintDocument1
        '
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Hospital_Management_System.My.Resources.Resources.doc_Pic
        Me.PictureBox1.Location = New System.Drawing.Point(281, 21)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(125, 122)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'CheckUp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.PrintBtn)
        Me.Controls.Add(Me.ClearBtn)
        Me.Controls.Add(Me.PaymentBox)
        Me.Controls.Add(Me.PatientInfoBox)
        Me.Controls.Add(Me.SearchBox)
        Me.Controls.Add(Me.SearchResultGrid)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "CheckUp"
        Me.Size = New System.Drawing.Size(977, 804)
        CType(Me.SearchResultGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SearchBox.ResumeLayout(False)
        Me.SearchBox.PerformLayout()
        Me.PatientInfoBox.ResumeLayout(False)
        Me.PatientInfoBox.PerformLayout()
        Me.PaymentBox.ResumeLayout(False)
        Me.PaymentBox.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents SearchResultGrid As System.Windows.Forms.DataGridView
    Friend WithEvents SearchBox As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents NameSTxt As System.Windows.Forms.TextBox
    Friend WithEvents SearchBtn As System.Windows.Forms.Button
    Friend WithEvents PatientInfoBox As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents PIDTxt As System.Windows.Forms.TextBox
    Friend WithEvents DOBTxt As System.Windows.Forms.TextBox
    Friend WithEvents AddressTxt As System.Windows.Forms.TextBox
    Friend WithEvents GenderTxt As System.Windows.Forms.TextBox
    Friend WithEvents PaymentBox As System.Windows.Forms.GroupBox
    Friend WithEvents RoomNoTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TokenNoTxt As System.Windows.Forms.TextBox
    Friend WithEvents FeesTxt As System.Windows.Forms.TextBox
    Friend WithEvents ClearBtn As System.Windows.Forms.Button
    Friend WithEvents PrintBtn As System.Windows.Forms.Button
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents NameTxt As System.Windows.Forms.TextBox

End Class
