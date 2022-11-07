<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormMain
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMain))
        Me.DataGridView_Main = New System.Windows.Forms.DataGridView()
        Me.Column_Num = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column_AddTime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column_Sourse = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column_TypeFlag = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column_TypeStr = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column_TargetPath = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column_New = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column_NewFlag = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column_SubStore = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column_SubStoreFlag = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.退出XToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.文件FToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.新建NToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.打开OToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.保存SToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.另存为AToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.打印PToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.打印预览VToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.退出XToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.编辑EToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.撤消UToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.重复RToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.剪切TToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.复制CToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.粘贴PToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.全选AToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.工具TToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.自定义CToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.选项OToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.帮助HToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.内容CToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.索引IToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.搜索SToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.关于AToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TimeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.开机启动OToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.TextBox_Log = New System.Windows.Forms.TextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        CType(Me.DataGridView_Main, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel8.SuspendLayout()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel7.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView_Main
        '
        Me.DataGridView_Main.AllowUserToAddRows = False
        Me.DataGridView_Main.AllowUserToResizeRows = False
        Me.DataGridView_Main.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_Main.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column_Num, Me.Column_AddTime, Me.Column_Sourse, Me.Column_TypeFlag, Me.Column_TypeStr, Me.Column_TargetPath, Me.Column_New, Me.Column_NewFlag, Me.Column_SubStore, Me.Column_SubStoreFlag})
        Me.DataGridView_Main.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView_Main.Location = New System.Drawing.Point(0, 54)
        Me.DataGridView_Main.MultiSelect = False
        Me.DataGridView_Main.Name = "DataGridView_Main"
        Me.DataGridView_Main.ReadOnly = True
        Me.DataGridView_Main.RowHeadersVisible = False
        Me.DataGridView_Main.RowHeadersWidth = 51
        Me.DataGridView_Main.RowTemplate.Height = 27
        Me.DataGridView_Main.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView_Main.Size = New System.Drawing.Size(778, 285)
        Me.DataGridView_Main.TabIndex = 0
        '
        'Column_Num
        '
        Me.Column_Num.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column_Num.HeaderText = "序号"
        Me.Column_Num.MinimumWidth = 10
        Me.Column_Num.Name = "Column_Num"
        Me.Column_Num.ReadOnly = True
        Me.Column_Num.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Column_Num.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.Column_Num.Width = 66
        '
        'Column_AddTime
        '
        Me.Column_AddTime.HeaderText = "添加时间"
        Me.Column_AddTime.MinimumWidth = 6
        Me.Column_AddTime.Name = "Column_AddTime"
        Me.Column_AddTime.ReadOnly = True
        Me.Column_AddTime.Visible = False
        Me.Column_AddTime.Width = 125
        '
        'Column_Sourse
        '
        Me.Column_Sourse.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column_Sourse.HeaderText = "同步文件"
        Me.Column_Sourse.MinimumWidth = 80
        Me.Column_Sourse.Name = "Column_Sourse"
        Me.Column_Sourse.ReadOnly = True
        '
        'Column_TypeFlag
        '
        Me.Column_TypeFlag.HeaderText = "类型Flag"
        Me.Column_TypeFlag.MinimumWidth = 6
        Me.Column_TypeFlag.Name = "Column_TypeFlag"
        Me.Column_TypeFlag.ReadOnly = True
        Me.Column_TypeFlag.Visible = False
        Me.Column_TypeFlag.Width = 125
        '
        'Column_TypeStr
        '
        Me.Column_TypeStr.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column_TypeStr.HeaderText = "类型"
        Me.Column_TypeStr.MinimumWidth = 6
        Me.Column_TypeStr.Name = "Column_TypeStr"
        Me.Column_TypeStr.ReadOnly = True
        Me.Column_TypeStr.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Column_TypeStr.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Column_TypeStr.Width = 43
        '
        'Column_TargetPath
        '
        Me.Column_TargetPath.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column_TargetPath.HeaderText = "目标文件夹"
        Me.Column_TargetPath.MinimumWidth = 100
        Me.Column_TargetPath.Name = "Column_TargetPath"
        Me.Column_TargetPath.ReadOnly = True
        '
        'Column_New
        '
        Me.Column_New.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column_New.HeaderText = "记忆"
        Me.Column_New.MinimumWidth = 40
        Me.Column_New.Name = "Column_New"
        Me.Column_New.ReadOnly = True
        Me.Column_New.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Column_New.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Column_New.Width = 43
        '
        'Column_NewFlag
        '
        Me.Column_NewFlag.HeaderText = "记忆Flag"
        Me.Column_NewFlag.MinimumWidth = 6
        Me.Column_NewFlag.Name = "Column_NewFlag"
        Me.Column_NewFlag.ReadOnly = True
        Me.Column_NewFlag.Visible = False
        Me.Column_NewFlag.Width = 125
        '
        'Column_SubStore
        '
        Me.Column_SubStore.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column_SubStore.HeaderText = "存储形式"
        Me.Column_SubStore.MinimumWidth = 80
        Me.Column_SubStore.Name = "Column_SubStore"
        Me.Column_SubStore.ReadOnly = True
        Me.Column_SubStore.Width = 96
        '
        'Column_SubStoreFlag
        '
        Me.Column_SubStoreFlag.HeaderText = "存储Flag"
        Me.Column_SubStoreFlag.MinimumWidth = 6
        Me.Column_SubStoreFlag.Name = "Column_SubStoreFlag"
        Me.Column_SubStoreFlag.ReadOnly = True
        Me.Column_SubStoreFlag.Visible = False
        Me.Column_SubStoreFlag.Width = 125
        '
        'PictureBox2
        '
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(56, 75)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 2
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(56, 75)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'TextBox1
        '
        Me.TextBox1.AllowDrop = True
        Me.TextBox1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.TextBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox1.Font = New System.Drawing.Font("微软雅黑", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(56, 0)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(172, 75)
        Me.TextBox1.TabIndex = 3
        Me.TextBox1.Text = " DragHere Add Files"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.TextBox2)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(228, 75)
        Me.Panel1.TabIndex = 4
        '
        'TextBox2
        '
        Me.TextBox2.AllowDrop = True
        Me.TextBox2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.TextBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox2.Font = New System.Drawing.Font("微软雅黑", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(56, 0)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(172, 75)
        Me.TextBox2.TabIndex = 4
        Me.TextBox2.Text = " DragHere Set Floder"
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.TextBox1)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 75)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(228, 75)
        Me.Panel2.TabIndex = 5
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Panel8)
        Me.Panel3.Controls.Add(Me.Panel7)
        Me.Panel3.Controls.Add(Me.Panel5)
        Me.Panel3.Controls.Add(Me.CheckBox2)
        Me.Panel3.Controls.Add(Me.Panel6)
        Me.Panel3.Controls.Add(Me.Panel2)
        Me.Panel3.Controls.Add(Me.Panel1)
        Me.Panel3.Controls.Add(Me.GroupBox1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(778, 27)
        Me.Panel3.MinimumSize = New System.Drawing.Size(200, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(228, 501)
        Me.Panel3.TabIndex = 6
        '
        'Panel8
        '
        Me.Panel8.Controls.Add(Me.Button4)
        Me.Panel8.Controls.Add(Me.PictureBox7)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel8.Location = New System.Drawing.Point(0, 253)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(228, 51)
        Me.Panel8.TabIndex = 13
        '
        'Button4
        '
        Me.Button4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button4.Location = New System.Drawing.Point(56, 0)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(172, 51)
        Me.Button4.TabIndex = 2
        Me.Button4.Text = "备份选中"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'PictureBox7
        '
        Me.PictureBox7.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox7.Image = CType(resources.GetObject("PictureBox7.Image"), System.Drawing.Image)
        Me.PictureBox7.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(56, 51)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox7.TabIndex = 1
        Me.PictureBox7.TabStop = False
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.Button3)
        Me.Panel7.Controls.Add(Me.PictureBox3)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel7.Location = New System.Drawing.Point(0, 211)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(228, 42)
        Me.Panel7.TabIndex = 9
        '
        'Button3
        '
        Me.Button3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button3.Location = New System.Drawing.Point(56, 0)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(172, 42)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "删除选中"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'PictureBox3
        '
        Me.PictureBox3.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(56, 42)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 1
        Me.PictureBox3.TabStop = False
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.Button2)
        Me.Panel5.Controls.Add(Me.PictureBox6)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(0, 169)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(228, 42)
        Me.Panel5.TabIndex = 7
        '
        'Button2
        '
        Me.Button2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button2.Location = New System.Drawing.Point(56, 0)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(172, 42)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "保存列表"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'PictureBox6
        '
        Me.PictureBox6.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), System.Drawing.Image)
        Me.PictureBox6.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(56, 42)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox6.TabIndex = 1
        Me.PictureBox6.TabStop = False
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoCheck = False
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.CheckBox2.Location = New System.Drawing.Point(0, 150)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(228, 19)
        Me.CheckBox2.TabIndex = 12
        Me.CheckBox2.Text = "备份为副本"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.Button1)
        Me.Panel6.Controls.Add(Me.PictureBox5)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel6.Location = New System.Drawing.Point(0, 399)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(228, 51)
        Me.Panel6.TabIndex = 8
        '
        'Button1
        '
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button1.Location = New System.Drawing.Point(56, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(172, 51)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "全部备份"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PictureBox5
        '
        Me.PictureBox5.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(56, 51)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox5.TabIndex = 1
        Me.PictureBox5.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.NumericUpDown1)
        Me.GroupBox1.Controls.Add(Me.CheckBox1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupBox1.Location = New System.Drawing.Point(0, 450)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(228, 51)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "设置"
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NumericUpDown1.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.NumericUpDown1.Increment = New Decimal(New Integer() {10, 0, 0, 0})
        Me.NumericUpDown1.Location = New System.Drawing.Point(92, 21)
        Me.NumericUpDown1.Maximum = New Decimal(New Integer() {1440, 0, 0, 0})
        Me.NumericUpDown1.Minimum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(133, 25)
        Me.NumericUpDown1.TabIndex = 1
        Me.NumericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.NumericUpDown1.Value = New Decimal(New Integer() {60, 0, 0, 0})
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoCheck = False
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.CheckBox1.Location = New System.Drawing.Point(3, 21)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(89, 27)
        Me.CheckBox1.TabIndex = 0
        Me.CheckBox1.Text = "自动同步"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel2})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 528)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1006, 25)
        Me.StatusStrip1.TabIndex = 7
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(12, 19)
        Me.ToolStripStatusLabel1.Text = "."
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.退出XToolStripMenuItem1, Me.文件FToolStripMenuItem, Me.编辑EToolStripMenuItem, Me.工具TToolStripMenuItem, Me.帮助HToolStripMenuItem, Me.TimeToolStripMenuItem, Me.开机启动OToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1006, 27)
        Me.MenuStrip1.TabIndex = 8
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        '退出XToolStripMenuItem1
        '
        Me.退出XToolStripMenuItem1.Name = "退出XToolStripMenuItem1"
        Me.退出XToolStripMenuItem1.Size = New System.Drawing.Size(73, 23)
        Me.退出XToolStripMenuItem1.Text = "退出(&X)"
        '
        '文件FToolStripMenuItem
        '
        Me.文件FToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.新建NToolStripMenuItem, Me.打开OToolStripMenuItem, Me.toolStripSeparator, Me.保存SToolStripMenuItem, Me.另存为AToolStripMenuItem, Me.toolStripSeparator1, Me.打印PToolStripMenuItem, Me.打印预览VToolStripMenuItem, Me.toolStripSeparator2, Me.退出XToolStripMenuItem})
        Me.文件FToolStripMenuItem.Name = "文件FToolStripMenuItem"
        Me.文件FToolStripMenuItem.Size = New System.Drawing.Size(71, 23)
        Me.文件FToolStripMenuItem.Text = "文件(&F)"
        Me.文件FToolStripMenuItem.Visible = False
        '
        '新建NToolStripMenuItem
        '
        Me.新建NToolStripMenuItem.Image = CType(resources.GetObject("新建NToolStripMenuItem.Image"), System.Drawing.Image)
        Me.新建NToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.新建NToolStripMenuItem.Name = "新建NToolStripMenuItem"
        Me.新建NToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.新建NToolStripMenuItem.Size = New System.Drawing.Size(201, 26)
        Me.新建NToolStripMenuItem.Text = "新建(&N)"
        '
        '打开OToolStripMenuItem
        '
        Me.打开OToolStripMenuItem.Image = CType(resources.GetObject("打开OToolStripMenuItem.Image"), System.Drawing.Image)
        Me.打开OToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.打开OToolStripMenuItem.Name = "打开OToolStripMenuItem"
        Me.打开OToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.打开OToolStripMenuItem.Size = New System.Drawing.Size(201, 26)
        Me.打开OToolStripMenuItem.Text = "打开(&O)"
        '
        'toolStripSeparator
        '
        Me.toolStripSeparator.Name = "toolStripSeparator"
        Me.toolStripSeparator.Size = New System.Drawing.Size(198, 6)
        '
        '保存SToolStripMenuItem
        '
        Me.保存SToolStripMenuItem.Image = CType(resources.GetObject("保存SToolStripMenuItem.Image"), System.Drawing.Image)
        Me.保存SToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.保存SToolStripMenuItem.Name = "保存SToolStripMenuItem"
        Me.保存SToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.保存SToolStripMenuItem.Size = New System.Drawing.Size(201, 26)
        Me.保存SToolStripMenuItem.Text = "保存(&S)"
        '
        '另存为AToolStripMenuItem
        '
        Me.另存为AToolStripMenuItem.Name = "另存为AToolStripMenuItem"
        Me.另存为AToolStripMenuItem.Size = New System.Drawing.Size(201, 26)
        Me.另存为AToolStripMenuItem.Text = "另存为(&A)"
        '
        'toolStripSeparator1
        '
        Me.toolStripSeparator1.Name = "toolStripSeparator1"
        Me.toolStripSeparator1.Size = New System.Drawing.Size(198, 6)
        '
        '打印PToolStripMenuItem
        '
        Me.打印PToolStripMenuItem.Image = CType(resources.GetObject("打印PToolStripMenuItem.Image"), System.Drawing.Image)
        Me.打印PToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.打印PToolStripMenuItem.Name = "打印PToolStripMenuItem"
        Me.打印PToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.打印PToolStripMenuItem.Size = New System.Drawing.Size(201, 26)
        Me.打印PToolStripMenuItem.Text = "打印(&P)"
        '
        '打印预览VToolStripMenuItem
        '
        Me.打印预览VToolStripMenuItem.Image = CType(resources.GetObject("打印预览VToolStripMenuItem.Image"), System.Drawing.Image)
        Me.打印预览VToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.打印预览VToolStripMenuItem.Name = "打印预览VToolStripMenuItem"
        Me.打印预览VToolStripMenuItem.Size = New System.Drawing.Size(201, 26)
        Me.打印预览VToolStripMenuItem.Text = "打印预览(&V)"
        '
        'toolStripSeparator2
        '
        Me.toolStripSeparator2.Name = "toolStripSeparator2"
        Me.toolStripSeparator2.Size = New System.Drawing.Size(198, 6)
        '
        '退出XToolStripMenuItem
        '
        Me.退出XToolStripMenuItem.Name = "退出XToolStripMenuItem"
        Me.退出XToolStripMenuItem.Size = New System.Drawing.Size(201, 26)
        Me.退出XToolStripMenuItem.Text = "退出(&X)"
        '
        '编辑EToolStripMenuItem
        '
        Me.编辑EToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.撤消UToolStripMenuItem, Me.重复RToolStripMenuItem, Me.toolStripSeparator3, Me.剪切TToolStripMenuItem, Me.复制CToolStripMenuItem, Me.粘贴PToolStripMenuItem, Me.toolStripSeparator4, Me.全选AToolStripMenuItem})
        Me.编辑EToolStripMenuItem.Name = "编辑EToolStripMenuItem"
        Me.编辑EToolStripMenuItem.Size = New System.Drawing.Size(71, 23)
        Me.编辑EToolStripMenuItem.Text = "编辑(&E)"
        Me.编辑EToolStripMenuItem.Visible = False
        '
        '撤消UToolStripMenuItem
        '
        Me.撤消UToolStripMenuItem.Name = "撤消UToolStripMenuItem"
        Me.撤消UToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Z), System.Windows.Forms.Keys)
        Me.撤消UToolStripMenuItem.Size = New System.Drawing.Size(197, 26)
        Me.撤消UToolStripMenuItem.Text = "撤消(&U)"
        '
        '重复RToolStripMenuItem
        '
        Me.重复RToolStripMenuItem.Name = "重复RToolStripMenuItem"
        Me.重复RToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Y), System.Windows.Forms.Keys)
        Me.重复RToolStripMenuItem.Size = New System.Drawing.Size(197, 26)
        Me.重复RToolStripMenuItem.Text = "重复(&R)"
        '
        'toolStripSeparator3
        '
        Me.toolStripSeparator3.Name = "toolStripSeparator3"
        Me.toolStripSeparator3.Size = New System.Drawing.Size(194, 6)
        '
        '剪切TToolStripMenuItem
        '
        Me.剪切TToolStripMenuItem.Image = CType(resources.GetObject("剪切TToolStripMenuItem.Image"), System.Drawing.Image)
        Me.剪切TToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.剪切TToolStripMenuItem.Name = "剪切TToolStripMenuItem"
        Me.剪切TToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.剪切TToolStripMenuItem.Size = New System.Drawing.Size(197, 26)
        Me.剪切TToolStripMenuItem.Text = "剪切(&T)"
        '
        '复制CToolStripMenuItem
        '
        Me.复制CToolStripMenuItem.Image = CType(resources.GetObject("复制CToolStripMenuItem.Image"), System.Drawing.Image)
        Me.复制CToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.复制CToolStripMenuItem.Name = "复制CToolStripMenuItem"
        Me.复制CToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.复制CToolStripMenuItem.Size = New System.Drawing.Size(197, 26)
        Me.复制CToolStripMenuItem.Text = "复制(&C)"
        '
        '粘贴PToolStripMenuItem
        '
        Me.粘贴PToolStripMenuItem.Image = CType(resources.GetObject("粘贴PToolStripMenuItem.Image"), System.Drawing.Image)
        Me.粘贴PToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.粘贴PToolStripMenuItem.Name = "粘贴PToolStripMenuItem"
        Me.粘贴PToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.粘贴PToolStripMenuItem.Size = New System.Drawing.Size(197, 26)
        Me.粘贴PToolStripMenuItem.Text = "粘贴(&P)"
        '
        'toolStripSeparator4
        '
        Me.toolStripSeparator4.Name = "toolStripSeparator4"
        Me.toolStripSeparator4.Size = New System.Drawing.Size(194, 6)
        '
        '全选AToolStripMenuItem
        '
        Me.全选AToolStripMenuItem.Name = "全选AToolStripMenuItem"
        Me.全选AToolStripMenuItem.Size = New System.Drawing.Size(197, 26)
        Me.全选AToolStripMenuItem.Text = "全选(&A)"
        '
        '工具TToolStripMenuItem
        '
        Me.工具TToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.自定义CToolStripMenuItem, Me.选项OToolStripMenuItem})
        Me.工具TToolStripMenuItem.Name = "工具TToolStripMenuItem"
        Me.工具TToolStripMenuItem.Size = New System.Drawing.Size(71, 23)
        Me.工具TToolStripMenuItem.Text = "工具(&T)"
        Me.工具TToolStripMenuItem.Visible = False
        '
        '自定义CToolStripMenuItem
        '
        Me.自定义CToolStripMenuItem.Name = "自定义CToolStripMenuItem"
        Me.自定义CToolStripMenuItem.Size = New System.Drawing.Size(157, 26)
        Me.自定义CToolStripMenuItem.Text = "自定义(&C)"
        '
        '选项OToolStripMenuItem
        '
        Me.选项OToolStripMenuItem.Name = "选项OToolStripMenuItem"
        Me.选项OToolStripMenuItem.Size = New System.Drawing.Size(157, 26)
        Me.选项OToolStripMenuItem.Text = "选项(&O)"
        '
        '帮助HToolStripMenuItem
        '
        Me.帮助HToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.内容CToolStripMenuItem, Me.索引IToolStripMenuItem, Me.搜索SToolStripMenuItem, Me.toolStripSeparator5, Me.关于AToolStripMenuItem})
        Me.帮助HToolStripMenuItem.Name = "帮助HToolStripMenuItem"
        Me.帮助HToolStripMenuItem.Size = New System.Drawing.Size(74, 23)
        Me.帮助HToolStripMenuItem.Text = "帮助(&H)"
        Me.帮助HToolStripMenuItem.Visible = False
        '
        '内容CToolStripMenuItem
        '
        Me.内容CToolStripMenuItem.Name = "内容CToolStripMenuItem"
        Me.内容CToolStripMenuItem.Size = New System.Drawing.Size(151, 26)
        Me.内容CToolStripMenuItem.Text = "内容(&C)"
        '
        '索引IToolStripMenuItem
        '
        Me.索引IToolStripMenuItem.Name = "索引IToolStripMenuItem"
        Me.索引IToolStripMenuItem.Size = New System.Drawing.Size(151, 26)
        Me.索引IToolStripMenuItem.Text = "索引(&I)"
        '
        '搜索SToolStripMenuItem
        '
        Me.搜索SToolStripMenuItem.Name = "搜索SToolStripMenuItem"
        Me.搜索SToolStripMenuItem.Size = New System.Drawing.Size(151, 26)
        Me.搜索SToolStripMenuItem.Text = "搜索(&S)"
        '
        'toolStripSeparator5
        '
        Me.toolStripSeparator5.Name = "toolStripSeparator5"
        Me.toolStripSeparator5.Size = New System.Drawing.Size(148, 6)
        '
        '关于AToolStripMenuItem
        '
        Me.关于AToolStripMenuItem.Name = "关于AToolStripMenuItem"
        Me.关于AToolStripMenuItem.Size = New System.Drawing.Size(151, 26)
        Me.关于AToolStripMenuItem.Text = "关于(&A)..."
        '
        'TimeToolStripMenuItem
        '
        Me.TimeToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.TimeToolStripMenuItem.Name = "TimeToolStripMenuItem"
        Me.TimeToolStripMenuItem.Size = New System.Drawing.Size(57, 23)
        Me.TimeToolStripMenuItem.Text = "Time"
        '
        '开机启动OToolStripMenuItem
        '
        Me.开机启动OToolStripMenuItem.Name = "开机启动OToolStripMenuItem"
        Me.开机启动OToolStripMenuItem.Size = New System.Drawing.Size(135, 23)
        Me.开机启动OToolStripMenuItem.Text = "设置开机启动(&O)"
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.TextBox5)
        Me.Panel4.Controls.Add(Me.PictureBox4)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 27)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(778, 27)
        Me.Panel4.TabIndex = 9
        '
        'TextBox5
        '
        Me.TextBox5.AllowDrop = True
        Me.TextBox5.BackColor = System.Drawing.SystemColors.Control
        Me.TextBox5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox5.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TextBox5.Location = New System.Drawing.Point(62, 0)
        Me.TextBox5.Multiline = True
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.ReadOnly = True
        Me.TextBox5.Size = New System.Drawing.Size(716, 27)
        Me.TextBox5.TabIndex = 5
        Me.TextBox5.Text = "目标文件夹"
        '
        'PictureBox4
        '
        Me.PictureBox4.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(62, 27)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 2
        Me.PictureBox4.TabStop = False
        '
        'TextBox_Log
        '
        Me.TextBox_Log.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TextBox_Log.Location = New System.Drawing.Point(0, 339)
        Me.TextBox_Log.Multiline = True
        Me.TextBox_Log.Name = "TextBox_Log"
        Me.TextBox_Log.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TextBox_Log.Size = New System.Drawing.Size(778, 189)
        Me.TextBox_Log.TabIndex = 11
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        Me.OpenFileDialog1.Multiselect = True
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "PrivateSynBak"
        Me.NotifyIcon1.Visible = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.ToolStripMenuItem2})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(109, 52)
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(108, 24)
        Me.ToolStripMenuItem1.Text = "显示"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(108, 24)
        Me.ToolStripMenuItem2.Text = "关闭"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(12, 19)
        Me.ToolStripStatusLabel2.Text = "."
        '
        'FormMain
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1006, 553)
        Me.Controls.Add(Me.DataGridView_Main)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.TextBox_Log)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MinimumSize = New System.Drawing.Size(1024, 600)
        Me.Name = "FormMain"
        Me.Text = "PrivateSynBak"
        CType(Me.DataGridView_Main, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel7.ResumeLayout(False)
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView_Main As DataGridView
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents 文件FToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 新建NToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 打开OToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents toolStripSeparator As ToolStripSeparator
    Friend WithEvents 保存SToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 另存为AToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents toolStripSeparator1 As ToolStripSeparator
    Friend WithEvents 打印PToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 打印预览VToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents toolStripSeparator2 As ToolStripSeparator
    Friend WithEvents 退出XToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 编辑EToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 撤消UToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 重复RToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents toolStripSeparator3 As ToolStripSeparator
    Friend WithEvents 剪切TToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 复制CToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 粘贴PToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents toolStripSeparator4 As ToolStripSeparator
    Friend WithEvents 全选AToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 工具TToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 自定义CToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 选项OToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 帮助HToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 内容CToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 索引IToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 搜索SToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents toolStripSeparator5 As ToolStripSeparator
    Friend WithEvents 关于AToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Panel4 As Panel
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents TextBox_Log As TextBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Panel6 As Panel
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Button3 As Button
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents TimeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NotifyIcon1 As NotifyIcon
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents 退出XToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents 开机启动OToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Column_Num As DataGridViewTextBoxColumn
    Friend WithEvents Column_AddTime As DataGridViewTextBoxColumn
    Friend WithEvents Column_Sourse As DataGridViewTextBoxColumn
    Friend WithEvents Column_TypeFlag As DataGridViewTextBoxColumn
    Friend WithEvents Column_TypeStr As DataGridViewTextBoxColumn
    Friend WithEvents Column_TargetPath As DataGridViewTextBoxColumn
    Friend WithEvents Column_New As DataGridViewTextBoxColumn
    Friend WithEvents Column_NewFlag As DataGridViewTextBoxColumn
    Friend WithEvents Column_SubStore As DataGridViewTextBoxColumn
    Friend WithEvents Column_SubStoreFlag As DataGridViewTextBoxColumn
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Button4 As Button
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents ToolStripStatusLabel2 As ToolStripStatusLabel
End Class
