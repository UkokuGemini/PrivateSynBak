Public Class FormMain
#Region "SQL"
    Friend DataBasePath As String = IO.Directory.GetCurrentDirectory & "\"
    Friend SynFilesDataBaseConnection As New SQLite.SQLiteConnection
    ReadOnly DataBaseCommand As New SQLite.SQLiteCommand
    Private WithEvents SynTimer As New Timer
    Private WithEvents SynWorkTimer As New Timer
    Private WithEvents SecondTimer As New Timer
    Dim SynFliesDataBase, SettingDataBase As DataSet
    ReadOnly NumArrlist, PathStrArr, SynArr As New ArrayList
    Dim NextWorkDate As Date = Now
    Dim NowIndex， SynFailue, SynSuccess As Integer
    Dim AutoNum As Integer = 1
    Dim TargetPath, SubStoreName As String
    Dim FinishFlag As Boolean = True
    Dim TrueClose As Boolean
    Function DataBaseCodeVerify(ByVal DataBaseName As String, ByVal DataBaseConnection As SQLite.SQLiteConnection) As String
        Dim DataBaseConnectionStrResult As String = ""
        Try
            DataBaseConnection.ConnectionString = "Data Source=" & DataBasePath & DataBaseName
            If DataBaseConnection.State = System.Data.ConnectionState.Closed Then
                DataBaseConnection.Open()
                Dim Test As Integer = SQLDataBaseQeury("SELECT COUNT(*) FROM sqlite_master WHERE type='table'", DataBaseConnection).Tables(0).Rows.Count
            End If
            DataBaseConnectionStrResult = DataBaseConnection.ConnectionString
        Catch ex As Exception
        End Try
        Return DataBaseConnectionStrResult
    End Function  '数据库密码验证
    Function SQLDataBaseQeury(ByVal SQLCommand As String, ByVal DataBaseConnection As SQLite.SQLiteConnection) As DataSet
        Dim DataSetTemp As New DataSet
        Try
            If DataBaseConnection.State = System.Data.ConnectionState.Closed Then
                DataBaseConnection.Open()
            End If
            DataBaseCommand.Connection = DataBaseConnection
            DataBaseCommand.CommandText = SQLCommand
            Dim DataBaseAdapter As New SQLite.SQLiteDataAdapter(DataBaseCommand)
            DataBaseAdapter.Fill(DataSetTemp)
            If DataBaseConnection.State = System.Data.ConnectionState.Open Then
                DataBaseConnection.Close()
            End If
            Return DataSetTemp
            DataSetTemp.Dispose()
        Catch Ex As Exception
            If DataBaseConnection.State = System.Data.ConnectionState.Open Then
                DataBaseConnection.Close()
            End If
            Return DataSetTemp
        End Try
    End Function '数据库查询
    Sub SQLDataBaseExecute(ByVal SQLCommand As String, ByVal DataBaseConnection As SQLite.SQLiteConnection)
        Try
            If DataBaseConnection.State = System.Data.ConnectionState.Closed Then
                DataBaseConnection.Open()
            End If
            DataBaseCommand.Connection = DataBaseConnection
            DataBaseCommand.CommandText = SQLCommand
            DataBaseCommand.ExecuteNonQuery()
        Catch Ex As Exception
        End Try
        If DataBaseConnection.State = System.Data.ConnectionState.Open Then
            DataBaseConnection.Close()
        End If
    End Sub '数据库操作指令
