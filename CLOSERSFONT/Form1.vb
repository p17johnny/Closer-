Public Class Form1
    Dim url As String
    Dim urlfile As String
    Dim txta As String
    Dim DownloadManager As New Downloader(url, urlfile, txta)
    Private mouseOffset As Point
    Private isMouseDown As Boolean = False
    Private Sub BunifuDropdown1_onItemSelected(sender As Object, e As EventArgs)

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Progressbar1.Value = DownloadManager.GetProgressPercentage '取得下載進度百分比(0~100)
    End Sub


    Private Sub Form1_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        Dim xOffset As Integer
        Dim yOffset As Integer

        If e.Button = MouseButtons.Left Then
            xOffset = -e.X - SystemInformation.FrameBorderSize.Width
            yOffset = -e.Y - SystemInformation.CaptionHeight - _
                    SystemInformation.FrameBorderSize.Height
            mouseOffset = New Point(xOffset, yOffset)
            isMouseDown = True
        End If
    End Sub

    Private Sub Form1_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        If isMouseDown Then
            Dim mousePos As Point = Control.MousePosition
            mousePos.Offset(mouseOffset.X, mouseOffset.Y)
            Location = mousePos
        End If
    End Sub

    Private Sub Form1_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp
        ' Changes the isMouseDown field so that the form does
        ' not move unless the user is pressing the left mouse button.
        If e.Button = MouseButtons.Left Then
            isMouseDown = False
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BunifuImageButton2_Click(sender As Object, e As EventArgs) Handles BunifuImageButton2.Click
        Textbox1.text = DownloadManager.ChoseFolderPath '直接開啟對話方塊選取資料夾
    End Sub

    Private Sub BunifuImageButton3_Click(sender As Object, e As EventArgs) Handles BunifuImageButton3.Click
        Dim file = Textbox1.text
        Dim x As String
        Dim y, y2 As String
        If (BunifuDropdown1.selectedIndex = 1) Then
            Try
                x = file + "\MSJH.ttf"
                My.Computer.FileSystem.DeleteFile(x)
                y = file + "\FONT1.TTF"
                y2 = file + "\MSJH.TTF"
                My.Computer.FileSystem.CopyFile(y,
                y2, Microsoft.VisualBasic.FileIO.UIOption.OnlyErrorDialogs, FileIO.UICancelOption.DoNothing)
                MsgBox("完成!")
            Catch ex As Exception
                MsgBox("未下載字體 , 第一次使用請選擇首次使用")
            End Try
        ElseIf (BunifuDropdown1.selectedIndex = 2) Then
            Try
                x = file + "\MSJH.ttf"
                My.Computer.FileSystem.DeleteFile(x)
                y = file + "\FONT2.TTF"
                y2 = file + "\MSJH.TTF"
                My.Computer.FileSystem.CopyFile(y,
                y2, Microsoft.VisualBasic.FileIO.UIOption.OnlyErrorDialogs, FileIO.UICancelOption.DoNothing)
                MsgBox("完成!")
            Catch ex As Exception
                MsgBox("未下載字體 , 第一次使用請選擇首次使用")
            End Try
        ElseIf (BunifuDropdown1.selectedIndex = 3) Then
            Try
                x = file + "\MSJH.ttf"
                My.Computer.FileSystem.DeleteFile(x)
                y = file + "\FONT3.TTF"
                y2 = file + "\MSJH.TTF"
                My.Computer.FileSystem.CopyFile(y,
                y2, Microsoft.VisualBasic.FileIO.UIOption.OnlyErrorDialogs, FileIO.UICancelOption.DoNothing)
                MsgBox("完成!")
            Catch ex As Exception
                MsgBox("未下載字體 , 第一次使用請選擇首次使用")
            End Try
        ElseIf (BunifuDropdown1.selectedIndex = 5) Then
            Try
                x = file + "\MSJH.ttf"
                My.Computer.FileSystem.DeleteFile(x)
                y = file + "\MSJHori.TTF"
                y2 = file + "\MSJH.TTF"
                My.Computer.FileSystem.CopyFile(y,
                y2, Microsoft.VisualBasic.FileIO.UIOption.OnlyErrorDialogs, FileIO.UICancelOption.DoNothing)
                MsgBox("完成!")
            Catch ex As Exception
                MsgBox("未下載字體 , 第一次使用請選擇首次使用")
            End Try
        Else
            Try
                x = file + "\MSJH.ttf"
                My.Computer.FileSystem.DeleteFile(x)
                y = file + "\FONT4.TTF"
                y2 = file + "\MSJH.TTF"
                My.Computer.FileSystem.CopyFile(y,
                y2, Microsoft.VisualBasic.FileIO.UIOption.OnlyErrorDialogs, FileIO.UICancelOption.DoNothing)
                MsgBox("完成!")
            Catch ex As Exception
                MsgBox("未下載字體 , 第一次使用請選擇首次使用")
            End Try


        End If
    End Sub

    Private Sub BunifuImageButton4_Click(sender As Object, e As EventArgs) Handles BunifuImageButton4.Click
        Dim file = Textbox1.text
        Try
            file = Textbox1.text
            file = file + "\MSJH.ttf"
            My.Computer.FileSystem.DeleteFile(file) '刪除MSJH改
        Catch ex As Exception

        End Try
        Try
            file = Textbox1.text
            file = file + "\MSJHK.ttf"
            My.Computer.FileSystem.DeleteFile(file) '刪除MSJH改
        Catch ex As Exception

        End Try
        Try
            file = Textbox1.text
            file = file + "\MSJHori.ttf"
            My.Computer.FileSystem.DeleteFile(file) '刪除MSJH改
        Catch ex As Exception

        End Try
        Try
            file = Textbox1.text
            file = file + "\MSJHO.ttf"
            My.Computer.FileSystem.DeleteFile(file) '刪除MSJH改
        Catch ex As Exception

        End Try
        Dim a(5) As String
        Dim n(5) As String
        Dim nn(5) As String
        Label3.Visible = True
        '微軟正黑體(120%)
        '儷黑粗體(108%)
        '方正粗圓繁簡(108%)
        '完美適應字體(150%)
        a(1) = "https://www.dropbox.com/s/7uojdnwpip81rkh/%E5%BE%AE%E8%BB%9F%E6%AD%A3%E9%BB%91%20%281%29.ttf?dl=1"
        n(1) = "FONT1.TTF"
        nn(1) = "微軟正黑體(8.19 MB)"
        a(2) = "https://www.dropbox.com/s/nosvdldyh430ng1/%E6%96%B9%E6%AD%A3%E7%B2%97%E5%9C%93%20%281%29.ttf?dl=1"
        n(2) = "FONT2.TTF"
        nn(2) = "方正粗圓繁簡 (10.9 MB) "
        a(3) = "https://www.dropbox.com/s/zn0mwrcvjjsyxdi/%E5%84%B7%E9%BB%91%E7%B2%97%20%281%29.ttf?dl=1"
        n(3) = "FONT3.TTF"
        nn(3) = "儷黑粗體 (3.91 MB)"
        a(4) = "https://www.dropbox.com/s/nj1y6sa0wvlnxah/%E5%AE%8C%E7%BE%8E%E5%AD%97%E9%AB%94.ttf?dl=1"
        n(4) = "FONT4.TTF"
        nn(4) = "完美適應字體(3.91 MB)"
        a(5) = "https://www.dropbox.com/s/iglm683vm5ypvsp/MSJH.TTF?dl=1"
        n(5) = "MSJHori.TTF"
        nn(5) = "官方字體(20.6 MB  為什麼這麼大?我也不知道)"
        urlfile = Textbox1.text
        urlfile = urlfile + "\"
        For i = 1 To 5
            DownloadManager.TargetURL = a(i)
            DownloadManager.SaveFolderPath = urlfile
            DownloadManager.SaveFileName = n(i)
            Label3.Text = "正在下載" + nn(i) + "...."
            DownloadManager.TimerGate(Timer1, 1000) '將Timer1實體傳入DownloadManager中，並設定Interval為1000毫秒

            DownloadManager.StartDownload() '開始進行下載

            While DownloadManager.CheckDownloading '如果正在下載中，就永遠執行迴圈
                Application.DoEvents() '停頓(多工)
            End While
        Next


        Select Case DownloadManager.GetStatus '取得狀態傳回值
            Case 0
                MsgBox("字體下載失敗", MsgBoxStyle.Critical)
            Case 1
                ProgressBar1.Value = 100
                'MsgBox("成功,關閉本程式後啟動遊戲")
                MsgBox("字體下載完成。請待遊戲啟動後，選擇字體並更換。使用時間：" & DownloadManager.FormatTime(DownloadManager.GetDownloadedTime), MsgBoxStyle.Information)

        End Select

        file = Textbox1.text
        Try
            file = file + "\MSJHori.ttf"
            Dim newa = Textbox1.text
            newa = newa + "\MSJH.ttf"
            My.Computer.FileSystem.CopyFile(file,
            newa, Microsoft.VisualBasic.FileIO.UIOption.OnlyErrorDialogs, FileIO.UICancelOption.DoNothing)
        Catch ex As Exception

        End Try
        Try
            Dim game = Textbox1.text
            game = game + "\LAUNCHERX.lnk "
            System.Diagnostics.Process.Start(game)
        Catch ex As Exception
            MsgBox("發生錯誤 , 找不到遊戲程式")
        End Try
        Label3.Visible = False
    End Sub

    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
        Dim file = Textbox1.text
        Try

            file = file + "\MSJH.ttf"
            My.Computer.FileSystem.DeleteFile(file) '刪除MSJH改
        Catch ex As Exception
        End Try
        file = Textbox1.text
        Try
            file = file + "\MSJHori.ttf"
            Dim newa = Textbox1.text
            newa = newa + "\MSJH.ttf"
            My.Computer.FileSystem.CopyFile(file,
            newa, Microsoft.VisualBasic.FileIO.UIOption.OnlyErrorDialogs, FileIO.UICancelOption.DoNothing)
        Catch ex As Exception

        End Try
        Dim game = Textbox1.text
        game = game + "\LAUNCHERX.lnk"
        System.Diagnostics.Process.Start(game)

        'MsgBox("發生錯誤 , 找不到遊戲程式(LAUNCHERX.lnk)或檔案(MSJH.TTF)")
    End Sub

    Private Sub BunifuImageButton5_Click(sender As Object, e As EventArgs) Handles BunifuImageButton5.Click
        Me.Close()

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Try
            System.Diagnostics.Process.Start("https://forum.gamer.com.tw/C.php?bsn=23655&snA=3819&locked=F&page=1&gothis=14025#14025")
        Catch

        End Try
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Textbox1_OnTextChange(sender As Object, e As EventArgs) Handles Textbox1.OnTextChange

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles BunifuDropdown1.SelectedIndexChanged

    End Sub
End Class
