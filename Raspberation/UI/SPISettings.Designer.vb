<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SPISettings
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
        Me.components = New System.ComponentModel.Container()
        Me.Cancell = New System.Windows.Forms.Button()
        Me.OK = New System.Windows.Forms.Button()
        Me.ChipSelect = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ClockPhase = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ClockPolarity = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
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
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.CS0Polarity = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.CS1Polarity = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.CS2Polarity = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.EnableLoSSIDMA = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.EnableLoSSILongWord = New System.Windows.Forms.ComboBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.ClockNum = New System.Windows.Forms.TextBox()
        Me.ClockUnit = New System.Windows.Forms.ComboBox()
        Me.TransferSize = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.EnableTOH = New System.Windows.Forms.ComboBox()
        Me.WriteRequestThreshold = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.WritePanicThreshold = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.ReadRequestThreshold = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.ReadPanicThreshold = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.PinNo = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.TabPage6.SuspendLayout()
        Me.SuspendLayout()
        '
        'Cancell
        '
        Me.Cancell.Location = New System.Drawing.Point(408, 308)
        Me.Cancell.Name = "Cancell"
        Me.Cancell.Size = New System.Drawing.Size(75, 23)
        Me.Cancell.TabIndex = 22
        Me.Cancell.Text = "キャンセル"
        Me.Cancell.UseVisualStyleBackColor = True
        '
        'OK
        '
        Me.OK.Location = New System.Drawing.Point(102, 308)
        Me.OK.Name = "OK"
        Me.OK.Size = New System.Drawing.Size(75, 23)
        Me.OK.TabIndex = 21
        Me.OK.Text = "OK"
        Me.OK.UseVisualStyleBackColor = True
        '
        'ChipSelect
        '
        Me.ChipSelect.FormattingEnabled = True
        Me.ChipSelect.Items.AddRange(New Object() {"CS 0", "CS 1", "CS 2"})
        Me.ChipSelect.Location = New System.Drawing.Point(6, 21)
        Me.ChipSelect.Name = "ChipSelect"
        Me.ChipSelect.Size = New System.Drawing.Size(57, 20)
        Me.ChipSelect.TabIndex = 24
        Me.ChipSelect.Text = " CS 0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(20, 12)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "CS"
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 12)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "クロック遷移位置"
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
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 12)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "クロック休止時の状態"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage6)
        Me.TabControl1.Location = New System.Drawing.Point(12, 24)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(560, 278)
        Me.TabControl1.TabIndex = 29
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.EnableTOH)
        Me.TabPage1.Controls.Add(Me.Label20)
        Me.TabPage1.Controls.Add(Me.EnableLoSSILongWord)
        Me.TabPage1.Controls.Add(Me.Label17)
        Me.TabPage1.Controls.Add(Me.EnableLoSSIDMA)
        Me.TabPage1.Controls.Add(Me.Label16)
        Me.TabPage1.Controls.Add(Me.CS2Polarity)
        Me.TabPage1.Controls.Add(Me.Label15)
        Me.TabPage1.Controls.Add(Me.CS1Polarity)
        Me.TabPage1.Controls.Add(Me.Label14)
        Me.TabPage1.Controls.Add(Me.CS0Polarity)
        Me.TabPage1.Controls.Add(Me.Label13)
        Me.TabPage1.Controls.Add(Me.EnableLoSSI)
        Me.TabPage1.Controls.Add(Me.Label12)
        Me.TabPage1.Controls.Add(Me.EnableRead)
        Me.TabPage1.Controls.Add(Me.Label11)
        Me.TabPage1.Controls.Add(Me.EnableADCS)
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Controls.Add(Me.EnableRXInterrupt)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.EnableTxInterrupt)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.EnableDMA)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.EnableTransfer)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.CSPolarity)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.CLEARFIFO)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.ClockPolarity)
        Me.TabPage1.Controls.Add(Me.ChipSelect)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.ClockPhase)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(552, 252)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "制御と状態"
        Me.TabPage1.UseVisualStyleBackColor = True
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
        Me.ToolTip1.SetToolTip(Me.Label12, "SPIが低速シリアルインターフェースとして構成されている場合ここで低速を設定します。")
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
        Me.ToolTip1.SetToolTip(Me.Label11, "双方向モードを使用している場合はここで設定します。SPIペリフェラルがデータを送信できるようになります。")
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
        Me.ToolTip1.SetToolTip(Me.Label7, "ペリフェラルはデータ要求を生成します。これらは、SPIDLENに達するまで4バイトワード単位で取り込まれます。")
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
        Me.ToolTip1.SetToolTip(Me.Label4, "CLEARとTAが両方とも同じ動作で設定されている場合、FIFOは新しいフレームが開始される前にクリアされます。０として読み込みます。")
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.ClockUnit)
        Me.TabPage3.Controls.Add(Me.ClockNum)
        Me.TabPage3.Controls.Add(Me.Label18)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(502, 252)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "クロック"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.TransferSize)
        Me.TabPage4.Controls.Add(Me.Label19)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(552, 252)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "データ長"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'TabPage6
        '
        Me.TabPage6.Controls.Add(Me.ReadPanicThreshold)
        Me.TabPage6.Controls.Add(Me.Label24)
        Me.TabPage6.Controls.Add(Me.ReadRequestThreshold)
        Me.TabPage6.Controls.Add(Me.Label23)
        Me.TabPage6.Controls.Add(Me.WritePanicThreshold)
        Me.TabPage6.Controls.Add(Me.Label22)
        Me.TabPage6.Controls.Add(Me.WriteRequestThreshold)
        Me.TabPage6.Controls.Add(Me.Label21)
        Me.TabPage6.Location = New System.Drawing.Point(4, 22)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage6.Size = New System.Drawing.Size(552, 252)
        Me.TabPage6.TabIndex = 5
        Me.TabPage6.Text = "DMA DREQ制御"
        Me.TabPage6.ToolTipText = "外部DMAエンジンへのDREQ信号及びパニック信号の生成を制御します。DREQ信号はFIFOが定義されたレベルに達してサービスを必要とするときに生成されます。パニ" &
    "ック信号は外部DMAエンジンにAXI要求の優先順位を上げるよう指示します。"
        Me.TabPage6.UseVisualStyleBackColor = True
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
        Me.ToolTip1.SetToolTip(Me.Label17, "低速(LoSSI)モードでDMAが有効のとき、32bitワードを有効化します。")
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(6, 6)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(117, 12)
        Me.Label18.TabIndex = 0
        Me.Label18.Text = "クロック(通信速度)設定"
        '
        'ClockNum
        '
        Me.ClockNum.Location = New System.Drawing.Point(8, 21)
        Me.ClockNum.Name = "ClockNum"
        Me.ClockNum.Size = New System.Drawing.Size(68, 19)
        Me.ClockNum.TabIndex = 1
        '
        'ClockUnit
        '
        Me.ClockUnit.FormattingEnabled = True
        Me.ClockUnit.Items.AddRange(New Object() {"MHz", "kHz"})
        Me.ClockUnit.Location = New System.Drawing.Point(82, 21)
        Me.ClockUnit.Name = "ClockUnit"
        Me.ClockUnit.Size = New System.Drawing.Size(57, 20)
        Me.ClockUnit.TabIndex = 25
        Me.ClockUnit.Text = "MHz"
        '
        'TransferSize
        '
        Me.TransferSize.Location = New System.Drawing.Point(8, 21)
        Me.TransferSize.Name = "TransferSize"
        Me.TransferSize.Size = New System.Drawing.Size(68, 19)
        Me.TransferSize.TabIndex = 3
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(6, 6)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(87, 12)
        Me.Label19.TabIndex = 2
        Me.Label19.Text = "転送するバイト数"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(326, 211)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(207, 12)
        Me.Label20.TabIndex = 57
        Me.Label20.Text = "低速(LoSSI)モードでAPBクロック出力遅延"
        Me.ToolTip1.SetToolTip(Me.Label20, "有効化すると1クロック遅延を引き起こします。")
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
        'WriteRequestThreshold
        '
        Me.WriteRequestThreshold.Location = New System.Drawing.Point(8, 21)
        Me.WriteRequestThreshold.Name = "WriteRequestThreshold"
        Me.WriteRequestThreshold.Size = New System.Drawing.Size(68, 19)
        Me.WriteRequestThreshold.TabIndex = 5
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(6, 6)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(182, 12)
        Me.Label21.TabIndex = 4
        Me.Label21.Text = "DMA書き込み要求しきい値(0～255)"
        Me.ToolTip1.SetToolTip(Me.Label21, "TX FIFOレベルがこの量以下であるときは常に、TX DMAエンジンへのDREQ信号を生成します。")
        '
        'WritePanicThreshold
        '
        Me.WritePanicThreshold.Location = New System.Drawing.Point(8, 61)
        Me.WritePanicThreshold.Name = "WritePanicThreshold"
        Me.WritePanicThreshold.Size = New System.Drawing.Size(68, 19)
        Me.WritePanicThreshold.TabIndex = 7
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(6, 46)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(192, 12)
        Me.Label22.TabIndex = 6
        Me.Label22.Text = "DMA書き込みパニックしきい値(0～255)"
        Me.ToolTip1.SetToolTip(Me.Label22, "TX FIFOレベルがこの量以下の場合は、TX DMAエンジンへのパニック信号を生成します。")
        '
        'ReadRequestThreshold
        '
        Me.ReadRequestThreshold.Location = New System.Drawing.Point(8, 101)
        Me.ReadRequestThreshold.Name = "ReadRequestThreshold"
        Me.ReadRequestThreshold.Size = New System.Drawing.Size(68, 19)
        Me.ReadRequestThreshold.TabIndex = 9
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(6, 86)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(181, 12)
        Me.Label23.TabIndex = 8
        Me.Label23.Text = "DMA読み取り要求しきい値(0～255)"
        Me.ToolTip1.SetToolTip(Me.Label23, "RX FIFOレベルがこの量より大きい場合は常に、RX DMAエンジンにDREQを生成します（転送が完了してもRXFIFOが空でない場合はRX DREQも生成され" &
        "ます）。")
        '
        'ReadPanicThreshold
        '
        Me.ReadPanicThreshold.Location = New System.Drawing.Point(8, 141)
        Me.ReadPanicThreshold.Name = "ReadPanicThreshold"
        Me.ReadPanicThreshold.Size = New System.Drawing.Size(68, 19)
        Me.ReadPanicThreshold.TabIndex = 11
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(6, 126)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(191, 12)
        Me.Label24.TabIndex = 10
        Me.Label24.Text = "DMA読み取りパニックしきい値(0～255)"
        Me.ToolTip1.SetToolTip(Me.Label24, "RX FIFOレベルがこの値より大きいときは常に、RX DMAエンジンへのパニック信号を生成します。")
        '
        'PinNo
        '
        Me.PinNo.AutoSize = True
        Me.PinNo.Location = New System.Drawing.Point(12, 9)
        Me.PinNo.Name = "PinNo"
        Me.PinNo.Size = New System.Drawing.Size(61, 12)
        Me.PinNo.TabIndex = 30
        Me.PinNo.Text = "Pin番号 00"
        '
        'SPISettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 340)
        Me.Controls.Add(Me.PinNo)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Cancell)
        Me.Controls.Add(Me.OK)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SPISettings"
        Me.Text = "SPI詳細設定"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        Me.TabPage6.ResumeLayout(False)
        Me.TabPage6.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Cancell As Button
    Friend WithEvents OK As Button
    Friend WithEvents ChipSelect As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ClockPhase As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ClockPolarity As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents EnableRead As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents ToolTip1 As ToolTip
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
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents TabPage6 As TabPage
    Friend WithEvents EnableLoSSI As ComboBox
    Friend WithEvents Label12 As Label
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
    Friend WithEvents EnableTOH As ComboBox
    Friend WithEvents Label20 As Label
    Friend WithEvents ClockUnit As ComboBox
    Friend WithEvents ClockNum As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents TransferSize As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents ReadPanicThreshold As TextBox
    Friend WithEvents Label24 As Label
    Friend WithEvents ReadRequestThreshold As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents WritePanicThreshold As TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents WriteRequestThreshold As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents PinNo As Label
End Class
