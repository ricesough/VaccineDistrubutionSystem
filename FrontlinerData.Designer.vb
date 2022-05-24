<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrontlinerData
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrontlinerData))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.lblID = New System.Windows.Forms.Label()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.txtcnumber = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txtfname = New System.Windows.Forms.TextBox()
        Me.txtvcenter = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.InactiveBorder
        Me.Label1.Location = New System.Drawing.Point(347, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(518, 25)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "VACCINE DISTRIBUTION SYSTEM (FRONTLINER)"
        '
        'btnBack
        '
        Me.btnBack.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBack.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.btnBack.Location = New System.Drawing.Point(823, 428)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(183, 40)
        Me.btnBack.TabIndex = 167
        Me.btnBack.Text = "BACK"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(841, 140)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(340, 26)
        Me.txtID.TabIndex = 165
        Me.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblID.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.lblID.Location = New System.Drawing.Point(944, 117)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(132, 20)
        Me.lblID.TabIndex = 164
        Me.lblID.Text = "Search with ID:"
        '
        'btnUpdate
        '
        Me.btnUpdate.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnUpdate.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.btnUpdate.Location = New System.Drawing.Point(1012, 428)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(183, 40)
        Me.btnUpdate.TabIndex = 163
        Me.btnUpdate.Text = "UPDATE"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExit.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.btnExit.Location = New System.Drawing.Point(1012, 472)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(183, 40)
        Me.btnExit.TabIndex = 160
        Me.btnExit.Text = "EXIT"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDelete.BackColor = System.Drawing.SystemColors.ControlDark
        Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.btnDelete.Location = New System.Drawing.Point(823, 472)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(183, 40)
        Me.btnDelete.TabIndex = 159
        Me.btnDelete.Text = "DELETE"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'txtcnumber
        '
        Me.txtcnumber.Location = New System.Drawing.Point(970, 352)
        Me.txtcnumber.Name = "txtcnumber"
        Me.txtcnumber.Size = New System.Drawing.Size(225, 26)
        Me.txtcnumber.TabIndex = 158
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
        'lblcnumber
        '
        Me.lblcnumber.AutoSize = True
        Me.lblcnumber.BackColor = System.Drawing.Color.Transparent
        Me.lblcnumber.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.lblcnumber.Location = New System.Drawing.Point(841, 355)
        Me.lblcnumber.Name = "lblcnumber"
        Me.lblcnumber.Size = New System.Drawing.Size(129, 20)
        Me.lblcnumber.TabIndex = 157
        Me.lblcnumber.Text = "Contact Number:"
        '
        'txtpraddress
        '
        Me.txtpraddress.Location = New System.Drawing.Point(970, 320)
        Me.txtpraddress.Name = "txtpraddress"
        Me.txtpraddress.Size = New System.Drawing.Size(225, 26)
        Me.txtpraddress.TabIndex = 156
        '
        'lblpraddress
        '
        Me.lblpraddress.AutoSize = True
        Me.lblpraddress.BackColor = System.Drawing.Color.Transparent
        Me.lblpraddress.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.lblpraddress.Location = New System.Drawing.Point(840, 323)
        Me.lblpraddress.Name = "lblpraddress"
        Me.lblpraddress.Size = New System.Drawing.Size(131, 20)
        Me.lblpraddress.TabIndex = 155
        Me.lblpraddress.Text = "Present Address:"
        '
        'txtpmaddress
        '
        Me.txtpmaddress.Location = New System.Drawing.Point(970, 287)
        Me.txtpmaddress.Name = "txtpmaddress"
        Me.txtpmaddress.Size = New System.Drawing.Size(225, 26)
        Me.txtpmaddress.TabIndex = 154
        '
        'lblpmaddress
        '
        Me.lblpmaddress.AutoSize = True
        Me.lblpmaddress.BackColor = System.Drawing.Color.Transparent
        Me.lblpmaddress.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.lblpmaddress.Location = New System.Drawing.Point(817, 290)
        Me.lblpmaddress.Name = "lblpmaddress"
        Me.lblpmaddress.Size = New System.Drawing.Size(154, 20)
        Me.lblpmaddress.TabIndex = 153
        Me.lblpmaddress.Text = "Permanent Address:"
        '
        'txtlname
        '
        Me.txtlname.Location = New System.Drawing.Point(970, 255)
        Me.txtlname.Name = "txtlname"
        Me.txtlname.Size = New System.Drawing.Size(225, 26)
        Me.txtlname.TabIndex = 152
        '
        'lbllname
        '
        Me.lbllname.AutoSize = True
        Me.lbllname.BackColor = System.Drawing.Color.Transparent
        Me.lbllname.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.lbllname.Location = New System.Drawing.Point(880, 258)
        Me.lbllname.Name = "lbllname"
        Me.lbllname.Size = New System.Drawing.Size(90, 20)
        Me.lbllname.TabIndex = 151
        Me.lbllname.Text = "Last Name:"
        '
        'txtmname
        '
        Me.txtmname.Location = New System.Drawing.Point(970, 223)
        Me.txtmname.Name = "txtmname"
        Me.txtmname.Size = New System.Drawing.Size(225, 26)
        Me.txtmname.TabIndex = 150
        '
        'lblmname
        '
        Me.lblmname.AutoSize = True
        Me.lblmname.BackColor = System.Drawing.Color.Transparent
        Me.lblmname.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.lblmname.Location = New System.Drawing.Point(866, 226)
        Me.lblmname.Name = "lblmname"
        Me.lblmname.Size = New System.Drawing.Size(105, 20)
        Me.lblmname.TabIndex = 149
        Me.lblmname.Text = "Middle Name:"
        '
        'lblfname
        '
        Me.lblfname.AutoSize = True
        Me.lblfname.BackColor = System.Drawing.Color.Transparent
        Me.lblfname.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.lblfname.Location = New System.Drawing.Point(879, 193)
        Me.lblfname.Name = "lblfname"
        Me.lblfname.Size = New System.Drawing.Size(90, 20)
        Me.lblfname.TabIndex = 147
        Me.lblfname.Text = "First Name:"
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel2.Controls.Add(Me.DataGridView1)
        Me.Panel2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel2.Location = New System.Drawing.Point(21, 113)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(792, 399)
        Me.Panel2.TabIndex = 146
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
        Me.DataGridView1.Size = New System.Drawing.Size(774, 382)
        Me.DataGridView1.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel1.Location = New System.Drawing.Point(20, 37)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1175, 58)
        Me.Panel1.TabIndex = 145
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel3.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Panel3.Location = New System.Drawing.Point(828, 113)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(367, 66)
        Me.Panel3.TabIndex = 166
        '
        'txtfname
        '
        Me.txtfname.Location = New System.Drawing.Point(970, 190)
        Me.txtfname.Name = "txtfname"
        Me.txtfname.Size = New System.Drawing.Size(225, 26)
        Me.txtfname.TabIndex = 148
        '
        'txtvcenter
        '
        Me.txtvcenter.Location = New System.Drawing.Point(970, 384)
        Me.txtvcenter.Name = "txtvcenter"
        Me.txtvcenter.Size = New System.Drawing.Size(225, 26)
        Me.txtvcenter.TabIndex = 169
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label2.Location = New System.Drawing.Point(848, 387)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(122, 20)
        Me.Label2.TabIndex = 168
        Me.Label2.Text = "Vaccine Center:"
        '
        'FrontlinerData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.VaccineDistrubution.My.Resources.Resources.Blue_Simple_Illustration_Covid_Pandemic_Vaccine_Medical_Presentation_Template__2_
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1214, 549)
        Me.Controls.Add(Me.txtvcenter)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.lblID)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnDelete)
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
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.txtfname)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrontlinerData"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Frontliner Data"
        Me.Panel2.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnBack As Button
    Friend WithEvents txtID As TextBox
    Friend WithEvents lblID As Label
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents txtcnumber As TextBox
    Friend WithEvents Label7 As Label
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
    Friend WithEvents Panel2 As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents txtfname As TextBox
    Friend WithEvents txtvcenter As TextBox
    Friend WithEvents Label2 As Label
End Class
