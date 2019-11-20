Module Module1

    Sub Main()

        Dim Replacer As Char
        Dim Replacant As Char
        Dim LineString As String
        Dim Output As String = ""
        Dim Count As Integer

        Console.WriteLine("Input the character to replace.")
        Replacer = Console.ReadLine

        Console.WriteLine("Enter the character to be replaced.")
        Replacant = Console.ReadLine

        Console.WriteLine("Input the string to remove the character from.")
        LineString = Console.ReadLine

        For Count = 1 To Len(LineString)

            If Mid(LineString, Count, 1) = Replacant Then
                Output &= Replacer
            Else
                Output &= Mid(LineString, Count, 1)
            End If

        Next

        Console.WriteLine(Output)

        Console.ReadKey()
    End Sub

End Module