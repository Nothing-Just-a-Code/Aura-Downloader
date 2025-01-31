Imports System.Drawing.Text
Imports System.IO
Imports System.Net
Imports System.Net.Http
Imports System.Reflection
Imports System.Runtime.InteropServices
Imports Newtonsoft.Json
Public Class Extras

    Public Shared ReadOnly MainDir As String = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Aura Downloader")
    Public Shared ReadOnly LogsDir As String = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Aura Downloader", "Logs")
    Public Shared ReadOnly UpdateDir As String = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Aura Downloader", "Update")
    Public Shared ReadOnly TempDownloadsDir As String = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Aura Downloader", "Temp Downloads")
    Public Shared ReadOnly DownloadsDir As String = IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Aura Downloads")
    Public Shared Aura As AuraConfig
    Public Shared Async Function Init() As Task
        Await Task.Run(Sub()

                           'create directories
                           If Not Directory.Exists(MainDir) Then Directory.CreateDirectory(MainDir)
                           If Not Directory.Exists(LogsDir) Then Directory.CreateDirectory(LogsDir)
                           If Not Directory.Exists(UpdateDir) Then Directory.CreateDirectory(UpdateDir)
                           If Not Directory.Exists(TempDownloadsDir) Then Directory.CreateDirectory(TempDownloadsDir)
                           If Not Directory.Exists(DownloadsDir) Then Directory.CreateDirectory(DownloadsDir)
                           Dim readconf = ReadConfig()
                       End Sub)
    End Function

    Public Shared Function FormatBytes(bytes As Long) As String
        Const KB As Long = 1024
        Const MB As Long = KB * 1024
        Const GB As Long = MB * 1024
        Const TB As Long = GB * 1024

        Select Case bytes
            Case Is >= TB
                Return (bytes / TB).ToString("F2") & " TB"
            Case Is >= GB
                Return (bytes / GB).ToString("F2") & " GB"
            Case Is >= MB
                Return (bytes / MB).ToString("F2") & " MB"
            Case Is >= KB
                Return (bytes / KB).ToString("F2") & " KB"
            Case Else
                Return bytes.ToString() & " bytes"
        End Select
    End Function

    Public Shared Async Function GetDownloadFileInfo(ByVal link As String) As Task(Of DownloadFileInfo)
        Try
            Dim finalurl As String = Await CheckForRedirectAsync(link)
            Dim req As New Downloader.Request(link, New Downloader.RequestConfiguration() With {
                                          .AllowAutoRedirect = True,
                                          .KeepAlive = False,
                                          .UserAgent = Aura.UserAgent})
            Dim fname As String = Await req.GetFileName()
            Dim f As New DownloadFileInfo() With {
                .CanBeDownloadInChunks = Await req.IsSupportDownloadInRange,
                .DestinationPath = Aura.DownloadLocation,
                .Filename = fname,
                .FileSize = Await req.GetFileSize(),
                .Status = "Not started",
                .DownloadLink = req.Address}
            Dim ext As String = ""
            'First we will try to get extension from content-type
            Dim resp As WebResponse = Await req.GetRequest().GetResponseAsync()
            If Not IsEmpty(resp.ContentType) Then
                MimeKit.MimeTypes.TryGetExtension(resp.ContentType, ext)
            Else
                'second, we will try to get extension from url if possible
                ext = IO.Path.GetExtension(link)
            End If
            'final check if our extension is good or empty., If empty, we will try to get extension from filename, if possible.
            If IsEmpty(ext) Then ext = IO.Path.GetExtension(fname)
            f.Filetype = ext
            If IsEmpty(IO.Path.GetExtension(f.Filename)) Then f.Filename = $"{fname}{ext}"
            Return f
        Catch ex As Exception
            Throw New ArgumentException(ex.Message, ex)
        End Try
    End Function

    Public Shared Function IsEmpty(ByVal value As String) As Boolean
        Return String.IsNullOrEmpty(value) OrElse String.IsNullOrWhiteSpace(value)
    End Function

