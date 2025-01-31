<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VideoInfoFetcher
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VideoInfoFetcher))
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        ProgressBar1 = New ProgressBar()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(12, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(48, 48)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(20), CByte(30), CByte(40))
        Label1.Location = New Point(76, 12)
        Label1.Name = "Label1"
        Label1.Size = New Size(215, 34)
        Label1.TabIndex = 1
        Label1.Text = "Please wait..." & vbCrLf & "Fetching information of the video."
        ' 
        ' ProgressBar1
        ' 
        ProgressBar1.Location = New Point(76, 57)
        ProgressBar1.Name = "ProgressBar1"
        ProgressBar1.Size = New Size(210, 5)
        ProgressBar1.Style = ProgressBarStyle.Marquee
        ProgressBar1.TabIndex = 2
        ' 
        ' VideoInfoFetcher
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(303, 74)
        Controls.Add(ProgressBar1)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        ForeColor = Color.FromArgb(CByte(20), CByte(30), CByte(40))
        FormBorderStyle = FormBorderStyle.None
        MaximizeBox = False
        MinimizeBox = False
        Name = "VideoInfoFetcher"
        ShowIcon = False
        ShowInTaskbar = False
        StartPosition = FormStartPosition.CenterScreen
        Text = "Video Info Fetcher"
        TopMost = True
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ProgressBar1 As ProgressBar
End Class
