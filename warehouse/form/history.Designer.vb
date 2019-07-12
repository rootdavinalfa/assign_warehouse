<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class history
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim Label1 As System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.incoming = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.outcoming = New System.Windows.Forms.DataGridView()
        Me.datepick_first = New System.Windows.Forms.DateTimePicker()
        Me.datepick_sec = New System.Windows.Forms.DateTimePicker()
        Me.cb_show_all = New System.Windows.Forms.CheckBox()
        Me.btn_refresh = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_in_counter = New System.Windows.Forms.Label()
        Me.txt_out_counter = New System.Windows.Forms.Label()
        Me.cb_limiter = New System.Windows.Forms.CheckBox()
        Me.tb_limiter = New System.Windows.Forms.TextBox()
        Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.incoming, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.outcoming, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label1.Location = New System.Drawing.Point(224, 13)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(37, 16)
        Label1.TabIndex = 3
        Label1.Text = "Over"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.incoming)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 86)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(776, 232)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Incoming"
        '
        'incoming
        '
        Me.incoming.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.incoming.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.incoming.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.incoming.Location = New System.Drawing.Point(12, 36)
        Me.incoming.Name = "incoming"
        Me.incoming.ReadOnly = True
        Me.incoming.Size = New System.Drawing.Size(764, 190)
        Me.incoming.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.outcoming)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 324)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(776, 217)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Out to production"
        '
        'outcoming
        '
        Me.outcoming.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.outcoming.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.outcoming.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.outcoming.Location = New System.Drawing.Point(6, 23)
        Me.outcoming.Name = "outcoming"
        Me.outcoming.ReadOnly = True
        Me.outcoming.Size = New System.Drawing.Size(764, 186)
        Me.outcoming.TabIndex = 1
        '
        'datepick_first
        '
        Me.datepick_first.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.datepick_first.CustomFormat = "yyyy-MM-dd HH:mm:ss"
        Me.datepick_first.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.datepick_first.Location = New System.Drawing.Point(18, 13)
        Me.datepick_first.Name = "datepick_first"
        Me.datepick_first.Size = New System.Drawing.Size(200, 20)
        Me.datepick_first.TabIndex = 2
        '
        'datepick_sec
        '
        Me.datepick_sec.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.datepick_sec.CustomFormat = "yyyy-MM-dd HH:mm:ss"
        Me.datepick_sec.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.datepick_sec.Location = New System.Drawing.Point(267, 13)
        Me.datepick_sec.Name = "datepick_sec"
        Me.datepick_sec.Size = New System.Drawing.Size(200, 20)
        Me.datepick_sec.TabIndex = 4
        '
        'cb_show_all
        '
        Me.cb_show_all.AutoSize = True
        Me.cb_show_all.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_show_all.Location = New System.Drawing.Point(18, 58)
        Me.cb_show_all.Name = "cb_show_all"
        Me.cb_show_all.Size = New System.Drawing.Size(140, 22)
        Me.cb_show_all.TabIndex = 5
        Me.cb_show_all.Text = "I want to show all"
        Me.cb_show_all.UseVisualStyleBackColor = True
        '
        'btn_refresh
        '
        Me.btn_refresh.BackColor = System.Drawing.SystemColors.Control
        Me.btn_refresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_refresh.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btn_refresh.Location = New System.Drawing.Point(686, 13)
        Me.btn_refresh.Name = "btn_refresh"
        Me.btn_refresh.Size = New System.Drawing.Size(75, 23)
        Me.btn_refresh.TabIndex = 6
        Me.btn_refresh.Text = "Refresh"
        Me.btn_refresh.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Green
        Me.Label2.Location = New System.Drawing.Point(187, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 20)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "IN:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(362, 63)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 20)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "OUT:"
        '
        'txt_in_counter
        '
        Me.txt_in_counter.AutoSize = True
        Me.txt_in_counter.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_in_counter.Location = New System.Drawing.Point(215, 63)
        Me.txt_in_counter.Name = "txt_in_counter"
        Me.txt_in_counter.Size = New System.Drawing.Size(119, 20)
        Me.txt_in_counter.TabIndex = 9
        Me.txt_in_counter.Text = "23323242322"
        '
        'txt_out_counter
        '
        Me.txt_out_counter.AutoSize = True
        Me.txt_out_counter.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_out_counter.Location = New System.Drawing.Point(414, 63)
        Me.txt_out_counter.Name = "txt_out_counter"
        Me.txt_out_counter.Size = New System.Drawing.Size(119, 20)
        Me.txt_out_counter.TabIndex = 10
        Me.txt_out_counter.Text = "23323242322"
        '
        'cb_limiter
        '
        Me.cb_limiter.AutoSize = True
        Me.cb_limiter.Location = New System.Drawing.Point(486, 14)
        Me.cb_limiter.Name = "cb_limiter"
        Me.cb_limiter.Size = New System.Drawing.Size(47, 17)
        Me.cb_limiter.TabIndex = 11
        Me.cb_limiter.Text = "Limit"
        Me.cb_limiter.UseVisualStyleBackColor = True
        '
        'tb_limiter
        '
        Me.tb_limiter.Location = New System.Drawing.Point(539, 14)
        Me.tb_limiter.Name = "tb_limiter"
        Me.tb_limiter.Size = New System.Drawing.Size(141, 20)
        Me.tb_limiter.TabIndex = 12
        Me.tb_limiter.Text = "10"
        '
        'history
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 545)
        Me.Controls.Add(Me.tb_limiter)
        Me.Controls.Add(Me.cb_limiter)
        Me.Controls.Add(Me.txt_out_counter)
        Me.Controls.Add(Me.txt_in_counter)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btn_refresh)
        Me.Controls.Add(Me.cb_show_all)
        Me.Controls.Add(Me.datepick_sec)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.datepick_first)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "history"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "history"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.incoming, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.outcoming, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents incoming As DataGridView
    Friend WithEvents outcoming As DataGridView
    Friend WithEvents datepick_first As DateTimePicker
    Friend WithEvents datepick_sec As DateTimePicker
    Friend WithEvents cb_show_all As CheckBox
    Friend WithEvents btn_refresh As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_in_counter As Label
    Friend WithEvents txt_out_counter As Label
    Friend WithEvents cb_limiter As CheckBox
    Friend WithEvents tb_limiter As TextBox
End Class
