<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVacation
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVacation))
        Me.btnFrance = New System.Windows.Forms.Button()
        Me.btnChina = New System.Windows.Forms.Button()
        Me.btnEgypt = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnFrance
        '
        Me.btnFrance.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnFrance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFrance.Location = New System.Drawing.Point(40, 137)
        Me.btnFrance.Name = "btnFrance"
        Me.btnFrance.Size = New System.Drawing.Size(121, 54)
        Me.btnFrance.TabIndex = 0
        Me.btnFrance.Text = "France"
        Me.btnFrance.UseVisualStyleBackColor = False
        '
        'btnChina
        '
        Me.btnChina.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnChina.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChina.Location = New System.Drawing.Point(167, 137)
        Me.btnChina.Name = "btnChina"
        Me.btnChina.Size = New System.Drawing.Size(121, 54)
        Me.btnChina.TabIndex = 1
        Me.btnChina.Text = "China"
        Me.btnChina.UseVisualStyleBackColor = False
        '
        'btnEgypt
        '
        Me.btnEgypt.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnEgypt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEgypt.Location = New System.Drawing.Point(294, 137)
        Me.btnEgypt.Name = "btnEgypt"
        Me.btnEgypt.Size = New System.Drawing.Size(121, 54)
        Me.btnEgypt.TabIndex = 2
        Me.btnEgypt.Text = "Egypt"
        Me.btnEgypt.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(33, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(382, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Choose where you would like to go on vacation"
        '
        'frmVacation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(465, 309)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnEgypt)
        Me.Controls.Add(Me.btnChina)
        Me.Controls.Add(Me.btnFrance)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmVacation"
        Me.Text = "Vacation"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnFrance As System.Windows.Forms.Button
    Friend WithEvents btnChina As System.Windows.Forms.Button
    Friend WithEvents btnEgypt As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
