Module Module1

    Sub Main()
        Dim MemberID As Integer
        Dim Name, searchN As String

        Console.Write("Enter Name to search for: ")
        searchN = Console.ReadLine

        FileOpen(1, "C:\HamzaPROJECTS\Task 1.1\Members.txt", OpenMode.Input)

        While Not EOF(1)
            Input(1, MemberID)
            Input(1, Name)


            If Name = searchN Then
                Console.WriteLine("Member ID. :" & MemberID)
                Console.WriteLine("Member name :" & Name)
            End If
        End While
        FileClose(1)

        Console.ReadKey()

    End Sub

End Module
