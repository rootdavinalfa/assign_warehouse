<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class warehouse
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
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
        Me.stock_tab = New System.Windows.Forms.TabPage()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.wh_stock_btnshow = New System.Windows.Forms.Button()
        Me.wh_stock_tb_name = New System.Windows.Forms.TextBox()
        Me.wh_stock_checkl = New System.Windows.Forms.CheckBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.wh_stock_gd = New System.Windows.Forms.DataGridView()
        Me.receive_tab = New System.Windows.Forms.TabPage()
        Me.wh_recv_dgv = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.wh_suppl_update = New System.Windows.Forms.Button()
        Me.wh_suppl_delete = New System.Windows.Forms.Button()
        Me.wh_suppl_modify = New System.Windows.Forms.CheckBox()
        Me.wh_recv_refresh = New System.Windows.Forms.Button()
        Me.wh_recv_upload = New System.Windows.Forms.Button()
        Me.hw_textb_items = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.wh_combo_supplier = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.hw_recv_id = New System.Windows.Forms.TextBox()
        Me.production_tab = New System.Windows.Forms.TabPage()
        Me.wh_product_dgv = New System.Windows.Forms.DataGridView()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.wh_product_update = New System.Windows.Forms.Button()
        Me.wh_product_delete = New System.Windows.Forms.Button()
        Me.wh_product_checkl = New System.Windows.Forms.CheckBox()
        Me.wh_product_refresh = New System.Windows.Forms.Button()
        Me.wh_product_pic = New System.Windows.Forms.TextBox()
        Me.wh_product_upload = New System.Windows.Forms.Button()
        Me.wh_product_items = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.wh_product_pack = New System.Windows.Forms.TextBox()
        Me.lbl_date = New System.Windows.Forms.Label()
        Me.now_date = New System.Windows.Forms.Timer(Me.components)
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.wh_tablay.SuspendLayout()
        Me.summary_tab.SuspendLayout()
        CType(Me.wh_summary_dg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.stock_tab.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.wh_stock_gd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.receive_tab.SuspendLayout()
        CType(Me.wh_recv_dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.production_tab.SuspendLayout()
        CType(Me.wh_product_dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
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
        Me.wh_tablay.Controls.Add(Me.stock_tab)
        Me.wh_tablay.Controls.Add(Me.receive_tab)
        Me.wh_tablay.Controls.Add(Me.production_tab)
        Me.wh_tablay.Controls.Add(Me.TabPage1)
        Me.wh_tablay.Controls.Add(Me.TabPage2)
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
        Me.summary_tab.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
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
        Me.wh_summary_dg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.wh_summary_dg.BackgroundColor = System.Drawing.SystemColors.ActiveBorder
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.wh_summary_dg.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.wh_summary_dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.wh_summary_dg.DefaultCellStyle = DataGridViewCellStyle2
        Me.wh_summary_dg.GridColor = System.Drawing.SystemColors.ActiveCaptionText
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
        'stock_tab
        '
        Me.stock_tab.Controls.Add(Me.GroupBox5)
        Me.stock_tab.Controls.Add(Me.wh_stock_gd)
        Me.stock_tab.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.stock_tab.Location = New System.Drawing.Point(4, 22)
        Me.stock_tab.Name = "stock_tab"
        Me.stock_tab.Padding = New System.Windows.Forms.Padding(3)
        Me.stock_tab.Size = New System.Drawing.Size(948, 395)
        Me.stock_tab.TabIndex = 3
        Me.stock_tab.Text = "Stok/Package List"
        Me.stock_tab.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox5.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox5.Controls.Add(Me.wh_stock_btnshow)
        Me.GroupBox5.Controls.Add(Me.wh_stock_tb_name)
        Me.GroupBox5.Controls.Add(Me.wh_stock_checkl)
        Me.GroupBox5.Controls.Add(Me.Label10)
        Me.GroupBox5.Location = New System.Drawing.Point(3, 6)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(942, 74)
        Me.GroupBox5.TabIndex = 1
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Stok/Package Find"
        '
        'wh_stock_btnshow
        '
        Me.wh_stock_btnshow.Location = New System.Drawing.Point(486, 31)
        Me.wh_stock_btnshow.Name = "wh_stock_btnshow"
        Me.wh_stock_btnshow.Size = New System.Drawing.Size(109, 23)
        Me.wh_stock_btnshow.TabIndex = 3
        Me.wh_stock_btnshow.Text = "Show All / Refresh"
        Me.wh_stock_btnshow.UseVisualStyleBackColor = True
        '
        'wh_stock_tb_name
        '
        Me.wh_stock_tb_name.Location = New System.Drawing.Point(179, 33)
        Me.wh_stock_tb_name.Name = "wh_stock_tb_name"
        Me.wh_stock_tb_name.Size = New System.Drawing.Size(301, 20)
        Me.wh_stock_tb_name.TabIndex = 2
        '
        'wh_stock_checkl
        '
        Me.wh_stock_checkl.AutoSize = True
        Me.wh_stock_checkl.Location = New System.Drawing.Point(10, 33)
        Me.wh_stock_checkl.Name = "wh_stock_checkl"
        Me.wh_stock_checkl.Size = New System.Drawing.Size(52, 17)
        Me.wh_stock_checkl.TabIndex = 1
        Me.wh_stock_checkl.Text = "Find?"
        Me.wh_stock_checkl.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(68, 34)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(108, 13)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Stok/Package Name"
        '
        'wh_stock_gd
        '
        Me.wh_stock_gd.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.wh_stock_gd.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.wh_stock_gd.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.wh_stock_gd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.wh_stock_gd.DefaultCellStyle = DataGridViewCellStyle4
        Me.wh_stock_gd.Location = New System.Drawing.Point(0, 86)
        Me.wh_stock_gd.Name = "wh_stock_gd"
        Me.wh_stock_gd.ReadOnly = True
        Me.wh_stock_gd.Size = New System.Drawing.Size(948, 309)
        Me.wh_stock_gd.TabIndex = 0
        '
        'receive_tab
        '
        Me.receive_tab.BackColor = System.Drawing.Color.Transparent
        Me.receive_tab.Controls.Add(Me.wh_recv_dgv)
        Me.receive_tab.Controls.Add(Me.GroupBox2)
        Me.receive_tab.Cursor = System.Windows.Forms.Cursors.Default
        Me.receive_tab.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.receive_tab.Location = New System.Drawing.Point(4, 22)
        Me.receive_tab.Name = "receive_tab"
        Me.receive_tab.Padding = New System.Windows.Forms.Padding(3)
        Me.receive_tab.Size = New System.Drawing.Size(948, 395)
        Me.receive_tab.TabIndex = 0
        Me.receive_tab.Text = "Receive From Supplier"
        '
        'wh_recv_dgv
        '
        Me.wh_recv_dgv.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.wh_recv_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.wh_recv_dgv.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.wh_recv_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.wh_recv_dgv.DefaultCellStyle = DataGridViewCellStyle6
        Me.wh_recv_dgv.Location = New System.Drawing.Point(4, 89)
        Me.wh_recv_dgv.Name = "wh_recv_dgv"
        Me.wh_recv_dgv.ReadOnly = True
        Me.wh_recv_dgv.Size = New System.Drawing.Size(941, 300)
        Me.wh_recv_dgv.TabIndex = 1
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.GroupBox6)
        Me.GroupBox2.Controls.Add(Me.wh_recv_refresh)
        Me.GroupBox2.Controls.Add(Me.wh_recv_upload)
        Me.GroupBox2.Controls.Add(Me.hw_textb_items)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.wh_combo_supplier)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.hw_recv_id)
        Me.GroupBox2.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(942, 87)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Add Goods"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.wh_suppl_update)
        Me.GroupBox6.Controls.Add(Me.wh_suppl_delete)
        Me.GroupBox6.Controls.Add(Me.wh_suppl_modify)
        Me.GroupBox6.Location = New System.Drawing.Point(526, 11)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(247, 69)
        Me.GroupBox6.TabIndex = 11
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Delete / Update"
        '
        'wh_suppl_update
        '
        Me.wh_suppl_update.BackColor = System.Drawing.Color.SeaGreen
        Me.wh_suppl_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.wh_suppl_update.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.wh_suppl_update.Location = New System.Drawing.Point(114, 37)
        Me.wh_suppl_update.Name = "wh_suppl_update"
        Me.wh_suppl_update.Size = New System.Drawing.Size(104, 23)
        Me.wh_suppl_update.TabIndex = 2
        Me.wh_suppl_update.Text = "Update"
        Me.wh_suppl_update.UseVisualStyleBackColor = False
        '
        'wh_suppl_delete
        '
        Me.wh_suppl_delete.BackColor = System.Drawing.Color.Brown
        Me.wh_suppl_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.wh_suppl_delete.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.wh_suppl_delete.Location = New System.Drawing.Point(114, 13)
        Me.wh_suppl_delete.Name = "wh_suppl_delete"
        Me.wh_suppl_delete.Size = New System.Drawing.Size(104, 23)
        Me.wh_suppl_delete.TabIndex = 1
        Me.wh_suppl_delete.Text = "Delete Selected"
        Me.wh_suppl_delete.UseVisualStyleBackColor = False
        '
        'wh_suppl_modify
        '
        Me.wh_suppl_modify.AutoSize = True
        Me.wh_suppl_modify.Location = New System.Drawing.Point(6, 26)
        Me.wh_suppl_modify.Name = "wh_suppl_modify"
        Me.wh_suppl_modify.Size = New System.Drawing.Size(93, 17)
        Me.wh_suppl_modify.TabIndex = 0
        Me.wh_suppl_modify.Text = "Modify Table?"
        Me.wh_suppl_modify.UseVisualStyleBackColor = True
        '
        'wh_recv_refresh
        '
        Me.wh_recv_refresh.Location = New System.Drawing.Point(779, 24)
        Me.wh_recv_refresh.Name = "wh_recv_refresh"
        Me.wh_recv_refresh.Size = New System.Drawing.Size(75, 40)
        Me.wh_recv_refresh.TabIndex = 10
        Me.wh_recv_refresh.Text = "Refresh"
        Me.wh_recv_refresh.UseVisualStyleBackColor = True
        '
        'wh_recv_upload
        '
        Me.wh_recv_upload.Location = New System.Drawing.Point(861, 24)
        Me.wh_recv_upload.Name = "wh_recv_upload"
        Me.wh_recv_upload.Size = New System.Drawing.Size(75, 40)
        Me.wh_recv_upload.TabIndex = 9
        Me.wh_recv_upload.Text = "Upload"
        Me.wh_recv_upload.UseVisualStyleBackColor = True
        '
        'hw_textb_items
        '
        Me.hw_textb_items.Location = New System.Drawing.Point(378, 37)
        Me.hw_textb_items.Name = "hw_textb_items"
        Me.hw_textb_items.Size = New System.Drawing.Size(142, 20)
        Me.hw_textb_items.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(375, 21)
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
        'hw_recv_id
        '
        Me.hw_recv_id.Location = New System.Drawing.Point(84, 21)
        Me.hw_recv_id.MaxLength = 30
        Me.hw_recv_id.Name = "hw_recv_id"
        Me.hw_recv_id.Size = New System.Drawing.Size(285, 20)
        Me.hw_recv_id.TabIndex = 0
        '
        'production_tab
        '
        Me.production_tab.Controls.Add(Me.wh_product_dgv)
        Me.production_tab.Controls.Add(Me.GroupBox3)
        Me.production_tab.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.production_tab.Location = New System.Drawing.Point(4, 22)
        Me.production_tab.Name = "production_tab"
        Me.production_tab.Padding = New System.Windows.Forms.Padding(3)
        Me.production_tab.Size = New System.Drawing.Size(948, 395)
        Me.production_tab.TabIndex = 1
        Me.production_tab.Text = "To Production Line"
        Me.production_tab.UseVisualStyleBackColor = True
        '
        'wh_product_dgv
        '
        Me.wh_product_dgv.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.wh_product_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.wh_product_dgv.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.wh_product_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.wh_product_dgv.DefaultCellStyle = DataGridViewCellStyle8
        Me.wh_product_dgv.Location = New System.Drawing.Point(3, 88)
        Me.wh_product_dgv.Name = "wh_product_dgv"
        Me.wh_product_dgv.ReadOnly = True
        Me.wh_product_dgv.Size = New System.Drawing.Size(949, 307)
        Me.wh_product_dgv.TabIndex = 2
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.GroupBox4)
        Me.GroupBox3.Controls.Add(Me.wh_product_refresh)
        Me.GroupBox3.Controls.Add(Me.wh_product_pic)
        Me.GroupBox3.Controls.Add(Me.wh_product_upload)
        Me.GroupBox3.Controls.Add(Me.wh_product_items)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.wh_product_pack)
        Me.GroupBox3.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(942, 88)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Add Goods"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.wh_product_update)
        Me.GroupBox4.Controls.Add(Me.wh_product_delete)
        Me.GroupBox4.Controls.Add(Me.wh_product_checkl)
        Me.GroupBox4.Location = New System.Drawing.Point(535, 10)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(247, 69)
        Me.GroupBox4.TabIndex = 12
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Delete / Update"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(7, 46)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(77, 13)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "Update Values"
        '
        'wh_product_update
        '
        Me.wh_product_update.BackColor = System.Drawing.Color.SeaGreen
        Me.wh_product_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.wh_product_update.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.wh_product_update.Location = New System.Drawing.Point(114, 37)
        Me.wh_product_update.Name = "wh_product_update"
        Me.wh_product_update.Size = New System.Drawing.Size(104, 23)
        Me.wh_product_update.TabIndex = 2
        Me.wh_product_update.Text = "Update"
        Me.wh_product_update.UseVisualStyleBackColor = False
        '
        'wh_product_delete
        '
        Me.wh_product_delete.BackColor = System.Drawing.Color.Brown
        Me.wh_product_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.wh_product_delete.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.wh_product_delete.Location = New System.Drawing.Point(114, 13)
        Me.wh_product_delete.Name = "wh_product_delete"
        Me.wh_product_delete.Size = New System.Drawing.Size(104, 23)
        Me.wh_product_delete.TabIndex = 1
        Me.wh_product_delete.Text = "Delete Selected"
        Me.wh_product_delete.UseVisualStyleBackColor = False
        '
        'wh_product_checkl
        '
        Me.wh_product_checkl.AutoSize = True
        Me.wh_product_checkl.Location = New System.Drawing.Point(6, 26)
        Me.wh_product_checkl.Name = "wh_product_checkl"
        Me.wh_product_checkl.Size = New System.Drawing.Size(93, 17)
        Me.wh_product_checkl.TabIndex = 0
        Me.wh_product_checkl.Text = "Modify Table?"
        Me.wh_product_checkl.UseVisualStyleBackColor = True
        '
        'wh_product_refresh
        '
        Me.wh_product_refresh.Location = New System.Drawing.Point(788, 24)
        Me.wh_product_refresh.Name = "wh_product_refresh"
        Me.wh_product_refresh.Size = New System.Drawing.Size(55, 40)
        Me.wh_product_refresh.TabIndex = 11
        Me.wh_product_refresh.Text = "Refresh"
        Me.wh_product_refresh.UseVisualStyleBackColor = True
        '
        'wh_product_pic
        '
        Me.wh_product_pic.Location = New System.Drawing.Point(84, 53)
        Me.wh_product_pic.MaxLength = 30
        Me.wh_product_pic.Name = "wh_product_pic"
        Me.wh_product_pic.Size = New System.Drawing.Size(285, 20)
        Me.wh_product_pic.TabIndex = 10
        '
        'wh_product_upload
        '
        Me.wh_product_upload.Location = New System.Drawing.Point(849, 24)
        Me.wh_product_upload.Name = "wh_product_upload"
        Me.wh_product_upload.Size = New System.Drawing.Size(75, 40)
        Me.wh_product_upload.TabIndex = 9
        Me.wh_product_upload.Text = "Upload"
        Me.wh_product_upload.UseVisualStyleBackColor = True
        '
        'wh_product_items
        '
        Me.wh_product_items.Location = New System.Drawing.Point(387, 44)
        Me.wh_product_items.Name = "wh_product_items"
        Me.wh_product_items.Size = New System.Drawing.Size(142, 20)
        Me.wh_product_items.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(384, 28)
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
        'wh_product_pack
        '
        Me.wh_product_pack.Location = New System.Drawing.Point(84, 21)
        Me.wh_product_pack.MaxLength = 30
        Me.wh_product_pack.Name = "wh_product_pack"
        Me.wh_product_pack.Size = New System.Drawing.Size(285, 20)
        Me.wh_product_pack.TabIndex = 0
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
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.Location = New System.Drawing.Point(721, 13)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(43, 16)
        Me.LinkLabel1.TabIndex = 6
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "About"
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Label11)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(948, 395)
        Me.TabPage1.TabIndex = 4
        Me.TabPage1.Text = "Supplier"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Label12)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(948, 395)
        Me.TabPage2.TabIndex = 5
        Me.TabPage2.Text = "Package"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(7, 9)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(336, 75)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Don't be ridiculous!" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Supplier List wont be here" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Supplier was on Purchasing Dept" &
    "!"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(8, 14)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(311, 50)
        Me.Label12.TabIndex = 1
        Me.Label12.Text = "Here Same As Before," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "package was under purchasing"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(606, 38)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(339, 20)
        Me.Label13.TabIndex = 7
        Me.Label13.Text = "Just For Incoming,not Finish Good Warehouse"
        '
        'warehouse
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(957, 490)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.LinkLabel1)
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
        Me.stock_tab.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.wh_stock_gd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.receive_tab.ResumeLayout(False)
        CType(Me.wh_recv_dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.production_tab.ResumeLayout(False)
        CType(Me.wh_product_dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
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
    Friend WithEvents hw_recv_id As TextBox
    Friend WithEvents wh_recv_dgv As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents wh_combo_supplier As ComboBox
    Friend WithEvents wh_recv_upload As Button
    Friend WithEvents hw_textb_items As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents wh_product_dgv As DataGridView
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents wh_product_pic As TextBox
    Friend WithEvents wh_product_upload As Button
    Friend WithEvents wh_product_items As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents wh_product_pack As TextBox
    Friend WithEvents wh_recv_refresh As Button
    Friend WithEvents wh_product_refresh As Button
    Friend WithEvents stock_tab As TabPage
    Friend WithEvents wh_stock_gd As DataGridView
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents wh_stock_btnshow As Button
    Friend WithEvents wh_stock_tb_name As TextBox
    Friend WithEvents wh_stock_checkl As CheckBox
    Friend WithEvents Label10 As Label
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents wh_suppl_delete As Button
    Friend WithEvents wh_suppl_modify As CheckBox
    Friend WithEvents wh_suppl_update As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents wh_product_update As Button
    Friend WithEvents wh_product_delete As Button
    Friend WithEvents wh_product_checkl As CheckBox
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Label9 As Label
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents Label11 As Label
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
End Class
