Option Strict On
Option Explicit On

Imports System.IO
Imports System.Text.RegularExpressions
Imports BencodeNET
Imports BencodeNET.Parsing
Imports BencodeNET.Torrents


Public Class fGUI

    Private TorrentFile As String = Nothing

    Private Sub fGUI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.LabelDragAndDrop.AllowDrop = True
        Me.LabelDragAndDrop.AutoSize = False
    End Sub

    Private Sub LabelDragAndDrop_DragEnter(sender As Object, e As DragEventArgs) Handles LabelDragAndDrop.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.All
        End If
    End Sub

    Private Sub LabelDragAndDrop_DragDrop(sender As Object, e As DragEventArgs) Handles LabelDragAndDrop.DragDrop
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            For Each FileFound As String In CType(e.Data.GetData(DataFormats.FileDrop), String())
                If Path.GetExtension(FileFound).ToLower = ".torrent" Then
                    TorrentFile = FileFound
                    Me.LabelDragAndDrop.Text = Path.GetFileName(TorrentFile)
                    Exit For
                End If
            Next
        End If
    End Sub

    Private Sub ButtonConvert_Click(sender As Object, e As EventArgs) Handles ButtonConvert.Click
        If TorrentFile = "" Then
            Exit Sub
        End If
        Dim GetMagnetLink As String = Nothing
        Dim MagnetLink As String = Nothing
        Try
            Dim Parser = New BencodeParser()
            Dim Torrent = Parser.Parse(Of Torrent)(TorrentFile)
            Dim TorrentName As String = Torrent.DisplayName()
            GetMagnetLink = Torrent.GetMagnetLink()
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Tor2Mag - Bencode Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try
        If Me.CheckBoxTrackerInfo.Checked = False Then
            Try
                Dim RegexObj As New Regex("(^magnet:.+?)&tr")
                MagnetLink = RegexObj.Match(GetMagnetLink).Groups(1).Value
            Catch ex As ArgumentException
                MessageBox.Show(ex.ToString, "Tor2Mag - Regex Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try
        Else
            MagnetLink = GetMagnetLink
        End If
        Try
            My.Computer.Clipboard.SetText(MagnetLink)
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Tor2Mag - Clipboard Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            My.Computer.Clipboard.Clear()
            Exit Sub
        End Try
        MessageBox.Show(MagnetLink, "Tor2Mag - Link has been copied to the clipboard", MessageBoxButtons.OK, MessageBoxIcon.Information)




    End Sub

End Class
