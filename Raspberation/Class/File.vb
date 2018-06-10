'_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/
'ファイルの保存と読み込みを提供するクラス
'_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/
Public Class File
    '_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/
    '引数で受け取った情報をファイルに保存する
    'FP:ファイルパス
    'Buf:書き込む内容
    '_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/
    Function SaveFile(ByRef FP As String, ByRef Buf As String)
        Dim sw As New System.IO.StreamWriter(FP, False, System.Text.Encoding.GetEncoding("UTF-8"))
        'Bufの内容を書き込む
        sw.Write(Buf)
        '閉じる
        sw.Close()
        Return 0
    End Function

    '_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/
    'ファイルから一行読み出す
    'FP:ファイルパス
    'Buf:一行データ
    'Row:読み込む行
    '_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/
    Sub ReadRowFromFile(ByRef FP As String, ByRef Buf As String, ByVal Row As Integer, ByRef EOF As Boolean)
        Dim sr As New System.IO.StreamReader(FP, System.Text.Encoding.Default)
        Dim i As Integer = 0
        Dim tBuf As String = ""
        EOF = True
        While (sr.Peek() >= 0)
            If (i = Row) Then
                EOF = False
                Exit While
            Else
                tBuf = sr.ReadLine()
                i += 1
            End If
        End While
        Buf = tBuf
        sr.Close()
    End Sub

    'ファイルから一文字読み出す

    '_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/
    'ディレクトリを作成する
    'DP:ディレクトリパス
    '_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/
    Sub CreateDirectry(ByRef DP As String)
        Dim di As System.IO.DirectoryInfo
        Try
            di = System.IO.Directory.CreateDirectory(DP)
        Catch ex As System.IO.IOException
            'フォルダが存在する
            MsgBox("フォルダが存在します")
        Catch ex As UnauthorizedAccessException
            'アクセス許可が無い
            MsgBox("アクセス許可がありません")
        End Try
    End Sub
End Class
