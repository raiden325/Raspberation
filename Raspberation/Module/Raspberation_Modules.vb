'_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/
'ユーザー操作を受けて、実際に処理をするための関数群
'_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/
Module Raspberation_Modules
    '構造体定義
    Structure EnFunc
        Dim GPIO As Boolean
        Dim UART As Boolean
        Dim SPI As Boolean
        Dim I2C As Boolean
    End Structure
    '_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/
    'ファイルスコープ変数の宣言
    '_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/
    Private SavePrjFlg As Boolean = False
    Private LoadFilePath As String = ""

    'Private Subs or Functions
    '_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/
    'ベースソースコードから読み出して、設定を反映したバッファを生成する
    '_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/
    Private Function GenBuf(ByRef Buf As String, ByVal EnableFuction As EnFunc)
        'NOTE: ベースのソースコードに//G等で機能反映箇所を特定する
        '//G数字で設定する項目を判定する
        Dim tBuf As String = ""
        Dim Row As Integer = 1
        Dim EOFflag As Boolean = False
        Dim fobj As File = New File
        'ベースのソースコード読み出し
        While (EOFflag = False)
            fobj.ReadRowFromFile("./def/main.c", tBuf, Row, EOFflag)
            'Buf内容解析
            AnalysisBuf(tBuf, EnableFuction)
            If (tBuf <> "NUR") Then
                Buf = Buf & tBuf & vbCrLf
            End If
            Row = Row + 1
        End While
        Return 0
    End Function

    '_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/
    'バッファを解析し、設定を反映する
    '_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/
    Private Function AnalysisBuf(ByRef Buf As String, ByVal EnableFunction As EnFunc)
        Dim fPtr As Integer '文字列発見位置
        Dim FStr() As String =
            {
                "",
                "//G",
                "//U",
                "//S",
                "//I"
            }
        Dim i As Integer
        For i = 1 To 4 Step 1
            fPtr = Buf.IndexOf(FStr(i))
            If (fPtr <> -1) Then

                If (EnableFunction.GPIO = True And i = GlobalDef.PinFunc.GPIO) Then
                    Buf = Buf.Substring(4)
                ElseIf (EnableFunction.UART = True And i = GlobalDef.PinFunc.UART) Then
                    Buf = Buf.Substring(4)
                ElseIf (EnableFunction.SPI = True And i = GlobalDef.PinFunc.SPI) Then
                    Buf = Buf.Substring(4)
                ElseIf (EnableFunction.I2C = True And i = GlobalDef.PinFunc.I2C) Then
                    Buf = Buf.Substring(4)
                Else
                    '不要な行は消す
                    Buf = "NUR"
                End If
            End If
        Next i

        Return 0
    End Function

    '_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/
    '有効化されている機能を調査する
    '_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/
    Private Function FindActiveFunction(ByRef PinInfo() As GlobalDef.PinSettingInfo, ByRef EnableFunction As EnFunc)
        Dim i As Integer

        For i = 1 To 40 Step 1
            Select Case (PinInfo(i).UseFunc)
                Case GlobalDef.PinFunc.GPIO
                    EnableFunction.GPIO = True
                Case GlobalDef.PinFunc.UART
                    EnableFunction.UART = True
                Case GlobalDef.PinFunc.SPI
                    EnableFunction.SPI = True
                Case GlobalDef.PinFunc.I2C
                    EnableFunction.I2C = True
                Case Else
                    '何もしない
            End Select
        Next i
        Return 0
    End Function

    'Public Subs or Functions
    '_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/
    '保存済みフラグをクリアする
    '_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/
    Sub ClearSavePrjFlg()
        SavePrjFlg = False
    End Sub

    '_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/
    'ソフト起動時の初期設定をする
    '_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/
    Sub UILoaded()

    End Sub

    '_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/
    '閉じる
    '_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/
    Sub CloseForm()
        If (SavePrjFlg) Then
            Raspberation_UI.Close()
        Else
            '保存するか聞く
            Dim result As DialogResult = MsgBox("設定を保存していません。" & vbCrLf & "保存しますか？", MsgBoxStyle.YesNo)
            If (result = DialogResult.Yes) Then
                '保存する
                Save()
                SavePrjFlg = True
            Else
                '保存しない
                SavePrjFlg = True
                Raspberation_UI.Close()
            End If
        End If
    End Sub

    '_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/
    '閉じるボタンが押されたとき
    '_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/
    Sub FormClosing()
        If (SavePrjFlg) Then
            'すでに保存済み or メニューバーから終了で保存しないを選択 -> 何もしない
        Else
            '保存するか聞く
            Dim result As DialogResult = MsgBox("設定を保存していません。" & vbCrLf & "保存しますか？", MsgBoxStyle.YesNo)
            If (result = DialogResult.Yes) Then
                '保存する
                Save()
            Else
                '保存しない
            End If
        End If
    End Sub

    '_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/
    '読み出し
    '_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/
    Sub Load()
        Dim read As String
        Raspberation_UI.LoadPrjFile.ShowDialog()
        read = Raspberation_UI.LoadPrjFile.FileName
        'MsgBox(read)
        LoadFilePath = read
    End Sub

    '_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/
    '名前をつけて保存
    '_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/
    Sub Save()
        Dim write As String
        Raspberation_UI.SavePrjFile.ShowDialog()
        write = Raspberation_UI.SavePrjFile.FileName
        'MsgBox(write)
        If (write = "") Then
            'キャンセルされた
        Else
            Raspberation_UI.SavePrjPath.Text = write
            '保存を実行する
            'TODO:ピン設定、プロジェクトファイル保存場所、ルートディレクトリをcsvかxml形式に変換してからファイルへ保存する
            SavePrjFlg = True
        End If
    End Sub

    '_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/
    '上書き保存
    '_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/
    Sub Overwrite()
        If (LoadFilePath <> "") Then
            'ファイルを開いている場合は、そのパスで保存をする
            SavePrjFlg = True
        Else
            'ファイルを開いていない場合は、保存先を尋ねる
            Save()
        End If
    End Sub

    '_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/
    'プロジェクトファイル保存場所
    '_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/
    Sub SavePrj()
        Dim write As String
        Raspberation_UI.SavePrjFile.ShowDialog()
        write = Raspberation_UI.SavePrjFile.FileName
        '拡張子があるか判定し、無ければ付加する
        Raspberation_UI.SavePrjPath.Text = write
    End Sub

    '_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/
    'ソースコード保存場所
    '_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/
    Sub SaveSrc()
        Dim write As String
        Raspberation_UI.SaveSrc.ShowDialog()
        write = Raspberation_UI.SaveSrc.FileName
        Raspberation_UI.SaveSrcPath.Text = write
    End Sub

    '_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/
    'ピン配置画像のクリック位置からどのピンを設定するか判断する
    'X:画像のクリックされたX座標
    'Y:画像のクリックされたY座標
    '_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/
    Sub Area(ByVal X As Integer, ByVal Y As Integer)
        Dim globdef As New GlobalDef
        Dim i As Integer
        For i = 0 To 39 Step 1
            If (globdef.PinArea(i).First.PointX < X And X < globdef.PinArea(i).Last.PointX _
                And
                globdef.PinArea(i).First.PointY < Y And Y < globdef.PinArea(i).Last.PointY) Then
                Dim PinNo As Integer
                PinNo = i + 1
                PinSetting.GPIOpinNo.Text = "GPIO " & PinNo
                PinSetting.Show()
                Exit For
            End If
        Next
    End Sub

    '_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/
    'ソースコード生成
    '_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/
    Sub GenSRC(ByRef PinInfo() As GlobalDef.PinSettingInfo)
        '1.設定のロード(UIから)
        Dim SrcPath As String
        SrcPath = Raspberation_UI.SaveSrcPath.Text
        If (SrcPath <> "") Then
            '有効化されている機能を調査する
            Dim EnableFunction As EnFunc
            FindActiveFunction(PinInfo, EnableFunction)
            '2.ベースコードに設定を反映
            Dim Buf As String = ""
            GenBuf(Buf, EnableFunction)
            'Raspberation_UI.debug.Text = Buf
            '3.ファイル書き出し(File.SaveFile)
            Dim fobj As File = New File
            fobj.SaveFile(SrcPath, Buf)
            MsgBox("ソースコードを自動生成しました。")
        Else
            '保存場所が設定されていない
            MsgBox("ソースコード保存場所が設定されていません。")
        End If
    End Sub


    '_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/
    'Raspberationについて
    '_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/
    Sub AboutRaspberation_UI()
        Version.Show()
        Version.ver.Text = "0.0.1 (build 2018/**/**)"
    End Sub

    '_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/
    'ヘルプの表示
    '_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/
    Sub ShowHelp()
        MsgBox("そんなものはなかった")
    End Sub

End Module
