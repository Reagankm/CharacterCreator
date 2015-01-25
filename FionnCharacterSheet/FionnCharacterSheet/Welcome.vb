Option Strict On

Public Class Welcome

    Private Sub CreateButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CreateButton.Click

        'Close the current window and open the first character
        'creation window
        BaseStats.ShowDialog()
        Me.Close()

    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click

        'Exit program
        Me.Close()

    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click

        'Show about box
        AboutBox.ShowDialog()

    End Sub
End Class
