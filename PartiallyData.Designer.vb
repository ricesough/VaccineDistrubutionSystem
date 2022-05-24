<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PartiallyData
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PartiallyData))
        Me.btnBack = New System.Windows.Forms.Button()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.lblID = New System.Windows.Forms.Label()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txtvname1 = New System.Windows.Forms.TextBox()
        Me.lblvname1 = New System.Windows.Forms.Label()
        Me.dtptsdate1 = New System.Windows.Forms.DateTimePicker()
        Me.lbltsdate1 = New System.Windows.Forms.Label()
        Me.dtpfdate1 = New System.Windows.Forms.DateTimePicker()
        Me.lblfdate1 = New System.Windows.Forms.Label()
        Me.txtcnumber = New System.Windows.Forms.TextBox()
        Me.lblcnumber = New System.Windows.Forms.Label()
        Me.txtpraddress = New System.Windows.Forms.TextBox()
        Me.lblpraddress = New System.Windows.Forms.Label()
        Me.txtpmaddress = New System.Windows.Forms.TextBox()
        Me.lblpmaddress = New System.Windows.Forms.Label()
        Me.txtlname = New System.Windows.Forms.TextBox()
        Me.lbllname = New System.Windows.Forms.Label()
        Me.txtmname = New System.Windows.Forms.TextBox()
        Me.lblmname = New System.Windows.Forms.Label()
        Me.lblfname = New System.Windows.Forms.Label()
        Me.txtfname = New System.Windows.Forms.TextBox()
        Me.Panel2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnBack
        '
        Me.btnBack.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnBack.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.btnBack.Location = New System.Drawing.Point(825, 525)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(183, 40)
        Me.btnBack.TabIndex = 121
        Me.btnBack.Text = "BACK"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(841, 133)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(340, 26)
        Me.txtID.TabIndex = 119
        Me.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblID.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.lblID.Location = New System.Drawing.Point(944, 108)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(132, 20)
        Me.lblID.TabIndex = 118
        Me.lblID.Text = "Search with ID:"
        '
        'btnUpdate
        '
        Me.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnUpdate.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.btnUpdate.Location = New System.Drawing.Point(1014, 525)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(183, 40)
        Me.btnUpdate.TabIndex = 117
        Me.btnUpdate.Text = "UPDATE"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnExit.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.btnExit.Location = New System.Drawing.Point(1014, 569)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(183, 40)
        Me.btnExit.TabIndex = 114
        Me.btnExit.Text = "EXIT"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnDelete.BackColor = System.Drawing.SystemColors.ControlDark
        Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.btnDelete.Location = New System.Drawing.Point(825, 569)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(183, 40)
        Me.btnDelete.TabIndex = 113
        Me.btnDelete.Text = "DELETE"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel2.Controls.Add(Me.DataGridView1)
        Me.Panel2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel2.Location = New System.Drawing.Point(21, 102)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(792, 507)
        Me.Panel2.TabIndex = 100
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Gray
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaption
        Me.DataGridView1.Location = New System.Drawing.Point(9, 9)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(774, 487)
        Me.DataGridView1.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel1.Location = New System.Drawing.Point(21, 20)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1175, 58)
        Me.Panel1.TabIndex = 99
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.InactiveBorder
        Me.Label1.Location = New System.Drawing.Point(273, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(647, 25)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "VACCINE DISTRIBUTION SYSTEM (PARTIALLY VACCINATED)"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label7.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label7.Location = New System.Drawing.Point(366, 32)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(479, 20)
        Me.Label7.TabIndex = 29
        Me.Label7.Text = "Please make sure that the details you entered are true and correct."
        '
        'Panel3
        '
        Me.Panel3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel3.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel3.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Panel3.Location = New System.Drawing.Point(829, 102)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(367, 66)
        Me.Panel3.TabIndex = 120
        '
        'txtvname1
        '
        Me.txtvname1.Location = New System.Drawing.Point(970, 403)
        Me.txtvname1.Name = "txtvname1"
        Me.txtvname1.Size = New System.Drawing.Size(225, 26)
        Me.txtvname1.TabIndex = 127
        '
        'lblvname1
        '
        Me.lblvname1.AutoSize = True
        Me.lblvname1.BackColor = System.Drawing.Color.Transparent
        Me.lblvname1.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.lblvname1.Location = New System.Drawing.Point(851, 406)
        Me.lblvname1.Name = "lblvname1"
        Me.lblvname1.Size = New System.Drawing.Size(116, 20)
        Me.lblvname1.TabIndex = 126
        Me.lblvname1.Text = "Vaccine Name:"
        '
        'dtptsdate1
        '
        Me.dtptsdate1.Location = New System.Drawing.Point(970, 471)
        Me.dtptsdate1.Name = "dtptsdate1"
        Me.dtptsdate1.Size = New System.Drawing.Size(225, 26)
        Me.dtptsdate1.TabIndex = 125
        '
        'lbltsdate1
        '
        Me.lbltsdate1.AutoSize = True
        Me.lbltsdate1.BackColor = System.Drawing.Color.Transparent
        Me.lbltsdate1.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.lbltsdate1.Location = New System.Drawing.Point(819, 474)
        Me.lbltsdate1.Name = "lbltsdate1"
        Me.lbltsdate1.Size = New System.Drawing.Size(149, 20)
        Me.lbltsdate1.TabIndex = 124
        Me.lbltsdate1.Text = "Second Dose Date:"
        '
        'dtpfdate1
        '
        Me.dtpfdate1.Location = New System.Drawing.Point(970, 437)
        Me.dtpfdate1.Name = "dtpfdate1"
        Me.dtpfdate1.Size = New System.Drawing.Size(225, 26)
        Me.dtpfdate1.TabIndex = 123
        '
        'lblfdate1
        '
        Me.lblfdate1.AutoSize = True
        Me.lblfdate1.BackColor = System.Drawing.Color.Transparent
        Me.lblfdate1.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.lblfdate1.Location = New System.Drawing.Point(842, 440)
        Me.lblfdate1.Name = "lblfdate1"
        Me.lblfdate1.Size = New System.Drawing.Size(125, 20)
        Me.lblfdate1.TabIndex = 122
        Me.lblfdate1.Text = "First Dose Date:"
        '
        'txtcnumber
        '
        Me.txtcnumber.Location = New System.Drawing.Point(971, 369)
        Me.txtcnumber.Name = "txtcnumber"
        Me.txtcnumber.Size = New System.Drawing.Size(225, 26)
        Me.txtcnumber.TabIndex = 197
        '
        'lblcnumber
        '
        Me.lblcnumber.AutoSize = True
        Me.lblcnumber.BackColor = System.Drawing.Color.Transparent
        Me.lblcnumber.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.lblcnumber.Location = New System.Drawing.Point(845, 372)
        Me.lblcnumber.Name = "lblcnumber"
        Me.lblcnumber.Size = New System.Drawing.Size(129, 20)
        Me.lblcnumber.TabIndex = 196
        Me.lblcnumber.Text = "Contact Number:"
        '
        'txtpraddress
        '
        Me.txtpraddress.Location = New System.Drawing.Point(971, 335)
        Me.txtpraddress.Name = "txtpraddress"
        Me.txtpraddress.Size = New System.Drawing.Size(225, 26)
        Me.txtpraddress.TabIndex = 195
        '
        'lblpraddress
        '
        Me.lblpraddress.AutoSize = True
        Me.lblpraddress.BackColor = System.Drawing.Color.Transparent
        Me.lblpraddress.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.lblpraddress.Location = New System.Drawing.Point(843, 338)
        Me.lblpraddress.Name = "lblpraddress"
        Me.lblpraddress.Size = New System.Drawing.Size(131, 20)
        Me.lblpraddress.TabIndex = 194
        Me.lblpraddress.Text = "Present Address:"
        '
        'txtpmaddress
        '
        Me.txtpmaddress.Location = New System.Drawing.Point(971, 300)
        Me.txtpmaddress.Name = "txtpmaddress"
        Me.txtpmaddress.Size = New System.Drawing.Size(225, 26)
        Me.txtpmaddress.TabIndex = 193
        '
        'lblpmaddress
        '
        Me.lblpmaddress.AutoSize = True
        Me.lblpmaddress.BackColor = System.Drawing.Color.Transparent
        Me.lblpmaddress.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.lblpmaddress.Location = New System.Drawing.Point(818, 303)
        Me.lblpmaddress.Name = "lblpmaddress"
        Me.lblpmaddress.Size = New System.Drawing.Size(154, 20)
        Me.lblpmaddress.TabIndex = 192
        Me.lblpmaddress.Text = "Permanent Address:"
        '
        'txtlname
        '
        Me.txtlname.Location = New System.Drawing.Point(971, 266)
        Me.txtlname.Name = "txtlname"
        Me.txtlname.Size = New System.Drawing.Size(225, 26)
        Me.txtlname.TabIndex = 191
        '
        'lbllname
        '
        Me.lbllname.AutoSize = True
        Me.lbllname.BackColor = System.Drawing.Color.Transparent
        Me.lbllname.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.lbllname.Location = New System.Drawing.Point(881, 269)
        Me.lbllname.Name = "lbllname"
        Me.lbllname.Size = New System.Drawing.Size(90, 20)
        Me.lbllname.TabIndex = 190
        Me.lbllname.Text = "Last Name:"
        '
        'txtmname
        '
        Me.txtmname.Location = New System.Drawing.Point(971, 232)
        Me.txtmname.Name = "txtmname"
        Me.txtmname.Size = New System.Drawing.Size(225, 26)
        Me.txtmname.TabIndex = 189
        '
        'lblmname
        '
        Me.lblmname.AutoSize = True
        Me.lblmname.BackColor = System.Drawing.Color.Transparent
        Me.lblmname.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.lblmname.Location = New System.Drawing.Point(867, 235)
        Me.lblmname.Name = "lblmname"
        Me.lblmname.Size = New System.Drawing.Size(105, 20)
        Me.lblmname.TabIndex = 188
        Me.lblmname.Text = "Middle Name:"
        '
        'lblfname
        '
        Me.lblfname.AutoSize = True
        Me.lblfname.BackColor = System.Drawing.Color.Transparent
        Me.lblfname.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.lblfname.Location = New System.Drawing.Point(880, 200)
        Me.lblfname.Name = "lblfname"
        Me.lblfname.Size = New System.Drawing.Size(90, 20)
        Me.lblfname.TabIndex = 186
        Me.lblfname.Text = "First Name:"
        '
        'txtfname
        '
        Me.txtfname.Location = New System.Drawing.Point(971, 197)
        Me.txtfname.Name = "txtfname"
        Me.txtfname.Size = New System.Drawing.Size(225, 26)
        Me.txtfname.TabIndex = 187
        '
        'PartiallyData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.VaccineDistrubution.My.Resources.Resources.Blue_Simple_Illustration_Covid_Pandemic_Vaccine_Medical_Presentation_Template__2_
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1214, 633)
        Me.Controls.Add(Me.txtcnumber)
        Me.Controls.Add(Me.lblcnumber)
        Me.Controls.Add(Me.txtpraddress)
        Me.Controls.Add(Me.lblpraddress)
        Me.Controls.Add(Me.txtpmaddress)
        Me.Controls.Add(Me.lblpmaddress)
        Me.Controls.Add(Me.txtlname)
        Me.Controls.Add(Me.lbllname)
        Me.Controls.Add(Me.txtmname)
        Me.Controls.Add(Me.lblmname)
        Me.Controls.Add(Me.lblfname)
        Me.Controls.Add(Me.txtfname)
        Me.Controls.Add(Me.txtvname1)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.lblvname1)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.dtptsdate1)
        Me.Controls.Add(Me.lblID)
        Me.Controls.Add(Me.lblfdate1)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.lbltsdate1)
        Me.Controls.Add(Me.dtpfdate1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel3)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "PartiallyData"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Partially Vaccinated"
        Me.Panel2.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnBack As Button
    Friend WithEvents txtID As TextBox
    Friend WithEvents lblID As Label
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents txtvname1 As TextBox
    Friend WithEvents lblvname1 As Label
    Friend WithEvents dtptsdate1 As DateTimePicker
    Friend WithEvents lbltsdate1 As Label
    Friend WithEvents dtpfdate1 As DateTimePicker
    Friend WithEvents lblfdate1 As Label
    Friend WithEvents txtcnumber As TextBox
    Friend WithEvents lblcnumber As Label
    Friend WithEvents txtpraddress As TextBox
    Friend WithEvents lblpraddress As Label
    Friend WithEvents txtpmaddress As TextBox
    Friend WithEvents lblpmaddress As Label
    Friend WithEvents txtlname As TextBox
    Friend WithEvents lbllname As Label
    Friend WithEvents txtmname As TextBox
    Friend WithEvents lblmname As Label
    Friend WithEvents lblfname As Label
    Friend WithEvents txtfname As TextBox
End Class
