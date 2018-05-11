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
        Me.SuspendLayout()
        '
        'GPIOpinNo
        '
        Me.GPIOpinNo.AutoSize = True
        Me.GPIOpinNo.Location = New System.Drawing.Point(52, 84)
        Me.GPIOpinNo.Name = "GPIOpinNo"
        Me.GPIOpinNo.Size = New System.Drawing.Size(38, 12)
        Me.GPIOpinNo.TabIndex = 0
        Me.GPIOpinNo.Text = "Label1"
        '
        'PinSetting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.GPIOpinNo)
        Me.Name = "PinSetting"
        Me.Text = "PinSetting"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GPIOpinNo As Label
End Class
