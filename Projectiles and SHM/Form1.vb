Imports System.Threading
Public Class Form1
    Dim BallThrowThreading As Thread
    Dim ProjectileMotionThreading As Thread
    Dim SHMThreading As Thread
    Public YMeterPoints(20) As Label
    Public ReDrawCirclesForBallThrow(15) As Decimal
    Public ProjectileMotionYMeter(20) As Label
    Public ProjectileMotionXMeter(20) As Label

    Function ValidateSingleDecimalPlace(ByRef VariableToTest As Decimal, ByVal Test As String, ByVal LowerBound As Integer, ByVal UpperBound As Integer) As Boolean
        Dim Expression As String = "^\d*(\.\d)?$"
        Dim SingleDpRegEx As New System.Text.RegularExpressions.Regex(Expression)

        'Tries to match the test to the regex
        If SingleDpRegEx.IsMatch(Test) = True Then
            Try
                VariableToTest = CDec(Test)
            Catch
                If Len(Test) <> 0 Then
                    MsgBox("Error: A value isn't a positive number with a single decimal place")
                Else
                    MsgBox("Error: No data has been entered into a textbox")
                End If
                ValidateSingleDecimalPlace = False
            End Try

            'Checks that the value is within a lower and upper bound
            If VariableToTest <= UpperBound And LowerBound <= VariableToTest And Len(Test) <> 0 Then
                ValidateSingleDecimalPlace = True
            ElseIf Len(Test) <> 0 Then
                MsgBox("Error: A value is outside of its boundary values")
                ValidateSingleDecimalPlace = False
            End If

        Else
            MsgBox("Error: A value isn't a positive number with a single decimal place")
            ValidateSingleDecimalPlace = False
        End If

        Return ValidateSingleDecimalPlace
    End Function

    Function ValidateInteger(ByRef VariableToTest As Integer, ByVal Test As String, ByVal LowerBound As Integer, ByVal UpperBound As Integer) As Boolean
        Dim IntegerExp As String = "^\d+$"
        Dim IntRegEx As New System.Text.RegularExpressions.Regex(IntegerExp)

        'Checks data matches regex
        If IntRegEx.IsMatch(Test) = True Then
            Try
                'Tries to convert to integer
                VariableToTest = CInt(Test)
            Catch
                MsgBox("Error: A variable entered isn't a positive integer")
                ValidateInteger = False
            End Try
            'Checks data is within correct boundary
            If VariableToTest <= UpperBound And VariableToTest >= LowerBound And Len(Test) <> 0 Then
                ValidateInteger = True
            ElseIf Len(Test) <> 0 Then
                MsgBox("Error: A variable is too large or too small")
                ValidateInteger = False
            End If

        Else
            If Len(Test) <> 0 Then
                MsgBox("Error: A variable entered isn't a positive integer")
            Else
                MsgBox("Error: No data has been entered into a textbox")
            End If
            ValidateInteger = False
            End If

            Return ValidateInteger
    End Function

    Function Validate2DecimalPlaces(ByVal Test As String, ByRef VariableToTest As Decimal, ByVal LowerBound As Decimal, ByVal UpperBound As Decimal) As Boolean
        Dim DecExpression As String = "^\d*(\.\d(\d)?)?$"
        Dim RegExDec As New System.Text.RegularExpressions.Regex(DecExpression)
        'Checks data matches regex
        Validate2DecimalPlaces = True
        If RegExDec.IsMatch(Test) = True Then
            'Attempts to convert data
            Try
                VariableToTest = CDec(Test)
            Catch
                If Len(Test) <> 0 Then
                    MsgBox("Error: A variable isn't a number or has too many decimal places")
                Else
                    MsgBox("Error: No data has been entered into a textbox")
                End If
                Validate2DecimalPlaces = False
            End Try
            'Validates if in correct range
            If Validate2DecimalPlaces = True Then
                If Not (VariableToTest >= LowerBound And VariableToTest <= UpperBound) Then
                    MsgBox("Error: a variable is too large or is a negative number")
                    Validate2DecimalPlaces = False
                End If
            End If
        Else
            MsgBox("Error: A variable entered isn't a positive number")
            Validate2DecimalPlaces = False
        End If

        Return Validate2DecimalPlaces
    End Function

    Function SinOrCosToFindDistance(ByVal Sin As Boolean, ByVal Angle As Decimal, ByVal Hyp As Decimal, ByVal AddDistance As Integer, ByVal Positive As Boolean) As Decimal
        'Various sin and cosine formula for the simulations to use
        If Sin = True And Positive = True Then
            SinOrCosToFindDistance = Hyp * Math.Sin(Math.Abs(Angle)) + AddDistance
        ElseIf Sin = True And Positive = False Then
            SinOrCosToFindDistance = -Hyp * Math.Sin(Math.Abs(Angle)) + AddDistance
        ElseIf Sin = False And Positive = True Then
            SinOrCosToFindDistance = Hyp * Math.Cos(Math.Abs(Angle)) + AddDistance
        Else
            SinOrCosToFindDistance = -Hyp * Math.Cos(Math.Abs(Angle)) + AddDistance
        End If
    End Function

    Function DistanceSuvatEquation(ByVal t As Decimal, ByVal a As Decimal, ByVal u As Decimal) As Decimal
        's = ut + 1/2 * a * (t^2)
        'Finds distance using formula above
        DistanceSuvatEquation = (u * t) + (0.5 * (a) * (t ^ 2))
        Return DistanceSuvatEquation
    End Function

#Region "BallThrow"

