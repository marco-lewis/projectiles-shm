<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.tabMain = New System.Windows.Forms.TabControl()
        Me.tabBallThrow = New System.Windows.Forms.TabPage()
        Me.btnLoadBT = New System.Windows.Forms.Button()
        Me.btnSaveBT = New System.Windows.Forms.Button()
        Me.btnBallThrowFormula = New System.Windows.Forms.Button()
        Me.lblBTHeightAxis = New System.Windows.Forms.Label()
        Me.txtGravity = New System.Windows.Forms.TextBox()
        Me.lblBTAcceleration = New System.Windows.Forms.Label()
        Me.btnPausePlayBallThrow = New System.Windows.Forms.Button()
        Me.lblBTVariables = New System.Windows.Forms.Label()
        Me.updHeight = New System.Windows.Forms.NumericUpDown()
        Me.updVelocity = New System.Windows.Forms.NumericUpDown()
        Me.lblBTIntHeight = New System.Windows.Forms.Label()
        Me.lblBTIntVel = New System.Windows.Forms.Label()
        Me.imgBTBall = New System.Windows.Forms.PictureBox()
        Me.btnSimulateBallThrow = New System.Windows.Forms.Button()
        Me.tabProjectileMotion = New System.Windows.Forms.TabPage()
        Me.lblPMVariables = New System.Windows.Forms.Label()
        Me.btnSavePM = New System.Windows.Forms.Button()
        Me.btnLoadPM = New System.Windows.Forms.Button()
        Me.btnProjectileFormulae = New System.Windows.Forms.Button()
        Me.lblPMDistanceAxis = New System.Windows.Forms.Label()
        Me.lblPMHeightAxis = New System.Windows.Forms.Label()
        Me.btnPMPauseandPlay = New System.Windows.Forms.Button()
        Me.lblPMIntHeight = New System.Windows.Forms.Label()
        Me.lblPMIntHor = New System.Windows.Forms.Label()
        Me.lblPMIntVert = New System.Windows.Forms.Label()
        Me.txtInitialHeight = New System.Windows.Forms.TextBox()
        Me.txtInitialHor = New System.Windows.Forms.TextBox()
        Me.txtInitialVert = New System.Windows.Forms.TextBox()
        Me.imgProjectileBall = New System.Windows.Forms.PictureBox()
        Me.btnLaunch = New System.Windows.Forms.Button()
        Me.tabSHM = New System.Windows.Forms.TabPage()
        Me.lblZero = New System.Windows.Forms.Label()
        Me.lblHalf = New System.Windows.Forms.Label()
        Me.lblLength = New System.Windows.Forms.Label()
        Me.lblMeterMark = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.optResultantForce = New System.Windows.Forms.RadioButton()
        Me.optComponentForces = New System.Windows.Forms.RadioButton()
        Me.lblSHMVariables = New System.Windows.Forms.Label()
        Me.btnSaveSHM = New System.Windows.Forms.Button()
        Me.btnLoadSHM = New System.Windows.Forms.Button()
        Me.btnPauseSHM = New System.Windows.Forms.Button()
        Me.btnSHMFormulae = New System.Windows.Forms.Button()
        Me.lbSHMMaxDis = New System.Windows.Forms.Label()
        Me.txtMaxDisplacement = New System.Windows.Forms.TextBox()
        Me.imgSHMBall = New System.Windows.Forms.PictureBox()
        Me.lblSHMPendLen = New System.Windows.Forms.Label()
        Me.txtStringLength = New System.Windows.Forms.TextBox()
        Me.btnSimulateSHM = New System.Windows.Forms.Button()
        Me.lblValue1 = New System.Windows.Forms.Label()
        Me.lblValue2 = New System.Windows.Forms.Label()
        Me.lblValue3 = New System.Windows.Forms.Label()
        Me.lblValue4 = New System.Windows.Forms.Label()
        Me.lblValue5 = New System.Windows.Forms.Label()
        Me.lblValue6 = New System.Windows.Forms.Label()
        Me.lblValue7 = New System.Windows.Forms.Label()
        Me.lblValue8 = New System.Windows.Forms.Label()
        Me.lblBTTime = New System.Windows.Forms.Label()
        Me.lblInterval = New System.Windows.Forms.Label()
        Me.lblPMTime = New System.Windows.Forms.Label()
        Me.lblSHMTime = New System.Windows.Forms.Label()
        Me.lblDetails3 = New System.Windows.Forms.Label()
        Me.lblDetails2 = New System.Windows.Forms.Label()
        Me.lblDetails1 = New System.Windows.Forms.Label()
        Me.lblDetails4 = New System.Windows.Forms.Label()
        Me.lblDetails5 = New System.Windows.Forms.Label()
        Me.lblDetails6 = New System.Windows.Forms.Label()
        Me.lblDetails8 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tabMain.SuspendLayout()
        Me.tabBallThrow.SuspendLayout()
        CType(Me.updHeight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.updVelocity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgBTBall, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabProjectileMotion.SuspendLayout()
        CType(Me.imgProjectileBall, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabSHM.SuspendLayout()
        CType(Me.imgSHMBall, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tabMain
        '
        Me.tabMain.Controls.Add(Me.tabBallThrow)
        Me.tabMain.Controls.Add(Me.tabProjectileMotion)
        Me.tabMain.Controls.Add(Me.tabSHM)
        Me.tabMain.Location = New System.Drawing.Point(0, 12)
        Me.tabMain.Name = "tabMain"
        Me.tabMain.SelectedIndex = 0
        Me.tabMain.Size = New System.Drawing.Size(891, 628)
        Me.tabMain.TabIndex = 0
        '
        'tabBallThrow
        '
        Me.tabBallThrow.Controls.Add(Me.lblDetails1)
        Me.tabBallThrow.Controls.Add(Me.lblDetails2)
        Me.tabBallThrow.Controls.Add(Me.lblDetails3)
        Me.tabBallThrow.Controls.Add(Me.lblInterval)
        Me.tabBallThrow.Controls.Add(Me.lblBTTime)
        Me.tabBallThrow.Controls.Add(Me.lblValue3)
        Me.tabBallThrow.Controls.Add(Me.lblValue2)
        Me.tabBallThrow.Controls.Add(Me.lblValue1)
        Me.tabBallThrow.Controls.Add(Me.btnLoadBT)
        Me.tabBallThrow.Controls.Add(Me.btnSaveBT)
        Me.tabBallThrow.Controls.Add(Me.btnBallThrowFormula)
        Me.tabBallThrow.Controls.Add(Me.lblBTHeightAxis)
        Me.tabBallThrow.Controls.Add(Me.txtGravity)
        Me.tabBallThrow.Controls.Add(Me.lblBTAcceleration)
        Me.tabBallThrow.Controls.Add(Me.btnPausePlayBallThrow)
        Me.tabBallThrow.Controls.Add(Me.lblBTVariables)
        Me.tabBallThrow.Controls.Add(Me.updHeight)
        Me.tabBallThrow.Controls.Add(Me.updVelocity)
        Me.tabBallThrow.Controls.Add(Me.lblBTIntHeight)
        Me.tabBallThrow.Controls.Add(Me.lblBTIntVel)
        Me.tabBallThrow.Controls.Add(Me.imgBTBall)
        Me.tabBallThrow.Controls.Add(Me.btnSimulateBallThrow)
        Me.tabBallThrow.Location = New System.Drawing.Point(4, 22)
        Me.tabBallThrow.Name = "tabBallThrow"
        Me.tabBallThrow.Padding = New System.Windows.Forms.Padding(3)
        Me.tabBallThrow.Size = New System.Drawing.Size(883, 602)
        Me.tabBallThrow.TabIndex = 0
        Me.tabBallThrow.Text = "Ball Throw"
        Me.tabBallThrow.UseVisualStyleBackColor = True
        '
        'btnLoadBT
        '
        Me.btnLoadBT.Location = New System.Drawing.Point(640, 216)
        Me.btnLoadBT.Name = "btnLoadBT"
        Me.btnLoadBT.Size = New System.Drawing.Size(100, 40)
        Me.btnLoadBT.TabIndex = 16
        Me.btnLoadBT.Text = "Load Variables"
        Me.btnLoadBT.UseVisualStyleBackColor = True
        '
        'btnSaveBT
        '
        Me.btnSaveBT.Location = New System.Drawing.Point(759, 216)
        Me.btnSaveBT.Name = "btnSaveBT"
        Me.btnSaveBT.Size = New System.Drawing.Size(100, 40)
        Me.btnSaveBT.TabIndex = 15
        Me.btnSaveBT.Text = "Save Variables"
        Me.btnSaveBT.UseVisualStyleBackColor = True
        '
        'btnBallThrowFormula
        '
        Me.btnBallThrowFormula.Location = New System.Drawing.Point(640, 262)
        Me.btnBallThrowFormula.Name = "btnBallThrowFormula"
        Me.btnBallThrowFormula.Size = New System.Drawing.Size(100, 40)
        Me.btnBallThrowFormula.TabIndex = 14
        Me.btnBallThrowFormula.Text = "Formulae"
        Me.btnBallThrowFormula.UseVisualStyleBackColor = True
        '
        'lblBTHeightAxis
        '
        Me.lblBTHeightAxis.AutoSize = True
        Me.lblBTHeightAxis.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBTHeightAxis.Location = New System.Drawing.Point(8, 21)
        Me.lblBTHeightAxis.Name = "lblBTHeightAxis"
        Me.lblBTHeightAxis.Size = New System.Drawing.Size(54, 13)
        Me.lblBTHeightAxis.TabIndex = 13
        Me.lblBTHeightAxis.Text = "Height /m"
        '
        'txtGravity
        '
        Me.txtGravity.Location = New System.Drawing.Point(769, 127)
        Me.txtGravity.Name = "txtGravity"
        Me.txtGravity.Size = New System.Drawing.Size(50, 20)
        Me.txtGravity.TabIndex = 12
        '
        'lblBTAcceleration
        '
        Me.lblBTAcceleration.AutoSize = True
        Me.lblBTAcceleration.Location = New System.Drawing.Point(630, 130)
        Me.lblBTAcceleration.Name = "lblBTAcceleration"
        Me.lblBTAcceleration.Size = New System.Drawing.Size(138, 13)
        Me.lblBTAcceleration.TabIndex = 11
        Me.lblBTAcceleration.Text = "Acceleration due to Gravity:"
        '
        'btnPausePlayBallThrow
        '
        Me.btnPausePlayBallThrow.Enabled = False
        Me.btnPausePlayBallThrow.Location = New System.Drawing.Point(640, 170)
        Me.btnPausePlayBallThrow.Name = "btnPausePlayBallThrow"
        Me.btnPausePlayBallThrow.Size = New System.Drawing.Size(100, 40)
        Me.btnPausePlayBallThrow.TabIndex = 10
        Me.btnPausePlayBallThrow.Text = "Pause"
        Me.btnPausePlayBallThrow.UseVisualStyleBackColor = True
        '
        'lblBTVariables
        '
        Me.lblBTVariables.AutoSize = True
        Me.lblBTVariables.Location = New System.Drawing.Point(630, 21)
        Me.lblBTVariables.Name = "lblBTVariables"
        Me.lblBTVariables.Size = New System.Drawing.Size(50, 13)
        Me.lblBTVariables.TabIndex = 9
        Me.lblBTVariables.Text = "Variables"
        '
        'updHeight
        '
        Me.updHeight.DecimalPlaces = 1
        Me.updHeight.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.updHeight.Location = New System.Drawing.Point(775, 90)
        Me.updHeight.Maximum = New Decimal(New Integer() {2, 0, 0, 0})
        Me.updHeight.Name = "updHeight"
        Me.updHeight.ReadOnly = True
        Me.updHeight.Size = New System.Drawing.Size(44, 20)
        Me.updHeight.TabIndex = 7
        '
        'updVelocity
        '
        Me.updVelocity.DecimalPlaces = 1
        Me.updVelocity.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.updVelocity.Location = New System.Drawing.Point(775, 51)
        Me.updVelocity.Maximum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.updVelocity.Name = "updVelocity"
        Me.updVelocity.ReadOnly = True
        Me.updVelocity.Size = New System.Drawing.Size(44, 20)
        Me.updVelocity.TabIndex = 6
        '
        'lblBTIntHeight
        '
        Me.lblBTIntHeight.AutoSize = True
        Me.lblBTIntHeight.Location = New System.Drawing.Point(630, 92)
        Me.lblBTIntHeight.Name = "lblBTIntHeight"
        Me.lblBTIntHeight.Size = New System.Drawing.Size(68, 13)
        Me.lblBTIntHeight.TabIndex = 3
        Me.lblBTIntHeight.Text = "Initial Height:"
        '
        'lblBTIntVel
        '
        Me.lblBTIntVel.AutoSize = True
        Me.lblBTIntVel.Location = New System.Drawing.Point(630, 53)
        Me.lblBTIntVel.Name = "lblBTIntVel"
        Me.lblBTIntVel.Size = New System.Drawing.Size(74, 13)
        Me.lblBTIntVel.TabIndex = 2
        Me.lblBTIntVel.Text = "Initial Velocity:"
        '
        'imgBTBall
        '
        Me.imgBTBall.Image = Global.Projectiles_and_SHM.My.Resources.Resources.Ball
        Me.imgBTBall.Location = New System.Drawing.Point(849, 533)
        Me.imgBTBall.Name = "imgBTBall"
        Me.imgBTBall.Size = New System.Drawing.Size(10, 10)
        Me.imgBTBall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imgBTBall.TabIndex = 1
        Me.imgBTBall.TabStop = False
        Me.imgBTBall.Visible = False
        '
        'btnSimulateBallThrow
        '
        Me.btnSimulateBallThrow.Location = New System.Drawing.Point(759, 170)
        Me.btnSimulateBallThrow.Name = "btnSimulateBallThrow"
        Me.btnSimulateBallThrow.Size = New System.Drawing.Size(100, 40)
        Me.btnSimulateBallThrow.TabIndex = 0
        Me.btnSimulateBallThrow.Text = "Simulate"
        Me.btnSimulateBallThrow.UseVisualStyleBackColor = True
        '
        'tabProjectileMotion
        '
        Me.tabProjectileMotion.Controls.Add(Me.lblDetails6)
        Me.tabProjectileMotion.Controls.Add(Me.lblDetails5)
        Me.tabProjectileMotion.Controls.Add(Me.lblDetails4)
        Me.tabProjectileMotion.Controls.Add(Me.lblPMTime)
        Me.tabProjectileMotion.Controls.Add(Me.lblValue6)
        Me.tabProjectileMotion.Controls.Add(Me.lblValue5)
        Me.tabProjectileMotion.Controls.Add(Me.lblValue4)
        Me.tabProjectileMotion.Controls.Add(Me.lblPMVariables)
        Me.tabProjectileMotion.Controls.Add(Me.btnSavePM)
        Me.tabProjectileMotion.Controls.Add(Me.btnLoadPM)
        Me.tabProjectileMotion.Controls.Add(Me.btnProjectileFormulae)
        Me.tabProjectileMotion.Controls.Add(Me.lblPMDistanceAxis)
        Me.tabProjectileMotion.Controls.Add(Me.lblPMHeightAxis)
        Me.tabProjectileMotion.Controls.Add(Me.btnPMPauseandPlay)
        Me.tabProjectileMotion.Controls.Add(Me.lblPMIntHeight)
        Me.tabProjectileMotion.Controls.Add(Me.lblPMIntHor)
        Me.tabProjectileMotion.Controls.Add(Me.lblPMIntVert)
        Me.tabProjectileMotion.Controls.Add(Me.txtInitialHeight)
        Me.tabProjectileMotion.Controls.Add(Me.txtInitialHor)
        Me.tabProjectileMotion.Controls.Add(Me.txtInitialVert)
        Me.tabProjectileMotion.Controls.Add(Me.imgProjectileBall)
        Me.tabProjectileMotion.Controls.Add(Me.btnLaunch)
        Me.tabProjectileMotion.Location = New System.Drawing.Point(4, 22)
        Me.tabProjectileMotion.Name = "tabProjectileMotion"
        Me.tabProjectileMotion.Padding = New System.Windows.Forms.Padding(3)
        Me.tabProjectileMotion.Size = New System.Drawing.Size(883, 602)
        Me.tabProjectileMotion.TabIndex = 1
        Me.tabProjectileMotion.Text = "Projectile Motion"
        Me.tabProjectileMotion.UseVisualStyleBackColor = True
        '
        'lblPMVariables
        '
        Me.lblPMVariables.AutoSize = True
        Me.lblPMVariables.Location = New System.Drawing.Point(633, 15)
        Me.lblPMVariables.Name = "lblPMVariables"
        Me.lblPMVariables.Size = New System.Drawing.Size(50, 13)
        Me.lblPMVariables.TabIndex = 17
        Me.lblPMVariables.Text = "Variables"
        '
        'btnSavePM
        '
        Me.btnSavePM.Location = New System.Drawing.Point(754, 215)
        Me.btnSavePM.Name = "btnSavePM"
        Me.btnSavePM.Size = New System.Drawing.Size(100, 40)
        Me.btnSavePM.TabIndex = 16
        Me.btnSavePM.Text = "Save Variables"
        Me.btnSavePM.UseVisualStyleBackColor = True
        '
        'btnLoadPM
        '
        Me.btnLoadPM.Location = New System.Drawing.Point(636, 216)
        Me.btnLoadPM.Name = "btnLoadPM"
        Me.btnLoadPM.Size = New System.Drawing.Size(100, 40)
        Me.btnLoadPM.TabIndex = 15
        Me.btnLoadPM.Text = "Load Variables"
        Me.btnLoadPM.UseVisualStyleBackColor = True
        '
        'btnProjectileFormulae
        '
        Me.btnProjectileFormulae.Location = New System.Drawing.Point(636, 262)
        Me.btnProjectileFormulae.Name = "btnProjectileFormulae"
        Me.btnProjectileFormulae.Size = New System.Drawing.Size(100, 40)
        Me.btnProjectileFormulae.TabIndex = 14
        Me.btnProjectileFormulae.Text = "Formulae"
        Me.btnProjectileFormulae.UseVisualStyleBackColor = True
        '
        'lblPMDistanceAxis
        '
        Me.lblPMDistanceAxis.AutoSize = True
        Me.lblPMDistanceAxis.Location = New System.Drawing.Point(280, 486)
        Me.lblPMDistanceAxis.Name = "lblPMDistanceAxis"
        Me.lblPMDistanceAxis.Size = New System.Drawing.Size(112, 13)
        Me.lblPMDistanceAxis.TabIndex = 13
        Me.lblPMDistanceAxis.Text = "Distance Travelled /m"
        '
        'lblPMHeightAxis
        '
        Me.lblPMHeightAxis.AutoSize = True
        Me.lblPMHeightAxis.Location = New System.Drawing.Point(37, 45)
        Me.lblPMHeightAxis.Name = "lblPMHeightAxis"
        Me.lblPMHeightAxis.Size = New System.Drawing.Size(54, 13)
        Me.lblPMHeightAxis.TabIndex = 12
        Me.lblPMHeightAxis.Text = "Height /m"
        '
        'btnPMPauseandPlay
        '
        Me.btnPMPauseandPlay.Enabled = False
        Me.btnPMPauseandPlay.Location = New System.Drawing.Point(636, 170)
        Me.btnPMPauseandPlay.Name = "btnPMPauseandPlay"
        Me.btnPMPauseandPlay.Size = New System.Drawing.Size(100, 40)
        Me.btnPMPauseandPlay.TabIndex = 11
        Me.btnPMPauseandPlay.Text = "Pause"
        Me.btnPMPauseandPlay.UseVisualStyleBackColor = True
        '
        'lblPMIntHeight
        '
        Me.lblPMIntHeight.AutoSize = True
        Me.lblPMIntHeight.Location = New System.Drawing.Point(633, 124)
        Me.lblPMIntHeight.Name = "lblPMIntHeight"
        Me.lblPMIntHeight.Size = New System.Drawing.Size(68, 13)
        Me.lblPMIntHeight.TabIndex = 8
        Me.lblPMIntHeight.Text = "Initial Height:"
        '
        'lblPMIntHor
        '
        Me.lblPMIntHor.AutoSize = True
        Me.lblPMIntHor.Location = New System.Drawing.Point(633, 86)
        Me.lblPMIntHor.Name = "lblPMIntHor"
        Me.lblPMIntHor.Size = New System.Drawing.Size(124, 13)
        Me.lblPMIntHor.TabIndex = 7
        Me.lblPMIntHor.Text = "Initial Horizontal Velocity:"
        '
        'lblPMIntVert
        '
        Me.lblPMIntVert.AutoSize = True
        Me.lblPMIntVert.Location = New System.Drawing.Point(633, 44)
        Me.lblPMIntVert.Name = "lblPMIntVert"
        Me.lblPMIntVert.Size = New System.Drawing.Size(112, 13)
        Me.lblPMIntVert.TabIndex = 6
        Me.lblPMIntVert.Text = "Initial Vertical Velocity:"
        '
        'txtInitialHeight
        '
        Me.txtInitialHeight.Location = New System.Drawing.Point(764, 124)
        Me.txtInitialHeight.Name = "txtInitialHeight"
        Me.txtInitialHeight.Size = New System.Drawing.Size(51, 20)
        Me.txtInitialHeight.TabIndex = 5
        '
        'txtInitialHor
        '
        Me.txtInitialHor.Location = New System.Drawing.Point(764, 83)
        Me.txtInitialHor.Name = "txtInitialHor"
        Me.txtInitialHor.Size = New System.Drawing.Size(51, 20)
        Me.txtInitialHor.TabIndex = 4
        '
        'txtInitialVert
        '
        Me.txtInitialVert.Location = New System.Drawing.Point(764, 41)
        Me.txtInitialVert.Name = "txtInitialVert"
        Me.txtInitialVert.Size = New System.Drawing.Size(51, 20)
        Me.txtInitialVert.TabIndex = 3
        '
        'imgProjectileBall
        '
        Me.imgProjectileBall.Image = Global.Projectiles_and_SHM.My.Resources.Resources.Ball
        Me.imgProjectileBall.Location = New System.Drawing.Point(735, 434)
        Me.imgProjectileBall.Name = "imgProjectileBall"
        Me.imgProjectileBall.Size = New System.Drawing.Size(10, 10)
        Me.imgProjectileBall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imgProjectileBall.TabIndex = 2
        Me.imgProjectileBall.TabStop = False
        Me.imgProjectileBall.Visible = False
        '
        'btnLaunch
        '
        Me.btnLaunch.Location = New System.Drawing.Point(754, 169)
        Me.btnLaunch.Name = "btnLaunch"
        Me.btnLaunch.Size = New System.Drawing.Size(100, 40)
        Me.btnLaunch.TabIndex = 0
        Me.btnLaunch.Text = "Launch"
        Me.btnLaunch.UseVisualStyleBackColor = True
        '
        'tabSHM
        '
        Me.tabSHM.Controls.Add(Me.Label2)
        Me.tabSHM.Controls.Add(Me.lblDetails8)
        Me.tabSHM.Controls.Add(Me.lblSHMTime)
        Me.tabSHM.Controls.Add(Me.lblValue8)
        Me.tabSHM.Controls.Add(Me.lblValue7)
        Me.tabSHM.Controls.Add(Me.lblZero)
        Me.tabSHM.Controls.Add(Me.lblHalf)
        Me.tabSHM.Controls.Add(Me.lblLength)
        Me.tabSHM.Controls.Add(Me.lblMeterMark)
        Me.tabSHM.Controls.Add(Me.Label1)
        Me.tabSHM.Controls.Add(Me.optResultantForce)
        Me.tabSHM.Controls.Add(Me.optComponentForces)
        Me.tabSHM.Controls.Add(Me.lblSHMVariables)
        Me.tabSHM.Controls.Add(Me.btnSaveSHM)
        Me.tabSHM.Controls.Add(Me.btnLoadSHM)
        Me.tabSHM.Controls.Add(Me.btnPauseSHM)
        Me.tabSHM.Controls.Add(Me.btnSHMFormulae)
        Me.tabSHM.Controls.Add(Me.lbSHMMaxDis)
        Me.tabSHM.Controls.Add(Me.txtMaxDisplacement)
        Me.tabSHM.Controls.Add(Me.imgSHMBall)
        Me.tabSHM.Controls.Add(Me.lblSHMPendLen)
        Me.tabSHM.Controls.Add(Me.txtStringLength)
        Me.tabSHM.Controls.Add(Me.btnSimulateSHM)
        Me.tabSHM.Location = New System.Drawing.Point(4, 22)
        Me.tabSHM.Name = "tabSHM"
        Me.tabSHM.Size = New System.Drawing.Size(883, 602)
        Me.tabSHM.TabIndex = 2
        Me.tabSHM.Text = "Simple Harmonic Motion"
        Me.tabSHM.UseVisualStyleBackColor = True
        '
        'lblZero
        '
        Me.lblZero.AutoSize = True
        Me.lblZero.Location = New System.Drawing.Point(70, 93)
        Me.lblZero.Name = "lblZero"
        Me.lblZero.Size = New System.Drawing.Size(28, 13)
        Me.lblZero.TabIndex = 23
        Me.lblZero.Text = "0.0 -"
        '
        'lblHalf
        '
        Me.lblHalf.AutoSize = True
        Me.lblHalf.Location = New System.Drawing.Point(70, 293)
        Me.lblHalf.Name = "lblHalf"
        Me.lblHalf.Size = New System.Drawing.Size(28, 13)
        Me.lblHalf.TabIndex = 22
        Me.lblHalf.Text = "0.5 -"
        '
        'lblLength
        '
        Me.lblLength.AutoSize = True
        Me.lblLength.Location = New System.Drawing.Point(8, 93)
        Me.lblLength.Name = "lblLength"
        Me.lblLength.Size = New System.Drawing.Size(62, 13)
        Me.lblLength.TabIndex = 21
        Me.lblLength.Text = "Distance/m"
        '
        'lblMeterMark
        '
        Me.lblMeterMark.AutoSize = True
        Me.lblMeterMark.Location = New System.Drawing.Point(70, 493)
        Me.lblMeterMark.Name = "lblMeterMark"
        Me.lblMeterMark.Size = New System.Drawing.Size(28, 13)
        Me.lblMeterMark.TabIndex = 20
        Me.lblMeterMark.Text = "1.0 -"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(654, 281)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(165, 13)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Force Arrow Display (not to scale)"
        '
        'optResultantForce
        '
        Me.optResultantForce.AutoSize = True
        Me.optResultantForce.Location = New System.Drawing.Point(657, 320)
        Me.optResultantForce.Name = "optResultantForce"
        Me.optResultantForce.Size = New System.Drawing.Size(100, 17)
        Me.optResultantForce.TabIndex = 18
        Me.optResultantForce.TabStop = True
        Me.optResultantForce.Text = "Resultant Force"
        Me.optResultantForce.UseVisualStyleBackColor = True
        '
        'optComponentForces
        '
        Me.optComponentForces.AutoSize = True
        Me.optComponentForces.Location = New System.Drawing.Point(657, 297)
        Me.optComponentForces.Name = "optComponentForces"
        Me.optComponentForces.Size = New System.Drawing.Size(114, 17)
        Me.optComponentForces.TabIndex = 17
        Me.optComponentForces.TabStop = True
        Me.optComponentForces.Text = "Component Forces"
        Me.optComponentForces.UseVisualStyleBackColor = True
        '
        'lblSHMVariables
        '
        Me.lblSHMVariables.AutoSize = True
        Me.lblSHMVariables.Location = New System.Drawing.Point(654, 17)
        Me.lblSHMVariables.Name = "lblSHMVariables"
        Me.lblSHMVariables.Size = New System.Drawing.Size(50, 13)
        Me.lblSHMVariables.TabIndex = 16
        Me.lblSHMVariables.Text = "Variables"
        '
        'btnSaveSHM
        '
        Me.btnSaveSHM.Location = New System.Drawing.Point(775, 178)
        Me.btnSaveSHM.Name = "btnSaveSHM"
        Me.btnSaveSHM.Size = New System.Drawing.Size(100, 40)
        Me.btnSaveSHM.TabIndex = 15
        Me.btnSaveSHM.Text = "Save Variables"
        Me.btnSaveSHM.UseVisualStyleBackColor = True
        '
        'btnLoadSHM
        '
        Me.btnLoadSHM.Location = New System.Drawing.Point(657, 178)
        Me.btnLoadSHM.Name = "btnLoadSHM"
        Me.btnLoadSHM.Size = New System.Drawing.Size(100, 40)
        Me.btnLoadSHM.TabIndex = 14
        Me.btnLoadSHM.Text = "Load Variables"
        Me.btnLoadSHM.UseVisualStyleBackColor = True
        '
        'btnPauseSHM
        '
        Me.btnPauseSHM.Enabled = False
        Me.btnPauseSHM.Location = New System.Drawing.Point(657, 132)
        Me.btnPauseSHM.Name = "btnPauseSHM"
        Me.btnPauseSHM.Size = New System.Drawing.Size(100, 40)
        Me.btnPauseSHM.TabIndex = 13
        Me.btnPauseSHM.Text = "Pause"
        Me.btnPauseSHM.UseVisualStyleBackColor = True
        '
        'btnSHMFormulae
        '
        Me.btnSHMFormulae.Location = New System.Drawing.Point(657, 224)
        Me.btnSHMFormulae.Name = "btnSHMFormulae"
        Me.btnSHMFormulae.Size = New System.Drawing.Size(100, 40)
        Me.btnSHMFormulae.TabIndex = 12
        Me.btnSHMFormulae.Text = "Formulae"
        Me.btnSHMFormulae.UseVisualStyleBackColor = True
        '
        'lbSHMMaxDis
        '
        Me.lbSHMMaxDis.AutoSize = True
        Me.lbSHMMaxDis.Location = New System.Drawing.Point(654, 84)
        Me.lbSHMMaxDis.Name = "lbSHMMaxDis"
        Me.lbSHMMaxDis.Size = New System.Drawing.Size(121, 13)
        Me.lbSHMMaxDis.TabIndex = 11
        Me.lbSHMMaxDis.Text = "Maximum Displacement:"
        '
        'txtMaxDisplacement
        '
        Me.txtMaxDisplacement.Location = New System.Drawing.Point(781, 81)
        Me.txtMaxDisplacement.Name = "txtMaxDisplacement"
        Me.txtMaxDisplacement.Size = New System.Drawing.Size(51, 20)
        Me.txtMaxDisplacement.TabIndex = 10
        '
        'imgSHMBall
        '
        Me.imgSHMBall.Image = Global.Projectiles_and_SHM.My.Resources.Resources.Ball
        Me.imgSHMBall.Location = New System.Drawing.Point(843, 493)
        Me.imgSHMBall.Name = "imgSHMBall"
        Me.imgSHMBall.Size = New System.Drawing.Size(30, 30)
        Me.imgSHMBall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imgSHMBall.TabIndex = 9
        Me.imgSHMBall.TabStop = False
        Me.imgSHMBall.Visible = False
        '
        'lblSHMPendLen
        '
        Me.lblSHMPendLen.AutoSize = True
        Me.lblSHMPendLen.Location = New System.Drawing.Point(654, 43)
        Me.lblSHMPendLen.Name = "lblSHMPendLen"
        Me.lblSHMPendLen.Size = New System.Drawing.Size(93, 13)
        Me.lblSHMPendLen.TabIndex = 8
        Me.lblSHMPendLen.Text = "Pendulum Length:"
        '
        'txtStringLength
        '
        Me.txtStringLength.Location = New System.Drawing.Point(781, 40)
        Me.txtStringLength.Name = "txtStringLength"
        Me.txtStringLength.Size = New System.Drawing.Size(51, 20)
        Me.txtStringLength.TabIndex = 7
        '
        'btnSimulateSHM
        '
        Me.btnSimulateSHM.Location = New System.Drawing.Point(775, 132)
        Me.btnSimulateSHM.Name = "btnSimulateSHM"
        Me.btnSimulateSHM.Size = New System.Drawing.Size(100, 40)
        Me.btnSimulateSHM.TabIndex = 1
        Me.btnSimulateSHM.Text = "Simulate SHM"
        Me.btnSimulateSHM.UseVisualStyleBackColor = True
        '
        'lblValue1
        '
        Me.lblValue1.AutoSize = True
        Me.lblValue1.Location = New System.Drawing.Point(825, 53)
        Me.lblValue1.Name = "lblValue1"
        Me.lblValue1.Size = New System.Drawing.Size(27, 13)
        Me.lblValue1.TabIndex = 17
        Me.lblValue1.Text = "ms⁻¹"
        '
        'lblValue2
        '
        Me.lblValue2.AutoSize = True
        Me.lblValue2.Location = New System.Drawing.Point(825, 92)
        Me.lblValue2.Name = "lblValue2"
        Me.lblValue2.Size = New System.Drawing.Size(15, 13)
        Me.lblValue2.TabIndex = 18
        Me.lblValue2.Text = "m"
        '
        'lblValue3
        '
        Me.lblValue3.AutoSize = True
        Me.lblValue3.Location = New System.Drawing.Point(825, 130)
        Me.lblValue3.Name = "lblValue3"
        Me.lblValue3.Size = New System.Drawing.Size(27, 13)
        Me.lblValue3.TabIndex = 19
        Me.lblValue3.Text = "ms⁻²"
        '
        'lblValue4
        '
        Me.lblValue4.AutoSize = True
        Me.lblValue4.Location = New System.Drawing.Point(821, 44)
        Me.lblValue4.Name = "lblValue4"
        Me.lblValue4.Size = New System.Drawing.Size(27, 13)
        Me.lblValue4.TabIndex = 18
        Me.lblValue4.Text = "ms⁻¹"
        '
        'lblValue5
        '
        Me.lblValue5.AutoSize = True
        Me.lblValue5.Location = New System.Drawing.Point(821, 86)
        Me.lblValue5.Name = "lblValue5"
        Me.lblValue5.Size = New System.Drawing.Size(27, 13)
        Me.lblValue5.TabIndex = 19
        Me.lblValue5.Text = "ms⁻¹"
        '
        'lblValue6
        '
        Me.lblValue6.AutoSize = True
        Me.lblValue6.Location = New System.Drawing.Point(821, 127)
        Me.lblValue6.Name = "lblValue6"
        Me.lblValue6.Size = New System.Drawing.Size(15, 13)
        Me.lblValue6.TabIndex = 20
        Me.lblValue6.Text = "m"
        '
        'lblValue7
        '
        Me.lblValue7.AutoSize = True
        Me.lblValue7.Location = New System.Drawing.Point(840, 43)
        Me.lblValue7.Name = "lblValue7"
        Me.lblValue7.Size = New System.Drawing.Size(15, 13)
        Me.lblValue7.TabIndex = 24
        Me.lblValue7.Text = "m"
        '
        'lblValue8
        '
        Me.lblValue8.AutoSize = True
        Me.lblValue8.Location = New System.Drawing.Point(840, 84)
        Me.lblValue8.Name = "lblValue8"
        Me.lblValue8.Size = New System.Drawing.Size(15, 13)
        Me.lblValue8.TabIndex = 25
        Me.lblValue8.Text = "m"
        '
        'lblBTTime
        '
        Me.lblBTTime.AutoSize = True
        Me.lblBTTime.Location = New System.Drawing.Point(482, 21)
        Me.lblBTTime.Name = "lblBTTime"
        Me.lblBTTime.Size = New System.Drawing.Size(33, 13)
        Me.lblBTTime.TabIndex = 20
        Me.lblBTTime.Text = "Time:"
        '
        'lblInterval
        '
        Me.lblInterval.AutoSize = True
        Me.lblInterval.Location = New System.Drawing.Point(482, 51)
        Me.lblInterval.Name = "lblInterval"
        Me.lblInterval.Size = New System.Drawing.Size(71, 13)
        Me.lblInterval.TabIndex = 21
        Me.lblInterval.Text = "Interval Rate:"
        '
        'lblPMTime
        '
        Me.lblPMTime.AutoSize = True
        Me.lblPMTime.Location = New System.Drawing.Point(474, 15)
        Me.lblPMTime.Name = "lblPMTime"
        Me.lblPMTime.Size = New System.Drawing.Size(33, 13)
        Me.lblPMTime.TabIndex = 21
        Me.lblPMTime.Text = "Time:"
        '
        'lblSHMTime
        '
        Me.lblSHMTime.AutoSize = True
        Me.lblSHMTime.Location = New System.Drawing.Point(518, 17)
        Me.lblSHMTime.Name = "lblSHMTime"
        Me.lblSHMTime.Size = New System.Drawing.Size(33, 13)
        Me.lblSHMTime.TabIndex = 26
        Me.lblSHMTime.Text = "Time:"
        '
        'lblDetails3
        '
        Me.lblDetails3.AutoSize = True
        Me.lblDetails3.Location = New System.Drawing.Point(630, 143)
        Me.lblDetails3.Name = "lblDetails3"
        Me.lblDetails3.Size = New System.Drawing.Size(82, 13)
        Me.lblDetails3.TabIndex = 22
        Me.lblDetails3.Text = "(0 - 20, to 2 d.p)"
        '
        'lblDetails2
        '
        Me.lblDetails2.AutoSize = True
        Me.lblDetails2.Location = New System.Drawing.Point(630, 105)
        Me.lblDetails2.Name = "lblDetails2"
        Me.lblDetails2.Size = New System.Drawing.Size(76, 13)
        Me.lblDetails2.TabIndex = 23
        Me.lblDetails2.Text = "(0 - 2, to 1 d.p)"
        '
        'lblDetails1
        '
        Me.lblDetails1.AutoSize = True
        Me.lblDetails1.Location = New System.Drawing.Point(630, 66)
        Me.lblDetails1.Name = "lblDetails1"
        Me.lblDetails1.Size = New System.Drawing.Size(76, 13)
        Me.lblDetails1.TabIndex = 24
        Me.lblDetails1.Text = "(0 - 5, to 1 d.p)"
        '
        'lblDetails4
        '
        Me.lblDetails4.AutoSize = True
        Me.lblDetails4.Location = New System.Drawing.Point(633, 57)
        Me.lblDetails4.Name = "lblDetails4"
        Me.lblDetails4.Size = New System.Drawing.Size(103, 13)
        Me.lblDetails4.TabIndex = 25
        Me.lblDetails4.Text = "(0 - 100, as integers)"
        '
        'lblDetails5
        '
        Me.lblDetails5.AutoSize = True
        Me.lblDetails5.Location = New System.Drawing.Point(633, 99)
        Me.lblDetails5.Name = "lblDetails5"
        Me.lblDetails5.Size = New System.Drawing.Size(103, 13)
        Me.lblDetails5.TabIndex = 26
        Me.lblDetails5.Text = "(0 - 100, as integers)"
        '
        'lblDetails6
        '
        Me.lblDetails6.AutoSize = True
        Me.lblDetails6.Location = New System.Drawing.Point(633, 137)
        Me.lblDetails6.Name = "lblDetails6"
        Me.lblDetails6.Size = New System.Drawing.Size(103, 13)
        Me.lblDetails6.TabIndex = 27
        Me.lblDetails6.Text = "(0 - 200, as integers)"
        '
        'lblDetails8
        '
        Me.lblDetails8.AutoSize = True
        Me.lblDetails8.Location = New System.Drawing.Point(654, 99)
        Me.lblDetails8.Name = "lblDetails8"
        Me.lblDetails8.Size = New System.Drawing.Size(85, 13)
        Me.lblDetails8.TabIndex = 28
        Me.lblDetails8.Text = "(0 - 0.5, to 2 d.p)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(654, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 13)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "(0 - 1, to 1 d.p)"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(889, 639)
        Me.Controls.Add(Me.tabMain)
        Me.Name = "Form1"
        Me.Text = "Projectiles Simulator"
        Me.tabMain.ResumeLayout(False)
        Me.tabBallThrow.ResumeLayout(False)
        Me.tabBallThrow.PerformLayout()
        CType(Me.updHeight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.updVelocity, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgBTBall, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabProjectileMotion.ResumeLayout(False)
        Me.tabProjectileMotion.PerformLayout()
        CType(Me.imgProjectileBall, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabSHM.ResumeLayout(False)
        Me.tabSHM.PerformLayout()
        CType(Me.imgSHMBall, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tabMain As System.Windows.Forms.TabControl
    Friend WithEvents tabBallThrow As System.Windows.Forms.TabPage
    Friend WithEvents tabProjectileMotion As System.Windows.Forms.TabPage
    Friend WithEvents tabSHM As System.Windows.Forms.TabPage
    Friend WithEvents btnSimulateBallThrow As System.Windows.Forms.Button
    Friend WithEvents imgBTBall As System.Windows.Forms.PictureBox
    Friend WithEvents lblBTIntHeight As Label
    Friend WithEvents lblBTIntVel As Label
    Friend WithEvents updVelocity As NumericUpDown
    Friend WithEvents updHeight As NumericUpDown
    Friend WithEvents lblBTVariables As Label
    Friend WithEvents btnPausePlayBallThrow As Button
    Friend WithEvents btnLaunch As Button
    Friend WithEvents imgProjectileBall As PictureBox
    Friend WithEvents txtInitialVert As TextBox
    Friend WithEvents txtInitialHeight As TextBox
    Friend WithEvents txtInitialHor As TextBox
    Friend WithEvents lblPMIntVert As Label
    Friend WithEvents lblPMIntHeight As Label
    Friend WithEvents lblPMIntHor As Label
    Friend WithEvents lblBTAcceleration As System.Windows.Forms.Label
    Friend WithEvents btnSimulateSHM As System.Windows.Forms.Button
    Friend WithEvents lblSHMPendLen As System.Windows.Forms.Label
    Friend WithEvents txtStringLength As System.Windows.Forms.TextBox
    Friend WithEvents imgSHMBall As System.Windows.Forms.PictureBox
    Friend WithEvents btnPMPauseandPlay As Button
    Friend WithEvents txtGravity As System.Windows.Forms.TextBox
    Friend WithEvents lbSHMMaxDis As Label
    Friend WithEvents txtMaxDisplacement As TextBox
    Friend WithEvents lblBTHeightAxis As Label
    Friend WithEvents lblPMDistanceAxis As Label
    Friend WithEvents lblPMHeightAxis As Label
    Friend WithEvents btnBallThrowFormula As Button
    Friend WithEvents btnProjectileFormulae As Button
    Friend WithEvents btnSHMFormulae As Button
    Friend WithEvents btnSaveBT As Button
    Friend WithEvents btnPauseSHM As Button
    Friend WithEvents btnLoadBT As Button
    Friend WithEvents btnSavePM As System.Windows.Forms.Button
    Friend WithEvents btnLoadPM As System.Windows.Forms.Button
    Friend WithEvents btnSaveSHM As Button
    Friend WithEvents btnLoadSHM As Button
    Friend WithEvents lblPMVariables As System.Windows.Forms.Label
    Friend WithEvents lblSHMVariables As System.Windows.Forms.Label
    Friend WithEvents optResultantForce As System.Windows.Forms.RadioButton
    Friend WithEvents optComponentForces As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblMeterMark As Label
    Friend WithEvents lblHalf As Label
    Friend WithEvents lblLength As Label
    Friend WithEvents lblZero As Label
    Friend WithEvents lblValue3 As Label
    Friend WithEvents lblValue2 As Label
    Friend WithEvents lblValue1 As Label
    Friend WithEvents lblValue6 As Label
    Friend WithEvents lblValue5 As Label
    Friend WithEvents lblValue4 As Label
    Friend WithEvents lblValue8 As Label
    Friend WithEvents lblValue7 As Label
    Friend WithEvents lblBTTime As Label
    Friend WithEvents lblInterval As Label
    Friend WithEvents lblPMTime As Label
    Friend WithEvents lblSHMTime As Label
    Friend WithEvents lblDetails1 As Label
    Friend WithEvents lblDetails2 As Label
    Friend WithEvents lblDetails3 As Label
    Friend WithEvents lblDetails4 As Label
    Friend WithEvents lblDetails6 As Label
    Friend WithEvents lblDetails5 As Label
    Friend WithEvents lblDetails8 As Label
    Friend WithEvents Label2 As Label
End Class