#End Region
    Private Sub FormMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = My.Application.Info.AssemblyName & "[" & My.Application.Info.Version.ToString & "]"
        SecondTimer.Enabled = True
        SynFilesDataBaseConnection.ConnectionString = DataBaseCodeVerify("PrivateSynBak.db", SynFilesDataBaseConnection)
        ReadDataBase()
        CheckBox1_CheckedChanged(Nothing, Nothing)
    End Sub '开始
    Sub ReadDataBase()
        SettingDataBase = SQLDataBaseQeury("SELECT * FROM Settings Where Setting = True", SynFilesDataBaseConnection)
        If SettingDataBase.Tables(0).Rows.Count > 0 Then
            Me.Height = SettingDataBase.Tables(0).Rows(0).Item("Height")
            Me.Width = SettingDataBase.Tables(0).Rows(0).Item("Width")

            NumericUpDown1.Value = SettingDataBase.Tables(0).Rows(0).Item("SynTime")
            CheckBox1.Checked = Not SettingDataBase.Tables(0).Rows(0).Item("AutoSyn") '后面还有一次反转

            Me.WindowState = SettingDataBase.Tables(0).Rows(0).Item("Winstate")
            If WindowState = FormWindowState.Minimized Then
                WindowState = FormWindowState.Normal
            End If
        Else
            SQLDataBaseExecute("INSERT INTO Settings VALUES(" & True & ",0," & Me.MinimumSize.Width & "," & Me.MinimumSize.Height & ",60," & True & ")", SynFilesDataBaseConnection)
        End If
        NumArrlist.Clear()
        PathStrArr.Clear()
        SynFliesDataBase = SQLDataBaseQeury("SELECT * FROM PrivateSynBakSaveData ORDER BY AddTime ASC", SynFilesDataBaseConnection)
        If DataGridView_Main.Rows.Count > 0 Then
            Do
                DataGridView_Main.Rows.RemoveAt(0)
            Loop While DataGridView_Main.Rows.Count > 0
        End If
        For i = 0 To SynFliesDataBase.Tables(0).Rows.Count - 1
            DataGridView_Main.Rows.Add()
            DataGridView_Main.Rows(DataGridView_Main.Rows.Count - 1).Cells("Column_Num").Value = SynFliesDataBase.Tables(0).Rows(i).Item("Num")
            NumArrlist.Add(SynFliesDataBase.Tables(0).Rows(i).Item("Num").ToString)
            DataGridView_Main.Rows(DataGridView_Main.Rows.Count - 1).Cells("Column_Sourse").Value = SynFliesDataBase.Tables(0).Rows(i).Item("SoursePath")
            PathStrArr.Add(SynFliesDataBase.Tables(0).Rows(i).Item("SoursePath"))
            DataGridView_Main.Rows(DataGridView_Main.Rows.Count - 1).Cells("Column_TargetPath").Value = SynFliesDataBase.Tables(0).Rows(i).Item("TargetFloder")
            DataGridView_Main.Rows(DataGridView_Main.Rows.Count - 1).Cells("Column_TypeFlag").Value = SynFliesDataBase.Tables(0).Rows(i).Item("TypeFlag")
            DataGridView_Main.Rows(DataGridView_Main.Rows.Count - 1).Cells("Column_TypeStr").Value = TypeFlagToStr(SynFliesDataBase.Tables(0).Rows(i).Item("TypeFlag"))
            DataGridView_Main.Rows(DataGridView_Main.Rows.Count - 1).Cells("Column_NewFlag").Value = False
            DataGridView_Main.Rows(DataGridView_Main.Rows.Count - 1).Cells("Column_New").Value = NewFlagToStr(False)
            DataGridView_Main.Rows(DataGridView_Main.Rows.Count - 1).Cells("Column_AddTime").Value = SynFliesDataBase.Tables(0).Rows(i).Item("AddTime")
            DataGridView_Main.Rows(DataGridView_Main.Rows.Count - 1).Cells("Column_SubStoreFlag").Value = Convert.ToBoolean(SynFliesDataBase.Tables(0).Rows(i).Item("SubStoreFlag"))
            DataGridView_Main.Rows(DataGridView_Main.Rows.Count - 1).Cells("Column_SubStore").Value = SubStoreFlagToStr(Convert.ToBoolean(SynFliesDataBase.Tables(0).Rows(i).Item("SubStoreFlag")))
        Next
        If DataGridView_Main.Rows.Count > 0 Then
            DataGridView_Main.Rows(DataGridView_Main.Rows.Count - 1).Cells("Column_Num").Selected = True
        End If
    End Sub '读取历史
    Private Sub TextBox1_DragDrop(sender As Object, e As DragEventArgs) Handles TextBox1.DragDrop
        If IO.Directory.Exists(TargetPath) Then
            AddGrid(CType(e.Data.GetData(DataFormats.FileDrop, False), String()).Clone)
        Else
            MsgBox("请先选择备份文件夹.", MsgBoxStyle.OkOnly, "未选择备份文件夹.")
            TargetPath = IO.Directory.GetCurrentDirectory & "\DefaultBakFloder"
            If IO.Directory.Exists(TargetPath) = False Then
                IO.Directory.CreateDirectory(TargetPath)
            End If
            TextBox5.Text = TargetPath
        End If
    End Sub '拖动文件夹
    Sub AddGrid(ByVal FileCollections As Array)
        If FileCollections.Length > 0 Then
            For i = 0 To FileCollections.Length - 1
                Dim TypeFlagNum As Integer = Jugg(FileCollections(i))
                If TypeFlagNum = -1 Then
                    TextBox_Log.Text &= vbCrLf & "识别错误 - [" & FileCollections(i) & "]."
                ElseIf IO.Directory.Exists(TargetPath) = False Then
                    TextBox_Log.Text &= vbCrLf & "备份文件夹不存在 - [" & TargetPath & "]."
                ElseIf PathStrArr.Contains(FileCollections(i)) AndAlso checkrepeat(FileCollections(i), TargetPath) = True Then
                    TextBox_Log.Text &= vbCrLf & "文件已存在 - [" & IO.Path.GetFileName(FileCollections(i)) & "]."
                Else
                    DataGridView_Main.Rows.Add()
                    Dim MinNum As Integer = GetMinNum(NumArrlist)
                    DataGridView_Main.Rows(DataGridView_Main.Rows.Count - 1).Cells("Column_Num").Value = MinNum
                    NumArrlist.Add(MinNum.ToString)
                    DataGridView_Main.Rows(DataGridView_Main.Rows.Count - 1).Cells("Column_Sourse").Value = FileCollections(i)
                    PathStrArr.Add(FileCollections(i))
                    DataGridView_Main.Rows(DataGridView_Main.Rows.Count - 1).Cells("Column_TargetPath").Value = TargetPath
                    DataGridView_Main.Rows(DataGridView_Main.Rows.Count - 1).Cells("Column_TypeFlag").Value = Convert.ToBoolean(TypeFlagNum)
                    DataGridView_Main.Rows(DataGridView_Main.Rows.Count - 1).Cells("Column_TypeStr").Value = TypeFlagToStr(Convert.ToBoolean(TypeFlagNum))
                    DataGridView_Main.Rows(DataGridView_Main.Rows.Count - 1).Cells("Column_NewFlag").Value = True
                    DataGridView_Main.Rows(DataGridView_Main.Rows.Count - 1).Cells("Column_New").Value = NewFlagToStr(True)
                    DataGridView_Main.Rows(DataGridView_Main.Rows.Count - 1).Cells("Column_AddTime").Value = Format(Now, "yyyy-MM-dd HH:mm:ss")
                    DataGridView_Main.Rows(DataGridView_Main.Rows.Count - 1).Cells("Column_SubStoreFlag").Value = CheckBox2.Checked
                    DataGridView_Main.Rows(DataGridView_Main.Rows.Count - 1).Cells("Column_SubStore").Value = SubStoreFlagToStr(Convert.ToBoolean(CheckBox2.Checked))
                    TextBox_Log.Text &= vbCrLf & "成功添加 - [" & IO.Path.GetFileName(FileCollections(i)) & "]."
                End If
            Next
        End If
    End Sub
    Function CheckRepeat(ByVal SourName As String, ByVal TarPath As String) As Boolean
        Dim Result As Boolean = False
        For i = 0 To DataGridView_Main.Rows.Count - 1
            If DataGridView_Main.Rows(i).Cells("Column_Sourse").Value = SourName AndAlso DataGridView_Main.Rows(i).Cells("Column_TargetPath").Value = TarPath Then
                Result = True
                Exit For
            End If
        Next
        Return Result
    End Function
    Private Sub TextBox2_DragDrop(sender As Object, e As DragEventArgs) Handles TextBox2.DragDrop
        Dim PathStr() As String = CType(e.Data.GetData(DataFormats.FileDrop, False), String())
        If PathStr.Count > 0 Then
            If IO.Directory.Exists(PathStr(0)) Then
                TargetPath = PathStr(0)
            ElseIf IO.File.Exists(PathStr(0)) Then
                TargetPath = IO.Directory.GetParent(PathStr(0)).ToString()
            Else
                TargetPath = "无效路径."
            End If
            TextBox5.Text = TargetPath
        End If
    End Sub '拖动文件
    Private Sub TextBox1_DragEnter(sender As Object, e As DragEventArgs) Handles TextBox1.DragEnter
        If (e.Data.GetDataPresent(DataFormats.FileDrop)) Then
            e.Effect = DragDropEffects.All
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub
    Private Sub TextBox2_DragEnter(sender As Object, e As DragEventArgs) Handles TextBox2.DragEnter
        If (e.Data.GetDataPresent(DataFormats.FileDrop)) Then
            e.Effect = DragDropEffects.All
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub
    Function TypeFlagToStr(ByVal Flag As Boolean) As String
        If Flag Then
            Return "文件"
        Else
            Return "文件夹"
        End If
    End Function
    Function NewFlagToStr(ByVal Flag As Boolean) As String
        If Flag = False Then
            Return "记忆"
        Else
            Return "新增"
        End If
    End Function
    Function SubStoreFlagToStr(ByVal Flag As Boolean) As String
        If Flag Then
            Return "副本存储"
        Else
            Return "覆盖存储"
        End If
    End Function
    Function GetMinNum(ByVal NowArrList As ArrayList) As Integer
        Dim GetFlag As Boolean = False
        Dim Num_T As Integer = NowArrList.Count
        For i = NowArrList.Count - 1 To 0 Step -1
            If NowArrList.Contains(i.ToString) = False Then
                Num_T = i
                GetFlag = True
                Exit For
            End If
        Next
        If GetFlag = False Then
            Do While NowArrList.Contains(Num_T.ToString)
                Num_T += 1
            Loop
        End If
        Return Num_T
    End Function '获取DataSet中空白序号最小值
    Function Jugg(ByVal Path As String) As Integer
        If IO.File.Exists(Path) Then
            Return 1
        ElseIf IO.Directory.Exists(Path) Then
            Return 0
        Else
            Return -1
        End If
    End Function
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click, TextBox2.Click
        FolderBrowserDialog1.ShowDialog()
        Dim Path As String = FolderBrowserDialog1.SelectedPath
        If IO.Directory.Exists(Path) Then
            TargetPath = Path
            TextBox5.Text = Path
        End If
    End Sub
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click, TextBox1.Click
        If IO.Directory.Exists(TargetPath) Then
            OpenFileDialog1.ShowDialog()
            Dim PathArr As String() = OpenFileDialog1.FileNames
            If PathArr.Count > 0 Then
                AddGrid(PathArr)
            End If
        Else
            MsgBox("请先选择备份文件夹.", MsgBoxStyle.OkOnly, "未选择备份文件夹.")
            TargetPath = IO.Directory.GetCurrentDirectory & "\DefaultBakFloder"
            If IO.Directory.Exists(TargetPath) = False Then
                IO.Directory.CreateDirectory(TargetPath)
            End If
            TextBox5.Text = TargetPath
        End If

    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click, PictureBox6.Click
        For i = 0 To DataGridView_Main.Rows.Count - 1
            If Convert.ToBoolean(DataGridView_Main.Rows(i).Cells("Column_NewFlag").Value) Then
                Dim Spath As String = DataGridView_Main.Rows(i).Cells("Column_Sourse").Value
                Dim Tpath As String = DataGridView_Main.Rows(i).Cells("Column_TargetPath").Value
                Dim SaveText As String = "Insert INTO PrivateSynBakSaveData VALUES(" &
                     DataGridView_Main.Rows(i).Cells("Column_Num").Value &
                     ",'" & Spath & "','" & Tpath & "'," &
                     Convert.ToBoolean(DataGridView_Main.Rows(i).Cells("Column_TypeFlag").Value) & ",'" &
                     DataGridView_Main.Rows(i).Cells("Column_AddTime").Value & "'," & DataGridView_Main.Rows(i).Cells("Column_SubStoreFlag").Value & ")"
                Try
                    SQLDataBaseQeury(SaveText, SynFilesDataBaseConnection)
                Catch ex As Exception
                    MsgBox(ex.Message.ToString)
                End Try
                TextBox_Log.Text &= vbCrLf & Now & " - 成功存储条目[" & IO.Path.GetFileName(Spath) & "]->" & IO.Path.GetDirectoryName(Tpath)
            End If
        Next
        ReadDataBase()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click， PictureBox5.Click
        NextWorkDate = DateAdd(DateInterval.Minute, NumericUpDown1.Value, Now)
        SubStoreName = "\" & Date.Now.ToString("yyyy-MM-dd HH-mm") & "\"
        SynArr.Clear()
        SynSuccess = 0
        SynFailue = 0
        For I = 0 To DataGridView_Main.Rows.Count - 1
            SynArr.Add(DataGridView_Main.Rows(I).Cells("Column_Num").Value)
        Next
        FinishFlag = False
        SynTimer.Interval = 1000
        SynTimer.Enabled = True
        If Me.WindowState = FormWindowState.Minimized Then
            NotifyIcon1.ShowBalloonTip(1000, "Notice", Now & " - 第" & AutoNum & "轮后台同步开始:", ToolTipIcon.Info)
        End If
    End Sub
    Sub Syn(ByVal Syn_Index As Integer, ByVal AllSyn As Boolean)
        If Syn_Index <> -1 Then
            Dim Spath As String = DataGridView_Main.Rows(Syn_Index).Cells("Column_Sourse").Value
            Dim Tpath As String = DataGridView_Main.Rows(Syn_Index).Cells("Column_TargetPath").Value
            If DataGridView_Main.Rows(Syn_Index).Cells("Column_SubStoreFlag").Value Then
                Tpath &= SubStoreName
                If IO.Directory.Exists(Tpath) = False Then
                    IO.Directory.CreateDirectory(Tpath)
                End If
            End If
            Try
                Select Case DataGridView_Main.Rows(Syn_Index).Cells("Column_TypeFlag").Value
                    Case True
                        '//IO.File.Copy(Spath, Tpath & "\" & IO.Path.GetFileName(Spath), True)
                        My.Computer.FileSystem.CopyFile(Spath, Tpath & "\" & IO.Path.GetFileName(Spath), True)
                    Case False
                        My.Computer.FileSystem.CopyDirectory(Spath, Tpath & "\" & IO.Path.GetFileName(Spath), True)
                End Select
                TextBox_Log.Text &= vbCrLf & Now & " - 备份[" & IO.Path.GetFileName(Spath) &
                    "] -> {" & IO.Path.GetDirectoryName(Tpath & "\" & IO.Path.GetFileName(Spath)) & "\}"
                SynSuccess += 1
            Catch ex As Exception
                TextBox_Log.Text &= vbCrLf & Now & " - " & ex.Message.ToString
                SynFailue += 1
            End Try
        End If
        If AllSyn Then
            NowIndex += 1
            If NowIndex >= SynArr.Count Then
                NowIndex = 0
                ToolStripStatusLabel2.Text = "."
                SynTimer.Enabled = False
                FinishFlag = True
                TextBox_Log.Text &= vbCrLf & Now & " - 第" & AutoNum & "轮同步完成.(总计:" & SynSuccess + SynFailue & "/成功:" & SynSuccess & "/失败:" & SynFailue & ")" & vbCrLf
                If Me.WindowState = FormWindowState.Minimized Then
                    NotifyIcon1.ShowBalloonTip(1000, "Notice", Now & " - 第" & AutoNum & "轮同步后台完成.(总计:" & SynSuccess + SynFailue & "/成功:" & SynSuccess & "/失败:" & SynFailue & ").", ToolTipIcon.Info)
                End If
            End If
        End If
    End Sub
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.Click
        NextWorkDate = DateAdd(DateInterval.Minute, NumericUpDown1.Value, Now)
        CheckBox1.Checked = Not CheckBox1.Checked
        NumericUpDown1.Enabled = Not CheckBox1.Checked
        SynWorkTimer.Interval = 1000 * 60 * NumericUpDown1.Value
        SynWorkTimer.Enabled = CheckBox1.Checked
        AutoNum = 1
    End Sub '开始自动值守
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If DataGridView_Main.CurrentRow.Index <> -1 Then
            Dim DelNum As Integer = DataGridView_Main.Rows(DataGridView_Main.CurrentRow.Index).Cells("Column_Num").Value
            SQLDataBaseExecute("DELETE FROM PrivateSynBakSaveData WHERE NUM = " & DelNum, SynFilesDataBaseConnection)
            ReadDataBase()
        End If
    End Sub '删除
    Private Sub FormMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If TrueClose Then
            NotifyIcon1.Dispose()
        Else
            e.Cancel = True
            NotifyIcon1.Visible = True
            Me.WindowState = FormWindowState.Minimized
        End If
    End Sub
    Private Sub FormMain_MinimumSizeChanged(sender As Object, e As EventArgs) Handles MyBase.Resize
        If Me.WindowState = FormWindowState.Minimized Then
            Me.ShowInTaskbar = False
            NotifyIcon1.Visible = True
        Else
            Me.ShowInTaskbar = True
        End If
    End Sub
    Private Sub NotifyIcon1_MouseClick(sender As Object, e As MouseEventArgs) Handles NotifyIcon1.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Me.WindowState = FormWindowState.Normal
            Me.TopMost = True
            Me.TopMost = False
            NotifyIcon1.Visible = False
        ElseIf e.Button = Windows.Forms.MouseButtons.Right Then
            ContextMenuStrip1.Show()
        End If
    End Sub
    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        MeClose()
    End Sub
    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        Me.WindowState = FormWindowState.Normal
        NotifyIcon1.Visible = False
    End Sub
    Private Sub 退出XToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles 退出XToolStripMenuItem1.Click
        MeClose()
    End Sub
    Private Sub TextBox_Log_TextChanged(sender As Object, e As EventArgs) Handles TextBox_Log.TextChanged
        TextBox_Log.SelectionStart = TextBox_Log.TextLength
        TextBox_Log.ScrollToCaret()
    End Sub '滚动
    Private Sub SynTimer_Time() Handles SynTimer.Tick
        ToolStripStatusLabel2.Text = "正在同步(" & NowIndex & "/" & SynArr.Count & ")"
        Syn(QurIndex(SynArr(NowIndex)), True)
    End Sub '计时器
    Private Sub 开机启动OToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 开机启动OToolStripMenuItem.Click
        Try
            CreateStartup()
            开机启动OToolStripMenuItem.Text = "设置开机启动√(&O)"
            MsgBox("设置成功.")
        Catch ex As Exception
            开机启动OToolStripMenuItem.Text = "设置开机启动(&O)"
            MsgBox("设置失败.")
        End Try
    End Sub
    Private Sub CreateStartup()
        Dim WScript_T As Object = CreateObject("WScript.Shell")
        Dim StartupPath = Environment.GetFolderPath(Environment.SpecialFolder.Startup)
        Dim AppName = My.Application.Info.ProductName
        'Dim desk As String = WScript_T.SpecialFolders("Desktop")
        Dim AppInk As Object = WScript_T.CreateShortcut(StartupPath & "\" & AppName & ".exe.lnk")
        'If Not IO.File.Exists(AppInk) Then
        With AppInk
            .Description = "PrivateSynBak.Ink"
            .IconLocation = Application.StartupPath + "\" + My.Application.Info.AssemblyName & ".exe,0"
            .TargetPath = Application.StartupPath + "\" + My.Application.Info.AssemblyName & ".exe "
            .WindowStyle = 7 '打开窗体的风格，最小化
                .WorkingDirectory = Application.StartupPath '工作路径
                .Save() '保存快捷方式
            End With
        'End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click, PictureBox7.Click
        Syn(DataGridView_Main.CurrentRow.Index, False)
    End Sub
    Private Sub CheckBox2_Click(sender As Object, e As EventArgs) Handles CheckBox2.Click
        CheckBox2.Checked = Not CheckBox2.Checked
    End Sub
    Private Sub SecondTimer_Time() Handles SecondTimer.Tick
        If SynWorkTimer.Enabled Then
            ToolStripStatusLabel1.Text = "自动同步值守:[" & NextWorkDate & "] - " & "剩余:" & DateDiff(DateInterval.Minute, NextWorkDate, Now) & "分钟."
        Else
            ToolStripStatusLabel1.Text = "自动同步值守:关."
        End If
        TimeToolStripMenuItem.Text = Now
    End Sub '计时器
    Private Sub SynWork_Time() Handles SynWorkTimer.Tick
        If FinishFlag Then
            Button1_Click(Nothing, Nothing)
            TextBox_Log.Text &= vbCrLf & Now & " - 开始第" & AutoNum & "次同步."
            NextWorkDate = DateAdd(DateInterval.Minute, NumericUpDown1.Value, Now)
            AutoNum += 1
        Else
            TextBox_Log.Text &= vbCrLf & Now & " - 同步未完成,自动值守已自动延迟."
        End If
    End Sub '计时器
    Function QurIndex(ByVal Num As Integer) As Integer
        Dim ReturnIndex As Integer = -1
        For i = 0 To DataGridView_Main.Rows.Count - 1
            If Num = DataGridView_Main.Rows(i).Cells("Column_Num").Value Then
                ReturnIndex = i
            End If
        Next
        Return ReturnIndex
    End Function '查询
    Sub MeClose()
        Try
            SQLDataBaseExecute("UPDATE Settings SET Winstate = " & Me.WindowState & " ,Width =" & Me.Width & " ,Height = " & Me.Height & " ,SynTime = " & NumericUpDown1.Value & " ,AutoSyn = " & CheckBox1.Checked & " WHERE Setting = True ", SynFilesDataBaseConnection)
        Catch ex As Exception
        End Try
        Dim CheckNew As Boolean = False
        For I = DataGridView_Main.Rows.Count - 1 To 0 Step -1
            If DataGridView_Main.Rows(I).Cells("Column_NewFlag").Value = True Then
                CheckNew = True
                Exit For
            End If
        Next
        If CheckNew Then
            Dim MsgResult_T As MsgBoxResult = MsgBox("是否保存当前新增条目后退出?", MsgBoxStyle.YesNoCancel, "存在尚未保存条目!")
            If MsgResult_T = MsgBoxResult.Yes Then
                Button2_Click(Nothing, Nothing)
                TrueClose = True
                Me.Close()
            ElseIf MsgResult_T = MsgBoxResult.No Then
                TrueClose = True
                Me.Close()
            Else
                'Do Nothing
            End If
        Else
            TrueClose = True
            Me.Close()
        End If
    End Sub
End Class
