Public Class PinSetting
    'ピン番号によって、有効化する機能の定義
    'TODO:Raspberry Pi 3 model B以外も対応するなら、定義を追加すること
    Private PinFunc_Pi3B(,) As Boolean = {  'GPIO, SPI, UART, I2C
        {False, False, False, False},   'GPIO 01
        {False, False, False, False},   'GPIO 02
        {False, False, False, False},   'GPIO 03
        {False, False, False, False},   'GPIO 04
        {False, False, False, False},   'GPIO 05
        {False, False, False, False},   'GPIO 06
        {False, False, False, False},   'GPIO 07
        {False, False, False, False},   'GPIO 08
        {False, False, False, False},   'GPIO 09
        {False, False, False, False},   'GPIO 10
        {False, False, False, False},   'GPIO 11
        {False, False, False, False},   'GPIO 12
        {False, False, False, False},   'GPIO 13
        {False, False, False, False},   'GPIO 14
        {False, False, False, False},   'GPIO 15
        {False, False, False, False},   'GPIO 16
        {False, False, False, False},   'GPIO 17
        {False, False, False, False},   'GPIO 18
        {False, False, False, False},   'GPIO 19
        {False, False, False, False},   'GPIO 20
        {False, False, False, False},   'GPIO 21
        {False, False, False, False},   'GPIO 22
        {False, False, False, False},   'GPIO 23
        {False, False, False, False},   'GPIO 24
        {False, False, False, False},   'GPIO 25
        {False, False, False, False},   'GPIO 26
        {False, False, False, False},   'GPIO 27
        {False, False, False, False},   'GPIO 28
        {False, False, False, False},   'GPIO 29
        {False, False, False, False},   'GPIO 30
        {False, False, False, False},   'GPIO 31
        {False, False, False, False},   'GPIO 32
        {False, False, False, False},   'GPIO 33
        {False, False, False, False},   'GPIO 34
        {False, False, False, False},   'GPIO 35
        {False, False, False, False},   'GPIO 36
        {False, False, False, False},   'GPIO 37
        {False, False, False, False},   'GPIO 38
        {False, False, False, False},   'GPIO 39
        {False, False, False, False}    'GPIO 40
        }

    Private Sub PinSetting_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        '押されたピン番号によって、有効化するラジオボタンを決定する
        Dim SelectPin As Integer
        SelectPin = GPIOpinNo.Text.Substring(5)

        UseGPIO.Enabled = PinFunc_Pi3B(SelectPin - 1, 0)
        UseSPI.Enabled = PinFunc_Pi3B(SelectPin - 1, 1)
        UseUART.Enabled = PinFunc_Pi3B(SelectPin - 1, 2)
        UseI2C.Enabled = PinFunc_Pi3B(SelectPin - 1, 3)
    End Sub

    Private Sub NextSetting_Click(sender As Object, e As EventArgs) Handles NextSetting.Click
        '選択されたボタンに応じて、呼び出す設定画面を変える
    End Sub

    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        'キャンセル -> フォームを閉じる
        Me.Close()
    End Sub
End Class