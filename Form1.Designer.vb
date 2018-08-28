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

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請不要使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.pic_entra = New System.Windows.Forms.PictureBox()
        Me.pic_exit = New System.Windows.Forms.PictureBox()
        Me.car = New System.Windows.Forms.PictureBox()
        Me.lbl = New System.Windows.Forms.Label()
        Me.lbl_show = New System.Windows.Forms.Label()
        Me.p01 = New System.Windows.Forms.Label()
        Me.p09 = New System.Windows.Forms.Label()
        Me.p05 = New System.Windows.Forms.Label()
        Me.p04 = New System.Windows.Forms.Label()
        Me.p03 = New System.Windows.Forms.Label()
        Me.p02 = New System.Windows.Forms.Label()
        Me.p06 = New System.Windows.Forms.Label()
        Me.p07 = New System.Windows.Forms.Label()
        Me.p08 = New System.Windows.Forms.Label()
        Me.p12 = New System.Windows.Forms.Label()
        Me.p11 = New System.Windows.Forms.Label()
        Me.p10 = New System.Windows.Forms.Label()
        Me.p13 = New System.Windows.Forms.Label()
        Me.car_right = New System.Windows.Forms.PictureBox()
        Me.car_left = New System.Windows.Forms.PictureBox()
        Me.car6 = New System.Windows.Forms.PictureBox()
        Me.car11 = New System.Windows.Forms.PictureBox()
        Me.car5 = New System.Windows.Forms.PictureBox()
        Me.car1 = New System.Windows.Forms.PictureBox()
        Me.car7 = New System.Windows.Forms.PictureBox()
        Me.car4 = New System.Windows.Forms.PictureBox()
        Me.car3 = New System.Windows.Forms.PictureBox()
        Me.car2 = New System.Windows.Forms.PictureBox()
        Me.car13 = New System.Windows.Forms.PictureBox()
        Me.car8 = New System.Windows.Forms.PictureBox()
        Me.car12 = New System.Windows.Forms.PictureBox()
        Me.car9 = New System.Windows.Forms.PictureBox()
        Me.car10 = New System.Windows.Forms.PictureBox()
        Me.pic_stop = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.pic_entra, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_exit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.car, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.car_right, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.car_left, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.car6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.car11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.car5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.car1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.car7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.car4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.car3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.car2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.car13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.car8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.car12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.car9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.car10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_stop, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pic_entra
        '
        Me.pic_entra.Image = CType(resources.GetObject("pic_entra.Image"), System.Drawing.Image)
        Me.pic_entra.Location = New System.Drawing.Point(860, 12)
        Me.pic_entra.Name = "pic_entra"
        Me.pic_entra.Size = New System.Drawing.Size(78, 525)
        Me.pic_entra.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pic_entra.TabIndex = 0
        Me.pic_entra.TabStop = False
        '
        'pic_exit
        '
        Me.pic_exit.Image = CType(resources.GetObject("pic_exit.Image"), System.Drawing.Image)
        Me.pic_exit.Location = New System.Drawing.Point(111, 12)
        Me.pic_exit.Name = "pic_exit"
        Me.pic_exit.Size = New System.Drawing.Size(78, 525)
        Me.pic_exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pic_exit.TabIndex = 1
        Me.pic_exit.TabStop = False
        '
        'car
        '
        Me.car.Image = CType(resources.GetObject("car.Image"), System.Drawing.Image)
        Me.car.Location = New System.Drawing.Point(958, 243)
        Me.car.Name = "car"
        Me.car.Size = New System.Drawing.Size(83, 50)
        Me.car.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.car.TabIndex = 2
        Me.car.TabStop = False
        '
        'lbl
        '
        Me.lbl.AutoSize = True
        Me.lbl.Location = New System.Drawing.Point(969, 20)
        Me.lbl.Name = "lbl"
        Me.lbl.Size = New System.Drawing.Size(72, 16)
        Me.lbl.TabIndex = 3
        Me.lbl.Text = "剩餘車位"
        '
        'lbl_show
        '
        Me.lbl_show.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbl_show.Font = New System.Drawing.Font("新細明體", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lbl_show.Location = New System.Drawing.Point(958, 47)
        Me.lbl_show.Name = "lbl_show"
        Me.lbl_show.Size = New System.Drawing.Size(83, 32)
        Me.lbl_show.TabIndex = 4
        Me.lbl_show.Text = "0"
        Me.lbl_show.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'p01
        '
        Me.p01.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.p01.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.p01.Location = New System.Drawing.Point(216, 12)
        Me.p01.Name = "p01"
        Me.p01.Size = New System.Drawing.Size(120, 90)
        Me.p01.TabIndex = 5
        Me.p01.Text = "01"
        Me.p01.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'p09
        '
        Me.p09.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.p09.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.p09.Location = New System.Drawing.Point(216, 447)
        Me.p09.Name = "p09"
        Me.p09.Size = New System.Drawing.Size(120, 90)
        Me.p09.TabIndex = 6
        Me.p09.Text = "09"
        Me.p09.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'p05
        '
        Me.p05.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.p05.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.p05.Location = New System.Drawing.Point(720, 12)
        Me.p05.Name = "p05"
        Me.p05.Size = New System.Drawing.Size(120, 90)
        Me.p05.TabIndex = 7
        Me.p05.Text = "05"
        Me.p05.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'p04
        '
        Me.p04.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.p04.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.p04.Location = New System.Drawing.Point(594, 12)
        Me.p04.Name = "p04"
        Me.p04.Size = New System.Drawing.Size(120, 90)
        Me.p04.TabIndex = 8
        Me.p04.Text = "04"
        Me.p04.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'p03
        '
        Me.p03.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.p03.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.p03.Location = New System.Drawing.Point(468, 12)
        Me.p03.Name = "p03"
        Me.p03.Size = New System.Drawing.Size(120, 90)
        Me.p03.TabIndex = 9
        Me.p03.Text = "03"
        Me.p03.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'p02
        '
        Me.p02.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.p02.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.p02.Location = New System.Drawing.Point(342, 12)
        Me.p02.Name = "p02"
        Me.p02.Size = New System.Drawing.Size(120, 90)
        Me.p02.TabIndex = 10
        Me.p02.Text = "02"
        Me.p02.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'p06
        '
        Me.p06.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.p06.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.p06.Location = New System.Drawing.Point(342, 224)
        Me.p06.Name = "p06"
        Me.p06.Size = New System.Drawing.Size(120, 90)
        Me.p06.TabIndex = 11
        Me.p06.Text = "06"
        Me.p06.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'p07
        '
        Me.p07.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.p07.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.p07.Location = New System.Drawing.Point(468, 224)
        Me.p07.Name = "p07"
        Me.p07.Size = New System.Drawing.Size(120, 90)
        Me.p07.TabIndex = 12
        Me.p07.Text = "07"
        Me.p07.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'p08
        '
        Me.p08.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.p08.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.p08.Location = New System.Drawing.Point(594, 224)
        Me.p08.Name = "p08"
        Me.p08.Size = New System.Drawing.Size(120, 90)
        Me.p08.TabIndex = 13
        Me.p08.Text = "08"
        Me.p08.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'p12
        '
        Me.p12.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.p12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.p12.Location = New System.Drawing.Point(594, 447)
        Me.p12.Name = "p12"
        Me.p12.Size = New System.Drawing.Size(120, 90)
        Me.p12.TabIndex = 16
        Me.p12.Text = "12"
        Me.p12.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'p11
        '
        Me.p11.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.p11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.p11.Location = New System.Drawing.Point(468, 447)
        Me.p11.Name = "p11"
        Me.p11.Size = New System.Drawing.Size(120, 90)
        Me.p11.TabIndex = 17
        Me.p11.Text = "11"
        Me.p11.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'p10
        '
        Me.p10.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.p10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.p10.Location = New System.Drawing.Point(342, 447)
        Me.p10.Name = "p10"
        Me.p10.Size = New System.Drawing.Size(120, 90)
        Me.p10.TabIndex = 18
        Me.p10.Text = "10"
        Me.p10.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'p13
        '
        Me.p13.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.p13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.p13.Location = New System.Drawing.Point(720, 447)
        Me.p13.Name = "p13"
        Me.p13.Size = New System.Drawing.Size(120, 90)
        Me.p13.TabIndex = 19
        Me.p13.Text = "13"
        Me.p13.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'car_right
        '
        Me.car_right.Image = CType(resources.GetObject("car_right.Image"), System.Drawing.Image)
        Me.car_right.Location = New System.Drawing.Point(958, 326)
        Me.car_right.Name = "car_right"
        Me.car_right.Size = New System.Drawing.Size(83, 50)
        Me.car_right.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.car_right.TabIndex = 20
        Me.car_right.TabStop = False
        Me.car_right.Visible = False
        '
        'car_left
        '
        Me.car_left.Image = CType(resources.GetObject("car_left.Image"), System.Drawing.Image)
        Me.car_left.Location = New System.Drawing.Point(958, 395)
        Me.car_left.Name = "car_left"
        Me.car_left.Size = New System.Drawing.Size(83, 50)
        Me.car_left.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.car_left.TabIndex = 21
        Me.car_left.TabStop = False
        Me.car_left.Visible = False
        '
        'car6
        '
        Me.car6.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.car6.Location = New System.Drawing.Point(358, 243)
        Me.car6.Name = "car6"
        Me.car6.Size = New System.Drawing.Size(83, 50)
        Me.car6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.car6.TabIndex = 23
        Me.car6.TabStop = False
        Me.car6.Visible = False
        '
        'car11
        '
        Me.car11.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.car11.Location = New System.Drawing.Point(488, 464)
        Me.car11.Name = "car11"
        Me.car11.Size = New System.Drawing.Size(83, 50)
        Me.car11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.car11.TabIndex = 24
        Me.car11.TabStop = False
        Me.car11.Visible = False
        '
        'car5
        '
        Me.car5.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.car5.Location = New System.Drawing.Point(738, 29)
        Me.car5.Name = "car5"
        Me.car5.Size = New System.Drawing.Size(83, 50)
        Me.car5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.car5.TabIndex = 25
        Me.car5.TabStop = False
        Me.car5.Visible = False
        '
        'car1
        '
        Me.car1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.car1.Location = New System.Drawing.Point(238, 29)
        Me.car1.Name = "car1"
        Me.car1.Size = New System.Drawing.Size(83, 50)
        Me.car1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.car1.TabIndex = 27
        Me.car1.TabStop = False
        Me.car1.Visible = False
        '
        'car7
        '
        Me.car7.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.car7.Location = New System.Drawing.Point(488, 243)
        Me.car7.Name = "car7"
        Me.car7.Size = New System.Drawing.Size(83, 50)
        Me.car7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.car7.TabIndex = 28
        Me.car7.TabStop = False
        Me.car7.Visible = False
        '
        'car4
        '
        Me.car4.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.car4.Location = New System.Drawing.Point(608, 29)
        Me.car4.Name = "car4"
        Me.car4.Size = New System.Drawing.Size(83, 50)
        Me.car4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.car4.TabIndex = 29
        Me.car4.TabStop = False
        Me.car4.Visible = False
        '
        'car3
        '
        Me.car3.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.car3.Location = New System.Drawing.Point(488, 29)
        Me.car3.Name = "car3"
        Me.car3.Size = New System.Drawing.Size(83, 50)
        Me.car3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.car3.TabIndex = 30
        Me.car3.TabStop = False
        Me.car3.Visible = False
        '
        'car2
        '
        Me.car2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.car2.Location = New System.Drawing.Point(358, 29)
        Me.car2.Name = "car2"
        Me.car2.Size = New System.Drawing.Size(83, 50)
        Me.car2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.car2.TabIndex = 31
        Me.car2.TabStop = False
        Me.car2.Visible = False
        '
        'car13
        '
        Me.car13.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.car13.Location = New System.Drawing.Point(738, 464)
        Me.car13.Name = "car13"
        Me.car13.Size = New System.Drawing.Size(83, 50)
        Me.car13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.car13.TabIndex = 32
        Me.car13.TabStop = False
        Me.car13.Visible = False
        '
        'car8
        '
        Me.car8.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.car8.Location = New System.Drawing.Point(608, 243)
        Me.car8.Name = "car8"
        Me.car8.Size = New System.Drawing.Size(83, 50)
        Me.car8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.car8.TabIndex = 33
        Me.car8.TabStop = False
        Me.car8.Visible = False
        '
        'car12
        '
        Me.car12.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.car12.Location = New System.Drawing.Point(608, 464)
        Me.car12.Name = "car12"
        Me.car12.Size = New System.Drawing.Size(83, 50)
        Me.car12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.car12.TabIndex = 34
        Me.car12.TabStop = False
        Me.car12.Visible = False
        '
        'car9
        '
        Me.car9.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.car9.Location = New System.Drawing.Point(238, 464)
        Me.car9.Name = "car9"
        Me.car9.Size = New System.Drawing.Size(83, 50)
        Me.car9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.car9.TabIndex = 35
        Me.car9.TabStop = False
        Me.car9.Visible = False
        '
        'car10
        '
        Me.car10.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.car10.Location = New System.Drawing.Point(358, 464)
        Me.car10.Name = "car10"
        Me.car10.Size = New System.Drawing.Size(83, 50)
        Me.car10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.car10.TabIndex = 36
        Me.car10.TabStop = False
        Me.car10.Visible = False
        '
        'pic_stop
        '
        Me.pic_stop.Image = CType(resources.GetObject("pic_stop.Image"), System.Drawing.Image)
        Me.pic_stop.Location = New System.Drawing.Point(860, 12)
        Me.pic_stop.Name = "pic_stop"
        Me.pic_stop.Size = New System.Drawing.Size(78, 525)
        Me.pic_stop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pic_stop.TabIndex = 37
        Me.pic_stop.TabStop = False
        Me.pic_stop.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(1000, 162)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 16)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "Label1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1063, 663)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.car)
        Me.Controls.Add(Me.pic_stop)
        Me.Controls.Add(Me.car1)
        Me.Controls.Add(Me.car10)
        Me.Controls.Add(Me.car9)
        Me.Controls.Add(Me.car12)
        Me.Controls.Add(Me.car8)
        Me.Controls.Add(Me.car13)
        Me.Controls.Add(Me.car2)
        Me.Controls.Add(Me.car3)
        Me.Controls.Add(Me.car4)
        Me.Controls.Add(Me.car7)
        Me.Controls.Add(Me.car5)
        Me.Controls.Add(Me.car11)
        Me.Controls.Add(Me.car6)
        Me.Controls.Add(Me.car_left)
        Me.Controls.Add(Me.car_right)
        Me.Controls.Add(Me.p13)
        Me.Controls.Add(Me.p10)
        Me.Controls.Add(Me.p11)
        Me.Controls.Add(Me.p12)
        Me.Controls.Add(Me.p08)
        Me.Controls.Add(Me.p07)
        Me.Controls.Add(Me.p06)
        Me.Controls.Add(Me.p02)
        Me.Controls.Add(Me.p03)
        Me.Controls.Add(Me.p04)
        Me.Controls.Add(Me.p05)
        Me.Controls.Add(Me.p09)
        Me.Controls.Add(Me.lbl_show)
        Me.Controls.Add(Me.lbl)
        Me.Controls.Add(Me.pic_exit)
        Me.Controls.Add(Me.pic_entra)
        Me.Controls.Add(Me.p01)
        Me.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.Text = "停車場控制系統"
        CType(Me.pic_entra, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_exit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.car, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.car_right, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.car_left, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.car6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.car11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.car5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.car1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.car7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.car4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.car3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.car2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.car13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.car8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.car12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.car9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.car10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_stop, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pic_entra As System.Windows.Forms.PictureBox
    Friend WithEvents pic_exit As System.Windows.Forms.PictureBox
    Friend WithEvents car As System.Windows.Forms.PictureBox
    Friend WithEvents lbl As System.Windows.Forms.Label
    Friend WithEvents lbl_show As System.Windows.Forms.Label
    Friend WithEvents p01 As System.Windows.Forms.Label
    Friend WithEvents p09 As System.Windows.Forms.Label
    Friend WithEvents p05 As System.Windows.Forms.Label
    Friend WithEvents p04 As System.Windows.Forms.Label
    Friend WithEvents p03 As System.Windows.Forms.Label
    Friend WithEvents p02 As System.Windows.Forms.Label
    Friend WithEvents p06 As System.Windows.Forms.Label
    Friend WithEvents p07 As System.Windows.Forms.Label
    Friend WithEvents p08 As System.Windows.Forms.Label
    Friend WithEvents p12 As System.Windows.Forms.Label
    Friend WithEvents p11 As System.Windows.Forms.Label
    Friend WithEvents p10 As System.Windows.Forms.Label
    Friend WithEvents p13 As System.Windows.Forms.Label
    Friend WithEvents car_right As System.Windows.Forms.PictureBox
    Friend WithEvents car_left As System.Windows.Forms.PictureBox
    Friend WithEvents car6 As System.Windows.Forms.PictureBox
    Friend WithEvents car11 As System.Windows.Forms.PictureBox
    Friend WithEvents car5 As System.Windows.Forms.PictureBox
    Friend WithEvents car1 As System.Windows.Forms.PictureBox
    Friend WithEvents car7 As System.Windows.Forms.PictureBox
    Friend WithEvents car4 As System.Windows.Forms.PictureBox
    Friend WithEvents car3 As System.Windows.Forms.PictureBox
    Friend WithEvents car2 As System.Windows.Forms.PictureBox
    Friend WithEvents car13 As System.Windows.Forms.PictureBox
    Friend WithEvents car8 As System.Windows.Forms.PictureBox
    Friend WithEvents car12 As System.Windows.Forms.PictureBox
    Friend WithEvents car9 As System.Windows.Forms.PictureBox
    Friend WithEvents car10 As System.Windows.Forms.PictureBox
    Friend WithEvents pic_stop As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
