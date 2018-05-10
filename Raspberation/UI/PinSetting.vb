'_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/
'ピンの機能を選択するフォーム
'_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/

Public Class PinSetting
    '変数宣言
    Dim PinFuncTbl(,) As Boolean =
        {'GPIO   SPI    UART   I2C
        {False, False, False, False},  '1
        {False, False, False, False},  '2
        {True, False, False, True},    '3
        {False, False, False, False},  '4
        {True, False, False, True},    '5
        {False, False, False, False},  '6
        {True, False, False, False},   '7
        {True, False, True, False},    '8
        {False, False, False, False},  '9
        {True, False, True, False},    '10
        {True, False, False, False},   '11
        {True, False, False, False},   '12
        {True, False, False, False},   '13
        {False, False, False, False},  '14
        {True, False, False, False},   '15
        {True, False, False, False},   '16
        {False, False, False, False},  '17
        {True, False, False, False},   '18
        {True, True, False, False},    '19
        {False, False, False, False},  '20
        {True, True, False, False},    '21
        {True, False, False, False},   '22
        {True, True, False, False},    '23
        {True, True, False, False},    '24
        {False, False, False, False},  '25
        {True, True, False, False},    '26
        {False, False, False, True},   '27
        {False, False, False, True},   '28
        {True, False, False, False},   '29
        {False, False, False, False},  '30
        {True, False, False, False},   '31
        {True, False, False, False},   '32
        {True, False, False, False},   '33
        {False, False, False, False},  '34
        {True, False, False, False},   '35
        {True, False, False, False},   '36
        {True, False, False, False},   '37
        {True, False, False, False},   '38
        {False, False, False, False},  '39
        {True, False, False, False}}   '40
    '_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/
    'ピン詳細設定画面がロードされた時の処理
    '_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/
    Private Sub PinSetting_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'ピン番号から、GPIO,SPI,UART,I2Cの使用可能なものだけ表示する
        Dim s As String = Me.GPIOpinNo.Text.Substring(4)
        Dim PinNo As Integer = CInt(s)
        Dim j As Integer
        For j = 0 To 3 Step 1
            If (PinFuncTbl(PinNo - 1, j) <> True) Then
                Select Case (j + 1)
                    Case GlobalDef.PinFunc.GPIO
                        Me.UseGPIO.Enabled = False
                    Case GlobalDef.PinFunc.SPI
                        Me.UseSPI.Enabled = False
                    Case GlobalDef.PinFunc.UART
                        Me.UseUART.Enabled = False
                    Case GlobalDef.PinFunc.I2C
                        Me.UseI2C.Enabled = False
                End Select
            End If
        Next j
        '全てのピン機能が使用不可の場合は次へボタンを無効化
        If (Me.UseGPIO.Enabled = False _
        And Me.UseSPI.Enabled = False _
        And Me.UseUART.Enabled = False _
        And Me.UseI2C.Enabled = False) Then
            Me.NextSetting.Enabled = False
        End If
    End Sub

    '_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/
    '次へボタンが押された時の処理
    '_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/
    Private Sub NextSetting_Click(sender As Object, e As EventArgs) Handles NextSetting.Click
        '機能設定から詳細設定用フォームを呼び出す
        Me.Close()
        Dim SelectPinFunc As Integer
        If (UseGPIO.Checked) Then
            SelectPinFunc = GlobalDef.PinFunc.GPIO
            GPIOSetting.Show()
        ElseIf (UseSPI.Checked) Then
            SelectPinFunc = GlobalDef.PinFunc.SPI
            SPISetting.Show()
        ElseIf (UseUART.Checked) Then
            SelectPinFunc = GlobalDef.PinFunc.UART
        ElseIf (UseI2C.Checked) Then
            SelectPinFunc = GlobalDef.PinFunc.I2C
        Else
            MsgBox("ピン機能を選択していません。")
            Exit Sub
        End If
        '設定内容をモジュールへ渡す
    End Sub

    '_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/
    'キャンセルボタンが押された時の処理
    '_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/
    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        '閉じる
        Me.Close()
    End Sub
End Class
