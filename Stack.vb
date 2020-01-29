Module Module1

    Dim Choice As Integer = 0
    Dim Stack(9) As String
    Dim Top As Integer

    Sub Main()

        Do While Choice <> 3 Or Top < 9
            Call DisplayMenu()
            Call ChooseOption()
        Loop

    End Sub

    Sub DisplayMenu()

        Console.Clear()
        Console.WriteLine("1: Push.")
        Console.WriteLine("2: Pop.")
        Console.WriteLine("3: Exit Program.")
        Console.WriteLine("Choose a number between 1 and 3: ")


    End Sub

    Sub ChooseOption()

        Choice = Console.ReadLine()

        Do While Choice < 1 And Choice > 3
            Choice = Console.ReadLine()
            Console.Clear()
            Console.WriteLine("Invalid entry. Choose a number between 1 and 3.")
            Console.ReadKey()
        Loop
        Select Case Choice
            Case 1
                Call Push()
            Case 2
                Call Pop()
            Case 3
                Exit Select
            Case Else
                Console.Clear()
                Console.WriteLine("Invalid entry. Choose a number between 1 and 3.")
                Console.ReadKey()
        End Select

    End Sub

    Sub Push()

        If Top > 9 Then

            Console.WriteLine("Data overflow. Pop a value to insert another.")
            Console.ReadKey()

        Else

            Dim Value As String
            Console.WriteLine("Enter the value to push.") : Value = Console.ReadLine()
            Stack(Top) = Value
            Top += 1

        End If

    End Sub

    Sub Pop()

        If Top < 0 Then

            Console.WriteLine("Data underflow. The stack is empty.")
            Console.ReadKey()

        Else

            Dim Value As String
            Top -= 1
            Value = Stack(Top)
            Console.WriteLine("The value poped is: " & Value)
            Console.ReadKey()

        End If

    End Sub

End Module
