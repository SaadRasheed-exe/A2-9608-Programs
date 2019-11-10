Module Module1

    Structure Member
        <VBFixedString(20)> Dim Name As String
        Dim ID As Integer
    End Structure

    Structure NewMember
        <VBFixedString(20)> Dim Name As String
        Dim ID As Integer
        <VBFixedString(20)> Dim Telephone As String
        <VBFixedString(20)> Dim StartDate As String
    End Structure

    Sub Main()

        Dim x As Integer = Console.ReadLine
        Dim oldMember As Member
        Dim newMember As NewMember
        Dim recNum As Integer

        FileOpen(1, "D:/txt.dat", OpenMode.Random, OpenAccess.ReadWrite, , Len(oldMember))
        FileOpen(2, "D:/txt2.dat", OpenMode.Random, OpenAccess.ReadWrite, , Len(newMember))
        recNum = LOF(1) / Len(oldMember)

        Dim count As Integer

        For count = 1 To recNum

            FileGet(1, oldMember, count)
            newMember.Name = oldMember.Name
            newMember.ID = oldMember.ID

            Console.WriteLine("Enter the telephone number for " & oldMember.Name & ": ")
            newMember.Telephone = Console.ReadLine

            Console.WriteLine("Enter the membership start date for " & oldMember.Name & ": ")
            newMember.StartDate = Console.ReadLine

            FilePut(2, newMember, count)

        Next

        Call Output(recNum)

        FileClose(1)
        FileClose(2)

    End Sub

    Sub Output(ByVal recnum As Integer)

        Dim memberDetails As NewMember

        Dim count As Integer

        For count = 1 To recnum

            FileGet(2, memberDetails, count)

            Console.WriteLine("Name: " & memberDetails.Name)
            Console.WriteLine("Membership ID: " & memberDetails.ID)
            Console.WriteLine("Telephone: " & memberDetails.Telephone)
            Console.WriteLine("Membership Start Date: " & memberDetails.StartDate)

        Next

        Console.ReadKey()

    End Sub

End Module
