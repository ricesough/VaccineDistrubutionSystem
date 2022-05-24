<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewData
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ViewData))
        Me.btnBack = New System.Windows.Forms.Button()
        Me.pcPartial = New System.Windows.Forms.PictureBox()
        Me.PcFrontliner = New System.Windows.Forms.PictureBox()
        Me.pcBooster = New System.Windows.Forms.PictureBox()
        Me.pcCenter = New System.Windows.Forms.PictureBox()
        Me.pcUnvaccinated = New System.Windows.Forms.PictureBox()
        Me.pcFully = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.pcPartial, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PcFrontliner, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcBooster, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcCenter, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcUnvaccinated, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcFully, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnBack.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.btnBack.Location = New System.Drawing.Point(29, 586)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(180, 40)
        Me.btnBack.TabIndex = 0
        Me.btnBack.Text = "BACK"
        Me.btnBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnBack.UseVisualStyleBackColor = False
        Me.btnBack.UseWaitCursor = True
        '
        'pcPartial
        '
        Me.pcPartial.BackgroundImage = Global.VaccineDistrubution.My.Resources.Resources._3
        Me.pcPartial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pcPartial.Location = New System.Drawing.Point(9, 199)
        Me.pcPartial.Name = "pcPartial"
        Me.pcPartial.Size = New System.Drawing.Size(180, 180)
        Me.pcPartial.TabIndex = 3
        Me.pcPartial.TabStop = False
        '
        'PcFrontliner
        '
        Me.PcFrontliner.BackgroundImage = Global.VaccineDistrubution.My.Resources.Resources._7
        Me.PcFrontliner.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PcFrontliner.Location = New System.Drawing.Point(381, 13)
        Me.PcFrontliner.Name = "PcFrontliner"
        Me.PcFrontliner.Size = New System.Drawing.Size(180, 180)
        Me.PcFrontliner.TabIndex = 4
        Me.PcFrontliner.TabStop = False
        '
        'pcBooster
        '
        Me.pcBooster.BackgroundImage = Global.VaccineDistrubution.My.Resources.Resources._5
        Me.pcBooster.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pcBooster.Location = New System.Drawing.Point(195, 199)
        Me.pcBooster.Name = "pcBooster"
        Me.pcBooster.Size = New System.Drawing.Size(180, 180)
        Me.pcBooster.TabIndex = 2
        Me.pcBooster.TabStop = False
        '
        'pcCenter
        '
        Me.pcCenter.BackgroundImage = Global.VaccineDistrubution.My.Resources.Resources._6
        Me.pcCenter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pcCenter.Location = New System.Drawing.Point(381, 199)
        Me.pcCenter.Name = "pcCenter"
        Me.pcCenter.Size = New System.Drawing.Size(180, 180)
        Me.pcCenter.TabIndex = 5
        Me.pcCenter.TabStop = False
        '
        'pcUnvaccinated
        '
        Me.pcUnvaccinated.BackgroundImage = Global.VaccineDistrubution.My.Resources.Resources._2
        Me.pcUnvaccinated.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pcUnvaccinated.Location = New System.Drawing.Point(9, 13)
        Me.pcUnvaccinated.Name = "pcUnvaccinated"
        Me.pcUnvaccinated.Size = New System.Drawing.Size(180, 180)
        Me.pcUnvaccinated.TabIndex = 0
        Me.pcUnvaccinated.TabStop = False
        '
        'pcFully
        '
        Me.pcFully.BackgroundImage = Global.VaccineDistrubution.My.Resources.Resources._4
        Me.pcFully.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pcFully.Location = New System.Drawing.Point(195, 13)
        Me.pcFully.Name = "pcFully"
        Me.pcFully.Size = New System.Drawing.Size(180, 180)
        Me.pcFully.TabIndex = 1
        Me.pcFully.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel2.Controls.Add(Me.pcFully)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.pcUnvaccinated)
        Me.Panel2.Controls.Add(Me.pcCenter)
        Me.Panel2.Controls.Add(Me.pcBooster)
        Me.Panel2.Controls.Add(Me.PcFrontliner)
        Me.Panel2.Controls.Add(Me.pcPartial)
        Me.Panel2.Location = New System.Drawing.Point(539, 128)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(570, 433)
        Me.Panel2.TabIndex = 78
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label7.Location = New System.Drawing.Point(42, 390)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(491, 26)
        Me.Label7.TabIndex = 29
        Me.Label7.Text = "Select the image of the data set you want to view."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(99, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(891, 46)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "COVID-19 VACCINE DISTRIBUTION SYSTEM"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Location = New System.Drawing.Point(29, 128)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(492, 433)
        Me.Panel3.TabIndex = 79
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label2.Location = New System.Drawing.Point(90, 390)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(299, 26)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "We're keeping your data safe!"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.Window
        Me.Panel4.BackgroundImage = Global.VaccineDistrubution.My.Resources.Resources.ABOUT__1_
        Me.Panel4.Location = New System.Drawing.Point(9, 13)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(473, 366)
        Me.Panel4.TabIndex = 80
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel1.Location = New System.Drawing.Point(29, 24)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1080, 65)
        Me.Panel1.TabIndex = 77
        '
        'ViewData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange
        Me.BackgroundImage = Global.VaccineDistrubution.My.Resources.Resources.Blue_Simple_Illustration_Covid_Pandemic_Vaccine_Medical_Presentation_Template__5_
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1134, 653)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ViewData"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "VIEW DATA"
        CType(Me.pcPartial, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PcFrontliner, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcBooster, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcCenter, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcUnvaccinated, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcFully, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnBack As Button
    Friend WithEvents pcPartial As PictureBox
    Friend WithEvents PcFrontliner As PictureBox
    Friend WithEvents pcBooster As PictureBox
    Friend WithEvents pcCenter As PictureBox
    Friend WithEvents pcUnvaccinated As PictureBox
    Friend WithEvents pcFully As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
End Class