#Region "SimulationBT"
    Private Sub StartBTSimulation(sender As Object, e As EventArgs) Handles btnSimulateBallThrow.Click
        Dim TimeToPeak As Decimal
        Dim MaxHeight As Decimal
        Dim InitialHeight As Decimal
        Dim Valid As Boolean
        Dim Test As String

        Me.tabMain.SelectedTab = tabBallThrow

        'Validating Acceleration
        Test = txtGravity.Text
        Valid = Validate2DecimalPlaces(Test, PauseBallThrowVariables.Acceleration, 0, 20)


        If Valid = True Then
            'Reseting the coordinates of the balls to 0, preventing error
            For n = 1 To 10
                ReDrawCirclesForBallThrow(n) = 0
            Next
            'Aborts threading and resets some variables and button settings
            imgBTBall.Visible = True
            SelectAbortThreading(1)
            btnPausePlayBallThrow.Enabled = True
            btnSimulateBallThrow.Enabled = False
            btnPausePlayBallThrow.Text = "Pause"
            btnSaveBT.Enabled = False
            btnLoadBT.Enabled = False
            Refresh()
            imgBTBall.Left = 250

            With PauseBallThrowVariables
                'Sets base values
                .Ratio = 200
                .TakeRecord = 0
                .Vel = -(updVelocity.Value)
                InitialHeight = updHeight.Value


                'Can't divide by 0 so this stops the scaling breaking if this occurs
                'Also makes values not scale when acceleration is very small
                If .Acceleration <> 0 Then
                    TimeToPeak = -(.Vel / .Acceleration)
                    's= t*(u+v)/2
                    MaxHeight = InitialHeight - (0.5 * (TimeToPeak * .Vel))
                    lblInterval.Text = "Interval Rate: " & Math.Round(100 / .Acceleration) * 0.01 & "s"
                Else
                    'Sets a base height of 25 when a = 0, since giving enough time to show the ball won't slow down
                    MaxHeight = 25
                    lblInterval.Text = "Interval Rate: -"
                End If

                'Sets it so that the ball reaches the max height within the tab
                While (.Ratio * MaxHeight) >= 500
                    If .Ratio > 25 Then
                        .Ratio = .Ratio - 25
                    ElseIf .Ratio <= 25 And .Ratio > 1 Then
                        .Ratio = .Ratio - 1
                    ElseIf .Ratio <= 1 Then
                        .Ratio = .Ratio - 0.1
                    End If
                End While

                imgBTBall.Top = 490 - (.Ratio * InitialHeight)
                imgBTBall.Refresh()
                'Creates meter marks
                CreateMeterPointsForBT(500, .Ratio)
            End With

            'Starts simulation
            Form1.CheckForIllegalCrossThreadCalls = False
            BallThrowThreading = New Thread(AddressOf SimulateBT)
            BallThrowThreading.Start()
        End If
    End Sub

    Sub SimulateBT()
        Dim DrawLinesandCircles As Drawing.Graphics
        Dim CircleCount As Integer
        Dim NextPoint As Single
        'Redraws graph
        DrawLinesandCircles = Me.tabMain.SelectedTab.CreateGraphics()
        DrawBaseLines()
        CircleCount = 1
        NextPoint = imgBTBall.Top

        With PauseBallThrowVariables
            'Loops until img isn't lower than 500
            Do
                'DistanceSuvat is changed so that it is scaled
                'Used every 0.01s
                NextPoint = NextPoint + (DistanceSuvatEquation(0.01, .Acceleration, .Vel) * .Ratio)
                imgBTBall.Location = New Point(250, NextPoint)
                'Changes vel using v = u + at
                .Vel = .Vel + (.Acceleration * 0.01)
                imgBTBall.Refresh()
                'Takes a record of the image coordinate if returning to ground and so that there is a suitabel distance between recorded balls
                'This shows an increase in velocity
                'Records point in case simulation is paused
                If .Acceleration <> 0 And .Vel > 0 Then
                    If .TakeRecord Mod Math.Round(100 / .Acceleration) = 0 And NextPoint + 10 <= 500 And NextPoint - ReDrawCirclesForBallThrow(CircleCount - 1) > 10 Then
                        ReDrawCirclesForBallThrow(CircleCount) = NextPoint
                        'Draws the circle and increases number of circles
                        DrawLinesandCircles.DrawEllipse(Pens.Black, 400, ReDrawCirclesForBallThrow(CircleCount), 10, 10)
                        CircleCount = CircleCount + 1
                    End If
                End If
                'Redraws axis
                .TakeRecord = .TakeRecord + 1
                lblBTTime.Text = "Time: " & .TakeRecord * 0.01 & "s"
                Threading.Thread.Sleep(10)
            Loop Until (imgBTBall.Bottom >= 500 And .Vel > 0 And .Acceleration <> 0) Or (.Acceleration = 0 And .TakeRecord = 500)
        End With
        If imgBTBall.Bottom > 500 Then
            imgBTBall.Top = 490
        End If
        'Resets buttons and aborts threading
        btnPausePlayBallThrow.Enabled = False
        btnSimulateBallThrow.Enabled = True
        btnSaveBT.Enabled = True
        btnLoadBT.Enabled = True
    End Sub

    Private Sub PauseandPlayBallThrow(sender As Object, e As EventArgs) Handles btnPausePlayBallThrow.Click
        Dim DrawImages As Graphics
        DrawImages = Me.tabMain.SelectedTab.CreateGraphics()
        'Pauses simulation
        If btnPausePlayBallThrow.Text = "Pause" Then
            'Pauses threading, draws force arrow and changes settings
            BallThrowThreading.Suspend()
            btnPausePlayBallThrow.Text = "Play"
            DrawForceArrowForBallThrow(DrawImages)
            btnSimulateBallThrow.Enabled = True
            btnSaveBT.Enabled = True
            btnLoadBT.Enabled = True

            'Plays simulation
        ElseIf btnPausePlayBallThrow.Text = "Play" Then
            'Resumes threading, draws graph/circles and changes settings
            btnPausePlayBallThrow.Text = "Pause"
            btnSimulateBallThrow.Enabled = False
            btnSaveBT.Enabled = False
            btnLoadBT.Enabled = False
            BallThrowThreading.Resume()
            Refresh()
            DrawBaseLines()
            ReDrawCircles(DrawImages)
        End If
    End Sub

    Sub ReDrawCircles(ByVal DrawCircles As Graphics)
        'Redraws all balls
        For n = 1 To 15
            If ReDrawCirclesForBallThrow(n) <> 0 Then
                'Redraws the ball using the Y coordinate given
                DrawCircles.DrawEllipse(Pens.Black, 400, ReDrawCirclesForBallThrow(n), 10, 10)
            End If
        Next
    End Sub

    Private Sub DrawForceArrowForBallThrow(ByVal DrawingArrows As Graphics)
        Dim ArrowHead As New Pen(Brushes.Black, 5)
        Dim ArrowVertEnd As Integer
        'Draws an arrow using a custom pen
        ArrowHead.EndCap = Drawing2D.LineCap.ArrowAnchor
        'Custom pen changed to have an arrowhead at the end
        'End of arrow will change depending on the value of acceleration
        ArrowVertEnd = imgBTBall.Top + (10 * PauseBallThrowVariables.Acceleration)
        'Not very visible for acceleration of 1
        DrawingArrows.DrawLine(ArrowHead, imgBTBall.Left + 5, imgBTBall.Top + 5, imgBTBall.Left + 5, ArrowVertEnd)
    End Sub

    Sub CreateMeterPointsForBT(ByVal PointerStart As Integer, ByVal Ratio As Decimal)
        Dim Pointer As Integer
        Dim N As Integer
        'Removes previous points
        For A = 1 To 20
            Try
                tabMain.SelectedTab.Controls.Remove(YMeterPoints(A))
            Catch
            End Try
        Next
        Pointer = PointerStart
        N = 0
        'Continues until pointer > 0
        While Pointer > 0
            YMeterPoints(N) = New Label
            YMeterPoints(N).Top = Pointer - 10
            'Changes text value and position of next point based upon ratio
            If Ratio >= 25 Then
                YMeterPoints(N).Text = N
                Pointer = Pointer - Ratio
            ElseIf Ratio < 25 And Ratio > 1 Then
                YMeterPoints(N).Text = N * 20
                Pointer = Pointer - (Ratio * 20)
            ElseIf Ratio <= 1 Then
                YMeterPoints(N).Text = N * 100
                Pointer = Pointer - (Ratio * 100)
            End If
            'Sets it so that the centre of the text box is at the pointer value
            YMeterPoints(N).AutoSize = True
            tabMain.SelectedTab.Controls.Add(YMeterPoints(N))
            YMeterPoints(N).Left = 95 - YMeterPoints(N).Width
            N = N + 1
        End While
    End Sub
