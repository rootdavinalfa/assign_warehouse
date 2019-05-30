Imports MySql.Data.MySqlClient
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
        wh_iduser_lbl.Text = login_form.iduser
        wh_name_lbl.Text = ""
        Call getname()

    End Sub
    Private Sub getname()
        Call connect2db()
        Dim rowname As New DataTable
        Dim id = login_form.iduser

        sql = "SELECT * FROM user_detail WHERE id_user ='" & id & "';"
        adapter = New MySqlDataAdapter(sql, Con)
        adapter.Fill(rowname)
        If rowname.Rows.Count > 0 Then
            wh_name_lbl.Text = rowname.Rows(0).Item(1)
        Else
            Application.Exit()
        End If
    End Sub
End Class