﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Raspberation_UI
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Raspberation_UI))
        Dim TreeNode36 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("GPIO 03")
        Dim TreeNode37 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("GPIO 05")
        Dim TreeNode38 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("GPIO 07")
        Dim TreeNode39 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("GPIO 08")
        Dim TreeNode40 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("GPIO 10")
        Dim TreeNode41 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("GPIO 11")
        Dim TreeNode42 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("GPIO 12")
        Dim TreeNode43 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("GPIO 13")
        Dim TreeNode44 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("GPIO 15")
        Dim TreeNode45 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("GPIO 16")
        Dim TreeNode46 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("GPIO 18")
        Dim TreeNode47 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("GPIO 19")
        Dim TreeNode48 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("GPIO 21")
        Dim TreeNode49 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("GPIO 22")
        Dim TreeNode50 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("GPIO 23")
        Dim TreeNode51 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("GPIO 24")
        Dim TreeNode52 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("GPIO 26")
        Dim TreeNode53 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("GPIO 29")
        Dim TreeNode54 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("GPIO 31")
        Dim TreeNode55 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("GPIO 32")
        Dim TreeNode56 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("GPIO 33")
        Dim TreeNode57 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("GPIO 35")
        Dim TreeNode58 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("GPIO 36")
        Dim TreeNode59 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("GPIO 37")
        Dim TreeNode60 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("GPIO 38")
        Dim TreeNode61 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("GPIO 40")
        Dim TreeNode62 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("GPIO", New System.Windows.Forms.TreeNode() {TreeNode36, TreeNode37, TreeNode38, TreeNode39, TreeNode40, TreeNode41, TreeNode42, TreeNode43, TreeNode44, TreeNode45, TreeNode46, TreeNode47, TreeNode48, TreeNode49, TreeNode50, TreeNode51, TreeNode52, TreeNode53, TreeNode54, TreeNode55, TreeNode56, TreeNode57, TreeNode58, TreeNode59, TreeNode60, TreeNode61})
        Dim TreeNode63 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("UART")
        Dim TreeNode64 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("UART", New System.Windows.Forms.TreeNode() {TreeNode63})
        Dim TreeNode65 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("SPI1")
        Dim TreeNode66 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("SPI2")
        Dim TreeNode67 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("SPI", New System.Windows.Forms.TreeNode() {TreeNode65, TreeNode66})
        Dim TreeNode68 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("I2C")
        Dim TreeNode69 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("I2C", New System.Windows.Forms.TreeNode() {TreeNode68})
        Dim TreeNode70 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Peripherals", New System.Windows.Forms.TreeNode() {TreeNode62, TreeNode64, TreeNode67, TreeNode69})
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ファイルToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.名前をつけて保存ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.上書き保存ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.開くToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.終了ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ヘルプToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ヘルプの表示ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RaspberationについてToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.LoadPrj = New System.Windows.Forms.ToolStripButton()
        Me.SavePrj = New System.Windows.Forms.ToolStripButton()
        Me.GenSRC = New System.Windows.Forms.ToolStripButton()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.BaseSettings = New System.Windows.Forms.TabPage()
        Me.SelectSrcPath = New System.Windows.Forms.Button()
        Me.SaveSrcPath = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SelectPrjPath = New System.Windows.Forms.Button()
        Me.SavePrjPath = New System.Windows.Forms.TextBox()
        Me.UsedModel = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PinSettings = New System.Windows.Forms.TabPage()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GenMakefile = New System.Windows.Forms.TabPage()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.SelectPullUpDown = New System.Windows.Forms.ComboBox()
        Me.LabelGPIO9 = New System.Windows.Forms.Label()
        Me.DetectAsyncDownEdge = New System.Windows.Forms.ComboBox()
        Me.LabelGPIO8 = New System.Windows.Forms.Label()
        Me.DetectAsyncUpEdge = New System.Windows.Forms.ComboBox()
        Me.LabelGPIO7 = New System.Windows.Forms.Label()
        Me.DetectLowLevel = New System.Windows.Forms.ComboBox()
        Me.LabelGPIO6 = New System.Windows.Forms.Label()
        Me.DetectHighLevel = New System.Windows.Forms.ComboBox()
        Me.LabelGPIO5 = New System.Windows.Forms.Label()
        Me.DetectDownEdge = New System.Windows.Forms.ComboBox()
        Me.LabelGPIO4 = New System.Windows.Forms.Label()
        Me.DetectUpEdge = New System.Windows.Forms.ComboBox()
        Me.LabelGPIO3 = New System.Windows.Forms.Label()
        Me.Level = New System.Windows.Forms.ComboBox()
        Me.LabelGPIO2 = New System.Windows.Forms.Label()
        Me.Mode = New System.Windows.Forms.ComboBox()
        Me.LabelGPIO1 = New System.Windows.Forms.Label()
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.SavePrjFile = New System.Windows.Forms.SaveFileDialog()
        Me.LoadPrjFile = New System.Windows.Forms.OpenFileDialog()
        Me.SaveSrc = New System.Windows.Forms.SaveFileDialog()
        Me.SetInfoSPI = New System.Windows.Forms.TabControl()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.EnableTOH = New System.Windows.Forms.ComboBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.EnableLoSSILongWord = New System.Windows.Forms.ComboBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.EnableLoSSIDMA = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.CS2Polarity = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.CS1Polarity = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.CS0Polarity = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.EnableLoSSI = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.EnableRead = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.EnableADCS = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.EnableRXInterrupt = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.EnableTxInterrupt = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.EnableDMA = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.EnableTransfer = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CSPolarity = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CLEARFIFO = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.ClockPolarity = New System.Windows.Forms.ComboBox()
        Me.ChipSelect = New System.Windows.Forms.ComboBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.ClockPhase = New System.Windows.Forms.ComboBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.ClockUnit = New System.Windows.Forms.ComboBox()
        Me.ClockFreq = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.TransferSize = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.ReadPanicThreshold = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.ReadRequestThreshold = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.WritePanicThreshold = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.WriteRequestThreshold = New System.Windows.Forms.TextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.BaseSettings.SuspendLayout()
        Me.PinSettings.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage1.SuspendLayout()
        Me.SetInfoSPI.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.TabPage6.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ファイルToolStripMenuItem, Me.ヘルプToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(784, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ファイルToolStripMenuItem
        '
        Me.ファイルToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.名前をつけて保存ToolStripMenuItem, Me.上書き保存ToolStripMenuItem, Me.開くToolStripMenuItem, Me.終了ToolStripMenuItem})
        Me.ファイルToolStripMenuItem.Name = "ファイルToolStripMenuItem"
        Me.ファイルToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.ファイルToolStripMenuItem.Text = "ファイル"
        '
        '名前をつけて保存ToolStripMenuItem
        '
        Me.名前をつけて保存ToolStripMenuItem.Name = "名前をつけて保存ToolStripMenuItem"
        Me.名前をつけて保存ToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.名前をつけて保存ToolStripMenuItem.Text = "名前をつけて保存"
        '
        '上書き保存ToolStripMenuItem
        '
        Me.上書き保存ToolStripMenuItem.Name = "上書き保存ToolStripMenuItem"
        Me.上書き保存ToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.上書き保存ToolStripMenuItem.Text = "上書き保存"
        '
        '開くToolStripMenuItem
        '
        Me.開くToolStripMenuItem.Name = "開くToolStripMenuItem"
        Me.開くToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.開くToolStripMenuItem.Text = "開く"
        '
        '終了ToolStripMenuItem
        '
        Me.終了ToolStripMenuItem.Name = "終了ToolStripMenuItem"
        Me.終了ToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.終了ToolStripMenuItem.Text = "終了"
        '
        'ヘルプToolStripMenuItem
        '
        Me.ヘルプToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ヘルプの表示ToolStripMenuItem, Me.RaspberationについてToolStripMenuItem})
        Me.ヘルプToolStripMenuItem.Name = "ヘルプToolStripMenuItem"
        Me.ヘルプToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
        Me.ヘルプToolStripMenuItem.Text = "ヘルプ"
        '
        'ヘルプの表示ToolStripMenuItem
        '
        Me.ヘルプの表示ToolStripMenuItem.Name = "ヘルプの表示ToolStripMenuItem"
        Me.ヘルプの表示ToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ヘルプの表示ToolStripMenuItem.Text = "ヘルプの表示"
        '
        'RaspberationについてToolStripMenuItem
        '
        Me.RaspberationについてToolStripMenuItem.Name = "RaspberationについてToolStripMenuItem"
        Me.RaspberationについてToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.RaspberationについてToolStripMenuItem.Text = "Raspberationについて"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 539)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(784, 22)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(59, 17)
        Me.ToolStripStatusLabel1.Text = "Loading..."
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoadPrj, Me.SavePrj, Me.GenSRC})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 24)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(784, 25)
        Me.ToolStrip1.TabIndex = 2
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'LoadPrj
        '
        Me.LoadPrj.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.LoadPrj.Image = CType(resources.GetObject("LoadPrj.Image"), System.Drawing.Image)
        Me.LoadPrj.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.LoadPrj.Name = "LoadPrj"
        Me.LoadPrj.Size = New System.Drawing.Size(23, 22)
        Me.LoadPrj.Text = "ToolStripButton1"
        Me.LoadPrj.ToolTipText = "開く"
        '
        'SavePrj
        '
        Me.SavePrj.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SavePrj.Image = CType(resources.GetObject("SavePrj.Image"), System.Drawing.Image)
        Me.SavePrj.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SavePrj.Name = "SavePrj"
        Me.SavePrj.Size = New System.Drawing.Size(23, 22)
        Me.SavePrj.Text = "ToolStripButton2"
        Me.SavePrj.ToolTipText = "保存"
        '
        'GenSRC
        '
        Me.GenSRC.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.GenSRC.Image = CType(resources.GetObject("GenSRC.Image"), System.Drawing.Image)
        Me.GenSRC.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.GenSRC.Name = "GenSRC"
        Me.GenSRC.Size = New System.Drawing.Size(23, 22)
        Me.GenSRC.Text = "ToolStripButton3"
        Me.GenSRC.ToolTipText = "ソースコード生成"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.BaseSettings)
        Me.TabControl1.Controls.Add(Me.PinSettings)
        Me.TabControl1.Controls.Add(Me.GenMakefile)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 49)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(784, 490)
        Me.TabControl1.TabIndex = 3
        '
        'BaseSettings
        '
        Me.BaseSettings.AutoScroll = True
        Me.BaseSettings.Controls.Add(Me.SelectSrcPath)
        Me.BaseSettings.Controls.Add(Me.SaveSrcPath)
        Me.BaseSettings.Controls.Add(Me.Label1)
        Me.BaseSettings.Controls.Add(Me.SelectPrjPath)
        Me.BaseSettings.Controls.Add(Me.SavePrjPath)
        Me.BaseSettings.Controls.Add(Me.UsedModel)
        Me.BaseSettings.Controls.Add(Me.Label3)
        Me.BaseSettings.Controls.Add(Me.Label2)
        Me.BaseSettings.Location = New System.Drawing.Point(4, 22)
        Me.BaseSettings.Name = "BaseSettings"
        Me.BaseSettings.Padding = New System.Windows.Forms.Padding(3)
        Me.BaseSettings.Size = New System.Drawing.Size(776, 464)
        Me.BaseSettings.TabIndex = 0
        Me.BaseSettings.Text = "基本設定"
        Me.BaseSettings.UseVisualStyleBackColor = True
        '
        'SelectSrcPath
        '
        Me.SelectSrcPath.Location = New System.Drawing.Point(693, 57)
        Me.SelectSrcPath.Name = "SelectSrcPath"
        Me.SelectSrcPath.Size = New System.Drawing.Size(75, 23)
        Me.SelectSrcPath.TabIndex = 9
        Me.SelectSrcPath.Text = "選択"
        Me.SelectSrcPath.UseVisualStyleBackColor = True
        '
        'SaveSrcPath
        '
        Me.SaveSrcPath.Location = New System.Drawing.Point(8, 59)
        Me.SaveSrcPath.Name = "SaveSrcPath"
        Me.SaveSrcPath.Size = New System.Drawing.Size(679, 19)
        Me.SaveSrcPath.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(156, 12)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "自動生成ソースコード保存場所"
        '
        'SelectPrjPath
        '
        Me.SelectPrjPath.Location = New System.Drawing.Point(695, 20)
        Me.SelectPrjPath.Name = "SelectPrjPath"
        Me.SelectPrjPath.Size = New System.Drawing.Size(75, 23)
        Me.SelectPrjPath.TabIndex = 6
        Me.SelectPrjPath.Text = "選択"
        Me.SelectPrjPath.UseVisualStyleBackColor = True
        '
        'SavePrjPath
        '
        Me.SavePrjPath.Location = New System.Drawing.Point(10, 22)
        Me.SavePrjPath.Name = "SavePrjPath"
        Me.SavePrjPath.Size = New System.Drawing.Size(679, 19)
        Me.SavePrjPath.TabIndex = 5
        '
        'UsedModel
        '
        Me.UsedModel.FormattingEnabled = True
        Me.UsedModel.Items.AddRange(New Object() {"Raspberry Pi 3 model B"})
        Me.UsedModel.Location = New System.Drawing.Point(91, 82)
        Me.UsedModel.Name = "UsedModel"
        Me.UsedModel.Size = New System.Drawing.Size(154, 20)
        Me.UsedModel.TabIndex = 3
        Me.UsedModel.Text = "Raspberry Pi 3 model B"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 7)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(138, 12)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "プロジェクトファイル保存場所"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 12)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "使用するモデル"
        '
        'PinSettings
        '
        Me.PinSettings.Controls.Add(Me.PictureBox1)
        Me.PinSettings.Location = New System.Drawing.Point(4, 22)
        Me.PinSettings.Name = "PinSettings"
        Me.PinSettings.Padding = New System.Windows.Forms.Padding(3)
        Me.PinSettings.Size = New System.Drawing.Size(776, 464)
        Me.PinSettings.TabIndex = 1
        Me.PinSettings.Text = "Pin設定"
        Me.PinSettings.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(770, 458)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'GenMakefile
        '
        Me.GenMakefile.Location = New System.Drawing.Point(4, 22)
        Me.GenMakefile.Name = "GenMakefile"
        Me.GenMakefile.Size = New System.Drawing.Size(776, 464)
        Me.GenMakefile.TabIndex = 2
        Me.GenMakefile.Text = "makefile生成"
        Me.GenMakefile.UseVisualStyleBackColor = True
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.SetInfoSPI)
        Me.TabPage1.Controls.Add(Me.SelectPullUpDown)
        Me.TabPage1.Controls.Add(Me.LabelGPIO9)
        Me.TabPage1.Controls.Add(Me.DetectAsyncDownEdge)
        Me.TabPage1.Controls.Add(Me.LabelGPIO8)
        Me.TabPage1.Controls.Add(Me.DetectAsyncUpEdge)
        Me.TabPage1.Controls.Add(Me.LabelGPIO7)
        Me.TabPage1.Controls.Add(Me.DetectLowLevel)
        Me.TabPage1.Controls.Add(Me.LabelGPIO6)
        Me.TabPage1.Controls.Add(Me.DetectHighLevel)
        Me.TabPage1.Controls.Add(Me.LabelGPIO5)
        Me.TabPage1.Controls.Add(Me.DetectDownEdge)
        Me.TabPage1.Controls.Add(Me.LabelGPIO4)
        Me.TabPage1.Controls.Add(Me.DetectUpEdge)
        Me.TabPage1.Controls.Add(Me.LabelGPIO3)
        Me.TabPage1.Controls.Add(Me.Level)
        Me.TabPage1.Controls.Add(Me.LabelGPIO2)
        Me.TabPage1.Controls.Add(Me.Mode)
        Me.TabPage1.Controls.Add(Me.LabelGPIO1)
        Me.TabPage1.Controls.Add(Me.TreeView1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(776, 464)
        Me.TabPage1.TabIndex = 3
        Me.TabPage1.Text = "PinOut"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'SelectPullUpDown
        '
        Me.SelectPullUpDown.FormattingEnabled = True
        Me.SelectPullUpDown.Items.AddRange(New Object() {"しない", "プルアップ", "プルダウン"})
        Me.SelectPullUpDown.Location = New System.Drawing.Point(139, 345)
        Me.SelectPullUpDown.Name = "SelectPullUpDown"
        Me.SelectPullUpDown.Size = New System.Drawing.Size(88, 20)
        Me.SelectPullUpDown.TabIndex = 36
        Me.SelectPullUpDown.Text = "しない"
        Me.SelectPullUpDown.Visible = False
        '
        'LabelGPIO9
        '
        Me.LabelGPIO9.AutoSize = True
        Me.LabelGPIO9.Location = New System.Drawing.Point(136, 330)
        Me.LabelGPIO9.Name = "LabelGPIO9"
        Me.LabelGPIO9.Size = New System.Drawing.Size(125, 12)
        Me.LabelGPIO9.TabIndex = 35
        Me.LabelGPIO9.Text = "プルアップ・プルダウン選択"
        Me.LabelGPIO9.Visible = False
        '
        'DetectAsyncDownEdge
        '
        Me.DetectAsyncDownEdge.FormattingEnabled = True
        Me.DetectAsyncDownEdge.Items.AddRange(New Object() {"する", "しない"})
        Me.DetectAsyncDownEdge.Location = New System.Drawing.Point(139, 305)
        Me.DetectAsyncDownEdge.Name = "DetectAsyncDownEdge"
        Me.DetectAsyncDownEdge.Size = New System.Drawing.Size(57, 20)
        Me.DetectAsyncDownEdge.TabIndex = 34
        Me.DetectAsyncDownEdge.Text = "する"
        Me.DetectAsyncDownEdge.Visible = False
        '
        'LabelGPIO8
        '
        Me.LabelGPIO8.AutoSize = True
        Me.LabelGPIO8.Location = New System.Drawing.Point(136, 290)
        Me.LabelGPIO8.Name = "LabelGPIO8"
        Me.LabelGPIO8.Size = New System.Drawing.Size(142, 12)
        Me.LabelGPIO8.TabIndex = 33
        Me.LabelGPIO8.Text = "非同期立ち上がりエッジ検出"
        Me.LabelGPIO8.Visible = False
        '
        'DetectAsyncUpEdge
        '
        Me.DetectAsyncUpEdge.FormattingEnabled = True
        Me.DetectAsyncUpEdge.Items.AddRange(New Object() {"する", "しない"})
        Me.DetectAsyncUpEdge.Location = New System.Drawing.Point(139, 265)
        Me.DetectAsyncUpEdge.Name = "DetectAsyncUpEdge"
        Me.DetectAsyncUpEdge.Size = New System.Drawing.Size(57, 20)
        Me.DetectAsyncUpEdge.TabIndex = 32
        Me.DetectAsyncUpEdge.Text = "する"
        Me.DetectAsyncUpEdge.Visible = False
        '
        'LabelGPIO7
        '
        Me.LabelGPIO7.AutoSize = True
        Me.LabelGPIO7.Location = New System.Drawing.Point(136, 250)
        Me.LabelGPIO7.Name = "LabelGPIO7"
        Me.LabelGPIO7.Size = New System.Drawing.Size(142, 12)
        Me.LabelGPIO7.TabIndex = 31
        Me.LabelGPIO7.Text = "非同期立ち上がりエッジ検出"
        Me.LabelGPIO7.Visible = False
        '
        'DetectLowLevel
        '
        Me.DetectLowLevel.FormattingEnabled = True
        Me.DetectLowLevel.Items.AddRange(New Object() {"する", "しない"})
        Me.DetectLowLevel.Location = New System.Drawing.Point(139, 225)
        Me.DetectLowLevel.Name = "DetectLowLevel"
        Me.DetectLowLevel.Size = New System.Drawing.Size(57, 20)
        Me.DetectLowLevel.TabIndex = 30
        Me.DetectLowLevel.Text = "する"
        Me.DetectLowLevel.Visible = False
        '
        'LabelGPIO6
        '
        Me.LabelGPIO6.AutoSize = True
        Me.LabelGPIO6.Location = New System.Drawing.Point(136, 210)
        Me.LabelGPIO6.Name = "LabelGPIO6"
        Me.LabelGPIO6.Size = New System.Drawing.Size(77, 12)
        Me.LabelGPIO6.TabIndex = 29
        Me.LabelGPIO6.Text = "ローレベル検出"
        Me.LabelGPIO6.Visible = False
        '
        'DetectHighLevel
        '
        Me.DetectHighLevel.FormattingEnabled = True
        Me.DetectHighLevel.Items.AddRange(New Object() {"する", "しない"})
        Me.DetectHighLevel.Location = New System.Drawing.Point(139, 185)
        Me.DetectHighLevel.Name = "DetectHighLevel"
        Me.DetectHighLevel.Size = New System.Drawing.Size(57, 20)
        Me.DetectHighLevel.TabIndex = 28
        Me.DetectHighLevel.Text = "する"
        Me.DetectHighLevel.Visible = False
        '
        'LabelGPIO5
        '
        Me.LabelGPIO5.AutoSize = True
        Me.LabelGPIO5.Location = New System.Drawing.Point(136, 170)
        Me.LabelGPIO5.Name = "LabelGPIO5"
        Me.LabelGPIO5.Size = New System.Drawing.Size(77, 12)
        Me.LabelGPIO5.TabIndex = 27
        Me.LabelGPIO5.Text = "ハイレベル検出"
        Me.LabelGPIO5.Visible = False
        '
        'DetectDownEdge
        '
        Me.DetectDownEdge.FormattingEnabled = True
        Me.DetectDownEdge.Items.AddRange(New Object() {"する", "しない"})
        Me.DetectDownEdge.Location = New System.Drawing.Point(139, 145)
        Me.DetectDownEdge.Name = "DetectDownEdge"
        Me.DetectDownEdge.Size = New System.Drawing.Size(57, 20)
        Me.DetectDownEdge.TabIndex = 26
        Me.DetectDownEdge.Text = "する"
        Me.DetectDownEdge.Visible = False
        '
        'LabelGPIO4
        '
        Me.LabelGPIO4.AutoSize = True
        Me.LabelGPIO4.Location = New System.Drawing.Point(136, 130)
        Me.LabelGPIO4.Name = "LabelGPIO4"
        Me.LabelGPIO4.Size = New System.Drawing.Size(106, 12)
        Me.LabelGPIO4.TabIndex = 25
        Me.LabelGPIO4.Text = "立ち下がりエッジ検出"
        Me.LabelGPIO4.Visible = False
        '
        'DetectUpEdge
        '
        Me.DetectUpEdge.FormattingEnabled = True
        Me.DetectUpEdge.Items.AddRange(New Object() {"する", "しない"})
        Me.DetectUpEdge.Location = New System.Drawing.Point(140, 105)
        Me.DetectUpEdge.Name = "DetectUpEdge"
        Me.DetectUpEdge.Size = New System.Drawing.Size(57, 20)
        Me.DetectUpEdge.TabIndex = 24
        Me.DetectUpEdge.Text = "する"
        Me.DetectUpEdge.Visible = False
        '
        'LabelGPIO3
        '
        Me.LabelGPIO3.AutoSize = True
        Me.LabelGPIO3.Location = New System.Drawing.Point(137, 90)
        Me.LabelGPIO3.Name = "LabelGPIO3"
        Me.LabelGPIO3.Size = New System.Drawing.Size(106, 12)
        Me.LabelGPIO3.TabIndex = 23
        Me.LabelGPIO3.Text = "立ち上がりエッジ検出"
        Me.LabelGPIO3.Visible = False
        '
        'Level
        '
        Me.Level.FormattingEnabled = True
        Me.Level.Items.AddRange(New Object() {"Low", "High"})
        Me.Level.Location = New System.Drawing.Point(139, 65)
        Me.Level.Name = "Level"
        Me.Level.Size = New System.Drawing.Size(57, 20)
        Me.Level.TabIndex = 22
        Me.Level.Text = "Low"
        Me.Level.Visible = False
        '
        'LabelGPIO2
        '
        Me.LabelGPIO2.AutoSize = True
        Me.LabelGPIO2.Location = New System.Drawing.Point(136, 50)
        Me.LabelGPIO2.Name = "LabelGPIO2"
        Me.LabelGPIO2.Size = New System.Drawing.Size(34, 12)
        Me.LabelGPIO2.TabIndex = 21
        Me.LabelGPIO2.Text = "レベル"
        Me.LabelGPIO2.Visible = False
        '
        'Mode
        '
        Me.Mode.FormattingEnabled = True
        Me.Mode.Items.AddRange(New Object() {"入力", "出力"})
        Me.Mode.Location = New System.Drawing.Point(139, 25)
        Me.Mode.Name = "Mode"
        Me.Mode.Size = New System.Drawing.Size(57, 20)
        Me.Mode.TabIndex = 20
        Me.Mode.Text = "入力"
        Me.Mode.Visible = False
        '
        'LabelGPIO1
        '
        Me.LabelGPIO1.AutoSize = True
        Me.LabelGPIO1.Location = New System.Drawing.Point(136, 10)
        Me.LabelGPIO1.Name = "LabelGPIO1"
        Me.LabelGPIO1.Size = New System.Drawing.Size(33, 12)
        Me.LabelGPIO1.TabIndex = 19
        Me.LabelGPIO1.Text = "モード"
        Me.LabelGPIO1.Visible = False
        '
        'TreeView1
        '
        Me.TreeView1.Location = New System.Drawing.Point(3, 6)
        Me.TreeView1.Name = "TreeView1"
        TreeNode36.Name = "GPIO03"
        TreeNode36.Text = "GPIO 03"
        TreeNode37.Name = "GPIO05"
        TreeNode37.Text = "GPIO 05"
        TreeNode38.Name = "GPIO07"
        TreeNode38.Text = "GPIO 07"
        TreeNode39.Name = "GPIO08"
        TreeNode39.Text = "GPIO 08"
        TreeNode40.Name = "GPIO10"
        TreeNode40.Text = "GPIO 10"
        TreeNode41.Name = "GPIO11"
        TreeNode41.Text = "GPIO 11"
        TreeNode42.Name = "GPIO12"
        TreeNode42.Text = "GPIO 12"
        TreeNode43.Name = "GPIO13"
        TreeNode43.Text = "GPIO 13"
        TreeNode44.Name = "GPIO15"
        TreeNode44.Text = "GPIO 15"
        TreeNode45.Name = "GPIO16"
        TreeNode45.Text = "GPIO 16"
        TreeNode46.Name = "GPIO18"
        TreeNode46.Text = "GPIO 18"
        TreeNode47.Name = "GPIO19"
        TreeNode47.Text = "GPIO 19"
        TreeNode48.Name = "GPIO21"
        TreeNode48.Text = "GPIO 21"
        TreeNode49.Name = "GPIO22"
        TreeNode49.Text = "GPIO 22"
        TreeNode50.Name = "GPIO23"
        TreeNode50.Text = "GPIO 23"
        TreeNode51.Name = "GPIO24"
        TreeNode51.Text = "GPIO 24"
        TreeNode52.Name = "GPIO26"
        TreeNode52.Text = "GPIO 26"
        TreeNode53.Name = "GPIO29"
        TreeNode53.Text = "GPIO 29"
        TreeNode54.Name = "GPIO31"
        TreeNode54.Text = "GPIO 31"
        TreeNode55.Name = "GPIO32"
        TreeNode55.Text = "GPIO 32"
        TreeNode56.Name = "GPIO33"
        TreeNode56.Text = "GPIO 33"
        TreeNode57.Name = "GPIO35"
        TreeNode57.Text = "GPIO 35"
        TreeNode58.Name = "GPIO36"
        TreeNode58.Text = "GPIO 36"
        TreeNode59.Name = "GPIO37"
        TreeNode59.Text = "GPIO 37"
        TreeNode60.Name = "GPIO38"
        TreeNode60.Text = "GPIO 38"
        TreeNode61.Name = "GPIO40"
        TreeNode61.Text = "GPIO 40"
        TreeNode62.Name = "SetGPIO"
        TreeNode62.Text = "GPIO"
        TreeNode63.Name = "UART"
        TreeNode63.Text = "UART"
        TreeNode64.Name = "SetUART"
        TreeNode64.Text = "UART"
        TreeNode65.Name = "SPI1"
        TreeNode65.Text = "SPI1"
        TreeNode66.Name = "SPI2"
        TreeNode66.Text = "SPI2"
        TreeNode67.Name = "SetSPI"
        TreeNode67.Text = "SPI"
        TreeNode68.Name = "I2C"
        TreeNode68.Text = "I2C"
        TreeNode69.Name = "SetI2C"
        TreeNode69.Text = "I2C"
        TreeNode70.Name = "Peripherals"
        TreeNode70.Text = "Peripherals"
        Me.TreeView1.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode70})
        Me.TreeView1.Size = New System.Drawing.Size(127, 452)
        Me.TreeView1.TabIndex = 0
        '
        'SavePrjFile
        '
        Me.SavePrjFile.DefaultExt = "rpprj"
        Me.SavePrjFile.Filter = "Raspberation プロジェクトファイル|*.rpprj||"
        '
        'SaveSrc
        '
        Me.SaveSrc.DefaultExt = "rpprj"
        Me.SaveSrc.Filter = "C言語ソースファイル|*.c"
        '
        'SetInfoSPI
        '
        Me.SetInfoSPI.Controls.Add(Me.TabPage2)
        Me.SetInfoSPI.Controls.Add(Me.TabPage3)
        Me.SetInfoSPI.Controls.Add(Me.TabPage4)
        Me.SetInfoSPI.Controls.Add(Me.TabPage6)
        Me.SetInfoSPI.Location = New System.Drawing.Point(136, 6)
        Me.SetInfoSPI.Name = "SetInfoSPI"
        Me.SetInfoSPI.SelectedIndex = 0
        Me.SetInfoSPI.Size = New System.Drawing.Size(632, 452)
        Me.SetInfoSPI.TabIndex = 37
        Me.SetInfoSPI.Visible = False
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.EnableTOH)
        Me.TabPage2.Controls.Add(Me.Label20)
        Me.TabPage2.Controls.Add(Me.EnableLoSSILongWord)
        Me.TabPage2.Controls.Add(Me.Label17)
        Me.TabPage2.Controls.Add(Me.EnableLoSSIDMA)
        Me.TabPage2.Controls.Add(Me.Label16)
        Me.TabPage2.Controls.Add(Me.CS2Polarity)
        Me.TabPage2.Controls.Add(Me.Label15)
        Me.TabPage2.Controls.Add(Me.CS1Polarity)
        Me.TabPage2.Controls.Add(Me.Label14)
        Me.TabPage2.Controls.Add(Me.CS0Polarity)
        Me.TabPage2.Controls.Add(Me.Label13)
        Me.TabPage2.Controls.Add(Me.EnableLoSSI)
        Me.TabPage2.Controls.Add(Me.Label12)
        Me.TabPage2.Controls.Add(Me.EnableRead)
        Me.TabPage2.Controls.Add(Me.Label11)
        Me.TabPage2.Controls.Add(Me.EnableADCS)
        Me.TabPage2.Controls.Add(Me.Label10)
        Me.TabPage2.Controls.Add(Me.EnableRXInterrupt)
        Me.TabPage2.Controls.Add(Me.Label9)
        Me.TabPage2.Controls.Add(Me.EnableTxInterrupt)
        Me.TabPage2.Controls.Add(Me.Label8)
        Me.TabPage2.Controls.Add(Me.EnableDMA)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.EnableTransfer)
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Controls.Add(Me.CSPolarity)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.CLEARFIFO)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.Label18)
        Me.TabPage2.Controls.Add(Me.ClockPolarity)
        Me.TabPage2.Controls.Add(Me.ChipSelect)
        Me.TabPage2.Controls.Add(Me.Label19)
        Me.TabPage2.Controls.Add(Me.Label21)
        Me.TabPage2.Controls.Add(Me.ClockPhase)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(624, 426)
        Me.TabPage2.TabIndex = 0
        Me.TabPage2.Text = "制御と状態"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'EnableTOH
        '
        Me.EnableTOH.FormattingEnabled = True
        Me.EnableTOH.Items.AddRange(New Object() {"しない", "する"})
        Me.EnableTOH.Location = New System.Drawing.Point(328, 226)
        Me.EnableTOH.Name = "EnableTOH"
        Me.EnableTOH.Size = New System.Drawing.Size(57, 20)
        Me.EnableTOH.TabIndex = 58
        Me.EnableTOH.Text = "しない"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(326, 211)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(207, 12)
        Me.Label20.TabIndex = 57
        Me.Label20.Text = "低速(LoSSI)モードでAPBクロック出力遅延"
        '
        'EnableLoSSILongWord
        '
        Me.EnableLoSSILongWord.FormattingEnabled = True
        Me.EnableLoSSILongWord.Items.AddRange(New Object() {"しない", "する"})
        Me.EnableLoSSILongWord.Location = New System.Drawing.Point(329, 185)
        Me.EnableLoSSILongWord.Name = "EnableLoSSILongWord"
        Me.EnableLoSSILongWord.Size = New System.Drawing.Size(57, 20)
        Me.EnableLoSSILongWord.TabIndex = 56
        Me.EnableLoSSILongWord.Text = "しない"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(326, 170)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(94, 12)
        Me.Label17.TabIndex = 55
        Me.Label17.Text = "32bitワード有効化"
        '
        'EnableLoSSIDMA
        '
        Me.EnableLoSSIDMA.FormattingEnabled = True
        Me.EnableLoSSIDMA.Items.AddRange(New Object() {"しない", "する"})
        Me.EnableLoSSIDMA.Location = New System.Drawing.Point(329, 144)
        Me.EnableLoSSIDMA.Name = "EnableLoSSIDMA"
        Me.EnableLoSSIDMA.Size = New System.Drawing.Size(57, 20)
        Me.EnableLoSSIDMA.TabIndex = 54
        Me.EnableLoSSIDMA.Text = "しない"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(326, 129)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(176, 12)
        Me.Label16.TabIndex = 53
        Me.Label16.Text = "低速(LOSSI)モードでDMAを有効化"
        '
        'CS2Polarity
        '
        Me.CS2Polarity.FormattingEnabled = True
        Me.CS2Polarity.Items.AddRange(New Object() {"アクティブローにする", "アクティブハイにする"})
        Me.CS2Polarity.Location = New System.Drawing.Point(329, 103)
        Me.CS2Polarity.Name = "CS2Polarity"
        Me.CS2Polarity.Size = New System.Drawing.Size(120, 20)
        Me.CS2Polarity.TabIndex = 52
        Me.CS2Polarity.Text = "アクティブローにする"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(326, 88)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(60, 12)
        Me.Label15.TabIndex = 51
        Me.Label15.Text = "CS2の状態"
        '
        'CS1Polarity
        '
        Me.CS1Polarity.FormattingEnabled = True
        Me.CS1Polarity.Items.AddRange(New Object() {"アクティブローにする", "アクティブハイにする"})
        Me.CS1Polarity.Location = New System.Drawing.Point(329, 62)
        Me.CS1Polarity.Name = "CS1Polarity"
        Me.CS1Polarity.Size = New System.Drawing.Size(120, 20)
        Me.CS1Polarity.TabIndex = 50
        Me.CS1Polarity.Text = "アクティブローにする"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(326, 47)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(60, 12)
        Me.Label14.TabIndex = 49
        Me.Label14.Text = "CS1の状態"
        '
        'CS0Polarity
        '
        Me.CS0Polarity.FormattingEnabled = True
        Me.CS0Polarity.Items.AddRange(New Object() {"アクティブローにする", "アクティブハイにする"})
        Me.CS0Polarity.Location = New System.Drawing.Point(329, 21)
        Me.CS0Polarity.Name = "CS0Polarity"
        Me.CS0Polarity.Size = New System.Drawing.Size(120, 20)
        Me.CS0Polarity.TabIndex = 48
        Me.CS0Polarity.Text = "アクティブローにする"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(326, 6)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(60, 12)
        Me.Label13.TabIndex = 47
        Me.Label13.Text = "CS0の状態"
        '
        'EnableLoSSI
        '
        Me.EnableLoSSI.FormattingEnabled = True
        Me.EnableLoSSI.Items.AddRange(New Object() {"高速(SPI)", "低速(LoSSI)"})
        Me.EnableLoSSI.Location = New System.Drawing.Point(151, 226)
        Me.EnableLoSSI.Name = "EnableLoSSI"
        Me.EnableLoSSI.Size = New System.Drawing.Size(77, 20)
        Me.EnableLoSSI.TabIndex = 46
        Me.EnableLoSSI.Text = "高速(SPI)"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(148, 211)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(57, 12)
        Me.Label12.TabIndex = 45
        Me.Label12.Text = "速度モード"
        '
        'EnableRead
        '
        Me.EnableRead.FormattingEnabled = True
        Me.EnableRead.Items.AddRange(New Object() {"SPIペリフェラルに書き込み", "SPI周辺機器から読み込み"})
        Me.EnableRead.Location = New System.Drawing.Point(151, 185)
        Me.EnableRead.Name = "EnableRead"
        Me.EnableRead.Size = New System.Drawing.Size(154, 20)
        Me.EnableRead.TabIndex = 44
        Me.EnableRead.Text = "SPIペリフェラルに書き込み"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(148, 170)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(72, 12)
        Me.Label11.TabIndex = 43
        Me.Label11.Text = "読み取り有効"
        '
        'EnableADCS
        '
        Me.EnableADCS.FormattingEnabled = True
        Me.EnableADCS.Items.AddRange(New Object() {"しない", "する"})
        Me.EnableADCS.Location = New System.Drawing.Point(152, 144)
        Me.EnableADCS.Name = "EnableADCS"
        Me.EnableADCS.Size = New System.Drawing.Size(57, 20)
        Me.EnableADCS.TabIndex = 42
        Me.EnableADCS.Text = "しない"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(149, 129)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(113, 12)
        Me.Label10.TabIndex = 41
        Me.Label10.Text = "チップセレクト自動解除"
        '
        'EnableRXInterrupt
        '
        Me.EnableRXInterrupt.FormattingEnabled = True
        Me.EnableRXInterrupt.Items.AddRange(New Object() {"無効", "有効"})
        Me.EnableRXInterrupt.Location = New System.Drawing.Point(151, 103)
        Me.EnableRXInterrupt.Name = "EnableRXInterrupt"
        Me.EnableRXInterrupt.Size = New System.Drawing.Size(57, 20)
        Me.EnableRXInterrupt.TabIndex = 40
        Me.EnableRXInterrupt.Text = "無効"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(148, 88)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(120, 12)
        Me.Label9.TabIndex = 39
        Me.Label9.Text = "受信完了割り込み設定"
        '
        'EnableTxInterrupt
        '
        Me.EnableTxInterrupt.FormattingEnabled = True
        Me.EnableTxInterrupt.Items.AddRange(New Object() {"無効", "有効"})
        Me.EnableTxInterrupt.Location = New System.Drawing.Point(151, 62)
        Me.EnableTxInterrupt.Name = "EnableTxInterrupt"
        Me.EnableTxInterrupt.Size = New System.Drawing.Size(57, 20)
        Me.EnableTxInterrupt.TabIndex = 38
        Me.EnableTxInterrupt.Text = "無効"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(148, 47)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(120, 12)
        Me.Label8.TabIndex = 37
        Me.Label8.Text = "送信完了割り込み設定"
        '
        'EnableDMA
        '
        Me.EnableDMA.FormattingEnabled = True
        Me.EnableDMA.Items.AddRange(New Object() {"無効", "有効"})
        Me.EnableDMA.Location = New System.Drawing.Point(151, 21)
        Me.EnableDMA.Name = "EnableDMA"
        Me.EnableDMA.Size = New System.Drawing.Size(57, 20)
        Me.EnableDMA.TabIndex = 36
        Me.EnableDMA.Text = "無効"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(148, 6)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(54, 12)
        Me.Label7.TabIndex = 35
        Me.Label7.Text = "DMA設定"
        '
        'EnableTransfer
        '
        Me.EnableTransfer.FormattingEnabled = True
        Me.EnableTransfer.Items.AddRange(New Object() {"無効", "有効"})
        Me.EnableTransfer.Location = New System.Drawing.Point(6, 226)
        Me.EnableTransfer.Name = "EnableTransfer"
        Me.EnableTransfer.Size = New System.Drawing.Size(57, 20)
        Me.EnableTransfer.TabIndex = 34
        Me.EnableTransfer.Text = "無効"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(3, 211)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 12)
        Me.Label6.TabIndex = 33
        Me.Label6.Text = "転送設定"
        '
        'CSPolarity
        '
        Me.CSPolarity.FormattingEnabled = True
        Me.CSPolarity.Items.AddRange(New Object() {"アクティブローにする", "アクティブハイにする"})
        Me.CSPolarity.Location = New System.Drawing.Point(6, 185)
        Me.CSPolarity.Name = "CSPolarity"
        Me.CSPolarity.Size = New System.Drawing.Size(120, 20)
        Me.CSPolarity.TabIndex = 32
        Me.CSPolarity.Text = "アクティブローにする"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 170)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 12)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "CSの状態"
        '
        'CLEARFIFO
        '
        Me.CLEARFIFO.FormattingEnabled = True
        Me.CLEARFIFO.Items.AddRange(New Object() {"何もしない", "TX FIFOクリア", "RX FIFOクリア"})
        Me.CLEARFIFO.Location = New System.Drawing.Point(6, 144)
        Me.CLEARFIFO.Name = "CLEARFIFO"
        Me.CLEARFIFO.Size = New System.Drawing.Size(92, 20)
        Me.CLEARFIFO.TabIndex = 30
        Me.CLEARFIFO.Text = "何もしない"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 129)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 12)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "CLEAR FIFOクリア"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(3, 6)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(20, 12)
        Me.Label18.TabIndex = 23
        Me.Label18.Text = "CS"
        '
        'ClockPolarity
        '
        Me.ClockPolarity.FormattingEnabled = True
        Me.ClockPolarity.Items.AddRange(New Object() {"Low", "High"})
        Me.ClockPolarity.Location = New System.Drawing.Point(6, 103)
        Me.ClockPolarity.Name = "ClockPolarity"
        Me.ClockPolarity.Size = New System.Drawing.Size(57, 20)
        Me.ClockPolarity.TabIndex = 28
        Me.ClockPolarity.Text = "Low"
        '
        'ChipSelect
        '
        Me.ChipSelect.FormattingEnabled = True
        Me.ChipSelect.Items.AddRange(New Object() {"CS 0", "CS 1", "CS 2"})
        Me.ChipSelect.Location = New System.Drawing.Point(6, 21)
        Me.ChipSelect.Name = "ChipSelect"
        Me.ChipSelect.Size = New System.Drawing.Size(57, 20)
        Me.ChipSelect.TabIndex = 24
        Me.ChipSelect.Text = "CS 0"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(3, 88)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(107, 12)
        Me.Label19.TabIndex = 27
        Me.Label19.Text = "クロック休止時の状態"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(3, 47)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(85, 12)
        Me.Label21.TabIndex = 25
        Me.Label21.Text = "クロック遷移位置"
        '
        'ClockPhase
        '
        Me.ClockPhase.FormattingEnabled = True
        Me.ClockPhase.Items.AddRange(New Object() {"データビットの中央", "データビットの始まり"})
        Me.ClockPhase.Location = New System.Drawing.Point(6, 62)
        Me.ClockPhase.Name = "ClockPhase"
        Me.ClockPhase.Size = New System.Drawing.Size(123, 20)
        Me.ClockPhase.TabIndex = 26
        Me.ClockPhase.Text = "データビットの中央"
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.ClockUnit)
        Me.TabPage3.Controls.Add(Me.ClockFreq)
        Me.TabPage3.Controls.Add(Me.Label22)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(624, 426)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "クロック"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'ClockUnit
        '
        Me.ClockUnit.FormattingEnabled = True
        Me.ClockUnit.Items.AddRange(New Object() {"MHz", "kHz"})
        Me.ClockUnit.Location = New System.Drawing.Point(51, 20)
        Me.ClockUnit.Name = "ClockUnit"
        Me.ClockUnit.Size = New System.Drawing.Size(57, 20)
        Me.ClockUnit.TabIndex = 25
        Me.ClockUnit.Text = "MHz"
        '
        'ClockFreq
        '
        Me.ClockFreq.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.ClockFreq.Location = New System.Drawing.Point(8, 21)
        Me.ClockFreq.Name = "ClockFreq"
        Me.ClockFreq.Size = New System.Drawing.Size(37, 19)
        Me.ClockFreq.TabIndex = 1
        Me.ClockFreq.Text = "20"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(6, 6)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(117, 12)
        Me.Label22.TabIndex = 0
        Me.Label22.Text = "クロック(通信速度)設定"
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.TransferSize)
        Me.TabPage4.Controls.Add(Me.Label23)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(624, 426)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "データ長"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'TransferSize
        '
        Me.TransferSize.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.TransferSize.Location = New System.Drawing.Point(8, 21)
        Me.TransferSize.Name = "TransferSize"
        Me.TransferSize.Size = New System.Drawing.Size(68, 19)
        Me.TransferSize.TabIndex = 3
        Me.TransferSize.Text = "1"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(6, 6)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(143, 12)
        Me.Label23.TabIndex = 2
        Me.Label23.Text = "転送するバイト数(0～65535)"
        '
        'TabPage6
        '
        Me.TabPage6.Controls.Add(Me.ReadPanicThreshold)
        Me.TabPage6.Controls.Add(Me.Label24)
        Me.TabPage6.Controls.Add(Me.ReadRequestThreshold)
        Me.TabPage6.Controls.Add(Me.Label25)
        Me.TabPage6.Controls.Add(Me.WritePanicThreshold)
        Me.TabPage6.Controls.Add(Me.Label26)
        Me.TabPage6.Controls.Add(Me.WriteRequestThreshold)
        Me.TabPage6.Controls.Add(Me.Label27)
        Me.TabPage6.Location = New System.Drawing.Point(4, 22)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage6.Size = New System.Drawing.Size(624, 426)
        Me.TabPage6.TabIndex = 5
        Me.TabPage6.Text = "DMA DREQ制御"
        Me.TabPage6.ToolTipText = "外部DMAエンジンへのDREQ信号及びパニック信号の生成を制御します。DREQ信号はFIFOが定義されたレベルに達してサービスを必要とするときに生成されます。パニ" &
    "ック信号は外部DMAエンジンにAXI要求の優先順位を上げるよう指示します。"
        Me.TabPage6.UseVisualStyleBackColor = True
        '
        'ReadPanicThreshold
        '
        Me.ReadPanicThreshold.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.ReadPanicThreshold.Location = New System.Drawing.Point(8, 141)
        Me.ReadPanicThreshold.Name = "ReadPanicThreshold"
        Me.ReadPanicThreshold.Size = New System.Drawing.Size(68, 19)
        Me.ReadPanicThreshold.TabIndex = 11
        Me.ReadPanicThreshold.Text = "0"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(6, 126)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(191, 12)
        Me.Label24.TabIndex = 10
        Me.Label24.Text = "DMA読み取りパニックしきい値(0～255)"
        '
        'ReadRequestThreshold
        '
        Me.ReadRequestThreshold.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.ReadRequestThreshold.Location = New System.Drawing.Point(8, 101)
        Me.ReadRequestThreshold.Name = "ReadRequestThreshold"
        Me.ReadRequestThreshold.Size = New System.Drawing.Size(68, 19)
        Me.ReadRequestThreshold.TabIndex = 9
        Me.ReadRequestThreshold.Text = "0"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(6, 86)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(181, 12)
        Me.Label25.TabIndex = 8
        Me.Label25.Text = "DMA読み取り要求しきい値(0～255)"
        '
        'WritePanicThreshold
        '
        Me.WritePanicThreshold.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.WritePanicThreshold.Location = New System.Drawing.Point(8, 61)
        Me.WritePanicThreshold.Name = "WritePanicThreshold"
        Me.WritePanicThreshold.Size = New System.Drawing.Size(68, 19)
        Me.WritePanicThreshold.TabIndex = 7
        Me.WritePanicThreshold.Text = "0"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(6, 46)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(192, 12)
        Me.Label26.TabIndex = 6
        Me.Label26.Text = "DMA書き込みパニックしきい値(0～255)"
        '
        'WriteRequestThreshold
        '
        Me.WriteRequestThreshold.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.WriteRequestThreshold.Location = New System.Drawing.Point(8, 21)
        Me.WriteRequestThreshold.Name = "WriteRequestThreshold"
        Me.WriteRequestThreshold.Size = New System.Drawing.Size(68, 19)
        Me.WriteRequestThreshold.TabIndex = 5
        Me.WriteRequestThreshold.Text = "0"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(6, 6)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(182, 12)
        Me.Label27.TabIndex = 4
        Me.Label27.Text = "DMA書き込み要求しきい値(0～255)"
        '
        'Raspberation_UI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Raspberation_UI"
        Me.Text = "Raspberation"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.BaseSettings.ResumeLayout(False)
        Me.BaseSettings.PerformLayout()
        Me.PinSettings.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.SetInfoSPI.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        Me.TabPage6.ResumeLayout(False)
        Me.TabPage6.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ファイルToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 名前をつけて保存ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 上書き保存ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 開くToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 終了ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ヘルプToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ヘルプの表示ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RaspberationについてToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents LoadPrj As ToolStripButton
    Friend WithEvents SavePrj As ToolStripButton
    Friend WithEvents GenSRC As ToolStripButton
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents BaseSettings As TabPage
    Friend WithEvents PinSettings As TabPage
    Friend WithEvents GenMakefile As TabPage
    Friend WithEvents UsedModel As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents SelectPrjPath As Button
    Friend WithEvents SavePrjPath As TextBox
    Friend WithEvents SavePrjFile As SaveFileDialog
    Friend WithEvents LoadPrjFile As OpenFileDialog
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents SelectSrcPath As Button
    Friend WithEvents SaveSrcPath As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents SaveSrc As SaveFileDialog
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TreeView1 As TreeView
    Friend WithEvents SelectPullUpDown As ComboBox
    Friend WithEvents LabelGPIO9 As Label
    Friend WithEvents DetectAsyncDownEdge As ComboBox
    Friend WithEvents LabelGPIO8 As Label
    Friend WithEvents DetectAsyncUpEdge As ComboBox
    Friend WithEvents LabelGPIO7 As Label
    Friend WithEvents DetectLowLevel As ComboBox
    Friend WithEvents LabelGPIO6 As Label
    Friend WithEvents DetectHighLevel As ComboBox
    Friend WithEvents LabelGPIO5 As Label
    Friend WithEvents DetectDownEdge As ComboBox
    Friend WithEvents LabelGPIO4 As Label
    Friend WithEvents DetectUpEdge As ComboBox
    Friend WithEvents LabelGPIO3 As Label
    Friend WithEvents Level As ComboBox
    Friend WithEvents LabelGPIO2 As Label
    Friend WithEvents Mode As ComboBox
    Friend WithEvents LabelGPIO1 As Label
    Friend WithEvents SetInfoSPI As TabControl
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents EnableTOH As ComboBox
    Friend WithEvents Label20 As Label
    Friend WithEvents EnableLoSSILongWord As ComboBox
    Friend WithEvents Label17 As Label
    Friend WithEvents EnableLoSSIDMA As ComboBox
    Friend WithEvents Label16 As Label
    Friend WithEvents CS2Polarity As ComboBox
    Friend WithEvents Label15 As Label
    Friend WithEvents CS1Polarity As ComboBox
    Friend WithEvents Label14 As Label
    Friend WithEvents CS0Polarity As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents EnableLoSSI As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents EnableRead As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents EnableADCS As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents EnableRXInterrupt As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents EnableTxInterrupt As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents EnableDMA As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents EnableTransfer As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents CSPolarity As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents CLEARFIFO As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents ClockPolarity As ComboBox
    Friend WithEvents ChipSelect As ComboBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents ClockPhase As ComboBox
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents ClockUnit As ComboBox
    Friend WithEvents ClockFreq As TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents TransferSize As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents TabPage6 As TabPage
    Friend WithEvents ReadPanicThreshold As TextBox
    Friend WithEvents Label24 As Label
    Friend WithEvents ReadRequestThreshold As TextBox
    Friend WithEvents Label25 As Label
    Friend WithEvents WritePanicThreshold As TextBox
    Friend WithEvents Label26 As Label
    Friend WithEvents WriteRequestThreshold As TextBox
    Friend WithEvents Label27 As Label
End Class
