<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Center
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Center))
        Me.btnStart = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtVCnumber = New System.Windows.Forms.TextBox()
        Me.lblVCnumber = New System.Windows.Forms.Label()
        Me.txtVCaddress = New System.Windows.Forms.TextBox()
        Me.lblVCaddress = New System.Windows.Forms.Label()
        Me.txtVCname = New System.Windows.Forms.TextBox()
        Me.lblVCname = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnStart
        '
        Me.btnStart.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnStart.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.btnStart.Location = New System.Drawing.Point(589, 404)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(121, 38)
        Me.btnStart.TabIndex = 31
        Me.btnStart.Text = "NEXT"
        Me.btnStart.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(166, 97)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(479, 20)
        Me.Label7.TabIndex = 30
        Me.Label7.Text = "Please make sure that the details you entered are true and correct."
        '
        'txtVCnumber
        '
        Me.txtVCnumber.Location = New System.Drawing.Point(314, 249)
        Me.txtVCnumber.Name = "txtVCnumber"
        Me.txtVCnumber.Size = New System.Drawing.Size(328, 26)
        Me.txtVCnumber.TabIndex = 23
        '
        'lblVCnumber
        '
        Me.lblVCnumber.AutoSize = True
        Me.lblVCnumber.BackColor = System.Drawing.Color.Transparent
        Me.lblVCnumber.ForeColor = System.Drawing.Color.Teal
        Me.lblVCnumber.Location = New System.Drawing.Point(184, 252)
        Me.lblVCnumber.Name = "lblVCnumber"
        Me.lblVCnumber.Size = New System.Drawing.Size(129, 20)
        Me.lblVCnumber.TabIndex = 22
        Me.lblVCnumber.Text = "Contact Number:"
        '
        'txtVCaddress
        '
        Me.txtVCaddress.Location = New System.Drawing.Point(314, 209)
        Me.txtVCaddress.Name = "txtVCaddress"
        Me.txtVCaddress.Size = New System.Drawing.Size(328, 26)
        Me.txtVCaddress.TabIndex = 21
        '
        'lblVCaddress
        '
        Me.lblVCaddress.AutoSize = True
        Me.lblVCaddress.BackColor = System.Drawing.Color.Transparent
        Me.lblVCaddress.ForeColor = System.Drawing.Color.Teal
        Me.lblVCaddress.Location = New System.Drawing.Point(241, 212)
        Me.lblVCaddress.Name = "lblVCaddress"
        Me.lblVCaddress.Size = New System.Drawing.Size(72, 20)
        Me.lblVCaddress.TabIndex = 20
        Me.lblVCaddress.Text = "Address:"
        '
        'txtVCname
        '
        Me.txtVCname.Location = New System.Drawing.Point(314, 167)
        Me.txtVCname.Name = "txtVCname"
        Me.txtVCname.Size = New System.Drawing.Size(328, 26)
        Me.txtVCname.TabIndex = 19
        '
        'lblVCname
        '
        Me.lblVCname.AutoSize = True
        Me.lblVCname.BackColor = System.Drawing.Color.Transparent
        Me.lblVCname.ForeColor = System.Drawing.Color.Teal
        Me.lblVCname.Location = New System.Drawing.Point(120, 170)
        Me.lblVCname.Name = "lblVCname"
        Me.lblVCname.Size = New System.Drawing.Size(194, 20)
        Me.lblVCname.TabIndex = 18
        Me.lblVCname.Text = "Vaccination Center Name:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Teal
        Me.Label1.Location = New System.Drawing.Point(237, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(352, 25)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "VACCINATION CENTER DETAILS"
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnBack.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.btnBack.Location = New System.Drawing.Point(104, 404)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(121, 38)
        Me.btnBack.TabIndex = 53
        Me.btnBack.Text = "BACK"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'Center
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.VaccineDistrubution.My.Resources.Resources.Blue_Simple_Illustration_Covid_Pandemic_Vaccine_Medical_Presentation_Template__1_
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(805, 494)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtVCnumber)
        Me.Controls.Add(Me.lblVCnumber)
        Me.Controls.Add(Me.txtVCaddress)
        Me.Controls.Add(Me.lblVCaddress)
        Me.Controls.Add(Me.txtVCname)
        Me.Controls.Add(Me.lblVCname)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Center"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Vaccination Center Details"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnStart As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents txtVCnumber As TextBox
    Friend WithEvents lblVCnumber As Label
    Friend WithEvents txtVCaddress As TextBox
    Friend WithEvents lblVCaddress As Label
    Friend WithEvents txtVCname As TextBox
    Friend WithEvents lblVCname As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnBack As Button
End Class
