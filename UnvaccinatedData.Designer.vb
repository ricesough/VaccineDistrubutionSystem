<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UnvaccinatedData
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UnvaccinatedData))
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblvaccinename = New System.Windows.Forms.Label()
        Me.txtvaccinename = New System.Windows.Forms.TextBox()
        Me.lblcnumber = New System.Windows.Forms.Label()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.lblssfname = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.dtpfdate = New System.Windows.Forms.DateTimePicker()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.txtcnumber = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
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
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel3.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel3.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Panel3.Location = New System.Drawing.Point(826, 108)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(369, 66)
        Me.Panel3.TabIndex = 119
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.InactiveBorder
        Me.Label1.Location = New System.Drawing.Point(260, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(689, 25)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "VACCINE DISTRIBUTION SYSTEM (UNVACCINATED RECIPIENTS)"
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel1.Location = New System.Drawing.Point(21, 27)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1175, 58)
        Me.Panel1.TabIndex = 98
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToResizeColumns = False
        Me.DataGridView2.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Gray
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.DataGridView2.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView2.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.DataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.DataGridView2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView2.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView2.GridColor = System.Drawing.SystemColors.ActiveCaption
        Me.DataGridView2.Location = New System.Drawing.Point(9, 10)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView2.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.DataGridView2.RowTemplate.Height = 28
        Me.DataGridView2.Size = New System.Drawing.Size(774, 466)
        Me.DataGridView2.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel2.Controls.Add(Me.DataGridView2)
        Me.Panel2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel2.Location = New System.Drawing.Point(21, 108)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(792, 487)
        Me.Panel2.TabIndex = 99
        '
        'lblvaccinename
        '
        Me.lblvaccinename.AutoSize = True
        Me.lblvaccinename.BackColor = System.Drawing.Color.Transparent
        Me.lblvaccinename.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.lblvaccinename.Location = New System.Drawing.Point(858, 417)
        Me.lblvaccinename.Name = "lblvaccinename"
        Me.lblvaccinename.Size = New System.Drawing.Size(112, 20)
        Me.lblvaccinename.TabIndex = 108
        Me.lblvaccinename.Text = "Vaccine Name"
        '
        'txtvaccinename
        '
        Me.txtvaccinename.Location = New System.Drawing.Point(971, 414)
        Me.txtvaccinename.Name = "txtvaccinename"
        Me.txtvaccinename.Size = New System.Drawing.Size(225, 26)
        Me.txtvaccinename.TabIndex = 109
        '
        'lblcnumber
        '
        Me.lblcnumber.AutoSize = True
        Me.lblcnumber.BackColor = System.Drawing.Color.Transparent
        Me.lblcnumber.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.lblcnumber.Location = New System.Drawing.Point(845, 452)
        Me.lblcnumber.Name = "lblcnumber"
        Me.lblcnumber.Size = New System.Drawing.Size(125, 20)
        Me.lblcnumber.TabIndex = 110
        Me.lblcnumber.Text = "First Dose Date:"
        '
        'btnDelete
        '
        Me.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnDelete.BackColor = System.Drawing.SystemColors.ControlDark
        Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.btnDelete.Location = New System.Drawing.Point(823, 555)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(183, 40)
        Me.btnDelete.TabIndex = 112
        Me.btnDelete.Text = "DELETE"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnExit.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.btnExit.Location = New System.Drawing.Point(1012, 555)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(183, 40)
        Me.btnExit.TabIndex = 113
        Me.btnExit.Text = "EXIT"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnUpdate
        '
        Me.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnUpdate.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.btnUpdate.Location = New System.Drawing.Point(1012, 511)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(183, 40)
        Me.btnUpdate.TabIndex = 116
        Me.btnUpdate.Text = "UPDATE"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'lblssfname
        '
        Me.lblssfname.AutoSize = True
        Me.lblssfname.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblssfname.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblssfname.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.lblssfname.Location = New System.Drawing.Point(949, 117)
        Me.lblssfname.Name = "lblssfname"
        Me.lblssfname.Size = New System.Drawing.Size(132, 20)
        Me.lblssfname.TabIndex = 117
        Me.lblssfname.Text = "Search with ID:"
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(841, 140)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(340, 26)
        Me.txtID.TabIndex = 118
        Me.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'dtpfdate
        '
        Me.dtpfdate.CalendarForeColor = System.Drawing.SystemColors.ControlDark
        Me.dtpfdate.CalendarTitleForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.dtpfdate.CalendarTrailingForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.dtpfdate.CustomFormat = ""
        Me.dtpfdate.Location = New System.Drawing.Point(971, 449)
        Me.dtpfdate.Name = "dtpfdate"
        Me.dtpfdate.Size = New System.Drawing.Size(225, 26)
        Me.dtpfdate.TabIndex = 120
        '
        'btnBack
        '
        Me.btnBack.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnBack.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.btnBack.Location = New System.Drawing.Point(823, 511)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(183, 40)
        Me.btnBack.TabIndex = 121
        Me.btnBack.Text = "BACK"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'txtcnumber
        '
        Me.txtcnumber.Location = New System.Drawing.Point(971, 380)
        Me.txtcnumber.Name = "txtcnumber"
        Me.txtcnumber.Size = New System.Drawing.Size(225, 26)
        Me.txtcnumber.TabIndex = 209
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.Label2.Location = New System.Drawing.Point(845, 383)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(129, 20)
        Me.Label2.TabIndex = 208
        Me.Label2.Text = "Contact Number:"
        '
        'txtpraddress
        '
        Me.txtpraddress.Location = New System.Drawing.Point(971, 346)
        Me.txtpraddress.Name = "txtpraddress"
        Me.txtpraddress.Size = New System.Drawing.Size(225, 26)
        Me.txtpraddress.TabIndex = 207
        '
        'lblpraddress
        '
        Me.lblpraddress.AutoSize = True
        Me.lblpraddress.BackColor = System.Drawing.Color.Transparent
        Me.lblpraddress.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.lblpraddress.Location = New System.Drawing.Point(843, 349)
        Me.lblpraddress.Name = "lblpraddress"
        Me.lblpraddress.Size = New System.Drawing.Size(131, 20)
        Me.lblpraddress.TabIndex = 206
        Me.lblpraddress.Text = "Present Address:"
        '
        'txtpmaddress
        '
        Me.txtpmaddress.Location = New System.Drawing.Point(971, 311)
        Me.txtpmaddress.Name = "txtpmaddress"
        Me.txtpmaddress.Size = New System.Drawing.Size(225, 26)
        Me.txtpmaddress.TabIndex = 205
        '
        'lblpmaddress
        '
        Me.lblpmaddress.AutoSize = True
        Me.lblpmaddress.BackColor = System.Drawing.Color.Transparent
        Me.lblpmaddress.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.lblpmaddress.Location = New System.Drawing.Point(818, 314)
        Me.lblpmaddress.Name = "lblpmaddress"
        Me.lblpmaddress.Size = New System.Drawing.Size(154, 20)
        Me.lblpmaddress.TabIndex = 204
        Me.lblpmaddress.Text = "Permanent Address:"
        '
        'txtlname
        '
        Me.txtlname.Location = New System.Drawing.Point(971, 277)
        Me.txtlname.Name = "txtlname"
        Me.txtlname.Size = New System.Drawing.Size(225, 26)
        Me.txtlname.TabIndex = 203
        '
        'lbllname
        '
        Me.lbllname.AutoSize = True
        Me.lbllname.BackColor = System.Drawing.Color.Transparent
        Me.lbllname.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.lbllname.Location = New System.Drawing.Point(881, 280)
        Me.lbllname.Name = "lbllname"
        Me.lbllname.Size = New System.Drawing.Size(90, 20)
        Me.lbllname.TabIndex = 202
        Me.lbllname.Text = "Last Name:"
        '
        'txtmname
        '
        Me.txtmname.Location = New System.Drawing.Point(971, 243)
        Me.txtmname.Name = "txtmname"
        Me.txtmname.Size = New System.Drawing.Size(225, 26)
        Me.txtmname.TabIndex = 201
        '
        'lblmname
        '
        Me.lblmname.AutoSize = True
        Me.lblmname.BackColor = System.Drawing.Color.Transparent
        Me.lblmname.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.lblmname.Location = New System.Drawing.Point(867, 246)
        Me.lblmname.Name = "lblmname"
        Me.lblmname.Size = New System.Drawing.Size(105, 20)
        Me.lblmname.TabIndex = 200
        Me.lblmname.Text = "Middle Name:"
        '
        'lblfname
        '
        Me.lblfname.AutoSize = True
        Me.lblfname.BackColor = System.Drawing.Color.Transparent
        Me.lblfname.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.lblfname.Location = New System.Drawing.Point(880, 211)
        Me.lblfname.Name = "lblfname"
        Me.lblfname.Size = New System.Drawing.Size(90, 20)
        Me.lblfname.TabIndex = 198
        Me.lblfname.Text = "First Name:"
        '
        'txtfname
        '
        Me.txtfname.Location = New System.Drawing.Point(971, 208)
        Me.txtfname.Name = "txtfname"
        Me.txtfname.Size = New System.Drawing.Size(225, 26)
        Me.txtfname.TabIndex = 199
        '
        'UnvaccinatedData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.VaccineDistrubution.My.Resources.Resources.Blue_Simple_Illustration_Covid_Pandemic_Vaccine_Medical_Presentation_Template__2_1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1214, 622)
        Me.Controls.Add(Me.txtcnumber)
        Me.Controls.Add(Me.Label2)
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
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.dtpfdate)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.lblssfname)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.lblcnumber)
        Me.Controls.Add(Me.txtvaccinename)
        Me.Controls.Add(Me.lblvaccinename)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel3)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "UnvaccinatedData"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "UnvaccinatedData"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblvaccinename As Label
    Friend WithEvents txtvaccinename As TextBox
    Friend WithEvents lblcnumber As Label
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents lblssfname As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents dtpfdate As DateTimePicker
    Friend WithEvents btnBack As Button
    Friend WithEvents txtcnumber As TextBox
    Friend WithEvents Label2 As Label
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
