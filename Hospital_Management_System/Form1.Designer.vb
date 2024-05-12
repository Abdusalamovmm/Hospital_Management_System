<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ShowPasswd = New System.Windows.Forms.CheckBox()
        Me.AdminRadioBtn = New System.Windows.Forms.RadioButton()
        Me.StaffRadioBtn = New System.Windows.Forms.RadioButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ExitBtn = New System.Windows.Forms.Button()
        Me.loginBtn = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PasswordTxt = New System.Windows.Forms.TextBox()
        Me.UsernameTxt = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        resources.ApplyResources(Me.GroupBox1, "GroupBox1")
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Menu
        Me.GroupBox1.Controls.Add(Me.ShowPasswd)
        Me.GroupBox1.Controls.Add(Me.AdminRadioBtn)
        Me.GroupBox1.Controls.Add(Me.StaffRadioBtn)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.ExitBtn)
        Me.GroupBox1.Controls.Add(Me.loginBtn)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.PasswordTxt)
        Me.GroupBox1.Controls.Add(Me.UsernameTxt)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.TabStop = False
        '
        'ShowPasswd
        '
        resources.ApplyResources(Me.ShowPasswd, "ShowPasswd")
        Me.ShowPasswd.Name = "ShowPasswd"
        Me.ShowPasswd.UseVisualStyleBackColor = True
        '
        'AdminRadioBtn
        '
        resources.ApplyResources(Me.AdminRadioBtn, "AdminRadioBtn")
        Me.AdminRadioBtn.Name = "AdminRadioBtn"
        Me.AdminRadioBtn.TabStop = True
        Me.AdminRadioBtn.UseVisualStyleBackColor = True
        '
        'StaffRadioBtn
        '
        resources.ApplyResources(Me.StaffRadioBtn, "StaffRadioBtn")
        Me.StaffRadioBtn.Name = "StaffRadioBtn"
        Me.StaffRadioBtn.TabStop = True
        Me.StaffRadioBtn.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Hospital_Management_System.My.Resources.Resources.imageedit_1_6564123496
        resources.ApplyResources(Me.PictureBox1, "PictureBox1")
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.TabStop = False
        '
        'ExitBtn
        '
        Me.ExitBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight
        resources.ApplyResources(Me.ExitBtn, "ExitBtn")
        Me.ExitBtn.Name = "ExitBtn"
        Me.ExitBtn.UseVisualStyleBackColor = False
        '
        'loginBtn
        '
        Me.loginBtn.BackColor = System.Drawing.SystemColors.ControlLightLight
        resources.ApplyResources(Me.loginBtn, "loginBtn")
        Me.loginBtn.ForeColor = System.Drawing.SystemColors.ControlText
        Me.loginBtn.Name = "loginBtn"
        Me.loginBtn.UseVisualStyleBackColor = False
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'PasswordTxt
        '
        resources.ApplyResources(Me.PasswordTxt, "PasswordTxt")
        Me.PasswordTxt.Name = "PasswordTxt"
        Me.PasswordTxt.UseSystemPasswordChar = True
        '
        'UsernameTxt
        '
        resources.ApplyResources(Me.UsernameTxt, "UsernameTxt")
        Me.UsernameTxt.Name = "UsernameTxt"
        '
        'Form1
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Hospital_Management_System.My.Resources.Resources.golisano_childrens_hospital_2
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PasswordTxt As System.Windows.Forms.TextBox
    Friend WithEvents UsernameTxt As System.Windows.Forms.TextBox
    Friend WithEvents loginBtn As System.Windows.Forms.Button
    Friend WithEvents ExitBtn As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents StaffRadioBtn As System.Windows.Forms.RadioButton
    Friend WithEvents AdminRadioBtn As System.Windows.Forms.RadioButton
    Friend WithEvents ShowPasswd As System.Windows.Forms.CheckBox

End Class
