Public Class Raspberation_UI
    '設定保存用変数
    '構造体要素番号とピン番号を対応させて、管理する
    Dim PinInfo(40) As GlobalDef.PinSettingInfo

    '_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/
    ' Public Function
    '_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/
    'GPIO設定データ保存
    Public Sub StoreGPIOInfo(ByRef Info As GlobalDef.GPIOSettingInfo)
        PinInfo(Info.PinNo - 1).GPIO = Info
        PinInfo(Info.PinNo - 1).UseFunc = GlobalDef.PinFunc.GPIO
        'ピン設定が更新されたので保存フラグをクリア
        Raspberation_Modules.ClearSavePrjFlg()
    End Sub

    'SPI設定データ保存
    Public Sub StoreSPIInfo(ByRef Info As GlobalDef.SPISettingInfo)
        PinInfo(Info.PinNo - 1).SPI = Info
        PinInfo(Info.PinNo - 1).UseFunc = GlobalDef.PinFunc.SPI
        'ピン設定が更新されたので保存フラグをクリア
        Raspberation_Modules.ClearSavePrjFlg()
    End Sub

    'UART設定データ保存
    Public Sub StoreUARTInfo(ByRef Info As GlobalDef.UARTSettingInfo)
        PinInfo(Info.PinNo - 1).UART = Info
        PinInfo(Info.PinNo - 1).UseFunc = GlobalDef.PinFunc.UART
        'ピン設定が更新されたので保存フラグをクリア
        Raspberation_Modules.ClearSavePrjFlg()
    End Sub

    'I2C設定データ保存
    Public Sub StoreI2CInfo(ByRef Info As GlobalDef.I2CSettingInfo)
        PinInfo(Info.PinNo - 1).I2C = Info
        PinInfo(Info.PinNo - 1).UseFunc = GlobalDef.PinFunc.I2C
        'ピン設定が更新されたので保存フラグをクリア
        Raspberation_Modules.ClearSavePrjFlg()
    End Sub
    '_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/
    ' Private Function
    '_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/
    'ヘルプの表示ボタン
    Private Sub ヘルプの表示ToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ヘルプの表示ToolStripMenuItem.Click
        Raspberation_Modules.ShowHelp()
    End Sub

    'Raspberationについて
    Private Sub RaspberationについてToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles RaspberationについてToolStripMenuItem.Click
        Raspberation_Modules.AboutRaspberation_UI()
    End Sub

    'プロジェクトファイルを開く
    Private Sub ToolStripButton1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles LoadPrj.Click
        Raspberation_Modules.Load()
    End Sub

    'プロジェクトファイルを開く
    Private Sub 開くToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles 開くToolStripMenuItem.Click
        Raspberation_Modules.Load()
    End Sub

    '上書き保存
    Private Sub ToolStripButton2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles SavePrj.Click
        Raspberation_Modules.Overwrite()
    End Sub

    '上書き保存
    Private Sub 上書き保存ToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles 上書き保存ToolStripMenuItem.Click
        Raspberation_Modules.Overwrite()
    End Sub

    'コード生成
    Private Sub ToolStripButton3_Click(ByVal sender As Object, ByVal e As EventArgs) Handles GenSRC.Click
        'ここにモジュールを呼び出す関数を記述する
        Raspberation_Modules.GenSRC(PinInfo)
    End Sub

    '名前をつけて保存
    Private Sub 名前をつけて保存ToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles 名前をつけて保存ToolStripMenuItem.Click
        Raspberation_Modules.Save()
    End Sub

    'プロジェクトファイル保存場所選択ボタン
    Private Sub SelectPrjPath_Click(ByVal sender As Object, ByVal e As EventArgs) Handles SelectPrjPath.Click
        Raspberation_Modules.SavePrj()
    End Sub

    'ソースコード保存場所選択ボタン
    Private Sub SelectSrcPath_Click(sender As Object, e As EventArgs) Handles SelectSrcPath.Click
        Raspberation_Modules.SaveSrc()
    End Sub

    'ピン設定タブの画像をクリックした
    'Private Sub PictureBox1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
    '    Raspberation_Modules.Area(e.X, e.Y)
    'End Sub

    '初期化
    Private Sub Raspberation_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        'ここでソフト起動時の初期化処理する関数を呼ぶ
    End Sub

    '画面の表示がされた
    Private Sub Raspberation_Shown(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Shown
        'Status更新
        ToolStripStatusLabel1.Text = "Ready..."
    End Sub

    'メニューの終了が押された
    Private Sub 終了ToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles 終了ToolStripMenuItem.Click
        '閉じる前に設定が変更されていれば、保存するか問う
        Raspberation_Modules.CloseForm()
    End Sub

    '閉じる
    Private Sub Raspberation_Closing(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Closing
        Raspberation_Modules.FormClosing()
    End Sub

    'ツリービューのノードのどれかが選択された
    Private Sub TreeView1_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles TreeView1.AfterSelect
        Dim SelectedNodeStr As String
        SelectedNodeStr = TreeView1.SelectedNode.Name
        Select Case (SelectedNodeStr.Substring(0, 3))   '先頭から3文字切り出して、判定する
            'とりあえず今あるフォームを表示しているけど、ツリービューの隣に設定項目を出したい -> visibleをtrue falseでできる
            Case "GPI"
                'GPIO
                ShowSettingGPIO()
                HideSettingUART()
                HideSettingSPI()
                HideSettingI2C()
            Case "UAR"
                'UART
                ShowSettingUART()
                HideSettingGPIO()
                HideSettingSPI()
                HideSettingI2C()
            Case "SPI"
                'SPI
                ShowSettingSPI()
                HideSettingGPIO()
                HideSettingUART()
                HideSettingI2C()
            Case "I2C"
                'I2C
                ShowSettingI2C()
                HideSettingGPIO()
                HideSettingUART()
                HideSettingSPI()
        End Select
    End Sub

    'GPIO設定を可視化
    Private Sub ShowSettingGPIO()
        Mode.Visible = True
        Level.Visible = True
        DetectUpEdge.Visible = True
        DetectDownEdge.Visible = True
        DetectHighLevel.Visible = True
        DetectLowLevel.Visible = True
        DetectAsyncUpEdge.Visible = True
        DetectAsyncDownEdge.Visible = True
        SelectPullUpDown.Visible = True
        LabelGPIO1.Visible = True
        LabelGPIO2.Visible = True
        LabelGPIO3.Visible = True
        LabelGPIO4.Visible = True
        LabelGPIO5.Visible = True
        LabelGPIO6.Visible = True
        LabelGPIO7.Visible = True
        LabelGPIO8.Visible = True
        LabelGPIO9.Visible = True

    End Sub

    'UART設定を可視化
    Private Sub ShowSettingUART()

    End Sub

    'SPI設定を可視化
    Private Sub ShowSettingSPI()
        SetInfoSPI.Visible = True
    End Sub

    'I2C設定を可視化
    Private Sub ShowSettingI2C()

    End Sub

    'GPIO設定を隠す
    Private Sub HideSettingGPIO()
        Mode.Visible = False
        Level.Visible = False
        DetectUpEdge.Visible = False
        DetectDownEdge.Visible = False
        DetectHighLevel.Visible = False
        DetectLowLevel.Visible = False
        DetectAsyncUpEdge.Visible = False
        DetectAsyncDownEdge.Visible = False
        SelectPullUpDown.Visible = False
        LabelGPIO1.Visible = False
        LabelGPIO2.Visible = False
        LabelGPIO3.Visible = False
        LabelGPIO4.Visible = False
        LabelGPIO5.Visible = False
        LabelGPIO6.Visible = False
        LabelGPIO7.Visible = False
        LabelGPIO8.Visible = False
        LabelGPIO9.Visible = False
    End Sub

    'UART設定を隠す
    Private Sub HideSettingUART()

    End Sub

    'SPI設定を隠す
    Private Sub HideSettingSPI()
        SetInfoSPI.Visible = False
    End Sub

    'I2C設定を隠す
    Private Sub HideSettingI2C()

    End Sub

End Class
