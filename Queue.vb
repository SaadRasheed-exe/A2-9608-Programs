Module Module1

    Dim Head As Integer
    Dim Tail As Integer
    Dim Queue(9) As String
    Dim Choice As Integer


    Sub Main()

        Head = 0
        Tail = 0
        Do While Choice <> 3

            Call DisplayMenu()
            Call Choose()

        Loop

        Console.WriteLine("Thank you for testing out my program.")
        Console.ReadKey()

    End Sub

    Sub Add()

        Dim Value As String

        If Tail = 9 Then
            Console.WriteLine("Overflow. The value cannot be added to the queue.")
            Console.ReadKey()
        Else
            Console.WriteLine("Enter value to add to queue.")
            Value = Console.ReadLine()
            Queue(Tail) = Value
            Tail += 1
        End If


    End Sub

    Sub Delete()

        If Tail = 0 Then
            Console.WriteLine("Underflow. There is no value in queue to delete.")
            Console.ReadKey()
        Else
            Dim Value As String
            Value = Queue(Head)
            Head += 1
            Console.WriteLine("The value deleted is: " & Value)
            Console.ReadKey()

            Call Adjuster()
        End If

    End Sub

    Sub DisplayMenu()

        Console.Clear()
        Call DisplayQueue()
        Console.WriteLine()
        Console.WriteLine("1: Add.")
        Console.WriteLine("2: Delete.")
        Console.WriteLine("3: Exit Program.")

    End Sub

    Sub Choose()

        Console.WriteLine("Enter a number between 1 and 3.")
        Choice = Console.ReadLine()

Line1:
        Do While Choice < 1 Or Choice > 3

            Console.Clear()
            Console.WriteLine("Invalid Entry. Choose a number between 1 and 3.")
            Console.ReadKey()
            Choice = Console.ReadLine()

        Loop

        Select Case Choice
            Case 1
                Call Add()
            Case 2
                Call Delete()
            Case 3
                Exit Select
            Case Else
                GoTo Line1
        End Select

    End Sub

    Sub Adjuster()

        Dim A As Integer
        A = Head

        If Head > 0 Then

            For Count = Head To Tail

                Queue(A - 1) = Queue(A)
                A += 1

            Next

            Tail -= 1
            Head = 0

        End If

    End Sub

    Sub DisplayQueue()

        Console.WriteLine("Head: " & Head)
        Console.WriteLine("Tail: " & Tail)
        For Count = 0 To 9
            Console.WriteLine(Count & ". " & Queue(Count))
        Next

    End Sub


End Module
