Module Module1


    Sub Main()

        Dim MemberID, Newmembers As Integer
        Dim Name As String


        Console.WriteLine("Enter Number Of New Members : ")
        NewMembers = Console.ReadLine

        For Count = 1 To Newmembers


            Console.Write("Enter MemberID: ")
            MemberID = Console.ReadLine

            Console.WriteLine("Enter Member name: ")
            Name = Console.ReadLine


            FileOpen(1, "C:\HamzaPROJECTS\Members.txt", OpenMode.Append)

            WriteLine(1, MemberID)
            WriteLine(1, Name)

            FileClose(1)

        Next

        Console.ReadKey()
    End Sub

End Module
