
Imports System

Imports System.Numerics

Imports System.Security.Cryptography

Module Program

    Sub Main(args As String())

        Dim cislo As Object
        Dim vysledek As Integer = 1
        Console.WriteLine("Zadej ��slo")

        cislo = Console.ReadLine

        If Not IsNumeric(cislo) Then

            Console.WriteLine(" Vstup mus� b�t ��slo ")

            Console.ReadKey()

            End

        End If

        If cislo > 10 Then

            Console.WriteLine(" ��slo mus� b�t men�� ")

            Console.ReadKey()

            End

        End If

        If cislo < 0 Then

            Console.WriteLine(" minim�ln� zadan� ��slo mus� b�t 1")

            Console.ReadKey()

            End

        End If

        For i As Integer = 1 To cislo

            vysledek *= i

        Next

        Console.WriteLine($"faktori�l zadan�ho ��sla {cislo} je {vysledek}")

    End Sub

End Module