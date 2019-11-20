Module Module1

    Sub Main()

        Dim StringChecker1, StringChecker2 As String
        Dim LineString1, LineString2 As String
        StringChecker2 = ""
        StringChecker1 = ""

        Console.WriteLine("Enter the first string value.")
        LineString1 = LCase(Console.ReadLine)

        Console.WriteLine("Enter the second string value.")
        LineString2 = LCase(Console.ReadLine)

        Dim Count, length1, length2, Count2 As Integer
        length1 = Len(LineString1)
        length2 = Len(LineString2)

        Count2 = 1
        If length1 <> length2 Then
            GoTo line1
        End If

        For Count = 97 To 122

            Do Until Count2 = length1
                If Asc(Mid(LineString1, Count2, 1)) = Count Then
                    StringChecker1 &= Mid(LineString1, Count2, 1)
                End If
                If Asc(Mid(LineString2, Count2, 1)) = Count Then
                    StringChecker2 &= Mid(LineString2, Count2, 1)
                End If
                Count2 += 1
            Loop

        Next

        If StringChecker1 = StringChecker2 Then
            Console.WriteLine("The two lines are anagrams of each other.")

        Else
line1:
            Console.WriteLine("The two string are not anagrams of each other")
        End If

        Console.ReadKey()
    End Sub

End Module