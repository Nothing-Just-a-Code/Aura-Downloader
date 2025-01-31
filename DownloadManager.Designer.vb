<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DownloadManager
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DownloadManager))
        ImageList1 = New ImageList(components)
        MenuStrip1 = New MenuStrip()
        ToolStripMenuItem1 = New ToolStripMenuItem()
        AddNewDownloadToolStripMenuItem = New ToolStripMenuItem()
        ToolStripSeparator1 = New ToolStripSeparator()
        StopRunningDownloadsToolStripMenuItem = New ToolStripMenuItem()
        ClearAllCompletedDownloadsToolStripMenuItem = New ToolStripMenuItem()
        ToolStripSeparator2 = New ToolStripSeparator()
        ClearAllDownloadsToolStripMenuItem = New ToolStripMenuItem()
        ToolStripSeparator3 = New ToolStripSeparator()
        ExitAuraDownloaderToolStripMenuItem = New ToolStripMenuItem()
        ToolStripMenuItem2 = New ToolStripMenuItem()
        SoundCloudEngineToolStripMenuItem = New ToolStripMenuItem()
        YoutubeEngineToolStripMenuItem = New ToolStripMenuItem()
        SettingsToolStripMenuItem = New ToolStripMenuItem()
        ToolStripMenuItem3 = New ToolStripMenuItem()
        ToolStripMenuItem5 = New ToolStripMenuItem()
        ToolStripMenuItem4 = New ToolStripMenuItem()
        CheckForUpdateToolStripMenuItem = New ToolStripMenuItem()
        AboutAuraDownloadToolStripMenuItem = New ToolStripMenuItem()
        LV = New ListView()
        ColumnHeader1 = New ColumnHeader()
        ColumnHeader2 = New ColumnHeader()
        ColumnHeader3 = New ColumnHeader()
        ColumnHeader4 = New ColumnHeader()
        ColumnHeader5 = New ColumnHeader()
        ContextMenuStrip1 = New ContextMenuStrip(components)
        OpenFileCN = New ToolStripMenuItem()
        OpenDirCN = New ToolStripMenuItem()
        ToolStripSeparator4 = New ToolStripSeparator()
        ResumeDownloadCN = New ToolStripMenuItem()
        CancelDownloadCN = New ToolStripMenuItem()
        ToolStripSeparator6 = New ToolStripSeparator()
        DeleteEntryCN = New ToolStripMenuItem()
        DeleteFileAndEntryCN = New ToolStripMenuItem()
        ToolStripSeparator5 = New ToolStripSeparator()
        ToolStripMenuItem9 = New ToolStripMenuItem()
        CopyFilenameCN = New ToolStripMenuItem()
        CopyFileCN = New ToolStripMenuItem()
        NotifyIcon1 = New NotifyIcon(components)
        ToolStripMenuItem6 = New ToolStripMenuItem()
        MenuStrip1.SuspendLayout()
        ContextMenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' ImageList1
        ' 
        ImageList1.ColorDepth = ColorDepth.Depth32Bit
        ImageList1.ImageSize = New Size(20, 20)
        ImageList1.TransparentColor = Color.Transparent
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.BackColor = Color.White
        MenuStrip1.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        MenuStrip1.Items.AddRange(New ToolStripItem() {ToolStripMenuItem1, ToolStripMenuItem2, SettingsToolStripMenuItem, ToolStripMenuItem3})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(858, 24)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' ToolStripMenuItem1
        ' 
        ToolStripMenuItem1.DropDownItems.AddRange(New ToolStripItem() {AddNewDownloadToolStripMenuItem, ToolStripSeparator1, StopRunningDownloadsToolStripMenuItem, ClearAllCompletedDownloadsToolStripMenuItem, ToolStripSeparator2, ClearAllDownloadsToolStripMenuItem, ToolStripSeparator3, ExitAuraDownloaderToolStripMenuItem})
        ToolStripMenuItem1.ForeColor = Color.FromArgb(CByte(20), CByte(30), CByte(40))
        ToolStripMenuItem1.Image = CType(resources.GetObject("ToolStripMenuItem1.Image"), Image)
        ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        ToolStripMenuItem1.Size = New Size(95, 20)
        ToolStripMenuItem1.Text = "Downloads"
        ' 
        ' AddNewDownloadToolStripMenuItem
        ' 
        AddNewDownloadToolStripMenuItem.BackColor = Color.White
        AddNewDownloadToolStripMenuItem.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        AddNewDownloadToolStripMenuItem.ForeColor = Color.FromArgb(CByte(20), CByte(30), CByte(40))
        AddNewDownloadToolStripMenuItem.Image = CType(resources.GetObject("AddNewDownloadToolStripMenuItem.Image"), Image)
        AddNewDownloadToolStripMenuItem.Name = "AddNewDownloadToolStripMenuItem"
        AddNewDownloadToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.D
        AddNewDownloadToolStripMenuItem.Size = New Size(241, 22)
        AddNewDownloadToolStripMenuItem.Text = "Add New Download"
        ' 
        ' ToolStripSeparator1
        ' 
        ToolStripSeparator1.BackColor = Color.White
        ToolStripSeparator1.ForeColor = Color.White
        ToolStripSeparator1.Name = "ToolStripSeparator1"
        ToolStripSeparator1.Size = New Size(238, 6)
        ' 
        ' StopRunningDownloadsToolStripMenuItem
        ' 
        StopRunningDownloadsToolStripMenuItem.BackColor = Color.White
        StopRunningDownloadsToolStripMenuItem.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        StopRunningDownloadsToolStripMenuItem.ForeColor = Color.FromArgb(CByte(20), CByte(30), CByte(40))
        StopRunningDownloadsToolStripMenuItem.Image = CType(resources.GetObject("StopRunningDownloadsToolStripMenuItem.Image"), Image)
        StopRunningDownloadsToolStripMenuItem.Name = "StopRunningDownloadsToolStripMenuItem"
        StopRunningDownloadsToolStripMenuItem.Size = New Size(241, 22)
        StopRunningDownloadsToolStripMenuItem.Text = "Stop Running Downloads"
        ' 
        ' ClearAllCompletedDownloadsToolStripMenuItem
        ' 
        ClearAllCompletedDownloadsToolStripMenuItem.BackColor = Color.White
        ClearAllCompletedDownloadsToolStripMenuItem.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        ClearAllCompletedDownloadsToolStripMenuItem.ForeColor = Color.FromArgb(CByte(20), CByte(30), CByte(40))
        ClearAllCompletedDownloadsToolStripMenuItem.Image = CType(resources.GetObject("ClearAllCompletedDownloadsToolStripMenuItem.Image"), Image)
        ClearAllCompletedDownloadsToolStripMenuItem.Name = "ClearAllCompletedDownloadsToolStripMenuItem"
        ClearAllCompletedDownloadsToolStripMenuItem.Size = New Size(241, 22)
        ClearAllCompletedDownloadsToolStripMenuItem.Text = "Clear All Completed Downloads"
        ' 
        ' ToolStripSeparator2
        ' 
        ToolStripSeparator2.BackColor = SystemColors.Control
        ToolStripSeparator2.ForeColor = SystemColors.ControlText
        ToolStripSeparator2.Name = "ToolStripSeparator2"
        ToolStripSeparator2.Size = New Size(238, 6)
        ' 
        ' ClearAllDownloadsToolStripMenuItem
        ' 
        ClearAllDownloadsToolStripMenuItem.BackColor = Color.White
        ClearAllDownloadsToolStripMenuItem.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        ClearAllDownloadsToolStripMenuItem.ForeColor = Color.FromArgb(CByte(20), CByte(30), CByte(40))
        ClearAllDownloadsToolStripMenuItem.Image = CType(resources.GetObject("ClearAllDownloadsToolStripMenuItem.Image"), Image)
        ClearAllDownloadsToolStripMenuItem.Name = "ClearAllDownloadsToolStripMenuItem"
        ClearAllDownloadsToolStripMenuItem.Size = New Size(241, 22)
        ClearAllDownloadsToolStripMenuItem.Text = "Clear All Downloads"
        ' 
        ' ToolStripSeparator3
        ' 
        ToolStripSeparator3.BackColor = SystemColors.Control
        ToolStripSeparator3.ForeColor = SystemColors.ControlText
        ToolStripSeparator3.Name = "ToolStripSeparator3"
        ToolStripSeparator3.Size = New Size(238, 6)
        ' 
        ' ExitAuraDownloaderToolStripMenuItem
        ' 
        ExitAuraDownloaderToolStripMenuItem.BackColor = Color.White
        ExitAuraDownloaderToolStripMenuItem.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        ExitAuraDownloaderToolStripMenuItem.ForeColor = Color.FromArgb(CByte(20), CByte(30), CByte(40))
        ExitAuraDownloaderToolStripMenuItem.Image = CType(resources.GetObject("ExitAuraDownloaderToolStripMenuItem.Image"), Image)
        ExitAuraDownloaderToolStripMenuItem.Name = "ExitAuraDownloaderToolStripMenuItem"
        ExitAuraDownloaderToolStripMenuItem.ShortcutKeys = Keys.Alt Or Keys.F4
        ExitAuraDownloaderToolStripMenuItem.Size = New Size(241, 22)
        ExitAuraDownloaderToolStripMenuItem.Text = "Close Aura Downloader"
        ' 
        ' ToolStripMenuItem2
        ' 
        ToolStripMenuItem2.DropDownItems.AddRange(New ToolStripItem() {SoundCloudEngineToolStripMenuItem, YoutubeEngineToolStripMenuItem})
        ToolStripMenuItem2.ForeColor = Color.FromArgb(CByte(20), CByte(30), CByte(40))
        ToolStripMenuItem2.Image = CType(resources.GetObject("ToolStripMenuItem2.Image"), Image)
        ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        ToolStripMenuItem2.Size = New Size(71, 20)
        ToolStripMenuItem2.Text = "Search"
        ' 
        ' SoundCloudEngineToolStripMenuItem
        ' 
        SoundCloudEngineToolStripMenuItem.BackColor = Color.White
        SoundCloudEngineToolStripMenuItem.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        SoundCloudEngineToolStripMenuItem.ForeColor = Color.FromArgb(CByte(20), CByte(30), CByte(40))
        SoundCloudEngineToolStripMenuItem.Image = CType(resources.GetObject("SoundCloudEngineToolStripMenuItem.Image"), Image)
        SoundCloudEngineToolStripMenuItem.Name = "SoundCloudEngineToolStripMenuItem"
        SoundCloudEngineToolStripMenuItem.Size = New Size(179, 22)
        SoundCloudEngineToolStripMenuItem.Text = "SoundCloud Engine"
        ' 
        ' YoutubeEngineToolStripMenuItem
        ' 
        YoutubeEngineToolStripMenuItem.BackColor = Color.White
        YoutubeEngineToolStripMenuItem.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        YoutubeEngineToolStripMenuItem.ForeColor = Color.FromArgb(CByte(20), CByte(30), CByte(40))
        YoutubeEngineToolStripMenuItem.Image = CType(resources.GetObject("YoutubeEngineToolStripMenuItem.Image"), Image)
        YoutubeEngineToolStripMenuItem.Name = "YoutubeEngineToolStripMenuItem"
        YoutubeEngineToolStripMenuItem.Size = New Size(179, 22)
        YoutubeEngineToolStripMenuItem.Text = "Youtube Engine"
        ' 
        ' SettingsToolStripMenuItem
        ' 
        SettingsToolStripMenuItem.ForeColor = Color.FromArgb(CByte(20), CByte(30), CByte(40))
        SettingsToolStripMenuItem.Image = CType(resources.GetObject("SettingsToolStripMenuItem.Image"), Image)
        SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        SettingsToolStripMenuItem.Size = New Size(78, 20)
        SettingsToolStripMenuItem.Text = "Settings"
        ' 
        ' ToolStripMenuItem3
        ' 
        ToolStripMenuItem3.DropDownItems.AddRange(New ToolStripItem() {ToolStripMenuItem5, ToolStripMenuItem4, CheckForUpdateToolStripMenuItem, ToolStripMenuItem6, AboutAuraDownloadToolStripMenuItem})
        ToolStripMenuItem3.ForeColor = Color.FromArgb(CByte(20), CByte(30), CByte(40))
        ToolStripMenuItem3.Image = CType(resources.GetObject("ToolStripMenuItem3.Image"), Image)
        ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        ToolStripMenuItem3.Size = New Size(68, 20)
        ToolStripMenuItem3.Text = "About"
        ' 
        ' ToolStripMenuItem5
        ' 
        ToolStripMenuItem5.BackColor = Color.White
        ToolStripMenuItem5.ForeColor = Color.FromArgb(CByte(20), CByte(30), CByte(40))
        ToolStripMenuItem5.Image = CType(resources.GetObject("ToolStripMenuItem5.Image"), Image)
        ToolStripMenuItem5.Name = "ToolStripMenuItem5"
        ToolStripMenuItem5.Size = New Size(193, 22)
        ToolStripMenuItem5.Text = "Donate"
        ' 
        ' ToolStripMenuItem4
        ' 
        ToolStripMenuItem4.BackColor = Color.White
        ToolStripMenuItem4.ForeColor = Color.FromArgb(CByte(20), CByte(30), CByte(40))
        ToolStripMenuItem4.Image = CType(resources.GetObject("ToolStripMenuItem4.Image"), Image)
        ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        ToolStripMenuItem4.Size = New Size(193, 22)
        ToolStripMenuItem4.Text = "Github"
        ' 
        ' CheckForUpdateToolStripMenuItem
        ' 
        CheckForUpdateToolStripMenuItem.BackColor = Color.White
        CheckForUpdateToolStripMenuItem.ForeColor = Color.FromArgb(CByte(20), CByte(30), CByte(40))
        CheckForUpdateToolStripMenuItem.Image = CType(resources.GetObject("CheckForUpdateToolStripMenuItem.Image"), Image)
        CheckForUpdateToolStripMenuItem.Name = "CheckForUpdateToolStripMenuItem"
        CheckForUpdateToolStripMenuItem.Size = New Size(193, 22)
        CheckForUpdateToolStripMenuItem.Text = "Check for Update"
        ' 
        ' AboutAuraDownloadToolStripMenuItem
        ' 
        AboutAuraDownloadToolStripMenuItem.BackColor = Color.White
        AboutAuraDownloadToolStripMenuItem.ForeColor = Color.FromArgb(CByte(20), CByte(30), CByte(40))
        AboutAuraDownloadToolStripMenuItem.Image = CType(resources.GetObject("AboutAuraDownloadToolStripMenuItem.Image"), Image)
        AboutAuraDownloadToolStripMenuItem.Name = "AboutAuraDownloadToolStripMenuItem"
        AboutAuraDownloadToolStripMenuItem.Size = New Size(193, 22)
        AboutAuraDownloadToolStripMenuItem.Text = "About Aura Download"
        ' 
        ' LV
        ' 
        LV.BackColor = Color.White
        LV.BorderStyle = BorderStyle.None
        LV.Columns.AddRange(New ColumnHeader() {ColumnHeader1, ColumnHeader2, ColumnHeader3, ColumnHeader4, ColumnHeader5})
        LV.ContextMenuStrip = ContextMenuStrip1
        LV.Dock = DockStyle.Fill
        LV.ForeColor = Color.FromArgb(CByte(54), CByte(69), CByte(79))
        LV.FullRowSelect = True
        LV.GridLines = True
        LV.Location = New Point(0, 24)
        LV.MultiSelect = False
        LV.Name = "LV"
        LV.Size = New Size(858, 465)
        LV.SmallImageList = ImageList1
        LV.TabIndex = 5
        LV.UseCompatibleStateImageBehavior = False
        LV.View = View.Details
        ' 
        ' ColumnHeader1
        ' 
        ColumnHeader1.Text = "Filename"
        ColumnHeader1.Width = 200
        ' 
        ' ColumnHeader2
        ' 
        ColumnHeader2.Text = "Size"
        ColumnHeader2.TextAlign = HorizontalAlignment.Center
        ColumnHeader2.Width = 80
        ' 
        ' ColumnHeader3
        ' 
        ColumnHeader3.Text = "Directory"
        ColumnHeader3.TextAlign = HorizontalAlignment.Center
        ColumnHeader3.Width = 160
        ' 
        ' ColumnHeader4
        ' 
        ColumnHeader4.Text = "Added On"
        ColumnHeader4.TextAlign = HorizontalAlignment.Center
        ColumnHeader4.Width = 100
        ' 
        ' ColumnHeader5
        ' 
        ColumnHeader5.Text = "Status"
        ColumnHeader5.TextAlign = HorizontalAlignment.Center
        ColumnHeader5.Width = 90
        ' 
        ' ContextMenuStrip1
        ' 
        ContextMenuStrip1.Items.AddRange(New ToolStripItem() {OpenFileCN, OpenDirCN, ToolStripSeparator4, ResumeDownloadCN, CancelDownloadCN, ToolStripSeparator6, DeleteEntryCN, ToolStripSeparator5, ToolStripMenuItem9})
        ContextMenuStrip1.Name = "ContextMenuStrip1"
        ContextMenuStrip1.Size = New Size(195, 154)
        ' 
        ' OpenFileCN
        ' 
        OpenFileCN.BackColor = Color.White
        OpenFileCN.Image = CType(resources.GetObject("OpenFileCN.Image"), Image)
        OpenFileCN.Name = "OpenFileCN"
        OpenFileCN.Size = New Size(194, 22)
        OpenFileCN.Text = "Open"
        ' 
        ' OpenDirCN
        ' 
        OpenDirCN.BackColor = Color.White
        OpenDirCN.Image = CType(resources.GetObject("OpenDirCN.Image"), Image)
        OpenDirCN.Name = "OpenDirCN"
        OpenDirCN.Size = New Size(194, 22)
        OpenDirCN.Text = "Open Directory"
        ' 
        ' ToolStripSeparator4
        ' 
        ToolStripSeparator4.Name = "ToolStripSeparator4"
        ToolStripSeparator4.Size = New Size(191, 6)
        ' 
        ' ResumeDownloadCN
        ' 
        ResumeDownloadCN.BackColor = Color.White
        ResumeDownloadCN.Image = CType(resources.GetObject("ResumeDownloadCN.Image"), Image)
        ResumeDownloadCN.Name = "ResumeDownloadCN"
        ResumeDownloadCN.Size = New Size(194, 22)
        ResumeDownloadCN.Text = "Resume Download"
        ' 
        ' CancelDownloadCN
        ' 
        CancelDownloadCN.BackColor = Color.White
        CancelDownloadCN.Image = CType(resources.GetObject("CancelDownloadCN.Image"), Image)
        CancelDownloadCN.Name = "CancelDownloadCN"
        CancelDownloadCN.Size = New Size(194, 22)
        CancelDownloadCN.Text = "Cancel Download"
        ' 
        ' ToolStripSeparator6
        ' 
        ToolStripSeparator6.Name = "ToolStripSeparator6"
        ToolStripSeparator6.Size = New Size(191, 6)
        ' 
        ' DeleteEntryCN
        ' 
        DeleteEntryCN.BackColor = Color.White
        DeleteEntryCN.DropDownItems.AddRange(New ToolStripItem() {DeleteFileAndEntryCN})
        DeleteEntryCN.Image = CType(resources.GetObject("DeleteEntryCN.Image"), Image)
        DeleteEntryCN.Name = "DeleteEntryCN"
        DeleteEntryCN.Size = New Size(194, 22)
        DeleteEntryCN.Text = "Delete Download Entry"
        ' 
        ' DeleteFileAndEntryCN
        ' 
        DeleteFileAndEntryCN.Image = CType(resources.GetObject("DeleteFileAndEntryCN.Image"), Image)
        DeleteFileAndEntryCN.Name = "DeleteFileAndEntryCN"
        DeleteFileAndEntryCN.Size = New Size(238, 22)
        DeleteFileAndEntryCN.Text = "Delete File and Download Entry"
        ' 
        ' ToolStripSeparator5
        ' 
        ToolStripSeparator5.Name = "ToolStripSeparator5"
        ToolStripSeparator5.Size = New Size(191, 6)
        ' 
        ' ToolStripMenuItem9
        ' 
        ToolStripMenuItem9.BackColor = Color.White
        ToolStripMenuItem9.DropDownItems.AddRange(New ToolStripItem() {CopyFilenameCN, CopyFileCN})
        ToolStripMenuItem9.Image = CType(resources.GetObject("ToolStripMenuItem9.Image"), Image)
        ToolStripMenuItem9.Name = "ToolStripMenuItem9"
        ToolStripMenuItem9.Size = New Size(194, 22)
        ToolStripMenuItem9.Text = "Copy"
        ' 
        ' CopyFilenameCN
        ' 
        CopyFilenameCN.Image = CType(resources.GetObject("CopyFilenameCN.Image"), Image)
        CopyFilenameCN.Name = "CopyFilenameCN"
        CopyFilenameCN.Size = New Size(153, 22)
        CopyFilenameCN.Text = "Copy Filename"
        ' 
        ' CopyFileCN
        ' 
        CopyFileCN.Image = CType(resources.GetObject("CopyFileCN.Image"), Image)
        CopyFileCN.Name = "CopyFileCN"
        CopyFileCN.Size = New Size(153, 22)
        CopyFileCN.Text = "Copy File"
        ' 
        ' NotifyIcon1
        ' 
        NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), Icon)
        NotifyIcon1.Text = "Aura Downloader"
        NotifyIcon1.Visible = True
        ' 
        ' ToolStripMenuItem6
        ' 
        ToolStripMenuItem6.BackColor = Color.White
        ToolStripMenuItem6.ForeColor = Color.FromArgb(CByte(20), CByte(30), CByte(40))
        ToolStripMenuItem6.Image = CType(resources.GetObject("ToolStripMenuItem6.Image"), Image)
        ToolStripMenuItem6.Name = "ToolStripMenuItem6"
        ToolStripMenuItem6.Size = New Size(193, 22)
        ToolStripMenuItem6.Text = "Report Bug"
        ' 
        ' DownloadManager
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(858, 489)
        Controls.Add(LV)
        Controls.Add(MenuStrip1)
        DoubleBuffered = True
        ForeColor = Color.FromArgb(CByte(20), CByte(30), CByte(40))
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "DownloadManager"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Aura Downloader"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ContextMenuStrip1.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents SettingsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents LV As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents AddNewDownloadToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents StopRunningDownloadsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClearAllCompletedDownloadsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ClearAllDownloadsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents ExitAuraDownloaderToolStripMenuItem As ToolStripMenuItem
    Public WithEvents ImageList1 As ImageList
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents OpenFileCN As ToolStripMenuItem
    Friend WithEvents OpenDirCN As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents ResumeDownloadCN As ToolStripMenuItem
    Friend WithEvents CancelDownloadCN As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator6 As ToolStripSeparator
    Friend WithEvents DeleteEntryCN As ToolStripMenuItem
    Friend WithEvents DeleteFileAndEntryCN As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
    Friend WithEvents ToolStripMenuItem9 As ToolStripMenuItem
    Friend WithEvents CopyFilenameCN As ToolStripMenuItem
    Friend WithEvents CopyFileCN As ToolStripMenuItem
    Friend WithEvents SoundCloudEngineToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents YoutubeEngineToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CheckForUpdateToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutAuraDownloadToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NotifyIcon1 As NotifyIcon
    Friend WithEvents ToolStripMenuItem5 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem6 As ToolStripMenuItem
End Class
