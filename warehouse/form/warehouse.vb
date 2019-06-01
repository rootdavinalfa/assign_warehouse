'Copyright 2019
'    Davin Alfarizky Putra Basudewa <davinbambang@hotmail.com / dbasudewa@gmail.com>
'    All rights reserved
Imports MySql.Data.MySqlClient
Imports warehouse.sql_command
Public Class warehouse
    Private Sub warehouse_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If MessageBox.Show("Are you sure to close this form?", "Caution!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            login_form.Show()
            'Me.Close()
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

    End Sub


    Private Sub now_date_Tick(sender As Object, e As EventArgs) Handles now_date.Tick
        lbl_date.Text = Date.Now.ToString("dd/MM/yyyy HH:mm:ss")
    End Sub

    Private Sub summary_btn_show_Click(sender As Object, e As EventArgs) Handles wh_summary_show.Click
        getSummary()
    End Sub
    'Section For SQL Method'
    Private Sub getname()
        Call connect2db()
        Dim rowname As New DataTable
        Dim id = login_form.iduser

        sql = "SELECT * FROM user_detail WHERE id_user ='" & id & "';"
        rowname = sqlcommand_with_datatable(sql)
        If rowname.Rows.Count > 0 Then
            wh_name_lbl.Text = rowname.Rows(0).Item(1)
        Else
        Application.Exit()
        End If
    End Sub

    Private Sub getSupplierList()
        Call connect2db()
        Dim ds As New DataSet
        sql = "SELECT id_supplier,name_supplier FROM supplier;"
        ds = sqlcommand_with_dataset(sql)
        If ds.Tables.Count > 0 Then
            wh_combo_supplier.DataSource = ds.Tables(0)
            wh_combo_supplier.ValueMember = "id_supplier"
            wh_combo_supplier.DisplayMember = "name_supplier"
        End If

    End Sub

    Private Sub getSummary()
        Call connect2db()
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
        ds = sqlcommand_with_dataset(sql)
        If ds.Tables.Count > 0 Then
            wh_summary_dg.DataSource = ds.Tables(0)
        End If

    End Sub

End Class