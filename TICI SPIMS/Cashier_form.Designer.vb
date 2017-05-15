<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cashier_form
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
        Me.label_pname = New System.Windows.Forms.Label()
        Me.text_pname = New System.Windows.Forms.TextBox()
        Me.btn_search = New System.Windows.Forms.Button()
        Me.DG_precord = New System.Windows.Forms.DataGridView()
        Me.label_result = New System.Windows.Forms.Label()
        Me.DG_pcharges = New System.Windows.Forms.DataGridView()
        Me.label_unpcharges = New System.Windows.Forms.Label()
        Me.GB_othrcharge = New System.Windows.Forms.GroupBox()
        Me.text_chrgprice = New System.Windows.Forms.TextBox()
        Me.text_chrgname = New System.Windows.Forms.TextBox()
        Me.label_chrgprice = New System.Windows.Forms.Label()
        Me.label_chrgname = New System.Windows.Forms.Label()
        Me.btn_addc = New System.Windows.Forms.Button()
        Me.GB_transactions = New System.Windows.Forms.GroupBox()
        Me.GB_result = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.label_amtchange = New System.Windows.Forms.Label()
        Me.label_amtchrg = New System.Windows.Forms.Label()
        Me.label_change = New System.Windows.Forms.Label()
        Me.btn_pwdsnr = New System.Windows.Forms.Button()
        Me.btn_accept = New System.Windows.Forms.Button()
        Me.label_amtcash = New System.Windows.Forms.Label()
        Me.text_amtcash = New System.Windows.Forms.TextBox()
        Me.btn_back = New System.Windows.Forms.Button()
        Me.label_transaction = New System.Windows.Forms.Label()
        CType(Me.DG_precord, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DG_pcharges, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GB_othrcharge.SuspendLayout()
        Me.GB_transactions.SuspendLayout()
        Me.GB_result.SuspendLayout()
        Me.SuspendLayout()
        '
        'label_pname
        '
        Me.label_pname.AutoSize = True
        Me.label_pname.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_pname.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.label_pname.Location = New System.Drawing.Point(9, 51)
        Me.label_pname.Name = "label_pname"
        Me.label_pname.Size = New System.Drawing.Size(115, 21)
        Me.label_pname.TabIndex = 0
        Me.label_pname.Text = "PATIENT NAME"
        '
        'text_pname
        '
        Me.text_pname.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.text_pname.ForeColor = System.Drawing.SystemColors.WindowText
        Me.text_pname.Location = New System.Drawing.Point(130, 46)
        Me.text_pname.Multiline = True
        Me.text_pname.Name = "text_pname"
        Me.text_pname.Size = New System.Drawing.Size(361, 30)
        Me.text_pname.TabIndex = 1
        '
        'btn_search
        '
        Me.btn_search.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.btn_search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_search.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_search.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_search.Location = New System.Drawing.Point(494, 46)
        Me.btn_search.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_search.Name = "btn_search"
        Me.btn_search.Padding = New System.Windows.Forms.Padding(2)
        Me.btn_search.Size = New System.Drawing.Size(128, 30)
        Me.btn_search.TabIndex = 2
        Me.btn_search.Text = "Search"
        Me.btn_search.UseMnemonic = False
        Me.btn_search.UseVisualStyleBackColor = False
        '
        'DG_precord
        '
        Me.DG_precord.AccessibleDescription = "Patient Record"
        Me.DG_precord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_precord.Location = New System.Drawing.Point(13, 113)
        Me.DG_precord.Name = "DG_precord"
        Me.DG_precord.Size = New System.Drawing.Size(499, 245)
        Me.DG_precord.TabIndex = 3
        '
        'label_result
        '
        Me.label_result.AccessibleDescription = "Result"
        Me.label_result.AutoSize = True
        Me.label_result.Font = New System.Drawing.Font("Franklin Gothic Medium", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_result.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.label_result.Location = New System.Drawing.Point(10, 89)
        Me.label_result.Name = "label_result"
        Me.label_result.Size = New System.Drawing.Size(58, 20)
        Me.label_result.TabIndex = 4
        Me.label_result.Text = "Results"
        '
        'DG_pcharges
        '
        Me.DG_pcharges.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_pcharges.Location = New System.Drawing.Point(13, 384)
        Me.DG_pcharges.Name = "DG_pcharges"
        Me.DG_pcharges.Size = New System.Drawing.Size(220, 170)
        Me.DG_pcharges.TabIndex = 5
        '
        'label_unpcharges
        '
        Me.label_unpcharges.AutoSize = True
        Me.label_unpcharges.Font = New System.Drawing.Font("Franklin Gothic Medium", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_unpcharges.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.label_unpcharges.Location = New System.Drawing.Point(10, 364)
        Me.label_unpcharges.Name = "label_unpcharges"
        Me.label_unpcharges.Size = New System.Drawing.Size(111, 20)
        Me.label_unpcharges.TabIndex = 6
        Me.label_unpcharges.Text = "Unpaid Charges"
        '
        'GB_othrcharge
        '
        Me.GB_othrcharge.Controls.Add(Me.text_chrgprice)
        Me.GB_othrcharge.Controls.Add(Me.text_chrgname)
        Me.GB_othrcharge.Controls.Add(Me.label_chrgprice)
        Me.GB_othrcharge.Controls.Add(Me.label_chrgname)
        Me.GB_othrcharge.Controls.Add(Me.btn_addc)
        Me.GB_othrcharge.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB_othrcharge.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.GB_othrcharge.Location = New System.Drawing.Point(251, 364)
        Me.GB_othrcharge.Name = "GB_othrcharge"
        Me.GB_othrcharge.Size = New System.Drawing.Size(261, 190)
        Me.GB_othrcharge.TabIndex = 7
        Me.GB_othrcharge.TabStop = False
        Me.GB_othrcharge.Text = "Other Charges"
        '
        'text_chrgprice
        '
        Me.text_chrgprice.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.text_chrgprice.Location = New System.Drawing.Point(111, 76)
        Me.text_chrgprice.Name = "text_chrgprice"
        Me.text_chrgprice.Size = New System.Drawing.Size(144, 26)
        Me.text_chrgprice.TabIndex = 12
        Me.text_chrgprice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'text_chrgname
        '
        Me.text_chrgname.Font = New System.Drawing.Font("Franklin Gothic Medium", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.text_chrgname.Location = New System.Drawing.Point(111, 28)
        Me.text_chrgname.Multiline = True
        Me.text_chrgname.Name = "text_chrgname"
        Me.text_chrgname.Size = New System.Drawing.Size(144, 30)
        Me.text_chrgname.TabIndex = 11
        '
        'label_chrgprice
        '
        Me.label_chrgprice.AutoSize = True
        Me.label_chrgprice.Font = New System.Drawing.Font("Franklin Gothic Medium", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_chrgprice.Location = New System.Drawing.Point(59, 81)
        Me.label_chrgprice.Name = "label_chrgprice"
        Me.label_chrgprice.Size = New System.Drawing.Size(46, 20)
        Me.label_chrgprice.TabIndex = 10
        Me.label_chrgprice.Text = "Price:"
        '
        'label_chrgname
        '
        Me.label_chrgname.AutoSize = True
        Me.label_chrgname.Font = New System.Drawing.Font("Franklin Gothic Medium", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_chrgname.Location = New System.Drawing.Point(6, 31)
        Me.label_chrgname.Name = "label_chrgname"
        Me.label_chrgname.Size = New System.Drawing.Size(99, 20)
        Me.label_chrgname.TabIndex = 9
        Me.label_chrgname.Text = "Charge name:"
        '
        'btn_addc
        '
        Me.btn_addc.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.btn_addc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_addc.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_addc.Location = New System.Drawing.Point(111, 119)
        Me.btn_addc.Name = "btn_addc"
        Me.btn_addc.Size = New System.Drawing.Size(144, 38)
        Me.btn_addc.TabIndex = 0
        Me.btn_addc.Text = "Add"
        Me.btn_addc.UseVisualStyleBackColor = False
        '
        'GB_transactions
        '
        Me.GB_transactions.Controls.Add(Me.GB_result)
        Me.GB_transactions.Controls.Add(Me.btn_pwdsnr)
        Me.GB_transactions.Controls.Add(Me.btn_accept)
        Me.GB_transactions.Controls.Add(Me.label_amtcash)
        Me.GB_transactions.Controls.Add(Me.text_amtcash)
        Me.GB_transactions.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB_transactions.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GB_transactions.Location = New System.Drawing.Point(535, 89)
        Me.GB_transactions.Name = "GB_transactions"
        Me.GB_transactions.Size = New System.Drawing.Size(354, 465)
        Me.GB_transactions.TabIndex = 8
        Me.GB_transactions.TabStop = False
        Me.GB_transactions.Text = "Transaction"
        '
        'GB_result
        '
        Me.GB_result.Controls.Add(Me.Label1)
        Me.GB_result.Controls.Add(Me.label_amtchange)
        Me.GB_result.Controls.Add(Me.label_amtchrg)
        Me.GB_result.Controls.Add(Me.label_change)
        Me.GB_result.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB_result.ForeColor = System.Drawing.SystemColors.Window
        Me.GB_result.Location = New System.Drawing.Point(42, 209)
        Me.GB_result.Name = "GB_result"
        Me.GB_result.Size = New System.Drawing.Size(273, 205)
        Me.GB_result.TabIndex = 9
        Me.GB_result.TabStop = False
        Me.GB_result.Text = "Result"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 20.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(83, 40)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.MinimumSize = New System.Drawing.Size(133, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(133, 37)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "0"
        '
        'label_amtchange
        '
        Me.label_amtchange.AutoSize = True
        Me.label_amtchange.Font = New System.Drawing.Font("Segoe UI Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_amtchange.Location = New System.Drawing.Point(84, 122)
        Me.label_amtchange.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label_amtchange.MinimumSize = New System.Drawing.Size(133, 16)
        Me.label_amtchange.Name = "label_amtchange"
        Me.label_amtchange.Size = New System.Drawing.Size(133, 32)
        Me.label_amtchange.TabIndex = 11
        Me.label_amtchange.Text = "0"
        '
        'label_amtchrg
        '
        Me.label_amtchrg.AutoSize = True
        Me.label_amtchrg.Font = New System.Drawing.Font("Franklin Gothic Medium", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_amtchrg.Location = New System.Drawing.Point(29, 50)
        Me.label_amtchrg.Name = "label_amtchrg"
        Me.label_amtchrg.Size = New System.Drawing.Size(49, 20)
        Me.label_amtchrg.TabIndex = 7
        Me.label_amtchrg.Text = "TOTAL"
        '
        'label_change
        '
        Me.label_change.AutoSize = True
        Me.label_change.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_change.Location = New System.Drawing.Point(13, 128)
        Me.label_change.Name = "label_change"
        Me.label_change.Size = New System.Drawing.Size(66, 21)
        Me.label_change.TabIndex = 8
        Me.label_change.Text = "Change:"
        '
        'btn_pwdsnr
        '
        Me.btn_pwdsnr.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.btn_pwdsnr.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_pwdsnr.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_pwdsnr.ForeColor = System.Drawing.SystemColors.Window
        Me.btn_pwdsnr.Location = New System.Drawing.Point(37, 136)
        Me.btn_pwdsnr.Name = "btn_pwdsnr"
        Me.btn_pwdsnr.Size = New System.Drawing.Size(110, 67)
        Me.btn_pwdsnr.TabIndex = 4
        Me.btn_pwdsnr.Text = "PWD/Senior"
        Me.btn_pwdsnr.UseVisualStyleBackColor = False
        '
        'btn_accept
        '
        Me.btn_accept.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.btn_accept.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_accept.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_accept.ForeColor = System.Drawing.SystemColors.Window
        Me.btn_accept.Location = New System.Drawing.Point(153, 136)
        Me.btn_accept.Name = "btn_accept"
        Me.btn_accept.Size = New System.Drawing.Size(170, 67)
        Me.btn_accept.TabIndex = 3
        Me.btn_accept.Text = "CHECKOUT"
        Me.btn_accept.UseVisualStyleBackColor = False
        '
        'label_amtcash
        '
        Me.label_amtcash.AutoSize = True
        Me.label_amtcash.Font = New System.Drawing.Font("Franklin Gothic Medium", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_amtcash.ForeColor = System.Drawing.SystemColors.Window
        Me.label_amtcash.Location = New System.Drawing.Point(37, 48)
        Me.label_amtcash.Name = "label_amtcash"
        Me.label_amtcash.Size = New System.Drawing.Size(116, 20)
        Me.label_amtcash.TabIndex = 2
        Me.label_amtcash.Text = "Amount of Cash:"
        Me.label_amtcash.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'text_amtcash
        '
        Me.text_amtcash.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.text_amtcash.Font = New System.Drawing.Font("Franklin Gothic Medium", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.text_amtcash.Location = New System.Drawing.Point(34, 71)
        Me.text_amtcash.Multiline = True
        Me.text_amtcash.Name = "text_amtcash"
        Me.text_amtcash.Size = New System.Drawing.Size(286, 43)
        Me.text_amtcash.TabIndex = 1
        Me.text_amtcash.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btn_back
        '
        Me.btn_back.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_back.Font = New System.Drawing.Font("Franklin Gothic Medium", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_back.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_back.Location = New System.Drawing.Point(9, 9)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(75, 28)
        Me.btn_back.TabIndex = 0
        Me.btn_back.Text = "BACK"
        Me.btn_back.UseVisualStyleBackColor = False
        '
        'label_transaction
        '
        Me.label_transaction.AutoSize = True
        Me.label_transaction.Font = New System.Drawing.Font("Franklin Gothic Medium", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_transaction.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.label_transaction.Location = New System.Drawing.Point(746, 9)
        Me.label_transaction.Name = "label_transaction"
        Me.label_transaction.Size = New System.Drawing.Size(145, 30)
        Me.label_transaction.TabIndex = 1
        Me.label_transaction.Text = "Transactions"
        '
        'Cashier_form
        '
        Me.AccessibleName = "Cashier_form"
        Me.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(900, 573)
        Me.Controls.Add(Me.btn_back)
        Me.Controls.Add(Me.label_transaction)
        Me.Controls.Add(Me.GB_transactions)
        Me.Controls.Add(Me.GB_othrcharge)
        Me.Controls.Add(Me.label_unpcharges)
        Me.Controls.Add(Me.DG_pcharges)
        Me.Controls.Add(Me.label_result)
        Me.Controls.Add(Me.DG_precord)
        Me.Controls.Add(Me.btn_search)
        Me.Controls.Add(Me.text_pname)
        Me.Controls.Add(Me.label_pname)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Cashier_form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cashier form"
        CType(Me.DG_precord, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DG_pcharges, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GB_othrcharge.ResumeLayout(False)
        Me.GB_othrcharge.PerformLayout()
        Me.GB_transactions.ResumeLayout(False)
        Me.GB_transactions.PerformLayout()
        Me.GB_result.ResumeLayout(False)
        Me.GB_result.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents label_pname As Label
    Friend WithEvents text_pname As TextBox
    Friend WithEvents btn_search As Button
    Friend WithEvents DG_precord As DataGridView
    Friend WithEvents label_result As Label
    Friend WithEvents DG_pcharges As DataGridView
    Friend WithEvents label_unpcharges As Label
    Friend WithEvents GB_othrcharge As GroupBox
    Friend WithEvents GB_transactions As GroupBox
    Friend WithEvents btn_pwdsnr As Button
    Friend WithEvents btn_accept As Button
    Friend WithEvents label_amtcash As Label
    Friend WithEvents text_amtcash As TextBox
    Friend WithEvents label_amtchrg As Label
    Friend WithEvents GB_result As GroupBox
    Friend WithEvents label_change As Label
    Friend WithEvents btn_addc As Button
    Friend WithEvents label_chrgname As Label
    Friend WithEvents label_chrgprice As Label
    Friend WithEvents text_chrgname As TextBox
    Friend WithEvents text_chrgprice As TextBox
    Friend WithEvents btn_back As Button
    Friend WithEvents label_transaction As Label
    Friend WithEvents label_amtchange As Label
    Friend WithEvents Label1 As Label
End Class
