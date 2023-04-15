Imports System.IO
Imports System.Net
Public Class Form1

    Dim Area As Point = New Point(13, 2)
    Dim LocationOfX As Point = New Point(15, 5)

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SearchEngine.Items.Add("Google")
        SearchEngine.Items.Add("Wikipedia")
        SearchEngine.Items.Add("Youtube")

        SearchEngine.SelectedIndex = 0

        AddTab(TabControl1)
        If My.Settings.HomePageOrBlank = 0 Then
            Dim browser As Functions = Me.TabControl1.SelectedTab.Tag
            browser.Navigate(My.Settings.homePage)
        Else

        End If
        Try
            History.Show()
            History.Visible = False
            For Each link As String In File.ReadAllLines("C:\Users\user\Desktop\DragusinIoanCosminWebBrowserPractica\historyforBrowser\History.txt")
                History.lstHistory.Items.Add(link.ToString)
            Next

        Catch ex As Exception

        End Try

        Try
            For Each url As String In File.ReadAllLines("C:\Users\user\Desktop\DragusinIoanCosminWebBrowserPractica\historyforBrowser\FavoriteUrl.txt")
                ListBox3.Items.Add(url)

            Next
        Catch ex As Exception

        End Try

        Try
            ListBox3.SelectedIndex = 0

        Catch ex As Exception

        End Try


        Try
            For Each Name As String In File.ReadAllLines("C:\Users\user\Desktop\DragusinIoanCosminWebBrowserPractica\historyforBrowser\FavoriteName.txt")
                Dim newBookmark As New ToolStripButton
                newBookmark.Text = Name
                newBookmark.Tag = ListBox3.SelectedItem.ToString
                ToolStrip1.Items.Add(newBookmark)
                ListBox3.SelectedIndex = ListBox3.SelectedIndex + 1

            Next
        Catch ex As Exception

        End Try
        createBookClick()
    End Sub

    Private Sub btnGoBack_Click(sender As Object, e As EventArgs) Handles btnGoBack.Click
        Dim browser As Functions = Me.TabControl1.SelectedTab.Tag
        browser.GoBack()
    End Sub

    Private Sub btnForward_Click(sender As Object, e As EventArgs) Handles btnForward.Click
        Dim browser As Functions = Me.TabControl1.SelectedTab.Tag
        browser.GoForward()
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        Dim browser As Functions = Me.TabControl1.SelectedTab.Tag
        browser.Refresh()
    End Sub

    Private Sub WebBrowser1_Navigated(sender As Object, e As WebBrowserNavigatedEventArgs)
        Dim browser As Functions = Me.TabControl1.SelectedTab.Tag
        UrlText.Text = browser.Url.ToString
        webIcons()

        TabControl1.SelectedTab.Text = browser.DocumentTitle.ToString

        History.lstHistory.Items.Add(UrlText.Text)
    End Sub

    Private Sub UrlText_KeyUp(sender As Object, e As KeyEventArgs) Handles UrlText.KeyUp
        Dim browser As Functions = Me.TabControl1.SelectedTab.Tag
        If e.KeyCode = Keys.Enter Then
            browser.Navigate(UrlText.Text)
        End If
    End Sub

    Private Sub webIcons()
        Dim browser As Functions = Me.TabControl1.SelectedTab.Tag
        Dim wc As New WebClient
        Dim memorystream As New MemoryStream(wc.DownloadData("http://" & New Uri(browser.Url.ToString).Host & "/favicon.ico"))
        Try
            Dim icon As New Icon(memorystream)
        Catch ex As Exception
        End Try

        If ImageList1.Images.Count = -1 Then
            ImageList1.Images.Add(Icon.ToBitmap)
            TabControl1.SelectedTab.ImageIndex = 0

        Else ImageList1.Images.Clear()
            ImageList1.Images.Add(Icon.ToBitmap)
            TabControl1.SelectedTab.ImageIndex = 0
        End If
    End Sub

    Private Sub UrlCombo_KeyUp(sender As Object, e As KeyEventArgs) Handles UrlSearchEngine.KeyUp

        Dim browser As Functions = Me.TabControl1.SelectedTab.Tag

        Select Case (SearchEngine.SelectedIndex)
            Case 0
                If e.KeyCode = Keys.Enter Then
                    browser.Navigate("https://www.google.ro/search?q=" + UrlSearchEngine.Text)
                End If
            Case 1
                If e.KeyCode = Keys.Enter Then
                    browser.Navigate("https://en.wikipedia.org/w/index.php?search=" + UrlSearchEngine.Text)
                End If
            Case 2
                If e.KeyCode = Keys.Enter Then
                    browser.Navigate("https://www.youtube.com/results?search_query=" + UrlSearchEngine.Text)
                End If
        End Select
    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        Dim browser As Functions = Me.TabControl1.SelectedTab.Tag
        browser.Navigate(My.Settings.homePage)
    End Sub

    Private Declare Sub keybd_event Lib "user32" (ByVal volumeUpOrDown As Byte, ByVal v1 As Byte, ByVal v2 As Integer, ByVal v3 As Integer)

    Private Sub musicDown_Click(sender As Object, e As EventArgs) Handles musicDown.Click
        Call keybd_event(System.Windows.Forms.Keys.VolumeDown, 0, 0, 0)
    End Sub

    Private Sub MusicUp_Click(sender As Object, e As EventArgs) Handles MusicUp.Click
        Call keybd_event(System.Windows.Forms.Keys.VolumeUp, 0, 0, 0)
    End Sub

    Private Sub OptionsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OptionsToolStripMenuItem.Click
        Options.Show()
    End Sub

    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        ibnDate.Text = Now
    End Sub

    Private Sub HistoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HistoryToolStripMenuItem.Click
        History.Visible = True

    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        File.Delete("C:\Users\user\Desktop\DragusinIoanCosminWebBrowserPractica\historyforBrowser\History.txt")
        For Each link As String In History.lstHistory.Items
            File.AppendAllText("C:\Users\user\Desktop\DragusinIoanCosminWebBrowserPractica\historyforBrowser\History.txt", link & vbNewLine)
        Next


        For Each favoritename As String In lstName.Items
            File.AppendAllText("C:\Users\user\Desktop\DragusinIoanCosminWebBrowserPractica\historyforBrowser\FavoriteName.txt", favoritename & vbNewLine)
        Next

        For Each favoriteUrl As String In lstUrl.Items
            File.AppendAllText("C:\Users\user\Desktop\DragusinIoanCosminWebBrowserPractica\historyforBrowser\FavoriteUrl.txt", favoriteUrl & vbNewLine)
        Next
    End Sub

    Private Sub UrlText_TextChanged(sender As Object, e As EventArgs) Handles UrlText.TextChanged
        UrlText.AutoCompleteCustomSource.Clear()
        For i As Integer = 0 To History.lstHistory.Items.Count - 1
            UrlText.AutoCompleteCustomSource.Add(History.lstHistory.Items(i))
        Next
    End Sub

    Private Sub NewTabToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewTabToolStripMenuItem.Click
        AddTab(TabControl1)
    End Sub

    Private Sub CloseTabToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseTabToolStripMenuItem.Click
        RemoveTab()
    End Sub

    Public Sub AddTab(ByRef tabControl As TabControl)
        Dim browser As New Functions
        Dim tab As New TabPage
        browser.Tag = tab
        tab.Tag = browser
        TabControl1.TabPages.Add(tab)
        tab.Controls.Add(browser)
        browser.Dock = DockStyle.Fill
        browser.Navigate("www.google.com")
        TabControl1.SelectedTab = tab
    End Sub

    Public Sub AddTabFromHistory(ByRef tabControl As TabControl, ByRef link As String)
        Dim browser As New Functions
        Dim tab As New TabPage
        browser.Tag = tab
        tab.Tag = browser
        TabControl1.TabPages.Add(tab)
        tab.Controls.Add(browser)
        browser.Dock = DockStyle.Fill
        browser.Navigate(link)
        TabControl1.SelectedTab = tab
    End Sub

    Public Sub RemoveTab()
        If TabControl1.TabPages.Count > 0 Then
            TabControl1.TabPages.Remove(TabControl1.SelectedTab)

        End If
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
        Try
            Dim browser As Functions = TabControl1.SelectedTab.Tag
            UrlText.Text = browser.Url.ToString
        Catch ex As Exception

        End Try

    End Sub

    Private Sub NewWindowToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewWindowToolStripMenuItem.Click
        Dim newWindow As New Form1
        newWindow.Show()
    End Sub

    Private Sub UndoToolStripMenuItem_Click(sender As Object, e As EventArgs)
        UrlText.Undo()
    End Sub

    Private Sub RedoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RedoToolStripMenuItem.Click
        UrlText.ClearUndo()
    End Sub

    Private Sub CutToolStripMenuItem_Click(sender As Object, e As EventArgs)
        UrlText.Cut()
    End Sub

    Private Sub CopyToolStripMenuItem_Click(sender As Object, e As EventArgs)
        UrlText.Copy()
    End Sub

    Private Sub PasteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PasteToolStripMenuItem.Click
        UrlText.Paste()
    End Sub

    Private Sub SelectAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelectAllToolStripMenuItem.Click
        UrlText.SelectAll()
    End Sub

    Private Sub SaveHtmlToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveHtmlToolStripMenuItem.Click
        Dim browser As Functions = TabControl1.SelectedTab.Tag
        Dim filename As String = InputBox("Enter Filename", "Save Html", ".txt")
        Dim path As String = "C:\Users\user\Desktop\DragusinIoanCosminWebBrowserPractica\historyforBrowser\" & filename
        Try
            If File.Exists(path) Then
                Dim AllText As String
                AllText = browser.DocumentText
                File.WriteAllText(path, AllText)
            End If
        Catch ex As Exception
            File.Create(path).Dispose()
            Dim AllText As String
            AllText = browser.DocumentText
            File.WriteAllText(path, AllText)
        End Try
    End Sub

    Private Sub HelpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HelpToolStripMenuItem.Click
        MsgBox("Nu am implementat help ")
    End Sub

    Private Sub BookmarksToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BookmarksToolStripMenuItem.Click
        addBookmarks()
    End Sub
    Private Sub addBookmarks()
        Dim browser As Functions = TabControl1.SelectedTab.Tag

        Dim newBookmark As New ToolStripButton
        newBookmark.Text = TabControl1.SelectedTab.Text
        newBookmark.Tag = browser.Url
        ToolStrip2.Items.Add(newBookmark)
        lstName.Items.Add(TabControl1.SelectedTab.Text)
        lstUrl.Items.Add(browser.Url.ToString)
        AddHandler newBookmark.Click, AddressOf NewBookmarkClick
    End Sub

    Private Sub NewBookmarkClick(sender As Object, e As EventArgs)
        Dim browser As Functions = TabControl1.SelectedTab.Tag

        If TypeOf sender Is ToolStripButton Then
            browser.Navigate(CType(sender, ToolStripButton).Tag)
        End If

    End Sub

    Private Sub createBookClick()
        For Each Item As ToolStripButton In ToolStrip2.Items
            AddHandler Item.Click, AddressOf bookclick
        Next

    End Sub

    Private Sub bookclick(sender As Object, e As EventArgs)
        UrlText.Text = CType(sender, ToolStripButton).Tag
        bookNav()
    End Sub

    Private Sub bookNav()
        Dim browser As Functions = TabControl1.SelectedTab.Tag
        browser.Navigate(UrlText.Text)
    End Sub




End Class
