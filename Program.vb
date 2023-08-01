Imports System

Module Program
    Sub Main(args As String())
        Dim variable As Integer
        Console.WriteLine("Hello World!")
        Do Until variable = 4
            Console.WriteLine("esta es la opcion 1")
            Console.WriteLine("esta es la opcion 2")
            Console.WriteLine("opcion 3")
            Console.WriteLine("SALIR")
            variable = Console.ReadLine
            If variable = 1 Then
                Console.WriteLine("esto es opcion 1")
            ElseIf variable = 2 Then
                Console.WriteLine("esto es opcion 2")
            ElseIf variable = 4 Then
                Console.WriteLine("esto es opcion 3")
            End If
            Console.WriteLine("esto es opcion 4")
        Loop
    End Sub
End Module
