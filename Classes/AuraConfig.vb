Imports Newtonsoft.Json
Public Class AuraConfig
    <JsonProperty("chunks")> Public Property Chunks As Integer = 4
    <JsonProperty("downloadpath")> Public Property DownloadLocation As String = IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Aura Downloads")
    <JsonProperty("useragent")> Public Property UserAgent As String = "Mozilla/5.0 (Windows NT 10.0; Win64; x64; rv:134.0) Gecko/20100101 Firefox/134.0"
    <JsonProperty("bufferblocksize")> Public Property BufferBlockSize As Integer = 10240
    <JsonProperty("paralleldownload")> Public Property ParallelDownload As Boolean = True
    <JsonProperty("parallelchunks")> Public Property ParallelChunks As Integer = 4
    <JsonProperty("speedlimiter")> Public Property SpeedLimiter As Boolean = False
    <JsonProperty("maxspeed")> Public Property MaximumSpeedInKB As Integer = 512
    <JsonProperty("commonextensions")> Public Property CommonExtensions As List(Of String)
    <JsonProperty("checkdisksize")> Public Property CheckDiskSizeBeforeDownload As Boolean = True
    <JsonProperty("deletefileonfailed")> Public Property ClearPackageOnCompletionWithFailure As Boolean = True
    <JsonProperty("maxmemorybuffer")> Public Property MaximumMemoryBufferByte As Long = 1 * 1024 * 1024
    <JsonProperty("MaxTryAgainOnFailover")> Public Property MaxTryAgainOnFailover As Integer = 3
    <JsonProperty("ReserveStorageSpaceBeforeStartingDownload")> Public Property ReserveStorageSpaceBeforeStartingDownload As Boolean = True
    <JsonProperty("useproxy")> Public Property UseProxy As Boolean = False
    <JsonProperty("proxy")> Public Property Proxy As System.Net.WebProxy
    <JsonProperty("runatstartup")> Public Property RunAtStartup As Boolean = True
    <JsonProperty("checkforupdateatstartup")> Public Property CheckForUpdateAtStartup As Boolean = True
    <JsonProperty("hideonclose")> Public Property HideOnClose As Boolean = True
End Class
