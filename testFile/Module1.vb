Imports System.IO

Module Module1
    Sub Main()
        Console.WriteLine(IO.Path.GetFileNameWithoutExtension(IO.Path.GetRandomFileName()))

    End Sub
End Module
