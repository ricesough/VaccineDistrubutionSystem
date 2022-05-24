<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Status
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Status))
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnUnvaccinated = New System.Windows.Forms.Button()
        Me.btnPartiallyVaccinated = New System.Windows.Forms.Button()
        Me.btnFullyVaccinated = New System.Windows.Forms.Button()
        Me.btnBooster = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(217, 63)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(380, 20)
        Me.Label7.TabIndex = 34
        Me.Label7.Text = "Select vaccination status to proceed to the next part."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Teal
        Me.Label1.Location = New System.Drawing.Point(288, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(256, 25)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "VACCINATION STATUS"
        '
        'btnUnvaccinated
        '
        Me.btnUnvaccinated.BackColor = System.Drawing.Color.Transparent
        Me.btnUnvaccinated.BackgroundImage = CType(resources.GetObject("btnUnvaccinated.BackgroundImage"), System.Drawing.Image)
        Me.btnUnvaccinated.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnUnvaccinated.Location = New System.Drawing.Point(236, 104)
        Me.btnUnvaccinated.Name = "btnUnvaccinated"
        Me.btnUnvaccinated.Size = New System.Drawing.Size(168, 170)
        Me.btnUnvaccinated.TabIndex = 35
        Me.btnUnvaccinated.UseVisualStyleBackColor = False
        '
        'btnPartiallyVaccinated
        '
        Me.btnPartiallyVaccinated.BackColor = System.Drawing.Color.Transparent
        Me.btnPartiallyVaccinated.BackgroundImage = CType(resources.GetObject("btnPartiallyVaccinated.BackgroundImage"), System.Drawing.Image)
        Me.btnPartiallyVaccinated.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnPartiallyVaccinated.Location = New System.Drawing.Point(412, 104)
        Me.btnPartiallyVaccinated.Name = "btnPartiallyVaccinated"
        Me.btnPartiallyVaccinated.Size = New System.Drawing.Size(168, 170)
        Me.btnPartiallyVaccinated.TabIndex = 36
        Me.btnPartiallyVaccinated.UseVisualStyleBackColor = False
        '
        'btnFullyVaccinated
        '
        Me.btnFullyVaccinated.BackColor = System.Drawing.Color.Transparent
        Me.btnFullyVaccinated.BackgroundImage = CType(resources.GetObject("btnFullyVaccinated.BackgroundImage"), System.Drawing.Image)
        Me.btnFullyVaccinated.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnFullyVaccinated.Location = New System.Drawing.Point(236, 283)
        Me.btnFullyVaccinated.Name = "btnFullyVaccinated"
        Me.btnFullyVaccinated.Size = New System.Drawing.Size(168, 170)
        Me.btnFullyVaccinated.TabIndex = 37
        Me.btnFullyVaccinated.UseVisualStyleBackColor = False
        '
        'btnBooster
        '
        Me.btnBooster.BackColor = System.Drawing.Color.Transparent
        Me.btnBooster.BackgroundImage = CType(resources.GetObject("btnBooster.BackgroundImage"), System.Drawing.Image)
        Me.btnBooster.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBooster.Location = New System.Drawing.Point(412, 283)
        Me.btnBooster.Name = "btnBooster"
        Me.btnBooster.Size = New System.Drawing.Size(168, 170)
        Me.btnBooster.TabIndex = 38
        Me.btnBooster.UseVisualStyleBackColor = False
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnBack.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.btnBack.Location = New System.Drawing.Point(38, 470)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(121, 38)
        Me.btnBack.TabIndex = 53
        Me.btnBack.Text = "BACK"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'Status
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.VaccineDistrubution.My.Resources.Resources.Blue_Simple_Illustration_Covid_Pandemic_Vaccine_Medical_Presentation_Template__5_
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(805, 539)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnBooster)
        Me.Controls.Add(Me.btnFullyVaccinated)
        Me.Controls.Add(Me.btnPartiallyVaccinated)
        Me.Controls.Add(Me.btnUnvaccinated)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Status"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Vaccination Status"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label7 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnUnvaccinated As Button
    Friend WithEvents btnPartiallyVaccinated As Button
    Friend WithEvents btnFullyVaccinated As Button
    Friend WithEvents btnBooster As Button
    Friend WithEvents btnBack As Button
End Class
