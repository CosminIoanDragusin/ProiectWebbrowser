Imports System.IO

Public Class History
    Private Sub History_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        e.Cancel = True
        Me.Visible = False

        File.Delete("C:\Users\user\Desktop\DragusinIoanCosminWebBrowserPractica\historyforBrowser\History.txt")
        For Each link As String In lstHistory.Items
            File.AppendAllText("C:\Users\user\Desktop\DragusinIoanCosminWebBrowserPractica\historyforBrowser\History.txt", link & vbNewLine)
        Next
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Visible = False
        File.Delete("C:\Users\user\Desktop\DragusinIoanCosminWebBrowserPractica\historyforBrowser\History.txt")
        For Each link As String In lstHistory.Items
            File.AppendAllText("C:\Users\user\Desktop\DragusinIoanCosminWebBrowserPractica\historyforBrowser\History.txt", link & vbNewLine)
        Next
    End Sub

    Private Sub btnDeleteAll_Click(sender As Object, e As EventArgs) Handles btnDeleteAll.Click
        lstHistory.Items.Clear()
        File.Delete("C:\Users\user\Desktop\DragusinIoanCosminWebBrowserPractica\historyforBrowser\History.txt")
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        lstHistory.Items.Remove(lstHistory.SelectedItem)
    End Sub

    Private Sub History_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDoubleClick
        Form1.AddTabFromHistory(Form1.TabControl1, lstHistory.SelectedItem.ToString)
    End Sub
End Class