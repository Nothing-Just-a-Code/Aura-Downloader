<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SoundCloudEngine
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SoundCloudEngine))
        ImageList1 = New ImageList(components)
        ToolStripMenuItem2 = New ToolStripMenuItem()
        ToolStripMenuItem1 = New ToolStripMenuItem()
        ContextMenuStrip1 = New ContextMenuStrip(components)
        ToolStripMenuItem3 = New ToolStripMenuItem()
        ResultsLV = New ListView()
        ColumnHeader5 = New ColumnHeader()
        ColumnHeader6 = New ColumnHeader()
        ColumnHeader7 = New ColumnHeader()
        ColumnHeader1 = New ColumnHeader()
        GroupBox2 = New GroupBox()
        loader = New PictureBox()
        SearchBtn = New Button()
        qry = New TextBox()
        Label1 = New Label()
        GroupBox1 = New GroupBox()
        ContextMenuStrip1.SuspendLayout()
        GroupBox2.SuspendLayout()
        CType(loader, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' ImageList1
        ' 
        ImageList1.ColorDepth = ColorDepth.Depth32Bit
        ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), ImageListStreamer)
        ImageList1.TransparentColor = Color.Transparent
        ImageList1.Images.SetKeyName(0, "volume-up.png")
        ' 
        ' ToolStripMenuItem2
        ' 
        ToolStripMenuItem2.BackColor = Color.White
        ToolStripMenuItem2.Image = CType(resources.GetObject("ToolStripMenuItem2.Image"), Image)
        ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        ToolStripMenuItem2.Size = New Size(180, 22)
        ToolStripMenuItem2.Text = "Copy Song Name"
        ' 
        ' ToolStripMenuItem1
        ' 
        ToolStripMenuItem1.BackColor = Color.White
        ToolStripMenuItem1.Image = CType(resources.GetObject("ToolStripMenuItem1.Image"), Image)
        ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        ToolStripMenuItem1.Size = New Size(180, 22)
        ToolStripMenuItem1.Text = "Download Song"
        ' 
        ' ContextMenuStrip1
        ' 
        ContextMenuStrip1.Items.AddRange(New ToolStripItem() {ToolStripMenuItem1, ToolStripMenuItem2, ToolStripMenuItem3})
        ContextMenuStrip1.Name = "ContextMenuStrip1"
        ContextMenuStrip1.Size = New Size(181, 92)
        ' 
        ' ToolStripMenuItem3
        ' 
        ToolStripMenuItem3.BackColor = Color.White
        ToolStripMenuItem3.Image = CType(resources.GetObject("ToolStripMenuItem3.Image"), Image)
        ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        ToolStripMenuItem3.Size = New Size(180, 22)
        ToolStripMenuItem3.Text = "Copy Song URL"
        ' 
        ' ResultsLV
        ' 
        ResultsLV.BackColor = Color.White
        ResultsLV.BorderStyle = BorderStyle.None
        ResultsLV.Columns.AddRange(New ColumnHeader() {ColumnHeader5, ColumnHeader6, ColumnHeader7, ColumnHeader1})
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
        ' ColumnHeader5
        ' 
        ColumnHeader5.Text = "Songname"
        ColumnHeader5.Width = 200
        ' 
        ' ColumnHeader6
        ' 
        ColumnHeader6.Text = "Duration"
        ColumnHeader6.TextAlign = HorizontalAlignment.Center
        ColumnHeader6.Width = 100
        ' 
        ' ColumnHeader7
        ' 
        ColumnHeader7.Text = "Author"
        ColumnHeader7.TextAlign = HorizontalAlignment.Center
        ColumnHeader7.Width = 120
        ' 
        ' ColumnHeader1
        ' 
        ColumnHeader1.Text = "Song URL"
        ColumnHeader1.Width = 250
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
        GroupBox2.TabIndex = 3
        GroupBox2.TabStop = False
        GroupBox2.Text = "Search Results"
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
        GroupBox1.TabIndex = 2
        GroupBox1.TabStop = False
        GroupBox1.Text = "Search"
        ' 
        ' SoundCloudEngine
        ' 
        AcceptButton = SearchBtn
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(800, 450)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        ForeColor = Color.FromArgb(CByte(20), CByte(30), CByte(40))
        Name = "SoundCloudEngine"
        StartPosition = FormStartPosition.CenterScreen
        Text = "SoundCloud Search Engine  -   Aura Downloader"
        ContextMenuStrip1.ResumeLayout(False)
        GroupBox2.ResumeLayout(False)
        CType(loader, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents ToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents ResultsLV As ListView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents SearchBtn As Button
    Friend WithEvents loader As PictureBox
    Friend WithEvents qry As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents ColumnHeader1 As ColumnHeader
End Class
