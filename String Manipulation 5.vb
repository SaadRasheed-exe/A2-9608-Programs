Module Module1

    Sub Main()

        Dim LineString As String
        Dim Count As Integer
        Dim Output As String

        Console.WriteLine("Enter the string value to invert.")
        LineString = Console.ReadLine

        For Count = Len(LineString) To 1 Step -1
            Output &= Mid(LineString, Count, 1)
        Next

        Console.WriteLine(Output)

        Console.ReadKey()
    End Sub

End Module