<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FileDownloader
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FileDownloader))
        Label1 = New Label()
        GroupBox1 = New GroupBox()
        timeleft = New Label()
        Label9 = New Label()
        speed = New Label()
        Label7 = New Label()
        downloaded = New Label()
        Label5 = New Label()
        fsize = New Label()
        Label3 = New Label()
        Fname = New Label()
        cancelbtn = New Button()
        pausebtn = New Button()
        openbtn = New Button()
        stsbox = New PictureBox()
        Pbar = New ProgressBar()
        GroupBox1.SuspendLayout()
        CType(stsbox, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(7, 17)
        Label1.Name = "Label1"
        Label1.Size = New Size(58, 15)
        Label1.TabIndex = 0
        Label1.Text = "Filename:"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(timeleft)
        GroupBox1.Controls.Add(Label9)
        GroupBox1.Controls.Add(speed)
        GroupBox1.Controls.Add(Label7)
        GroupBox1.Controls.Add(downloaded)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(fsize)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Fname)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.ForeColor = Color.FromArgb(CByte(30), CByte(40), CByte(50))
        GroupBox1.Location = New Point(6, 4)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(548, 135)
        GroupBox1.TabIndex = 1
        GroupBox1.TabStop = False
        ' 
        ' timeleft
        ' 
        timeleft.AutoSize = True
        timeleft.Location = New Point(89, 105)
        timeleft.Name = "timeleft"
        timeleft.Size = New Size(25, 15)
        timeleft.TabIndex = 9
        timeleft.Text = "n/a"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(8, 106)
        Label9.Name = "Label9"
        Label9.Size = New Size(60, 15)
        Label9.TabIndex = 8
        Label9.Text = "Time Left:"
        ' 
        ' speed
        ' 
        speed.AutoSize = True
        speed.Location = New Point(89, 83)
        speed.Name = "speed"
        speed.Size = New Size(25, 15)
        speed.TabIndex = 7
        speed.Text = "n/a"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(7, 83)
        Label7.Name = "Label7"
        Label7.Size = New Size(42, 15)
        Label7.TabIndex = 6
        Label7.Text = "Speed:"
        ' 
        ' downloaded
        ' 
        downloaded.AutoSize = True
        downloaded.Location = New Point(89, 61)
        downloaded.Name = "downloaded"
        downloaded.Size = New Size(25, 15)
        downloaded.TabIndex = 5
        downloaded.Text = "n/a"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(7, 61)
        Label5.Name = "Label5"
        Label5.Size = New Size(77, 15)
        Label5.TabIndex = 4
        Label5.Text = "Downloaded:"
        ' 
        ' fsize
        ' 
        fsize.AutoSize = True
        fsize.Location = New Point(89, 39)
        fsize.Name = "fsize"
        fsize.Size = New Size(25, 15)
        fsize.TabIndex = 3
        fsize.Text = "n/a"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(7, 39)
        Label3.Name = "Label3"
        Label3.Size = New Size(51, 15)
        Label3.TabIndex = 2
        Label3.Text = "File Size:"
        ' 
        ' Fname
        ' 
        Fname.AutoSize = True
        Fname.Location = New Point(89, 17)
        Fname.Name = "Fname"
        Fname.Size = New Size(25, 15)
        Fname.TabIndex = 1
        Fname.Text = "n/a"
        ' 
        ' cancelbtn
        ' 
        cancelbtn.Enabled = False
        cancelbtn.Image = CType(resources.GetObject("cancelbtn.Image"), Image)
        cancelbtn.Location = New Point(454, 145)
        cancelbtn.Name = "cancelbtn"
        cancelbtn.Size = New Size(100, 25)
        cancelbtn.TabIndex = 3
        cancelbtn.Text = "Cancel"
        cancelbtn.TextAlign = ContentAlignment.MiddleRight
        cancelbtn.TextImageRelation = TextImageRelation.ImageBeforeText
        cancelbtn.UseVisualStyleBackColor = True
        ' 
        ' pausebtn
        ' 
        pausebtn.Enabled = False
        pausebtn.Image = CType(resources.GetObject("pausebtn.Image"), Image)
        pausebtn.Location = New Point(348, 145)
        pausebtn.Name = "pausebtn"
        pausebtn.Size = New Size(100, 25)
        pausebtn.TabIndex = 4
        pausebtn.Text = "Pause"
        pausebtn.TextAlign = ContentAlignment.MiddleRight
        pausebtn.TextImageRelation = TextImageRelation.ImageBeforeText
        pausebtn.UseVisualStyleBackColor = True
        ' 
        ' openbtn
        ' 
        openbtn.Enabled = False
        openbtn.Image = CType(resources.GetObject("openbtn.Image"), Image)
        openbtn.Location = New Point(242, 145)
        openbtn.Name = "openbtn"
        openbtn.Size = New Size(100, 25)
        openbtn.TabIndex = 5
        openbtn.Text = "Open"
        openbtn.TextAlign = ContentAlignment.MiddleRight
        openbtn.TextImageRelation = TextImageRelation.ImageBeforeText
        openbtn.UseVisualStyleBackColor = True
        ' 
        ' stsbox
        ' 
        stsbox.Image = CType(resources.GetObject("stsbox.Image"), Image)
        stsbox.Location = New Point(6, 159)
        stsbox.Name = "stsbox"
        stsbox.Size = New Size(28, 28)
        stsbox.SizeMode = PictureBoxSizeMode.StretchImage
        stsbox.TabIndex = 10
        stsbox.TabStop = False
        ' 
        ' Pbar
        ' 
        Pbar.Dock = DockStyle.Bottom
        Pbar.Location = New Point(0, 194)
        Pbar.Name = "Pbar"
        Pbar.Size = New Size(558, 15)
        Pbar.TabIndex = 11
        ' 
        ' FileDownloader
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(558, 209)
        Controls.Add(Pbar)
        Controls.Add(stsbox)
        Controls.Add(openbtn)
        Controls.Add(pausebtn)
        Controls.Add(cancelbtn)
        Controls.Add(GroupBox1)
        DoubleBuffered = True
        ForeColor = Color.FromArgb(CByte(30), CByte(40), CByte(50))
        FormBorderStyle = FormBorderStyle.FixedSingle
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        Name = "FileDownloader"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Aura Downloader"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(stsbox, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Fname As Label
    Friend WithEvents fsize As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents downloaded As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents speed As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents timeleft As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents cancelbtn As Button
    Friend WithEvents pausebtn As Button
    Friend WithEvents openbtn As Button
    Friend WithEvents stsbox As PictureBox
    Friend WithEvents Pbar As ProgressBar
End Class
