Public Class Form1
    Dim astPeople(4, 5) As String
    Dim x As Integer
    Dim y As Integer
    Public Sub InitializeData()

        astPeople(0, 0) = "Barack"
        astPeople(1, 0) = "Obama"
        astPeople(2, 0) = "Male"
        astPeople(3, 0) = "American"
        astPeople(4, 0) = "President"

        astPeople(0, 1) = "Jacinda"
        astPeople(1, 1) = "Ardern"
        astPeople(2, 1) = "Female"
        astPeople(3, 1) = "New Zealand"
        astPeople(4, 1) = "Prime Minister"

        astPeople(0, 2) = "Ada"
        astPeople(1, 2) = "Lovelace"
        astPeople(2, 2) = "Female"
        astPeople(3, 2) = "British"
        astPeople(4, 2) = "Mathematician"

        astPeople(0, 3) = "Albert"
        astPeople(1, 3) = "Einstein"
        astPeople(2, 3) = "Male"
        astPeople(3, 3) = "Swiss"
        astPeople(4, 3) = "Scientist"

        astPeople(0, 4) = "Vincent"
        astPeople(1, 4) = "van Gogh"
        astPeople(2, 4) = "Male"
        astPeople(3, 4) = "Dutch"
        astPeople(4, 4) = "Artist"

        astPeople(0, 5) = "Mahatma"
        astPeople(1, 5) = "Ganghi"
        astPeople(2, 5) = "Male"
        astPeople(3, 5) = "Indian"
        astPeople(4, 5) = "Lawyer"
    End Sub
    Private Sub btnGo1_Click(sender As Object, e As EventArgs) Handles btnGo1.Click

        InitializeData()

        For x = 0 To 4 ' Iterate through rows
            Dim rowData As String = ""

            For y = 0 To 5 ' Iterate through columns
                rowData += astPeople(x, y) & " "
            Next

            MsgBox(rowData.Trim()) ' Display the row data
        Next
    End Sub


    Private Sub btnGo2_Click(sender As Object, e As EventArgs) Handles btnGo2.Click

        InitializeData()

        For y = 0 To 5 ' Iterate through columns
            Dim columnData As String = ""

            For x = 0 To 4 ' Iterate through rows
                columnData += astPeople(x, y) & vbCrLf ' Use vbCrLf for a new line
            Next

            MsgBox(columnData.Trim()) ' Display the column data
        Next
    End Sub

    Private Sub btnGo3_Click(sender As Object, e As EventArgs) Handles btnGo3.Click

        InitializeData()

        Dim allData As String = ""

        For x = 0 To 4 ' Iterate through rows
            For y = 0 To 5 ' Iterate through columns
                allData += astPeople(x, y) & " "
            Next
            allData += vbCrLf ' New line after each row
        Next

        MsgBox(allData.Trim()) ' Display all the data
    End Sub

    Private Sub btnGo4_Click(sender As Object, e As EventArgs) Handles btnGo4.Click
        InitializeData()
        Dim stTarget As String
        Dim bFound As Boolean
        bFound = False
        Dim stOut As String
        stTarget = InputBox("Enter the surname of the person you want to find")

        For y = 0 To 5
            If astPeople(1, y) = stTarget Then
                bFound = True
                Exit For
            End If
        Next

        If bFound = True Then
            For x = 0 To 4
                stOut = stOut & astPeople(x, y) & " "
            Next
        Else
            stOut = "Not Found"
        End If

        MsgBox(stOut)

    End Sub
End Class
