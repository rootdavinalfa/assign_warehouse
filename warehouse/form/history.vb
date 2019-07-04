Imports warehouse.sql_command
Public Class history
    Dim ids As String
    Private Sub History_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "History | " & ids
        Call getInc()
        Call getOut()
    End Sub
    Public Sub setID(id As String)
        ids = id
    End Sub

    Private Sub getInc()
        sql = "SELECT t1.wh_rh as 'ID',t2.name_package AS 'Package Name',t4.name_supplier as 'Supplier' , t3.name as 'Maintainer',t1.received As 'Values'
FROM wh_receive_history t1 INNER JOIN package_list t2 ON t1.id_package = t2.id_package
INNER JOIN user_detail t3 ON t1.id_maintain = t3.id_user INNER JOIN supplier t4 ON
t1.id_supplier = t4.id_supplier WHERE t1.id_package = " & Convert.ToInt32(ids) & " ORDER BY t1.wh_rh DESC"
        Dim ds = select_sqlcommand_with_dataset(sql)
        If ds.Tables.Count > 0 Then
            incoming.DataSource = ds.Tables(0)
        End If
    End Sub
    Private Sub getOut()
        sql = "SELECT t1.wh_ph as 'ID',t2.name_package as 'Name Package', t3.name as 'PIC',t4.name as 'Maintainer',t1.package_items as 'Values'
FROM wh_production_history t1 INNER JOIN package_list t2 ON t1.id_package = t2.id_package
INNER JOIN user_detail t3 ON t1.id_pic = t3.id_user
INNER JOIN user_detail t4 ON t1.id_maintain = t4.id_user WHERE t1.id_package=" & Convert.ToInt32(ids) & " ORDER BY t1.wh_ph DESC"
        Dim ds = select_sqlcommand_with_dataset(sql)
        If ds.Tables.Count > 0 Then
            outcoming.DataSource = ds.Tables(0)
        End If
    End Sub

End Class