Public Class Raspberation_UI
    '設定保存用変数
    '構造体要素番号とピン番号を対応させて、管理する
    Dim PinInfo(40) As GlobalDef.PinSettingInfo

    '_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/
    ' Public Function
    '_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/
    Public Sub StoreGPIOInfo(ByRef Info As GlobalDef.GPIOSettingInfo)
        PinInfo(Info.PinNo - 1).GPIO = Info
        PinInfo(Info.PinNo - 1).UseFunc = GlobalDef.PinFunc.GPIO
    End Sub

    '_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/
    ' Private Function
    '_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/
    'ヘルプの表示ボタン
    Private Sub ヘルプの表示ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ヘルプの表示ToolStripMenuItem.Click

    End Sub

    'Raspberationについて
    Private Sub RaspberationについてToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RaspberationについてToolStripMenuItem.Click
        Raspberation_Modules.AboutRaspberation_UI()
    End Sub

    'プロジェクトファイルを開く
    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Raspberation_Modules.Load()
    End Sub

    'プロジェクトファイルを開く
    Private Sub 開くToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 開くToolStripMenuItem.Click
        Raspberation_Modules.Load()
    End Sub

    '上書き保存
    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        Raspberation_Modules.Overwrite()
    End Sub

    '上書き保存
    Private Sub 上書き保存ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 上書き保存ToolStripMenuItem.Click
        Raspberation_Modules.Overwrite()
    End Sub

    'コード生成
    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        'ここにモジュールを呼び出す関数を記述する
    End Sub

    '名前をつけて保存
    Private Sub 名前をつけて保存ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 名前をつけて保存ToolStripMenuItem.Click
        Raspberation_Modules.Save()
    End Sub

    'プロジェクトファイル保存場所選択ボタン
    Private Sub SelectSrcPath_Click(sender As Object, e As EventArgs) Handles SelectSrcPath.Click
        Raspberation_Modules.SavePrj()
    End Sub

    'ピン設定タブの画像をクリックした
    Private Sub PictureBox1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseDown
        Raspberation_Modules.Area(e.X, e.Y)
    End Sub

    '初期化
    Private Sub Raspberation_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        'ここでソフト起動時の初期化処理する関数を呼ぶ
    End Sub

    '画面の表示がされた
    Private Sub Raspberation_Shown(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Shown
        'Status更新
        ToolStripStatusLabel1.Text = "Ready..."
    End Sub
End Class
