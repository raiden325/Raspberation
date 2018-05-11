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

    '画像のピン位置座標変数
    Public PinArea(40) As Area

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
