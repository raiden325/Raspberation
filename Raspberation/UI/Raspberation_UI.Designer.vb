<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Raspberation_UI
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
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

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Raspberation_UI))
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
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.BaseSettings = New System.Windows.Forms.TabPage()
        Me.SelectSrcPath = New System.Windows.Forms.Button()
        Me.SaveSrcPath = New System.Windows.Forms.TextBox()
        Me.UsedModel = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PinSettings = New System.Windows.Forms.TabPage()
        Me.GenMakefile = New System.Windows.Forms.TabPage()
        Me.SavePrjFile = New System.Windows.Forms.SaveFileDialog()
        Me.LoadPrjFile = New System.Windows.Forms.OpenFileDialog()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.BaseSettings.SuspendLayout()
        Me.PinSettings.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripButton2, Me.ToolStripButton3})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 24)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(784, 25)
        Me.ToolStrip1.TabIndex = 2
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton1.Text = "ToolStripButton1"
        Me.ToolStripButton1.ToolTipText = "LoadPrj"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton2.Text = "ToolStripButton2"
        Me.ToolStripButton2.ToolTipText = "SavePrj"
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton3.Text = "ToolStripButton3"
        Me.ToolStripButton3.ToolTipText = "GenerateSRC"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.BaseSettings)
        Me.TabControl1.Controls.Add(Me.PinSettings)
        Me.TabControl1.Controls.Add(Me.GenMakefile)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 49)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(784, 490)
        Me.TabControl1.TabIndex = 3
        '
        'BaseSettings
        '
        Me.BaseSettings.Controls.Add(Me.SelectSrcPath)
        Me.BaseSettings.Controls.Add(Me.SaveSrcPath)
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
        Me.SelectSrcPath.Location = New System.Drawing.Point(695, 20)
        Me.SelectSrcPath.Name = "SelectSrcPath"
        Me.SelectSrcPath.Size = New System.Drawing.Size(75, 23)
        Me.SelectSrcPath.TabIndex = 6
        Me.SelectSrcPath.Text = "選択"
        Me.SelectSrcPath.UseVisualStyleBackColor = True
        '
        'SaveSrcPath
        '
        Me.SaveSrcPath.Location = New System.Drawing.Point(10, 22)
        Me.SaveSrcPath.Name = "SaveSrcPath"
        Me.SaveSrcPath.Size = New System.Drawing.Size(679, 19)
        Me.SaveSrcPath.TabIndex = 5
        '
        'UsedModel
        '
        Me.UsedModel.FormattingEnabled = True
        Me.UsedModel.Items.AddRange(New Object() {"Raspberry Pi 3 model B"})
        Me.UsedModel.Location = New System.Drawing.Point(91, 47)
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
        Me.Label2.Location = New System.Drawing.Point(8, 50)
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
        'GenMakefile
        '
        Me.GenMakefile.Location = New System.Drawing.Point(4, 22)
        Me.GenMakefile.Name = "GenMakefile"
        Me.GenMakefile.Size = New System.Drawing.Size(776, 464)
        Me.GenMakefile.TabIndex = 2
        Me.GenMakefile.Text = "makefile生成"
        Me.GenMakefile.UseVisualStyleBackColor = True
        '
        'SavePrjFile
        '
        Me.SavePrjFile.DefaultExt = "rpprj"
        Me.SavePrjFile.Filter = "Raspberation プロジェクトファイル|*.rpprj||"
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
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents ToolStripButton3 As ToolStripButton
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents BaseSettings As TabPage
    Friend WithEvents PinSettings As TabPage
    Friend WithEvents GenMakefile As TabPage
    Friend WithEvents UsedModel As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents SelectSrcPath As Button
    Friend WithEvents SaveSrcPath As TextBox
    Friend WithEvents SavePrjFile As SaveFileDialog
    Friend WithEvents LoadPrjFile As OpenFileDialog
    Friend WithEvents PictureBox1 As PictureBox
End Class
