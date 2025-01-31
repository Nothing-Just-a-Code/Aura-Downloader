<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddNewDownload
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddNewDownload))
        GroupBox1 = New GroupBox()
        nxtbtn = New Button()
        dwnlink = New TextBox()
        Label1 = New Label()
        GroupBox2 = New GroupBox()
        ficon = New PictureBox()
        fsize = New Label()
        Label7 = New Label()
        ftype = New Label()
        Label5 = New Label()
        fname = New Label()
        Label2 = New Label()
        loader = New PictureBox()
        DownBtn = New Button()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        CType(ficon, ComponentModel.ISupportInitialize).BeginInit()
        CType(loader, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(nxtbtn)
        GroupBox1.Controls.Add(dwnlink)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.ForeColor = Color.FromArgb(CByte(30), CByte(40), CByte(50))
        GroupBox1.Location = New Point(12, 12)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(478, 83)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Add New Download"
        ' 
        ' nxtbtn
        ' 
        nxtbtn.Location = New Point(415, 46)
        nxtbtn.Name = "nxtbtn"
        nxtbtn.Size = New Size(57, 23)
        nxtbtn.TabIndex = 2
        nxtbtn.Text = "Next"
        nxtbtn.UseVisualStyleBackColor = True
        ' 
        ' dwnlink
        ' 
        dwnlink.Location = New Point(16, 46)
        dwnlink.Name = "dwnlink"
        dwnlink.Size = New Size(393, 23)
        dwnlink.TabIndex = 1
        dwnlink.Text = "http://link.testfile.org/150MB"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(16, 28)
        Label1.Name = "Label1"
        Label1.Size = New Size(85, 15)
        Label1.TabIndex = 0
        Label1.Text = "Download URL"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(ficon)
        GroupBox2.Controls.Add(fsize)
        GroupBox2.Controls.Add(Label7)
        GroupBox2.Controls.Add(ftype)
        GroupBox2.Controls.Add(Label5)
        GroupBox2.Controls.Add(fname)
        GroupBox2.Controls.Add(Label2)
        GroupBox2.ForeColor = Color.FromArgb(CByte(30), CByte(40), CByte(50))
        GroupBox2.Location = New Point(12, 106)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(478, 108)
        GroupBox2.TabIndex = 1
        GroupBox2.TabStop = False
        GroupBox2.Text = "File Information"
        ' 
        ' ficon
        ' 
        ficon.Location = New Point(426, 35)
        ficon.Name = "ficon"
        ficon.Size = New Size(42, 42)
        ficon.TabIndex = 6
        ficon.TabStop = False
        ' 
        ' fsize
        ' 
        fsize.AutoSize = True
        fsize.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        fsize.Location = New Point(74, 73)
        fsize.Name = "fsize"
        fsize.Size = New Size(25, 15)
        fsize.TabIndex = 5
        fsize.Text = "n/a"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(10, 73)
        Label7.Name = "Label7"
        Label7.Size = New Size(32, 15)
        Label7.TabIndex = 4
        Label7.Text = "Size:"
        ' 
        ' ftype
        ' 
        ftype.AutoSize = True
        ftype.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ftype.Location = New Point(74, 51)
        ftype.Name = "ftype"
        ftype.Size = New Size(25, 15)
        ftype.TabIndex = 3
        ftype.Text = "n/a"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(10, 51)
        Label5.Name = "Label5"
        Label5.Size = New Size(35, 15)
        Label5.TabIndex = 2
        Label5.Text = "Type:"
        ' 
        ' fname
        ' 
        fname.AutoSize = True
        fname.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        fname.Location = New Point(74, 29)
        fname.Name = "fname"
        fname.Size = New Size(25, 15)
        fname.TabIndex = 1
        fname.Text = "n/a"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(10, 29)
        Label2.Name = "Label2"
        Label2.Size = New Size(58, 15)
        Label2.TabIndex = 0
        Label2.Text = "Filename:"
        ' 
        ' loader
        ' 
        loader.BackColor = Color.Transparent
        loader.Image = CType(resources.GetObject("loader.Image"), Image)
        loader.Location = New Point(11, 221)
        loader.Name = "loader"
        loader.Size = New Size(34, 34)
        loader.SizeMode = PictureBoxSizeMode.StretchImage
        loader.TabIndex = 0
        loader.TabStop = False
        loader.Visible = False
        ' 
        ' DownBtn
        ' 
        DownBtn.Enabled = False
        DownBtn.Image = CType(resources.GetObject("DownBtn.Image"), Image)
        DownBtn.Location = New Point(360, 228)
        DownBtn.Name = "DownBtn"
        DownBtn.Size = New Size(133, 26)
        DownBtn.TabIndex = 3
        DownBtn.Text = "Start Download"
        DownBtn.TextAlign = ContentAlignment.MiddleRight
        DownBtn.TextImageRelation = TextImageRelation.ImageBeforeText
        DownBtn.UseVisualStyleBackColor = True
        ' 
        ' AddNewDownload
        ' 
        AcceptButton = nxtbtn
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(502, 263)
        Controls.Add(loader)
        Controls.Add(DownBtn)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        DoubleBuffered = True
        ForeColor = Color.FromArgb(CByte(30), CByte(40), CByte(50))
        FormBorderStyle = FormBorderStyle.FixedSingle
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        MinimizeBox = False
        Name = "AddNewDownload"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Add New Download"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        CType(ficon, ComponentModel.ISupportInitialize).EndInit()
        CType(loader, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents dwnlink As TextBox
    Friend WithEvents nxtbtn As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents DownBtn As Button
    Friend WithEvents loader As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents fname As Label
    Friend WithEvents ftype As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents fsize As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents ficon As PictureBox
End Class
