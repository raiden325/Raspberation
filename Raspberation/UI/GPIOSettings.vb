Public Class GPIOSettings
    Private Sub Cancell_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Cancell.Click
        'キャンセルボタンが押された
        Me.Close()
    End Sub

    Private Sub OK_Click(ByVal sender As Object, ByVal e As EventArgs) Handles OK.Click
        '現在の画面のデータを取得し、保持する
        Dim Info As GlobalDef.GPIOSettingInfo

        Info.PinNo = PinNo.Text.Substring(5)

        If (Mode.Text = "出力") Then
            Info.Mode = GlobalDef.GPIOMode.Output
        ElseIf (Mode.Text = "入力") Then
            Info.Mode = GlobalDef.GPIOMode.Input
        Else
            MsgBox("モードが選択されていません。" & vbCrLf & "中断します。")
            Exit Sub
        End If

        If (Level.Text = "High") Then
            Info.Level = GlobalDef.GPIOLevel.High
        ElseIf (Level.Text = "Low") Then
            Info.Level = GlobalDef.GPIOLevel.Low
        Else
            MsgBox("レベルが選択されていません。" & vbCrLf & "中断します。")
            Exit Sub
        End If

        If (DetectUpEdge.Text = "する") Then
            Info.DetectUpEdge = True
        Else
            Info.DetectUpEdge = False
        End If

        If (DetectDownEdge.Text = "する") Then
            Info.DetectDownEdge = True
        Else
            Info.DetectDownEdge = False
        End If

        If (DetectHighLevel.Text = "する") Then
            Info.DetectHighLevel = True
        Else
            Info.DetectHighLevel = False
        End If

        If (DetectLowLevel.Text = "する") Then
            Info.DetectLowLevel = True
        Else
            Info.DetectLowLevel = False
        End If

        If (DetectAsyncUpEdge.Text = "する") Then
            Info.DetectAsyncUpEdge = True
        Else
            Info.DetectAsyncUpEdge = False
        End If

        If (DetectAsyncDownEdge.Text = "する") Then
            Info.DetectAsyncDownEdge = True
        Else
            Info.DetectAsyncDownEdge = False
        End If

        If (SelectPullUpDown.Text = "しない") Then
            Info.SelectPullUpDown = GlobalDef.GPIOPull.None
        ElseIf (SelectPullUpDown.Text = "プルアップ") Then
            Info.SelectPullUpDown = GlobalDef.GPIOPull.PullUp
        ElseIf (SelectPullUpDown.Text = "プルダウン") Then
            Info.SelectPullUpDown = GlobalDef.GPIOPull.PullDown
        Else
            MsgBox("プルアップ・プルダウンが選択されていません。" & vbCrLf & "中断します。")
            Exit Sub
        End If

        'データを格納する
        Raspberation_UI.StoreGPIOInfo(Info)
        Me.Close()
    End Sub

End Class