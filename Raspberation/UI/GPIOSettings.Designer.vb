<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GPIOSettings
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
        Me.Mode = New System.Windows.Forms.ComboBox()
        Me.Level = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DetectUpEdge = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DetectDownEdge = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DetectHighLevel = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DetectLowLevel = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DetectAsyncUpEdge = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DetectAsyncDownEdge = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.SelectPullUpDown = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.OK = New System.Windows.Forms.Button()
        Me.Cancell = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'PinNo
        '
        Me.PinNo.AutoSize = True
        Me.PinNo.Location = New System.Drawing.Point(13, 13)
        Me.PinNo.Name = "PinNo"
        Me.PinNo.Size = New System.Drawing.Size(47, 12)
        Me.PinNo.TabIndex = 0
        Me.PinNo.Text = "GPIO 00"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 12)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "モード"
        '
        'Mode
        '
        Me.Mode.FormattingEnabled = True
        Me.Mode.Items.AddRange(New Object() {"入力", "出力"})
        Me.Mode.Location = New System.Drawing.Point(15, 47)
        Me.Mode.Name = "Mode"
        Me.Mode.Size = New System.Drawing.Size(57, 20)
        Me.Mode.TabIndex = 2
        Me.Mode.Text = "入力"
        '
        'Level
        '
        Me.Level.FormattingEnabled = True
        Me.Level.Items.AddRange(New Object() {"Low", "High"})
        Me.Level.Location = New System.Drawing.Point(163, 47)
        Me.Level.Name = "Level"
        Me.Level.Size = New System.Drawing.Size(57, 20)
        Me.Level.TabIndex = 4
        Me.Level.Text = "Low"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(160, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 12)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "レベル"
        '
        'DetectUpEdge
        '
        Me.DetectUpEdge.FormattingEnabled = True
        Me.DetectUpEdge.Items.AddRange(New Object() {"する", "しない"})
        Me.DetectUpEdge.Location = New System.Drawing.Point(15, 88)
        Me.DetectUpEdge.Name = "DetectUpEdge"
        Me.DetectUpEdge.Size = New System.Drawing.Size(57, 20)
        Me.DetectUpEdge.TabIndex = 6
        Me.DetectUpEdge.Text = "する"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 12)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "立ち上がりエッジ検出"
        '
        'DetectDownEdge
        '
        Me.DetectDownEdge.FormattingEnabled = True
        Me.DetectDownEdge.Items.AddRange(New Object() {"する", "しない"})
        Me.DetectDownEdge.Location = New System.Drawing.Point(163, 88)
        Me.DetectDownEdge.Name = "DetectDownEdge"
        Me.DetectDownEdge.Size = New System.Drawing.Size(57, 20)
        Me.DetectDownEdge.TabIndex = 8
        Me.DetectDownEdge.Text = "する"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(160, 73)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(106, 12)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "立ち下がりエッジ検出"
        '
        'DetectHighLevel
        '
        Me.DetectHighLevel.FormattingEnabled = True
        Me.DetectHighLevel.Items.AddRange(New Object() {"する", "しない"})
        Me.DetectHighLevel.Location = New System.Drawing.Point(15, 129)
        Me.DetectHighLevel.Name = "DetectHighLevel"
        Me.DetectHighLevel.Size = New System.Drawing.Size(57, 20)
        Me.DetectHighLevel.TabIndex = 10
        Me.DetectHighLevel.Text = "する"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 114)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 12)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "ハイレベル検出"
        '
        'DetectLowLevel
        '
        Me.DetectLowLevel.FormattingEnabled = True
        Me.DetectLowLevel.Items.AddRange(New Object() {"する", "しない"})
        Me.DetectLowLevel.Location = New System.Drawing.Point(163, 129)
        Me.DetectLowLevel.Name = "DetectLowLevel"
        Me.DetectLowLevel.Size = New System.Drawing.Size(57, 20)
        Me.DetectLowLevel.TabIndex = 12
        Me.DetectLowLevel.Text = "する"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(160, 114)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(77, 12)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "ローレベル検出"
        '
        'DetectAsyncUpEdge
        '
        Me.DetectAsyncUpEdge.FormattingEnabled = True
        Me.DetectAsyncUpEdge.Items.AddRange(New Object() {"する", "しない"})
        Me.DetectAsyncUpEdge.Location = New System.Drawing.Point(16, 170)
        Me.DetectAsyncUpEdge.Name = "DetectAsyncUpEdge"
        Me.DetectAsyncUpEdge.Size = New System.Drawing.Size(57, 20)
        Me.DetectAsyncUpEdge.TabIndex = 14
        Me.DetectAsyncUpEdge.Text = "する"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(13, 155)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(142, 12)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "非同期立ち上がりエッジ検出"
        '
        'DetectAsyncDownEdge
        '
        Me.DetectAsyncDownEdge.FormattingEnabled = True
        Me.DetectAsyncDownEdge.Items.AddRange(New Object() {"する", "しない"})
        Me.DetectAsyncDownEdge.Location = New System.Drawing.Point(164, 170)
        Me.DetectAsyncDownEdge.Name = "DetectAsyncDownEdge"
        Me.DetectAsyncDownEdge.Size = New System.Drawing.Size(57, 20)
        Me.DetectAsyncDownEdge.TabIndex = 16
        Me.DetectAsyncDownEdge.Text = "する"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(161, 155)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(142, 12)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "非同期立ち上がりエッジ検出"
        '
        'SelectPullUpDown
        '
        Me.SelectPullUpDown.FormattingEnabled = True
        Me.SelectPullUpDown.Items.AddRange(New Object() {"しない", "プルアップ", "プルダウン"})
        Me.SelectPullUpDown.Location = New System.Drawing.Point(15, 211)
        Me.SelectPullUpDown.Name = "SelectPullUpDown"
        Me.SelectPullUpDown.Size = New System.Drawing.Size(88, 20)
        Me.SelectPullUpDown.TabIndex = 18
        Me.SelectPullUpDown.Text = "しない"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(12, 196)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(125, 12)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "プルアップ・プルダウン選択"
        '
        'OK
        '
        Me.OK.Location = New System.Drawing.Point(43, 240)
        Me.OK.Name = "OK"
        Me.OK.Size = New System.Drawing.Size(75, 23)
        Me.OK.TabIndex = 19
        Me.OK.Text = "OK"
        Me.OK.UseVisualStyleBackColor = True
        '
        'Cancell
        '
        Me.Cancell.Location = New System.Drawing.Point(164, 240)
        Me.Cancell.Name = "Cancell"
        Me.Cancell.Size = New System.Drawing.Size(75, 23)
        Me.Cancell.TabIndex = 20
        Me.Cancell.Text = "キャンセル"
        Me.Cancell.UseVisualStyleBackColor = True
        '
        'GPIOSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(313, 275)
        Me.Controls.Add(Me.Cancell)
        Me.Controls.Add(Me.OK)
        Me.Controls.Add(Me.SelectPullUpDown)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.DetectAsyncDownEdge)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.DetectAsyncUpEdge)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.DetectLowLevel)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.DetectHighLevel)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.DetectDownEdge)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.DetectUpEdge)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Level)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Mode)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PinNo)
        Me.Name = "GPIOSettings"
        Me.Text = "GPIO詳細設定"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PinNo As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Mode As ComboBox
    Friend WithEvents Level As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents DetectUpEdge As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents DetectDownEdge As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents DetectHighLevel As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents DetectLowLevel As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents DetectAsyncUpEdge As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents DetectAsyncDownEdge As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents SelectPullUpDown As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents OK As Button
    Friend WithEvents Cancell As Button
End Class
