Module Module1

    Sub Main()

        Dim Removant As Char
        Dim LineString As String
        Dim Output As String = ""
        Dim Count As Integer

        Console.WriteLine("Input the character to remove.")
        Removant = Console.ReadLine

        Console.WriteLine("Input the string to remove the character from.")
        LineString = Console.ReadLine

        For Count = 1 To Len(LineString)

            If Mid(LineString, Count, 1) = Removant Then
            Else
                Output &= Mid(LineString, Count, 1)
            End If

        Next

        Console.WriteLine(Output)

        Console.ReadKey()
    End Sub

End Module