<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PinSetting
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
        Me.GPIOpinNo = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.UseGPIO = New System.Windows.Forms.RadioButton()
        Me.UseSPI = New System.Windows.Forms.RadioButton()
        Me.UseUART = New System.Windows.Forms.RadioButton()
        Me.UseI2C = New System.Windows.Forms.RadioButton()
        Me.NextSetting = New System.Windows.Forms.Button()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GPIOpinNo
        '
        Me.GPIOpinNo.AutoSize = True
        Me.GPIOpinNo.Location = New System.Drawing.Point(12, 9)
        Me.GPIOpinNo.Name = "GPIOpinNo"
        Me.GPIOpinNo.Size = New System.Drawing.Size(47, 12)
        Me.GPIOpinNo.TabIndex = 0
        Me.GPIOpinNo.Text = "GPIO 00"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.UseI2C)
        Me.GroupBox1.Controls.Add(Me.UseUART)
        Me.GroupBox1.Controls.Add(Me.UseSPI)
        Me.GroupBox1.Controls.Add(Me.UseGPIO)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 24)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(183, 111)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "機能設定"
        '
        'UseGPIO
        '
        Me.UseGPIO.AutoSize = True
        Me.UseGPIO.Location = New System.Drawing.Point(6, 18)
        Me.UseGPIO.Name = "UseGPIO"
        Me.UseGPIO.Size = New System.Drawing.Size(49, 16)
        Me.UseGPIO.TabIndex = 0
        Me.UseGPIO.TabStop = True
        Me.UseGPIO.Text = "GPIO"
        Me.UseGPIO.UseVisualStyleBackColor = True
        '
        'UseSPI
        '
        Me.UseSPI.AutoSize = True
        Me.UseSPI.Location = New System.Drawing.Point(6, 40)
        Me.UseSPI.Name = "UseSPI"
        Me.UseSPI.Size = New System.Drawing.Size(40, 16)
        Me.UseSPI.TabIndex = 1
        Me.UseSPI.TabStop = True
        Me.UseSPI.Text = "SPI"
        Me.UseSPI.UseVisualStyleBackColor = True
        '
        'UseUART
        '
        Me.UseUART.AutoSize = True
        Me.UseUART.Location = New System.Drawing.Point(6, 62)
        Me.UseUART.Name = "UseUART"
        Me.UseUART.Size = New System.Drawing.Size(54, 16)
        Me.UseUART.TabIndex = 2
        Me.UseUART.TabStop = True
        Me.UseUART.Text = "UART"
        Me.UseUART.UseVisualStyleBackColor = True
        '
        'UseI2C
        '
        Me.UseI2C.AutoSize = True
        Me.UseI2C.Location = New System.Drawing.Point(6, 84)
        Me.UseI2C.Name = "UseI2C"
        Me.UseI2C.Size = New System.Drawing.Size(40, 16)
        Me.UseI2C.TabIndex = 3
        Me.UseI2C.TabStop = True
        Me.UseI2C.Text = "I2C"
        Me.UseI2C.UseVisualStyleBackColor = True
        '
        'NextSetting
        '
        Me.NextSetting.Location = New System.Drawing.Point(12, 141)
        Me.NextSetting.Name = "NextSetting"
        Me.NextSetting.Size = New System.Drawing.Size(75, 23)
        Me.NextSetting.TabIndex = 2
        Me.NextSetting.Text = "次へ"
        Me.NextSetting.UseVisualStyleBackColor = True
        '
        'Cancel
        '
        Me.Cancel.Location = New System.Drawing.Point(120, 141)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(75, 23)
        Me.Cancel.TabIndex = 3
        Me.Cancel.Text = "キャンセル"
        Me.Cancel.UseVisualStyleBackColor = True
        '
        'PinSetting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(207, 171)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.NextSetting)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GPIOpinNo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "PinSetting"
        Me.Text = "Pin詳細設定"
        Me.TopMost = True
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GPIOpinNo As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents UseI2C As RadioButton
    Friend WithEvents UseUART As RadioButton
    Friend WithEvents UseSPI As RadioButton
    Friend WithEvents UseGPIO As RadioButton
    Friend WithEvents NextSetting As Button
    Friend WithEvents Cancel As Button
End Class
