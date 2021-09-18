'Sebastian Soto
'RCET0265
'Fall 2021
'BetterCalculator
'https://github.com/SebastianSotoMk4/MultiplicationTable.git
Option Strict On
Option Explicit On
Option Compare Text
Module MultiplicationTable
    Sub Main()
        Dim userNumber As Integer
        Dim storedNumber As Integer
        Dim userInput As String
        Dim numberCheck As Boolean

        Do
            Console.WriteLine("Enter a number:")
            userInput = Console.ReadLine()
            Try
                userNumber = CInt(userInput)
                numberCheck = True
            Catch ex As Exception
                Console.WriteLine("Please enter a number")
            End Try
        Loop Until numberCheck = True

        Do Until storedNumber = userNumber

            storedNumber = 1 + storedNumber
            For i As Integer = 1 To userNumber

                Console.Write("{0} ", i * storedNumber)

            Next
            Console.WriteLine()
        Loop
        Console.ReadLine()
    End Sub
End Module
