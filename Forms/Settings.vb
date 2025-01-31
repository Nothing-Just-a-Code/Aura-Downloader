Imports System.Net
Imports System.Net.Http
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports AuraDownloader.Extras
Imports Newtonsoft.Json.Linq
Public Class Settings
    Private prox As WebProxy
    Private ProxyIsSet As Boolean = True
    Private IsReady As Boolean = False
    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckForIllegalCrossThreadCalls = False
        Me.GroupBox4.Text = $"Download Options{Environment.NewLine}(Do not change if you don't know what you doing)"
        Me.Label18.Text = $"Version: {My.Application.Info.Version.Major}.{My.Application.Info.Version.Minor}.{My.Application.Info.Version.Build}"
    End Sub
    Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        ReadSettings()
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub ReadSettings()
        Try
            Me.FolderBrowserDialog1.InitialDirectory = Aura.DownloadLocation
            Me.runappwithwindowsCB.Checked = Aura.RunAtStartup
            Me.checkforupdateCB.Checked = Aura.CheckForUpdateAtStartup
            If Aura.HideOnClose = True Then hideappRB.Checked = True Else closeappRB.Checked = True
            Me.downloaddir.Text = Aura.DownloadLocation
            Me.maxchunks.Value = Aura.Chunks
            Me.bufferblocksizeDD.Text = ConvertBytes(Aura.BufferBlockSize)
            Me.paralleldownCB.Checked = Aura.ParallelDownload
            Me.maxparallelchunks.Value = Aura.ParallelChunks
            Me.DownSpeedCB.Checked = Aura.SpeedLimiter
            Me.maxspeedpersec.Text = Aura.MaximumSpeedInKB.ToString()
            Me.checkdisksizeCB.Checked = Aura.CheckDiskSizeBeforeDownload
            Me.deletefileonfailureCB.Checked = Aura.ClearPackageOnCompletionWithFailure
            Me.bufferbyteDD.Text = Me.ConvertBytes(Aura.MaximumMemoryBufferByte)
            Me.maxretryDD.Text = Aura.MaxTryAgainOnFailover
            Me.reservespeedondownloadCB.Checked = Aura.ReserveStorageSpaceBeforeStartingDownload

            Me.Panel1.Enabled = Aura.UseProxy
            Me.maxspeedpersec.Enabled = Aura.SpeedLimiter

            'proxy
            Me.useproxyCB.Checked = Aura.UseProxy
            If Aura.Proxy IsNot Nothing Then
                Dim cred As NetworkCredential = Aura.Proxy.Credentials
                If cred IsNot Nothing Then
                    If Not IsEmpty(cred.UserName) Then Me.proxyusername.Text = cred.UserName
                    If Not IsEmpty(cred.Password) Then Me.proxypassword.Text = cred.Password
                End If
            End If
            IsReady = True

        Catch ex As Exception
            MessageBox.Show(caption:="Error", text:="There is an error while reading settings. Please try again or restart application. If the problem persists, report in our GitHub Repo.", buttons:=MessageBoxButtons.OK, icon:=MessageBoxIcon.Error)
            Me.Close()
        End Try
    End Sub

    Private Function ConvertBytes(bytes As Long) As String
        If bytes >= 1024 * 1024 * 1024 Then
            Return (bytes \ (1024 * 1024 * 1024)) & " GB"
        ElseIf bytes >= 1024 * 1024 Then
            Return (bytes \ (1024 * 1024)) & " MB"
        ElseIf bytes >= 1024 Then
            Return (bytes \ 1024) & " KB"
        Else
            Return bytes & " Bytes"
        End If
    End Function

    Private Async Sub Button2_Click(sender As Object, e As EventArgs) Handles TestproxyBtn.Click
        Try
            If IsEmpty(Me.proxyip.Text) Or IsEmpty(proxyip.Text) Then
                MessageBox.Show(caption:="Missing Field", text:="Proxy address is invalid. Please make sure you using correct IP Address and Port.", buttons:=MessageBoxButtons.OK, icon:=MessageBoxIcon.Error)
                Return
            End If
            Me.prox = New WebProxy($"http://{Me.proxyip.Text}:{Me.proxyport.Text}")
            If Not IsEmpty(Me.proxyusername.Text) OrElse Not IsEmpty(Me.proxypassword.Text) Then
                Dim cred As New NetworkCredential(userName:=Me.proxyusername.Text, password:=Me.proxypassword.Text)
                Me.prox.Credentials = cred
            End If
            Using handler As New HttpClientHandler() With {.UseProxy = True, .Proxy = Me.prox}
                Using http As New HttpClient(handler)
                    http.Timeout = TimeSpan.FromSeconds(12)
                    Dim resp = Await http.GetAsync("http://ipinfo.io/json")
                    resp.EnsureSuccessStatusCode()
                    Dim str As String = Await resp.Content.ReadAsStringAsync()
                    If IsEmpty(str) Then
                        Me.proxysts.Text = "Proxy is not working or try again."
                    Else
                        Dim j As JObject = JObject.Parse(str)
                        If j.ContainsKey("ip") AndAlso Not IsEmpty(j("ip").Value(Of String)) Then
                            Me.proxysts.Text = $"IP: {j("ip").Value(Of String)}  Country: {j("country").Value(Of String)}"
                            If MessageBox.Show(text:="Connect has successfully made. Your proxy is working well. Would you like to save this proxy?", caption:="Proxy is Working", buttons:=MessageBoxButtons.YesNo, icon:=MessageBoxIcon.Information) = DialogResult.Yes Then
                                If IsReady = True Then
                                    ProxyIsSet = True
                                    Aura.Proxy = Me.prox
                                    Await SaveConfig()
                                End If
                            End If
                        End If
                    End If
                End Using
            End Using
        Catch ex1 As HttpRequestException
            Select Case ex1.HttpRequestError
                Case HttpRequestError.ProxyTunnelError
                    MessageBox.Show(text:="Failed to connect by using current proxy details.", caption:="Connection Failed", buttons:=MessageBoxButtons.OK, icon:=MessageBoxIcon.Error)
                    Exit Select
            End Select
        Catch ex As Exception
            ProxyIsSet = False
            Me.proxysts.Text = ex.Message
        End Try
    End Sub

    Private Async Sub useproxyCB_CheckedChanged(sender As Object, e As EventArgs) Handles useproxyCB.CheckedChanged
        Me.Panel1.Enabled = Me.useproxyCB.Checked
        If IsReady = True Then
            Aura.UseProxy = Me.useproxyCB.Checked
            Await Task.Delay(TimeSpan.FromMilliseconds(500))
            Await SaveConfig()
        End If
    End Sub

    Private Async Sub DownSpeedCB_CheckedChanged(sender As Object, e As EventArgs) Handles DownSpeedCB.CheckedChanged
        Me.maxspeedpersec.Enabled = DownSpeedCB.Checked
        If IsReady = True Then
            Aura.SpeedLimiter = Me.DownSpeedCB.Checked
            Aura.MaximumSpeedInKB = CInt(Me.maxspeedpersec.Text)
            Await Task.Delay(TimeSpan.FromMilliseconds(500))
            Await SaveConfig()
        End If
    End Sub

    Private Async Sub runappwithwindowsCB_CheckedChanged(sender As Object, e As EventArgs) Handles runappwithwindowsCB.CheckedChanged
        If IsReady = True Then
            Aura.RunAtStartup = runappwithwindowsCB.Checked
            Await Task.Delay(TimeSpan.FromMilliseconds(500))
            Await SaveConfig()
        End If
    End Sub

    Private Async Sub checkforupdateCB_CheckedChanged(sender As Object, e As EventArgs) Handles checkforupdateCB.CheckedChanged
        If IsReady = True Then
            Aura.CheckForUpdateAtStartup = checkforupdateCB.Checked
            Await Task.Delay(TimeSpan.FromMilliseconds(500))
            Await SaveConfig()
        End If
    End Sub

    Private Async Sub closeappRB_CheckedChanged(sender As Object, e As EventArgs) Handles closeappRB.CheckedChanged
        If IsReady = True Then
            If closeappRB.Checked = True Then
                Aura.HideOnClose = False
                Await Task.Delay(TimeSpan.FromMilliseconds(500))
                Await SaveConfig()
            End If
        End If
    End Sub

    Private Async Sub hideappRB_CheckedChanged(sender As Object, e As EventArgs) Handles hideappRB.CheckedChanged
        If hideappRB.Checked = True Then
            Aura.HideOnClose = True
            Await Task.Delay(TimeSpan.FromMilliseconds(500))
            Await SaveConfig()
        End If
    End Sub

    Private Async Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If IsReady = True Then
            If FolderBrowserDialog1.ShowDialog() = DialogResult.OK Then
                Aura.DownloadLocation = FolderBrowserDialog1.SelectedPath
                Me.downloaddir.Text = FolderBrowserDialog1.SelectedPath
                Await SaveConfig()
            End If
        End If
    End Sub

    Private Async Sub maxchunks_ValueChanged(sender As Object, e As EventArgs) Handles maxchunks.ValueChanged
        If IsReady = True Then
            Aura.Chunks = CInt(maxchunks.Value)
            Await Task.Delay(TimeSpan.FromMilliseconds(500))
            Await SaveConfig()
        End If
    End Sub

    Private Async Sub bufferblocksizeDD_SelectedIndexChanged(sender As Object, e As EventArgs) Handles bufferblocksizeDD.SelectedIndexChanged
        If IsReady = True Then
            Select Case bufferblocksizeDD.SelectedIndex
                Case 0
                    Aura.BufferBlockSize = 4 * 1024
                    Exit Select
                Case 1
                    Aura.BufferBlockSize = 8 * 1024
                    Exit Select
                Case 2
                    Aura.BufferBlockSize = 10 * 1024
                    Exit Select
                Case 3
                    Aura.BufferBlockSize = 12 * 1024
                    Exit Select
                Case 4
                    Aura.BufferBlockSize = 16 * 1024
                    Exit Select
                Case 5
                    Aura.BufferBlockSize = 20 * 1024
                    Exit Select
                Case 6
                    Aura.BufferBlockSize = 32 * 1024
                    Exit Select
            End Select
            Await Task.Delay(TimeSpan.FromMilliseconds(500))
            Await SaveConfig()
        End If
    End Sub

    Private Async Sub paralleldownCB_CheckedChanged(sender As Object, e As EventArgs) Handles paralleldownCB.CheckedChanged
        If IsReady = True Then
            Aura.ParallelDownload = paralleldownCB.Checked
            Await Task.Delay(TimeSpan.FromMilliseconds(500))
            Await SaveConfig()
        End If
    End Sub

    Private Async Sub maxparallelchunks_ValueChanged(sender As Object, e As EventArgs) Handles maxparallelchunks.ValueChanged
        If IsReady = True Then
            Aura.ParallelChunks = CInt(maxparallelchunks.Value)
            Await Task.Delay(TimeSpan.FromMilliseconds(500))
            Await SaveConfig()
        End If
    End Sub

    Private Async Sub maxspeedpersec_TextChanged(sender As Object, e As EventArgs) Handles maxspeedpersec.TextChanged
        If IsEmpty(maxspeedpersec.Text) OrElse maxspeedpersec.Text = "0" Then maxspeedpersec.Text = "512"
        If Not maxspeedpersec.Text.All(Function(c) Char.IsDigit(c)) Then
            maxspeedpersec.Text = New String(maxspeedpersec.Text.Where(Function(c) Char.IsDigit(c)).ToArray())
            maxspeedpersec.SelectionStart = maxspeedpersec.Text.Length
        End If
        If IsReady = True Then
            Aura.MaximumSpeedInKB = CInt(maxspeedpersec.Text)
            Await Task.Delay(TimeSpan.FromMilliseconds(500))
            Await SaveConfig()
        End If
    End Sub

    Private Sub maxspeedpersec_KeyPress(sender As Object, e As KeyPressEventArgs) Handles maxspeedpersec.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Async Sub checkdisksizeCB_CheckedChanged(sender As Object, e As EventArgs) Handles checkdisksizeCB.CheckedChanged
        If IsReady = True Then
            Aura.CheckDiskSizeBeforeDownload = Me.checkdisksizeCB.Checked
            Await Task.Delay(TimeSpan.FromMilliseconds(500))
            Await SaveConfig()
        End If
    End Sub

    Private Async Sub deletefileonfailureCB_CheckedChanged(sender As Object, e As EventArgs) Handles deletefileonfailureCB.CheckedChanged
        If IsReady = True Then
            Aura.ClearPackageOnCompletionWithFailure = deletefileonfailureCB.Checked
            Await Task.Delay(TimeSpan.FromMilliseconds(500))
            Await SaveConfig()
        End If
    End Sub

    Private Async Sub bufferbyteDD_SelectedIndexChanged(sender As Object, e As EventArgs) Handles bufferbyteDD.SelectedIndexChanged
        If IsReady = True Then
            Select Case bufferbyteDD.SelectedIndex
                Case 0 '1mb
                    Aura.MaximumMemoryBufferByte = 1 * 1024 * 1024
                    Exit Select
                Case 1 '4mb
                    Aura.MaximumMemoryBufferByte = 4 * 1024 * 1024
                    Exit Select
                Case 2 '10mb
                    Aura.MaximumMemoryBufferByte = 10 * 1024 * 1024 '
                    Exit Select
                Case 3 '30mb
                    Aura.MaximumMemoryBufferByte = 30 * 1024 * 1024
                    Exit Select
                Case 4 '50mb
                    Aura.MaximumMemoryBufferByte = 50 * 1024 * 1024
                    Exit Select
                Case 5 '80mb
                    Aura.MaximumMemoryBufferByte = 80 * 1024 * 1024
                    Exit Select
                Case 6 '150mb
                    Aura.MaximumMemoryBufferByte = 150 * 1024 * 1024
                    Exit Select
                Case 7 '200mb
                    Aura.MaximumMemoryBufferByte = 200 * 1024 * 1024
                    Exit Select
            End Select
            Await Task.Delay(TimeSpan.FromMilliseconds(500))
            Await SaveConfig()
        End If
    End Sub

    Private Async Sub maxretryDD_SelectedIndexChanged(sender As Object, e As EventArgs) Handles maxretryDD.SelectedIndexChanged
        If IsReady = True Then
            Aura.MaxTryAgainOnFailover = maxretryDD.Text
            Await Task.Delay(TimeSpan.FromMilliseconds(500))
            Await SaveConfig()
        End If
    End Sub

    Private Async Sub reservespeedondownloadCB_CheckedChanged(sender As Object, e As EventArgs) Handles reservespeedondownloadCB.CheckedChanged
        If IsReady = True Then
            Aura.ReserveStorageSpaceBeforeStartingDownload = reservespeedondownloadCB.Checked
            Await Task.Delay(TimeSpan.FromMilliseconds(500))
            Await SaveConfig()
        End If
    End Sub

    Private Async Sub Settings_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If ProxyIsSet = False Then
            MessageBox.Show(caption:="Proxy is Not Set", text:="The proxy has not added or probably not tested by clicking 'Test' button. Aura Downloader going to disable proxy to not interrupt your next downloads. You can save a proxy anytime.", buttons:=MessageBoxButtons.OK, icon:=MessageBoxIcon.Exclamation)
            Aura.UseProxy = False
            Await SaveConfig()
        End If
    End Sub

    Private Sub Label22_Click(sender As Object, e As EventArgs) Handles Label22.Click
        Process.Start(New ProcessStartInfo() With {.FileName = "https://github.com/bezzad/Downloader", .UseShellExecute = True})
    End Sub

    Private Sub Label24_Click(sender As Object, e As EventArgs) Handles Label24.Click
        Process.Start(New ProcessStartInfo() With {.FileName = "https://github.com/Tyrrrz/YoutubeExplode", .UseShellExecute = True})
    End Sub

    Private Sub Label25_Click(sender As Object, e As EventArgs) Handles Label25.Click
        Process.Start(New ProcessStartInfo() With {.FileName = "https://github.com/jerry08/SoundCloudExplode/", .UseShellExecute = True})
    End Sub

    Private Sub Label27_Click(sender As Object, e As EventArgs) Handles Label27.Click
        Process.Start(New ProcessStartInfo() With {.FileName = "https://icons8.com", .UseShellExecute = True})
    End Sub

    Private Sub Label29_Click(sender As Object, e As EventArgs) Handles Label29.Click
        Process.Start(New ProcessStartInfo() With {.FileName = "https://mimekit.net/", .UseShellExecute = True})
    End Sub
End Class