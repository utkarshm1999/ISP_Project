Imports System.Data.OleDb
Imports System.Data
Imports System.Text.RegularExpressions
Public Class Form2
    Public Property UserNumber As String
    Public Property mobileplannumber As Integer
    Public Property tvplannumber As String
    Public Property internetplannumber As String
    Public Property mobileplanstartdate As Date
    Public Property internetplanstartdate As Date
    Public Property tvplanstartdate As Date
    Public Property Tbalance As Integer
    Public Property daysleftformobileplan As Integer
    Public Property daysleftforinternetplan As Integer
    Public Property daysleftfortvplan As Integer
    Public Property mobiledatausage As Integer
    Public Property internetusage As Integer







    Public Function Reset_details()
        PhoneNoTextBox.Text = UserNumber
        FirstNameTextBox.ReadOnly = True
        SecondNameTextBox.ReadOnly = True
        DOBDateTimePicker.Enabled = False
        AddressTextBox.ReadOnly = True
        save_button.Enabled = False
        restore_button.Enabled = False

        Dim Fname As String
        Dim Sname As String
        Dim Address As String
        Dim UserName As String

        Dim DOB As String

        Dim Aadhar As String



        Dim path As String = My.Application.Info.DirectoryPath
        path = path + "\GeneralUserDB.accdb"
        Dim dbsource As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path
        Dim conn = New OleDbConnection(dbsource)
        Dim adapter As New OleDbDataAdapter()
        Dim reader As OleDbDataReader

        Dim cmd As OleDbCommand
        conn.Open()
        Dim sql As String = "SELECT * FROM GeneralUser WHERE PhoneNo='" & UserNumber & "'"
        Try
            cmd = New OleDbCommand(sql, conn)
            reader = cmd.ExecuteReader()

            While reader.Read
                Fname = reader.GetString(1).ToString
                Sname = reader.GetString(2).ToString
                UserName = reader.GetString(3).ToString
                Tbalance = reader.GetValue(6)

                mobileplannumber = reader.GetValue(7)

                internetplannumber = reader.GetValue(8)
                tvplannumber = reader.GetValue(9)



                DOB = reader.GetValue(10).ToString

                Aadhar = reader.GetString(12).ToString


                Address = reader.GetString(14).ToString

                mobileplanstartdate = reader.GetValue(15)
                internetplanstartdate = reader.GetValue(16)
                tvplanstartdate = reader.GetValue(17)

                mobiledatausage = reader.GetValue(18)
                internetusage = reader.GetValue(19)
            End While
        Catch ex As Exception

        End Try
        conn.Close()






        UserNameTextBox.Text = UserName
        AddressTextBox.Text = Address
        FirstNameTextBox.Text = Fname
        SecondNameTextBox.Text = Sname
        dashboardname_label.Text = Fname + " " + Sname
        DOBDateTimePicker.Text = DOB
        Dim dashboardnumber_label = New Label
        dashboardnumber_label.Text = UserNumber
        DOBDateTimePicker.Text = DOB
        Label6.Text = "Rs. " & Tbalance
        reset_mobileplandetails()
        reset_internetplandetails()
        reset_tvplandetails()






    End Function

    Public Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TVPlansDataSet1.TVPlans' table. You can move, or remove it, as needed.
        ' Me.TVPlansTableAdapter1.Fill(Me.TVPlansDataSet1.TVPlans)
        'TODO: This line of code loads data into the 'InternetPlansDataSet2.InternetPlans' table. You can move, or remove it, as needed.
        ' Me.InternetPlansTableAdapter2.Fill(Me.InternetPlansDataSet2.InternetPlans)
        'TODO: This line of code loads data into the 'InternetPlansDataSet1.InternetPlans' table. You can move, or remove it, as needed.
        'Me.InternetPlansTableAdapter1.Fill(Me.InternetPlansDataSet1.InternetPlans)
        'TODO: This line of code loads data into the 'TVPlansDataSet.TVPlans' table. You can move, or remove it, as needed.
        'Me.TVPlansTableAdapter.Fill(Me.TVPlansDataSet.TVPlans)
        'TODO: This line of code loads data into the 'InternetPlansDataSet.InternetPlans' table. You can move, or remove it, as needed.
        ' Me.InternetPlansTableAdapter.Fill(Me.InternetPlansDataSet.InternetPlans)
        'TODO: This line of code loads data into the 'MobilePlansDBDataSet1.MobilePlans' table. You can move, or remove it, as needed.
        ' Me.MobilePlansTableAdapter.Fill(Me.MobilePlansDBDataSet1.MobilePlans)
        'TODO: This line of code loads data into the 'GeneralUserDBDataSet1.GeneralUser' table. You can move, or remove it, as needed.
        ' Me.GeneralUserTableAdapter1.Fill(Me.GeneralUserDBDataSet1.GeneralUser)
        'TODO: This line of code loads data into the 'GeneralUserDBDataSet.GeneralUser' table. You can move, or remove it, as needed.
        ' Me.GeneralUserTableAdapter.Fill(Me.GeneralUserDBDataSet.GeneralUser)

        Me.WindowState = FormWindowState.Maximized
        Dashboard_button_Click(sender, e)
        Reset_details()
    End Sub

    Public Function reset_mobileplandetails()
        Dim path As String = My.Application.Info.DirectoryPath
        path = path + "\MobilePlansDB.accdb"
        Dim dbsource As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path
        Dim conn = New OleDbConnection(dbsource)
        Dim adapter As New OleDbDataAdapter()
        Dim reader As OleDbDataReader

        Dim cmd As OleDbCommand
        Dim validityperiod As Integer
        Dim planname As String
        Dim ttbalance As Integer
        Dim mbalance As Integer
        Dim netbalance As Integer
        Dim description As String



        Dim dt As New DataTable
        Dim da As New OleDbDataAdapter

        conn.Open()
        If DataGridView1.ColumnCount < 6 Then
            Try
                da = New OleDbDataAdapter("Select [ID],[Cost],[PlanName],[TT_balance],[M_balance],[Net_balance],[Validity period] From MobilePlans", conn)
                da.Fill(dt)
                DataGridView1.DataSource = dt
                DataGridView1.ClearSelection()
                Dim btn As DataGridViewButtonColumn = New DataGridViewButtonColumn()
                If DataGridView1.ColumnCount = 4 Then
                    btn.HeaderText = "Click to Avail"
                    btn.Name = "btn"
                    btn.Text = "Select"
                    btn.UseColumnTextForButtonValue = True
                    DataGridView1.Columns.Add(btn)
                End If


            Catch ex As Exception
                MsgBox("No Users Right Now!!")
            End Try
        End If


        If mobileplannumber <> "0" Then
            Dim sql As String = "SELECT * FROM MobilePlans WHERE [ID]=" & mobileplannumber

            Try
                cmd = New OleDbCommand(sql, conn)
                reader = cmd.ExecuteReader()



                While reader.Read
                    planname = reader.GetString(3).ToString
                    description = reader.GetString(4).ToString

                    validityperiod = reader.GetValue(8)
                    netbalance = reader.GetValue(9)


                End While

                conn.Close()
                planname_label.Text = planname
                Dim thisdate As Date
                thisdate = Today
                Dim datediff = thisdate - mobileplanstartdate
                Label11.Text = planname
                dbmobile_cpb.Visible = True
                dbmobile_cpb.Maximum = netbalance
                dbmobile_cpb.Value = mobiledatausage
                mp_cpb.Maximum = netbalance
                mp_cpb.Value = mobiledatausage
                Dim x As Integer = mobiledatausage / netbalance
                If x < 50 Then
                    dbmobile_cpb.ProgressColor = Color.FromArgb(255 * x / 50, 255, 0)
                    mp_cpb.ProgressColor = Color.FromArgb(255 * x / 50, 255, 0)
                ElseIf x <= 100 Then
                    dbmobile_cpb.ProgressColor = Color.FromArgb(255, 255 - 255 * (x - 50) / 50, 0)
                    mp_cpb.ProgressColor = Color.FromArgb(255, 255 - 255 * (x - 50) / 50, 0)
                End If



                If (validityperiod - CInt(datediff.Days) > 0) Then
                    Label19.Text = "Days left: " & CStr(validityperiod - CInt(datediff.Days))
                    daysleftformobileplan = (validityperiod - CInt(datediff.Days))
                    Label12.Text = "Days left: " & CStr(validityperiod - CInt(datediff.Days))
                Else
                    Label11.Text = "No active plans"
                    planname_label.Text = "No active plans"

                    Label19.Text = ""
                    Label12.Text = ""
                    daysleftformobileplan = 0
                    dbmobile_cpb.Visible = False
                    mp_cpb.Visible = False
                    Panel7.Height = 110




                End If




            Catch ex As Exception
                MsgBox("In mobile plan " + Convert.ToString(ex))
            End Try


        Else
            Label11.Text = "No active plans"
            planname_label.Text = "No active plans"

            Label19.Text = ""
            Label12.Text = ""
            daysleftformobileplan = 0
            dbmobile_cpb.Visible = False
            mp_cpb.Visible = False
            Panel7.Height = 110
        End If
        conn.Close()
    End Function
    Private Sub Mobile_button_Click(sender As Object, e As EventArgs) Handles mobile_button.Click

        dashboard_panel.Show()
        mobile_panel.Show()

        td_panel.Hide()
        tv_panel.Hide()
        internet_panel.Hide()
        myprofile_panel.Hide()
        passwordchange_panel.Hide()


        reset_mobileplandetails()

    End Sub

    Private Sub Dashboard_button_Click(sender As Object, e As EventArgs) Handles dashboard_button.Click

        dashboard_panel.Show()

        mobile_panel.Hide()
        td_panel.Hide()
        tv_panel.Hide()
        internet_panel.Hide()
        myprofile_panel.Hide()
        passwordchange_panel.Hide()
        Reset_details()


    End Sub

    Private Sub Td_button_Click(sender As Object, e As EventArgs) Handles td_button.Click

        dashboard_panel.Show()
        mobile_panel.Show()
        internet_panel.Show()
        tv_panel.Show()
        td_panel.Show()

        myprofile_panel.Hide()
        passwordchange_panel.Hide()
        Reset_details()


    End Sub
    Private Function reset_internetplandetails()
        Dim path As String = My.Application.Info.DirectoryPath
        path = path + "\InternetPlans.accdb"
        Dim dbsource As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path
        Dim conn = New OleDbConnection(dbsource)
        Dim adapter As New OleDbDataAdapter()
        Dim reader As OleDbDataReader

        Dim cmd As OleDbCommand
        Dim validityperiod As Integer
        Dim planname As String

        Dim description As String


        conn.Open()

        Dim dt As New DataTable
        Dim da As New OleDbDataAdapter

        If DataGridView2.RowCount <= 1 Then
            Try
                da = New OleDbDataAdapter("Select [ID],[PlanName],[Cost],[Speed],[DataLimit],[Validity] From InternetPlans", conn)

                da.Fill(dt)
                DataGridView2.DataSource = dt
                DataGridView2.ClearSelection()
                Dim btn As DataGridViewButtonColumn = New DataGridViewButtonColumn()
                If DataGridView2.ColumnCount = 6 Then
                    btn.HeaderText = "Click to Avail"
                    btn.Name = "btn"
                    btn.Text = "Select"
                    btn.UseColumnTextForButtonValue = True
                    DataGridView2.Columns.Add(btn)
                End If


            Catch ex As Exception
                MsgBox("No Users Right Now!!")
            End Try
        End If
        

        If internetplannumber <> "0" Then
            Dim sql As String = "SELECT * FROM InternetPlans WHERE [ID]=" & internetplannumber

            Try
                cmd = New OleDbCommand(sql, conn)
                reader = cmd.ExecuteReader()


                While reader.Read
                    planname = reader.GetString(2).ToString
                    description = reader.GetString(3).ToString

                    validityperiod = reader.GetValue(7)

                End While

                conn.Close()
                Label35.Text = planname
                Label10.Text = planname
                Dim thisdate As Date
                thisdate = Today
                Dim datediff = thisdate - internetplanstartdate



                If (validityperiod - CInt(datediff.Days) > 0) Then
                    Label36.Text = "Days left: " & CStr(validityperiod - CInt(datediff.Days))
                    daysleftforinternetplan = (validityperiod - CInt(datediff.Days))
                    Label17.Text = "Days left: " & CStr(validityperiod - CInt(datediff.Days))
                    dbinternet_cpb.Visible = True

                    dbinternet_cpb.Maximum = validityperiod
                    dbinternet_cpb.Value = CInt(datediff.Days)
                    ip_cpb.Visible = True
                    ip_cpb.Maximum = validityperiod
                    ip_cpb.Value = CInt(datediff.Days)
                    Dim x As Integer = CInt(datediff.Days) / validityperiod
                    If x < 50 Then
                        dbinternet_cpb.ProgressColor = Color.FromArgb(255 * x / 50, 255, 0)
                        ip_cpb.ProgressColor = Color.FromArgb(255 * x / 50, 255, 0)
                    ElseIf x <= 100 Then
                        dbinternet_cpb.ProgressColor = Color.FromArgb(255, 255 - 255 * (x - 50) / 50, 0)
                        ip_cpb.ProgressColor = Color.FromArgb(255, 255 - 255 * (x - 50) / 50, 0)
                    End If

                Else
                    Label35.Text = "No active plans"
                    Label10.Text = "No active plans"

                    Label36.Text = ""
                    Label17.Text = ""

                    daysleftforinternetplan = 0
                    dbinternet_cpb.Visible = False
                    ip_cpb.Visible = False
                    Panel6.Height = 110


                End If




            Catch ex As Exception
                MsgBox("In internet plan " + Convert.ToString(ex))
            End Try


        Else
            Label35.Text = "No active plans"
            Label10.Text = "No active plans"

            Label36.Text = ""
            Label17.Text = ""

            daysleftforinternetplan = 0
            dbinternet_cpb.Visible = False
            ip_cpb.Visible = False
            Panel6.Height = 110


        End If
        conn.Close()
    End Function
    Private Sub Internet_button_Click(sender As Object, e As EventArgs) Handles internet_button.Click

        dashboard_panel.Show()
        mobile_panel.Show()
        internet_panel.Show()

        td_panel.Hide()
        tv_panel.Hide()
        myprofile_panel.Hide()
        passwordchange_panel.Hide()
        reset_internetplandetails()

    End Sub

    Private Function reset_tvplandetails()
        Dim path As String = My.Application.Info.DirectoryPath
        path = path + "\TVPlans.accdb"
        Dim dbsource As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path
        Dim conn = New OleDbConnection(dbsource)
        Dim adapter As New OleDbDataAdapter()
        Dim reader As OleDbDataReader

        Dim cmd As OleDbCommand
        Dim validityperiod As Integer
        Dim planname As String
        Dim ttbalance As Integer
        Dim mbalance As Integer
        Dim netbalance As Integer
        Dim description As String


        conn.Open()
        Dim dt As New DataTable
        Dim da As New OleDbDataAdapter


        If DataGridView3.RowCount = 1 Then
            Try
                da = New OleDbDataAdapter("Select [ID],[PlanName],[Cost],[AvailableChannels(Image)],[Validity] From TVPlans", conn)

                da.Fill(dt)
                DataGridView3.DataSource = dt
                DataGridView3.ClearSelection()
                Dim btn As DataGridViewButtonColumn = New DataGridViewButtonColumn()
                If DataGridView3.ColumnCount = 5 Then
                    btn.HeaderText = "Click to Avail"
                    btn.Name = "btn"
                    btn.Text = "Select"
                    btn.UseColumnTextForButtonValue = True
                    DataGridView3.Columns.Add(btn)
                End If


            Catch ex As Exception
                MsgBox("No Users Right Now!!")
            End Try
        End If
        

        
        If tvplannumber <> "0" Then
            Dim sql As String = "SELECT * FROM TVPlans WHERE [ID]=" & tvplannumber

            Try
                cmd = New OleDbCommand(sql, conn)
                reader = cmd.ExecuteReader()



                While reader.Read
                    planname = reader.GetString(3).ToString

                    description = reader.GetString(5).ToString

                    validityperiod = reader.GetValue(4)

                End While

                conn.Close()
                Label30.Text = planname
                Dim thisdate As Date
                thisdate = Today
                Dim datediff = thisdate - tvplanstartdate
                Label33.Text = planname



                If (validityperiod - CInt(datediff.Days) > 0) Then
                    Label31.Text = "Days left: " & CStr(validityperiod - CInt(datediff.Days))
                    daysleftfortvplan = (validityperiod - CInt(datediff.Days))
                    Label34.Text = "Days left: " & CStr(validityperiod - CInt(datediff.Days))
                    dbtv_cpb.Visible = True
                    dbtv_cpb.Maximum = validityperiod
                    dbtv_cpb.Value = CInt(datediff.Days)
                    tvp_cpb.Visible = True
                    tvp_cpb.Maximum = validityperiod
                    tvp_cpb.Value = CInt(datediff.Days)
                    Dim x As Integer = CInt(datediff.Days) / validityperiod
                    If x < 50 Then
                        dbtv_cpb.ProgressColor = Color.FromArgb(255 * x / 50, 255, 0)
                        tvp_cpb.ProgressColor = Color.FromArgb(255 * x / 50, 255, 0)
                    ElseIf x <= 100 Then
                        dbtv_cpb.ProgressColor = Color.FromArgb(255, 255 - 255 * (x - 50) / 50, 0)
                        tvp_cpb.ProgressColor = Color.FromArgb(255, 255 - 255 * (x - 50) / 50, 0)
                    End If

                Else
                    Label30.Text = "No active plans"
                    Label33.Text = "No active plans"

                    Label31.Text = ""
                    Label34.Text = ""
                    daysleftfortvplan = 0
                    dbtv_cpb.Visible = False
                    tvp_cpb.Visible = False

                    Panel13.Height = 110


                End If

                conn.Close()


            Catch ex As Exception
                MsgBox("In TV plan " + Convert.ToString(ex))
            End Try
            conn.Close()

        Else
            Label30.Text = "No active plans"
            Label33.Text = "No active plans"

            Label31.Text = ""
            Label34.Text = ""
            daysleftfortvplan = 0
            dbtv_cpb.Visible = False
            tvp_cpb.Visible = False
            Panel13.Height = 110


        End If
        conn.Close()
    End Function
    Private Sub Tv_button_Click(sender As Object, e As EventArgs) Handles tv_button.Click

        dashboard_panel.Show()
        mobile_panel.Show()
        internet_panel.Show()
        tv_panel.Show()

        td_panel.Hide()
        myprofile_panel.Hide()
        passwordchange_panel.Hide()
        reset_tvplandetails()

    End Sub

    Private Sub Myprofile_button_Click(sender As Object, e As EventArgs) Handles myprofile_button.Click

        dashboard_panel.Show()
        mobile_panel.Show()
        internet_panel.Show()
        tv_panel.Show()
        td_panel.Show()
        myprofile_panel.Show()
        passwordchange_panel.Hide()

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles edit_button.Click
        FirstNameTextBox.ReadOnly = False
        SecondNameTextBox.ReadOnly = False
        DOBDateTimePicker.Enabled = True
        AddressTextBox.ReadOnly = False
        save_button.Enabled = True
        restore_button.Enabled = True
    End Sub

    Private Sub GeneralUserBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.GeneralUserBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.GeneralUserDBDataSet)

    End Sub

    Private Sub AddressLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub DOBLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub SecondNameLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Panel31_Paint(sender As Object, e As PaintEventArgs) Handles myprofile_panel.Paint

    End Sub

    Private Sub FirstNameLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PhoneNoTextBox_TextChanged(sender As Object, e As EventArgs) Handles PhoneNoTextBox.TextChanged


    End Sub

    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles save_button.Click
        Dim cFName As String = FirstNameTextBox.Text
        Dim cSName As String = SecondNameTextBox.Text
        Dim cAddress As String = AddressTextBox.Text
        Dim dob As String = DOBDateTimePicker.Text
        If cFName.Length = 0 Then
            fname_label.Text = "First Name cannot be empty"
        ElseIf cSName.Length = 0 Then
            sname_label.Text = "Second Name cannot be empty"
        Else
            fname_label.Text = ""
            sname_label.Text = ""
            Dim path As String = My.Application.Info.DirectoryPath
            path = path + "\GeneralUserDB.accdb"
            Dim dbsource As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path
            Dim conn = New OleDbConnection(dbsource)
            conn.Open()
            Dim cmd As OleDbCommand
            Dim query As String
            query = "Update [GeneralUser] set [FirstName]='" & cFName & "',[SecondName]='" & cSName & "',[Address]='" & cAddress & "',[DOB]='" & dob & "' Where [PhoneNo] = '" & UserNumber & "'"
            Try
                cmd = New OleDbCommand(query, conn)
                cmd.ExecuteNonQuery()
                cmd.Dispose()
                MsgBox("Update Successful")
            Catch ex As Exception
                MsgBox("Update Unsuccesful" + ex.ToString)
            End Try
            conn.Close()
        End If
        Reset_details()

    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        If TextBox2.Text = "" Or TextBox3.Text = "" Then
            MsgBox("Please Fill The Details")
            Return
        End If
        Dim Pnum As String = TextBox2.Text
        Dim Cost As Integer = TextBox3.Text
        Dim Num As String = UserNumber
        If Num = Pnum Then
            MsgBox("U Cannot Transfer To Your Own Account!!")
            Return
        End If
        If Pnum.Length <> 10 Then
            MsgBox("This Number Does Not Exist")
            Return
        End If
        Dim path As String = My.Application.Info.DirectoryPath
        path = path + "\GeneralUserDB.accdb"
        Dim dbsource As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path
        Dim conn = New OleDbConnection(dbsource)
        conn.Open()
        Dim query As String = "Select TBalance From GeneralUser Where PhoneNo='" & Num & "'"
        Dim TB As Integer = 0
        Try
            Dim cmd As New OleDbCommand(query, conn)
            TB = cmd.ExecuteScalar()
        Catch ex As Exception
            MsgBox("Error Occurred")
            conn.Close()
            Return
        End Try
        query = "Select Password From GeneralUser Where PhoneNo='" & Pnum & "'"
        Dim TBO As Integer = 0
        Try
            Dim cmd As New OleDbCommand(query, conn)
            Dim pass As String = cmd.ExecuteScalar().ToString
            query = "Select TBalance From GeneralUser Where PhoneNo='" & Pnum & "'"
            Dim cxd As New OleDbCommand(query, conn)
            TBO = cxd.ExecuteScalar()
        Catch ex As Exception
            MsgBox("This Number Does Not Exist")
            conn.Close()
            Return
        End Try
        If TB.ToString >= Cost Then
            Dim Res As Integer = TB - Cost
            query = "Update [GeneralUser] set [TBalance]='" & Res & "' Where [PhoneNo]='" & Num & "'"
            Dim cmd As New OleDbCommand(query, conn)
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            Res = TBO + Cost
            query = "Update [GeneralUser] set [TBalance]='" & Res & "' Where [PhoneNo]='" & Pnum & "'"
            cmd = New OleDbCommand(query, conn)
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            MsgBox("Transfer Success")
            conn.Close()
            TextBox2.Text = ""
            TextBox3.Text = ""
            Return
        Else
            MsgBox("U Don't Have Enough Balance")
            conn.Close()
            Return
        End If
        conn.Close()
    End Sub

    Private Sub restore_button_Click(sender As Object, e As EventArgs) Handles restore_button.Click
        Reset_details()
    End Sub

    Private Sub ChangePasswordTextBox_TextChanged(sender As Object, e As EventArgs) Handles ChangePasswordTextBox.TextChanged

    End Sub

    Private Sub Label52_Click(sender As Object, e As EventArgs) Handles Label52.Click

    End Sub

    Private Sub TextBox12_TextChanged(sender As Object, e As EventArgs) Handles confrimnewpassword.TextChanged

    End Sub

    Private Sub Button25_Click(sender As Object, e As EventArgs) Handles password_change.Click
        dashboard_panel.Show()
        mobile_panel.Show()
        internet_panel.Show()
        tv_panel.Show()
        td_panel.Show()
        myprofile_panel.Show()
        passwordchange_panel.Show()
    End Sub

    Private Sub backtoprofile_button_Click(sender As Object, e As EventArgs) Handles backtoprofile_button.Click
        Myprofile_button_Click(sender, e)

    End Sub

    Private Sub updatepassword_Click(sender As Object, e As EventArgs) Handles updatepassword.Click
        Dim oldpassword As String
        Dim newpassword As String
        Dim CNewpassword As String
        oldpassword = ChangePasswordTextBox.Text
        newpassword = newpassword_textbox.Text
        CNewpassword = confrimnewpassword.Text

        If oldpassword.Length = 0 Or newpassword.Length = 0 Or CNewpassword.Length = 0 Then
            oldpassword_label.Text = "No field can remain empty"
        ElseIf CNewpassword <> newpassword Then
            npassword_label.Text = "The passwords do not match"
        Else
            Dim dbpassword As String
            Dim querry As String = "Select Password From GeneralUser where PhoneNo= '" & UserNumber & "';"
            Dim path As String = My.Application.Info.DirectoryPath
            path = path + "\GeneralUserDB.accdb"
            Dim dbsource As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path
            Dim conn = New OleDbConnection(dbsource)
            Dim cmd As New OleDbCommand(querry, conn)
            conn.Open()

            dbpassword = cmd.ExecuteScalar().ToString

            If (dbpassword = oldpassword) Then
                Try
                    querry = "Update [GeneralUser] set [Password]='" & newpassword & "' Where [PhoneNo] = '" & UserNumber & "'"
                    Dim cmd1 As New OleDbCommand(querry, conn)
                    cmd1.ExecuteNonQuery()
                    cmd1.Dispose()
                    MsgBox("Password updated successfully")
                    Myprofile_button_Click(sender, e)

                Catch ex As Exception
                    MsgBox("Password update unsuccessful")
                End Try
            Else
                npassword_label.Text = "Incorrect Old password"
                
            End If
            conn.Close()

        End If

    End Sub

    Private Sub passwordchange_panel_Paint(sender As Object, e As PaintEventArgs) Handles passwordchange_panel.Paint

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Panel9_Paint(sender As Object, e As PaintEventArgs) Handles Panel9.Paint

    End Sub

    Private Sub Panel13_Paint(sender As Object, e As PaintEventArgs)

    End Sub



    Private Sub mobileamount_label_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub mobile_panel_Paint(sender As Object, e As PaintEventArgs) Handles mobile_panel.Paint

    End Sub


    Private Sub planname_label_Click(sender As Object, e As EventArgs) Handles planname_label.Click

    End Sub


    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click

    End Sub

    Private Sub Panel18_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Panel24_Paint(sender As Object, e As PaintEventArgs) Handles Panel24.Paint

    End Sub

    Private Sub Panel7_Paint(sender As Object, e As PaintEventArgs) Handles Panel7.Paint

    End Sub

    Private Sub tv_panel_Paint(sender As Object, e As PaintEventArgs) Handles tv_panel.Paint

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

        If e.ColumnIndex = 4 Then

            Dim planname As String = DataGridView1.Rows(e.RowIndex).Cells(2).Value
            Dim cost As Integer = CInt(DataGridView1.Rows(e.RowIndex).Cells(1).Value)
            Dim nmobileplannmber = CInt(DataGridView1.Rows(e.RowIndex).Cells(0).Value)
            If Tbalance >= cost Then
                Dim thisday As Date = Today
                Dim path As String = My.Application.Info.DirectoryPath
                path = path + "\GeneralUserDB.accdb"
                Dim dbsource As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path
                Dim conn = New OleDbConnection(dbsource)


                If mobileplannumber <> 0 Then
                    Dim result As Integer = MessageBox.Show("Are you sure you want to opt for Plan: " & planname & "? You still have " & daysleftformobileplan & " days left for your previous plan to expire", "", MessageBoxButtons.YesNoCancel)
                    If result = DialogResult.Yes Then

                        Try
                            conn.Open()
                            Dim querry As String = "Update [GeneralUser] set [TBalance]=" & Tbalance - cost & ",[MobilePlan]=" & nmobileplannmber & ",[StartDateofMobilePlan]='" & thisday.ToString & "' Where [PhoneNo]='" & UserNumber & "'"

                            Dim cmd As New OleDbCommand(querry, conn)
                            cmd.ExecuteNonQuery()
                            cmd.Dispose()
                            conn.Close()
                            MsgBox("Plan Succesfully changed")
                            Tbalance = Tbalance - cost
                            mobileplanstartdate = thisday
                            mobileplannumber = e.RowIndex + 1
                            Reset_details()
                        Catch ex As Exception
                            MsgBox(ex.ToString)
                        End Try




                    End If
                Else
                    Dim result As Integer = MessageBox.Show("Are you sure you want to opt for Plan: " & planname & "?", "", MessageBoxButtons.YesNoCancel)
                    If result = DialogResult.Yes Then

                        conn.Open()
                        Try
                            Dim querry As String = "Update [GeneralUser] set [TBalance]=" & Tbalance - cost & ",[MobilePlan]=" & nmobileplannmber & ",[StartDateofMobilePlan]='" & thisday.ToString & "' Where [PhoneNo]='" & UserNumber & "'"
                            Dim cmd As New OleDbCommand(querry, conn)
                            cmd.ExecuteNonQuery()
                            cmd.Dispose()
                            MsgBox("plan successfully applied")
                            Tbalance = Tbalance - cost
                            mobileplanstartdate = thisday
                            mobileplannumber = e.RowIndex + 1
                            Reset_details()
                        Catch ex As Exception
                            MsgBox("Attempt Unsucessful")
                        End Try

                    End If
                End If



            Else
                MsgBox("Please recharge Rs. " & cost - Tbalance & " into your account!")


            End If

        Else
            MsgBox(e.ColumnIndex)
        End If
    End Sub

    Private Sub recharge_button_Click(sender As Object, e As EventArgs) Handles recharge_button.Click
        If IsNumeric(walletrecharge_textbox.Text) Then
            If walletrecharge_textbox.Text.Length < 5 Then

                Dim path As String = My.Application.Info.DirectoryPath
                path = path + "\UserRequestDB.accdb"
                Dim dbsource As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path
                Dim conn = New OleDbConnection(dbsource)

                Dim insert As String = "Insert into UserRequestDB([PhoneNumber],[AmountRequested],[DateofRequest]) Values('" & UserNumber.ToString & "'," & walletrecharge_textbox.Text & ",'" & Today.ToString & "')"
                Dim cmd As New OleDbCommand(insert, conn)
                Try
                    conn.Open()
                    cmd.ExecuteNonQuery()

                    conn.Close()
                    MsgBox("A request has been sent to the admin for your recharge request")
                    walletrecharge_textbox.Text = ""
                Catch ex As Exception
                    MsgBox("Attempt Unsuccesful")
                End Try

                conn.Close()
            Else
                MsgBox("Recharge Limit Exceeded")
            End If
        Else
            MsgBox("Please Enter a Numeric Value")
            walletrecharge_textbox.Text = ""

        End If



    End Sub

    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick
        If e.ColumnIndex = 6 Then

            Dim planname As String = DataGridView2.Rows(e.RowIndex).Cells(2).Value
            Dim cost As Integer = CInt(DataGridView2.Rows(e.RowIndex).Cells(1).Value)
            If Tbalance >= cost Then
                Dim thisday As Date = Today
                Dim path As String = My.Application.Info.DirectoryPath
                path = path + "\GeneralUserDB.accdb"
                Dim dbsource As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path
                Dim conn = New OleDbConnection(dbsource)


                If internetplannumber <> 0 Then
                    Dim result As Integer = MessageBox.Show("Are you sure you want to opt for Plan: " & planname & "? You still have " & daysleftforinternetplan & " days left for your previous plan to expire", "", MessageBoxButtons.YesNoCancel)
                    If result = DialogResult.Yes Then

                        Try
                            conn.Open()
                            Dim querry As String = "Update [GeneralUser] set [TBalance]=" & Tbalance - cost & ",[InternetPlan]=" & e.RowIndex + 1 & ",[StartDateofInternetPlan]='" & thisday.ToString & "' Where [PhoneNo]='" & UserNumber & "'"

                            Dim cmd As New OleDbCommand(querry, conn)
                            cmd.ExecuteNonQuery()
                            cmd.Dispose()
                            conn.Close()
                            MsgBox("Plan Succesfully changed")
                            Tbalance = Tbalance - cost
                            internetplanstartdate = thisday
                            internetplannumber = e.RowIndex + 1
                            Reset_details()
                        Catch ex As Exception
                            MsgBox(ex.ToString)
                        End Try




                    End If
                Else
                    Dim result As Integer = MessageBox.Show("Are you sure you want to opt for Plan: " & planname & "?", "", MessageBoxButtons.YesNoCancel)
                    If result = DialogResult.Yes Then

                        conn.Open()
                        Try
                            Dim querry As String = "Update [GeneralUser] set [TBalance]=" & Tbalance - cost & ",[InternetPlan]=" & e.RowIndex + 1 & ",[StartDateofInternetPlan]='" & thisday.ToString & "' Where [PhoneNo]='" & UserNumber & "'"
                            Dim cmd As New OleDbCommand(querry, conn)
                            cmd.ExecuteNonQuery()
                            cmd.Dispose()
                            MsgBox("plan successfully applied")
                            Tbalance = Tbalance - cost
                            internetplanstartdate = thisday
                            internetplannumber = e.RowIndex + 1
                            Reset_details()
                        Catch ex As Exception
                            MsgBox("Attempt Unsucessful")
                        End Try

                    End If
                End If



            Else
                MsgBox("Please recharge Rs. " & cost - Tbalance & " into your account!")

            End If


        End If
    End Sub

    Private Sub Panel16_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub DataGridView3_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView3.CellContentClick
        If e.ColumnIndex = 5 Then
            Dim planname As String = DataGridView3.Rows(e.RowIndex).Cells(2).Value
            Dim cost As Integer = CInt(DataGridView3.Rows(e.RowIndex).Cells(1).Value)
            Dim nplannumber As Integer = CInt(DataGridView3.Rows(e.RowIndex).Cells(0).Value)
            If Tbalance >= cost Then
                Dim thisday As Date = Today

                Dim path As String = My.Application.Info.DirectoryPath
                path = path + "\GeneralUserDB.accdb"
                Dim dbsource As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path
                Dim conn = New OleDbConnection(dbsource)


                If tvplannumber <> 0 Then
                    Dim result As Integer = MessageBox.Show("Are you sure you want to opt for Plan: " & planname & "? You still have " & daysleftfortvplan & " days left for your previous plan to expire", "", MessageBoxButtons.YesNoCancel)
                    If result = DialogResult.Yes Then

                        Try
                            conn.Open()
                            Dim querry As String = "Update [GeneralUser] set [TBalance]=" & Tbalance - cost & ",[TVPlan]=" & nplannumber & ",[StartDateofTvPlan]='" & thisday.ToString & "' Where [PhoneNo]='" & UserNumber & "'"
                            ' MsgBox(querry)
                            Dim cmd As New OleDbCommand(querry, conn)
                            cmd.ExecuteNonQuery()
                            cmd.Dispose()
                            conn.Close()
                            MsgBox("Plan Succesfully changed")
                            Tbalance = Tbalance - cost
                            tvplanstartdate = thisday
                            tvplannumber = e.RowIndex + 1
                            Reset_details()
                        Catch ex As Exception
                            MsgBox(ex.ToString)
                        End Try




                    End If
                Else
                    Dim result As Integer = MessageBox.Show("Are you sure you want to opt for Plan: " & planname & "?", "", MessageBoxButtons.YesNoCancel)
                    If result = DialogResult.Yes Then

                        conn.Open()
                        Try
                            Dim querry As String = "Update [GeneralUser] set [TBalance]=" & Tbalance - cost & ",[TVPlan]=" & nplannumber & ",[StartDateofTvPlan]='" & thisday.ToString & "' Where [PhoneNo]='" & UserNumber & "'"
                            Dim cmd As New OleDbCommand(querry, conn)
                            cmd.ExecuteNonQuery()
                            cmd.Dispose()
                            MsgBox("plan successfully applied")
                            Tbalance = Tbalance - cost
                            tvplanstartdate = thisday
                            tvplannumber = e.RowIndex + 1
                            Reset_details()
                        Catch ex As Exception
                            MsgBox("Attempt Unsucessful")
                        End Try

                    End If
                End If


            Else
                MsgBox("Please recharge Rs. " & cost - Tbalance & " into your account!")

            End If

        ElseIf e.ColumnIndex = 4 Then



        End If
    End Sub

    Private Sub Label41_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub walletrecharge_textbox_TextChanged(sender As Object, e As EventArgs) Handles walletrecharge_textbox.TextChanged

    End Sub

    Private Sub dbinternet_cpb_Click(sender As Object, e As EventArgs) Handles dbinternet_cpb.Click

    End Sub

    Private Sub dashboard_panel_Paint(sender As Object, e As PaintEventArgs) Handles dashboard_panel.Paint

    End Sub


    Private Sub Panel5_Paint(sender As Object, e As PaintEventArgs) Handles Panel5.Paint

    End Sub

    Private Sub Panel12_Paint(sender As Object, e As PaintEventArgs) Handles Panel12.Paint

    End Sub

    Private Sub Panel26_Paint(sender As Object, e As PaintEventArgs) Handles Panel26.Paint

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Me.Close()

    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Form4.Show()
        Form4.BackColor = Color.FromArgb(247, 204, 76)

        Dim path As String = My.Application.Info.DirectoryPath
        path = path + "\UserRequestDB.accdb"
        Dim dbsource As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path
        Dim conn = New OleDbConnection(dbsource)
        Dim adapter As New OleDbDataAdapter()
        Dim reader As OleDbDataReader
        Dim tuser As String = UserNumber
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
End Class