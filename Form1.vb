Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1
    ' menu strip where it can alternatively exit in menu
    Private Sub ExitTool_Click(sender As Object, e As EventArgs) Handles ExitTool.Click
        Me.Close()
    End Sub

    ' menu strip where all the information is being saved
    Private Sub SaveTool_Click(sender As Object, e As EventArgs) Handles SaveTool.Click
        MsgBox("Your Data Have Been Saved.")
    End Sub

    ' menu strip where it allow the user to open up file from specific file's type
    Private Sub OpenTool_Click(sender As Object, e As EventArgs) Handles OpenTool.Click
        openFD.InitialDirectory = "C:\"
        openFD.Title = "Open Your File"
        openFD.Filter = "Text Files|*.txt|Word Files|*.doc|PDF Files|*.pdf|All Files|*.*"
        openFD.FileName = "Choose Your File"

        openFD.ShowDialog()
    End Sub

    ' the classic button where the user submitted the data
    Private Sub BTNSubmit_Click(sender As Object, e As EventArgs) Handles BTNSubmit.Click
        MsgBox("You Have Been Registered.")
    End Sub

    ' menu strip where it can reseting all the written data in the form
    Private Sub ResetTool_Click(sender As Object, e As EventArgs) Handles ResetTool.Click
        Controls.Clear()
        InitializeComponent()
    End Sub
End Class
