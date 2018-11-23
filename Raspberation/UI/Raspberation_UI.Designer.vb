<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Me.SettingGrid = New System.Windows.Forms.DataGridView()
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
        Me.SetItem = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SetValue = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.BaseSettings.SuspendLayout()
        Me.PinSettings.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage1.SuspendLayout()
        CType(Me.SettingGrid, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.TabPage1.Controls.Add(Me.SettingGrid)
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
        'SettingGrid
        '
        Me.SettingGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SettingGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SetItem, Me.SetValue})
        Me.SettingGrid.Location = New System.Drawing.Point(312, 6)
        Me.SettingGrid.Name = "SettingGrid"
        Me.SettingGrid.RowTemplate.Height = 21
        Me.SettingGrid.Size = New System.Drawing.Size(456, 452)
        Me.SettingGrid.TabIndex = 37
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
        'SetItem
        '
        Me.SetItem.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.SetItem.HeaderText = "設定項目"
        Me.SetItem.Name = "SetItem"
        Me.SetItem.ReadOnly = True
        Me.SetItem.Width = 78
        '
        'SetValue
        '
        Me.SetValue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.SetValue.HeaderText = "設定値"
        Me.SetValue.Name = "SetValue"
        Me.SetValue.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.SetValue.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.SetValue.Width = 66
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
        CType(Me.SettingGrid, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents SettingGrid As DataGridView
    Friend WithEvents SetItem As DataGridViewTextBoxColumn
    Friend WithEvents SetValue As DataGridViewComboBoxColumn
End Class
