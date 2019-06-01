﻿'Copyright 2019
'    Davin Alfarizky Putra Basudewa <davinbambang@hotmail.com / dbasudewa@gmail.com>
'    All rights reserved
Imports MySql.Data.MySqlClient
Public Class login_form
    Public iduser As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles login_btn.Click
        Call Login()
    End Sub

    Private Sub login_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Check is connected to mysql server and has no problem
        If checkConnect() = True Then
            MessageBox.Show("Connected to server")
        Else
            Application.Exit()
        End If
    End Sub

    Sub Login()
        Call connect2db()
        Dim username As String
        Dim password As String
        Dim rowtables As New DataTable
        username = username_text.Text
        password = password_text.Text
        If username = "" And password = "" Then
            MsgBox("Isi username dan password")

        ElseIf username = "" Then
            MsgBox("Isi Usename")
        ElseIf password = "" Then
            MsgBox("Isi Password")
        Else
            sql = "SELECT t1.id_user,t2.type FROM user_list t1 INNER JOIN user_detail t2 ON t1.id_user = t2.id_user 
                   WHERE t1.username='" & username & "' && t1.password ='" & password & "';"
            adapter = New MySqlDataAdapter(sql, Con)
            adapter.Fill(rowtables)
            If rowtables.Rows.Count > 0 Then
                iduser = rowtables.Rows(0).Item(0)
                Dim type_user As String = rowtables.Rows(0).Item(1)
                If type_user = "ADMIN" Or type_user = "PIC" Then
                    MsgBox("Login Success")
                    Dim wh = New warehouse
                    wh.Show()
                    Me.Hide()
                Else
                    MsgBox("Not Authorized!")
                    username_text.Text = ""
                    password_text.Text = ""
                End If


            Else
                MsgBox("Username/password salah")
                username_text.Text = ""
                password_text.Text = ""
            End If

        End If
        'adapter = New MySqlDataAdapter("SELECT")
    End Sub
End Class
