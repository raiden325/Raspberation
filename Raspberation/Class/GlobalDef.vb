Public Class GlobalDef
    '座標構造体
    Structure Point
        Dim PointX As Integer
        Dim PointY As Integer
    End Structure

    '座標範囲構造体
    Structure Area
        Dim First As Point
        Dim Last As Point
    End Structure

    '_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/
    'GPIO設定情報構造体
    Structure GPIOSettingInfo
        Dim PinNo As Integer
        Dim Mode As Integer
        Dim Level As Integer
        Dim DetectUpEdge As Boolean
        Dim DetectDownEdge As Boolean
        Dim DetectHighLevel As Boolean
        Dim DetectLowLevel As Boolean
        Dim DetectAsyncUpEdge As Boolean
        Dim DetectAsyncDownEdge As Boolean
        Dim SelectPullUpDown As Integer
    End Structure

    'GPIOモード列挙体
    Enum GPIOMode
        Input
        Output
    End Enum

    'GPIOレベル列挙体
    Enum GPIOLevel
        Low
        High
    End Enum

    'GPIOプルアップ・ダウン列挙体
    Enum GPIOPull
        None
        PullUp
        PullDown
    End Enum

    '_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/
    'SPI設定情報構造体
    Structure SPISettingInfo
        Dim PinNo As Integer
    End Structure

    '_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/
    'UART設定情報構造体
    Structure UARTSettingInfo
        Dim PinNo As Integer
    End Structure

    '_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/
    'I2C設定情報構造体
    Structure I2CSettingInfo
        Dim PinNo As Integer
    End Structure

    '_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/
    'ピン設定情報構造体      PinNoと要素番号を合わせるため1オリジンとする
    Structure PinSettingInfo
        Dim UseFunc As Integer
        Dim GPIO As GPIOSettingInfo
        Dim SPI As SPISettingInfo
        Dim UART As UARTSettingInfo
        Dim I2C As I2CSettingInfo
    End Structure

    'ピン機能列挙体
    Enum PinFunc
        NotUsed
        GPIO
        SPI
        UART
        I2C
    End Enum

    '_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/
    '画像のピン位置座標変数
    Public PinArea(40) As Area

    '_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/
    Public Sub New()
        Dim i As Integer
        For i = 0 To 39 Step 2
            PinArea(i + 1).First.PointX = (i / 2) * 19 + 72
            PinArea(i + 1).First.PointY = 19
            PinArea(i + 1).Last.PointX = (i / 2) * 19 + 86
            PinArea(i + 1).Last.PointY = 35
            PinArea(i).First.PointX = (i / 2) * 19 + 72
            PinArea(i).First.PointY = 42
            PinArea(i).Last.PointX = (i / 2) * 19 + 86
            PinArea(i).Last.PointY = 58
        Next i
    End Sub
End Class
