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

        'Dim numTwo As String
        ''numTwo = Console.ReadLine()
        'secondNumber = CInt(numTwo)
        'multiNumtwo = 1 * multiNumtwo
        'Console.WriteLine($"{multiNumtwo} ")
        'multiNumtwo = multiNumtwo + 1
        'Console.ReadLine()
        'Left()

        Dim firstNumber As Integer
        Dim multiNum As Integer
        Dim multiNumTwo As Integer
        Dim numOne As String
        Dim lineCheck As Integer
        Console.WriteLine("Num one is for loop and num two is num in loop")
        numOne = Console.ReadLine()
        firstNumber = CInt(numOne)

        Do Until multiNum = firstNumber

            multiNum = 1 + multiNum
            Console.WriteLine($"/////{multiNum}/////")
            For i As Integer = 1 To firstNumber

                Console.Write("{0} ", i * multiNum)



            Next
            Console.WriteLine()
        Loop
        'For i = 1 To firstNumber
        '    multiNum = 1 * multiNum

        '    Console.Write($"{multiNum} ")

        '    multiNum = 1 + multiNum
        'Next

        'For i = 1 To firstNumber
        '    multiNumTwo = 1 * multiNumTwo


        '    Console.WriteLine($"{multiNumTwo} ")

        '    multiNumTwo = 1 + multiNumTwo
        'Next

        Console.ReadLine()
    End Sub
    Sub Left()



    End Sub
End Module