#Region "Config"
    Private Shared Async Function ReadConfig() As Task
        If Not File.Exists(Path.Combine(MainDir, "Aura.json")) Then Await SaveConfig()
        Dim jsn As String = Await File.ReadAllTextAsync(Path.Combine(MainDir, "Aura.json"), System.Text.Encoding.UTF8)
        Aura = JsonConvert.DeserializeObject(Of AuraConfig)(jsn)
    End Function
    Public Shared Async Function SaveConfig() As Task
        If Aura.CommonExtensions Is Nothing Then
            Aura.CommonExtensions = New List(Of String) From {
    ".txt",        ' Text files
    ".docx",       ' Microsoft Word documents
    ".xlsx",       ' Microsoft Excel documents
    ".pptx",       ' Microsoft PowerPoint presentations
    ".pdf",        ' PDF documents
    ".jpg",        ' JPEG image files
    ".jpeg",       ' JPEG image files
    ".png",        ' PNG image files
    ".gif",        ' GIF image files
    ".bmp",        ' Bitmap image files
    ".mp3",        ' MP3 audio files
    ".wav",        ' WAV audio files
    ".mp4",        ' MP4 video files
    ".avi",        ' AVI video files
    ".mkv",        ' MKV video files
    ".html",       ' HTML web pages
    ".css",        ' CSS stylesheets
    ".js",         ' JavaScript files
    ".json",       ' JSON data files
    ".xml",        ' XML files
    ".zip",        ' ZIP compressed files
    ".rar",        ' RAR compressed files
    ".7z",         ' 7z compressed files
    ".exe",        ' Executable files
    ".dll",        ' Dynamic link libraries
    ".sys",        ' System files
    ".ini",        ' Configuration files
    ".bat",        ' Batch files
    ".sh",         ' Shell scripts
    ".iso",        ' ISO image files
    ".tar",        ' TAR archive files
    ".gz",         ' GZIP compressed files
    ".flv",        ' Flash video files
    ".txt",        ' Plain text files
    ".rtf",        ' Rich Text Format files
    ".md",         ' Markdown files
    ".sqlite",      ' SQLite database files
    ".apk",        ' Android application package files
    ".ipa",        ' iOS application files
    ".dmg",        ' Disk image files (Mac)
    ".pkg",        ' Mac installation packages
    ".ttf",        ' TrueType font files
    ".otf",        ' OpenType font files
    ".mpg",        ' MPEG video files
    ".mov",        ' QuickTime video files
    ".wmv"         ' Windows Media Video files
}
        End If
        Await File.WriteAllTextAsync(Path.Combine(MainDir, "Aura.json"), JsonConvert.SerializeObject(Aura, Formatting.Indented), System.Text.Encoding.UTF8)
    End Function
#End Region

#Region "Save/Load Downloads"
    Public Shared Async Sub SaveAllDownloads()
        For Each item As ListViewItem In DownloadManager.LV.Items
            Dim jsn As String = JsonConvert.SerializeObject(CType(item.Tag, DownloadFileInfo), Formatting.Indented)
            Await IO.File.WriteAllTextAsync(Path.Combine(LogsDir, CType(item.Tag, DownloadFileInfo).Filename), jsn, System.Text.Encoding.UTF8)
        Next
    End Sub

    Public Shared Async Function ReadAllDownloads() As Task(Of List(Of ListViewItem))
        Dim files As String() = IO.Directory.GetFiles(LogsDir, "*.json")
        If files.Length = 0 Then Return Nothing
        Dim lst As New List(Of ListViewItem)()
        For Each item As String In files
            Dim l As New ListViewItem()
            Dim fi As DownloadFileInfo = JsonConvert.DeserializeObject(Of DownloadFileInfo)(Await File.ReadAllTextAsync(item))
            l.Text = fi.Filename
            l.SubItems.Add(FormatBytes(fi.FileSize))
            l.SubItems.Add(fi.DestinationPath)
            l.SubItems.Add(fi.DownloadAddedOn.ToString())
            If fi.Package IsNot Nothing Then
                If fi.Package.Status = Downloader.DownloadStatus.Completed Then
                    l.SubItems.Add("Completed")
                ElseIf fi.Package.Status = Downloader.DownloadStatus.Paused Then
                    l.SubItems.Add("Paused")
                ElseIf fi.Package.Status = Downloader.DownloadStatus.Stopped Then
                    l.SubItems.Add("Cancelled")
                Else
                    l.SubItems.Add("...")
                End If
            End If
            l.Tag = fi
            l.ImageKey = fi.Filetype
            lst.Add(l)
        Next
        Return lst
    End Function
