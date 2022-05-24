<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VaccinationCenter
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VaccinationCenter))
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.lblID = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.lblVCname = New System.Windows.Forms.Label()
        Me.txtVCname = New System.Windows.Forms.TextBox()
        Me.lblVCaddress = New System.Windows.Forms.Label()
        Me.txtVCaddress = New System.Windows.Forms.TextBox()
        Me.lblVCnumber = New System.Windows.Forms.Label()
        Me.txtVCnumber = New System.Windows.Forms.TextBox()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel3.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel3.Controls.Add(Me.txtID)
        Me.Panel3.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Panel3.Location = New System.Drawing.Point(680, 116)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(367, 66)
        Me.Panel3.TabIndex = 166
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(15, 28)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(340, 26)
        Me.txtID.TabIndex = 165
        Me.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label7.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label7.Location = New System.Drawing.Point(272, 31)
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
        Me.Label1.Location = New System.Drawing.Point(274, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(471, 25)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "VACCINE DISTRIBUTION SYSTEM (CENTER)"
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel1.Location = New System.Drawing.Point(37, 40)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1010, 58)
        Me.Panel1.TabIndex = 145
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
        Me.DataGridView1.Location = New System.Drawing.Point(9, 8)
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
        Me.DataGridView1.Size = New System.Drawing.Size(604, 382)
        Me.DataGridView1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel2.Controls.Add(Me.DataGridView1)
        Me.Panel2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel2.Location = New System.Drawing.Point(38, 116)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(622, 399)
        Me.Panel2.TabIndex = 146
        '
        'btnDelete
        '
        Me.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnDelete.BackColor = System.Drawing.SystemColors.ControlDark
        Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.btnDelete.Location = New System.Drawing.Point(680, 473)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(179, 40)
        Me.btnDelete.TabIndex = 159
        Me.btnDelete.Text = "DELETE"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnExit.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.btnExit.Location = New System.Drawing.Point(868, 473)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(179, 40)
        Me.btnExit.TabIndex = 160
        Me.btnExit.Text = "EXIT"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnUpdate
        '
        Me.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnUpdate.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.btnUpdate.Location = New System.Drawing.Point(868, 426)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(179, 40)
        Me.btnUpdate.TabIndex = 163
        Me.btnUpdate.Text = "UPDATE"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblID.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.lblID.Location = New System.Drawing.Point(798, 120)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(132, 20)
        Me.lblID.TabIndex = 164
        Me.lblID.Text = "Search with ID:"
        '
        'btnBack
        '
        Me.btnBack.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnBack.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.btnBack.Location = New System.Drawing.Point(680, 426)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(179, 40)
        Me.btnBack.TabIndex = 167
        Me.btnBack.Text = "BACK"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'lblVCname
        '
        Me.lblVCname.AutoSize = True
        Me.lblVCname.BackColor = System.Drawing.Color.Transparent
        Me.lblVCname.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblVCname.Location = New System.Drawing.Point(708, 210)
        Me.lblVCname.Name = "lblVCname"
        Me.lblVCname.Size = New System.Drawing.Size(107, 20)
        Me.lblVCname.TabIndex = 168
        Me.lblVCname.Text = "Center Name:"
        '
        'txtVCname
        '
        Me.txtVCname.Location = New System.Drawing.Point(822, 207)
        Me.txtVCname.Name = "txtVCname"
        Me.txtVCname.Size = New System.Drawing.Size(225, 26)
        Me.txtVCname.TabIndex = 169
        '
        'lblVCaddress
        '
        Me.lblVCaddress.AutoSize = True
        Me.lblVCaddress.BackColor = System.Drawing.Color.Transparent
        Me.lblVCaddress.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblVCaddress.Location = New System.Drawing.Point(743, 252)
        Me.lblVCaddress.Name = "lblVCaddress"
        Me.lblVCaddress.Size = New System.Drawing.Size(72, 20)
        Me.lblVCaddress.TabIndex = 170
        Me.lblVCaddress.Text = "Address:"
        '
        'txtVCaddress
        '
        Me.txtVCaddress.Location = New System.Drawing.Point(822, 249)
        Me.txtVCaddress.Name = "txtVCaddress"
        Me.txtVCaddress.Size = New System.Drawing.Size(225, 26)
        Me.txtVCaddress.TabIndex = 171
        '
        'lblVCnumber
        '
        Me.lblVCnumber.AutoSize = True
        Me.lblVCnumber.BackColor = System.Drawing.Color.Transparent
        Me.lblVCnumber.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblVCnumber.Location = New System.Drawing.Point(686, 292)
        Me.lblVCnumber.Name = "lblVCnumber"
        Me.lblVCnumber.Size = New System.Drawing.Size(129, 20)
        Me.lblVCnumber.TabIndex = 172
        Me.lblVCnumber.Text = "Contact Number:"
        '
        'txtVCnumber
        '
        Me.txtVCnumber.Location = New System.Drawing.Point(822, 289)
        Me.txtVCnumber.Name = "txtVCnumber"
        Me.txtVCnumber.Size = New System.Drawing.Size(225, 26)
        Me.txtVCnumber.TabIndex = 173
        '
        'VaccinationCenter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.VaccineDistrubution.My.Resources.Resources.Blue_Simple_Illustration_Covid_Pandemic_Vaccine_Medical_Presentation_Template__2_
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1084, 549)
        Me.Controls.Add(Me.txtVCnumber)
        Me.Controls.Add(Me.lblVCnumber)
        Me.Controls.Add(Me.txtVCaddress)
        Me.Controls.Add(Me.lblVCaddress)
        Me.Controls.Add(Me.txtVCname)
        Me.Controls.Add(Me.lblVCname)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.lblID)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel3)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "VaccinationCenter"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Vaccination Center"
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents lblID As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents btnBack As Button
    Friend WithEvents lblVCname As Label
    Friend WithEvents txtVCname As TextBox
    Friend WithEvents lblVCaddress As Label
    Friend WithEvents txtVCaddress As TextBox
    Friend WithEvents lblVCnumber As Label
    Friend WithEvents txtVCnumber As TextBox
End Class
