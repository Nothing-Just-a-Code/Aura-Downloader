Imports Downloader
Imports AuraDownloader.Extras
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Public Class DownloadManager
    Private ClosingCall As Boolean = False
    Private Async Sub DownloadManager_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckForIllegalCrossThreadCalls = False
        LV.GetType().GetProperty("DoubleBuffered", Reflection.BindingFlags.NonPublic Or Reflection.BindingFlags.Instance).SetValue(LV, True, Nothing)
        Await Task.Run(Sub() AddCommonExtensionIcons())
        ReadDownloads()
        If Aura.CheckForUpdateAtStartup = True Then CheckForUpdate(False)
    End Sub

    Private Sub AddNewDownloadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddNewDownloadToolStripMenuItem.Click
        AddNewDownload.Show(Me)
    End Sub

    Private Sub AddCommonExtensionIcons()
        For Each item As String In Aura.CommonExtensions
            ImageList1.Images.Add(key:=item, FileIconHelper.GetDefaultIconByExtension(item).ToBitmap())
        Next
    End Sub

    Public Function GetIconByExtension(ByVal ext As String) As Image
        If ImageList1.Images.ContainsKey(ext) Then
            Return ImageList1.Images.Item(ext)
        Else
            Return SystemIcons.WinLogo.ToBitmap()
        End If
    End Function

    Private Sub ContextMenuStrip1_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip1.Opening
        If LV.SelectedItems Is Nothing OrElse LV.SelectedItems.Count = 0 Then
            e.Cancel = True
            Return
        End If
        Dim item As ListViewItem = Me.LV.SelectedItems.Item(0)
        Dim finfo As DownloadFileInfo = CType(item.Tag, DownloadFileInfo)
        If finfo Is Nothing Then
            MessageBox.Show(caption:="Invalid Entry", text:="This download entry seems invalid or corrupted and contains no information.", buttons:=MessageBoxButtons.OK, icon:=MessageBoxIcon.Error)
            LV.Items.Remove(item)
            e.Cancel = True
        Else
            If Not IO.File.Exists(finfo.FileFullPath) Then
                DeleteFileAndEntryCN.Enabled = False
                If Not finfo.Package.Status = DownloadStatus.Completed Then
                    CopyFileCN.Enabled = False
                    OpenFileCN.Enabled = False
                End If
            End If
            If Not IO.Directory.Exists(finfo.DestinationPath) Then OpenDirCN.Enabled = False
            If Not finfo.Package.Status = DownloadStatus.Paused Or Not finfo.Package.Status = DownloadStatus.Stopped Then ResumeDownloadCN.Enabled = False
            If Not finfo.Package.Status = DownloadStatus.Running Or Not finfo.Package.Status = DownloadStatus.Paused Then CancelDownloadCN.Enabled = False

        End If
    End Sub

    Private Sub ToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles OpenFileCN.Click
        Dim item As ListViewItem = Me.LV.SelectedItems.Item(0)
        Dim finfo As DownloadFileInfo = CType(item.Tag, DownloadFileInfo)
        If finfo Is Nothing Then
            MessageBox.Show(caption:="Invalid Entry", text:="This download entry seems invalid or corrupted and contains no information.", buttons:=MessageBoxButtons.OK, icon:=MessageBoxIcon.Error)
            DeleteEntry(item)
        Else
            Process.Start(finfo.FileFullPath)
        End If
    End Sub

    Private Sub DeleteEntry(ByVal item As ListViewItem, Optional deletefile As Boolean = False)
        Dim filepath As String = Nothing
        Dim finfo As DownloadFileInfo = TryCast(item.Tag, DownloadFileInfo)
        If deletefile = True AndAlso finfo IsNot Nothing AndAlso IO.File.Exists(finfo.FileFullPath) Then IO.File.Delete(finfo.FileFullPath)
        If IO.Directory.Exists(LogsDir) AndAlso Not IsEmpty(item.Text) Then
            filepath = IO.Directory.GetFiles(LogsDir, "*.json").FirstOrDefault(Function(x) x.Contains(IO.Path.GetFileNameWithoutExtension(item.Text)))
        End If
        If Not IsEmpty(filepath) AndAlso IO.File.Exists(filepath) Then IO.File.Delete(filepath)
        Me.LV.Items.Remove(item)
    End Sub

    Private Sub OpenDirCN_Click(sender As Object, e As EventArgs) Handles OpenDirCN.Click
        Dim item As ListViewItem = Me.LV.SelectedItems.Item(0)
        Dim finfo As DownloadFileInfo = CType(item.Tag, DownloadFileInfo)
        If finfo Is Nothing Then
            MessageBox.Show(caption:="Invalid Entry", text:="This download entry seems invalid or corrupted and contains no information.", buttons:=MessageBoxButtons.OK, icon:=MessageBoxIcon.Error)
            DeleteEntry(item)
        Else
            'If file exist then open Dir and highlight the file
            If IO.File.Exists(finfo.FileFullPath) Then
                If IO.Directory.Exists(finfo.DestinationPath) Then
                    Process.Start("explorer.exe", "/select," & finfo.FileFullPath)
                Else
                    MessageBox.Show(caption:="Directory Not Exists", text:=$"Directory {finfo.DestinationPath} does not exist.", buttons:=MessageBoxButtons.OK, icon:=MessageBoxIcon.Error)
                End If
            Else
                'if file doesnt exist, it will open the Dir only
                If IO.Directory.Exists(finfo.DestinationPath) Then
                    Process.Start("explorer.exe", finfo.DestinationPath)
                Else
                    MessageBox.Show(caption:="Directory Not Exists", text:=$"Directory {finfo.DestinationPath} does not exist.", buttons:=MessageBoxButtons.OK, icon:=MessageBoxIcon.Error)
                End If
            End If
        End If
    End Sub

    Private Sub ResumeDownloadCN_Click(sender As Object, e As EventArgs) Handles ResumeDownloadCN.Click
        Dim item As ListViewItem = Me.LV.SelectedItems.Item(0)
        Dim finfo As DownloadFileInfo = CType(item.Tag, DownloadFileInfo)
        If finfo Is Nothing Then
            MessageBox.Show(caption:="Invalid Entry", text:="This download entry seems invalid or corrupted and contains no information.", buttons:=MessageBoxButtons.OK, icon:=MessageBoxIcon.Error)
            DeleteEntry(item)
        Else
            Dim D As New FileDownloader(finfo, Me) With {.LVItem = item}
            D.Show()
            D.ResumeDownload(finfo.Package)
        End If
    End Sub

    Private Sub CancelDownloadCN_Click(sender As Object, e As EventArgs) Handles CancelDownloadCN.Click
        Dim item As ListViewItem = Me.LV.SelectedItems.Item(0)
        Dim finfo As DownloadFileInfo = CType(item.Tag, DownloadFileInfo)
        If finfo Is Nothing Then
            MessageBox.Show(caption:="Invalid Entry", text:="This download entry seems invalid or corrupted and contains no information.", buttons:=MessageBoxButtons.OK, icon:=MessageBoxIcon.Error)
            DeleteEntry(item)
        Else
            Dim F As FileDownloader = finfo.DownloaderForm
            If F IsNot Nothing OrElse Not F.IsDisposed Then
                F.CancelDownload()
            End If
        End If
    End Sub

    Private Sub DeleteEntryCN_Click(sender As Object, e As EventArgs) Handles DeleteEntryCN.Click
        Dim item As ListViewItem = Me.LV.SelectedItems.Item(0)
        Dim finfo As DownloadFileInfo = CType(item.Tag, DownloadFileInfo)
        If finfo Is Nothing Then
            MessageBox.Show(caption:="Invalid Entry", text:="This download entry seems invalid or corrupted and contains no information.", buttons:=MessageBoxButtons.OK, icon:=MessageBoxIcon.Error)
            DeleteEntry(item)
        Else
            If finfo.Package.Status = DownloadStatus.Running Then
                Dim F As FileDownloader = finfo.DownloaderForm
                If F IsNot Nothing OrElse Not F.IsDisposed Then
                    F.CancelDownload()
                End If
            End If
            DeleteEntry(item)
        End If
    End Sub

    Private Sub DeleteFileAndEntryCN_Click(sender As Object, e As EventArgs) Handles DeleteFileAndEntryCN.Click
        Dim item As ListViewItem = Me.LV.SelectedItems.Item(0)
        Dim finfo As DownloadFileInfo = CType(item.Tag, DownloadFileInfo)
        If finfo Is Nothing Then
            MessageBox.Show(caption:="Invalid Entry", text:="This download entry seems invalid or corrupted and contains no information.", buttons:=MessageBoxButtons.OK, icon:=MessageBoxIcon.Error)
            DeleteEntry(item)
        Else
            If finfo.Package.Status = DownloadStatus.Running Then
                Dim F As FileDownloader = finfo.DownloaderForm
                If F IsNot Nothing OrElse Not F.IsDisposed Then
                    F.CancelDownload()
                End If
                DeleteEntry(item)
            Else
                DeleteEntry(item, True)
            End If
        End If
    End Sub

    Private Sub SettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SettingsToolStripMenuItem.Click
        Settings.Show()
    End Sub

    Private Async Sub ReadDownloads()
        Dim lst As List(Of ListViewItem) = Await ReadAllDownloads()
        If IsNothing(lst) OrElse lst.Count = 0 Then Return
        Me.LV.Items.AddRange(lst.ToArray())
    End Sub

    Private Sub DownloadManager_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If ClosingCall = False AndAlso Aura.HideOnClose = True Then
            e.Cancel = True
            Me.Hide()
        End If
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click

    End Sub

    Private Sub ToolStripMenuItem1_DropDownOpening(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.DropDownOpening
        Dim items = Me.LV.Items.Cast(Of ListViewItem)().Where(Function(x) CType(x.Tag, DownloadFileInfo).Package.Status = DownloadStatus.Running).ToList()
        If items.Count = 0 Then StopRunningDownloadsToolStripMenuItem.Enabled = False
        If Me.LV.Items.Count = 0 Then ClearAllDownloadsToolStripMenuItem.Enabled = False
    End Sub

    Private Sub StopRunningDownloadsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StopRunningDownloadsToolStripMenuItem.Click
        Dim items = Me.LV.Items.Cast(Of ListViewItem)().Where(Function(x) CType(x.Tag, DownloadFileInfo).Package.Status = DownloadStatus.Running).ToList()
        For Each item In items
            CType(item.Tag, DownloadFileInfo).DownloaderForm.CancelDownload()
        Next
    End Sub

    Private Sub ClearAllCompletedDownloadsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearAllCompletedDownloadsToolStripMenuItem.Click
        Dim items = Me.LV.Items.Cast(Of ListViewItem)().Where(Function(x) CType(x.Tag, DownloadFileInfo).Package.Status = DownloadStatus.Completed).ToList()
        For Each item In items
            DeleteEntry(item)
        Next
    End Sub

    Private Sub ClearAllDownloadsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearAllDownloadsToolStripMenuItem.Click
        For Each item As ListViewItem In Me.LV.Items
            DeleteEntry(item)
        Next
    End Sub

    Private Sub ExitAuraDownloaderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitAuraDownloaderToolStripMenuItem.Click
        ClosingCall = True
        Application.Exit()
    End Sub

    Private Sub YoutubeEngineToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles YoutubeEngineToolStripMenuItem.Click
        YoutubeEngine.Show(Me)
    End Sub

    Private Sub SoundCloudEngineToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SoundCloudEngineToolStripMenuItem.Click
        SoundCloudEngine.Show(Me)
    End Sub

    Private Sub AboutAuraDownloadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutAuraDownloadToolStripMenuItem.Click
        Settings.Show()
        Settings.TabControl1.SelectTab(2)
    End Sub

    Private Sub CheckForUpdateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CheckForUpdateToolStripMenuItem.Click
        CheckForUpdate(True)
    End Sub

    Private Async Sub CheckForUpdate(Optional ByVal showmessage As Boolean = True)
        Dim update As UpdateClass = Await IsNewVersionAvailable()
        If update.IsNewVersion = True Then
            Dim UP As New NewVersion(update)
            UP.Show()
        Else
            If showmessage = True Then MessageBox.Show(caption:="No New Version Available", text:="There is no new version available right now. Please check again after some time", buttons:=MessageBoxButtons.OK, icon:=MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub NotifyIcon1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles NotifyIcon1.MouseDoubleClick
        If Me.Visible = False Then Me.Show()
    End Sub

    Private Sub ToolStripMenuItem4_Click_1(sender As Object, e As EventArgs) Handles ToolStripMenuItem4.Click
        Process.Start(New ProcessStartInfo() With {.FileName = "https://github.com/Nothing-Just-a-Code/Aura-Downloader", .UseShellExecute = True})
    End Sub

    Private Sub ToolStripMenuItem5_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem5.Click
        Process.Start(New ProcessStartInfo() With {.FileName = "https://buymeacoffee.com/njac", .UseShellExecute = True})
    End Sub

    Private Sub ToolStripMenuItem6_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem6.Click
        Process.Start(New ProcessStartInfo() With {.FileName = "https://github.com/Nothing-Just-a-Code/Aura-Downloader/issues/new/choose", .UseShellExecute = True})
    End Sub
End Class