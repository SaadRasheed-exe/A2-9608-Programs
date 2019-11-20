Module Module1

    Sub Main()

        Dim LineString, StringChecker As String
        Console.WriteLine("Input the string value.")
        LineString = LCase(Console.ReadLine)
        StringChecker = ""

        Dim BooleanChecker As Boolean = True
        Dim Count, Count2, count3 As Integer
        Count2 = 97

        Do Until Len(StringChecker) = 26 Or BooleanChecker = False

            If count3 > 1000 Then
                BooleanChecker = False
            End If

            For Count = 1 To Len(LineString)

                If Asc(Mid(LineString, Count, 1)) = Count2 Then
                    StringChecker &= Mid(LineString, Count, 1)
                    Count2 += 1
                End If

            Next

            count3 += 1

        Loop

        If StringChecker = "abcdefghijklmnopqrstuvwxyz" Then
            Console.WriteLine("The string is a pangram.")
        Else
            Console.WriteLine("The string is not a pangram.")
        End If

        Console.ReadKey()
    End Sub

End Module