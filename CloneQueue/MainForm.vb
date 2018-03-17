﻿Imports CloneQueue

Public Class MainForm
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CloneQueue.GitIsFunctional(True)
    End Sub

    Private Sub CloneList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CloneList.SelectedIndexChanged

    End Sub

    Private Sub RepoURL_TextChanged(sender As Object, e As EventArgs) Handles RepoURL.TextChanged

    End Sub

    Private Sub CloneRepo_Click(sender As Object, e As EventArgs) Handles CloneRepo.Click
        If Not String.IsNullOrEmpty(Me.RepoURL.Text) And CloneQueue.GitIsFunctional(True) Then
            Dim cloneCall As Process = CloneQueue.Clone(Me.RepoURL.Text)

            If cloneCall.ExitCode = 0 Then
                RepoURL.Text = String.Empty
            End If
        End If
    End Sub

End Class
