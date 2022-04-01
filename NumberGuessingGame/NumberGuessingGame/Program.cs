using System;

namespace NumberGuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            bool playAgain = true;
            int min = 1;
            int max = 100;
            int guess;
            int number;
            int guesses;
            string response;

            Console.WriteLine("-----------Sayı Tahmin Oyunu-----------");

            while (playAgain)
            {
                guess = 0;
                guesses = 0;
                response = "";
                number = random.Next(min, max + 1);

                while (guess != number)
                {
                    Console.WriteLine(min + " ile " + max + " arasında bir sayı tahmin edin: ");
                    guess = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Tahmininiz: " + guess);

                    if (guess > number)
                    {
                        Console.WriteLine(guess +  " sayısı çok büyük.");
                    }
                    else if (guess < number)
                    {
                        Console.WriteLine(guess + " sayısı çok küçük.");
                    }
                    guesses++;
                }
                Console.WriteLine("Sayı: " + number);
                Console.WriteLine("Kazandınız!");
                Console.WriteLine("Tahmin Sayısı: " + guesses);

                Console.WriteLine("Tekrar oynamak ister misiniz? (Evet/Hayır): ");
                response = Console.ReadLine();
                response = response.ToUpper();

                if (response == "EVET")
                {
                    playAgain = true;
                    Console.WriteLine("----------------------------");
                }
                else
                {
                    playAgain = false;
                }
            }

            Console.WriteLine("Oynadığınız için teşekkürler!");
            Console.ReadKey();
        }
    }
}
