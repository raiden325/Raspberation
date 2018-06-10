'_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/
'ユーザー操作を受けて、実際に処理をするための関数群
'_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/
Module Raspberation_Modules
    '_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/
    'ファイルスコープ変数の宣言
    '_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/
    Private SavePrjFlg As Boolean = False
    Private LoadFilePath As String = ""

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
            Raspberation_UI.SaveSrcPath.Text = write
            '保存を実行する
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
        Raspberation_UI.SaveSrcPath.Text = write
    End Sub

    '_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/
    'プロジェクト保存ディレクトリ
    '_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/
    'Sub SelectPrjDir()
    '    Dim PrjPath As String
    '    Raspberation_UI.SelectDir.ShowDialog()
    '    PrjPath = Raspberation_UI.SelectDir.SelectedPath
    '    Raspberation_UI.PrjDir.Text = PrjPath
    'End Sub
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
    Sub GenSRC()
        '1.設定のロード(UIから)
        Dim fp As String
        fp = Raspberation_UI.SaveSrcPath.Text
        If (fp <> "") Then
            '保存先ファイルパス生成
            Dim FileName As String
            Dim FileDirectory As String
            Dim SrcPath As String
            FileName = System.IO.Path.GetFileNameWithoutExtension(fp)
            FileDirectory = System.IO.Path.GetDirectoryName(fp)
            SrcPath = FileDirectory & "\" & FileName & ".c"
            '2.ベースコードに設定を反映
            Dim Buf As String
            Buf = "test"
            '3.ファイル書き出し(File.SaveFile)
            Dim fobj As File = New File
            fobj.SaveFile(SrcPath, Buf)
        Else
            '保存場所が設定されていない
            MsgBox("プロジェクトファイル保存場所が設定されていません。")
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