#End Region

    Private Sub SaveBallThrowVariables(sender As Object, e As EventArgs) Handles btnSaveBT.Click
        Dim Valid As Boolean
        Dim Test As String
        Dim SaveHeight As Decimal
        'Checks acceleration before saving the variable
        Test = txtGravity.Text
        Valid = Validate2DecimalPlaces(Test, PauseBallThrowVariables.Acceleration, 0, 20)
        SaveHeight = updHeight.Text
        PauseBallThrowVariables.Vel = updVelocity.Text
        If Valid = True Then
            'Goes to subroutine that saves the variables
            Save3Variables("BallThrowVariables.txt", 1, SaveHeight, False)
        End If
    End Sub

    Private Sub ShowLoadBTForm(sender As Object, e As EventArgs) Handles btnLoadBT.Click
        ReDim VariableLoading.TextBoxesToLoadIn(1)
        ReDim VariableLoading.NumericUpDownToLoadIn(2)
        'Ensures the file contains some data
        If FileLen("BallThrowVariables.txt") <> 0 Then
            'Changes variable values
            With VariableLoading
                .TextBoxesToLoadIn(1) = txtGravity
                .NumericUpDownToLoadIn(1) = updVelocity
                .NumericUpDownToLoadIn(2) = updHeight
                .FileToLoadFrom = "BallThrowVariables.txt"
                .FileTunnel = 1
                .NumOfVariables = 3
                Me.Hide()
                frmLoadVariables.Show()
            End With
        Else
            MsgBox("There is nothing saved within the file")
        End If
    End Sub
#End Region

#Region "Projectiles"

