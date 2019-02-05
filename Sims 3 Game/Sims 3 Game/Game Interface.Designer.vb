<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGameInterface
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGameInterface))
        Me.timerAge = New System.Windows.Forms.Timer(Me.components)
        Me.timerBladder = New System.Windows.Forms.Timer(Me.components)
        Me.timerHunger = New System.Windows.Forms.Timer(Me.components)
        Me.timerHygiene = New System.Windows.Forms.Timer(Me.components)
        Me.timerEnergy = New System.Windows.Forms.Timer(Me.components)
        Me.timerTime = New System.Windows.Forms.Timer(Me.components)
        Me.timerPlayerMove = New System.Windows.Forms.Timer(Me.components)
        Me.prgBarAge = New System.Windows.Forms.ProgressBar()
        Me.prgBarHunger = New System.Windows.Forms.ProgressBar()
        Me.prgBarBladder = New System.Windows.Forms.ProgressBar()
        Me.prgHygiene = New System.Windows.Forms.ProgressBar()
        Me.prgBarEnergy = New System.Windows.Forms.ProgressBar()
        Me.lblBlad = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblHygen = New System.Windows.Forms.Label()
        Me.lblEnergy = New System.Windows.Forms.Label()
        Me.lblAge = New System.Windows.Forms.Label()
        Me.lblJob = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblAgeByName = New System.Windows.Forms.Label()
        Me.lblStatement = New System.Windows.Forms.Label()
        Me.btnEatRestur = New System.Windows.Forms.Button()
        Me.btnExitRest = New System.Windows.Forms.Button()
        Me.lblMoney = New System.Windows.Forms.Label()
        Me.timerJob = New System.Windows.Forms.Timer(Me.components)
        Me.btnpoliceexit = New System.Windows.Forms.Button()
        Me.btnPark = New System.Windows.Forms.Button()
        Me.btnExitPark = New System.Windows.Forms.Button()
        Me.btnWorkRestur = New System.Windows.Forms.Button()
        Me.btnWorkPolice = New System.Windows.Forms.Button()
        Me.btnExitGrocer = New System.Windows.Forms.Button()
        Me.btnBuyGrocery = New System.Windows.Forms.Button()
        Me.btnWorkGrocery = New System.Windows.Forms.Button()
        Me.btnWatchMovie = New System.Windows.Forms.Button()
        Me.btnExitMovie = New System.Windows.Forms.Button()
        Me.btnWorkMovie = New System.Windows.Forms.Button()
        Me.btnChangeName = New System.Windows.Forms.Button()
        Me.btnGetMarried = New System.Windows.Forms.Button()
        Me.btnExitCityHall = New System.Windows.Forms.Button()
        Me.btnWorkCityHall = New System.Windows.Forms.Button()
        Me.btnHaveChildren = New System.Windows.Forms.Button()
        Me.btnExitHospital = New System.Windows.Forms.Button()
        Me.btnExitSchool = New System.Windows.Forms.Button()
        Me.btnWorkSchool = New System.Windows.Forms.Button()
        Me.btnSwim = New System.Windows.Forms.Button()
        Me.btnExitPool = New System.Windows.Forms.Button()
        Me.btnWorkLifeguard = New System.Windows.Forms.Button()
        Me.btnWorkWriter = New System.Windows.Forms.Button()
        Me.btnExitBookStore = New System.Windows.Forms.Button()
        Me.picSpouse = New System.Windows.Forms.PictureBox()
        Me.btnPause = New System.Windows.Forms.PictureBox()
        Me.picPlayer = New System.Windows.Forms.PictureBox()
        Me.picHouse5 = New System.Windows.Forms.PictureBox()
        Me.piccharacter = New System.Windows.Forms.PictureBox()
        Me.picHouse3 = New System.Windows.Forms.PictureBox()
        Me.picPolice = New System.Windows.Forms.PictureBox()
        Me.picGym = New System.Windows.Forms.PictureBox()
        Me.picMovie = New System.Windows.Forms.PictureBox()
        Me.picBookStore = New System.Windows.Forms.PictureBox()
        Me.picSwimmingPool = New System.Windows.Forms.PictureBox()
        Me.picHouse2 = New System.Windows.Forms.PictureBox()
        Me.picRestaur = New System.Windows.Forms.PictureBox()
        Me.picGroceryStore = New System.Windows.Forms.PictureBox()
        Me.picHouse1 = New System.Windows.Forms.PictureBox()
        Me.picSchool = New System.Windows.Forms.PictureBox()
        Me.picCityHall = New System.Windows.Forms.PictureBox()
        Me.picCentralPark = New System.Windows.Forms.PictureBox()
        Me.picTaskBar = New System.Windows.Forms.PictureBox()
        Me.HouseDiamond1 = New System.Windows.Forms.PictureBox()
        Me.HouseDiamond2 = New System.Windows.Forms.PictureBox()
        Me.HouseDiamond3 = New System.Windows.Forms.PictureBox()
        Me.HouseDiamond4 = New System.Windows.Forms.PictureBox()
        Me.HouseDiamond5 = New System.Windows.Forms.PictureBox()
        Me.lblSpouseName = New System.Windows.Forms.Label()
        Me.btnBathroom1 = New System.Windows.Forms.Button()
        Me.btnEat1 = New System.Windows.Forms.Button()
        Me.btnShower1 = New System.Windows.Forms.Button()
        Me.btnBed1 = New System.Windows.Forms.Button()
        Me.btnBed2 = New System.Windows.Forms.Button()
        Me.btnShower2 = New System.Windows.Forms.Button()
        Me.btnEat2 = New System.Windows.Forms.Button()
        Me.btnBathroom2 = New System.Windows.Forms.Button()
        Me.btnBed3 = New System.Windows.Forms.Button()
        Me.btnShower3 = New System.Windows.Forms.Button()
        Me.btnEat3 = New System.Windows.Forms.Button()
        Me.btnBathroom3 = New System.Windows.Forms.Button()
        Me.btnFinishedPlaying = New System.Windows.Forms.Label()
        Me.btnExit1 = New System.Windows.Forms.Button()
        Me.btnExit2 = New System.Windows.Forms.Button()
        Me.btnExit3 = New System.Windows.Forms.Button()
        Me.btnExit4 = New System.Windows.Forms.Button()
        Me.btnBed4 = New System.Windows.Forms.Button()
        Me.btnShower4 = New System.Windows.Forms.Button()
        Me.btnEat4 = New System.Windows.Forms.Button()
        Me.btnBathroom4 = New System.Windows.Forms.Button()
        Me.btnExit5 = New System.Windows.Forms.Button()
        Me.btnBed5 = New System.Windows.Forms.Button()
        Me.btnShower5 = New System.Windows.Forms.Button()
        Me.btnEat5 = New System.Windows.Forms.Button()
        Me.btnBathroom5 = New System.Windows.Forms.Button()
        Me.lblGroceries = New System.Windows.Forms.Label()
        Me.picChild1 = New System.Windows.Forms.PictureBox()
        Me.picChild2 = New System.Windows.Forms.PictureBox()
        Me.picChild3 = New System.Windows.Forms.PictureBox()
        Me.lblChild1Name = New System.Windows.Forms.Label()
        Me.lblChild2Name = New System.Windows.Forms.Label()
        Me.lblChild3Name = New System.Windows.Forms.Label()
        Me.picBackground = New System.Windows.Forms.PictureBox()
        Me.btnRobBank = New System.Windows.Forms.Button()
        Me.btnVacation = New System.Windows.Forms.Button()
        Me.btnLottery = New System.Windows.Forms.Button()
        Me.btnExitSelf = New System.Windows.Forms.Button()
        Me.btnHelp = New System.Windows.Forms.Label()
        Me.pictopboundary = New System.Windows.Forms.PictureBox()
        Me.picRightBoundary = New System.Windows.Forms.PictureBox()
        Me.picBoundaryLeft = New System.Windows.Forms.PictureBox()
        Me.picHouse4New = New System.Windows.Forms.PictureBox()
        Me.btnClubbing = New System.Windows.Forms.Button()
        Me.lblHelpMoving = New System.Windows.Forms.Label()
        Me.tmrCheckMoney = New System.Windows.Forms.Timer(Me.components)
        CType(Me.picSpouse, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnPause, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPlayer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picHouse5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.piccharacter, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picHouse3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPolice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picGym, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMovie, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBookStore, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSwimmingPool, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picHouse2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picRestaur, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picGroceryStore, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picHouse1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSchool, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCityHall, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCentralPark, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picTaskBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HouseDiamond1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HouseDiamond2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HouseDiamond3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HouseDiamond4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HouseDiamond5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picChild1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picChild2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picChild3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBackground, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictopboundary, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picRightBoundary, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBoundaryLeft, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picHouse4New, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'timerAge
        '
        Me.timerAge.Interval = 1500
        '
        'timerBladder
        '
        Me.timerBladder.Interval = 2000
        '
        'timerHunger
        '
        Me.timerHunger.Interval = 2400
        '
        'timerHygiene
        '
        Me.timerHygiene.Interval = 3000
        '
        'timerEnergy
        '
        Me.timerEnergy.Interval = 3000
        '
        'timerTime
        '
        Me.timerTime.Interval = 1000
        '
        'timerPlayerMove
        '
        Me.timerPlayerMove.Interval = 1
        '
        'prgBarAge
        '
        Me.prgBarAge.Location = New System.Drawing.Point(886, 706)
        Me.prgBarAge.Name = "prgBarAge"
        Me.prgBarAge.Size = New System.Drawing.Size(100, 23)
        Me.prgBarAge.TabIndex = 0
        '
        'prgBarHunger
        '
        Me.prgBarHunger.Location = New System.Drawing.Point(1002, 728)
        Me.prgBarHunger.Name = "prgBarHunger"
        Me.prgBarHunger.Size = New System.Drawing.Size(100, 23)
        Me.prgBarHunger.TabIndex = 1
        '
        'prgBarBladder
        '
        Me.prgBarBladder.Location = New System.Drawing.Point(1002, 684)
        Me.prgBarBladder.Name = "prgBarBladder"
        Me.prgBarBladder.Size = New System.Drawing.Size(100, 23)
        Me.prgBarBladder.TabIndex = 2
        '
        'prgHygiene
        '
        Me.prgHygiene.Location = New System.Drawing.Point(1127, 684)
        Me.prgHygiene.Name = "prgHygiene"
        Me.prgHygiene.Size = New System.Drawing.Size(100, 23)
        Me.prgHygiene.TabIndex = 6
        '
        'prgBarEnergy
        '
        Me.prgBarEnergy.Location = New System.Drawing.Point(1127, 728)
        Me.prgBarEnergy.Name = "prgBarEnergy"
        Me.prgBarEnergy.Size = New System.Drawing.Size(100, 23)
        Me.prgBarEnergy.TabIndex = 7
        '
        'lblBlad
        '
        Me.lblBlad.AutoSize = True
        Me.lblBlad.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblBlad.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBlad.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblBlad.Location = New System.Drawing.Point(1026, 664)
        Me.lblBlad.Name = "lblBlad"
        Me.lblBlad.Size = New System.Drawing.Size(56, 16)
        Me.lblBlad.TabIndex = 8
        Me.lblBlad.Text = "Bladder"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(1026, 709)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 16)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Hunger"
        '
        'lblHygen
        '
        Me.lblHygen.AutoSize = True
        Me.lblHygen.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblHygen.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHygen.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblHygen.Location = New System.Drawing.Point(1154, 664)
        Me.lblHygen.Name = "lblHygen"
        Me.lblHygen.Size = New System.Drawing.Size(60, 16)
        Me.lblHygen.TabIndex = 10
        Me.lblHygen.Text = "Hygiene"
        '
        'lblEnergy
        '
        Me.lblEnergy.AutoSize = True
        Me.lblEnergy.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblEnergy.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEnergy.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblEnergy.Location = New System.Drawing.Point(1154, 709)
        Me.lblEnergy.Name = "lblEnergy"
        Me.lblEnergy.Size = New System.Drawing.Size(53, 16)
        Me.lblEnergy.TabIndex = 11
        Me.lblEnergy.Text = "Energy"
        '
        'lblAge
        '
        Me.lblAge.AutoSize = True
        Me.lblAge.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblAge.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAge.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblAge.Location = New System.Drawing.Point(920, 684)
        Me.lblAge.Name = "lblAge"
        Me.lblAge.Size = New System.Drawing.Size(33, 16)
        Me.lblAge.TabIndex = 12
        Me.lblAge.Text = "Age"
        '
        'lblJob
        '
        Me.lblJob.AutoSize = True
        Me.lblJob.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblJob.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJob.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblJob.Location = New System.Drawing.Point(707, 670)
        Me.lblJob.Name = "lblJob"
        Me.lblJob.Size = New System.Drawing.Size(36, 16)
        Me.lblJob.TabIndex = 13
        Me.lblJob.Text = "Job:"
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblTime.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblTime.Location = New System.Drawing.Point(614, 656)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(46, 16)
        Me.lblTime.TabIndex = 14
        Me.lblTime.Text = "10:03"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblName.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblName.Location = New System.Drawing.Point(31, 764)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(50, 16)
        Me.lblName.TabIndex = 17
        Me.lblName.Text = "Name:"
        '
        'lblAgeByName
        '
        Me.lblAgeByName.AutoSize = True
        Me.lblAgeByName.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblAgeByName.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAgeByName.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblAgeByName.Location = New System.Drawing.Point(31, 788)
        Me.lblAgeByName.Name = "lblAgeByName"
        Me.lblAgeByName.Size = New System.Drawing.Size(39, 16)
        Me.lblAgeByName.TabIndex = 18
        Me.lblAgeByName.Text = "Age:"
        '
        'lblStatement
        '
        Me.lblStatement.AutoSize = True
        Me.lblStatement.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblStatement.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatement.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblStatement.Location = New System.Drawing.Point(476, 656)
        Me.lblStatement.Name = "lblStatement"
        Me.lblStatement.Size = New System.Drawing.Size(132, 16)
        Me.lblStatement.TabIndex = 20
        Me.lblStatement.Text = "Total Time Played:"
        '
        'btnEatRestur
        '
        Me.btnEatRestur.BackColor = System.Drawing.Color.Honeydew
        Me.btnEatRestur.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEatRestur.ForeColor = System.Drawing.Color.DarkGreen
        Me.btnEatRestur.Location = New System.Drawing.Point(661, 119)
        Me.btnEatRestur.Name = "btnEatRestur"
        Me.btnEatRestur.Size = New System.Drawing.Size(115, 33)
        Me.btnEatRestur.TabIndex = 24
        Me.btnEatRestur.Text = "Eat Dinner $25"
        Me.btnEatRestur.UseVisualStyleBackColor = False
        Me.btnEatRestur.Visible = False
        '
        'btnExitRest
        '
        Me.btnExitRest.BackColor = System.Drawing.Color.Honeydew
        Me.btnExitRest.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExitRest.ForeColor = System.Drawing.Color.DarkGreen
        Me.btnExitRest.Location = New System.Drawing.Point(661, 155)
        Me.btnExitRest.Name = "btnExitRest"
        Me.btnExitRest.Size = New System.Drawing.Size(115, 33)
        Me.btnExitRest.TabIndex = 25
        Me.btnExitRest.Text = "Exit"
        Me.btnExitRest.UseVisualStyleBackColor = False
        Me.btnExitRest.Visible = False
        '
        'lblMoney
        '
        Me.lblMoney.AutoSize = True
        Me.lblMoney.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblMoney.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMoney.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblMoney.Location = New System.Drawing.Point(707, 706)
        Me.lblMoney.Name = "lblMoney"
        Me.lblMoney.Size = New System.Drawing.Size(57, 16)
        Me.lblMoney.TabIndex = 26
        Me.lblMoney.Text = "Money:"
        '
        'timerJob
        '
        Me.timerJob.Interval = 1000
        '
        'btnpoliceexit
        '
        Me.btnpoliceexit.BackColor = System.Drawing.Color.Honeydew
        Me.btnpoliceexit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnpoliceexit.ForeColor = System.Drawing.Color.DarkGreen
        Me.btnpoliceexit.Location = New System.Drawing.Point(386, 148)
        Me.btnpoliceexit.Name = "btnpoliceexit"
        Me.btnpoliceexit.Size = New System.Drawing.Size(99, 33)
        Me.btnpoliceexit.TabIndex = 31
        Me.btnpoliceexit.Text = "Exit"
        Me.btnpoliceexit.UseVisualStyleBackColor = False
        Me.btnpoliceexit.Visible = False
        '
        'btnPark
        '
        Me.btnPark.BackColor = System.Drawing.Color.Honeydew
        Me.btnPark.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPark.ForeColor = System.Drawing.Color.DarkGreen
        Me.btnPark.Location = New System.Drawing.Point(373, 320)
        Me.btnPark.Name = "btnPark"
        Me.btnPark.Size = New System.Drawing.Size(218, 33)
        Me.btnPark.TabIndex = 32
        Me.btnPark.Text = "Visit Park"
        Me.btnPark.UseVisualStyleBackColor = False
        Me.btnPark.Visible = False
        '
        'btnExitPark
        '
        Me.btnExitPark.BackColor = System.Drawing.Color.Honeydew
        Me.btnExitPark.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExitPark.ForeColor = System.Drawing.Color.DarkGreen
        Me.btnExitPark.Location = New System.Drawing.Point(373, 358)
        Me.btnExitPark.Name = "btnExitPark"
        Me.btnExitPark.Size = New System.Drawing.Size(218, 33)
        Me.btnExitPark.TabIndex = 33
        Me.btnExitPark.Text = "Exit"
        Me.btnExitPark.UseVisualStyleBackColor = False
        Me.btnExitPark.Visible = False
        '
        'btnWorkRestur
        '
        Me.btnWorkRestur.BackColor = System.Drawing.Color.Honeydew
        Me.btnWorkRestur.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnWorkRestur.ForeColor = System.Drawing.Color.DarkGreen
        Me.btnWorkRestur.Location = New System.Drawing.Point(661, 192)
        Me.btnWorkRestur.Name = "btnWorkRestur"
        Me.btnWorkRestur.Size = New System.Drawing.Size(115, 33)
        Me.btnWorkRestur.TabIndex = 34
        Me.btnWorkRestur.Text = "Go to Work"
        Me.btnWorkRestur.UseVisualStyleBackColor = False
        Me.btnWorkRestur.Visible = False
        '
        'btnWorkPolice
        '
        Me.btnWorkPolice.BackColor = System.Drawing.Color.Honeydew
        Me.btnWorkPolice.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnWorkPolice.ForeColor = System.Drawing.Color.DarkGreen
        Me.btnWorkPolice.Location = New System.Drawing.Point(386, 187)
        Me.btnWorkPolice.Name = "btnWorkPolice"
        Me.btnWorkPolice.Size = New System.Drawing.Size(99, 33)
        Me.btnWorkPolice.TabIndex = 35
        Me.btnWorkPolice.Text = "Go to Work"
        Me.btnWorkPolice.UseVisualStyleBackColor = False
        Me.btnWorkPolice.Visible = False
        '
        'btnExitGrocer
        '
        Me.btnExitGrocer.BackColor = System.Drawing.Color.Honeydew
        Me.btnExitGrocer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExitGrocer.ForeColor = System.Drawing.Color.DarkGreen
        Me.btnExitGrocer.Location = New System.Drawing.Point(661, 316)
        Me.btnExitGrocer.Name = "btnExitGrocer"
        Me.btnExitGrocer.Size = New System.Drawing.Size(106, 33)
        Me.btnExitGrocer.TabIndex = 36
        Me.btnExitGrocer.Text = "Exit"
        Me.btnExitGrocer.UseVisualStyleBackColor = False
        Me.btnExitGrocer.Visible = False
        '
        'btnBuyGrocery
        '
        Me.btnBuyGrocery.BackColor = System.Drawing.Color.Honeydew
        Me.btnBuyGrocery.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuyGrocery.ForeColor = System.Drawing.Color.DarkGreen
        Me.btnBuyGrocery.Location = New System.Drawing.Point(661, 278)
        Me.btnBuyGrocery.Name = "btnBuyGrocery"
        Me.btnBuyGrocery.Size = New System.Drawing.Size(106, 37)
        Me.btnBuyGrocery.TabIndex = 37
        Me.btnBuyGrocery.Text = "Buy Groceries $100"
        Me.btnBuyGrocery.UseVisualStyleBackColor = False
        Me.btnBuyGrocery.Visible = False
        '
        'btnWorkGrocery
        '
        Me.btnWorkGrocery.BackColor = System.Drawing.Color.Honeydew
        Me.btnWorkGrocery.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnWorkGrocery.ForeColor = System.Drawing.Color.DarkGreen
        Me.btnWorkGrocery.Location = New System.Drawing.Point(661, 350)
        Me.btnWorkGrocery.Name = "btnWorkGrocery"
        Me.btnWorkGrocery.Size = New System.Drawing.Size(106, 33)
        Me.btnWorkGrocery.TabIndex = 38
        Me.btnWorkGrocery.Text = "Go to Work"
        Me.btnWorkGrocery.UseVisualStyleBackColor = False
        Me.btnWorkGrocery.Visible = False
        '
        'btnWatchMovie
        '
        Me.btnWatchMovie.BackColor = System.Drawing.Color.Honeydew
        Me.btnWatchMovie.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnWatchMovie.ForeColor = System.Drawing.Color.DarkGreen
        Me.btnWatchMovie.Location = New System.Drawing.Point(661, 356)
        Me.btnWatchMovie.Name = "btnWatchMovie"
        Me.btnWatchMovie.Size = New System.Drawing.Size(123, 33)
        Me.btnWatchMovie.TabIndex = 39
        Me.btnWatchMovie.Text = "Watch a movie $5"
        Me.btnWatchMovie.UseVisualStyleBackColor = False
        Me.btnWatchMovie.Visible = False
        '
        'btnExitMovie
        '
        Me.btnExitMovie.BackColor = System.Drawing.Color.Honeydew
        Me.btnExitMovie.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExitMovie.ForeColor = System.Drawing.Color.DarkGreen
        Me.btnExitMovie.Location = New System.Drawing.Point(661, 389)
        Me.btnExitMovie.Name = "btnExitMovie"
        Me.btnExitMovie.Size = New System.Drawing.Size(123, 33)
        Me.btnExitMovie.TabIndex = 40
        Me.btnExitMovie.Text = "Exit"
        Me.btnExitMovie.UseVisualStyleBackColor = False
        Me.btnExitMovie.Visible = False
        '
        'btnWorkMovie
        '
        Me.btnWorkMovie.BackColor = System.Drawing.Color.Honeydew
        Me.btnWorkMovie.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnWorkMovie.ForeColor = System.Drawing.Color.DarkGreen
        Me.btnWorkMovie.Location = New System.Drawing.Point(661, 423)
        Me.btnWorkMovie.Name = "btnWorkMovie"
        Me.btnWorkMovie.Size = New System.Drawing.Size(123, 33)
        Me.btnWorkMovie.TabIndex = 41
        Me.btnWorkMovie.Text = "Go to Work"
        Me.btnWorkMovie.UseVisualStyleBackColor = False
        Me.btnWorkMovie.Visible = False
        '
        'btnChangeName
        '
        Me.btnChangeName.BackColor = System.Drawing.Color.Honeydew
        Me.btnChangeName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChangeName.ForeColor = System.Drawing.Color.DarkGreen
        Me.btnChangeName.Location = New System.Drawing.Point(192, 271)
        Me.btnChangeName.Name = "btnChangeName"
        Me.btnChangeName.Size = New System.Drawing.Size(111, 48)
        Me.btnChangeName.TabIndex = 42
        Me.btnChangeName.Text = "Legal Name Change $300"
        Me.btnChangeName.UseVisualStyleBackColor = False
        Me.btnChangeName.Visible = False
        '
        'btnGetMarried
        '
        Me.btnGetMarried.BackColor = System.Drawing.Color.Honeydew
        Me.btnGetMarried.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGetMarried.ForeColor = System.Drawing.Color.DarkGreen
        Me.btnGetMarried.Location = New System.Drawing.Point(192, 322)
        Me.btnGetMarried.Name = "btnGetMarried"
        Me.btnGetMarried.Size = New System.Drawing.Size(111, 48)
        Me.btnGetMarried.TabIndex = 43
        Me.btnGetMarried.Text = "Get Married"
        Me.btnGetMarried.UseVisualStyleBackColor = False
        Me.btnGetMarried.Visible = False
        '
        'btnExitCityHall
        '
        Me.btnExitCityHall.BackColor = System.Drawing.Color.Honeydew
        Me.btnExitCityHall.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExitCityHall.ForeColor = System.Drawing.Color.DarkGreen
        Me.btnExitCityHall.Location = New System.Drawing.Point(192, 374)
        Me.btnExitCityHall.Name = "btnExitCityHall"
        Me.btnExitCityHall.Size = New System.Drawing.Size(111, 48)
        Me.btnExitCityHall.TabIndex = 44
        Me.btnExitCityHall.Text = "Exit"
        Me.btnExitCityHall.UseVisualStyleBackColor = False
        Me.btnExitCityHall.Visible = False
        '
        'btnWorkCityHall
        '
        Me.btnWorkCityHall.BackColor = System.Drawing.Color.Honeydew
        Me.btnWorkCityHall.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnWorkCityHall.ForeColor = System.Drawing.Color.DarkGreen
        Me.btnWorkCityHall.Location = New System.Drawing.Point(192, 425)
        Me.btnWorkCityHall.Name = "btnWorkCityHall"
        Me.btnWorkCityHall.Size = New System.Drawing.Size(111, 48)
        Me.btnWorkCityHall.TabIndex = 45
        Me.btnWorkCityHall.Text = "Go to Work"
        Me.btnWorkCityHall.UseVisualStyleBackColor = False
        Me.btnWorkCityHall.Visible = False
        '
        'btnHaveChildren
        '
        Me.btnHaveChildren.BackColor = System.Drawing.Color.Honeydew
        Me.btnHaveChildren.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHaveChildren.ForeColor = System.Drawing.Color.DarkGreen
        Me.btnHaveChildren.Location = New System.Drawing.Point(120, 565)
        Me.btnHaveChildren.Name = "btnHaveChildren"
        Me.btnHaveChildren.Size = New System.Drawing.Size(146, 30)
        Me.btnHaveChildren.TabIndex = 46
        Me.btnHaveChildren.Text = "Have Children"
        Me.btnHaveChildren.UseVisualStyleBackColor = False
        Me.btnHaveChildren.Visible = False
        '
        'btnExitHospital
        '
        Me.btnExitHospital.BackColor = System.Drawing.Color.Honeydew
        Me.btnExitHospital.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExitHospital.ForeColor = System.Drawing.Color.DarkGreen
        Me.btnExitHospital.Location = New System.Drawing.Point(120, 599)
        Me.btnExitHospital.Name = "btnExitHospital"
        Me.btnExitHospital.Size = New System.Drawing.Size(146, 30)
        Me.btnExitHospital.TabIndex = 47
        Me.btnExitHospital.Text = "Exit"
        Me.btnExitHospital.UseVisualStyleBackColor = False
        Me.btnExitHospital.Visible = False
        '
        'btnExitSchool
        '
        Me.btnExitSchool.BackColor = System.Drawing.Color.Honeydew
        Me.btnExitSchool.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExitSchool.ForeColor = System.Drawing.Color.DarkGreen
        Me.btnExitSchool.Location = New System.Drawing.Point(408, 565)
        Me.btnExitSchool.Name = "btnExitSchool"
        Me.btnExitSchool.Size = New System.Drawing.Size(158, 33)
        Me.btnExitSchool.TabIndex = 48
        Me.btnExitSchool.Text = "Exit"
        Me.btnExitSchool.UseVisualStyleBackColor = False
        Me.btnExitSchool.Visible = False
        '
        'btnWorkSchool
        '
        Me.btnWorkSchool.BackColor = System.Drawing.Color.Honeydew
        Me.btnWorkSchool.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnWorkSchool.ForeColor = System.Drawing.Color.DarkGreen
        Me.btnWorkSchool.Location = New System.Drawing.Point(408, 604)
        Me.btnWorkSchool.Name = "btnWorkSchool"
        Me.btnWorkSchool.Size = New System.Drawing.Size(158, 33)
        Me.btnWorkSchool.TabIndex = 49
        Me.btnWorkSchool.Text = "Go to Work"
        Me.btnWorkSchool.UseVisualStyleBackColor = False
        Me.btnWorkSchool.Visible = False
        '
        'btnSwim
        '
        Me.btnSwim.BackColor = System.Drawing.Color.Honeydew
        Me.btnSwim.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSwim.ForeColor = System.Drawing.Color.DarkGreen
        Me.btnSwim.Location = New System.Drawing.Point(646, 534)
        Me.btnSwim.Name = "btnSwim"
        Me.btnSwim.Size = New System.Drawing.Size(121, 33)
        Me.btnSwim.TabIndex = 50
        Me.btnSwim.Text = "Go Swimming"
        Me.btnSwim.UseVisualStyleBackColor = False
        Me.btnSwim.Visible = False
        '
        'btnExitPool
        '
        Me.btnExitPool.BackColor = System.Drawing.Color.Honeydew
        Me.btnExitPool.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExitPool.ForeColor = System.Drawing.Color.DarkGreen
        Me.btnExitPool.Location = New System.Drawing.Point(646, 567)
        Me.btnExitPool.Name = "btnExitPool"
        Me.btnExitPool.Size = New System.Drawing.Size(121, 33)
        Me.btnExitPool.TabIndex = 51
        Me.btnExitPool.Text = "Exit"
        Me.btnExitPool.UseVisualStyleBackColor = False
        Me.btnExitPool.Visible = False
        '
        'btnWorkLifeguard
        '
        Me.btnWorkLifeguard.BackColor = System.Drawing.Color.Honeydew
        Me.btnWorkLifeguard.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnWorkLifeguard.ForeColor = System.Drawing.Color.DarkGreen
        Me.btnWorkLifeguard.Location = New System.Drawing.Point(646, 602)
        Me.btnWorkLifeguard.Name = "btnWorkLifeguard"
        Me.btnWorkLifeguard.Size = New System.Drawing.Size(121, 33)
        Me.btnWorkLifeguard.TabIndex = 52
        Me.btnWorkLifeguard.Text = "Go to Work"
        Me.btnWorkLifeguard.UseVisualStyleBackColor = False
        Me.btnWorkLifeguard.Visible = False
        '
        'btnWorkWriter
        '
        Me.btnWorkWriter.BackColor = System.Drawing.Color.Honeydew
        Me.btnWorkWriter.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnWorkWriter.ForeColor = System.Drawing.Color.DarkGreen
        Me.btnWorkWriter.Location = New System.Drawing.Point(661, 485)
        Me.btnWorkWriter.Name = "btnWorkWriter"
        Me.btnWorkWriter.Size = New System.Drawing.Size(123, 33)
        Me.btnWorkWriter.TabIndex = 54
        Me.btnWorkWriter.Text = "Go to Work"
        Me.btnWorkWriter.UseVisualStyleBackColor = False
        Me.btnWorkWriter.Visible = False
        '
        'btnExitBookStore
        '
        Me.btnExitBookStore.BackColor = System.Drawing.Color.Honeydew
        Me.btnExitBookStore.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExitBookStore.ForeColor = System.Drawing.Color.DarkGreen
        Me.btnExitBookStore.Location = New System.Drawing.Point(661, 453)
        Me.btnExitBookStore.Name = "btnExitBookStore"
        Me.btnExitBookStore.Size = New System.Drawing.Size(123, 33)
        Me.btnExitBookStore.TabIndex = 55
        Me.btnExitBookStore.Text = "Exit"
        Me.btnExitBookStore.UseVisualStyleBackColor = False
        Me.btnExitBookStore.Visible = False
        '
        'picSpouse
        '
        Me.picSpouse.Location = New System.Drawing.Point(135, 656)
        Me.picSpouse.Name = "picSpouse"
        Me.picSpouse.Size = New System.Drawing.Size(65, 73)
        Me.picSpouse.TabIndex = 53
        Me.picSpouse.TabStop = False
        Me.picSpouse.Visible = False
        '
        'btnPause
        '
        Me.btnPause.BackColor = System.Drawing.Color.PaleTurquoise
        Me.btnPause.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPause.Image = CType(resources.GetObject("btnPause.Image"), System.Drawing.Image)
        Me.btnPause.Location = New System.Drawing.Point(559, 682)
        Me.btnPause.Name = "btnPause"
        Me.btnPause.Size = New System.Drawing.Size(49, 40)
        Me.btnPause.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnPause.TabIndex = 22
        Me.btnPause.TabStop = False
        '
        'picPlayer
        '
        Me.picPlayer.BackColor = System.Drawing.Color.Transparent
        Me.picPlayer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picPlayer.Location = New System.Drawing.Point(830, 252)
        Me.picPlayer.Name = "picPlayer"
        Me.picPlayer.Size = New System.Drawing.Size(38, 66)
        Me.picPlayer.TabIndex = 17
        Me.picPlayer.TabStop = False
        '
        'picHouse5
        '
        Me.picHouse5.BackColor = System.Drawing.Color.DarkOliveGreen
        Me.picHouse5.Cursor = System.Windows.Forms.Cursors.Default
        Me.picHouse5.Image = CType(resources.GetObject("picHouse5.Image"), System.Drawing.Image)
        Me.picHouse5.Location = New System.Drawing.Point(1029, 565)
        Me.picHouse5.Name = "picHouse5"
        Me.picHouse5.Size = New System.Drawing.Size(84, 81)
        Me.picHouse5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picHouse5.TabIndex = 16
        Me.picHouse5.TabStop = False
        '
        'piccharacter
        '
        Me.piccharacter.Location = New System.Drawing.Point(34, 664)
        Me.piccharacter.Name = "piccharacter"
        Me.piccharacter.Size = New System.Drawing.Size(78, 87)
        Me.piccharacter.TabIndex = 16
        Me.piccharacter.TabStop = False
        '
        'picHouse3
        '
        Me.picHouse3.BackColor = System.Drawing.Color.DarkOliveGreen
        Me.picHouse3.Cursor = System.Windows.Forms.Cursors.Default
        Me.picHouse3.Image = Global.Sims_3_Game.My.Resources.Resources.house_3
        Me.picHouse3.Location = New System.Drawing.Point(912, 332)
        Me.picHouse3.Name = "picHouse3"
        Me.picHouse3.Size = New System.Drawing.Size(84, 81)
        Me.picHouse3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picHouse3.TabIndex = 14
        Me.picHouse3.TabStop = False
        '
        'picPolice
        '
        Me.picPolice.BackColor = System.Drawing.Color.DarkOliveGreen
        Me.picPolice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picPolice.Cursor = System.Windows.Forms.Cursors.Default
        Me.picPolice.Image = Global.Sims_3_Game.My.Resources.Resources.police
        Me.picPolice.Location = New System.Drawing.Point(386, 164)
        Me.picPolice.Name = "picPolice"
        Me.picPolice.Size = New System.Drawing.Size(99, 93)
        Me.picPolice.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPolice.TabIndex = 13
        Me.picPolice.TabStop = False
        '
        'picGym
        '
        Me.picGym.BackColor = System.Drawing.Color.DarkOliveGreen
        Me.picGym.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picGym.Cursor = System.Windows.Forms.Cursors.Default
        Me.picGym.Image = Global.Sims_3_Game.My.Resources.Resources.hosppital
        Me.picGym.Location = New System.Drawing.Point(102, 582)
        Me.picGym.Name = "picGym"
        Me.picGym.Size = New System.Drawing.Size(188, 65)
        Me.picGym.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picGym.TabIndex = 12
        Me.picGym.TabStop = False
        '
        'picMovie
        '
        Me.picMovie.BackColor = System.Drawing.Color.DarkOliveGreen
        Me.picMovie.Cursor = System.Windows.Forms.Cursors.Default
        Me.picMovie.Image = Global.Sims_3_Game.My.Resources.Resources.movie
        Me.picMovie.Location = New System.Drawing.Point(665, 371)
        Me.picMovie.Name = "picMovie"
        Me.picMovie.Size = New System.Drawing.Size(123, 75)
        Me.picMovie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picMovie.TabIndex = 11
        Me.picMovie.TabStop = False
        '
        'picBookStore
        '
        Me.picBookStore.BackColor = System.Drawing.Color.DarkOliveGreen
        Me.picBookStore.Cursor = System.Windows.Forms.Cursors.Default
        Me.picBookStore.Image = Global.Sims_3_Game.My.Resources.Resources.boook
        Me.picBookStore.Location = New System.Drawing.Point(667, 447)
        Me.picBookStore.Name = "picBookStore"
        Me.picBookStore.Size = New System.Drawing.Size(94, 62)
        Me.picBookStore.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBookStore.TabIndex = 10
        Me.picBookStore.TabStop = False
        '
        'picSwimmingPool
        '
        Me.picSwimmingPool.BackColor = System.Drawing.Color.DarkOliveGreen
        Me.picSwimmingPool.Cursor = System.Windows.Forms.Cursors.Default
        Me.picSwimmingPool.Image = Global.Sims_3_Game.My.Resources.Resources.pool
        Me.picSwimmingPool.Location = New System.Drawing.Point(648, 593)
        Me.picSwimmingPool.Name = "picSwimmingPool"
        Me.picSwimmingPool.Size = New System.Drawing.Size(121, 53)
        Me.picSwimmingPool.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picSwimmingPool.TabIndex = 9
        Me.picSwimmingPool.TabStop = False
        '
        'picHouse2
        '
        Me.picHouse2.BackColor = System.Drawing.Color.DarkOliveGreen
        Me.picHouse2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picHouse2.Cursor = System.Windows.Forms.Cursors.Default
        Me.picHouse2.Image = CType(resources.GetObject("picHouse2.Image"), System.Drawing.Image)
        Me.picHouse2.Location = New System.Drawing.Point(491, 154)
        Me.picHouse2.Name = "picHouse2"
        Me.picHouse2.Size = New System.Drawing.Size(111, 104)
        Me.picHouse2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picHouse2.TabIndex = 8
        Me.picHouse2.TabStop = False
        '
        'picRestaur
        '
        Me.picRestaur.BackColor = System.Drawing.Color.DarkOliveGreen
        Me.picRestaur.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picRestaur.Cursor = System.Windows.Forms.Cursors.Default
        Me.picRestaur.Image = Global.Sims_3_Game.My.Resources.Resources.restur
        Me.picRestaur.Location = New System.Drawing.Point(663, 143)
        Me.picRestaur.Name = "picRestaur"
        Me.picRestaur.Size = New System.Drawing.Size(115, 100)
        Me.picRestaur.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picRestaur.TabIndex = 7
        Me.picRestaur.TabStop = False
        '
        'picGroceryStore
        '
        Me.picGroceryStore.BackColor = System.Drawing.Color.DarkOliveGreen
        Me.picGroceryStore.Cursor = System.Windows.Forms.Cursors.Default
        Me.picGroceryStore.Image = Global.Sims_3_Game.My.Resources.Resources.grocery
        Me.picGroceryStore.Location = New System.Drawing.Point(665, 328)
        Me.picGroceryStore.Name = "picGroceryStore"
        Me.picGroceryStore.Size = New System.Drawing.Size(78, 42)
        Me.picGroceryStore.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picGroceryStore.TabIndex = 6
        Me.picGroceryStore.TabStop = False
        '
        'picHouse1
        '
        Me.picHouse1.BackColor = System.Drawing.Color.DarkOliveGreen
        Me.picHouse1.BackgroundImage = CType(resources.GetObject("picHouse1.BackgroundImage"), System.Drawing.Image)
        Me.picHouse1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picHouse1.Cursor = System.Windows.Forms.Cursors.Default
        Me.picHouse1.Location = New System.Drawing.Point(74, 319)
        Me.picHouse1.Name = "picHouse1"
        Me.picHouse1.Size = New System.Drawing.Size(96, 113)
        Me.picHouse1.TabIndex = 5
        Me.picHouse1.TabStop = False
        '
        'picSchool
        '
        Me.picSchool.BackColor = System.Drawing.Color.DarkOliveGreen
        Me.picSchool.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picSchool.Cursor = System.Windows.Forms.Cursors.Default
        Me.picSchool.Image = Global.Sims_3_Game.My.Resources.Resources.school
        Me.picSchool.Location = New System.Drawing.Point(386, 593)
        Me.picSchool.Name = "picSchool"
        Me.picSchool.Size = New System.Drawing.Size(195, 53)
        Me.picSchool.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picSchool.TabIndex = 4
        Me.picSchool.TabStop = False
        '
        'picCityHall
        '
        Me.picCityHall.BackColor = System.Drawing.Color.DarkOliveGreen
        Me.picCityHall.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picCityHall.Cursor = System.Windows.Forms.Cursors.Default
        Me.picCityHall.Image = CType(resources.GetObject("picCityHall.Image"), System.Drawing.Image)
        Me.picCityHall.Location = New System.Drawing.Point(192, 322)
        Me.picCityHall.Name = "picCityHall"
        Me.picCityHall.Size = New System.Drawing.Size(111, 178)
        Me.picCityHall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picCityHall.TabIndex = 3
        Me.picCityHall.TabStop = False
        '
        'picCentralPark
        '
        Me.picCentralPark.BackColor = System.Drawing.Color.DarkOliveGreen
        Me.picCentralPark.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picCentralPark.Cursor = System.Windows.Forms.Cursors.Default
        Me.picCentralPark.Image = Global.Sims_3_Game.My.Resources.Resources.park
        Me.picCentralPark.Location = New System.Drawing.Point(360, 335)
        Me.picCentralPark.Name = "picCentralPark"
        Me.picCentralPark.Size = New System.Drawing.Size(248, 185)
        Me.picCentralPark.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picCentralPark.TabIndex = 2
        Me.picCentralPark.TabStop = False
        '
        'picTaskBar
        '
        Me.picTaskBar.BackColor = System.Drawing.Color.LightSteelBlue
        Me.picTaskBar.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.picTaskBar.Location = New System.Drawing.Point(0, 646)
        Me.picTaskBar.Name = "picTaskBar"
        Me.picTaskBar.Size = New System.Drawing.Size(1239, 167)
        Me.picTaskBar.TabIndex = 19
        Me.picTaskBar.TabStop = False
        '
        'HouseDiamond1
        '
        Me.HouseDiamond1.BackColor = System.Drawing.Color.Transparent
        Me.HouseDiamond1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.HouseDiamond1.Image = Global.Sims_3_Game.My.Resources.Resources.Animated_sims_plumbbob
        Me.HouseDiamond1.Location = New System.Drawing.Point(102, 252)
        Me.HouseDiamond1.Name = "HouseDiamond1"
        Me.HouseDiamond1.Size = New System.Drawing.Size(48, 69)
        Me.HouseDiamond1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.HouseDiamond1.TabIndex = 57
        Me.HouseDiamond1.TabStop = False
        '
        'HouseDiamond2
        '
        Me.HouseDiamond2.BackColor = System.Drawing.Color.Transparent
        Me.HouseDiamond2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.HouseDiamond2.Image = Global.Sims_3_Game.My.Resources.Resources.Animated_sims_plumbbob
        Me.HouseDiamond2.Location = New System.Drawing.Point(531, 85)
        Me.HouseDiamond2.Name = "HouseDiamond2"
        Me.HouseDiamond2.Size = New System.Drawing.Size(48, 69)
        Me.HouseDiamond2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.HouseDiamond2.TabIndex = 61
        Me.HouseDiamond2.TabStop = False
        '
        'HouseDiamond3
        '
        Me.HouseDiamond3.BackColor = System.Drawing.Color.Transparent
        Me.HouseDiamond3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.HouseDiamond3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.HouseDiamond3.Image = Global.Sims_3_Game.My.Resources.Resources.Animated_sims_plumbbob
        Me.HouseDiamond3.Location = New System.Drawing.Point(938, 257)
        Me.HouseDiamond3.Name = "HouseDiamond3"
        Me.HouseDiamond3.Size = New System.Drawing.Size(48, 69)
        Me.HouseDiamond3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.HouseDiamond3.TabIndex = 62
        Me.HouseDiamond3.TabStop = False
        '
        'HouseDiamond4
        '
        Me.HouseDiamond4.BackColor = System.Drawing.Color.Transparent
        Me.HouseDiamond4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.HouseDiamond4.Image = Global.Sims_3_Game.My.Resources.Resources.Animated_sims_plumbbob
        Me.HouseDiamond4.Location = New System.Drawing.Point(989, 353)
        Me.HouseDiamond4.Name = "HouseDiamond4"
        Me.HouseDiamond4.Size = New System.Drawing.Size(48, 69)
        Me.HouseDiamond4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.HouseDiamond4.TabIndex = 63
        Me.HouseDiamond4.TabStop = False
        '
        'HouseDiamond5
        '
        Me.HouseDiamond5.BackColor = System.Drawing.Color.Transparent
        Me.HouseDiamond5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.HouseDiamond5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.HouseDiamond5.Image = Global.Sims_3_Game.My.Resources.Resources.Animated_sims_plumbbob
        Me.HouseDiamond5.Location = New System.Drawing.Point(1054, 497)
        Me.HouseDiamond5.Name = "HouseDiamond5"
        Me.HouseDiamond5.Size = New System.Drawing.Size(48, 69)
        Me.HouseDiamond5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.HouseDiamond5.TabIndex = 64
        Me.HouseDiamond5.TabStop = False
        '
        'lblSpouseName
        '
        Me.lblSpouseName.AutoSize = True
        Me.lblSpouseName.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblSpouseName.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSpouseName.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblSpouseName.Location = New System.Drawing.Point(132, 738)
        Me.lblSpouseName.Name = "lblSpouseName"
        Me.lblSpouseName.Size = New System.Drawing.Size(0, 16)
        Me.lblSpouseName.TabIndex = 65
        Me.lblSpouseName.Visible = False
        '
        'btnBathroom1
        '
        Me.btnBathroom1.BackColor = System.Drawing.Color.Honeydew
        Me.btnBathroom1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBathroom1.ForeColor = System.Drawing.Color.DarkGreen
        Me.btnBathroom1.Location = New System.Drawing.Point(73, 324)
        Me.btnBathroom1.Name = "btnBathroom1"
        Me.btnBathroom1.Size = New System.Drawing.Size(97, 35)
        Me.btnBathroom1.TabIndex = 66
        Me.btnBathroom1.Text = "Go to Bathroom"
        Me.btnBathroom1.UseVisualStyleBackColor = False
        Me.btnBathroom1.Visible = False
        '
        'btnEat1
        '
        Me.btnEat1.BackColor = System.Drawing.Color.Honeydew
        Me.btnEat1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEat1.ForeColor = System.Drawing.Color.DarkGreen
        Me.btnEat1.Location = New System.Drawing.Point(73, 364)
        Me.btnEat1.Name = "btnEat1"
        Me.btnEat1.Size = New System.Drawing.Size(97, 35)
        Me.btnEat1.TabIndex = 67
        Me.btnEat1.Text = "Eat Something" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "- 1 grocery"
        Me.btnEat1.UseVisualStyleBackColor = False
        Me.btnEat1.Visible = False
        '
        'btnShower1
        '
        Me.btnShower1.BackColor = System.Drawing.Color.Honeydew
        Me.btnShower1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShower1.ForeColor = System.Drawing.Color.DarkGreen
        Me.btnShower1.Location = New System.Drawing.Point(73, 403)
        Me.btnShower1.Name = "btnShower1"
        Me.btnShower1.Size = New System.Drawing.Size(97, 35)
        Me.btnShower1.TabIndex = 68
        Me.btnShower1.Text = "Shower"
        Me.btnShower1.UseVisualStyleBackColor = False
        Me.btnShower1.Visible = False
        '
        'btnBed1
        '
        Me.btnBed1.BackColor = System.Drawing.Color.Honeydew
        Me.btnBed1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBed1.ForeColor = System.Drawing.Color.DarkGreen
        Me.btnBed1.Location = New System.Drawing.Point(73, 444)
        Me.btnBed1.Name = "btnBed1"
        Me.btnBed1.Size = New System.Drawing.Size(97, 35)
        Me.btnBed1.TabIndex = 69
        Me.btnBed1.Text = "Go to Bed"
        Me.btnBed1.UseVisualStyleBackColor = False
        Me.btnBed1.Visible = False
        '
        'btnBed2
        '
        Me.btnBed2.BackColor = System.Drawing.Color.Honeydew
        Me.btnBed2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBed2.ForeColor = System.Drawing.Color.DarkGreen
        Me.btnBed2.Location = New System.Drawing.Point(504, 274)
        Me.btnBed2.Name = "btnBed2"
        Me.btnBed2.Size = New System.Drawing.Size(97, 35)
        Me.btnBed2.TabIndex = 73
        Me.btnBed2.Text = "Go to Bed"
        Me.btnBed2.UseVisualStyleBackColor = False
        Me.btnBed2.Visible = False
        '
        'btnShower2
        '
        Me.btnShower2.BackColor = System.Drawing.Color.Honeydew
        Me.btnShower2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShower2.ForeColor = System.Drawing.Color.DarkGreen
        Me.btnShower2.Location = New System.Drawing.Point(504, 233)
        Me.btnShower2.Name = "btnShower2"
        Me.btnShower2.Size = New System.Drawing.Size(97, 35)
        Me.btnShower2.TabIndex = 72
        Me.btnShower2.Text = "Shower"
        Me.btnShower2.UseVisualStyleBackColor = False
        Me.btnShower2.Visible = False
        '
        'btnEat2
        '
        Me.btnEat2.BackColor = System.Drawing.Color.Honeydew
        Me.btnEat2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEat2.ForeColor = System.Drawing.Color.DarkGreen
        Me.btnEat2.Location = New System.Drawing.Point(504, 194)
        Me.btnEat2.Name = "btnEat2"
        Me.btnEat2.Size = New System.Drawing.Size(97, 35)
        Me.btnEat2.TabIndex = 71
        Me.btnEat2.Text = "Eat Something" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "- 1 grocery"
        Me.btnEat2.UseVisualStyleBackColor = False
        Me.btnEat2.Visible = False
        '
        'btnBathroom2
        '
        Me.btnBathroom2.BackColor = System.Drawing.Color.Honeydew
        Me.btnBathroom2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBathroom2.ForeColor = System.Drawing.Color.DarkGreen
        Me.btnBathroom2.Location = New System.Drawing.Point(504, 154)
        Me.btnBathroom2.Name = "btnBathroom2"
        Me.btnBathroom2.Size = New System.Drawing.Size(97, 35)
        Me.btnBathroom2.TabIndex = 70
        Me.btnBathroom2.Text = "Go to Bathroom"
        Me.btnBathroom2.UseVisualStyleBackColor = False
        Me.btnBathroom2.Visible = False
        '
        'btnBed3
        '
        Me.btnBed3.BackColor = System.Drawing.Color.Honeydew
        Me.btnBed3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBed3.ForeColor = System.Drawing.Color.DarkGreen
        Me.btnBed3.Location = New System.Drawing.Point(918, 444)
        Me.btnBed3.Name = "btnBed3"
        Me.btnBed3.Size = New System.Drawing.Size(97, 35)
        Me.btnBed3.TabIndex = 77
        Me.btnBed3.Text = "Go to Bed"
        Me.btnBed3.UseVisualStyleBackColor = False
        Me.btnBed3.Visible = False
        '
        'btnShower3
        '
        Me.btnShower3.BackColor = System.Drawing.Color.Honeydew
        Me.btnShower3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShower3.ForeColor = System.Drawing.Color.DarkGreen
        Me.btnShower3.Location = New System.Drawing.Point(918, 403)
        Me.btnShower3.Name = "btnShower3"
        Me.btnShower3.Size = New System.Drawing.Size(97, 35)
        Me.btnShower3.TabIndex = 76
        Me.btnShower3.Text = "Shower"
        Me.btnShower3.UseVisualStyleBackColor = False
        Me.btnShower3.Visible = False
        '
        'btnEat3
        '
        Me.btnEat3.BackColor = System.Drawing.Color.Honeydew
        Me.btnEat3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEat3.ForeColor = System.Drawing.Color.DarkGreen
        Me.btnEat3.Location = New System.Drawing.Point(918, 364)
        Me.btnEat3.Name = "btnEat3"
        Me.btnEat3.Size = New System.Drawing.Size(97, 35)
        Me.btnEat3.TabIndex = 75
        Me.btnEat3.Text = "Eat Something" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "- 1 grocery"
        Me.btnEat3.UseVisualStyleBackColor = False
        Me.btnEat3.Visible = False
        '
        'btnBathroom3
        '
        Me.btnBathroom3.BackColor = System.Drawing.Color.Honeydew
        Me.btnBathroom3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBathroom3.ForeColor = System.Drawing.Color.DarkGreen
        Me.btnBathroom3.Location = New System.Drawing.Point(918, 324)
        Me.btnBathroom3.Name = "btnBathroom3"
        Me.btnBathroom3.Size = New System.Drawing.Size(97, 35)
        Me.btnBathroom3.TabIndex = 74
        Me.btnBathroom3.Text = "Go to Bathroom"
        Me.btnBathroom3.UseVisualStyleBackColor = False
        Me.btnBathroom3.Visible = False
        '
        'btnFinishedPlaying
        '
        Me.btnFinishedPlaying.AutoSize = True
        Me.btnFinishedPlaying.BackColor = System.Drawing.Color.LightSeaGreen
        Me.btnFinishedPlaying.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFinishedPlaying.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFinishedPlaying.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnFinishedPlaying.Location = New System.Drawing.Point(526, 728)
        Me.btnFinishedPlaying.Name = "btnFinishedPlaying"
        Me.btnFinishedPlaying.Size = New System.Drawing.Size(119, 16)
        Me.btnFinishedPlaying.TabIndex = 78
        Me.btnFinishedPlaying.Text = "Finished Playing?"
        '
        'btnExit1
        '
        Me.btnExit1.BackColor = System.Drawing.Color.Honeydew
        Me.btnExit1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit1.ForeColor = System.Drawing.Color.DarkGreen
        Me.btnExit1.Location = New System.Drawing.Point(73, 485)
        Me.btnExit1.Name = "btnExit1"
        Me.btnExit1.Size = New System.Drawing.Size(97, 35)
        Me.btnExit1.TabIndex = 79
        Me.btnExit1.Text = "Exit"
        Me.btnExit1.UseVisualStyleBackColor = False
        Me.btnExit1.Visible = False
        '
        'btnExit2
        '
        Me.btnExit2.BackColor = System.Drawing.Color.Honeydew
        Me.btnExit2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit2.ForeColor = System.Drawing.Color.DarkGreen
        Me.btnExit2.Location = New System.Drawing.Point(504, 312)
        Me.btnExit2.Name = "btnExit2"
        Me.btnExit2.Size = New System.Drawing.Size(97, 35)
        Me.btnExit2.TabIndex = 80
        Me.btnExit2.Text = "Exit"
        Me.btnExit2.UseVisualStyleBackColor = False
        Me.btnExit2.Visible = False
        '
        'btnExit3
        '
        Me.btnExit3.BackColor = System.Drawing.Color.Honeydew
        Me.btnExit3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit3.ForeColor = System.Drawing.Color.DarkGreen
        Me.btnExit3.Location = New System.Drawing.Point(918, 485)
        Me.btnExit3.Name = "btnExit3"
        Me.btnExit3.Size = New System.Drawing.Size(97, 35)
        Me.btnExit3.TabIndex = 81
        Me.btnExit3.Text = "Exit"
        Me.btnExit3.UseVisualStyleBackColor = False
        Me.btnExit3.Visible = False
        '
        'btnExit4
        '
        Me.btnExit4.BackColor = System.Drawing.Color.Honeydew
        Me.btnExit4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit4.ForeColor = System.Drawing.Color.DarkGreen
        Me.btnExit4.Location = New System.Drawing.Point(868, 572)
        Me.btnExit4.Name = "btnExit4"
        Me.btnExit4.Size = New System.Drawing.Size(97, 35)
        Me.btnExit4.TabIndex = 86
        Me.btnExit4.Text = "Exit"
        Me.btnExit4.UseVisualStyleBackColor = False
        Me.btnExit4.Visible = False
        '
        'btnBed4
        '
        Me.btnBed4.BackColor = System.Drawing.Color.Honeydew
        Me.btnBed4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBed4.ForeColor = System.Drawing.Color.DarkGreen
        Me.btnBed4.Location = New System.Drawing.Point(868, 531)
        Me.btnBed4.Name = "btnBed4"
        Me.btnBed4.Size = New System.Drawing.Size(97, 35)
        Me.btnBed4.TabIndex = 85
        Me.btnBed4.Text = "Go to Bed"
        Me.btnBed4.UseVisualStyleBackColor = False
        Me.btnBed4.Visible = False
        '
        'btnShower4
        '
        Me.btnShower4.BackColor = System.Drawing.Color.Honeydew
        Me.btnShower4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShower4.ForeColor = System.Drawing.Color.DarkGreen
        Me.btnShower4.Location = New System.Drawing.Point(868, 490)
        Me.btnShower4.Name = "btnShower4"
        Me.btnShower4.Size = New System.Drawing.Size(97, 35)
        Me.btnShower4.TabIndex = 84
        Me.btnShower4.Text = "Shower"
        Me.btnShower4.UseVisualStyleBackColor = False
        Me.btnShower4.Visible = False
        '
        'btnEat4
        '
        Me.btnEat4.BackColor = System.Drawing.Color.Honeydew
        Me.btnEat4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEat4.ForeColor = System.Drawing.Color.DarkGreen
        Me.btnEat4.Location = New System.Drawing.Point(868, 451)
        Me.btnEat4.Name = "btnEat4"
        Me.btnEat4.Size = New System.Drawing.Size(97, 35)
        Me.btnEat4.TabIndex = 83
        Me.btnEat4.Text = "Eat Something" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "- 1 grocery"
        Me.btnEat4.UseVisualStyleBackColor = False
        Me.btnEat4.Visible = False
        '
        'btnBathroom4
        '
        Me.btnBathroom4.BackColor = System.Drawing.Color.Honeydew
        Me.btnBathroom4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBathroom4.ForeColor = System.Drawing.Color.DarkGreen
        Me.btnBathroom4.Location = New System.Drawing.Point(868, 411)
        Me.btnBathroom4.Name = "btnBathroom4"
        Me.btnBathroom4.Size = New System.Drawing.Size(97, 35)
        Me.btnBathroom4.TabIndex = 82
        Me.btnBathroom4.Text = "Go to Bathroom"
        Me.btnBathroom4.UseVisualStyleBackColor = False
        Me.btnBathroom4.Visible = False
        '
        'btnExit5
        '
        Me.btnExit5.BackColor = System.Drawing.Color.Honeydew
        Me.btnExit5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit5.ForeColor = System.Drawing.Color.DarkGreen
        Me.btnExit5.Location = New System.Drawing.Point(1127, 601)
        Me.btnExit5.Name = "btnExit5"
        Me.btnExit5.Size = New System.Drawing.Size(97, 35)
        Me.btnExit5.TabIndex = 91
        Me.btnExit5.Text = "Exit"
        Me.btnExit5.UseVisualStyleBackColor = False
        Me.btnExit5.Visible = False
        '
        'btnBed5
        '
        Me.btnBed5.BackColor = System.Drawing.Color.Honeydew
        Me.btnBed5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBed5.ForeColor = System.Drawing.Color.DarkGreen
        Me.btnBed5.Location = New System.Drawing.Point(1127, 565)
        Me.btnBed5.Name = "btnBed5"
        Me.btnBed5.Size = New System.Drawing.Size(97, 35)
        Me.btnBed5.TabIndex = 90
        Me.btnBed5.Text = "Go to Bed"
        Me.btnBed5.UseVisualStyleBackColor = False
        Me.btnBed5.Visible = False
        '
        'btnShower5
        '
        Me.btnShower5.BackColor = System.Drawing.Color.Honeydew
        Me.btnShower5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShower5.ForeColor = System.Drawing.Color.DarkGreen
        Me.btnShower5.Location = New System.Drawing.Point(1127, 530)
        Me.btnShower5.Name = "btnShower5"
        Me.btnShower5.Size = New System.Drawing.Size(97, 35)
        Me.btnShower5.TabIndex = 89
        Me.btnShower5.Text = "Shower"
        Me.btnShower5.UseVisualStyleBackColor = False
        Me.btnShower5.Visible = False
        '
        'btnEat5
        '
        Me.btnEat5.BackColor = System.Drawing.Color.Honeydew
        Me.btnEat5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEat5.ForeColor = System.Drawing.Color.DarkGreen
        Me.btnEat5.Location = New System.Drawing.Point(1127, 493)
        Me.btnEat5.Name = "btnEat5"
        Me.btnEat5.Size = New System.Drawing.Size(97, 35)
        Me.btnEat5.TabIndex = 88
        Me.btnEat5.Text = "Eat Something" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "- 1 grocery"
        Me.btnEat5.UseVisualStyleBackColor = False
        Me.btnEat5.Visible = False
        '
        'btnBathroom5
        '
        Me.btnBathroom5.BackColor = System.Drawing.Color.Honeydew
        Me.btnBathroom5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBathroom5.ForeColor = System.Drawing.Color.DarkGreen
        Me.btnBathroom5.Location = New System.Drawing.Point(1127, 457)
        Me.btnBathroom5.Name = "btnBathroom5"
        Me.btnBathroom5.Size = New System.Drawing.Size(97, 35)
        Me.btnBathroom5.TabIndex = 87
        Me.btnBathroom5.Text = "Go to Bathroom"
        Me.btnBathroom5.UseVisualStyleBackColor = False
        Me.btnBathroom5.Visible = False
        '
        'lblGroceries
        '
        Me.lblGroceries.AutoSize = True
        Me.lblGroceries.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblGroceries.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGroceries.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblGroceries.Location = New System.Drawing.Point(707, 738)
        Me.lblGroceries.Name = "lblGroceries"
        Me.lblGroceries.Size = New System.Drawing.Size(75, 16)
        Me.lblGroceries.TabIndex = 92
        Me.lblGroceries.Text = "Groceries:"
        '
        'picChild1
        '
        Me.picChild1.Location = New System.Drawing.Point(240, 656)
        Me.picChild1.Name = "picChild1"
        Me.picChild1.Size = New System.Drawing.Size(65, 73)
        Me.picChild1.TabIndex = 93
        Me.picChild1.TabStop = False
        Me.picChild1.Visible = False
        '
        'picChild2
        '
        Me.picChild2.Location = New System.Drawing.Point(311, 656)
        Me.picChild2.Name = "picChild2"
        Me.picChild2.Size = New System.Drawing.Size(65, 73)
        Me.picChild2.TabIndex = 94
        Me.picChild2.TabStop = False
        Me.picChild2.Visible = False
        '
        'picChild3
        '
        Me.picChild3.Location = New System.Drawing.Point(382, 656)
        Me.picChild3.Name = "picChild3"
        Me.picChild3.Size = New System.Drawing.Size(65, 73)
        Me.picChild3.TabIndex = 95
        Me.picChild3.TabStop = False
        Me.picChild3.Visible = False
        '
        'lblChild1Name
        '
        Me.lblChild1Name.AutoSize = True
        Me.lblChild1Name.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblChild1Name.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChild1Name.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblChild1Name.Location = New System.Drawing.Point(240, 738)
        Me.lblChild1Name.Name = "lblChild1Name"
        Me.lblChild1Name.Size = New System.Drawing.Size(0, 16)
        Me.lblChild1Name.TabIndex = 96
        Me.lblChild1Name.Visible = False
        '
        'lblChild2Name
        '
        Me.lblChild2Name.AutoSize = True
        Me.lblChild2Name.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblChild2Name.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChild2Name.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblChild2Name.Location = New System.Drawing.Point(308, 738)
        Me.lblChild2Name.Name = "lblChild2Name"
        Me.lblChild2Name.Size = New System.Drawing.Size(0, 16)
        Me.lblChild2Name.TabIndex = 97
        Me.lblChild2Name.Visible = False
        '
        'lblChild3Name
        '
        Me.lblChild3Name.AutoSize = True
        Me.lblChild3Name.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblChild3Name.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChild3Name.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblChild3Name.Location = New System.Drawing.Point(381, 738)
        Me.lblChild3Name.Name = "lblChild3Name"
        Me.lblChild3Name.Size = New System.Drawing.Size(0, 16)
        Me.lblChild3Name.TabIndex = 98
        Me.lblChild3Name.Visible = False
        '
        'picBackground
        '
        Me.picBackground.BackColor = System.Drawing.Color.Transparent
        Me.picBackground.Image = Global.Sims_3_Game.My.Resources.Resources.map
        Me.picBackground.Location = New System.Drawing.Point(-6, -13)
        Me.picBackground.Name = "picBackground"
        Me.picBackground.Size = New System.Drawing.Size(1255, 852)
        Me.picBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBackground.TabIndex = 99
        Me.picBackground.TabStop = False
        '
        'btnRobBank
        '
        Me.btnRobBank.BackColor = System.Drawing.Color.Honeydew
        Me.btnRobBank.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRobBank.ForeColor = System.Drawing.Color.DarkGreen
        Me.btnRobBank.Location = New System.Drawing.Point(971, 53)
        Me.btnRobBank.Name = "btnRobBank"
        Me.btnRobBank.Size = New System.Drawing.Size(235, 57)
        Me.btnRobBank.TabIndex = 100
        Me.btnRobBank.Text = "Rob Money (Chance at life in prison)"
        Me.btnRobBank.UseVisualStyleBackColor = False
        Me.btnRobBank.Visible = False
        '
        'btnVacation
        '
        Me.btnVacation.BackColor = System.Drawing.Color.Honeydew
        Me.btnVacation.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVacation.ForeColor = System.Drawing.Color.DarkGreen
        Me.btnVacation.Location = New System.Drawing.Point(972, 179)
        Me.btnVacation.Name = "btnVacation"
        Me.btnVacation.Size = New System.Drawing.Size(235, 57)
        Me.btnVacation.TabIndex = 102
        Me.btnVacation.Text = "Go on vacation -$800"
        Me.btnVacation.UseVisualStyleBackColor = False
        Me.btnVacation.Visible = False
        '
        'btnLottery
        '
        Me.btnLottery.BackColor = System.Drawing.Color.Honeydew
        Me.btnLottery.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLottery.ForeColor = System.Drawing.Color.DarkGreen
        Me.btnLottery.Location = New System.Drawing.Point(971, 242)
        Me.btnLottery.Name = "btnLottery"
        Me.btnLottery.Size = New System.Drawing.Size(235, 57)
        Me.btnLottery.TabIndex = 103
        Me.btnLottery.Text = "Buy a lottery ticket -$5"
        Me.btnLottery.UseVisualStyleBackColor = False
        Me.btnLottery.Visible = False
        '
        'btnExitSelf
        '
        Me.btnExitSelf.BackColor = System.Drawing.Color.Honeydew
        Me.btnExitSelf.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExitSelf.ForeColor = System.Drawing.Color.DarkGreen
        Me.btnExitSelf.Location = New System.Drawing.Point(971, 305)
        Me.btnExitSelf.Name = "btnExitSelf"
        Me.btnExitSelf.Size = New System.Drawing.Size(235, 57)
        Me.btnExitSelf.TabIndex = 104
        Me.btnExitSelf.Text = "Exit"
        Me.btnExitSelf.UseVisualStyleBackColor = False
        Me.btnExitSelf.Visible = False
        '
        'btnHelp
        '
        Me.btnHelp.AutoSize = True
        Me.btnHelp.BackColor = System.Drawing.Color.LightSeaGreen
        Me.btnHelp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnHelp.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHelp.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnHelp.Location = New System.Drawing.Point(567, 752)
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Size = New System.Drawing.Size(36, 16)
        Me.btnHelp.TabIndex = 105
        Me.btnHelp.Text = "Help"
        '
        'pictopboundary
        '
        Me.pictopboundary.BackColor = System.Drawing.Color.Transparent
        Me.pictopboundary.Location = New System.Drawing.Point(-6, -18)
        Me.pictopboundary.Name = "pictopboundary"
        Me.pictopboundary.Size = New System.Drawing.Size(1240, 22)
        Me.pictopboundary.TabIndex = 106
        Me.pictopboundary.TabStop = False
        '
        'picRightBoundary
        '
        Me.picRightBoundary.BackColor = System.Drawing.Color.Transparent
        Me.picRightBoundary.Location = New System.Drawing.Point(1237, 0)
        Me.picRightBoundary.Name = "picRightBoundary"
        Me.picRightBoundary.Size = New System.Drawing.Size(10, 661)
        Me.picRightBoundary.TabIndex = 107
        Me.picRightBoundary.TabStop = False
        '
        'picBoundaryLeft
        '
        Me.picBoundaryLeft.BackColor = System.Drawing.Color.Transparent
        Me.picBoundaryLeft.Location = New System.Drawing.Point(-40, 0)
        Me.picBoundaryLeft.Name = "picBoundaryLeft"
        Me.picBoundaryLeft.Size = New System.Drawing.Size(42, 681)
        Me.picBoundaryLeft.TabIndex = 108
        Me.picBoundaryLeft.TabStop = False
        '
        'picHouse4New
        '
        Me.picHouse4New.BackColor = System.Drawing.Color.DarkOliveGreen
        Me.picHouse4New.Cursor = System.Windows.Forms.Cursors.Default
        Me.picHouse4New.Image = Global.Sims_3_Game.My.Resources.Resources.hoouse_4
        Me.picHouse4New.Location = New System.Drawing.Point(964, 423)
        Me.picHouse4New.Name = "picHouse4New"
        Me.picHouse4New.Size = New System.Drawing.Size(84, 81)
        Me.picHouse4New.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picHouse4New.TabIndex = 14
        Me.picHouse4New.TabStop = False
        '
        'btnClubbing
        '
        Me.btnClubbing.BackColor = System.Drawing.Color.Honeydew
        Me.btnClubbing.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClubbing.ForeColor = System.Drawing.Color.DarkGreen
        Me.btnClubbing.Location = New System.Drawing.Point(972, 116)
        Me.btnClubbing.Name = "btnClubbing"
        Me.btnClubbing.Size = New System.Drawing.Size(235, 57)
        Me.btnClubbing.TabIndex = 101
        Me.btnClubbing.Text = "Go to a club -$30"
        Me.btnClubbing.UseVisualStyleBackColor = False
        Me.btnClubbing.Visible = False
        '
        'lblHelpMoving
        '
        Me.lblHelpMoving.AutoSize = True
        Me.lblHelpMoving.BackColor = System.Drawing.Color.LightSeaGreen
        Me.lblHelpMoving.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblHelpMoving.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHelpMoving.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblHelpMoving.Location = New System.Drawing.Point(472, 775)
        Me.lblHelpMoving.Name = "lblHelpMoving"
        Me.lblHelpMoving.Size = New System.Drawing.Size(240, 16)
        Me.lblHelpMoving.TabIndex = 109
        Me.lblHelpMoving.Text = "Help! My Player Won't Stop Moving"
        '
        'tmrCheckMoney
        '
        Me.tmrCheckMoney.Enabled = True
        Me.tmrCheckMoney.Interval = 1
        '
        'frmGameInterface
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Sims_3_Game.My.Resources.Resources.map
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1239, 813)
        Me.Controls.Add(Me.lblHelpMoving)
        Me.Controls.Add(Me.picBoundaryLeft)
        Me.Controls.Add(Me.picRightBoundary)
        Me.Controls.Add(Me.pictopboundary)
        Me.Controls.Add(Me.btnHelp)
        Me.Controls.Add(Me.btnExitSelf)
        Me.Controls.Add(Me.btnLottery)
        Me.Controls.Add(Me.btnVacation)
        Me.Controls.Add(Me.btnClubbing)
        Me.Controls.Add(Me.btnRobBank)
        Me.Controls.Add(Me.lblChild3Name)
        Me.Controls.Add(Me.lblChild2Name)
        Me.Controls.Add(Me.lblChild1Name)
        Me.Controls.Add(Me.picChild3)
        Me.Controls.Add(Me.picChild2)
        Me.Controls.Add(Me.picChild1)
        Me.Controls.Add(Me.lblGroceries)
        Me.Controls.Add(Me.btnExit5)
        Me.Controls.Add(Me.btnBed5)
        Me.Controls.Add(Me.btnShower5)
        Me.Controls.Add(Me.btnEat5)
        Me.Controls.Add(Me.btnBathroom5)
        Me.Controls.Add(Me.btnExit4)
        Me.Controls.Add(Me.btnBed4)
        Me.Controls.Add(Me.btnShower4)
        Me.Controls.Add(Me.btnEat4)
        Me.Controls.Add(Me.btnBathroom4)
        Me.Controls.Add(Me.btnExit3)
        Me.Controls.Add(Me.btnExit2)
        Me.Controls.Add(Me.btnExit1)
        Me.Controls.Add(Me.btnFinishedPlaying)
        Me.Controls.Add(Me.btnBed3)
        Me.Controls.Add(Me.btnShower3)
        Me.Controls.Add(Me.btnEat3)
        Me.Controls.Add(Me.btnBathroom3)
        Me.Controls.Add(Me.btnBed2)
        Me.Controls.Add(Me.btnShower2)
        Me.Controls.Add(Me.btnEat2)
        Me.Controls.Add(Me.btnBathroom2)
        Me.Controls.Add(Me.btnBed1)
        Me.Controls.Add(Me.btnShower1)
        Me.Controls.Add(Me.btnEat1)
        Me.Controls.Add(Me.btnBathroom1)
        Me.Controls.Add(Me.lblSpouseName)
        Me.Controls.Add(Me.HouseDiamond3)
        Me.Controls.Add(Me.HouseDiamond5)
        Me.Controls.Add(Me.HouseDiamond4)
        Me.Controls.Add(Me.HouseDiamond2)
        Me.Controls.Add(Me.HouseDiamond1)
        Me.Controls.Add(Me.btnExitBookStore)
        Me.Controls.Add(Me.btnWorkWriter)
        Me.Controls.Add(Me.picSpouse)
        Me.Controls.Add(Me.btnWorkLifeguard)
        Me.Controls.Add(Me.btnExitPool)
        Me.Controls.Add(Me.btnSwim)
        Me.Controls.Add(Me.btnWorkSchool)
        Me.Controls.Add(Me.btnExitSchool)
        Me.Controls.Add(Me.btnExitHospital)
        Me.Controls.Add(Me.btnHaveChildren)
        Me.Controls.Add(Me.btnWorkCityHall)
        Me.Controls.Add(Me.btnExitCityHall)
        Me.Controls.Add(Me.btnGetMarried)
        Me.Controls.Add(Me.btnChangeName)
        Me.Controls.Add(Me.btnWorkMovie)
        Me.Controls.Add(Me.btnExitMovie)
        Me.Controls.Add(Me.btnWatchMovie)
        Me.Controls.Add(Me.btnWorkGrocery)
        Me.Controls.Add(Me.btnBuyGrocery)
        Me.Controls.Add(Me.btnExitGrocer)
        Me.Controls.Add(Me.btnWorkPolice)
        Me.Controls.Add(Me.btnWorkRestur)
        Me.Controls.Add(Me.btnExitPark)
        Me.Controls.Add(Me.btnPark)
        Me.Controls.Add(Me.btnpoliceexit)
        Me.Controls.Add(Me.lblMoney)
        Me.Controls.Add(Me.btnExitRest)
        Me.Controls.Add(Me.btnEatRestur)
        Me.Controls.Add(Me.btnPause)
        Me.Controls.Add(Me.lblStatement)
        Me.Controls.Add(Me.lblAgeByName)
        Me.Controls.Add(Me.picPlayer)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.picHouse5)
        Me.Controls.Add(Me.piccharacter)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.picHouse4New)
        Me.Controls.Add(Me.picHouse3)
        Me.Controls.Add(Me.lblJob)
        Me.Controls.Add(Me.picPolice)
        Me.Controls.Add(Me.lblAge)
        Me.Controls.Add(Me.picGym)
        Me.Controls.Add(Me.lblEnergy)
        Me.Controls.Add(Me.picMovie)
        Me.Controls.Add(Me.lblHygen)
        Me.Controls.Add(Me.picBookStore)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.picSwimmingPool)
        Me.Controls.Add(Me.lblBlad)
        Me.Controls.Add(Me.picHouse2)
        Me.Controls.Add(Me.prgBarEnergy)
        Me.Controls.Add(Me.picRestaur)
        Me.Controls.Add(Me.prgHygiene)
        Me.Controls.Add(Me.prgBarBladder)
        Me.Controls.Add(Me.picGroceryStore)
        Me.Controls.Add(Me.prgBarHunger)
        Me.Controls.Add(Me.picHouse1)
        Me.Controls.Add(Me.prgBarAge)
        Me.Controls.Add(Me.picSchool)
        Me.Controls.Add(Me.picCityHall)
        Me.Controls.Add(Me.picCentralPark)
        Me.Controls.Add(Me.picTaskBar)
        Me.Controls.Add(Me.picBackground)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmGameInterface"
        Me.Text = "The Sims 3"
        CType(Me.picSpouse, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnPause, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPlayer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picHouse5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.piccharacter, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picHouse3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPolice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picGym, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMovie, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBookStore, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSwimmingPool, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picHouse2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picRestaur, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picGroceryStore, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picHouse1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSchool, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCityHall, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCentralPark, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picTaskBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HouseDiamond1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HouseDiamond2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HouseDiamond3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HouseDiamond4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HouseDiamond5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picChild1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picChild2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picChild3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBackground, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictopboundary, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picRightBoundary, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBoundaryLeft, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picHouse4New, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents timerHunger As System.Windows.Forms.Timer
    Friend WithEvents timerEnergy As System.Windows.Forms.Timer
    Friend WithEvents timerTime As System.Windows.Forms.Timer
    Friend WithEvents picHouse1 As System.Windows.Forms.PictureBox
    Friend WithEvents picCityHall As System.Windows.Forms.PictureBox
    Friend WithEvents picSchool As System.Windows.Forms.PictureBox
    Friend WithEvents picSwimmingPool As System.Windows.Forms.PictureBox
    Friend WithEvents picBookStore As System.Windows.Forms.PictureBox
    Friend WithEvents picGroceryStore As System.Windows.Forms.PictureBox
    Friend WithEvents picCentralPark As System.Windows.Forms.PictureBox
    Friend WithEvents picHouse2 As System.Windows.Forms.PictureBox
    Friend WithEvents picRestaur As System.Windows.Forms.PictureBox
    Friend WithEvents picMovie As System.Windows.Forms.PictureBox
    Friend WithEvents picGym As System.Windows.Forms.PictureBox
    Friend WithEvents picPolice As System.Windows.Forms.PictureBox
    Friend WithEvents picHouse3 As System.Windows.Forms.PictureBox
    Friend WithEvents picHouse5 As System.Windows.Forms.PictureBox
    Friend WithEvents picPlayer As System.Windows.Forms.PictureBox
    Friend WithEvents timerPlayerMove As System.Windows.Forms.Timer
    Friend WithEvents prgBarAge As System.Windows.Forms.ProgressBar
    Friend WithEvents prgBarHunger As System.Windows.Forms.ProgressBar
    Friend WithEvents prgBarBladder As System.Windows.Forms.ProgressBar
    Friend WithEvents prgHygiene As System.Windows.Forms.ProgressBar
    Friend WithEvents prgBarEnergy As System.Windows.Forms.ProgressBar
    Friend WithEvents lblBlad As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblHygen As System.Windows.Forms.Label
    Friend WithEvents lblEnergy As System.Windows.Forms.Label
    Friend WithEvents lblAge As System.Windows.Forms.Label
    Friend WithEvents lblJob As System.Windows.Forms.Label
    Friend WithEvents lblTime As System.Windows.Forms.Label
    Friend WithEvents piccharacter As System.Windows.Forms.PictureBox
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents lblAgeByName As System.Windows.Forms.Label
    Friend WithEvents picTaskBar As System.Windows.Forms.PictureBox
    Friend WithEvents lblStatement As System.Windows.Forms.Label
    Friend WithEvents btnPause As System.Windows.Forms.PictureBox
    Friend WithEvents btnEatRestur As System.Windows.Forms.Button
    Friend WithEvents btnExitRest As System.Windows.Forms.Button
    Friend WithEvents lblMoney As System.Windows.Forms.Label
    Friend WithEvents timerJob As System.Windows.Forms.Timer
    Friend WithEvents btnpoliceexit As System.Windows.Forms.Button
    Friend WithEvents btnPark As System.Windows.Forms.Button
    Friend WithEvents btnExitPark As System.Windows.Forms.Button
    Friend WithEvents btnWorkRestur As System.Windows.Forms.Button
    Friend WithEvents btnWorkPolice As System.Windows.Forms.Button
    Friend WithEvents btnExitGrocer As System.Windows.Forms.Button
    Friend WithEvents btnBuyGrocery As System.Windows.Forms.Button
    Friend WithEvents btnWorkGrocery As System.Windows.Forms.Button
    Friend WithEvents btnWatchMovie As System.Windows.Forms.Button
    Friend WithEvents btnExitMovie As System.Windows.Forms.Button
    Friend WithEvents btnWorkMovie As System.Windows.Forms.Button
    Friend WithEvents btnChangeName As System.Windows.Forms.Button
    Friend WithEvents btnGetMarried As System.Windows.Forms.Button
    Friend WithEvents btnExitCityHall As System.Windows.Forms.Button
    Friend WithEvents btnWorkCityHall As System.Windows.Forms.Button
    Friend WithEvents btnHaveChildren As System.Windows.Forms.Button
    Friend WithEvents btnExitHospital As System.Windows.Forms.Button
    Friend WithEvents btnExitSchool As System.Windows.Forms.Button
    Friend WithEvents btnWorkSchool As System.Windows.Forms.Button
    Friend WithEvents btnSwim As System.Windows.Forms.Button
    Friend WithEvents btnExitPool As System.Windows.Forms.Button
    Friend WithEvents btnWorkLifeguard As System.Windows.Forms.Button
    Friend WithEvents picSpouse As System.Windows.Forms.PictureBox
    Friend WithEvents btnWorkWriter As System.Windows.Forms.Button
    Friend WithEvents btnExitBookStore As System.Windows.Forms.Button
    Friend WithEvents HouseDiamond1 As System.Windows.Forms.PictureBox
    Friend WithEvents HouseDiamond2 As System.Windows.Forms.PictureBox
    Friend WithEvents HouseDiamond3 As System.Windows.Forms.PictureBox
    Friend WithEvents HouseDiamond4 As System.Windows.Forms.PictureBox
    Friend WithEvents HouseDiamond5 As System.Windows.Forms.PictureBox
    Friend WithEvents timerBladder As System.Windows.Forms.Timer
    Friend WithEvents lblSpouseName As Label
    Friend WithEvents btnBathroom1 As Button
    Friend WithEvents btnEat1 As Button
    Friend WithEvents btnShower1 As Button
    Friend WithEvents btnBed1 As Button
    Friend WithEvents btnBed2 As Button
    Friend WithEvents btnShower2 As Button
    Friend WithEvents btnEat2 As Button
    Friend WithEvents btnBathroom2 As Button
    Friend WithEvents btnBed3 As Button
    Friend WithEvents btnShower3 As Button
    Friend WithEvents btnEat3 As Button
    Friend WithEvents btnBathroom3 As Button
    Friend WithEvents btnFinishedPlaying As Label
    Friend WithEvents btnExit1 As Button
    Friend WithEvents btnExit2 As Button
    Friend WithEvents btnExit3 As Button
    Friend WithEvents btnExit4 As Button
    Friend WithEvents btnBed4 As Button
    Friend WithEvents btnShower4 As Button
    Friend WithEvents btnEat4 As Button
    Friend WithEvents btnBathroom4 As Button
    Friend WithEvents btnExit5 As Button
    Friend WithEvents btnBed5 As Button
    Friend WithEvents btnShower5 As Button
    Friend WithEvents btnEat5 As Button
    Friend WithEvents btnBathroom5 As Button
    Friend WithEvents lblGroceries As Label
    Friend WithEvents picChild1 As PictureBox
    Friend WithEvents picChild2 As PictureBox
    Friend WithEvents picChild3 As PictureBox
    Friend WithEvents lblChild1Name As Label
    Friend WithEvents lblChild2Name As Label
    Friend WithEvents lblChild3Name As Label
    Friend WithEvents picBackground As PictureBox
    Friend WithEvents btnRobBank As Button
    Friend WithEvents btnVacation As Button
    Friend WithEvents btnLottery As Button
    Friend WithEvents btnExitSelf As Button
    Friend WithEvents btnHelp As Label
    Friend WithEvents pictopboundary As System.Windows.Forms.PictureBox
    Friend WithEvents picRightBoundary As System.Windows.Forms.PictureBox
    Friend WithEvents picBoundaryLeft As System.Windows.Forms.PictureBox
    Friend WithEvents picHouse4New As System.Windows.Forms.PictureBox
    Friend WithEvents btnClubbing As System.Windows.Forms.Button
    Friend WithEvents timerAge As System.Windows.Forms.Timer
    Friend WithEvents timerHygiene As System.Windows.Forms.Timer
    Friend WithEvents lblHelpMoving As System.Windows.Forms.Label
    Friend WithEvents tmrCheckMoney As System.Windows.Forms.Timer
End Class
