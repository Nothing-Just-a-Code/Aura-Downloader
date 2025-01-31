Imports YoutubeExplode
Imports YoutubeExplode.Videos.Streams

Public Class VideoInfoFetcher
    Private videoid As Videos.VideoId
    Private OForm As Form
    Private YTClient As YoutubeClient
    Private AsAudio As Boolean = True
    Private Sub VideoInfoFetcher_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckForIllegalCrossThreadCalls = False
        Dim t As Task = Task.Run(Sub() FetchInfo())
    End Sub

    Sub New(ByVal vid As Videos.VideoId, ByVal _owner As Form, ByVal _client As YoutubeClient, Optional ByVal audioonly As Boolean = False)
        InitializeComponent()
        Me.videoid = vid
        Me.OForm = _owner
        Me.AsAudio = audioonly
        Me.YTClient = _client
    End Sub

    Private Async Sub FetchInfo()
        Try
            Dim manifest = Await YTClient.Videos.Streams.GetManifestAsync(videoId:=videoid)
            If manifest IsNot Nothing Then
                If Me.AsAudio = True Then
                    'download audio only
                    Dim item As IAudioStreamInfo = manifest.GetAudioStreams().FirstOrDefault()
                    If item Is Nothing Then
                        MessageBox.Show(caption:="Error", text:="There is an error while getting video information. Please report about this on our Github Repo.", buttons:=MessageBoxButtons.OK, icon:=MessageBoxIcon.Error)
                        Me.Close()
                    Else
                        Me.Invoke(New Action(Sub()
                                                 Dim D As New AddNewDownload(item.Url, Me.OForm)
                                                 D.Show()
                                                 D.nxtbtn.PerformClick()
                                                 Me.Close()
                                             End Sub))
                    End If
                Else
                    'download video
                    Dim item As IVideoStreamInfo = manifest.GetVideoStreams().FirstOrDefault()
                    If item Is Nothing Then
                        MessageBox.Show(caption:="Error", text:="There is an error while getting video information. Please report about this on our Github Repo.", buttons:=MessageBoxButtons.OK, icon:=MessageBoxIcon.Error)
                        Me.Close()
                    Else
                        Me.Invoke(New Action(Sub()
                                                 Dim D As New AddNewDownload(item.Url, Me.OForm)
                                                 D.Show()
                                                 D.nxtbtn.PerformClick()
                                                 Me.Close()
                                             End Sub))
                    End If
                End If
            Else
                MessageBox.Show(caption:="Error", text:="There is an error while getting video information. Please report about this on our Github Repo.", buttons:=MessageBoxButtons.OK, icon:=MessageBoxIcon.Error)
                Me.Close()
            End If
        Catch ex As Exception
            MessageBox.Show(caption:="Error", text:="There is an error while getting video information. Please report about this on our Github Repo.", buttons:=MessageBoxButtons.OK, icon:=MessageBoxIcon.Error)
            Me.Close()
        End Try
    End Sub


End Class