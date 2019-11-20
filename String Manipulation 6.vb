Module Module1

    Sub Main()

        Dim Vowels As Integer
        Dim LineString As String
        Dim Count As Integer

        Console.WriteLine("Enter the line to check for vowels.")
        LineString = Console.ReadLine

        For Count = 1 To Len(LineString)

            If Mid(LineString, Count, 1) = "A" Or Mid(LineString, Count, 1) = "a" Or Mid(LineString, Count, 1) = "E" Or Mid(LineString, Count, 1) = "e" Then
                Vowels += 1
            End If

            If Mid(LineString, Count, 1) = "I" Or Mid(LineString, Count, 1) = "i" Or Mid(LineString, Count, 1) = "O" Or Mid(LineString, Count, 1) = "o" Then
                Vowels += 1
            End If

            If Mid(LineString, Count, 1) = "U" Or Mid(LineString, Count, 1) = "u" Then
                Vowels += 1
            End If

        Next

        Console.WriteLine("The number of vowels in the line is " & Vowels & ".")

        Console.ReadKey()
    End Sub

End Module