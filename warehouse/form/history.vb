Imports warehouse.sql_command
Public Class history
    Dim ids, first, over As String
    Dim limit, in_counter, out_counter As Integer
    Private Sub History_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "History | " & ids
        limit = tb_limiter.Text
        cb_show_all.Checked = True
        tb_limiter.Enabled = False
        If cb_show_all.Checked Then
            Call getInc()
            Call getOut()
        End If
    End Sub
    Public Sub setID(id As String)
        ids = id
    End Sub
    Private Sub getInc()
        in_counter = 0
        sql = "SELECT t1.wh_rh as 'ID',t2.name_package AS 'Package Name',t4.name_supplier as 'Supplier' , t3.name as 'Maintainer',t1.received As 'Values',t1.date As 'Received On'
FROM wh_receive_history t1 INNER JOIN package_list t2 ON t1.id_package = t2.id_package
INNER JOIN user_detail t3 ON t1.id_maintain = t3.id_user INNER JOIN supplier t4 ON
t1.id_supplier = t4.id_supplier WHERE t1.id_package = " & Convert.ToInt32(ids) & " ORDER BY t1.date DESC LIMIT 0," & limit & ""
        Dim ds = select_sqlcommand_with_dataset(sql)
        If ds.Tables.Count > 0 Then
            incoming.DataSource = ds.Tables(0)
            For index As Integer = 0 To incoming.RowCount - 1
                in_counter += Convert.ToInt32(incoming.Rows(index).Cells(4).Value)
            Next
            txt_in_counter.Text = in_counter
        End If
    End Sub
    Private Sub getOut()
        out_counter = 0
        sql = "SELECT t1.wh_ph as 'ID',t2.name_package as 'Name Package', t3.name as 'PIC',t4.name as 'Maintainer',t1.package_items as 'Values',t1.datetime As 'Out ON'
FROM wh_production_history t1 INNER JOIN package_list t2 ON t1.id_package = t2.id_package
INNER JOIN user_detail t3 ON t1.id_pic = t3.id_user
INNER JOIN user_detail t4 ON t1.id_maintain = t4.id_user WHERE t1.id_package=" & Convert.ToInt32(ids) & " ORDER BY t1.datetime DESC LIMIT 0," & limit & ""
        Dim ds = select_sqlcommand_with_dataset(sql)
        If ds.Tables.Count > 0 Then
            outcoming.DataSource = ds.Tables(0)
            For index As Integer = 0 To outcoming.RowCount - 1
                out_counter += Convert.ToInt32(outcoming.Rows(index).Cells(4).Value)
            Next
            txt_out_counter.Text = out_counter
        End If
    End Sub

    Private Sub getIncWithDate()
        in_counter = 0
        sql = "SELECT t1.wh_rh as 'ID',t2.name_package AS 'Package Name',t4.name_supplier as 'Supplier' , t3.name as 'Maintainer',t1.received As 'Values',t1.date As 'Received On'
FROM wh_receive_history t1 INNER JOIN package_list t2 ON t1.id_package = t2.id_package
INNER JOIN user_detail t3 ON t1.id_maintain = t3.id_user INNER JOIN supplier t4 ON
t1.id_supplier = t4.id_supplier WHERE t1.id_package = " & Convert.ToInt32(ids) & " AND t1.date BETWEEN '" & first & "' AND '" & over & "' ORDER BY t1.date DESC LIMIT 0," & limit & ""
        'MsgBox("IN:" & sql)
        Dim ds = select_sqlcommand_with_dataset(sql)
        If ds.Tables.Count > 0 Then
            incoming.DataSource = ds.Tables(0)
            For index As Integer = 0 To incoming.RowCount - 1
                in_counter += Convert.ToInt32(incoming.Rows(index).Cells(4).Value)
            Next
            txt_in_counter.Text = in_counter
        End If
    End Sub

    Private Sub getOutWithDate()
        out_counter = 0
        sql = "SELECT t1.wh_ph as 'ID',t2.name_package as 'Name Package', t3.name as 'PIC',t4.name as 'Maintainer',t1.package_items as 'Values',t1.datetime As 'Out ON'
FROM wh_production_history t1 INNER JOIN package_list t2 ON t1.id_package = t2.id_package
INNER JOIN user_detail t3 ON t1.id_pic = t3.id_user
INNER JOIN user_detail t4 ON t1.id_maintain = t4.id_user WHERE t1.id_package=" & Convert.ToInt32(ids) & " AND t1.datetime BETWEEN '" & first & "' AND '" & over & "' ORDER BY t1.datetime DESC LIMIT 0," & limit & ""
        'MsgBox("OUT:" & sql)
        Dim ds = select_sqlcommand_with_dataset(sql)
        If ds.Tables.Count > 0 Then
            outcoming.DataSource = ds.Tables(0)
            For index As Integer = 0 To outcoming.RowCount - 1
                out_counter += Convert.ToInt32(outcoming.Rows(index).Cells(4).Value)
            Next
            txt_out_counter.Text = out_counter
        End If
    End Sub


    Private Sub Cb_show_all_CheckedChanged(sender As Object, e As EventArgs) Handles cb_show_all.CheckedChanged
        If cb_show_all.Checked Then
            datepick_sec.Enabled = False
            datepick_first.Enabled = False
        Else
            datepick_sec.Enabled = True
            datepick_first.Enabled = True
        End If
    End Sub

    Private Sub Btn_refresh_Click(sender As Object, e As EventArgs) Handles btn_refresh.Click
        limit = tb_limiter.Text
        If cb_show_all.Checked Then
            If Not cb_limiter.Checked Then
                limit = 10
            End If
            Call getInc()
            Call getOut()
        Else
            datepick_first.Format = DateTimePickerFormat.Custom
            datepick_first.CustomFormat = "yyyy-MM-dd 00:00:00"
            first = datepick_first.Text
            datepick_sec.Format = DateTimePickerFormat.Custom
            datepick_sec.CustomFormat = "yyyy-MM-dd HH:mm:ss"
            over = datepick_sec.Text
            'MsgBox(over)
            Call getIncWithDate()
            Call getOutWithDate()

        End If
    End Sub

    Private Sub Cb_limiter_CheckedChanged(sender As Object, e As EventArgs) Handles cb_limiter.CheckedChanged
        If cb_limiter.Checked Then
            If MessageBox.Show("If you enter limit too high,that may lead to high spike on server,still want?", "Caution!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                tb_limiter.Enabled = True
            Else
                cb_limiter.Checked = False
                tb_limiter.Enabled = False
            End If

        Else
            tb_limiter.Enabled = False
        End If
    End Sub
End Class