#Region "SimulatePM"
    Private Sub InitializeProjectileSimulation(sender As Object, e As EventArgs) Handles btnLaunch.Click
        Dim DrawSim As Drawing.Graphics
        Dim XScaling, YScaling As Decimal
        Dim DisplacementRequired As Integer
        Dim TimeToPeak As Decimal
        Dim MaxHeight As Decimal
        Dim XDistance As Decimal
        Dim Valid As Boolean
        Dim Test As String

        'Validates each of the variables, if one fails, no need to perform another validation
        'Variables are also given their value within the function
        Test = txtInitialVert.Text
        Valid = ValidateInteger(PMVariables.VertSpeed, Test, 0, 100)
        If Valid = True Then
            Test = txtInitialHor.Text
            Valid = ValidateInteger(PMVariables.HorizonSpeed, Test, 0, 100)
            If Valid = True Then
                Test = txtInitialHeight.Text
                Valid = ValidateInteger(TransferPM.InitialHeight, Test, 0, 200)
            End If
        End If


        If Valid = True Then
            'Aborts threading and resets settings on buttons and some variables
            imgProjectileBall.Visible = True
            SelectAbortThreading(2)
            btnLaunch.Enabled = False
            btnPMPauseandPlay.Enabled = True
            btnPMPauseandPlay.Text = "Pause"
            btnSavePM.Enabled = False
            btnLoadPM.Enabled = False
            XScaling = 100
            YScaling = 100
            TransferPM.Acceleration = -9.81

            With PMVariables
                DisplacementRequired = -TransferPM.InitialHeight
                'Finding time required based on y direction
                's = ut + 1/2*a(t^2)
                '0 = 1/2*a(t^2) + ut - s
                'Therefore, using the quadratic formula:
                't = (-u (+or-) Sqrt(u^2-4(1/2*a)(-s))) / 2(1/2*a)
                't = (-u - Sqrt(u^2 - 2(a)(-s))) / a
                TransferPM.TimeRequired = ((-.VertSpeed) - Math.Sqrt((.VertSpeed ^ 2) - (2 * TransferPM.Acceleration * (-DisplacementRequired)))) / TransferPM.Acceleration
                'Since t = v-u/a and v = 0 at peak
                'So t = -u/a
                TimeToPeak = (-.VertSpeed) / TransferPM.Acceleration
                MaxHeight = DistanceSuvatEquation(TimeToPeak, TransferPM.Acceleration, .VertSpeed) + TransferPM.InitialHeight

                'Continues to reduce scaling until the image can complete its curve
                While (YScaling * MaxHeight) + 10 >= 400
                    If YScaling > 1 Then
                        YScaling = YScaling - 1
                    ElseIf YScaling <= 1 Then
                        YScaling = YScaling - 0.1
                    End If
                End While

                'Finds the approximate XDistance from the variables
                XDistance = .HorizonSpeed * TransferPM.TimeRequired
                'Continues to reduce scaling until image can land
                While (XDistance * XScaling) + 10 >= 400
                    If XScaling > 1 Then
                        XScaling = XScaling - 1
                    ElseIf XScaling <= 1 Then
                        XScaling = XScaling - 0.1
                    End If
                End While

                'Scales the variables that are needed
                .HorizonSpeed = .HorizonSpeed * XScaling
                .VertSpeed = .VertSpeed * YScaling
                TransferPM.InitialHeight = TransferPM.InitialHeight * YScaling
                TransferPM.Acceleration = TransferPM.Acceleration * YScaling
                'Creates meterpoints based on scaling
                CreatePMXandYMeterPoints(YScaling, XScaling)

                'Draws the graph
                DrawSim = Me.tabMain.SelectedTab.CreateGraphics()
                DrawBaseLines()
                'Sets details for image
                imgProjectileBall.Left = 95
                'Sets the start coordinate for the image
                imgProjectileBall.Top = 445 - TransferPM.InitialHeight
                Refresh()
            End With

            'Threading aborted beforehand, so threading can start now
            Form1.CheckForIllegalCrossThreadCalls = False
            ProjectileMotionThreading = New Thread(AddressOf StartPMSimulation)
            ProjectileMotionThreading.Start()
        End If

    End Sub

    Sub StartPMSimulation()
        Dim DrawForSim As Graphics
        Dim FinalPts As List(Of Point) = New List(Of Point)
        Dim CurrentX As Integer
        DrawForSim = tabMain.SelectedTab.CreateGraphics()
        'Sets the current X value and adds it to the list of points
        CurrentX = 100
        FinalPts.Add(New Point(imgProjectileBall.Left + 5, imgProjectileBall.Top + 5))
        'Calls the recursion algorithm with initial variables and values
        SimulatePMFor10ms(DrawForSim, FinalPts, PMVariables.VertSpeed, CurrentX, TransferPM.TimeRequired, 0, PMVariables.HorizonSpeed, TransferPM.Acceleration, 0, imgProjectileBall.Top)

        FinalPts.Add(New Point(imgProjectileBall.Left + 5, imgProjectileBall.Top + 5))
        'Draws final curve of journey
        Try
            DrawForSim.DrawLines(Pens.Black, FinalPts.ToArray)
        Catch
        End Try
        'Resets buttons
        btnPMPauseandPlay.Enabled = False
        btnLaunch.Enabled = True
        btnSavePM.Enabled = True
        btnLoadPM.Enabled = True
    End Sub

    Sub SimulatePMFor10ms(ByVal UseGraphics As Graphics, ByRef RecordPoints As List(Of Point), ByVal VertSpeed As Decimal, ByVal XCoords As Decimal, ByVal Time As Decimal, ByVal interval As Integer, ByVal HorSpeed As Integer, ByVal Acceleration As Decimal, ByRef TimePassed As Decimal, ByVal CurrentYPoint As Decimal)

        'Continues to perform the algorithm until timepassed >= time, i.e. just landing
        If Not (TimePassed >= Time) Then
            'Using displacement equation to find change in position in 0.01s with velocity U
            CurrentYPoint = CurrentYPoint - (DistanceSuvatEquation(0.01, Acceleration, VertSpeed))
            'v = u + at
            VertSpeed = VertSpeed + (Acceleration * 0.01)
            's = vt
            XCoords = XCoords + (HorSpeed * 0.01)
            'Changes the coordinate of the ball
            imgProjectileBall.Top = CurrentYPoint - 5
            imgProjectileBall.Left = XCoords - 5
            'Takes recording of object place every 0.05s
            If interval Mod 5 = 0 Or TimePassed = 0 Then
                RecordPoints.Add(New Point(imgProjectileBall.Left + 5, imgProjectileBall.Top + 5))
            End If
            interval = interval + 1
            'Redraws the graph
            DrawBaseLines()
            Thread.Sleep(10)
            imgProjectileBall.Refresh()
            lblPMTime.Text = "Time: " & TimePassed & "s"
            TimePassed = TimePassed + 0.01
            'Performs Algorithm again
            SimulatePMFor10ms(UseGraphics, RecordPoints, VertSpeed, XCoords, Time, interval, HorSpeed, Acceleration, TimePassed, CurrentYPoint)
        End If

    End Sub

    Private Sub PlayAndPauseForProjectileMotion(sender As Object, e As EventArgs) Handles btnPMPauseandPlay.Click
        'For pausing the simulation
        If btnPMPauseandPlay.Text = "Pause" Then
            'Draws arrows and changes button settings
            btnPMPauseandPlay.Text = "Play"
            Try
                ProjectileMotionThreading.Suspend()
            Catch
            End Try
            btnLaunch.Enabled = True
            btnSavePM.Enabled = True
            btnLoadPM.Enabled = True
            DrawingProjectileArrows()

            'For playing the simulation
        ElseIf btnPMPauseandPlay.Text = "Play" Then
            'Clears screen and changes button settings
            btnPMPauseandPlay.Text = "Pause"
            btnLaunch.Enabled = False
            btnSavePM.Enabled = False
            btnLoadPM.Enabled = False
            ProjectileMotionThreading.Resume()
            Refresh()
        End If
    End Sub

    Sub DrawingProjectileArrows()
        Dim DrawStuff As Graphics
        Dim ArrowHead As New Pen(Brushes.Black, 5)
        ArrowHead.EndCap = Drawing2D.LineCap.ArrowAnchor
        DrawStuff = Me.tabMain.SelectedTab.CreateGraphics()
        'Draws Graph
        DrawBaseLines()
        'Draws the force arrow
        DrawStuff.DrawLine(ArrowHead, imgProjectileBall.Left + 5, imgProjectileBall.Top + 5, imgProjectileBall.Left + 5, imgProjectileBall.Top + 55)
    End Sub

    Sub CreatePMXandYMeterPoints(ByVal YScaling As Decimal, ByVal XScaling As Decimal)
        Dim Pointer As Integer
        Dim N As Integer

        'Attempts to remove any previous labels in tab
        For A = 1 To 20
            Try
                tabMain.SelectedTab.Controls.Remove(ProjectileMotionYMeter(A))
            Catch
            End Try
            Try
                tabMain.SelectedTab.Controls.Remove(ProjectileMotionXMeter(A))
            Catch
            End Try
        Next

        'Starts with y-axis
        Pointer = 450
        N = 0
        'Continues until the pointer is at a position higher than the axis
        While Pointer > 50
            'Defines label settings
            ProjectileMotionYMeter(N) = New Label
            ProjectileMotionYMeter(N).Height = 20
            ProjectileMotionYMeter(N).Location = New Point(70, Pointer - 10)
            ProjectileMotionYMeter(N).Width = 50
            'Changes label text and next label position based upon the Y-scaling
            If YScaling <= 100 And YScaling >= 20 Then
                ProjectileMotionYMeter(N).Text = N
                Pointer = Pointer - YScaling
            ElseIf YScaling < 20 And YScaling > 1 Then
                ProjectileMotionYMeter(N).Text = (N * 10)
                Pointer = Pointer - (YScaling * 10)
            ElseIf YScaling <= 1 Then
                ProjectileMotionYMeter(N).Text = (N * 100)
                Pointer = Pointer - (YScaling * 100)
            End If
            ProjectileMotionYMeter(N).AutoSize = True
            'Adds the textbox to the tab
            tabMain.SelectedTab.Controls.Add(ProjectileMotionYMeter(N))
            N = N + 1
        End While


        'Creating meter points for X-axis
        N = 0
        Pointer = 100
        'Continues until the pointer goes past the axis
        While Pointer < 500
            'Changes settings
            ProjectileMotionXMeter(N) = New Label
            ProjectileMotionXMeter(N).Location = New Point(Pointer - 10, 460)
            ProjectileMotionXMeter(N).Font.Size.Equals(8)
            'Changes values based on X-Scaling
            If XScaling <= 100 And XScaling > 20 Then
                ProjectileMotionXMeter(N).Text = N
                Pointer = Pointer + XScaling
            ElseIf XScaling <= 20 And XScaling > 1 Then
                ProjectileMotionXMeter(N).Text = (N * 10)
                Pointer = Pointer + (XScaling * 10)
            ElseIf 0.5 < XScaling And XScaling <= 1 Then
                ProjectileMotionXMeter(N).Text = (N * 100)
                Pointer = Pointer + (XScaling * 100)
            ElseIf XScaling <= 0.5 Then
                ProjectileMotionXMeter(N).Text = (N * 500)
                Pointer = Pointer + (XScaling * 500)
            End If
            ProjectileMotionXMeter(N).AutoSize = True
            tabMain.SelectedTab.Controls.Add(ProjectileMotionXMeter(N))
            N = N + 1
        End While

    End Sub
