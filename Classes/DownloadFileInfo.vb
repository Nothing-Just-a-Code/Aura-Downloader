Imports Newtonsoft.Json
Public Class DownloadFileInfo
    <JsonProperty("downloadlink")> Public Property DownloadLink As Uri
    <JsonProperty("filename")> Public Property Filename As String
    <JsonProperty("size")> Public Property FileSize As Long
    <JsonProperty("destination")> Public Property DestinationPath As String
    <JsonProperty("downloadaddedon")> Public Property DownloadAddedOn As DateTime
    <JsonProperty("status")> Public Property Status As String
    <JsonProperty("filetype")> Public Property Filetype As String
    <JsonProperty("downloaded")> Public Property DownloadedBytes As Long
    <JsonProperty("isranged")> Public Property CanBeDownloadInChunks As Boolean
    <JsonProperty("package")> Public Property Package As Downloader.DownloadPackage
    <JsonProperty("fullpath")> Public Property FileFullPath As String
    <JsonIgnore> Public Property DownloaderForm As FileDownloader
End Class
