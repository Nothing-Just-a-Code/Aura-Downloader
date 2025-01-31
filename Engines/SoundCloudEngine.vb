Imports SoundCloudExplode.Search
Imports SoundCloudExplode.Tracks
Imports SoundCloudExplode
Imports AuraDownloader.Extras
Imports SoundCloudExplode.Common
Public Class SoundCloudEngine
    Private SC As New SoundCloudClient()
    Private Async Sub SoundCloudEngine_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckForIllegalCrossThreadCalls = False
        ResultsLV.GetType().GetProperty("DoubleBuffered", Reflection.BindingFlags.NonPublic Or Reflection.BindingFlags.Instance).SetValue(ResultsLV, True, Nothing)
        If Not SC.IsInitialized Then Await SC.InitializeAsync()
    End Sub

    Private Async Sub SearchBtn_Click(sender As Object, e As EventArgs) Handles SearchBtn.Click
        Try
            If Not IsEmpty(Me.qry.Text) Then
                Me.qry.Enabled = False
                Me.SearchBtn.Enabled = False
                Me.loader.Visible = True
                If Not Me.ResultsLV.Items.Count = 0 Then Me.ResultsLV.Items.Clear()
                Dim res = Await SC.Search.GetTracksAsync(searchQuery:=Me.qry.Text, offset:=0, limit:=50)
                If res.Count = 0 Then
                    MessageBox.Show(caption:="No Result Found", text:="No result found by using this query. Try again with a different query.", buttons:=MessageBoxButtons.OK, icon:=MessageBoxIcon.Error)
                    Me.qry.Enabled = True
                    Me.SearchBtn.Enabled = True
                    Me.loader.Visible = False
                    Return
                End If
                Me.ResultsLV.BeginUpdate()
                For Each item As TrackSearchResult In res
                    Dim l As New ListViewItem() With {.Text = item.Title, .ImageIndex = 0, .ForeColor = Color.FromArgb(20, 30, 40)}
                    l.UseItemStyleForSubItems = True
                    l.SubItems.Add(TimeSpan.FromMilliseconds(item.Duration).ToString("hh\:mm\:ss"))
                    l.SubItems.Add(item.User.Username)
                    l.SubItems.Add(item.Url)
                    Me.ResultsLV.Items.Add(l)
                Next
                Me.ResultsLV.EndUpdate()
                Me.qry.Enabled = True
                Me.SearchBtn.Enabled = True
                Me.loader.Visible = False
            End If
        Catch ex As Exception
            Me.loader.Visible = False
            Me.qry.Enabled = True
            Me.SearchBtn.Enabled = True
            MessageBox.Show(caption:="Unknown Error", text:=ex.Message, buttons:=MessageBoxButtons.OK, icon:=MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        Dim item As ListViewItem = Me.ResultsLV.SelectedItems.Item(0)
        Clipboard.SetText(item.Text)
    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click
        Dim item As ListViewItem = Me.ResultsLV.SelectedItems.Item(0)
        Clipboard.SetText(item.SubItems(3).Text)
    End Sub

    Private Async Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        Dim item As ListViewItem = Me.ResultsLV.SelectedItems.Item(0)
        Dim url As String = Await SC.Tracks.GetDownloadUrlAsync(item.SubItems(3).Text)
        If Not IsEmpty(url) Then
            Me.Invoke(New Action(Sub()
                                     Dim D As New AddNewDownload(url, Me.Owner)
                                     D.Show()
                                     D.nxtbtn.PerformClick()
                                     Me.Close()
                                 End Sub))
        End If
    End Sub

    Private Sub ContextMenuStrip1_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip1.Opening
        If Me.ResultsLV.SelectedItems Is Nothing OrElse Me.ResultsLV.SelectedItems.Count = 0 Then e.Cancel = True
    End Sub
End Class