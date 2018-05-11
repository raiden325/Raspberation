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
        For i = 0 To 39 Step 1
            PinArea(i).First.PointX = 0
            PinArea(i).First.PointY = 0
            PinArea(i).Last.PointX = 0
            PinArea(i).Last.PointY = 0
        Next i
    End Sub
End Class
