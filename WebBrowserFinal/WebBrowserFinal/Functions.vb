Public Class Functions
    Inherits WebBrowser
    Private Sub webBrowserDocumentComp() Handles Me.DocumentCompleted
        Dim TabPage As TabPage = Me.Tag

        If Me.DocumentTitle.Length > 25 Then
            TabPage.Text = Me.DocumentTitle.Substring(0, 25)
        Else
            TabPage.Text = Me.DocumentTitle
        End If
        Form1.UrlText.Text = Me.Url.ToString

        If Not History.lstHistory.Items.Contains(Form1.UrlText.Text) And Options.getHistory = 0 Then
            History.lstHistory.Items.Add(Form1.UrlText.Text)
        End If
    End Sub
    Public Sub New()
        Me.ScriptErrorsSuppressed = True
    End Sub

End Class
