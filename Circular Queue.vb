Module Module1

    Dim Queue(9) As String
    Dim Front As Integer
    Dim Back As Integer
    Dim Choice As Integer
    Dim FullQ, EmptyQ As Boolean


    Sub Main()

        Front = 0
        Back = 0
        FullQ = False
        EmptyQ = True

        Do While Choice <> 3

            Console.Clear()
            Call DisplayQueue()
            Call DisplayMenu()
            Call Choose()

        Loop

    End Sub

    Sub Add()

        Dim value As String

        If FullQ = False Then
            Console.WriteLine("Enter the value to add to queue.")
            value = Console.ReadLine
            Queue(Back) = value
            EmptyQ = False
            If Back >= 9 Then
                Back = 0
            Else
                Back += 1
            End If
            If Front = Back Then
                FullQ = True
            End If
        Else
            Console.WriteLine("Overflow. There is no space in the queue left.")
            Console.ReadKey()
        End If

    End Sub

    Sub Delete()

        Dim value As String

        If EmptyQ = True Then
            Console.WriteLine("Underflow. There is no value to delete from the queue.")
            Console.ReadKey()
        Else
            value = Queue(Front)
            FullQ = False
            Console.WriteLine("The value deleted is: " & value)
            If Front >= 9 Then
                Front = 0
            Else
                Front += 1
            End If
            If Front = Back Then
                EmptyQ = True
            End If
            Console.ReadKey()
        End If


    End Sub

    Sub DisplayMenu()

        Console.WriteLine("1. Add")
        Console.WriteLine("2. Delete")
        Console.WriteLine("3. Exit program")

    End Sub

    Sub Choose()

        Console.WriteLine("Choose an option: ")
        Choice = Console.ReadLine()
Line1:
        Do While Choice < 1 Or Choice > 3
            Console.WriteLine("Invalid Entry. Enter a valid choice between 1 and 3: ")
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

    Sub DisplayQueue()

        Console.WriteLine("Front: " & Front)
        Console.WriteLine("Back: " & Back)
        For Count = 0 To 9
            Console.WriteLine(Count & ". " & Queue(Count))
        Next

    End Sub

End Module
