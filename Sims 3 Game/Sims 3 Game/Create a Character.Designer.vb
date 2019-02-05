<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCas))
        Me.lblFirstState = New System.Windows.Forms.Label()
        Me.lblLastState = New System.Windows.Forms.Label()
        Me.lblNameState = New System.Windows.Forms.Label()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.lblGenderState = New System.Windows.Forms.Label()
        Me.btnMale = New System.Windows.Forms.Button()
        Me.btnFemale = New System.Windows.Forms.Button()
        Me.lblStatement = New System.Windows.Forms.Label()
        Me.lblChosen = New System.Windows.Forms.Label()
        Me.btnReady = New System.Windows.Forms.Button()
        Me.lblChoose = New System.Windows.Forms.Label()
        Me.picChoosenPerson = New System.Windows.Forms.PictureBox()
        Me.picPerson3 = New System.Windows.Forms.PictureBox()
        Me.picPerson2 = New System.Windows.Forms.PictureBox()
        Me.picPerson1 = New System.Windows.Forms.PictureBox()
        CType(Me.picChoosenPerson, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPerson3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPerson2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPerson1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblFirstState
        '
        Me.lblFirstState.AutoSize = True
        Me.lblFirstState.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.lblFirstState.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFirstState.ForeColor = System.Drawing.Color.White
        Me.lblFirstState.Location = New System.Drawing.Point(27, 92)
        Me.lblFirstState.Name = "lblFirstState"
        Me.lblFirstState.Size = New System.Drawing.Size(45, 18)
        Me.lblFirstState.TabIndex = 0
        Me.lblFirstState.Text = "First"
        '
        'lblLastState
        '
        Me.lblLastState.AutoSize = True
        Me.lblLastState.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.lblLastState.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLastState.ForeColor = System.Drawing.Color.White
        Me.lblLastState.Location = New System.Drawing.Point(167, 92)
        Me.lblLastState.Name = "lblLastState"
        Me.lblLastState.Size = New System.Drawing.Size(47, 18)
        Me.lblLastState.TabIndex = 1
        Me.lblLastState.Text = "Last "
        '
        'lblNameState
        '
        Me.lblNameState.AutoSize = True
        Me.lblNameState.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.lblNameState.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNameState.ForeColor = System.Drawing.Color.White
        Me.lblNameState.Location = New System.Drawing.Point(16, 49)
        Me.lblNameState.Name = "lblNameState"
        Me.lblNameState.Size = New System.Drawing.Size(53, 18)
        Me.lblNameState.TabIndex = 2
        Me.lblNameState.Text = "Name:"
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(27, 113)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(110, 20)
        Me.txtFirstName.TabIndex = 3
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(167, 113)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(110, 20)
        Me.txtLastName.TabIndex = 4
        '
        'lblGenderState
        '
        Me.lblGenderState.AutoSize = True
        Me.lblGenderState.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.lblGenderState.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGenderState.ForeColor = System.Drawing.Color.White
        Me.lblGenderState.Location = New System.Drawing.Point(16, 181)
        Me.lblGenderState.Name = "lblGenderState"
        Me.lblGenderState.Size = New System.Drawing.Size(65, 18)
        Me.lblGenderState.TabIndex = 5
        Me.lblGenderState.Text = "Gender:"
        '
        'btnMale
        '
        Me.btnMale.BackColor = System.Drawing.Color.DarkGreen
        Me.btnMale.Font = New System.Drawing.Font("Modern No. 20", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMale.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnMale.Location = New System.Drawing.Point(30, 212)
        Me.btnMale.Name = "btnMale"
        Me.btnMale.Size = New System.Drawing.Size(106, 36)
        Me.btnMale.TabIndex = 6
        Me.btnMale.Text = "Male"
        Me.btnMale.UseVisualStyleBackColor = False
        '
        'btnFemale
        '
        Me.btnFemale.BackColor = System.Drawing.Color.DarkGreen
        Me.btnFemale.Font = New System.Drawing.Font("Modern No. 20", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFemale.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnFemale.Location = New System.Drawing.Point(167, 212)
        Me.btnFemale.Name = "btnFemale"
        Me.btnFemale.Size = New System.Drawing.Size(106, 36)
        Me.btnFemale.TabIndex = 7
        Me.btnFemale.Text = "Female"
        Me.btnFemale.UseVisualStyleBackColor = False
        '
        'lblStatement
        '
        Me.lblStatement.AutoSize = True
        Me.lblStatement.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.lblStatement.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatement.ForeColor = System.Drawing.Color.White
        Me.lblStatement.Location = New System.Drawing.Point(341, 9)
        Me.lblStatement.Name = "lblStatement"
        Me.lblStatement.Size = New System.Drawing.Size(143, 18)
        Me.lblStatement.TabIndex = 11
        Me.lblStatement.Text = "Create a Character"
        '
        'lblChosen
        '
        Me.lblChosen.AutoSize = True
        Me.lblChosen.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.lblChosen.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChosen.ForeColor = System.Drawing.Color.White
        Me.lblChosen.Location = New System.Drawing.Point(631, 76)
        Me.lblChosen.Name = "lblChosen"
        Me.lblChosen.Size = New System.Drawing.Size(136, 18)
        Me.lblChosen.TabIndex = 13
        Me.lblChosen.Text = "Chosen Character"
        Me.lblChosen.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnReady
        '
        Me.btnReady.BackColor = System.Drawing.Color.DarkGreen
        Me.btnReady.Font = New System.Drawing.Font("Modern No. 20", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReady.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnReady.Location = New System.Drawing.Point(344, 113)
        Me.btnReady.Name = "btnReady"
        Me.btnReady.Size = New System.Drawing.Size(164, 86)
        Me.btnReady.TabIndex = 14
        Me.btnReady.Text = "Ready to Play!"
        Me.btnReady.UseVisualStyleBackColor = False
        '
        'lblChoose
        '
        Me.lblChoose.AutoSize = True
        Me.lblChoose.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.lblChoose.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChoose.ForeColor = System.Drawing.Color.White
        Me.lblChoose.Location = New System.Drawing.Point(27, 275)
        Me.lblChoose.Name = "lblChoose"
        Me.lblChoose.Size = New System.Drawing.Size(292, 18)
        Me.lblChoose.TabIndex = 16
        Me.lblChoose.Text = "Select one of the following characters:"
        Me.lblChoose.Visible = False
        '
        'picChoosenPerson
        '
        Me.picChoosenPerson.BackColor = System.Drawing.Color.Honeydew
        Me.picChoosenPerson.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picChoosenPerson.Location = New System.Drawing.Point(567, 97)
        Me.picChoosenPerson.Name = "picChoosenPerson"
        Me.picChoosenPerson.Size = New System.Drawing.Size(252, 408)
        Me.picChoosenPerson.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picChoosenPerson.TabIndex = 12
        Me.picChoosenPerson.TabStop = False
        '
        'picPerson3
        '
        Me.picPerson3.BackColor = System.Drawing.Color.Honeydew
        Me.picPerson3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picPerson3.Location = New System.Drawing.Point(355, 307)
        Me.picPerson3.Name = "picPerson3"
        Me.picPerson3.Size = New System.Drawing.Size(121, 215)
        Me.picPerson3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picPerson3.TabIndex = 10
        Me.picPerson3.TabStop = False
        '
        'picPerson2
        '
        Me.picPerson2.BackColor = System.Drawing.Color.Honeydew
        Me.picPerson2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picPerson2.Location = New System.Drawing.Point(190, 307)
        Me.picPerson2.Name = "picPerson2"
        Me.picPerson2.Size = New System.Drawing.Size(121, 215)
        Me.picPerson2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picPerson2.TabIndex = 9
        Me.picPerson2.TabStop = False
        '
        'picPerson1
        '
        Me.picPerson1.BackColor = System.Drawing.Color.Honeydew
        Me.picPerson1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picPerson1.Location = New System.Drawing.Point(27, 307)
        Me.picPerson1.Name = "picPerson1"
        Me.picPerson1.Size = New System.Drawing.Size(121, 215)
        Me.picPerson1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picPerson1.TabIndex = 8
        Me.picPerson1.TabStop = False
        '
        'frmCas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(894, 587)
        Me.Controls.Add(Me.lblChoose)
        Me.Controls.Add(Me.btnReady)
        Me.Controls.Add(Me.lblChosen)
        Me.Controls.Add(Me.picChoosenPerson)
        Me.Controls.Add(Me.lblStatement)
        Me.Controls.Add(Me.picPerson3)
        Me.Controls.Add(Me.picPerson2)
        Me.Controls.Add(Me.picPerson1)
        Me.Controls.Add(Me.btnFemale)
        Me.Controls.Add(Me.btnMale)
        Me.Controls.Add(Me.lblGenderState)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.txtFirstName)
        Me.Controls.Add(Me.lblNameState)
        Me.Controls.Add(Me.lblLastState)
        Me.Controls.Add(Me.lblFirstState)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCas"
        Me.Text = "Create a Character"
        CType(Me.picChoosenPerson, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPerson3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPerson2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPerson1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblFirstState As System.Windows.Forms.Label
    Friend WithEvents lblLastState As System.Windows.Forms.Label
    Friend WithEvents lblNameState As System.Windows.Forms.Label
    Friend WithEvents txtFirstName As System.Windows.Forms.TextBox
    Friend WithEvents txtLastName As System.Windows.Forms.TextBox
    Friend WithEvents lblGenderState As System.Windows.Forms.Label
    Friend WithEvents btnMale As System.Windows.Forms.Button
    Friend WithEvents btnFemale As System.Windows.Forms.Button
    Friend WithEvents picPerson1 As System.Windows.Forms.PictureBox
    Friend WithEvents picPerson2 As System.Windows.Forms.PictureBox
    Friend WithEvents picPerson3 As System.Windows.Forms.PictureBox
    Friend WithEvents lblStatement As System.Windows.Forms.Label
    Friend WithEvents picChoosenPerson As System.Windows.Forms.PictureBox
    Friend WithEvents lblChosen As System.Windows.Forms.Label
    Friend WithEvents btnReady As System.Windows.Forms.Button
    Friend WithEvents lblChoose As System.Windows.Forms.Label
End Class
