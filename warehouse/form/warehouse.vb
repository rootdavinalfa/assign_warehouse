'Copyright 2019
'    Davin Alfarizky Putra Basudewa <davinbambang@hotmail.com / dbasudewa@gmail.com>
'    All rights reserved
Imports warehouse.sql_command
Imports MySql.Data.MySqlClient
Public Class warehouse
    Private Sub warehouse_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If MessageBox.Show("Are you sure to close this form and logout?", "Caution!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            login_form.Show()
        Else
            e.Cancel = True
        End If

    End Sub

    Private Sub warehouse_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        wh_stock_tb_name.Enabled = False
        wh_summary_suppl.Checked = True
        now_date.Enabled = True
        blink.Enabled = True
        wh_iduser_lbl.Text = login_form.iduser
        wh_name_lbl.Text = ""
        Call getname()
        Call getSupplierList()
        Call getSummary()
        Call getStockList("")
        clean_in_wh()
        clean_out_wh()

    End Sub


    Private Sub now_date_Tick(sender As Object, e As EventArgs) Handles now_date.Tick
        lbl_date.Text = Date.Now.ToString("dd/MM/yyyy HH:mm:ss")
    End Sub

    Private Sub summary_btn_show_Click(sender As Object, e As EventArgs) Handles wh_summary_show.Click, wh_summary_suppl.CheckedChanged, wh_summary_product.CheckedChanged
        getSummary()
    End Sub
    'Section For SQL Method'
    Private Sub getname()
        Dim rowname As New DataTable
        Dim id = login_form.iduser

        sql = "SELECT * FROM user_detail WHERE id_user ='" & id & "';"
        rowname = select_sqlcommand_with_datatable(sql)
        If rowname.Rows.Count > 0 Then
            wh_name_lbl.Text = rowname.Rows(0).Item(1)
        Else
            Application.Exit()
        End If
    End Sub

    Private Sub getSupplierList()
        Dim ds As New DataSet
        sql = "SELECT id_supplier,name_supplier FROM supplier;"
        ds = select_sqlcommand_with_dataset(sql)
        If ds.Tables.Count > 0 Then
            wh_combo_supplier.DataSource = ds.Tables(0)
            wh_combo_supplier.ValueMember = "id_supplier"
            wh_combo_supplier.DisplayMember = "name_supplier"
        End If

    End Sub

    Private Sub getSummary()
        Dim ds As New DataSet

        If wh_summary_suppl.Checked Then
            sql = "SELECT t1.wh_rh as 'ID',t2.name_package AS 'Package Name',t4.name_supplier as 'Supplier' , t3.name as 'Maintainer',t1.received As 'Values'
FROM wh_receive_history t1 INNER JOIN package_list t2 ON t1.id_package = t2.id_package
INNER JOIN user_detail t3 ON t1.id_maintain = t3.id_user INNER JOIN supplier t4 ON
t1.id_supplier = t4.id_supplier ORDER BY t1.wh_rh DESC LIMIT 0,10"
        ElseIf wh_summary_product.Checked Then
            sql = "SELECT t1.wh_ph as 'ID',t2.name_package as 'Name Package', t3.name as 'PIC',t4.name as 'Maintainer',t1.package_items as 'Values'
FROM wh_production_history t1 INNER JOIN package_list t2 ON t1.id_package = t2.id_package
INNER JOIN user_detail t3 ON t1.id_pic = t3.id_user
INNER JOIN user_detail t4 ON t1.id_maintain = t4.id_user ORDER BY t1.wh_ph DESC LIMIT 0,10"
        End If
        ds = select_sqlcommand_with_dataset(sql)
        If ds.Tables.Count > 0 Then
            wh_summary_dg.DataSource = ds.Tables(0)
        End If

    End Sub

    Private Sub recv_upload()
        Dim id As Integer = wh_iduser_lbl.Text
        Dim idpack As Integer = hw_recv_id.Text
        Dim suppli As Integer = wh_combo_supplier.SelectedValue
        Dim regDate As DateTime = DateTime.Now
        Dim strDate As String = regDate.ToString("yyyy-MM-dd HH:mm:ss")
        Dim recv As Integer = hw_textb_items.Text
        sql = "INSERT INTO wh_receive_history(id_package,id_supplier,id_maintain,received,date)
VALUE(?idpack,?idsuppl,?idmaintain,?recv,?date)"
        Try
            Dim cmd As New MySqlCommand(sql, Con)
            cmd.Parameters.AddWithValue("?idpack", idpack)
            cmd.Parameters.AddWithValue("?idsuppl", suppli)
            cmd.Parameters.AddWithValue("?idmaintain", id)
            cmd.Parameters.AddWithValue("?recv", recv)
            cmd.Parameters.AddWithValue("?date", strDate)
            cmd.BeginExecuteNonQuery()
            Dim stok As Integer
            sql = "SELECT stock FROM package_list WHERE id_package='" & idpack & "';"
            Dim dataStock = select_sqlcommand_with_datatable(sql)
            If dataStock.Rows.Count > 0 Then
                stok = recv + dataStock.Rows(0).Item(0)
            Else
                stok = 0
            End If
            Dim param2 As New Dictionary(Of String, Integer) From {
            {"?stokk", stok}
            }
            sql = "UPDATE package_list SET stock=?stokk WHERE id_package='" & idpack & "';"
            If noreturnsql(sql, param2) Then
                MsgBox("Data Uploaded!")
                getRecvSu()
                clean_in_wh()

            End If
        Catch ex As MySqlException
            MsgBox("There's error while executing\nerror:" & ex.Message)
        End Try


        'Dim param As New Dictionary(Of String, Integer)
        'param.Add("?idpack", idpack)
        'param.Add("?idsuppl", suppli)
        'param.Add("?idmaintain", id)
        'param.Add("?recv", recv)
        'If noreturnsql(sql, param) Then
        '    Dim stok As Integer
        '    sql = "SELECT stock FROM package_list WHERE id_package='" & idpack & "';"
        '    Dim dataStock = select_sqlcommand_with_datatable(sql)
        '    If dataStock.Rows.Count > 0 Then
        '        stok = recv + dataStock.Rows(0).Item(0)
        '    Else
        '        stok = 0
        '    End If
        '    Dim param2 As New Dictionary(Of String, Integer) From {
        '    {"?stokk", stok}
        '    }
        '    sql = "UPDATE package_list SET stock=?stokk WHERE id_package='" & idpack & "';"
        '    If noreturnsql(sql, param2) Then
        '        MsgBox("Data Uploaded!")
        '        getRecvSu()
        '        clean_in_wh()

        '    End If

        'Else
        '    MsgBox("ERROR!")
        'End If
    End Sub
    Private Sub getStockList(states As String)
        If states = "CHECKED" Then
            Dim finder As String = wh_stock_tb_name.Text
            sql = "SELECT id_package as 'ID',name_package as 'Name Package',stock as'In Stok'
FROM package_list WHERE LOWER(name_package) LIKE LOWER('%" & finder & "%');"
        Else
            sql = "SELECT id_package as 'ID',name_package as 'Name Package',stock as'In Stok'
FROM package_list;"
        End If

        Dim ds = select_sqlcommand_with_dataset(sql)
        If ds.Tables.Count > 0 Then
            wh_stock_gd.DataSource = ds.Tables(0)
        End If

    End Sub

    Private Sub product_upload()
        Dim regDate As DateTime = DateTime.Now
        Dim strDate As String = regDate.ToString("yyyy-MM-dd HH:mm:ss")
        Dim idmaintain As Integer = wh_iduser_lbl.Text
        Dim idpic As Integer = wh_product_pic.Text
        Dim idpack As Integer = wh_product_pack.Text
        Dim recv As Integer = wh_product_items.Text
        sql = "INSERT INTO wh_production_history(id_package,id_pic,id_maintain,package_items,datetime)
VALUES(?idpack,?idpic,?idmaintain,?recv,?date)"
        '        sql = "INSERT INTO wh_production_history(id_package,id_pic,id_maintain,package_items,datetime)
        'VALUES(?idpack,?idpic,?idmaintain,?recv," & strDate & ")"
        Call connect2db()
        Try
            Dim cmd As New MySqlCommand(sql, Con)
            cmd.Parameters.AddWithValue("?idpack", idpack)
            cmd.Parameters.AddWithValue("?idpic", idpic)
            cmd.Parameters.AddWithValue("?idmaintain", idmaintain)
            cmd.Parameters.AddWithValue("?recv", recv)
            cmd.Parameters.AddWithValue("?date", strDate)
            cmd.BeginExecuteNonQuery()
            Dim stok As Integer
            sql = "SELECT stock FROM package_list WHERE id_package='" & idpack & "';"
            Dim dataStock = select_sqlcommand_with_datatable(sql)
            If dataStock.Rows.Count > 0 Then
                stok = dataStock.Rows(0).Item(0) - recv
            Else
                stok = 0
            End If
            Dim param2 As New Dictionary(Of String, Integer) From {
            {"?stokk", stok}
            }
            sql = "UPDATE package_list SET stock=?stokk WHERE id_package='" & idpack & "';"
            If noreturnsql(sql, param2) Then
                MsgBox("Data Uploaded!")
                getProdSu()
                clean_out_wh()
            End If

        Catch ex As MySqlException
            MsgBox("There's error while executing\nerror:" & ex.Message)
        End Try
    End Sub
    Private Sub getRecvSu()
        sql = "SELECT t1.wh_rh as 'ID',t2.name_package AS 'Package Name',t4.name_supplier as 'Supplier' , t3.name as 'Maintainer',t1.received As 'Values',t1.date As 'Received ON'
FROM wh_receive_history t1 INNER JOIN package_list t2 ON t1.id_package = t2.id_package
INNER JOIN user_detail t3 ON t1.id_maintain = t3.id_user INNER JOIN supplier t4 ON
t1.id_supplier = t4.id_supplier ORDER BY t1.wh_rh DESC"
        Dim ds = select_sqlcommand_with_dataset(sql)
        If ds.Tables.Count > 0 Then
            wh_recv_dgv.DataSource = ds.Tables(0)
        End If

    End Sub

    Private Sub getProdSu()
        sql = "SELECT t1.wh_ph as 'ID',t2.name_package as 'Name Package', t3.name as 'PIC',t4.name as 'Maintainer',t1.package_items as 'Values',t1.datetime As 'Out On'
FROM wh_production_history t1 INNER JOIN package_list t2 ON t1.id_package = t2.id_package
INNER JOIN user_detail t3 ON t1.id_pic = t3.id_user
INNER JOIN user_detail t4 ON t1.id_maintain = t4.id_user ORDER BY t1.wh_ph DESC"
        Dim ds = select_sqlcommand_with_dataset(sql)
        If ds.Tables.Count > 0 Then
            wh_product_dgv.DataSource = ds.Tables(0)
        End If

    End Sub

    Private Sub remProductHist()
        Dim index = wh_product_dgv.CurrentRow.Index
        Dim idhist = wh_product_dgv.Item(0, index).Value
        Dim values = wh_product_dgv.Item(4, index).Value
        Dim package = wh_product_dgv.Item(1, index).Value
        Dim after_values As Integer = 0
        sql = "SELECT stock FROM package_list WHERE LOWER(name_package) LIKE LOWER('%" & package & "%')"
        Dim ds = select_sqlcommand_with_datatable(sql)
        If ds.Rows.Count > 0 Then
            after_values = ds.Rows(0).Item(0) + values
            sql = "UPDATE package_list SET stock = ?stock WHERE LOWER(name_package) LIKE LOWER('%" & package & "%')"
            Dim param As New Dictionary(Of String, Integer)
            param.Add("?stock", after_values)
            If noreturnsql(sql, param) Then
                sql = "DELETE FROM wh_production_history WHERE wh_ph =?id;"
                Dim param2 As New Dictionary(Of String, Integer)
                param2.Add("?id", idhist)
                If noreturnsql(sql, param2) Then
                    MsgBox("DELETED SUCCESSFULLY")
                    wh_product_checkl.Checked = False
                    getProdSu()
                End If
            End If
        End If
    End Sub

    Private Sub updateProdHist()
        Dim index = wh_product_dgv.CurrentRow.Index
        Dim idhist = wh_product_dgv.Item(0, index).Value
        Dim values = wh_product_dgv.Item(4, index).Value
        Dim package = wh_product_dgv.Item(1, index).Value
        Dim after_values As Integer = 0
        sql = "SELECT stock FROM package_list WHERE LOWER(name_package) LIKE LOWER('%" & package & "%')"
        Dim ds = select_sqlcommand_with_datatable(sql)
        If ds.Rows.Count > 0 Then
            'If values on history is greater than updated,then dbval - values = nowval
            'otherwise, dbval + values = nowval
            sql = "SELECT package_items FROM wh_production_history WHERE wh_ph ='" & idhist & "'"
            Dim ds1 = select_sqlcommand_with_datatable(sql)
            Dim stokvalues As Integer = ds.Rows(0).Item(0)
            Dim dbvalues As Integer = 0
            Dim tempval As Integer = 0
            If ds1.Rows.Count > 0 Then
                dbvalues = ds1.Rows(0).Item(0)
            End If
            If dbvalues > values Then
                tempval = dbvalues - values
                after_values = stokvalues + tempval
            ElseIf dbvalues < values Then
                tempval = values - dbvalues
                after_values = stokvalues - tempval

            End If

            sql = "UPDATE package_list SET stock = ?stock WHERE LOWER(name_package) LIKE LOWER('%" & package & "%')"
            Dim param As New Dictionary(Of String, Integer)
            param.Add("?stock", after_values)
            If noreturnsql(sql, param) Then
                sql = "UPDATE wh_production_history SET package_items = ?items WHERE wh_ph =?id;"
                Dim param2 As New Dictionary(Of String, Integer)
                param2.Add("?items", values)
                param2.Add("?id", idhist)
                If noreturnsql(sql, param2) Then
                    MsgBox("UPDATED SUCCESSFULLY")
                    wh_product_checkl.Checked = False
                    getProdSu()
                End If
            End If
        End If
    End Sub

    Private Sub remRecvHist()
        Dim index = wh_recv_dgv.CurrentRow.Index
        Dim idhist = wh_recv_dgv.Item(0, index).Value
        Dim values = wh_recv_dgv.Item(4, index).Value
        Dim package = wh_recv_dgv.Item(1, index).Value
        Dim after_values As Integer = 0
        sql = "SELECT stock FROM package_list WHERE LOWER(name_package) LIKE LOWER('%" & package & "%')"
        Dim ds = select_sqlcommand_with_datatable(sql)
        If ds.Rows.Count > 0 Then
            after_values = ds.Rows(0).Item(0) - values
            sql = "UPDATE package_list SET stock = ?stock WHERE LOWER(name_package) LIKE LOWER('%" & package & "%')"
            Dim param As New Dictionary(Of String, Integer)
            param.Add("?stock", after_values)
            If noreturnsql(sql, param) Then
                sql = "DELETE FROM wh_receive_history WHERE wh_rh =?id;"
                Dim param2 As New Dictionary(Of String, Integer)
                param2.Add("?id", idhist)
                If noreturnsql(sql, param2) Then
                    MsgBox("DELETED SUCCESSFULLY")
                    wh_suppl_modify.Checked = False
                    getRecvSu()
                End If
            End If
        End If
    End Sub

    Private Sub updateRecvHist()
        Dim index = wh_recv_dgv.CurrentRow.Index
        Dim idhist = wh_recv_dgv.Item(0, index).Value
        Dim values = wh_recv_dgv.Item(4, index).Value
        Dim package = wh_recv_dgv.Item(1, index).Value
        Dim after_values As Integer = 0
        sql = "SELECT stock FROM package_list WHERE LOWER(name_package) LIKE LOWER('%" & package & "%')"
        Dim ds = select_sqlcommand_with_datatable(sql)
        If ds.Rows.Count > 0 Then
            'If values on history is greater than updated,then dbval - values = nowval
            'otherwise, dbval + values = nowval
            sql = "SELECT received FROM wh_receive_history WHERE wh_rh ='" & idhist & "'"
            Dim ds1 = select_sqlcommand_with_datatable(sql)
            Dim stokvalues As Integer = ds.Rows(0).Item(0)
            Dim dbvalues As Integer = 0
            Dim tempval As Integer = 0
            If ds1.Rows.Count > 0 Then
                dbvalues = ds1.Rows(0).Item(0)
            End If
            If dbvalues > values Then
                tempval = dbvalues - values
                after_values = stokvalues - tempval
            ElseIf dbvalues < values Then
                tempval = values - dbvalues
                after_values = stokvalues + tempval

            End If

            sql = "UPDATE package_list SET stock = ?stock WHERE LOWER(name_package) LIKE LOWER('%" & package & "%')"
            Dim param As New Dictionary(Of String, Integer)
            param.Add("?stock", after_values)
            If noreturnsql(sql, param) Then
                sql = "UPDATE wh_receive_history SET received = ?items WHERE wh_rh =?id;"
                Dim param2 As New Dictionary(Of String, Integer)
                param2.Add("?items", values)
                param2.Add("?id", idhist)
                If noreturnsql(sql, param2) Then
                    MsgBox("UPDATED SUCCESSFULLY")
                    wh_suppl_modify.Checked = False
                    getRecvSu()
                End If
            End If
        End If
    End Sub
    'end of sql section



    Private Sub Wh_recv_upload_Click(sender As Object, e As EventArgs) Handles wh_recv_upload.Click
        If hw_recv_id.Text = "" And wh_combo_supplier.Text = "" And hw_textb_items.Text = "" Then
            MsgBox("Please enter field!")
        Else
            If MessageBox.Show("Are you sure to insert?", "Caution!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                recv_upload()
            Else
                '            clean_in_wh()
                'e.Cancel = True
            End If
        End If



    End Sub

    Private Sub Wh_stock_checkl_CheckedChanged(sender As Object, e As EventArgs) Handles wh_stock_checkl.CheckedChanged
        If wh_stock_checkl.Checked Then
            wh_stock_btnshow.Text = "Find"
            wh_stock_tb_name.Enabled = True
        Else
            wh_stock_tb_name.Enabled = False
            wh_stock_btnshow.Text = "Show All / Refresh"
        End If

    End Sub

    Private Sub Wh_stock_btnshow_Click(sender As Object, e As EventArgs) Handles wh_stock_btnshow.Click
        If wh_stock_checkl.Checked Then
            getStockList("CHECKED")
        Else
            getStockList("")
        End If
    End Sub

    Private Sub Wh_suppl_update_Click(sender As Object, e As EventArgs) Handles wh_suppl_update.Click
        If wh_suppl_modify.Checked Then
            updateRecvHist()
        Else
            MsgBox("If You want to UPDATE,please check the checkbox")
        End If
    End Sub

    Private Sub Wh_suppl_delete_Click(sender As Object, e As EventArgs) Handles wh_suppl_delete.Click
        If wh_suppl_modify.Checked Then
            remRecvHist()
        Else
            MsgBox("If You want to DELETE,please check the checkbox")
        End If
    End Sub

    Private Sub Wh_product_upload_Click(sender As Object, e As EventArgs) Handles wh_product_upload.Click
        If wh_product_pack.Text = "" And wh_product_pic.Text = "" And wh_product_items.Text = "" Then
            MsgBox("Please enter field!")
        Else
            If MessageBox.Show("Are you sure to upload?", "Caution!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                Call product_upload()
            Else
                'clean_in_wh()
                'e.Cancel = True
            End If
        End If



    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        thisprog.Show()
    End Sub

    Private Sub Wh_recv_refresh_Click(sender As Object, e As EventArgs) Handles wh_recv_refresh.Click
        Call getRecvSu()
    End Sub

    Private Sub Wh_product_refresh_Click(sender As Object, e As EventArgs) Handles wh_product_refresh.Click
        getProdSu()
    End Sub

    Private Sub Wh_product_update_Click(sender As Object, e As EventArgs) Handles wh_product_update.Click
        If wh_product_checkl.Checked Then
            updateProdHist()
        Else
            MsgBox("Please check allow modify and select row and values column do you want to update and try again")
        End If
    End Sub

    Private Sub Wh_product_delete_Click(sender As Object, e As EventArgs) Handles wh_product_delete.Click
        If wh_product_checkl.Checked Then
            remProductHist()
        Else
            MsgBox("Please check allow modify and select row do you want to remove and try again")
        End If

    End Sub

    Private Sub Wh_product_checkl_CheckedChanged(sender As Object, e As EventArgs) Handles wh_product_checkl.CheckedChanged
        If wh_product_checkl.Checked Then
            wh_product_dgv.ReadOnly = False
        Else
            wh_product_dgv.ReadOnly = True
        End If

    End Sub

    Private Sub Wh_suppl_modify_CheckedChanged(sender As Object, e As EventArgs) Handles wh_suppl_modify.CheckedChanged
        If wh_suppl_modify.Checked Then
            wh_recv_dgv.ReadOnly = False
        Else
            wh_recv_dgv.ReadOnly = True
        End If
    End Sub

    Private Sub recv_id_enter(sender As Object, e As KeyPressEventArgs) Handles hw_recv_id.KeyPress
        Dim tmp As System.Windows.Forms.KeyPressEventArgs = e
        If tmp.KeyChar = ChrW(Keys.Enter) Then
            sql = "SELECT name_package FROM package_list WHERE id_package=" & hw_recv_id.Text & ";"
            Dim dt = select_sqlcommand_with_datatable(sql)
            If dt.Rows.Count > 0 Then
                Dim txt As String = dt.Rows(0).Item(0)
                If MessageBox.Show("Are you sure this package : " & txt & " To be selected?", "Caution!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                    wh_combo_supplier.Enabled = True
                    hw_textb_items.Enabled = True
                Else
                    clean_in_wh()
                    'e.Cancel = True
                End If
            Else
                MsgBox("id: " & hw_recv_id.Text & " Not found!")

            End If
        End If
    End Sub

    Private Sub hw_prod_key(sender As Object, e As KeyPressEventArgs) Handles wh_product_pack.KeyPress
        Dim tmp As System.Windows.Forms.KeyPressEventArgs = e
        If tmp.KeyChar = ChrW(Keys.Enter) Then
            sql = "SELECT name_package FROM package_list WHERE id_package=" & wh_product_pack.Text & ";"
            Dim dt = select_sqlcommand_with_datatable(sql)
            If dt.Rows.Count > 0 Then
                Dim txt As String = dt.Rows(0).Item(0)
                If MessageBox.Show("Are you sure this package : " & txt & " To be selected?", "Caution!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                    wh_product_pic.Enabled = True
                    wh_product_items.Enabled = True
                Else
                    clean_out_wh()
                    'e.Cancel = True
                End If
            Else
                MsgBox("id: " & wh_product_pack.Text & " Not found!")

            End If
        End If
    End Sub
    Private Sub clean_in_wh()
        hw_recv_id.Text = ""
        wh_combo_supplier.Enabled = False
        hw_textb_items.Enabled = False
        hw_recv_id.Select()
    End Sub
    Private Sub clean_out_wh()
        wh_product_pack.Text = ""
        wh_product_pic.Text = ""
        wh_product_items.Text = ""
        wh_product_pic.Enabled = False
        wh_product_items.Enabled = False
        wh_product_pack.Select()

    End Sub

    Private Sub Wh_stock_gd_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles wh_stock_gd.CellContentClick
        If e.RowIndex >= 0 Then
            Dim rows As DataGridViewRow = wh_stock_gd.Rows(e.RowIndex)
            Dim hs As New history
            hs.setID(rows.Cells(0).Value.ToString)
            hs.ShowDialog()
            'MsgBox(rows.Cells(0).Value.ToString)
        End If

    End Sub

    Private Sub Blink_Tick(sender As Object, e As EventArgs) Handles blink.Tick
        Dim Rnd As New Random
        Label13.ForeColor = Color.FromArgb(255, Rnd.Next(200), Rnd.Next(200), Rnd.Next(200))
        Label14.ForeColor = Color.FromArgb(255, Rnd.Next(200), Rnd.Next(200), Rnd.Next(200))

    End Sub

    Private Sub finder_package(sender As Object, e As KeyPressEventArgs) Handles wh_stock_tb_name.KeyPress
        Dim tmp As System.Windows.Forms.KeyPressEventArgs = e
        If tmp.KeyChar = ChrW(Keys.Enter) Then
            If wh_stock_checkl.Checked Then
                getStockList("CHECKED")
            Else
                getStockList("")
            End If
        End If
    End Sub
End Class