#End Region

    Private Sub ShowLoadForm(sender As Object, e As EventArgs) Handles btnLoadPM.Click
        ReDim VariableLoading.TextBoxesToLoadIn(3)
        'Checks file has data
        If FileLen("ProjectileMotionVariables.txt") <> 0 Then
            'Changes variable settings so form works with this data
            With VariableLoading
                .TextBoxesToLoadIn(1) = txtInitialVert
                .TextBoxesToLoadIn(2) = txtInitialHor
                .TextBoxesToLoadIn(3) = txtInitialHeight
                .FileToLoadFrom = "ProjectileMotionVariables.txt"
                .FileTunnel = 4
                .NumOfVariables = 3
                Me.Hide()
                frmLoadVariables.Show()
            End With
        Else
            MsgBox("There is nothing saved within the file")
        End If
    End Sub

    Private Sub SavePMVariables(sender As Object, e As EventArgs) Handles btnSavePM.Click
        Dim Test As String
        Dim AbleToSave As Boolean

        'Ensures that the data is valid
        Test = txtInitialVert.Text
        AbleToSave = ValidateInteger(PMVariables.VertSpeed, Test, 0, 100)
        If AbleToSave = True Then
            Test = txtInitialHor.Text
            AbleToSave = ValidateInteger(PMVariables.HorizonSpeed, Test, 0, 100)
            If AbleToSave = True Then
                Test = txtInitialHeight.Text
                AbleToSave = ValidateInteger(TransferPM.InitialHeight, Test, 0, 200)
            End If
        End If

        'If data is valid, data is saved using subroutine
        If AbleToSave = True Then
            Save3Variables("ProjectileMotionVariables.txt", 4, 0, True)
        End If

    End Sub

