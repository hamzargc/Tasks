Module Module1

    Sub Main()
        Dim MemberID, Members As Integer
        Dim Telephone As String
        Dim JoinDate As Date


        Console.WriteLine("Enter Number Of Members : ")
        Members = Console.ReadLine

        For Count = 1 To Members


            Console.Write("Enter MemberID: ")
            MemberID = Console.ReadLine



            Console.WriteLine("Enter Member Cell Number: ")
            Telephone = Console.ReadLine

            Console.WriteLine("Enter Member Join Date: ")
            JoinDate = Console.ReadLine


            FileOpen(1, "C:\HamzaPROJECTS\Task 1.1\Members.txt", OpenMode.Append)

            WriteLine(1, MemberID)
            WriteLine(1, Telephone)
            WriteLine(1, JoinDate)

            FileClose(1)

        Next

        Console.ReadKey()
    End Sub

End Module
