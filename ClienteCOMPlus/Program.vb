Module modMain
    Sub Main()
        Dim objCOMPlus As New COMPlusJumpStart.COMPlusServices()

        Console.WriteLine(objCOMPlus.DoTransaction())
        Console.ReadLine()
    End Sub
End Module