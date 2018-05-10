<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Version
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
        Me.ver = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ver
        '
        Me.ver.AutoSize = True
        Me.ver.Location = New System.Drawing.Point(13, 13)
        Me.ver.Name = "ver"
        Me.ver.Size = New System.Drawing.Size(42, 12)
        Me.ver.TabIndex = 0
        Me.ver.Text = "version"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(13, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(211, 35)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "RaspberationはRaspberry PiのIO設定を自動生成するためのソフトです。"
        '
        'Version
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(236, 84)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ver)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Version"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Raspberationについて"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ver As Label
    Friend WithEvents Label1 As Label
End Class