#End Region

#Region "SHM"

#Region "SimulateSHM"
    'Ratio is 400px:1m
    Private Sub InitializeSHM(sender As Object, e As EventArgs) Handles btnSimulateSHM.Click
        Dim Valid As Boolean
        'Validates the data entered before the simulation is performed
        ValidateSHM(Valid)

        'Performs simulation if vakud data
        If Valid = True Then
            imgSHMBall.Visible = True
            SelectAbortThreading(3)
            Form1.CheckForIllegalCrossThreadCalls = False
            SHMThreading = New Thread(AddressOf PerformSHM)
            SHMThreading.Start()
        End If
    End Sub

    Sub PerformSHM()
        Dim DrawTheSim As Drawing.Graphics
        Dim Frequency As Decimal
        Dim Displacement As Double
        Dim TimePassed As Decimal
        Dim XLength, YLength As Decimal


        DrawTheSim = Me.tabMain.SelectedTab.CreateGraphics()
        Me.DoubleBuffered = True
        'Makes the images flicker less

        'Changes button settings
        btnPauseSHM.Text = "Pause"
        btnSaveSHM.Enabled = False
        btnLoadSHM.Enabled = False
        btnSimulateSHM.Enabled = False
        btnPauseSHM.Enabled = True

        With TransferSHM
            .Center.X = 400
            .Center.Y = 100
            'Ball at equilibrium position
            .BallCords.X = 400
            DrawBaseLines()
            'Sets the equilibrium position
            Frequency = 1 / ((2 * Math.PI) * Math.Sqrt(.PendulumLength / 9.81))
            TimePassed = 0
            'Scales values for simulation
            .PendulumLength = .PendulumLength * 400
            .MaxDisplacement = .MaxDisplacement * 400

            Do
                'Calculates the displacement for each axis
                Displacement = .MaxDisplacement * Math.Cos(2 * Math.PI * Frequency * TimePassed)
                .Angle = Math.Abs(Displacement / .PendulumLength)
                XLength = SinOrCosToFindDistance(True, .Angle, .PendulumLength, 0, True)
                If Displacement < 0 Then
                    XLength = -XLength
                End If
                YLength = SinOrCosToFindDistance(False, .Angle, .PendulumLength, 0, True)
                .BallCords.X = Math.Round(.Center.X + XLength)
                .BallCords.Y = Math.Round(.Center.Y + YLength)
                'Redraws the circle each loop
                Refresh()
                DrawCircleAndLineForSHM(DrawTheSim, .Center.X, .Center.Y, .BallCords)
                'Keeps track of time
                lblSHMTime.Text = "Time: " & TimePassed & "s"
                TimePassed = TimePassed + 0.01
                Thread.Sleep(10)
            Loop Until TimePassed > 3
        End With
        btnPauseSHM.Enabled = False
        btnSaveSHM.Enabled = True
        btnLoadSHM.Enabled = True
        btnSimulateSHM.Enabled = True
    End Sub

    Private Sub PauseOrPlaySHM(sender As Object, e As EventArgs) Handles btnPauseSHM.Click
        'Pausing simulation
        If btnPauseSHM.Text = "Pause" Then
            btnPauseSHM.Text = "Play"
            Try
                SHMThreading.Suspend()
            Catch
            End Try
            DrawSHMForceArrows()
            btnSimulateSHM.Enabled = True
            btnSaveSHM.Enabled = True
            btnLoadSHM.Enabled = True
        ElseIf btnPauseSHM.Text = "Play" Then
            'Playing simulation
            btnPauseSHM.Text = "Pause"
            btnSimulateSHM.Enabled = False
            btnSaveSHM.Enabled = False
            btnLoadSHM.Enabled = False
            SHMThreading.Resume()
        End If
    End Sub

    Sub DrawCircleAndLineForSHM(ByRef DrawTheImage As Drawing.Graphics, ByVal CenterX As Integer, CenterY As Integer, ByVal BallCords As Point)
        'Draws the line the string is attatched to
        DrawBaseLines()
        'Draws the image
        imgSHMBall.Left = BallCords.X - 15
        imgSHMBall.Top = BallCords.Y - 15
        'Draws the line to the circle
        DrawTheImage.DrawLine(Pens.Black, CenterX, CenterY, BallCords.X, BallCords.Y)
    End Sub

    Sub DrawSHMForceArrows()
        Dim DrawingSHM As Drawing.Graphics
        Dim XTension As Integer
        Dim YTension As Integer
        Dim EndOfWeightArrowY As Integer
        Dim ArrowHead As New Pen(Brushes.Black)
        Refresh()
        DrawingSHM = Me.tabMain.SelectedTab.CreateGraphics()
        With TransferSHM
            DrawBaseLines()
            DrawingSHM.DrawLine(Pens.Black, .Center.X, .Center.Y, .BallCords.X, .BallCords.Y)
            XTension = HalfForceArrow(.BallCords.X, .Center.X)
            YTension = HalfForceArrow(.BallCords.Y, .Center.Y)
            ArrowHead.EndCap = Drawing2D.LineCap.ArrowAnchor
            'Creating weight arrow
            EndOfWeightArrowY = .BallCords.Y + 100
            If optComponentForces.Checked = True Then
                'Creating weight arrow
                ArrowHead.Width = 10
                DrawingSHM.DrawLine(ArrowHead, .BallCords.X, .BallCords.Y, .BallCords.X, EndOfWeightArrowY)
                'Creates tension arrow
                ArrowHead.Width = 5
                DrawingSHM.DrawLine(ArrowHead, .BallCords.X, .BallCords.Y, XTension, YTension)
            ElseIf optResultantForce.Checked = True Then
                'Creates resultant arrow
                ArrowHead.Width = 5
                DrawingSHM.DrawLine(ArrowHead, .BallCords.X, .BallCords.Y, XTension, .Center.Y + .PendulumLength)
            End If
  End With
    End Sub

