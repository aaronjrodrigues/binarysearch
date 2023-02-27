Module Module1

    Sub Main()
        Dim Array() As Integer = {0, 2, 2, 3, 4, 8, 25, 27, 35, 47}
        Dim Query, Half, FoundPos As Integer
        Dim Found As Boolean

        Found = False

        Console.WriteLine("Enter search query")
        Query = Console.ReadLine

        Half = 5

        Do
            If Array(Half) > Half Then
                Half = CInt(Half / 2) + Half

            End If

            If Array(Half) = Query Then
                Found = True
                FoundPos = Half
            End If

            If Array(Half) < Query Then
                Half = Half - CInt(Half / 2)
            End If

        Loop Until Found = True Or Half = 1 Or Half = 9


    End Sub

End Module
