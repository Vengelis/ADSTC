Public Class LogsPage
    Private Sub ExitLogs_Click(sender As Object, e As EventArgs) Handles ExitLogs.Click
        Me.Hide()
    End Sub

    Private Sub BoxSelectViewLogs_SelectedIndexChanged(sender As Object, e As EventArgs) Handles BoxSelectViewLogs.SelectedIndexChanged
        If BoxSelectViewLogs.Text = "Loader" Then
            ReadLogs("Loader")
        ElseIf BoxSelectViewLogs.Text = "Home" Then
            ReadLogs("Home")
        ElseIf BoxSelectViewLogs.Text = "Licence" Then
            ReadLogs("Licence")
        ElseIf BoxSelectViewLogs.Text = "Paramètres" Then
            ReadLogs("Paramètres")
        End If
    End Sub
End Class