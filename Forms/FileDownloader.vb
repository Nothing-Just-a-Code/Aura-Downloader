Imports Downloader
Imports AuraDownloader.Extras
Imports System.Threading
Imports System.ComponentModel
Imports Newtonsoft.Json
Imports Windows.Win32.System
Imports System.Runtime.InteropServices
Public Class FileDownloader
    Public WithEvents Downloadclient As DownloadService
    Private CT As New CancellationTokenSource()
    Public conf As DownloadConfiguration
    Public FInfo As DownloadFileInfo
    Private OwnerForm As DownloadManager
    Public Property LVItem As ListViewItem
    Private Sub FileDownloader_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckForIllegalCrossThreadCalls = False
    End Sub

    Sub New(ByVal _file As DownloadFileInfo, ByVal _owner As DownloadManager)

        ' This call is required by the designer.
        InitializeComponent()
        Me.FInfo = _file
        Me.OwnerForm = _owner
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Public Async Sub StartDownload()
        Try
            Me.conf = New DownloadConfiguration() With {
    .BufferBlockSize = Aura.BufferBlockSize,
    .CheckDiskSizeBeforeDownload = Aura.CheckDiskSizeBeforeDownload,
    .ChunkCount = Aura.Chunks,
    .ClearPackageOnCompletionWithFailure = Aura.ClearPackageOnCompletionWithFailure,
    .EnableLiveStreaming = False,
    .MaximumMemoryBufferBytes = Aura.MaximumMemoryBufferByte,
    .MaxTryAgainOnFailover = Aura.MaxTryAgainOnFailover,
    .MinimumSizeOfChunking = 1024,
    .ParallelCount = Aura.ParallelChunks,
    .ParallelDownload = Aura.ParallelDownload,
    .RangeDownload = False,
    .RequestConfiguration = New RequestConfiguration() With {.AllowAutoRedirect = True, .KeepAlive = True, .UserAgent = Aura.UserAgent},
    .ReserveStorageSpaceBeforeStartingDownload = Aura.ReserveStorageSpaceBeforeStartingDownload,
    .Timeout = 3000}
            If Aura.UseProxy Then
                If Aura.Proxy IsNot Nothing Then
                    Me.conf.RequestConfiguration.Proxy = Aura.Proxy
                Else
                    MessageBox.Show(text:="No proxy found. Downloading will continue without using proxy. If you want to set proxy, Please goto Settings.", caption:="No Proxy Found", buttons:=MessageBoxButtons.OK, icon:=MessageBoxIcon.Warning)
                    Aura.UseProxy = False
                End If
            End If
            If Aura.SpeedLimiter = True Then conf.MaximumBytesPerSecond = CLng(Aura.MaximumSpeedInKB * 1024)
            Me.Downloadclient = New DownloadService(Me.conf)
            FInfo.Package = Downloadclient.Package
            Await Downloadclient.DownloadFileTaskAsync(address:=FInfo.DownloadLink.ToString(), fileName:=IO.Path.Combine(FInfo.DestinationPath, FInfo.Filename))
        Catch ex2 As IO.IOException
            If ex2.Message.Contains("because it is being used by another process") Then
                Me.LVItem = GetLVItem()
                If LVItem IsNot Nothing Then
                    ResumeDownload(CType(LVItem.Tag, DownloadFileInfo).Package)
                Else
                    'error code and close form
                    MessageBox.Show(caption:="Error", text:=ex2.Message, buttons:=MessageBoxButtons.OK, icon:=MessageBoxIcon.Error)
                    Me.Close()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(caption:="Error while Downloading", text:=ex.Message, buttons:=MessageBoxButtons.OK, icon:=MessageBoxIcon.Error)
            Me.Close()
        End Try
    End Sub

    Private Async Sub Downloadclient_DownloadFileCompleted(sender As Object, e As AsyncCompletedEventArgs) Handles Downloadclient.DownloadFileCompleted
        If InvokeRequired Then
            Invoke(New AsyncCompletedEventHandler(AddressOf Downloadclient_DownloadFileCompleted), New Object() {sender, e})
            Return
        End If
        If Not e.Cancelled Then
            Me.stsbox.Visible = False
            Me.Text = "Download Completed - Aura Downloader"
            FInfo.Package = Me.Downloadclient.Package
            Await IO.File.WriteAllTextAsync(IO.Path.Combine(LogsDir, IO.Path.GetFileNameWithoutExtension(FInfo.Filename) & ".json"), JsonConvert.SerializeObject(FInfo, Formatting.Indented), System.Text.Encoding.UTF8)
            Await Me.Downloadclient.Clear()
            pausebtn.Enabled = False
            cancelbtn.Enabled = False
            openbtn.Enabled = True
            LVItem.SubItems(4).Text = "Completed"
            Me.Downloadclient.Dispose()
        Else
            FInfo.Package = Downloadclient.Package
            Await IO.File.WriteAllTextAsync(IO.Path.Combine(LogsDir, IO.Path.GetFileNameWithoutExtension(FInfo.Filename) & ".json"), JsonConvert.SerializeObject(FInfo, Formatting.Indented), System.Text.Encoding.UTF8)
            LVItem.SubItems(4).Text = "Cancelled"
            Me.Close()
        End If
    End Sub

    Public Async Sub ResumeDownload(ByVal package As DownloadPackage)
        Try
            FInfo.DownloaderForm = Me
            Me.conf = New DownloadConfiguration() With {
    .BufferBlockSize = Aura.BufferBlockSize,
    .CheckDiskSizeBeforeDownload = Aura.CheckDiskSizeBeforeDownload,
    .ChunkCount = Aura.Chunks,
    .ClearPackageOnCompletionWithFailure = Aura.ClearPackageOnCompletionWithFailure,
    .EnableLiveStreaming = False,
    .MaximumMemoryBufferBytes = Aura.MaximumMemoryBufferByte,
    .MaxTryAgainOnFailover = Aura.MaxTryAgainOnFailover,
    .MinimumSizeOfChunking = 1024,
    .ParallelCount = Aura.ParallelChunks,
    .ParallelDownload = Aura.ParallelDownload,
    .RangeDownload = False,
    .RequestConfiguration = New RequestConfiguration() With {.AllowAutoRedirect = True, .KeepAlive = True, .UserAgent = Aura.UserAgent},
    .ReserveStorageSpaceBeforeStartingDownload = Aura.ReserveStorageSpaceBeforeStartingDownload,
    .Timeout = 3000}
            If Aura.UseProxy Then
                If Aura.Proxy IsNot Nothing Then
                    Me.conf.RequestConfiguration.Proxy = Aura.Proxy
                Else
                    MessageBox.Show(text:="No proxy found. Downloading will continue without using proxy. If you want to set proxy, Please goto Settings.", caption:="No Proxy Found", buttons:=MessageBoxButtons.OK, icon:=MessageBoxIcon.Warning)
                    Aura.UseProxy = False
                End If
            End If
            Me.Downloadclient = New DownloadService(Me.conf)
            package.Validate()
            Await Downloadclient.DownloadFileTaskAsync(package:=package)
        Catch ex As Exception
            MessageBox.Show(caption:="Error while Downloading", text:=ex.Message, buttons:=MessageBoxButtons.OK, icon:=MessageBoxIcon.Error)
            Me.Close()
        End Try
    End Sub

    Private Sub Downloadclient_DownloadProgressChanged(sender As Object, e As DownloadProgressChangedEventArgs) Handles Downloadclient.DownloadProgressChanged
        If InvokeRequired Then
            Invoke(New EventHandler(Of DownloadProgressChangedEventArgs)(AddressOf Downloadclient_DownloadProgressChanged), New Object() {sender, e})
            Return
        End If
        Me.Pbar.Value = CInt(e.ProgressPercentage)
        Me.speed.Text = FormatBytes(e.BytesPerSecondSpeed)
        Me.timeleft.Text = GetEstimateTime(e.TotalBytesToReceive, e.ReceivedBytesSize, e.BytesPerSecondSpeed)
        Me.downloaded.Text = FormatBytes(e.ReceivedBytesSize)
        'Dim item As ListViewItem = GetLVItem()
        LVItem.SubItems(4).Text = $"{CInt(e.ProgressPercentage)}% Completed"
    End Sub

    Private Async Sub Downloadclient_DownloadStarted(sender As Object, e As DownloadStartedEventArgs) Handles Downloadclient.DownloadStarted
        If InvokeRequired Then
            Invoke(New EventHandler(Of DownloadStartedEventArgs)(AddressOf Downloadclient_DownloadStarted), New Object() {sender, e})
            Return
        End If
        If LVItem Is Nothing Then
            Me.LVItem = New ListViewItem() With {
.Text = FInfo.Filename}
            LVItem.SubItems.Add(FormatBytes(FInfo.FileSize))
            LVItem.SubItems.Add(FInfo.DestinationPath)
            LVItem.SubItems.Add(FInfo.DownloadAddedOn.ToString())
            LVItem.SubItems.Add("0%")
            LVItem.Tag = FInfo
            LVItem.ImageKey = IO.Path.GetExtension(e.FileName)
            Me.OwnerForm.LV.Items.Add(LVItem)
        End If
        FInfo.Package = Downloadclient.Package
        FInfo.DownloadAddedOn = DateTime.Now
        FInfo.FileFullPath = e.FileName
        FInfo.DownloaderForm = Me
        If IsEmpty(FInfo.Filetype) Then FInfo.Filetype = IO.Path.GetExtension(e.FileName)
        FInfo.CanBeDownloadInChunks = Downloadclient.Package.IsSupportDownloadInRange
        Await IO.File.WriteAllTextAsync(IO.Path.Combine(LogsDir, IO.Path.GetFileNameWithoutExtension(FInfo.Filename) & ".json"), JsonConvert.SerializeObject(FInfo, Formatting.Indented), System.Text.Encoding.UTF8)
        Me.Fname.Text = FInfo.FileFullPath
        Me.fsize.Text = FormatBytes(e.TotalBytesToReceive)
        Me.pausebtn.Enabled = FInfo.CanBeDownloadInChunks
        cancelbtn.Enabled = True
    End Sub

    Private Function GetEstimateTime(totalBytes As Long, receivedBytes As Long, bytesPerSecond As Double) As String
        If bytesPerSecond <= 0 Then Return "Calculating..."
        Dim remainingBytes As Long = totalBytes - receivedBytes
        Dim secondsRemaining As Double = remainingBytes / bytesPerSecond
        Return TimeSpan.FromSeconds(secondsRemaining).ToString("hh\:mm\:ss")
    End Function

    Private Function GetLVItem() As ListViewItem
        For Each item As ListViewItem In OwnerForm.LV.Items
            Dim inf As DownloadFileInfo = CType(item.Tag, DownloadFileInfo)
            If inf.DownloadLink = FInfo.DownloadLink AndAlso inf.Filename = FInfo.Filename Then Return item
        Next
        Return Nothing
    End Function

    Private CloseForm As Boolean = False
    Private Async Sub FileDownloader_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If Downloadclient.Status = DownloadStatus.Running Then
            If MessageBox.Show(caption:="Download is Running", text:="Download is running and if you close this, downloadinging will be paused. Do you want to close?", buttons:=MessageBoxButtons.YesNo, icon:=MessageBoxIcon.Warning) = DialogResult.No Then
                e.Cancel = True
            Else
                LVItem.SubItems(4).Text = "Closed"
                FInfo.Package = Downloadclient.Package
                Await IO.File.WriteAllTextAsync(IO.Path.Combine(LogsDir, IO.Path.GetFileNameWithoutExtension(FInfo.Filename) & ".json"), JsonConvert.SerializeObject(FInfo, Formatting.Indented), System.Text.Encoding.UTF8)
            End If
        Else
            FInfo.Package = Downloadclient.Package
            Await IO.File.WriteAllTextAsync(IO.Path.Combine(LogsDir, IO.Path.GetFileNameWithoutExtension(FInfo.Filename) & ".json"), JsonConvert.SerializeObject(FInfo, Formatting.Indented), System.Text.Encoding.UTF8)
        End If
    End Sub

    Private Sub openbtn_Click(sender As Object, e As EventArgs) Handles openbtn.Click
        If IO.File.Exists(FInfo.FileFullPath) Then Process.Start(New ProcessStartInfo() With {.FileName = FInfo.FileFullPath, .UseShellExecute = True})
        Me.Close()
    End Sub

    Private Sub Pausebtn_Click(sender As Object, e As EventArgs) Handles pausebtn.Click
        If Downloadclient.Status = DownloadStatus.Running Then
            Downloadclient.Pause()
            pausebtn.Text = "Resume"
            LVItem.SubItems(4).Text = "Paused"
            Me.stsbox.Visible = False
        ElseIf Downloadclient.IsPaused Then
            Downloadclient.Resume()
            pausebtn.Text = "Pause"
            LVItem.SubItems(4).Text = "Resuming"
            Me.stsbox.Visible = True
        End If
    End Sub

    Private Sub cancelbtn_Click(sender As Object, e As EventArgs) Handles cancelbtn.Click
        If MessageBox.Show(caption:="Cancel Downloading", text:="Do you really want to cancel the download?", buttons:=MessageBoxButtons.YesNo, icon:=MessageBoxIcon.Question) = DialogResult.Yes Then
            CancelDownload()
        End If
    End Sub

    Public Async Sub CancelDownload()
        pausebtn.Enabled = False
        cancelbtn.Enabled = False
        Me.Text = "Cancelling - Aura Downloader"
        Await Downloadclient.CancelTaskAsync()
        If IO.File.Exists(FInfo.FileFullPath) Then IO.File.Delete(Me.Fname.Text)
    End Sub
End Class