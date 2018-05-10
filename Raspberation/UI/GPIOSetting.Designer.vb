<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GPIOSetting
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
        Me.PinNo = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.IOMode = New System.Windows.Forms.ComboBox()
        Me.Level = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.RiseEdgeEnable = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.FallEdgeEnable = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.HighDetectEnable = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LowDetectEnable = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.AsycFallEdge = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.AsycRiseEdgeEnable = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.PullUpDown = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.OK = New System.Windows.Forms.Button()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'PinNo
        '
        Me.PinNo.AutoSize = True
        Me.PinNo.Location = New System.Drawing.Point(12, 9)
        Me.PinNo.Name = "PinNo"
        Me.PinNo.Size = New System.Drawing.Size(43, 12)
        Me.PinNo.TabIndex = 0
        Me.PinNo.Text = "GPIO00"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 12)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "モード"
        '
        'IOMode
        '
        Me.IOMode.FormattingEnabled = True
        Me.IOMode.Items.AddRange(New Object() {"入力", "出力"})
        Me.IOMode.Location = New System.Drawing.Point(14, 44)
        Me.IOMode.Name = "IOMode"
        Me.IOMode.Size = New System.Drawing.Size(48, 20)
        Me.IOMode.TabIndex = 2
        Me.IOMode.Text = "入力"
        '
        'Level
        '
        Me.Level.FormattingEnabled = True
        Me.Level.Items.AddRange(New Object() {"Low", "High"})
        Me.Level.Location = New System.Drawing.Point(162, 44)
        Me.Level.Name = "Level"
        Me.Level.Size = New System.Drawing.Size(48, 20)
        Me.Level.TabIndex = 4
        Me.Level.Text = "Low"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(160, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 12)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "レベル"
        '
        'RiseEdgeEnable
        '
        Me.RiseEdgeEnable.FormattingEnabled = True
        Me.RiseEdgeEnable.Items.AddRange(New Object() {"する", "しない"})
        Me.RiseEdgeEnable.Location = New System.Drawing.Point(14, 86)
        Me.RiseEdgeEnable.Name = "RiseEdgeEnable"
        Me.RiseEdgeEnable.Size = New System.Drawing.Size(48, 20)
        Me.RiseEdgeEnable.TabIndex = 6
        Me.RiseEdgeEnable.Text = "する"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 12)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "立ち上がりエッジ検出"
        '
        'FallEdgeEnable
        '
        Me.FallEdgeEnable.FormattingEnabled = True
        Me.FallEdgeEnable.Items.AddRange(New Object() {"する", "しない"})
        Me.FallEdgeEnable.Location = New System.Drawing.Point(162, 86)
        Me.FallEdgeEnable.Name = "FallEdgeEnable"
        Me.FallEdgeEnable.Size = New System.Drawing.Size(48, 20)
        Me.FallEdgeEnable.TabIndex = 8
        Me.FallEdgeEnable.Text = "する"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(160, 71)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(106, 12)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "立ち下がりエッジ検出"
        '
        'HighDetectEnable
        '
        Me.HighDetectEnable.FormattingEnabled = True
        Me.HighDetectEnable.Items.AddRange(New Object() {"する", "しない"})
        Me.HighDetectEnable.Location = New System.Drawing.Point(14, 127)
        Me.HighDetectEnable.Name = "HighDetectEnable"
        Me.HighDetectEnable.Size = New System.Drawing.Size(48, 20)
        Me.HighDetectEnable.TabIndex = 10
        Me.HighDetectEnable.Text = "する"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 112)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 12)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "ハイレベル検出"
        '
        'LowDetectEnable
        '
        Me.LowDetectEnable.FormattingEnabled = True
        Me.LowDetectEnable.Items.AddRange(New Object() {"する", "しない"})
        Me.LowDetectEnable.Location = New System.Drawing.Point(162, 127)
        Me.LowDetectEnable.Name = "LowDetectEnable"
        Me.LowDetectEnable.Size = New System.Drawing.Size(48, 20)
        Me.LowDetectEnable.TabIndex = 12
        Me.LowDetectEnable.Text = "する"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(160, 112)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(77, 12)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "ローレベル検出"
        '
        'AsycFallEdge
        '
        Me.AsycFallEdge.FormattingEnabled = True
        Me.AsycFallEdge.Items.AddRange(New Object() {"する", "しない"})
        Me.AsycFallEdge.Location = New System.Drawing.Point(162, 168)
        Me.AsycFallEdge.Name = "AsycFallEdge"
        Me.AsycFallEdge.Size = New System.Drawing.Size(48, 20)
        Me.AsycFallEdge.TabIndex = 16
        Me.AsycFallEdge.Text = "する"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(160, 153)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(142, 12)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "非同期立ち下がりエッジ検出"
        '
        'AsycRiseEdgeEnable
        '
        Me.AsycRiseEdgeEnable.FormattingEnabled = True
        Me.AsycRiseEdgeEnable.Items.AddRange(New Object() {"する", "しない"})
        Me.AsycRiseEdgeEnable.Location = New System.Drawing.Point(14, 168)
        Me.AsycRiseEdgeEnable.Name = "AsycRiseEdgeEnable"
        Me.AsycRiseEdgeEnable.Size = New System.Drawing.Size(48, 20)
        Me.AsycRiseEdgeEnable.TabIndex = 14
        Me.AsycRiseEdgeEnable.Text = "する"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 153)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(142, 12)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "非同期立ち上がりエッジ検出"
        '
        'PullUpDown
        '
        Me.PullUpDown.FormattingEnabled = True
        Me.PullUpDown.Items.AddRange(New Object() {"しない", "プルダウン", "プルアップ"})
        Me.PullUpDown.Location = New System.Drawing.Point(14, 209)
        Me.PullUpDown.Name = "PullUpDown"
        Me.PullUpDown.Size = New System.Drawing.Size(87, 20)
        Me.PullUpDown.TabIndex = 18
        Me.PullUpDown.Text = "しない"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(12, 194)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(125, 12)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "プルアップ・プルダウン選択"
        '
        'OK
        '
        Me.OK.Location = New System.Drawing.Point(43, 236)
        Me.OK.Name = "OK"
        Me.OK.Size = New System.Drawing.Size(75, 23)
        Me.OK.TabIndex = 19
        Me.OK.Text = "OK"
        Me.OK.UseVisualStyleBackColor = True
        '
        'Cancel
        '
        Me.Cancel.Location = New System.Drawing.Point(162, 236)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(75, 23)
        Me.Cancel.TabIndex = 20
        Me.Cancel.Text = "キャンセル"
        Me.Cancel.UseVisualStyleBackColor = True
        '
        'GPIOSetting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(307, 271)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.OK)
        Me.Controls.Add(Me.PullUpDown)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.AsycFallEdge)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.AsycRiseEdgeEnable)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.LowDetectEnable)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.HighDetectEnable)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.FallEdgeEnable)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.RiseEdgeEnable)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Level)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.IOMode)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PinNo)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "GPIOSetting"
        Me.Text = "GPIOSetting"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PinNo As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents IOMode As ComboBox
    Friend WithEvents Level As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents RiseEdgeEnable As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents FallEdgeEnable As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents HighDetectEnable As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents LowDetectEnable As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents AsycFallEdge As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents AsycRiseEdgeEnable As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents PullUpDown As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents OK As Button
    Friend WithEvents Cancel As Button
End Class