#End Region

    Public Shared Async Function CheckForRedirectAsync(url As String) As Task(Of String)
        Try
            Using handler As New HttpClientHandler() With {.AllowAutoRedirect = False}
                Using client As New HttpClient(handler)
                    Dim currentUrl As String = url
                    Dim maxRedirects As Integer = 10 ' Prevent infinite loops
                    Dim redirectCount As Integer = 0

                    While redirectCount < maxRedirects
                        Dim response = Await client.GetAsync(currentUrl, HttpCompletionOption.ResponseHeadersRead)

                        ' If a redirect is found, update currentUrl
                        If response.StatusCode = Net.HttpStatusCode.Found OrElse
                           response.StatusCode = Net.HttpStatusCode.MovedPermanently OrElse
                           response.StatusCode = Net.HttpStatusCode.SeeOther OrElse
                           response.StatusCode = Net.HttpStatusCode.TemporaryRedirect OrElse
                           response.StatusCode = Net.HttpStatusCode.PermanentRedirect Then

                            If response.Headers.Location IsNot Nothing Then
                                currentUrl = response.Headers.Location.AbsoluteUri
                                redirectCount += 1
                            Else
                                Exit While
                            End If
                        Else
                            ' No more redirects, return the last valid URL
                            Return currentUrl
                        End If
                    End While

                    ' If max redirects reached, return last found URL
                    Return currentUrl
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
            Return Nothing
        End Try
    End Function



    Public Shared Async Function IsNewVersionAvailable() As Task(Of UpdateClass)
        Try
            Using http As New HttpClient()
                http.Timeout = TimeSpan.FromSeconds(20)
                http.DefaultRequestHeaders.CacheControl = New System.Net.Http.Headers.CacheControlHeaderValue() With {
            .NoCache = True,
            .NoStore = True
        }
                Dim httpM = Await http.GetAsync("https://raw.githubusercontent.com/Nothing-Just-a-Code/Aura-Downloader/refs/heads/main/Update/updater.json")
                httpM.EnsureSuccessStatusCode()
                Dim curver As String = $"{My.Application.Info.Version.Major}.{My.Application.Info.Version.Minor}.{My.Application.Info.Version.Build}"
                Dim jsn As String = Await httpM.Content.ReadAsStringAsync()
                Dim J As Linq.JObject = Linq.JObject.Parse(jsn)
                Dim newver As String = J("version").ToString()
                Dim C As New UpdateClass()
                If curver.Equals(newver) Then
                    C.IsNewVersion = False
                Else
                    C.NewVersion = J("version").ToString()
                    C.DownloadLink = J("download").ToString()
                    C.IsNewVersion = True
                    Dim changes As Linq.JArray = J("changes")
                    C.WhatsNew = New List(Of String)()
                    For Each item As Linq.JToken In changes
                        C.WhatsNew.Add("• " & item.ToString())
                    Next
                End If
                Return C
            End Using
        Catch ex As Exception
            Throw New ArgumentException("Having some trouble while checking for update for now. Please try again.", ex)
        End Try
    End Function


End Class
