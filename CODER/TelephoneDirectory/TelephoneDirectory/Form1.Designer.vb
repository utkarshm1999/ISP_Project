<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Dim AadharLabel As System.Windows.Forms.Label
        Dim PasswordLabel As System.Windows.Forms.Label
        Dim UserNameLabel As System.Windows.Forms.Label
        Dim SecondNameLabel As System.Windows.Forms.Label
        Dim FirstNameLabel As System.Windows.Forms.Label
        Dim PhoneNoLabel As System.Windows.Forms.Label
        Me.GeneralUserBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GeneralUserDBDataSet = New TelephoneDirectory.GeneralUserDBDataSet()
        Me.GeneralUserTableAdapter = New TelephoneDirectory.GeneralUserDBDataSetTableAdapters.GeneralUserTableAdapter()
        Me.TableAdapterManager = New TelephoneDirectory.GeneralUserDBDataSetTableAdapters.TableAdapterManager()
        Me.login_panel = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.CustomRoundedPanel5 = New TelephoneDirectory.CustomRoundedPanel()
        Me.AadharTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CustomRoundedPanel6 = New TelephoneDirectory.CustomRoundedPanel()
        Me.cpasswordtxtbox = New System.Windows.Forms.TextBox()
        Me.CustomRoundedPanel7 = New TelephoneDirectory.CustomRoundedPanel()
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.CustomRoundedPanel2 = New TelephoneDirectory.CustomRoundedPanel()
        Me.FirstNameTextBox = New System.Windows.Forms.TextBox()
        Me.CustomRoundedPanel3 = New TelephoneDirectory.CustomRoundedPanel()
        Me.UserNameTextBox = New System.Windows.Forms.TextBox()
        Me.CustomRoundedPanel4 = New TelephoneDirectory.CustomRoundedPanel()
        Me.SecondNameTextBox = New System.Windows.Forms.TextBox()
        Me.CustomRoundedPanel1 = New TelephoneDirectory.CustomRoundedPanel()
        Me.PhoneNoTextBox = New System.Windows.Forms.TextBox()
        Me.status_label = New System.Windows.Forms.Label()
        Me.register_button = New System.Windows.Forms.Button()
        AadharLabel = New System.Windows.Forms.Label()
        PasswordLabel = New System.Windows.Forms.Label()
        UserNameLabel = New System.Windows.Forms.Label()
        SecondNameLabel = New System.Windows.Forms.Label()
        FirstNameLabel = New System.Windows.Forms.Label()
        PhoneNoLabel = New System.Windows.Forms.Label()
        CType(Me.GeneralUserBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GeneralUserDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.login_panel.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.CustomRoundedPanel5.SuspendLayout()
        Me.CustomRoundedPanel6.SuspendLayout()
        Me.CustomRoundedPanel7.SuspendLayout()
        Me.CustomRoundedPanel2.SuspendLayout()
        Me.CustomRoundedPanel3.SuspendLayout()
        Me.CustomRoundedPanel4.SuspendLayout()
        Me.CustomRoundedPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GeneralUserBindingSource
        '
        Me.GeneralUserBindingSource.DataMember = "GeneralUser"
        Me.GeneralUserBindingSource.DataSource = Me.GeneralUserDBDataSet
        '
        'GeneralUserDBDataSet
        '
        Me.GeneralUserDBDataSet.DataSetName = "GeneralUserDBDataSet"
        Me.GeneralUserDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GeneralUserTableAdapter
        '
        Me.GeneralUserTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.GeneralUserTableAdapter = Me.GeneralUserTableAdapter
        Me.TableAdapterManager.UpdateOrder = TelephoneDirectory.GeneralUserDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'login_panel
        '
        Me.login_panel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.login_panel.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.login_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.login_panel.Controls.Add(Me.Panel4)
        Me.login_panel.Controls.Add(Me.Panel3)
        Me.login_panel.Controls.Add(Me.Button1)
        Me.login_panel.Location = New System.Drawing.Point(0, 0)
        Me.login_panel.Margin = New System.Windows.Forms.Padding(4)
        Me.login_panel.Name = "login_panel"
        Me.login_panel.Size = New System.Drawing.Size(1341, 110)
        Me.login_panel.TabIndex = 2
        '
        'Panel4
        '
        Me.Panel4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel4.BackColor = System.Drawing.Color.DimGray
        Me.Panel4.Controls.Add(Me.PictureBox2)
        Me.Panel4.Controls.Add(Me.TextBox2)
        Me.Panel4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel4.Location = New System.Drawing.Point(649, 30)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(259, 49)
        Me.Panel4.TabIndex = 2
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox2.Location = New System.Drawing.Point(9, 8)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(33, 33)
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox2.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.ForeColor = System.Drawing.Color.White
        Me.TextBox2.Location = New System.Drawing.Point(75, 14)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(180, 21)
        Me.TextBox2.TabIndex = 2
        Me.TextBox2.TabStop = False
        Me.TextBox2.Text = "Password"
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.BackColor = System.Drawing.Color.DimGray
        Me.Panel3.Controls.Add(Me.PictureBox1)
        Me.Panel3.Controls.Add(Me.TextBox1)
        Me.Panel3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel3.Location = New System.Drawing.Point(373, 30)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(259, 49)
        Me.Panel3.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(9, 8)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(33, 33)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.White
        Me.TextBox1.Location = New System.Drawing.Point(71, 14)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(180, 21)
        Me.TextBox1.TabIndex = 0
        Me.TextBox1.TabStop = False
        Me.TextBox1.Text = "Phone No."
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.Color.DarkTurquoise
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.Control
        Me.Button1.Location = New System.Drawing.Point(926, 30)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(138, 49)
        Me.Button1.TabIndex = 2
        Me.Button1.TabStop = False
        Me.Button1.Text = "Login"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.SpringGreen
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(0, 110)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1378, 808)
        Me.Panel1.TabIndex = 3
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(AadharLabel)
        Me.Panel2.Controls.Add(Me.CustomRoundedPanel5)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.CustomRoundedPanel6)
        Me.Panel2.Controls.Add(PasswordLabel)
        Me.Panel2.Controls.Add(UserNameLabel)
        Me.Panel2.Controls.Add(Me.CustomRoundedPanel7)
        Me.Panel2.Controls.Add(SecondNameLabel)
        Me.Panel2.Controls.Add(FirstNameLabel)
        Me.Panel2.Controls.Add(Me.CustomRoundedPanel2)
        Me.Panel2.Controls.Add(Me.CustomRoundedPanel3)
        Me.Panel2.Controls.Add(PhoneNoLabel)
        Me.Panel2.Controls.Add(Me.CustomRoundedPanel4)
        Me.Panel2.Controls.Add(Me.CustomRoundedPanel1)
        Me.Panel2.Controls.Add(Me.status_label)
        Me.Panel2.Controls.Add(Me.register_button)
        Me.Panel2.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.Location = New System.Drawing.Point(399, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(637, 797)
        Me.Panel2.TabIndex = 0
        '
        'AadharLabel
        '
        AadharLabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        AadharLabel.AutoSize = True
        AadharLabel.BackColor = System.Drawing.Color.Transparent
        AadharLabel.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AadharLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        AadharLabel.Location = New System.Drawing.Point(147, 525)
        AadharLabel.Name = "AadharLabel"
        AadharLabel.Size = New System.Drawing.Size(89, 20)
        AadharLabel.TabIndex = 13
        AadharLabel.Text = "Aadhar No"
        '
        'CustomRoundedPanel5
        '
        Me.CustomRoundedPanel5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CustomRoundedPanel5.BackColor = System.Drawing.Color.Gainsboro
        Me.CustomRoundedPanel5.Controls.Add(Me.AadharTextBox)
        Me.CustomRoundedPanel5.Location = New System.Drawing.Point(137, 537)
        Me.CustomRoundedPanel5.Name = "CustomRoundedPanel5"
        Me.CustomRoundedPanel5.Size = New System.Drawing.Size(359, 48)
        Me.CustomRoundedPanel5.TabIndex = 9
        '
        'AadharTextBox
        '
        Me.AadharTextBox.BackColor = System.Drawing.Color.Gainsboro
        Me.AadharTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.AadharTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GeneralUserBindingSource, "Aadhar", True))
        Me.AadharTextBox.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AadharTextBox.Location = New System.Drawing.Point(16, 15)
        Me.AadharTextBox.Name = "AadharTextBox"
        Me.AadharTextBox.Size = New System.Drawing.Size(330, 21)
        Me.AadharTextBox.TabIndex = 9
        Me.AadharTextBox.TabStop = False
        Me.AadharTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(154, 75)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(323, 39)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Create an account"
        '
        'Label4
        '
        Me.Label4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(147, 461)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(140, 20)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Confirm Password"
        '
        'CustomRoundedPanel6
        '
        Me.CustomRoundedPanel6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CustomRoundedPanel6.BackColor = System.Drawing.Color.Gainsboro
        Me.CustomRoundedPanel6.Controls.Add(Me.cpasswordtxtbox)
        Me.CustomRoundedPanel6.Location = New System.Drawing.Point(137, 472)
        Me.CustomRoundedPanel6.Name = "CustomRoundedPanel6"
        Me.CustomRoundedPanel6.Size = New System.Drawing.Size(359, 48)
        Me.CustomRoundedPanel6.TabIndex = 8
        '
        'cpasswordtxtbox
        '
        Me.cpasswordtxtbox.BackColor = System.Drawing.Color.Gainsboro
        Me.cpasswordtxtbox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.cpasswordtxtbox.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cpasswordtxtbox.Location = New System.Drawing.Point(16, 15)
        Me.cpasswordtxtbox.Name = "cpasswordtxtbox"
        Me.cpasswordtxtbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.cpasswordtxtbox.Size = New System.Drawing.Size(330, 21)
        Me.cpasswordtxtbox.TabIndex = 8
        Me.cpasswordtxtbox.TabStop = False
        Me.cpasswordtxtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PasswordLabel
        '
        PasswordLabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        PasswordLabel.AutoSize = True
        PasswordLabel.BackColor = System.Drawing.Color.Transparent
        PasswordLabel.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PasswordLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        PasswordLabel.Location = New System.Drawing.Point(147, 395)
        PasswordLabel.Name = "PasswordLabel"
        PasswordLabel.Size = New System.Drawing.Size(79, 20)
        PasswordLabel.TabIndex = 12
        PasswordLabel.Text = "Password"
        '
        'UserNameLabel
        '
        UserNameLabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        UserNameLabel.AutoSize = True
        UserNameLabel.BackColor = System.Drawing.Color.Transparent
        UserNameLabel.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        UserNameLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        UserNameLabel.Location = New System.Drawing.Point(147, 330)
        UserNameLabel.Name = "UserNameLabel"
        UserNameLabel.Size = New System.Drawing.Size(89, 20)
        UserNameLabel.TabIndex = 11
        UserNameLabel.Text = "User Name"
        '
        'CustomRoundedPanel7
        '
        Me.CustomRoundedPanel7.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CustomRoundedPanel7.BackColor = System.Drawing.Color.Gainsboro
        Me.CustomRoundedPanel7.Controls.Add(Me.PasswordTextBox)
        Me.CustomRoundedPanel7.Location = New System.Drawing.Point(137, 406)
        Me.CustomRoundedPanel7.Name = "CustomRoundedPanel7"
        Me.CustomRoundedPanel7.Size = New System.Drawing.Size(359, 48)
        Me.CustomRoundedPanel7.TabIndex = 7
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.BackColor = System.Drawing.Color.Gainsboro
        Me.PasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.PasswordTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GeneralUserBindingSource, "Password", True))
        Me.PasswordTextBox.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PasswordTextBox.Location = New System.Drawing.Point(17, 14)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PasswordTextBox.Size = New System.Drawing.Size(330, 21)
        Me.PasswordTextBox.TabIndex = 7
        Me.PasswordTextBox.TabStop = False
        Me.PasswordTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'SecondNameLabel
        '
        SecondNameLabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        SecondNameLabel.AutoSize = True
        SecondNameLabel.BackColor = System.Drawing.Color.Transparent
        SecondNameLabel.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SecondNameLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        SecondNameLabel.Location = New System.Drawing.Point(147, 266)
        SecondNameLabel.Name = "SecondNameLabel"
        SecondNameLabel.Size = New System.Drawing.Size(113, 20)
        SecondNameLabel.TabIndex = 10
        SecondNameLabel.Text = "Second Name"
        '
        'FirstNameLabel
        '
        FirstNameLabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        FirstNameLabel.AutoSize = True
        FirstNameLabel.BackColor = System.Drawing.Color.Transparent
        FirstNameLabel.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        FirstNameLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        FirstNameLabel.Location = New System.Drawing.Point(147, 200)
        FirstNameLabel.Name = "FirstNameLabel"
        FirstNameLabel.Size = New System.Drawing.Size(83, 20)
        FirstNameLabel.TabIndex = 9
        FirstNameLabel.Text = "First Name"
        '
        'CustomRoundedPanel2
        '
        Me.CustomRoundedPanel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CustomRoundedPanel2.BackColor = System.Drawing.Color.Gainsboro
        Me.CustomRoundedPanel2.Controls.Add(Me.FirstNameTextBox)
        Me.CustomRoundedPanel2.Location = New System.Drawing.Point(137, 212)
        Me.CustomRoundedPanel2.Name = "CustomRoundedPanel2"
        Me.CustomRoundedPanel2.Size = New System.Drawing.Size(359, 48)
        Me.CustomRoundedPanel2.TabIndex = 4
        '
        'FirstNameTextBox
        '
        Me.FirstNameTextBox.BackColor = System.Drawing.Color.Gainsboro
        Me.FirstNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.FirstNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GeneralUserBindingSource, "FirstName", True))
        Me.FirstNameTextBox.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FirstNameTextBox.Location = New System.Drawing.Point(17, 15)
        Me.FirstNameTextBox.Name = "FirstNameTextBox"
        Me.FirstNameTextBox.Size = New System.Drawing.Size(330, 21)
        Me.FirstNameTextBox.TabIndex = 4
        Me.FirstNameTextBox.TabStop = False
        Me.FirstNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CustomRoundedPanel3
        '
        Me.CustomRoundedPanel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CustomRoundedPanel3.BackColor = System.Drawing.Color.Gainsboro
        Me.CustomRoundedPanel3.Controls.Add(Me.UserNameTextBox)
        Me.CustomRoundedPanel3.Location = New System.Drawing.Point(137, 342)
        Me.CustomRoundedPanel3.Name = "CustomRoundedPanel3"
        Me.CustomRoundedPanel3.Size = New System.Drawing.Size(359, 48)
        Me.CustomRoundedPanel3.TabIndex = 6
        '
        'UserNameTextBox
        '
        Me.UserNameTextBox.BackColor = System.Drawing.Color.Gainsboro
        Me.UserNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.UserNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GeneralUserBindingSource, "UserName", True))
        Me.UserNameTextBox.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserNameTextBox.Location = New System.Drawing.Point(17, 15)
        Me.UserNameTextBox.Name = "UserNameTextBox"
        Me.UserNameTextBox.Size = New System.Drawing.Size(330, 21)
        Me.UserNameTextBox.TabIndex = 6
        Me.UserNameTextBox.TabStop = False
        Me.UserNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PhoneNoLabel
        '
        PhoneNoLabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        PhoneNoLabel.AutoSize = True
        PhoneNoLabel.BackColor = System.Drawing.Color.Transparent
        PhoneNoLabel.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PhoneNoLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        PhoneNoLabel.Location = New System.Drawing.Point(147, 135)
        PhoneNoLabel.Name = "PhoneNoLabel"
        PhoneNoLabel.Size = New System.Drawing.Size(81, 20)
        PhoneNoLabel.TabIndex = 8
        PhoneNoLabel.Text = "Phone No"
        '
        'CustomRoundedPanel4
        '
        Me.CustomRoundedPanel4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CustomRoundedPanel4.BackColor = System.Drawing.Color.Gainsboro
        Me.CustomRoundedPanel4.Controls.Add(Me.SecondNameTextBox)
        Me.CustomRoundedPanel4.Location = New System.Drawing.Point(137, 277)
        Me.CustomRoundedPanel4.Name = "CustomRoundedPanel4"
        Me.CustomRoundedPanel4.Size = New System.Drawing.Size(359, 48)
        Me.CustomRoundedPanel4.TabIndex = 5
        '
        'SecondNameTextBox
        '
        Me.SecondNameTextBox.BackColor = System.Drawing.Color.Gainsboro
        Me.SecondNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.SecondNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GeneralUserBindingSource, "SecondName", True))
        Me.SecondNameTextBox.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SecondNameTextBox.Location = New System.Drawing.Point(17, 15)
        Me.SecondNameTextBox.Name = "SecondNameTextBox"
        Me.SecondNameTextBox.Size = New System.Drawing.Size(330, 21)
        Me.SecondNameTextBox.TabIndex = 5
        Me.SecondNameTextBox.TabStop = False
        Me.SecondNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CustomRoundedPanel1
        '
        Me.CustomRoundedPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CustomRoundedPanel1.BackColor = System.Drawing.Color.Gainsboro
        Me.CustomRoundedPanel1.Controls.Add(Me.PhoneNoTextBox)
        Me.CustomRoundedPanel1.Location = New System.Drawing.Point(137, 147)
        Me.CustomRoundedPanel1.Name = "CustomRoundedPanel1"
        Me.CustomRoundedPanel1.Size = New System.Drawing.Size(359, 48)
        Me.CustomRoundedPanel1.TabIndex = 3
        '
        'PhoneNoTextBox
        '
        Me.PhoneNoTextBox.BackColor = System.Drawing.Color.Gainsboro
        Me.PhoneNoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.PhoneNoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GeneralUserBindingSource, "PhoneNo", True))
        Me.PhoneNoTextBox.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PhoneNoTextBox.Location = New System.Drawing.Point(17, 14)
        Me.PhoneNoTextBox.Name = "PhoneNoTextBox"
        Me.PhoneNoTextBox.Size = New System.Drawing.Size(330, 21)
        Me.PhoneNoTextBox.TabIndex = 3
        Me.PhoneNoTextBox.TabStop = False
        Me.PhoneNoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'status_label
        '
        Me.status_label.AutoSize = True
        Me.status_label.Location = New System.Drawing.Point(710, 127)
        Me.status_label.Name = "status_label"
        Me.status_label.Size = New System.Drawing.Size(0, 21)
        Me.status_label.TabIndex = 17
        '
        'register_button
        '
        Me.register_button.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.register_button.BackColor = System.Drawing.Color.DarkTurquoise
        Me.register_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.register_button.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.register_button.ForeColor = System.Drawing.Color.White
        Me.register_button.Location = New System.Drawing.Point(137, 602)
        Me.register_button.Margin = New System.Windows.Forms.Padding(4)
        Me.register_button.Name = "register_button"
        Me.register_button.Size = New System.Drawing.Size(359, 48)
        Me.register_button.TabIndex = 10
        Me.register_button.TabStop = False
        Me.register_button.Text = "Sign Up"
        Me.register_button.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1342, 832)
        Me.Controls.Add(Me.login_panel)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.GeneralUserBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GeneralUserDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.login_panel.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.CustomRoundedPanel5.ResumeLayout(False)
        Me.CustomRoundedPanel5.PerformLayout()
        Me.CustomRoundedPanel6.ResumeLayout(False)
        Me.CustomRoundedPanel6.PerformLayout()
        Me.CustomRoundedPanel7.ResumeLayout(False)
        Me.CustomRoundedPanel7.PerformLayout()
        Me.CustomRoundedPanel2.ResumeLayout(False)
        Me.CustomRoundedPanel2.PerformLayout()
        Me.CustomRoundedPanel3.ResumeLayout(False)
        Me.CustomRoundedPanel3.PerformLayout()
        Me.CustomRoundedPanel4.ResumeLayout(False)
        Me.CustomRoundedPanel4.PerformLayout()
        Me.CustomRoundedPanel1.ResumeLayout(False)
        Me.CustomRoundedPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GeneralUserDBDataSet As TelephoneDirectory.GeneralUserDBDataSet
    Friend WithEvents GeneralUserBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GeneralUserTableAdapter As TelephoneDirectory.GeneralUserDBDataSetTableAdapters.GeneralUserTableAdapter
    Friend WithEvents TableAdapterManager As TelephoneDirectory.GeneralUserDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents login_panel As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents CustomRoundedPanel5 As TelephoneDirectory.CustomRoundedPanel
    Friend WithEvents AadharTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents CustomRoundedPanel6 As TelephoneDirectory.CustomRoundedPanel
    Friend WithEvents cpasswordtxtbox As System.Windows.Forms.TextBox
    Friend WithEvents CustomRoundedPanel7 As TelephoneDirectory.CustomRoundedPanel
    Friend WithEvents PasswordTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CustomRoundedPanel2 As TelephoneDirectory.CustomRoundedPanel
    Friend WithEvents FirstNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CustomRoundedPanel3 As TelephoneDirectory.CustomRoundedPanel
    Friend WithEvents UserNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CustomRoundedPanel4 As TelephoneDirectory.CustomRoundedPanel
    Friend WithEvents SecondNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CustomRoundedPanel1 As TelephoneDirectory.CustomRoundedPanel
    Friend WithEvents PhoneNoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents status_label As System.Windows.Forms.Label
    Friend WithEvents register_button As System.Windows.Forms.Button
End Class
