Imports YoutubeExplode
Imports AuraDownloader.Extras
Imports YoutubeExplode.Common
Imports YoutubeExplode.Search
Imports System.IO
Imports System.Net.Http
Public Class YoutubeEngine
    Private YTClient As New YoutubeClient()
    Private Sub YoutubeEngine_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckForIllegalCrossThreadCalls = False
        ResultsLV.GetType().GetProperty("DoubleBuffered", Reflection.BindingFlags.NonPublic Or Reflection.BindingFlags.Instance).SetValue(ResultsLV, True, Nothing)
    End Sub

    Private Async Sub Button1_Click(sender As Object, e As EventArgs) Handles SearchBtn.Click
        Try
            If Not IsEmpty(Me.qry.Text) Then
                Me.loader.Visible = True
                If Not Me.ResultsLV.Items.Count = 0 Then Me.ResultsLV.Items.Clear()
                Me.qry.Enabled = False
                Me.SearchBtn.Enabled = False
                Dim reslt = Await YTClient.Search.GetVideosAsync(Me.qry.Text)
                If reslt.Count = 0 Then
                    MessageBox.Show(caption:="No Results", text:="No results found. Please try again with a different query.", buttons:=MessageBoxButtons.OK, icon:=MessageBoxIcon.Information)
                    Me.qry.Enabled = True
                    Me.loader.Visible = False
                    Me.SearchBtn.Enabled = True
                    Return
                End If
                Me.ResultsLV.BeginUpdate()
                For Each item As VideoSearchResult In reslt
                    Dim l As New ListViewItem() With {
                        .Text = item.Title,
                        .ImageIndex = 0}
                    l.UseItemStyleForSubItems = True
                    l.ForeColor = Color.FromArgb(20, 30, 40)
                    l.SubItems.Add(item.Duration.ToString())
                    l.SubItems.Add(item.Author.ChannelTitle)
                    l.SubItems.Add(item.Url)
                    l.Tag = item.Id
                    Me.ResultsLV.Items.Add(l)
                Next
                Me.ResultsLV.EndUpdate()
                Me.loader.Visible = False
                Me.qry.Enabled = True
                Me.SearchBtn.Enabled = True
            End If
        Catch ex As Exception
            Me.loader.Visible = False
            Me.qry.Enabled = True
            Me.SearchBtn.Enabled = True
            MessageBox.Show(caption:="Unknown Error", text:=ex.Message, buttons:=MessageBoxButtons.OK, icon:=MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ContextMenuStrip1_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip1.Opening
        If Me.ResultsLV.SelectedItems Is Nothing OrElse Me.ResultsLV.SelectedItems.Count = 0 Then e.Cancel = True
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        Dim item As ListViewItem = Me.ResultsLV.SelectedItems.Item(0)
        Dim fetch As New VideoInfoFetcher(CType(item.Tag, Videos.VideoId), Me.Owner, Me.YTClient)
        fetch.Show()
        Me.Close()
    End Sub

    Private Sub ToolStripMenuItem4_Click(sender As Object, e As EventArgs)
        Dim item = ResultsLV.SelectedItems.Item(0)
        Dim fetch As New VideoInfoFetcher(item.Tag, Owner, YTClient, True)
        fetch.Show
        Me.Close()
    End Sub
End Class