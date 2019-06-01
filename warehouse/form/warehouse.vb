'Copyright 2019
'    Davin Alfarizky Putra Basudewa <davinbambang@hotmail.com / dbasudewa@gmail.com>
'    All rights reserved
Imports warehouse.sql_command
Public Class warehouse
    Private Sub warehouse_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If MessageBox.Show("Are you sure to close this form?", "Caution!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            login_form.Show()
        Else
            e.Cancel = True
        End If

    End Sub

    Private Sub warehouse_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        wh_summary_suppl.Checked = True
        now_date.Enabled = True
        wh_iduser_lbl.Text = login_form.iduser
        wh_name_lbl.Text = ""
        Call getname()
        Call getSupplierList()
        Call getSummary()
        Call getStockList("")

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
t1.id_supplier = t4.id_supplier"
        ElseIf wh_summary_product.Checked Then
            sql = "SELECT t1.wh_ph as 'ID',t2.name_package as 'Name Package', t3.name as 'PIC',t4.name as 'Maintainer',t1.package_items as 'Values'
FROM wh_production_history t1 INNER JOIN package_list t2 ON t1.id_package = t2.id_package
INNER JOIN user_detail t3 ON t1.id_pic = t3.id_user
INNER JOIN user_detail t4 ON t1.id_maintain = t3.id_user"
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

        Dim recv As Integer = hw_textb_items.Text
        sql = "INSERT INTO wh_receive_history(id_package,id_supplier,id_maintain,received)
VALUE(?idpack,?idsuppl,?idmaintain,?recv)"
        Dim param As New Dictionary(Of String, Integer)
        param.Add("?idpack", idpack)
        param.Add("?idsuppl", suppli)
        param.Add("?idmaintain", id)
        param.Add("?recv", recv)
        If insert_recv_upload(sql, param) Then
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
            If insert_recv_upload(sql, param2) Then
                MsgBox("Data Uploaded!")

            End If

        Else
            MsgBox("ERROR!")
        End If



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
    'end of sql section

    Private Sub Wh_recv_upload_Click(sender As Object, e As EventArgs) Handles wh_recv_upload.Click
        recv_upload()
    End Sub

    Private Sub Wh_stock_checkl_CheckedChanged(sender As Object, e As EventArgs) Handles wh_stock_checkl.CheckedChanged
        If wh_stock_checkl.Checked Then
            wh_stock_btnshow.Text = "Find"
        Else
            wh_stock_btnshow.Text = "Show All"
        End If

    End Sub

    Private Sub Wh_stock_btnshow_Click(sender As Object, e As EventArgs) Handles wh_stock_btnshow.Click
        If wh_stock_checkl.Checked Then
            getStockList("CHECKED")
        Else
            wh_stock_btnshow.Text = "Show"
            getStockList("")
        End If
    End Sub

    Private Sub Wh_suppl_update_Click(sender As Object, e As EventArgs) Handles wh_suppl_update.Click
        If wh_suppl_modify.Checked Then
        Else
            MsgBox("If You want to UPDATE,please check the checkbox")
        End If
    End Sub

    Private Sub Wh_suppl_delete_Click(sender As Object, e As EventArgs) Handles wh_suppl_delete.Click
        If wh_suppl_modify.Checked Then
        Else
            MsgBox("If You want to DELETE,please check the checkbox")
        End If
    End Sub
End Class