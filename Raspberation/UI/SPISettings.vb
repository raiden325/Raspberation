Public Class SPISettings
    Private Sub OK_Click(sender As Object, e As EventArgs) Handles OK.Click
        '設定データを保持する
        Dim Info As GlobalDef.SPISettingInfo
        Info.PinNo = PinNo.Text.Substring(6)
        'データを格納する
        If (ChipSelect.Text = "CS 0") Then
            Info.ChipSelect = GlobalDef.SPIChipSelect.CS0
        ElseIf (ChipSelect.Text = "CS 1") Then
            Info.ChipSelect = GlobalDef.SPIChipSelect.CS1
        ElseIf (ChipSelect.Text = "CS 2") Then
            Info.ChipSelect = GlobalDef.SPIChipSelect.CS2
        Else
            MsgBox("CSが選択されていません。" & vbCrLf & "中断します。")
            Exit Sub
        End If

        If (ClockPhase.Text = "データビットの中央") Then
            Info.ClockPhase = GlobalDef.SPIClockPhase.Middle
        ElseIf (ClockPhase.Text = "データビットの始まり") Then
            Info.ClockPhase = GlobalDef.SPIClockPhase.Begining
        Else
            MsgBox("クロック遷移位置が選択されていません。" & vbCrLf & "中断します。")
            Exit Sub
        End If

        If (ClockPolarity.Text = "Low") Then
            Info.ClockPolarity = GlobalDef.SPIClockPolarity.Low
        ElseIf (ClockPolarity.Text = "High") Then
            Info.ClockPolarity = GlobalDef.SPIClockPolarity.High
        Else
            MsgBox("クロック休止時の状態が選択されていません。" & vbCrLf & "中断します。")
            Exit Sub
        End If

        If (CLEARFIFO.Text = "何もしない") Then
            Info.CLEARFIFO = GlobalDef.SPIClEARFIFO.NO_ACUTION
        ElseIf (CLEARFIFO.Text = "TX FIFOクリア") Then
            Info.CLEARFIFO = GlobalDef.SPIClEARFIFO.CLEAR_TX
        ElseIf (CLEARFIFO.Text = "RX FIFOクリア") Then
            Info.CLEARFIFO = GlobalDef.SPIClEARFIFO.CLEAR_RX
        Else
            MsgBox("CLEAR FIFOクリアが選択されていません。" & vbCrLf & "中断します。")
            Exit Sub
        End If

        If (CSPolarity.Text = "アクティブローにする") Then
            Info.CSPolarity = GlobalDef.SPICSPolarity.ACTIVE_LOW
        ElseIf (CSPolarity.Text = "アクティブハイにする") Then
            Info.CSPolarity = GlobalDef.SPICSPolarity.ACTIVE_HIGH
        Else
            MsgBox("CSの状態が選択されていません。" & vbCrLf & "中断します。")
            Exit Sub
        End If

        If (EnableTransfer.Text = "有効") Then
            Info.EnableTransfer = True
        Else
            Info.EnableTransfer = False
        End If

        If (EnableDMA.Text = "有効") Then
            Info.EnableDMA = True
        Else
            Info.EnableDMA = False
        End If

        If (EnableTxInterrupt.Text = "有効") Then
            Info.EnableTXInterrupt = True
        Else
            Info.EnableTXInterrupt = False
        End If

        If (EnableRXInterrupt.Text = "有効") Then
            Info.EnableRXInterrupt = True
        Else
            Info.EnableRXInterrupt = False
        End If

        If (EnableADCS.Text = "する") Then
            Info.EnableADCS = True
        Else
            Info.EnableADCS = False
        End If

        If (EnableRead.Text = "SPIペリフェラルに書き込み") Then
            Info.EnableRead = GlobalDef.SPIEnableRead.WRITE_SPI
        ElseIf (EnableRead.Text = "SPI周辺機器から読み込み") Then
            Info.EnableRead = GlobalDef.SPIEnableRead.READ_SPI
        Else
            MsgBox("読み取り有効が選択されていません。" & vbCrLf & "中断します。")
            Exit Sub
        End If

        If (EnableLoSSI.Text = "高速(SPI)") Then
            Info.EnableLoSSI = GlobalDef.SPIMode.SPI
        ElseIf (EnableLoSSI.Text = "低速(LoSSI)") Then
            Info.EnableLoSSI = GlobalDef.SPIMode.LoSSI
        Else
            MsgBox("速度モードが選択されていません。" & vbCrLf & "中断します。")
            Exit Sub
        End If

        If (CS0Polarity.Text = "アクティブローにする") Then
            Info.CSPolarity0 = GlobalDef.SPICSPolarity.ACTIVE_LOW
        ElseIf (CS0Polarity.Text = "アクティブハイにする") Then
            Info.CSPolarity0 = GlobalDef.SPICSPolarity.ACTIVE_HIGH
        Else
            MsgBox("CS0の状態が選択されていません。" & vbCrLf & "中断します。")
            Exit Sub
        End If

        If (CS1Polarity.Text = "アクティブローにする") Then
            Info.CSPolarity1 = GlobalDef.SPICSPolarity.ACTIVE_LOW
        ElseIf (CS1Polarity.Text = "アクティブハイにする") Then
            Info.CSPolarity1 = GlobalDef.SPICSPolarity.ACTIVE_HIGH
        Else
            MsgBox("CS1の状態が選択されていません。" & vbCrLf & "中断します。")
            Exit Sub
        End If

        If (CS2Polarity.Text = "アクティブローにする") Then
            Info.CSPolarity2 = GlobalDef.SPICSPolarity.ACTIVE_LOW
        ElseIf (CS2Polarity.Text = "アクティブハイにする") Then
            Info.CSPolarity2 = GlobalDef.SPICSPolarity.ACTIVE_HIGH
        Else
            MsgBox("CS2の状態が選択されていません。" & vbCrLf & "中断します。")
            Exit Sub
        End If

        If (EnableLoSSIDMA.Text = "する") Then
            Info.EnableLoSSIDMA = True
        Else
            Info.EnableLoSSIDMA = False
        End If

        If (EnableLoSSILongWord.Text = "する") Then
            Info.EnableLoSSILongWord = True
        Else
            Info.EnableLoSSILongWord = False
        End If

        If (EnableTOH.Text = "する") Then
            Info.EnableTOH = True
        Else
            Info.EnableTOH = False
        End If

        If (ClockFreq.Text <> "") Then
            Const CORE_CLOCK As Long = 1200000000
            If (ClockUnit.Text = "MHz") Then
                'クロック周波数計算
                Info.TxClockFreq = CORE_CLOCK / (ClockFreq.Text * 10 ^ 6)
            ElseIf (ClockUnit.Text = "kHz") Then
                'クロック周波数計算
                Info.TxClockFreq = CORE_CLOCK / (ClockFreq.Text * 10 ^ 3)
            Else
                MsgBox("クロックの単位が選択されていません。" & vbCrLf & "中断します。")
                Exit Sub
            End If
        Else
            MsgBox("クロック周波数が入力されていません。" & vbCrLf & "中断します。")
            Exit Sub
        End If

        If (TransferSize.Text <> "") Then
            Dim tTxSize As Long = TransferSize.Text
            If (tTxSize >= 0) And (tTxSize <= 65535) Then
                Info.TransferSize = tTxSize
            Else
                MsgBox("転送するバイト数の設定が不正です。" & vbCrLf & "中断します。")
                Exit Sub
            End If
        End If

        If (WriteRequestThreshold.Text <> "") Then
            Dim tThreshold As Integer = WriteRequestThreshold.Text
            If (tThreshold >= 0) And (tThreshold <= 255) Then
                Info.WriteRequestThreshold = tThreshold
            Else
                MsgBox("DMA書き込み要求しきい値の設定値が不正です。" & vbCrLf & "中断します。")
                Exit Sub
            End If
        End If

        If (WritePanicThreshold.Text <> "") Then
            Dim tThreshold As Integer = WritePanicThreshold.Text
            If (tThreshold >= 0) And (tThreshold <= 255) Then
                Info.WritePanicThreshold = tThreshold
            Else
                MsgBox("DMA書き込みパニックしきい値の設定値が不正です。" & vbCrLf & "中断します。")
                Exit Sub
            End If
        End If

        If (ReadRequestThreshold.Text <> "") Then
            Dim tThreshold As Integer = ReadRequestThreshold.Text
            If (tThreshold >= 0) And (tThreshold <= 255) Then
                Info.ReadRequestThreshold = tThreshold
            Else
                MsgBox("DMA読み取り要求しきい値の設定値が不正です。" & vbCrLf & "中断します。")
                Exit Sub
            End If
        End If

        If (ReadPanicThreshold.Text <> "") Then
            Dim tThreshold As Integer = ReadPanicThreshold.Text
            If (tThreshold >= 0) And (tThreshold <= 255) Then
                Info.ReadPanicThreshold = tThreshold
            Else
                MsgBox("DMA読み取りパニックしきい値の設定値が不正です。" & vbCrLf & "中断します。")
                Exit Sub
            End If
        End If
        '設定データを
        Raspberation_UI.StoreSPIInfo(Info)
        '画面を閉じる
        Me.Close()
    End Sub

    Private Sub Cancell_Click(sender As Object, e As EventArgs) Handles Cancell.Click
        '画面を閉じる
        Me.Close()
    End Sub

    'クロック数用テキストボックスに数字しか入力できないようにする
    Private Sub ClockFreq_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles ClockFreq.KeyPress
        If ((e.KeyChar < "0"c) OrElse (e.KeyChar > "9"c)) AndAlso (e.KeyChar <> ControlChars.Back) Then
            '押されたキーがO～9でない場合はイベントをキャンセルする
            e.Handled = True
        End If
    End Sub

    '転送するバイト数用テキストボックスに数字しか入力できないようにする
    Private Sub TransferSize_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TransferSize.KeyPress
        If ((e.KeyChar < "0"c) OrElse (e.KeyChar > "9"c)) AndAlso (e.KeyChar <> ControlChars.Back) Then
            '押されたキーがO～9でない場合はイベントをキャンセルする
            e.Handled = True
        End If
    End Sub

    'DMA書き込み要求しきい値用テキストボックスに数字しか入力できないようにする
    Private Sub WriteRequestThreshold_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles WriteRequestThreshold.KeyPress
        If ((e.KeyChar < "0"c) OrElse (e.KeyChar > "9"c)) AndAlso (e.KeyChar <> ControlChars.Back) Then
            '押されたキーがO～9でない場合はイベントをキャンセルする
            e.Handled = True
        End If
    End Sub

    'DMA書き込みパニックしきい値用テキストボックスに数字しか入力できないようにする
    Private Sub WritePanicThreshold_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles WritePanicThreshold.KeyPress
        If ((e.KeyChar < "0"c) OrElse (e.KeyChar > "9"c)) AndAlso (e.KeyChar <> ControlChars.Back) Then
            '押されたキーがO～9でない場合はイベントをキャンセルする
            e.Handled = True
        End If
    End Sub

    'DMA読み取り要求しきい値用テキストボックスに数字しか入力できないようにする
    Private Sub ReadRequestThreshold_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles ReadRequestThreshold.KeyPress
        If ((e.KeyChar < "0"c) OrElse (e.KeyChar > "9"c)) AndAlso (e.KeyChar <> ControlChars.Back) Then
            '押されたキーがO～9でない場合はイベントをキャンセルする
            e.Handled = True
        End If
    End Sub

    'DMA読み取りパニックしきい値用テキストボックスに数字しか入力できないようにする
    Private Sub ReadPanicThreshold_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles ReadPanicThreshold.KeyPress
        If ((e.KeyChar < "0"c) OrElse (e.KeyChar > "9"c)) AndAlso (e.KeyChar <> ControlChars.Back) Then
            '押されたキーがO～9でない場合はイベントをキャンセルする
            e.Handled = True
        End If
    End Sub
End Class