<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class YoutubeEngine
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
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(YoutubeEngine))
        GroupBox1 = New GroupBox()
        loader = New PictureBox()
        SearchBtn = New Button()
        qry = New TextBox()
        Label1 = New Label()
        GroupBox2 = New GroupBox()
        ResultsLV = New ListView()
        ColumnHeader1 = New ColumnHeader()
        ColumnHeader2 = New ColumnHeader()
        ColumnHeader3 = New ColumnHeader()
        ColumnHeader4 = New ColumnHeader()
        ContextMenuStrip1 = New ContextMenuStrip(components)
        ToolStripMenuItem1 = New ToolStripMenuItem()
        ToolStripMenuItem4 = New ToolStripMenuItem()
        ToolStripMenuItem2 = New ToolStripMenuItem()
        ToolStripMenuItem3 = New ToolStripMenuItem()
        ImageList1 = New ImageList(components)
        GroupBox1.SuspendLayout()
        CType(loader, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox2.SuspendLayout()
        ContextMenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        GroupBox1.Controls.Add(loader)
        GroupBox1.Controls.Add(SearchBtn)
        GroupBox1.Controls.Add(qry)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox1.ForeColor = Color.FromArgb(CByte(20), CByte(30), CByte(40))
        GroupBox1.Location = New Point(12, 12)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(776, 71)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Search"
        ' 
        ' loader
        ' 
        loader.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        loader.Image = CType(resources.GetObject("loader.Image"), Image)
        loader.Location = New Point(726, 18)
        loader.Name = "loader"
        loader.Size = New Size(42, 42)
        loader.SizeMode = PictureBoxSizeMode.StretchImage
        loader.TabIndex = 3
        loader.TabStop = False
        loader.Visible = False
        ' 
        ' SearchBtn
        ' 
        SearchBtn.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        SearchBtn.ForeColor = Color.FromArgb(CByte(20), CByte(30), CByte(40))
        SearchBtn.Location = New Point(551, 26)
        SearchBtn.Name = "SearchBtn"
        SearchBtn.Size = New Size(85, 23)
        SearchBtn.TabIndex = 2
        SearchBtn.Text = "Search"
        SearchBtn.UseVisualStyleBackColor = True
        ' 
        ' qry
        ' 
        qry.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        qry.Location = New Point(55, 27)
        qry.Name = "qry"
        qry.Size = New Size(490, 23)
        qry.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(10, 30)
        Label1.Name = "Label1"
        Label1.Size = New Size(39, 15)
        Label1.TabIndex = 0
        Label1.Text = "Query"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        GroupBox2.Controls.Add(ResultsLV)
        GroupBox2.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox2.ForeColor = Color.FromArgb(CByte(20), CByte(30), CByte(40))
        GroupBox2.Location = New Point(12, 89)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(776, 349)
        GroupBox2.TabIndex = 1
        GroupBox2.TabStop = False
        GroupBox2.Text = "Search Results"
        ' 
        ' ResultsLV
        ' 
        ResultsLV.BackColor = Color.White
        ResultsLV.BorderStyle = BorderStyle.None
        ResultsLV.Columns.AddRange(New ColumnHeader() {ColumnHeader1, ColumnHeader2, ColumnHeader3, ColumnHeader4})
        ResultsLV.ContextMenuStrip = ContextMenuStrip1
        ResultsLV.Dock = DockStyle.Fill
        ResultsLV.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ResultsLV.ForeColor = Color.FromArgb(CByte(20), CByte(30), CByte(40))
        ResultsLV.FullRowSelect = True
        ResultsLV.Location = New Point(3, 19)
        ResultsLV.Name = "ResultsLV"
        ResultsLV.Size = New Size(770, 327)
        ResultsLV.SmallImageList = ImageList1
        ResultsLV.TabIndex = 0
        ResultsLV.UseCompatibleStateImageBehavior = False
        ResultsLV.View = View.Details
        ' 
        ' ColumnHeader1
        ' 
        ColumnHeader1.Text = "Video Name"
        ColumnHeader1.Width = 200
        ' 
        ' ColumnHeader2
        ' 
        ColumnHeader2.Text = "Length"
        ColumnHeader2.TextAlign = HorizontalAlignment.Center
        ColumnHeader2.Width = 100
        ' 
        ' ColumnHeader3
        ' 
        ColumnHeader3.Text = "Channel Name"
        ColumnHeader3.TextAlign = HorizontalAlignment.Center
        ColumnHeader3.Width = 130
        ' 
        ' ColumnHeader4
        ' 
        ColumnHeader4.Text = "Video URL"
        ColumnHeader4.Width = 300
        ' 
        ' ContextMenuStrip1
        ' 
        ContextMenuStrip1.Items.AddRange(New ToolStripItem() {ToolStripMenuItem1, ToolStripMenuItem2, ToolStripMenuItem3})
        ContextMenuStrip1.Name = "ContextMenuStrip1"
        ContextMenuStrip1.Size = New Size(181, 92)
        ' 
        ' ToolStripMenuItem1
        ' 
        ToolStripMenuItem1.DropDownItems.AddRange(New ToolStripItem() {ToolStripMenuItem4})
        ToolStripMenuItem1.Image = CType(resources.GetObject("ToolStripMenuItem1.Image"), Image)
        ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        ToolStripMenuItem1.Size = New Size(180, 22)
        ToolStripMenuItem1.Text = "Download Video"
        ' 
        ' ToolStripMenuItem4
        ' 
        ToolStripMenuItem4.Image = CType(resources.GetObject("ToolStripMenuItem4.Image"), Image)
        ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        ToolStripMenuItem4.Size = New Size(184, 22)
        ToolStripMenuItem4.Text = "Dowload Audio Only"
        ' 
        ' ToolStripMenuItem2
        ' 
        ToolStripMenuItem2.Image = CType(resources.GetObject("ToolStripMenuItem2.Image"), Image)
        ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        ToolStripMenuItem2.Size = New Size(180, 22)
        ToolStripMenuItem2.Text = "Copy Video Name"
        ' 
        ' ToolStripMenuItem3
        ' 
        ToolStripMenuItem3.Image = CType(resources.GetObject("ToolStripMenuItem3.Image"), Image)
        ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        ToolStripMenuItem3.Size = New Size(180, 22)
        ToolStripMenuItem3.Text = "Copy Video URL"
        ' 
        ' ImageList1
        ' 
        ImageList1.ColorDepth = ColorDepth.Depth32Bit
        ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), ImageListStreamer)
        ImageList1.TransparentColor = Color.Transparent
        ImageList1.Images.SetKeyName(0, "play.png")
        ' 
        ' YoutubeEngine
        ' 
        AcceptButton = SearchBtn
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(800, 450)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        DoubleBuffered = True
        Name = "YoutubeEngine"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Youtube Search Engine  -   Aura Downloader"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(loader, ComponentModel.ISupportInitialize).EndInit()
        GroupBox2.ResumeLayout(False)
        ContextMenuStrip1.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents qry As TextBox
    Friend WithEvents SearchBtn As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ResultsLV As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents loader As PictureBox
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As ToolStripMenuItem
End Class
