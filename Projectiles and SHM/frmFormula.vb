Public Class frmFormula

    Public Sub LoadLabels(ByVal LoadFrom As Integer)

        Select Case LoadFrom
            Case 1, 2
                'Changes form if from the Projectile motion or ball throw simulation
                lblTitle1.Text = "SUVAT Equations"
                lblFormula1.Text = "a = (v - u) / t"
                lblFormula2.Text = "v = u + a * t"
                lblFormula3.Text = "s = u * t + 0.5 * a * ( t^2)"
                lblFormula4.Text = "v^2 = u^2 + 2 * a * s"
                lblFormula5.Text = "s = t * (u + v) /2"
                lblFormula6.Text = "F = m * a"
                lblFormula7.Text = ""
                lblFormula8.Text = ""
                lblSymbol1.Text = "s = Discplacement"
                lblSymbol2.Text = "u = Initial Velocity"
                lblSymbol3.Text = "v = Final Velocity"
                lblSymbol4.Text = "a = Acceleration"
                lblSymbol5.Text = "t = Time"
                lblSymbol6.Text = "F = Force"
                lblSymbol7.Text = "m = Mass"
                lblSymbol8.Text = ""
                lblSymbol9.Text = ""
                imgTriangle.Visible = False
                lblTitle3.Visible = False
                lblTrig1.Visible = False
                lblTrig2.Visible = False
                lblTrig3.Visible = False
                If LoadFrom = 1 Then
                    lblMainTitle.Text = "Ball Throw Formula"
                Else
                    lblMainTitle.Text = "Projectile Motion Formula"
                End If
            Case 3
                'Changes form if from SHM simulation 
                lblTitle1.Text = "SHM Equations"
                lblFormula1.Text = "x = L * θ"
                lblFormula2.Text = "T = 1 / f"
                lblFormula3.Text = "a = - x * (2πf)^2 "
                lblFormula4.Text = "x = A cos(2πf * t)"
                lblFormula5.Text = "v = ± 2πf * √( A^2 - x^2)"
                lblFormula7.Text = "T = 2π * √( L / g)"
                lblFormula4.Location = New Point(155, 72)
                lblFormula5.Location = New Point(155, 96)
                lblFormula7.Location = New Point(155, 120)
                lblFormula6.Text = "F = m * a"
                lblFormula6.Location = New Point(12, 166)
                lblTitle2.Location = New Point(12, 142)
                lblSymbol1.Text = "x = Displacement"
                lblSymbol2.Text = "L = Length"
                lblSymbol3.Text = "θ = Angle"
                lblSymbol4.Text = "T = Time Period"
                lblSymbol5.Text = "f = Frequency"
                lblSymbol6.Text = "a = Acceleration"
                lblSymbol7.Text = "A = Max Displacement"
                lblSymbol8.Text = "v = Velocity"
                lblSymbol9.Text = "g = Acceleration due to Gravity"
                imgTriangle.Visible = True
                lblTitle3.Visible = True
                lblTrig1.Visible = True
                lblTrig2.Visible = True
                lblTrig3.Visible = True
                lblMainTitle.Text = "Simple Harmonic Motion Formula"
        End Select

    End Sub

End Class