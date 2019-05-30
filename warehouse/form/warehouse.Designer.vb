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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.wh_iduser_lbl = New System.Windows.Forms.Label()
        Me.wh_name_lbl = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.wh_tablay = New System.Windows.Forms.TabControl()
        Me.receive_tab = New System.Windows.Forms.TabPage()
        Me.production_tab = New System.Windows.Forms.TabPage()
        Me.summary_tab = New System.Windows.Forms.TabPage()
        Me.wh_tablay.SuspendLayout()
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
        'receive_tab
        '
        Me.receive_tab.BackColor = System.Drawing.Color.DarkRed
        Me.receive_tab.Cursor = System.Windows.Forms.Cursors.Default
        Me.receive_tab.Location = New System.Drawing.Point(4, 22)
        Me.receive_tab.Name = "receive_tab"
        Me.receive_tab.Padding = New System.Windows.Forms.Padding(3)
        Me.receive_tab.Size = New System.Drawing.Size(948, 395)
        Me.receive_tab.TabIndex = 0
        Me.receive_tab.Text = "Receive From Suppl"
        '
        'production_tab
        '
        Me.production_tab.Location = New System.Drawing.Point(4, 22)
        Me.production_tab.Name = "production_tab"
        Me.production_tab.Padding = New System.Windows.Forms.Padding(3)
        Me.production_tab.Size = New System.Drawing.Size(948, 395)
        Me.production_tab.TabIndex = 1
        Me.production_tab.Text = "To Production Line"
        Me.production_tab.UseVisualStyleBackColor = True
        '
        'summary_tab
        '
        Me.summary_tab.BackColor = System.Drawing.Color.Navy
        Me.summary_tab.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.summary_tab.Location = New System.Drawing.Point(4, 22)
        Me.summary_tab.Name = "summary_tab"
        Me.summary_tab.Size = New System.Drawing.Size(948, 395)
        Me.summary_tab.TabIndex = 2
        Me.summary_tab.Text = "Summary"
        '
        'warehouse
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(957, 490)
        Me.Controls.Add(Me.wh_tablay)
        Me.Controls.Add(Me.wh_name_lbl)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.wh_iduser_lbl)
        Me.Controls.Add(Me.Label1)
        Me.Name = "warehouse"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Warehouse"
        Me.wh_tablay.ResumeLayout(False)
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
End Class
