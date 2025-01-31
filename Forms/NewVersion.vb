Imports System.Net.Http
Imports System.Text
Public Class NewVersion
    Private UFile As UpdateClass

    Sub New(ByVal _uf As UpdateClass)
        InitializeComponent()
        Me.UFile = _uf
    End Sub
    Private Sub NewVersion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckForIllegalCrossThreadCalls = False
        GetInfo()
    End Sub

    Private Sub GetInfo()
        Me.Label3.Text = $"{My.Application.Info.Version.Major}.{My.Application.Info.Version.Minor}.{My.Application.Info.Version.Build}"
        Me.Label4.Text = UFile.NewVersion
        Me.TextBox1.Text = String.Join(Environment.NewLine, UFile.WhatsNew)
        Me.Button1.Enabled = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Process.Start(New ProcessStartInfo() With {.FileName = UFile.DownloadLink, .UseShellExecute = True})
    End Sub
End Class