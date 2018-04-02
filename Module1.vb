Module Module1

    Sub Main()
        Dim choice As Integer = 0
        While choice = 0
            Console.WriteLine("Enter the height of the house")
            Dim n As Integer = Console.ReadLine
            Console.WriteLine("Enter the color of the house")
            Dim color As String = Console.ReadLine
            If color = "red" Then
                Console.ForegroundColor = ConsoleColor.Red
            ElseIf color = "blue" Then
                Console.ForegroundColor = ConsoleColor.Blue
            ElseIf color = "yellow" Then
                Console.ForegroundColor = ConsoleColor.Yellow
            ElseIf color = "cyan" Then
                Console.ForegroundColor = ConsoleColor.Cyan
            ElseIf color = "green" Then
                Console.ForegroundColor = ConsoleColor.Green
            End If
            Dim half_heihgt As Integer = n / 2
            Dim z As Integer = half_heihgt - 1
            Dim l As Integer = n - 1
            Dim x3 As Integer = n + 2 + half_heihgt
            Dim x4 As Integer = n + 2
            Dim x6 As Integer = z
            Dim c As Integer = 1
            Dim M1 As Integer = half_heihgt + 1
            Dim i, e1, e2, e4, i2, i3, i4, E, B, M, R, R1 As Integer
            For i = 0 To n
                If (i = 0) Then
                    For e1 = 0 To half_heihgt
                        Console.Write(" ")
                    Next
                    For e2 = 0 To x4
                        Console.Write("*")
                    Next
                    Console.WriteLine()
                ElseIf (i > 0 And i < ((half_heihgt) - 1)) Then
                    For i2 = 0 To z
                        For i3 = 0 To x6
                            Console.Write(" ")
                        Next
                        Console.Write("*")
                        For E = 0 To c - 1
                            Console.BackgroundColor = 1
                            Console.Write(" ")
                        Next
                        Console.BackgroundColor = ConsoleColor.Black
                        Console.Write("*")
                        For B = 0 To l
                            Console.BackgroundColor = 1
                            Console.Write(" ")
                        Next
                        Console.BackgroundColor = ConsoleColor.Black
                        Console.Write("*")
                        l = l - 1
                        x6 = x6 - 1
                        c = c + 2
                        Console.WriteLine()
                        i = i + 1
                    Next
                    Console.Write(" ")
                ElseIf (i = half_heihgt + 2) Then
                    For M = 0 To x3
                        Console.Write("*")
                    Next
                    Console.WriteLine()
                ElseIf (i > half_heihgt And i <= (n - 2)) Then
                    For R = 0 To z
                        Console.Write(" *")
                        For R1 = 0 To n - 2
                            Console.BackgroundColor = ConsoleColor.Magenta
                            Console.Write(" ")
                        Next
                        Console.BackgroundColor = ConsoleColor.Black
                        Console.Write("*")
                        For e4 = 0 To M1 - 1
                            Console.BackgroundColor = ConsoleColor.Magenta
                            Console.Write(" ")
                        Next
                        Console.BackgroundColor = ConsoleColor.Black
                        Console.Write("*")
                        Console.WriteLine()
                        i = i + 1
                    Next
                Else
                End If
            Next
            Console.Write(" ")
            For i4 = 0 To x3
                Console.Write("*")
            Next
            Console.ForegroundColor = ConsoleColor.White
            Console.WriteLine()
            Console.WriteLine("Press 0 to continue, 1 to terminate")
            choice = Console.ReadLine
        End While
    End Sub

End Module
