Public Class SPISettings
    Private Sub OK_Click(sender As Object, e As EventArgs) Handles OK.Click
        '設定データを保持する
        Dim Info As GlobalDef.SPISettingInfo
        Info.PinNo = PinNo.Text.Substring(6)
        'データを格納する
        '画面を閉じる
        Me.Close()
    End Sub

    Private Sub Cancell_Click(sender As Object, e As EventArgs) Handles Cancell.Click
        '画面を閉じる
        Me.Close()
    End Sub
End Class