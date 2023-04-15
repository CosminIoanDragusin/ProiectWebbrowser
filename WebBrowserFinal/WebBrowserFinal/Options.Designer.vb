<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Options
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Options))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.Generals = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.SaveToBtn = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.AlwaysSave = New System.Windows.Forms.RadioButton()
        Me.SaveFiles = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Save = New System.Windows.Forms.Button()
        Me.UrlStartUp = New System.Windows.Forms.TextBox()
        Me.StartUpComboBox = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Privacy = New System.Windows.Forms.TabPage()
        Me.History = New System.Windows.Forms.GroupBox()
        Me.RememberHistory = New System.Windows.Forms.RadioButton()
        Me.NeverRememberHistory = New System.Windows.Forms.RadioButton()
        Me.Email = New System.Windows.Forms.TabPage()
        Me.Subject = New System.Windows.Forms.Label()
        Me.SubjectText = New System.Windows.Forms.TextBox()
        Me.TextTo = New System.Windows.Forms.TextBox()
        Me.ToEmail = New System.Windows.Forms.Label()
        Me.PasswordText = New System.Windows.Forms.TextBox()
        Me.EmailText = New System.Windows.Forms.TextBox()
        Me.WriteEmailHere = New System.Windows.Forms.TextBox()
        Me.btnSend = New System.Windows.Forms.Button()
        Me.EmailPassword = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Network = New System.Windows.Forms.TabPage()
        Me.txtNetwork = New System.Windows.Forms.TextBox()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.TabControl1.SuspendLayout()
        Me.Generals.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Privacy.SuspendLayout()
        Me.History.SuspendLayout()
        Me.Email.SuspendLayout()
        Me.Network.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.Generals)
        Me.TabControl1.Controls.Add(Me.Privacy)
        Me.TabControl1.Controls.Add(Me.Email)
        Me.TabControl1.Controls.Add(Me.Network)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.ImageList = Me.ImageList1
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(384, 311)
        Me.TabControl1.TabIndex = 0
        '
        'Generals
        '
        Me.Generals.Controls.Add(Me.GroupBox2)
        Me.Generals.Controls.Add(Me.GroupBox1)
        Me.Generals.ImageIndex = 2
        Me.Generals.Location = New System.Drawing.Point(4, 23)
        Me.Generals.Name = "Generals"
        Me.Generals.Padding = New System.Windows.Forms.Padding(3)
        Me.Generals.Size = New System.Drawing.Size(376, 284)
        Me.Generals.TabIndex = 0
        Me.Generals.Text = "Generals"
        Me.Generals.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.SaveToBtn)
        Me.GroupBox2.Controls.Add(Me.TextBox1)
        Me.GroupBox2.Controls.Add(Me.AlwaysSave)
        Me.GroupBox2.Controls.Add(Me.SaveFiles)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 114)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(233, 100)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Downloads"
        '
        'SaveToBtn
        '
        Me.SaveToBtn.Location = New System.Drawing.Point(198, 17)
        Me.SaveToBtn.Name = "SaveToBtn"
        Me.SaveToBtn.Size = New System.Drawing.Size(29, 23)
        Me.SaveToBtn.TabIndex = 5
        Me.SaveToBtn.Text = "..."
        Me.SaveToBtn.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(83, 19)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(109, 20)
        Me.TextBox1.TabIndex = 4
        '
        'AlwaysSave
        '
        Me.AlwaysSave.AutoSize = True
        Me.AlwaysSave.Location = New System.Drawing.Point(3, 61)
        Me.AlwaysSave.Name = "AlwaysSave"
        Me.AlwaysSave.Size = New System.Drawing.Size(146, 17)
        Me.AlwaysSave.TabIndex = 1
        Me.AlwaysSave.TabStop = True
        Me.AlwaysSave.Text = "AlwaysAskWhereToSave"
        Me.AlwaysSave.UseVisualStyleBackColor = True
        '
        'SaveFiles
        '
        Me.SaveFiles.AutoSize = True
        Me.SaveFiles.Location = New System.Drawing.Point(3, 19)
        Me.SaveFiles.Name = "SaveFiles"
        Me.SaveFiles.Size = New System.Drawing.Size(84, 17)
        Me.SaveFiles.TabIndex = 0
        Me.SaveFiles.TabStop = True
        Me.SaveFiles.Text = "SaveFilesTo"
        Me.SaveFiles.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.Save)
        Me.GroupBox1.Controls.Add(Me.UrlStartUp)
        Me.GroupBox1.Controls.Add(Me.StartUpComboBox)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(233, 100)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "StartUp"
        '
        'Save
        '
        Me.Save.Location = New System.Drawing.Point(152, 77)
        Me.Save.Name = "Save"
        Me.Save.Size = New System.Drawing.Size(75, 23)
        Me.Save.TabIndex = 1
        Me.Save.Text = "Save"
        Me.Save.UseVisualStyleBackColor = True
        '
        'UrlStartUp
        '
        Me.UrlStartUp.Location = New System.Drawing.Point(106, 53)
        Me.UrlStartUp.Name = "UrlStartUp"
        Me.UrlStartUp.Size = New System.Drawing.Size(121, 20)
        Me.UrlStartUp.TabIndex = 3
        '
        'StartUpComboBox
        '
        Me.StartUpComboBox.FormattingEnabled = True
        Me.StartUpComboBox.Items.AddRange(New Object() {"Homepage", "Open Blank Page"})
        Me.StartUpComboBox.Location = New System.Drawing.Point(106, 22)
        Me.StartUpComboBox.Name = "StartUpComboBox"
        Me.StartUpComboBox.Size = New System.Drawing.Size(121, 21)
        Me.StartUpComboBox.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "HomePage"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "WhenStartUpsStart"
        '
        'Privacy
        '
        Me.Privacy.Controls.Add(Me.History)
        Me.Privacy.ImageIndex = 1
        Me.Privacy.Location = New System.Drawing.Point(4, 23)
        Me.Privacy.Name = "Privacy"
        Me.Privacy.Size = New System.Drawing.Size(376, 284)
        Me.Privacy.TabIndex = 2
        Me.Privacy.Text = "Privacy"
        Me.Privacy.UseVisualStyleBackColor = True
        '
        'History
        '
        Me.History.Controls.Add(Me.RememberHistory)
        Me.History.Controls.Add(Me.NeverRememberHistory)
        Me.History.Location = New System.Drawing.Point(8, 8)
        Me.History.Name = "History"
        Me.History.Size = New System.Drawing.Size(342, 100)
        Me.History.TabIndex = 0
        Me.History.TabStop = False
        Me.History.Text = "History"
        '
        'RememberHistory
        '
        Me.RememberHistory.AutoSize = True
        Me.RememberHistory.Location = New System.Drawing.Point(6, 29)
        Me.RememberHistory.Name = "RememberHistory"
        Me.RememberHistory.Size = New System.Drawing.Size(108, 17)
        Me.RememberHistory.TabIndex = 1
        Me.RememberHistory.TabStop = True
        Me.RememberHistory.Text = "RememberHistory"
        Me.RememberHistory.UseVisualStyleBackColor = True
        '
        'NeverRememberHistory
        '
        Me.NeverRememberHistory.AutoSize = True
        Me.NeverRememberHistory.Location = New System.Drawing.Point(6, 65)
        Me.NeverRememberHistory.Name = "NeverRememberHistory"
        Me.NeverRememberHistory.Size = New System.Drawing.Size(137, 17)
        Me.NeverRememberHistory.TabIndex = 2
        Me.NeverRememberHistory.TabStop = True
        Me.NeverRememberHistory.Text = "NeverRememberHistory"
        Me.NeverRememberHistory.UseVisualStyleBackColor = True
        '
        'Email
        '
        Me.Email.Controls.Add(Me.Subject)
        Me.Email.Controls.Add(Me.SubjectText)
        Me.Email.Controls.Add(Me.TextTo)
        Me.Email.Controls.Add(Me.ToEmail)
        Me.Email.Controls.Add(Me.PasswordText)
        Me.Email.Controls.Add(Me.EmailText)
        Me.Email.Controls.Add(Me.WriteEmailHere)
        Me.Email.Controls.Add(Me.btnSend)
        Me.Email.Controls.Add(Me.EmailPassword)
        Me.Email.Controls.Add(Me.Label3)
        Me.Email.ImageIndex = 4
        Me.Email.Location = New System.Drawing.Point(4, 23)
        Me.Email.Name = "Email"
        Me.Email.Size = New System.Drawing.Size(376, 284)
        Me.Email.TabIndex = 3
        Me.Email.Text = "Email"
        Me.Email.UseVisualStyleBackColor = True
        '
        'Subject
        '
        Me.Subject.AutoSize = True
        Me.Subject.Location = New System.Drawing.Point(8, 97)
        Me.Subject.Name = "Subject"
        Me.Subject.Size = New System.Drawing.Size(43, 13)
        Me.Subject.TabIndex = 8
        Me.Subject.Text = "Subject"
        '
        'SubjectText
        '
        Me.SubjectText.Location = New System.Drawing.Point(92, 90)
        Me.SubjectText.Name = "SubjectText"
        Me.SubjectText.Size = New System.Drawing.Size(258, 20)
        Me.SubjectText.TabIndex = 7
        '
        'TextTo
        '
        Me.TextTo.Location = New System.Drawing.Point(92, 34)
        Me.TextTo.Name = "TextTo"
        Me.TextTo.Size = New System.Drawing.Size(258, 20)
        Me.TextTo.TabIndex = 6
        '
        'ToEmail
        '
        Me.ToEmail.AutoSize = True
        Me.ToEmail.Location = New System.Drawing.Point(8, 41)
        Me.ToEmail.Name = "ToEmail"
        Me.ToEmail.Size = New System.Drawing.Size(20, 13)
        Me.ToEmail.TabIndex = 5
        Me.ToEmail.Text = "To"
        '
        'PasswordText
        '
        Me.PasswordText.Location = New System.Drawing.Point(92, 64)
        Me.PasswordText.Name = "PasswordText"
        Me.PasswordText.Size = New System.Drawing.Size(258, 20)
        Me.PasswordText.TabIndex = 4
        '
        'EmailText
        '
        Me.EmailText.Location = New System.Drawing.Point(91, 8)
        Me.EmailText.Name = "EmailText"
        Me.EmailText.Size = New System.Drawing.Size(259, 20)
        Me.EmailText.TabIndex = 3
        '
        'WriteEmailHere
        '
        Me.WriteEmailHere.Location = New System.Drawing.Point(6, 116)
        Me.WriteEmailHere.Multiline = True
        Me.WriteEmailHere.Name = "WriteEmailHere"
        Me.WriteEmailHere.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.WriteEmailHere.Size = New System.Drawing.Size(370, 136)
        Me.WriteEmailHere.TabIndex = 3
        '
        'btnSend
        '
        Me.btnSend.Location = New System.Drawing.Point(6, 258)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(370, 23)
        Me.btnSend.TabIndex = 2
        Me.btnSend.Text = "Send"
        Me.btnSend.UseVisualStyleBackColor = True
        '
        'EmailPassword
        '
        Me.EmailPassword.AutoSize = True
        Me.EmailPassword.Location = New System.Drawing.Point(8, 67)
        Me.EmailPassword.Name = "EmailPassword"
        Me.EmailPassword.Size = New System.Drawing.Size(78, 13)
        Me.EmailPassword.TabIndex = 1
        Me.EmailPassword.Text = "EmailPassword"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 11)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Email"
        '
        'Network
        '
        Me.Network.Controls.Add(Me.txtNetwork)
        Me.Network.ImageIndex = 3
        Me.Network.Location = New System.Drawing.Point(4, 23)
        Me.Network.Name = "Network"
        Me.Network.Size = New System.Drawing.Size(376, 284)
        Me.Network.TabIndex = 4
        Me.Network.Text = "Network"
        Me.Network.UseVisualStyleBackColor = True
        '
        'txtNetwork
        '
        Me.txtNetwork.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtNetwork.Location = New System.Drawing.Point(0, 0)
        Me.txtNetwork.Multiline = True
        Me.txtNetwork.Name = "txtNetwork"
        Me.txtNetwork.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtNetwork.Size = New System.Drawing.Size(376, 284)
        Me.txtNetwork.TabIndex = 0
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "icons8-content-16.png")
        Me.ImageList1.Images.SetKeyName(1, "icons8-cyber-security-16.png")
        Me.ImageList1.Images.SetKeyName(2, "icons8-general-electrics-16.png")
        Me.ImageList1.Images.SetKeyName(3, "icons8-mac-client-16.png")
        Me.ImageList1.Images.SetKeyName(4, "icons8-privacy-16.png")
        '
        'Options
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(384, 311)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Options"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Options"
        Me.TabControl1.ResumeLayout(False)
        Me.Generals.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Privacy.ResumeLayout(False)
        Me.History.ResumeLayout(False)
        Me.History.PerformLayout()
        Me.Email.ResumeLayout(False)
        Me.Email.PerformLayout()
        Me.Network.ResumeLayout(False)
        Me.Network.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents Generals As TabPage
    Friend WithEvents Privacy As TabPage
    Friend WithEvents Email As TabPage
    Friend WithEvents Network As TabPage
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents UrlStartUp As TextBox
    Friend WithEvents StartUpComboBox As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents AlwaysSave As RadioButton
    Friend WithEvents SaveFiles As RadioButton
    Friend WithEvents SaveToBtn As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents History As GroupBox
    Friend WithEvents RememberHistory As RadioButton
    Friend WithEvents NeverRememberHistory As RadioButton
    Friend WithEvents Save As Button
    Friend WithEvents txtNetwork As TextBox
    Friend WithEvents PasswordText As TextBox
    Friend WithEvents EmailText As TextBox
    Friend WithEvents WriteEmailHere As TextBox
    Friend WithEvents btnSend As Button
    Friend WithEvents EmailPassword As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextTo As TextBox
    Friend WithEvents ToEmail As Label
    Friend WithEvents Subject As Label
    Friend WithEvents SubjectText As TextBox
End Class
