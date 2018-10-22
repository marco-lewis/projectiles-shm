Public Class frmLoadVariables

    Private Sub LoadToTable(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Row As Integer
        ReDim VariableLoading.DataFromFile(20, 3)
        'Resets text
        lstVariables.ResetText()
        Row = 1
        With VariableLoading
            'Opens file specified depending on simulation
            FileOpen(.FileTunnel, .FileToLoadFrom, OpenMode.Input)
            While Not EOF(.FileTunnel)
                'Inputs data based on number of variables
                For Column = 1 To .NumOfVariables
                    Input(.FileTunnel, .DataFromFile(Row, Column))
                Next
                'For SHM variables, there are only 2, so different ways to add items
                If .FileTunnel <> 5 Then
                    lstVariables.Items.Add(.DataFromFile(Row, 1) & " ".PadRight(5) & "| " & .DataFromFile(Row, 2) & " ".PadRight(5) & "| " & .DataFromFile(Row, 3))
                Else
                    lstVariables.Items.Add(.DataFromFile(Row, 1) & " ".PadRight(5) & "| " & .DataFromFile(Row, 2))
                End If
                Row = Row + 1
            End While
            Select Case .FileTunnel
                Case 1
                    lblTitle.Text = "Key: Initial Velocity | Acceleration | Initial Height"
                    Me.Text = "Load Ball Throw Variables"
                Case 4
                    lblTitle.Text = "Key: Vertical Velocity | Horizontal Velocity | Initial Height"
                    Me.Text = "Load Projectile Motion Variables"
                Case 5
                    lblTitle.Text = "Key: Pendulum Lenght | Max Displacement"
                    Me.Text = "Load SHM Variables"
            End Select
            .NumofRows = Row
            .Selected = False
            FileClose(.FileTunnel)
        End With
    End Sub

    Private Sub LineSelected(sender As Object, e As EventArgs) Handles lstVariables.SelectedValueChanged
        'Checks user has selected an item
        VariableLoading.Selected = True
    End Sub

    Private Sub LoadVariablesToForm(sender As Object, e As EventArgs) Handles btnLoadBT.Click
        Dim LineRequired As String
        Dim TestLine As String
        Dim CurrentRow As Integer

        With VariableLoading
            'Loads variables if an item is selected
            If .Selected = True Then
                LineRequired = lstVariables.SelectedItem.ToString
                'Checks data isn't deleted
                If LineRequired <> "-" Then
                    CurrentRow = 0
                    Do
                        TestLine = lstVariables.Items(CurrentRow)
                        CurrentRow = CurrentRow + 1
                    Loop Until TestLine = LineRequired
                    Form1.Show()
                    'Obtains data depending on simulation
                    If .FileToLoadFrom = "BallThrowVariables.txt" Then
                        .NumericUpDownToLoadIn(1).Value = .DataFromFile(CurrentRow, 1)
                        .TextBoxesToLoadIn(1).Text = .DataFromFile(CurrentRow, 2)
                        .NumericUpDownToLoadIn(2).Value = .DataFromFile(CurrentRow, 3)
                    ElseIf .FileToLoadFrom = "ProjectileMotionVariables.txt" Then
                        .TextBoxesToLoadIn(1).Text = .DataFromFile(CurrentRow, 1)
                        .TextBoxesToLoadIn(2).Text = .DataFromFile(CurrentRow, 2)
                        .TextBoxesToLoadIn(3).Text = .DataFromFile(CurrentRow, 3)
                    ElseIf .FileToLoadFrom = "SHMVariables.txt" Then
                        .TextBoxesToLoadIn(1).Text = .DataFromFile(CurrentRow, 1)
                        .TextBoxesToLoadIn(2).Text = .DataFromFile(CurrentRow, 2)
                    End If
                    Me.Close()
                Else
                    MsgBox("These variables are deleted")
                End If
            Else
                MsgBox("No Variables have been selected")
            End If
        End With
    End Sub

    Private Sub DeleteVariables(sender As Object, e As EventArgs) Handles btnDeleteData.Click
        Dim LineRequired As String
        Dim TestLine As String
        Dim CurrentRow As Integer
        'Checks a variable is selected
        If VariableLoading.Selected = True Then
            LineRequired = lstVariables.SelectedItem.ToString
            CurrentRow = 0
            'Goes through rows until it finds the correct row
            Do
                TestLine = lstVariables.Items(CurrentRow)
                CurrentRow = CurrentRow + 1
            Loop Until TestLine = LineRequired
            lstVariables.Items(CurrentRow - 1) = "-"
        End If
    End Sub

    Private Sub SaveVariables(sender As Object, e As EventArgs) Handles MyBase.Closing
        Dim TempVar As String
        Dim SaveVars(3) As Decimal
        Dim ColumnNum As Integer
        Dim Accepted As Boolean
        Dim RowNumber As Integer

        'Opens a temporary file and saves the data from the form to it
        FileOpen(2, "Temp.txt", OpenMode.Output)
        RowNumber = 1
        Do
            ColumnNum = 1
            Accepted = True
            Do
                If Accepted = True Then
                    'Checks data isn't corrupt
                    TempVar = VariableLoading.DataFromFile(RowNumber, ColumnNum)
                    If lstVariables.Items(RowNumber - 1) = "-" Then
                        Accepted = False
                    Else
                        Accepted = ValidateSingleDecimalPlaceWithoutBounds(SaveVars(ColumnNum), TempVar)
                    End If
                End If
                ColumnNum = ColumnNum + 1
            Loop Until ColumnNum > VariableLoading.NumOfVariables Or Accepted = False
            'Saves data if isn't corrupt
            If Accepted = True Then
                For WriteInVariables = 1 To VariableLoading.NumOfVariables
                    If WriteInVariables = VariableLoading.NumOfVariables Then
                        WriteLine(2, SaveVars(WriteInVariables))
                    Else
                        Write(2, SaveVars(WriteInVariables))
                    End If
                Next
            End If
            RowNumber = RowNumber + 1
        Loop Until RowNumber = VariableLoading.NumofRows
        'Closes and deletes the old file, renaming the new one
        FileClose(2)
        FileClose(VariableLoading.FileTunnel)
        Kill(VariableLoading.FileToLoadFrom)
        Rename("Temp.txt", VariableLoading.FileToLoadFrom)
        Form1.Show()
    End Sub

    Function ValidateSingleDecimalPlaceWithoutBounds(ByRef VariableToTest As Decimal, ByVal Test As String)
        Dim Expression As String = "\d*(\.\d)?"
        Dim SingleDpRegEx As New System.Text.RegularExpressions.Regex(Expression)
        'Tries to match the test to the regex
        If SingleDpRegEx.IsMatch(Test) = True Then
            Try
                'Checks that test can be converted to decimal
                VariableToTest = CDec(Test)
                Return True
            Catch
                Return False
            End Try
        Else
            Return False
        End If
    End Function

End Class