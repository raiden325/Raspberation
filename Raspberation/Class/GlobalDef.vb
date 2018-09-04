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
        Dim Mode As GPIOMode
        Dim Level As GPIOLevel
        Dim DetectUpEdge As Boolean
        Dim DetectDownEdge As Boolean
        Dim DetectHighLevel As Boolean
        Dim DetectLowLevel As Boolean
        Dim DetectAsyncUpEdge As Boolean
        Dim DetectAsyncDownEdge As Boolean
        Dim SelectPullUpDown As GPIOPull
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
        Dim ChipSelect As SPIChipSelect
        Dim ClockPhase As SPIClockPhase
        Dim ClockPolarity As SPIClockPolarity
        Dim CLEARFIFO As SPIClEARFIFO
        Dim CSPolarity As SPICSPolarity
        Dim EnableTransfer As Boolean
        Dim EnableDMA As Boolean
        Dim EnableTXInterrupt As Boolean
        Dim EnableRXInterrupt As Boolean
        Dim EnableADCS As Boolean
        Dim EnableRead As SPIEnableRead
        Dim EnableLoSSI As SPIMode
        Dim CSPolarity0 As SPICSPolarity
        Dim CSPolarity1 As SPICSPolarity
        Dim CSPolarity2 As SPICSPolarity
        Dim EnableLoSSIDMA As Boolean
        Dim EnableLoSSILongWord As Boolean
        Dim EnableTOH As Boolean
        Dim TxClockFreq As Integer
        Dim TransferSize As Integer
        Dim WriteRequestThreshold As Integer
        Dim WritePanicThreshold As Integer
        Dim ReadRequestThreshold As Integer
        Dim ReadPanicThreshold As Integer
    End Structure

    'チップセレクト
    Enum SPIChipSelect
        CS0
        CS1
        CS2
    End Enum

    'クロック遷移位置列挙体
    Enum SPIClockPhase
        Middle
        Begining
    End Enum

    'クロック休止状態の状態
    Enum SPIClockPolarity
        Low
        High
    End Enum

    'CLEAR FIFOクリア
    Enum SPIClEARFIFO
        NO_ACUTION
        CLEAR_TX
        CLEAR_RX
    End Enum

    'CSの状態
    Enum SPICSPolarity
        ACTIVE_LOW
        ACTIVE_HIGH
    End Enum

    '読み取り有効
    Enum SPIEnableRead
        WRITE_SPI
        READ_SPI
    End Enum

    '速度モード(高速SPIモード、低速LoSSIモード)
    Enum SPIMode
        SPI
        LoSSI
    End Enum

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
