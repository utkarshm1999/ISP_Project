Imports System.Data.OleDb
Imports System.Data
Imports System.Text.RegularExpressions

Public Class Form1

    Dim Formh As New Form2

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'GeneralUserDBDataSet.GeneralUser' table. You can move, or remove it, as needed.
        ' Me.GeneralUserTableAdapter.Fill(Me.GeneralUserDBDataSet.GeneralUser)
        'Me.WindowState = FormWindowState.Maximized
        Panel2.BackColor = Color.FromArgb(200, Color.WhiteSmoke)

    End Sub

    ' MAKES FORM RESPONSIVE BY CHANGING LOCATIONS OF OBJECTS ON RESIZE
    Private Sub Main_Form_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        'login_panel.Location = New Point(0, 0)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim uname As String = ""
        Dim pword As String = ""
        Dim username As String = ""
        Dim pass As String = ""
        Dim counter As Integer = 0
        Dim Pnum As String = TextBox1.Text
        If Regex.IsMatch(Pnum, "^[0-9 ]+$") Then
            counter = 0
        Else
            counter = 1
        End If

        If Pnum = "" Or Pnum.Length <> 10 Or TextBox2.Text = "" Or counter = 1 Then
            MsgBox("Invalid Login Details")
            counter = 1
        ElseIf counter <> 1 Then
            uname = TextBox1.Text
            pword = TextBox2.Text
            Dim querry As String = "Select Password From GeneralUser where PhoneNo= '" & uname & "';"
            'Dim dbsource As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\sem4\Software_Lab\assignment2\GeneralUserDB.accdb"
            Dim path As String = My.Application.Info.DirectoryPath
            path = path + "\GeneralUserDB.accdb"
            Dim dbsource As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path
            Dim conn = New OleDbConnection(dbsource)
            Dim cmd As New OleDbCommand(querry, conn)
            conn.Open()
            Try
                pass = cmd.ExecuteScalar().ToString
            Catch ex As Exception
                MsgBox("Username does not exit")
            End Try
            If (pword = pass) Then
                ' MsgBox("Login success")
                Dim obj As New Form2
                obj.UserNumber = uname
                obj.Show()
                If obj.Visible Then
                    Me.Hide()
                End If
            Else
                MsgBox("login Failed")
                TextBox1.Clear()
                TextBox2.Clear()
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles register_button.Click
        ' InitializeComponent()

        Dim counter As Integer = 0
        Dim Check As Integer = 0
        Dim Pnum As String = PhoneNoTextBox.Text
        If Regex.IsMatch(Pnum, "^[0-9 ]+$") Then
            ' MsgBox("Only Numbers in Phone Number")
            counter = 0
        Else
            counter = 1
        End If
        If Pnum = "" Or Pnum.Length <> 10 Then
            MsgBox("Please Enter A Phone Number of 10 digits")
            counter = 1
            Check = 1
        ElseIf counter <> 1 Then
            Dim querry As String = "Select PassWord From GeneralUser where PhoneNo= '" & Pnum & "';"
            'Dim dbsource As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\sem4\Software_Lab\assignment2\GeneralUserDB.accdb"
            Dim path As String = My.Application.Info.DirectoryPath

            path = path + "\GeneralUserDB.accdb"
            MsgBox(path)
            Dim dbsource As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path
            Dim conn = New OleDbConnection(dbsource)
            Dim cmd As New OleDbCommand(querry, conn)
            conn.Open()
            Dim pass As String = ""
            Try
                pass = cmd.ExecuteScalar().ToString
                status_label.Text = "Sorry Taken"
                counter = 1
            Catch ex As Exception
                status_label.Text = "Available"
                counter = 0
            End Try
        End If

        If counter <> 1 Then
            status_label.Text = ""
            If FirstNameTextBox.Text = "" Or SecondNameTextBox.Text = "" Or UserNameTextBox.Text = "" Or PasswordTextBox.Text = "" Or cpasswordtxtbox.Text = "" Or AadharTextBox.Text = "" Then
                MsgBox("Please Enter All Your Detail Correctly")
            ElseIf PasswordTextBox.Text <> cpasswordtxtbox.Text Then
                MsgBox("Please Enter Both Password Same and Correctly")
            Else
                If AadharTextBox.Text.Length <> 12 Then
                    MsgBox("Enter Your Aadhar No Correctly")
                Else
                    Try
                        Dim path As String = My.Application.Info.DirectoryPath
                        path = path + "\GeneralUserDB.accdb"
                        Dim dbsource As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path
                        'Dim dbsource As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\sem4\Software_Lab\assignment2\GeneralUserDB.accdb"
                        Dim conn = New OleDbConnection(dbsource)
                        Dim insert As String = "Insert into GeneralUser([PhoneNo],[FirstName],[SecondName],[UserName],[Password],[Aadhar]) Values('" & PhoneNoTextBox.Text & "','" & FirstNameTextBox.Text & "','" & SecondNameTextBox.Text & "','" & UserNameTextBox.Text & "','" & PasswordTextBox.Text & "','" & AadharTextBox.Text & "');"
                        Dim cmd As New OleDbCommand(insert, conn)
                        conn.Open()
                        cmd.ExecuteNonQuery()
                        MsgBox("create success")
                        Me.Close()
                    Catch ex As Exception
                        MsgBox("Error please try again")
                    End Try
                End If
            End If
        Else
            status_label.Text = ""
            If Check <> 1 Then
                MsgBox("That Number Is Not Available")
            End If
        End If
    End Sub

    Private Sub GeneralUserBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.GeneralUserBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.GeneralUserDBDataSet)

    End Sub

    Private Sub TextBox1_Click(sender As Object, e As EventArgs) Handles TextBox1.Click
        TextBox1.Text = ""
    End Sub
    Private Sub TextBox2_Click(sender As Object, e As EventArgs) Handles TextBox2.Click
        TextBox2.Text = ""
        TextBox2.PasswordChar = "*"
    End Sub

End Class