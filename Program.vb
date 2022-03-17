Imports System
Imports System.Text

Module Program


    Sub Main(args As String())
        Dim s As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789"
        Dim r As New Random
        Dim sb As New StringBuilder
        For i As Integer = 1 To 8
            Dim idx As Integer = r.Next(0, 35)
            sb.Append(s.Substring(idx, 1))
        Next

        Console.WriteLine("Password Generator - Version 0.1")
        Console.WriteLine("Made By IsEmil")
        Console.WriteLine("")
        Console.WriteLine("")
        Console.WriteLine("Your Generated Password:")
        Console.WriteLine(sb.ToString())
    End Sub
End Module
