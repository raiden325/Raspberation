Public Class PinSetting
    'ピン番号によって、有効化する機能の定義
    'TODO:Raspberry Pi 3 model B以外も対応するなら、定義を追加すること
    Private PinFunc_Pi3B(,) As Boolean = {  'GPIO, SPI, UART, I2C
        {False, False, False, False},   'GPIO 01
        {False, False, False, False},   'GPIO 02
        {True, False, False, True},     'GPIO 03
        {False, False, False, False},   'GPIO 04
        {True, False, False, True},     'GPIO 05
        {False, False, False, False},   'GPIO 06
        {True, False, False, False},    'GPIO 07
        {True, False, True, False},     'GPIO 08
        {False, False, False, False},   'GPIO 09
        {True, False, True, False},     'GPIO 10
        {True, False, False, False},    'GPIO 11
        {True, False, False, False},    'GPIO 12
        {True, False, False, False},    'GPIO 13
        {False, False, False, False},   'GPIO 14
        {True, False, False, False},    'GPIO 15
        {True, False, False, False},    'GPIO 16
        {False, False, False, False},   'GPIO 17
        {True, False, False, False},    'GPIO 18
        {True, True, False, False},     'GPIO 19
        {False, False, False, False},   'GPIO 20
        {True, True, False, False},     'GPIO 21
        {True, False, False, False},    'GPIO 22
        {True, True, False, False},     'GPIO 23
        {True, True, False, False},     'GPIO 24
        {False, False, False, False},   'GPIO 25
        {True, True, False, False},     'GPIO 26
        {False, False, False, True},    'GPIO 27
        {False, False, False, True},    'GPIO 28
        {True, False, False, False},    'GPIO 29
        {False, False, False, False},   'GPIO 30
        {True, False, False, False},    'GPIO 31
        {True, False, False, False},    'GPIO 32
        {True, False, False, False},    'GPIO 33
        {False, False, False, False},   'GPIO 34
        {True, False, False, False},    'GPIO 35
        {True, False, False, False},    'GPIO 36
        {True, False, False, False},    'GPIO 37
        {True, False, False, False},    'GPIO 38
        {False, False, False, False},   'GPIO 39
        {True, False, False, False}     'GPIO 40
        }

    Private Sub PinSetting_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        '押されたピン番号によって、有効化するラジオボタンを決定する
        Dim SelectPin As Integer
        SelectPin = GPIOpinNo.Text.Substring(5)
        '使用モデルで切替必要
        'TODO:今後対応モデルを増やす場合は、別ファイルで定義するか、ソフト内部にハードコードするか検討が必要
        UseGPIO.Enabled = PinFunc_Pi3B(SelectPin - 1, 0)
        UseSPI.Enabled = PinFunc_Pi3B(SelectPin - 1, 1)
        UseUART.Enabled = PinFunc_Pi3B(SelectPin - 1, 2)
        UseI2C.Enabled = PinFunc_Pi3B(SelectPin - 1, 3)
    End Sub

    Private Sub NextSetting_Click(ByVal sender As Object, ByVal e As EventArgs) Handles NextSetting.Click
        '選択されたボタンに応じて、呼び出す設定画面を変える
        Dim SelectPin As Integer
        SelectPin = GPIOpinNo.Text.Substring(5)
        If (UseGPIO.Checked = True) Then
            'GPIO設定を呼び出す
            GPIOSettings.Show()
            GPIOSettings.PinNo.Text = "GPIO " & SelectPin
            Me.Close()
        ElseIf (UseSPI.Checked = True) Then
            'SPI設定を呼び出す
        ElseIf (UseUART.Checked = True) Then
            'UART設定を呼び出す
        ElseIf (UseI2C.Checked = True) Then
            'I2C設定を呼び出す
        End If
    End Sub

    Private Sub Cancel_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Cancel.Click
        'キャンセル -> フォームを閉じる
        Me.Close()
    End Sub
End Class