'Jason Permann
'Spring 2025
'RCET2265
'Fortune Cookie
'https://github.com/JaceFoxman/FortuneCookie.git

Option Explicit On
Option Strict On
Option Compare Text

Module FortuneCookie

    Sub Main()
        Console.Write("Choosing Your Wisdom: ")
        Console.WriteLine(RandomNumber(1, 10))
        Console.WriteLine()
        Console.Write("Here is your fortune: ")

        Select Case RandomNumber(1, 10)

            Case = 1
                Console.WriteLine("Don’t worry about money. The best things in life are free.")
                Console.WriteLine()
            Case = 2
                Console.WriteLine("Hard work pays off in the future. Laziness pays off now.")
                Console.WriteLine()
            Case = 3
                Console.WriteLine("Change is inevitable, except for vending machines.")
                Console.WriteLine()
            Case = 4
                Console.WriteLine("Okay to look at past and future. Just don’t stare.")
                Console.WriteLine()
            Case = 5
                Console.WriteLine("The wise man is the one that makes you think that he is dumb.")
                Console.WriteLine()
            Case = 6
                Console.Write("Of all our human resources, the most precious is the desire to improve.")
                Console.WriteLine()
            Case = 7
                Console.Write("Success lies in the hands of those who wants it.")
                Console.WriteLine()
            Case = 8
                Console.Write("Age is high price to pay for maturity.")
                Console.WriteLine()
            Case = 9
                Console.Write("If at first you don’t succeed, skydiving not for you.")
                Console.WriteLine()
            Case = 10
                Console.Write("A conclusion is simply the place where you got tired of thinking.")
                Console.WriteLine()
        End Select




    End Sub

    Function RandomNumber(min As Integer, max As Integer) As Integer
        Dim number As Single
        Randomize() 'initalizes randomizer
        number = Rnd()
        number *= max - min 'sets range
        number += min
        Return CInt(number)
    End Function

End Module