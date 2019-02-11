Imports System.Data.OleDb
Imports System.Data
Imports System.Text.RegularExpressions

Public Class Form3

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Mobile_button_Click(sender, e)
        Panel6.BackColor = Color.SlateGray
        Panel7.BackColor = Color.SlateGray
        Panel13.BackColor = Color.SlateGray
        Panel4.BackColor = Color.SlateGray
        Panel17.BackColor = Color.SlateGray


        Panel6.Location = New Point(Panel3.Width, Panel3.Height)
        Panel6.Width = Me.Width - Panel3.Width
        Panel6.Height = Me.Height - Panel3.Height

        Panel7.Location = New Point(0, 0)
        Panel7.Width = Panel6.Width
        Panel7.Height = Panel6.Height

        Panel4.Location = New Point(0, 0)
        Panel4.Width = Panel6.Width
        Panel4.Height = Panel6.Height

        Panel13.Location = New Point(0, 0)
        Panel13.Width = Panel6.Width
        Panel13.Height = Panel6.Height

        Panel17.Location = New Point(0, 0)
        Panel17.Width = Panel6.Width
        Panel17.Height = Panel6.Height

        Panel7.Location = New Point(0, 0)
    End Sub

    Private Sub Mobile_button_Click(sender As Object, e As EventArgs) Handles mobile_button.Click
        Panel7.Hide()
        Panel13.Hide()
        Panel4.Hide()
        Panel17.Hide()


        mobile_button.BackColor = Color.SlateGray
        internet_button.BackColor = Color.FromKnownColor(KnownColor.Control)
        tv_button.BackColor = Color.FromKnownColor(KnownColor.Control)
        Button6.BackColor = Color.FromKnownColor(KnownColor.Control)
        Button8.BackColor = Color.FromKnownColor(KnownColor.Control)

    End Sub

    Private Sub Internet_button_Click(sender As Object, e As EventArgs) Handles internet_button.Click
        Panel4.Show()
        Panel7.Hide()
        Panel13.Hide()
        Panel17.Hide()

        internet_button.BackColor = Color.SlateGray
        tv_button.BackColor = Color.FromKnownColor(KnownColor.Control)
        mobile_button.BackColor = Color.FromKnownColor(KnownColor.Control)
        Button6.BackColor = Color.FromKnownColor(KnownColor.Control)
        Button8.BackColor = Color.FromKnownColor(KnownColor.Control)
    End Sub

    Private Sub Tv_button_Click(sender As Object, e As EventArgs) Handles tv_button.Click
        Panel4.Show()
        Panel13.Show()
        Panel7.Hide()
        Panel17.Hide()


        tv_button.BackColor = Color.SlateGray
        internet_button.BackColor = Color.FromKnownColor(KnownColor.Control)
        mobile_button.BackColor = Color.FromKnownColor(KnownColor.Control)
        Button6.BackColor = Color.FromKnownColor(KnownColor.Control)
        Button8.BackColor = Color.FromKnownColor(KnownColor.Control)

    End Sub

    Private Sub Reset_fields()
        TextBox11.Text = ""
        TextBox12.Text = ""
        TextBox5.Text = ""
    End Sub
    Private Sub Manage_fields(val As Boolean)

        TextBox11.Enabled = val
        TextBox12.Enabled = val
        RadioButton5.Enabled = val
        RadioButton6.Enabled = val
        TextBox5.Enabled = val

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If TextBox11.Text = "" Or TextBox12.Text = "" Or TextBox5.Text = "" Or TextBox23.Text = "" Or TextBox24.Text = "" Or TextBox25.Text = "" Or TextBox26.Text = "" Or TextBox27.Text = "" Then
            MsgBox("Please Enter All Details")
        ElseIf Regex.IsMatch(TextBox12.Text, "^[0-9 ]+$") And Regex.IsMatch(TextBox5.Text, "^[0-9 ]+$") And Regex.IsMatch(TextBox23.Text, "^[0-9 ]+$") And Regex.IsMatch(TextBox25.Text, "^[0-9 ]+$") Then
            'Validation of talktime and message number
            Dim Type_ As String = ""
            Dim date_ As String = TextBox27.Text
            If RadioButton5.Checked = True Then
                Type_ = "PostPaid"
            ElseIf RadioButton6.Checked = True Then
                Type_ = "PrePaid"
            End If

            Dim path As String = My.Application.Info.DirectoryPath
            path = path + "\MobilePlansDB.accdb"
            Dim dbsource As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path
            Dim conn = New OleDbConnection(dbsource)
            Dim insert As String = "Insert into MobilePlans([PlanName],[TT_balance],[M_balance],[Validity period],[Type],[Cost],[Description],[Net_MB],[Net_Balance]) Values('" & TextBox11.Text & "','" & TextBox12.Text & "','" & TextBox5.Text & "','" & date_ & "','" & Type_ & "','" & TextBox23.Text & "','" & TextBox24.Text & "','" & TextBox25.Text & "','" & TextBox26.Text & "');"
            Dim cmd As New OleDbCommand(insert, conn)
            conn.Open()
            Try
                cmd.ExecuteNonQuery()
                MsgBox("Succesfully Created")
                Reset_fields()
                TextBox23.Text = ""
                TextBox24.Text = ""
                TextBox25.Text = ""
                TextBox26.Text = ""
            Catch ex As Exception
                MsgBox("Error Try Again" + ex.ToString)
            End Try
            conn.Close()
        Else
            MsgBox("Please Fill Numbers In TalkTime Cost Net_MB And Messages Fields")
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Panel4.Show()
        Panel13.Show()
        Panel7.Show()
        Panel17.Hide()


        Button6.BackColor = Color.SlateGray
        tv_button.BackColor = Color.FromKnownColor(KnownColor.Control)
        internet_button.BackColor = Color.FromKnownColor(KnownColor.Control)
        mobile_button.BackColor = Color.FromKnownColor(KnownColor.Control)
        Button8.BackColor = Color.FromKnownColor(KnownColor.Control)

        Dim dt As New DataTable
        Dim da As New OleDbDataAdapter
        Dim path As String = My.Application.Info.DirectoryPath
        path = path + "\UserRequestDB.accdb"
        Dim dbsource As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path
        Dim conn = New OleDbConnection(dbsource)
        conn.Open()
        Dim F As Integer = 0
        Try
            da = New OleDbDataAdapter("Select [ID],[PhoneNumber],[AmountRequested],[DateOfRequest] from UserRequestDB where Flag = " & F & "", conn)
            da.Fill(dt)
            DataGridView1.DataSource = dt
            DataGridView1.ClearSelection()
            Dim num As Integer = DataGridView1.Columns.Count
            If DataGridView1.ColumnCount = 4 Then
                Dim btn1 As DataGridViewButtonColumn = New DataGridViewButtonColumn()
                btn1.HeaderText = "Click Here"
                btn1.Name = "btn"
                btn1.Text = "Reject"
                btn1.UseColumnTextForButtonValue = True
                DataGridView1.Columns.Add(btn1)
                Dim btn2 As DataGridViewButtonColumn = New DataGridViewButtonColumn()
                btn2.HeaderText = "Click Here"
                btn2.Name = "btn2"
                btn2.Text = "Accept"
                btn2.UseColumnTextForButtonValue = True
                DataGridView1.Columns.Add(btn2)
            End If
        Catch ex As Exception
            MsgBox("No Requests Right Now!!")
        End Try
        conn.Close()
    End Sub

    Private Sub Accept_Click(sender As Object, e As EventArgs) Handles Accept.Click
        Dim row As Integer
        Dim ID As Integer
        Dim PNo As String = ""
        Dim Cost As Integer = 0
        Try
            row = DataGridView1.CurrentRow.Index
            ID = DataGridView1.Item(0, row).Value()
            PNo = DataGridView1.Item(1, row).Value()
            Cost = DataGridView1.Item(2, row).Value()
        Catch ex As Exception
            MsgBox("Please Select A Row First")
            Exit Sub
        End Try
        Dim path As String = My.Application.Info.DirectoryPath
        path = path + "\UserRequestDB.accdb"
        Dim dbsource As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path
        Dim conn = New OleDbConnection(dbsource)
        conn.Open()
        Dim F As Integer = 1   'Accepted
        Dim query As String = "Update [UserRequestDB] set [Flag]=" & F & " Where [ID] = " & ID & ""
        Dim cmd As OleDbCommand
        cmd = New OleDbCommand(query, conn)
        cmd.ExecuteNonQuery()
        cmd.Dispose()
        conn.Close()
        path = My.Application.Info.DirectoryPath + "\GeneralUserDB.accdb"
        dbsource = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path
        conn = New OleDbConnection(dbsource)
        conn.Open()
        query = "Select TBalance From GeneralUser Where PhoneNo='" & PNo & "'"
        cmd = New OleDbCommand(query, conn)
        Dim CurrBalance As Integer = cmd.ExecuteScalar()
        CurrBalance = CurrBalance + Cost
        query = "Update GeneralUser set [TBalance]=" & CurrBalance & " Where PhoneNo='" & PNo & "'"
        cmd = New OleDbCommand(query, conn)
        cmd.ExecuteNonQuery()
        cmd.Dispose()
        conn.Close()
        Button6.PerformClick()
        MsgBox("Accepted")
        DataGridView1.ClearSelection()
        conn.Close()
    End Sub
    Private Sub Reject_Click(sender As Object, e As EventArgs) Handles Reject.Click
        Dim row As Integer
        Dim ID As Integer
        Try
            row = DataGridView1.CurrentRow.Index
            ID = DataGridView1.Item(0, row).Value()
        Catch ex As Exception
            MsgBox("Please Select A Row First")
            Exit Sub
        End Try
        Dim path As String = My.Application.Info.DirectoryPath
        path = path + "\UserRequestDB.accdb"
        Dim dbsource As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path
        Dim conn = New OleDbConnection(dbsource)
        conn.Open()
        Dim F As Integer = 2    'Rejected
        Dim query As String = "Update [UserRequestDB] set [Flag]=" & F & " Where [ID] = " & ID & ""
        Dim cmd As OleDbCommand
        cmd = New OleDbCommand(query, conn)
        cmd.ExecuteNonQuery()
        cmd.Dispose()
        conn.Close()
        Button6.PerformClick()
        MsgBox("Rejected")
        DataGridView1.ClearSelection()
        conn.Close()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Me.Hide()
        Form4.Show()
        Dim path As String = My.Application.Info.DirectoryPath
        path = path + "\GeneralUserDB.accdb"
        Dim dbsource As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path
        Dim conn = New OleDbConnection(dbsource)
        Dim adapter As New OleDbDataAdapter()
        Dim reader As OleDbDataReader
        Dim tuser As String = "8986727258"
        Dim cmd As OleDbCommand
        conn.Open()
        Dim F As Integer = 1
        Dim sql As String = "SELECT * FROM UserRequestDB WHERE PhoneNumber='" & tuser & "'"
        Try
            cmd = New OleDbCommand(sql, conn)
            reader = cmd.ExecuteReader()
            Dim left As Integer = 10
            Dim top As Integer = 0
            While reader.Read
                Dim lb As Label = New Label
                If reader.GetInt32(4) = 1 Then
                    lb.Text = "Your Request For " + reader.GetInt32(2).ToString + " On " + reader.GetDateTime(3).ToString + " Has Been Approved!"
                ElseIf reader.GetInt32(4) = 2 Then
                    lb.Text = "Your Request For " + reader.GetInt32(2).ToString + " On " + reader.GetDateTime(3).ToString + " Has Been Rejected!"
                End If
                lb.Width = 2000
                lb.Height = 30
                lb.Top = top
                lb.Left = left
                top = top + 40
                Form4.Controls.Add(lb)
                lb.Show()
            End While
        Catch ex As Exception
            MsgBox("No Notificatiosn Right Now !!" + ex.ToString)
        End Try
        conn.Close()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If TextBox13.Text = "" Or TextBox14.Text = "" Or TextBox9.Text = "" Or TextBox8.Text = "" Then
            MsgBox("Please Enter All Details")
        ElseIf Regex.IsMatch(TextBox9.Text, "^[0-9 ]+$") Then
            'Validation of talktime and message number
            Dim Type_ As String = ""
            Dim date_ As String = TextBox8.Text
            If RadioButton3.Checked = True Then
                Type_ = "PostPaid"
            ElseIf RadioButton4.Checked = True Then
                Type_ = "PrePaid"
            End If

            Dim path As String = My.Application.Info.DirectoryPath
            path = path + "\TVPlans.accdb"
            Dim dbsource As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path
            Dim conn = New OleDbConnection(dbsource)
            Dim insert As String = "Insert into TVPlans([Type],[Cost],[PlanName],[Validity],[Description]) Values('" & Type_ & "','" & TextBox9.Text & "','" & TextBox13.Text & "','" & date_ & "','" & TextBox14.Text & "');"
            Dim cmd As New OleDbCommand(insert, conn)
            conn.Open()
            Try
                cmd.ExecuteNonQuery()
                MsgBox("Succesfully Created")
                TextBox13.Text = ""
                TextBox14.Text = ""
                TextBox9.Text = ""
                TextBox27.Text = ""
                TextBox8.Text = ""
            Catch ex As Exception
                MsgBox("Error Try Again" + ex.ToString)
            End Try
            conn.Close()
        Else
            MsgBox("Please Enter A Number As Cost")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox2.Text = "" Or TextBox7.Text = "" Or TextBox1.Text = "" Or TextBox3.Text = "" Or TextBox6.Text = "" Or TextBox4.Text = "" Then
            MsgBox("Please Enter All Details")
        ElseIf Regex.IsMatch(TextBox3.Text, "^[0-9 ]+$") And Regex.IsMatch(TextBox1.Text, "^[0-9 ]+$") And Regex.IsMatch(TextBox6.Text, "^[0-9 ]+$") Then
            'Validation of talktime and message number
            Dim Type_ As String = ""
            Dim date_ As String = TextBox4.Text
            If RadioButton1.Checked = True Then
                Type_ = "PostPaid"
            ElseIf RadioButton2.Checked = True Then
                Type_ = "PrePaid"
            End If

            Dim path As String = My.Application.Info.DirectoryPath
            path = path + "\InternetPlans.accdb"
            Dim dbsource As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path
            Dim conn = New OleDbConnection(dbsource)
            Dim insert As String = "Insert into InternetPlans([Type],[Cost],[PlanName],[Validity],[Description],[DataLimit],[Speed]) Values('" & Type_ & "','" & TextBox3.Text & "','" & TextBox2.Text & "','" & date_ & "','" & TextBox7.Text & "','" & TextBox6.Text & "','" & TextBox1.Text & "');"
            Dim cmd As New OleDbCommand(insert, conn)
            conn.Open()
            Try
                cmd.ExecuteNonQuery()
                MsgBox("Succesfully Created")
                TextBox2.Text = ""
                TextBox7.Text = ""
                TextBox1.Text = ""
                TextBox6.Text = ""
                TextBox3.Text = ""
                TextBox4.Text = ""
            Catch ex As Exception
                MsgBox("Error Try Again")
            End Try
            conn.Close()
        Else
            MsgBox("Please Enter A Number As Cost , DataLimit And Speed")
        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Panel4.Show()
        Panel13.Show()
        Panel7.Show()
        Panel17.Show()
        Button8.BackColor = Color.SlateGray
        Button6.BackColor = Color.FromKnownColor(KnownColor.Control)
        tv_button.BackColor = Color.FromKnownColor(KnownColor.Control)
        internet_button.BackColor = Color.FromKnownColor(KnownColor.Control)
        mobile_button.BackColor = Color.FromKnownColor(KnownColor.Control)


        Dim dt As New DataTable
        Dim da As New OleDbDataAdapter
        Dim path As String = My.Application.Info.DirectoryPath
        path = path + "\GeneralUserDB.accdb"
        Dim dbsource As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path
        Dim conn = New OleDbConnection(dbsource)
        conn.Open()
        Dim F As Integer = 0
        Try
            da = New OleDbDataAdapter("Select * From GeneralUser", conn)
            da.Fill(dt)
            DataGridView2.DataSource = dt
            DataGridView2.ClearSelection()
        Catch ex As Exception
            MsgBox("No Users Right Now!!")
        End Try
        TextBox17.Text = ""
        TextBox18.Text = ""
        TextBox19.Text = ""
        TextBox20.Text = ""
        TextBox21.Text = ""
        TextBox22.Text = ""
        TextBox15.Text = ""
        TextBox16.Text = ""
        conn.Close()

    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Dim path As String = My.Application.Info.DirectoryPath
        path = path + "\GeneralUserDB.accdb"
        Dim dbsource As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path
        Dim conn = New OleDbConnection(dbsource)
        If RadioButton7.Checked = True Then
            Dim Pno As String = TextBox16.Text
            If Pno = "" Or Pno.Length <> 10 Then
                MsgBox("Please Enter Correct Phone Number")
            Else
                Dim adapter As New OleDbDataAdapter()
                Dim reader As OleDbDataReader
                Dim tuser As String = Pno
                Dim cmd As OleDbCommand
                conn.Open()
                Dim sql As String = "SELECT * FROM GeneralUser WHERE PhoneNo='" & tuser & "'"
                Try
                    cmd = New OleDbCommand(sql, conn)
                    reader = cmd.ExecuteReader()
                    While reader.Read
                        TextBox17.Text = reader.GetString(1).ToString
                        TextBox18.Text = reader.GetString(2).ToString
                        TextBox19.Text = reader.GetString(0).ToString
                        TextBox20.Text = reader.GetString(3).ToString
                        TextBox21.Text = reader.GetString(12).ToString
                        TextBox22.Text = reader.GetDateTime(10).ToString
                    End While
                Catch ex As Exception
                    MsgBox("Number Does Not Exist!!" + ex.ToString)
                End Try
            End If
        ElseIf RadioButton8.Checked = True Then
            Dim Pno As String = TextBox15.Text
            If Pno = "" Or Pno.Length <> 12 Then
                MsgBox("Please Enter Correct Aadhar Number")
            Else
                Dim adapter As New OleDbDataAdapter()
                Dim reader As OleDbDataReader
                Dim tuser As String = Pno
                Dim cmd As OleDbCommand
                conn.Open()
                Dim sql As String = "SELECT * FROM GeneralUser WHERE Aadhar='" & tuser & "'"
                Try
                    cmd = New OleDbCommand(sql, conn)
                    reader = cmd.ExecuteReader()
                    While reader.Read
                        TextBox17.Text = reader.GetString(1).ToString
                        TextBox18.Text = reader.GetString(2).ToString
                        TextBox19.Text = reader.GetString(0).ToString
                        TextBox20.Text = reader.GetString(3).ToString
                        TextBox21.Text = reader.GetString(12).ToString
                        TextBox22.Text = reader.GetString(10).ToString
                    End While
                Catch ex As Exception
                    MsgBox("Number Does Not Exist!!")
                End Try
            End If
        End If
        conn.Close()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If e.ColumnIndex = 4 Then
            Dim row As Integer
            Dim ID As Integer
            Try
                row = DataGridView1.CurrentRow.Index
                ID = DataGridView1.Item(0, row).Value()
            Catch ex As Exception
                MsgBox("Please Select A Row First")
                Exit Sub
            End Try
            Dim path As String = My.Application.Info.DirectoryPath
            path = path + "\UserRequestDB.accdb"
            Dim dbsource As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path
            Dim conn = New OleDbConnection(dbsource)
            conn.Open()
            Dim F As Integer = 2    'Rejected
            Dim query As String = "Update [UserRequestDB] set [Flag]=" & F & " Where [ID] = " & ID & ""
            Dim cmd As OleDbCommand
            cmd = New OleDbCommand(query, conn)
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            conn.Close()
            Button6.PerformClick()
            MsgBox("Rejected")
            DataGridView1.ClearSelection()
            conn.Close()
        ElseIf e.ColumnIndex = 5 Then
            Dim row As Integer
            Dim ID As Integer
            Dim PNo As String = ""
            Dim Cost As Integer = 0
            Try
                row = DataGridView1.CurrentRow.Index
                ID = DataGridView1.Item(0, row).Value()
                PNo = DataGridView1.Item(1, row).Value()
                Cost = DataGridView1.Item(2, row).Value()
            Catch ex As Exception
                MsgBox("Please Select A Row First")
                Exit Sub
            End Try
            Dim path As String = My.Application.Info.DirectoryPath
            path = path + "\UserRequestDB.accdb"
            Dim dbsource As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path
            Dim conn = New OleDbConnection(dbsource)
            conn.Open()
            Dim F As Integer = 1   'Accepted
            Dim query As String = "Update [UserRequestDB] set [Flag]=" & F & " Where [ID] = " & ID & ""
            Dim cmd As OleDbCommand
            cmd = New OleDbCommand(query, conn)
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            conn.Close()
            path = My.Application.Info.DirectoryPath + "\GeneralUserDB.accdb"
            dbsource = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path
            conn = New OleDbConnection(dbsource)
            conn.Open()
            query = "Select TBalance From GeneralUser Where PhoneNo='" & PNo & "'"
            cmd = New OleDbCommand(query, conn)
            Dim CurrBalance As Integer = cmd.ExecuteScalar()
            CurrBalance = CurrBalance + Cost
            query = "Update GeneralUser set [TBalance]=" & CurrBalance & " Where PhoneNo='" & PNo & "'"
            cmd = New OleDbCommand(query, conn)
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            conn.Close()
            Button6.PerformClick()
            MsgBox("Accepted")
            DataGridView1.ClearSelection()
            conn.Close()
        End If
    End Sub
End Class