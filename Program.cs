namespace RateSpielDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Willkommen beim Ratespiel");
            Random random = new Random(); // feneriert neue ZUfällige Zahl 
            int goalNumber = random.Next(1, 101);
            int maxAttempts = 5;
            int attempts = 0; // bevor man was eingibt werden die versuche auf null gesetzt weil man noch nichts eingegeben hat 
            bool guessed = false;

            while (!guessed && attempts < maxAttempts) //! = schleife läuft weiter solange man nicht gewinnt 
            {
                Console.Write("Geben Sie Ihre Vermutung ein (1-100): ");
                string eingabe = Console.ReadLine();

                if (int.TryParse(eingabe, out int guess))
                {
                    attempts++;

                    if (guess < goalNumber)
                    {
                        Console.WriteLine("Zu niedrig!");
                    }
                    else if (guess > goalNumber)
                    {
                        Console.WriteLine("Zu hoch!");
                    }
                    else
                    {
                        guessed = true;
                        Console.WriteLine($"Sie haben die richtige Zahl in {attempts} Versuchen erraten!");
                    }

                    // Motivationsspruch nach jedem Versuch
                    GibMotivationsspruch();
                }
                else
                {
                    Console.WriteLine("Ungültige Eingabe");
                }
            }

            if (!guessed)
            {
                Console.WriteLine($"Leider keine richtige Zahl in {maxAttempts} Versuchen erraten. Die richtige Zahl war {goalNumber}.");
            }

            Console.ReadLine();
        }

        static void GibMotivationsspruch()
        {

            string[] motivationssprueche = {
            "Gut gemacht! Weiter so!",
            "Du bist auf dem richtigen Weg!",
            "Nicht aufgeben, du kommst näher!",
            "Fantastisch! Du schaffst das!",

        };

            Random random = new Random();
            int index = random.Next(motivationssprueche.Length);

            Console.WriteLine($"Motivation: {motivationssprueche[index]}");
        }
    }
}
    

