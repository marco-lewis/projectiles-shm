Module Variables

    Structure BallThrowVariables
        Dim Vel As Decimal
        Dim TakeRecord As Integer
        Dim Acceleration As Decimal
        Dim Ratio As Decimal
    End Structure

    Structure ProjectilePauseVariables
        Dim VertSpeed As Decimal
        Dim HorizonSpeed As Integer
    End Structure

    Structure TransferProjectileInitalVariables
        Dim TimeRequired As Decimal
        Dim Acceleration As Decimal
        Dim InitialHeight As Decimal
    End Structure

    Structure TransferForSHM
        Dim Center As Point
        Dim BallCords As Point
        Dim Angle As Decimal
        Dim PendulumLength As Decimal
        Dim MaxDisplacement As Decimal
    End Structure

    Structure LoadVariables
        Dim DataFromFile(,) As Decimal
        Dim NumofRows As Integer
        Dim Selected As Boolean
        Dim FileToLoadFrom As String
        Dim TextBoxesToLoadIn() As TextBox
        Dim NumericUpDownToLoadIn() As NumericUpDown
        Dim FileTunnel As Integer
        Dim NumOfVariables As Integer
    End Structure

    Public TransferPM As TransferProjectileInitalVariables
    Public PauseBallThrowVariables As BallThrowVariables
    Public PMVariables As ProjectilePauseVariables
    Public TransferSHM As TransferForSHM
    Public VariableLoading As LoadVariables
End Module
