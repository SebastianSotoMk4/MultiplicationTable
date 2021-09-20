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
        Dim writeNumber As String
        Dim numberCheck As Boolean
        Do
            Console.WriteLine("Enter a number:")
            userInput = Console.ReadLine()
            Console.WriteLine($"Enjoy your {userInput} x {userInput} Multiplication Table:")
            Try
                userNumber = CInt(userInput)
                numberCheck = True
            Catch ex As Exception
                Console.WriteLine("Please enter a number")
            End Try
        Loop Until numberCheck = True
        '(1 + storedNumber) * i = writeNumber
        'storedNumber = previous number, it will start at 0
        'i = amount of loops 
        'writeNumber = the number to be writen to the console.
        Do
            storedNumber = 1 + storedNumber
            For i As Integer = 1 To userNumber
                writeNumber = CStr(i * storedNumber).PadLeft(4)
                Console.Write(writeNumber)
            Next
            Console.WriteLine()
        Loop Until storedNumber = userNumber
        Console.ReadLine()
    End Sub
End Module