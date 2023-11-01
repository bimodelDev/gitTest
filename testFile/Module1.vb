Imports System.IO
Imports Inventor

Module Module1
    Dim defaultPath As String = "C:\Users\bimodel3\Desktop\exportedFiles"
    Dim definedFilesDict As Dictionary(Of String, String) = New Dictionary(Of String, String) From {
    {"", "EdgeGuard"},
    {"L", "EdgeGuardLeft"},
    {"R", "EdgeGuardRight"}}


    Dim invApp As Inventor.Application = Nothing
    Public Sub openTheFile(pDoorSide As String, pProfileType As String)

        With invApp.Documents
            If definedFilesDict.ContainsKey(pDoorSide) Then
                .Open(System.IO.Path.Combine(defaultPath, definedFilesDict(pDoorSide) + ".idw"), True)
            End If
        End With

        Select Case pDoorSide
            Case "L"
                If pProfileType = "548" Then MsgBox("This MsgBox for L 548")
                If pProfileType = "538" Then MsgBox("This MsgBox for L 538")
            Case "R"
                If pProfileType = "528" Then MsgBox("This MsgBox for R 538")
            Case ""
                If pProfileType = "528" Then MsgBox("This MsgBox for Standard 528")
        End Select
    End Sub

    Sub Main()
        invApp = Activator.CreateInstance(Type.GetTypeFromProgID("Inventor.Application"))
        invApp.Visible = True
        Dim doorSide As String = ""
        Dim profileType As String = ""

        For i As Integer = 0 To 2
            doorSide = Console.ReadLine()
            profileType = Console.ReadLine()
            openTheFile(doorSide, profileType)
        Next

        'If doorSide = "L" Then
        '    invApp.Documents.Open(System.IO.Path.Combine(defaultPath, definedFilesDict("L") + ".idw"), True)

        'End If



        'With invApp.Documents
        '    If doorSide = "L" Then .Open(System.IO.Path.Combine(defaultPath, definedFilesDict("L") + ".idw"), True)
        'End With

        GC.Collect() ' Start .NET CLR Garbage Collection
        GC.WaitForPendingFinalizers() ' Wait for Garbage Collection to finish
    End Sub
End Module
