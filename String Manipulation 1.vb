Module Module1

    Sub Main()

        Dim String1 As String
        Dim String2 As String
        Dim Output As String = ""

        Console.WriteLine("Enter the first string.")
        String1 = Console.ReadLine
        Console.WriteLine("Enter the second string.")
        String2 = Console.ReadLine

        Dim m As Integer
        m = InStr(String1, " ")
        Output &= Left(String1, m - 1)

        Dim check As String = ""
        m = Len(String2)

        Do Until check = " "
            check = Mid(String2, m, 1)
            m -= 1
        Loop

        Output &= Right(String2, Len(String2) - m)
        Console.WriteLine(Output & ".")

        Console.ReadKey()
    End Sub

End Module