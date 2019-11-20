Module Module1

    Sub Main()

        Dim Digits, Count As Integer
        Dim Alphabets As Integer
        Dim LineString As String

        Console.WriteLine("Enter the string value.")
        LineString = Console.ReadLine

        For Count = 1 To Len(LineString)

            If Asc(Mid(LineString, Count, 1)) >= 65 And Asc(Mid(LineString, Count, 1)) <= 90 Then
                Alphabets += 1
            End If

            If Asc(Mid(LineString, Count, 1)) >= 97 And Asc(Mid(LineString, Count, 1)) <= 122 Then
                Alphabets += 1
            End If

            If Asc(Mid(LineString, Count, 1)) >= 48 And Asc(Mid(LineString, Count, 1)) <= 57 Then
                Digits += 1
            End If

        Next

        Console.WriteLine("The number of digits in the line is " & Digits & " and the number of alphabets in the line is " & Alphabets & ".")

        Console.ReadKey()
    End Sub

End Module