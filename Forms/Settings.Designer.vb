<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Settings
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Settings))
        TabControl1 = New TabControl()
        TabPage1 = New TabPage()
        GroupBox2 = New GroupBox()
        hideappRB = New RadioButton()
        Label1 = New Label()
        closeappRB = New RadioButton()
        GroupBox1 = New GroupBox()
        checkforupdateCB = New CheckBox()
        runappwithwindowsCB = New CheckBox()
        TabPage2 = New TabPage()
        GroupBox5 = New GroupBox()
        useproxyCB = New CheckBox()
        Panel1 = New Panel()
        proxysts = New Label()
        TestproxyBtn = New Button()
        proxypassword = New TextBox()
        Label17 = New Label()
        proxyusername = New TextBox()
        Label16 = New Label()
        proxyport = New TextBox()
        Label15 = New Label()
        proxyip = New TextBox()
        Label14 = New Label()
        GroupBox4 = New GroupBox()
        Label13 = New Label()
        reservespeedondownloadCB = New CheckBox()
        maxretryDD = New ComboBox()
        Label12 = New Label()
        bufferbyteDD = New ComboBox()
        Label11 = New Label()
        Label10 = New Label()
        deletefileonfailureCB = New CheckBox()
        Label9 = New Label()
        checkdisksizeCB = New CheckBox()
        Label8 = New Label()
        maxspeedpersec = New TextBox()
        Label7 = New Label()
        DownSpeedCB = New CheckBox()
        maxparallelchunks = New NumericUpDown()
        Label6 = New Label()
        Label5 = New Label()
        paralleldownCB = New CheckBox()
        bufferblocksizeDD = New ComboBox()
        Label4 = New Label()
        maxchunks = New NumericUpDown()
        Label3 = New Label()
        GroupBox3 = New GroupBox()
        Button1 = New Button()
        downloaddir = New TextBox()
        Label2 = New Label()
        TabPage3 = New TabPage()
        Label29 = New Label()
        Label30 = New Label()
        Label27 = New Label()
        Label28 = New Label()
        Label25 = New Label()
        Label26 = New Label()
        Label24 = New Label()
        Label23 = New Label()
        Label22 = New Label()
        Label21 = New Label()
        Label20 = New Label()
        Label19 = New Label()
        Label18 = New Label()
        PictureBox2 = New PictureBox()
        PictureBox1 = New PictureBox()
        ImageList1 = New ImageList(components)
        FolderBrowserDialog1 = New FolderBrowserDialog()
        ToolTip1 = New ToolTip(components)
        TabControl1.SuspendLayout()
        TabPage1.SuspendLayout()
        GroupBox2.SuspendLayout()
        GroupBox1.SuspendLayout()
        TabPage2.SuspendLayout()
        GroupBox5.SuspendLayout()
        Panel1.SuspendLayout()
        GroupBox4.SuspendLayout()
        CType(maxparallelchunks, ComponentModel.ISupportInitialize).BeginInit()
        CType(maxchunks, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox3.SuspendLayout()
        TabPage3.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(TabPage1)
        TabControl1.Controls.Add(TabPage2)
        TabControl1.Controls.Add(TabPage3)
        TabControl1.Dock = DockStyle.Fill
        TabControl1.ImageList = ImageList1
        TabControl1.Location = New Point(0, 0)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(729, 426)
        TabControl1.TabIndex = 0
        ' 
        ' TabPage1
        ' 
        TabPage1.BackColor = Color.White
        TabPage1.Controls.Add(GroupBox2)
        TabPage1.Controls.Add(GroupBox1)
        TabPage1.ForeColor = Color.FromArgb(CByte(30), CByte(40), CByte(50))
        TabPage1.ImageIndex = 2
        TabPage1.Location = New Point(4, 24)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(721, 398)
        TabPage1.TabIndex = 0
        TabPage1.Text = "Application"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(hideappRB)
        GroupBox2.Controls.Add(Label1)
        GroupBox2.Controls.Add(closeappRB)
        GroupBox2.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox2.Location = New Point(11, 94)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(512, 75)
        GroupBox2.TabIndex = 3
        GroupBox2.TabStop = False
        ' 
        ' hideappRB
        ' 
        hideappRB.AutoSize = True
        hideappRB.Font = New Font("Segoe UI", 9F)
        hideappRB.Location = New Point(143, 42)
        hideappRB.Name = "hideappRB"
        hideappRB.Size = New Size(114, 19)
        hideappRB.TabIndex = 3
        hideappRB.TabStop = True
        hideappRB.Text = "Hide Application"
        hideappRB.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(6, 19)
        Label1.Name = "Label1"
        Label1.Size = New Size(497, 15)
        Label1.TabIndex = 1
        Label1.Text = "Action when you close application (Not application when you click 'Close Aura Downloader')"
        ' 
        ' closeappRB
        ' 
        closeappRB.AutoSize = True
        closeappRB.Font = New Font("Segoe UI", 9F)
        closeappRB.Location = New Point(20, 42)
        closeappRB.Name = "closeappRB"
        closeappRB.Size = New Size(118, 19)
        closeappRB.TabIndex = 2
        closeappRB.TabStop = True
        closeappRB.Text = "Close Application"
        closeappRB.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(checkforupdateCB)
        GroupBox1.Controls.Add(runappwithwindowsCB)
        GroupBox1.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox1.ForeColor = Color.FromArgb(CByte(30), CByte(40), CByte(50))
        GroupBox1.Location = New Point(11, 9)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(323, 79)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Startup"
        ' 
        ' checkforupdateCB
        ' 
        checkforupdateCB.AutoSize = True
        checkforupdateCB.Font = New Font("Segoe UI", 9F)
        checkforupdateCB.Location = New Point(10, 51)
        checkforupdateCB.Name = "checkforupdateCB"
        checkforupdateCB.Size = New Size(242, 19)
        checkforupdateCB.TabIndex = 1
        checkforupdateCB.Text = "Check for update when application starts"
        checkforupdateCB.UseVisualStyleBackColor = True
        ' 
        ' runappwithwindowsCB
        ' 
        runappwithwindowsCB.AutoSize = True
        runappwithwindowsCB.Font = New Font("Segoe UI", 9F)
        runappwithwindowsCB.Location = New Point(10, 26)
        runappwithwindowsCB.Name = "runappwithwindowsCB"
        runappwithwindowsCB.Size = New Size(287, 19)
        runappwithwindowsCB.TabIndex = 0
        runappwithwindowsCB.Text = "Run Aura Downloader when your computer starts"
        runappwithwindowsCB.UseVisualStyleBackColor = True
        ' 
        ' TabPage2
        ' 
        TabPage2.AutoScroll = True
        TabPage2.BackColor = Color.White
        TabPage2.Controls.Add(GroupBox5)
        TabPage2.Controls.Add(GroupBox4)
        TabPage2.Controls.Add(GroupBox3)
        TabPage2.ImageIndex = 0
        TabPage2.Location = New Point(4, 24)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3)
        TabPage2.Size = New Size(721, 398)
        TabPage2.TabIndex = 1
        TabPage2.Text = "Downloads"
        ' 
        ' GroupBox5
        ' 
        GroupBox5.Controls.Add(useproxyCB)
        GroupBox5.Controls.Add(Panel1)
        GroupBox5.Location = New Point(11, 574)
        GroupBox5.Name = "GroupBox5"
        GroupBox5.Size = New Size(470, 173)
        GroupBox5.TabIndex = 5
        GroupBox5.TabStop = False
        GroupBox5.Text = "Proxy"
        ' 
        ' useproxyCB
        ' 
        useproxyCB.AutoSize = True
        useproxyCB.Location = New Point(10, 30)
        useproxyCB.Name = "useproxyCB"
        useproxyCB.Size = New Size(61, 19)
        useproxyCB.TabIndex = 1
        useproxyCB.Text = "Enable"
        useproxyCB.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(proxysts)
        Panel1.Controls.Add(TestproxyBtn)
        Panel1.Controls.Add(proxypassword)
        Panel1.Controls.Add(Label17)
        Panel1.Controls.Add(proxyusername)
        Panel1.Controls.Add(Label16)
        Panel1.Controls.Add(proxyport)
        Panel1.Controls.Add(Label15)
        Panel1.Controls.Add(proxyip)
        Panel1.Controls.Add(Label14)
        Panel1.Dock = DockStyle.Bottom
        Panel1.Location = New Point(3, 60)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(464, 110)
        Panel1.TabIndex = 0
        ' 
        ' proxysts
        ' 
        proxysts.AutoEllipsis = True
        proxysts.ImageAlign = ContentAlignment.MiddleLeft
        proxysts.Location = New Point(5, 89)
        proxysts.Name = "proxysts"
        proxysts.Size = New Size(315, 15)
        proxysts.TabIndex = 9
        proxysts.Text = "Idle"
        ' 
        ' TestproxyBtn
        ' 
        TestproxyBtn.Location = New Point(383, 80)
        TestproxyBtn.Name = "TestproxyBtn"
        TestproxyBtn.Size = New Size(75, 23)
        TestproxyBtn.TabIndex = 8
        TestproxyBtn.Text = "Test"
        TestproxyBtn.UseVisualStyleBackColor = True
        ' 
        ' proxypassword
        ' 
        proxypassword.Location = New Point(307, 47)
        proxypassword.Name = "proxypassword"
        proxypassword.Size = New Size(151, 23)
        proxypassword.TabIndex = 7
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.ForeColor = Color.FromArgb(CByte(30), CByte(40), CByte(50))
        Label17.Location = New Point(241, 50)
        Label17.Name = "Label17"
        Label17.Size = New Size(60, 15)
        Label17.TabIndex = 6
        Label17.Text = "Password:"
        ' 
        ' proxyusername
        ' 
        proxyusername.Location = New Point(76, 47)
        proxyusername.Name = "proxyusername"
        proxyusername.Size = New Size(151, 23)
        proxyusername.TabIndex = 5
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.ForeColor = Color.FromArgb(CByte(30), CByte(40), CByte(50))
        Label16.Location = New Point(7, 50)
        Label16.Name = "Label16"
        Label16.Size = New Size(63, 15)
        Label16.TabIndex = 4
        Label16.Text = "Username:"
        ' 
        ' proxyport
        ' 
        proxyport.Location = New Point(283, 6)
        proxyport.Name = "proxyport"
        proxyport.Size = New Size(81, 23)
        proxyport.TabIndex = 3
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.ForeColor = Color.FromArgb(CByte(30), CByte(40), CByte(50))
        Label15.Location = New Point(245, 9)
        Label15.Name = "Label15"
        Label15.Size = New Size(32, 15)
        Label15.TabIndex = 2
        Label15.Text = "Port:"
        ' 
        ' proxyip
        ' 
        proxyip.Location = New Point(75, 6)
        proxyip.Name = "proxyip"
        proxyip.Size = New Size(151, 23)
        proxyip.TabIndex = 1
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.ForeColor = Color.FromArgb(CByte(30), CByte(40), CByte(50))
        Label14.Location = New Point(7, 9)
        Label14.Name = "Label14"
        Label14.Size = New Size(62, 15)
        Label14.TabIndex = 0
        Label14.Text = "IP Address"
        ' 
        ' GroupBox4
        ' 
        GroupBox4.Controls.Add(Label13)
        GroupBox4.Controls.Add(reservespeedondownloadCB)
        GroupBox4.Controls.Add(maxretryDD)
        GroupBox4.Controls.Add(Label12)
        GroupBox4.Controls.Add(bufferbyteDD)
        GroupBox4.Controls.Add(Label11)
        GroupBox4.Controls.Add(Label10)
        GroupBox4.Controls.Add(deletefileonfailureCB)
        GroupBox4.Controls.Add(Label9)
        GroupBox4.Controls.Add(checkdisksizeCB)
        GroupBox4.Controls.Add(Label8)
        GroupBox4.Controls.Add(maxspeedpersec)
        GroupBox4.Controls.Add(Label7)
        GroupBox4.Controls.Add(DownSpeedCB)
        GroupBox4.Controls.Add(maxparallelchunks)
        GroupBox4.Controls.Add(Label6)
        GroupBox4.Controls.Add(Label5)
        GroupBox4.Controls.Add(paralleldownCB)
        GroupBox4.Controls.Add(bufferblocksizeDD)
        GroupBox4.Controls.Add(Label4)
        GroupBox4.Controls.Add(maxchunks)
        GroupBox4.Controls.Add(Label3)
        GroupBox4.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox4.ForeColor = Color.FromArgb(CByte(30), CByte(40), CByte(50))
        GroupBox4.Location = New Point(11, 105)
        GroupBox4.Name = "GroupBox4"
        GroupBox4.Size = New Size(349, 450)
        GroupBox4.TabIndex = 4
        GroupBox4.TabStop = False
        GroupBox4.Text = "Download Options (Do not change if you don't know what you doing)"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Segoe UI", 9F)
        Label13.Location = New Point(10, 412)
        Label13.Name = "Label13"
        Label13.Size = New Size(219, 15)
        Label13.TabIndex = 20
        Label13.Text = "Reserve Space Before Starting Download"
        ToolTip1.SetToolTip(Label13, "Aura Downloader will always check your disk and make sure your disk have enough size to download the file" & vbCrLf & "before starting download file task.")
        ' 
        ' reservespeedondownloadCB
        ' 
        reservespeedondownloadCB.AutoSize = True
        reservespeedondownloadCB.Location = New Point(276, 411)
        reservespeedondownloadCB.Name = "reservespeedondownloadCB"
        reservespeedondownloadCB.Size = New Size(61, 19)
        reservespeedondownloadCB.TabIndex = 19
        reservespeedondownloadCB.Text = "Enable"
        ToolTip1.SetToolTip(reservespeedondownloadCB, "Aura Downloader will always check your disk and make sure your disk have enough size to download the file" & vbCrLf & "before starting download file task.")
        reservespeedondownloadCB.UseVisualStyleBackColor = True
        ' 
        ' maxretryDD
        ' 
        maxretryDD.DropDownStyle = ComboBoxStyle.DropDownList
        maxretryDD.Font = New Font("Segoe UI", 9F)
        maxretryDD.ForeColor = Color.FromArgb(CByte(30), CByte(40), CByte(50))
        maxretryDD.FormattingEnabled = True
        maxretryDD.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6"})
        maxretryDD.Location = New Point(257, 374)
        maxretryDD.Name = "maxretryDD"
        maxretryDD.Size = New Size(80, 23)
        maxretryDD.TabIndex = 18
        ToolTip1.SetToolTip(maxretryDD, "If download failed, Aura Downloader will keep trying to download the file at the number of times set by user.")
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Segoe UI", 9F)
        Label12.Location = New Point(10, 377)
        Label12.Name = "Label12"
        Label12.Size = New Size(145, 15)
        Label12.TabIndex = 17
        Label12.Text = "Max Try On Download Fail"
        ToolTip1.SetToolTip(Label12, "If download failed, Aura Downloader will keep trying to download the file at the number of times set by user.")
        ' 
        ' bufferbyteDD
        ' 
        bufferbyteDD.DropDownStyle = ComboBoxStyle.DropDownList
        bufferbyteDD.Font = New Font("Segoe UI", 9F)
        bufferbyteDD.ForeColor = Color.FromArgb(CByte(30), CByte(40), CByte(50))
        bufferbyteDD.FormattingEnabled = True
        bufferbyteDD.Items.AddRange(New Object() {"1 MB", "4 MB", "10 MB", "30 MB", "50 MB", "80 MB", "150 MB", "200 MB"})
        bufferbyteDD.Location = New Point(257, 337)
        bufferbyteDD.Name = "bufferbyteDD"
        bufferbyteDD.Size = New Size(80, 23)
        bufferbyteDD.TabIndex = 16
        ToolTip1.SetToolTip(bufferbyteDD, resources.GetString("bufferbyteDD.ToolTip"))
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI", 9F)
        Label11.Location = New Point(10, 340)
        Label11.Name = "Label11"
        Label11.Size = New Size(167, 15)
        Label11.TabIndex = 15
        Label11.Text = "Maximum Memory BufferByte"
        ToolTip1.SetToolTip(Label11, resources.GetString("Label11.ToolTip"))
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 9F)
        Label10.Location = New Point(10, 305)
        Label10.Name = "Label10"
        Label10.Size = New Size(184, 15)
        Label10.TabIndex = 14
        Label10.Text = "Delete File when Download Failed"
        ToolTip1.SetToolTip(Label10, "Aura Downloader will always check your disk and make sure your disk have enough size to download the file" & vbCrLf & "before starting download file task.")
        ' 
        ' deletefileonfailureCB
        ' 
        deletefileonfailureCB.AutoSize = True
        deletefileonfailureCB.Location = New Point(276, 304)
        deletefileonfailureCB.Name = "deletefileonfailureCB"
        deletefileonfailureCB.Size = New Size(61, 19)
        deletefileonfailureCB.TabIndex = 13
        deletefileonfailureCB.Text = "Enable"
        ToolTip1.SetToolTip(deletefileonfailureCB, "Aura Downloader will always check your disk and make sure your disk have enough size to download the file" & vbCrLf & "before starting download file task.")
        deletefileonfailureCB.UseVisualStyleBackColor = True
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 9F)
        Label9.Location = New Point(10, 272)
        Label9.Name = "Label9"
        Label9.Size = New Size(179, 15)
        Label9.TabIndex = 12
        Label9.Text = "Check DiskSize Before Download"
        ToolTip1.SetToolTip(Label9, "Aura Downloader will always check your disk and make sure your disk have enough size to download the file" & vbCrLf & "before starting download file task.")
        ' 
        ' checkdisksizeCB
        ' 
        checkdisksizeCB.AutoSize = True
        checkdisksizeCB.Location = New Point(276, 271)
        checkdisksizeCB.Name = "checkdisksizeCB"
        checkdisksizeCB.Size = New Size(61, 19)
        checkdisksizeCB.TabIndex = 11
        checkdisksizeCB.Text = "Enable"
        ToolTip1.SetToolTip(checkdisksizeCB, "Aura Downloader will always check your disk and make sure your disk have enough size to download the file" & vbCrLf & "before starting download file task.")
        checkdisksizeCB.UseVisualStyleBackColor = True
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 9F)
        Label8.Location = New Point(10, 237)
        Label8.Name = "Label8"
        Label8.Size = New Size(166, 15)
        Label8.TabIndex = 10
        Label8.Text = "Max. Speed per second (in KB)"
        ToolTip1.SetToolTip(Label8, "Set the maximum limit of download speed each download task can use." & vbCrLf & "Better for Low-Speed network otherwise keep it Disabled.")
        ' 
        ' maxspeedpersec
        ' 
        maxspeedpersec.Location = New Point(250, 234)
        maxspeedpersec.Name = "maxspeedpersec"
        maxspeedpersec.Size = New Size(87, 23)
        maxspeedpersec.TabIndex = 5
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 9F)
        Label7.Location = New Point(10, 210)
        Label7.Name = "Label7"
        Label7.Size = New Size(126, 15)
        Label7.TabIndex = 9
        Label7.Text = "Download Speed Limit"
        ToolTip1.SetToolTip(Label7, "Set the maximum limit of download speed each download task can use." & vbCrLf & "Better for Low-Speed network otherwise keep it Disabled.")
        ' 
        ' DownSpeedCB
        ' 
        DownSpeedCB.AutoSize = True
        DownSpeedCB.Location = New Point(276, 209)
        DownSpeedCB.Name = "DownSpeedCB"
        DownSpeedCB.Size = New Size(61, 19)
        DownSpeedCB.TabIndex = 8
        DownSpeedCB.Text = "Enable"
        ToolTip1.SetToolTip(DownSpeedCB, "Set the maximum limit of download speed each download task can use." & vbCrLf & "Better for Low-Speed network otherwise keep it Disabled.")
        DownSpeedCB.UseVisualStyleBackColor = True
        ' 
        ' maxparallelchunks
        ' 
        maxparallelchunks.BorderStyle = BorderStyle.FixedSingle
        maxparallelchunks.Font = New Font("Segoe UI", 9F)
        maxparallelchunks.ForeColor = Color.FromArgb(CByte(30), CByte(40), CByte(50))
        maxparallelchunks.Location = New Point(268, 172)
        maxparallelchunks.Maximum = New Decimal(New Integer() {16, 0, 0, 0})
        maxparallelchunks.Minimum = New Decimal(New Integer() {2, 0, 0, 0})
        maxparallelchunks.Name = "maxparallelchunks"
        maxparallelchunks.Size = New Size(69, 23)
        maxparallelchunks.TabIndex = 7
        maxparallelchunks.TextAlign = HorizontalAlignment.Center
        ToolTip1.SetToolTip(maxparallelchunks, resources.GetString("maxparallelchunks.ToolTip"))
        maxparallelchunks.Value = New Decimal(New Integer() {2, 0, 0, 0})
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 9F)
        Label6.Location = New Point(10, 174)
        Label6.Name = "Label6"
        Label6.Size = New Size(88, 15)
        Label6.TabIndex = 6
        Label6.Text = "Parallel Chunks"
        ToolTip1.SetToolTip(Label6, resources.GetString("Label6.ToolTip"))
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 9F)
        Label5.Location = New Point(10, 139)
        Label5.Name = "Label5"
        Label5.Size = New Size(102, 15)
        Label5.TabIndex = 5
        Label5.Text = "Parallel Download"
        ToolTip1.SetToolTip(Label5, "Parallel Download is the process of downloading multiple parts of a file simultaneously to speed up the overall download time.")
        ' 
        ' paralleldownCB
        ' 
        paralleldownCB.AutoSize = True
        paralleldownCB.Location = New Point(276, 138)
        paralleldownCB.Name = "paralleldownCB"
        paralleldownCB.Size = New Size(61, 19)
        paralleldownCB.TabIndex = 4
        paralleldownCB.Text = "Enable"
        ToolTip1.SetToolTip(paralleldownCB, "Parallel Download is the process of downloading multiple parts of a file simultaneously to speed up the overall download time.")
        paralleldownCB.UseVisualStyleBackColor = True
        ' 
        ' bufferblocksizeDD
        ' 
        bufferblocksizeDD.DropDownStyle = ComboBoxStyle.DropDownList
        bufferblocksizeDD.Font = New Font("Segoe UI", 9F)
        bufferblocksizeDD.ForeColor = Color.FromArgb(CByte(30), CByte(40), CByte(50))
        bufferblocksizeDD.FormattingEnabled = True
        bufferblocksizeDD.Items.AddRange(New Object() {"4 KB", "8 KB", "10 KB", "12 KB", "16 KB", "20 KB", "32 KB"})
        bufferblocksizeDD.Location = New Point(257, 101)
        bufferblocksizeDD.Name = "bufferblocksizeDD"
        bufferblocksizeDD.Size = New Size(80, 23)
        bufferblocksizeDD.TabIndex = 3
        ToolTip1.SetToolTip(bufferblocksizeDD, "BufferBlockSize is the size (in bytes) of each chunk of data read and written during the download process." & vbCrLf & "Higher BufferBlockSize can increase download speed but consume more memory.")
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 9F)
        Label4.Location = New Point(10, 104)
        Label4.Name = "Label4"
        Label4.Size = New Size(94, 15)
        Label4.TabIndex = 2
        Label4.Text = "Buffer Block Size"
        ToolTip1.SetToolTip(Label4, "BufferBlockSize is the size (in bytes) of each chunk of data read and written during the download process." & vbCrLf & "Higher BufferBlockSize can increase download speed but consume more memory.")
        ' 
        ' maxchunks
        ' 
        maxchunks.BorderStyle = BorderStyle.FixedSingle
        maxchunks.Font = New Font("Segoe UI", 9F)
        maxchunks.ForeColor = Color.FromArgb(CByte(30), CByte(40), CByte(50))
        maxchunks.Location = New Point(268, 64)
        maxchunks.Maximum = New Decimal(New Integer() {16, 0, 0, 0})
        maxchunks.Minimum = New Decimal(New Integer() {2, 0, 0, 0})
        maxchunks.Name = "maxchunks"
        maxchunks.Size = New Size(69, 23)
        maxchunks.TabIndex = 1
        maxchunks.TextAlign = HorizontalAlignment.Center
        ToolTip1.SetToolTip(maxchunks, resources.GetString("maxchunks.ToolTip"))
        maxchunks.Value = New Decimal(New Integer() {2, 0, 0, 0})
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9F)
        Label3.Location = New Point(10, 66)
        Label3.Name = "Label3"
        Label3.Size = New Size(47, 15)
        Label3.TabIndex = 0
        Label3.Text = "Chunks"
        ToolTip1.SetToolTip(Label3, resources.GetString("Label3.ToolTip"))
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(Button1)
        GroupBox3.Controls.Add(downloaddir)
        GroupBox3.Controls.Add(Label2)
        GroupBox3.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox3.ForeColor = Color.FromArgb(CByte(30), CByte(40), CByte(50))
        GroupBox3.Location = New Point(11, 9)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(398, 85)
        GroupBox3.TabIndex = 1
        GroupBox3.TabStop = False
        GroupBox3.Text = "Download Location"
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI", 9F)
        Button1.Location = New Point(312, 53)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 2
        Button1.Text = "Change"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' downloaddir
        ' 
        downloaddir.BackColor = Color.White
        downloaddir.Font = New Font("Segoe UI", 9F)
        downloaddir.ForeColor = Color.FromArgb(CByte(30), CByte(40), CByte(50))
        downloaddir.Location = New Point(72, 24)
        downloaddir.Name = "downloaddir"
        downloaddir.ReadOnly = True
        downloaddir.Size = New Size(315, 23)
        downloaddir.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9F)
        Label2.ForeColor = Color.FromArgb(CByte(30), CByte(40), CByte(50))
        Label2.Location = New Point(10, 27)
        Label2.Name = "Label2"
        Label2.Size = New Size(55, 15)
        Label2.TabIndex = 2
        Label2.Text = "Directory"
        ' 
        ' TabPage3
        ' 
        TabPage3.BackColor = Color.White
        TabPage3.Controls.Add(Label29)
        TabPage3.Controls.Add(Label30)
        TabPage3.Controls.Add(Label27)
        TabPage3.Controls.Add(Label28)
        TabPage3.Controls.Add(Label25)
        TabPage3.Controls.Add(Label26)
        TabPage3.Controls.Add(Label24)
        TabPage3.Controls.Add(Label23)
        TabPage3.Controls.Add(Label22)
        TabPage3.Controls.Add(Label21)
        TabPage3.Controls.Add(Label20)
        TabPage3.Controls.Add(Label19)
        TabPage3.Controls.Add(Label18)
        TabPage3.Controls.Add(PictureBox2)
        TabPage3.Controls.Add(PictureBox1)
        TabPage3.ImageIndex = 1
        TabPage3.Location = New Point(4, 24)
        TabPage3.Name = "TabPage3"
        TabPage3.Padding = New Padding(3)
        TabPage3.Size = New Size(721, 398)
        TabPage3.TabIndex = 2
        TabPage3.Text = "About"
        ' 
        ' Label29
        ' 
        Label29.AutoSize = True
        Label29.Cursor = Cursors.Hand
        Label29.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label29.Location = New Point(233, 341)
        Label29.Name = "Label29"
        Label29.Size = New Size(52, 15)
        Label29.TabIndex = 14
        Label29.Text = "MimeKit"
        ' 
        ' Label30
        ' 
        Label30.AutoSize = True
        Label30.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label30.Location = New Point(9, 341)
        Label30.Name = "Label30"
        Label30.Size = New Size(116, 15)
        Label30.TabIndex = 13
        Label30.Text = "Lib to get Extensions"
        ' 
        ' Label27
        ' 
        Label27.AutoSize = True
        Label27.Cursor = Cursors.Hand
        Label27.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label27.Location = New Point(233, 312)
        Label27.Name = "Label27"
        Label27.Size = New Size(109, 15)
        Label27.TabIndex = 12
        Label27.Text = "https://icons8.com"
        ' 
        ' Label28
        ' 
        Label28.AutoSize = True
        Label28.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label28.Location = New Point(9, 312)
        Label28.Name = "Label28"
        Label28.Size = New Size(36, 15)
        Label28.TabIndex = 11
        Label28.Text = "Icons"
        ' 
        ' Label25
        ' 
        Label25.AutoSize = True
        Label25.Cursor = Cursors.Hand
        Label25.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label25.Location = New Point(233, 284)
        Label25.Name = "Label25"
        Label25.Size = New Size(115, 15)
        Label25.TabIndex = 10
        Label25.Text = "SoundCloudExplode"
        ' 
        ' Label26
        ' 
        Label26.AutoSize = True
        Label26.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label26.Location = New Point(9, 284)
        Label26.Name = "Label26"
        Label26.Size = New Size(131, 15)
        Label26.TabIndex = 9
        Label26.Text = "SoundCloud Search Lib"
        ' 
        ' Label24
        ' 
        Label24.AutoSize = True
        Label24.Cursor = Cursors.Hand
        Label24.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label24.Location = New Point(233, 257)
        Label24.Name = "Label24"
        Label24.Size = New Size(93, 15)
        Label24.TabIndex = 8
        Label24.Text = "YoutubeExplode"
        ' 
        ' Label23
        ' 
        Label23.AutoSize = True
        Label23.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label23.Location = New Point(9, 257)
        Label23.Name = "Label23"
        Label23.Size = New Size(109, 15)
        Label23.TabIndex = 7
        Label23.Text = "Youtube Search Lib"
        ' 
        ' Label22
        ' 
        Label22.AutoSize = True
        Label22.Cursor = Cursors.Hand
        Label22.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label22.Location = New Point(233, 230)
        Label22.Name = "Label22"
        Label22.Size = New Size(72, 15)
        Label22.TabIndex = 6
        Label22.Text = "Downloader"
        ' 
        ' Label21
        ' 
        Label21.AutoSize = True
        Label21.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label21.Location = New Point(9, 230)
        Label21.Name = "Label21"
        Label21.Size = New Size(102, 15)
        Label21.TabIndex = 5
        Label21.Text = "File Download Lib"
        ' 
        ' Label20
        ' 
        Label20.AutoSize = True
        Label20.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold)
        Label20.Location = New Point(9, 193)
        Label20.Name = "Label20"
        Label20.Size = New Size(53, 19)
        Label20.TabIndex = 4
        Label20.Text = "Credits"
        ' 
        ' Label19
        ' 
        Label19.Location = New Point(9, 95)
        Label19.Name = "Label19"
        Label19.Size = New Size(704, 68)
        Label19.TabIndex = 3
        Label19.Text = resources.GetString("Label19.Text")
        ' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label18.Location = New Point(65, 64)
        Label18.Name = "Label18"
        Label18.Size = New Size(77, 15)
        Label18.TabIndex = 2
        Label18.Text = "Version: 1.0.0"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(9, 11)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(50, 50)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 1
        PictureBox2.TabStop = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(65, 11)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(200, 50)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' ImageList1
        ' 
        ImageList1.ColorDepth = ColorDepth.Depth32Bit
        ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), ImageListStreamer)
        ImageList1.TransparentColor = Color.Transparent
        ImageList1.Images.SetKeyName(0, "icons8-downloading-updates-48(1).png")
        ImageList1.Images.SetKeyName(1, "icons8-about-48(3).png")
        ImageList1.Images.SetKeyName(2, "icons8-application-window-48.png")
        ' 
        ' FolderBrowserDialog1
        ' 
        FolderBrowserDialog1.Description = "Select a Folder for your Download Location"
        FolderBrowserDialog1.UseDescriptionForTitle = True
        ' 
        ' ToolTip1
        ' 
        ToolTip1.BackColor = Color.White
        ToolTip1.ForeColor = Color.FromArgb(CByte(30), CByte(40), CByte(50))
        ' 
        ' Settings
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(729, 426)
        Controls.Add(TabControl1)
        DoubleBuffered = True
        ForeColor = Color.FromArgb(CByte(30), CByte(40), CByte(50))
        FormBorderStyle = FormBorderStyle.FixedSingle
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        Name = "Settings"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Settings   -   Aura Downloader"
        TabControl1.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        TabPage2.ResumeLayout(False)
        GroupBox5.ResumeLayout(False)
        GroupBox5.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        GroupBox4.ResumeLayout(False)
        GroupBox4.PerformLayout()
        CType(maxparallelchunks, ComponentModel.ISupportInitialize).EndInit()
        CType(maxchunks, ComponentModel.ISupportInitialize).EndInit()
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        TabPage3.ResumeLayout(False)
        TabPage3.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents runappwithwindowsCB As CheckBox
    Friend WithEvents checkforupdateCB As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents closeappRB As RadioButton
    Friend WithEvents hideappRB As RadioButton
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents downloaddir As TextBox
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents maxchunks As NumericUpDown
    Friend WithEvents Label4 As Label
    Friend WithEvents bufferblocksizeDD As ComboBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents paralleldownCB As CheckBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents maxparallelchunks As NumericUpDown
    Friend WithEvents Label7 As Label
    Friend WithEvents DownSpeedCB As CheckBox
    Friend WithEvents maxspeedpersec As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents checkdisksizeCB As CheckBox
    Friend WithEvents Label10 As Label
    Friend WithEvents deletefileonfailureCB As CheckBox
    Friend WithEvents bufferbyteDD As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents maxretryDD As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents reservespeedondownloadCB As CheckBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents useproxyCB As CheckBox
    Friend WithEvents Label14 As Label
    Friend WithEvents proxyport As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents proxyip As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents proxyusername As TextBox
    Friend WithEvents proxypassword As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents TestproxyBtn As Button
    Friend WithEvents proxysts As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents Label27 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents Label30 As Label
End Class
