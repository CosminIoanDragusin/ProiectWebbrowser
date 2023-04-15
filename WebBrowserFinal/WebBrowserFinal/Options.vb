Imports System.Net.Mail

Public Class Options
    Dim historyRemember As Integer = 0
    Public Sub setHistory(ByVal int As Integer)
        historyRemember = int
    End Sub

    Public Function getHistory()
        Return historyRemember
    End Function

    Private Sub Options_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UrlStartUp.Text = My.Settings.homePage

        If My.Settings.HomePageOrBlank = 0 Then
            StartUpComboBox.SelectedIndex = 0
        ElseIf My.Settings.HomePageOrBlank = 1 Then
            StartUpComboBox.SelectedIndex = 1

        End If

        RememberHistory.Checked = True
        setHistory(0)
        Try
            Dim process As New Process
            process.StartInfo.UseShellExecute = False
            process.StartInfo.RedirectStandardOutput = True

            Try
                process.StartInfo.FileName = "ipconfig"
                process.StartInfo.Arguments = "/all"
                process.StartInfo.CreateNoWindow = True
                process.Start()
                txtNetwork.Text = txtNetwork.Text + Replace(process.StandardOutput.ReadToEnd(), Chr(13) & Chr(13), Chr(13))
                process.WaitForExit()
            Catch ex As Exception

            End Try
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Save_Click(sender As Object, e As EventArgs) Handles Save.Click
        My.Settings.homePage = UrlStartUp.Text
        My.Settings.Save()
        My.Settings.Reload()

        My.Settings.HomePageOrBlank = StartUpComboBox.SelectedIndex.ToString
        My.Settings.Save()
        My.Settings.Reload()
    End Sub

    Private Sub RememberHistory_CheckedChanged(sender As Object, e As EventArgs) Handles RememberHistory.CheckedChanged
        If RememberHistory.Checked = True Then
            setHistory(0)
        End If
    End Sub

    Private Sub NeverRememberHistory_CheckedChanged(sender As Object, e As EventArgs) Handles NeverRememberHistory.CheckedChanged
        If NeverRememberHistory.Checked = True Then
            setHistory(1)
        End If
    End Sub

    Private Sub btnSend_Click(sender As Object, e As EventArgs) Handles btnSend.Click
        Try
            Dim MyMailMessage As New MailMessage()
            MyMailMessage.From = New MailAddress(EmailText.Text)
            MyMailMessage.To.Add(TextTo.Text)
            MyMailMessage.Subject = SubjectText.Text
            MyMailMessage.Body = WriteEmailHere.Text
            Dim smtPServer As New SmtpClient("smt.pgmail.com")
            smtPServer.Port = 587
            smtPServer.Credentials = New Net.NetworkCredential(TextTo.Text, PasswordText.Text)
            smtPServer.EnableSsl = True
            smtPServer.Send(MyMailMessage)
        Catch ex As Exception

        End Try
    End Sub
End Class