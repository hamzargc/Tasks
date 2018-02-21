Module Module1

    Sub Main()
        Dim MemberID, Members As Integer
        Dim Telephone, Name As String
        Dim JoinDate As Date


        Console.WriteLine("Enter Number Of Members : ")
        Members = Console.ReadLine

        For Count = 1 To Members


            Console.Write("Enter MemberID: ")
            MemberID = Console.ReadLine


            Console.WriteLine("Enter Member Name: ")
            Name = Console.ReadLine


            Console.WriteLine("Enter Member Cell Number: ")
            Telephone = Console.ReadLine

            Console.WriteLine("Enter Member Join Date: ")
            JoinDate = Console.ReadLine




            FileOpen(1, "C:\HamzaPROJECTS\Task 1.1\addMembers.txt", OpenMode.Append)

            WriteLine(1, MemberID)
            WriteLine(1, Telephone)
            WriteLine(1, JoinDate)
            WriteLine(1, Name)

            FileClose(1)

        Next

        Console.ReadKey()
    End Sub

End Module
