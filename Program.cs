using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Napisz aplikację, grę FizzBuzz. Gra ta na podstawie przekazanej liczby zwraca odpowiedni wynik.
            Zasady gry:
                -Jeżeli liczba użytkownika będzie podzielna przez 3 bez reszty, to powinien zostać zwrócony wynik „Fizz”.
                -Jeżeli liczba użytkownika będzie podzielna przez 5 bez reszty, to powinien zostać zwrócony wynik „Buzz”.
                -Jeżeli liczba użytkownika będzie podzielna przez 3 i przez 5 jednocześnie bez reszty, to powinien zostać
                 zwrócony wynik „FizzBuzz”.
                -Jeżeli liczba użytkownika nie będzie podzielna przez 3 ani przez 5 bez reszty, to wtedy zwracasz podaną liczbę.
            Niech to będzie nowa metoda niestatyczna w osobnej klasie o nazwie FizzBuzz. Najlepiej jak sama metoda będzie zwracała string’a,
            który zostanie zwrócony i wyświetlony w klasie Program w metodzie Main.
             */
            Console.WriteLine("Gra FizzBuzz. Podaj dowolną liczbę:");
            var fizzBuzz = new FizzBuzz();
            while (true)
            {
                var yourNumber = GetNumber();
                Console.WriteLine(fizzBuzz.OutputNumber(yourNumber));
                Console.WriteLine();
            }

        }

        private static int GetNumber()
        {
            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out int yourNumber))
                {
                    Console.WriteLine("wprowadziłeś błębne dane, spróbuj ponownie");
                    continue;
                }
                return yourNumber;
            }
            
            
          
            
        }
    }
}
