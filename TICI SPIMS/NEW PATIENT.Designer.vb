<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NEW_PATIENT
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NEW_PATIENT))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtCaseNo = New System.Windows.Forms.TextBox()
        Me.txtPtype = New System.Windows.Forms.ComboBox()
        Me.txtSex = New System.Windows.Forms.ComboBox()
        Me.txtCstat = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtContactNo = New System.Windows.Forms.TextBox()
        Me.txtMname = New System.Windows.Forms.TextBox()
        Me.txtDob = New System.Windows.Forms.TextBox()
        Me.txtFname = New System.Windows.Forms.TextBox()
        Me.txtLname = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.chkClaustro = New System.Windows.Forms.CheckBox()
        Me.chkImplant = New System.Windows.Forms.CheckBox()
        Me.txtOcc = New System.Windows.Forms.TextBox()
        Me.txtProv = New System.Windows.Forms.TextBox()
        Me.txtAll = New System.Windows.Forms.TextBox()
        Me.txtCity = New System.Windows.Forms.TextBox()
        Me.txtBrgy = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtHmo = New System.Windows.Forms.TextBox()
        Me.txtEmNo = New System.Windows.Forms.TextBox()
        Me.txtEmName = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btnADD = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.txtCaseNo)
        Me.GroupBox1.Controls.Add(Me.txtPtype)
        Me.GroupBox1.Controls.Add(Me.txtSex)
        Me.GroupBox1.Controls.Add(Me.txtCstat)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtContactNo)
        Me.GroupBox1.Controls.Add(Me.txtMname)
        Me.GroupBox1.Controls.Add(Me.txtDob)
        Me.GroupBox1.Controls.Add(Me.txtFname)
        Me.GroupBox1.Controls.Add(Me.txtLname)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox1.Location = New System.Drawing.Point(12, 47)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(672, 216)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "PATIENT PRIMARY INFORMATION"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(491, 181)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(50, 13)
        Me.Label16.TabIndex = 10
        Me.Label16.Text = "CASE NO"
        '
        'txtCaseNo
        '
        Me.txtCaseNo.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCaseNo.Location = New System.Drawing.Point(426, 149)
        Me.txtCaseNo.Name = "txtCaseNo"
        Me.txtCaseNo.Size = New System.Drawing.Size(197, 29)
        Me.txtCaseNo.TabIndex = 9
        Me.txtCaseNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPtype
        '
        Me.txtPtype.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.txtPtype.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPtype.FormattingEnabled = True
        Me.txtPtype.Items.AddRange(New Object() {"IN-PATIENT", "OUT-PATIENT"})
        Me.txtPtype.Location = New System.Drawing.Point(223, 149)
        Me.txtPtype.Name = "txtPtype"
        Me.txtPtype.Size = New System.Drawing.Size(197, 29)
        Me.txtPtype.TabIndex = 8
        Me.txtPtype.Text = "INP/OPD"
        '
        'txtSex
        '
        Me.txtSex.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.txtSex.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSex.FormattingEnabled = True
        Me.txtSex.Items.AddRange(New Object() {"MALE", "FEMALE"})
        Me.txtSex.Location = New System.Drawing.Point(419, 89)
        Me.txtSex.Name = "txtSex"
        Me.txtSex.Size = New System.Drawing.Size(197, 29)
        Me.txtSex.TabIndex = 6
        Me.txtSex.Text = "GENDER"
        '
        'txtCstat
        '
        Me.txtCstat.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCstat.FormattingEnabled = True
        Me.txtCstat.Items.AddRange(New Object() {"SINGLE", "MARRIED", "CHILD", "WIDOW/ER", "OTHERS"})
        Me.txtCstat.Location = New System.Drawing.Point(20, 149)
        Me.txtCstat.Name = "txtCstat"
        Me.txtCstat.Size = New System.Drawing.Size(197, 29)
        Me.txtCstat.TabIndex = 7
        Me.txtCstat.Text = "CIVIL STATUS"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(223, 118)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(101, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "CONTACT NUMBER"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(20, 118)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "DATE OF BIRTH"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(419, 59)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "MIDDLE NAME"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(220, 59)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "FIRST NAME"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(20, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "LAST NAME"
        '
        'txtContactNo
        '
        Me.txtContactNo.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContactNo.Location = New System.Drawing.Point(223, 89)
        Me.txtContactNo.Name = "txtContactNo"
        Me.txtContactNo.Size = New System.Drawing.Size(190, 29)
        Me.txtContactNo.TabIndex = 5
        Me.txtContactNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtMname
        '
        Me.txtMname.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMname.Location = New System.Drawing.Point(419, 29)
        Me.txtMname.Name = "txtMname"
        Me.txtMname.Size = New System.Drawing.Size(197, 29)
        Me.txtMname.TabIndex = 3
        Me.txtMname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtDob
        '
        Me.txtDob.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDob.Location = New System.Drawing.Point(20, 89)
        Me.txtDob.Name = "txtDob"
        Me.txtDob.Size = New System.Drawing.Size(197, 29)
        Me.txtDob.TabIndex = 4
        Me.txtDob.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtFname
        '
        Me.txtFname.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFname.Location = New System.Drawing.Point(223, 29)
        Me.txtFname.Name = "txtFname"
        Me.txtFname.Size = New System.Drawing.Size(190, 29)
        Me.txtFname.TabIndex = 2
        Me.txtFname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtLname
        '
        Me.txtLname.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLname.Location = New System.Drawing.Point(20, 29)
        Me.txtLname.Name = "txtLname"
        Me.txtLname.Size = New System.Drawing.Size(197, 29)
        Me.txtLname.TabIndex = 1
        Me.txtLname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.chkClaustro)
        Me.GroupBox2.Controls.Add(Me.chkImplant)
        Me.GroupBox2.Controls.Add(Me.txtOcc)
        Me.GroupBox2.Controls.Add(Me.txtProv)
        Me.GroupBox2.Controls.Add(Me.txtAll)
        Me.GroupBox2.Controls.Add(Me.txtCity)
        Me.GroupBox2.Controls.Add(Me.txtBrgy)
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox2.Location = New System.Drawing.Point(12, 269)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(370, 289)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "PATIENT SECONDARY INFORMATION"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(26, 178)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(56, 13)
        Me.Label11.TabIndex = 8
        Me.Label11.Text = "ALLERGIES"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(11, 143)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(75, 13)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "OCCUPATION"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(27, 98)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(34, 13)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "PROV"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(27, 63)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(29, 13)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "CITY"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(27, 28)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(33, 13)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "BRGY"
        '
        'chkClaustro
        '
        Me.chkClaustro.AutoSize = True
        Me.chkClaustro.Location = New System.Drawing.Point(91, 241)
        Me.chkClaustro.Name = "chkClaustro"
        Me.chkClaustro.Size = New System.Drawing.Size(124, 17)
        Me.chkClaustro.TabIndex = 16
        Me.chkClaustro.Text = "CLAUSTROPHOBIC"
        Me.chkClaustro.UseVisualStyleBackColor = True
        '
        'chkImplant
        '
        Me.chkImplant.AutoSize = True
        Me.chkImplant.Location = New System.Drawing.Point(91, 212)
        Me.chkImplant.Name = "chkImplant"
        Me.chkImplant.Size = New System.Drawing.Size(135, 17)
        Me.chkImplant.TabIndex = 15
        Me.chkImplant.Text = "METALLIC IMPLANTS"
        Me.chkImplant.UseVisualStyleBackColor = True
        '
        'txtOcc
        '
        Me.txtOcc.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOcc.Location = New System.Drawing.Point(91, 134)
        Me.txtOcc.Name = "txtOcc"
        Me.txtOcc.Size = New System.Drawing.Size(197, 29)
        Me.txtOcc.TabIndex = 13
        Me.txtOcc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtProv
        '
        Me.txtProv.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProv.Location = New System.Drawing.Point(63, 89)
        Me.txtProv.Name = "txtProv"
        Me.txtProv.Size = New System.Drawing.Size(197, 29)
        Me.txtProv.TabIndex = 12
        Me.txtProv.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtAll
        '
        Me.txtAll.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAll.Location = New System.Drawing.Point(91, 169)
        Me.txtAll.Name = "txtAll"
        Me.txtAll.Size = New System.Drawing.Size(197, 29)
        Me.txtAll.TabIndex = 14
        Me.txtAll.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCity
        '
        Me.txtCity.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCity.Location = New System.Drawing.Point(63, 54)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(197, 29)
        Me.txtCity.TabIndex = 11
        Me.txtCity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtBrgy
        '
        Me.txtBrgy.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBrgy.Location = New System.Drawing.Point(63, 19)
        Me.txtBrgy.Name = "txtBrgy"
        Me.txtBrgy.Size = New System.Drawing.Size(197, 29)
        Me.txtBrgy.TabIndex = 10
        Me.txtBrgy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtHmo)
        Me.GroupBox3.Controls.Add(Me.txtEmNo)
        Me.GroupBox3.Controls.Add(Me.txtEmName)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox3.Location = New System.Drawing.Point(388, 269)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(296, 181)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "PATIENT SECONDARY INFORMATION"
        '
        'txtHmo
        '
        Me.txtHmo.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHmo.Location = New System.Drawing.Point(43, 128)
        Me.txtHmo.Name = "txtHmo"
        Me.txtHmo.Size = New System.Drawing.Size(197, 29)
        Me.txtHmo.TabIndex = 19
        Me.txtHmo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEmNo
        '
        Me.txtEmNo.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmNo.Location = New System.Drawing.Point(43, 82)
        Me.txtEmNo.Name = "txtEmNo"
        Me.txtEmNo.Size = New System.Drawing.Size(197, 29)
        Me.txtEmNo.TabIndex = 18
        Me.txtEmNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEmName
        '
        Me.txtEmName.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmName.Location = New System.Drawing.Point(43, 35)
        Me.txtEmName.Name = "txtEmName"
        Me.txtEmName.Size = New System.Drawing.Size(197, 29)
        Me.txtEmName.TabIndex = 17
        Me.txtEmName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(6, 66)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(163, 13)
        Me.Label15.TabIndex = 8
        Me.Label15.Text = "EMERGENCY CONTACT NUMBER"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(12, 112)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(32, 13)
        Me.Label13.TabIndex = 8
        Me.Label13.Text = "HMO"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(6, 19)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(159, 13)
        Me.Label12.TabIndex = 8
        Me.Label12.Text = "EMERGENCY CONTACT PERSON"
        '
        'btnADD
        '
        Me.btnADD.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.btnADD.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnADD.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnADD.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnADD.Location = New System.Drawing.Point(527, 473)
        Me.btnADD.Name = "btnADD"
        Me.btnADD.Size = New System.Drawing.Size(157, 66)
        Me.btnADD.TabIndex = 21
        Me.btnADD.Text = "ADD PATIENT"
        Me.btnADD.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(700, 43)
        Me.Panel1.TabIndex = 2
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(-3, 1)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(143, 41)
        Me.Button2.TabIndex = 31
        Me.Button2.Text = "BACK"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(489, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(195, 30)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "New Patient Record"
        '
        'btnReset
        '
        Me.btnReset.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReset.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnReset.Location = New System.Drawing.Point(390, 473)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(129, 66)
        Me.btnReset.TabIndex = 30
        Me.btnReset.Text = "RESET"
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'NEW_PATIENT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(700, 570)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnADD)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.Name = "NEW_PATIENT"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "NEW_PATIENT"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnADD As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents btnReset As Button
    Friend WithEvents txtMname As TextBox
    Friend WithEvents txtFname As TextBox
    Friend WithEvents txtLname As TextBox
    Friend WithEvents txtContactNo As TextBox
    Friend WithEvents txtDob As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents chkClaustro As CheckBox
    Friend WithEvents chkImplant As CheckBox
    Friend WithEvents txtOcc As TextBox
    Friend WithEvents txtProv As TextBox
    Friend WithEvents txtAll As TextBox
    Friend WithEvents txtCity As TextBox
    Friend WithEvents txtBrgy As TextBox
    Friend WithEvents txtPtype As ComboBox
    Friend WithEvents txtSex As ComboBox
    Friend WithEvents txtCstat As ComboBox
    Friend WithEvents txtHmo As TextBox
    Friend WithEvents txtEmNo As TextBox
    Friend WithEvents txtEmName As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents txtCaseNo As TextBox
End Class
