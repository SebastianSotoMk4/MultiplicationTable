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
        Dim firstNumber As Integer
        Dim secondNumber As Integer
        Dim numOne As String
        Dim numTwo As String

        Console.WriteLine("Num one is for loop and num two is num in loop")
        numOne = Console.ReadLine()
        firstNumber = CInt(numOne)
        numTwo = Console.ReadLine()
        secondNumber = CInt(numTwo)


        For i = 1 To firstNumber
            Console.WriteLine($"{secondNumber}")

        Next

        Console.ReadLine()

    End Sub

End Module
