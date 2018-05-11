Public Class Raspberation_UI
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
End Class
