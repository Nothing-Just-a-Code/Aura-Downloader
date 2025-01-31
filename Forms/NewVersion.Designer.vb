<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewVersion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NewVersion))
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        Button1 = New Button()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        TextBox1 = New TextBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(5, 6)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(127, 80)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(142, 11)
        Label1.Name = "Label1"
        Label1.Size = New Size(238, 57)
        Label1.TabIndex = 2
        Label1.Text = "A new version of Aura Download is available" & vbCrLf & "Would you like to download?"
        ' 
        ' Button1
        ' 
        Button1.Dock = DockStyle.Bottom
        Button1.Enabled = False
        Button1.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.Image = CType(resources.GetObject("Button1.Image"), Image)
        Button1.Location = New Point(0, 384)
        Button1.Name = "Button1"
        Button1.Size = New Size(389, 29)
        Button1.TabIndex = 3
        Button1.Text = "Download Update"
        Button1.TextAlign = ContentAlignment.MiddleRight
        Button1.TextImageRelation = TextImageRelation.ImageBeforeText
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(142, 72)
        Label2.Name = "Label2"
        Label2.Size = New Size(75, 15)
        Label2.TabIndex = 4
        Label2.Text = "Your Version:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(230, 72)
        Label3.Name = "Label3"
        Label3.Size = New Size(16, 15)
        Label3.TabIndex = 5
        Label3.Text = "..."
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(230, 95)
        Label4.Name = "Label4"
        Label4.Size = New Size(16, 15)
        Label4.TabIndex = 7
        Label4.Text = "..."
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(142, 95)
        Label5.Name = "Label5"
        Label5.Size = New Size(82, 15)
        Label5.TabIndex = 6
        Label5.Text = "Latest Version:"
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = Color.White
        TextBox1.ForeColor = Color.FromArgb(CByte(30), CByte(40), CByte(50))
        TextBox1.Location = New Point(5, 128)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.ReadOnly = True
        TextBox1.ScrollBars = ScrollBars.Both
        TextBox1.Size = New Size(377, 250)
        TextBox1.TabIndex = 8
        ' 
        ' NewVersion
        ' 
        AcceptButton = Button1
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(389, 413)
        Controls.Add(TextBox1)
        Controls.Add(Label4)
        Controls.Add(Label5)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Button1)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        DoubleBuffered = True
        ForeColor = Color.FromArgb(CByte(30), CByte(40), CByte(50))
        FormBorderStyle = FormBorderStyle.FixedSingle
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        MinimizeBox = False
        Name = "NewVersion"
        StartPosition = FormStartPosition.CenterScreen
        Text = "New Version Available  -  Aura Downloader"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox1 As TextBox
End Class