#End Region

    Private Sub ValidateSHM(ByRef Valid As Boolean)
        'Goes through process to validate data
        Dim Test As String
        Test = txtStringLength.Text
        Valid = ValidateSingleDecimalPlace(TransferSHM.PendulumLength, Test, 0.2, 1)
        If Valid = True Then
            Test = txtMaxDisplacement.Text
            Valid = Validate2DecimalPlaces(Test, TransferSHM.MaxDisplacement, 0.01, 0.5)
            If TransferSHM.PendulumLength * (Math.PI / 6) < TransferSHM.MaxDisplacement And Valid = True Then
                MsgBox("Maximum Displacement is too large for the simulation to be accurate")
                Valid = False
            End If
        End If
    End Sub

    Private Sub SaveSHMVariables(sender As Object, e As EventArgs) Handles btnSaveSHM.Click
        Dim Valid As Boolean
        Dim Duplicate As Boolean
        Dim TempVar(2) As Decimal

        'Validates variables
        ValidateSHM(Valid)
        'Transfers data from file
        If Valid = True Then
            Duplicate = False
            FileOpen(5, "SHMVariables.txt", OpenMode.Input)
            FileOpen(2, "Temp.txt", OpenMode.Output)
            While Not EOF(5)
                For N = 1 To 2
                    Input(5, TempVar(N))
                Next
                WriteLine(2, TempVar(1), TempVar(2))
                'Checks there isn't a copy within the file
                If TempVar(1) = TransferSHM.PendulumLength And TempVar(2) = TransferSHM.MaxDisplacement Then
                    Duplicate = True
                End If
            End While

            'If there's a copy, won't save data, otherwise data is saved
            If Duplicate = True Then
                MsgBox("This data is already saved in the file")
            Else
                WriteLine(2, TransferSHM.PendulumLength, TransferSHM.MaxDisplacement)
                MsgBox("Data Saved")
            End If
            FileClose(5)
            FileClose(2)
            'Changes temp file to the SHM file
            Kill("SHMVariables.txt")
            Rename("Temp.txt", "SHMVariables.txt")
        End If
    End Sub

    Private Sub LoadSHMVariables(sender As Object, e As EventArgs) Handles btnLoadSHM.Click
        ReDim VariableLoading.TextBoxesToLoadIn(2)
        'Checks file isn't empty, then changes settings
        If FileLen("SHMVariables.txt") <> 0 Then
            With VariableLoading
                .TextBoxesToLoadIn(1) = txtStringLength
                .TextBoxesToLoadIn(2) = txtMaxDisplacement
                .FileToLoadFrom = "SHMVariables.txt"
                .FileTunnel = 5
                .NumOfVariables = 2
                Me.Hide()
                frmLoadVariables.Show()
            End With
        Else
            MsgBox("There is nothing saved within the file")
        End If
    End Sub

    Function HalfForceArrow(ByVal Coord As Integer, ByVal Center As Integer) As Integer
        'Finds 1/2 of the length of the pendulum height
        HalfForceArrow = CInt((Coord - Center) / 2) + Center
        Return HalfForceArrow
    End Function

    Private Sub ChangeInRadioButton(sender As Object, e As EventArgs) Handles optComponentForces.CheckedChanged
        'If radio buttons are clicked whilst simulation is paused, redraws force arrows
        If imgSHMBall.Visible = True And btnSimulateSHM.Enabled = True Then
            DrawSHMForceArrows()
        End If
    End Sub

#End Region

