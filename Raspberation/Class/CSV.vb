﻿'_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/
'CSVファイルを扱うクラス
'_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/
Public Class CSV
    '_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/
    'カンマ区切りの文字列を分解して配列に格納する
    'Buf:文字列
    'Array():格納する配列
    'ArrayElem:格納する配列の要素数または格納したい数
    '_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/
    Sub SplitStrStoreArray(ByRef Buf As String, ByRef Array() As String, ByVal ArrayElem As Integer)
        Dim i As Integer = 0
        Dim elem As Integer = 0
        For i = 0 To Buf.Length - 1 Step 1
            If (elem < ArrayElem) Then
                If (Buf(i) = ",") Then
                    elem += 1
                Else
                    Array(elem) &= Buf(i)
                End If
            Else
                Exit For
            End If
        Next
    End Sub

    '_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/
    '配列をカンマ区切りの文字列にする
    '_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/
End Class