Module Module1

    Sub Main()
        Dim MemberID As Integer
        Dim Name As String


        FileOpen(1, "C:\HamzaPROJECTS\Members.txt", OpenMode.Input)

        While Not EOF(1)
            Input(1, MemberID)
            Input(1, Name)
        
            Console.WriteLine("Member ID is. :" & MemberID)
            Console.WriteLine("Member name :" & Name)
      
        End While
        FileClose(1)

        Console.ReadKey()

    End Sub

End Module
