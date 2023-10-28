Module Module1
    Public Class ZeroDivisonError : Inherits Exception
        Public Sub New()
            Console.WriteLine("ZeroDivisionError")
        End Sub
    End Class
    Sub Main()
        Dim numerator As Integer = 15
        Dim Denominator As Integer = 0
        If Denominator = 0 Then
            Throw New ZeroDivisonError()
        End If
    End Sub
End Module