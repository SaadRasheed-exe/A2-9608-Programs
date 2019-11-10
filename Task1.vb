Module Task1

    Dim X As Integer

    Structure Member
        <VBFixedString(20)> Dim Name As String
        Dim ID As Integer
    End Structure

    Sub Main()

        Do Until X = 4

            Console.Clear()

            Console.WriteLine("If you want to output all the records, type 1.")
            Console.WriteLine("If you want to input a record, type 2.")
            Console.WriteLine("If you want to search for a record, type 3.")
            Console.WriteLine("If you want to exit, type 4.")

            X = Console.ReadLine

            If X = 1 Then
                Call Output()
            End If

            If X = 2 Then
                Call Input()
            End If

            If X = 3 Then
                Call Search()
            End If

        Loop

    End Sub

    Sub Output()

        Dim MemberDetails As Member
        Dim recNum, count As Integer

        FileOpen(1, "D:/txt.dat", OpenMode.Random, OpenAccess.ReadWrite, , Len(MemberDetails))

        recNum = LOF(1) / Len(MemberDetails)

        For count = 1 To recNum

            FileGet(1, MemberDetails, count)

            Console.WriteLine("Name: " & MemberDetails.Name)
            Console.WriteLine("Membership ID: " & MemberDetails.ID)

        Next

        FileClose(1)

        Console.ReadKey()

    End Sub

    Sub Input()

        Dim Name As String = ""
        Dim ID As Integer
        Dim recNum As Integer

        Do While Name <> "X"

            Console.Clear()

            Console.WriteLine("Enter Name as X to end program.")

            Console.WriteLine("Enter the name of the member: ")
            Name = Console.ReadLine

            If Name <> "X" Then

                Console.WriteLine("Enter the membership ID of the member: ")
                ID = Console.ReadLine

                Dim NewMember As Member

                NewMember.Name = Name
                NewMember.ID = ID

                Try
                    FileOpen(1, "D:/txt.dat", OpenMode.Random, OpenAccess.ReadWrite, , Len(NewMember))
                Catch ex As Exception
                    Console.WriteLine("Failure.")
                End Try

                recNum = LOF(1) / Len(NewMember)
                recNum = recNum + 1

                FilePut(1, NewMember, recNum)
                FileClose(1)

            End If

            Console.Clear()

        Loop

    End Sub

    Sub Search()

        Console.Clear()

        Dim Name As String
        Dim SearchMember As Member
        Dim recNum As Integer
        Dim Count As Integer

        Console.WriteLine("Input the name to search: ")
        Name = NameCorrection(Console.ReadLine)

        Count = 1

        FileOpen(1, "D:/txt.dat", OpenMode.Random, OpenAccess.ReadWrite, , Len(SearchMember))

        recNum = LOF(1) / Len(SearchMember)

        Do Until SearchMember.Name = Name Or Count > recNum

            FileGet(1, SearchMember, Count)

            If SearchMember.Name = Name Then

                Console.WriteLine("ID: " & SearchMember.ID)

            End If

            Count = Count + 1

            If Count > recNum Then
                Console.WriteLine("Name not found.")
            End If

        Loop

        FileClose(1)

        Console.ReadKey()

    End Sub

    Function NameCorrection(ByVal name As String) As String

        Dim newName As String
        Dim length As Integer

        newName = name
        length = 20 - Len(name)

        For count = 1 To length

            newName = newName & " "

        Next

        Return newName

    End Function

End Module
