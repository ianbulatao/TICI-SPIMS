<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Patient_Directory
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btn_search = New System.Windows.Forms.Button()
        Me.tt_pinfo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.info = New System.Windows.Forms.DataGridView()
        Me.btn_options = New System.Windows.Forms.Button()
        Me.btn_othrinfo = New System.Windows.Forms.Button()
        Me.visitdgv = New System.Windows.Forms.DataGridView()
        Me.vstID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.vstDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DG_pinfo = New System.Windows.Forms.DataGridView()
        Me.stat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.data = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ptid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fullName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.addr = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtFilter = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.info, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.visitdgv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DG_pinfo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_search
        '
        Me.btn_search.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.btn_search.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_search.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_search.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_search.Location = New System.Drawing.Point(623, 17)
        Me.btn_search.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_search.Name = "btn_search"
        Me.btn_search.Size = New System.Drawing.Size(151, 28)
        Me.btn_search.TabIndex = 8
        Me.btn_search.Text = "SEARCH"
        Me.btn_search.UseVisualStyleBackColor = False
        '
        'tt_pinfo
        '
        Me.tt_pinfo.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tt_pinfo.Location = New System.Drawing.Point(83, 18)
        Me.tt_pinfo.Margin = New System.Windows.Forms.Padding(2)
        Me.tt_pinfo.Multiline = True
        Me.tt_pinfo.Name = "tt_pinfo"
        Me.tt_pinfo.Size = New System.Drawing.Size(276, 28)
        Me.tt_pinfo.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Franklin Gothic Medium", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(25, 23)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 18)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "NAME"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.info)
        Me.GroupBox1.Controls.Add(Me.btn_options)
        Me.GroupBox1.Controls.Add(Me.btn_othrinfo)
        Me.GroupBox1.Controls.Add(Me.visitdgv)
        Me.GroupBox1.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.GroupBox1.Location = New System.Drawing.Point(12, 229)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(768, 170)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "PATIENT VISIT RECORDS"
        '
        'info
        '
        Me.info.AllowUserToAddRows = False
        Me.info.AllowUserToDeleteRows = False
        Me.info.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.info.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.info.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.stat, Me.data})
        Me.info.Location = New System.Drawing.Point(6, 21)
        Me.info.Name = "info"
        Me.info.ReadOnly = True
        Me.info.RowHeadersVisible = False
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        Me.info.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.info.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.info.Size = New System.Drawing.Size(341, 136)
        Me.info.TabIndex = 4
        '
        'btn_options
        '
        Me.btn_options.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.btn_options.FlatAppearance.BorderSize = 2
        Me.btn_options.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_options.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_options.Location = New System.Drawing.Point(676, 66)
        Me.btn_options.Name = "btn_options"
        Me.btn_options.Size = New System.Drawing.Size(86, 40)
        Me.btn_options.TabIndex = 3
        Me.btn_options.Text = "VIEW"
        Me.btn_options.UseVisualStyleBackColor = False
        '
        'btn_othrinfo
        '
        Me.btn_othrinfo.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.btn_othrinfo.FlatAppearance.BorderSize = 2
        Me.btn_othrinfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_othrinfo.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_othrinfo.Location = New System.Drawing.Point(676, 112)
        Me.btn_othrinfo.Name = "btn_othrinfo"
        Me.btn_othrinfo.Size = New System.Drawing.Size(86, 40)
        Me.btn_othrinfo.TabIndex = 2
        Me.btn_othrinfo.Text = "OTHER INFO"
        Me.btn_othrinfo.UseVisualStyleBackColor = False
        '
        'visitdgv
        '
        Me.visitdgv.AllowUserToAddRows = False
        Me.visitdgv.AllowUserToDeleteRows = False
        Me.visitdgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.visitdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.visitdgv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.vstID, Me.vstDate})
        Me.visitdgv.Location = New System.Drawing.Point(387, 20)
        Me.visitdgv.Name = "visitdgv"
        Me.visitdgv.ReadOnly = True
        Me.visitdgv.RowHeadersVisible = False
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        Me.visitdgv.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.visitdgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.visitdgv.Size = New System.Drawing.Size(283, 136)
        Me.visitdgv.TabIndex = 0
        '
        'vstID
        '
        Me.vstID.FillWeight = 71.06599!
        Me.vstID.HeaderText = "VISIT ID"
        Me.vstID.Name = "vstID"
        Me.vstID.ReadOnly = True
        '
        'vstDate
        '
        Me.vstDate.FillWeight = 128.934!
        Me.vstDate.HeaderText = "VISIT DATE"
        Me.vstDate.Name = "vstDate"
        Me.vstDate.ReadOnly = True
        '
        'DG_pinfo
        '
        Me.DG_pinfo.AllowUserToAddRows = False
        Me.DG_pinfo.AllowUserToDeleteRows = False
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        Me.DG_pinfo.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DG_pinfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DG_pinfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_pinfo.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ptid, Me.fullName, Me.addr})
        Me.DG_pinfo.Location = New System.Drawing.Point(12, 59)
        Me.DG_pinfo.Name = "DG_pinfo"
        Me.DG_pinfo.ReadOnly = True
        Me.DG_pinfo.RowHeadersVisible = False
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        Me.DG_pinfo.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DG_pinfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG_pinfo.Size = New System.Drawing.Size(768, 164)
        Me.DG_pinfo.TabIndex = 10
        '
        'stat
        '
        Me.stat.HeaderText = "INFO"
        Me.stat.Name = "stat"
        Me.stat.ReadOnly = True
        '
        'data
        '
        Me.data.FillWeight = 150.0!
        Me.data.HeaderText = "DATA"
        Me.data.Name = "data"
        Me.data.ReadOnly = True
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.Button1.FlatAppearance.BorderSize = 2
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(676, 21)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(86, 40)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "ADD NEW"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'ptid
        '
        Me.ptid.FillWeight = 44.83877!
        Me.ptid.HeaderText = "Patient ID"
        Me.ptid.Name = "ptid"
        Me.ptid.ReadOnly = True
        '
        'fullName
        '
        Me.fullName.FillWeight = 90.0!
        Me.fullName.HeaderText = "Full Name"
        Me.fullName.Name = "fullName"
        Me.fullName.ReadOnly = True
        '
        'addr
        '
        Me.addr.HeaderText = "Address"
        Me.addr.Name = "addr"
        Me.addr.ReadOnly = True
        '
        'txtFilter
        '
        Me.txtFilter.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFilter.FormattingEnabled = True
        Me.txtFilter.Items.AddRange(New Object() {"LAST NAME", "FIRST NAME", "ADDRESS"})
        Me.txtFilter.Location = New System.Drawing.Point(452, 17)
        Me.txtFilter.Name = "txtFilter"
        Me.txtFilter.Size = New System.Drawing.Size(166, 28)
        Me.txtFilter.TabIndex = 11
        Me.txtFilter.Text = "---"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Franklin Gothic Medium", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(375, 24)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 18)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Search By:"
        '
        'Patient_Directory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(792, 413)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtFilter)
        Me.Controls.Add(Me.DG_pinfo)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btn_search)
        Me.Controls.Add(Me.tt_pinfo)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Name = "Patient_Directory"
        Me.Text = "Patient Directory"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.info, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.visitdgv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DG_pinfo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_search As Button
    Friend WithEvents tt_pinfo As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btn_options As Button
    Friend WithEvents btn_othrinfo As Button
    Friend WithEvents visitdgv As DataGridView
    Friend WithEvents DG_pinfo As DataGridView
    Friend WithEvents info As DataGridView
    Friend WithEvents vstID As DataGridViewTextBoxColumn
    Friend WithEvents vstDate As DataGridViewTextBoxColumn
    Friend WithEvents stat As DataGridViewTextBoxColumn
    Friend WithEvents data As DataGridViewTextBoxColumn
    Friend WithEvents Button1 As Button
    Friend WithEvents ptid As DataGridViewTextBoxColumn
    Friend WithEvents fullName As DataGridViewTextBoxColumn
    Friend WithEvents addr As DataGridViewTextBoxColumn
    Friend WithEvents txtFilter As ComboBox
    Friend WithEvents Label2 As Label
End Class
