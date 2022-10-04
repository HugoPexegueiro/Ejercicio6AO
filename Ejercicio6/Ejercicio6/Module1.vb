Module Module1

    Sub Main()
        Dim a, b, c, d, menor As Integer
        a = Convert.ToInt32(InputBox("Introduzca el primer numero"))
        b = Convert.ToInt32(InputBox("Introduzca el segundo numero"))
        c = Convert.ToInt32(InputBox("Introduzca el tercer numero"))
        d = Convert.ToInt32(InputBox("Introduzca el cuarto numero"))
        If a > b Then
            menor = b
        Else
            menor = a
        End If
        If menor > c Then
            menor = c
            If menor > d Then
                menor = d
                Console.WriteLine("El numero menor es " & menor)
            Else
                Console.WriteLine("El numero menor es " & menor)
            End If
        Else
            If menor > d Then
                menor = d
                Console.WriteLine("El numero menor es " & menor)
            Else
                Console.WriteLine("El numero menor es " & menor)
            End If
        End If
        Console.ReadLine()
    End Sub

End Module