#Region "Misc SubRoutines"

    Private Sub ClosePage(sender As Object, e As EventArgs) Handles MyBase.FormClosing
        'Prevents threading being paused if program is closed
        AbortThreading()
    End Sub

    Sub SelectAbortThreading(ByVal AbortNum As Integer)
        Select Case AbortNum
            Case 1
                Try
                    BallThrowThreading.Resume()
                Catch
                End Try

                Try
                    BallThrowThreading.Abort()
                Catch
                End Try
            Case 2
                Try
                    ProjectileMotionThreading.Resume()
                Catch
                End Try

                Try
                    ProjectileMotionThreading.Abort()
                Catch
                End Try
            Case 3
                Try
                    SHMThreading.Resume()
                Catch
                End Try

                Try
                    SHMThreading.Abort()
                Catch
                End Try
        End Select
    End Sub


    Sub AbortThreading()
        'Aborts threading if possible
        For N = 1 To 3
            SelectAbortThreading(N)
        Next
    End Sub

    'Showing formulae tabs
    Private Sub ShowSMHFormulae(sender As Object, e As EventArgs) Handles btnSHMFormulae.Click
        frmFormula.Show()
        frmFormula.LoadLabels(3)
    End Sub

    Private Sub ShowPMFormulae(sender As Object, e As EventArgs) Handles btnProjectileFormulae.Click
        frmFormula.Show()
        frmFormula.LoadLabels(2)
    End Sub

    Private Sub ShowBallThrowFormulae(sender As Object, e As EventArgs) Handles btnBallThrowFormula.Click
        frmFormula.Show()
        frmFormula.LoadLabels(1)
    End Sub

    'Drawing routines for when the user performs actions and graph disappears
    Private Sub LoadTab(sender As Object, e As EventArgs) Handles tabMain.SelectedIndexChanged
        DrawBaseLines()
    End Sub

    'Subroutines in order to draw lines if needed
    Private Sub InitialLoad(sender As Object, e As EventArgs) Handles Me.Load
        DrawBaseLines()
        optComponentForces.Checked = True
    End Sub

    Private Sub ActiveForn(sender As Object, e As EventArgs) Handles Me.Activated
        DrawBaseLines()
    End Sub

    Private Sub ChangeText(sender As Object, e As EventArgs) Handles txtGravity.Enter
        DrawBaseLines()
    End Sub

    Private Sub DrawBaseLines()
        Dim DrawGroundLine As Drawing.Graphics
        'Draws the base lines for the menus
        DrawGroundLine = Me.tabMain.SelectedTab.CreateGraphics()
        If tabMain.SelectedTab Is tabBallThrow Then
            DrawGroundLine.DrawLine(Pens.Black, 100, 500, 500, 500)
            DrawGroundLine.DrawLine(Pens.Black, 100, 0, 100, 500)
            DrawGroundLine.DrawLine(Pens.Black, 615, 0, 615, 620)
            ReDrawCircles(DrawGroundLine)
        ElseIf tabMain.SelectedTab Is tabProjectileMotion Then
            DrawGroundLine.DrawLine(Pens.Black, 100, 50, 100, 450)
            DrawGroundLine.DrawLine(Pens.Black, 100, 450, 500, 450)
            DrawGroundLine.DrawLine(Pens.Black, 630, 0, 630, 620)
        ElseIf tabMain.SelectedTab Is tabSHM Then
            DrawGroundLine.DrawLine(Pens.Black, 100, 100, 640, 100)
            DrawGroundLine.DrawLine(Pens.Black, 640, 0, 640, 620)
            DrawGroundLine.DrawLine(Pens.Black, 100, 100, 100, 500)
        End If

    End Sub

    'Saving subroutine used by 2 of the simulations to save data
    Private Sub Save3Variables(ByVal FileName As String, ByVal FileStream As Integer, ByVal ExtraVariable As Decimal, ByVal IsInteger As Boolean)
        Dim Duplicate As Boolean
        Dim TempVar(3) As Integer
        Dim AltTempVar(3) As Decimal

        Duplicate = False
        'Opens a temporary file to save data into
        FileOpen(FileStream, FileName, OpenMode.Input)
        FileOpen(2, "Temp.txt", OpenMode.Output)
        While Not EOF(FileStream)
            For N = 1 To 3
                If IsInteger = True Then
                    Input(FileStream, TempVar(N))
                Else
                    Input(FileStream, AltTempVar(N))
                End If
            Next

            'Saves data based on whether the data is an integer
            If IsInteger = True Then
                WriteLine(2, TempVar(1), TempVar(2), TempVar(3))
            Else
                WriteLine(2, AltTempVar(1), AltTempVar(2), AltTempVar(3))
            End If

            'Checks there aren't duplicates
            If FileName = "BallThrowVariables.txt" Then
                If AltTempVar(1) = PauseBallThrowVariables.Vel And AltTempVar(2) = PauseBallThrowVariables.Acceleration And AltTempVar(3) = ExtraVariable Then
                    Duplicate = True
                End If
            ElseIf FileName = "ProjectileMotionVariables.txt" Then
                If TempVar(1) = PMVariables.VertSpeed And TempVar(2) = PMVariables.HorizonSpeed And TempVar(3) = TransferPM.InitialHeight Then
                    Duplicate = True
                End If
            End If
        End While

        If Duplicate = True Then
            MsgBox("This data is already saved in the file")
        Else
            'Saves data into the correct file if not a duplicate
            If FileName = "BallThrowVariables.txt" Then
                WriteLine(2, PauseBallThrowVariables.Vel, PauseBallThrowVariables.Acceleration, ExtraVariable)
            ElseIf FileName = "ProjectileMotionVariables.txt" Then
                WriteLine(2, PMVariables.VertSpeed, PMVariables.HorizonSpeed, TransferPM.InitialHeight)
            End If
            MsgBox("Data Saved")
        End If

        FileClose(FileStream)
        FileClose(2)
        Kill(FileName)
        Rename("Temp.txt", FileName)
    End Sub
#End Region

End Class