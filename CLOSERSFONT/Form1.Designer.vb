<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意:  以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請不要使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.BunifuCustomLabel2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.BunifuImageButton1 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuImageButton2 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuImageButton3 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuImageButton4 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New Bunifu.Framework.UI.BunifuProgressBar()
        Me.BunifuImageButton5 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Textbox1 = New Bunifu.Framework.UI.BunifuTextbox()
        Me.BunifuDropdown1 = New System.Windows.Forms.ComboBox()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BunifuImageButton2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BunifuImageButton3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BunifuImageButton4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BunifuImageButton5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuCustomLabel2
        '
        Me.BunifuCustomLabel2.AutoSize = True
        Me.BunifuCustomLabel2.BackColor = System.Drawing.Color.Black
        Me.BunifuCustomLabel2.Font = New System.Drawing.Font("新蒂金钟体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.BunifuCustomLabel2.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel2.Location = New System.Drawing.Point(507, 554)
        Me.BunifuCustomLabel2.Name = "BunifuCustomLabel2"
        Me.BunifuCustomLabel2.Size = New System.Drawing.Size(270, 50)
        Me.BunifuCustomLabel2.TabIndex = 15
        Me.BunifuCustomLabel2.Text = "點選""啟動遊戲"" 待遊戲跑完更新後 " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "選擇字體並點選""更換字體""即可"
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("新蒂金钟体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.BunifuCustomLabel1.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(269, 373)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(80, 25)
        Me.BunifuCustomLabel1.TabIndex = 14
        Me.BunifuCustomLabel1.Text = "遊戲路徑"
        '
        'Timer1
        '
        '
        'BunifuImageButton1
        '
        Me.BunifuImageButton1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuImageButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuImageButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuImageButton1.ErrorImage = Nothing
        Me.BunifuImageButton1.Image = CType(resources.GetObject("BunifuImageButton1.Image"), System.Drawing.Image)
        Me.BunifuImageButton1.ImageActive = Nothing
        Me.BunifuImageButton1.InitialImage = Nothing
        Me.BunifuImageButton1.Location = New System.Drawing.Point(819, 554)
        Me.BunifuImageButton1.Name = "BunifuImageButton1"
        Me.BunifuImageButton1.Size = New System.Drawing.Size(160, 86)
        Me.BunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton1.TabIndex = 18
        Me.BunifuImageButton1.TabStop = False
        Me.BunifuImageButton1.Zoom = 1
        '
        'BunifuImageButton2
        '
        Me.BunifuImageButton2.BackColor = System.Drawing.Color.Transparent
        Me.BunifuImageButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuImageButton2.ErrorImage = Nothing
        Me.BunifuImageButton2.Image = CType(resources.GetObject("BunifuImageButton2.Image"), System.Drawing.Image)
        Me.BunifuImageButton2.ImageActive = Nothing
        Me.BunifuImageButton2.InitialImage = Nothing
        Me.BunifuImageButton2.Location = New System.Drawing.Point(780, 385)
        Me.BunifuImageButton2.Name = "BunifuImageButton2"
        Me.BunifuImageButton2.Size = New System.Drawing.Size(189, 42)
        Me.BunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton2.TabIndex = 19
        Me.BunifuImageButton2.TabStop = False
        Me.BunifuImageButton2.Zoom = 2
        '
        'BunifuImageButton3
        '
        Me.BunifuImageButton3.BackColor = System.Drawing.Color.Transparent
        Me.BunifuImageButton3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuImageButton3.ErrorImage = Nothing
        Me.BunifuImageButton3.Image = CType(resources.GetObject("BunifuImageButton3.Image"), System.Drawing.Image)
        Me.BunifuImageButton3.ImageActive = Nothing
        Me.BunifuImageButton3.InitialImage = Nothing
        Me.BunifuImageButton3.Location = New System.Drawing.Point(780, 433)
        Me.BunifuImageButton3.Name = "BunifuImageButton3"
        Me.BunifuImageButton3.Size = New System.Drawing.Size(189, 42)
        Me.BunifuImageButton3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton3.TabIndex = 20
        Me.BunifuImageButton3.TabStop = False
        Me.BunifuImageButton3.Zoom = 2
        '
        'BunifuImageButton4
        '
        Me.BunifuImageButton4.BackColor = System.Drawing.Color.Transparent
        Me.BunifuImageButton4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuImageButton4.ErrorImage = Nothing
        Me.BunifuImageButton4.Image = CType(resources.GetObject("BunifuImageButton4.Image"), System.Drawing.Image)
        Me.BunifuImageButton4.ImageActive = Nothing
        Me.BunifuImageButton4.InitialImage = Nothing
        Me.BunifuImageButton4.Location = New System.Drawing.Point(780, 481)
        Me.BunifuImageButton4.Name = "BunifuImageButton4"
        Me.BunifuImageButton4.Size = New System.Drawing.Size(189, 42)
        Me.BunifuImageButton4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton4.TabIndex = 21
        Me.BunifuImageButton4.TabStop = False
        Me.BunifuImageButton4.Zoom = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(551, 463)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(140, 12)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "推薦*完美適應字體150%*"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.BackColor = System.Drawing.Color.Silver
        Me.ProgressBar1.BorderRadius = 5
        Me.ProgressBar1.Location = New System.Drawing.Point(263, 606)
        Me.ProgressBar1.MaximumValue = 100
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.ProgressColor = System.Drawing.Color.Teal
        Me.ProgressBar1.Size = New System.Drawing.Size(531, 19)
        Me.ProgressBar1.TabIndex = 23
        Me.ProgressBar1.Value = 0
        '
        'BunifuImageButton5
        '
        Me.BunifuImageButton5.BackColor = System.Drawing.Color.Transparent
        Me.BunifuImageButton5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuImageButton5.ErrorImage = Nothing
        Me.BunifuImageButton5.Image = CType(resources.GetObject("BunifuImageButton5.Image"), System.Drawing.Image)
        Me.BunifuImageButton5.ImageActive = Nothing
        Me.BunifuImageButton5.InitialImage = Nothing
        Me.BunifuImageButton5.Location = New System.Drawing.Point(959, 113)
        Me.BunifuImageButton5.Name = "BunifuImageButton5"
        Me.BunifuImageButton5.Size = New System.Drawing.Size(25, 24)
        Me.BunifuImageButton5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton5.TabIndex = 24
        Me.BunifuImageButton5.TabStop = False
        Me.BunifuImageButton5.Zoom = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Black
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(261, 628)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 12)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "目前版本號 : v1.2.1"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Black
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(261, 580)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 12)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "正在下載 ... "
        Me.Label3.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.ErrorImage = Nothing
        Me.PictureBox1.InitialImage = Nothing
        Me.PictureBox1.Location = New System.Drawing.Point(327, 144)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(590, 200)
        Me.PictureBox1.TabIndex = 27
        Me.PictureBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Black
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(783, 349)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(113, 12)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "點擊圖片查看新版本"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.ForeColor = System.Drawing.Color.DimGray
        Me.Label5.Location = New System.Drawing.Point(739, 66)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(161, 12)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "Made by p17johnny(KamaboKo)"
        '
        'Textbox1
        '
        Me.Textbox1.BackColor = System.Drawing.Color.White
        Me.Textbox1.BackgroundImage = CType(resources.GetObject("Textbox1.BackgroundImage"), System.Drawing.Image)
        Me.Textbox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Textbox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Textbox1.DataBindings.Add(New System.Windows.Forms.Binding("text", Global.CLOSERSFONT.My.MySettings.Default, "Gamefolder", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Textbox1.ForeColor = System.Drawing.Color.Black
        Me.Textbox1.Icon = CType(resources.GetObject("Textbox1.Icon"), System.Drawing.Image)
        Me.Textbox1.Location = New System.Drawing.Point(254, 404)
        Me.Textbox1.Name = "Textbox1"
        Me.Textbox1.Size = New System.Drawing.Size(446, 39)
        Me.Textbox1.TabIndex = 12
        Me.Textbox1.text = Global.CLOSERSFONT.My.MySettings.Default.Gamefolder
        '
        'BunifuDropdown1
        '
        Me.BunifuDropdown1.Font = New System.Drawing.Font("新蒂金钟体", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.BunifuDropdown1.FormattingEnabled = True
        Me.BunifuDropdown1.Items.AddRange(New Object() {"選擇字體", "微軟正黑體(120%)", "方正粗圓繁簡(108%)", "儷黑粗體(108%)", "完美適應字體(150%)", "官方字體"})
        Me.BunifuDropdown1.Location = New System.Drawing.Point(254, 449)
        Me.BunifuDropdown1.Name = "BunifuDropdown1"
        Me.BunifuDropdown1.Size = New System.Drawing.Size(265, 45)
        Me.BunifuDropdown1.TabIndex = 30
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1003, 722)
        Me.Controls.Add(Me.BunifuDropdown1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BunifuImageButton5)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BunifuImageButton4)
        Me.Controls.Add(Me.BunifuImageButton3)
        Me.Controls.Add(Me.BunifuImageButton2)
        Me.Controls.Add(Me.BunifuImageButton1)
        Me.Controls.Add(Me.Textbox1)
        Me.Controls.Add(Me.BunifuCustomLabel1)
        Me.Controls.Add(Me.BunifuCustomLabel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.TransparencyKey = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(36, Byte), Integer))
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BunifuImageButton2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BunifuImageButton3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BunifuImageButton4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BunifuImageButton5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents Textbox1 As Bunifu.Framework.UI.BunifuTextbox
    Friend WithEvents BunifuCustomLabel2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuImageButton1 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BunifuImageButton2 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BunifuImageButton3 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BunifuImageButton4 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ProgressBar1 As Bunifu.Framework.UI.BunifuProgressBar
    Friend WithEvents BunifuImageButton5 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents BunifuDropdown1 As System.Windows.Forms.ComboBox

End Class
