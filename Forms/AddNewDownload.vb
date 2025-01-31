Imports AuraDownloader.Extras
Public Class AddNewDownload
    Private FInfo As DownloadFileInfo
    Private Async Sub nxtbtn_Click(sender As Object, e As EventArgs) Handles nxtbtn.Click
        Try
            If Not IsEmpty(Me.dwnlink.Text) OrElse Uri.IsWellFormedUriString(Me.dwnlink.Text, UriKind.Absolute) Then
                nxtbtn.Enabled = False
                dwnlink.Enabled = False
                Reset()
                ShowLoader(True)
                Me.FInfo = Await GetDownloadFileInfo(Me.dwnlink.Text)
                If FInfo IsNot Nothing Then
                    Me.ficon.Image = DownloadManager.GetIconByExtension(FInfo.Filetype)
                    Me.fname.Text = FInfo.Filename
                    Me.ftype.Text = FInfo.Filetype
                    Me.fsize.Text = FormatBytes(FInfo.FileSize)
                    ShowLoader(False)
                    If DownBtn.Enabled = False Then DownBtn.Enabled = True
                    DownBtn.Focus()
                Else
                    MessageBox.Show(caption:="Error", text:="Error while fetching file information. Make sure you pasted a correct URL.", buttons:=MessageBoxButtons.OK, icon:=MessageBoxIcon.Error)
                    Reset()
                    nxtbtn.Enabled = True
                    dwnlink.Enabled = True
                    Exit Sub
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(caption:="Error", text:=ex.Message, buttons:=MessageBoxButtons.OK, icon:=MessageBoxIcon.Error)
            Reset()
            nxtbtn.Enabled = True
            dwnlink.Enabled = True
        End Try
    End Sub

    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Sub New(ByVal _downloadurl As String, ByVal _owner As Form)
        InitializeComponent()
        Me.dwnlink.Text = _downloadurl
        Me.Owner = _owner
    End Sub

    Private Sub AddNewDownload_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckForIllegalCrossThreadCalls = False
    End Sub

    Private Sub Reset()
        Me.fname.Text = "n/a"
        Me.ftype.Text = "n/a"
        Me.fsize.Text = "n/a"
        Me.ficon.Image = Nothing
        ShowLoader(False)
        If DownBtn.Enabled = True Then DownBtn.Enabled = False
    End Sub
    Private Sub ShowLoader(ByVal show As Boolean)
        loader.Visible = show
    End Sub

    Private Sub DownBtn_Click(sender As Object, e As EventArgs) Handles DownBtn.Click
        Dim D As New FileDownloader(Me.FInfo, CType(Me.Owner, DownloadManager))
        D.Show()
        D.StartDownload()
        Me.Close()
    End Sub
End Class