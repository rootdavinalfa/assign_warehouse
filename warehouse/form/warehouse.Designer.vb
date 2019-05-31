<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class warehouse
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(warehouse))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.wh_iduser_lbl = New System.Windows.Forms.Label()
        Me.wh_name_lbl = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.wh_tablay = New System.Windows.Forms.TabControl()
        Me.summary_tab = New System.Windows.Forms.TabPage()
        Me.wh_summary_dg = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.wh_summary_show = New System.Windows.Forms.Button()
        Me.wh_summary_product = New System.Windows.Forms.RadioButton()
        Me.wh_summary_suppl = New System.Windows.Forms.RadioButton()
        Me.receive_tab = New System.Windows.Forms.TabPage()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.wh_combo_supplier = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.production_tab = New System.Windows.Forms.TabPage()
        Me.DataGridView3 = New System.Windows.Forms.DataGridView()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.lbl_date = New System.Windows.Forms.Label()
        Me.now_date = New System.Windows.Forms.Timer(Me.components)
        Me.wh_tablay.SuspendLayout()
        Me.summary_tab.SuspendLayout()
        CType(Me.wh_summary_dg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.receive_tab.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.production_tab.SuspendLayout()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID USER:"
        '
        'wh_iduser_lbl
        '
        Me.wh_iduser_lbl.AutoSize = True
        Me.wh_iduser_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.wh_iduser_lbl.ForeColor = System.Drawing.Color.Green
        Me.wh_iduser_lbl.Location = New System.Drawing.Point(130, 13)
        Me.wh_iduser_lbl.Name = "wh_iduser_lbl"
        Me.wh_iduser_lbl.Size = New System.Drawing.Size(84, 25)
        Me.wh_iduser_lbl.TabIndex = 1
        Me.wh_iduser_lbl.Text = "111111"
        '
        'wh_name_lbl
        '
        Me.wh_name_lbl.AutoSize = True
        Me.wh_name_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.wh_name_lbl.ForeColor = System.Drawing.Color.Green
        Me.wh_name_lbl.Location = New System.Drawing.Point(130, 38)
        Me.wh_name_lbl.Name = "wh_name_lbl"
        Me.wh_name_lbl.Size = New System.Drawing.Size(154, 25)
        Me.wh_name_lbl.TabIndex = 3
        Me.wh_name_lbl.Text = "Albert asidhasi"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(13, 38)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 25)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Name:"
        '
        'wh_tablay
        '
        Me.wh_tablay.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.wh_tablay.Controls.Add(Me.summary_tab)
        Me.wh_tablay.Controls.Add(Me.receive_tab)
        Me.wh_tablay.Controls.Add(Me.production_tab)
        Me.wh_tablay.Location = New System.Drawing.Point(1, 66)
        Me.wh_tablay.Name = "wh_tablay"
        Me.wh_tablay.SelectedIndex = 0
        Me.wh_tablay.Size = New System.Drawing.Size(956, 421)
        Me.wh_tablay.TabIndex = 4
        '
        'summary_tab
        '
        Me.summary_tab.BackColor = System.Drawing.Color.Transparent
        Me.summary_tab.Controls.Add(Me.wh_summary_dg)
        Me.summary_tab.Controls.Add(Me.GroupBox1)
        Me.summary_tab.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.summary_tab.Location = New System.Drawing.Point(4, 22)
        Me.summary_tab.Name = "summary_tab"
        Me.summary_tab.Size = New System.Drawing.Size(948, 395)
        Me.summary_tab.TabIndex = 2
        Me.summary_tab.Text = "Summary"
        '
        'wh_summary_dg
        '
        Me.wh_summary_dg.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.wh_summary_dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.wh_summary_dg.Location = New System.Drawing.Point(4, 90)
        Me.wh_summary_dg.Name = "wh_summary_dg"
        Me.wh_summary_dg.Size = New System.Drawing.Size(941, 300)
        Me.wh_summary_dg.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.wh_summary_show)
        Me.GroupBox1.Controls.Add(Me.wh_summary_product)
        Me.GroupBox1.Controls.Add(Me.wh_summary_suppl)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(936, 79)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "View By"
        '
        'wh_summary_show
        '
        Me.wh_summary_show.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.wh_summary_show.Location = New System.Drawing.Point(875, 19)
        Me.wh_summary_show.Name = "wh_summary_show"
        Me.wh_summary_show.Size = New System.Drawing.Size(55, 34)
        Me.wh_summary_show.TabIndex = 2
        Me.wh_summary_show.Text = "SHOW"
        Me.wh_summary_show.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.wh_summary_show.UseVisualStyleBackColor = True
        '
        'wh_summary_product
        '
        Me.wh_summary_product.AutoSize = True
        Me.wh_summary_product.Location = New System.Drawing.Point(6, 42)
        Me.wh_summary_product.Name = "wh_summary_product"
        Me.wh_summary_product.Size = New System.Drawing.Size(92, 17)
        Me.wh_summary_product.TabIndex = 1
        Me.wh_summary_product.TabStop = True
        Me.wh_summary_product.Text = "To Production"
        Me.wh_summary_product.UseVisualStyleBackColor = True
        '
        'wh_summary_suppl
        '
        Me.wh_summary_suppl.AutoSize = True
        Me.wh_summary_suppl.Location = New System.Drawing.Point(6, 19)
        Me.wh_summary_suppl.Name = "wh_summary_suppl"
        Me.wh_summary_suppl.Size = New System.Drawing.Size(135, 17)
        Me.wh_summary_suppl.TabIndex = 0
        Me.wh_summary_suppl.TabStop = True
        Me.wh_summary_suppl.Text = "From Supplier(Receive)"
        Me.wh_summary_suppl.UseVisualStyleBackColor = True
        '
        'receive_tab
        '
        Me.receive_tab.BackColor = System.Drawing.Color.Transparent
        Me.receive_tab.Controls.Add(Me.DataGridView2)
        Me.receive_tab.Controls.Add(Me.GroupBox2)
        Me.receive_tab.Cursor = System.Windows.Forms.Cursors.Default
        Me.receive_tab.Location = New System.Drawing.Point(4, 22)
        Me.receive_tab.Name = "receive_tab"
        Me.receive_tab.Padding = New System.Windows.Forms.Padding(3)
        Me.receive_tab.Size = New System.Drawing.Size(948, 395)
        Me.receive_tab.TabIndex = 0
        Me.receive_tab.Text = "Receive From Suppl"
        '
        'DataGridView2
        '
        Me.DataGridView2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(4, 89)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(941, 300)
        Me.DataGridView2.TabIndex = 1
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.TextBox2)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.wh_combo_supplier)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.TextBox1)
        Me.GroupBox2.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(942, 79)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Add Goods"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(861, 24)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 40)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "Upload"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(488, 24)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(142, 20)
        Me.TextBox2.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(400, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Jumlah Diterima"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 51)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Supplier"
        '
        'wh_combo_supplier
        '
        Me.wh_combo_supplier.FormattingEnabled = True
        Me.wh_combo_supplier.Location = New System.Drawing.Point(84, 48)
        Me.wh_combo_supplier.Name = "wh_combo_supplier"
        Me.wh_combo_supplier.Size = New System.Drawing.Size(285, 21)
        Me.wh_combo_supplier.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "ID Package"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(84, 21)
        Me.TextBox1.MaxLength = 30
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(285, 20)
        Me.TextBox1.TabIndex = 0
        '
        'production_tab
        '
        Me.production_tab.Controls.Add(Me.DataGridView3)
        Me.production_tab.Controls.Add(Me.GroupBox3)
        Me.production_tab.Location = New System.Drawing.Point(4, 22)
        Me.production_tab.Name = "production_tab"
        Me.production_tab.Padding = New System.Windows.Forms.Padding(3)
        Me.production_tab.Size = New System.Drawing.Size(948, 395)
        Me.production_tab.TabIndex = 1
        Me.production_tab.Text = "To Production Line"
        Me.production_tab.UseVisualStyleBackColor = True
        '
        'DataGridView3
        '
        Me.DataGridView3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView3.Location = New System.Drawing.Point(3, 88)
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.Size = New System.Drawing.Size(949, 307)
        Me.DataGridView3.TabIndex = 2
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.TextBox5)
        Me.GroupBox3.Controls.Add(Me.Button3)
        Me.GroupBox3.Controls.Add(Me.TextBox3)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.TextBox4)
        Me.GroupBox3.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(942, 79)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Add Goods"
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(84, 53)
        Me.TextBox5.MaxLength = 30
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(285, 20)
        Me.TextBox5.TabIndex = 10
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(849, 24)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 40)
        Me.Button3.TabIndex = 9
        Me.Button3.Text = "Upload"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(488, 24)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(142, 20)
        Me.TextBox3.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(400, 24)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 13)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Jumlah"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(7, 51)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(41, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "PIC(ID)"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 24)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(64, 13)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "ID Package"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(84, 21)
        Me.TextBox4.MaxLength = 30
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(285, 20)
        Me.TextBox4.TabIndex = 0
        '
        'lbl_date
        '
        Me.lbl_date.AutoSize = True
        Me.lbl_date.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_date.ForeColor = System.Drawing.Color.Maroon
        Me.lbl_date.Location = New System.Drawing.Point(762, 9)
        Me.lbl_date.Name = "lbl_date"
        Me.lbl_date.Size = New System.Drawing.Size(100, 24)
        Me.lbl_date.TabIndex = 5
        Me.lbl_date.Text = "2019 20 19"
        '
        'now_date
        '
        '
        'warehouse
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(957, 490)
        Me.Controls.Add(Me.lbl_date)
        Me.Controls.Add(Me.wh_tablay)
        Me.Controls.Add(Me.wh_name_lbl)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.wh_iduser_lbl)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "warehouse"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Warehouse"
        Me.wh_tablay.ResumeLayout(False)
        Me.summary_tab.ResumeLayout(False)
        CType(Me.wh_summary_dg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.receive_tab.ResumeLayout(False)
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.production_tab.ResumeLayout(False)
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents wh_iduser_lbl As Label
    Friend WithEvents wh_name_lbl As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents wh_tablay As TabControl
    Friend WithEvents receive_tab As TabPage
    Friend WithEvents production_tab As TabPage
    Friend WithEvents summary_tab As TabPage
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents wh_summary_dg As DataGridView
    Friend WithEvents wh_summary_product As RadioButton
    Friend WithEvents wh_summary_suppl As RadioButton
    Friend WithEvents wh_summary_show As Button
    Friend WithEvents lbl_date As Label
    Friend WithEvents now_date As Timer
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents wh_combo_supplier As ComboBox
    Friend WithEvents Button2 As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents DataGridView3 As DataGridView
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox4 As TextBox
End Class
